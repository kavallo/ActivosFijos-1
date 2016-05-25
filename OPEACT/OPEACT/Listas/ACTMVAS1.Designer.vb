<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAS1
    Inherits Citi.Synergia.UIGenerico.FormaSelNav

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMVAS1))
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblTitCampo = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblTitDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.cmdConsultaMovimientos = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosConsultasActivos = New System.Windows.Forms.ImageList(Me.components)
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultaActivo = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultaPartidas = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosLocales = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCalculo = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAutorizacion = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdReporteDepreciacion = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdReportePartidaTrabajo = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaMovimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaActivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaPartidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutorizacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReporteDepreciacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportePartida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 382)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(605, 23)
        Me.LabelMensaje.TabIndex = 25
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblTitCampo)
        Me.Encabezado.Controls.Add(Me.lblMes)
        Me.Encabezado.Controls.Add(Me.lblTitDESCRIPCION_DIVISION)
        Me.Encabezado.Controls.Add(Me.lblAnio)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(585, 41)
        Me.Encabezado.TabIndex = 26
        '
        'lblTitCampo
        '
        Me.lblTitCampo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitCampo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitCampo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCampo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCampo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCampo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitCampo.Name = "lblTitCampo"
        Me.lblTitCampo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCampo.Size = New System.Drawing.Size(96, 20)
        Me.lblTitCampo.TabIndex = 15
        Me.lblTitCampo.Text = "Mes"
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
        Me.lblMes.Location = New System.Drawing.Point(96, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMes.Size = New System.Drawing.Size(486, 20)
        Me.lblMes.TabIndex = 16
        '
        'lblTitDESCRIPCION_DIVISION
        '
        Me.lblTitDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitDESCRIPCION_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_DIVISION.Location = New System.Drawing.Point(0, 20)
        Me.lblTitDESCRIPCION_DIVISION.Name = "lblTitDESCRIPCION_DIVISION"
        Me.lblTitDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_DIVISION.Size = New System.Drawing.Size(96, 20)
        Me.lblTitDESCRIPCION_DIVISION.TabIndex = 17
        Me.lblTitDESCRIPCION_DIVISION.Text = "Año"
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
        Me.lblAnio.Location = New System.Drawing.Point(96, 20)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnio.Size = New System.Drawing.Size(486, 20)
        Me.lblAnio.TabIndex = 18
        '
        'cmdConsultaMovimientos
        '
        Me.cmdConsultaMovimientos.ImageKey = "ConsultaMovimientos"
        Me.cmdConsultaMovimientos.ImageList = Me.IconosConsultasActivos
        Me.cmdConsultaMovimientos.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaMovimientos.Location = New System.Drawing.Point(8, 30)
        Me.cmdConsultaMovimientos.Name = "cmdConsultaMovimientos"
        Me.cmdConsultaMovimientos.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaMovimientos.TabIndex = 27
        Me.cmdConsultaMovimientos.Texto = "Consulta a movimientos de activos"
        Me.cmdConsultaMovimientos.UseVisualStyleBackColor = True
        '
        'IconosConsultasActivos
        '
        Me.IconosConsultasActivos.ImageStream = CType(resources.GetObject("IconosConsultasActivos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosConsultasActivos.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosConsultasActivos.Images.SetKeyName(0, "ConsultaMovimientos")
        Me.IconosConsultasActivos.Images.SetKeyName(1, "ConsultaActivosFijos")
        Me.IconosConsultasActivos.Images.SetKeyName(2, "ConsultaPartidasContables")
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
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(328, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 29
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(388, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 28
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdConsultaActivo
        '
        Me.cmdConsultaActivo.ImageKey = "ConsultaActivosFijos"
        Me.cmdConsultaActivo.ImageList = Me.IconosConsultasActivos
        Me.cmdConsultaActivo.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaActivo.Location = New System.Drawing.Point(48, 30)
        Me.cmdConsultaActivo.Name = "cmdConsultaActivo"
        Me.cmdConsultaActivo.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaActivo.TabIndex = 30
        Me.cmdConsultaActivo.Texto = "Consulta de activo fijo"
        Me.cmdConsultaActivo.UseVisualStyleBackColor = True
        '
        'cmdConsultaPartidas
        '
        Me.cmdConsultaPartidas.ImageKey = "ConsultaPartidasContables"
        Me.cmdConsultaPartidas.ImageList = Me.IconosConsultasActivos
        Me.cmdConsultaPartidas.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaPartidas.Location = New System.Drawing.Point(88, 30)
        Me.cmdConsultaPartidas.Name = "cmdConsultaPartidas"
        Me.cmdConsultaPartidas.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaPartidas.TabIndex = 31
        Me.cmdConsultaPartidas.Texto = "Consulta de partidas contables"
        Me.cmdConsultaPartidas.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.ImageKey = "Eliminacion"
        Me.cmdBorrar.ImageList = Me.IconosLocales
        Me.cmdBorrar.LabelMensaje = Me.LabelMensaje
        Me.cmdBorrar.Location = New System.Drawing.Point(128, 30)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(40, 40)
        Me.cmdBorrar.TabIndex = 32
        Me.cmdBorrar.Texto = "Eliminación de movimiento de depreciación"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'IconosLocales
        '
        Me.IconosLocales.ImageStream = CType(resources.GetObject("IconosLocales.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosLocales.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosLocales.Images.SetKeyName(0, "Detalle")
        Me.IconosLocales.Images.SetKeyName(1, "Revaluacion")
        Me.IconosLocales.Images.SetKeyName(2, "Eliminacion")
        Me.IconosLocales.Images.SetKeyName(3, "Calculo")
        Me.IconosLocales.Images.SetKeyName(4, "Autorizacion")
        '
        'cmdCalculo
        '
        Me.cmdCalculo.ImageKey = "Calculo"
        Me.cmdCalculo.ImageList = Me.IconosLocales
        Me.cmdCalculo.LabelMensaje = Me.LabelMensaje
        Me.cmdCalculo.Location = New System.Drawing.Point(168, 30)
        Me.cmdCalculo.Name = "cmdCalculo"
        Me.cmdCalculo.Size = New System.Drawing.Size(40, 40)
        Me.cmdCalculo.TabIndex = 33
        Me.cmdCalculo.Tag = "0207100"
        Me.cmdCalculo.Texto = "Cálculo de depreciación"
        Me.cmdCalculo.UseVisualStyleBackColor = True
        '
        'cmdAutorizacion
        '
        Me.cmdAutorizacion.ImageKey = "Autorizacion"
        Me.cmdAutorizacion.ImageList = Me.IconosLocales
        Me.cmdAutorizacion.LabelMensaje = Me.LabelMensaje
        Me.cmdAutorizacion.Location = New System.Drawing.Point(208, 30)
        Me.cmdAutorizacion.Name = "cmdAutorizacion"
        Me.cmdAutorizacion.Size = New System.Drawing.Size(40, 40)
        Me.cmdAutorizacion.TabIndex = 34
        Me.cmdAutorizacion.Tag = "0207200"
        Me.cmdAutorizacion.Texto = "Autorización de depreciación"
        Me.cmdAutorizacion.UseVisualStyleBackColor = True
        '
        'cmdReporteDepreciacion
        '
        Me.cmdReporteDepreciacion.ImageKey = "Reporte"
        Me.cmdReporteDepreciacion.ImageList = Me.IconosMenus
        Me.cmdReporteDepreciacion.LabelMensaje = Me.LabelMensaje
        Me.cmdReporteDepreciacion.Location = New System.Drawing.Point(248, 30)
        Me.cmdReporteDepreciacion.Name = "cmdReporteDepreciacion"
        Me.cmdReporteDepreciacion.Size = New System.Drawing.Size(40, 40)
        Me.cmdReporteDepreciacion.TabIndex = 35
        Me.cmdReporteDepreciacion.Texto = "Reporte de depreciación de activos"
        Me.cmdReporteDepreciacion.UseVisualStyleBackColor = True
        '
        'cmdReportePartidaTrabajo
        '
        Me.cmdReportePartidaTrabajo.ImageKey = "Reporte"
        Me.cmdReportePartidaTrabajo.ImageList = Me.IconosMenus
        Me.cmdReportePartidaTrabajo.LabelMensaje = Me.LabelMensaje
        Me.cmdReportePartidaTrabajo.Location = New System.Drawing.Point(288, 30)
        Me.cmdReportePartidaTrabajo.Name = "cmdReportePartidaTrabajo"
        Me.cmdReportePartidaTrabajo.Size = New System.Drawing.Size(40, 40)
        Me.cmdReportePartidaTrabajo.TabIndex = 36
        Me.cmdReportePartidaTrabajo.Texto = "Reporte de partida de trabajo por depreciación "
        Me.cmdReportePartidaTrabajo.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(605, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultaMovimiento, Me.mnuConsultaActivo, Me.mnuConsultaPartidas, Me.mnuBorrar, Me.mnuCalculo, Me.mnuAutorizacion, Me.mnuReporteDepreciacion, Me.mnuReportePartida, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultaMovimiento
        '
        Me.mnuConsultaMovimiento.Name = "mnuConsultaMovimiento"
        Me.mnuConsultaMovimiento.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuConsultaMovimiento.Size = New System.Drawing.Size(363, 22)
        Me.mnuConsultaMovimiento.Text = "Consulta a movimientos de activos"
        '
        'mnuConsultaActivo
        '
        Me.mnuConsultaActivo.Name = "mnuConsultaActivo"
        Me.mnuConsultaActivo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultaActivo.Size = New System.Drawing.Size(363, 22)
        Me.mnuConsultaActivo.Text = "Consulta de activo fijo"
        '
        'mnuConsultaPartidas
        '
        Me.mnuConsultaPartidas.Name = "mnuConsultaPartidas"
        Me.mnuConsultaPartidas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuConsultaPartidas.Size = New System.Drawing.Size(363, 22)
        Me.mnuConsultaPartidas.Text = "Consulta de partidas contables"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(363, 22)
        Me.mnuBorrar.Text = "Eliminación de movimiento de depreciación"
        '
        'mnuCalculo
        '
        Me.mnuCalculo.Name = "mnuCalculo"
        Me.mnuCalculo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuCalculo.Size = New System.Drawing.Size(363, 22)
        Me.mnuCalculo.Text = "Cálculo de depreciación"
        '
        'mnuAutorizacion
        '
        Me.mnuAutorizacion.Name = "mnuAutorizacion"
        Me.mnuAutorizacion.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuAutorizacion.Size = New System.Drawing.Size(363, 22)
        Me.mnuAutorizacion.Text = "Autorización de depreciación"
        '
        'mnuReporteDepreciacion
        '
        Me.mnuReporteDepreciacion.Name = "mnuReporteDepreciacion"
        Me.mnuReporteDepreciacion.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuReporteDepreciacion.Size = New System.Drawing.Size(363, 22)
        Me.mnuReporteDepreciacion.Text = "Reporte de depreciación de activos"
        '
        'mnuReportePartida
        '
        Me.mnuReportePartida.Name = "mnuReportePartida"
        Me.mnuReportePartida.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuReportePartida.Size = New System.Drawing.Size(363, 22)
        Me.mnuReportePartida.Text = "Reporte de partida de trabajo por depreciación "
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(363, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(360, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(363, 22)
        Me.mnuSalir.Text = "@1"
        '
        'ACTMVAS1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdConsultaMovimientos
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(605, 405)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdReportePartidaTrabajo)
        Me.Controls.Add(Me.cmdReporteDepreciacion)
        Me.Controls.Add(Me.cmdAutorizacion)
        Me.Controls.Add(Me.cmdCalculo)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdConsultaPartidas)
        Me.Controls.Add(Me.cmdConsultaActivo)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdConsultaMovimientos)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMVAS1"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento activos fijos por depreciacion - ACTMVAS1"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaMovimientos, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaActivo, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaPartidas, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdCalculo, 0)
        Me.Controls.SetChildIndex(Me.cmdAutorizacion, 0)
        Me.Controls.SetChildIndex(Me.cmdReporteDepreciacion, 0)
        Me.Controls.SetChildIndex(Me.cmdReportePartidaTrabajo, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblTitCampo As System.Windows.Forms.Label
    Public WithEvents lblMes As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents cmdConsultaMovimientos As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosConsultasActivos As System.Windows.Forms.ImageList
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents cmdConsultaActivo As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdConsultaPartidas As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosLocales As System.Windows.Forms.ImageList
    Friend WithEvents cmdCalculo As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAutorizacion As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdReporteDepreciacion As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdReportePartidaTrabajo As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaMovimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaActivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaPartidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalculo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAutorizacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReporteDepreciacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportePartida As System.Windows.Forms.ToolStripMenuItem
End Class
