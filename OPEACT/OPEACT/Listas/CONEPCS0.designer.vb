<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONEPCS0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONEPCS0))
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblTitCONSOLIDACION_ID = New System.Windows.Forms.Label()
        Me.lblCONSOLIDACION_ID = New System.Windows.Forms.Label()
        Me.lblTitANO_PERIODO = New System.Windows.Forms.Label()
        Me.lblANO_PERIODO = New System.Windows.Forms.Label()
        Me.lblTitNO_PERIODO = New System.Windows.Forms.Label()
        Me.lblNO_PERIODO = New System.Windows.Forms.Label()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonConsulta = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblTitCONSOLIDACION_ID)
        Me.Encabezado.Controls.Add(Me.lblCONSOLIDACION_ID)
        Me.Encabezado.Controls.Add(Me.lblTitANO_PERIODO)
        Me.Encabezado.Controls.Add(Me.lblANO_PERIODO)
        Me.Encabezado.Controls.Add(Me.lblTitNO_PERIODO)
        Me.Encabezado.Controls.Add(Me.lblNO_PERIODO)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(542, 60)
        Me.Encabezado.TabIndex = 43
        '
        'lblTitCONSOLIDACION_ID
        '
        Me.lblTitCONSOLIDACION_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitCONSOLIDACION_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitCONSOLIDACION_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCONSOLIDACION_ID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCONSOLIDACION_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCONSOLIDACION_ID.Location = New System.Drawing.Point(0, 0)
        Me.lblTitCONSOLIDACION_ID.Name = "lblTitCONSOLIDACION_ID"
        Me.lblTitCONSOLIDACION_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCONSOLIDACION_ID.Size = New System.Drawing.Size(96, 20)
        Me.lblTitCONSOLIDACION_ID.TabIndex = 16
        Me.lblTitCONSOLIDACION_ID.Text = "Consolidación"
        '
        'lblCONSOLIDACION_ID
        '
        Me.lblCONSOLIDACION_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCONSOLIDACION_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCONSOLIDACION_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCONSOLIDACION_ID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCONSOLIDACION_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCONSOLIDACION_ID.Location = New System.Drawing.Point(96, 0)
        Me.lblCONSOLIDACION_ID.Name = "lblCONSOLIDACION_ID"
        Me.lblCONSOLIDACION_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCONSOLIDACION_ID.Size = New System.Drawing.Size(192, 20)
        Me.lblCONSOLIDACION_ID.TabIndex = 17
        Me.lblCONSOLIDACION_ID.Text = "Consolidación"
        '
        'lblTitANO_PERIODO
        '
        Me.lblTitANO_PERIODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitANO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitANO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitANO_PERIODO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitANO_PERIODO.Location = New System.Drawing.Point(0, 20)
        Me.lblTitANO_PERIODO.Name = "lblTitANO_PERIODO"
        Me.lblTitANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitANO_PERIODO.Size = New System.Drawing.Size(96, 20)
        Me.lblTitANO_PERIODO.TabIndex = 18
        Me.lblTitANO_PERIODO.Text = "Año"
        '
        'lblANO_PERIODO
        '
        Me.lblANO_PERIODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblANO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblANO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblANO_PERIODO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblANO_PERIODO.Location = New System.Drawing.Point(96, 20)
        Me.lblANO_PERIODO.Name = "lblANO_PERIODO"
        Me.lblANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblANO_PERIODO.Size = New System.Drawing.Size(96, 20)
        Me.lblANO_PERIODO.TabIndex = 19
        Me.lblANO_PERIODO.Text = "Año"
        '
        'lblTitNO_PERIODO
        '
        Me.lblTitNO_PERIODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitNO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitNO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_PERIODO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_PERIODO.Location = New System.Drawing.Point(0, 40)
        Me.lblTitNO_PERIODO.Name = "lblTitNO_PERIODO"
        Me.lblTitNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_PERIODO.Size = New System.Drawing.Size(96, 20)
        Me.lblTitNO_PERIODO.TabIndex = 20
        Me.lblTitNO_PERIODO.Text = "No. Periodo"
        '
        'lblNO_PERIODO
        '
        Me.lblNO_PERIODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNO_PERIODO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNO_PERIODO.Location = New System.Drawing.Point(96, 40)
        Me.lblNO_PERIODO.Name = "lblNO_PERIODO"
        Me.lblNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNO_PERIODO.Size = New System.Drawing.Size(96, 20)
        Me.lblNO_PERIODO.TabIndex = 21
        Me.lblNO_PERIODO.Text = "No. Periodo"
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(48, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 42
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
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 342)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(562, 23)
        Me.LabelMensaje.TabIndex = 38
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(108, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 40
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'BotonConsulta
        '
        Me.BotonConsulta.ImageKey = "Consulta"
        Me.BotonConsulta.ImageList = Me.IconosMenus
        Me.BotonConsulta.LabelMensaje = Me.LabelMensaje
        Me.BotonConsulta.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsulta.Name = "BotonConsulta"
        Me.BotonConsulta.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsulta.TabIndex = 39
        Me.BotonConsulta.Texto = "@143"
        Me.BotonConsulta.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultar, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(146, 22)
        Me.mnuConsultar.Text = "@143"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(146, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(143, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(146, 22)
        Me.mnuSalir.Text = "@1"
        '
        'CONEPCS0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsulta
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.BotonConsulta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "CONEPCS0"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección partidas consolidadas - CONEPCS0"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonConsulta, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonConsulta As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents lblTitCONSOLIDACION_ID As System.Windows.Forms.Label
    Public WithEvents lblCONSOLIDACION_ID As System.Windows.Forms.Label
    Public WithEvents lblTitANO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblANO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblTitNO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblNO_PERIODO As System.Windows.Forms.Label
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
End Class
