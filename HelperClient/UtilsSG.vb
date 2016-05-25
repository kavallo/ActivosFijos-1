Public Class UtilsSG
    Public Shared OSG As New SecuritySG.SGClienteServidor

    Private Shared mostrarBoxes As Boolean = False

    Public Shared Function Login(ByRef usuario As String, ByRef password As String) As Boolean
        OSG.pathConfigXml = Locals.Cache.PathConfigXmlSG
        OSG.appId = Locals.Cache.ApplicationID
        OSG.appName = Locals.Cache.NombreAplicacion

        Dim retorno As Boolean = False

        Try
            Dim mensaje As String = String.Empty
            retorno = OSG.Login(usuario, password, mensaje)

            If mostrarBoxes Then
                System.Windows.Forms.MessageBox.Show("Después de SG.Login user: " & usuario & "    pwd: " & password & " (" & password.Length.ToString, "Test", System.Windows.Forms.MessageBoxButtons.OK)
            End If
            If retorno = True Then
                OSG.obtenerCredencialesExternas(usuario, password, mensaje)
                If mostrarBoxes Then
                    System.Windows.Forms.MessageBox.Show("Después de credencialesSG user: " & usuario & "    pwd: " & password & " (" & password.Length.ToString, "Test", System.Windows.Forms.MessageBoxButtons.OK)
                End If
                If mensaje <> "" Then
                    Throw New Exception(mensaje)
                    retorno = False
                End If
            Else
                If mensaje <> "" Then
                    Throw New Exception(mensaje)
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return retorno
    End Function

    Public Shared Function TieneAcceso(ByVal codigo As String) As Boolean
        OSG.pathConfigXml = Locals.Cache.PathConfigXmlSG
        OSG.appId = Locals.Cache.ApplicationID
        OSG.appName = Locals.Cache.NombreAplicacion

        Dim mensaje As String = String.Empty
        Dim retorno As Boolean = False

        Try
            If OSG.TienePermisoAcceso(codigo, mensaje) Then
                If Not String.IsNullOrEmpty(mensaje) Then
                    Throw New Exception(mensaje)
                Else
                    retorno = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return retorno
    End Function
End Class
