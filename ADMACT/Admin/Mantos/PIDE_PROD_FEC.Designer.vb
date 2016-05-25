<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIDE_PROD_FEC
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
        Me.mskFECHA_INI = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.mskFECHA_FIN = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtPRODUCT0 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mskFECHA_INI
        '
        Me.mskFECHA_INI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFECHA_INI.EsRequerido = True
        Me.mskFECHA_INI.Location = New System.Drawing.Point(110, 19)
        Me.mskFECHA_INI.Mask = "00/00/0000"
        Me.mskFECHA_INI.Name = "mskFECHA_INI"
        Me.mskFECHA_INI.Size = New System.Drawing.Size(129, 20)
        Me.mskFECHA_INI.TabIndex = 1
        Me.mskFECHA_INI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFECHA_INI.ValidatingType = GetType(Date)
        '
        'mskFECHA_FIN
        '
        Me.mskFECHA_FIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFECHA_FIN.EsRequerido = True
        Me.mskFECHA_FIN.Location = New System.Drawing.Point(110, 45)
        Me.mskFECHA_FIN.Mask = "00/00/0000"
        Me.mskFECHA_FIN.Name = "mskFECHA_FIN"
        Me.mskFECHA_FIN.Size = New System.Drawing.Size(129, 20)
        Me.mskFECHA_FIN.TabIndex = 2
        Me.mskFECHA_FIN.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFECHA_FIN.ValidatingType = GetType(Date)
        '
        'txtPRODUCT0
        '
        Me.txtPRODUCT0.AcceptsReturn = True
        Me.txtPRODUCT0.BackColor = System.Drawing.SystemColors.Window
        Me.txtPRODUCT0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPRODUCT0.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPRODUCT0.EsRequerido = True
        Me.txtPRODUCT0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRODUCT0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPRODUCT0.LabelConsulta = Nothing
        Me.txtPRODUCT0.Location = New System.Drawing.Point(110, 71)
        Me.txtPRODUCT0.MaxLength = 25
        Me.txtPRODUCT0.Name = "txtPRODUCT0"
        Me.txtPRODUCT0.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeProductos_MPRODC01
        Me.txtPRODUCT0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPRODUCT0.Size = New System.Drawing.Size(185, 20)
        Me.txtPRODUCT0.TabIndex = 3
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(207, 118)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
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
        Me.cmdCancelar.Location = New System.Drawing.Point(300, 118)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(265, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "(DD/MM/AAAA)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(265, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "(DD/MM/AAAA)"
        '
        'lblProducto
        '
        Me.lblProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblProducto.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblProducto.Location = New System.Drawing.Point(6, 73)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProducto.Size = New System.Drawing.Size(98, 20)
        Me.lblProducto.TabIndex = 17
        Me.lblProducto.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha Inicial"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.mskFECHA_INI)
        Me.Frame1.Controls.Add(Me.mskFECHA_FIN)
        Me.Frame1.Controls.Add(Me.txtPRODUCT0)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.lblProducto)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(375, 100)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'PIDE_PROD_FEC
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(399, 155)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "PIDE_PROD_FEC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedores por producto - PIDE_PROD_FEC"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents mskFECHA_INI As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents mskFECHA_FIN As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents txtPRODUCT0 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lblProducto As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
End Class
