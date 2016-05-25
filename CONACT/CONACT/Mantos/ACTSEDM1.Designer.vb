<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEDM1
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
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblDescripcionCobertura = New System.Windows.Forms.Label()
        Me.lblNombreActivo = New System.Windows.Forms.Label()
        Me.lblNoPoliza = New System.Windows.Forms.Label()
        Me.lblNoEndoso = New System.Windows.Forms.Label()
        Me.lblCobertura = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNoPoliza = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNoEndoso = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCodigoCobertura = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCodigoActivo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCodigoMejora = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCodigoActivo = New System.Windows.Forms.Label()
        Me.lblCodigoMejora = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(477, 157)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 23
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'lblDescripcionCobertura
        '
        Me.lblDescripcionCobertura.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcionCobertura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcionCobertura.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionCobertura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDescripcionCobertura.Location = New System.Drawing.Point(296, 66)
        Me.lblDescripcionCobertura.Name = "lblDescripcionCobertura"
        Me.lblDescripcionCobertura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcionCobertura.Size = New System.Drawing.Size(268, 20)
        Me.lblDescripcionCobertura.TabIndex = 25
        '
        'lblNombreActivo
        '
        Me.lblNombreActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreActivo.Location = New System.Drawing.Point(296, 93)
        Me.lblNombreActivo.Name = "lblNombreActivo"
        Me.lblNombreActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreActivo.Size = New System.Drawing.Size(268, 20)
        Me.lblNombreActivo.TabIndex = 24
        Me.lblNombreActivo.UseMnemonic = False
        '
        'lblNoPoliza
        '
        Me.lblNoPoliza.BackColor = System.Drawing.Color.Transparent
        Me.lblNoPoliza.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoPoliza.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPoliza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNoPoliza.Location = New System.Drawing.Point(12, 14)
        Me.lblNoPoliza.Name = "lblNoPoliza"
        Me.lblNoPoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNoPoliza.Size = New System.Drawing.Size(142, 14)
        Me.lblNoPoliza.TabIndex = 18
        Me.lblNoPoliza.Text = "Número de póliza"
        '
        'lblNoEndoso
        '
        Me.lblNoEndoso.BackColor = System.Drawing.Color.Transparent
        Me.lblNoEndoso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoEndoso.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoEndoso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNoEndoso.Location = New System.Drawing.Point(12, 40)
        Me.lblNoEndoso.Name = "lblNoEndoso"
        Me.lblNoEndoso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNoEndoso.Size = New System.Drawing.Size(142, 14)
        Me.lblNoEndoso.TabIndex = 19
        Me.lblNoEndoso.Text = "Número endoso"
        '
        'lblCobertura
        '
        Me.lblCobertura.BackColor = System.Drawing.Color.Transparent
        Me.lblCobertura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCobertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCobertura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCobertura.Location = New System.Drawing.Point(12, 66)
        Me.lblCobertura.Name = "lblCobertura"
        Me.lblCobertura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCobertura.Size = New System.Drawing.Size(142, 14)
        Me.lblCobertura.TabIndex = 20
        Me.lblCobertura.Text = "Cobertura"
        '
        'txtNoPoliza
        '
        Me.txtNoPoliza.AcceptsReturn = True
        Me.txtNoPoliza.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPoliza.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoPoliza.Enabled = False
        Me.txtNoPoliza.EsRequerido = False
        Me.txtNoPoliza.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPoliza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoPoliza.LabelConsulta = Nothing
        Me.txtNoPoliza.Location = New System.Drawing.Point(160, 12)
        Me.txtNoPoliza.MaxLength = 20
        Me.txtNoPoliza.Name = "txtNoPoliza"
        Me.txtNoPoliza.NombreDeConsulta = Nothing
        Me.txtNoPoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoPoliza.Size = New System.Drawing.Size(130, 20)
        Me.txtNoPoliza.TabIndex = 13
        '
        'txtNoEndoso
        '
        Me.txtNoEndoso.AcceptsReturn = True
        Me.txtNoEndoso.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoEndoso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoEndoso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoEndoso.Enabled = False
        Me.txtNoEndoso.EsRequerido = False
        Me.txtNoEndoso.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoEndoso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoEndoso.LabelConsulta = Nothing
        Me.txtNoEndoso.Location = New System.Drawing.Point(160, 38)
        Me.txtNoEndoso.MaxLength = 15
        Me.txtNoEndoso.Name = "txtNoEndoso"
        Me.txtNoEndoso.NombreDeConsulta = Nothing
        Me.txtNoEndoso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoEndoso.Size = New System.Drawing.Size(130, 20)
        Me.txtNoEndoso.TabIndex = 14
        Me.txtNoEndoso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigoCobertura
        '
        Me.txtCodigoCobertura.AcceptsReturn = True
        Me.txtCodigoCobertura.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoCobertura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoCobertura.Enabled = False
        Me.txtCodigoCobertura.EsRequerido = False
        Me.txtCodigoCobertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCobertura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoCobertura.LabelConsulta = Nothing
        Me.txtCodigoCobertura.Location = New System.Drawing.Point(160, 64)
        Me.txtCodigoCobertura.MaxLength = 10
        Me.txtCodigoCobertura.Multiline = True
        Me.txtCodigoCobertura.Name = "txtCodigoCobertura"
        Me.txtCodigoCobertura.NombreDeConsulta = Nothing
        Me.txtCodigoCobertura.NumeroDecimales = 0
        Me.txtCodigoCobertura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoCobertura.Size = New System.Drawing.Size(130, 20)
        Me.txtCodigoCobertura.TabIndex = 15
        Me.txtCodigoCobertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigoActivo
        '
        Me.txtCodigoActivo.AcceptsReturn = True
        Me.txtCodigoActivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoActivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoActivo.Enabled = False
        Me.txtCodigoActivo.EsRequerido = False
        Me.txtCodigoActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoActivo.LabelConsulta = Nothing
        Me.txtCodigoActivo.Location = New System.Drawing.Point(160, 91)
        Me.txtCodigoActivo.MaxLength = 15
        Me.txtCodigoActivo.Name = "txtCodigoActivo"
        Me.txtCodigoActivo.NombreDeConsulta = Nothing
        Me.txtCodigoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoActivo.Size = New System.Drawing.Size(130, 20)
        Me.txtCodigoActivo.TabIndex = 16
        '
        'txtCodigoMejora
        '
        Me.txtCodigoMejora.AcceptsReturn = True
        Me.txtCodigoMejora.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoMejora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoMejora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoMejora.Enabled = False
        Me.txtCodigoMejora.EsRequerido = False
        Me.txtCodigoMejora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoMejora.LabelConsulta = Nothing
        Me.txtCodigoMejora.Location = New System.Drawing.Point(160, 117)
        Me.txtCodigoMejora.MaxLength = 10
        Me.txtCodigoMejora.Multiline = True
        Me.txtCodigoMejora.Name = "txtCodigoMejora"
        Me.txtCodigoMejora.NombreDeConsulta = Nothing
        Me.txtCodigoMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoMejora.Size = New System.Drawing.Size(130, 20)
        Me.txtCodigoMejora.TabIndex = 17
        Me.txtCodigoMejora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigoActivo
        '
        Me.lblCodigoActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoActivo.Location = New System.Drawing.Point(12, 93)
        Me.lblCodigoActivo.Name = "lblCodigoActivo"
        Me.lblCodigoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoActivo.Size = New System.Drawing.Size(142, 14)
        Me.lblCodigoActivo.TabIndex = 21
        Me.lblCodigoActivo.Text = "Código de activo"
        '
        'lblCodigoMejora
        '
        Me.lblCodigoMejora.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoMejora.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoMejora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoMejora.Location = New System.Drawing.Point(12, 119)
        Me.lblCodigoMejora.Name = "lblCodigoMejora"
        Me.lblCodigoMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoMejora.Size = New System.Drawing.Size(142, 14)
        Me.lblCodigoMejora.TabIndex = 22
        Me.lblCodigoMejora.Text = "Mejora correlativo"
        '
        'ACTSEDM1
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(576, 189)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblDescripcionCobertura)
        Me.Controls.Add(Me.lblNombreActivo)
        Me.Controls.Add(Me.lblNoPoliza)
        Me.Controls.Add(Me.lblNoEndoso)
        Me.Controls.Add(Me.lblCobertura)
        Me.Controls.Add(Me.txtNoPoliza)
        Me.Controls.Add(Me.txtNoEndoso)
        Me.Controls.Add(Me.txtCodigoCobertura)
        Me.Controls.Add(Me.txtCodigoActivo)
        Me.Controls.Add(Me.txtCodigoMejora)
        Me.Controls.Add(Me.lblCodigoActivo)
        Me.Controls.Add(Me.lblCodigoMejora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTSEDM1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de activos asegurados por la póliza - ACTSEDM1"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents lblDescripcionCobertura As System.Windows.Forms.Label
    Public WithEvents lblNombreActivo As System.Windows.Forms.Label
    Public WithEvents lblNoPoliza As System.Windows.Forms.Label
    Public WithEvents lblNoEndoso As System.Windows.Forms.Label
    Public WithEvents lblCobertura As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtNoPoliza As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNoEndoso As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCodigoCobertura As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCodigoActivo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCodigoMejora As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCodigoActivo As System.Windows.Forms.Label
    Public WithEvents lblCodigoMejora As System.Windows.Forms.Label
End Class
