<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFS0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTMAFS0))
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdModificar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdBorrar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAgregar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdMejorar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosConsulta = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdInfoGeneral = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdConsultaPartida = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdTraslado = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdAsociarImagen = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdReporteFicha = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.cmdReporteGeneral = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMejorar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInfoGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaPartida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTraslado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAsociarImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReporteFicha = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReporteGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(460, 30)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 23
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
        Me.IconosMenus.Images.SetKeyName(5, "Salir2")
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 281)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(592, 23)
        Me.LabelMensaje.TabIndex = 24
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(520, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 22
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
        Me.cmdModificar.TabIndex = 21
        Me.cmdModificar.Texto = "Modificar activo fijo"
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
        Me.cmdBorrar.TabIndex = 20
        Me.cmdBorrar.Texto = "Borrar activo fijo"
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
        Me.cmdAgregar.TabIndex = 19
        Me.cmdAgregar.Texto = "Agregar activo fijo"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdMejorar
        '
        Me.cmdMejorar.ImageKey = "Mejorar"
        Me.cmdMejorar.ImageList = Me.IconosConsulta
        Me.cmdMejorar.LabelMensaje = Me.LabelMensaje
        Me.cmdMejorar.Location = New System.Drawing.Point(134, 30)
        Me.cmdMejorar.Name = "cmdMejorar"
        Me.cmdMejorar.Size = New System.Drawing.Size(40, 40)
        Me.cmdMejorar.TabIndex = 25
        Me.cmdMejorar.Texto = "Mejorar activo fijo"
        Me.cmdMejorar.UseVisualStyleBackColor = True
        '
        'IconosConsulta
        '
        Me.IconosConsulta.ImageStream = CType(resources.GetObject("IconosConsulta.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosConsulta.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosConsulta.Images.SetKeyName(0, "Mejorar")
        Me.IconosConsulta.Images.SetKeyName(1, "InfoGeneral")
        Me.IconosConsulta.Images.SetKeyName(2, "Consulta")
        Me.IconosConsulta.Images.SetKeyName(3, "ConsultaPartida")
        Me.IconosConsulta.Images.SetKeyName(4, "Traslados")
        Me.IconosConsulta.Images.SetKeyName(5, "AsociarImagen")
        Me.IconosConsulta.Images.SetKeyName(6, "Reporte1")
        '
        'cmdInfoGeneral
        '
        Me.cmdInfoGeneral.ImageKey = "InfoGeneral"
        Me.cmdInfoGeneral.ImageList = Me.IconosConsulta
        Me.cmdInfoGeneral.LabelMensaje = Me.LabelMensaje
        Me.cmdInfoGeneral.Location = New System.Drawing.Point(174, 30)
        Me.cmdInfoGeneral.Name = "cmdInfoGeneral"
        Me.cmdInfoGeneral.Size = New System.Drawing.Size(40, 40)
        Me.cmdInfoGeneral.TabIndex = 26
        Me.cmdInfoGeneral.Texto = "Información general de activo fijo"
        Me.cmdInfoGeneral.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.ImageKey = "Consulta"
        Me.cmdConsultar.ImageList = Me.IconosConsulta
        Me.cmdConsultar.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultar.Location = New System.Drawing.Point(214, 30)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultar.TabIndex = 27
        Me.cmdConsultar.Texto = "Consulta de activo fijo"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdConsultaPartida
        '
        Me.cmdConsultaPartida.ImageKey = "ConsultaPartida"
        Me.cmdConsultaPartida.ImageList = Me.IconosConsulta
        Me.cmdConsultaPartida.LabelMensaje = Me.LabelMensaje
        Me.cmdConsultaPartida.Location = New System.Drawing.Point(254, 30)
        Me.cmdConsultaPartida.Name = "cmdConsultaPartida"
        Me.cmdConsultaPartida.Size = New System.Drawing.Size(40, 40)
        Me.cmdConsultaPartida.TabIndex = 28
        Me.cmdConsultaPartida.Texto = "Consulta partida por traslado de departamento de activo fijo"
        Me.cmdConsultaPartida.UseVisualStyleBackColor = True
        '
        'cmdTraslado
        '
        Me.cmdTraslado.ImageKey = "Traslados"
        Me.cmdTraslado.ImageList = Me.IconosConsulta
        Me.cmdTraslado.LabelMensaje = Me.LabelMensaje
        Me.cmdTraslado.Location = New System.Drawing.Point(294, 30)
        Me.cmdTraslado.Name = "cmdTraslado"
        Me.cmdTraslado.Size = New System.Drawing.Size(40, 40)
        Me.cmdTraslado.TabIndex = 29
        Me.cmdTraslado.Texto = "Traslados de activos entre departamentos"
        Me.cmdTraslado.UseVisualStyleBackColor = True
        '
        'cmdAsociarImagen
        '
        Me.cmdAsociarImagen.ImageKey = "AsociarImagen"
        Me.cmdAsociarImagen.ImageList = Me.IconosConsulta
        Me.cmdAsociarImagen.LabelMensaje = Me.LabelMensaje
        Me.cmdAsociarImagen.Location = New System.Drawing.Point(334, 30)
        Me.cmdAsociarImagen.Name = "cmdAsociarImagen"
        Me.cmdAsociarImagen.Size = New System.Drawing.Size(40, 40)
        Me.cmdAsociarImagen.TabIndex = 30
        Me.cmdAsociarImagen.Texto = "Asociar imagen"
        Me.cmdAsociarImagen.UseVisualStyleBackColor = True
        '
        'cmdReporteFicha
        '
        Me.cmdReporteFicha.ImageKey = "Reporte1"
        Me.cmdReporteFicha.ImageList = Me.IconosConsulta
        Me.cmdReporteFicha.LabelMensaje = Me.LabelMensaje
        Me.cmdReporteFicha.Location = New System.Drawing.Point(374, 30)
        Me.cmdReporteFicha.Name = "cmdReporteFicha"
        Me.cmdReporteFicha.Size = New System.Drawing.Size(40, 40)
        Me.cmdReporteFicha.TabIndex = 31
        Me.cmdReporteFicha.Texto = "Ficha del responsable"
        Me.cmdReporteFicha.UseVisualStyleBackColor = True
        '
        'cmdReporteGeneral
        '
        Me.cmdReporteGeneral.ImageKey = "Reporte1"
        Me.cmdReporteGeneral.ImageList = Me.IconosConsulta
        Me.cmdReporteGeneral.LabelMensaje = Me.LabelMensaje
        Me.cmdReporteGeneral.Location = New System.Drawing.Point(414, 30)
        Me.cmdReporteGeneral.Name = "cmdReporteGeneral"
        Me.cmdReporteGeneral.Size = New System.Drawing.Size(40, 40)
        Me.cmdReporteGeneral.TabIndex = 32
        Me.cmdReporteGeneral.Texto = "Reporte general de activos fijos"
        Me.cmdReporteGeneral.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuBorrar, Me.mnuModificar, Me.mnuMejorar, Me.mnuInfoGeneral, Me.mnuConsultar, Me.mnuConsultaPartida, Me.mnuTraslado, Me.mnuAsociarImagen, Me.mnuReporteFicha, Me.mnuReporteGeneral, Me.mnuLlenar, Me.mnuSep, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(433, 22)
        Me.mnuAgregar.Text = "Agregar activo fijo"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBorrar.Size = New System.Drawing.Size(433, 22)
        Me.mnuBorrar.Text = "Borrar activo fijo"
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuModificar.Size = New System.Drawing.Size(433, 22)
        Me.mnuModificar.Text = "Modificar activo fijo"
        '
        'mnuMejorar
        '
        Me.mnuMejorar.Name = "mnuMejorar"
        Me.mnuMejorar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuMejorar.Size = New System.Drawing.Size(433, 22)
        Me.mnuMejorar.Text = "Mejorar activo fijo"
        '
        'mnuInfoGeneral
        '
        Me.mnuInfoGeneral.Name = "mnuInfoGeneral"
        Me.mnuInfoGeneral.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuInfoGeneral.Size = New System.Drawing.Size(433, 22)
        Me.mnuInfoGeneral.Text = "Información general de activo fijo"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(433, 22)
        Me.mnuConsultar.Text = "Consulta de activo fijo"
        '
        'mnuConsultaPartida
        '
        Me.mnuConsultaPartida.Name = "mnuConsultaPartida"
        Me.mnuConsultaPartida.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuConsultaPartida.Size = New System.Drawing.Size(433, 22)
        Me.mnuConsultaPartida.Text = "Consulta partida por traslado de departamento de activo fijo"
        '
        'mnuTraslado
        '
        Me.mnuTraslado.Name = "mnuTraslado"
        Me.mnuTraslado.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuTraslado.Size = New System.Drawing.Size(433, 22)
        Me.mnuTraslado.Text = "Traslados de activos entre departamentos"
        '
        'mnuAsociarImagen
        '
        Me.mnuAsociarImagen.Name = "mnuAsociarImagen"
        Me.mnuAsociarImagen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuAsociarImagen.Size = New System.Drawing.Size(202, 22)
        Me.mnuAsociarImagen.Text = "Asociar imagen"
        '
        'mnuReporteFicha
        '
        Me.mnuReporteFicha.Name = "mnuReporteFicha"
        Me.mnuReporteFicha.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuReporteFicha.Size = New System.Drawing.Size(433, 22)
        Me.mnuReporteFicha.Text = "Ficha del responsable"
        '
        'mnuReporteGeneral
        '
        Me.mnuReporteGeneral.Name = "mnuReporteGeneral"
        Me.mnuReporteGeneral.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuReporteGeneral.Size = New System.Drawing.Size(433, 22)
        Me.mnuReporteGeneral.Text = "Reporte general de activos fijos"
        '
        'mnuLlenar
        '
        Me.mnuLlenar.Name = "mnuLlenar"
        Me.mnuLlenar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLlenar.Size = New System.Drawing.Size(433, 22)
        Me.mnuLlenar.Text = "@5"
        '
        'mnuSep
        '
        Me.mnuSep.Name = "mnuSep"
        Me.mnuSep.Size = New System.Drawing.Size(199, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(433, 22)
        Me.mnuSalir.Text = "@1"
        '
        'ACTMAFS0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.cmdAgregar
        Me.BotonBorrar = Me.cmdBorrar
        Me.BotonCambiar = Me.cmdModificar
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(592, 304)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdReporteGeneral)
        Me.Controls.Add(Me.cmdReporteFicha)
        Me.Controls.Add(Me.cmdAsociarImagen)
        Me.Controls.Add(Me.cmdTraslado)
        Me.Controls.Add(Me.cmdConsultaPartida)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.cmdInfoGeneral)
        Me.Controls.Add(Me.cmdMejorar)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "ACTMAFS0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de activos fijos - ACTMAFS0"
        Me.Controls.SetChildIndex(Me.cmdAgregar, 0)
        Me.Controls.SetChildIndex(Me.cmdBorrar, 0)
        Me.Controls.SetChildIndex(Me.cmdModificar, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.cmdMejorar, 0)
        Me.Controls.SetChildIndex(Me.cmdInfoGeneral, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultar, 0)
        Me.Controls.SetChildIndex(Me.cmdConsultaPartida, 0)
        Me.Controls.SetChildIndex(Me.cmdTraslado, 0)
        Me.Controls.SetChildIndex(Me.cmdAsociarImagen, 0)
        Me.Controls.SetChildIndex(Me.cmdReporteFicha, 0)
        Me.Controls.SetChildIndex(Me.cmdReporteGeneral, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdModificar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdBorrar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAgregar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdMejorar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosConsulta As System.Windows.Forms.ImageList
    Friend WithEvents cmdInfoGeneral As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdConsultar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdConsultaPartida As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdTraslado As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdAsociarImagen As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdReporteFicha As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents cmdReporteGeneral As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReporteGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReporteFicha As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMejorar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInfoGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaPartida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTraslado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAsociarImagen As System.Windows.Forms.ToolStripMenuItem
End Class
