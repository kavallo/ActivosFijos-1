<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEAM0
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
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtOBSERVACIONES4 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES3 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES2 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtOBSERVACIONES1 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtVALOR_SERVICIO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTASA_CAMBIO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtCODIGO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDOCUMENTO_ENTREGA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.mskfecha2 = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitFECHA_ENTREGA = New System.Windows.Forms.Label()
        Me.lblTitDOCUMENTO_ENTREGA = New System.Windows.Forms.Label()
        Me.lblTitTASA_CAMBIO = New System.Windows.Forms.Label()
        Me.lblTitVALOR_SERVICIO = New System.Windows.Forms.Label()
        Me.lblnombremoneda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtCODIGO_DE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMEJORA_CORRELATIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTIPO_SERVICIO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDOCUMENTO_SALIDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.mskfecha1 = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtCODIGO_PROVEEDOR = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtNUMERO_SERVICIO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lbltiposerv = New System.Windows.Forms.Label()
        Me.lblTitDOCUMENTO_SALIDA = New System.Windows.Forms.Label()
        Me.lblTitFECHA_SERVICIO = New System.Windows.Forms.Label()
        Me.lblTitTIPO_SERVICIO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_PROVEEDOR = New System.Windows.Forms.Label()
        Me.lblTitNUMERO_SERVICIO = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblnombreactivo = New System.Windows.Forms.Label()
        Me.lblnombreproveedor = New System.Windows.Forms.Label()
        Me.lblnombretiposervicio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.txtOBSERVACIONES4)
        Me.Frame3.Controls.Add(Me.txtOBSERVACIONES3)
        Me.Frame3.Controls.Add(Me.txtOBSERVACIONES2)
        Me.Frame3.Controls.Add(Me.txtOBSERVACIONES1)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame3.Location = New System.Drawing.Point(12, 328)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(674, 107)
        Me.Frame3.TabIndex = 3
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " Observaciones "
        '
        'txtOBSERVACIONES4
        '
        Me.txtOBSERVACIONES4.AcceptsReturn = True
        Me.txtOBSERVACIONES4.BackColor = System.Drawing.SystemColors.Window
        Me.txtOBSERVACIONES4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOBSERVACIONES4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOBSERVACIONES4.EsRequerido = False
        Me.txtOBSERVACIONES4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBSERVACIONES4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOBSERVACIONES4.LabelConsulta = Nothing
        Me.txtOBSERVACIONES4.Location = New System.Drawing.Point(6, 79)
        Me.txtOBSERVACIONES4.MaxLength = 60
        Me.txtOBSERVACIONES4.Multiline = True
        Me.txtOBSERVACIONES4.Name = "txtOBSERVACIONES4"
        Me.txtOBSERVACIONES4.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES4.Size = New System.Drawing.Size(662, 20)
        Me.txtOBSERVACIONES4.TabIndex = 15
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
        Me.txtOBSERVACIONES3.Multiline = True
        Me.txtOBSERVACIONES3.Name = "txtOBSERVACIONES3"
        Me.txtOBSERVACIONES3.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES3.Size = New System.Drawing.Size(662, 20)
        Me.txtOBSERVACIONES3.TabIndex = 14
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
        Me.txtOBSERVACIONES2.Multiline = True
        Me.txtOBSERVACIONES2.Name = "txtOBSERVACIONES2"
        Me.txtOBSERVACIONES2.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES2.Size = New System.Drawing.Size(662, 20)
        Me.txtOBSERVACIONES2.TabIndex = 13
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
        Me.txtOBSERVACIONES1.Multiline = True
        Me.txtOBSERVACIONES1.Name = "txtOBSERVACIONES1"
        Me.txtOBSERVACIONES1.NombreDeConsulta = Nothing
        Me.txtOBSERVACIONES1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOBSERVACIONES1.Size = New System.Drawing.Size(662, 20)
        Me.txtOBSERVACIONES1.TabIndex = 12
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtVALOR_SERVICIO)
        Me.Frame2.Controls.Add(Me.txtTASA_CAMBIO)
        Me.Frame2.Controls.Add(Me.txtCODIGO_DE_MONEDA)
        Me.Frame2.Controls.Add(Me.txtDOCUMENTO_ENTREGA)
        Me.Frame2.Controls.Add(Me.mskfecha2)
        Me.Frame2.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.Frame2.Controls.Add(Me.lblTitFECHA_ENTREGA)
        Me.Frame2.Controls.Add(Me.lblTitDOCUMENTO_ENTREGA)
        Me.Frame2.Controls.Add(Me.lblTitTASA_CAMBIO)
        Me.Frame2.Controls.Add(Me.lblTitVALOR_SERVICIO)
        Me.Frame2.Controls.Add(Me.lblnombremoneda)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(12, 194)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(674, 128)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " Datos de recepción del servicio"
        '
        'txtVALOR_SERVICIO
        '
        Me.txtVALOR_SERVICIO.AcceptsReturn = True
        Me.txtVALOR_SERVICIO.BackColor = System.Drawing.SystemColors.Window
        Me.txtVALOR_SERVICIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALOR_SERVICIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVALOR_SERVICIO.EsRequerido = True
        Me.txtVALOR_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVALOR_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVALOR_SERVICIO.LabelConsulta = Nothing
        Me.txtVALOR_SERVICIO.Location = New System.Drawing.Point(178, 45)
        Me.txtVALOR_SERVICIO.MaxLength = 14
        Me.txtVALOR_SERVICIO.Multiline = True
        Me.txtVALOR_SERVICIO.Name = "txtVALOR_SERVICIO"
        Me.txtVALOR_SERVICIO.NombreDeConsulta = Nothing
        Me.txtVALOR_SERVICIO.NumeroDecimales = 2
        Me.txtVALOR_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVALOR_SERVICIO.Size = New System.Drawing.Size(99, 20)
        Me.txtVALOR_SERVICIO.TabIndex = 8
        Me.txtVALOR_SERVICIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTASA_CAMBIO
        '
        Me.txtTASA_CAMBIO.AcceptsReturn = True
        Me.txtTASA_CAMBIO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTASA_CAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTASA_CAMBIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTASA_CAMBIO.EsRequerido = True
        Me.txtTASA_CAMBIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTASA_CAMBIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTASA_CAMBIO.LabelConsulta = Nothing
        Me.txtTASA_CAMBIO.Location = New System.Drawing.Point(178, 97)
        Me.txtTASA_CAMBIO.MaxLength = 13
        Me.txtTASA_CAMBIO.Multiline = True
        Me.txtTASA_CAMBIO.Name = "txtTASA_CAMBIO"
        Me.txtTASA_CAMBIO.NombreDeConsulta = Nothing
        Me.txtTASA_CAMBIO.NumeroDecimales = 5
        Me.txtTASA_CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTASA_CAMBIO.Size = New System.Drawing.Size(99, 20)
        Me.txtTASA_CAMBIO.TabIndex = 10
        Me.txtTASA_CAMBIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCODIGO_DE_MONEDA
        '
        Me.txtCODIGO_DE_MONEDA.AcceptsReturn = True
        Me.txtCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_MONEDA.EsRequerido = False
        Me.txtCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_MONEDA.LabelConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.Location = New System.Drawing.Point(178, 71)
        Me.txtCODIGO_DE_MONEDA.MaxLength = 5
        Me.txtCODIGO_DE_MONEDA.Name = "txtCODIGO_DE_MONEDA"
        Me.txtCODIGO_DE_MONEDA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeMonedas_MONEDC01
        Me.txtCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_MONEDA.Size = New System.Drawing.Size(45, 20)
        Me.txtCODIGO_DE_MONEDA.TabIndex = 9
        Me.txtCODIGO_DE_MONEDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDOCUMENTO_ENTREGA
        '
        Me.txtDOCUMENTO_ENTREGA.AcceptsReturn = True
        Me.txtDOCUMENTO_ENTREGA.BackColor = System.Drawing.SystemColors.Window
        Me.txtDOCUMENTO_ENTREGA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDOCUMENTO_ENTREGA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDOCUMENTO_ENTREGA.EsRequerido = False
        Me.txtDOCUMENTO_ENTREGA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOCUMENTO_ENTREGA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDOCUMENTO_ENTREGA.LabelConsulta = Nothing
        Me.txtDOCUMENTO_ENTREGA.Location = New System.Drawing.Point(564, 97)
        Me.txtDOCUMENTO_ENTREGA.MaxLength = 20
        Me.txtDOCUMENTO_ENTREGA.Name = "txtDOCUMENTO_ENTREGA"
        Me.txtDOCUMENTO_ENTREGA.NombreDeConsulta = Nothing
        Me.txtDOCUMENTO_ENTREGA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDOCUMENTO_ENTREGA.Size = New System.Drawing.Size(91, 20)
        Me.txtDOCUMENTO_ENTREGA.TabIndex = 11
        Me.txtDOCUMENTO_ENTREGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskfecha2
        '
        Me.mskfecha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskfecha2.EsRequerido = False
        Me.mskfecha2.Location = New System.Drawing.Point(178, 21)
        Me.mskfecha2.Mask = "00/00/0000"
        Me.mskfecha2.Name = "mskfecha2"
        Me.mskfecha2.Size = New System.Drawing.Size(140, 20)
        Me.mskfecha2.TabIndex = 7
        Me.mskfecha2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskfecha2.ValidatingType = GetType(Date)
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(6, 73)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(166, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 19
        Me.lblTitCODIGO_DE_MONEDA.Text = "Código de moneda"
        '
        'lblTitFECHA_ENTREGA
        '
        Me.lblTitFECHA_ENTREGA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_ENTREGA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_ENTREGA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_ENTREGA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_ENTREGA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitFECHA_ENTREGA.Name = "lblTitFECHA_ENTREGA"
        Me.lblTitFECHA_ENTREGA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_ENTREGA.Size = New System.Drawing.Size(166, 14)
        Me.lblTitFECHA_ENTREGA.TabIndex = 20
        Me.lblTitFECHA_ENTREGA.Text = "Fecha de entrega"
        '
        'lblTitDOCUMENTO_ENTREGA
        '
        Me.lblTitDOCUMENTO_ENTREGA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDOCUMENTO_ENTREGA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDOCUMENTO_ENTREGA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDOCUMENTO_ENTREGA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDOCUMENTO_ENTREGA.Location = New System.Drawing.Point(438, 99)
        Me.lblTitDOCUMENTO_ENTREGA.Name = "lblTitDOCUMENTO_ENTREGA"
        Me.lblTitDOCUMENTO_ENTREGA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDOCUMENTO_ENTREGA.Size = New System.Drawing.Size(120, 14)
        Me.lblTitDOCUMENTO_ENTREGA.TabIndex = 21
        Me.lblTitDOCUMENTO_ENTREGA.Text = "Documento de entrega"
        '
        'lblTitTASA_CAMBIO
        '
        Me.lblTitTASA_CAMBIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_CAMBIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_CAMBIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_CAMBIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_CAMBIO.Location = New System.Drawing.Point(6, 99)
        Me.lblTitTASA_CAMBIO.Name = "lblTitTASA_CAMBIO"
        Me.lblTitTASA_CAMBIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_CAMBIO.Size = New System.Drawing.Size(166, 14)
        Me.lblTitTASA_CAMBIO.TabIndex = 22
        Me.lblTitTASA_CAMBIO.Text = "Tasa de cambio"
        '
        'lblTitVALOR_SERVICIO
        '
        Me.lblTitVALOR_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitVALOR_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitVALOR_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitVALOR_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitVALOR_SERVICIO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitVALOR_SERVICIO.Name = "lblTitVALOR_SERVICIO"
        Me.lblTitVALOR_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitVALOR_SERVICIO.Size = New System.Drawing.Size(166, 14)
        Me.lblTitVALOR_SERVICIO.TabIndex = 23
        Me.lblTitVALOR_SERVICIO.Text = "Valor del servicio"
        '
        'lblnombremoneda
        '
        Me.lblnombremoneda.BackColor = System.Drawing.Color.Transparent
        Me.lblnombremoneda.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombremoneda.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombremoneda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombremoneda.Location = New System.Drawing.Point(244, 73)
        Me.lblnombremoneda.Name = "lblnombremoneda"
        Me.lblnombremoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombremoneda.Size = New System.Drawing.Size(424, 20)
        Me.lblnombremoneda.TabIndex = 24
        Me.lblnombremoneda.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(336, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "[DD/MM/AAAA]"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtCODIGO_DE_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtMEJORA_CORRELATIVO)
        Me.Frame1.Controls.Add(Me.txtTIPO_SERVICIO)
        Me.Frame1.Controls.Add(Me.txtDOCUMENTO_SALIDA)
        Me.Frame1.Controls.Add(Me.mskfecha1)
        Me.Frame1.Controls.Add(Me.txtCODIGO_PROVEEDOR)
        Me.Frame1.Controls.Add(Me.txtNUMERO_SERVICIO)
        Me.Frame1.Controls.Add(Me.lbltiposerv)
        Me.Frame1.Controls.Add(Me.lblTitDOCUMENTO_SALIDA)
        Me.Frame1.Controls.Add(Me.lblTitFECHA_SERVICIO)
        Me.Frame1.Controls.Add(Me.lblTitTIPO_SERVICIO)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_PROVEEDOR)
        Me.Frame1.Controls.Add(Me.lblTitNUMERO_SERVICIO)
        Me.Frame1.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblnombreactivo)
        Me.Frame1.Controls.Add(Me.lblnombreproveedor)
        Me.Frame1.Controls.Add(Me.lblnombretiposervicio)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(674, 176)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " Datos de envío a servicio"
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
        Me.txtCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(178, 19)
        Me.txtCODIGO_DE_ACTIVO.MaxLength = 15
        Me.txtCODIGO_DE_ACTIVO.Name = "txtCODIGO_DE_ACTIVO"
        Me.txtCODIGO_DE_ACTIVO.NombreDeConsulta = Nothing
        Me.txtCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(125, 20)
        Me.txtCODIGO_DE_ACTIVO.TabIndex = 0
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
        Me.txtMEJORA_CORRELATIVO.Location = New System.Drawing.Point(178, 45)
        Me.txtMEJORA_CORRELATIVO.MaxLength = 10
        Me.txtMEJORA_CORRELATIVO.Multiline = True
        Me.txtMEJORA_CORRELATIVO.Name = "txtMEJORA_CORRELATIVO"
        Me.txtMEJORA_CORRELATIVO.NombreDeConsulta = Nothing
        Me.txtMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMEJORA_CORRELATIVO.Size = New System.Drawing.Size(45, 20)
        Me.txtMEJORA_CORRELATIVO.TabIndex = 1
        Me.txtMEJORA_CORRELATIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTIPO_SERVICIO
        '
        Me.txtTIPO_SERVICIO.AcceptsReturn = True
        Me.txtTIPO_SERVICIO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIPO_SERVICIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIPO_SERVICIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIPO_SERVICIO.EsRequerido = True
        Me.txtTIPO_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_SERVICIO.LabelConsulta = Nothing
        Me.txtTIPO_SERVICIO.Location = New System.Drawing.Point(178, 123)
        Me.txtTIPO_SERVICIO.MaxLength = 10
        Me.txtTIPO_SERVICIO.Name = "txtTIPO_SERVICIO"
        Me.txtTIPO_SERVICIO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeServicio_ACTTSAL0
        Me.txtTIPO_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_SERVICIO.Size = New System.Drawing.Size(83, 20)
        Me.txtTIPO_SERVICIO.TabIndex = 4
        '
        'txtDOCUMENTO_SALIDA
        '
        Me.txtDOCUMENTO_SALIDA.AcceptsReturn = True
        Me.txtDOCUMENTO_SALIDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtDOCUMENTO_SALIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDOCUMENTO_SALIDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDOCUMENTO_SALIDA.EsRequerido = False
        Me.txtDOCUMENTO_SALIDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOCUMENTO_SALIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDOCUMENTO_SALIDA.LabelConsulta = Nothing
        Me.txtDOCUMENTO_SALIDA.Location = New System.Drawing.Point(564, 149)
        Me.txtDOCUMENTO_SALIDA.MaxLength = 20
        Me.txtDOCUMENTO_SALIDA.Name = "txtDOCUMENTO_SALIDA"
        Me.txtDOCUMENTO_SALIDA.NombreDeConsulta = Nothing
        Me.txtDOCUMENTO_SALIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDOCUMENTO_SALIDA.Size = New System.Drawing.Size(91, 20)
        Me.txtDOCUMENTO_SALIDA.TabIndex = 6
        Me.txtDOCUMENTO_SALIDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskfecha1
        '
        Me.mskfecha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskfecha1.EsRequerido = True
        Me.mskfecha1.Location = New System.Drawing.Point(178, 149)
        Me.mskfecha1.Mask = "00/00/0000"
        Me.mskfecha1.Name = "mskfecha1"
        Me.mskfecha1.Size = New System.Drawing.Size(140, 20)
        Me.mskfecha1.TabIndex = 5
        Me.mskfecha1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskfecha1.ValidatingType = GetType(Date)
        '
        'txtCODIGO_PROVEEDOR
        '
        Me.txtCODIGO_PROVEEDOR.AcceptsReturn = True
        Me.txtCODIGO_PROVEEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_PROVEEDOR.EsRequerido = False
        Me.txtCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_PROVEEDOR.LabelConsulta = Nothing
        Me.txtCODIGO_PROVEEDOR.Location = New System.Drawing.Point(178, 97)
        Me.txtCODIGO_PROVEEDOR.MaxLength = 10
        Me.txtCODIGO_PROVEEDOR.Multiline = True
        Me.txtCODIGO_PROVEEDOR.Name = "txtCODIGO_PROVEEDOR"
        Me.txtCODIGO_PROVEEDOR.NombreDeConsulta = Nothing
        Me.txtCODIGO_PROVEEDOR.NumeroDecimales = 0
        Me.txtCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_PROVEEDOR.Size = New System.Drawing.Size(83, 20)
        Me.txtCODIGO_PROVEEDOR.TabIndex = 3
        Me.txtCODIGO_PROVEEDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNUMERO_SERVICIO
        '
        Me.txtNUMERO_SERVICIO.AcceptsReturn = True
        Me.txtNUMERO_SERVICIO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUMERO_SERVICIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_SERVICIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_SERVICIO.EsRequerido = False
        Me.txtNUMERO_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_SERVICIO.LabelConsulta = Nothing
        Me.txtNUMERO_SERVICIO.Location = New System.Drawing.Point(178, 71)
        Me.txtNUMERO_SERVICIO.MaxLength = 8
        Me.txtNUMERO_SERVICIO.Multiline = True
        Me.txtNUMERO_SERVICIO.Name = "txtNUMERO_SERVICIO"
        Me.txtNUMERO_SERVICIO.NombreDeConsulta = Nothing
        Me.txtNUMERO_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_SERVICIO.Size = New System.Drawing.Size(45, 20)
        Me.txtNUMERO_SERVICIO.TabIndex = 2
        Me.txtNUMERO_SERVICIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltiposerv
        '
        Me.lbltiposerv.BackColor = System.Drawing.Color.Transparent
        Me.lbltiposerv.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltiposerv.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltiposerv.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltiposerv.Location = New System.Drawing.Point(534, 125)
        Me.lbltiposerv.Name = "lbltiposerv"
        Me.lbltiposerv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltiposerv.Size = New System.Drawing.Size(134, 20)
        Me.lbltiposerv.TabIndex = 39
        '
        'lblTitDOCUMENTO_SALIDA
        '
        Me.lblTitDOCUMENTO_SALIDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDOCUMENTO_SALIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDOCUMENTO_SALIDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDOCUMENTO_SALIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDOCUMENTO_SALIDA.Location = New System.Drawing.Point(438, 151)
        Me.lblTitDOCUMENTO_SALIDA.Name = "lblTitDOCUMENTO_SALIDA"
        Me.lblTitDOCUMENTO_SALIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDOCUMENTO_SALIDA.Size = New System.Drawing.Size(120, 14)
        Me.lblTitDOCUMENTO_SALIDA.TabIndex = 26
        Me.lblTitDOCUMENTO_SALIDA.Text = "Documento de salida"
        '
        'lblTitFECHA_SERVICIO
        '
        Me.lblTitFECHA_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_SERVICIO.Location = New System.Drawing.Point(6, 151)
        Me.lblTitFECHA_SERVICIO.Name = "lblTitFECHA_SERVICIO"
        Me.lblTitFECHA_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_SERVICIO.Size = New System.Drawing.Size(166, 14)
        Me.lblTitFECHA_SERVICIO.TabIndex = 27
        Me.lblTitFECHA_SERVICIO.Text = "Fecha de servicio"
        '
        'lblTitTIPO_SERVICIO
        '
        Me.lblTitTIPO_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_SERVICIO.Location = New System.Drawing.Point(6, 125)
        Me.lblTitTIPO_SERVICIO.Name = "lblTitTIPO_SERVICIO"
        Me.lblTitTIPO_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_SERVICIO.Size = New System.Drawing.Size(166, 14)
        Me.lblTitTIPO_SERVICIO.TabIndex = 28
        Me.lblTitTIPO_SERVICIO.Text = "Tipo de servicio"
        '
        'lblTitCODIGO_PROVEEDOR
        '
        Me.lblTitCODIGO_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_PROVEEDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_PROVEEDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_PROVEEDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_PROVEEDOR.Location = New System.Drawing.Point(6, 99)
        Me.lblTitCODIGO_PROVEEDOR.Name = "lblTitCODIGO_PROVEEDOR"
        Me.lblTitCODIGO_PROVEEDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_PROVEEDOR.Size = New System.Drawing.Size(166, 14)
        Me.lblTitCODIGO_PROVEEDOR.TabIndex = 29
        Me.lblTitCODIGO_PROVEEDOR.Text = "Código de proveedor"
        '
        'lblTitNUMERO_SERVICIO
        '
        Me.lblTitNUMERO_SERVICIO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_SERVICIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_SERVICIO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_SERVICIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_SERVICIO.Location = New System.Drawing.Point(6, 73)
        Me.lblTitNUMERO_SERVICIO.Name = "lblTitNUMERO_SERVICIO"
        Me.lblTitNUMERO_SERVICIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_SERVICIO.Size = New System.Drawing.Size(166, 14)
        Me.lblTitNUMERO_SERVICIO.TabIndex = 30
        Me.lblTitNUMERO_SERVICIO.Text = "Numero de servicio"
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(166, 14)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 37
        Me.lblTitMEJORA_CORRELATIVO.Text = "Correlativo mejora"
        '
        'lblTitCODIGO_DE_ACTIVO
        '
        Me.lblTitCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCODIGO_DE_ACTIVO.Name = "lblTitCODIGO_DE_ACTIVO"
        Me.lblTitCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(166, 14)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 36
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Código de activo"
        '
        'lblnombreactivo
        '
        Me.lblnombreactivo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreactivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreactivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreactivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreactivo.Location = New System.Drawing.Point(325, 21)
        Me.lblnombreactivo.Name = "lblnombreactivo"
        Me.lblnombreactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreactivo.Size = New System.Drawing.Size(343, 20)
        Me.lblnombreactivo.TabIndex = 35
        Me.lblnombreactivo.UseMnemonic = False
        '
        'lblnombreproveedor
        '
        Me.lblnombreproveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreproveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombreproveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreproveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombreproveedor.Location = New System.Drawing.Point(282, 99)
        Me.lblnombreproveedor.Name = "lblnombreproveedor"
        Me.lblnombreproveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombreproveedor.Size = New System.Drawing.Size(386, 20)
        Me.lblnombreproveedor.TabIndex = 34
        Me.lblnombreproveedor.UseMnemonic = False
        '
        'lblnombretiposervicio
        '
        Me.lblnombretiposervicio.BackColor = System.Drawing.Color.Transparent
        Me.lblnombretiposervicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombretiposervicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombretiposervicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombretiposervicio.Location = New System.Drawing.Point(285, 125)
        Me.lblnombretiposervicio.Name = "lblnombretiposervicio"
        Me.lblnombretiposervicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombretiposervicio.Size = New System.Drawing.Size(243, 20)
        Me.lblnombretiposervicio.TabIndex = 33
        Me.lblnombretiposervicio.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(336, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "[DD/MM/AAAA]"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(526, 441)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(77, 25)
        Me.cmdAceptar.TabIndex = 4
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
        Me.cmdCancelar.Location = New System.Drawing.Point(609, 441)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(77, 25)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'ACTSEAM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(698, 478)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ACTSEAM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento a servicios de activos - ACTSEAM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents txtOBSERVACIONES4 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES3 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES2 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtOBSERVACIONES1 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtCODIGO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDOCUMENTO_ENTREGA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTASA_CAMBIO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtVALOR_SERVICIO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents mskfecha2 As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_ENTREGA As System.Windows.Forms.Label
    Public WithEvents lblTitDOCUMENTO_ENTREGA As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_CAMBIO As System.Windows.Forms.Label
    Public WithEvents lblTitVALOR_SERVICIO As System.Windows.Forms.Label
    Public WithEvents lblnombremoneda As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDOCUMENTO_SALIDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTIPO_SERVICIO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_PROVEEDOR As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtNUMERO_SERVICIO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtMEJORA_CORRELATIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCODIGO_DE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents mskfecha1 As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents lbltiposerv As System.Windows.Forms.Label
    Public WithEvents lblTitDOCUMENTO_SALIDA As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_SERVICIO As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_SERVICIO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_PROVEEDOR As System.Windows.Forms.Label
    Public WithEvents lblTitNUMERO_SERVICIO As System.Windows.Forms.Label
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblnombreactivo As System.Windows.Forms.Label
    Public WithEvents lblnombreproveedor As System.Windows.Forms.Label
    Public WithEvents lblnombretiposervicio As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
