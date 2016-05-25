Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion

Public Class CONEPCC0
    Public Property PeriodoAnio As String
    Public Property PeriodoNumero As String
    Public Property Partida As String

    Private _monedaUtiliza As Short = 0

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsultar.Text = Me.BotonConsulta.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consultar
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

        Order_By = ""

        lblNoPartida.Text = Me.Partida
        lblNoPeriodo.Text = Me.PeriodoNumero
        lblAnioPeriodo.Text = Me.PeriodoAnio

        Me.LlenarEncab()

        _monedaUtiliza = 1

        If _monedaUtiliza = 1 Then
            OptLOCAL.Checked = True
        Else
            OptDOLAR.Checked = True
        End If

        Me.LlenarParam()

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized 'Maximizamos

        MyBase.LlenarSelNav()

        Me.CambioLista()
    End Sub

    Private Sub LlenarEncab()
        Try
            meteSQL("select")
            meteSQL("CODIGO_MODULO")
            meteSQL(", DESCRIPCION_1")
            meteSQL(", DESCRIPCION_2")
            meteSQL(", DESCRIPCION_3")
            meteSQL(", DESCRIPCION_4")
            meteSQL(", convert(varchar(12),FECHA_PARTIDA,103)")
            meteSQL(", convert(varchar(12),FECHA_INGRESO,103)")
            meteSQL(", USUARIO_INGRESO")
            meteSQL(", TASA_CAMBIO")
            meteSQL(", REFERENCIA_1")
            meteSQL(", REFERENCIA_2")
            meteSQL(", DOCUMENTO_ORIGEN")
            meteSQL(", ORIGEN1")
            meteSQL(", ORIGEN2")
            meteSQL(", ORIGEN3")
            meteSQL(", ORIGEN4")
            meteSQL(", ORIGEN5")
            meteSQL(", ORIGEN6")
            meteSQL(", convert(varchar(12),FECHA_AUTORIZACION,103)")
            meteSQL(", USUARIO_AUTORIZACION")
            meteSQL(", INDICA_MODIFICACION")
            meteSQL("  from PARTIDAS_CONSOL_ENC")
            meteSQL(" where ANO_PERIODO    = " & sen(Me.PeriodoAnio))
            meteSQL("   and NO_PERIODO     = " & sen(Me.PeriodoNumero))
            meteSQL("   and NUMERO_PARTIDA = " & sen(Me.Partida))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblCODIGO_MODULO.Text = SqlData(Sqlconn, 1).ToString
                lblDESCRIPCION_1.Text = SqlData(Sqlconn, 2).ToString
                lblDESCRIPCION_2.Text = SqlData(Sqlconn, 3).ToString
                lblDESCRIPCION_3.Text = SqlData(Sqlconn, 4).ToString
                lblDESCRIPCION_4.Text = SqlData(Sqlconn, 5).ToString
                lblFechaPartida.Text = SqlData(Sqlconn, 6).ToString
                lblFECHA_INGRESO.Text = SqlData(Sqlconn, 7).ToString
                lblUSUARIO_INGRESO.Text = SqlData(Sqlconn, 8).ToString
                lblTASA_DE_CAMBIO.Text = SqlData(Sqlconn, 9).ToString
                lblREFERENCIA_1.Text = SqlData(Sqlconn, 10).ToString
                lblREFERENCIA_2.Text = SqlData(Sqlconn, 11).ToString
                lblDOCUMENTO_ORIGEN.Text = SqlData(Sqlconn, 12).ToString
                lblORIGEN_1.Text = SqlData(Sqlconn, 13).ToString
                lblORIGEN_2.Text = SqlData(Sqlconn, 14).ToString
                lblORIGEN_3.Text = SqlData(Sqlconn, 15).ToString
                lblORIGEN_4.Text = SqlData(Sqlconn, 16).ToString
                lblORIGEN_5.Text = SqlData(Sqlconn, 17).ToString
                lblORIGEN_6.Text = SqlData(Sqlconn, 18).ToString
                lblFECHA_AUTORIZO.Text = SqlData(Sqlconn, 19).ToString
                lblUSUARIO_AUTORIZO.Text = SqlData(Sqlconn, 20).ToString
                lblAviso.Visible = IIf(SqlData(Sqlconn, 21).ToString = "S", True, False)
            Loop

            If Val(lblTASA_DE_CAMBIO.Text) = 0 Then
                grpMoneda.Enabled = False
            End If

            'Variamos Titulos de Origenes
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Ver_partida_de_origen"
                .Parameters.Add("@documento_origen", SqlDbType.Char, 2).Value = lblDOCUMENTO_ORIGEN.Text
                .Parameters.Add("@origen1", SqlDbType.Char, 15).Value = lblORIGEN_1
                .Parameters.Add("@origen2", SqlDbType.Char, 15).Value = lblORIGEN_2
                .Parameters.Add("@origen3", SqlDbType.Char, 15).Value = lblORIGEN_3
                .Parameters.Add("@origen4", SqlDbType.Char, 15).Value = lblORIGEN_4
                .Parameters.Add("@origen5", SqlDbType.Char, 15).Value = lblORIGEN_5
                .Parameters.Add("@origen6", SqlDbType.Char, 15).Value = lblORIGEN_6
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
                .Value = lblDOCUMENTO_ORIGEN.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen1"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblORIGEN_1
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen2"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblORIGEN_2
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen3"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblORIGEN_3
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen4"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblORIGEN_4
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen5"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblORIGEN_5
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@origen6"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblORIGEN_6
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
                lblOrigen1.Text = .Parameters(7).Value.ToString
                lblOrigen2.Text = .Parameters(8).Value.ToString
                lblOrigen3.Text = .Parameters(9).Value.ToString
                lblOrigen4.Text = .Parameters(10).Value.ToString
                lblOrigen5.Text = .Parameters(11).Value.ToString
                lblOrigen6.Text = .Parameters(12).Value.ToString
                lblDES_ORI_1.Text = .Parameters(13).Value.ToString
                lblDES_ORI_2.Text = .Parameters(14).Value.ToString
                lblDES_ORI_3.Text = .Parameters(15).Value.ToString
                lblDES_ORI_4.Text = .Parameters(16).Value.ToString
                lblDES_ORI_5.Text = .Parameters(17).Value.ToString
                lblDES_ORI_6.Text = .Parameters(18).Value.ToString
            End With

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarParam()
        NumCols = 8
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Linea", 5, ALINEAR_DER, "PARTIDAS_CONSOL_DET.CORRELATIVO", 56, 3, 0, 1, 133)
        MeterParam(2, Info, 1, "Cat.", 4, ALINEAR_IZQ, "PARTIDAS_CONSOL_DET.TIPO_CATALOGO", 47, 3, 0, 0, 28)
        MeterParam(3, Info, 1, "Centro", 15, ALINEAR_IZQ, "PARTIDAS_CONSOL_DET.CODIGO_CENTRO", 39, 15, 0, 0, 130)
        MeterParam(4, Info, 1, "Cuenta", 30, ALINEAR_IZQ, "PARTIDAS_CONSOL_DET.CUENTA_CONTABLE", 47, 30, 0, 0, 131)
        MeterParam(5, Info, 1, "Descripcion", 40, ALINEAR_IZQ, "CATALOGO_CONT_DET.DESCRIPCION", 47, 40, 0, 0, 12)
        If _monedaUtiliza = 1 Then
            MeterParam(6, Info, 1, "Monto", 14, ALINEAR_DER, "Convert(Varchar, round(PARTIDAS_CONSOL_DET.MONTO,2), 1)", 62, 14, 2, 0, 127)
        Else
            MeterParam(6, Info, 1, "Monto $", 14, ALINEAR_DER, "Convert(Varchar, round(Convert(money,PARTIDAS_CONSOL_DET.MONTO / PARTIDAS_CONSOL_ENC.TASA_CAMBIO),2), 1)", 62, 14, 2, 0, 127)
        End If
        MeterParam(7, Info, 1, "Tipo", 9, ALINEAR_IZQ, "PARTIDAS_CONSOL_DET.DEBITO_CREDITO", 47, 1, 0, 0, 14)
        MeterParam(8, Info, 1, "Concepto Contable", 60, ALINEAR_IZQ, "PARTIDAS_CONSOL_DET.CONCEPTO_CONTABLE", 47, 60, 0, 0, 132)

        snCond = " PARTIDAS_CONSOL_ENC.ANO_PERIODO = " & Me.PeriodoAnio & " and PARTIDAS_CONSOL_ENC.NO_PERIODO = " & Me.PeriodoNumero
        snCond = snCond & " and PARTIDAS_CONSOL_ENC.NUMERO_PARTIDA = " & Me.Partida & " and PARTIDAS_CONSOL_DET.ANO_PERIODO = PARTIDAS_CONSOL_ENC.ANO_PERIODO and PARTIDAS_CONSOL_DET.NO_PERIODO = PARTIDAS_CONSOL_ENC.NO_PERIODO and PARTIDAS_CONSOL_DET.NUMERO_PARTIDA = PARTIDAS_CONSOL_ENC.NUMERO_PARTIDA"
        snCond = snCond & " and PARTIDAS_CONSOL_DET.TIPO_CATALOGO = CATALOGO_CONT_DET.TIPO_CATALOGO "
        snCond = snCond & " and PARTIDAS_CONSOL_DET.CUENTA_CONTABLE = CATALOGO_CONT_DET.CUENTA_CONTABLE "
        snTabla = " PARTIDAS_CONSOL_ENC, PARTIDAS_CONSOL_DET, CATALOGO_CONT_DET "

        Dim Sentencia As String
        Sentencia = "select ltrim(str(sum(convert(money,MONTO)),14,2)) "
        Sentencia = Sentencia & " From PARTIDAS_CONSOL_DET "
        Sentencia = Sentencia & " Where PARTIDAS_CONSOL_DET.ANO_PERIODO = " & Me.PeriodoAnio
        Sentencia = Sentencia & " and PARTIDAS_CONSOL_DET.NO_PERIODO = " & Me.PeriodoNumero
        Sentencia = Sentencia & " and PARTIDAS_CONSOL_DET.NUMERO_PARTIDA = " & Me.Partida
        Sentencia = Sentencia & " and DEBITO_CREDITO = 'D'"

        If _monedaUtiliza <> 1 Then
            If Val(lblTASA_DE_CAMBIO.Text) > 0 Then
                Sentencia = "Select ltrim(str(Sum(round(convert(money,PARTIDAS_CONSOL_DET.MONTO / TASA_CAMBIO), 2)),14,2)) "
                Sentencia = Sentencia & " From PARTIDAS_CONSOL_DET , PARTIDAS_CONSOL_ENC "
                Sentencia = Sentencia & " Where PARTIDAS_CONSOL_DET.ANO_PERIODO = " & Me.PeriodoAnio
                Sentencia = Sentencia & " and PARTIDAS_CONSOL_DET.NO_PERIODO = " & Me.PeriodoNumero
                Sentencia = Sentencia & " and PARTIDAS_CONSOL_DET.NUMERO_PARTIDA = " & Me.Partida
                Sentencia = Sentencia & " and PARTIDAS_CONSOL_DET.DEBITO_CREDITO = 'D'"
                Sentencia = Sentencia & " and PARTIDAS_CONSOL_ENC.ANO_PERIODO = PARTIDAS_CONSOL_DET.ANO_PERIODO"
                Sentencia = Sentencia & " and PARTIDAS_CONSOL_ENC.NO_PERIODO = PARTIDAS_CONSOL_DET.NO_PERIODO"
                Sentencia = Sentencia & " and PARTIDAS_CONSOL_ENC.NUMERO_PARTIDA = PARTIDAS_CONSOL_DET.NUMERO_PARTIDA"
                If Not String.IsNullOrEmpty(TraeDato(Sentencia)) Then
                    lblTOTALES.Text = String.Format("{0:0,0.00}", TraeDato(Sentencia))
                End If
            Else
                lblTOTALES.Text = "0.00"
            End If
        Else
            If Not String.IsNullOrEmpty(TraeDato(Sentencia)) Then
                lblTOTALES.Text = String.Format("{0:0,0.00}", TraeDato(Sentencia))
            End If
        End If
    End Sub

    Private Sub CambioLista()
        If Me.GridData.Rows.Count > 0 Then
            If GridData.Rows.Count > 0 Then
                For Each fila As DataGridViewRow In GridData.Rows
                    Dim tmp As String = fila.Cells(4).Value.ToString.Trim
                    Select Case tmp
                        Case "D"
                            fila.Cells(4).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(184, "D - Débito")
                        Case "C"
                            fila.Cells(4).Value = Citi.Synergia.Traductor.Idiomas.GetMensaje(185, "C - Crédito")
                    End Select
                Next
            End If
        End If
    End Sub

    Private Sub Consultar()
        Dim varConsolidacionId As String = String.Empty
        Dim periodoAnio As String = String.Empty
        Dim numeroPeriodo As String = String.Empty
        Dim numeroPartida As String = String.Empty
        Dim tipoPartida As String = String.Empty

        If Not String.IsNullOrEmpty(TraeDato("Select CONSOLIDACION_ID From PARTIDAS_CONSOL_ENC Where ANO_PERIODO = " & sen(Me.PeriodoAnio) & " And NO_PERIODO = " & sen(Me.PeriodoNumero) & " And NUMERO_PARTIDA = " & sen(Me.Partida))) Then
            varConsolidacionId = TraeDato("Select CONSOLIDACION_ID From PARTIDAS_CONSOL_ENC Where ANO_PERIODO = " & sen(Me.PeriodoAnio) & " And NO_PERIODO = " & sen(Me.PeriodoNumero) & " And NUMERO_PARTIDA = " & sen(Me.Partida)).ToString
        End If

        If Not String.IsNullOrEmpty(TraeDato("select Count(1) From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
            If Val(TraeDato("select Count(1) From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString) > 0 Then
                If Not String.IsNullOrEmpty(TraeDato("select ANO_PERIODO From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
                    periodoAnio = TraeDato("select ANO_PERIODO From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString()
                End If
                If Not String.IsNullOrEmpty(TraeDato("select NO_PERIODO From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
                    numeroPeriodo = TraeDato("select NO_PERIODO From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString()
                End If
                If Not String.IsNullOrEmpty(TraeDato("select NUMERO_PARTIDA From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
                    numeroPartida = TraeDato("select NUMERO_PARTIDA From PARTIDAS_TRABAJO_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString()
                End If

                Dim frmConsulta As New PATRAC01
                With frmConsulta
                    .AnioPeriodo = periodoAnio
                    .NumeroPeriodo = numeroPeriodo
                    .NumeroPartida = numeroPartida
                    .Show()
                End With
                Exit Sub
            End If
        End If

        If Not String.IsNullOrEmpty(TraeDato("select Count(1) From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
            If Val(TraeDato("select Count(1) From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString) > 0 Then
                If Not String.IsNullOrEmpty(TraeDato("select ANO_PERIODO From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
                    periodoAnio = TraeDato("select ANO_PERIODO From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString
                End If
                If Not String.IsNullOrEmpty(TraeDato("select NO_PERIODO From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
                    numeroPeriodo = TraeDato("select NO_PERIODO From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString
                End If
                If Not String.IsNullOrEmpty(TraeDato("select TIPO_PARTIDA From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
                    tipoPartida = TraeDato("select TIPO_PARTIDA From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString
                End If
                If Not String.IsNullOrEmpty(TraeDato("select NUMERO_PARTIDA From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId))) Then
                    numeroPartida = TraeDato("select NUMERO_PARTIDA From PARTIDA_CONTABLE_ENC Where CONSOLIDACION_ID = " & sen(varConsolidacionId)).ToString
                End If

                Dim frmConsulta As New PACONC01
                With frmConsulta
                    .AnioPeriodo = periodoAnio
                    .NumeroPeriodo = numeroPeriodo
                    .TipoPartida = tipoPartida
                    .NumeroPartida = numeroPartida
                    .Show()
                End With
                Exit Sub
            End If
        End If

        MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(137, "Se detectó que la partida consolidadora no existe."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consultar()
    End Sub

    Private Sub DES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DES_1.CheckedChanged, DES_2.CheckedChanged, DES_3.CheckedChanged, DES_4.CheckedChanged
        If sender.Checked Then
            PresentaDescripcion()
        End If
    End Sub

    Private Sub PresentaDescripcion()
        If DES_1.Checked Then
            lblDESCRIPCION_1.Visible = True
            lblDESCRIPCION_2.Visible = False
            lblDESCRIPCION_3.Visible = False
            lblDESCRIPCION_4.Visible = False
        End If
        If DES_2.Checked Then
            lblDESCRIPCION_1.Visible = False
            lblDESCRIPCION_2.Visible = True
            lblDESCRIPCION_3.Visible = False
            lblDESCRIPCION_4.Visible = False
        End If
        If DES_3.Checked Then
            lblDESCRIPCION_1.Visible = False
            lblDESCRIPCION_2.Visible = False
            lblDESCRIPCION_3.Visible = True
            lblDESCRIPCION_4.Visible = False
        End If
        If DES_4.Checked Then
            lblDESCRIPCION_1.Visible = False
            lblDESCRIPCION_2.Visible = False
            lblDESCRIPCION_3.Visible = False
            lblDESCRIPCION_4.Visible = True
        End If
    End Sub

    Private Sub Opts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptCuenta.CheckedChanged, OptDEBE.CheckedChanged, OptDOLAR.CheckedChanged, OptLOCAL.CheckedChanged, OptSecuencia.CheckedChanged
        Select Case sender.Name
            Case "OptCuenta"
                If OptCuenta.Checked Then
                    Order_By = " Order By PARTIDAS_CONSOL_DET.CUENTA_CONTABLE"
                    MyBase.LlenarSelNav()
                End If

            Case "OptDEBE"
                If OptDEBE.Checked Then
                    Order_By = " Order By PARTIDAS_CONSOL_DET.DEBITO_CREDITO"
                    MyBase.LlenarSelNav()
                End If

            Case "OptDOLAR"
                If OptDOLAR.Checked Then
                    _monedaUtiliza = 2
                    Me._infoLista.Clear()
                    Me.LlenarParam()
                    MyBase.LlenarSelNav()
                End If

            Case "OptLOCAL"
                If OptLOCAL.Checked Then
                    _monedaUtiliza = 1
                    Me._infoLista.Clear()
                    Me.LlenarParam()
                    MyBase.LlenarSelNav()
                End If

            Case "OptSecuencia"
                If OptSecuencia.Checked Then
                    Order_By = " Order By PARTIDAS_CONSOL_DET.CORRELATIVO"
                    MyBase.LlenarSelNav()
                End If
        End Select
        Me.CambioLista()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsulta.Click, mnuConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
        Me.CambioLista()
    End Sub
End Class