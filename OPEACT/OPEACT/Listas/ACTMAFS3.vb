Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTMAFS3
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuMantoMovimiento.Text = Me.cmdMantoMovimiento.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Bajar nivel
            imagen = oIcono.GetIcon(Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdMantoMovimiento.Image = Me.IconosMenus.Images(0)
            Me.mnuMantoMovimiento.Image = Me.cmdMantoMovimiento.Image
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
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo Activo", 9, ALINEAR_IZQ, "CODIGO_DE_ACTIVO", 47, 4, 0, 1, 92)
        MeterParam(2, Info, 1, "Mejoras", 5, ALINEAR_DER, "MEJORA_CORRELATIVO", 56, 3, 0, 2, 115)
        MeterParam(3, Info, 1, "Descripcion", 30, ALINEAR_IZQ, "DESCRIP_CORTA_ACTIVO", 39, 40, 0, 0, 12)
        MeterParam(4, Info, 1, "Valor Original", 10, ALINEAR_DER, "Convert(Varchar, VALOR_ORIGINAL_ACTIV, 1)", 60, 5, 2, 0, 121)
        MeterParam(5, Info, 1, "Adquisición", 8, ALINEAR_IZQ, "convert(varchar(10), FECHA_ADQUISICION,103)", 47, 5, 0, 0, 223)

        snCond = " Where ACTIVOS_FIJOS.ESTATUS <> 'P'"
        snTabla = "ACTIVOS_FIJOS"
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub MantoMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMantoMovimiento.Click, mnuMantoMovimiento.Click
        If LlenarLlaves() Then
            Dim frmManto As New ACTMVAS0
            With frmManto
                .Pila = Me.Pila
                .Show()
            End With
            Me.LimpiarPila()
        End If
    End Sub
End Class