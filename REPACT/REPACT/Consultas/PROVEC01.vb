Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class PROVEC01
    Public CodigoProveedor As String = ""

    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonLlenar.Image = Me.IconosMenus.Images(0)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(1)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try

        MyBase.SetearPosiciones()

        Me.LlenarEncab()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarEncab()
        Dim claseProveedor As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        claseProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("*", "** TODOS **"))

        Dim data As DataSet = GetDataSet("Select CODIGO_CLASE_PROVEED, DESCRIPCION_CLASE From CLASE_PROVEEDOR")
        If Not data Is Nothing Then
            If data.Tables.Count > 0 Then
                For Each fila As DataRow In data.Tables(0).Rows
                    claseProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion(fila.Item("CODIGO_CLASE_PROVEED"), fila.Item("DESCRIPCION_CLASE")))
                Next
            End If
        End If

        With cboCODIGO_CLASE_PROVEED
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = claseProveedor
        End With
    End Sub

    Private Sub LlenarParam()
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Proveedor", 10, ALINEAR_DER, "CODIGO_PROVEEDOR", 56, 10, 0, 1, 45)
        MeterParam(2, Info, 1, "Nombre", 40, ALINEAR_IZQ, "nombre_proveedor", 47, 40, 0, 0, 7)

        snCond = "ESTATUS_PROVEEDOR = 'A'"
        If cboCODIGO_CLASE_PROVEED.SelectedValue <> "*" Then
            snCond = snCond & " And CODIGO_CLASE_PROVEED = " & Scm(cboCODIGO_CLASE_PROVEED.SelectedValue)
        End If
        snTabla = "PROVEEDORES"
    End Sub

    Private Sub cboCodigoClaseProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCODIGO_CLASE_PROVEED.SelectedIndexChanged
        Me.LlenarParam()
        MyBase.LlenarSelNav()
    End Sub

    Private Sub SeleccionarProveedor(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Dim filaGrid As DataGridViewRow = GridData.Rows(e.RowIndex)
        Me.CodigoProveedor = filaGrid.Cells(0).Value.ToString()
        Me.Close()
    End Sub

    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub BotonLlenar_Click(sender As System.Object, e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub
End Class