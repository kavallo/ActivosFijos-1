<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN5
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
        Me.txtAnioInicial = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtAnioFinal = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.grpFecha = New System.Windows.Forms.GroupBox()
        Me.cboMesFinal = New System.Windows.Forms.ComboBox()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.cboMesInicial = New System.Windows.Forms.ComboBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.grpTotalizadoPor = New System.Windows.Forms.GroupBox()
        Me.radTipoDivision = New System.Windows.Forms.RadioButton()
        Me.radDivisionTipo = New System.Windows.Forms.RadioButton()
        Me.grpTipoActivo = New System.Windows.Forms.GroupBox()
        Me.txtTipoActivoInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTipoActivoFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTipoActivoInicial = New System.Windows.Forms.Label()
        Me.lblTipoActivoFinal = New System.Windows.Forms.Label()
        Me.lblNombreTipoInicial = New System.Windows.Forms.Label()
        Me.lblNombreTipoFinal = New System.Windows.Forms.Label()
        Me.grpDivision = New System.Windows.Forms.GroupBox()
        Me.txtDivisionInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDivisionFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDivisionInicial = New System.Windows.Forms.Label()
        Me.lblDivisionFinal = New System.Windows.Forms.Label()
        Me.lblNombreDivisionInicial = New System.Windows.Forms.Label()
        Me.lblNombreDivisionFinal = New System.Windows.Forms.Label()
        Me.grpActivoFijo = New System.Windows.Forms.GroupBox()
        Me.txtActivoFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtActivoInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblActivoFijoFinal = New System.Windows.Forms.Label()
        Me.lblActivoFijoInicial = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFecha.SuspendLayout()
        Me.grpTotalizadoPor.SuspendLayout()
        Me.grpTipoActivo.SuspendLayout()
        Me.grpDivision.SuspendLayout()
        Me.grpActivoFijo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAnioInicial
        '
        Me.txtAnioInicial.AcceptsReturn = True
        Me.txtAnioInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtAnioInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnioInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnioInicial.EsRequerido = True
        Me.txtAnioInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnioInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnioInicial.LabelConsulta = Nothing
        Me.txtAnioInicial.Location = New System.Drawing.Point(360, 34)
        Me.txtAnioInicial.MaxLength = 4
        Me.txtAnioInicial.Name = "txtAnioInicial"
        Me.txtAnioInicial.NombreDeConsulta = Nothing
        Me.txtAnioInicial.NumeroDecimales = 0
        Me.txtAnioInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAnioInicial.Size = New System.Drawing.Size(49, 20)
        Me.txtAnioInicial.TabIndex = 2
        Me.txtAnioInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAnioFinal
        '
        Me.txtAnioFinal.AcceptsReturn = True
        Me.txtAnioFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtAnioFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnioFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnioFinal.EsRequerido = True
        Me.txtAnioFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnioFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnioFinal.LabelConsulta = Nothing
        Me.txtAnioFinal.Location = New System.Drawing.Point(360, 62)
        Me.txtAnioFinal.MaxLength = 4
        Me.txtAnioFinal.Name = "txtAnioFinal"
        Me.txtAnioFinal.NombreDeConsulta = Nothing
        Me.txtAnioFinal.NumeroDecimales = 0
        Me.txtAnioFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAnioFinal.Size = New System.Drawing.Size(49, 20)
        Me.txtAnioFinal.TabIndex = 4
        Me.txtAnioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(455, 407)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(77, 25)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(372, 407)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(77, 25)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'grpFecha
        '
        Me.grpFecha.BackColor = System.Drawing.SystemColors.Control
        Me.grpFecha.Controls.Add(Me.cboMesFinal)
        Me.grpFecha.Controls.Add(Me.lblFechaFinal)
        Me.grpFecha.Controls.Add(Me.lblFechaInicial)
        Me.grpFecha.Controls.Add(Me.cboMesInicial)
        Me.grpFecha.Controls.Add(Me.txtAnioInicial)
        Me.grpFecha.Controls.Add(Me.txtAnioFinal)
        Me.grpFecha.Controls.Add(Me.lblAnio)
        Me.grpFecha.Controls.Add(Me.lblMes)
        Me.grpFecha.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFecha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpFecha.Location = New System.Drawing.Point(12, 243)
        Me.grpFecha.Name = "grpFecha"
        Me.grpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpFecha.Size = New System.Drawing.Size(520, 92)
        Me.grpFecha.TabIndex = 4
        Me.grpFecha.TabStop = False
        Me.grpFecha.Text = "Fecha"
        '
        'cboMesFinal
        '
        Me.cboMesFinal.BackColor = System.Drawing.SystemColors.Window
        Me.cboMesFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMesFinal.Location = New System.Drawing.Point(102, 61)
        Me.cboMesFinal.Name = "cboMesFinal"
        Me.cboMesFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMesFinal.Size = New System.Drawing.Size(206, 22)
        Me.cboMesFinal.TabIndex = 3
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaFinal.Location = New System.Drawing.Point(6, 64)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaFinal.Size = New System.Drawing.Size(90, 14)
        Me.lblFechaFinal.TabIndex = 29
        Me.lblFechaFinal.Text = "Final"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaInicial.Location = New System.Drawing.Point(6, 36)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaInicial.Size = New System.Drawing.Size(90, 14)
        Me.lblFechaInicial.TabIndex = 28
        Me.lblFechaInicial.Text = "Inicial"
        '
        'cboMesInicial
        '
        Me.cboMesInicial.BackColor = System.Drawing.SystemColors.Window
        Me.cboMesInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMesInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMesInicial.Location = New System.Drawing.Point(102, 33)
        Me.cboMesInicial.Name = "cboMesInicial"
        Me.cboMesInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMesInicial.Size = New System.Drawing.Size(206, 22)
        Me.cboMesInicial.TabIndex = 1
        '
        'lblAnio
        '
        Me.lblAnio.BackColor = System.Drawing.Color.Transparent
        Me.lblAnio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAnio.Location = New System.Drawing.Point(360, 16)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnio.Size = New System.Drawing.Size(49, 14)
        Me.lblAnio.TabIndex = 15
        Me.lblAnio.Text = "Año"
        Me.lblAnio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMes
        '
        Me.lblMes.BackColor = System.Drawing.Color.Transparent
        Me.lblMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMes.Location = New System.Drawing.Point(170, 16)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMes.Size = New System.Drawing.Size(67, 14)
        Me.lblMes.TabIndex = 16
        Me.lblMes.Text = "Mes "
        Me.lblMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpTotalizadoPor
        '
        Me.grpTotalizadoPor.BackColor = System.Drawing.SystemColors.Control
        Me.grpTotalizadoPor.Controls.Add(Me.radTipoDivision)
        Me.grpTotalizadoPor.Controls.Add(Me.radDivisionTipo)
        Me.grpTotalizadoPor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotalizadoPor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpTotalizadoPor.Location = New System.Drawing.Point(12, 341)
        Me.grpTotalizadoPor.Name = "grpTotalizadoPor"
        Me.grpTotalizadoPor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpTotalizadoPor.Size = New System.Drawing.Size(520, 60)
        Me.grpTotalizadoPor.TabIndex = 5
        Me.grpTotalizadoPor.TabStop = False
        Me.grpTotalizadoPor.Text = " Totalizado por "
        '
        'radTipoDivision
        '
        Me.radTipoDivision.BackColor = System.Drawing.SystemColors.Control
        Me.radTipoDivision.Checked = True
        Me.radTipoDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.radTipoDivision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTipoDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radTipoDivision.Location = New System.Drawing.Point(64, 19)
        Me.radTipoDivision.Name = "radTipoDivision"
        Me.radTipoDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radTipoDivision.Size = New System.Drawing.Size(178, 18)
        Me.radTipoDivision.TabIndex = 1
        Me.radTipoDivision.TabStop = True
        Me.radTipoDivision.Text = "Tipo activo - Departamento"
        Me.radTipoDivision.UseVisualStyleBackColor = False
        '
        'radDivisionTipo
        '
        Me.radDivisionTipo.BackColor = System.Drawing.SystemColors.Control
        Me.radDivisionTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.radDivisionTipo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDivisionTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radDivisionTipo.Location = New System.Drawing.Point(278, 19)
        Me.radDivisionTipo.Name = "radDivisionTipo"
        Me.radDivisionTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radDivisionTipo.Size = New System.Drawing.Size(178, 18)
        Me.radDivisionTipo.TabIndex = 2
        Me.radDivisionTipo.TabStop = True
        Me.radDivisionTipo.Text = "Departamento - Tipo activo"
        Me.radDivisionTipo.UseVisualStyleBackColor = False
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
        Me.grpTipoActivo.Size = New System.Drawing.Size(520, 71)
        Me.grpTipoActivo.TabIndex = 1
        Me.grpTipoActivo.TabStop = False
        Me.grpTipoActivo.Text = "Tipo de activo"
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
        Me.txtTipoActivoInicial.TabIndex = 1
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
        Me.txtTipoActivoFinal.TabIndex = 2
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
        Me.lblTipoActivoInicial.TabIndex = 18
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
        Me.lblTipoActivoFinal.TabIndex = 19
        Me.lblTipoActivoFinal.Text = "[Final]"
        '
        'lblNombreTipoInicial
        '
        Me.lblNombreTipoInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreTipoInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoInicial.Location = New System.Drawing.Point(218, 21)
        Me.lblNombreTipoInicial.Name = "lblNombreTipoInicial"
        Me.lblNombreTipoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoInicial.Size = New System.Drawing.Size(296, 20)
        Me.lblNombreTipoInicial.TabIndex = 20
        Me.lblNombreTipoInicial.UseMnemonic = False
        '
        'lblNombreTipoFinal
        '
        Me.lblNombreTipoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreTipoFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoFinal.Location = New System.Drawing.Point(218, 47)
        Me.lblNombreTipoFinal.Name = "lblNombreTipoFinal"
        Me.lblNombreTipoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoFinal.Size = New System.Drawing.Size(296, 20)
        Me.lblNombreTipoFinal.TabIndex = 16
        Me.lblNombreTipoFinal.UseMnemonic = False
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
        Me.grpDivision.Size = New System.Drawing.Size(520, 71)
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
        Me.txtDivisionInicial.TabIndex = 1
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
        Me.txtDivisionFinal.TabIndex = 2
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
        Me.lblDivisionInicial.TabIndex = 13
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
        Me.lblDivisionFinal.Size = New System.Drawing.Size(90, 17)
        Me.lblDivisionFinal.TabIndex = 14
        Me.lblDivisionFinal.Text = "[Final]"
        '
        'lblNombreDivisionInicial
        '
        Me.lblNombreDivisionInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreDivisionInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreDivisionInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDivisionInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreDivisionInicial.Location = New System.Drawing.Point(218, 21)
        Me.lblNombreDivisionInicial.Name = "lblNombreDivisionInicial"
        Me.lblNombreDivisionInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreDivisionInicial.Size = New System.Drawing.Size(296, 20)
        Me.lblNombreDivisionInicial.TabIndex = 15
        Me.lblNombreDivisionInicial.UseMnemonic = False
        '
        'lblNombreDivisionFinal
        '
        Me.lblNombreDivisionFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreDivisionFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreDivisionFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDivisionFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreDivisionFinal.Location = New System.Drawing.Point(218, 47)
        Me.lblNombreDivisionFinal.Name = "lblNombreDivisionFinal"
        Me.lblNombreDivisionFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreDivisionFinal.Size = New System.Drawing.Size(296, 20)
        Me.lblNombreDivisionFinal.TabIndex = 17
        Me.lblNombreDivisionFinal.UseMnemonic = False
        '
        'grpActivoFijo
        '
        Me.grpActivoFijo.BackColor = System.Drawing.SystemColors.Control
        Me.grpActivoFijo.Controls.Add(Me.txtActivoFinal)
        Me.grpActivoFijo.Controls.Add(Me.txtActivoInicial)
        Me.grpActivoFijo.Controls.Add(Me.lblActivoFijoFinal)
        Me.grpActivoFijo.Controls.Add(Me.lblActivoFijoInicial)
        Me.grpActivoFijo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpActivoFijo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpActivoFijo.Location = New System.Drawing.Point(12, 166)
        Me.grpActivoFijo.Name = "grpActivoFijo"
        Me.grpActivoFijo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpActivoFijo.Size = New System.Drawing.Size(520, 71)
        Me.grpActivoFijo.TabIndex = 3
        Me.grpActivoFijo.TabStop = False
        Me.grpActivoFijo.Text = "Activo fijo"
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
        Me.txtActivoFinal.Location = New System.Drawing.Point(102, 45)
        Me.txtActivoFinal.MaxLength = 15
        Me.txtActivoFinal.Name = "txtActivoFinal"
        Me.txtActivoFinal.NombreDeConsulta = Nothing
        Me.txtActivoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActivoFinal.Size = New System.Drawing.Size(135, 20)
        Me.txtActivoFinal.TabIndex = 2
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
        Me.txtActivoInicial.Location = New System.Drawing.Point(102, 19)
        Me.txtActivoInicial.MaxLength = 15
        Me.txtActivoInicial.Name = "txtActivoInicial"
        Me.txtActivoInicial.NombreDeConsulta = Nothing
        Me.txtActivoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActivoInicial.Size = New System.Drawing.Size(135, 20)
        Me.txtActivoInicial.TabIndex = 1
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
        Me.lblActivoFijoFinal.Size = New System.Drawing.Size(90, 14)
        Me.lblActivoFijoFinal.TabIndex = 28
        Me.lblActivoFijoFinal.Text = "[Final]"
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
        Me.lblActivoFijoInicial.Size = New System.Drawing.Size(90, 14)
        Me.lblActivoFijoInicial.TabIndex = 27
        Me.lblActivoFijoInicial.Text = "[Inicial]"
        '
        'ACTMVAN5
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(544, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpActivoFijo)
        Me.Controls.Add(Me.grpDivision)
        Me.Controls.Add(Me.grpTipoActivo)
        Me.Controls.Add(Me.grpFecha)
        Me.Controls.Add(Me.grpTotalizadoPor)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(149, 111)
        Me.MaximizeBox = False
        Me.Name = "ACTMVAN5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyección de depreciación de activos fijos - ACTMVAN5"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFecha.ResumeLayout(False)
        Me.grpFecha.PerformLayout()
        Me.grpTotalizadoPor.ResumeLayout(False)
        Me.grpTipoActivo.ResumeLayout(False)
        Me.grpTipoActivo.PerformLayout()
        Me.grpDivision.ResumeLayout(False)
        Me.grpDivision.PerformLayout()
        Me.grpActivoFijo.ResumeLayout(False)
        Me.grpActivoFijo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents txtAnioInicial As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtAnioFinal As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents grpFecha As System.Windows.Forms.GroupBox
    Public WithEvents lblAnio As System.Windows.Forms.Label
    Public WithEvents lblMes As System.Windows.Forms.Label
    Public WithEvents grpTotalizadoPor As System.Windows.Forms.GroupBox
    Public WithEvents radTipoDivision As System.Windows.Forms.RadioButton
    Public WithEvents radDivisionTipo As System.Windows.Forms.RadioButton
    Public WithEvents grpTipoActivo As System.Windows.Forms.GroupBox
    Public WithEvents txtTipoActivoInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTipoActivoFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTipoActivoInicial As System.Windows.Forms.Label
    Public WithEvents lblTipoActivoFinal As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoFinal As System.Windows.Forms.Label
    Public WithEvents grpDivision As System.Windows.Forms.GroupBox
    Public WithEvents txtDivisionInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDivisionFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblDivisionFinal As System.Windows.Forms.Label
    Public WithEvents lblNombreDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreDivisionFinal As System.Windows.Forms.Label
    Public WithEvents grpActivoFijo As System.Windows.Forms.GroupBox
    Public WithEvents txtActivoFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtActivoInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblActivoFijoFinal As System.Windows.Forms.Label
    Public WithEvents lblActivoFijoInicial As System.Windows.Forms.Label
    Public WithEvents cboMesFinal As System.Windows.Forms.ComboBox
    Public WithEvents lblFechaFinal As System.Windows.Forms.Label
    Public WithEvents lblFechaInicial As System.Windows.Forms.Label
    Public WithEvents cboMesInicial As System.Windows.Forms.ComboBox
End Class
