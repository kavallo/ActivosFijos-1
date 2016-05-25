Imports System.Data.SqlClient

Public Class Helper
#Region " [Idiomas] "
    Public Shared Function LeerIdioma(Optional ByVal codigo As String = "") As List(Of Citi.Synergia.Entidades.Idiomas)
        Dim retorno As List(Of Citi.Synergia.Entidades.Idiomas) = Nothing

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.LeerIdioma(codigo)

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If retorno Is Nothing Then
            retorno = New List(Of Citi.Synergia.Entidades.Idiomas)
        End If

        Return retorno
    End Function
#End Region

#Region " [Aplicaciones] "
    Public Shared Function LeerAplicaciones() As List(Of Citi.Synergia.Entidades.Aplicaciones)
        Dim retorno As List(Of Citi.Synergia.Entidades.Aplicaciones) = Nothing

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.LeerAplicaciones()

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If retorno Is Nothing Then
            retorno = New List(Of Citi.Synergia.Entidades.Aplicaciones)
        End If

        Return retorno
    End Function

    Public Shared Function AplicacionAgregar(ByVal aplicacion As String) As Boolean
        Dim retorno As Boolean = False

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            oIdiomas.AplicacionAgregar(aplicacion)

            retorno = True

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        Return retorno
    End Function
#End Region

#Region " [Formas & Controles] "
    Public Shared Function LeerFormas(ByVal aplicacion As String, Optional ByVal forma As String = "") As List(Of Citi.Synergia.Entidades.Formas)
        Dim retorno As List(Of Citi.Synergia.Entidades.Formas) = Nothing

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.LeerFormas(aplicacion, forma)

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If retorno Is Nothing Then
            retorno = New List(Of Citi.Synergia.Entidades.Formas)
        End If

        Return retorno
    End Function

    Public Shared Function LeerFormasIdiomas(ByVal aplicacion As String, Optional ByVal forma As String = "", Optional ByVal idioma As String = "") As List(Of Citi.Synergia.Entidades.Formas)
        Dim retorno As List(Of Citi.Synergia.Entidades.Formas) = Nothing

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.LeerFormasIdiomas(aplicacion, forma, idioma)

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If retorno Is Nothing Then
            retorno = New List(Of Citi.Synergia.Entidades.Formas)
        End If

        Return retorno
    End Function

    Public Shared Function FormaAgregar(ByVal aplicacion As String, ByVal forma As String, ByVal titulos As List(Of Citi.Synergia.Entidades.Formas)) As Boolean
        Dim retorno As Boolean = False

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            oIdiomas.FormaAgregar(aplicacion, forma, titulos)

            retorno = True

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        Return retorno
    End Function

    Public Shared Function FormasEditar(ByVal aplicacion As String, ByVal formas As List(Of Citi.Synergia.Entidades.Formas)) As Boolean
        Dim retorno As Boolean = False

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            oIdiomas.FormasEditar(aplicacion, formas)

            retorno = True

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        Return retorno
    End Function

    Public Shared Function LeerControlesIdiomas(ByVal aplicacion As String, ByVal forma As String) As List(Of Citi.Synergia.Entidades.ControlDetalle)
        Dim retorno As List(Of Citi.Synergia.Entidades.ControlDetalle) = Nothing

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.LeerControlesIdiomas(aplicacion, forma)

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If retorno Is Nothing Then
            retorno = New List(Of Citi.Synergia.Entidades.ControlDetalle)
        End If

        Return retorno
    End Function

    Public Shared Function ControlEditar(ByVal aplicacion As String, ByVal forma As String, ByVal controles As List(Of Citi.Synergia.Entidades.ControlDetalle)) As Boolean
        Dim retorno As Boolean = False

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            oIdiomas.ControlEditar(aplicacion, forma, controles)

            retorno = True

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        Return retorno
    End Function

    Public Shared Function ControlAgregar(ByVal aplicacion As String, ByVal forma As String, ByVal controles As List(Of Citi.Synergia.Entidades.ControlDetalle)) As Boolean
        Dim retorno As Boolean = False

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            oIdiomas.ControlAgregar(aplicacion, forma, controles)

            retorno = True

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        Return retorno
    End Function
#End Region

#Region " [Mensajes] "
    Public Shared Function LeerMensajeIdiomas(Optional ByVal codigo As Integer = 0, Optional ByVal idioma As String = "") As List(Of Citi.Synergia.Entidades.Mensajes)
        Dim retorno As List(Of Citi.Synergia.Entidades.Mensajes) = Nothing

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.LeerMensajeIdiomas(codigo, idioma)

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If retorno Is Nothing Then
            retorno = New List(Of Citi.Synergia.Entidades.Mensajes)
        End If

        Return retorno
    End Function

    Public Shared Function MensajesEditar(ByVal mensajes As List(Of Citi.Synergia.Entidades.Mensajes)) As Boolean
        Dim retorno As Boolean = False

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            oIdiomas.MensajesEditar(mensajes)

            retorno = True

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        Return retorno
    End Function

    Public Shared Function MensajeAgregar(ByVal mensajes As List(Of Citi.Synergia.Entidades.Mensajes)) As Boolean
        Dim retorno As Boolean = False

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            oIdiomas.MensajeAgregar(mensajes)

            retorno = True

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        Return retorno
    End Function

    Public Shared Function MensajeCodigoSugerido() As Integer
        Dim retorno As Integer = Nothing

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.MensajeCodigoSugerido()

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If IsNothing(retorno) Then
            retorno = 0
        End If

        Return retorno
    End Function

    Public Shared Function MensajeExiste(ByVal mensaje As String) As String
        Dim retorno As String = String.Empty

        Dim oIdiomas As New Citi.Synergia.Traductor.Idiomas

        Try
            retorno = oIdiomas.MensajeExiste(mensaje)

        Catch errSQL As SqlException
            MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        If String.IsNullOrEmpty(retorno) Then
            retorno = String.Empty
        End If

        Return retorno
    End Function
#End Region
End Class
