Imports Citi.Synergia.HelperClient

Public Class ACTMAFC0
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarCombos()

        Me.CreaControlesCampos()

        lblMEJORA_CORRELATIVO.Text = Pop()
        lblCODIGO_DE_ACTIVO.Text = Pop()

        Me.Leer()

        Grabado = False

        FrameUno.Visible = True
        FrameDos.Visible = False

        Me.cmdSiguiente.Visible = True
        Me.cmdSiguiente.Enabled = True

        Me.cmdAnterior.Visible = False
        Me.cmdAnterior.Enabled = False

        Me.lblTitCODIGO_PROVEEDOR.Visible = Not Citi.Synergia.Locals.Cache.ProveedoresInvisibles
        Me.lblCODIGO_PROVEEDOR.Visible = Me.lblTitCODIGO_PROVEEDOR.Visible
        Me.lblNombreProveedor.Visible = Me.lblTitCODIGO_PROVEEDOR.Visible
    End Sub

    Private Sub LlenarCombos()
        Dim depreciacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With depreciacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(50, "D - Doble Saldo Declinante")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("L", Citi.Synergia.Traductor.Idiomas.GetMensaje(51, "L - Linea Recta")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(52, "S - Suma de Años Digitos")))
        End With
        With cboTipoDepreciacion
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = depreciacion
        End With

        Dim depreciable As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With depreciable
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(116, "N - No Depreciable")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(117, "S - Si Depreciable")))
        End With
        With cboDepreciable
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = depreciable
        End With

        Dim estadoServicio As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estadoServicio
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("U", Citi.Synergia.Traductor.Idiomas.GetMensaje(118, "U - Uso")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(119, "M - Mantenimiento")))
        End With
        With cboEstadoServicio
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estadoServicio
        End With

        Dim estado As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estado
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(62, "D - Desecho")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("U", Citi.Synergia.Traductor.Idiomas.GetMensaje(102, "U - Actualizado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("V", Citi.Synergia.Traductor.Idiomas.GetMensaje(105, "V - Vendido")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(106, "N - Donado")))
        End With
        With cboEstado
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estado
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
                            .Width = 450
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
                            .Enabled = Not Me.SoloDeConsulta
                        End With
                        Me.panCampos.Controls.Add(oTexto)
                    Else
                        oCombo = New ComboBox
                        With oCombo
                            .DropDownStyle = ComboBoxStyle.DropDownList
                            .FormattingEnabled = False
                            .Width = 450
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

    Private Sub Leer()
        Try
            Dim varANO_PERIODO As String = String.Empty
            meteSQL("select")
            meteSQL(" IsNull(ACTIVOS_FIJOS.ANO_PERIODO, 0), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.NO_PERIODO, 0), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.SALDO_MESES_DEPRE, 0), ")
            meteSQL(" ltrim(str(ACTIVOS_FIJOS.CODIGO_PROVEEDOR,10, 0)), ")
            meteSQL(" ACTIVOS_FIJOS.CODIGO_TIPO_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS.CODIGO_DIVISION, ")
            meteSQL(" ACTIVOS_FIJOS.DESCRIP_CORTA_ACTIVO, ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.VALOR_ORIGINAL_ACTIV, 0.00), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.VALOR_ACTUAL_ACTIVO, 0.00), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.VALOR_RESCATE_ACTIVO, 0.00), ")
            meteSQL(" ACTIVOS_FIJOS.TIPO_DEPRECIACION, ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.TIEMPO_DEPRECIACION, 0), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.PORCENTAJE_ANUAL_DEP, 0.00000), ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ADQUISICION,103), ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_BAJA_ACTIVO,103), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.VALOR_DEP_ACUM_ACT, 0.00), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.MONTO_ULTIMA_REVAL, 0.00), ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULTIMA_REVAL,103), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.MONTO_ULTIMA_DEPREC, 0.00), ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULTIMA_DEPREC,103), ")
            meteSQL(" ACTIVOS_FIJOS.USUARIO_OPERACION, ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_OPERACION,103), ")
            meteSQL(" ACTIVOS_FIJOS.ESTATUS, ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.TASA_CAMBIO_COMPRA, 0.00000), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.TASA_CAMBIO_ULT_REV, 0.00000), ")
            meteSQL(" ACTIVOS_FIJOS.CODIGO_DE_MONEDA, ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULT_INVENTARIO,103), ")
            meteSQL(" ltrim(str(ACTIVOS_FIJOS.NO_ORDEN,10, 0)), ")
            meteSQL(" ACTIVOS_FIJOS.USR_ACTUALIZACION, ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FEC_ACTUALIZACION,103), ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_ULT_MANTMTO,103), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.COSTO_ACUM_MNTMTO, 0.00), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.FRECUENCIA_MNTMTO, 0), ")
            meteSQL(" ACTIVOS_FIJOS.DEPRECIABLE, ")
            meteSQL(" ACTIVOS_FIJOS.ESTADO_SERVICIO, ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.VALOR_ORIG_ACT_USADO, 0.00), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.TASA_DEDUCIBLE_ISR, 0.00000), ")
            meteSQL(" IsNull(ACTIVOS_FIJOS.VALOR_NO_DEDUCIBLE, 0.00), ")
            meteSQL(" ACTIVOS_FIJOS.REFERENCIA,")
            meteSQL(" ACTIVOS_FIJOS.CODIGO_MARCA,")
            meteSQL(" IsNull(ACTIVOS_FIJOS.VALOR_MONEDA_LOCAL, 0.00), ")
            meteSQL(" convert(varchar(10),ACTIVOS_FIJOS.FECHA_INICIO_DEPREC,103), ")
            meteSQL(" ACTIVOS_FIJOS.RESPONSABLE_ID,")
            meteSQL(" ACTIVOS_FIJOS.CATEGORIA_ID,")
            meteSQL(" ACTIVOS_FIJOS.CODIGO_UBICACION,")
            meteSQL(" IsNull(ACTIVOS_FIJOS.POSEE_CTRL_TF, '1'),")
            meteSQL(" ACTIVOS_FIJOS.timestamp ")
            meteSQL("from ACTIVOS_FIJOS")
            meteSQL(" where ACTIVOS_FIJOS.CODIGO_DE_ACTIVO = " & Scm(lblCODIGO_DE_ACTIVO.Text) & " and ACTIVOS_FIJOS.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblANO_PERIODO.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 1))
                lblNO_PERIODO.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 2))
                lblSALDO_MESES_DEPRE.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 3))
                lblCODIGO_PROVEEDOR.Text = SqlData(Sqlconn, 4).ToString
                lblCODIGO_TIPO_ACTIVO.Text = SqlData(Sqlconn, 5).ToString
                lblCODIGO_DIVISION.Text = SqlData(Sqlconn, 6).ToString
                lblDESCRIP_CORTA_ACTIVO.Text = SqlData(Sqlconn, 7).ToString
                lblVALOR_ORIGINAL_ACTIV.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 8))
                lblVALOR_ACTUAL_ACTIVO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 9))
                lblVALOR_RESCATE_ACTIVO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 10))
                Me.cboTipoDepreciacion.SelectedValue = SqlData(Sqlconn, 11).ToString
                lblTIEMPO_DEPRECIACION.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 12))
                lblPORCENTAJE_ANUAL_DEP.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 13))
                lblFECHA_ADQUISICION.Text = SqlData(Sqlconn, 14).ToString
                lblFECHA_BAJA_ACTIVO.Text = SqlData(Sqlconn, 15).ToString
                lblVALOR_DEP_ACUM_ACT.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 16))
                lblMONTO_ULTIMA_REVAL.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 17))
                lblFECHA_ULTIMA_REVAL.Text = SqlData(Sqlconn, 18).ToString
                lblMONTO_ULTIMA_DEPREC.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 19))
                lblFECHA_ULTIMA_DEPREC.Text = SqlData(Sqlconn, 20).ToString
                lblUSUARIO_OPERACION.Text = SqlData(Sqlconn, 21).ToString
                lblFECHA_OPERACION.Text = SqlData(Sqlconn, 22).ToString
                Me.cboEstado.SelectedValue = SqlData(Sqlconn, 23).ToString
                lblTASA_CAMBIO_COMPRA.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 24))
                lblTASA_CAMBIO_ULT_REV.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 25))
                lblCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 26).ToString
                lblFECHA_ULT_INVENTARIO.Text = SqlData(Sqlconn, 27).ToString
                lblNO_ORDEN.Text = SqlData(Sqlconn, 28).ToString
                lblUSR_ACTUALIZACION.Text = SqlData(Sqlconn, 29).ToString
                lblFEC_ACTUALIZACION.Text = SqlData(Sqlconn, 30).ToString
                lblFECHA_ULT_MANTMTO.Text = SqlData(Sqlconn, 31).ToString
                lblCOSTO_ACUM_MNTMTO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 32))
                lblFRECUENCIA_MNTMTO.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 33))
                Me.cboDepreciable.SelectedValue = SqlData(Sqlconn, 34).ToString
                Me.cboEstadoServicio.SelectedValue = SqlData(Sqlconn, 35).ToString
                lblVALOR_ORIG_ACT_USADO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 36))
                lblTASA_DEDUCIBLE_ISR.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 37))
                lblVALOR_NO_DEDUCIBLE.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 38))
                txtREFERENCIA.Text = SqlData(Sqlconn, 39).ToString
                txtCODIGO_MARCA.Text = SqlData(Sqlconn, 40).ToString
                txtVALOR_MONEDA_LOCAL.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 41))
                lblFECHA_INICIO_DEPREC.Text = SqlData(Sqlconn, 42).ToString
                txtRESPONSABLE_ID.Text = SqlData(Sqlconn, 43).ToString
                txtCATEGORIA_ID.Text = SqlData(Sqlconn, 44).ToString
                CODIGO_UBICACION.Text = SqlData(Sqlconn, 45).ToString
                POSEE_CTRL_TF.Checked = CType(SqlData(Sqlconn, 46), Boolean)
                ReadTimeStamp()
                TimeStamp_Local = SysTimeStamp
            Loop

            Me.LeeCampos()

            Me.LeerDescripciones()

            '24/10/1996 Se obtiene el monto de las revaluaciones del activo
            'y se rebajan al campo de valor original solo para efectos de
            'consulta
            meteSQL("select str(isnull(sum(MONTO_DE_MOVIMIENTO),0),13,2) ")
            meteSQL("  from MOVIM_ACTIVOS M, TIPO_MOV_ACTIVOS T ")
            meteSQL(" where M.CODIGO_DE_ACTIVO   = " & Scm(lblCODIGO_DE_ACTIVO.Text))
            meteSQL("   and M.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))
            meteSQL("   and T.CLASE_MOVIMIENTO   in ('G','R') ")
            meteSQL("   and M.TIPO_MOVIMIENTO    =  T.TIPO_MOVIMIENTO ")
            meteSQL("   and ESTADO_MOVIMIENTO    =  'T' ")
            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblMONTO_REVALUACIONES.Text = SqlData(Sqlconn, 1).ToString
            Loop

            If lblVALOR_ORIGINAL_ACTIV.Text = "" Then
                lblVALOR_ORIGINAL_ACTIV.Text = "0.00"
            End If
            lblVALOR_TOT_ACTIVO.Text = lblVALOR_ORIGINAL_ACTIV.Text

            lblVALOR_ORIGINAL_ACTIV.Text = String.Format("{0:0,0.00}", CDbl(lblVALOR_ORIGINAL_ACTIV.Text) - CDbl(lblMONTO_REVALUACIONES.Text))


            varANO_PERIODO = String.Empty
            If Not String.IsNullOrEmpty(TraeDato("select isnull(ANO_PERIODO,0) from PERIODOS_CONTABLES where getdate() between FECHA_INICIO and FECHA_FIN")) Then
                varANO_PERIODO = TraeDato("select isnull(ANO_PERIODO,0) from PERIODOS_CONTABLES where getdate() between FECHA_INICIO and FECHA_FIN").ToString
            End If

            meteSQL("  select isnull(sum (MONTO_DE_MOVIMIENTO) + sum (VALOR_NO_DEDUCIBLE) ,0)")
            meteSQL("    from MOVIM_ACTIVOS M, TIPO_MOV_ACTIVOS T")
            meteSQL("   where M.CODIGO_DE_ACTIVO   = " & Scm(lblCODIGO_DE_ACTIVO.Text))
            meteSQL("     and M.MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))
            meteSQL("     and T.CLASE_MOVIMIENTO   = 'P' ")
            meteSQL("     and M.TIPO_MOVIMIENTO    = T.TIPO_MOVIMIENTO ")
            meteSQL("     and ESTADO_MOVIMIENTO    = 'T' ")
            meteSQL("     and M.ANO_PERIODO        = " & sen(varANO_PERIODO))
            EjecutaSQL("")
            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblVALOR_DEP_PERIODO.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 1))
            Loop

            If lblSALDO_MESES_DEPRE.Text = "" Then
                lblSALDO_MESES_DEPRE.Text = CStr(0)
            End If

            If CDbl(lblSALDO_MESES_DEPRE.Text) <= 0 Then
                lblTOTALMENTE_DEP.Text = " TOTALMENTE DEPRECIADO "
            Else
                lblTOTALMENTE_DEP.Text = " "
            End If

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
                            .Append("  From ACT_CAMPOS_VAL")
                            .Append("     , ACT_CAMPO")
                            .Append(" where ACT_CAMPOS_VAL.CODIGO_DE_ACTIVO   = " & Scm(lblCODIGO_DE_ACTIVO.Text))
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

    Private Sub LeerDescripciones()
        Me.lblNombreProveedor.Text = DescripcionesDB.Proveedor(lblCODIGO_PROVEEDOR.Text)
        Me.lblNombreTipoActivo.Text = DescripcionesDB.TipoDeActivo(lblCODIGO_TIPO_ACTIVO.Text)
        Me.lblNombreDivision.Text = DescripcionesDB.Division(lblCODIGO_DIVISION.Text)
        Me.lblDESCRIPCION_MONEDA.Text = DescripcionesDB.Monedas(lblCODIGO_DE_MONEDA.Text)
        Me.lblNombreMarca.Text = DescripcionesDB.Marcas(txtCODIGO_MARCA.Text)
        Me.lblNombreResponsable.Text = DescripcionesDB.NombreUsualResponsable(txtRESPONSABLE_ID.Text)
        Me.lblNombreCategoria.Text = DescripcionesDB.Categoria(txtCATEGORIA_ID.Text)
        Me.lblNombreUbicacion.Text = DescripcionesDB.UbicacionActivo(CODIGO_UBICACION.Text)
    End Sub

    Private Sub Tab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mhTab1.SelectedIndexChanged
        If mhTab1.SelectedIndex = 1 Then
            Me.LeeCampos()
        End If
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub

    Private Sub Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiguiente.Click
        FrameUno.Visible = False
        FrameDos.Visible = True
        cmdSiguiente.Visible = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Visible = True
        cmdAnterior.Enabled = True
    End Sub

    Private Sub Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnterior.Click
        FrameUno.Visible = True
        FrameDos.Visible = False
        cmdSiguiente.Visible = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Visible = False
        cmdAnterior.Enabled = False
    End Sub

    Private Sub InfoGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoGeneral.Click
        If Not String.IsNullOrEmpty(TraeDato("select count(*) from ACTIVOS_FIJOS_GEN where CODIGO_DE_ACTIVO = " & Scm(lblCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))) Then
            If Val(TraeDato("select count(*) from ACTIVOS_FIJOS_GEN where CODIGO_DE_ACTIVO = " & Scm(lblCODIGO_DE_ACTIVO.Text) & " and MEJORA_CORRELATIVO = " & sen(lblMEJORA_CORRELATIVO.Text))) > 0 Then
                Push(lblCODIGO_DE_ACTIVO.Text)
                Push(lblMEJORA_CORRELATIVO.Text)
                Dim frmConsulta As New ACTAFGC0
                With frmConsulta
                    .Modo_Local = Modo_Consulta
                    .SoloDeConsulta = True
                    .Pila = Me.Pila
                    .ShowDialog()
                    .Dispose()
                End With
                Me.LimpiarPila()
            Else
                MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(120, "Este activo fijo no posee información general"), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class