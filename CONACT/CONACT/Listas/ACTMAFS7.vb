Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class ACTMAFS7
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuBajarNivel.Text = Me.BotonBajarNivel.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Bajar nivel
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonBajarNivel.Image = Me.IconosMenus.Images(0)
            Me.mnuBajarNivel.Image = Me.BotonBajarNivel.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(1)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(2)
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

        MeterParam(1, Info, 1, "Codigo Activo", 9, ALINEAR_IZQ, "CODIGO_DE_ACTIVO", 47, 4, 0, 1, 92)
        MeterParam(2, Info, 1, "Descripcion", 20, ALINEAR_IZQ, "Space(28)", 39, 30, 0, 0, 12)
        MeterParam(3, Info, 1, "Valor Original", 9, ALINEAR_DER, "Convert(Varchar, SUM(VALOR_ORIGINAL_ACTIV), 1)", 60, 4, 2, 0, 121)
        MeterParam(4, Info, 1, "Valor Actual", 9, ALINEAR_DER, "Convert(Varchar, SUM(VALOR_ACTUAL_ACTIVO), 1)", 60, 4, 2, 0, 122)
        MeterParam(5, Info, 1, "Deprec.Acum.", 9, ALINEAR_DER, "Convert(Varchar, SUM(VALOR_DEP_ACUM_ACT), 1)", 60, 4, 2, 0, 123)

        snTabla = "ACTIVOS_FIJOS"
        Group_By = "CODIGO_DE_ACTIVO"
    End Sub

    Private Sub CambioLista()
        Dim nombre, primeraParte As String

        nombre = String.Empty
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                For Each fila As DataGridViewRow In GridData.Rows
                    primeraParte = fila.Cells(0).Value.ToString.Trim
                    nombre = DescripcionesDB.DescripcionCortaActivo(primeraParte, "0")
                    fila.Cells(1).Value = nombre
                Next
            End If
        End If

    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoActivo As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim frmBajarNivel As New ACTMVAS4
                With frmBajarNivel
                    .CodigoActivo = codigoActivo
                    .Show()
                End With
            End If
        End If
    End Sub

    Private Sub CambiarDescripciones(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.CambiarDescripcionesEnGrid
        Me.CambioLista()
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub BotonBajarNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBajarNivel.Click, mnuBajarNivel.Click
        Me.Consultar()
    End Sub

    Private Sub BotonLlenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
        Me.CambioLista()
    End Sub
End Class