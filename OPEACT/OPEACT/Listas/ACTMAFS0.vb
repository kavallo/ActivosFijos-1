Imports Citi.Synergia
Imports Citi.Synergia.Iconos
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient
Imports System.Windows.Forms

Public Class ACTMAFS0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuMejorar.Text = Me.cmdMejorar.Texto
        Me.mnuInfoGeneral.Text = Me.cmdInfoGeneral.Texto
        Me.mnuConsultar.Text = Me.cmdConsultar.Texto
        Me.mnuConsultaPartida.Text = Me.cmdConsultaPartida.Texto
        Me.mnuTraslado.Text = Me.cmdTraslado.Texto
        Me.mnuAsociarImagen.Text = Me.cmdAsociarImagen.Texto
        Me.mnuReporteFicha.Text = Me.cmdReporteFicha.Texto
        Me.mnuReporteGeneral.Text = Me.cmdReporteGeneral.Texto
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
            '-- Mejorar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Mejorar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Info. General
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Editar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consultar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consultar Partida
            imagen = oIcono.GetIcon(Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Traslado
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Traslado).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Asociar Imagen
            imagen = oIcono.GetIcon(Iconos.TipoIcono.AsociarImagen).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte Ficha
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ReporteFicha).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte General
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ReporteGeneral).ToBitmap
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
            Me.cmdMejorar.Image = Me.IconosMenus.Images(3)
            Me.mnuMejorar.Image = Me.cmdMejorar.Image
            Me.cmdInfoGeneral.Image = Me.IconosMenus.Images(4)
            Me.mnuInfoGeneral.Image = Me.cmdInfoGeneral.Image
            Me.cmdConsultar.Image = Me.IconosMenus.Images(5)
            Me.mnuConsultar.Image = Me.cmdConsultar.Image
            Me.cmdConsultaPartida.Image = Me.IconosMenus.Images(6)
            Me.mnuConsultaPartida.Image = Me.cmdConsultaPartida.Image
            Me.cmdTraslado.Image = Me.IconosMenus.Images(7)
            Me.mnuTraslado.Image = Me.cmdTraslado.Image
            Me.cmdAsociarImagen.Image = Me.IconosMenus.Images(8)
            Me.mnuAsociarImagen.Image = Me.cmdAsociarImagen.Image
            Me.cmdReporteFicha.Image = Me.IconosMenus.Images(9)
            Me.mnuReporteFicha.Image = Me.cmdReporteFicha.Image
            Me.cmdReporteGeneral.Image = Me.IconosMenus.Images(10)
            Me.mnuReporteGeneral.Image = Me.cmdReporteGeneral.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(11)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(12)
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
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo", 5, ALINEAR_IZQ, "CODIGO_DE_ACTIVO", 47, 15, 0, 1, 21)
        MeterParam(2, Info, 1, "Correlativo", 6, ALINEAR_DER, "MEJORA_CORRELATIVO", 56, 4, 0, 2, 93)
        MeterParam(3, Info, 1, "Descripción", 30, ALINEAR_IZQ, "DESCRIP_CORTA_ACTIVO", 39, 40, 0, 0, 12)
        MeterParam(4, Info, 1, "Estado", 8, ALINEAR_IZQ, "ESTATUS", 47, 1, 0, 0, 37)
        MeterParam(5, Info, 1, "Faltante", 6, ALINEAR_IZQ, "DESAPARECIDO", 47, 1, 0, 0, 222)

        snTabla = "ACTIVOS_FIJOS"
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each fila As DataGridViewRow In GridData.Rows
            valor = fila.Cells(3).Value.ToString
            Select Case valor
                Case "D"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(104, "D - Desechado").Replace("D - ", "")
                Case "P"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente").Replace("P - ", "")
                Case "U"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(102, "U - Actualizado").Replace("U - ", "")
                Case "V"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(105, "V - Vendido").Replace("V - ", "")
                Case "N"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(106, "N - Donado").Replace("N - ", "")
            End Select

            valor = fila.Cells(4).Value.ToString
            Select Case valor
                Case "S"
                    fila.Cells(4).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(85, "Si").Replace("1 - ", "")

                Case Else
                    fila.Cells(4).Value = " "
            End Select
        Next
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New ACTMAFM0
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

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New ACTMAFM0
        With frmAgregar
            .Modo_Local = Modo_Alta
            .Push("")
            .Push("")
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTMAFM0
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

    Private Sub Modificar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
        Me.CambioLista()
    End Sub

    Private Sub Mejorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMejorar.Click, mnuMejorar.Click
        If LlenarLlaves() Then
            Dim frmMejoras As New ACTMAFM1
            With frmMejoras
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

    Private Sub InfoGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoGeneral.Click, mnuInfoGeneral.Click
        If LlenarLlaves() Then
            Dim frmInfoGral As New ACTAFGM0
            With frmInfoGral
                .Modo_Local = Modo_Alta
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

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click, mnuConsultar.Click
        If LlenarLlaves() Then
            Dim frmConsultar As New ACTMAFC0
            With frmConsultar
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

    Private Sub ConsultaPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaPartida.Click, mnuConsultaPartida.Click
        If LlenarLlaves() Then
            Dim frmConsultar As New PATRES03
            With frmConsultar
                .DocumentoOrigen = "CA"
                .Origen6 = String.Empty
                .Origen5 = String.Empty
                .Origen4 = String.Empty
                .TipoMovimiento = String.Empty
                .Pila = Me.Pila
                .Show()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Traslado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTraslado.Click, mnuTraslado.Click
        If LlenarLlaves() Then
            Dim frmTraslado As New ACTMAFN4
            With frmTraslado
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

    Private Sub ReporteFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporteFicha.Click, mnuReporteFicha.Click
        Dim frmReporteFicha As New ACTRESN0
        With frmReporteFicha
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ReporteGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporteGeneral.Click, mnuReporteGeneral.Click

        ReporteInformacionGeneralActivo()

        'verificando si selecciono un activo 
        'If GridData.SelectedRows.Count > 0 Then
        '    Dim mensaje As String = String.Empty
        '
        '    If (Citi.Synergia.Locals.Cache.IdiomaSeleccionado = "SP") Then
        '        mensaje = "Desea generar reporte de información detallada para el activo fijo seleccionado?"
        '    Else
        '        mensaje = "Would you like to print detailed information for selected fixed asset?"
        '    End If
        '
        '    If Citi.Synergia.HelperClient.Utils.CITIMsgBox(mensaje, Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoConfirmacion) = Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Aceptar Then
        '        Try
        '            If LlenarLlaves() Then
        '                Dim filtro As String = String.Empty
        '                Dim parametros As New List(Of String)
        '
        '                With parametros
        '                    '.Add(DescripcionesDB.TraeUsuario())
        '                    .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
        '                End With
        '
        '                filtro = "a.CODIGO_DE_ACTIVO = '" + Me.Pila.Item(0) + "' AND a.MEJORA_CORRELATIVO = " + Me.Pila.Item(1)
        '                Me.Pila.Clear()
        '
        '                Citi.Synergia.Reports.Reportes.EjecutarReporte(Reports.Reportes.ListadoReportes.Informacion_general_activo_fijo, parametros, filtro)
        '            End If
        '
        '        Catch errSQL As SqlClient.SqlException
        '            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try
        '    Else
        '        ReporteInformacionGeneralActivo()
        '    End If
        'Else
        '    ReporteInformacionGeneralActivo()
        'End If


    End Sub

    Private Sub AsociarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsociarImagen.Click, mnuAsociarImagen.Click
        If LlenarLlaves() Then
            Dim frmImagenes As New PicActivos
            With frmImagenes
                .Pila = Me.Pila
                .ShowDialog()
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub ReporteInformacionGeneralActivo()
        Try
            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_USUARIO", Scm(DescripcionesDB.TraeUsuario())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_EMPRESA", Scm(DescripcionesDB.TraeEmpresa())))
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("Informacion_general_Activos_Fijos", True) = False Then
            '    Return
            'End If

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("Informacion_general_Activos_Fijos", , Citi.Synergia.Traductor.Idiomas.GetMensaje(318, "Información General de Activos Fijos"))


            Dim parametros As New List(Of String)
            With parametros
                '.Add(DescripcionesDB.TraeUsuario())
                .Add(Citi.Synergia.Locals.Cache.UsuarioSSO)
            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Reports.Reportes.ListadoReportes.Informacion_general_Activos_Fijos, parametros)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

