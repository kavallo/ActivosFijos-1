<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTPRVB
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
        Me.txtCODIGO_CLASE_PROVEEDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIPCION_CLASE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitDESCRIPCION_CLASE = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CLASE_PROVEEDOR = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtCODIGO_CLASE_PROVEEDOR)
        Me.Frame1.Controls.Add(Me.txtDESCRIPCION_CLASE)
        Me.Frame1.Controls.Add(Me.lblTitDESCRIPCION_CLASE)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_CLASE_PROVEEDOR)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(474, 73)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtCODIGO_CLASE_PROVEEDOR
        '
        Me.txtCODIGO_CLASE_PROVEEDOR.AcceptsReturn = True
        Me.txtCODIGO_CLASE_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_CLASE_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_CLASE_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_CLASE_PROVEEDOR.EsRequerido = True
        Me.txtCODIGO_CLASE_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_CLASE_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_CLASE_PROVEEDOR.LabelConsulta = Nothing
        Me.txtCODIGO_CLASE_PROVEEDOR.Location = New System.Drawing.Point(111, 19)
        Me.txtCODIGO_CLASE_PROVEEDOR.MaxLength = 5
        Me.txtCODIGO_CLASE_PROVEEDOR.Name = "txtCODIGO_CLASE_PROVEEDOR"
        Me.txtCODIGO_CLASE_PROVEEDOR.NombreDeConsulta = Nothing
        Me.txtCODIGO_CLASE_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CLASE_PROVEEDOR.Size = New System.Drawing.Size(52, 20)
        Me.txtCODIGO_CLASE_PROVEEDOR.TabIndex = 0
        Me.txtCODIGO_CLASE_PROVEEDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDESCRIPCION_CLASE
        '
        Me.txtDESCRIPCION_CLASE.AcceptsReturn = True
        Me.txtDESCRIPCION_CLASE.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION_CLASE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION_CLASE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION_CLASE.EsRequerido = True
        Me.txtDESCRIPCION_CLASE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION_CLASE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION_CLASE.LabelConsulta = Nothing
        Me.txtDESCRIPCION_CLASE.Location = New System.Drawing.Point(111, 45)
        Me.txtDESCRIPCION_CLASE.MaxLength = 40
        Me.txtDESCRIPCION_CLASE.Name = "txtDESCRIPCION_CLASE"
        Me.txtDESCRIPCION_CLASE.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION_CLASE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION_CLASE.Size = New System.Drawing.Size(347, 20)
        Me.txtDESCRIPCION_CLASE.TabIndex = 1
        '
        'lblTitDESCRIPCION_CLASE
        '
        Me.lblTitDESCRIPCION_CLASE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION_CLASE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_CLASE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_CLASE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_CLASE.Location = New System.Drawing.Point(6, 47)
        Me.lblTitDESCRIPCION_CLASE.Name = "lblTitDESCRIPCION_CLASE"
        Me.lblTitDESCRIPCION_CLASE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_CLASE.Size = New System.Drawing.Size(99, 14)
        Me.lblTitDESCRIPCION_CLASE.TabIndex = 4
        Me.lblTitDESCRIPCION_CLASE.Text = "Descripcion"
        '
        'lblTitCODIGO_CLASE_PROVEEDOR
        '
        Me.lblTitCODIGO_CLASE_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CLASE_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CLASE_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CLASE_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CLASE_PROVEEDOR.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCODIGO_CLASE_PROVEEDOR.Name = "lblTitCODIGO_CLASE_PROVEEDOR"
        Me.lblTitCODIGO_CLASE_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CLASE_PROVEEDOR.Size = New System.Drawing.Size(99, 14)
        Me.lblTitCODIGO_CLASE_PROVEEDOR.TabIndex = 5
        Me.lblTitCODIGO_CLASE_PROVEEDOR.Text = "Codigo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(399, 91)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(306, 91)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTPRVB
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(498, 128)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTPRVB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de clases de proveedores - ACTPRVB"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDESCRIPCION_CLASE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_CLASE_PROVEEDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitDESCRIPCION_CLASE As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CLASE_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
