Public Enum Ambiente
    Produccion = 1
    UAT = 2
    SIT = 3
End Enum

Public Structure DatosConexion

    Private _Servidor As String
    Private _Puerto As String
    Private _BaseDatos As String


    Public Property Database() As String
        Get
            Return _BaseDatos
        End Get
        Set(ByVal value As String)
            _BaseDatos = value
        End Set
    End Property


    Public Property Puerto() As String
        Get
            Return _Puerto
        End Get
        Set(ByVal value As String)
            _Puerto = value
        End Set
    End Property

    Public Property Server() As String
        Get
            Return _Servidor
        End Get
        Set(ByVal value As String)
            _Servidor = value
        End Set
    End Property




    Public Function GetDataSource() As String
        Dim servidor As String = String.Empty


        If String.IsNullOrEmpty(_Puerto) Then
            servidor = _Servidor
        Else
            servidor = _Servidor + "," + _Puerto
        End If

        Return servidor

    End Function

    Public Function getConectionString(ByVal UsuarioDB As String, ByVal passwordDB As String) As String

        Dim strConn As New System.Data.SqlClient.SqlConnectionStringBuilder
        strConn.DataSource = GetDataSource()
        strConn.InitialCatalog = Database
        strConn.UserID = UsuarioDB
        strConn.Password = passwordDB

        Return strConn.ConnectionString

    End Function



End Structure