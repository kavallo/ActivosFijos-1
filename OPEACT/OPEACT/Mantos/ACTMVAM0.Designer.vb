<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAM0
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
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtOBSERVACIONES1 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES2 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES3 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkGeneraPartida = New System.Windows.Forms.CheckBox()
        Me.txtCODIGO_DE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMEJORA_CORRELATIVO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTIPO_MOVIMIENTO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.mskfecha = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtTASA_CAMBIO_MOV = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtMONTO_DE_MOVIMIENTO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCORRELATIVO_MOVIM = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblTitTASA_CAMBIO_MOV = New System.Windows.Forms.Label()
        Me.lblTitMONTO_DE_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitFECHA_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitCORRELATIVO_MOVIM = New System.Windows.Forms.Label()
        Me.lblTitTIPO_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblnombreactivo = New System.Windows.Forms.Label()
        Me.lblnombretipo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtOBSERVACIONES1)
        Me.Frame2.Controls.Add(Me.txtOBSERVACIONES2)
        Me.Frame2.Controls.Add(Me.txtOBSERVACIONES3)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(12, 223)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(640, 87)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Observaciones"
        '
        'txtOBSERVACIONES1
        '
        Me.txtOBSERVACIONES1.AcceptsReturn = True
        Me.txtOBSERVACIONES1.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES1.EsRequerido = False
        Me.txtOBSERVACIONES1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES1.LabelConsulta = Nothing
        Me.txtOBSERVACIONES1.Location = New System.Drawing.Point(6, 19)
        Me.txtOBSERVACIONES1.MaxLength = 60
        Me.txtOBSERVACIONES1.Name = "txtOBSERVACIONES1"
        Me.txtOBSERVACIONES1.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES1.Size = New System.Drawing.Size(628, 20)
        Me.txtOBSERVACIONES1.TabIndex = 1
        '
        'txtOBSERVACIONES2
        '
        Me.txtOBSERVACIONES2.AcceptsReturn = True
        Me.txtOBSERVACIONES2.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES2.EsRequerido = False
        Me.txtOBSERVACIONES2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES2.LabelConsulta = Nothing
        Me.txtOBSERVACIONES2.Location = New System.Drawing.Point(6, 39)
        Me.txtOBSERVACIONES2.MaxLength = 60
        Me.txtOBSERVACIONES2.Name = "txtOBSERVACIONES2"
        Me.txtOBSERVACIONES2.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES2.Size = New System.Drawing.Size(628, 20)
        Me.txtOBSERVACIONES2.TabIndex = 2
        '
        'txtOBSERVACIONES3
        '
        Me.txtOBSERVACIONES3.AcceptsReturn = True
        Me.txtOBSERVACIONES3.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES3.EsRequerido = False
        Me.txtOBSERVACIONES3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES3.LabelConsulta = Nothing
        Me.txtOBSERVACIONES3.Location = New System.Drawing.Point(6, 59)
        Me.txtOBSERVACIONES3.MaxLength = 60
        Me.txtOBSERVACIONES3.Name = "txtOBSERVACIONES3"
        Me.txtOBSERVACIONES3.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES3.Size = New System.Drawing.Size(628, 20)
        Me.txtOBSERVACIONES3.TabIndex = 3
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkGeneraPartida)
        Me.Frame1.Controls.Add(Me.txtCODIGO_DE_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtMEJORA_CORRELATIVO)
        Me.Frame1.Controls.Add(Me.txtTIPO_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.mskfecha)
        Me.Frame1.Controls.Add(Me.txtTASA_CAMBIO_MOV)
        Me.Frame1.Controls.Add(Me.txtMONTO_DE_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.txtCORRELATIVO_MOVIM)
        Me.Frame1.Controls.Add(Me.lblTitTASA_CAMBIO_MOV)
        Me.Frame1.Controls.Add(Me.lblTitMONTO_DE_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.lblTitFECHA_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.lblTitCORRELATIVO_MOVIM)
        Me.Frame1.Controls.Add(Me.lblTitTIPO_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblnombreactivo)
        Me.Frame1.Controls.Add(Me.lblnombretipo)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(640, 205)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'chkGeneraPartida
        '
        Me.chkGeneraPartida.BackColor = System.Drawing.SystemColors.Control
        Me.chkGeneraPartida.Checked = True
        Me.chkGeneraPartida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGeneraPartida.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGeneraPartida.Enabled = False
        Me.chkGeneraPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGeneraPartida.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkGeneraPartida.Location = New System.Drawing.Point(233, 98)
        Me.chkGeneraPartida.Name = "chkGeneraPartida"
        Me.chkGeneraPartida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGeneraPartida.Size = New System.Drawing.Size(314, 18)
        Me.chkGeneraPartida.TabIndex = 5
        Me.chkGeneraPartida.Text = "Movimiento genera partida"
        Me.chkGeneraPartida.UseVisualStyleBackColor = False
        '
        'txtCODIGO_DE_ACTIVO
        '
        Me.txtCODIGO_DE_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_DE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_ACTIVO.EsRequerido = True
        Me.txtCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(159, 19)
        Me.txtCODIGO_DE_ACTIVO.MaxLength = 15
        Me.txtCODIGO_DE_ACTIVO.Name = "txtCODIGO_DE_ACTIVO"
        Me.txtCODIGO_DE_ACTIVO.NombreDeConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(125, 20)
        Me.txtCODIGO_DE_ACTIVO.TabIndex = 1
        '
        'txtMEJORA_CORRELATIVO
        '
        Me.txtMEJORA_CORRELATIVO.AcceptsReturn = True
        Me.txtMEJORA_CORRELATIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtMEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMEJORA_CORRELATIVO.EsRequerido = True
        Me.txtMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMEJORA_CORRELATIVO.LabelConsulta = Nothing
        Me.txtMEJORA_CORRELATIVO.Location = New System.Drawing.Point(159, 45)
        Me.txtMEJORA_CORRELATIVO.MaxLength = 10
        Me.txtMEJORA_CORRELATIVO.Multiline = True
        Me.txtMEJORA_CORRELATIVO.Name = "txtMEJORA_CORRELATIVO"
        Me.txtMEJORA_CORRELATIVO.NombreDeConsulta = Nothing
        Me.txtMEJORA_CORRELATIVO.NumeroDecimales = 0
        Me.txtMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMEJORA_CORRELATIVO.Size = New System.Drawing.Size(45, 20)
        Me.txtMEJORA_CORRELATIVO.TabIndex = 2
        Me.txtMEJORA_CORRELATIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTIPO_MOVIMIENTO
        '
        Me.txtTIPO_MOVIMIENTO.AcceptsReturn = True
        Me.txtTIPO_MOVIMIENTO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIPO_MOVIMIENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIPO_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIPO_MOVIMIENTO.EsRequerido = True
        Me.txtTIPO_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_MOVIMIENTO.LabelConsulta = Nothing
        Me.txtTIPO_MOVIMIENTO.Location = New System.Drawing.Point(159, 71)
        Me.txtTIPO_MOVIMIENTO.MaxLength = 1
        Me.txtTIPO_MOVIMIENTO.Multiline = True
        Me.txtTIPO_MOVIMIENTO.Name = "txtTIPO_MOVIMIENTO"
        Me.txtTIPO_MOVIMIENTO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeMovimientosDeActivos_ACTTMAL0
        Me.txtTIPO_MOVIMIENTO.NumeroDecimales = 0
        Me.txtTIPO_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_MOVIMIENTO.Size = New System.Drawing.Size(45, 20)
        Me.txtTIPO_MOVIMIENTO.TabIndex = 3
        Me.txtTIPO_MOVIMIENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskfecha
        '
        Me.mskfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskfecha.EsRequerido = True
        Me.mskfecha.Location = New System.Drawing.Point(159, 123)
        Me.mskfecha.Mask = "00/00/0000"
        Me.mskfecha.Name = "mskfecha"
        Me.mskfecha.Size = New System.Drawing.Size(130, 20)
        Me.mskfecha.TabIndex = 6
        Me.mskfecha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskfecha.ValidatingType = GetType(Date)
        '
        'txtTASA_CAMBIO_MOV
        '
        Me.txtTASA_CAMBIO_MOV.AcceptsReturn = True
        Me.txtTASA_CAMBIO_MOV.BackColor = System.Drawing.SystemColors.Window
        Me.txtTASA_CAMBIO_MOV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTASA_CAMBIO_MOV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTASA_CAMBIO_MOV.Enabled = False
        Me.txtTASA_CAMBIO_MOV.EsRequerido = False
        Me.txtTASA_CAMBIO_MOV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTASA_CAMBIO_MOV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTASA_CAMBIO_MOV.LabelConsulta = Nothing
        Me.txtTASA_CAMBIO_MOV.Location = New System.Drawing.Point(159, 175)
        Me.txtTASA_CAMBIO_MOV.MaxLength = 13
        Me.txtTASA_CAMBIO_MOV.Multiline = True
        Me.txtTASA_CAMBIO_MOV.Name = "txtTASA_CAMBIO_MOV"
        Me.txtTASA_CAMBIO_MOV.NombreDeConsulta = Nothing
        Me.txtTASA_CAMBIO_MOV.NumeroDecimales = 5
        Me.txtTASA_CAMBIO_MOV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTASA_CAMBIO_MOV.Size = New System.Drawing.Size(86, 20)
        Me.txtTASA_CAMBIO_MOV.TabIndex = 8
        Me.txtTASA_CAMBIO_MOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMONTO_DE_MOVIMIENTO
        '
        Me.txtMONTO_DE_MOVIMIENTO.AcceptsReturn = True
        Me.txtMONTO_DE_MOVIMIENTO.BackColor = System.Drawing.SystemColors.Window
        Me.txtMONTO_DE_MOVIMIENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMONTO_DE_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMONTO_DE_MOVIMIENTO.EsRequerido = False
        Me.txtMONTO_DE_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTO_DE_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMONTO_DE_MOVIMIENTO.LabelConsulta = Nothing
        Me.txtMONTO_DE_MOVIMIENTO.Location = New System.Drawing.Point(159, 149)
        Me.txtMONTO_DE_MOVIMIENTO.MaxLength = 13
        Me.txtMONTO_DE_MOVIMIENTO.Multiline = True
        Me.txtMONTO_DE_MOVIMIENTO.Name = "txtMONTO_DE_MOVIMIENTO"
        Me.txtMONTO_DE_MOVIMIENTO.NombreDeConsulta = Nothing
        Me.txtMONTO_DE_MOVIMIENTO.NumeroDecimales = 2
        Me.txtMONTO_DE_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMONTO_DE_MOVIMIENTO.Size = New System.Drawing.Size(86, 20)
        Me.txtMONTO_DE_MOVIMIENTO.TabIndex = 7
        Me.txtMONTO_DE_MOVIMIENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCORRELATIVO_MOVIM
        '
        Me.txtCORRELATIVO_MOVIM.AcceptsReturn = True
        Me.txtCORRELATIVO_MOVIM.BackColor = System.Drawing.SystemColors.Window
        Me.txtCORRELATIVO_MOVIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCORRELATIVO_MOVIM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCORRELATIVO_MOVIM.EsRequerido = False
        Me.txtCORRELATIVO_MOVIM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCORRELATIVO_MOVIM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCORRELATIVO_MOVIM.LabelConsulta = Nothing
        Me.txtCORRELATIVO_MOVIM.Location = New System.Drawing.Point(159, 97)
        Me.txtCORRELATIVO_MOVIM.MaxLength = 10
        Me.txtCORRELATIVO_MOVIM.Multiline = True
        Me.txtCORRELATIVO_MOVIM.Name = "txtCORRELATIVO_MOVIM"
        Me.txtCORRELATIVO_MOVIM.NombreDeConsulta = Nothing
        Me.txtCORRELATIVO_MOVIM.NumeroDecimales = 0
        Me.txtCORRELATIVO_MOVIM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCORRELATIVO_MOVIM.Size = New System.Drawing.Size(45, 20)
        Me.txtCORRELATIVO_MOVIM.TabIndex = 4
        Me.txtCORRELATIVO_MOVIM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitTASA_CAMBIO_MOV
        '
        Me.lblTitTASA_CAMBIO_MOV.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_CAMBIO_MOV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_CAMBIO_MOV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_CAMBIO_MOV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_CAMBIO_MOV.Location = New System.Drawing.Point(6, 177)
        Me.lblTitTASA_CAMBIO_MOV.Name = "lblTitTASA_CAMBIO_MOV"
        Me.lblTitTASA_CAMBIO_MOV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_CAMBIO_MOV.Size = New System.Drawing.Size(147, 14)
        Me.lblTitTASA_CAMBIO_MOV.TabIndex = 9
        Me.lblTitTASA_CAMBIO_MOV.Text = "Tasa de cambio"
        '
        'lblTitMONTO_DE_MOVIMIENTO
        '
        Me.lblTitMONTO_DE_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_DE_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_DE_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_DE_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_DE_MOVIMIENTO.Location = New System.Drawing.Point(6, 151)
        Me.lblTitMONTO_DE_MOVIMIENTO.Name = "lblTitMONTO_DE_MOVIMIENTO"
        Me.lblTitMONTO_DE_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_DE_MOVIMIENTO.Size = New System.Drawing.Size(147, 14)
        Me.lblTitMONTO_DE_MOVIMIENTO.TabIndex = 10
        Me.lblTitMONTO_DE_MOVIMIENTO.Text = "Monto del movimiento"
        '
        'lblTitFECHA_MOVIMIENTO
        '
        Me.lblTitFECHA_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_MOVIMIENTO.Location = New System.Drawing.Point(6, 125)
        Me.lblTitFECHA_MOVIMIENTO.Name = "lblTitFECHA_MOVIMIENTO"
        Me.lblTitFECHA_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_MOVIMIENTO.Size = New System.Drawing.Size(147, 14)
        Me.lblTitFECHA_MOVIMIENTO.TabIndex = 11
        Me.lblTitFECHA_MOVIMIENTO.Text = "Fecha del movimiento"
        '
        'lblTitCORRELATIVO_MOVIM
        '
        Me.lblTitCORRELATIVO_MOVIM.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCORRELATIVO_MOVIM.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCORRELATIVO_MOVIM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCORRELATIVO_MOVIM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCORRELATIVO_MOVIM.Location = New System.Drawing.Point(6, 99)
        Me.lblTitCORRELATIVO_MOVIM.Name = "lblTitCORRELATIVO_MOVIM"
        Me.lblTitCORRELATIVO_MOVIM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCORRELATIVO_MOVIM.Size = New System.Drawing.Size(147, 14)
        Me.lblTitCORRELATIVO_MOVIM.TabIndex = 12
        Me.lblTitCORRELATIVO_MOVIM.Text = "Correlativo movimiento"
        '
        'lblTitTIPO_MOVIMIENTO
        '
        Me.lblTitTIPO_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_MOVIMIENTO.Location = New System.Drawing.Point(6, 73)
        Me.lblTitTIPO_MOVIMIENTO.Name = "lblTitTIPO_MOVIMIENTO"
        Me.lblTitTIPO_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_MOVIMIENTO.Size = New System.Drawing.Size(147, 14)
        Me.lblTitTIPO_MOVIMIENTO.TabIndex = 13
        Me.lblTitTIPO_MOVIMIENTO.Text = "Tipo de movimiento"
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(147, 14)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 14
        Me.lblTitMEJORA_CORRELATIVO.Text = "Mejora correlativo"
        '
        'lblTitCODIGO_DE_ACTIVO
        '
        Me.lblTitCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCODIGO_DE_ACTIVO.Name = "lblTitCODIGO_DE_ACTIVO"
        Me.lblTitCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(147, 14)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 15
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Código activo"
        '
        'lblnombreactivo
        '
        Me.lblnombreactivo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreactivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreactivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreactivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreactivo.Location = New System.Drawing.Point(298, 21)
        Me.lblnombreactivo.Name = "lblnombreactivo"
        Me.lblnombreactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreactivo.Size = New System.Drawing.Size(336, 20)
        Me.lblnombreactivo.TabIndex = 16
        Me.lblnombreactivo.UseMnemonic = False
        '
        'lblnombretipo
        '
        Me.lblnombretipo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombretipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombretipo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombretipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombretipo.Location = New System.Drawing.Point(230, 73)
        Me.lblnombretipo.Name = "lblnombretipo"
        Me.lblnombretipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombretipo.Size = New System.Drawing.Size(404, 20)
        Me.lblnombretipo.TabIndex = 17
        Me.lblnombretipo.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(295, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "[DD/MM/AAAA]"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(472, 316)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Tag = "0205100"
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(565, 316)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'ACTMVAM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(664, 353)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMVAM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento a movimientos de activos - ACTMVAM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtOBSERVACIONES1 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES2 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES3 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtTASA_CAMBIO_MOV As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtMONTO_DE_MOVIMIENTO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCORRELATIVO_MOVIM As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTIPO_MOVIMIENTO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtMEJORA_CORRELATIVO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtCODIGO_DE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents mskfecha As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblTitTASA_CAMBIO_MOV As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_DE_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitCORRELATIVO_MOVIM As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblnombreactivo As System.Windows.Forms.Label
    Public WithEvents lblnombretipo As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents chkGeneraPartida As System.Windows.Forms.CheckBox
End Class
