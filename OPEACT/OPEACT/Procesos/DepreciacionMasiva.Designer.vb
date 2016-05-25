<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepreciacionMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepreciacionMasiva))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblAnioPeriodo = New System.Windows.Forms.Label()
        Me.lblNumeroPeriodo = New System.Windows.Forms.Label()
        Me.lblTitAnioPeriodo = New System.Windows.Forms.Label()
        Me.lblTitNumeroPeriodo = New System.Windows.Forms.Label()
        Me.lblTitMesDepreciacion = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblTitAnioDepreciación = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEjecutaProceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.BotonEjecutaProceso = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.lblSinAcceso = New System.Windows.Forms.Label()
        Me.panSinAcceso = New System.Windows.Forms.Panel()
        Me.grdSinAcceso = New System.Windows.Forms.DataGridView()
        Me.BDSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinMostrar = New System.Windows.Forms.Label()
        Me.grdEmpresas = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BaseDeDatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Warnings = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerPendientes = New System.Windows.Forms.DataGridViewLinkColumn()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.panSinAcceso.SuspendLayout()
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.LabelMensaje = Nothing
        Me.cmdSalir.Location = New System.Drawing.Point(68, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 30
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblAnioPeriodo)
        Me.Encabezado.Controls.Add(Me.lblNumeroPeriodo)
        Me.Encabezado.Controls.Add(Me.lblTitAnioPeriodo)
        Me.Encabezado.Controls.Add(Me.lblTitNumeroPeriodo)
        Me.Encabezado.Controls.Add(Me.lblTitMesDepreciacion)
        Me.Encabezado.Controls.Add(Me.lblMes)
        Me.Encabezado.Controls.Add(Me.lblTitAnioDepreciación)
        Me.Encabezado.Controls.Add(Me.lblAnio)
        Me.Encabezado.Location = New System.Drawing.Point(12, 95)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(573, 42)
        Me.Encabezado.TabIndex = 29
        '
        'lblAnioPeriodo
        '
        Me.lblAnioPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnioPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnioPeriodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnioPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnioPeriodo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAnioPeriodo.Location = New System.Drawing.Point(423, 20)
        Me.lblAnioPeriodo.Name = "lblAnioPeriodo"
        Me.lblAnioPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnioPeriodo.Size = New System.Drawing.Size(147, 20)
        Me.lblAnioPeriodo.TabIndex = 22
        Me.lblAnioPeriodo.Visible = False
        '
        'lblNumeroPeriodo
        '
        Me.lblNumeroPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumeroPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroPeriodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumeroPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPeriodo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNumeroPeriodo.Location = New System.Drawing.Point(423, 0)
        Me.lblNumeroPeriodo.Name = "lblNumeroPeriodo"
        Me.lblNumeroPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumeroPeriodo.Size = New System.Drawing.Size(147, 20)
        Me.lblNumeroPeriodo.TabIndex = 21
        Me.lblNumeroPeriodo.Visible = False
        '
        'lblTitAnioPeriodo
        '
        Me.lblTitAnioPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitAnioPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitAnioPeriodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitAnioPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitAnioPeriodo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitAnioPeriodo.Location = New System.Drawing.Point(280, 20)
        Me.lblTitAnioPeriodo.Name = "lblTitAnioPeriodo"
        Me.lblTitAnioPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitAnioPeriodo.Size = New System.Drawing.Size(143, 20)
        Me.lblTitAnioPeriodo.TabIndex = 20
        Me.lblTitAnioPeriodo.Text = "Año período"
        Me.lblTitAnioPeriodo.Visible = False
        '
        'lblTitNumeroPeriodo
        '
        Me.lblTitNumeroPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitNumeroPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitNumeroPeriodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNumeroPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNumeroPeriodo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNumeroPeriodo.Location = New System.Drawing.Point(280, 0)
        Me.lblTitNumeroPeriodo.Name = "lblTitNumeroPeriodo"
        Me.lblTitNumeroPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNumeroPeriodo.Size = New System.Drawing.Size(143, 20)
        Me.lblTitNumeroPeriodo.TabIndex = 19
        Me.lblTitNumeroPeriodo.Text = "Número período"
        Me.lblTitNumeroPeriodo.Visible = False
        '
        'lblTitMesDepreciacion
        '
        Me.lblTitMesDepreciacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitMesDepreciacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitMesDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMesDepreciacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMesDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMesDepreciacion.Location = New System.Drawing.Point(0, 0)
        Me.lblTitMesDepreciacion.Name = "lblTitMesDepreciacion"
        Me.lblTitMesDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMesDepreciacion.Size = New System.Drawing.Size(143, 20)
        Me.lblTitMesDepreciacion.TabIndex = 15
        Me.lblTitMesDepreciacion.Text = "Mes depreciación"
        '
        'lblMes
        '
        Me.lblMes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMes.Location = New System.Drawing.Point(143, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMes.Size = New System.Drawing.Size(427, 20)
        Me.lblMes.TabIndex = 16
        '
        'lblTitAnioDepreciación
        '
        Me.lblTitAnioDepreciación.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitAnioDepreciación.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitAnioDepreciación.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitAnioDepreciación.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitAnioDepreciación.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitAnioDepreciación.Location = New System.Drawing.Point(0, 20)
        Me.lblTitAnioDepreciación.Name = "lblTitAnioDepreciación"
        Me.lblTitAnioDepreciación.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitAnioDepreciación.Size = New System.Drawing.Size(143, 20)
        Me.lblTitAnioDepreciación.TabIndex = 17
        Me.lblTitAnioDepreciación.Text = "Año depreciación"
        '
        'lblAnio
        '
        Me.lblAnio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAnio.Location = New System.Drawing.Point(143, 20)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnio.Size = New System.Drawing.Size(427, 20)
        Me.lblAnio.TabIndex = 18
        '
        'IconosMenus
        '
        Me.IconosMenus.ImageStream = CType(resources.GetObject("IconosMenus.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosMenus.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosMenus.Images.SetKeyName(0, "Baja")
        Me.IconosMenus.Images.SetKeyName(1, "Alta")
        Me.IconosMenus.Images.SetKeyName(2, "Cambio")
        Me.IconosMenus.Images.SetKeyName(3, "Llenar")
        Me.IconosMenus.Images.SetKeyName(4, "Salir")
        Me.IconosMenus.Images.SetKeyName(5, "Consulta")
        Me.IconosMenus.Images.SetKeyName(6, "Salir2")
        Me.IconosMenus.Images.SetKeyName(7, "Reporte")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(597, 24)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEjecutaProceso, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuEjecutaProceso
        '
        Me.mnuEjecutaProceso.Name = "mnuEjecutaProceso"
        Me.mnuEjecutaProceso.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuEjecutaProceso.Size = New System.Drawing.Size(198, 22)
        Me.mnuEjecutaProceso.Text = "Ejecuta proceso"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(195, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(198, 22)
        Me.mnuSalir.Text = "Salir"
        '
        'BotonEjecutaProceso
        '
        Me.BotonEjecutaProceso.ImageKey = "Actualizacion"
        Me.BotonEjecutaProceso.LabelMensaje = Nothing
        Me.BotonEjecutaProceso.Location = New System.Drawing.Point(8, 30)
        Me.BotonEjecutaProceso.Name = "BotonEjecutaProceso"
        Me.BotonEjecutaProceso.Size = New System.Drawing.Size(40, 40)
        Me.BotonEjecutaProceso.TabIndex = 39
        Me.BotonEjecutaProceso.Texto = "Actualización de activos fijos"
        Me.BotonEjecutaProceso.UseVisualStyleBackColor = True
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
        Me.lblSinAcceso.Size = New System.Drawing.Size(158, 20)
        Me.lblSinAcceso.TabIndex = 41
        Me.lblSinAcceso.Text = "Empresas sin acceso"
        '
        'panSinAcceso
        '
        Me.panSinAcceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panSinAcceso.Controls.Add(Me.grdSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinMostrar)
        Me.panSinAcceso.Location = New System.Drawing.Point(12, 311)
        Me.panSinAcceso.Name = "panSinAcceso"
        Me.panSinAcceso.Size = New System.Drawing.Size(573, 117)
        Me.panSinAcceso.TabIndex = 42
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
        Me.grdSinAcceso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BDSinAcceso, Me.EmpresaSinAcceso})
        Me.grdSinAcceso.Location = New System.Drawing.Point(3, 23)
        Me.grdSinAcceso.Name = "grdSinAcceso"
        Me.grdSinAcceso.ReadOnly = True
        Me.grdSinAcceso.RowHeadersVisible = False
        Me.grdSinAcceso.Size = New System.Drawing.Size(567, 91)
        Me.grdSinAcceso.TabIndex = 42
        '
        'BDSinAcceso
        '
        Me.BDSinAcceso.HeaderText = "Base de Datos"
        Me.BDSinAcceso.MinimumWidth = 110
        Me.BDSinAcceso.Name = "BDSinAcceso"
        Me.BDSinAcceso.ReadOnly = True
        Me.BDSinAcceso.Width = 110
        '
        'EmpresaSinAcceso
        '
        Me.EmpresaSinAcceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpresaSinAcceso.HeaderText = "Empresas"
        Me.EmpresaSinAcceso.MinimumWidth = 100
        Me.EmpresaSinAcceso.Name = "EmpresaSinAcceso"
        Me.EmpresaSinAcceso.ReadOnly = True
        '
        'lblSinMostrar
        '
        Me.lblSinMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSinMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSinMostrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSinMostrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinMostrar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSinMostrar.Location = New System.Drawing.Point(167, 48)
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
        Me.grdEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.BaseDeDatos, Me.Empresas, Me.Warnings, Me.VerPendientes})
        Me.grdEmpresas.Location = New System.Drawing.Point(12, 143)
        Me.grdEmpresas.Name = "grdEmpresas"
        Me.grdEmpresas.RowHeadersVisible = False
        Me.grdEmpresas.Size = New System.Drawing.Size(573, 147)
        Me.grdEmpresas.TabIndex = 40
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
        Me.Empresas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Empresas.HeaderText = "Empresas"
        Me.Empresas.MinimumWidth = 175
        Me.Empresas.Name = "Empresas"
        Me.Empresas.ReadOnly = True
        Me.Empresas.Width = 175
        '
        'Warnings
        '
        Me.Warnings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Warnings.HeaderText = "Warnings"
        Me.Warnings.MinimumWidth = 175
        Me.Warnings.Name = "Warnings"
        Me.Warnings.ReadOnly = True
        Me.Warnings.Width = 175
        '
        'VerPendientes
        '
        Me.VerPendientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.VerPendientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.VerPendientes.HeaderText = "Ver pendientes"
        Me.VerPendientes.MinimumWidth = 75
        Me.VerPendientes.Name = "VerPendientes"
        Me.VerPendientes.ReadOnly = True
        '
        'DepreciacionMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 440)
        Me.Controls.Add(Me.panSinAcceso)
        Me.Controls.Add(Me.grdEmpresas)
        Me.Controls.Add(Me.BotonEjecutaProceso)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Encabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "DepreciacionMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variable, se controla en código"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panSinAcceso.ResumeLayout(False)
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblTitMesDepreciacion As System.Windows.Forms.Label
    Public WithEvents lblMes As System.Windows.Forms.Label
    Public WithEvents lblTitAnioDepreciación As System.Windows.Forms.Label
    Public WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEjecutaProceso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotonEjecutaProceso As Citi.Synergia.UIGenerico.BotonMenu
    Public WithEvents lblSinAcceso As System.Windows.Forms.Label
    Friend WithEvents panSinAcceso As System.Windows.Forms.Panel
    Public WithEvents grdSinAcceso As System.Windows.Forms.DataGridView
    Public WithEvents grdEmpresas As System.Windows.Forms.DataGridView
    Public WithEvents lblTitNumeroPeriodo As System.Windows.Forms.Label
    Public WithEvents lblAnioPeriodo As System.Windows.Forms.Label
    Public WithEvents lblNumeroPeriodo As System.Windows.Forms.Label
    Public WithEvents lblTitAnioPeriodo As System.Windows.Forms.Label
    Public WithEvents lblSinMostrar As System.Windows.Forms.Label
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BaseDeDatos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Warnings As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerPendientes As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents BDSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
