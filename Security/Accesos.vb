Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Accesos
    Public Property ConexionSQL As SqlConnection

    Public Sub New()
        ConexionSQL = New SqlConnection
    End Sub
    Public Sub New(ByVal conexion As SqlConnection)
        ConexionSQL = conexion
    End Sub

    Public Function Login() As Boolean
        Dim companias As New List(Of Citi.Synergia.Entidades.Companias)
        Return Login(companias, False, Nothing)
    End Function

    Public Function Login(ByVal companias As List(Of Citi.Synergia.Entidades.Companias)) As Boolean
        Return Login(companias, False, Nothing)
    End Function

    Public Sub RegistrarIdiomaUsuario(ByVal idioma As String, ByVal usuario As String)
        Dim conexion As SqlConnection = Citi.Synergia.Locals.Cache.ConexionSQL

        Dim comando As New SqlCommand
        'Dim usuario As String = String.Empty
        Dim nombreMaquina As String = String.Empty

        With comando
            .CommandType = CommandType.Text
            '.CommandText = "Select suser_name(), host_name()"
            .CommandText = "Select host_name()"
            .Connection = conexion
        End With

        Dim reader As SqlDataReader = comando.ExecuteReader()
        While reader.Read
            'usuario = reader.GetString(0)
            'nombreMaquina = reader.GetString(1)
            nombreMaquina = reader.GetString(0)
        End While
        reader.Close()

        With comando
            .CommandText = "Delete SYN_IDIOMA_USUARIO Where USUARIO = @Usuario And WORKSTATION = @Workstation"
            .Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario
            .Parameters.Add("@Workstation", SqlDbType.VarChar).Value = nombreMaquina
            .ExecuteNonQuery()

            .CommandText = "Insert SYN_IDIOMA_USUARIO Values (@Usuario, @Workstation, @Idioma)"
            .Parameters.Add("@Idioma", SqlDbType.VarChar).Value = idioma
            .ExecuteNonQuery()
        End With

    End Sub

    Public Function Login(ByVal companias As List(Of Citi.Synergia.Entidades.Companias), ByVal utilizarIdioma As Boolean, ByVal idiomas As List(Of Citi.Synergia.Entidades.Idiomas)) As Boolean
        Dim retorno As Boolean = False

        Dim frmLogin As New FLogin
        With frmLogin
            .Companias = companias
            .Idiomas = idiomas
            .UtilizarIdioma = utilizarIdioma

            .ShowDialog()
            retorno = .Aceptar
            .Dispose()
        End With

        Return retorno
    End Function

    Public Function LoginSQL(ByVal servidor As String, ByVal baseDeDatos As String, ByVal usuario As String, ByVal password As String) As Boolean
        Dim retorno As Boolean = False

        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=" + servidor + "; Initial Catalog=" + baseDeDatos + "; uid=" + usuario + "; pwd=" + password

        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                retorno = True
                ConexionSQL = conexion
            End If
        Catch errSQL As SqlClient.SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try

        Return retorno
    End Function
End Class
