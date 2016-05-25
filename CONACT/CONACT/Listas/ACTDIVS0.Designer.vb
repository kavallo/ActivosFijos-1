<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTDIVS0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTDIVS0))
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonBajarNivel = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonGrafica = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGraficar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBajarNivel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.BotonConsulta = New Citi.Synergia.UIGenerico.BotonMenu()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(128, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 23
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseMnemonic = False
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
        Me.LabelMensaje.Size = New System.Drawing.Size(562, 23)
        Me.LabelMensaje.TabIndex = 17
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(188, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 21
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'BotonBajarNivel
        '
        Me.BotonBajarNivel.ImageKey = "(none)"
        Me.BotonBajarNivel.ImageList = Me.IconosMenus
        Me.BotonBajarNivel.LabelMensaje = Me.LabelMensaje
        Me.BotonBajarNivel.Location = New System.Drawing.Point(88, 30)
        Me.BotonBajarNivel.Name = "BotonBajarNivel"
        Me.BotonBajarNivel.Size = New System.Drawing.Size(40, 40)
        Me.BotonBajarNivel.TabIndex = 20
        Me.BotonBajarNivel.Texto = "Activos fijos por departamento"
        Me.BotonBajarNivel.UseMnemonic = False
        Me.BotonBajarNivel.UseVisualStyleBackColor = True
        '
        'BotonGrafica
        '
        Me.BotonGrafica.ImageKey = "(none)"
        Me.BotonGrafica.ImageList = Me.IconosMenus
        Me.BotonGrafica.LabelMensaje = Me.LabelMensaje
        Me.BotonGrafica.Location = New System.Drawing.Point(48, 30)
        Me.BotonGrafica.Name = "BotonGrafica"
        Me.BotonGrafica.Size = New System.Drawing.Size(40, 40)
        Me.BotonGrafica.TabIndex = 19
        Me.BotonGrafica.Texto = "Gráfica por departamentos"
        Me.BotonGrafica.UseMnemonic = False
        Me.BotonGrafica.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultar, Me.mnuGraficar, Me.mnuBajarNivel, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(278, 22)
        Me.mnuConsultar.Text = "Consulta de departamentos"
        '
        'mnuGraficar
        '
        Me.mnuGraficar.Name = "mnuGraficar"
        Me.mnuGraficar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuGraficar.Size = New System.Drawing.Size(278, 22)
        Me.mnuGraficar.Text = "a por departamentos"
        '
        'mnuBajarNivel
        '
        Me.mnuBajarNivel.Name = "mnuBajarNivel"
        Me.mnuBajarNivel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBajarNivel.Size = New System.Drawing.Size(278, 22)
        Me.mnuBajarNivel.Text = "Activos fijos por departamento"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(278, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(275, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(278, 22)
        Me.mnuSalir.Text = "@1"
        '
        'BotonConsulta
        '
        Me.BotonConsulta.ImageKey = "(none)"
        Me.BotonConsulta.ImageList = Me.IconosMenus
        Me.BotonConsulta.LabelMensaje = Me.LabelMensaje
        Me.BotonConsulta.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsulta.Name = "BotonConsulta"
        Me.BotonConsulta.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsulta.TabIndex = 18
        Me.BotonConsulta.Texto = "Consulta de departamentos"
        Me.BotonConsulta.UseMnemonic = False
        Me.BotonConsulta.UseVisualStyleBackColor = True
        '
        'ACTDIVS0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsulta
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.BotonBajarNivel)
        Me.Controls.Add(Me.BotonGrafica)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BotonConsulta)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTDIVS0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de departamentos - ACTDIVS0"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.BotonConsulta, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonGrafica, 0)
        Me.Controls.SetChildIndex(Me.BotonBajarNivel, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonBajarNivel As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonGrafica As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGraficar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotonConsulta As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents mnuBajarNivel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
End Class
