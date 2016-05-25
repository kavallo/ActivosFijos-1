Imports Citi.Synergia.HelperClient

Public Class DIVISM01
    Private mascara As String = String.Empty
    Private sinValor As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LeerPosicion = True

        Modo = Modo_Local

        MyBase.Limpiar()

        Me.SetupLlaves()

        Me.LimpiarLabels()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub SetupLlaves()
        txtCODIGO_CENTRO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCODIGO_CENTRO_PXP.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCODIGO_CENTRO_SXP.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCENTRO_GSTO_PATRONAL.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))

        txtCUENTA_CONTABLE.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCUENTA_CONTABLE.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCODIGO_CENTRO))

        txtCUENTA_CONTABLE_PXP.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCUENTA_CONTABLE_PXP.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCODIGO_CENTRO_PXP))

        txtCUENTA_CONTABLE_SXP.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCUENTA_CONTABLE_SXP.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCODIGO_CENTRO_SXP))

        txtCUENTA_GSTO_PATRONAL.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCUENTA_GSTO_PATRONAL.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtCENTRO_GSTO_PATRONAL))
    End Sub

    Private Sub LimpiarLabels()
        lblNOMBRE_CATALOGO.Text = ""
        lblDESCRIPCION.Text = ""
        lblDESCRIPCION_CUENTA.Text = ""
        lblDESCRIPCION_SXP.Text = ""
        lblDESCRIPCION_CUENTA_SXP.Text = ""
        lblDESCRIPCION_PXP.Text = ""
        lblDESCRIPCION_CUENTA_PXP.Text = ""
        lblDESC_CEN_GASTOS_PAT.Text = ""
        lblDESC_CTA_GASTOS_PAT.Text = ""
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        Dim valor As String = String.Empty
        If Acción And cp_POP Then valor = Pop()
        If valor.Length > 0 Then
            txtCODIGO_DIVISION.Text = valor & Mid(txtCODIGO_DIVISION.Text, Len(valor) + 1, 10 - Len(valor))
        Else
            txtCODIGO_DIVISION.Text = valor
        End If
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL(" SELECT DIVISIONES.DESCRIPCION_DIVISION, DIVISIONES.RESPONSABLE_DIVISION, DIVISIONES.DIRECCION_DIVISION, DIVISIONES.TELEFONO_DIVISION,")
                meteSQL("        DIVISIONES.TIPO_CATALOGO, CATALOGO_CONT_ENC.NOMBRE_CATALOGO, DIVISIONES.CODIGO_CENTRO, CENTROS.DESCRIPCION,")
                meteSQL("        DIVISIONES.CUENTA_CONTABLE, DIVISIONES.CODIGO_CENTRO_SXP, DIVISIONES.CUENTA_CONTABLE_SXP, DIVISIONES.CODIGO_CENTRO_PXP,")
                meteSQL("        DIVISIONES.CUENTA_CONTABLE_PXP, DIVISIONES.CENTRO_GSTO_PATRONAL, DIVISIONES.CUENTA_GSTO_PATRONAL,")
                meteSQL("        DIVISIONES.Timestamp")
                meteSQL(" FROM   CATALOGO_CONT_DET RIGHT OUTER JOIN")
                meteSQL("        DIVISIONES ON CATALOGO_CONT_DET.TIPO_CATALOGO = DIVISIONES.TIPO_CATALOGO AND")
                meteSQL("        CATALOGO_CONT_DET.CUENTA_CONTABLE = DIVISIONES.CUENTA_CONTABLE LEFT OUTER JOIN")
                meteSQL("        CENTROS ON DIVISIONES.CODIGO_CENTRO = CENTROS.CODIGO_CENTRO LEFT OUTER JOIN")
                meteSQL("        CATALOGO_CONT_ENC ON DIVISIONES.TIPO_CATALOGO = CATALOGO_CONT_ENC.TIPO_CATALOGO")
                meteSQL(" WHERE  DIVISIONES.CODIGO_DIVISION = " & Scm(txtCODIGO_DIVISION.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDESCRIPCION_DIVISION.Text = SqlData(Sqlconn, 1).ToString
                    txtRESPONSABLE_DIVISION.Text = SqlData(Sqlconn, 2).ToString
                    txtDIRECCION_DIVISION.Text = SqlData(Sqlconn, 3).ToString
                    txtTELEFONO_DIVISION.Text = SqlData(Sqlconn, 4).ToString
                    txtTIPO_CATALOGO.Text = SqlData(Sqlconn, 5).ToString
                    lblNOMBRE_CATALOGO.Text = SqlData(Sqlconn, 6).ToString
                    txtCODIGO_CENTRO.Text = SqlData(Sqlconn, 7).ToString
                    lblDESCRIPCION.Text = SqlData(Sqlconn, 8).ToString
                    txtCUENTA_CONTABLE.Text = SqlData(Sqlconn, 9).ToString
                    txtCODIGO_CENTRO_SXP.Text = SqlData(Sqlconn, 10).ToString
                    txtCUENTA_CONTABLE_SXP.Text = SqlData(Sqlconn, 11).ToString
                    txtCODIGO_CENTRO_PXP.Text = SqlData(Sqlconn, 12).ToString
                    txtCUENTA_CONTABLE_PXP.Text = SqlData(Sqlconn, 13).ToString
                    txtCENTRO_GSTO_PATRONAL.Text = SqlData(Sqlconn, 14).ToString
                    txtCUENTA_GSTO_PATRONAL.Text = SqlData(Sqlconn, 15).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                Me.txtCODIGO_DIVISION.Enabled = False
            End If
            Me.lblTitCODIGO_DIVISION.Enabled = Me.txtCODIGO_DIVISION.Enabled


            '-- Descripciones
            Me.DescripcionesCentro(txtCODIGO_CENTRO, Nothing)
            Me.DescripcionesCentro(txtCODIGO_CENTRO_PXP, Nothing)
            Me.DescripcionesCentro(txtCODIGO_CENTRO_SXP, Nothing)
            Me.DescripcionesCentro(txtCENTRO_GSTO_PATRONAL, Nothing)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                Me.LimpiarLabels()
                Me.txtCODIGO_DIVISION.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                Me.txtCODIGO_DIVISION.Text = Pop()
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub DescripcionesCentro(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODIGO_CENTRO.Leave, txtCODIGO_CENTRO_PXP.Leave, txtCODIGO_CENTRO_SXP.Leave, txtCENTRO_GSTO_PATRONAL.Leave
        Select Case sender.name
            Case "txtCODIGO_CENTRO"
                lblDESCRIPCION.Text = DescripcionesDB.CentroPorCatalogo(txtTIPO_CATALOGO.Text, txtCODIGO_CENTRO.Text)
            Case "txtCODIGO_CENTRO_PXP"
                lblDESCRIPCION_PXP.Text = DescripcionesDB.CentroPorCatalogo(txtTIPO_CATALOGO.Text, txtCODIGO_CENTRO_PXP.Text)
            Case "txtCODIGO_CENTRO_SXP"
                lblDESCRIPCION_SXP.Text = DescripcionesDB.CentroPorCatalogo(txtTIPO_CATALOGO.Text, txtCODIGO_CENTRO_SXP.Text)
            Case "txtCENTRO_GSTO_PATRONAL"
                lblDESC_CEN_GASTOS_PAT.Text = DescripcionesDB.CentroPorCatalogo(txtTIPO_CATALOGO.Text, txtCENTRO_GSTO_PATRONAL.Text)
        End Select
    End Sub

    Private Sub TitTIPO_CATALOGO_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitTIPO_CATALOGO.DoubleClick
        txtTIPO_CATALOGO.GenerarConsulta()
    End Sub

    Private Sub TIPO_CATALOGO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTIPO_CATALOGO.TextChanged
        'lblNOMBRE_CATALOGO.Text = ""
        'If Not String.IsNullOrEmpty(txtTIPO_CATALOGO.Text) Then
        lblNOMBRE_CATALOGO.Text = DescripcionesDB.NombreCatalogoContable(txtTIPO_CATALOGO.Text)
        'End If
    End Sub

    Private Sub TitCODIGO_CENTRO_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_CENTRO.DoubleClick, lblTitCODIGO_CENTRO_SXP.DoubleClick, lblTitCODIGO_CENTRO_PXP.DoubleClick, lblTitCENTRO_GSTO_PATRONAL.DoubleClick
        Select Case sender.name
            Case "lblTitCODIGO_CENTRO"
                txtCODIGO_CENTRO.GenerarConsulta()
            Case "lblTitCODIGO_CENTRO_SXP"
                txtCODIGO_CENTRO_SXP.GenerarConsulta()
            Case "lblTitCODIGO_CENTRO_PXP"
                txtCODIGO_CENTRO_PXP.GenerarConsulta()
            Case "lblTitCENTRO_GSTO_PATRONAL"
                txtCENTRO_GSTO_PATRONAL.GenerarConsulta()
        End Select

    End Sub

    Private Sub DescripcionesCuenta(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCUENTA_CONTABLE.TextChanged, txtCUENTA_CONTABLE_PXP.TextChanged, txtCUENTA_CONTABLE_SXP.TextChanged, txtCUENTA_GSTO_PATRONAL.TextChanged
        Dim cadena As String = DescripcionesDB.Cuentas(txtTIPO_CATALOGO.Text, sender.Text)
        Select Case sender.name
            Case "txtCUENTA_CONTABLE"
                lblDESCRIPCION_CUENTA.Text = cadena
            Case "txtCUENTA_CONTABLE_PXP"
                lblDESCRIPCION_CUENTA_PXP.Text = cadena
            Case "txtCUENTA_CONTABLE_SXP"
                lblDESCRIPCION_CUENTA_SXP.Text = cadena
            Case "txtCUENTA_GSTO_PATRONAL"
                lblDESC_CTA_GASTOS_PAT.Text = cadena
        End Select
    End Sub

    Private Sub TitCUENTA_CONTABLE_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCUENTA_CONTABLE.DoubleClick, lblTitCUENTA_CONTABLE_SXP.DoubleClick, lblTitCUENTA_CONTABLE_PXP.DoubleClick, lblTitCUENTA_GSTO_PATRONAL.DoubleClick
        Select Case sender.name
            Case "lblTitCUENTA_CONTABLE"
                txtCUENTA_CONTABLE.GenerarConsulta()
            Case "lblTitCUENTA_CONTABLE_SXP"
                txtCUENTA_CONTABLE_SXP.GenerarConsulta()
            Case "lblTitCUENTA_CONTABLE_PXP"
                txtCUENTA_CONTABLE_PXP.GenerarConsulta()
            Case "lblTitCUENTA_GSTO_PATRONAL"
                txtCUENTA_GSTO_PATRONAL.GenerarConsulta()
        End Select
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            MyBase.ErrorCampos.SetError(Me.txtCODIGO_DIVISION, Nothing)
            If txtCODIGO_DIVISION.Text = Me.sinValor Then
                MyBase.ErrorCampos.SetError(txtCODIGO_DIVISION, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If

            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If
        End If

        V = V & "  @CODIGO_DIVISION      = " & Scm(txtCODIGO_DIVISION.Text)
        V = V & ", @DESCRIPCION_DIVISION = " & Scm(txtDESCRIPCION_DIVISION.Text)
        V = V & ", @RESPONSABLE_DIVISION = " & Scm(txtRESPONSABLE_DIVISION.Text)
        V = V & ", @DIRECCION_DIVISION   = " & Scm(txtDIRECCION_DIVISION.Text)
        V = V & ", @TELEFONO_DIVISION    = " & Scm(txtTELEFONO_DIVISION.Text)
        V = V & ", @TIPO_CATALOGO        = " & Scm(txtTIPO_CATALOGO.Text)
        V = V & ", @CODIGO_CENTRO        = " & Scm(txtCODIGO_CENTRO.Text)
        V = V & ", @CUENTA_CONTABLE      = " & Scm(txtCUENTA_CONTABLE.Text)
        V = V & ", @CODIGO_CENTRO_SXP    = " & Scm(txtCODIGO_CENTRO_SXP.Text)
        V = V & ", @CUENTA_CONTABLE_SXP  = " & Scm(txtCUENTA_CONTABLE_SXP.Text)
        V = V & ", @CODIGO_CENTRO_PXP    = " & Scm(txtCODIGO_CENTRO_PXP.Text)
        V = V & ", @CUENTA_CONTABLE_PXP  = " & Scm(txtCUENTA_CONTABLE_PXP.Text)
        V = V & ", @CENTRO_GSTO_PATRONAL = " & Scm(txtCENTRO_GSTO_PATRONAL.Text)
        V = V & ", @CUENTA_GSTO_PATRONAL = " & Scm(txtCUENTA_GSTO_PATRONAL.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("DIVISIONES", V) Then
            'Rellenamos registros
            meteSQL("Exec sp_Genera_MG")
            EjecutaSQL("")

            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class