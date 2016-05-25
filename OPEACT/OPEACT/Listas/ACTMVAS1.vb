Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.Iconos

Public Class ACTMVAS1
    Public Property Mes As Integer
    Public Property Anio As Integer

    Private _fechaDepreciacion As String = String.Empty
    Private _fechaDepreciacionFin As String = String.Empty
    Private _tipoDeMovimiento As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultaMovimiento.Text = Me.cmdConsultaMovimientos.Texto
        Me.mnuConsultaActivo.Text = Me.cmdConsultaActivo.Texto
        Me.mnuConsultaPartidas.Text = Me.cmdConsultaPartidas.Texto
        Me.mnuBorrar.Text = Me.cmdBorrar.Texto
        Me.mnuCalculo.Text = Me.cmdCalculo.Texto
        Me.mnuAutorizacion.Text = Me.cmdAutorizacion.Texto
        Me.mnuReporteDepreciacion.Text = Me.cmdReporteDepreciacion.Texto
        Me.mnuReportePartida.Text = Me.cmdReportePartidaTrabajo.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consulta Movimientos
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Movimiento).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta activo
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Consultar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta partida
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ConsultaPartida).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Borrar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Borrar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Calculo
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Calculo).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Autorizacion
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Autorizacion).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte Depreciación
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ReporteGeneral).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Reporte Partida
            imagen = oIcono.GetIcon(Iconos.TipoIcono.ReporteFicha).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdConsultaMovimientos.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultaMovimiento.Image = Me.cmdConsultaMovimientos.Image
            Me.cmdConsultaActivo.Image = Me.IconosMenus.Images(1)
            Me.mnuConsultaActivo.Image = Me.cmdConsultaActivo.Image
            Me.cmdConsultaPartidas.Image = Me.IconosMenus.Images(2)
            Me.mnuConsultaPartidas.Image = Me.cmdConsultaPartidas.Image
            Me.cmdBorrar.Image = Me.IconosMenus.Images(3)
            Me.mnuBorrar.Image = Me.cmdBorrar.Image
            Me.cmdCalculo.Image = Me.IconosMenus.Images(4)
            Me.mnuCalculo.Image = Me.cmdCalculo.Image
            Me.cmdAutorizacion.Image = IconosMenus.Images(5)
            Me.mnuAutorizacion.Image = Me.cmdAutorizacion.Image
            Me.cmdReporteDepreciacion.Image = Me.IconosMenus.Images(6)
            Me.mnuReporteDepreciacion.Image = Me.cmdReporteDepreciacion.Image
            Me.cmdReportePartidaTrabajo.Image = Me.IconosMenus.Images(7)
            Me.mnuReportePartida.Image = Me.cmdReportePartidaTrabajo.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(8)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(9)
            Me.mnuSalir.Image = Me.cmdSalir.Image

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        lblMes.Text = Citi.Synergia.HelperClient.Utils.MesEnLetras(Me.Mes)
        lblAnio.Text = Anio

        Dim mes As String = Me.Mes

        _fechaDepreciacion = mes + "/01/" + Anio.ToString()

        Dim final As Integer = Date.DaysInMonth(Me.Anio, Me.Mes)
        _fechaDepreciacionFin = mes + "/" + final.ToString + "/" + Me.Anio.ToString()

        If Not String.IsNullOrEmpty(TraeDato("Select TIPO_MOVIMIENTO From TIPO_MOV_ACTIVOS Where TIPO_MOV_ACTIVOS.CLASE_MOVIMIENTO = 'P'")) Then
            _tipoDeMovimiento = TraeDato("Select TIPO_MOVIMIENTO From TIPO_MOV_ACTIVOS Where TIPO_MOV_ACTIVOS.CLASE_MOVIMIENTO = 'P'").ToString
        End If

        MyBase.SetearPosiciones()

        Me.LlenarParam()

        MyBase.LlenarSelNav()
    End Sub

    Private Sub LlenarParam()
        NumCols = 5
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Codigo Activo", 15, ALINEAR_IZQ, "MOVIM_ACTIVOS.CODIGO_DE_ACTIVO", 47, 4, 0, 1, 92)
        MeterParam(2, Info, 1, "Mejora", 6, ALINEAR_DER, "MOVIM_ACTIVOS.MEJORA_CORRELATIVO", 56, 1, 0, 3, 115)
        MeterParam(3, Info, 1, "Tipo", 4, ALINEAR_DER, "MOVIM_ACTIVOS.TIPO_MOVIMIENTO", 56, 1, 0, 4, 14)
        MeterParam(4, Info, 1, "Movimiento", 10, ALINEAR_DER, "MOVIM_ACTIVOS.CORRELATIVO_MOVIM", 56, 5, 0, 2, 236)
        MeterParam(5, Info, 1, "Depreciacion ", 13, ALINEAR_DER, "Convert(Varchar, MOVIM_ACTIVOS.MONTO_DE_MOVIMIENTO, 1)", 60, 6, 2, 0, 237)
        MeterParam(6, Info, 1, "Dep. No Deduc.", 15, ALINEAR_DER, "Convert(Varchar, MOVIM_ACTIVOS.VALOR_NO_DEDUCIBLE, 1)", 60, 6, 2, 0, 238)
        MeterParam(7, Info, 1, "Descripción Activo", 40, ALINEAR_IZQ, "ACTIVOS_FIJOS.DESCRIP_CORTA_ACTIVO", 47, 20, 0, 0, 30)

        snCond = "MOVIM_ACTIVOS.CODIGO_DE_ACTIVO = ACTIVOS_FIJOS.CODIGO_DE_ACTIVO AND MOVIM_ACTIVOS.MEJORA_CORRELATIVO = ACTIVOS_FIJOS.MEJORA_CORRELATIVO"
        snCond += " And MOVIM_ACTIVOS.FECHA_MOVIMIENTO Between " & Scm(_fechaDepreciacion) & " and " & Scm(_fechaDepreciacionFin)
        snCond += " And MOVIM_ACTIVOS.TIPO_MOVIMIENTO = " & sen(_tipoDeMovimiento)

        Order_By = " order by MOVIM_ACTIVOS.CODIGO_DE_ACTIVO,MOVIM_ACTIVOS.MEJORA_CORRELATIVO"
        snTabla = "MOVIM_ACTIVOS,ACTIVOS_FIJOS"
    End Sub

    Sub EnviaOrigenes()
        'El objetivo de esta funcion es enviar los
        'Origenes de la depreciación para el uso que
        'sea conveniente, el orden de envio (PUSH):
        '   - ORIGEN 1
        '   - ORIGEN 2
        '   - ORIGEN 3
        '   - ORIGEN 4
        '   - ORIGEN 5
        '   - ORIGEN 6
        '   - DOCUMENTO ORIGEN
        '-------------------------------------------
        Try
            Dim Sel As Short
            Dim tipo_mov As String = String.Empty
            Dim mes_num As Integer
            Dim mes_car As String = String.Empty
            Dim anio_num As Integer
            Dim anio_car As String = String.Empty
            Dim No_Periodo As String = String.Empty
            Dim Ano_Periodo As String = String.Empty

            Sel = True
            meteSQL("SELECT TIPO_MOVIMIENTO")
            meteSQL("  FROM TIPO_MOV_ACTIVOS")
            meteSQL(" WHERE CLASE_MOVIMIENTO = 'P'")
            EjecutaSQL("")
            ' Obtenemos resultado del sql
            Do While SqlNextRow(Sqlconn) = MOREROWS
                tipo_mov = SqlData(Sqlconn, 1).ToString
            Loop

            meteSQL("select NO_PERIODO,ANO_PERIODO")
            meteSQL("  from MOVIM_ACTIVOS")
            meteSQL(" where ESTADO_MOVIMIENTO  = 'T'")
            meteSQL("   and TIPO_MOVIMIENTO    = " & sen(_tipoDeMovimiento))
            meteSQL("   and FECHA_MOVIMIENTO   = " & Scm(_fechaDepreciacion))
            EjecutaSQL("")
            Do While SqlNextRow(Sqlconn) = MOREROWS
                No_Periodo = SqlData(Sqlconn, 1).ToString
                Ano_Periodo = SqlData(Sqlconn, 2).ToString
            Loop

            anio_num = Val(Ano_Periodo)
            mes_num = Val(No_Periodo)

            anio_car = Str(anio_num)
            mes_car = Str(mes_num)

            Push(tipo_mov)
            Push(Trim(anio_car))
            Push(Trim(mes_car))
            Push("")
            Push("")
            Push("")
            Push("PA")

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Llenar(False)
    End Sub

    Private Sub ConsultaMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaMovimientos.Click, mnuConsultaMovimiento.Click
        If LlenarLlaves() Then
            Dim frmConsulta As New ACTMVAM1
            With frmConsulta
                .SoloDeConsulta = True
                .Pila = Me.Pila
                .Show()
            End With
            Me.LimpiarPila()
        End If
    End Sub

    Private Sub ConsultaActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaActivo.Click, mnuConsultaActivo.Click
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                If GridData.SelectedRows.Count > 0 Then
                    Dim codigoActivo As String = GridData.SelectedRows(0).Cells(0).Value.ToString
                    Dim mejoraCorrelativo As String = GridData.SelectedRows(0).Cells(1).Value.ToString
                    Push(codigoActivo)
                    Push(mejoraCorrelativo)
                    Dim frmConsulta As New ACTMAFC0
                    With frmConsulta
                        .SoloDeConsulta = True
                        .Pila = Me.Pila
                        .ShowDialog()
                        If .HubieronCambios Then
                            MyBase.LlenarSelNav()
                        End If
                        .Dispose()
                    End With
                    Me.LimpiarPila()
                End If
            End If
        End If
    End Sub

    Private Sub ConsultaPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaPartidas.Click, mnuConsultaPartidas.Click
        Dim frmOpciones As New ConsultaPartida
        If frmOpciones.ShowDialog() = DialogResult.OK Then
            Dim respuesta As String = frmOpciones.Opcion

            Me.EnviaOrigenes()

            If respuesta = "1" Then
                Dim frmConsulta As New PATRES03
                With frmConsulta
                    .DocumentoOrigen = Pop()
                    .Origen6 = Pop()
                    .Origen5 = Pop()
                    .Origen4 = Pop()
                    .TipoMovimiento = Pop()
                    .MejoraCorrelativo = Pop()
                    .CodigoActivo = Pop()
                    .Pila = Me.Pila
                    .Show()
                End With
            ElseIf respuesta = "2" Then
                Dim frmConsulta As New frmParConta
                With frmConsulta
                    .Pila = Me.Pila
                    .Show()
                End With
            End If

            Me.LimpiarPila()
        End If
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click, mnuBorrar.Click
        Try
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Elimina_Mov_Depreciacion"
                .Parameters.Add("@MES_DEPRE", SqlDbType.Int).Value = Me.Mes
                .Parameters.Add("@ANO_DEPRE", SqlDbType.Int).Value = Me.Anio
            End With
            For i As Integer = 0 To comando.Parameters.Count - 1
                comando.Parameters(i).Direction = ParameterDirection.Input
            Next
            Dim parametro As SqlClient.SqlParameter
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@MES_DEPRE"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Int
                .Value = Me.Mes
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@ANO_DEPRE"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Int
                .Value = Me.Anio
            End With

            EjecutarComando(comando)

            MyBase.LlenarSelNav()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Calculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculo.Click, mnuCalculo.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdCalculo.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            If Now.Day >= Citi.Synergia.Locals.Cache.DiaInicioProcesoDepreciacion Then
                Dim frmDepreciacionMasiva As New DepreciacionMasiva
                With frmDepreciacionMasiva
                    .EsCalculo = True
                    .MesDepreciacion = Me.Mes
                    .AnioDepreciacion = Me.Anio
                    .ShowDialog()
                    If .HubieronCambios Then
                        MyBase.LlenarSelNav()
                    End If
                    .Dispose()
                End With
            Else
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(359, "Usted no puede realizar este proceso hoy."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Autorizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizacion.Click, mnuAutorizacion.Click
        Dim tieneAcceso As Boolean = False
        Try
            If Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.cmdAutorizacion.Tag.ToString) Then
                tieneAcceso = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If tieneAcceso Then
            If Now.Day >= Citi.Synergia.Locals.Cache.DiaInicioProcesoDepreciacion Then
                Dim frmAutorizacion As New ACTMVAN2
                With frmAutorizacion
                    .Anio = Me.Anio
                    .Mes = Me.Mes
                End With

                If frmAutorizacion.ShowDialog() = DialogResult.OK Then
                    Dim mes As Integer = frmAutorizacion.Mes
                    Dim anio As Integer = frmAutorizacion.Anio

                    Dim resultado As Boolean = False

                    Dim frmDepreciacionMasiva As New DepreciacionMasiva
                    With frmDepreciacionMasiva
                        .NumeroPeriodo = mes
                        .AnioPeriodo = anio
                        .MesDepreciacion = Me.Mes
                        .AnioDepreciacion = Me.Anio
                        .EsCalculo = False
                        .ShowDialog()
                        .Dispose()
                    End With
                End If
            Else
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(359, "Usted no puede realizar este proceso hoy."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(340, "Usted no tiene acceso a esta opción."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ReporteDepreciacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporteDepreciacion.Click, mnuReporteDepreciacion.Click
        Dim frmDepreciacion As New ACTMVAN3
        Push(Me.Mes.ToString)
        Push(Me.Anio)
        Push(True)
        With frmDepreciacion
            .Pila = Me.Pila
            .ShowDialog()
            .Dispose()
        End With
        Me.LimpiarPila()
    End Sub

    Private Sub ReportePartidaTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReportePartidaTrabajo.Click, mnuReportePartida.Click
        Me.EnviaOrigenes()

        Dim frmPartida As New PATRER00
        With frmPartida
            .Pila = Me.Pila
            .ShowDialog()
            .Dispose()
        End With
        Me.LimpiarPila()
    End Sub
End Class