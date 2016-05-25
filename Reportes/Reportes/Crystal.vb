Imports CrystalDecisions
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports System.Windows.Forms

Public Class Campos
    Public Property Campo As String
    Public Property Texto As String

    Public Sub New()
        Campo = String.Empty
        Texto = String.Empty
    End Sub

    Public Sub New(ByVal campo As String, ByVal texto As String)
        Me.Campo = campo
        Me.Texto = texto
    End Sub
End Class

Public Class Crystal
    Public Shared Folder As String
    Public Shared Parametros As New List(Of Citi.Synergia.Reportes.Campos)

    Private Shared Function SetReporte(ByRef reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal pathArchivo As String, ByVal filtro As String) As Boolean
        Dim retorno As Boolean = False

        Dim myConnectionInfo As New CrystalDecisions.Shared.ConnectionInfo

        With myConnectionInfo
            .DatabaseName = Citi.Synergia.Locals.Cache.BaseDeDatos
            .UserID = Citi.Synergia.Locals.Cache.UsuarioSQL
            .Password = Citi.Synergia.Locals.Cache.Password
            .ServerName = Citi.Synergia.Locals.Cache.Servidor
        End With

        reporte.Load(pathArchivo)

        For Each conexion As CrystalReports.Engine.InternalConnectionInfo In reporte.DataSourceConnections
            With conexion
                .SetConnection(Citi.Synergia.Locals.Cache.Servidor, Citi.Synergia.Locals.Cache.BaseDeDatos, Citi.Synergia.Locals.Cache.UsuarioSQL, Citi.Synergia.Locals.Cache.Password)
            End With
        Next

        Dim myTables As CrystalDecisions.CrystalReports.Engine.Tables = reporte.Database.Tables

        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim newLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            newLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(newLogonInfo)
        Next

        For Each campo As Campos In Parametros
            For Each formula As CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition In reporte.DataDefinition.FormulaFields
                If formula.Name.ToString().Trim = campo.Campo.Trim Then
                    formula.Text = campo.Texto
                End If
            Next
        Next

        retorno = True

        Return retorno
    End Function


    Public Shared Function ValidaReporte(ByVal nombreReporte As String, Optional ByVal asignaFolder As Boolean = False) As Boolean
        Dim retorno As Boolean = True
        Dim asignaValor As Boolean = False

        Dim pathDirectorio, pathReporte As String

        pathDirectorio = My.Application.Info.DirectoryPath

        If Not pathDirectorio.EndsWith("\") Then
            pathDirectorio = pathDirectorio & "\"
        End If

        pathDirectorio = pathDirectorio & "REPORTES\"

        If asignaFolder Then
            Folder = pathDirectorio
        End If

        'Path con el nombre del reporte incluído
        If Not nombreReporte.ToUpper.EndsWith(".RPT") Then
            pathReporte = pathDirectorio & nombreReporte & ".RPT"
        Else
            pathReporte = pathDirectorio & nombreReporte
        End If

        'VERIFICAR QUE EXISTA DIRECTORIO SQR
        '-------------------------------------
        If Not FileIO.FileSystem.DirectoryExists(pathDirectorio) Then
            asignaValor = True
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(109, "No Existe folder de REPORTES") & " " & pathDirectorio, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'VERIFICAR QUE EXISTA .SQR
        '-------------------------
        If Not FileIO.FileSystem.FileExists(pathReporte) Then
            asignaValor = True
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(110, "No existe reporte") & ": " & nombreReporte & ". " & Citi.Synergia.Traductor.Idiomas.GetMensaje(111, "En folder") & ": " & pathDirectorio, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If asignaValor Then
            retorno = False
        End If

        Return retorno
    End Function

    Public Shared Sub EjecutarReporte(ByVal nombreReporte As String, Optional ByVal filtro As String = "", Optional ByVal titulo As String = "", Optional ByVal resultadoImpresoraPantalla As String = "P", Optional ByVal strConexion As String = "", Optional ByVal inputVariablesParametrosProc As String = "V")
        '-- Este proceso muestra el reporte en ventana.

        If ValidaReporte(nombreReporte) = False Then
            Return
        End If

        If Not nombreReporte.ToUpper.EndsWith(".RPT") Then
            nombreReporte = nombreReporte & ".RPT"
        End If

        If Not FileIO.FileSystem.FileExists(Folder & nombreReporte) Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(109, "No Existe folder de REPORTES") & " " & Folder, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim pathArchivo As String = Folder & nombreReporte

        '-- Reporte Crystal
        Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If SetReporte(reporte, pathArchivo, filtro) = False Then
            Return
        End If

        '-- TODO Ver en qué momento entra.
        If inputVariablesParametrosProc <> "V" Then
            Dim entra As Boolean = False
        End If

        '-- Muestra el reporte en ventana
        Dim frmReporte As New FReporte
        With frmReporte
            .Text = titulo
            If filtro.Trim <> "" Then
                .View.SelectionFormula = filtro
            End If
            .View.ReportSource = reporte
            .ShowDialog()
        End With
    End Sub

    Public Shared Sub ExportarPDF(ByVal nombreReporte As String, Optional ByVal filtro As String = "", Optional ByVal titulo As String = "", Optional ByVal resultadoImpresoraPantalla As String = "P", Optional ByVal strConexion As String = "", Optional ByVal inputVariablesParametrosProc As String = "V")
        '-- Este proceso exporta el reporte a formato PDF preguntando en dónde se quiere guardar

        If ValidaReporte(nombreReporte) = False Then
            Return
        End If

        If Not nombreReporte.ToUpper.EndsWith(".RPT") Then
            nombreReporte = nombreReporte & ".RPT"
        End If

        If Not FileIO.FileSystem.FileExists(Folder & nombreReporte) Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(109, "No Existe folder de REPORTES") & " " & Folder, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim pathArchivo As String = Folder & nombreReporte

        '-- Reporte Crystal
        Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If SetReporte(reporte, pathArchivo, filtro) = False Then
            Return
        End If

        '-- TODO Ver en qué momento entra.
        If inputVariablesParametrosProc <> "V" Then
            Dim entra As Boolean = False
        End If

        '-- Título servirá para sugerencia de nombre del archivo.
        If titulo = "" Then
            titulo = Citi.Synergia.Traductor.Idiomas.GetMensaje(254, "Reporte") & " " & nombreReporte.Replace(".RPT", "")
        End If

        '-- Pregunta al usuario en donde quiere guardar el archivo
        Dim pathDestino As String
        Dim dlgGuardar As New SaveFileDialog
        With dlgGuardar
            .Title = Citi.Synergia.Traductor.Idiomas.GetMensaje(302, "Documentos PDF.")
            .DefaultExt = "pdf"
            .FileName = titulo
            .Filter = "PDF (pdf)|*.pdf"
            If .ShowDialog() <> DialogResult.OK Then
                Return
            End If
            pathDestino = .FileName
            .Dispose()
        End With

        '-- Empieza proceso de exportar de crystal a pdf
        Dim pdfFormat As New PdfFormatOptions
        pdfFormat.CreateBookmarksFromGroupTree = True

        Dim opciones As New ExportOptions
        With opciones
            .ExportFormatOptions = pdfFormat
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .ExportDestinationType = ExportDestinationType.DiskFile
        End With

        Dim destino As New DiskFileDestinationOptions
        destino.DiskFileName = pathDestino

        opciones.ExportDestinationOptions = destino

        reporte.Refresh()

        reporte.Export(opciones)

        '-- Abro el archivo de una vez
        System.Diagnostics.Process.Start(pathDestino)
    End Sub
End Class
