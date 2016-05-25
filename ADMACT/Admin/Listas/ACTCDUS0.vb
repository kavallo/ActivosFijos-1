Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class ACTCDUS0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
        Me.mnuListaValores.Text = Me.BotonListaValores.Texto
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
            '-- Lista Valores
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.ListaValores).ToBitmap
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
            Me.BotonListaValores.Image = Me.IconosMenus.Images(3)
            Me.mnuListaValores.Image = Me.BotonListaValores.Image
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
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Campo", 5, ALINEAR_IZQ, "ACT_CAMPO.CAMPO_ID", 47, 3, 0, 1, 29)
        MeterParam(2, Info, 1, "Descripción", 20, ALINEAR_IZQ, "ACT_CAMPO.CAMPO_NOMBRE", 39, 20, 0, 0, 12)
        MeterParam(3, Info, 1, "Descripción Tipo Activo", 30, ALINEAR_IZQ, "TIPOS_DE_ACTIVOS.DESCRIP_TIPO_ACTIVO", 39, 20, 0, 0, 30)

        'snCampos = CrearParam(Info, Me)
        snTabla = " ACT_CAMPO LEFT OUTER JOIN TIPOS_DE_ACTIVOS ON ACT_CAMPO.CODIGO_TIPO_ACTIVO = TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO "
    End Sub

    Private Sub Modificar()
        If LlenarLlaves() Then
            Dim frmModificar As New ACTCDUM0
            With frmModificar
                .Modo_Local = Modo_Cambio
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
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
        Dim frmAgregar As New ACTCDUM0
        With frmAgregar
            .Modo_Local = Modo_Alta
            .Push("")
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
        End With
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTCDUM0
            With frmBorrar
                .Modo_Local = Modo_Baja
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub BotonLlenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub BotonListaValores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonListaValores.Click, mnuListaValores.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigo As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim listaValores As String = String.Empty
                If Not String.IsNullOrEmpty(TraeDato("Select CAMPO_LISTA_VALORES from ACT_CAMPO where CAMPO_ID = " + Scm(codigo))) Then
                    listaValores = TraeDato("Select CAMPO_LISTA_VALORES from ACT_CAMPO where CAMPO_ID = " + Scm(codigo)).ToString().Trim()
                End If
                If listaValores = "S" Then
                    Dim frmResponsables As New ACTVCDS0
                    With frmResponsables
                        .CampoID = codigo
                        .ShowDialog()
                        .Dispose()
                    End With
                    MyBase.LlenarSelNav()
                Else
                    MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(215, "Debe seleccionar un campo definido con lista de valores."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class