<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN7
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
        Me.grpSeleccion = New System.Windows.Forms.GroupBox()
        Me.txtTipoActivo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblNombreTipo = New System.Windows.Forms.Label()
        Me.lblTipoActivo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkIncluyeMejoras = New System.Windows.Forms.CheckBox()
        Me.grpInformacion = New System.Windows.Forms.GroupBox()
        Me.txtTituloReporte = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTituloReporte = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSeleccion.SuspendLayout()
        Me.grpInformacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSeleccion
        '
        Me.grpSeleccion.BackColor = System.Drawing.SystemColors.Control
        Me.grpSeleccion.Controls.Add(Me.txtTipoActivo)
        Me.grpSeleccion.Controls.Add(Me.lblNombreTipo)
        Me.grpSeleccion.Controls.Add(Me.lblTipoActivo)
        Me.grpSeleccion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSeleccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpSeleccion.Location = New System.Drawing.Point(12, 12)
        Me.grpSeleccion.Name = "grpSeleccion"
        Me.grpSeleccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpSeleccion.Size = New System.Drawing.Size(481, 53)
        Me.grpSeleccion.TabIndex = 1
        Me.grpSeleccion.TabStop = False
        Me.grpSeleccion.Text = "Selección"
        '
        'txtTipoActivo
        '
        Me.txtTipoActivo.AcceptsReturn = True
        Me.txtTipoActivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoActivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoActivo.EsRequerido = True
        Me.txtTipoActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoActivo.LabelConsulta = Nothing
        Me.txtTipoActivo.Location = New System.Drawing.Point(140, 19)
        Me.txtTipoActivo.MaxLength = 7
        Me.txtTipoActivo.Name = "txtTipoActivo"
        Me.txtTipoActivo.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoActivo.Size = New System.Drawing.Size(80, 20)
        Me.txtTipoActivo.TabIndex = 1
        '
        'lblNombreTipo
        '
        Me.lblNombreTipo.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombreTipo.Location = New System.Drawing.Point(226, 21)
        Me.lblNombreTipo.Name = "lblNombreTipo"
        Me.lblNombreTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipo.Size = New System.Drawing.Size(249, 20)
        Me.lblNombreTipo.TabIndex = 9
        Me.lblNombreTipo.UseMnemonic = False
        '
        'lblTipoActivo
        '
        Me.lblTipoActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoActivo.Location = New System.Drawing.Point(6, 21)
        Me.lblTipoActivo.Name = "lblTipoActivo"
        Me.lblTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoActivo.Size = New System.Drawing.Size(128, 14)
        Me.lblTipoActivo.TabIndex = 7
        Me.lblTipoActivo.Text = "Tipo activo"
        '
        'chkIncluyeMejoras
        '
        Me.chkIncluyeMejoras.BackColor = System.Drawing.SystemColors.Control
        Me.chkIncluyeMejoras.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkIncluyeMejoras.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncluyeMejoras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkIncluyeMejoras.Location = New System.Drawing.Point(140, 45)
        Me.chkIncluyeMejoras.Name = "chkIncluyeMejoras"
        Me.chkIncluyeMejoras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIncluyeMejoras.Size = New System.Drawing.Size(127, 18)
        Me.chkIncluyeMejoras.TabIndex = 2
        Me.chkIncluyeMejoras.Text = "Incluye mejoras"
        Me.chkIncluyeMejoras.UseVisualStyleBackColor = False
        '
        'grpInformacion
        '
        Me.grpInformacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpInformacion.Controls.Add(Me.chkIncluyeMejoras)
        Me.grpInformacion.Controls.Add(Me.txtTituloReporte)
        Me.grpInformacion.Controls.Add(Me.lblTituloReporte)
        Me.grpInformacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInformacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpInformacion.Location = New System.Drawing.Point(12, 71)
        Me.grpInformacion.Name = "grpInformacion"
        Me.grpInformacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpInformacion.Size = New System.Drawing.Size(481, 75)
        Me.grpInformacion.TabIndex = 2
        Me.grpInformacion.TabStop = False
        Me.grpInformacion.Text = "Información para reporte"
        '
        'txtTituloReporte
        '
        Me.txtTituloReporte.AcceptsReturn = True
        Me.txtTituloReporte.BackColor = System.Drawing.SystemColors.Window
        Me.txtTituloReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTituloReporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTituloReporte.EsRequerido = False
        Me.txtTituloReporte.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTituloReporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTituloReporte.LabelConsulta = Nothing
        Me.txtTituloReporte.Location = New System.Drawing.Point(140, 19)
        Me.txtTituloReporte.MaxLength = 0
        Me.txtTituloReporte.Name = "txtTituloReporte"
        Me.txtTituloReporte.NombreDeConsulta = Nothing
        Me.txtTituloReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTituloReporte.Size = New System.Drawing.Size(321, 20)
        Me.txtTituloReporte.TabIndex = 1
        '
        'lblTituloReporte
        '
        Me.lblTituloReporte.BackColor = System.Drawing.SystemColors.Control
        Me.lblTituloReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTituloReporte.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloReporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTituloReporte.Location = New System.Drawing.Point(6, 21)
        Me.lblTituloReporte.Name = "lblTituloReporte"
        Me.lblTituloReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTituloReporte.Size = New System.Drawing.Size(128, 14)
        Me.lblTituloReporte.TabIndex = 10
        Me.lblTituloReporte.Text = "Titulo para reporte:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(333, 152)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(77, 25)
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
        Me.cmdCancelar.Location = New System.Drawing.Point(416, 152)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(77, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'ACTMVAN7
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(505, 189)
        Me.Controls.Add(Me.grpInformacion)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grpSeleccion)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACTMVAN7"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activos por tipo de activo - ACTMVAN7"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSeleccion.ResumeLayout(False)
        Me.grpSeleccion.PerformLayout()
        Me.grpInformacion.ResumeLayout(False)
        Me.grpInformacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents grpSeleccion As System.Windows.Forms.GroupBox
    Public WithEvents txtTipoActivo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblNombreTipo As System.Windows.Forms.Label
    Public WithEvents lblTipoActivo As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents chkIncluyeMejoras As System.Windows.Forms.CheckBox
    Public WithEvents grpInformacion As System.Windows.Forms.GroupBox
    Public WithEvents txtTituloReporte As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTituloReporte As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
