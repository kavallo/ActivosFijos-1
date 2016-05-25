Imports Citi.Synergia.HelperClient

Public Class MONEDM02
    Private CENTRO_SUCUR_ESTRUCT As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.SetupLlaves()

        If Not String.IsNullOrEmpty(TraeDato("Select IsNull(CENTRO_SUCUR_ESTRUCT,'E') From PARAMETRO_GENERALES Where COMPANIA = 'PA'")) Then
            CENTRO_SUCUR_ESTRUCT = TraeDato("Select IsNull(CENTRO_SUCUR_ESTRUCT,'E') From PARAMETRO_GENERALES Where COMPANIA = 'PA'").ToString
        End If

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False

        'Para sucursales no exhigimos centro
        '-----------------------------------
        If CENTRO_SUCUR_ESTRUCT = "E" Then
            chkREEMPLAZA_CENTRO_OPE.Visible = False
            chkREEMPLAZA_CENTRO_OPE.Checked = False
            lblTitCODIGO_CENTRO.Visible = True
            txtCODIGO_CENTRO.Visible = True
            lblDESCRIPCION.Visible = True
        Else
            chkREEMPLAZA_CENTRO_OPE.Visible = True
            If Modo = Modo_Alta Then
                chkREEMPLAZA_CENTRO_OPE.Checked = False
            End If

            If chkREEMPLAZA_CENTRO_OPE.Checked Then
                lblTitCODIGO_CENTRO.Visible = True
                txtCODIGO_CENTRO.Visible = True
                lblDESCRIPCION.Visible = True
            Else
                lblTitCODIGO_CENTRO.Visible = False
                txtCODIGO_CENTRO.Text = ""
                lblDESCRIPCION.Text = ""
                txtCODIGO_CENTRO.Visible = False
                lblDESCRIPCION.Visible = False
            End If
        End If

        Me.ValoresDefault()
    End Sub

    Private Sub ValoresDefault()
        Dim cantidad As Integer = 0

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from CATALOGO_CONT_ENC")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from CATALOGO_CONT_ENC"), Integer)
            If cantidad = 1 Then
                Me.txtTIPO_CATALOGO.Text = TraeDato("Select TIPO_CATALOGO From CATALOGO_CONT_ENC").ToString
                Me.Codigos_Leave(txtTIPO_CATALOGO, Nothing)
                Me.txtTIPO_CATALOGO.Enabled = False
                Me.lblTitTIPO_CATALOGO.Enabled = False
            End If
        End If
    End Sub

    Private Sub SetupLlaves()
        If CENTRO_SUCUR_ESTRUCT = "E" Or chkREEMPLAZA_CENTRO_OPE.Checked Then
            'MAYGEC01()
            txtCUENTA_CONTABLE.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Else
            'CACODC03()
            txtCUENTA_CONTABLE.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCatalogoContablePorTipoDeCatalogo_CACODC03
        End If

        txtCODIGO_CENTRO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCUENTA_CONTABLE.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCUENTA_CONTABLE.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCODIGO_CENTRO))
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Modo <> Modo_Alta Then
            If Acción And cp_POP Then txtCODIGO_DE_MONEDA.Text = Pop()
        End If
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL(" SELECT MONEDAS.DESCRIPCION_MONEDA")
                meteSQL("      , MONEDAS.SIGNO_DE_MONEDA")
                meteSQL("      , MONEDAS.TIPO_CATALOGO")
                meteSQL("      , CATALOGO_CONT_ENC.NOMBRE_CATALOGO")
                meteSQL("      , MONEDAS.CODIGO_CENTRO")
                meteSQL("      , CENTROS.DESCRIPCION")
                meteSQL("      , CATALOGO_CONT_DET.CUENTA_CONTABLE")
                meteSQL("      , MONEDAS.NOMBRE_FRACCION_MONE")
                meteSQL("      , ISNULL(MONEDAS.REEMPLAZA_CENTRO_OPE, 'N') AS Expr1")
                meteSQL("      , IsNull(MONEDAS.ID_MONEDA_BCOSMOS, '') As ID_MONEDA_BCOSMOS")
                meteSQL("      , IsNull(MONEDAS.MONEDA_DEFAULT, 0) As MONEDA_DEFAULT")
                meteSQL("      , MONEDAS.timestamp")
                meteSQL("   FROM CATALOGO_CONT_ENC RIGHT OUTER JOIN")
                meteSQL("        MONEDAS ON CATALOGO_CONT_ENC.TIPO_CATALOGO = MONEDAS.TIPO_CATALOGO LEFT OUTER JOIN")
                meteSQL("        CENTROS ON MONEDAS.CODIGO_CENTRO = CENTROS.CODIGO_CENTRO LEFT OUTER JOIN")
                meteSQL("        CATALOGO_CONT_DET ON MONEDAS.CUENTA_CONTABLE = CATALOGO_CONT_DET.CUENTA_CONTABLE")
                meteSQL("  WHERE MONEDAS.CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDESCRIPCION_MONEDA.Text = SqlData(Sqlconn, 1).ToString
                    txtSIGNO_DE_MONEDA.Text = SqlData(Sqlconn, 2).ToString
                    txtTIPO_CATALOGO.Text = SqlData(Sqlconn, 3).ToString
                    lblNOMBRE_CATALOGO.Text = SqlData(Sqlconn, 4).ToString
                    txtCODIGO_CENTRO.Text = SqlData(Sqlconn, 5).ToString
                    lblDESCRIPCION.Text = SqlData(Sqlconn, 6).ToString
                    txtCUENTA_CONTABLE.Text = SqlData(Sqlconn, 7).ToString
                    txtNOMBRE_FRACCION_MONE.Text = SqlData(Sqlconn, 8).ToString
                    chkREEMPLAZA_CENTRO_OPE.Checked = IIf(SqlData(Sqlconn, 9).ToString = "S", True, False)
                    txtMonedaCosmos.Text = SqlData(Sqlconn, 10).ToString
                    chkDefault.Checked = SqlData(Sqlconn, 11)

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop

                'Descripcion de la cuenta contable
                Me.DescripcionCuenta()
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_DE_MONEDA.Enabled = False
                lblTitCODIGO_DE_MONEDA.Enabled = False
            End If

            Me.Codigos_Leave(txtTIPO_CATALOGO, Nothing)
            Me.Codigos_Leave(txtCODIGO_CENTRO, Nothing)
            Me.Codigos_Leave(txtCUENTA_CONTABLE, Nothing)


        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DescripcionCuenta()
        'Descripcion de la cuenta contable
        lblDESC_CUENTA_CONTABLE.Text = DescripcionesDB.Cuentas(txtTIPO_CATALOGO.Text, txtCUENTA_CONTABLE.Text)
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                Me.chkDefault.Checked = False
                Me.Codigos_Leave(txtTIPO_CATALOGO, Nothing)
                Me.Codigos_Leave(txtCODIGO_CENTRO, Nothing)
                Me.Codigos_Leave(txtCUENTA_CONTABLE, Nothing)
                Me.ValoresDefault()
                Me.txtCODIGO_DE_MONEDA.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                Me.txtCODIGO_DE_MONEDA.Text = Pop()
                Me.Leer()
                Me.ValoresDefault()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ReemplazaCentro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkREEMPLAZA_CENTRO_OPE.CheckedChanged
        If chkREEMPLAZA_CENTRO_OPE.Checked Then
            lblTitCODIGO_CENTRO.Visible = True
            txtCODIGO_CENTRO.Visible = True
            lblDESCRIPCION.Visible = True
        Else
            If chkREEMPLAZA_CENTRO_OPE.Visible Then
                lblTitCODIGO_CENTRO.Visible = False
                txtCODIGO_CENTRO.Text = ""
                lblDESCRIPCION.Text = ""
                txtCODIGO_CENTRO.Visible = False
                lblDESCRIPCION.Visible = False
            End If
        End If
    End Sub

    Private Sub TipoCatalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitTIPO_CATALOGO.DoubleClick
        txtTIPO_CATALOGO.GenerarConsulta()
    End Sub

    Private Sub CodigoCentro_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_CENTRO.DoubleClick
        txtCODIGO_CENTRO.GenerarConsulta()
    End Sub

    Private Sub CuentaContable_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCUENTA_CONTABLE.DoubleClick
        txtCUENTA_CONTABLE.GenerarConsulta()
    End Sub

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIPO_CATALOGO.Leave, txtCODIGO_CENTRO.Leave, txtCUENTA_CONTABLE.Leave
        Select Case sender.Name
            Case "txtTIPO_CATALOGO"
                lblNOMBRE_CATALOGO.Text = DescripcionesDB.NombreCatalogoContable(txtTIPO_CATALOGO.Text)
            Case "txtCODIGO_CENTRO"
                lblDESCRIPCION.Text = DescripcionesDB.CentroPorCatalogo(txtTIPO_CATALOGO.Text, txtCODIGO_CENTRO.Text)
            Case "txtCUENTA_CONTABLE"
                lblDESC_CUENTA_CONTABLE.Text = DescripcionesDB.Cuentas(txtTIPO_CATALOGO.Text, txtCUENTA_CONTABLE.Text)
        End Select
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            'txtCODIGO_CENTRO.EsRequerido = chkREEMPLAZA_CENTRO_OPE.Checked

            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If
        End If

        V = V & "  @CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text)
        V = V & ", @DESCRIPCION_MONEDA = " & Scm(txtDESCRIPCION_MONEDA.Text)
        V = V & ", @SIGNO_DE_MONEDA = " & Scm(txtSIGNO_DE_MONEDA.Text)
        V = V & ", @TIPO_CATALOGO = " & Scm(txtTIPO_CATALOGO.Text)
        V = V & ", @CODIGO_CENTRO = " & Scm(txtCODIGO_CENTRO.Text)
        V = V & ", @CUENTA_CONTABLE = " & Scm(txtCUENTA_CONTABLE.Text)
        V = V & ", @NOMBRE_FRACCION_MONE = " & Scm(txtNOMBRE_FRACCION_MONE.Text)
        V = V & ", @REEMPLAZA_CENTRO_OPE = " & Scm(IIf(chkREEMPLAZA_CENTRO_OPE.Checked, "S", "N"))
        V = V & ", @ID_MONEDA_BCOSMOS = " & Scm(txtMonedaCosmos.Text)
        V = V & ", @MONEDA_DEFAULT = " & sen(IIf(chkDefault.Checked, 1, 0))

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("MONEDAS", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class