<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTETAM0
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTETAM0))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdOrigen = New System.Windows.Forms.DataGridView()
        Me.ActivoFijoOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MejoraOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrasladoOrigen = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtTRASLADO_ID_ACT = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtFECHA_TRASLADO = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtRESPONSABLE_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNUEVO_RESPONSABLE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboESTADO_TRASLADO_ACT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNUEVO_NOMBRE_USUAL = New System.Windows.Forms.Label()
        Me.lblNOMBRE_USUAL = New System.Windows.Forms.Label()
        Me.lblTitESTADO_TRASLADO_ACT = New System.Windows.Forms.Label()
        Me.lblTitNUEVO_RESPONSABLE = New System.Windows.Forms.Label()
        Me.lblTitRESPONSABLE_ID = New System.Windows.Forms.Label()
        Me.lblTitFECHA_TRASLADO = New System.Windows.Forms.Label()
        Me.lblTitTRASLADO_ID_ACT = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.TRASLADO = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Check3D1 = New System.Windows.Forms.CheckBox()
        Me.CAMBIO = New System.Windows.Forms.RadioButton()
        Me.REEMPLAZO = New System.Windows.Forms.RadioButton()
        Me.frmTIPO = New System.Windows.Forms.GroupBox()
        Me.frmDESTINO = New System.Windows.Forms.GroupBox()
        Me.grdDestino = New System.Windows.Forms.DataGridView()
        Me.ActivoFijoDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MejoraDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.frmTIPO.SuspendLayout()
        Me.frmDESTINO.SuspendLayout()
        CType(Me.grdDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdOrigen
        '
        Me.grdOrigen.AllowUserToAddRows = False
        Me.grdOrigen.AllowUserToDeleteRows = False
        Me.grdOrigen.AllowUserToResizeRows = False
        Me.grdOrigen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOrigen.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdOrigen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrigen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActivoFijoOrigen, Me.MejoraOrigen, Me.DescripcionOrigen, Me.TrasladoOrigen})
        Me.grdOrigen.Location = New System.Drawing.Point(6, 19)
        Me.grdOrigen.Name = "grdOrigen"
        Me.grdOrigen.RowHeadersVisible = False
        Me.grdOrigen.Size = New System.Drawing.Size(409, 202)
        Me.grdOrigen.TabIndex = 9
        '
        'ActivoFijoOrigen
        '
        Me.ActivoFijoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ActivoFijoOrigen.DefaultCellStyle = DataGridViewCellStyle2
        Me.ActivoFijoOrigen.HeaderText = "Activo Fijo"
        Me.ActivoFijoOrigen.Name = "ActivoFijoOrigen"
        Me.ActivoFijoOrigen.ReadOnly = True
        '
        'MejoraOrigen
        '
        Me.MejoraOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.MejoraOrigen.DefaultCellStyle = DataGridViewCellStyle3
        Me.MejoraOrigen.HeaderText = "Mejora"
        Me.MejoraOrigen.Name = "MejoraOrigen"
        Me.MejoraOrigen.ReadOnly = True
        Me.MejoraOrigen.Width = 75
        '
        'DescripcionOrigen
        '
        Me.DescripcionOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DescripcionOrigen.DefaultCellStyle = DataGridViewCellStyle4
        Me.DescripcionOrigen.HeaderText = "Descripción"
        Me.DescripcionOrigen.Name = "DescripcionOrigen"
        Me.DescripcionOrigen.ReadOnly = True
        Me.DescripcionOrigen.Width = 200
        '
        'TrasladoOrigen
        '
        Me.TrasladoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TrasladoOrigen.HeaderText = "Traslado"
        Me.TrasladoOrigen.MinimumWidth = 75
        Me.TrasladoOrigen.Name = "TrasladoOrigen"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtTRASLADO_ID_ACT)
        Me.Frame1.Controls.Add(Me.txtFECHA_TRASLADO)
        Me.Frame1.Controls.Add(Me.txtRESPONSABLE_ID)
        Me.Frame1.Controls.Add(Me.txtNUEVO_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.cboESTADO_TRASLADO_ACT)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lblNUEVO_NOMBRE_USUAL)
        Me.Frame1.Controls.Add(Me.lblNOMBRE_USUAL)
        Me.Frame1.Controls.Add(Me.lblTitESTADO_TRASLADO_ACT)
        Me.Frame1.Controls.Add(Me.lblTitNUEVO_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.lblTitRESPONSABLE_ID)
        Me.Frame1.Controls.Add(Me.lblTitFECHA_TRASLADO)
        Me.Frame1.Controls.Add(Me.lblTitTRASLADO_ID_ACT)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(848, 156)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtTRASLADO_ID_ACT
        '
        Me.txtTRASLADO_ID_ACT.AcceptsReturn = True
        Me.txtTRASLADO_ID_ACT.BackColor = System.Drawing.SystemColors.Window
        Me.txtTRASLADO_ID_ACT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTRASLADO_ID_ACT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTRASLADO_ID_ACT.EsRequerido = True
        Me.txtTRASLADO_ID_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTRASLADO_ID_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTRASLADO_ID_ACT.LabelConsulta = Nothing
        Me.txtTRASLADO_ID_ACT.Location = New System.Drawing.Point(160, 19)
        Me.txtTRASLADO_ID_ACT.MaxLength = 11
        Me.txtTRASLADO_ID_ACT.Multiline = True
        Me.txtTRASLADO_ID_ACT.Name = "txtTRASLADO_ID_ACT"
        Me.txtTRASLADO_ID_ACT.NombreDeConsulta = Nothing
        Me.txtTRASLADO_ID_ACT.NumeroDecimales = 0
        Me.txtTRASLADO_ID_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTRASLADO_ID_ACT.Size = New System.Drawing.Size(79, 20)
        Me.txtTRASLADO_ID_ACT.TabIndex = 1
        Me.txtTRASLADO_ID_ACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFECHA_TRASLADO
        '
        Me.txtFECHA_TRASLADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFECHA_TRASLADO.EsRequerido = True
        Me.txtFECHA_TRASLADO.Location = New System.Drawing.Point(160, 45)
        Me.txtFECHA_TRASLADO.Mask = "00/00/0000"
        Me.txtFECHA_TRASLADO.Name = "txtFECHA_TRASLADO"
        Me.txtFECHA_TRASLADO.Size = New System.Drawing.Size(160, 20)
        Me.txtFECHA_TRASLADO.TabIndex = 2
        Me.txtFECHA_TRASLADO.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFECHA_TRASLADO.ValidatingType = GetType(Date)
        '
        'txtRESPONSABLE_ID
        '
        Me.txtRESPONSABLE_ID.AcceptsReturn = True
        Me.txtRESPONSABLE_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtRESPONSABLE_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRESPONSABLE_ID.EsRequerido = True
        Me.txtRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRESPONSABLE_ID.LabelConsulta = Nothing
        Me.txtRESPONSABLE_ID.Location = New System.Drawing.Point(160, 71)
        Me.txtRESPONSABLE_ID.MaxLength = 5
        Me.txtRESPONSABLE_ID.Name = "txtRESPONSABLE_ID"
        Me.txtRESPONSABLE_ID.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeResponsablesDeActivosFijos_ACTRAFL0
        Me.txtRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRESPONSABLE_ID.Size = New System.Drawing.Size(52, 20)
        Me.txtRESPONSABLE_ID.TabIndex = 3
        '
        'txtNUEVO_RESPONSABLE
        '
        Me.txtNUEVO_RESPONSABLE.AcceptsReturn = True
        Me.txtNUEVO_RESPONSABLE.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUEVO_RESPONSABLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUEVO_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUEVO_RESPONSABLE.EsRequerido = True
        Me.txtNUEVO_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUEVO_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUEVO_RESPONSABLE.LabelConsulta = Nothing
        Me.txtNUEVO_RESPONSABLE.Location = New System.Drawing.Point(160, 97)
        Me.txtNUEVO_RESPONSABLE.MaxLength = 5
        Me.txtNUEVO_RESPONSABLE.Name = "txtNUEVO_RESPONSABLE"
        Me.txtNUEVO_RESPONSABLE.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeResponsablesDeActivosFijos_ACTRAFL0
        Me.txtNUEVO_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUEVO_RESPONSABLE.Size = New System.Drawing.Size(52, 20)
        Me.txtNUEVO_RESPONSABLE.TabIndex = 4
        '
        'cboESTADO_TRASLADO_ACT
        '
        Me.cboESTADO_TRASLADO_ACT.BackColor = System.Drawing.SystemColors.Window
        Me.cboESTADO_TRASLADO_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboESTADO_TRASLADO_ACT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboESTADO_TRASLADO_ACT.Enabled = False
        Me.cboESTADO_TRASLADO_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboESTADO_TRASLADO_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboESTADO_TRASLADO_ACT.Location = New System.Drawing.Point(160, 123)
        Me.cboESTADO_TRASLADO_ACT.Name = "cboESTADO_TRASLADO_ACT"
        Me.cboESTADO_TRASLADO_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboESTADO_TRASLADO_ACT.Size = New System.Drawing.Size(251, 22)
        Me.cboESTADO_TRASLADO_ACT.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(339, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "(DD/MM/AAAA)"
        '
        'lblNUEVO_NOMBRE_USUAL
        '
        Me.lblNUEVO_NOMBRE_USUAL.BackColor = System.Drawing.Color.Transparent
        Me.lblNUEVO_NOMBRE_USUAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNUEVO_NOMBRE_USUAL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUEVO_NOMBRE_USUAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNUEVO_NOMBRE_USUAL.Location = New System.Drawing.Point(240, 99)
        Me.lblNUEVO_NOMBRE_USUAL.Name = "lblNUEVO_NOMBRE_USUAL"
        Me.lblNUEVO_NOMBRE_USUAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNUEVO_NOMBRE_USUAL.Size = New System.Drawing.Size(602, 20)
        Me.lblNUEVO_NOMBRE_USUAL.TabIndex = 13
        Me.lblNUEVO_NOMBRE_USUAL.UseMnemonic = False
        '
        'lblNOMBRE_USUAL
        '
        Me.lblNOMBRE_USUAL.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_USUAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_USUAL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_USUAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_USUAL.Location = New System.Drawing.Point(237, 73)
        Me.lblNOMBRE_USUAL.Name = "lblNOMBRE_USUAL"
        Me.lblNOMBRE_USUAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_USUAL.Size = New System.Drawing.Size(605, 20)
        Me.lblNOMBRE_USUAL.TabIndex = 14
        Me.lblNOMBRE_USUAL.UseMnemonic = False
        '
        'lblTitESTADO_TRASLADO_ACT
        '
        Me.lblTitESTADO_TRASLADO_ACT.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTADO_TRASLADO_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTADO_TRASLADO_ACT.Enabled = False
        Me.lblTitESTADO_TRASLADO_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTADO_TRASLADO_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTADO_TRASLADO_ACT.Location = New System.Drawing.Point(6, 126)
        Me.lblTitESTADO_TRASLADO_ACT.Name = "lblTitESTADO_TRASLADO_ACT"
        Me.lblTitESTADO_TRASLADO_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTADO_TRASLADO_ACT.Size = New System.Drawing.Size(148, 14)
        Me.lblTitESTADO_TRASLADO_ACT.TabIndex = 15
        Me.lblTitESTADO_TRASLADO_ACT.Text = "Estado traslado"
        '
        'lblTitNUEVO_RESPONSABLE
        '
        Me.lblTitNUEVO_RESPONSABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUEVO_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUEVO_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUEVO_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUEVO_RESPONSABLE.Location = New System.Drawing.Point(6, 99)
        Me.lblTitNUEVO_RESPONSABLE.Name = "lblTitNUEVO_RESPONSABLE"
        Me.lblTitNUEVO_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUEVO_RESPONSABLE.Size = New System.Drawing.Size(148, 14)
        Me.lblTitNUEVO_RESPONSABLE.TabIndex = 16
        Me.lblTitNUEVO_RESPONSABLE.Text = "Nuevo responsable"
        '
        'lblTitRESPONSABLE_ID
        '
        Me.lblTitRESPONSABLE_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitRESPONSABLE_ID.Location = New System.Drawing.Point(6, 73)
        Me.lblTitRESPONSABLE_ID.Name = "lblTitRESPONSABLE_ID"
        Me.lblTitRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitRESPONSABLE_ID.Size = New System.Drawing.Size(148, 14)
        Me.lblTitRESPONSABLE_ID.TabIndex = 17
        Me.lblTitRESPONSABLE_ID.Text = "Responsable del activo"
        '
        'lblTitFECHA_TRASLADO
        '
        Me.lblTitFECHA_TRASLADO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_TRASLADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_TRASLADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_TRASLADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_TRASLADO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitFECHA_TRASLADO.Name = "lblTitFECHA_TRASLADO"
        Me.lblTitFECHA_TRASLADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_TRASLADO.Size = New System.Drawing.Size(148, 14)
        Me.lblTitFECHA_TRASLADO.TabIndex = 20
        Me.lblTitFECHA_TRASLADO.Text = "Fecha traslado"
        '
        'lblTitTRASLADO_ID_ACT
        '
        Me.lblTitTRASLADO_ID_ACT.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTRASLADO_ID_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTRASLADO_ID_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTRASLADO_ID_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTRASLADO_ID_ACT.Location = New System.Drawing.Point(6, 21)
        Me.lblTitTRASLADO_ID_ACT.Name = "lblTitTRASLADO_ID_ACT"
        Me.lblTitTRASLADO_ID_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTRASLADO_ID_ACT.Size = New System.Drawing.Size(148, 14)
        Me.lblTitTRASLADO_ID_ACT.TabIndex = 19
        Me.lblTitTRASLADO_ID_ACT.Text = "Código de traslado"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(680, 494)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'TRASLADO
        '
        Me.TRASLADO.Appearance = System.Windows.Forms.Appearance.Button
        Me.TRASLADO.BackColor = System.Drawing.SystemColors.Control
        Me.TRASLADO.Checked = True
        Me.TRASLADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.TRASLADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRASLADO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TRASLADO.Image = CType(resources.GetObject("TRASLADO.Image"), System.Drawing.Image)
        Me.TRASLADO.Location = New System.Drawing.Point(6, 19)
        Me.TRASLADO.Name = "TRASLADO"
        Me.TRASLADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TRASLADO.Size = New System.Drawing.Size(71, 57)
        Me.TRASLADO.TabIndex = 1
        Me.TRASLADO.TabStop = True
        Me.TRASLADO.Text = "Traslado"
        Me.TRASLADO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TRASLADO.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.grdOrigen)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(12, 261)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(421, 227)
        Me.Frame2.TabIndex = 3
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Activos del responsable a trasladar:"
        '
        'Check3D1
        '
        Me.Check3D1.BackColor = System.Drawing.SystemColors.Control
        Me.Check3D1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check3D1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check3D1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Check3D1.Location = New System.Drawing.Point(237, 58)
        Me.Check3D1.Name = "Check3D1"
        Me.Check3D1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check3D1.Size = New System.Drawing.Size(174, 17)
        Me.Check3D1.TabIndex = 4
        Me.Check3D1.Text = "Marcar todos"
        Me.Check3D1.UseVisualStyleBackColor = False
        '
        'CAMBIO
        '
        Me.CAMBIO.Appearance = System.Windows.Forms.Appearance.Button
        Me.CAMBIO.BackColor = System.Drawing.SystemColors.Control
        Me.CAMBIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.CAMBIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAMBIO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CAMBIO.Image = CType(resources.GetObject("CAMBIO.Image"), System.Drawing.Image)
        Me.CAMBIO.Location = New System.Drawing.Point(83, 19)
        Me.CAMBIO.Name = "CAMBIO"
        Me.CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CAMBIO.Size = New System.Drawing.Size(71, 57)
        Me.CAMBIO.TabIndex = 2
        Me.CAMBIO.TabStop = True
        Me.CAMBIO.Text = "Cambio"
        Me.CAMBIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CAMBIO.UseVisualStyleBackColor = False
        '
        'REEMPLAZO
        '
        Me.REEMPLAZO.Appearance = System.Windows.Forms.Appearance.Button
        Me.REEMPLAZO.BackColor = System.Drawing.SystemColors.Control
        Me.REEMPLAZO.Cursor = System.Windows.Forms.Cursors.Default
        Me.REEMPLAZO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REEMPLAZO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.REEMPLAZO.Image = CType(resources.GetObject("REEMPLAZO.Image"), System.Drawing.Image)
        Me.REEMPLAZO.Location = New System.Drawing.Point(160, 19)
        Me.REEMPLAZO.Name = "REEMPLAZO"
        Me.REEMPLAZO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.REEMPLAZO.Size = New System.Drawing.Size(71, 57)
        Me.REEMPLAZO.TabIndex = 3
        Me.REEMPLAZO.TabStop = True
        Me.REEMPLAZO.Text = "Reemplazo"
        Me.REEMPLAZO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.REEMPLAZO.UseVisualStyleBackColor = False
        '
        'frmTIPO
        '
        Me.frmTIPO.BackColor = System.Drawing.SystemColors.Control
        Me.frmTIPO.Controls.Add(Me.Check3D1)
        Me.frmTIPO.Controls.Add(Me.TRASLADO)
        Me.frmTIPO.Controls.Add(Me.CAMBIO)
        Me.frmTIPO.Controls.Add(Me.REEMPLAZO)
        Me.frmTIPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmTIPO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmTIPO.Location = New System.Drawing.Point(12, 174)
        Me.frmTIPO.Name = "frmTIPO"
        Me.frmTIPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmTIPO.Size = New System.Drawing.Size(848, 81)
        Me.frmTIPO.TabIndex = 2
        Me.frmTIPO.TabStop = False
        Me.frmTIPO.Text = "Tipo de transferencia:"
        '
        'frmDESTINO
        '
        Me.frmDESTINO.BackColor = System.Drawing.SystemColors.Control
        Me.frmDESTINO.Controls.Add(Me.grdDestino)
        Me.frmDESTINO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmDESTINO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmDESTINO.Location = New System.Drawing.Point(439, 261)
        Me.frmDESTINO.Name = "frmDESTINO"
        Me.frmDESTINO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmDESTINO.Size = New System.Drawing.Size(421, 227)
        Me.frmDESTINO.TabIndex = 4
        Me.frmDESTINO.TabStop = False
        Me.frmDESTINO.Text = "Información DESTINO:"
        '
        'grdDestino
        '
        Me.grdDestino.AllowUserToAddRows = False
        Me.grdDestino.AllowUserToDeleteRows = False
        Me.grdDestino.AllowUserToResizeRows = False
        Me.grdDestino.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDestino.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDestino.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDestino.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActivoFijoDestino, Me.MejoraDestino, Me.DescripcionDestino})
        Me.grdDestino.Location = New System.Drawing.Point(6, 19)
        Me.grdDestino.Name = "grdDestino"
        Me.grdDestino.RowHeadersVisible = False
        Me.grdDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDestino.Size = New System.Drawing.Size(409, 202)
        Me.grdDestino.TabIndex = 10
        '
        'ActivoFijoDestino
        '
        Me.ActivoFijoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ActivoFijoDestino.DefaultCellStyle = DataGridViewCellStyle6
        Me.ActivoFijoDestino.HeaderText = "Activo Fijo"
        Me.ActivoFijoDestino.Name = "ActivoFijoDestino"
        Me.ActivoFijoDestino.ReadOnly = True
        Me.ActivoFijoDestino.Width = 120
        '
        'MejoraDestino
        '
        Me.MejoraDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.MejoraDestino.DefaultCellStyle = DataGridViewCellStyle7
        Me.MejoraDestino.HeaderText = "Mejora"
        Me.MejoraDestino.Name = "MejoraDestino"
        Me.MejoraDestino.ReadOnly = True
        Me.MejoraDestino.Width = 80
        '
        'DescripcionDestino
        '
        Me.DescripcionDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DescripcionDestino.DefaultCellStyle = DataGridViewCellStyle8
        Me.DescripcionDestino.HeaderText = "Descripción"
        Me.DescripcionDestino.MinimumWidth = 250
        Me.DescripcionDestino.Name = "DescripcionDestino"
        Me.DescripcionDestino.ReadOnly = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(773, 494)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'ACTETAM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(872, 531)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.frmTIPO)
        Me.Controls.Add(Me.frmDESTINO)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTETAM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de traslados - ACTETAM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.frmTIPO.ResumeLayout(False)
        Me.frmDESTINO.ResumeLayout(False)
        CType(Me.grdDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents grdOrigen As System.Windows.Forms.DataGridView
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtFECHA_TRASLADO As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents cboESTADO_TRASLADO_ACT As System.Windows.Forms.ComboBox
    Public WithEvents txtNUEVO_RESPONSABLE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtRESPONSABLE_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTRASLADO_ID_ACT As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblNUEVO_NOMBRE_USUAL As System.Windows.Forms.Label
    Public WithEvents lblNOMBRE_USUAL As System.Windows.Forms.Label
    Public WithEvents lblTitESTADO_TRASLADO_ACT As System.Windows.Forms.Label
    Public WithEvents lblTitNUEVO_RESPONSABLE As System.Windows.Forms.Label
    Public WithEvents lblTitRESPONSABLE_ID As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_TRASLADO As System.Windows.Forms.Label
    Public WithEvents lblTitTRASLADO_ID_ACT As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents TRASLADO As System.Windows.Forms.RadioButton
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Check3D1 As System.Windows.Forms.CheckBox
    Public WithEvents CAMBIO As System.Windows.Forms.RadioButton
    Public WithEvents REEMPLAZO As System.Windows.Forms.RadioButton
    Public WithEvents frmTIPO As System.Windows.Forms.GroupBox
    Public WithEvents frmDESTINO As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents grdDestino As System.Windows.Forms.DataGridView
    Friend WithEvents ActivoFijoOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MejoraOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrasladoOrigen As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ActivoFijoDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MejoraDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDestino As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
