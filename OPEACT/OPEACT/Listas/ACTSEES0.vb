Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTSEES0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuConsultaPartidas.Text = Me.cmdConsultaPartidas.Texto
        Me.mnuEndoso.Text = Me.cmdEndoso.Texto
        Me.mnuCoberturas.Text = Me.cmdCoberturas.Texto
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
            '-- Consulta partida
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ConsultaPartida).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Endoso
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Endoso).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Coberturas
            imagen = oIcono.GetIcon(Iconos.TipoIcono.BajarNivel).ToBitmap
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
            Me.cmdConsultaPartidas.Image = Me.IconosMenus.Images(3)
            Me.mnuConsultaPartidas.Image = Me.cmdConsultaPartidas.Image
            Me.cmdEndoso.Image = Me.IconosMenus.Images(4)
            Me.mnuEndoso.Image = Me.cmdEndoso.Image
            Me.cmdCoberturas.Image = IconosMenus.Images(5)
            Me.mnuCoberturas.Image = Me.cmdCoberturas.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(6)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(7)
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
        NumCols = 4
        NumLlaves = 2
        ReDim Llaves(NumLlaves)

        snBusc = ""
        MeterParam(1, Info, 1, "Numero Poliza", 12, ALINEAR_IZQ, "NUMERO_POLIZA", 39, 10, 0, 2, 138)
        MeterParam(2, Info, 1, "Numero Endoso", 12, ALINEAR_IZQ, "NO_ENDOSO", 39, 5, 0, 1, 139)
        MeterParam(3, Info, 1, "Fin Vigencia", 10, ALINEAR_IZQ, "convert(varchar(10),FECHA_F_VIGENCIA,103)", 47, 5, 0, 0, 140)
        MeterParam(4, Info, 1, "Compañia Seguros", 30, ALINEAR_IZQ, "COMPANIA_SEGUROS", 39, 30, 0, 0, 141)

        snCond = " ESTADO_POLIZA = 'A'"
        snTabla = "SEGUROS_ENC"
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New ACTSEEM0
            With frmModificar
                .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(324, "Mantenimiento de pólizas de seguro - ACTSEEM0")
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

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Push("")
        Push("")
        Dim frmAgregar As New ACTSEEM0
        With frmAgregar
            .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(324, "Mantenimiento de pólizas de seguro - ACTSEEM0")
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
            Dim frmBorrar As New ACTSEEM0
            With frmBorrar
                .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(324, "Mantenimiento de pólizas de seguro - ACTSEEM0")
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

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
    End Sub

    Private Sub ConsultaPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaPartidas.Click, mnuConsultaPartidas.Click
        If LlenarLlaves() Then
            Dim frmConsultar As New ACTSEEM0
            With frmConsultar
                .Modo_Local = Modo_Cambio
                .Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(325, "Consulta de pólizas de seguros - ACTSEEM0")
                .SoloDeConsulta = True
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

    Private Sub Endoso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEndoso.Click, mnuEndoso.Click
        If LlenarLlaves() Then
            Dim frmEndoso As New ACTSEEM1
            With frmEndoso
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

    Private Sub Coberturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCoberturas.Click, mnuCoberturas.Click
        If Me.GridData.Rows.Count > 0 Then
            If Me.GridData.SelectedRows.Count > 0 Then
                Dim filaGrid As DataGridViewRow = Me.GridData.SelectedRows(0)
                Dim frmCobertura As New ACTCPPS0
                With frmCobertura
                    .NumeroPoliza = filaGrid.Cells(0).Value.ToString()
                    .NumeroEndoso = filaGrid.Cells(1).Value.ToString()
                    .ShowDialog()
                    .Dispose()
                End With
                MyBase.LlenarSelNav()
            End If
        End If
    End Sub
End Class