Public Class Mensajes
    Public Property Codigo As Integer
    Public Property Idioma As String
    Public Property Texto As String

    Public Sub New()
        Codigo = 0
        Idioma = String.Empty
        Texto = String.Empty
    End Sub

    Public Sub New(ByVal codigo As Integer, ByVal idioma As String, ByVal texto As String)
        Me.Codigo = codigo
        Me.Idioma = idioma
        Me.Texto = texto
    End Sub
End Class
