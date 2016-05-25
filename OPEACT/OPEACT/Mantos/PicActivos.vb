Imports Citi.Synergia.HelperClient

Public Class PicActivos
    Private grabo As Boolean

    Private _dsFotos As New DataSet
    Private _cantidadImagenes As Integer = 0
    Private _imagenActual As Integer = 0
    Private _cantidad As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LeerPos(Me, "frmPicActivos")
        LeerIco(Me)

        Me._cantidad = Me.lblCantidad.Text

        txtMejora.Text = Pop()
        txtActivo.Text = Pop()

        lblDescripcionActivo.Text = DescripcionesDB.DescripcionCortaActivo(txtActivo.Text, txtMejora.GetValor())

        grabo = True

        '-- Muestro los resultados
        Me.CargarInfo()

        Me.AccesoBotones()
    End Sub

    Private Sub CargarInfo()
        '-- Voy a traer las imágenes que tenga el Activo
        Dim comando As New SqlClient.SqlCommand
        With comando
            .CommandText = "SELECT * FROM ACTIVOS_FIJOS_FOTOS Where CODIGO_DE_ACTIVO = " & Scm(txtActivo.Text) & " And MEJORA_CORRELATIVO = " & sen(txtMejora.GetValor())
        End With

        Try
            Me._dsFotos = GetDataSet(comando)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Not Me._dsFotos Is Nothing Then
            If Me._dsFotos.Tables.Count > 0 Then
                Me._cantidadImagenes = Me._dsFotos.Tables(0).Rows.Count
                If Me._cantidadImagenes > 0 Then
                    Me._imagenActual = 1
                    Me.txtActivo.Text = Me._dsFotos.Tables(0).Rows(0).Item("CODIGO_DE_ACTIVO").ToString
                    Me.txtMejora.Text = Me._dsFotos.Tables(0).Rows(0).Item("MEJORA_CORRELATIVO").ToString
                    Me.MostrarImagen()
                End If
            End If
        End If

        Me.lblCantidad.Text = Me._cantidadImagenes.ToString & Me._cantidad
    End Sub

    Private Sub MostrarImagen()
        Me.picImagen.Image = Nothing

        Try
            Dim imagen() As Byte = Me._dsFotos.Tables(0).Rows(Me._imagenActual - 1).Item("FOTO")
            Dim myStream As IO.MemoryStream = New IO.MemoryStream(imagen, True)

            myStream.Write(imagen, 0, imagen.Length)

            Dim imagenFinal As New Bitmap(myStream)

            Me.picImagen.Image = imagenFinal

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AccesoBotones()
        If Me._cantidadImagenes = 0 Then
            Me.cmdAnterior.Enabled = False
            Me.cmdSiguiente.Enabled = Me.cmdAnterior.Enabled
            Me.cmdEliminar.Enabled = Me.cmdAnterior.Enabled
            Me.cmdGrabar.Enabled = Me.cmdAnterior.Enabled
            Me.cmdReporte.Enabled = Me.cmdAnterior.Enabled
        Else
            Me.cmdAnterior.Enabled = True
            Me.cmdSiguiente.Enabled = Me.cmdAnterior.Enabled
            Me.cmdEliminar.Enabled = Me.cmdAnterior.Enabled
            Me.cmdGrabar.Enabled = Me.cmdAnterior.Enabled
            Me.cmdReporte.Enabled = Me.cmdAnterior.Enabled
        End If

        '-- Anterior
        If Me._imagenActual > 1 Then
            Me.cmdAnterior.Enabled = True
        Else
            Me.cmdAnterior.Enabled = False
        End If

        '-- Siguiente
        If Me._imagenActual >= Me._cantidadImagenes Then
            Me.cmdSiguiente.Enabled = False
        Else
            Me.cmdSiguiente.Enabled = True
        End If
    End Sub

    Private Sub CancelarAgregarImagen()
        Me.MostrarImagen()
        Me.AccesoBotones()
        Me.cmdReporte.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(254, "Reporte")
        Me.txtPathImagen.Text = ""
    End Sub

    Private Sub PathImagen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPathImagen.TextChanged
        If Me.txtPathImagen.Text.Trim.Length > 0 Then
            Me.cmdAgregar.Enabled = True
        Else
            Me.cmdAgregar.Enabled = False
        End If
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        With Me.opnDialog
            .FileName = ""
            .Filter = Citi.Synergia.Traductor.Idiomas.GetMensaje(253, "Archivos de Imágenes") & " (*.jpg,*.bmp,*.tif)|*.jpg;*.bmp;*.tif"
            If .ShowDialog = DialogResult.OK Then
                If .FileName.Trim.Length > 0 Then
                    Me.txtPathImagen.Text = .FileName
                    Me.cmdEliminar.Enabled = False
                    Me.cmdAnterior.Enabled = Me.cmdEliminar.Enabled
                    Me.cmdSiguiente.Enabled = Me.cmdEliminar.Enabled
                    Me.cmdGrabar.Enabled = Me.cmdEliminar.Enabled
                    Me.cmdAgregar.Enabled = Not Me.cmdEliminar.Enabled
                    Me.cmdReporte.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(16, "Cancelar")

                    Me.picImagen.Image = Nothing

                    Dim archivo As IO.FileInfo = New IO.FileInfo(.FileName)

                    If archivo.Length > 300000 Then
                        'El tamaño de la imagen que desea asociar a este activo fijo NO puede ser MAYOR A 200 Kbytes.
                        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(255, "El tamaño de la imagen que desea asociar a este activo fijo NO puede ser MAYOR A 200 Kbytes."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.CancelarAgregarImagen()
                        Return
                    End If

                    Dim imagenFinal As New Bitmap(.FileName)

                    Me.picImagen.Image = imagenFinal
                End If
            End If
        End With
    End Sub

    Private Sub Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnterior.Click
        Me._imagenActual = Me._imagenActual - 1
        If Me._imagenActual = 0 Then
            Me._imagenActual += 1
        End If

        Me.MostrarImagen()
        Me.AccesoBotones()
    End Sub

    Private Sub Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiguiente.Click
        Me._imagenActual += 1
        If Me._imagenActual > Me._cantidadImagenes Then
            Me._imagenActual = Me._imagenActual - 1
        End If

        Me.MostrarImagen()
        Me.AccesoBotones()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(265, "¿Está seguro de eliminar esta fotografía?"), Utils.TipoDeMensaje.TipoConfirmacion) = Utils.TipoDeRespuesta.Aceptar Then
            Me._dsFotos.Tables(0).Rows.RemoveAt(Me._imagenActual - 1)

            Me._cantidadImagenes = Me._cantidadImagenes - 1

            Me.lblCantidad.Text = Me._cantidadImagenes.ToString & Me._cantidad

            Me._imagenActual = Me._cantidadImagenes

            Me.MostrarImagen()
            Me.AccesoBotones()
        End If
    End Sub

    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Dim comando As New SqlClient.SqlCommand

        comando.CommandText = "Delete ACTIVOS_FIJOS_FOTOS Where CODIGO_DE_ACTIVO = " & Scm(txtActivo.Text) & " And MEJORA_CORRELATIVO = " & sen(txtMejora.GetValor())

        Try
            EjecutarComando(comando)

            For Each filaData As DataRow In Me._dsFotos.Tables(0).Rows
                With comando
                    .Parameters.Clear()
                    .CommandText = "Insert Into ACTIVOS_FIJOS_FOTOS (CODIGO_DE_ACTIVO, MEJORA_CORRELATIVO, FOTO) Values (@Codigo, @Mejora, @Foto)"
                    .Parameters.Add("@Codigo", SqlDbType.Char, 15).Value = filaData.Item("CODIGO_DE_ACTIVO").ToString
                    .Parameters.Add("@Mejora", SqlDbType.Int).Value = CType(filaData.Item("MEJORA_CORRELATIVO"), Integer)
                    .Parameters.Add("@Foto", SqlDbType.Image).Value = filaData.Item("FOTO")
                End With
                EjecutarComando(comando)
            Next

            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(315, "Imagen asociada al activo."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        '-- Agrega la foto cargada al dataset
        Try
            Dim archivo As IO.FileInfo = New IO.FileInfo(Me.txtPathImagen.Text)

            Dim fileStream As IO.FileStream = New IO.FileStream(Me.txtPathImagen.Text, IO.FileMode.Open, IO.FileAccess.Read)

            Dim binaryReader As IO.BinaryReader = New IO.BinaryReader(fileStream)

            Dim data As Byte() = binaryReader.ReadBytes(archivo.Length)

            Dim filaData As DataRow = Me._dsFotos.Tables(0).NewRow
            
            filaData.Item("CODIGO_DE_ACTIVO") = Me.txtActivo.Text
            filaData.Item("MEJORA_CORRELATIVO") = Me.txtMejora.GetValor()
            filaData.Item("FOTO") = data

            Me._dsFotos.Tables(0).Rows.Add(filaData)

            Me._cantidadImagenes += 1
            Me.lblCantidad.Text = Me._cantidadImagenes.ToString & Me._cantidad

            Me._imagenActual = Me._cantidadImagenes

            Me.MostrarImagen()
            Me.AccesoBotones()
            Me.cmdReporte.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(254, "Reporte")
            Me.txtPathImagen.Text = ""

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporte.Click
        If cmdReporte.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(16, "Cancelar") Then
            Me.CancelarAgregarImagen()
            Return
        End If

        Try
            Dim filtro As String = String.Empty

            Dim activo As String = String.Empty
            Dim correlativo As String = String.Empty

            activo = txtActivo.Text
            correlativo = txtMejora.GetValor()

            'Citi.Synergia.Reportes.Crystal.Parametros.Clear()
            'With Citi.Synergia.Reportes.Crystal.Parametros
            '    .Add(New Citi.Synergia.Reportes.Campos("_IDIOMA", Scm(Citi.Synergia.Locals.Cache.IdiomaSeleccionado)))
            'End With

            'If Citi.Synergia.Reportes.Crystal.ValidaReporte("assetinfo", True) = False Then
            '    Return
            'End If

            'filtro = "{ACTIVOS_FIJOS.CODIGO_DE_ACTIVO} = " & Scm(txtActivo.Text) & " and {ACTIVOS_FIJOS.MEJORA_CORRELATIVO} = " & sen(txtMejora.GetValor())

            'Citi.Synergia.Reportes.Crystal.EjecutarReporte("assetinfo", filtro)


            filtro = String.Empty
            filtro = "a.CODIGO_DE_ACTIVO = '" + activo + "'"
            filtro = filtro + " And a.MEJORA_CORRELATIVO = " + correlativo

            Dim parametros As New List(Of String)
            With parametros

            End With

            Citi.Synergia.Reports.Reportes.EjecutarReporte(Citi.Synergia.Reports.Reportes.ListadoReportes.assetinfo, parametros, filtro)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub picImagen_DoubleClick(sender As System.Object, e As System.EventArgs) Handles picImagen.DoubleClick
        If Not picImagen.Image Is Nothing Then
            '-- Abrir el archivo
            Try
                Dim imagen() As Byte = Me._dsFotos.Tables(0).Rows(Me._imagenActual - 1).Item("FOTO")

                Dim pathDestino As String = My.Computer.FileSystem.SpecialDirectories.Temp
                If Not pathDestino.EndsWith("\") Then
                    pathDestino += "\"
                End If
                pathDestino += "ImgAF.jpg"

                Dim archivo As IO.FileStream = New IO.FileStream(pathDestino, IO.FileMode.Create, IO.FileAccess.Write)
                archivo.Write(imagen, 0, imagen.Length)
                archivo.Close()

                archivo = Nothing

                System.Diagnostics.Process.Start(pathDestino)

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class