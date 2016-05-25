<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTRVES0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTRVES0))
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdModificar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAgregar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdDetalleActivoRevaluar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosLocales = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdConsultaRevaluacion = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultaActivoRevaluar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultaPartidaContable = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdProceso = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDetalleActivoRevaluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaRevaluacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaActivoRevaluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaPartidaContable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 342)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(562, 23)
        Me.LabelMensaje.TabIndex = 25
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdModificar
        '
        Me.cmdModificar.ImageKey = "Cambio"
        Me.cmdModificar.ImageList = Me.IconosMenus
        Me.cmdModificar.LabelMensaje = Me.LabelMensaje
        Me.cmdModificar.Location = New System.Drawing.Point(88, 30)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(40, 40)
        Me.cmdModificar.TabIndex = 28
        Me.cmdModificar.Texto = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
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
        'cmdBorrar
        '
        Me.cmdBorrar.ImageKey = "Baja"
        Me.cmdBorrar.ImageList = Me.IconosMenus
        Me.cmdBorrar.LabelMensaje = Me.LabelMensaje
        Me.cmdBorrar.Location = New System.Drawing.Point(48, 30)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(40, 40)
        Me.cmdBorrar.TabIndex = 27
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
        Me.cmdAgregar.TabIndex = 26
        Me.cmdAgregar.Texto = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(328, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 30
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
        Me.cmdSalir.TabIndex = 29
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdDetalleActivoRevaluar
        '
        Me.cmdDetalleActivoRevaluar.ImageKey = "(none)"
        Me.cmdDetalleActivoRevaluar.ImageList = Me.IconosMenus
        Me.cmdDetalleActivoRevaluar.LabelMensaje = Me.LabelMensaje
        Me.cmdDetalleActivoRevaluar.Location = New System.Drawing.Point(128, 30)
        Me.cmdDetalleActivoRevaluar.Name = "cmdDetalleActivoRevaluar"
        Me.cmdDetalleActivoRevaluar.Size = New System.Drawing.Size(40, 40)
        Me.cmdDetalleActivoRevaluar.TabIndex = 31
        Me.cmdDetalleActivoRevaluar.Texto = "Detalle de activos a revaluar"
        Me.cmdDetalleActivoRevaluar.UseVisualStyleBackColor = True
        '
        'IconosLocales
        '
        Me.IconosLocales.ImageStream = CType(resources.GetObject("IconosLocales.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosLocales.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosLocales.Images.SetKeyName(0, "Detalle")
        Me.IconosLocales.Images.SetKeyName(1, "Revaluacion")
        '
        'cmdConsultaRevaluacion
        '
        Me.cmdConsultaRevaluacion.ImageKey = "(none)"
        Me.cmdConsultaRevaluacion.ImageList = Me.IconosMenus
        Me.cmdConsultaRevaluacion.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaRevaluacion.Location = New System.Drawing.Point(168, 30)
        Me.cmdConsultaRevaluacion.Name = "cmdConsultaRevaluacion"
        Me.cmdConsultaRevaluacion.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaRevaluacion.TabIndex = 32
        Me.cmdConsultaRevaluacion.Texto = "Consulta de datos de revaluación"
        Me.cmdConsultaRevaluacion.UseVisualStyleBackColor = True
        '
        'cmdConsultaActivoRevaluar
        '
        Me.cmdConsultaActivoRevaluar.ImageKey = "(none)"
        Me.cmdConsultaActivoRevaluar.ImageList = Me.IconosMenus
        Me.cmdConsultaActivoRevaluar.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaActivoRevaluar.Location = New System.Drawing.Point(208, 30)
        Me.cmdConsultaActivoRevaluar.Name = "cmdConsultaActivoRevaluar"
        Me.cmdConsultaActivoRevaluar.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaActivoRevaluar.TabIndex = 33
        Me.cmdConsultaActivoRevaluar.Texto = "Consulta de activos a revaluar"
        Me.cmdConsultaActivoRevaluar.UseVisualStyleBackColor = True
        '
        'cmdConsultaPartidaContable
        '
        Me.cmdConsultaPartidaContable.ImageKey = "Consulta"
        Me.cmdConsultaPartidaContable.ImageList = Me.IconosMenus
        Me.cmdConsultaPartidaContable.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaPartidaContable.Location = New System.Drawing.Point(248, 30)
        Me.cmdConsultaPartidaContable.Name = "cmdConsultaPartidaContable"
        Me.cmdConsultaPartidaContable.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaPartidaContable.TabIndex = 34
        Me.cmdConsultaPartidaContable.Texto = "Consulta de partida contable"
        Me.cmdConsultaPartidaContable.UseVisualStyleBackColor = True
        '
        'cmdProceso
        '
        Me.cmdProceso.ImageKey = "Revaluacion"
        Me.cmdProceso.ImageList = Me.IconosLocales
        Me.cmdProceso.LabelMensaje = Me.LabelMensaje
        Me.cmdProceso.Location = New System.Drawing.Point(288, 30)
        Me.cmdProceso.Name = "cmdProceso"
        Me.cmdProceso.Size = New System.Drawing.Size(40, 40)
        Me.cmdProceso.TabIndex = 35
        Me.cmdProceso.Texto = "Proceso de revaluación"
        Me.cmdProceso.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuBorrar, Me.mnuModificar, Me.mnuDetalleActivoRevaluar, Me.mnuConsultaRevaluacion, Me.mnuConsultaActivoRevaluar, Me.mnuConsultaPartidaContable, Me.mnuProceso, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(290, 22)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(290, 22)
        Me.mnuBorrar.Text = "Borrar"
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuModificar.Size = New System.Drawing.Size(290, 22)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuDetalleActivoRevaluar
        '
        Me.mnuDetalleActivoRevaluar.Name = "mnuDetalleActivoRevaluar"
        Me.mnuDetalleActivoRevaluar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuDetalleActivoRevaluar.Size = New System.Drawing.Size(290, 22)
        Me.mnuDetalleActivoRevaluar.Text = "Detalle de activos a revaluar"
        '
        'mnuConsultaRevaluacion
        '
        Me.mnuConsultaRevaluacion.Name = "mnuConsultaRevaluacion"
        Me.mnuConsultaRevaluacion.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuConsultaRevaluacion.Size = New System.Drawing.Size(290, 22)
        Me.mnuConsultaRevaluacion.Text = "Consulta de datos de revaluación"
        '
        'mnuConsultaActivoRevaluar
        '
        Me.mnuConsultaActivoRevaluar.Name = "mnuConsultaActivoRevaluar"
        Me.mnuConsultaActivoRevaluar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuConsultaActivoRevaluar.Size = New System.Drawing.Size(290, 22)
        Me.mnuConsultaActivoRevaluar.Text = "Consulta de activos a revaluar"
        '
        'mnuConsultaPartidaContable
        '
        Me.mnuConsultaPartidaContable.Name = "mnuConsultaPartidaContable"
        Me.mnuConsultaPartidaContable.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuConsultaPartidaContable.Size = New System.Drawing.Size(290, 22)
        Me.mnuConsultaPartidaContable.Text = "Consulta de partida contable"
        '
        'mnuProceso
        '
        Me.mnuProceso.Name = "mnuProceso"
        Me.mnuProceso.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuProceso.Size = New System.Drawing.Size(290, 22)
        Me.mnuProceso.Text = "Proceso de revaluación"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(290, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(287, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(290, 22)
        Me.mnuSalir.Text = "@1"
        '
        'ACTRVES0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdAgregar
        Me.BotonBorrar = Me.cmdBorrar
        Me.BotonCambiar = Me.cmdModificar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdProceso)
        Me.Controls.Add(Me.cmdConsultaPartidaContable)
        Me.Controls.Add(Me.cmdConsultaActivoRevaluar)
        Me.Controls.Add(Me.cmdConsultaRevaluacion)
        Me.Controls.Add(Me.cmdDetalleActivoRevaluar)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTRVES0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de revaluacion de activos - ACTRVES0"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.cmdAgregar, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdModificar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.cmdDetalleActivoRevaluar, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaRevaluacion, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaActivoRevaluar, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaPartidaContable, 0)
        Me.Controls.SetChildIndex(Me.cmdProceso, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdModificar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAgregar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdDetalleActivoRevaluar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosLocales As System.Windows.Forms.ImageList
    Friend WithEvents cmdConsultaRevaluacion As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdConsultaActivoRevaluar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdConsultaPartidaContable As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdProceso As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDetalleActivoRevaluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaRevaluacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaActivoRevaluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaPartidaContable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProceso As System.Windows.Forms.ToolStripMenuItem
End Class
