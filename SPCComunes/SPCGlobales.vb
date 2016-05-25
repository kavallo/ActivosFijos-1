
Public Class SPCGlobales

    Public Shared Function TraeEmpresa() As String
        Return "Empresa: " + TraeDato("Select db_name()")
    End Function

    Public Shared Function TraeDato(ByVal transactSQL As String) As String
        Dim retorno As String = String.Empty

        Dim oSQL As New Citi.Synergia.DB.SQL
        oSQL.ConexionSTR = Citi.Synergia.Locals.Cache.ConexionSTR
        retorno = oSQL.GetCadena(transactSQL)

        Return retorno
    End Function
End Class
