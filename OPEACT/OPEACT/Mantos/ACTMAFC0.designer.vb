<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFC0
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento 'System.Windows.Forms.Form

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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpCamposDefinidos = New System.Windows.Forms.GroupBox()
        Me.panCampos = New System.Windows.Forms.Panel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpGeneral = New System.Windows.Forms.GroupBox()
        Me.POSEE_CTRL_TF = New System.Windows.Forms.CheckBox()
        Me.cboEstadoServicio = New System.Windows.Forms.ComboBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtCATEGORIA_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtRESPONSABLE_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.CODIGO_UBICACION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_MARCA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtREFERENCIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblNombreCategoria = New System.Windows.Forms.Label()
        Me.lblNombreResponsable = New System.Windows.Forms.Label()
        Me.lblNombreUbicacion = New System.Windows.Forms.Label()
        Me.lblNombreMarca = New System.Windows.Forms.Label()
        Me.lblNombreDivision = New System.Windows.Forms.Label()
        Me.lblNombreTipoActivo = New System.Windows.Forms.Label()
        Me.lblNombreProveedor = New System.Windows.Forms.Label()
        Me.lblTitESTADO_SERVICIO = New System.Windows.Forms.Label()
        Me.lblTitESTATUS = New System.Windows.Forms.Label()
        Me.lblDESCRIP_CORTA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblCATEGORIA_ID = New System.Windows.Forms.Label()
        Me.lblRESPONSABLE_ID = New System.Windows.Forms.Label()
        Me.lblUBICACION = New System.Windows.Forms.Label()
        Me.lblCODIGO_MARCA = New System.Windows.Forms.Label()
        Me.lblREFERENCIA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblCODIGO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.mhTab1 = New System.Windows.Forms.TabControl()
        Me.FrameUno = New System.Windows.Forms.GroupBox()
        Me.grpDepreciacion = New System.Windows.Forms.GroupBox()
        Me.cboTipoDepreciacion = New System.Windows.Forms.ComboBox()
        Me.cboDepreciable = New System.Windows.Forms.ComboBox()
        Me.lblSALDO_MESES_DEPRE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTOTALMENTE_DEP = New System.Windows.Forms.Label()
        Me.lblTIEMPO_DEPRECIACION = New System.Windows.Forms.Label()
        Me.lblPORCENTAJE_ANUAL_DEP = New System.Windows.Forms.Label()
        Me.lblTitTIPO_DEPRECIACION = New System.Windows.Forms.Label()
        Me.lblTitTIEMPO_DEPRECIACION = New System.Windows.Forms.Label()
        Me.lblTitPORCENTAJE_ANUAL_DEP = New System.Windows.Forms.Label()
        Me.lblTitDEPRECIABLE = New System.Windows.Forms.Label()
        Me.lblTitSALDO_MESES_DEPRE = New System.Windows.Forms.Label()
        Me.grpValores = New System.Windows.Forms.GroupBox()
        Me.txtVALOR_MONEDA_LOCAL = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblVALOR_MONEDA_LOCAL = New System.Windows.Forms.Label()
        Me.lblVALOR_NO_DEDUCIBLE = New System.Windows.Forms.Label()
        Me.lblTitVALOR_NO_DEDUCIBLE = New System.Windows.Forms.Label()
        Me.lblTASA_DEDUCIBLE_ISR = New System.Windows.Forms.Label()
        Me.lblVALOR_ACTUAL_ACTIVO = New System.Windows.Forms.Label()
        Me.lblMONTO_REVALUACIONES = New System.Windows.Forms.Label()
        Me.lblTitTASA_DEDUCIBLE_ISR = New System.Windows.Forms.Label()
        Me.lblTitVALOR_ORIG_ACT_USADO = New System.Windows.Forms.Label()
        Me.lblVALOR_ORIG_ACT_USADO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVALOR_ORIGINAL_ACTIV = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_MONEDA = New System.Windows.Forms.Label()
        Me.lblCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitTASA_CAMBIO_COMPRA = New System.Windows.Forms.Label()
        Me.lblTASA_CAMBIO_COMPRA = New System.Windows.Forms.Label()
        Me.lblVALOR_TOT_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitVALOR_TOT_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitVALOR_DEP_ACUM_ACT = New System.Windows.Forms.Label()
        Me.lblVALOR_DEP_ACUM_ACT = New System.Windows.Forms.Label()
        Me.lblVALOR_RESCATE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitVALOR_ORIGINAL_ACTIV = New System.Windows.Forms.Label()
        Me.lblTitVALOR_ACTUAL_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitVALOR_RESCATE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitMONTO_REVALUACIONES = New System.Windows.Forms.Label()
        Me.lblTitVALOR_DEP_PERIODO = New System.Windows.Forms.Label()
        Me.lblVALOR_DEP_PERIODO = New System.Windows.Forms.Label()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdInfoGeneral = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.FrameDos = New System.Windows.Forms.GroupBox()
        Me.grpFechas = New System.Windows.Forms.GroupBox()
        Me.lblNO_PERIODO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblANO_PERIODO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblFECHA_INICIO_DEPREC = New System.Windows.Forms.Label()
        Me.lblTitFECHA_INICIO_DEPREC = New System.Windows.Forms.Label()
        Me.lblTitFECHA_BAJA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblFECHA_BAJA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblFECHA_ADQUISICION = New System.Windows.Forms.Label()
        Me.lblTitFECHA_ADQUISICION = New System.Windows.Forms.Label()
        Me.lblTitNO_PERIODO = New System.Windows.Forms.Label()
        Me.lblTitANO_PERIODO = New System.Windows.Forms.Label()
        Me.grpOtros = New System.Windows.Forms.GroupBox()
        Me.lblNO_ORDEN = New System.Windows.Forms.Label()
        Me.lblTitNO_ORDEN = New System.Windows.Forms.Label()
        Me.lblFECHA_ULT_INVENTARIO = New System.Windows.Forms.Label()
        Me.lblTitFECHA_ULT_INVENTARIO = New System.Windows.Forms.Label()
        Me.grpUltimaActualizacion = New System.Windows.Forms.GroupBox()
        Me.lblUSR_ACTUALIZACION = New System.Windows.Forms.Label()
        Me.lblFEC_ACTUALIZACION = New System.Windows.Forms.Label()
        Me.lblTitUSR_ACTUALIZACION = New System.Windows.Forms.Label()
        Me.lblTitFEC_ACTUALIZACION = New System.Windows.Forms.Label()
        Me.grpUltimoMovimiento = New System.Windows.Forms.GroupBox()
        Me.lblFECHA_ULT_MANTMTO = New System.Windows.Forms.Label()
        Me.lblCOSTO_ACUM_MNTMTO = New System.Windows.Forms.Label()
        Me.lblFRECUENCIA_MNTMTO = New System.Windows.Forms.Label()
        Me.lblTitFECHA_ULT_MANTMTO = New System.Windows.Forms.Label()
        Me.lblTitCOSTO_ACUM_MNTMTO = New System.Windows.Forms.Label()
        Me.lblTitFRECUENCIA_MNTMTO = New System.Windows.Forms.Label()
        Me.grpAuditoria = New System.Windows.Forms.GroupBox()
        Me.lblTitFECHA_OPERACION = New System.Windows.Forms.Label()
        Me.lblTitUSUARIO_OPERACION = New System.Windows.Forms.Label()
        Me.lblFECHA_OPERACION = New System.Windows.Forms.Label()
        Me.lblUSUARIO_OPERACION = New System.Windows.Forms.Label()
        Me.grpUltimaDepreciacion = New System.Windows.Forms.GroupBox()
        Me.lblTitFECHA_ULTIMA_DEPREC = New System.Windows.Forms.Label()
        Me.lblTitMONTO_ULTIMA_DEPREC = New System.Windows.Forms.Label()
        Me.lblFECHA_ULTIMA_DEPREC = New System.Windows.Forms.Label()
        Me.lblMONTO_ULTIMA_DEPREC = New System.Windows.Forms.Label()
        Me.lblTitTASA_CAMBIO_ULT_REV = New System.Windows.Forms.Label()
        Me.lblTASA_CAMBIO_ULT_REV = New System.Windows.Forms.Label()
        Me.grpUltimaReevaluacion = New System.Windows.Forms.GroupBox()
        Me.lblMONTO_ULTIMA_REVAL = New System.Windows.Forms.Label()
        Me.lblFECHA_ULTIMA_REVAL = New System.Windows.Forms.Label()
        Me.lblTitMONTO_ULTIMA_REVAL = New System.Windows.Forms.Label()
        Me.lblTitFECHA_ULTIMA_REVAL = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.grpCamposDefinidos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpGeneral.SuspendLayout()
        Me.mhTab1.SuspendLayout()
        Me.FrameUno.SuspendLayout()
        Me.grpDepreciacion.SuspendLayout()
        Me.grpValores.SuspendLayout()
        Me.FrameDos.SuspendLayout()
        Me.grpFechas.SuspendLayout()
        Me.grpOtros.SuspendLayout()
        Me.grpUltimaActualizacion.SuspendLayout()
        Me.grpUltimoMovimiento.SuspendLayout()
        Me.grpAuditoria.SuspendLayout()
        Me.grpUltimaDepreciacion.SuspendLayout()
        Me.grpUltimaReevaluacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.grpCamposDefinidos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(743, 273)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Campos especiales"
        '
        'grpCamposDefinidos
        '
        Me.grpCamposDefinidos.BackColor = System.Drawing.SystemColors.Control
        Me.grpCamposDefinidos.Controls.Add(Me.panCampos)
        Me.grpCamposDefinidos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCamposDefinidos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpCamposDefinidos.Location = New System.Drawing.Point(6, 6)
        Me.grpCamposDefinidos.Name = "grpCamposDefinidos"
        Me.grpCamposDefinidos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpCamposDefinidos.Size = New System.Drawing.Size(731, 261)
        Me.grpCamposDefinidos.TabIndex = 128
        Me.grpCamposDefinidos.TabStop = False
        Me.grpCamposDefinidos.Text = "Campos definidos por el usuario"
        '
        'panCampos
        '
        Me.panCampos.AutoScroll = True
        Me.panCampos.Location = New System.Drawing.Point(6, 19)
        Me.panCampos.Name = "panCampos"
        Me.panCampos.Size = New System.Drawing.Size(719, 236)
        Me.panCampos.TabIndex = 129
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.grpGeneral)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(743, 273)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Información general"
        '
        'grpGeneral
        '
        Me.grpGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.grpGeneral.Controls.Add(Me.POSEE_CTRL_TF)
        Me.grpGeneral.Controls.Add(Me.cboEstadoServicio)
        Me.grpGeneral.Controls.Add(Me.cboEstado)
        Me.grpGeneral.Controls.Add(Me.txtCATEGORIA_ID)
        Me.grpGeneral.Controls.Add(Me.txtRESPONSABLE_ID)
        Me.grpGeneral.Controls.Add(Me.CODIGO_UBICACION)
        Me.grpGeneral.Controls.Add(Me.txtCODIGO_MARCA)
        Me.grpGeneral.Controls.Add(Me.txtREFERENCIA)
        Me.grpGeneral.Controls.Add(Me.lblNombreCategoria)
        Me.grpGeneral.Controls.Add(Me.lblNombreResponsable)
        Me.grpGeneral.Controls.Add(Me.lblNombreUbicacion)
        Me.grpGeneral.Controls.Add(Me.lblNombreMarca)
        Me.grpGeneral.Controls.Add(Me.lblNombreDivision)
        Me.grpGeneral.Controls.Add(Me.lblNombreTipoActivo)
        Me.grpGeneral.Controls.Add(Me.lblNombreProveedor)
        Me.grpGeneral.Controls.Add(Me.lblTitESTADO_SERVICIO)
        Me.grpGeneral.Controls.Add(Me.lblTitESTATUS)
        Me.grpGeneral.Controls.Add(Me.lblDESCRIP_CORTA_ACTIVO)
        Me.grpGeneral.Controls.Add(Me.lblCATEGORIA_ID)
        Me.grpGeneral.Controls.Add(Me.lblRESPONSABLE_ID)
        Me.grpGeneral.Controls.Add(Me.lblUBICACION)
        Me.grpGeneral.Controls.Add(Me.lblCODIGO_MARCA)
        Me.grpGeneral.Controls.Add(Me.lblREFERENCIA)
        Me.grpGeneral.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.grpGeneral.Controls.Add(Me.lblCODIGO_DIVISION)
        Me.grpGeneral.Controls.Add(Me.lblCODIGO_TIPO_ACTIVO)
        Me.grpGeneral.Controls.Add(Me.lblTitCODIGO_TIPO_ACTIVO)
        Me.grpGeneral.Controls.Add(Me.lblCODIGO_PROVEEDOR)
        Me.grpGeneral.Controls.Add(Me.lblTitCODIGO_PROVEEDOR)
        Me.grpGeneral.Controls.Add(Me.lblMEJORA_CORRELATIVO)
        Me.grpGeneral.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.grpGeneral.Controls.Add(Me.lblCODIGO_DE_ACTIVO)
        Me.grpGeneral.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.grpGeneral.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGeneral.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpGeneral.Location = New System.Drawing.Point(6, 6)
        Me.grpGeneral.Name = "grpGeneral"
        Me.grpGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpGeneral.Size = New System.Drawing.Size(731, 261)
        Me.grpGeneral.TabIndex = 94
        Me.grpGeneral.TabStop = False
        '
        'POSEE_CTRL_TF
        '
        Me.POSEE_CTRL_TF.BackColor = System.Drawing.SystemColors.Control
        Me.POSEE_CTRL_TF.Cursor = System.Windows.Forms.Cursors.Default
        Me.POSEE_CTRL_TF.Enabled = False
        Me.POSEE_CTRL_TF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSEE_CTRL_TF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.POSEE_CTRL_TF.Location = New System.Drawing.Point(474, 184)
        Me.POSEE_CTRL_TF.Name = "POSEE_CTRL_TF"
        Me.POSEE_CTRL_TF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.POSEE_CTRL_TF.Size = New System.Drawing.Size(221, 20)
        Me.POSEE_CTRL_TF.TabIndex = 126
        Me.POSEE_CTRL_TF.Text = "Control de existencia"
        Me.POSEE_CTRL_TF.UseVisualStyleBackColor = False
        '
        'cboEstadoServicio
        '
        Me.cboEstadoServicio.BackColor = System.Drawing.SystemColors.Window
        Me.cboEstadoServicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboEstadoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoServicio.Enabled = False
        Me.cboEstadoServicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoServicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEstadoServicio.Location = New System.Drawing.Point(578, 38)
        Me.cboEstadoServicio.Name = "cboEstadoServicio"
        Me.cboEstadoServicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstadoServicio.Size = New System.Drawing.Size(147, 22)
        Me.cboEstadoServicio.TabIndex = 118
        '
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.SystemColors.Window
        Me.cboEstado.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Enabled = False
        Me.cboEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEstado.Location = New System.Drawing.Point(303, 38)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstado.Size = New System.Drawing.Size(147, 22)
        Me.cboEstado.TabIndex = 116
        '
        'txtCATEGORIA_ID
        '
        Me.txtCATEGORIA_ID.AcceptsReturn = True
        Me.txtCATEGORIA_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCATEGORIA_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCATEGORIA_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCATEGORIA_ID.Enabled = False
        Me.txtCATEGORIA_ID.EsRequerido = False
        Me.txtCATEGORIA_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATEGORIA_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCATEGORIA_ID.LabelConsulta = Nothing
        Me.txtCATEGORIA_ID.Location = New System.Drawing.Point(153, 232)
        Me.txtCATEGORIA_ID.MaxLength = 5
        Me.txtCATEGORIA_ID.Name = "txtCATEGORIA_ID"
        Me.txtCATEGORIA_ID.NombreDeConsulta = Nothing
        Me.txtCATEGORIA_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCATEGORIA_ID.Size = New System.Drawing.Size(58, 20)
        Me.txtCATEGORIA_ID.TabIndex = 112
        Me.txtCATEGORIA_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRESPONSABLE_ID
        '
        Me.txtRESPONSABLE_ID.AcceptsReturn = True
        Me.txtRESPONSABLE_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtRESPONSABLE_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRESPONSABLE_ID.Enabled = False
        Me.txtRESPONSABLE_ID.EsRequerido = False
        Me.txtRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRESPONSABLE_ID.LabelConsulta = Nothing
        Me.txtRESPONSABLE_ID.Location = New System.Drawing.Point(153, 208)
        Me.txtRESPONSABLE_ID.MaxLength = 5
        Me.txtRESPONSABLE_ID.Name = "txtRESPONSABLE_ID"
        Me.txtRESPONSABLE_ID.NombreDeConsulta = Nothing
        Me.txtRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRESPONSABLE_ID.Size = New System.Drawing.Size(58, 20)
        Me.txtRESPONSABLE_ID.TabIndex = 110
        Me.txtRESPONSABLE_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CODIGO_UBICACION
        '
        Me.CODIGO_UBICACION.AcceptsReturn = True
        Me.CODIGO_UBICACION.BackColor = System.Drawing.SystemColors.Window
        Me.CODIGO_UBICACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CODIGO_UBICACION.Enabled = False
        Me.CODIGO_UBICACION.EsRequerido = False
        Me.CODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CODIGO_UBICACION.LabelConsulta = Nothing
        Me.CODIGO_UBICACION.Location = New System.Drawing.Point(153, 184)
        Me.CODIGO_UBICACION.MaxLength = 10
        Me.CODIGO_UBICACION.Name = "CODIGO_UBICACION"
        Me.CODIGO_UBICACION.NombreDeConsulta = Nothing
        Me.CODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CODIGO_UBICACION.Size = New System.Drawing.Size(81, 20)
        Me.CODIGO_UBICACION.TabIndex = 108
        Me.CODIGO_UBICACION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_MARCA
        '
        Me.txtCODIGO_MARCA.AcceptsReturn = True
        Me.txtCODIGO_MARCA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_MARCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_MARCA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_MARCA.Enabled = False
        Me.txtCODIGO_MARCA.EsRequerido = False
        Me.txtCODIGO_MARCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_MARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_MARCA.LabelConsulta = Nothing
        Me.txtCODIGO_MARCA.Location = New System.Drawing.Point(153, 160)
        Me.txtCODIGO_MARCA.MaxLength = 5
        Me.txtCODIGO_MARCA.Name = "txtCODIGO_MARCA"
        Me.txtCODIGO_MARCA.NombreDeConsulta = Nothing
        Me.txtCODIGO_MARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_MARCA.Size = New System.Drawing.Size(58, 20)
        Me.txtCODIGO_MARCA.TabIndex = 106
        Me.txtCODIGO_MARCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtREFERENCIA
        '
        Me.txtREFERENCIA.AcceptsReturn = True
        Me.txtREFERENCIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtREFERENCIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtREFERENCIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtREFERENCIA.Enabled = False
        Me.txtREFERENCIA.EsRequerido = False
        Me.txtREFERENCIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtREFERENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtREFERENCIA.LabelConsulta = Nothing
        Me.txtREFERENCIA.Location = New System.Drawing.Point(153, 136)
        Me.txtREFERENCIA.MaxLength = 15
        Me.txtREFERENCIA.Multiline = True
        Me.txtREFERENCIA.Name = "txtREFERENCIA"
        Me.txtREFERENCIA.NombreDeConsulta = Nothing
        Me.txtREFERENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtREFERENCIA.Size = New System.Drawing.Size(125, 20)
        Me.txtREFERENCIA.TabIndex = 104
        '
        'lblNombreCategoria
        '
        Me.lblNombreCategoria.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCategoria.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCategoria.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCategoria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCategoria.Location = New System.Drawing.Point(217, 234)
        Me.lblNombreCategoria.Name = "lblNombreCategoria"
        Me.lblNombreCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCategoria.Size = New System.Drawing.Size(508, 20)
        Me.lblNombreCategoria.TabIndex = 125
        Me.lblNombreCategoria.UseMnemonic = False
        '
        'lblNombreResponsable
        '
        Me.lblNombreResponsable.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreResponsable.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreResponsable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreResponsable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreResponsable.Location = New System.Drawing.Point(217, 210)
        Me.lblNombreResponsable.Name = "lblNombreResponsable"
        Me.lblNombreResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreResponsable.Size = New System.Drawing.Size(508, 20)
        Me.lblNombreResponsable.TabIndex = 124
        Me.lblNombreResponsable.UseMnemonic = False
        '
        'lblNombreUbicacion
        '
        Me.lblNombreUbicacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUbicacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreUbicacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUbicacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreUbicacion.Location = New System.Drawing.Point(240, 186)
        Me.lblNombreUbicacion.Name = "lblNombreUbicacion"
        Me.lblNombreUbicacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreUbicacion.Size = New System.Drawing.Size(225, 20)
        Me.lblNombreUbicacion.TabIndex = 123
        Me.lblNombreUbicacion.UseMnemonic = False
        '
        'lblNombreMarca
        '
        Me.lblNombreMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreMarca.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreMarca.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMarca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreMarca.Location = New System.Drawing.Point(217, 162)
        Me.lblNombreMarca.Name = "lblNombreMarca"
        Me.lblNombreMarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreMarca.Size = New System.Drawing.Size(508, 20)
        Me.lblNombreMarca.TabIndex = 122
        Me.lblNombreMarca.UseMnemonic = False
        '
        'lblNombreDivision
        '
        Me.lblNombreDivision.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreDivision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreDivision.Location = New System.Drawing.Point(240, 113)
        Me.lblNombreDivision.Name = "lblNombreDivision"
        Me.lblNombreDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreDivision.Size = New System.Drawing.Size(485, 20)
        Me.lblNombreDivision.TabIndex = 121
        Me.lblNombreDivision.UseMnemonic = False
        '
        'lblNombreTipoActivo
        '
        Me.lblNombreTipoActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreTipoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoActivo.Location = New System.Drawing.Point(240, 89)
        Me.lblNombreTipoActivo.Name = "lblNombreTipoActivo"
        Me.lblNombreTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoActivo.Size = New System.Drawing.Size(485, 20)
        Me.lblNombreTipoActivo.TabIndex = 120
        Me.lblNombreTipoActivo.UseMnemonic = False
        '
        'lblNombreProveedor
        '
        Me.lblNombreProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreProveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreProveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreProveedor.Location = New System.Drawing.Point(287, 65)
        Me.lblNombreProveedor.Name = "lblNombreProveedor"
        Me.lblNombreProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreProveedor.Size = New System.Drawing.Size(438, 20)
        Me.lblNombreProveedor.TabIndex = 119
        Me.lblNombreProveedor.UseMnemonic = False
        '
        'lblTitESTADO_SERVICIO
        '
        Me.lblTitESTADO_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTADO_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTADO_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTADO_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTADO_SERVICIO.Location = New System.Drawing.Point(471, 41)
        Me.lblTitESTADO_SERVICIO.Name = "lblTitESTADO_SERVICIO"
        Me.lblTitESTADO_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTADO_SERVICIO.Size = New System.Drawing.Size(101, 14)
        Me.lblTitESTADO_SERVICIO.TabIndex = 117
        Me.lblTitESTADO_SERVICIO.Text = "Estado servicio"
        '
        'lblTitESTATUS
        '
        Me.lblTitESTATUS.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTATUS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTATUS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTATUS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTATUS.Location = New System.Drawing.Point(245, 41)
        Me.lblTitESTATUS.Name = "lblTitESTATUS"
        Me.lblTitESTATUS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTATUS.Size = New System.Drawing.Size(52, 14)
        Me.lblTitESTATUS.TabIndex = 115
        Me.lblTitESTATUS.Text = "Estado"
        '
        'lblDESCRIP_CORTA_ACTIVO
        '
        Me.lblDESCRIP_CORTA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIP_CORTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIP_CORTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIP_CORTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIP_CORTA_ACTIVO.Location = New System.Drawing.Point(284, 17)
        Me.lblDESCRIP_CORTA_ACTIVO.Name = "lblDESCRIP_CORTA_ACTIVO"
        Me.lblDESCRIP_CORTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIP_CORTA_ACTIVO.Size = New System.Drawing.Size(441, 20)
        Me.lblDESCRIP_CORTA_ACTIVO.TabIndex = 114
        Me.lblDESCRIP_CORTA_ACTIVO.UseMnemonic = False
        '
        'lblCATEGORIA_ID
        '
        Me.lblCATEGORIA_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblCATEGORIA_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCATEGORIA_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCATEGORIA_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCATEGORIA_ID.Location = New System.Drawing.Point(6, 234)
        Me.lblCATEGORIA_ID.Name = "lblCATEGORIA_ID"
        Me.lblCATEGORIA_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCATEGORIA_ID.Size = New System.Drawing.Size(141, 14)
        Me.lblCATEGORIA_ID.TabIndex = 113
        Me.lblCATEGORIA_ID.Text = "Categoria del activo"
        '
        'lblRESPONSABLE_ID
        '
        Me.lblRESPONSABLE_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblRESPONSABLE_ID.Location = New System.Drawing.Point(6, 210)
        Me.lblRESPONSABLE_ID.Name = "lblRESPONSABLE_ID"
        Me.lblRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRESPONSABLE_ID.Size = New System.Drawing.Size(141, 14)
        Me.lblRESPONSABLE_ID.TabIndex = 111
        Me.lblRESPONSABLE_ID.Text = "Responsable del activo"
        '
        'lblUBICACION
        '
        Me.lblUBICACION.BackColor = System.Drawing.Color.Transparent
        Me.lblUBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUBICACION.Location = New System.Drawing.Point(6, 186)
        Me.lblUBICACION.Name = "lblUBICACION"
        Me.lblUBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUBICACION.Size = New System.Drawing.Size(141, 14)
        Me.lblUBICACION.TabIndex = 109
        Me.lblUBICACION.Text = "Código de ubicación"
        '
        'lblCODIGO_MARCA
        '
        Me.lblCODIGO_MARCA.BackColor = System.Drawing.Color.Transparent
        Me.lblCODIGO_MARCA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_MARCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_MARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_MARCA.Location = New System.Drawing.Point(6, 162)
        Me.lblCODIGO_MARCA.Name = "lblCODIGO_MARCA"
        Me.lblCODIGO_MARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_MARCA.Size = New System.Drawing.Size(141, 14)
        Me.lblCODIGO_MARCA.TabIndex = 107
        Me.lblCODIGO_MARCA.Text = "Código de marca"
        '
        'lblREFERENCIA
        '
        Me.lblREFERENCIA.BackColor = System.Drawing.Color.Transparent
        Me.lblREFERENCIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblREFERENCIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREFERENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblREFERENCIA.Location = New System.Drawing.Point(6, 138)
        Me.lblREFERENCIA.Name = "lblREFERENCIA"
        Me.lblREFERENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblREFERENCIA.Size = New System.Drawing.Size(141, 14)
        Me.lblREFERENCIA.TabIndex = 105
        Me.lblREFERENCIA.Text = "Referencia activo fijo"
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(6, 113)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(141, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 103
        Me.lblTitCODIGO_DIVISION.Text = "Departamento"
        '
        'lblCODIGO_DIVISION
        '
        Me.lblCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DIVISION.Location = New System.Drawing.Point(153, 112)
        Me.lblCODIGO_DIVISION.Name = "lblCODIGO_DIVISION"
        Me.lblCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DIVISION.Size = New System.Drawing.Size(81, 20)
        Me.lblCODIGO_DIVISION.TabIndex = 102
        Me.lblCODIGO_DIVISION.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCODIGO_TIPO_ACTIVO
        '
        Me.lblCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_TIPO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(153, 88)
        Me.lblCODIGO_TIPO_ACTIVO.Name = "lblCODIGO_TIPO_ACTIVO"
        Me.lblCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(81, 20)
        Me.lblCODIGO_TIPO_ACTIVO.TabIndex = 101
        '
        'lblTitCODIGO_TIPO_ACTIVO
        '
        Me.lblTitCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(6, 89)
        Me.lblTitCODIGO_TIPO_ACTIVO.Name = "lblTitCODIGO_TIPO_ACTIVO"
        Me.lblTitCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(141, 14)
        Me.lblTitCODIGO_TIPO_ACTIVO.TabIndex = 100
        Me.lblTitCODIGO_TIPO_ACTIVO.Text = "Tipo de activo"
        '
        'lblCODIGO_PROVEEDOR
        '
        Me.lblCODIGO_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_PROVEEDOR.Location = New System.Drawing.Point(153, 64)
        Me.lblCODIGO_PROVEEDOR.Name = "lblCODIGO_PROVEEDOR"
        Me.lblCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_PROVEEDOR.Size = New System.Drawing.Size(125, 20)
        Me.lblCODIGO_PROVEEDOR.TabIndex = 99
        Me.lblCODIGO_PROVEEDOR.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitCODIGO_PROVEEDOR
        '
        Me.lblTitCODIGO_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_PROVEEDOR.Location = New System.Drawing.Point(6, 65)
        Me.lblTitCODIGO_PROVEEDOR.Name = "lblTitCODIGO_PROVEEDOR"
        Me.lblTitCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_PROVEEDOR.Size = New System.Drawing.Size(141, 14)
        Me.lblTitCODIGO_PROVEEDOR.TabIndex = 98
        Me.lblTitCODIGO_PROVEEDOR.Text = "Código de proveedor"
        '
        'lblMEJORA_CORRELATIVO
        '
        Me.lblMEJORA_CORRELATIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblMEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMEJORA_CORRELATIVO.Location = New System.Drawing.Point(153, 40)
        Me.lblMEJORA_CORRELATIVO.Name = "lblMEJORA_CORRELATIVO"
        Me.lblMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMEJORA_CORRELATIVO.Size = New System.Drawing.Size(58, 20)
        Me.lblMEJORA_CORRELATIVO.TabIndex = 97
        Me.lblMEJORA_CORRELATIVO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(6, 41)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(141, 14)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 96
        Me.lblTitMEJORA_CORRELATIVO.Text = "Mejora"
        '
        'lblCODIGO_DE_ACTIVO
        '
        Me.lblCODIGO_DE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(153, 16)
        Me.lblCODIGO_DE_ACTIVO.Name = "lblCODIGO_DE_ACTIVO"
        Me.lblCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(125, 20)
        Me.lblCODIGO_DE_ACTIVO.TabIndex = 95
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
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(141, 14)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 94
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Código activo"
        '
        'mhTab1
        '
        Me.mhTab1.Controls.Add(Me.TabPage1)
        Me.mhTab1.Controls.Add(Me.TabPage2)
        Me.mhTab1.Location = New System.Drawing.Point(12, 12)
        Me.mhTab1.Name = "mhTab1"
        Me.mhTab1.SelectedIndex = 0
        Me.mhTab1.Size = New System.Drawing.Size(751, 299)
        Me.mhTab1.TabIndex = 5
        '
        'FrameUno
        '
        Me.FrameUno.BackColor = System.Drawing.SystemColors.Control
        Me.FrameUno.Controls.Add(Me.grpDepreciacion)
        Me.FrameUno.Controls.Add(Me.grpValores)
        Me.FrameUno.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameUno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FrameUno.Location = New System.Drawing.Point(12, 317)
        Me.FrameUno.Name = "FrameUno"
        Me.FrameUno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameUno.Size = New System.Drawing.Size(645, 321)
        Me.FrameUno.TabIndex = 32
        Me.FrameUno.TabStop = False
        '
        'grpDepreciacion
        '
        Me.grpDepreciacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpDepreciacion.Controls.Add(Me.cboTipoDepreciacion)
        Me.grpDepreciacion.Controls.Add(Me.cboDepreciable)
        Me.grpDepreciacion.Controls.Add(Me.lblSALDO_MESES_DEPRE)
        Me.grpDepreciacion.Controls.Add(Me.lblTOTALMENTE_DEP)
        Me.grpDepreciacion.Controls.Add(Me.lblTIEMPO_DEPRECIACION)
        Me.grpDepreciacion.Controls.Add(Me.lblPORCENTAJE_ANUAL_DEP)
        Me.grpDepreciacion.Controls.Add(Me.lblTitTIPO_DEPRECIACION)
        Me.grpDepreciacion.Controls.Add(Me.lblTitTIEMPO_DEPRECIACION)
        Me.grpDepreciacion.Controls.Add(Me.lblTitPORCENTAJE_ANUAL_DEP)
        Me.grpDepreciacion.Controls.Add(Me.lblTitDEPRECIABLE)
        Me.grpDepreciacion.Controls.Add(Me.lblTitSALDO_MESES_DEPRE)
        Me.grpDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpDepreciacion.Location = New System.Drawing.Point(6, 229)
        Me.grpDepreciacion.Name = "grpDepreciacion"
        Me.grpDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDepreciacion.Size = New System.Drawing.Size(633, 86)
        Me.grpDepreciacion.TabIndex = 32
        Me.grpDepreciacion.TabStop = False
        Me.grpDepreciacion.Text = " Depreciación "
        '
        'cboTipoDepreciacion
        '
        Me.cboTipoDepreciacion.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDepreciacion.Enabled = False
        Me.cboTipoDepreciacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoDepreciacion.Location = New System.Drawing.Point(324, 19)
        Me.cboTipoDepreciacion.Name = "cboTipoDepreciacion"
        Me.cboTipoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoDepreciacion.Size = New System.Drawing.Size(151, 22)
        Me.cboTipoDepreciacion.TabIndex = 33
        '
        'cboDepreciable
        '
        Me.cboDepreciable.BackColor = System.Drawing.SystemColors.Window
        Me.cboDepreciable.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDepreciable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepreciable.Enabled = False
        Me.cboDepreciable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepreciable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDepreciable.Location = New System.Drawing.Point(89, 19)
        Me.cboDepreciable.Name = "cboDepreciable"
        Me.cboDepreciable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDepreciable.Size = New System.Drawing.Size(131, 22)
        Me.cboDepreciable.TabIndex = 34
        '
        'lblSALDO_MESES_DEPRE
        '
        Me.lblSALDO_MESES_DEPRE.AcceptsReturn = True
        Me.lblSALDO_MESES_DEPRE.BackColor = System.Drawing.SystemColors.Window
        Me.lblSALDO_MESES_DEPRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSALDO_MESES_DEPRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSALDO_MESES_DEPRE.Enabled = False
        Me.lblSALDO_MESES_DEPRE.EsRequerido = False
        Me.lblSALDO_MESES_DEPRE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSALDO_MESES_DEPRE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSALDO_MESES_DEPRE.LabelConsulta = Nothing
        Me.lblSALDO_MESES_DEPRE.Location = New System.Drawing.Point(324, 47)
        Me.lblSALDO_MESES_DEPRE.MaxLength = 0
        Me.lblSALDO_MESES_DEPRE.Name = "lblSALDO_MESES_DEPRE"
        Me.lblSALDO_MESES_DEPRE.NombreDeConsulta = Nothing
        Me.lblSALDO_MESES_DEPRE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSALDO_MESES_DEPRE.Size = New System.Drawing.Size(61, 20)
        Me.lblSALDO_MESES_DEPRE.TabIndex = 35
        '
        'lblTOTALMENTE_DEP
        '
        Me.lblTOTALMENTE_DEP.AutoSize = True
        Me.lblTOTALMENTE_DEP.BackColor = System.Drawing.Color.Transparent
        Me.lblTOTALMENTE_DEP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTOTALMENTE_DEP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOTALMENTE_DEP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTOTALMENTE_DEP.Location = New System.Drawing.Point(384, 49)
        Me.lblTOTALMENTE_DEP.Name = "lblTOTALMENTE_DEP"
        Me.lblTOTALMENTE_DEP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTOTALMENTE_DEP.Size = New System.Drawing.Size(0, 14)
        Me.lblTOTALMENTE_DEP.TabIndex = 80
        '
        'lblTIEMPO_DEPRECIACION
        '
        Me.lblTIEMPO_DEPRECIACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblTIEMPO_DEPRECIACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTIEMPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTIEMPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIEMPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTIEMPO_DEPRECIACION.Location = New System.Drawing.Point(152, 48)
        Me.lblTIEMPO_DEPRECIACION.Name = "lblTIEMPO_DEPRECIACION"
        Me.lblTIEMPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTIEMPO_DEPRECIACION.Size = New System.Drawing.Size(68, 20)
        Me.lblTIEMPO_DEPRECIACION.TabIndex = 36
        Me.lblTIEMPO_DEPRECIACION.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPORCENTAJE_ANUAL_DEP
        '
        Me.lblPORCENTAJE_ANUAL_DEP.BackColor = System.Drawing.SystemColors.Window
        Me.lblPORCENTAJE_ANUAL_DEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPORCENTAJE_ANUAL_DEP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPORCENTAJE_ANUAL_DEP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPORCENTAJE_ANUAL_DEP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPORCENTAJE_ANUAL_DEP.Location = New System.Drawing.Point(570, 16)
        Me.lblPORCENTAJE_ANUAL_DEP.Name = "lblPORCENTAJE_ANUAL_DEP"
        Me.lblPORCENTAJE_ANUAL_DEP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPORCENTAJE_ANUAL_DEP.Size = New System.Drawing.Size(57, 20)
        Me.lblPORCENTAJE_ANUAL_DEP.TabIndex = 37
        Me.lblPORCENTAJE_ANUAL_DEP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitTIPO_DEPRECIACION
        '
        Me.lblTitTIPO_DEPRECIACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_DEPRECIACION.Location = New System.Drawing.Point(226, 22)
        Me.lblTitTIPO_DEPRECIACION.Name = "lblTitTIPO_DEPRECIACION"
        Me.lblTitTIPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_DEPRECIACION.Size = New System.Drawing.Size(92, 14)
        Me.lblTitTIPO_DEPRECIACION.TabIndex = 38
        Me.lblTitTIPO_DEPRECIACION.Text = "Tipo depreciación"
        '
        'lblTitTIEMPO_DEPRECIACION
        '
        Me.lblTitTIEMPO_DEPRECIACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIEMPO_DEPRECIACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIEMPO_DEPRECIACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIEMPO_DEPRECIACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIEMPO_DEPRECIACION.Location = New System.Drawing.Point(6, 49)
        Me.lblTitTIEMPO_DEPRECIACION.Name = "lblTitTIEMPO_DEPRECIACION"
        Me.lblTitTIEMPO_DEPRECIACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIEMPO_DEPRECIACION.Size = New System.Drawing.Size(141, 28)
        Me.lblTitTIEMPO_DEPRECIACION.TabIndex = 39
        Me.lblTitTIEMPO_DEPRECIACION.Text = "Tiempo a ejecutar depreciación (meses)"
        '
        'lblTitPORCENTAJE_ANUAL_DEP
        '
        Me.lblTitPORCENTAJE_ANUAL_DEP.BackColor = System.Drawing.Color.Transparent
        Me.lblTitPORCENTAJE_ANUAL_DEP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitPORCENTAJE_ANUAL_DEP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPORCENTAJE_ANUAL_DEP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitPORCENTAJE_ANUAL_DEP.Location = New System.Drawing.Point(490, 16)
        Me.lblTitPORCENTAJE_ANUAL_DEP.Name = "lblTitPORCENTAJE_ANUAL_DEP"
        Me.lblTitPORCENTAJE_ANUAL_DEP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitPORCENTAJE_ANUAL_DEP.Size = New System.Drawing.Size(74, 29)
        Me.lblTitPORCENTAJE_ANUAL_DEP.TabIndex = 40
        Me.lblTitPORCENTAJE_ANUAL_DEP.Text = "% Anual depreciación"
        '
        'lblTitDEPRECIABLE
        '
        Me.lblTitDEPRECIABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDEPRECIABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDEPRECIABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDEPRECIABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDEPRECIABLE.Location = New System.Drawing.Point(6, 22)
        Me.lblTitDEPRECIABLE.Name = "lblTitDEPRECIABLE"
        Me.lblTitDEPRECIABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDEPRECIABLE.Size = New System.Drawing.Size(82, 14)
        Me.lblTitDEPRECIABLE.TabIndex = 41
        Me.lblTitDEPRECIABLE.Text = "Depreciable"
        '
        'lblTitSALDO_MESES_DEPRE
        '
        Me.lblTitSALDO_MESES_DEPRE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitSALDO_MESES_DEPRE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitSALDO_MESES_DEPRE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitSALDO_MESES_DEPRE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitSALDO_MESES_DEPRE.Location = New System.Drawing.Point(226, 47)
        Me.lblTitSALDO_MESES_DEPRE.Name = "lblTitSALDO_MESES_DEPRE"
        Me.lblTitSALDO_MESES_DEPRE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitSALDO_MESES_DEPRE.Size = New System.Drawing.Size(92, 30)
        Me.lblTitSALDO_MESES_DEPRE.TabIndex = 42
        Me.lblTitSALDO_MESES_DEPRE.Text = "Saldo meses depreciación"
        '
        'grpValores
        '
        Me.grpValores.BackColor = System.Drawing.SystemColors.Control
        Me.grpValores.Controls.Add(Me.txtVALOR_MONEDA_LOCAL)
        Me.grpValores.Controls.Add(Me.lblVALOR_MONEDA_LOCAL)
        Me.grpValores.Controls.Add(Me.lblVALOR_NO_DEDUCIBLE)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_NO_DEDUCIBLE)
        Me.grpValores.Controls.Add(Me.lblTASA_DEDUCIBLE_ISR)
        Me.grpValores.Controls.Add(Me.lblVALOR_ACTUAL_ACTIVO)
        Me.grpValores.Controls.Add(Me.lblMONTO_REVALUACIONES)
        Me.grpValores.Controls.Add(Me.lblTitTASA_DEDUCIBLE_ISR)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_ORIG_ACT_USADO)
        Me.grpValores.Controls.Add(Me.lblVALOR_ORIG_ACT_USADO)
        Me.grpValores.Controls.Add(Me.Label1)
        Me.grpValores.Controls.Add(Me.lblVALOR_ORIGINAL_ACTIV)
        Me.grpValores.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.grpValores.Controls.Add(Me.lblDESCRIPCION_MONEDA)
        Me.grpValores.Controls.Add(Me.lblCODIGO_DE_MONEDA)
        Me.grpValores.Controls.Add(Me.lblTitTASA_CAMBIO_COMPRA)
        Me.grpValores.Controls.Add(Me.lblTASA_CAMBIO_COMPRA)
        Me.grpValores.Controls.Add(Me.lblVALOR_TOT_ACTIVO)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_TOT_ACTIVO)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_DEP_ACUM_ACT)
        Me.grpValores.Controls.Add(Me.lblVALOR_DEP_ACUM_ACT)
        Me.grpValores.Controls.Add(Me.lblVALOR_RESCATE_ACTIVO)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_ORIGINAL_ACTIV)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_ACTUAL_ACTIVO)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_RESCATE_ACTIVO)
        Me.grpValores.Controls.Add(Me.lblTitMONTO_REVALUACIONES)
        Me.grpValores.Controls.Add(Me.lblTitVALOR_DEP_PERIODO)
        Me.grpValores.Controls.Add(Me.lblVALOR_DEP_PERIODO)
        Me.grpValores.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpValores.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpValores.Location = New System.Drawing.Point(6, 19)
        Me.grpValores.Name = "grpValores"
        Me.grpValores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpValores.Size = New System.Drawing.Size(633, 204)
        Me.grpValores.TabIndex = 43
        Me.grpValores.TabStop = False
        Me.grpValores.Text = " Valores "
        '
        'txtVALOR_MONEDA_LOCAL
        '
        Me.txtVALOR_MONEDA_LOCAL.AcceptsReturn = True
        Me.txtVALOR_MONEDA_LOCAL.BackColor = System.Drawing.SystemColors.Window
        Me.txtVALOR_MONEDA_LOCAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_MONEDA_LOCAL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVALOR_MONEDA_LOCAL.Enabled = False
        Me.txtVALOR_MONEDA_LOCAL.EsRequerido = False
        Me.txtVALOR_MONEDA_LOCAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVALOR_MONEDA_LOCAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVALOR_MONEDA_LOCAL.LabelConsulta = Nothing
        Me.txtVALOR_MONEDA_LOCAL.Location = New System.Drawing.Point(176, 145)
        Me.txtVALOR_MONEDA_LOCAL.MaxLength = 13
        Me.txtVALOR_MONEDA_LOCAL.Multiline = True
        Me.txtVALOR_MONEDA_LOCAL.Name = "txtVALOR_MONEDA_LOCAL"
        Me.txtVALOR_MONEDA_LOCAL.NombreDeConsulta = Nothing
        Me.txtVALOR_MONEDA_LOCAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVALOR_MONEDA_LOCAL.Size = New System.Drawing.Size(113, 20)
        Me.txtVALOR_MONEDA_LOCAL.TabIndex = 88
        Me.txtVALOR_MONEDA_LOCAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVALOR_MONEDA_LOCAL
        '
        Me.lblVALOR_MONEDA_LOCAL.BackColor = System.Drawing.Color.Transparent
        Me.lblVALOR_MONEDA_LOCAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_MONEDA_LOCAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_MONEDA_LOCAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_MONEDA_LOCAL.Location = New System.Drawing.Point(6, 147)
        Me.lblVALOR_MONEDA_LOCAL.Name = "lblVALOR_MONEDA_LOCAL"
        Me.lblVALOR_MONEDA_LOCAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_MONEDA_LOCAL.Size = New System.Drawing.Size(164, 14)
        Me.lblVALOR_MONEDA_LOCAL.TabIndex = 89
        Me.lblVALOR_MONEDA_LOCAL.Text = "Valor moneda de compra"
        '
        'lblVALOR_NO_DEDUCIBLE
        '
        Me.lblVALOR_NO_DEDUCIBLE.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_NO_DEDUCIBLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_NO_DEDUCIBLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_NO_DEDUCIBLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_NO_DEDUCIBLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_NO_DEDUCIBLE.Location = New System.Drawing.Point(176, 94)
        Me.lblVALOR_NO_DEDUCIBLE.Name = "lblVALOR_NO_DEDUCIBLE"
        Me.lblVALOR_NO_DEDUCIBLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_NO_DEDUCIBLE.Size = New System.Drawing.Size(113, 20)
        Me.lblVALOR_NO_DEDUCIBLE.TabIndex = 81
        Me.lblVALOR_NO_DEDUCIBLE.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitVALOR_NO_DEDUCIBLE
        '
        Me.lblTitVALOR_NO_DEDUCIBLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_NO_DEDUCIBLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_NO_DEDUCIBLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_NO_DEDUCIBLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_NO_DEDUCIBLE.Location = New System.Drawing.Point(6, 95)
        Me.lblTitVALOR_NO_DEDUCIBLE.Name = "lblTitVALOR_NO_DEDUCIBLE"
        Me.lblTitVALOR_NO_DEDUCIBLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_NO_DEDUCIBLE.Size = New System.Drawing.Size(164, 14)
        Me.lblTitVALOR_NO_DEDUCIBLE.TabIndex = 82
        Me.lblTitVALOR_NO_DEDUCIBLE.Text = "Valor no deducible"
        '
        'lblTASA_DEDUCIBLE_ISR
        '
        Me.lblTASA_DEDUCIBLE_ISR.BackColor = System.Drawing.SystemColors.Window
        Me.lblTASA_DEDUCIBLE_ISR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTASA_DEDUCIBLE_ISR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTASA_DEDUCIBLE_ISR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTASA_DEDUCIBLE_ISR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTASA_DEDUCIBLE_ISR.Location = New System.Drawing.Point(514, 68)
        Me.lblTASA_DEDUCIBLE_ISR.Name = "lblTASA_DEDUCIBLE_ISR"
        Me.lblTASA_DEDUCIBLE_ISR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTASA_DEDUCIBLE_ISR.Size = New System.Drawing.Size(113, 20)
        Me.lblTASA_DEDUCIBLE_ISR.TabIndex = 84
        Me.lblTASA_DEDUCIBLE_ISR.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVALOR_ACTUAL_ACTIVO
        '
        Me.lblVALOR_ACTUAL_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_ACTUAL_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_ACTUAL_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_ACTUAL_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_ACTUAL_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_ACTUAL_ACTIVO.Location = New System.Drawing.Point(514, 42)
        Me.lblVALOR_ACTUAL_ACTIVO.Name = "lblVALOR_ACTUAL_ACTIVO"
        Me.lblVALOR_ACTUAL_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_ACTUAL_ACTIVO.Size = New System.Drawing.Size(113, 20)
        Me.lblVALOR_ACTUAL_ACTIVO.TabIndex = 54
        Me.lblVALOR_ACTUAL_ACTIVO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMONTO_REVALUACIONES
        '
        Me.lblMONTO_REVALUACIONES.BackColor = System.Drawing.SystemColors.Window
        Me.lblMONTO_REVALUACIONES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMONTO_REVALUACIONES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMONTO_REVALUACIONES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTO_REVALUACIONES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMONTO_REVALUACIONES.Location = New System.Drawing.Point(514, 16)
        Me.lblMONTO_REVALUACIONES.Name = "lblMONTO_REVALUACIONES"
        Me.lblMONTO_REVALUACIONES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMONTO_REVALUACIONES.Size = New System.Drawing.Size(113, 20)
        Me.lblMONTO_REVALUACIONES.TabIndex = 61
        Me.lblMONTO_REVALUACIONES.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitTASA_DEDUCIBLE_ISR
        '
        Me.lblTitTASA_DEDUCIBLE_ISR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_DEDUCIBLE_ISR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_DEDUCIBLE_ISR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_DEDUCIBLE_ISR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_DEDUCIBLE_ISR.Location = New System.Drawing.Point(321, 69)
        Me.lblTitTASA_DEDUCIBLE_ISR.Name = "lblTitTASA_DEDUCIBLE_ISR"
        Me.lblTitTASA_DEDUCIBLE_ISR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_DEDUCIBLE_ISR.Size = New System.Drawing.Size(187, 14)
        Me.lblTitTASA_DEDUCIBLE_ISR.TabIndex = 87
        Me.lblTitTASA_DEDUCIBLE_ISR.Text = "Tasa deducible ISR"
        '
        'lblTitVALOR_ORIG_ACT_USADO
        '
        Me.lblTitVALOR_ORIG_ACT_USADO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_ORIG_ACT_USADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_ORIG_ACT_USADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_ORIG_ACT_USADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_ORIG_ACT_USADO.Location = New System.Drawing.Point(6, 69)
        Me.lblTitVALOR_ORIG_ACT_USADO.Name = "lblTitVALOR_ORIG_ACT_USADO"
        Me.lblTitVALOR_ORIG_ACT_USADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_ORIG_ACT_USADO.Size = New System.Drawing.Size(164, 14)
        Me.lblTitVALOR_ORIG_ACT_USADO.TabIndex = 86
        Me.lblTitVALOR_ORIG_ACT_USADO.Text = "Valor original act. comprado"
        '
        'lblVALOR_ORIG_ACT_USADO
        '
        Me.lblVALOR_ORIG_ACT_USADO.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_ORIG_ACT_USADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_ORIG_ACT_USADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_ORIG_ACT_USADO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_ORIG_ACT_USADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_ORIG_ACT_USADO.Location = New System.Drawing.Point(176, 68)
        Me.lblVALOR_ORIG_ACT_USADO.Name = "lblVALOR_ORIG_ACT_USADO"
        Me.lblVALOR_ORIG_ACT_USADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_ORIG_ACT_USADO.Size = New System.Drawing.Size(113, 20)
        Me.lblVALOR_ORIG_ACT_USADO.TabIndex = 85
        Me.lblVALOR_ORIG_ACT_USADO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(8, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(0, 14)
        Me.Label1.TabIndex = 83
        '
        'lblVALOR_ORIGINAL_ACTIV
        '
        Me.lblVALOR_ORIGINAL_ACTIV.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_ORIGINAL_ACTIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_ORIGINAL_ACTIV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_ORIGINAL_ACTIV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_ORIGINAL_ACTIV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_ORIGINAL_ACTIV.Location = New System.Drawing.Point(176, 16)
        Me.lblVALOR_ORIGINAL_ACTIV.Name = "lblVALOR_ORIGINAL_ACTIV"
        Me.lblVALOR_ORIGINAL_ACTIV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_ORIGINAL_ACTIV.Size = New System.Drawing.Size(113, 20)
        Me.lblVALOR_ORIGINAL_ACTIV.TabIndex = 53
        Me.lblVALOR_ORIGINAL_ACTIV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(6, 169)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(164, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 44
        Me.lblTitCODIGO_DE_MONEDA.Text = "Moneda"
        '
        'lblDESCRIPCION_MONEDA
        '
        Me.lblDESCRIPCION_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_MONEDA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_MONEDA.Location = New System.Drawing.Point(224, 169)
        Me.lblDESCRIPCION_MONEDA.Name = "lblDESCRIPCION_MONEDA"
        Me.lblDESCRIPCION_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_MONEDA.Size = New System.Drawing.Size(399, 20)
        Me.lblDESCRIPCION_MONEDA.TabIndex = 45
        Me.lblDESCRIPCION_MONEDA.UseMnemonic = False
        '
        'lblCODIGO_DE_MONEDA
        '
        Me.lblCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DE_MONEDA.Location = New System.Drawing.Point(176, 168)
        Me.lblCODIGO_DE_MONEDA.Name = "lblCODIGO_DE_MONEDA"
        Me.lblCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DE_MONEDA.Size = New System.Drawing.Size(42, 21)
        Me.lblCODIGO_DE_MONEDA.TabIndex = 46
        '
        'lblTitTASA_CAMBIO_COMPRA
        '
        Me.lblTitTASA_CAMBIO_COMPRA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_CAMBIO_COMPRA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_CAMBIO_COMPRA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_CAMBIO_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_CAMBIO_COMPRA.Location = New System.Drawing.Point(321, 147)
        Me.lblTitTASA_CAMBIO_COMPRA.Name = "lblTitTASA_CAMBIO_COMPRA"
        Me.lblTitTASA_CAMBIO_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_CAMBIO_COMPRA.Size = New System.Drawing.Size(187, 14)
        Me.lblTitTASA_CAMBIO_COMPRA.TabIndex = 47
        Me.lblTitTASA_CAMBIO_COMPRA.Text = "Tasa cambio compra"
        '
        'lblTASA_CAMBIO_COMPRA
        '
        Me.lblTASA_CAMBIO_COMPRA.BackColor = System.Drawing.SystemColors.Window
        Me.lblTASA_CAMBIO_COMPRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTASA_CAMBIO_COMPRA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTASA_CAMBIO_COMPRA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTASA_CAMBIO_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTASA_CAMBIO_COMPRA.Location = New System.Drawing.Point(514, 146)
        Me.lblTASA_CAMBIO_COMPRA.Name = "lblTASA_CAMBIO_COMPRA"
        Me.lblTASA_CAMBIO_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTASA_CAMBIO_COMPRA.Size = New System.Drawing.Size(113, 20)
        Me.lblTASA_CAMBIO_COMPRA.TabIndex = 48
        Me.lblTASA_CAMBIO_COMPRA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVALOR_TOT_ACTIVO
        '
        Me.lblVALOR_TOT_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_TOT_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_TOT_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_TOT_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_TOT_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_TOT_ACTIVO.Location = New System.Drawing.Point(176, 42)
        Me.lblVALOR_TOT_ACTIVO.Name = "lblVALOR_TOT_ACTIVO"
        Me.lblVALOR_TOT_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_TOT_ACTIVO.Size = New System.Drawing.Size(113, 20)
        Me.lblVALOR_TOT_ACTIVO.TabIndex = 49
        Me.lblVALOR_TOT_ACTIVO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitVALOR_TOT_ACTIVO
        '
        Me.lblTitVALOR_TOT_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_TOT_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_TOT_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_TOT_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_TOT_ACTIVO.Location = New System.Drawing.Point(6, 43)
        Me.lblTitVALOR_TOT_ACTIVO.Name = "lblTitVALOR_TOT_ACTIVO"
        Me.lblTitVALOR_TOT_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_TOT_ACTIVO.Size = New System.Drawing.Size(164, 14)
        Me.lblTitVALOR_TOT_ACTIVO.TabIndex = 50
        Me.lblTitVALOR_TOT_ACTIVO.Text = "Valor total activo"
        '
        'lblTitVALOR_DEP_ACUM_ACT
        '
        Me.lblTitVALOR_DEP_ACUM_ACT.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_DEP_ACUM_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_DEP_ACUM_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_DEP_ACUM_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_DEP_ACUM_ACT.Location = New System.Drawing.Point(321, 121)
        Me.lblTitVALOR_DEP_ACUM_ACT.Name = "lblTitVALOR_DEP_ACUM_ACT"
        Me.lblTitVALOR_DEP_ACUM_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_DEP_ACUM_ACT.Size = New System.Drawing.Size(187, 14)
        Me.lblTitVALOR_DEP_ACUM_ACT.TabIndex = 51
        Me.lblTitVALOR_DEP_ACUM_ACT.Text = "Depreciación acumulada"
        '
        'lblVALOR_DEP_ACUM_ACT
        '
        Me.lblVALOR_DEP_ACUM_ACT.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_DEP_ACUM_ACT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_DEP_ACUM_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_DEP_ACUM_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_DEP_ACUM_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_DEP_ACUM_ACT.Location = New System.Drawing.Point(514, 120)
        Me.lblVALOR_DEP_ACUM_ACT.Name = "lblVALOR_DEP_ACUM_ACT"
        Me.lblVALOR_DEP_ACUM_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_DEP_ACUM_ACT.Size = New System.Drawing.Size(113, 21)
        Me.lblVALOR_DEP_ACUM_ACT.TabIndex = 52
        Me.lblVALOR_DEP_ACUM_ACT.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVALOR_RESCATE_ACTIVO
        '
        Me.lblVALOR_RESCATE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_RESCATE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_RESCATE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_RESCATE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_RESCATE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_RESCATE_ACTIVO.Location = New System.Drawing.Point(514, 94)
        Me.lblVALOR_RESCATE_ACTIVO.Name = "lblVALOR_RESCATE_ACTIVO"
        Me.lblVALOR_RESCATE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_RESCATE_ACTIVO.Size = New System.Drawing.Size(113, 21)
        Me.lblVALOR_RESCATE_ACTIVO.TabIndex = 55
        Me.lblVALOR_RESCATE_ACTIVO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitVALOR_ORIGINAL_ACTIV
        '
        Me.lblTitVALOR_ORIGINAL_ACTIV.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_ORIGINAL_ACTIV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_ORIGINAL_ACTIV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_ORIGINAL_ACTIV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_ORIGINAL_ACTIV.Location = New System.Drawing.Point(6, 17)
        Me.lblTitVALOR_ORIGINAL_ACTIV.Name = "lblTitVALOR_ORIGINAL_ACTIV"
        Me.lblTitVALOR_ORIGINAL_ACTIV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_ORIGINAL_ACTIV.Size = New System.Drawing.Size(164, 14)
        Me.lblTitVALOR_ORIGINAL_ACTIV.TabIndex = 56
        Me.lblTitVALOR_ORIGINAL_ACTIV.Text = "Valor original quetzales"
        '
        'lblTitVALOR_ACTUAL_ACTIVO
        '
        Me.lblTitVALOR_ACTUAL_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_ACTUAL_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_ACTUAL_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_ACTUAL_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_ACTUAL_ACTIVO.Location = New System.Drawing.Point(321, 43)
        Me.lblTitVALOR_ACTUAL_ACTIVO.Name = "lblTitVALOR_ACTUAL_ACTIVO"
        Me.lblTitVALOR_ACTUAL_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_ACTUAL_ACTIVO.Size = New System.Drawing.Size(187, 14)
        Me.lblTitVALOR_ACTUAL_ACTIVO.TabIndex = 57
        Me.lblTitVALOR_ACTUAL_ACTIVO.Text = "Valor actual activo"
        '
        'lblTitVALOR_RESCATE_ACTIVO
        '
        Me.lblTitVALOR_RESCATE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_RESCATE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_RESCATE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_RESCATE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_RESCATE_ACTIVO.Location = New System.Drawing.Point(321, 95)
        Me.lblTitVALOR_RESCATE_ACTIVO.Name = "lblTitVALOR_RESCATE_ACTIVO"
        Me.lblTitVALOR_RESCATE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_RESCATE_ACTIVO.Size = New System.Drawing.Size(187, 14)
        Me.lblTitVALOR_RESCATE_ACTIVO.TabIndex = 58
        Me.lblTitVALOR_RESCATE_ACTIVO.Text = "Valor de rescate"
        '
        'lblTitMONTO_REVALUACIONES
        '
        Me.lblTitMONTO_REVALUACIONES.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_REVALUACIONES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_REVALUACIONES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_REVALUACIONES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_REVALUACIONES.Location = New System.Drawing.Point(321, 17)
        Me.lblTitMONTO_REVALUACIONES.Name = "lblTitMONTO_REVALUACIONES"
        Me.lblTitMONTO_REVALUACIONES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_REVALUACIONES.Size = New System.Drawing.Size(187, 13)
        Me.lblTitMONTO_REVALUACIONES.TabIndex = 59
        Me.lblTitMONTO_REVALUACIONES.Text = "Valor por revaluaciones"
        '
        'lblTitVALOR_DEP_PERIODO
        '
        Me.lblTitVALOR_DEP_PERIODO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_DEP_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_DEP_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_DEP_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_DEP_PERIODO.Location = New System.Drawing.Point(6, 114)
        Me.lblTitVALOR_DEP_PERIODO.Name = "lblTitVALOR_DEP_PERIODO"
        Me.lblTitVALOR_DEP_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_DEP_PERIODO.Size = New System.Drawing.Size(164, 29)
        Me.lblTitVALOR_DEP_PERIODO.TabIndex = 63
        Me.lblTitVALOR_DEP_PERIODO.Text = "Depreciación acum. periodo fiscal"
        '
        'lblVALOR_DEP_PERIODO
        '
        Me.lblVALOR_DEP_PERIODO.BackColor = System.Drawing.SystemColors.Window
        Me.lblVALOR_DEP_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVALOR_DEP_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVALOR_DEP_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVALOR_DEP_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblVALOR_DEP_PERIODO.Location = New System.Drawing.Point(176, 120)
        Me.lblVALOR_DEP_PERIODO.Name = "lblVALOR_DEP_PERIODO"
        Me.lblVALOR_DEP_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVALOR_DEP_PERIODO.Size = New System.Drawing.Size(113, 20)
        Me.lblVALOR_DEP_PERIODO.TabIndex = 64
        Me.lblVALOR_DEP_PERIODO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAnterior.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAnterior.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnterior.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAnterior.Location = New System.Drawing.Point(663, 580)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAnterior.Size = New System.Drawing.Size(100, 25)
        Me.cmdAnterior.TabIndex = 72
        Me.cmdAnterior.Text = "Pantalla Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = False
        '
        'cmdInfoGeneral
        '
        Me.cmdInfoGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.cmdInfoGeneral.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInfoGeneral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInfoGeneral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdInfoGeneral.Location = New System.Drawing.Point(663, 549)
        Me.cmdInfoGeneral.Name = "cmdInfoGeneral"
        Me.cmdInfoGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdInfoGeneral.Size = New System.Drawing.Size(100, 25)
        Me.cmdInfoGeneral.TabIndex = 71
        Me.cmdInfoGeneral.Text = "Información Gral."
        Me.cmdInfoGeneral.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(663, 611)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 25)
        Me.cmdAceptar.TabIndex = 70
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSiguiente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSiguiente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiguiente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSiguiente.Location = New System.Drawing.Point(663, 580)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSiguiente.Size = New System.Drawing.Size(100, 25)
        Me.cmdSiguiente.TabIndex = 73
        Me.cmdSiguiente.Text = "Pantalla Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = False
        '
        'FrameDos
        '
        Me.FrameDos.BackColor = System.Drawing.SystemColors.Control
        Me.FrameDos.Controls.Add(Me.grpFechas)
        Me.FrameDos.Controls.Add(Me.grpOtros)
        Me.FrameDos.Controls.Add(Me.grpUltimaActualizacion)
        Me.FrameDos.Controls.Add(Me.grpUltimoMovimiento)
        Me.FrameDos.Controls.Add(Me.grpAuditoria)
        Me.FrameDos.Controls.Add(Me.grpUltimaDepreciacion)
        Me.FrameDos.Controls.Add(Me.grpUltimaReevaluacion)
        Me.FrameDos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameDos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FrameDos.Location = New System.Drawing.Point(12, 317)
        Me.FrameDos.Name = "FrameDos"
        Me.FrameDos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameDos.Size = New System.Drawing.Size(645, 321)
        Me.FrameDos.TabIndex = 74
        Me.FrameDos.TabStop = False
        '
        'grpFechas
        '
        Me.grpFechas.BackColor = System.Drawing.SystemColors.Control
        Me.grpFechas.Controls.Add(Me.lblNO_PERIODO)
        Me.grpFechas.Controls.Add(Me.lblANO_PERIODO)
        Me.grpFechas.Controls.Add(Me.lblFECHA_INICIO_DEPREC)
        Me.grpFechas.Controls.Add(Me.lblTitFECHA_INICIO_DEPREC)
        Me.grpFechas.Controls.Add(Me.lblTitFECHA_BAJA_ACTIVO)
        Me.grpFechas.Controls.Add(Me.lblFECHA_BAJA_ACTIVO)
        Me.grpFechas.Controls.Add(Me.lblFECHA_ADQUISICION)
        Me.grpFechas.Controls.Add(Me.lblTitFECHA_ADQUISICION)
        Me.grpFechas.Controls.Add(Me.lblTitNO_PERIODO)
        Me.grpFechas.Controls.Add(Me.lblTitANO_PERIODO)
        Me.grpFechas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFechas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpFechas.Location = New System.Drawing.Point(6, 194)
        Me.grpFechas.Name = "grpFechas"
        Me.grpFechas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpFechas.Size = New System.Drawing.Size(633, 69)
        Me.grpFechas.TabIndex = 75
        Me.grpFechas.TabStop = False
        Me.grpFechas.Text = " Fechas "
        '
        'lblNO_PERIODO
        '
        Me.lblNO_PERIODO.AcceptsReturn = True
        Me.lblNO_PERIODO.BackColor = System.Drawing.SystemColors.Window
        Me.lblNO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNO_PERIODO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNO_PERIODO.Enabled = False
        Me.lblNO_PERIODO.EsRequerido = False
        Me.lblNO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNO_PERIODO.LabelConsulta = Nothing
        Me.lblNO_PERIODO.Location = New System.Drawing.Point(131, 39)
        Me.lblNO_PERIODO.MaxLength = 0
        Me.lblNO_PERIODO.Name = "lblNO_PERIODO"
        Me.lblNO_PERIODO.NombreDeConsulta = Nothing
        Me.lblNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNO_PERIODO.Size = New System.Drawing.Size(70, 20)
        Me.lblNO_PERIODO.TabIndex = 77
        '
        'lblANO_PERIODO
        '
        Me.lblANO_PERIODO.AcceptsReturn = True
        Me.lblANO_PERIODO.BackColor = System.Drawing.SystemColors.Window
        Me.lblANO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblANO_PERIODO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblANO_PERIODO.Enabled = False
        Me.lblANO_PERIODO.EsRequerido = False
        Me.lblANO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblANO_PERIODO.LabelConsulta = Nothing
        Me.lblANO_PERIODO.Location = New System.Drawing.Point(344, 39)
        Me.lblANO_PERIODO.MaxLength = 0
        Me.lblANO_PERIODO.Name = "lblANO_PERIODO"
        Me.lblANO_PERIODO.NombreDeConsulta = Nothing
        Me.lblANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblANO_PERIODO.Size = New System.Drawing.Size(70, 20)
        Me.lblANO_PERIODO.TabIndex = 76
        '
        'lblFECHA_INICIO_DEPREC
        '
        Me.lblFECHA_INICIO_DEPREC.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_INICIO_DEPREC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_INICIO_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_INICIO_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_INICIO_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_INICIO_DEPREC.Location = New System.Drawing.Point(557, 16)
        Me.lblFECHA_INICIO_DEPREC.Name = "lblFECHA_INICIO_DEPREC"
        Me.lblFECHA_INICIO_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_INICIO_DEPREC.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_INICIO_DEPREC.TabIndex = 90
        '
        'lblTitFECHA_INICIO_DEPREC
        '
        Me.lblTitFECHA_INICIO_DEPREC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_INICIO_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_INICIO_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_INICIO_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_INICIO_DEPREC.Location = New System.Drawing.Point(432, 16)
        Me.lblTitFECHA_INICIO_DEPREC.Name = "lblTitFECHA_INICIO_DEPREC"
        Me.lblTitFECHA_INICIO_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_INICIO_DEPREC.Size = New System.Drawing.Size(119, 29)
        Me.lblTitFECHA_INICIO_DEPREC.TabIndex = 91
        Me.lblTitFECHA_INICIO_DEPREC.Text = "Fecha inicio depreciacion"
        '
        'lblTitFECHA_BAJA_ACTIVO
        '
        Me.lblTitFECHA_BAJA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_BAJA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_BAJA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_BAJA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_BAJA_ACTIVO.Location = New System.Drawing.Point(211, 17)
        Me.lblTitFECHA_BAJA_ACTIVO.Name = "lblTitFECHA_BAJA_ACTIVO"
        Me.lblTitFECHA_BAJA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_BAJA_ACTIVO.Size = New System.Drawing.Size(127, 14)
        Me.lblTitFECHA_BAJA_ACTIVO.TabIndex = 60
        Me.lblTitFECHA_BAJA_ACTIVO.Text = "Fecha de desecho"
        '
        'lblFECHA_BAJA_ACTIVO
        '
        Me.lblFECHA_BAJA_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_BAJA_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_BAJA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_BAJA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_BAJA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_BAJA_ACTIVO.Location = New System.Drawing.Point(344, 16)
        Me.lblFECHA_BAJA_ACTIVO.Name = "lblFECHA_BAJA_ACTIVO"
        Me.lblFECHA_BAJA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_BAJA_ACTIVO.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_BAJA_ACTIVO.TabIndex = 62
        '
        'lblFECHA_ADQUISICION
        '
        Me.lblFECHA_ADQUISICION.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_ADQUISICION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_ADQUISICION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_ADQUISICION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_ADQUISICION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_ADQUISICION.Location = New System.Drawing.Point(131, 16)
        Me.lblFECHA_ADQUISICION.Name = "lblFECHA_ADQUISICION"
        Me.lblFECHA_ADQUISICION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_ADQUISICION.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_ADQUISICION.TabIndex = 65
        '
        'lblTitFECHA_ADQUISICION
        '
        Me.lblTitFECHA_ADQUISICION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_ADQUISICION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_ADQUISICION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_ADQUISICION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_ADQUISICION.Location = New System.Drawing.Point(6, 17)
        Me.lblTitFECHA_ADQUISICION.Name = "lblTitFECHA_ADQUISICION"
        Me.lblTitFECHA_ADQUISICION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_ADQUISICION.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFECHA_ADQUISICION.TabIndex = 66
        Me.lblTitFECHA_ADQUISICION.Text = "Fecha adquisición"
        '
        'lblTitNO_PERIODO
        '
        Me.lblTitNO_PERIODO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_PERIODO.Location = New System.Drawing.Point(6, 41)
        Me.lblTitNO_PERIODO.Name = "lblTitNO_PERIODO"
        Me.lblTitNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_PERIODO.Size = New System.Drawing.Size(119, 14)
        Me.lblTitNO_PERIODO.TabIndex = 79
        Me.lblTitNO_PERIODO.Text = "Número período"
        '
        'lblTitANO_PERIODO
        '
        Me.lblTitANO_PERIODO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitANO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitANO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitANO_PERIODO.Location = New System.Drawing.Point(211, 41)
        Me.lblTitANO_PERIODO.Name = "lblTitANO_PERIODO"
        Me.lblTitANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitANO_PERIODO.Size = New System.Drawing.Size(127, 14)
        Me.lblTitANO_PERIODO.TabIndex = 78
        Me.lblTitANO_PERIODO.Text = "Año de período"
        '
        'grpOtros
        '
        Me.grpOtros.BackColor = System.Drawing.SystemColors.Control
        Me.grpOtros.Controls.Add(Me.lblNO_ORDEN)
        Me.grpOtros.Controls.Add(Me.lblTitNO_ORDEN)
        Me.grpOtros.Controls.Add(Me.lblFECHA_ULT_INVENTARIO)
        Me.grpOtros.Controls.Add(Me.lblTitFECHA_ULT_INVENTARIO)
        Me.grpOtros.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOtros.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpOtros.Location = New System.Drawing.Point(432, 95)
        Me.grpOtros.Name = "grpOtros"
        Me.grpOtros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpOtros.Size = New System.Drawing.Size(207, 93)
        Me.grpOtros.TabIndex = 70
        Me.grpOtros.TabStop = False
        Me.grpOtros.Text = " Otros "
        '
        'lblNO_ORDEN
        '
        Me.lblNO_ORDEN.BackColor = System.Drawing.SystemColors.Window
        Me.lblNO_ORDEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNO_ORDEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNO_ORDEN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNO_ORDEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNO_ORDEN.Location = New System.Drawing.Point(131, 64)
        Me.lblNO_ORDEN.Name = "lblNO_ORDEN"
        Me.lblNO_ORDEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNO_ORDEN.Size = New System.Drawing.Size(70, 20)
        Me.lblNO_ORDEN.TabIndex = 71
        Me.lblNO_ORDEN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitNO_ORDEN
        '
        Me.lblTitNO_ORDEN.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_ORDEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_ORDEN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_ORDEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_ORDEN.Location = New System.Drawing.Point(6, 62)
        Me.lblTitNO_ORDEN.Name = "lblTitNO_ORDEN"
        Me.lblTitNO_ORDEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_ORDEN.Size = New System.Drawing.Size(119, 28)
        Me.lblTitNO_ORDEN.TabIndex = 72
        Me.lblTitNO_ORDEN.Text = "Orden de compra"
        '
        'lblFECHA_ULT_INVENTARIO
        '
        Me.lblFECHA_ULT_INVENTARIO.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_ULT_INVENTARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_ULT_INVENTARIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_ULT_INVENTARIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_ULT_INVENTARIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_ULT_INVENTARIO.Location = New System.Drawing.Point(131, 16)
        Me.lblFECHA_ULT_INVENTARIO.Name = "lblFECHA_ULT_INVENTARIO"
        Me.lblFECHA_ULT_INVENTARIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_ULT_INVENTARIO.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_ULT_INVENTARIO.TabIndex = 73
        '
        'lblTitFECHA_ULT_INVENTARIO
        '
        Me.lblTitFECHA_ULT_INVENTARIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_ULT_INVENTARIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_ULT_INVENTARIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_ULT_INVENTARIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_ULT_INVENTARIO.Location = New System.Drawing.Point(6, 16)
        Me.lblTitFECHA_ULT_INVENTARIO.Name = "lblTitFECHA_ULT_INVENTARIO"
        Me.lblTitFECHA_ULT_INVENTARIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_ULT_INVENTARIO.Size = New System.Drawing.Size(119, 28)
        Me.lblTitFECHA_ULT_INVENTARIO.TabIndex = 74
        Me.lblTitFECHA_ULT_INVENTARIO.Text = "Fecha último inventario"
        '
        'grpUltimaActualizacion
        '
        Me.grpUltimaActualizacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpUltimaActualizacion.Controls.Add(Me.lblUSR_ACTUALIZACION)
        Me.grpUltimaActualizacion.Controls.Add(Me.lblFEC_ACTUALIZACION)
        Me.grpUltimaActualizacion.Controls.Add(Me.lblTitUSR_ACTUALIZACION)
        Me.grpUltimaActualizacion.Controls.Add(Me.lblTitFEC_ACTUALIZACION)
        Me.grpUltimaActualizacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimaActualizacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpUltimaActualizacion.Location = New System.Drawing.Point(6, 19)
        Me.grpUltimaActualizacion.Name = "grpUltimaActualizacion"
        Me.grpUltimaActualizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpUltimaActualizacion.Size = New System.Drawing.Size(207, 70)
        Me.grpUltimaActualizacion.TabIndex = 2
        Me.grpUltimaActualizacion.TabStop = False
        Me.grpUltimaActualizacion.Text = "Ultima actualización"
        '
        'lblUSR_ACTUALIZACION
        '
        Me.lblUSR_ACTUALIZACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblUSR_ACTUALIZACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUSR_ACTUALIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUSR_ACTUALIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSR_ACTUALIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUSR_ACTUALIZACION.Location = New System.Drawing.Point(131, 40)
        Me.lblUSR_ACTUALIZACION.Name = "lblUSR_ACTUALIZACION"
        Me.lblUSR_ACTUALIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUSR_ACTUALIZACION.Size = New System.Drawing.Size(70, 20)
        Me.lblUSR_ACTUALIZACION.TabIndex = 3
        '
        'lblFEC_ACTUALIZACION
        '
        Me.lblFEC_ACTUALIZACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblFEC_ACTUALIZACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFEC_ACTUALIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFEC_ACTUALIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFEC_ACTUALIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFEC_ACTUALIZACION.Location = New System.Drawing.Point(131, 16)
        Me.lblFEC_ACTUALIZACION.Name = "lblFEC_ACTUALIZACION"
        Me.lblFEC_ACTUALIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFEC_ACTUALIZACION.Size = New System.Drawing.Size(70, 20)
        Me.lblFEC_ACTUALIZACION.TabIndex = 4
        '
        'lblTitUSR_ACTUALIZACION
        '
        Me.lblTitUSR_ACTUALIZACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitUSR_ACTUALIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitUSR_ACTUALIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitUSR_ACTUALIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitUSR_ACTUALIZACION.Location = New System.Drawing.Point(6, 41)
        Me.lblTitUSR_ACTUALIZACION.Name = "lblTitUSR_ACTUALIZACION"
        Me.lblTitUSR_ACTUALIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitUSR_ACTUALIZACION.Size = New System.Drawing.Size(119, 14)
        Me.lblTitUSR_ACTUALIZACION.TabIndex = 5
        Me.lblTitUSR_ACTUALIZACION.Text = "Usuario"
        '
        'lblTitFEC_ACTUALIZACION
        '
        Me.lblTitFEC_ACTUALIZACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFEC_ACTUALIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFEC_ACTUALIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFEC_ACTUALIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFEC_ACTUALIZACION.Location = New System.Drawing.Point(6, 17)
        Me.lblTitFEC_ACTUALIZACION.Name = "lblTitFEC_ACTUALIZACION"
        Me.lblTitFEC_ACTUALIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFEC_ACTUALIZACION.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFEC_ACTUALIZACION.TabIndex = 6
        Me.lblTitFEC_ACTUALIZACION.Text = "Fecha"
        '
        'grpUltimoMovimiento
        '
        Me.grpUltimoMovimiento.BackColor = System.Drawing.SystemColors.Control
        Me.grpUltimoMovimiento.Controls.Add(Me.lblFECHA_ULT_MANTMTO)
        Me.grpUltimoMovimiento.Controls.Add(Me.lblCOSTO_ACUM_MNTMTO)
        Me.grpUltimoMovimiento.Controls.Add(Me.lblFRECUENCIA_MNTMTO)
        Me.grpUltimoMovimiento.Controls.Add(Me.lblTitFECHA_ULT_MANTMTO)
        Me.grpUltimoMovimiento.Controls.Add(Me.lblTitCOSTO_ACUM_MNTMTO)
        Me.grpUltimoMovimiento.Controls.Add(Me.lblTitFRECUENCIA_MNTMTO)
        Me.grpUltimoMovimiento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimoMovimiento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpUltimoMovimiento.Location = New System.Drawing.Point(219, 95)
        Me.grpUltimoMovimiento.Name = "grpUltimoMovimiento"
        Me.grpUltimoMovimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpUltimoMovimiento.Size = New System.Drawing.Size(207, 93)
        Me.grpUltimoMovimiento.TabIndex = 7
        Me.grpUltimoMovimiento.TabStop = False
        Me.grpUltimoMovimiento.Text = "Ultimo mantenimiento"
        '
        'lblFECHA_ULT_MANTMTO
        '
        Me.lblFECHA_ULT_MANTMTO.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_ULT_MANTMTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_ULT_MANTMTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_ULT_MANTMTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_ULT_MANTMTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_ULT_MANTMTO.Location = New System.Drawing.Point(131, 16)
        Me.lblFECHA_ULT_MANTMTO.Name = "lblFECHA_ULT_MANTMTO"
        Me.lblFECHA_ULT_MANTMTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_ULT_MANTMTO.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_ULT_MANTMTO.TabIndex = 8
        '
        'lblCOSTO_ACUM_MNTMTO
        '
        Me.lblCOSTO_ACUM_MNTMTO.BackColor = System.Drawing.SystemColors.Window
        Me.lblCOSTO_ACUM_MNTMTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCOSTO_ACUM_MNTMTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCOSTO_ACUM_MNTMTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOSTO_ACUM_MNTMTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCOSTO_ACUM_MNTMTO.Location = New System.Drawing.Point(131, 64)
        Me.lblCOSTO_ACUM_MNTMTO.Name = "lblCOSTO_ACUM_MNTMTO"
        Me.lblCOSTO_ACUM_MNTMTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCOSTO_ACUM_MNTMTO.Size = New System.Drawing.Size(70, 20)
        Me.lblCOSTO_ACUM_MNTMTO.TabIndex = 9
        Me.lblCOSTO_ACUM_MNTMTO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFRECUENCIA_MNTMTO
        '
        Me.lblFRECUENCIA_MNTMTO.BackColor = System.Drawing.SystemColors.Window
        Me.lblFRECUENCIA_MNTMTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFRECUENCIA_MNTMTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFRECUENCIA_MNTMTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFRECUENCIA_MNTMTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFRECUENCIA_MNTMTO.Location = New System.Drawing.Point(131, 40)
        Me.lblFRECUENCIA_MNTMTO.Name = "lblFRECUENCIA_MNTMTO"
        Me.lblFRECUENCIA_MNTMTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFRECUENCIA_MNTMTO.Size = New System.Drawing.Size(70, 20)
        Me.lblFRECUENCIA_MNTMTO.TabIndex = 10
        Me.lblFRECUENCIA_MNTMTO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitFECHA_ULT_MANTMTO
        '
        Me.lblTitFECHA_ULT_MANTMTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_ULT_MANTMTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_ULT_MANTMTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_ULT_MANTMTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_ULT_MANTMTO.Location = New System.Drawing.Point(6, 17)
        Me.lblTitFECHA_ULT_MANTMTO.Name = "lblTitFECHA_ULT_MANTMTO"
        Me.lblTitFECHA_ULT_MANTMTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_ULT_MANTMTO.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFECHA_ULT_MANTMTO.TabIndex = 11
        Me.lblTitFECHA_ULT_MANTMTO.Text = "Fecha"
        '
        'lblTitCOSTO_ACUM_MNTMTO
        '
        Me.lblTitCOSTO_ACUM_MNTMTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOSTO_ACUM_MNTMTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOSTO_ACUM_MNTMTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOSTO_ACUM_MNTMTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOSTO_ACUM_MNTMTO.Location = New System.Drawing.Point(6, 65)
        Me.lblTitCOSTO_ACUM_MNTMTO.Name = "lblTitCOSTO_ACUM_MNTMTO"
        Me.lblTitCOSTO_ACUM_MNTMTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOSTO_ACUM_MNTMTO.Size = New System.Drawing.Size(119, 14)
        Me.lblTitCOSTO_ACUM_MNTMTO.TabIndex = 12
        Me.lblTitCOSTO_ACUM_MNTMTO.Text = "Costo acumulado"
        '
        'lblTitFRECUENCIA_MNTMTO
        '
        Me.lblTitFRECUENCIA_MNTMTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFRECUENCIA_MNTMTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFRECUENCIA_MNTMTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFRECUENCIA_MNTMTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFRECUENCIA_MNTMTO.Location = New System.Drawing.Point(6, 41)
        Me.lblTitFRECUENCIA_MNTMTO.Name = "lblTitFRECUENCIA_MNTMTO"
        Me.lblTitFRECUENCIA_MNTMTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFRECUENCIA_MNTMTO.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFRECUENCIA_MNTMTO.TabIndex = 13
        Me.lblTitFRECUENCIA_MNTMTO.Text = "Frecuencia (días)"
        '
        'grpAuditoria
        '
        Me.grpAuditoria.BackColor = System.Drawing.SystemColors.Control
        Me.grpAuditoria.Controls.Add(Me.lblTitFECHA_OPERACION)
        Me.grpAuditoria.Controls.Add(Me.lblTitUSUARIO_OPERACION)
        Me.grpAuditoria.Controls.Add(Me.lblFECHA_OPERACION)
        Me.grpAuditoria.Controls.Add(Me.lblUSUARIO_OPERACION)
        Me.grpAuditoria.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAuditoria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpAuditoria.Location = New System.Drawing.Point(432, 19)
        Me.grpAuditoria.Name = "grpAuditoria"
        Me.grpAuditoria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpAuditoria.Size = New System.Drawing.Size(207, 70)
        Me.grpAuditoria.TabIndex = 14
        Me.grpAuditoria.TabStop = False
        Me.grpAuditoria.Text = "Auditoria"
        '
        'lblTitFECHA_OPERACION
        '
        Me.lblTitFECHA_OPERACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_OPERACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_OPERACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_OPERACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_OPERACION.Location = New System.Drawing.Point(6, 41)
        Me.lblTitFECHA_OPERACION.Name = "lblTitFECHA_OPERACION"
        Me.lblTitFECHA_OPERACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_OPERACION.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFECHA_OPERACION.TabIndex = 15
        Me.lblTitFECHA_OPERACION.Text = "Fecha"
        '
        'lblTitUSUARIO_OPERACION
        '
        Me.lblTitUSUARIO_OPERACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitUSUARIO_OPERACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitUSUARIO_OPERACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitUSUARIO_OPERACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitUSUARIO_OPERACION.Location = New System.Drawing.Point(6, 17)
        Me.lblTitUSUARIO_OPERACION.Name = "lblTitUSUARIO_OPERACION"
        Me.lblTitUSUARIO_OPERACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitUSUARIO_OPERACION.Size = New System.Drawing.Size(119, 14)
        Me.lblTitUSUARIO_OPERACION.TabIndex = 16
        Me.lblTitUSUARIO_OPERACION.Text = "Usuario"
        '
        'lblFECHA_OPERACION
        '
        Me.lblFECHA_OPERACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_OPERACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_OPERACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_OPERACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_OPERACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_OPERACION.Location = New System.Drawing.Point(131, 40)
        Me.lblFECHA_OPERACION.Name = "lblFECHA_OPERACION"
        Me.lblFECHA_OPERACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_OPERACION.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_OPERACION.TabIndex = 17
        '
        'lblUSUARIO_OPERACION
        '
        Me.lblUSUARIO_OPERACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblUSUARIO_OPERACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUSUARIO_OPERACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUSUARIO_OPERACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIO_OPERACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUSUARIO_OPERACION.Location = New System.Drawing.Point(131, 16)
        Me.lblUSUARIO_OPERACION.Name = "lblUSUARIO_OPERACION"
        Me.lblUSUARIO_OPERACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUSUARIO_OPERACION.Size = New System.Drawing.Size(70, 20)
        Me.lblUSUARIO_OPERACION.TabIndex = 18
        '
        'grpUltimaDepreciacion
        '
        Me.grpUltimaDepreciacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpUltimaDepreciacion.Controls.Add(Me.lblTitFECHA_ULTIMA_DEPREC)
        Me.grpUltimaDepreciacion.Controls.Add(Me.lblTitMONTO_ULTIMA_DEPREC)
        Me.grpUltimaDepreciacion.Controls.Add(Me.lblFECHA_ULTIMA_DEPREC)
        Me.grpUltimaDepreciacion.Controls.Add(Me.lblMONTO_ULTIMA_DEPREC)
        Me.grpUltimaDepreciacion.Controls.Add(Me.lblTitTASA_CAMBIO_ULT_REV)
        Me.grpUltimaDepreciacion.Controls.Add(Me.lblTASA_CAMBIO_ULT_REV)
        Me.grpUltimaDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimaDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpUltimaDepreciacion.Location = New System.Drawing.Point(6, 95)
        Me.grpUltimaDepreciacion.Name = "grpUltimaDepreciacion"
        Me.grpUltimaDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpUltimaDepreciacion.Size = New System.Drawing.Size(207, 93)
        Me.grpUltimaDepreciacion.TabIndex = 19
        Me.grpUltimaDepreciacion.TabStop = False
        Me.grpUltimaDepreciacion.Text = "Ultima depreciación"
        '
        'lblTitFECHA_ULTIMA_DEPREC
        '
        Me.lblTitFECHA_ULTIMA_DEPREC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_ULTIMA_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_ULTIMA_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_ULTIMA_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_ULTIMA_DEPREC.Location = New System.Drawing.Point(6, 19)
        Me.lblTitFECHA_ULTIMA_DEPREC.Name = "lblTitFECHA_ULTIMA_DEPREC"
        Me.lblTitFECHA_ULTIMA_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_ULTIMA_DEPREC.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFECHA_ULTIMA_DEPREC.TabIndex = 20
        Me.lblTitFECHA_ULTIMA_DEPREC.Text = "Fecha"
        '
        'lblTitMONTO_ULTIMA_DEPREC
        '
        Me.lblTitMONTO_ULTIMA_DEPREC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_ULTIMA_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_ULTIMA_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_ULTIMA_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_ULTIMA_DEPREC.Location = New System.Drawing.Point(6, 45)
        Me.lblTitMONTO_ULTIMA_DEPREC.Name = "lblTitMONTO_ULTIMA_DEPREC"
        Me.lblTitMONTO_ULTIMA_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_ULTIMA_DEPREC.Size = New System.Drawing.Size(119, 14)
        Me.lblTitMONTO_ULTIMA_DEPREC.TabIndex = 21
        Me.lblTitMONTO_ULTIMA_DEPREC.Text = "Monto"
        '
        'lblFECHA_ULTIMA_DEPREC
        '
        Me.lblFECHA_ULTIMA_DEPREC.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_ULTIMA_DEPREC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_ULTIMA_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_ULTIMA_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_ULTIMA_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_ULTIMA_DEPREC.Location = New System.Drawing.Point(131, 16)
        Me.lblFECHA_ULTIMA_DEPREC.Name = "lblFECHA_ULTIMA_DEPREC"
        Me.lblFECHA_ULTIMA_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_ULTIMA_DEPREC.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_ULTIMA_DEPREC.TabIndex = 22
        '
        'lblMONTO_ULTIMA_DEPREC
        '
        Me.lblMONTO_ULTIMA_DEPREC.BackColor = System.Drawing.SystemColors.Window
        Me.lblMONTO_ULTIMA_DEPREC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMONTO_ULTIMA_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMONTO_ULTIMA_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTO_ULTIMA_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMONTO_ULTIMA_DEPREC.Location = New System.Drawing.Point(131, 40)
        Me.lblMONTO_ULTIMA_DEPREC.Name = "lblMONTO_ULTIMA_DEPREC"
        Me.lblMONTO_ULTIMA_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMONTO_ULTIMA_DEPREC.Size = New System.Drawing.Size(70, 20)
        Me.lblMONTO_ULTIMA_DEPREC.TabIndex = 23
        Me.lblMONTO_ULTIMA_DEPREC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitTASA_CAMBIO_ULT_REV
        '
        Me.lblTitTASA_CAMBIO_ULT_REV.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_CAMBIO_ULT_REV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_CAMBIO_ULT_REV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_CAMBIO_ULT_REV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_CAMBIO_ULT_REV.Location = New System.Drawing.Point(6, 65)
        Me.lblTitTASA_CAMBIO_ULT_REV.Name = "lblTitTASA_CAMBIO_ULT_REV"
        Me.lblTitTASA_CAMBIO_ULT_REV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_CAMBIO_ULT_REV.Size = New System.Drawing.Size(119, 14)
        Me.lblTitTASA_CAMBIO_ULT_REV.TabIndex = 24
        Me.lblTitTASA_CAMBIO_ULT_REV.Text = "Tasa de cambio"
        '
        'lblTASA_CAMBIO_ULT_REV
        '
        Me.lblTASA_CAMBIO_ULT_REV.BackColor = System.Drawing.SystemColors.Window
        Me.lblTASA_CAMBIO_ULT_REV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTASA_CAMBIO_ULT_REV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTASA_CAMBIO_ULT_REV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTASA_CAMBIO_ULT_REV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTASA_CAMBIO_ULT_REV.Location = New System.Drawing.Point(131, 64)
        Me.lblTASA_CAMBIO_ULT_REV.Name = "lblTASA_CAMBIO_ULT_REV"
        Me.lblTASA_CAMBIO_ULT_REV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTASA_CAMBIO_ULT_REV.Size = New System.Drawing.Size(70, 20)
        Me.lblTASA_CAMBIO_ULT_REV.TabIndex = 25
        Me.lblTASA_CAMBIO_ULT_REV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpUltimaReevaluacion
        '
        Me.grpUltimaReevaluacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpUltimaReevaluacion.Controls.Add(Me.lblMONTO_ULTIMA_REVAL)
        Me.grpUltimaReevaluacion.Controls.Add(Me.lblFECHA_ULTIMA_REVAL)
        Me.grpUltimaReevaluacion.Controls.Add(Me.lblTitMONTO_ULTIMA_REVAL)
        Me.grpUltimaReevaluacion.Controls.Add(Me.lblTitFECHA_ULTIMA_REVAL)
        Me.grpUltimaReevaluacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimaReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpUltimaReevaluacion.Location = New System.Drawing.Point(219, 19)
        Me.grpUltimaReevaluacion.Name = "grpUltimaReevaluacion"
        Me.grpUltimaReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpUltimaReevaluacion.Size = New System.Drawing.Size(207, 70)
        Me.grpUltimaReevaluacion.TabIndex = 26
        Me.grpUltimaReevaluacion.TabStop = False
        Me.grpUltimaReevaluacion.Text = "Ultima reevaluación"
        '
        'lblMONTO_ULTIMA_REVAL
        '
        Me.lblMONTO_ULTIMA_REVAL.BackColor = System.Drawing.SystemColors.Window
        Me.lblMONTO_ULTIMA_REVAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMONTO_ULTIMA_REVAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMONTO_ULTIMA_REVAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTO_ULTIMA_REVAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMONTO_ULTIMA_REVAL.Location = New System.Drawing.Point(131, 40)
        Me.lblMONTO_ULTIMA_REVAL.Name = "lblMONTO_ULTIMA_REVAL"
        Me.lblMONTO_ULTIMA_REVAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMONTO_ULTIMA_REVAL.Size = New System.Drawing.Size(70, 20)
        Me.lblMONTO_ULTIMA_REVAL.TabIndex = 27
        Me.lblMONTO_ULTIMA_REVAL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFECHA_ULTIMA_REVAL
        '
        Me.lblFECHA_ULTIMA_REVAL.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_ULTIMA_REVAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_ULTIMA_REVAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_ULTIMA_REVAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_ULTIMA_REVAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_ULTIMA_REVAL.Location = New System.Drawing.Point(131, 16)
        Me.lblFECHA_ULTIMA_REVAL.Name = "lblFECHA_ULTIMA_REVAL"
        Me.lblFECHA_ULTIMA_REVAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_ULTIMA_REVAL.Size = New System.Drawing.Size(70, 20)
        Me.lblFECHA_ULTIMA_REVAL.TabIndex = 28
        '
        'lblTitMONTO_ULTIMA_REVAL
        '
        Me.lblTitMONTO_ULTIMA_REVAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_ULTIMA_REVAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_ULTIMA_REVAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_ULTIMA_REVAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_ULTIMA_REVAL.Location = New System.Drawing.Point(6, 41)
        Me.lblTitMONTO_ULTIMA_REVAL.Name = "lblTitMONTO_ULTIMA_REVAL"
        Me.lblTitMONTO_ULTIMA_REVAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_ULTIMA_REVAL.Size = New System.Drawing.Size(119, 14)
        Me.lblTitMONTO_ULTIMA_REVAL.TabIndex = 29
        Me.lblTitMONTO_ULTIMA_REVAL.Text = "Monto"
        '
        'lblTitFECHA_ULTIMA_REVAL
        '
        Me.lblTitFECHA_ULTIMA_REVAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_ULTIMA_REVAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_ULTIMA_REVAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_ULTIMA_REVAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_ULTIMA_REVAL.Location = New System.Drawing.Point(6, 17)
        Me.lblTitFECHA_ULTIMA_REVAL.Name = "lblTitFECHA_ULTIMA_REVAL"
        Me.lblTitFECHA_ULTIMA_REVAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_ULTIMA_REVAL.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFECHA_ULTIMA_REVAL.TabIndex = 30
        Me.lblTitFECHA_ULTIMA_REVAL.Text = "Fecha"
        '
        'ACTMAFC0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(775, 644)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdInfoGeneral)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.mhTab1)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.FrameUno)
        Me.Controls.Add(Me.FrameDos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMAFC0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de activos fijos - ACTMAFC0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.grpCamposDefinidos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpGeneral.ResumeLayout(False)
        Me.grpGeneral.PerformLayout()
        Me.mhTab1.ResumeLayout(False)
        Me.FrameUno.ResumeLayout(False)
        Me.grpDepreciacion.ResumeLayout(False)
        Me.grpDepreciacion.PerformLayout()
        Me.grpValores.ResumeLayout(False)
        Me.grpValores.PerformLayout()
        Me.FrameDos.ResumeLayout(False)
        Me.grpFechas.ResumeLayout(False)
        Me.grpFechas.PerformLayout()
        Me.grpOtros.ResumeLayout(False)
        Me.grpUltimaActualizacion.ResumeLayout(False)
        Me.grpUltimoMovimiento.ResumeLayout(False)
        Me.grpAuditoria.ResumeLayout(False)
        Me.grpUltimaDepreciacion.ResumeLayout(False)
        Me.grpUltimaReevaluacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents grpGeneral As System.Windows.Forms.GroupBox
    Public WithEvents POSEE_CTRL_TF As System.Windows.Forms.CheckBox
    Public WithEvents cboEstadoServicio As System.Windows.Forms.ComboBox
    Public WithEvents cboEstado As System.Windows.Forms.ComboBox
    Public WithEvents txtCATEGORIA_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtRESPONSABLE_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents CODIGO_UBICACION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_MARCA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtREFERENCIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblNombreCategoria As System.Windows.Forms.Label
    Public WithEvents lblNombreResponsable As System.Windows.Forms.Label
    Public WithEvents lblNombreUbicacion As System.Windows.Forms.Label
    Public WithEvents lblNombreMarca As System.Windows.Forms.Label
    Public WithEvents lblNombreDivision As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoActivo As System.Windows.Forms.Label
    Public WithEvents lblNombreProveedor As System.Windows.Forms.Label
    Public WithEvents lblTitESTADO_SERVICIO As System.Windows.Forms.Label
    Public WithEvents lblTitESTATUS As System.Windows.Forms.Label
    Public WithEvents lblDESCRIP_CORTA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblCATEGORIA_ID As System.Windows.Forms.Label
    Public WithEvents lblRESPONSABLE_ID As System.Windows.Forms.Label
    Public WithEvents lblUBICACION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_MARCA As System.Windows.Forms.Label
    Public WithEvents lblREFERENCIA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Friend WithEvents mhTab1 As System.Windows.Forms.TabControl
    Public WithEvents grpCamposDefinidos As System.Windows.Forms.GroupBox
    Public WithEvents FrameUno As System.Windows.Forms.GroupBox
    Public WithEvents grpDepreciacion As System.Windows.Forms.GroupBox
    Public WithEvents cboTipoDepreciacion As System.Windows.Forms.ComboBox
    Public WithEvents cboDepreciable As System.Windows.Forms.ComboBox
    Public WithEvents lblSALDO_MESES_DEPRE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTOTALMENTE_DEP As System.Windows.Forms.Label
    Public WithEvents lblTIEMPO_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents lblPORCENTAJE_ANUAL_DEP As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents lblTitTIEMPO_DEPRECIACION As System.Windows.Forms.Label
    Public WithEvents lblTitPORCENTAJE_ANUAL_DEP As System.Windows.Forms.Label
    Public WithEvents lblTitDEPRECIABLE As System.Windows.Forms.Label
    Public WithEvents lblTitSALDO_MESES_DEPRE As System.Windows.Forms.Label
    Public WithEvents grpValores As System.Windows.Forms.GroupBox
    Public WithEvents txtVALOR_MONEDA_LOCAL As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblVALOR_MONEDA_LOCAL As System.Windows.Forms.Label
    Public WithEvents lblVALOR_NO_DEDUCIBLE As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_NO_DEDUCIBLE As System.Windows.Forms.Label
    Public WithEvents lblTASA_DEDUCIBLE_ISR As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_DEDUCIBLE_ISR As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_ORIG_ACT_USADO As System.Windows.Forms.Label
    Public WithEvents lblVALOR_ORIG_ACT_USADO As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblMONTO_REVALUACIONES As System.Windows.Forms.Label
    Public WithEvents lblVALOR_ORIGINAL_ACTIV As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_CAMBIO_COMPRA As System.Windows.Forms.Label
    Public WithEvents lblTASA_CAMBIO_COMPRA As System.Windows.Forms.Label
    Public WithEvents lblVALOR_TOT_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_TOT_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_DEP_ACUM_ACT As System.Windows.Forms.Label
    Public WithEvents lblVALOR_DEP_ACUM_ACT As System.Windows.Forms.Label
    Public WithEvents lblVALOR_ACTUAL_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblVALOR_RESCATE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_ORIGINAL_ACTIV As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_ACTUAL_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_RESCATE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_REVALUACIONES As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_DEP_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblVALOR_DEP_PERIODO As System.Windows.Forms.Label
    Public WithEvents cmdAnterior As System.Windows.Forms.Button
    Public WithEvents cmdInfoGeneral As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdSiguiente As System.Windows.Forms.Button
    Public WithEvents FrameDos As System.Windows.Forms.GroupBox
    Public WithEvents grpFechas As System.Windows.Forms.GroupBox
    Public WithEvents lblNO_PERIODO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblANO_PERIODO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblFECHA_INICIO_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_INICIO_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_BAJA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblFECHA_BAJA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblFECHA_ADQUISICION As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_ADQUISICION As System.Windows.Forms.Label
    Public WithEvents lblTitNO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblTitANO_PERIODO As System.Windows.Forms.Label
    Public WithEvents grpOtros As System.Windows.Forms.GroupBox
    Public WithEvents lblNO_ORDEN As System.Windows.Forms.Label
    Public WithEvents lblTitNO_ORDEN As System.Windows.Forms.Label
    Public WithEvents lblFECHA_ULT_INVENTARIO As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_ULT_INVENTARIO As System.Windows.Forms.Label
    Public WithEvents grpUltimaActualizacion As System.Windows.Forms.GroupBox
    Public WithEvents lblUSR_ACTUALIZACION As System.Windows.Forms.Label
    Public WithEvents lblFEC_ACTUALIZACION As System.Windows.Forms.Label
    Public WithEvents lblTitUSR_ACTUALIZACION As System.Windows.Forms.Label
    Public WithEvents lblTitFEC_ACTUALIZACION As System.Windows.Forms.Label
    Public WithEvents grpUltimoMovimiento As System.Windows.Forms.GroupBox
    Public WithEvents lblFECHA_ULT_MANTMTO As System.Windows.Forms.Label
    Public WithEvents lblCOSTO_ACUM_MNTMTO As System.Windows.Forms.Label
    Public WithEvents lblFRECUENCIA_MNTMTO As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_ULT_MANTMTO As System.Windows.Forms.Label
    Public WithEvents lblTitCOSTO_ACUM_MNTMTO As System.Windows.Forms.Label
    Public WithEvents lblTitFRECUENCIA_MNTMTO As System.Windows.Forms.Label
    Public WithEvents grpAuditoria As System.Windows.Forms.GroupBox
    Public WithEvents lblTitFECHA_OPERACION As System.Windows.Forms.Label
    Public WithEvents lblTitUSUARIO_OPERACION As System.Windows.Forms.Label
    Public WithEvents lblFECHA_OPERACION As System.Windows.Forms.Label
    Public WithEvents lblUSUARIO_OPERACION As System.Windows.Forms.Label
    Public WithEvents grpUltimaDepreciacion As System.Windows.Forms.GroupBox
    Public WithEvents lblTitFECHA_ULTIMA_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_ULTIMA_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblFECHA_ULTIMA_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblMONTO_ULTIMA_DEPREC As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_CAMBIO_ULT_REV As System.Windows.Forms.Label
    Public WithEvents lblTASA_CAMBIO_ULT_REV As System.Windows.Forms.Label
    Public WithEvents grpUltimaReevaluacion As System.Windows.Forms.GroupBox
    Public WithEvents lblMONTO_ULTIMA_REVAL As System.Windows.Forms.Label
    Public WithEvents lblFECHA_ULTIMA_REVAL As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_ULTIMA_REVAL As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_ULTIMA_REVAL As System.Windows.Forms.Label
    Friend WithEvents panCampos As System.Windows.Forms.Panel
End Class
