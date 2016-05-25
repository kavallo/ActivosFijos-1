Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTSEAS0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuConsultar.Text = Me.cmdConsulta.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Agregar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Agregar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Modificar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Modificar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdAgregar.Image = Me.IconosMenus.Images(0)
            Me.mnuAgregar.Image = Me.cmdAgregar.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(1)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdModificar.Image = Me.IconosMenus.Images(2)
            Me.mnuModificar.Image = Me.cmdModificar.Image
            Me.cmdConsulta.Image = Me.IconosMenus.Images(3)
            Me.mnuConsultar.Image = Me.cmdConsulta.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(4)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(5)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 5
        NumLlaves = 3
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo Activo", 18, ALINEAR_IZQ, "CODIGO_DE_ACTIVO", 47, 18, 0, 1, 92)
        MeterParam(2, Info, 1, "Mejora", 10, ALINEAR_DER, "MEJORA_CORRELATIVO", 56, 4, 0, 2, 115)
        MeterParam(3, Info, 1, "Servicio", 8, ALINEAR_DER, "NUMERO_SERVICIO", 56, 8, 0, 3, 224)
        MeterParam(4, Info, 1, "Fecha Servicio", 14, ALINEAR_DER, "CONVERT(VARCHAR(10), FECHA_SERVICIO,103)", 47, 10, 0, 0, 225)
        MeterParam(5, Info, 1, "Observaciones", 40, ALINEAR_IZQ, "OBSERVACIONES1", 39, 60, 0, 0, 226)

        snCond = ""
        snTabla = "SERVICIOS_DE_ACTIVOS"
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New ACTSEAM0
            With frmModificar
                .Modo_Local = Modo_Cambio
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    LlenarSelNav()
                End If
                Me.LimpiarPila()
            End With
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New ACTSEAM0

        frmAgregar.Modo_Local = Modo_Alta
        frmAgregar.Push("")
        frmAgregar.Push("")
        frmAgregar.Push("")
        frmAgregar.ShowDialog()
        If frmAgregar.HubieronCambios Then
            MyBase.LlenarSelNav()
        End If
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTSEAM0
            With frmBorrar
                .Modo_Local = Modo_Baja
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                Me.LimpiarPila()
            End With
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click, mnuConsultar.Click
        If LlenarLlaves() Then
            Dim frmConsultar As New ACTSEAM1
            With frmConsultar
                .SoloDeConsulta = True
                .Modo_Local = Modo_Baja
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                Me.LimpiarPila()
            End With
        End If
    End Sub
End Class