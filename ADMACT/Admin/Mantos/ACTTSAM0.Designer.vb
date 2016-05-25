<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTTSAM0
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
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtTIPO_SERVICIO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIPCION_SERVICIO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboCLASE_DE_SERVICIO = New System.Windows.Forms.ComboBox()
        Me.lblTitCLASE_DE_SERVICIO = New System.Windows.Forms.Label()
        Me.lblTitDESCRIPCION_SERVICIO = New System.Windows.Forms.Label()
        Me.lblTitTIPO_SERVICIO = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(389, 124)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(295, 124)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtTIPO_SERVICIO)
        Me.Frame1.Controls.Add(Me.txtDESCRIPCION_SERVICIO)
        Me.Frame1.Controls.Add(Me.cboCLASE_DE_SERVICIO)
        Me.Frame1.Controls.Add(Me.lblTitCLASE_DE_SERVICIO)
        Me.Frame1.Controls.Add(Me.lblTitDESCRIPCION_SERVICIO)
        Me.Frame1.Controls.Add(Me.lblTitTIPO_SERVICIO)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(464, 106)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtTIPO_SERVICIO
        '
        Me.txtTIPO_SERVICIO.AcceptsReturn = True
        Me.txtTIPO_SERVICIO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIPO_SERVICIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIPO_SERVICIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIPO_SERVICIO.EsRequerido = True
        Me.txtTIPO_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_SERVICIO.LabelConsulta = Nothing
        Me.txtTIPO_SERVICIO.Location = New System.Drawing.Point(134, 19)
        Me.txtTIPO_SERVICIO.MaxLength = 10
        Me.txtTIPO_SERVICIO.Name = "txtTIPO_SERVICIO"
        Me.txtTIPO_SERVICIO.NombreDeConsulta = Nothing
        Me.txtTIPO_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_SERVICIO.Size = New System.Drawing.Size(87, 20)
        Me.txtTIPO_SERVICIO.TabIndex = 1
        '
        'txtDESCRIPCION_SERVICIO
        '
        Me.txtDESCRIPCION_SERVICIO.AcceptsReturn = True
        Me.txtDESCRIPCION_SERVICIO.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION_SERVICIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION_SERVICIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION_SERVICIO.EsRequerido = True
        Me.txtDESCRIPCION_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION_SERVICIO.LabelConsulta = Nothing
        Me.txtDESCRIPCION_SERVICIO.Location = New System.Drawing.Point(134, 45)
        Me.txtDESCRIPCION_SERVICIO.MaxLength = 40
        Me.txtDESCRIPCION_SERVICIO.Name = "txtDESCRIPCION_SERVICIO"
        Me.txtDESCRIPCION_SERVICIO.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION_SERVICIO.Size = New System.Drawing.Size(307, 20)
        Me.txtDESCRIPCION_SERVICIO.TabIndex = 2
        '
        'cboCLASE_DE_SERVICIO
        '
        Me.cboCLASE_DE_SERVICIO.BackColor = System.Drawing.SystemColors.Window
        Me.cboCLASE_DE_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCLASE_DE_SERVICIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCLASE_DE_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCLASE_DE_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCLASE_DE_SERVICIO.Location = New System.Drawing.Point(134, 71)
        Me.cboCLASE_DE_SERVICIO.Name = "cboCLASE_DE_SERVICIO"
        Me.cboCLASE_DE_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCLASE_DE_SERVICIO.Size = New System.Drawing.Size(307, 22)
        Me.cboCLASE_DE_SERVICIO.TabIndex = 3
        '
        'lblTitCLASE_DE_SERVICIO
        '
        Me.lblTitCLASE_DE_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCLASE_DE_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCLASE_DE_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCLASE_DE_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCLASE_DE_SERVICIO.Location = New System.Drawing.Point(6, 74)
        Me.lblTitCLASE_DE_SERVICIO.Name = "lblTitCLASE_DE_SERVICIO"
        Me.lblTitCLASE_DE_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCLASE_DE_SERVICIO.Size = New System.Drawing.Size(122, 14)
        Me.lblTitCLASE_DE_SERVICIO.TabIndex = 5
        Me.lblTitCLASE_DE_SERVICIO.Text = "Clase de servicio"
        '
        'lblTitDESCRIPCION_SERVICIO
        '
        Me.lblTitDESCRIPCION_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_SERVICIO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitDESCRIPCION_SERVICIO.Name = "lblTitDESCRIPCION_SERVICIO"
        Me.lblTitDESCRIPCION_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_SERVICIO.Size = New System.Drawing.Size(122, 14)
        Me.lblTitDESCRIPCION_SERVICIO.TabIndex = 6
        Me.lblTitDESCRIPCION_SERVICIO.Text = "Descripción"
        '
        'lblTitTIPO_SERVICIO
        '
        Me.lblTitTIPO_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_SERVICIO.Location = New System.Drawing.Point(6, 21)
        Me.lblTitTIPO_SERVICIO.Name = "lblTitTIPO_SERVICIO"
        Me.lblTitTIPO_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_SERVICIO.Size = New System.Drawing.Size(122, 14)
        Me.lblTitTIPO_SERVICIO.TabIndex = 7
        Me.lblTitTIPO_SERVICIO.Text = "Tipo servicio"
        '
        'ACTTSAM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(488, 161)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTTSAM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de tipos de servicios de activos - ACTTSAM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    ' System.Windows.Forms.TextBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDESCRIPCION_SERVICIO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTIPO_SERVICIO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCLASE_DE_SERVICIO As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIPCION_SERVICIO As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_SERVICIO As System.Windows.Forms.Label
    Public WithEvents cboCLASE_DE_SERVICIO As System.Windows.Forms.ComboBox
End Class
