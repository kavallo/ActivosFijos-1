<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MONEDM02
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento 'System.Windows.Forms.Form

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
        Me.chkREEMPLAZA_CENTRO_OPE = New System.Windows.Forms.CheckBox()
        Me.txtCODIGO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIPCION_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtSIGNO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTIPO_CATALOGO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_CENTRO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCUENTA_CONTABLE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNOMBRE_FRACCION_MONE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblDESC_CUENTA_CONTABLE = New System.Windows.Forms.Label()
        Me.lblNOMBRE_CATALOGO = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitDESCRIPCION_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitSIGNO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitTIPO_CATALOGO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CENTRO = New System.Windows.Forms.Label()
        Me.lblTitCUENTA_CONTABLE = New System.Windows.Forms.Label()
        Me.lblTitNOMBRE_FRACCION_MONE = New System.Windows.Forms.Label()
        Me.chkDefault = New System.Windows.Forms.CheckBox()
        Me.txtMonedaCosmos = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblMonedaCosmos = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkREEMPLAZA_CENTRO_OPE
        '
        Me.chkREEMPLAZA_CENTRO_OPE.BackColor = System.Drawing.SystemColors.Control
        Me.chkREEMPLAZA_CENTRO_OPE.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkREEMPLAZA_CENTRO_OPE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkREEMPLAZA_CENTRO_OPE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkREEMPLAZA_CENTRO_OPE.Location = New System.Drawing.Point(146, 90)
        Me.chkREEMPLAZA_CENTRO_OPE.Name = "chkREEMPLAZA_CENTRO_OPE"
        Me.chkREEMPLAZA_CENTRO_OPE.Size = New System.Drawing.Size(175, 20)
        Me.chkREEMPLAZA_CENTRO_OPE.TabIndex = 4
        Me.chkREEMPLAZA_CENTRO_OPE.Text = "Reemplaza centro"
        Me.chkREEMPLAZA_CENTRO_OPE.UseVisualStyleBackColor = False
        '
        'txtCODIGO_DE_MONEDA
        '
        Me.txtCODIGO_DE_MONEDA.AcceptsReturn = True
        Me.txtCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_MONEDA.EsRequerido = True
        Me.txtCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_MONEDA.LabelConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.Location = New System.Drawing.Point(146, 12)
        Me.txtCODIGO_DE_MONEDA.MaxLength = 5
        Me.txtCODIGO_DE_MONEDA.Name = "txtCODIGO_DE_MONEDA"
        Me.txtCODIGO_DE_MONEDA.NombreDeConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_MONEDA.Size = New System.Drawing.Size(52, 20)
        Me.txtCODIGO_DE_MONEDA.TabIndex = 0
        '
        'txtDESCRIPCION_MONEDA
        '
        Me.txtDESCRIPCION_MONEDA.AcceptsReturn = True
        Me.txtDESCRIPCION_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION_MONEDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION_MONEDA.EsRequerido = True
        Me.txtDESCRIPCION_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION_MONEDA.LabelConsulta = Nothing
        Me.txtDESCRIPCION_MONEDA.Location = New System.Drawing.Point(146, 38)
        Me.txtDESCRIPCION_MONEDA.MaxLength = 40
        Me.txtDESCRIPCION_MONEDA.Name = "txtDESCRIPCION_MONEDA"
        Me.txtDESCRIPCION_MONEDA.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION_MONEDA.Size = New System.Drawing.Size(349, 20)
        Me.txtDESCRIPCION_MONEDA.TabIndex = 2
        '
        'txtSIGNO_DE_MONEDA
        '
        Me.txtSIGNO_DE_MONEDA.AcceptsReturn = True
        Me.txtSIGNO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtSIGNO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSIGNO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSIGNO_DE_MONEDA.EsRequerido = True
        Me.txtSIGNO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSIGNO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSIGNO_DE_MONEDA.LabelConsulta = Nothing
        Me.txtSIGNO_DE_MONEDA.Location = New System.Drawing.Point(146, 64)
        Me.txtSIGNO_DE_MONEDA.MaxLength = 3
        Me.txtSIGNO_DE_MONEDA.Name = "txtSIGNO_DE_MONEDA"
        Me.txtSIGNO_DE_MONEDA.NombreDeConsulta = Nothing
        Me.txtSIGNO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSIGNO_DE_MONEDA.Size = New System.Drawing.Size(52, 20)
        Me.txtSIGNO_DE_MONEDA.TabIndex = 3
        '
        'txtTIPO_CATALOGO
        '
        Me.txtTIPO_CATALOGO.AcceptsReturn = True
        Me.txtTIPO_CATALOGO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIPO_CATALOGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIPO_CATALOGO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIPO_CATALOGO.EsRequerido = False
        Me.txtTIPO_CATALOGO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_CATALOGO.LabelConsulta = Nothing
        Me.txtTIPO_CATALOGO.Location = New System.Drawing.Point(146, 116)
        Me.txtTIPO_CATALOGO.MaxLength = 3
        Me.txtTIPO_CATALOGO.Name = "txtTIPO_CATALOGO"
        Me.txtTIPO_CATALOGO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCatalogosContables_CACOEC01
        Me.txtTIPO_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_CATALOGO.Size = New System.Drawing.Size(52, 20)
        Me.txtTIPO_CATALOGO.TabIndex = 6
        Me.txtTIPO_CATALOGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_CENTRO
        '
        Me.txtCODIGO_CENTRO.AcceptsReturn = True
        Me.txtCODIGO_CENTRO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_CENTRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_CENTRO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_CENTRO.EsRequerido = False
        Me.txtCODIGO_CENTRO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_CENTRO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_CENTRO.LabelConsulta = Nothing
        Me.txtCODIGO_CENTRO.Location = New System.Drawing.Point(146, 142)
        Me.txtCODIGO_CENTRO.MaxLength = 15
        Me.txtCODIGO_CENTRO.Name = "txtCODIGO_CENTRO"
        Me.txtCODIGO_CENTRO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCODIGO_CENTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CENTRO.Size = New System.Drawing.Size(130, 20)
        Me.txtCODIGO_CENTRO.TabIndex = 7
        '
        'txtCUENTA_CONTABLE
        '
        Me.txtCUENTA_CONTABLE.AcceptsReturn = True
        Me.txtCUENTA_CONTABLE.BackColor = System.Drawing.SystemColors.Window
        Me.txtCUENTA_CONTABLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUENTA_CONTABLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCUENTA_CONTABLE.EsRequerido = False
        Me.txtCUENTA_CONTABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUENTA_CONTABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCUENTA_CONTABLE.LabelConsulta = Nothing
        Me.txtCUENTA_CONTABLE.Location = New System.Drawing.Point(146, 168)
        Me.txtCUENTA_CONTABLE.MaxLength = 30
        Me.txtCUENTA_CONTABLE.Name = "txtCUENTA_CONTABLE"
        Me.txtCUENTA_CONTABLE.NombreDeConsulta = Nothing
        Me.txtCUENTA_CONTABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_CONTABLE.Size = New System.Drawing.Size(262, 20)
        Me.txtCUENTA_CONTABLE.TabIndex = 8
        Me.txtCUENTA_CONTABLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNOMBRE_FRACCION_MONE
        '
        Me.txtNOMBRE_FRACCION_MONE.AcceptsReturn = True
        Me.txtNOMBRE_FRACCION_MONE.BackColor = System.Drawing.SystemColors.Window
        Me.txtNOMBRE_FRACCION_MONE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE_FRACCION_MONE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNOMBRE_FRACCION_MONE.EsRequerido = False
        Me.txtNOMBRE_FRACCION_MONE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE_FRACCION_MONE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNOMBRE_FRACCION_MONE.LabelConsulta = Nothing
        Me.txtNOMBRE_FRACCION_MONE.Location = New System.Drawing.Point(146, 214)
        Me.txtNOMBRE_FRACCION_MONE.MaxLength = 20
        Me.txtNOMBRE_FRACCION_MONE.Name = "txtNOMBRE_FRACCION_MONE"
        Me.txtNOMBRE_FRACCION_MONE.NombreDeConsulta = Nothing
        Me.txtNOMBRE_FRACCION_MONE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNOMBRE_FRACCION_MONE.Size = New System.Drawing.Size(175, 20)
        Me.txtNOMBRE_FRACCION_MONE.TabIndex = 9
        Me.txtNOMBRE_FRACCION_MONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(451, 240)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(544, 240)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblDESC_CUENTA_CONTABLE
        '
        Me.lblDESC_CUENTA_CONTABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblDESC_CUENTA_CONTABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESC_CUENTA_CONTABLE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESC_CUENTA_CONTABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESC_CUENTA_CONTABLE.Location = New System.Drawing.Point(146, 191)
        Me.lblDESC_CUENTA_CONTABLE.Name = "lblDESC_CUENTA_CONTABLE"
        Me.lblDESC_CUENTA_CONTABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESC_CUENTA_CONTABLE.Size = New System.Drawing.Size(349, 20)
        Me.lblDESC_CUENTA_CONTABLE.TabIndex = 39
        Me.lblDESC_CUENTA_CONTABLE.UseMnemonic = False
        '
        'lblNOMBRE_CATALOGO
        '
        Me.lblNOMBRE_CATALOGO.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_CATALOGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_CATALOGO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_CATALOGO.Location = New System.Drawing.Point(204, 118)
        Me.lblNOMBRE_CATALOGO.Name = "lblNOMBRE_CATALOGO"
        Me.lblNOMBRE_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_CATALOGO.Size = New System.Drawing.Size(349, 20)
        Me.lblNOMBRE_CATALOGO.TabIndex = 30
        Me.lblNOMBRE_CATALOGO.UseMnemonic = False
        '
        'lblDESCRIPCION
        '
        Me.lblDESCRIPCION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION.Location = New System.Drawing.Point(282, 144)
        Me.lblDESCRIPCION.Name = "lblDESCRIPCION"
        Me.lblDESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION.Size = New System.Drawing.Size(349, 20)
        Me.lblDESCRIPCION.TabIndex = 31
        Me.lblDESCRIPCION.UseMnemonic = False
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(12, 14)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 32
        Me.lblTitCODIGO_DE_MONEDA.Text = "Moneda"
        '
        'lblTitDESCRIPCION_MONEDA
        '
        Me.lblTitDESCRIPCION_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_MONEDA.Location = New System.Drawing.Point(12, 40)
        Me.lblTitDESCRIPCION_MONEDA.Name = "lblTitDESCRIPCION_MONEDA"
        Me.lblTitDESCRIPCION_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_MONEDA.Size = New System.Drawing.Size(128, 14)
        Me.lblTitDESCRIPCION_MONEDA.TabIndex = 33
        Me.lblTitDESCRIPCION_MONEDA.Text = "Descripción"
        '
        'lblTitSIGNO_DE_MONEDA
        '
        Me.lblTitSIGNO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitSIGNO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitSIGNO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitSIGNO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitSIGNO_DE_MONEDA.Location = New System.Drawing.Point(12, 66)
        Me.lblTitSIGNO_DE_MONEDA.Name = "lblTitSIGNO_DE_MONEDA"
        Me.lblTitSIGNO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitSIGNO_DE_MONEDA.Size = New System.Drawing.Size(128, 14)
        Me.lblTitSIGNO_DE_MONEDA.TabIndex = 34
        Me.lblTitSIGNO_DE_MONEDA.Text = "Signo"
        '
        'lblTitTIPO_CATALOGO
        '
        Me.lblTitTIPO_CATALOGO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_CATALOGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_CATALOGO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_CATALOGO.Location = New System.Drawing.Point(12, 118)
        Me.lblTitTIPO_CATALOGO.Name = "lblTitTIPO_CATALOGO"
        Me.lblTitTIPO_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_CATALOGO.Size = New System.Drawing.Size(128, 14)
        Me.lblTitTIPO_CATALOGO.TabIndex = 35
        Me.lblTitTIPO_CATALOGO.Text = "[Catálogo]"
        '
        'lblTitCODIGO_CENTRO
        '
        Me.lblTitCODIGO_CENTRO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CENTRO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CENTRO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CENTRO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CENTRO.Location = New System.Drawing.Point(12, 144)
        Me.lblTitCODIGO_CENTRO.Name = "lblTitCODIGO_CENTRO"
        Me.lblTitCODIGO_CENTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CENTRO.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCODIGO_CENTRO.TabIndex = 36
        Me.lblTitCODIGO_CENTRO.Text = "[Centro]"
        '
        'lblTitCUENTA_CONTABLE
        '
        Me.lblTitCUENTA_CONTABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_CONTABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_CONTABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_CONTABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_CONTABLE.Location = New System.Drawing.Point(12, 170)
        Me.lblTitCUENTA_CONTABLE.Name = "lblTitCUENTA_CONTABLE"
        Me.lblTitCUENTA_CONTABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_CONTABLE.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCUENTA_CONTABLE.TabIndex = 37
        Me.lblTitCUENTA_CONTABLE.Text = "[Cuenta contable]"
        '
        'lblTitNOMBRE_FRACCION_MONE
        '
        Me.lblTitNOMBRE_FRACCION_MONE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNOMBRE_FRACCION_MONE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNOMBRE_FRACCION_MONE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNOMBRE_FRACCION_MONE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNOMBRE_FRACCION_MONE.Location = New System.Drawing.Point(12, 216)
        Me.lblTitNOMBRE_FRACCION_MONE.Name = "lblTitNOMBRE_FRACCION_MONE"
        Me.lblTitNOMBRE_FRACCION_MONE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNOMBRE_FRACCION_MONE.Size = New System.Drawing.Size(128, 14)
        Me.lblTitNOMBRE_FRACCION_MONE.TabIndex = 38
        Me.lblTitNOMBRE_FRACCION_MONE.Text = "Nombre de la fracción"
        '
        'chkDefault
        '
        Me.chkDefault.BackColor = System.Drawing.SystemColors.Control
        Me.chkDefault.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDefault.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefault.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkDefault.Location = New System.Drawing.Point(327, 90)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(175, 20)
        Me.chkDefault.TabIndex = 5
        Me.chkDefault.Text = "Moneda default"
        Me.chkDefault.UseVisualStyleBackColor = False
        '
        'txtMonedaCosmos
        '
        Me.txtMonedaCosmos.AcceptsReturn = True
        Me.txtMonedaCosmos.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonedaCosmos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonedaCosmos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonedaCosmos.EsRequerido = False
        Me.txtMonedaCosmos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonedaCosmos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMonedaCosmos.LabelConsulta = Nothing
        Me.txtMonedaCosmos.Location = New System.Drawing.Point(443, 12)
        Me.txtMonedaCosmos.MaxLength = 3
        Me.txtMonedaCosmos.Name = "txtMonedaCosmos"
        Me.txtMonedaCosmos.NombreDeConsulta = Nothing
        Me.txtMonedaCosmos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMonedaCosmos.Size = New System.Drawing.Size(52, 20)
        Me.txtMonedaCosmos.TabIndex = 1
        '
        'lblMonedaCosmos
        '
        Me.lblMonedaCosmos.BackColor = System.Drawing.Color.Transparent
        Me.lblMonedaCosmos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMonedaCosmos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonedaCosmos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMonedaCosmos.Location = New System.Drawing.Point(309, 14)
        Me.lblMonedaCosmos.Name = "lblMonedaCosmos"
        Me.lblMonedaCosmos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMonedaCosmos.Size = New System.Drawing.Size(128, 14)
        Me.lblMonedaCosmos.TabIndex = 41
        Me.lblMonedaCosmos.Text = "Moneda Cosmos"
        '
        'MONEDM02
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(650, 277)
        Me.Controls.Add(Me.txtMonedaCosmos)
        Me.Controls.Add(Me.lblMonedaCosmos)
        Me.Controls.Add(Me.chkDefault)
        Me.Controls.Add(Me.txtCODIGO_DE_MONEDA)
        Me.Controls.Add(Me.txtDESCRIPCION_MONEDA)
        Me.Controls.Add(Me.txtSIGNO_DE_MONEDA)
        Me.Controls.Add(Me.chkREEMPLAZA_CENTRO_OPE)
        Me.Controls.Add(Me.txtTIPO_CATALOGO)
        Me.Controls.Add(Me.txtCODIGO_CENTRO)
        Me.Controls.Add(Me.txtCUENTA_CONTABLE)
        Me.Controls.Add(Me.txtNOMBRE_FRACCION_MONE)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblDESC_CUENTA_CONTABLE)
        Me.Controls.Add(Me.lblNOMBRE_CATALOGO)
        Me.Controls.Add(Me.lblDESCRIPCION)
        Me.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.Controls.Add(Me.lblTitDESCRIPCION_MONEDA)
        Me.Controls.Add(Me.lblTitSIGNO_DE_MONEDA)
        Me.Controls.Add(Me.lblTitTIPO_CATALOGO)
        Me.Controls.Add(Me.lblTitCODIGO_CENTRO)
        Me.Controls.Add(Me.lblTitCUENTA_CONTABLE)
        Me.Controls.Add(Me.lblTitNOMBRE_FRACCION_MONE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "MONEDM02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de monedas - MONEDM02"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents chkREEMPLAZA_CENTRO_OPE As System.Windows.Forms.CheckBox
    Public WithEvents txtCODIGO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDESCRIPCION_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtSIGNO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTIPO_CATALOGO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_CENTRO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCUENTA_CONTABLE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNOMBRE_FRACCION_MONE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents lblDESC_CUENTA_CONTABLE As System.Windows.Forms.Label
    Public WithEvents lblNOMBRE_CATALOGO As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIPCION_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitSIGNO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_CATALOGO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CENTRO As System.Windows.Forms.Label
    Public WithEvents lblTitCUENTA_CONTABLE As System.Windows.Forms.Label
    Public WithEvents lblTitNOMBRE_FRACCION_MONE As System.Windows.Forms.Label
    Public WithEvents chkDefault As System.Windows.Forms.CheckBox
    Public WithEvents txtMonedaCosmos As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblMonedaCosmos As System.Windows.Forms.Label
End Class
