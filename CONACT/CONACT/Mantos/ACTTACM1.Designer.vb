<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTTACM1
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
        Me.mhTab1 = New System.Windows.Forms.TabControl()
        Me.tbpGenerales = New System.Windows.Forms.TabPage()
        Me.cboClaseContabilizacion = New System.Windows.Forms.ComboBox()
        Me.cboCalculaPrimeraDepreciacion = New System.Windows.Forms.ComboBox()
        Me.cboDiasCalculoDepreciacion = New System.Windows.Forms.ComboBox()
        Me.cboFormaDepreciacion = New System.Windows.Forms.ComboBox()
        Me.cboTipoDepreciacion = New System.Windows.Forms.ComboBox()
        Me.txtCodigoTipoActivo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTipoActivoDescripcion = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDiaLimite = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtMontoMinimo = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTiempoDepreciacion = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTipoCatalogo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCalculaPrimeraDepreciacion = New System.Windows.Forms.Label()
        Me.lblNombreTipoCatalogo = New System.Windows.Forms.Label()
        Me.lblClaseContabilizacion = New System.Windows.Forms.Label()
        Me.lblCodigoTipoActivo = New System.Windows.Forms.Label()
        Me.lblTipoActivoDescripcion = New System.Windows.Forms.Label()
        Me.lblTipoDepreciacion = New System.Windows.Forms.Label()
        Me.lblDiaLimite = New System.Windows.Forms.Label()
        Me.lblMontoMinimo = New System.Windows.Forms.Label()
        Me.lblTiempoDepreciacion = New System.Windows.Forms.Label()
        Me.lblTipoCatalogo = New System.Windows.Forms.Label()
        Me.lblFormaDepreciacion = New System.Windows.Forms.Label()
        Me.lblDiasCalculoDepreciacion = New System.Windows.Forms.Label()
        Me.tbpBalance = New System.Windows.Forms.TabPage()
        Me.grpReevaluacion = New System.Windows.Forms.GroupBox()
        Me.txtCuentaReevaluacion = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCentroReevaluacion = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaReevaluacion = New System.Windows.Forms.Label()
        Me.lblCentroReevaluacion = New System.Windows.Forms.Label()
        Me.lblNombreCentroReevaluacion = New System.Windows.Forms.Label()
        Me.lblNombreCuentaReevaluacion = New System.Windows.Forms.Label()
        Me.grpGastos = New System.Windows.Forms.GroupBox()
        Me.txtCuentaGastos = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCentroGastos = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaGastos = New System.Windows.Forms.Label()
        Me.lblCentroGastos = New System.Windows.Forms.Label()
        Me.lblNombreCentroGastos = New System.Windows.Forms.Label()
        Me.lblNombreCuentaGastos = New System.Windows.Forms.Label()
        Me.grpBalance = New System.Windows.Forms.GroupBox()
        Me.txtCuentaDepreciacion = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCuentaActivo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCentroBalance = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaDepreciacion = New System.Windows.Forms.Label()
        Me.lblCuentaActivo = New System.Windows.Forms.Label()
        Me.lblCentroBalance = New System.Windows.Forms.Label()
        Me.lblNombreCentroBalance = New System.Windows.Forms.Label()
        Me.lblNombreCuentaActivo = New System.Windows.Forms.Label()
        Me.lblNombreCuentaDepreciacion = New System.Windows.Forms.Label()
        Me.tbpIngresoEgreso = New System.Windows.Forms.TabPage()
        Me.grpDesecho = New System.Windows.Forms.GroupBox()
        Me.txtCuentaDesecho = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCentroDesecho = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaDesecho = New System.Windows.Forms.Label()
        Me.lblCentroDesecho = New System.Windows.Forms.Label()
        Me.lblNombreCentroDesecho = New System.Windows.Forms.Label()
        Me.lblNombreCuentaDesecho = New System.Windows.Forms.Label()
        Me.grpIngresosEgresos = New System.Windows.Forms.GroupBox()
        Me.txtCuentaPerdida = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCuentaGanancia = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCentroIngresosEgresos = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaPerdida = New System.Windows.Forms.Label()
        Me.lblCuentaGanancia = New System.Windows.Forms.Label()
        Me.lblCentroIngresosEgresos = New System.Windows.Forms.Label()
        Me.lblNombreCentroIngresosEgresos = New System.Windows.Forms.Label()
        Me.lblNombreCuentaGanancia = New System.Windows.Forms.Label()
        Me.lblNombreCuentaPerdida = New System.Windows.Forms.Label()
        Me.grpCompras = New System.Windows.Forms.GroupBox()
        Me.txtCuentaCompras = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCentroCompras = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaCompras = New System.Windows.Forms.Label()
        Me.lblCentroCompras = New System.Windows.Forms.Label()
        Me.lblNombreCentroCompras = New System.Windows.Forms.Label()
        Me.lblNombreCuentaCompras = New System.Windows.Forms.Label()
        Me.tbpDonacion = New System.Windows.Forms.TabPage()
        Me.grpDonacion = New System.Windows.Forms.GroupBox()
        Me.txtCuentaDonacion = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCentroDonacion = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblNombreCuentaDonacion = New System.Windows.Forms.Label()
        Me.lblNombreCentroDonacion = New System.Windows.Forms.Label()
        Me.lblCentroDonacion = New System.Windows.Forms.Label()
        Me.lblCuentaDonacion = New System.Windows.Forms.Label()
        Me.grpVentas = New System.Windows.Forms.GroupBox()
        Me.txtCentroVentas = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCuentaVentas = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaVentas = New System.Windows.Forms.Label()
        Me.lblCentroVentas = New System.Windows.Forms.Label()
        Me.lblNombreCentroVentas = New System.Windows.Forms.Label()
        Me.lblNombreCuentaVentas = New System.Windows.Forms.Label()
        Me.grpGastosNoDeducible = New System.Windows.Forms.GroupBox()
        Me.txtCentroGastoNoDeducible = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCuentaGastoNoDeducible = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblCuentaGastosNoDeducible = New System.Windows.Forms.Label()
        Me.lblCentroGastosNoDeducible = New System.Windows.Forms.Label()
        Me.lblNombreCentroGastoNoDeducible = New System.Windows.Forms.Label()
        Me.lblNombreCuentaGastoNoDeducible = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mhTab1.SuspendLayout()
        Me.tbpGenerales.SuspendLayout()
        Me.tbpBalance.SuspendLayout()
        Me.grpReevaluacion.SuspendLayout()
        Me.grpGastos.SuspendLayout()
        Me.grpBalance.SuspendLayout()
        Me.tbpIngresoEgreso.SuspendLayout()
        Me.grpDesecho.SuspendLayout()
        Me.grpIngresosEgresos.SuspendLayout()
        Me.grpCompras.SuspendLayout()
        Me.tbpDonacion.SuspendLayout()
        Me.grpDonacion.SuspendLayout()
        Me.grpVentas.SuspendLayout()
        Me.grpGastosNoDeducible.SuspendLayout()
        Me.SuspendLayout()
        '
        'mhTab1
        '
        Me.mhTab1.Controls.Add(Me.tbpGenerales)
        Me.mhTab1.Controls.Add(Me.tbpBalance)
        Me.mhTab1.Controls.Add(Me.tbpIngresoEgreso)
        Me.mhTab1.Controls.Add(Me.tbpDonacion)
        Me.mhTab1.Location = New System.Drawing.Point(12, 12)
        Me.mhTab1.Name = "mhTab1"
        Me.mhTab1.SelectedIndex = 0
        Me.mhTab1.Size = New System.Drawing.Size(667, 310)
        Me.mhTab1.TabIndex = 0
        '
        'tbpGenerales
        '
        Me.tbpGenerales.BackColor = System.Drawing.SystemColors.Control
        Me.tbpGenerales.Controls.Add(Me.cboClaseContabilizacion)
        Me.tbpGenerales.Controls.Add(Me.cboCalculaPrimeraDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.cboDiasCalculoDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.cboFormaDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.cboTipoDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.txtCodigoTipoActivo)
        Me.tbpGenerales.Controls.Add(Me.txtTipoActivoDescripcion)
        Me.tbpGenerales.Controls.Add(Me.txtDiaLimite)
        Me.tbpGenerales.Controls.Add(Me.txtMontoMinimo)
        Me.tbpGenerales.Controls.Add(Me.txtTiempoDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.txtTipoCatalogo)
        Me.tbpGenerales.Controls.Add(Me.lblCalculaPrimeraDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.lblNombreTipoCatalogo)
        Me.tbpGenerales.Controls.Add(Me.lblClaseContabilizacion)
        Me.tbpGenerales.Controls.Add(Me.lblCodigoTipoActivo)
        Me.tbpGenerales.Controls.Add(Me.lblTipoActivoDescripcion)
        Me.tbpGenerales.Controls.Add(Me.lblTipoDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.lblDiaLimite)
        Me.tbpGenerales.Controls.Add(Me.lblMontoMinimo)
        Me.tbpGenerales.Controls.Add(Me.lblTiempoDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.lblTipoCatalogo)
        Me.tbpGenerales.Controls.Add(Me.lblFormaDepreciacion)
        Me.tbpGenerales.Controls.Add(Me.lblDiasCalculoDepreciacion)
        Me.tbpGenerales.Location = New System.Drawing.Point(4, 22)
        Me.tbpGenerales.Name = "tbpGenerales"
        Me.tbpGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGenerales.Size = New System.Drawing.Size(659, 284)
        Me.tbpGenerales.TabIndex = 0
        Me.tbpGenerales.Text = "Generales ( F1 )"
        '
        'cboClaseContabilizacion
        '
        Me.cboClaseContabilizacion.BackColor = System.Drawing.SystemColors.Window
        Me.cboClaseContabilizacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboClaseContabilizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClaseContabilizacion.Enabled = False
        Me.cboClaseContabilizacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClaseContabilizacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboClaseContabilizacion.Location = New System.Drawing.Point(217, 220)
        Me.cboClaseContabilizacion.Name = "cboClaseContabilizacion"
        Me.cboClaseContabilizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboClaseContabilizacion.Size = New System.Drawing.Size(275, 22)
        Me.cboClaseContabilizacion.TabIndex = 9
        '
        'cboCalculaPrimeraDepreciacion
        '
        Me.cboCalculaPrimeraDepreciacion.BackColor = System.Drawing.SystemColors.Window
        Me.cboCalculaPrimeraDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCalculaPrimeraDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCalculaPrimeraDepreciacion.Enabled = False
        Me.cboCalculaPrimeraDepreciacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCalculaPrimeraDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCalculaPrimeraDepreciacion.Location = New System.Drawing.Point(217, 114)
        Me.cboCalculaPrimeraDepreciacion.Name = "cboCalculaPrimeraDepreciacion"
        Me.cboCalculaPrimeraDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCalculaPrimeraDepreciacion.Size = New System.Drawing.Size(275, 22)
        Me.cboCalculaPrimeraDepreciacion.TabIndex = 5
        '
        'cboDiasCalculoDepreciacion
        '
        Me.cboDiasCalculoDepreciacion.BackColor = System.Drawing.SystemColors.Window
        Me.cboDiasCalculoDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDiasCalculoDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiasCalculoDepreciacion.Enabled = False
        Me.cboDiasCalculoDepreciacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiasCalculoDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDiasCalculoDepreciacion.Location = New System.Drawing.Point(540, 86)
        Me.cboDiasCalculoDepreciacion.Name = "cboDiasCalculoDepreciacion"
        Me.cboDiasCalculoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDiasCalculoDepreciacion.Size = New System.Drawing.Size(113, 22)
        Me.cboDiasCalculoDepreciacion.TabIndex = 4
        '
        'cboFormaDepreciacion
        '
        Me.cboFormaDepreciacion.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormaDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFormaDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaDepreciacion.Enabled = False
        Me.cboFormaDepreciacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFormaDepreciacion.Location = New System.Drawing.Point(217, 86)
        Me.cboFormaDepreciacion.Name = "cboFormaDepreciacion"
        Me.cboFormaDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFormaDepreciacion.Size = New System.Drawing.Size(131, 22)
        Me.cboFormaDepreciacion.TabIndex = 3
        '
        'cboTipoDepreciacion
        '
        Me.cboTipoDepreciacion.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDepreciacion.Enabled = False
        Me.cboTipoDepreciacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoDepreciacion.Location = New System.Drawing.Point(217, 58)
        Me.cboTipoDepreciacion.Name = "cboTipoDepreciacion"
        Me.cboTipoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoDepreciacion.Size = New System.Drawing.Size(275, 22)
        Me.cboTipoDepreciacion.TabIndex = 2
        '
        'txtCodigoTipoActivo
        '
        Me.txtCodigoTipoActivo.AcceptsReturn = True
        Me.txtCodigoTipoActivo.BackColor = System.Drawing.Color.White
        Me.txtCodigoTipoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoTipoActivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoTipoActivo.Enabled = False
        Me.txtCodigoTipoActivo.EsRequerido = False
        Me.txtCodigoTipoActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoTipoActivo.LabelConsulta = Nothing
        Me.txtCodigoTipoActivo.Location = New System.Drawing.Point(217, 6)
        Me.txtCodigoTipoActivo.MaxLength = 7
        Me.txtCodigoTipoActivo.Name = "txtCodigoTipoActivo"
        Me.txtCodigoTipoActivo.NombreDeConsulta = Nothing
        Me.txtCodigoTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoTipoActivo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigoTipoActivo.TabIndex = 0
        '
        'txtTipoActivoDescripcion
        '
        Me.txtTipoActivoDescripcion.AcceptsReturn = True
        Me.txtTipoActivoDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoActivoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoActivoDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoActivoDescripcion.Enabled = False
        Me.txtTipoActivoDescripcion.EsRequerido = False
        Me.txtTipoActivoDescripcion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoActivoDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoActivoDescripcion.LabelConsulta = Nothing
        Me.txtTipoActivoDescripcion.Location = New System.Drawing.Point(217, 32)
        Me.txtTipoActivoDescripcion.MaxLength = 40
        Me.txtTipoActivoDescripcion.Name = "txtTipoActivoDescripcion"
        Me.txtTipoActivoDescripcion.NombreDeConsulta = Nothing
        Me.txtTipoActivoDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoActivoDescripcion.Size = New System.Drawing.Size(436, 20)
        Me.txtTipoActivoDescripcion.TabIndex = 1
        '
        'txtDiaLimite
        '
        Me.txtDiaLimite.AcceptsReturn = True
        Me.txtDiaLimite.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiaLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaLimite.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiaLimite.Enabled = False
        Me.txtDiaLimite.EsRequerido = False
        Me.txtDiaLimite.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaLimite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiaLimite.LabelConsulta = Nothing
        Me.txtDiaLimite.Location = New System.Drawing.Point(217, 142)
        Me.txtDiaLimite.MaxLength = 2
        Me.txtDiaLimite.Multiline = True
        Me.txtDiaLimite.Name = "txtDiaLimite"
        Me.txtDiaLimite.NombreDeConsulta = Nothing
        Me.txtDiaLimite.NumeroDecimales = 0
        Me.txtDiaLimite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiaLimite.Size = New System.Drawing.Size(52, 20)
        Me.txtDiaLimite.TabIndex = 6
        Me.txtDiaLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMontoMinimo
        '
        Me.txtMontoMinimo.AcceptsReturn = True
        Me.txtMontoMinimo.BackColor = System.Drawing.SystemColors.Window
        Me.txtMontoMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoMinimo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMontoMinimo.Enabled = False
        Me.txtMontoMinimo.EsRequerido = False
        Me.txtMontoMinimo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoMinimo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMontoMinimo.LabelConsulta = Nothing
        Me.txtMontoMinimo.Location = New System.Drawing.Point(217, 194)
        Me.txtMontoMinimo.MaxLength = 13
        Me.txtMontoMinimo.Multiline = True
        Me.txtMontoMinimo.Name = "txtMontoMinimo"
        Me.txtMontoMinimo.NombreDeConsulta = Nothing
        Me.txtMontoMinimo.NumeroDecimales = 2
        Me.txtMontoMinimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMontoMinimo.Size = New System.Drawing.Size(113, 20)
        Me.txtMontoMinimo.TabIndex = 8
        Me.txtMontoMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTiempoDepreciacion
        '
        Me.txtTiempoDepreciacion.AcceptsReturn = True
        Me.txtTiempoDepreciacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtTiempoDepreciacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTiempoDepreciacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTiempoDepreciacion.Enabled = False
        Me.txtTiempoDepreciacion.EsRequerido = False
        Me.txtTiempoDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTiempoDepreciacion.LabelConsulta = Nothing
        Me.txtTiempoDepreciacion.Location = New System.Drawing.Point(217, 168)
        Me.txtTiempoDepreciacion.MaxLength = 5
        Me.txtTiempoDepreciacion.Multiline = True
        Me.txtTiempoDepreciacion.Name = "txtTiempoDepreciacion"
        Me.txtTiempoDepreciacion.NombreDeConsulta = Nothing
        Me.txtTiempoDepreciacion.NumeroDecimales = 0
        Me.txtTiempoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTiempoDepreciacion.Size = New System.Drawing.Size(52, 20)
        Me.txtTiempoDepreciacion.TabIndex = 7
        Me.txtTiempoDepreciacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTipoCatalogo
        '
        Me.txtTipoCatalogo.AcceptsReturn = True
        Me.txtTipoCatalogo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCatalogo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoCatalogo.Enabled = False
        Me.txtTipoCatalogo.EsRequerido = False
        Me.txtTipoCatalogo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCatalogo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoCatalogo.LabelConsulta = Nothing
        Me.txtTipoCatalogo.Location = New System.Drawing.Point(217, 248)
        Me.txtTipoCatalogo.MaxLength = 3
        Me.txtTipoCatalogo.Name = "txtTipoCatalogo"
        Me.txtTipoCatalogo.NombreDeConsulta = Nothing
        Me.txtTipoCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoCatalogo.Size = New System.Drawing.Size(52, 20)
        Me.txtTipoCatalogo.TabIndex = 10
        Me.txtTipoCatalogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCalculaPrimeraDepreciacion
        '
        Me.lblCalculaPrimeraDepreciacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCalculaPrimeraDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCalculaPrimeraDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculaPrimeraDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCalculaPrimeraDepreciacion.Location = New System.Drawing.Point(6, 117)
        Me.lblCalculaPrimeraDepreciacion.Name = "lblCalculaPrimeraDepreciacion"
        Me.lblCalculaPrimeraDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCalculaPrimeraDepreciacion.Size = New System.Drawing.Size(205, 14)
        Me.lblCalculaPrimeraDepreciacion.TabIndex = 50
        Me.lblCalculaPrimeraDepreciacion.Text = "Calcula primera depreciación"
        '
        'lblNombreTipoCatalogo
        '
        Me.lblNombreTipoCatalogo.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreTipoCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoCatalogo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoCatalogo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoCatalogo.Location = New System.Drawing.Point(275, 250)
        Me.lblNombreTipoCatalogo.Name = "lblNombreTipoCatalogo"
        Me.lblNombreTipoCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoCatalogo.Size = New System.Drawing.Size(378, 20)
        Me.lblNombreTipoCatalogo.TabIndex = 49
        Me.lblNombreTipoCatalogo.Text = "lblNombreTipoCatalogo"
        Me.lblNombreTipoCatalogo.UseMnemonic = False
        '
        'lblClaseContabilizacion
        '
        Me.lblClaseContabilizacion.BackColor = System.Drawing.Color.Transparent
        Me.lblClaseContabilizacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblClaseContabilizacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaseContabilizacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblClaseContabilizacion.Location = New System.Drawing.Point(6, 223)
        Me.lblClaseContabilizacion.Name = "lblClaseContabilizacion"
        Me.lblClaseContabilizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClaseContabilizacion.Size = New System.Drawing.Size(205, 14)
        Me.lblClaseContabilizacion.TabIndex = 48
        Me.lblClaseContabilizacion.Text = "Clase de contabilización"
        '
        'lblCodigoTipoActivo
        '
        Me.lblCodigoTipoActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoTipoActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoTipoActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoTipoActivo.Location = New System.Drawing.Point(6, 8)
        Me.lblCodigoTipoActivo.Name = "lblCodigoTipoActivo"
        Me.lblCodigoTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoTipoActivo.Size = New System.Drawing.Size(205, 14)
        Me.lblCodigoTipoActivo.TabIndex = 47
        Me.lblCodigoTipoActivo.Text = "Código"
        '
        'lblTipoActivoDescripcion
        '
        Me.lblTipoActivoDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoActivoDescripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoActivoDescripcion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoActivoDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoActivoDescripcion.Location = New System.Drawing.Point(6, 31)
        Me.lblTipoActivoDescripcion.Name = "lblTipoActivoDescripcion"
        Me.lblTipoActivoDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoActivoDescripcion.Size = New System.Drawing.Size(205, 14)
        Me.lblTipoActivoDescripcion.TabIndex = 46
        Me.lblTipoActivoDescripcion.Text = "Descripción"
        '
        'lblTipoDepreciacion
        '
        Me.lblTipoDepreciacion.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoDepreciacion.Location = New System.Drawing.Point(6, 61)
        Me.lblTipoDepreciacion.Name = "lblTipoDepreciacion"
        Me.lblTipoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoDepreciacion.Size = New System.Drawing.Size(205, 14)
        Me.lblTipoDepreciacion.TabIndex = 45
        Me.lblTipoDepreciacion.Text = "Tipo de depreciación"
        '
        'lblDiaLimite
        '
        Me.lblDiaLimite.BackColor = System.Drawing.Color.Transparent
        Me.lblDiaLimite.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiaLimite.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaLimite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDiaLimite.Location = New System.Drawing.Point(6, 144)
        Me.lblDiaLimite.Name = "lblDiaLimite"
        Me.lblDiaLimite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiaLimite.Size = New System.Drawing.Size(205, 14)
        Me.lblDiaLimite.TabIndex = 44
        Me.lblDiaLimite.Text = "Día límite fecha depreciación"
        '
        'lblMontoMinimo
        '
        Me.lblMontoMinimo.BackColor = System.Drawing.Color.Transparent
        Me.lblMontoMinimo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMontoMinimo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinimo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMontoMinimo.Location = New System.Drawing.Point(6, 196)
        Me.lblMontoMinimo.Name = "lblMontoMinimo"
        Me.lblMontoMinimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMontoMinimo.Size = New System.Drawing.Size(205, 14)
        Me.lblMontoMinimo.TabIndex = 43
        Me.lblMontoMinimo.Text = "Monto mínimo de deprec. de activo"
        '
        'lblTiempoDepreciacion
        '
        Me.lblTiempoDepreciacion.BackColor = System.Drawing.Color.Transparent
        Me.lblTiempoDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTiempoDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTiempoDepreciacion.Location = New System.Drawing.Point(6, 170)
        Me.lblTiempoDepreciacion.Name = "lblTiempoDepreciacion"
        Me.lblTiempoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTiempoDepreciacion.Size = New System.Drawing.Size(205, 14)
        Me.lblTiempoDepreciacion.TabIndex = 42
        Me.lblTiempoDepreciacion.Text = "Tiempo de depreciación (meses)"
        '
        'lblTipoCatalogo
        '
        Me.lblTipoCatalogo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoCatalogo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCatalogo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoCatalogo.Location = New System.Drawing.Point(6, 250)
        Me.lblTipoCatalogo.Name = "lblTipoCatalogo"
        Me.lblTipoCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoCatalogo.Size = New System.Drawing.Size(205, 14)
        Me.lblTipoCatalogo.TabIndex = 41
        Me.lblTipoCatalogo.Text = "Tipo de catálogo"
        '
        'lblFormaDepreciacion
        '
        Me.lblFormaDepreciacion.BackColor = System.Drawing.Color.Transparent
        Me.lblFormaDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFormaDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFormaDepreciacion.Location = New System.Drawing.Point(6, 89)
        Me.lblFormaDepreciacion.Name = "lblFormaDepreciacion"
        Me.lblFormaDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFormaDepreciacion.Size = New System.Drawing.Size(205, 14)
        Me.lblFormaDepreciacion.TabIndex = 40
        Me.lblFormaDepreciacion.Text = "Forma de depreciación"
        '
        'lblDiasCalculoDepreciacion
        '
        Me.lblDiasCalculoDepreciacion.BackColor = System.Drawing.Color.Transparent
        Me.lblDiasCalculoDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiasCalculoDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasCalculoDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDiasCalculoDepreciacion.Location = New System.Drawing.Point(381, 89)
        Me.lblDiasCalculoDepreciacion.Name = "lblDiasCalculoDepreciacion"
        Me.lblDiasCalculoDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiasCalculoDepreciacion.Size = New System.Drawing.Size(153, 14)
        Me.lblDiasCalculoDepreciacion.TabIndex = 39
        Me.lblDiasCalculoDepreciacion.Text = "Días cálculo depreciación"
        '
        'tbpBalance
        '
        Me.tbpBalance.BackColor = System.Drawing.SystemColors.Control
        Me.tbpBalance.Controls.Add(Me.grpReevaluacion)
        Me.tbpBalance.Controls.Add(Me.grpGastos)
        Me.tbpBalance.Controls.Add(Me.grpBalance)
        Me.tbpBalance.Location = New System.Drawing.Point(4, 22)
        Me.tbpBalance.Name = "tbpBalance"
        Me.tbpBalance.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpBalance.Size = New System.Drawing.Size(659, 284)
        Me.tbpBalance.TabIndex = 1
        Me.tbpBalance.Text = "Cuentas contables ( F2 )"
        '
        'grpReevaluacion
        '
        Me.grpReevaluacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpReevaluacion.Controls.Add(Me.txtCuentaReevaluacion)
        Me.grpReevaluacion.Controls.Add(Me.txtCentroReevaluacion)
        Me.grpReevaluacion.Controls.Add(Me.lblCuentaReevaluacion)
        Me.grpReevaluacion.Controls.Add(Me.lblCentroReevaluacion)
        Me.grpReevaluacion.Controls.Add(Me.lblNombreCentroReevaluacion)
        Me.grpReevaluacion.Controls.Add(Me.lblNombreCuentaReevaluacion)
        Me.grpReevaluacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpReevaluacion.Location = New System.Drawing.Point(6, 192)
        Me.grpReevaluacion.Name = "grpReevaluacion"
        Me.grpReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpReevaluacion.Size = New System.Drawing.Size(647, 77)
        Me.grpReevaluacion.TabIndex = 2
        Me.grpReevaluacion.TabStop = False
        Me.grpReevaluacion.Text = "Cuentas de Reevaluación "
        '
        'txtCuentaReevaluacion
        '
        Me.txtCuentaReevaluacion.AcceptsReturn = True
        Me.txtCuentaReevaluacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaReevaluacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaReevaluacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaReevaluacion.Enabled = False
        Me.txtCuentaReevaluacion.EsRequerido = False
        Me.txtCuentaReevaluacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaReevaluacion.LabelConsulta = Nothing
        Me.txtCuentaReevaluacion.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaReevaluacion.MaxLength = 30
        Me.txtCuentaReevaluacion.Name = "txtCuentaReevaluacion"
        Me.txtCuentaReevaluacion.NombreDeConsulta = Nothing
        Me.txtCuentaReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaReevaluacion.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaReevaluacion.TabIndex = 6
        Me.txtCuentaReevaluacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroReevaluacion
        '
        Me.txtCentroReevaluacion.AcceptsReturn = True
        Me.txtCentroReevaluacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroReevaluacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroReevaluacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroReevaluacion.Enabled = False
        Me.txtCentroReevaluacion.EsRequerido = False
        Me.txtCentroReevaluacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroReevaluacion.LabelConsulta = Nothing
        Me.txtCentroReevaluacion.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroReevaluacion.MaxLength = 15
        Me.txtCentroReevaluacion.Name = "txtCentroReevaluacion"
        Me.txtCentroReevaluacion.NombreDeConsulta = Nothing
        Me.txtCentroReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroReevaluacion.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroReevaluacion.TabIndex = 5
        '
        'lblCuentaReevaluacion
        '
        Me.lblCuentaReevaluacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaReevaluacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaReevaluacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaReevaluacion.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaReevaluacion.Name = "lblCuentaReevaluacion"
        Me.lblCuentaReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaReevaluacion.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaReevaluacion.TabIndex = 23
        Me.lblCuentaReevaluacion.Text = "Cuenta"
        '
        'lblCentroReevaluacion
        '
        Me.lblCentroReevaluacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroReevaluacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroReevaluacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroReevaluacion.Location = New System.Drawing.Point(6, 22)
        Me.lblCentroReevaluacion.Name = "lblCentroReevaluacion"
        Me.lblCentroReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroReevaluacion.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroReevaluacion.TabIndex = 22
        Me.lblCentroReevaluacion.Text = "Centro"
        '
        'lblNombreCentroReevaluacion
        '
        Me.lblNombreCentroReevaluacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroReevaluacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroReevaluacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroReevaluacion.Location = New System.Drawing.Point(399, 22)
        Me.lblNombreCentroReevaluacion.Name = "lblNombreCentroReevaluacion"
        Me.lblNombreCentroReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroReevaluacion.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroReevaluacion.TabIndex = 21
        Me.lblNombreCentroReevaluacion.Text = "lblNombreCentroReevaluacion"
        Me.lblNombreCentroReevaluacion.UseMnemonic = False
        '
        'lblNombreCuentaReevaluacion
        '
        Me.lblNombreCuentaReevaluacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaReevaluacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaReevaluacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaReevaluacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaReevaluacion.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaReevaluacion.Name = "lblNombreCuentaReevaluacion"
        Me.lblNombreCuentaReevaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaReevaluacion.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaReevaluacion.TabIndex = 20
        Me.lblNombreCuentaReevaluacion.Text = "lblNombreCuentaReevaluacion"
        Me.lblNombreCuentaReevaluacion.UseMnemonic = False
        '
        'grpGastos
        '
        Me.grpGastos.BackColor = System.Drawing.SystemColors.Control
        Me.grpGastos.Controls.Add(Me.txtCuentaGastos)
        Me.grpGastos.Controls.Add(Me.txtCentroGastos)
        Me.grpGastos.Controls.Add(Me.lblCuentaGastos)
        Me.grpGastos.Controls.Add(Me.lblCentroGastos)
        Me.grpGastos.Controls.Add(Me.lblNombreCentroGastos)
        Me.grpGastos.Controls.Add(Me.lblNombreCuentaGastos)
        Me.grpGastos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpGastos.Location = New System.Drawing.Point(6, 109)
        Me.grpGastos.Name = "grpGastos"
        Me.grpGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpGastos.Size = New System.Drawing.Size(647, 77)
        Me.grpGastos.TabIndex = 1
        Me.grpGastos.TabStop = False
        Me.grpGastos.Text = "Cuentas de Gastos "
        '
        'txtCuentaGastos
        '
        Me.txtCuentaGastos.AcceptsReturn = True
        Me.txtCuentaGastos.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaGastos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaGastos.Enabled = False
        Me.txtCuentaGastos.EsRequerido = False
        Me.txtCuentaGastos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaGastos.LabelConsulta = Nothing
        Me.txtCuentaGastos.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaGastos.MaxLength = 30
        Me.txtCuentaGastos.Name = "txtCuentaGastos"
        Me.txtCuentaGastos.NombreDeConsulta = Nothing
        Me.txtCuentaGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaGastos.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaGastos.TabIndex = 4
        Me.txtCuentaGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroGastos
        '
        Me.txtCentroGastos.AcceptsReturn = True
        Me.txtCentroGastos.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroGastos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroGastos.Enabled = False
        Me.txtCentroGastos.EsRequerido = False
        Me.txtCentroGastos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroGastos.LabelConsulta = Nothing
        Me.txtCentroGastos.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroGastos.MaxLength = 15
        Me.txtCentroGastos.Name = "txtCentroGastos"
        Me.txtCentroGastos.NombreDeConsulta = Nothing
        Me.txtCentroGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroGastos.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroGastos.TabIndex = 3
        Me.txtCentroGastos.Visible = False
        '
        'lblCuentaGastos
        '
        Me.lblCuentaGastos.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaGastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaGastos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaGastos.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaGastos.Name = "lblCuentaGastos"
        Me.lblCuentaGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaGastos.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaGastos.TabIndex = 16
        Me.lblCuentaGastos.Text = "Cuenta"
        '
        'lblCentroGastos
        '
        Me.lblCentroGastos.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroGastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroGastos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroGastos.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroGastos.Name = "lblCentroGastos"
        Me.lblCentroGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroGastos.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroGastos.TabIndex = 15
        Me.lblCentroGastos.Text = "Centro"
        Me.lblCentroGastos.Visible = False
        '
        'lblNombreCentroGastos
        '
        Me.lblNombreCentroGastos.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroGastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroGastos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroGastos.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroGastos.Name = "lblNombreCentroGastos"
        Me.lblNombreCentroGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroGastos.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroGastos.TabIndex = 14
        Me.lblNombreCentroGastos.Text = "lblNombreCentroGastos"
        Me.lblNombreCentroGastos.UseMnemonic = False
        Me.lblNombreCentroGastos.Visible = False
        '
        'lblNombreCuentaGastos
        '
        Me.lblNombreCuentaGastos.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaGastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaGastos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaGastos.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaGastos.Name = "lblNombreCuentaGastos"
        Me.lblNombreCuentaGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaGastos.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaGastos.TabIndex = 13
        Me.lblNombreCuentaGastos.Text = "lblNombreCuentaGastos"
        Me.lblNombreCuentaGastos.UseMnemonic = False
        '
        'grpBalance
        '
        Me.grpBalance.BackColor = System.Drawing.SystemColors.Control
        Me.grpBalance.Controls.Add(Me.txtCuentaDepreciacion)
        Me.grpBalance.Controls.Add(Me.txtCuentaActivo)
        Me.grpBalance.Controls.Add(Me.txtCentroBalance)
        Me.grpBalance.Controls.Add(Me.lblCuentaDepreciacion)
        Me.grpBalance.Controls.Add(Me.lblCuentaActivo)
        Me.grpBalance.Controls.Add(Me.lblCentroBalance)
        Me.grpBalance.Controls.Add(Me.lblNombreCentroBalance)
        Me.grpBalance.Controls.Add(Me.lblNombreCuentaActivo)
        Me.grpBalance.Controls.Add(Me.lblNombreCuentaDepreciacion)
        Me.grpBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpBalance.Location = New System.Drawing.Point(6, 6)
        Me.grpBalance.Name = "grpBalance"
        Me.grpBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpBalance.Size = New System.Drawing.Size(647, 97)
        Me.grpBalance.TabIndex = 0
        Me.grpBalance.TabStop = False
        Me.grpBalance.Text = "Cuentas de Balance "
        '
        'txtCuentaDepreciacion
        '
        Me.txtCuentaDepreciacion.AcceptsReturn = True
        Me.txtCuentaDepreciacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaDepreciacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaDepreciacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaDepreciacion.Enabled = False
        Me.txtCuentaDepreciacion.EsRequerido = False
        Me.txtCuentaDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaDepreciacion.LabelConsulta = Nothing
        Me.txtCuentaDepreciacion.Location = New System.Drawing.Point(156, 71)
        Me.txtCuentaDepreciacion.MaxLength = 30
        Me.txtCuentaDepreciacion.Name = "txtCuentaDepreciacion"
        Me.txtCuentaDepreciacion.NombreDeConsulta = Nothing
        Me.txtCuentaDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaDepreciacion.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaDepreciacion.TabIndex = 2
        Me.txtCuentaDepreciacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuentaActivo
        '
        Me.txtCuentaActivo.AcceptsReturn = True
        Me.txtCuentaActivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaActivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaActivo.Enabled = False
        Me.txtCuentaActivo.EsRequerido = False
        Me.txtCuentaActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaActivo.LabelConsulta = Nothing
        Me.txtCuentaActivo.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaActivo.MaxLength = 30
        Me.txtCuentaActivo.Name = "txtCuentaActivo"
        Me.txtCuentaActivo.NombreDeConsulta = Nothing
        Me.txtCuentaActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaActivo.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaActivo.TabIndex = 1
        Me.txtCuentaActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroBalance
        '
        Me.txtCentroBalance.AcceptsReturn = True
        Me.txtCentroBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroBalance.Enabled = False
        Me.txtCentroBalance.EsRequerido = False
        Me.txtCentroBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroBalance.LabelConsulta = Nothing
        Me.txtCentroBalance.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroBalance.MaxLength = 15
        Me.txtCentroBalance.Name = "txtCentroBalance"
        Me.txtCentroBalance.NombreDeConsulta = Nothing
        Me.txtCentroBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroBalance.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroBalance.TabIndex = 0
        '
        'lblCuentaDepreciacion
        '
        Me.lblCuentaDepreciacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaDepreciacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaDepreciacion.Location = New System.Drawing.Point(6, 73)
        Me.lblCuentaDepreciacion.Name = "lblCuentaDepreciacion"
        Me.lblCuentaDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaDepreciacion.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaDepreciacion.TabIndex = 9
        Me.lblCuentaDepreciacion.Text = "Cuenta de depreciación"
        '
        'lblCuentaActivo
        '
        Me.lblCuentaActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaActivo.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaActivo.Name = "lblCuentaActivo"
        Me.lblCuentaActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaActivo.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaActivo.TabIndex = 8
        Me.lblCuentaActivo.Text = "Cuenta de activo"
        '
        'lblCentroBalance
        '
        Me.lblCentroBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroBalance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroBalance.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroBalance.Name = "lblCentroBalance"
        Me.lblCentroBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroBalance.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroBalance.TabIndex = 7
        Me.lblCentroBalance.Text = "Centro"
        '
        'lblNombreCentroBalance
        '
        Me.lblNombreCentroBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroBalance.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroBalance.Name = "lblNombreCentroBalance"
        Me.lblNombreCentroBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroBalance.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroBalance.TabIndex = 6
        Me.lblNombreCentroBalance.Text = "lblNombreCentroBalance"
        Me.lblNombreCentroBalance.UseMnemonic = False
        '
        'lblNombreCuentaActivo
        '
        Me.lblNombreCuentaActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaActivo.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaActivo.Name = "lblNombreCuentaActivo"
        Me.lblNombreCuentaActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaActivo.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaActivo.TabIndex = 5
        Me.lblNombreCuentaActivo.Text = "lblNombreCuentaActivo"
        Me.lblNombreCuentaActivo.UseMnemonic = False
        '
        'lblNombreCuentaDepreciacion
        '
        Me.lblNombreCuentaDepreciacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaDepreciacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaDepreciacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaDepreciacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaDepreciacion.Location = New System.Drawing.Point(399, 73)
        Me.lblNombreCuentaDepreciacion.Name = "lblNombreCuentaDepreciacion"
        Me.lblNombreCuentaDepreciacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaDepreciacion.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaDepreciacion.TabIndex = 4
        Me.lblNombreCuentaDepreciacion.Text = "lblNombreCuentaDepreciacion"
        Me.lblNombreCuentaDepreciacion.UseMnemonic = False
        '
        'tbpIngresoEgreso
        '
        Me.tbpIngresoEgreso.BackColor = System.Drawing.SystemColors.Control
        Me.tbpIngresoEgreso.Controls.Add(Me.grpDesecho)
        Me.tbpIngresoEgreso.Controls.Add(Me.grpIngresosEgresos)
        Me.tbpIngresoEgreso.Controls.Add(Me.grpCompras)
        Me.tbpIngresoEgreso.Location = New System.Drawing.Point(4, 22)
        Me.tbpIngresoEgreso.Name = "tbpIngresoEgreso"
        Me.tbpIngresoEgreso.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpIngresoEgreso.Size = New System.Drawing.Size(659, 284)
        Me.tbpIngresoEgreso.TabIndex = 2
        Me.tbpIngresoEgreso.Text = "Cuentas contables ( F3 )"
        '
        'grpDesecho
        '
        Me.grpDesecho.BackColor = System.Drawing.SystemColors.Control
        Me.grpDesecho.Controls.Add(Me.txtCuentaDesecho)
        Me.grpDesecho.Controls.Add(Me.txtCentroDesecho)
        Me.grpDesecho.Controls.Add(Me.lblCuentaDesecho)
        Me.grpDesecho.Controls.Add(Me.lblCentroDesecho)
        Me.grpDesecho.Controls.Add(Me.lblNombreCentroDesecho)
        Me.grpDesecho.Controls.Add(Me.lblNombreCuentaDesecho)
        Me.grpDesecho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpDesecho.Location = New System.Drawing.Point(6, 192)
        Me.grpDesecho.Name = "grpDesecho"
        Me.grpDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDesecho.Size = New System.Drawing.Size(647, 81)
        Me.grpDesecho.TabIndex = 2
        Me.grpDesecho.TabStop = False
        Me.grpDesecho.Text = "Cuentas de desecho "
        '
        'txtCuentaDesecho
        '
        Me.txtCuentaDesecho.AcceptsReturn = True
        Me.txtCuentaDesecho.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaDesecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaDesecho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaDesecho.Enabled = False
        Me.txtCuentaDesecho.EsRequerido = False
        Me.txtCuentaDesecho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaDesecho.LabelConsulta = Nothing
        Me.txtCuentaDesecho.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaDesecho.MaxLength = 30
        Me.txtCuentaDesecho.Name = "txtCuentaDesecho"
        Me.txtCuentaDesecho.NombreDeConsulta = Nothing
        Me.txtCuentaDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaDesecho.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaDesecho.TabIndex = 6
        Me.txtCuentaDesecho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroDesecho
        '
        Me.txtCentroDesecho.AcceptsReturn = True
        Me.txtCentroDesecho.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroDesecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroDesecho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroDesecho.Enabled = False
        Me.txtCentroDesecho.EsRequerido = False
        Me.txtCentroDesecho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroDesecho.LabelConsulta = Nothing
        Me.txtCentroDesecho.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroDesecho.MaxLength = 15
        Me.txtCentroDesecho.Name = "txtCentroDesecho"
        Me.txtCentroDesecho.NombreDeConsulta = Nothing
        Me.txtCentroDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroDesecho.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroDesecho.TabIndex = 5
        '
        'lblCuentaDesecho
        '
        Me.lblCuentaDesecho.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaDesecho.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaDesecho.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaDesecho.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaDesecho.Name = "lblCuentaDesecho"
        Me.lblCuentaDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaDesecho.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaDesecho.TabIndex = 23
        Me.lblCuentaDesecho.Text = "Cuenta"
        '
        'lblCentroDesecho
        '
        Me.lblCentroDesecho.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroDesecho.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroDesecho.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroDesecho.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroDesecho.Name = "lblCentroDesecho"
        Me.lblCentroDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroDesecho.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroDesecho.TabIndex = 22
        Me.lblCentroDesecho.Text = "Centro"
        '
        'lblNombreCentroDesecho
        '
        Me.lblNombreCentroDesecho.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroDesecho.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroDesecho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroDesecho.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroDesecho.Name = "lblNombreCentroDesecho"
        Me.lblNombreCentroDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroDesecho.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroDesecho.TabIndex = 21
        Me.lblNombreCentroDesecho.Text = "lblNombreCentroDesecho"
        Me.lblNombreCentroDesecho.UseMnemonic = False
        '
        'lblNombreCuentaDesecho
        '
        Me.lblNombreCuentaDesecho.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaDesecho.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaDesecho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaDesecho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaDesecho.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaDesecho.Name = "lblNombreCuentaDesecho"
        Me.lblNombreCuentaDesecho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaDesecho.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaDesecho.TabIndex = 20
        Me.lblNombreCuentaDesecho.Text = "lblNombreCuentaDesecho"
        Me.lblNombreCuentaDesecho.UseMnemonic = False
        '
        'grpIngresosEgresos
        '
        Me.grpIngresosEgresos.BackColor = System.Drawing.SystemColors.Control
        Me.grpIngresosEgresos.Controls.Add(Me.txtCuentaPerdida)
        Me.grpIngresosEgresos.Controls.Add(Me.txtCuentaGanancia)
        Me.grpIngresosEgresos.Controls.Add(Me.txtCentroIngresosEgresos)
        Me.grpIngresosEgresos.Controls.Add(Me.lblCuentaPerdida)
        Me.grpIngresosEgresos.Controls.Add(Me.lblCuentaGanancia)
        Me.grpIngresosEgresos.Controls.Add(Me.lblCentroIngresosEgresos)
        Me.grpIngresosEgresos.Controls.Add(Me.lblNombreCentroIngresosEgresos)
        Me.grpIngresosEgresos.Controls.Add(Me.lblNombreCuentaGanancia)
        Me.grpIngresosEgresos.Controls.Add(Me.lblNombreCuentaPerdida)
        Me.grpIngresosEgresos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIngresosEgresos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpIngresosEgresos.Location = New System.Drawing.Point(6, 6)
        Me.grpIngresosEgresos.Name = "grpIngresosEgresos"
        Me.grpIngresosEgresos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpIngresosEgresos.Size = New System.Drawing.Size(647, 97)
        Me.grpIngresosEgresos.TabIndex = 0
        Me.grpIngresosEgresos.TabStop = False
        Me.grpIngresosEgresos.Text = "Cuentas de Ingresos/Egresos por venta "
        '
        'txtCuentaPerdida
        '
        Me.txtCuentaPerdida.AcceptsReturn = True
        Me.txtCuentaPerdida.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaPerdida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaPerdida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaPerdida.Enabled = False
        Me.txtCuentaPerdida.EsRequerido = False
        Me.txtCuentaPerdida.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaPerdida.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaPerdida.LabelConsulta = Nothing
        Me.txtCuentaPerdida.Location = New System.Drawing.Point(156, 71)
        Me.txtCuentaPerdida.MaxLength = 30
        Me.txtCuentaPerdida.Name = "txtCuentaPerdida"
        Me.txtCuentaPerdida.NombreDeConsulta = Nothing
        Me.txtCuentaPerdida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaPerdida.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaPerdida.TabIndex = 2
        Me.txtCuentaPerdida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuentaGanancia
        '
        Me.txtCuentaGanancia.AcceptsReturn = True
        Me.txtCuentaGanancia.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaGanancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaGanancia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaGanancia.Enabled = False
        Me.txtCuentaGanancia.EsRequerido = False
        Me.txtCuentaGanancia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaGanancia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaGanancia.LabelConsulta = Nothing
        Me.txtCuentaGanancia.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaGanancia.MaxLength = 30
        Me.txtCuentaGanancia.Name = "txtCuentaGanancia"
        Me.txtCuentaGanancia.NombreDeConsulta = Nothing
        Me.txtCuentaGanancia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaGanancia.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaGanancia.TabIndex = 1
        Me.txtCuentaGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroIngresosEgresos
        '
        Me.txtCentroIngresosEgresos.AcceptsReturn = True
        Me.txtCentroIngresosEgresos.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroIngresosEgresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroIngresosEgresos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroIngresosEgresos.Enabled = False
        Me.txtCentroIngresosEgresos.EsRequerido = False
        Me.txtCentroIngresosEgresos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroIngresosEgresos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroIngresosEgresos.LabelConsulta = Nothing
        Me.txtCentroIngresosEgresos.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroIngresosEgresos.MaxLength = 15
        Me.txtCentroIngresosEgresos.Name = "txtCentroIngresosEgresos"
        Me.txtCentroIngresosEgresos.NombreDeConsulta = Nothing
        Me.txtCentroIngresosEgresos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroIngresosEgresos.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroIngresosEgresos.TabIndex = 0
        '
        'lblCuentaPerdida
        '
        Me.lblCuentaPerdida.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaPerdida.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaPerdida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaPerdida.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaPerdida.Location = New System.Drawing.Point(6, 73)
        Me.lblCuentaPerdida.Name = "lblCuentaPerdida"
        Me.lblCuentaPerdida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaPerdida.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaPerdida.TabIndex = 16
        Me.lblCuentaPerdida.Text = "Cuenta de pérdida"
        '
        'lblCuentaGanancia
        '
        Me.lblCuentaGanancia.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaGanancia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaGanancia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaGanancia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaGanancia.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaGanancia.Name = "lblCuentaGanancia"
        Me.lblCuentaGanancia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaGanancia.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaGanancia.TabIndex = 15
        Me.lblCuentaGanancia.Text = "Cuenta de ganancia"
        '
        'lblCentroIngresosEgresos
        '
        Me.lblCentroIngresosEgresos.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroIngresosEgresos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroIngresosEgresos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroIngresosEgresos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroIngresosEgresos.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroIngresosEgresos.Name = "lblCentroIngresosEgresos"
        Me.lblCentroIngresosEgresos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroIngresosEgresos.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroIngresosEgresos.TabIndex = 14
        Me.lblCentroIngresosEgresos.Text = "Centro"
        '
        'lblNombreCentroIngresosEgresos
        '
        Me.lblNombreCentroIngresosEgresos.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroIngresosEgresos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroIngresosEgresos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroIngresosEgresos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroIngresosEgresos.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroIngresosEgresos.Name = "lblNombreCentroIngresosEgresos"
        Me.lblNombreCentroIngresosEgresos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroIngresosEgresos.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroIngresosEgresos.TabIndex = 13
        Me.lblNombreCentroIngresosEgresos.Text = "lblNombreCentroIngresosEgresos"
        Me.lblNombreCentroIngresosEgresos.UseMnemonic = False
        '
        'lblNombreCuentaGanancia
        '
        Me.lblNombreCuentaGanancia.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaGanancia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaGanancia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaGanancia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaGanancia.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaGanancia.Name = "lblNombreCuentaGanancia"
        Me.lblNombreCuentaGanancia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaGanancia.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaGanancia.TabIndex = 12
        Me.lblNombreCuentaGanancia.Text = "lblNombreCuentaGanancia"
        Me.lblNombreCuentaGanancia.UseMnemonic = False
        '
        'lblNombreCuentaPerdida
        '
        Me.lblNombreCuentaPerdida.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaPerdida.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaPerdida.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaPerdida.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaPerdida.Location = New System.Drawing.Point(399, 73)
        Me.lblNombreCuentaPerdida.Name = "lblNombreCuentaPerdida"
        Me.lblNombreCuentaPerdida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaPerdida.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaPerdida.TabIndex = 11
        Me.lblNombreCuentaPerdida.Text = "lblNombreCuentaPerdida"
        Me.lblNombreCuentaPerdida.UseMnemonic = False
        '
        'grpCompras
        '
        Me.grpCompras.BackColor = System.Drawing.SystemColors.Control
        Me.grpCompras.Controls.Add(Me.txtCuentaCompras)
        Me.grpCompras.Controls.Add(Me.txtCentroCompras)
        Me.grpCompras.Controls.Add(Me.lblCuentaCompras)
        Me.grpCompras.Controls.Add(Me.lblCentroCompras)
        Me.grpCompras.Controls.Add(Me.lblNombreCentroCompras)
        Me.grpCompras.Controls.Add(Me.lblNombreCuentaCompras)
        Me.grpCompras.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCompras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpCompras.Location = New System.Drawing.Point(6, 109)
        Me.grpCompras.Name = "grpCompras"
        Me.grpCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpCompras.Size = New System.Drawing.Size(647, 77)
        Me.grpCompras.TabIndex = 1
        Me.grpCompras.TabStop = False
        Me.grpCompras.Text = "Cuentas de compras "
        '
        'txtCuentaCompras
        '
        Me.txtCuentaCompras.AcceptsReturn = True
        Me.txtCuentaCompras.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCompras.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaCompras.Enabled = False
        Me.txtCuentaCompras.EsRequerido = False
        Me.txtCuentaCompras.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaCompras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaCompras.LabelConsulta = Nothing
        Me.txtCuentaCompras.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaCompras.MaxLength = 30
        Me.txtCuentaCompras.Name = "txtCuentaCompras"
        Me.txtCuentaCompras.NombreDeConsulta = Nothing
        Me.txtCuentaCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaCompras.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaCompras.TabIndex = 4
        Me.txtCuentaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroCompras
        '
        Me.txtCentroCompras.AcceptsReturn = True
        Me.txtCentroCompras.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroCompras.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroCompras.Enabled = False
        Me.txtCentroCompras.EsRequerido = False
        Me.txtCentroCompras.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroCompras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroCompras.LabelConsulta = Nothing
        Me.txtCentroCompras.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroCompras.MaxLength = 15
        Me.txtCentroCompras.Name = "txtCentroCompras"
        Me.txtCentroCompras.NombreDeConsulta = Nothing
        Me.txtCentroCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroCompras.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroCompras.TabIndex = 3
        '
        'lblCuentaCompras
        '
        Me.lblCuentaCompras.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaCompras.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaCompras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaCompras.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaCompras.Name = "lblCuentaCompras"
        Me.lblCuentaCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaCompras.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaCompras.TabIndex = 6
        Me.lblCuentaCompras.Text = "Cuenta"
        '
        'lblCentroCompras
        '
        Me.lblCentroCompras.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroCompras.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroCompras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroCompras.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroCompras.Name = "lblCentroCompras"
        Me.lblCentroCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroCompras.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroCompras.TabIndex = 5
        Me.lblCentroCompras.Text = "Centro"
        '
        'lblNombreCentroCompras
        '
        Me.lblNombreCentroCompras.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroCompras.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroCompras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroCompras.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroCompras.Name = "lblNombreCentroCompras"
        Me.lblNombreCentroCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroCompras.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroCompras.TabIndex = 4
        Me.lblNombreCentroCompras.Text = "lblNombreCentroCompras"
        Me.lblNombreCentroCompras.UseMnemonic = False
        '
        'lblNombreCuentaCompras
        '
        Me.lblNombreCuentaCompras.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaCompras.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaCompras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaCompras.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaCompras.Name = "lblNombreCuentaCompras"
        Me.lblNombreCuentaCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaCompras.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaCompras.TabIndex = 3
        Me.lblNombreCuentaCompras.Text = "lblNombreCuentaCompras"
        Me.lblNombreCuentaCompras.UseMnemonic = False
        '
        'tbpDonacion
        '
        Me.tbpDonacion.BackColor = System.Drawing.SystemColors.Control
        Me.tbpDonacion.Controls.Add(Me.grpDonacion)
        Me.tbpDonacion.Controls.Add(Me.grpVentas)
        Me.tbpDonacion.Controls.Add(Me.grpGastosNoDeducible)
        Me.tbpDonacion.Location = New System.Drawing.Point(4, 22)
        Me.tbpDonacion.Name = "tbpDonacion"
        Me.tbpDonacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDonacion.Size = New System.Drawing.Size(659, 284)
        Me.tbpDonacion.TabIndex = 3
        Me.tbpDonacion.Text = "Cuentas contables ( F5 )"
        '
        'grpDonacion
        '
        Me.grpDonacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpDonacion.Controls.Add(Me.txtCuentaDonacion)
        Me.grpDonacion.Controls.Add(Me.txtCentroDonacion)
        Me.grpDonacion.Controls.Add(Me.lblNombreCuentaDonacion)
        Me.grpDonacion.Controls.Add(Me.lblNombreCentroDonacion)
        Me.grpDonacion.Controls.Add(Me.lblCentroDonacion)
        Me.grpDonacion.Controls.Add(Me.lblCuentaDonacion)
        Me.grpDonacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDonacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpDonacion.Location = New System.Drawing.Point(6, 85)
        Me.grpDonacion.Name = "grpDonacion"
        Me.grpDonacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDonacion.Size = New System.Drawing.Size(647, 73)
        Me.grpDonacion.TabIndex = 1
        Me.grpDonacion.TabStop = False
        Me.grpDonacion.Text = "Cuenta de donación de activos "
        '
        'txtCuentaDonacion
        '
        Me.txtCuentaDonacion.AcceptsReturn = True
        Me.txtCuentaDonacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaDonacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaDonacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaDonacion.Enabled = False
        Me.txtCuentaDonacion.EsRequerido = False
        Me.txtCuentaDonacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaDonacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaDonacion.LabelConsulta = Nothing
        Me.txtCuentaDonacion.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaDonacion.MaxLength = 30
        Me.txtCuentaDonacion.Name = "txtCuentaDonacion"
        Me.txtCuentaDonacion.NombreDeConsulta = Nothing
        Me.txtCuentaDonacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaDonacion.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaDonacion.TabIndex = 3
        Me.txtCuentaDonacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCentroDonacion
        '
        Me.txtCentroDonacion.AcceptsReturn = True
        Me.txtCentroDonacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroDonacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroDonacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroDonacion.Enabled = False
        Me.txtCentroDonacion.EsRequerido = False
        Me.txtCentroDonacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroDonacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroDonacion.LabelConsulta = Nothing
        Me.txtCentroDonacion.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroDonacion.MaxLength = 15
        Me.txtCentroDonacion.Name = "txtCentroDonacion"
        Me.txtCentroDonacion.NombreDeConsulta = Nothing
        Me.txtCentroDonacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroDonacion.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroDonacion.TabIndex = 2
        '
        'lblNombreCuentaDonacion
        '
        Me.lblNombreCuentaDonacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaDonacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaDonacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaDonacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaDonacion.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaDonacion.Name = "lblNombreCuentaDonacion"
        Me.lblNombreCuentaDonacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaDonacion.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaDonacion.TabIndex = 20
        Me.lblNombreCuentaDonacion.Text = "Cuenta donación de activos"
        Me.lblNombreCuentaDonacion.UseMnemonic = False
        '
        'lblNombreCentroDonacion
        '
        Me.lblNombreCentroDonacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroDonacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroDonacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroDonacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroDonacion.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroDonacion.Name = "lblNombreCentroDonacion"
        Me.lblNombreCentroDonacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroDonacion.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroDonacion.TabIndex = 19
        Me.lblNombreCentroDonacion.Text = "Centro cuenta de donación de activos"
        Me.lblNombreCentroDonacion.UseMnemonic = False
        '
        'lblCentroDonacion
        '
        Me.lblCentroDonacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroDonacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroDonacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroDonacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroDonacion.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroDonacion.Name = "lblCentroDonacion"
        Me.lblCentroDonacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroDonacion.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroDonacion.TabIndex = 18
        Me.lblCentroDonacion.Text = "Centro"
        '
        'lblCuentaDonacion
        '
        Me.lblCuentaDonacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaDonacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaDonacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaDonacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaDonacion.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaDonacion.Name = "lblCuentaDonacion"
        Me.lblCuentaDonacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaDonacion.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaDonacion.TabIndex = 17
        Me.lblCuentaDonacion.Text = "Cuenta"
        '
        'grpVentas
        '
        Me.grpVentas.BackColor = System.Drawing.SystemColors.Control
        Me.grpVentas.Controls.Add(Me.txtCentroVentas)
        Me.grpVentas.Controls.Add(Me.txtCuentaVentas)
        Me.grpVentas.Controls.Add(Me.lblCuentaVentas)
        Me.grpVentas.Controls.Add(Me.lblCentroVentas)
        Me.grpVentas.Controls.Add(Me.lblNombreCentroVentas)
        Me.grpVentas.Controls.Add(Me.lblNombreCuentaVentas)
        Me.grpVentas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVentas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpVentas.Location = New System.Drawing.Point(6, 6)
        Me.grpVentas.Name = "grpVentas"
        Me.grpVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpVentas.Size = New System.Drawing.Size(647, 73)
        Me.grpVentas.TabIndex = 0
        Me.grpVentas.TabStop = False
        Me.grpVentas.Text = "Cuenta de ventas activos "
        '
        'txtCentroVentas
        '
        Me.txtCentroVentas.AcceptsReturn = True
        Me.txtCentroVentas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroVentas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroVentas.Enabled = False
        Me.txtCentroVentas.EsRequerido = False
        Me.txtCentroVentas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroVentas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroVentas.LabelConsulta = Nothing
        Me.txtCentroVentas.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroVentas.MaxLength = 15
        Me.txtCentroVentas.Name = "txtCentroVentas"
        Me.txtCentroVentas.NombreDeConsulta = Nothing
        Me.txtCentroVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroVentas.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroVentas.TabIndex = 0
        '
        'txtCuentaVentas
        '
        Me.txtCuentaVentas.AcceptsReturn = True
        Me.txtCuentaVentas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaVentas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaVentas.Enabled = False
        Me.txtCuentaVentas.EsRequerido = False
        Me.txtCuentaVentas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaVentas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaVentas.LabelConsulta = Nothing
        Me.txtCuentaVentas.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaVentas.MaxLength = 30
        Me.txtCuentaVentas.Name = "txtCuentaVentas"
        Me.txtCuentaVentas.NombreDeConsulta = Nothing
        Me.txtCuentaVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaVentas.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaVentas.TabIndex = 1
        Me.txtCuentaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCuentaVentas
        '
        Me.lblCuentaVentas.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaVentas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaVentas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaVentas.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaVentas.Name = "lblCuentaVentas"
        Me.lblCuentaVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaVentas.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaVentas.TabIndex = 13
        Me.lblCuentaVentas.Text = "Cuenta"
        '
        'lblCentroVentas
        '
        Me.lblCentroVentas.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroVentas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroVentas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroVentas.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroVentas.Name = "lblCentroVentas"
        Me.lblCentroVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroVentas.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroVentas.TabIndex = 12
        Me.lblCentroVentas.Text = "Centro"
        '
        'lblNombreCentroVentas
        '
        Me.lblNombreCentroVentas.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroVentas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroVentas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroVentas.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroVentas.Name = "lblNombreCentroVentas"
        Me.lblNombreCentroVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroVentas.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroVentas.TabIndex = 11
        Me.lblNombreCentroVentas.Text = "lblNombreCentroVentas"
        Me.lblNombreCentroVentas.UseMnemonic = False
        '
        'lblNombreCuentaVentas
        '
        Me.lblNombreCuentaVentas.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaVentas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaVentas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaVentas.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaVentas.Name = "lblNombreCuentaVentas"
        Me.lblNombreCuentaVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaVentas.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaVentas.TabIndex = 10
        Me.lblNombreCuentaVentas.Text = "lblNombreCuentaVentas"
        Me.lblNombreCuentaVentas.UseMnemonic = False
        '
        'grpGastosNoDeducible
        '
        Me.grpGastosNoDeducible.BackColor = System.Drawing.SystemColors.Control
        Me.grpGastosNoDeducible.Controls.Add(Me.txtCentroGastoNoDeducible)
        Me.grpGastosNoDeducible.Controls.Add(Me.txtCuentaGastoNoDeducible)
        Me.grpGastosNoDeducible.Controls.Add(Me.lblCuentaGastosNoDeducible)
        Me.grpGastosNoDeducible.Controls.Add(Me.lblCentroGastosNoDeducible)
        Me.grpGastosNoDeducible.Controls.Add(Me.lblNombreCentroGastoNoDeducible)
        Me.grpGastosNoDeducible.Controls.Add(Me.lblNombreCuentaGastoNoDeducible)
        Me.grpGastosNoDeducible.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGastosNoDeducible.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpGastosNoDeducible.Location = New System.Drawing.Point(6, 164)
        Me.grpGastosNoDeducible.Name = "grpGastosNoDeducible"
        Me.grpGastosNoDeducible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpGastosNoDeducible.Size = New System.Drawing.Size(647, 73)
        Me.grpGastosNoDeducible.TabIndex = 2
        Me.grpGastosNoDeducible.TabStop = False
        Me.grpGastosNoDeducible.Text = "Cuenta de gastos no deducible"
        '
        'txtCentroGastoNoDeducible
        '
        Me.txtCentroGastoNoDeducible.AcceptsReturn = True
        Me.txtCentroGastoNoDeducible.BackColor = System.Drawing.SystemColors.Window
        Me.txtCentroGastoNoDeducible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroGastoNoDeducible.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCentroGastoNoDeducible.Enabled = False
        Me.txtCentroGastoNoDeducible.EsRequerido = False
        Me.txtCentroGastoNoDeducible.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroGastoNoDeducible.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCentroGastoNoDeducible.LabelConsulta = Nothing
        Me.txtCentroGastoNoDeducible.Location = New System.Drawing.Point(156, 19)
        Me.txtCentroGastoNoDeducible.MaxLength = 15
        Me.txtCentroGastoNoDeducible.Name = "txtCentroGastoNoDeducible"
        Me.txtCentroGastoNoDeducible.NombreDeConsulta = Nothing
        Me.txtCentroGastoNoDeducible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCentroGastoNoDeducible.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroGastoNoDeducible.TabIndex = 4
        Me.txtCentroGastoNoDeducible.Visible = False
        '
        'txtCuentaGastoNoDeducible
        '
        Me.txtCuentaGastoNoDeducible.AcceptsReturn = True
        Me.txtCuentaGastoNoDeducible.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaGastoNoDeducible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaGastoNoDeducible.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuentaGastoNoDeducible.Enabled = False
        Me.txtCuentaGastoNoDeducible.EsRequerido = False
        Me.txtCuentaGastoNoDeducible.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaGastoNoDeducible.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaGastoNoDeducible.LabelConsulta = Nothing
        Me.txtCuentaGastoNoDeducible.Location = New System.Drawing.Point(156, 45)
        Me.txtCuentaGastoNoDeducible.MaxLength = 30
        Me.txtCuentaGastoNoDeducible.Name = "txtCuentaGastoNoDeducible"
        Me.txtCuentaGastoNoDeducible.NombreDeConsulta = Nothing
        Me.txtCuentaGastoNoDeducible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaGastoNoDeducible.Size = New System.Drawing.Size(237, 20)
        Me.txtCuentaGastoNoDeducible.TabIndex = 5
        Me.txtCuentaGastoNoDeducible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCuentaGastosNoDeducible
        '
        Me.lblCuentaGastosNoDeducible.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaGastosNoDeducible.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaGastosNoDeducible.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaGastosNoDeducible.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaGastosNoDeducible.Location = New System.Drawing.Point(6, 47)
        Me.lblCuentaGastosNoDeducible.Name = "lblCuentaGastosNoDeducible"
        Me.lblCuentaGastosNoDeducible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaGastosNoDeducible.Size = New System.Drawing.Size(144, 14)
        Me.lblCuentaGastosNoDeducible.TabIndex = 6
        Me.lblCuentaGastosNoDeducible.Text = "Cuenta"
        '
        'lblCentroGastosNoDeducible
        '
        Me.lblCentroGastosNoDeducible.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroGastosNoDeducible.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCentroGastosNoDeducible.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroGastosNoDeducible.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCentroGastosNoDeducible.Location = New System.Drawing.Point(6, 21)
        Me.lblCentroGastosNoDeducible.Name = "lblCentroGastosNoDeducible"
        Me.lblCentroGastosNoDeducible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCentroGastosNoDeducible.Size = New System.Drawing.Size(144, 14)
        Me.lblCentroGastosNoDeducible.TabIndex = 5
        Me.lblCentroGastosNoDeducible.Text = "Centro"
        Me.lblCentroGastosNoDeducible.Visible = False
        '
        'lblNombreCentroGastoNoDeducible
        '
        Me.lblNombreCentroGastoNoDeducible.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentroGastoNoDeducible.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentroGastoNoDeducible.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentroGastoNoDeducible.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentroGastoNoDeducible.Location = New System.Drawing.Point(399, 21)
        Me.lblNombreCentroGastoNoDeducible.Name = "lblNombreCentroGastoNoDeducible"
        Me.lblNombreCentroGastoNoDeducible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentroGastoNoDeducible.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCentroGastoNoDeducible.TabIndex = 4
        Me.lblNombreCentroGastoNoDeducible.Text = "Centro cta.gastos no deducible"
        Me.lblNombreCentroGastoNoDeducible.UseMnemonic = False
        Me.lblNombreCentroGastoNoDeducible.Visible = False
        '
        'lblNombreCuentaGastoNoDeducible
        '
        Me.lblNombreCuentaGastoNoDeducible.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaGastoNoDeducible.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaGastoNoDeducible.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaGastoNoDeducible.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaGastoNoDeducible.Location = New System.Drawing.Point(399, 47)
        Me.lblNombreCuentaGastoNoDeducible.Name = "lblNombreCuentaGastoNoDeducible"
        Me.lblNombreCuentaGastoNoDeducible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaGastoNoDeducible.Size = New System.Drawing.Size(242, 20)
        Me.lblNombreCuentaGastoNoDeducible.TabIndex = 3
        Me.lblNombreCuentaGastoNoDeducible.Text = "Cuenta gastos no deducible"
        Me.lblNombreCuentaGastoNoDeducible.UseMnemonic = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(592, 328)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTTACM1
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(691, 365)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.mhTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTTACM1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de tipos de activos fijos - ACTTACM1"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mhTab1.ResumeLayout(False)
        Me.tbpGenerales.ResumeLayout(False)
        Me.tbpGenerales.PerformLayout()
        Me.tbpBalance.ResumeLayout(False)
        Me.grpReevaluacion.ResumeLayout(False)
        Me.grpReevaluacion.PerformLayout()
        Me.grpGastos.ResumeLayout(False)
        Me.grpGastos.PerformLayout()
        Me.grpBalance.ResumeLayout(False)
        Me.grpBalance.PerformLayout()
        Me.tbpIngresoEgreso.ResumeLayout(False)
        Me.grpDesecho.ResumeLayout(False)
        Me.grpDesecho.PerformLayout()
        Me.grpIngresosEgresos.ResumeLayout(False)
        Me.grpIngresosEgresos.PerformLayout()
        Me.grpCompras.ResumeLayout(False)
        Me.grpCompras.PerformLayout()
        Me.tbpDonacion.ResumeLayout(False)
        Me.grpDonacion.ResumeLayout(False)
        Me.grpDonacion.PerformLayout()
        Me.grpVentas.ResumeLayout(False)
        Me.grpVentas.PerformLayout()
        Me.grpGastosNoDeducible.ResumeLayout(False)
        Me.grpGastosNoDeducible.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mhTab1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpGenerales As System.Windows.Forms.TabPage
    Public WithEvents cboClaseContabilizacion As System.Windows.Forms.ComboBox
    Public WithEvents cboCalculaPrimeraDepreciacion As System.Windows.Forms.ComboBox
    Public WithEvents cboDiasCalculoDepreciacion As System.Windows.Forms.ComboBox
    Public WithEvents cboFormaDepreciacion As System.Windows.Forms.ComboBox
    Public WithEvents cboTipoDepreciacion As System.Windows.Forms.ComboBox
    Public WithEvents txtCodigoTipoActivo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTipoActivoDescripcion As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDiaLimite As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtMontoMinimo As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTiempoDepreciacion As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTipoCatalogo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCalculaPrimeraDepreciacion As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoCatalogo As System.Windows.Forms.Label
    Public WithEvents lblClaseContabilizacion As System.Windows.Forms.Label
    Public WithEvents lblCodigoTipoActivo As System.Windows.Forms.Label
    Public WithEvents lblTipoActivoDescripcion As System.Windows.Forms.Label
    Public WithEvents lblTipoDepreciacion As System.Windows.Forms.Label
    Public WithEvents lblDiaLimite As System.Windows.Forms.Label
    Public WithEvents lblMontoMinimo As System.Windows.Forms.Label
    Public WithEvents lblTiempoDepreciacion As System.Windows.Forms.Label
    Public WithEvents lblTipoCatalogo As System.Windows.Forms.Label
    Public WithEvents lblFormaDepreciacion As System.Windows.Forms.Label
    Public WithEvents lblDiasCalculoDepreciacion As System.Windows.Forms.Label
    Friend WithEvents tbpBalance As System.Windows.Forms.TabPage
    Public WithEvents grpReevaluacion As System.Windows.Forms.GroupBox
    Public WithEvents txtCuentaReevaluacion As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCentroReevaluacion As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaReevaluacion As System.Windows.Forms.Label
    Public WithEvents lblCentroReevaluacion As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroReevaluacion As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaReevaluacion As System.Windows.Forms.Label
    Public WithEvents grpGastos As System.Windows.Forms.GroupBox
    Public WithEvents txtCuentaGastos As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCentroGastos As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaGastos As System.Windows.Forms.Label
    Public WithEvents lblCentroGastos As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroGastos As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaGastos As System.Windows.Forms.Label
    Public WithEvents grpBalance As System.Windows.Forms.GroupBox
    Public WithEvents txtCuentaDepreciacion As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCuentaActivo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCentroBalance As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaDepreciacion As System.Windows.Forms.Label
    Public WithEvents lblCuentaActivo As System.Windows.Forms.Label
    Public WithEvents lblCentroBalance As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroBalance As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaActivo As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaDepreciacion As System.Windows.Forms.Label
    Friend WithEvents tbpIngresoEgreso As System.Windows.Forms.TabPage
    Public WithEvents grpDesecho As System.Windows.Forms.GroupBox
    Public WithEvents txtCuentaDesecho As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCentroDesecho As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaDesecho As System.Windows.Forms.Label
    Public WithEvents lblCentroDesecho As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroDesecho As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaDesecho As System.Windows.Forms.Label
    Public WithEvents grpIngresosEgresos As System.Windows.Forms.GroupBox
    Public WithEvents txtCuentaPerdida As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCuentaGanancia As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCentroIngresosEgresos As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaPerdida As System.Windows.Forms.Label
    Public WithEvents lblCuentaGanancia As System.Windows.Forms.Label
    Public WithEvents lblCentroIngresosEgresos As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroIngresosEgresos As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaGanancia As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaPerdida As System.Windows.Forms.Label
    Public WithEvents grpCompras As System.Windows.Forms.GroupBox
    Public WithEvents txtCuentaCompras As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCentroCompras As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaCompras As System.Windows.Forms.Label
    Public WithEvents lblCentroCompras As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroCompras As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaCompras As System.Windows.Forms.Label
    Friend WithEvents tbpDonacion As System.Windows.Forms.TabPage
    Public WithEvents grpDonacion As System.Windows.Forms.GroupBox
    Public WithEvents txtCuentaDonacion As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCentroDonacion As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblNombreCuentaDonacion As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroDonacion As System.Windows.Forms.Label
    Public WithEvents lblCentroDonacion As System.Windows.Forms.Label
    Public WithEvents lblCuentaDonacion As System.Windows.Forms.Label
    Public WithEvents grpVentas As System.Windows.Forms.GroupBox
    Public WithEvents txtCentroVentas As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCuentaVentas As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaVentas As System.Windows.Forms.Label
    Public WithEvents lblCentroVentas As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroVentas As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaVentas As System.Windows.Forms.Label
    Public WithEvents grpGastosNoDeducible As System.Windows.Forms.GroupBox
    Public WithEvents txtCentroGastoNoDeducible As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCuentaGastoNoDeducible As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblCuentaGastosNoDeducible As System.Windows.Forms.Label
    Public WithEvents lblCentroGastosNoDeducible As System.Windows.Forms.Label
    Public WithEvents lblNombreCentroGastoNoDeducible As System.Windows.Forms.Label
    Public WithEvents lblNombreCuentaGastoNoDeducible As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
