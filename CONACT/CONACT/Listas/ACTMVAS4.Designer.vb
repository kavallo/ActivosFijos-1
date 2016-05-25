<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAS4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMVAS4))
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMovimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActivosFijos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPartida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.BotonConsultaMovimientos = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonConsultaActivos = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonConsultaPartida = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.cboMejora = New System.Windows.Forms.ComboBox()
        Me.lblNoMejora = New System.Windows.Forms.Label()
        Me.lblNombreActivo = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblCodigoActivo = New System.Windows.Forms.Label()
        Me.lblMejoraCorrelativo = New System.Windows.Forms.Label()
        Me.lblCodigoMejora = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Encabezado.SuspendLayout()
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
        Me.BotonLlenar.TabIndex = 40
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
        Me.LabelMensaje.TabIndex = 36
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
        Me.cmdSalir.TabIndex = 38
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMovimientos, Me.mnuActivosFijos, Me.mnuPartida, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuMovimientos
        '
        Me.mnuMovimientos.Name = "mnuMovimientos"
        Me.mnuMovimientos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuMovimientos.Size = New System.Drawing.Size(301, 22)
        Me.mnuMovimientos.Text = "Consulta a movimientos de activos"
        '
        'mnuActivosFijos
        '
        Me.mnuActivosFijos.Name = "mnuActivosFijos"
        Me.mnuActivosFijos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuActivosFijos.Size = New System.Drawing.Size(301, 22)
        Me.mnuActivosFijos.Text = "Consulta de activos fijos"
        '
        'mnuPartida
        '
        Me.mnuPartida.Name = "mnuPartida"
        Me.mnuPartida.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuPartida.Size = New System.Drawing.Size(301, 22)
        Me.mnuPartida.Text = "Consulta a partida contable"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(301, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(298, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(301, 22)
        Me.mnuSalir.Text = "@1"
        '
        'BotonConsultaMovimientos
        '
        Me.BotonConsultaMovimientos.ImageKey = "(none)"
        Me.BotonConsultaMovimientos.ImageList = Me.IconosMenus
        Me.BotonConsultaMovimientos.LabelMensaje = Me.LabelMensaje
        Me.BotonConsultaMovimientos.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsultaMovimientos.Name = "BotonConsultaMovimientos"
        Me.BotonConsultaMovimientos.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsultaMovimientos.TabIndex = 37
        Me.BotonConsultaMovimientos.Texto = "Consulta a movimientos de activos"
        Me.BotonConsultaMovimientos.UseMnemonic = False
        Me.BotonConsultaMovimientos.UseVisualStyleBackColor = True
        '
        'BotonConsultaActivos
        '
        Me.BotonConsultaActivos.ImageKey = "(none)"
        Me.BotonConsultaActivos.ImageList = Me.IconosMenus
        Me.BotonConsultaActivos.LabelMensaje = Me.LabelMensaje
        Me.BotonConsultaActivos.Location = New System.Drawing.Point(48, 30)
        Me.BotonConsultaActivos.Name = "BotonConsultaActivos"
        Me.BotonConsultaActivos.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsultaActivos.TabIndex = 41
        Me.BotonConsultaActivos.Texto = "Consulta de activos fijos"
        Me.BotonConsultaActivos.UseMnemonic = False
        Me.BotonConsultaActivos.UseVisualStyleBackColor = True
        '
        'BotonConsultaPartida
        '
        Me.BotonConsultaPartida.ImageKey = "(none)"
        Me.BotonConsultaPartida.ImageList = Me.IconosMenus
        Me.BotonConsultaPartida.LabelMensaje = Me.LabelMensaje
        Me.BotonConsultaPartida.Location = New System.Drawing.Point(88, 30)
        Me.BotonConsultaPartida.Name = "BotonConsultaPartida"
        Me.BotonConsultaPartida.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsultaPartida.TabIndex = 42
        Me.BotonConsultaPartida.Texto = "Consulta a partida contable"
        Me.BotonConsultaPartida.UseMnemonic = False
        Me.BotonConsultaPartida.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.cboMejora)
        Me.Encabezado.Controls.Add(Me.lblNoMejora)
        Me.Encabezado.Controls.Add(Me.lblNombreActivo)
        Me.Encabezado.Controls.Add(Me.lblCodigo)
        Me.Encabezado.Controls.Add(Me.lblCodigoActivo)
        Me.Encabezado.Controls.Add(Me.lblMejoraCorrelativo)
        Me.Encabezado.Controls.Add(Me.lblCodigoMejora)
        Me.Encabezado.Location = New System.Drawing.Point(12, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(538, 43)
        Me.Encabezado.TabIndex = 43
        '
        'cboMejora
        '
        Me.cboMejora.BackColor = System.Drawing.SystemColors.Window
        Me.cboMejora.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMejora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMejora.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMejora.Location = New System.Drawing.Point(387, 0)
        Me.cboMejora.Name = "cboMejora"
        Me.cboMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMejora.Size = New System.Drawing.Size(148, 22)
        Me.cboMejora.TabIndex = 26
        '
        'lblNoMejora
        '
        Me.lblNoMejora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNoMejora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoMejora.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoMejora.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNoMejora.Location = New System.Drawing.Point(314, 0)
        Me.lblNoMejora.Name = "lblNoMejora"
        Me.lblNoMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNoMejora.Size = New System.Drawing.Size(73, 22)
        Me.lblNoMejora.TabIndex = 27
        Me.lblNoMejora.Text = "No. Mejora:"
        Me.lblNoMejora.UseMnemonic = False
        '
        'lblNombreActivo
        '
        Me.lblNombreActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreActivo.Location = New System.Drawing.Point(131, 22)
        Me.lblNombreActivo.Name = "lblNombreActivo"
        Me.lblNombreActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreActivo.Size = New System.Drawing.Size(256, 20)
        Me.lblNombreActivo.TabIndex = 25
        Me.lblNombreActivo.Text = "Label1"
        Me.lblNombreActivo.UseMnemonic = False
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigo.Location = New System.Drawing.Point(0, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigo.Size = New System.Drawing.Size(96, 22)
        Me.lblCodigo.TabIndex = 21
        Me.lblCodigo.Text = "Codigo Activo"
        Me.lblCodigo.UseMnemonic = False
        '
        'lblCodigoActivo
        '
        Me.lblCodigoActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoActivo.Location = New System.Drawing.Point(96, 0)
        Me.lblCodigoActivo.Name = "lblCodigoActivo"
        Me.lblCodigoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoActivo.Size = New System.Drawing.Size(130, 22)
        Me.lblCodigoActivo.TabIndex = 22
        Me.lblCodigoActivo.Text = "Codigo Activo"
        Me.lblCodigoActivo.UseMnemonic = False
        '
        'lblMejoraCorrelativo
        '
        Me.lblMejoraCorrelativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMejoraCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMejoraCorrelativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMejoraCorrelativo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMejoraCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMejoraCorrelativo.Location = New System.Drawing.Point(0, 22)
        Me.lblMejoraCorrelativo.Name = "lblMejoraCorrelativo"
        Me.lblMejoraCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMejoraCorrelativo.Size = New System.Drawing.Size(96, 20)
        Me.lblMejoraCorrelativo.TabIndex = 23
        Me.lblMejoraCorrelativo.Text = "Mejora Correlativo"
        Me.lblMejoraCorrelativo.UseMnemonic = False
        '
        'lblCodigoMejora
        '
        Me.lblCodigoMejora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigoMejora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoMejora.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoMejora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoMejora.Location = New System.Drawing.Point(96, 22)
        Me.lblCodigoMejora.Name = "lblCodigoMejora"
        Me.lblCodigoMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoMejora.Size = New System.Drawing.Size(35, 20)
        Me.lblCodigoMejora.TabIndex = 24
        Me.lblCodigoMejora.Text = "Mejora Correlativo"
        Me.lblCodigoMejora.UseMnemonic = False
        '
        'ACTMVAS4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsultaMovimientos
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonConsultaPartida)
        Me.Controls.Add(Me.BotonConsultaActivos)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BotonConsultaMovimientos)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMVAS4"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de activos fijos - ACTMVAS4"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.BotonConsultaMovimientos, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.BotonConsultaActivos, 0)
        Me.Controls.SetChildIndex(Me.BotonConsultaPartida, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMovimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotonConsultaMovimientos As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonConsultaActivos As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonConsultaPartida As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents cboMejora As System.Windows.Forms.ComboBox
    Public WithEvents lblNoMejora As System.Windows.Forms.Label
    Public WithEvents lblNombreActivo As System.Windows.Forms.Label
    Public WithEvents lblCodigo As System.Windows.Forms.Label
    Public WithEvents lblCodigoActivo As System.Windows.Forms.Label
    Public WithEvents lblMejoraCorrelativo As System.Windows.Forms.Label
    Public WithEvents lblCodigoMejora As System.Windows.Forms.Label
    Friend WithEvents mnuActivosFijos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPartida As System.Windows.Forms.ToolStripMenuItem
End Class
