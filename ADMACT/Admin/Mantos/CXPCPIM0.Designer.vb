<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CXPCPIM0
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
        Me.txtCODIGO_IMPUESTO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblnombre_proveedor = New System.Windows.Forms.Label()
        Me.lblCODIGO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_IMPUESTO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_IMPUESTO = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCODIGO_IMPUESTO
        '
        Me.txtCODIGO_IMPUESTO.AcceptsReturn = True
        Me.txtCODIGO_IMPUESTO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_IMPUESTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_IMPUESTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_IMPUESTO.EsRequerido = True
        Me.txtCODIGO_IMPUESTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_IMPUESTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_IMPUESTO.LabelConsulta = Nothing
        Me.txtCODIGO_IMPUESTO.Location = New System.Drawing.Point(96, 44)
        Me.txtCODIGO_IMPUESTO.MaxLength = 3
        Me.txtCODIGO_IMPUESTO.Name = "txtCODIGO_IMPUESTO"
        Me.txtCODIGO_IMPUESTO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeImpuestos_IMPUEC01
        Me.txtCODIGO_IMPUESTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_IMPUESTO.Size = New System.Drawing.Size(59, 20)
        Me.txtCODIGO_IMPUESTO.TabIndex = 2
        Me.txtCODIGO_IMPUESTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(261, 78)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 3
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
        Me.cmdCancelar.Location = New System.Drawing.Point(354, 77)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblnombre_proveedor
        '
        Me.lblnombre_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombre_proveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombre_proveedor.Location = New System.Drawing.Point(236, 22)
        Me.lblnombre_proveedor.Name = "lblnombre_proveedor"
        Me.lblnombre_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombre_proveedor.Size = New System.Drawing.Size(205, 20)
        Me.lblnombre_proveedor.TabIndex = 15
        Me.lblnombre_proveedor.UseMnemonic = False
        '
        'lblCODIGO_PROVEEDOR
        '
        Me.lblCODIGO_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_PROVEEDOR.Location = New System.Drawing.Point(96, 21)
        Me.lblCODIGO_PROVEEDOR.Name = "lblCODIGO_PROVEEDOR"
        Me.lblCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_PROVEEDOR.Size = New System.Drawing.Size(118, 20)
        Me.lblCODIGO_PROVEEDOR.TabIndex = 1
        Me.lblCODIGO_PROVEEDOR.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDESCRIPCION_IMPUESTO
        '
        Me.lblDESCRIPCION_IMPUESTO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_IMPUESTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_IMPUESTO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_IMPUESTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_IMPUESTO.Location = New System.Drawing.Point(175, 46)
        Me.lblDESCRIPCION_IMPUESTO.Name = "lblDESCRIPCION_IMPUESTO"
        Me.lblDESCRIPCION_IMPUESTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_IMPUESTO.Size = New System.Drawing.Size(266, 20)
        Me.lblDESCRIPCION_IMPUESTO.TabIndex = 10
        Me.lblDESCRIPCION_IMPUESTO.UseMnemonic = False
        '
        'lblTitCODIGO_PROVEEDOR
        '
        Me.lblTitCODIGO_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_PROVEEDOR.Location = New System.Drawing.Point(12, 22)
        Me.lblTitCODIGO_PROVEEDOR.Name = "lblTitCODIGO_PROVEEDOR"
        Me.lblTitCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_PROVEEDOR.Size = New System.Drawing.Size(78, 14)
        Me.lblTitCODIGO_PROVEEDOR.TabIndex = 11
        Me.lblTitCODIGO_PROVEEDOR.Text = "Proveedor"
        '
        'lblTitCODIGO_IMPUESTO
        '
        Me.lblTitCODIGO_IMPUESTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_IMPUESTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_IMPUESTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_IMPUESTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_IMPUESTO.Location = New System.Drawing.Point(12, 46)
        Me.lblTitCODIGO_IMPUESTO.Name = "lblTitCODIGO_IMPUESTO"
        Me.lblTitCODIGO_IMPUESTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_IMPUESTO.Size = New System.Drawing.Size(78, 14)
        Me.lblTitCODIGO_IMPUESTO.TabIndex = 12
        Me.lblTitCODIGO_IMPUESTO.Text = "Impuesto"
        '
        'CXPCPIM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(453, 114)
        Me.Controls.Add(Me.txtCODIGO_IMPUESTO)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblnombre_proveedor)
        Me.Controls.Add(Me.lblCODIGO_PROVEEDOR)
        Me.Controls.Add(Me.lblDESCRIPCION_IMPUESTO)
        Me.Controls.Add(Me.lblTitCODIGO_PROVEEDOR)
        Me.Controls.Add(Me.lblTitCODIGO_IMPUESTO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "CXPCPIM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de impuestos por proveedor - CXPCPIM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtCODIGO_IMPUESTO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents lblnombre_proveedor As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_IMPUESTO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_IMPUESTO As System.Windows.Forms.Label
End Class
