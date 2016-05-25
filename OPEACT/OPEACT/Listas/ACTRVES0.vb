Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTRVES0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuDetalleActivoRevaluar.Text = Me.cmdDetalleActivoRevaluar.Texto
        Me.mnuConsultaRevaluacion.Text = Me.cmdConsultaRevaluacion.Texto
        Me.mnuConsultaActivoRevaluar.Text = Me.cmdConsultaActivoRevaluar.Texto
        Me.mnuConsultaPartidaContable.Text = Me.cmdConsultaPartidaContable.Texto
        Me.mnuProceso.Text = Me.cmdProceso.Texto
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
            '-- Detalle Activo
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Tabla).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta Revaluacion
            imagen = oIcono.GetIcon(Iconos.TipoIcono.InfoGeneral).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta Activo Revaluar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.TablaVer).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta Partida Contable
            imagen = oIcono.GetIcon(Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Proceso
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Proceso).ToBitmap
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
            Me.cmdDetalleActivoRevaluar.Image = Me.IconosMenus.Images(3)
            Me.mnuDetalleActivoRevaluar.Image = Me.cmdDetalleActivoRevaluar.Image
            Me.cmdConsultaRevaluacion.Image = Me.IconosMenus.Images(4)
            Me.mnuConsultaRevaluacion.Image = Me.cmdConsultaRevaluacion.Image
            Me.cmdConsultaActivoRevaluar.Image = Me.IconosMenus.Images(5)
            Me.mnuConsultaActivoRevaluar.Image = Me.cmdConsultaActivoRevaluar.Image
            Me.cmdConsultaPartidaContable.Image = Me.IconosMenus.Images(6)
            Me.mnuConsultaPartidaContable.Image = Me.cmdConsultaPartidaContable.Image
            Me.cmdProceso.Image = Me.IconosMenus.Images(7)
            Me.mnuProceso.Image = Me.cmdProceso.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(8)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(9)
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
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo", 6, ALINEAR_DER, "CODIGO_REVALUACION", 52, 3, 0, 1, 21)
        MeterParam(2, Info, 1, "Descripcion", 20, ALINEAR_IZQ, "DESC_REVALUACION", 39, 10, 0, 0, 12)
        MeterParam(3, Info, 1, "Fecha Revaluación", 15, ALINEAR_IZQ, "convert(varchar(10), FECHA_DE_REVALUACION,103)", 47, 2, 0, 0, 135)
        MeterParam(4, Info, 1, "Tipo", 6, ALINEAR_IZQ, "TIPO_DE_REVALUACION", 47, 7, 0, 0, 14)
        MeterParam(5, Info, 1, "Estado", 6, ALINEAR_IZQ, "ESTADO_REVALUACION", 47, 3, 0, 0, 37)

        snTabla = "REVALUACION_ENC"
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each fila As DataGridViewRow In Me.GridData.Rows
            valor = fila.Cells(3).Value.ToString
            Select Case valor
                Case "D"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(231, "D - División")
                Case "T"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(230, "T - Tipo de Activo")
            End Select

            valor = fila.Cells(4).Value.ToString
            Select Case valor
                Case "P"
                    fila.Cells(4).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente")
                Case "A"
                    fila.Cells(4).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(179, "A - Autorizada")
            End Select
        Next
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New ACTRVEM0
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

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
        Me.CambioLista()
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New ACTRVEM0
        Push("")
        With frmAgregar
            .Modo_Local = Modo_Alta
            .Pila = Me.Pila
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
        Me.LimpiarPila()
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTRVEM0
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

    Private Sub DetalleActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalleActivoRevaluar.Click, mnuDetalleActivoRevaluar.Click
        If LlenarLlaves() Then
            Dim codigo As String = Pop()

            If Not String.IsNullOrEmpty(TraeDato("select ESTADO_REVALUACION from REVALUACION_ENC where CODIGO_REVALUACION = " & sen(codigo))) Then
                If TraeDato("select ESTADO_REVALUACION from REVALUACION_ENC where CODIGO_REVALUACION = " & sen(codigo).ToString) = "P" Then
                    Push(codigo)
                    Dim frmDetalleActivo As New ACTMAFM2
                    With frmDetalleActivo
                        .Pila = Me.Pila
                        .ShowDialog()
                        .Dispose()
                    End With
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(232, "No puede trabajar revaluaciones ya autorizadas."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub ConsultaRevaluacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaRevaluacion.Click, mnuConsultaRevaluacion.Click
        If LlenarLlaves() Then
            Dim frmConsulta As New ACTRVEM1
            With frmConsulta
                .SoloDeConsulta = True
                .Pila = Me.Pila
                .ShowDialog()
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub ConsultaActivoRevaluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaActivoRevaluar.Click, mnuConsultaActivoRevaluar.Click
        If LlenarLlaves() Then
            Dim frmConsultaActivo As New ACTMAFM2
            With frmConsultaActivo
                .Pila = Me.Pila
                .ShowDialog()
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub ConsultaPartidaContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaPartidaContable.Click, mnuConsultaPartidaContable.Click
        If LlenarLlaves() Then
            Dim frmPartida As New PATRES03
            With frmPartida
                .DocumentoOrigen = "RM"
                .Origen6 = String.Empty
                .Origen5 = String.Empty
                .Origen4 = String.Empty
                .TipoMovimiento = String.Empty
                .MejoraCorrelativo = "SYN_null"
                .Pila = Me.Pila
                .Show()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Proceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProceso.Click, mnuProceso.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                If GridData.SelectedRows.Count > 0 Then
                    Dim mensaje As String = String.Empty

                    mensaje = Citi.Synergia.Traductor.Idiomas.GetMensaje(321, "Este proceso realiza la revaluación de Activos Fijos, la cual generará un Movimiento")
                    mensaje += " "
                    mensaje += Citi.Synergia.Traductor.Idiomas.GetMensaje(322, "para cada Activo Fijo y luego generará una partida contable por tipo de Activo.")

                    If Citi.Synergia.HelperClient.Utils.CITIMsgBox(mensaje, Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoConfirmacion) = Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Aceptar Then
                        For Each filaGrid As DataGridViewRow In GridData.SelectedRows
                            Dim codigo As String = filaGrid.Cells(0).Value.ToString

                            Dim comando As New SqlClient.SqlCommand
                            With comando
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "sp_Revaluacion_Activos_Fijos"
                                .Parameters.Add("@CODIGO_REVALUACION", SqlDbType.Int).Value = codigo
                                .Parameters(0).Direction = ParameterDirection.Input
                            End With

                            Dim parametro As SqlClient.SqlParameter
                            parametro = New SqlClient.SqlParameter
                            With parametro
                                .ParameterName = "@CODIGO_REVALUACION"
                                .Direction = ParameterDirection.Input
                                .SqlDbType = SqlDbType.Int
                                .Value = codigo
                            End With
                            Try
                                EjecutarComando(comando)

                            Catch errSQL As SqlClient.SqlException
                                MessageBox.Show(errSQL.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Next

                        MyBase.LlenarSelNav()
                    End If
                End If
            End If
        End If
    End Sub
End Class