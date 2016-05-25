<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDispFull
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
        Me.lblFechaMaskFinal = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtFechaFin = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaMaskInicial = New System.Windows.Forms.Label()
        Me.panSinAcceso = New System.Windows.Forms.Panel()
        Me.grdSinAcceso = New System.Windows.Forms.DataGridView()
        Me.DBSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinAcceso = New System.Windows.Forms.Label()
        Me.lblSinMostrar = New System.Windows.Forms.Label()
        Me.grdEmpresas = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BaseDeDatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panFechas = New System.Windows.Forms.Panel()
        Me.radMes = New System.Windows.Forms.RadioButton()
        Me.radFecha = New System.Windows.Forms.RadioButton()
        Me.grpFecha = New System.Windows.Forms.GroupBox()
        Me.grpMes = New System.Windows.Forms.GroupBox()
        Me.cboMeses = New System.Windows.Forms.ComboBox()
        Me.txtAnio = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.panBarras = New System.Windows.Forms.Panel()
        Me.barRegistros = New System.Windows.Forms.ProgressBar()
        Me.barBases = New System.Windows.Forms.ProgressBar()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panSinAcceso.SuspendLayout()
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panFechas.SuspendLayout()
        Me.grpFecha.SuspendLayout()
        Me.grpMes.SuspendLayout()
        Me.panBarras.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFechaMaskFinal
        '
        Me.lblFechaMaskFinal.AutoSize = True
        Me.lblFechaMaskFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaMaskFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaMaskFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMaskFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaMaskFinal.Location = New System.Drawing.Point(430, 47)
        Me.lblFechaMaskFinal.Name = "lblFechaMaskFinal"
        Me.lblFechaMaskFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaMaskFinal.Size = New System.Drawing.Size(83, 14)
        Me.lblFechaMaskFinal.TabIndex = 23
        Me.lblFechaMaskFinal.Text = "(DD/MM/AAAA)"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(385, 369)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 4
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
        Me.cmdCancelar.Location = New System.Drawing.Point(478, 369)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'txtFechaFin
        '
        Me.txtFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaFin.EsRequerido = True
        Me.txtFechaFin.Location = New System.Drawing.Point(204, 45)
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
        Me.lblFechaFin.Location = New System.Drawing.Point(35, 47)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaFin.Size = New System.Drawing.Size(45, 14)
        Me.lblFechaFin.TabIndex = 22
        Me.lblFechaFin.Text = "Al :"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaInicio.EsRequerido = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(204, 19)
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
        Me.lblFechaInicio.Location = New System.Drawing.Point(35, 21)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaInicio.Size = New System.Drawing.Size(45, 14)
        Me.lblFechaInicio.TabIndex = 21
        Me.lblFechaInicio.Text = "Del :"
        '
        'lblFechaMaskInicial
        '
        Me.lblFechaMaskInicial.AutoSize = True
        Me.lblFechaMaskInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaMaskInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaMaskInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMaskInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaMaskInicial.Location = New System.Drawing.Point(430, 21)
        Me.lblFechaMaskInicial.Name = "lblFechaMaskInicial"
        Me.lblFechaMaskInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaMaskInicial.Size = New System.Drawing.Size(83, 14)
        Me.lblFechaMaskInicial.TabIndex = 20
        Me.lblFechaMaskInicial.Text = "(DD/MM/AAAA)"
        '
        'panSinAcceso
        '
        Me.panSinAcceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panSinAcceso.Controls.Add(Me.grdSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinMostrar)
        Me.panSinAcceso.Location = New System.Drawing.Point(12, 400)
        Me.panSinAcceso.Name = "panSinAcceso"
        Me.panSinAcceso.Size = New System.Drawing.Size(553, 147)
        Me.panSinAcceso.TabIndex = 6
        '
        'grdSinAcceso
        '
        Me.grdSinAcceso.AllowUserToAddRows = False
        Me.grdSinAcceso.AllowUserToDeleteRows = False
        Me.grdSinAcceso.AllowUserToResizeRows = False
        Me.grdSinAcceso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSinAcceso.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdSinAcceso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DBSinAcceso, Me.EmpresaSinAcceso})
        Me.grdSinAcceso.Location = New System.Drawing.Point(3, 23)
        Me.grdSinAcceso.Name = "grdSinAcceso"
        Me.grdSinAcceso.ReadOnly = True
        Me.grdSinAcceso.RowHeadersVisible = False
        Me.grdSinAcceso.Size = New System.Drawing.Size(547, 121)
        Me.grdSinAcceso.TabIndex = 1
        '
        'DBSinAcceso
        '
        Me.DBSinAcceso.HeaderText = "Base de Datos"
        Me.DBSinAcceso.MinimumWidth = 110
        Me.DBSinAcceso.Name = "DBSinAcceso"
        Me.DBSinAcceso.ReadOnly = True
        Me.DBSinAcceso.Width = 110
        '
        'EmpresaSinAcceso
        '
        Me.EmpresaSinAcceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpresaSinAcceso.HeaderText = "Empresas"
        Me.EmpresaSinAcceso.MinimumWidth = 100
        Me.EmpresaSinAcceso.Name = "EmpresaSinAcceso"
        Me.EmpresaSinAcceso.ReadOnly = True
        '
        'lblSinAcceso
        '
        Me.lblSinAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSinAcceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSinAcceso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSinAcceso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinAcceso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSinAcceso.Location = New System.Drawing.Point(0, 0)
        Me.lblSinAcceso.Name = "lblSinAcceso"
        Me.lblSinAcceso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSinAcceso.Size = New System.Drawing.Size(238, 20)
        Me.lblSinAcceso.TabIndex = 41
        Me.lblSinAcceso.Text = "Empresas sin acceso"
        '
        'lblSinMostrar
        '
        Me.lblSinMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSinMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSinMostrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSinMostrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinMostrar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSinMostrar.Location = New System.Drawing.Point(157, 48)
        Me.lblSinMostrar.Name = "lblSinMostrar"
        Me.lblSinMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSinMostrar.Size = New System.Drawing.Size(238, 20)
        Me.lblSinMostrar.TabIndex = 43
        Me.lblSinMostrar.Text = "No hay empresas sin acceso"
        Me.lblSinMostrar.Visible = False
        '
        'grdEmpresas
        '
        Me.grdEmpresas.AllowUserToAddRows = False
        Me.grdEmpresas.AllowUserToDeleteRows = False
        Me.grdEmpresas.AllowUserToResizeRows = False
        Me.grdEmpresas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEmpresas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.BaseDeDatos, Me.Empresas})
        Me.grdEmpresas.Location = New System.Drawing.Point(12, 12)
        Me.grdEmpresas.Name = "grdEmpresas"
        Me.grdEmpresas.RowHeadersVisible = False
        Me.grdEmpresas.Size = New System.Drawing.Size(553, 169)
        Me.grdEmpresas.TabIndex = 1
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.MinimumWidth = 75
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 75
        '
        'BaseDeDatos
        '
        Me.BaseDeDatos.HeaderText = "Base de Datos"
        Me.BaseDeDatos.MinimumWidth = 110
        Me.BaseDeDatos.Name = "BaseDeDatos"
        Me.BaseDeDatos.ReadOnly = True
        Me.BaseDeDatos.Width = 110
        '
        'Empresas
        '
        Me.Empresas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Empresas.HeaderText = "Empresas"
        Me.Empresas.MinimumWidth = 175
        Me.Empresas.Name = "Empresas"
        Me.Empresas.ReadOnly = True
        '
        'panFechas
        '
        Me.panFechas.Controls.Add(Me.radMes)
        Me.panFechas.Controls.Add(Me.radFecha)
        Me.panFechas.Controls.Add(Me.grpFecha)
        Me.panFechas.Controls.Add(Me.grpMes)
        Me.panFechas.Location = New System.Drawing.Point(12, 187)
        Me.panFechas.Name = "panFechas"
        Me.panFechas.Size = New System.Drawing.Size(553, 230)
        Me.panFechas.TabIndex = 2
        '
        'radMes
        '
        Me.radMes.BackColor = System.Drawing.SystemColors.Control
        Me.radMes.Checked = True
        Me.radMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.radMes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radMes.Location = New System.Drawing.Point(9, 2)
        Me.radMes.Name = "radMes"
        Me.radMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radMes.Size = New System.Drawing.Size(91, 24)
        Me.radMes.TabIndex = 0
        Me.radMes.TabStop = True
        Me.radMes.Text = "By month"
        Me.radMes.UseVisualStyleBackColor = False
        '
        'radFecha
        '
        Me.radFecha.BackColor = System.Drawing.SystemColors.Control
        Me.radFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.radFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFecha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radFecha.Location = New System.Drawing.Point(9, 90)
        Me.radFecha.Name = "radFecha"
        Me.radFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radFecha.Size = New System.Drawing.Size(91, 24)
        Me.radFecha.TabIndex = 2
        Me.radFecha.TabStop = True
        Me.radFecha.Text = "By date"
        Me.radFecha.UseVisualStyleBackColor = False
        '
        'grpFecha
        '
        Me.grpFecha.Controls.Add(Me.txtFechaInicio)
        Me.grpFecha.Controls.Add(Me.lblFechaFin)
        Me.grpFecha.Controls.Add(Me.lblFechaMaskInicial)
        Me.grpFecha.Controls.Add(Me.txtFechaFin)
        Me.grpFecha.Controls.Add(Me.lblFechaInicio)
        Me.grpFecha.Controls.Add(Me.lblFechaMaskFinal)
        Me.grpFecha.Enabled = False
        Me.grpFecha.Location = New System.Drawing.Point(3, 98)
        Me.grpFecha.Name = "grpFecha"
        Me.grpFecha.Size = New System.Drawing.Size(547, 71)
        Me.grpFecha.TabIndex = 3
        Me.grpFecha.TabStop = False
        '
        'grpMes
        '
        Me.grpMes.Controls.Add(Me.cboMeses)
        Me.grpMes.Controls.Add(Me.txtAnio)
        Me.grpMes.Controls.Add(Me.lblAnio)
        Me.grpMes.Controls.Add(Me.lblMes)
        Me.grpMes.Location = New System.Drawing.Point(3, 11)
        Me.grpMes.Name = "grpMes"
        Me.grpMes.Size = New System.Drawing.Size(547, 73)
        Me.grpMes.TabIndex = 1
        Me.grpMes.TabStop = False
        '
        'cboMeses
        '
        Me.cboMeses.BackColor = System.Drawing.SystemColors.Window
        Me.cboMeses.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeses.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMeses.Location = New System.Drawing.Point(204, 19)
        Me.cboMeses.Name = "cboMeses"
        Me.cboMeses.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMeses.Size = New System.Drawing.Size(205, 22)
        Me.cboMeses.TabIndex = 0
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
        Me.txtAnio.Location = New System.Drawing.Point(204, 47)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.NombreDeConsulta = Nothing
        Me.txtAnio.NumeroDecimales = 0
        Me.txtAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAnio.Size = New System.Drawing.Size(49, 20)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAnio
        '
        Me.lblAnio.BackColor = System.Drawing.SystemColors.Control
        Me.lblAnio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAnio.Location = New System.Drawing.Point(35, 49)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnio.Size = New System.Drawing.Size(163, 14)
        Me.lblAnio.TabIndex = 33
        Me.lblAnio.Text = "Año"
        '
        'lblMes
        '
        Me.lblMes.BackColor = System.Drawing.SystemColors.Control
        Me.lblMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMes.Location = New System.Drawing.Point(35, 22)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMes.Size = New System.Drawing.Size(163, 14)
        Me.lblMes.TabIndex = 32
        Me.lblMes.Text = "Mes"
        '
        'panBarras
        '
        Me.panBarras.Controls.Add(Me.barRegistros)
        Me.panBarras.Controls.Add(Me.barBases)
        Me.panBarras.Location = New System.Drawing.Point(12, 187)
        Me.panBarras.Name = "panBarras"
        Me.panBarras.Size = New System.Drawing.Size(553, 59)
        Me.panBarras.TabIndex = 3
        '
        'barRegistros
        '
        Me.barRegistros.Location = New System.Drawing.Point(3, 32)
        Me.barRegistros.Name = "barRegistros"
        Me.barRegistros.Size = New System.Drawing.Size(547, 23)
        Me.barRegistros.TabIndex = 1
        '
        'barBases
        '
        Me.barBases.Location = New System.Drawing.Point(3, 3)
        Me.barBases.Maximum = 2
        Me.barBases.Name = "barBases"
        Me.barBases.Size = New System.Drawing.Size(547, 23)
        Me.barBases.TabIndex = 0
        Me.barBases.Value = 1
        '
        'AddDispFull
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(577, 554)
        Me.Controls.Add(Me.grdEmpresas)
        Me.Controls.Add(Me.panSinAcceso)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.panFechas)
        Me.Controls.Add(Me.panBarras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "AddDispFull"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Excel - AddDispFull"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panSinAcceso.ResumeLayout(False)
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panFechas.ResumeLayout(False)
        Me.grpFecha.ResumeLayout(False)
        Me.grpFecha.PerformLayout()
        Me.grpMes.ResumeLayout(False)
        Me.grpMes.PerformLayout()
        Me.panBarras.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblFechaMaskFinal As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents txtFechaFin As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblFechaFin As System.Windows.Forms.Label
    Public WithEvents txtFechaInicio As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblFechaInicio As System.Windows.Forms.Label
    Public WithEvents lblFechaMaskInicial As System.Windows.Forms.Label
    Friend WithEvents panSinAcceso As System.Windows.Forms.Panel
    Public WithEvents grdSinAcceso As System.Windows.Forms.DataGridView
    Public WithEvents lblSinAcceso As System.Windows.Forms.Label
    Public WithEvents lblSinMostrar As System.Windows.Forms.Label
    Public WithEvents grdEmpresas As System.Windows.Forms.DataGridView
    Friend WithEvents panFechas As System.Windows.Forms.Panel
    Friend WithEvents panBarras As System.Windows.Forms.Panel
    Friend WithEvents barRegistros As System.Windows.Forms.ProgressBar
    Friend WithEvents barBases As System.Windows.Forms.ProgressBar
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BaseDeDatos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpFecha As System.Windows.Forms.GroupBox
    Friend WithEvents grpMes As System.Windows.Forms.GroupBox
    Public WithEvents radMes As System.Windows.Forms.RadioButton
    Public WithEvents cboMeses As System.Windows.Forms.ComboBox
    Public WithEvents txtAnio As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblAnio As System.Windows.Forms.Label
    Public WithEvents lblMes As System.Windows.Forms.Label
    Public WithEvents radFecha As System.Windows.Forms.RadioButton
End Class
