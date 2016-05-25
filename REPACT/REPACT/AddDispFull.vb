Imports Microsoft.Office.Interop

Public Class AddDispFull
    Private _empresasConAcceso As New List(Of Citi.Synergia.Entidades.Companias)
    Private _empresasSinAcceso As New List(Of Citi.Synergia.Entidades.Companias)

    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.LlenarCombos()

        '-- El grid sólo tiene 3 columnas
        Me.grdEmpresas.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(307, "Seleccionar")
        Me.grdEmpresas.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(342, "Base de Datos")
        Me.grdEmpresas.Columns(2).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(306, "Empresas")

        '-- El grid de empresas sin acceso sólo tiene 2 columna
        Me.grdSinAcceso.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(342, "Base de Datos")
        Me.grdSinAcceso.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(306, "Empresas")

        '-- Valido si el usuario tiene acceso a todas las empresas
        Me.ValidaAcceso()

        '-- Lleno el grid
        Me.LlenoGrid()

        Me.panFechas.Visible = True
        Me.panBarras.Visible = Not Me.panFechas.Visible
    End Sub

    Private Sub LlenarCombos()
        Dim meses As List(Of Citi.Synergia.Entidades.CodigoDescripcion) = Citi.Synergia.HelperClient.Utils.ListaDeMeses()
        With cboMeses
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = meses
        End With
    End Sub

    Private Sub ValidaAcceso()
        '-- Por cada empresa veo si el usuario tiene acceso a la DB abriendo una conexion
        For Each empresa As Citi.Synergia.Entidades.Companias In _companias
            Dim tieneAcceso As Boolean = False

            Try
                Dim conexion As New SqlClient.SqlConnection
                conexion.ConnectionString = "Data Source=" + empresa.Servidor + "; Initial Catalog=" + empresa.BaseDeDatos + "; uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + "; pwd=" + Citi.Synergia.Locals.Cache.Password

                conexion.Open()

                conexion.Close()

                tieneAcceso = True

            Catch ex As Exception
                '-- Si tira error es porque no tiene acceso
                tieneAcceso = False
            End Try

            If tieneAcceso Then
                Me._empresasConAcceso.Add(empresa)
            Else
                Me._empresasSinAcceso.Add(empresa)
            End If
        Next
    End Sub

    Private Sub LlenoGrid()
        If Me._empresasConAcceso.Count > 0 Then
            For Each empresa As Citi.Synergia.Entidades.Companias In Me._empresasConAcceso
                Dim filaGrid As New DataGridViewRow
                filaGrid.CreateCells(grdEmpresas)

                filaGrid.Cells(0).Value = True
                filaGrid.Cells(1).Value = empresa.BaseDeDatos
                filaGrid.Cells(1).Tag = empresa.Servidor
                filaGrid.Cells(2).Value = empresa.Descripcion

                grdEmpresas.Rows.Add(filaGrid)
            Next
        End If

        If Me._empresasSinAcceso.Count > 0 Then
            For Each empresa As Citi.Synergia.Entidades.Companias In Me._empresasSinAcceso
                Dim filaGrid As New DataGridViewRow
                filaGrid.CreateCells(grdSinAcceso)

                filaGrid.Cells(0).Value = empresa.BaseDeDatos
                filaGrid.Cells(1).Value = empresa.Descripcion

                grdSinAcceso.Rows.Add(filaGrid)
            Next
        Else
            Me.grdSinAcceso.Visible = False
            Me.lblSinMostrar.Visible = True
            Me.panSinAcceso.Visible = False
            Me.Height = 430
        End If
    End Sub

    Private Sub AddDispFullDepr(ByVal empresas As List(Of Citi.Synergia.Entidades.Companias), ByVal fechaInicial As String, ByVal fechaFinal As String)
        Try
            '-- Excel
            Dim oExcel As Excel.Application = Nothing
            Dim primeraVez As Boolean = True
            Dim usuario As String = String.Empty

            Dim linea As Integer = 1

            '-- Inicializar control 1
            Me.barBases.Value = 0
            Me.barBases.Maximum = empresas.Count

            If empresas.Count > 0 Then
                Me.panBarras.Visible = True
                Me.panFechas.Visible = False
                Me.panBarras.BringToFront()
                Me.barRegistros.Visible = True
                If empresas.Count > 1 Then
                    Me.barBases.Visible = True
                End If
            End If

            For Each cia As Citi.Synergia.Entidades.Companias In empresas
                Me.barBases.Value += 1
                System.Threading.Thread.Sleep(500)

                Dim conexion As New SqlClient.SqlConnection("Data Source=" + cia.Servidor + "; Initial Catalog=" + cia.BaseDeDatos + "; Uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + ";Pwd=" + Citi.Synergia.Locals.Cache.Password)
                conexion.Open()

                Dim comando As New SqlClient.SqlCommand
                Dim sentenciaSQL As New System.Text.StringBuilder

                With comando
                    .Connection = conexion
                    .CommandText = "Set DateFormat DMY; Select * From dbo.FunAddDispFullDeprReport(@FechaInicial, @FechaFinal, @DiaCalculaDep)"
                    .Parameters.Clear()
                    .Parameters.Add("@FechaInicial", SqlDbType.VarChar).Value = fechaInicial
                    .Parameters.Add("@FechaFinal", SqlDbType.VarChar).Value = fechaFinal
                    .Parameters.Add("@DiaCalculaDep", SqlDbType.TinyInt).Value = Citi.Synergia.Locals.Cache.DiaInicioProcesoDepreciacion
                End With
                Dim puente As New SqlClient.SqlDataAdapter
                puente.SelectCommand = comando

                Dim dsData As New DataSet
                puente.Fill(dsData)

                Dim totalDebito As Decimal = 0
                Dim totalCredito As Decimal = 0

                Dim lineaInicial As Integer = 0
                Dim lineaFinal As Integer = 0

                Dim contadorRegistro As Integer = 0

                If Not dsData Is Nothing Then
                    If dsData.Tables.Count > 0 Then
                        If dsData.Tables(0).Rows.Count > 0 Then
                            If primeraVez Then
                                primeraVez = False
                                oExcel = New Excel.Application
                                oExcel.Workbooks.Add()
                            End If
                            oExcel.Cells(linea, 1) = cia.Descripcion
                            oExcel.Cells(linea, 1).Font.Bold = True
                            oExcel.Cells(linea, 1).font.Size = 20

                            linea += 2

                            oExcel.Cells(linea, 1) = "Start Date:"
                            oExcel.Cells(linea, 2) = fechaInicial
                            oExcel.Cells(linea, 4) = "End Date:"
                            oExcel.Cells(linea, 5) = fechaFinal

                            linea += 2

                            '-- Titulos
                            oExcel.Cells(linea, 1) = "Add/Disp/Full Depr"
                            oExcel.Cells(linea, 1).ColumnWidth = 16
                            oExcel.Cells(linea, 2) = "Asset ID"
                            oExcel.Cells(linea, 2).ColumnWidth = 11
                            oExcel.Cells(linea, 3) = "Country"
                            oExcel.Cells(linea, 4) = "Legal Entity"
                            oExcel.Cells(linea, 4).ColumnWidth = 10
                            oExcel.Cells(linea, 5) = "Location"
                            oExcel.Cells(linea, 5).ColumnWidth = 11
                            oExcel.Cells(linea, 6) = "Acquisition Date"
                            oExcel.Cells(linea, 6).ColumnWidth = 15
                            oExcel.Cells(linea, 7) = "Acquisition Value"
                            oExcel.Cells(linea, 7).ColumnWidth = 14
                            oExcel.Cells(linea, 8) = "Acumm. Depr"
                            oExcel.Cells(linea, 8).ColumnWidth = 12
                            oExcel.Cells(linea, 9) = "Previous Mth Depr Exp"
                            oExcel.Cells(linea, 9).ColumnWidth = 18
                            oExcel.Cells(linea, 10) = "Current Mth Depr Exp"
                            oExcel.Cells(linea, 10).ColumnWidth = 18
                            oExcel.Cells(linea, 11) = "Month over Month Change"
                            oExcel.Cells(linea, 11).ColumnWidth = 22
                            oExcel.Cells(linea, 12) = "Disposal Date"
                            oExcel.Cells(linea, 12).ColumnWidth = 12
                            oExcel.Cells(linea, 13) = "Full Depr Date"
                            oExcel.Cells(linea, 13).ColumnWidth = 12
                            oExcel.Cells(linea, 14) = "Transaction Reason"
                            oExcel.Cells(linea, 14).ColumnWidth = 16
                            oExcel.Cells(linea, 15) = "Asset Type Descripcion"
                            oExcel.Cells(linea, 15).ColumnWidth = 22
                            oExcel.Cells(linea, 16) = "Asset Description"
                            oExcel.Cells(linea, 16).ColumnWidth = 22
                            oExcel.Cells(linea, 17) = "APA"
                            oExcel.Cells(linea, 18) = "Acquire Value GL"
                            oExcel.Cells(linea, 18).ColumnWidth = 31
                            oExcel.Cells(linea, 19) = "Gl Description"
                            oExcel.Cells(linea, 19).ColumnWidth = 40
                            oExcel.Cells(linea, 20) = "Accumulated Depreciation Gl"
                            oExcel.Cells(linea, 20).ColumnWidth = 31
                            oExcel.Cells(linea, 21) = "Gl Description"
                            oExcel.Cells(linea, 21).ColumnWidth = 40
                            oExcel.Cells(linea, 22) = "Depreciation Expense Gl"
                            oExcel.Cells(linea, 22).ColumnWidth = 31
                            oExcel.Cells(linea, 23) = "Gl Description"
                            oExcel.Cells(linea, 23).ColumnWidth = 40
                            Dim rangoColumnas As Excel.Range = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, 23))
                            rangoColumnas.Font.Size = 10

                            rangoColumnas.Font.Bold = True
                            linea += 1
                            lineaInicial = linea

                            '-- Inicializar control 2
                            Me.barRegistros.Value = 0
                            Me.barRegistros.Maximum = dsData.Tables(0).Rows.Count
                            contadorRegistro = 0

                            Dim lineaInicioSuma As Integer = linea

                            For Each fila As DataRow In dsData.Tables(0).Rows
                                oExcel.Cells(linea, 1).NumberFormat = "@"
                                oExcel.Cells(linea, 1) = fila.Item("Descripcion")
                                oExcel.Cells(linea, 2) = fila.Item("CodigoDeActivo")
                                oExcel.Cells(linea, 3) = cia.Country
                                oExcel.Cells(linea, 4) = cia.LegalEntity
                                oExcel.Cells(linea, 5).NumberFormat = "@"
                                oExcel.Cells(linea, 5) = fila.Item("CodigoUbicacion")
                                oExcel.Cells(linea, 6) = fila.Item("FechaAdquisicion")
                                oExcel.Cells(linea, 7).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea, 7) = fila.Item("ValorOriginalActivo")
                                oExcel.Cells(linea, 8).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea, 8) = fila.Item("ValorDepAcumulada")
                                oExcel.Cells(linea, 9).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea, 9) = fila.Item("ValorDepMesAnterior")
                                oExcel.Cells(linea, 10).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea, 10) = fila.Item("ValorDepMesActual")
                                oExcel.Cells(linea, 11).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                oExcel.Cells(linea, 11) = fila.Item("ValorDepMesVariacion")
                                oExcel.Cells(linea, 12) = fila.Item("DisposalDate")
                                oExcel.Cells(linea, 13) = fila.Item("FullDeprDate")
                                oExcel.Cells(linea, 14) = fila.Item("TransactionDescription")
                                oExcel.Cells(linea, 15) = fila.Item("TipoDeActivo")
                                oExcel.Cells(linea, 16) = fila.Item("DescripcionActivo")
                                oExcel.Cells(linea, 17) = fila.Item("CodigoDivision")
                                oExcel.Cells(linea, 18).NumberFormat = "@"
                                oExcel.Cells(linea, 18) = fila.Item("CuentaActivo")
                                oExcel.Cells(linea, 19).NumberFormat = "@"
                                oExcel.Cells(linea, 19) = fila.Item("CuentaActivoDesc")
                                oExcel.Cells(linea, 20).NumberFormat = "@"
                                oExcel.Cells(linea, 20) = fila.Item("CuentaDepreciacionAcumulada")
                                oExcel.Cells(linea, 21).NumberFormat = "@"
                                oExcel.Cells(linea, 21) = fila.Item("CuentaDepreciacionAcumuladaDesc")
                                oExcel.Cells(linea, 22).NumberFormat = "@"
                                oExcel.Cells(linea, 22) = fila.Item("CuentaDepreciacionGastos")
                                oExcel.Cells(linea, 23).NumberFormat = "@"
                                oExcel.Cells(linea, 23) = fila.Item("CuentaDepreciacionGastosDesc")
                                linea += 1

                                contadorRegistro += 1
                                Me.barRegistros.Value = contadorRegistro
                            Next

                            linea += 1

                            Dim columnaCuadro As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial - 1, 1), oExcel.Cells(linea, 23))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            Dim columnaFill As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial - 1, 1), oExcel.Cells(lineaInicial - 1, 23))
                            columnaFill.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
                            columnaFill.Interior.Pattern = Excel.XlPattern.xlPatternSolid

                            linea += 2

                            oExcel.Cells(linea, 10) = "Total Month over month change in depreciation expense:"
                            oExcel.Cells(linea, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            '-- Si se hace un cambio a las columnas cambiar esta parte:
                            oExcel.Cells(linea, 11).Formula = "=SUM(K" & lineaInicioSuma.ToString & ":K" & (linea - 2).ToString & ")"

                            linea += 2
                        Else
                            MessageBox.Show("There is no data for database: " + cia.BaseDeDatos, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If

                conexion.Close()
            Next

            If Not oExcel Is Nothing Then
                oExcel.Visible = True
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
        If Me.grdEmpresas.Rows.Count > 0 Then
            If Me.radMes.Checked Then
                Me.txtAnio.EsRequerido = True
            Else
                Me.txtAnio.EsRequerido = False
            End If

            If Me.radFecha.Checked Then
                Me.txtFechaInicio.EsRequerido = True
                Me.txtFechaFin.EsRequerido = True
            Else
                Me.txtFechaInicio.EsRequerido = False
                Me.txtFechaFin.EsRequerido = False
            End If

            If MyBase.ValidarCampos(Me) = False Then
                Return
            End If

            If Me.radMes.Checked Then
                MyBase.ErrorCampos.SetError(Me.txtAnio, Nothing)
                Dim validarAnio As Integer = Me.txtAnio.Text
                If validarAnio <= 1900 Then
                    MyBase.ErrorCampos.SetError(txtAnio, Citi.Synergia.Traductor.Idiomas.GetMensaje(245, "Año inválido"))
                    Return
                End If

                MyBase.ErrorCampos.SetError(Me.cboMeses, Nothing)
                If cboMeses.SelectedValue.ToString = "" Then
                    MyBase.ErrorCampos.SetError(cboMeses, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                    Return
                End If
            End If

            Dim cias As New List(Of Citi.Synergia.Entidades.Companias)

            For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                If filaGrid.Cells(0).Value = True Then
                    For Each cia As Citi.Synergia.Entidades.Companias In _empresasConAcceso
                        If cia.BaseDeDatos = filaGrid.Cells(1).Value AndAlso cia.Servidor = filaGrid.Cells(1).Tag.ToString Then
                            Dim nuevaCia As New Citi.Synergia.Entidades.Companias
                            With nuevaCia
                                .BaseDeDatos = cia.BaseDeDatos
                                .Descripcion = cia.Descripcion
                                .Country = cia.Country
                                .Indice = cia.Indice
                                .LegalEntity = cia.LegalEntity
                                .Servidor = cia.Servidor
                                .BatchCode = cia.BatchCode
                                .TransactionCodeDebit = cia.TransactionCodeDebit
                                .TransactionCodeCredit = cia.TransactionCodeCredit
                            End With
                            cias.Add(cia)
                        End If
                    Next
                End If
            Next

            Dim fechaInicio As String = String.Empty
            Dim fechaFin As String = String.Empty

            If Me.radMes.Checked Then
                Dim dia As String = String.Empty
                Dim mes As String = String.Empty
                Dim anio As String = String.Empty

                dia = "01"
                mes = Me.cboMeses.SelectedValue.ToString
                If mes.Length = 1 Then
                    mes = "0" & mes
                End If
                anio = Me.txtAnio.GetValor
                fechaInicio = dia & "/" & mes & "/" & anio

                Dim ultimoDia As Date = New DateTime(anio, mes, Date.DaysInMonth(anio, mes))
                dia = ultimoDia.Day
                mes = ultimoDia.Month
                anio = ultimoDia.Year
                If dia.Length = 1 Then
                    dia = "0" & dia
                End If
                If mes.Length = 1 Then
                    mes = "0" & mes
                End If
                fechaFin = dia & "/" & mes & "/" & anio
            Else
                fechaInicio = txtFechaInicio.TextDDMMYYYY()
                fechaFin = txtFechaFin.TextDDMMYYYY()
            End If

            Me.AddDispFullDepr(cias, fechaInicio, fechaFin)

            Me.Close()
        End If
    End Sub

    Private Sub Mes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radMes.CheckedChanged
        Me.radMes.TabStop = True
        If Me.radMes.Checked Then
            Me.grpMes.Enabled = True
        Else
            Me.grpMes.Enabled = False
        End If
    End Sub

    Private Sub Fecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radFecha.CheckedChanged
        Me.radFecha.TabStop = True
        If Me.radFecha.Checked Then
            Me.grpFecha.Enabled = True
        Else
            Me.grpFecha.Enabled = False
        End If
    End Sub
End Class