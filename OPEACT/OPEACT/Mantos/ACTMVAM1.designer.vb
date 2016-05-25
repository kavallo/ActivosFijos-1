<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAM1
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
        Me.txtOBSERVACIONES1 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES2 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES3 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtVALOR_NO_DEDUCIBLE = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtperiodos = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtclasemov = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtestado = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.mskfechamov = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.mskfechaact = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtCODIGO_DE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMEJORA_CORRELATIVO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTIPO_MOVIMIENTO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCORRELATIVO_MOVIM = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtANO_PERIODO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtNO_PERIODO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtMONTO_DE_MOVIMIENTO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTASA_CAMBIO_MOV = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtUSUARIO_MOV_ACT = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtPORCENTAJE_DEPREC = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.lblOBSERVACIONES = New System.Windows.Forms.Label()
        Me.lblTitVALOR_NO_DEDUCIBLE = New System.Windows.Forms.Label()
        Me.lblperiodos = New System.Windows.Forms.Label()
        Me.lblnombreestado = New System.Windows.Forms.Label()
        Me.lblnombreclase = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnombretipo = New System.Windows.Forms.Label()
        Me.lblnombreactivo = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblTitTIPO_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitCORRELATIVO_MOVIM = New System.Windows.Forms.Label()
        Me.lblTitANO_PERIODO = New System.Windows.Forms.Label()
        Me.lblTitNO_PERIODO = New System.Windows.Forms.Label()
        Me.lblTitFECHA_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitMONTO_DE_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitTASA_CAMBIO_MOV = New System.Windows.Forms.Label()
        Me.lblTitUSUARIO_MOV_ACT = New System.Windows.Forms.Label()
        Me.lblTitFECHA_DPA_MOV_ACT = New System.Windows.Forms.Label()
        Me.lblTitESTADO_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitPORCENTAJE_DEPREC = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOBSERVACIONES1
        '
        Me.txtOBSERVACIONES1.AcceptsReturn = True
        Me.txtOBSERVACIONES1.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES1.Enabled = False
        Me.txtOBSERVACIONES1.EsRequerido = False
        Me.txtOBSERVACIONES1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES1.LabelConsulta = Nothing
        Me.txtOBSERVACIONES1.Location = New System.Drawing.Point(36, 334)
        Me.txtOBSERVACIONES1.MaxLength = 60
        Me.txtOBSERVACIONES1.Name = "txtOBSERVACIONES1"
        Me.txtOBSERVACIONES1.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES1.Size = New System.Drawing.Size(552, 20)
        Me.txtOBSERVACIONES1.TabIndex = 17
        '
        'txtOBSERVACIONES2
        '
        Me.txtOBSERVACIONES2.AcceptsReturn = True
        Me.txtOBSERVACIONES2.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES2.Enabled = False
        Me.txtOBSERVACIONES2.EsRequerido = False
        Me.txtOBSERVACIONES2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES2.LabelConsulta = Nothing
        Me.txtOBSERVACIONES2.Location = New System.Drawing.Point(36, 354)
        Me.txtOBSERVACIONES2.MaxLength = 60
        Me.txtOBSERVACIONES2.Name = "txtOBSERVACIONES2"
        Me.txtOBSERVACIONES2.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES2.Size = New System.Drawing.Size(552, 20)
        Me.txtOBSERVACIONES2.TabIndex = 18
        '
        'txtOBSERVACIONES3
        '
        Me.txtOBSERVACIONES3.AcceptsReturn = True
        Me.txtOBSERVACIONES3.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES3.Enabled = False
        Me.txtOBSERVACIONES3.EsRequerido = False
        Me.txtOBSERVACIONES3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES3.LabelConsulta = Nothing
        Me.txtOBSERVACIONES3.Location = New System.Drawing.Point(36, 374)
        Me.txtOBSERVACIONES3.MaxLength = 60
        Me.txtOBSERVACIONES3.Name = "txtOBSERVACIONES3"
        Me.txtOBSERVACIONES3.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES3.Size = New System.Drawing.Size(552, 20)
        Me.txtOBSERVACIONES3.TabIndex = 19
        '
        'txtVALOR_NO_DEDUCIBLE
        '
        Me.txtVALOR_NO_DEDUCIBLE.AcceptsReturn = True
        Me.txtVALOR_NO_DEDUCIBLE.BackColor = System.Drawing.SystemColors.Window
        Me.txtVALOR_NO_DEDUCIBLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_NO_DEDUCIBLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVALOR_NO_DEDUCIBLE.Enabled = False
        Me.txtVALOR_NO_DEDUCIBLE.EsRequerido = False
        Me.txtVALOR_NO_DEDUCIBLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVALOR_NO_DEDUCIBLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVALOR_NO_DEDUCIBLE.LabelConsulta = Nothing
        Me.txtVALOR_NO_DEDUCIBLE.Location = New System.Drawing.Point(183, 143)
        Me.txtVALOR_NO_DEDUCIBLE.MaxLength = 13
        Me.txtVALOR_NO_DEDUCIBLE.Multiline = True
        Me.txtVALOR_NO_DEDUCIBLE.Name = "txtVALOR_NO_DEDUCIBLE"
        Me.txtVALOR_NO_DEDUCIBLE.NombreDeConsulta = Nothing
        Me.txtVALOR_NO_DEDUCIBLE.NumeroDecimales = 2
        Me.txtVALOR_NO_DEDUCIBLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVALOR_NO_DEDUCIBLE.Size = New System.Drawing.Size(90, 20)
        Me.txtVALOR_NO_DEDUCIBLE.TabIndex = 6
        Me.txtVALOR_NO_DEDUCIBLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtperiodos
        '
        Me.txtperiodos.AcceptsReturn = True
        Me.txtperiodos.BackColor = System.Drawing.SystemColors.Window
        Me.txtperiodos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtperiodos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtperiodos.Enabled = False
        Me.txtperiodos.EsRequerido = False
        Me.txtperiodos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperiodos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtperiodos.LabelConsulta = Nothing
        Me.txtperiodos.Location = New System.Drawing.Point(483, 221)
        Me.txtperiodos.MaxLength = 10
        Me.txtperiodos.Name = "txtperiodos"
        Me.txtperiodos.NombreDeConsulta = Nothing
        Me.txtperiodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtperiodos.Size = New System.Drawing.Size(45, 20)
        Me.txtperiodos.TabIndex = 12
        Me.txtperiodos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtclasemov
        '
        Me.txtclasemov.AcceptsReturn = True
        Me.txtclasemov.BackColor = System.Drawing.SystemColors.Window
        Me.txtclasemov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclasemov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtclasemov.Enabled = False
        Me.txtclasemov.EsRequerido = False
        Me.txtclasemov.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclasemov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtclasemov.LabelConsulta = Nothing
        Me.txtclasemov.Location = New System.Drawing.Point(183, 91)
        Me.txtclasemov.MaxLength = 0
        Me.txtclasemov.Name = "txtclasemov"
        Me.txtclasemov.NombreDeConsulta = Nothing
        Me.txtclasemov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtclasemov.Size = New System.Drawing.Size(45, 20)
        Me.txtclasemov.TabIndex = 4
        '
        'txtestado
        '
        Me.txtestado.AcceptsReturn = True
        Me.txtestado.BackColor = System.Drawing.SystemColors.Window
        Me.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtestado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtestado.Enabled = False
        Me.txtestado.EsRequerido = False
        Me.txtestado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtestado.LabelConsulta = Nothing
        Me.txtestado.Location = New System.Drawing.Point(483, 247)
        Me.txtestado.MaxLength = 0
        Me.txtestado.Name = "txtestado"
        Me.txtestado.NombreDeConsulta = Nothing
        Me.txtestado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtestado.Size = New System.Drawing.Size(45, 20)
        Me.txtestado.TabIndex = 14
        '
        'mskfechamov
        '
        Me.mskfechamov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskfechamov.Enabled = False
        Me.mskfechamov.EsRequerido = False
        Me.mskfechamov.Location = New System.Drawing.Point(183, 247)
        Me.mskfechamov.Mask = "00/00/0000"
        Me.mskfechamov.Name = "mskfechamov"
        Me.mskfechamov.Size = New System.Drawing.Size(130, 20)
        Me.mskfechamov.TabIndex = 13
        Me.mskfechamov.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskfechamov.ValidatingType = GetType(Date)
        '
        'mskfechaact
        '
        Me.mskfechaact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskfechaact.Enabled = False
        Me.mskfechaact.EsRequerido = False
        Me.mskfechaact.Location = New System.Drawing.Point(483, 273)
        Me.mskfechaact.Mask = "00/00/0000"
        Me.mskfechaact.Name = "mskfechaact"
        Me.mskfechaact.Size = New System.Drawing.Size(130, 20)
        Me.mskfechaact.TabIndex = 16
        Me.mskfechaact.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskfechaact.ValidatingType = GetType(Date)
        '
        'txtCODIGO_DE_ACTIVO
        '
        Me.txtCODIGO_DE_ACTIVO.AcceptsReturn = True
        Me.txtCODIGO_DE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_ACTIVO.Enabled = False
        Me.txtCODIGO_DE_ACTIVO.EsRequerido = False
        Me.txtCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_ACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(183, 12)
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
        Me.txtMEJORA_CORRELATIVO.Enabled = False
        Me.txtMEJORA_CORRELATIVO.EsRequerido = False
        Me.txtMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMEJORA_CORRELATIVO.LabelConsulta = Nothing
        Me.txtMEJORA_CORRELATIVO.Location = New System.Drawing.Point(183, 38)
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
        Me.txtTIPO_MOVIMIENTO.Enabled = False
        Me.txtTIPO_MOVIMIENTO.EsRequerido = False
        Me.txtTIPO_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_MOVIMIENTO.LabelConsulta = Nothing
        Me.txtTIPO_MOVIMIENTO.Location = New System.Drawing.Point(183, 64)
        Me.txtTIPO_MOVIMIENTO.MaxLength = 10
        Me.txtTIPO_MOVIMIENTO.Multiline = True
        Me.txtTIPO_MOVIMIENTO.Name = "txtTIPO_MOVIMIENTO"
        Me.txtTIPO_MOVIMIENTO.NombreDeConsulta = Nothing
        Me.txtTIPO_MOVIMIENTO.NumeroDecimales = 0
        Me.txtTIPO_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_MOVIMIENTO.Size = New System.Drawing.Size(45, 20)
        Me.txtTIPO_MOVIMIENTO.TabIndex = 3
        Me.txtTIPO_MOVIMIENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCORRELATIVO_MOVIM
        '
        Me.txtCORRELATIVO_MOVIM.AcceptsReturn = True
        Me.txtCORRELATIVO_MOVIM.BackColor = System.Drawing.SystemColors.Window
        Me.txtCORRELATIVO_MOVIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCORRELATIVO_MOVIM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCORRELATIVO_MOVIM.Enabled = False
        Me.txtCORRELATIVO_MOVIM.EsRequerido = False
        Me.txtCORRELATIVO_MOVIM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCORRELATIVO_MOVIM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCORRELATIVO_MOVIM.LabelConsulta = Nothing
        Me.txtCORRELATIVO_MOVIM.Location = New System.Drawing.Point(183, 117)
        Me.txtCORRELATIVO_MOVIM.MaxLength = 10
        Me.txtCORRELATIVO_MOVIM.Multiline = True
        Me.txtCORRELATIVO_MOVIM.Name = "txtCORRELATIVO_MOVIM"
        Me.txtCORRELATIVO_MOVIM.NombreDeConsulta = Nothing
        Me.txtCORRELATIVO_MOVIM.NumeroDecimales = 0
        Me.txtCORRELATIVO_MOVIM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCORRELATIVO_MOVIM.Size = New System.Drawing.Size(45, 20)
        Me.txtCORRELATIVO_MOVIM.TabIndex = 5
        Me.txtCORRELATIVO_MOVIM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtANO_PERIODO
        '
        Me.txtANO_PERIODO.AcceptsReturn = True
        Me.txtANO_PERIODO.BackColor = System.Drawing.SystemColors.Window
        Me.txtANO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtANO_PERIODO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtANO_PERIODO.Enabled = False
        Me.txtANO_PERIODO.EsRequerido = False
        Me.txtANO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtANO_PERIODO.LabelConsulta = Nothing
        Me.txtANO_PERIODO.Location = New System.Drawing.Point(483, 169)
        Me.txtANO_PERIODO.MaxLength = 4
        Me.txtANO_PERIODO.Multiline = True
        Me.txtANO_PERIODO.Name = "txtANO_PERIODO"
        Me.txtANO_PERIODO.NombreDeConsulta = Nothing
        Me.txtANO_PERIODO.NumeroDecimales = 0
        Me.txtANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtANO_PERIODO.Size = New System.Drawing.Size(45, 20)
        Me.txtANO_PERIODO.TabIndex = 8
        Me.txtANO_PERIODO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNO_PERIODO
        '
        Me.txtNO_PERIODO.AcceptsReturn = True
        Me.txtNO_PERIODO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNO_PERIODO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNO_PERIODO.Enabled = False
        Me.txtNO_PERIODO.EsRequerido = False
        Me.txtNO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNO_PERIODO.LabelConsulta = Nothing
        Me.txtNO_PERIODO.Location = New System.Drawing.Point(183, 169)
        Me.txtNO_PERIODO.MaxLength = 2
        Me.txtNO_PERIODO.Multiline = True
        Me.txtNO_PERIODO.Name = "txtNO_PERIODO"
        Me.txtNO_PERIODO.NombreDeConsulta = Nothing
        Me.txtNO_PERIODO.NumeroDecimales = 0
        Me.txtNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNO_PERIODO.Size = New System.Drawing.Size(45, 20)
        Me.txtNO_PERIODO.TabIndex = 7
        Me.txtNO_PERIODO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMONTO_DE_MOVIMIENTO
        '
        Me.txtMONTO_DE_MOVIMIENTO.AcceptsReturn = True
        Me.txtMONTO_DE_MOVIMIENTO.BackColor = System.Drawing.SystemColors.Window
        Me.txtMONTO_DE_MOVIMIENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMONTO_DE_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMONTO_DE_MOVIMIENTO.Enabled = False
        Me.txtMONTO_DE_MOVIMIENTO.EsRequerido = False
        Me.txtMONTO_DE_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTO_DE_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMONTO_DE_MOVIMIENTO.LabelConsulta = Nothing
        Me.txtMONTO_DE_MOVIMIENTO.Location = New System.Drawing.Point(183, 195)
        Me.txtMONTO_DE_MOVIMIENTO.MaxLength = 13
        Me.txtMONTO_DE_MOVIMIENTO.Multiline = True
        Me.txtMONTO_DE_MOVIMIENTO.Name = "txtMONTO_DE_MOVIMIENTO"
        Me.txtMONTO_DE_MOVIMIENTO.NombreDeConsulta = Nothing
        Me.txtMONTO_DE_MOVIMIENTO.NumeroDecimales = 2
        Me.txtMONTO_DE_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMONTO_DE_MOVIMIENTO.Size = New System.Drawing.Size(90, 20)
        Me.txtMONTO_DE_MOVIMIENTO.TabIndex = 9
        Me.txtMONTO_DE_MOVIMIENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtTASA_CAMBIO_MOV.Location = New System.Drawing.Point(483, 195)
        Me.txtTASA_CAMBIO_MOV.MaxLength = 13
        Me.txtTASA_CAMBIO_MOV.Multiline = True
        Me.txtTASA_CAMBIO_MOV.Name = "txtTASA_CAMBIO_MOV"
        Me.txtTASA_CAMBIO_MOV.NombreDeConsulta = Nothing
        Me.txtTASA_CAMBIO_MOV.NumeroDecimales = 5
        Me.txtTASA_CAMBIO_MOV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTASA_CAMBIO_MOV.Size = New System.Drawing.Size(90, 20)
        Me.txtTASA_CAMBIO_MOV.TabIndex = 10
        Me.txtTASA_CAMBIO_MOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUSUARIO_MOV_ACT
        '
        Me.txtUSUARIO_MOV_ACT.AcceptsReturn = True
        Me.txtUSUARIO_MOV_ACT.BackColor = System.Drawing.SystemColors.Window
        Me.txtUSUARIO_MOV_ACT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUSUARIO_MOV_ACT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUSUARIO_MOV_ACT.Enabled = False
        Me.txtUSUARIO_MOV_ACT.EsRequerido = False
        Me.txtUSUARIO_MOV_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSUARIO_MOV_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUSUARIO_MOV_ACT.LabelConsulta = Nothing
        Me.txtUSUARIO_MOV_ACT.Location = New System.Drawing.Point(183, 273)
        Me.txtUSUARIO_MOV_ACT.MaxLength = 10
        Me.txtUSUARIO_MOV_ACT.Name = "txtUSUARIO_MOV_ACT"
        Me.txtUSUARIO_MOV_ACT.NombreDeConsulta = Nothing
        Me.txtUSUARIO_MOV_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUSUARIO_MOV_ACT.Size = New System.Drawing.Size(90, 20)
        Me.txtUSUARIO_MOV_ACT.TabIndex = 15
        '
        'txtPORCENTAJE_DEPREC
        '
        Me.txtPORCENTAJE_DEPREC.AcceptsReturn = True
        Me.txtPORCENTAJE_DEPREC.BackColor = System.Drawing.SystemColors.Window
        Me.txtPORCENTAJE_DEPREC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPORCENTAJE_DEPREC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPORCENTAJE_DEPREC.Enabled = False
        Me.txtPORCENTAJE_DEPREC.EsRequerido = False
        Me.txtPORCENTAJE_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPORCENTAJE_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPORCENTAJE_DEPREC.LabelConsulta = Nothing
        Me.txtPORCENTAJE_DEPREC.Location = New System.Drawing.Point(183, 221)
        Me.txtPORCENTAJE_DEPREC.MaxLength = 8
        Me.txtPORCENTAJE_DEPREC.Multiline = True
        Me.txtPORCENTAJE_DEPREC.Name = "txtPORCENTAJE_DEPREC"
        Me.txtPORCENTAJE_DEPREC.NombreDeConsulta = Nothing
        Me.txtPORCENTAJE_DEPREC.NumeroDecimales = 4
        Me.txtPORCENTAJE_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPORCENTAJE_DEPREC.Size = New System.Drawing.Size(90, 20)
        Me.txtPORCENTAJE_DEPREC.TabIndex = 11
        Me.txtPORCENTAJE_DEPREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(526, 416)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Location = New System.Drawing.Point(15, 303)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(576, 1)
        Me.Line1.TabIndex = 81
        '
        'lblOBSERVACIONES
        '
        Me.lblOBSERVACIONES.AutoSize = True
        Me.lblOBSERVACIONES.BackColor = System.Drawing.Color.Transparent
        Me.lblOBSERVACIONES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOBSERVACIONES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOBSERVACIONES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblOBSERVACIONES.Location = New System.Drawing.Point(15, 317)
        Me.lblOBSERVACIONES.Name = "lblOBSERVACIONES"
        Me.lblOBSERVACIONES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOBSERVACIONES.Size = New System.Drawing.Size(81, 14)
        Me.lblOBSERVACIONES.TabIndex = 82
        Me.lblOBSERVACIONES.Text = "Observaciones"
        '
        'lblTitVALOR_NO_DEDUCIBLE
        '
        Me.lblTitVALOR_NO_DEDUCIBLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_NO_DEDUCIBLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_NO_DEDUCIBLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_NO_DEDUCIBLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_NO_DEDUCIBLE.Location = New System.Drawing.Point(12, 145)
        Me.lblTitVALOR_NO_DEDUCIBLE.Name = "lblTitVALOR_NO_DEDUCIBLE"
        Me.lblTitVALOR_NO_DEDUCIBLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_NO_DEDUCIBLE.Size = New System.Drawing.Size(165, 14)
        Me.lblTitVALOR_NO_DEDUCIBLE.TabIndex = 76
        Me.lblTitVALOR_NO_DEDUCIBLE.Text = "Valor no deducible"
        '
        'lblperiodos
        '
        Me.lblperiodos.BackColor = System.Drawing.Color.Transparent
        Me.lblperiodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblperiodos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperiodos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblperiodos.Location = New System.Drawing.Point(326, 221)
        Me.lblperiodos.Name = "lblperiodos"
        Me.lblperiodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblperiodos.Size = New System.Drawing.Size(151, 14)
        Me.lblperiodos.TabIndex = 74
        Me.lblperiodos.Text = "Periodos depreciados"
        '
        'lblnombreestado
        '
        Me.lblnombreestado.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreestado.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreestado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreestado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreestado.Location = New System.Drawing.Point(534, 249)
        Me.lblnombreestado.Name = "lblnombreestado"
        Me.lblnombreestado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreestado.Size = New System.Drawing.Size(87, 20)
        Me.lblnombreestado.TabIndex = 73
        '
        'lblnombreclase
        '
        Me.lblnombreclase.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreclase.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreclase.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreclase.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreclase.Location = New System.Drawing.Point(234, 93)
        Me.lblnombreclase.Name = "lblnombreclase"
        Me.lblnombreclase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreclase.Size = New System.Drawing.Size(379, 20)
        Me.lblnombreclase.TabIndex = 72
        Me.lblnombreclase.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(165, 14)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Clase de movimiento"
        '
        'lblnombretipo
        '
        Me.lblnombretipo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombretipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombretipo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombretipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombretipo.Location = New System.Drawing.Point(319, 66)
        Me.lblnombretipo.Name = "lblnombretipo"
        Me.lblnombretipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombretipo.Size = New System.Drawing.Size(294, 20)
        Me.lblnombretipo.TabIndex = 64
        Me.lblnombretipo.UseMnemonic = False
        '
        'lblnombreactivo
        '
        Me.lblnombreactivo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreactivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreactivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreactivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreactivo.Location = New System.Drawing.Point(314, 14)
        Me.lblnombreactivo.Name = "lblnombreactivo"
        Me.lblnombreactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreactivo.Size = New System.Drawing.Size(299, 20)
        Me.lblnombreactivo.TabIndex = 69
        Me.lblnombreactivo.UseMnemonic = False
        '
        'lblTitCODIGO_DE_ACTIVO
        '
        Me.lblTitCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(12, 14)
        Me.lblTitCODIGO_DE_ACTIVO.Name = "lblTitCODIGO_DE_ACTIVO"
        Me.lblTitCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(165, 14)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 55
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Codigo de activo"
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(12, 40)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(165, 14)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 56
        Me.lblTitMEJORA_CORRELATIVO.Text = "Mejora correlativo"
        '
        'lblTitTIPO_MOVIMIENTO
        '
        Me.lblTitTIPO_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_MOVIMIENTO.Location = New System.Drawing.Point(12, 66)
        Me.lblTitTIPO_MOVIMIENTO.Name = "lblTitTIPO_MOVIMIENTO"
        Me.lblTitTIPO_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_MOVIMIENTO.Size = New System.Drawing.Size(165, 14)
        Me.lblTitTIPO_MOVIMIENTO.TabIndex = 57
        Me.lblTitTIPO_MOVIMIENTO.Text = "Tipo de movimiento"
        '
        'lblTitCORRELATIVO_MOVIM
        '
        Me.lblTitCORRELATIVO_MOVIM.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCORRELATIVO_MOVIM.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCORRELATIVO_MOVIM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCORRELATIVO_MOVIM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCORRELATIVO_MOVIM.Location = New System.Drawing.Point(12, 119)
        Me.lblTitCORRELATIVO_MOVIM.Name = "lblTitCORRELATIVO_MOVIM"
        Me.lblTitCORRELATIVO_MOVIM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCORRELATIVO_MOVIM.Size = New System.Drawing.Size(165, 14)
        Me.lblTitCORRELATIVO_MOVIM.TabIndex = 58
        Me.lblTitCORRELATIVO_MOVIM.Text = "Correlativo movimiento"
        '
        'lblTitANO_PERIODO
        '
        Me.lblTitANO_PERIODO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitANO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitANO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitANO_PERIODO.Location = New System.Drawing.Point(326, 171)
        Me.lblTitANO_PERIODO.Name = "lblTitANO_PERIODO"
        Me.lblTitANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitANO_PERIODO.Size = New System.Drawing.Size(151, 14)
        Me.lblTitANO_PERIODO.TabIndex = 59
        Me.lblTitANO_PERIODO.Text = "Año del periodo"
        '
        'lblTitNO_PERIODO
        '
        Me.lblTitNO_PERIODO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_PERIODO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_PERIODO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_PERIODO.Location = New System.Drawing.Point(12, 171)
        Me.lblTitNO_PERIODO.Name = "lblTitNO_PERIODO"
        Me.lblTitNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_PERIODO.Size = New System.Drawing.Size(165, 14)
        Me.lblTitNO_PERIODO.TabIndex = 60
        Me.lblTitNO_PERIODO.Text = "Mes del periodo"
        '
        'lblTitFECHA_MOVIMIENTO
        '
        Me.lblTitFECHA_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_MOVIMIENTO.Location = New System.Drawing.Point(12, 249)
        Me.lblTitFECHA_MOVIMIENTO.Name = "lblTitFECHA_MOVIMIENTO"
        Me.lblTitFECHA_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_MOVIMIENTO.Size = New System.Drawing.Size(165, 14)
        Me.lblTitFECHA_MOVIMIENTO.TabIndex = 61
        Me.lblTitFECHA_MOVIMIENTO.Text = "Fecha de movimiento"
        '
        'lblTitMONTO_DE_MOVIMIENTO
        '
        Me.lblTitMONTO_DE_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_DE_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_DE_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_DE_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_DE_MOVIMIENTO.Location = New System.Drawing.Point(12, 197)
        Me.lblTitMONTO_DE_MOVIMIENTO.Name = "lblTitMONTO_DE_MOVIMIENTO"
        Me.lblTitMONTO_DE_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_DE_MOVIMIENTO.Size = New System.Drawing.Size(165, 14)
        Me.lblTitMONTO_DE_MOVIMIENTO.TabIndex = 62
        Me.lblTitMONTO_DE_MOVIMIENTO.Text = "Monto del movimiento"
        '
        'lblTitTASA_CAMBIO_MOV
        '
        Me.lblTitTASA_CAMBIO_MOV.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_CAMBIO_MOV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_CAMBIO_MOV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_CAMBIO_MOV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_CAMBIO_MOV.Location = New System.Drawing.Point(326, 197)
        Me.lblTitTASA_CAMBIO_MOV.Name = "lblTitTASA_CAMBIO_MOV"
        Me.lblTitTASA_CAMBIO_MOV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_CAMBIO_MOV.Size = New System.Drawing.Size(151, 14)
        Me.lblTitTASA_CAMBIO_MOV.TabIndex = 63
        Me.lblTitTASA_CAMBIO_MOV.Text = "Tasa de cambio"
        '
        'lblTitUSUARIO_MOV_ACT
        '
        Me.lblTitUSUARIO_MOV_ACT.BackColor = System.Drawing.Color.Transparent
        Me.lblTitUSUARIO_MOV_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitUSUARIO_MOV_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitUSUARIO_MOV_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitUSUARIO_MOV_ACT.Location = New System.Drawing.Point(12, 275)
        Me.lblTitUSUARIO_MOV_ACT.Name = "lblTitUSUARIO_MOV_ACT"
        Me.lblTitUSUARIO_MOV_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitUSUARIO_MOV_ACT.Size = New System.Drawing.Size(165, 14)
        Me.lblTitUSUARIO_MOV_ACT.TabIndex = 65
        Me.lblTitUSUARIO_MOV_ACT.Text = "Usuario que actualizó"
        '
        'lblTitFECHA_DPA_MOV_ACT
        '
        Me.lblTitFECHA_DPA_MOV_ACT.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_DPA_MOV_ACT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_DPA_MOV_ACT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_DPA_MOV_ACT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_DPA_MOV_ACT.Location = New System.Drawing.Point(326, 275)
        Me.lblTitFECHA_DPA_MOV_ACT.Name = "lblTitFECHA_DPA_MOV_ACT"
        Me.lblTitFECHA_DPA_MOV_ACT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_DPA_MOV_ACT.Size = New System.Drawing.Size(151, 14)
        Me.lblTitFECHA_DPA_MOV_ACT.TabIndex = 66
        Me.lblTitFECHA_DPA_MOV_ACT.Text = "Fecha actualización"
        '
        'lblTitESTADO_MOVIMIENTO
        '
        Me.lblTitESTADO_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTADO_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTADO_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTADO_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTADO_MOVIMIENTO.Location = New System.Drawing.Point(326, 249)
        Me.lblTitESTADO_MOVIMIENTO.Name = "lblTitESTADO_MOVIMIENTO"
        Me.lblTitESTADO_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTADO_MOVIMIENTO.Size = New System.Drawing.Size(151, 14)
        Me.lblTitESTADO_MOVIMIENTO.TabIndex = 67
        Me.lblTitESTADO_MOVIMIENTO.Text = "Estado del movimiento"
        '
        'lblTitPORCENTAJE_DEPREC
        '
        Me.lblTitPORCENTAJE_DEPREC.BackColor = System.Drawing.Color.Transparent
        Me.lblTitPORCENTAJE_DEPREC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitPORCENTAJE_DEPREC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPORCENTAJE_DEPREC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitPORCENTAJE_DEPREC.Location = New System.Drawing.Point(12, 223)
        Me.lblTitPORCENTAJE_DEPREC.Name = "lblTitPORCENTAJE_DEPREC"
        Me.lblTitPORCENTAJE_DEPREC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitPORCENTAJE_DEPREC.Size = New System.Drawing.Size(165, 14)
        Me.lblTitPORCENTAJE_DEPREC.TabIndex = 68
        Me.lblTitPORCENTAJE_DEPREC.Text = "Porcentaje de depreciación"
        '
        'ACTMVAM1
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(625, 453)
        Me.Controls.Add(Me.txtOBSERVACIONES1)
        Me.Controls.Add(Me.txtOBSERVACIONES2)
        Me.Controls.Add(Me.txtOBSERVACIONES3)
        Me.Controls.Add(Me.txtVALOR_NO_DEDUCIBLE)
        Me.Controls.Add(Me.txtperiodos)
        Me.Controls.Add(Me.txtclasemov)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.mskfechamov)
        Me.Controls.Add(Me.mskfechaact)
        Me.Controls.Add(Me.txtCODIGO_DE_ACTIVO)
        Me.Controls.Add(Me.txtMEJORA_CORRELATIVO)
        Me.Controls.Add(Me.txtTIPO_MOVIMIENTO)
        Me.Controls.Add(Me.txtCORRELATIVO_MOVIM)
        Me.Controls.Add(Me.txtANO_PERIODO)
        Me.Controls.Add(Me.txtNO_PERIODO)
        Me.Controls.Add(Me.txtMONTO_DE_MOVIMIENTO)
        Me.Controls.Add(Me.txtTASA_CAMBIO_MOV)
        Me.Controls.Add(Me.txtUSUARIO_MOV_ACT)
        Me.Controls.Add(Me.txtPORCENTAJE_DEPREC)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.lblOBSERVACIONES)
        Me.Controls.Add(Me.lblTitVALOR_NO_DEDUCIBLE)
        Me.Controls.Add(Me.lblperiodos)
        Me.Controls.Add(Me.lblnombreestado)
        Me.Controls.Add(Me.lblnombreclase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnombretipo)
        Me.Controls.Add(Me.lblnombreactivo)
        Me.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.Controls.Add(Me.lblTitTIPO_MOVIMIENTO)
        Me.Controls.Add(Me.lblTitCORRELATIVO_MOVIM)
        Me.Controls.Add(Me.lblTitANO_PERIODO)
        Me.Controls.Add(Me.lblTitNO_PERIODO)
        Me.Controls.Add(Me.lblTitFECHA_MOVIMIENTO)
        Me.Controls.Add(Me.lblTitMONTO_DE_MOVIMIENTO)
        Me.Controls.Add(Me.lblTitTASA_CAMBIO_MOV)
        Me.Controls.Add(Me.lblTitUSUARIO_MOV_ACT)
        Me.Controls.Add(Me.lblTitFECHA_DPA_MOV_ACT)
        Me.Controls.Add(Me.lblTitESTADO_MOVIMIENTO)
        Me.Controls.Add(Me.lblTitPORCENTAJE_DEPREC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMVAM1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta a movimientos de activos - ACTMVAM1"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtOBSERVACIONES1 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES2 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES3 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtVALOR_NO_DEDUCIBLE As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtperiodos As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtclasemov As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtestado As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents mskfechamov As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents mskfechaact As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents txtCODIGO_DE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtMEJORA_CORRELATIVO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTIPO_MOVIMIENTO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtCORRELATIVO_MOVIM As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtANO_PERIODO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtNO_PERIODO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtMONTO_DE_MOVIMIENTO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTASA_CAMBIO_MOV As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtUSUARIO_MOV_ACT As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtPORCENTAJE_DEPREC As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents lblOBSERVACIONES As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_NO_DEDUCIBLE As System.Windows.Forms.Label
    Public WithEvents lblperiodos As System.Windows.Forms.Label
    Public WithEvents lblnombreestado As System.Windows.Forms.Label
    Public WithEvents lblnombreclase As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblnombretipo As System.Windows.Forms.Label
    Public WithEvents lblnombreactivo As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitCORRELATIVO_MOVIM As System.Windows.Forms.Label
    Public WithEvents lblTitANO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblTitNO_PERIODO As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_DE_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_CAMBIO_MOV As System.Windows.Forms.Label
    Public WithEvents lblTitUSUARIO_MOV_ACT As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_DPA_MOV_ACT As System.Windows.Forms.Label
    Public WithEvents lblTitESTADO_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitPORCENTAJE_DEPREC As System.Windows.Forms.Label
End Class
