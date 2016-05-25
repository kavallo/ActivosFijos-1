Imports Citi.Synergia.HelperClient

Public Class ACTSEAM1
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LeerIco(Me)

        MyBase.Limpiar()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

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

    Private Sub Leer()
        Try
            'Dim moneda As String
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

            clase = DescripcionesDB.TipoDeServicioClase(txtTIPO_SERVICIO.Text)
            lblnombretiposervicio.Text = DescripcionesDB.TipoDeServicioDescripcion(txtTIPO_SERVICIO.Text)

            Dim preventivo As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(71, "Preventivo")
            Dim correctivo As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(70, "Correctivo")

            Select Case clase
                Case "P"
                    lbltiposerv.Text = preventivo.Replace("P - ", "")
                Case "C"
                    lbltiposerv.Text = correctivo.Replace("C - ", "")
            End Select

            Habilitar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InfoMoneda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DE_MONEDA.TextChanged
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

                Dim resultado As Integer = CType(comando.Parameters(1).Value, Integer)
                txtTASA_CAMBIO.Text = String.Format("{0:0.00000}", resultado)

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Codigos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_PROVEEDOR.TextChanged, txtCODIGO_DE_ACTIVO.TextChanged
        Select Case sender.Name
            Case "txtCODIGO_PROVEEDOR"
                lblnombreproveedor.Text = DescripcionesDB.Proveedor(sender.Text)
            Case "txtCODIGO_DE_ACTIVO"
                lblnombreactivo.Text = DescripcionesDB.DescripcionCortaActivo(txtCODIGO_DE_ACTIVO.Text, txtMEJORA_CORRELATIVO.Text)
        End Select
    End Sub

    Private Sub TipoServicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIPO_SERVICIO.TextChanged
        Dim clase As String = String.Empty
        If Trim(txtTIPO_SERVICIO.Text) <> "" Then
            lblnombretiposervicio.Text = DescripcionesDB.TipoDeServicioDescripcion(txtTIPO_SERVICIO.Text)
        End If

        clase = DescripcionesDB.TipoDeServicioClase(txtTIPO_SERVICIO.Text)

        Dim preventivo As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(71, "Preventivo")
        Dim correctivo As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(70, "Correctivo")

        Select Case clase
            Case "P"
                lbltiposerv.Text = preventivo.Replace("P - ", "")
            Case "C"
                lbltiposerv.Text = correctivo.Replace("C - ", "")
        End Select
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class