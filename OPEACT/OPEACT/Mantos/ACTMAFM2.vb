Public Class ACTMAFM2
    Private Consultando As Boolean = False 'Determina si esta en modalidad de consulta o no
    Private varTIPO_DE_REVALUACION As String = String.Empty
    Private varESTADO_DE_REVALUACION As String = String.Empty

    Private _llave As String = String.Empty

    Private _dsRevaluaciones As New DataSet
    Private _dsDetalle As New DataSet

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LeerIco(Me)

        Modo = Modo_Local

        MyBase.Limpiar()

        lblCODIGO_REVALUACION.Text = Pop()

        If lblCODIGO_REVALUACION.Text.StartsWith("*C*") Then
            Consultando = True
            lblCODIGO_REVALUACION.Text = Mid(lblCODIGO_REVALUACION.Text, 4)
        Else
            Consultando = False
        End If

        Me.LlenarEncab()

        Me.LlenaGrid()

        Me.MuestraCampos()

        Grabado = False
    End Sub

    Private Sub LlenarEncab()
        Try
            meteSQL(" SELECT REVALUACION_ENC.DESC_REVALUACION, REVALUACION_ENC.TIPO_DE_REVALUACION, DIVISIONES.CODIGO_DIVISION,")
            meteSQL("        DIVISIONES.DESCRIPCION_DIVISION, TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO, TIPOS_DE_ACTIVOS.DESCRIP_TIPO_ACTIVO, CONVERT(varchar(10),")
            meteSQL("        REVALUACION_ENC.FECHA_DE_REVALUACION, 103) AS Expr1, REVALUACION_ENC.ESTADO_REVALUACION,")
            meteSQL("        REVALUACION_ENC.PORCENTAJE_REVAL")
            meteSQL(" FROM   DIVISIONES RIGHT OUTER JOIN")
            meteSQL("        REVALUACION_ENC ON DIVISIONES.CODIGO_DIVISION = REVALUACION_ENC.CODIGO_DIVISION LEFT OUTER JOIN")
            meteSQL("        TIPOS_DE_ACTIVOS ON REVALUACION_ENC.CODIGO_TIPO_ACTIVO = TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO")
            meteSQL(" where REVALUACION_ENC.CODIGO_REVALUACION      = " & sen(lblCODIGO_REVALUACION.Text))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblDESC_REVALUACION.Text = SqlData(Sqlconn, 1).ToString
                varTIPO_DE_REVALUACION = SqlData(Sqlconn, 2).ToString
                lblCODIGO_DIVISION.Text = SqlData(Sqlconn, 3).ToString
                lblDESCRIPCION_DIVISION.Text = SqlData(Sqlconn, 4).ToString
                lblCODIGO_TIPO_ACTIVO.Text = SqlData(Sqlconn, 5).ToString
                lblDESCRIP_TIPO_ACTIVO.Text = SqlData(Sqlconn, 6).ToString
                lblFECHA_CALCULO.Text = SqlData(Sqlconn, 7).ToString
                varESTADO_DE_REVALUACION = SqlData(Sqlconn, 8).ToString
                lblporcentaje.Text = SqlData(Sqlconn, 9).ToString
            Loop

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenaGrid()
        Try
            Grid.Rows.Clear()

            'Obtenemos De Activos Los Registros y Los Grabamos Al Detalle
            'Posteriormente El Detalle Nos Servira Para LLenar El Grid
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Graba_Revaluaciones"
                .Parameters.Add("@CODIGO_REVALUACION", SqlDbType.Int).Value = lblCODIGO_REVALUACION.Text
                .Parameters.Add("@TIPO_DE_REVALUACION", SqlDbType.Char, 1).Value = varTIPO_DE_REVALUACION
                .Parameters.Add("@CODIGO_DIVISION", SqlDbType.Char, 10).Value = lblCODIGO_DIVISION.Text
                .Parameters.Add("@CODIGO_TIPO_ACTIVO", SqlDbType.Char, 7).Value = lblCODIGO_TIPO_ACTIVO.Text
                .Parameters.Add("@PORCENTAJE", SqlDbType.Float).Value = lblporcentaje.Text
            End With
            For i As Integer = 0 To comando.Parameters.Count - 1
                comando.Parameters(i).Direction = ParameterDirection.Input
            Next
            Dim parametro As SqlClient.SqlParameter
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@CODIGO_REVALUACION"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Int
                .Value = lblCODIGO_REVALUACION.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@TIPO_DE_REVALUACION"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 1
                .Value = varTIPO_DE_REVALUACION
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@CODIGO_DIVISION"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 10
                .Value = lblCODIGO_DIVISION.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@CODIGO_TIPO_ACTIVO"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 7
                .Value = lblCODIGO_TIPO_ACTIVO.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@PORCENTAJE"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Float
                .Value = lblporcentaje.Text
            End With

            Me._dsRevaluaciones = GetDataSet(comando)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        DefineGrid()

        Try
            'Ahora Sacaremos Del Detalle Los Registros Para Meterlos Al Grid
            Dim comandoSQL As New System.Text.StringBuilder()
            With comandoSQL
                .Append("select AF.CODIGO_DE_ACTIVO")
                .Append("     , str(AF.MEJORA_CORRELATIVO,3,0)")
                .Append("     , AF.DESCRIP_CORTA_ACTIVO")
                .Append("     , isnull(RD.MONTO_REVALUACION, 0)")
                .Append("     , isnull(RD.TASA_REVALUACION, 0)")
                .Append("     , IsNull(AF.VALOR_ORIGINAL_ACTIV, 0)")
                .Append("     , IsNull(AF.VALOR_ACTUAL_ACTIVO, 0)")
                .Append("  from ACTIVOS_FIJOS AF,REVALUACION_DET RD")
                .Append(" where RD.CODIGO_REVALUACION = " & sen(lblCODIGO_REVALUACION.Text))
                .Append("   and AF.CODIGO_DE_ACTIVO   = RD.CODIGO_DE_ACTIVO")
                .Append("   and AF.MEJORA_CORRELATIVO = RD.MEJORA_CORRELATIVO")
            End With
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandText = comandoSQL.ToString
            End With

            Me._dsDetalle = GetDataSet(comando)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Not Me._dsDetalle Is Nothing Then
            If Me._dsDetalle.Tables.Count > 0 Then
                For Each filaData As DataRow In Me._dsDetalle.Tables(0).Rows
                    Dim filaGrid As New DataGridViewRow
                    filaGrid.CreateCells(Me.Grid)
                    filaGrid.Cells(0).Value = filaData.Item(0).ToString & " - " & filaData.Item(1).ToString
                    filaGrid.Cells(1).Value = filaData.Item(2).ToString

                    '-- Para control de grabar y eliminar
                    filaGrid.Cells(0).Tag = filaData.Item(0).ToString  '-- Código de Activo
                    filaGrid.Cells(1).Tag = filaData.Item(1).ToString  '-- Mejora correlativo

                    filaGrid.Cells(2).Value = String.Format("{0:0,0.00}", filaData.Item(3))
                    filaGrid.Cells(3).Value = String.Format("{0:0.00000}", filaData.Item(4))
                    filaGrid.Cells(4).Value = String.Format("{0:0,0.00}", filaData.Item(5))
                    filaGrid.Cells(5).Value = String.Format("{0:0,0.00}", filaData.Item(6))
                    '-- Agrego la fila al grid
                    Me.Grid.Rows.Add(filaGrid)
                Next
            End If
        End If
    End Sub

    Private Sub DefineGrid()
        '-- 2011: No se usará en este método
        'Dim numeroFilas As Integer = 0
        'If Not String.IsNullOrEmpty(TraeDato("select IsNull(count(*), 0) from REVALUACION_DET where CODIGO_REVALUACION = " & sen(lblCODIGO_REVALUACION.Text))) Then
        '    numeroFilas = CType(TraeDato("select IsNull(count(*), 0) from REVALUACION_DET where CODIGO_REVALUACION = " & sen(lblCODIGO_REVALUACION.Text)), Integer)
        'End If

        Me.Grid.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(233, "Activo Fijo")
        Me.Grid.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(12, "Descripción")
        Me.Grid.Columns(2).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(234, "Monto Revaluación")
        Me.Grid.Columns(3).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(235, "Tasa de Cambio")
        Me.Grid.Columns(4).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(121, "Valor Original")
        Me.Grid.Columns(5).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(122, "Valor Actual")

        'Armamos condiciones de Encabezado
        _llave = " where CODIGO_REVALUACION = " & sen(lblCODIGO_REVALUACION.Text)

        If Consultando Then 'Se protege todo el Grid
            For Each columnaGrid As DataGridViewTextBoxColumn In Grid.Columns
                columnaGrid.ReadOnly = True
            Next
        End If
    End Sub

    Private Sub MuestraCampos()
        Dim muestraDivision As Boolean
        Dim muestraTipo As Boolean

        If varTIPO_DE_REVALUACION.StartsWith("T") Then
            muestraDivision = False
            muestraTipo = True
        ElseIf varTIPO_DE_REVALUACION.StartsWith("D") Then
            muestraDivision = True
            muestraTipo = False
            lblTitCODIGO_DIVISION.Top = 34
            lblCODIGO_DIVISION.Top = 33
            lblDESCRIPCION_DIVISION.Top = lblTitCODIGO_DIVISION.Top

        Else
            muestraDivision = False
            muestraTipo = False
        End If
        lblTitCODIGO_TIPO_ACTIVO.Visible = muestraTipo
        lblCODIGO_TIPO_ACTIVO.Visible = muestraTipo
        lblDESCRIP_TIPO_ACTIVO.Visible = muestraTipo
        lblTitCODIGO_DIVISION.Visible = muestraDivision
        lblCODIGO_DIVISION.Visible = muestraDivision
        lblDESCRIPCION_DIVISION.Visible = muestraDivision
    End Sub

    Private Sub CambiosEnGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.CurrentCellDirtyStateChanged
        If Grid.IsCurrentCellDirty Then
            Grid.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub Grid_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyUp
        If e.Shift = True Then
            Select Case e.KeyCode
                Case Keys.Delete
                    Dim fila As Integer = Grid.SelectedCells(0).RowIndex
                    Me.BorraLineas(fila)
            End Select
        End If
    End Sub

    Private Sub BorraLineas(ByVal fila As Integer)
        Try
            'Si es modalidad Consulta se sale de la grabacion
            If Consultando Then
                Return
            End If

            Dim codigoActivo As String = String.Empty
            Dim mejoraCorrelativo As String = String.Empty

            With Grid.Rows(fila)
                codigoActivo = .Cells(0).Tag.ToString
                mejoraCorrelativo = .Cells(1).Tag.ToString
            End With

            'Armamos Actualizacion o Inserción

            meteSQL(" if exists ( select * from REVALUACION_DET")
            meteSQL(_llave)
            meteSQL(" and CODIGO_DE_ACTIVO = " & Scm(codigoActivo))
            meteSQL(" and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo) & ")")
            meteSQL(" Begin")  '-- Actualizacion
            meteSQL("     Delete REVALUACION_DET")
            meteSQL(_llave)
            meteSQL("     and CODIGO_DE_ACTIVO = " & Scm(codigoActivo))
            meteSQL("     and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo))
            meteSQL(" End")

            EjecutaSQL("")

            Me.LlenaGrid()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grid_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles Grid.CellValidating
        Select Case e.ColumnIndex
            Case 2  '-- Monto Revaluación
                If Not IsNumeric(Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                    e.Cancel = True
                Else
                    Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Format("{0:0,0.00}", CType(Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Decimal))
                End If
        End Select
    End Sub

    Private Sub Grid_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellEndEdit
        Try
            Select Case e.ColumnIndex
                Case 2
                    '-- Grabo los cambios
                    If Consultando Then
                        Return
                    End If

                    Dim codigoActivo As String = String.Empty
                    Dim mejoraCorrelativo As String = String.Empty
                    Dim montoRevaluacion As String = String.Empty
                    Dim tasaRevaluacion As String = String.Empty

                    With Grid.Rows(e.RowIndex)
                        If Not String.IsNullOrEmpty(.Cells(2).Value) Then
                            If .Cells(2).Value.ToString.Trim.Length > 0 Then
                                '-- Hago un proceso para quitarle las comas a la cantidad
                                montoRevaluacion = CType(.Cells(2).Value, Decimal).ToString
                            Else
                                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(319, "Debe especificar el monto de revaluación."), Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        Else
                            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(319, "Debe especificar el monto de revaluación."), Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        If Not String.IsNullOrEmpty(.Cells(3).Value) Then
                            If .Cells(3).Value.ToString.Trim.Length > 0 Then
                                '-- Hago un proceso para quitarle las comas a la cantidad
                                tasaRevaluacion = CType(.Cells(3).Value, Decimal).ToString
                            Else
                                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(320, "Debe especificar la tasa de revaluación."), Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        Else
                            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(320, "Debe especificar la tasa de revaluación."), Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        codigoActivo = .Cells(0).Tag.ToString
                        mejoraCorrelativo = .Cells(1).Tag.ToString
                    End With

                    'Armamos Actualizacion o Inserción
                    meteSQL(" if exists ( select * from REVALUACION_DET")
                    meteSQL(_llave)
                    meteSQL(" and CODIGO_DE_ACTIVO = " & Scm(codigoActivo))
                    meteSQL(" and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo) & ")")
                    meteSQL(" Begin")  '-- Actualizacion
                    meteSQL("     update REVALUACION_DET")
                    meteSQL("        set MONTO_REVALUACION   = " & sen(montoRevaluacion))
                    meteSQL("            ,TASA_REVALUACION   = " & sen(tasaRevaluacion))
                    meteSQL(_llave)
                    meteSQL("     and CODIGO_DE_ACTIVO = " & Scm(codigoActivo))
                    meteSQL("     and MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo))
                    meteSQL(" End")
                    meteSQL(" Else")
                    meteSQL(" Begin")  '-- Ingreso
                    meteSQL("     exec sp_Alta_REVALUACION_DET")
                    meteSQL("          @CODIGO_REVALUACION   = " & sen(lblCODIGO_REVALUACION.Text))
                    meteSQL("        , @CODIGO_DE_ACTIVO = " & Scm(codigoActivo))
                    meteSQL("        , @MEJORA_CORRELATIVO = " & sen(mejoraCorrelativo))
                    meteSQL("        , @MONTO_REVALUACION = " & sen(montoRevaluacion))
                    meteSQL("        , @TASA_REVALUACION = " & sen(tasaRevaluacion))
                    meteSQL(" End")

                    EjecutaSQL("")

            End Select

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class