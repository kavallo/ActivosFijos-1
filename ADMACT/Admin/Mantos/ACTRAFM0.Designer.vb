<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTRAFM0
    Inherits Citi.Synergia.UIGenerico.FormaMantenimiento  ' System.Windows.Forms.Form

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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtRESPONSABLE_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNOMBRE_RESPONSABLE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtAPELLIDO_PATERNO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitEMPLEADO_ID = New System.Windows.Forms.Label()
        Me.txtNOMBRE_USUAL = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtEMPLEADO_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCODIGO_DIVISION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtAPELLIDO_DE_CASADA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtAPELLIDO_MATERNO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDESCRIPCION_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DIVISION = New System.Windows.Forms.Label()
        Me.lblTitNOMBRE_USUAL = New System.Windows.Forms.Label()
        Me.lblTitAPELLIDO_DE_CASADA = New System.Windows.Forms.Label()
        Me.lblTitAPELLIDO_MATERNO = New System.Windows.Forms.Label()
        Me.lblTitAPELLIDO_PATERNO = New System.Windows.Forms.Label()
        Me.lblTitNOMBRE_RESPONSABLE = New System.Windows.Forms.Label()
        Me.lblTitRESPONSABLE_ID = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(449, 244)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(356, 244)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtRESPONSABLE_ID)
        Me.Frame1.Controls.Add(Me.txtNOMBRE_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.txtAPELLIDO_PATERNO)
        Me.Frame1.Controls.Add(Me.lblTitEMPLEADO_ID)
        Me.Frame1.Controls.Add(Me.txtNOMBRE_USUAL)
        Me.Frame1.Controls.Add(Me.txtEMPLEADO_ID)
        Me.Frame1.Controls.Add(Me.txtCODIGO_DIVISION)
        Me.Frame1.Controls.Add(Me.txtAPELLIDO_DE_CASADA)
        Me.Frame1.Controls.Add(Me.txtAPELLIDO_MATERNO)
        Me.Frame1.Controls.Add(Me.lblDESCRIPCION_DIVISION)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DIVISION)
        Me.Frame1.Controls.Add(Me.lblTitNOMBRE_USUAL)
        Me.Frame1.Controls.Add(Me.lblTitAPELLIDO_DE_CASADA)
        Me.Frame1.Controls.Add(Me.lblTitAPELLIDO_MATERNO)
        Me.Frame1.Controls.Add(Me.lblTitAPELLIDO_PATERNO)
        Me.Frame1.Controls.Add(Me.lblTitNOMBRE_RESPONSABLE)
        Me.Frame1.Controls.Add(Me.lblTitRESPONSABLE_ID)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(524, 226)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtRESPONSABLE_ID
        '
        Me.txtRESPONSABLE_ID.AcceptsReturn = True
        Me.txtRESPONSABLE_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtRESPONSABLE_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRESPONSABLE_ID.EsRequerido = True
        Me.txtRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRESPONSABLE_ID.LabelConsulta = Nothing
        Me.txtRESPONSABLE_ID.Location = New System.Drawing.Point(157, 19)
        Me.txtRESPONSABLE_ID.MaxLength = 5
        Me.txtRESPONSABLE_ID.Name = "txtRESPONSABLE_ID"
        Me.txtRESPONSABLE_ID.NombreDeConsulta = Nothing
        Me.txtRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRESPONSABLE_ID.Size = New System.Drawing.Size(87, 20)
        Me.txtRESPONSABLE_ID.TabIndex = 0
        '
        'txtNOMBRE_RESPONSABLE
        '
        Me.txtNOMBRE_RESPONSABLE.AcceptsReturn = True
        Me.txtNOMBRE_RESPONSABLE.BackColor = System.Drawing.SystemColors.Window
        Me.txtNOMBRE_RESPONSABLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNOMBRE_RESPONSABLE.EsRequerido = True
        Me.txtNOMBRE_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNOMBRE_RESPONSABLE.LabelConsulta = Nothing
        Me.txtNOMBRE_RESPONSABLE.Location = New System.Drawing.Point(157, 45)
        Me.txtNOMBRE_RESPONSABLE.MaxLength = 40
        Me.txtNOMBRE_RESPONSABLE.Name = "txtNOMBRE_RESPONSABLE"
        Me.txtNOMBRE_RESPONSABLE.NombreDeConsulta = Nothing
        Me.txtNOMBRE_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNOMBRE_RESPONSABLE.Size = New System.Drawing.Size(328, 20)
        Me.txtNOMBRE_RESPONSABLE.TabIndex = 2
        '
        'txtAPELLIDO_PATERNO
        '
        Me.txtAPELLIDO_PATERNO.AcceptsReturn = True
        Me.txtAPELLIDO_PATERNO.BackColor = System.Drawing.SystemColors.Window
        Me.txtAPELLIDO_PATERNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAPELLIDO_PATERNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAPELLIDO_PATERNO.EsRequerido = True
        Me.txtAPELLIDO_PATERNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPELLIDO_PATERNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAPELLIDO_PATERNO.LabelConsulta = Nothing
        Me.txtAPELLIDO_PATERNO.Location = New System.Drawing.Point(157, 71)
        Me.txtAPELLIDO_PATERNO.MaxLength = 30
        Me.txtAPELLIDO_PATERNO.Name = "txtAPELLIDO_PATERNO"
        Me.txtAPELLIDO_PATERNO.NombreDeConsulta = Nothing
        Me.txtAPELLIDO_PATERNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAPELLIDO_PATERNO.Size = New System.Drawing.Size(260, 20)
        Me.txtAPELLIDO_PATERNO.TabIndex = 3
        '
        'lblTitEMPLEADO_ID
        '
        Me.lblTitEMPLEADO_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitEMPLEADO_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitEMPLEADO_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitEMPLEADO_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitEMPLEADO_ID.Location = New System.Drawing.Point(6, 203)
        Me.lblTitEMPLEADO_ID.Name = "lblTitEMPLEADO_ID"
        Me.lblTitEMPLEADO_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitEMPLEADO_ID.Size = New System.Drawing.Size(145, 14)
        Me.lblTitEMPLEADO_ID.TabIndex = 16
        Me.lblTitEMPLEADO_ID.Text = "[Código empleado]"
        Me.lblTitEMPLEADO_ID.Visible = False
        '
        'txtNOMBRE_USUAL
        '
        Me.txtNOMBRE_USUAL.AcceptsReturn = True
        Me.txtNOMBRE_USUAL.BackColor = System.Drawing.SystemColors.Window
        Me.txtNOMBRE_USUAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMBRE_USUAL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNOMBRE_USUAL.EsRequerido = True
        Me.txtNOMBRE_USUAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE_USUAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNOMBRE_USUAL.LabelConsulta = Nothing
        Me.txtNOMBRE_USUAL.Location = New System.Drawing.Point(157, 149)
        Me.txtNOMBRE_USUAL.MaxLength = 40
        Me.txtNOMBRE_USUAL.Name = "txtNOMBRE_USUAL"
        Me.txtNOMBRE_USUAL.NombreDeConsulta = Nothing
        Me.txtNOMBRE_USUAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNOMBRE_USUAL.Size = New System.Drawing.Size(328, 20)
        Me.txtNOMBRE_USUAL.TabIndex = 6
        '
        'txtEMPLEADO_ID
        '
        Me.txtEMPLEADO_ID.AcceptsReturn = True
        Me.txtEMPLEADO_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEMPLEADO_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEMPLEADO_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEMPLEADO_ID.EsRequerido = False
        Me.txtEMPLEADO_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEMPLEADO_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEMPLEADO_ID.LabelConsulta = Nothing
        Me.txtEMPLEADO_ID.Location = New System.Drawing.Point(157, 201)
        Me.txtEMPLEADO_ID.MaxLength = 10
        Me.txtEMPLEADO_ID.Name = "txtEMPLEADO_ID"
        Me.txtEMPLEADO_ID.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeEmpleados_NOMEMPL0
        Me.txtEMPLEADO_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEMPLEADO_ID.Size = New System.Drawing.Size(87, 20)
        Me.txtEMPLEADO_ID.TabIndex = 1
        Me.txtEMPLEADO_ID.Visible = False
        '
        'txtCODIGO_DIVISION
        '
        Me.txtCODIGO_DIVISION.AcceptsReturn = True
        Me.txtCODIGO_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_DIVISION.EsRequerido = True
        Me.txtCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_DIVISION.LabelConsulta = Nothing
        Me.txtCODIGO_DIVISION.Location = New System.Drawing.Point(157, 175)
        Me.txtCODIGO_DIVISION.MaxLength = 10
        Me.txtCODIGO_DIVISION.Name = "txtCODIGO_DIVISION"
        Me.txtCODIGO_DIVISION.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_DIVISION.Size = New System.Drawing.Size(87, 20)
        Me.txtCODIGO_DIVISION.TabIndex = 7
        '
        'txtAPELLIDO_DE_CASADA
        '
        Me.txtAPELLIDO_DE_CASADA.AcceptsReturn = True
        Me.txtAPELLIDO_DE_CASADA.BackColor = System.Drawing.SystemColors.Window
        Me.txtAPELLIDO_DE_CASADA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAPELLIDO_DE_CASADA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAPELLIDO_DE_CASADA.EsRequerido = False
        Me.txtAPELLIDO_DE_CASADA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPELLIDO_DE_CASADA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAPELLIDO_DE_CASADA.LabelConsulta = Nothing
        Me.txtAPELLIDO_DE_CASADA.Location = New System.Drawing.Point(157, 123)
        Me.txtAPELLIDO_DE_CASADA.MaxLength = 10
        Me.txtAPELLIDO_DE_CASADA.Name = "txtAPELLIDO_DE_CASADA"
        Me.txtAPELLIDO_DE_CASADA.NombreDeConsulta = Nothing
        Me.txtAPELLIDO_DE_CASADA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAPELLIDO_DE_CASADA.Size = New System.Drawing.Size(87, 20)
        Me.txtAPELLIDO_DE_CASADA.TabIndex = 5
        '
        'txtAPELLIDO_MATERNO
        '
        Me.txtAPELLIDO_MATERNO.AcceptsReturn = True
        Me.txtAPELLIDO_MATERNO.BackColor = System.Drawing.SystemColors.Window
        Me.txtAPELLIDO_MATERNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAPELLIDO_MATERNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAPELLIDO_MATERNO.EsRequerido = False
        Me.txtAPELLIDO_MATERNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPELLIDO_MATERNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAPELLIDO_MATERNO.LabelConsulta = Nothing
        Me.txtAPELLIDO_MATERNO.Location = New System.Drawing.Point(157, 97)
        Me.txtAPELLIDO_MATERNO.MaxLength = 30
        Me.txtAPELLIDO_MATERNO.Name = "txtAPELLIDO_MATERNO"
        Me.txtAPELLIDO_MATERNO.NombreDeConsulta = Nothing
        Me.txtAPELLIDO_MATERNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAPELLIDO_MATERNO.Size = New System.Drawing.Size(260, 20)
        Me.txtAPELLIDO_MATERNO.TabIndex = 4
        '
        'lblDESCRIPCION_DIVISION
        '
        Me.lblDESCRIPCION_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_DIVISION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_DIVISION.Location = New System.Drawing.Point(260, 177)
        Me.lblDESCRIPCION_DIVISION.Name = "lblDESCRIPCION_DIVISION"
        Me.lblDESCRIPCION_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_DIVISION.Size = New System.Drawing.Size(258, 20)
        Me.lblDESCRIPCION_DIVISION.TabIndex = 19
        Me.lblDESCRIPCION_DIVISION.UseMnemonic = False
        '
        'lblTitCODIGO_DIVISION
        '
        Me.lblTitCODIGO_DIVISION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DIVISION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DIVISION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DIVISION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DIVISION.Location = New System.Drawing.Point(6, 177)
        Me.lblTitCODIGO_DIVISION.Name = "lblTitCODIGO_DIVISION"
        Me.lblTitCODIGO_DIVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DIVISION.Size = New System.Drawing.Size(145, 14)
        Me.lblTitCODIGO_DIVISION.TabIndex = 10
        Me.lblTitCODIGO_DIVISION.Text = "Departamento"
        '
        'lblTitNOMBRE_USUAL
        '
        Me.lblTitNOMBRE_USUAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNOMBRE_USUAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNOMBRE_USUAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNOMBRE_USUAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNOMBRE_USUAL.Location = New System.Drawing.Point(6, 151)
        Me.lblTitNOMBRE_USUAL.Name = "lblTitNOMBRE_USUAL"
        Me.lblTitNOMBRE_USUAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNOMBRE_USUAL.Size = New System.Drawing.Size(145, 14)
        Me.lblTitNOMBRE_USUAL.TabIndex = 11
        Me.lblTitNOMBRE_USUAL.Text = "Nombre usual"
        '
        'lblTitAPELLIDO_DE_CASADA
        '
        Me.lblTitAPELLIDO_DE_CASADA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitAPELLIDO_DE_CASADA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitAPELLIDO_DE_CASADA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitAPELLIDO_DE_CASADA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitAPELLIDO_DE_CASADA.Location = New System.Drawing.Point(6, 125)
        Me.lblTitAPELLIDO_DE_CASADA.Name = "lblTitAPELLIDO_DE_CASADA"
        Me.lblTitAPELLIDO_DE_CASADA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitAPELLIDO_DE_CASADA.Size = New System.Drawing.Size(145, 14)
        Me.lblTitAPELLIDO_DE_CASADA.TabIndex = 12
        Me.lblTitAPELLIDO_DE_CASADA.Text = "[Apellido de casada]"
        '
        'lblTitAPELLIDO_MATERNO
        '
        Me.lblTitAPELLIDO_MATERNO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitAPELLIDO_MATERNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitAPELLIDO_MATERNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitAPELLIDO_MATERNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitAPELLIDO_MATERNO.Location = New System.Drawing.Point(6, 99)
        Me.lblTitAPELLIDO_MATERNO.Name = "lblTitAPELLIDO_MATERNO"
        Me.lblTitAPELLIDO_MATERNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitAPELLIDO_MATERNO.Size = New System.Drawing.Size(145, 14)
        Me.lblTitAPELLIDO_MATERNO.TabIndex = 13
        Me.lblTitAPELLIDO_MATERNO.Text = "[Apellido materno]"
        '
        'lblTitAPELLIDO_PATERNO
        '
        Me.lblTitAPELLIDO_PATERNO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitAPELLIDO_PATERNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitAPELLIDO_PATERNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitAPELLIDO_PATERNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitAPELLIDO_PATERNO.Location = New System.Drawing.Point(6, 73)
        Me.lblTitAPELLIDO_PATERNO.Name = "lblTitAPELLIDO_PATERNO"
        Me.lblTitAPELLIDO_PATERNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitAPELLIDO_PATERNO.Size = New System.Drawing.Size(145, 14)
        Me.lblTitAPELLIDO_PATERNO.TabIndex = 14
        Me.lblTitAPELLIDO_PATERNO.Text = "Apellido paterno"
        '
        'lblTitNOMBRE_RESPONSABLE
        '
        Me.lblTitNOMBRE_RESPONSABLE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNOMBRE_RESPONSABLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNOMBRE_RESPONSABLE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNOMBRE_RESPONSABLE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNOMBRE_RESPONSABLE.Location = New System.Drawing.Point(6, 47)
        Me.lblTitNOMBRE_RESPONSABLE.Name = "lblTitNOMBRE_RESPONSABLE"
        Me.lblTitNOMBRE_RESPONSABLE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNOMBRE_RESPONSABLE.Size = New System.Drawing.Size(145, 14)
        Me.lblTitNOMBRE_RESPONSABLE.TabIndex = 15
        Me.lblTitNOMBRE_RESPONSABLE.Text = "Nombre responsable"
        '
        'lblTitRESPONSABLE_ID
        '
        Me.lblTitRESPONSABLE_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitRESPONSABLE_ID.Location = New System.Drawing.Point(6, 21)
        Me.lblTitRESPONSABLE_ID.Name = "lblTitRESPONSABLE_ID"
        Me.lblTitRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitRESPONSABLE_ID.Size = New System.Drawing.Size(145, 14)
        Me.lblTitRESPONSABLE_ID.TabIndex = 17
        Me.lblTitRESPONSABLE_ID.Text = "Código responable"
        '
        'ACTRAFM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(548, 281)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTRAFM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento responsables de activos - ACTRAFM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    ' System.Windows.Forms.TextBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtCODIGO_DIVISION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNOMBRE_USUAL As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtAPELLIDO_DE_CASADA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtAPELLIDO_MATERNO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtAPELLIDO_PATERNO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNOMBRE_RESPONSABLE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtEMPLEADO_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtRESPONSABLE_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDESCRIPCION_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DIVISION As System.Windows.Forms.Label
    Public WithEvents lblTitNOMBRE_USUAL As System.Windows.Forms.Label
    Public WithEvents lblTitAPELLIDO_DE_CASADA As System.Windows.Forms.Label
    Public WithEvents lblTitAPELLIDO_MATERNO As System.Windows.Forms.Label
    Public WithEvents lblTitAPELLIDO_PATERNO As System.Windows.Forms.Label
    Public WithEvents lblTitNOMBRE_RESPONSABLE As System.Windows.Forms.Label
    Public WithEvents lblTitEMPLEADO_ID As System.Windows.Forms.Label
    Public WithEvents lblTitRESPONSABLE_ID As System.Windows.Forms.Label
End Class
