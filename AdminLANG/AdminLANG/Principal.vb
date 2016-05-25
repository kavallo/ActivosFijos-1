Imports System.Windows.Forms

Public Class Principal
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LeerConfiguracionSistema() Then
            Dim accesos As New Citi.Synergia.Security.Accesos()

            Try
                If accesos.Login(_companias, Citi.Synergia.Locals.Cache.UtilizarIdiomas, _idiomas) = True Then
                    If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso("0211000") Then
                        If Citi.Synergia.Locals.Cache.TablasDeIdiomaCreadas = False Then
                            Try
                                Dim idioma As New Citi.Synergia.Traductor.Idiomas
                                idioma.CrearTablas()
                            Catch errSQL As SqlClient.SqlException
                                MessageBox.Show(errSQL.Message, errSQL.ToString, MessageBoxButtons.OK)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
                            End Try
                        End If
                    Else
                        MessageBox.Show("Usted no tiene acceso a esta aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Conexión inválida.", "Conexión", MessageBoxButtons.OK)
                    Me.Close()
                End If

            Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Function LeerConfiguracionSistema() As Boolean
        Dim retorno As Boolean = False

        '-- Nombre que se utiliza de aplicativo.
        Citi.Synergia.Locals.Cache.NombreAplicacion = "ADMLANG"

        '-- Leo del archivo sistemas.xml la informacion ahi definida para companias e idiomas.
        _companias = Citi.Synergia.HelperClient.Sistemas.LeerCompanias()
        _idiomas = Citi.Synergia.HelperClient.Sistemas.LeerIdiomas(Citi.Synergia.Locals.Cache.UtilizarIdiomas, Citi.Synergia.Locals.Cache.CrearIdioma)

        '-- Leo applicationID y path del config de SG
        Citi.Synergia.HelperClient.Sistemas.LeerConfigXmlSG(Citi.Synergia.Locals.Cache.ApplicationID, Citi.Synergia.Locals.Cache.PathConfigXmlSG)

        If Citi.Synergia.HelperClient.Sistemas.ErrorEncontrado = Citi.Synergia.HelperClient.Sistemas.ErrHandler.ArchivoXmlNoEncontrado Then
            MessageBox.Show("Archivo de configuración no fue encontrado.")
            retorno = False
        Else
            retorno = True
        End If

        Return retorno
    End Function

    Private Sub BotonAplicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAplicaciones.Click
        Dim frmControles As New FAplicaciones
        With frmControles
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub BotonMensajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonMensajes.Click
        Dim frmMensajes As New FMensajes
        With frmMensajes
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Cerrar()
    End Sub

    Private Sub Cerrar()
        Dim data As New Citi.Synergia.DB.SQL
        data.CerrarConexion(Citi.Synergia.Locals.Cache.ConexionSQL)

        Me.Close()
    End Sub
End Class
