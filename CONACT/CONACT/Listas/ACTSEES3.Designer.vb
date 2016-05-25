<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEES3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTSEES3))
        Me.BotonConsulta = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonBajarNivel = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBajarNivel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblNumeroPoliza = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'BotonConsulta
        '
        Me.BotonConsulta.ImageKey = "Cambio"
        Me.BotonConsulta.ImageList = Me.IconosMenus
        Me.BotonConsulta.LabelMensaje = Me.LabelMensaje
        Me.BotonConsulta.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsulta.Name = "BotonConsulta"
        Me.BotonConsulta.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsulta.TabIndex = 42
        Me.BotonConsulta.Texto = "Consulta de pólizas"
        Me.BotonConsulta.UseMnemonic = False
        Me.BotonConsulta.UseVisualStyleBackColor = True
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
        Me.LabelMensaje.TabIndex = 37
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
        Me.BotonLlenar.TabIndex = 41
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
        Me.cmdSalir.TabIndex = 39
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'BotonBajarNivel
        '
        Me.BotonBajarNivel.ImageKey = "(none)"
        Me.BotonBajarNivel.ImageList = Me.IconosMenus
        Me.BotonBajarNivel.LabelMensaje = Me.LabelMensaje
        Me.BotonBajarNivel.Location = New System.Drawing.Point(48, 30)
        Me.BotonBajarNivel.Name = "BotonBajarNivel"
        Me.BotonBajarNivel.Size = New System.Drawing.Size(40, 40)
        Me.BotonBajarNivel.TabIndex = 38
        Me.BotonBajarNivel.Texto = "Consultas por pólizas"
        Me.BotonBajarNivel.UseMnemonic = False
        Me.BotonBajarNivel.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultar, Me.mnuBajarNivel, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(227, 22)
        Me.mnuConsultar.Text = "Consulta de pólizas"
        '
        'mnuBajarNivel
        '
        Me.mnuBajarNivel.Name = "mnuBajarNivel"
        Me.mnuBajarNivel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBajarNivel.Size = New System.Drawing.Size(227, 22)
        Me.mnuBajarNivel.Text = "Consultas por pólizas"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(227, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(224, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(227, 22)
        Me.mnuSalir.Text = "@1"
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblNumeroPoliza)
        Me.Encabezado.Location = New System.Drawing.Point(12, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(538, 22)
        Me.Encabezado.TabIndex = 44
        '
        'lblNumeroPoliza
        '
        Me.lblNumeroPoliza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroPoliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumeroPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroPoliza.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumeroPoliza.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPoliza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNumeroPoliza.Location = New System.Drawing.Point(0, 0)
        Me.lblNumeroPoliza.Name = "lblNumeroPoliza"
        Me.lblNumeroPoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumeroPoliza.Size = New System.Drawing.Size(535, 20)
        Me.lblNumeroPoliza.TabIndex = 14
        Me.lblNumeroPoliza.Text = "Datos"
        Me.lblNumeroPoliza.UseMnemonic = False
        '
        'ACTSEES3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsulta
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonConsulta)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.BotonBajarNivel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTSEES3"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pólizas de seguro vencidas - ACTSEES3"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonBajarNivel, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.BotonConsulta, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonConsulta As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonBajarNivel As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblNumeroPoliza As System.Windows.Forms.Label
    Friend WithEvents mnuBajarNivel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
End Class
