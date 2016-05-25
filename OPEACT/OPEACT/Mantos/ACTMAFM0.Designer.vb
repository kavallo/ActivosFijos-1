<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ACTMAFM0
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Folder = New System.Windows.Forms.TabControl()
        Me.TabGenerales = New System.Windows.Forms.TabPage()
        Me.btnPrint = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.cmdCopiar = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.txtCODIGO_PROVEEDOR = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCODIGO_DE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_TIPO_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIP_CORTA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtVALOR_ORIGINAL_ACTIV = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtVALOR_RESCATE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTIEMPO_DEPRECIACION = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.mskFECHA_ADQUISICION = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtCODIGO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtFRECUENCIA_MNTMTO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTASA_CAMBIO_COMPRA = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.CODIGO_UBICACION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtRESPONSABLE_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCATEGORIA_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblmsgfecha = New System.Windows.Forms.Label()
        Me.POSEE_CTRL_TF = New System.Windows.Forms.CheckBox()
        Me.lblCATEGORIA_DESC = New System.Windows.Forms.Label()
        Me.lblTitCATEGORIA_ID = New System.Windows.Forms.Label()
        Me.lblNOMBRE_USUAL = New System.Windows.Forms.Label()
        Me.lblTitRESPONSABLE_ID = New System.Windows.Forms.Label()
        Me.desCODIGO_UBICACION = New System.Windows.Forms.Label()
        Me.lblCODIGO_UBICACION = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_MARCA = New System.Windows.Forms.Label()
        Me.txtCODIGO_MARCA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCODIGO_MARCA = New System.Windows.Forms.Label()
        Me.mskFECHA_INICIO_DEPREC = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblTitFECHA_INICIO_DEPREC = New System.Windows.Forms.Label()
        Me.txtVALOR_MONEDA_LOCAL = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblTitVALOR_MONEDA_LOCAL = New System.Windows.Forms.Label()
        Me.txtTASA_DEDUCIBLE_ISR = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblTitTASA_DEDUCIBLE_ISR = New System.Windows.Forms.Label()
        Me.txtVALOR_ORIG_ACT_USADO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblTitVALOR_ORIG_ACT_USADO = New System.Windows.Forms.Label()
        Me.lblTitFRECUENCIA_MNTMTO = New System.Windows.Forms.Label()
        Me.txtCODIGO_DE_BARRAS = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCODIGO_DE_BARRAS = New System.Windows.Forms.Label()
        Me.txtREFERENCIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitREFERENCIA = New System.Windows.Forms.Label()
        Me.txtVALOR_NO_DEDUCIBLE = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblTitVALOR_NO_DEDUCIBLE = New System.Windows.Forms.Label()
        Me.lblTitTASA_CAMBIO_COMPRA = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.mskFechaInv = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFechaInv = New System.Windows.Forms.Label()
        Me.lblTitVALOR_RESCATE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitTIEMPO_DEPRECIACION = New System.Windows.Forms.Label()
        Me.lblTitTIPO_DEPRECIACION = New System.Windows.Forms.Label()
        Me.cboTIPO_DEPRECIACION = New System.Windows.Forms.ComboBox()
        Me.lblDESCRIP_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblnombre_proveedor = New System.Windows.Forms.Label()
        Me.lblMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblTitFECHA_ADQUISICION = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDEPRECIABLE = New System.Windows.Forms.ComboBox()
        Me.lblTitVALOR_ORIGINAL_ACTIV = New System.Windows.Forms.Label()
        Me.lblTitDESCRIP_CORTA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.panCampos = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.ImpresoraDialog = New System.Windows.Forms.PrintDialog()
        Me.TemporizadorEspera = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Folder.SuspendLayout()
        Me.TabGenerales.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Folder
        '
        Me.Folder.Controls.Add(Me.TabGenerales)
        Me.Folder.Controls.Add(Me.TabPage2)
        Me.Folder.Location = New System.Drawing.Point(12, 12)
        Me.Folder.Name = "Folder"
        Me.Folder.SelectedIndex = 0
        Me.Folder.Size = New System.Drawing.Size(878, 527)
        Me.Folder.TabIndex = 1
        '
        'TabGenerales
        '
        Me.TabGenerales.BackColor = System.Drawing.SystemColors.Control
        Me.TabGenerales.Controls.Add(Me.btnPrint)
        Me.TabGenerales.Controls.Add(Me.cmdCopiar)
        Me.TabGenerales.Controls.Add(Me.txtCODIGO_PROVEEDOR)
        Me.TabGenerales.Controls.Add(Me.txtCODIGO_DE_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.txtCODIGO_TIPO_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.txtCODIGO_DIVISION)
        Me.TabGenerales.Controls.Add(Me.txtDESCRIP_CORTA_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.txtVALOR_ORIGINAL_ACTIV)
        Me.TabGenerales.Controls.Add(Me.txtVALOR_RESCATE_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.txtTIEMPO_DEPRECIACION)
        Me.TabGenerales.Controls.Add(Me.mskFECHA_ADQUISICION)
        Me.TabGenerales.Controls.Add(Me.txtCODIGO_DE_MONEDA)
        Me.TabGenerales.Controls.Add(Me.txtFRECUENCIA_MNTMTO)
        Me.TabGenerales.Controls.Add(Me.txtTASA_CAMBIO_COMPRA)
        Me.TabGenerales.Controls.Add(Me.CODIGO_UBICACION)
        Me.TabGenerales.Controls.Add(Me.txtRESPONSABLE_ID)
        Me.TabGenerales.Controls.Add(Me.txtCATEGORIA_ID)
        Me.TabGenerales.Controls.Add(Me.Label3)
        Me.TabGenerales.Controls.Add(Me.lblmsgfecha)
        Me.TabGenerales.Controls.Add(Me.POSEE_CTRL_TF)
        Me.TabGenerales.Controls.Add(Me.lblCATEGORIA_DESC)
        Me.TabGenerales.Controls.Add(Me.lblTitCATEGORIA_ID)
        Me.TabGenerales.Controls.Add(Me.lblNOMBRE_USUAL)
        Me.TabGenerales.Controls.Add(Me.lblTitRESPONSABLE_ID)
        Me.TabGenerales.Controls.Add(Me.desCODIGO_UBICACION)
        Me.TabGenerales.Controls.Add(Me.lblCODIGO_UBICACION)
        Me.TabGenerales.Controls.Add(Me.lblDESCRIPCION_MARCA)
        Me.TabGenerales.Controls.Add(Me.txtCODIGO_MARCA)
        Me.TabGenerales.Controls.Add(Me.lblTitCODIGO_MARCA)
        Me.TabGenerales.Controls.Add(Me.mskFECHA_INICIO_DEPREC)
        Me.TabGenerales.Controls.Add(Me.lblTitFECHA_INICIO_DEPREC)
        Me.TabGenerales.Controls.Add(Me.txtVALOR_MONEDA_LOCAL)
        Me.TabGenerales.Controls.Add(Me.lblTitVALOR_MONEDA_LOCAL)
        Me.TabGenerales.Controls.Add(Me.txtTASA_DEDUCIBLE_ISR)
        Me.TabGenerales.Controls.Add(Me.lblTitTASA_DEDUCIBLE_ISR)
        Me.TabGenerales.Controls.Add(Me.txtVALOR_ORIG_ACT_USADO)
        Me.TabGenerales.Controls.Add(Me.lblTitVALOR_ORIG_ACT_USADO)
        Me.TabGenerales.Controls.Add(Me.lblTitFRECUENCIA_MNTMTO)
        Me.TabGenerales.Controls.Add(Me.txtCODIGO_DE_BARRAS)
        Me.TabGenerales.Controls.Add(Me.lblTitCODIGO_DE_BARRAS)
        Me.TabGenerales.Controls.Add(Me.txtREFERENCIA)
        Me.TabGenerales.Controls.Add(Me.lblTitREFERENCIA)
        Me.TabGenerales.Controls.Add(Me.txtVALOR_NO_DEDUCIBLE)
        Me.TabGenerales.Controls.Add(Me.lblTitVALOR_NO_DEDUCIBLE)
        Me.TabGenerales.Controls.Add(Me.lblTitTASA_CAMBIO_COMPRA)
        Me.TabGenerales.Controls.Add(Me.lblDESCRIPCION_MONEDA)
        Me.TabGenerales.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.TabGenerales.Controls.Add(Me.mskFechaInv)
        Me.TabGenerales.Controls.Add(Me.Label2)
        Me.TabGenerales.Controls.Add(Me.lblFechaInv)
        Me.TabGenerales.Controls.Add(Me.lblTitVALOR_RESCATE_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.lblDESCRIPCION_DIVISION)
        Me.TabGenerales.Controls.Add(Me.lblTitTIEMPO_DEPRECIACION)
        Me.TabGenerales.Controls.Add(Me.lblTitTIPO_DEPRECIACION)
        Me.TabGenerales.Controls.Add(Me.cboTIPO_DEPRECIACION)
        Me.TabGenerales.Controls.Add(Me.lblDESCRIP_TIPO_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.lblnombre_proveedor)
        Me.TabGenerales.Controls.Add(Me.lblMEJORA_CORRELATIVO)
        Me.TabGenerales.Controls.Add(Me.lblTitFECHA_ADQUISICION)
        Me.TabGenerales.Controls.Add(Me.Label7)
        Me.TabGenerales.Controls.Add(Me.cboDEPRECIABLE)
        Me.TabGenerales.Controls.Add(Me.lblTitVALOR_ORIGINAL_ACTIV)
        Me.TabGenerales.Controls.Add(Me.lblTitDESCRIP_CORTA_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.TabGenerales.Controls.Add(Me.lblTitCODIGO_TIPO_ACTIVO)
        Me.TabGenerales.Controls.Add(Me.lblTitCODIGO_PROVEEDOR)
        Me.TabGenerales.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.TabGenerales.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.TabGenerales.Location = New System.Drawing.Point(4, 22)
        Me.TabGenerales.Name = "TabGenerales"
        Me.TabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGenerales.Size = New System.Drawing.Size(870, 501)
        Me.TabGenerales.TabIndex = 0
        Me.TabGenerales.Text = "Información General"
        '
        'btnPrint
        '
        Me.btnPrint.ImageKey = "Agregar.ico"
        Me.btnPrint.LabelMensaje = Me.LabelMensaje
        Me.btnPrint.Location = New System.Drawing.Point(382, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(32, 32)
        Me.btnPrint.TabIndex = 77
        Me.btnPrint.Texto = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(12, 547)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(692, 23)
        Me.LabelMensaje.TabIndex = 4
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdCopiar
        '
        Me.cmdCopiar.ImageKey = "Agregar.ico"
        Me.cmdCopiar.LabelMensaje = Me.LabelMensaje
        Me.cmdCopiar.Location = New System.Drawing.Point(344, 7)
        Me.cmdCopiar.Name = "cmdCopiar"
        Me.cmdCopiar.Size = New System.Drawing.Size(32, 32)
        Me.cmdCopiar.TabIndex = 76
        Me.cmdCopiar.Texto = "Copy from"
        Me.cmdCopiar.UseVisualStyleBackColor = True
        '
        'txtCODIGO_PROVEEDOR
        '
        Me.txtCODIGO_PROVEEDOR.AcceptsReturn = True
        Me.txtCODIGO_PROVEEDOR.BackColor = System.Drawing.Color.White
        Me.txtCODIGO_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_PROVEEDOR.EsRequerido = True
        Me.txtCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_PROVEEDOR.LabelConsulta = Nothing
        Me.txtCODIGO_PROVEEDOR.Location = New System.Drawing.Point(189, 57)
        Me.txtCODIGO_PROVEEDOR.MaxLength = 10
        Me.txtCODIGO_PROVEEDOR.Name = "txtCODIGO_PROVEEDOR"
        Me.txtCODIGO_PROVEEDOR.NombreDeConsulta = Nothing
        Me.txtCODIGO_PROVEEDOR.NumeroDecimales = 0
        Me.txtCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_PROVEEDOR.Size = New System.Drawing.Size(83, 20)
        Me.txtCODIGO_PROVEEDOR.TabIndex = 0
        Me.txtCODIGO_PROVEEDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_DE_ACTIVO
        '
        Me.txtCODIGO_DE_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.White
        Me.txtCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_ACTIVO.Enabled = False
        Me.txtCODIGO_DE_ACTIVO.EsRequerido = False
        Me.txtCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(189, 15)
        Me.txtCODIGO_DE_ACTIVO.MaxLength = 15
        Me.txtCODIGO_DE_ACTIVO.Name = "txtCODIGO_DE_ACTIVO"
        Me.txtCODIGO_DE_ACTIVO.NombreDeConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(150, 20)
        Me.txtCODIGO_DE_ACTIVO.TabIndex = 1
        '
        'txtCODIGO_TIPO_ACTIVO
        '
        Me.txtCODIGO_TIPO_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_TIPO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_TIPO_ACTIVO.EsRequerido = True
        Me.txtCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_TIPO_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(189, 83)
        Me.txtCODIGO_TIPO_ACTIVO.MaxLength = 7
        Me.txtCODIGO_TIPO_ACTIVO.Name = "txtCODIGO_TIPO_ACTIVO"
        Me.txtCODIGO_TIPO_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(83, 20)
        Me.txtCODIGO_TIPO_ACTIVO.TabIndex = 2
        '
        'txtCODIGO_DIVISION
        '
        Me.txtCODIGO_DIVISION.AcceptsReturn = True
        Me.txtCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DIVISION.EsRequerido = True
        Me.txtCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DIVISION.LabelConsulta = Nothing
        Me.txtCODIGO_DIVISION.Location = New System.Drawing.Point(189, 109)
        Me.txtCODIGO_DIVISION.MaxLength = 10
        Me.txtCODIGO_DIVISION.Name = "txtCODIGO_DIVISION"
        Me.txtCODIGO_DIVISION.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DIVISION.Size = New System.Drawing.Size(83, 20)
        Me.txtCODIGO_DIVISION.TabIndex = 3
        '
        'txtDESCRIP_CORTA_ACTIVO
        '
        Me.txtDESCRIP_CORTA_ACTIVO.AcceptsReturn = True
        Me.txtDESCRIP_CORTA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIP_CORTA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIP_CORTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIP_CORTA_ACTIVO.EsRequerido = True
        Me.txtDESCRIP_CORTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIP_CORTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIP_CORTA_ACTIVO.LabelConsulta = Nothing
        Me.txtDESCRIP_CORTA_ACTIVO.Location = New System.Drawing.Point(189, 135)
        Me.txtDESCRIP_CORTA_ACTIVO.MaxLength = 40
        Me.txtDESCRIP_CORTA_ACTIVO.Name = "txtDESCRIP_CORTA_ACTIVO"
        Me.txtDESCRIP_CORTA_ACTIVO.NombreDeConsulta = Nothing
        Me.txtDESCRIP_CORTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIP_CORTA_ACTIVO.Size = New System.Drawing.Size(565, 20)
        Me.txtDESCRIP_CORTA_ACTIVO.TabIndex = 4
        '
        'txtVALOR_ORIGINAL_ACTIV
        '
        Me.txtVALOR_ORIGINAL_ACTIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_ORIGINAL_ACTIV.EsRequerido = True
        Me.txtVALOR_ORIGINAL_ACTIV.LabelConsulta = Nothing
        Me.txtVALOR_ORIGINAL_ACTIV.Location = New System.Drawing.Point(189, 161)
        Me.txtVALOR_ORIGINAL_ACTIV.Name = "txtVALOR_ORIGINAL_ACTIV"
        Me.txtVALOR_ORIGINAL_ACTIV.NombreDeConsulta = Nothing
        Me.txtVALOR_ORIGINAL_ACTIV.NumeroDecimales = 2
        Me.txtVALOR_ORIGINAL_ACTIV.Size = New System.Drawing.Size(100, 20)
        Me.txtVALOR_ORIGINAL_ACTIV.TabIndex = 5
        Me.txtVALOR_ORIGINAL_ACTIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVALOR_RESCATE_ACTIVO
        '
        Me.txtVALOR_RESCATE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_RESCATE_ACTIVO.EsRequerido = True
        Me.txtVALOR_RESCATE_ACTIVO.LabelConsulta = Nothing
        Me.txtVALOR_RESCATE_ACTIVO.Location = New System.Drawing.Point(611, 161)
        Me.txtVALOR_RESCATE_ACTIVO.Name = "txtVALOR_RESCATE_ACTIVO"
        Me.txtVALOR_RESCATE_ACTIVO.NombreDeConsulta = Nothing
        Me.txtVALOR_RESCATE_ACTIVO.NumeroDecimales = 2
        Me.txtVALOR_RESCATE_ACTIVO.Size = New System.Drawing.Size(100, 20)
        Me.txtVALOR_RESCATE_ACTIVO.TabIndex = 6
        Me.txtVALOR_RESCATE_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTIEMPO_DEPRECIACION
        '
        Me.txtTIEMPO_DEPRECIACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIEMPO_DEPRECIACION.EsRequerido = True
        Me.txtTIEMPO_DEPRECIACION.LabelConsulta = Nothing
        Me.txtTIEMPO_DEPRECIACION.Location = New System.Drawing.Point(611, 187)
        Me.txtTIEMPO_DEPRECIACION.MaxLength = 5
        Me.txtTIEMPO_DEPRECIACION.Name = "txtTIEMPO_DEPRECIACION"
        Me.txtTIEMPO_DEPRECIACION.NombreDeConsulta = Nothing
        Me.txtTIEMPO_DEPRECIACION.NumeroDecimales = 0
        Me.txtTIEMPO_DEPRECIACION.Size = New System.Drawing.Size(58, 20)
        Me.txtTIEMPO_DEPRECIACION.TabIndex = 8
        Me.txtTIEMPO_DEPRECIACION.Tag = "0201100"
        Me.txtTIEMPO_DEPRECIACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskFECHA_ADQUISICION
        '
        Me.mskFECHA_ADQUISICION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFECHA_ADQUISICION.EsRequerido = True
        Me.mskFECHA_ADQUISICION.Location = New System.Drawing.Point(189, 215)
        Me.mskFECHA_ADQUISICION.Mask = "00/00/0000"
        Me.mskFECHA_ADQUISICION.Name = "mskFECHA_ADQUISICION"
        Me.mskFECHA_ADQUISICION.Size = New System.Drawing.Size(143, 20)
        Me.mskFECHA_ADQUISICION.TabIndex = 9
        Me.mskFECHA_ADQUISICION.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFECHA_ADQUISICION.ValidatingType = GetType(Date)
        '
        'txtCODIGO_DE_MONEDA
        '
        Me.txtCODIGO_DE_MONEDA.AcceptsReturn = True
        Me.txtCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_MONEDA.EsRequerido = True
        Me.txtCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_MONEDA.LabelConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.Location = New System.Drawing.Point(189, 241)
        Me.txtCODIGO_DE_MONEDA.MaxLength = 5
        Me.txtCODIGO_DE_MONEDA.Name = "txtCODIGO_DE_MONEDA"
        Me.txtCODIGO_DE_MONEDA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMonedas_MONEDC01
        Me.txtCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_MONEDA.Size = New System.Drawing.Size(45, 20)
        Me.txtCODIGO_DE_MONEDA.TabIndex = 11
        '
        'txtFRECUENCIA_MNTMTO
        '
        Me.txtFRECUENCIA_MNTMTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFRECUENCIA_MNTMTO.EsRequerido = True
        Me.txtFRECUENCIA_MNTMTO.LabelConsulta = Nothing
        Me.txtFRECUENCIA_MNTMTO.Location = New System.Drawing.Point(189, 267)
        Me.txtFRECUENCIA_MNTMTO.Name = "txtFRECUENCIA_MNTMTO"
        Me.txtFRECUENCIA_MNTMTO.NombreDeConsulta = Nothing
        Me.txtFRECUENCIA_MNTMTO.NumeroDecimales = 0
        Me.txtFRECUENCIA_MNTMTO.Size = New System.Drawing.Size(45, 20)
        Me.txtFRECUENCIA_MNTMTO.TabIndex = 12
        Me.txtFRECUENCIA_MNTMTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTASA_CAMBIO_COMPRA
        '
        Me.txtTASA_CAMBIO_COMPRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTASA_CAMBIO_COMPRA.EsRequerido = True
        Me.txtTASA_CAMBIO_COMPRA.LabelConsulta = Nothing
        Me.txtTASA_CAMBIO_COMPRA.Location = New System.Drawing.Point(189, 321)
        Me.txtTASA_CAMBIO_COMPRA.Name = "txtTASA_CAMBIO_COMPRA"
        Me.txtTASA_CAMBIO_COMPRA.NombreDeConsulta = Nothing
        Me.txtTASA_CAMBIO_COMPRA.NumeroDecimales = 5
        Me.txtTASA_CAMBIO_COMPRA.Size = New System.Drawing.Size(100, 20)
        Me.txtTASA_CAMBIO_COMPRA.TabIndex = 16
        Me.txtTASA_CAMBIO_COMPRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CODIGO_UBICACION
        '
        Me.CODIGO_UBICACION.AcceptsReturn = True
        Me.CODIGO_UBICACION.BackColor = System.Drawing.SystemColors.Window
        Me.CODIGO_UBICACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CODIGO_UBICACION.EsRequerido = True
        Me.CODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CODIGO_UBICACION.LabelConsulta = Nothing
        Me.CODIGO_UBICACION.Location = New System.Drawing.Point(189, 425)
        Me.CODIGO_UBICACION.MaxLength = 10
        Me.CODIGO_UBICACION.Name = "CODIGO_UBICACION"
        Me.CODIGO_UBICACION.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeUbicacionesDeActivosFijos_ACTUBIL0
        Me.CODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CODIGO_UBICACION.Size = New System.Drawing.Size(83, 20)
        Me.CODIGO_UBICACION.TabIndex = 23
        '
        'txtRESPONSABLE_ID
        '
        Me.txtRESPONSABLE_ID.AcceptsReturn = True
        Me.txtRESPONSABLE_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtRESPONSABLE_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRESPONSABLE_ID.EsRequerido = True
        Me.txtRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRESPONSABLE_ID.LabelConsulta = Nothing
        Me.txtRESPONSABLE_ID.Location = New System.Drawing.Point(189, 451)
        Me.txtRESPONSABLE_ID.MaxLength = 5
        Me.txtRESPONSABLE_ID.Name = "txtRESPONSABLE_ID"
        Me.txtRESPONSABLE_ID.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeResponsablesDeActivosFijos_ACTRAFL0
        Me.txtRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRESPONSABLE_ID.Size = New System.Drawing.Size(45, 20)
        Me.txtRESPONSABLE_ID.TabIndex = 24
        '
        'txtCATEGORIA_ID
        '
        Me.txtCATEGORIA_ID.AcceptsReturn = True
        Me.txtCATEGORIA_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCATEGORIA_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCATEGORIA_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCATEGORIA_ID.EsRequerido = False
        Me.txtCATEGORIA_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATEGORIA_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCATEGORIA_ID.LabelConsulta = Nothing
        Me.txtCATEGORIA_ID.Location = New System.Drawing.Point(189, 477)
        Me.txtCATEGORIA_ID.MaxLength = 5
        Me.txtCATEGORIA_ID.Name = "txtCATEGORIA_ID"
        Me.txtCATEGORIA_ID.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCategoriasDeActivos_ACTCDAL0
        Me.txtCATEGORIA_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCATEGORIA_ID.Size = New System.Drawing.Size(45, 20)
        Me.txtCATEGORIA_ID.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(773, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "(DD/MM/AAAA)"
        '
        'lblmsgfecha
        '
        Me.lblmsgfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblmsgfecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsgfecha.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgfecha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblmsgfecha.Location = New System.Drawing.Point(773, 214)
        Me.lblmsgfecha.Name = "lblmsgfecha"
        Me.lblmsgfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsgfecha.Size = New System.Drawing.Size(91, 17)
        Me.lblmsgfecha.TabIndex = 74
        Me.lblmsgfecha.Text = "(DD/MM/AAAA)"
        '
        'POSEE_CTRL_TF
        '
        Me.POSEE_CTRL_TF.Location = New System.Drawing.Point(611, 424)
        Me.POSEE_CTRL_TF.Name = "POSEE_CTRL_TF"
        Me.POSEE_CTRL_TF.Size = New System.Drawing.Size(226, 17)
        Me.POSEE_CTRL_TF.TabIndex = 26
        Me.POSEE_CTRL_TF.Text = "Control de existencias (toma física)"
        Me.POSEE_CTRL_TF.UseVisualStyleBackColor = True
        '
        'lblCATEGORIA_DESC
        '
        Me.lblCATEGORIA_DESC.BackColor = System.Drawing.Color.Transparent
        Me.lblCATEGORIA_DESC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCATEGORIA_DESC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCATEGORIA_DESC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCATEGORIA_DESC.Location = New System.Drawing.Point(259, 479)
        Me.lblCATEGORIA_DESC.Name = "lblCATEGORIA_DESC"
        Me.lblCATEGORIA_DESC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCATEGORIA_DESC.Size = New System.Drawing.Size(522, 20)
        Me.lblCATEGORIA_DESC.TabIndex = 73
        Me.lblCATEGORIA_DESC.UseMnemonic = False
        '
        'lblTitCATEGORIA_ID
        '
        Me.lblTitCATEGORIA_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCATEGORIA_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCATEGORIA_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCATEGORIA_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCATEGORIA_ID.Location = New System.Drawing.Point(6, 479)
        Me.lblTitCATEGORIA_ID.Name = "lblTitCATEGORIA_ID"
        Me.lblTitCATEGORIA_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCATEGORIA_ID.Size = New System.Drawing.Size(177, 14)
        Me.lblTitCATEGORIA_ID.TabIndex = 72
        Me.lblTitCATEGORIA_ID.Text = "[Categoría del activo]"
        '
        'lblNOMBRE_USUAL
        '
        Me.lblNOMBRE_USUAL.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_USUAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_USUAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_USUAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_USUAL.Location = New System.Drawing.Point(259, 451)
        Me.lblNOMBRE_USUAL.Name = "lblNOMBRE_USUAL"
        Me.lblNOMBRE_USUAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_USUAL.Size = New System.Drawing.Size(522, 20)
        Me.lblNOMBRE_USUAL.TabIndex = 70
        Me.lblNOMBRE_USUAL.UseMnemonic = False
        '
        'lblTitRESPONSABLE_ID
        '
        Me.lblTitRESPONSABLE_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitRESPONSABLE_ID.Location = New System.Drawing.Point(6, 453)
        Me.lblTitRESPONSABLE_ID.Name = "lblTitRESPONSABLE_ID"
        Me.lblTitRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitRESPONSABLE_ID.Size = New System.Drawing.Size(177, 14)
        Me.lblTitRESPONSABLE_ID.TabIndex = 69
        Me.lblTitRESPONSABLE_ID.Text = "Responsable del activo"
        '
        'desCODIGO_UBICACION
        '
        Me.desCODIGO_UBICACION.BackColor = System.Drawing.Color.Transparent
        Me.desCODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.desCODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desCODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.desCODIGO_UBICACION.Location = New System.Drawing.Point(294, 425)
        Me.desCODIGO_UBICACION.Name = "desCODIGO_UBICACION"
        Me.desCODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.desCODIGO_UBICACION.Size = New System.Drawing.Size(297, 20)
        Me.desCODIGO_UBICACION.TabIndex = 67
        Me.desCODIGO_UBICACION.UseMnemonic = False
        '
        'lblCODIGO_UBICACION
        '
        Me.lblCODIGO_UBICACION.BackColor = System.Drawing.Color.Transparent
        Me.lblCODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_UBICACION.Location = New System.Drawing.Point(6, 427)
        Me.lblCODIGO_UBICACION.Name = "lblCODIGO_UBICACION"
        Me.lblCODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_UBICACION.Size = New System.Drawing.Size(177, 14)
        Me.lblCODIGO_UBICACION.TabIndex = 66
        Me.lblCODIGO_UBICACION.Text = "Código de ubicación"
        '
        'lblDESCRIPCION_MARCA
        '
        Me.lblDESCRIPCION_MARCA.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_MARCA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_MARCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_MARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_MARCA.Location = New System.Drawing.Point(259, 399)
        Me.lblDESCRIPCION_MARCA.Name = "lblDESCRIPCION_MARCA"
        Me.lblDESCRIPCION_MARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_MARCA.Size = New System.Drawing.Size(522, 20)
        Me.lblDESCRIPCION_MARCA.TabIndex = 64
        Me.lblDESCRIPCION_MARCA.UseMnemonic = False
        '
        'txtCODIGO_MARCA
        '
        Me.txtCODIGO_MARCA.AcceptsReturn = True
        Me.txtCODIGO_MARCA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_MARCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_MARCA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_MARCA.EsRequerido = False
        Me.txtCODIGO_MARCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_MARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_MARCA.LabelConsulta = Nothing
        Me.txtCODIGO_MARCA.Location = New System.Drawing.Point(189, 399)
        Me.txtCODIGO_MARCA.MaxLength = 5
        Me.txtCODIGO_MARCA.Name = "txtCODIGO_MARCA"
        Me.txtCODIGO_MARCA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMarcas_MARCAC01
        Me.txtCODIGO_MARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_MARCA.Size = New System.Drawing.Size(45, 20)
        Me.txtCODIGO_MARCA.TabIndex = 22
        '
        'lblTitCODIGO_MARCA
        '
        Me.lblTitCODIGO_MARCA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_MARCA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_MARCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_MARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_MARCA.Location = New System.Drawing.Point(6, 401)
        Me.lblTitCODIGO_MARCA.Name = "lblTitCODIGO_MARCA"
        Me.lblTitCODIGO_MARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_MARCA.Size = New System.Drawing.Size(177, 14)
        Me.lblTitCODIGO_MARCA.TabIndex = 63
        Me.lblTitCODIGO_MARCA.Text = "[Código de marca]"
        '
        'mskFECHA_INICIO_DEPREC
        '
        Me.mskFECHA_INICIO_DEPREC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFECHA_INICIO_DEPREC.EsRequerido = False
        Me.mskFECHA_INICIO_DEPREC.Location = New System.Drawing.Point(611, 373)
        Me.mskFECHA_INICIO_DEPREC.Mask = "00/00/0000"
        Me.mskFECHA_INICIO_DEPREC.Name = "mskFECHA_INICIO_DEPREC"
        Me.mskFECHA_INICIO_DEPREC.Size = New System.Drawing.Size(143, 20)
        Me.mskFECHA_INICIO_DEPREC.TabIndex = 21
        Me.mskFECHA_INICIO_DEPREC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFECHA_INICIO_DEPREC.ValidatingType = GetType(Date)
        '
        'lblTitFECHA_INICIO_DEPREC
        '
        Me.lblTitFECHA_INICIO_DEPREC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_INICIO_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_INICIO_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_INICIO_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_INICIO_DEPREC.Location = New System.Drawing.Point(430, 375)
        Me.lblTitFECHA_INICIO_DEPREC.Name = "lblTitFECHA_INICIO_DEPREC"
        Me.lblTitFECHA_INICIO_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_INICIO_DEPREC.Size = New System.Drawing.Size(175, 14)
        Me.lblTitFECHA_INICIO_DEPREC.TabIndex = 61
        Me.lblTitFECHA_INICIO_DEPREC.Text = "Fecha de inicio depreciación"
        '
        'txtVALOR_MONEDA_LOCAL
        '
        Me.txtVALOR_MONEDA_LOCAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_MONEDA_LOCAL.EsRequerido = False
        Me.txtVALOR_MONEDA_LOCAL.LabelConsulta = Nothing
        Me.txtVALOR_MONEDA_LOCAL.Location = New System.Drawing.Point(189, 373)
        Me.txtVALOR_MONEDA_LOCAL.Name = "txtVALOR_MONEDA_LOCAL"
        Me.txtVALOR_MONEDA_LOCAL.NombreDeConsulta = Nothing
        Me.txtVALOR_MONEDA_LOCAL.NumeroDecimales = 2
        Me.txtVALOR_MONEDA_LOCAL.Size = New System.Drawing.Size(100, 20)
        Me.txtVALOR_MONEDA_LOCAL.TabIndex = 20
        Me.txtVALOR_MONEDA_LOCAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitVALOR_MONEDA_LOCAL
        '
        Me.lblTitVALOR_MONEDA_LOCAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_MONEDA_LOCAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_MONEDA_LOCAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_MONEDA_LOCAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_MONEDA_LOCAL.Location = New System.Drawing.Point(6, 375)
        Me.lblTitVALOR_MONEDA_LOCAL.Name = "lblTitVALOR_MONEDA_LOCAL"
        Me.lblTitVALOR_MONEDA_LOCAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_MONEDA_LOCAL.Size = New System.Drawing.Size(177, 14)
        Me.lblTitVALOR_MONEDA_LOCAL.TabIndex = 59
        Me.lblTitVALOR_MONEDA_LOCAL.Text = "Valor moneda de compra"
        '
        'txtTASA_DEDUCIBLE_ISR
        '
        Me.txtTASA_DEDUCIBLE_ISR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTASA_DEDUCIBLE_ISR.EsRequerido = False
        Me.txtTASA_DEDUCIBLE_ISR.LabelConsulta = Nothing
        Me.txtTASA_DEDUCIBLE_ISR.Location = New System.Drawing.Point(611, 293)
        Me.txtTASA_DEDUCIBLE_ISR.Name = "txtTASA_DEDUCIBLE_ISR"
        Me.txtTASA_DEDUCIBLE_ISR.NombreDeConsulta = Nothing
        Me.txtTASA_DEDUCIBLE_ISR.NumeroDecimales = 5
        Me.txtTASA_DEDUCIBLE_ISR.Size = New System.Drawing.Size(100, 20)
        Me.txtTASA_DEDUCIBLE_ISR.TabIndex = 15
        Me.txtTASA_DEDUCIBLE_ISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTASA_DEDUCIBLE_ISR.Visible = False
        '
        'lblTitTASA_DEDUCIBLE_ISR
        '
        Me.lblTitTASA_DEDUCIBLE_ISR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_DEDUCIBLE_ISR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_DEDUCIBLE_ISR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_DEDUCIBLE_ISR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_DEDUCIBLE_ISR.Location = New System.Drawing.Point(430, 296)
        Me.lblTitTASA_DEDUCIBLE_ISR.Name = "lblTitTASA_DEDUCIBLE_ISR"
        Me.lblTitTASA_DEDUCIBLE_ISR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_DEDUCIBLE_ISR.Size = New System.Drawing.Size(175, 14)
        Me.lblTitTASA_DEDUCIBLE_ISR.TabIndex = 57
        Me.lblTitTASA_DEDUCIBLE_ISR.Text = "Tasa deducible ISR"
        Me.lblTitTASA_DEDUCIBLE_ISR.Visible = False
        '
        'txtVALOR_ORIG_ACT_USADO
        '
        Me.txtVALOR_ORIG_ACT_USADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_ORIG_ACT_USADO.EsRequerido = False
        Me.txtVALOR_ORIG_ACT_USADO.LabelConsulta = Nothing
        Me.txtVALOR_ORIG_ACT_USADO.Location = New System.Drawing.Point(611, 267)
        Me.txtVALOR_ORIG_ACT_USADO.Name = "txtVALOR_ORIG_ACT_USADO"
        Me.txtVALOR_ORIG_ACT_USADO.NombreDeConsulta = Nothing
        Me.txtVALOR_ORIG_ACT_USADO.NumeroDecimales = 2
        Me.txtVALOR_ORIG_ACT_USADO.Size = New System.Drawing.Size(100, 20)
        Me.txtVALOR_ORIG_ACT_USADO.TabIndex = 13
        Me.txtVALOR_ORIG_ACT_USADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVALOR_ORIG_ACT_USADO.Visible = False
        '
        'lblTitVALOR_ORIG_ACT_USADO
        '
        Me.lblTitVALOR_ORIG_ACT_USADO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_ORIG_ACT_USADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_ORIG_ACT_USADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_ORIG_ACT_USADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_ORIG_ACT_USADO.Location = New System.Drawing.Point(430, 269)
        Me.lblTitVALOR_ORIG_ACT_USADO.Name = "lblTitVALOR_ORIG_ACT_USADO"
        Me.lblTitVALOR_ORIG_ACT_USADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_ORIG_ACT_USADO.Size = New System.Drawing.Size(175, 14)
        Me.lblTitVALOR_ORIG_ACT_USADO.TabIndex = 55
        Me.lblTitVALOR_ORIG_ACT_USADO.Text = "Valor original en comp. de usado"
        Me.lblTitVALOR_ORIG_ACT_USADO.Visible = False
        '
        'lblTitFRECUENCIA_MNTMTO
        '
        Me.lblTitFRECUENCIA_MNTMTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFRECUENCIA_MNTMTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFRECUENCIA_MNTMTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFRECUENCIA_MNTMTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFRECUENCIA_MNTMTO.Location = New System.Drawing.Point(6, 269)
        Me.lblTitFRECUENCIA_MNTMTO.Name = "lblTitFRECUENCIA_MNTMTO"
        Me.lblTitFRECUENCIA_MNTMTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFRECUENCIA_MNTMTO.Size = New System.Drawing.Size(177, 20)
        Me.lblTitFRECUENCIA_MNTMTO.TabIndex = 53
        Me.lblTitFRECUENCIA_MNTMTO.Text = "Frecuencia manto. (días)"
        '
        'txtCODIGO_DE_BARRAS
        '
        Me.txtCODIGO_DE_BARRAS.AcceptsReturn = True
        Me.txtCODIGO_DE_BARRAS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_BARRAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_BARRAS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_BARRAS.EsRequerido = False
        Me.txtCODIGO_DE_BARRAS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_BARRAS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_BARRAS.LabelConsulta = Nothing
        Me.txtCODIGO_DE_BARRAS.Location = New System.Drawing.Point(611, 347)
        Me.txtCODIGO_DE_BARRAS.MaxLength = 15
        Me.txtCODIGO_DE_BARRAS.Name = "txtCODIGO_DE_BARRAS"
        Me.txtCODIGO_DE_BARRAS.NombreDeConsulta = Nothing
        Me.txtCODIGO_DE_BARRAS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_BARRAS.Size = New System.Drawing.Size(143, 20)
        Me.txtCODIGO_DE_BARRAS.TabIndex = 19
        '
        'lblTitCODIGO_DE_BARRAS
        '
        Me.lblTitCODIGO_DE_BARRAS.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_BARRAS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_BARRAS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_BARRAS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_BARRAS.Location = New System.Drawing.Point(430, 349)
        Me.lblTitCODIGO_DE_BARRAS.Name = "lblTitCODIGO_DE_BARRAS"
        Me.lblTitCODIGO_DE_BARRAS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_BARRAS.Size = New System.Drawing.Size(175, 14)
        Me.lblTitCODIGO_DE_BARRAS.TabIndex = 51
        Me.lblTitCODIGO_DE_BARRAS.Text = "[Código de barras]"
        '
        'txtREFERENCIA
        '
        Me.txtREFERENCIA.AcceptsReturn = True
        Me.txtREFERENCIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtREFERENCIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtREFERENCIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtREFERENCIA.EsRequerido = False
        Me.txtREFERENCIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtREFERENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtREFERENCIA.LabelConsulta = Nothing
        Me.txtREFERENCIA.Location = New System.Drawing.Point(189, 347)
        Me.txtREFERENCIA.MaxLength = 15
        Me.txtREFERENCIA.Name = "txtREFERENCIA"
        Me.txtREFERENCIA.NombreDeConsulta = Nothing
        Me.txtREFERENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtREFERENCIA.Size = New System.Drawing.Size(125, 20)
        Me.txtREFERENCIA.TabIndex = 18
        '
        'lblTitREFERENCIA
        '
        Me.lblTitREFERENCIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitREFERENCIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitREFERENCIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitREFERENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitREFERENCIA.Location = New System.Drawing.Point(6, 349)
        Me.lblTitREFERENCIA.Name = "lblTitREFERENCIA"
        Me.lblTitREFERENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitREFERENCIA.Size = New System.Drawing.Size(177, 14)
        Me.lblTitREFERENCIA.TabIndex = 49
        Me.lblTitREFERENCIA.Text = "[Referencia activo fijo]"
        '
        'txtVALOR_NO_DEDUCIBLE
        '
        Me.txtVALOR_NO_DEDUCIBLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_NO_DEDUCIBLE.EsRequerido = False
        Me.txtVALOR_NO_DEDUCIBLE.LabelConsulta = Nothing
        Me.txtVALOR_NO_DEDUCIBLE.Location = New System.Drawing.Point(611, 321)
        Me.txtVALOR_NO_DEDUCIBLE.Name = "txtVALOR_NO_DEDUCIBLE"
        Me.txtVALOR_NO_DEDUCIBLE.NombreDeConsulta = Nothing
        Me.txtVALOR_NO_DEDUCIBLE.NumeroDecimales = 2
        Me.txtVALOR_NO_DEDUCIBLE.Size = New System.Drawing.Size(100, 20)
        Me.txtVALOR_NO_DEDUCIBLE.TabIndex = 17
        Me.txtVALOR_NO_DEDUCIBLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVALOR_NO_DEDUCIBLE.Visible = False
        '
        'lblTitVALOR_NO_DEDUCIBLE
        '
        Me.lblTitVALOR_NO_DEDUCIBLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_NO_DEDUCIBLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_NO_DEDUCIBLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_NO_DEDUCIBLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_NO_DEDUCIBLE.Location = New System.Drawing.Point(430, 323)
        Me.lblTitVALOR_NO_DEDUCIBLE.Name = "lblTitVALOR_NO_DEDUCIBLE"
        Me.lblTitVALOR_NO_DEDUCIBLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_NO_DEDUCIBLE.Size = New System.Drawing.Size(175, 14)
        Me.lblTitVALOR_NO_DEDUCIBLE.TabIndex = 47
        Me.lblTitVALOR_NO_DEDUCIBLE.Text = "Valor no deducible"
        Me.lblTitVALOR_NO_DEDUCIBLE.Visible = False
        '
        'lblTitTASA_CAMBIO_COMPRA
        '
        Me.lblTitTASA_CAMBIO_COMPRA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_CAMBIO_COMPRA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_CAMBIO_COMPRA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_CAMBIO_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_CAMBIO_COMPRA.Location = New System.Drawing.Point(6, 323)
        Me.lblTitTASA_CAMBIO_COMPRA.Name = "lblTitTASA_CAMBIO_COMPRA"
        Me.lblTitTASA_CAMBIO_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_CAMBIO_COMPRA.Size = New System.Drawing.Size(177, 14)
        Me.lblTitTASA_CAMBIO_COMPRA.TabIndex = 45
        Me.lblTitTASA_CAMBIO_COMPRA.Text = "Tasa cambio compra"
        '
        'lblDESCRIPCION_MONEDA
        '
        Me.lblDESCRIPCION_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_MONEDA.Location = New System.Drawing.Point(256, 241)
        Me.lblDESCRIPCION_MONEDA.Name = "lblDESCRIPCION_MONEDA"
        Me.lblDESCRIPCION_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_MONEDA.Size = New System.Drawing.Size(525, 20)
        Me.lblDESCRIPCION_MONEDA.TabIndex = 43
        Me.lblDESCRIPCION_MONEDA.UseMnemonic = False
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(6, 243)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(177, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 42
        Me.lblTitCODIGO_DE_MONEDA.Text = "Moneda de compra"
        '
        'mskFechaInv
        '
        Me.mskFechaInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskFechaInv.EsRequerido = False
        Me.mskFechaInv.Location = New System.Drawing.Point(611, 215)
        Me.mskFechaInv.Mask = "00/00/0000"
        Me.mskFechaInv.Name = "mskFechaInv"
        Me.mskFechaInv.Size = New System.Drawing.Size(143, 20)
        Me.mskFechaInv.TabIndex = 10
        Me.mskFechaInv.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskFechaInv.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(341, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "(DD/MM/AAAA)"
        '
        'lblFechaInv
        '
        Me.lblFechaInv.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFechaInv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInv.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaInv.Location = New System.Drawing.Point(430, 217)
        Me.lblFechaInv.Name = "lblFechaInv"
        Me.lblFechaInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaInv.Size = New System.Drawing.Size(175, 14)
        Me.lblFechaInv.TabIndex = 37
        Me.lblFechaInv.Text = "Fecha último inventario"
        '
        'lblTitVALOR_RESCATE_ACTIVO
        '
        Me.lblTitVALOR_RESCATE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_RESCATE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_RESCATE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_RESCATE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_RESCATE_ACTIVO.Location = New System.Drawing.Point(430, 163)
        Me.lblTitVALOR_RESCATE_ACTIVO.Name = "lblTitVALOR_RESCATE_ACTIVO"
        Me.lblTitVALOR_RESCATE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_RESCATE_ACTIVO.Size = New System.Drawing.Size(175, 14)
        Me.lblTitVALOR_RESCATE_ACTIVO.TabIndex = 36
        Me.lblTitVALOR_RESCATE_ACTIVO.Text = "Valor de rescate"
        '
        'lblDESCRIPCION_DIVISION
        '
        Me.lblDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_DIVISION.Location = New System.Drawing.Point(294, 109)
        Me.lblDESCRIPCION_DIVISION.Name = "lblDESCRIPCION_DIVISION"
        Me.lblDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_DIVISION.Size = New System.Drawing.Size(487, 20)
        Me.lblDESCRIPCION_DIVISION.TabIndex = 34
        Me.lblDESCRIPCION_DIVISION.UseMnemonic = False
        '
        'lblTitTIEMPO_DEPRECIACION
        '
        Me.lblTitTIEMPO_DEPRECIACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIEMPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIEMPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIEMPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIEMPO_DEPRECIACION.Location = New System.Drawing.Point(430, 190)
        Me.lblTitTIEMPO_DEPRECIACION.Name = "lblTitTIEMPO_DEPRECIACION"
        Me.lblTitTIEMPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIEMPO_DEPRECIACION.Size = New System.Drawing.Size(175, 14)
        Me.lblTitTIEMPO_DEPRECIACION.TabIndex = 32
        Me.lblTitTIEMPO_DEPRECIACION.Text = "Meses a ejecutar depreciación"
        '
        'lblTitTIPO_DEPRECIACION
        '
        Me.lblTitTIPO_DEPRECIACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_DEPRECIACION.Location = New System.Drawing.Point(6, 296)
        Me.lblTitTIPO_DEPRECIACION.Name = "lblTitTIPO_DEPRECIACION"
        Me.lblTitTIPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_DEPRECIACION.Size = New System.Drawing.Size(177, 14)
        Me.lblTitTIPO_DEPRECIACION.TabIndex = 31
        Me.lblTitTIPO_DEPRECIACION.Text = "Tipo de depreciación"
        '
        'cboTIPO_DEPRECIACION
        '
        Me.cboTIPO_DEPRECIACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboTIPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTIPO_DEPRECIACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTIPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTIPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTIPO_DEPRECIACION.Location = New System.Drawing.Point(189, 293)
        Me.cboTIPO_DEPRECIACION.Name = "cboTIPO_DEPRECIACION"
        Me.cboTIPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTIPO_DEPRECIACION.Size = New System.Drawing.Size(174, 22)
        Me.cboTIPO_DEPRECIACION.TabIndex = 14
        '
        'lblDESCRIP_TIPO_ACTIVO
        '
        Me.lblDESCRIP_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIP_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIP_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIP_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIP_TIPO_ACTIVO.Location = New System.Drawing.Point(294, 83)
        Me.lblDESCRIP_TIPO_ACTIVO.Name = "lblDESCRIP_TIPO_ACTIVO"
        Me.lblDESCRIP_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIP_TIPO_ACTIVO.Size = New System.Drawing.Size(487, 20)
        Me.lblDESCRIP_TIPO_ACTIVO.TabIndex = 29
        Me.lblDESCRIP_TIPO_ACTIVO.UseMnemonic = False
        '
        'lblnombre_proveedor
        '
        Me.lblnombre_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre_proveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombre_proveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombre_proveedor.Location = New System.Drawing.Point(294, 57)
        Me.lblnombre_proveedor.Name = "lblnombre_proveedor"
        Me.lblnombre_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombre_proveedor.Size = New System.Drawing.Size(487, 20)
        Me.lblnombre_proveedor.TabIndex = 28
        Me.lblnombre_proveedor.UseMnemonic = False
        '
        'lblMEJORA_CORRELATIVO
        '
        Me.lblMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.White
        Me.lblMEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMEJORA_CORRELATIVO.Location = New System.Drawing.Point(611, 15)
        Me.lblMEJORA_CORRELATIVO.Name = "lblMEJORA_CORRELATIVO"
        Me.lblMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMEJORA_CORRELATIVO.Size = New System.Drawing.Size(58, 20)
        Me.lblMEJORA_CORRELATIVO.TabIndex = 27
        Me.lblMEJORA_CORRELATIVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitFECHA_ADQUISICION
        '
        Me.lblTitFECHA_ADQUISICION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_ADQUISICION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_ADQUISICION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_ADQUISICION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_ADQUISICION.Location = New System.Drawing.Point(6, 217)
        Me.lblTitFECHA_ADQUISICION.Name = "lblTitFECHA_ADQUISICION"
        Me.lblTitFECHA_ADQUISICION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_ADQUISICION.Size = New System.Drawing.Size(177, 14)
        Me.lblTitFECHA_ADQUISICION.TabIndex = 22
        Me.lblTitFECHA_ADQUISICION.Text = "Fecha de adquisición"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(6, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(177, 14)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Depreciable"
        '
        'cboDEPRECIABLE
        '
        Me.cboDEPRECIABLE.BackColor = System.Drawing.SystemColors.Window
        Me.cboDEPRECIABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDEPRECIABLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDEPRECIABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDEPRECIABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDEPRECIABLE.Location = New System.Drawing.Point(189, 187)
        Me.cboDEPRECIABLE.Name = "cboDEPRECIABLE"
        Me.cboDEPRECIABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDEPRECIABLE.Size = New System.Drawing.Size(174, 22)
        Me.cboDEPRECIABLE.TabIndex = 7
        '
        'lblTitVALOR_ORIGINAL_ACTIV
        '
        Me.lblTitVALOR_ORIGINAL_ACTIV.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_ORIGINAL_ACTIV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_ORIGINAL_ACTIV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_ORIGINAL_ACTIV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_ORIGINAL_ACTIV.Location = New System.Drawing.Point(6, 163)
        Me.lblTitVALOR_ORIGINAL_ACTIV.Name = "lblTitVALOR_ORIGINAL_ACTIV"
        Me.lblTitVALOR_ORIGINAL_ACTIV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_ORIGINAL_ACTIV.Size = New System.Drawing.Size(177, 14)
        Me.lblTitVALOR_ORIGINAL_ACTIV.TabIndex = 19
        Me.lblTitVALOR_ORIGINAL_ACTIV.Text = "Valor original Quetzales"
        '
        'lblTitDESCRIP_CORTA_ACTIVO
        '
        Me.lblTitDESCRIP_CORTA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIP_CORTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIP_CORTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIP_CORTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIP_CORTA_ACTIVO.Location = New System.Drawing.Point(6, 137)
        Me.lblTitDESCRIP_CORTA_ACTIVO.Name = "lblTitDESCRIP_CORTA_ACTIVO"
        Me.lblTitDESCRIP_CORTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIP_CORTA_ACTIVO.Size = New System.Drawing.Size(177, 14)
        Me.lblTitDESCRIP_CORTA_ACTIVO.TabIndex = 17
        Me.lblTitDESCRIP_CORTA_ACTIVO.Text = "Descripción activo"
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(6, 111)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(177, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 15
        Me.lblTitCODIGO_DIVISION.Text = "Departamento"
        '
        'lblTitCODIGO_TIPO_ACTIVO
        '
        Me.lblTitCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(6, 85)
        Me.lblTitCODIGO_TIPO_ACTIVO.Name = "lblTitCODIGO_TIPO_ACTIVO"
        Me.lblTitCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(177, 14)
        Me.lblTitCODIGO_TIPO_ACTIVO.TabIndex = 13
        Me.lblTitCODIGO_TIPO_ACTIVO.Text = "Tipo de activo"
        '
        'lblTitCODIGO_PROVEEDOR
        '
        Me.lblTitCODIGO_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_PROVEEDOR.Location = New System.Drawing.Point(6, 59)
        Me.lblTitCODIGO_PROVEEDOR.Name = "lblTitCODIGO_PROVEEDOR"
        Me.lblTitCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_PROVEEDOR.Size = New System.Drawing.Size(177, 14)
        Me.lblTitCODIGO_PROVEEDOR.TabIndex = 11
        Me.lblTitCODIGO_PROVEEDOR.Text = "Código de proveedor"
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(430, 17)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(39, 14)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 9
        Me.lblTitMEJORA_CORRELATIVO.Text = "Mejora"
        '
        'lblTitCODIGO_DE_ACTIVO
        '
        Me.lblTitCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(6, 17)
        Me.lblTitCODIGO_DE_ACTIVO.Name = "lblTitCODIGO_DE_ACTIVO"
        Me.lblTitCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(177, 14)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 7
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Código activo fijo"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.panCampos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(870, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Campos especiales"
        '
        'panCampos
        '
        Me.panCampos.AutoScroll = True
        Me.panCampos.Location = New System.Drawing.Point(6, 6)
        Me.panCampos.Name = "panCampos"
        Me.panCampos.Size = New System.Drawing.Size(858, 468)
        Me.panCampos.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(803, 545)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(710, 545)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'IconosMenus
        '
        Me.IconosMenus.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.IconosMenus.ImageSize = New System.Drawing.Size(32, 32)
        Me.IconosMenus.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImpresoraDialog
        '
        Me.ImpresoraDialog.UseEXDialog = True
        '
        'TemporizadorEspera
        '
        '
        'ACTMAFM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 573)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Folder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMAFM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de activos fijos - ACTMAFM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Folder.ResumeLayout(False)
        Me.TabGenerales.ResumeLayout(False)
        Me.TabGenerales.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Folder As System.Windows.Forms.TabControl
    Friend WithEvents TabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_DE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cboDEPRECIABLE As System.Windows.Forms.ComboBox
    Public WithEvents lblTitVALOR_ORIGINAL_ACTIV As System.Windows.Forms.Label
    Public WithEvents txtDESCRIP_CORTA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitDESCRIP_CORTA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_DIVISION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_TIPO_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_PROVEEDOR As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitCODIGO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_ADQUISICION As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents lblMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblnombre_proveedor As System.Windows.Forms.Label
    Public WithEvents lblDESCRIP_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents cboTIPO_DEPRECIACION As System.Windows.Forms.ComboBox
    Friend WithEvents txtTIEMPO_DEPRECIACION As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitTIEMPO_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Friend WithEvents txtVALOR_ORIGINAL_ACTIV As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Friend WithEvents txtVALOR_RESCATE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitVALOR_RESCATE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblFechaInv As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mskFECHA_ADQUISICION As Citi.Synergia.UIGenerico.SynTextoFecha
    Friend WithEvents mskFechaInv As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents txtCODIGO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_MONEDA As System.Windows.Forms.Label
    Friend WithEvents txtTASA_CAMBIO_COMPRA As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitTASA_CAMBIO_COMPRA As System.Windows.Forms.Label
    Friend WithEvents txtVALOR_NO_DEDUCIBLE As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitVALOR_NO_DEDUCIBLE As System.Windows.Forms.Label
    Public WithEvents txtREFERENCIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitREFERENCIA As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_DE_BARRAS As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCODIGO_DE_BARRAS As System.Windows.Forms.Label
    Friend WithEvents txtVALOR_ORIG_ACT_USADO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitVALOR_ORIG_ACT_USADO As System.Windows.Forms.Label
    Friend WithEvents txtFRECUENCIA_MNTMTO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitFRECUENCIA_MNTMTO As System.Windows.Forms.Label
    Friend WithEvents txtTASA_DEDUCIBLE_ISR As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitTASA_DEDUCIBLE_ISR As System.Windows.Forms.Label
    Friend WithEvents txtVALOR_MONEDA_LOCAL As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitVALOR_MONEDA_LOCAL As System.Windows.Forms.Label
    Public WithEvents txtCODIGO_MARCA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCODIGO_MARCA As System.Windows.Forms.Label
    Friend WithEvents mskFECHA_INICIO_DEPREC As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblTitFECHA_INICIO_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_MARCA As System.Windows.Forms.Label
    Public WithEvents CODIGO_UBICACION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCODIGO_UBICACION As System.Windows.Forms.Label
    Public WithEvents desCODIGO_UBICACION As System.Windows.Forms.Label
    Public WithEvents lblNOMBRE_USUAL As System.Windows.Forms.Label
    Public WithEvents txtRESPONSABLE_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitRESPONSABLE_ID As System.Windows.Forms.Label
    Public WithEvents lblCATEGORIA_DESC As System.Windows.Forms.Label
    Public WithEvents txtCATEGORIA_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCATEGORIA_ID As System.Windows.Forms.Label
    Friend WithEvents POSEE_CTRL_TF As System.Windows.Forms.CheckBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblmsgfecha As System.Windows.Forms.Label
    Friend WithEvents panCampos As System.Windows.Forms.Panel
    Friend WithEvents cmdCopiar As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents IconosMenus As ImageList
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents btnPrint As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents ImpresoraDialog As PrintDialog
    Friend WithEvents TemporizadorEspera As Timer
End Class
