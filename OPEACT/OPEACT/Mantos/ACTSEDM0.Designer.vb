<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEDM0
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblnombreactivo = New System.Windows.Forms.Label()
        Me.txtNUMERO_POLIZA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNO_ENDOSO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_COBERTURA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_DE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMEJORA_CORRELATIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitNUMERO_POLIZA = New System.Windows.Forms.Label()
        Me.lblTitNO_ENDOSO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_COBERTURA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblnombreactivo)
        Me.GroupBox1.Controls.Add(Me.txtNUMERO_POLIZA)
        Me.GroupBox1.Controls.Add(Me.txtNO_ENDOSO)
        Me.GroupBox1.Controls.Add(Me.txtCODIGO_COBERTURA)
        Me.GroupBox1.Controls.Add(Me.txtCODIGO_DE_ACTIVO)
        Me.GroupBox1.Controls.Add(Me.txtMEJORA_CORRELATIVO)
        Me.GroupBox1.Controls.Add(Me.lblTitNUMERO_POLIZA)
        Me.GroupBox1.Controls.Add(Me.lblTitNO_ENDOSO)
        Me.GroupBox1.Controls.Add(Me.lblTitCODIGO_COBERTURA)
        Me.GroupBox1.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.GroupBox1.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblnombreactivo
        '
        Me.lblnombreactivo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreactivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreactivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreactivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreactivo.Location = New System.Drawing.Point(266, 99)
        Me.lblnombreactivo.Name = "lblnombreactivo"
        Me.lblnombreactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreactivo.Size = New System.Drawing.Size(344, 20)
        Me.lblnombreactivo.TabIndex = 20
        Me.lblnombreactivo.UseMnemonic = False
        '
        'txtNUMERO_POLIZA
        '
        Me.txtNUMERO_POLIZA.AcceptsReturn = True
        Me.txtNUMERO_POLIZA.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUMERO_POLIZA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_POLIZA.EsRequerido = True
        Me.txtNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_POLIZA.LabelConsulta = Nothing
        Me.txtNUMERO_POLIZA.Location = New System.Drawing.Point(166, 19)
        Me.txtNUMERO_POLIZA.MaxLength = 20
        Me.txtNUMERO_POLIZA.Name = "txtNUMERO_POLIZA"
        Me.txtNUMERO_POLIZA.NombreDeConsulta = Nothing
        Me.txtNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_POLIZA.Size = New System.Drawing.Size(174, 20)
        Me.txtNUMERO_POLIZA.TabIndex = 0
        '
        'txtNO_ENDOSO
        '
        Me.txtNO_ENDOSO.AcceptsReturn = True
        Me.txtNO_ENDOSO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNO_ENDOSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNO_ENDOSO.EsRequerido = True
        Me.txtNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNO_ENDOSO.LabelConsulta = Nothing
        Me.txtNO_ENDOSO.Location = New System.Drawing.Point(166, 45)
        Me.txtNO_ENDOSO.MaxLength = 15
        Me.txtNO_ENDOSO.Name = "txtNO_ENDOSO"
        Me.txtNO_ENDOSO.NombreDeConsulta = Nothing
        Me.txtNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNO_ENDOSO.Size = New System.Drawing.Size(94, 20)
        Me.txtNO_ENDOSO.TabIndex = 1
        Me.txtNO_ENDOSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_COBERTURA
        '
        Me.txtCODIGO_COBERTURA.AcceptsReturn = True
        Me.txtCODIGO_COBERTURA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_COBERTURA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_COBERTURA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_COBERTURA.EsRequerido = True
        Me.txtCODIGO_COBERTURA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_COBERTURA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_COBERTURA.LabelConsulta = Nothing
        Me.txtCODIGO_COBERTURA.Location = New System.Drawing.Point(166, 71)
        Me.txtCODIGO_COBERTURA.MaxLength = 10
        Me.txtCODIGO_COBERTURA.Multiline = True
        Me.txtCODIGO_COBERTURA.Name = "txtCODIGO_COBERTURA"
        Me.txtCODIGO_COBERTURA.NombreDeConsulta = Nothing
        Me.txtCODIGO_COBERTURA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_COBERTURA.Size = New System.Drawing.Size(94, 20)
        Me.txtCODIGO_COBERTURA.TabIndex = 2
        Me.txtCODIGO_COBERTURA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_DE_ACTIVO
        '
        Me.txtCODIGO_DE_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_DE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_ACTIVO.EsRequerido = True
        Me.txtCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(166, 97)
        Me.txtCODIGO_DE_ACTIVO.MaxLength = 15
        Me.txtCODIGO_DE_ACTIVO.Name = "txtCODIGO_DE_ACTIVO"
        Me.txtCODIGO_DE_ACTIVO.NombreDeConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(94, 20)
        Me.txtCODIGO_DE_ACTIVO.TabIndex = 3
        '
        'txtMEJORA_CORRELATIVO
        '
        Me.txtMEJORA_CORRELATIVO.AcceptsReturn = True
        Me.txtMEJORA_CORRELATIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtMEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMEJORA_CORRELATIVO.EsRequerido = True
        Me.txtMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMEJORA_CORRELATIVO.LabelConsulta = Nothing
        Me.txtMEJORA_CORRELATIVO.Location = New System.Drawing.Point(166, 123)
        Me.txtMEJORA_CORRELATIVO.MaxLength = 10
        Me.txtMEJORA_CORRELATIVO.Multiline = True
        Me.txtMEJORA_CORRELATIVO.Name = "txtMEJORA_CORRELATIVO"
        Me.txtMEJORA_CORRELATIVO.NombreDeConsulta = Nothing
        Me.txtMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMEJORA_CORRELATIVO.Size = New System.Drawing.Size(45, 20)
        Me.txtMEJORA_CORRELATIVO.TabIndex = 4
        Me.txtMEJORA_CORRELATIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitNUMERO_POLIZA
        '
        Me.lblTitNUMERO_POLIZA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_POLIZA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitNUMERO_POLIZA.Name = "lblTitNUMERO_POLIZA"
        Me.lblTitNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_POLIZA.Size = New System.Drawing.Size(154, 14)
        Me.lblTitNUMERO_POLIZA.TabIndex = 15
        Me.lblTitNUMERO_POLIZA.Text = "Número de póliza"
        '
        'lblTitNO_ENDOSO
        '
        Me.lblTitNO_ENDOSO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_ENDOSO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitNO_ENDOSO.Name = "lblTitNO_ENDOSO"
        Me.lblTitNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_ENDOSO.Size = New System.Drawing.Size(154, 14)
        Me.lblTitNO_ENDOSO.TabIndex = 16
        Me.lblTitNO_ENDOSO.Text = "Número endoso"
        '
        'lblTitCODIGO_COBERTURA
        '
        Me.lblTitCODIGO_COBERTURA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_COBERTURA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_COBERTURA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_COBERTURA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_COBERTURA.Location = New System.Drawing.Point(6, 73)
        Me.lblTitCODIGO_COBERTURA.Name = "lblTitCODIGO_COBERTURA"
        Me.lblTitCODIGO_COBERTURA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_COBERTURA.Size = New System.Drawing.Size(154, 14)
        Me.lblTitCODIGO_COBERTURA.TabIndex = 17
        Me.lblTitCODIGO_COBERTURA.Text = "Cobertura"
        '
        'lblTitCODIGO_DE_ACTIVO
        '
        Me.lblTitCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(6, 99)
        Me.lblTitCODIGO_DE_ACTIVO.Name = "lblTitCODIGO_DE_ACTIVO"
        Me.lblTitCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(154, 14)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 18
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Código de activo"
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(6, 125)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(154, 14)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 19
        Me.lblTitMEJORA_CORRELATIVO.Text = "Mejora correlativo"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(448, 166)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 12
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
        Me.cmdCancelar.Location = New System.Drawing.Point(541, 166)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 13
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'ACTSEDM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(640, 203)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTSEDM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de activos asegurados por la póliza - ACTSEDM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents lblnombreactivo As System.Windows.Forms.Label
    Public WithEvents txtNUMERO_POLIZA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNO_ENDOSO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_COBERTURA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_DE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtMEJORA_CORRELATIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitNUMERO_POLIZA As System.Windows.Forms.Label
    Public WithEvents lblTitNO_ENDOSO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_COBERTURA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
