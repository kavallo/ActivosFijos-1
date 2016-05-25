Imports Citi.Synergia.SPCComunes.SPCGlobales
Imports Citi.Synergia.Iconos
Imports Citi.Synergia.HelperClient

Public Class Principal
    Private Sub Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Citi.Synergia.Locals.Cache.NombreAplicacion = "ADMACT"

        LabelEmpresa.Text = Citi.Synergia.Locals.Cache.Empresa

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            '-- Salir
            Me.IconosMenus.Images.Clear()
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cm3Salir.Image = Me.IconosMenus.Images(0)

            Me.MenuProveedores.Visible = Not Citi.Synergia.Locals.Cache.ProveedoresInvisibles
            Me.MenuProveedores.Enabled = Me.MenuProveedores.Visible
            Me._lblDescrip_2.Visible = Me.MenuProveedores.Visible
            Me._lblNombre_2.Visible = Me.MenuProveedores.Visible
            Me.MenuClaseProveedores.Visible = Me.MenuProveedores.Visible
            Me.MenuClaseProveedores.Enabled = Me.MenuProveedores.Visible
            Me._lblDescrip_10.Visible = Me.MenuProveedores.Visible
            Me._lblNombre_10.Visible = Me.MenuProveedores.Visible

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

    Private Sub MenuMarcas_Click(sender As System.Object, e As System.EventArgs) Handles MenuMarcas.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuMarcas.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTMARS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTMARS0.Show()
            ACTMARS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuUbicaciones_Click(sender As System.Object, e As System.EventArgs) Handles MenuUbicaciones.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuUbicaciones.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTUBIS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTUBIS0.Show()
            ACTUBIS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuDivisiones_Click(sender As System.Object, e As System.EventArgs) Handles MenuDivisiones.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuDivisiones.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            DIVISS01.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            DIVISS01.Show()
            DIVISS01.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuTipoDeMovimientos_Click(sender As System.Object, e As System.EventArgs) Handles MenuTipoDeMovimientos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuTipoDeMovimientos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTTMAS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTTMAS0.Show()
            ACTTMAS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuMonedas_Click(sender As System.Object, e As System.EventArgs) Handles MenuMonedas.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuMonedas.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            MONEDS01.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            MONEDS01.Show()
            MONEDS01.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuProveedores_Click(sender As System.Object, e As System.EventArgs) Handles MenuProveedores.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuProveedores.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            PROVES06.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            PROVES06.Show()
            PROVES06.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuTiposDeActivos_Click(sender As System.Object, e As System.EventArgs) Handles MenuTiposDeActivos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuTiposDeActivos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTTACS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTTACS0.Show()
            ACTTACS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuTipoDeServicios_Click(sender As System.Object, e As System.EventArgs) Handles MenuTipoDeServicios.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuTipoDeServicios.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTTSAS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTTSAS0.Show()
            ACTTSAS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuCamposDefinidos_Click(sender As System.Object, e As System.EventArgs) Handles MenuCamposDefinidos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuCamposDefinidos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTCDUS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTCDUS0.Show()
            ACTCDUS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuResponsables_Click(sender As System.Object, e As System.EventArgs) Handles MenuResponsables.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuResponsables.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTRAFS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTRAFS0.Show()
            ACTRAFS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuCategoriaActivos_Click(sender As System.Object, e As System.EventArgs) Handles MenuCategoriaActivos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuCategoriaActivos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTCDAS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTCDAS0.Show()
            ACTCDAS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuClaseProveedores_Click(sender As System.Object, e As System.EventArgs) Handles MenuClaseProveedores.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuClaseProveedores.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTPRV.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTPRV.Show()
            ACTPRV.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuCuentas_Click(sender As System.Object, e As System.EventArgs) Handles MenuCuentas.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuCuentas.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTCUTC.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTCUTC.Show()
            ACTCUTC.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
