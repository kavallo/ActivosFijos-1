Public Class Utils
    Public Enum TipoDeMensaje
        TipoAviso
        TipoError
        TipoConfirmacion
    End Enum

    Public Enum TipoDeRespuesta
        Aceptar
        Cancelar
        Continuar
    End Enum

    Public Shared Function AbrirArchivoXml(ByVal archivo As String) As Xml.XmlDocument
        Dim oXml As New Xml.XmlDocument
        If System.IO.File.Exists(archivo) Then
            oXml.Load(archivo)
        End If

        Return oXml

    End Function

    Public Shared Function ArchivoExiste(ByVal archivo As String) As Boolean
        Return System.IO.File.Exists(archivo)
    End Function

    Public Shared Function ListaDeMeses() As List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        Dim meses As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("1", Citi.Synergia.Traductor.Idiomas.GetMensaje(346, "Enero")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("2", Citi.Synergia.Traductor.Idiomas.GetMensaje(347, "Febrero")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("3", Citi.Synergia.Traductor.Idiomas.GetMensaje(348, "Marzo")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("4", Citi.Synergia.Traductor.Idiomas.GetMensaje(349, "Abril")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("5", Citi.Synergia.Traductor.Idiomas.GetMensaje(350, "Mayo")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("6", Citi.Synergia.Traductor.Idiomas.GetMensaje(351, "Junio")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("7", Citi.Synergia.Traductor.Idiomas.GetMensaje(352, "Julio")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("8", Citi.Synergia.Traductor.Idiomas.GetMensaje(353, "Agosto")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("9", Citi.Synergia.Traductor.Idiomas.GetMensaje(354, "Septiembre")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("10", Citi.Synergia.Traductor.Idiomas.GetMensaje(355, "Octubre")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("11", Citi.Synergia.Traductor.Idiomas.GetMensaje(356, "Noviembre")))
        meses.Add(New Citi.Synergia.Entidades.CodigoDescripcion("12", Citi.Synergia.Traductor.Idiomas.GetMensaje(357, "Diciembre")))

        Return meses
    End Function

    Public Shared Function MesEnLetras(ByVal mes As Integer) As String
        Dim retorno As String = ""

        Select Case mes
            Case 1 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(346, "Enero")
            Case 2 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(347, "Febrero")
            Case 3 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(348, "Marzo")
            Case 4 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(349, "Abril")
            Case 5 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(350, "Mayo")
            Case 6 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(351, "Junio")
            Case 7 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(352, "Julio")
            Case 8 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(353, "Agosto")
            Case 9 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(354, "Septiembre")
            Case 10 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(355, "Octubre")
            Case 11 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(356, "Noviembre")
            Case 12 : retorno = Citi.Synergia.Traductor.Idiomas.GetMensaje(357, "Diciembre")
        End Select

        Return retorno
    End Function

    Public Shared Function CITIMsgBox(ByVal mensaje As String, ByVal tipo As Utils.TipoDeMensaje) As Utils.TipoDeRespuesta
        Dim respuesta As Utils.TipoDeRespuesta

        Dim frmMensaje As New CitiMessage
        frmMensaje.lblDETALLES.Text = mensaje
        frmMensaje.TipoMensaje = tipo
        frmMensaje.ShowDialog()
        respuesta = frmMensaje.TipoRespuesta

        Return respuesta
    End Function

    Public Shared Sub DataGridViewEnviarAExcel(ByVal grid As System.Windows.Forms.DataGridView, ByVal pathDestino As String, ByVal titulosGrid As List(Of String))
        If grid.Rows.Count > 0 Then
            If pathDestino.Trim.Length = 0 Then
                Throw New Exception(Citi.Synergia.Traductor.Idiomas.GetMensaje(303, "No se indicó nombre del archivo"))
                Return
            End If

            Dim dsData As New DataSet

            dsData.Tables.Add()

            '-- Agrego los encabezados de las columnas
            For i As Integer = 0 To grid.Columns.Count - 1
                If grid.Columns(i).Visible Then
                    dsData.Tables(0).Columns.Add(grid.Columns(i).HeaderText)
                End If
            Next

            '-- Agrego las columnas
            Dim filaData As DataRow
            Dim columna As Integer

            For i As Integer = 0 To grid.Rows.Count - 1
                filaData = dsData.Tables(0).NewRow
                columna = 0
                For j As Integer = 0 To grid.Columns.Count - 1
                    If grid.Columns(j).Visible Then
                        filaData(columna) = grid.Rows(i).Cells(j).Value
                        columna += 1
                    End If
                Next
                dsData.Tables(0).Rows.Add(filaData)
            Next

            Dim oExcel As Object
            Dim oBook As Object
            Dim oSheet As Object

            oExcel = Nothing
            oBook = Nothing
            oSheet = Nothing

            Try
                oExcel = CreateObject("Excel.Application")

                oBook = oExcel.Workbooks.Add()
                oSheet = oBook.Worksheets(1)
                oSheet = oBook.ActiveSheet()

                Dim dtTabla As DataTable = dsData.Tables(0)
                Dim dcColumna As DataColumn
                Dim drFila As DataRow
                Dim colIndex As Integer = 0
                Dim celda As Integer = 1
                Dim celdaInicio As Integer = 1
                Dim columnaInicio As Integer = 0

                If titulosGrid.Count > 0 Then
                    For Each titulo As String In titulosGrid
                        oExcel.Cells(celdaInicio, 1) = titulo
                        oExcel.Cells(celdaInicio, 1).Font.Bold = True

                        celdaInicio += 1
                    Next

                    celdaInicio += 1
                    columnaInicio = 1
                End If

                colIndex = columnaInicio
                celda = celdaInicio

                For Each dcColumna In dtTabla.Columns
                    colIndex += 1
                    oExcel.Cells(celda, colIndex) = dcColumna.ColumnName
                    oExcel.Cells(celda, colIndex).Font.Bold = True
                Next

                celda += 1

                For Each drFila In dtTabla.Rows
                    'rowIndex += 1
                    'colIndex = 0
                    colIndex = columnaInicio
                    For Each dcColumna In dtTabla.Columns
                        colIndex += 1
                        oExcel.Cells(celda, colIndex) = drFila(dcColumna.ColumnName)
                    Next
                    celda += 1
                Next

                oSheet.Columns.AutoFit()

                'Dim archivoDestino As System.IO.FileStream = System.IO.File.OpenWrite(pathDestino)
                'archivoDestino.Close()

                If System.IO.File.Exists(pathDestino) Then
                    System.IO.File.Delete(pathDestino)
                End If

                oBook.SaveAs(pathDestino)
                oExcel.Workbooks.Open(pathDestino)
                oExcel.Application.Visible = True

            Catch errSQL As SqlClient.SqlException
                Throw errSQL
            Catch ex As Exception
                Throw ex

            Finally
                If Not oBook Is Nothing Then
                    oBook = Nothing
                End If
                If Not oSheet Is Nothing Then
                    oSheet = Nothing
                End If
            End Try
        End If
    End Sub
End Class
