Imports System.Runtime.InteropServices
<ComVisible(True)> _
<Guid("ac9a2970-6413-42c0-b224-f88484d7dce9")> _
<ClassInterface(ClassInterfaceType.None)> _
Public Class SGClienteServidor
    Implements iSGClienteServidor

#Region "Atributos"
    Private _appId As Integer = -1
    Private _appName As String = String.Empty
    Private _pathConfigXML As String = String.Empty
    Private _usernameSecurityGateway As String = String.Empty
    Private _passwordSecurityGateway As String = String.Empty
    Private _credencialesExternasUsername As String = String.Empty
    Private _credencialesExternasPassword As String = String.Empty
    Private _opcionID As String = String.Empty
    Private _opcionDescripcion As String = String.Empty
    Private _procesosSecurityGateway As ProcesosSG
    Private _sesionIniciada As Boolean = False
    Private _ImplementaGUI As Boolean = False
    Private _listaPermisosAccesos As List(Of PermisoAcceso) 'Se instancia en ExtraerListaPermisosAcceso()
    Private _sgInterface As SGInterface = FactorySGInstance.getInstanceInterface()



#End Region

#Region "Propiedades"
    '''<summary>
    '''ID del sistema/aplicación en la base de datos de Security Gateway.
    '''</summary>
    Public Property appId() As Integer Implements iSGClienteServidor.appId
        Get
            Return _appId
        End Get
        Set(ByVal value As Integer)
            _appId = value
            If _appName.Length > 0 And _pathConfigXML.Length > 0 And _procesosSecurityGateway Is Nothing Then
                _procesosSecurityGateway = New ProcesosSG(_appId, _appName, _pathConfigXML, _sgInterface)
            End If
        End Set
    End Property
    '''<summary>
    '''Nombre del sistema/aplicación en la base de datos de Security Gateway.
    '''</summary>
    Public Property appName() As String Implements iSGClienteServidor.appName
        Get
            Return _appName
        End Get
        Set(ByVal value As String)
            value = value.Trim()
            If value.Length > 0 Then
                _appName = value
                If _appId <> -1 And _pathConfigXML.Length > 0 And _procesosSecurityGateway Is Nothing Then
                    _procesosSecurityGateway = New ProcesosSG(_appId, _appName, _pathConfigXML, _sgInterface)
                End If
            End If
        End Set
    End Property
    '''<summary>
    '''Directorio donde se encuentra ubicado el archivo config.xml que es utilizado internamente por Security Gateway.
    '''</summary>
    Public Property pathConfigXml() As String Implements iSGClienteServidor.pathConfigXml
        Get
            Return _pathConfigXML
        End Get
        Set(ByVal value As String)
            value = value.Trim()
            If value.Length > 0 Then
                _pathConfigXML = KnownFolderFullPath(value)
                If _appId <> -1 And _appName.Length > 0 And _procesosSecurityGateway Is Nothing Then
                    _procesosSecurityGateway = New ProcesosSG(_appId, _appName, _pathConfigXML, _sgInterface)
                End If
            End If
        End Set
    End Property

    '''<summary>
    '''Asigna o retorna: Verdadero si se utiliza la interfase grafica provista por Security Gateway.
    '''</summary>
    Property ImplementaGUI() As Boolean Implements iSGClienteServidor.ImplementaGUI
        Get
            Return _ImplementaGUI
        End Get
        Set(ByVal value As Boolean)
            _ImplementaGUI = value
        End Set
    End Property


    '''<summary>
    '''Listado de IDs de las opciones disponibles para el usuario registradas en el servidor de Security Gateway.
    '''</summary>
    Public ReadOnly Property stringFuncionesID() As String Implements iSGClienteServidor.stringFuncionesID
        Get
            Return _opcionID
        End Get
    End Property
    '''<summary>
    '''Listado de descripciones de las opciones disponibles para el usuario registradas en el servidor de Security Gateway.
    '''</summary>
    Public ReadOnly Property stringFuncionesDescripcion() As String Implements iSGClienteServidor.stringFuncionesDescripcion
        Get
            Return _opcionDescripcion
        End Get
    End Property
    '''<summary>
    '''Indica si se tiene una sesión iniciada.
    '''</summary>
    Public ReadOnly Property sesionIniciada() As Boolean Implements iSGClienteServidor.sesionIniciada
        Get
            Return _sesionIniciada
        End Get
    End Property
    '''<summary>
    '''Username de Security Gateway
    '''</summary>
    Public ReadOnly Property usernameSecurityGateway() As String Implements iSGClienteServidor.usernameSecurityGateway
        Get
            Return _usernameSecurityGateway
        End Get
    End Property
    '''<summary>
    '''Password que corresponde al username de Security Gateway
    '''</summary>
    Public ReadOnly Property passwordSecurityGateway() As String Implements iSGClienteServidor.passwordSecurityGateway
        Get
            Return _passwordSecurityGateway
        End Get
    End Property
    ''' <summary>
    ''' Username para conexion con base de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property credencialesExternasUsername() As String Implements iSGClienteServidor.credencialesExternasusername
        Get
            Return _credencialesExternasUsername
        End Get
    End Property

    ''' <summary>
    ''' Password para conexion con Base de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property credencialesExternasPassword() As String Implements iSGClienteServidor.CredencialesExternaspassword
        Get
            Return _credencialesExternasPassword
        End Get
    End Property


    '''<summary>
    '''Objeto/instancia de SGLibrary (Security Gateway)
    '''</summary>
    Public ReadOnly Property objetoSGLibrary() As Object Implements iSGClienteServidor.objetoSGLibrary
        Get
            Return _sgInterface
        End Get
    End Property
#End Region

#Region "Constructor"
    ''' <summary>
    ''' Constructor de la Clase SecurityGateway_Procesos
    ''' </summary>
    <Obsolete("Se deja el constructor sin parametros para compatibilidad de programas que ya lo utilizan, " _
              & "pero deberá de usuarse alguno de los constructores con parametros para evitar errores de funcionamiento", False)> _
    Sub New()
        Try
            pathConfigXml = My.Settings("SG_PathConfigXML")
        Catch ex As Exception
            MsgBox("Error en tiempo de ejecución. " & ex.Message, MsgBoxStyle.Critical, Me.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Constructor de la Clase SecurityGateway_Procesos
    ''' </summary>
    ''' <param name="appId">System Id #</param>
    ''' <param name="appName">Application Name </param>
    Sub New(ByVal appId As Integer, ByVal appName As String)
        Try
            _appId = appId
            _appName = appName.Trim
            pathConfigXml = My.Settings("SG_PathConfigXML")
            _procesosSecurityGateway = New ProcesosSG(_appId, _appName, _pathConfigXML, _sgInterface)
        Catch ex As Exception
            MsgBox("Error en tiempo de ejecución. " & ex.Message, MsgBoxStyle.Critical, Me.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Constructor de la Clase SecurityGateway_Procesos
    ''' </summary>
    ''' <param name="appId">System Id #</param>
    ''' <param name="appName">Application Name </param>
    ''' <param name="pathArchivoConfigXml">Path del archivo config.xml utilizado por Security Gateway</param>
    Sub New(ByVal appId As Integer, ByVal appName As String, ByVal pathArchivoConfigXml As String)
        Try
            _appId = appId
            _appName = appName
            pathConfigXml = pathArchivoConfigXml.Trim
            _procesosSecurityGateway = New ProcesosSG(_appId, _appName, _pathConfigXML, _sgInterface)
        Catch ex As Exception
            MsgBox("Error en tiempo de ejecución. " & ex.Message, MsgBoxStyle.Critical, Me.ToString())
        End Try
    End Sub
#End Region

#Region "Destructor"


    'Guatemala 06 Marzo 2012: Se elimino el destructor ya que elimina los usuarios de la base de datos cuando se activa al garbage collector
    'Protected Overrides Sub Finalize()
    '    Dim MensajeError As String = String.Empty
    '    If _sesionIniciada Then
    '        Logout(MensajeError)
    '    End If
    'End Sub
#End Region

#Region "Métodos Públicos"
    '''<summary>
    '''Función que realiza el proceso de Login hacia el servidor de Security Gateway.
    '''</summary>
    '''<param name="username">Usuario almacenado en la base de datos de Security Gateway.</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en la base de datos de Security Gateway.</param>
    Public Function Login(ByVal username As String, ByVal password As String, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.Login
        Dim respuesta As Respuesta
        Dim resultado As Boolean = False
        If Not _sesionIniciada Then
            If Not (_procesosSecurityGateway Is Nothing) Then
                Try
                    If username.Length > 0 Then
                        If password.Length > 0 Then
                            _usernameSecurityGateway = username
                            _passwordSecurityGateway = password
                            respuesta = _procesosSecurityGateway.login(username, password)

                            resultado = respuesta.finalizadoExitosamente
                            If resultado Then
                                _sesionIniciada = True
                                errorMessage = String.Empty
                                _credencialesExternasUsername = respuesta.usuario
                                _credencialesExternasPassword = respuesta.password
                                _opcionDescripcion = respuesta.descripcionesFuncs
                                _opcionID = respuesta.codigosFuncs
                                ExtraerListaPermisosAcceso()
                            Else
                                _sesionIniciada = False
                                errorMessage = respuesta.mensajeDevuelto
                                _opcionDescripcion = String.Empty
                                _opcionID = String.Empty
                            End If
                        Else
                            resultado = False
                            errorMessage = "Debe ingresar el Username de Security Gateway."
                        End If
                    Else
                        resultado = False
                        errorMessage = "Debe ingresar el Password que corresponde al Username de Security Gateway."
                    End If
                Catch ex As Exception
                    resultado = False
                    errorMessage = "Error en tiempo de ejecución. " & ex.Message
                End Try
            Else
                resultado = False
                errorMessage = "Debe especificar previamente las propiedades:" & _
                            Environment.NewLine & "        - appId = ID de la aplicación en Security Gateway. " & _
                            Environment.NewLine & "        - appName = Nombre de la aplicación. " & _
                            Environment.NewLine & "        - pathConfigXml = Localización del archivo Config.xml utilizado por Security Gateway."
            End If
        Else
            resultado = False
            errorMessage = "Ya se ha iniciado una sesión. Debe cerrarla con la función Logout antes de iniciar otra."
        End If
        Return resultado
    End Function



    '''<summary>
    '''Función que realiza el proceso de Login Implementando Interfase Grafica hacia el servidor de Security Gateway.
    '''</summary>    
    Public Function RSMSLogin(ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.RSMSLogin
        Dim respuesta As Respuesta
        Dim resultado As Boolean = False
        ImplementaGUI = True

        If Not _sesionIniciada Then
            If Not (_procesosSecurityGateway Is Nothing) Then
                Try
                    respuesta = _procesosSecurityGateway.RSMSlogin()
                    resultado = respuesta.finalizadoExitosamente
                    If resultado Then
                        _sesionIniciada = True
                        errorMessage = String.Empty
                        _usernameSecurityGateway = respuesta.usuario
                        _credencialesExternasUsername = respuesta.usuario
                        _credencialesExternasPassword = respuesta.password
                        _opcionDescripcion = respuesta.descripcionesFuncs
                        _opcionID = respuesta.codigosFuncs
                        ExtraerListaPermisosAcceso()

                        '-- Agregado por Hugo Villatoro (Diciembre 2014)
                        Dim usuarioSSO As New Respuesta

                        usuarioSSO = _procesosSecurityGateway.getExternalCredentials()
                        _usernameSecurityGateway = usuarioSSO.usuario
                    Else
                        _sesionIniciada = False
                        errorMessage = respuesta.mensajeDevuelto
                        _opcionDescripcion = String.Empty
                        _opcionID = String.Empty
                    End If


                Catch ex As Exception
                    resultado = False
                    errorMessage = "Error en tiempo de ejecución. " & ex.Message
                End Try
            Else
                resultado = False
                errorMessage = "Debe especificar previamente las propiedades:" & _
                            Environment.NewLine & "        - appId = ID de la aplicación en Security Gateway. " & _
                            Environment.NewLine & "        - appName = Nombre de la aplicación. " & _
                            Environment.NewLine & "        - pathConfigXml = Localización del archivo Config.xml utilizado por Security Gateway."
            End If
        Else
            resultado = False
            errorMessage = "Ya se ha iniciado una sesión. Debe cerrarla con la función Logout antes de iniciar otra."
        End If
        Return resultado
    End Function






    '''<summary>
    '''Función que realiza el proceso de Logout hacia el servidor de Security Gateway.
    '''</summary>
    Public Function Logout(ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.Logout
        Dim respuesta As Respuesta
        Dim resultado As Boolean = False
        If _sesionIniciada Then
            If Not (_procesosSecurityGateway Is Nothing) Then
                Try
                    respuesta = _procesosSecurityGateway.logout
                    resultado = respuesta.finalizadoExitosamente
                    If resultado Then
                        errorMessage = String.Empty
                        _sesionIniciada = False
                    Else
                        errorMessage = respuesta.mensajeDevuelto
                    End If
                Catch ex As Exception
                    resultado = False
                    errorMessage = "Error en tiempo de ejecución. " & ex.Message
                End Try
            Else
                resultado = False
                errorMessage = "Debe especificar previamente las propiedades appId, appName y pathConfigXml que corresponden al ID de la aplicación en Security Gateway, el nombre de la aplicación y la localización del archivo Config.xml utilizado por Security Gateway."
            End If
        Else
            resultado = False
            errorMessage = "No se ha iniciado una sesión."
        End If
        Return resultado
    End Function
    '''<summary>
    '''Función que se conecta al servidor de Security Gateway y guarda en la memoria los permisos de acceso que tiene el usuario.
    '''Ejecuta las funciones de login, consulta de permisos y logout (opcional). Devuelve True en caso de haber finalizado exitosamente el proceso.
    '''</summary>
    '''<param name="idApp">ID de la aplicación/sistema en la base de datos de Security Gateway</param>
    '''<param name="nameApp">Nombre de la aplicación/sistema en la base de datos de Security Gateway</param>
    '''<param name="username">Usuario almacenado en la base de datos de Security Gateway</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en la base de datos de Security Gateway</param>
    '''<param name="logout">Indica si después de la consulta de permisos al servidor de Security Gateway se hará Logout.</param>
    Public Overloads Function TraerPermisosAcceso(ByVal idApp As Integer, ByVal nameApp As String, ByVal username As String, ByVal password As String, ByVal logout As Boolean, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.TraerPermisosAcceso
        Dim resultado As Boolean = False
        Try
            resultado = nameApp.Length > 0
            If resultado Then
                appId = idApp
                appName = nameApp
                resultado = TraerPermisosAcceso(username, password, logout, errorMessage)
            Else
                errorMessage = "Debe especificar el nombre de la aplicación/sistema."
            End If
        Catch ex As Exception
            resultado = False
            errorMessage = ex.Message
        End Try
        Return resultado
    End Function


    '''<summary>
    '''Función que se conecta al servidor de Security Gateway y guarda en la memoria los permisos de acceso que tiene el usuario.
    '''Ejecuta las funciones de login, consulta de permisos y logout (opcional). Devuelve True en caso de haber finalizado exitosamente el proceso.
    '''</summary>
    '''<param name="idApp">ID de la aplicación/sistema en la base de datos de Security Gateway</param>
    '''<param name="nameApp">Nombre de la aplicación/sistema en la base de datos de Security Gateway</param>    
    '''<param name="logout">Indica si después de la consulta de permisos al servidor de Security Gateway se hará Logout.</param>
    Public Overloads Function TraerPermisosAcceso(ByVal idApp As Integer, ByVal nameApp As String, ByVal logout As Boolean, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.TraerPermisosAcceso
        Dim resultado As Boolean = False
        Try
            ImplementaGUI = True
            resultado = nameApp.Length > 0
            If resultado Then
                appId = idApp
                appName = nameApp
                resultado = TraerPermisosAcceso("", "", logout, errorMessage)
            Else
                errorMessage = "Debe especificar el nombre de la aplicación/sistema."
            End If
        Catch ex As Exception
            resultado = False
            errorMessage = ex.Message
        End Try
        Return resultado
    End Function








    '''<summary>
    '''Función que se conecta al servidor de Security Gateway y guarda en la memoria los permisos de acceso que tiene el usuario.
    '''Ejecuta las funciones de login, consulta de permisos y logout (opcional). Devuelve True en caso de haber finalizado exitosamente el proceso.
    '''</summary>
    '''<param name="username">Usuario almacenado en la base de datos de Security Gateway</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en la base de datos de Security Gateway</param>
    '''<param name="logout">Indica si después de la consulta de permisos al servidor de Security Gateway se hará Logout.</param>
    Public Overloads Function TraerPermisosAcceso(ByVal username As String, ByVal password As String, ByVal logout As Boolean, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.TraerPermisosAcceso
        Dim resultado As Boolean = False
        Try
            If Not _sesionIniciada Then
                If ImplementaGUI Then
                    resultado = RSMSLogin(errorMessage)
                Else
                    resultado = Login(username, password, errorMessage)


                End If

            Else
                resultado = True
            End If
            If Not resultado Then
                errorMessage = "Error en el login. " & errorMessage
            Else
                ExtraerListaPermisosAcceso()
                If (logout) Then
                    resultado = Me.Logout(errorMessage)
                    If Not resultado Then
                        errorMessage = "Error en el logout. " & errorMessage
                    End If
                End If
            End If
        Catch ex As Exception
            resultado = False
            errorMessage = ex.Message
        End Try
        Return resultado
    End Function
    '''<summary>
    '''Función que realiza el proceso de cambio de password en el servidor de Security Gateway.
    '''</summary>
    '''<param name="username">Usuario almacenado en base de datos de Security Gateway</param>
    '''<param name="password">Contraseña actual que corresponde al usuario registrado en base de datos de Security Gateway</param>
    '''<param name="newPassword">Nueva contraseña para el usuario registrado en base de datos de Security Gateway</param>
    '''<param name="reTypeNewPassword">Confirmación de la nueva contraseña para el usuario registrado en base de datos de Security Gateway</param>
    Public Function ChangePassword(ByVal username As String, ByVal password As String, ByVal newPassword As String, ByVal reTypeNewPassword As String, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.ChangePassword
        Dim respuesta As Respuesta
        Dim resultado As Boolean
        If Not (_procesosSecurityGateway Is Nothing) Then
            If newPassword = reTypeNewPassword Then
                Try
                    respuesta = _procesosSecurityGateway.changePassword(username, password, newPassword, reTypeNewPassword)
                    resultado = respuesta.finalizadoExitosamente
                    If resultado Then
                        errorMessage = String.Empty
                    Else
                        errorMessage = respuesta.mensajeDevuelto
                    End If
                Catch ex As Exception
                    resultado = False
                    errorMessage = "Error en tiempo de ejecución. " & ex.Message
                End Try
            Else
                resultado = False
                errorMessage = "La nueva contraseña ingresada la primera vez es diferente de la ingresada para confirmación."
            End If
        Else
            resultado = False
            errorMessage = "Debe especificar previamente las propiedades:" & _
                            Environment.NewLine & "        - appId = ID de la aplicación en Security Gateway. " & _
                            Environment.NewLine & "        - appName = Nombre de la aplicación. " & _
                            Environment.NewLine & "        - pathConfigXml = Localización del archivo Config.xml utilizado por Security Gateway."
        End If
        Return resultado
    End Function
    '''<summary>
    '''Función que devuelve True si el usuario tiene permiso de acceso a la función de Security Gateway especificada.
    '''Devuelve False en caso contrario.
    '''</summary>
    '''<param name="codigoAcceso">Código del acceso contenido en la descripción de función de Security Gateway</param>
    Public Function TienePermisoAcceso(ByVal codigoAcceso As String, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.TienePermisoAcceso
        Dim resultado As Boolean = False
        Try


            If (_listaPermisosAccesos Is Nothing) Then
                ExtraerListaPermisosAcceso()
            End If
            Dim permisos = From a In _listaPermisosAccesos Where a.CodigoDelAcceso = codigoAcceso Select a
            resultado = (permisos.Count > 0)
        Catch ex As Exception
            resultado = False
            errorMessage = ex.Message
        End Try
        Return resultado
    End Function
    '''<summary>
    '''Función que devuelve el listado de permisos de acceso que tiene el usuario en Security Gateway.
    '''</summary>
    Public Function ListadoTodosPermisosAcceso() As String Implements iSGClienteServidor.ListadoTodosPermisosAcceso
        Dim Permiso As PermisoAcceso
        Dim Permisos As New System.Text.StringBuilder
        If Not (_listaPermisosAccesos Is Nothing) Then
            For Each Permiso In _listaPermisosAccesos
                Permisos.Append(Permiso.ModuleID & "   " & Permiso.FunctionID & "   " & Permiso.CodigoDelAcceso & "   " & Permiso.DescripcionDelAcceso & Environment.NewLine)
            Next
            Return Permisos.ToString()
        Else
            Return "No se han consultado aún los permisos de acceso."
        End If
    End Function
    '''<summary>
    '''Función que realiza el proceso de cambio de password en el servidor de Security Gateway.
    '''</summary>
    '''<param name="username">Usuario registrado en base de datos de Security Gateway</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en base de datos de Security Gateway</param>
    '''<param name="credencialesExternas_username">Username de las credenciales externas devueltas por Security Gateway</param>
    '''<param name="credencialesExternas_password">Password de las credenciales externas devueltas por Security Gateway</param>
    Public Function obtenerCredencialesExternas(ByVal username As String, ByVal password As String, ByRef credencialesExternas_username As String, ByRef credencialesExternas_password As String, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.obtenerCredencialesExternas
        ' Modificación
        ' Fecha: Agosto 2014
        ' Hecho por: Hugo Villatoro (Synergia)
        ' Motivo: Debido al cambio de formato de functional ID de SQL se requiere que se devuelva
        '         el login y pwd de SQL, y el método geExternalCredentials de la librería de SG devuelve
        '         el SOE como usuario y no el login.
        Dim respuesta As Respuesta
        Dim resultado As Boolean = False
        Dim mantenerSesionAbierta As Boolean = False
        Dim mensaje As String = String.Empty
        If Not (_procesosSecurityGateway Is Nothing) Then
            If (_sesionIniciada) Then
                mantenerSesionAbierta = True
                ' Agregadas 3 líneas
                respuesta = New Respuesta()
                respuesta.asignaValoresLogin(_credencialesExternasUsername, _credencialesExternasPassword, _opcionDescripcion, _opcionID, String.Empty, 1, 0, 0)
                resultado = True
            Else
                If ImplementaGUI Then
                    ' Comentado
                    'resultado = RSMSLogin(errorMessage)
                    ' Agregadas 2 líneas
                    respuesta = _procesosSecurityGateway.RSMSlogin()
                    resultado = respuesta.finalizadoExitosamente
                Else
                    ' Comentado
                    'resultado = Login(username, password, errorMessage)
                    ' Agregadas 2 líneas
                    respuesta = _procesosSecurityGateway.login(username, password)
                    resultado = respuesta.finalizadoExitosamente
                End If
            End If
            If (_sesionIniciada) Then
                ' Comentadas 2 líneas
                'respuesta = _procesosSecurityGateway.getExternalCredentials()
                'resultado = respuesta.finalizadoExitosamente
                If resultado Then
                    credencialesExternas_username = respuesta.usuario
                    credencialesExternas_password = respuesta.password
                    _credencialesExternasUsername = credencialesExternas_username
                    _credencialesExternasPassword = credencialesExternas_password
                    errorMessage = String.Empty
                Else
                    errorMessage = respuesta.mensajeDevuelto
                End If
                If Not (mantenerSesionAbierta) Then
                    Logout(mensaje)
                End If
            End If
        Else
            resultado = False
            errorMessage = "Debe especificar previamente las propiedades:" & _
                            Environment.NewLine & "        - appId = ID de la aplicación en Security Gateway. " & _
                            Environment.NewLine & "        - appName = Nombre de la aplicación. " & _
                            Environment.NewLine & "        - pathConfigXml = Localización del archivo Config.xml utilizado por Security Gateway."
        End If
        Return resultado
    End Function
    '''<summary>
    '''Función que realiza el proceso de cambio de password en el servidor de Security Gateway.
    '''</summary>
    '''<param name="credencialesExternas_username">Username de las credenciales externas devueltas por Security Gateway</param>
    '''<param name="credencialesExternas_password">Password de las credenciales externas devueltas por Security Gateway</param>
    Public Function obtenerCredencialesExternas(ByRef credencialesExternas_username As String, ByRef credencialesExternas_password As String, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.obtenerCredencialesExternas
        Dim resultado As Boolean = False
        If Not (_procesosSecurityGateway Is Nothing) Then
            If Not (_sesionIniciada) Or Not (_usernameSecurityGateway.Length > 0) Then
                errorMessage = "No se ha iniciado una sesión con el servidor de Security Gateway."
            Else
                resultado = obtenerCredencialesExternas(_usernameSecurityGateway, _passwordSecurityGateway, credencialesExternas_username, credencialesExternas_password, errorMessage)
            End If
        Else
            resultado = False
            errorMessage = "Debe especificar previamente las propiedades:" & _
                            Environment.NewLine & "        - appId = ID de la aplicación en Security Gateway. " & _
                            Environment.NewLine & "        - appName = Nombre de la aplicación. " & _
                            Environment.NewLine & "        - pathConfigXml = Localización del archivo Config.xml utilizado por Security Gateway."
        End If
        Return resultado
    End Function
#End Region

#Region "Métodos Privados"
    Private Function KnownFolderFullPath(ByVal pathOriginal As String) As String
        Dim Resultado As String = pathOriginal.ToUpper()
        Resultado = Resultado.Replace("%SYSTEM%", Environment.GetFolderPath(Environment.SpecialFolder.System))
        Return Resultado.ToLower()
    End Function
    Private Sub ExtraerListaPermisosAcceso()
        Try
            'Arreglos para el contenido de los string de IDs y de descripciones de funciones
            Dim IDs As String()
            Dim DESCRIPs As String()
            'Variables usadas para recorrer los arreglos
            Dim I As Integer
            Dim Id As String
            Dim Descrip As String
            'Variables que corresponderan a los atributos en el objeto SecurityGateway_PermisoAcceso
            Dim ModuleID As Short
            Dim FunctionID As Short
            Dim DescripID As String
            Dim Descripcion As String
            IDs = Split(_opcionID, "**")
            DESCRIPs = _opcionDescripcion.Split("*")
            'Clear lista
            If Not (_listaPermisosAccesos Is Nothing) Then
                _listaPermisosAccesos.Clear()
            Else
                _listaPermisosAccesos = New List(Of PermisoAcceso)
            End If
            'Recorrer ambos arreglos para extraer Modulo, Funcion, Codigo en Descripcion, Descripcion
            I = 0
            Do While I < IDs.Count And IDs.GetValue(I).ToString().Contains("*")
                Id = IDs.GetValue(I)
                Descrip = DESCRIPs.GetValue(I)
                ModuleID = Id.Substring(0, Id.IndexOf("*"))
                FunctionID = Id.Substring(Id.IndexOf("*") + 1)
                DescripID = Descrip.Substring(0, Descrip.IndexOf(" "))
                Descripcion = Descrip.Substring(Descrip.IndexOf(" ") + 1)
                _listaPermisosAccesos.Add(New PermisoAcceso(ModuleID, FunctionID, DescripID, Descripcion))
                I += 1
            Loop
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    ''' <summary>
    ''' Función que devuelve True si el usuario tiene permiso de acceso a la función de Security Gateway especificada con opcion a guardar auditoria en SG
    ''' </summary>
    ''' <param name="codigoAcceso"> Código del Acceso contenido en la descripcion de SG</param>
    ''' <param name="grabaAuditoria">Verdadero: llama a la función AuditLog de SG</param>
    ''' <param name="muestraMensaje">Verdadero: Muestra un MsgBox si el usuario no tiene permisos</param>
    ''' <param name="errorMessage">Variable de salida con descripcion si algun error ocurriera dentro del procedimiento</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TienePermisoAcceso(ByVal codigoAcceso As String, ByVal grabaAuditoria As Boolean, ByVal muestraMensaje As Boolean, ByRef errorMessage As String) As Boolean Implements iSGClienteServidor.TienePermisoAcceso
        Dim resultado As Boolean = False

        Try


            If (_listaPermisosAccesos Is Nothing) Then
                ExtraerListaPermisosAcceso()
            End If

            Dim CodigoAccesoDenegado As String = getAccesoDenegado()


            Dim permisos = From a In _listaPermisosAccesos _
                           Where a.CodigoDelAcceso = codigoAcceso _
                           Select a

            resultado = (permisos.Count > 0)



            If resultado And grabaAuditoria Then

                _procesosSecurityGateway.auditLog(CShort(appId), CShort(permisos.First.ModuleID), CShort(permisos.First.FunctionID), "Solicitud de Acceso", "User: " + _usernameSecurityGateway + "Result: Acceso concedido")

            Else
                If CodigoAccesoDenegado.Trim <> String.Empty Then
                    Dim Acceso = (From a In _listaPermisosAccesos _
                           Where a.CodigoDelAcceso = CodigoAccesoDenegado _
                           Select a).First

                    _procesosSecurityGateway.auditLog(CShort(appId), CShort(Acceso.ModuleID), CShort(Acceso.FunctionID), "", "User: " + _usernameSecurityGateway + " Acceso Denegado a la funcion: " + codigoAcceso)

                End If


            End If


        Catch ex As Exception
            resultado = False
            errorMessage = ex.Message
        End Try
        Return resultado
    End Function



    Private Function getAccesoDenegado() As String

        Try

        
            If (_listaPermisosAccesos Is Nothing) Then
                ExtraerListaPermisosAcceso()
            End If


            Dim Accesos = From a In _listaPermisosAccesos
                          Where a.CodigoDelAcceso IsNot DBNull.Value _
                                And Val(a.CodigoDelAcceso) = 0
                          Select a

            If Accesos.Any Then
                Dim accesoDenegado = Accesos.First
                Return accesoDenegado.CodigoDelAcceso
            Else
                Return ""

            End If

        Catch ex As Exception
            Return ""
        End Try

        
        

    End Function



#End Region

End Class





