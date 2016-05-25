Imports Citi.Synergia.Iconos

Public Class ACTTACG0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuExportarAExcel.Text = Me.BotonExportarAExcel.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Exportar a Excel
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ExportarAExcel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonExportarAExcel.Image = Me.IconosMenus.Images(0)
            Me.mnuExportarAExcel.Image = Me.BotonExportarAExcel.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(1)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Llena el grid
        Me.LlenarGrid()
    End Sub

    Private Sub LlenarGrid()
        Me.SqlLlenaGrid()
        If Me.LlenaGrid() Then
            'Me.BotonGraficar.Enabled = True
        Else
            'Me.BotonGraficar.Enabled = False
        End If
        'Me.mnuGraficar.Enabled = Me.BotonGraficar.Enabled
    End Sub

    Private Sub SqlLlenaGrid()
        Try
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Totales_Activos_Por_Tipo"
            End With

            '-- Ese SP devuelve 2 tablas, en la primera devuelve el total de filas de la segunda
            '-- Se utilizará más la 2da tabla
            Me._dsData = GetDataSet(comando)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function LlenaGrid() As Boolean
        '-- Este método llena el grid con la información de _dsData
        Dim retorno As Boolean = False

        If Not Me._dsData Is Nothing Then
            If Me._dsData.Tables.Count > 0 Then
                Dim totalValorOriginal As String = String.Empty
                Dim totalValorActual As String = String.Empty
                Dim totalDepreciacion As String = String.Empty

                Me.LimpiaGrid()

                '-- Las columnas van a ser 4: Descripcion, Valor Original, Valor Actual, Depreciacion Acumulada
                Dim cantidadColumnas As Integer = 4
                Dim columna As DataGridViewTextBoxColumn
                columna = New DataGridViewTextBoxColumn
                With columna
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .ReadOnly = True
                    .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(33, "Tipo de activo")
                    .Frozen = True
                End With
                Me.grdCG.Columns.Add(columna)

                Dim cellStyle As New DataGridViewCellStyle
                With cellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "{0:0,0.00}"
                    .NullValue = ""
                End With

                columna = New DataGridViewTextBoxColumn
                With columna
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .DefaultCellStyle = cellStyle
                    .ReadOnly = True
                    .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(121, "Valor original")
                End With
                Me.grdCG.Columns.Add(columna)

                columna = New DataGridViewTextBoxColumn
                With columna
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .DefaultCellStyle = cellStyle
                    .ReadOnly = True
                    .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(122, "Valor actual")
                End With
                Me.grdCG.Columns.Add(columna)

                columna = New DataGridViewTextBoxColumn
                With columna
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle = cellStyle
                    .ReadOnly = True
                    .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(123, "Deprec. Acum.")
                    .MinimumWidth = 100
                End With
                Me.grdCG.Columns.Add(columna)

                '-- Agrego las filas de la 2da. tabla
                For Each fila As DataRow In Me._dsData.Tables(1).Rows
                    Dim filaGrid As New DataGridViewRow
                    filaGrid.CreateCells(Me.grdCG)
                    Dim descripcion As String = fila.Item(0).ToString & " " & fila.Item(1).ToString
                    filaGrid.Cells(0).Value = descripcion
                    '-- Guardo el código del producto
                    filaGrid.Cells(0).Tag = fila.Item(0).ToString
                    totalValorOriginal = String.Format("{0:0,0.00}", fila.Item(2))
                    filaGrid.Cells(1).Value = totalValorOriginal
                    totalValorActual = String.Format("{0:0,0.00}", fila.Item(3))
                    filaGrid.Cells(2).Value = totalValorActual
                    totalDepreciacion = String.Format("{0:0,0.00}", fila.Item(4))
                    filaGrid.Cells(3).Value = totalDepreciacion
                    '--Agrego la fila al grid
                    Me.grdCG.Rows.Add(filaGrid)

                    '-- Las últimas 3 columnas de cada fila contienen los totales
                    '-- que se mostraran en la última fila del grid
                    totalValorOriginal = String.Format("{0:0,0.00}", fila.Item(5))
                    totalValorActual = String.Format("{0:0,0.00}", fila.Item(6))
                    totalDepreciacion = String.Format("{0:0,0.00}", fila.Item(7))
                Next

                '-- Agrego una fila vacía para dejar espacio
                Dim filaExtra As New DataGridViewRow
                filaExtra.CreateCells(Me.grdCG)
                With filaExtra
                    .Cells(0).Value = ""
                    .Cells(0).Tag = ""
                    .Cells(1).Value = ""
                    .Cells(2).Value = ""
                    .Cells(3).Value = ""
                End With
                Me.grdCG.Rows.Add(filaExtra)
                filaExtra = New DataGridViewRow
                filaExtra.CreateCells(Me.grdCG)
                With filaExtra
                    .Cells(0).Value = "Total"
                    .Cells(0).Tag = ""
                    .Cells(1).Value = totalValorOriginal
                    .Cells(2).Value = totalValorActual
                    .Cells(3).Value = totalDepreciacion
                End With
                Me.grdCG.Rows.Add(filaExtra)
            End If
        End If

        retorno = True

        Return retorno
    End Function

    Private Sub LimpiaGrid()
        For i As Integer = 0 To Me.grdCG.Columns.Count - 1
            For Each fila As DataGridViewRow In Me.grdCG.Rows
                fila.Cells(i).Value = "0"
            Next
        Next
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub ExportarAExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonExportarAExcel.Click, mnuExportarAExcel.Click
        '-- Pregunta al usuario dónde quiere guardar el archivo
        Dim pathDestino As String = String.Empty
        Dim dlgGuardar As New SaveFileDialog
        With dlgGuardar
            .Title = Citi.Synergia.Traductor.Idiomas.GetMensaje(302, "Documentos PDF.").Replace("PDF", "").Replace(" ", "")
            .DefaultExt = ".xls"
            .FileName = Citi.Synergia.Traductor.Idiomas.GetMensaje(33, "Tipos de activo")
            .Filter = "Excel (xls)|*.xls"
            If .ShowDialog() <> DialogResult.OK Then
                Return
            End If
            pathDestino = .FileName
            .Dispose()
        End With

        Dim titulosGrid As New List(Of String)
        With titulosGrid
            .Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(33, "Tipo de activo"))
        End With

        Try
            Citi.Synergia.HelperClient.Utils.DataGridViewEnviarAExcel(Me.grdCG, pathDestino, titulosGrid)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class