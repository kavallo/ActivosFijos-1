Imports Citi.Synergia.HelperClient

Public Class ACTTACM0
    Private _primerLlenado As Boolean = False

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._primerLlenado = False

        MyBase.Limpiar()

        'VERIFICA QUE EXISTA LA CONTABILIDAD INSTALADA
        If Not Me.ExisteConta() Then
            Me.EscondeFrames()
        End If

        Modo = Modo_Local

        Me.SetupLlaves()

        Me.LlenarCombos()

        Me.LimpiarDescripciones()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
            Me.HabilitaFechaActivo()
        End If

        Me.ValoresDefault()

        Grabado = False
    End Sub

    Private Sub ValoresDefault()
        Dim cantidad As Integer = 0

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from CATALOGO_CONT_ENC")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from CATALOGO_CONT_ENC"), Integer)
            If cantidad = 1 Then
                Me.txtTIPO_CATALOGO.Text = TraeDato("Select TIPO_CATALOGO From CATALOGO_CONT_ENC").ToString
                Me.TipoCatalogo_Leave(Nothing, Nothing)
                Me.txtTIPO_CATALOGO.Enabled = False
                Me.lblTitTIPO_CATALOGO.Enabled = False
            End If
        End If
    End Sub

    Function ExisteConta() As Boolean
        Dim retorno As Boolean = False

        Try
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Existe_conta"
                .Parameters.Add("@existe_conta", SqlDbType.Char, 1).Value = "S"
                .Parameters(0).Direction = ParameterDirection.InputOutput
            End With
            Dim parametro As New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@existe_conta"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Value = "S"
            End With

            EjecutarComando(comando)

            If comando.Parameters(0).Value = "S" Then
                retorno = True
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return retorno
    End Function

    Private Sub EscondeFrames()
        mhTab1.SelectedIndex = 0
        frame_Balance.Visible = False
        frame_Gastos.Visible = frame_Balance.Visible
        frame_Reevaluacion.Visible = frame_Balance.Visible
        frame_ingresos_egresos.Visible = frame_Balance.Visible
        frame_compras.Visible = frame_Balance.Visible
        frame_desecho.Visible = frame_Balance.Visible
        Frame6.Visible = frame_Balance.Visible
        Frame3.Visible = frame_Balance.Visible
        Frame5.Visible = frame_Balance.Visible

        lblTitTIPO_CATALOGO.Visible = frame_Balance.Visible
        txtTIPO_CATALOGO.Visible = frame_Balance.Visible
        lblNOMBRE_CATALOGO.Visible = frame_Balance.Visible
    End Sub

    Private Sub SetupLlaves()
        txtCODIGO_CENTRO_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCOD_CENTRO_GASTO_ACT.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCOD_CENTRO_REVALUA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCOD_CENTRO_RESULTADO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCOD_CENTRO_COMPRA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCOD_CENTRO_BAJA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCOD_CENTRO_VENTA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCENTRO_DONA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCOD_CENTRO_ACT_NODED.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))

        txtCTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCODIGO_CENTRO_ACTIVO))
        txtCTA_DEPREC_ACUM.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_DEPREC_ACUM.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCODIGO_CENTRO_ACTIVO))

        txtCTA_GASTO_DEPREC.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_GASTO_DEPREC.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_GASTO_ACT))

        txtCTA_REVALUA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_REVALUA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_REVALUA))

        txtCTA_GAN_VTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_GAN_VTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_RESULTADO))

        txtCTA_PER_VTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_PER_VTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_RESULTADO))

        txtCTA_COMPRA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_COMPRA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_COMPRA))

        txtCTA_BAJA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_BAJA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_BAJA))

        txtCTA_VENTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_VENTA_ACTIVO.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_VENTA))

        txtCUENTA_DONA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCUENTA_DONA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCENTRO_DONA))

        txtCTA_ACTIVO_NODEDUCIB.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Catálogo", txtTIPO_CATALOGO))
        txtCTA_ACTIVO_NODEDUCIB.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Centro", txtCOD_CENTRO_ACT_NODED))
    End Sub

    Private Sub LlenarCombos()
        Dim tipoDepreciacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With tipoDepreciacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(50, "D - Doble Saldo Declinante")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("L", Citi.Synergia.Traductor.Idiomas.GetMensaje(51, "L - Línea Recta")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(52, "S - Suma de Años Dígitos")))
        End With
        With cboTIPO_DEPRECIACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoDepreciacion
        End With

        Dim claseContabilizacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With claseContabilizacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(53, "A - Toma Centro de Tipo de Activo")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(54, "D - Toma Centro de División")))
        End With
        With cboCLA_CONTABILIZACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = claseContabilizacion
        End With

        Dim calculoPrimeraDepr As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With calculoPrimeraDepr
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("C", Citi.Synergia.Traductor.Idiomas.GetMensaje(55, "C - Desde Fecha de Adquisición")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(56, "M - Conforme al Mes")))
        End With
        With cboCALCULO_PRIMERA_DEPR
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = calculoPrimeraDepr
        End With

        Me._primerLlenado = False

        Dim formaDepreciacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With formaDepreciacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(57, "D - Días Calendario")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(58, "M - Meses")))
        End With
        With cboFORMA_DEPRECIACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = formaDepreciacion
        End With

        Dim noDiasAnio As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With noDiasAnio
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("360", Citi.Synergia.Traductor.Idiomas.GetMensaje(59, "360 DIAS")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("365", Citi.Synergia.Traductor.Idiomas.GetMensaje(60, "365 DIAS")))
        End With
        With cboNO_DIAS_ANIO
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = noDiasAnio
        End With
    End Sub

    Private Sub kPila(ByVal Acción As Short)
        If Acción And cp_POP Then txtCODIGO_TIPO_ACTIVO.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" TIPOS_DE_ACTIVOS.DESCRIP_TIPO_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.TIPO_DEPRECIACION, ")
                meteSQL(" IsNull(TIPOS_DE_ACTIVOS.FORZAR_FECHA_ACTIVO, 0), ")
                meteSQL(" IsNull(TIPOS_DE_ACTIVOS.MONTO_MINIMO_ACTIVO, 0), ")
                meteSQL(" IsNull(TIPOS_DE_ACTIVOS.TIEMPO_DEPRECIACION, 0), ")
                meteSQL(" TIPOS_DE_ACTIVOS.TIPO_CATALOGO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CODIGO_CENTRO_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_DEPREC_ACUM, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_GASTO_ACT, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_GASTO_DEPREC, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_RESULTADO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_GAN_VTA_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_PER_VTA_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_COMPRA, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_COMPRA_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_BAJA, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_BAJA_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_REVALUA, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_REVALUA_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_VENTA, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_VENTA_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CLA_CONTABILIZACION, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CALCULO_PRIMERA_DEPR, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_DONACION, ")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_DONACION_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.COD_CENTRO_ACT_NODED,")
                meteSQL(" TIPOS_DE_ACTIVOS.CTA_ACTIVO_NODEDUCIB,")
                meteSQL(" TIPOS_DE_ACTIVOS.FORMA_DEPRECIACION,")
                meteSQL(" TIPOS_DE_ACTIVOS.NO_DIAS_ANIO,")
                meteSQL(" IsNull(TIPOS_DE_ACTIVOS.PORCENTAJE_PARA_RESCATE, 0),")
                meteSQL(" TIPOS_DE_ACTIVOS.timestamp ")
                meteSQL("from TIPOS_DE_ACTIVOS")
                meteSQL(" where TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO = " & Scm(txtCODIGO_TIPO_ACTIVO.Text))
                meteSQL("")

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDESCRIP_TIPO_ACTIVO.Text = SqlData(Sqlconn, 1).ToString
                    cboTIPO_DEPRECIACION.SelectedValue = SqlData(Sqlconn, 2).ToString
                    txtFORZAR_FECHA_ACTIVO.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 3))
                    txtMONTO_MINIMO_ACTIVO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 4))
                    txtTIEMPO_DEPRECIACION.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 5))
                    txtTIPO_CATALOGO.Text = SqlData(Sqlconn, 6).ToString
                    txtCODIGO_CENTRO_ACTIVO.Text = SqlData(Sqlconn, 7).ToString
                    txtCTA_ACTIVO.Text = SqlData(Sqlconn, 8).ToString
                    txtCTA_DEPREC_ACUM.Text = SqlData(Sqlconn, 9).ToString
                    txtCOD_CENTRO_GASTO_ACT.Text = SqlData(Sqlconn, 10).ToString
                    txtCTA_GASTO_DEPREC.Text = SqlData(Sqlconn, 11).ToString
                    txtCOD_CENTRO_RESULTADO.Text = SqlData(Sqlconn, 12).ToString
                    txtCTA_GAN_VTA_ACTIVO.Text = SqlData(Sqlconn, 13).ToString
                    txtCTA_PER_VTA_ACTIVO.Text = SqlData(Sqlconn, 14).ToString
                    txtCOD_CENTRO_COMPRA.Text = SqlData(Sqlconn, 15).ToString
                    txtCTA_COMPRA_ACTIVO.Text = SqlData(Sqlconn, 16).ToString
                    txtCOD_CENTRO_BAJA.Text = SqlData(Sqlconn, 17).ToString
                    txtCTA_BAJA_ACTIVO.Text = SqlData(Sqlconn, 18).ToString
                    txtCOD_CENTRO_REVALUA.Text = SqlData(Sqlconn, 19).ToString
                    txtCTA_REVALUA_ACTIVO.Text = SqlData(Sqlconn, 20).ToString
                    txtCOD_CENTRO_VENTA.Text = SqlData(Sqlconn, 21).ToString
                    txtCTA_VENTA_ACTIVO.Text = SqlData(Sqlconn, 22).ToString
                    cboCLA_CONTABILIZACION.SelectedValue = SqlData(Sqlconn, 23).ToString
                    cboCALCULO_PRIMERA_DEPR.SelectedValue = SqlData(Sqlconn, 24).ToString
                    txtCENTRO_DONA.Text = SqlData(Sqlconn, 25).ToString
                    txtCUENTA_DONA.Text = SqlData(Sqlconn, 26).ToString
                    txtCOD_CENTRO_ACT_NODED.Text = SqlData(Sqlconn, 27).ToString
                    txtCTA_ACTIVO_NODEDUCIB.Text = SqlData(Sqlconn, 28).ToString
                    cboFORMA_DEPRECIACION.SelectedValue = SqlData(Sqlconn, 29).ToString
                    cboNO_DIAS_ANIO.SelectedValue = SqlData(Sqlconn, 30).ToString
                    txtPORCENTAJE_PARA_RESCATE.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 31))

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_TIPO_ACTIVO.Enabled = False
                lblTitCODIGO_TIPO_ACTIVO.Enabled = False
            End If

            Me.DescripcionesCodigo()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DescripcionesCodigo()
        '-- Descripciones
        Me.TipoCatalogo_Leave(Nothing, Nothing)
        Me.CodigoCentro_Leave(txtCODIGO_CENTRO_ACTIVO, Nothing)
        Me.CodigoCentro_Leave(txtCOD_CENTRO_GASTO_ACT, Nothing)
        Me.CodigoCentro_Leave(txtCOD_CENTRO_REVALUA, Nothing)
        Me.CodigoCentro_Leave(txtCOD_CENTRO_RESULTADO, Nothing)
        Me.CodigoCentro_Leave(txtCOD_CENTRO_COMPRA, Nothing)
        Me.CodigoCentro_Leave(txtCOD_CENTRO_BAJA, Nothing)
        Me.CodigoCentro_Leave(txtCOD_CENTRO_VENTA, Nothing)
        Me.CodigoCentro_Leave(txtCENTRO_DONA, Nothing)
        Me.CodigoCentro_Leave(txtCOD_CENTRO_ACT_NODED, Nothing)
        Me.CuentaCentro_Leave(txtCTA_ACTIVO, Nothing)
        Me.CuentaCentro_Leave(txtCTA_DEPREC_ACUM, Nothing)
        Me.CuentaCentro_Leave(txtCTA_GASTO_DEPREC, Nothing)
        Me.CuentaCentro_Leave(txtCTA_REVALUA_ACTIVO, Nothing)
        Me.CuentaCentro_Leave(txtCTA_GAN_VTA_ACTIVO, Nothing)
        Me.CuentaCentro_Leave(txtCTA_PER_VTA_ACTIVO, Nothing)
        Me.CuentaCentro_Leave(txtCTA_COMPRA_ACTIVO, Nothing)
        Me.CuentaCentro_Leave(txtCTA_BAJA_ACTIVO, Nothing)
        Me.CuentaCentro_Leave(txtCTA_VENTA_ACTIVO, Nothing)
        Me.CuentaCentro_Leave(txtCUENTA_DONA, Nothing)
        Me.CuentaCentro_Leave(txtCTA_ACTIVO_NODEDUCIB, Nothing)
    End Sub

    Private Sub LimpiarDescripciones()
        lblNOMBRE_CATALOGO.Text = ""
        _lblDESCRIPCION_1.Text = ""
        _lblDESCRIPCION_CUENTA_1.Text = ""
        _lblDESCRIPCION_CUENTA_2.Text = ""
        _lblDESCRIPCION_2.Text = ""
        _lblDESCRIPCION_CUENTA_3.Text = ""
        _lblDESCRIPCION_6.Text = ""
        _lblDESCRIPCION_CUENTA_8.Text = ""
        _lblDESCRIPCION_3.Text = ""
        _lblDESCRIPCION_CUENTA_4.Text = ""
        _lblDESCRIPCION_CUENTA_5.Text = ""
        _lblDESCRIPCION_4.Text = ""
        _lblDESCRIPCION_CUENTA_6.Text = ""
        _lblDESCRIPCION_5.Text = ""
        _lblDESCRIPCION_CUENTA_7.Text = ""
        _lblDESCRIPCION_7.Text = ""
        _lblDESCRIPCION_CUENTA_9.Text = ""
        _lblDESCRIPCION_8.Text = ""
        _lblDESCRIPCION_CUENTA_10.Text = ""
        _lblDESCRIPCION_9.Text = ""
        _lblDESCRIPCION_CUENTA_11.Text = ""
    End Sub

    Private Sub HabilitaFechaActivo()
        If Modo_Local = Modo_Cambio Then
            If cboCALCULO_PRIMERA_DEPR.SelectedValue.ToString = "C" Then
                txtFORZAR_FECHA_ACTIVO.Enabled = False
            Else
                txtFORZAR_FECHA_ACTIVO.Enabled = True
            End If
        End If
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                Me.DescripcionesCodigo()
                Me.ValoresDefault()
                txtCODIGO_TIPO_ACTIVO.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCODIGO_TIPO_ACTIVO.Text = Pop()
                Me.Leer()
                Me.ValoresDefault()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Forma_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                mhTab1.SelectedIndex = 0
            Case Keys.F2
                mhTab1.SelectedIndex = 1
            Case Keys.F3
                mhTab1.SelectedIndex = 2
            Case Keys.F5
                mhTab1.SelectedIndex = 3
        End Select
    End Sub

    Private Sub TipoCatalogo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIPO_CATALOGO.Leave
        lblNOMBRE_CATALOGO.Text = Citi.Synergia.HelperClient.DescripcionesDB.NombreCatalogoContable(txtTIPO_CATALOGO.Text)
    End Sub

    Private Sub CodigoCentro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_CENTRO_ACTIVO.Leave, txtCOD_CENTRO_GASTO_ACT.Leave, txtCOD_CENTRO_REVALUA.Leave, txtCOD_CENTRO_RESULTADO.Leave, txtCOD_CENTRO_COMPRA.Leave, txtCOD_CENTRO_BAJA.Leave, txtCOD_CENTRO_VENTA.Leave, txtCENTRO_DONA.Leave, txtCOD_CENTRO_ACT_NODED.Leave
        Dim cadena As String = DescripcionesDB.Centros(sender.Text)

        Select Case sender.Name
            Case "txtCODIGO_CENTRO_ACTIVO"
                _lblDESCRIPCION_1.Text = cadena
            Case "txtCOD_CENTRO_GASTO_ACT"
                _lblDESCRIPCION_2.Text = cadena
            Case "txtCOD_CENTRO_REVALUA"
                _lblDESCRIPCION_6.Text = cadena
            Case "txtCOD_CENTRO_RESULTADO"
                _lblDESCRIPCION_3.Text = cadena
            Case "txtCOD_CENTRO_COMPRA"
                _lblDESCRIPCION_4.Text = cadena
            Case "txtCOD_CENTRO_BAJA"
                _lblDESCRIPCION_5.Text = cadena
            Case "txtCOD_CENTRO_VENTA"
                _lblDESCRIPCION_7.Text = cadena
            Case "txtCENTRO_DONA"
                _lblDESCRIPCION_8.Text = cadena
            Case "txtCOD_CENTRO_ACT_NODED"
                _lblDESCRIPCION_9.Text = cadena
        End Select
    End Sub

    Private Sub CuentaCentro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCTA_ACTIVO.Leave, txtCTA_DEPREC_ACUM.Leave, txtCTA_GASTO_DEPREC.Leave, txtCTA_REVALUA_ACTIVO.Leave, txtCTA_GAN_VTA_ACTIVO.Leave, txtCTA_PER_VTA_ACTIVO.Leave, txtCTA_COMPRA_ACTIVO.Leave, txtCTA_BAJA_ACTIVO.Leave, txtCTA_VENTA_ACTIVO.Leave, txtCUENTA_DONA.Leave, txtCTA_ACTIVO_NODEDUCIB.Leave
        Dim cadena As String = DescripcionesDB.Cuentas(Me.txtTIPO_CATALOGO.Text, sender.Text)

        Select Case sender.Name
            Case "txtCTA_ACTIVO"
                _lblDESCRIPCION_CUENTA_1.Text = cadena
            Case "txtCTA_DEPREC_ACUM"
                _lblDESCRIPCION_CUENTA_2.Text = cadena
            Case "txtCTA_GASTO_DEPREC"
                _lblDESCRIPCION_CUENTA_3.Text = cadena
            Case "txtCTA_REVALUA_ACTIVO"
                _lblDESCRIPCION_CUENTA_8.Text = cadena
            Case "txtCTA_GAN_VTA_ACTIVO"
                _lblDESCRIPCION_CUENTA_4.Text = cadena
            Case "txtCTA_PER_VTA_ACTIVO"
                _lblDESCRIPCION_CUENTA_5.Text = cadena
            Case "txtCTA_COMPRA_ACTIVO"
                _lblDESCRIPCION_CUENTA_6.Text = cadena
            Case "txtCTA_BAJA_ACTIVO"
                _lblDESCRIPCION_CUENTA_7.Text = cadena
            Case "txtCTA_VENTA_ACTIVO"
                _lblDESCRIPCION_CUENTA_9.Text = cadena
            Case "txtCUENTA_DONA"
                _lblDESCRIPCION_CUENTA_10.Text = cadena
            Case "txtCTA_ACTIVO_NODEDUCIB"
                _lblDESCRIPCION_CUENTA_11.Text = cadena
        End Select
    End Sub

    Private Sub Label_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitTIPO_CATALOGO.DoubleClick, lblTitCODIGO_CENTRO_ACTIVO.DoubleClick, lblTitCTA_ACTIVO.DoubleClick, lblTitCTA_DEPREC_ACUM.DoubleClick, lblTitCOD_CENTRO_GASTO_ACT.DoubleClick, lblTitCTA_GASTO_DEPREC.DoubleClick, lblTitCOD_CENTRO_REVALUA.DoubleClick, lblTitCTA_REVALUA_ACTIVO.DoubleClick, lblTitCOD_CENTRO_RESULTADO.DoubleClick, lblTitCTA_GAN_VTA_ACTIVO.DoubleClick, lblTitCTA_PER_VTA_ACTIVO.DoubleClick, lblTitCOD_CENTRO_COMPRA.DoubleClick, lblTitCTA_COMPRA_ACTIVO.DoubleClick, lblTitCOD_CENTRO_BAJA.DoubleClick, lblTitCTA_BAJA_ACTIVO.DoubleClick, lblTitCOD_CENTRO_VENTA.DoubleClick, lblTitCTA_VENTA_ACTIVO.DoubleClick, lblTitCENTRO_DONA.DoubleClick, lblTitCUENTA_DONA.DoubleClick, lblTitCOD_CENTRO_ACT_NODED.DoubleClick, lblTitCTA_ACTIVO_NODEDUCIB.DoubleClick
        Select Case sender.Name
            Case "lblTitTIPO_CATALOGO"
                txtTIPO_CATALOGO.GenerarConsulta()
            Case "lblTitCODIGO_CENTRO_ACTIVO"
                txtCODIGO_CENTRO_ACTIVO.GenerarConsulta()
            Case "lblTitCTA_ACTIVO"
                txtCTA_ACTIVO.GenerarConsulta()
            Case "lblTitCTA_DEPREC_ACUM"
                txtCTA_DEPREC_ACUM.GenerarConsulta()
            Case "lblTitCOD_CENTRO_GASTO_ACT"
                txtCOD_CENTRO_GASTO_ACT.GenerarConsulta()
            Case "lblTitCTA_GASTO_DEPREC"
                txtCTA_GASTO_DEPREC.GenerarConsulta()
            Case "lblTitCOD_CENTRO_REVALUA"
                txtCOD_CENTRO_REVALUA.GenerarConsulta()
            Case "lblTitCTA_REVALUA_ACTIVO"
                txtCTA_REVALUA_ACTIVO.GenerarConsulta()
            Case "lblTitCOD_CENTRO_RESULTADO"
                txtCOD_CENTRO_RESULTADO.GenerarConsulta()
            Case "lblTitCTA_GAN_VTA_ACTIVO"
                txtCTA_GAN_VTA_ACTIVO.GenerarConsulta()
            Case "lblTitCTA_PER_VTA_ACTIVO"
                txtCTA_PER_VTA_ACTIVO.GenerarConsulta()
            Case "lblTitCOD_CENTRO_COMPRA"
                txtCOD_CENTRO_COMPRA.GenerarConsulta()
            Case "lblTitCTA_COMPRA_ACTIVO"
                txtCTA_COMPRA_ACTIVO.GenerarConsulta()
            Case "lblTitCOD_CENTRO_BAJA"
                txtCOD_CENTRO_BAJA.GenerarConsulta()
            Case "lblTitCTA_BAJA_ACTIVO"
                txtCTA_BAJA_ACTIVO.GenerarConsulta()
            Case "lblTitCOD_CENTRO_VENTA"
                txtCOD_CENTRO_VENTA.GenerarConsulta()
            Case "lblTitCTA_VENTA_ACTIVO"
                txtCTA_VENTA_ACTIVO.GenerarConsulta()
            Case "lblTitCENTRO_DONA"
                txtCENTRO_DONA.GenerarConsulta()
            Case "lblTitCUENTA_DONA"
                txtCUENTA_DONA.GenerarConsulta()
            Case "lblTitCOD_CENTRO_ACT_NODED"
                txtCOD_CENTRO_ACT_NODED.GenerarConsulta()
            Case "lblTitCTA_ACTIVO_NODEDUCIB"
                txtCTA_ACTIVO_NODEDUCIB.GenerarConsulta()
        End Select
    End Sub

    Private Sub CalculoPrimeraDepreciacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCALCULO_PRIMERA_DEPR.SelectedValueChanged
        If Me._primerLlenado Then
            If cboCALCULO_PRIMERA_DEPR.SelectedValue.ToString = "C" Then
                txtFORZAR_FECHA_ACTIVO.Text = "0"
                txtFORZAR_FECHA_ACTIVO.Enabled = False
            Else
                txtFORZAR_FECHA_ACTIVO.Enabled = True
            End If
        End If
        Me._primerLlenado = True
    End Sub

    Private Sub Folder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mhTab1.SelectedIndexChanged
        If cboCALCULO_PRIMERA_DEPR.SelectedValue.ToString = "C" Then
            txtFORZAR_FECHA_ACTIVO.Text = "0"
            txtFORZAR_FECHA_ACTIVO.Enabled = False
        Else
            txtFORZAR_FECHA_ACTIVO.Enabled = True
        End If

        If cboFORMA_DEPRECIACION.SelectedValue.ToString = "M" Then
            cboNO_DIAS_ANIO.Enabled = False
        Else
            cboNO_DIAS_ANIO.Enabled = True
        End If

        cboNO_DIAS_ANIO.Visible = cboNO_DIAS_ANIO.Enabled
        lblTitNO_DIAS_ANIO.Enabled = cboNO_DIAS_ANIO.Enabled
        lblTitNO_DIAS_ANIO.Visible = cboNO_DIAS_ANIO.Enabled
    End Sub

    Private Sub FormaDepreciacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFORMA_DEPRECIACION.SelectedValueChanged
        If Me._primerLlenado Then
            If cboFORMA_DEPRECIACION.SelectedValue.ToString = "M" Then
                cboNO_DIAS_ANIO.Enabled = False
            Else
                cboNO_DIAS_ANIO.Enabled = True
            End If

            cboNO_DIAS_ANIO.Visible = cboNO_DIAS_ANIO.Enabled
            lblTitNO_DIAS_ANIO.Enabled = cboNO_DIAS_ANIO.Enabled
            lblTitNO_DIAS_ANIO.Visible = cboNO_DIAS_ANIO.Enabled
        End If
        Me._primerLlenado = True
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            Me.txtTIPO_CATALOGO.EsRequerido = False
            Me.txtCODIGO_CENTRO_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_DEPREC_ACUM.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCOD_CENTRO_GASTO_ACT.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_GASTO_DEPREC.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCOD_CENTRO_REVALUA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_REVALUA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCOD_CENTRO_RESULTADO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_GAN_VTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_PER_VTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCOD_CENTRO_COMPRA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_COMPRA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCOD_CENTRO_BAJA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_BAJA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCOD_CENTRO_VENTA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_VENTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCENTRO_DONA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCUENTA_DONA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCOD_CENTRO_ACT_NODED.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
            Me.txtCTA_ACTIVO_NODEDUCIB.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido

            If MyBase.ValidarCampos(mhTab1.TabPages(0)) = False Then
                mhTab1.SelectedIndex = 0
                Return
            End If

            If ExisteConta() Then
                'Se deben ingresar todas las cuentas
                Me.txtTIPO_CATALOGO.EsRequerido = True
                If MyBase.ValidarCampos(mhTab1.TabPages(0)) = False Then
                    mhTab1.SelectedIndex = 0
                    Return
                End If

                Me.txtCODIGO_CENTRO_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                Me.txtCTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                Me.txtCTA_DEPREC_ACUM.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                Me.txtCOD_CENTRO_GASTO_ACT.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                Me.txtCTA_GASTO_DEPREC.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCOD_CENTRO_REVALUA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCTA_REVALUA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                If MyBase.ValidarCampos(mhTab1.TabPages(1)) = False Then
                    mhTab1.SelectedIndex = 1
                    Return
                End If

                '    Me.txtCOD_CENTRO_RESULTADO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCTA_GAN_VTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCTA_PER_VTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCOD_CENTRO_COMPRA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCTA_COMPRA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCOD_CENTRO_BAJA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCTA_BAJA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    If MyBase.ValidarCampos(mhTab1.TabPages(2)) = False Then
                '        mhTab1.SelectedIndex = 2
                '        Return
                '    End If

                '    Me.txtCOD_CENTRO_VENTA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCTA_VENTA_ACTIVO.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCENTRO_DONA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCUENTA_DONA.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCOD_CENTRO_ACT_NODED.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    Me.txtCTA_ACTIVO_NODEDUCIB.EsRequerido = Me.txtTIPO_CATALOGO.EsRequerido
                '    If MyBase.ValidarCampos(mhTab1.TabPages(3)) = False Then
                '        mhTab1.SelectedIndex = 3
                '        Return
                '    End If
            End If
        End If

        V = V & "  @CODIGO_TIPO_ACTIVO      = " & Scm(txtCODIGO_TIPO_ACTIVO.Text)
        V = V & ", @DESCRIP_TIPO_ACTIVO     = " & Scm(txtDESCRIP_TIPO_ACTIVO.Text)
        V = V & ", @TIPO_DEPRECIACION       = " & Scm(cboTIPO_DEPRECIACION.SelectedValue.ToString)
        V = V & ", @TIEMPO_DEPRECIACION     = " & sen(txtTIEMPO_DEPRECIACION.GetValor())
        V = V & ", @MONTO_MINIMO_ACTIVO     = " & sen(txtMONTO_MINIMO_ACTIVO.GetValor())
        V = V & ", @FORZAR_FECHA_ACTIVO     = " & sen(txtFORZAR_FECHA_ACTIVO.GetValor())
        V = V & ", @TIPO_CATALOGO           = " & Scm(txtTIPO_CATALOGO.Text)
        V = V & ", @CODIGO_CENTRO_ACTIVO    = " & Scm(txtCODIGO_CENTRO_ACTIVO.Text)
        V = V & ", @CTA_ACTIVO              = " & Scm(txtCTA_ACTIVO.Text)
        V = V & ", @CTA_DEPREC_ACUM         = " & Scm(txtCTA_DEPREC_ACUM.Text)
        V = V & ", @COD_CENTRO_GASTO_ACT    = " & Scm(txtCOD_CENTRO_GASTO_ACT.Text)
        V = V & ", @CTA_GASTO_DEPREC        = " & Scm(txtCTA_GASTO_DEPREC.Text)
        V = V & ", @COD_CENTRO_RESULTADO    = " & Scm(txtCOD_CENTRO_RESULTADO.Text)
        V = V & ", @CTA_GAN_VTA_ACTIVO      = " & Scm(txtCTA_GAN_VTA_ACTIVO.Text)
        V = V & ", @CTA_PER_VTA_ACTIVO      = " & Scm(txtCTA_PER_VTA_ACTIVO.Text)
        V = V & ", @COD_CENTRO_COMPRA       = " & Scm(txtCOD_CENTRO_COMPRA.Text)
        V = V & ", @CTA_COMPRA_ACTIVO       = " & Scm(txtCTA_COMPRA_ACTIVO.Text)
        V = V & ", @COD_CENTRO_BAJA         = " & Scm(txtCOD_CENTRO_BAJA.Text)
        V = V & ", @CTA_BAJA_ACTIVO         = " & Scm(txtCTA_BAJA_ACTIVO.Text)
        V = V & ", @COD_CENTRO_REVALUA      = " & Scm(txtCOD_CENTRO_REVALUA.Text)
        V = V & ", @CTA_REVALUA_ACTIVO      = " & Scm(txtCTA_REVALUA_ACTIVO.Text)
        V = V & ", @COD_CENTRO_VENTA        = " & Scm(txtCOD_CENTRO_VENTA.Text)
        V = V & ", @CTA_VENTA_ACTIVO        = " & Scm(txtCTA_VENTA_ACTIVO.Text)
        V = V & ", @CLA_CONTABILIZACION     = " & Scm(cboCLA_CONTABILIZACION.SelectedValue.ToString)
        V = V & ", @CALCULO_PRIMERA_DEPR    = " & Scm(cboCALCULO_PRIMERA_DEPR.SelectedValue.ToString)
        V = V & ", @COD_CENTRO_DONACION     = " & Scm(txtCENTRO_DONA.Text)
        V = V & ", @CTA_DONACION_ACTIVO     = " & Scm(txtCUENTA_DONA.Text)
        V = V & ", @COD_CENTRO_ACT_NODED    = " & Scm(txtCOD_CENTRO_ACT_NODED.Text)
        V = V & ", @CTA_ACTIVO_NODEDUCIB    = " & Scm(txtCTA_ACTIVO_NODEDUCIB.Text)
        V = V & ", @FORMA_DEPRECIACION      = " & Scm(cboFORMA_DEPRECIACION.SelectedValue.ToString)
        V = V & ", @NO_DIAS_ANIO            = " & sen(cboNO_DIAS_ANIO.SelectedValue.ToString)
        V = V & ", @PORCENTAJE_PARA_RESCATE = " & sen(txtPORCENTAJE_PARA_RESCATE.GetValor())

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("TIPOS_DE_ACTIVOS", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class