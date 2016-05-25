Public Class InfoLista
    Public Enum TipoAlineacion As Short
        ALINEAR_IZQ
        ALINEAR_DER
    End Enum
    Public Property Inicio As Short
    Public Property Espacios As Short
    Public Property Largo As Short
    Public Property Titulo As String
    Public Property Alinear As TipoAlineacion
    Public Property Campo As String
    Public Property Tipo As Short
    Public Property Longitud As Short
    Public Property Decimales As Short
    Public Property Llave As Short
    Public Property EsLlave As Boolean
    Public Property IdIdiomaMensaje As Integer
    Public Property ListaValores As List(Of Citi.Synergia.Entidades.CodigoDescripcion)

    Public Sub New()

    End Sub
End Class
