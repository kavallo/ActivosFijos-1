<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafico
    Inherits Citi.Synergia.UIGenerico.Forma 'System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grafico))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.gra = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTipos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gra
        '
        Me.gra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gra.BackColor = System.Drawing.SystemColors.Control
        Me.gra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gra.Cursor = System.Windows.Forms.Cursors.Default
        Me.gra.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gra.Location = New System.Drawing.Point(0, 27)
        Me.gra.Name = "gra"
        Me.gra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gra.Size = New System.Drawing.Size(332, 179)
        Me.gra.TabIndex = 2
        Me.gra.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOpciones})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(334, 24)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOpciones
        '
        Me.MenuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTipos, Me.mnuCopiar, Me.mnuImprimir, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Size = New System.Drawing.Size(42, 20)
        Me.MenuOpciones.Text = "@17"
        '
        'mnuTipos
        '
        Me.mnuTipos.Name = "mnuTipos"
        Me.mnuTipos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuTipos.Size = New System.Drawing.Size(145, 22)
        Me.mnuTipos.Text = "@14"
        '
        'mnuCopiar
        '
        Me.mnuCopiar.Name = "mnuCopiar"
        Me.mnuCopiar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopiar.Size = New System.Drawing.Size(145, 22)
        Me.mnuCopiar.Text = "@168"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Name = "mnuImprimir"
        Me.mnuImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuImprimir.Size = New System.Drawing.Size(145, 22)
        Me.mnuImprimir.Text = "@169"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(145, 22)
        Me.mnuSalir.Text = "@1"
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
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 24)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(334, 182)
        Me.Chart1.TabIndex = 48
        Me.Chart1.Text = "Chart1"
        '
        'Grafico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 206)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gra)
        Me.KeyPreview = True
        Me.Name = "Grafico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents gra As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOpciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTipos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
