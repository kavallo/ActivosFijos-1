<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PATRAC01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PATRAC01))
        Me.OptCuenta = New System.Windows.Forms.RadioButton()
        Me.OptSecuencia = New System.Windows.Forms.RadioButton()
        Me.lblAVISO = New System.Windows.Forms.Label()
        Me.OptDEBE = New System.Windows.Forms.RadioButton()
        Me.grpMoneda = New System.Windows.Forms.GroupBox()
        Me.OptLOCAL = New System.Windows.Forms.RadioButton()
        Me.OptDOLAR = New System.Windows.Forms.RadioButton()
        Me.grpOrdenamiento = New System.Windows.Forms.GroupBox()
        Me.BotonLlenar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.BotonConsolida = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsolida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mhTab1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Tab1 = New System.Windows.Forms.GroupBox()
        Me.cboDESCRIPCION = New System.Windows.Forms.ComboBox()
        Me.lblTitNombre_Tipo = New System.Windows.Forms.Label()
        Me.lblFECHA_PARTIDA = New System.Windows.Forms.Label()
        Me.lblTIPO_PARTIDA = New System.Windows.Forms.Label()
        Me.lblTASA_DE_CAMBIO = New System.Windows.Forms.Label()
        Me.lblTitFECHA_PARTIDA = New System.Windows.Forms.Label()
        Me.lblTitTIPO_PARTIDA = New System.Windows.Forms.Label()
        Me.lblTitTASA_DE_CAMBIO = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_EMPRESA = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_SUCURSAL = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_CENTRO = New System.Windows.Forms.Label()
        Me._lbldescripcion_origen_1 = New System.Windows.Forms.Label()
        Me._lbldescripcion_origen_2 = New System.Windows.Forms.Label()
        Me._lbldescripcion_origen_3 = New System.Windows.Forms.Label()
        Me._lbldescripcion_origen_4 = New System.Windows.Forms.Label()
        Me._lbldescripcion_origen_5 = New System.Windows.Forms.Label()
        Me._lbldescripcion_origen_6 = New System.Windows.Forms.Label()
        Me.lblNO_PERIODO = New System.Windows.Forms.Label()
        Me.lblNUMERO_PARTIDA = New System.Windows.Forms.Label()
        Me.lblANO_PERIODO = New System.Windows.Forms.Label()
        Me.lblDOCUMENTO_ORIGEN = New System.Windows.Forms.Label()
        Me.lblID_EMPRESA = New System.Windows.Forms.Label()
        Me.lblID_SUCURSAL = New System.Windows.Forms.Label()
        Me.lblID_CENTRO_OPERATIVO = New System.Windows.Forms.Label()
        Me._lblorigen_4 = New System.Windows.Forms.Label()
        Me._lblorigen_3 = New System.Windows.Forms.Label()
        Me._lblorigen_2 = New System.Windows.Forms.Label()
        Me._lblorigen_1 = New System.Windows.Forms.Label()
        Me._lblorigen_5 = New System.Windows.Forms.Label()
        Me._lblorigen_6 = New System.Windows.Forms.Label()
        Me._lblTitDESCRIPCION_1_0 = New System.Windows.Forms.Label()
        Me.lblTitNUMERO_PARTIDA = New System.Windows.Forms.Label()
        Me.lblTitNO_PERIODO = New System.Windows.Forms.Label()
        Me.lblTitDOCUMENTO_ORIGEN = New System.Windows.Forms.Label()
        Me.lblTitID_EMPRESA = New System.Windows.Forms.Label()
        Me.lblTitID_SUCURSAL = New System.Windows.Forms.Label()
        Me.lblTitID_CENTRO_OPERATIVO = New System.Windows.Forms.Label()
        Me._lbltitORIGEN_4 = New System.Windows.Forms.Label()
        Me._lbltitORIGEN_3 = New System.Windows.Forms.Label()
        Me._lbltitORIGEN_2 = New System.Windows.Forms.Label()
        Me._lbltitORIGEN_1 = New System.Windows.Forms.Label()
        Me._lbltitORIGEN_5 = New System.Windows.Forms.Label()
        Me._lbltitORIGEN_6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.lblTitCODIGO_MODULO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitREFERENCIA_1 = New System.Windows.Forms.Label()
        Me.lblPARTIDA_ORIGEN = New System.Windows.Forms.Label()
        Me.lblUSUARIO_INGRESO = New System.Windows.Forms.Label()
        Me.lblTitUSUARIO_INGRESO = New System.Windows.Forms.Label()
        Me.lblTitFECHA_MAYORIZACION = New System.Windows.Forms.Label()
        Me.lblCODIGO_MODULO = New System.Windows.Forms.Label()
        Me.lblTOTALES = New System.Windows.Forms.Label()
        Me.lblREFERENCIA_1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFECHA_INGRESO = New System.Windows.Forms.Label()
        Me.lblTitCodigo_razon = New System.Windows.Forms.Label()
        Me.lblTitREFERENCIA_2 = New System.Windows.Forms.Label()
        Me.lblCodigo_razon = New System.Windows.Forms.Label()
        Me.lblDES_RAZON = New System.Windows.Forms.Label()
        Me.lblREFERENCIA_2 = New System.Windows.Forms.Label()
        Me.lblUSUARIO_AUTORIZO = New System.Windows.Forms.Label()
        Me.lblFECHA_AUTORIZO = New System.Windows.Forms.Label()
        Me.Encabezado = New System.Windows.Forms.Panel()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMoneda.SuspendLayout()
        Me.grpOrdenamiento.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.mhTab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptCuenta
        '
        Me.OptCuenta.BackColor = System.Drawing.SystemColors.Control
        Me.OptCuenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCuenta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OptCuenta.Location = New System.Drawing.Point(126, 19)
        Me.OptCuenta.Name = "OptCuenta"
        Me.OptCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptCuenta.Size = New System.Drawing.Size(127, 16)
        Me.OptCuenta.TabIndex = 1
        Me.OptCuenta.Text = "Código cuenta"
        Me.OptCuenta.UseMnemonic = False
        Me.OptCuenta.UseVisualStyleBackColor = False
        '
        'OptSecuencia
        '
        Me.OptSecuencia.BackColor = System.Drawing.SystemColors.Control
        Me.OptSecuencia.Checked = True
        Me.OptSecuencia.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptSecuencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptSecuencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OptSecuencia.Location = New System.Drawing.Point(6, 19)
        Me.OptSecuencia.Name = "OptSecuencia"
        Me.OptSecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptSecuencia.Size = New System.Drawing.Size(57, 16)
        Me.OptSecuencia.TabIndex = 0
        Me.OptSecuencia.TabStop = True
        Me.OptSecuencia.Text = "Línea"
        Me.OptSecuencia.UseMnemonic = False
        Me.OptSecuencia.UseVisualStyleBackColor = False
        '
        'lblAVISO
        '
        Me.lblAVISO.BackColor = System.Drawing.SystemColors.Control
        Me.lblAVISO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAVISO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAVISO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAVISO.Location = New System.Drawing.Point(546, 27)
        Me.lblAVISO.Name = "lblAVISO"
        Me.lblAVISO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAVISO.Size = New System.Drawing.Size(137, 41)
        Me.lblAVISO.TabIndex = 81
        Me.lblAVISO.Text = "AVISO:  Esta partida                 fue modificada              manualmente."
        Me.lblAVISO.UseMnemonic = False
        Me.lblAVISO.Visible = False
        '
        'OptDEBE
        '
        Me.OptDEBE.BackColor = System.Drawing.SystemColors.Control
        Me.OptDEBE.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptDEBE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDEBE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OptDEBE.Location = New System.Drawing.Point(6, 41)
        Me.OptDEBE.Name = "OptDEBE"
        Me.OptDEBE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptDEBE.Size = New System.Drawing.Size(129, 16)
        Me.OptDEBE.TabIndex = 2
        Me.OptDEBE.Text = "Créditos / débitos"
        Me.OptDEBE.UseMnemonic = False
        Me.OptDEBE.UseVisualStyleBackColor = False
        '
        'grpMoneda
        '
        Me.grpMoneda.BackColor = System.Drawing.SystemColors.Control
        Me.grpMoneda.Controls.Add(Me.OptLOCAL)
        Me.grpMoneda.Controls.Add(Me.OptDOLAR)
        Me.grpMoneda.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMoneda.ForeColor = System.Drawing.Color.Black
        Me.grpMoneda.Location = New System.Drawing.Point(186, 27)
        Me.grpMoneda.Name = "grpMoneda"
        Me.grpMoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpMoneda.Size = New System.Drawing.Size(89, 61)
        Me.grpMoneda.TabIndex = 80
        Me.grpMoneda.TabStop = False
        Me.grpMoneda.Text = "Moneda"
        '
        'OptLOCAL
        '
        Me.OptLOCAL.BackColor = System.Drawing.SystemColors.Control
        Me.OptLOCAL.Checked = True
        Me.OptLOCAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptLOCAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLOCAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OptLOCAL.Location = New System.Drawing.Point(6, 19)
        Me.OptLOCAL.Name = "OptLOCAL"
        Me.OptLOCAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptLOCAL.Size = New System.Drawing.Size(57, 16)
        Me.OptLOCAL.TabIndex = 12
        Me.OptLOCAL.TabStop = True
        Me.OptLOCAL.Text = "Local"
        Me.OptLOCAL.UseMnemonic = False
        Me.OptLOCAL.UseVisualStyleBackColor = False
        '
        'OptDOLAR
        '
        Me.OptDOLAR.BackColor = System.Drawing.SystemColors.Control
        Me.OptDOLAR.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptDOLAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDOLAR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OptDOLAR.Location = New System.Drawing.Point(6, 41)
        Me.OptDOLAR.Name = "OptDOLAR"
        Me.OptDOLAR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptDOLAR.Size = New System.Drawing.Size(69, 16)
        Me.OptDOLAR.TabIndex = 13
        Me.OptDOLAR.Text = "Dólares"
        Me.OptDOLAR.UseMnemonic = False
        Me.OptDOLAR.UseVisualStyleBackColor = False
        '
        'grpOrdenamiento
        '
        Me.grpOrdenamiento.BackColor = System.Drawing.SystemColors.Control
        Me.grpOrdenamiento.Controls.Add(Me.OptDEBE)
        Me.grpOrdenamiento.Controls.Add(Me.OptCuenta)
        Me.grpOrdenamiento.Controls.Add(Me.OptSecuencia)
        Me.grpOrdenamiento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrdenamiento.ForeColor = System.Drawing.Color.Black
        Me.grpOrdenamiento.Location = New System.Drawing.Point(281, 27)
        Me.grpOrdenamiento.Name = "grpOrdenamiento"
        Me.grpOrdenamiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpOrdenamiento.Size = New System.Drawing.Size(259, 61)
        Me.grpOrdenamiento.TabIndex = 79
        Me.grpOrdenamiento.TabStop = False
        Me.grpOrdenamiento.Text = "Ordenamiento"
        '
        'BotonLlenar
        '
        Me.BotonLlenar.ImageKey = "Llenar"
        Me.BotonLlenar.ImageList = Me.IconosMenus
        Me.BotonLlenar.LabelMensaje = Me.LabelMensaje
        Me.BotonLlenar.Location = New System.Drawing.Point(48, 43)
        Me.BotonLlenar.Name = "BotonLlenar"
        Me.BotonLlenar.Size = New System.Drawing.Size(40, 40)
        Me.BotonLlenar.TabIndex = 95
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
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 619)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(618, 23)
        Me.LabelMensaje.TabIndex = 91
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelMensaje.UseMnemonic = False
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(108, 43)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 93
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseMnemonic = False
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'BotonConsolida
        '
        Me.BotonConsolida.ImageKey = "(none)"
        Me.BotonConsolida.ImageList = Me.IconosMenus
        Me.BotonConsolida.LabelMensaje = Me.LabelMensaje
        Me.BotonConsolida.Location = New System.Drawing.Point(8, 43)
        Me.BotonConsolida.Name = "BotonConsolida"
        Me.BotonConsolida.Size = New System.Drawing.Size(40, 40)
        Me.BotonConsolida.TabIndex = 92
        Me.BotonConsolida.Texto = "Partidas consolidadoras"
        Me.BotonConsolida.UseMnemonic = False
        Me.BotonConsolida.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(618, 24)
        Me.MenuStrip1.TabIndex = 94
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsolida, Me.mnuLlenar, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuConsolida
        '
        Me.mnuConsolida.Name = "mnuConsolida"
        Me.mnuConsolida.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsolida.Size = New System.Drawing.Size(242, 22)
        Me.mnuConsolida.Text = "Partidas consolidadoras"
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
        'mhTab1
        '
        Me.mhTab1.Controls.Add(Me.TabPage1)
        Me.mhTab1.Controls.Add(Me.TabPage2)
        Me.mhTab1.Location = New System.Drawing.Point(4, 3)
        Me.mhTab1.Name = "mhTab1"
        Me.mhTab1.SelectedIndex = 0
        Me.mhTab1.Size = New System.Drawing.Size(591, 326)
        Me.mhTab1.TabIndex = 96
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Tab1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(583, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Información general (F1)"
        '
        'Tab1
        '
        Me.Tab1.BackColor = System.Drawing.SystemColors.Control
        Me.Tab1.Controls.Add(Me.cboDESCRIPCION)
        Me.Tab1.Controls.Add(Me.lblTitNombre_Tipo)
        Me.Tab1.Controls.Add(Me.lblFECHA_PARTIDA)
        Me.Tab1.Controls.Add(Me.lblTIPO_PARTIDA)
        Me.Tab1.Controls.Add(Me.lblTASA_DE_CAMBIO)
        Me.Tab1.Controls.Add(Me.lblTitFECHA_PARTIDA)
        Me.Tab1.Controls.Add(Me.lblTitTIPO_PARTIDA)
        Me.Tab1.Controls.Add(Me.lblTitTASA_DE_CAMBIO)
        Me.Tab1.Controls.Add(Me.lblDESCRIPCION_EMPRESA)
        Me.Tab1.Controls.Add(Me.lblDESCRIPCION_SUCURSAL)
        Me.Tab1.Controls.Add(Me.lblDESCRIPCION_CENTRO)
        Me.Tab1.Controls.Add(Me._lbldescripcion_origen_1)
        Me.Tab1.Controls.Add(Me._lbldescripcion_origen_2)
        Me.Tab1.Controls.Add(Me._lbldescripcion_origen_3)
        Me.Tab1.Controls.Add(Me._lbldescripcion_origen_4)
        Me.Tab1.Controls.Add(Me._lbldescripcion_origen_5)
        Me.Tab1.Controls.Add(Me._lbldescripcion_origen_6)
        Me.Tab1.Controls.Add(Me.lblNO_PERIODO)
        Me.Tab1.Controls.Add(Me.lblNUMERO_PARTIDA)
        Me.Tab1.Controls.Add(Me.lblANO_PERIODO)
        Me.Tab1.Controls.Add(Me.lblDOCUMENTO_ORIGEN)
        Me.Tab1.Controls.Add(Me.lblID_EMPRESA)
        Me.Tab1.Controls.Add(Me.lblID_SUCURSAL)
        Me.Tab1.Controls.Add(Me.lblID_CENTRO_OPERATIVO)
        Me.Tab1.Controls.Add(Me._lblorigen_4)
        Me.Tab1.Controls.Add(Me._lblorigen_3)
        Me.Tab1.Controls.Add(Me._lblorigen_2)
        Me.Tab1.Controls.Add(Me._lblorigen_1)
        Me.Tab1.Controls.Add(Me._lblorigen_5)
        Me.Tab1.Controls.Add(Me._lblorigen_6)
        Me.Tab1.Controls.Add(Me._lblTitDESCRIPCION_1_0)
        Me.Tab1.Controls.Add(Me.lblTitNUMERO_PARTIDA)
        Me.Tab1.Controls.Add(Me.lblTitNO_PERIODO)
        Me.Tab1.Controls.Add(Me.lblTitDOCUMENTO_ORIGEN)
        Me.Tab1.Controls.Add(Me.lblTitID_EMPRESA)
        Me.Tab1.Controls.Add(Me.lblTitID_SUCURSAL)
        Me.Tab1.Controls.Add(Me.lblTitID_CENTRO_OPERATIVO)
        Me.Tab1.Controls.Add(Me._lbltitORIGEN_4)
        Me.Tab1.Controls.Add(Me._lbltitORIGEN_3)
        Me.Tab1.Controls.Add(Me._lbltitORIGEN_2)
        Me.Tab1.Controls.Add(Me._lbltitORIGEN_1)
        Me.Tab1.Controls.Add(Me._lbltitORIGEN_5)
        Me.Tab1.Controls.Add(Me._lbltitORIGEN_6)
        Me.Tab1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Tab1.Location = New System.Drawing.Point(6, 6)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tab1.Size = New System.Drawing.Size(571, 288)
        Me.Tab1.TabIndex = 35
        Me.Tab1.TabStop = False
        '
        'cboDESCRIPCION
        '
        Me.cboDESCRIPCION.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboDESCRIPCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDESCRIPCION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDESCRIPCION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDESCRIPCION.Location = New System.Drawing.Point(108, 56)
        Me.cboDESCRIPCION.Name = "cboDESCRIPCION"
        Me.cboDESCRIPCION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDESCRIPCION.Size = New System.Drawing.Size(457, 22)
        Me.cboDESCRIPCION.TabIndex = 48
        '
        'lblTitNombre_Tipo
        '
        Me.lblTitNombre_Tipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitNombre_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitNombre_Tipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNombre_Tipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNombre_Tipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNombre_Tipo.Location = New System.Drawing.Point(380, 16)
        Me.lblTitNombre_Tipo.Name = "lblTitNombre_Tipo"
        Me.lblTitNombre_Tipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNombre_Tipo.Size = New System.Drawing.Size(185, 20)
        Me.lblTitNombre_Tipo.TabIndex = 77
        '
        'lblFECHA_PARTIDA
        '
        Me.lblFECHA_PARTIDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFECHA_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_PARTIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_PARTIDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_PARTIDA.Location = New System.Drawing.Point(343, 36)
        Me.lblFECHA_PARTIDA.Name = "lblFECHA_PARTIDA"
        Me.lblFECHA_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_PARTIDA.Size = New System.Drawing.Size(222, 20)
        Me.lblFECHA_PARTIDA.TabIndex = 76
        Me.lblFECHA_PARTIDA.Text = "Fecha Partida"
        Me.lblFECHA_PARTIDA.UseMnemonic = False
        '
        'lblTIPO_PARTIDA
        '
        Me.lblTIPO_PARTIDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTIPO_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTIPO_PARTIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTIPO_PARTIDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIPO_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTIPO_PARTIDA.Location = New System.Drawing.Point(343, 16)
        Me.lblTIPO_PARTIDA.Name = "lblTIPO_PARTIDA"
        Me.lblTIPO_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTIPO_PARTIDA.Size = New System.Drawing.Size(37, 20)
        Me.lblTIPO_PARTIDA.TabIndex = 75
        Me.lblTIPO_PARTIDA.Text = "Tipo de Partida"
        Me.lblTIPO_PARTIDA.UseMnemonic = False
        '
        'lblTASA_DE_CAMBIO
        '
        Me.lblTASA_DE_CAMBIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTASA_DE_CAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTASA_DE_CAMBIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTASA_DE_CAMBIO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTASA_DE_CAMBIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTASA_DE_CAMBIO.Location = New System.Drawing.Point(343, 76)
        Me.lblTASA_DE_CAMBIO.Name = "lblTASA_DE_CAMBIO"
        Me.lblTASA_DE_CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTASA_DE_CAMBIO.Size = New System.Drawing.Size(222, 20)
        Me.lblTASA_DE_CAMBIO.TabIndex = 74
        Me.lblTASA_DE_CAMBIO.Text = "Tasa de Cambio"
        Me.lblTASA_DE_CAMBIO.UseMnemonic = False
        '
        'lblTitFECHA_PARTIDA
        '
        Me.lblTitFECHA_PARTIDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitFECHA_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitFECHA_PARTIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_PARTIDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_PARTIDA.Location = New System.Drawing.Point(238, 36)
        Me.lblTitFECHA_PARTIDA.Name = "lblTitFECHA_PARTIDA"
        Me.lblTitFECHA_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_PARTIDA.Size = New System.Drawing.Size(105, 20)
        Me.lblTitFECHA_PARTIDA.TabIndex = 73
        Me.lblTitFECHA_PARTIDA.Text = "Fecha partida"
        Me.lblTitFECHA_PARTIDA.UseMnemonic = False
        '
        'lblTitTIPO_PARTIDA
        '
        Me.lblTitTIPO_PARTIDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitTIPO_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitTIPO_PARTIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_PARTIDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_PARTIDA.Location = New System.Drawing.Point(238, 16)
        Me.lblTitTIPO_PARTIDA.Name = "lblTitTIPO_PARTIDA"
        Me.lblTitTIPO_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_PARTIDA.Size = New System.Drawing.Size(105, 20)
        Me.lblTitTIPO_PARTIDA.TabIndex = 72
        Me.lblTitTIPO_PARTIDA.Text = "Tipo de partida"
        Me.lblTitTIPO_PARTIDA.UseMnemonic = False
        '
        'lblTitTASA_DE_CAMBIO
        '
        Me.lblTitTASA_DE_CAMBIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitTASA_DE_CAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitTASA_DE_CAMBIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_DE_CAMBIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_DE_CAMBIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_DE_CAMBIO.Location = New System.Drawing.Point(238, 76)
        Me.lblTitTASA_DE_CAMBIO.Name = "lblTitTASA_DE_CAMBIO"
        Me.lblTitTASA_DE_CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_DE_CAMBIO.Size = New System.Drawing.Size(105, 20)
        Me.lblTitTASA_DE_CAMBIO.TabIndex = 71
        Me.lblTitTASA_DE_CAMBIO.Text = "Tasa de cambio"
        Me.lblTitTASA_DE_CAMBIO.UseMnemonic = False
        '
        'lblDESCRIPCION_EMPRESA
        '
        Me.lblDESCRIPCION_EMPRESA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDESCRIPCION_EMPRESA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDESCRIPCION_EMPRESA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_EMPRESA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_EMPRESA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_EMPRESA.Location = New System.Drawing.Point(238, 216)
        Me.lblDESCRIPCION_EMPRESA.Name = "lblDESCRIPCION_EMPRESA"
        Me.lblDESCRIPCION_EMPRESA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_EMPRESA.Size = New System.Drawing.Size(327, 20)
        Me.lblDESCRIPCION_EMPRESA.TabIndex = 70
        '
        'lblDESCRIPCION_SUCURSAL
        '
        Me.lblDESCRIPCION_SUCURSAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDESCRIPCION_SUCURSAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDESCRIPCION_SUCURSAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_SUCURSAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_SUCURSAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_SUCURSAL.Location = New System.Drawing.Point(238, 236)
        Me.lblDESCRIPCION_SUCURSAL.Name = "lblDESCRIPCION_SUCURSAL"
        Me.lblDESCRIPCION_SUCURSAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_SUCURSAL.Size = New System.Drawing.Size(327, 20)
        Me.lblDESCRIPCION_SUCURSAL.TabIndex = 69
        '
        'lblDESCRIPCION_CENTRO
        '
        Me.lblDESCRIPCION_CENTRO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDESCRIPCION_CENTRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDESCRIPCION_CENTRO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_CENTRO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_CENTRO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_CENTRO.Location = New System.Drawing.Point(238, 256)
        Me.lblDESCRIPCION_CENTRO.Name = "lblDESCRIPCION_CENTRO"
        Me.lblDESCRIPCION_CENTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_CENTRO.Size = New System.Drawing.Size(327, 20)
        Me.lblDESCRIPCION_CENTRO.TabIndex = 68
        '
        '_lbldescripcion_origen_1
        '
        Me._lbldescripcion_origen_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbldescripcion_origen_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbldescripcion_origen_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbldescripcion_origen_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbldescripcion_origen_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbldescripcion_origen_1.Location = New System.Drawing.Point(238, 96)
        Me._lbldescripcion_origen_1.Name = "_lbldescripcion_origen_1"
        Me._lbldescripcion_origen_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbldescripcion_origen_1.Size = New System.Drawing.Size(327, 20)
        Me._lbldescripcion_origen_1.TabIndex = 67
        '
        '_lbldescripcion_origen_2
        '
        Me._lbldescripcion_origen_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbldescripcion_origen_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbldescripcion_origen_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbldescripcion_origen_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbldescripcion_origen_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbldescripcion_origen_2.Location = New System.Drawing.Point(238, 116)
        Me._lbldescripcion_origen_2.Name = "_lbldescripcion_origen_2"
        Me._lbldescripcion_origen_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbldescripcion_origen_2.Size = New System.Drawing.Size(327, 20)
        Me._lbldescripcion_origen_2.TabIndex = 66
        '
        '_lbldescripcion_origen_3
        '
        Me._lbldescripcion_origen_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbldescripcion_origen_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbldescripcion_origen_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbldescripcion_origen_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbldescripcion_origen_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbldescripcion_origen_3.Location = New System.Drawing.Point(238, 136)
        Me._lbldescripcion_origen_3.Name = "_lbldescripcion_origen_3"
        Me._lbldescripcion_origen_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbldescripcion_origen_3.Size = New System.Drawing.Size(327, 20)
        Me._lbldescripcion_origen_3.TabIndex = 65
        '
        '_lbldescripcion_origen_4
        '
        Me._lbldescripcion_origen_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbldescripcion_origen_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbldescripcion_origen_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbldescripcion_origen_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbldescripcion_origen_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbldescripcion_origen_4.Location = New System.Drawing.Point(238, 156)
        Me._lbldescripcion_origen_4.Name = "_lbldescripcion_origen_4"
        Me._lbldescripcion_origen_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbldescripcion_origen_4.Size = New System.Drawing.Size(327, 20)
        Me._lbldescripcion_origen_4.TabIndex = 64
        '
        '_lbldescripcion_origen_5
        '
        Me._lbldescripcion_origen_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbldescripcion_origen_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbldescripcion_origen_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbldescripcion_origen_5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbldescripcion_origen_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbldescripcion_origen_5.Location = New System.Drawing.Point(238, 176)
        Me._lbldescripcion_origen_5.Name = "_lbldescripcion_origen_5"
        Me._lbldescripcion_origen_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbldescripcion_origen_5.Size = New System.Drawing.Size(327, 20)
        Me._lbldescripcion_origen_5.TabIndex = 63
        '
        '_lbldescripcion_origen_6
        '
        Me._lbldescripcion_origen_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbldescripcion_origen_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbldescripcion_origen_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbldescripcion_origen_6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbldescripcion_origen_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbldescripcion_origen_6.Location = New System.Drawing.Point(238, 196)
        Me._lbldescripcion_origen_6.Name = "_lbldescripcion_origen_6"
        Me._lbldescripcion_origen_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbldescripcion_origen_6.Size = New System.Drawing.Size(327, 20)
        Me._lbldescripcion_origen_6.TabIndex = 62
        '
        'lblNO_PERIODO
        '
        Me.lblNO_PERIODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNO_PERIODO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNO_PERIODO.Location = New System.Drawing.Point(173, 16)
        Me.lblNO_PERIODO.Name = "lblNO_PERIODO"
        Me.lblNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNO_PERIODO.Size = New System.Drawing.Size(65, 20)
        Me.lblNO_PERIODO.TabIndex = 61
        Me.lblNO_PERIODO.Text = "Periodo"
        Me.lblNO_PERIODO.UseMnemonic = False
        '
        'lblNUMERO_PARTIDA
        '
        Me.lblNUMERO_PARTIDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNUMERO_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNUMERO_PARTIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNUMERO_PARTIDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUMERO_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNUMERO_PARTIDA.Location = New System.Drawing.Point(108, 36)
        Me.lblNUMERO_PARTIDA.Name = "lblNUMERO_PARTIDA"
        Me.lblNUMERO_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNUMERO_PARTIDA.Size = New System.Drawing.Size(130, 20)
        Me.lblNUMERO_PARTIDA.TabIndex = 60
        Me.lblNUMERO_PARTIDA.Text = "No. Partida"
        Me.lblNUMERO_PARTIDA.UseMnemonic = False
        '
        'lblANO_PERIODO
        '
        Me.lblANO_PERIODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblANO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblANO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblANO_PERIODO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblANO_PERIODO.Location = New System.Drawing.Point(108, 16)
        Me.lblANO_PERIODO.Name = "lblANO_PERIODO"
        Me.lblANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblANO_PERIODO.Size = New System.Drawing.Size(65, 20)
        Me.lblANO_PERIODO.TabIndex = 59
        Me.lblANO_PERIODO.Text = "Año"
        Me.lblANO_PERIODO.UseMnemonic = False
        '
        'lblDOCUMENTO_ORIGEN
        '
        Me.lblDOCUMENTO_ORIGEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDOCUMENTO_ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDOCUMENTO_ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDOCUMENTO_ORIGEN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOCUMENTO_ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDOCUMENTO_ORIGEN.Location = New System.Drawing.Point(108, 76)
        Me.lblDOCUMENTO_ORIGEN.Name = "lblDOCUMENTO_ORIGEN"
        Me.lblDOCUMENTO_ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDOCUMENTO_ORIGEN.Size = New System.Drawing.Size(130, 20)
        Me.lblDOCUMENTO_ORIGEN.TabIndex = 58
        Me.lblDOCUMENTO_ORIGEN.Text = "Documento Ori"
        Me.lblDOCUMENTO_ORIGEN.UseMnemonic = False
        '
        'lblID_EMPRESA
        '
        Me.lblID_EMPRESA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblID_EMPRESA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID_EMPRESA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblID_EMPRESA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_EMPRESA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblID_EMPRESA.Location = New System.Drawing.Point(108, 216)
        Me.lblID_EMPRESA.Name = "lblID_EMPRESA"
        Me.lblID_EMPRESA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblID_EMPRESA.Size = New System.Drawing.Size(130, 20)
        Me.lblID_EMPRESA.TabIndex = 57
        Me.lblID_EMPRESA.Text = "Empresa"
        Me.lblID_EMPRESA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblID_EMPRESA.UseMnemonic = False
        '
        'lblID_SUCURSAL
        '
        Me.lblID_SUCURSAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblID_SUCURSAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID_SUCURSAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblID_SUCURSAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_SUCURSAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblID_SUCURSAL.Location = New System.Drawing.Point(108, 236)
        Me.lblID_SUCURSAL.Name = "lblID_SUCURSAL"
        Me.lblID_SUCURSAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblID_SUCURSAL.Size = New System.Drawing.Size(130, 20)
        Me.lblID_SUCURSAL.TabIndex = 56
        Me.lblID_SUCURSAL.Text = "Sucursal"
        Me.lblID_SUCURSAL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblID_SUCURSAL.UseMnemonic = False
        '
        'lblID_CENTRO_OPERATIVO
        '
        Me.lblID_CENTRO_OPERATIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblID_CENTRO_OPERATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID_CENTRO_OPERATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblID_CENTRO_OPERATIVO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_CENTRO_OPERATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblID_CENTRO_OPERATIVO.Location = New System.Drawing.Point(108, 256)
        Me.lblID_CENTRO_OPERATIVO.Name = "lblID_CENTRO_OPERATIVO"
        Me.lblID_CENTRO_OPERATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblID_CENTRO_OPERATIVO.Size = New System.Drawing.Size(130, 20)
        Me.lblID_CENTRO_OPERATIVO.TabIndex = 55
        Me.lblID_CENTRO_OPERATIVO.Text = "Centro"
        Me.lblID_CENTRO_OPERATIVO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblID_CENTRO_OPERATIVO.UseMnemonic = False
        '
        '_lblorigen_4
        '
        Me._lblorigen_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lblorigen_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblorigen_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblorigen_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblorigen_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblorigen_4.Location = New System.Drawing.Point(108, 156)
        Me._lblorigen_4.Name = "_lblorigen_4"
        Me._lblorigen_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblorigen_4.Size = New System.Drawing.Size(130, 20)
        Me._lblorigen_4.TabIndex = 54
        Me._lblorigen_4.Text = "codigo origen4"
        Me._lblorigen_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._lblorigen_4.UseMnemonic = False
        '
        '_lblorigen_3
        '
        Me._lblorigen_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lblorigen_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblorigen_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblorigen_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblorigen_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblorigen_3.Location = New System.Drawing.Point(108, 136)
        Me._lblorigen_3.Name = "_lblorigen_3"
        Me._lblorigen_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblorigen_3.Size = New System.Drawing.Size(130, 20)
        Me._lblorigen_3.TabIndex = 53
        Me._lblorigen_3.Text = "codigo origen3"
        Me._lblorigen_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._lblorigen_3.UseMnemonic = False
        '
        '_lblorigen_2
        '
        Me._lblorigen_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lblorigen_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblorigen_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblorigen_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblorigen_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblorigen_2.Location = New System.Drawing.Point(108, 116)
        Me._lblorigen_2.Name = "_lblorigen_2"
        Me._lblorigen_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblorigen_2.Size = New System.Drawing.Size(130, 20)
        Me._lblorigen_2.TabIndex = 52
        Me._lblorigen_2.Text = "codigo origen 2"
        Me._lblorigen_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._lblorigen_2.UseMnemonic = False
        '
        '_lblorigen_1
        '
        Me._lblorigen_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lblorigen_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblorigen_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblorigen_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblorigen_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblorigen_1.Location = New System.Drawing.Point(108, 96)
        Me._lblorigen_1.Name = "_lblorigen_1"
        Me._lblorigen_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblorigen_1.Size = New System.Drawing.Size(130, 20)
        Me._lblorigen_1.TabIndex = 51
        Me._lblorigen_1.Text = "codigo origen1"
        Me._lblorigen_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._lblorigen_1.UseMnemonic = False
        '
        '_lblorigen_5
        '
        Me._lblorigen_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lblorigen_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblorigen_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblorigen_5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblorigen_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblorigen_5.Location = New System.Drawing.Point(108, 176)
        Me._lblorigen_5.Name = "_lblorigen_5"
        Me._lblorigen_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblorigen_5.Size = New System.Drawing.Size(130, 20)
        Me._lblorigen_5.TabIndex = 50
        Me._lblorigen_5.Text = "codigo origen5"
        Me._lblorigen_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._lblorigen_5.UseMnemonic = False
        '
        '_lblorigen_6
        '
        Me._lblorigen_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lblorigen_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblorigen_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblorigen_6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblorigen_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblorigen_6.Location = New System.Drawing.Point(108, 196)
        Me._lblorigen_6.Name = "_lblorigen_6"
        Me._lblorigen_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblorigen_6.Size = New System.Drawing.Size(130, 20)
        Me._lblorigen_6.TabIndex = 49
        Me._lblorigen_6.Text = "codigo origen6"
        Me._lblorigen_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me._lblorigen_6.UseMnemonic = False
        '
        '_lblTitDESCRIPCION_1_0
        '
        Me._lblTitDESCRIPCION_1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lblTitDESCRIPCION_1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblTitDESCRIPCION_1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblTitDESCRIPCION_1_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblTitDESCRIPCION_1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblTitDESCRIPCION_1_0.Location = New System.Drawing.Point(6, 56)
        Me._lblTitDESCRIPCION_1_0.Name = "_lblTitDESCRIPCION_1_0"
        Me._lblTitDESCRIPCION_1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblTitDESCRIPCION_1_0.Size = New System.Drawing.Size(102, 20)
        Me._lblTitDESCRIPCION_1_0.TabIndex = 47
        Me._lblTitDESCRIPCION_1_0.Text = "Descripción"
        Me._lblTitDESCRIPCION_1_0.UseMnemonic = False
        '
        'lblTitNUMERO_PARTIDA
        '
        Me.lblTitNUMERO_PARTIDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitNUMERO_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitNUMERO_PARTIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_PARTIDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_PARTIDA.Location = New System.Drawing.Point(6, 36)
        Me.lblTitNUMERO_PARTIDA.Name = "lblTitNUMERO_PARTIDA"
        Me.lblTitNUMERO_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_PARTIDA.Size = New System.Drawing.Size(102, 20)
        Me.lblTitNUMERO_PARTIDA.TabIndex = 46
        Me.lblTitNUMERO_PARTIDA.Text = "No. de partida"
        Me.lblTitNUMERO_PARTIDA.UseMnemonic = False
        '
        'lblTitNO_PERIODO
        '
        Me.lblTitNO_PERIODO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitNO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitNO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_PERIODO.Location = New System.Drawing.Point(6, 16)
        Me.lblTitNO_PERIODO.Name = "lblTitNO_PERIODO"
        Me.lblTitNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_PERIODO.Size = New System.Drawing.Size(102, 20)
        Me.lblTitNO_PERIODO.TabIndex = 45
        Me.lblTitNO_PERIODO.Text = "Periodo"
        Me.lblTitNO_PERIODO.UseMnemonic = False
        '
        'lblTitDOCUMENTO_ORIGEN
        '
        Me.lblTitDOCUMENTO_ORIGEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitDOCUMENTO_ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitDOCUMENTO_ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDOCUMENTO_ORIGEN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDOCUMENTO_ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDOCUMENTO_ORIGEN.Location = New System.Drawing.Point(6, 76)
        Me.lblTitDOCUMENTO_ORIGEN.Name = "lblTitDOCUMENTO_ORIGEN"
        Me.lblTitDOCUMENTO_ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDOCUMENTO_ORIGEN.Size = New System.Drawing.Size(102, 20)
        Me.lblTitDOCUMENTO_ORIGEN.TabIndex = 44
        Me.lblTitDOCUMENTO_ORIGEN.Text = "Documento origen"
        Me.lblTitDOCUMENTO_ORIGEN.UseMnemonic = False
        '
        'lblTitID_EMPRESA
        '
        Me.lblTitID_EMPRESA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitID_EMPRESA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitID_EMPRESA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitID_EMPRESA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitID_EMPRESA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitID_EMPRESA.Location = New System.Drawing.Point(6, 216)
        Me.lblTitID_EMPRESA.Name = "lblTitID_EMPRESA"
        Me.lblTitID_EMPRESA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitID_EMPRESA.Size = New System.Drawing.Size(102, 20)
        Me.lblTitID_EMPRESA.TabIndex = 43
        Me.lblTitID_EMPRESA.Text = "Empresa"
        Me.lblTitID_EMPRESA.UseMnemonic = False
        '
        'lblTitID_SUCURSAL
        '
        Me.lblTitID_SUCURSAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitID_SUCURSAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitID_SUCURSAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitID_SUCURSAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitID_SUCURSAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitID_SUCURSAL.Location = New System.Drawing.Point(6, 236)
        Me.lblTitID_SUCURSAL.Name = "lblTitID_SUCURSAL"
        Me.lblTitID_SUCURSAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitID_SUCURSAL.Size = New System.Drawing.Size(102, 20)
        Me.lblTitID_SUCURSAL.TabIndex = 42
        Me.lblTitID_SUCURSAL.Text = "Sucursal"
        Me.lblTitID_SUCURSAL.UseMnemonic = False
        '
        'lblTitID_CENTRO_OPERATIVO
        '
        Me.lblTitID_CENTRO_OPERATIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitID_CENTRO_OPERATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitID_CENTRO_OPERATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitID_CENTRO_OPERATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitID_CENTRO_OPERATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitID_CENTRO_OPERATIVO.Location = New System.Drawing.Point(6, 256)
        Me.lblTitID_CENTRO_OPERATIVO.Name = "lblTitID_CENTRO_OPERATIVO"
        Me.lblTitID_CENTRO_OPERATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitID_CENTRO_OPERATIVO.Size = New System.Drawing.Size(102, 20)
        Me.lblTitID_CENTRO_OPERATIVO.TabIndex = 41
        Me.lblTitID_CENTRO_OPERATIVO.Text = "Centro"
        Me.lblTitID_CENTRO_OPERATIVO.UseMnemonic = False
        '
        '_lbltitORIGEN_4
        '
        Me._lbltitORIGEN_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbltitORIGEN_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbltitORIGEN_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbltitORIGEN_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbltitORIGEN_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbltitORIGEN_4.Location = New System.Drawing.Point(6, 156)
        Me._lbltitORIGEN_4.Name = "_lbltitORIGEN_4"
        Me._lbltitORIGEN_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbltitORIGEN_4.Size = New System.Drawing.Size(102, 20)
        Me._lbltitORIGEN_4.TabIndex = 40
        Me._lbltitORIGEN_4.Text = "Origen4"
        Me._lbltitORIGEN_4.UseMnemonic = False
        '
        '_lbltitORIGEN_3
        '
        Me._lbltitORIGEN_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbltitORIGEN_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbltitORIGEN_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbltitORIGEN_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbltitORIGEN_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbltitORIGEN_3.Location = New System.Drawing.Point(6, 136)
        Me._lbltitORIGEN_3.Name = "_lbltitORIGEN_3"
        Me._lbltitORIGEN_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbltitORIGEN_3.Size = New System.Drawing.Size(102, 20)
        Me._lbltitORIGEN_3.TabIndex = 39
        Me._lbltitORIGEN_3.Text = "Origen3"
        Me._lbltitORIGEN_3.UseMnemonic = False
        '
        '_lbltitORIGEN_2
        '
        Me._lbltitORIGEN_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbltitORIGEN_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbltitORIGEN_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbltitORIGEN_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbltitORIGEN_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbltitORIGEN_2.Location = New System.Drawing.Point(6, 116)
        Me._lbltitORIGEN_2.Name = "_lbltitORIGEN_2"
        Me._lbltitORIGEN_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbltitORIGEN_2.Size = New System.Drawing.Size(102, 20)
        Me._lbltitORIGEN_2.TabIndex = 38
        Me._lbltitORIGEN_2.Text = "Origen2"
        Me._lbltitORIGEN_2.UseMnemonic = False
        '
        '_lbltitORIGEN_1
        '
        Me._lbltitORIGEN_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbltitORIGEN_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbltitORIGEN_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbltitORIGEN_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbltitORIGEN_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbltitORIGEN_1.Location = New System.Drawing.Point(6, 96)
        Me._lbltitORIGEN_1.Name = "_lbltitORIGEN_1"
        Me._lbltitORIGEN_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbltitORIGEN_1.Size = New System.Drawing.Size(102, 20)
        Me._lbltitORIGEN_1.TabIndex = 37
        Me._lbltitORIGEN_1.Text = "Origen1"
        Me._lbltitORIGEN_1.UseMnemonic = False
        '
        '_lbltitORIGEN_5
        '
        Me._lbltitORIGEN_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbltitORIGEN_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbltitORIGEN_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbltitORIGEN_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbltitORIGEN_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbltitORIGEN_5.Location = New System.Drawing.Point(6, 176)
        Me._lbltitORIGEN_5.Name = "_lbltitORIGEN_5"
        Me._lbltitORIGEN_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbltitORIGEN_5.Size = New System.Drawing.Size(102, 20)
        Me._lbltitORIGEN_5.TabIndex = 36
        Me._lbltitORIGEN_5.Text = "Origen5"
        Me._lbltitORIGEN_5.UseMnemonic = False
        '
        '_lbltitORIGEN_6
        '
        Me._lbltitORIGEN_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._lbltitORIGEN_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lbltitORIGEN_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbltitORIGEN_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbltitORIGEN_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lbltitORIGEN_6.Location = New System.Drawing.Point(6, 196)
        Me._lbltitORIGEN_6.Name = "_lbltitORIGEN_6"
        Me._lbltitORIGEN_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbltitORIGEN_6.Size = New System.Drawing.Size(102, 20)
        Me._lbltitORIGEN_6.TabIndex = 35
        Me._lbltitORIGEN_6.Text = "Origen6"
        Me._lbltitORIGEN_6.UseMnemonic = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Frame2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(583, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos de auditoría (F2)"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.lblTitCODIGO_MODULO)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.lblTitREFERENCIA_1)
        Me.Frame2.Controls.Add(Me.lblPARTIDA_ORIGEN)
        Me.Frame2.Controls.Add(Me.lblUSUARIO_INGRESO)
        Me.Frame2.Controls.Add(Me.lblTitUSUARIO_INGRESO)
        Me.Frame2.Controls.Add(Me.lblTitFECHA_MAYORIZACION)
        Me.Frame2.Controls.Add(Me.lblCODIGO_MODULO)
        Me.Frame2.Controls.Add(Me.lblTOTALES)
        Me.Frame2.Controls.Add(Me.lblREFERENCIA_1)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.lblFECHA_INGRESO)
        Me.Frame2.Controls.Add(Me.lblTitCodigo_razon)
        Me.Frame2.Controls.Add(Me.lblTitREFERENCIA_2)
        Me.Frame2.Controls.Add(Me.lblCodigo_razon)
        Me.Frame2.Controls.Add(Me.lblDES_RAZON)
        Me.Frame2.Controls.Add(Me.lblREFERENCIA_2)
        Me.Frame2.Controls.Add(Me.lblUSUARIO_AUTORIZO)
        Me.Frame2.Controls.Add(Me.lblFECHA_AUTORIZO)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(6, 6)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(571, 160)
        Me.Frame2.TabIndex = 91
        Me.Frame2.TabStop = False
        '
        'lblTitCODIGO_MODULO
        '
        Me.lblTitCODIGO_MODULO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitCODIGO_MODULO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitCODIGO_MODULO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_MODULO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_MODULO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_MODULO.Location = New System.Drawing.Point(6, 16)
        Me.lblTitCODIGO_MODULO.Name = "lblTitCODIGO_MODULO"
        Me.lblTitCODIGO_MODULO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_MODULO.Size = New System.Drawing.Size(140, 20)
        Me.lblTitCODIGO_MODULO.TabIndex = 3
        Me.lblTitCODIGO_MODULO.Text = "Módulo que genero partida"
        Me.lblTitCODIGO_MODULO.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total cargos / abonos"
        Me.Label3.UseMnemonic = False
        '
        'lblTitREFERENCIA_1
        '
        Me.lblTitREFERENCIA_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitREFERENCIA_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitREFERENCIA_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitREFERENCIA_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitREFERENCIA_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitREFERENCIA_1.Location = New System.Drawing.Point(6, 56)
        Me.lblTitREFERENCIA_1.Name = "lblTitREFERENCIA_1"
        Me.lblTitREFERENCIA_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitREFERENCIA_1.Size = New System.Drawing.Size(140, 20)
        Me.lblTitREFERENCIA_1.TabIndex = 7
        Me.lblTitREFERENCIA_1.Text = "Referencia 1"
        Me.lblTitREFERENCIA_1.UseMnemonic = False
        '
        'lblPARTIDA_ORIGEN
        '
        Me.lblPARTIDA_ORIGEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPARTIDA_ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPARTIDA_ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPARTIDA_ORIGEN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPARTIDA_ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPARTIDA_ORIGEN.Location = New System.Drawing.Point(6, 76)
        Me.lblPARTIDA_ORIGEN.Name = "lblPARTIDA_ORIGEN"
        Me.lblPARTIDA_ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPARTIDA_ORIGEN.Size = New System.Drawing.Size(140, 20)
        Me.lblPARTIDA_ORIGEN.TabIndex = 11
        Me.lblPARTIDA_ORIGEN.UseMnemonic = False
        '
        'lblUSUARIO_INGRESO
        '
        Me.lblUSUARIO_INGRESO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUSUARIO_INGRESO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUSUARIO_INGRESO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUSUARIO_INGRESO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIO_INGRESO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUSUARIO_INGRESO.Location = New System.Drawing.Point(146, 96)
        Me.lblUSUARIO_INGRESO.Name = "lblUSUARIO_INGRESO"
        Me.lblUSUARIO_INGRESO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUSUARIO_INGRESO.Size = New System.Drawing.Size(198, 20)
        Me.lblUSUARIO_INGRESO.TabIndex = 14
        Me.lblUSUARIO_INGRESO.Text = "Usuario Ingreso"
        Me.lblUSUARIO_INGRESO.UseMnemonic = False
        '
        'lblTitUSUARIO_INGRESO
        '
        Me.lblTitUSUARIO_INGRESO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitUSUARIO_INGRESO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitUSUARIO_INGRESO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitUSUARIO_INGRESO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitUSUARIO_INGRESO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitUSUARIO_INGRESO.Location = New System.Drawing.Point(6, 96)
        Me.lblTitUSUARIO_INGRESO.Name = "lblTitUSUARIO_INGRESO"
        Me.lblTitUSUARIO_INGRESO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitUSUARIO_INGRESO.Size = New System.Drawing.Size(140, 20)
        Me.lblTitUSUARIO_INGRESO.TabIndex = 15
        Me.lblTitUSUARIO_INGRESO.Text = "Usuario "
        Me.lblTitUSUARIO_INGRESO.UseMnemonic = False
        '
        'lblTitFECHA_MAYORIZACION
        '
        Me.lblTitFECHA_MAYORIZACION.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitFECHA_MAYORIZACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitFECHA_MAYORIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_MAYORIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_MAYORIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_MAYORIZACION.Location = New System.Drawing.Point(6, 116)
        Me.lblTitFECHA_MAYORIZACION.Name = "lblTitFECHA_MAYORIZACION"
        Me.lblTitFECHA_MAYORIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_MAYORIZACION.Size = New System.Drawing.Size(140, 20)
        Me.lblTitFECHA_MAYORIZACION.TabIndex = 91
        Me.lblTitFECHA_MAYORIZACION.Text = "Fecha"
        Me.lblTitFECHA_MAYORIZACION.UseMnemonic = False
        '
        'lblCODIGO_MODULO
        '
        Me.lblCODIGO_MODULO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCODIGO_MODULO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_MODULO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_MODULO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_MODULO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_MODULO.Location = New System.Drawing.Point(146, 16)
        Me.lblCODIGO_MODULO.Name = "lblCODIGO_MODULO"
        Me.lblCODIGO_MODULO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_MODULO.Size = New System.Drawing.Size(99, 20)
        Me.lblCODIGO_MODULO.TabIndex = 90
        Me.lblCODIGO_MODULO.Text = "Modulo"
        Me.lblCODIGO_MODULO.UseMnemonic = False
        '
        'lblTOTALES
        '
        Me.lblTOTALES.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTOTALES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTOTALES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTOTALES.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOTALES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTOTALES.Location = New System.Drawing.Point(146, 36)
        Me.lblTOTALES.Name = "lblTOTALES"
        Me.lblTOTALES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTOTALES.Size = New System.Drawing.Size(419, 20)
        Me.lblTOTALES.TabIndex = 89
        Me.lblTOTALES.Text = "Totales"
        Me.lblTOTALES.UseMnemonic = False
        '
        'lblREFERENCIA_1
        '
        Me.lblREFERENCIA_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblREFERENCIA_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblREFERENCIA_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblREFERENCIA_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREFERENCIA_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblREFERENCIA_1.Location = New System.Drawing.Point(146, 56)
        Me.lblREFERENCIA_1.Name = "lblREFERENCIA_1"
        Me.lblREFERENCIA_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblREFERENCIA_1.Size = New System.Drawing.Size(99, 20)
        Me.lblREFERENCIA_1.TabIndex = 88
        Me.lblREFERENCIA_1.Text = "Referencia 1"
        Me.lblREFERENCIA_1.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(146, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(419, 20)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "                 INGRESO                /                AUTORIZO"
        Me.Label2.UseMnemonic = False
        '
        'lblFECHA_INGRESO
        '
        Me.lblFECHA_INGRESO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFECHA_INGRESO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_INGRESO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_INGRESO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_INGRESO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_INGRESO.Location = New System.Drawing.Point(146, 116)
        Me.lblFECHA_INGRESO.Name = "lblFECHA_INGRESO"
        Me.lblFECHA_INGRESO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_INGRESO.Size = New System.Drawing.Size(198, 20)
        Me.lblFECHA_INGRESO.TabIndex = 86
        Me.lblFECHA_INGRESO.Text = "Fecha Ingreso"
        Me.lblFECHA_INGRESO.UseMnemonic = False
        '
        'lblTitCodigo_razon
        '
        Me.lblTitCodigo_razon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitCodigo_razon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitCodigo_razon.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCodigo_razon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCodigo_razon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCodigo_razon.Location = New System.Drawing.Point(245, 16)
        Me.lblTitCodigo_razon.Name = "lblTitCodigo_razon"
        Me.lblTitCodigo_razon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCodigo_razon.Size = New System.Drawing.Size(99, 20)
        Me.lblTitCodigo_razon.TabIndex = 85
        Me.lblTitCodigo_razon.Text = "Codigo de razón"
        Me.lblTitCodigo_razon.UseMnemonic = False
        '
        'lblTitREFERENCIA_2
        '
        Me.lblTitREFERENCIA_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitREFERENCIA_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitREFERENCIA_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitREFERENCIA_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitREFERENCIA_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitREFERENCIA_2.Location = New System.Drawing.Point(245, 56)
        Me.lblTitREFERENCIA_2.Name = "lblTitREFERENCIA_2"
        Me.lblTitREFERENCIA_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitREFERENCIA_2.Size = New System.Drawing.Size(99, 20)
        Me.lblTitREFERENCIA_2.TabIndex = 84
        Me.lblTitREFERENCIA_2.Text = "Referencia 2"
        Me.lblTitREFERENCIA_2.UseMnemonic = False
        '
        'lblCodigo_razon
        '
        Me.lblCodigo_razon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodigo_razon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigo_razon.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigo_razon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo_razon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigo_razon.Location = New System.Drawing.Point(344, 16)
        Me.lblCodigo_razon.Name = "lblCodigo_razon"
        Me.lblCodigo_razon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigo_razon.Size = New System.Drawing.Size(47, 20)
        Me.lblCodigo_razon.TabIndex = 83
        Me.lblCodigo_razon.Text = "Raz"
        Me.lblCodigo_razon.UseMnemonic = False
        '
        'lblDES_RAZON
        '
        Me.lblDES_RAZON.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDES_RAZON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDES_RAZON.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDES_RAZON.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDES_RAZON.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDES_RAZON.Location = New System.Drawing.Point(391, 16)
        Me.lblDES_RAZON.Name = "lblDES_RAZON"
        Me.lblDES_RAZON.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDES_RAZON.Size = New System.Drawing.Size(174, 20)
        Me.lblDES_RAZON.TabIndex = 82
        Me.lblDES_RAZON.UseMnemonic = False
        '
        'lblREFERENCIA_2
        '
        Me.lblREFERENCIA_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblREFERENCIA_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblREFERENCIA_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblREFERENCIA_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREFERENCIA_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblREFERENCIA_2.Location = New System.Drawing.Point(344, 56)
        Me.lblREFERENCIA_2.Name = "lblREFERENCIA_2"
        Me.lblREFERENCIA_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblREFERENCIA_2.Size = New System.Drawing.Size(221, 20)
        Me.lblREFERENCIA_2.TabIndex = 81
        Me.lblREFERENCIA_2.Text = "Referencia 2"
        Me.lblREFERENCIA_2.UseMnemonic = False
        '
        'lblUSUARIO_AUTORIZO
        '
        Me.lblUSUARIO_AUTORIZO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUSUARIO_AUTORIZO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUSUARIO_AUTORIZO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUSUARIO_AUTORIZO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIO_AUTORIZO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUSUARIO_AUTORIZO.Location = New System.Drawing.Point(344, 96)
        Me.lblUSUARIO_AUTORIZO.Name = "lblUSUARIO_AUTORIZO"
        Me.lblUSUARIO_AUTORIZO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUSUARIO_AUTORIZO.Size = New System.Drawing.Size(221, 20)
        Me.lblUSUARIO_AUTORIZO.TabIndex = 80
        Me.lblUSUARIO_AUTORIZO.Text = "Usuario Autorizo"
        Me.lblUSUARIO_AUTORIZO.UseMnemonic = False
        '
        'lblFECHA_AUTORIZO
        '
        Me.lblFECHA_AUTORIZO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFECHA_AUTORIZO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_AUTORIZO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_AUTORIZO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_AUTORIZO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_AUTORIZO.Location = New System.Drawing.Point(344, 116)
        Me.lblFECHA_AUTORIZO.Name = "lblFECHA_AUTORIZO"
        Me.lblFECHA_AUTORIZO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_AUTORIZO.Size = New System.Drawing.Size(221, 20)
        Me.lblFECHA_AUTORIZO.TabIndex = 79
        Me.lblFECHA_AUTORIZO.Text = "Fecha Autorizo"
        Me.lblFECHA_AUTORIZO.UseMnemonic = False
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.mhTab1)
        Me.Encabezado.Location = New System.Drawing.Point(8, 91)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(598, 332)
        Me.Encabezado.TabIndex = 97
        '
        'PATRAC01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BotonAgregar = Me.BotonConsolida
        Me.BotonDeLlenado = Me.BotonLlenar
        Me.BotonSalir = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(618, 642)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.BotonLlenar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.BotonConsolida)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.lblAVISO)
        Me.Controls.Add(Me.grpMoneda)
        Me.Controls.Add(Me.grpOrdenamiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.MenuDeLlenado = Me.mnuLlenar
        Me.Name = "PATRAC01"
        Me.PanelEncabezado = Me.Encabezado
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de partidas de trabajo - PATRAC01"
        Me.Controls.SetChildIndex(Me.grpOrdenamiento, 0)
        Me.Controls.SetChildIndex(Me.grpMoneda, 0)
        Me.Controls.SetChildIndex(Me.lblAVISO, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.BotonConsolida, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.BotonLlenar, 0)
        Me.Controls.SetChildIndex(Me.Encabezado, 0)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMoneda.ResumeLayout(False)
        Me.grpOrdenamiento.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mhTab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents OptCuenta As System.Windows.Forms.RadioButton
    Public WithEvents OptSecuencia As System.Windows.Forms.RadioButton
    Public WithEvents lblAVISO As System.Windows.Forms.Label
    Public WithEvents OptDEBE As System.Windows.Forms.RadioButton
    Public WithEvents grpMoneda As System.Windows.Forms.GroupBox
    Public WithEvents OptLOCAL As System.Windows.Forms.RadioButton
    Public WithEvents OptDOLAR As System.Windows.Forms.RadioButton
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents grpOrdenamiento As System.Windows.Forms.GroupBox
    Friend WithEvents BotonLlenar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents BotonConsolida As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsolida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mhTab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents Tab1 As System.Windows.Forms.GroupBox
    Public WithEvents cboDESCRIPCION As System.Windows.Forms.ComboBox
    Public WithEvents lblTitNombre_Tipo As System.Windows.Forms.Label
    Public WithEvents lblFECHA_PARTIDA As System.Windows.Forms.Label
    Public WithEvents lblTIPO_PARTIDA As System.Windows.Forms.Label
    Public WithEvents lblTASA_DE_CAMBIO As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_PARTIDA As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_PARTIDA As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_DE_CAMBIO As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_EMPRESA As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_SUCURSAL As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_CENTRO As System.Windows.Forms.Label
    Public WithEvents _lbldescripcion_origen_1 As System.Windows.Forms.Label
    Public WithEvents _lbldescripcion_origen_2 As System.Windows.Forms.Label
    Public WithEvents _lbldescripcion_origen_3 As System.Windows.Forms.Label
    Public WithEvents _lbldescripcion_origen_4 As System.Windows.Forms.Label
    Public WithEvents _lbldescripcion_origen_5 As System.Windows.Forms.Label
    Public WithEvents _lbldescripcion_origen_6 As System.Windows.Forms.Label
    Public WithEvents lblNO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblNUMERO_PARTIDA As System.Windows.Forms.Label
    Public WithEvents lblANO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblDOCUMENTO_ORIGEN As System.Windows.Forms.Label
    Public WithEvents lblID_EMPRESA As System.Windows.Forms.Label
    Public WithEvents lblID_SUCURSAL As System.Windows.Forms.Label
    Public WithEvents lblID_CENTRO_OPERATIVO As System.Windows.Forms.Label
    Public WithEvents _lblorigen_4 As System.Windows.Forms.Label
    Public WithEvents _lblorigen_3 As System.Windows.Forms.Label
    Public WithEvents _lblorigen_2 As System.Windows.Forms.Label
    Public WithEvents _lblorigen_1 As System.Windows.Forms.Label
    Public WithEvents _lblorigen_5 As System.Windows.Forms.Label
    Public WithEvents _lblorigen_6 As System.Windows.Forms.Label
    Public WithEvents _lblTitDESCRIPCION_1_0 As System.Windows.Forms.Label
    Public WithEvents lblTitNUMERO_PARTIDA As System.Windows.Forms.Label
    Public WithEvents lblTitNO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblTitDOCUMENTO_ORIGEN As System.Windows.Forms.Label
    Public WithEvents lblTitID_EMPRESA As System.Windows.Forms.Label
    Public WithEvents lblTitID_SUCURSAL As System.Windows.Forms.Label
    Public WithEvents lblTitID_CENTRO_OPERATIVO As System.Windows.Forms.Label
    Public WithEvents _lbltitORIGEN_4 As System.Windows.Forms.Label
    Public WithEvents _lbltitORIGEN_3 As System.Windows.Forms.Label
    Public WithEvents _lbltitORIGEN_2 As System.Windows.Forms.Label
    Public WithEvents _lbltitORIGEN_1 As System.Windows.Forms.Label
    Public WithEvents _lbltitORIGEN_5 As System.Windows.Forms.Label
    Public WithEvents _lbltitORIGEN_6 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents lblTitCODIGO_MODULO As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblTitREFERENCIA_1 As System.Windows.Forms.Label
    Public WithEvents lblPARTIDA_ORIGEN As System.Windows.Forms.Label
    Public WithEvents lblUSUARIO_INGRESO As System.Windows.Forms.Label
    Public WithEvents lblTitUSUARIO_INGRESO As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_MAYORIZACION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_MODULO As System.Windows.Forms.Label
    Public WithEvents lblTOTALES As System.Windows.Forms.Label
    Public WithEvents lblREFERENCIA_1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblFECHA_INGRESO As System.Windows.Forms.Label
    Public WithEvents lblTitCodigo_razon As System.Windows.Forms.Label
    Public WithEvents lblTitREFERENCIA_2 As System.Windows.Forms.Label
    Public WithEvents lblCodigo_razon As System.Windows.Forms.Label
    Public WithEvents lblDES_RAZON As System.Windows.Forms.Label
    Public WithEvents lblREFERENCIA_2 As System.Windows.Forms.Label
    Public WithEvents lblUSUARIO_AUTORIZO As System.Windows.Forms.Label
    Public WithEvents lblFECHA_AUTORIZO As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Friend WithEvents mnuLlenar As System.Windows.Forms.ToolStripMenuItem
End Class
