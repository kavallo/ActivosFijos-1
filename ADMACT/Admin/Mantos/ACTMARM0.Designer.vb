<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMARM0
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
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cboValorOmision = New System.Windows.Forms.ComboBox()
        Me.txtCODIGO_MARCA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIPCION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblcodigo_marca = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblValorOmision = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
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
        Me.Frame1.Controls.Add(Me.cboValorOmision)
        Me.Frame1.Controls.Add(Me.txtCODIGO_MARCA)
        Me.Frame1.Controls.Add(Me.txtDESCRIPCION)
        Me.Frame1.Controls.Add(Me.lblcodigo_marca)
        Me.Frame1.Controls.Add(Me.lblDescripcion)
        Me.Frame1.Controls.Add(Me.lblValorOmision)
        Me.Frame1.Controls.Add(Me.lblDESCRIPCION_DIVISION)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(494, 103)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'cboValorOmision
        '
        Me.cboValorOmision.BackColor = System.Drawing.SystemColors.Window
        Me.cboValorOmision.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboValorOmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboValorOmision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboValorOmision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboValorOmision.Location = New System.Drawing.Point(110, 71)
        Me.cboValorOmision.Name = "cboValorOmision"
        Me.cboValorOmision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboValorOmision.Size = New System.Drawing.Size(174, 22)
        Me.cboValorOmision.TabIndex = 2
        '
        'txtCODIGO_MARCA
        '
        Me.txtCODIGO_MARCA.AcceptsReturn = True
        Me.txtCODIGO_MARCA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_MARCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_MARCA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_MARCA.EsRequerido = True
        Me.txtCODIGO_MARCA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_MARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_MARCA.LabelConsulta = Nothing
        Me.txtCODIGO_MARCA.Location = New System.Drawing.Point(110, 19)
        Me.txtCODIGO_MARCA.MaxLength = 5
        Me.txtCODIGO_MARCA.Name = "txtCODIGO_MARCA"
        Me.txtCODIGO_MARCA.NombreDeConsulta = Nothing
        Me.txtCODIGO_MARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_MARCA.Size = New System.Drawing.Size(52, 20)
        Me.txtCODIGO_MARCA.TabIndex = 0
        '
        'txtDESCRIPCION
        '
        Me.txtDESCRIPCION.AcceptsReturn = True
        Me.txtDESCRIPCION.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION.EsRequerido = True
        Me.txtDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION.LabelConsulta = Nothing
        Me.txtDESCRIPCION.Location = New System.Drawing.Point(110, 45)
        Me.txtDESCRIPCION.MaxLength = 40
        Me.txtDESCRIPCION.Name = "txtDESCRIPCION"
        Me.txtDESCRIPCION.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION.Size = New System.Drawing.Size(359, 20)
        Me.txtDESCRIPCION.TabIndex = 1
        '
        'lblcodigo_marca
        '
        Me.lblcodigo_marca.BackColor = System.Drawing.Color.Transparent
        Me.lblcodigo_marca.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcodigo_marca.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo_marca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblcodigo_marca.Location = New System.Drawing.Point(6, 21)
        Me.lblcodigo_marca.Name = "lblcodigo_marca"
        Me.lblcodigo_marca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcodigo_marca.Size = New System.Drawing.Size(98, 14)
        Me.lblcodigo_marca.TabIndex = 9
        Me.lblcodigo_marca.Text = "Código"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 47)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcion.Size = New System.Drawing.Size(98, 14)
        Me.lblDescripcion.TabIndex = 8
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblValorOmision
        '
        Me.lblValorOmision.BackColor = System.Drawing.Color.Transparent
        Me.lblValorOmision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblValorOmision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorOmision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblValorOmision.Location = New System.Drawing.Point(6, 74)
        Me.lblValorOmision.Name = "lblValorOmision"
        Me.lblValorOmision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblValorOmision.Size = New System.Drawing.Size(98, 14)
        Me.lblValorOmision.TabIndex = 7
        Me.lblValorOmision.Text = "Valor omisión"
        '
        'lblDESCRIPCION_DIVISION
        '
        Me.lblDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_DIVISION.Location = New System.Drawing.Point(232, 184)
        Me.lblDESCRIPCION_DIVISION.Name = "lblDESCRIPCION_DIVISION"
        Me.lblDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_DIVISION.Size = New System.Drawing.Size(473, 21)
        Me.lblDESCRIPCION_DIVISION.TabIndex = 6
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(419, 121)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(326, 121)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTMARM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(518, 158)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMARM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de marcas - ACTMARM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtCODIGO_MARCA As Citi.Synergia.UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents txtDESCRIPCION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblcodigo_marca As System.Windows.Forms.Label
    Public WithEvents lblDescripcion As System.Windows.Forms.Label
    Public WithEvents lblValorOmision As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cboValorOmision As System.Windows.Forms.ComboBox
End Class
