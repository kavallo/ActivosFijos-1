<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PATRES03
    Inherits Citi.Synergia.UIGenerico.FormaSelNav 'System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PATRES03))
        Me.BotonConsultaMayorizada = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonConsultaDetalle = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaMayorizada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdOriginal = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdNuevaCon = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lbldescripcion_origen6 = New System.Windows.Forms.Label()
        Me.lblorigen6 = New System.Windows.Forms.Label()
        Me.lbltitORIGEN6 = New System.Windows.Forms.Label()
        Me.lblorigen5 = New System.Windows.Forms.Label()
        Me.lbltitORIGEN5 = New System.Windows.Forms.Label()
        Me.lbldescripcion_origen5 = New System.Windows.Forms.Label()
        Me.lbldescripcion_origen4 = New System.Windows.Forms.Label()
        Me.lblTitORIGEN4 = New System.Windows.Forms.Label()
        Me.lblORIGEN4 = New System.Windows.Forms.Label()
        Me.lbldescripcion_origen3 = New System.Windows.Forms.Label()
        Me.lblTitORIGEN3 = New System.Windows.Forms.Label()
        Me.lblORIGEN3 = New System.Windows.Forms.Label()
        Me.lbldescripcion_origen2 = New System.Windows.Forms.Label()
        Me.lblTitORIGEN2 = New System.Windows.Forms.Label()
        Me.lblORIGEN2 = New System.Windows.Forms.Label()
        Me.lbldescripcion_origen1 = New System.Windows.Forms.Label()
        Me.lblTitORIGEN1 = New System.Windows.Forms.Label()
        Me.lblORIGEN1 = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'BotonConsultaMayorizada
        '
        Me.BotonConsultaMayorizada.ImageKey = "(none)"
        Me.BotonConsultaMayorizada.ImageList = Me.IconosMenus
        Me.BotonConsultaMayorizada.LabelMensaje = Me.LabelMensaje
        Me.BotonConsultaMayorizada.Location = New System.Drawing.Point(48, 30)
        Me.BotonConsultaMayorizada.Name = "BotonConsultaMayorizada"
        Me.BotonConsultaMayorizada.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsultaMayorizada.TabIndex = 34
        Me.BotonConsultaMayorizada.Texto = "Consulta de partidas mayorizadas"
        Me.BotonConsultaMayorizada.UseMnemonic = False
        Me.BotonConsultaMayorizada.UseVisualStyleBackColor = True
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
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 342)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(579, 23)
        Me.LabelMensaje.TabIndex = 29
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(88, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 33
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseMnemonic = False
        Me.BotonLlenar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(148, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 31
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'BotonConsultaDetalle
        '
        Me.BotonConsultaDetalle.ImageKey = "Consulta"
        Me.BotonConsultaDetalle.ImageList = Me.IconosMenus
        Me.BotonConsultaDetalle.LabelMensaje = Me.LabelMensaje
        Me.BotonConsultaDetalle.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsultaDetalle.Name = "BotonConsultaDetalle"
        Me.BotonConsultaDetalle.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsultaDetalle.TabIndex = 30
        Me.BotonConsultaDetalle.Texto = "Consulta detalle partida contable"
        Me.BotonConsultaDetalle.UseMnemonic = False
        Me.BotonConsultaDetalle.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultaDetalle, Me.mnuConsultaMayorizada, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultaDetalle
        '
        Me.mnuConsultaDetalle.Name = "mnuConsultaDetalle"
        Me.mnuConsultaDetalle.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuConsultaDetalle.Size = New System.Drawing.Size(292, 22)
        Me.mnuConsultaDetalle.Text = "Consulta detalle partida contable"
        '
        'mnuConsultaMayorizada
        '
        Me.mnuConsultaMayorizada.Name = "mnuConsultaMayorizada"
        Me.mnuConsultaMayorizada.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuConsultaMayorizada.Size = New System.Drawing.Size(292, 22)
        Me.mnuConsultaMayorizada.Text = "Consulta de partidas mayorizadas"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(292, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(289, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(292, 22)
        Me.mnuSalir.Text = "@1"
        '
        'cmdOriginal
        '
        Me.cmdOriginal.ImageKey = "(none)"
        Me.cmdOriginal.ImageList = Me.IconosMenus
        Me.cmdOriginal.LabelMensaje = Me.LabelMensaje
        Me.cmdOriginal.Location = New System.Drawing.Point(368, 30)
        Me.cmdOriginal.Name = "cmdOriginal"
        Me.cmdOriginal.Size = New System.Drawing.Size(40, 40)
        Me.cmdOriginal.TabIndex = 35
        Me.cmdOriginal.Texto = "Cambio de marcas"
        Me.cmdOriginal.UseMnemonic = False
        Me.cmdOriginal.UseVisualStyleBackColor = True
        Me.cmdOriginal.Visible = False
        '
        'cmdNuevaCon
        '
        Me.cmdNuevaCon.ImageKey = "(none)"
        Me.cmdNuevaCon.ImageList = Me.IconosMenus
        Me.cmdNuevaCon.LabelMensaje = Me.LabelMensaje
        Me.cmdNuevaCon.Location = New System.Drawing.Point(408, 30)
        Me.cmdNuevaCon.Name = "cmdNuevaCon"
        Me.cmdNuevaCon.Size = New System.Drawing.Size(40, 40)
        Me.cmdNuevaCon.TabIndex = 36
        Me.cmdNuevaCon.Texto = "Cambio de marcas"
        Me.cmdNuevaCon.UseMnemonic = False
        Me.cmdNuevaCon.UseVisualStyleBackColor = True
        Me.cmdNuevaCon.Visible = False
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lbldescripcion_origen6)
        Me.Encabezado.Controls.Add(Me.lblorigen6)
        Me.Encabezado.Controls.Add(Me.lbltitORIGEN6)
        Me.Encabezado.Controls.Add(Me.lblorigen5)
        Me.Encabezado.Controls.Add(Me.lbltitORIGEN5)
        Me.Encabezado.Controls.Add(Me.lbldescripcion_origen5)
        Me.Encabezado.Controls.Add(Me.lbldescripcion_origen4)
        Me.Encabezado.Controls.Add(Me.lblTitORIGEN4)
        Me.Encabezado.Controls.Add(Me.lblORIGEN4)
        Me.Encabezado.Controls.Add(Me.lbldescripcion_origen3)
        Me.Encabezado.Controls.Add(Me.lblTitORIGEN3)
        Me.Encabezado.Controls.Add(Me.lblORIGEN3)
        Me.Encabezado.Controls.Add(Me.lbldescripcion_origen2)
        Me.Encabezado.Controls.Add(Me.lblTitORIGEN2)
        Me.Encabezado.Controls.Add(Me.lblORIGEN2)
        Me.Encabezado.Controls.Add(Me.lbldescripcion_origen1)
        Me.Encabezado.Controls.Add(Me.lblTitORIGEN1)
        Me.Encabezado.Controls.Add(Me.lblORIGEN1)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(458, 105)
        Me.Encabezado.TabIndex = 37
        '
        'lbldescripcion_origen6
        '
        Me.lbldescripcion_origen6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldescripcion_origen6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion_origen6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldescripcion_origen6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion_origen6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbldescripcion_origen6.Location = New System.Drawing.Point(280, 85)
        Me.lbldescripcion_origen6.Name = "lbldescripcion_origen6"
        Me.lbldescripcion_origen6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldescripcion_origen6.Size = New System.Drawing.Size(177, 17)
        Me.lbldescripcion_origen6.TabIndex = 39
        Me.lbldescripcion_origen6.UseMnemonic = False
        '
        'lblorigen6
        '
        Me.lblorigen6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblorigen6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblorigen6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblorigen6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorigen6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblorigen6.Location = New System.Drawing.Point(140, 85)
        Me.lblorigen6.Name = "lblorigen6"
        Me.lblorigen6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblorigen6.Size = New System.Drawing.Size(140, 17)
        Me.lblorigen6.TabIndex = 36
        Me.lblorigen6.Text = "codigo origen6"
        Me.lblorigen6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblorigen6.UseMnemonic = False
        '
        'lbltitORIGEN6
        '
        Me.lbltitORIGEN6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltitORIGEN6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitORIGEN6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitORIGEN6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitORIGEN6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitORIGEN6.Location = New System.Drawing.Point(0, 85)
        Me.lbltitORIGEN6.Name = "lbltitORIGEN6"
        Me.lbltitORIGEN6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitORIGEN6.Size = New System.Drawing.Size(140, 17)
        Me.lbltitORIGEN6.TabIndex = 37
        Me.lbltitORIGEN6.Text = "Origen6"
        Me.lbltitORIGEN6.UseMnemonic = False
        '
        'lblorigen5
        '
        Me.lblorigen5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblorigen5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblorigen5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblorigen5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorigen5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblorigen5.Location = New System.Drawing.Point(140, 68)
        Me.lblorigen5.Name = "lblorigen5"
        Me.lblorigen5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblorigen5.Size = New System.Drawing.Size(140, 17)
        Me.lblorigen5.TabIndex = 38
        Me.lblorigen5.Text = "codigo origen5"
        Me.lblorigen5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblorigen5.UseMnemonic = False
        '
        'lbltitORIGEN5
        '
        Me.lbltitORIGEN5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltitORIGEN5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitORIGEN5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitORIGEN5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitORIGEN5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitORIGEN5.Location = New System.Drawing.Point(0, 68)
        Me.lbltitORIGEN5.Name = "lbltitORIGEN5"
        Me.lbltitORIGEN5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitORIGEN5.Size = New System.Drawing.Size(140, 17)
        Me.lbltitORIGEN5.TabIndex = 40
        Me.lbltitORIGEN5.Text = "Origen5"
        Me.lbltitORIGEN5.UseMnemonic = False
        '
        'lbldescripcion_origen5
        '
        Me.lbldescripcion_origen5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldescripcion_origen5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion_origen5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldescripcion_origen5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion_origen5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbldescripcion_origen5.Location = New System.Drawing.Point(280, 68)
        Me.lbldescripcion_origen5.Name = "lbldescripcion_origen5"
        Me.lbldescripcion_origen5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldescripcion_origen5.Size = New System.Drawing.Size(177, 17)
        Me.lbldescripcion_origen5.TabIndex = 42
        Me.lbldescripcion_origen5.UseMnemonic = False
        '
        'lbldescripcion_origen4
        '
        Me.lbldescripcion_origen4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldescripcion_origen4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion_origen4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldescripcion_origen4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion_origen4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbldescripcion_origen4.Location = New System.Drawing.Point(280, 51)
        Me.lbldescripcion_origen4.Name = "lbldescripcion_origen4"
        Me.lbldescripcion_origen4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldescripcion_origen4.Size = New System.Drawing.Size(177, 17)
        Me.lbldescripcion_origen4.TabIndex = 41
        Me.lbldescripcion_origen4.UseMnemonic = False
        '
        'lblTitORIGEN4
        '
        Me.lblTitORIGEN4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitORIGEN4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitORIGEN4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN4.Location = New System.Drawing.Point(0, 51)
        Me.lblTitORIGEN4.Name = "lblTitORIGEN4"
        Me.lblTitORIGEN4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN4.Size = New System.Drawing.Size(140, 17)
        Me.lblTitORIGEN4.TabIndex = 34
        Me.lblTitORIGEN4.Text = "Origen4"
        Me.lblTitORIGEN4.UseMnemonic = False
        '
        'lblORIGEN4
        '
        Me.lblORIGEN4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblORIGEN4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblORIGEN4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblORIGEN4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORIGEN4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblORIGEN4.Location = New System.Drawing.Point(140, 51)
        Me.lblORIGEN4.Name = "lblORIGEN4"
        Me.lblORIGEN4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblORIGEN4.Size = New System.Drawing.Size(140, 17)
        Me.lblORIGEN4.TabIndex = 35
        Me.lblORIGEN4.Text = "codigo origen4"
        Me.lblORIGEN4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblORIGEN4.UseMnemonic = False
        '
        'lbldescripcion_origen3
        '
        Me.lbldescripcion_origen3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldescripcion_origen3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion_origen3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldescripcion_origen3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion_origen3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbldescripcion_origen3.Location = New System.Drawing.Point(280, 34)
        Me.lbldescripcion_origen3.Name = "lbldescripcion_origen3"
        Me.lbldescripcion_origen3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldescripcion_origen3.Size = New System.Drawing.Size(177, 17)
        Me.lbldescripcion_origen3.TabIndex = 31
        Me.lbldescripcion_origen3.UseMnemonic = False
        '
        'lblTitORIGEN3
        '
        Me.lblTitORIGEN3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitORIGEN3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitORIGEN3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN3.Location = New System.Drawing.Point(0, 34)
        Me.lblTitORIGEN3.Name = "lblTitORIGEN3"
        Me.lblTitORIGEN3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN3.Size = New System.Drawing.Size(140, 17)
        Me.lblTitORIGEN3.TabIndex = 29
        Me.lblTitORIGEN3.Text = "Origen3"
        Me.lblTitORIGEN3.UseMnemonic = False
        '
        'lblORIGEN3
        '
        Me.lblORIGEN3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblORIGEN3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblORIGEN3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblORIGEN3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORIGEN3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblORIGEN3.Location = New System.Drawing.Point(140, 34)
        Me.lblORIGEN3.Name = "lblORIGEN3"
        Me.lblORIGEN3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblORIGEN3.Size = New System.Drawing.Size(140, 17)
        Me.lblORIGEN3.TabIndex = 30
        Me.lblORIGEN3.Text = "codigo origen3"
        Me.lblORIGEN3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblORIGEN3.UseMnemonic = False
        '
        'lbldescripcion_origen2
        '
        Me.lbldescripcion_origen2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldescripcion_origen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion_origen2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldescripcion_origen2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion_origen2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbldescripcion_origen2.Location = New System.Drawing.Point(280, 17)
        Me.lbldescripcion_origen2.Name = "lbldescripcion_origen2"
        Me.lbldescripcion_origen2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldescripcion_origen2.Size = New System.Drawing.Size(177, 17)
        Me.lbldescripcion_origen2.TabIndex = 28
        Me.lbldescripcion_origen2.UseMnemonic = False
        '
        'lblTitORIGEN2
        '
        Me.lblTitORIGEN2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitORIGEN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitORIGEN2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN2.Location = New System.Drawing.Point(0, 17)
        Me.lblTitORIGEN2.Name = "lblTitORIGEN2"
        Me.lblTitORIGEN2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN2.Size = New System.Drawing.Size(140, 17)
        Me.lblTitORIGEN2.TabIndex = 26
        Me.lblTitORIGEN2.Text = "Origen2"
        Me.lblTitORIGEN2.UseMnemonic = False
        '
        'lblORIGEN2
        '
        Me.lblORIGEN2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblORIGEN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblORIGEN2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblORIGEN2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORIGEN2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblORIGEN2.Location = New System.Drawing.Point(140, 17)
        Me.lblORIGEN2.Name = "lblORIGEN2"
        Me.lblORIGEN2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblORIGEN2.Size = New System.Drawing.Size(140, 17)
        Me.lblORIGEN2.TabIndex = 27
        Me.lblORIGEN2.Text = "codigo origen 2"
        Me.lblORIGEN2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblORIGEN2.UseMnemonic = False
        '
        'lbldescripcion_origen1
        '
        Me.lbldescripcion_origen1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldescripcion_origen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldescripcion_origen1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldescripcion_origen1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion_origen1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbldescripcion_origen1.Location = New System.Drawing.Point(280, 0)
        Me.lbldescripcion_origen1.Name = "lbldescripcion_origen1"
        Me.lbldescripcion_origen1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldescripcion_origen1.Size = New System.Drawing.Size(177, 17)
        Me.lbldescripcion_origen1.TabIndex = 25
        Me.lbldescripcion_origen1.UseMnemonic = False
        '
        'lblTitORIGEN1
        '
        Me.lblTitORIGEN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitORIGEN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitORIGEN1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN1.Location = New System.Drawing.Point(0, 0)
        Me.lblTitORIGEN1.Name = "lblTitORIGEN1"
        Me.lblTitORIGEN1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN1.Size = New System.Drawing.Size(140, 17)
        Me.lblTitORIGEN1.TabIndex = 23
        Me.lblTitORIGEN1.Text = "Origen1"
        Me.lblTitORIGEN1.UseMnemonic = False
        '
        'lblORIGEN1
        '
        Me.lblORIGEN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblORIGEN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblORIGEN1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblORIGEN1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORIGEN1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblORIGEN1.Location = New System.Drawing.Point(140, 0)
        Me.lblORIGEN1.Name = "lblORIGEN1"
        Me.lblORIGEN1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblORIGEN1.Size = New System.Drawing.Size(140, 17)
        Me.lblORIGEN1.TabIndex = 24
        Me.lblORIGEN1.Text = "codigo origen1"
        Me.lblORIGEN1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblORIGEN1.UseMnemonic = False
        '
        'PATRES03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsultaDetalle
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(579, 365)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.cmdNuevaCon)
        Me.Controls.Add(Me.cmdOriginal)
        Me.Controls.Add(Me.BotonConsultaMayorizada)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.BotonConsultaDetalle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "PATRES03"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Es Variable Segun las Partidas que se consultan ver:LlenarParam()"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonConsultaDetalle, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.BotonConsultaMayorizada, 0)
        Me.Controls.SetChildIndex(Me.cmdOriginal, 0)
        Me.Controls.SetChildIndex(Me.cmdNuevaCon, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonConsultaMayorizada As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonConsultaDetalle As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents cmdOriginal As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdNuevaCon As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lbldescripcion_origen6 As System.Windows.Forms.Label
    Public WithEvents lblorigen6 As System.Windows.Forms.Label
    Public WithEvents lbltitORIGEN6 As System.Windows.Forms.Label
    Public WithEvents lblorigen5 As System.Windows.Forms.Label
    Public WithEvents lbltitORIGEN5 As System.Windows.Forms.Label
    Public WithEvents lbldescripcion_origen5 As System.Windows.Forms.Label
    Public WithEvents lbldescripcion_origen4 As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN4 As System.Windows.Forms.Label
    Public WithEvents lblORIGEN4 As System.Windows.Forms.Label
    Public WithEvents lbldescripcion_origen3 As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN3 As System.Windows.Forms.Label
    Public WithEvents lblORIGEN3 As System.Windows.Forms.Label
    Public WithEvents lbldescripcion_origen2 As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN2 As System.Windows.Forms.Label
    Public WithEvents lblORIGEN2 As System.Windows.Forms.Label
    Public WithEvents lbldescripcion_origen1 As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN1 As System.Windows.Forms.Label
    Public WithEvents lblORIGEN1 As System.Windows.Forms.Label
    Friend WithEvents mnuConsultaMayorizada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
End Class
