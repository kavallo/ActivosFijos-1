Imports Citi.Synergia
Imports Citi.Synergia.Entidades
Imports Citi.Synergia.Entidades.InfoLista.TipoAlineacion
Imports Citi.Synergia.HelperClient

Public Class PATRAC01
    Public Property AnioPeriodo As String
    Public Property NumeroPeriodo As String
    Public Property NumeroPartida As String

    Private _monedaUtiliza As Short

    Private varConsolidacionID As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mnuConsolida.Text = Me.BotonConsolida.Texto
        Me.mnuLlenar.Text = Me.BotonLlenar.Texto
        Me.mnuSalir.Text = Me.cmdSalir.Texto

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos.Iconos

            Me.IconosMenus.Images.Clear()
            '-- Consolida
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Consolidar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Llenar
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Llenar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)
            '-- Salir
            imagen = oIcono.GetIcon(Iconos.Iconos.TipoIcono.Salir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.BotonConsolida.Image = Me.IconosMenus.Images(0)
            Me.mnuConsolida.Image = Me.BotonConsolida.Image
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

        lblNUMERO_PARTIDA.Text = Me.NumeroPartida
        lblNO_PERIODO.Text = Me.NumeroPeriodo
        lblANO_PERIODO.Text = Me.AnioPeriodo

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
    End Sub

    Private Sub LlenarEncab()
        Try
            meteSQL("select")
            meteSQL(" CODIGO_MODULO")
            meteSQL(", DESCRIPCION_1")
            meteSQL(", DESCRIPCION_2")
            meteSQL(", DESCRIPCION_3")
            meteSQL(", DESCRIPCION_4")
            meteSQL(", convert(varchar(12),FECHA_PARTIDA,103)")
            meteSQL(", convert(varchar(12),FECHA_INGRESO,103)")
            meteSQL(", TIPO_PARTIDA")
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
            meteSQL(", ID_EMPRESA")
            meteSQL(", ID_SUCURSAL")
            meteSQL(", ID_CENTRO_OPERATIVO")
            meteSQL(", Codigo_razon")
            meteSQL(", convert(varchar(12),FECHA_AUTORIZACION,103)")
            meteSQL(", USUARIO_AUTORIZACION")
            meteSQL(", CONSOLIDACION_ID")
            meteSQL(", INDICA_MODIFICACION")
            meteSQL(" from PARTIDAS_TRABAJO_ENC")
            meteSQL(" where ANO_PERIODO    = " & sen(Me.AnioPeriodo))
            meteSQL("  and NO_PERIODO     = " & sen(Me.NumeroPeriodo))
            meteSQL("  and NUMERO_PARTIDA = " & sen(Me.NumeroPartida))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblCODIGO_MODULO.Text = SqlData(Sqlconn, 1).ToString
                If SqlData(Sqlconn, 2).ToString.Trim.Length > 0 Then
                    cboDESCRIPCION.Items.Add(SqlData(Sqlconn, 2).ToString)
                End If
                If SqlData(Sqlconn, 3).ToString.Trim.Length > 0 Then
                    cboDESCRIPCION.Items.Add(SqlData(Sqlconn, 3).ToString)
                End If
                If SqlData(Sqlconn, 4).ToString.Trim.Length > 0 Then
                    cboDESCRIPCION.Items.Add(SqlData(Sqlconn, 4).ToString)
                End If
                If SqlData(Sqlconn, 5).ToString.Trim.Length > 0 Then
                    cboDESCRIPCION.Items.Add(SqlData(Sqlconn, 5).ToString)
                End If

                cboDESCRIPCION.SelectedIndex = 0

                lblFECHA_PARTIDA.Text = SqlData(Sqlconn, 6).ToString
                lblFECHA_INGRESO.Text = SqlData(Sqlconn, 7).ToString
                lblTIPO_PARTIDA.Text = SqlData(Sqlconn, 8).ToString
                lblUSUARIO_INGRESO.Text = SqlData(Sqlconn, 9).ToString
                lblTASA_DE_CAMBIO.Text = SqlData(Sqlconn, 10).ToString
                lblREFERENCIA_1.Text = SqlData(Sqlconn, 11).ToString
                lblREFERENCIA_2.Text = SqlData(Sqlconn, 12).ToString
                lblDOCUMENTO_ORIGEN.Text = SqlData(Sqlconn, 13).ToString
                _lblorigen_1.Text = SqlData(Sqlconn, 14).ToString
                _lblorigen_2.Text = SqlData(Sqlconn, 15).ToString
                _lblorigen_3.Text = SqlData(Sqlconn, 16).ToString
                _lblorigen_4.Text = SqlData(Sqlconn, 17).ToString
                _lblorigen_5.Text = SqlData(Sqlconn, 18).ToString
                _lblorigen_6.Text = SqlData(Sqlconn, 19).ToString
                lblID_EMPRESA.Text = SqlData(Sqlconn, 20).ToString
                lblID_SUCURSAL.Text = SqlData(Sqlconn, 21).ToString
                lblID_CENTRO_OPERATIVO.Text = SqlData(Sqlconn, 22).ToString
                lblCodigo_razon.Text = SqlData(Sqlconn, 23).ToString
                lblFECHA_AUTORIZO.Text = SqlData(Sqlconn, 24).ToString
                lblUSUARIO_AUTORIZO.Text = SqlData(Sqlconn, 25).ToString
                varConsolidacionID = SqlData(Sqlconn, 26).ToString
                lblAVISO.Visible = IIf(SqlData(Sqlconn, 27).ToString = "S", True, False)
            Loop

            If Val(lblTASA_DE_CAMBIO.Text) = 0 Then
                grpMoneda.Enabled = False
            End If

            lblTitNombre_Tipo.Text = DescripcionesDB.TipoPartida(lblTIPO_PARTIDA.Text)

            lblDES_RAZON.Text = DescripcionesDB.RazonContable(lblCodigo_razon.Text)

            'Variamos Titulos de Origenes
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Ver_origen_de_partida"
                .Parameters.Add("@ano_periodo", SqlDbType.Int).Value = Me.AnioPeriodo
                .Parameters.Add("@no_periodo", SqlDbType.Int).Value = Me.NumeroPeriodo
                .Parameters.Add("@numero_partida", SqlDbType.Int).Value = Me.NumeroPartida
                .Parameters.Add("@Tipo_Partida", SqlDbType.Char, 3).Value = DBNull.Value
                .Parameters.Add("@dedonde", SqlDbType.Char, 20).Value = "T"
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
                For i As Integer = 5 To .Parameters.Count - 1
                    .Parameters(i).Direction = ParameterDirection.InputOutput
                Next
            End With
            Dim parametro As SqlClient.SqlParameter

            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@ano_periodo"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Int
                .Value = Me.AnioPeriodo
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@no_periodo"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Int
                .Value = Me.NumeroPeriodo
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@numero_partida"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Int
                .Value = Me.NumeroPartida
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@Tipo_Partida"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 3
                .Value = DBNull.Value
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@dedonde"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 20
                .Value = "T"
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
                _lbltitORIGEN_1.Text = .Parameters(5).Value.ToString
                _lbltitORIGEN_2.Text = .Parameters(6).Value.ToString
                _lbltitORIGEN_3.Text = .Parameters(7).Value.ToString
                _lbltitORIGEN_4.Text = .Parameters(8).Value.ToString
                _lbltitORIGEN_5.Text = .Parameters(9).Value.ToString
                _lbltitORIGEN_6.Text = .Parameters(10).Value.ToString
                _lbldescripcion_origen_1.Text = .Parameters(11).Value.ToString
                _lbldescripcion_origen_2.Text = .Parameters(12).Value.ToString
                _lbldescripcion_origen_3.Text = .Parameters(13).Value.ToString
                _lbldescripcion_origen_4.Text = .Parameters(14).Value.ToString
                _lbldescripcion_origen_5.Text = .Parameters(15).Value.ToString
                _lbldescripcion_origen_6.Text = .Parameters(16).Value.ToString
            End With

            If varConsolidacionID = "" Then
                BotonConsolida.Visible = False
                mnuConsolida.Visible = False
            End If

            If Not String.IsNullOrEmpty(TraeDato("Select NOMBRE_DE_EMPRESA From GEN_EMPRESA Where ID_EMPRESA = " & Scm(lblID_EMPRESA.Text))) Then
                lblDESCRIPCION_EMPRESA.Text = TraeDato("Select NOMBRE_DE_EMPRESA From GEN_EMPRESA Where ID_EMPRESA = " & Scm(lblID_EMPRESA.Text)).ToString
            End If

            If Not String.IsNullOrEmpty(TraeDato("Select NOMBRE_DE_SUCURSAL From GEN_SUCURSAL Where ID_EMPRESA = " & Scm(lblID_EMPRESA.Text) & " And ID_SUCURSAL = " & Scm(lblID_SUCURSAL.Text))) Then
                lblDESCRIPCION_SUCURSAL.Text = TraeDato("Select NOMBRE_DE_SUCURSAL From GEN_SUCURSAL Where ID_EMPRESA = " & Scm(lblID_EMPRESA.Text) & " And ID_SUCURSAL = " & Scm(lblID_SUCURSAL.Text)).ToString
            End If

            If Not String.IsNullOrEmpty(TraeDato("Select NOMBRE_DE_CENTRO From GEN_CENTRO_OPERATIVO Where ID_EMPRESA = " & Scm(lblID_EMPRESA.Text) & " And ID_SUCURSAL = " & Scm(lblID_SUCURSAL.Text) & " And ID_CENTRO_OPERATIVO = " & Scm(lblID_CENTRO_OPERATIVO.Text))) Then
                lblDESCRIPCION_CENTRO.Text = TraeDato("Select NOMBRE_DE_CENTRO From GEN_CENTRO_OPERATIVO Where ID_EMPRESA = " & Scm(lblID_EMPRESA.Text) & " And ID_SUCURSAL = " & Scm(lblID_SUCURSAL.Text) & " And ID_CENTRO_OPERATIVO = " & Scm(lblID_CENTRO_OPERATIVO.Text)).ToString
            End If

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

        NumCols = 8
        NumLlaves = 1
        ReDim Llaves(NumLlaves)
        snBusc = ""

        MeterParam(1, Info, 1, "Centro", 6, ALINEAR_IZQ, "PARTIDAS_TRABAJO_DET.CODIGO_CENTRO", 39, 10, 0, 0, 130)
        MeterParam(2, Info, 1, "Cuenta", 12, ALINEAR_IZQ, "PARTIDAS_TRABAJO_DET.CUENTA_CONTABLE", 47, 35, 0, 0, 131)
        If _monedaUtiliza = 1 Then
            MeterParam(3, Info, 1, "Monto", 8, ALINEAR_DER, "Convert(VARCHAR, round(PARTIDAS_TRABAJO_DET.MONTO,2), 1)", 62, 10, 2, 0, 127)
        Else
            MeterParam(3, Info, 1, "Monto $", 8, ALINEAR_DER, "Convert(VARCHAR, round(Convert(money,PARTIDAS_TRABAJO_DET.MONTO / PARTIDAS_TRABAJO_ENC.TASA_CAMBIO),2), 1)", 62, 10, 2, 0, 127)
        End If
        MeterParam(4, Info, 1, "Tipo", 6, ALINEAR_IZQ, "Substring('Debito Credito',CharIndex(PARTIDAS_TRABAJO_DET.DEBITO_CREDITO,'Debito Credito'),7)", 47, 5, 0, 0, 14)
        MeterParam(5, Info, 1, "Descripcion", 40, ALINEAR_IZQ, "CATALOGO_CONT_DET.DESCRIPCION", 47, 50, 0, 0, 12)
        MeterParam(6, Info, 1, "Concepto Contable", 12, ALINEAR_IZQ, "PARTIDAS_TRABAJO_DET.CONCEPTO_CONTABLE", 47, 30, 0, 0, 132)
        MeterParam(7, Info, 1, "Linea", 4, ALINEAR_DER, "PARTIDAS_TRABAJO_DET.CORRELATIVO", 56, 5, 0, 1, 133)
        MeterParam(8, Info, 1, "Cat.", 4, ALINEAR_IZQ, "PARTIDAS_TRABAJO_DET.TIPO_CATALOGO", 47, 5, 0, 0, 28)

        snCond = " PARTIDAS_TRABAJO_ENC.ANO_PERIODO = " & Me.AnioPeriodo & " and PARTIDAS_TRABAJO_ENC.NO_PERIODO = " & Me.NumeroPeriodo
        snCond = snCond & " and PARTIDAS_TRABAJO_ENC.NUMERO_PARTIDA = " & Me.NumeroPartida & " and PARTIDAS_TRABAJO_DET.ANO_PERIODO = PARTIDAS_TRABAJO_ENC.ANO_PERIODO and PARTIDAS_TRABAJO_DET.NO_PERIODO = PARTIDAS_TRABAJO_ENC.NO_PERIODO and PARTIDAS_TRABAJO_DET.NUMERO_PARTIDA = PARTIDAS_TRABAJO_ENC.NUMERO_PARTIDA"
        snCond = snCond & " and PARTIDAS_TRABAJO_DET.TIPO_CATALOGO = CATALOGO_CONT_DET.TIPO_CATALOGO "
        snCond = snCond & " and PARTIDAS_TRABAJO_DET.CUENTA_CONTABLE = CATALOGO_CONT_DET.CUENTA_CONTABLE"
        snTabla = " PARTIDAS_TRABAJO_ENC, PARTIDAS_TRABAJO_DET, CATALOGO_CONT_DET "

        Dim Sentencia As String
        Sentencia = "select ltrim(str(IsNull(sum(convert(money, MONTO)), 0), 14,2)) "
        Sentencia = Sentencia & " From PARTIDAS_TRABAJO_DET "
        Sentencia = Sentencia & " Where PARTIDAS_TRABAJO_DET.ANO_PERIODO = " & Me.AnioPeriodo
        Sentencia = Sentencia & " and PARTIDAS_TRABAJO_DET.NO_PERIODO = " & Me.NumeroPeriodo
        Sentencia = Sentencia & " and PARTIDAS_TRABAJO_DET.NUMERO_PARTIDA = " & Me.NumeroPartida
        Sentencia = Sentencia & " and DEBITO_CREDITO = 'D'"

        If _monedaUtiliza <> 1 Then
            If Val(lblTASA_DE_CAMBIO.Text) > 0 Then
                Sentencia = "Select ltrim(str(IsNull(Sum(round(convert(money, (PARTIDAS_TRABAJO_DET.MONTO / TASA_CAMBIO)), 2)), 0), 14,2)) "
                Sentencia = Sentencia & " From PARTIDAS_TRABAJO_DET , PARTIDAS_TRABAJO_ENC "
                Sentencia = Sentencia & " Where PARTIDAS_TRABAJO_DET.ANO_PERIODO = " & Me.AnioPeriodo
                Sentencia = Sentencia & " and PARTIDAS_TRABAJO_DET.NO_PERIODO = " & Me.NumeroPeriodo
                Sentencia = Sentencia & " and PARTIDAS_TRABAJO_DET.NUMERO_PARTIDA = " & Me.NumeroPartida
                Sentencia = Sentencia & " and PARTIDAS_TRABAJO_DET.DEBITO_CREDITO = 'D'"
                Sentencia = Sentencia & " and PARTIDAS_TRABAJO_ENC.ANO_PERIODO = PARTIDAS_TRABAJO_DET.ANO_PERIODO"
                Sentencia = Sentencia & " and PARTIDAS_TRABAJO_ENC.NO_PERIODO = PARTIDAS_TRABAJO_DET.NO_PERIODO"
                Sentencia = Sentencia & " and PARTIDAS_TRABAJO_ENC.NUMERO_PARTIDA = PARTIDAS_TRABAJO_DET.NUMERO_PARTIDA"
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

    Private Sub Consolidar()
        Dim frmConsolida As New CONEPCS0
        With frmConsolida
            .Consolidacion = varConsolidacionID
            .PeriodoAnio = lblANO_PERIODO.Text
            .PeriodoNumero = lblNO_PERIODO.Text
            .Show()
        End With
    End Sub

    Private Sub SeleccionaFila(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CeldaDoubleClick
        Me.Consolidar()
    End Sub

    Private Sub Opts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptCuenta.CheckedChanged, OptDEBE.CheckedChanged, OptDOLAR.CheckedChanged, OptLOCAL.CheckedChanged, OptSecuencia.CheckedChanged
        Select Case sender.Name
            Case "OptCuenta"
                If OptCuenta.Checked Then
                    Order_By = " Order By PARTIDAS_TRABAJO_DET.CUENTA_CONTABLE "
                    MyBase.LlenarSelNav()
                End If

            Case "OptDEBE"
                If OptDEBE.Checked Then
                    Order_By = " Order By PARTIDAS_TRABAJO_DET.DEBITO_CREDITO "
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
                    Order_By = " Order By PARTIDAS_TRABAJO_DET.CORRELATIVO "
                    MyBase.LlenarSelNav()
                End If
        End Select
    End Sub

    Private Sub Forma_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim inicio As Integer = 96
        Dim aumento As Integer = 20

        If Me._lblorigen_1.Text.Trim.Length > 0 Then
            Me._lbltitORIGEN_1.Top = inicio
            Me._lblorigen_1.Top = Me._lbltitORIGEN_1.Top
            Me._lbldescripcion_origen_1.Top = Me._lbltitORIGEN_1.Top
            inicio += aumento
        Else
            Me._lbltitORIGEN_1.Visible = False
            Me._lblorigen_1.Visible = Me._lbltitORIGEN_1.Visible
            Me._lbldescripcion_origen_1.Visible = Me._lbltitORIGEN_1.Visible
        End If

        If Me._lblorigen_2.Text.Trim.Length > 0 Then
            Me._lbltitORIGEN_2.Top = inicio
            Me._lblorigen_2.Top = Me._lbltitORIGEN_2.Top
            Me._lbldescripcion_origen_2.Top = Me._lbltitORIGEN_2.Top
            inicio += aumento
        Else
            Me._lbltitORIGEN_2.Visible = False
            Me._lblorigen_2.Visible = Me._lbltitORIGEN_2.Visible
            Me._lbldescripcion_origen_2.Visible = Me._lbltitORIGEN_2.Visible
        End If

        If Me._lblorigen_3.Text.Trim.Length > 0 Then
            Me._lbltitORIGEN_3.Top = inicio
            Me._lblorigen_3.Top = Me._lbltitORIGEN_3.Top
            Me._lbldescripcion_origen_3.Top = Me._lbltitORIGEN_3.Top
            inicio += aumento
        Else
            Me._lbltitORIGEN_3.Visible = False
            Me._lblorigen_3.Visible = Me._lbltitORIGEN_3.Visible
            Me._lbldescripcion_origen_3.Visible = Me._lbltitORIGEN_3.Visible
        End If

        If Me._lblorigen_4.Text.Trim.Length > 0 Then
            Me._lbltitORIGEN_4.Top = inicio
            Me._lblorigen_4.Top = Me._lbltitORIGEN_4.Top
            Me._lbldescripcion_origen_4.Top = Me._lbltitORIGEN_4.Top
            inicio += aumento
        Else
            Me._lbltitORIGEN_4.Visible = False
            Me._lblorigen_4.Visible = Me._lbltitORIGEN_4.Visible
            Me._lbldescripcion_origen_4.Visible = Me._lbltitORIGEN_4.Visible
        End If

        If Me._lblorigen_5.Text.Trim.Length > 0 Then
            Me._lbltitORIGEN_5.Top = inicio
            Me._lblorigen_5.Top = Me._lbltitORIGEN_5.Top
            Me._lbldescripcion_origen_5.Top = Me._lbltitORIGEN_5.Top
            inicio += aumento
        Else
            Me._lbltitORIGEN_5.Visible = False
            Me._lblorigen_5.Visible = Me._lbltitORIGEN_5.Visible
            Me._lbldescripcion_origen_5.Visible = Me._lbltitORIGEN_5.Visible
        End If

        If Me._lblorigen_6.Text.Trim.Length > 0 Then
            Me._lbltitORIGEN_6.Top = inicio
            Me._lblorigen_6.Top = Me._lbltitORIGEN_6.Top
            Me._lbldescripcion_origen_6.Top = Me._lbltitORIGEN_6.Top
            inicio += aumento
        Else
            Me._lbltitORIGEN_6.Visible = False
            Me._lblorigen_6.Visible = Me._lbltitORIGEN_6.Visible
            Me._lbldescripcion_origen_6.Visible = Me._lbltitORIGEN_6.Visible
        End If

        Me.lblTitID_EMPRESA.Top = inicio
        Me.lblID_EMPRESA.Top = Me.lblTitID_EMPRESA.Top
        Me.lblDESCRIPCION_EMPRESA.Top = Me.lblTitID_EMPRESA.Top
        inicio += aumento

        Me.lblTitID_SUCURSAL.Top = inicio
        Me.lblID_SUCURSAL.Top = Me.lblTitID_SUCURSAL.Top
        Me.lblDESCRIPCION_SUCURSAL.Top = Me.lblTitID_SUCURSAL.Top
        inicio += aumento

        Me.lblTitID_CENTRO_OPERATIVO.Top = inicio
        Me.lblID_CENTRO_OPERATIVO.Top = Me.lblTitID_CENTRO_OPERATIVO.Top
        Me.lblDESCRIPCION_CENTRO.Top = Me.lblTitID_CENTRO_OPERATIVO.Top
    End Sub

    Private Sub Forma_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                mhTab1.SelectedIndex = 0
            Case Keys.F2
                mhTab1.SelectedIndex = 1
        End Select
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click, mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub Consolida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConsolida.Click, mnuConsolida.Click
        Me.Consolidar()
    End Sub

    Private Sub Llenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonLlenar.Click, mnuLlenar.Click
        Me.Llenar(False)
    End Sub
End Class