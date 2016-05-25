Imports Citi.Synergia.HelperClient

Public Class ACTTACM1
    Public Property CodigoActivo As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        'VERIFICA QUE EXISTA LA CONTABILIDAD INSTALADA
        If Not ExisteConta() Then
            EscondeFrames()
        End If

        Me.LlenarCombos()

        Me.LimpiarDescripciones()

        txtCodigoTipoActivo.Text = CodigoActivo

        Me.Leer()

        Grabado = False
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
        grpBalance.Visible = False
        grpGastos.Visible = grpBalance.Visible
        grpReevaluacion.Visible = grpBalance.Visible
        grpIngresosEgresos.Visible = grpBalance.Visible
        grpGastos.Visible = grpBalance.Visible
        grpDesecho.Visible = grpBalance.Visible
        grpVentas.Visible = grpBalance.Visible
        grpDonacion.Visible = grpBalance.Visible
        grpGastosNoDeducible.Visible = grpBalance.Visible

        lblTipoCatalogo.Visible = grpBalance.Visible
        txtTipoCatalogo.Visible = grpBalance.Visible
        lblNombreTipoCatalogo.Visible = grpBalance.Visible
    End Sub

    Private Sub LlenarCombos()
        Dim tipoDepreciacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With tipoDepreciacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(50, "D - Doble Saldo Declinante")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("L", Citi.Synergia.Traductor.Idiomas.GetMensaje(51, "L - Línea Recta")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(52, "S - Suma de Años Dígitos")))
        End With
        With cboTipoDepreciacion
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoDepreciacion
        End With

        Dim claseContabilizacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With claseContabilizacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(53, "A - Toma Centro de Tipo de Activo")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(54, "D - Toma Centro de División")))
        End With
        With cboClaseContabilizacion
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = claseContabilizacion
        End With

        Dim calculoPrimeraDepr As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With calculoPrimeraDepr
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("C", Citi.Synergia.Traductor.Idiomas.GetMensaje(55, "C - Desde Fecha de Adquisición")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(56, "M - Conforme al Mes")))
        End With
        With cboCalculaPrimeraDepreciacion
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = calculoPrimeraDepr
        End With

        Dim formaDepreciacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With formaDepreciacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(57, "D - Días Calendario")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(58, "M - Meses")))
        End With
        With cboFormaDepreciacion
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = formaDepreciacion
        End With

        Dim noDiasAnio As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With noDiasAnio
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("360", Citi.Synergia.Traductor.Idiomas.GetMensaje(59, "360 DIAS")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("365", Citi.Synergia.Traductor.Idiomas.GetMensaje(60, "365 DIAS")))
        End With
        With cboDiasCalculoDepreciacion
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = noDiasAnio
        End With
    End Sub

    Private Sub LimpiarDescripciones()
        lblNombreTipoCatalogo.Text = ""
        lblNombreCentroBalance.Text = ""
        lblNombreCuentaActivo.Text = ""
        lblNombreCuentaDepreciacion.Text = ""
        lblNombreCentroGastos.Text = ""
        lblNombreCuentaGastos.Text = ""
        lblNombreCentroReevaluacion.Text = ""
        lblNombreCuentaReevaluacion.Text = ""
        lblNombreCentroIngresosEgresos.Text = ""
        lblNombreCuentaGanancia.Text = ""
        lblNombreCuentaPerdida.Text = ""
        lblNombreCentroCompras.Text = ""
        lblNombreCuentaCompras.Text = ""
        lblNombreCentroDesecho.Text = ""
        lblNombreCuentaDesecho.Text = ""
        lblNombreCentroVentas.Text = ""
        lblNombreCuentaVentas.Text = ""
        lblNombreCentroDonacion.Text = ""
        lblNombreCuentaDonacion.Text = ""
        lblNombreCentroGastoNoDeducible.Text = ""
        lblNombreCuentaGastoNoDeducible.Text = ""
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" TIPOS_DE_ACTIVOS.DESCRIP_TIPO_ACTIVO, ")
                meteSQL(" TIPOS_DE_ACTIVOS.TIPO_DEPRECIACION, ")
                meteSQL(" ltrim(str(TIPOS_DE_ACTIVOS.FORZAR_FECHA_ACTIVO,2, 0)), ")
                meteSQL(" ltrim(str(TIPOS_DE_ACTIVOS.MONTO_MINIMO_ACTIVO,13,2)), ")
                meteSQL(" ltrim(str(TIPOS_DE_ACTIVOS.TIEMPO_DEPRECIACION,5, 0)), ")
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
                meteSQL(" TIPOS_DE_ACTIVOS.timestamp ")
                meteSQL("from TIPOS_DE_ACTIVOS")
                meteSQL(" where TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO = " & Scm(CodigoActivo))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtTipoActivoDescripcion.Text = SqlData(Sqlconn, 1).ToString
                    cboTipoDepreciacion.SelectedValue = SqlData(Sqlconn, 2).ToString
                    txtDiaLimite.Text = SqlData(Sqlconn, 3).ToString
                    txtMontoMinimo.Text = SqlData(Sqlconn, 4).ToString
                    txtTiempoDepreciacion.Text = SqlData(Sqlconn, 5).ToString
                    txtTipoCatalogo.Text = SqlData(Sqlconn, 6).ToString
                    txtCentroBalance.Text = SqlData(Sqlconn, 7).ToString
                    txtCuentaActivo.Text = SqlData(Sqlconn, 8).ToString
                    txtCuentaDepreciacion.Text = SqlData(Sqlconn, 9).ToString
                    'txtCOD_CENTRO_GASTO_ACT =SqlData(SqlConn, 10)
                    txtCentroGastos.Text = ""
                    txtCuentaGastos.Text = SqlData(Sqlconn, 11).ToString
                    txtCentroIngresosEgresos.Text = SqlData(Sqlconn, 12).ToString
                    txtCuentaGanancia.Text = SqlData(Sqlconn, 13).ToString
                    txtCuentaPerdida.Text = SqlData(Sqlconn, 14).ToString
                    txtCentroCompras.Text = SqlData(Sqlconn, 15).ToString
                    txtCuentaCompras.Text = SqlData(Sqlconn, 16).ToString
                    txtCentroDesecho.Text = SqlData(Sqlconn, 17).ToString
                    txtCuentaDesecho.Text = SqlData(Sqlconn, 18).ToString
                    txtCentroReevaluacion.Text = SqlData(Sqlconn, 19).ToString
                    txtCuentaReevaluacion.Text = SqlData(Sqlconn, 20).ToString
                    txtCentroVentas.Text = SqlData(Sqlconn, 21).ToString
                    txtCuentaVentas.Text = SqlData(Sqlconn, 22).ToString
                    cboClaseContabilizacion.SelectedValue = SqlData(Sqlconn, 23).ToString
                    cboCalculaPrimeraDepreciacion.SelectedValue = SqlData(Sqlconn, 24).ToString
                    txtCentroDonacion.Text = SqlData(Sqlconn, 25).ToString
                    txtCuentaDonacion.Text = SqlData(Sqlconn, 26).ToString
                    txtCentroGastoNoDeducible.Text = SqlData(Sqlconn, 27).ToString
                    txtCuentaGastoNoDeducible.Text = SqlData(Sqlconn, 28).ToString
                    cboFormaDepreciacion.SelectedValue = SqlData(Sqlconn, 29).ToString
                    cboDiasCalculoDepreciacion.SelectedValue = SqlData(Sqlconn, 30).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            MyBase.Habilitar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TipoCatalogo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoCatalogo.TextChanged
        If Me.txtTipoCatalogo.Text.Trim.Length > 0 Then
            Me.lblNombreTipoCatalogo.Text = DescripcionesDB.NombreCatalogoContable(Me.txtTipoCatalogo.Text)
        End If
    End Sub

    Private Sub Cuentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaActivo.TextChanged, txtCuentaDepreciacion.TextChanged, txtCuentaGastos.TextChanged, txtCuentaReevaluacion.TextChanged, txtCuentaGanancia.TextChanged, txtCuentaPerdida.TextChanged, txtCuentaCompras.TextChanged, txtCuentaDesecho.TextChanged, txtCuentaVentas.TextChanged, txtCuentaDonacion.TextChanged, txtCuentaGastoNoDeducible.TextChanged
        If sender.Text.Trim.Length > 0 Then
            Dim cadena As String = DescripcionesDB.Cuentas(Me.txtTipoCatalogo.Text, sender.Text)
            Select Case sender.Name
                Case "txtCuentaActivo"
                    Me.lblNombreCuentaActivo.Text = cadena
                Case "txtCuentaDepreciacion"
                    Me.lblNombreCuentaDepreciacion.Text = cadena
                Case "txtCuentaGastos"
                    Me.lblNombreCuentaGastos.Text = cadena
                Case "txtCuentaReevaluacion"
                    Me.lblNombreCuentaReevaluacion.Text = cadena
                Case "txtCuentaGanancia"
                    Me.lblNombreCuentaGanancia.Text = cadena
                Case "txtCuentaPerdida"
                    Me.lblNombreCuentaPerdida.Text = cadena
                Case "txtCuentaCompras"
                    Me.lblNombreCuentaCompras.Text = cadena
                Case "txtCuentaDesecho"
                    Me.lblNombreCuentaDesecho.Text = cadena
                Case "txtCuentaVentas"
                    Me.lblNombreCuentaVentas.Text = cadena
                Case "txtCuentaDonacion"
                    Me.lblNombreCuentaDonacion.Text = cadena
                Case "txtCuentaGastoNoDeducible"
                    Me.lblNombreCuentaGastoNoDeducible.Text = cadena
            End Select
        End If
    End Sub

    Private Sub Centro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentroBalance.TextChanged, txtCentroGastos.TextChanged, txtCentroReevaluacion.TextChanged, txtCentroIngresosEgresos.TextChanged, txtCentroCompras.TextChanged, txtCentroDesecho.TextChanged, txtCentroVentas.TextChanged, txtCentroDonacion.TextChanged, txtCentroGastoNoDeducible.TextChanged
        If sender.Text.Trim.Length > 0 Then
            Dim cadena As String = DescripcionesDB.Centros(sender.Text)
            Select Case sender.Name
                Case "txtCentroBalance"
                    Me.lblNombreCentroBalance.Text = cadena
                Case "txtCentroGastos"
                    Me.lblNombreCentroGastos.Text = cadena
                Case "txtCentroReevaluacion"
                    Me.lblNombreCentroReevaluacion.Text = cadena
                Case "txtCentroIngresosEgresos"
                    Me.lblNombreCentroIngresosEgresos.Text = cadena
                Case "txtCentroCompras"
                    Me.lblNombreCentroCompras.Text = cadena
                Case "txtCentroDesecho"
                    Me.lblNombreCentroDesecho.Text = cadena
                Case "txtCentroVentas"
                    Me.lblNombreCentroVentas.Text = cadena
                Case "txtCentroDonacion"
                    Me.lblNombreCentroDonacion.Text = cadena
                Case "txtCentroGastoNoDeducible"
                    Me.lblNombreCentroGastoNoDeducible.Text = cadena
            End Select
        End If
    End Sub

    Private Sub FormaDepreciacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaDepreciacion.SelectedIndexChanged
        If Me.cboFormaDepreciacion.SelectedValue.ToString = "M" Then
            Me.cboDiasCalculoDepreciacion.Enabled = False
        Else
            Me.cboDiasCalculoDepreciacion.Enabled = True
        End If

        Me.cboDiasCalculoDepreciacion.Visible = Me.cboDiasCalculoDepreciacion.Enabled
        Me.lblDiasCalculoDepreciacion.Enabled = Me.cboDiasCalculoDepreciacion.Enabled
        Me.lblDiasCalculoDepreciacion.Visible = Me.cboDiasCalculoDepreciacion.Enabled
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

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class