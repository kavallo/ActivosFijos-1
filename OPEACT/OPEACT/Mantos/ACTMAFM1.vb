Imports Citi.Synergia.HelperClient

Public Class ACTMAFM1
    Private varANO_PERIODO As String = String.Empty
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
    Private CORRELATIVO As String = String.Empty

    Private _valorDeRescate As Decimal = 0

    Private _tiempoDepreciacion As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        LeerPos(Me, "ACTMAFM1")
        LeerIco(Me)

        MyBase.Limpiar()

        Me.LlenarCombos()

        Me.CreaControlesCampos()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        'Se limpia el correlativo para que genera uno nuevo
        'en el procedimiento almacenado de alta
        CORRELATIVO = lblMEJORA_CORRELATIVO.Text
        lblMEJORA_CORRELATIVO.Text = ""
        Grabado = False

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
                            '.Width = 210
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
                        End With
                        Me.panCampos.Controls.Add(oTexto)
                    Else
                        oCombo = New ComboBox
                        With oCombo
                            .DropDownStyle = ComboBoxStyle.DropDownList
                            .FormattingEnabled = False
                            '.Width = 210
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
                                        temp = filaLista.Item("CAMPO_VALOR").ToString
                                        temp1 = filaLista.Item("CAMPO_DESCRIPCION").ToString
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
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then lblMEJORA_CORRELATIVO.Text = Pop()
        If Acción And cp_POP Then txtCODIGO_DE_ACTIVO.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL(" SELECT LTRIM(STR(ACTIVOS_FIJOS.ANO_PERIODO, 4, 0)) AS Expr1")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.COSTO_ACUM_MNTMTO, 14, 2)) AS Expr2")
                meteSQL("      , ACTIVOS_FIJOS.ESTADO_SERVICIO")
                meteSQL("      , ACTIVOS_FIJOS.ESTATUS")
                meteSQL("      , convert(varchar(10),ACTIVOS_FIJOS.FECHA_BAJA_ACTIVO,101)")
                meteSQL("      , convert(varchar(10),ACTIVOS_FIJOS.FECHA_OPERACION,101)")
                meteSQL("      , convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULTIMA_DEPREC,101)")
                meteSQL("      , convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULTIMA_REVAL,101)")
                meteSQL("      , convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULT_INVENTARIO,101)")
                meteSQL("      , convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULT_MANTMTO,101)")
                meteSQL("      , convert(varchar(10),ACTIVOS_FIJOS.FEC_ACTUALIZACION,101)")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.MEJORA_CORRELATIVO, 4, 0)) AS Expr3")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.MONTO_ULTIMA_DEPREC, 13, 2)) AS Expr4")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.MONTO_ULTIMA_REVAL, 13, 2)) AS Expr5")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.NO_ORDEN, 10, 0)) AS Expr6")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.NO_PERIODO, 2, 0)) AS Expr7")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.PORCENTAJE_ANUAL_DEP, 8, 4)) AS Expr8")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.SALDO_MESES_DEPRE, 3, 0)) AS Expr9")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.TASA_CAMBIO_COMPRA, 13, 5)) AS Expr10")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.TASA_CAMBIO_ULT_REV, 13, 5)) AS Expr11")
                meteSQL("      , ACTIVOS_FIJOS.USR_ACTUALIZACION")
                meteSQL("      , ACTIVOS_FIJOS.USUARIO_OPERACION")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.VALOR_ACTUAL_ACTIVO, 13, 2)) AS Expr12")
                meteSQL("      , LTRIM(STR(ACTIVOS_FIJOS.VALOR_DEP_ACUM_ACT, 13, 2)) AS Expr13")
                meteSQL("      , LTRIM(STR(PROVEEDORES.CODIGO_PROVEEDOR, 10, 0)) AS Expr14")
                meteSQL("      , PROVEEDORES.nombre_proveedor")
                meteSQL("      , TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO")
                meteSQL("      , TIPOS_DE_ACTIVOS.DESCRIP_TIPO_ACTIVO")
                meteSQL("      , DIVISIONES.CODIGO_DIVISION")
                meteSQL("      , DIVISIONES.DESCRIPCION_DIVISION")
                meteSQL("      , ACTIVOS_FIJOS.DESCRIP_CORTA_ACTIVO")
                meteSQL("      , Convert(Varchar, ACTIVOS_FIJOS.VALOR_ORIGINAL_ACTIV, 1) AS Expr15")
                meteSQL("      , Convert(Varchar, ACTIVOS_FIJOS.VALOR_RESCATE_ACTIVO, 1) AS Expr16")
                meteSQL("      , ACTIVOS_FIJOS.TIPO_DEPRECIACION")
                meteSQL("      , Convert(Varchar, ACTIVOS_FIJOS.TIEMPO_DEPRECIACION, 1) AS Expr17")
                meteSQL("      , CONVERT(varchar(10),ACTIVOS_FIJOS.FECHA_ADQUISICION, 101) AS Expr18")
                meteSQL("      , ACTIVOS_FIJOS.CODIGO_DE_MONEDA")
                meteSQL("      , MONEDAS.DESCRIPCION_MONEDA")
                meteSQL("      , IsNull(ACTIVOS_FIJOS.FRECUENCIA_MNTMTO, 0) AS Expr19")
                meteSQL("      , ACTIVOS_FIJOS.DEPRECIABLE")
                meteSQL("      , Convert(Varchar, ACTIVOS_FIJOS.VALOR_ORIG_ACT_USADO, 1) AS Expr20")
                meteSQL("      , Convert(Varchar, ACTIVOS_FIJOS.TASA_DEDUCIBLE_ISR, 1) AS Expr21")
                meteSQL("      , Convert(Varchar, ACTIVOS_FIJOS.VALOR_NO_DEDUCIBLE, 1) AS Expr22")
                meteSQL("      , Convert(Varchar, ACTIVOS_FIJOS.VALOR_MONEDA_LOCAL, 1) AS Expr23")
                meteSQL("      , CONVERT(varchar(10), ACTIVOS_FIJOS.FECHA_INICIO_DEPREC, 101) AS Expr24")
                meteSQL("      , ACTIVOS_FIJOS.CODIGO_MARCA")
                meteSQL("      , ACTIVOS_FIJOS.REFERENCIA")
                meteSQL("      , ACTIVOS_FIJOS.RESPONSABLE_ID")
                meteSQL("      , ACTIVOS_FIJOS.CATEGORIA_ID")
                meteSQL("      , ACTIVOS_FIJOS.CODIGO_UBICACION")
                meteSQL("      , ACTIVOS_FIJOS.TimeStamp")
                meteSQL("   FROM ACTIVOS_FIJOS INNER JOIN")
                meteSQL("        MONEDAS ON ACTIVOS_FIJOS.CODIGO_DE_MONEDA = MONEDAS.CODIGO_DE_MONEDA LEFT OUTER JOIN")
                meteSQL("        DIVISIONES ON ACTIVOS_FIJOS.CODIGO_DIVISION = DIVISIONES.CODIGO_DIVISION LEFT OUTER JOIN")
                meteSQL("        PROVEEDORES ON ACTIVOS_FIJOS.CODIGO_PROVEEDOR = PROVEEDORES.CODIGO_PROVEEDOR INNER JOIN")
                meteSQL("        TIPOS_DE_ACTIVOS ON ACTIVOS_FIJOS.CODIGO_TIPO_ACTIVO = TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO")
                meteSQL("  WHERE (ACTIVOS_FIJOS.CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & ")")
                meteSQL("        AND (ACTIVOS_FIJOS.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text) & ")")

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    varANO_PERIODO = SqlData(Sqlconn, 1).ToString
                    varCOSTO_ACUM_MNTMTO = SqlData(Sqlconn, 2).ToString
                    varESTADO_SERVICIO = SqlData(Sqlconn, 3).ToString
                    varESTATUS = SqlData(Sqlconn, 4).ToString
                    varFECHA_BAJA_ACTIVO = SqlData(Sqlconn, 5).ToString
                    varFECHA_OPERACION = SqlData(Sqlconn, 6).ToString
                    varFECHA_ULTIMA_DEPREC = SqlData(Sqlconn, 7).ToString
                    varFECHA_ULTIMA_REVAL = SqlData(Sqlconn, 8).ToString
                    varFECHA_ULT_INVENTARIO = SqlData(Sqlconn, 9).ToString
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
                    lblnombre_proveedor.Text = SqlData(Sqlconn, 26).ToString
                    txtCODIGO_TIPO_ACTIVO.Text = SqlData(Sqlconn, 27).ToString
                    lblDESCRIP_TIPO_ACTIVO.Text = SqlData(Sqlconn, 28).ToString
                    txtCODIGO_DIVISION.Text = SqlData(Sqlconn, 29).ToString
                    lblDESCRIPCION_DIVISION.Text = SqlData(Sqlconn, 30).ToString
                    txtDESCRIP_CORTA_ACTIVO.Text = SqlData(Sqlconn, 31).ToString
                    txtVALOR_ORIGINAL_ACTIV.Text = SqlData(Sqlconn, 32).ToString
                    txtVALOR_RESCATE_ACTIVO.Text = SqlData(Sqlconn, 33).ToString
                    cboTIPO_DEPRECIACION.SelectedValue = SqlData(Sqlconn, 34).ToString
                    txtTIEMPO_DEPRECIACION.Text = SqlData(Sqlconn, 35).ToString
                    Me._tiempoDepreciacion = txtTIEMPO_DEPRECIACION.GetValor()
                    mskFECHA_ADQUISICION.EscribirFecha(SqlData(Sqlconn, 36).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 37).ToString
                    lblDESCRIPCION_MONEDA.Text = SqlData(Sqlconn, 38).ToString
                    txtFRECUENCIA_MNTMTO.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 39))
                    cboDEPRECIABLE.SelectedValue = SqlData(Sqlconn, 40).ToString
                    txtVALOR_ORIG_ACT_USADO.Text = SqlData(Sqlconn, 41).ToString
                    txtTASA_DEDUCIBLE_ISR.Text = SqlData(Sqlconn, 42).ToString
                    txtVALOR_NO_DEDUCIBLE.Text = SqlData(Sqlconn, 43).ToString
                    txtVALOR_MONEDA_LOCAL.Text = SqlData(Sqlconn, 44).ToString
                    mskFECHA_INICIO_DEPREC.EscribirFecha(SqlData(Sqlconn, 45).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtCODIGO_MARCA.Text = SqlData(Sqlconn, 46).ToString
                    txtREFERENCIA.Text = SqlData(Sqlconn, 47).ToString
                    txtRESPONSABLE_ID.Text = SqlData(Sqlconn, 48).ToString
                    txtCATEGORIA_ID.Text = SqlData(Sqlconn, 49).ToString
                    CODIGO_UBICACION.Text = SqlData(Sqlconn, 50).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop

                Me.CreaControlesCampos()

                Me.LeeCampos()
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_DE_ACTIVO.Enabled = False
                lblMEJORA_CORRELATIVO.Visible = True
            End If
            lblTitCODIGO_DE_ACTIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            lblTitCODIGO_TIPO_ACTIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            txtCODIGO_TIPO_ACTIVO.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            cboTIPO_DEPRECIACION.Enabled = txtCODIGO_DE_ACTIVO.Enabled
            lblTitTIPO_DEPRECIACION.Enabled = txtCODIGO_DE_ACTIVO.Enabled

            lblTitMEJORA_CORRELATIVO.Visible = lblMEJORA_CORRELATIVO.Visible

            '-- Leo las descripciones
            Me.Codigos_Leave(txtCODIGO_PROVEEDOR, Nothing)
            lblDESCRIP_TIPO_ACTIVO.Text = DescripcionesDB.TipoDeActivo(txtCODIGO_TIPO_ACTIVO.Text)
            Me.Codigos_Leave(txtCODIGO_DIVISION, Nothing)
            Me.InfoMoneda(Nothing, Nothing)
            Me.Codigos_Leave(txtCODIGO_MARCA, Nothing)
            Me.Codigos_Leave(CODIGO_UBICACION, Nothing)
            Me.Codigos_Leave(txtRESPONSABLE_ID, Nothing)
            Me.Codigos_Leave(txtCATEGORIA_ID, Nothing)
            Me.ComboDepreciable_SelectedValueChanged(Nothing, Nothing)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LeeCampos()
        If Me.panCampos.Controls.Count > 0 Then
            Try
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
                            .Append("     , ACT_CAMPOS_VAL.timestamp")
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
                                    Dim timeStamp As String = String.Empty

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
                                        ctrlTexto.Text = campoValor
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
        V = V & ", @FECHA_ADQUISICION = " & Scm(mskFECHA_ADQUISICION.TextMMDDYYYY())
        V = V & ", @FECHA_BAJA_ACTIVO = " & Scm(varFECHA_BAJA_ACTIVO)
        V = V & ", @VALOR_DEP_ACUM_ACT = " & sen(varVALOR_DEP_ACUM_ACT)
        V = V & ", @MONTO_ULTIMA_REVAL = " & sen(varMONTO_ULTIMA_REVAL)
        V = V & ", @FECHA_ULTIMA_REVAL = " & Scm(varFECHA_ULTIMA_REVAL)
        V = V & ", @MONTO_ULTIMA_DEPREC = " & sen(varMONTO_ULTIMA_DEPREC)
        V = V & ", @FECHA_ULTIMA_DEPREC = null"
        V = V & ", @USUARIO_OPERACION = " & Scm(varUSUARIO_OPERACION)
        V = V & ", @FECHA_OPERACION = " & Scm(varFECHA_OPERACION)
        V = V & ", @ESTATUS = " & Scm(varESTATUS)
        V = V & ", @TASA_CAMBIO_COMPRA = " & sen(txtTASA_CAMBIO_COMPRA.GetValor())
        V = V & ", @TASA_CAMBIO_ULT_REV = " & sen(varTASA_CAMBIO_ULT_REV)
        V = V & ", @CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text)
        V = V & ", @FECHA_ULT_INVENTARIO = " & Scm(varFECHA_ULT_INVENTARIO)
        V = V & ", @NO_ORDEN = " & sen(varNO_ORDEN)
        V = V & ", @USR_ACTUALIZACION = " & Scm(varUSR_ACTUALIZACION)
        V = V & ", @FEC_ACTUALIZACION = " & Scm(varFEC_ACTUALIZACION)
        V = V & ", @SALDO_MESES_DEPRE = " & sen(varSALDO_MESES_DEPRE)
        V = V & ", @FECHA_ULT_MANTMTO = " & Scm(varFECHA_ULT_MANTMTO)
        V = V & ", @COSTO_ACUM_MNTMTO = " & sen(varCOSTO_ACUM_MNTMTO)
        V = V & ", @FRECUENCIA_MNTMTO = " & sen(txtFRECUENCIA_MNTMTO.GetValor())
        V = V & ", @ANO_PERIODO = " & sen(varANO_PERIODO)
        V = V & ", @NO_PERIODO = " & sen(varNO_PERIODO)
        V = V & ", @DEPRECIABLE = " & Scm(cboDEPRECIABLE.SelectedValue.ToString)
        V = V & ", @ESTADO_SERVICIO = " & Scm(varESTADO_SERVICIO)
        V = V & ", @VALOR_ORIG_ACT_USADO = " & sen(txtVALOR_ORIG_ACT_USADO.GetValor())
        V = V & ", @TASA_DEDUCIBLE_ISR = " & sen(txtTASA_DEDUCIBLE_ISR.GetValor())
        V = V & ", @VALOR_NO_DEDUCIBLE = " & sen(txtVALOR_NO_DEDUCIBLE.GetValor())

        If mskFECHA_INICIO_DEPREC.Text = "__/__/____" Or mskFECHA_INICIO_DEPREC.Text = "" Then
            V = V & ", @FECHA_INICIO_DEPREC = " & Scm(mskFECHA_ADQUISICION.TextMMDDYYYY())
        Else
            V = V & ", @FECHA_INICIO_DEPREC = " & Scm(mskFECHA_INICIO_DEPREC.TextMMDDYYYY())
        End If

        V = V & ", @VALOR_MONEDA_LOCAL = " & sen(txtVALOR_MONEDA_LOCAL.GetValor())
        V = V & ", @CODIGO_MARCA = " & Scm(txtCODIGO_MARCA.Text)
        V = V & ", @REFERENCIA = " & Scm(txtREFERENCIA.Text)
        V = V & ", @RESPONSABLE_ID = " & Scm(txtRESPONSABLE_ID.Text)
        V = V & ", @CATEGORIA_ID = " & Scm(txtCATEGORIA_ID.Text)
        V = V & ", @CODIGO_UBICACION = " & Scm(CODIGO_UBICACION.Text)
        V = V & ", @POSEE_CTRL_TF = " & Scm(CStr(POSEE_CTRL_TF.CheckState))

        Return V
    End Function

    Private Sub GrabarCampos()
        If Me.panCampos.Controls.Count > 0 Then
            Dim v As String = String.Empty
            For Each ctrl As Control In Me.panCampos.Controls
                If TypeOf ctrl Is Citi.Synergia.UIGenerico.SynTextBox Or TypeOf ctrl Is ComboBox Then
                    If Not String.IsNullOrEmpty(TraeDato("select max(MEJORA_CORRELATIVO) from ACTIVOS_FIJOS Where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text))) Then
                        lblMEJORA_CORRELATIVO.Text = TraeDato("select max(MEJORA_CORRELATIVO) from ACTIVOS_FIJOS Where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text)).ToString
                    End If

                    v = ""
                    v = v & "  @CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text)
                    v = v & ", @MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text)
                    v = v & ", @CAMPO_ID = " & Scm(ctrl.Tag.ToString)

                    Dim res As Integer = 0
                    Dim valor As String = String.Empty
                    If Not String.IsNullOrEmpty(TraeDato("Select isnull(count(*),0) from ACT_CAMPOS_VAL Where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " And MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text) & " And CAMPO_ID = " & Scm(ctrl.Tag.ToString))) Then
                        res = CType(TraeDato("Select isnull(count(*),0) from ACT_CAMPOS_VAL Where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " And MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text) & " And CAMPO_ID = " & Scm(ctrl.Tag.ToString)), Integer)
                    End If
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

                    SysTimeStamp = TimeStamp_Local

                    If res = 0 And Modo_Local = Modo_Cambio Then
                        Modo = Modo_Alta
                    Else
                        Modo = Modo_Local
                    End If

                    If sp("ACT_CAMPOS_VAL", v) = False Then
                        Exit Sub
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub CodigoProveedor_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCODIGO_PROVEEDOR.KeyUp
        If e.KeyCode = Keys.F4 Then
            Me.ListaProveedores(Nothing, Nothing)
        End If
    End Sub

    Private Sub CodigoTipoActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_TIPO_ACTIVO.Leave
        Try
            Me.CreaControlesCampos()

            If txtCODIGO_TIPO_ACTIVO.Text.Trim <> "" Then
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
            End If

            If txtVALOR_ORIGINAL_ACTIV.Text <> "" Then
                ValorOriginalActivo_Leave(txtVALOR_ORIGINAL_ACTIV, New System.EventArgs())
            End If

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

    Private Sub CodigosConsultas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_MARCA.DoubleClick, lblTitRESPONSABLE_ID.DoubleClick, lblTitCATEGORIA_ID.DoubleClick
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

                    Dim codigoMoneda As String = String.Empty
                    If Not String.IsNullOrEmpty(TraeDato("Select CODIGO_DE_MONEDA From PARAMETRO_GENERALES Where compania = 'PA'")) Then
                        codigoMoneda = TraeDato("Select CODIGO_DE_MONEDA From PARAMETRO_GENERALES Where compania = 'PA'").ToString
                    End If
                    If codigoMoneda.Trim() = txtCODIGO_DE_MONEDA.ToString().Trim() Then
                        txtTASA_CAMBIO_COMPRA.Enabled = False
                    Else
                        txtTASA_CAMBIO_COMPRA.Enabled = True
                    End If
                End If

            Catch errSQL As SqlClient.SqlException
                MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If txtVALOR_ORIGINAL_ACTIV.Text <> "" AndAlso txtTASA_CAMBIO_COMPRA.Text <> "" AndAlso txtVALOR_RESCATE_ACTIVO.Text <> "" Then
            txtVALOR_MONEDA_LOCAL.Text = String.Format("{0:0,0.00}", ((CDbl(txtVALOR_ORIGINAL_ACTIV.Text) - CDbl(txtVALOR_RESCATE_ACTIVO.Text)) / CDbl(txtTASA_CAMBIO_COMPRA.Text)))
        End If
    End Sub

    Private Sub ValorOriginalActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVALOR_ORIGINAL_ACTIV.Leave
        If txtVALOR_ORIGINAL_ACTIV.Text = "" Then
            txtVALOR_RESCATE_ACTIVO.Text = "0.00"
        End If

        Dim valorOriginal As Decimal = 0
        Decimal.TryParse(txtVALOR_ORIGINAL_ACTIV.Text, valorOriginal)
        valorOriginal = (valorOriginal / 100) * _valorDeRescate
        txtVALOR_RESCATE_ACTIVO.Text = String.Format("{0:0,0.00}", valorOriginal)

        Decimal.TryParse(txtVALOR_ORIGINAL_ACTIV.Text, valorOriginal)
        If txtVALOR_ORIGINAL_ACTIV.Text <> "" AndAlso txtTASA_CAMBIO_COMPRA.Text <> "" AndAlso txtVALOR_RESCATE_ACTIVO.Text <> "" Then
            txtVALOR_MONEDA_LOCAL.Text = String.Format("{0:0,0.00}", ((valorOriginal - CDbl(txtVALOR_RESCATE_ACTIVO.Text)) / CDbl(txtTASA_CAMBIO_COMPRA.Text)))
        End If
    End Sub

    Private Sub ValorRescateActivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVALOR_RESCATE_ACTIVO.Leave
        If txtVALOR_ORIGINAL_ACTIV.Text <> "" AndAlso txtTASA_CAMBIO_COMPRA.Text <> "" AndAlso txtVALOR_RESCATE_ACTIVO.Text <> "" Then
            txtVALOR_MONEDA_LOCAL.Text = String.Format("{0:0,0.00}", ((CDbl(txtVALOR_ORIGINAL_ACTIV.Text) - CDbl(txtVALOR_RESCATE_ACTIVO.Text)) * CDbl(txtTASA_CAMBIO_COMPRA.Text)))
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
    End Sub

    Private Sub Folder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folder.SelectedIndexChanged
        If Folder.SelectedIndex = 1 Then
            Me.LeeCampos()
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim estado As String = String.Empty

        'Obtenemos el estado del activo base para permitir o no la mejora
        If Not String.IsNullOrEmpty(TraeDato("select ESTATUS from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(CORRELATIVO))) Then
            estado = TraeDato("select ESTATUS from ACTIVOS_FIJOS where CODIGO_DE_ACTIVO = " & Scm(txtCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(CORRELATIVO)).ToString
        End If
        If estado = "P" Then
            If Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(252, "No se permite hacer mejoras a activos con estado Pendiente."), Citi.Synergia.HelperClient.Utils.TipoDeMensaje.TipoError) = Citi.Synergia.HelperClient.Utils.TipoDeRespuesta.Continuar Then
                Return
            End If
            Return
        End If

        If Modo_Local <> Modo_Baja Then
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
        Modo = Modo_Alta

        Try
            If sp("ACTIVOS_FIJOS", Me.ArmarInsert()) Then
                Grabado = True
                HubieronCambios = True

                Me.GrabarCampos()

                Me.Close()
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class