<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEDS1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTSEDS1))
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblNombreCobertura = New System.Windows.Forms.Label()
        Me.lblNombrePoliza = New System.Windows.Forms.Label()
        Me.lblPoliza = New System.Windows.Forms.Label()
        Me.lblNumeroPoliza = New System.Windows.Forms.Label()
        Me.lblEndoso = New System.Windows.Forms.Label()
        Me.lblNumeroEndoso = New System.Windows.Forms.Label()
        Me.lblCobertura = New System.Windows.Forms.Label()
        Me.lblCodigoCobertura = New System.Windows.Forms.Label()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
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
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(108, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 56
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
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
        Me.LabelMensaje.TabIndex = 51
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblNombreCobertura)
        Me.Encabezado.Controls.Add(Me.lblNombrePoliza)
        Me.Encabezado.Controls.Add(Me.lblPoliza)
        Me.Encabezado.Controls.Add(Me.lblNumeroPoliza)
        Me.Encabezado.Controls.Add(Me.lblEndoso)
        Me.Encabezado.Controls.Add(Me.lblNumeroEndoso)
        Me.Encabezado.Controls.Add(Me.lblCobertura)
        Me.Encabezado.Controls.Add(Me.lblCodigoCobertura)
        Me.Encabezado.Location = New System.Drawing.Point(8, 76)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(542, 63)
        Me.Encabezado.TabIndex = 55
        '
        'lblNombreCobertura
        '
        Me.lblNombreCobertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombreCobertura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCobertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCobertura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCobertura.Location = New System.Drawing.Point(241, 40)
        Me.lblNombreCobertura.Name = "lblNombreCobertura"
        Me.lblNombreCobertura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCobertura.Size = New System.Drawing.Size(301, 20)
        Me.lblNombreCobertura.TabIndex = 23
        Me.lblNombreCobertura.UseMnemonic = False
        '
        'lblNombrePoliza
        '
        Me.lblNombrePoliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombrePoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombrePoliza.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombrePoliza.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePoliza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombrePoliza.Location = New System.Drawing.Point(241, 20)
        Me.lblNombrePoliza.Name = "lblNombrePoliza"
        Me.lblNombrePoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombrePoliza.Size = New System.Drawing.Size(301, 20)
        Me.lblNombrePoliza.TabIndex = 22
        Me.lblNombrePoliza.UseMnemonic = False
        '
        'lblPoliza
        '
        Me.lblPoliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoliza.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPoliza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoliza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPoliza.Location = New System.Drawing.Point(0, 0)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPoliza.Size = New System.Drawing.Size(73, 20)
        Me.lblPoliza.TabIndex = 16
        Me.lblPoliza.Text = "Poliza"
        Me.lblPoliza.UseMnemonic = False
        '
        'lblNumeroPoliza
        '
        Me.lblNumeroPoliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumeroPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroPoliza.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumeroPoliza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPoliza.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNumeroPoliza.Location = New System.Drawing.Point(73, 0)
        Me.lblNumeroPoliza.Name = "lblNumeroPoliza"
        Me.lblNumeroPoliza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumeroPoliza.Size = New System.Drawing.Size(469, 20)
        Me.lblNumeroPoliza.TabIndex = 17
        Me.lblNumeroPoliza.Text = "Numero De Poliza"
        Me.lblNumeroPoliza.UseMnemonic = False
        '
        'lblEndoso
        '
        Me.lblEndoso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEndoso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndoso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEndoso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndoso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEndoso.Location = New System.Drawing.Point(0, 20)
        Me.lblEndoso.Name = "lblEndoso"
        Me.lblEndoso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEndoso.Size = New System.Drawing.Size(73, 20)
        Me.lblEndoso.TabIndex = 18
        Me.lblEndoso.Text = "Endoso"
        Me.lblEndoso.UseMnemonic = False
        '
        'lblNumeroEndoso
        '
        Me.lblNumeroEndoso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumeroEndoso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroEndoso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumeroEndoso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroEndoso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNumeroEndoso.Location = New System.Drawing.Point(73, 20)
        Me.lblNumeroEndoso.Name = "lblNumeroEndoso"
        Me.lblNumeroEndoso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumeroEndoso.Size = New System.Drawing.Size(168, 20)
        Me.lblNumeroEndoso.TabIndex = 19
        Me.lblNumeroEndoso.Text = "Numero De Endoso"
        Me.lblNumeroEndoso.UseMnemonic = False
        '
        'lblCobertura
        '
        Me.lblCobertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCobertura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCobertura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCobertura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCobertura.Location = New System.Drawing.Point(0, 40)
        Me.lblCobertura.Name = "lblCobertura"
        Me.lblCobertura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCobertura.Size = New System.Drawing.Size(73, 20)
        Me.lblCobertura.TabIndex = 20
        Me.lblCobertura.Text = "Cobertura"
        Me.lblCobertura.UseMnemonic = False
        '
        'lblCodigoCobertura
        '
        Me.lblCodigoCobertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigoCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoCobertura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoCobertura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCobertura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoCobertura.Location = New System.Drawing.Point(73, 40)
        Me.lblCodigoCobertura.Name = "lblCodigoCobertura"
        Me.lblCodigoCobertura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoCobertura.Size = New System.Drawing.Size(168, 20)
        Me.lblCodigoCobertura.TabIndex = 21
        Me.lblCodigoCobertura.Text = "Codigo Cobertura"
        Me.lblCodigoCobertura.UseMnemonic = False
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(48, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 54
        Me.BotonLlenar.Texto = "@5"
        Me.BotonLlenar.UseMnemonic = False
        Me.BotonLlenar.UseVisualStyleBackColor = True
        '
        'BotonConsulta
        '
        Me.BotonConsulta.ImageKey = "Cambio"
        Me.BotonConsulta.ImageList = Me.IconosMenus
        Me.BotonConsulta.LabelMensaje = Me.LabelMensaje
        Me.BotonConsulta.Location = New System.Drawing.Point(8, 30)
        Me.BotonConsulta.Name = "BotonConsulta"
        Me.BotonConsulta.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsulta.TabIndex = 52
        Me.BotonConsulta.Texto = "Consultar"
        Me.BotonConsulta.UseMnemonic = False
        Me.BotonConsulta.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 53
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
        Me.mnuConsultar.Size = New System.Drawing.Size(168, 22)
        Me.mnuConsultar.Text = "Consultar"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(168, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(165, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(168, 22)
        Me.mnuSalir.Text = "@1"
        '
        'ACTSEDS1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsulta
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.BotonConsulta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTSEDS1"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activos asegurados por la póliza - ACTSEDS1"
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonConsulta, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonConsulta As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents lblNombreCobertura As System.Windows.Forms.Label
    Public WithEvents lblNombrePoliza As System.Windows.Forms.Label
    Public WithEvents lblPoliza As System.Windows.Forms.Label
    Public WithEvents lblNumeroPoliza As System.Windows.Forms.Label
    Public WithEvents lblEndoso As System.Windows.Forms.Label
    Public WithEvents lblNumeroEndoso As System.Windows.Forms.Label
    Public WithEvents lblCobertura As System.Windows.Forms.Label
    Public WithEvents lblCodigoCobertura As System.Windows.Forms.Label
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
End Class
