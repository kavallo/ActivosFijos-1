Class PermisoAcceso
#Region "Atributos"
    Dim _ModuleID As Short
    Dim _FunctionID As Short
    Dim _DescripID As String
    Dim _Descripcion As String
#End Region
#Region "Propiedades"
    Public ReadOnly Property ModuleID() As Short
        Get
            Return _ModuleID
        End Get
    End Property
    Public ReadOnly Property FunctionID() As Short
        Get
            Return _FunctionID
        End Get
    End Property
    Public ReadOnly Property CodigoDelAcceso() As String
        Get
            Return _DescripID
        End Get
    End Property
    Public ReadOnly Property DescripcionDelAcceso() As String
        Get
            Return _Descripcion
        End Get
    End Property
#End Region
#Region "Constructor"
    Sub New(ByVal IdModulo As Short, ByVal IdFuncion As Short, ByVal CodigoDelAcceso As String, ByVal DescripcionDelAcceso As String)
        _ModuleID = IdModulo
        _FunctionID = IdFuncion
        _DescripID = CodigoDelAcceso
        _Descripcion = DescripcionDelAcceso
    End Sub
#End Region
End Class
