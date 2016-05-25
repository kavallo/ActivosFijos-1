<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TASASG01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TASASG01))
        Me.grdCG = New System.Windows.Forms.DataGridView()
        Me.cboTIP_CAMBIO_TASAS_CAM = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCODIGO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtFEC_FINAL = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtFEC_INICIAL = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lbltitFEC_FINAL = New System.Windows.Forms.Label()
        Me.lbltitFEC_INICIAL = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitTIP_CAMBIO_TASAS_CAM = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.BotonExportarAExcel = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportarAExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdCG
        '
        Me.grdCG.AllowUserToAddRows = False
        Me.grdCG.AllowUserToDeleteRows = False
        Me.grdCG.AllowUserToResizeRows = False
        Me.grdCG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCG.Location = New System.Drawing.Point(12, 175)
        Me.grdCG.Name = "grdCG"
        Me.grdCG.ReadOnly = True
        Me.grdCG.RowHeadersVisible = False
        Me.grdCG.Size = New System.Drawing.Size(590, 223)
        Me.grdCG.TabIndex = 30
        '
        'cboTIP_CAMBIO_TASAS_CAM
        '
        Me.cboTIP_CAMBIO_TASAS_CAM.BackColor = System.Drawing.SystemColors.Window
        Me.cboTIP_CAMBIO_TASAS_CAM.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTIP_CAMBIO_TASAS_CAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTIP_CAMBIO_TASAS_CAM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTIP_CAMBIO_TASAS_CAM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTIP_CAMBIO_TASAS_CAM.Location = New System.Drawing.Point(141, 103)
        Me.cboTIP_CAMBIO_TASAS_CAM.Name = "cboTIP_CAMBIO_TASAS_CAM"
        Me.cboTIP_CAMBIO_TASAS_CAM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTIP_CAMBIO_TASAS_CAM.Size = New System.Drawing.Size(219, 22)
        Me.cboTIP_CAMBIO_TASAS_CAM.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(325, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "(DD/MM/AAAA)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseMnemonic = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(325, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "(DD/MM/AAAA)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.UseMnemonic = False
        '
        'txtCODIGO_DE_MONEDA
        '
        Me.txtCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCODIGO_DE_MONEDA.EsRequerido = False
        Me.txtCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_MONEDA.LabelConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.Location = New System.Drawing.Point(141, 74)
        Me.txtCODIGO_DE_MONEDA.Name = "txtCODIGO_DE_MONEDA"
        Me.txtCODIGO_DE_MONEDA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMonedas_MONEDC01
        Me.txtCODIGO_DE_MONEDA.ReadOnly = True
        Me.txtCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_MONEDA.Size = New System.Drawing.Size(52, 22)
        Me.txtCODIGO_DE_MONEDA.TabIndex = 3
        '
        'txtFEC_FINAL
        '
        Me.txtFEC_FINAL.BackColor = System.Drawing.SystemColors.Window
        Me.txtFEC_FINAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFEC_FINAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFEC_FINAL.EsRequerido = False
        Me.txtFEC_FINAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFEC_FINAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFEC_FINAL.Location = New System.Drawing.Point(141, 45)
        Me.txtFEC_FINAL.Mask = "00/00/0000"
        Me.txtFEC_FINAL.Name = "txtFEC_FINAL"
        Me.txtFEC_FINAL.ReadOnly = True
        Me.txtFEC_FINAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFEC_FINAL.Size = New System.Drawing.Size(163, 22)
        Me.txtFEC_FINAL.TabIndex = 2
        Me.txtFEC_FINAL.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFEC_FINAL.ValidatingType = GetType(Date)
        '
        'txtFEC_INICIAL
        '
        Me.txtFEC_INICIAL.BackColor = System.Drawing.SystemColors.Window
        Me.txtFEC_INICIAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFEC_INICIAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFEC_INICIAL.EsRequerido = False
        Me.txtFEC_INICIAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFEC_INICIAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFEC_INICIAL.Location = New System.Drawing.Point(141, 16)
        Me.txtFEC_INICIAL.Mask = "00/00/0000"
        Me.txtFEC_INICIAL.Name = "txtFEC_INICIAL"
        Me.txtFEC_INICIAL.ReadOnly = True
        Me.txtFEC_INICIAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFEC_INICIAL.Size = New System.Drawing.Size(163, 22)
        Me.txtFEC_INICIAL.TabIndex = 1
        Me.txtFEC_INICIAL.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFEC_INICIAL.ValidatingType = GetType(Date)
        '
        'lbltitFEC_FINAL
        '
        Me.lbltitFEC_FINAL.BackColor = System.Drawing.Color.Transparent
        Me.lbltitFEC_FINAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitFEC_FINAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitFEC_FINAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitFEC_FINAL.Location = New System.Drawing.Point(6, 48)
        Me.lbltitFEC_FINAL.Name = "lbltitFEC_FINAL"
        Me.lbltitFEC_FINAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitFEC_FINAL.Size = New System.Drawing.Size(129, 20)
        Me.lbltitFEC_FINAL.TabIndex = 23
        Me.lbltitFEC_FINAL.Text = "Fecha final"
        Me.lbltitFEC_FINAL.UseMnemonic = False
        '
        'lbltitFEC_INICIAL
        '
        Me.lbltitFEC_INICIAL.BackColor = System.Drawing.Color.Transparent
        Me.lbltitFEC_INICIAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitFEC_INICIAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitFEC_INICIAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitFEC_INICIAL.Location = New System.Drawing.Point(6, 19)
        Me.lbltitFEC_INICIAL.Name = "lbltitFEC_INICIAL"
        Me.lbltitFEC_INICIAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitFEC_INICIAL.Size = New System.Drawing.Size(129, 20)
        Me.lbltitFEC_INICIAL.TabIndex = 22
        Me.lbltitFEC_INICIAL.Text = "Fecha inicial"
        Me.lbltitFEC_INICIAL.UseMnemonic = False
        '
        'lblDESCRIPCION_MONEDA
        '
        Me.lblDESCRIPCION_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_MONEDA.Location = New System.Drawing.Point(205, 77)
        Me.lblDESCRIPCION_MONEDA.Name = "lblDESCRIPCION_MONEDA"
        Me.lblDESCRIPCION_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_MONEDA.Size = New System.Drawing.Size(203, 20)
        Me.lblDESCRIPCION_MONEDA.TabIndex = 21
        Me.lblDESCRIPCION_MONEDA.UseMnemonic = False
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(6, 77)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(129, 20)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 19
        Me.lblTitCODIGO_DE_MONEDA.Text = "Código de moneda"
        Me.lblTitCODIGO_DE_MONEDA.UseMnemonic = False
        '
        'lblTitTIP_CAMBIO_TASAS_CAM
        '
        Me.lblTitTIP_CAMBIO_TASAS_CAM.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIP_CAMBIO_TASAS_CAM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Location = New System.Drawing.Point(6, 106)
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Name = "lblTitTIP_CAMBIO_TASAS_CAM"
        Me.lblTitTIP_CAMBIO_TASAS_CAM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Size = New System.Drawing.Size(129, 20)
        Me.lblTitTIP_CAMBIO_TASAS_CAM.TabIndex = 20
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Text = "Tipo de cambio"
        Me.lblTitTIP_CAMBIO_TASAS_CAM.UseMnemonic = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtFEC_INICIAL)
        Me.Frame1.Controls.Add(Me.txtFEC_FINAL)
        Me.Frame1.Controls.Add(Me.cboTIP_CAMBIO_TASAS_CAM)
        Me.Frame1.Controls.Add(Me.lblTitTIP_CAMBIO_TASAS_CAM)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.Frame1.Controls.Add(Me.lbltitFEC_INICIAL)
        Me.Frame1.Controls.Add(Me.lblDESCRIPCION_MONEDA)
        Me.Frame1.Controls.Add(Me.txtCODIGO_DE_MONEDA)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lbltitFEC_FINAL)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(188, 30)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(414, 139)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'BotonExportarAExcel
        '
        Me.BotonExportarAExcel.ImageKey = "(none)"
        Me.BotonExportarAExcel.ImageList = Me.IconosMenus
        Me.BotonExportarAExcel.LabelMensaje = Me.LabelMensaje
        Me.BotonExportarAExcel.Location = New System.Drawing.Point(8, 30)
        Me.BotonExportarAExcel.Name = "BotonExportarAExcel"
        Me.BotonExportarAExcel.Size = New System.Drawing.Size(40, 40)
        Me.BotonExportarAExcel.TabIndex = 34
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
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 401)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(614, 23)
        Me.LabelMensaje.TabIndex = 35
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(68, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 32
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExportarAExcel, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuExportarAExcel
        '
        Me.mnuExportarAExcel.Name = "mnuExportarAExcel"
        Me.mnuExportarAExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuExportarAExcel.Size = New System.Drawing.Size(252, 22)
        Me.mnuExportarAExcel.Text = "Exportar resultados a Excel"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(249, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(252, 22)
        Me.mnuSalir.Text = "@1"
        '
        'TASASG01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 424)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.BotonExportarAExcel)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.grdCG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "TASASG01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de tasas de cambio - TASASG01"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents grdCG As System.Windows.Forms.DataGridView
    Public WithEvents cboTIP_CAMBIO_TASAS_CAM As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtFEC_FINAL As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents txtFEC_INICIAL As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lbltitFEC_FINAL As System.Windows.Forms.Label
    Public WithEvents lbltitFEC_INICIAL As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitTIP_CAMBIO_TASAS_CAM As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents BotonExportarAExcel As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportarAExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
End Class
