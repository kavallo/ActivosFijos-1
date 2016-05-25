Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTETAS0
    Private _primerLlenado As Boolean = False

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuAutorizar.Text = Me.cmdAutorizar.Texto
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
            '-- Autorizar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Autoriza).ToBitmap
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
            Me.cmdAutorizar.Image = Me.IconosMenus.Images(3)
            Me.mnuAutorizar.Image = Me.cmdAutorizar.Image
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
        Me._infoLista.Clear()

        Me.GridColumnas.Columns.Clear()
        Me.GridData.Columns.Clear()

        NumCols = 6
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Traslado", 5, ALINEAR_DER, "A.TRASLADO_ID_ACT", 56, 5, 0, 1, 228)
        MeterParam(2, Info, 1, "Responsable", 10, ALINEAR_IZQ, "A.RESPONSABLE_ID", 47, 5, 0, 0, 32)
        MeterParam(3, Info, 1, "Nombre", 10, ALINEAR_IZQ, "B.NOMBRE_USUAL", 39, 7, 0, 0, 7)
        MeterParam(4, Info, 1, "Estado", 8, ALINEAR_IZQ, "A.ESTADO_TRASLADO_ACT", 47, 2, 0, 0, 37)
        MeterParam(5, Info, 1, "Nuevo responsable", 15, ALINEAR_IZQ, "A.NUEVO_RESPONSABLE", 47, 5, 0, 0, 229)
        MeterParam(6, Info, 1, "Nombre", 10, ALINEAR_IZQ, "C.NOMBRE_USUAL", 39, 7, 0, 0, 7)

        snCond = " Where A.RESPONSABLE_ID = B.RESPONSABLE_ID"
        snCond = snCond & " and A.NUEVO_RESPONSABLE = C.RESPONSABLE_ID"
        snTabla = "ACT_RESPONSABLES B,ACT_RESPONSABLES C, ACT_TRASLADO_ENC A"
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each filaGrid As DataGridViewRow In Me.GridData.Rows
            valor = filaGrid.Cells(3).Value.ToString
            Select Case valor
                Case "P"
                    filaGrid.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "Pendiente").Replace("P - ", "")
                Case Else
                    filaGrid.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(179, "Autorizado").Replace("A - ", "")
            End Select
        Next
    End Sub

    Private Sub Modificar()
        If Me.GridData.Rows.Count > 0 Then
            If Me.GridData.SelectedRows.Count > 0 Then
                Dim idTraslado As String = Me.GridData.SelectedRows(0).Cells(0).Value.ToString

                Dim estado As String = String.Empty
                If Not String.IsNullOrEmpty(TraeDato("Select ESTADO_TRASLADO_ACT From ACT_TRASLADO_ENC Where TRASLADO_ID_ACT = " & idTraslado)) Then
                    estado = TraeDato("Select ESTADO_TRASLADO_ACT From ACT_TRASLADO_ENC Where TRASLADO_ID_ACT = " & idTraslado).ToString

                    If estado = "P" Then
                        Push(idTraslado)

                        Dim frmModificar As New ACTETAM0
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
                    Else
                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(248, "No se puede modificar el traslado porque ya está autorizado."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
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
        Push("")
        Dim frmAgregar As New ACTETAM0
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

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If Me.GridData.Rows.Count > 0 Then
            If Me.GridData.SelectedRows.Count > 0 Then
                Dim idTraslado As String = Me.GridData.SelectedRows(0).Cells(0).Value.ToString

                Dim estado As String = String.Empty
                If Not String.IsNullOrEmpty(TraeDato("Select ESTADO_TRASLADO_ACT From ACT_TRASLADO_ENC Where TRASLADO_ID_ACT = " & idTraslado)) Then
                    estado = TraeDato("Select ESTADO_TRASLADO_ACT From ACT_TRASLADO_ENC Where TRASLADO_ID_ACT = " & idTraslado).ToString

                    If estado = "P" Then
                        Push(idTraslado)

                        Dim frmBorrar As New ACTETAM0
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
                    Else
                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(247, "No puede borrar el traslado porque ya esta autorizado."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub Autorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizar.Click, mnuAutorizar.Click
        If Me.GridData.Rows.Count > 0 Then
            If Me.GridData.SelectedRows.Count > 0 Then
                Dim tieneAcceso As Boolean = False
                Try
                    If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdAutorizar.Tag.ToString) Then
                        tieneAcceso = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

                If tieneAcceso Then
                    Dim idTraslado As String = Me.GridData.SelectedRows(0).Cells(0).Value.ToString

                    Dim estado As String = String.Empty
                    If Not String.IsNullOrEmpty(TraeDato("Select ESTADO_TRASLADO_ACT From ACT_TRASLADO_ENC Where TRASLADO_ID_ACT = " & idTraslado)) Then
                        estado = TraeDato("Select ESTADO_TRASLADO_ACT From ACT_TRASLADO_ENC Where TRASLADO_ID_ACT = " & idTraslado).ToString

                        If estado = "P" Then
                            Push(idTraslado)

                            Dim frmAutorizar As New ACTETAM1
                            With frmAutorizar
                                .Modo_Local = Modo_Baja
                                .Pila = Me.Pila
                                .ShowDialog()
                                If .HubieronCambios Then
                                    MyBase.LlenarSelNav()
                                End If
                                .Dispose()
                            End With

                            Me.LimpiarPila()
                        Else
                            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(249, "No puede autorizar el traslado porque ya esta autorizado."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub Todos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optTodos.CheckedChanged
        If Me.optTodos.Checked Then
            Me.cmdAutorizar.Enabled = False

            Me.LlenarParam()

            snCond = " Where A.RESPONSABLE_ID = B.RESPONSABLE_ID"
            snCond = snCond & " and A.NUEVO_RESPONSABLE = C.RESPONSABLE_ID"

            If Me._primerLlenado Then
                MyBase.LlenarSelNav()
            End If

            Me._primerLlenado = True
        Else
            Me.cmdAutorizar.Enabled = True
        End If
        Me.mnuAutorizar.Enabled = Me.cmdAutorizar.Enabled
    End Sub

    Private Sub Pendientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPendientes.CheckedChanged
        If Me.optPendientes.Checked Then
            Me.LlenarParam()

            snCond = " Where A.RESPONSABLE_ID = B.RESPONSABLE_ID"
            snCond = snCond & " and A.NUEVO_RESPONSABLE = C.RESPONSABLE_ID"
            snCond = snCond & " And A.USUARIO_DPA <> '" & Citi.Synergia.Locals.Cache.UsuarioSSO & "'"  '--SUSER_SNAME()"

            If Me._primerLlenado Then
                MyBase.LlenarSelNav()
            End If
        End If
    End Sub
End Class