Imports Citi.Synergia.SecuritySG
Imports System.Windows.Forms

Friend Class FLogin

    Protected Friend Companias As DataSet
    Protected Friend Aceptar As Boolean
    Protected Friend DefaultServer As String = Nothing
    Protected Friend DefaultDataBase As String = Nothing
    Protected Friend UserDB As String = Nothing
    Protected Friend PasswordDB As String = Nothing
    Protected Friend SG As SGClienteServidor
    Protected Friend ConeccionSQL As SqlClient.SqlConnection
    Public IsUserCancel As Boolean = False

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ValidacionCampos.SetError(TextoUsuario, Nothing)
        ValidacionCampos.SetError(TextoPassword, Nothing)

        If String.IsNullOrEmpty(TextoUsuario.Text.ToString()) Then
            ValidacionCampos.SetError(TextoUsuario, "Required.")
            Return
        End If
        If String.IsNullOrEmpty(TextoPassword.Text.ToString()) Then
            ValidacionCampos.SetError(TextoPassword, "Required.")
            Return
        End If

        Dim servidor As String = String.Empty
        Dim baseDeDatos As String = String.Empty
        If ComboCompania.Visible Then
            For Each row In Companias.Tables(0).Rows
                If (row(0).ToString().Equals(ComboCompania.SelectedValue)) Then
                    servidor = row(1)
                    baseDeDatos = row(2)
                End If
            Next
        Else
            servidor = DefaultServer
            baseDeDatos = DefaultDataBase
        End If

        Try
            'Dim SG As New SGClienteServidor()
            Dim UserDB As String = ""
            Dim PwdDB As String = ""
            Dim SGError As String = ""
            Dim DBError As String = ""

            'SG.TraerPermisosAcceso(TextoUsuario.Text, TextoPassword.Text, False, SGError)
            'If (SG.Login(TextoUsuario.Text, TextoPassword.Text, SGError)) Then
            If SG.TraerPermisosAcceso(TextoUsuario.Text, TextoPassword.Text, False, SGError) Then
                If (SG.obtenerCredencialesExternas(UserDB, PwdDB, DBError)) Then
                    Try
                        Dim accesos As New Accesos
                        If PwdDB.EndsWith("*") Then
                            PasswordDB = PwdDB.Substring(0, PwdDB.Length - 1)
                        Else
                            PasswordDB = PwdDB
                        End If

                        If accesos.LoginSQL(servidor, baseDeDatos, UserDB, PasswordDB) Then
                            DefaultServer = servidor
                            DefaultDataBase = baseDeDatos
                            ConeccionSQL = accesos.ConexionSQL
                            Aceptar = True
                        Else
                            MessageBox.Show("No fue posible obtener la conexion a la Base de Datos.")
                            Aceptar = False
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al obtener la Conexion Activa de Base de Datos.")
                        Aceptar = False
                    End Try
                Else
                    MessageBox.Show("Error al obtener Credenciales Externas de Base De Datos")
                    MessageBox.Show(DBError)
                    Aceptar = False
                End If

            Else
                MessageBox.Show("Usuario y Password incorrecto." + SGError)
                Aceptar = False
            End If

        Catch ex As SqlClient.SqlException
            MessageBox.Show("Error al obtener la informacion del Componente SGGateway")
            Aceptar = False
        End Try

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Aceptar = False
        IsUserCancel = True
        Me.Close()
    End Sub

    Private Sub FLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tope As Long = LabelCompania.Top
        Dim tope1 As Long = UsernameLabel.Top
        Dim tope2 As Long = TextoUsuario.Top
        Dim tope3 As Long = PasswordLabel.Top

        If (Me.SG.appId = -1) Then
            MessageBox.Show("No existe la especificacion para: AppId")
            Me.Close()
        End If

        If (Me.SG.appName Is Nothing) Then
            MessageBox.Show("No existe la especificacion para: AppName")
            Me.Close()
        End If

        If Not (Companias Is Nothing) Then
            If Companias.Tables.Count > 0 Then
                With ComboCompania
                    .DataSource = Companias.Tables(0)
                    .DisplayMember = "DESCRIPCION"
                    .ValueMember = "ID"
                End With
            End If
        Else
            If (Me.DefaultServer Is Nothing) Then
                MessageBox.Show("No existe la especificacion para: DefaultServer")
                Me.Close()
            End If
            If (Me.DefaultDataBase Is Nothing) Then
                MessageBox.Show("No existe la especificacion para: DefaultDataBase")
                Me.Close()
            End If


            Me.ComboCompania.Visible = False
            tope = LabelCompania.Top



            UsernameLabel.Top = LabelCompania.Top
            TextoUsuario.Top = ComboCompania.Top

            PasswordLabel.Top = tope1
            TextoPassword.Top = tope2

            OK.Top = tope3
            Cancel.Top = tope3

            Me.Height = Me.Height - 50
        End If

        Me.LabelCompania.Visible = Me.ComboCompania.Visible

    End Sub
End Class
