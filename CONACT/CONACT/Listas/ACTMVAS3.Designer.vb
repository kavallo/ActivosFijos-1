<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAS3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMVAS3))
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonConsultar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPartidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.BotonConsultaPartidas = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblCodigoMejora = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblCodigoActivo = New System.Windows.Forms.Label()
        Me.lblMejora = New System.Windows.Forms.Label()
        Me.lblNombreActivo = New System.Windows.Forms.Label()
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
        Me.BotonLlenar.Location = New System.Drawing.Point(88, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 25
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
        Me.LabelMensaje.TabIndex = 19
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(148, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 21
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'BotonConsultar
        '
        Me.BotonConsultar.ImageKey = "Cambio"
        Me.BotonConsultar.ImageList = Me.IconosMenus
        Me.BotonConsultar.LabelMensaje = Me.LabelMensaje
        Me.BotonConsultar.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsultar.Name = "BotonConsultar"
        Me.BotonConsultar.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsultar.TabIndex = 20
        Me.BotonConsultar.Texto = "Consulta movimientos"
        Me.BotonConsultar.UseMnemonic = False
        Me.BotonConsultar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultar, Me.mnuPartidas, Me.mnuLlenar, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(237, 22)
        Me.mnuConsultar.Text = "Consulta movimientos"
        '
        'mnuPartidas
        '
        Me.mnuPartidas.Name = "mnuPartidas"
        Me.mnuPartidas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuPartidas.Size = New System.Drawing.Size(237, 22)
        Me.mnuPartidas.Text = "Consulta partidas"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(237, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(234, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(237, 22)
        Me.mnuSalir.Text = "@1"
        '
        'BotonConsultaPartidas
        '
        Me.BotonConsultaPartidas.ImageKey = "(none)"
        Me.BotonConsultaPartidas.ImageList = Me.IconosMenus
        Me.BotonConsultaPartidas.LabelMensaje = Me.LabelMensaje
        Me.BotonConsultaPartidas.Location = New System.Drawing.Point(48, 30)
        Me.BotonConsultaPartidas.Name = "BotonConsultaPartidas"
        Me.BotonConsultaPartidas.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsultaPartidas.TabIndex = 28
        Me.BotonConsultaPartidas.Texto = "Consulta partidas"
        Me.BotonConsultaPartidas.UseMnemonic = False
        Me.BotonConsultaPartidas.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblCodigoMejora)
        Me.Encabezado.Controls.Add(Me.lblCodigo)
        Me.Encabezado.Controls.Add(Me.lblCodigoActivo)
        Me.Encabezado.Controls.Add(Me.lblMejora)
        Me.Encabezado.Controls.Add(Me.lblNombreActivo)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(562, 43)
        Me.Encabezado.TabIndex = 29
        '
        'lblCodigoMejora
        '
        Me.lblCodigoMejora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigoMejora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoMejora.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoMejora.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoMejora.Location = New System.Drawing.Point(96, 20)
        Me.lblCodigoMejora.Name = "lblCodigoMejora"
        Me.lblCodigoMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoMejora.Size = New System.Drawing.Size(87, 20)
        Me.lblCodigoMejora.TabIndex = 19
        Me.lblCodigoMejora.Text = "TIPO"
        Me.lblCodigoMejora.UseMnemonic = False
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigo.Location = New System.Drawing.Point(0, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigo.Size = New System.Drawing.Size(96, 20)
        Me.lblCodigo.TabIndex = 15
        Me.lblCodigo.Text = "Código activo"
        Me.lblCodigo.UseMnemonic = False
        '
        'lblCodigoActivo
        '
        Me.lblCodigoActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoActivo.Location = New System.Drawing.Point(96, 0)
        Me.lblCodigoActivo.Name = "lblCodigoActivo"
        Me.lblCodigoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoActivo.Size = New System.Drawing.Size(87, 20)
        Me.lblCodigoActivo.TabIndex = 16
        Me.lblCodigoActivo.Text = "Código activo"
        Me.lblCodigoActivo.UseMnemonic = False
        '
        'lblMejora
        '
        Me.lblMejora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMejora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMejora.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMejora.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMejora.Location = New System.Drawing.Point(0, 20)
        Me.lblMejora.Name = "lblMejora"
        Me.lblMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMejora.Size = New System.Drawing.Size(96, 20)
        Me.lblMejora.TabIndex = 17
        Me.lblMejora.Text = "Mejora"
        Me.lblMejora.UseMnemonic = False
        '
        'lblNombreActivo
        '
        Me.lblNombreActivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreActivo.Location = New System.Drawing.Point(183, 20)
        Me.lblNombreActivo.Name = "lblNombreActivo"
        Me.lblNombreActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreActivo.Size = New System.Drawing.Size(376, 20)
        Me.lblNombreActivo.TabIndex = 18
        Me.lblNombreActivo.Text = "DESCRIPCION DE ACTIVO FIJO"
        Me.lblNombreActivo.UseMnemonic = False
        '
        'ACTMVAS3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsultar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(582, 346)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonConsultaPartidas)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.BotonConsultar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMVAS3"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de movimientos de activos fijos - ACTMVAS3"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonConsultar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.BotonConsultaPartidas, 0)
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
    Friend WithEvents BotonConsultar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotonConsultaPartidas As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblCodigo As System.Windows.Forms.Label
    Public WithEvents lblCodigoActivo As System.Windows.Forms.Label
    Public WithEvents lblMejora As System.Windows.Forms.Label
    Public WithEvents lblNombreActivo As System.Windows.Forms.Label
    Public WithEvents lblCodigoMejora As System.Windows.Forms.Label
    Friend WithEvents mnuPartidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
End Class
