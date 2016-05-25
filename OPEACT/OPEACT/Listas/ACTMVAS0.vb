Imports Citi.Synergia
Imports Citi.Synergia.Iconos
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class ACTMVAS0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuAgregar.Text = Me.cmdAgregar.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuConsultaMovimiento.Text = Me.cmdConsultaMovimiento.Texto
        Me.mnuConsultaActivo.Text = Me.cmdConsultaActivo.Texto
        Me.mnuConsultaPartida.Text = Me.cmdConsultaPartida.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Agregar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Agregar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta Movimientos
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ConsultaMovimientos).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consultar Activo
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consultar Partida
            imagen = oIcono.GetIcon(Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdAgregar.Image = Me.IconosMenus.Images(0)
            Me.mnuAgregar.Image = Me.cmdAgregar.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(1)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdConsultaMovimiento.Image = Me.IconosMenus.Images(2)
            Me.mnuConsultaMovimiento.Image = Me.cmdConsultaMovimiento.Image
            Me.cmdConsultaActivo.Image = Me.IconosMenus.Images(3)
            Me.mnuConsultaActivo.Image = Me.cmdConsultaActivo.Image
            Me.cmdConsultaPartida.Image = Me.IconosMenus.Images(4)
            Me.mnuConsultaPartida.Image = Me.cmdConsultaPartida.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(5)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(6)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        lblMEJORA_CORRELATIVO.Text = Pop()
        lblCODIGO_DE_ACTIVO.Text = Pop()

        lblnombreactivo.Text = DescripcionesDB.DescripcionCortaActivo(lblCODIGO_DE_ACTIVO.Text, lblMEJORA_CORRELATIVO.Text)

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 5
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Tipo", 4, ALINEAR_DER, "MOVIM_ACTIVOS.TIPO_MOVIMIENTO", 56, 4, 0, 2, 14)
        MeterParam(2, Info, 1, "Correlativo", 6, ALINEAR_DER, "MOVIM_ACTIVOS.CORRELATIVO_MOVIM", 56, 7, 0, 1, 93)
        MeterParam(3, Info, 1, "Descripción", 15, ALINEAR_IZQ, "CLASE_MOVIMIENTO", 56, 8, 0, 0, 12)
        MeterParam(4, Info, 1, "Fecha Movimiento", 12, ALINEAR_IZQ, "convert(varchar(12),MOVIM_ACTIVOS.FECHA_MOVIMIENTO,103)", 47, 8, 0, 0, 124)
        MeterParam(5, Info, 1, "Monto", 8, ALINEAR_DER, "Convert(Varchar, MOVIM_ACTIVOS.MONTO_DE_MOVIMIENTO, 1)", 60, 10, 2, 0, 127)

        snTabla = "MOVIM_ACTIVOS, TIPO_MOV_ACTIVOS"
        snCond = "MOVIM_ACTIVOS.CODIGO_DE_ACTIVO = " & Scm(lblCODIGO_DE_ACTIVO.Text) & " and MOVIM_ACTIVOS.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text)
        snCond = snCond & " and MOVIM_ACTIVOS.TIPO_MOVIMIENTO = TIPO_MOV_ACTIVOS.TIPO_MOVIMIENTO "
        snCond = snCond & " and MOVIM_ACTIVOS.ESTADO_MOVIMIENTO = 'T' "

        Order_By = " Order By MOVIM_ACTIVOS.TIPO_MOVIMIENTO, MOVIM_ACTIVOS.CORRELATIVO_MOVIM"
        'snCond = snCond & "order by MOVIM_ACTIVOS.FECHA_MOVIMIENTO"
    End Sub

    Private Sub CambioLista()
        Dim valor As String
        For Each fila As DataGridViewRow In Me.GridData.Rows
            valor = fila.Cells(2).Value.ToString
            Select Case valor
                Case "A"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(61, "A - Alta")
                Case "D"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(62, "D - Desecho")
                Case "P"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(63, "P - Depreciación")
                Case "R"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(64, "R - Revaluación")
                Case "V"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(65, "V - Venta")
                Case "M"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(170, "M - Disminución")
                Case "I"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(171, "I - Incremento")
                Case "G"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(68, "G - Revaluación Masiva")
                Case "N"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(69, "N - Donación")
            End Select
        Next
    End Sub

    Private Sub Consultar()
        If LlenarLlaves() Then
            Dim frmConsulta As New ACTMVAM1
            With frmConsulta
                .CodigoActivo = lblCODIGO_DE_ACTIVO.Text
                .MejoraCorrelativo = lblMEJORA_CORRELATIVO.Text
                .SoloDeConsulta = True
                .Pila = Me.Pila
                .Show()
            End With
            Me.LimpiarPila()
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

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
        Me.CambioLista()
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click, mnuAgregar.Click
        Dim frmAgregar As New ACTMVAM0
        With frmAgregar
            .Modo_Local = Modo_Alta
            .CodigoActivo = lblCODIGO_DE_ACTIVO.Text
            .MejoraCorrelativo = lblMEJORA_CORRELATIVO.Text
            Push("")
            Push("")
            .ShowDialog()
            If .HubieronCambios Then
                MyBase.LlenarSelNav()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        If LlenarLlaves() Then
            Dim frmBorrar As New ACTMVAM0
            With frmBorrar
                .Modo_Local = Modo_Baja
                .CodigoActivo = lblCODIGO_DE_ACTIVO.Text
                .MejoraCorrelativo = lblMEJORA_CORRELATIVO.Text
                .Pila = Me.Pila
                .ShowDialog()
                If .HubieronCambios Then
                    MyBase.LlenarSelNav()
                End If
                .Dispose()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub ConsultaMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaMovimiento.Click, mnuConsultaMovimiento.Click
        Me.Consultar()
    End Sub

    Private Sub ConsultaActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaActivo.Click, mnuConsultaActivo.Click
        Dim frmConsulta As New ACTMAFC0
        With frmConsulta
            Push(lblCODIGO_DE_ACTIVO.Text)
            Push(lblMEJORA_CORRELATIVO.Text)
            .Pila = Me.Pila
            .ShowDialog()
        End With
        Me.LimpiarPila()
    End Sub

    Private Sub ConsultaPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaPartida.Click, mnuConsultaPartida.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                Try
                    Dim codigoActivo As String = lblCODIGO_DE_ACTIVO.Text
                    Dim mejoraCorrelativo As String = lblMEJORA_CORRELATIVO.Text
                    Dim tipoMovimiento As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                    Dim correlativoMovimiento As String = GridData.SelectedRows(0).Cells(2).Value.ToString()

                    Dim comando As New SqlClient.SqlCommand
                    With comando
                        .CommandText = "SELECT CLASE_MOVIMIENTO FROM TIPO_MOV_ACTIVOS WHERE TIPO_MOVIMIENTO = " & tipoMovimiento
                    End With
                    Dim claseMovimiento As String = String.Empty
                    Dim dsClase As DataSet = GetDataSet(comando)
                    If Not dsClase Is Nothing Then
                        If dsClase.Tables.Count > 0 Then
                            For Each filaData As DataRow In dsClase.Tables(0).Rows
                                claseMovimiento = filaData.Item(0).ToString
                            Next
                            Dim documentoOrigen As String = String.Empty
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
                                    meteSQL("SELECT CODIGO_REVALUACION")
                                    meteSQL("FROM MOVIM_ACTIVOS")
                                    meteSQL("WHERE CODIGO_DE_ACTIVO = " & Scm(lblCODIGO_DE_ACTIVO.Text))
                                    meteSQL(" AND MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))
                                    meteSQL(" AND TIPO_MOVIMIENTO = " & sen(tipoMovimiento))
                                    meteSQL(" AND CORRELATIVO_MOVIM = " & sen(correlativoMovimiento))
                                    EjecutaSQL("")

                                    Dim codigoRevaluacion As String = String.Empty
                                    ' Obtenemos el resultado de SQL
                                    Do While SqlNextRow(Sqlconn) = MOREROWS
                                        codigoRevaluacion = SqlData(Sqlconn, 1).ToString
                                    Loop

                                    codigoActivo = codigoRevaluacion
                                    mejoraCorrelativo = String.Empty
                                    tipoMovimiento = String.Empty
                                    documentoOrigen = "RM"
                            End Select

                            Dim frmConsulta As New PATRES03
                            With frmConsulta
                                .CodigoActivo = codigoActivo
                                .MejoraCorrelativo = mejoraCorrelativo
                                .TipoMovimiento = tipoMovimiento
                                .Origen4 = String.Empty
                                .Origen5 = String.Empty
                                .Origen6 = String.Empty
                                .DocumentoOrigen = documentoOrigen
                                .Show()
                            End With
                        End If
                    End If

                Catch errSQL As SqlClient.SqlException
                    MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
End Class