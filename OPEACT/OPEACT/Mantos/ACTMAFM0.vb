Imports System.Windows.Forms
Imports Citi.Synergia.HelperClient
Imports Citi.Synergia.Iconos
Imports System.Drawing.Printing


Public Class ACTMAFM0
    Private _anoPeriodo As String = String.Empty
    Private varCOSTO_ACUM_MNTMTO As String = String.Empty
    Private varESTADO_SERVICIO As String = String.Empty
    Private varESTATUS As String = String.Empty
    Private varFECHA_BAJA_ACTIVO As String = String.Empty
    Private varFECHA_OPERACION As String = String.Empty
    Private varFECHA_ULTIMA_DEPREC As String = String.Empty
    Private varFECHA_ULTIMA_REVAL As String = String.Empty
    Private varFECHA_ULT_INVENTARIO As String = String.Empty
    Private varFECHA_ULT_MANTMTO As String = String.Empty
    Private varFEC_ACTUALIZACION As String = String.Empty
    Private varMONTO_ULTIMA_DEPREC As String = String.Empty
    Private varMONTO_ULTIMA_REVAL As String = String.Empty
    Private varNO_ORDEN As String = String.Empty
    Private varNO_PERIODO As String = String.Empty
    Private varPORCENTAJE_ANUAL_DEP As String = String.Empty
    Private varSALDO_MESES_DEPRE As String = String.Empty
    Private varTASA_CAMBIO_ULT_REV As String = String.Empty
    Private varUSR_ACTUALIZACION As String = String.Empty
    Private varUSUARIO_OPERACION As String = String.Empty
    Private varVALOR_ACTUAL_ACTIVO As String = String.Empty
    Private varVALOR_DEP_ACUM_ACT As String = String.Empty

    Private _valorDeRescate As Decimal = 0

    Private _tiempoDepreciacion As String = String.Empty

    Private varMostrarCampos As Boolean = False

    Dim _Pantallazo As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
    Dim captura As Graphics
    WithEvents printDocument As New PrintDocument
    Dim contador As Integer = 0

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim imagen As Drawing.Bitmap
            Dim oIcono As New Iconos

            Me.IconosMenus.Images.Clear()
            '--Copiar
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Copiar).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            '--imprimir
            imagen = oIcono.GetIcon(Iconos.TipoIcono.Imprimir).ToBitmap
            Me.IconosMenus.Images.Add(imagen)

            Me.cmdCopiar.Image = Me.IconosMenus.Images(0)
            Me.btnPrint.Image = Me.IconosMenus.Images(1)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarCombos()

        Me.CreaControlesCampos()

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)

            lblFechaInv.Enabled = False
            lblFechaInv.Visible = False
            mskFechaInv.Enabled = False
            mskFechaInv.Visible = False
            lblmsgfecha.Visible = False
            btnPrint.Visible = False

            If (Citi.Synergia.Locals.Cache.IdiomaSeleccionado = "SP") Then
                cmdCopiar.Texto = "Copiar de"
            End If

        Else
            'cambiando el texto del boton a español
            If (Citi.Synergia.Locals.Cache.IdiomaSeleccionado = "SP") Then
                btnPrint.Texto = "Imprimir"
            End If

            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Grabado = False

        If Me.SoloDeConsulta Then
            Me.cmdCancelar.Text = Me.cmdAceptar.Text
            Me.cmdAceptar.Visible = False
            Me.cmdAceptar.Enabled = False
        End If

        If Modo_Local = Modo_Alta Then
            lblMEJORA_CORRELATIVO.Visible = False
            lblTitMEJORA_CORRELATIVO.Visible = False
        End If

        '-- El código de activo no puede ser ingresado por el usuario
        Me.txtCODIGO_DE_ACTIVO.Enabled = False

        '-- El control de existencias va a ir deshabilitado
        Me.POSEE_CTRL_TF.Enabled = False

        '-- Veo si es opcional o no el proveedor
        '-- Primero le quito los [ ] si tuviera
        Me.lblTitCODIGO_PROVEEDOR.Text = Me.lblTitCODIGO_PROVEEDOR.Text.Replace("[", "").Replace("]", "")
        If Citi.Synergia.Locals.Cache.ProveedoresInvisibles Then
            '-- No se requiere proveedor
            Me.txtCODIGO_PROVEEDOR.EsRequerido = False
            Me.lblTitCODIGO_PROVEEDOR.Text = "[" & Me.lblTitCODIGO_PROVEEDOR.Text & "]"
        Else
            Me.txtCODIGO_PROVEEDOR.EsRequerido = True
        End If
        Me.lblTitCODIGO_PROVEEDOR.Visible = Me.txtCODIGO_PROVEEDOR.EsRequerido
        Me.txtCODIGO_PROVEEDOR.Visible = Me.txtCODIGO_PROVEEDOR.EsRequerido
        Me.lblnombre_proveedor.Visible = Me.txtCODIGO_PROVEEDOR.EsRequerido
    End Sub

    Private Sub LlenarCombos()
        Dim tipoDepreciacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With tipoDepreciacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("L", Citi.Synergia.Traductor.Idiomas.GetMensaje(51, "L - Linea recta")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(50, "D - Doble saldo declinante")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(52, "S - Suma de años dígitos")))
        End With
        With cboTIPO_DEPRECIACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoDepreciacion
        End With

        Dim depreciable As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With depreciable
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(116, "N - No es depreciable")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(117, "S - Si es depreciable")))
        End With
        With cboDEPRECIABLE
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = depreciable
        End With
    End Sub

    Private Sub CreaControlesCampos()
        '-- Esta rutina crea los Textbox y ComboBox que iran en el panel
        Try
            '-- Posición de labels
            Dim labelX As Integer = 17
            Dim labelY As Integer = 21
            '-- Posicion de TextBox y/o ComboBox
            Dim campoX As Integer = 250 '-- Provisionalmente
            Dim campoY As Integer = 19
            '-- Incremento
            Dim incrementoCampo As Integer = 6
            Dim incrementoLabel As Integer = 26

            '-- Controles a usar
            Dim oLabel As Label
            Dim oTexto As Citi.Synergia.UIGenerico.SynTextBox
            Dim oCombo As ComboBox

            Dim filtro As String
            If txtCODIGO_TIPO_ACTIVO.Text <> "" Then
                filtro = txtCODIGO_TIPO_ACTIVO.Text
            Else
                filtro = "X"
            End If

            '-- Limpio los controles que existan en el Panel
            Me.panCampos.Controls.Clear()

            '-- Valores a usar en los controles
            '-- Creación de etiquetas y controles
            Dim tabIndice As Integer = 1
            Dim opcional As String = String.Empty
            Dim nombreCampo As String = String.Empty
            Dim idCampo As String = String.Empty
            Dim listaValores As String = String.Empty
            Dim listaAnterior As String = String.Empty
            Dim textoCampo As String = String.Empty
            Dim band As Boolean

            Dim comandoLabels As New System.Text.StringBuilder
            With comandoLabels
                .Append("Select ")
                .Append("       CAMPO_OPCIONAL")
                .Append("     , CAMPO_TITULO")
                .Append("     , CAMPO_ID")
                .Append("     , CAMPO_LISTA_VALORES")
                .Append("  From ACT_CAMPO")
                .Append(" Where ISNULL(CODIGO_TIPO_ACTIVO, " & Scm(filtro) & ") = " & Scm(filtro))
                .Append("       Order By CAMPO_LISTA_VALORES, CAMPO_TITULO")
            End With

            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandText = comandoLabels.ToString
            End With

            Dim dataLabels As DataSet = GetDataSet(comando)

            If Not dataLabels Is Nothing Then
                If dataLabels.Tables.Count > 0 Then
                    For Each filaData As DataRow In dataLabels.Tables(0).Rows
                        band = False
                        opcional = filaData.Item(0).ToString
                        textoCampo = filaData.Item(1).ToString
                        idCampo = filaData.Item(2).ToString
                        listaValores = filaData.Item(3).ToString

                        '-- Label
                        oLabel = New Label
                        With oLabel
                            .AutoSize = True
                            .Tag = opcional
                            If opcional = "S" Then
                                .Text = "[ " & textoCampo & " ]"
                            Else
                                .Text = textoCampo
                            End If
                            .Left = labelX
                            If listaValores = "S" Then
                                If listaAnterior = "N" Then
                                    labelY += 1
                                Else
                                    labelY += 2
                                End If
                            Else
                                If listaAnterior = "S" Then
                                    labelY += 1
                                End If
                            End If
                            .Top = labelY
                        End With
                        Me.panCampos.Controls.Add(oLabel)

                        '-- Se creará un label invisible que servirá de link entre
                        '-- el que se muestra y el control con la data
                        oLabel = New Label
                        With oLabel
                            .Visible = False
                            .Tag = opcional & "-" & listaValores
                            .Text = idCampo
                            .SendToBack()
                        End With
                        Me.panCampos.Controls.Add(oLabel)

                        '-- Campo
                        If listaValores = "N" Then
                            '-- Textbox
                            oTexto = New Citi.Synergia.UIGenerico.SynTextBox
                            With oTexto
                                .Text = ""
                                .Tag = idCampo
                                .AcceptsReturn = True
                                .BackColor = Color.White
                                .BorderStyle = BorderStyle.FixedSingle
                                .Width = 580
                                .Left = campoX
                                .Top = campoY
                                .TabIndex = tabIndice
                                campoY += .Height
                                '-- Para efectos de validacion al grabar
                                If opcional = "S" Then
                                    .EsRequerido = False
                                Else
                                    .EsRequerido = True
                                End If
                                '-- Tiene que tener un máximo de 40 caracteres ingresados
                                .MaxLength = 40
                            End With
                            Me.panCampos.Controls.Add(oTexto)
                        Else
                            oCombo = New ComboBox
                            With oCombo
                                .DropDownStyle = ComboBoxStyle.DropDownList
                                .FormattingEnabled = False
                                .Width = 580
                                .Left = campoX
                                .Top = campoY
                                .TabIndex = tabIndice
                                .Tag = idCampo

                                Dim dsLista As New DataSet
                                Dim comandoLista As New SqlClient.SqlCommand
                                With comandoLista
                                    .CommandType = CommandType.Text
                                    .CommandText = "select CAMPO_VALOR, CAMPO_DESCRIPCION from ACT_CAMPOS_LV Where CAMPO_ID = " & Scm(idCampo)
                                End With
                                dsLista = GetDataSet(comandoLista)

                                Dim temp, temp1 As String
                                Dim combo As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
                                If Not dsLista Is Nothing Then
                                    If dsLista.Tables(0).Rows.Count > 0 Then
                                        For Each filaLista As DataRow In dsLista.Tables(0).Rows
                                            band = True
                                            temp = filaLista.Item("CAMPO_VALOR").ToString().Trim
                                            temp1 = filaLista.Item("CAMPO_DESCRIPCION").ToString().Trim
                                            With combo
                                                .Add(New Citi.Synergia.Entidades.CodigoDescripcion(temp, temp & " - " & temp1))
                                            End With
                                        Next
                                    Else
                                        With combo
                                            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente de Definicion")))
                                        End With
                                    End If
                                Else
                                    With combo
                                        .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente de Definicion")))
                                    End With
                                End If

                                With oCombo
                                    .ValueMember = "Codigo"
                                    .DisplayMember = "Descripcion"
                                    .DataSource = combo
                                End With

                                If band Then
                                    .Enabled = True
                                Else
                                    .Enabled = False
                                End If

                                campoY += .Height
                            End With
                            Me.panCampos.Controls.Add(oCombo)
                        End If

                        '-- Incrementos
                        campoY += incrementoCampo
                        labelY += incrementoLabel

                        listaAnterior = listaValores

                        tabIndice += 1
                    Next
                End If
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then lblMEJORA_CORRELATIVO.Text = Pop()
        If Acción And cp_POP Then txtCODIGO_DE_ACTIVO.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.ANO_PERIODO,4, 0)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.COSTO_ACUM_MNTMTO,14,2)), ")
                meteSQL(" ACTIVOS_FIJOS.ESTADO_SERVICIO, ")
                meteSQL(" ACTIVOS_FIJOS.ESTATUS, ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_BAJA_ACTIVO,101), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_OPERACION,101), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULTIMA_DEPREC,101), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULTIMA_REVAL,101), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULT_INVENTARIO,101), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULT_MANTMTO,101), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FEC_ACTUALIZACION,101) + ' ' + convert(varchar(10),ACTIVOS_FIJOS.FEC_ACTUALIZACION,108), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.MEJORA_CORRELATIVO,4, 0)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.MONTO_ULTIMA_DEPREC,13,2)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.MONTO_ULTIMA_REVAL,13,2)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.NO_ORDEN,10, 0)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.NO_PERIODO,2, 0)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.PORCENTAJE_ANUAL_DEP,8,4)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.SALDO_MESES_DEPRE,3, 0)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.TASA_CAMBIO_COMPRA,13,5)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.TASA_CAMBIO_ULT_REV,13,5)), ")
                meteSQL(" ACTIVOS_FIJOS.USR_ACTUALIZACION, ")
                meteSQL(" ACTIVOS_FIJOS.USUARIO_OPERACION, ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.VALOR_ACTUAL_ACTIVO,13,2)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.VALOR_DEP_ACUM_ACT,13,2)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.CODIGO_PROVEEDOR,10, 0)), ")
                meteSQL(" ACTIVOS_FIJOS.CODIGO_TIPO_ACTIVO, ")
                meteSQL(" ACTIVOS_FIJOS.CODIGO_DIVISION, ")
                meteSQL(" ACTIVOS_FIJOS.DESCRIP_CORTA_ACTIVO, ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.VALOR_ORIGINAL_ACTIV,13,2)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.VALOR_RESCATE_ACTIVO,13,2)), ")
                meteSQL(" ACTIVOS_FIJOS.TIPO_DEPRECIACION, ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.TIEMPO_DEPRECIACION,5, 0)), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ADQUISICION,101), ")
                meteSQL(" ACTIVOS_FIJOS.CODIGO_DE_MONEDA, ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.FRECUENCIA_MNTMTO,5, 0)), ")
                meteSQL(" ACTIVOS_FIJOS.DEPRECIABLE, ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.VALOR_ORIG_ACT_USADO,13,2)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.TASA_DEDUCIBLE_ISR,13,5)), ")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.VALOR_NO_DEDUCIBLE,13,2)), ")
                meteSQL(" ACTIVOS_FIJOS.CODIGO_DE_BARRAS, ")
                meteSQL(" ACTIVOS_FIJOS.REFERENCIA,")
                meteSQL(" ltrim(str(ACTIVOS_FIJOS.VALOR_MONEDA_LOCAL,13,2)), ")
                meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_INICIO_DEPREC,101), ")
                meteSQL(" ACTIVOS_FIJOS.CODIGO_MARCA, ")
                meteSQL(" ACTIVOS_FIJOS.CODIGO_UBICACION,")
                meteSQL(" ACTIVOS_FIJOS.RESPONSABLE_ID, ")
                meteSQL(" ACTIVOS_FIJOS.CATEGORIA_ID, ")
                meteSQL(" IsNull(ACTIVOS_FIJOS.POSEE_CTRL_TF, '1'),")
                meteSQL(" ACTIVOS_FIJOS.timestamp ")
                meteSQL("from ACTIVOS_FIJOS")
                meteSQL(" where ACTIVOS_FIJOS.CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and ACTIVOS_FIJOS.MEJORA_CORRELATIVO = " + sen(lblMEJORA_CORRELATIVO.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    _anoPeriodo = SqlData(Sqlconn, 1).ToString
                    varCOSTO_ACUM_MNTMTO = SqlData(Sqlconn, 2).ToString
                    varESTADO_SERVICIO = SqlData(Sqlconn, 3).ToString
                    varESTATUS = SqlData(Sqlconn, 4).ToString
                    varFECHA_BAJA_ACTIVO = SqlData(Sqlconn, 5).ToString
                    varFECHA_OPERACION = SqlData(Sqlconn, 6).ToString
                    varFECHA_ULTIMA_DEPREC = SqlData(Sqlconn, 7).ToString
                    varFECHA_ULTIMA_REVAL = SqlData(Sqlconn, 8).ToString
                    mskFechaInv.EscribirFecha(SqlData(Sqlconn, 9).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    varFECHA_ULT_MANTMTO = SqlData(Sqlconn, 10).ToString
                    varFEC_ACTUALIZACION = SqlData(Sqlconn, 11).ToString
                    lblMEJORA_CORRELATIVO.Text = SqlData(Sqlconn, 12).ToString
                    varMONTO_ULTIMA_DEPREC = SqlData(Sqlconn, 13).ToString
                    varMONTO_ULTIMA_REVAL = SqlData(Sqlconn, 14).ToString
                    varNO_ORDEN = SqlData(Sqlconn, 15).ToString
                    varNO_PERIODO = SqlData(Sqlconn, 16).ToString
                    varPORCENTAJE_ANUAL_DEP = SqlData(Sqlconn, 17).ToString
                    varSALDO_MESES_DEPRE = SqlData(Sqlconn, 18).ToString
                    txtTASA_CAMBIO_COMPRA.Text = SqlData(Sqlconn, 19).ToString
                    varTASA_CAMBIO_ULT_REV = SqlData(Sqlconn, 20).ToString
                    varUSR_ACTUALIZACION = SqlData(Sqlconn, 21).ToString
                    varUSUARIO_OPERACION = SqlData(Sqlconn, 22).ToString
                    varVALOR_ACTUAL_ACTIVO = SqlData(Sqlconn, 23).ToString
                    varVALOR_DEP_ACUM_ACT = SqlData(Sqlconn, 24).ToString
                    txtCODIGO_PROVEEDOR.Text = SqlData(Sqlconn, 25).ToString
                    txtCODIGO_TIPO_ACTIVO.Text = SqlData(Sqlconn, 26).ToString
                    txtCODIGO_DIVISION.Text = SqlData(Sqlconn, 27).ToString
                    txtDESCRIP_CORTA_ACTIVO.Text = Replace(SqlData(Sqlconn, 28).ToString, Chr(13) & Chr(10), "")
                    txtVALOR_ORIGINAL_ACTIV.Text = SqlData(Sqlconn, 29).ToString
                    txtVALOR_RESCATE_ACTIVO.Text = SqlData(Sqlconn, 30).ToString
                    cboTIPO_DEPRECIACION.SelectedValue = SqlData(Sqlconn, 31).ToString
                    txtTIEMPO_DEPRECIACION.Text = SqlData(Sqlconn, 32).ToString
                    Me._tiempoDepreciacion = txtTIEMPO_DEPRECIACION.GetValor()
                    mskFECHA_ADQUISICION.EscribirFecha(SqlData(Sqlconn, 33).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 34).ToString
                    txtFRECUENCIA_MNTMTO.Text = SqlData(Sqlconn, 35).ToString
                    cboDEPRECIABLE.SelectedValue = SqlData(Sqlconn, 36).ToString
                    txtVALOR_ORIG_ACT_USADO.Text = SqlData(Sqlconn, 37).ToString
                    txtTASA_DEDUCIBLE_ISR.Text = SqlData(Sqlconn, 38).ToString
                    txtVALOR_NO_DEDUCIBLE.Text = SqlData(Sqlconn, 39).ToString
                    txtCODIGO_DE_BARRAS.Text = SqlData(Sqlconn, 40).ToString
                    txtREFERENCIA.Text = SqlData(Sqlconn, 41).ToString
                    txtVALOR_MONEDA_LOCAL.Text = SqlData(Sqlconn, 42).ToString
                    mskFECHA_INICIO_DEPREC.EscribirFecha(SqlData(Sqlconn, 43).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtCODIGO_MARCA.Text = SqlData(Sqlconn, 44).ToString
                    CODIGO_UBICACION.Text = SqlData(Sqlconn, 45).ToString
                    txtRESPONSABLE_ID.Text = SqlData(Sqlconn, 46).ToString
                    txtCATEGORIA_ID.Text = SqlData(Sqlconn, 47).ToString
                    POSEE_CTRL_TF.CheckState = SqlData(Sqlconn, 48).ToString

                    MyBase.ReadTimeStamp()
                Loop

                Me.CreaControlesCampos()

                Me.LeeCampos()

                '-- Leo las descripciones
                Me.Codigos_Leave(txtCODIGO_PROVEEDOR, Nothing)
                lblDESCRIP_TIPO_ACTIVO.Text = DescripcionesDB.TipoDeActivo(txtCODIGO_TIPO_ACTIVO.Text)
                Me.Codigos_Leave(txtCODIGO_DIVISION, Nothing)
                Me.InfoMoneda(Nothing, Nothing)
                Me.Codigos_Leave(txtCODIGO_MARCA, Nothing)
                Me.Codigos_Leave(CODIGO_UBICACION, Nothing)
                Me.Codigos_Leave(txtRESPONSABLE_ID, Nothing)
                Me.Codigos_Leave(txtCATEGORIA_ID, Nothing)
            End If

            If Modo_Local = Modo_Baja Then
                MyBase.ControlesEnForma.Clear()
                MyBase.LeerControlesEnForma()
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                lblTitCODIGO_DE_ACTIVO.Enabled = False
            End If
            txtCODIGO_DE_ACTIVO.Enabled = lblTitCODIGO_DE_ACTIVO.Enabled
            txtVALOR_MONEDA_LOCAL.Enabled = lblTitCODIGO_DE_ACTIVO.Enabled
            lblTitVALOR_MONEDA_LOCAL.Enabled = lblTitCODIGO_DE_ACTIVO.Enabled

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Modo_Local = Modo_Cambio Then
            'Obtenemos el estado para habilitar o no ciertos campos
            Dim estado As String = String.Empty
            If Not String.IsNullOrEmpty(TraeDato("select ESTATUS from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))) Then
                estado = TraeDato("select ESTATUS from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text)).ToString
            End If
            If estado = "P" Then
                txtCODIGO_TIPO_ACTIVO.Enabled = True
                lblTitCODIGO_TIPO_ACTIVO.Enabled = True
                cboTIPO_DEPRECIACION.Enabled = True
                lblTitTIPO_DEPRECIACION.Enabled = True
                txtVALOR_RESCATE_ACTIVO.Enabled = True
                txtVALOR_ORIGINAL_ACTIV.Enabled = True
            Else
                txtCODIGO_DIVISION.Enabled = False
                lblTitCODIGO_DIVISION.Enabled = False
                txtVALOR_RESCATE_ACTIVO.Enabled = False
                txtVALOR_ORIGINAL_ACTIV.Enabled = False
                txtCODIGO_PROVEEDOR.Enabled = False
                lblTitCODIGO_PROVEEDOR.Enabled = False
                txtVALOR_ORIG_ACT_USADO.Enabled = False
                txtTASA_DEDUCIBLE_ISR.Enabled = False
                txtVALOR_NO_DEDUCIBLE.Enabled = False
                cboDEPRECIABLE.Enabled = False
                txtCODIGO_DE_MONEDA.Enabled = False
                lblTitCODIGO_DE_MONEDA.Enabled = False
                txtTASA_CAMBIO_COMPRA.Enabled = False
                mskFECHA_ADQUISICION.Enabled = False
            End If
        End If

        Me.ComboDepreciable_SelectedValueChanged(Nothing, Nothing)

        If varMostrarCampos Then
            MyBase.Habilitar()
            txtCODIGO_DE_ACTIVO.Enabled = False
        ElseIf Me.varESTATUS <> "P" Then
            Modo = Modo_Local
            Modo_Local = Modo_Baja
            MyBase.Habilitar()
            Modo_Local = Modo
        End If
    End Sub

    Private Sub LeeCampos()
        Try
            If Me.panCampos.Controls.Count > 0 Then
                For Each ctrl As Control In Me.panCampos.Controls
                    Dim idCampo As String = String.Empty
                    If TypeOf ctrl Is Citi.Synergia.UIGenerico.SynTextBox Or TypeOf ctrl Is ComboBox Then
                        If Not String.IsNullOrEmpty(ctrl.Tag) Then
                            idCampo = ctrl.Tag.ToString
                        End If

                        Dim comandoSQL As New System.Text.StringBuilder
                        With comandoSQL
                            .Append("Select")
                            .Append("       ACT_CAMPO.CAMPO_LISTA_VALORES")
                            .Append("     , ACT_CAMPOS_VAL.VALOR_CAMPO")
                            .Append("  From ACT_CAMPOS_VAL")
                            .Append("     , ACT_CAMPO")
                            .Append(" where ACT_CAMPOS_VAL.CODIGO_DE_ACTIVO   = " & Scm(txtCODIGO_DE_ACTIVO.Text))
                            .Append("   And ACT_CAMPOS_VAL.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))
                            .Append("   And ACT_CAMPOS_VAL.CAMPO_ID           = " & Scm(idCampo))
                            .Append("   And ACT_CAMPO.CAMPO_ID                = ACT_CAMPOS_VAL.CAMPO_ID")
                            .Append("       Order by ACT_CAMPO.CAMPO_LISTA_VALORES,ACT_CAMPOS_VAL.CAMPO_ID")
                        End With
                        Dim comando As New SqlClient.SqlCommand
                        With comando
                            .CommandText = comandoSQL.ToString()
                        End With

                        Dim data As DataSet = GetDataSet(comando)

                        If Not data Is Nothing Then
                            If data.Tables.Count > 0 Then
                                For Each filaData As DataRow In data.Tables(0).Rows
                                    Dim lista As String = String.Empty
                                    Dim campoValor As String = String.Empty

                                    lista = filaData.Item(0).ToString
                                    campoValor = filaData.Item(1).ToString

                                    If TypeOf ctrl Is ComboBox And lista = "S" Then
                                        Dim cboBox As ComboBox = ctrl

                                        If cboBox.Enabled Then
                                            If campoValor.Trim.Length > 0 Then
                                                cboBox.SelectedValue = campoValor
                                            Else
                                                cboBox.SelectedIndex = -1
                                            End If
                                        End If
                                    End If

                                    If TypeOf ctrl Is Citi.Synergia.UIGenerico.SynTextBox And lista = "N" Then
                                        Dim ctrlTexto As Citi.Synergia.UIGenerico.SynTextBox = ctrl
                                        If ctrlTexto.Text.Trim = "" Then
                                            ctrlTexto.Text = campoValor
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()

                '-- Leo las descripciones
                Me.Codigos_Leave(txtCODIGO_PROVEEDOR, Nothing)
                lblDESCRIP_TIPO_ACTIVO.Text = DescripcionesDB.TipoDeActivo(txtCODIGO_TIPO_ACTIVO.Text)
                Me.Codigos_Leave(txtCODIGO_DIVISION, Nothing)
                Me.InfoMoneda(Nothing, Nothing)
                Me.Codigos_Leave(txtCODIGO_MARCA, Nothing)
                Me.Codigos_Leave(CODIGO_UBICACION, Nothing)
                Me.Codigos_Leave(txtRESPONSABLE_ID, Nothing)
                Me.Codigos_Leave(txtCATEGORIA_ID, Nothing)
                Me._tiempoDepreciacion = String.Empty
                Me.ComboDepreciable_SelectedValueChanged(Nothing, Nothing)

                Me.CreaControlesCampos()

                Me.txtCODIGO_DE_ACTIVO.Enabled = False
                Me.POSEE_CTRL_TF.Enabled = False
                txtCODIGO_PROVEEDOR.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                lblMEJORA_CORRELATIVO.Text = Pop()
                txtCODIGO_DE_ACTIVO.Text = Pop()
                Me.Leer()
                Me.txtCODIGO_DE_ACTIVO.Enabled = False
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Function ArmarInsert() As String
        Dim V As String = String.Empty

        If String.IsNullOrWhiteSpace(varUSR_ACTUALIZACION) Then
            varUSR_ACTUALIZACION = Citi.Synergia.Locals.Cache.UsuarioSSO
        End If

        If String.IsNullOrWhiteSpace(varUSUARIO_OPERACION) Then
            varUSUARIO_OPERACION = Citi.Synergia.Locals.Cache.UsuarioSSO
        End If

        V = V & "  @CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text)
        V = V & ", @MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text)
        V = V & ", @CODIGO_PROVEEDOR = " & sen(txtCODIGO_PROVEEDOR.GetValor())
        V = V & ", @CODIGO_TIPO_ACTIVO = " & Scm(txtCODIGO_TIPO_ACTIVO.Text)
        V = V & ", @CODIGO_DIVISION = " & Scm(txtCODIGO_DIVISION.Text)
        V = V & ", @DESCRIP_CORTA_ACTIVO = " & Scm(txtDESCRIP_CORTA_ACTIVO.Text)
        V = V & ", @VALOR_ORIGINAL_ACTIV = " & sen(txtVALOR_ORIGINAL_ACTIV.GetValor())
        V = V & ", @VALOR_ACTUAL_ACTIVO = " & sen(varVALOR_ACTUAL_ACTIVO)
        V = V & ", @VALOR_RESCATE_ACTIVO = " & sen(txtVALOR_RESCATE_ACTIVO.GetValor())
        V = V & ", @TIPO_DEPRECIACION = " & Scm(cboTIPO_DEPRECIACION.SelectedValue.ToString)
        V = V & ", @TIEMPO_DEPRECIACION = " & sen(txtTIEMPO_DEPRECIACION.GetValor())
        V = V & ", @PORCENTAJE_ANUAL_DEP = " & sen(varPORCENTAJE_ANUAL_DEP)
        V = V & ", @FECHA_ADQUISICION = " & Scm(mskFECHA_ADQUISICION.TextMMDDYYYY)
        V = V & ", @FECHA_BAJA_ACTIVO = " & Scm(varFECHA_BAJA_ACTIVO)
        V = V & ", @VALOR_DEP_ACUM_ACT = " & sen(varVALOR_DEP_ACUM_ACT)
        V = V & ", @MONTO_ULTIMA_REVAL = " & sen(varMONTO_ULTIMA_REVAL)
        V = V & ", @FECHA_ULTIMA_REVAL = " & Scm(varFECHA_ULTIMA_REVAL)
        V = V & ", @MONTO_ULTIMA_DEPREC = " & sen(varMONTO_ULTIMA_DEPREC)
        V = V & ", @FECHA_ULTIMA_DEPREC = " & Scm(varFECHA_ULTIMA_DEPREC)
        V = V & ", @USUARIO_OPERACION = " & Scm(varUSUARIO_OPERACION)
        V = V & ", @FECHA_OPERACION = " & Scm(varFECHA_OPERACION)
        V = V & ", @ESTATUS = " & Scm(varESTATUS)
        V = V & ", @TASA_CAMBIO_COMPRA = " & sen(txtTASA_CAMBIO_COMPRA.GetValor())
        V = V & ", @TASA_CAMBIO_ULT_REV = " & sen(varTASA_CAMBIO_ULT_REV)
        V = V & ", @CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text)
        If mskFechaInv.Text = "__/__/____" Or mskFechaInv.Text = "" Then
            V = V & ", @FECHA_ULT_INVENTARIO = " & Scm(varFECHA_ULT_INVENTARIO)
        Else
            V = V & ", @FECHA_ULT_INVENTARIO = " & Scm(mskFechaInv.TextMMDDYYYY)
        End If
        V = V & ", @NO_ORDEN = " & sen(varNO_ORDEN)
        V = V & ", @USR_ACTUALIZACION = " & Scm(varUSR_ACTUALIZACION)
        V = V & ", @FEC_ACTUALIZACION = " & Scm(varFEC_ACTUALIZACION)
        V = V & ", @SALDO_MESES_DEPRE = " & sen(varSALDO_MESES_DEPRE)
        V = V & ", @FECHA_ULT_MANTMTO = " & Scm(varFECHA_ULT_MANTMTO)
        V = V & ", @COSTO_ACUM_MNTMTO = " & sen(varCOSTO_ACUM_MNTMTO)
        V = V & ", @FRECUENCIA_MNTMTO = " & sen(txtFRECUENCIA_MNTMTO.GetValor())
        V = V & ", @ANO_PERIODO = " & sen(_anoPeriodo)
        V = V & ", @NO_PERIODO = " & sen(varNO_PERIODO)
        V = V & ", @DEPRECIABLE = " & Scm(cboDEPRECIABLE.SelectedValue.ToString)
        V = V & ", @ESTADO_SERVICIO = " & Scm(varESTADO_SERVICIO)
        V = V & ", @VALOR_ORIG_ACT_USADO = " & sen(txtVALOR_ORIG_ACT_USADO.GetValor())
        V = V & ", @TASA_DEDUCIBLE_ISR = " & sen(txtTASA_DEDUCIBLE_ISR.GetValor())
        V = V & ", @VALOR_NO_DEDUCIBLE = " & sen(txtVALOR_NO_DEDUCIBLE.GetValor())
        V = V & ", @CODIGO_DE_BARRAS = " & Scm(txtCODIGO_DE_BARRAS.Text)
        V = V & ", @REFERENCIA = " & Scm(txtREFERENCIA.Text)
        V = V & ", @VALOR_MONEDA_LOCAL = " & sen(txtVALOR_MONEDA_LOCAL.GetValor())
        If mskFECHA_INICIO_DEPREC.Text = "" Or mskFECHA_INICIO_DEPREC.Text = "__/__/____" Then
            V = V & ", @FECHA_INICIO_DEPREC = " & Scm(mskFECHA_ADQUISICION.TextMMDDYYYY)
        Else
            V = V & ", @FECHA_INICIO_DEPREC = " & Scm(mskFECHA_INICIO_DEPREC.TextMMDDYYYY)
        End If
        V = V & ", @CODIGO_MARCA = " & Scm(txtCODIGO_MARCA.Text)
        V = V & ", @CODIGO_UBICACION = " & Scm(CODIGO_UBICACION.Text)
        V = V & ", @RESPONSABLE_ID = " & Scm(txtRESPONSABLE_ID.Text)
        V = V & ", @CATEGORIA_ID = " & Scm(txtCATEGORIA_ID.Text)
        V = V & ", @POSEE_CTRL_TF = " & Scm(CStr(POSEE_CTRL_TF.CheckState))

        Return V
    End Function

    Private Sub GrabarCampos()
        If Me.panCampos.Controls.Count > 0 Then
            Dim v As String = String.Empty

            '-- Comienzo la transaccion
            Dim adconexion As SqlClient.SqlConnection = Citi.Synergia.Locals.Cache.ConexionSQL

            Dim transaccion As SqlClient.SqlTransaction = adconexion.BeginTransaction

            Dim comando As New SqlClient.SqlCommand
            With comando
                .Connection = adconexion
                .Transaction = transaccion
            End With

            Try
                With comando
                    .CommandText = "Delete ACT_CAMPOS_VAL where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text)
                    .ExecuteNonQuery()
                End With

                'Si es BAJA no procesamos los detalles ya que aqui se genero el delete masivo
                If Modo_Local = Modo_Baja Then
                    transaccion.Commit()
                    Return
                End If

                For Each ctrl As Control In Me.panCampos.Controls
                    If TypeOf ctrl Is Citi.Synergia.UIGenerico.SynTextBox Or TypeOf ctrl Is ComboBox AndAlso Not ctrl.Tag Is Nothing Then
                        v = ""
                        v = v & "  @CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text)
                        v = v & ", @MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text)
                        v = v & ", @CAMPO_ID = " & Scm(ctrl.Tag.ToString)

                        Dim valor As String = String.Empty

                        If TypeOf ctrl Is Citi.Synergia.UIGenerico.SynTextBox Then
                            valor = ctrl.Text
                        Else
                            Dim cboBox As ComboBox = ctrl
                            If cboBox.Enabled Then
                                If cboBox.SelectedValue Is Nothing Then
                                    Dim codigo As List(Of Citi.Synergia.Entidades.CodigoDescripcion) = cboBox.DataSource
                                    valor = codigo(0).Codigo
                                Else
                                    If cboBox.SelectedValue.ToString <> "" Then
                                        valor = cboBox.SelectedValue.ToString
                                    End If
                                End If
                            End If
                        End If
                        v = v & ", @VALOR_CAMPO = " & Scm(valor)
                        Modo = Modo_Alta

                        Dim cmd As String = String.Empty

                        cmd = "execute sp_Alta_ACT_CAMPOS_VAL " & PoneNull(v)

                        Dim resultado As Integer = 0
                        With comando
                            .CommandText = cmd
                            resultado = .ExecuteNonQuery()
                        End With

                        If resultado <> 1 Then
                            transaccion.Rollback()
                            Return
                        End If
                    End If
                Next

                transaccion.Commit()

            Catch errSQL As SqlClient.SqlException
                transaccion.Rollback()
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                transaccion.Rollback()
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function CalculaValorMonedaLocal() As Boolean
        Dim retorno As Boolean = True

        ' Asigna cero al  valor moneda local, si vienen en null
        If txtVALOR_MONEDA_LOCAL.Text = "" Then
            txtVALOR_MONEDA_LOCAL.Text = "0.00"
        End If

        ' Para calcular valor, los campos no pueden ser null, de lo contrario no se calcula.
        If txtVALOR_ORIGINAL_ACTIV.Text = "" Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(216, "Ingrese valor original quetzales."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVALOR_ORIGINAL_ACTIV.Focus()
            retorno = False
        End If
        If Val(txtTASA_CAMBIO_COMPRA.Text) = 0 Then
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(217, "Ingrese tasa de compra."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTASA_CAMBIO_COMPRA.Focus()
            retorno = False
        End If
        If txtVALOR_ORIGINAL_ACTIV.Text <> "" And txtTASA_CAMBIO_COMPRA.Text <> "" And txtVALOR_RESCATE_ACTIVO.Text <> "" Then
            txtVALOR_MONEDA_LOCAL.Text = String.Format("{0:0,0.00}", ((CDbl(txtVALOR_ORIGINAL_ACTIV.Text) - CDbl(txtVALOR_RESCATE_ACTIVO.Text)) / CDbl(txtTASA_CAMBIO_COMPRA.Text)))
        End If

        Return retorno
    End Function

    Private Sub CalculaCodigoActivo(ByRef tipoDeActivo As String)
        Dim intCorrelativo As Integer
        intCorrelativo = 0

        txtCODIGO_DE_ACTIVO.Text = ""

        '-- Se le puso +2 porque el código del activo está dividido por un guión (-)
        Dim posicionInicial As Integer = tipoDeActivo.Trim.Length + 2
        If Not String.IsNullOrEmpty(TraeDato("Select isnull(max(convert(int,substring(CODIGO_DE_ACTIVO," & posicionInicial.ToString & ",6) ) ),0) + 1 From ACTIVOS_FIJOS where CODIGO_TIPO_ACTIVO = " + Scm(tipoDeActivo))) Then
            intCorrelativo = CType(TraeDato("Select isnull(max(convert(int,substring(CODIGO_DE_ACTIVO," & posicionInicial.ToString & ",6) ) ),0) + 1 From ACTIVOS_FIJOS where CODIGO_TIPO_ACTIVO = " + Scm(tipoDeActivo)), Integer)
        End If

        txtCODIGO_DE_ACTIVO.Text = tipoDeActivo.Trim & "-" & String.Format("{0:00000}", intCorrelativo)
    End Sub

    Private Sub CodigoTipoActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_TIPO_ACTIVO.Leave
        Me.CreaControlesCampos()

        Try
            Dim comandoSQL As New System.Text.StringBuilder()
            With comandoSQL
                .Append("Select DESCRIP_TIPO_ACTIVO")
                .Append("     , TIPO_DEPRECIACION")
                .Append("     , TIEMPO_DEPRECIACION")
                .Append("     , IsNull(PORCENTAJE_PARA_RESCATE, 0) As PORCENTAJE_PARA_RESCATE")
                .Append("  From TIPOS_DE_ACTIVOS")
                .Append(" Where CODIGO_TIPO_ACTIVO = @CodigoTipoActivo")
            End With
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandText = comandoSQL.ToString()
                .Parameters.Add("@CodigoTipoActivo", SqlDbType.Char, 7).Value = txtCODIGO_TIPO_ACTIVO.Text
            End With
            Dim data As DataSet = GetDataSet(comando)
            If Not data Is Nothing Then
                If data.Tables.Count > 0 AndAlso data.Tables(0).Rows.Count > 0 Then
                    Dim fila As DataRow = data.Tables(0).Rows(0)
                    lblDESCRIP_TIPO_ACTIVO.Text = fila.Item("DESCRIP_TIPO_ACTIVO").ToString
                    cboTIPO_DEPRECIACION.SelectedValue = fila.Item("TIPO_DEPRECIACION").ToString
                    txtTIEMPO_DEPRECIACION.Text = fila.Item("TIEMPO_DEPRECIACION").ToString
                    _valorDeRescate = fila.Item("PORCENTAJE_PARA_RESCATE").ToString
                End If
            End If

            If Me._tiempoDepreciacion = "" Then
                Me._tiempoDepreciacion = txtTIEMPO_DEPRECIACION.GetValor()
            End If

            lblDESCRIP_TIPO_ACTIVO.Text = DescripcionesDB.TipoDeActivo(txtCODIGO_TIPO_ACTIVO.Text)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Codigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_PROVEEDOR.Leave, txtCODIGO_DIVISION.Leave, txtCODIGO_MARCA.Leave, CODIGO_UBICACION.Leave, txtRESPONSABLE_ID.Leave, txtCATEGORIA_ID.Leave
        Select Case sender.Name
            Case "txtCODIGO_PROVEEDOR"
                lblnombre_proveedor.Text = DescripcionesDB.Proveedor(sender.Text)
            Case "txtCODIGO_DIVISION"
                lblDESCRIPCION_DIVISION.Text = DescripcionesDB.Division(sender.Text)
            Case "txtCODIGO_MARCA"
                lblDESCRIPCION_MARCA.Text = DescripcionesDB.Marcas(sender.Text)
            Case "CODIGO_UBICACION"
                desCODIGO_UBICACION.Text = DescripcionesDB.UbicacionActivo(sender.Text)
            Case "txtRESPONSABLE_ID"
                lblNOMBRE_USUAL.Text = DescripcionesDB.NombreUsualResponsable(sender.Text)
            Case "txtCATEGORIA_ID"
                lblCATEGORIA_DESC.Text = DescripcionesDB.Categoria(sender.Text)
        End Select
    End Sub

    Private Sub CodigosConsultas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_TIPO_ACTIVO.DoubleClick, lblTitCODIGO_DIVISION.DoubleClick, lblTitCODIGO_DE_MONEDA.DoubleClick, lblTitCODIGO_MARCA.DoubleClick, lblCODIGO_UBICACION.DoubleClick, lblTitRESPONSABLE_ID.DoubleClick, lblTitCATEGORIA_ID.DoubleClick
        Select Case sender.Name
            Case "lblTitCODIGO_TIPO_ACTIVO"
                txtCODIGO_TIPO_ACTIVO.GenerarConsulta()
            Case "lblTitCODIGO_DIVISION"
                txtCODIGO_DIVISION.GenerarConsulta()
            Case "lblTitCODIGO_DE_MONEDA"
                txtCODIGO_DE_MONEDA.GenerarConsulta()
            Case "lblTitCODIGO_MARCA"
                txtCODIGO_MARCA.GenerarConsulta()
            Case "lblCODIGO_UBICACION"
                CODIGO_UBICACION.GenerarConsulta()
            Case "lblTitRESPONSABLE_ID"
                txtRESPONSABLE_ID.GenerarConsulta()
            Case "lblTitCATEGORIA_ID"
                txtCATEGORIA_ID.GenerarConsulta()
        End Select
    End Sub

    Private Sub ListaProveedores(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_PROVEEDOR.DoubleClick, lblTitCODIGO_PROVEEDOR.DoubleClick
        Dim codigoProveedor As String = String.Empty
        Dim frmLista As New PROVEC01
        With frmLista
            .ShowDialog()
            codigoProveedor = .CodigoProveedor
            .Dispose()
        End With
        If codigoProveedor <> "" Then
            txtCODIGO_PROVEEDOR.Text = codigoProveedor
        End If
    End Sub

    Private Sub CodigoProveedor_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCODIGO_PROVEEDOR.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.ListaProveedores(Nothing, Nothing)
        End If
    End Sub

    Private Sub InfoMoneda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DE_MONEDA.Leave
        lblDESCRIPCION_MONEDA.Text = ""
        If txtCODIGO_DE_MONEDA.Text <> "" Then
            Try
                lblDESCRIPCION_MONEDA.Text = DescripcionesDB.Monedas(txtCODIGO_DE_MONEDA.Text)

                '-- Tasa de cambio moneda.
                Dim comando As New SqlClient.SqlCommand
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Obtiene_tasa_cambio_de_moneda"
                    .Parameters.Add("@CODIGO_DE_MONEDA", SqlDbType.Char, 5).Value = txtCODIGO_DE_MONEDA.Text
                    .Parameters.Add("@TASA_CAMBIO", SqlDbType.Float).Value = 0
                    .Parameters(0).Direction = ParameterDirection.Input
                    .Parameters(1).Direction = ParameterDirection.Output
                End With

                Dim parametro As SqlClient.SqlParameter
                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@CODIGO_DE_MONEDA"
                    .Direction = ParameterDirection.Input
                    .SqlDbType = SqlDbType.Char
                    .Size = 5
                    .Value = txtCODIGO_DE_MONEDA.Text
                End With
                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@TASA_CAMBIO"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Float
                    .Value = 0
                End With

                EjecutarComando(comando)

                If Not IsDBNull(comando.Parameters(1).Value) Then
                    Dim resultado As Integer = CType(comando.Parameters(1).Value, Integer)
                    txtTASA_CAMBIO_COMPRA.Text = String.Format("{0:0.00000}", resultado)

                    Dim codigoMoneda As String = DescripcionesDB.ParametrosGeneralesCodigoMoneda("PA")
                    If codigoMoneda.Trim() = txtCODIGO_DE_MONEDA.ToString().Trim() Then
                        txtTASA_CAMBIO_COMPRA.Enabled = False
                    Else
                        txtTASA_CAMBIO_COMPRA.Enabled = True
                    End If

                    Dim bolNada As Boolean = CalculaValorMonedaLocal()
                End If

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ComboDepreciable_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDEPRECIABLE.SelectedValueChanged
        If cboDEPRECIABLE.SelectedValue = "N" Then
            txtTIEMPO_DEPRECIACION.Text = Me._tiempoDepreciacion
            txtTIEMPO_DEPRECIACION.Enabled = False
            lblTitTIEMPO_DEPRECIACION.Enabled = False
        End If
        If cboDEPRECIABLE.SelectedValue = "S" Then
            txtTIEMPO_DEPRECIACION.Enabled = Citi.Synergia.HelperClient.UtilsSG.TieneAcceso(Me.txtTIEMPO_DEPRECIACION.Tag.ToString)
            lblTitTIEMPO_DEPRECIACION.Enabled = txtTIEMPO_DEPRECIACION.Enabled
        End If

        If Me.Modo_Local = Modo_Baja Then
            txtTIEMPO_DEPRECIACION.Enabled = False
            lblTitTIEMPO_DEPRECIACION.Enabled = False
        End If
    End Sub

    Private Sub ValorOriginalActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVALOR_ORIGINAL_ACTIV.Leave
        If txtVALOR_ORIGINAL_ACTIV.Text = "" Then
            txtVALOR_RESCATE_ACTIVO.Text = "0"
        End If

        Dim valorOriginal As Decimal = 0
        Decimal.TryParse(txtVALOR_ORIGINAL_ACTIV.Text, valorOriginal)
        valorOriginal = (valorOriginal / 100) * _valorDeRescate
        txtVALOR_RESCATE_ACTIVO.Text = String.Format("{0:0,0.00}", valorOriginal)
    End Sub

    Private Sub ValorOriginalUsado_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVALOR_ORIG_ACT_USADO.Leave
        If txtVALOR_ORIG_ACT_USADO.Text <> "0.00" Then
            txtTASA_DEDUCIBLE_ISR.Enabled = True
            txtVALOR_NO_DEDUCIBLE.Text = txtVALOR_ORIG_ACT_USADO.Text
        Else
            txtTASA_DEDUCIBLE_ISR.Text = "0.00000"
            txtTASA_DEDUCIBLE_ISR.Enabled = False
        End If
    End Sub

    Private Sub TasaDeducibleISR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTASA_DEDUCIBLE_ISR.Leave
        Dim varVALOR_DEDUCIBLE As Double
        If txtTASA_DEDUCIBLE_ISR.Text <> "" And txtVALOR_ORIG_ACT_USADO.Text <> "" Then
            If txtVALOR_ORIG_ACT_USADO.Text = "0.00" Then
                txtVALOR_NO_DEDUCIBLE.Text = "0.00"
            Else
                If txtTASA_DEDUCIBLE_ISR.Text = "0.00000" Then
                    varVALOR_DEDUCIBLE = 0
                Else
                    varVALOR_DEDUCIBLE = CType(txtVALOR_ORIG_ACT_USADO.Text, Double) * (CType(txtTASA_DEDUCIBLE_ISR.Text, Double) / 100)
                End If
                txtVALOR_NO_DEDUCIBLE.Text = String.Format("{0:0,0.00}", (CType(txtVALOR_ORIG_ACT_USADO.Text, Double) - varVALOR_DEDUCIBLE))
            End If
        End If
    End Sub

    Private Sub Folder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folder.SelectedIndexChanged
        If Folder.SelectedIndex = 1 Then
            Me.LeeCampos()
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        System.Windows.Forms.Application.DoEvents()

        If CalculaValorMonedaLocal() = False Then
            Return
        End If

        If Me.Modo_Local <> Modo_Baja Then
            If MyBase.ValidarCampos(TabGenerales) = False Then
                Folder.SelectedIndex = 0
                Return
            End If

            MyBase.ErrorCampos.SetError(Me.cboTIPO_DEPRECIACION, Nothing)
            If cboTIPO_DEPRECIACION.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboTIPO_DEPRECIACION, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 0
                Return
            End If

            MyBase.ErrorCampos.SetError(Me.cboDEPRECIABLE, Nothing)
            If cboDEPRECIABLE.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboDEPRECIABLE, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 0
                Return
            End If

            ''-- Cambio 2011, si es alta se va a calcular automáticamente el código y no se puede modificar.
            ''Se calcula el codigo de activo si el codigo ingresado es punto (.)'
            'If txtCODIGO_DE_ACTIVO.Text.Trim = "." Then
            '    CalculaCodigoActivo((txtCODIGO_TIPO_ACTIVO.Text))
            'End If

            If Modo_Local = Modo_Alta Then
                Me.CalculaCodigoActivo((txtCODIGO_TIPO_ACTIVO.Text))

                lblMEJORA_CORRELATIVO.Text = "0"

                'Al agregar un activo fijo, confirmamos al tener valor original CERO
                Dim valorOriginal As Decimal = 0
                If txtVALOR_ORIGINAL_ACTIV.Text <> "" Then
                    valorOriginal = CType(txtVALOR_ORIGINAL_ACTIV.Text, Decimal)
                End If
                If valorOriginal = 0 Then
                    Dim mensaje As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(319, "Se detectó que no ha especificado valor original del activo, esto implica que no contabilizará la información sino solo es control físico. ¿ESTA SEGURO MANEJAR ESTE ACTIVO DE ESA FORMA?")
                    If Citi.Synergia.HelperClient.Utils.CITIMsgBox(mensaje, Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoConfirmacion) <> Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Aceptar Then
                        Folder.SelectedIndex = 0
                        txtVALOR_ORIGINAL_ACTIV.Focus()
                        Return
                    End If
                    'Si no tiene valor original, obligamos a que NO SEA DEPRECIABLE
                    If cboDEPRECIABLE.SelectedValue <> "N" Then
                        Dim mensajeDepre As String = Citi.Synergia.Traductor.Idiomas.GetMensaje(320, "Cuando el activo se ingresa sin valor original debe indicar NO DEPRECIABLE pues no hay valores registrados.")
                        Citi.Synergia.HelperClient.Utils.CITIMsgBox(mensajeDepre, Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoError)
                        Folder.SelectedIndex = 0
                        cboDEPRECIABLE.Focus()
                        Return
                    End If
                End If
            End If

            '-- Validacion Campos
            '-- Valido los SynTextBox
            If MyBase.ValidarCampos(Me.panCampos) = False Then
                Folder.SelectedIndex = 1
                Return
            End If
            '-- Valido los ComboBox
            '-- Primero busco los labels invisibles que indican si son opcionales (Tag) y cuál es el id (Text)
            For Each ctrl As Control In Me.panCampos.Controls
                If TypeOf ctrl Is Label Then
                    Dim lblInvisible As Label = ctrl
                    If lblInvisible.Visible = False Then
                        If lblInvisible.Tag.ToString = "N-S" Then
                            '-- Busco el ComboBox que de tag tenga el id igual
                            For Each cboBox As Control In Me.panCampos.Controls
                                If TypeOf cboBox Is System.Windows.Forms.ComboBox Then
                                    If lblInvisible.Text = cboBox.Tag.ToString Then
                                        '-- Si el combo está disponible
                                        If cboBox.Enabled Then
                                            Dim combo As System.Windows.Forms.ComboBox = cboBox

                                            MyBase.ErrorCampos.SetError(cboBox, Nothing)
                                            If Not combo.SelectedValue Is Nothing Then
                                                If combo.SelectedValue.ToString = "" Then
                                                    MyBase.ErrorCampos.SetError(cboBox, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                                                    Folder.SelectedIndex = 1
                                                    Return
                                                End If
                                            End If
                                        End If

                                        '-- Salgo del ciclo porque ya lo encontró
                                        Exit For
                                    End If
                                End If
                            Next
                        End If
                    End If
                End If
            Next
        End If

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        Try
            If sp("ACTIVOS_FIJOS", Me.ArmarInsert()) Then
                Grabado = True
                HubieronCambios = True

                Me.GrabarCampos()

                'Actualizamos informacion general
                meteSQL("Update ACTIVOS_FIJOS_GEN")
                meteSQL("   Set UBICACION_ACTIVO   = " & Scm(desCODIGO_UBICACION.Text))
                meteSQL("     , RESPONSABLE_ACTIVO = " & Scm(lblNOMBRE_USUAL.Text))
                meteSQL(" Where CODIGO_DE_ACTIVO   = " & Scm(txtCODIGO_DE_ACTIVO.Text))
                meteSQL("   And MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))

                EjecutaSQL("") 'No monitorea error pq puede ser que no exista

                Me.Siguiente()
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdCopiar_Click(sender As Object, e As EventArgs) Handles cmdCopiar.Click
        With txtCODIGO_DE_ACTIVO
            .NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
            .GenerarConsulta()
            varMostrarCampos = False

            '-- Si selecciono un activo
            If .CodigosRetorno.Count > 0 Then
                .Text = .CodigosRetorno.Item(0)
                lblMEJORA_CORRELATIVO.Text = .CodigosRetorno.Item(1)
                Modo_Local = Modo_Cambio
                varMostrarCampos = True
                Leer()
                Modo_Local = Modo_Alta
            End If
            .NombreDeConsulta = Nothing
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        GenerarPantallazo()

        'mostrando msgbox
        Dim mensaje As String = String.Empty
        If (Citi.Synergia.Locals.Cache.IdiomaSeleccionado = "SP") Then
            mensaje = "¿Desea imprimir la pantalla de campos especiales?"
        Else
            mensaje = "Do you want to print special fields screen?"
        End If

        If Citi.Synergia.HelperClient.Utils.CITIMsgBox(mensaje, Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoConfirmacion) = Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Aceptar Then
            Folder.SelectTab(1)
            TemporizadorEspera.Enabled = True
        End If


    End Sub

    Private Sub GenerarPantallazo()
        captura = Graphics.FromImage(_Pantallazo)
        Dim sz As New System.Drawing.Size(Me.Bounds.Width - 20, Me.Bounds.Height - 15)
        captura.CopyFromScreen(Me.Bounds.X + 10, Me.Bounds.Y + 5, 0, 0, sz)
        printDocument = New PrintDocument()

        ImpresoraDialog.Document = printDocument

        ImpresoraDialog.AllowSomePages = True
        ImpresoraDialog.AllowSelection = True

        If ImpresoraDialog.ShowDialog() = DialogResult.OK Then
            printDocument.DefaultPageSettings.Landscape = True
            printDocument.Print()
        End If
    End Sub

    Private Sub ImprimirDocumento(sender As Object, e As PrintPageEventArgs) Handles printDocument.PrintPage
        e.Graphics.DrawImage(_Pantallazo, 0, 0, _Pantallazo.Width, _Pantallazo.Height)
    End Sub

    Private Sub TemporizadorEspera_Tick(sender As Object, e As EventArgs) Handles TemporizadorEspera.Tick

        If contador = 4 Then
            TemporizadorEspera.Enabled = False
            GenerarPantallazo()
            contador = 0
            Return
        End If

        contador += 1
    End Sub

End Class