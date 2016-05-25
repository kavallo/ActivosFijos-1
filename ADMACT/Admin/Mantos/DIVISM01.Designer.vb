<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIVISM01
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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.frmGASTOS_PATRONALES = New System.Windows.Forms.GroupBox()
        Me.txtCENTRO_GSTO_PATRONAL = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCUENTA_GSTO_PATRONAL = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDESC_CTA_GASTOS_PAT = New System.Windows.Forms.Label()
        Me.lblDESC_CEN_GASTOS_PAT = New System.Windows.Forms.Label()
        Me.lblTitCENTRO_GSTO_PATRONAL = New System.Windows.Forms.Label()
        Me.lblTitCUENTA_GSTO_PATRONAL = New System.Windows.Forms.Label()
        Me.frmPRESTACION = New System.Windows.Forms.GroupBox()
        Me.txtCUENTA_CONTABLE_PXP = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_CENTRO_PXP = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCUENTA_CONTABLE_PXP = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CENTRO_PXP = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_PXP = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_CUENTA_PXP = New System.Windows.Forms.Label()
        Me.frmSUELDOS = New System.Windows.Forms.GroupBox()
        Me.txtCODIGO_CENTRO_SXP = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCUENTA_CONTABLE_SXP = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDESCRIPCION_CUENTA_SXP = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_SXP = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CENTRO_SXP = New System.Windows.Forms.Label()
        Me.lblTitCUENTA_CONTABLE_SXP = New System.Windows.Forms.Label()
        Me.frmGASTOS = New System.Windows.Forms.GroupBox()
        Me.txtCUENTA_CONTABLE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_CENTRO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCUENTA_CONTABLE = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CENTRO = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_CUENTA = New System.Windows.Forms.Label()
        Me.txtDESCRIPCION_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtRESPONSABLE_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDIRECCION_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTELEFONO_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTIPO_CATALOGO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblNOMBRE_CATALOGO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitRESPONSABLE_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitDIRECCION_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitTELEFONO_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitTIPO_CATALOGO = New System.Windows.Forms.Label()
        Me.txtCODIGO_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmGASTOS_PATRONALES.SuspendLayout()
        Me.frmPRESTACION.SuspendLayout()
        Me.frmSUELDOS.SuspendLayout()
        Me.frmGASTOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(627, 472)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(534, 472)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'frmGASTOS_PATRONALES
        '
        Me.frmGASTOS_PATRONALES.BackColor = System.Drawing.SystemColors.Control
        Me.frmGASTOS_PATRONALES.Controls.Add(Me.txtCENTRO_GSTO_PATRONAL)
        Me.frmGASTOS_PATRONALES.Controls.Add(Me.txtCUENTA_GSTO_PATRONAL)
        Me.frmGASTOS_PATRONALES.Controls.Add(Me.lblDESC_CTA_GASTOS_PAT)
        Me.frmGASTOS_PATRONALES.Controls.Add(Me.lblDESC_CEN_GASTOS_PAT)
        Me.frmGASTOS_PATRONALES.Controls.Add(Me.lblTitCENTRO_GSTO_PATRONAL)
        Me.frmGASTOS_PATRONALES.Controls.Add(Me.lblTitCUENTA_GSTO_PATRONAL)
        Me.frmGASTOS_PATRONALES.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmGASTOS_PATRONALES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmGASTOS_PATRONALES.Location = New System.Drawing.Point(12, 394)
        Me.frmGASTOS_PATRONALES.Name = "frmGASTOS_PATRONALES"
        Me.frmGASTOS_PATRONALES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGASTOS_PATRONALES.Size = New System.Drawing.Size(702, 72)
        Me.frmGASTOS_PATRONALES.TabIndex = 9
        Me.frmGASTOS_PATRONALES.TabStop = False
        Me.frmGASTOS_PATRONALES.Text = "Nómina - Cuenta de gastos patronales"
        '
        'txtCENTRO_GSTO_PATRONAL
        '
        Me.txtCENTRO_GSTO_PATRONAL.AcceptsReturn = True
        Me.txtCENTRO_GSTO_PATRONAL.BackColor = System.Drawing.SystemColors.Window
        Me.txtCENTRO_GSTO_PATRONAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCENTRO_GSTO_PATRONAL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCENTRO_GSTO_PATRONAL.EsRequerido = False
        Me.txtCENTRO_GSTO_PATRONAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCENTRO_GSTO_PATRONAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCENTRO_GSTO_PATRONAL.LabelConsulta = Nothing
        Me.txtCENTRO_GSTO_PATRONAL.Location = New System.Drawing.Point(134, 19)
        Me.txtCENTRO_GSTO_PATRONAL.MaxLength = 15
        Me.txtCENTRO_GSTO_PATRONAL.Name = "txtCENTRO_GSTO_PATRONAL"
        Me.txtCENTRO_GSTO_PATRONAL.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCENTRO_GSTO_PATRONAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCENTRO_GSTO_PATRONAL.Size = New System.Drawing.Size(130, 20)
        Me.txtCENTRO_GSTO_PATRONAL.TabIndex = 19
        '
        'txtCUENTA_GSTO_PATRONAL
        '
        Me.txtCUENTA_GSTO_PATRONAL.AcceptsReturn = True
        Me.txtCUENTA_GSTO_PATRONAL.BackColor = System.Drawing.SystemColors.Window
        Me.txtCUENTA_GSTO_PATRONAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUENTA_GSTO_PATRONAL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCUENTA_GSTO_PATRONAL.EsRequerido = False
        Me.txtCUENTA_GSTO_PATRONAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUENTA_GSTO_PATRONAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCUENTA_GSTO_PATRONAL.LabelConsulta = Nothing
        Me.txtCUENTA_GSTO_PATRONAL.Location = New System.Drawing.Point(134, 45)
        Me.txtCUENTA_GSTO_PATRONAL.MaxLength = 30
        Me.txtCUENTA_GSTO_PATRONAL.Name = "txtCUENTA_GSTO_PATRONAL"
        Me.txtCUENTA_GSTO_PATRONAL.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCUENTA_GSTO_PATRONAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_GSTO_PATRONAL.Size = New System.Drawing.Size(260, 20)
        Me.txtCUENTA_GSTO_PATRONAL.TabIndex = 21
        '
        'lblDESC_CTA_GASTOS_PAT
        '
        Me.lblDESC_CTA_GASTOS_PAT.BackColor = System.Drawing.Color.Transparent
        Me.lblDESC_CTA_GASTOS_PAT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESC_CTA_GASTOS_PAT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESC_CTA_GASTOS_PAT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESC_CTA_GASTOS_PAT.Location = New System.Drawing.Point(400, 47)
        Me.lblDESC_CTA_GASTOS_PAT.Name = "lblDESC_CTA_GASTOS_PAT"
        Me.lblDESC_CTA_GASTOS_PAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESC_CTA_GASTOS_PAT.Size = New System.Drawing.Size(296, 13)
        Me.lblDESC_CTA_GASTOS_PAT.TabIndex = 22
        Me.lblDESC_CTA_GASTOS_PAT.Text = "Descripción cuenta gastos patronales"
        Me.lblDESC_CTA_GASTOS_PAT.UseMnemonic = False
        '
        'lblDESC_CEN_GASTOS_PAT
        '
        Me.lblDESC_CEN_GASTOS_PAT.BackColor = System.Drawing.Color.Transparent
        Me.lblDESC_CEN_GASTOS_PAT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESC_CEN_GASTOS_PAT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESC_CEN_GASTOS_PAT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESC_CEN_GASTOS_PAT.Location = New System.Drawing.Point(270, 21)
        Me.lblDESC_CEN_GASTOS_PAT.Name = "lblDESC_CEN_GASTOS_PAT"
        Me.lblDESC_CEN_GASTOS_PAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESC_CEN_GASTOS_PAT.Size = New System.Drawing.Size(426, 16)
        Me.lblDESC_CEN_GASTOS_PAT.TabIndex = 20
        Me.lblDESC_CEN_GASTOS_PAT.Text = "Descripción centro gastos patronales"
        Me.lblDESC_CEN_GASTOS_PAT.UseMnemonic = False
        '
        'lblTitCENTRO_GSTO_PATRONAL
        '
        Me.lblTitCENTRO_GSTO_PATRONAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCENTRO_GSTO_PATRONAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCENTRO_GSTO_PATRONAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCENTRO_GSTO_PATRONAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCENTRO_GSTO_PATRONAL.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCENTRO_GSTO_PATRONAL.Name = "lblTitCENTRO_GSTO_PATRONAL"
        Me.lblTitCENTRO_GSTO_PATRONAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCENTRO_GSTO_PATRONAL.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCENTRO_GSTO_PATRONAL.TabIndex = 35
        Me.lblTitCENTRO_GSTO_PATRONAL.Text = "[Centro]"
        '
        'lblTitCUENTA_GSTO_PATRONAL
        '
        Me.lblTitCUENTA_GSTO_PATRONAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_GSTO_PATRONAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_GSTO_PATRONAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_GSTO_PATRONAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_GSTO_PATRONAL.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCUENTA_GSTO_PATRONAL.Name = "lblTitCUENTA_GSTO_PATRONAL"
        Me.lblTitCUENTA_GSTO_PATRONAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_GSTO_PATRONAL.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCUENTA_GSTO_PATRONAL.TabIndex = 36
        Me.lblTitCUENTA_GSTO_PATRONAL.Text = "[Cuenta contable]"
        '
        'frmPRESTACION
        '
        Me.frmPRESTACION.BackColor = System.Drawing.SystemColors.Control
        Me.frmPRESTACION.Controls.Add(Me.txtCUENTA_CONTABLE_PXP)
        Me.frmPRESTACION.Controls.Add(Me.txtCODIGO_CENTRO_PXP)
        Me.frmPRESTACION.Controls.Add(Me.lblTitCUENTA_CONTABLE_PXP)
        Me.frmPRESTACION.Controls.Add(Me.lblTitCODIGO_CENTRO_PXP)
        Me.frmPRESTACION.Controls.Add(Me.lblDESCRIPCION_PXP)
        Me.frmPRESTACION.Controls.Add(Me.lblDESCRIPCION_CUENTA_PXP)
        Me.frmPRESTACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmPRESTACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmPRESTACION.Location = New System.Drawing.Point(12, 316)
        Me.frmPRESTACION.Name = "frmPRESTACION"
        Me.frmPRESTACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmPRESTACION.Size = New System.Drawing.Size(702, 72)
        Me.frmPRESTACION.TabIndex = 8
        Me.frmPRESTACION.TabStop = False
        Me.frmPRESTACION.Text = "Nómina - Cuenta de prestaciones por pagar"
        '
        'txtCUENTA_CONTABLE_PXP
        '
        Me.txtCUENTA_CONTABLE_PXP.AcceptsReturn = True
        Me.txtCUENTA_CONTABLE_PXP.BackColor = System.Drawing.SystemColors.Window
        Me.txtCUENTA_CONTABLE_PXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUENTA_CONTABLE_PXP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCUENTA_CONTABLE_PXP.EsRequerido = False
        Me.txtCUENTA_CONTABLE_PXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUENTA_CONTABLE_PXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCUENTA_CONTABLE_PXP.LabelConsulta = Nothing
        Me.txtCUENTA_CONTABLE_PXP.Location = New System.Drawing.Point(134, 45)
        Me.txtCUENTA_CONTABLE_PXP.MaxLength = 30
        Me.txtCUENTA_CONTABLE_PXP.Name = "txtCUENTA_CONTABLE_PXP"
        Me.txtCUENTA_CONTABLE_PXP.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCUENTA_CONTABLE_PXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_CONTABLE_PXP.Size = New System.Drawing.Size(260, 20)
        Me.txtCUENTA_CONTABLE_PXP.TabIndex = 17
        '
        'txtCODIGO_CENTRO_PXP
        '
        Me.txtCODIGO_CENTRO_PXP.AcceptsReturn = True
        Me.txtCODIGO_CENTRO_PXP.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_CENTRO_PXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_CENTRO_PXP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_CENTRO_PXP.EsRequerido = False
        Me.txtCODIGO_CENTRO_PXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_CENTRO_PXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_CENTRO_PXP.LabelConsulta = Nothing
        Me.txtCODIGO_CENTRO_PXP.Location = New System.Drawing.Point(134, 19)
        Me.txtCODIGO_CENTRO_PXP.MaxLength = 15
        Me.txtCODIGO_CENTRO_PXP.Name = "txtCODIGO_CENTRO_PXP"
        Me.txtCODIGO_CENTRO_PXP.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCODIGO_CENTRO_PXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CENTRO_PXP.Size = New System.Drawing.Size(130, 20)
        Me.txtCODIGO_CENTRO_PXP.TabIndex = 15
        '
        'lblTitCUENTA_CONTABLE_PXP
        '
        Me.lblTitCUENTA_CONTABLE_PXP.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_CONTABLE_PXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_CONTABLE_PXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_CONTABLE_PXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_CONTABLE_PXP.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCUENTA_CONTABLE_PXP.Name = "lblTitCUENTA_CONTABLE_PXP"
        Me.lblTitCUENTA_CONTABLE_PXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_CONTABLE_PXP.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCUENTA_CONTABLE_PXP.TabIndex = 34
        Me.lblTitCUENTA_CONTABLE_PXP.Text = "[Cuenta contable]"
        '
        'lblTitCODIGO_CENTRO_PXP
        '
        Me.lblTitCODIGO_CENTRO_PXP.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CENTRO_PXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CENTRO_PXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CENTRO_PXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CENTRO_PXP.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCODIGO_CENTRO_PXP.Name = "lblTitCODIGO_CENTRO_PXP"
        Me.lblTitCODIGO_CENTRO_PXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CENTRO_PXP.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCODIGO_CENTRO_PXP.TabIndex = 33
        Me.lblTitCODIGO_CENTRO_PXP.Text = "[Centro]"
        '
        'lblDESCRIPCION_PXP
        '
        Me.lblDESCRIPCION_PXP.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_PXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_PXP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_PXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_PXP.Location = New System.Drawing.Point(270, 21)
        Me.lblDESCRIPCION_PXP.Name = "lblDESCRIPCION_PXP"
        Me.lblDESCRIPCION_PXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_PXP.Size = New System.Drawing.Size(426, 16)
        Me.lblDESCRIPCION_PXP.TabIndex = 16
        Me.lblDESCRIPCION_PXP.Text = "Descripción centro prestaciones por pagar"
        Me.lblDESCRIPCION_PXP.UseMnemonic = False
        '
        'lblDESCRIPCION_CUENTA_PXP
        '
        Me.lblDESCRIPCION_CUENTA_PXP.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_CUENTA_PXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_CUENTA_PXP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_CUENTA_PXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_CUENTA_PXP.Location = New System.Drawing.Point(400, 47)
        Me.lblDESCRIPCION_CUENTA_PXP.Name = "lblDESCRIPCION_CUENTA_PXP"
        Me.lblDESCRIPCION_CUENTA_PXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_CUENTA_PXP.Size = New System.Drawing.Size(296, 13)
        Me.lblDESCRIPCION_CUENTA_PXP.TabIndex = 18
        Me.lblDESCRIPCION_CUENTA_PXP.Text = "Descripción cuenta prestaciones por pagar"
        Me.lblDESCRIPCION_CUENTA_PXP.UseMnemonic = False
        '
        'frmSUELDOS
        '
        Me.frmSUELDOS.BackColor = System.Drawing.SystemColors.Control
        Me.frmSUELDOS.Controls.Add(Me.txtCODIGO_CENTRO_SXP)
        Me.frmSUELDOS.Controls.Add(Me.txtCUENTA_CONTABLE_SXP)
        Me.frmSUELDOS.Controls.Add(Me.lblDESCRIPCION_CUENTA_SXP)
        Me.frmSUELDOS.Controls.Add(Me.lblDESCRIPCION_SXP)
        Me.frmSUELDOS.Controls.Add(Me.lblTitCODIGO_CENTRO_SXP)
        Me.frmSUELDOS.Controls.Add(Me.lblTitCUENTA_CONTABLE_SXP)
        Me.frmSUELDOS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmSUELDOS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmSUELDOS.Location = New System.Drawing.Point(12, 238)
        Me.frmSUELDOS.Name = "frmSUELDOS"
        Me.frmSUELDOS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmSUELDOS.Size = New System.Drawing.Size(702, 72)
        Me.frmSUELDOS.TabIndex = 7
        Me.frmSUELDOS.TabStop = False
        Me.frmSUELDOS.Text = "Nómina - Cuenta de sueldos por pagar"
        '
        'txtCODIGO_CENTRO_SXP
        '
        Me.txtCODIGO_CENTRO_SXP.AcceptsReturn = True
        Me.txtCODIGO_CENTRO_SXP.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_CENTRO_SXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_CENTRO_SXP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_CENTRO_SXP.EsRequerido = False
        Me.txtCODIGO_CENTRO_SXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_CENTRO_SXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_CENTRO_SXP.LabelConsulta = Nothing
        Me.txtCODIGO_CENTRO_SXP.Location = New System.Drawing.Point(134, 19)
        Me.txtCODIGO_CENTRO_SXP.MaxLength = 15
        Me.txtCODIGO_CENTRO_SXP.Name = "txtCODIGO_CENTRO_SXP"
        Me.txtCODIGO_CENTRO_SXP.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCODIGO_CENTRO_SXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CENTRO_SXP.Size = New System.Drawing.Size(130, 20)
        Me.txtCODIGO_CENTRO_SXP.TabIndex = 11
        '
        'txtCUENTA_CONTABLE_SXP
        '
        Me.txtCUENTA_CONTABLE_SXP.AcceptsReturn = True
        Me.txtCUENTA_CONTABLE_SXP.BackColor = System.Drawing.SystemColors.Window
        Me.txtCUENTA_CONTABLE_SXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUENTA_CONTABLE_SXP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCUENTA_CONTABLE_SXP.EsRequerido = False
        Me.txtCUENTA_CONTABLE_SXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUENTA_CONTABLE_SXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCUENTA_CONTABLE_SXP.LabelConsulta = Nothing
        Me.txtCUENTA_CONTABLE_SXP.Location = New System.Drawing.Point(134, 45)
        Me.txtCUENTA_CONTABLE_SXP.MaxLength = 30
        Me.txtCUENTA_CONTABLE_SXP.Name = "txtCUENTA_CONTABLE_SXP"
        Me.txtCUENTA_CONTABLE_SXP.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCUENTA_CONTABLE_SXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_CONTABLE_SXP.Size = New System.Drawing.Size(260, 20)
        Me.txtCUENTA_CONTABLE_SXP.TabIndex = 13
        '
        'lblDESCRIPCION_CUENTA_SXP
        '
        Me.lblDESCRIPCION_CUENTA_SXP.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_CUENTA_SXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_CUENTA_SXP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_CUENTA_SXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_CUENTA_SXP.Location = New System.Drawing.Point(400, 47)
        Me.lblDESCRIPCION_CUENTA_SXP.Name = "lblDESCRIPCION_CUENTA_SXP"
        Me.lblDESCRIPCION_CUENTA_SXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_CUENTA_SXP.Size = New System.Drawing.Size(296, 13)
        Me.lblDESCRIPCION_CUENTA_SXP.TabIndex = 14
        Me.lblDESCRIPCION_CUENTA_SXP.Text = "Descripción cuenta sueldos por pagar"
        Me.lblDESCRIPCION_CUENTA_SXP.UseMnemonic = False
        '
        'lblDESCRIPCION_SXP
        '
        Me.lblDESCRIPCION_SXP.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_SXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_SXP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_SXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_SXP.Location = New System.Drawing.Point(270, 21)
        Me.lblDESCRIPCION_SXP.Name = "lblDESCRIPCION_SXP"
        Me.lblDESCRIPCION_SXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_SXP.Size = New System.Drawing.Size(426, 21)
        Me.lblDESCRIPCION_SXP.TabIndex = 12
        Me.lblDESCRIPCION_SXP.Text = "Descripción centro sueldos por pagar"
        Me.lblDESCRIPCION_SXP.UseMnemonic = False
        '
        'lblTitCODIGO_CENTRO_SXP
        '
        Me.lblTitCODIGO_CENTRO_SXP.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CENTRO_SXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CENTRO_SXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CENTRO_SXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CENTRO_SXP.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCODIGO_CENTRO_SXP.Name = "lblTitCODIGO_CENTRO_SXP"
        Me.lblTitCODIGO_CENTRO_SXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CENTRO_SXP.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCODIGO_CENTRO_SXP.TabIndex = 31
        Me.lblTitCODIGO_CENTRO_SXP.Text = "[Centro]"
        '
        'lblTitCUENTA_CONTABLE_SXP
        '
        Me.lblTitCUENTA_CONTABLE_SXP.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_CONTABLE_SXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_CONTABLE_SXP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_CONTABLE_SXP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_CONTABLE_SXP.Location = New System.Drawing.Point(6, 50)
        Me.lblTitCUENTA_CONTABLE_SXP.Name = "lblTitCUENTA_CONTABLE_SXP"
        Me.lblTitCUENTA_CONTABLE_SXP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_CONTABLE_SXP.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCUENTA_CONTABLE_SXP.TabIndex = 32
        Me.lblTitCUENTA_CONTABLE_SXP.Text = "[Cuenta contable]"
        '
        'frmGASTOS
        '
        Me.frmGASTOS.BackColor = System.Drawing.SystemColors.Control
        Me.frmGASTOS.Controls.Add(Me.txtCUENTA_CONTABLE)
        Me.frmGASTOS.Controls.Add(Me.txtCODIGO_CENTRO)
        Me.frmGASTOS.Controls.Add(Me.lblTitCUENTA_CONTABLE)
        Me.frmGASTOS.Controls.Add(Me.lblTitCODIGO_CENTRO)
        Me.frmGASTOS.Controls.Add(Me.lblDESCRIPCION)
        Me.frmGASTOS.Controls.Add(Me.lblDESCRIPCION_CUENTA)
        Me.frmGASTOS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmGASTOS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmGASTOS.Location = New System.Drawing.Point(12, 160)
        Me.frmGASTOS.Name = "frmGASTOS"
        Me.frmGASTOS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGASTOS.Size = New System.Drawing.Size(702, 72)
        Me.frmGASTOS.TabIndex = 6
        Me.frmGASTOS.TabStop = False
        Me.frmGASTOS.Tag = ""
        Me.frmGASTOS.Text = "Proveduría - Cuenta de gastos de papelería"
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
        Me.txtCUENTA_CONTABLE.Location = New System.Drawing.Point(134, 45)
        Me.txtCUENTA_CONTABLE.MaxLength = 30
        Me.txtCUENTA_CONTABLE.Name = "txtCUENTA_CONTABLE"
        Me.txtCUENTA_CONTABLE.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCUENTA_CONTABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_CONTABLE.Size = New System.Drawing.Size(260, 20)
        Me.txtCUENTA_CONTABLE.TabIndex = 7
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
        Me.txtCODIGO_CENTRO.Location = New System.Drawing.Point(134, 19)
        Me.txtCODIGO_CENTRO.MaxLength = 15
        Me.txtCODIGO_CENTRO.Name = "txtCODIGO_CENTRO"
        Me.txtCODIGO_CENTRO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCODIGO_CENTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CENTRO.Size = New System.Drawing.Size(130, 20)
        Me.txtCODIGO_CENTRO.TabIndex = 6
        '
        'lblTitCUENTA_CONTABLE
        '
        Me.lblTitCUENTA_CONTABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_CONTABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_CONTABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_CONTABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_CONTABLE.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCUENTA_CONTABLE.Name = "lblTitCUENTA_CONTABLE"
        Me.lblTitCUENTA_CONTABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_CONTABLE.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCUENTA_CONTABLE.TabIndex = 30
        Me.lblTitCUENTA_CONTABLE.Text = "[Cuenta contable]"
        '
        'lblTitCODIGO_CENTRO
        '
        Me.lblTitCODIGO_CENTRO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CENTRO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CENTRO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CENTRO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CENTRO.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCODIGO_CENTRO.Name = "lblTitCODIGO_CENTRO"
        Me.lblTitCODIGO_CENTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CENTRO.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCODIGO_CENTRO.TabIndex = 29
        Me.lblTitCODIGO_CENTRO.Text = "[Centro]"
        '
        'lblDESCRIPCION
        '
        Me.lblDESCRIPCION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION.Location = New System.Drawing.Point(270, 21)
        Me.lblDESCRIPCION.Name = "lblDESCRIPCION"
        Me.lblDESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION.Size = New System.Drawing.Size(426, 16)
        Me.lblDESCRIPCION.TabIndex = 8
        Me.lblDESCRIPCION.Text = "Descripción centro gastos papeleria"
        Me.lblDESCRIPCION.UseMnemonic = False
        '
        'lblDESCRIPCION_CUENTA
        '
        Me.lblDESCRIPCION_CUENTA.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_CUENTA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_CUENTA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_CUENTA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_CUENTA.Location = New System.Drawing.Point(400, 47)
        Me.lblDESCRIPCION_CUENTA.Name = "lblDESCRIPCION_CUENTA"
        Me.lblDESCRIPCION_CUENTA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_CUENTA.Size = New System.Drawing.Size(296, 13)
        Me.lblDESCRIPCION_CUENTA.TabIndex = 10
        Me.lblDESCRIPCION_CUENTA.Text = "Descripción cuenta gastos papeleria"
        Me.lblDESCRIPCION_CUENTA.UseMnemonic = False
        '
        'txtDESCRIPCION_DIVISION
        '
        Me.txtDESCRIPCION_DIVISION.AcceptsReturn = True
        Me.txtDESCRIPCION_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION_DIVISION.EsRequerido = True
        Me.txtDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION_DIVISION.LabelConsulta = Nothing
        Me.txtDESCRIPCION_DIVISION.Location = New System.Drawing.Point(146, 38)
        Me.txtDESCRIPCION_DIVISION.MaxLength = 60
        Me.txtDESCRIPCION_DIVISION.Name = "txtDESCRIPCION_DIVISION"
        Me.txtDESCRIPCION_DIVISION.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION_DIVISION.Size = New System.Drawing.Size(517, 20)
        Me.txtDESCRIPCION_DIVISION.TabIndex = 1
        '
        'txtRESPONSABLE_DIVISION
        '
        Me.txtRESPONSABLE_DIVISION.AcceptsReturn = True
        Me.txtRESPONSABLE_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtRESPONSABLE_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRESPONSABLE_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRESPONSABLE_DIVISION.EsRequerido = True
        Me.txtRESPONSABLE_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRESPONSABLE_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRESPONSABLE_DIVISION.LabelConsulta = Nothing
        Me.txtRESPONSABLE_DIVISION.Location = New System.Drawing.Point(146, 62)
        Me.txtRESPONSABLE_DIVISION.MaxLength = 40
        Me.txtRESPONSABLE_DIVISION.Name = "txtRESPONSABLE_DIVISION"
        Me.txtRESPONSABLE_DIVISION.NombreDeConsulta = Nothing
        Me.txtRESPONSABLE_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRESPONSABLE_DIVISION.Size = New System.Drawing.Size(347, 20)
        Me.txtRESPONSABLE_DIVISION.TabIndex = 2
        '
        'txtDIRECCION_DIVISION
        '
        Me.txtDIRECCION_DIVISION.AcceptsReturn = True
        Me.txtDIRECCION_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtDIRECCION_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDIRECCION_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDIRECCION_DIVISION.EsRequerido = True
        Me.txtDIRECCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIRECCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDIRECCION_DIVISION.LabelConsulta = Nothing
        Me.txtDIRECCION_DIVISION.Location = New System.Drawing.Point(146, 86)
        Me.txtDIRECCION_DIVISION.MaxLength = 40
        Me.txtDIRECCION_DIVISION.Name = "txtDIRECCION_DIVISION"
        Me.txtDIRECCION_DIVISION.NombreDeConsulta = Nothing
        Me.txtDIRECCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDIRECCION_DIVISION.Size = New System.Drawing.Size(347, 20)
        Me.txtDIRECCION_DIVISION.TabIndex = 3
        '
        'txtTELEFONO_DIVISION
        '
        Me.txtTELEFONO_DIVISION.AcceptsReturn = True
        Me.txtTELEFONO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtTELEFONO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTELEFONO_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTELEFONO_DIVISION.EsRequerido = True
        Me.txtTELEFONO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTELEFONO_DIVISION.LabelConsulta = Nothing
        Me.txtTELEFONO_DIVISION.Location = New System.Drawing.Point(146, 110)
        Me.txtTELEFONO_DIVISION.MaxLength = 20
        Me.txtTELEFONO_DIVISION.Name = "txtTELEFONO_DIVISION"
        Me.txtTELEFONO_DIVISION.NombreDeConsulta = Nothing
        Me.txtTELEFONO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTELEFONO_DIVISION.Size = New System.Drawing.Size(174, 20)
        Me.txtTELEFONO_DIVISION.TabIndex = 4
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
        Me.txtTIPO_CATALOGO.Location = New System.Drawing.Point(146, 134)
        Me.txtTIPO_CATALOGO.MaxLength = 3
        Me.txtTIPO_CATALOGO.Name = "txtTIPO_CATALOGO"
        Me.txtTIPO_CATALOGO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCatalogosContables_CACOEC01
        Me.txtTIPO_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_CATALOGO.Size = New System.Drawing.Size(52, 20)
        Me.txtTIPO_CATALOGO.TabIndex = 5
        '
        'lblNOMBRE_CATALOGO
        '
        Me.lblNOMBRE_CATALOGO.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_CATALOGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_CATALOGO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_CATALOGO.Location = New System.Drawing.Point(204, 134)
        Me.lblNOMBRE_CATALOGO.Name = "lblNOMBRE_CATALOGO"
        Me.lblNOMBRE_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_CATALOGO.Size = New System.Drawing.Size(510, 21)
        Me.lblNOMBRE_CATALOGO.TabIndex = 48
        Me.lblNOMBRE_CATALOGO.Text = "Descripción del catálogo"
        Me.lblNOMBRE_CATALOGO.UseMnemonic = False
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(12, 16)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 49
        Me.lblTitCODIGO_DIVISION.Text = "Código departamento"
        '
        'lblTitDESCRIPCION_DIVISION
        '
        Me.lblTitDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_DIVISION.Location = New System.Drawing.Point(12, 40)
        Me.lblTitDESCRIPCION_DIVISION.Name = "lblTitDESCRIPCION_DIVISION"
        Me.lblTitDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_DIVISION.Size = New System.Drawing.Size(128, 14)
        Me.lblTitDESCRIPCION_DIVISION.TabIndex = 50
        Me.lblTitDESCRIPCION_DIVISION.Text = "Descripción"
        '
        'lblTitRESPONSABLE_DIVISION
        '
        Me.lblTitRESPONSABLE_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitRESPONSABLE_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitRESPONSABLE_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitRESPONSABLE_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitRESPONSABLE_DIVISION.Location = New System.Drawing.Point(12, 64)
        Me.lblTitRESPONSABLE_DIVISION.Name = "lblTitRESPONSABLE_DIVISION"
        Me.lblTitRESPONSABLE_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitRESPONSABLE_DIVISION.Size = New System.Drawing.Size(128, 14)
        Me.lblTitRESPONSABLE_DIVISION.TabIndex = 51
        Me.lblTitRESPONSABLE_DIVISION.Text = "Responsable"
        '
        'lblTitDIRECCION_DIVISION
        '
        Me.lblTitDIRECCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDIRECCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDIRECCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDIRECCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDIRECCION_DIVISION.Location = New System.Drawing.Point(12, 88)
        Me.lblTitDIRECCION_DIVISION.Name = "lblTitDIRECCION_DIVISION"
        Me.lblTitDIRECCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDIRECCION_DIVISION.Size = New System.Drawing.Size(128, 14)
        Me.lblTitDIRECCION_DIVISION.TabIndex = 52
        Me.lblTitDIRECCION_DIVISION.Text = "Dirección"
        '
        'lblTitTELEFONO_DIVISION
        '
        Me.lblTitTELEFONO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTELEFONO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTELEFONO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTELEFONO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTELEFONO_DIVISION.Location = New System.Drawing.Point(12, 112)
        Me.lblTitTELEFONO_DIVISION.Name = "lblTitTELEFONO_DIVISION"
        Me.lblTitTELEFONO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTELEFONO_DIVISION.Size = New System.Drawing.Size(128, 14)
        Me.lblTitTELEFONO_DIVISION.TabIndex = 53
        Me.lblTitTELEFONO_DIVISION.Text = "Teléfono"
        '
        'lblTitTIPO_CATALOGO
        '
        Me.lblTitTIPO_CATALOGO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_CATALOGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_CATALOGO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_CATALOGO.Location = New System.Drawing.Point(12, 136)
        Me.lblTitTIPO_CATALOGO.Name = "lblTitTIPO_CATALOGO"
        Me.lblTitTIPO_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_CATALOGO.Size = New System.Drawing.Size(128, 14)
        Me.lblTitTIPO_CATALOGO.TabIndex = 54
        Me.lblTitTIPO_CATALOGO.Text = "[Catálogo]"
        '
        'txtCODIGO_DIVISION
        '
        Me.txtCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DIVISION.EsRequerido = False
        Me.txtCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DIVISION.LabelConsulta = Nothing
        Me.txtCODIGO_DIVISION.Location = New System.Drawing.Point(146, 14)
        Me.txtCODIGO_DIVISION.MaxLength = 10
        Me.txtCODIGO_DIVISION.Name = "txtCODIGO_DIVISION"
        Me.txtCODIGO_DIVISION.NombreDeConsulta = Nothing
        Me.txtCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DIVISION.Size = New System.Drawing.Size(90, 20)
        Me.txtCODIGO_DIVISION.TabIndex = 0
        '
        'DIVISM01
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 507)
        Me.Controls.Add(Me.txtCODIGO_DIVISION)
        Me.Controls.Add(Me.txtDESCRIPCION_DIVISION)
        Me.Controls.Add(Me.txtRESPONSABLE_DIVISION)
        Me.Controls.Add(Me.txtDIRECCION_DIVISION)
        Me.Controls.Add(Me.txtTELEFONO_DIVISION)
        Me.Controls.Add(Me.frmGASTOS_PATRONALES)
        Me.Controls.Add(Me.frmPRESTACION)
        Me.Controls.Add(Me.frmSUELDOS)
        Me.Controls.Add(Me.frmGASTOS)
        Me.Controls.Add(Me.txtTIPO_CATALOGO)
        Me.Controls.Add(Me.lblNOMBRE_CATALOGO)
        Me.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.Controls.Add(Me.lblTitDESCRIPCION_DIVISION)
        Me.Controls.Add(Me.lblTitRESPONSABLE_DIVISION)
        Me.Controls.Add(Me.lblTitDIRECCION_DIVISION)
        Me.Controls.Add(Me.lblTitTELEFONO_DIVISION)
        Me.Controls.Add(Me.lblTitTIPO_CATALOGO)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "DIVISM01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de departamentos - DIVISM01"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmGASTOS_PATRONALES.ResumeLayout(False)
        Me.frmGASTOS_PATRONALES.PerformLayout()
        Me.frmPRESTACION.ResumeLayout(False)
        Me.frmPRESTACION.PerformLayout()
        Me.frmSUELDOS.ResumeLayout(False)
        Me.frmSUELDOS.PerformLayout()
        Me.frmGASTOS.ResumeLayout(False)
        Me.frmGASTOS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    ' System.Windows.Forms.TextBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents frmGASTOS_PATRONALES As System.Windows.Forms.GroupBox
    Public WithEvents txtCENTRO_GSTO_PATRONAL As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCUENTA_GSTO_PATRONAL As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDESC_CTA_GASTOS_PAT As System.Windows.Forms.Label
    Public WithEvents lblDESC_CEN_GASTOS_PAT As System.Windows.Forms.Label
    Public WithEvents lblTitCENTRO_GSTO_PATRONAL As System.Windows.Forms.Label
    Public WithEvents lblTitCUENTA_GSTO_PATRONAL As System.Windows.Forms.Label
    Public WithEvents frmPRESTACION As System.Windows.Forms.GroupBox
    Public WithEvents txtCUENTA_CONTABLE_PXP As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_CENTRO_PXP As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCUENTA_CONTABLE_PXP As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CENTRO_PXP As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_PXP As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_CUENTA_PXP As System.Windows.Forms.Label
    Public WithEvents frmSUELDOS As System.Windows.Forms.GroupBox
    Public WithEvents txtCODIGO_CENTRO_SXP As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCUENTA_CONTABLE_SXP As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDESCRIPCION_CUENTA_SXP As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_SXP As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CENTRO_SXP As System.Windows.Forms.Label
    Public WithEvents lblTitCUENTA_CONTABLE_SXP As System.Windows.Forms.Label
    Public WithEvents frmGASTOS As System.Windows.Forms.GroupBox
    Public WithEvents txtCUENTA_CONTABLE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_CENTRO As Citi.Synergia.UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents lblTitCUENTA_CONTABLE As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CENTRO As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_CUENTA As System.Windows.Forms.Label
    Public WithEvents txtDESCRIPCION_DIVISION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtRESPONSABLE_DIVISION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDIRECCION_DIVISION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTELEFONO_DIVISION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTIPO_CATALOGO As Citi.Synergia.UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents lblNOMBRE_CATALOGO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitRESPONSABLE_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitDIRECCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitTELEFONO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_CATALOGO As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_DIVISION As Citi.Synergia.UIGenerico.SynTextBox  ' System.Windows.Forms.TextBox
End Class
