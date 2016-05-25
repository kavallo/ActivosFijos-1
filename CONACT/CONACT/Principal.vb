Imports Citi.Synergia
Imports Citi.Synergia.HelperClient

Public Class Principal
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Citi.Synergia.Locals.Cache.NombreAplicacion = "CONACT"

        LabelEmpresa.Text = Citi.Synergia.Locals.Cache.Empresa

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            '-- Salir
            Me.IconosMenus.Images.Clear()
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
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

    Private Sub MenuActivosPorTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActivosPorTipo.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuActivosPorTipo.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTTACS1
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuActivosPorDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActivosPorDivision.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuActivosPorDivision.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTDIVS0
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
            With ACTMAFS7
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MenuPolizas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPolizas.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.MenuPolizas.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            With ACTSEES2
                .CrearIdioma = Citi.Synergia.Locals.Cache.CrearIdioma
                .Show()
                .Focus()
            End With
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class