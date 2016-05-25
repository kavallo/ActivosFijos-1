Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class CXPCPIS0
    Public Property CodigoProveedor As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuModificar.Text = Me.cmdModificar.Texto
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
            Me.BotonLlenar.Image = Me.IconosMenus.Images(3)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(4)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        lblCODIGO_PROVEEDOR.Text = Me.CodigoProveedor

        Me.LlenarEncab()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarEncab()
        Try
            meteSQL("select")
            meteSQL(" nombre_proveedor")
            meteSQL(" from PROVEEDORES")
            meteSQL(" where CODIGO_PROVEEDOR = " & Me.CodigoProveedor)

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblnombre_proveedor.Text = SqlData(Sqlconn, 1).ToString
            Loop

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarParam()
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Impuesto", 8, ALINEAR_IZQ, "CXP_PROVEEDOR_IMPTO.CODIGO_IMPUESTO", 47, 10, 0, 1, 212)
        MeterParam(2, Info, 1, "Descripción", 20, ALINEAR_IZQ, "IMPUESTOS.DESCRIPCION_IMPUESTO", 39, 30, 0, 0, 12)

        snCond = " CXP_PROVEEDOR_IMPTO.CODIGO_PROVEEDOR = " & sen(Me.CodigoProveedor) & " and CXP_PROVEEDOR_IMPTO.CODIGO_IMPUESTO  =  IMPUESTOS.CODIGO_IMPUESTO "
        snTabla = " CXP_PROVEEDOR_IMPTO, IMPUESTOS "
    End Sub

    Private Sub Modificar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoImpuesto As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmBorrar As New CXPCPIM0
                With frmBorrar
                    .Modo_Local = Modo_Cambio
                    .CodigoProveedor = Me.CodigoProveedor
                    .CodigoImpuesto = codigoImpuesto
                    .ShowDialog()
                    If .HubieronCambios Then
                        MyBase.LlenarSelNav()
                    End If
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Modificar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New CXPCPIM0
        With frmAgregar
            .Modo_Local = Modo_Alta
            .CodigoProveedor = Me.CodigoProveedor
            .CodigoImpuesto = ""
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoImpuesto As String = GridData.SelectedRows(0).Cells(0).Value.ToString()

                Dim frmBorrar As New CXPCPIM0
                With frmBorrar
                    .Modo_Local = Modo_Baja
                    .SoloDeConsulta = True
                    .CodigoProveedor = Me.CodigoProveedor
                    .CodigoImpuesto = codigoImpuesto
                    .ShowDialog()
                    If .HubieronCambios Then
                        MyBase.LlenarSelNav()
                    End If
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click, mnuModificar.Click
        Me.Modificar()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub
End Class