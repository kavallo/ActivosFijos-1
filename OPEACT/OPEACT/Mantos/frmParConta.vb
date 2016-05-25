Imports Citi.Synergia.HelperClient
Imports Citi.Synergia.Iconos
Imports Microsoft.Office.Interop

Public Class frmParConta
    Private _documentoOrigen As String = String.Empty
    Private _origen6 As String = String.Empty
    Private _origen5 As String = String.Empty
    Private _origen4 As String = String.Empty
    Private _origen3 As String = String.Empty
    Private _origen2 As String = String.Empty
    Private _origen1 As String = String.Empty
    Private _fechaDMY As String = String.Empty
    Private _fechaMDY As String = String.Empty
    Private _empresasConAcceso As New List(Of Citi.Synergia.Entidades.Companias)
    Private _empresasSinAcceso As New List(Of Citi.Synergia.Entidades.Companias)

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oIcono As New Iconos

            Me.cmdSelect.Image = oIcono.GetImagen(Iconos.Imagenes.BuscarCarpeta, 16, 16)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.dlgFolder.RootFolder = Environment.SpecialFolder.MyComputer

        _documentoOrigen = Pop()
        _origen6 = Pop()
        _origen5 = Pop()
        _origen4 = Pop()
        _origen3 = Pop()
        _origen2 = Pop()
        _origen1 = Pop()

        Me._fechaDMY = DescripcionesDB.TraeFechaHoy("103")
        Me._fechaMDY = DescripcionesDB.TraeFechaHoy("101")

        '-- El grid sólo tiene 6 columnas
        Me.grdEmpresas.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(307, "Seleccionar")
        Me.grdEmpresas.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(342, "Base de Datos")
        Me.grdEmpresas.Columns(2).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(306, "Empresas")
        Me.grdEmpresas.Columns(3).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(330, "Nombre del archivo")
        Me.grdEmpresas.Columns(4).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(336, "Código Producto")
        Me.grdEmpresas.Columns(5).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(329, "Usuario Cosmos")

        '-- El grid de empresas sin acceso sólo tiene 2 columnas
        Me.grdSinAcceso.Columns(0).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(342, "Base de Datos")
        Me.grdSinAcceso.Columns(1).HeaderText = Citi.Synergia.Traductor.Idiomas.GetMensaje(306, "Empresas")

        '-- Valido si el usuario tiene acceso a todas las empresas
        Me.ValidaAcceso()

        '-- Lleno el grid
        Me.LlenoGrid()
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

                Dim nombreArchivo As String = String.Empty

                nombreArchivo = empresa.BaseDeDatos.Substring(empresa.BaseDeDatos.Trim.Length - 3, 3).ToUpper & Mid(Me._fechaDMY, 9, 2) & Mid(Me._fechaDMY, 4, 2) & Mid(Me._fechaDMY, 1, 2) & ".txt"
                filaGrid.Cells(0).Value = True
                filaGrid.Cells(1).Value = empresa.BaseDeDatos
                filaGrid.Cells(1).Tag = empresa.Servidor
                filaGrid.Cells(2).Value = empresa.Descripcion
                filaGrid.Cells(3).Value = nombreArchivo
                filaGrid.Cells(4).Value = String.Empty
                filaGrid.Cells(5).Value = String.Empty

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
            Me.Height = 427
        End If
    End Sub

    Private Function ValidoGrid() As Boolean
        Dim retorno As Boolean = False

        For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
            '-- Veo si la fila está seleccionada
            If filaGrid.Cells(0).Value = True Then
                Dim empresa As String = filaGrid.Cells(1).Value.ToString

                '-- Valido si está toda la información ingresada
                '-- Nombre archivo
                If Not String.IsNullOrEmpty(filaGrid.Cells(3).Value) Then
                    If filaGrid.Cells(3).Value.ToString.Trim <> "" Then
                        retorno = True
                    Else
                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(303, "No se indicó nombre del archivo.") & " - " & empresa & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                        retorno = False
                        Exit For
                    End If
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(303, "No se indicó nombre del archivo.") & " - " & empresa & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    retorno = False
                    Exit For
                End If

                '-- Código producto
                If Not String.IsNullOrEmpty(filaGrid.Cells(4).Value) Then
                    If filaGrid.Cells(4).Value.ToString.Trim <> "" Then
                        retorno = True
                    Else
                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(331, "No se indicó código de producto.") & " - " & empresa & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                        retorno = False
                        Exit For
                    End If
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(331, "No se indicó código de producto.") & " - " & empresa & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    retorno = False
                    Exit For
                End If

                '-- Usuario Cosmos
                If Not String.IsNullOrEmpty(filaGrid.Cells(5).Value) Then
                    If filaGrid.Cells(5).Value.ToString.Trim <> "" Then
                        retorno = True
                    Else
                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(332, "No se indicó el Usuario Cosmos.") & " - " & empresa & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                        retorno = False
                        Exit For
                    End If
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(332, "No se indicó el Usuario Cosmos.") & " - " & empresa & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    retorno = False
                    Exit For
                End If
            End If
        Next

        Return retorno
    End Function

    Private Function ValidoBranchCodeADEComplement(ByVal branchCode As String, ByVal branchCodeLength As Integer, ByVal adeComplement As String, ByVal adeComplementLength As Integer) As Boolean
        Dim retorno As Boolean = False

        '-- Branch Code
        If branchCode.Trim.Length <= 0 Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(360, "No se ha definido el Branch Code en el archivo de configuración xml."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If branchCodeLength <= 0 Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(361, "No se ha definido la longitud del Branch Code en el archivo de configuración xml."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        '-- ADE Complement
        If adeComplement.Trim.Length <= 0 Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(362, "No se ha definido el Complemento ADE en el archivo de configuración xml."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If adeComplementLength <= 0 Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(363, "No se ha definido la longitud del Complemento ADE en el archivo de configuración xml."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        '-- Si llega hasta acá es que todo está bien
        retorno = True

        Return retorno
    End Function

    Private Function PegaBlancos(ByVal texto As String, ByVal espacios As Integer, ByVal alineacion As String) As String
        Dim retorno As String = String.Empty

        If alineacion = "D" Then
            retorno = String.Format("{0," & espacios.ToString & "}", texto)
        Else
            retorno = String.Format("{0,-" & espacios.ToString & "}", texto)
        End If

        Return retorno
    End Function

    Private Sub ManualJournal(ByVal empresas As List(Of Citi.Synergia.Entidades.Companias), ByVal documentoOrigen As String, ByVal origen1 As String, ByVal origen2 As String, ByVal origen3 As String)
        Try
            '-- Excel
            Dim oExcel As Excel.Application = Nothing
            Dim primeraVez As Boolean = True
            Dim usuario As String = String.Empty

            Dim linea As Integer = 1

            For Each cia As Citi.Synergia.Entidades.Companias In empresas
                Dim conexion As New SqlClient.SqlConnection("Data Source=" + cia.Servidor + "; Initial Catalog=" + cia.BaseDeDatos + "; Uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + ";Pwd=" + Citi.Synergia.Locals.Cache.Password)
                conexion.Open()

                Dim comando As New SqlClient.SqlCommand
                Dim sentenciaSQL As New System.Text.StringBuilder

                With comando
                    .Connection = conexion
                    With sentenciaSQL
                        .Append("Select CUENTA_CONTABLE, MONTO, DEBITO_CREDITO, IsNull(CONCEPTO_CONTABLE, '') As CONCEPTO_CONTABLE, CODIGO_CENTRO, SUSER_NAME() As USUARIO")
                        .Append("  From PARTIDAS_TRABAJO_DET As d")
                        .Append(" Inner Join PARTIDAS_TRABAJO_ENC As e On (e.ANO_PERIODO = d.ANO_PERIODO And e.NO_PERIODO = d.NO_PERIODO And e.NUMERO_PARTIDA = e.NUMERO_PARTIDA)")
                        .Append(" Where e.DOCUMENTO_ORIGEN = @DocumentoOrigen")
                        .Append("   And e.ORIGEN1          = @Origen1")
                        .Append("   And e.ORIGEN2          = @Origen2")
                        .Append("   And e.ORIGEN3          = @Origen3")
                        .Append(" Order By CORRELATIVO")
                    End With
                    .CommandText = sentenciaSQL.ToString()
                    .Parameters.Add("@DocumentoOrigen", SqlDbType.VarChar).Value = documentoOrigen
                    .Parameters.Add("@Origen1", SqlDbType.VarChar).Value = origen1
                    .Parameters.Add("@Origen2", SqlDbType.VarChar).Value = origen2
                    .Parameters.Add("@Origen3", SqlDbType.VarChar).Value = origen3
                End With
                Dim puente As New SqlClient.SqlDataAdapter
                puente.SelectCommand = comando

                Dim dsData As New DataSet
                puente.Fill(dsData)

                Dim totalDebito As Decimal = 0
                Dim totalCredito As Decimal = 0

                Dim lineaInicial As Integer = 0
                Dim lineaFinal As Integer = 0

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
                            linea += 1
                            oExcel.Cells(linea, 1) = "DATA ENTRY BATCH"

                            oExcel.Cells(linea, 2) = cia.BatchCode
                            oExcel.Cells(linea, 6) = "No of Entries: " + dsData.Tables(0).Rows.Count.ToString()

                            linea += 2

                            '-- Titulos

                            oExcel.Cells(linea, 1) = "ACCOUNT"
                            oExcel.Cells(linea, 2) = "CCY CODE"
                            oExcel.Cells(linea, 3) = "DEBIT"
                            oExcel.Cells(linea, 4) = "CREDIT"
                            oExcel.Cells(linea, 5) = "TXN CODE"
                            oExcel.Cells(linea, 6) = "TEXT"
                            oExcel.Cells(linea, 7) = "REF"
                            oExcel.Cells(linea, 8) = "APA"
                            Dim rangoColumnas As Excel.Range = oExcel.Range(oExcel.Cells(linea, 1), oExcel.Cells(linea, 8))
                            rangoColumnas.Font.Size = 10

                            rangoColumnas.Font.Bold = True
                            linea += 1
                            lineaInicial = linea

                            For Each fila As DataRow In dsData.Tables(0).Rows
                                usuario = fila.Item("USUARIO")
                                oExcel.Cells(linea, 1).NumberFormat = "@"
                                oExcel.Cells(linea, 1) = fila.Item("CUENTA_CONTABLE")

                                If fila.Item("DEBITO_CREDITO") = "D" Then
                                    oExcel.Cells(linea, 3) = fila.Item("MONTO")
                                    oExcel.Cells(linea, 5) = cia.TransactionCodeDebit
                                    totalDebito += fila.Item("MONTO")
                                Else
                                    oExcel.Cells(linea, 4) = fila.Item("MONTO")
                                    oExcel.Cells(linea, 5) = cia.TransactionCodeCredit
                                    totalCredito += fila.Item("MONTO")
                                End If

                                oExcel.Cells(linea, 7) = fila.Item("CONCEPTO_CONTABLE")
                                oExcel.Cells(linea, 8).NumberFormat = "@"
                                oExcel.Cells(linea, 8) = fila.Item("CODIGO_CENTRO")

                                linea += 1
                            Next
                            Dim columnaCuenta As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial, 1), oExcel.Cells(linea, 1))
                            columnaCuenta.NumberFormat = "@"
                            columnaCuenta.ColumnWidth = 30

                            linea += 1
                            oExcel.Cells(linea, 1) = "Total"
                            oExcel.Cells(linea, 1).Font.bold = True
                            oExcel.Cells(linea, 3) = totalDebito
                            oExcel.Cells(linea, 3).Font.Bold = True
                            oExcel.Cells(linea, 4) = totalCredito
                            oExcel.Cells(linea, 4).Font.Bold = True
                            Dim columnaMontos As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial, 3), oExcel.Cells(linea, 4))
                            columnaMontos.NumberFormat = "###,###,##0.00"
                            columnaMontos.ColumnWidth = 15


                            Dim columnaCuadro As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial - 1, 1), oExcel.Cells(linea, 8))
                            columnaCuadro.BorderAround(Type.Missing, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing)

                            Dim columnaFill As Excel.Range = oExcel.Range(oExcel.Cells(lineaInicial - 1, 1), oExcel.Cells(lineaInicial - 1, 8))
                            columnaFill.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
                            columnaFill.Interior.Pattern = Excel.XlPattern.xlPatternSolid

                            linea += 2

                            oExcel.Cells(linea, 1) = "MAKER:"
                            oExcel.Cells(linea, 2) = usuario
                            oExcel.Cells(linea, 3) = System.DateTime.Today()
                            linea += 1
                            oExcel.Cells(linea, 1) = "AUTHORIZER:"
                            oExcel.Cells(linea, 3) = System.DateTime.Today()
                            linea += 2
                            oExcel.Cells(linea, 1) = "FINANCIAL APPROVAL:"
                            linea += 1
                            oExcel.Cells(linea, 1) = "DATE"
                            linea += 5
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

    Private Sub Empresas_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEmpresas.CellEndEdit
        Select Case e.ColumnIndex
            Case 4
                '-- Veo si hay algun dato ingresado en la columna de código para habilitar el checkbox
                Dim encontro As Boolean = False
                For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                    If Not String.IsNullOrEmpty(filaGrid.Cells(4).Value) Then
                        If filaGrid.Cells(4).Value.ToString.Trim <> "" Then
                            encontro = True
                        End If
                    End If
                Next
                Me.chkMismoCodigo.Enabled = encontro
                If encontro = False Then
                    Me.chkMismoCodigo.Checked = encontro
                End If

            Case 5
                '-- Veo si hay algun dato ingresado en la columna de usuario para habilitar el checkbox
                Dim encontro As Boolean = False
                For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                    If Not String.IsNullOrEmpty(filaGrid.Cells(5).Value) Then
                        If filaGrid.Cells(5).Value.ToString.Trim <> "" Then
                            encontro = True
                        End If
                    End If
                Next
                Me.chkMismoUsuario.Enabled = encontro
                If encontro = False Then
                    Me.chkMismoUsuario.Checked = encontro
                End If

        End Select
    End Sub

    Private Sub MismoCodigo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMismoCodigo.CheckedChanged
        If Me.chkMismoCodigo.Checked Then
            Dim codigo As String = String.Empty
            For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                If Not String.IsNullOrEmpty(filaGrid.Cells(4).Value) Then
                    If filaGrid.Cells(4).Value.ToString.Trim <> "" Then
                        codigo = filaGrid.Cells(4).Value.ToString
                        Exit For
                    End If
                End If
            Next

            If codigo <> "" Then
                For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                    filaGrid.Cells(4).Value = codigo
                Next
            End If
        End If
    End Sub

    Private Sub MismoUsuario_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMismoUsuario.CheckedChanged
        If Me.chkMismoUsuario.Checked Then
            Dim usuario As String = String.Empty
            For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                If Not String.IsNullOrEmpty(filaGrid.Cells(5).Value) Then
                    If filaGrid.Cells(5).Value.ToString.Trim <> "" Then
                        usuario = filaGrid.Cells(5).Value.ToString
                        Exit For
                    End If
                End If
            Next

            If usuario <> "" Then
                For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                    filaGrid.Cells(5).Value = usuario
                Next
            End If
        End If
    End Sub

    Private Sub Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        With Me.dlgFolder
            If .ShowDialog = DialogResult.OK Then
                Me.lblPathSeleccionado.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
        If Me.grdEmpresas.Rows.Count > 0 Then
            '-- Valido que hayan seleccionado en dónde se guardaran los archivos
            MyBase.ErrorCampos.SetError(Me.cmdSelect, Nothing)
            If lblPathSeleccionado.Text = "" Then
                MyBase.ErrorCampos.SetError(cmdSelect, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Return
            End If

            Dim folderDestino As String = lblPathSeleccionado.Text
            If Not folderDestino.EndsWith("\") Then
                folderDestino = folderDestino & "\"
            End If

            Dim exito As Boolean = False
            Dim entro As Boolean = False
            Dim empresasError As New List(Of String)

            If Me.ValidoGrid() Then
                For Each filaGrid As DataGridViewRow In Me.grdEmpresas.Rows
                    '-- Ejecuto sólo las selccionadas
                    If filaGrid.Cells(0).Value = True Then
                        entro = True
                        exito = False

                        Dim servidor As String = String.Empty
                        Dim empresa As String = String.Empty
                        Dim nombreArchivo As String = String.Empty
                        Dim codigoProducto As String = String.Empty
                        Dim usuarioCosmos As String = String.Empty
                        Dim descripcion As String = String.Empty

                        servidor = filaGrid.Cells(1).Tag.ToString
                        empresa = filaGrid.Cells(1).Value.ToString

                        '-- Busco el transaction code credit y transaccion code debit de la empresa
                        Dim codeCredit As String = String.Empty
                        Dim codeDebit As String = String.Empty
                        Dim branchCode As String = String.Empty
                        Dim branchCodeLength As Integer = 0
                        Dim adeComplement As String = String.Empty
                        Dim adeComplementLength As Integer = 0

                        For Each cia As Citi.Synergia.Entidades.Companias In _empresasConAcceso
                            If cia.BaseDeDatos = filaGrid.Cells(1).Value AndAlso cia.Servidor = filaGrid.Cells(1).Tag.ToString Then
                                codeCredit = cia.TransactionCodeCredit.Trim
                                codeDebit = cia.TransactionCodeDebit.Trim
                                branchCode = cia.BranchCode.Trim
                                branchCodeLength = cia.BranchCodeLength
                                adeComplement = cia.ADEComplement.Trim
                                adeComplementLength = cia.ADEComplementLength
                                Exit For
                            End If
                        Next

                        If Me.ValidoBranchCodeADEComplement(branchCode, branchCodeLength, adeComplement, adeComplementLength) = False Then
                            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(364, "Debe de salir de la aplicación para que los cambios estén actualizados."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Continue For
                        End If

                        '-- Veo si no ingresaron más de lo definido
                        If branchCode.Trim.Length > branchCodeLength Then
                            branchCode = branchCode.Substring(0, branchCodeLength)
                        End If
                        '-- Veo si ingresaron menos de lo definido
                        If branchCode.Trim.Length < branchCodeLength Then
                            branchCode = Me.PegaBlancos(branchCode, branchCodeLength, "D")
                        End If

                        '-- Veo si no ingresaron más de lo definido
                        If adeComplement.Trim.Length > adeComplementLength Then
                            adeComplement = adeComplement.Substring(0, adeComplementLength)
                        End If
                        '-- Veo si ingresaron menos de lo definido
                        If adeComplement.Trim.Length < adeComplementLength Then
                            adeComplement = Me.PegaBlancos(adeComplement, adeComplementLength, "I")
                        End If

                        '-- Valido espacios (6)
                        If codeCredit.Trim.Length > 6 Then
                            codeCredit = codeCredit.Substring(0, 6)
                        Else
                            codeCredit = Me.PegaBlancos(codeCredit, 6, "D")
                        End If
                        If codeDebit.Trim.Length > 6 Then
                            codeDebit = codeDebit.Substring(0, 6)
                        Else
                            codeDebit = Me.PegaBlancos(codeDebit, 6, "D")
                        End If

                        descripcion = filaGrid.Cells(2).Value.ToString

                        nombreArchivo = filaGrid.Cells(3).Value.ToString
                        If Not nombreArchivo.ToUpper.EndsWith(".TXT") Then
                            nombreArchivo = nombreArchivo & ".txt"
                        End If

                        codigoProducto = filaGrid.Cells(4).Value.ToString
                        usuarioCosmos = filaGrid.Cells(5).Value.ToString

                        Dim conexion As New SqlClient.SqlConnection

                        Try
                            Dim anioPeriodo As String = String.Empty
                            Dim numeroPeriodo As String = String.Empty
                            Dim numeroPartida As String = String.Empty

                            conexion.ConnectionString = "Data Source=" + servidor + "; Initial Catalog=" + empresa + "; uid=" + Citi.Synergia.Locals.Cache.UsuarioSQL + "; pwd=" + Citi.Synergia.Locals.Cache.Password

                            Dim comandoSQL As New System.Text.StringBuilder

                            With comandoSQL
                                .Append("Select ANO_PERIODO")
                                .Append("     , NO_PERIODO")
                                .Append("     , NUMERO_PARTIDA")
                                .Append("  From PARTIDAS_TRABAJO_ENC")
                                .Append(" WHERE DOCUMENTO_ORIGEN = " & Scm(_documentoOrigen))
                                .Append("   AND ORIGEN1          = " & Scm(_origen1))
                                .Append("   AND ORIGEN2          = " & Scm(_origen2))
                                .Append("   AND ORIGEN3          = " & Scm(_origen3))
                            End With

                            Dim comando As New SqlClient.SqlCommand
                            With comando
                                .Connection = conexion
                                .CommandType = CommandType.Text
                                .CommandText = comandoSQL.ToString
                            End With

                            Dim dsData As New DataSet

                            Dim adPuente As New SqlClient.SqlDataAdapter

                            adPuente.SelectCommand = comando

                            conexion.Open()

                            adPuente.Fill(dsData)

                            If Not dsData Is Nothing Then
                                If dsData.Tables.Count > 0 Then
                                    For Each filaData As DataRow In dsData.Tables(0).Rows
                                        anioPeriodo = filaData.Item("ANO_PERIODO").ToString
                                        numeroPeriodo = filaData.Item("NO_PERIODO").ToString
                                        numeroPartida = filaData.Item("NUMERO_PARTIDA").ToString
                                    Next
                                End If
                            End If

                            Dim idMonedaBCosmos As String = String.Empty
                            comandoSQL.Clear()
                            With comandoSQL
                                .Append("Select IsNull(m.ID_MONEDA_BCOSMOS, '')")
                                .Append("  From PARAMETRO_GENERALES p")
                                .Append("  Join MONEDAS m On (m.CODIGO_DE_MONEDA = p.CODIGO_DE_MONEDA)")
                                .Append(" Where p.COMPANIA = 'PA'")
                            End With
                            With comando
                                .CommandText = comandoSQL.ToString
                                idMonedaBCosmos = CType(.ExecuteScalar(), String)
                            End With
                            If idMonedaBCosmos.Trim.Length <= 0 Then
                                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(365, "No se ha definido el campo Moneda Cosmos de la moneda default.") & " - " & descripcion & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                                conexion.Close()
                                empresasError.Add(descripcion)
                                Continue For
                            End If

                            Dim numeroRegistros As Integer = 0
                            comandoSQL.Clear()
                            With comandoSQL
                                .Append("Select IsNull(COUNT(1), 0)")
                                .Append("  From PARTIDAS_TRABAJO_DET")
                                .Append(" Where ANO_PERIODO = " & sen(anioPeriodo))
                                .Append("   AND NO_PERIODO = " & sen(numeroPeriodo))
                                .Append("   AND NUMERO_PARTIDA = " & sen(numeroPartida))
                            End With

                            With comando
                                .CommandText = comandoSQL.ToString
                                numeroRegistros = CType(.ExecuteScalar(), Integer)
                            End With

                            If numeroRegistros < 1 Then
                                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(333, "No existe información relacionada a la ultima partida de trabajo, POR FAVOR REVISE AUTORIZO EL PROCESO DE DEPRECIACION.") & " - " & descripcion & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                                conexion.Close()
                                empresasError.Add(descripcion)
                                Continue For
                            End If

                            Dim destinoFinal As String = folderDestino & nombreArchivo

                            If Citi.Synergia.HelperClient.Utils.ArchivoExiste(destinoFinal) Then
                                Dim msgArchivo As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(343, "El archivo: ") & nombreArchivo & " (" & descripcion & ")"
                                msgArchivo = msgArchivo & Citi.Synergia.Traductor.Idiomas.GetMensaje(344, " ya existe. ") & Chr(13) & Chr(13)
                                msgArchivo = msgArchivo & Citi.Synergia.Traductor.Idiomas.GetMensaje(345, "¿Desea continuar?")

                                If Citi.Synergia.HelperClient.Utils.CITIMsgBox(msgArchivo, Utils.TipoDeMensaje.TipoConfirmacion) = Utils.TipoDeRespuesta.Aceptar Then
                                    FileIO.FileSystem.DeleteFile(destinoFinal)
                                Else
                                    conexion.Close()
                                    empresasError.Add(descripcion)
                                    Continue For
                                End If
                            End If

                            Dim fechaActual As String = Mid(Me._fechaDMY, 9, 2) & Mid(Me._fechaDMY, 4, 2) & Mid(Me._fechaDMY, 1, 2)
                            Dim totalDebitos As Double = 0
                            Dim totalCreditos As Double = 0

                            '-- Lugar donde guardaré lo que grabaré al archivo
                            Dim lineas As New List(Of String)

                            If codigoProducto.Trim.Length < 3 Then
                                codigoProducto = Me.PegaBlancos(codigoProducto, 3, "I")
                            End If
                            If usuarioCosmos.Trim.Length < 12 Then
                                usuarioCosmos = Me.PegaBlancos(usuarioCosmos, 12, "I")
                            End If

                            With lineas
                                .Add(codigoProducto & fechaActual & Me.PegaBlancos(numeroRegistros.ToString, 4, "D") & Me.PegaBlancos(String.Format("{0:0.00}", totalDebitos), 15, "D") & Me.PegaBlancos(String.Format("{0:0.00}", totalCreditos), 15, "D") & usuarioCosmos & branchCode & adeComplement)
                            End With

                            comandoSQL.Clear()
                            With comandoSQL
                                .Append("Select ltrim(REPLACE(CUENTA_CONTABLE,'-','') ) ")
                                .Append("     , ltrim(str(MONTO,14,2)) ")
                                .Append("     , DEBITO_CREDITO ")
                                .Append("     , ltrim(REPLACE(CODIGO_CENTRO,'-','') ) ")
                                .Append("  FROM PARTIDAS_TRABAJO_DET ")
                                .Append("  WHERE ANO_PERIODO    = " & sen(anioPeriodo))
                                .Append("     AND NO_PERIODO     = " & sen(numeroPeriodo))
                                .Append("     AND NUMERO_PARTIDA = " & sen(numeroPartida))
                                .Append("         ORDER BY CORRELATIVO")
                            End With

                            With comando
                                .CommandText = comandoSQL.ToString
                            End With

                            dsData = New DataSet
                            adPuente = New SqlClient.SqlDataAdapter

                            adPuente.SelectCommand = comando

                            adPuente.Fill(dsData)

                            conexion.Close()

                            Dim contador As Integer = 0

                            If Not dsData Is Nothing Then
                                If dsData.Tables.Count > 0 Then
                                    Dim registro As String = String.Empty

                                    For Each filaData As DataRow In dsData.Tables(0).Rows
                                        contador += 1
                                        registro = String.Empty

                                        registro = Me.PegaBlancos(filaData.Item(0).ToString, 10, "I")
                                        registro = registro & Me.PegaBlancos(idMonedaBCosmos, 3, "D") '"000" 'MONEDA
                                        registro = registro & Me.PegaBlancos(filaData.Item(1).ToString, 15, "I")  'MONTO
                                        registro = registro & Space(15)
                                        registro = registro & IIf(filaData.Item(2).ToString = "C", "1", "0")
                                        registro = registro & fechaActual
                                        registro = registro & Space(9)
                                        registro = registro & IIf(filaData.Item(2).ToString = "C", codeCredit, codeDebit)
                                        registro = registro & Space(10)
                                        registro = registro & IIf(Mid(filaData.Item(0).ToString, 1, 2) = "93", Me.PegaBlancos(filaData.Item(3), 6, "D"), "      ")
                                        registro = registro & Space(12)
                                        Dim codigoUbicacion As String = String.Empty
                                        registro = registro & Me.PegaBlancos(codigoUbicacion, 10, "D")
                                        registro = registro & Space(25)  'ADITIONAL TEXT
                                        registro = registro & Space(3)   'SPC
                                        registro = registro & Space(10)  'COLLECTION MODE
                                        registro = registro & Space(35)  'COLLECTION NAME
                                        registro = registro & Space(120) 'EXTENDED ADITIONAL TEXT

                                        If numeroRegistros = contador Then
                                            'registro = registro & Space(118 - Len(registro)) & "X"
                                            registro = registro & "X"
                                        End If

                                        If filaData.Item(2).ToString = "C" Then
                                            totalDebitos = totalDebitos + CType(filaData.Item(1), Decimal)
                                        Else
                                            totalCreditos = totalCreditos + CType(filaData.Item(1), Decimal)
                                        End If

                                        lineas.Add(registro)
                                    Next
                                End If
                            End If

                            '---------------------------
                            'Generamos partida adicional
                            '---------------------------
                            '-- --------------------------------------------------------
                            '-- Abrimos nuevamente para poner el numero de transacciones
                            '-- --------------------------------------------------------
                            Dim final As String = codigoProducto & fechaActual & Me.PegaBlancos(numeroRegistros.ToString, 4, "D") & Me.PegaBlancos(String.Format("{0:0.00}", totalDebitos), 15, "D") & Me.PegaBlancos(String.Format("{0:0.00}", totalCreditos), 15, "D") & usuarioCosmos & branchCode & adeComplement
                            lineas.Item(0) = final

                            '-- Creo el archivo
                            Using writer As IO.StreamWriter = New IO.StreamWriter(destinoFinal)
                                For Each linea As String In lineas
                                    writer.WriteLine(linea)
                                Next
                            End Using

                            '-- ----------------
                            '-- Cerramos archivo
                            '-- ----------------

                            'Finalizó proceso.
                            exito = True

                        Catch errSQL As SqlClient.SqlException
                            Dim entroError As Boolean = False
                            For Each errorMalo As System.Data.SqlClient.SqlError In errSQL.Errors
                                If errorMalo.Number = 40000 Then
                                    entroError = True
                                    MessageBox.Show(errorMalo.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Next

                            If Not entroError Then
                                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                            empresasError.Add(descripcion)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            empresasError.Add(descripcion)
                        Finally
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                        End Try
                    End If
                Next
            End If

            If entro Then
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(334, "Finalizó proceso."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Information)

                If empresasError.Count > 0 Then
                    Dim msgEmpresas As String = String.Empty
                    For Each empresaError As String In empresasError
                        msgEmpresas += " " & empresaError
                    Next

                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(335, "Se detectaron problemas en las siguientes empresas:") & msgEmpresas & ".", Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Me.Close()
            Else
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(314, "No se seleccionaron empresas."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmdExcel_Click(sender As System.Object, e As System.EventArgs) Handles cmdExcel.Click
        If Me.grdEmpresas.Rows.Count > 0 Then
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

            Me.ManualJournal(cias, _documentoOrigen, _origen1, _origen2, _origen3)
        End If
    End Sub
End Class