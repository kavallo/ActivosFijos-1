<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTCUTCB
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
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtCUENTA_CONTABLE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIPCION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitDESCRIPCION = New System.Windows.Forms.Label()
        Me.lblTitCUENTA_CONTABLE = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtCUENTA_CONTABLE)
        Me.Frame1.Controls.Add(Me.txtDESCRIPCION)
        Me.Frame1.Controls.Add(Me.lblTitDESCRIPCION)
        Me.Frame1.Controls.Add(Me.lblTitCUENTA_CONTABLE)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(492, 73)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'txtCUENTA_CONTABLE
        '
        Me.txtCUENTA_CONTABLE.AcceptsReturn = True
        Me.txtCUENTA_CONTABLE.BackColor = System.Drawing.SystemColors.Window
        Me.txtCUENTA_CONTABLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUENTA_CONTABLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCUENTA_CONTABLE.EsRequerido = True
        Me.txtCUENTA_CONTABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUENTA_CONTABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCUENTA_CONTABLE.LabelConsulta = Nothing
        Me.txtCUENTA_CONTABLE.Location = New System.Drawing.Point(114, 19)
        Me.txtCUENTA_CONTABLE.MaxLength = 30
        Me.txtCUENTA_CONTABLE.Name = "txtCUENTA_CONTABLE"
        Me.txtCUENTA_CONTABLE.NombreDeConsulta = Nothing
        Me.txtCUENTA_CONTABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_CONTABLE.Size = New System.Drawing.Size(347, 20)
        Me.txtCUENTA_CONTABLE.TabIndex = 0
        '
        'txtDESCRIPCION
        '
        Me.txtDESCRIPCION.AcceptsReturn = True
        Me.txtDESCRIPCION.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION.EsRequerido = True
        Me.txtDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION.LabelConsulta = Nothing
        Me.txtDESCRIPCION.Location = New System.Drawing.Point(114, 45)
        Me.txtDESCRIPCION.MaxLength = 40
        Me.txtDESCRIPCION.Name = "txtDESCRIPCION"
        Me.txtDESCRIPCION.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION.Size = New System.Drawing.Size(347, 20)
        Me.txtDESCRIPCION.TabIndex = 1
        '
        'lblTitDESCRIPCION
        '
        Me.lblTitDESCRIPCION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION.Location = New System.Drawing.Point(6, 47)
        Me.lblTitDESCRIPCION.Name = "lblTitDESCRIPCION"
        Me.lblTitDESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION.Size = New System.Drawing.Size(102, 14)
        Me.lblTitDESCRIPCION.TabIndex = 4
        Me.lblTitDESCRIPCION.Text = "Descripcion"
        '
        'lblTitCUENTA_CONTABLE
        '
        Me.lblTitCUENTA_CONTABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_CONTABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_CONTABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_CONTABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_CONTABLE.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCUENTA_CONTABLE.Name = "lblTitCUENTA_CONTABLE"
        Me.lblTitCUENTA_CONTABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_CONTABLE.Size = New System.Drawing.Size(102, 14)
        Me.lblTitCUENTA_CONTABLE.TabIndex = 5
        Me.lblTitCUENTA_CONTABLE.Text = "Cuenta contable"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(324, 91)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 1
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
        Me.cmdCancelar.Location = New System.Drawing.Point(417, 91)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'ACTCUTCB
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(516, 128)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTCUTCB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas contables - ACTCUTCB"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDESCRIPCION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCUENTA_CONTABLE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitDESCRIPCION As System.Windows.Forms.Label
    Public WithEvents lblTitCUENTA_CONTABLE As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
