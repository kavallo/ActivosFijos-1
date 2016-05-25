Public Class Cache
    Public Shared Property Servidor As String
    Public Shared Property BaseDeDatos As String
    Public Shared Property UsuarioSSO As String
    Public Shared Property UsuarioSQL As String
    Public Shared Property Password As String
    Public Shared Property UtilizarIdiomas As Boolean
    Public Shared Property CrearIdioma As Boolean
    Public Shared Property ConexionSTR As String
    Public Shared Property NombreAplicacion As String
    Public Shared Property IdiomaSeleccionado As String
    Public Shared Property TablasDeIdiomaCreadas As Boolean
    Public Shared Property NumeroRegistrosEnGrid As Integer
    Public Shared Property Empresa As String
    Public Shared Property LegalEntity As String
    Public Shared Property Country As String
    Public Shared Property BatchCode As String
    Public Shared Property TransactionCodeDebit As String
    Public Shared Property TransactionCodeCredit As String
    Public Shared Property ApplicationID As String
    Public Shared Property PathConfigXmlSG As String
    Public Shared Property DiaInicioProcesoDepreciacion As Integer
    Public Shared Property ProveedoresInvisibles As Boolean = True
    Public Shared Property BranchCode As String
    Public Shared Property BranchCodeLength As Integer
    Public Shared Property ADEComplement As String
    Public Shared Property ADEComplementLength As Integer

    '-- SQL
    Public Shared Property ConexionSQL As SqlClient.SqlConnection
End Class
