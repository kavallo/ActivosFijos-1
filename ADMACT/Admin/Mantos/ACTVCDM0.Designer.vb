<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTVCDM0
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
        Me.txtCAMPO_VALOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCAMPO_DESCRIPCION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCAMPO_DESCRIPCION = New System.Windows.Forms.Label()
        Me.lblTitCAMPO_VALOR = New System.Windows.Forms.Label()
        Me.lblTitCAMPO_ID = New System.Windows.Forms.Label()
        Me.lblCAMPO_ID = New System.Windows.Forms.Label()
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
        Me.cmdCancelar.Location = New System.Drawing.Point(428, 109)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(335, 109)
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
        Me.Frame1.Controls.Add(Me.txtCAMPO_VALOR)
        Me.Frame1.Controls.Add(Me.txtCAMPO_DESCRIPCION)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_DESCRIPCION)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_VALOR)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_ID)
        Me.Frame1.Controls.Add(Me.lblCAMPO_ID)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(503, 91)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtCAMPO_VALOR
        '
        Me.txtCAMPO_VALOR.AcceptsReturn = True
        Me.txtCAMPO_VALOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtCAMPO_VALOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCAMPO_VALOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCAMPO_VALOR.EsRequerido = True
        Me.txtCAMPO_VALOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAMPO_VALOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCAMPO_VALOR.LabelConsulta = Nothing
        Me.txtCAMPO_VALOR.Location = New System.Drawing.Point(117, 40)
        Me.txtCAMPO_VALOR.MaxLength = 30
        Me.txtCAMPO_VALOR.Name = "txtCAMPO_VALOR"
        Me.txtCAMPO_VALOR.NombreDeConsulta = Nothing
        Me.txtCAMPO_VALOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCAMPO_VALOR.Size = New System.Drawing.Size(130, 20)
        Me.txtCAMPO_VALOR.TabIndex = 2
        '
        'txtCAMPO_DESCRIPCION
        '
        Me.txtCAMPO_DESCRIPCION.AcceptsReturn = True
        Me.txtCAMPO_DESCRIPCION.BackColor = System.Drawing.SystemColors.Window
        Me.txtCAMPO_DESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCAMPO_DESCRIPCION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCAMPO_DESCRIPCION.EsRequerido = True
        Me.txtCAMPO_DESCRIPCION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAMPO_DESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCAMPO_DESCRIPCION.LabelConsulta = Nothing
        Me.txtCAMPO_DESCRIPCION.Location = New System.Drawing.Point(117, 64)
        Me.txtCAMPO_DESCRIPCION.MaxLength = 80
        Me.txtCAMPO_DESCRIPCION.Name = "txtCAMPO_DESCRIPCION"
        Me.txtCAMPO_DESCRIPCION.NombreDeConsulta = Nothing
        Me.txtCAMPO_DESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCAMPO_DESCRIPCION.Size = New System.Drawing.Size(347, 20)
        Me.txtCAMPO_DESCRIPCION.TabIndex = 3
        '
        'lblTitCAMPO_DESCRIPCION
        '
        Me.lblTitCAMPO_DESCRIPCION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_DESCRIPCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_DESCRIPCION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_DESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_DESCRIPCION.Location = New System.Drawing.Point(6, 66)
        Me.lblTitCAMPO_DESCRIPCION.Name = "lblTitCAMPO_DESCRIPCION"
        Me.lblTitCAMPO_DESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_DESCRIPCION.Size = New System.Drawing.Size(105, 14)
        Me.lblTitCAMPO_DESCRIPCION.TabIndex = 4
        Me.lblTitCAMPO_DESCRIPCION.Text = "Descripción"
        '
        'lblTitCAMPO_VALOR
        '
        Me.lblTitCAMPO_VALOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_VALOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_VALOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_VALOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_VALOR.Location = New System.Drawing.Point(6, 42)
        Me.lblTitCAMPO_VALOR.Name = "lblTitCAMPO_VALOR"
        Me.lblTitCAMPO_VALOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_VALOR.Size = New System.Drawing.Size(105, 14)
        Me.lblTitCAMPO_VALOR.TabIndex = 5
        Me.lblTitCAMPO_VALOR.Text = "Valor"
        '
        'lblTitCAMPO_ID
        '
        Me.lblTitCAMPO_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_ID.Location = New System.Drawing.Point(6, 17)
        Me.lblTitCAMPO_ID.Name = "lblTitCAMPO_ID"
        Me.lblTitCAMPO_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_ID.Size = New System.Drawing.Size(105, 14)
        Me.lblTitCAMPO_ID.TabIndex = 6
        Me.lblTitCAMPO_ID.Text = "Campo"
        '
        'lblCAMPO_ID
        '
        Me.lblCAMPO_ID.BackColor = System.Drawing.SystemColors.Window
        Me.lblCAMPO_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCAMPO_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCAMPO_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAMPO_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCAMPO_ID.Location = New System.Drawing.Point(117, 16)
        Me.lblCAMPO_ID.Name = "lblCAMPO_ID"
        Me.lblCAMPO_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCAMPO_ID.Size = New System.Drawing.Size(347, 20)
        Me.lblCAMPO_ID.TabIndex = 1
        '
        'ACTVCDM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(527, 146)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTVCDM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de lista de valores de campos - ACTVCDM0"
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
    Public WithEvents txtCAMPO_DESCRIPCION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCAMPO_VALOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCAMPO_DESCRIPCION As System.Windows.Forms.Label
    Public WithEvents lblTitCAMPO_VALOR As System.Windows.Forms.Label
    Public WithEvents lblTitCAMPO_ID As System.Windows.Forms.Label
    Public WithEvents lblCAMPO_ID As System.Windows.Forms.Label
End Class
