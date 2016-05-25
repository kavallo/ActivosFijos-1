<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAplicacionManto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAplicacionManto))
        Me.grdFormas = New System.Windows.Forms.DataGridView()
        Me.cboForma = New System.Windows.Forms.ComboBox()
        Me.lblForma = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BotonGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSalir = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdFormas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdFormas
        '
        Me.grdFormas.AllowUserToAddRows = False
        Me.grdFormas.AllowUserToDeleteRows = False
        Me.grdFormas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.grdFormas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdFormas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFormas.BackgroundColor = System.Drawing.Color.White
        Me.grdFormas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFormas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdFormas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFormas.Location = New System.Drawing.Point(12, 56)
        Me.grdFormas.Name = "grdFormas"
        Me.grdFormas.RowHeadersVisible = False
        Me.grdFormas.Size = New System.Drawing.Size(804, 238)
        Me.grdFormas.TabIndex = 1
        '
        'cboForma
        '
        Me.cboForma.BackColor = System.Drawing.SystemColors.Window
        Me.cboForma.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboForma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboForma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboForma.Location = New System.Drawing.Point(58, 28)
        Me.cboForma.Name = "cboForma"
        Me.cboForma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboForma.Size = New System.Drawing.Size(275, 22)
        Me.cboForma.TabIndex = 2
        '
        'lblForma
        '
        Me.lblForma.AutoSize = True
        Me.lblForma.BackColor = System.Drawing.Color.Transparent
        Me.lblForma.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblForma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblForma.Location = New System.Drawing.Point(12, 31)
        Me.lblForma.Name = "lblForma"
        Me.lblForma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblForma.Size = New System.Drawing.Size(40, 14)
        Me.lblForma.TabIndex = 20
        Me.lblForma.Text = "Forma:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonGrabar, Me.ToolStripSeparator1, Me.BotonAgregar, Me.ToolStripSeparator2, Me.BotonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(828, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BotonGrabar
        '
        Me.BotonGrabar.Image = CType(resources.GetObject("BotonGrabar.Image"), System.Drawing.Image)
        Me.BotonGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonGrabar.Name = "BotonGrabar"
        Me.BotonGrabar.Size = New System.Drawing.Size(62, 22)
        Me.BotonGrabar.Text = "Grabar"
        Me.BotonGrabar.ToolTipText = "Grabar información"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BotonAgregar
        '
        Me.BotonAgregar.Image = CType(resources.GetObject("BotonAgregar.Image"), System.Drawing.Image)
        Me.BotonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonAgregar.Name = "BotonAgregar"
        Me.BotonAgregar.Size = New System.Drawing.Size(114, 22)
        Me.BotonAgregar.Text = "Agregar ventana"
        Me.BotonAgregar.ToolTipText = "Agregar aplicación"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BotonSalir
        '
        Me.BotonSalir.Image = CType(resources.GetObject("BotonSalir.Image"), System.Drawing.Image)
        Me.BotonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(49, 22)
        Me.BotonSalir.Text = "Salir"
        '
        'FAplicacionManto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 306)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cboForma)
        Me.Controls.Add(Me.lblForma)
        Me.Controls.Add(Me.grdFormas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "FAplicacionManto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento aplicación "
        CType(Me.grdFormas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdFormas As System.Windows.Forms.DataGridView
    Public WithEvents cboForma As System.Windows.Forms.ComboBox
    Public WithEvents lblForma As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BotonGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BotonSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents BotonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
