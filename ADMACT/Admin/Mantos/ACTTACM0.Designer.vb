<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTTACM0
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento  ' System.Windows.Forms.Form

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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.mhTab1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtCODIGO_TIPO_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIP_TIPO_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtFORZAR_FECHA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTIEMPO_DEPRECIACION = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtMONTO_MINIMO_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.cboTIPO_DEPRECIACION = New System.Windows.Forms.ComboBox()
        Me.cboFORMA_DEPRECIACION = New System.Windows.Forms.ComboBox()
        Me.cboCALCULO_PRIMERA_DEPR = New System.Windows.Forms.ComboBox()
        Me.cboCLA_CONTABILIZACION = New System.Windows.Forms.ComboBox()
        Me.cboNO_DIAS_ANIO = New System.Windows.Forms.ComboBox()
        Me.txtTIPO_CATALOGO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtPORCENTAJE_PARA_RESCATE = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblTitCALCULO_PRIMERA_DEPR = New System.Windows.Forms.Label()
        Me.lblNOMBRE_CATALOGO = New System.Windows.Forms.Label()
        Me.lblTitCLA_CONTABILIZACION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitDESCRIP_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitTIPO_DEPRECIACION = New System.Windows.Forms.Label()
        Me.lblTitFORZAR_FECHA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitMONTO_MINIMO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitTIEMPO_DEPRECIACION = New System.Windows.Forms.Label()
        Me.lblTitTIPO_CATALOGO = New System.Windows.Forms.Label()
        Me.lblTitFORMA_DEPRECIACION = New System.Windows.Forms.Label()
        Me.lblTitNO_DIAS_ANIO = New System.Windows.Forms.Label()
        Me.lblTitPORCENTAJE_PARA_RESCATE = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.frame_Balance = New System.Windows.Forms.GroupBox()
        Me.txtCODIGO_CENTRO_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_DEPREC_ACUM = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_DEPREC_ACUM = New System.Windows.Forms.Label()
        Me.lblTitCTA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_CENTRO_ACTIVO = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_1 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_1 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_2 = New System.Windows.Forms.Label()
        Me.frame_Gastos = New System.Windows.Forms.GroupBox()
        Me.txtCOD_CENTRO_GASTO_ACT = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_GASTO_DEPREC = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_GASTO_DEPREC = New System.Windows.Forms.Label()
        Me.lblTitCOD_CENTRO_GASTO_ACT = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_2 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_3 = New System.Windows.Forms.Label()
        Me.frame_Reevaluacion = New System.Windows.Forms.GroupBox()
        Me.txtCOD_CENTRO_REVALUA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_REVALUA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_REVALUA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCOD_CENTRO_REVALUA = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_6 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_8 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.frame_ingresos_egresos = New System.Windows.Forms.GroupBox()
        Me.txtCOD_CENTRO_RESULTADO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_GAN_VTA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_PER_VTA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_PER_VTA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCTA_GAN_VTA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCOD_CENTRO_RESULTADO = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_3 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_4 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_5 = New System.Windows.Forms.Label()
        Me.frame_compras = New System.Windows.Forms.GroupBox()
        Me.txtCOD_CENTRO_COMPRA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_COMPRA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_COMPRA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCOD_CENTRO_COMPRA = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_4 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_6 = New System.Windows.Forms.Label()
        Me.frame_desecho = New System.Windows.Forms.GroupBox()
        Me.txtCOD_CENTRO_BAJA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_BAJA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_BAJA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCOD_CENTRO_BAJA = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_5 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_7 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.txtCOD_CENTRO_VENTA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_VENTA_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_VENTA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCOD_CENTRO_VENTA = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_7 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_9 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtCENTRO_DONA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCUENTA_DONA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me._lblDESCRIPCION_CUENTA_10 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_8 = New System.Windows.Forms.Label()
        Me.lblTitCENTRO_DONA = New System.Windows.Forms.Label()
        Me.lblTitCUENTA_DONA = New System.Windows.Forms.Label()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.txtCOD_CENTRO_ACT_NODED = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCTA_ACTIVO_NODEDUCIB = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCTA_ACTIVO_NODEDUCIB = New System.Windows.Forms.Label()
        Me.lblTitCOD_CENTRO_ACT_NODED = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_9 = New System.Windows.Forms.Label()
        Me._lblDESCRIPCION_CUENTA_11 = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mhTab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.frame_Balance.SuspendLayout()
        Me.frame_Gastos.SuspendLayout()
        Me.frame_Reevaluacion.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.frame_ingresos_egresos.SuspendLayout()
        Me.frame_compras.SuspendLayout()
        Me.frame_desecho.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(570, 347)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(477, 347)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'mhTab1
        '
        Me.mhTab1.Controls.Add(Me.TabPage1)
        Me.mhTab1.Controls.Add(Me.TabPage2)
        Me.mhTab1.Controls.Add(Me.TabPage3)
        Me.mhTab1.Controls.Add(Me.TabPage4)
        Me.mhTab1.Location = New System.Drawing.Point(12, 12)
        Me.mhTab1.Name = "mhTab1"
        Me.mhTab1.SelectedIndex = 0
        Me.mhTab1.Size = New System.Drawing.Size(645, 329)
        Me.mhTab1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.txtCODIGO_TIPO_ACTIVO)
        Me.TabPage1.Controls.Add(Me.txtDESCRIP_TIPO_ACTIVO)
        Me.TabPage1.Controls.Add(Me.txtFORZAR_FECHA_ACTIVO)
        Me.TabPage1.Controls.Add(Me.txtTIEMPO_DEPRECIACION)
        Me.TabPage1.Controls.Add(Me.txtMONTO_MINIMO_ACTIVO)
        Me.TabPage1.Controls.Add(Me.cboTIPO_DEPRECIACION)
        Me.TabPage1.Controls.Add(Me.cboFORMA_DEPRECIACION)
        Me.TabPage1.Controls.Add(Me.cboCALCULO_PRIMERA_DEPR)
        Me.TabPage1.Controls.Add(Me.cboCLA_CONTABILIZACION)
        Me.TabPage1.Controls.Add(Me.cboNO_DIAS_ANIO)
        Me.TabPage1.Controls.Add(Me.txtTIPO_CATALOGO)
        Me.TabPage1.Controls.Add(Me.txtPORCENTAJE_PARA_RESCATE)
        Me.TabPage1.Controls.Add(Me.lblTitCALCULO_PRIMERA_DEPR)
        Me.TabPage1.Controls.Add(Me.lblNOMBRE_CATALOGO)
        Me.TabPage1.Controls.Add(Me.lblTitCLA_CONTABILIZACION)
        Me.TabPage1.Controls.Add(Me.lblTitCODIGO_TIPO_ACTIVO)
        Me.TabPage1.Controls.Add(Me.lblTitDESCRIP_TIPO_ACTIVO)
        Me.TabPage1.Controls.Add(Me.lblTitTIPO_DEPRECIACION)
        Me.TabPage1.Controls.Add(Me.lblTitFORZAR_FECHA_ACTIVO)
        Me.TabPage1.Controls.Add(Me.lblTitMONTO_MINIMO_ACTIVO)
        Me.TabPage1.Controls.Add(Me.lblTitTIEMPO_DEPRECIACION)
        Me.TabPage1.Controls.Add(Me.lblTitTIPO_CATALOGO)
        Me.TabPage1.Controls.Add(Me.lblTitFORMA_DEPRECIACION)
        Me.TabPage1.Controls.Add(Me.lblTitNO_DIAS_ANIO)
        Me.TabPage1.Controls.Add(Me.lblTitPORCENTAJE_PARA_RESCATE)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(637, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generales ( F1 )"
        '
        'txtCODIGO_TIPO_ACTIVO
        '
        Me.txtCODIGO_TIPO_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.Color.White
        Me.txtCODIGO_TIPO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_TIPO_ACTIVO.EsRequerido = True
        Me.txtCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_TIPO_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(217, 6)
        Me.txtCODIGO_TIPO_ACTIVO.MaxLength = 7
        Me.txtCODIGO_TIPO_ACTIVO.Name = "txtCODIGO_TIPO_ACTIVO"
        Me.txtCODIGO_TIPO_ACTIVO.NombreDeConsulta = Nothing
        Me.txtCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(81, 20)
        Me.txtCODIGO_TIPO_ACTIVO.TabIndex = 0
        '
        'txtDESCRIP_TIPO_ACTIVO
        '
        Me.txtDESCRIP_TIPO_ACTIVO.AcceptsReturn = True
        Me.txtDESCRIP_TIPO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIP_TIPO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIP_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIP_TIPO_ACTIVO.EsRequerido = True
        Me.txtDESCRIP_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIP_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIP_TIPO_ACTIVO.LabelConsulta = Nothing
        Me.txtDESCRIP_TIPO_ACTIVO.Location = New System.Drawing.Point(217, 29)
        Me.txtDESCRIP_TIPO_ACTIVO.MaxLength = 40
        Me.txtDESCRIP_TIPO_ACTIVO.Name = "txtDESCRIP_TIPO_ACTIVO"
        Me.txtDESCRIP_TIPO_ACTIVO.NombreDeConsulta = Nothing
        Me.txtDESCRIP_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIP_TIPO_ACTIVO.Size = New System.Drawing.Size(397, 20)
        Me.txtDESCRIP_TIPO_ACTIVO.TabIndex = 1
        '
        'txtFORZAR_FECHA_ACTIVO
        '
        Me.txtFORZAR_FECHA_ACTIVO.AcceptsReturn = True
        Me.txtFORZAR_FECHA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtFORZAR_FECHA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFORZAR_FECHA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFORZAR_FECHA_ACTIVO.EsRequerido = True
        Me.txtFORZAR_FECHA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFORZAR_FECHA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFORZAR_FECHA_ACTIVO.LabelConsulta = Nothing
        Me.txtFORZAR_FECHA_ACTIVO.Location = New System.Drawing.Point(217, 139)
        Me.txtFORZAR_FECHA_ACTIVO.MaxLength = 2
        Me.txtFORZAR_FECHA_ACTIVO.Multiline = True
        Me.txtFORZAR_FECHA_ACTIVO.Name = "txtFORZAR_FECHA_ACTIVO"
        Me.txtFORZAR_FECHA_ACTIVO.NombreDeConsulta = Nothing
        Me.txtFORZAR_FECHA_ACTIVO.NumeroDecimales = 0
        Me.txtFORZAR_FECHA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFORZAR_FECHA_ACTIVO.Size = New System.Drawing.Size(52, 21)
        Me.txtFORZAR_FECHA_ACTIVO.TabIndex = 6
        Me.txtFORZAR_FECHA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTIEMPO_DEPRECIACION
        '
        Me.txtTIEMPO_DEPRECIACION.AcceptsReturn = True
        Me.txtTIEMPO_DEPRECIACION.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIEMPO_DEPRECIACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIEMPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIEMPO_DEPRECIACION.EsRequerido = True
        Me.txtTIEMPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIEMPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIEMPO_DEPRECIACION.LabelConsulta = Nothing
        Me.txtTIEMPO_DEPRECIACION.Location = New System.Drawing.Point(217, 166)
        Me.txtTIEMPO_DEPRECIACION.MaxLength = 5
        Me.txtTIEMPO_DEPRECIACION.Multiline = True
        Me.txtTIEMPO_DEPRECIACION.Name = "txtTIEMPO_DEPRECIACION"
        Me.txtTIEMPO_DEPRECIACION.NombreDeConsulta = Nothing
        Me.txtTIEMPO_DEPRECIACION.NumeroDecimales = 0
        Me.txtTIEMPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIEMPO_DEPRECIACION.Size = New System.Drawing.Size(52, 21)
        Me.txtTIEMPO_DEPRECIACION.TabIndex = 7
        Me.txtTIEMPO_DEPRECIACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMONTO_MINIMO_ACTIVO
        '
        Me.txtMONTO_MINIMO_ACTIVO.AcceptsReturn = True
        Me.txtMONTO_MINIMO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtMONTO_MINIMO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMONTO_MINIMO_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMONTO_MINIMO_ACTIVO.EsRequerido = True
        Me.txtMONTO_MINIMO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTO_MINIMO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMONTO_MINIMO_ACTIVO.LabelConsulta = Nothing
        Me.txtMONTO_MINIMO_ACTIVO.Location = New System.Drawing.Point(217, 193)
        Me.txtMONTO_MINIMO_ACTIVO.MaxLength = 13
        Me.txtMONTO_MINIMO_ACTIVO.Multiline = True
        Me.txtMONTO_MINIMO_ACTIVO.Name = "txtMONTO_MINIMO_ACTIVO"
        Me.txtMONTO_MINIMO_ACTIVO.NombreDeConsulta = Nothing
        Me.txtMONTO_MINIMO_ACTIVO.NumeroDecimales = 2
        Me.txtMONTO_MINIMO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMONTO_MINIMO_ACTIVO.Size = New System.Drawing.Size(113, 21)
        Me.txtMONTO_MINIMO_ACTIVO.TabIndex = 8
        Me.txtMONTO_MINIMO_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboTIPO_DEPRECIACION
        '
        Me.cboTIPO_DEPRECIACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboTIPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTIPO_DEPRECIACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTIPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTIPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTIPO_DEPRECIACION.Location = New System.Drawing.Point(217, 55)
        Me.cboTIPO_DEPRECIACION.Name = "cboTIPO_DEPRECIACION"
        Me.cboTIPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTIPO_DEPRECIACION.Size = New System.Drawing.Size(275, 22)
        Me.cboTIPO_DEPRECIACION.TabIndex = 2
        '
        'cboFORMA_DEPRECIACION
        '
        Me.cboFORMA_DEPRECIACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboFORMA_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFORMA_DEPRECIACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFORMA_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFORMA_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFORMA_DEPRECIACION.Location = New System.Drawing.Point(217, 83)
        Me.cboFORMA_DEPRECIACION.Name = "cboFORMA_DEPRECIACION"
        Me.cboFORMA_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFORMA_DEPRECIACION.Size = New System.Drawing.Size(131, 22)
        Me.cboFORMA_DEPRECIACION.TabIndex = 3
        '
        'cboCALCULO_PRIMERA_DEPR
        '
        Me.cboCALCULO_PRIMERA_DEPR.BackColor = System.Drawing.SystemColors.Window
        Me.cboCALCULO_PRIMERA_DEPR.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCALCULO_PRIMERA_DEPR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCALCULO_PRIMERA_DEPR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCALCULO_PRIMERA_DEPR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCALCULO_PRIMERA_DEPR.Location = New System.Drawing.Point(217, 111)
        Me.cboCALCULO_PRIMERA_DEPR.Name = "cboCALCULO_PRIMERA_DEPR"
        Me.cboCALCULO_PRIMERA_DEPR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCALCULO_PRIMERA_DEPR.Size = New System.Drawing.Size(275, 22)
        Me.cboCALCULO_PRIMERA_DEPR.TabIndex = 5
        '
        'cboCLA_CONTABILIZACION
        '
        Me.cboCLA_CONTABILIZACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboCLA_CONTABILIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCLA_CONTABILIZACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCLA_CONTABILIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCLA_CONTABILIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCLA_CONTABILIZACION.Location = New System.Drawing.Point(217, 220)
        Me.cboCLA_CONTABILIZACION.Name = "cboCLA_CONTABILIZACION"
        Me.cboCLA_CONTABILIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCLA_CONTABILIZACION.Size = New System.Drawing.Size(275, 22)
        Me.cboCLA_CONTABILIZACION.TabIndex = 9
        '
        'cboNO_DIAS_ANIO
        '
        Me.cboNO_DIAS_ANIO.BackColor = System.Drawing.SystemColors.Window
        Me.cboNO_DIAS_ANIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNO_DIAS_ANIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNO_DIAS_ANIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNO_DIAS_ANIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboNO_DIAS_ANIO.Location = New System.Drawing.Point(501, 83)
        Me.cboNO_DIAS_ANIO.Name = "cboNO_DIAS_ANIO"
        Me.cboNO_DIAS_ANIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboNO_DIAS_ANIO.Size = New System.Drawing.Size(113, 22)
        Me.cboNO_DIAS_ANIO.TabIndex = 4
        '
        'txtTIPO_CATALOGO
        '
        Me.txtTIPO_CATALOGO.AcceptsReturn = True
        Me.txtTIPO_CATALOGO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIPO_CATALOGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIPO_CATALOGO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIPO_CATALOGO.EsRequerido = False
        Me.txtTIPO_CATALOGO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_CATALOGO.LabelConsulta = Nothing
        Me.txtTIPO_CATALOGO.Location = New System.Drawing.Point(217, 248)
        Me.txtTIPO_CATALOGO.MaxLength = 3
        Me.txtTIPO_CATALOGO.Name = "txtTIPO_CATALOGO"
        Me.txtTIPO_CATALOGO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCatalogosContables_CACOEC01
        Me.txtTIPO_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_CATALOGO.Size = New System.Drawing.Size(52, 20)
        Me.txtTIPO_CATALOGO.TabIndex = 10
        Me.txtTIPO_CATALOGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPORCENTAJE_PARA_RESCATE
        '
        Me.txtPORCENTAJE_PARA_RESCATE.AcceptsReturn = True
        Me.txtPORCENTAJE_PARA_RESCATE.BackColor = System.Drawing.SystemColors.Window
        Me.txtPORCENTAJE_PARA_RESCATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPORCENTAJE_PARA_RESCATE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPORCENTAJE_PARA_RESCATE.EsRequerido = False
        Me.txtPORCENTAJE_PARA_RESCATE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPORCENTAJE_PARA_RESCATE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPORCENTAJE_PARA_RESCATE.LabelConsulta = Nothing
        Me.txtPORCENTAJE_PARA_RESCATE.Location = New System.Drawing.Point(217, 274)
        Me.txtPORCENTAJE_PARA_RESCATE.MaxLength = 5
        Me.txtPORCENTAJE_PARA_RESCATE.Multiline = True
        Me.txtPORCENTAJE_PARA_RESCATE.Name = "txtPORCENTAJE_PARA_RESCATE"
        Me.txtPORCENTAJE_PARA_RESCATE.NombreDeConsulta = Nothing
        Me.txtPORCENTAJE_PARA_RESCATE.NumeroDecimales = 2
        Me.txtPORCENTAJE_PARA_RESCATE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPORCENTAJE_PARA_RESCATE.Size = New System.Drawing.Size(113, 21)
        Me.txtPORCENTAJE_PARA_RESCATE.TabIndex = 11
        Me.txtPORCENTAJE_PARA_RESCATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCALCULO_PRIMERA_DEPR
        '
        Me.lblTitCALCULO_PRIMERA_DEPR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCALCULO_PRIMERA_DEPR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCALCULO_PRIMERA_DEPR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCALCULO_PRIMERA_DEPR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCALCULO_PRIMERA_DEPR.Location = New System.Drawing.Point(6, 114)
        Me.lblTitCALCULO_PRIMERA_DEPR.Name = "lblTitCALCULO_PRIMERA_DEPR"
        Me.lblTitCALCULO_PRIMERA_DEPR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCALCULO_PRIMERA_DEPR.Size = New System.Drawing.Size(205, 14)
        Me.lblTitCALCULO_PRIMERA_DEPR.TabIndex = 50
        Me.lblTitCALCULO_PRIMERA_DEPR.Text = "Calcula primera depreciación"
        '
        'lblNOMBRE_CATALOGO
        '
        Me.lblNOMBRE_CATALOGO.BackColor = System.Drawing.Color.Transparent
        Me.lblNOMBRE_CATALOGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNOMBRE_CATALOGO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMBRE_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNOMBRE_CATALOGO.Location = New System.Drawing.Point(275, 250)
        Me.lblNOMBRE_CATALOGO.Name = "lblNOMBRE_CATALOGO"
        Me.lblNOMBRE_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNOMBRE_CATALOGO.Size = New System.Drawing.Size(339, 20)
        Me.lblNOMBRE_CATALOGO.TabIndex = 49
        Me.lblNOMBRE_CATALOGO.Text = "lblNOMBRE_CATALOGO"
        Me.lblNOMBRE_CATALOGO.UseMnemonic = False
        '
        'lblTitCLA_CONTABILIZACION
        '
        Me.lblTitCLA_CONTABILIZACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCLA_CONTABILIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCLA_CONTABILIZACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCLA_CONTABILIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCLA_CONTABILIZACION.Location = New System.Drawing.Point(6, 223)
        Me.lblTitCLA_CONTABILIZACION.Name = "lblTitCLA_CONTABILIZACION"
        Me.lblTitCLA_CONTABILIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCLA_CONTABILIZACION.Size = New System.Drawing.Size(205, 14)
        Me.lblTitCLA_CONTABILIZACION.TabIndex = 48
        Me.lblTitCLA_CONTABILIZACION.Text = "Clase de contabilización"
        '
        'lblTitCODIGO_TIPO_ACTIVO
        '
        Me.lblTitCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(6, 8)
        Me.lblTitCODIGO_TIPO_ACTIVO.Name = "lblTitCODIGO_TIPO_ACTIVO"
        Me.lblTitCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(205, 14)
        Me.lblTitCODIGO_TIPO_ACTIVO.TabIndex = 47
        Me.lblTitCODIGO_TIPO_ACTIVO.Text = "Código"
        '
        'lblTitDESCRIP_TIPO_ACTIVO
        '
        Me.lblTitDESCRIP_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIP_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIP_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIP_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIP_TIPO_ACTIVO.Location = New System.Drawing.Point(6, 31)
        Me.lblTitDESCRIP_TIPO_ACTIVO.Name = "lblTitDESCRIP_TIPO_ACTIVO"
        Me.lblTitDESCRIP_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIP_TIPO_ACTIVO.Size = New System.Drawing.Size(205, 14)
        Me.lblTitDESCRIP_TIPO_ACTIVO.TabIndex = 46
        Me.lblTitDESCRIP_TIPO_ACTIVO.Text = "Descripción"
        '
        'lblTitTIPO_DEPRECIACION
        '
        Me.lblTitTIPO_DEPRECIACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_DEPRECIACION.Location = New System.Drawing.Point(6, 58)
        Me.lblTitTIPO_DEPRECIACION.Name = "lblTitTIPO_DEPRECIACION"
        Me.lblTitTIPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_DEPRECIACION.Size = New System.Drawing.Size(205, 14)
        Me.lblTitTIPO_DEPRECIACION.TabIndex = 45
        Me.lblTitTIPO_DEPRECIACION.Text = "Tipo de depreciación"
        '
        'lblTitFORZAR_FECHA_ACTIVO
        '
        Me.lblTitFORZAR_FECHA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFORZAR_FECHA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFORZAR_FECHA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFORZAR_FECHA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFORZAR_FECHA_ACTIVO.Location = New System.Drawing.Point(6, 141)
        Me.lblTitFORZAR_FECHA_ACTIVO.Name = "lblTitFORZAR_FECHA_ACTIVO"
        Me.lblTitFORZAR_FECHA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFORZAR_FECHA_ACTIVO.Size = New System.Drawing.Size(205, 14)
        Me.lblTitFORZAR_FECHA_ACTIVO.TabIndex = 44
        Me.lblTitFORZAR_FECHA_ACTIVO.Text = "Día límite fecha depreciación"
        '
        'lblTitMONTO_MINIMO_ACTIVO
        '
        Me.lblTitMONTO_MINIMO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_MINIMO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_MINIMO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_MINIMO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_MINIMO_ACTIVO.Location = New System.Drawing.Point(6, 195)
        Me.lblTitMONTO_MINIMO_ACTIVO.Name = "lblTitMONTO_MINIMO_ACTIVO"
        Me.lblTitMONTO_MINIMO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_MINIMO_ACTIVO.Size = New System.Drawing.Size(205, 14)
        Me.lblTitMONTO_MINIMO_ACTIVO.TabIndex = 43
        Me.lblTitMONTO_MINIMO_ACTIVO.Text = "Monto mínimo de deprec. de activo"
        '
        'lblTitTIEMPO_DEPRECIACION
        '
        Me.lblTitTIEMPO_DEPRECIACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIEMPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIEMPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIEMPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIEMPO_DEPRECIACION.Location = New System.Drawing.Point(6, 168)
        Me.lblTitTIEMPO_DEPRECIACION.Name = "lblTitTIEMPO_DEPRECIACION"
        Me.lblTitTIEMPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIEMPO_DEPRECIACION.Size = New System.Drawing.Size(205, 14)
        Me.lblTitTIEMPO_DEPRECIACION.TabIndex = 42
        Me.lblTitTIEMPO_DEPRECIACION.Text = "Tiempo de depreciación (meses)"
        '
        'lblTitTIPO_CATALOGO
        '
        Me.lblTitTIPO_CATALOGO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_CATALOGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_CATALOGO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_CATALOGO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_CATALOGO.Location = New System.Drawing.Point(6, 250)
        Me.lblTitTIPO_CATALOGO.Name = "lblTitTIPO_CATALOGO"
        Me.lblTitTIPO_CATALOGO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_CATALOGO.Size = New System.Drawing.Size(205, 14)
        Me.lblTitTIPO_CATALOGO.TabIndex = 41
        Me.lblTitTIPO_CATALOGO.Text = "Tipo de catálogo"
        '
        'lblTitFORMA_DEPRECIACION
        '
        Me.lblTitFORMA_DEPRECIACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFORMA_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFORMA_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFORMA_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFORMA_DEPRECIACION.Location = New System.Drawing.Point(6, 86)
        Me.lblTitFORMA_DEPRECIACION.Name = "lblTitFORMA_DEPRECIACION"
        Me.lblTitFORMA_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFORMA_DEPRECIACION.Size = New System.Drawing.Size(205, 14)
        Me.lblTitFORMA_DEPRECIACION.TabIndex = 40
        Me.lblTitFORMA_DEPRECIACION.Text = "Forma de depreciación"
        '
        'lblTitNO_DIAS_ANIO
        '
        Me.lblTitNO_DIAS_ANIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_DIAS_ANIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_DIAS_ANIO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_DIAS_ANIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_DIAS_ANIO.Location = New System.Drawing.Point(362, 86)
        Me.lblTitNO_DIAS_ANIO.Name = "lblTitNO_DIAS_ANIO"
        Me.lblTitNO_DIAS_ANIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_DIAS_ANIO.Size = New System.Drawing.Size(133, 14)
        Me.lblTitNO_DIAS_ANIO.TabIndex = 39
        Me.lblTitNO_DIAS_ANIO.Text = "Días cálculo depreciación"
        '
        'lblTitPORCENTAJE_PARA_RESCATE
        '
        Me.lblTitPORCENTAJE_PARA_RESCATE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitPORCENTAJE_PARA_RESCATE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitPORCENTAJE_PARA_RESCATE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPORCENTAJE_PARA_RESCATE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitPORCENTAJE_PARA_RESCATE.Location = New System.Drawing.Point(6, 276)
        Me.lblTitPORCENTAJE_PARA_RESCATE.Name = "lblTitPORCENTAJE_PARA_RESCATE"
        Me.lblTitPORCENTAJE_PARA_RESCATE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitPORCENTAJE_PARA_RESCATE.Size = New System.Drawing.Size(205, 14)
        Me.lblTitPORCENTAJE_PARA_RESCATE.TabIndex = 38
        Me.lblTitPORCENTAJE_PARA_RESCATE.Text = "Porcentaje mínimo valor rescate"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.frame_Balance)
        Me.TabPage2.Controls.Add(Me.frame_Gastos)
        Me.TabPage2.Controls.Add(Me.frame_Reevaluacion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(637, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cuentas contables ( F2 )"
        '
        'frame_Balance
        '
        Me.frame_Balance.BackColor = System.Drawing.SystemColors.Control
        Me.frame_Balance.Controls.Add(Me.txtCODIGO_CENTRO_ACTIVO)
        Me.frame_Balance.Controls.Add(Me.txtCTA_ACTIVO)
        Me.frame_Balance.Controls.Add(Me.txtCTA_DEPREC_ACUM)
        Me.frame_Balance.Controls.Add(Me.lblTitCTA_DEPREC_ACUM)
        Me.frame_Balance.Controls.Add(Me.lblTitCTA_ACTIVO)
        Me.frame_Balance.Controls.Add(Me.lblTitCODIGO_CENTRO_ACTIVO)
        Me.frame_Balance.Controls.Add(Me._lblDESCRIPCION_1)
        Me.frame_Balance.Controls.Add(Me._lblDESCRIPCION_CUENTA_1)
        Me.frame_Balance.Controls.Add(Me._lblDESCRIPCION_CUENTA_2)
        Me.frame_Balance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_Balance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frame_Balance.Location = New System.Drawing.Point(6, 6)
        Me.frame_Balance.Name = "frame_Balance"
        Me.frame_Balance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame_Balance.Size = New System.Drawing.Size(625, 97)
        Me.frame_Balance.TabIndex = 1
        Me.frame_Balance.TabStop = False
        Me.frame_Balance.Text = "Cuentas de Balance "
        '
        'txtCODIGO_CENTRO_ACTIVO
        '
        Me.txtCODIGO_CENTRO_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_CENTRO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_CENTRO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_CENTRO_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_CENTRO_ACTIVO.EsRequerido = False
        Me.txtCODIGO_CENTRO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_CENTRO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_CENTRO_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_CENTRO_ACTIVO.Location = New System.Drawing.Point(185, 19)
        Me.txtCODIGO_CENTRO_ACTIVO.MaxLength = 15
        Me.txtCODIGO_CENTRO_ACTIVO.Name = "txtCODIGO_CENTRO_ACTIVO"
        Me.txtCODIGO_CENTRO_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCODIGO_CENTRO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_CENTRO_ACTIVO.Size = New System.Drawing.Size(130, 20)
        Me.txtCODIGO_CENTRO_ACTIVO.TabIndex = 1
        Me.txtCODIGO_CENTRO_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_ACTIVO
        '
        Me.txtCTA_ACTIVO.AcceptsReturn = True
        Me.txtCTA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_ACTIVO.EsRequerido = False
        Me.txtCTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_ACTIVO.LabelConsulta = Nothing
        Me.txtCTA_ACTIVO.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_ACTIVO.MaxLength = 30
        Me.txtCTA_ACTIVO.Name = "txtCTA_ACTIVO"
        Me.txtCTA_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_ACTIVO.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_ACTIVO.TabIndex = 2
        Me.txtCTA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_DEPREC_ACUM
        '
        Me.txtCTA_DEPREC_ACUM.AcceptsReturn = True
        Me.txtCTA_DEPREC_ACUM.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_DEPREC_ACUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_DEPREC_ACUM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_DEPREC_ACUM.EsRequerido = False
        Me.txtCTA_DEPREC_ACUM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_DEPREC_ACUM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_DEPREC_ACUM.LabelConsulta = Nothing
        Me.txtCTA_DEPREC_ACUM.Location = New System.Drawing.Point(185, 71)
        Me.txtCTA_DEPREC_ACUM.MaxLength = 30
        Me.txtCTA_DEPREC_ACUM.Name = "txtCTA_DEPREC_ACUM"
        Me.txtCTA_DEPREC_ACUM.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_DEPREC_ACUM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_DEPREC_ACUM.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_DEPREC_ACUM.TabIndex = 3
        Me.txtCTA_DEPREC_ACUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_DEPREC_ACUM
        '
        Me.lblTitCTA_DEPREC_ACUM.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_DEPREC_ACUM.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_DEPREC_ACUM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_DEPREC_ACUM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_DEPREC_ACUM.Location = New System.Drawing.Point(6, 73)
        Me.lblTitCTA_DEPREC_ACUM.Name = "lblTitCTA_DEPREC_ACUM"
        Me.lblTitCTA_DEPREC_ACUM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_DEPREC_ACUM.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_DEPREC_ACUM.TabIndex = 9
        Me.lblTitCTA_DEPREC_ACUM.Text = "Cuenta de depreciación"
        '
        'lblTitCTA_ACTIVO
        '
        Me.lblTitCTA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_ACTIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_ACTIVO.Name = "lblTitCTA_ACTIVO"
        Me.lblTitCTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_ACTIVO.TabIndex = 8
        Me.lblTitCTA_ACTIVO.Text = "Cuenta de activo"
        '
        'lblTitCODIGO_CENTRO_ACTIVO
        '
        Me.lblTitCODIGO_CENTRO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_CENTRO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_CENTRO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_CENTRO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_CENTRO_ACTIVO.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCODIGO_CENTRO_ACTIVO.Name = "lblTitCODIGO_CENTRO_ACTIVO"
        Me.lblTitCODIGO_CENTRO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_CENTRO_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCODIGO_CENTRO_ACTIVO.TabIndex = 7
        Me.lblTitCODIGO_CENTRO_ACTIVO.Text = "Centro"
        '
        '_lblDESCRIPCION_1
        '
        Me._lblDESCRIPCION_1.AutoSize = True
        Me._lblDESCRIPCION_1.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_1.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_1.Name = "_lblDESCRIPCION_1"
        Me._lblDESCRIPCION_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_1.Size = New System.Drawing.Size(97, 14)
        Me._lblDESCRIPCION_1.TabIndex = 6
        Me._lblDESCRIPCION_1.Text = "lblDESCRIPCION(1)"
        Me._lblDESCRIPCION_1.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_1
        '
        Me._lblDESCRIPCION_CUENTA_1.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_1.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_1.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_1.Name = "_lblDESCRIPCION_CUENTA_1"
        Me._lblDESCRIPCION_CUENTA_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_1.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_1.TabIndex = 5
        Me._lblDESCRIPCION_CUENTA_1.Text = "lblDESCRIPCION_CUENTA(1)"
        Me._lblDESCRIPCION_CUENTA_1.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_2
        '
        Me._lblDESCRIPCION_CUENTA_2.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_2.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_2.Location = New System.Drawing.Point(425, 73)
        Me._lblDESCRIPCION_CUENTA_2.Name = "_lblDESCRIPCION_CUENTA_2"
        Me._lblDESCRIPCION_CUENTA_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_2.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_2.TabIndex = 4
        Me._lblDESCRIPCION_CUENTA_2.Text = "lblDESCRIPCION_CUENTA(2)"
        Me._lblDESCRIPCION_CUENTA_2.UseMnemonic = False
        '
        'frame_Gastos
        '
        Me.frame_Gastos.BackColor = System.Drawing.SystemColors.Control
        Me.frame_Gastos.Controls.Add(Me.txtCOD_CENTRO_GASTO_ACT)
        Me.frame_Gastos.Controls.Add(Me.txtCTA_GASTO_DEPREC)
        Me.frame_Gastos.Controls.Add(Me.lblTitCTA_GASTO_DEPREC)
        Me.frame_Gastos.Controls.Add(Me.lblTitCOD_CENTRO_GASTO_ACT)
        Me.frame_Gastos.Controls.Add(Me._lblDESCRIPCION_2)
        Me.frame_Gastos.Controls.Add(Me._lblDESCRIPCION_CUENTA_3)
        Me.frame_Gastos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_Gastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frame_Gastos.Location = New System.Drawing.Point(6, 109)
        Me.frame_Gastos.Name = "frame_Gastos"
        Me.frame_Gastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame_Gastos.Size = New System.Drawing.Size(625, 77)
        Me.frame_Gastos.TabIndex = 2
        Me.frame_Gastos.TabStop = False
        Me.frame_Gastos.Text = "Cuentas de Gastos "
        '
        'txtCOD_CENTRO_GASTO_ACT
        '
        Me.txtCOD_CENTRO_GASTO_ACT.AcceptsReturn = True
        Me.txtCOD_CENTRO_GASTO_ACT.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOD_CENTRO_GASTO_ACT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOD_CENTRO_GASTO_ACT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOD_CENTRO_GASTO_ACT.EsRequerido = False
        Me.txtCOD_CENTRO_GASTO_ACT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOD_CENTRO_GASTO_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOD_CENTRO_GASTO_ACT.LabelConsulta = Nothing
        Me.txtCOD_CENTRO_GASTO_ACT.Location = New System.Drawing.Point(185, 19)
        Me.txtCOD_CENTRO_GASTO_ACT.MaxLength = 15
        Me.txtCOD_CENTRO_GASTO_ACT.Name = "txtCOD_CENTRO_GASTO_ACT"
        Me.txtCOD_CENTRO_GASTO_ACT.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCOD_CENTRO_GASTO_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOD_CENTRO_GASTO_ACT.Size = New System.Drawing.Size(130, 20)
        Me.txtCOD_CENTRO_GASTO_ACT.TabIndex = 1
        Me.txtCOD_CENTRO_GASTO_ACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_GASTO_DEPREC
        '
        Me.txtCTA_GASTO_DEPREC.AcceptsReturn = True
        Me.txtCTA_GASTO_DEPREC.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_GASTO_DEPREC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_GASTO_DEPREC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_GASTO_DEPREC.EsRequerido = False
        Me.txtCTA_GASTO_DEPREC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_GASTO_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_GASTO_DEPREC.LabelConsulta = Nothing
        Me.txtCTA_GASTO_DEPREC.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_GASTO_DEPREC.MaxLength = 30
        Me.txtCTA_GASTO_DEPREC.Name = "txtCTA_GASTO_DEPREC"
        Me.txtCTA_GASTO_DEPREC.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_GASTO_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_GASTO_DEPREC.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_GASTO_DEPREC.TabIndex = 2
        Me.txtCTA_GASTO_DEPREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_GASTO_DEPREC
        '
        Me.lblTitCTA_GASTO_DEPREC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_GASTO_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_GASTO_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_GASTO_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_GASTO_DEPREC.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_GASTO_DEPREC.Name = "lblTitCTA_GASTO_DEPREC"
        Me.lblTitCTA_GASTO_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_GASTO_DEPREC.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_GASTO_DEPREC.TabIndex = 16
        Me.lblTitCTA_GASTO_DEPREC.Text = "Cuenta"
        '
        'lblTitCOD_CENTRO_GASTO_ACT
        '
        Me.lblTitCOD_CENTRO_GASTO_ACT.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOD_CENTRO_GASTO_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOD_CENTRO_GASTO_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOD_CENTRO_GASTO_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOD_CENTRO_GASTO_ACT.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCOD_CENTRO_GASTO_ACT.Name = "lblTitCOD_CENTRO_GASTO_ACT"
        Me.lblTitCOD_CENTRO_GASTO_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOD_CENTRO_GASTO_ACT.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCOD_CENTRO_GASTO_ACT.TabIndex = 15
        Me.lblTitCOD_CENTRO_GASTO_ACT.Text = "Centro"
        '
        '_lblDESCRIPCION_2
        '
        Me._lblDESCRIPCION_2.AutoSize = True
        Me._lblDESCRIPCION_2.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_2.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_2.Name = "_lblDESCRIPCION_2"
        Me._lblDESCRIPCION_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_2.Size = New System.Drawing.Size(97, 14)
        Me._lblDESCRIPCION_2.TabIndex = 14
        Me._lblDESCRIPCION_2.Text = "lblDESCRIPCION(2)"
        Me._lblDESCRIPCION_2.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_3
        '
        Me._lblDESCRIPCION_CUENTA_3.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_3.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_3.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_3.Name = "_lblDESCRIPCION_CUENTA_3"
        Me._lblDESCRIPCION_CUENTA_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_3.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_3.TabIndex = 13
        Me._lblDESCRIPCION_CUENTA_3.Text = "lblDESCRIPCION_CUENTA(3)"
        Me._lblDESCRIPCION_CUENTA_3.UseMnemonic = False
        '
        'frame_Reevaluacion
        '
        Me.frame_Reevaluacion.BackColor = System.Drawing.SystemColors.Control
        Me.frame_Reevaluacion.Controls.Add(Me.txtCOD_CENTRO_REVALUA)
        Me.frame_Reevaluacion.Controls.Add(Me.txtCTA_REVALUA_ACTIVO)
        Me.frame_Reevaluacion.Controls.Add(Me.lblTitCTA_REVALUA_ACTIVO)
        Me.frame_Reevaluacion.Controls.Add(Me.lblTitCOD_CENTRO_REVALUA)
        Me.frame_Reevaluacion.Controls.Add(Me._lblDESCRIPCION_6)
        Me.frame_Reevaluacion.Controls.Add(Me._lblDESCRIPCION_CUENTA_8)
        Me.frame_Reevaluacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_Reevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frame_Reevaluacion.Location = New System.Drawing.Point(6, 192)
        Me.frame_Reevaluacion.Name = "frame_Reevaluacion"
        Me.frame_Reevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame_Reevaluacion.Size = New System.Drawing.Size(625, 77)
        Me.frame_Reevaluacion.TabIndex = 3
        Me.frame_Reevaluacion.TabStop = False
        Me.frame_Reevaluacion.Text = "Cuentas de Reevaluación "
        '
        'txtCOD_CENTRO_REVALUA
        '
        Me.txtCOD_CENTRO_REVALUA.AcceptsReturn = True
        Me.txtCOD_CENTRO_REVALUA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOD_CENTRO_REVALUA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOD_CENTRO_REVALUA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOD_CENTRO_REVALUA.EsRequerido = False
        Me.txtCOD_CENTRO_REVALUA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOD_CENTRO_REVALUA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOD_CENTRO_REVALUA.LabelConsulta = Nothing
        Me.txtCOD_CENTRO_REVALUA.Location = New System.Drawing.Point(185, 19)
        Me.txtCOD_CENTRO_REVALUA.MaxLength = 15
        Me.txtCOD_CENTRO_REVALUA.Name = "txtCOD_CENTRO_REVALUA"
        Me.txtCOD_CENTRO_REVALUA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCOD_CENTRO_REVALUA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOD_CENTRO_REVALUA.Size = New System.Drawing.Size(130, 20)
        Me.txtCOD_CENTRO_REVALUA.TabIndex = 1
        Me.txtCOD_CENTRO_REVALUA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_REVALUA_ACTIVO
        '
        Me.txtCTA_REVALUA_ACTIVO.AcceptsReturn = True
        Me.txtCTA_REVALUA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_REVALUA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_REVALUA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_REVALUA_ACTIVO.EsRequerido = False
        Me.txtCTA_REVALUA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_REVALUA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_REVALUA_ACTIVO.LabelConsulta = Nothing
        Me.txtCTA_REVALUA_ACTIVO.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_REVALUA_ACTIVO.MaxLength = 30
        Me.txtCTA_REVALUA_ACTIVO.Name = "txtCTA_REVALUA_ACTIVO"
        Me.txtCTA_REVALUA_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_REVALUA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_REVALUA_ACTIVO.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_REVALUA_ACTIVO.TabIndex = 2
        Me.txtCTA_REVALUA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_REVALUA_ACTIVO
        '
        Me.lblTitCTA_REVALUA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_REVALUA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_REVALUA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_REVALUA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_REVALUA_ACTIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_REVALUA_ACTIVO.Name = "lblTitCTA_REVALUA_ACTIVO"
        Me.lblTitCTA_REVALUA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_REVALUA_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_REVALUA_ACTIVO.TabIndex = 23
        Me.lblTitCTA_REVALUA_ACTIVO.Text = "Cuenta"
        '
        'lblTitCOD_CENTRO_REVALUA
        '
        Me.lblTitCOD_CENTRO_REVALUA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOD_CENTRO_REVALUA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOD_CENTRO_REVALUA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOD_CENTRO_REVALUA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOD_CENTRO_REVALUA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCOD_CENTRO_REVALUA.Name = "lblTitCOD_CENTRO_REVALUA"
        Me.lblTitCOD_CENTRO_REVALUA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOD_CENTRO_REVALUA.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCOD_CENTRO_REVALUA.TabIndex = 22
        Me.lblTitCOD_CENTRO_REVALUA.Text = "Centro"
        '
        '_lblDESCRIPCION_6
        '
        Me._lblDESCRIPCION_6.AutoSize = True
        Me._lblDESCRIPCION_6.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_6.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_6.Name = "_lblDESCRIPCION_6"
        Me._lblDESCRIPCION_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_6.Size = New System.Drawing.Size(97, 14)
        Me._lblDESCRIPCION_6.TabIndex = 21
        Me._lblDESCRIPCION_6.Text = "lblDESCRIPCION(6)"
        Me._lblDESCRIPCION_6.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_8
        '
        Me._lblDESCRIPCION_CUENTA_8.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_8.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_8.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_8.Name = "_lblDESCRIPCION_CUENTA_8"
        Me._lblDESCRIPCION_CUENTA_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_8.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_8.TabIndex = 20
        Me._lblDESCRIPCION_CUENTA_8.Text = "lblDESCRIPCION_CUENTA(8)"
        Me._lblDESCRIPCION_CUENTA_8.UseMnemonic = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.frame_ingresos_egresos)
        Me.TabPage3.Controls.Add(Me.frame_compras)
        Me.TabPage3.Controls.Add(Me.frame_desecho)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(637, 303)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cuentas contables ( F3 )"
        '
        'frame_ingresos_egresos
        '
        Me.frame_ingresos_egresos.BackColor = System.Drawing.SystemColors.Control
        Me.frame_ingresos_egresos.Controls.Add(Me.txtCOD_CENTRO_RESULTADO)
        Me.frame_ingresos_egresos.Controls.Add(Me.txtCTA_GAN_VTA_ACTIVO)
        Me.frame_ingresos_egresos.Controls.Add(Me.txtCTA_PER_VTA_ACTIVO)
        Me.frame_ingresos_egresos.Controls.Add(Me.lblTitCTA_PER_VTA_ACTIVO)
        Me.frame_ingresos_egresos.Controls.Add(Me.lblTitCTA_GAN_VTA_ACTIVO)
        Me.frame_ingresos_egresos.Controls.Add(Me.lblTitCOD_CENTRO_RESULTADO)
        Me.frame_ingresos_egresos.Controls.Add(Me._lblDESCRIPCION_3)
        Me.frame_ingresos_egresos.Controls.Add(Me._lblDESCRIPCION_CUENTA_4)
        Me.frame_ingresos_egresos.Controls.Add(Me._lblDESCRIPCION_CUENTA_5)
        Me.frame_ingresos_egresos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_ingresos_egresos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frame_ingresos_egresos.Location = New System.Drawing.Point(6, 6)
        Me.frame_ingresos_egresos.Name = "frame_ingresos_egresos"
        Me.frame_ingresos_egresos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame_ingresos_egresos.Size = New System.Drawing.Size(625, 97)
        Me.frame_ingresos_egresos.TabIndex = 1
        Me.frame_ingresos_egresos.TabStop = False
        Me.frame_ingresos_egresos.Text = "Cuentas de Ingresos/Egresos por venta "
        '
        'txtCOD_CENTRO_RESULTADO
        '
        Me.txtCOD_CENTRO_RESULTADO.AcceptsReturn = True
        Me.txtCOD_CENTRO_RESULTADO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOD_CENTRO_RESULTADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOD_CENTRO_RESULTADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOD_CENTRO_RESULTADO.EsRequerido = False
        Me.txtCOD_CENTRO_RESULTADO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOD_CENTRO_RESULTADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOD_CENTRO_RESULTADO.LabelConsulta = Nothing
        Me.txtCOD_CENTRO_RESULTADO.Location = New System.Drawing.Point(185, 19)
        Me.txtCOD_CENTRO_RESULTADO.MaxLength = 15
        Me.txtCOD_CENTRO_RESULTADO.Name = "txtCOD_CENTRO_RESULTADO"
        Me.txtCOD_CENTRO_RESULTADO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCOD_CENTRO_RESULTADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOD_CENTRO_RESULTADO.Size = New System.Drawing.Size(130, 20)
        Me.txtCOD_CENTRO_RESULTADO.TabIndex = 1
        Me.txtCOD_CENTRO_RESULTADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_GAN_VTA_ACTIVO
        '
        Me.txtCTA_GAN_VTA_ACTIVO.AcceptsReturn = True
        Me.txtCTA_GAN_VTA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_GAN_VTA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_GAN_VTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_GAN_VTA_ACTIVO.EsRequerido = False
        Me.txtCTA_GAN_VTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_GAN_VTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_GAN_VTA_ACTIVO.LabelConsulta = Nothing
        Me.txtCTA_GAN_VTA_ACTIVO.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_GAN_VTA_ACTIVO.MaxLength = 30
        Me.txtCTA_GAN_VTA_ACTIVO.Name = "txtCTA_GAN_VTA_ACTIVO"
        Me.txtCTA_GAN_VTA_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_GAN_VTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_GAN_VTA_ACTIVO.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_GAN_VTA_ACTIVO.TabIndex = 2
        Me.txtCTA_GAN_VTA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_PER_VTA_ACTIVO
        '
        Me.txtCTA_PER_VTA_ACTIVO.AcceptsReturn = True
        Me.txtCTA_PER_VTA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_PER_VTA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_PER_VTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_PER_VTA_ACTIVO.EsRequerido = False
        Me.txtCTA_PER_VTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_PER_VTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_PER_VTA_ACTIVO.LabelConsulta = Nothing
        Me.txtCTA_PER_VTA_ACTIVO.Location = New System.Drawing.Point(185, 71)
        Me.txtCTA_PER_VTA_ACTIVO.MaxLength = 30
        Me.txtCTA_PER_VTA_ACTIVO.Name = "txtCTA_PER_VTA_ACTIVO"
        Me.txtCTA_PER_VTA_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_PER_VTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_PER_VTA_ACTIVO.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_PER_VTA_ACTIVO.TabIndex = 3
        Me.txtCTA_PER_VTA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_PER_VTA_ACTIVO
        '
        Me.lblTitCTA_PER_VTA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_PER_VTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_PER_VTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_PER_VTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_PER_VTA_ACTIVO.Location = New System.Drawing.Point(6, 73)
        Me.lblTitCTA_PER_VTA_ACTIVO.Name = "lblTitCTA_PER_VTA_ACTIVO"
        Me.lblTitCTA_PER_VTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_PER_VTA_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_PER_VTA_ACTIVO.TabIndex = 16
        Me.lblTitCTA_PER_VTA_ACTIVO.Text = "Cuenta de pérdida"
        '
        'lblTitCTA_GAN_VTA_ACTIVO
        '
        Me.lblTitCTA_GAN_VTA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_GAN_VTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_GAN_VTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_GAN_VTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_GAN_VTA_ACTIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_GAN_VTA_ACTIVO.Name = "lblTitCTA_GAN_VTA_ACTIVO"
        Me.lblTitCTA_GAN_VTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_GAN_VTA_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_GAN_VTA_ACTIVO.TabIndex = 15
        Me.lblTitCTA_GAN_VTA_ACTIVO.Text = "Cuenta de ganancia"
        '
        'lblTitCOD_CENTRO_RESULTADO
        '
        Me.lblTitCOD_CENTRO_RESULTADO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOD_CENTRO_RESULTADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOD_CENTRO_RESULTADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOD_CENTRO_RESULTADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOD_CENTRO_RESULTADO.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCOD_CENTRO_RESULTADO.Name = "lblTitCOD_CENTRO_RESULTADO"
        Me.lblTitCOD_CENTRO_RESULTADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOD_CENTRO_RESULTADO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCOD_CENTRO_RESULTADO.TabIndex = 14
        Me.lblTitCOD_CENTRO_RESULTADO.Text = "Centro"
        '
        '_lblDESCRIPCION_3
        '
        Me._lblDESCRIPCION_3.AutoSize = True
        Me._lblDESCRIPCION_3.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_3.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_3.Name = "_lblDESCRIPCION_3"
        Me._lblDESCRIPCION_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_3.Size = New System.Drawing.Size(97, 14)
        Me._lblDESCRIPCION_3.TabIndex = 13
        Me._lblDESCRIPCION_3.Text = "lblDESCRIPCION(3)"
        Me._lblDESCRIPCION_3.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_4
        '
        Me._lblDESCRIPCION_CUENTA_4.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_4.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_4.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_4.Name = "_lblDESCRIPCION_CUENTA_4"
        Me._lblDESCRIPCION_CUENTA_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_4.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_4.TabIndex = 12
        Me._lblDESCRIPCION_CUENTA_4.Text = "lblDESCRIPCION_CUENTA(4)"
        Me._lblDESCRIPCION_CUENTA_4.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_5
        '
        Me._lblDESCRIPCION_CUENTA_5.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_5.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_5.Location = New System.Drawing.Point(425, 73)
        Me._lblDESCRIPCION_CUENTA_5.Name = "_lblDESCRIPCION_CUENTA_5"
        Me._lblDESCRIPCION_CUENTA_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_5.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_5.TabIndex = 11
        Me._lblDESCRIPCION_CUENTA_5.Text = "lblDESCRIPCION_CUENTA(5)"
        Me._lblDESCRIPCION_CUENTA_5.UseMnemonic = False
        '
        'frame_compras
        '
        Me.frame_compras.BackColor = System.Drawing.SystemColors.Control
        Me.frame_compras.Controls.Add(Me.txtCOD_CENTRO_COMPRA)
        Me.frame_compras.Controls.Add(Me.txtCTA_COMPRA_ACTIVO)
        Me.frame_compras.Controls.Add(Me.lblTitCTA_COMPRA_ACTIVO)
        Me.frame_compras.Controls.Add(Me.lblTitCOD_CENTRO_COMPRA)
        Me.frame_compras.Controls.Add(Me._lblDESCRIPCION_4)
        Me.frame_compras.Controls.Add(Me._lblDESCRIPCION_CUENTA_6)
        Me.frame_compras.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_compras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frame_compras.Location = New System.Drawing.Point(6, 109)
        Me.frame_compras.Name = "frame_compras"
        Me.frame_compras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame_compras.Size = New System.Drawing.Size(625, 77)
        Me.frame_compras.TabIndex = 2
        Me.frame_compras.TabStop = False
        Me.frame_compras.Text = "Cuentas de compras "
        '
        'txtCOD_CENTRO_COMPRA
        '
        Me.txtCOD_CENTRO_COMPRA.AcceptsReturn = True
        Me.txtCOD_CENTRO_COMPRA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOD_CENTRO_COMPRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOD_CENTRO_COMPRA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOD_CENTRO_COMPRA.EsRequerido = False
        Me.txtCOD_CENTRO_COMPRA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOD_CENTRO_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOD_CENTRO_COMPRA.LabelConsulta = Nothing
        Me.txtCOD_CENTRO_COMPRA.Location = New System.Drawing.Point(185, 19)
        Me.txtCOD_CENTRO_COMPRA.MaxLength = 15
        Me.txtCOD_CENTRO_COMPRA.Name = "txtCOD_CENTRO_COMPRA"
        Me.txtCOD_CENTRO_COMPRA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCOD_CENTRO_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOD_CENTRO_COMPRA.Size = New System.Drawing.Size(130, 20)
        Me.txtCOD_CENTRO_COMPRA.TabIndex = 1
        Me.txtCOD_CENTRO_COMPRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_COMPRA_ACTIVO
        '
        Me.txtCTA_COMPRA_ACTIVO.AcceptsReturn = True
        Me.txtCTA_COMPRA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_COMPRA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_COMPRA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_COMPRA_ACTIVO.EsRequerido = False
        Me.txtCTA_COMPRA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_COMPRA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_COMPRA_ACTIVO.LabelConsulta = Nothing
        Me.txtCTA_COMPRA_ACTIVO.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_COMPRA_ACTIVO.MaxLength = 30
        Me.txtCTA_COMPRA_ACTIVO.Name = "txtCTA_COMPRA_ACTIVO"
        Me.txtCTA_COMPRA_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_COMPRA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_COMPRA_ACTIVO.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_COMPRA_ACTIVO.TabIndex = 2
        Me.txtCTA_COMPRA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_COMPRA_ACTIVO
        '
        Me.lblTitCTA_COMPRA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_COMPRA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_COMPRA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_COMPRA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_COMPRA_ACTIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_COMPRA_ACTIVO.Name = "lblTitCTA_COMPRA_ACTIVO"
        Me.lblTitCTA_COMPRA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_COMPRA_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_COMPRA_ACTIVO.TabIndex = 6
        Me.lblTitCTA_COMPRA_ACTIVO.Text = "Cuenta"
        '
        'lblTitCOD_CENTRO_COMPRA
        '
        Me.lblTitCOD_CENTRO_COMPRA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOD_CENTRO_COMPRA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOD_CENTRO_COMPRA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOD_CENTRO_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOD_CENTRO_COMPRA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCOD_CENTRO_COMPRA.Name = "lblTitCOD_CENTRO_COMPRA"
        Me.lblTitCOD_CENTRO_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOD_CENTRO_COMPRA.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCOD_CENTRO_COMPRA.TabIndex = 5
        Me.lblTitCOD_CENTRO_COMPRA.Text = "Centro"
        '
        '_lblDESCRIPCION_4
        '
        Me._lblDESCRIPCION_4.AutoSize = True
        Me._lblDESCRIPCION_4.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_4.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_4.Name = "_lblDESCRIPCION_4"
        Me._lblDESCRIPCION_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_4.Size = New System.Drawing.Size(97, 14)
        Me._lblDESCRIPCION_4.TabIndex = 4
        Me._lblDESCRIPCION_4.Text = "lblDESCRIPCION(4)"
        Me._lblDESCRIPCION_4.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_6
        '
        Me._lblDESCRIPCION_CUENTA_6.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_6.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_6.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_6.Name = "_lblDESCRIPCION_CUENTA_6"
        Me._lblDESCRIPCION_CUENTA_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_6.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_6.TabIndex = 3
        Me._lblDESCRIPCION_CUENTA_6.Text = "lblDESCRIPCION_CUENTA(6)"
        Me._lblDESCRIPCION_CUENTA_6.UseMnemonic = False
        '
        'frame_desecho
        '
        Me.frame_desecho.BackColor = System.Drawing.SystemColors.Control
        Me.frame_desecho.Controls.Add(Me.txtCOD_CENTRO_BAJA)
        Me.frame_desecho.Controls.Add(Me.txtCTA_BAJA_ACTIVO)
        Me.frame_desecho.Controls.Add(Me.lblTitCTA_BAJA_ACTIVO)
        Me.frame_desecho.Controls.Add(Me.lblTitCOD_CENTRO_BAJA)
        Me.frame_desecho.Controls.Add(Me._lblDESCRIPCION_5)
        Me.frame_desecho.Controls.Add(Me._lblDESCRIPCION_CUENTA_7)
        Me.frame_desecho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_desecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frame_desecho.Location = New System.Drawing.Point(6, 192)
        Me.frame_desecho.Name = "frame_desecho"
        Me.frame_desecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame_desecho.Size = New System.Drawing.Size(625, 77)
        Me.frame_desecho.TabIndex = 3
        Me.frame_desecho.TabStop = False
        Me.frame_desecho.Text = "Cuentas de desecho "
        '
        'txtCOD_CENTRO_BAJA
        '
        Me.txtCOD_CENTRO_BAJA.AcceptsReturn = True
        Me.txtCOD_CENTRO_BAJA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOD_CENTRO_BAJA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOD_CENTRO_BAJA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOD_CENTRO_BAJA.EsRequerido = False
        Me.txtCOD_CENTRO_BAJA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOD_CENTRO_BAJA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOD_CENTRO_BAJA.LabelConsulta = Nothing
        Me.txtCOD_CENTRO_BAJA.Location = New System.Drawing.Point(185, 19)
        Me.txtCOD_CENTRO_BAJA.MaxLength = 15
        Me.txtCOD_CENTRO_BAJA.Name = "txtCOD_CENTRO_BAJA"
        Me.txtCOD_CENTRO_BAJA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCOD_CENTRO_BAJA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOD_CENTRO_BAJA.Size = New System.Drawing.Size(130, 20)
        Me.txtCOD_CENTRO_BAJA.TabIndex = 1
        Me.txtCOD_CENTRO_BAJA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_BAJA_ACTIVO
        '
        Me.txtCTA_BAJA_ACTIVO.AcceptsReturn = True
        Me.txtCTA_BAJA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_BAJA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_BAJA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_BAJA_ACTIVO.EsRequerido = False
        Me.txtCTA_BAJA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_BAJA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_BAJA_ACTIVO.LabelConsulta = Nothing
        Me.txtCTA_BAJA_ACTIVO.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_BAJA_ACTIVO.MaxLength = 30
        Me.txtCTA_BAJA_ACTIVO.Name = "txtCTA_BAJA_ACTIVO"
        Me.txtCTA_BAJA_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_BAJA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_BAJA_ACTIVO.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_BAJA_ACTIVO.TabIndex = 2
        Me.txtCTA_BAJA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_BAJA_ACTIVO
        '
        Me.lblTitCTA_BAJA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_BAJA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_BAJA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_BAJA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_BAJA_ACTIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_BAJA_ACTIVO.Name = "lblTitCTA_BAJA_ACTIVO"
        Me.lblTitCTA_BAJA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_BAJA_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_BAJA_ACTIVO.TabIndex = 23
        Me.lblTitCTA_BAJA_ACTIVO.Text = "Cuenta"
        '
        'lblTitCOD_CENTRO_BAJA
        '
        Me.lblTitCOD_CENTRO_BAJA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOD_CENTRO_BAJA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOD_CENTRO_BAJA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOD_CENTRO_BAJA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOD_CENTRO_BAJA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCOD_CENTRO_BAJA.Name = "lblTitCOD_CENTRO_BAJA"
        Me.lblTitCOD_CENTRO_BAJA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOD_CENTRO_BAJA.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCOD_CENTRO_BAJA.TabIndex = 22
        Me.lblTitCOD_CENTRO_BAJA.Text = "Centro"
        '
        '_lblDESCRIPCION_5
        '
        Me._lblDESCRIPCION_5.AutoSize = True
        Me._lblDESCRIPCION_5.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_5.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_5.Name = "_lblDESCRIPCION_5"
        Me._lblDESCRIPCION_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_5.Size = New System.Drawing.Size(97, 14)
        Me._lblDESCRIPCION_5.TabIndex = 21
        Me._lblDESCRIPCION_5.Text = "lblDESCRIPCION(5)"
        Me._lblDESCRIPCION_5.UseMnemonic = False
        '
        '_lblDESCRIPCION_CUENTA_7
        '
        Me._lblDESCRIPCION_CUENTA_7.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_7.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_7.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_7.Name = "_lblDESCRIPCION_CUENTA_7"
        Me._lblDESCRIPCION_CUENTA_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_7.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_7.TabIndex = 20
        Me._lblDESCRIPCION_CUENTA_7.Text = "lblDESCRIPCION_CUENTA(7)"
        Me._lblDESCRIPCION_CUENTA_7.UseMnemonic = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.Frame6)
        Me.TabPage4.Controls.Add(Me.Frame3)
        Me.TabPage4.Controls.Add(Me.Frame5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(637, 303)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Cuentas contables ( F5 )"
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.txtCOD_CENTRO_VENTA)
        Me.Frame6.Controls.Add(Me.txtCTA_VENTA_ACTIVO)
        Me.Frame6.Controls.Add(Me.lblTitCTA_VENTA_ACTIVO)
        Me.Frame6.Controls.Add(Me.lblTitCOD_CENTRO_VENTA)
        Me.Frame6.Controls.Add(Me._lblDESCRIPCION_7)
        Me.Frame6.Controls.Add(Me._lblDESCRIPCION_CUENTA_9)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame6.Location = New System.Drawing.Point(6, 6)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(625, 77)
        Me.Frame6.TabIndex = 1
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "Cuenta de ventas activos "
        '
        'txtCOD_CENTRO_VENTA
        '
        Me.txtCOD_CENTRO_VENTA.AcceptsReturn = True
        Me.txtCOD_CENTRO_VENTA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOD_CENTRO_VENTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOD_CENTRO_VENTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOD_CENTRO_VENTA.EsRequerido = False
        Me.txtCOD_CENTRO_VENTA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOD_CENTRO_VENTA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOD_CENTRO_VENTA.LabelConsulta = Nothing
        Me.txtCOD_CENTRO_VENTA.Location = New System.Drawing.Point(185, 19)
        Me.txtCOD_CENTRO_VENTA.MaxLength = 15
        Me.txtCOD_CENTRO_VENTA.Name = "txtCOD_CENTRO_VENTA"
        Me.txtCOD_CENTRO_VENTA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCOD_CENTRO_VENTA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOD_CENTRO_VENTA.Size = New System.Drawing.Size(130, 20)
        Me.txtCOD_CENTRO_VENTA.TabIndex = 1
        Me.txtCOD_CENTRO_VENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_VENTA_ACTIVO
        '
        Me.txtCTA_VENTA_ACTIVO.AcceptsReturn = True
        Me.txtCTA_VENTA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_VENTA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_VENTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_VENTA_ACTIVO.EsRequerido = False
        Me.txtCTA_VENTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_VENTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_VENTA_ACTIVO.LabelConsulta = Nothing
        Me.txtCTA_VENTA_ACTIVO.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_VENTA_ACTIVO.MaxLength = 30
        Me.txtCTA_VENTA_ACTIVO.Name = "txtCTA_VENTA_ACTIVO"
        Me.txtCTA_VENTA_ACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_VENTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_VENTA_ACTIVO.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_VENTA_ACTIVO.TabIndex = 2
        Me.txtCTA_VENTA_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_VENTA_ACTIVO
        '
        Me.lblTitCTA_VENTA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_VENTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_VENTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_VENTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_VENTA_ACTIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_VENTA_ACTIVO.Name = "lblTitCTA_VENTA_ACTIVO"
        Me.lblTitCTA_VENTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_VENTA_ACTIVO.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_VENTA_ACTIVO.TabIndex = 13
        Me.lblTitCTA_VENTA_ACTIVO.Text = "Cuenta"
        '
        'lblTitCOD_CENTRO_VENTA
        '
        Me.lblTitCOD_CENTRO_VENTA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOD_CENTRO_VENTA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOD_CENTRO_VENTA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOD_CENTRO_VENTA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOD_CENTRO_VENTA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCOD_CENTRO_VENTA.Name = "lblTitCOD_CENTRO_VENTA"
        Me.lblTitCOD_CENTRO_VENTA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOD_CENTRO_VENTA.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCOD_CENTRO_VENTA.TabIndex = 12
        Me.lblTitCOD_CENTRO_VENTA.Text = "Centro"
        '
        '_lblDESCRIPCION_7
        '
        Me._lblDESCRIPCION_7.AutoSize = True
        Me._lblDESCRIPCION_7.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_7.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_7.Name = "_lblDESCRIPCION_7"
        Me._lblDESCRIPCION_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_7.Size = New System.Drawing.Size(97, 14)
        Me._lblDESCRIPCION_7.TabIndex = 11
        Me._lblDESCRIPCION_7.Text = "lblDESCRIPCION(7)"
        '
        '_lblDESCRIPCION_CUENTA_9
        '
        Me._lblDESCRIPCION_CUENTA_9.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_9.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_9.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_9.Name = "_lblDESCRIPCION_CUENTA_9"
        Me._lblDESCRIPCION_CUENTA_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_9.Size = New System.Drawing.Size(143, 14)
        Me._lblDESCRIPCION_CUENTA_9.TabIndex = 10
        Me._lblDESCRIPCION_CUENTA_9.Text = "lblDESCRIPCION_CUENTA(9)"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.txtCENTRO_DONA)
        Me.Frame3.Controls.Add(Me.txtCUENTA_DONA)
        Me.Frame3.Controls.Add(Me._lblDESCRIPCION_CUENTA_10)
        Me.Frame3.Controls.Add(Me._lblDESCRIPCION_8)
        Me.Frame3.Controls.Add(Me.lblTitCENTRO_DONA)
        Me.Frame3.Controls.Add(Me.lblTitCUENTA_DONA)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame3.Location = New System.Drawing.Point(6, 89)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(625, 77)
        Me.Frame3.TabIndex = 2
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Cuenta de donación de activos "
        '
        'txtCENTRO_DONA
        '
        Me.txtCENTRO_DONA.AcceptsReturn = True
        Me.txtCENTRO_DONA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCENTRO_DONA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCENTRO_DONA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCENTRO_DONA.EsRequerido = False
        Me.txtCENTRO_DONA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCENTRO_DONA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCENTRO_DONA.LabelConsulta = Nothing
        Me.txtCENTRO_DONA.Location = New System.Drawing.Point(185, 19)
        Me.txtCENTRO_DONA.MaxLength = 15
        Me.txtCENTRO_DONA.Name = "txtCENTRO_DONA"
        Me.txtCENTRO_DONA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCENTRO_DONA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCENTRO_DONA.Size = New System.Drawing.Size(130, 20)
        Me.txtCENTRO_DONA.TabIndex = 1
        Me.txtCENTRO_DONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCUENTA_DONA
        '
        Me.txtCUENTA_DONA.AcceptsReturn = True
        Me.txtCUENTA_DONA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCUENTA_DONA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCUENTA_DONA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCUENTA_DONA.EsRequerido = False
        Me.txtCUENTA_DONA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUENTA_DONA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCUENTA_DONA.LabelConsulta = Nothing
        Me.txtCUENTA_DONA.Location = New System.Drawing.Point(185, 45)
        Me.txtCUENTA_DONA.MaxLength = 30
        Me.txtCUENTA_DONA.Name = "txtCUENTA_DONA"
        Me.txtCUENTA_DONA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCUENTA_DONA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUENTA_DONA.Size = New System.Drawing.Size(218, 20)
        Me.txtCUENTA_DONA.TabIndex = 2
        Me.txtCUENTA_DONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lblDESCRIPCION_CUENTA_10
        '
        Me._lblDESCRIPCION_CUENTA_10.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_10.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_10.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_10.Name = "_lblDESCRIPCION_CUENTA_10"
        Me._lblDESCRIPCION_CUENTA_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_10.Size = New System.Drawing.Size(141, 14)
        Me._lblDESCRIPCION_CUENTA_10.TabIndex = 20
        Me._lblDESCRIPCION_CUENTA_10.Text = "Cuenta donación de activos"
        '
        '_lblDESCRIPCION_8
        '
        Me._lblDESCRIPCION_8.AutoSize = True
        Me._lblDESCRIPCION_8.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_8.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_8.Name = "_lblDESCRIPCION_8"
        Me._lblDESCRIPCION_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_8.Size = New System.Drawing.Size(190, 14)
        Me._lblDESCRIPCION_8.TabIndex = 19
        Me._lblDESCRIPCION_8.Text = "Centro cuenta de donación de activos"
        '
        'lblTitCENTRO_DONA
        '
        Me.lblTitCENTRO_DONA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCENTRO_DONA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCENTRO_DONA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCENTRO_DONA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCENTRO_DONA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCENTRO_DONA.Name = "lblTitCENTRO_DONA"
        Me.lblTitCENTRO_DONA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCENTRO_DONA.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCENTRO_DONA.TabIndex = 18
        Me.lblTitCENTRO_DONA.Text = "Centro"
        '
        'lblTitCUENTA_DONA
        '
        Me.lblTitCUENTA_DONA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCUENTA_DONA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCUENTA_DONA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCUENTA_DONA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCUENTA_DONA.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCUENTA_DONA.Name = "lblTitCUENTA_DONA"
        Me.lblTitCUENTA_DONA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCUENTA_DONA.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCUENTA_DONA.TabIndex = 17
        Me.lblTitCUENTA_DONA.Text = "Cuenta"
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.txtCOD_CENTRO_ACT_NODED)
        Me.Frame5.Controls.Add(Me.txtCTA_ACTIVO_NODEDUCIB)
        Me.Frame5.Controls.Add(Me.lblTitCTA_ACTIVO_NODEDUCIB)
        Me.Frame5.Controls.Add(Me.lblTitCOD_CENTRO_ACT_NODED)
        Me.Frame5.Controls.Add(Me._lblDESCRIPCION_9)
        Me.Frame5.Controls.Add(Me._lblDESCRIPCION_CUENTA_11)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame5.Location = New System.Drawing.Point(6, 172)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(625, 77)
        Me.Frame5.TabIndex = 3
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Cuenta de gastos No deducible"
        '
        'txtCOD_CENTRO_ACT_NODED
        '
        Me.txtCOD_CENTRO_ACT_NODED.AcceptsReturn = True
        Me.txtCOD_CENTRO_ACT_NODED.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOD_CENTRO_ACT_NODED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOD_CENTRO_ACT_NODED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOD_CENTRO_ACT_NODED.EsRequerido = False
        Me.txtCOD_CENTRO_ACT_NODED.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOD_CENTRO_ACT_NODED.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOD_CENTRO_ACT_NODED.LabelConsulta = Nothing
        Me.txtCOD_CENTRO_ACT_NODED.Location = New System.Drawing.Point(185, 19)
        Me.txtCOD_CENTRO_ACT_NODED.MaxLength = 15
        Me.txtCOD_CENTRO_ACT_NODED.Name = "txtCOD_CENTRO_ACT_NODED"
        Me.txtCOD_CENTRO_ACT_NODED.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeCentrosDeResponsabilidad_CERESC01
        Me.txtCOD_CENTRO_ACT_NODED.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOD_CENTRO_ACT_NODED.Size = New System.Drawing.Size(130, 20)
        Me.txtCOD_CENTRO_ACT_NODED.TabIndex = 1
        Me.txtCOD_CENTRO_ACT_NODED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCTA_ACTIVO_NODEDUCIB
        '
        Me.txtCTA_ACTIVO_NODEDUCIB.AcceptsReturn = True
        Me.txtCTA_ACTIVO_NODEDUCIB.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTA_ACTIVO_NODEDUCIB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTA_ACTIVO_NODEDUCIB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCTA_ACTIVO_NODEDUCIB.EsRequerido = False
        Me.txtCTA_ACTIVO_NODEDUCIB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTA_ACTIVO_NODEDUCIB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCTA_ACTIVO_NODEDUCIB.LabelConsulta = Nothing
        Me.txtCTA_ACTIVO_NODEDUCIB.Location = New System.Drawing.Point(185, 45)
        Me.txtCTA_ACTIVO_NODEDUCIB.MaxLength = 30
        Me.txtCTA_ACTIVO_NODEDUCIB.Name = "txtCTA_ACTIVO_NODEDUCIB"
        Me.txtCTA_ACTIVO_NODEDUCIB.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMayorGeneral_MAYGEC01
        Me.txtCTA_ACTIVO_NODEDUCIB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCTA_ACTIVO_NODEDUCIB.Size = New System.Drawing.Size(218, 20)
        Me.txtCTA_ACTIVO_NODEDUCIB.TabIndex = 2
        Me.txtCTA_ACTIVO_NODEDUCIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitCTA_ACTIVO_NODEDUCIB
        '
        Me.lblTitCTA_ACTIVO_NODEDUCIB.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCTA_ACTIVO_NODEDUCIB.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCTA_ACTIVO_NODEDUCIB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCTA_ACTIVO_NODEDUCIB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCTA_ACTIVO_NODEDUCIB.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCTA_ACTIVO_NODEDUCIB.Name = "lblTitCTA_ACTIVO_NODEDUCIB"
        Me.lblTitCTA_ACTIVO_NODEDUCIB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCTA_ACTIVO_NODEDUCIB.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCTA_ACTIVO_NODEDUCIB.TabIndex = 6
        Me.lblTitCTA_ACTIVO_NODEDUCIB.Text = "Cuenta"
        '
        'lblTitCOD_CENTRO_ACT_NODED
        '
        Me.lblTitCOD_CENTRO_ACT_NODED.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOD_CENTRO_ACT_NODED.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOD_CENTRO_ACT_NODED.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOD_CENTRO_ACT_NODED.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOD_CENTRO_ACT_NODED.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCOD_CENTRO_ACT_NODED.Name = "lblTitCOD_CENTRO_ACT_NODED"
        Me.lblTitCOD_CENTRO_ACT_NODED.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOD_CENTRO_ACT_NODED.Size = New System.Drawing.Size(173, 14)
        Me.lblTitCOD_CENTRO_ACT_NODED.TabIndex = 5
        Me.lblTitCOD_CENTRO_ACT_NODED.Text = "Centro"
        '
        '_lblDESCRIPCION_9
        '
        Me._lblDESCRIPCION_9.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_9.Location = New System.Drawing.Point(425, 21)
        Me._lblDESCRIPCION_9.Name = "_lblDESCRIPCION_9"
        Me._lblDESCRIPCION_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_9.Size = New System.Drawing.Size(194, 13)
        Me._lblDESCRIPCION_9.TabIndex = 4
        Me._lblDESCRIPCION_9.Text = "Centro cta.gastos no deducible"
        '
        '_lblDESCRIPCION_CUENTA_11
        '
        Me._lblDESCRIPCION_CUENTA_11.AutoSize = True
        Me._lblDESCRIPCION_CUENTA_11.BackColor = System.Drawing.Color.Transparent
        Me._lblDESCRIPCION_CUENTA_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDESCRIPCION_CUENTA_11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDESCRIPCION_CUENTA_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDESCRIPCION_CUENTA_11.Location = New System.Drawing.Point(425, 47)
        Me._lblDESCRIPCION_CUENTA_11.Name = "_lblDESCRIPCION_CUENTA_11"
        Me._lblDESCRIPCION_CUENTA_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDESCRIPCION_CUENTA_11.Size = New System.Drawing.Size(141, 14)
        Me._lblDESCRIPCION_CUENTA_11.TabIndex = 3
        Me._lblDESCRIPCION_CUENTA_11.Text = "Cuenta gastos no deducible"
        '
        'ACTTACM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 384)
        Me.Controls.Add(Me.mhTab1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTTACM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de tipos de activos fijos - ACTTACM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mhTab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.frame_Balance.ResumeLayout(False)
        Me.frame_Balance.PerformLayout()
        Me.frame_Gastos.ResumeLayout(False)
        Me.frame_Gastos.PerformLayout()
        Me.frame_Reevaluacion.ResumeLayout(False)
        Me.frame_Reevaluacion.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.frame_ingresos_egresos.ResumeLayout(False)
        Me.frame_ingresos_egresos.PerformLayout()
        Me.frame_compras.ResumeLayout(False)
        Me.frame_compras.PerformLayout()
        Me.frame_desecho.ResumeLayout(False)
        Me.frame_desecho.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    ' System.Windows.Forms.TextBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents mhTab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents txtCODIGO_TIPO_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents txtDESCRIP_TIPO_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtMONTO_MINIMO_ACTIVO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTIEMPO_DEPRECIACION As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTIPO_CATALOGO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtPORCENTAJE_PARA_RESCATE As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitCALCULO_PRIMERA_DEPR As System.Windows.Forms.Label
    Public WithEvents lblNOMBRE_CATALOGO As System.Windows.Forms.Label
    Public WithEvents lblTitCLA_CONTABILIZACION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIP_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents lblTitFORZAR_FECHA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_MINIMO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitTIEMPO_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_CATALOGO As System.Windows.Forms.Label
    Public WithEvents lblTitFORMA_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents lblTitNO_DIAS_ANIO As System.Windows.Forms.Label
    Public WithEvents lblTitPORCENTAJE_PARA_RESCATE As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents frame_Reevaluacion As System.Windows.Forms.GroupBox
    Public WithEvents txtCTA_REVALUA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCOD_CENTRO_REVALUA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_REVALUA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCOD_CENTRO_REVALUA As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_6 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_8 As System.Windows.Forms.Label
    Public WithEvents frame_Gastos As System.Windows.Forms.GroupBox
    Public WithEvents txtCTA_GASTO_DEPREC As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCOD_CENTRO_GASTO_ACT As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_GASTO_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblTitCOD_CENTRO_GASTO_ACT As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_2 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_3 As System.Windows.Forms.Label
    Public WithEvents frame_Balance As System.Windows.Forms.GroupBox
    Public WithEvents txtCTA_DEPREC_ACUM As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCTA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_CENTRO_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_DEPREC_ACUM As System.Windows.Forms.Label
    Public WithEvents lblTitCTA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_CENTRO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_1 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_1 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_2 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents frame_desecho As System.Windows.Forms.GroupBox
    Public WithEvents txtCTA_BAJA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCOD_CENTRO_BAJA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_BAJA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCOD_CENTRO_BAJA As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_5 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_7 As System.Windows.Forms.Label
    Public WithEvents frame_ingresos_egresos As System.Windows.Forms.GroupBox
    Public WithEvents txtCTA_PER_VTA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCTA_GAN_VTA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCOD_CENTRO_RESULTADO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_PER_VTA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCTA_GAN_VTA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCOD_CENTRO_RESULTADO As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_3 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_4 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_5 As System.Windows.Forms.Label
    Public WithEvents frame_compras As System.Windows.Forms.GroupBox
    Public WithEvents txtCTA_COMPRA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCOD_CENTRO_COMPRA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_COMPRA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCOD_CENTRO_COMPRA As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_4 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_6 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents txtCUENTA_DONA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCENTRO_DONA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents _lblDESCRIPCION_CUENTA_10 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_8 As System.Windows.Forms.Label
    Public WithEvents lblTitCENTRO_DONA As System.Windows.Forms.Label
    Public WithEvents lblTitCUENTA_DONA As System.Windows.Forms.Label
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents txtCOD_CENTRO_VENTA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCTA_VENTA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_VENTA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCOD_CENTRO_VENTA As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_7 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_9 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents txtCOD_CENTRO_ACT_NODED As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCTA_ACTIVO_NODEDUCIB As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCTA_ACTIVO_NODEDUCIB As System.Windows.Forms.Label
    Public WithEvents lblTitCOD_CENTRO_ACT_NODED As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_9 As System.Windows.Forms.Label
    Public WithEvents _lblDESCRIPCION_CUENTA_11 As System.Windows.Forms.Label
    Public WithEvents cboCLA_CONTABILIZACION As System.Windows.Forms.ComboBox
    Public WithEvents cboCALCULO_PRIMERA_DEPR As System.Windows.Forms.ComboBox
    Public WithEvents cboNO_DIAS_ANIO As System.Windows.Forms.ComboBox
    Public WithEvents cboFORMA_DEPRECIACION As System.Windows.Forms.ComboBox
    Public WithEvents cboTIPO_DEPRECIACION As System.Windows.Forms.ComboBox
    Public WithEvents txtFORZAR_FECHA_ACTIVO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
End Class
