Imports Microsoft.Office.Interop

Public Class ExportAllFields
    Private _empresasConAcceso As New List(Of Citi.Synergia.Entidades.Companias)
    Private _empresasSinAcceso As New List(Of Citi.Synergia.Entidades.Companias)

    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

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

        Me.panBarras.Visible = True
        Me.barBases.Visible = False
        Me.barRegistros.Visible = False
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
            Me.Height = 313
        End If
    End Sub

    Private Sub ExportAllFields(ByVal empresas As List(Of Citi.Synergia.Entidades.Companias))
        Try
            '-- Excel
            Dim oExcel As Excel.Application = Nothing
            Dim primeraVez As Boolean = True
            Dim usuario As String = String.Empty

            Dim linea As Integer = 1
            Dim contadorBD As Integer = 0

            '-- Inicializar control 1
            Me.barBases.Value = 0
            Me.barBases.Maximum = empresas.Count

            If empresas.Count > 0 Then
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
                    With sentenciaSQL
                        .Append("Select m.SIGNO_DE_MONEDA As SignoDeMoneda")
                        .Append(", a.CODIGO_UBICACION As CodigoUbicacion")
                        .Append(", u.DESCRIPCION_UBICACION As DescripcionUbicacion")
                        .Append(", a.CODIGO_DIVISION As CodigoDivison")
                        .Append(", d.DESCRIPCION_DIVISION As DescripcionDivision")
                        .Append(", a.CODIGO_TIPO_ACTIVO As CodigoTipoActivo")
                        .Append(", T.DESCRIP_TIPO_ACTIVO As DescripcionTipoActivo")
                        .Append(", a.TIPO_DEPRECIACION As TipoDepreciacion")
                        .Append(", a.TIEMPO_DEPRECIACION As TiempoDepreciacion")
                        .Append(", a.CODIGO_DE_ACTIVO As CodigoDeActivo")
                        .Append(", a.DESCRIP_CORTA_ACTIVO As DescripcionCortaActivo")
                        .Append(", mc.DESCRIPCION_MARCA As Marca")
                        .Append(", gen.MODELO_DEL_ACTIVO As Modelo")
                        .Append(", gen.NUMERO_SERIE_ACTIVO As Serie")
                        .Append(", r.NOMBRE_USUAL + ' - ' + r.NOMBRE_RESPONSABLE + ' ' + r.APELLIDO_PATERNO As Responsable")
                        .Append(", gen.CHASIS_ACTIVO As Chasis")
                        .Append(", a.VALOR_ORIGINAL_ACTIV As ValorOriginal")
                        .Append(", a.VALOR_ACTUAL_ACTIVO As ValorActualActivo")
                        .Append(", a.VALOR_DEP_ACUM_ACT As ValorDepreciadoAcumuladoActual")
                        .Append(", a.MONTO_ULTIMA_DEPREC As MontoUltimaDepreciacion")
                        .Append(", a.VALOR_NO_DEDUCIBLE As ValorNoDeducible")
                        .Append(", a.VALOR_RESCATE_ACTIVO As ValorRescateActivo")
                        .Append(", a.FECHA_ADQUISICION As FechaAdquisicion")
                        .Append(", a.FECHA_BAJA_ACTIVO As FechaBajaActivo")
                        .Append(", a.FECHA_INICIO_DEPREC As FechaInicioDepreciacion")
                        .Append(", a.FECHA_OPERACION As FechaOperacion")
                        .Append(", a.FECHA_ULTIMA_DEPREC As FechaUltimaDepreciacion")
                        .Append(", a.FECHA_ULTIMA_REVAL As FechaUltimaRevaluacion")
                        .Append(", a.FECHA_ULT_INVENTARIO As FechaUltimoInventario")
                        .Append(", a.FECHA_ULT_MANTMTO As FechaUltimoMantenimiento")
                        .Append(", a.FRECUENCIA_MNTMTO As FrecuenciaMantenimiento")
                        .Append(", a.COSTO_ACUM_MNTMTO As CostoAcumuladoMantenimiento ")
                        .Append(", a.FEC_ACTUALIZACION As FechaActualizacion")
                        .Append(", a.PORCENTAJE_ANUAL_DEP As PorcentajeAnualDepreciacion")
                        .Append(", a.CATEGORIA_ID As CategoriaID")
                        .Append(", cat.CATEGORIA_DESC As DescripcionCategoria")
                        .Append(", a.DEPRECIABLE As Depreciable")
                        .Append(", t.CTA_ACTIVO As CuentaActivo")
                        .Append(", c1.DESCRIPCION As CuentaActivoDescripcion")
                        .Append(", t.CTA_DEPREC_ACUM As CuentaDepreciacionAcumulada")
                        .Append(", c2.DESCRIPCION As CuentaDepreciacionAcumuladaDescripcion")
                        .Append(", t.CTA_GASTO_DEPREC As CuentaDepreciacionGastos")
                        .Append(", c3.DESCRIPCION As CuentaDepreciacionGastosDescripcion")
                        .Append(", a.MEJORA_CORRELATIVO As MejoraCorrelativo")
                        .Append("  From            ACTIVOS_FIJOS     As a")
                        .Append("  Inner Join      MONEDAS           As m   On (m.CODIGO_DE_MONEDA = a.CODIGO_DE_MONEDA)")
                        .Append("  Left Outer Join UBICACION_ACTIVO  As u   On (u.CODIGO_UBICACION = a.CODIGO_UBICACION)")
                        .Append("  Left Outer Join DIVISIONES        As d   On (a.CODIGO_DIVISION = d.CODIGO_DIVISION)")
                        .Append("  Inner Join      TIPOS_DE_ACTIVOS  As t   On (t.CODIGO_TIPO_ACTIVO = a.CODIGO_TIPO_ACTIVO)")
                        .Append("  Left Outer Join MARCAS            As mc  On (mc.CODIGO_MARCA = a.CODIGO_MARCA)")
                        .Append("  Left Outer Join ACTIVOS_FIJOS_GEN As gen On (gen.CODIGO_DE_ACTIVO = a.CODIGO_DE_ACTIVO and GEN.MEJORA_CORRELATIVO = a.MEJORA_CORRELATIVO)")
                        .Append("  Left Outer Join ACT_RESPONSABLES  As r   On (r.RESPONSABLE_ID = a.RESPONSABLE_ID)")
                        .Append("  Left Outer JOin ACT_CATEGORIAS    As cat On (cat.CATEGORIA_ID = a.CATEGORIA_ID)")
                        .Append("  Inner Join      CATALOGO_CONT_DET As c1  On (c1.TIPO_CATALOGO = t.TIPO_CATALOGO And c1.CUENTA_CONTABLE = t.CTA_ACTIVO)")
                        .Append("  Inner Join      CATALOGO_CONT_DET As c2  On (c2.TIPO_CATALOGO = t.TIPO_CATALOGO And c2.CUENTA_CONTABLE = t.CTA_DEPREC_ACUM)")
                        .Append("  Inner Join      CATALOGO_CONT_DET As c3  On (c3.TIPO_CATALOGO = t.TIPO_CATALOGO And c3.CUENTA_CONTABLE = t.CTA_GASTO_DEPREC)")
                    End With
                    .CommandText = sentenciaSQL.ToString()
                End With
                Dim puente As New SqlClient.SqlDataAdapter
                puente.SelectCommand = comando

                Dim dsData As New DataSet
                puente.Fill(dsData)

                '-- Columnas customizadas, sirve para encabezados de columnas
                Dim dsColumnas As New DataSet
                comando.CommandText = "Select * From ACT_CAMPO"
                puente.Fill(dsColumnas)
                Dim dsListaValores As New DataSet
                comando.CommandText = "Select * From ACT_CAMPOS_LV"
                puente.Fill(dsListaValores)

                Dim totalDebito As Decimal = 0
                Dim totalCredito As Decimal = 0

                Dim lineaInicial As Integer = 0
                Dim lineaFinal As Integer = 0
                Dim totalColumnas As Integer = 0
                Dim iniciaColumnaCustomizada As Integer = 0

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
                            oExcel.Cells(linea, 1) = "FIXED ASSETS"
                            linea += 2

                            '-- Titulos

                            oExcel.Cells(linea, 1) = "TODAY'S DATE"
                            oExcel.Cells(linea, 1).ColumnWidth = 14
                            oExcel.Cells(linea, 2) = "LEGAL ENTITY"
                            oExcel.Cells(linea, 2).ColumnWidth = 11
                            oExcel.Cells(linea, 3) = "COUNTRY"
                            oExcel.Cells(linea, 4) = "CURRENCY"
                            oExcel.Cells(linea, 4).ColumnWidth = 9
                            oExcel.Cells(linea, 5) = "LOCATION"
                            oExcel.Cells(linea, 6) = "LOCATION DESCRIPTION"
                            oExcel.Cells(linea, 6).ColumnWidth = 20
                            oExcel.Cells(linea, 7) = "APA"
                            oExcel.Cells(linea, 8) = "APA DESCRIPTION"
                            oExcel.Cells(linea, 9) = "ASSET TYPE ID"
                            oExcel.Cells(linea, 9).ColumnWidth = 11
                            oExcel.Cells(linea, 10) = "ASSET TYPE ID DESCRIPTION"
                            oExcel.Cells(linea, 10).ColumnWidth = 44
                            oExcel.Cells(linea, 11) = "DEPN TYPE"
                            oExcel.Cells(linea, 11).ColumnWidth = 9
                            oExcel.Cells(linea, 12) = "DEPN TIME"
                            oExcel.Cells(linea, 13) = "ASSET ID"
                            oExcel.Cells(linea, 13).ColumnWidth = 16
                            oExcel.Cells(linea, 14) = "ASSET DESCRIPTION"
                            oExcel.Cells(linea, 14).ColumnWidth = 26
                            oExcel.Cells(linea, 15) = "BRAND"
                            oExcel.Cells(linea, 16) = "MODEL"
                            oExcel.Cells(linea, 17) = "SERIAL NO"
                            oExcel.Cells(linea, 18) = "ASSET RESPONSIBLE"
                            oExcel.Cells(linea, 18).ColumnWidth = 16
                            oExcel.Cells(linea, 19) = "CHASSIS"
                            oExcel.Cells(linea, 20) = "ORIGINAL VALUE"
                            oExcel.Cells(linea, 20).ColumnWidth = 14
                            oExcel.Cells(linea, 21) = "CURRENT VALUE"
                            oExcel.Cells(linea, 21).ColumnWidth = 13
                            oExcel.Cells(linea, 22) = "DEPR ACUM VALUE"
                            oExcel.Cells(linea, 22).ColumnWidth = 16
                            oExcel.Cells(linea, 23) = "MTH DEPR"
                            oExcel.Cells(linea, 23).ColumnWidth = 16
                            oExcel.Cells(linea, 24) = "NOT DEDUCTIBLE VALUE"
                            oExcel.Cells(linea, 24).ColumnWidth = 20
                            oExcel.Cells(linea, 25) = "SURRENDER VALUE"
                            oExcel.Cells(linea, 25).ColumnWidth = 16
                            oExcel.Cells(linea, 26) = "ACQUISITION DATE"
                            oExcel.Cells(linea, 26).ColumnWidth = 15
                            oExcel.Cells(linea, 27) = "DISPOSAL DATE"
                            oExcel.Cells(linea, 27).ColumnWidth = 13
                            oExcel.Cells(linea, 28) = "DEPR BEGIN DATE"
                            oExcel.Cells(linea, 28).ColumnWidth = 14
                            oExcel.Cells(linea, 29) = "OPE DATE"
                            oExcel.Cells(linea, 29).ColumnWidth = 11
                            oExcel.Cells(linea, 30) = "LAST DEPR DATE"
                            oExcel.Cells(linea, 30).ColumnWidth = 13
                            oExcel.Cells(linea, 31) = "LAST DEVALUATION DATE"
                            oExcel.Cells(linea, 31).ColumnWidth = 21
                            oExcel.Cells(linea, 32) = "LAST INVENTORY DATE"
                            oExcel.Cells(linea, 32).ColumnWidth = 19
                            oExcel.Cells(linea, 33) = "LAST MAINT DATE"
                            oExcel.Cells(linea, 33).ColumnWidth = 14
                            oExcel.Cells(linea, 34) = "FREQ MANT"
                            oExcel.Cells(linea, 34).ColumnWidth = 10
                            oExcel.Cells(linea, 35) = "CUMULATIVE AMNT MANT"
                            oExcel.Cells(linea, 35).ColumnWidth = 22
                            oExcel.Cells(linea, 36) = "ACTIVE DATE"
                            oExcel.Cells(linea, 36).ColumnWidth = 16
                            oExcel.Cells(linea, 37) = "ANNUAL % DEPR"
                            oExcel.Cells(linea, 37).ColumnWidth = 14
                            oExcel.Cells(linea, 38) = "CATEGORY ID"
                            oExcel.Cells(linea, 39) = "CATEGORY DESC"
                            oExcel.Cells(linea, 39).ColumnWidth = 18
                            oExcel.Cells(linea, 40) = "DEPRECIABLE"
                            oExcel.Cells(linea, 40).ColumnWidth = 11
                            oExcel.Cells(linea, 41) = "Acq Val GL"
                            oExcel.Cells(linea, 41).ColumnWidth = 31
                            oExcel.Cells(linea, 42) = "GL Desc"
                            oExcel.Cells(linea, 42).ColumnWidth = 40
                            oExcel.Cells(linea, 43) = "Accumulated Depreciation GL"
                            oExcel.Cells(linea, 43).ColumnWidth = 31
                            oExcel.Cells(linea, 44) = "GL Desc"
                            oExcel.Cells(linea, 44).ColumnWidth = 40
                            oExcel.Cells(linea, 45) = "Depreciation Expense GL"
                            oExcel.Cells(linea, 45).ColumnWidth = 31
                            oExcel.Cells(linea, 46) = "GL Desc"
                            oExcel.Cells(linea, 46).ColumnWidth = 40
                            totalColumnas = 46
                            iniciaColumnaCustomizada = totalColumnas + 1

                            If Not dsColumnas Is Nothing Then
                                If dsColumnas.Tables.Count > 0 Then
                                    For Each fila As DataRow In dsColumnas.Tables(0).Rows
                                        totalColumnas += 1
                                        oExcel.Cells(linea, totalColumnas) = fila.Item("CAMPO_NOMBRE")
                                        oExcel.Cells(linea, totalColumnas).ColumnWidth = 18
                                    Next
                                End If
                            End If

                            Dim rangoColumnas As Excel.Range = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, totalColumnas))
                            rangoColumnas.Font.Size = 10

                            rangoColumnas.Font.Bold = True
                            linea += 1
                            lineaInicial = linea

                            '-- Inicializar control 2
                            Me.barRegistros.Value = 0
                            Me.barRegistros.Maximum = dsData.Tables(0).Rows.Count
                            contadorRegistro = 0

                            For Each fila As DataRow In dsData.Tables(0).Rows
                                oExcel.Cells(linea, 1) = System.DateTime.Today()
                                oExcel.Cells(linea, 2) = cia.LegalEntity
                                oExcel.Cells(linea, 3) = cia.Country
                                For j As Integer = 0 To dsData.Tables(0).Columns.Count - 2 '-- No se incluye MEJORA_CORRELATIVO
                                    Select Case j
                                        Case 1, 3, 5, 11, 12, 13, 15, 37, 39, 41
                                            oExcel.Cells(linea, j + 4).NumberFormat = "@"
                                        Case 16, 17, 18, 19, 20, 21
                                            oExcel.Cells(linea, j + 4).NumberFormat = "###,###,##0.00;[Red](###,###,##0.00)"
                                    End Select

                                    oExcel.Cells(linea, j + 4) = fila.Item(j)
                                Next

                                '-- Campos customizados
                                Dim dsCustomizados As New DataSet
                                comando.CommandText = "Select * From ACT_CAMPOS_VAL Where CODIGO_DE_ACTIVO = @CodigoDeActivo And MEJORA_CORRELATIVO = @MejoraCorrelativo"
                                comando.Parameters.Clear()
                                comando.Parameters.Add("@CodigoDeActivo", SqlDbType.Char, 15).Value = fila.Item("CodigoDeActivo")
                                comando.Parameters.Add("@MejoraCorrelativo", SqlDbType.Int).Value = fila.Item("MejoraCorrelativo")
                                puente.Fill(dsCustomizados)
                                If Not dsCustomizados Is Nothing Then
                                    If dsCustomizados.Tables.Count > 0 Then
                                        For Each filaCustomizada As DataRow In dsCustomizados.Tables(0).Rows
                                            Dim posicionColumna As Integer = iniciaColumnaCustomizada
                                            For Each campoBusqueda As DataRow In dsColumnas.Tables(0).Rows
                                                If campoBusqueda.Item("CAMPO_ID") = filaCustomizada.Item("CAMPO_ID") Then
                                                    If campoBusqueda.Item("CAMPO_LISTA_VALORES") = "S" Then
                                                        If Not dsListaValores Is Nothing Then
                                                            If dsListaValores.Tables.Count > 0 Then
                                                                For Each listaValores As DataRow In dsListaValores.Tables(0).Rows
                                                                    If listaValores.Item("CAMPO_ID") = campoBusqueda.Item("CAMPO_ID") AndAlso listaValores.Item("CAMPO_VALOR") = filaCustomizada.Item("VALOR_CAMPO") Then
                                                                        oExcel.Cells(linea, posicionColumna).NumberFormat = "@"
                                                                        oExcel.Cells(linea, posicionColumna) = listaValores.Item("CAMPO_DESCRIPCION")
                                                                    End If
                                                                Next
                                                            End If
                                                        End If
                                                    Else
                                                        oExcel.Cells(linea, posicionColumna).NumberFormat = "@"
                                                        oExcel.Cells(linea, posicionColumna) = filaCustomizada.Item("VALOR_CAMPO")
                                                    End If

                                                End If
                                                posicionColumna += 1
                                            Next
                                        Next
                                    End If
                                End If
                                linea += 1

                                contadorRegistro += 1
                                Me.barRegistros.Value = contadorRegistro
                            Next

                            Dim columnaCuadro As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial - 1, 1), oExcel.Cells(linea, totalColumnas))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            Dim columnaFill As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial - 1, 1), oExcel.Cells(lineaInicial - 1, totalColumnas))
                            columnaFill.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
                            columnaFill.Interior.Pattern = Excel.XlPattern.xlPatternSolid

                            linea += 2

                        End If
                    End If
                End If

                conexion.Close()
                contadorBD += 1
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
            If MyBase.ValidarCampos(Me) = False Then
                Return
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

            Me.ExportAllFields(cias)

            Me.Close()
        End If
    End Sub
End Class