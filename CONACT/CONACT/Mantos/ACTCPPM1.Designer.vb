<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTCPPM1
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
        Me.components = New System.ComponentModel.Container()
        Me.txtOBSERVACIONES3 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES2 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES1 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNUMERO_POLIZA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNO_ENDOSO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_COBERTURA = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtDESCRIPCION_COBERTUR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMONTO_ASEGURADO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblOBSERVACIONES = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.lblTitNUMERO_POLIZA = New System.Windows.Forms.Label()
        Me.lblTitNO_ENDOSO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_COBERTURA = New System.Windows.Forms.Label()
        Me.lblTitDESCRIPCION_COBERTUR = New System.Windows.Forms.Label()
        Me.lblTitMONTO_ASEGURADO = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOBSERVACIONES3
        '
        Me.txtOBSERVACIONES3.AcceptsReturn = True
        Me.txtOBSERVACIONES3.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES3.Enabled = False
        Me.txtOBSERVACIONES3.EsRequerido = False
        Me.txtOBSERVACIONES3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES3.LabelConsulta = Nothing
        Me.txtOBSERVACIONES3.Location = New System.Drawing.Point(29, 217)
        Me.txtOBSERVACIONES3.MaxLength = 60
        Me.txtOBSERVACIONES3.Name = "txtOBSERVACIONES3"
        Me.txtOBSERVACIONES3.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES3.Size = New System.Drawing.Size(552, 20)
        Me.txtOBSERVACIONES3.TabIndex = 29
        '
        'txtOBSERVACIONES2
        '
        Me.txtOBSERVACIONES2.AcceptsReturn = True
        Me.txtOBSERVACIONES2.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES2.Enabled = False
        Me.txtOBSERVACIONES2.EsRequerido = False
        Me.txtOBSERVACIONES2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES2.LabelConsulta = Nothing
        Me.txtOBSERVACIONES2.Location = New System.Drawing.Point(29, 197)
        Me.txtOBSERVACIONES2.MaxLength = 60
        Me.txtOBSERVACIONES2.Name = "txtOBSERVACIONES2"
        Me.txtOBSERVACIONES2.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES2.Size = New System.Drawing.Size(552, 20)
        Me.txtOBSERVACIONES2.TabIndex = 28
        '
        'txtOBSERVACIONES1
        '
        Me.txtOBSERVACIONES1.AcceptsReturn = True
        Me.txtOBSERVACIONES1.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES1.Enabled = False
        Me.txtOBSERVACIONES1.EsRequerido = False
        Me.txtOBSERVACIONES1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES1.LabelConsulta = Nothing
        Me.txtOBSERVACIONES1.Location = New System.Drawing.Point(29, 177)
        Me.txtOBSERVACIONES1.MaxLength = 60
        Me.txtOBSERVACIONES1.Name = "txtOBSERVACIONES1"
        Me.txtOBSERVACIONES1.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES1.Size = New System.Drawing.Size(552, 20)
        Me.txtOBSERVACIONES1.TabIndex = 27
        '
        'txtNUMERO_POLIZA
        '
        Me.txtNUMERO_POLIZA.AcceptsReturn = True
        Me.txtNUMERO_POLIZA.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUMERO_POLIZA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_POLIZA.Enabled = False
        Me.txtNUMERO_POLIZA.EsRequerido = False
        Me.txtNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_POLIZA.LabelConsulta = Nothing
        Me.txtNUMERO_POLIZA.Location = New System.Drawing.Point(165, 12)
        Me.txtNUMERO_POLIZA.MaxLength = 20
        Me.txtNUMERO_POLIZA.Name = "txtNUMERO_POLIZA"
        Me.txtNUMERO_POLIZA.NombreDeConsulta = Nothing
        Me.txtNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_POLIZA.Size = New System.Drawing.Size(174, 20)
        Me.txtNUMERO_POLIZA.TabIndex = 16
        '
        'txtNO_ENDOSO
        '
        Me.txtNO_ENDOSO.AcceptsReturn = True
        Me.txtNO_ENDOSO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNO_ENDOSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNO_ENDOSO.Enabled = False
        Me.txtNO_ENDOSO.EsRequerido = False
        Me.txtNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNO_ENDOSO.LabelConsulta = Nothing
        Me.txtNO_ENDOSO.Location = New System.Drawing.Point(165, 38)
        Me.txtNO_ENDOSO.MaxLength = 15
        Me.txtNO_ENDOSO.Name = "txtNO_ENDOSO"
        Me.txtNO_ENDOSO.NombreDeConsulta = Nothing
        Me.txtNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNO_ENDOSO.Size = New System.Drawing.Size(174, 20)
        Me.txtNO_ENDOSO.TabIndex = 17
        Me.txtNO_ENDOSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_COBERTURA
        '
        Me.txtCODIGO_COBERTURA.AcceptsReturn = True
        Me.txtCODIGO_COBERTURA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_COBERTURA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_COBERTURA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_COBERTURA.Enabled = False
        Me.txtCODIGO_COBERTURA.EsRequerido = False
        Me.txtCODIGO_COBERTURA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_COBERTURA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_COBERTURA.LabelConsulta = Nothing
        Me.txtCODIGO_COBERTURA.Location = New System.Drawing.Point(165, 64)
        Me.txtCODIGO_COBERTURA.MaxLength = 10
        Me.txtCODIGO_COBERTURA.Multiline = True
        Me.txtCODIGO_COBERTURA.Name = "txtCODIGO_COBERTURA"
        Me.txtCODIGO_COBERTURA.NombreDeConsulta = Nothing
        Me.txtCODIGO_COBERTURA.NumeroDecimales = 2
        Me.txtCODIGO_COBERTURA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_COBERTURA.Size = New System.Drawing.Size(174, 20)
        Me.txtCODIGO_COBERTURA.TabIndex = 18
        Me.txtCODIGO_COBERTURA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDESCRIPCION_COBERTUR
        '
        Me.txtDESCRIPCION_COBERTUR.AcceptsReturn = True
        Me.txtDESCRIPCION_COBERTUR.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION_COBERTUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION_COBERTUR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION_COBERTUR.Enabled = False
        Me.txtDESCRIPCION_COBERTUR.EsRequerido = False
        Me.txtDESCRIPCION_COBERTUR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION_COBERTUR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION_COBERTUR.LabelConsulta = Nothing
        Me.txtDESCRIPCION_COBERTUR.Location = New System.Drawing.Point(165, 90)
        Me.txtDESCRIPCION_COBERTUR.MaxLength = 60
        Me.txtDESCRIPCION_COBERTUR.Name = "txtDESCRIPCION_COBERTUR"
        Me.txtDESCRIPCION_COBERTUR.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION_COBERTUR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION_COBERTUR.Size = New System.Drawing.Size(416, 20)
        Me.txtDESCRIPCION_COBERTUR.TabIndex = 19
        '
        'txtMONTO_ASEGURADO
        '
        Me.txtMONTO_ASEGURADO.AcceptsReturn = True
        Me.txtMONTO_ASEGURADO.BackColor = System.Drawing.SystemColors.Window
        Me.txtMONTO_ASEGURADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMONTO_ASEGURADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMONTO_ASEGURADO.Enabled = False
        Me.txtMONTO_ASEGURADO.EsRequerido = False
        Me.txtMONTO_ASEGURADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTO_ASEGURADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMONTO_ASEGURADO.LabelConsulta = Nothing
        Me.txtMONTO_ASEGURADO.Location = New System.Drawing.Point(165, 116)
        Me.txtMONTO_ASEGURADO.MaxLength = 14
        Me.txtMONTO_ASEGURADO.Multiline = True
        Me.txtMONTO_ASEGURADO.Name = "txtMONTO_ASEGURADO"
        Me.txtMONTO_ASEGURADO.NombreDeConsulta = Nothing
        Me.txtMONTO_ASEGURADO.NumeroDecimales = 0
        Me.txtMONTO_ASEGURADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMONTO_ASEGURADO.Size = New System.Drawing.Size(174, 20)
        Me.txtMONTO_ASEGURADO.TabIndex = 20
        Me.txtMONTO_ASEGURADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(494, 243)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 26
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'lblOBSERVACIONES
        '
        Me.lblOBSERVACIONES.AutoSize = True
        Me.lblOBSERVACIONES.BackColor = System.Drawing.Color.Transparent
        Me.lblOBSERVACIONES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOBSERVACIONES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOBSERVACIONES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblOBSERVACIONES.Location = New System.Drawing.Point(9, 160)
        Me.lblOBSERVACIONES.Name = "lblOBSERVACIONES"
        Me.lblOBSERVACIONES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOBSERVACIONES.Size = New System.Drawing.Size(81, 14)
        Me.lblOBSERVACIONES.TabIndex = 30
        Me.lblOBSERVACIONES.Text = "Observaciones"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Location = New System.Drawing.Point(9, 159)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(576, 1)
        Me.Line1.TabIndex = 31
        '
        'lblTitNUMERO_POLIZA
        '
        Me.lblTitNUMERO_POLIZA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_POLIZA.Location = New System.Drawing.Point(12, 14)
        Me.lblTitNUMERO_POLIZA.Name = "lblTitNUMERO_POLIZA"
        Me.lblTitNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_POLIZA.Size = New System.Drawing.Size(147, 14)
        Me.lblTitNUMERO_POLIZA.TabIndex = 21
        Me.lblTitNUMERO_POLIZA.Text = "Número de pólliza"
        '
        'lblTitNO_ENDOSO
        '
        Me.lblTitNO_ENDOSO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_ENDOSO.Location = New System.Drawing.Point(12, 40)
        Me.lblTitNO_ENDOSO.Name = "lblTitNO_ENDOSO"
        Me.lblTitNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_ENDOSO.Size = New System.Drawing.Size(147, 14)
        Me.lblTitNO_ENDOSO.TabIndex = 22
        Me.lblTitNO_ENDOSO.Text = "Número de endoso"
        '
        'lblTitCODIGO_COBERTURA
        '
        Me.lblTitCODIGO_COBERTURA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_COBERTURA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_COBERTURA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_COBERTURA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_COBERTURA.Location = New System.Drawing.Point(12, 66)
        Me.lblTitCODIGO_COBERTURA.Name = "lblTitCODIGO_COBERTURA"
        Me.lblTitCODIGO_COBERTURA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_COBERTURA.Size = New System.Drawing.Size(147, 14)
        Me.lblTitCODIGO_COBERTURA.TabIndex = 23
        Me.lblTitCODIGO_COBERTURA.Text = "Código de cobertura"
        '
        'lblTitDESCRIPCION_COBERTUR
        '
        Me.lblTitDESCRIPCION_COBERTUR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION_COBERTUR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_COBERTUR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_COBERTUR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_COBERTUR.Location = New System.Drawing.Point(12, 92)
        Me.lblTitDESCRIPCION_COBERTUR.Name = "lblTitDESCRIPCION_COBERTUR"
        Me.lblTitDESCRIPCION_COBERTUR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_COBERTUR.Size = New System.Drawing.Size(147, 14)
        Me.lblTitDESCRIPCION_COBERTUR.TabIndex = 24
        Me.lblTitDESCRIPCION_COBERTUR.Text = "Descripción cobertura"
        '
        'lblTitMONTO_ASEGURADO
        '
        Me.lblTitMONTO_ASEGURADO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_ASEGURADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_ASEGURADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_ASEGURADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_ASEGURADO.Location = New System.Drawing.Point(12, 118)
        Me.lblTitMONTO_ASEGURADO.Name = "lblTitMONTO_ASEGURADO"
        Me.lblTitMONTO_ASEGURADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_ASEGURADO.Size = New System.Drawing.Size(147, 14)
        Me.lblTitMONTO_ASEGURADO.TabIndex = 25
        Me.lblTitMONTO_ASEGURADO.Text = "Monto asegurado"
        '
        'ACTCPPM1
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(593, 280)
        Me.Controls.Add(Me.txtOBSERVACIONES3)
        Me.Controls.Add(Me.txtOBSERVACIONES2)
        Me.Controls.Add(Me.txtOBSERVACIONES1)
        Me.Controls.Add(Me.txtNUMERO_POLIZA)
        Me.Controls.Add(Me.txtNO_ENDOSO)
        Me.Controls.Add(Me.txtCODIGO_COBERTURA)
        Me.Controls.Add(Me.txtDESCRIPCION_COBERTUR)
        Me.Controls.Add(Me.txtMONTO_ASEGURADO)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblOBSERVACIONES)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.lblTitNUMERO_POLIZA)
        Me.Controls.Add(Me.lblTitNO_ENDOSO)
        Me.Controls.Add(Me.lblTitCODIGO_COBERTURA)
        Me.Controls.Add(Me.lblTitDESCRIPCION_COBERTUR)
        Me.Controls.Add(Me.lblTitMONTO_ASEGURADO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTCPPM1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta a coberturas por póliza - ACTCPPM1"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtOBSERVACIONES3 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES2 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES1 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtNUMERO_POLIZA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNO_ENDOSO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_COBERTURA As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtDESCRIPCION_COBERTUR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtMONTO_ASEGURADO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents lblOBSERVACIONES As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents lblTitNUMERO_POLIZA As System.Windows.Forms.Label
    Public WithEvents lblTitNO_ENDOSO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_COBERTURA As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIPCION_COBERTUR As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_ASEGURADO As System.Windows.Forms.Label
End Class
