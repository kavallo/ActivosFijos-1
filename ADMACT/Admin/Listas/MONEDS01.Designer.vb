<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MONEDS01
    Inherits Citi.Synergia.UIGenerico.FormaSelNav ' System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MONEDS01))
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdAgregar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdModificar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTasasDeCambio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGrafica = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lbltitTIPO_CAMBIO = New System.Windows.Forms.Label()
        Me.varFORMA_CALCULO_CAMBIO = New System.Windows.Forms.Label()
        Me.nameFORMA_CALCULO_CAMBIO = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_MONEDA = New System.Windows.Forms.Label()
        Me.lblCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.BotonTasasDeCambio = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonGrafica = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonReporte = New Citi.Synergia.UIGenerico.BotonMenu()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 323)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(582, 23)
        Me.LabelMensaje.TabIndex = 1
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.ImageKey = "Alta"
        Me.cmdAgregar.ImageList = Me.IconosMenus
        Me.cmdAgregar.LabelMensaje = Me.LabelMensaje
        Me.cmdAgregar.Location = New System.Drawing.Point(8, 30)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(40, 40)
        Me.cmdAgregar.TabIndex = 3
        Me.cmdAgregar.Texto = "Agregar"
        Me.cmdAgregar.UseMnemonic = False
        Me.cmdAgregar.UseVisualStyleBackColor = True
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
        'cmdBorrar
        '
        Me.cmdBorrar.ImageKey = "Baja"
        Me.cmdBorrar.ImageList = Me.IconosMenus
        Me.cmdBorrar.LabelMensaje = Me.LabelMensaje
        Me.cmdBorrar.Location = New System.Drawing.Point(48, 30)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(40, 40)
        Me.cmdBorrar.TabIndex = 4
        Me.cmdBorrar.Texto = "Borrar"
        Me.cmdBorrar.UseMnemonic = False
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.ImageKey = "Cambio"
        Me.cmdModificar.ImageList = Me.IconosMenus
        Me.cmdModificar.LabelMensaje = Me.LabelMensaje
        Me.cmdModificar.Location = New System.Drawing.Point(88, 30)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(40, 40)
        Me.cmdModificar.TabIndex = 5
        Me.cmdModificar.Texto = "Modificar moneda"
        Me.cmdModificar.UseMnemonic = False
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(268, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuBorrar, Me.mnuModificar, Me.mnuTasasDeCambio, Me.mnuGrafica, Me.mnuReporte, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(257, 22)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(257, 22)
        Me.mnuBorrar.Text = "Borrar"
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuModificar.Size = New System.Drawing.Size(257, 22)
        Me.mnuModificar.Text = "Modificar moneda"
        '
        'mnuTasasDeCambio
        '
        Me.mnuTasasDeCambio.Name = "mnuTasasDeCambio"
        Me.mnuTasasDeCambio.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuTasasDeCambio.Size = New System.Drawing.Size(257, 22)
        Me.mnuTasasDeCambio.Text = "Tasas de cambio"
        '
        'mnuGrafica
        '
        Me.mnuGrafica.Name = "mnuGrafica"
        Me.mnuGrafica.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuGrafica.Size = New System.Drawing.Size(257, 22)
        Me.mnuGrafica.Text = "Gráfica de tasas de cambio"
        '
        'mnuReporte
        '
        Me.mnuReporte.Name = "mnuReporte"
        Me.mnuReporte.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuReporte.Size = New System.Drawing.Size(257, 22)
        Me.mnuReporte.Text = "Reporte de monedas"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(254, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(257, 22)
        Me.mnuSalir.Text = "@1"
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lbltitTIPO_CAMBIO)
        Me.Encabezado.Controls.Add(Me.varFORMA_CALCULO_CAMBIO)
        Me.Encabezado.Controls.Add(Me.nameFORMA_CALCULO_CAMBIO)
        Me.Encabezado.Controls.Add(Me.lblDESCRIPCION_MONEDA)
        Me.Encabezado.Controls.Add(Me.lblCODIGO_DE_MONEDA)
        Me.Encabezado.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(562, 43)
        Me.Encabezado.TabIndex = 12
        '
        'lbltitTIPO_CAMBIO
        '
        Me.lbltitTIPO_CAMBIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltitTIPO_CAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitTIPO_CAMBIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitTIPO_CAMBIO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitTIPO_CAMBIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitTIPO_CAMBIO.Location = New System.Drawing.Point(0, 20)
        Me.lbltitTIPO_CAMBIO.Name = "lbltitTIPO_CAMBIO"
        Me.lbltitTIPO_CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitTIPO_CAMBIO.Size = New System.Drawing.Size(121, 20)
        Me.lbltitTIPO_CAMBIO.TabIndex = 26
        Me.lbltitTIPO_CAMBIO.Text = "Tipo de Conversión"
        Me.lbltitTIPO_CAMBIO.UseMnemonic = False
        '
        'varFORMA_CALCULO_CAMBIO
        '
        Me.varFORMA_CALCULO_CAMBIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.varFORMA_CALCULO_CAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.varFORMA_CALCULO_CAMBIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.varFORMA_CALCULO_CAMBIO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varFORMA_CALCULO_CAMBIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.varFORMA_CALCULO_CAMBIO.Location = New System.Drawing.Point(121, 20)
        Me.varFORMA_CALCULO_CAMBIO.Name = "varFORMA_CALCULO_CAMBIO"
        Me.varFORMA_CALCULO_CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.varFORMA_CALCULO_CAMBIO.Size = New System.Drawing.Size(26, 20)
        Me.varFORMA_CALCULO_CAMBIO.TabIndex = 25
        Me.varFORMA_CALCULO_CAMBIO.Text = "M"
        Me.varFORMA_CALCULO_CAMBIO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.varFORMA_CALCULO_CAMBIO.UseMnemonic = False
        '
        'nameFORMA_CALCULO_CAMBIO
        '
        Me.nameFORMA_CALCULO_CAMBIO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameFORMA_CALCULO_CAMBIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nameFORMA_CALCULO_CAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameFORMA_CALCULO_CAMBIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.nameFORMA_CALCULO_CAMBIO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameFORMA_CALCULO_CAMBIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nameFORMA_CALCULO_CAMBIO.Location = New System.Drawing.Point(147, 20)
        Me.nameFORMA_CALCULO_CAMBIO.Name = "nameFORMA_CALCULO_CAMBIO"
        Me.nameFORMA_CALCULO_CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nameFORMA_CALCULO_CAMBIO.Size = New System.Drawing.Size(412, 20)
        Me.nameFORMA_CALCULO_CAMBIO.TabIndex = 24
        Me.nameFORMA_CALCULO_CAMBIO.UseMnemonic = False
        '
        'lblDESCRIPCION_MONEDA
        '
        Me.lblDESCRIPCION_MONEDA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDESCRIPCION_MONEDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDESCRIPCION_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDESCRIPCION_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_MONEDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_MONEDA.Location = New System.Drawing.Point(179, 0)
        Me.lblDESCRIPCION_MONEDA.Name = "lblDESCRIPCION_MONEDA"
        Me.lblDESCRIPCION_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_MONEDA.Size = New System.Drawing.Size(380, 20)
        Me.lblDESCRIPCION_MONEDA.TabIndex = 23
        Me.lblDESCRIPCION_MONEDA.UseMnemonic = False
        '
        'lblCODIGO_DE_MONEDA
        '
        Me.lblCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DE_MONEDA.Location = New System.Drawing.Point(121, 0)
        Me.lblCODIGO_DE_MONEDA.Name = "lblCODIGO_DE_MONEDA"
        Me.lblCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DE_MONEDA.Size = New System.Drawing.Size(58, 20)
        Me.lblCODIGO_DE_MONEDA.TabIndex = 21
        Me.lblCODIGO_DE_MONEDA.Text = "Moneda"
        Me.lblCODIGO_DE_MONEDA.UseMnemonic = False
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(0, 0)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(121, 20)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 20
        Me.lblTitCODIGO_DE_MONEDA.Text = "Moneda Local"
        Me.lblTitCODIGO_DE_MONEDA.UseMnemonic = False
        '
        'BotonTasasDeCambio
        '
        Me.BotonTasasDeCambio.ImageKey = "(none)"
        Me.BotonTasasDeCambio.ImageList = Me.IconosMenus
        Me.BotonTasasDeCambio.LabelMensaje = Me.LabelMensaje
        Me.BotonTasasDeCambio.Location = New System.Drawing.Point(128, 30)
        Me.BotonTasasDeCambio.Name = "BotonTasasDeCambio"
        Me.BotonTasasDeCambio.Size = New System.Drawing.Size(40, 40)
        Me.BotonTasasDeCambio.TabIndex = 17
        Me.BotonTasasDeCambio.Texto = "Tasas de cambio"
        Me.BotonTasasDeCambio.UseMnemonic = False
        Me.BotonTasasDeCambio.UseVisualStyleBackColor = True
        '
        'BotonGrafica
        '
        Me.BotonGrafica.ImageKey = "(none)"
        Me.BotonGrafica.ImageList = Me.IconosMenus
        Me.BotonGrafica.LabelMensaje = Me.LabelMensaje
        Me.BotonGrafica.Location = New System.Drawing.Point(168, 30)
        Me.BotonGrafica.Name = "BotonGrafica"
        Me.BotonGrafica.Size = New System.Drawing.Size(40, 40)
        Me.BotonGrafica.TabIndex = 18
        Me.BotonGrafica.Texto = "Gráfica de tasas de cambio"
        Me.BotonGrafica.UseMnemonic = False
        Me.BotonGrafica.UseVisualStyleBackColor = True
        '
        'BotonReporte
        '
        Me.BotonReporte.ImageKey = "(none)"
        Me.BotonReporte.ImageList = Me.IconosMenus
        Me.BotonReporte.LabelMensaje = Me.LabelMensaje
        Me.BotonReporte.Location = New System.Drawing.Point(208, 30)
        Me.BotonReporte.Name = "BotonReporte"
        Me.BotonReporte.Size = New System.Drawing.Size(40, 40)
        Me.BotonReporte.TabIndex = 19
        Me.BotonReporte.Texto = "Reporte de monedas"
        Me.BotonReporte.UseMnemonic = False
        Me.BotonReporte.UseVisualStyleBackColor = True
        '
        'MONEDS01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdAgregar
        Me.BotonBorrar = Me.cmdBorrar
        Me.BotonCambiar = Me.cmdModificar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(582, 346)
        Me.Controls.Add(Me.BotonReporte)
        Me.Controls.Add(Me.BotonGrafica)
        Me.Controls.Add(Me.BotonTasasDeCambio)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.MenuStrip1)
        Me.LeerPosicion = True
        Me.Name = "MONEDS01"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de monedas - MONEDS01"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.cmdAgregar, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdModificar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.BotonTasasDeCambio, 0)
        Me.Controls.SetChildIndex(Me.BotonGrafica, 0)
        Me.Controls.SetChildIndex(Me.BotonReporte, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdModificar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lbltitTIPO_CAMBIO As System.Windows.Forms.Label
    Public WithEvents varFORMA_CALCULO_CAMBIO As System.Windows.Forms.Label
    Public WithEvents nameFORMA_CALCULO_CAMBIO As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents BotonTasasDeCambio As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents mnuTasasDeCambio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotonGrafica As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents mnuGrafica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotonReporte As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents mnuReporte As System.Windows.Forms.ToolStripMenuItem
    ' System.Windows.Forms.ToolStrip
End Class
