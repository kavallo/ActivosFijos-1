<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFN2
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento  'System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.txtTipoActivoInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtTipoActivoFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblNombreProveedorFinal = New System.Windows.Forms.Label()
        Me.lblTipoActivoInicial = New System.Windows.Forms.Label()
        Me.lblTipoActivoFinal = New System.Windows.Forms.Label()
        Me.txtDivisionInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblNombreTipoInicial = New System.Windows.Forms.Label()
        Me.txtDivisionFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDivisionInicial = New System.Windows.Forms.Label()
        Me.lblNombreTipoFinal = New System.Windows.Forms.Label()
        Me.grpTipoActivo = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtProveedorFinal = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtProveedorInicial = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblNombreDivisionInicial = New System.Windows.Forms.Label()
        Me.lblNombreProveedorInicial = New System.Windows.Forms.Label()
        Me.lblProveedorFinal = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblProveedorInicial = New System.Windows.Forms.Label()
        Me.grpProveedor = New System.Windows.Forms.GroupBox()
        Me.grpActivoFijo = New System.Windows.Forms.GroupBox()
        Me.txtActivoFinal = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtActivoInicial = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblActivoFijoFinal = New System.Windows.Forms.Label()
        Me.lblActivoFijoInicial = New System.Windows.Forms.Label()
        Me.lblDivisionFinal = New System.Windows.Forms.Label()
        Me.lblNombreDivisionFinal = New System.Windows.Forms.Label()
        Me.grpDivision = New System.Windows.Forms.GroupBox()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoActivo.SuspendLayout()
        Me.grpProveedor.SuspendLayout()
        Me.grpActivoFijo.SuspendLayout()
        Me.grpDivision.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTipoActivoInicial
        '
        Me.txtTipoActivoInicial.AcceptsReturn = True
        Me.txtTipoActivoInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoActivoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoActivoInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoActivoInicial.EsRequerido = False
        Me.txtTipoActivoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoActivoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoActivoInicial.LabelConsulta = Nothing
        Me.txtTipoActivoInicial.Location = New System.Drawing.Point(102, 19)
        Me.txtTipoActivoInicial.MaxLength = 7
        Me.txtTipoActivoInicial.Name = "txtTipoActivoInicial"
        Me.txtTipoActivoInicial.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtTipoActivoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoActivoInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtTipoActivoInicial.TabIndex = 1
        '
        'txtTipoActivoFinal
        '
        Me.txtTipoActivoFinal.AcceptsReturn = True
        Me.txtTipoActivoFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoActivoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoActivoFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoActivoFinal.EsRequerido = False
        Me.txtTipoActivoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoActivoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoActivoFinal.LabelConsulta = Nothing
        Me.txtTipoActivoFinal.Location = New System.Drawing.Point(102, 45)
        Me.txtTipoActivoFinal.MaxLength = 7
        Me.txtTipoActivoFinal.Name = "txtTipoActivoFinal"
        Me.txtTipoActivoFinal.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtTipoActivoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoActivoFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtTipoActivoFinal.TabIndex = 2
        '
        'lblNombreProveedorFinal
        '
        Me.lblNombreProveedorFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreProveedorFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreProveedorFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProveedorFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreProveedorFinal.Location = New System.Drawing.Point(188, 47)
        Me.lblNombreProveedorFinal.Name = "lblNombreProveedorFinal"
        Me.lblNombreProveedorFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreProveedorFinal.Size = New System.Drawing.Size(318, 20)
        Me.lblNombreProveedorFinal.TabIndex = 19
        Me.lblNombreProveedorFinal.UseMnemonic = False
        '
        'lblTipoActivoInicial
        '
        Me.lblTipoActivoInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoActivoInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoActivoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoActivoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoActivoInicial.Location = New System.Drawing.Point(6, 21)
        Me.lblTipoActivoInicial.Name = "lblTipoActivoInicial"
        Me.lblTipoActivoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoActivoInicial.Size = New System.Drawing.Size(90, 17)
        Me.lblTipoActivoInicial.TabIndex = 16
        Me.lblTipoActivoInicial.Text = "[Inicial]"
        '
        'lblTipoActivoFinal
        '
        Me.lblTipoActivoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoActivoFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoActivoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoActivoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoActivoFinal.Location = New System.Drawing.Point(6, 47)
        Me.lblTipoActivoFinal.Name = "lblTipoActivoFinal"
        Me.lblTipoActivoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoActivoFinal.Size = New System.Drawing.Size(90, 17)
        Me.lblTipoActivoFinal.TabIndex = 17
        Me.lblTipoActivoFinal.Text = "[Final]"
        '
        'txtDivisionInicial
        '
        Me.txtDivisionInicial.AcceptsReturn = True
        Me.txtDivisionInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtDivisionInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDivisionInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDivisionInicial.EsRequerido = False
        Me.txtDivisionInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDivisionInicial.LabelConsulta = Nothing
        Me.txtDivisionInicial.Location = New System.Drawing.Point(102, 19)
        Me.txtDivisionInicial.MaxLength = 10
        Me.txtDivisionInicial.Name = "txtDivisionInicial"
        Me.txtDivisionInicial.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtDivisionInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDivisionInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtDivisionInicial.TabIndex = 1
        '
        'lblNombreTipoInicial
        '
        Me.lblNombreTipoInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreTipoInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoInicial.Location = New System.Drawing.Point(188, 21)
        Me.lblNombreTipoInicial.Name = "lblNombreTipoInicial"
        Me.lblNombreTipoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoInicial.Size = New System.Drawing.Size(318, 20)
        Me.lblNombreTipoInicial.TabIndex = 18
        Me.lblNombreTipoInicial.UseMnemonic = False
        '
        'txtDivisionFinal
        '
        Me.txtDivisionFinal.AcceptsReturn = True
        Me.txtDivisionFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtDivisionFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDivisionFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDivisionFinal.EsRequerido = False
        Me.txtDivisionFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDivisionFinal.LabelConsulta = Nothing
        Me.txtDivisionFinal.Location = New System.Drawing.Point(102, 45)
        Me.txtDivisionFinal.MaxLength = 10
        Me.txtDivisionFinal.Name = "txtDivisionFinal"
        Me.txtDivisionFinal.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtDivisionFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDivisionFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtDivisionFinal.TabIndex = 2
        '
        'lblDivisionInicial
        '
        Me.lblDivisionInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblDivisionInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDivisionInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDivisionInicial.Location = New System.Drawing.Point(6, 21)
        Me.lblDivisionInicial.Name = "lblDivisionInicial"
        Me.lblDivisionInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDivisionInicial.Size = New System.Drawing.Size(90, 17)
        Me.lblDivisionInicial.TabIndex = 11
        Me.lblDivisionInicial.Text = "[Inicial]"
        '
        'lblNombreTipoFinal
        '
        Me.lblNombreTipoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreTipoFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreTipoFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreTipoFinal.Location = New System.Drawing.Point(188, 47)
        Me.lblNombreTipoFinal.Name = "lblNombreTipoFinal"
        Me.lblNombreTipoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreTipoFinal.Size = New System.Drawing.Size(318, 20)
        Me.lblNombreTipoFinal.TabIndex = 14
        Me.lblNombreTipoFinal.UseMnemonic = False
        '
        'grpTipoActivo
        '
        Me.grpTipoActivo.BackColor = System.Drawing.SystemColors.Control
        Me.grpTipoActivo.Controls.Add(Me.txtTipoActivoInicial)
        Me.grpTipoActivo.Controls.Add(Me.txtTipoActivoFinal)
        Me.grpTipoActivo.Controls.Add(Me.lblTipoActivoInicial)
        Me.grpTipoActivo.Controls.Add(Me.lblTipoActivoFinal)
        Me.grpTipoActivo.Controls.Add(Me.lblNombreTipoInicial)
        Me.grpTipoActivo.Controls.Add(Me.lblNombreTipoFinal)
        Me.grpTipoActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipoActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpTipoActivo.Location = New System.Drawing.Point(12, 89)
        Me.grpTipoActivo.Name = "grpTipoActivo"
        Me.grpTipoActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpTipoActivo.Size = New System.Drawing.Size(512, 71)
        Me.grpTipoActivo.TabIndex = 2
        Me.grpTipoActivo.TabStop = False
        Me.grpTipoActivo.Text = "Tipo de activo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(447, 320)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(77, 25)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(364, 320)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(77, 25)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'txtProveedorFinal
        '
        Me.txtProveedorFinal.AcceptsReturn = True
        Me.txtProveedorFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtProveedorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedorFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProveedorFinal.EsRequerido = False
        Me.txtProveedorFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProveedorFinal.LabelConsulta = Nothing
        Me.txtProveedorFinal.Location = New System.Drawing.Point(102, 45)
        Me.txtProveedorFinal.MaxLength = 10
        Me.txtProveedorFinal.Name = "txtProveedorFinal"
        Me.txtProveedorFinal.NombreDeConsulta = Nothing
        Me.txtProveedorFinal.NumeroDecimales = 0
        Me.txtProveedorFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProveedorFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtProveedorFinal.TabIndex = 2
        Me.txtProveedorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProveedorInicial
        '
        Me.txtProveedorInicial.AcceptsReturn = True
        Me.txtProveedorInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtProveedorInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedorInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProveedorInicial.EsRequerido = False
        Me.txtProveedorInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProveedorInicial.LabelConsulta = Nothing
        Me.txtProveedorInicial.Location = New System.Drawing.Point(102, 19)
        Me.txtProveedorInicial.MaxLength = 10
        Me.txtProveedorInicial.Name = "txtProveedorInicial"
        Me.txtProveedorInicial.NombreDeConsulta = Nothing
        Me.txtProveedorInicial.NumeroDecimales = 0
        Me.txtProveedorInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProveedorInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtProveedorInicial.TabIndex = 1
        Me.txtProveedorInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNombreDivisionInicial
        '
        Me.lblNombreDivisionInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreDivisionInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreDivisionInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDivisionInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreDivisionInicial.Location = New System.Drawing.Point(188, 21)
        Me.lblNombreDivisionInicial.Name = "lblNombreDivisionInicial"
        Me.lblNombreDivisionInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreDivisionInicial.Size = New System.Drawing.Size(318, 20)
        Me.lblNombreDivisionInicial.TabIndex = 13
        Me.lblNombreDivisionInicial.UseMnemonic = False
        '
        'lblNombreProveedorInicial
        '
        Me.lblNombreProveedorInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreProveedorInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreProveedorInicial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProveedorInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreProveedorInicial.Location = New System.Drawing.Point(188, 21)
        Me.lblNombreProveedorInicial.Name = "lblNombreProveedorInicial"
        Me.lblNombreProveedorInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreProveedorInicial.Size = New System.Drawing.Size(318, 20)
        Me.lblNombreProveedorInicial.TabIndex = 20
        Me.lblNombreProveedorInicial.UseMnemonic = False
        '
        'lblProveedorFinal
        '
        Me.lblProveedorFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblProveedorFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProveedorFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedorFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblProveedorFinal.Location = New System.Drawing.Point(6, 47)
        Me.lblProveedorFinal.Name = "lblProveedorFinal"
        Me.lblProveedorFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProveedorFinal.Size = New System.Drawing.Size(90, 17)
        Me.lblProveedorFinal.TabIndex = 27
        Me.lblProveedorFinal.Text = "[Final]"
        '
        'lblProveedorInicial
        '
        Me.lblProveedorInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblProveedorInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProveedorInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedorInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblProveedorInicial.Location = New System.Drawing.Point(6, 21)
        Me.lblProveedorInicial.Name = "lblProveedorInicial"
        Me.lblProveedorInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProveedorInicial.Size = New System.Drawing.Size(90, 17)
        Me.lblProveedorInicial.TabIndex = 24
        Me.lblProveedorInicial.Text = "[Inicial]"
        '
        'grpProveedor
        '
        Me.grpProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.grpProveedor.Controls.Add(Me.txtProveedorFinal)
        Me.grpProveedor.Controls.Add(Me.txtProveedorInicial)
        Me.grpProveedor.Controls.Add(Me.lblNombreProveedorFinal)
        Me.grpProveedor.Controls.Add(Me.lblNombreProveedorInicial)
        Me.grpProveedor.Controls.Add(Me.lblProveedorFinal)
        Me.grpProveedor.Controls.Add(Me.lblProveedorInicial)
        Me.grpProveedor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProveedor.ForeColor = System.Drawing.Color.Black
        Me.grpProveedor.Location = New System.Drawing.Point(12, 243)
        Me.grpProveedor.Name = "grpProveedor"
        Me.grpProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpProveedor.Size = New System.Drawing.Size(512, 71)
        Me.grpProveedor.TabIndex = 4
        Me.grpProveedor.TabStop = False
        Me.grpProveedor.Text = "Proveedor"
        '
        'grpActivoFijo
        '
        Me.grpActivoFijo.BackColor = System.Drawing.SystemColors.Control
        Me.grpActivoFijo.Controls.Add(Me.txtActivoFinal)
        Me.grpActivoFijo.Controls.Add(Me.txtActivoInicial)
        Me.grpActivoFijo.Controls.Add(Me.lblActivoFijoFinal)
        Me.grpActivoFijo.Controls.Add(Me.lblActivoFijoInicial)
        Me.grpActivoFijo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpActivoFijo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpActivoFijo.Location = New System.Drawing.Point(12, 12)
        Me.grpActivoFijo.Name = "grpActivoFijo"
        Me.grpActivoFijo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpActivoFijo.Size = New System.Drawing.Size(512, 71)
        Me.grpActivoFijo.TabIndex = 1
        Me.grpActivoFijo.TabStop = False
        Me.grpActivoFijo.Text = "Activo fijo"
        '
        'txtActivoFinal
        '
        Me.txtActivoFinal.AcceptsReturn = True
        Me.txtActivoFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtActivoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActivoFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtActivoFinal.EsRequerido = False
        Me.txtActivoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtActivoFinal.LabelConsulta = Nothing
        Me.txtActivoFinal.Location = New System.Drawing.Point(102, 45)
        Me.txtActivoFinal.MaxLength = 15
        Me.txtActivoFinal.Name = "txtActivoFinal"
        Me.txtActivoFinal.NombreDeConsulta = Nothing
        Me.txtActivoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActivoFinal.Size = New System.Drawing.Size(125, 20)
        Me.txtActivoFinal.TabIndex = 2
        '
        'txtActivoInicial
        '
        Me.txtActivoInicial.AcceptsReturn = True
        Me.txtActivoInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtActivoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActivoInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtActivoInicial.EsRequerido = False
        Me.txtActivoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtActivoInicial.LabelConsulta = Nothing
        Me.txtActivoInicial.Location = New System.Drawing.Point(102, 19)
        Me.txtActivoInicial.MaxLength = 15
        Me.txtActivoInicial.Name = "txtActivoInicial"
        Me.txtActivoInicial.NombreDeConsulta = Nothing
        Me.txtActivoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActivoInicial.Size = New System.Drawing.Size(125, 20)
        Me.txtActivoInicial.TabIndex = 1
        '
        'lblActivoFijoFinal
        '
        Me.lblActivoFijoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblActivoFijoFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblActivoFijoFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivoFijoFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblActivoFijoFinal.Location = New System.Drawing.Point(6, 47)
        Me.lblActivoFijoFinal.Name = "lblActivoFijoFinal"
        Me.lblActivoFijoFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblActivoFijoFinal.Size = New System.Drawing.Size(90, 17)
        Me.lblActivoFijoFinal.TabIndex = 26
        Me.lblActivoFijoFinal.Text = "[Final]"
        '
        'lblActivoFijoInicial
        '
        Me.lblActivoFijoInicial.BackColor = System.Drawing.SystemColors.Control
        Me.lblActivoFijoInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblActivoFijoInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivoFijoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblActivoFijoInicial.Location = New System.Drawing.Point(6, 21)
        Me.lblActivoFijoInicial.Name = "lblActivoFijoInicial"
        Me.lblActivoFijoInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblActivoFijoInicial.Size = New System.Drawing.Size(90, 17)
        Me.lblActivoFijoInicial.TabIndex = 25
        Me.lblActivoFijoInicial.Text = "[Inicial]"
        '
        'lblDivisionFinal
        '
        Me.lblDivisionFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblDivisionFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDivisionFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDivisionFinal.Location = New System.Drawing.Point(6, 47)
        Me.lblDivisionFinal.Name = "lblDivisionFinal"
        Me.lblDivisionFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDivisionFinal.Size = New System.Drawing.Size(90, 17)
        Me.lblDivisionFinal.TabIndex = 12
        Me.lblDivisionFinal.Text = "[Final]"
        '
        'lblNombreDivisionFinal
        '
        Me.lblNombreDivisionFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreDivisionFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreDivisionFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDivisionFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreDivisionFinal.Location = New System.Drawing.Point(188, 47)
        Me.lblNombreDivisionFinal.Name = "lblNombreDivisionFinal"
        Me.lblNombreDivisionFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreDivisionFinal.Size = New System.Drawing.Size(318, 20)
        Me.lblNombreDivisionFinal.TabIndex = 15
        Me.lblNombreDivisionFinal.UseMnemonic = False
        '
        'grpDivision
        '
        Me.grpDivision.BackColor = System.Drawing.SystemColors.Control
        Me.grpDivision.Controls.Add(Me.txtDivisionInicial)
        Me.grpDivision.Controls.Add(Me.txtDivisionFinal)
        Me.grpDivision.Controls.Add(Me.lblDivisionInicial)
        Me.grpDivision.Controls.Add(Me.lblDivisionFinal)
        Me.grpDivision.Controls.Add(Me.lblNombreDivisionInicial)
        Me.grpDivision.Controls.Add(Me.lblNombreDivisionFinal)
        Me.grpDivision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDivision.ForeColor = System.Drawing.Color.Black
        Me.grpDivision.Location = New System.Drawing.Point(12, 166)
        Me.grpDivision.Name = "grpDivision"
        Me.grpDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDivision.Size = New System.Drawing.Size(512, 71)
        Me.grpDivision.TabIndex = 3
        Me.grpDivision.TabStop = False
        Me.grpDivision.Text = "Departamento"
        '
        'ACTMAFN2
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(536, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpTipoActivo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grpProveedor)
        Me.Controls.Add(Me.grpActivoFijo)
        Me.Controls.Add(Me.grpDivision)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Location = New System.Drawing.Point(118, 111)
        Me.MaximizeBox = False
        Me.Name = "ACTMAFN2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información general de activos - ACTMAFN2"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoActivo.ResumeLayout(False)
        Me.grpTipoActivo.PerformLayout()
        Me.grpProveedor.ResumeLayout(False)
        Me.grpProveedor.PerformLayout()
        Me.grpActivoFijo.ResumeLayout(False)
        Me.grpActivoFijo.PerformLayout()
        Me.grpDivision.ResumeLayout(False)
        Me.grpDivision.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents txtTipoActivoInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTipoActivoFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblNombreProveedorFinal As System.Windows.Forms.Label
    Public WithEvents lblTipoActivoInicial As System.Windows.Forms.Label
    Public WithEvents lblTipoActivoFinal As System.Windows.Forms.Label
    Public WithEvents txtDivisionInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblNombreTipoInicial As System.Windows.Forms.Label
    Public WithEvents txtDivisionFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreTipoFinal As System.Windows.Forms.Label
    Public WithEvents grpTipoActivo As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents txtProveedorFinal As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtProveedorInicial As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblNombreDivisionInicial As System.Windows.Forms.Label
    Public WithEvents lblNombreProveedorInicial As System.Windows.Forms.Label
    Public WithEvents lblProveedorFinal As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents lblProveedorInicial As System.Windows.Forms.Label
    Public WithEvents grpProveedor As System.Windows.Forms.GroupBox
    Public WithEvents grpActivoFijo As System.Windows.Forms.GroupBox
    Public WithEvents txtActivoFinal As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtActivoInicial As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblActivoFijoFinal As System.Windows.Forms.Label
    Public WithEvents lblActivoFijoInicial As System.Windows.Forms.Label
    Public WithEvents lblDivisionFinal As System.Windows.Forms.Label
    Public WithEvents lblNombreDivisionFinal As System.Windows.Forms.Label
    Public WithEvents grpDivision As System.Windows.Forms.GroupBox
End Class
