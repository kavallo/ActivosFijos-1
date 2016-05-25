<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTRESN0
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
        Me.SIN_RESP = New System.Windows.Forms.CheckBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.RESP_FIN = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.RESP_INI = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblRESP_FIN = New System.Windows.Forms.Label()
        Me.desRESP_FIN = New System.Windows.Forms.Label()
        Me.lblRESP_INI = New System.Windows.Forms.Label()
        Me.desRESP_INI = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SIN_RESP
        '
        Me.SIN_RESP.BackColor = System.Drawing.SystemColors.Control
        Me.SIN_RESP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SIN_RESP.Cursor = System.Windows.Forms.Cursors.Default
        Me.SIN_RESP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIN_RESP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SIN_RESP.Location = New System.Drawing.Point(12, 84)
        Me.SIN_RESP.Name = "SIN_RESP"
        Me.SIN_RESP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SIN_RESP.Size = New System.Drawing.Size(151, 19)
        Me.SIN_RESP.TabIndex = 11
        Me.SIN_RESP.Text = "Incluye SIN responsables"
        Me.SIN_RESP.UseVisualStyleBackColor = False
        Me.SIN_RESP.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(332, 115)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmdCancelar.TabIndex = 13
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(237, 115)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'RESP_FIN
        '
        Me.RESP_FIN.AcceptsReturn = True
        Me.RESP_FIN.BackColor = System.Drawing.SystemColors.Window
        Me.RESP_FIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RESP_FIN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RESP_FIN.EsRequerido = True
        Me.RESP_FIN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESP_FIN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RESP_FIN.LabelConsulta = Nothing
        Me.RESP_FIN.Location = New System.Drawing.Point(144, 49)
        Me.RESP_FIN.MaxLength = 5
        Me.RESP_FIN.Name = "RESP_FIN"
        Me.RESP_FIN.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeResponsablesDeActivosFijos_ACTRAFL0
        Me.RESP_FIN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RESP_FIN.Size = New System.Drawing.Size(58, 20)
        Me.RESP_FIN.TabIndex = 10
        '
        'RESP_INI
        '
        Me.RESP_INI.AcceptsReturn = True
        Me.RESP_INI.BackColor = System.Drawing.SystemColors.Window
        Me.RESP_INI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RESP_INI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RESP_INI.EsRequerido = True
        Me.RESP_INI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESP_INI.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RESP_INI.LabelConsulta = Nothing
        Me.RESP_INI.Location = New System.Drawing.Point(144, 23)
        Me.RESP_INI.MaxLength = 5
        Me.RESP_INI.Name = "RESP_INI"
        Me.RESP_INI.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeResponsablesDeActivosFijos_ACTRAFL0
        Me.RESP_INI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RESP_INI.Size = New System.Drawing.Size(58, 20)
        Me.RESP_INI.TabIndex = 9
        '
        'lblRESP_FIN
        '
        Me.lblRESP_FIN.BackColor = System.Drawing.Color.Transparent
        Me.lblRESP_FIN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRESP_FIN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRESP_FIN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblRESP_FIN.Location = New System.Drawing.Point(12, 51)
        Me.lblRESP_FIN.Name = "lblRESP_FIN"
        Me.lblRESP_FIN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRESP_FIN.Size = New System.Drawing.Size(126, 14)
        Me.lblRESP_FIN.TabIndex = 17
        Me.lblRESP_FIN.Text = "Responsable final"
        '
        'desRESP_FIN
        '
        Me.desRESP_FIN.BackColor = System.Drawing.Color.Transparent
        Me.desRESP_FIN.Cursor = System.Windows.Forms.Cursors.Default
        Me.desRESP_FIN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desRESP_FIN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.desRESP_FIN.Location = New System.Drawing.Point(219, 51)
        Me.desRESP_FIN.Name = "desRESP_FIN"
        Me.desRESP_FIN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.desRESP_FIN.Size = New System.Drawing.Size(202, 21)
        Me.desRESP_FIN.TabIndex = 16
        Me.desRESP_FIN.UseMnemonic = False
        '
        'lblRESP_INI
        '
        Me.lblRESP_INI.BackColor = System.Drawing.Color.Transparent
        Me.lblRESP_INI.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRESP_INI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRESP_INI.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblRESP_INI.Location = New System.Drawing.Point(12, 25)
        Me.lblRESP_INI.Name = "lblRESP_INI"
        Me.lblRESP_INI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRESP_INI.Size = New System.Drawing.Size(126, 14)
        Me.lblRESP_INI.TabIndex = 15
        Me.lblRESP_INI.Text = "Responsable inicial"
        '
        'desRESP_INI
        '
        Me.desRESP_INI.BackColor = System.Drawing.Color.Transparent
        Me.desRESP_INI.Cursor = System.Windows.Forms.Cursors.Default
        Me.desRESP_INI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desRESP_INI.ForeColor = System.Drawing.SystemColors.WindowText
        Me.desRESP_INI.Location = New System.Drawing.Point(219, 25)
        Me.desRESP_INI.Name = "desRESP_INI"
        Me.desRESP_INI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.desRESP_INI.Size = New System.Drawing.Size(202, 21)
        Me.desRESP_INI.TabIndex = 14
        Me.desRESP_INI.UseMnemonic = False
        '
        'ACTRESN0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(433, 152)
        Me.Controls.Add(Me.RESP_INI)
        Me.Controls.Add(Me.RESP_FIN)
        Me.Controls.Add(Me.SIN_RESP)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblRESP_FIN)
        Me.Controls.Add(Me.desRESP_FIN)
        Me.Controls.Add(Me.lblRESP_INI)
        Me.Controls.Add(Me.desRESP_INI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTRESN0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha de responsable - ACTRESN0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents SIN_RESP As System.Windows.Forms.CheckBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents RESP_FIN As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents RESP_INI As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblRESP_FIN As System.Windows.Forms.Label
    Public WithEvents desRESP_FIN As System.Windows.Forms.Label
    Public WithEvents lblRESP_INI As System.Windows.Forms.Label
    Public WithEvents desRESP_INI As System.Windows.Forms.Label
End Class
