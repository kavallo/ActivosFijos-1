Public Class Helper
    Public Shared Sub Imprime_Grid(ByVal ThisGrid As System.Windows.Forms.DataGridView, ByVal Lineas As Short, ByVal TamanoLetras As Short, ByVal Titulo1 As String, ByVal Titulo2 As String, ByVal Titulo3 As String, ByVal NombreForma As String, ByVal AnchoPagina As Short)
        'Dim Linea2 As Object
        'Dim Texto As String
        'Dim texto_det As String
        'Dim Columna As String
        'Dim arreglo() As Integer 'Arreglo que contiene el tamano de cada columna
        'Dim Resta As Integer 'Lo que resta para llenar la columna
        'Dim linea_i As Integer  'Numero de linea impresa
        'Dim TotalColumnas As Integer
        'Dim NombreEmpresa As String = String.Empty
        'Dim USUARIO As String = String.Empty
        'Dim Hora As String = String.Empty
        'Dim FECHA As String = String.Empty
        'Dim espacios As Short
        'Dim m As Short
        'Dim ColumnaMaxima As Integer
        'Dim Respuesta As Short

        ''Si el ancho de la pagina es mayor a 80 se despliega un aviso
        'If AnchoPagina > 80 Then
        'Respuesta = CITIMsgBox("El Ancho de Página es mayor de 80, si el reporte no cabe, configure la impresora como LANDSCAPE", "A")
        'End If
        ''ReDim arreglo(ThisGrid.Cols - 1)
        'ReDim arreglo(ThisGrid.Columns.Count)

        ''Selecciono nombre de empresa y variables de entorno
        'NombreEmpresa = Citi.Synergia.HelperClient.DescripcionesDB.TraeEmpresa()
        'USUARIO = Citi.Synergia.HelperClient.DescripcionesDB.TraeUsuario()
        'Hora = Citi.Synergia.HelperClient.DescripcionesDB.TraeFecha("8")
        'FECHA = Citi.Synergia.HelperClient.DescripcionesDB.TraeFecha("103")

        ''Seteo la informacion que llevaran las lineas de encabezado
        'Linea2 = LTrim(NombreForma) & Space(AnchoPagina - 18) & "Página .: "

        ''Determino el numero de columnas fixed
        ''TotalColumnas = ThisGrid.FixedCols - 1
        'TotalColumnas = 0

        ''Determino primero el ancho que tendran las columnas
        'ColumnaMaxima = 0
        ''For i = 0 To ThisGrid.Cols - 1
        'For columnaGrid As Integer = 0 To ThisGrid.Columns.Count - 1
        '    For filaGrid As Integer = 0 To ThisGrid.Rows.Count - 1
        '        If ColumnaMaxima < ThisGrid.Rows(filaGrid).Cells(columnaGrid).Value.ToString.Trim.Length Then
        '            arreglo(columnaGrid) = ThisGrid.Rows(filaGrid).Cells(columnaGrid).Value.ToString.Trim.Length
        '            ColumnaMaxima = ThisGrid.Rows(filaGrid).Cells(columnaGrid).Value.ToString.Trim.Length
        '        End If
        '    Next
        '    ColumnaMaxima = 0
        'Next

        'texto_det = ""
        'Texto = ""
        'linea_i = 1
        'Respuesta = 2

        ''Seteo el tamano del font
        ''Printer.FontSize = TamanoLetras

        ''Impresion del grid
        'For filaGrid As Integer = 0 To ThisGrid.Rows.Count - 1
        '    'Obtengo linea del detalle a imprimir
        '    For columnaGrid As Integer = 0 To ThisGrid.Columns.Count - 1
        '        Columna = RTrim(Mid(ThisGrid.Rows(filaGrid).Cells(columnaGrid).Value.ToString, 1, arreglo(columnaGrid)))
        '        If Columna.Trim.Length < arreglo(columnaGrid) Then
        '            Resta = arreglo(columnaGrid) - Columna.Trim.Length
        '            If TotalColumnas = ThisGrid.Columns.Count Then
        '                Columna = Columna & Space(Resta)
        '            Else 'Alinea a la derecha
        '                Columna = Space(Resta) & Columna
        '            End If
        '        End If
        '        texto_det = texto_det & Columna & Space(3)
        '    Next
        '    'Valido que la linea a imprimir tenga menos de 342 caracteres
        '    'If texto_det.Trim.Length > 341 And Respuesta = 2 Then
        '    Respuesta = CITIMsgBox("El texto a imprimir sobrepasa 341 caracteres, Desea continuar?", "C")
        '    If Respuesta = 2 Then Exit Sub
        '    'End If
        '    If texto_det.Trim.Length > 341 Then texto_det = Mid(texto_det, 1, 341)

        '    'Saltos de pagina e impresion de encabezados
        '    If linea_i = 1 Or linea_i = Lineas Then
        '        If linea_i = Lineas Then
        'Printer.NewPage()
        '        End If
        '        'ThisGrid.Row = 0
        '        Texto = ""

        '        'Impresion del encabezado
        'Printer.Print(NombreEmpresa.Trim)
        'Printer.Print(NombreForma.Trim & Space((AnchoPagina - 20) - NombreForma.Trim.Length) & "Página .: " & Str(Printer.Page))
        'Printer.Print(USUARIO.Trim & Space((AnchoPagina - 20) - USUARIO.Trim.Length) & "Fecha ..: " & FECHA.Trim)
        'Printer.Print(Space(AnchoPagina - 20) & "Hora ...: " & Hora.Trim)

        'Printer.Print()

        '        'Espacios centra el titulo
        '        espacios = (AnchoPagina - Titulo1.Trim.Length) / 2
        'Printer.Print(Space(espacios) & Titulo1.Trim)

        '        If Titulo2.Trim.Length > 0 Then
        '            espacios = (AnchoPagina - Titulo2.Trim.Length) / 2
        'Printer.Print(Space(espacios) & Titulo2.Trim)
        '            If Titulo3.Trim.Length > 0 Then
        '                espacios = (AnchoPagina - Titulo3.Trim.Length) / 2
        'Printer.Print(Space(espacios) & Titulo3.Trim)
        '                linea_i = 9
        '            Else
        '                linea_i = 8
        '            End If
        '        Else
        '            linea_i = 7
        '        End If

        'Printer.Print()
        '        linea_i = linea_i + 4

        '        'Impresion de nombre de columnas de campo
        '        'For k = 1 To ThisGrid.FixedRows
        '        For k As Integer = 1 To 1
        '            ThisGrid.Row = k - 1

        '            For t = 0 To ThisGrid.Cols - 1 'Columnas
        '                ThisGrid.Col = t

        '                Columna = RTrim(Mid(Trim(ThisGrid.Text), 1, arreglo(t)))
        '                If Len(Columna) < arreglo(t) Then
        '                    'Agrega espacios para alinear a la derecha
        '                    Resta = arreglo(t) - Len(Columna)
        '                    Columna = Columna & Space(Resta)
        '                End If
        '                Texto = Texto & Columna & Space(3)
        '            Next t

        '            'Valido que la linea a imprimir tenga menos de 342 caracteres
        '            If Texto.Trim.Length > 341 And Respuesta = 2 Then
        'Respuesta = CITIMsgBox("El texto a imprimir sobrepasa 341 caracteres, Desea continuar?", "C")
        'If Respuesta = 2 Then Exit Sub
        '            End If

        '            Texto = Mid(Texto, 1, 341)

        'Printer.Print(Texto)
        '            Texto = ""
        '        Next k
        '        'linea_i = ThisGrid.FixedRows + 1
        '        linea_i = 1 + 1
        'Printer.Print() 'linea en blanco
        '    End If

        '    'Tiro a impresora el detalle
        '    'Printer.Print(texto_det)
        '    texto_det = ""
        '    linea_i = linea_i + 1
        'Next
        'Printer.EndDoc()
    End Sub
End Class
