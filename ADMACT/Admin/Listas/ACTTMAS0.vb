Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class ACTTMAS0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuReporte.Text = Me.BotonReporte.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Agregar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Agregar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Modificar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Modificar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Reporte).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdAgregar.Image = Me.IconosMenus.Images(0)
            Me.mnuAgregar.Image = Me.cmdAgregar.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(1)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdModificar.Image = Me.IconosMenus.Images(2)
            Me.mnuModificar.Image = Me.cmdModificar.Image
            Me.BotonReporte.Image = Me.IconosMenus.Images(3)
            Me.mnuReporte.Image = Me.BotonReporte.Image
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
        NumCols = 3
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Tipo", 4, ALINEAR_DER, "TIPO_MOVIMIENTO", 56, 5, 0, 1, 14)
        MeterParam(2, Info, 1, "Descripcion", 30, ALINEAR_IZQ, "DESCRIPCION_TIP_MOV", 39, 30, 0, 0, 12)
        MeterParam(3, Info, 1, "Clase", 7, ALINEAR_IZQ, "CLASE_MOVIMIENTO", 47, 5, 0, 0, 34)

        'snCampos = CrearParam(Info, Me)
        snTabla = "TIPO_MOV_ACTIVOS"
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each fila As DataGridViewRow In Me.GridData.Rows
            valor = fila.Cells(2).Value.ToString
            Select Case valor
                Case "A"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(61, "A - Alta")
                Case "D"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(62, "D - Desecho")
                Case "P"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(63, "P - Depreciación")
                Case "R"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(64, "R - Revaluación")
                Case "I"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(213, "I - Incremento Valor Activo")
                Case "M"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(214, "M - Disminución Valor Activo")
                Case "V"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(65, "V - Venta")
                Case "G"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(68, "G - Revaluación Masiva")
                Case "N"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(69, "N - Donación")
            End Select
        Next
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New ACTTMAM0
            With frmModificar
                .Modo_Local = Modo_Cambio
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub CambiarDescripciones(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.CambiarDescripcionesEnGrid
        Me.CambioLista()
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New ACTTMAM0
        With frmAgregar
            .Modo_Local = Modo_Alta
            .Push("")
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTTMAM0
            With frmBorrar
                .Modo_Local = Modo_Baja
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub BotonLlenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
        Me.CambioLista()
    End Sub

    Private Sub BotonReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReporte.Click, mnuReporte.Click
        Try
            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Movimiento_Activos", True) = False Then
            '    Return
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Movimiento_Activos", , Citi.Synergia.Traductor.Idiomas.GetMensaje(272, "Movimiento de activos"))

            Dim parametros As New List(Of String)
            With parametros
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Reports.Reportes.ListadoReportes.Movimiento_Activos, parametros)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class