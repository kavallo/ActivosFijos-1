<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits Citi.Synergia.UIGenerico.Forma  'System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.LabelEmpresa = New System.Windows.Forms.Label()
        Me.MENU_Renamed = New System.Windows.Forms.GroupBox()
        Me.MenuExportAllFields = New System.Windows.Forms.Button()
        Me.lblExportAllFields = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuAddDispFull = New System.Windows.Forms.Button()
        Me.lblAltaDesecho = New System.Windows.Forms.Label()
        Me.lblAddDispFull = New System.Windows.Forms.Label()
        Me.cm3Salir = New System.Windows.Forms.Button()
        Me.MenuDepreciados = New System.Windows.Forms.Button()
        Me.MenuTipoActivos = New System.Windows.Forms.Button()
        Me.MenuTotalmenteDepreciados = New System.Windows.Forms.Button()
        Me.MenuProyeccion = New System.Windows.Forms.Button()
        Me.MenuTomaFisica = New System.Windows.Forms.Button()
        Me.MenuDepreciaciones = New System.Windows.Forms.Button()
        Me.MenuMovimientos = New System.Windows.Forms.Button()
        Me.MenuInformacionGeneral = New System.Windows.Forms.Button()
        Me.MenuReporteGeneral = New System.Windows.Forms.Button()
        Me.MenuCatalogo = New System.Windows.Forms.Button()
        Me.lblMovimientos = New System.Windows.Forms.Label()
        Me.lblCatalogoActivos = New System.Windows.Forms.Label()
        Me.lblDepreciaciones = New System.Windows.Forms.Label()
        Me.lblInformacionGeneral = New System.Windows.Forms.Label()
        Me.lblTomaFisica = New System.Windows.Forms.Label()
        Me.lblReporteGeneral = New System.Windows.Forms.Label()
        Me.lblProyeccion = New System.Windows.Forms.Label()
        Me.lblTotalmente = New System.Windows.Forms.Label()
        Me.lblPorTipo = New System.Windows.Forms.Label()
        Me.lblDepreciados = New System.Windows.Forms.Label()
        Me.lblACTMVAN4 = New System.Windows.Forms.Label()
        Me.lblACTMAFN3 = New System.Windows.Forms.Label()
        Me.lblACTMVAN3 = New System.Windows.Forms.Label()
        Me.lblACTMAFN2 = New System.Windows.Forms.Label()
        Me.lblACTMAFN5 = New System.Windows.Forms.Label()
        Me.lblACTMAFN6 = New System.Windows.Forms.Label()
        Me.lblACTMVAN5 = New System.Windows.Forms.Label()
        Me.lblACTMVAN6 = New System.Windows.Forms.Label()
        Me.lblACTMVAN7 = New System.Windows.Forms.Label()
        Me.lblACTMVAN8 = New System.Windows.Forms.Label()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MENU_Renamed.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelEmpresa
        '
        Me.LabelEmpresa.AutoEllipsis = True
        Me.LabelEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelEmpresa.Location = New System.Drawing.Point(12, 9)
        Me.LabelEmpresa.Name = "LabelEmpresa"
        Me.LabelEmpresa.Size = New System.Drawing.Size(578, 23)
        Me.LabelEmpresa.TabIndex = 39
        Me.LabelEmpresa.UseMnemonic = False
        '
        'MENU_Renamed
        '
        Me.MENU_Renamed.Controls.Add(Me.MenuExportAllFields)
        Me.MENU_Renamed.Controls.Add(Me.lblExportAllFields)
        Me.MENU_Renamed.Controls.Add(Me.Label2)
        Me.MENU_Renamed.Controls.Add(Me.MenuAddDispFull)
        Me.MENU_Renamed.Controls.Add(Me.lblAltaDesecho)
        Me.MENU_Renamed.Controls.Add(Me.lblAddDispFull)
        Me.MENU_Renamed.Controls.Add(Me.cm3Salir)
        Me.MENU_Renamed.Controls.Add(Me.MenuDepreciados)
        Me.MENU_Renamed.Controls.Add(Me.MenuTipoActivos)
        Me.MENU_Renamed.Controls.Add(Me.MenuTotalmenteDepreciados)
        Me.MENU_Renamed.Controls.Add(Me.MenuProyeccion)
        Me.MENU_Renamed.Controls.Add(Me.MenuTomaFisica)
        Me.MENU_Renamed.Controls.Add(Me.MenuDepreciaciones)
        Me.MENU_Renamed.Controls.Add(Me.MenuMovimientos)
        Me.MENU_Renamed.Controls.Add(Me.MenuInformacionGeneral)
        Me.MENU_Renamed.Controls.Add(Me.MenuReporteGeneral)
        Me.MENU_Renamed.Controls.Add(Me.MenuCatalogo)
        Me.MENU_Renamed.Controls.Add(Me.lblMovimientos)
        Me.MENU_Renamed.Controls.Add(Me.lblCatalogoActivos)
        Me.MENU_Renamed.Controls.Add(Me.lblDepreciaciones)
        Me.MENU_Renamed.Controls.Add(Me.lblInformacionGeneral)
        Me.MENU_Renamed.Controls.Add(Me.lblTomaFisica)
        Me.MENU_Renamed.Controls.Add(Me.lblReporteGeneral)
        Me.MENU_Renamed.Controls.Add(Me.lblProyeccion)
        Me.MENU_Renamed.Controls.Add(Me.lblTotalmente)
        Me.MENU_Renamed.Controls.Add(Me.lblPorTipo)
        Me.MENU_Renamed.Controls.Add(Me.lblDepreciados)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMVAN4)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMAFN3)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMVAN3)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMAFN2)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMAFN5)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMAFN6)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMVAN5)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMVAN6)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMVAN7)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMVAN8)
        Me.MENU_Renamed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENU_Renamed.Location = New System.Drawing.Point(12, 35)
        Me.MENU_Renamed.Name = "MENU_Renamed"
        Me.MENU_Renamed.Size = New System.Drawing.Size(578, 378)
        Me.MENU_Renamed.TabIndex = 1
        Me.MENU_Renamed.TabStop = False
        '
        'MenuExportAllFields
        '
        Me.MenuExportAllFields.BackColor = System.Drawing.SystemColors.Control
        Me.MenuExportAllFields.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuExportAllFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuExportAllFields.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuExportAllFields.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuExportAllFields.Location = New System.Drawing.Point(118, 290)
        Me.MenuExportAllFields.Name = "MenuExportAllFields"
        Me.MenuExportAllFields.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuExportAllFields.Size = New System.Drawing.Size(17, 17)
        Me.MenuExportAllFields.TabIndex = 12
        Me.MenuExportAllFields.Tag = "0412000"
        Me.MenuExportAllFields.UseVisualStyleBackColor = False
        '
        'lblExportAllFields
        '
        Me.lblExportAllFields.BackColor = System.Drawing.Color.Transparent
        Me.lblExportAllFields.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblExportAllFields.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportAllFields.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblExportAllFields.Location = New System.Drawing.Point(141, 291)
        Me.lblExportAllFields.Name = "lblExportAllFields"
        Me.lblExportAllFields.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExportAllFields.Size = New System.Drawing.Size(213, 17)
        Me.lblExportAllFields.TabIndex = 60
        Me.lblExportAllFields.Text = "Exporta todos los campos"
        Me.lblExportAllFields.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(360, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "AddDispFull"
        Me.Label2.UseMnemonic = False
        '
        'MenuAddDispFull
        '
        Me.MenuAddDispFull.BackColor = System.Drawing.SystemColors.Control
        Me.MenuAddDispFull.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuAddDispFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuAddDispFull.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuAddDispFull.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuAddDispFull.Location = New System.Drawing.Point(118, 267)
        Me.MenuAddDispFull.Name = "MenuAddDispFull"
        Me.MenuAddDispFull.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuAddDispFull.Size = New System.Drawing.Size(17, 17)
        Me.MenuAddDispFull.TabIndex = 11
        Me.MenuAddDispFull.Tag = "0411000"
        Me.MenuAddDispFull.UseVisualStyleBackColor = False
        '
        'lblAltaDesecho
        '
        Me.lblAltaDesecho.BackColor = System.Drawing.Color.Transparent
        Me.lblAltaDesecho.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblAltaDesecho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAltaDesecho.Location = New System.Drawing.Point(141, 268)
        Me.lblAltaDesecho.Name = "lblAltaDesecho"
        Me.lblAltaDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAltaDesecho.Size = New System.Drawing.Size(213, 17)
        Me.lblAltaDesecho.TabIndex = 57
        Me.lblAltaDesecho.Text = "Alta / Desecho del activo"
        Me.lblAltaDesecho.UseMnemonic = False
        '
        'lblAddDispFull
        '
        Me.lblAddDispFull.BackColor = System.Drawing.Color.Transparent
        Me.lblAddDispFull.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblAddDispFull.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDispFull.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAddDispFull.Location = New System.Drawing.Point(360, 268)
        Me.lblAddDispFull.Name = "lblAddDispFull"
        Me.lblAddDispFull.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddDispFull.Size = New System.Drawing.Size(101, 17)
        Me.lblAddDispFull.TabIndex = 56
        Me.lblAddDispFull.Text = "AddDispFull"
        Me.lblAddDispFull.UseMnemonic = False
        '
        'cm3Salir
        '
        Me.cm3Salir.BackColor = System.Drawing.SystemColors.Control
        Me.cm3Salir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cm3Salir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cm3Salir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cm3Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cm3Salir.Location = New System.Drawing.Point(511, 313)
        Me.cm3Salir.Name = "cm3Salir"
        Me.cm3Salir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cm3Salir.Size = New System.Drawing.Size(61, 59)
        Me.cm3Salir.TabIndex = 13
        Me.cm3Salir.Text = "@1"
        Me.cm3Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cm3Salir.UseMnemonic = False
        Me.cm3Salir.UseVisualStyleBackColor = False
        '
        'MenuDepreciados
        '
        Me.MenuDepreciados.BackColor = System.Drawing.SystemColors.Control
        Me.MenuDepreciados.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuDepreciados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuDepreciados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDepreciados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuDepreciados.Location = New System.Drawing.Point(118, 244)
        Me.MenuDepreciados.Name = "MenuDepreciados"
        Me.MenuDepreciados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuDepreciados.Size = New System.Drawing.Size(17, 17)
        Me.MenuDepreciados.TabIndex = 10
        Me.MenuDepreciados.Tag = "0410000"
        Me.MenuDepreciados.UseVisualStyleBackColor = False
        '
        'MenuTipoActivos
        '
        Me.MenuTipoActivos.BackColor = System.Drawing.SystemColors.Control
        Me.MenuTipoActivos.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuTipoActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuTipoActivos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTipoActivos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuTipoActivos.Location = New System.Drawing.Point(118, 221)
        Me.MenuTipoActivos.Name = "MenuTipoActivos"
        Me.MenuTipoActivos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuTipoActivos.Size = New System.Drawing.Size(17, 17)
        Me.MenuTipoActivos.TabIndex = 9
        Me.MenuTipoActivos.Tag = "0409000"
        Me.MenuTipoActivos.UseVisualStyleBackColor = False
        '
        'MenuTotalmenteDepreciados
        '
        Me.MenuTotalmenteDepreciados.BackColor = System.Drawing.SystemColors.Control
        Me.MenuTotalmenteDepreciados.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuTotalmenteDepreciados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuTotalmenteDepreciados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTotalmenteDepreciados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuTotalmenteDepreciados.Location = New System.Drawing.Point(118, 198)
        Me.MenuTotalmenteDepreciados.Name = "MenuTotalmenteDepreciados"
        Me.MenuTotalmenteDepreciados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuTotalmenteDepreciados.Size = New System.Drawing.Size(17, 17)
        Me.MenuTotalmenteDepreciados.TabIndex = 8
        Me.MenuTotalmenteDepreciados.Tag = "0408000"
        Me.MenuTotalmenteDepreciados.UseVisualStyleBackColor = False
        '
        'MenuProyeccion
        '
        Me.MenuProyeccion.BackColor = System.Drawing.SystemColors.Control
        Me.MenuProyeccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuProyeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuProyeccion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuProyeccion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuProyeccion.Location = New System.Drawing.Point(118, 175)
        Me.MenuProyeccion.Name = "MenuProyeccion"
        Me.MenuProyeccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuProyeccion.Size = New System.Drawing.Size(17, 17)
        Me.MenuProyeccion.TabIndex = 7
        Me.MenuProyeccion.Tag = "0407000"
        Me.MenuProyeccion.UseVisualStyleBackColor = False
        '
        'MenuTomaFisica
        '
        Me.MenuTomaFisica.BackColor = System.Drawing.SystemColors.Control
        Me.MenuTomaFisica.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuTomaFisica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuTomaFisica.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTomaFisica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuTomaFisica.Location = New System.Drawing.Point(118, 152)
        Me.MenuTomaFisica.Name = "MenuTomaFisica"
        Me.MenuTomaFisica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuTomaFisica.Size = New System.Drawing.Size(17, 17)
        Me.MenuTomaFisica.TabIndex = 6
        Me.MenuTomaFisica.Tag = "0406000"
        Me.MenuTomaFisica.UseVisualStyleBackColor = False
        '
        'MenuDepreciaciones
        '
        Me.MenuDepreciaciones.BackColor = System.Drawing.SystemColors.Control
        Me.MenuDepreciaciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuDepreciaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuDepreciaciones.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDepreciaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuDepreciaciones.Location = New System.Drawing.Point(118, 129)
        Me.MenuDepreciaciones.Name = "MenuDepreciaciones"
        Me.MenuDepreciaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuDepreciaciones.Size = New System.Drawing.Size(17, 17)
        Me.MenuDepreciaciones.TabIndex = 5
        Me.MenuDepreciaciones.Tag = "0405000"
        Me.MenuDepreciaciones.UseVisualStyleBackColor = False
        '
        'MenuMovimientos
        '
        Me.MenuMovimientos.BackColor = System.Drawing.SystemColors.Control
        Me.MenuMovimientos.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuMovimientos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMovimientos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuMovimientos.Location = New System.Drawing.Point(118, 106)
        Me.MenuMovimientos.Name = "MenuMovimientos"
        Me.MenuMovimientos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuMovimientos.Size = New System.Drawing.Size(17, 17)
        Me.MenuMovimientos.TabIndex = 4
        Me.MenuMovimientos.Tag = "0404000"
        Me.MenuMovimientos.UseVisualStyleBackColor = False
        '
        'MenuInformacionGeneral
        '
        Me.MenuInformacionGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.MenuInformacionGeneral.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuInformacionGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuInformacionGeneral.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuInformacionGeneral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuInformacionGeneral.Location = New System.Drawing.Point(118, 83)
        Me.MenuInformacionGeneral.Name = "MenuInformacionGeneral"
        Me.MenuInformacionGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuInformacionGeneral.Size = New System.Drawing.Size(17, 17)
        Me.MenuInformacionGeneral.TabIndex = 3
        Me.MenuInformacionGeneral.Tag = "0403000"
        Me.MenuInformacionGeneral.UseVisualStyleBackColor = False
        '
        'MenuReporteGeneral
        '
        Me.MenuReporteGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.MenuReporteGeneral.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuReporteGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuReporteGeneral.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuReporteGeneral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuReporteGeneral.Location = New System.Drawing.Point(118, 60)
        Me.MenuReporteGeneral.Name = "MenuReporteGeneral"
        Me.MenuReporteGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuReporteGeneral.Size = New System.Drawing.Size(17, 17)
        Me.MenuReporteGeneral.TabIndex = 2
        Me.MenuReporteGeneral.Tag = "0402000"
        Me.MenuReporteGeneral.UseVisualStyleBackColor = False
        '
        'MenuCatalogo
        '
        Me.MenuCatalogo.BackColor = System.Drawing.SystemColors.Control
        Me.MenuCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuCatalogo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCatalogo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuCatalogo.Location = New System.Drawing.Point(118, 37)
        Me.MenuCatalogo.Name = "MenuCatalogo"
        Me.MenuCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuCatalogo.Size = New System.Drawing.Size(17, 17)
        Me.MenuCatalogo.TabIndex = 1
        Me.MenuCatalogo.Tag = "0401000"
        Me.MenuCatalogo.UseVisualStyleBackColor = False
        '
        'lblMovimientos
        '
        Me.lblMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.lblMovimientos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblMovimientos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovimientos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMovimientos.Location = New System.Drawing.Point(141, 107)
        Me.lblMovimientos.Name = "lblMovimientos"
        Me.lblMovimientos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMovimientos.Size = New System.Drawing.Size(213, 17)
        Me.lblMovimientos.TabIndex = 54
        Me.lblMovimientos.Text = "Movimientos"
        Me.lblMovimientos.UseMnemonic = False
        '
        'lblCatalogoActivos
        '
        Me.lblCatalogoActivos.BackColor = System.Drawing.Color.Transparent
        Me.lblCatalogoActivos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblCatalogoActivos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalogoActivos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCatalogoActivos.Location = New System.Drawing.Point(141, 38)
        Me.lblCatalogoActivos.Name = "lblCatalogoActivos"
        Me.lblCatalogoActivos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCatalogoActivos.Size = New System.Drawing.Size(213, 17)
        Me.lblCatalogoActivos.TabIndex = 53
        Me.lblCatalogoActivos.Text = "Catálogo de activos"
        Me.lblCatalogoActivos.UseMnemonic = False
        '
        'lblDepreciaciones
        '
        Me.lblDepreciaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblDepreciaciones.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblDepreciaciones.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciaciones.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDepreciaciones.Location = New System.Drawing.Point(141, 130)
        Me.lblDepreciaciones.Name = "lblDepreciaciones"
        Me.lblDepreciaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDepreciaciones.Size = New System.Drawing.Size(213, 17)
        Me.lblDepreciaciones.TabIndex = 52
        Me.lblDepreciaciones.Text = "Depreciaciones"
        Me.lblDepreciaciones.UseMnemonic = False
        '
        'lblInformacionGeneral
        '
        Me.lblInformacionGeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblInformacionGeneral.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblInformacionGeneral.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacionGeneral.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblInformacionGeneral.Location = New System.Drawing.Point(141, 84)
        Me.lblInformacionGeneral.Name = "lblInformacionGeneral"
        Me.lblInformacionGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInformacionGeneral.Size = New System.Drawing.Size(213, 17)
        Me.lblInformacionGeneral.TabIndex = 51
        Me.lblInformacionGeneral.Text = "Información general de activos"
        Me.lblInformacionGeneral.UseMnemonic = False
        '
        'lblTomaFisica
        '
        Me.lblTomaFisica.BackColor = System.Drawing.Color.Transparent
        Me.lblTomaFisica.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTomaFisica.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTomaFisica.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTomaFisica.Location = New System.Drawing.Point(141, 153)
        Me.lblTomaFisica.Name = "lblTomaFisica"
        Me.lblTomaFisica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTomaFisica.Size = New System.Drawing.Size(213, 17)
        Me.lblTomaFisica.TabIndex = 50
        Me.lblTomaFisica.Text = "Toma física inventario de activos"
        Me.lblTomaFisica.UseMnemonic = False
        '
        'lblReporteGeneral
        '
        Me.lblReporteGeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblReporteGeneral.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblReporteGeneral.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporteGeneral.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblReporteGeneral.Location = New System.Drawing.Point(141, 61)
        Me.lblReporteGeneral.Name = "lblReporteGeneral"
        Me.lblReporteGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReporteGeneral.Size = New System.Drawing.Size(213, 17)
        Me.lblReporteGeneral.TabIndex = 49
        Me.lblReporteGeneral.Text = "Reporte general de activos"
        Me.lblReporteGeneral.UseMnemonic = False
        '
        'lblProyeccion
        '
        Me.lblProyeccion.BackColor = System.Drawing.Color.Transparent
        Me.lblProyeccion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblProyeccion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProyeccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblProyeccion.Location = New System.Drawing.Point(141, 176)
        Me.lblProyeccion.Name = "lblProyeccion"
        Me.lblProyeccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProyeccion.Size = New System.Drawing.Size(213, 17)
        Me.lblProyeccion.TabIndex = 48
        Me.lblProyeccion.Text = "Proyección de depreciaciones"
        Me.lblProyeccion.UseMnemonic = False
        '
        'lblTotalmente
        '
        Me.lblTotalmente.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalmente.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTotalmente.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalmente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTotalmente.Location = New System.Drawing.Point(141, 199)
        Me.lblTotalmente.Name = "lblTotalmente"
        Me.lblTotalmente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalmente.Size = New System.Drawing.Size(213, 17)
        Me.lblTotalmente.TabIndex = 47
        Me.lblTotalmente.Text = "Activos totalmente depreciados"
        Me.lblTotalmente.UseMnemonic = False
        '
        'lblPorTipo
        '
        Me.lblPorTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblPorTipo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblPorTipo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPorTipo.Location = New System.Drawing.Point(141, 222)
        Me.lblPorTipo.Name = "lblPorTipo"
        Me.lblPorTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPorTipo.Size = New System.Drawing.Size(213, 17)
        Me.lblPorTipo.TabIndex = 46
        Me.lblPorTipo.Text = "Activos por tipo de activo"
        Me.lblPorTipo.UseMnemonic = False
        '
        'lblDepreciados
        '
        Me.lblDepreciados.BackColor = System.Drawing.Color.Transparent
        Me.lblDepreciados.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblDepreciados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciados.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDepreciados.Location = New System.Drawing.Point(141, 245)
        Me.lblDepreciados.Name = "lblDepreciados"
        Me.lblDepreciados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDepreciados.Size = New System.Drawing.Size(213, 17)
        Me.lblDepreciados.TabIndex = 45
        Me.lblDepreciados.Text = "Activos depreciados"
        Me.lblDepreciados.UseMnemonic = False
        '
        'lblACTMVAN4
        '
        Me.lblACTMVAN4.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMVAN4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMVAN4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMVAN4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMVAN4.Location = New System.Drawing.Point(360, 107)
        Me.lblACTMVAN4.Name = "lblACTMVAN4"
        Me.lblACTMVAN4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMVAN4.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMVAN4.TabIndex = 44
        Me.lblACTMVAN4.Text = "ACTMVAN4"
        Me.lblACTMVAN4.UseMnemonic = False
        '
        'lblACTMAFN3
        '
        Me.lblACTMAFN3.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMAFN3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMAFN3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMAFN3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMAFN3.Location = New System.Drawing.Point(360, 38)
        Me.lblACTMAFN3.Name = "lblACTMAFN3"
        Me.lblACTMAFN3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMAFN3.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMAFN3.TabIndex = 43
        Me.lblACTMAFN3.Text = "ACTMAFN3"
        Me.lblACTMAFN3.UseMnemonic = False
        '
        'lblACTMVAN3
        '
        Me.lblACTMVAN3.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMVAN3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMVAN3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMVAN3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMVAN3.Location = New System.Drawing.Point(360, 130)
        Me.lblACTMVAN3.Name = "lblACTMVAN3"
        Me.lblACTMVAN3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMVAN3.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMVAN3.TabIndex = 42
        Me.lblACTMVAN3.Text = "ACTMVAN3"
        Me.lblACTMVAN3.UseMnemonic = False
        '
        'lblACTMAFN2
        '
        Me.lblACTMAFN2.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMAFN2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMAFN2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMAFN2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMAFN2.Location = New System.Drawing.Point(360, 84)
        Me.lblACTMAFN2.Name = "lblACTMAFN2"
        Me.lblACTMAFN2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMAFN2.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMAFN2.TabIndex = 41
        Me.lblACTMAFN2.Text = "ACTMAFN2"
        Me.lblACTMAFN2.UseMnemonic = False
        '
        'lblACTMAFN5
        '
        Me.lblACTMAFN5.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMAFN5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMAFN5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMAFN5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMAFN5.Location = New System.Drawing.Point(360, 153)
        Me.lblACTMAFN5.Name = "lblACTMAFN5"
        Me.lblACTMAFN5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMAFN5.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMAFN5.TabIndex = 40
        Me.lblACTMAFN5.Text = "ACTMAFN5"
        Me.lblACTMAFN5.UseMnemonic = False
        '
        'lblACTMAFN6
        '
        Me.lblACTMAFN6.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMAFN6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMAFN6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMAFN6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMAFN6.Location = New System.Drawing.Point(360, 61)
        Me.lblACTMAFN6.Name = "lblACTMAFN6"
        Me.lblACTMAFN6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMAFN6.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMAFN6.TabIndex = 39
        Me.lblACTMAFN6.Text = "ACTMAFN6"
        Me.lblACTMAFN6.UseMnemonic = False
        '
        'lblACTMVAN5
        '
        Me.lblACTMVAN5.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMVAN5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMVAN5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMVAN5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMVAN5.Location = New System.Drawing.Point(360, 176)
        Me.lblACTMVAN5.Name = "lblACTMVAN5"
        Me.lblACTMVAN5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMVAN5.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMVAN5.TabIndex = 38
        Me.lblACTMVAN5.Text = "ACTMVAN5"
        Me.lblACTMVAN5.UseMnemonic = False
        '
        'lblACTMVAN6
        '
        Me.lblACTMVAN6.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMVAN6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMVAN6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMVAN6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMVAN6.Location = New System.Drawing.Point(360, 199)
        Me.lblACTMVAN6.Name = "lblACTMVAN6"
        Me.lblACTMVAN6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMVAN6.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMVAN6.TabIndex = 37
        Me.lblACTMVAN6.Text = "ACTMVAN6"
        Me.lblACTMVAN6.UseMnemonic = False
        '
        'lblACTMVAN7
        '
        Me.lblACTMVAN7.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMVAN7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMVAN7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMVAN7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMVAN7.Location = New System.Drawing.Point(360, 222)
        Me.lblACTMVAN7.Name = "lblACTMVAN7"
        Me.lblACTMVAN7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMVAN7.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMVAN7.TabIndex = 36
        Me.lblACTMVAN7.Text = "ACTMVAN7"
        Me.lblACTMVAN7.UseMnemonic = False
        '
        'lblACTMVAN8
        '
        Me.lblACTMVAN8.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMVAN8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMVAN8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMVAN8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMVAN8.Location = New System.Drawing.Point(360, 245)
        Me.lblACTMVAN8.Name = "lblACTMVAN8"
        Me.lblACTMVAN8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMVAN8.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMVAN8.TabIndex = 35
        Me.lblACTMVAN8.Text = "ACTMVAN8"
        Me.lblACTMVAN8.UseMnemonic = False
        '
        'IconosMenus
        '
        Me.IconosMenus.ImageStream = CType(resources.GetObject("IconosMenus.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosMenus.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosMenus.Images.SetKeyName(0, "TheEnd.ico")
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 425)
        Me.Controls.Add(Me.LabelEmpresa)
        Me.Controls.Add(Me.MENU_Renamed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.LeerPosicion = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPC - Activos Fijos [Reportes] "
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MENU_Renamed.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelEmpresa As System.Windows.Forms.Label
    Friend WithEvents MENU_Renamed As System.Windows.Forms.GroupBox
    Public WithEvents cm3Salir As System.Windows.Forms.Button
    Public WithEvents MenuDepreciados As System.Windows.Forms.Button
    Public WithEvents MenuTipoActivos As System.Windows.Forms.Button
    Public WithEvents MenuTotalmenteDepreciados As System.Windows.Forms.Button
    Public WithEvents MenuProyeccion As System.Windows.Forms.Button
    Public WithEvents MenuTomaFisica As System.Windows.Forms.Button
    Public WithEvents MenuDepreciaciones As System.Windows.Forms.Button
    Public WithEvents MenuMovimientos As System.Windows.Forms.Button
    Public WithEvents MenuInformacionGeneral As System.Windows.Forms.Button
    Public WithEvents MenuReporteGeneral As System.Windows.Forms.Button
    Public WithEvents MenuCatalogo As System.Windows.Forms.Button
    Public WithEvents lblMovimientos As System.Windows.Forms.Label
    Public WithEvents lblCatalogoActivos As System.Windows.Forms.Label
    Public WithEvents lblDepreciaciones As System.Windows.Forms.Label
    Public WithEvents lblInformacionGeneral As System.Windows.Forms.Label
    Public WithEvents lblTomaFisica As System.Windows.Forms.Label
    Public WithEvents lblReporteGeneral As System.Windows.Forms.Label
    Public WithEvents lblProyeccion As System.Windows.Forms.Label
    Public WithEvents lblTotalmente As System.Windows.Forms.Label
    Public WithEvents lblPorTipo As System.Windows.Forms.Label
    Public WithEvents lblDepreciados As System.Windows.Forms.Label
    Public WithEvents lblACTMVAN4 As System.Windows.Forms.Label
    Public WithEvents lblACTMAFN3 As System.Windows.Forms.Label
    Public WithEvents lblACTMVAN3 As System.Windows.Forms.Label
    Public WithEvents lblACTMAFN2 As System.Windows.Forms.Label
    Public WithEvents lblACTMAFN5 As System.Windows.Forms.Label
    Public WithEvents lblACTMAFN6 As System.Windows.Forms.Label
    Public WithEvents lblACTMVAN5 As System.Windows.Forms.Label
    Public WithEvents lblACTMVAN6 As System.Windows.Forms.Label
    Public WithEvents lblACTMVAN7 As System.Windows.Forms.Label
    Public WithEvents lblACTMVAN8 As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Public WithEvents MenuAddDispFull As System.Windows.Forms.Button
    Public WithEvents lblAltaDesecho As System.Windows.Forms.Label
    Public WithEvents lblAddDispFull As System.Windows.Forms.Label
    Public WithEvents MenuExportAllFields As System.Windows.Forms.Button
    Public WithEvents lblExportAllFields As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
End Class
