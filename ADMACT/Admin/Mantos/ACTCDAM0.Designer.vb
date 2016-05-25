<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTCDAM0
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
        Me.txtCATEGORIA_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCATEGORIA_DESC = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCATEGORIA_DESC = New System.Windows.Forms.Label()
        Me.lblTitCATEGORIA_ID = New System.Windows.Forms.Label()
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
        Me.Frame1.Controls.Add(Me.txtCATEGORIA_ID)
        Me.Frame1.Controls.Add(Me.txtCATEGORIA_DESC)
        Me.Frame1.Controls.Add(Me.lblTitCATEGORIA_DESC)
        Me.Frame1.Controls.Add(Me.lblTitCATEGORIA_ID)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(474, 73)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtCATEGORIA_ID
        '
        Me.txtCATEGORIA_ID.AcceptsReturn = True
        Me.txtCATEGORIA_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCATEGORIA_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCATEGORIA_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCATEGORIA_ID.EsRequerido = True
        Me.txtCATEGORIA_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATEGORIA_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCATEGORIA_ID.LabelConsulta = Nothing
        Me.txtCATEGORIA_ID.Location = New System.Drawing.Point(109, 19)
        Me.txtCATEGORIA_ID.MaxLength = 5
        Me.txtCATEGORIA_ID.Name = "txtCATEGORIA_ID"
        Me.txtCATEGORIA_ID.NombreDeConsulta = Nothing
        Me.txtCATEGORIA_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCATEGORIA_ID.Size = New System.Drawing.Size(52, 20)
        Me.txtCATEGORIA_ID.TabIndex = 0
        '
        'txtCATEGORIA_DESC
        '
        Me.txtCATEGORIA_DESC.AcceptsReturn = True
        Me.txtCATEGORIA_DESC.BackColor = System.Drawing.SystemColors.Window
        Me.txtCATEGORIA_DESC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCATEGORIA_DESC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCATEGORIA_DESC.EsRequerido = True
        Me.txtCATEGORIA_DESC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATEGORIA_DESC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCATEGORIA_DESC.LabelConsulta = Nothing
        Me.txtCATEGORIA_DESC.Location = New System.Drawing.Point(109, 45)
        Me.txtCATEGORIA_DESC.MaxLength = 40
        Me.txtCATEGORIA_DESC.Name = "txtCATEGORIA_DESC"
        Me.txtCATEGORIA_DESC.NombreDeConsulta = Nothing
        Me.txtCATEGORIA_DESC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCATEGORIA_DESC.Size = New System.Drawing.Size(347, 20)
        Me.txtCATEGORIA_DESC.TabIndex = 1
        '
        'lblTitCATEGORIA_DESC
        '
        Me.lblTitCATEGORIA_DESC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCATEGORIA_DESC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCATEGORIA_DESC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCATEGORIA_DESC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCATEGORIA_DESC.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCATEGORIA_DESC.Name = "lblTitCATEGORIA_DESC"
        Me.lblTitCATEGORIA_DESC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCATEGORIA_DESC.Size = New System.Drawing.Size(97, 14)
        Me.lblTitCATEGORIA_DESC.TabIndex = 4
        Me.lblTitCATEGORIA_DESC.Text = "Descripción"
        '
        'lblTitCATEGORIA_ID
        '
        Me.lblTitCATEGORIA_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCATEGORIA_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCATEGORIA_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCATEGORIA_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCATEGORIA_ID.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCATEGORIA_ID.Name = "lblTitCATEGORIA_ID"
        Me.lblTitCATEGORIA_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCATEGORIA_ID.Size = New System.Drawing.Size(97, 14)
        Me.lblTitCATEGORIA_ID.TabIndex = 5
        Me.lblTitCATEGORIA_ID.Text = "Categoría"
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
        'ACTCDAM0
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
        Me.Name = "ACTCDAM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de categorias de activos fijos - ACTCDAM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtCATEGORIA_DESC As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCATEGORIA_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCATEGORIA_DESC As System.Windows.Forms.Label
    Public WithEvents lblTitCATEGORIA_ID As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
