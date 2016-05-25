Imports System.Windows.Forms
Imports Citi.Synergia

Public Class FLogin
    Public Property Companias As List(Of Citi.Synergia.Entidades.Companias)
    Public Property Idiomas As List(Of Citi.Synergia.Entidades.Idiomas)

    Public Property UtilizarIdioma As Boolean
    Public Property Aceptar As Boolean

    Private mostrarBoxes As Boolean = False

    Private Sub FLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim tope As Long = LabelCompania.Top

        If Companias.Count = 0 Then
            Me.ComboCompania.Visible = False
            tope = LabelCompania.Top
        Else
            With ComboCompania
                .ValueMember = "Indice"
                .DisplayMember = "Descripcion"
                .DataSource = Companias
            End With
        End If

        If UtilizarIdioma = False Then
            Me.ComboIdioma.Visible = False
        Else
            If Not Idiomas Is Nothing Then
                If Idiomas.Count > 0 Then
                    With ComboIdioma
                        .ValueMember = "Codigo"
                        .DisplayMember = "Descripcion"
                        .DataSource = Idiomas
                    End With
                End If
            End If
        End If
        Me.LabelCompania.Visible = Me.ComboCompania.Visible
        Me.LabelIdioma.Visible = Me.ComboIdioma.Visible

        Me.LeerUltimoLogin()

        If Me.TextoUsuario.Text <> "" Then
            Me.TextoPassword.TabIndex = 0
            Me.ComboCompania.TabIndex = 1
            Me.ComboIdioma.TabIndex = 2
            Me.PanelBotones.TabIndex = 3
            Me.TextoUsuario.TabIndex = 4
        End If
    End Sub

    Private Sub LeerUltimoLogin()
        Try
            Dim archivoConfiguracion As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ActivosUltimoLogin.Xml"
            If My.Computer.FileSystem.FileExists(archivoConfiguracion) Then
                Dim oXml As New Xml.XmlDocument
                oXml.Load(archivoConfiguracion)

                Me.TextoUsuario.Text = oXml.SelectSingleNode("ROOT").SelectSingleNode("Usuario").InnerText
                If ComboCompania.Visible Then
                    Me.ComboCompania.SelectedValue = CType(oXml.SelectSingleNode("ROOT").SelectSingleNode("IdEmpresa").InnerText, Integer)
                End If
                If ComboIdioma.Visible Then
                    Me.ComboIdioma.SelectedValue = oXml.SelectSingleNode("ROOT").SelectSingleNode("IdIdioma").InnerText
                End If

                oXml = Nothing
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles CmdCancelar.Click
        Aceptar = False
        Me.Close()
    End Sub

    Private Sub CmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles CmdAceptar.Click
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
        Dim empresa As String = String.Empty
        Dim legalEntity As String = String.Empty
        Dim country As String = String.Empty
        Dim batchCode As String = String.Empty
        Dim transactionCodeDebit As String = String.Empty
        Dim transactionCodeCredit As String = String.Empty
        Dim branchCode As String = String.Empty
        Dim branchCodeLength As Integer = 0
        Dim adeComplement As String = String.Empty
        Dim adeComplementLength As Integer = 0

        If ComboCompania.Visible Then
            For Each cia As Citi.Synergia.Entidades.Companias In Companias
                If cia.Indice = ComboCompania.SelectedValue Then
                    servidor = cia.Servidor
                    baseDeDatos = cia.BaseDeDatos
                    empresa = cia.Descripcion
                    legalEntity = cia.LegalEntity
                    country = cia.Country
                    batchCode = cia.BatchCode
                    transactionCodeDebit = cia.TransactionCodeDebit
                    transactionCodeCredit = cia.TransactionCodeCredit
                    branchCode = cia.BranchCode
                    branchCodeLength = cia.BranchCodeLength
                    adeComplement = cia.ADEComplement
                    adeComplementLength = cia.ADEComplementLength
                    Exit For
                End If
            Next
        Else
            servidor = Citi.Synergia.Locals.Cache.Servidor
            baseDeDatos = Citi.Synergia.Locals.Cache.BaseDeDatos
            empresa = Citi.Synergia.Locals.Cache.Empresa
            legalEntity = Citi.Synergia.Locals.Cache.LegalEntity
            country = Citi.Synergia.Locals.Cache.Country
            batchCode = Citi.Synergia.Locals.Cache.BatchCode
            transactionCodeDebit = Citi.Synergia.Locals.Cache.TransactionCodeDebit
            transactionCodeCredit = Citi.Synergia.Locals.Cache.TransactionCodeCredit
            branchCode = Citi.Synergia.Locals.Cache.BranchCode
            branchCodeLength = Citi.Synergia.Locals.Cache.BranchCodeLength
            adeComplement = Citi.Synergia.Locals.Cache.ADEComplement
            adeComplementLength = Citi.Synergia.Locals.Cache.ADEComplementLength
        End If

        Try
            Dim accesos As New Citi.Synergia.Security.Accesos

            Dim pwd As String = TextoPassword.Text
            Dim user As String = TextoUsuario.Text

            If mostrarBoxes Then
                MessageBox.Show("Ingresado por el usuario: user: " & user & "    pwd: " & pwd & " (" & pwd.Length.ToString & ")", "Test", MessageBoxButtons.OK)
            End If

            If Citi.Synergia.HelperClient.UtilsSG.Login(user, pwd) Then
                If mostrarBoxes Then
                    MessageBox.Show("Retorna SG: user: " & user & "    pwd: " & pwd & " (" & pwd.Length.ToString & ")", "Test", MessageBoxButtons.OK)
                End If

                pwd = pwd.Trim
                If pwd.EndsWith("*") Then
                    pwd = pwd.Substring(0, pwd.Length - 1)
                End If

                If mostrarBoxes Then
                    MessageBox.Show("Quitando * user: " & user & "    pwd: " & pwd & " (" & pwd.Length.ToString & ")", "Test", MessageBoxButtons.OK)
                End If

                If accesos.LoginSQL(servidor, baseDeDatos, user, pwd) Then
                    If mostrarBoxes Then
                        MessageBox.Show("user: " & user & "    pwd: " & pwd, "Test", MessageBoxButtons.OK)
                    End If

                    Aceptar = True

                    '-- Para armar conectividad
                    Citi.Synergia.Locals.Cache.Servidor = servidor
                    Citi.Synergia.Locals.Cache.BaseDeDatos = baseDeDatos
                    Citi.Synergia.Locals.Cache.UsuarioSQL = user
                    Citi.Synergia.Locals.Cache.UsuarioSSO = Me.TextoUsuario.Text
                    Citi.Synergia.Locals.Cache.Password = pwd

                    Citi.Synergia.Locals.Cache.IdiomaSeleccionado = ComboIdioma.SelectedValue

                    '-- String de conexion.
                    Citi.Synergia.Locals.Cache.ConexionSTR = "Data Source=" + servidor + "; Initial Catalog=" + baseDeDatos + "; uid=" + user + "; pwd=" + TextoPassword.Text

                    If mostrarBoxes Then
                        MessageBox.Show("STR: " & Citi.Synergia.Locals.Cache.ConexionSTR, "Test", MessageBoxButtons.OK)
                    End If

                    '-- Conexion fisica a SQL.
                    Citi.Synergia.Locals.Cache.ConexionSQL = accesos.ConexionSQL

                    If mostrarBoxes Then
                        MessageBox.Show("ConnSQL: " & accesos.ConexionSQL.ConnectionString, "Test", MessageBoxButtons.OK)
                    End If

                    '-- Marco el idioma que selecciono el usuario
                    accesos.RegistrarIdiomaUsuario(Citi.Synergia.Locals.Cache.IdiomaSeleccionado, Citi.Synergia.Locals.Cache.UsuarioSSO)

                    '-- Para uso de descripciones
                    Citi.Synergia.Locals.Cache.Empresa = empresa
                    Citi.Synergia.Locals.Cache.LegalEntity = legalEntity
                    Citi.Synergia.Locals.Cache.Country = country
                    Citi.Synergia.Locals.Cache.BatchCode = batchCode
                    Citi.Synergia.Locals.Cache.TransactionCodeDebit = transactionCodeDebit
                    Citi.Synergia.Locals.Cache.TransactionCodeCredit = transactionCodeCredit
                    Citi.Synergia.Locals.Cache.BranchCode = branchCode
                    Citi.Synergia.Locals.Cache.BranchCodeLength = branchCodeLength
                    Citi.Synergia.Locals.Cache.ADEComplement = adeComplement
                    Citi.Synergia.Locals.Cache.ADEComplementLength = adeComplementLength

                    '-- Archivo de Xml, contiene empresa/usuario/idioma último Logueado
                    Dim cuerpoXml As String = "<ROOT><IdEmpresa>" & Me.ComboCompania.SelectedValue.ToString & "</IdEmpresa>" & "<Usuario>" & Me.TextoUsuario.Text & "</Usuario>" & "<IdIdioma>" & Me.ComboIdioma.SelectedValue.ToString & "</IdIdioma></ROOT>"
                    Dim strNombreArchivo As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ActivosUltimoLogin.Xml"
                    If My.Computer.FileSystem.FileExists(strNombreArchivo) Then
                        My.Computer.FileSystem.DeleteFile(strNombreArchivo)
                    End If
                    Dim oArchivo As System.IO.StreamWriter
                    oArchivo = My.Computer.FileSystem.OpenTextFileWriter(strNombreArchivo, False)
                    oArchivo.WriteLine(cuerpoXml)
                    oArchivo.Close()

                    Me.Close()
                End If
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class