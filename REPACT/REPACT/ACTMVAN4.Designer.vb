<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN4
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento  'System.Windows.Forms.Form

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
        Me.lblAvisoTipoMovimiento = New System.Windows.Forms.Label()
        Me.lblActivoFijoInicial = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtActivoFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.txtActivoInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtTipoMovimiento = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtFechaInicio = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtFechaFin = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.grpActivoFijo = New System.Windows.Forms.GroupBox()
        Me.lblActivoFijoFinal = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblMaskFechaFinal = New System.Windows.Forms.Label()
        Me.lblMaskFechaInicial = New System.Windows.Forms.Label()
        Me.lblNombreTipoMovimiento = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActivoFijo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAvisoTipoMovimiento
        '
        Me.lblAvisoTipoMovimiento.BackColor = System.Drawing.SystemColors.Control
        Me.lblAvisoTipoMovimiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAvisoTipoMovimiento.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvisoTipoMovimiento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAvisoTipoMovimiento.Location = New System.Drawing.Point(12, 87)
        Me.lblAvisoTipoMovimiento.Name = "lblAvisoTipoMovimiento"
        Me.lblAvisoTipoMovimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAvisoTipoMovimiento.Size = New System.Drawing.Size(358, 32)
        Me.lblAvisoTipoMovimiento.TabIndex = 20
        Me.lblAvisoTipoMovimiento.Text = "(Si no ingresa el Tipo de Movimiento se incluirán todos los movimientos dentro de" & _
    "l reporte)"
        '
        'lblActivoFijoInicial
        '
        Me.lblActivoFijoInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblActivoFijoInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblActivoFijoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivoFijoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblActivoFijoInicial.Location = New System.Drawing.Point(6, 21)
        Me.lblActivoFijoInicial.Name = "lblActivoFijoInicial"
        Me.lblActivoFijoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblActivoFijoInicial.Size = New System.Drawing.Size(146, 14)
        Me.lblActivoFijoInicial.TabIndex = 8
        Me.lblActivoFijoInicial.Text = "[Inicial]"
        '
        'txtActivoFinal
        '
        Me.txtActivoFinal.AcceptsReturn = True
        Me.txtActivoFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtActivoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActivoFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtActivoFinal.EsRequerido = False
        Me.txtActivoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtActivoFinal.LabelConsulta = Nothing
        Me.txtActivoFinal.Location = New System.Drawing.Point(158, 45)
        Me.txtActivoFinal.MaxLength = 15
        Me.txtActivoFinal.Name = "txtActivoFinal"
        Me.txtActivoFinal.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
        Me.txtActivoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActivoFinal.Size = New System.Drawing.Size(125, 20)
        Me.txtActivoFinal.TabIndex = 2
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoMovimiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoMovimiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMovimiento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(12, 66)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(152, 14)
        Me.lblTipoMovimiento.TabIndex = 22
        Me.lblTipoMovimiento.Text = "[Tipo de movimiento]"
        '
        'txtActivoInicial
        '
        Me.txtActivoInicial.AcceptsReturn = True
        Me.txtActivoInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtActivoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActivoInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtActivoInicial.EsRequerido = False
        Me.txtActivoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtActivoInicial.LabelConsulta = Nothing
        Me.txtActivoInicial.Location = New System.Drawing.Point(158, 19)
        Me.txtActivoInicial.MaxLength = 15
        Me.txtActivoInicial.Name = "txtActivoInicial"
        Me.txtActivoInicial.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeActivosFijos_ACTMAFL0
        Me.txtActivoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActivoInicial.Size = New System.Drawing.Size(125, 20)
        Me.txtActivoInicial.TabIndex = 1
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaInicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaInicio.Location = New System.Drawing.Point(12, 15)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaInicio.Size = New System.Drawing.Size(152, 14)
        Me.lblFechaInicio.TabIndex = 25
        Me.lblFechaInicio.Text = "Del"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaFin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaFin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaFin.Location = New System.Drawing.Point(14, 40)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaFin.Size = New System.Drawing.Size(150, 14)
        Me.lblFechaFin.TabIndex = 21
        Me.lblFechaFin.Text = "Al"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(372, 218)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(77, 25)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'txtTipoMovimiento
        '
        Me.txtTipoMovimiento.AcceptsReturn = True
        Me.txtTipoMovimiento.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoMovimiento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoMovimiento.EsRequerido = False
        Me.txtTipoMovimiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMovimiento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoMovimiento.LabelConsulta = Nothing
        Me.txtTipoMovimiento.Location = New System.Drawing.Point(170, 64)
        Me.txtTipoMovimiento.MaxLength = 1
        Me.txtTipoMovimiento.Name = "txtTipoMovimiento"
        Me.txtTipoMovimiento.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeMovimientosDeActivos_ACTTMAL0
        Me.txtTipoMovimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoMovimiento.Size = New System.Drawing.Size(79, 20)
        Me.txtTipoMovimiento.TabIndex = 3
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaInicio.EsRequerido = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(170, 12)
        Me.txtFechaInicio.Mask = "00/00/0000"
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(160, 20)
        Me.txtFechaInicio.TabIndex = 1
        Me.txtFechaInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFechaInicio.ValidatingType = GetType(Date)
        '
        'txtFechaFin
        '
        Me.txtFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaFin.EsRequerido = True
        Me.txtFechaFin.Location = New System.Drawing.Point(170, 38)
        Me.txtFechaFin.Mask = "00/00/0000"
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(160, 20)
        Me.txtFechaFin.TabIndex = 2
        Me.txtFechaFin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFechaFin.ValidatingType = GetType(Date)
        '
        'grpActivoFijo
        '
        Me.grpActivoFijo.BackColor = System.Drawing.SystemColors.Control
        Me.grpActivoFijo.Controls.Add(Me.txtActivoInicial)
        Me.grpActivoFijo.Controls.Add(Me.txtActivoFinal)
        Me.grpActivoFijo.Controls.Add(Me.lblActivoFijoInicial)
        Me.grpActivoFijo.Controls.Add(Me.lblActivoFijoFinal)
        Me.grpActivoFijo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpActivoFijo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpActivoFijo.Location = New System.Drawing.Point(12, 141)
        Me.grpActivoFijo.Name = "grpActivoFijo"
        Me.grpActivoFijo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpActivoFijo.Size = New System.Drawing.Size(520, 71)
        Me.grpActivoFijo.TabIndex = 4
        Me.grpActivoFijo.TabStop = False
        Me.grpActivoFijo.Text = "Activo fijo"
        '
        'lblActivoFijoFinal
        '
        Me.lblActivoFijoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblActivoFijoFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblActivoFijoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivoFijoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblActivoFijoFinal.Location = New System.Drawing.Point(6, 47)
        Me.lblActivoFijoFinal.Name = "lblActivoFijoFinal"
        Me.lblActivoFijoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblActivoFijoFinal.Size = New System.Drawing.Size(146, 14)
        Me.lblActivoFijoFinal.TabIndex = 9
        Me.lblActivoFijoFinal.Text = "[Final]"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(455, 218)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(77, 25)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblMaskFechaFinal
        '
        Me.lblMaskFechaFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblMaskFechaFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaskFechaFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaskFechaFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMaskFechaFinal.Location = New System.Drawing.Point(358, 40)
        Me.lblMaskFechaFinal.Name = "lblMaskFechaFinal"
        Me.lblMaskFechaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaskFechaFinal.Size = New System.Drawing.Size(83, 20)
        Me.lblMaskFechaFinal.TabIndex = 30
        Me.lblMaskFechaFinal.Text = "(DD/MM/AAAA)"
        Me.lblMaskFechaFinal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMaskFechaInicial
        '
        Me.lblMaskFechaInicial.BackColor = System.Drawing.Color.Transparent
        Me.lblMaskFechaInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaskFechaInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaskFechaInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMaskFechaInicial.Location = New System.Drawing.Point(358, 15)
        Me.lblMaskFechaInicial.Name = "lblMaskFechaInicial"
        Me.lblMaskFechaInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaskFechaInicial.Size = New System.Drawing.Size(83, 20)
        Me.lblMaskFechaInicial.TabIndex = 31
        Me.lblMaskFechaInicial.Text = "(DD/MM/AAAA)"
        Me.lblMaskFechaInicial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNombreTipoMovimiento
        '
        Me.lblNombreTipoMovimiento.Location = New System.Drawing.Point(255, 66)
        Me.lblNombreTipoMovimiento.Name = "lblNombreTipoMovimiento"
        Me.lblNombreTipoMovimiento.Size = New System.Drawing.Size(277, 20)
        Me.lblNombreTipoMovimiento.TabIndex = 32
        '
        'ACTMVAN4
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(544, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNombreTipoMovimiento)
        Me.Controls.Add(Me.lblMaskFechaInicial)
        Me.Controls.Add(Me.lblMaskFechaFinal)
        Me.Controls.Add(Me.lblAvisoTipoMovimiento)
        Me.Controls.Add(Me.lblTipoMovimiento)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtTipoMovimiento)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.grpActivoFijo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(84, 105)
        Me.MaximizeBox = False
        Me.Name = "ACTMVAN4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de activos fijos - ACTMVAN4"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActivoFijo.ResumeLayout(False)
        Me.grpActivoFijo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblAvisoTipoMovimiento As System.Windows.Forms.Label
    Public WithEvents lblActivoFijoInicial As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtActivoFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTipoMovimiento As System.Windows.Forms.Label
    Public WithEvents txtActivoInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblFechaInicio As System.Windows.Forms.Label
    Public WithEvents lblFechaFin As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents txtTipoMovimiento As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtFechaFin As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents txtFechaInicio As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents grpActivoFijo As System.Windows.Forms.GroupBox
    Public WithEvents lblActivoFijoFinal As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents lblMaskFechaFinal As System.Windows.Forms.Label
    Public WithEvents lblMaskFechaInicial As System.Windows.Forms.Label
    Friend WithEvents lblNombreTipoMovimiento As System.Windows.Forms.Label
End Class
