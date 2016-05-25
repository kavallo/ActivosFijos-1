<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTRVEM1
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
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cboESTADO_REVALUACION = New System.Windows.Forms.ComboBox()
        Me.cboTIPO_DE_REVALUACION = New System.Windows.Forms.ComboBox()
        Me.txtporcentaje = New System.Windows.Forms.TextBox()
        Me.lblTitESTADO_REVALUACION = New System.Windows.Forms.Label()
        Me.lblTitUSUARIO_AUTORIZACION = New System.Windows.Forms.Label()
        Me.lblTitFECHA_AUTORIZACION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitTIPO_DE_REVALUACION = New System.Windows.Forms.Label()
        Me.lblTitFECHA_DE_REVALUACION = New System.Windows.Forms.Label()
        Me.lblTitDESC_REVALUACION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_REVALUACION = New System.Windows.Forms.Label()
        Me.lblUSUARIO_AUTORIZACION = New System.Windows.Forms.Label()
        Me.lblFECHA_AUTORIZACION = New System.Windows.Forms.Label()
        Me.lblDESCRIP_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblDESC_REVALUACION = New System.Windows.Forms.Label()
        Me.lblCODIGO_REVALUACION = New System.Windows.Forms.Label()
        Me.lblFECHA_DE_REVALUACION = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cboESTADO_REVALUACION)
        Me.Frame1.Controls.Add(Me.cboTIPO_DE_REVALUACION)
        Me.Frame1.Controls.Add(Me.txtporcentaje)
        Me.Frame1.Controls.Add(Me.lblTitESTADO_REVALUACION)
        Me.Frame1.Controls.Add(Me.lblTitUSUARIO_AUTORIZACION)
        Me.Frame1.Controls.Add(Me.lblTitFECHA_AUTORIZACION)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_TIPO_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitTIPO_DE_REVALUACION)
        Me.Frame1.Controls.Add(Me.lblTitFECHA_DE_REVALUACION)
        Me.Frame1.Controls.Add(Me.lblTitDESC_REVALUACION)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_REVALUACION)
        Me.Frame1.Controls.Add(Me.lblUSUARIO_AUTORIZACION)
        Me.Frame1.Controls.Add(Me.lblFECHA_AUTORIZACION)
        Me.Frame1.Controls.Add(Me.lblDESCRIP_TIPO_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblCODIGO_TIPO_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblDESC_REVALUACION)
        Me.Frame1.Controls.Add(Me.lblCODIGO_REVALUACION)
        Me.Frame1.Controls.Add(Me.lblFECHA_DE_REVALUACION)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.lblporcentaje)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.Frame1.Controls.Add(Me.lblCODIGO_DIVISION)
        Me.Frame1.Controls.Add(Me.lblDESCRIPCION_DIVISION)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(649, 265)
        Me.Frame1.TabIndex = 22
        Me.Frame1.TabStop = False
        '
        'cboESTADO_REVALUACION
        '
        Me.cboESTADO_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboESTADO_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboESTADO_REVALUACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboESTADO_REVALUACION.Enabled = False
        Me.cboESTADO_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboESTADO_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboESTADO_REVALUACION.Location = New System.Drawing.Point(154, 234)
        Me.cboESTADO_REVALUACION.Name = "cboESTADO_REVALUACION"
        Me.cboESTADO_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboESTADO_REVALUACION.Size = New System.Drawing.Size(251, 22)
        Me.cboESTADO_REVALUACION.TabIndex = 24
        '
        'cboTIPO_DE_REVALUACION
        '
        Me.cboTIPO_DE_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboTIPO_DE_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTIPO_DE_REVALUACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTIPO_DE_REVALUACION.Enabled = False
        Me.cboTIPO_DE_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTIPO_DE_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTIPO_DE_REVALUACION.Location = New System.Drawing.Point(154, 97)
        Me.cboTIPO_DE_REVALUACION.Name = "cboTIPO_DE_REVALUACION"
        Me.cboTIPO_DE_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTIPO_DE_REVALUACION.Size = New System.Drawing.Size(251, 22)
        Me.cboTIPO_DE_REVALUACION.TabIndex = 23
        '
        'txtporcentaje
        '
        Me.txtporcentaje.AcceptsReturn = True
        Me.txtporcentaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtporcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtporcentaje.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtporcentaje.Enabled = False
        Me.txtporcentaje.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtporcentaje.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtporcentaje.Location = New System.Drawing.Point(154, 153)
        Me.txtporcentaje.MaxLength = 0
        Me.txtporcentaje.Multiline = True
        Me.txtporcentaje.Name = "txtporcentaje"
        Me.txtporcentaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtporcentaje.Size = New System.Drawing.Size(110, 20)
        Me.txtporcentaje.TabIndex = 22
        Me.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitESTADO_REVALUACION
        '
        Me.lblTitESTADO_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTADO_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTADO_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTADO_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTADO_REVALUACION.Location = New System.Drawing.Point(6, 237)
        Me.lblTitESTADO_REVALUACION.Name = "lblTitESTADO_REVALUACION"
        Me.lblTitESTADO_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTADO_REVALUACION.Size = New System.Drawing.Size(142, 14)
        Me.lblTitESTADO_REVALUACION.TabIndex = 0
        Me.lblTitESTADO_REVALUACION.Text = "Estado"
        '
        'lblTitUSUARIO_AUTORIZACION
        '
        Me.lblTitUSUARIO_AUTORIZACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitUSUARIO_AUTORIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitUSUARIO_AUTORIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitUSUARIO_AUTORIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitUSUARIO_AUTORIZACION.Location = New System.Drawing.Point(6, 208)
        Me.lblTitUSUARIO_AUTORIZACION.Name = "lblTitUSUARIO_AUTORIZACION"
        Me.lblTitUSUARIO_AUTORIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitUSUARIO_AUTORIZACION.Size = New System.Drawing.Size(142, 14)
        Me.lblTitUSUARIO_AUTORIZACION.TabIndex = 1
        Me.lblTitUSUARIO_AUTORIZACION.Text = "Usuario"
        '
        'lblTitFECHA_AUTORIZACION
        '
        Me.lblTitFECHA_AUTORIZACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_AUTORIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_AUTORIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_AUTORIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_AUTORIZACION.Location = New System.Drawing.Point(6, 181)
        Me.lblTitFECHA_AUTORIZACION.Name = "lblTitFECHA_AUTORIZACION"
        Me.lblTitFECHA_AUTORIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_AUTORIZACION.Size = New System.Drawing.Size(142, 14)
        Me.lblTitFECHA_AUTORIZACION.TabIndex = 2
        Me.lblTitFECHA_AUTORIZACION.Text = "Fecha actulización"
        '
        'lblTitCODIGO_TIPO_ACTIVO
        '
        Me.lblTitCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(6, 127)
        Me.lblTitCODIGO_TIPO_ACTIVO.Name = "lblTitCODIGO_TIPO_ACTIVO"
        Me.lblTitCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(142, 14)
        Me.lblTitCODIGO_TIPO_ACTIVO.TabIndex = 4
        Me.lblTitCODIGO_TIPO_ACTIVO.Text = "Tipo de activo"
        '
        'lblTitTIPO_DE_REVALUACION
        '
        Me.lblTitTIPO_DE_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_DE_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_DE_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_DE_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_DE_REVALUACION.Location = New System.Drawing.Point(6, 100)
        Me.lblTitTIPO_DE_REVALUACION.Name = "lblTitTIPO_DE_REVALUACION"
        Me.lblTitTIPO_DE_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_DE_REVALUACION.Size = New System.Drawing.Size(142, 14)
        Me.lblTitTIPO_DE_REVALUACION.TabIndex = 5
        Me.lblTitTIPO_DE_REVALUACION.Text = "Tipo de revaluación"
        '
        'lblTitFECHA_DE_REVALUACION
        '
        Me.lblTitFECHA_DE_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_DE_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_DE_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_DE_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_DE_REVALUACION.Location = New System.Drawing.Point(6, 71)
        Me.lblTitFECHA_DE_REVALUACION.Name = "lblTitFECHA_DE_REVALUACION"
        Me.lblTitFECHA_DE_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_DE_REVALUACION.Size = New System.Drawing.Size(142, 14)
        Me.lblTitFECHA_DE_REVALUACION.TabIndex = 6
        Me.lblTitFECHA_DE_REVALUACION.Text = "Fecha revaluación"
        '
        'lblTitDESC_REVALUACION
        '
        Me.lblTitDESC_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESC_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESC_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESC_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESC_REVALUACION.Location = New System.Drawing.Point(6, 44)
        Me.lblTitDESC_REVALUACION.Name = "lblTitDESC_REVALUACION"
        Me.lblTitDESC_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESC_REVALUACION.Size = New System.Drawing.Size(142, 14)
        Me.lblTitDESC_REVALUACION.TabIndex = 7
        Me.lblTitDESC_REVALUACION.Text = "Descripción"
        '
        'lblTitCODIGO_REVALUACION
        '
        Me.lblTitCODIGO_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_REVALUACION.Location = New System.Drawing.Point(6, 17)
        Me.lblTitCODIGO_REVALUACION.Name = "lblTitCODIGO_REVALUACION"
        Me.lblTitCODIGO_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_REVALUACION.Size = New System.Drawing.Size(142, 14)
        Me.lblTitCODIGO_REVALUACION.TabIndex = 8
        Me.lblTitCODIGO_REVALUACION.Text = "Código revaluación"
        '
        'lblUSUARIO_AUTORIZACION
        '
        Me.lblUSUARIO_AUTORIZACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblUSUARIO_AUTORIZACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUSUARIO_AUTORIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUSUARIO_AUTORIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIO_AUTORIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUSUARIO_AUTORIZACION.Location = New System.Drawing.Point(154, 207)
        Me.lblUSUARIO_AUTORIZACION.Name = "lblUSUARIO_AUTORIZACION"
        Me.lblUSUARIO_AUTORIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUSUARIO_AUTORIZACION.Size = New System.Drawing.Size(110, 20)
        Me.lblUSUARIO_AUTORIZACION.TabIndex = 9
        '
        'lblFECHA_AUTORIZACION
        '
        Me.lblFECHA_AUTORIZACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_AUTORIZACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_AUTORIZACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_AUTORIZACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_AUTORIZACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_AUTORIZACION.Location = New System.Drawing.Point(154, 180)
        Me.lblFECHA_AUTORIZACION.Name = "lblFECHA_AUTORIZACION"
        Me.lblFECHA_AUTORIZACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_AUTORIZACION.Size = New System.Drawing.Size(110, 20)
        Me.lblFECHA_AUTORIZACION.TabIndex = 10
        '
        'lblDESCRIP_TIPO_ACTIVO
        '
        Me.lblDESCRIP_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIP_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIP_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIP_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIP_TIPO_ACTIVO.Location = New System.Drawing.Point(270, 127)
        Me.lblDESCRIP_TIPO_ACTIVO.Name = "lblDESCRIP_TIPO_ACTIVO"
        Me.lblDESCRIP_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIP_TIPO_ACTIVO.Size = New System.Drawing.Size(373, 20)
        Me.lblDESCRIP_TIPO_ACTIVO.TabIndex = 13
        Me.lblDESCRIP_TIPO_ACTIVO.UseMnemonic = False
        '
        'lblCODIGO_TIPO_ACTIVO
        '
        Me.lblCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_TIPO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(154, 126)
        Me.lblCODIGO_TIPO_ACTIVO.Name = "lblCODIGO_TIPO_ACTIVO"
        Me.lblCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(110, 20)
        Me.lblCODIGO_TIPO_ACTIVO.TabIndex = 14
        '
        'lblDESC_REVALUACION
        '
        Me.lblDESC_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblDESC_REVALUACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDESC_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESC_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESC_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESC_REVALUACION.Location = New System.Drawing.Point(154, 43)
        Me.lblDESC_REVALUACION.Name = "lblDESC_REVALUACION"
        Me.lblDESC_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESC_REVALUACION.Size = New System.Drawing.Size(347, 20)
        Me.lblDESC_REVALUACION.TabIndex = 15
        '
        'lblCODIGO_REVALUACION
        '
        Me.lblCODIGO_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_REVALUACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_REVALUACION.Location = New System.Drawing.Point(154, 16)
        Me.lblCODIGO_REVALUACION.Name = "lblCODIGO_REVALUACION"
        Me.lblCODIGO_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_REVALUACION.Size = New System.Drawing.Size(110, 20)
        Me.lblCODIGO_REVALUACION.TabIndex = 16
        Me.lblCODIGO_REVALUACION.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFECHA_DE_REVALUACION
        '
        Me.lblFECHA_DE_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_DE_REVALUACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_DE_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_DE_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_DE_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_DE_REVALUACION.Location = New System.Drawing.Point(154, 70)
        Me.lblFECHA_DE_REVALUACION.Name = "lblFECHA_DE_REVALUACION"
        Me.lblFECHA_DE_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_DE_REVALUACION.Size = New System.Drawing.Size(110, 20)
        Me.lblFECHA_DE_REVALUACION.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(270, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "(DD/MM/AAAA)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(270, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "(DD/MM/AAAA)"
        '
        'lblporcentaje
        '
        Me.lblporcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblporcentaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblporcentaje.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporcentaje.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblporcentaje.Location = New System.Drawing.Point(6, 155)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblporcentaje.Size = New System.Drawing.Size(142, 14)
        Me.lblporcentaje.TabIndex = 20
        Me.lblporcentaje.Text = "Porcentaje a aplicar"
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.AutoSize = True
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(6, 127)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(79, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 3
        Me.lblTitCODIGO_DIVISION.Text = "Código division"
        '
        'lblCODIGO_DIVISION
        '
        Me.lblCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DIVISION.Location = New System.Drawing.Point(154, 126)
        Me.lblCODIGO_DIVISION.Name = "lblCODIGO_DIVISION"
        Me.lblCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DIVISION.Size = New System.Drawing.Size(110, 20)
        Me.lblCODIGO_DIVISION.TabIndex = 12
        '
        'lblDESCRIPCION_DIVISION
        '
        Me.lblDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_DIVISION.Location = New System.Drawing.Point(270, 127)
        Me.lblDESCRIPCION_DIVISION.Name = "lblDESCRIPCION_DIVISION"
        Me.lblDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_DIVISION.Size = New System.Drawing.Size(373, 20)
        Me.lblDESCRIPCION_DIVISION.TabIndex = 11
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(574, 283)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 25
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTRVEM1
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(673, 320)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTRVEM1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de datos de revaluación - ACTRVEM1"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cboESTADO_REVALUACION As System.Windows.Forms.ComboBox
    Public WithEvents cboTIPO_DE_REVALUACION As System.Windows.Forms.ComboBox
    Public WithEvents txtporcentaje As System.Windows.Forms.TextBox
    Public WithEvents lblTitESTADO_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblTitUSUARIO_AUTORIZACION As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_AUTORIZACION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_DE_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_DE_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblTitDESC_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblUSUARIO_AUTORIZACION As System.Windows.Forms.Label
    Public WithEvents lblFECHA_AUTORIZACION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIP_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblDESC_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblFECHA_DE_REVALUACION As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblporcentaje As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
