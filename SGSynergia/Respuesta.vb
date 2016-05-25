Class Respuesta

#Region "Atributos"
    Dim _usuario As String
    Dim _password As String
    Dim _descripcionesFuncs As String
    Dim _codigosFuncs As String
    Dim _mensajeDevuelto As String
    Dim _fnLogin As Integer
    Dim _fnAccFuncs As Integer
    Dim _fnAccCodFuncs As Integer
    Dim _fnLogout As Integer
    Dim _fnChangePassword As Integer
    Dim _finalizadoExitosamente As Boolean
    '-- Agregado por Hugo Villatoro (Diciembre 2014)
    Dim _usuarioSSO As String
#End Region

#Region "Propiedades"
    Public ReadOnly Property usuario() As String
        Get
            Return _usuario
        End Get
    End Property
    Public ReadOnly Property password() As String
        Get
            Return _password
        End Get
    End Property
    Public ReadOnly Property descripcionesFuncs() As String
        Get
            Return _descripcionesFuncs
        End Get
    End Property
    Public ReadOnly Property codigosFuncs() As String
        Get
            Return _codigosFuncs
        End Get
    End Property
    Public Property mensajeDevuelto() As String
        Get
            Return _mensajeDevuelto
        End Get
        Set(ByVal value As String)
            _mensajeDevuelto = value
        End Set
    End Property
    Public Property fnLogin() As Integer
        Get
            Return _fnLogin
        End Get
        Set(ByVal value As Integer)
            _fnAccCodFuncs = value
        End Set
    End Property
    Public ReadOnly Property fnAccFuncs() As String
        Get
            Return _fnAccFuncs
        End Get
    End Property
    Public ReadOnly Property fnAccCodFuncs() As String
        Get
            Return _fnAccCodFuncs
        End Get
    End Property
    Public Property fnLogout() As Integer
        Get
            Return _fnLogout
        End Get
        Set(ByVal value As Integer)
            _fnLogout = value
        End Set
    End Property
    Public ReadOnly Property fnChangePassword() As String
        Get
            Return _fnChangePassword
        End Get
    End Property
    Public Property finalizadoExitosamente() As Boolean
        Get
            Return _finalizadoExitosamente
        End Get
        Set(ByVal value As Boolean)
            _finalizadoExitosamente = value
        End Set
    End Property
    '-- Agregado por Hugo Villatoro (Diciembre 2014)
    Public ReadOnly Property usuarioSSO() As String
        Get
            Return Me._usuarioSSO
        End Get
    End Property
#End Region

#Region "Constructor"
    '''<summary>
    '''Clase que almacena las respuestas de los métodos de la clase SGLibrary.dll
    '''</summary>
    Sub New()
        _usuario = ""
        _password = ""
        _descripcionesFuncs = ""
        _codigosFuncs = ""
        _fnLogin = -1
        _fnAccFuncs = -2
        _fnAccCodFuncs = -2
        _fnLogout = -2
        _fnChangePassword = -2
        _finalizadoExitosamente = False
        Me._usuarioSSO = String.Empty
    End Sub
#End Region

#Region "Métodos"
    Public Sub asignaValoresLogin(ByVal user As String, ByVal pass As String, ByVal descripFuncs As String, ByVal codFuncs As String, ByVal mensaje As String, _
        ByVal resLogin As Integer, ByVal resAccFuncs As Integer, ByVal resAccCodFuncs As Integer)
        _usuario = user
        _password = pass
        _descripcionesFuncs = descripFuncs
        _codigosFuncs = codFuncs
        _mensajeDevuelto = mensaje
        _fnLogin = resLogin
        _fnAccFuncs = resAccFuncs
        _fnAccCodFuncs = resAccCodFuncs
    End Sub

    Public Sub asignaValoresLogin(ByVal usuarioSSO As String, ByVal user As String, ByVal pass As String, ByVal descripFuncs As String, ByVal codFuncs As String, ByVal mensaje As String, _
        ByVal resLogin As Integer, ByVal resAccFuncs As Integer, ByVal resAccCodFuncs As Integer)
        _usuario = user
        _password = pass
        _descripcionesFuncs = descripFuncs
        _codigosFuncs = codFuncs
        _mensajeDevuelto = mensaje
        _fnLogin = resLogin
        _fnAccFuncs = resAccFuncs
        _fnAccCodFuncs = resAccCodFuncs
        Me._usuarioSSO = usuarioSSO
    End Sub

    Public Sub asignaValoresChangePass(ByVal user As String, ByVal pass As String, ByVal mensaje As String, ByVal resChangePassword As Integer, ByVal seCambioPass As Boolean)
        _usuario = user
        _password = pass
        _mensajeDevuelto = mensaje
        _fnChangePassword = resChangePassword
        _finalizadoExitosamente = seCambioPass
    End Sub

    Public Sub asignaValoresCredencialesExternas(ByVal mensaje As String, ByVal resAccCodFuncs As Integer)
        _finalizadoExitosamente = (resAccCodFuncs = 1)
        If _finalizadoExitosamente Then
            _usuario = mensaje.Substring(0, mensaje.IndexOf("|"))
            _password = mensaje.Substring(mensaje.IndexOf("|") + 1)

            If _password.EndsWith("*") Then
                _password = _password.Substring(0, _password.Trim.Length - 1)
            End If
        Else
            _mensajeDevuelto = mensaje
        End If
    End Sub
#End Region

End Class


