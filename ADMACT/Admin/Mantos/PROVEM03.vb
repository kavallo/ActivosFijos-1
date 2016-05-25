Public Class PROVEM03
    Private varSALDO_PROVEEDOR As String = String.Empty
    Private varANTICIPO_PROVEEDOR As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.SetupLlaves()

        Me.LimpiarDescripciones()

        Me.LlenarCombos()

        If Modo_Local = Modo_Alta Then
            Me.kPila(cp_POP)
            Me.SugerirCodigo()
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me.Leer()
        End If

        Me.ValoresDefault()

        Grabado = False
    End Sub

    Private Sub SetupLlaves()
        txtCODIGO_CUENTA.ControlesLlave.Add(New Citi.Synergia.Entidades.ConGenControlesLlave("Banco", txtCODIGO_BANCO))
    End Sub

    Private Sub LimpiarDescripciones()
        lblDESCRIP_CODIGO_ISR.Text = ""
        lblDESCRIPCION_CLASE.Text = ""
        lblNOMBRE_BANCO.Text = ""
        lblNOMBRE_CUENTA.Text = ""
        lblDESCRIPCION_MONEDA.Text = ""
        lblDESCRIPCI_CONDICION.Text = ""
        lblDESC_TIPO_PAGO.Text = ""
        lblNOMBRE_DEL_PAIS.Text = ""
        lblDESCRIPCION_IMPUESTO.Text = ""
    End Sub

    Private Sub LlenarCombos()
        Dim tipoProveedor As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        tipoProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("E", Citi.Synergia.Traductor.Idiomas.GetMensaje(75, "E - EMPRESA")))
        tipoProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(76, "P - PERSONA INDIVIDUAL")))
        With cboTIPO_PROVEEDOR
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoProveedor
        End With

        Dim proveedorUnicaVez As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        proveedorUnicaVez.Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(77, "N - PROVEEDOR CONSTANTE")))
        proveedorUnicaVez.Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(78, "S - PROVEEDOR POR UNICA VEZ")))
        With cboPROVEEDOR_UNICA_VEZ
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = proveedorUnicaVez
        End With

        Dim estatusProvedor As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        estatusProvedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(72, "A - ACTIVO")))
        estatusProvedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("I", Citi.Synergia.Traductor.Idiomas.GetMensaje(74, "I - INACTIVO")))
        With cboESTATUS_PROVEEDOR
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estatusProvedor
        End With

        Dim tomaDescuentos As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        tomaDescuentos.Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(79, "N - NO TOMA LOS DESCUENTOS")))
        tomaDescuentos.Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(80, "S - TOMA LOS DESCUENTOS")))
        With cboTOMA_DESCUENTOS
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tomaDescuentos
        End With

        Dim origenProveedor As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        origenProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("E", Citi.Synergia.Traductor.Idiomas.GetMensaje(81, "E - EXTRANJERO")))
        origenProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("L", Citi.Synergia.Traductor.Idiomas.GetMensaje(82, "L - LOCAL")))
        With cboORIGEN_PROVEEDOR
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = origenProveedor
        End With

        Dim congelado As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        congelado.Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(83, "A - PROVEEDOR ACTIVO")))
        congelado.Add(New Citi.Synergia.Entidades.CodigoDescripcion("C", Citi.Synergia.Traductor.Idiomas.GetMensaje(84, "C - PROVEEDOR CONGELADO")))
        With cbocongelado
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = congelado
        End With

        Dim pagaIvaProveedor As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        pagaIvaProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("1", Citi.Synergia.Traductor.Idiomas.GetMensaje(85, "1 - SI")))
        pagaIvaProveedor.Add(New Citi.Synergia.Entidades.CodigoDescripcion("0", Citi.Synergia.Traductor.Idiomas.GetMensaje(86, "0 - NO")))
        With cbopaga_iva_proveedor
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = pagaIvaProveedor
        End With

        Dim participaRetencion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        participaRetencion.Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(87, "N - NO SE APLICA RETENCION")))
        participaRetencion.Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(88, "S - SI SE APLICA RETENCION")))
        With cboPARTICIPA_RETENCION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = participaRetencion
        End With

        Dim aceptaEnvioParcial As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        aceptaEnvioParcial.Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(89, "N - NO ACEPTA ENVIOS PARCIALES")))
        aceptaEnvioParcial.Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(90, "S - SI ACEPTA ENVIOS PARCIALES")))
        With cboACEPTA_ENVIO_PARCIAL
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = aceptaEnvioParcial
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then txtCODIGO_PROVEEDOR.Text = Pop()
    End Sub

    Private Sub SugerirCodigo()
        If txtCODIGO_PROVEEDOR.Text = "" Then
            If Not String.IsNullOrEmpty(TraeDato("Select IsNull(Max(CODIGO_PROVEEDOR), 0) + 1 From PROVEEDORES")) Then
                txtCODIGO_PROVEEDOR.Text = TraeDato("Select IsNull(Max(CODIGO_PROVEEDOR), 0) + 1 From PROVEEDORES").ToString
            End If
        End If
    End Sub

    Private Sub ValoresDefault()
        Dim cantidad As Integer = 0

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from IMPUESTOS")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from IMPUESTOS"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_ISR.Text = TraeDato("Select CODIGO_IMPUESTO From IMPUESTOS").ToString
                Me.DescripcionesCodigos_Leave(txtCODIGO_ISR, Nothing)
                Me.txtCODIGO_ISR.Enabled = False
                Me.lblTitCODIGO_ISR.Enabled = False

                Me.txtCODIGO_IMPUESTO.Text = Me.txtCODIGO_ISR.Text
                Me.DescripcionesCodigos_Leave(txtCODIGO_IMPUESTO, Nothing)
                Me.txtCODIGO_IMPUESTO.Enabled = False
                Me.lblTitCODIGO_IMPUESTO.Enabled = False
            End If
        End If

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from MONEDAS"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_DE_MONEDA.Text = TraeDato("Select CODIGO_DE_MONEDA From MONEDAS").ToString
                Me.DescripcionesCodigos_Leave(txtCODIGO_DE_MONEDA, Nothing)
                Me.txtCODIGO_DE_MONEDA.Enabled = False
                Me.lblTitCODIGO_DE_MONEDA.Enabled = False
            End If
        End If

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from CONDICIONES_DE_PAGO")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from CONDICIONES_DE_PAGO"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_DE_CONDICION.Text = TraeDato("Select CODIGO_DE_CONDICION From CONDICIONES_DE_PAGO").ToString
                Me.DescripcionesCodigos_Leave(txtCODIGO_DE_CONDICION, Nothing)
                Me.txtCODIGO_DE_CONDICION.Enabled = False
                Me.lblTitCODIGO_DE_CONDICION.Enabled = False
            End If
        End If

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from TIPOS_DE_PAGO")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from TIPOS_DE_PAGO"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_TIPO_PAGO.Text = TraeDato("Select CODIGO_TIPO_PAGO From TIPOS_DE_PAGO").ToString
                Me.DescripcionesCodigos_Leave(txtCODIGO_TIPO_PAGO, Nothing)
                Me.txtCODIGO_TIPO_PAGO.Enabled = False
                Me.lblTitCODIGO_TIPO_PAGO.Enabled = False
            End If
        End If

        If Not String.IsNullOrEmpty(TraeDato("select IsNull(COUNT(1), 0) from MAESTRO_PAISES")) Then
            cantidad = CType(TraeDato("select IsNull(COUNT(1), 0) from MAESTRO_PAISES"), Integer)
            If cantidad = 1 Then
                Me.txtCODIGO_DE_PAIS.Text = TraeDato("Select CODIGO_DE_PAIS From MAESTRO_PAISES").ToString
                Me.DescripcionesCodigos_Leave(txtCODIGO_DE_PAIS, Nothing)
                Me.txtCODIGO_DE_PAIS.Enabled = False
                Me.lblTitCODIGO_DE_PAIS.Enabled = False
            End If
        End If
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" IsNull(PROVEEDORES.SALDO_PROVEEDOR, 0.00), ")
                meteSQL(" PROVEEDORES.DESCRIPCION_PROV, ")
                meteSQL(" PROVEEDORES.nombre_proveedor, ")
                meteSQL(" PROVEEDORES.direccion_proveedor, ")
                meteSQL(" PROVEEDORES.telefonos_proveedor, ")
                meteSQL(" PROVEEDORES.fax_proveedor, ")
                meteSQL(" PROVEEDORES.nit_proveedor, ")
                meteSQL(" PROVEEDORES.Cedula_proveedor, ")
                meteSQL(" ltrim(str(PROVEEDORES.Cod_postal_proveedor,5, 0)), ")
                meteSQL(" ltrim(str(PROVEEDORES.ANTICIPO_PROVEEDOR,14,2)), ")
                meteSQL(" PROVEEDORES.comentario1_proveedo, ")
                meteSQL(" PROVEEDORES.comentario2_proveedo, ")
                meteSQL(" PROVEEDORES.comentario3_proveedo, ")
                meteSQL(" PROVEEDORES.comentario4_proveedo, ")
                meteSQL(" PROVEEDORES.comentario5_proveedo, ")
                meteSQL(" ltrim(str(PROVEEDORES.CODIGO_BANCO,3, 0)), ")
                meteSQL(" PROVEEDORES.CODIGO_TIPO_PAGO, ")
                meteSQL(" PROVEEDORES.CODIGO_CLASE_PROVEED, ")
                meteSQL(" ltrim(str(PROVEEDORES.CODIGO_CUENTA,3, 0)), ")
                meteSQL(" ltrim(str(PROVEEDORES.CODIGO_DE_CONDICION,3, 0)), ")
                meteSQL(" PROVEEDORES.TIPO_PROVEEDOR, ")
                meteSQL(" PROVEEDORES.CODIGO_DE_MONEDA, ")
                meteSQL(" PROVEEDORES.CODIGO_IMPUESTO, ")
                meteSQL(" PROVEEDORES.PROVEEDOR_UNICA_VEZ, ")
                meteSQL(" ltrim(str(PROVEEDORES.CODIGO_DE_PAIS,2, 0)), ")
                meteSQL(" ltrim(str(PROVEEDORES.paga_iva_proveedor,1, 0)), ")
                meteSQL(" IsNull(PROVEEDORES.porcentaje_descuento, 0.00000), ")
                meteSQL(" PROVEEDORES.ESTATUS_PROVEEDOR, ")
                meteSQL(" PROVEEDORES.TOMA_DESCUENTOS, ")
                meteSQL(" PROVEEDORES.ORIGEN_PROVEEDOR, ")
                meteSQL(" PROVEEDORES.congelado, ")
                meteSQL(" PROVEEDORES.NUMERO_REGISTRO, ")
                meteSQL(" PROVEEDORES.GIRO_DE_NEGOCIO, ")
                meteSQL(" ltrim(str(PROVEEDORES.LINEA_DE_CREDITO,14,2)), ")
                meteSQL(" PROVEEDORES.CUENTA_PROVEEDOR, ")
                meteSQL(" PROVEEDORES.PARTICIPA_RETENCION, ")
                meteSQL(" PROVEEDORES.CODIGO_ISR, ")
                meteSQL(" PROVEEDORES.REFERENCIA_PROVEEDOR, ")
                meteSQL(" PROVEEDORES.FORMATO_ORDEN_COMPRA, ")
                meteSQL(" PROVEEDORES.ACEPTA_ENVIO_PARCIAL, ")
                meteSQL(" PROVEEDORES.DIRECCION_EMAIL, ")
                meteSQL(" PROVEEDORES.NOMBRE_BENEFICIARIO, ")
                meteSQL(" PROVEEDORES.timestamp ")
                meteSQL("from PROVEEDORES ")
                meteSQL(" where PROVEEDORES.CODIGO_PROVEEDOR = " & sen(txtCODIGO_PROVEEDOR.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    varSALDO_PROVEEDOR = String.Format("{0:0,0.00}", SqlData(Sqlconn, 1))
                    txtDESCRIPCION_PROV.Text = SqlData(Sqlconn, 2).ToString
                    txtnombre_proveedor.Text = SqlData(Sqlconn, 3).ToString
                    txtdireccion_proveedor.Text = SqlData(Sqlconn, 4).ToString
                    txttelefonos_proveedor.Text = SqlData(Sqlconn, 5).ToString
                    txtfax_proveedor.Text = SqlData(Sqlconn, 6).ToString
                    txtnit_proveedor.Text = SqlData(Sqlconn, 7).ToString
                    txtCedula_proveedor.Text = SqlData(Sqlconn, 8).ToString
                    txtCod_postal_proveedor.Text = SqlData(Sqlconn, 9).ToString
                    varANTICIPO_PROVEEDOR = SqlData(Sqlconn, 10).ToString
                    txtcomentario1_proveedo.Text = SqlData(Sqlconn, 11).ToString
                    txtcomentario2_proveedo.Text = SqlData(Sqlconn, 12).ToString
                    txtcomentario3_proveedo.Text = SqlData(Sqlconn, 13).ToString
                    txtcomentario4_proveedo.Text = SqlData(Sqlconn, 14).ToString
                    txtcomentario5_proveedo.Text = SqlData(Sqlconn, 15).ToString
                    txtCODIGO_BANCO.Text = SqlData(Sqlconn, 16).ToString
                    txtCODIGO_TIPO_PAGO.Text = SqlData(Sqlconn, 17).ToString
                    txtCODIGO_CLASE_PROVEED.Text = SqlData(Sqlconn, 18).ToString
                    txtCODIGO_CUENTA.Text = SqlData(Sqlconn, 19).ToString
                    txtCODIGO_DE_CONDICION.Text = SqlData(Sqlconn, 20).ToString
                    cboTIPO_PROVEEDOR.SelectedValue = SqlData(Sqlconn, 21).ToString
                    txtCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 22).ToString
                    txtCODIGO_IMPUESTO.Text = SqlData(Sqlconn, 23).ToString
                    cboPROVEEDOR_UNICA_VEZ.SelectedValue = SqlData(Sqlconn, 24).ToString
                    txtCODIGO_DE_PAIS.Text = SqlData(Sqlconn, 25).ToString
                    cboPAGA_IVA_PROVEEDOR.SelectedValue = SqlData(Sqlconn, 26).ToString
                    txtporcentaje_descuento.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 27))
                    cboESTATUS_PROVEEDOR.SelectedValue = SqlData(Sqlconn, 28).ToString
                    cboTOMA_DESCUENTOS.SelectedValue = SqlData(Sqlconn, 29).ToString
                    cboORIGEN_PROVEEDOR.SelectedValue = SqlData(Sqlconn, 30).ToString
                    cboCONGELADO.SelectedValue = SqlData(Sqlconn, 31).ToString
                    txtNUMERO_REGISTRO.Text = SqlData(Sqlconn, 32).ToString
                    txtGIRO_DE_NEGOCIO.Text = SqlData(Sqlconn, 33).ToString
                    txtLINEA_DE_CREDITO.Text = SqlData(Sqlconn, 34).ToString
                    txtCUENTA_PROVEEDOR.Text = SqlData(Sqlconn, 35).ToString
                    cboPARTICIPA_RETENCION.SelectedValue = SqlData(Sqlconn, 36).ToString
                    txtCODIGO_ISR.Text = SqlData(Sqlconn, 37).ToString
                    txtREFERENCIA_PROVEEDOR.Text = SqlData(Sqlconn, 38).ToString
                    txtFORMATO_ORDEN_COMPRA.Text = SqlData(Sqlconn, 39).ToString
                    cboACEPTA_ENVIO_PARCIAL.SelectedValue = SqlData(Sqlconn, 40).ToString
                    txtDIRECCION_EMAIL.Text = SqlData(Sqlconn, 41).ToString
                    txtNOMBRE_BENEFICIARIO.Text = SqlData(Sqlconn, 42).ToString

                    MyBase.ReadTimeStamp()
                Loop
            End If

            MyBase.Habilitar()

            If Modo_Local <> Modo_Alta Then
                txtCODIGO_PROVEEDOR.Enabled = False
                lblTitCODIGO_PROVEEDOR.Enabled = False
            End If

            Me.CodigosDescripciones()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CodigosDescripciones()
        '-- Descripciones
        Me.DescripcionesCodigos_Leave(txtCODIGO_ISR, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_CLASE_PROVEED, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_BANCO, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_CUENTA, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_DE_MONEDA, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_DE_CONDICION, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_TIPO_PAGO, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_DE_PAIS, Nothing)
        Me.DescripcionesCodigos_Leave(txtCODIGO_IMPUESTO, Nothing)
    End Sub

    Private Sub Siguiente(Optional ByVal cancelar As Boolean = False)
        If Modo_Local = Modo_Alta Then
            If cancelar Then
                Me.Close()
            Else
                MyBase.Limpiar()
                Me.SugerirCodigo()
                Me.CodigosDescripciones()
                Me.ValoresDefault()
                txtCODIGO_PROVEEDOR.Focus()
            End If
        Else
            If Me.Pila.Count > 0 Then
                txtCODIGO_PROVEEDOR.Text = Pop()
                Me.Leer()
                Me.ValoresDefault()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub DescripcionesCodigos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_ISR.Leave, txtCODIGO_CLASE_PROVEED.Leave, txtCODIGO_BANCO.Leave, txtCODIGO_CUENTA.Leave, txtCODIGO_DE_MONEDA.Leave, txtCODIGO_DE_CONDICION.Leave, txtCODIGO_TIPO_PAGO.Leave, txtCODIGO_DE_PAIS.Leave, txtCODIGO_IMPUESTO.Leave
        Select Case sender.Name
            Case "txtCODIGO_ISR"
                lblDESCRIP_CODIGO_ISR.Text = ""
                If txtCODIGO_ISR.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_ISR.Text))) Then
                        lblDESCRIP_CODIGO_ISR.Text = TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_ISR.Text)).ToString
                    End If
                End If
            Case "txtCODIGO_CLASE_PROVEED"
                lblDESCRIPCION_CLASE.Text = ""
                If txtCODIGO_CLASE_PROVEED.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_CLASE,1,18) from CLASE_PROVEEDOR where CODIGO_CLASE_PROVEED = " & Scm(txtCODIGO_CLASE_PROVEED.Text))) Then
                        lblDESCRIPCION_CLASE.Text = TraeDato("select substring(DESCRIPCION_CLASE,1,18) from CLASE_PROVEEDOR where CODIGO_CLASE_PROVEED = " & Scm(txtCODIGO_CLASE_PROVEED.Text)).ToString
                    End If
                End If
            Case "txtCODIGO_BANCO"
                lblNOMBRE_BANCO.Text = ""
                If txtCODIGO_BANCO.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select ltrim(substring(NOMBRE_BANCO,1,18)) from BANCOS where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.GetValor()))) Then
                        lblNOMBRE_BANCO.Text = TraeDato("select ltrim(substring(NOMBRE_BANCO,1,18)) from BANCOS where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.GetValor())).ToString
                    End If
                End If
            Case "txtCODIGO_CUENTA"
                lblNOMBRE_CUENTA.Text = ""
                If txtCODIGO_CUENTA.Text <> "" And txtCODIGO_BANCO.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(NOMBRE_CUENTA,1,18) from CUENTA_BANCO where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.GetValor()) & " and CODIGO_CUENTA = " & sen(txtCODIGO_CUENTA.GetValor()))) Then
                        lblNOMBRE_CUENTA.Text = TraeDato("select substring(NOMBRE_CUENTA,1,18) from CUENTA_BANCO where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.GetValor()) & " and CODIGO_CUENTA = " & sen(txtCODIGO_CUENTA.GetValor())).ToString
                    End If
                End If
            Case "txtCODIGO_DE_MONEDA"
                lblDESCRIPCION_MONEDA.Text = ""
                If txtCODIGO_DE_MONEDA.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_MONEDA,1,19) from MONEDAS where CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text))) Then
                        lblDESCRIPCION_MONEDA.Text = TraeDato("select substring(DESCRIPCION_MONEDA,1,19) from MONEDAS where CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text)).ToString
                    End If
                End If
            Case "txtCODIGO_DE_CONDICION"
                lblDESCRIPCI_CONDICION.Text = ""
                If txtCODIGO_DE_CONDICION.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCI_CONDICION,1,18) from CONDICIONES_DE_PAGO where CODIGO_DE_CONDICION = " & sen(txtCODIGO_DE_CONDICION.GetValor()))) Then
                        lblDESCRIPCI_CONDICION.Text = TraeDato("select substring(DESCRIPCI_CONDICION,1,18) from CONDICIONES_DE_PAGO where CODIGO_DE_CONDICION = " & sen(txtCODIGO_DE_CONDICION.GetValor())).ToString
                    End If
                End If
            Case "txtCODIGO_TIPO_PAGO"
                lblDESC_TIPO_PAGO.Text = ""
                If txtCODIGO_TIPO_PAGO.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(DESC_TIPO_PAGO,1,18) from TIPOS_DE_PAGO where CODIGO_TIPO_PAGO = " & Scm(txtCODIGO_TIPO_PAGO.Text))) Then
                        lblDESC_TIPO_PAGO.Text = TraeDato("select substring(DESC_TIPO_PAGO,1,18) from TIPOS_DE_PAGO where CODIGO_TIPO_PAGO = " & Scm(txtCODIGO_TIPO_PAGO.Text)).ToString
                    End If
                End If
            Case "txtCODIGO_DE_PAIS"
                lblNOMBRE_DEL_PAIS.Text = ""
                If txtCODIGO_DE_PAIS.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(NOMBRE_DEL_PAIS,1,18) from MAESTRO_PAISES where CODIGO_DE_PAIS = " & sen(txtCODIGO_DE_PAIS.GetValor()))) Then
                        lblNOMBRE_DEL_PAIS.Text = TraeDato("select substring(NOMBRE_DEL_PAIS,1,18) from MAESTRO_PAISES where CODIGO_DE_PAIS = " & sen(txtCODIGO_DE_PAIS.GetValor())).ToString
                    End If
                End If
            Case "txtCODIGO_IMPUESTO"
                lblDESCRIPCION_IMPUESTO.Text = ""
                If txtCODIGO_IMPUESTO.Text <> "" Then
                    If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_IMPUESTO.Text))) Then
                        lblDESCRIPCION_IMPUESTO.Text = TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_IMPUESTO.Text)).ToString
                    End If
                End If
        End Select
    End Sub

    Private Sub Codigos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitCODIGO_ISR.DoubleClick, lblTitCODIGO_CLASE_PROVEED.DoubleClick, lblTitCODIGO_BANCO.DoubleClick, lblTitCODIGO_CUENTA.DoubleClick, lblTitCODIGO_DE_MONEDA.DoubleClick, lblTitCODIGO_DE_CONDICION.DoubleClick, lblTitCODIGO_TIPO_PAGO.DoubleClick, lblTitCODIGO_DE_PAIS.DoubleClick, lblTitCODIGO_IMPUESTO.DoubleClick, lblTitFORMATO_ORDEN_COMPRA.DoubleClick
        Select Case sender.Name
            Case "lblTitCODIGO_ISR"
                txtCODIGO_ISR.GenerarConsulta()
            Case "lblTitCODIGO_CLASE_PROVEED"
                txtCODIGO_CLASE_PROVEED.GenerarConsulta()
            Case "lblTitCODIGO_BANCO"
                txtCODIGO_BANCO.GenerarConsulta()
            Case "lblTitCODIGO_CUENTA"
                txtCODIGO_CUENTA.GenerarConsulta()
            Case "lblTitCODIGO_DE_MONEDA"
                txtCODIGO_DE_MONEDA.GenerarConsulta()
            Case "lblTitCODIGO_DE_CONDICION"
                txtCODIGO_DE_CONDICION.GenerarConsulta()
            Case "lblTitCODIGO_TIPO_PAGO"
                txtCODIGO_TIPO_PAGO.GenerarConsulta()
            Case "lblTitCODIGO_DE_PAIS"
                txtCODIGO_DE_PAIS.GenerarConsulta()
            Case "lblTitCODIGO_IMPUESTO"
                txtCODIGO_IMPUESTO.GenerarConsulta()
            Case "lblTitFORMATO_ORDEN_COMPRA"
                txtFORMATO_ORDEN_COMPRA.GenerarConsulta()
        End Select
    End Sub

    Private Sub ParticipaRetencion_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPARTICIPA_RETENCION.SelectedValueChanged
        If Modo_Local = Modo_Baja Then Exit Sub
        If cboPARTICIPA_RETENCION.SelectedValue = "N" Then
            txtCODIGO_ISR.Text = ""
            lblDESCRIP_CODIGO_ISR.Text = ""
            lblTitCODIGO_ISR.Enabled = False
        Else
            lblTitCODIGO_ISR.Enabled = True
        End If

        txtCODIGO_ISR.Enabled = lblTitCODIGO_ISR.Enabled
    End Sub

    Private Sub Forma_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Folder.SelectedIndex = 0
            Case Keys.F2
                Folder.SelectedIndex = 1
            Case Keys.F3
                Folder.SelectedIndex = 2
        End Select
    End Sub

    Private Sub Tab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folder.SelectedIndexChanged
        If Modo_Local <> Modo_Baja Then
            If cboPARTICIPA_RETENCION.SelectedValue = "N" Then
                txtCODIGO_ISR.Text = ""
                lblDESCRIP_CODIGO_ISR.Text = ""
                lblTitCODIGO_ISR.Enabled = False
            Else
                lblTitCODIGO_ISR.Enabled = True
            End If

            txtCODIGO_ISR.Enabled = lblTitCODIGO_ISR.Enabled
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Siguiente(True)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim V As String = String.Empty

        System.Windows.Forms.Application.DoEvents()

        If Modo_Local <> Modo_Baja Then
            'F1
            If MyBase.ValidarCampos(Folder.TabPages(0)) = False Then
                Folder.SelectedIndex = 0
                Return
            End If

            'F2
            If MyBase.ValidarCampos(Folder.TabPages(1)) = False Then
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboPAGA_IVA_PROVEEDOR, Nothing)
            If cboPAGA_IVA_PROVEEDOR.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboPAGA_IVA_PROVEEDOR, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboTIPO_PROVEEDOR, Nothing)
            If cboTIPO_PROVEEDOR.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboTIPO_PROVEEDOR, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboORIGEN_PROVEEDOR, Nothing)
            If cboORIGEN_PROVEEDOR.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboORIGEN_PROVEEDOR, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboTOMA_DESCUENTOS, Nothing)
            If cboTOMA_DESCUENTOS.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboTOMA_DESCUENTOS, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboPROVEEDOR_UNICA_VEZ, Nothing)
            If cboPROVEEDOR_UNICA_VEZ.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboPROVEEDOR_UNICA_VEZ, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboESTATUS_PROVEEDOR, Nothing)
            If cboESTATUS_PROVEEDOR.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboESTATUS_PROVEEDOR, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboCONGELADO, Nothing)
            If cboCONGELADO.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboCONGELADO, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            MyBase.ErrorCampos.SetError(cboPARTICIPA_RETENCION, Nothing)
            If cboPARTICIPA_RETENCION.SelectedValue.ToString = "" Then
                MyBase.ErrorCampos.SetError(cboPARTICIPA_RETENCION, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                Folder.SelectedIndex = 1
                Return
            End If

            If cboPARTICIPA_RETENCION.SelectedValue = "S" Then
                MyBase.ErrorCampos.SetError(txtCODIGO_ISR, Nothing)
                If txtCODIGO_ISR.Text = "" Then
                    MyBase.ErrorCampos.SetError(txtCODIGO_ISR, Citi.Synergia.Traductor.Idiomas.GetMensaje(201, "Campo es requerido"))
                    Folder.SelectedIndex = 1
                    Return
                End If
            End If


            'F3
            If MyBase.ValidarCampos(Folder.TabPages(2)) = False Then
                Folder.SelectedIndex = 2
                Return
            End If
        End If

        V = V & "  @CODIGO_PROVEEDOR     = " & sen(txtCODIGO_PROVEEDOR.GetValor())
        V = V & ", @TIPO_PROVEEDOR       = " & Scm(cboTIPO_PROVEEDOR.SelectedValue.ToString)
        V = V & ", @DESCRIPCION_PROV     = " & Scm(txtDESCRIPCION_PROV.Text)
        V = V & ", @nombre_proveedor     = " & Scm(txtnombre_proveedor.Text)
        V = V & ", @direccion_proveedor  = " & Scm(txtdireccion_proveedor.Text)
        V = V & ", @Cod_postal_proveedor = " & sen(txtCod_postal_proveedor.GetValor())
        V = V & ", @telefonos_proveedor  = " & Scm(txttelefonos_proveedor.Text)
        V = V & ", @fax_proveedor        = " & Scm(txtfax_proveedor.Text)
        V = V & ", @nit_proveedor        = " & Scm(txtnit_proveedor.Text)
        V = V & ", @Cedula_proveedor     = " & Scm(txtCedula_proveedor.Text)
        V = V & ", @paga_iva_proveedor   = " & sen(cboPAGA_IVA_PROVEEDOR.SelectedValue.ToString) 'sen(txtpaga_iva_proveedor)
        V = V & ", @comentario1_proveedo = " & Scm(txtcomentario1_proveedo.Text)
        V = V & ", @comentario2_proveedo = " & Scm(txtcomentario2_proveedo.Text)
        V = V & ", @comentario3_proveedo = " & Scm(txtcomentario3_proveedo.Text)
        V = V & ", @comentario4_proveedo = " & Scm(txtcomentario4_proveedo.Text)
        V = V & ", @comentario5_proveedo = " & Scm(txtcomentario5_proveedo.Text)
        V = V & ", @congelado            = " & Scm(cboCONGELADO.SelectedValue.ToString)
        V = V & ", @ORIGEN_PROVEEDOR     = " & Scm(cboORIGEN_PROVEEDOR.SelectedValue.ToString)
        V = V & ", @PROVEEDOR_UNICA_VEZ  = " & Scm(cboPROVEEDOR_UNICA_VEZ.SelectedValue.ToString)
        'V = V & ", @porcentaje_descuento = " & sen(txtporcentaje_descuento.Text)
        V = V & ", @porcentaje_descuento = " & sen(txtporcentaje_descuento.GetValor())
        V = V & ", @TOMA_DESCUENTOS      = " & Scm(cboTOMA_DESCUENTOS.SelectedValue.ToString)
        V = V & ", @CODIGO_CLASE_PROVEED = " & Scm(txtCODIGO_CLASE_PROVEED.Text)
        V = V & ", @CODIGO_BANCO         = " & sen(txtCODIGO_BANCO.GetValor())
        V = V & ", @CODIGO_CUENTA        = " & sen(txtCODIGO_CUENTA.GetValor())
        V = V & ", @CODIGO_DE_MONEDA     = " & Scm(txtCODIGO_DE_MONEDA.Text)
        V = V & ", @CODIGO_DE_PAIS       = " & sen(txtCODIGO_DE_PAIS.GetValor())
        V = V & ", @CODIGO_DE_CONDICION  = " & sen(txtCODIGO_DE_CONDICION.GetValor())
        V = V & ", @CODIGO_IMPUESTO      = " & Scm(txtCODIGO_IMPUESTO.Text)
        V = V & ", @CODIGO_TIPO_PAGO     = " & Scm(txtCODIGO_TIPO_PAGO.Text)
        V = V & ", @SALDO_PROVEEDOR      = " & sen(varSALDO_PROVEEDOR)
        V = V & ", @ANTICIPO_PROVEEDOR   = " & sen(varANTICIPO_PROVEEDOR)
        V = V & ", @ESTATUS_PROVEEDOR    = " & Scm(cboESTATUS_PROVEEDOR.SelectedValue.ToString)
        V = V & ", @NUMERO_REGISTRO      = " & Scm(txtNUMERO_REGISTRO.Text)
        V = V & ", @GIRO_DE_NEGOCIO      = " & Scm(txtGIRO_DE_NEGOCIO.Text)
        V = V & ", @LINEA_DE_CREDITO     = " & sen(txtLINEA_DE_CREDITO.GetValor())
        V = V & ", @CUENTA_PROVEEDOR     = " & Scm(txtCUENTA_PROVEEDOR.Text)
        V = V & ", @PARTICIPA_RETENCION  = " & Scm(cboPARTICIPA_RETENCION.SelectedValue.ToString)
        V = V & ", @CODIGO_ISR           = " & Scm(txtCODIGO_ISR.Text)
        V = V & ", @REFERENCIA_PROVEEDOR = " & Scm(txtREFERENCIA_PROVEEDOR.Text)
        V = V & ", @FORMATO_ORDEN_COMPRA = " & Scm(txtFORMATO_ORDEN_COMPRA.Text)
        V = V & ", @ACEPTA_ENVIO_PARCIAL = " & Scm(cboACEPTA_ENVIO_PARCIAL.SelectedValue.ToString)
        V = V & ", @DIRECCION_EMAIL      = " & Scm(txtDIRECCION_EMAIL.Text)

        'CITI: Se elimina, ver text del control
        'V = V & ", @NOMBRE_BENEFICIARIO  = " & scm(txtNOMBRE_BENEFICIARIO)

        SysTimeStamp = TimeStamp_Local
        Modo = Modo_Local

        If sp("PROVEEDORES", V) Then
            Grabado = True
            Me.HubieronCambios = True
            Me.Siguiente()
        End If
    End Sub
End Class