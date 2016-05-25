<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAS0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMVAS0))
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblnombreactivo = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaMovimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaActivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaPartida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdConsultaActivo = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdConsultaMovimiento = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAgregar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultaPartida = New Citi.Synergia.UIGenerico.BotonMenu()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblnombreactivo)
        Me.Encabezado.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.Encabezado.Controls.Add(Me.lblCODIGO_DE_ACTIVO)
        Me.Encabezado.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.Encabezado.Controls.Add(Me.lblMEJORA_CORRELATIVO)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(542, 43)
        Me.Encabezado.TabIndex = 13
        '
        'lblnombreactivo
        '
        Me.lblnombreactivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblnombreactivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombreactivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreactivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreactivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreactivo.Location = New System.Drawing.Point(185, 20)
        Me.lblnombreactivo.Name = "lblnombreactivo"
        Me.lblnombreactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreactivo.Size = New System.Drawing.Size(357, 20)
        Me.lblnombreactivo.TabIndex = 22
        Me.lblnombreactivo.Text = "Label1"
        '
        'lblTitCODIGO_DE_ACTIVO
        '
        Me.lblTitCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(0, 0)
        Me.lblTitCODIGO_DE_ACTIVO.Name = "lblTitCODIGO_DE_ACTIVO"
        Me.lblTitCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(120, 20)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 18
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Codigo Activo"
        '
        'lblCODIGO_DE_ACTIVO
        '
        Me.lblCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(120, 0)
        Me.lblCODIGO_DE_ACTIVO.Name = "lblCODIGO_DE_ACTIVO"
        Me.lblCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(169, 20)
        Me.lblCODIGO_DE_ACTIVO.TabIndex = 19
        Me.lblCODIGO_DE_ACTIVO.Text = "Codigo Activo"
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitMEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(0, 20)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(120, 20)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 20
        Me.lblTitMEJORA_CORRELATIVO.Text = "Mejora Correlativo"
        '
        'lblMEJORA_CORRELATIVO
        '
        Me.lblMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMEJORA_CORRELATIVO.Location = New System.Drawing.Point(120, 20)
        Me.lblMEJORA_CORRELATIVO.Name = "lblMEJORA_CORRELATIVO"
        Me.lblMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMEJORA_CORRELATIVO.Size = New System.Drawing.Size(65, 20)
        Me.lblMEJORA_CORRELATIVO.TabIndex = 21
        Me.lblMEJORA_CORRELATIVO.Text = "Mejora Correlativo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuBorrar, Me.mnuConsultaMovimiento, Me.mnuConsultaActivo, Me.mnuConsultaPartida, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(304, 22)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(304, 22)
        Me.mnuBorrar.Text = "Borrar"
        '
        'mnuConsultaMovimiento
        '
        Me.mnuConsultaMovimiento.Name = "mnuConsultaMovimiento"
        Me.mnuConsultaMovimiento.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuConsultaMovimiento.Size = New System.Drawing.Size(304, 22)
        Me.mnuConsultaMovimiento.Text = "Consulta a movimientos de activos"
        '
        'mnuConsultaActivo
        '
        Me.mnuConsultaActivo.Name = "mnuConsultaActivo"
        Me.mnuConsultaActivo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuConsultaActivo.Size = New System.Drawing.Size(304, 22)
        Me.mnuConsultaActivo.Text = "Consulta de activos fijos"
        '
        'mnuConsultaPartida
        '
        Me.mnuConsultaPartida.Name = "mnuConsultaPartida"
        Me.mnuConsultaPartida.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuConsultaPartida.Size = New System.Drawing.Size(304, 22)
        Me.mnuConsultaPartida.Text = "Consulta a partida contable"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(304, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(301, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(304, 22)
        Me.mnuSalir.Text = "@1"
        '
        'cmdConsultaActivo
        '
        Me.cmdConsultaActivo.ImageKey = "InfoGeneral"
        Me.cmdConsultaActivo.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaActivo.Location = New System.Drawing.Point(128, 30)
        Me.cmdConsultaActivo.Name = "cmdConsultaActivo"
        Me.cmdConsultaActivo.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaActivo.TabIndex = 41
        Me.cmdConsultaActivo.Texto = "Consulta de activos fijos"
        Me.cmdConsultaActivo.UseVisualStyleBackColor = True
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 342)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(562, 23)
        Me.LabelMensaje.TabIndex = 39
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdConsultaMovimiento
        '
        Me.cmdConsultaMovimiento.ImageKey = "Mejorar"
        Me.cmdConsultaMovimiento.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaMovimiento.Location = New System.Drawing.Point(88, 30)
        Me.cmdConsultaMovimiento.Name = "cmdConsultaMovimiento"
        Me.cmdConsultaMovimiento.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaMovimiento.TabIndex = 40
        Me.cmdConsultaMovimiento.Texto = "Consulta a movimientos de activos"
        Me.cmdConsultaMovimiento.UseVisualStyleBackColor = True
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(208, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 38
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseVisualStyleBackColor = True
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
        Me.IconosMenus.Images.SetKeyName(5, "Salir2")
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(268, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 37
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.ImageKey = "Baja"
        Me.cmdBorrar.ImageList = Me.IconosMenus
        Me.cmdBorrar.LabelMensaje = Me.LabelMensaje
        Me.cmdBorrar.Location = New System.Drawing.Point(48, 30)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(40, 40)
        Me.cmdBorrar.TabIndex = 35
        Me.cmdBorrar.Tag = ""
        Me.cmdBorrar.Texto = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.ImageKey = "Alta"
        Me.cmdAgregar.ImageList = Me.IconosMenus
        Me.cmdAgregar.LabelMensaje = Me.LabelMensaje
        Me.cmdAgregar.Location = New System.Drawing.Point(8, 30)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(40, 40)
        Me.cmdAgregar.TabIndex = 34
        Me.cmdAgregar.Texto = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdConsultaPartida
        '
        Me.cmdConsultaPartida.ImageKey = "ConsultaPartida"
        Me.cmdConsultaPartida.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaPartida.Location = New System.Drawing.Point(168, 30)
        Me.cmdConsultaPartida.Name = "cmdConsultaPartida"
        Me.cmdConsultaPartida.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaPartida.TabIndex = 43
        Me.cmdConsultaPartida.Texto = "Consulta a partida contable"
        Me.cmdConsultaPartida.UseVisualStyleBackColor = True
        '
        'ACTMVAS0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdAgregar
        Me.BotonBorrar = Me.cmdBorrar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.cmdConsultaPartida)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdConsultaActivo)
        Me.Controls.Add(Me.cmdConsultaMovimiento)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.Encabezado)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMVAS0"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de activos fijos - ACTMVAS0"
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.cmdAgregar, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaMovimiento, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaActivo, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaPartida, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaMovimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaActivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaPartida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdConsultaActivo As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdConsultaMovimiento As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAgregar As Citi.Synergia.UIGenerico.BotonMenu
    Public WithEvents lblnombreactivo As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Friend WithEvents cmdConsultaPartida As Citi.Synergia.UIGenerico.BotonMenu
End Class
