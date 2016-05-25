Imports Citi.Synergia
Imports Citi.Synergia.HelperClient

Public Class TASASG01
    Public Property FechaInicial As String
    Public Property FechaFinal As String
    Public Property CodigoMoneda As String
    Public Property TasaTipo As String

    Private _primerLlenado As Boolean = False

    '-- Para crear el grid
    Private _dsFilas As New DataSet
    Private _dsFechasFilas As New DataSet
    Private _dsTuplas As New DataSet

    Private _filas As New List(Of String)
    Private _columnas As New List(Of String)

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuExportarAExcel.Text = Me.BotonExportarAExcel.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Imprimir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.ExportarAExcel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
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

        MyBase.Limpiar()

        '-- Las fechas vienen en formato mm/dd/aaaa
        txtFEC_INICIAL.EscribirFecha(Me.FechaInicial, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
        txtFEC_FINAL.EscribirFecha(Me.FechaFinal, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)

        txtCODIGO_DE_MONEDA.Text = Me.CodigoMoneda

        If Me.CodigoMoneda.Trim.Length > 0 Then
            lblDESCRIPCION_MONEDA.Text = DescripcionesDB.Monedas(Me.CodigoMoneda)
        End If

        Me._primerLlenado = False

        'Inicialización del texto de los combos
        Me.LlenarCombos()

        'Llena el grid
        Me.LlenarGrid()

        txtFEC_INICIAL.Enabled = False
        txtFEC_FINAL.Enabled = False
        txtCODIGO_DE_MONEDA.Enabled = False
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
            Me._primerLlenado = False
            .DataSource = cambioTasas
        End With

        Select Case Me.TasaTipo
            Case "D"
                Me.cboTIP_CAMBIO_TASAS_CAM.SelectedValue = "D"
            Case "H"
                Me.cboTIP_CAMBIO_TASAS_CAM.SelectedValue = "H"
            Case "P"
                Me.cboTIP_CAMBIO_TASAS_CAM.SelectedValue = "P"
        End Select
    End Sub

    Private Sub LlenarGrid()
        Me.SqlLlenaGrid()
        If Me.LlenaGrid() Then
            BotonExportarAExcel.Enabled = True
        Else
            BotonExportarAExcel.Enabled = False
        End If
    End Sub

    Private Sub SqlLlenaGrid()
        Try
            Dim inicial As String = String.Empty
            Dim final As String = String.Empty

            inicial = txtFEC_INICIAL.TextMMDDYYYY()
            final = txtFEC_FINAL.TextMMDDYYYY()

            'Devuelve el número de filas
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "select NumFilas=count(distinct FECHA_DE_LA_TASA) from TASAS_DE_CAMBIO where FECHA_DE_LA_TASA between '" & inicial & "' and '" & final & "'"
                If Me.CodigoMoneda.Trim.Length > 0 Then
                    .CommandText += " and TASAS_DE_CAMBIO.CODIGO_DE_MONEDA = '" & Me.CodigoMoneda & "'"
                End If
                If Me.TasaTipo.Trim.Length > 0 Then
                    .CommandText += " and TASAS_DE_CAMBIO.TIP_CAMBIO_TASAS_CAM = '" & Me.TasaTipo & "'"
                End If
            End With
            Me._dsFilas = GetDataSet(comando)

            'Devuelve el número de valores dIferentes del campo fila
            comando = New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "select distinct Fila=convert(varchar(10),FECHA_DE_LA_TASA,103), FECHA_DE_LA_TASA from TASAS_DE_CAMBIO where FECHA_DE_LA_TASA between '" & inicial & "' and '" & final & "'"
                If Me.CodigoMoneda.Trim.Length > 0 Then
                    .CommandText += " and TASAS_DE_CAMBIO.CODIGO_DE_MONEDA = '" & Me.CodigoMoneda & "'"
                End If
                If Me.TasaTipo.Trim.Length > 0 Then
                    .CommandText += " and TASAS_DE_CAMBIO.TIP_CAMBIO_TASAS_CAM = '" & Me.TasaTipo & "'"
                End If
                .CommandText += " order by FECHA_DE_LA_TASA"
            End With
            Me._dsFechasFilas = GetDataSet(comando)

            'Devuelve el número de valores dIferentes del campo columna
            'metesql "select distinct Columna='Venta'"

            'Devuelve todas las tuplas para llenar el grid
            comando = New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "select Fila=convert(varchar(10),FECHA_DE_LA_TASA,103), Columna1=TASA_CONVERSION, Columna2=TASA_COMPRA, Columna3=((TASA_COMPRA + TASA_CONVERSION) / 2) from TASAS_DE_CAMBIO"
                Dim sep As String
                sep = " where "
                Dim q As String = String.Empty
                If Me.CodigoMoneda.Trim.Length > 0 Then
                    q = sep & "TASAS_DE_CAMBIO.CODIGO_DE_MONEDA = '" & Me.CodigoMoneda & "'"
                    sep = " And "
                End If
                If Me.TasaTipo.Trim.Length > 0 Then
                    q = q & sep & "TASAS_DE_CAMBIO.TIP_CAMBIO_TASAS_CAM = '" & Me.TasaTipo & "'"
                    sep = " And "
                End If
                q = q & sep & "TASAS_DE_CAMBIO.FECHA_DE_LA_TASA between '" & inicial & "' and '" & final & "'"
                If q.Trim.Length > 0 Then
                    .CommandText += q
                End If
            End With
            Me._dsTuplas = GetDataSet(comando)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function LlenaGrid() As Boolean
        Dim retorno As Boolean = False

        Me.grdCG.Rows.Clear()
        Me.grdCG.Columns.Clear()
        Me._filas.Clear()
        Me._columnas.Clear()

        '-- Agrego las columnas al grid
        'Guarda los diferentes valores de las Columnas
        Dim cellStyle As New DataGridViewCellStyle
        With cellStyle
            .Alignment = DataGridViewContentAlignment.MiddleLeft
            .NullValue = ""
        End With

        Dim columna As DataGridViewTextBoxColumn
        columna = New DataGridViewTextBoxColumn
        With columna
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .DefaultCellStyle = cellStyle
            .ReadOnly = True
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(207, "Fecha / Tasa de cambio")
        End With
        Me.grdCG.Columns.Add(columna)

        cellStyle = New DataGridViewCellStyle
        With cellStyle
            .Alignment = DataGridViewContentAlignment.MiddleRight
            .Format = "{0:0,0.00}"
            .NullValue = ""
        End With

        columna = New DataGridViewTextBoxColumn
        With columna
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .ReadOnly = True
            .DefaultCellStyle = cellStyle
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(205, "Venta")
        End With
        Me.grdCG.Columns.Add(columna)
        Me._columnas.Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(205, "Venta"))

        columna = New DataGridViewTextBoxColumn
        With columna
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .DefaultCellStyle = cellStyle
            .ReadOnly = True
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(206, "Compra")
        End With
        Me.grdCG.Columns.Add(columna)
        Me._columnas.Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(206, "Compra"))

        columna = New DataGridViewTextBoxColumn
        With columna
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .DefaultCellStyle = cellStyle
            .ReadOnly = True
            .HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(196, "Promedio")
        End With
        Me.grdCG.Columns.Add(columna)
        Me._columnas.Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(196, "Promedio"))

        LimpiaGrid()

        Dim numeroFilas As Integer = 0
        'Define el número de Filas del grid
        If Not Me._dsFilas Is Nothing Then
            If Me._dsFilas.Tables.Count > 0 Then
                For Each filaData As DataRow In Me._dsFilas.Tables(0).Rows
                    numeroFilas = CType(filaData.Item("NumFilas"), Integer) + 1
                Next
            End If
        End If

        'Define el número de Columnas del grid
        'Devuelve el número de columnas
        'meteSQL("select NumCols=3")
        Dim numeroColumnas As Integer = 3 + 1

        If numeroColumnas <= 1 Or numeroFilas <= 1 Then
            Me.grdCG.Enabled = False
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(204, "No hay datos en las tablas."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return retorno
        End If

        'Guarda los diferentes valores de las filas
        If Not Me._dsFechasFilas Is Nothing Then
            If Me._dsFechasFilas.Tables.Count > 0 Then
                For Each filaData As DataRow In Me._dsFechasFilas.Tables(0).Rows
                    Me._filas.Add(filaData.Item(0).ToString)
                    Dim filaGrid As New DataGridViewRow
                    filaGrid.CreateCells(Me.grdCG)
                    filaGrid.Cells(0).Value = filaData.Item(0).ToString
                    Me.grdCG.Rows.Add(filaGrid)
                Next
            End If
        End If

        'Rellena las celdas "non-fixed" del grid
        If Not Me._dsTuplas Is Nothing Then
            If Me._dsTuplas.Tables.Count > 0 Then
                For Each filaData As DataRow In Me._dsTuplas.Tables(0).Rows
                    For Each filaGrid As DataGridViewRow In Me.grdCG.Rows
                        If filaData.Item("Fila").ToString.Trim = filaGrid.Cells(0).Value.ToString.Trim Then
                            filaGrid.Cells(1).Value = filaData.Item("Columna1").ToString
                            filaGrid.Cells(2).Value = filaData.Item("Columna2").ToString
                            filaGrid.Cells(3).Value = filaData.Item("Columna3").ToString
                        End If
                    Next
                Next
            End If
        End If

        retorno = True

        Return retorno
    End Function

    Private Sub LimpiaGrid()
        For i As Integer = 0 To Me.grdCG.Columns.Count - 1
            For Each fila As DataGridViewRow In Me.grdCG.Rows
                fila.Cells(i).Value = "0.00"
            Next
        Next
    End Sub

    Private Sub CodigoMoneda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_DE_MONEDA.DoubleClick
        Me.txtCODIGO_DE_MONEDA.GenerarConsulta()
    End Sub

    Private Sub CodigoMoneda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DE_MONEDA.TextChanged
        If Me._primerLlenado Then
            lblDESCRIPCION_MONEDA.Text = DescripcionesDB.Monedas(Me.CodigoMoneda)
            Me.LlenarGrid()
        End If
        Me._primerLlenado = True
    End Sub

    Private Sub TipoCambioTasas_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTIP_CAMBIO_TASAS_CAM.SelectedValueChanged
        If Me._primerLlenado Then
            Me.TasaTipo = Me.cboTIP_CAMBIO_TASAS_CAM.SelectedValue.ToString
            Me.LlenarGrid()
        End If
        Me._primerLlenado = True
    End Sub

    Private Sub Fechas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFEC_INICIAL.DoubleClick, txtFEC_FINAL.DoubleClick, lbltitFEC_INICIAL.DoubleClick, lbltitFEC_FINAL.DoubleClick
        Dim frmFechas As New PIDE_PROD_FEC
        With frmFechas
            .Producto = "Falso"
            .FechaInicial = txtFEC_INICIAL.TextMMDDYYYY()
            .FechaFinal = txtFEC_FINAL.TextMMDDYYYY()
            .ShowDialog()
            If .FechaInicial <> "99/99/9999" And .FechaFinal <> "99/99/9999" Then
                txtFEC_INICIAL.EscribirFecha(.FechaInicial, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                txtFEC_FINAL.EscribirFecha(.FechaFinal, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                .Dispose()
                Me.LlenarGrid()
            End If
        End With
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub ExportarAExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonExportarAExcel.Click, mnuExportarAExcel.Click
        Dim TipoCambio As String = String.Empty

        If Me.TasaTipo = "D" Then
            TipoCambio = "Diario"
        Else
            If Me.TasaTipo = "H" Then
                TipoCambio = "Histórico"
            Else
                If Me.TasaTipo = "P" Then
                    TipoCambio = "Promedio"
                End If
            End If
        End If

        '-- Pregunta al usuario dónde quiere guardar el archivo
        Dim pathDestino As String = String.Empty
        Dim dlgGuardar As New SaveFileDialog
        With dlgGuardar
            .Title = Citi.Synergia.Traductor.Idiomas.GetMensaje(302, "Documentos PDF.").Replace("PDF", "").Replace(" ", "")
            .DefaultExt = ".xls"
            .FileName = Citi.Synergia.Traductor.Idiomas.GetMensaje(235, "Tasas de Cambio")
            .Filter = "Excel (xls)|*.xls"
            If .ShowDialog() <> DialogResult.OK Then
                Return
            End If
            pathDestino = .FileName
            .Dispose()
        End With

        Dim titulosGrid As New List(Of String)
        With titulosGrid
            .Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(235, "Tasas de Cambio"))
            .Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(304, "De") & ": " & txtFEC_INICIAL.Text & " " & Citi.Synergia.Traductor.Idiomas.GetMensaje(305, "A") & ": " & txtFEC_FINAL.Text)
            .Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(40, "Moneda") & ": " & LTrim(txtCODIGO_DE_MONEDA.Text))
            .Add(Citi.Synergia.Traductor.Idiomas.GetMensaje(235, "Tipo Cambio") & ": " & LTrim(TipoCambio))
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