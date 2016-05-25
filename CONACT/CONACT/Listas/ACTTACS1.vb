Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class ACTTACS1
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.BotonConsulta.Texto
        Me.mnuGraficar.Text = Me.BotonGrafica.Texto
        Me.mnuBajarNivel.Text = Me.BotonBajarNivel.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '--Consulta
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '--Graficar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Graficar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Bajar nivel
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsulta.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultar.Image = Me.BotonConsulta.Image
            Me.BotonGrafica.Image = Me.IconosMenus.Images(1)
            Me.mnuGraficar.Image = Me.BotonGrafica.Image
            Me.BotonBajarNivel.Image = Me.IconosMenus.Images(2)
            Me.mnuBajarNivel.Image = Me.BotonBajarNivel.Image
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

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 3
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Tipo de activo", 14, ALINEAR_IZQ, "CODIGO_TIPO_ACTIVO", 47, 2, 0, 1, 33)
        MeterParam(2, Info, 1, "Descripción", 40, ALINEAR_IZQ, "DESCRIP_TIPO_ACTIVO", 47, 7, 0, 0, 12)
        MeterParam(3, Info, 1, "Tipo depreciación", 60, ALINEAR_IZQ, "TIPO_DEPRECIACION", 47, 2, 0, 0, 114)

        snTabla = "TIPOS_DE_ACTIVOS"
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each fila As DataGridViewRow In Me._gridDeData.Rows
            valor = fila.Cells(2).Value.ToString
            Select Case valor
                Case "L"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(51, "L - Línea Recta")
                Case "D"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(50, "D - Doble Saldo Declinante")
                Case "S"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(52, "S - Suma de Años Dígitos")
            End Select
        Next
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoActivo As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim frmConsulta As New ACTTACM1
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .CodigoActivo = codigoActivo
                    .ShowDialog()
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub CambiarDescripciones(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.CambiarDescripcionesEnGrid
        Me.CambioLista()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsulta.Click, mnuConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub Grafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrafica.Click, mnuGraficar.Click
        Dim frmGrafica As New ACTTACG0
        With frmGrafica
            .Show()
        End With
    End Sub

    Private Sub BajarNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBajarNivel.Click, mnuBajarNivel.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigo As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim frmResponsables As New ACTMAFS4
                With frmResponsables
                    .CodigoTipoActivo = codigo
                    .Show()
                End With
            End If
        End If
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
        Me.CambioLista()
    End Sub
End Class