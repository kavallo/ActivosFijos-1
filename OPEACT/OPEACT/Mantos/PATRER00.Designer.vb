<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PATRER00
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
        Me.OP3 = New System.Windows.Forms.RadioButton()
        Me.OP2 = New System.Windows.Forms.RadioButton()
        Me.OP1 = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtANO_PERIODO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNO_PERIODO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNUMERO_PARTIDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitNUMERO_POLIZA = New System.Windows.Forms.Label()
        Me.lblTitNO_ENDOSO = New System.Windows.Forms.Label()
        Me.lblTitCOMPANIA_SEGUROS = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.varDORIGEN = New System.Windows.Forms.Label()
        Me.var4ORIGEN = New System.Windows.Forms.Label()
        Me.lblTitORIGEN4 = New System.Windows.Forms.Label()
        Me.var3ORIGEN = New System.Windows.Forms.Label()
        Me.lblTitORIGEN3 = New System.Windows.Forms.Label()
        Me.var2ORIGEN = New System.Windows.Forms.Label()
        Me.lblTitORIGEN2 = New System.Windows.Forms.Label()
        Me.lblTitORIGEN1 = New System.Windows.Forms.Label()
        Me.var1ORIGEN = New System.Windows.Forms.Label()
        Me.lbltitORIGEN5 = New System.Windows.Forms.Label()
        Me.var5ORIGEN = New System.Windows.Forms.Label()
        Me.lbltitORIGEN6 = New System.Windows.Forms.Label()
        Me.var6ORIGEN = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
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
        Me.Frame3.Controls.Add(Me.OP3)
        Me.Frame3.Controls.Add(Me.OP2)
        Me.Frame3.Controls.Add(Me.OP1)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame3.Location = New System.Drawing.Point(12, 268)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(389, 57)
        Me.Frame3.TabIndex = 2
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Ordenamiento del reporte"
        '
        'OP3
        '
        Me.OP3.BackColor = System.Drawing.SystemColors.Control
        Me.OP3.Cursor = System.Windows.Forms.Cursors.Default
        Me.OP3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OP3.Location = New System.Drawing.Point(263, 16)
        Me.OP3.Name = "OP3"
        Me.OP3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OP3.Size = New System.Drawing.Size(116, 33)
        Me.OP3.TabIndex = 4
        Me.OP3.TabStop = True
        Me.OP3.Text = "Cta. contable"
        Me.OP3.UseVisualStyleBackColor = False
        '
        'OP2
        '
        Me.OP2.BackColor = System.Drawing.SystemColors.Control
        Me.OP2.Cursor = System.Windows.Forms.Cursors.Default
        Me.OP2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OP2.Location = New System.Drawing.Point(136, 16)
        Me.OP2.Name = "OP2"
        Me.OP2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OP2.Size = New System.Drawing.Size(116, 33)
        Me.OP2.TabIndex = 3
        Me.OP2.TabStop = True
        Me.OP2.Text = "Sec. ingreso"
        Me.OP2.UseVisualStyleBackColor = False
        '
        'OP1
        '
        Me.OP1.BackColor = System.Drawing.SystemColors.Control
        Me.OP1.Checked = True
        Me.OP1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OP1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OP1.Location = New System.Drawing.Point(9, 16)
        Me.OP1.Name = "OP1"
        Me.OP1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OP1.Size = New System.Drawing.Size(116, 33)
        Me.OP1.TabIndex = 2
        Me.OP1.TabStop = True
        Me.OP1.Text = "Débito y crédito"
        Me.OP1.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtANO_PERIODO)
        Me.Frame2.Controls.Add(Me.txtNO_PERIODO)
        Me.Frame2.Controls.Add(Me.txtNUMERO_PARTIDA)
        Me.Frame2.Controls.Add(Me.lblTitNUMERO_POLIZA)
        Me.Frame2.Controls.Add(Me.lblTitNO_ENDOSO)
        Me.Frame2.Controls.Add(Me.lblTitCOMPANIA_SEGUROS)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(12, 157)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(389, 105)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Partida de trabajo identificada"
        '
        'txtANO_PERIODO
        '
        Me.txtANO_PERIODO.AcceptsReturn = True
        Me.txtANO_PERIODO.BackColor = System.Drawing.SystemColors.Window
        Me.txtANO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtANO_PERIODO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtANO_PERIODO.Enabled = False
        Me.txtANO_PERIODO.EsRequerido = False
        Me.txtANO_PERIODO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtANO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtANO_PERIODO.LabelConsulta = Nothing
        Me.txtANO_PERIODO.Location = New System.Drawing.Point(82, 24)
        Me.txtANO_PERIODO.MaxLength = 20
        Me.txtANO_PERIODO.Name = "txtANO_PERIODO"
        Me.txtANO_PERIODO.NombreDeConsulta = Nothing
        Me.txtANO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtANO_PERIODO.Size = New System.Drawing.Size(301, 20)
        Me.txtANO_PERIODO.TabIndex = 1
        '
        'txtNO_PERIODO
        '
        Me.txtNO_PERIODO.AcceptsReturn = True
        Me.txtNO_PERIODO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNO_PERIODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNO_PERIODO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNO_PERIODO.Enabled = False
        Me.txtNO_PERIODO.EsRequerido = False
        Me.txtNO_PERIODO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNO_PERIODO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNO_PERIODO.LabelConsulta = Nothing
        Me.txtNO_PERIODO.Location = New System.Drawing.Point(82, 48)
        Me.txtNO_PERIODO.MaxLength = 15
        Me.txtNO_PERIODO.Name = "txtNO_PERIODO"
        Me.txtNO_PERIODO.NombreDeConsulta = Nothing
        Me.txtNO_PERIODO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNO_PERIODO.Size = New System.Drawing.Size(301, 20)
        Me.txtNO_PERIODO.TabIndex = 2
        '
        'txtNUMERO_PARTIDA
        '
        Me.txtNUMERO_PARTIDA.AcceptsReturn = True
        Me.txtNUMERO_PARTIDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUMERO_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_PARTIDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_PARTIDA.Enabled = False
        Me.txtNUMERO_PARTIDA.EsRequerido = False
        Me.txtNUMERO_PARTIDA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_PARTIDA.LabelConsulta = Nothing
        Me.txtNUMERO_PARTIDA.Location = New System.Drawing.Point(82, 72)
        Me.txtNUMERO_PARTIDA.MaxLength = 40
        Me.txtNUMERO_PARTIDA.Name = "txtNUMERO_PARTIDA"
        Me.txtNUMERO_PARTIDA.NombreDeConsulta = Nothing
        Me.txtNUMERO_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_PARTIDA.Size = New System.Drawing.Size(301, 20)
        Me.txtNUMERO_PARTIDA.TabIndex = 3
        '
        'lblTitNUMERO_POLIZA
        '
        Me.lblTitNUMERO_POLIZA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_POLIZA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_POLIZA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_POLIZA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_POLIZA.Location = New System.Drawing.Point(6, 26)
        Me.lblTitNUMERO_POLIZA.Name = "lblTitNUMERO_POLIZA"
        Me.lblTitNUMERO_POLIZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_POLIZA.Size = New System.Drawing.Size(70, 14)
        Me.lblTitNUMERO_POLIZA.TabIndex = 25
        Me.lblTitNUMERO_POLIZA.Text = "Año período"
        '
        'lblTitNO_ENDOSO
        '
        Me.lblTitNO_ENDOSO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNO_ENDOSO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNO_ENDOSO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNO_ENDOSO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNO_ENDOSO.Location = New System.Drawing.Point(6, 50)
        Me.lblTitNO_ENDOSO.Name = "lblTitNO_ENDOSO"
        Me.lblTitNO_ENDOSO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNO_ENDOSO.Size = New System.Drawing.Size(70, 14)
        Me.lblTitNO_ENDOSO.TabIndex = 24
        Me.lblTitNO_ENDOSO.Text = "No. período"
        '
        'lblTitCOMPANIA_SEGUROS
        '
        Me.lblTitCOMPANIA_SEGUROS.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCOMPANIA_SEGUROS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCOMPANIA_SEGUROS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCOMPANIA_SEGUROS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCOMPANIA_SEGUROS.Location = New System.Drawing.Point(6, 74)
        Me.lblTitCOMPANIA_SEGUROS.Name = "lblTitCOMPANIA_SEGUROS"
        Me.lblTitCOMPANIA_SEGUROS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCOMPANIA_SEGUROS.Size = New System.Drawing.Size(70, 14)
        Me.lblTitCOMPANIA_SEGUROS.TabIndex = 23
        Me.lblTitCOMPANIA_SEGUROS.Text = "No. partida"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.varDORIGEN)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(222, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(179, 128)
        Me.Frame1.TabIndex = 41
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Documento Origen"
        '
        'varDORIGEN
        '
        Me.varDORIGEN.BackColor = System.Drawing.SystemColors.Window
        Me.varDORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.varDORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.varDORIGEN.Font = New System.Drawing.Font("Arial", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varDORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.varDORIGEN.Location = New System.Drawing.Point(6, 16)
        Me.varDORIGEN.Name = "varDORIGEN"
        Me.varDORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.varDORIGEN.Size = New System.Drawing.Size(167, 109)
        Me.varDORIGEN.TabIndex = 18
        Me.varDORIGEN.Text = "MM"
        Me.varDORIGEN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'var4ORIGEN
        '
        Me.var4ORIGEN.BackColor = System.Drawing.SystemColors.Window
        Me.var4ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.var4ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.var4ORIGEN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var4ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.var4ORIGEN.Location = New System.Drawing.Point(86, 80)
        Me.var4ORIGEN.Name = "var4ORIGEN"
        Me.var4ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.var4ORIGEN.Size = New System.Drawing.Size(130, 20)
        Me.var4ORIGEN.TabIndex = 40
        Me.var4ORIGEN.Text = "codigo origen4"
        '
        'lblTitORIGEN4
        '
        Me.lblTitORIGEN4.BackColor = System.Drawing.Color.Transparent
        Me.lblTitORIGEN4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN4.Location = New System.Drawing.Point(9, 81)
        Me.lblTitORIGEN4.Name = "lblTitORIGEN4"
        Me.lblTitORIGEN4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN4.Size = New System.Drawing.Size(71, 17)
        Me.lblTitORIGEN4.TabIndex = 39
        Me.lblTitORIGEN4.Text = "4  "
        Me.lblTitORIGEN4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'var3ORIGEN
        '
        Me.var3ORIGEN.BackColor = System.Drawing.SystemColors.Window
        Me.var3ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.var3ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.var3ORIGEN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var3ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.var3ORIGEN.Location = New System.Drawing.Point(86, 60)
        Me.var3ORIGEN.Name = "var3ORIGEN"
        Me.var3ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.var3ORIGEN.Size = New System.Drawing.Size(130, 20)
        Me.var3ORIGEN.TabIndex = 38
        Me.var3ORIGEN.Text = "codigo origen3"
        '
        'lblTitORIGEN3
        '
        Me.lblTitORIGEN3.BackColor = System.Drawing.Color.Transparent
        Me.lblTitORIGEN3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN3.Location = New System.Drawing.Point(9, 61)
        Me.lblTitORIGEN3.Name = "lblTitORIGEN3"
        Me.lblTitORIGEN3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN3.Size = New System.Drawing.Size(71, 17)
        Me.lblTitORIGEN3.TabIndex = 37
        Me.lblTitORIGEN3.Text = "3  "
        Me.lblTitORIGEN3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'var2ORIGEN
        '
        Me.var2ORIGEN.BackColor = System.Drawing.SystemColors.Window
        Me.var2ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.var2ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.var2ORIGEN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var2ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.var2ORIGEN.Location = New System.Drawing.Point(86, 40)
        Me.var2ORIGEN.Name = "var2ORIGEN"
        Me.var2ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.var2ORIGEN.Size = New System.Drawing.Size(130, 20)
        Me.var2ORIGEN.TabIndex = 36
        Me.var2ORIGEN.Text = "codigo origen 2"
        '
        'lblTitORIGEN2
        '
        Me.lblTitORIGEN2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitORIGEN2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN2.Location = New System.Drawing.Point(9, 41)
        Me.lblTitORIGEN2.Name = "lblTitORIGEN2"
        Me.lblTitORIGEN2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN2.Size = New System.Drawing.Size(71, 17)
        Me.lblTitORIGEN2.TabIndex = 35
        Me.lblTitORIGEN2.Text = "2  "
        Me.lblTitORIGEN2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitORIGEN1
        '
        Me.lblTitORIGEN1.BackColor = System.Drawing.Color.Transparent
        Me.lblTitORIGEN1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitORIGEN1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitORIGEN1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitORIGEN1.Location = New System.Drawing.Point(9, 20)
        Me.lblTitORIGEN1.Name = "lblTitORIGEN1"
        Me.lblTitORIGEN1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitORIGEN1.Size = New System.Drawing.Size(71, 17)
        Me.lblTitORIGEN1.TabIndex = 33
        Me.lblTitORIGEN1.Text = "Origen  1"
        '
        'var1ORIGEN
        '
        Me.var1ORIGEN.BackColor = System.Drawing.SystemColors.Window
        Me.var1ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.var1ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.var1ORIGEN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var1ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.var1ORIGEN.Location = New System.Drawing.Point(86, 20)
        Me.var1ORIGEN.Name = "var1ORIGEN"
        Me.var1ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.var1ORIGEN.Size = New System.Drawing.Size(130, 20)
        Me.var1ORIGEN.TabIndex = 34
        Me.var1ORIGEN.Text = "codigo origen1"
        '
        'lbltitORIGEN5
        '
        Me.lbltitORIGEN5.BackColor = System.Drawing.Color.Transparent
        Me.lbltitORIGEN5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitORIGEN5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitORIGEN5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitORIGEN5.Location = New System.Drawing.Point(9, 101)
        Me.lbltitORIGEN5.Name = "lbltitORIGEN5"
        Me.lbltitORIGEN5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitORIGEN5.Size = New System.Drawing.Size(71, 17)
        Me.lbltitORIGEN5.TabIndex = 32
        Me.lbltitORIGEN5.Text = "5  "
        Me.lbltitORIGEN5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'var5ORIGEN
        '
        Me.var5ORIGEN.BackColor = System.Drawing.SystemColors.Window
        Me.var5ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.var5ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.var5ORIGEN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var5ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.var5ORIGEN.Location = New System.Drawing.Point(86, 100)
        Me.var5ORIGEN.Name = "var5ORIGEN"
        Me.var5ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.var5ORIGEN.Size = New System.Drawing.Size(130, 20)
        Me.var5ORIGEN.TabIndex = 31
        Me.var5ORIGEN.Text = "codigo origen5"
        '
        'lbltitORIGEN6
        '
        Me.lbltitORIGEN6.BackColor = System.Drawing.Color.Transparent
        Me.lbltitORIGEN6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitORIGEN6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitORIGEN6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitORIGEN6.Location = New System.Drawing.Point(9, 121)
        Me.lbltitORIGEN6.Name = "lbltitORIGEN6"
        Me.lbltitORIGEN6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitORIGEN6.Size = New System.Drawing.Size(71, 17)
        Me.lbltitORIGEN6.TabIndex = 30
        Me.lbltitORIGEN6.Text = "6  "
        Me.lbltitORIGEN6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'var6ORIGEN
        '
        Me.var6ORIGEN.BackColor = System.Drawing.SystemColors.Window
        Me.var6ORIGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.var6ORIGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.var6ORIGEN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var6ORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.var6ORIGEN.Location = New System.Drawing.Point(86, 120)
        Me.var6ORIGEN.Name = "var6ORIGEN"
        Me.var6ORIGEN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.var6ORIGEN.Size = New System.Drawing.Size(130, 20)
        Me.var6ORIGEN.TabIndex = 29
        Me.var6ORIGEN.Text = "codigo origen6"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(314, 331)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "@16"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(221, 331)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(87, 25)
        Me.cmdOk.TabIndex = 3
        Me.cmdOk.Text = "@15"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'PATRER00
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(413, 368)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.var4ORIGEN)
        Me.Controls.Add(Me.lblTitORIGEN4)
        Me.Controls.Add(Me.var3ORIGEN)
        Me.Controls.Add(Me.lblTitORIGEN3)
        Me.Controls.Add(Me.var2ORIGEN)
        Me.Controls.Add(Me.lblTitORIGEN2)
        Me.Controls.Add(Me.lblTitORIGEN1)
        Me.Controls.Add(Me.var1ORIGEN)
        Me.Controls.Add(Me.lbltitORIGEN5)
        Me.Controls.Add(Me.var5ORIGEN)
        Me.Controls.Add(Me.lbltitORIGEN6)
        Me.Controls.Add(Me.var6ORIGEN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "PATRER00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión partida de trabajo desde origenes - PATRER00"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents OP3 As System.Windows.Forms.RadioButton
    Public WithEvents OP2 As System.Windows.Forms.RadioButton
    Public WithEvents OP1 As System.Windows.Forms.RadioButton
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtANO_PERIODO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNO_PERIODO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNUMERO_PARTIDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitNUMERO_POLIZA As System.Windows.Forms.Label
    Public WithEvents lblTitNO_ENDOSO As System.Windows.Forms.Label
    Public WithEvents lblTitCOMPANIA_SEGUROS As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents varDORIGEN As System.Windows.Forms.Label
    Public WithEvents var4ORIGEN As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN4 As System.Windows.Forms.Label
    Public WithEvents var3ORIGEN As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN3 As System.Windows.Forms.Label
    Public WithEvents var2ORIGEN As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN2 As System.Windows.Forms.Label
    Public WithEvents lblTitORIGEN1 As System.Windows.Forms.Label
    Public WithEvents var1ORIGEN As System.Windows.Forms.Label
    Public WithEvents lbltitORIGEN5 As System.Windows.Forms.Label
    Public WithEvents var5ORIGEN As System.Windows.Forms.Label
    Public WithEvents lbltitORIGEN6 As System.Windows.Forms.Label
    Public WithEvents var6ORIGEN As System.Windows.Forms.Label
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOk As System.Windows.Forms.Button
End Class
