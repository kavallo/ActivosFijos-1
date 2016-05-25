Imports Citi.Synergia.HelperClient

Public Class ACTMVAM1
    Public Property CodigoActivo As String
    Public Property MejoraCorrelativo As String

    Private _tipoPartida As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False

        If txtCODIGO_DE_ACTIVO.Text.Trim <> "" Then
            lblnombreactivo.Text = DescripcionesDB.DescripcionCortaActivo(txtCODIGO_DE_ACTIVO.Text, txtMEJORA_CORRELATIVO.Text)
        End If
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCORRELATIVO_MOVIM.Text = Pop()
        If Acción And cp_POP Then txtTIPO_MOVIMIENTO.Text = Pop()
        If String.IsNullOrEmpty(Me.MejoraCorrelativo) Then
            If Acción And cp_POP Then Me.MejoraCorrelativo = Pop()
        End If
        If String.IsNullOrEmpty(Me.CodigoActivo) Then
            If Acción And cp_POP Then Me.CodigoActivo = Pop()
        End If
        If Acción And cp_POP Then txtMEJORA_CORRELATIVO.Text = Me.MejoraCorrelativo
        If Acción And cp_POP Then txtCODIGO_DE_ACTIVO.Text = Me.CodigoActivo
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.ANO_PERIODO,4, 0)), ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.NO_PERIODO,2, 0)), ")
                meteSQL(" convert(varchar,MOVIM_ACTIVOS.FECHA_MOVIMIENTO,101), ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.MONTO_DE_MOVIMIENTO,13,2)), ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.TASA_CAMBIO_MOV,13,5)), ")
                meteSQL(" MOVIM_ACTIVOS.OBSERVACIONES1, ")
                meteSQL(" MOVIM_ACTIVOS.OBSERVACIONES2, ")
                meteSQL(" MOVIM_ACTIVOS.USUARIO_MOV_ACT, ")
                meteSQL(" convert(varchar,MOVIM_ACTIVOS.FECHA_DPA_MOV_ACT,101), ")
                meteSQL(" MOVIM_ACTIVOS.ESTADO_MOVIMIENTO, ")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.PORCENTAJE_DEPREC,8,4)), ")
                meteSQL(" MOVIM_ACTIVOS.PERIODOS_DEPRECIADOS,")
                meteSQL(" ltrim(str(MOVIM_ACTIVOS.VALOR_NO_DEDUCIBLE,13,2)), ")
                meteSQL(" MOVIM_ACTIVOS.timestamp ")
                meteSQL("from MOVIM_ACTIVOS")
                meteSQL(" where MOVIM_ACTIVOS.TIPO_MOVIMIENTO = " & sen(txtTIPO_MOVIMIENTO.Text) & " and MOVIM_ACTIVOS.CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MOVIM_ACTIVOS.CORRELATIVO_MOVIM = " & sen(txtCORRELATIVO_MOVIM.Text) & " and MOVIM_ACTIVOS.MEJORA_CORRELATIVO = " & sen(txtMEJORA_CORRELATIVO.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtANO_PERIODO.Text = SqlData(Sqlconn, 1).ToString
                    txtNO_PERIODO.Text = SqlData(Sqlconn, 2).ToString
                    mskfechamov.EscribirFecha(SqlData(Sqlconn, 3).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtMONTO_DE_MOVIMIENTO.Text = SqlData(Sqlconn, 4).ToString
                    txtTASA_CAMBIO_MOV.Text = SqlData(Sqlconn, 5).ToString
                    txtOBSERVACIONES1.Text = SqlData(Sqlconn, 6).ToString
                    txtOBSERVACIONES2.Text = SqlData(Sqlconn, 7).ToString
                    txtUSUARIO_MOV_ACT.Text = SqlData(Sqlconn, 8).ToString
                    mskfechaact.EscribirFecha(SqlData(Sqlconn, 9).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtestado.Text = SqlData(Sqlconn, 10).ToString
                    txtPORCENTAJE_DEPREC.Text = SqlData(Sqlconn, 11).ToString
                    txtperiodos.Text = SqlData(Sqlconn, 12).ToString
                    txtVALOR_NO_DEDUCIBLE.Text = SqlData(Sqlconn, 13).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop
            End If

            If txtestado.Text = "P" Then
                lblnombreestado.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "PENDIENTE").Replace("P - ", "").ToUpper
            Else
                lblnombreestado.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(241, "TRASLADADO").ToUpper
            End If

            MyBase.Habilitar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TipoMovimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTIPO_MOVIMIENTO.TextChanged
        If txtTIPO_MOVIMIENTO.Text.Trim.Length > 0 Then
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandText = "SELECT DESCRIPCION_TIP_MOV, CLASE_MOVIMIENTO, TIPO_PARTIDA from TIPO_MOV_ACTIVOS where TIPO_MOVIMIENTO = " & txtTIPO_MOVIMIENTO.Text
            End With
            Dim dsTipo As DataSet = GetDataSet(comando)
            If Not dsTipo Is Nothing Then
                If dsTipo.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsTipo.Tables(0).Rows
                        lblnombretipo.Text = filaData.Item(0).ToString
                        txtclasemov.Text = filaData.Item(1).ToString
                        _tipoPartida = filaData.Item(2).ToString
                    Next
                End If
            End If

            Select Case txtclasemov.Text
                Case "A"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(61, "ALTA").Replace("A - ", "").ToUpper
                Case "D"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(62, "DESECHO").Replace("D - ", "").ToUpper
                Case "P"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(63, "DEPRECIACION").Replace("P - ", "").ToUpper
                Case "R"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(64, "REVALUACION").Replace("R - ", "").ToUpper
                Case "V"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(65, "VENTA").Replace("V - ", "").ToUpper
                Case "M"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(170, "DISMINUCION").Replace("M - ", "").ToUpper
                Case "I"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(171, "INCREMENTO").Replace("I - ", "").ToUpper
                Case "G"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(68, "REVAL. MASIVA").Replace("G - ", "").ToUpper
                Case "N"
                    lblnombreclase.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(69, "DONACION").Replace("N - ", "").ToUpper
            End Select
        End If
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class