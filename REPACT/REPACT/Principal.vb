Imports Citi.Synergia.SPCComunes.SPCGlobales
Imports Citi.Synergia.HelperClient
Imports Citi.Synergia.Iconos

Public Class Principal
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Citi.Synergia.Locals.Cache.NombreAplicacion = "REPACT"

        LabelEmpresa.Text = Citi.Synergia.Locals.Cache.Empresa

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            '-- Salir
            Me.IconosMenus.Images.Clear()
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cm3Salir.Image = Me.IconosMenus.Images(0)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cm3Salir.Click
        Dim data As New Citi.Synergia.DB.SQL
        data.CerrarConexion(Citi.Synergia.Locals.Cache.ConexionSQL)

        Me.Close()
    End Sub

    Private Sub MenuCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCatalogo.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuCatalogo.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMAFN3
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuReporteGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReporteGeneral.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuReporteGeneral.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMAFN6
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuInformacionGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuInformacionGeneral.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuInformacionGeneral.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMAFN2
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMovimientos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuMovimientos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMVAN4
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuDepreciaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepreciaciones.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuDepreciaciones.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMVAN3
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuTomaFisica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTomaFisica.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuTomaFisica.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMAFN5
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuProyeccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProyeccion.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuProyeccion.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMVAN5
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuTotalmenteDepreciados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTotalmenteDepreciados.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuTotalmenteDepreciados.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMVAN6
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuTipoActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTipoActivos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuTipoActivos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMVAN7
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuDepreciados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepreciados.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuDepreciados.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTMVAN8
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuAddDispFull_Click(sender As System.Object, e As System.EventArgs) Handles MenuAddDispFull.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuAddDispFull.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With AddDispFull
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuExportAllFields_Click(sender As System.Object, e As System.EventArgs) Handles MenuExportAllFields.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuExportAllFields.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ExportAllFields
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class