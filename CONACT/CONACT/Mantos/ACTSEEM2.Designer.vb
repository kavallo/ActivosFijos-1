<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTSEEM2
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
        Me.mskfechaf = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtCODIGO_DE_MONEDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTOTAL_SEGURO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtMONTO_PRIMA = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtFAX_COMPANIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTELEFONO_COMPANIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCONTACTO_COMPANIA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.mskfechai = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.txtCOMPANIA_SEGUROS = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNO_ENDOSO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNUMERO_POLIZA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnombremoneda = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitTOTAL_SEGURO = New System.Windows.Forms.Label()
        Me.lblTitMONTO_PRIMA = New System.Windows.Forms.Label()
        Me.lblTitFAX_COMPANIA = New System.Windows.Forms.Label()
        Me.lblTitTELEFONO_COMPANIA = New System.Windows.Forms.Label()
        Me.lblTitCONTACTO_COMPANIA = New System.Windows.Forms.Label()
        Me.lblTitCOMPANIA_SEGUROS = New System.Windows.Forms.Label()
        Me.lblTitFECHA_F_VIGENCIA = New System.Windows.Forms.Label()
        Me.lblTitFECHA_I_VIGENCIA = New System.Windows.Forms.Label()
        Me.lblTitNO_ENDOSO = New System.Windows.Forms.Label()
        Me.lblTitNUMERO_POLIZA = New System.Windows.Forms.Label()
        Me.lblTitNOMBRE_CORREDOR = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtFAX_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTELEFONO_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCONTACTO_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNOMBRE_CORREDOR = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitFAX_CORREDOR = New System.Windows.Forms.Label()
        Me.lblTitTELEFONO_CORREDOR = New System.Windows.Forms.Label()
        Me.lblTitCONTACTO_CORREDOR = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mskfechaf
        '
        Me.mskfechaf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskfechaf.Enabled = False
        Me.mskfechaf.EsRequerido = False
        Me.mskfechaf.Location = New System.Drawing.Point(165, 228)
        Me.mskfechaf.Mask = "00/00/0000"
        Me.mskfechaf.Name = "mskfechaf"
        Me.mskfechaf.Size = New System.Drawing.Size(174, 20)
        Me.mskfechaf.TabIndex = 10
        Me.mskfechaf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskfechaf.ValidatingType = GetType(Date)
        '
        'txtCODIGO_DE_MONEDA
        '
        Me.txtCODIGO_DE_MONEDA.AcceptsReturn = True
        Me.txtCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DE_MONEDA.Enabled = False
        Me.txtCODIGO_DE_MONEDA.EsRequerido = False
        Me.txtCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DE_MONEDA.LabelConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.Location = New System.Drawing.Point(165, 149)
        Me.txtCODIGO_DE_MONEDA.MaxLength = 2
        Me.txtCODIGO_DE_MONEDA.Name = "txtCODIGO_DE_MONEDA"
        Me.txtCODIGO_DE_MONEDA.NombreDeConsulta = Nothing
        Me.txtCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DE_MONEDA.Size = New System.Drawing.Size(87, 20)
        Me.txtCODIGO_DE_MONEDA.TabIndex = 6
        Me.txtCODIGO_DE_MONEDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTOTAL_SEGURO
        '
        Me.txtTOTAL_SEGURO.AcceptsReturn = True
        Me.txtTOTAL_SEGURO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTOTAL_SEGURO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTOTAL_SEGURO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTOTAL_SEGURO.Enabled = False
        Me.txtTOTAL_SEGURO.EsRequerido = False
        Me.txtTOTAL_SEGURO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTOTAL_SEGURO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTOTAL_SEGURO.LabelConsulta = Nothing
        Me.txtTOTAL_SEGURO.Location = New System.Drawing.Point(456, 175)
        Me.txtTOTAL_SEGURO.MaxLength = 14
        Me.txtTOTAL_SEGURO.Multiline = True
        Me.txtTOTAL_SEGURO.Name = "txtTOTAL_SEGURO"
        Me.txtTOTAL_SEGURO.NombreDeConsulta = Nothing
        Me.txtTOTAL_SEGURO.NumeroDecimales = 2
        Me.txtTOTAL_SEGURO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTOTAL_SEGURO.Size = New System.Drawing.Size(149, 21)
        Me.txtTOTAL_SEGURO.TabIndex = 8
        Me.txtTOTAL_SEGURO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMONTO_PRIMA
        '
        Me.txtMONTO_PRIMA.AcceptsReturn = True
        Me.txtMONTO_PRIMA.BackColor = System.Drawing.SystemColors.Window
        Me.txtMONTO_PRIMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMONTO_PRIMA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMONTO_PRIMA.Enabled = False
        Me.txtMONTO_PRIMA.EsRequerido = False
        Me.txtMONTO_PRIMA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTO_PRIMA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMONTO_PRIMA.LabelConsulta = Nothing
        Me.txtMONTO_PRIMA.Location = New System.Drawing.Point(165, 175)
        Me.txtMONTO_PRIMA.MaxLength = 14
        Me.txtMONTO_PRIMA.Multiline = True
        Me.txtMONTO_PRIMA.Name = "txtMONTO_PRIMA"
        Me.txtMONTO_PRIMA.NombreDeConsulta = Nothing
        Me.txtMONTO_PRIMA.NumeroDecimales = 2
        Me.txtMONTO_PRIMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMONTO_PRIMA.Size = New System.Drawing.Size(149, 21)
        Me.txtMONTO_PRIMA.TabIndex = 7
        Me.txtMONTO_PRIMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFAX_COMPANIA
        '
        Me.txtFAX_COMPANIA.AcceptsReturn = True
        Me.txtFAX_COMPANIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtFAX_COMPANIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFAX_COMPANIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFAX_COMPANIA.Enabled = False
        Me.txtFAX_COMPANIA.EsRequerido = False
        Me.txtFAX_COMPANIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFAX_COMPANIA.LabelConsulta = Nothing
        Me.txtFAX_COMPANIA.Location = New System.Drawing.Point(456, 123)
        Me.txtFAX_COMPANIA.MaxLength = 15
        Me.txtFAX_COMPANIA.Name = "txtFAX_COMPANIA"
        Me.txtFAX_COMPANIA.NombreDeConsulta = Nothing
        Me.txtFAX_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFAX_COMPANIA.Size = New System.Drawing.Size(149, 20)
        Me.txtFAX_COMPANIA.TabIndex = 5
        Me.txtFAX_COMPANIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTELEFONO_COMPANIA
        '
        Me.txtTELEFONO_COMPANIA.AcceptsReturn = True
        Me.txtTELEFONO_COMPANIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtTELEFONO_COMPANIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTELEFONO_COMPANIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTELEFONO_COMPANIA.Enabled = False
        Me.txtTELEFONO_COMPANIA.EsRequerido = False
        Me.txtTELEFONO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTELEFONO_COMPANIA.LabelConsulta = Nothing
        Me.txtTELEFONO_COMPANIA.Location = New System.Drawing.Point(165, 123)
        Me.txtTELEFONO_COMPANIA.MaxLength = 15
        Me.txtTELEFONO_COMPANIA.Name = "txtTELEFONO_COMPANIA"
        Me.txtTELEFONO_COMPANIA.NombreDeConsulta = Nothing
        Me.txtTELEFONO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTELEFONO_COMPANIA.Size = New System.Drawing.Size(149, 20)
        Me.txtTELEFONO_COMPANIA.TabIndex = 4
        Me.txtTELEFONO_COMPANIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCONTACTO_COMPANIA
        '
        Me.txtCONTACTO_COMPANIA.AcceptsReturn = True
        Me.txtCONTACTO_COMPANIA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCONTACTO_COMPANIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCONTACTO_COMPANIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCONTACTO_COMPANIA.Enabled = False
        Me.txtCONTACTO_COMPANIA.EsRequerido = False
        Me.txtCONTACTO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTACTO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCONTACTO_COMPANIA.LabelConsulta = Nothing
        Me.txtCONTACTO_COMPANIA.Location = New System.Drawing.Point(165, 97)
        Me.txtCONTACTO_COMPANIA.MaxLength = 40
        Me.txtCONTACTO_COMPANIA.Name = "txtCONTACTO_COMPANIA"
        Me.txtCONTACTO_COMPANIA.NombreDeConsulta = Nothing
        Me.txtCONTACTO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCONTACTO_COMPANIA.Size = New System.Drawing.Size(348, 20)
        Me.txtCONTACTO_COMPANIA.TabIndex = 3
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.mskfechai)
        Me.Frame1.Controls.Add(Me.mskfechaf)
        Me.Frame1.Controls.Add(Me.txtCODIGO_DE_MONEDA)
        Me.Frame1.Controls.Add(Me.txtTOTAL_SEGURO)
        Me.Frame1.Controls.Add(Me.txtMONTO_PRIMA)
        Me.Frame1.Controls.Add(Me.txtFAX_COMPANIA)
        Me.Frame1.Controls.Add(Me.txtTELEFONO_COMPANIA)
        Me.Frame1.Controls.Add(Me.txtCONTACTO_COMPANIA)
        Me.Frame1.Controls.Add(Me.txtCOMPANIA_SEGUROS)
        Me.Frame1.Controls.Add(Me.txtNO_ENDOSO)
        Me.Frame1.Controls.Add(Me.txtNUMERO_POLIZA)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.lblnombremoneda)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.Frame1.Controls.Add(Me.lblTitTOTAL_SEGURO)
        Me.Frame1.Controls.Add(Me.lblTitMONTO_PRIMA)
        Me.Frame1.Controls.Add(Me.lblTitFAX_COMPANIA)
        Me.Frame1.Controls.Add(Me.lblTitTELEFONO_COMPANIA)
        Me.Frame1.Controls.Add(Me.lblTitCONTACTO_COMPANIA)
        Me.Frame1.Controls.Add(Me.lblTitCOMPANIA_SEGUROS)
        Me.Frame1.Controls.Add(Me.lblTitFECHA_F_VIGENCIA)
        Me.Frame1.Controls.Add(Me.lblTitFECHA_I_VIGENCIA)
        Me.Frame1.Controls.Add(Me.lblTitNO_ENDOSO)
        Me.Frame1.Controls.Add(Me.lblTitNUMERO_POLIZA)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(611, 255)
        Me.Frame1.TabIndex = 32
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " Datos de la póliza "
        '
        'mskfechai
        '
        Me.mskfechai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskfechai.Enabled = False
        Me.mskfechai.EsRequerido = False
        Me.mskfechai.Location = New System.Drawing.Point(165, 202)
        Me.mskfechai.Mask = "00/00/0000"
        Me.mskfechai.Name = "mskfechai"
        Me.mskfechai.Size = New System.Drawing.Size(174, 20)
        Me.mskfechai.TabIndex = 37
        Me.mskfechai.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskfechai.ValidatingType = GetType(Date)
        '
        'txtCOMPANIA_SEGUROS
        '
        Me.txtCOMPANIA_SEGUROS.AcceptsReturn = True
        Me.txtCOMPANIA_SEGUROS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCOMPANIA_SEGUROS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOMPANIA_SEGUROS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCOMPANIA_SEGUROS.Enabled = False
        Me.txtCOMPANIA_SEGUROS.EsRequerido = False
        Me.txtCOMPANIA_SEGUROS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOMPANIA_SEGUROS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCOMPANIA_SEGUROS.LabelConsulta = Nothing
        Me.txtCOMPANIA_SEGUROS.Location = New System.Drawing.Point(165, 71)
        Me.txtCOMPANIA_SEGUROS.MaxLength = 40
        Me.txtCOMPANIA_SEGUROS.Name = "txtCOMPANIA_SEGUROS"
        Me.txtCOMPANIA_SEGUROS.NombreDeConsulta = Nothing
        Me.txtCOMPANIA_SEGUROS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCOMPANIA_SEGUROS.Size = New System.Drawing.Size(348, 20)
        Me.txtCOMPANIA_SEGUROS.TabIndex = 2
        '
        'txtNO_ENDOSO
        '
        Me.txtNO_ENDOSO.AcceptsReturn = True
        Me.txtNO_ENDOSO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNO_ENDOSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNO_ENDOSO.Enabled = False
        Me.txtNO_ENDOSO.EsRequerido = False
        Me.txtNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNO_ENDOSO.LabelConsulta = Nothing
        Me.txtNO_ENDOSO.Location = New System.Drawing.Point(165, 45)
        Me.txtNO_ENDOSO.MaxLength = 15
        Me.txtNO_ENDOSO.Name = "txtNO_ENDOSO"
        Me.txtNO_ENDOSO.NombreDeConsulta = Nothing
        Me.txtNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNO_ENDOSO.Size = New System.Drawing.Size(174, 20)
        Me.txtNO_ENDOSO.TabIndex = 1
        Me.txtNO_ENDOSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNUMERO_POLIZA
        '
        Me.txtNUMERO_POLIZA.AcceptsReturn = True
        Me.txtNUMERO_POLIZA.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUMERO_POLIZA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_POLIZA.Enabled = False
        Me.txtNUMERO_POLIZA.EsRequerido = False
        Me.txtNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_POLIZA.LabelConsulta = Nothing
        Me.txtNUMERO_POLIZA.Location = New System.Drawing.Point(165, 19)
        Me.txtNUMERO_POLIZA.MaxLength = 20
        Me.txtNUMERO_POLIZA.Name = "txtNUMERO_POLIZA"
        Me.txtNUMERO_POLIZA.NombreDeConsulta = Nothing
        Me.txtNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_POLIZA.Size = New System.Drawing.Size(174, 20)
        Me.txtNUMERO_POLIZA.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(345, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "(DD/MM/AAAA)"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(345, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "(DD/MM/AAAA)"
        '
        'lblnombremoneda
        '
        Me.lblnombremoneda.BackColor = System.Drawing.Color.Transparent
        Me.lblnombremoneda.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombremoneda.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombremoneda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombremoneda.Location = New System.Drawing.Point(258, 149)
        Me.lblnombremoneda.Name = "lblnombremoneda"
        Me.lblnombremoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombremoneda.Size = New System.Drawing.Size(347, 20)
        Me.lblnombremoneda.TabIndex = 21
        Me.lblnombremoneda.UseMnemonic = False
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(6, 151)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(153, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 22
        Me.lblTitCODIGO_DE_MONEDA.Text = "Código de moneda"
        '
        'lblTitTOTAL_SEGURO
        '
        Me.lblTitTOTAL_SEGURO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTOTAL_SEGURO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTOTAL_SEGURO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTOTAL_SEGURO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTOTAL_SEGURO.Location = New System.Drawing.Point(348, 177)
        Me.lblTitTOTAL_SEGURO.Name = "lblTitTOTAL_SEGURO"
        Me.lblTitTOTAL_SEGURO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTOTAL_SEGURO.Size = New System.Drawing.Size(102, 14)
        Me.lblTitTOTAL_SEGURO.TabIndex = 23
        Me.lblTitTOTAL_SEGURO.Text = "Total del seguro"
        '
        'lblTitMONTO_PRIMA
        '
        Me.lblTitMONTO_PRIMA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMONTO_PRIMA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMONTO_PRIMA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMONTO_PRIMA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMONTO_PRIMA.Location = New System.Drawing.Point(6, 177)
        Me.lblTitMONTO_PRIMA.Name = "lblTitMONTO_PRIMA"
        Me.lblTitMONTO_PRIMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMONTO_PRIMA.Size = New System.Drawing.Size(153, 14)
        Me.lblTitMONTO_PRIMA.TabIndex = 24
        Me.lblTitMONTO_PRIMA.Text = "Monto de la prima"
        '
        'lblTitFAX_COMPANIA
        '
        Me.lblTitFAX_COMPANIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFAX_COMPANIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFAX_COMPANIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFAX_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFAX_COMPANIA.Location = New System.Drawing.Point(348, 125)
        Me.lblTitFAX_COMPANIA.Name = "lblTitFAX_COMPANIA"
        Me.lblTitFAX_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFAX_COMPANIA.Size = New System.Drawing.Size(102, 14)
        Me.lblTitFAX_COMPANIA.TabIndex = 25
        Me.lblTitFAX_COMPANIA.Text = "Fax aseguradora"
        '
        'lblTitTELEFONO_COMPANIA
        '
        Me.lblTitTELEFONO_COMPANIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTELEFONO_COMPANIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTELEFONO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTELEFONO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTELEFONO_COMPANIA.Location = New System.Drawing.Point(6, 125)
        Me.lblTitTELEFONO_COMPANIA.Name = "lblTitTELEFONO_COMPANIA"
        Me.lblTitTELEFONO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTELEFONO_COMPANIA.Size = New System.Drawing.Size(153, 14)
        Me.lblTitTELEFONO_COMPANIA.TabIndex = 26
        Me.lblTitTELEFONO_COMPANIA.Text = "Teléfono aseguradora"
        '
        'lblTitCONTACTO_COMPANIA
        '
        Me.lblTitCONTACTO_COMPANIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCONTACTO_COMPANIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCONTACTO_COMPANIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCONTACTO_COMPANIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCONTACTO_COMPANIA.Location = New System.Drawing.Point(6, 99)
        Me.lblTitCONTACTO_COMPANIA.Name = "lblTitCONTACTO_COMPANIA"
        Me.lblTitCONTACTO_COMPANIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCONTACTO_COMPANIA.Size = New System.Drawing.Size(153, 14)
        Me.lblTitCONTACTO_COMPANIA.TabIndex = 27
        Me.lblTitCONTACTO_COMPANIA.Text = "Nombre del contacto"
        '
        'lblTitCOMPANIA_SEGUROS
        '
        Me.lblTitCOMPANIA_SEGUROS.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOMPANIA_SEGUROS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOMPANIA_SEGUROS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOMPANIA_SEGUROS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOMPANIA_SEGUROS.Location = New System.Drawing.Point(6, 73)
        Me.lblTitCOMPANIA_SEGUROS.Name = "lblTitCOMPANIA_SEGUROS"
        Me.lblTitCOMPANIA_SEGUROS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOMPANIA_SEGUROS.Size = New System.Drawing.Size(153, 14)
        Me.lblTitCOMPANIA_SEGUROS.TabIndex = 30
        Me.lblTitCOMPANIA_SEGUROS.Text = "Compañia de seguros"
        '
        'lblTitFECHA_F_VIGENCIA
        '
        Me.lblTitFECHA_F_VIGENCIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_F_VIGENCIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_F_VIGENCIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_F_VIGENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_F_VIGENCIA.Location = New System.Drawing.Point(6, 230)
        Me.lblTitFECHA_F_VIGENCIA.Name = "lblTitFECHA_F_VIGENCIA"
        Me.lblTitFECHA_F_VIGENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_F_VIGENCIA.Size = New System.Drawing.Size(153, 14)
        Me.lblTitFECHA_F_VIGENCIA.TabIndex = 34
        Me.lblTitFECHA_F_VIGENCIA.Text = "Fecha final  de vigencia"
        '
        'lblTitFECHA_I_VIGENCIA
        '
        Me.lblTitFECHA_I_VIGENCIA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_I_VIGENCIA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_I_VIGENCIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_I_VIGENCIA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_I_VIGENCIA.Location = New System.Drawing.Point(6, 204)
        Me.lblTitFECHA_I_VIGENCIA.Name = "lblTitFECHA_I_VIGENCIA"
        Me.lblTitFECHA_I_VIGENCIA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_I_VIGENCIA.Size = New System.Drawing.Size(153, 14)
        Me.lblTitFECHA_I_VIGENCIA.TabIndex = 33
        Me.lblTitFECHA_I_VIGENCIA.Text = "Fecha inicial de vigencia"
        '
        'lblTitNO_ENDOSO
        '
        Me.lblTitNO_ENDOSO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_ENDOSO.Location = New System.Drawing.Point(6, 47)
        Me.lblTitNO_ENDOSO.Name = "lblTitNO_ENDOSO"
        Me.lblTitNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_ENDOSO.Size = New System.Drawing.Size(153, 14)
        Me.lblTitNO_ENDOSO.TabIndex = 32
        Me.lblTitNO_ENDOSO.Text = "Número de endoso"
        '
        'lblTitNUMERO_POLIZA
        '
        Me.lblTitNUMERO_POLIZA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_POLIZA.Location = New System.Drawing.Point(6, 21)
        Me.lblTitNUMERO_POLIZA.Name = "lblTitNUMERO_POLIZA"
        Me.lblTitNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_POLIZA.Size = New System.Drawing.Size(153, 14)
        Me.lblTitNUMERO_POLIZA.TabIndex = 31
        Me.lblTitNUMERO_POLIZA.Text = "Número de póliza"
        '
        'lblTitNOMBRE_CORREDOR
        '
        Me.lblTitNOMBRE_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNOMBRE_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNOMBRE_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNOMBRE_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNOMBRE_CORREDOR.Location = New System.Drawing.Point(6, 21)
        Me.lblTitNOMBRE_CORREDOR.Name = "lblTitNOMBRE_CORREDOR"
        Me.lblTitNOMBRE_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNOMBRE_CORREDOR.Size = New System.Drawing.Size(153, 14)
        Me.lblTitNOMBRE_CORREDOR.TabIndex = 20
        Me.lblTitNOMBRE_CORREDOR.Text = "Nombre"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtFAX_CORREDOR)
        Me.Frame2.Controls.Add(Me.txtTELEFONO_CORREDOR)
        Me.Frame2.Controls.Add(Me.txtCONTACTO_CORREDOR)
        Me.Frame2.Controls.Add(Me.txtNOMBRE_CORREDOR)
        Me.Frame2.Controls.Add(Me.lblTitFAX_CORREDOR)
        Me.Frame2.Controls.Add(Me.lblTitTELEFONO_CORREDOR)
        Me.Frame2.Controls.Add(Me.lblTitCONTACTO_CORREDOR)
        Me.Frame2.Controls.Add(Me.lblTitNOMBRE_CORREDOR)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(12, 273)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(611, 111)
        Me.Frame2.TabIndex = 33
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " Datos del corredor "
        '
        'txtFAX_CORREDOR
        '
        Me.txtFAX_CORREDOR.AcceptsReturn = True
        Me.txtFAX_CORREDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtFAX_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFAX_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFAX_CORREDOR.Enabled = False
        Me.txtFAX_CORREDOR.EsRequerido = False
        Me.txtFAX_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFAX_CORREDOR.LabelConsulta = Nothing
        Me.txtFAX_CORREDOR.Location = New System.Drawing.Point(456, 71)
        Me.txtFAX_CORREDOR.MaxLength = 15
        Me.txtFAX_CORREDOR.Name = "txtFAX_CORREDOR"
        Me.txtFAX_CORREDOR.NombreDeConsulta = Nothing
        Me.txtFAX_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFAX_CORREDOR.Size = New System.Drawing.Size(149, 20)
        Me.txtFAX_CORREDOR.TabIndex = 14
        Me.txtFAX_CORREDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTELEFONO_CORREDOR
        '
        Me.txtTELEFONO_CORREDOR.AcceptsReturn = True
        Me.txtTELEFONO_CORREDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtTELEFONO_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTELEFONO_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTELEFONO_CORREDOR.Enabled = False
        Me.txtTELEFONO_CORREDOR.EsRequerido = False
        Me.txtTELEFONO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTELEFONO_CORREDOR.LabelConsulta = Nothing
        Me.txtTELEFONO_CORREDOR.Location = New System.Drawing.Point(165, 71)
        Me.txtTELEFONO_CORREDOR.MaxLength = 15
        Me.txtTELEFONO_CORREDOR.Name = "txtTELEFONO_CORREDOR"
        Me.txtTELEFONO_CORREDOR.NombreDeConsulta = Nothing
        Me.txtTELEFONO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTELEFONO_CORREDOR.Size = New System.Drawing.Size(149, 20)
        Me.txtTELEFONO_CORREDOR.TabIndex = 13
        Me.txtTELEFONO_CORREDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCONTACTO_CORREDOR
        '
        Me.txtCONTACTO_CORREDOR.AcceptsReturn = True
        Me.txtCONTACTO_CORREDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtCONTACTO_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCONTACTO_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCONTACTO_CORREDOR.Enabled = False
        Me.txtCONTACTO_CORREDOR.EsRequerido = False
        Me.txtCONTACTO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONTACTO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCONTACTO_CORREDOR.LabelConsulta = Nothing
        Me.txtCONTACTO_CORREDOR.Location = New System.Drawing.Point(165, 45)
        Me.txtCONTACTO_CORREDOR.MaxLength = 40
        Me.txtCONTACTO_CORREDOR.Name = "txtCONTACTO_CORREDOR"
        Me.txtCONTACTO_CORREDOR.NombreDeConsulta = Nothing
        Me.txtCONTACTO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCONTACTO_CORREDOR.Size = New System.Drawing.Size(348, 20)
        Me.txtCONTACTO_CORREDOR.TabIndex = 12
        '
        'txtNOMBRE_CORREDOR
        '
        Me.txtNOMBRE_CORREDOR.AcceptsReturn = True
        Me.txtNOMBRE_CORREDOR.BackColor = System.Drawing.SystemColors.Window
        Me.txtNOMBRE_CORREDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE_CORREDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNOMBRE_CORREDOR.Enabled = False
        Me.txtNOMBRE_CORREDOR.EsRequerido = False
        Me.txtNOMBRE_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNOMBRE_CORREDOR.LabelConsulta = Nothing
        Me.txtNOMBRE_CORREDOR.Location = New System.Drawing.Point(165, 19)
        Me.txtNOMBRE_CORREDOR.MaxLength = 40
        Me.txtNOMBRE_CORREDOR.Name = "txtNOMBRE_CORREDOR"
        Me.txtNOMBRE_CORREDOR.NombreDeConsulta = Nothing
        Me.txtNOMBRE_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNOMBRE_CORREDOR.Size = New System.Drawing.Size(348, 20)
        Me.txtNOMBRE_CORREDOR.TabIndex = 11
        '
        'lblTitFAX_CORREDOR
        '
        Me.lblTitFAX_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFAX_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFAX_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFAX_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFAX_CORREDOR.Location = New System.Drawing.Point(348, 73)
        Me.lblTitFAX_CORREDOR.Name = "lblTitFAX_CORREDOR"
        Me.lblTitFAX_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFAX_CORREDOR.Size = New System.Drawing.Size(102, 14)
        Me.lblTitFAX_CORREDOR.TabIndex = 17
        Me.lblTitFAX_CORREDOR.Text = "Número de Fax"
        '
        'lblTitTELEFONO_CORREDOR
        '
        Me.lblTitTELEFONO_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTELEFONO_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTELEFONO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTELEFONO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTELEFONO_CORREDOR.Location = New System.Drawing.Point(6, 73)
        Me.lblTitTELEFONO_CORREDOR.Name = "lblTitTELEFONO_CORREDOR"
        Me.lblTitTELEFONO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTELEFONO_CORREDOR.Size = New System.Drawing.Size(153, 14)
        Me.lblTitTELEFONO_CORREDOR.TabIndex = 18
        Me.lblTitTELEFONO_CORREDOR.Text = "Teléfono"
        '
        'lblTitCONTACTO_CORREDOR
        '
        Me.lblTitCONTACTO_CORREDOR.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCONTACTO_CORREDOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCONTACTO_CORREDOR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCONTACTO_CORREDOR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCONTACTO_CORREDOR.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCONTACTO_CORREDOR.Name = "lblTitCONTACTO_CORREDOR"
        Me.lblTitCONTACTO_CORREDOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCONTACTO_CORREDOR.Size = New System.Drawing.Size(153, 14)
        Me.lblTitCONTACTO_CORREDOR.TabIndex = 19
        Me.lblTitCONTACTO_CORREDOR.Text = "Contacto"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(536, 390)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 31
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTSEEM2
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(635, 426)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTSEEM2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de pólizas de seguros - ACTSEEM2"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents mskfechaf As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents txtCODIGO_DE_MONEDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtTOTAL_SEGURO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtMONTO_PRIMA As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtFAX_COMPANIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTELEFONO_COMPANIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCONTACTO_COMPANIA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtCOMPANIA_SEGUROS As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNO_ENDOSO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNUMERO_POLIZA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblnombremoneda As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitTOTAL_SEGURO As System.Windows.Forms.Label
    Public WithEvents lblTitMONTO_PRIMA As System.Windows.Forms.Label
    Public WithEvents lblTitFAX_COMPANIA As System.Windows.Forms.Label
    Public WithEvents lblTitTELEFONO_COMPANIA As System.Windows.Forms.Label
    Public WithEvents lblTitCONTACTO_COMPANIA As System.Windows.Forms.Label
    Public WithEvents lblTitCOMPANIA_SEGUROS As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_F_VIGENCIA As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_I_VIGENCIA As System.Windows.Forms.Label
    Public WithEvents lblTitNO_ENDOSO As System.Windows.Forms.Label
    Public WithEvents lblTitNUMERO_POLIZA As System.Windows.Forms.Label
    Public WithEvents lblTitNOMBRE_CORREDOR As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtFAX_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTELEFONO_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCONTACTO_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNOMBRE_CORREDOR As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitFAX_CORREDOR As System.Windows.Forms.Label
    Public WithEvents lblTitTELEFONO_CORREDOR As System.Windows.Forms.Label
    Public WithEvents lblTitCONTACTO_CORREDOR As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents mskfechai As Citi.Synergia.UIGenerico.SynTextoFecha
End Class
