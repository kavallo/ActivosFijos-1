<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits Citi.Synergia.UIGenerico.Forma

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
        Me.cm3Salir = New System.Windows.Forms.Button()
        Me.MenuIngresoDeActivos = New System.Windows.Forms.Button()
        Me.MenuActualizacion = New System.Windows.Forms.Button()
        Me.MenuAnulacion = New System.Windows.Forms.Button()
        Me.MenuServiciosActivos = New System.Windows.Forms.Button()
        Me.MenuOperaciones = New System.Windows.Forms.Button()
        Me.MenuRevaluaciones = New System.Windows.Forms.Button()
        Me.MenuCalculoDepreciacion = New System.Windows.Forms.Button()
        Me.MenuSeguros = New System.Windows.Forms.Button()
        Me.MenuCategoriaActivos = New System.Windows.Forms.Button()
        Me.MenuUbicaciones = New System.Windows.Forms.Button()
        Me._lblDescrip_9 = New System.Windows.Forms.Label()
        Me._lblNombre_9 = New System.Windows.Forms.Label()
        Me._lblNombre_8 = New System.Windows.Forms.Label()
        Me._lblDescrip_8 = New System.Windows.Forms.Label()
        Me._lblDescrip_7 = New System.Windows.Forms.Label()
        Me._lblNombre_7 = New System.Windows.Forms.Label()
        Me._lblNombre_6 = New System.Windows.Forms.Label()
        Me._lblDescrip_6 = New System.Windows.Forms.Label()
        Me._lblNombre_2 = New System.Windows.Forms.Label()
        Me._lblDescrip_2 = New System.Windows.Forms.Label()
        Me._lblDescrip_1 = New System.Windows.Forms.Label()
        Me._lblNombre_1 = New System.Windows.Forms.Label()
        Me._lblDescrip_0 = New System.Windows.Forms.Label()
        Me._lblNombre_0 = New System.Windows.Forms.Label()
        Me._lblNombre_3 = New System.Windows.Forms.Label()
        Me._lblDescrip_3 = New System.Windows.Forms.Label()
        Me._lblNombre_4 = New System.Windows.Forms.Label()
        Me._lblDescrip_4 = New System.Windows.Forms.Label()
        Me._lblDescrip_5 = New System.Windows.Forms.Label()
        Me._lblNombre_5 = New System.Windows.Forms.Label()
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
        Me.LabelEmpresa.Location = New System.Drawing.Point(12, 35)
        Me.LabelEmpresa.Name = "LabelEmpresa"
        Me.LabelEmpresa.Size = New System.Drawing.Size(517, 23)
        Me.LabelEmpresa.TabIndex = 3
        Me.LabelEmpresa.UseMnemonic = False
        '
        'MENU_Renamed
        '
        Me.MENU_Renamed.BackColor = System.Drawing.SystemColors.Control
        Me.MENU_Renamed.Controls.Add(Me.cm3Salir)
        Me.MENU_Renamed.Controls.Add(Me.MenuIngresoDeActivos)
        Me.MENU_Renamed.Controls.Add(Me.MenuActualizacion)
        Me.MENU_Renamed.Controls.Add(Me.MenuAnulacion)
        Me.MENU_Renamed.Controls.Add(Me.MenuServiciosActivos)
        Me.MENU_Renamed.Controls.Add(Me.MenuOperaciones)
        Me.MENU_Renamed.Controls.Add(Me.MenuRevaluaciones)
        Me.MENU_Renamed.Controls.Add(Me.MenuCalculoDepreciacion)
        Me.MENU_Renamed.Controls.Add(Me.MenuSeguros)
        Me.MENU_Renamed.Controls.Add(Me.MenuCategoriaActivos)
        Me.MENU_Renamed.Controls.Add(Me.MenuUbicaciones)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_9)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_9)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_8)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_8)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_7)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_7)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_6)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_6)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_2)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_2)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_1)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_1)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_0)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_0)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_3)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_3)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_4)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_4)
        Me.MENU_Renamed.Controls.Add(Me._lblDescrip_5)
        Me.MENU_Renamed.Controls.Add(Me._lblNombre_5)
        Me.MENU_Renamed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENU_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MENU_Renamed.Location = New System.Drawing.Point(12, 61)
        Me.MENU_Renamed.Name = "MENU_Renamed"
        Me.MENU_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MENU_Renamed.Size = New System.Drawing.Size(529, 289)
        Me.MENU_Renamed.TabIndex = 4
        Me.MENU_Renamed.TabStop = False
        '
        'cm3Salir
        '
        Me.cm3Salir.BackColor = System.Drawing.SystemColors.Control
        Me.cm3Salir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cm3Salir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cm3Salir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cm3Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cm3Salir.Location = New System.Drawing.Point(462, 224)
        Me.cm3Salir.Name = "cm3Salir"
        Me.cm3Salir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cm3Salir.Size = New System.Drawing.Size(61, 59)
        Me.cm3Salir.TabIndex = 10
        Me.cm3Salir.Text = "@1"
        Me.cm3Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cm3Salir.UseMnemonic = False
        Me.cm3Salir.UseVisualStyleBackColor = False
        '
        'MenuIngresoDeActivos
        '
        Me.MenuIngresoDeActivos.BackColor = System.Drawing.SystemColors.Control
        Me.MenuIngresoDeActivos.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuIngresoDeActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuIngresoDeActivos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuIngresoDeActivos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuIngresoDeActivos.Location = New System.Drawing.Point(86, 29)
        Me.MenuIngresoDeActivos.Name = "MenuIngresoDeActivos"
        Me.MenuIngresoDeActivos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuIngresoDeActivos.Size = New System.Drawing.Size(17, 17)
        Me.MenuIngresoDeActivos.TabIndex = 0
        Me.MenuIngresoDeActivos.Tag = "0201000"
        Me.MenuIngresoDeActivos.UseVisualStyleBackColor = False
        '
        'MenuActualizacion
        '
        Me.MenuActualizacion.BackColor = System.Drawing.SystemColors.Control
        Me.MenuActualizacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuActualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuActualizacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuActualizacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuActualizacion.Location = New System.Drawing.Point(86, 49)
        Me.MenuActualizacion.Name = "MenuActualizacion"
        Me.MenuActualizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuActualizacion.Size = New System.Drawing.Size(17, 17)
        Me.MenuActualizacion.TabIndex = 1
        Me.MenuActualizacion.Tag = "0202000"
        Me.MenuActualizacion.UseVisualStyleBackColor = False
        '
        'MenuAnulacion
        '
        Me.MenuAnulacion.BackColor = System.Drawing.SystemColors.Control
        Me.MenuAnulacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuAnulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuAnulacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuAnulacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuAnulacion.Location = New System.Drawing.Point(86, 69)
        Me.MenuAnulacion.Name = "MenuAnulacion"
        Me.MenuAnulacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuAnulacion.Size = New System.Drawing.Size(17, 17)
        Me.MenuAnulacion.TabIndex = 2
        Me.MenuAnulacion.Tag = "0203000"
        Me.MenuAnulacion.UseVisualStyleBackColor = False
        '
        'MenuServiciosActivos
        '
        Me.MenuServiciosActivos.BackColor = System.Drawing.SystemColors.Control
        Me.MenuServiciosActivos.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuServiciosActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuServiciosActivos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuServiciosActivos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuServiciosActivos.Location = New System.Drawing.Point(86, 89)
        Me.MenuServiciosActivos.Name = "MenuServiciosActivos"
        Me.MenuServiciosActivos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuServiciosActivos.Size = New System.Drawing.Size(17, 17)
        Me.MenuServiciosActivos.TabIndex = 3
        Me.MenuServiciosActivos.Tag = "0204000"
        Me.MenuServiciosActivos.UseVisualStyleBackColor = False
        '
        'MenuOperaciones
        '
        Me.MenuOperaciones.BackColor = System.Drawing.SystemColors.Control
        Me.MenuOperaciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuOperaciones.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuOperaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuOperaciones.Location = New System.Drawing.Point(86, 109)
        Me.MenuOperaciones.Name = "MenuOperaciones"
        Me.MenuOperaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuOperaciones.Size = New System.Drawing.Size(17, 17)
        Me.MenuOperaciones.TabIndex = 4
        Me.MenuOperaciones.Tag = "0205000"
        Me.MenuOperaciones.UseVisualStyleBackColor = False
        '
        'MenuRevaluaciones
        '
        Me.MenuRevaluaciones.BackColor = System.Drawing.SystemColors.Control
        Me.MenuRevaluaciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuRevaluaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuRevaluaciones.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuRevaluaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuRevaluaciones.Location = New System.Drawing.Point(86, 129)
        Me.MenuRevaluaciones.Name = "MenuRevaluaciones"
        Me.MenuRevaluaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuRevaluaciones.Size = New System.Drawing.Size(17, 17)
        Me.MenuRevaluaciones.TabIndex = 5
        Me.MenuRevaluaciones.Tag = "0206000"
        Me.MenuRevaluaciones.UseVisualStyleBackColor = False
        '
        'MenuCalculoDepreciacion
        '
        Me.MenuCalculoDepreciacion.BackColor = System.Drawing.SystemColors.Control
        Me.MenuCalculoDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuCalculoDepreciacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuCalculoDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCalculoDepreciacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuCalculoDepreciacion.Location = New System.Drawing.Point(86, 149)
        Me.MenuCalculoDepreciacion.Name = "MenuCalculoDepreciacion"
        Me.MenuCalculoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuCalculoDepreciacion.Size = New System.Drawing.Size(17, 17)
        Me.MenuCalculoDepreciacion.TabIndex = 6
        Me.MenuCalculoDepreciacion.Tag = "0207000"
        Me.MenuCalculoDepreciacion.UseVisualStyleBackColor = False
        '
        'MenuSeguros
        '
        Me.MenuSeguros.BackColor = System.Drawing.SystemColors.Control
        Me.MenuSeguros.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuSeguros.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuSeguros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuSeguros.Location = New System.Drawing.Point(86, 169)
        Me.MenuSeguros.Name = "MenuSeguros"
        Me.MenuSeguros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuSeguros.Size = New System.Drawing.Size(17, 17)
        Me.MenuSeguros.TabIndex = 7
        Me.MenuSeguros.Tag = "0208000"
        Me.MenuSeguros.UseVisualStyleBackColor = False
        '
        'MenuCategoriaActivos
        '
        Me.MenuCategoriaActivos.BackColor = System.Drawing.SystemColors.Control
        Me.MenuCategoriaActivos.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuCategoriaActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuCategoriaActivos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCategoriaActivos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuCategoriaActivos.Location = New System.Drawing.Point(86, 189)
        Me.MenuCategoriaActivos.Name = "MenuCategoriaActivos"
        Me.MenuCategoriaActivos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuCategoriaActivos.Size = New System.Drawing.Size(17, 17)
        Me.MenuCategoriaActivos.TabIndex = 8
        Me.MenuCategoriaActivos.Tag = "0209000"
        Me.MenuCategoriaActivos.UseVisualStyleBackColor = False
        '
        'MenuUbicaciones
        '
        Me.MenuUbicaciones.BackColor = System.Drawing.SystemColors.Control
        Me.MenuUbicaciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuUbicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuUbicaciones.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuUbicaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuUbicaciones.Location = New System.Drawing.Point(86, 209)
        Me.MenuUbicaciones.Name = "MenuUbicaciones"
        Me.MenuUbicaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuUbicaciones.Size = New System.Drawing.Size(17, 17)
        Me.MenuUbicaciones.TabIndex = 9
        Me.MenuUbicaciones.Tag = "0210000"
        Me.MenuUbicaciones.UseVisualStyleBackColor = False
        '
        '_lblDescrip_9
        '
        Me._lblDescrip_9.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_9.Location = New System.Drawing.Point(109, 210)
        Me._lblDescrip_9.Name = "_lblDescrip_9"
        Me._lblDescrip_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_9.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_9.TabIndex = 34
        Me._lblDescrip_9.Text = "Toma física"
        Me._lblDescrip_9.UseMnemonic = False
        '
        '_lblNombre_9
        '
        Me._lblNombre_9.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_9.Location = New System.Drawing.Point(328, 210)
        Me._lblNombre_9.Name = "_lblNombre_9"
        Me._lblNombre_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_9.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_9.TabIndex = 33
        Me._lblNombre_9.Text = "ACTTOMS0"
        Me._lblNombre_9.UseMnemonic = False
        '
        '_lblNombre_8
        '
        Me._lblNombre_8.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_8.Location = New System.Drawing.Point(328, 190)
        Me._lblNombre_8.Name = "_lblNombre_8"
        Me._lblNombre_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_8.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_8.TabIndex = 32
        Me._lblNombre_8.Text = "ACTETAS0"
        Me._lblNombre_8.UseMnemonic = False
        '
        '_lblDescrip_8
        '
        Me._lblDescrip_8.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_8.Location = New System.Drawing.Point(109, 190)
        Me._lblDescrip_8.Name = "_lblDescrip_8"
        Me._lblDescrip_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_8.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_8.TabIndex = 31
        Me._lblDescrip_8.Text = "Traslados de activos"
        Me._lblDescrip_8.UseMnemonic = False
        '
        '_lblDescrip_7
        '
        Me._lblDescrip_7.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_7.Location = New System.Drawing.Point(109, 170)
        Me._lblDescrip_7.Name = "_lblDescrip_7"
        Me._lblDescrip_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_7.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_7.TabIndex = 30
        Me._lblDescrip_7.Text = "Seguros"
        Me._lblDescrip_7.UseMnemonic = False
        '
        '_lblNombre_7
        '
        Me._lblNombre_7.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_7.Location = New System.Drawing.Point(328, 170)
        Me._lblNombre_7.Name = "_lblNombre_7"
        Me._lblNombre_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_7.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_7.TabIndex = 29
        Me._lblNombre_7.Text = "ACTSEES0"
        Me._lblNombre_7.UseMnemonic = False
        '
        '_lblNombre_6
        '
        Me._lblNombre_6.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_6.Location = New System.Drawing.Point(328, 150)
        Me._lblNombre_6.Name = "_lblNombre_6"
        Me._lblNombre_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_6.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_6.TabIndex = 28
        Me._lblNombre_6.Text = "ACTMVAN0"
        Me._lblNombre_6.UseMnemonic = False
        '
        '_lblDescrip_6
        '
        Me._lblDescrip_6.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_6.Location = New System.Drawing.Point(109, 150)
        Me._lblDescrip_6.Name = "_lblDescrip_6"
        Me._lblDescrip_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_6.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_6.TabIndex = 27
        Me._lblDescrip_6.Text = "Cálculo de depreciación"
        Me._lblDescrip_6.UseMnemonic = False
        '
        '_lblNombre_2
        '
        Me._lblNombre_2.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_2.Location = New System.Drawing.Point(328, 70)
        Me._lblNombre_2.Name = "_lblNombre_2"
        Me._lblNombre_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_2.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_2.TabIndex = 26
        Me._lblNombre_2.Text = "ACTMAFS2"
        Me._lblNombre_2.UseMnemonic = False
        '
        '_lblDescrip_2
        '
        Me._lblDescrip_2.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_2.Location = New System.Drawing.Point(109, 70)
        Me._lblDescrip_2.Name = "_lblDescrip_2"
        Me._lblDescrip_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_2.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_2.TabIndex = 25
        Me._lblDescrip_2.Text = "Anulación de autorización de activos"
        Me._lblDescrip_2.UseMnemonic = False
        '
        '_lblDescrip_1
        '
        Me._lblDescrip_1.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_1.Location = New System.Drawing.Point(109, 50)
        Me._lblDescrip_1.Name = "_lblDescrip_1"
        Me._lblDescrip_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_1.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_1.TabIndex = 24
        Me._lblDescrip_1.Text = "Actualización de activos"
        Me._lblDescrip_1.UseMnemonic = False
        '
        '_lblNombre_1
        '
        Me._lblNombre_1.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_1.Location = New System.Drawing.Point(328, 50)
        Me._lblNombre_1.Name = "_lblNombre_1"
        Me._lblNombre_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_1.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_1.TabIndex = 23
        Me._lblNombre_1.Text = "ACTMAFS1"
        Me._lblNombre_1.UseMnemonic = False
        '
        '_lblDescrip_0
        '
        Me._lblDescrip_0.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_0.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_0.Location = New System.Drawing.Point(109, 30)
        Me._lblDescrip_0.Name = "_lblDescrip_0"
        Me._lblDescrip_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_0.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_0.TabIndex = 22
        Me._lblDescrip_0.Text = "Ingreso de activos"
        Me._lblDescrip_0.UseMnemonic = False
        '
        '_lblNombre_0
        '
        Me._lblNombre_0.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_0.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_0.Location = New System.Drawing.Point(328, 30)
        Me._lblNombre_0.Name = "_lblNombre_0"
        Me._lblNombre_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_0.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_0.TabIndex = 21
        Me._lblNombre_0.Text = "ACTMAFS0"
        Me._lblNombre_0.UseMnemonic = False
        '
        '_lblNombre_3
        '
        Me._lblNombre_3.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_3.Location = New System.Drawing.Point(328, 90)
        Me._lblNombre_3.Name = "_lblNombre_3"
        Me._lblNombre_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_3.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_3.TabIndex = 20
        Me._lblNombre_3.Text = "ACTSEAS0"
        Me._lblNombre_3.UseMnemonic = False
        '
        '_lblDescrip_3
        '
        Me._lblDescrip_3.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_3.Location = New System.Drawing.Point(109, 90)
        Me._lblDescrip_3.Name = "_lblDescrip_3"
        Me._lblDescrip_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_3.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_3.TabIndex = 19
        Me._lblDescrip_3.Text = "Servicios a activos"
        Me._lblDescrip_3.UseMnemonic = False
        '
        '_lblNombre_4
        '
        Me._lblNombre_4.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_4.Location = New System.Drawing.Point(328, 110)
        Me._lblNombre_4.Name = "_lblNombre_4"
        Me._lblNombre_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_4.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_4.TabIndex = 18
        Me._lblNombre_4.Text = "ACTMAFS3"
        Me._lblNombre_4.UseMnemonic = False
        '
        '_lblDescrip_4
        '
        Me._lblDescrip_4.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_4.Location = New System.Drawing.Point(109, 110)
        Me._lblDescrip_4.Name = "_lblDescrip_4"
        Me._lblDescrip_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_4.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_4.TabIndex = 17
        Me._lblDescrip_4.Text = "Operaciones con activos"
        Me._lblDescrip_4.UseMnemonic = False
        '
        '_lblDescrip_5
        '
        Me._lblDescrip_5.BackColor = System.Drawing.Color.Transparent
        Me._lblDescrip_5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblDescrip_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDescrip_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDescrip_5.Location = New System.Drawing.Point(109, 130)
        Me._lblDescrip_5.Name = "_lblDescrip_5"
        Me._lblDescrip_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDescrip_5.Size = New System.Drawing.Size(213, 17)
        Me._lblDescrip_5.TabIndex = 16
        Me._lblDescrip_5.Text = "Revaluaciones"
        Me._lblDescrip_5.UseMnemonic = False
        '
        '_lblNombre_5
        '
        Me._lblNombre_5.BackColor = System.Drawing.Color.Transparent
        Me._lblNombre_5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._lblNombre_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblNombre_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblNombre_5.Location = New System.Drawing.Point(328, 130)
        Me._lblNombre_5.Name = "_lblNombre_5"
        Me._lblNombre_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblNombre_5.Size = New System.Drawing.Size(101, 17)
        Me._lblNombre_5.TabIndex = 15
        Me._lblNombre_5.Text = "ACTRVES0"
        Me._lblNombre_5.UseMnemonic = False
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
        Me.ClientSize = New System.Drawing.Size(553, 362)
        Me.Controls.Add(Me.MENU_Renamed)
        Me.Controls.Add(Me.LabelEmpresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPC - Activos Fijos [Operación] - Principal"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MENU_Renamed.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelEmpresa As System.Windows.Forms.Label
    Public WithEvents MENU_Renamed As System.Windows.Forms.GroupBox
    Public WithEvents MenuIngresoDeActivos As System.Windows.Forms.Button
    Public WithEvents MenuActualizacion As System.Windows.Forms.Button
    Public WithEvents MenuAnulacion As System.Windows.Forms.Button
    Public WithEvents MenuServiciosActivos As System.Windows.Forms.Button
    Public WithEvents MenuOperaciones As System.Windows.Forms.Button
    Public WithEvents MenuRevaluaciones As System.Windows.Forms.Button
    Public WithEvents MenuCalculoDepreciacion As System.Windows.Forms.Button
    Public WithEvents MenuSeguros As System.Windows.Forms.Button
    Public WithEvents MenuCategoriaActivos As System.Windows.Forms.Button
    Public WithEvents MenuUbicaciones As System.Windows.Forms.Button
    Public WithEvents _lblDescrip_9 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_9 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_8 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_8 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_7 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_7 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_6 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_6 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_2 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_2 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_1 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_1 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_0 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_0 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_3 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_3 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_4 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_4 As System.Windows.Forms.Label
    Public WithEvents _lblDescrip_5 As System.Windows.Forms.Label
    Public WithEvents _lblNombre_5 As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Public WithEvents cm3Salir As System.Windows.Forms.Button
End Class
