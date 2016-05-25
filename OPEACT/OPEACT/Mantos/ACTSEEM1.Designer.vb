<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEEM1
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento

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
        Me.Folder = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtNUMERO_POLIZA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCOMPANIA_SEGUROS = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMONTO_PRIMA = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTOTAL_SEGURO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.mskFechaI = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.mskFechaF = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblnombremoneda = New System.Windows.Forms.Label()
        Me.txtFAX_COMPANIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTELEFONO_COMPANIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCONTACTO_COMPANIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNO_ENDOSO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitTOTAL_SEGURO = New System.Windows.Forms.Label()
        Me.lblTitFAX_COMPANIA = New System.Windows.Forms.Label()
        Me.lblTitFECHA_F_VIGENCIA = New System.Windows.Forms.Label()
        Me.lblTitFECHA_I_VIGENCIA = New System.Windows.Forms.Label()
        Me.lblTitMONTO_PRIMA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitTELEFONO_COMPANIA = New System.Windows.Forms.Label()
        Me.lblTitCONTACTO_COMPANIA = New System.Windows.Forms.Label()
        Me.lblTitNO_ENDOSO = New System.Windows.Forms.Label()
        Me.lblTitCOMPANIA_SEGUROS = New System.Windows.Forms.Label()
        Me.lblTitNUMERO_POLIZA = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtFAX_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTELEFONO_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCONTACTO_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNOMBRE_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitFAX_CORREDOR = New System.Windows.Forms.Label()
        Me.lblTitNOMBRE_CORREDOR = New System.Windows.Forms.Label()
        Me.lblTitCONTACTO_CORREDOR = New System.Windows.Forms.Label()
        Me.lblTitTELEFONO_CORREDOR = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Folder.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Folder
        '
        Me.Folder.Controls.Add(Me.TabPage1)
        Me.Folder.Controls.Add(Me.TabPage2)
        Me.Folder.Location = New System.Drawing.Point(12, 12)
        Me.Folder.Name = "Folder"
        Me.Folder.SelectedIndex = 0
        Me.Folder.Size = New System.Drawing.Size(624, 267)
        Me.Folder.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.txtNUMERO_POLIZA)
        Me.TabPage1.Controls.Add(Me.txtCOMPANIA_SEGUROS)
        Me.TabPage1.Controls.Add(Me.txtCODIGO_DE_MONEDA)
        Me.TabPage1.Controls.Add(Me.txtMONTO_PRIMA)
        Me.TabPage1.Controls.Add(Me.txtTOTAL_SEGURO)
        Me.TabPage1.Controls.Add(Me.mskFechaI)
        Me.TabPage1.Controls.Add(Me.mskFechaF)
        Me.TabPage1.Controls.Add(Me.lblnombremoneda)
        Me.TabPage1.Controls.Add(Me.txtFAX_COMPANIA)
        Me.TabPage1.Controls.Add(Me.txtTELEFONO_COMPANIA)
        Me.TabPage1.Controls.Add(Me.txtCONTACTO_COMPANIA)
        Me.TabPage1.Controls.Add(Me.txtNO_ENDOSO)
        Me.TabPage1.Controls.Add(Me.lblTitTOTAL_SEGURO)
        Me.TabPage1.Controls.Add(Me.lblTitFAX_COMPANIA)
        Me.TabPage1.Controls.Add(Me.lblTitFECHA_F_VIGENCIA)
        Me.TabPage1.Controls.Add(Me.lblTitFECHA_I_VIGENCIA)
        Me.TabPage1.Controls.Add(Me.lblTitMONTO_PRIMA)
        Me.TabPage1.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.TabPage1.Controls.Add(Me.lblTitTELEFONO_COMPANIA)
        Me.TabPage1.Controls.Add(Me.lblTitCONTACTO_COMPANIA)
        Me.TabPage1.Controls.Add(Me.lblTitNO_ENDOSO)
        Me.TabPage1.Controls.Add(Me.lblTitCOMPANIA_SEGUROS)
        Me.TabPage1.Controls.Add(Me.lblTitNUMERO_POLIZA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(616, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos de la póliza"
        '
        'txtNUMERO_POLIZA
        '
        Me.txtNUMERO_POLIZA.AcceptsReturn = True
        Me.txtNUMERO_POLIZA.BackColor = System.Drawing.Color.White
        Me.txtNUMERO_POLIZA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_POLIZA.EsRequerido = True
        Me.txtNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_POLIZA.LabelConsulta = Nothing
        Me.txtNUMERO_POLIZA.Location = New System.Drawing.Point(169, 6)
        Me.txtNUMERO_POLIZA.MaxLength = 20
        Me.txtNUMERO_POLIZA.Multiline = True
        Me.txtNUMERO_POLIZA.Name = "txtNUMERO_POLIZA"
        Me.txtNUMERO_POLIZA.NombreDeConsulta = Nothing
        Me.txtNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_POLIZA.Size = New System.Drawing.Size(143, 20)
        Me.txtNUMERO_POLIZA.TabIndex = 0
        Me.txtNUMERO_POLIZA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCOMPANIA_SEGUROS
        '
        Me.txtCOMPANIA_SEGUROS.AcceptsReturn = True
        Me.txtCOMPANIA_SEGUROS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOMPANIA_SEGUROS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOMPANIA_SEGUROS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOMPANIA_SEGUROS.EsRequerido = True
        Me.txtCOMPANIA_SEGUROS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOMPANIA_SEGUROS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOMPANIA_SEGUROS.LabelConsulta = Nothing
        Me.txtCOMPANIA_SEGUROS.Location = New System.Drawing.Point(169, 58)
        Me.txtCOMPANIA_SEGUROS.MaxLength = 40
        Me.txtCOMPANIA_SEGUROS.Name = "txtCOMPANIA_SEGUROS"
        Me.txtCOMPANIA_SEGUROS.NombreDeConsulta = Nothing
        Me.txtCOMPANIA_SEGUROS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOMPANIA_SEGUROS.Size = New System.Drawing.Size(430, 20)
        Me.txtCOMPANIA_SEGUROS.TabIndex = 2
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
        Me.txtCODIGO_DE_MONEDA.Location = New System.Drawing.Point(169, 136)
        Me.txtCODIGO_DE_MONEDA.MaxLength = 5
        Me.txtCODIGO_DE_MONEDA.Name = "txtCODIGO_DE_MONEDA"
        Me.txtCODIGO_DE_MONEDA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMonedas_MONEDC01
        Me.txtCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_MONEDA.Size = New System.Drawing.Size(45, 20)
        Me.txtCODIGO_DE_MONEDA.TabIndex = 6
        Me.txtCODIGO_DE_MONEDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMONTO_PRIMA
        '
        Me.txtMONTO_PRIMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMONTO_PRIMA.EsRequerido = True
        Me.txtMONTO_PRIMA.LabelConsulta = Nothing
        Me.txtMONTO_PRIMA.Location = New System.Drawing.Point(169, 162)
        Me.txtMONTO_PRIMA.Name = "txtMONTO_PRIMA"
        Me.txtMONTO_PRIMA.NombreDeConsulta = Nothing
        Me.txtMONTO_PRIMA.NumeroDecimales = 2
        Me.txtMONTO_PRIMA.Size = New System.Drawing.Size(143, 20)
        Me.txtMONTO_PRIMA.TabIndex = 7
        Me.txtMONTO_PRIMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTOTAL_SEGURO
        '
        Me.txtTOTAL_SEGURO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTOTAL_SEGURO.EsRequerido = True
        Me.txtTOTAL_SEGURO.LabelConsulta = Nothing
        Me.txtTOTAL_SEGURO.Location = New System.Drawing.Point(456, 162)
        Me.txtTOTAL_SEGURO.Name = "txtTOTAL_SEGURO"
        Me.txtTOTAL_SEGURO.NombreDeConsulta = Nothing
        Me.txtTOTAL_SEGURO.NumeroDecimales = 2
        Me.txtTOTAL_SEGURO.Size = New System.Drawing.Size(143, 20)
        Me.txtTOTAL_SEGURO.TabIndex = 8
        Me.txtTOTAL_SEGURO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskFechaI
        '
        Me.mskFechaI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFechaI.EsRequerido = True
        Me.mskFechaI.Location = New System.Drawing.Point(169, 188)
        Me.mskFechaI.Mask = "00/00/0000"
        Me.mskFechaI.Name = "mskFechaI"
        Me.mskFechaI.Size = New System.Drawing.Size(143, 20)
        Me.mskFechaI.TabIndex = 9
        Me.mskFechaI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFechaI.ValidatingType = GetType(Date)
        '
        'mskFechaF
        '
        Me.mskFechaF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFechaF.EsRequerido = True
        Me.mskFechaF.Location = New System.Drawing.Point(169, 214)
        Me.mskFechaF.Mask = "00/00/0000"
        Me.mskFechaF.Name = "mskFechaF"
        Me.mskFechaF.Size = New System.Drawing.Size(143, 20)
        Me.mskFechaF.TabIndex = 10
        Me.mskFechaF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFechaF.ValidatingType = GetType(Date)
        '
        'lblnombremoneda
        '
        Me.lblnombremoneda.BackColor = System.Drawing.Color.Transparent
        Me.lblnombremoneda.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombremoneda.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombremoneda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombremoneda.Location = New System.Drawing.Point(232, 138)
        Me.lblnombremoneda.Name = "lblnombremoneda"
        Me.lblnombremoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombremoneda.Size = New System.Drawing.Size(367, 20)
        Me.lblnombremoneda.TabIndex = 53
        Me.lblnombremoneda.UseMnemonic = False
        '
        'txtFAX_COMPANIA
        '
        Me.txtFAX_COMPANIA.AcceptsReturn = True
        Me.txtFAX_COMPANIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtFAX_COMPANIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFAX_COMPANIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFAX_COMPANIA.EsRequerido = False
        Me.txtFAX_COMPANIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFAX_COMPANIA.LabelConsulta = Nothing
        Me.txtFAX_COMPANIA.Location = New System.Drawing.Point(456, 110)
        Me.txtFAX_COMPANIA.MaxLength = 15
        Me.txtFAX_COMPANIA.Name = "txtFAX_COMPANIA"
        Me.txtFAX_COMPANIA.NombreDeConsulta = Nothing
        Me.txtFAX_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFAX_COMPANIA.Size = New System.Drawing.Size(143, 20)
        Me.txtFAX_COMPANIA.TabIndex = 5
        '
        'txtTELEFONO_COMPANIA
        '
        Me.txtTELEFONO_COMPANIA.AcceptsReturn = True
        Me.txtTELEFONO_COMPANIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtTELEFONO_COMPANIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTELEFONO_COMPANIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTELEFONO_COMPANIA.EsRequerido = False
        Me.txtTELEFONO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTELEFONO_COMPANIA.LabelConsulta = Nothing
        Me.txtTELEFONO_COMPANIA.Location = New System.Drawing.Point(169, 110)
        Me.txtTELEFONO_COMPANIA.MaxLength = 15
        Me.txtTELEFONO_COMPANIA.Name = "txtTELEFONO_COMPANIA"
        Me.txtTELEFONO_COMPANIA.NombreDeConsulta = Nothing
        Me.txtTELEFONO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTELEFONO_COMPANIA.Size = New System.Drawing.Size(143, 20)
        Me.txtTELEFONO_COMPANIA.TabIndex = 4
        '
        'txtCONTACTO_COMPANIA
        '
        Me.txtCONTACTO_COMPANIA.AcceptsReturn = True
        Me.txtCONTACTO_COMPANIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCONTACTO_COMPANIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCONTACTO_COMPANIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCONTACTO_COMPANIA.EsRequerido = False
        Me.txtCONTACTO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTACTO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCONTACTO_COMPANIA.LabelConsulta = Nothing
        Me.txtCONTACTO_COMPANIA.Location = New System.Drawing.Point(169, 84)
        Me.txtCONTACTO_COMPANIA.MaxLength = 40
        Me.txtCONTACTO_COMPANIA.Name = "txtCONTACTO_COMPANIA"
        Me.txtCONTACTO_COMPANIA.NombreDeConsulta = Nothing
        Me.txtCONTACTO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCONTACTO_COMPANIA.Size = New System.Drawing.Size(430, 20)
        Me.txtCONTACTO_COMPANIA.TabIndex = 3
        '
        'txtNO_ENDOSO
        '
        Me.txtNO_ENDOSO.AcceptsReturn = True
        Me.txtNO_ENDOSO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNO_ENDOSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNO_ENDOSO.EsRequerido = False
        Me.txtNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNO_ENDOSO.LabelConsulta = Nothing
        Me.txtNO_ENDOSO.Location = New System.Drawing.Point(169, 32)
        Me.txtNO_ENDOSO.MaxLength = 15
        Me.txtNO_ENDOSO.Name = "txtNO_ENDOSO"
        Me.txtNO_ENDOSO.NombreDeConsulta = Nothing
        Me.txtNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNO_ENDOSO.Size = New System.Drawing.Size(143, 20)
        Me.txtNO_ENDOSO.TabIndex = 1
        Me.txtNO_ENDOSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitTOTAL_SEGURO
        '
        Me.lblTitTOTAL_SEGURO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTOTAL_SEGURO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTOTAL_SEGURO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTOTAL_SEGURO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTOTAL_SEGURO.Location = New System.Drawing.Point(338, 164)
        Me.lblTitTOTAL_SEGURO.Name = "lblTitTOTAL_SEGURO"
        Me.lblTitTOTAL_SEGURO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTOTAL_SEGURO.Size = New System.Drawing.Size(112, 14)
        Me.lblTitTOTAL_SEGURO.TabIndex = 52
        Me.lblTitTOTAL_SEGURO.Text = "Total del seguro"
        '
        'lblTitFAX_COMPANIA
        '
        Me.lblTitFAX_COMPANIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFAX_COMPANIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFAX_COMPANIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFAX_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFAX_COMPANIA.Location = New System.Drawing.Point(338, 112)
        Me.lblTitFAX_COMPANIA.Name = "lblTitFAX_COMPANIA"
        Me.lblTitFAX_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFAX_COMPANIA.Size = New System.Drawing.Size(112, 14)
        Me.lblTitFAX_COMPANIA.TabIndex = 51
        Me.lblTitFAX_COMPANIA.Text = "Fax aseguradora"
        '
        'lblTitFECHA_F_VIGENCIA
        '
        Me.lblTitFECHA_F_VIGENCIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_F_VIGENCIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_F_VIGENCIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_F_VIGENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_F_VIGENCIA.Location = New System.Drawing.Point(6, 216)
        Me.lblTitFECHA_F_VIGENCIA.Name = "lblTitFECHA_F_VIGENCIA"
        Me.lblTitFECHA_F_VIGENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_F_VIGENCIA.Size = New System.Drawing.Size(157, 14)
        Me.lblTitFECHA_F_VIGENCIA.TabIndex = 46
        Me.lblTitFECHA_F_VIGENCIA.Text = "Fecha final de vigencia"
        '
        'lblTitFECHA_I_VIGENCIA
        '
        Me.lblTitFECHA_I_VIGENCIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_I_VIGENCIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_I_VIGENCIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_I_VIGENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_I_VIGENCIA.Location = New System.Drawing.Point(6, 190)
        Me.lblTitFECHA_I_VIGENCIA.Name = "lblTitFECHA_I_VIGENCIA"
        Me.lblTitFECHA_I_VIGENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_I_VIGENCIA.Size = New System.Drawing.Size(157, 14)
        Me.lblTitFECHA_I_VIGENCIA.TabIndex = 45
        Me.lblTitFECHA_I_VIGENCIA.Text = "Fecha inicial de vigencia"
        '
        'lblTitMONTO_PRIMA
        '
        Me.lblTitMONTO_PRIMA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_PRIMA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_PRIMA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_PRIMA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_PRIMA.Location = New System.Drawing.Point(6, 164)
        Me.lblTitMONTO_PRIMA.Name = "lblTitMONTO_PRIMA"
        Me.lblTitMONTO_PRIMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_PRIMA.Size = New System.Drawing.Size(157, 14)
        Me.lblTitMONTO_PRIMA.TabIndex = 44
        Me.lblTitMONTO_PRIMA.Text = "Monto de la prima"
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(6, 138)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(157, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 43
        Me.lblTitCODIGO_DE_MONEDA.Text = "Código de moneda"
        '
        'lblTitTELEFONO_COMPANIA
        '
        Me.lblTitTELEFONO_COMPANIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTELEFONO_COMPANIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTELEFONO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTELEFONO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTELEFONO_COMPANIA.Location = New System.Drawing.Point(6, 112)
        Me.lblTitTELEFONO_COMPANIA.Name = "lblTitTELEFONO_COMPANIA"
        Me.lblTitTELEFONO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTELEFONO_COMPANIA.Size = New System.Drawing.Size(157, 14)
        Me.lblTitTELEFONO_COMPANIA.TabIndex = 42
        Me.lblTitTELEFONO_COMPANIA.Text = "Teléfono aseguradora"
        '
        'lblTitCONTACTO_COMPANIA
        '
        Me.lblTitCONTACTO_COMPANIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCONTACTO_COMPANIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCONTACTO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCONTACTO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCONTACTO_COMPANIA.Location = New System.Drawing.Point(6, 86)
        Me.lblTitCONTACTO_COMPANIA.Name = "lblTitCONTACTO_COMPANIA"
        Me.lblTitCONTACTO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCONTACTO_COMPANIA.Size = New System.Drawing.Size(157, 14)
        Me.lblTitCONTACTO_COMPANIA.TabIndex = 41
        Me.lblTitCONTACTO_COMPANIA.Text = "Nombre del contacto"
        '
        'lblTitNO_ENDOSO
        '
        Me.lblTitNO_ENDOSO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_ENDOSO.Location = New System.Drawing.Point(6, 34)
        Me.lblTitNO_ENDOSO.Name = "lblTitNO_ENDOSO"
        Me.lblTitNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_ENDOSO.Size = New System.Drawing.Size(157, 14)
        Me.lblTitNO_ENDOSO.TabIndex = 40
        Me.lblTitNO_ENDOSO.Text = "Número de endoso"
        '
        'lblTitCOMPANIA_SEGUROS
        '
        Me.lblTitCOMPANIA_SEGUROS.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOMPANIA_SEGUROS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOMPANIA_SEGUROS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOMPANIA_SEGUROS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOMPANIA_SEGUROS.Location = New System.Drawing.Point(6, 60)
        Me.lblTitCOMPANIA_SEGUROS.Name = "lblTitCOMPANIA_SEGUROS"
        Me.lblTitCOMPANIA_SEGUROS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOMPANIA_SEGUROS.Size = New System.Drawing.Size(157, 14)
        Me.lblTitCOMPANIA_SEGUROS.TabIndex = 39
        Me.lblTitCOMPANIA_SEGUROS.Text = "Compañía de seguros"
        '
        'lblTitNUMERO_POLIZA
        '
        Me.lblTitNUMERO_POLIZA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_POLIZA.Location = New System.Drawing.Point(6, 8)
        Me.lblTitNUMERO_POLIZA.Name = "lblTitNUMERO_POLIZA"
        Me.lblTitNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_POLIZA.Size = New System.Drawing.Size(157, 14)
        Me.lblTitNUMERO_POLIZA.TabIndex = 38
        Me.lblTitNUMERO_POLIZA.Text = "Número de póliza"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.txtFAX_CORREDOR)
        Me.TabPage2.Controls.Add(Me.txtTELEFONO_CORREDOR)
        Me.TabPage2.Controls.Add(Me.txtCONTACTO_CORREDOR)
        Me.TabPage2.Controls.Add(Me.txtNOMBRE_CORREDOR)
        Me.TabPage2.Controls.Add(Me.lblTitFAX_CORREDOR)
        Me.TabPage2.Controls.Add(Me.lblTitNOMBRE_CORREDOR)
        Me.TabPage2.Controls.Add(Me.lblTitCONTACTO_CORREDOR)
        Me.TabPage2.Controls.Add(Me.lblTitTELEFONO_CORREDOR)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(616, 241)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos del corredor"
        '
        'txtFAX_CORREDOR
        '
        Me.txtFAX_CORREDOR.AcceptsReturn = True
        Me.txtFAX_CORREDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtFAX_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFAX_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFAX_CORREDOR.EsRequerido = False
        Me.txtFAX_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFAX_CORREDOR.LabelConsulta = Nothing
        Me.txtFAX_CORREDOR.Location = New System.Drawing.Point(153, 84)
        Me.txtFAX_CORREDOR.MaxLength = 15
        Me.txtFAX_CORREDOR.Multiline = True
        Me.txtFAX_CORREDOR.Name = "txtFAX_CORREDOR"
        Me.txtFAX_CORREDOR.NombreDeConsulta = Nothing
        Me.txtFAX_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFAX_CORREDOR.Size = New System.Drawing.Size(158, 20)
        Me.txtFAX_CORREDOR.TabIndex = 3
        '
        'txtTELEFONO_CORREDOR
        '
        Me.txtTELEFONO_CORREDOR.AcceptsReturn = True
        Me.txtTELEFONO_CORREDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtTELEFONO_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTELEFONO_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTELEFONO_CORREDOR.EsRequerido = False
        Me.txtTELEFONO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTELEFONO_CORREDOR.LabelConsulta = Nothing
        Me.txtTELEFONO_CORREDOR.Location = New System.Drawing.Point(153, 58)
        Me.txtTELEFONO_CORREDOR.MaxLength = 15
        Me.txtTELEFONO_CORREDOR.Multiline = True
        Me.txtTELEFONO_CORREDOR.Name = "txtTELEFONO_CORREDOR"
        Me.txtTELEFONO_CORREDOR.NombreDeConsulta = Nothing
        Me.txtTELEFONO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTELEFONO_CORREDOR.Size = New System.Drawing.Size(158, 20)
        Me.txtTELEFONO_CORREDOR.TabIndex = 2
        '
        'txtCONTACTO_CORREDOR
        '
        Me.txtCONTACTO_CORREDOR.AcceptsReturn = True
        Me.txtCONTACTO_CORREDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtCONTACTO_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCONTACTO_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCONTACTO_CORREDOR.EsRequerido = False
        Me.txtCONTACTO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTACTO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCONTACTO_CORREDOR.LabelConsulta = Nothing
        Me.txtCONTACTO_CORREDOR.Location = New System.Drawing.Point(153, 32)
        Me.txtCONTACTO_CORREDOR.MaxLength = 40
        Me.txtCONTACTO_CORREDOR.Multiline = True
        Me.txtCONTACTO_CORREDOR.Name = "txtCONTACTO_CORREDOR"
        Me.txtCONTACTO_CORREDOR.NombreDeConsulta = Nothing
        Me.txtCONTACTO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCONTACTO_CORREDOR.Size = New System.Drawing.Size(449, 20)
        Me.txtCONTACTO_CORREDOR.TabIndex = 1
        '
        'txtNOMBRE_CORREDOR
        '
        Me.txtNOMBRE_CORREDOR.AcceptsReturn = True
        Me.txtNOMBRE_CORREDOR.BackColor = System.Drawing.Color.White
        Me.txtNOMBRE_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNOMBRE_CORREDOR.EsRequerido = False
        Me.txtNOMBRE_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNOMBRE_CORREDOR.LabelConsulta = Nothing
        Me.txtNOMBRE_CORREDOR.Location = New System.Drawing.Point(153, 6)
        Me.txtNOMBRE_CORREDOR.MaxLength = 40
        Me.txtNOMBRE_CORREDOR.Multiline = True
        Me.txtNOMBRE_CORREDOR.Name = "txtNOMBRE_CORREDOR"
        Me.txtNOMBRE_CORREDOR.NombreDeConsulta = Nothing
        Me.txtNOMBRE_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNOMBRE_CORREDOR.Size = New System.Drawing.Size(449, 20)
        Me.txtNOMBRE_CORREDOR.TabIndex = 0
        '
        'lblTitFAX_CORREDOR
        '
        Me.lblTitFAX_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFAX_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFAX_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFAX_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFAX_CORREDOR.Location = New System.Drawing.Point(6, 86)
        Me.lblTitFAX_CORREDOR.Name = "lblTitFAX_CORREDOR"
        Me.lblTitFAX_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFAX_CORREDOR.Size = New System.Drawing.Size(141, 14)
        Me.lblTitFAX_CORREDOR.TabIndex = 53
        Me.lblTitFAX_CORREDOR.Text = "Número fax"
        '
        'lblTitNOMBRE_CORREDOR
        '
        Me.lblTitNOMBRE_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNOMBRE_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNOMBRE_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNOMBRE_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNOMBRE_CORREDOR.Location = New System.Drawing.Point(6, 8)
        Me.lblTitNOMBRE_CORREDOR.Name = "lblTitNOMBRE_CORREDOR"
        Me.lblTitNOMBRE_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNOMBRE_CORREDOR.Size = New System.Drawing.Size(141, 14)
        Me.lblTitNOMBRE_CORREDOR.TabIndex = 50
        Me.lblTitNOMBRE_CORREDOR.Text = "Nombre"
        '
        'lblTitCONTACTO_CORREDOR
        '
        Me.lblTitCONTACTO_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCONTACTO_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCONTACTO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCONTACTO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCONTACTO_CORREDOR.Location = New System.Drawing.Point(6, 34)
        Me.lblTitCONTACTO_CORREDOR.Name = "lblTitCONTACTO_CORREDOR"
        Me.lblTitCONTACTO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCONTACTO_CORREDOR.Size = New System.Drawing.Size(141, 14)
        Me.lblTitCONTACTO_CORREDOR.TabIndex = 49
        Me.lblTitCONTACTO_CORREDOR.Text = "Contacto"
        '
        'lblTitTELEFONO_CORREDOR
        '
        Me.lblTitTELEFONO_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTELEFONO_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTELEFONO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTELEFONO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTELEFONO_CORREDOR.Location = New System.Drawing.Point(6, 60)
        Me.lblTitTELEFONO_CORREDOR.Name = "lblTitTELEFONO_CORREDOR"
        Me.lblTitTELEFONO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTELEFONO_CORREDOR.Size = New System.Drawing.Size(141, 14)
        Me.lblTitTELEFONO_CORREDOR.TabIndex = 47
        Me.lblTitTELEFONO_CORREDOR.Text = "Teléfono"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(549, 285)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(453, 285)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTSEEM1
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(648, 321)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Folder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTSEEM1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de endosos a polizas de seguros - ACTSEEM1"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Folder.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Folder As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents lblnombremoneda As System.Windows.Forms.Label
    Friend WithEvents txtTOTAL_SEGURO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Friend WithEvents txtMONTO_PRIMA As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtFAX_COMPANIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTELEFONO_COMPANIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCONTACTO_COMPANIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNO_ENDOSO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCOMPANIA_SEGUROS As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNUMERO_POLIZA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitTOTAL_SEGURO As System.Windows.Forms.Label
    Public WithEvents lblTitFAX_COMPANIA As System.Windows.Forms.Label
    Friend WithEvents mskFechaF As Citi.Synergia.UIGenerico.SynTextoFecha
    Friend WithEvents mskFechaI As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblTitFECHA_F_VIGENCIA As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_I_VIGENCIA As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_PRIMA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitTELEFONO_COMPANIA As System.Windows.Forms.Label
    Public WithEvents lblTitCONTACTO_COMPANIA As System.Windows.Forms.Label
    Public WithEvents lblTitNO_ENDOSO As System.Windows.Forms.Label
    Public WithEvents lblTitCOMPANIA_SEGUROS As System.Windows.Forms.Label
    Public WithEvents lblTitNUMERO_POLIZA As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents txtFAX_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTELEFONO_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCONTACTO_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNOMBRE_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitFAX_CORREDOR As System.Windows.Forms.Label
    Public WithEvents lblTitNOMBRE_CORREDOR As System.Windows.Forms.Label
    Public WithEvents lblTitCONTACTO_CORREDOR As System.Windows.Forms.Label
    Public WithEvents lblTitTELEFONO_CORREDOR As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
