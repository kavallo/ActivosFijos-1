Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQL
    Public Property ConexionSTR As String
    Public Property ConexionSQL As SqlConnection

    ''' <summary>
    ''' Retorna objeto SqlConnection de SQL Server.
    ''' </summary>
    ''' <returns>Objeto SqlConnection</returns>
    ''' <remarks>Toma de base el string de conexion enviada previamente a ConexionSTR</remarks>
    Public Function GetConexion() As SqlClient.SqlConnection
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = ConexionSTR

        Return conexion
    End Function

    ''' <summary>
    ''' Termina conexion con SQL Server.
    ''' </summary>
    ''' <param name="conexion"></param>
    ''' <remarks></remarks>
    Public Sub CerrarConexion(ByVal conexion As SqlConnection)
        If Not conexion Is Nothing Then
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Una vez configurado string de conexion, puede validarse si puede conectarse, si variable de ConexionSQL estuviera en null.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ValidarConexion()
        If ConexionSQL Is Nothing Then
            ConexionSQL = New SqlConnection
            ConexionSQL = GetConexion()
        End If
        If ConexionSQL.State <> ConnectionState.Open Then
            ConexionSQL.Open()
        End If
    End Sub

    ''' <summary>
    ''' Retorna un string en base a query enviado.
    ''' </summary>
    ''' <param name="transactSQL">Sentencia SQL para query.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCadena(ByVal transactSQL As String) As String
        Dim conexion As SqlClient.SqlConnection = ConexionSQL
        Dim retorno As String = String.Empty

        Dim comando As New SqlClient.SqlCommand
        comando.Connection = conexion
        comando.CommandText = transactSQL

        Try
            ValidarConexion()

            retorno = comando.ExecuteScalar()

            comando.Dispose()
            'conexion.Close()

        Catch errSQL As SqlClient.SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try

        Return retorno
    End Function

    ''' <summary>
    ''' Retorna dataset, enviando SqlCommand como parametro.
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataSet(ByVal comando As SqlCommand) As DataSet
        Dim data As New DataSet
        Dim conexion As SqlConnection = ConexionSQL

        comando.Connection = conexion

        Dim puente As New SqlDataAdapter
        puente.SelectCommand = comando

        Try
            ValidarConexion()

            puente.Fill(data)

            Return data

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna DataSet, enviando sentencia SQL como parametro.
    ''' </summary>
    ''' <param name="transactSQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataSet(ByVal transactSQL As String) As DataSet
        Dim comando As New SqlCommand
        comando.CommandText = transactSQL

        Return GetDataSet(comando)
    End Function

    ''' <summary>
    ''' Valida que sentencia SQL contenga clausula Where.
    ''' </summary>
    ''' <param name="strSQL">Tipo String</param>
    ''' <remarks></remarks>
    Public Sub AgregarWhere(ByRef strSQL As String)
        If InStr(UCase(strSQL), "WHERE") = 0 Then
            strSQL += " Where "
        Else
            strSQL += " And "
        End If
    End Sub

    ''' <summary>
    ''' Valida que sentencia SQL contenga clausula where.
    ''' </summary>
    ''' <param name="strSQL">Tipo StringBuilder</param>
    ''' <remarks></remarks>
    Public Sub AgregarWhere(ByRef strSQL As Text.StringBuilder)
        Dim strComando As String = strSQL.ToString
        If InStr(UCase(strComando), "WHERE") = 0 Then
            strSQL.Append(" Where ")
        Else
            strSQL.Append(" And ")
        End If
    End Sub

#Region " [ ExecuteNonQuery ]"
    ''' <summary>
    ''' Ejecuta instruccion SQL con comando como parametro.
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns>Si clausula SQL retorna valor de conteo</returns>
    ''' <remarks></remarks>
    Public Function EjecutarComando(ByRef comando As SqlCommand) As Integer
        Dim conexion As SqlConnection = ConexionSQL
        comando.Connection = conexion

        Try
            ValidarConexion()

            Dim retorno As Integer = comando.ExecuteNonQuery()

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta instruccion SQL con sentencia SQL como parametro
    ''' </summary>
    ''' <param name="transactSQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EjecutarComando(ByVal transactSQL As String) As Integer
        Dim comando As New SqlCommand
        comando.CommandText = transactSQL
        Return EjecutarComando(comando)
    End Function
#End Region

#Region " [ ExecuteScalar ]"
    ''' <summary>
    ''' Ejecuta sentencia SQL enviando comando como parametro.
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns>Un solo objeto</returns>
    ''' <remarks></remarks>
    Public Function EjecutarScalar(ByVal comando As SqlCommand) As Object
        Dim conexion As SqlConnection = ConexionSQL()
        comando.Connection = conexion

        Try
            ValidarConexion()

            Dim retorno As Object
            retorno = comando.ExecuteScalar()

            Return retorno

        Catch errSQL As SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta sentencia SQL enviando como parametro string como parametro
    ''' </summary>
    ''' <param name="transactSQL"></param>
    ''' <returns>Un solo objeto</returns>
    ''' <remarks></remarks>
    Public Function EjecutarScalar(ByVal transactSQL As String) As Object
        Dim comando As New SqlCommand
        comando.CommandText = transactSQL
        Return EjecutarScalar(comando)
    End Function
#End Region

End Class
