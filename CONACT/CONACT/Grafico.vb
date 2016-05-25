Imports Citi.Synergia

Public Class Grafico
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '--Tipos
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.TiposGraficas).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '--Copiar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Copiar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Imprimir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Imprimir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.mnuTipos.Image = Me.IconosMenus.Images(0)
            Me.mnuCopiar.Image = Me.IconosMenus.Images(1)
            Me.mnuImprimir.Image = Me.IconosMenus.Images(2)
            Me.mnuSalir.Image = Me.IconosMenus.Images(3)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.ToString, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Tipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTipos.Click

    End Sub

    Private Sub Copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopiar.Click

    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImprimir.Click

    End Sub
End Class