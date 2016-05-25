Imports Citi.Synergia.HelperClient

Public Class ACTETAM1
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarCombos()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
            If Not String.IsNullOrEmpty(TraeDato("Select IsNull(Max(TRASLADO_ID_ACT),0) + 1 From ACT_TRASLADO_ENC")) Then
                txtTRASLADO_ID_ACT.Text = TraeDato("Select IsNull(Max(TRASLADO_ID_ACT),0) + 1 From ACT_TRASLADO_ENC").ToString
            End If
            Dim fecha As String = DescripcionesDB.TraeFechaHoy("101")
            txtFECHA_TRASLADO.EscribirFecha(fecha, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False

        If Modo_Local <> Modo_Alta Then
            txtTRASLADO_ID_ACT.Enabled = False
            lblTitTRASLADO_ID_ACT.Enabled = txtTRASLADO_ID_ACT.Enabled
            lblTitRESPONSABLE_ID.Enabled = txtTRASLADO_ID_ACT.Enabled
            txtRESPONSABLE_ID.Enabled = txtTRASLADO_ID_ACT.Enabled

            If Modo_Local = Modo_Baja Then
                Me.grdOrigen.ReadOnly = True
                Me.grdDestino.ReadOnly = Me.grdOrigen.ReadOnly
                Me.TRASLADO.Enabled = Not Me.grdOrigen.ReadOnly
                Me.CAMBIO.Enabled = Not Me.grdOrigen.ReadOnly
                Me.REEMPLAZO.Enabled = Not Me.grdOrigen.ReadOnly
                Me.Check3D1.Enabled = Not Me.grdOrigen.ReadOnly
            End If
        End If

        cboESTADO_TRASLADO_ACT.Enabled = False
        lblTitESTADO_TRASLADO_ACT.Enabled = False

        With Me.grdOrigen
            .Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(233, "Activo Fijo")
            .Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(115, "Mejora")
            .Columns(2).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(12, "Descripción")
            .Columns(3).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(228, "Traslado")
        End With

        With Me.grdDestino
            .Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(233, "Activo Fijo")
            .Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(115, "Mejora")
            .Columns(2).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(12, "Descripción")
        End With
    End Sub

    Private Sub LlenarCombos()
        Dim estado As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estado
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(179, "A - Autorizada")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente")))
        End With
        With cboESTADO_TRASLADO_ACT
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estado
            .SelectedValue = "P"
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtTRASLADO_ID_ACT.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" Convert(Varchar(10),ACT_TRASLADO_ENC.FECHA_TRASLADO,101), ")
                meteSQL(" ACT_TRASLADO_ENC.RESPONSABLE_ID, ")
                meteSQL(" ACT_TRASLADO_ENC.NUEVO_RESPONSABLE, ")
                meteSQL(" ACT_TRASLADO_ENC.ESTADO_TRASLADO_ACT, ")
                meteSQL(" IsNull(ACT_TRASLADO_ENC.TIPO_TRANSLADO, 'T'),")
                meteSQL(" ACT_TRASLADO_ENC.timestamp ")
                meteSQL(" from ACT_TRASLADO_ENC")
                meteSQL(" where ACT_TRASLADO_ENC.TRASLADO_ID_ACT = " & sen(txtTRASLADO_ID_ACT.GetValor()))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtFECHA_TRASLADO.EscribirFecha(SqlData(Sqlconn, 1).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtRESPONSABLE_ID.Text = SqlData(Sqlconn, 2).ToString
                    txtNUEVO_RESPONSABLE.Text = SqlData(Sqlconn, 3).ToString
                    cboESTADO_TRASLADO_ACT.SelectedValue = SqlData(Sqlconn, 4).ToString
                    If SqlData(Sqlconn, 5).ToString = "T" Then
                        TRASLADO.Checked = True
                    ElseIf SqlData(Sqlconn, 5).ToString = "C" Then
                        CAMBIO.Checked = True
                    Else
                        REEMPLAZO.Checked = True
                    End If

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop

                '-- Antes de Leer los que fueron seleccionados lleno los grid
                Me.CodigoResponsable_Leave(txtRESPONSABLE_ID, Nothing)
                Me.CodigoResponsable_Leave(txtNUEVO_RESPONSABLE, Nothing)

                Me.LeerActivosOrigen()
            End If

            MyBase.Habilitar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LeerActivosOrigen()
        '*************************************
        'Recorro el grid y comparo para saber a cuales filas les pongo el cheque.
        '*************************************
        For Each filaGrid As DataGridViewRow In Me.grdOrigen.Rows
            Dim codigoActivo = filaGrid.Cells(0).Value.ToString
            Dim mejoraCorrelativo = filaGrid.Cells(1).Value.ToString

            Dim cantidad As Integer = 0
            If Not String.IsNullOrEmpty(TraeDato("Select IsNull(Count(1), 0) From ACT_TRASLADO_DET Where TRASLADO_ID_ACT = " & sen(txtTRASLADO_ID_ACT.Text) & " And CODIGO_DE_ACTIVO = " & Scm(codigoActivo) & " And MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo))) Then
                cantidad = CType(TraeDato("Select IsNull(Count(1), 0) From ACT_TRASLADO_DET Where TRASLADO_ID_ACT = " & sen(txtTRASLADO_ID_ACT.Text) & " And CODIGO_DE_ACTIVO = " & Scm(codigoActivo) & " And MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo)), Integer)
            End If

            If cantidad > 0 Then
                filaGrid.Cells(3).Value = True
            End If
        Next
    End Sub

    Private Sub LeerActivosResponsableOrigen()
        '-- Limpio las filas del grid
        Me.grdOrigen.Rows.Clear()

        Dim comandoSQL As New System.Text.StringBuilder
        With comandoSQL
            .Append(" Select CODIGO_DE_ACTIVO")
            .Append("      , MEJORA_CORRELATIVO")
            .Append("      , DESCRIP_CORTA_ACTIVO")
            .Append("   From ACTIVOS_FIJOS")
            .Append("  Where RESPONSABLE_ID = " & Scm(txtRESPONSABLE_ID.Text))
        End With

        Dim comando As New SqlClient.SqlCommand
        With comando
            .CommandText = comandoSQL.ToString
        End With

        Try
            Dim dsActivos As DataSet = GetDataSet(comando)

            If Not dsActivos Is Nothing Then
                If dsActivos.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsActivos.Tables(0).Rows
                        Dim filaGrid As New DataGridViewRow
                        filaGrid.CreateCells(Me.grdOrigen)
                        filaGrid.Cells(0).Value = filaData.Item(0).ToString
                        filaGrid.Cells(1).Value = filaData.Item(1).ToString
                        filaGrid.Cells(2).Value = filaData.Item(2).ToString
                        filaGrid.Cells(3).Value = False

                        Me.grdOrigen.Rows.Add(filaGrid)
                    Next
                End If
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LeerActivosResponsableDestino()
        '-- Limpio las filas del grid
        Me.grdDestino.Rows.Clear()

        Dim comandoSQL As New System.Text.StringBuilder
        With comandoSQL
            .Append(" Select CODIGO_DE_ACTIVO")
            .Append("      , MEJORA_CORRELATIVO")
            .Append("      , DESCRIP_CORTA_ACTIVO")
            .Append("   From ACTIVOS_FIJOS")
            .Append("  Where RESPONSABLE_ID = " & Scm(txtNUEVO_RESPONSABLE.Text))
        End With

        Dim comando As New SqlClient.SqlCommand
        With comando
            .CommandText = comandoSQL.ToString
        End With

        Try
            Dim dsActivos As DataSet = GetDataSet(comando)

            If Not dsActivos Is Nothing Then
                If dsActivos.Tables.Count > 0 Then
                    For Each filaData As DataRow In dsActivos.Tables(0).Rows
                        Dim filaGrid As New DataGridViewRow
                        filaGrid.CreateCells(Me.grdDestino)
                        filaGrid.Cells(0).Value = filaData.Item(0).ToString
                        filaGrid.Cells(1).Value = filaData.Item(1).ToString
                        filaGrid.Cells(2).Value = filaData.Item(2).ToString

                        Me.grdDestino.Rows.Add(filaGrid)
                    Next
                End If
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CodigoResponsable_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRESPONSABLE_ID.Leave, txtNUEVO_RESPONSABLE.Leave
        Select Case sender.Name
            Case "txtRESPONSABLE_ID"
                lblNOMBRE_USUAL.Text = DescripcionesDB.NombreUsualResponsable(txtRESPONSABLE_ID.Text)
                Me.LeerActivosResponsableOrigen()
            Case "txtNUEVO_RESPONSABLE"
                lblNUEVO_NOMBRE_USUAL.Text = DescripcionesDB.NombreUsualResponsable(txtNUEVO_RESPONSABLE.Text)
                Me.LeerActivosResponsableDestino()
        End Select
    End Sub

    Private Sub LabelCodigoResponsable_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitRESPONSABLE_ID.DoubleClick, lblTitNUEVO_RESPONSABLE.DoubleClick
        Select Case sender.Name
            Case "lblTitRESPONSABLE_ID"
                txtRESPONSABLE_ID.GenerarConsulta()
            Case "lblTitNUEVO_RESPONSABLE"
                txtNUEVO_RESPONSABLE.GenerarConsulta()
        End Select
    End Sub

    Private Sub Opciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRASLADO.CheckedChanged, CAMBIO.CheckedChanged, REEMPLAZO.CheckedChanged
        If sender.Checked Then
            Select Case sender.Name
                Case "TRASLADO"
                    Check3D1.Checked = False
                    Check3D1.Enabled = True
                Case "CAMBIO"
                    Check3D1.Checked = True
                    Check3D1.Enabled = False
                Case "REEMPLAZO"
                    Check3D1.Checked = True
                    Check3D1.Enabled = False
            End Select
        End If
    End Sub

    Private Sub SeleccionarTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check3D1.CheckedChanged
        For Each filaGrid As DataGridViewRow In Me.grdOrigen.Rows
            filaGrid.Cells(3).Value = Check3D1.Checked
        Next
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim comandoSQL As New System.Text.StringBuilder
        With comandoSQL
            'Actualizamos los responsables de los activos
            If TRASLADO.Checked Then
                .Append("Update ACTIVOS_FIJOS")
                .Append("   Set ACTIVOS_FIJOS.RESPONSABLE_ID = " & Scm(txtNUEVO_RESPONSABLE.Text))
                .Append("  From ACT_TRASLADO_DET")
                .Append("     , ACT_TRASLADO_ENC")
                .Append(" Where ACTIVOS_FIJOS.CODIGO_DE_ACTIVO = ACT_TRASLADO_DET.CODIGO_DE_ACTIVO")
                .Append("   And ACT_TRASLADO_ENC.TRASLADO_ID_ACT = ACT_TRASLADO_DET.TRASLADO_ID_ACT")
                .Append("   And ACT_TRASLADO_ENC.TRASLADO_ID_ACT = " & sen(txtTRASLADO_ID_ACT.Text))
            Else
                .Append("Update ACTIVOS_FIJOS")
                If CAMBIO.Checked Then
                    .Append("   Set RESPONSABLE_ID = Case RESPONSABLE_ID When " & Scm(txtNUEVO_RESPONSABLE.Text) & " Then " & Scm(txtRESPONSABLE_ID.Text) & " Else " & Scm(txtNUEVO_RESPONSABLE.Text) & " End")
                    .Append(" Where RESPONSABLE_ID In (" & Scm(txtRESPONSABLE_ID.Text) & ", " & Scm(txtNUEVO_RESPONSABLE.Text) & ")")
                End If
                If REEMPLAZO.Checked Then
                    .Append("   Set RESPONSABLE_ID = Case RESPONSABLE_ID When " & Scm(txtNUEVO_RESPONSABLE.Text) & " Then Null Else " & Scm(txtNUEVO_RESPONSABLE.Text) & " End")
                    .Append(" Where RESPONSABLE_ID In (" & Scm(txtRESPONSABLE_ID.Text) & ", " & Scm(txtNUEVO_RESPONSABLE.Text) & ")")
                End If
            End If
        End With

        Try
            EjecutarComando(comandoSQL.ToString)

            comandoSQL.Clear()
            With comandoSQL
                .Append("Update ACT_TRASLADO_ENC")
                .Append("   Set ACT_TRASLADO_ENC.ESTADO_TRASLADO_ACT = 'A'")
                .Append(" Where ACT_TRASLADO_ENC.TRASLADO_ID_ACT = " & sen(txtTRASLADO_ID_ACT.Text))
            End With

            EjecutarComando(comandoSQL.ToString)

            Citi.Synergia.HelperClient.Utils.CITIMsgBox("Se trasladaron correctamente los activos", Utils.TipoDeMensaje.TipoAviso)

            Grabado = True
            HubieronCambios = True

            Me.Close()

        Catch errSQL As SqlClient.SqlException
            Citi.Synergia.HelperClient.Utils.CITIMsgBox("Hubo error al trasladar los activos", Utils.TipoDeMensaje.TipoError)
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Citi.Synergia.HelperClient.Utils.CITIMsgBox("Hubo error al trasladar los activos", Utils.TipoDeMensaje.TipoError)
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class