Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class ACTMAFS4
    Public Property CodigoTipoActivo As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.BotonConsulta.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '--Consulta
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsulta.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultar.Image = Me.BotonConsulta.Image
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

        Me.LlenarEncabezado()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarEncabezado()
        lblCodigoTipoActivo.Text = CodigoTipoActivo
        lblDescripcionDivision.Text = DescripcionesDB.TipoDeActivo(CodigoTipoActivo)
    End Sub

    Private Sub LlenarParam()
        NumCols = 4
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo", 6, ALINEAR_IZQ, "CODIGO_DE_ACTIVO", 47, 9, 0, 1, 21)
        MeterParam(2, Info, 1, "Mejoras", 7, ALINEAR_DER, "MEJORA_CORRELATIVO", 56, 5, 0, 0, 115)
        MeterParam(3, Info, 1, "Descripcion", 30, ALINEAR_IZQ, "DESCRIP_CORTA_ACTIVO", 39, 20, 0, 0, 12)
        MeterParam(4, Info, 1, "Estado", 6, ALINEAR_IZQ, "ESTATUS", 47, 9, 0, 0, 37)

        snCond = " Where CODIGO_TIPO_ACTIVO = " & Scm(CodigoTipoActivo)
        snTabla = "ACTIVOS_FIJOS"
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each fila As DataGridViewRow In Me._gridDeData.Rows
            valor = fila.Cells(3).Value.ToString
            Select Case valor
                Case "D"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(104, "D - Desechados")
                Case "P"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendientes")
                Case "U"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(102, "U - Actualizados")
                Case "V"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(105, "V - Vendidos")
                Case "N"
                    fila.Cells(3).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(106, "N - Donados")
            End Select
        Next
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim codigoActivo As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim codigoMejora As String = GridData.SelectedRows(0).Cells(1).Value.ToString()
                Dim frmConsulta As New ACTMAFC0
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .CodigoActivo = codigoActivo
                    .CodigoMejora = codigoMejora
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

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsulta.Click, mnuConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
        Me.CambioLista()
    End Sub
End Class