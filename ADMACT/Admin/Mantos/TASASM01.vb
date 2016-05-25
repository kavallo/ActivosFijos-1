Imports Citi.Synergia.HelperClient

Public Class TASASM01
    Public Property CodigoMoneda As String
    Public Property TipoCambio As String
    Public Property Fecha As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        MonedaParametro() 'moneda de parametro general

        If Modo_Local = Modo_Alta Then
            '-- Formato mm/dd/aaaa
            Dim fecha As String = String.Empty
            fecha = DescripcionesDB.TraeFechaHoy("101")
            txtFECHA_DE_LA_TASA.EscribirFecha(fecha, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        End If

        If Modo_Consulta = True Then
            EsConsulta()
        End If

        Me.LlenarCombos()

        Me.Leer()

        Grabado = False
    End Sub

    Private Sub MonedaParametro()
        Try
            meteSQL("select P.CODIGO_DE_MONEDA, M.DESCRIPCION_MONEDA")
            meteSQL("  from PARAMETRO_GENERALES P, MONEDAS M")
            meteSQL(" where P.CODIGO_DE_MONEDA = M.CODIGO_DE_MONEDA")

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblCodigoMonedaParam.Text = SqlData(Sqlconn, 1).ToString
                lblDescripcionMonedaParam.Text = SqlData(Sqlconn, 2).ToString
            Loop

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EsConsulta()
        cmdAceptar.Visible = False
        cmdAceptar.Enabled = False
        cmdCancelar.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(15, "Aceptar")
    End Sub

    Private Sub LlenarCombos()
        Dim cambioTasas As New List(Of Citi.Synergia.Entidades.EstadoActivoInactivo)
        With cambioTasas
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(197, "D - Diario")))
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("H", Citi.Synergia.Traductor.Idiomas.GetMensaje(198, "H - Histórico")))
            .Add(New Citi.Synergia.Entidades.EstadoActivoInactivo("H", Citi.Synergia.Traductor.Idiomas.GetMensaje(199, "P - Promedio")))
        End With

        With cboTIP_CAMBIO_TASAS_CAM
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = cambioTasas
        End With
    End Sub

    Private Sub Leer()
        Try
            Dim fecha As String = String.Empty

            If Modo_Local <> Modo_Alta Then
                '-- Cuando se envía la fecha viene en formato dd/mm/aaaa
                txtFECHA_DE_LA_TASA.EscribirFecha(Me.Fecha)
                cboTIP_CAMBIO_TASAS_CAM.SelectedValue = Me.TipoCambio
            End If

            lblCODIGO_DE_MONEDA.Text = Me.CodigoMoneda

            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" MONEDAS.CODIGO_DE_MONEDA, ")
                meteSQL(" TASAS_DE_CAMBIO.TIP_CAMBIO_TASAS_CAM, ")
                meteSQL(" convert(varchar,TASAS_DE_CAMBIO.FECHA_DE_LA_TASA,101), ")
                meteSQL(" IsNull(TASAS_DE_CAMBIO.TASA_CONVERSION, 0.000000), ")
                meteSQL(" IsNull(TASAS_DE_CAMBIO.TASA_COMPRA, 0.000000), ")
                meteSQL(" TASAS_DE_CAMBIO.timestamp ")
                meteSQL("from MONEDAS, TASAS_DE_CAMBIO ")
                meteSQL(" where TASAS_DE_CAMBIO.CODIGO_DE_MONEDA = '" & Me.CodigoMoneda & "' and TASAS_DE_CAMBIO.FECHA_DE_LA_TASA = '" & txtFECHA_DE_LA_TASA.TextMMDDYYYY() & "' and TASAS_DE_CAMBIO.TIP_CAMBIO_TASAS_CAM = '" & cboTIP_CAMBIO_TASAS_CAM.SelectedValue.ToString & "'")
                meteSQL(" and TASAS_DE_CAMBIO.CODIGO_DE_MONEDA  =  MONEDAS.CODIGO_DE_MONEDA")

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    lblCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 1).ToString
                    cboTIP_CAMBIO_TASAS_CAM.SelectedValue = SqlData(Sqlconn, 2).ToString
                    txtFECHA_DE_LA_TASA.EscribirFecha(SqlData(Sqlconn, 3).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtTASA_CONVERSION.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 4))
                    txtTASA_COMPRA.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 5))

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            'recuperamos descripcion de moneda
            lblNombreMoneda.Text = DescripcionesDB.Monedas(lblCODIGO_DE_MONEDA.Text)

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                cboTIP_CAMBIO_TASAS_CAM.Enabled = False
                lblTitTIP_CAMBIO_TASAS_CAM.Enabled = cboTIP_CAMBIO_TASAS_CAM.Enabled
                lblTitFECHA_DE_LA_TASA.Enabled = cboTIP_CAMBIO_TASAS_CAM.Enabled
                txtFECHA_DE_LA_TASA.Enabled = cboTIP_CAMBIO_TASAS_CAM.Enabled
            End If

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
                cboTIP_CAMBIO_TASAS_CAM.Focus()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            MyBase.ErrorCampos.SetError(Me.cboTIP_CAMBIO_TASAS_CAM, Nothing)
            If cboTIP_CAMBIO_TASAS_CAM.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboTIP_CAMBIO_TASAS_CAM, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If

            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If
        End If

        V = V & "  @CODIGO_DE_MONEDA = " & Scm(lblCODIGO_DE_MONEDA.Text)
        V = V & ", @TIP_CAMBIO_TASAS_CAM = " & Scm(cboTIP_CAMBIO_TASAS_CAM.SelectedValue.ToString)
        V = V & ", @FECHA_DE_LA_TASA = " & Scm(txtFECHA_DE_LA_TASA.TextMMDDYYYY())
        V = V & ", @TASA_CONVERSION = " & sen(txtTASA_CONVERSION.GetValor())
        V = V & ", @TASA_COMPRA = " & sen(txtTASA_COMPRA.GetValor())

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("TASAS_DE_CAMBIO", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class