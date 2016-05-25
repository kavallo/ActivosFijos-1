<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEES0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTSEES0))
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdModificar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAgregar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultaPartidas = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosConsultasActivos = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdEndoso = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdCoberturas = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaPartidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEndoso = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCoberturas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 320)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(587, 23)
        Me.LabelMensaje.TabIndex = 35
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
        Me.cmdModificar.TabIndex = 38
        Me.cmdModificar.Texto = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.ImageKey = "Baja"
        Me.cmdBorrar.ImageList = Me.IconosMenus
        Me.cmdBorrar.LabelMensaje = Me.LabelMensaje
        Me.cmdBorrar.Location = New System.Drawing.Point(48, 30)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(40, 40)
        Me.cmdBorrar.TabIndex = 37
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
        Me.cmdAgregar.TabIndex = 36
        Me.cmdAgregar.Texto = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(248, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 40
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(308, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 39
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdConsultaPartidas
        '
        Me.cmdConsultaPartidas.ImageKey = "ConsultaPartidasContables"
        Me.cmdConsultaPartidas.ImageList = Me.IconosConsultasActivos
        Me.cmdConsultaPartidas.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaPartidas.Location = New System.Drawing.Point(128, 30)
        Me.cmdConsultaPartidas.Name = "cmdConsultaPartidas"
        Me.cmdConsultaPartidas.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaPartidas.TabIndex = 41
        Me.cmdConsultaPartidas.Texto = "Consulta de pólizas"
        Me.cmdConsultaPartidas.UseVisualStyleBackColor = True
        '
        'IconosConsultasActivos
        '
        Me.IconosConsultasActivos.ImageStream = CType(resources.GetObject("IconosConsultasActivos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosConsultasActivos.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosConsultasActivos.Images.SetKeyName(0, "ConsultaMovimientos")
        Me.IconosConsultasActivos.Images.SetKeyName(1, "ConsultaActivosFijos")
        Me.IconosConsultasActivos.Images.SetKeyName(2, "ConsultaPartidasContables")
        Me.IconosConsultasActivos.Images.SetKeyName(3, "Endoso")
        Me.IconosConsultasActivos.Images.SetKeyName(4, "Coberturas")
        '
        'cmdEndoso
        '
        Me.cmdEndoso.ImageKey = "Endoso"
        Me.cmdEndoso.ImageList = Me.IconosConsultasActivos
        Me.cmdEndoso.LabelMensaje = Me.LabelMensaje
        Me.cmdEndoso.Location = New System.Drawing.Point(168, 30)
        Me.cmdEndoso.Name = "cmdEndoso"
        Me.cmdEndoso.Size = New System.Drawing.Size(40, 40)
        Me.cmdEndoso.TabIndex = 42
        Me.cmdEndoso.Texto = "Endoso de pólizas"
        Me.cmdEndoso.UseVisualStyleBackColor = True
        '
        'cmdCoberturas
        '
        Me.cmdCoberturas.ImageKey = "Coberturas"
        Me.cmdCoberturas.ImageList = Me.IconosConsultasActivos
        Me.cmdCoberturas.LabelMensaje = Me.LabelMensaje
        Me.cmdCoberturas.Location = New System.Drawing.Point(208, 30)
        Me.cmdCoberturas.Name = "cmdCoberturas"
        Me.cmdCoberturas.Size = New System.Drawing.Size(40, 40)
        Me.cmdCoberturas.TabIndex = 43
        Me.cmdCoberturas.Texto = "Coberturas por póliza"
        Me.cmdCoberturas.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuBorrar, Me.mnuModificar, Me.mnuConsultaPartidas, Me.mnuEndoso, Me.mnuCoberturas, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(207, 22)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(207, 22)
        Me.mnuBorrar.Text = "Borrar"
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuModificar.Size = New System.Drawing.Size(207, 22)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuConsultaPartidas
        '
        Me.mnuConsultaPartidas.Name = "mnuConsultaPartidas"
        Me.mnuConsultaPartidas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuConsultaPartidas.Size = New System.Drawing.Size(229, 22)
        Me.mnuConsultaPartidas.Text = "Consulta de pólizas"
        '
        'mnuEndoso
        '
        Me.mnuEndoso.Name = "mnuEndoso"
        Me.mnuEndoso.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuEndoso.Size = New System.Drawing.Size(229, 22)
        Me.mnuEndoso.Text = "Endoso de pólizas"
        '
        'mnuCoberturas
        '
        Me.mnuCoberturas.Name = "mnuCoberturas"
        Me.mnuCoberturas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuCoberturas.Size = New System.Drawing.Size(229, 22)
        Me.mnuCoberturas.Text = "Coberturas por póliza"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(229, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(204, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(229, 22)
        Me.mnuSalir.Text = "@1"
        '
        'ACTSEES0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdAgregar
        Me.BotonBorrar = Me.cmdBorrar
        Me.BotonCambiar = Me.cmdModificar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(587, 343)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdCoberturas)
        Me.Controls.Add(Me.cmdEndoso)
        Me.Controls.Add(Me.cmdConsultaPartidas)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTSEES0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pólizas de seguro - ACTSEES0"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.cmdAgregar, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdModificar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaPartidas, 0)
        Me.Controls.SetChildIndex(Me.cmdEndoso, 0)
        Me.Controls.SetChildIndex(Me.cmdCoberturas, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdModificar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAgregar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdConsultaPartidas As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosConsultasActivos As System.Windows.Forms.ImageList
    Friend WithEvents cmdEndoso As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdCoberturas As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaPartidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEndoso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCoberturas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
End Class
