Public Interface iSGClienteServidor

#Region "Propiedades"
    '''<summary>
    '''ID del sistema/aplicación en la base de datos de Security Gateway.
    '''</summary>
    Property appId() As Integer 'Implements iSGClienteServidor.appId
    '''<summary>
    '''Nombre del sistema/aplicación en la base de datos de Security Gateway.
    '''</summary>
    Property appName() As String
    '''<summary>
    '''Directorio donde se encuentra ubicado el archivo config.xml que es utilizado internamente por Security Gateway.
    '''</summary>
    Property pathConfigXml() As String

    '''<summary>
    '''Asigna o retorna: Verdadero si se utiliza la interfase grafica provista por Security Gateway.
    '''</summary>
    Property ImplementaGUI() As Boolean

    '''<summary>
    '''Listado de IDs de las opciones disponibles para el usuario registradas en el servidor de Security Gateway.
    '''</summary>
    ReadOnly Property stringFuncionesID() As String
    '''<summary>
    '''Listado de descripciones de las opciones disponibles para el usuario registradas en el servidor de Security Gateway.
    '''</summary>
    ReadOnly Property stringFuncionesDescripcion() As String
    '''<summary>
    '''Indica si se tiene una sesión iniciada.
    '''</summary>
    ReadOnly Property sesionIniciada() As Boolean
    '''<summary>
    '''Username de Security Gateway
    '''</summary>
    ReadOnly Property usernameSecurityGateway() As String
    '''<summary>
    '''Password que corresponde al username de Security Gateway
    '''</summary>
    ReadOnly Property passwordSecurityGateway() As String
    '''<summary>
    '''Username de Conexion para base de datos
    '''</summary>
    ReadOnly Property credencialesExternasusername() As String
    '''<summary>
    '''Password de conexion para base de datos
    '''</summary>
    ReadOnly Property CredencialesExternaspassword() As String

    '''<summary>
    '''Objeto/instancia de SGLibrary (Security Gateway)
    '''</summary>
    ReadOnly Property objetoSGLibrary() As Object
#End Region

#Region "Métodos Públicos"
    '''<summary>
    '''Función que realiza el proceso de Login hacia el servidor de Security Gateway.
    '''</summary>
    '''<param name="username">Usuario almacenado en base de datos de Security Gateway</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en base de datos de Security Gateway</param>
    Function Login(ByVal username As String, ByVal password As String, ByRef ErrorMessage As String) As Boolean

    '''<summary>
    '''Función que realiza el proceso de Login Utilizando Interfase Grafica hacia el servidor de Security Gateway.
    '''</summary>    
    Function RSMSLogin(ByRef ErrorMessage As String) As Boolean

    '''<summary>
    '''Función que realiza el proceso de Logout hacia el servidor de Security Gateway.
    '''</summary>
    Function Logout(ByRef ErrorMessage As String) As Boolean
    '''<summary>
    '''Función que se conecta al servidor de Security Gateway y guarda en la memoria los permisos de acceso que tiene el usuario.
    '''Ejecuta las funciones de login, consulta de permisos y logout (opcional). Devuelve True en caso de haber finalizado exitosamente el proceso.
    '''</summary>
    '''<param name="idApp">ID de la aplicación/sistema en la base de datos de Security Gateway</param>
    '''<param name="nameApp">Nombre de la aplicación/sistema en la base de datos de Security Gateway</param>
    '''<param name="username">Usuario almacenado en la base de datos de Security Gateway</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en la base de datos de Security Gateway</param>
    '''<param name="logout">Indica si después de la consulta de permisos al servidor de Security Gateway se hará Logout.</param>
    Overloads Function TraerPermisosAcceso(ByVal idApp As Integer, ByVal nameApp As String, ByVal username As String, ByVal password As String, ByVal logout As Boolean, ByRef errorMessage As String) As Boolean
    '''<summary>
    '''Función que se conecta al servidor de Security Gateway y guarda en la memoria los permisos de acceso que tiene el usuario.
    '''Ejecuta las funciones de login, consulta de permisos y logout (opcional). Devuelve True en caso de haber finalizado exitosamente el proceso.
    '''</summary>
    '''<param name="idApp">ID de la aplicación/sistema en la base de datos de Security Gateway</param>
    '''<param name="nameApp">Nombre de la aplicación/sistema en la base de datos de Security Gateway</param>    
    '''<param name="logout">Indica si después de la consulta de permisos al servidor de Security Gateway se hará Logout.</param>
    Overloads Function TraerPermisosAcceso(ByVal idApp As Integer, ByVal nameApp As String, ByVal logout As Boolean, ByRef errorMessage As String) As Boolean
    '''<summary>
    '''Función que se conecta al servidor de Security Gateway y guarda en la memoria los permisos de acceso que tiene el usuario.
    '''Ejecuta las funciones de login, consulta de permisos y logout (opcional). Devuelve True en caso de haber finalizado exitosamente el proceso.
    '''</summary>
    '''<param name="username">Usuario almacenado en la base de datos de Security Gateway</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en la base de datos de Security Gateway</param>
    '''<param name="logout">Indica si después de la consulta de permisos al servidor de Security Gateway se hará Logout.</param>
    Overloads Function TraerPermisosAcceso(ByVal username As String, ByVal password As String, ByVal logout As Boolean, ByRef errorMessage As String) As Boolean
    '''<summary>
    '''Función que realiza el proceso de cambio de password en el servidor de Security Gateway.
    '''</summary>
    '''<param name="username">Usuario almacenado en base de datos de Security Gateway</param>
    '''<param name="password">Contraseña actual que corresponde al usuario registrado en base de datos de Security Gateway</param>
    '''<param name="newPassword">Nueva contraseña para el usuario registrado en base de datos de Security Gateway</param>
    '''<param name="reTypeNewPassword">Confirmación de la nueva contraseña para el usuario registrado en base de datos de Security Gateway</param>
    ''' 


    Function ChangePassword(ByVal username As String, ByVal password As String, ByVal newPassword As String, ByVal reTypeNewPassword As String, ByRef ErrorMessage As String) As Boolean
    '''<summary>
    '''Función que devuelve True si el usuario tiene permiso de acceso a la función de Security Gateway especificada.
    '''Devuelve False en caso contrario.
    '''</summary>
    '''<param name="codigoAcceso">Código del acceso contenido en la descripción de función de Security Gateway</param>
    Function TienePermisoAcceso(ByVal codigoAcceso As String, ByRef errorMessage As String) As Boolean

    ''' <summary>
    ''' Función que devuelve True si el usuario tiene permiso de acceso a la función de Security Gateway especificada con opcion a guardar auditoria en SG
    ''' </summary>
    ''' <param name="codigoAcceso"> Código del Acceso contenido en la descripcion de SG</param>
    ''' <param name="grabaAuditoria">Verdadero: llama a la función AuditLog de SG</param>
    ''' <param name="muestraMensaje">Verdadero: Muestra un MsgBox si el usuario no tiene permisos</param>
    ''' <param name="errorMessage">Variable de salida con descripcion si algun error ocurriera dentro del procedimiento</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function TienePermisoAcceso(ByVal codigoAcceso As String, ByVal grabaAuditoria As Boolean, ByVal muestraMensaje As Boolean, ByRef errorMessage As String) As Boolean

    '''<summary>
    '''Función que devuelve el listado de permisos de acceso que tiene el usuario en Security Gateway.
    '''</summary>
    Function ListadoTodosPermisosAcceso() As String
    '''<summary>
    '''Función que realiza el proceso de cambio de password en el servidor de Security Gateway.
    '''</summary>
    '''<param name="username">Usuario registrado en base de datos de Security Gateway</param>
    '''<param name="password">Contraseña que corresponde al usuario registrado en base de datos de Security Gateway</param>
    '''<param name="credencialesExternas_username">Username de las credenciales externas devueltas por Security Gateway</param>
    '''<param name="credencialesExternas_password">Password de las credenciales externas devueltas por Security Gateway</param>
    Function obtenerCredencialesExternas(ByVal username As String, ByVal password As String, ByRef credencialesExternas_username As String, ByRef credencialesExternas_password As String, ByRef errorMessage As String) As Boolean
    '''<summary>
    '''Función que realiza el proceso de cambio de password en el servidor de Security Gateway.
    '''</summary>
    '''<param name="credencialesExternas_username">Username de las credenciales externas devueltas por Security Gateway</param>
    '''<param name="credencialesExternas_password">Password de las credenciales externas devueltas por Security Gateway</param>
    Function obtenerCredencialesExternas(ByRef credencialesExternas_username As String, ByRef credencialesExternas_password As String, ByRef errorMessage As String) As Boolean
#End Region

End Interface
