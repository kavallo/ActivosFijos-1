Imports System.Xml


Class ProcesosSG
#Region "Atributos"
    Private _appId As Integer
    Private _appName As String = String.Empty
    Private _pathConfigXml As String = String.Empty
    Private _usuario As String = String.Empty
    Private _password As String = String.Empty
    Private _descripcionesFuncs As String = String.Empty
    Private _codigosFuncs As String = String.Empty
    Private _sgInterface As SGInterface
    Public objRes As Respuesta
    '-- Agregado por Hugo Villatoro (Diciembre 2014)
    Private _usuarioSSO As String = String.Empty
#End Region

#Region "Propiedades"




#End Region



#Region "Métodos"
    'Constructor de la clase
    ''' <summary>
    ''' Constructor de la Clase SecurityGateway_Procesos
    ''' </summary>
    ''' <param name="appId">System Id #</param>
    ''' <param name="appName">Application Name </param>
    ''' <param name="pathConfigXml">Path del archivo config.xml utilizado por Security Gateway</param>
    Sub New(ByVal appId As Integer, ByVal appName As String, ByVal pathConfigXml As String, ByRef sgInterface As SGInterface)
        _appId = appId
        _appName = appName
        _pathConfigXml = pathConfigXml
        _sgInterface = sgInterface
    End Sub

    ''' <summary>
    ''' Función que realiza proceso de login para un usuario y contraseña especificado por el usuario
    ''' y que dependiendo de la respuesta de SG, se obtiene una clase con la información detallada.
    ''' </summary>
    ''' <param name="user">SSO user</param>
    ''' <param name="password">SSO password</param>
    ''' <returns></returns>
    Public Function login(ByVal user As String, ByVal password As String) As Respuesta
        Dim Mensaje As String = String.Empty
        objRes = New Respuesta()
        Dim returnValue As Integer = -1
        'Realizar proceso de autenticación en base a parámetros xml y entradas de usuario
        returnValue = _sgInterface.noGuiLogin(_appId, _appName, _pathConfigXml, user, password, Mensaje)


        If (returnValue = 1) Then
            '-- Agregado por Hugo Villatoro (Diciembre 2014)
            _usuarioSSO = user

            objRes.finalizadoExitosamente = True
            objRes.mensajeDevuelto = String.Empty
            Dim separator As Integer = 0
            separator = Mensaje.IndexOf("|", 0)
            _usuario = Mensaje.Substring(0, separator)
            _password = Mensaje.Substring(separator + 1, Mensaje.Length - separator - 1)

            If _password.EndsWith("*") Then
                _password = _password.Substring(0, _password.Trim.Length - 1)
            End If


            Dim accFuncs As Integer = _sgInterface.noGuiAccFunctions(_descripcionesFuncs)
            If (accFuncs <> 1) Then
                Mensaje = _descripcionesFuncs
            End If
            Dim accCodFuncs As Integer = _sgInterface.noGuiAccModFuncIds(_codigosFuncs)
            If (accCodFuncs <> 1) Then
                Mensaje = _codigosFuncs
            End If
            'objRes.asignaValoresLogin(_usuario, _password, _descripcionesFuncs, _codigosFuncs, Mensaje, returnValue, accFuncs, accCodFuncs)
            objRes.asignaValoresLogin(_usuarioSSO, _usuario, _password, _descripcionesFuncs, _codigosFuncs, Mensaje, returnValue, accFuncs, accCodFuncs)
            _descripcionesFuncs = ""
            _codigosFuncs = ""
        Else
            objRes.finalizadoExitosamente = False
            objRes.mensajeDevuelto = Mensaje
            objRes.fnLogin = returnValue
        End If
        Return objRes
    End Function


    Public Function RSMSlogin() As Respuesta
        Dim Mensaje As String = String.Empty
        objRes = New Respuesta()
        Dim returnValue As Integer = -1
        'Realizar proceso de autenticación en base a parámetros xml y entradas de usuario
        returnValue = _sgInterface.RsmsLogin(_appId, _appName, _pathConfigXml, Mensaje)
        If (returnValue = 1) Then
            objRes.finalizadoExitosamente = True
            objRes.mensajeDevuelto = String.Empty
            Dim separator As Integer = 0
            separator = Mensaje.IndexOf("|", 0)
            _usuario = Mensaje.Substring(0, separator)
            _password = Mensaje.Substring(separator + 1, Mensaje.Length - separator - 1)

            If _password.EndsWith("*") Then
                _password = _password.Substring(0, _password.Trim.Length - 1)
            End If


            Dim accFuncs As Integer = _sgInterface.noGuiAccFunctions(_descripcionesFuncs)
            If (accFuncs <> 1) Then
                Mensaje = _descripcionesFuncs
            End If
            Dim accCodFuncs As Integer = _sgInterface.noGuiAccModFuncIds(_codigosFuncs)
            If (accCodFuncs <> 1) Then
                Mensaje = _codigosFuncs
            End If
            objRes.asignaValoresLogin(_usuario, _password, _descripcionesFuncs, _codigosFuncs, Mensaje, returnValue, accFuncs, accCodFuncs)
            _descripcionesFuncs = ""
            _codigosFuncs = ""
        Else
            objRes.finalizadoExitosamente = False
            objRes.mensajeDevuelto = Mensaje
            objRes.fnLogin = returnValue
        End If
        Return objRes
    End Function


    Public Function logout() As Respuesta
        Dim resultado As Integer = -2
        Dim mensajeResultado As String = String.Empty
        objRes = New Respuesta()
        resultado = _sgInterface.noGuiLogout(mensajeResultado)
        objRes.fnLogout = resultado
        objRes.finalizadoExitosamente = (resultado = 1)
        If objRes.finalizadoExitosamente Then
            mensajeResultado = String.Empty
        End If
        objRes.mensajeDevuelto = mensajeResultado
        Return objRes
    End Function

    Public Function changePassword(ByVal login As String, ByVal password As String, ByVal newPassword As String, ByVal reTypeNewPassword As String) As Respuesta
        Dim Mensaje As String = String.Empty
        objRes = New Respuesta()
        Dim changePass As Integer = -2
        changePass = _sgInterface.noGuiChangePass(_appId, _appName, _pathConfigXml, login, password, newPassword, reTypeNewPassword, Mensaje)
        If (changePass <> 1) Then
            objRes.asignaValoresChangePass(login, password, Mensaje, changePass, False)
        Else
            objRes.asignaValoresChangePass(login, newPassword, Mensaje, changePass, True)
        End If
        Return objRes
    End Function

    Public Function getExternalCredentials() As Respuesta
        'Instance the SGLibrary
        Dim response As String = String.Empty
        Dim returnValue As Integer = _sgInterface.noGuiAccExtUserCred(response)
        objRes = New Respuesta()
        objRes.asignaValoresCredencialesExternas(response, returnValue)
        Return objRes
    End Function


    Public Function auditLog(ByVal SystemID As Short, ByVal ModuloID As Short, ByVal FunctionID As Short, ByVal auditText As String, ByVal dataText As String) As Respuesta
        Dim Mensaje As String = String.Empty
        objRes = New Respuesta()

        Dim retunValue As Integer = _sgInterface.noGuiAuditLog(SystemID, ModuloID, FunctionID, auditText, dataText, Mensaje)

        If retunValue <> 1 Then
            objRes.finalizadoExitosamente = False
            objRes.mensajeDevuelto = Mensaje
        Else
            objRes.finalizadoExitosamente = True
            objRes.mensajeDevuelto = String.Empty
        End If

        Return objRes

    End Function


#End Region
End Class

