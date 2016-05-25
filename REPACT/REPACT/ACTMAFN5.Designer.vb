<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFN5
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
        Me.txtTipoActivoInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTipoActivoFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTipoActivoInicial = New System.Windows.Forms.Label()
        Me.lblTipoActivoFinal = New System.Windows.Forms.Label()
        Me.grpDivision = New System.Windows.Forms.GroupBox()
        Me.txtDivisionInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDivisionFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDivisionInicial = New System.Windows.Forms.Label()
        Me.lblDivisionFinal = New System.Windows.Forms.Label()
        Me.lblNombreDivisionInicial = New System.Windows.Forms.Label()
        Me.lblNombreDivisionFinal = New System.Windows.Forms.Label()
        Me.lblNombreTipoInicial = New System.Windows.Forms.Label()
        Me.lblNombreTipoFinal = New System.Windows.Forms.Label()
        Me.grpTipoActivo = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblEstadoActivos = New System.Windows.Forms.Label()
        Me.lblFiltradoPor = New System.Windows.Forms.Label()
        Me.cboTotalizado = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDivision.SuspendLayout()
        Me.grpTipoActivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboEstatus
        '
        Me.cboEstatus.BackColor = System.Drawing.SystemColors.Window
        Me.cboEstatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEstatus.Location = New System.Drawing.Point(195, 194)
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstatus.Size = New System.Drawing.Size(221, 22)
        Me.cboEstatus.TabIndex = 4
        '
        'txtTipoActivoInicial
        '
        Me.txtTipoActivoInicial.AcceptsReturn = True
        Me.txtTipoActivoInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoActivoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoActivoInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoActivoInicial.EsRequerido = False
        Me.txtTipoActivoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoActivoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoActivoInicial.LabelConsulta = Nothing
        Me.txtTipoActivoInicial.Location = New System.Drawing.Point(102, 19)
        Me.txtTipoActivoInicial.MaxLength = 7
        Me.txtTipoActivoInicial.Name = "txtTipoActivoInicial"
        Me.txtTipoActivoInicial.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtTipoActivoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoActivoInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtTipoActivoInicial.TabIndex = 0
        '
        'txtTipoActivoFinal
        '
        Me.txtTipoActivoFinal.AcceptsReturn = True
        Me.txtTipoActivoFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoActivoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoActivoFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoActivoFinal.EsRequerido = False
        Me.txtTipoActivoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoActivoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoActivoFinal.LabelConsulta = Nothing
        Me.txtTipoActivoFinal.Location = New System.Drawing.Point(102, 45)
        Me.txtTipoActivoFinal.MaxLength = 7
        Me.txtTipoActivoFinal.Name = "txtTipoActivoFinal"
        Me.txtTipoActivoFinal.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtTipoActivoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoActivoFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtTipoActivoFinal.TabIndex = 1
        '
        'lblTipoActivoInicial
        '
        Me.lblTipoActivoInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoActivoInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoActivoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoActivoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoActivoInicial.Location = New System.Drawing.Point(6, 21)
        Me.lblTipoActivoInicial.Name = "lblTipoActivoInicial"
        Me.lblTipoActivoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoActivoInicial.Size = New System.Drawing.Size(90, 14)
        Me.lblTipoActivoInicial.TabIndex = 14
        Me.lblTipoActivoInicial.Text = "[Inicial]"
        '
        'lblTipoActivoFinal
        '
        Me.lblTipoActivoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoActivoFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoActivoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoActivoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoActivoFinal.Location = New System.Drawing.Point(6, 47)
        Me.lblTipoActivoFinal.Name = "lblTipoActivoFinal"
        Me.lblTipoActivoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoActivoFinal.Size = New System.Drawing.Size(90, 14)
        Me.lblTipoActivoFinal.TabIndex = 15
        Me.lblTipoActivoFinal.Text = "[Final]"
        '
        'grpDivision
        '
        Me.grpDivision.BackColor = System.Drawing.SystemColors.Control
        Me.grpDivision.Controls.Add(Me.txtDivisionInicial)
        Me.grpDivision.Controls.Add(Me.txtDivisionFinal)
        Me.grpDivision.Controls.Add(Me.lblDivisionInicial)
        Me.grpDivision.Controls.Add(Me.lblDivisionFinal)
        Me.grpDivision.Controls.Add(Me.lblNombreDivisionInicial)
        Me.grpDivision.Controls.Add(Me.lblNombreDivisionFinal)
        Me.grpDivision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDivision.ForeColor = System.Drawing.Color.Black
        Me.grpDivision.Location = New System.Drawing.Point(12, 89)
        Me.grpDivision.Name = "grpDivision"
        Me.grpDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDivision.Size = New System.Drawing.Size(586, 71)
        Me.grpDivision.TabIndex = 2
        Me.grpDivision.TabStop = False
        Me.grpDivision.Text = "Departamento"
        '
        'txtDivisionInicial
        '
        Me.txtDivisionInicial.AcceptsReturn = True
        Me.txtDivisionInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtDivisionInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDivisionInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDivisionInicial.EsRequerido = False
        Me.txtDivisionInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDivisionInicial.LabelConsulta = Nothing
        Me.txtDivisionInicial.Location = New System.Drawing.Point(102, 19)
        Me.txtDivisionInicial.MaxLength = 10
        Me.txtDivisionInicial.Name = "txtDivisionInicial"
        Me.txtDivisionInicial.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtDivisionInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDivisionInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtDivisionInicial.TabIndex = 2
        '
        'txtDivisionFinal
        '
        Me.txtDivisionFinal.AcceptsReturn = True
        Me.txtDivisionFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtDivisionFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDivisionFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDivisionFinal.EsRequerido = False
        Me.txtDivisionFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDivisionFinal.LabelConsulta = Nothing
        Me.txtDivisionFinal.Location = New System.Drawing.Point(102, 45)
        Me.txtDivisionFinal.MaxLength = 10
        Me.txtDivisionFinal.Name = "txtDivisionFinal"
        Me.txtDivisionFinal.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtDivisionFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDivisionFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtDivisionFinal.TabIndex = 3
        '
        'lblDivisionInicial
        '
        Me.lblDivisionInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblDivisionInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDivisionInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDivisionInicial.Location = New System.Drawing.Point(6, 21)
        Me.lblDivisionInicial.Name = "lblDivisionInicial"
        Me.lblDivisionInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDivisionInicial.Size = New System.Drawing.Size(90, 14)
        Me.lblDivisionInicial.TabIndex = 9
        Me.lblDivisionInicial.Text = "[Inicial]"
        '
        'lblDivisionFinal
        '
        Me.lblDivisionFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblDivisionFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDivisionFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDivisionFinal.Location = New System.Drawing.Point(6, 47)
        Me.lblDivisionFinal.Name = "lblDivisionFinal"
        Me.lblDivisionFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDivisionFinal.Size = New System.Drawing.Size(90, 14)
        Me.lblDivisionFinal.TabIndex = 10
        Me.lblDivisionFinal.Text = "[Final]"
        '
        'lblNombreDivisionInicial
        '
        Me.lblNombreDivisionInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreDivisionInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreDivisionInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDivisionInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreDivisionInicial.Location = New System.Drawing.Point(188, 21)
        Me.lblNombreDivisionInicial.Name = "lblNombreDivisionInicial"
        Me.lblNombreDivisionInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreDivisionInicial.Size = New System.Drawing.Size(392, 20)
        Me.lblNombreDivisionInicial.TabIndex = 11
        Me.lblNombreDivisionInicial.UseMnemonic = False
        '
        'lblNombreDivisionFinal
        '
        Me.lblNombreDivisionFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreDivisionFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreDivisionFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDivisionFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreDivisionFinal.Location = New System.Drawing.Point(188, 47)
        Me.lblNombreDivisionFinal.Name = "lblNombreDivisionFinal"
        Me.lblNombreDivisionFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreDivisionFinal.Size = New System.Drawing.Size(392, 20)
        Me.lblNombreDivisionFinal.TabIndex = 13
        Me.lblNombreDivisionFinal.UseMnemonic = False
        '
        'lblNombreTipoInicial
        '
        Me.lblNombreTipoInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreTipoInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoInicial.Location = New System.Drawing.Point(188, 21)
        Me.lblNombreTipoInicial.Name = "lblNombreTipoInicial"
        Me.lblNombreTipoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoInicial.Size = New System.Drawing.Size(392, 20)
        Me.lblNombreTipoInicial.TabIndex = 16
        Me.lblNombreTipoInicial.UseMnemonic = False
        '
        'lblNombreTipoFinal
        '
        Me.lblNombreTipoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreTipoFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoFinal.Location = New System.Drawing.Point(188, 47)
        Me.lblNombreTipoFinal.Name = "lblNombreTipoFinal"
        Me.lblNombreTipoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoFinal.Size = New System.Drawing.Size(392, 20)
        Me.lblNombreTipoFinal.TabIndex = 19
        Me.lblNombreTipoFinal.UseMnemonic = False
        '
        'grpTipoActivo
        '
        Me.grpTipoActivo.BackColor = System.Drawing.SystemColors.Control
        Me.grpTipoActivo.Controls.Add(Me.txtTipoActivoInicial)
        Me.grpTipoActivo.Controls.Add(Me.txtTipoActivoFinal)
        Me.grpTipoActivo.Controls.Add(Me.lblTipoActivoInicial)
        Me.grpTipoActivo.Controls.Add(Me.lblTipoActivoFinal)
        Me.grpTipoActivo.Controls.Add(Me.lblNombreTipoInicial)
        Me.grpTipoActivo.Controls.Add(Me.lblNombreTipoFinal)
        Me.grpTipoActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpTipoActivo.Location = New System.Drawing.Point(12, 12)
        Me.grpTipoActivo.Name = "grpTipoActivo"
        Me.grpTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpTipoActivo.Size = New System.Drawing.Size(586, 71)
        Me.grpTipoActivo.TabIndex = 1
        Me.grpTipoActivo.TabStop = False
        Me.grpTipoActivo.Text = "Tipo de activo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(508, 222)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 27)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(412, 222)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 27)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'lblEstadoActivos
        '
        Me.lblEstadoActivos.BackColor = System.Drawing.SystemColors.Control
        Me.lblEstadoActivos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEstadoActivos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoActivos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEstadoActivos.Location = New System.Drawing.Point(54, 197)
        Me.lblEstadoActivos.Name = "lblEstadoActivos"
        Me.lblEstadoActivos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEstadoActivos.Size = New System.Drawing.Size(135, 14)
        Me.lblEstadoActivos.TabIndex = 25
        Me.lblEstadoActivos.Text = "Estado de los activos:"
        Me.lblEstadoActivos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFiltradoPor
        '
        Me.lblFiltradoPor.BackColor = System.Drawing.SystemColors.Control
        Me.lblFiltradoPor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFiltradoPor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltradoPor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFiltradoPor.Location = New System.Drawing.Point(51, 169)
        Me.lblFiltradoPor.Name = "lblFiltradoPor"
        Me.lblFiltradoPor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFiltradoPor.Size = New System.Drawing.Size(138, 14)
        Me.lblFiltradoPor.TabIndex = 24
        Me.lblFiltradoPor.Text = "Filtrado por:"
        Me.lblFiltradoPor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboTotalizado
        '
        Me.cboTotalizado.BackColor = System.Drawing.SystemColors.Window
        Me.cboTotalizado.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTotalizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTotalizado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTotalizado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTotalizado.Location = New System.Drawing.Point(195, 166)
        Me.cboTotalizado.Name = "cboTotalizado"
        Me.cboTotalizado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTotalizado.Size = New System.Drawing.Size(221, 22)
        Me.cboTotalizado.TabIndex = 3
        '
        'ACTMAFN5
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(610, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboTotalizado)
        Me.Controls.Add(Me.cboEstatus)
        Me.Controls.Add(Me.grpDivision)
        Me.Controls.Add(Me.grpTipoActivo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblEstadoActivos)
        Me.Controls.Add(Me.lblFiltradoPor)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(125, 155)
        Me.MaximizeBox = False
        Me.Name = "ACTMAFN5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte toma de inventario físico de activos - ACTMAFN5"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDivision.ResumeLayout(False)
        Me.grpDivision.PerformLayout()
        Me.grpTipoActivo.ResumeLayout(False)
        Me.grpTipoActivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cboEstatus As System.Windows.Forms.ComboBox
    Public WithEvents txtTipoActivoInicial As Citi.Synergia.UIGenerico.SynTextBox  'System.Windows.Forms.TextBox
    Public WithEvents txtTipoActivoFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTipoActivoInicial As System.Windows.Forms.Label
    Public WithEvents lblTipoActivoFinal As System.Windows.Forms.Label
    Public WithEvents grpDivision As System.Windows.Forms.GroupBox
    Public WithEvents txtDivisionInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDivisionFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblDivisionFinal As System.Windows.Forms.Label
    Public WithEvents lblNombreDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreDivisionFinal As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoFinal As System.Windows.Forms.Label
    Public WithEvents grpTipoActivo As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents lblEstadoActivos As System.Windows.Forms.Label
    Public WithEvents lblFiltradoPor As System.Windows.Forms.Label
    Public WithEvents cboTotalizado As System.Windows.Forms.ComboBox
End Class
