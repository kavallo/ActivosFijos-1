Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Sql
Imports Citi.Synergia.SecuritySG
Imports System.Windows.Forms



Public Class Accesos


    Protected Friend ConexionSQL As SqlConnection
    Private Servidor As String
    Private BaseDeDatos As String
    Private Usuario As String
    Private Password As String
    Private SG As SGClienteServidor = Nothing
    Private Companias As DataSet = Nothing
    Private IsUserCancel As Boolean = False
    Private UserActive As String = Nothing

    'Agregado por Mario Mendoza 

    Private _ambienteEquipo As Ambiente
    Private _PathXmlSistemas As String
    Private _dataSistemas As DataSet
    Private _conexionString As String
    Private _ID_Sistema As Integer
    Private _NombreSistema As String
    Private _ParametrosSistema As DataTable
    Private _datosConexion As DatosConexion
    Private _SG_configXML As String
    Private _CodigoSG As String
    Private _usuarioSG As String
    Private _passwordSG_DB As String
    Private _SqlConn As SqlConnection
    '-- Agregado por Hugo Villatoro (Diciembre 2014)
    Private _usuarioSSO As String







    <Obsolete("Constructor Vacio fue dejado por compativilidad con sistemas anteriores, por favor no usar")> _
    Public Sub New()
        SG = New SGClienteServidor()
    End Sub


    Public Sub New(ByVal ID_Sistema As Integer)
        If Not InicializaValores(ID_Sistema) Then
            Throw New Exception("Error en Inicializacion de objeto Accesos, por favor Comuniquese con Tecnología")
        End If
    End Sub



    Public Function login() As Boolean
        Dim mensaje As String = String.Empty
        Try
            SG = New SGClienteServidor(_CodigoSG, Me.Nombre_Sistema, _SG_configXML)

            If SG.RSMSLogin(mensaje) Then

                _usuarioSG = SG.credencialesExternasUsername
                _passwordSG_DB = SG.credencialesExternasPassword
                _usuarioSSO = SG.usernameSecurityGateway


                Dim DialogConn As New frmConexionDialog(GetDataSources())
                If DialogConn.ShowDialog() = DialogResult.OK Then
                    _datosConexion = DialogConn.conexionSeleccinada

                    If Not conectarSQL(_datosConexion.getConectionString(_usuarioSG, _passwordSG_DB)) Then
                        Return False
                    End If
                Else
                    msgError("No se selecciono ninguna Conexión, se cerrará la aplicacion")
                    Return False
                End If

                Return True
            End If

        Catch ex As Exception
            msgError("Login Error: " & ex.Message)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="codigoSG">ID de la aplicación en SG.</param>
    ''' <param name="nombreSistema">Nombre de la aplicación.</param>
    ''' <param name="pathConfigSG">Ubicación del archivo de configuración de Security Gateway.</param>
    ''' <param name="usuarioDB">Variable que contendrá cuál es el usuario del login a base de datos devuelto por Security Gateway.</param>
    ''' <param name="passwordDB">Variable que contendrá cuál es el password del login a base de datos devuelto por Security Gateway.</param>
    ''' <param name="mensaje">Variable que devolverá el mensaje devuelto por Security Gateway.</param>
    ''' <returns>Verdadero si pudo autenticarse.</returns>
    ''' <remarks></remarks>
    Public Function Login(ByVal codigoSG As String, ByVal nombreSistema As String, ByVal pathConfigSG As String, ByRef usuarioDB As String, ByRef passwordDB As String, ByRef mensaje As String) As Boolean
        Try
            SG = New SGClienteServidor(codigoSG, nombreSistema, pathConfigSG)

            If SG.RSMSLogin(mensaje) Then
                usuarioDB = SG.credencialesExternasUsername
                passwordDB = SG.credencialesExternasPassword

                Return True
            End If

        Catch ex As Exception
            msgError("Login Error: " & ex.Message)
            Return False
        End Try
    End Function



#Region "Metodos_Edgar"


    Public Function Login(ByVal appId As Integer, ByVal appName As String) As Boolean
        Me.SG.appId = appId
        Me.SG.appName = appName
        Return Login(appId, appName, Companias)
    End Function


    Public Function Logout() As Boolean
        Dim DescripcionError As String = String.Empty
        If Not (SG Is Nothing) Then
            If (SG.Logout(DescripcionError)) Then
                Return True
            End If
        End If
        MessageBox.Show("Error al Cerrar la sesion." + DescripcionError)
        Return False
    End Function


    Public Function Login(ByVal appId As Integer, ByVal appName As String, ByVal companias As DataSet) As Boolean
        Dim retorno As Boolean = False

        Me.SG.appId = appId
        Me.SG.appName = appName
        Me.Companias = companias

        'Valida la estructura de DataSet para companias
        If Not (companias Is Nothing) Then
            If (companias.Tables.Count > 0) Then
                If (companias.Tables(0).Columns.Contains("ID") And companias.Tables(0).Columns.Contains("SERVIDOR") And companias.Tables(0).Columns.Contains("BASEDATOS") And companias.Tables(0).Columns.Contains("DESCRIPCION")) Then

                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If

        Dim frmLogin As New FLogin
        With frmLogin
            .Companias = Me.Companias
            .SG = Me.SG
            .ShowDialog()
            retorno = .Aceptar
            IsUserCancel = .IsUserCancel
            ConexionSQL = .ConeccionSQL
            UserActive = .TextoUsuario.Text
            .Dispose()
        End With

        If retorno Then
            Dim tmp As New AuthorizationForm()
            With tmp
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

        End If

        Return retorno
    End Function


    Public Function LoginSQL(ByVal servidor As String, ByVal baseDeDatos As String, ByVal usuario As String, ByVal password As String) As Boolean
        Dim retorno As Boolean = False

        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=" + servidor + "; Initial Catalog=" + baseDeDatos + "; uid=" + usuario + "; pwd=" + password

        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                retorno = True
                ConexionSQL = conexion
            End If
        Catch errSQL As SqlClient.SqlException
            Throw errSQL
        Catch ex As Exception
            Throw ex
        End Try

        Return retorno
    End Function

    Public Sub AddCompania(ByVal Servidor As String, ByVal BaseDatos As String, ByVal Descripcion As String)
        Dim index As Integer = 0
        Dim newRow As DataRow

        If Companias Is Nothing Then
            Companias = New DataSet()
            Companias.Tables.Add()
            Companias.Tables(0).Columns.Add("ID")
            Companias.Tables(0).Columns.Add("SERVIDOR")
            Companias.Tables(0).Columns.Add("BASEDATOS")
            Companias.Tables(0).Columns.Add("DESCRIPCION")
        End If

        index = Companias.Tables(0).Rows.Count
        newRow = Companias.Tables(0).NewRow()
        newRow(0) = index.ToString()
        newRow(1) = Servidor
        newRow(2) = BaseDatos
        newRow(3) = Descripcion
        Companias.Tables(0).Rows.Add(newRow)

    End Sub

    Public Sub ClearCompanias()
        Companias = Nothing
    End Sub
    Public Function GetCompanias() As DataSet
        Return Me.Companias
    End Function
    Public Function IsUserCanceled() As Boolean
        Return IsUserCancel
    End Function
    Public Function GetSQLConnection() As SqlClient.SqlConnection
        Return ConexionSQL
    End Function

    Public Function GetUserActive() As String
        Return UserActive
    End Function

    Public Function TienePermiso(ByRef CodigoAcceso As String, ByRef ErrorMessage As String) As Boolean
        Return SG.TienePermisoAcceso(CodigoAcceso, ErrorMessage)
    End Function

#End Region


    'Agregado por Mario Mendoza

#Region "PROPIEDADES"


    Public ReadOnly Property UsuarioSG() As String
        Get
            Return _usuarioSG
        End Get
    End Property

    Public ReadOnly Property PasswordDB_SG() As String
        Get
            Return _passwordSG_DB
        End Get
    End Property

    '-- Agregado por Hugo Villatoro (Diciembre 2014)
    Public ReadOnly Property UsuarioSSO() As String
        Get
            Return Me._usuarioSSO
        End Get
    End Property

    Public Property AmbienteEquipo() As Ambiente
        Get
            Return _ambienteEquipo
        End Get
        Set(ByVal value As Ambiente)
            _ambienteEquipo = value
        End Set
    End Property


    Public ReadOnly Property CodigoSG() As String
        Get
            Return _CodigoSG
        End Get
    End Property

    Public ReadOnly Property Cadena_Conexion() As String
        Get
            Return _datosConexion.getConectionString(_usuarioSG, _passwordSG_DB)
        End Get
    End Property


    Public Property PathXmlSistemas() As String
        Get
            Return _PathXmlSistemas
        End Get
        Set(ByVal value As String)
            _PathXmlSistemas = value
        End Set
    End Property

    Public ReadOnly Property SG_Path_ConfigXML() As String
        Get
            Return _SG_configXML
        End Get
    End Property

    Public Property ID_Sistema() As Integer
        Get
            Return _ID_Sistema
        End Get
        Set(ByVal value As Integer)

            _ID_Sistema = value

            If (From dato In _dataSistemas.Tables("SISTEMAS").Rows _
                      Where dato("ID") = _ID_Sistema).Any Then

                Dim Q = (From dato In _dataSistemas.Tables("SISTEMAS").Rows _
                  Where dato("ID") = _ID_Sistema).First

                _NombreSistema = Q("DESCRIPCION").ToString

            Else
                Throw New Exception("No existe ningun sistema con ID: " + value.ToString)

            End If
        End Set
    End Property

    Public ReadOnly Property Nombre_Sistema() As String
        Get
            Return _NombreSistema
        End Get
    End Property


    Public ReadOnly Property Parametros_Sistema() As DataTable
        Get
            Return _ParametrosSistema
        End Get
    End Property


    Public ReadOnly Property ObjetoSG() As SGClienteServidor
        Get
            Return SG
        End Get
    End Property


#End Region



    Private Function InicializaValores(ByVal id_sistema As Integer) As Boolean
        Try

            PathXmlSistemas = GetPathSistemas()
            If PathXmlSistemas Is Nothing Then Return False
            If Not cargaArchivoXML() Then Return False

            AmbienteEquipo = CType(GetIDAmbiente(), Ambiente)
            gAmbienteLocal = AmbienteEquipo
            If AmbienteEquipo = 0 Then Return False

            If Not getDatosAmbiente(CInt(AmbienteEquipo)) Then Return False

            Me.ID_Sistema = id_sistema
            gNombreSistema = Nombre_Sistema
            gID_Sistema = id_sistema
            If Not getCodigoSG() Then Return False
            gCodigoSG = CodigoSG

            _ParametrosSistema = GetParametros()



            Return True
        Catch ex As Exception
            msgError("InicializaValores: Error Desconocido " + ex.Message)
            Return False

        End Try


    End Function





    Private Function cargaArchivoXML() As Boolean

        If Not IO.File.Exists(PathXmlSistemas) Then

            msgError("Funcion cargaArchivoXML: El archivo " + PathXmlSistemas + "No existe")
            Return False
        End If

        Try

            If _dataSistemas Is Nothing Then _dataSistemas = New DataSet
            _dataSistemas.Clear()
            _dataSistemas.ReadXml(PathXmlSistemas)

        Catch ex As Exception
            msgError("Funcion cargaArchivoXml: " + ex.Message)
            Return False
        End Try

        Return True

    End Function

    Private Function GetIDAmbiente() As String
        Dim idAmbiente As String = String.Empty

        If Not _dataSistemas.Tables.Contains("PARAM_ENTORNO") Then
            msgError("No se ha configurado el ambiente en ConfigSistemas.xml")
            Return Nothing
        End If

        If _dataSistemas.Tables("PARAM_ENTORNO").Rows.Count > 0 Then
            idAmbiente = _dataSistemas.Tables("PARAM_ENTORNO").Rows(0)("AMBIENTE_DEFAULT").ToString
            Return idAmbiente
        Else
            Return Nothing
        End If

    End Function



    Private Function GetDataSources() As DataTable
        Dim dvDataSources As DataView

        Try

            If Not _dataSistemas.Tables.Contains("DATASOURCES") Then
                msgError("No se encontro ninguna configuración de bases de datos en el archivo ConfigSistemas.xml")
                Return Nothing
            End If

            dvDataSources = _dataSistemas.Tables("DATASOURCES").DefaultView
            dvDataSources.RowFilter = "ID_SISTEMA=" & ID_Sistema & " AND ID_AMBIENTE=" & CInt(AmbienteEquipo)

            Return dvDataSources.ToTable

        Catch ex As Exception
            msgError("GetDataSources Error:" + ex.Message)
            Return Nothing
        End Try

    End Function


    Private Function getDatosAmbiente(ByVal id_ambiente As Integer) As Boolean
        Dim dvDataSources As DataView

        Try

            If Not _dataSistemas.Tables.Contains("AMBIENTES") Then
                msgError("No se encontro ninguna configuración de ambientes en el archivo ConfigSistemas.xml")
                Return False
            End If

            dvDataSources = _dataSistemas.Tables("AMBIENTES").DefaultView
            dvDataSources.RowFilter = "ID=" & id_ambiente

            If dvDataSources.Count > 0 Then
                _SG_configXML = dvDataSources.Item(0)("ARCHIVO_CONFIG_SG")
            Else
                Throw New Exception("No se encontro en ConfigSistemas.XML la ruta del archivo Config XML para el ambiente: " + CType(id_ambiente, Ambiente).ToString)
            End If

            Return True

        Catch ex As Exception
            msgError("getDatosAmbiente Error :" + ex.Message)
            Return False
        End Try

    End Function

    Private Function getCodigoSG() As Boolean
        Dim dvDataSources As DataView

        Try

            If Not _dataSistemas.Tables.Contains("CODIGOS_SG") Then
                msgError("No se encontro ninguna configuración de CODIGOS SG en el archivo ConfigSistemas.xml")
                Return False
            End If

            dvDataSources = _dataSistemas.Tables("CODIGOS_SG").DefaultView
            dvDataSources.RowFilter = "ID_AMBIENTE= " & CInt(AmbienteEquipo).ToString & " AND ID_SISTEMA= " & ID_Sistema.ToString

            If dvDataSources.Count > 0 Then
                _CodigoSG = dvDataSources.Item(0)("CODIGO_SG")
            Else
                Throw New Exception("No se encontro en ConfigSistemas.XML el codigo SG para el sistema=: " + Nombre_Sistema + _
                                    " y el ambiente:" + AmbienteEquipo.ToString)
            End If

            Return True

        Catch ex As Exception
            msgError("getCodigoSG Error:" + ex.Message)
            Return False
        End Try

    End Function


    Private Function GetParametros() As DataTable
        Dim dvDataSources As DataView

        Try

            If Not _dataSistemas.Tables.Contains("PARAMETROS") Then
                Return Nothing
            End If

            dvDataSources = _dataSistemas.Tables("PARAMETROS").DefaultView
            dvDataSources.RowFilter = "ID_SISTEMA=" & ID_Sistema

            Return dvDataSources.ToTable

        Catch ex As Exception
            msgError("GetParametros Error:" + ex.Message)
            Return Nothing
        End Try

    End Function





    Private Function GetPathSistemas() As String
        Dim sPathXmlSistemas As String
        Dim browser As OpenFileDialog


        sPathXmlSistemas = Environment.GetEnvironmentVariable("PathXmlSistemas", EnvironmentVariableTarget.Machine)

        If sPathXmlSistemas Is Nothing Then
            MessageBox.Show("Aviso: No se ha definido la ruta del archivo de configuracion de sistemas." + vbCrLf + _
                            "Seleccione el archivo ConfigSistemas.xml de los directorios de su maquina y si no lo tiene comuniquese con Tecnología", "CITI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            browser = New OpenFileDialog
            With browser
                .InitialDirectory = Environment.SystemDirectory
                .Filter = "Archivo de Configuracion XML|*.xml"
                .Multiselect = False

                If .ShowDialog() = DialogResult.OK Then
                    Try
                        Environment.SetEnvironmentVariable("PathXmlSistemas", .FileName.ToString, EnvironmentVariableTarget.Machine)
                        sPathXmlSistemas = Environment.GetEnvironmentVariable("PathXmlSistemas", EnvironmentVariableTarget.Machine)

                        If sPathXmlSistemas Is Nothing Then Throw New Exception("No se pudo asignar valor a la variable de sistema")

                    Catch ex As Exception
                        msgError("Error al Asignar valor a la variable de entorno, contacte a tecnología " + vbCrLf + ex.Message)
                        Return Nothing
                    End Try

                Else
                    msgError("No se selecciono el archivo de configuracion la aplicacion no se ejecutará correctamente")
                    Return Nothing
                End If

            End With
        End If

        Return sPathXmlSistemas



    End Function


    Private Function conectarSQL(ByVal stringConnection As String) As Boolean
        Try
            If _SqlConn Is Nothing Then
                _SqlConn = New SqlConnection
                _SqlConn.ConnectionString = stringConnection
            End If

            If _SqlConn.State <> ConnectionState.Closed Then _SqlConn.Close()

            _SqlConn.Open()

            Return True

        Catch ex As Exception
            msgError("Error al ConectarSQL: " + ex.Message)
            Return False
        Finally
            _SqlConn.Close()
        End Try


    End Function

    Public Function getConexionSQL() As SqlConnection
        If _SqlConn.State = ConnectionState.Closed Then
            _SqlConn.Open()
        End If
        Return _SqlConn

    End Function

    Public Sub CerrarConexion()
        If _SqlConn.State <> ConnectionState.Closed Then
            _SqlConn.Close()
        End If
    End Sub

    Public Function GrabaLogSG(ByVal codigoAcceso As String) As Boolean
        Dim mensaje As String = String.Empty
        If SG.TienePermisoAcceso(codigoAcceso, True, True, mensaje) Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
