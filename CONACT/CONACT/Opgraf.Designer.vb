<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opgraf
    Inherits System.Windows.Forms.Form

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
        Me.graDemo = New System.Windows.Forms.PictureBox()
        Me._chkGS_0 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkDrawStyle = New System.Windows.Forms.CheckBox()
        Me._chkGS_2 = New System.Windows.Forms.CheckBox()
        Me._chkGS_1 = New System.Windows.Forms.CheckBox()
        Me.cboGT = New System.Windows.Forms.ComboBox()
        Me.cboGS = New System.Windows.Forms.ComboBox()
        Me.lblGraphStyle = New System.Windows.Forms.Label()
        Me.lblGraphType = New System.Windows.Forms.Label()
        Me.lblTitGraphStyle = New System.Windows.Forms.Label()
        Me.lblTitGraphType = New System.Windows.Forms.Label()
        Me.lblTitEstilo = New System.Windows.Forms.Label()
        Me.lblTitTipo = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.graDemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graDemo
        '
        Me.graDemo.BackColor = System.Drawing.SystemColors.Control
        Me.graDemo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.graDemo.Cursor = System.Windows.Forms.Cursors.Default
        Me.graDemo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graDemo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.graDemo.Location = New System.Drawing.Point(277, 12)
        Me.graDemo.Name = "graDemo"
        Me.graDemo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.graDemo.Size = New System.Drawing.Size(279, 156)
        Me.graDemo.TabIndex = 27
        Me.graDemo.TabStop = False
        '
        '_chkGS_0
        '
        Me._chkGS_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkGS_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkGS_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkGS_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkGS_0.Location = New System.Drawing.Point(134, 40)
        Me._chkGS_0.Name = "_chkGS_0"
        Me._chkGS_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkGS_0.Size = New System.Drawing.Size(137, 22)
        Me._chkGS_0.TabIndex = 19
        Me._chkGS_0.Text = "Opción 1"
        Me._chkGS_0.UseVisualStyleBackColor = False
        '
        'chkDrawStyle
        '
        Me.chkDrawStyle.BackColor = System.Drawing.SystemColors.Control
        Me.chkDrawStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDrawStyle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrawStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDrawStyle.Location = New System.Drawing.Point(134, 127)
        Me.chkDrawStyle.Name = "chkDrawStyle"
        Me.chkDrawStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDrawStyle.Size = New System.Drawing.Size(137, 22)
        Me.chkDrawStyle.TabIndex = 26
        Me.chkDrawStyle.Text = "&Utilizar colores"
        Me.chkDrawStyle.UseVisualStyleBackColor = False
        '
        '_chkGS_2
        '
        Me._chkGS_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkGS_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkGS_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkGS_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkGS_2.Location = New System.Drawing.Point(134, 78)
        Me._chkGS_2.Name = "_chkGS_2"
        Me._chkGS_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkGS_2.Size = New System.Drawing.Size(137, 22)
        Me._chkGS_2.TabIndex = 21
        Me._chkGS_2.Text = "Opción 3"
        Me._chkGS_2.UseVisualStyleBackColor = False
        '
        '_chkGS_1
        '
        Me._chkGS_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkGS_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkGS_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkGS_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkGS_1.Location = New System.Drawing.Point(134, 59)
        Me._chkGS_1.Name = "_chkGS_1"
        Me._chkGS_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkGS_1.Size = New System.Drawing.Size(137, 22)
        Me._chkGS_1.TabIndex = 20
        Me._chkGS_1.Text = "Opción 2"
        Me._chkGS_1.UseVisualStyleBackColor = False
        '
        'cboGT
        '
        Me.cboGT.BackColor = System.Drawing.SystemColors.Window
        Me.cboGT.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGT.Location = New System.Drawing.Point(134, 12)
        Me.cboGT.Name = "cboGT"
        Me.cboGT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGT.Size = New System.Drawing.Size(137, 22)
        Me.cboGT.TabIndex = 16
        '
        'cboGS
        '
        Me.cboGS.BackColor = System.Drawing.Color.White
        Me.cboGS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboGS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGS.Location = New System.Drawing.Point(134, 40)
        Me.cboGS.Name = "cboGS"
        Me.cboGS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGS.Size = New System.Drawing.Size(137, 22)
        Me.cboGS.TabIndex = 18
        '
        'lblGraphStyle
        '
        Me.lblGraphStyle.BackColor = System.Drawing.SystemColors.Window
        Me.lblGraphStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGraphStyle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblGraphStyle.Location = New System.Drawing.Point(458, 183)
        Me.lblGraphStyle.Name = "lblGraphStyle"
        Me.lblGraphStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGraphStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblGraphStyle.TabIndex = 25
        Me.lblGraphStyle.Text = "0"
        Me.lblGraphStyle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGraphType
        '
        Me.lblGraphType.BackColor = System.Drawing.SystemColors.Window
        Me.lblGraphType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGraphType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblGraphType.Location = New System.Drawing.Point(362, 183)
        Me.lblGraphType.Name = "lblGraphType"
        Me.lblGraphType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGraphType.Size = New System.Drawing.Size(33, 13)
        Me.lblGraphType.TabIndex = 24
        Me.lblGraphType.Text = "0"
        Me.lblGraphType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitGraphStyle
        '
        Me.lblTitGraphStyle.AutoSize = True
        Me.lblTitGraphStyle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitGraphStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitGraphStyle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitGraphStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitGraphStyle.Location = New System.Drawing.Point(12, 43)
        Me.lblTitGraphStyle.Name = "lblTitGraphStyle"
        Me.lblTitGraphStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitGraphStyle.Size = New System.Drawing.Size(86, 14)
        Me.lblTitGraphStyle.TabIndex = 17
        Me.lblTitGraphStyle.Text = "&Estilo del gráfico"
        '
        'lblTitGraphType
        '
        Me.lblTitGraphType.AutoSize = True
        Me.lblTitGraphType.BackColor = System.Drawing.Color.Transparent
        Me.lblTitGraphType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitGraphType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitGraphType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitGraphType.Location = New System.Drawing.Point(12, 15)
        Me.lblTitGraphType.Name = "lblTitGraphType"
        Me.lblTitGraphType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitGraphType.Size = New System.Drawing.Size(79, 14)
        Me.lblTitGraphType.TabIndex = 15
        Me.lblTitGraphType.Text = "&Tipo de gráfico"
        '
        'lblTitEstilo
        '
        Me.lblTitEstilo.AutoSize = True
        Me.lblTitEstilo.BackColor = System.Drawing.SystemColors.Window
        Me.lblTitEstilo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitEstilo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitEstilo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitEstilo.Location = New System.Drawing.Point(414, 183)
        Me.lblTitEstilo.Name = "lblTitEstilo"
        Me.lblTitEstilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitEstilo.Size = New System.Drawing.Size(35, 14)
        Me.lblTitEstilo.TabIndex = 23
        Me.lblTitEstilo.Text = "Estilo:"
        '
        'lblTitTipo
        '
        Me.lblTitTipo.AutoSize = True
        Me.lblTitTipo.BackColor = System.Drawing.SystemColors.Window
        Me.lblTitTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTipo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTipo.Location = New System.Drawing.Point(318, 183)
        Me.lblTitTipo.Name = "lblTitTipo"
        Me.lblTitTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTitTipo.TabIndex = 22
        Me.lblTitTipo.Text = "Tipo:"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalir.Location = New System.Drawing.Point(12, 143)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(87, 25)
        Me.cmdSalir.TabIndex = 32
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'Opgraf
        '
        Me.AcceptButton = Me.cmdSalir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(568, 180)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.graDemo)
        Me.Controls.Add(Me._chkGS_0)
        Me.Controls.Add(Me.chkDrawStyle)
        Me.Controls.Add(Me._chkGS_2)
        Me.Controls.Add(Me._chkGS_1)
        Me.Controls.Add(Me.cboGT)
        Me.Controls.Add(Me.cboGS)
        Me.Controls.Add(Me.lblGraphStyle)
        Me.Controls.Add(Me.lblGraphType)
        Me.Controls.Add(Me.lblTitGraphStyle)
        Me.Controls.Add(Me.lblTitGraphType)
        Me.Controls.Add(Me.lblTitEstilo)
        Me.Controls.Add(Me.lblTitTipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "Opgraf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opgraf"
        CType(Me.graDemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents graDemo As System.Windows.Forms.PictureBox
    Public WithEvents _chkGS_0 As System.Windows.Forms.CheckBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents chkDrawStyle As System.Windows.Forms.CheckBox
    Public WithEvents _chkGS_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkGS_1 As System.Windows.Forms.CheckBox
    Public WithEvents cboGT As System.Windows.Forms.ComboBox
    Public WithEvents cboGS As System.Windows.Forms.ComboBox
    Public WithEvents lblGraphStyle As System.Windows.Forms.Label
    Public WithEvents lblGraphType As System.Windows.Forms.Label
    Public WithEvents lblTitGraphStyle As System.Windows.Forms.Label
    Public WithEvents lblTitGraphType As System.Windows.Forms.Label
    Public WithEvents lblTitEstilo As System.Windows.Forms.Label
    Public WithEvents lblTitTipo As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Button
End Class
