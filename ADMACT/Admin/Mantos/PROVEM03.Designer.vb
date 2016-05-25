<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROVEM03
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento  ' System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Folder = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtCODIGO_PROVEEDOR = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtnombre_proveedor = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtcomentario4_proveedo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtcomentario3_proveedo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtcomentario2_proveedo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtcomentario1_proveedo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCod_postal_proveedor = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCedula_proveedor = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtnit_proveedor = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtfax_proveedor = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txttelefonos_proveedor = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtdireccion_proveedor = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIPCION_PROV = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtcomentario5_proveedo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitcomentario1_proveedo = New System.Windows.Forms.Label()
        Me.lblTitCod_postal_proveedor = New System.Windows.Forms.Label()
        Me.lblTitCedula_proveedor = New System.Windows.Forms.Label()
        Me.lblTitnit_proveedor = New System.Windows.Forms.Label()
        Me.lblTitfax_proveedor = New System.Windows.Forms.Label()
        Me.lblTittelefonos_proveedor = New System.Windows.Forms.Label()
        Me.lblTitdireccion_proveedor = New System.Windows.Forms.Label()
        Me.lblTitnombre_proveedor = New System.Windows.Forms.Label()
        Me.lblTitDESCRIPCION_PROV = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboPARTICIPA_RETENCION = New System.Windows.Forms.ComboBox()
        Me.cboCONGELADO = New System.Windows.Forms.ComboBox()
        Me.cboESTATUS_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.cboPROVEEDOR_UNICA_VEZ = New System.Windows.Forms.ComboBox()
        Me.cboTOMA_DESCUENTOS = New System.Windows.Forms.ComboBox()
        Me.cboORIGEN_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.cboTIPO_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.cboPAGA_IVA_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.txtCUENTA_PROVEEDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblREFERENCIA_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblDESCRIP_CODIGO_ISR = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_ISR = New System.Windows.Forms.Label()
        Me.lblTitPARTICIPA_RETENCION = New System.Windows.Forms.Label()
        Me.lblTitLINEA_DE_CREDITO = New System.Windows.Forms.Label()
        Me.lblTitGIRO_DE_NEGOCIO = New System.Windows.Forms.Label()
        Me.lblTitNUMERO_REGISTRO = New System.Windows.Forms.Label()
        Me.lblTitcongelado = New System.Windows.Forms.Label()
        Me.lblTitORIGEN_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblTitTOMA_DESCUENTOS = New System.Windows.Forms.Label()
        Me.lblTitESTATUS_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblTitporcentaje_descuento = New System.Windows.Forms.Label()
        Me.lblTitpaga_iva_proveedor = New System.Windows.Forms.Label()
        Me.lblTitPROVEEDOR_UNICA_VEZ = New System.Windows.Forms.Label()
        Me.txtREFERENCIA_PROVEEDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_ISR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNUMERO_REGISTRO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtGIRO_DE_NEGOCIO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtLINEA_DE_CREDITO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtporcentaje_descuento = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblTitTIPO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblTitCUENTA_PROVEEDOR = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtCODIGO_CLASE_PROVEED = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_BANCO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCODIGO_CUENTA = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCODIGO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_DE_CONDICION = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCODIGO_TIPO_PAGO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_DE_PAIS = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCODIGO_IMPUESTO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboACEPTA_ENVIO_PARCIAL = New System.Windows.Forms.ComboBox()
        Me.txtFORMATO_ORDEN_COMPRA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDIRECCION_EMAIL = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNOMBRE_BENEFICIARIO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDESCRIPCION_CLASE = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_IMPUESTO = New System.Windows.Forms.Label()
        Me.lblNOMBRE_DEL_PAIS = New System.Windows.Forms.Label()
        Me.lblNOMBRE_CUENTA = New System.Windows.Forms.Label()
        Me.lblDESC_TIPO_PAGO = New System.Windows.Forms.Label()
        Me.lblDESCRIPCI_CONDICION = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_MONEDA = New System.Windows.Forms.Label()
        Me.lblNOMBRE_BANCO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_PAIS = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_IMPUESTO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_CONDICION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CUENTA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CLASE_PROVEED = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_TIPO_PAGO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_BANCO = New System.Windows.Forms.Label()
        Me.lblTitFORMATO_ORDEN_COMPRA = New System.Windows.Forms.Label()
        Me.lblTitDIRECCION_EMAIL = New System.Windows.Forms.Label()
        Me.lblTitACEPTA_ENVIO_PARCIAL = New System.Windows.Forms.Label()
        Me.lblTitNOMBRE_BENEFICIARIO = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Folder.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(549, 428)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(456, 428)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Folder
        '
        Me.Folder.Controls.Add(Me.TabPage1)
        Me.Folder.Controls.Add(Me.TabPage2)
        Me.Folder.Controls.Add(Me.TabPage3)
        Me.Folder.Location = New System.Drawing.Point(12, 12)
        Me.Folder.Name = "Folder"
        Me.Folder.SelectedIndex = 0
        Me.Folder.Size = New System.Drawing.Size(624, 410)
        Me.Folder.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.txtCODIGO_PROVEEDOR)
        Me.TabPage1.Controls.Add(Me.txtnombre_proveedor)
        Me.TabPage1.Controls.Add(Me.txtcomentario4_proveedo)
        Me.TabPage1.Controls.Add(Me.txtcomentario3_proveedo)
        Me.TabPage1.Controls.Add(Me.txtcomentario2_proveedo)
        Me.TabPage1.Controls.Add(Me.txtcomentario1_proveedo)
        Me.TabPage1.Controls.Add(Me.txtCod_postal_proveedor)
        Me.TabPage1.Controls.Add(Me.txtCedula_proveedor)
        Me.TabPage1.Controls.Add(Me.txtnit_proveedor)
        Me.TabPage1.Controls.Add(Me.txtfax_proveedor)
        Me.TabPage1.Controls.Add(Me.txttelefonos_proveedor)
        Me.TabPage1.Controls.Add(Me.txtdireccion_proveedor)
        Me.TabPage1.Controls.Add(Me.txtDESCRIPCION_PROV)
        Me.TabPage1.Controls.Add(Me.txtcomentario5_proveedo)
        Me.TabPage1.Controls.Add(Me.lblTitcomentario1_proveedo)
        Me.TabPage1.Controls.Add(Me.lblTitCod_postal_proveedor)
        Me.TabPage1.Controls.Add(Me.lblTitCedula_proveedor)
        Me.TabPage1.Controls.Add(Me.lblTitnit_proveedor)
        Me.TabPage1.Controls.Add(Me.lblTitfax_proveedor)
        Me.TabPage1.Controls.Add(Me.lblTittelefonos_proveedor)
        Me.TabPage1.Controls.Add(Me.lblTitdireccion_proveedor)
        Me.TabPage1.Controls.Add(Me.lblTitnombre_proveedor)
        Me.TabPage1.Controls.Add(Me.lblTitDESCRIPCION_PROV)
        Me.TabPage1.Controls.Add(Me.lblTitCODIGO_PROVEEDOR)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(616, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos generales ( F1 )"
        '
        'txtCODIGO_PROVEEDOR
        '
        Me.txtCODIGO_PROVEEDOR.AcceptsReturn = True
        Me.txtCODIGO_PROVEEDOR.BackColor = System.Drawing.Color.White
        Me.txtCODIGO_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_PROVEEDOR.EsRequerido = True
        Me.txtCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_PROVEEDOR.LabelConsulta = Nothing
        Me.txtCODIGO_PROVEEDOR.Location = New System.Drawing.Point(135, 15)
        Me.txtCODIGO_PROVEEDOR.MaxLength = 10
        Me.txtCODIGO_PROVEEDOR.Multiline = True
        Me.txtCODIGO_PROVEEDOR.Name = "txtCODIGO_PROVEEDOR"
        Me.txtCODIGO_PROVEEDOR.NombreDeConsulta = Nothing
        Me.txtCODIGO_PROVEEDOR.NumeroDecimales = 0
        Me.txtCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_PROVEEDOR.Size = New System.Drawing.Size(87, 20)
        Me.txtCODIGO_PROVEEDOR.TabIndex = 1
        Me.txtCODIGO_PROVEEDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnombre_proveedor
        '
        Me.txtnombre_proveedor.AcceptsReturn = True
        Me.txtnombre_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtnombre_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombre_proveedor.EsRequerido = True
        Me.txtnombre_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnombre_proveedor.LabelConsulta = Nothing
        Me.txtnombre_proveedor.Location = New System.Drawing.Point(135, 41)
        Me.txtnombre_proveedor.MaxLength = 60
        Me.txtnombre_proveedor.Name = "txtnombre_proveedor"
        Me.txtnombre_proveedor.NombreDeConsulta = Nothing
        Me.txtnombre_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnombre_proveedor.Size = New System.Drawing.Size(454, 20)
        Me.txtnombre_proveedor.TabIndex = 2
        '
        'txtcomentario4_proveedo
        '
        Me.txtcomentario4_proveedo.AcceptsReturn = True
        Me.txtcomentario4_proveedo.BackColor = System.Drawing.SystemColors.Window
        Me.txtcomentario4_proveedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario4_proveedo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcomentario4_proveedo.EsRequerido = False
        Me.txtcomentario4_proveedo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomentario4_proveedo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcomentario4_proveedo.LabelConsulta = Nothing
        Me.txtcomentario4_proveedo.Location = New System.Drawing.Point(135, 309)
        Me.txtcomentario4_proveedo.MaxLength = 40
        Me.txtcomentario4_proveedo.Name = "txtcomentario4_proveedo"
        Me.txtcomentario4_proveedo.NombreDeConsulta = Nothing
        Me.txtcomentario4_proveedo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcomentario4_proveedo.Size = New System.Drawing.Size(347, 20)
        Me.txtcomentario4_proveedo.TabIndex = 13
        '
        'txtcomentario3_proveedo
        '
        Me.txtcomentario3_proveedo.AcceptsReturn = True
        Me.txtcomentario3_proveedo.BackColor = System.Drawing.SystemColors.Window
        Me.txtcomentario3_proveedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario3_proveedo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcomentario3_proveedo.EsRequerido = False
        Me.txtcomentario3_proveedo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomentario3_proveedo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcomentario3_proveedo.LabelConsulta = Nothing
        Me.txtcomentario3_proveedo.Location = New System.Drawing.Point(135, 289)
        Me.txtcomentario3_proveedo.MaxLength = 40
        Me.txtcomentario3_proveedo.Name = "txtcomentario3_proveedo"
        Me.txtcomentario3_proveedo.NombreDeConsulta = Nothing
        Me.txtcomentario3_proveedo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcomentario3_proveedo.Size = New System.Drawing.Size(347, 20)
        Me.txtcomentario3_proveedo.TabIndex = 12
        '
        'txtcomentario2_proveedo
        '
        Me.txtcomentario2_proveedo.AcceptsReturn = True
        Me.txtcomentario2_proveedo.BackColor = System.Drawing.SystemColors.Window
        Me.txtcomentario2_proveedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario2_proveedo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcomentario2_proveedo.EsRequerido = False
        Me.txtcomentario2_proveedo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomentario2_proveedo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcomentario2_proveedo.LabelConsulta = Nothing
        Me.txtcomentario2_proveedo.Location = New System.Drawing.Point(135, 269)
        Me.txtcomentario2_proveedo.MaxLength = 40
        Me.txtcomentario2_proveedo.Name = "txtcomentario2_proveedo"
        Me.txtcomentario2_proveedo.NombreDeConsulta = Nothing
        Me.txtcomentario2_proveedo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcomentario2_proveedo.Size = New System.Drawing.Size(347, 20)
        Me.txtcomentario2_proveedo.TabIndex = 11
        '
        'txtcomentario1_proveedo
        '
        Me.txtcomentario1_proveedo.AcceptsReturn = True
        Me.txtcomentario1_proveedo.BackColor = System.Drawing.SystemColors.Window
        Me.txtcomentario1_proveedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario1_proveedo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcomentario1_proveedo.EsRequerido = False
        Me.txtcomentario1_proveedo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomentario1_proveedo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcomentario1_proveedo.LabelConsulta = Nothing
        Me.txtcomentario1_proveedo.Location = New System.Drawing.Point(135, 249)
        Me.txtcomentario1_proveedo.MaxLength = 40
        Me.txtcomentario1_proveedo.Name = "txtcomentario1_proveedo"
        Me.txtcomentario1_proveedo.NombreDeConsulta = Nothing
        Me.txtcomentario1_proveedo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcomentario1_proveedo.Size = New System.Drawing.Size(347, 20)
        Me.txtcomentario1_proveedo.TabIndex = 10
        '
        'txtCod_postal_proveedor
        '
        Me.txtCod_postal_proveedor.AcceptsReturn = True
        Me.txtCod_postal_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_postal_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCod_postal_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_postal_proveedor.EsRequerido = False
        Me.txtCod_postal_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod_postal_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_postal_proveedor.LabelConsulta = Nothing
        Me.txtCod_postal_proveedor.Location = New System.Drawing.Point(135, 223)
        Me.txtCod_postal_proveedor.MaxLength = 5
        Me.txtCod_postal_proveedor.Multiline = True
        Me.txtCod_postal_proveedor.Name = "txtCod_postal_proveedor"
        Me.txtCod_postal_proveedor.NombreDeConsulta = Nothing
        Me.txtCod_postal_proveedor.NumeroDecimales = 0
        Me.txtCod_postal_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_postal_proveedor.Size = New System.Drawing.Size(87, 20)
        Me.txtCod_postal_proveedor.TabIndex = 9
        Me.txtCod_postal_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCedula_proveedor
        '
        Me.txtCedula_proveedor.AcceptsReturn = True
        Me.txtCedula_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtCedula_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCedula_proveedor.EsRequerido = False
        Me.txtCedula_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCedula_proveedor.LabelConsulta = Nothing
        Me.txtCedula_proveedor.Location = New System.Drawing.Point(135, 197)
        Me.txtCedula_proveedor.MaxLength = 15
        Me.txtCedula_proveedor.Name = "txtCedula_proveedor"
        Me.txtCedula_proveedor.NombreDeConsulta = Nothing
        Me.txtCedula_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCedula_proveedor.Size = New System.Drawing.Size(174, 20)
        Me.txtCedula_proveedor.TabIndex = 8
        '
        'txtnit_proveedor
        '
        Me.txtnit_proveedor.AcceptsReturn = True
        Me.txtnit_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtnit_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnit_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnit_proveedor.EsRequerido = False
        Me.txtnit_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnit_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnit_proveedor.LabelConsulta = Nothing
        Me.txtnit_proveedor.Location = New System.Drawing.Point(135, 171)
        Me.txtnit_proveedor.MaxLength = 25
        Me.txtnit_proveedor.Name = "txtnit_proveedor"
        Me.txtnit_proveedor.NombreDeConsulta = Nothing
        Me.txtnit_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnit_proveedor.Size = New System.Drawing.Size(174, 20)
        Me.txtnit_proveedor.TabIndex = 7
        '
        'txtfax_proveedor
        '
        Me.txtfax_proveedor.AcceptsReturn = True
        Me.txtfax_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtfax_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfax_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfax_proveedor.EsRequerido = False
        Me.txtfax_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfax_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfax_proveedor.LabelConsulta = Nothing
        Me.txtfax_proveedor.Location = New System.Drawing.Point(135, 145)
        Me.txtfax_proveedor.MaxLength = 20
        Me.txtfax_proveedor.Name = "txtfax_proveedor"
        Me.txtfax_proveedor.NombreDeConsulta = Nothing
        Me.txtfax_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtfax_proveedor.Size = New System.Drawing.Size(174, 20)
        Me.txtfax_proveedor.TabIndex = 6
        Me.txtfax_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttelefonos_proveedor
        '
        Me.txttelefonos_proveedor.AcceptsReturn = True
        Me.txttelefonos_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txttelefonos_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefonos_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttelefonos_proveedor.EsRequerido = False
        Me.txttelefonos_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefonos_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txttelefonos_proveedor.LabelConsulta = Nothing
        Me.txttelefonos_proveedor.Location = New System.Drawing.Point(135, 119)
        Me.txttelefonos_proveedor.MaxLength = 20
        Me.txttelefonos_proveedor.Name = "txttelefonos_proveedor"
        Me.txttelefonos_proveedor.NombreDeConsulta = Nothing
        Me.txttelefonos_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttelefonos_proveedor.Size = New System.Drawing.Size(174, 20)
        Me.txttelefonos_proveedor.TabIndex = 5
        Me.txttelefonos_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdireccion_proveedor
        '
        Me.txtdireccion_proveedor.AcceptsReturn = True
        Me.txtdireccion_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtdireccion_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdireccion_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdireccion_proveedor.EsRequerido = False
        Me.txtdireccion_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdireccion_proveedor.LabelConsulta = Nothing
        Me.txtdireccion_proveedor.Location = New System.Drawing.Point(135, 93)
        Me.txtdireccion_proveedor.MaxLength = 60
        Me.txtdireccion_proveedor.Name = "txtdireccion_proveedor"
        Me.txtdireccion_proveedor.NombreDeConsulta = Nothing
        Me.txtdireccion_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdireccion_proveedor.Size = New System.Drawing.Size(454, 20)
        Me.txtdireccion_proveedor.TabIndex = 4
        '
        'txtDESCRIPCION_PROV
        '
        Me.txtDESCRIPCION_PROV.AcceptsReturn = True
        Me.txtDESCRIPCION_PROV.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION_PROV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION_PROV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION_PROV.EsRequerido = False
        Me.txtDESCRIPCION_PROV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION_PROV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION_PROV.LabelConsulta = Nothing
        Me.txtDESCRIPCION_PROV.Location = New System.Drawing.Point(135, 67)
        Me.txtDESCRIPCION_PROV.MaxLength = 40
        Me.txtDESCRIPCION_PROV.Name = "txtDESCRIPCION_PROV"
        Me.txtDESCRIPCION_PROV.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION_PROV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION_PROV.Size = New System.Drawing.Size(454, 20)
        Me.txtDESCRIPCION_PROV.TabIndex = 3
        '
        'txtcomentario5_proveedo
        '
        Me.txtcomentario5_proveedo.AcceptsReturn = True
        Me.txtcomentario5_proveedo.BackColor = System.Drawing.Color.White
        Me.txtcomentario5_proveedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario5_proveedo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcomentario5_proveedo.EsRequerido = False
        Me.txtcomentario5_proveedo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomentario5_proveedo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcomentario5_proveedo.LabelConsulta = Nothing
        Me.txtcomentario5_proveedo.Location = New System.Drawing.Point(135, 329)
        Me.txtcomentario5_proveedo.MaxLength = 40
        Me.txtcomentario5_proveedo.Name = "txtcomentario5_proveedo"
        Me.txtcomentario5_proveedo.NombreDeConsulta = Nothing
        Me.txtcomentario5_proveedo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcomentario5_proveedo.Size = New System.Drawing.Size(347, 20)
        Me.txtcomentario5_proveedo.TabIndex = 14
        '
        'lblTitcomentario1_proveedo
        '
        Me.lblTitcomentario1_proveedo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitcomentario1_proveedo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitcomentario1_proveedo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitcomentario1_proveedo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitcomentario1_proveedo.Location = New System.Drawing.Point(6, 251)
        Me.lblTitcomentario1_proveedo.Name = "lblTitcomentario1_proveedo"
        Me.lblTitcomentario1_proveedo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitcomentario1_proveedo.Size = New System.Drawing.Size(123, 14)
        Me.lblTitcomentario1_proveedo.TabIndex = 47
        Me.lblTitcomentario1_proveedo.Text = "[Comentarios]"
        '
        'lblTitCod_postal_proveedor
        '
        Me.lblTitCod_postal_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCod_postal_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCod_postal_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCod_postal_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCod_postal_proveedor.Location = New System.Drawing.Point(6, 225)
        Me.lblTitCod_postal_proveedor.Name = "lblTitCod_postal_proveedor"
        Me.lblTitCod_postal_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCod_postal_proveedor.Size = New System.Drawing.Size(123, 14)
        Me.lblTitCod_postal_proveedor.TabIndex = 46
        Me.lblTitCod_postal_proveedor.Text = "[Código postal]"
        '
        'lblTitCedula_proveedor
        '
        Me.lblTitCedula_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCedula_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCedula_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCedula_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCedula_proveedor.Location = New System.Drawing.Point(6, 199)
        Me.lblTitCedula_proveedor.Name = "lblTitCedula_proveedor"
        Me.lblTitCedula_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCedula_proveedor.Size = New System.Drawing.Size(123, 14)
        Me.lblTitCedula_proveedor.TabIndex = 45
        Me.lblTitCedula_proveedor.Text = "[Cédula]"
        '
        'lblTitnit_proveedor
        '
        Me.lblTitnit_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTitnit_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitnit_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitnit_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitnit_proveedor.Location = New System.Drawing.Point(6, 173)
        Me.lblTitnit_proveedor.Name = "lblTitnit_proveedor"
        Me.lblTitnit_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitnit_proveedor.Size = New System.Drawing.Size(123, 14)
        Me.lblTitnit_proveedor.TabIndex = 44
        Me.lblTitnit_proveedor.Text = "[NIT]"
        '
        'lblTitfax_proveedor
        '
        Me.lblTitfax_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTitfax_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitfax_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitfax_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitfax_proveedor.Location = New System.Drawing.Point(6, 147)
        Me.lblTitfax_proveedor.Name = "lblTitfax_proveedor"
        Me.lblTitfax_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitfax_proveedor.Size = New System.Drawing.Size(123, 14)
        Me.lblTitfax_proveedor.TabIndex = 43
        Me.lblTitfax_proveedor.Text = "[Fax]"
        '
        'lblTittelefonos_proveedor
        '
        Me.lblTittelefonos_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTittelefonos_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTittelefonos_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittelefonos_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTittelefonos_proveedor.Location = New System.Drawing.Point(6, 121)
        Me.lblTittelefonos_proveedor.Name = "lblTittelefonos_proveedor"
        Me.lblTittelefonos_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTittelefonos_proveedor.Size = New System.Drawing.Size(123, 14)
        Me.lblTittelefonos_proveedor.TabIndex = 42
        Me.lblTittelefonos_proveedor.Text = "[Teléfonos]"
        '
        'lblTitdireccion_proveedor
        '
        Me.lblTitdireccion_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTitdireccion_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitdireccion_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitdireccion_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitdireccion_proveedor.Location = New System.Drawing.Point(6, 95)
        Me.lblTitdireccion_proveedor.Name = "lblTitdireccion_proveedor"
        Me.lblTitdireccion_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitdireccion_proveedor.Size = New System.Drawing.Size(123, 14)
        Me.lblTitdireccion_proveedor.TabIndex = 41
        Me.lblTitdireccion_proveedor.Text = "[Dirección]"
        '
        'lblTitnombre_proveedor
        '
        Me.lblTitnombre_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTitnombre_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitnombre_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitnombre_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitnombre_proveedor.Location = New System.Drawing.Point(6, 43)
        Me.lblTitnombre_proveedor.Name = "lblTitnombre_proveedor"
        Me.lblTitnombre_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitnombre_proveedor.Size = New System.Drawing.Size(123, 14)
        Me.lblTitnombre_proveedor.TabIndex = 40
        Me.lblTitnombre_proveedor.Text = "Nombre"
        '
        'lblTitDESCRIPCION_PROV
        '
        Me.lblTitDESCRIPCION_PROV.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION_PROV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_PROV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_PROV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_PROV.Location = New System.Drawing.Point(6, 69)
        Me.lblTitDESCRIPCION_PROV.Name = "lblTitDESCRIPCION_PROV"
        Me.lblTitDESCRIPCION_PROV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_PROV.Size = New System.Drawing.Size(123, 14)
        Me.lblTitDESCRIPCION_PROV.TabIndex = 39
        Me.lblTitDESCRIPCION_PROV.Text = "[Contacto]"
        '
        'lblTitCODIGO_PROVEEDOR
        '
        Me.lblTitCODIGO_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_PROVEEDOR.Location = New System.Drawing.Point(6, 17)
        Me.lblTitCODIGO_PROVEEDOR.Name = "lblTitCODIGO_PROVEEDOR"
        Me.lblTitCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_PROVEEDOR.Size = New System.Drawing.Size(123, 14)
        Me.lblTitCODIGO_PROVEEDOR.TabIndex = 38
        Me.lblTitCODIGO_PROVEEDOR.Text = "Proveedor"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.cboPARTICIPA_RETENCION)
        Me.TabPage2.Controls.Add(Me.cboCONGELADO)
        Me.TabPage2.Controls.Add(Me.cboESTATUS_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.cboPROVEEDOR_UNICA_VEZ)
        Me.TabPage2.Controls.Add(Me.cboTOMA_DESCUENTOS)
        Me.TabPage2.Controls.Add(Me.cboORIGEN_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.cboTIPO_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.cboPAGA_IVA_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.txtCUENTA_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.lblREFERENCIA_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.lblDESCRIP_CODIGO_ISR)
        Me.TabPage2.Controls.Add(Me.lblTitCODIGO_ISR)
        Me.TabPage2.Controls.Add(Me.lblTitPARTICIPA_RETENCION)
        Me.TabPage2.Controls.Add(Me.lblTitLINEA_DE_CREDITO)
        Me.TabPage2.Controls.Add(Me.lblTitGIRO_DE_NEGOCIO)
        Me.TabPage2.Controls.Add(Me.lblTitNUMERO_REGISTRO)
        Me.TabPage2.Controls.Add(Me.lblTitcongelado)
        Me.TabPage2.Controls.Add(Me.lblTitORIGEN_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.lblTitTOMA_DESCUENTOS)
        Me.TabPage2.Controls.Add(Me.lblTitESTATUS_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.lblTitporcentaje_descuento)
        Me.TabPage2.Controls.Add(Me.lblTitpaga_iva_proveedor)
        Me.TabPage2.Controls.Add(Me.lblTitPROVEEDOR_UNICA_VEZ)
        Me.TabPage2.Controls.Add(Me.txtREFERENCIA_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.txtCODIGO_ISR)
        Me.TabPage2.Controls.Add(Me.txtNUMERO_REGISTRO)
        Me.TabPage2.Controls.Add(Me.txtGIRO_DE_NEGOCIO)
        Me.TabPage2.Controls.Add(Me.txtLINEA_DE_CREDITO)
        Me.TabPage2.Controls.Add(Me.txtporcentaje_descuento)
        Me.TabPage2.Controls.Add(Me.lblTitTIPO_PROVEEDOR)
        Me.TabPage2.Controls.Add(Me.lblTitCUENTA_PROVEEDOR)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(616, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Características ( F2 )"
        '
        'cboPARTICIPA_RETENCION
        '
        Me.cboPARTICIPA_RETENCION.BackColor = System.Drawing.SystemColors.Window
        Me.cboPARTICIPA_RETENCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPARTICIPA_RETENCION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPARTICIPA_RETENCION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPARTICIPA_RETENCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPARTICIPA_RETENCION.Location = New System.Drawing.Point(170, 253)
        Me.cboPARTICIPA_RETENCION.Name = "cboPARTICIPA_RETENCION"
        Me.cboPARTICIPA_RETENCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPARTICIPA_RETENCION.Size = New System.Drawing.Size(275, 22)
        Me.cboPARTICIPA_RETENCION.TabIndex = 11
        '
        'cboCONGELADO
        '
        Me.cboCONGELADO.BackColor = System.Drawing.SystemColors.Window
        Me.cboCONGELADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCONGELADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCONGELADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCONGELADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCONGELADO.Location = New System.Drawing.Point(170, 173)
        Me.cboCONGELADO.Name = "cboCONGELADO"
        Me.cboCONGELADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCONGELADO.Size = New System.Drawing.Size(275, 22)
        Me.cboCONGELADO.TabIndex = 8
        '
        'cboESTATUS_PROVEEDOR
        '
        Me.cboESTATUS_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.cboESTATUS_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboESTATUS_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboESTATUS_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboESTATUS_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboESTATUS_PROVEEDOR.Location = New System.Drawing.Point(170, 151)
        Me.cboESTATUS_PROVEEDOR.Name = "cboESTATUS_PROVEEDOR"
        Me.cboESTATUS_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboESTATUS_PROVEEDOR.Size = New System.Drawing.Size(275, 22)
        Me.cboESTATUS_PROVEEDOR.TabIndex = 7
        '
        'cboPROVEEDOR_UNICA_VEZ
        '
        Me.cboPROVEEDOR_UNICA_VEZ.BackColor = System.Drawing.SystemColors.Window
        Me.cboPROVEEDOR_UNICA_VEZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPROVEEDOR_UNICA_VEZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPROVEEDOR_UNICA_VEZ.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPROVEEDOR_UNICA_VEZ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPROVEEDOR_UNICA_VEZ.Location = New System.Drawing.Point(170, 129)
        Me.cboPROVEEDOR_UNICA_VEZ.Name = "cboPROVEEDOR_UNICA_VEZ"
        Me.cboPROVEEDOR_UNICA_VEZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPROVEEDOR_UNICA_VEZ.Size = New System.Drawing.Size(275, 22)
        Me.cboPROVEEDOR_UNICA_VEZ.TabIndex = 6
        '
        'cboTOMA_DESCUENTOS
        '
        Me.cboTOMA_DESCUENTOS.BackColor = System.Drawing.SystemColors.Window
        Me.cboTOMA_DESCUENTOS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTOMA_DESCUENTOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTOMA_DESCUENTOS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTOMA_DESCUENTOS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTOMA_DESCUENTOS.Location = New System.Drawing.Point(170, 107)
        Me.cboTOMA_DESCUENTOS.Name = "cboTOMA_DESCUENTOS"
        Me.cboTOMA_DESCUENTOS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTOMA_DESCUENTOS.Size = New System.Drawing.Size(275, 22)
        Me.cboTOMA_DESCUENTOS.TabIndex = 5
        '
        'cboORIGEN_PROVEEDOR
        '
        Me.cboORIGEN_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.cboORIGEN_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboORIGEN_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboORIGEN_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboORIGEN_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboORIGEN_PROVEEDOR.Location = New System.Drawing.Point(170, 85)
        Me.cboORIGEN_PROVEEDOR.Name = "cboORIGEN_PROVEEDOR"
        Me.cboORIGEN_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboORIGEN_PROVEEDOR.Size = New System.Drawing.Size(275, 22)
        Me.cboORIGEN_PROVEEDOR.TabIndex = 4
        '
        'cboTIPO_PROVEEDOR
        '
        Me.cboTIPO_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.cboTIPO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTIPO_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTIPO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTIPO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTIPO_PROVEEDOR.Location = New System.Drawing.Point(170, 63)
        Me.cboTIPO_PROVEEDOR.Name = "cboTIPO_PROVEEDOR"
        Me.cboTIPO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTIPO_PROVEEDOR.Size = New System.Drawing.Size(275, 22)
        Me.cboTIPO_PROVEEDOR.TabIndex = 3
        '
        'cboPAGA_IVA_PROVEEDOR
        '
        Me.cboPAGA_IVA_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.cboPAGA_IVA_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPAGA_IVA_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPAGA_IVA_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPAGA_IVA_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPAGA_IVA_PROVEEDOR.Location = New System.Drawing.Point(170, 41)
        Me.cboPAGA_IVA_PROVEEDOR.Name = "cboPAGA_IVA_PROVEEDOR"
        Me.cboPAGA_IVA_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPAGA_IVA_PROVEEDOR.Size = New System.Drawing.Size(275, 22)
        Me.cboPAGA_IVA_PROVEEDOR.TabIndex = 2
        '
        'txtCUENTA_PROVEEDOR
        '
        Me.txtCUENTA_PROVEEDOR.AcceptsReturn = True
        Me.txtCUENTA_PROVEEDOR.BackColor = System.Drawing.Color.White
        Me.txtCUENTA_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUENTA_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCUENTA_PROVEEDOR.EsRequerido = False
        Me.txtCUENTA_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUENTA_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCUENTA_PROVEEDOR.LabelConsulta = Nothing
        Me.txtCUENTA_PROVEEDOR.Location = New System.Drawing.Point(170, 201)
        Me.txtCUENTA_PROVEEDOR.MaxLength = 60
        Me.txtCUENTA_PROVEEDOR.Name = "txtCUENTA_PROVEEDOR"
        Me.txtCUENTA_PROVEEDOR.NombreDeConsulta = Nothing
        Me.txtCUENTA_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_PROVEEDOR.Size = New System.Drawing.Size(425, 20)
        Me.txtCUENTA_PROVEEDOR.TabIndex = 9
        Me.txtCUENTA_PROVEEDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblREFERENCIA_PROVEEDOR
        '
        Me.lblREFERENCIA_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblREFERENCIA_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblREFERENCIA_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREFERENCIA_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblREFERENCIA_PROVEEDOR.Location = New System.Drawing.Point(6, 229)
        Me.lblREFERENCIA_PROVEEDOR.Name = "lblREFERENCIA_PROVEEDOR"
        Me.lblREFERENCIA_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblREFERENCIA_PROVEEDOR.Size = New System.Drawing.Size(158, 14)
        Me.lblREFERENCIA_PROVEEDOR.TabIndex = 61
        Me.lblREFERENCIA_PROVEEDOR.Text = "[Código referencia]"
        '
        'lblDESCRIP_CODIGO_ISR
        '
        Me.lblDESCRIP_CODIGO_ISR.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIP_CODIGO_ISR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIP_CODIGO_ISR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIP_CODIGO_ISR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIP_CODIGO_ISR.Location = New System.Drawing.Point(254, 283)
        Me.lblDESCRIP_CODIGO_ISR.Name = "lblDESCRIP_CODIGO_ISR"
        Me.lblDESCRIP_CODIGO_ISR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIP_CODIGO_ISR.Size = New System.Drawing.Size(356, 21)
        Me.lblDESCRIP_CODIGO_ISR.TabIndex = 60
        Me.lblDESCRIP_CODIGO_ISR.Text = "Descripción impuesto retención"
        Me.lblDESCRIP_CODIGO_ISR.UseMnemonic = False
        '
        'lblTitCODIGO_ISR
        '
        Me.lblTitCODIGO_ISR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_ISR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_ISR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_ISR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_ISR.Location = New System.Drawing.Point(6, 283)
        Me.lblTitCODIGO_ISR.Name = "lblTitCODIGO_ISR"
        Me.lblTitCODIGO_ISR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_ISR.Size = New System.Drawing.Size(158, 14)
        Me.lblTitCODIGO_ISR.TabIndex = 59
        Me.lblTitCODIGO_ISR.Text = "[Impuesto retención]"
        '
        'lblTitPARTICIPA_RETENCION
        '
        Me.lblTitPARTICIPA_RETENCION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitPARTICIPA_RETENCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitPARTICIPA_RETENCION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPARTICIPA_RETENCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitPARTICIPA_RETENCION.Location = New System.Drawing.Point(6, 256)
        Me.lblTitPARTICIPA_RETENCION.Name = "lblTitPARTICIPA_RETENCION"
        Me.lblTitPARTICIPA_RETENCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitPARTICIPA_RETENCION.Size = New System.Drawing.Size(158, 14)
        Me.lblTitPARTICIPA_RETENCION.TabIndex = 58
        Me.lblTitPARTICIPA_RETENCION.Text = "Participa en retención"
        '
        'lblTitLINEA_DE_CREDITO
        '
        Me.lblTitLINEA_DE_CREDITO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitLINEA_DE_CREDITO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitLINEA_DE_CREDITO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitLINEA_DE_CREDITO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitLINEA_DE_CREDITO.Location = New System.Drawing.Point(6, 361)
        Me.lblTitLINEA_DE_CREDITO.Name = "lblTitLINEA_DE_CREDITO"
        Me.lblTitLINEA_DE_CREDITO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitLINEA_DE_CREDITO.Size = New System.Drawing.Size(158, 14)
        Me.lblTitLINEA_DE_CREDITO.TabIndex = 57
        Me.lblTitLINEA_DE_CREDITO.Text = "[Línea de crédito]"
        '
        'lblTitGIRO_DE_NEGOCIO
        '
        Me.lblTitGIRO_DE_NEGOCIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitGIRO_DE_NEGOCIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitGIRO_DE_NEGOCIO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitGIRO_DE_NEGOCIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitGIRO_DE_NEGOCIO.Location = New System.Drawing.Point(6, 335)
        Me.lblTitGIRO_DE_NEGOCIO.Name = "lblTitGIRO_DE_NEGOCIO"
        Me.lblTitGIRO_DE_NEGOCIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitGIRO_DE_NEGOCIO.Size = New System.Drawing.Size(158, 14)
        Me.lblTitGIRO_DE_NEGOCIO.TabIndex = 56
        Me.lblTitGIRO_DE_NEGOCIO.Text = "[Giro de negocio]"
        '
        'lblTitNUMERO_REGISTRO
        '
        Me.lblTitNUMERO_REGISTRO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_REGISTRO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_REGISTRO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_REGISTRO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_REGISTRO.Location = New System.Drawing.Point(6, 309)
        Me.lblTitNUMERO_REGISTRO.Name = "lblTitNUMERO_REGISTRO"
        Me.lblTitNUMERO_REGISTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_REGISTRO.Size = New System.Drawing.Size(158, 14)
        Me.lblTitNUMERO_REGISTRO.TabIndex = 55
        Me.lblTitNUMERO_REGISTRO.Text = "[Número de registro]"
        '
        'lblTitcongelado
        '
        Me.lblTitcongelado.BackColor = System.Drawing.Color.Transparent
        Me.lblTitcongelado.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitcongelado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitcongelado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitcongelado.Location = New System.Drawing.Point(6, 176)
        Me.lblTitcongelado.Name = "lblTitcongelado"
        Me.lblTitcongelado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitcongelado.Size = New System.Drawing.Size(158, 14)
        Me.lblTitcongelado.TabIndex = 54
        Me.lblTitcongelado.Text = "Congelado"
        '
        'lblTitORIGEN_PROVEEDOR
        '
        Me.lblTitORIGEN_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitORIGEN_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN_PROVEEDOR.Location = New System.Drawing.Point(6, 88)
        Me.lblTitORIGEN_PROVEEDOR.Name = "lblTitORIGEN_PROVEEDOR"
        Me.lblTitORIGEN_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN_PROVEEDOR.Size = New System.Drawing.Size(158, 14)
        Me.lblTitORIGEN_PROVEEDOR.TabIndex = 53
        Me.lblTitORIGEN_PROVEEDOR.Text = "Origen proveedor"
        '
        'lblTitTOMA_DESCUENTOS
        '
        Me.lblTitTOMA_DESCUENTOS.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTOMA_DESCUENTOS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTOMA_DESCUENTOS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTOMA_DESCUENTOS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTOMA_DESCUENTOS.Location = New System.Drawing.Point(6, 110)
        Me.lblTitTOMA_DESCUENTOS.Name = "lblTitTOMA_DESCUENTOS"
        Me.lblTitTOMA_DESCUENTOS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTOMA_DESCUENTOS.Size = New System.Drawing.Size(158, 14)
        Me.lblTitTOMA_DESCUENTOS.TabIndex = 52
        Me.lblTitTOMA_DESCUENTOS.Text = "Toma descuentos"
        '
        'lblTitESTATUS_PROVEEDOR
        '
        Me.lblTitESTATUS_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTATUS_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTATUS_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTATUS_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTATUS_PROVEEDOR.Location = New System.Drawing.Point(6, 154)
        Me.lblTitESTATUS_PROVEEDOR.Name = "lblTitESTATUS_PROVEEDOR"
        Me.lblTitESTATUS_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTATUS_PROVEEDOR.Size = New System.Drawing.Size(158, 14)
        Me.lblTitESTATUS_PROVEEDOR.TabIndex = 51
        Me.lblTitESTATUS_PROVEEDOR.Text = "Estado proveedor"
        '
        'lblTitporcentaje_descuento
        '
        Me.lblTitporcentaje_descuento.BackColor = System.Drawing.Color.Transparent
        Me.lblTitporcentaje_descuento.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitporcentaje_descuento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitporcentaje_descuento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitporcentaje_descuento.Location = New System.Drawing.Point(6, 17)
        Me.lblTitporcentaje_descuento.Name = "lblTitporcentaje_descuento"
        Me.lblTitporcentaje_descuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitporcentaje_descuento.Size = New System.Drawing.Size(158, 14)
        Me.lblTitporcentaje_descuento.TabIndex = 50
        Me.lblTitporcentaje_descuento.Text = "% Descuento"
        '
        'lblTitpaga_iva_proveedor
        '
        Me.lblTitpaga_iva_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblTitpaga_iva_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitpaga_iva_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitpaga_iva_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitpaga_iva_proveedor.Location = New System.Drawing.Point(6, 44)
        Me.lblTitpaga_iva_proveedor.Name = "lblTitpaga_iva_proveedor"
        Me.lblTitpaga_iva_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitpaga_iva_proveedor.Size = New System.Drawing.Size(158, 14)
        Me.lblTitpaga_iva_proveedor.TabIndex = 49
        Me.lblTitpaga_iva_proveedor.Text = "Paga IVA"
        '
        'lblTitPROVEEDOR_UNICA_VEZ
        '
        Me.lblTitPROVEEDOR_UNICA_VEZ.BackColor = System.Drawing.Color.Transparent
        Me.lblTitPROVEEDOR_UNICA_VEZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitPROVEEDOR_UNICA_VEZ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPROVEEDOR_UNICA_VEZ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitPROVEEDOR_UNICA_VEZ.Location = New System.Drawing.Point(6, 132)
        Me.lblTitPROVEEDOR_UNICA_VEZ.Name = "lblTitPROVEEDOR_UNICA_VEZ"
        Me.lblTitPROVEEDOR_UNICA_VEZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitPROVEEDOR_UNICA_VEZ.Size = New System.Drawing.Size(158, 14)
        Me.lblTitPROVEEDOR_UNICA_VEZ.TabIndex = 48
        Me.lblTitPROVEEDOR_UNICA_VEZ.Text = "Periodicidad proveedor"
        '
        'txtREFERENCIA_PROVEEDOR
        '
        Me.txtREFERENCIA_PROVEEDOR.AcceptsReturn = True
        Me.txtREFERENCIA_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtREFERENCIA_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtREFERENCIA_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtREFERENCIA_PROVEEDOR.EsRequerido = False
        Me.txtREFERENCIA_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtREFERENCIA_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtREFERENCIA_PROVEEDOR.LabelConsulta = Nothing
        Me.txtREFERENCIA_PROVEEDOR.Location = New System.Drawing.Point(170, 227)
        Me.txtREFERENCIA_PROVEEDOR.MaxLength = 11
        Me.txtREFERENCIA_PROVEEDOR.Name = "txtREFERENCIA_PROVEEDOR"
        Me.txtREFERENCIA_PROVEEDOR.NombreDeConsulta = Nothing
        Me.txtREFERENCIA_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtREFERENCIA_PROVEEDOR.Size = New System.Drawing.Size(138, 20)
        Me.txtREFERENCIA_PROVEEDOR.TabIndex = 10
        Me.txtREFERENCIA_PROVEEDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_ISR
        '
        Me.txtCODIGO_ISR.AcceptsReturn = True
        Me.txtCODIGO_ISR.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_ISR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_ISR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_ISR.EsRequerido = False
        Me.txtCODIGO_ISR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_ISR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_ISR.LabelConsulta = Nothing
        Me.txtCODIGO_ISR.Location = New System.Drawing.Point(170, 281)
        Me.txtCODIGO_ISR.MaxLength = 3
        Me.txtCODIGO_ISR.Name = "txtCODIGO_ISR"
        Me.txtCODIGO_ISR.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeImpuestos_IMPUEC01
        Me.txtCODIGO_ISR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_ISR.Size = New System.Drawing.Size(61, 20)
        Me.txtCODIGO_ISR.TabIndex = 12
        Me.txtCODIGO_ISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNUMERO_REGISTRO
        '
        Me.txtNUMERO_REGISTRO.AcceptsReturn = True
        Me.txtNUMERO_REGISTRO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUMERO_REGISTRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_REGISTRO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_REGISTRO.EsRequerido = False
        Me.txtNUMERO_REGISTRO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_REGISTRO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_REGISTRO.LabelConsulta = Nothing
        Me.txtNUMERO_REGISTRO.Location = New System.Drawing.Point(170, 307)
        Me.txtNUMERO_REGISTRO.MaxLength = 20
        Me.txtNUMERO_REGISTRO.Name = "txtNUMERO_REGISTRO"
        Me.txtNUMERO_REGISTRO.NombreDeConsulta = Nothing
        Me.txtNUMERO_REGISTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_REGISTRO.Size = New System.Drawing.Size(138, 20)
        Me.txtNUMERO_REGISTRO.TabIndex = 13
        Me.txtNUMERO_REGISTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGIRO_DE_NEGOCIO
        '
        Me.txtGIRO_DE_NEGOCIO.AcceptsReturn = True
        Me.txtGIRO_DE_NEGOCIO.BackColor = System.Drawing.SystemColors.Window
        Me.txtGIRO_DE_NEGOCIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGIRO_DE_NEGOCIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGIRO_DE_NEGOCIO.EsRequerido = False
        Me.txtGIRO_DE_NEGOCIO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGIRO_DE_NEGOCIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGIRO_DE_NEGOCIO.LabelConsulta = Nothing
        Me.txtGIRO_DE_NEGOCIO.Location = New System.Drawing.Point(170, 333)
        Me.txtGIRO_DE_NEGOCIO.MaxLength = 30
        Me.txtGIRO_DE_NEGOCIO.Name = "txtGIRO_DE_NEGOCIO"
        Me.txtGIRO_DE_NEGOCIO.NombreDeConsulta = Nothing
        Me.txtGIRO_DE_NEGOCIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGIRO_DE_NEGOCIO.Size = New System.Drawing.Size(278, 20)
        Me.txtGIRO_DE_NEGOCIO.TabIndex = 14
        Me.txtGIRO_DE_NEGOCIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLINEA_DE_CREDITO
        '
        Me.txtLINEA_DE_CREDITO.AcceptsReturn = True
        Me.txtLINEA_DE_CREDITO.BackColor = System.Drawing.SystemColors.Window
        Me.txtLINEA_DE_CREDITO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLINEA_DE_CREDITO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLINEA_DE_CREDITO.EsRequerido = False
        Me.txtLINEA_DE_CREDITO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLINEA_DE_CREDITO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLINEA_DE_CREDITO.LabelConsulta = Nothing
        Me.txtLINEA_DE_CREDITO.Location = New System.Drawing.Point(170, 359)
        Me.txtLINEA_DE_CREDITO.MaxLength = 14
        Me.txtLINEA_DE_CREDITO.Name = "txtLINEA_DE_CREDITO"
        Me.txtLINEA_DE_CREDITO.NombreDeConsulta = Nothing
        Me.txtLINEA_DE_CREDITO.NumeroDecimales = 2
        Me.txtLINEA_DE_CREDITO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLINEA_DE_CREDITO.Size = New System.Drawing.Size(138, 20)
        Me.txtLINEA_DE_CREDITO.TabIndex = 15
        Me.txtLINEA_DE_CREDITO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtporcentaje_descuento
        '
        Me.txtporcentaje_descuento.AcceptsReturn = True
        Me.txtporcentaje_descuento.BackColor = System.Drawing.Color.White
        Me.txtporcentaje_descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtporcentaje_descuento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtporcentaje_descuento.EsRequerido = True
        Me.txtporcentaje_descuento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtporcentaje_descuento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtporcentaje_descuento.LabelConsulta = Nothing
        Me.txtporcentaje_descuento.Location = New System.Drawing.Point(170, 15)
        Me.txtporcentaje_descuento.MaxLength = 8
        Me.txtporcentaje_descuento.Multiline = True
        Me.txtporcentaje_descuento.Name = "txtporcentaje_descuento"
        Me.txtporcentaje_descuento.NombreDeConsulta = Nothing
        Me.txtporcentaje_descuento.NumeroDecimales = 5
        Me.txtporcentaje_descuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtporcentaje_descuento.Size = New System.Drawing.Size(138, 20)
        Me.txtporcentaje_descuento.TabIndex = 1
        Me.txtporcentaje_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitTIPO_PROVEEDOR
        '
        Me.lblTitTIPO_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_PROVEEDOR.Location = New System.Drawing.Point(6, 66)
        Me.lblTitTIPO_PROVEEDOR.Name = "lblTitTIPO_PROVEEDOR"
        Me.lblTitTIPO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_PROVEEDOR.Size = New System.Drawing.Size(158, 14)
        Me.lblTitTIPO_PROVEEDOR.TabIndex = 47
        Me.lblTitTIPO_PROVEEDOR.Text = "Tipo proveedor"
        '
        'lblTitCUENTA_PROVEEDOR
        '
        Me.lblTitCUENTA_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_PROVEEDOR.Location = New System.Drawing.Point(6, 203)
        Me.lblTitCUENTA_PROVEEDOR.Name = "lblTitCUENTA_PROVEEDOR"
        Me.lblTitCUENTA_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_PROVEEDOR.Size = New System.Drawing.Size(158, 14)
        Me.lblTitCUENTA_PROVEEDOR.TabIndex = 46
        Me.lblTitCUENTA_PROVEEDOR.Text = "[Cuenta del proveedor]"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.txtCODIGO_CLASE_PROVEED)
        Me.TabPage3.Controls.Add(Me.txtCODIGO_BANCO)
        Me.TabPage3.Controls.Add(Me.txtCODIGO_CUENTA)
        Me.TabPage3.Controls.Add(Me.txtCODIGO_DE_MONEDA)
        Me.TabPage3.Controls.Add(Me.txtCODIGO_DE_CONDICION)
        Me.TabPage3.Controls.Add(Me.txtCODIGO_TIPO_PAGO)
        Me.TabPage3.Controls.Add(Me.txtCODIGO_DE_PAIS)
        Me.TabPage3.Controls.Add(Me.txtCODIGO_IMPUESTO)
        Me.TabPage3.Controls.Add(Me.cboACEPTA_ENVIO_PARCIAL)
        Me.TabPage3.Controls.Add(Me.txtFORMATO_ORDEN_COMPRA)
        Me.TabPage3.Controls.Add(Me.txtDIRECCION_EMAIL)
        Me.TabPage3.Controls.Add(Me.txtNOMBRE_BENEFICIARIO)
        Me.TabPage3.Controls.Add(Me.lblDESCRIPCION_CLASE)
        Me.TabPage3.Controls.Add(Me.lblDESCRIPCION_IMPUESTO)
        Me.TabPage3.Controls.Add(Me.lblNOMBRE_DEL_PAIS)
        Me.TabPage3.Controls.Add(Me.lblNOMBRE_CUENTA)
        Me.TabPage3.Controls.Add(Me.lblDESC_TIPO_PAGO)
        Me.TabPage3.Controls.Add(Me.lblDESCRIPCI_CONDICION)
        Me.TabPage3.Controls.Add(Me.lblDESCRIPCION_MONEDA)
        Me.TabPage3.Controls.Add(Me.lblNOMBRE_BANCO)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_DE_PAIS)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_IMPUESTO)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_DE_CONDICION)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_CUENTA)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_CLASE_PROVEED)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_TIPO_PAGO)
        Me.TabPage3.Controls.Add(Me.lblTitCODIGO_BANCO)
        Me.TabPage3.Controls.Add(Me.lblTitFORMATO_ORDEN_COMPRA)
        Me.TabPage3.Controls.Add(Me.lblTitDIRECCION_EMAIL)
        Me.TabPage3.Controls.Add(Me.lblTitACEPTA_ENVIO_PARCIAL)
        Me.TabPage3.Controls.Add(Me.lblTitNOMBRE_BENEFICIARIO)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(616, 384)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Referencias ( F3 )"
        '
        'txtCODIGO_CLASE_PROVEED
        '
        Me.txtCODIGO_CLASE_PROVEED.AcceptsReturn = True
        Me.txtCODIGO_CLASE_PROVEED.BackColor = System.Drawing.Color.White
        Me.txtCODIGO_CLASE_PROVEED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_CLASE_PROVEED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_CLASE_PROVEED.EsRequerido = True
        Me.txtCODIGO_CLASE_PROVEED.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_CLASE_PROVEED.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_CLASE_PROVEED.LabelConsulta = Nothing
        Me.txtCODIGO_CLASE_PROVEED.Location = New System.Drawing.Point(190, 15)
        Me.txtCODIGO_CLASE_PROVEED.MaxLength = 3
        Me.txtCODIGO_CLASE_PROVEED.Name = "txtCODIGO_CLASE_PROVEED"
        Me.txtCODIGO_CLASE_PROVEED.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeClasesDeProveedor_CLPROC01
        Me.txtCODIGO_CLASE_PROVEED.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CLASE_PROVEED.Size = New System.Drawing.Size(40, 20)
        Me.txtCODIGO_CLASE_PROVEED.TabIndex = 1
        Me.txtCODIGO_CLASE_PROVEED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_BANCO
        '
        Me.txtCODIGO_BANCO.AcceptsReturn = True
        Me.txtCODIGO_BANCO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_BANCO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_BANCO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_BANCO.EsRequerido = False
        Me.txtCODIGO_BANCO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_BANCO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_BANCO.LabelConsulta = Nothing
        Me.txtCODIGO_BANCO.Location = New System.Drawing.Point(190, 41)
        Me.txtCODIGO_BANCO.MaxLength = 3
        Me.txtCODIGO_BANCO.Multiline = True
        Me.txtCODIGO_BANCO.Name = "txtCODIGO_BANCO"
        Me.txtCODIGO_BANCO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeBancos_BANCOC01
        Me.txtCODIGO_BANCO.NumeroDecimales = 0
        Me.txtCODIGO_BANCO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_BANCO.Size = New System.Drawing.Size(40, 21)
        Me.txtCODIGO_BANCO.TabIndex = 2
        Me.txtCODIGO_BANCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_CUENTA
        '
        Me.txtCODIGO_CUENTA.AcceptsReturn = True
        Me.txtCODIGO_CUENTA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_CUENTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_CUENTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_CUENTA.EsRequerido = False
        Me.txtCODIGO_CUENTA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_CUENTA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_CUENTA.LabelConsulta = Nothing
        Me.txtCODIGO_CUENTA.Location = New System.Drawing.Point(190, 68)
        Me.txtCODIGO_CUENTA.MaxLength = 3
        Me.txtCODIGO_CUENTA.Multiline = True
        Me.txtCODIGO_CUENTA.Name = "txtCODIGO_CUENTA"
        Me.txtCODIGO_CUENTA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCuentasPorBanco_CUENTC01
        Me.txtCODIGO_CUENTA.NumeroDecimales = 0
        Me.txtCODIGO_CUENTA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CUENTA.Size = New System.Drawing.Size(40, 21)
        Me.txtCODIGO_CUENTA.TabIndex = 3
        Me.txtCODIGO_CUENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_DE_MONEDA
        '
        Me.txtCODIGO_DE_MONEDA.AcceptsReturn = True
        Me.txtCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_MONEDA.EsRequerido = True
        Me.txtCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_MONEDA.LabelConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.Location = New System.Drawing.Point(190, 95)
        Me.txtCODIGO_DE_MONEDA.MaxLength = 5
        Me.txtCODIGO_DE_MONEDA.Name = "txtCODIGO_DE_MONEDA"
        Me.txtCODIGO_DE_MONEDA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMonedas_MONEDC01
        Me.txtCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_MONEDA.Size = New System.Drawing.Size(40, 20)
        Me.txtCODIGO_DE_MONEDA.TabIndex = 4
        Me.txtCODIGO_DE_MONEDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_DE_CONDICION
        '
        Me.txtCODIGO_DE_CONDICION.AcceptsReturn = True
        Me.txtCODIGO_DE_CONDICION.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_CONDICION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_CONDICION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_CONDICION.EsRequerido = True
        Me.txtCODIGO_DE_CONDICION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_CONDICION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_CONDICION.LabelConsulta = Nothing
        Me.txtCODIGO_DE_CONDICION.Location = New System.Drawing.Point(190, 121)
        Me.txtCODIGO_DE_CONDICION.MaxLength = 3
        Me.txtCODIGO_DE_CONDICION.Multiline = True
        Me.txtCODIGO_DE_CONDICION.Name = "txtCODIGO_DE_CONDICION"
        Me.txtCODIGO_DE_CONDICION.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCondicionesDePago_CONDIC01
        Me.txtCODIGO_DE_CONDICION.NumeroDecimales = 0
        Me.txtCODIGO_DE_CONDICION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_CONDICION.Size = New System.Drawing.Size(40, 21)
        Me.txtCODIGO_DE_CONDICION.TabIndex = 5
        Me.txtCODIGO_DE_CONDICION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_TIPO_PAGO
        '
        Me.txtCODIGO_TIPO_PAGO.AcceptsReturn = True
        Me.txtCODIGO_TIPO_PAGO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_TIPO_PAGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_TIPO_PAGO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_TIPO_PAGO.EsRequerido = True
        Me.txtCODIGO_TIPO_PAGO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_TIPO_PAGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_TIPO_PAGO.LabelConsulta = Nothing
        Me.txtCODIGO_TIPO_PAGO.Location = New System.Drawing.Point(190, 148)
        Me.txtCODIGO_TIPO_PAGO.MaxLength = 2
        Me.txtCODIGO_TIPO_PAGO.Name = "txtCODIGO_TIPO_PAGO"
        Me.txtCODIGO_TIPO_PAGO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDePago_TIPPAC01
        Me.txtCODIGO_TIPO_PAGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_TIPO_PAGO.Size = New System.Drawing.Size(40, 20)
        Me.txtCODIGO_TIPO_PAGO.TabIndex = 6
        Me.txtCODIGO_TIPO_PAGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_DE_PAIS
        '
        Me.txtCODIGO_DE_PAIS.AcceptsReturn = True
        Me.txtCODIGO_DE_PAIS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_PAIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_PAIS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_PAIS.EsRequerido = True
        Me.txtCODIGO_DE_PAIS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_PAIS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_PAIS.LabelConsulta = Nothing
        Me.txtCODIGO_DE_PAIS.Location = New System.Drawing.Point(190, 174)
        Me.txtCODIGO_DE_PAIS.MaxLength = 2
        Me.txtCODIGO_DE_PAIS.Multiline = True
        Me.txtCODIGO_DE_PAIS.Name = "txtCODIGO_DE_PAIS"
        Me.txtCODIGO_DE_PAIS.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDePaises_PAISEC01
        Me.txtCODIGO_DE_PAIS.NumeroDecimales = 0
        Me.txtCODIGO_DE_PAIS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_PAIS.Size = New System.Drawing.Size(40, 21)
        Me.txtCODIGO_DE_PAIS.TabIndex = 7
        Me.txtCODIGO_DE_PAIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_IMPUESTO
        '
        Me.txtCODIGO_IMPUESTO.AcceptsReturn = True
        Me.txtCODIGO_IMPUESTO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_IMPUESTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_IMPUESTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_IMPUESTO.EsRequerido = True
        Me.txtCODIGO_IMPUESTO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_IMPUESTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_IMPUESTO.LabelConsulta = Nothing
        Me.txtCODIGO_IMPUESTO.Location = New System.Drawing.Point(190, 201)
        Me.txtCODIGO_IMPUESTO.MaxLength = 3
        Me.txtCODIGO_IMPUESTO.Name = "txtCODIGO_IMPUESTO"
        Me.txtCODIGO_IMPUESTO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeImpuestos_IMPUEC01
        Me.txtCODIGO_IMPUESTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_IMPUESTO.Size = New System.Drawing.Size(40, 20)
        Me.txtCODIGO_IMPUESTO.TabIndex = 8
        Me.txtCODIGO_IMPUESTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboACEPTA_ENVIO_PARCIAL
        '
        Me.cboACEPTA_ENVIO_PARCIAL.BackColor = System.Drawing.SystemColors.Window
        Me.cboACEPTA_ENVIO_PARCIAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboACEPTA_ENVIO_PARCIAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboACEPTA_ENVIO_PARCIAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboACEPTA_ENVIO_PARCIAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboACEPTA_ENVIO_PARCIAL.Location = New System.Drawing.Point(190, 253)
        Me.cboACEPTA_ENVIO_PARCIAL.Name = "cboACEPTA_ENVIO_PARCIAL"
        Me.cboACEPTA_ENVIO_PARCIAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboACEPTA_ENVIO_PARCIAL.Size = New System.Drawing.Size(275, 22)
        Me.cboACEPTA_ENVIO_PARCIAL.TabIndex = 10
        '
        'txtFORMATO_ORDEN_COMPRA
        '
        Me.txtFORMATO_ORDEN_COMPRA.AcceptsReturn = True
        Me.txtFORMATO_ORDEN_COMPRA.BackColor = System.Drawing.SystemColors.Window
        Me.txtFORMATO_ORDEN_COMPRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFORMATO_ORDEN_COMPRA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFORMATO_ORDEN_COMPRA.EsRequerido = False
        Me.txtFORMATO_ORDEN_COMPRA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFORMATO_ORDEN_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFORMATO_ORDEN_COMPRA.LabelConsulta = Nothing
        Me.txtFORMATO_ORDEN_COMPRA.Location = New System.Drawing.Point(190, 227)
        Me.txtFORMATO_ORDEN_COMPRA.MaxLength = 10
        Me.txtFORMATO_ORDEN_COMPRA.Name = "txtFORMATO_ORDEN_COMPRA"
        Me.txtFORMATO_ORDEN_COMPRA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeFormatosDeOrdenDeCompra_GYSFORL6
        Me.txtFORMATO_ORDEN_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFORMATO_ORDEN_COMPRA.Size = New System.Drawing.Size(86, 20)
        Me.txtFORMATO_ORDEN_COMPRA.TabIndex = 9
        '
        'txtDIRECCION_EMAIL
        '
        Me.txtDIRECCION_EMAIL.AcceptsReturn = True
        Me.txtDIRECCION_EMAIL.BackColor = System.Drawing.SystemColors.Window
        Me.txtDIRECCION_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDIRECCION_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDIRECCION_EMAIL.EsRequerido = False
        Me.txtDIRECCION_EMAIL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIRECCION_EMAIL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDIRECCION_EMAIL.LabelConsulta = Nothing
        Me.txtDIRECCION_EMAIL.Location = New System.Drawing.Point(190, 281)
        Me.txtDIRECCION_EMAIL.MaxLength = 30
        Me.txtDIRECCION_EMAIL.Name = "txtDIRECCION_EMAIL"
        Me.txtDIRECCION_EMAIL.NombreDeConsulta = Nothing
        Me.txtDIRECCION_EMAIL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIRECCION_EMAIL.Size = New System.Drawing.Size(217, 20)
        Me.txtDIRECCION_EMAIL.TabIndex = 11
        '
        'txtNOMBRE_BENEFICIARIO
        '
        Me.txtNOMBRE_BENEFICIARIO.AcceptsReturn = True
        Me.txtNOMBRE_BENEFICIARIO.BackColor = System.Drawing.Color.White
        Me.txtNOMBRE_BENEFICIARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE_BENEFICIARIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNOMBRE_BENEFICIARIO.EsRequerido = False
        Me.txtNOMBRE_BENEFICIARIO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE_BENEFICIARIO.ForeColor = System.Drawing.Color.Red
        Me.txtNOMBRE_BENEFICIARIO.LabelConsulta = Nothing
        Me.txtNOMBRE_BENEFICIARIO.Location = New System.Drawing.Point(190, 307)
        Me.txtNOMBRE_BENEFICIARIO.MaxLength = 0
        Me.txtNOMBRE_BENEFICIARIO.Name = "txtNOMBRE_BENEFICIARIO"
        Me.txtNOMBRE_BENEFICIARIO.NombreDeConsulta = Nothing
        Me.txtNOMBRE_BENEFICIARIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNOMBRE_BENEFICIARIO.Size = New System.Drawing.Size(388, 20)
        Me.txtNOMBRE_BENEFICIARIO.TabIndex = 12
        Me.txtNOMBRE_BENEFICIARIO.Text = "No se utiliza porque en los PTFS no se incluye la columna"
        Me.txtNOMBRE_BENEFICIARIO.Visible = False
        '
        'lblDESCRIPCION_CLASE
        '
        Me.lblDESCRIPCION_CLASE.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_CLASE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_CLASE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_CLASE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_CLASE.Location = New System.Drawing.Point(251, 17)
        Me.lblDESCRIPCION_CLASE.Name = "lblDESCRIPCION_CLASE"
        Me.lblDESCRIPCION_CLASE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_CLASE.Size = New System.Drawing.Size(359, 20)
        Me.lblDESCRIPCION_CLASE.TabIndex = 63
        Me.lblDESCRIPCION_CLASE.Text = "Descripción clase proveedor"
        Me.lblDESCRIPCION_CLASE.UseMnemonic = False
        '
        'lblDESCRIPCION_IMPUESTO
        '
        Me.lblDESCRIPCION_IMPUESTO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_IMPUESTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_IMPUESTO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_IMPUESTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_IMPUESTO.Location = New System.Drawing.Point(251, 203)
        Me.lblDESCRIPCION_IMPUESTO.Name = "lblDESCRIPCION_IMPUESTO"
        Me.lblDESCRIPCION_IMPUESTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_IMPUESTO.Size = New System.Drawing.Size(359, 20)
        Me.lblDESCRIPCION_IMPUESTO.TabIndex = 62
        Me.lblDESCRIPCION_IMPUESTO.Text = "Descripción impuesto"
        Me.lblDESCRIPCION_IMPUESTO.UseMnemonic = False
        '
        'lblNOMBRE_DEL_PAIS
        '
        Me.lblNOMBRE_DEL_PAIS.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_DEL_PAIS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_DEL_PAIS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_DEL_PAIS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_DEL_PAIS.Location = New System.Drawing.Point(251, 176)
        Me.lblNOMBRE_DEL_PAIS.Name = "lblNOMBRE_DEL_PAIS"
        Me.lblNOMBRE_DEL_PAIS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_DEL_PAIS.Size = New System.Drawing.Size(359, 20)
        Me.lblNOMBRE_DEL_PAIS.TabIndex = 61
        Me.lblNOMBRE_DEL_PAIS.Text = "Descripción pais"
        Me.lblNOMBRE_DEL_PAIS.UseMnemonic = False
        '
        'lblNOMBRE_CUENTA
        '
        Me.lblNOMBRE_CUENTA.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_CUENTA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_CUENTA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_CUENTA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_CUENTA.Location = New System.Drawing.Point(251, 70)
        Me.lblNOMBRE_CUENTA.Name = "lblNOMBRE_CUENTA"
        Me.lblNOMBRE_CUENTA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_CUENTA.Size = New System.Drawing.Size(359, 20)
        Me.lblNOMBRE_CUENTA.TabIndex = 60
        Me.lblNOMBRE_CUENTA.Text = "Descripción cuenta banco"
        Me.lblNOMBRE_CUENTA.UseMnemonic = False
        '
        'lblDESC_TIPO_PAGO
        '
        Me.lblDESC_TIPO_PAGO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESC_TIPO_PAGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESC_TIPO_PAGO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESC_TIPO_PAGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESC_TIPO_PAGO.Location = New System.Drawing.Point(251, 150)
        Me.lblDESC_TIPO_PAGO.Name = "lblDESC_TIPO_PAGO"
        Me.lblDESC_TIPO_PAGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESC_TIPO_PAGO.Size = New System.Drawing.Size(359, 20)
        Me.lblDESC_TIPO_PAGO.TabIndex = 59
        Me.lblDESC_TIPO_PAGO.Text = "Descripción tipo de pago"
        Me.lblDESC_TIPO_PAGO.UseMnemonic = False
        '
        'lblDESCRIPCI_CONDICION
        '
        Me.lblDESCRIPCI_CONDICION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCI_CONDICION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCI_CONDICION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCI_CONDICION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCI_CONDICION.Location = New System.Drawing.Point(251, 123)
        Me.lblDESCRIPCI_CONDICION.Name = "lblDESCRIPCI_CONDICION"
        Me.lblDESCRIPCI_CONDICION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCI_CONDICION.Size = New System.Drawing.Size(359, 20)
        Me.lblDESCRIPCI_CONDICION.TabIndex = 58
        Me.lblDESCRIPCI_CONDICION.Text = "Descripción condición"
        Me.lblDESCRIPCI_CONDICION.UseMnemonic = False
        '
        'lblDESCRIPCION_MONEDA
        '
        Me.lblDESCRIPCION_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_MONEDA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_MONEDA.Location = New System.Drawing.Point(251, 97)
        Me.lblDESCRIPCION_MONEDA.Name = "lblDESCRIPCION_MONEDA"
        Me.lblDESCRIPCION_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_MONEDA.Size = New System.Drawing.Size(359, 20)
        Me.lblDESCRIPCION_MONEDA.TabIndex = 57
        Me.lblDESCRIPCION_MONEDA.Text = "Descripción moneda"
        Me.lblDESCRIPCION_MONEDA.UseMnemonic = False
        '
        'lblNOMBRE_BANCO
        '
        Me.lblNOMBRE_BANCO.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_BANCO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_BANCO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_BANCO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_BANCO.Location = New System.Drawing.Point(251, 43)
        Me.lblNOMBRE_BANCO.Name = "lblNOMBRE_BANCO"
        Me.lblNOMBRE_BANCO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_BANCO.Size = New System.Drawing.Size(359, 20)
        Me.lblNOMBRE_BANCO.TabIndex = 56
        Me.lblNOMBRE_BANCO.Text = "Descripción banco"
        Me.lblNOMBRE_BANCO.UseMnemonic = False
        '
        'lblTitCODIGO_DE_PAIS
        '
        Me.lblTitCODIGO_DE_PAIS.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_PAIS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_PAIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_PAIS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_PAIS.Location = New System.Drawing.Point(6, 176)
        Me.lblTitCODIGO_DE_PAIS.Name = "lblTitCODIGO_DE_PAIS"
        Me.lblTitCODIGO_DE_PAIS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_PAIS.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_DE_PAIS.TabIndex = 55
        Me.lblTitCODIGO_DE_PAIS.Text = "Código de país"
        '
        'lblTitCODIGO_IMPUESTO
        '
        Me.lblTitCODIGO_IMPUESTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_IMPUESTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_IMPUESTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_IMPUESTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_IMPUESTO.Location = New System.Drawing.Point(6, 203)
        Me.lblTitCODIGO_IMPUESTO.Name = "lblTitCODIGO_IMPUESTO"
        Me.lblTitCODIGO_IMPUESTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_IMPUESTO.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_IMPUESTO.TabIndex = 54
        Me.lblTitCODIGO_IMPUESTO.Text = "Código impuesto"
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(6, 97)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 53
        Me.lblTitCODIGO_DE_MONEDA.Text = "Código moneda"
        '
        'lblTitCODIGO_DE_CONDICION
        '
        Me.lblTitCODIGO_DE_CONDICION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_CONDICION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_CONDICION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_CONDICION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_CONDICION.Location = New System.Drawing.Point(6, 123)
        Me.lblTitCODIGO_DE_CONDICION.Name = "lblTitCODIGO_DE_CONDICION"
        Me.lblTitCODIGO_DE_CONDICION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_CONDICION.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_DE_CONDICION.TabIndex = 52
        Me.lblTitCODIGO_DE_CONDICION.Text = "Código condición"
        '
        'lblTitCODIGO_CUENTA
        '
        Me.lblTitCODIGO_CUENTA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CUENTA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CUENTA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CUENTA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CUENTA.Location = New System.Drawing.Point(6, 70)
        Me.lblTitCODIGO_CUENTA.Name = "lblTitCODIGO_CUENTA"
        Me.lblTitCODIGO_CUENTA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CUENTA.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_CUENTA.TabIndex = 51
        Me.lblTitCODIGO_CUENTA.Text = "[Cuenta bancaria]"
        '
        'lblTitCODIGO_CLASE_PROVEED
        '
        Me.lblTitCODIGO_CLASE_PROVEED.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CLASE_PROVEED.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CLASE_PROVEED.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CLASE_PROVEED.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CLASE_PROVEED.Location = New System.Drawing.Point(6, 17)
        Me.lblTitCODIGO_CLASE_PROVEED.Name = "lblTitCODIGO_CLASE_PROVEED"
        Me.lblTitCODIGO_CLASE_PROVEED.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CLASE_PROVEED.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_CLASE_PROVEED.TabIndex = 50
        Me.lblTitCODIGO_CLASE_PROVEED.Text = "Clase de proveedor"
        '
        'lblTitCODIGO_TIPO_PAGO
        '
        Me.lblTitCODIGO_TIPO_PAGO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_TIPO_PAGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_TIPO_PAGO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_TIPO_PAGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_TIPO_PAGO.Location = New System.Drawing.Point(6, 150)
        Me.lblTitCODIGO_TIPO_PAGO.Name = "lblTitCODIGO_TIPO_PAGO"
        Me.lblTitCODIGO_TIPO_PAGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_TIPO_PAGO.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_TIPO_PAGO.TabIndex = 49
        Me.lblTitCODIGO_TIPO_PAGO.Text = "Código tipo pago"
        '
        'lblTitCODIGO_BANCO
        '
        Me.lblTitCODIGO_BANCO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_BANCO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_BANCO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_BANCO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_BANCO.Location = New System.Drawing.Point(6, 43)
        Me.lblTitCODIGO_BANCO.Name = "lblTitCODIGO_BANCO"
        Me.lblTitCODIGO_BANCO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_BANCO.Size = New System.Drawing.Size(178, 14)
        Me.lblTitCODIGO_BANCO.TabIndex = 48
        Me.lblTitCODIGO_BANCO.Text = "[Código banco]"
        '
        'lblTitFORMATO_ORDEN_COMPRA
        '
        Me.lblTitFORMATO_ORDEN_COMPRA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFORMATO_ORDEN_COMPRA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFORMATO_ORDEN_COMPRA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFORMATO_ORDEN_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFORMATO_ORDEN_COMPRA.Location = New System.Drawing.Point(6, 229)
        Me.lblTitFORMATO_ORDEN_COMPRA.Name = "lblTitFORMATO_ORDEN_COMPRA"
        Me.lblTitFORMATO_ORDEN_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFORMATO_ORDEN_COMPRA.Size = New System.Drawing.Size(178, 14)
        Me.lblTitFORMATO_ORDEN_COMPRA.TabIndex = 47
        Me.lblTitFORMATO_ORDEN_COMPRA.Text = "[Formato orden de compra]"
        '
        'lblTitDIRECCION_EMAIL
        '
        Me.lblTitDIRECCION_EMAIL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDIRECCION_EMAIL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDIRECCION_EMAIL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDIRECCION_EMAIL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDIRECCION_EMAIL.Location = New System.Drawing.Point(6, 283)
        Me.lblTitDIRECCION_EMAIL.Name = "lblTitDIRECCION_EMAIL"
        Me.lblTitDIRECCION_EMAIL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDIRECCION_EMAIL.Size = New System.Drawing.Size(178, 14)
        Me.lblTitDIRECCION_EMAIL.TabIndex = 46
        Me.lblTitDIRECCION_EMAIL.Text = "[Dirección e-mail]"
        '
        'lblTitACEPTA_ENVIO_PARCIAL
        '
        Me.lblTitACEPTA_ENVIO_PARCIAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitACEPTA_ENVIO_PARCIAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitACEPTA_ENVIO_PARCIAL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitACEPTA_ENVIO_PARCIAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitACEPTA_ENVIO_PARCIAL.Location = New System.Drawing.Point(6, 256)
        Me.lblTitACEPTA_ENVIO_PARCIAL.Name = "lblTitACEPTA_ENVIO_PARCIAL"
        Me.lblTitACEPTA_ENVIO_PARCIAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitACEPTA_ENVIO_PARCIAL.Size = New System.Drawing.Size(178, 14)
        Me.lblTitACEPTA_ENVIO_PARCIAL.TabIndex = 45
        Me.lblTitACEPTA_ENVIO_PARCIAL.Text = "[Envio parcial]"
        '
        'lblTitNOMBRE_BENEFICIARIO
        '
        Me.lblTitNOMBRE_BENEFICIARIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNOMBRE_BENEFICIARIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNOMBRE_BENEFICIARIO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNOMBRE_BENEFICIARIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNOMBRE_BENEFICIARIO.Location = New System.Drawing.Point(6, 309)
        Me.lblTitNOMBRE_BENEFICIARIO.Name = "lblTitNOMBRE_BENEFICIARIO"
        Me.lblTitNOMBRE_BENEFICIARIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNOMBRE_BENEFICIARIO.Size = New System.Drawing.Size(178, 14)
        Me.lblTitNOMBRE_BENEFICIARIO.TabIndex = 44
        Me.lblTitNOMBRE_BENEFICIARIO.Text = "[Nombre beneficiario]"
        Me.lblTitNOMBRE_BENEFICIARIO.Visible = False
        '
        'PROVEM03
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 465)
        Me.Controls.Add(Me.Folder)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "PROVEM03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de proveedores - PROVEM03"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Folder.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    ' System.Windows.Forms.TextBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Folder As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents txtcomentario4_proveedo As Citi.Synergia.UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents txtcomentario3_proveedo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtcomentario2_proveedo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtcomentario1_proveedo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCod_postal_proveedor As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCedula_proveedor As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtnit_proveedor As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtfax_proveedor As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txttelefonos_proveedor As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtdireccion_proveedor As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtnombre_proveedor As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDESCRIPCION_PROV As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_PROVEEDOR As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtcomentario5_proveedo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitcomentario1_proveedo As System.Windows.Forms.Label
    Public WithEvents lblTitCod_postal_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTitCedula_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTitnit_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTitfax_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTittelefonos_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTitdireccion_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTitnombre_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIPCION_PROV As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents txtCUENTA_PROVEEDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblREFERENCIA_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblDESCRIP_CODIGO_ISR As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_ISR As System.Windows.Forms.Label
    Public WithEvents lblTitPARTICIPA_RETENCION As System.Windows.Forms.Label
    Public WithEvents lblTitLINEA_DE_CREDITO As System.Windows.Forms.Label
    Public WithEvents lblTitGIRO_DE_NEGOCIO As System.Windows.Forms.Label
    Public WithEvents lblTitNUMERO_REGISTRO As System.Windows.Forms.Label
    Public WithEvents lblTitcongelado As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblTitTOMA_DESCUENTOS As System.Windows.Forms.Label
    Public WithEvents lblTitESTATUS_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblTitporcentaje_descuento As System.Windows.Forms.Label
    Public WithEvents lblTitpaga_iva_proveedor As System.Windows.Forms.Label
    Public WithEvents lblTitPROVEEDOR_UNICA_VEZ As System.Windows.Forms.Label
    Public WithEvents txtREFERENCIA_PROVEEDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_ISR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNUMERO_REGISTRO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtGIRO_DE_NEGOCIO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtLINEA_DE_CREDITO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtporcentaje_descuento As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitTIPO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblTitCUENTA_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_DE_PAIS As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCODIGO_IMPUESTO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_DE_CONDICION As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCODIGO_CUENTA As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCODIGO_CLASE_PROVEED As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_TIPO_PAGO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_BANCO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtFORMATO_ORDEN_COMPRA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDIRECCION_EMAIL As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNOMBRE_BENEFICIARIO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDESCRIPCION_CLASE As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_IMPUESTO As System.Windows.Forms.Label
    Public WithEvents lblNOMBRE_DEL_PAIS As System.Windows.Forms.Label
    Public WithEvents lblNOMBRE_CUENTA As System.Windows.Forms.Label
    Public WithEvents lblDESC_TIPO_PAGO As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCI_CONDICION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblNOMBRE_BANCO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_PAIS As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_IMPUESTO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_CONDICION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CUENTA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CLASE_PROVEED As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_TIPO_PAGO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_BANCO As System.Windows.Forms.Label
    Public WithEvents lblTitFORMATO_ORDEN_COMPRA As System.Windows.Forms.Label
    Public WithEvents lblTitDIRECCION_EMAIL As System.Windows.Forms.Label
    Public WithEvents lblTitACEPTA_ENVIO_PARCIAL As System.Windows.Forms.Label
    Public WithEvents lblTitNOMBRE_BENEFICIARIO As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Public WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Public WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Public WithEvents cboPARTICIPA_RETENCION As System.Windows.Forms.ComboBox
    Public WithEvents cboCONGELADO As System.Windows.Forms.ComboBox
    Public WithEvents cboESTATUS_PROVEEDOR As System.Windows.Forms.ComboBox
    Public WithEvents cboPROVEEDOR_UNICA_VEZ As System.Windows.Forms.ComboBox
    Public WithEvents cboTOMA_DESCUENTOS As System.Windows.Forms.ComboBox
    Public WithEvents cboORIGEN_PROVEEDOR As System.Windows.Forms.ComboBox
    Public WithEvents cboTIPO_PROVEEDOR As System.Windows.Forms.ComboBox
    Public WithEvents cboPAGA_IVA_PROVEEDOR As System.Windows.Forms.ComboBox
    Public WithEvents cboACEPTA_ENVIO_PARCIAL As System.Windows.Forms.ComboBox
End Class
