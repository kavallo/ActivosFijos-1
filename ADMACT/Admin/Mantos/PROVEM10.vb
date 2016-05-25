Public Class PROVEM10
    Public Property CodigoProveedor As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        txtCODIGO_PROVEEDOR.Text = Me.CodigoProveedor

        Me.LlenarCombos()

        Me.Leer()
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
    End Sub

    Private Sub Leer()
        Try
            meteSQL("select")
            meteSQL(" ltrim(str(PROVEEDORES.SALDO_PROVEEDOR,14,2)), ")
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
            meteSQL(" REFERENCIA_PROVEEDOR ")
            meteSQL("from PROVEEDORES ")
            meteSQL(" where PROVEEDORES.CODIGO_PROVEEDOR = " & sen(Me.CodigoProveedor))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                txtSALDO_PROVEEDOR.Text = SqlData(Sqlconn, 1).ToString
                txtDESCRIPCION_PROV.Text = SqlData(Sqlconn, 2).ToString
                txtnombre_proveedor.Text = SqlData(Sqlconn, 3).ToString
                txtdireccion_proveedor.Text = SqlData(Sqlconn, 4).ToString
                txttelefonos_proveedor.Text = SqlData(Sqlconn, 5).ToString
                txtfax_proveedor.Text = SqlData(Sqlconn, 6).ToString
                txtnit_proveedor.Text = SqlData(Sqlconn, 7).ToString
                txtCedula_proveedor.Text = SqlData(Sqlconn, 8).ToString
                txtCod_postal_proveedor.Text = SqlData(Sqlconn, 9).ToString
                txtANTICIPO_PROVEEDOR.Text = SqlData(Sqlconn, 10).ToString
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
                cbopaga_iva_proveedor.SelectedValue = SqlData(Sqlconn, 26).ToString
                txtporcentaje_descuento.Text = String.Format("{0:0.00000}", SqlData(Sqlconn, 27))
                cboESTATUS_PROVEEDOR.SelectedValue = SqlData(Sqlconn, 28).ToString
                cboTOMA_DESCUENTOS.SelectedValue = SqlData(Sqlconn, 29).ToString
                cboORIGEN_PROVEEDOR.SelectedValue = SqlData(Sqlconn, 30).ToString
                cbocongelado.SelectedValue = SqlData(Sqlconn, 31).ToString
                txtNUMERO_REGISTRO.Text = SqlData(Sqlconn, 32).ToString
                txtGIRO_DE_NEGOCIO.Text = SqlData(Sqlconn, 33).ToString
                txtLINEA_DE_CREDITO.Text = SqlData(Sqlconn, 34).ToString
                lblCUENTA_PROVEEDOR.Text = SqlData(Sqlconn, 35).ToString
                cboPARTICIPA_RETENCION.SelectedValue = SqlData(Sqlconn, 36).ToString
                txtCODIGO_ISR.Text = SqlData(Sqlconn, 37).ToString
                lblREFERENCIA_PROVEEDOR.Text = SqlData(Sqlconn, 38).ToString
            Loop

            Me.PoneDescripcion()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PoneDescripcion()
        lblDESCRIPCION_IMPUESTO.Text = ""
        lblNOMBRE_BANCO.Text = ""
        lblDESCRIPCION_CLASE.Text = ""
        lblNOMBRE_CUENTA.Text = ""
        lblDESCRIPCI_CONDICION.Text = ""
        lblDESCRIPCION_MONEDA.Text = ""
        lblNOMBRE_DEL_PAIS.Text = ""
        lblDESC_TIPO_PAGO.Text = ""
        lblDESCRIP_CODIGO_ISR.Text = ""

        If txtCODIGO_IMPUESTO.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_IMPUESTO.Text))) Then
                lblDESCRIPCION_IMPUESTO.Text = TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_IMPUESTO.Text)).ToString
            End If
        End If

        If txtCODIGO_BANCO.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select ltrim(substring(NOMBRE_BANCO,1,18)) from BANCOS where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.Text))) Then
                lblNOMBRE_BANCO.Text = TraeDato("select ltrim(substring(NOMBRE_BANCO,1,18)) from BANCOS where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.Text)).ToString
            End If
        End If

        If txtCODIGO_CLASE_PROVEED.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_CLASE,1,18) from CLASE_PROVEEDOR where CODIGO_CLASE_PROVEED = " & Scm(txtCODIGO_CLASE_PROVEED.Text))) Then
                lblDESCRIPCION_CLASE.Text = TraeDato("select substring(DESCRIPCION_CLASE,1,18) from CLASE_PROVEEDOR where CODIGO_CLASE_PROVEED = " & Scm(txtCODIGO_CLASE_PROVEED.Text)).ToString
            End If
        End If

        If txtCODIGO_CUENTA.Text <> "" And txtCODIGO_BANCO.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(NOMBRE_CUENTA,1,18) from CUENTA_BANCO where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.Text) & " and CODIGO_CUENTA = " & sen(txtCODIGO_CUENTA.Text))) Then
                lblNOMBRE_CUENTA.Text = TraeDato("select substring(NOMBRE_CUENTA,1,18) from CUENTA_BANCO where CODIGO_BANCO = " & sen(txtCODIGO_BANCO.Text) & " and CODIGO_CUENTA = " & sen(txtCODIGO_CUENTA.Text)).ToString
            End If
        End If

        If txtCODIGO_DE_CONDICION.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCI_CONDICION,1,18) from CONDICIONES_DE_PAGO where CODIGO_DE_CONDICION = " & sen(txtCODIGO_DE_CONDICION.Text))) Then
                lblDESCRIPCI_CONDICION.Text = TraeDato("select substring(DESCRIPCI_CONDICION,1,18) from CONDICIONES_DE_PAGO where CODIGO_DE_CONDICION = " & sen(txtCODIGO_DE_CONDICION.Text)).ToString
            End If
        End If

        If txtCODIGO_DE_MONEDA.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_MONEDA,1,19) from MONEDAS where CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text))) Then
                lblDESCRIPCION_MONEDA.Text = TraeDato("select substring(DESCRIPCION_MONEDA,1,19) from MONEDAS where CODIGO_DE_MONEDA = " & Scm(txtCODIGO_DE_MONEDA.Text)).ToString
            End If
        End If

        If txtCODIGO_DE_PAIS.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(NOMBRE_DEL_PAIS,1,18) from MAESTRO_PAISES where CODIGO_DE_PAIS = " & sen(txtCODIGO_DE_PAIS.Text))) Then
                lblNOMBRE_DEL_PAIS.Text = TraeDato("select substring(NOMBRE_DEL_PAIS,1,18) from MAESTRO_PAISES where CODIGO_DE_PAIS = " & sen(txtCODIGO_DE_PAIS.Text)).ToString
            End If
        End If

        If txtCODIGO_TIPO_PAGO.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(DESC_TIPO_PAGO,1,18) from TIPOS_DE_PAGO where CODIGO_TIPO_PAGO = " & Scm(txtCODIGO_TIPO_PAGO.Text))) Then
                lblDESC_TIPO_PAGO.Text = TraeDato("select substring(DESC_TIPO_PAGO,1,18) from TIPOS_DE_PAGO where CODIGO_TIPO_PAGO = " & Scm(txtCODIGO_TIPO_PAGO.Text)).ToString
            End If
        End If

        If txtCODIGO_ISR.Text <> "" Then
            If Not String.IsNullOrEmpty(TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_ISR.Text))) Then
                lblDESCRIP_CODIGO_ISR.Text = TraeDato("select substring(DESCRIPCION_IMPUESTO,1,18) from IMPUESTOS where CODIGO_IMPUESTO = " & Scm(txtCODIGO_ISR.Text)).ToString
            End If
        End If
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

    Private Sub ParticipaRetencion_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPARTICIPA_RETENCION.SelectedValueChanged
        If Modo_Local = Modo_Baja Then Exit Sub
        If cboPARTICIPA_RETENCION.SelectedValue = "N" Then
            txtCODIGO_ISR.Text = ""
            lblDESCRIP_CODIGO_ISR.Text = ""
            lblTitCODIGO_ISR.Enabled = False
            txtCODIGO_ISR.Enabled = False
        Else
            lblTitCODIGO_ISR.Enabled = True
            txtCODIGO_ISR.Enabled = True
        End If
    End Sub

    Private Sub Tab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folder.SelectedIndexChanged
        If Modo_Local <> Modo_Baja Then
            If cboPARTICIPA_RETENCION.SelectedValue = "N" Then
                txtCODIGO_ISR.Text = ""
                lblDESCRIP_CODIGO_ISR.Text = ""
                lblTitCODIGO_ISR.Enabled = False
                txtCODIGO_ISR.Enabled = False
            Else
                lblTitCODIGO_ISR.Enabled = True
                txtCODIGO_ISR.Enabled = True
            End If
        End If
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class