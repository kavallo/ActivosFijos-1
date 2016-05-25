Public Class TiposDePartidas
    Public Property TipoPartida As String
    Public Property Nombre As String

    Public Sub New()
        TipoPartida = String.Empty
        Nombre = String.Empty
    End Sub

    Public Sub New(ByVal tipoPartida As String, ByVal nombre As String)
        Me.TipoPartida = tipoPartida
        Me.Nombre = nombre
    End Sub
End Class
