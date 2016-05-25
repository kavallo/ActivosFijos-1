<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFS4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMAFS4))
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.BotonConsulta = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblTipoActivo = New System.Windows.Forms.Label()
        Me.lblCodigoTipoActivo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblDescripcionDivision = New System.Windows.Forms.Label()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
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
        'BotonConsulta
        '
        Me.BotonConsulta.ImageKey = "(none)"
        Me.BotonConsulta.ImageList = Me.IconosMenus
        Me.BotonConsulta.LabelMensaje = Me.LabelMensaje
        Me.BotonConsulta.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsulta.Name = "BotonConsulta"
        Me.BotonConsulta.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsulta.TabIndex = 5
        Me.BotonConsulta.Texto = "Consulta de activos fijos"
        Me.BotonConsulta.UseMnemonic = False
        Me.BotonConsulta.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(108, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblTipoActivo)
        Me.Encabezado.Controls.Add(Me.lblCodigoTipoActivo)
        Me.Encabezado.Controls.Add(Me.lblDescripcion)
        Me.Encabezado.Controls.Add(Me.lblDescripcionDivision)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(562, 43)
        Me.Encabezado.TabIndex = 11
        '
        'lblTipoActivo
        '
        Me.lblTipoActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTipoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoActivo.Location = New System.Drawing.Point(0, 0)
        Me.lblTipoActivo.Name = "lblTipoActivo"
        Me.lblTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoActivo.Size = New System.Drawing.Size(96, 20)
        Me.lblTipoActivo.TabIndex = 15
        Me.lblTipoActivo.Text = "Tipo de activo"
        Me.lblTipoActivo.UseMnemonic = False
        '
        'lblCodigoTipoActivo
        '
        Me.lblCodigoTipoActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigoTipoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoTipoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoTipoActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoTipoActivo.Location = New System.Drawing.Point(96, 0)
        Me.lblCodigoTipoActivo.Name = "lblCodigoTipoActivo"
        Me.lblCodigoTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoTipoActivo.Size = New System.Drawing.Size(87, 20)
        Me.lblCodigoTipoActivo.TabIndex = 16
        Me.lblCodigoTipoActivo.Text = "TIPO"
        Me.lblCodigoTipoActivo.UseMnemonic = False
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
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 17
        Me.lblDescripcion.Text = "Descripcion"
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
        Me.lblDescripcionDivision.Location = New System.Drawing.Point(96, 20)
        Me.lblDescripcionDivision.Name = "lblDescripcionDivision"
        Me.lblDescripcionDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcionDivision.Size = New System.Drawing.Size(463, 20)
        Me.lblDescripcionDivision.TabIndex = 18
        Me.lblDescripcionDivision.Text = "DESCRIPCION DE ACTIVO FIJO"
        Me.lblDescripcionDivision.UseMnemonic = False
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(48, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 17
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseMnemonic = False
        Me.BotonLlenar.UseVisualStyleBackColor = True
        '
        'ACTMAFS4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsulta
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(582, 346)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.BotonConsulta)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.MenuStrip1)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMAFS4"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de activos fijos - ACTMAFS4"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.BotonConsulta, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents BotonConsulta As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblTipoActivo As System.Windows.Forms.Label
    Public WithEvents lblCodigoTipoActivo As System.Windows.Forms.Label
    Public WithEvents lblDescripcion As System.Windows.Forms.Label
    Public WithEvents lblDescripcionDivision As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    ' System.Windows.Forms.ToolStrip
End Class
