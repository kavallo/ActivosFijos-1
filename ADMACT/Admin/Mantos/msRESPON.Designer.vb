<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msRESPON
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
        Me.txtCODIGO_RESPONSABLE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNOMBRE_RESPONSABLE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboESTADO_RESPONSABLE = New System.Windows.Forms.ComboBox()
        Me.lblTitESTADO_RESPONSABLE = New System.Windows.Forms.Label()
        Me.lblTitNOMBRE_RESPONSABLE = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_RESPONSABLE = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblCODIGO_DIVISION = New System.Windows.Forms.Label()
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
        Me.Frame1.Controls.Add(Me.txtCODIGO_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.txtNOMBRE_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.cboESTADO_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.lblTitESTADO_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.lblTitNOMBRE_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.Frame1.Controls.Add(Me.lblCODIGO_DIVISION)
        Me.Frame1.Controls.Add(Me.lblDESCRIPCION_DIVISION)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(492, 120)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'txtCODIGO_RESPONSABLE
        '
        Me.txtCODIGO_RESPONSABLE.AcceptsReturn = True
        Me.txtCODIGO_RESPONSABLE.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_RESPONSABLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_RESPONSABLE.EsRequerido = True
        Me.txtCODIGO_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_RESPONSABLE.LabelConsulta = Nothing
        Me.txtCODIGO_RESPONSABLE.Location = New System.Drawing.Point(139, 41)
        Me.txtCODIGO_RESPONSABLE.MaxLength = 6
        Me.txtCODIGO_RESPONSABLE.Name = "txtCODIGO_RESPONSABLE"
        Me.txtCODIGO_RESPONSABLE.NombreDeConsulta = Nothing
        Me.txtCODIGO_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_RESPONSABLE.Size = New System.Drawing.Size(52, 20)
        Me.txtCODIGO_RESPONSABLE.TabIndex = 2
        '
        'txtNOMBRE_RESPONSABLE
        '
        Me.txtNOMBRE_RESPONSABLE.AcceptsReturn = True
        Me.txtNOMBRE_RESPONSABLE.BackColor = System.Drawing.SystemColors.Window
        Me.txtNOMBRE_RESPONSABLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNOMBRE_RESPONSABLE.EsRequerido = True
        Me.txtNOMBRE_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNOMBRE_RESPONSABLE.LabelConsulta = Nothing
        Me.txtNOMBRE_RESPONSABLE.Location = New System.Drawing.Point(139, 66)
        Me.txtNOMBRE_RESPONSABLE.MaxLength = 40
        Me.txtNOMBRE_RESPONSABLE.Name = "txtNOMBRE_RESPONSABLE"
        Me.txtNOMBRE_RESPONSABLE.NombreDeConsulta = Nothing
        Me.txtNOMBRE_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNOMBRE_RESPONSABLE.Size = New System.Drawing.Size(330, 20)
        Me.txtNOMBRE_RESPONSABLE.TabIndex = 3
        '
        'cboESTADO_RESPONSABLE
        '
        Me.cboESTADO_RESPONSABLE.BackColor = System.Drawing.SystemColors.Window
        Me.cboESTADO_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboESTADO_RESPONSABLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboESTADO_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboESTADO_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboESTADO_RESPONSABLE.Location = New System.Drawing.Point(139, 92)
        Me.cboESTADO_RESPONSABLE.Name = "cboESTADO_RESPONSABLE"
        Me.cboESTADO_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboESTADO_RESPONSABLE.Size = New System.Drawing.Size(275, 22)
        Me.cboESTADO_RESPONSABLE.TabIndex = 4
        '
        'lblTitESTADO_RESPONSABLE
        '
        Me.lblTitESTADO_RESPONSABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTADO_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTADO_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTADO_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTADO_RESPONSABLE.Location = New System.Drawing.Point(6, 95)
        Me.lblTitESTADO_RESPONSABLE.Name = "lblTitESTADO_RESPONSABLE"
        Me.lblTitESTADO_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTADO_RESPONSABLE.Size = New System.Drawing.Size(127, 14)
        Me.lblTitESTADO_RESPONSABLE.TabIndex = 15
        Me.lblTitESTADO_RESPONSABLE.Text = "Estado responsable"
        '
        'lblTitNOMBRE_RESPONSABLE
        '
        Me.lblTitNOMBRE_RESPONSABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNOMBRE_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNOMBRE_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNOMBRE_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNOMBRE_RESPONSABLE.Location = New System.Drawing.Point(6, 68)
        Me.lblTitNOMBRE_RESPONSABLE.Name = "lblTitNOMBRE_RESPONSABLE"
        Me.lblTitNOMBRE_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNOMBRE_RESPONSABLE.Size = New System.Drawing.Size(127, 14)
        Me.lblTitNOMBRE_RESPONSABLE.TabIndex = 16
        Me.lblTitNOMBRE_RESPONSABLE.Text = "Nombre responsable"
        '
        'lblTitCODIGO_RESPONSABLE
        '
        Me.lblTitCODIGO_RESPONSABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_RESPONSABLE.Location = New System.Drawing.Point(6, 43)
        Me.lblTitCODIGO_RESPONSABLE.Name = "lblTitCODIGO_RESPONSABLE"
        Me.lblTitCODIGO_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_RESPONSABLE.Size = New System.Drawing.Size(127, 14)
        Me.lblTitCODIGO_RESPONSABLE.TabIndex = 17
        Me.lblTitCODIGO_RESPONSABLE.Text = "Código responsable"
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(6, 17)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(127, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 18
        Me.lblTitCODIGO_DIVISION.Text = "Código departamento"
        '
        'lblCODIGO_DIVISION
        '
        Me.lblCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DIVISION.Location = New System.Drawing.Point(139, 16)
        Me.lblCODIGO_DIVISION.Name = "lblCODIGO_DIVISION"
        Me.lblCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DIVISION.Size = New System.Drawing.Size(52, 20)
        Me.lblCODIGO_DIVISION.TabIndex = 1
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
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(417, 138)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(324, 138)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'msRESPON
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 175)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "msRESPON"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de responsables de departamentos - msRESPON"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    ' System.Windows.Forms.TextBox
    Public WithEvents lblDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents txtNOMBRE_RESPONSABLE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_RESPONSABLE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitESTADO_RESPONSABLE As System.Windows.Forms.Label
    Public WithEvents lblTitNOMBRE_RESPONSABLE As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_RESPONSABLE As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents cboESTADO_RESPONSABLE As System.Windows.Forms.ComboBox
End Class
