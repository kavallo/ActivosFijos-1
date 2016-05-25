<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFS6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMAFS6))
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.lblCodigoDivision = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblDescripcionDivision = New System.Windows.Forms.Label()
        Me.BotonConsulta = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(48, 30)
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
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 323)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(582, 23)
        Me.LabelMensaje.TabIndex = 18
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblDivision)
        Me.Encabezado.Controls.Add(Me.lblCodigoDivision)
        Me.Encabezado.Controls.Add(Me.lblDescripcion)
        Me.Encabezado.Controls.Add(Me.lblDescripcionDivision)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(562, 44)
        Me.Encabezado.TabIndex = 22
        '
        'lblDivision
        '
        Me.lblDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDivision.Location = New System.Drawing.Point(0, 0)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDivision.Size = New System.Drawing.Size(111, 20)
        Me.lblDivision.TabIndex = 15
        Me.lblDivision.Text = "Departamento"
        Me.lblDivision.UseMnemonic = False
        '
        'lblCodigoDivision
        '
        Me.lblCodigoDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigoDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoDivision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoDivision.Location = New System.Drawing.Point(111, 0)
        Me.lblCodigoDivision.Name = "lblCodigoDivision"
        Me.lblCodigoDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoDivision.Size = New System.Drawing.Size(87, 20)
        Me.lblCodigoDivision.TabIndex = 16
        Me.lblCodigoDivision.UseMnemonic = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDescripcion.Location = New System.Drawing.Point(0, 20)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcion.Size = New System.Drawing.Size(111, 20)
        Me.lblDescripcion.TabIndex = 17
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.UseMnemonic = False
        '
        'lblDescripcionDivision
        '
        Me.lblDescripcionDivision.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescripcionDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDescripcionDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcionDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcionDivision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDescripcionDivision.Location = New System.Drawing.Point(111, 20)
        Me.lblDescripcionDivision.Name = "lblDescripcionDivision"
        Me.lblDescripcionDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcionDivision.Size = New System.Drawing.Size(451, 20)
        Me.lblDescripcionDivision.TabIndex = 18
        Me.lblDescripcionDivision.UseMnemonic = False
        '
        'BotonConsulta
        '
        Me.BotonConsulta.ImageKey = "(none)"
        Me.BotonConsulta.ImageList = Me.IconosMenus
        Me.BotonConsulta.LabelMensaje = Me.LabelMensaje
        Me.BotonConsulta.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsulta.Name = "BotonConsulta"
        Me.BotonConsulta.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsulta.TabIndex = 19
        Me.BotonConsulta.Texto = "Consulta de activos fijos"
        Me.BotonConsulta.UseMnemonic = False
        Me.BotonConsulta.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultar, Me.mnuLlenar, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(242, 22)
        Me.mnuConsultar.Text = "Consulta de activos fijos"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(242, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(239, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(242, 22)
        Me.mnuSalir.Text = "@1"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(108, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 20
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'ACTMAFS6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsulta
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(582, 346)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonConsulta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMAFS6"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de activos fijos - ACTMAFS6"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonConsulta, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblDivision As System.Windows.Forms.Label
    Public WithEvents lblDescripcion As System.Windows.Forms.Label
    Public WithEvents lblDescripcionDivision As System.Windows.Forms.Label
    Friend WithEvents BotonConsulta As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Public WithEvents lblCodigoDivision As System.Windows.Forms.Label
End Class
