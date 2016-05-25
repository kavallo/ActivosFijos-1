Imports Citi.Synergia
Imports Citi.Synergia.Iconos
Imports Citi.Synergia.HelperClient

Public Class Principal
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Citi.Synergia.Locals.Cache.NombreAplicacion = "OPEACT"

        LabelEmpresa.Text = Citi.Synergia.Locals.Cache.Empresa

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            '-- Salir
            Me.IconosMenus.Images.Clear()
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cm3Salir.Image = Me.IconosMenus.Images(0)

            '-- Hago Update de Tipos de Activos
            meteSQL("Update TIPOS_DE_ACTIVOS")
            meteSQL("   Set FORZAR_FECHA_ACTIVO  = " & Citi.Synergia.Locals.Cache.DiaInicioProcesoDepreciacion)
            meteSQL(" Where CALCULO_PRIMERA_DEPR = 'M'")
            EjecutaSQL("")

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cm3Salir.Click
        Me.Close()
    End Sub

    Private Sub MenuIngresoDeActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuIngresoDeActivos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuIngresoDeActivos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTMAFS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTMAFS0.Show()
            ACTMAFS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuActualizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActualizacion.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuActualizacion.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTMAFS1.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTMAFS1.Show()
            ACTMAFS1.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuAnulacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAnulacion.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuAnulacion.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTMAFS2.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTMAFS2.Show()
            ACTMAFS2.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuServiciosActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuServiciosActivos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuServiciosActivos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTSEAS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTSEAS0.Show()
            ACTSEAS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuOperaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOperaciones.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuOperaciones.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTMAFS3.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTMAFS3.Show()
            ACTMAFS3.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuRevaluaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRevaluaciones.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuRevaluaciones.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTRVES0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTRVES0.Show()
            ACTRVES0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuCalculoDepreciacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCalculoDepreciacion.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuCalculoDepreciacion.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            Dim frmParametros As New ACTMVAN0
            If frmParametros.ShowDialog() = DialogResult.OK Then
                Dim mes As Integer = frmParametros.Mes
                Dim anio As Integer = frmParametros.Anio

                Dim frmCalculo As New ACTMVAS1
                With frmCalculo
                    .Mes = mes
                    .Anio = anio
                    .Show()
                End With
            End If
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuSeguros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSeguros.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuSeguros.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTSEES0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTSEES0.Show()
            ACTSEES0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuCategoriaActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCategoriaActivos.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuCategoriaActivos.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTETAS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTETAS0.Show()
            ACTETAS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuUbicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUbicaciones.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuUbicaciones.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            ACTTOMS0.CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
            ACTTOMS0.Show()
            ACTTOMS0.Focus()
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class