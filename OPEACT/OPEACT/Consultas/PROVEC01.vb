Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class PROVEC01
    Public Property CodigoProveedor As String

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

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        Me.BotonDeLlenado = Me.BotonLlenar

        Me.LlenarEncab()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 2
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Proveedor", 10, ALINEAR_DER, "PROVEEDORES.CODIGO_PROVEEDOR", 56, 10, 0, 1)
        MeterParam(2, Info, 1, "Nombre", 40, ALINEAR_IZQ, "PROVEEDORES.nombre_proveedor", 47, 40, 0, 0)

        snCond = "PROVEEDORES.ESTATUS_PROVEEDOR = 'A'"
        If cboCODIGO_CLASE_PROVEED.SelectedValue <> "*" Then
            snCond = snCond & " And PROVEEDORES.CODIGO_CLASE_PROVEED = " & Scm(cboCODIGO_CLASE_PROVEED.SelectedValue)
        End If
        snTabla = "PROVEEDORES"
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

    Private Sub cboCODIGO_CLASE_PROVEED_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCODIGO_CLASE_PROVEED.SelectedIndexChanged
        Me._infoLista.Clear()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub SeleccionarProveedor(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Dim filaGrid As DataGridViewRow = GridData.Rows(e.RowIndex)
        CodigoProveedor = filaGrid.Cells(0).Value.ToString()
        Me.Close()
    End Sub

    Private Sub Llenar_Click(sender As System.Object, e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub
End Class