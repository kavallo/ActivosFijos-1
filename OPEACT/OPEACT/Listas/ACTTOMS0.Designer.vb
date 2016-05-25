<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTTOMS0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTTOMS0))
        Me.frmFILTRO = New System.Windows.Forms.GroupBox()
        Me.ALL = New System.Windows.Forms.RadioButton()
        Me.AUT = New System.Windows.Forms.RadioButton()
        Me.PEND = New System.Windows.Forms.RadioButton()
        Me.mskFECHAI = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.mskFECHAF = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblFECHAF = New System.Windows.Forms.Label()
        Me.lblFECHAI = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutorizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAutorizar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdModificar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAgregar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.cmdConsultar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdReporte = New Citi.Synergia.UIGenerico.BotonMenu()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmFILTRO.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmFILTRO
        '
        Me.frmFILTRO.BackColor = System.Drawing.SystemColors.Control
        Me.frmFILTRO.Controls.Add(Me.ALL)
        Me.frmFILTRO.Controls.Add(Me.AUT)
        Me.frmFILTRO.Controls.Add(Me.PEND)
        Me.frmFILTRO.Controls.Add(Me.mskFECHAI)
        Me.frmFILTRO.Controls.Add(Me.mskFECHAF)
        Me.frmFILTRO.Controls.Add(Me.lblFECHAF)
        Me.frmFILTRO.Controls.Add(Me.lblFECHAI)
        Me.frmFILTRO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmFILTRO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmFILTRO.Location = New System.Drawing.Point(3, 3)
        Me.frmFILTRO.Name = "frmFILTRO"
        Me.frmFILTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmFILTRO.Size = New System.Drawing.Size(493, 93)
        Me.frmFILTRO.TabIndex = 20
        Me.frmFILTRO.TabStop = False
        Me.frmFILTRO.Text = "Condiciones de documentos:"
        '
        'ALL
        '
        Me.ALL.BackColor = System.Drawing.SystemColors.Control
        Me.ALL.Checked = True
        Me.ALL.Cursor = System.Windows.Forms.Cursors.Default
        Me.ALL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ALL.Location = New System.Drawing.Point(6, 67)
        Me.ALL.Name = "ALL"
        Me.ALL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ALL.Size = New System.Drawing.Size(93, 17)
        Me.ALL.TabIndex = 13
        Me.ALL.TabStop = True
        Me.ALL.Text = "Todas"
        Me.ALL.UseVisualStyleBackColor = False
        '
        'AUT
        '
        Me.AUT.BackColor = System.Drawing.SystemColors.Control
        Me.AUT.Cursor = System.Windows.Forms.Cursors.Default
        Me.AUT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AUT.Location = New System.Drawing.Point(6, 44)
        Me.AUT.Name = "AUT"
        Me.AUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AUT.Size = New System.Drawing.Size(93, 17)
        Me.AUT.TabIndex = 12
        Me.AUT.TabStop = True
        Me.AUT.Text = "Autorizadas"
        Me.AUT.UseVisualStyleBackColor = False
        '
        'PEND
        '
        Me.PEND.BackColor = System.Drawing.SystemColors.Control
        Me.PEND.Cursor = System.Windows.Forms.Cursors.Default
        Me.PEND.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PEND.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PEND.Location = New System.Drawing.Point(6, 21)
        Me.PEND.Name = "PEND"
        Me.PEND.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PEND.Size = New System.Drawing.Size(93, 17)
        Me.PEND.TabIndex = 11
        Me.PEND.TabStop = True
        Me.PEND.Text = "Pendientes"
        Me.PEND.UseVisualStyleBackColor = False
        '
        'mskFECHAI
        '
        Me.mskFECHAI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFECHAI.EsRequerido = False
        Me.mskFECHAI.Location = New System.Drawing.Point(307, 21)
        Me.mskFECHAI.Mask = "00/00/0000"
        Me.mskFECHAI.Name = "mskFECHAI"
        Me.mskFECHAI.Size = New System.Drawing.Size(180, 22)
        Me.mskFECHAI.TabIndex = 14
        Me.mskFECHAI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFECHAI.ValidatingType = GetType(Date)
        '
        'mskFECHAF
        '
        Me.mskFECHAF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFECHAF.EsRequerido = False
        Me.mskFECHAF.Location = New System.Drawing.Point(307, 49)
        Me.mskFECHAF.Mask = "00/00/0000"
        Me.mskFECHAF.Name = "mskFECHAF"
        Me.mskFECHAF.Size = New System.Drawing.Size(180, 22)
        Me.mskFECHAF.TabIndex = 15
        Me.mskFECHAF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFECHAF.ValidatingType = GetType(Date)
        '
        'lblFECHAF
        '
        Me.lblFECHAF.BackColor = System.Drawing.SystemColors.Control
        Me.lblFECHAF.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHAF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFECHAF.Location = New System.Drawing.Point(200, 53)
        Me.lblFECHAF.Name = "lblFECHAF"
        Me.lblFECHAF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHAF.Size = New System.Drawing.Size(85, 14)
        Me.lblFECHAF.TabIndex = 21
        Me.lblFECHAF.Text = "Fecha fin:"
        '
        'lblFECHAI
        '
        Me.lblFECHAI.BackColor = System.Drawing.SystemColors.Control
        Me.lblFECHAI.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHAI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHAI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFECHAI.Location = New System.Drawing.Point(200, 25)
        Me.lblFECHAI.Name = "lblFECHAI"
        Me.lblFECHAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHAI.Size = New System.Drawing.Size(85, 14)
        Me.lblFECHAI.TabIndex = 20
        Me.lblFECHAI.Text = "Fecha inicio:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(718, 24)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuBorrar, Me.mnuModificar, Me.mnuConsultar, Me.mnuAutorizar, Me.mnuReporte, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(299, 22)
        Me.mnuAgregar.Text = "Agregar toma física"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(299, 22)
        Me.mnuBorrar.Text = "Borrar toma física seleccionada"
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuModificar.Size = New System.Drawing.Size(299, 22)
        Me.mnuModificar.Text = "Modificar toma física seleccionada"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(299, 22)
        Me.mnuConsultar.Text = "Consultar toma física"
        '
        'mnuAutorizar
        '
        Me.mnuAutorizar.Name = "mnuAutorizar"
        Me.mnuAutorizar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuAutorizar.Size = New System.Drawing.Size(299, 22)
        Me.mnuAutorizar.Text = "Autorizar resultado de toma física"
        '
        'mnuReporte
        '
        Me.mnuReporte.Name = "mnuReporte"
        Me.mnuReporte.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuReporte.Size = New System.Drawing.Size(299, 22)
        Me.mnuReporte.Text = "Resultado de la toma física"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(299, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(296, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(299, 22)
        Me.mnuSalir.Text = "@1"
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 368)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(718, 23)
        Me.LabelMensaje.TabIndex = 50
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(248, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 49
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
        Me.cmdSalir.Location = New System.Drawing.Point(308, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 48
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdAutorizar
        '
        Me.cmdAutorizar.ImageKey = "(none)"
        Me.cmdAutorizar.ImageList = Me.IconosMenus
        Me.cmdAutorizar.LabelMensaje = Me.LabelMensaje
        Me.cmdAutorizar.Location = New System.Drawing.Point(168, 30)
        Me.cmdAutorizar.Name = "cmdAutorizar"
        Me.cmdAutorizar.Size = New System.Drawing.Size(40, 40)
        Me.cmdAutorizar.TabIndex = 47
        Me.cmdAutorizar.Tag = "0210500"
        Me.cmdAutorizar.Texto = "Autorizar resultado de toma física"
        Me.cmdAutorizar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.ImageKey = "Cambio"
        Me.cmdModificar.ImageList = Me.IconosMenus
        Me.cmdModificar.LabelMensaje = Me.LabelMensaje
        Me.cmdModificar.Location = New System.Drawing.Point(88, 30)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(40, 40)
        Me.cmdModificar.TabIndex = 46
        Me.cmdModificar.Tag = "0210300"
        Me.cmdModificar.Texto = "Modificar toma física seleccionada"
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
        Me.cmdBorrar.TabIndex = 45
        Me.cmdBorrar.Tag = "0210200"
        Me.cmdBorrar.Texto = "Borrar toma física seleccionada"
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
        Me.cmdAgregar.TabIndex = 44
        Me.cmdAgregar.Tag = "0210100"
        Me.cmdAgregar.Texto = "Agregar toma física"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.frmFILTRO)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(698, 99)
        Me.Encabezado.TabIndex = 52
        '
        'cmdConsultar
        '
        Me.cmdConsultar.ImageKey = "Consulta"
        Me.cmdConsultar.ImageList = Me.IconosMenus
        Me.cmdConsultar.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultar.Location = New System.Drawing.Point(128, 30)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultar.TabIndex = 53
        Me.cmdConsultar.Tag = "0210400"
        Me.cmdConsultar.Texto = "Consultar toma física"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdReporte
        '
        Me.cmdReporte.ImageKey = "(none)"
        Me.cmdReporte.ImageList = Me.IconosMenus
        Me.cmdReporte.LabelMensaje = Me.LabelMensaje
        Me.cmdReporte.Location = New System.Drawing.Point(208, 30)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(40, 40)
        Me.cmdReporte.TabIndex = 54
        Me.cmdReporte.Tag = "0210600"
        Me.cmdReporte.Texto = "Resultado de la toma física"
        Me.cmdReporte.UseVisualStyleBackColor = True
        '
        'ACTTOMS0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdAgregar
        Me.BotonBorrar = Me.cmdBorrar
        Me.BotonCambiar = Me.cmdModificar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(718, 391)
        Me.Controls.Add(Me.cmdReporte)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAutorizar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTTOMS0"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de toma física - ACTTOMS0"
        Me.Controls.SetChildIndex(Me.cmdAgregar, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdModificar, 0)
        Me.Controls.SetChildIndex(Me.cmdAutorizar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultar, 0)
        Me.Controls.SetChildIndex(Me.cmdReporte, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmFILTRO.ResumeLayout(False)
        Me.frmFILTRO.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents frmFILTRO As System.Windows.Forms.GroupBox
    Public WithEvents ALL As System.Windows.Forms.RadioButton
    Public WithEvents AUT As System.Windows.Forms.RadioButton
    Public WithEvents PEND As System.Windows.Forms.RadioButton
    Public WithEvents mskFECHAI As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents mskFECHAF As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblFECHAF As System.Windows.Forms.Label
    Public WithEvents lblFECHAI As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAutorizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAutorizar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdModificar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAgregar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Friend WithEvents cmdConsultar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdReporte As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReporte As System.Windows.Forms.ToolStripMenuItem
End Class
