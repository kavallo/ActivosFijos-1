Imports Citi.Synergia.HelperClient

Public Class ACTMVAM0
    Public Property CodigoActivo As String
    Public Property MejoraCorrelativo As String

    Private valor_actual_activo As String = String.Empty
    Private Fecha As String = String.Empty
    Private moneda As String = String.Empty
    Private varANO_PERIODO As String = String.Empty
    Private varESTADO_MOVIMIENTO As String = String.Empty
    Private varFECHA_DPA_MOV_ACT As String = String.Empty
    Private varNO_PERIODO As String = String.Empty
    Private varPORCENTAJE_DEPREC As String = String.Empty
    Private varUSUARIO_MOV_ACT As String = String.Empty
    Private clase_movimiento As String = String.Empty
    Private Tipo_Partida As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LeerUltimoCreaRegistro()

        Fecha = DescripcionesDB.TraeFechaHoy("101")
        mskfecha.EscribirFecha(Fecha, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False

        lblnombreactivo.Text = DescripcionesDB.DescripcionCortaActivo(txtCODIGO_DE_ACTIVO.Text, txtMEJORA_CORRELATIVO.GetValor())

        If Not String.IsNullOrEmpty(TraeDato("select str(round(VALOR_ACTUAL_ACTIVO * TASA_CAMBIO_COMPRA,2),13,2) from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.GetValor()))) Then
            valor_actual_activo = TraeDato("select str(round(VALOR_ACTUAL_ACTIVO * TASA_CAMBIO_COMPRA,2),13,2) from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.GetValor())).ToString
        End If

        moneda = DescripcionesDB.TipoDeActivoCodigoMoneda(txtCODIGO_DE_ACTIVO.Text, txtMEJORA_CORRELATIVO.GetValor())

        txtTASA_CAMBIO_MOV.Text = DescripcionesDB.TipoDeActivoTasaCambioCompra(txtCODIGO_DE_ACTIVO.Text, txtMEJORA_CORRELATIVO.GetValor())

        If Modo_Local = Modo_Alta Then
            txtCODIGO_DE_ACTIVO.Enabled = False
            lblTitCODIGO_DE_ACTIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            txtCORRELATIVO_MOVIM.Visible = txtCODIGO_DE_ACTIVO.Enabled
            lblTitCORRELATIVO_MOVIM.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            lblTitMEJORA_CORRELATIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            txtMEJORA_CORRELATIVO.Visible = txtCODIGO_DE_ACTIVO.Enabled
        End If
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCORRELATIVO_MOVIM.Text = Pop()
        If Acción And cp_POP Then txtTIPO_MOVIMIENTO.Text = Pop()
        If Acción And cp_POP Then txtMEJORA_CORRELATIVO.Text = Me.MejoraCorrelativo
        If Acción And cp_POP Then txtCODIGO_DE_ACTIVO.Text = Me.CodigoActivo
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.ANO_PERIODO,4, 0)), ")
                meteSQL(" MOVIM_ACTIVOS.ESTADO_MOVIMIENTO, ")
                meteSQL(" MOVIM_ACTIVOS.FECHA_DPA_MOV_ACT, ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.NO_PERIODO,2, 0)), ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.PORCENTAJE_DEPREC,8,4)), ")
                meteSQL(" MOVIM_ACTIVOS.USUARIO_MOV_ACT, ")
                meteSQL(" convert(varchar(10),MOVIM_ACTIVOS.FECHA_MOVIMIENTO,101), ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.MONTO_DE_MOVIMIENTO,13,2)), ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.TASA_CAMBIO_MOV,13,5)), ")
                meteSQL(" MOVIM_ACTIVOS.OBSERVACIONES1, ")
                meteSQL(" MOVIM_ACTIVOS.OBSERVACIONES2, ")
                meteSQL(" IsNull(MOVIM_ACTIVOS.GENERA_PARTIDA, 0), ")
                meteSQL(" MOVIM_ACTIVOS.timestamp ")
                meteSQL("from MOVIM_ACTIVOS")
                meteSQL(" where MOVIM_ACTIVOS.TIPO_MOVIMIENTO = " & sen(txtTIPO_MOVIMIENTO.GetValor()) & " and MOVIM_ACTIVOS.CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MOVIM_ACTIVOS.CORRELATIVO_MOVIM = " & sen(txtCORRELATIVO_MOVIM.GetValor()) & " and MOVIM_ACTIVOS.MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.GetValor()))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    varANO_PERIODO = SqlData(Sqlconn, 1).ToString
                    varESTADO_MOVIMIENTO = SqlData(Sqlconn, 2).ToString
                    varFECHA_DPA_MOV_ACT = SqlData(Sqlconn, 3).ToString
                    varNO_PERIODO = SqlData(Sqlconn, 4).ToString
                    varPORCENTAJE_DEPREC = SqlData(Sqlconn, 5).ToString
                    varUSUARIO_MOV_ACT = SqlData(Sqlconn, 6).ToString
                    mskfecha.EscribirFecha(SqlData(Sqlconn, 7).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtMONTO_DE_MOVIMIENTO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 8))
                    txtOBSERVACIONES1.Text = SqlData(Sqlconn, 10).ToString
                    txtOBSERVACIONES2.Text = SqlData(Sqlconn, 11).ToString
                    Me.chkGeneraPartida.Checked = SqlData(Sqlconn, 12)

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

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                txtMEJORA_CORRELATIVO.Text = Me.MejoraCorrelativo
                txtCODIGO_DE_ACTIVO.Text = Me.CodigoActivo
                lblnombretipo.Text = String.Empty
                If Modo_Local = Modo_Alta Then
                    txtCODIGO_DE_ACTIVO.Enabled = False
                    lblTitCODIGO_DE_ACTIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
                    txtCORRELATIVO_MOVIM.Visible = txtCODIGO_DE_ACTIVO.Enabled
                    lblTitCORRELATIVO_MOVIM.Enabled = txtCODIGO_DE_ACTIVO.Enabled
                    lblTitMEJORA_CORRELATIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
                    txtMEJORA_CORRELATIVO.Visible = txtCODIGO_DE_ACTIVO.Enabled
                End If
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCORRELATIVO_MOVIM.Text = Pop()
                txtTIPO_MOVIMIENTO.Text = Pop()
                txtMEJORA_CORRELATIVO.Text = Me.MejoraCorrelativo
                txtCODIGO_DE_ACTIVO.Text = Me.CodigoActivo
                Me.Leer()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LeerUltimoCreaRegistro()
        Try
            Dim archivoConfiguracion As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ActivosUltimoCreaRegistro.Xml"
            If My.Computer.FileSystem.FileExists(archivoConfiguracion) Then
                Dim oXml As New Xml.XmlDocument
                oXml.Load(archivoConfiguracion)

                Me.chkGeneraPartida.Checked = IIf(oXml.SelectSingleNode("ROOT").SelectSingleNode("Crea").InnerText = "1", True, False)

                oXml = Nothing
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrabarUltimoCreaRegistro()
        Dim cuerpoXml As String = "<ROOT><Crea>" & IIf(Me.chkGeneraPartida.Checked, "1", "0").ToString & "</Crea></ROOT>"
        Dim strNombreArchivo As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ActivosUltimoCreaRegistro.Xml"
        If My.Computer.FileSystem.FileExists(strNombreArchivo) Then
            My.Computer.FileSystem.DeleteFile(strNombreArchivo)
        End If
        Dim oArchivo As System.IO.StreamWriter
        oArchivo = My.Computer.FileSystem.OpenTextFileWriter(strNombreArchivo, False)
        oArchivo.WriteLine(cuerpoXml)
        oArchivo.Close()
    End Sub

    Private Sub LabelTipoMovimiento_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitTIPO_MOVIMIENTO.DoubleClick
        txtTIPO_MOVIMIENTO.GenerarConsulta()
        Me.TipoMovimiento_Leave(Nothing, Nothing)
    End Sub

    Private Sub TipoMovimiento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIPO_MOVIMIENTO.Leave
        If txtTIPO_MOVIMIENTO.Text.Trim <> "" Then
            Try
                Dim comando As New SqlClient.SqlCommand
                With comando
                    .CommandText = "SELECT DESCRIPCION_TIP_MOV, CLASE_MOVIMIENTO, TIPO_PARTIDA from TIPO_MOV_ACTIVOS where TIPO_MOVIMIENTO = " & txtTIPO_MOVIMIENTO.GetValor()
                End With
                Dim dsTipo As DataSet = GetDataSet(comando)
                If Not dsTipo Is Nothing Then
                    If dsTipo.Tables.Count > 0 Then
                        For Each filaData As DataRow In dsTipo.Tables(0).Rows
                            lblnombretipo.Text = filaData.Item(0).ToString
                            clase_movimiento = filaData.Item(1).ToString
                            Tipo_Partida = filaData.Item(2).ToString
                        Next
                    End If
                End If

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If clase_movimiento = "D" Or clase_movimiento = "N" Then
            txtMONTO_DE_MOVIMIENTO.Text = valor_actual_activo
            txtMONTO_DE_MOVIMIENTO.Enabled = False
        Else
            txtMONTO_DE_MOVIMIENTO.Enabled = True
            txtMONTO_DE_MOVIMIENTO.Text = ""
        End If

        If clase_movimiento = "V" Then
            Me.txtMONTO_DE_MOVIMIENTO.EsRequerido = True
        Else
            Me.txtMONTO_DE_MOVIMIENTO.EsRequerido = False
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim tieneAcceso As Boolean = True
        Try
            Dim claseMovimiento As String = String.Empty
            If Not String.IsNullOrEmpty(TraeDato("Select CLASE_MOVIMIENTO From TIPO_MOV_ACTIVOS Where TIPO_MOVIMIENTO = " & sen(txtTIPO_MOVIMIENTO.Text))) Then
                claseMovimiento = TraeDato("Select CLASE_MOVIMIENTO From TIPO_MOV_ACTIVOS Where TIPO_MOVIMIENTO = " & sen(txtTIPO_MOVIMIENTO.Text)).ToString

                If claseMovimiento = "D" Or claseMovimiento = "V" Or claseMovimiento = "N" Then
                    If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdAceptar.Tag.ToString) Then
                        tieneAcceso = True
                    Else
                        tieneAcceso = False
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso = False Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(Frame1) = False Then
                Return
            End If
        End If

        If String.IsNullOrWhiteSpace(varUSUARIO_MOV_ACT) Then
            varUSUARIO_MOV_ACT = Citi.Synergia.Locals.Cache.UsuarioSSO
        End If

        V = V & "  @CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text)
        V = V & ", @MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.GetValor())
        V = V & ", @TIPO_MOVIMIENTO = " & sen(txtTIPO_MOVIMIENTO.GetValor())
        V = V & ", @CORRELATIVO_MOVIM = " & sen(txtCORRELATIVO_MOVIM.Text)
        V = V & ", @ANO_PERIODO = " & sen(varANO_PERIODO)
        V = V & ", @NO_PERIODO = " & sen(varNO_PERIODO)
        V = V & ", @FECHA_MOVIMIENTO = " & Scm(mskfecha.TextMMDDYYYY())
        V = V & ", @MONTO_DE_MOVIMIENTO = " & sen(txtMONTO_DE_MOVIMIENTO.GetValor())
        V = V & ", @TASA_CAMBIO_MOV = " & sen(txtTASA_CAMBIO_MOV.GetValor())
        V = V & ", @OBSERVACIONES1 = " & Scm(txtOBSERVACIONES1.Text)
        V = V & ", @OBSERVACIONES2 = " & Scm(txtOBSERVACIONES2.Text)
        V = V & ", @USUARIO_MOV_ACT = " & Scm(varUSUARIO_MOV_ACT)
        V = V & ", @FECHA_DPA_MOV_ACT = " & Scm(Fecha)
        V = V & ", @ESTADO_MOVIMIENTO = 'T'"
        V = V & ", @PORCENTAJE_DEPREC = " & sen(varPORCENTAJE_DEPREC)
        V = V & ", @PERIODOS_DEPRECIADOS = NULL"
        V = V & ", @GENERA_PARTIDA = " & sen(IIf(Me.chkGeneraPartida.Checked, "1", "0").ToString)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("MOVIM_ACTIVOS", V) Then
            Grabado = True
            HubieronCambios = True

            If Modo = Modo_Alta Then
                Me.GrabarUltimoCreaRegistro()
            End If

            Siguiente()
        End If
    End Sub
End Class