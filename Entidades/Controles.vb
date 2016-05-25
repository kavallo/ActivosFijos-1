Imports System.ComponentModel

Public Class Controles
    'Public Property Tipo As String

    Public Property Nombre As String
    Public Property Texto As String
    Public Property ToolTip As String

    Public Sub New()
        Nombre = String.Empty
        Texto = String.Empty
        ToolTip = String.Empty
    End Sub

    Public Sub New(ByVal nombre As String, ByVal texto As String, ByVal toolTip As String)
        Me.Nombre = nombre
        Me.Texto = texto
        Me.ToolTip = toolTip
    End Sub
End Class

Public Class ControlDetalle
    Public Property Aplicacion As String
    Public Property Forma As String
    Public Property Idioma As String
    Public Property Nombre As String
    Public Property Texto As String
    Public Property ToolTipText As String

    Public Sub New()
        Aplicacion = String.Empty
        Forma = String.Empty
        Idioma = String.Empty
        Nombre = String.Empty
        Texto = String.Empty
        ToolTipText = String.Empty
    End Sub

    Public Sub New(ByVal aplicacion As String, ByVal forma As String, ByVal idioma As String, ByVal nombre As String, ByVal texto As String, ByVal toolTipText As String)
        Me.Aplicacion = aplicacion
        Me.Forma = forma
        Me.Idioma = idioma
        Me.Nombre = nombre
        Me.Texto = texto
        Me.ToolTipText = toolTipText
    End Sub
End Class

Public Class Aplicaciones
    Public Property Aplicacion As String

    Public Sub New()
        Me.Aplicacion = String.Empty
    End Sub
    Public Sub New(ByVal aplicacion As String)
        Me.Aplicacion = aplicacion
    End Sub
End Class

Public Class Formas
    Public Property Aplicacion As String
    Public Property Forma As String
    Public Property Linea As Integer
    Public Property Idioma As String
    Public Property Titulo As String

    Public Sub New()
        Me.Aplicacion = String.Empty
        Me.Forma = String.Empty
        Me.Linea = 0
        Me.Idioma = String.Empty
        Me.Titulo = String.Empty
    End Sub

    Public Sub New(ByVal aplicacion As String, ByVal forma As String, ByVal linea As Integer, ByVal idioma As String, ByVal titulo As String)
        Me.Aplicacion = aplicacion
        Me.Forma = forma
        Me.Linea = linea
        Me.Idioma = idioma
        Me.Titulo = titulo
    End Sub
End Class