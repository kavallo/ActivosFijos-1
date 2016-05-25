<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTTACG0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTTACG0))
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.BotonExportarAExcel = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportarAExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.grdCG = New System.Windows.Forms.DataGridView()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.grdCG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 258)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(533, 25)
        Me.LabelMensaje.TabIndex = 36
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'BotonExportarAExcel
        '
        Me.BotonExportarAExcel.ImageKey = "(none)"
        Me.BotonExportarAExcel.ImageList = Me.IconosMenus
        Me.BotonExportarAExcel.LabelMensaje = Me.LabelMensaje
        Me.BotonExportarAExcel.Location = New System.Drawing.Point(8, 30)
        Me.BotonExportarAExcel.Name = "BotonExportarAExcel"
        Me.BotonExportarAExcel.Size = New System.Drawing.Size(40, 40)
        Me.BotonExportarAExcel.TabIndex = 39
        Me.BotonExportarAExcel.Texto = "Exportar resultados a Excel"
        Me.BotonExportarAExcel.UseMnemonic = False
        Me.BotonExportarAExcel.UseVisualStyleBackColor = True
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
        Me.cmdSalir.Location = New System.Drawing.Point(68, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 38
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOpciones})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOpciones
        '
        Me.MenuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExportarAExcel, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Size = New System.Drawing.Size(42, 20)
        Me.MenuOpciones.Text = "@17"
        '
        'mnuExportarAExcel
        '
        Me.mnuExportarAExcel.Name = "mnuExportarAExcel"
        Me.mnuExportarAExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuExportarAExcel.Size = New System.Drawing.Size(252, 22)
        Me.mnuExportarAExcel.Text = "Exportar resultados a Excel"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(249, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(252, 22)
        Me.mnuSalir.Text = "@1"
        '
        'grdCG
        '
        Me.grdCG.AllowUserToAddRows = False
        Me.grdCG.AllowUserToDeleteRows = False
        Me.grdCG.AllowUserToResizeRows = False
        Me.grdCG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCG.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdCG.Location = New System.Drawing.Point(12, 76)
        Me.grdCG.Name = "grdCG"
        Me.grdCG.ReadOnly = True
        Me.grdCG.RowHeadersVisible = False
        Me.grdCG.Size = New System.Drawing.Size(509, 179)
        Me.grdCG.TabIndex = 41
        '
        'ACTTACG0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 283)
        Me.Controls.Add(Me.grdCG)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BotonExportarAExcel)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LeerPosicion = True
        Me.Name = "ACTTACG0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gráfica tipos de activos - ACTTACG0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.grdCG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents BotonExportarAExcel As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOpciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportarAExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents grdCG As System.Windows.Forms.DataGridView
End Class
