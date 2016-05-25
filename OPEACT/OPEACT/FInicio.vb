Public Class FInicio
    Private Function LeerConfiguracionSistema() As Boolean
        Dim retorno As Boolean = False

        '-- Nombre que se utiliza de aplicativo.
        Citi.Synergia.Locals.Cache.NombreAplicacion = "OPEACT"

        '-- Leo del archivo sistemas.xml la informacion ahi definida para companias e idiomas.
        _companias = Citi.Synergia.HelperClient.Sistemas.LeerCompanias()
        _idiomas = Citi.Synergia.HelperClient.Sistemas.LeerIdiomas(Citi.Synergia.Locals.Cache.UtilizarIdiomas, Citi.Synergia.Locals.Cache.CrearIdioma)

        Citi.Synergia.Locals.Cache.NumeroRegistrosEnGrid = Citi.Synergia.HelperClient.Sistemas.LeerNumeroRegistrosEnGrid()

        Citi.Synergia.Locals.Cache.DiaInicioProcesoDepreciacion = Citi.Synergia.HelperClient.Sistemas.LeerDiaInicioProcesoDepreciacion()

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

    Private Sub FInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LeerConfiguracionSistema() Then
            Dim accesos As New Citi.Synergia.Security.Accesos()

            If accesos.Login(_companias, Citi.Synergia.Locals.Cache.UtilizarIdiomas, _idiomas) = True Then

                Dim frmPrincipal As New Principal
                frmPrincipal.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma

                frmPrincipal.Show()
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class