<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN3
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
        Me.txtAnio = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTipoActivoFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtTipoActivoInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.grpTipoActivo = New System.Windows.Forms.GroupBox()
        Me.lblTipoActivoInicial = New System.Windows.Forms.Label()
        Me.lblTipoActivoFinal = New System.Windows.Forms.Label()
        Me.lblNombreTipoInicial = New System.Windows.Forms.Label()
        Me.lblNombreTipoFinal = New System.Windows.Forms.Label()
        Me.txtDivisionFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboTotalizado = New System.Windows.Forms.ComboBox()
        Me.txtDivisionInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.grpDivision = New System.Windows.Forms.GroupBox()
        Me.lblDivisionInicial = New System.Windows.Forms.Label()
        Me.lblDivisionFinal = New System.Windows.Forms.Label()
        Me.lblNombreDivisionInicial = New System.Windows.Forms.Label()
        Me.lblNombreDivisionFinal = New System.Windows.Forms.Label()
        Me.lblTotalizadoPor = New System.Windows.Forms.Label()
        Me.cboMeses = New System.Windows.Forms.ComboBox()
        Me.TodosLosAños = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoActivo.SuspendLayout()
        Me.grpDivision.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAnio
        '
        Me.txtAnio.AcceptsReturn = True
        Me.txtAnio.BackColor = System.Drawing.SystemColors.Window
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnio.EsRequerido = True
        Me.txtAnio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnio.LabelConsulta = Nothing
        Me.txtAnio.Location = New System.Drawing.Point(187, 12)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.NombreDeConsulta = Nothing
        Me.txtAnio.NumeroDecimales = 0
        Me.txtAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAnio.Size = New System.Drawing.Size(49, 20)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(437, 248)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(354, 248)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(77, 25)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
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
        'lblAnio
        '
        Me.lblAnio.BackColor = System.Drawing.SystemColors.Control
        Me.lblAnio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAnio.Location = New System.Drawing.Point(18, 14)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnio.Size = New System.Drawing.Size(163, 14)
        Me.lblAnio.TabIndex = 29
        Me.lblAnio.Text = "Año"
        '
        'lblMes
        '
        Me.lblMes.BackColor = System.Drawing.SystemColors.Control
        Me.lblMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMes.Location = New System.Drawing.Point(18, 41)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMes.Size = New System.Drawing.Size(163, 14)
        Me.lblMes.TabIndex = 28
        Me.lblMes.Text = "Mes"
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
        Me.grpTipoActivo.Location = New System.Drawing.Point(12, 94)
        Me.grpTipoActivo.Name = "grpTipoActivo"
        Me.grpTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpTipoActivo.Size = New System.Drawing.Size(502, 71)
        Me.grpTipoActivo.TabIndex = 4
        Me.grpTipoActivo.TabStop = False
        Me.grpTipoActivo.Text = "Tipo de activo"
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
        Me.lblTipoActivoInicial.TabIndex = 15
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
        Me.lblTipoActivoFinal.TabIndex = 16
        Me.lblTipoActivoFinal.Text = "[Final]"
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
        Me.lblNombreTipoInicial.Size = New System.Drawing.Size(308, 20)
        Me.lblNombreTipoInicial.TabIndex = 17
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
        Me.lblNombreTipoFinal.Size = New System.Drawing.Size(308, 20)
        Me.lblNombreTipoFinal.TabIndex = 21
        Me.lblNombreTipoFinal.UseMnemonic = False
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
        'cboTotalizado
        '
        Me.cboTotalizado.BackColor = System.Drawing.SystemColors.Window
        Me.cboTotalizado.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTotalizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTotalizado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTotalizado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTotalizado.Location = New System.Drawing.Point(187, 66)
        Me.cboTotalizado.Name = "cboTotalizado"
        Me.cboTotalizado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTotalizado.Size = New System.Drawing.Size(205, 22)
        Me.cboTotalizado.TabIndex = 3
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
        Me.grpDivision.Location = New System.Drawing.Point(12, 171)
        Me.grpDivision.Name = "grpDivision"
        Me.grpDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDivision.Size = New System.Drawing.Size(502, 71)
        Me.grpDivision.TabIndex = 5
        Me.grpDivision.TabStop = False
        Me.grpDivision.Text = "Departamento"
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
        Me.lblDivisionInicial.TabIndex = 10
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
        Me.lblDivisionFinal.TabIndex = 11
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
        Me.lblNombreDivisionInicial.Size = New System.Drawing.Size(308, 20)
        Me.lblNombreDivisionInicial.TabIndex = 12
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
        Me.lblNombreDivisionFinal.Size = New System.Drawing.Size(308, 20)
        Me.lblNombreDivisionFinal.TabIndex = 14
        Me.lblNombreDivisionFinal.UseMnemonic = False
        '
        'lblTotalizadoPor
        '
        Me.lblTotalizadoPor.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalizadoPor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalizadoPor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalizadoPor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTotalizadoPor.Location = New System.Drawing.Point(18, 69)
        Me.lblTotalizadoPor.Name = "lblTotalizadoPor"
        Me.lblTotalizadoPor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalizadoPor.Size = New System.Drawing.Size(163, 14)
        Me.lblTotalizadoPor.TabIndex = 27
        Me.lblTotalizadoPor.Text = "Reporte totalizado por:"
        '
        'cboMeses
        '
        Me.cboMeses.BackColor = System.Drawing.SystemColors.Window
        Me.cboMeses.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeses.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMeses.Location = New System.Drawing.Point(187, 38)
        Me.cboMeses.Name = "cboMeses"
        Me.cboMeses.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMeses.Size = New System.Drawing.Size(205, 22)
        Me.cboMeses.TabIndex = 2
        '
        'TodosLosAños
        '
        Me.TodosLosAños.AutoSize = True
        Me.TodosLosAños.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodosLosAños.Location = New System.Drawing.Point(21, 248)
        Me.TodosLosAños.Name = "TodosLosAños"
        Me.TodosLosAños.Size = New System.Drawing.Size(104, 18)
        Me.TodosLosAños.TabIndex = 6
        Me.TodosLosAños.Text = "Include all years"
        Me.TodosLosAños.UseVisualStyleBackColor = True
        '
        'ACTMVAN3
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(526, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.TodosLosAños)
        Me.Controls.Add(Me.cboMeses)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.grpTipoActivo)
        Me.Controls.Add(Me.cboTotalizado)
        Me.Controls.Add(Me.grpDivision)
        Me.Controls.Add(Me.lblTotalizadoPor)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(229, 115)
        Me.MaximizeBox = False
        Me.Name = "ACTMVAN3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de depreciaciones de activos fijos - ACTMVAN3"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoActivo.ResumeLayout(False)
        Me.grpTipoActivo.PerformLayout()
        Me.grpDivision.ResumeLayout(False)
        Me.grpDivision.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtAnio As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTipoActivoFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents txtTipoActivoInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblAnio As System.Windows.Forms.Label
    Public WithEvents lblMes As System.Windows.Forms.Label
    Public WithEvents grpTipoActivo As System.Windows.Forms.GroupBox
    Public WithEvents lblTipoActivoInicial As System.Windows.Forms.Label
    Public WithEvents lblTipoActivoFinal As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoFinal As System.Windows.Forms.Label
    Public WithEvents txtDivisionFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents cboTotalizado As System.Windows.Forms.ComboBox
    Public WithEvents txtDivisionInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents grpDivision As System.Windows.Forms.GroupBox
    Public WithEvents lblDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblDivisionFinal As System.Windows.Forms.Label
    Public WithEvents lblNombreDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreDivisionFinal As System.Windows.Forms.Label
    Public WithEvents lblTotalizadoPor As System.Windows.Forms.Label
    Public WithEvents cboMeses As System.Windows.Forms.ComboBox
    Friend WithEvents TodosLosAños As System.Windows.Forms.CheckBox
End Class
