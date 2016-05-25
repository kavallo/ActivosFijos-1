Imports Citi.Synergia.HelperClient

Public Class ACTSEAM0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Me.ValoresDefault()

        Grabado = False

        '-- Validación de proveedores visibles
        Me.lblTitCODIGO_PROVEEDOR.Visible = Not Citi.Synergia.Locals.Cache.ProveedoresInvisibles
        Me.txtCODIGO_PROVEEDOR.Visible = Me.lblTitCODIGO_PROVEEDOR.Visible
        Me.lblnombreproveedor.Visible = Me.lblTitCODIGO_PROVEEDOR.Visible
        If Citi.Synergia.Locals.Cache.ProveedoresInvisibles Then
            Me.lblTitFECHA_SERVICIO.Top = Me.lblTitTIPO_SERVICIO.Top
            Me.Label2.Top = Me.lblTitFECHA_SERVICIO.Top
            Me.lblTitDOCUMENTO_SALIDA.Top = Me.lblTitFECHA_SERVICIO.Top
            Me.mskfecha1.Top = Me.txtTIPO_SERVICIO.Top
            Me.txtDOCUMENTO_SALIDA.Top = Me.mskfecha1.Top
            Me.lblTitTIPO_SERVICIO.Top = Me.lblTitCODIGO_PROVEEDOR.Top
            Me.lblnombretiposervicio.Top = Me.lblTitTIPO_SERVICIO.Top
            Me.txtTIPO_SERVICIO.Top = Me.txtCODIGO_PROVEEDOR.Top
        Else
            Me.lblTitCODIGO_PROVEEDOR.Top = 99
            Me.lblnombreproveedor.Top = Me.lblTitCODIGO_PROVEEDOR.Top
            Me.txtCODIGO_PROVEEDOR.Top = 97
            Me.lblTitTIPO_SERVICIO.Top = 125
            Me.lblnombretiposervicio.Top = Me.lblTitTIPO_SERVICIO.Top
            Me.txtTIPO_SERVICIO.Top = 123
            Me.lblTitFECHA_SERVICIO.Top = 151
            Me.Label2.Top = Me.lblTitFECHA_SERVICIO.Top
            Me.lblTitDOCUMENTO_SALIDA.Top = Me.lblTitFECHA_SERVICIO.Top
            Me.mskfecha1.Top = 149
            Me.txtDOCUMENTO_SALIDA.Top = Me.mskfecha1.Top
        End If
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtNUMERO_SERVICIO.Text = Pop()
        If Acción And cp_POP Then txtMEJORA_CORRELATIVO.Text = Pop()
        If Acción And cp_POP Then txtCODIGO_DE_ACTIVO.Text = Pop()
    End Sub

    Private Sub ValoresDefault()
        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS")) Then
            Dim cantidad As Integer = CType(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_DE_MONEDA.Text = TraeDato("Select CODIGO_DE_MONEDA From MONEDAS").ToString
                lblnombremoneda.Text = DescripcionesDB.Monedas(txtCODIGO_DE_MONEDA.Text)
                If Modo_Local = Modo_Alta Then
                    Me.InfoMoneda(Nothing, Nothing)
                End If
                Me.lblTitCODIGO_DE_MONEDA.Enabled = False
                Me.txtCODIGO_DE_MONEDA.Enabled = False
            End If
        End If
    End Sub

    Private Sub Leer()
        Try
            Dim clase As String = String.Empty

            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ltrim(str(SERVICIOS_DE_ACTIVOS.CODIGO_PROVEEDOR,10, 0)), ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.TIPO_SERVICIO, ")
                meteSQL(" convert(varchar(10),SERVICIOS_DE_ACTIVOS.FECHA_SERVICIO,101), ")
                meteSQL(" IsNull(SERVICIOS_DE_ACTIVOS.VALOR_SERVICIO, 0), ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.OBSERVACIONES1, ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.OBSERVACIONES2, ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.OBSERVACIONES3, ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.OBSERVACIONES4, ")
                meteSQL(" IsNull(SERVICIOS_DE_ACTIVOS.TASA_CAMBIO, 0), ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.DOCUMENTO_SALIDA, ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.DOCUMENTO_ENTREGA, ")
                meteSQL(" convert(varchar(10),SERVICIOS_DE_ACTIVOS.FECHA_ENTREGA,101), ")
                meteSQL(" SERVICIOS_DE_ACTIVOS.CODIGO_DE_MONEDA, ")
                meteSQL("SERVICIOS_DE_ACTIVOS.timestamp ")
                meteSQL("from SERVICIOS_DE_ACTIVOS")
                meteSQL(" where SERVICIOS_DE_ACTIVOS.NUMERO_SERVICIO = " & sen(txtNUMERO_SERVICIO.Text) & " and SERVICIOS_DE_ACTIVOS.CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and SERVICIOS_DE_ACTIVOS.MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtCODIGO_PROVEEDOR.Text = SqlData(Sqlconn, 1).ToString
                    txtTIPO_SERVICIO.Text = SqlData(Sqlconn, 2).ToString
                    mskfecha1.EscribirFecha(SqlData(Sqlconn, 3).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtVALOR_SERVICIO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 4))
                    txtOBSERVACIONES1.Text = SqlData(Sqlconn, 5).ToString
                    txtOBSERVACIONES2.Text = SqlData(Sqlconn, 6).ToString
                    txtOBSERVACIONES3.Text = SqlData(Sqlconn, 7).ToString
                    txtOBSERVACIONES4.Text = SqlData(Sqlconn, 8).ToString
                    txtTASA_CAMBIO.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 9))
                    txtDOCUMENTO_SALIDA.Text = SqlData(Sqlconn, 10).ToString
                    txtDOCUMENTO_ENTREGA.Text = SqlData(Sqlconn, 11).ToString
                    mskfecha2.EscribirFecha(SqlData(Sqlconn, 12), Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 13).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_DE_ACTIVO.Enabled = False
            End If
            lblTitCODIGO_DE_ACTIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            txtMEJORA_CORRELATIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            lblTitMEJORA_CORRELATIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            txtNUMERO_SERVICIO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            lblTitNUMERO_SERVICIO.Enabled = txtCODIGO_DE_ACTIVO.Enabled

            Me.InfoMoneda(Nothing, Nothing)
            Me.Codigos_Leave(txtCODIGO_PROVEEDOR, Nothing)
            Me.Codigos_Leave(txtCODIGO_DE_ACTIVO, Nothing)
            Me.TipoServicio_Leave(Nothing, Nothing)

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
                Me.InfoMoneda(Nothing, Nothing)
                Me.Codigos_Leave(txtCODIGO_PROVEEDOR, Nothing)
                Me.Codigos_Leave(txtCODIGO_DE_ACTIVO, Nothing)
                Me.TipoServicio_Leave(Nothing, Nothing)
                Me.ValoresDefault()
                txtCODIGO_DE_ACTIVO.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtNUMERO_SERVICIO.Text = Pop()
                txtMEJORA_CORRELATIVO.Text = Pop()
                txtCODIGO_DE_ACTIVO.Text = Pop()
                Me.Leer()
                Me.ValoresDefault()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub InfoMoneda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DE_MONEDA.Leave
        lblnombremoneda.Text = ""
        If txtCODIGO_DE_MONEDA.Text <> "" Then
            Try
                lblnombremoneda.Text = DescripcionesDB.Monedas(txtCODIGO_DE_MONEDA.Text)

                '-- Tasa de cambio moneda.
                Dim comando As New SqlClient.SqlCommand
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Obtiene_tasa_cambio_de_moneda"
                    .Parameters.Add("@CODIGO_DE_MONEDA", SqlDbType.Char, 5).Value = txtCODIGO_DE_MONEDA.Text
                    .Parameters.Add("@TASA_CAMBIO", SqlDbType.Float).Value = 0
                    .Parameters(0).Direction = ParameterDirection.Input
                    .Parameters(1).Direction = ParameterDirection.Output
                End With

                Dim parametro As SqlClient.SqlParameter
                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@CODIGO_DE_MONEDA"
                    .Direction = ParameterDirection.Input
                    .SqlDbType = SqlDbType.Char
                    .Size = 5
                    .Value = txtCODIGO_DE_MONEDA.Text
                End With
                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@TASA_CAMBIO"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Float
                    .Value = 0
                End With

                EjecutarComando(comando)

                If Not IsDBNull(comando.Parameters(1).Value) Then
                    Dim resultado As Integer = CType(comando.Parameters(1).Value, Integer)
                    txtTASA_CAMBIO.Text = String.Format("{0:0.00000}", resultado)

                    Dim codigoMoneda As String = String.Empty
                    codigoMoneda = DescripcionesDB.ParametrosGeneralesCodigoMoneda("PA")
                    If codigoMoneda.Trim() = txtCODIGO_DE_MONEDA.ToString().Trim() Then
                        txtTASA_CAMBIO.Enabled = False
                    Else
                        txtTASA_CAMBIO.Enabled = True
                    End If
                End If

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_PROVEEDOR.Leave, txtCODIGO_DE_ACTIVO.Leave
        Select Case sender.Name
            Case "txtCODIGO_PROVEEDOR"
                lblnombreproveedor.Text = DescripcionesDB.Proveedor(sender.Text)
            Case "txtCODIGO_DE_ACTIVO"
                lblnombreactivo.Text = DescripcionesDB.DescripcionCortaActivo(txtCODIGO_DE_ACTIVO.Text, txtMEJORA_CORRELATIVO.Text)
        End Select
    End Sub

    Private Sub CodigoActivoMejora_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_DE_ACTIVO.DoubleClick, lblTitMEJORA_CORRELATIVO.DoubleClick, txtCODIGO_DE_ACTIVO.DoubleClick, txtMEJORA_CORRELATIVO.DoubleClick
        With txtCODIGO_DE_ACTIVO
            .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
            .GenerarConsulta()
            '-- En este caso la consulta devuelve 2 códigos, uno del tipo de activo
            '-- y el otro del correlativo
            If .CodigosRetorno.Count > 0 Then
                txtMEJORA_CORRELATIVO.Text = .CodigosRetorno.Item(1)
                .Text = .CodigosRetorno.Item(0)
            End If
            .NombreDeConsulta = Nothing
        End With
    End Sub

    Private Sub CodigoActivoMejora_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCODIGO_DE_ACTIVO.KeyUp, txtMEJORA_CORRELATIVO.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.CodigoActivoMejora_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub TipoServicio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIPO_SERVICIO.Leave
        Try
            Dim clase As String = String.Empty

            lblnombretiposervicio.Text = DescripcionesDB.TipoDeServicioDescripcion(txtTIPO_SERVICIO.Text)

            clase = DescripcionesDB.TipoDeServicioClase(txtTIPO_SERVICIO.Text)

            Dim preventivo As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(71, "Preventivo")
            Dim correctivo As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(70, "Correctivo")

            Select Case clase
                Case "P"
                    lbltiposerv.Text = preventivo.Replace("P - ", "")
                Case "C"
                    lbltiposerv.Text = correctivo.Replace("C - ", "")
            End Select

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListaProveedores(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_PROVEEDOR.DoubleClick, lblTitCODIGO_PROVEEDOR.DoubleClick
        Dim codigoProveedor As String = String.Empty
        Dim frmLista As New PROVEC01
        With frmLista
            .ShowDialog()
            codigoProveedor = .CodigoProveedor
            .Dispose()
        End With
        If codigoProveedor <> "" Then
            txtCODIGO_PROVEEDOR.Text = codigoProveedor
        End If
    End Sub

    Private Sub CODIGO_PROVEEDOR_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCODIGO_PROVEEDOR.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.ListaProveedores(Nothing, Nothing)
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If
        End If

        V = V & "  @CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text)
        V = V & ", @MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.Text)
        V = V & ", @NUMERO_SERVICIO = " & sen(txtNUMERO_SERVICIO.Text)
        V = V & ", @CODIGO_PROVEEDOR = " & sen(txtCODIGO_PROVEEDOR.GetValor())
        V = V & ", @TIPO_SERVICIO = " & Scm(txtTIPO_SERVICIO.Text)
        V = V & ", @FECHA_SERVICIO= " & IIf(mskfecha1.Text = "__/__/____" Or mskfecha1.Text = "", Scm(""), Scm(mskfecha1.TextMMDDYYYY()))
        V = V & ", @VALOR_SERVICIO = " & sen(txtVALOR_SERVICIO.GetValor())
        V = V & ", @OBSERVACIONES1 = " & Scm(txtOBSERVACIONES1.Text)
        V = V & ", @OBSERVACIONES2 = " & Scm(txtOBSERVACIONES2.Text)
        V = V & ", @OBSERVACIONES3 = " & Scm(txtOBSERVACIONES3.Text)
        V = V & ", @OBSERVACIONES4 = " & Scm(txtOBSERVACIONES4.Text)
        V = V & ", @TASA_CAMBIO = " & sen(txtTASA_CAMBIO.GetValor())
        V = V & ", @DOCUMENTO_SALIDA = " & Scm(txtDOCUMENTO_SALIDA.Text)
        V = V & ", @DOCUMENTO_ENTREGA = " & Scm(txtDOCUMENTO_ENTREGA.Text)
        V = V & ", @FECHA_ENTREGA = " & IIf(mskfecha2.Text = "__/__/____" Or mskfecha2.Text = "", Scm(""), Scm(mskfecha2.TextMMDDYYYY()))
        V = V & ", @CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("SERVICIOS_DE_ACTIVOS", V) Then
            Grabado = True
            HubieronCambios = True

            Me.Siguiente()
        End If
    End Sub
End Class