<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTCPPS0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTCPPS0))
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdModificar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAgregar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblTitNUMERO_POLIZA = New System.Windows.Forms.Label()
        Me.lblNUMERO_POLIZA = New System.Windows.Forms.Label()
        Me.lblTitNO_ENDOSO = New System.Windows.Forms.Label()
        Me.lblNO_ENDOSO = New System.Windows.Forms.Label()
        Me.IconosConsultasActivos = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCoberturas = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdCoberturaActivos = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCoberturas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCoberturaActivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.IconosMenus.Images.SetKeyName(7, "Reporte")
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(208, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 45
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseVisualStyleBackColor = True
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 342)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(562, 23)
        Me.LabelMensaje.TabIndex = 48
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(268, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 44
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.ImageKey = "Cambio"
        Me.cmdModificar.ImageList = Me.IconosMenus
        Me.cmdModificar.LabelMensaje = Me.LabelMensaje
        Me.cmdModificar.Location = New System.Drawing.Point(88, 30)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(40, 40)
        Me.cmdModificar.TabIndex = 43
        Me.cmdModificar.Texto = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.ImageKey = "Baja"
        Me.cmdBorrar.ImageList = Me.IconosMenus
        Me.cmdBorrar.LabelMensaje = Me.LabelMensaje
        Me.cmdBorrar.Location = New System.Drawing.Point(48, 30)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(40, 40)
        Me.cmdBorrar.TabIndex = 42
        Me.cmdBorrar.Texto = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.ImageKey = "Alta"
        Me.cmdAgregar.ImageList = Me.IconosMenus
        Me.cmdAgregar.LabelMensaje = Me.LabelMensaje
        Me.cmdAgregar.Location = New System.Drawing.Point(8, 30)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(40, 40)
        Me.cmdAgregar.TabIndex = 41
        Me.cmdAgregar.Texto = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblTitNUMERO_POLIZA)
        Me.Encabezado.Controls.Add(Me.lblNUMERO_POLIZA)
        Me.Encabezado.Controls.Add(Me.lblTitNO_ENDOSO)
        Me.Encabezado.Controls.Add(Me.lblNO_ENDOSO)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(542, 41)
        Me.Encabezado.TabIndex = 46
        '
        'lblTitNUMERO_POLIZA
        '
        Me.lblTitNUMERO_POLIZA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitNUMERO_POLIZA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_POLIZA.Location = New System.Drawing.Point(0, 0)
        Me.lblTitNUMERO_POLIZA.Name = "lblTitNUMERO_POLIZA"
        Me.lblTitNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_POLIZA.Size = New System.Drawing.Size(96, 20)
        Me.lblTitNUMERO_POLIZA.TabIndex = 15
        Me.lblTitNUMERO_POLIZA.Text = "Póliza"
        '
        'lblNUMERO_POLIZA
        '
        Me.lblNUMERO_POLIZA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNUMERO_POLIZA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNUMERO_POLIZA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNUMERO_POLIZA.Location = New System.Drawing.Point(96, 0)
        Me.lblNUMERO_POLIZA.Name = "lblNUMERO_POLIZA"
        Me.lblNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNUMERO_POLIZA.Size = New System.Drawing.Size(443, 20)
        Me.lblNUMERO_POLIZA.TabIndex = 16
        '
        'lblTitNO_ENDOSO
        '
        Me.lblTitNO_ENDOSO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitNO_ENDOSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_ENDOSO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_ENDOSO.Location = New System.Drawing.Point(0, 20)
        Me.lblTitNO_ENDOSO.Name = "lblTitNO_ENDOSO"
        Me.lblTitNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_ENDOSO.Size = New System.Drawing.Size(96, 20)
        Me.lblTitNO_ENDOSO.TabIndex = 17
        Me.lblTitNO_ENDOSO.Text = "Endoso"
        '
        'lblNO_ENDOSO
        '
        Me.lblNO_ENDOSO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNO_ENDOSO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNO_ENDOSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNO_ENDOSO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNO_ENDOSO.Location = New System.Drawing.Point(96, 20)
        Me.lblNO_ENDOSO.Name = "lblNO_ENDOSO"
        Me.lblNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNO_ENDOSO.Size = New System.Drawing.Size(443, 20)
        Me.lblNO_ENDOSO.TabIndex = 18
        '
        'IconosConsultasActivos
        '
        Me.IconosConsultasActivos.ImageStream = CType(resources.GetObject("IconosConsultasActivos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosConsultasActivos.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosConsultasActivos.Images.SetKeyName(0, "ConsultaMovimientos")
        Me.IconosConsultasActivos.Images.SetKeyName(1, "ConsultaActivosFijos")
        Me.IconosConsultasActivos.Images.SetKeyName(2, "ConsultaPartidasContables")
        Me.IconosConsultasActivos.Images.SetKeyName(3, "Endoso")
        Me.IconosConsultasActivos.Images.SetKeyName(4, "Coberturas")
        Me.IconosConsultasActivos.Images.SetKeyName(5, "ActivosAsegurados")
        '
        'cmdCoberturas
        '
        Me.cmdCoberturas.ImageKey = "Coberturas"
        Me.cmdCoberturas.ImageList = Me.IconosConsultasActivos
        Me.cmdCoberturas.LabelMensaje = Me.LabelMensaje
        Me.cmdCoberturas.Location = New System.Drawing.Point(128, 30)
        Me.cmdCoberturas.Name = "cmdCoberturas"
        Me.cmdCoberturas.Size = New System.Drawing.Size(40, 40)
        Me.cmdCoberturas.TabIndex = 47
        Me.cmdCoberturas.Texto = "Consulta de coberturas por póliza"
        Me.cmdCoberturas.UseVisualStyleBackColor = True
        '
        'cmdCoberturaActivos
        '
        Me.cmdCoberturaActivos.ImageKey = "ActivosAsegurados"
        Me.cmdCoberturaActivos.ImageList = Me.IconosConsultasActivos
        Me.cmdCoberturaActivos.LabelMensaje = Me.LabelMensaje
        Me.cmdCoberturaActivos.Location = New System.Drawing.Point(168, 30)
        Me.cmdCoberturaActivos.Name = "cmdCoberturaActivos"
        Me.cmdCoberturaActivos.Size = New System.Drawing.Size(40, 40)
        Me.cmdCoberturaActivos.TabIndex = 49
        Me.cmdCoberturaActivos.Texto = "Activos asegurados a la póliza"
        Me.cmdCoberturaActivos.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuBorrar, Me.mnuModificar, Me.mnuCoberturas, Me.mnuCoberturaActivos, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(293, 22)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(293, 22)
        Me.mnuBorrar.Text = "Borrar"
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuModificar.Size = New System.Drawing.Size(293, 22)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuCoberturas
        '
        Me.mnuCoberturas.Name = "mnuCoberturas"
        Me.mnuCoberturas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuCoberturas.Size = New System.Drawing.Size(293, 22)
        Me.mnuCoberturas.Text = "Consulta de coberturas por póliza"
        '
        'mnuCoberturaActivos
        '
        Me.mnuCoberturaActivos.Name = "mnuCoberturaActivos"
        Me.mnuCoberturaActivos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuCoberturaActivos.Size = New System.Drawing.Size(293, 22)
        Me.mnuCoberturaActivos.Text = "Activos asegurados a la póliza"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(293, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(290, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(293, 22)
        Me.mnuSalir.Text = "@1"
        '
        'ACTCPPS0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdAgregar
        Me.BotonBorrar = Me.cmdBorrar
        Me.BotonCambiar = Me.cmdModificar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdCoberturaActivos)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.cmdCoberturas)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTCPPS0"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coberturas por póliza - ACTCPPS0"
        Me.Controls.SetChildIndex(Me.cmdAgregar, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdModificar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.cmdCoberturas, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.cmdCoberturaActivos, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdModificar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAgregar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblTitNUMERO_POLIZA As System.Windows.Forms.Label
    Public WithEvents lblNUMERO_POLIZA As System.Windows.Forms.Label
    Public WithEvents lblTitNO_ENDOSO As System.Windows.Forms.Label
    Public WithEvents lblNO_ENDOSO As System.Windows.Forms.Label
    Friend WithEvents IconosConsultasActivos As System.Windows.Forms.ImageList
    Friend WithEvents cmdCoberturas As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdCoberturaActivos As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCoberturas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCoberturaActivos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
End Class
