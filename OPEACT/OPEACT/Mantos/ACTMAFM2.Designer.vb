<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFM2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colActivoFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMontoRevaluacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTasaDeCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValorOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValorActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltitporcentaje = New System.Windows.Forms.Label()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDESC_REVALUACION = New System.Windows.Forms.Label()
        Me.lblCODIGO_REVALUACION = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFECHA_CALCULO = New System.Windows.Forms.Label()
        Me.lblCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDESCRIP_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_TIPO_ACTIVO = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Agrupacion = New System.Windows.Forms.GroupBox()
        Me._Campo_4 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me._Campo_3 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me._Campo_2 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me._Campo_1 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
        Me.lblCODIGO_DIVISION = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colActivoFijo, Me.colDescripcion, Me.colMontoRevaluacion, Me.colTasaDeCambio, Me.colValorOriginal, Me.colValorActual})
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.Grid.Location = New System.Drawing.Point(12, 116)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersVisible = False
        Me.Grid.Size = New System.Drawing.Size(519, 305)
        Me.Grid.TabIndex = 23
        '
        'colActivoFijo
        '
        Me.colActivoFijo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.colActivoFijo.DefaultCellStyle = DataGridViewCellStyle2
        Me.colActivoFijo.Frozen = True
        Me.colActivoFijo.HeaderText = "Activo Fijo"
        Me.colActivoFijo.Name = "colActivoFijo"
        Me.colActivoFijo.ReadOnly = True
        Me.colActivoFijo.Width = 81
        '
        'colDescripcion
        '
        Me.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colDescripcion.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        Me.colDescripcion.Width = 88
        '
        'colMontoRevaluacion
        '
        Me.colMontoRevaluacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.colMontoRevaluacion.DefaultCellStyle = DataGridViewCellStyle4
        Me.colMontoRevaluacion.HeaderText = "Monto Revaluación"
        Me.colMontoRevaluacion.Name = "colMontoRevaluacion"
        Me.colMontoRevaluacion.Width = 125
        '
        'colTasaDeCambio
        '
        Me.colTasaDeCambio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N5"
        DataGridViewCellStyle5.NullValue = "0"
        Me.colTasaDeCambio.DefaultCellStyle = DataGridViewCellStyle5
        Me.colTasaDeCambio.HeaderText = "Tasa de Cambio"
        Me.colTasaDeCambio.Name = "colTasaDeCambio"
        Me.colTasaDeCambio.ReadOnly = True
        Me.colTasaDeCambio.Width = 109
        '
        'colValorOriginal
        '
        Me.colValorOriginal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.colValorOriginal.DefaultCellStyle = DataGridViewCellStyle6
        Me.colValorOriginal.HeaderText = "Valor Original"
        Me.colValorOriginal.Name = "colValorOriginal"
        Me.colValorOriginal.ReadOnly = True
        Me.colValorOriginal.Width = 94
        '
        'colValorActual
        '
        Me.colValorActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.colValorActual.DefaultCellStyle = DataGridViewCellStyle7
        Me.colValorActual.HeaderText = "Valor Actual"
        Me.colValorActual.Name = "colValorActual"
        Me.colValorActual.ReadOnly = True
        Me.colValorActual.Width = 89
        '
        'lbltitporcentaje
        '
        Me.lbltitporcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lbltitporcentaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitporcentaje.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitporcentaje.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitporcentaje.Location = New System.Drawing.Point(12, 82)
        Me.lbltitporcentaje.Name = "lbltitporcentaje"
        Me.lbltitporcentaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitporcentaje.Size = New System.Drawing.Size(147, 20)
        Me.lbltitporcentaje.TabIndex = 32
        Me.lbltitporcentaje.Text = "Porcentaje aplicado"
        '
        'lblporcentaje
        '
        Me.lblporcentaje.BackColor = System.Drawing.SystemColors.Window
        Me.lblporcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblporcentaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblporcentaje.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporcentaje.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblporcentaje.Location = New System.Drawing.Point(165, 81)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblporcentaje.Size = New System.Drawing.Size(98, 20)
        Me.lblporcentaje.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(12, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Código revaluación"
        '
        'lblDESC_REVALUACION
        '
        Me.lblDESC_REVALUACION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESC_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESC_REVALUACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESC_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESC_REVALUACION.Location = New System.Drawing.Point(269, 10)
        Me.lblDESC_REVALUACION.Name = "lblDESC_REVALUACION"
        Me.lblDESC_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESC_REVALUACION.Size = New System.Drawing.Size(262, 20)
        Me.lblDESC_REVALUACION.TabIndex = 29
        Me.lblDESC_REVALUACION.UseMnemonic = False
        '
        'lblCODIGO_REVALUACION
        '
        Me.lblCODIGO_REVALUACION.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_REVALUACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_REVALUACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_REVALUACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_REVALUACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_REVALUACION.Location = New System.Drawing.Point(165, 9)
        Me.lblCODIGO_REVALUACION.Name = "lblCODIGO_REVALUACION"
        Me.lblCODIGO_REVALUACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_REVALUACION.Size = New System.Drawing.Size(98, 20)
        Me.lblCODIGO_REVALUACION.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(269, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "(DD/MM/AAAA)"
        '
        'lblFECHA_CALCULO
        '
        Me.lblFECHA_CALCULO.BackColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_CALCULO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFECHA_CALCULO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_CALCULO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_CALCULO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFECHA_CALCULO.Location = New System.Drawing.Point(165, 57)
        Me.lblFECHA_CALCULO.Name = "lblFECHA_CALCULO"
        Me.lblFECHA_CALCULO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_CALCULO.Size = New System.Drawing.Size(98, 20)
        Me.lblFECHA_CALCULO.TabIndex = 26
        '
        'lblCODIGO_TIPO_ACTIVO
        '
        Me.lblCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_TIPO_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(165, 33)
        Me.lblCODIGO_TIPO_ACTIVO.Name = "lblCODIGO_TIPO_ACTIVO"
        Me.lblCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(98, 20)
        Me.lblCODIGO_TIPO_ACTIVO.TabIndex = 25
        Me.lblCODIGO_TIPO_ACTIVO.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Fecha revaluación"
        '
        'lblDESCRIP_TIPO_ACTIVO
        '
        Me.lblDESCRIP_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIP_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIP_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIP_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIP_TIPO_ACTIVO.Location = New System.Drawing.Point(269, 34)
        Me.lblDESCRIP_TIPO_ACTIVO.Name = "lblDESCRIP_TIPO_ACTIVO"
        Me.lblDESCRIP_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIP_TIPO_ACTIVO.Size = New System.Drawing.Size(262, 20)
        Me.lblDESCRIP_TIPO_ACTIVO.TabIndex = 21
        Me.lblDESCRIP_TIPO_ACTIVO.UseMnemonic = False
        Me.lblDESCRIP_TIPO_ACTIVO.Visible = False
        '
        'lblTitCODIGO_TIPO_ACTIVO
        '
        Me.lblTitCODIGO_TIPO_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_TIPO_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_TIPO_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_TIPO_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_TIPO_ACTIVO.Location = New System.Drawing.Point(12, 34)
        Me.lblTitCODIGO_TIPO_ACTIVO.Name = "lblTitCODIGO_TIPO_ACTIVO"
        Me.lblTitCODIGO_TIPO_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_TIPO_ACTIVO.Size = New System.Drawing.Size(147, 20)
        Me.lblTitCODIGO_TIPO_ACTIVO.TabIndex = 22
        Me.lblTitCODIGO_TIPO_ACTIVO.Text = "Tipo de activo"
        Me.lblTitCODIGO_TIPO_ACTIVO.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(444, 85)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 33
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Agrupacion
        '
        Me.Agrupacion.BackColor = System.Drawing.SystemColors.Control
        Me.Agrupacion.Controls.Add(Me._Campo_4)
        Me.Agrupacion.Controls.Add(Me._Campo_3)
        Me.Agrupacion.Controls.Add(Me._Campo_2)
        Me.Agrupacion.Controls.Add(Me._Campo_1)
        Me.Agrupacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Agrupacion.Location = New System.Drawing.Point(280, 465)
        Me.Agrupacion.Name = "Agrupacion"
        Me.Agrupacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Agrupacion.Size = New System.Drawing.Size(185, 33)
        Me.Agrupacion.TabIndex = 37
        Me.Agrupacion.TabStop = False
        Me.Agrupacion.Text = "Nombres de Campos en Tag "
        Me.Agrupacion.Visible = False
        '
        '_Campo_4
        '
        Me._Campo_4.AcceptsReturn = True
        Me._Campo_4.BackColor = System.Drawing.SystemColors.Window
        Me._Campo_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Campo_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Campo_4.Enabled = False
        Me._Campo_4.EsRequerido = False
        Me._Campo_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Campo_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Campo_4.LabelConsulta = Nothing
        Me._Campo_4.Location = New System.Drawing.Point(110, 12)
        Me._Campo_4.MaxLength = 5
        Me._Campo_4.Multiline = True
        Me._Campo_4.Name = "_Campo_4"
        Me._Campo_4.NombreDeConsulta = Nothing
        Me._Campo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Campo_4.Size = New System.Drawing.Size(13, 21)
        Me._Campo_4.TabIndex = 19
        Me._Campo_4.Tag = "TASA_REVALUACION"
        Me._Campo_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Campo_4.Visible = False
        '
        '_Campo_3
        '
        Me._Campo_3.AcceptsReturn = True
        Me._Campo_3.BackColor = System.Drawing.SystemColors.Window
        Me._Campo_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Campo_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Campo_3.Enabled = False
        Me._Campo_3.EsRequerido = False
        Me._Campo_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Campo_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Campo_3.LabelConsulta = Nothing
        Me._Campo_3.Location = New System.Drawing.Point(94, 12)
        Me._Campo_3.MaxLength = 5
        Me._Campo_3.Multiline = True
        Me._Campo_3.Name = "_Campo_3"
        Me._Campo_3.NombreDeConsulta = Nothing
        Me._Campo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Campo_3.Size = New System.Drawing.Size(13, 21)
        Me._Campo_3.TabIndex = 18
        Me._Campo_3.Tag = "MONTO_REVALUACION"
        Me._Campo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Campo_3.Visible = False
        '
        '_Campo_2
        '
        Me._Campo_2.AcceptsReturn = True
        Me._Campo_2.BackColor = System.Drawing.SystemColors.Window
        Me._Campo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Campo_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Campo_2.Enabled = False
        Me._Campo_2.EsRequerido = False
        Me._Campo_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Campo_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Campo_2.LabelConsulta = Nothing
        Me._Campo_2.Location = New System.Drawing.Point(78, 12)
        Me._Campo_2.MaxLength = 5
        Me._Campo_2.Multiline = True
        Me._Campo_2.Name = "_Campo_2"
        Me._Campo_2.NombreDeConsulta = Nothing
        Me._Campo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Campo_2.Size = New System.Drawing.Size(13, 21)
        Me._Campo_2.TabIndex = 17
        Me._Campo_2.Tag = "MEJORA_CORRELATIVO"
        Me._Campo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Campo_2.Visible = False
        '
        '_Campo_1
        '
        Me._Campo_1.AcceptsReturn = True
        Me._Campo_1.BackColor = System.Drawing.SystemColors.Window
        Me._Campo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Campo_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Campo_1.Enabled = False
        Me._Campo_1.EsRequerido = False
        Me._Campo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Campo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Campo_1.LabelConsulta = Nothing
        Me._Campo_1.Location = New System.Drawing.Point(62, 12)
        Me._Campo_1.MaxLength = 5
        Me._Campo_1.Multiline = True
        Me._Campo_1.Name = "_Campo_1"
        Me._Campo_1.NombreDeConsulta = Nothing
        Me._Campo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Campo_1.Size = New System.Drawing.Size(13, 21)
        Me._Campo_1.TabIndex = 16
        Me._Campo_1.Tag = "CODIGO_DE_ACTIVO"
        Me._Campo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._Campo_1.Visible = False
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.AutoSize = True
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(12, 500)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(80, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 34
        Me.lblTitCODIGO_DIVISION.Text = "Codigo Division"
        Me.lblTitCODIGO_DIVISION.Visible = False
        '
        'lblDESCRIPCION_DIVISION
        '
        Me.lblDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_DIVISION.Location = New System.Drawing.Point(269, 501)
        Me.lblDESCRIPCION_DIVISION.Name = "lblDESCRIPCION_DIVISION"
        Me.lblDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_DIVISION.Size = New System.Drawing.Size(262, 21)
        Me.lblDESCRIPCION_DIVISION.TabIndex = 35
        Me.lblDESCRIPCION_DIVISION.Visible = False
        '
        'lblCODIGO_DIVISION
        '
        Me.lblCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DIVISION.Location = New System.Drawing.Point(165, 500)
        Me.lblCODIGO_DIVISION.Name = "lblCODIGO_DIVISION"
        Me.lblCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DIVISION.Size = New System.Drawing.Size(98, 21)
        Me.lblCODIGO_DIVISION.TabIndex = 36
        Me.lblCODIGO_DIVISION.Visible = False
        '
        'ACTMAFM2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 433)
        Me.Controls.Add(Me.Agrupacion)
        Me.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.Controls.Add(Me.lblDESCRIPCION_DIVISION)
        Me.Controls.Add(Me.lblCODIGO_DIVISION)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.lbltitporcentaje)
        Me.Controls.Add(Me.lblporcentaje)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDESC_REVALUACION)
        Me.Controls.Add(Me.lblCODIGO_REVALUACION)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFECHA_CALCULO)
        Me.Controls.Add(Me.lblCODIGO_TIPO_ACTIVO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDESCRIP_TIPO_ACTIVO)
        Me.Controls.Add(Me.lblTitCODIGO_TIPO_ACTIVO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMAFM2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revaluación activos fijos - ACTMAFM2"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion.ResumeLayout(False)
        Me.Agrupacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Grid As System.Windows.Forms.DataGridView
    Public WithEvents lbltitporcentaje As System.Windows.Forms.Label
    Public WithEvents lblporcentaje As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lblDESC_REVALUACION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_REVALUACION As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblFECHA_CALCULO As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblDESCRIP_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_TIPO_ACTIVO As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents Agrupacion As System.Windows.Forms.GroupBox
    Public WithEvents _Campo_4 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents _Campo_3 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents _Campo_2 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents _Campo_1 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DIVISION As System.Windows.Forms.Label
    Friend WithEvents colActivoFijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMontoRevaluacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTasaDeCambio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValorOriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValorActual As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
