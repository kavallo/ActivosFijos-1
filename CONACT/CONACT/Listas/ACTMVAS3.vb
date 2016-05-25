Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class ACTMVAS3
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.BotonConsultar.Texto
        Me.mnuPartidas.Text = Me.BotonConsultaPartidas.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consultar
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

            Me.BotonConsultar.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultar.Image = Me.BotonConsultar.Image
            Me.BotonConsultaPartidas.Image = Me.IconosMenus.Images(1)
            Me.mnuPartidas.Image = Me.BotonConsultaPartidas.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(2)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(3)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        lblCodigoMejora.Text = Pop()
        lblCodigoActivo.Text = Pop()

        Me.LlenarParam()

        lblNombreActivo.Text = DescripcionesDB.DescripcionCortaActivo(lblCodigoActivo.Text, lblCodigoMejora.Text)

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 7
        NumLlaves = 2
        ReDim Llaves(NumLlaves)
        snBusc = ""

        Dim tipo_mov As String = String.Empty
        Try
            meteSQL("SELECT TIPO_MOVIMIENTO")
            meteSQL("  FROM TIPO_MOV_ACTIVOS")
            meteSQL(" WHERE CLASE_MOVIMIENTO = 'P'")

            EjecutaSQL("")

            ' Obtenemos el resultado de SQL
            Do While SqlNextRow(Sqlconn) = MOREROWS
                tipo_mov = SqlData(Sqlconn, 1)
            Loop

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MeterParam(1, Info, 1, " ", 1, ALINEAR_DER, "TIPO_MOV_ACTIVOS.CLASE_MOVIMIENTO", 47, 1, 0, 0)
        MeterParam(2, Info, 1, "Tipo", 4, ALINEAR_DER, "MOVIM_ACTIVOS.TIPO_MOVIMIENTO", 56, 1, 0, 2, 14)
        MeterParam(3, Info, 1, "Correlativo", 11, ALINEAR_DER, "MOVIM_ACTIVOS.CORRELATIVO_MOVIM", 56, 7, 0, 1, 93)
        MeterParam(4, Info, 1, "Fecha Movimiento", 16, ALINEAR_IZQ, "convert(varchar(12),MOVIM_ACTIVOS.FECHA_MOVIMIENTO,103)", 47, 12, 0, 0, 124)
        MeterParam(5, Info, 1, "Periodo", 7, ALINEAR_DER, "MOVIM_ACTIVOS.NO_PERIODO", 56, 2, 0, 0, 125)
        MeterParam(6, Info, 1, "Año ", 4, ALINEAR_DER, "MOVIM_ACTIVOS.ANO_PERIODO", 56, 4, 0, 0, 126)
        MeterParam(7, Info, 1, "Monto", 13, ALINEAR_DER, "MOVIM_ACTIVOS.MONTO_DE_MOVIMIENTO", 60, 13, 2, 0, 127)
        'snCampos = CrearParam(Info, Me)

        snCond = " MOVIM_ACTIVOS.CODIGO_DE_ACTIVO = " & Scm(lblCodigoActivo.Text) & " and MOVIM_ACTIVOS.MEJORA_CORRELATIVO = " & sen(lblCodigoMejora.Text)
        snCond = snCond & " and MOVIM_ACTIVOS.TIPO_MOVIMIENTO = TIPO_MOV_ACTIVOS.TIPO_MOVIMIENTO and MOVIM_ACTIVOS.TIPO_MOVIMIENTO <> " & sen(tipo_mov)
        snCond = snCond & " order by MOVIM_ACTIVOS.FECHA_MOVIMIENTO"

        snTabla = "MOVIM_ACTIVOS, TIPO_MOV_ACTIVOS"
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
                Case "I"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(171, "I - Incremento")
                Case "M"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(170, "M - Disminución")
                Case "V"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(65, "V - Venta")
                Case "G"
                    fila.Cells(2).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(68, "G - Revaluación Masiva")
            End Select
        Next
    End Sub

    Private Sub CambiarDescripciones(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.CambiarDescripcionesEnGrid
        Me.CambioLista()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultar.Click, mnuConsultar.Click
        If LlenarLlaves() Then
            Dim frmConsulta As New ACTMVAM1
            With frmConsulta
                .Modo_Local = Modo_Consulta
                .SoloDeConsulta = True
                .Pila = Me.Pila
                .Show()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub ConsultaPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultaPartidas.Click, mnuPartidas.Click
        If LlenarLlaves() Then
            Dim frmConsulta As New PATRES03
            With frmConsulta
                .Pila = Me.Pila
                .Show()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Llenar_Click(sender As System.Object, e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
        Me.CambioLista()
    End Sub
End Class