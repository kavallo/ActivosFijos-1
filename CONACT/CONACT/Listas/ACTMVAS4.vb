Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class ACTMVAS4
    Public Property CodigoActivo As String

    Private _controlPan As String = String.Empty
    Private _unaVez As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuMovimientos.Text = Me.BotonConsultaMovimientos.Texto
        Me.mnuActivosFijos.Text = Me.BotonConsultaActivos.Texto
        Me.mnuPartida.Text = Me.BotonConsultaPartida.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consulta movimientos
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.ConsultaMovimientos).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta activos
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta partidas contables
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.ConsultaPartida).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsultaMovimientos.Image = Me.IconosMenus.Images(0)
            Me.mnuMovimientos.Image = Me.BotonConsultaMovimientos.Image
            Me.BotonConsultaActivos.Image = Me.IconosMenus.Images(1)
            Me.mnuActivosFijos.Image = Me.BotonConsultaActivos.Image
            Me.BotonConsultaPartida.Image = Me.IconosMenus.Images(2)
            Me.mnuPartida.Image = Me.BotonConsultaPartida.Image
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

        Me._controlPan = "N"
        Me._unaVez = "S"

        lblCodigoActivo.Text = CodigoActivo

        Me.LlenarEncab()

        lblNombreActivo.Text = DescripcionesDB.DescripcionCortaActivo(CodigoActivo, cboMejora.SelectedValue.ToString)
    End Sub

    Private Sub LlenarParam()
        NumCols = 5
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        Dim lista As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(61, "Alta").Replace("A - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(62, "Desecho").Replace("D - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("G", Citi.Synergia.Traductor.Idiomas.GetMensaje(68, "Rev. masiva").Replace("G - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(63, "Depreciación").Replace("P - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("I", Citi.Synergia.Traductor.Idiomas.GetMensaje(66, "Ajuste Inc.").Replace("I - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(67, "Ajuste Dis.").Replace("M - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(69, "Donación").Replace("N - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("R", Citi.Synergia.Traductor.Idiomas.GetMensaje(64, "Revaluación").Replace("R - ", "")))
        lista.Add(New Citi.Synergia.Entidades.CodigoDescripcion("V", Citi.Synergia.Traductor.Idiomas.GetMensaje(65, "Venta").Replace("V - ", "")))

        MeterParam(1, Info, 1, "Tipo", 4, ALINEAR_DER, "MOVIM_ACTIVOS.TIPO_MOVIMIENTO", 56, 4, 0, 0, 14)
        MeterParam(2, Info, 1, "Descripción", 12, ALINEAR_IZQ, "CLASE_MOVIMIENTO", 56, 12, 0, 0, 12, lista)
        MeterParam(3, Info, 1, "Correlativo", 11, ALINEAR_DER, "MOVIM_ACTIVOS.CORRELATIVO_MOVIM", 56, 11, 0, 1, 93)
        MeterParam(4, Info, 1, "Fecha Movimiento", 16, ALINEAR_IZQ, "convert(varchar(12),MOVIM_ACTIVOS.FECHA_MOVIMIENTO,103)", 47, 16, 0, 0, 124)
        MeterParam(5, Info, 1, "Monto", 13, ALINEAR_DER, "Convert(Varchar, MOVIM_ACTIVOS.MONTO_DE_MOVIMIENTO, 1)", 60, 13, 2, 0, 127)

        snTabla = "MOVIM_ACTIVOS, TIPO_MOV_ACTIVOS"
        snCond = " MOVIM_ACTIVOS.CODIGO_DE_ACTIVO = " & Scm(CodigoActivo) & " and MOVIM_ACTIVOS.MEJORA_CORRELATIVO = " & sen(cboMejora.SelectedValue.ToString)
        snCond = snCond & " and MOVIM_ACTIVOS.TIPO_MOVIMIENTO = TIPO_MOV_ACTIVOS.TIPO_MOVIMIENTO "
        Order_By = " MOVIM_ACTIVOS.FECHA_MOVIMIENTO"
    End Sub

    Private Sub LlenarEncab()
        Try
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "Select MEJORA_CORRELATIVO From ACTIVOS_FIJOS Where CODIGO_DE_ACTIVO = " & Scm(CodigoActivo)
            End With

            Me._dsData = GetDataSet(comando)

            With cboMejora
                .ValueMember = "MEJORA_CORRELATIVO"
                .DisplayMember = "MEJORA_CORRELATIVO"
                .DataSource = Me._dsData.Tables(0)
            End With

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub LlenarDescripciones()
        Dim contador As Integer = 0
        For Each infolista As Citi.Synergia.Entidades.InfoLista In _infoLista
            If Not infolista.ListaValores Is Nothing Then
                For Each filaGrid As DataGridViewRow In GridData.Rows
                    If Not filaGrid.Cells(contador).Value Is Nothing Then
                        Dim valorGrid As String = filaGrid.Cells(contador).Value.ToString()

                        For Each valorLista As Citi.Synergia.Entidades.CodigoDescripcion In infolista.ListaValores
                            If valorLista.Codigo = valorGrid Then
                                filaGrid.Cells(contador).Value = valorLista.Descripcion
                            End If
                        Next
                    End If
                Next
            End If
            contador += 1
        Next
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim tipoMovimiento As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim correlativoMovimiento As String = GridData.SelectedRows(0).Cells(2).Value.ToString()
                Dim frmConsulta As New ACTMVAM1
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .CodigoActivo = Me.CodigoActivo
                    .MejoraCorrelativo = Me.lblCodigoMejora.Text
                    .TipoMovimiento = tipoMovimiento
                    .CorrelativoMovimiento = correlativoMovimiento
                    .Show()
                End With
            End If
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
        Me.LlenarDescripciones()
    End Sub

    Private Sub ComboMejora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMejora.SelectedIndexChanged
        lblCodigoMejora.Text = ""
        If Not String.IsNullOrEmpty(Me.cboMejora.SelectedValue) Then
            lblCodigoMejora.Text = Me.cboMejora.SelectedValue.ToString
        End If

        _infoLista.Clear()
        Me.LlenarParam()

        MyBase.LlenarSelNav()

        Me.LlenarDescripciones()
    End Sub

    Private Sub ConsultaMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultaMovimientos.Click, mnuMovimientos.Click
        Me.Consultar()
    End Sub

    Private Sub ConsultaActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultaActivos.Click, mnuActivosFijos.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim frmConsulta As New ACTMAFC0
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .CodigoActivo = Me.CodigoActivo
                    .CodigoMejora = Me.lblCodigoMejora.Text
                    .ShowDialog()
                    .Dispose()
                End With
            End If
        End If
    End Sub

    Private Sub ConsultaPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultaPartida.Click, mnuPartida.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Dim tipoMovimiento As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                Dim correlativoMovimiento As String = GridData.SelectedRows(0).Cells(2).Value.ToString()

                Dim frmConsulta As New PATRES03
                With frmConsulta
                    .CodigoActivo = Me.CodigoActivo
                    .MejoraCorrelativo = Me.lblCodigoMejora.Text
                    .TipoMovimiento = tipoMovimiento
                    .Origen4 = String.Empty
                    .Origen5 = String.Empty
                    .Origen6 = String.Empty

                    Dim claseMovimiento As String = ""

                    Try
                        meteSQL("SELECT CLASE_MOVIMIENTO")
                        meteSQL("  FROM TIPO_MOV_ACTIVOS")
                        meteSQL(" WHERE TIPO_MOVIMIENTO = " & tipoMovimiento)

                        EjecutaSQL("")

                        ' Obtenemos el resultado de SQL
                        Do While SqlNextRow(Sqlconn) = MOREROWS
                            claseMovimiento = SqlData(Sqlconn, 1)
                        Loop

                    Catch errSQL As SqlClient.SqlException
                        MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    Dim documentoOrigen As String = ""
                    Select Case claseMovimiento
                        Case "R"
                            documentoOrigen = "RA"
                        Case "D"
                            documentoOrigen = "DA"
                        Case "N"
                            documentoOrigen = "NA"
                        Case "A"
                            documentoOrigen = "CA"
                        Case "I"
                            documentoOrigen = "IA"
                        Case "M"
                            documentoOrigen = "MA"
                        Case "V"
                            documentoOrigen = "VA"
                        Case "P"
                            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(175, "La partida por depreciación se visualiza en Depreciaciones."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Case "G"
                            Dim codigoRevaluacion As String = String.Empty

                            Try
                                meteSQL("SELECT CODIGO_REVALUACION")
                                meteSQL("  FROM MOVIM_ACTIVOS")
                                meteSQL(" WHERE CODIGO_DE_ACTIVO = " & Scm(Me.CodigoActivo))
                                meteSQL("   AND MEJORA_CORRELATIVO = " & sen(lblCodigoMejora.Text))
                                meteSQL("   AND TIPO_MOVIMIENTO = " & sen(tipoMovimiento))
                                meteSQL("   AND CORRELATIVO_MOVIM = " & sen(correlativoMovimiento))

                                EjecutaSQL("")

                                ' Obtenemos el resultado de SQL
                                Do While SqlNextRow(Sqlconn) = MOREROWS
                                    codigoRevaluacion = SqlData(Sqlconn, 1).ToString
                                Loop

                            Catch errSQL As SqlClient.SqlException
                                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try

                            .CodigoActivo = codigoRevaluacion
                            .MejoraCorrelativo = ""
                            .TipoMovimiento = ""
                            documentoOrigen = "RM"
                    End Select

                    .DocumentoOrigen = documentoOrigen
                    .Show()
                End With
            End If
        End If
    End Sub
End Class