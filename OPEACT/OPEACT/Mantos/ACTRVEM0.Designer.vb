<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTRVEM0
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
        Me.txtporcentaje = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCODIGO_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboTIPO_DE_REVALUACION = New System.Windows.Forms.ComboBox()
        Me.mskFECHA_DE_REVALUACION = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtCODIGO_REVALUACION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESC_REVALUACION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_TIPO_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitTIPO_DE_REVALUACION = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDESCRIP_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitDESC_REVALUACION = New System.Windows.Forms.Label()
        Me.lblTitFECHA_DE_REVALUACION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_REVALUACION = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtporcentaje
        '
        Me.txtporcentaje.AcceptsReturn = True
        Me.txtporcentaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtporcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtporcentaje.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtporcentaje.EsRequerido = False
        Me.txtporcentaje.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtporcentaje.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtporcentaje.LabelConsulta = Nothing
        Me.txtporcentaje.Location = New System.Drawing.Point(166, 170)
        Me.txtporcentaje.MaxLength = 8
        Me.txtporcentaje.Multiline = True
        Me.txtporcentaje.Name = "txtporcentaje"
        Me.txtporcentaje.NombreDeConsulta = Nothing
        Me.txtporcentaje.NumeroDecimales = 5
        Me.txtporcentaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtporcentaje.Size = New System.Drawing.Size(87, 20)
        Me.txtporcentaje.TabIndex = 25
        Me.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_DIVISION
        '
        Me.txtCODIGO_DIVISION.AcceptsReturn = True
        Me.txtCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DIVISION.EsRequerido = False
        Me.txtCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DIVISION.LabelConsulta = Nothing
        Me.txtCODIGO_DIVISION.Location = New System.Drawing.Point(166, 144)
        Me.txtCODIGO_DIVISION.MaxLength = 10
        Me.txtCODIGO_DIVISION.Name = "txtCODIGO_DIVISION"
        Me.txtCODIGO_DIVISION.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DIVISION.Size = New System.Drawing.Size(87, 20)
        Me.txtCODIGO_DIVISION.TabIndex = 24
        Me.txtCODIGO_DIVISION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCODIGO_DIVISION.Visible = False
        '
        'cboTIPO_DE_REVALUACION
        '
        Me.cboTIPO_DE_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboTIPO_DE_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTIPO_DE_REVALUACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTIPO_DE_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTIPO_DE_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTIPO_DE_REVALUACION.Location = New System.Drawing.Point(166, 90)
        Me.cboTIPO_DE_REVALUACION.Name = "cboTIPO_DE_REVALUACION"
        Me.cboTIPO_DE_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTIPO_DE_REVALUACION.Size = New System.Drawing.Size(251, 22)
        Me.cboTIPO_DE_REVALUACION.TabIndex = 22
        '
        'mskFECHA_DE_REVALUACION
        '
        Me.mskFECHA_DE_REVALUACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFECHA_DE_REVALUACION.EsRequerido = True
        Me.mskFECHA_DE_REVALUACION.Location = New System.Drawing.Point(166, 64)
        Me.mskFECHA_DE_REVALUACION.Mask = "00/00/0000"
        Me.mskFECHA_DE_REVALUACION.Name = "mskFECHA_DE_REVALUACION"
        Me.mskFECHA_DE_REVALUACION.Size = New System.Drawing.Size(251, 20)
        Me.mskFECHA_DE_REVALUACION.TabIndex = 21
        Me.mskFECHA_DE_REVALUACION.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFECHA_DE_REVALUACION.ValidatingType = GetType(Date)
        '
        'txtCODIGO_REVALUACION
        '
        Me.txtCODIGO_REVALUACION.AcceptsReturn = True
        Me.txtCODIGO_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_REVALUACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_REVALUACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_REVALUACION.EsRequerido = True
        Me.txtCODIGO_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_REVALUACION.LabelConsulta = Nothing
        Me.txtCODIGO_REVALUACION.Location = New System.Drawing.Point(166, 12)
        Me.txtCODIGO_REVALUACION.MaxLength = 3
        Me.txtCODIGO_REVALUACION.Multiline = True
        Me.txtCODIGO_REVALUACION.Name = "txtCODIGO_REVALUACION"
        Me.txtCODIGO_REVALUACION.NombreDeConsulta = Nothing
        Me.txtCODIGO_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_REVALUACION.Size = New System.Drawing.Size(91, 20)
        Me.txtCODIGO_REVALUACION.TabIndex = 19
        Me.txtCODIGO_REVALUACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDESC_REVALUACION
        '
        Me.txtDESC_REVALUACION.AcceptsReturn = True
        Me.txtDESC_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESC_REVALUACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESC_REVALUACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESC_REVALUACION.EsRequerido = True
        Me.txtDESC_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESC_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESC_REVALUACION.LabelConsulta = Nothing
        Me.txtDESC_REVALUACION.Location = New System.Drawing.Point(166, 38)
        Me.txtDESC_REVALUACION.MaxLength = 40
        Me.txtDESC_REVALUACION.Name = "txtDESC_REVALUACION"
        Me.txtDESC_REVALUACION.NombreDeConsulta = Nothing
        Me.txtDESC_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESC_REVALUACION.Size = New System.Drawing.Size(446, 20)
        Me.txtDESC_REVALUACION.TabIndex = 20
        '
        'txtCODIGO_TIPO_ACTIVO
        '
        Me.txtCODIGO_TIPO_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_TIPO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_TIPO_ACTIVO.EsRequerido = False
        Me.txtCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_TIPO_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(166, 118)
        Me.txtCODIGO_TIPO_ACTIVO.MaxLength = 7
        Me.txtCODIGO_TIPO_ACTIVO.Name = "txtCODIGO_TIPO_ACTIVO"
        Me.txtCODIGO_TIPO_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(87, 20)
        Me.txtCODIGO_TIPO_ACTIVO.TabIndex = 23
        Me.txtCODIGO_TIPO_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCODIGO_TIPO_ACTIVO.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(447, 204)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 26
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
        Me.cmdCancelar.Location = New System.Drawing.Point(540, 204)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 27
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblporcentaje
        '
        Me.lblporcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblporcentaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblporcentaje.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporcentaje.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblporcentaje.Location = New System.Drawing.Point(12, 172)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblporcentaje.Size = New System.Drawing.Size(148, 14)
        Me.lblporcentaje.TabIndex = 36
        Me.lblporcentaje.Text = "Porcentaje a aplicar"
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(12, 146)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(148, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 35
        Me.lblTitCODIGO_DIVISION.Text = "Código departamento"
        Me.lblTitCODIGO_DIVISION.Visible = False
        '
        'lblDESCRIPCION_DIVISION
        '
        Me.lblDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_DIVISION.Location = New System.Drawing.Point(280, 146)
        Me.lblDESCRIPCION_DIVISION.Name = "lblDESCRIPCION_DIVISION"
        Me.lblDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_DIVISION.Size = New System.Drawing.Size(347, 20)
        Me.lblDESCRIPCION_DIVISION.TabIndex = 34
        Me.lblDESCRIPCION_DIVISION.UseMnemonic = False
        Me.lblDESCRIPCION_DIVISION.Visible = False
        '
        'lblTitTIPO_DE_REVALUACION
        '
        Me.lblTitTIPO_DE_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_DE_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_DE_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_DE_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_DE_REVALUACION.Location = New System.Drawing.Point(12, 93)
        Me.lblTitTIPO_DE_REVALUACION.Name = "lblTitTIPO_DE_REVALUACION"
        Me.lblTitTIPO_DE_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_DE_REVALUACION.Size = New System.Drawing.Size(148, 14)
        Me.lblTitTIPO_DE_REVALUACION.TabIndex = 33
        Me.lblTitTIPO_DE_REVALUACION.Text = "Tipo de revaluación"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(444, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "(DD/MM/AAAA)"
        '
        'lblDESCRIP_TIPO_ACTIVO
        '
        Me.lblDESCRIP_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIP_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIP_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIP_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIP_TIPO_ACTIVO.Location = New System.Drawing.Point(283, 120)
        Me.lblDESCRIP_TIPO_ACTIVO.Name = "lblDESCRIP_TIPO_ACTIVO"
        Me.lblDESCRIP_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIP_TIPO_ACTIVO.Size = New System.Drawing.Size(344, 20)
        Me.lblDESCRIP_TIPO_ACTIVO.TabIndex = 28
        Me.lblDESCRIP_TIPO_ACTIVO.UseMnemonic = False
        Me.lblDESCRIP_TIPO_ACTIVO.Visible = False
        '
        'lblTitDESC_REVALUACION
        '
        Me.lblTitDESC_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESC_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESC_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESC_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESC_REVALUACION.Location = New System.Drawing.Point(12, 40)
        Me.lblTitDESC_REVALUACION.Name = "lblTitDESC_REVALUACION"
        Me.lblTitDESC_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESC_REVALUACION.Size = New System.Drawing.Size(148, 14)
        Me.lblTitDESC_REVALUACION.TabIndex = 29
        Me.lblTitDESC_REVALUACION.Text = "Descripción"
        '
        'lblTitFECHA_DE_REVALUACION
        '
        Me.lblTitFECHA_DE_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_DE_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_DE_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_DE_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_DE_REVALUACION.Location = New System.Drawing.Point(12, 66)
        Me.lblTitFECHA_DE_REVALUACION.Name = "lblTitFECHA_DE_REVALUACION"
        Me.lblTitFECHA_DE_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_DE_REVALUACION.Size = New System.Drawing.Size(148, 14)
        Me.lblTitFECHA_DE_REVALUACION.TabIndex = 30
        Me.lblTitFECHA_DE_REVALUACION.Text = "Fecha revaluación"
        '
        'lblTitCODIGO_TIPO_ACTIVO
        '
        Me.lblTitCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(12, 120)
        Me.lblTitCODIGO_TIPO_ACTIVO.Name = "lblTitCODIGO_TIPO_ACTIVO"
        Me.lblTitCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(148, 14)
        Me.lblTitCODIGO_TIPO_ACTIVO.TabIndex = 31
        Me.lblTitCODIGO_TIPO_ACTIVO.Text = "Tipo de activo"
        Me.lblTitCODIGO_TIPO_ACTIVO.Visible = False
        '
        'lblTitCODIGO_REVALUACION
        '
        Me.lblTitCODIGO_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_REVALUACION.Location = New System.Drawing.Point(12, 14)
        Me.lblTitCODIGO_REVALUACION.Name = "lblTitCODIGO_REVALUACION"
        Me.lblTitCODIGO_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_REVALUACION.Size = New System.Drawing.Size(148, 14)
        Me.lblTitCODIGO_REVALUACION.TabIndex = 37
        Me.lblTitCODIGO_REVALUACION.Text = "Código revaluación"
        '
        'ACTRVEM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(639, 241)
        Me.Controls.Add(Me.txtCODIGO_REVALUACION)
        Me.Controls.Add(Me.txtDESC_REVALUACION)
        Me.Controls.Add(Me.mskFECHA_DE_REVALUACION)
        Me.Controls.Add(Me.txtCODIGO_DIVISION)
        Me.Controls.Add(Me.lblTitCODIGO_REVALUACION)
        Me.Controls.Add(Me.txtporcentaje)
        Me.Controls.Add(Me.cboTIPO_DE_REVALUACION)
        Me.Controls.Add(Me.txtCODIGO_TIPO_ACTIVO)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblporcentaje)
        Me.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.Controls.Add(Me.lblDESCRIPCION_DIVISION)
        Me.Controls.Add(Me.lblTitTIPO_DE_REVALUACION)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDESCRIP_TIPO_ACTIVO)
        Me.Controls.Add(Me.lblTitDESC_REVALUACION)
        Me.Controls.Add(Me.lblTitFECHA_DE_REVALUACION)
        Me.Controls.Add(Me.lblTitCODIGO_TIPO_ACTIVO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTRVEM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de datos de revaluación - ACTRVEM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtporcentaje As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCODIGO_DIVISION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents cboTIPO_DE_REVALUACION As System.Windows.Forms.ComboBox
    Public WithEvents mskFECHA_DE_REVALUACION As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents txtCODIGO_REVALUACION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDESC_REVALUACION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_TIPO_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents lblporcentaje As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_DE_REVALUACION As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblDESCRIP_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitDESC_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_DE_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_REVALUACION As System.Windows.Forms.Label
End Class
