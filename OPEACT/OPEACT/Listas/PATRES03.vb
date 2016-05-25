Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class PATRES03
    Public Property CodigoActivo As String
    Public Property MejoraCorrelativo As String
    Public Property TipoMovimiento As String
    Public Property Origen4 As String
    Public Property Origen5 As String
    Public Property Origen6 As String
    Public Property DocumentoOrigen As String

    'La variable tipo_consulta indica si utiliza
    'Partidas de Trabajo o Mayorizadas
    '  1 - Trabajos
    '  0 - Mayorizadas
    Private Property _tipoConsulta As Short = 1


    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultaDetalle.Text = Me.BotonConsultaDetalle.Texto
        Me.mnuConsultaMayorizada.Text = Me.BotonConsultaMayorizada.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consulta detalle
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.BajarNivel).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta mayorizada
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.ConsultaDerecha).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta Derecha
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.ConsultaDerecha).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Consulta Izquierda
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.ConsultaIzquierda).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsultaDetalle.Image = Me.IconosMenus.Images(0)
            Me.mnuConsultaDetalle.Image = Me.BotonConsultaDetalle.Image
            Me.BotonConsultaMayorizada.Image = Me.IconosMenus.Images(1)
            Me.mnuConsultaMayorizada.Image = Me.BotonConsultaMayorizada.Image
            Me.BotonLlenar.Image = Me.IconosMenus.Images(2)
            Me.mnuLlenar.Image = Me.BotonLlenar.Image
            Me.cmdSalir.Image = Me.IconosMenus.Images(3)
            Me.mnuSalir.Image = Me.cmdSalir.Image
            Me.cmdOriginal.Image = Me.IconosMenus.Images(4)
            Me.cmdNuevaCon.Image = Me.IconosMenus.Images(5)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MyBase.SetearPosiciones()

        'Incializamos que Busque Partidas de Trabajo
        ' osea tipo_consulta = 1
        _tipoConsulta = 1

        If String.IsNullOrEmpty(Me.MejoraCorrelativo) Then
            Me.MejoraCorrelativo = Pop()
        End If

        '-- SYN_null se le envía desde una ventana
        If Me.MejoraCorrelativo = "SYN_null" Then
            Me.MejoraCorrelativo = String.Empty
        End If

        If String.IsNullOrEmpty(Me.CodigoActivo) Then
            Me.CodigoActivo = Pop()
        End If

        lblorigen6.Text = Me.Origen6
        lblorigen5.Text = Me.Origen5
        lblORIGEN4.Text = Me.Origen4
        lblORIGEN3.Text = Me.TipoMovimiento
        lblORIGEN2.Text = Me.MejoraCorrelativo
        lblORIGEN1.Text = Me.CodigoActivo

        Me.LlenarEncab()

        Me.LlenarParam()

        MyBase.LlenarSelNav()

        Me.RenombraColumna()
    End Sub

    Private Sub LlenarEncab()
        Try
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Ver_partida_de_origen"
                .Parameters.Add("@documento_origen", SqlDbType.Char, 2).Value = Me.DocumentoOrigen
                .Parameters.Add("@origen1", SqlDbType.Char, 15).Value = Me.CodigoActivo
                .Parameters.Add("@origen2", SqlDbType.Char, 15).Value = Me.MejoraCorrelativo
                .Parameters.Add("@origen3", SqlDbType.Char, 15).Value = Me.TipoMovimiento
                .Parameters.Add("@origen4", SqlDbType.Char, 15).Value = Me.Origen4
                .Parameters.Add("@origen5", SqlDbType.Char, 15).Value = Me.Origen5
                .Parameters.Add("@origen6", SqlDbType.Char, 15).Value = Me.Origen6
                .Parameters.Add("@titulo1", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@titulo2", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@titulo3", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@titulo4", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@titulo5", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@titulo6", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@des1", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@des2", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@des3", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@des4", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@des5", SqlDbType.Char, 20).Value = String.Empty
                .Parameters.Add("@des6", SqlDbType.Char, 20).Value = String.Empty
                For i As Integer = 7 To .Parameters.Count - 1
                    .Parameters(i).Direction = ParameterDirection.InputOutput
                Next
            End With
            Dim parametro As SqlClient.SqlParameter

            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@documento_origen"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 2
                .Value = Me.DocumentoOrigen
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen1"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = Me.CodigoActivo
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen2"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = Me.MejoraCorrelativo
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen3"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = Me.TipoMovimiento
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen4"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = Me.Origen4
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen5"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = Me.Origen5
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen6"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = Me.Origen6
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@titulo1"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@titulo2"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@titulo3"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@titulo4"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@titulo5"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@titulo6"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@des1"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@des2"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@des3"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@des4"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@des5"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@des6"
                .Direction = ParameterDirection.InputOutput
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = String.Empty
            End With

            EjecutarComando(comando)

            With comando
                lblTitORIGEN1.Text = .Parameters(7).Value.ToString
                lblTitORIGEN2.Text = .Parameters(8).Value.ToString
                lblTitORIGEN3.Text = .Parameters(9).Value.ToString
                lblTitORIGEN4.Text = .Parameters(10).Value.ToString
                lbltitORIGEN5.Text = .Parameters(11).Value.ToString
                lbltitORIGEN6.Text = .Parameters(12).Value.ToString
                lbldescripcion_origen1.Text = .Parameters(13).Value.ToString
                lbldescripcion_origen2.Text = .Parameters(14).Value.ToString
                lbldescripcion_origen3.Text = .Parameters(15).Value.ToString
                lbldescripcion_origen4.Text = .Parameters(16).Value.ToString
                lbldescripcion_origen5.Text = .Parameters(17).Value.ToString
                lbldescripcion_origen6.Text = .Parameters(18).Value.ToString
            End With

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarParam()
        '-- Borro las columnas del grid
        Me.GridColumnas.Columns.Clear()
        Me.GridData.Columns.Clear()

        'Para Las Partidas Mayorizadas y las de Trabajo
        'Se desplegará el Tipo de Partida y en la rutina
        'de llenar_llaves() solo enviará el tipo de partida
        'si son partidas mayorizadas
        Dim anoPeriodo As String
        Dim noPeriodo As String
        Dim tipoPartida As String
        Dim numeroPartida As String
        Dim fechaPartida As String
        Dim campo6 As String
        Dim tituloCampo6 As String
        Dim llaveTipo As Short 'Esta indica la posicion de la llave para tipo de partida
        ' 0 = Partidas de trabajo  ( no es llave )
        ' 3 = Partidas Mayorizadas ( Si es llave )

        NumCols = 6
        NumLlaves = IIf(_tipoConsulta = 1, 3, 4)
        ReDim Llaves(NumLlaves)
        snBusc = ""

        'Identificamos Campos A Seleccionar
        If _tipoConsulta = 1 Then
            'Para PARTIDAS_TRABAJO_ENC
            anoPeriodo = "convert(varchar,PARTIDAS_TRABAJO_ENC.ANO_PERIODO)"
            noPeriodo = "convert(varchar,PARTIDAS_TRABAJO_ENC.NO_PERIODO)"
            tipoPartida = "PARTIDAS_TRABAJO_ENC.TIPO_PARTIDA"
            numeroPartida = "convert(varchar,PARTIDAS_TRABAJO_ENC.NUMERO_PARTIDA)"
            fechaPartida = "convert(varchar(10),PARTIDAS_TRABAJO_ENC.FECHA_PARTIDA, 103)"
            campo6 = "PARTIDAS_TRABAJO_ENC.ESTADO_PARTIDA"
            tituloCampo6 = Citi.Synergia.Traductor.Idiomas.GetMensaje(37, "Estado")
            llaveTipo = 0
            snTabla = "PARTIDAS_TRABAJO_ENC"
            'Cambiamos el Caption
            Me.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(176, "Consulta de partidas de trabajo - PATRES03")
        Else
            'Para PARTIDA_CONTABLE_ENC
            anoPeriodo = "convert(varchar,PARTIDA_CONTABLE_ENC.ANO_PERIODO)"
            noPeriodo = "convert(varchar,PARTIDA_CONTABLE_ENC.NO_PERIODO)"
            tipoPartida = "PARTIDA_CONTABLE_ENC.TIPO_PARTIDA"
            numeroPartida = "convert(varchar,PARTIDA_CONTABLE_ENC.NUMERO_PARTIDA)"
            fechaPartida = "convert(varchar(10),PARTIDA_CONTABLE_ENC.FECHA_PARTIDA, 103)"
            campo6 = "convert(varchar(10),PARTIDA_CONTABLE_ENC.FECHA_MAYORIZADA, 103)"
            tituloCampo6 = Citi.Synergia.Traductor.Idiomas.GetMensaje(178, "Fecha Mayorizada")
            llaveTipo = 3 'Indicamos Posicion de la llave
            snTabla = "PARTIDA_CONTABLE_ENC"
            'Cambiamos el Caption
            Me.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(177, "Consulta de partidas mayorizadas - PATRES03")
        End If

        'Indicamos Campos en Lista
        MeterParam(1, Info, 1, "Año", 4, ALINEAR_DER, anoPeriodo, 56, 4, 0, 1, 126)
        MeterParam(2, Info, 1, "Periodo", 7, ALINEAR_DER, noPeriodo, 56, 2, 0, 2, 125)
        MeterParam(3, Info, 1, "Tipo", 4, ALINEAR_IZQ, tipoPartida, 47, 3, 0, llaveTipo, 14)
        MeterParam(4, Info, 1, "No. Partida", 11, ALINEAR_DER, numeroPartida, 56, 7, 0, IIf(llaveTipo = 0, 3, 4), 128)
        MeterParam(5, Info, 1, "Fecha Partida", 13, ALINEAR_IZQ, fechaPartida, 58, 13, 0, 0, 129)
        MeterParam(6, Info, 1, tituloCampo6, 16, ALINEAR_IZQ, campo6, 47, 1, 0, 0, 0)

        'Creamos Campos a Seleccionar
        'snCampos = CrearParam(Info, Me)

        'Generamos condiciones
        snCond = "              ltrim(" & snTabla & ".ORIGEN1)          = " & Scm(Me.CodigoActivo)
        snCond = snCond & " And ltrim(" & snTabla & ".ORIGEN2)          = " & Scm(Me.MejoraCorrelativo)
        snCond = snCond & " And ltrim(" & snTabla & ".DOCUMENTO_ORIGEN) = " & Scm(Me.DocumentoOrigen)
        'Si Existe Valor para los demás origenes creamos condiciones
        'Para la tabla ya identificada
        If Me.TipoMovimiento.Trim.Length > 0 Then
            snCond = snCond & " And ltrim(" & snTabla & ".ORIGEN3) = " & Scm(Me.TipoMovimiento)
        End If
        If Me.Origen4.Trim.Length > 0 Then
            snCond = snCond & " And ltrim(" & snTabla & ".ORIGEN4) = " & Scm(Me.Origen4)
        End If
        If Me.Origen5.Trim.Length > 0 Then
            snCond = snCond & " And ltrim(" & snTabla & ".ORIGEN5) = " & Scm(Me.Origen5)
        End If
        If Me.Origen6.Trim.Length > 0 Then
            snCond = snCond & " And ltrim(" & snTabla & ".ORIGEN6) = " & Scm(Me.Origen6)
        End If
    End Sub

    Private Sub RenombraColumna()
        If Me._tipoConsulta = 1 Then
            If Me.GridData.Rows.Count > 0 Then
                If GridData.Rows.Count > 0 Then
                    For Each fila As DataGridViewRow In GridData.Rows
                        Dim tmp As String = fila.Cells(5).Value.ToString.Trim
                        Select Case tmp
                            Case "A"
                                fila.Cells(5).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(179, "A - Autorizada")
                            Case "M"
                                fila.Cells(5).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(180, "M - Mayorizada")
                            Case "N"
                                fila.Cells(5).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(181, "N - No cuadrada")
                            Case "S"
                                fila.Cells(5).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(182, "S - Cuadrada")
                        End Select
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub Consultar()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                If _tipoConsulta = 1 Then
                    Dim frmConsulta As New PATRAC01
                    With frmConsulta
                        Dim anio As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                        Dim periodo As String = GridData.SelectedRows(0).Cells(1).Value.ToString()
                        Dim numeroPartida As String = GridData.SelectedRows(0).Cells(3).Value.ToString()
                        .AnioPeriodo = anio
                        .NumeroPeriodo = periodo
                        .NumeroPartida = numeroPartida
                        .Show()
                    End With
                Else
                    Dim frmConsulta As New PACONC01
                    With frmConsulta
                        Dim anio As String = GridData.SelectedRows(0).Cells(0).Value.ToString()
                        Dim periodo As String = GridData.SelectedRows(0).Cells(1).Value.ToString()
                        Dim tipoPartida As String = GridData.SelectedRows(0).Cells(2).Value.ToString()
                        Dim numeroPartida As String = GridData.SelectedRows(0).Cells(3).Value.ToString()
                        .AnioPeriodo = anio
                        .NumeroPeriodo = periodo
                        .TipoPartida = tipoPartida
                        .NumeroPartida = numeroPartida
                        .Show()
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub ConsultaDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultaDetalle.Click, mnuConsultaDetalle.Click
        Me.Consultar()
    End Sub

    Private Sub Mayorizada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsultaMayorizada.Click, mnuConsultaMayorizada.Click
        If _tipoConsulta = 1 Then ' de Partidas de Trabajo a partidas mayorizadas
            _tipoConsulta = 2
            BotonConsultaMayorizada.Image = cmdNuevaCon.Image
            mnuConsultaMayorizada.Image = BotonConsultaMayorizada.Image
            BotonConsultaMayorizada.Texto = Citi.Synergia.Traductor.Idiomas.GetMensaje(176, "Consulta de partidas de trabajo - PATRES03").Replace(" - PATRES03", "")
            mnuConsultaMayorizada.Text = BotonConsultaMayorizada.Texto
        Else 'De Partidas de Trabajo a Partidas Mayorizadas
            _tipoConsulta = 1
            BotonConsultaMayorizada.Image = cmdOriginal.Image
            mnuConsultaMayorizada.Image = BotonConsultaMayorizada.Image
            BotonConsultaMayorizada.Texto = Citi.Synergia.Traductor.Idiomas.GetMensaje(177, "Consulta de partidas mayorizadas - PATRES03").Replace(" - PATRES03", "")
            mnuConsultaMayorizada.Text = BotonConsultaMayorizada.Texto
        End If

        Me._infoLista.Clear()
        Me.LlenarParam()
        MyBase.LlenarSelNav()
    End Sub
End Class