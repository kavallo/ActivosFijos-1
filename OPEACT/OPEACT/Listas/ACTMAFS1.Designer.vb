<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFS1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMAFS1))
        Me.cmdProceso = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosOperacion = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdConsultar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.optPendientes = New System.Windows.Forms.RadioButton()
        Me.optTodos = New System.Windows.Forms.RadioButton()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdProceso
        '
        Me.cmdProceso.ImageKey = "Actualizacion"
        Me.cmdProceso.ImageList = Me.IconosOperacion
        Me.cmdProceso.LabelMensaje = Me.LabelMensaje
        Me.cmdProceso.Location = New System.Drawing.Point(48, 30)
        Me.cmdProceso.Name = "cmdProceso"
        Me.cmdProceso.Size = New System.Drawing.Size(40, 40)
        Me.cmdProceso.TabIndex = 23
        Me.cmdProceso.Texto = "Actualización de activos fijos"
        Me.cmdProceso.UseVisualStyleBackColor = True
        '
        'IconosOperacion
        '
        Me.IconosOperacion.ImageStream = CType(resources.GetObject("IconosOperacion.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosOperacion.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosOperacion.Images.SetKeyName(0, "Consulta")
        Me.IconosOperacion.Images.SetKeyName(1, "Actualizacion")
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 342)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(562, 23)
        Me.LabelMensaje.TabIndex = 28
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdConsultar
        '
        Me.cmdConsultar.ImageKey = "Consulta"
        Me.cmdConsultar.ImageList = Me.IconosOperacion
        Me.cmdConsultar.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultar.Location = New System.Drawing.Point(8, 30)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultar.TabIndex = 22
        Me.cmdConsultar.Texto = "Consulta de activos fijos"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(88, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 27
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
        Me.IconosMenus.Images.SetKeyName(5, "Consulta")
        Me.IconosMenus.Images.SetKeyName(6, "Salir2")
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(148, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 26
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultar, Me.mnuProceso, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(267, 22)
        Me.mnuConsultar.Text = "Consulta de activos fijos"
        '
        'mnuProceso
        '
        Me.mnuProceso.Name = "mnuProceso"
        Me.mnuProceso.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuProceso.Size = New System.Drawing.Size(267, 22)
        Me.mnuProceso.Text = "Actualización de activos fijos"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(267, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(264, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(267, 22)
        Me.mnuSalir.Text = "@1"
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.optPendientes)
        Me.Encabezado.Controls.Add(Me.optTodos)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(542, 45)
        Me.Encabezado.TabIndex = 35
        '
        'optPendientes
        '
        Me.optPendientes.BackColor = System.Drawing.SystemColors.Control
        Me.optPendientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.optPendientes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPendientes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.optPendientes.Location = New System.Drawing.Point(3, 23)
        Me.optPendientes.Name = "optPendientes"
        Me.optPendientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optPendientes.Size = New System.Drawing.Size(180, 20)
        Me.optPendientes.TabIndex = 2
        Me.optPendientes.Text = "Pending authorization"
        Me.optPendientes.UseVisualStyleBackColor = False
        '
        'optTodos
        '
        Me.optTodos.BackColor = System.Drawing.SystemColors.Control
        Me.optTodos.Checked = True
        Me.optTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTodos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTodos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.optTodos.Location = New System.Drawing.Point(3, 3)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTodos.Size = New System.Drawing.Size(180, 20)
        Me.optTodos.TabIndex = 1
        Me.optTodos.TabStop = True
        Me.optTodos.Text = "All"
        Me.optTodos.UseVisualStyleBackColor = False
        '
        'ACTMAFS1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdConsultar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdProceso)
        Me.Controls.Add(Me.cmdConsultar)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMAFS1"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización de activos fijos - ACTMAFS1"
        Me.Controls.SetChildIndex(Me.cmdConsultar, 0)
        Me.Controls.SetChildIndex(Me.cmdProceso, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProceso As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdConsultar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosOperacion As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProceso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents optPendientes As System.Windows.Forms.RadioButton
    Public WithEvents optTodos As System.Windows.Forms.RadioButton
End Class
