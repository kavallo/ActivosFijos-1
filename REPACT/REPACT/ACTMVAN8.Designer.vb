<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN8
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
        Me.cboEstatus = New System.Windows.Forms.ComboBox()
        Me.grpSeleccion = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblEstadoActivos = New System.Windows.Forms.Label()
        Me.lblMaskFecha = New System.Windows.Forms.Label()
        Me.lblFechaDepreciacion = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSeleccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboEstatus
        '
        Me.cboEstatus.BackColor = System.Drawing.SystemColors.Window
        Me.cboEstatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEstatus.Location = New System.Drawing.Point(155, 45)
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstatus.Size = New System.Drawing.Size(172, 22)
        Me.cboEstatus.TabIndex = 2
        '
        'grpSeleccion
        '
        Me.grpSeleccion.BackColor = System.Drawing.SystemColors.Control
        Me.grpSeleccion.Controls.Add(Me.cboEstatus)
        Me.grpSeleccion.Controls.Add(Me.txtFecha)
        Me.grpSeleccion.Controls.Add(Me.lblEstadoActivos)
        Me.grpSeleccion.Controls.Add(Me.lblMaskFecha)
        Me.grpSeleccion.Controls.Add(Me.lblFechaDepreciacion)
        Me.grpSeleccion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSeleccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpSeleccion.Location = New System.Drawing.Point(12, 12)
        Me.grpSeleccion.Name = "grpSeleccion"
        Me.grpSeleccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpSeleccion.Size = New System.Drawing.Size(449, 80)
        Me.grpSeleccion.TabIndex = 1
        Me.grpSeleccion.TabStop = False
        Me.grpSeleccion.Text = "Selección"
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.EsRequerido = True
        Me.txtFecha.Location = New System.Drawing.Point(155, 19)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(172, 20)
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'lblEstadoActivos
        '
        Me.lblEstadoActivos.BackColor = System.Drawing.SystemColors.Control
        Me.lblEstadoActivos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEstadoActivos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoActivos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEstadoActivos.Location = New System.Drawing.Point(6, 48)
        Me.lblEstadoActivos.Name = "lblEstadoActivos"
        Me.lblEstadoActivos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEstadoActivos.Size = New System.Drawing.Size(143, 17)
        Me.lblEstadoActivos.TabIndex = 8
        Me.lblEstadoActivos.Text = "Estado de los activos:"
        '
        'lblMaskFecha
        '
        Me.lblMaskFecha.BackColor = System.Drawing.SystemColors.Control
        Me.lblMaskFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaskFecha.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaskFecha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMaskFecha.Location = New System.Drawing.Point(357, 21)
        Me.lblMaskFecha.Name = "lblMaskFecha"
        Me.lblMaskFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaskFecha.Size = New System.Drawing.Size(86, 16)
        Me.lblMaskFecha.TabIndex = 6
        Me.lblMaskFecha.Text = "(MM/DD/AAAA)"
        '
        'lblFechaDepreciacion
        '
        Me.lblFechaDepreciacion.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaDepreciacion.Location = New System.Drawing.Point(6, 21)
        Me.lblFechaDepreciacion.Name = "lblFechaDepreciacion"
        Me.lblFechaDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaDepreciacion.Size = New System.Drawing.Size(143, 14)
        Me.lblFechaDepreciacion.TabIndex = 5
        Me.lblFechaDepreciacion.Text = "Fecha deprecicación"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(384, 98)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(77, 25)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(301, 98)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(77, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTMVAN8
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(473, 135)
        Me.Controls.Add(Me.grpSeleccion)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACTMVAN8"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activos depreciados - ACTMVAN8"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSeleccion.ResumeLayout(False)
        Me.grpSeleccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cboEstatus As System.Windows.Forms.ComboBox
    Public WithEvents grpSeleccion As System.Windows.Forms.GroupBox
    Public WithEvents lblEstadoActivos As System.Windows.Forms.Label
    Public WithEvents lblMaskFecha As System.Windows.Forms.Label
    Public WithEvents lblFechaDepreciacion As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents txtFecha As Citi.Synergia.UIGenerico.SynTextoFecha
End Class
