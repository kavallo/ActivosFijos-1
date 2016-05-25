<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN6
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtFechaFin = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaMaskInicial = New System.Windows.Forms.Label()
        Me.lblFechaMaskFinal = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(186, 74)
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
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(279, 74)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'txtFechaFin
        '
        Me.txtFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaFin.EsRequerido = True
        Me.txtFechaFin.Location = New System.Drawing.Point(87, 41)
        Me.txtFechaFin.Mask = "00/00/0000"
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(172, 20)
        Me.txtFechaFin.TabIndex = 2
        Me.txtFechaFin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFechaFin.ValidatingType = GetType(Date)
        '
        'lblFechaFin
        '
        Me.lblFechaFin.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaFin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaFin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaFin.Location = New System.Drawing.Point(17, 43)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaFin.Size = New System.Drawing.Size(64, 14)
        Me.lblFechaFin.TabIndex = 14
        Me.lblFechaFin.Text = "Al :"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaInicio.EsRequerido = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(87, 15)
        Me.txtFechaInicio.Mask = "00/00/0000"
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(172, 20)
        Me.txtFechaInicio.TabIndex = 1
        Me.txtFechaInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFechaInicio.ValidatingType = GetType(Date)
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaInicio.Location = New System.Drawing.Point(17, 17)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaInicio.Size = New System.Drawing.Size(64, 14)
        Me.lblFechaInicio.TabIndex = 13
        Me.lblFechaInicio.Text = "Del :"
        '
        'lblFechaMaskInicial
        '
        Me.lblFechaMaskInicial.AutoSize = True
        Me.lblFechaMaskInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaMaskInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaMaskInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMaskInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaMaskInicial.Location = New System.Drawing.Point(283, 17)
        Me.lblFechaMaskInicial.Name = "lblFechaMaskInicial"
        Me.lblFechaMaskInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaMaskInicial.Size = New System.Drawing.Size(83, 14)
        Me.lblFechaMaskInicial.TabIndex = 11
        Me.lblFechaMaskInicial.Text = "(DD/MM/AAAA)"
        '
        'lblFechaMaskFinal
        '
        Me.lblFechaMaskFinal.AutoSize = True
        Me.lblFechaMaskFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaMaskFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaMaskFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMaskFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaMaskFinal.Location = New System.Drawing.Point(283, 43)
        Me.lblFechaMaskFinal.Name = "lblFechaMaskFinal"
        Me.lblFechaMaskFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaMaskFinal.Size = New System.Drawing.Size(83, 14)
        Me.lblFechaMaskFinal.TabIndex = 15
        Me.lblFechaMaskFinal.Text = "(DD/MM/AAAA)"
        '
        'ACTMVAN6
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(378, 111)
        Me.Controls.Add(Me.lblFechaMaskFinal)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lblFechaMaskInicial)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACTMVAN6"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activos totalmente depreciados - ACTMVAN6"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents txtFechaFin As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblFechaFin As System.Windows.Forms.Label
    Public WithEvents txtFechaInicio As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblFechaInicio As System.Windows.Forms.Label
    Public WithEvents lblFechaMaskInicial As System.Windows.Forms.Label
    Public WithEvents lblFechaMaskFinal As System.Windows.Forms.Label
End Class
