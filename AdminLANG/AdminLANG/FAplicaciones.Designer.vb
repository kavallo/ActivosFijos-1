<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAplicaciones
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAplicaciones))
        Me.lstAplicaciones = New System.Windows.Forms.ListView()
        Me.ColAplicacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BotonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAplicaciones
        '
        Me.lstAplicaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAplicaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColAplicacion})
        Me.lstAplicaciones.FullRowSelect = True
        Me.lstAplicaciones.Location = New System.Drawing.Point(12, 32)
        Me.lstAplicaciones.MultiSelect = False
        Me.lstAplicaciones.Name = "lstAplicaciones"
        Me.lstAplicaciones.Size = New System.Drawing.Size(560, 220)
        Me.lstAplicaciones.TabIndex = 1
        Me.lstAplicaciones.UseCompatibleStateImageBehavior = False
        Me.lstAplicaciones.View = System.Windows.Forms.View.Details
        '
        'ColAplicacion
        '
        Me.ColAplicacion.Text = "Aplicación"
        Me.ColAplicacion.Width = 548
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonAgregar, Me.ToolStripSeparator1, Me.BotonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BotonAgregar
        '
        Me.BotonAgregar.Image = CType(resources.GetObject("BotonAgregar.Image"), System.Drawing.Image)
        Me.BotonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonAgregar.Name = "BotonAgregar"
        Me.BotonAgregar.Size = New System.Drawing.Size(69, 22)
        Me.BotonAgregar.Text = "Agregar"
        Me.BotonAgregar.ToolTipText = "Agregar aplicación"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BotonSalir
        '
        Me.BotonSalir.Image = CType(resources.GetObject("BotonSalir.Image"), System.Drawing.Image)
        Me.BotonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(49, 22)
        Me.BotonSalir.Text = "Salir"
        '
        'FAplicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 264)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstAplicaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FAplicaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicaciones."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAplicaciones As System.Windows.Forms.ListView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BotonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BotonSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColAplicacion As System.Windows.Forms.ColumnHeader
End Class
