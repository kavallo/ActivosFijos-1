<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTAFGM0
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
        Me.txtDESCRIP_LARGA_TRES = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIP_LARGA_DOS = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtDESCRIP_LARGA_UNO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtRESPONSABLE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtUBICACION_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCHASIS_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtESTILO_DEL_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMODELO_DEL_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtNUMERO_SERIE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtMARCA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.DES_GARANTIA_1 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.DES_GARANTIA_2 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.DES_GARANTIA_3 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.DES_GARANTIA_4 = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDESCRIP_CORTA_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitRESPONSABLE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitUBICACION_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCHASIS_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitESTILO_DEL_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitMODELO_DEL_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitNUMERO_SERIE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblTitMARCA = New System.Windows.Forms.Label()
        Me.lblTitDESCRIP_LARGA_UNO = New System.Windows.Forms.Label()
        Me.lblTitMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblMEJORA_CORRELATIVO = New System.Windows.Forms.Label()
        Me.lblCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblgarantia = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtDESCRIP_LARGA_TRES)
        Me.Frame1.Controls.Add(Me.txtDESCRIP_LARGA_DOS)
        Me.Frame1.Controls.Add(Me.txtDESCRIP_LARGA_UNO)
        Me.Frame1.Controls.Add(Me.txtRESPONSABLE_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtUBICACION_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtCHASIS_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtESTILO_DEL_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtMODELO_DEL_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtNUMERO_SERIE_ACTIVO)
        Me.Frame1.Controls.Add(Me.txtMARCA)
        Me.Frame1.Controls.Add(Me.DES_GARANTIA_1)
        Me.Frame1.Controls.Add(Me.DES_GARANTIA_2)
        Me.Frame1.Controls.Add(Me.DES_GARANTIA_3)
        Me.Frame1.Controls.Add(Me.DES_GARANTIA_4)
        Me.Frame1.Controls.Add(Me.lblDESCRIP_CORTA_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitRESPONSABLE_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitUBICACION_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitCHASIS_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitESTILO_DEL_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitMODELO_DEL_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitNUMERO_SERIE_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitMARCA)
        Me.Frame1.Controls.Add(Me.lblTitDESCRIP_LARGA_UNO)
        Me.Frame1.Controls.Add(Me.lblTitMEJORA_CORRELATIVO)
        Me.Frame1.Controls.Add(Me.lblTitCODIGO_DE_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblMEJORA_CORRELATIVO)
        Me.Frame1.Controls.Add(Me.lblCODIGO_DE_ACTIVO)
        Me.Frame1.Controls.Add(Me.lblgarantia)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(585, 397)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtDESCRIP_LARGA_TRES
        '
        Me.txtDESCRIP_LARGA_TRES.AcceptsReturn = True
        Me.txtDESCRIP_LARGA_TRES.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIP_LARGA_TRES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIP_LARGA_TRES.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIP_LARGA_TRES.EsRequerido = False
        Me.txtDESCRIP_LARGA_TRES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIP_LARGA_TRES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIP_LARGA_TRES.LabelConsulta = Nothing
        Me.txtDESCRIP_LARGA_TRES.Location = New System.Drawing.Point(119, 103)
        Me.txtDESCRIP_LARGA_TRES.MaxLength = 60
        Me.txtDESCRIP_LARGA_TRES.Name = "txtDESCRIP_LARGA_TRES"
        Me.txtDESCRIP_LARGA_TRES.NombreDeConsulta = Nothing
        Me.txtDESCRIP_LARGA_TRES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIP_LARGA_TRES.Size = New System.Drawing.Size(442, 20)
        Me.txtDESCRIP_LARGA_TRES.TabIndex = 2
        '
        'txtDESCRIP_LARGA_DOS
        '
        Me.txtDESCRIP_LARGA_DOS.AcceptsReturn = True
        Me.txtDESCRIP_LARGA_DOS.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIP_LARGA_DOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIP_LARGA_DOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIP_LARGA_DOS.EsRequerido = False
        Me.txtDESCRIP_LARGA_DOS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIP_LARGA_DOS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIP_LARGA_DOS.LabelConsulta = Nothing
        Me.txtDESCRIP_LARGA_DOS.Location = New System.Drawing.Point(119, 83)
        Me.txtDESCRIP_LARGA_DOS.MaxLength = 60
        Me.txtDESCRIP_LARGA_DOS.Name = "txtDESCRIP_LARGA_DOS"
        Me.txtDESCRIP_LARGA_DOS.NombreDeConsulta = Nothing
        Me.txtDESCRIP_LARGA_DOS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIP_LARGA_DOS.Size = New System.Drawing.Size(442, 20)
        Me.txtDESCRIP_LARGA_DOS.TabIndex = 1
        '
        'txtDESCRIP_LARGA_UNO
        '
        Me.txtDESCRIP_LARGA_UNO.AcceptsReturn = True
        Me.txtDESCRIP_LARGA_UNO.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIP_LARGA_UNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIP_LARGA_UNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIP_LARGA_UNO.EsRequerido = True
        Me.txtDESCRIP_LARGA_UNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIP_LARGA_UNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIP_LARGA_UNO.LabelConsulta = Nothing
        Me.txtDESCRIP_LARGA_UNO.Location = New System.Drawing.Point(119, 63)
        Me.txtDESCRIP_LARGA_UNO.MaxLength = 60
        Me.txtDESCRIP_LARGA_UNO.Name = "txtDESCRIP_LARGA_UNO"
        Me.txtDESCRIP_LARGA_UNO.NombreDeConsulta = Nothing
        Me.txtDESCRIP_LARGA_UNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIP_LARGA_UNO.Size = New System.Drawing.Size(442, 20)
        Me.txtDESCRIP_LARGA_UNO.TabIndex = 0
        '
        'txtRESPONSABLE_ACTIVO
        '
        Me.txtRESPONSABLE_ACTIVO.AcceptsReturn = True
        Me.txtRESPONSABLE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtRESPONSABLE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRESPONSABLE_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRESPONSABLE_ACTIVO.EsRequerido = False
        Me.txtRESPONSABLE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRESPONSABLE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRESPONSABLE_ACTIVO.LabelConsulta = Nothing
        Me.txtRESPONSABLE_ACTIVO.Location = New System.Drawing.Point(119, 285)
        Me.txtRESPONSABLE_ACTIVO.MaxLength = 30
        Me.txtRESPONSABLE_ACTIVO.Name = "txtRESPONSABLE_ACTIVO"
        Me.txtRESPONSABLE_ACTIVO.NombreDeConsulta = Nothing
        Me.txtRESPONSABLE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRESPONSABLE_ACTIVO.Size = New System.Drawing.Size(225, 20)
        Me.txtRESPONSABLE_ACTIVO.TabIndex = 9
        '
        'txtUBICACION_ACTIVO
        '
        Me.txtUBICACION_ACTIVO.AcceptsReturn = True
        Me.txtUBICACION_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtUBICACION_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUBICACION_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUBICACION_ACTIVO.EsRequerido = False
        Me.txtUBICACION_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUBICACION_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUBICACION_ACTIVO.LabelConsulta = Nothing
        Me.txtUBICACION_ACTIVO.Location = New System.Drawing.Point(119, 259)
        Me.txtUBICACION_ACTIVO.MaxLength = 15
        Me.txtUBICACION_ACTIVO.Name = "txtUBICACION_ACTIVO"
        Me.txtUBICACION_ACTIVO.NombreDeConsulta = Nothing
        Me.txtUBICACION_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUBICACION_ACTIVO.Size = New System.Drawing.Size(125, 20)
        Me.txtUBICACION_ACTIVO.TabIndex = 8
        '
        'txtCHASIS_ACTIVO
        '
        Me.txtCHASIS_ACTIVO.AcceptsReturn = True
        Me.txtCHASIS_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCHASIS_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCHASIS_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCHASIS_ACTIVO.EsRequerido = False
        Me.txtCHASIS_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHASIS_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCHASIS_ACTIVO.LabelConsulta = Nothing
        Me.txtCHASIS_ACTIVO.Location = New System.Drawing.Point(119, 233)
        Me.txtCHASIS_ACTIVO.MaxLength = 30
        Me.txtCHASIS_ACTIVO.Name = "txtCHASIS_ACTIVO"
        Me.txtCHASIS_ACTIVO.NombreDeConsulta = Nothing
        Me.txtCHASIS_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCHASIS_ACTIVO.Size = New System.Drawing.Size(225, 20)
        Me.txtCHASIS_ACTIVO.TabIndex = 7
        '
        'txtESTILO_DEL_ACTIVO
        '
        Me.txtESTILO_DEL_ACTIVO.AcceptsReturn = True
        Me.txtESTILO_DEL_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtESTILO_DEL_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtESTILO_DEL_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtESTILO_DEL_ACTIVO.EsRequerido = False
        Me.txtESTILO_DEL_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtESTILO_DEL_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtESTILO_DEL_ACTIVO.LabelConsulta = Nothing
        Me.txtESTILO_DEL_ACTIVO.Location = New System.Drawing.Point(119, 207)
        Me.txtESTILO_DEL_ACTIVO.MaxLength = 15
        Me.txtESTILO_DEL_ACTIVO.Name = "txtESTILO_DEL_ACTIVO"
        Me.txtESTILO_DEL_ACTIVO.NombreDeConsulta = Nothing
        Me.txtESTILO_DEL_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtESTILO_DEL_ACTIVO.Size = New System.Drawing.Size(125, 20)
        Me.txtESTILO_DEL_ACTIVO.TabIndex = 6
        '
        'txtMODELO_DEL_ACTIVO
        '
        Me.txtMODELO_DEL_ACTIVO.AcceptsReturn = True
        Me.txtMODELO_DEL_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtMODELO_DEL_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMODELO_DEL_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMODELO_DEL_ACTIVO.EsRequerido = False
        Me.txtMODELO_DEL_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMODELO_DEL_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMODELO_DEL_ACTIVO.LabelConsulta = Nothing
        Me.txtMODELO_DEL_ACTIVO.Location = New System.Drawing.Point(119, 181)
        Me.txtMODELO_DEL_ACTIVO.MaxLength = 15
        Me.txtMODELO_DEL_ACTIVO.Name = "txtMODELO_DEL_ACTIVO"
        Me.txtMODELO_DEL_ACTIVO.NombreDeConsulta = Nothing
        Me.txtMODELO_DEL_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMODELO_DEL_ACTIVO.Size = New System.Drawing.Size(125, 20)
        Me.txtMODELO_DEL_ACTIVO.TabIndex = 5
        '
        'txtNUMERO_SERIE_ACTIVO
        '
        Me.txtNUMERO_SERIE_ACTIVO.AcceptsReturn = True
        Me.txtNUMERO_SERIE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNUMERO_SERIE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMERO_SERIE_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUMERO_SERIE_ACTIVO.EsRequerido = False
        Me.txtNUMERO_SERIE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUMERO_SERIE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNUMERO_SERIE_ACTIVO.LabelConsulta = Nothing
        Me.txtNUMERO_SERIE_ACTIVO.Location = New System.Drawing.Point(119, 155)
        Me.txtNUMERO_SERIE_ACTIVO.MaxLength = 30
        Me.txtNUMERO_SERIE_ACTIVO.Name = "txtNUMERO_SERIE_ACTIVO"
        Me.txtNUMERO_SERIE_ACTIVO.NombreDeConsulta = Nothing
        Me.txtNUMERO_SERIE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNUMERO_SERIE_ACTIVO.Size = New System.Drawing.Size(225, 20)
        Me.txtNUMERO_SERIE_ACTIVO.TabIndex = 4
        '
        'txtMARCA
        '
        Me.txtMARCA.AcceptsReturn = True
        Me.txtMARCA.BackColor = System.Drawing.SystemColors.Window
        Me.txtMARCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMARCA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMARCA.EsRequerido = False
        Me.txtMARCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMARCA.LabelConsulta = Nothing
        Me.txtMARCA.Location = New System.Drawing.Point(119, 129)
        Me.txtMARCA.MaxLength = 30
        Me.txtMARCA.Name = "txtMARCA"
        Me.txtMARCA.NombreDeConsulta = Nothing
        Me.txtMARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMARCA.Size = New System.Drawing.Size(225, 20)
        Me.txtMARCA.TabIndex = 3
        '
        'DES_GARANTIA_1
        '
        Me.DES_GARANTIA_1.AcceptsReturn = True
        Me.DES_GARANTIA_1.BackColor = System.Drawing.SystemColors.Window
        Me.DES_GARANTIA_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DES_GARANTIA_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DES_GARANTIA_1.EsRequerido = False
        Me.DES_GARANTIA_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DES_GARANTIA_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DES_GARANTIA_1.LabelConsulta = Nothing
        Me.DES_GARANTIA_1.Location = New System.Drawing.Point(119, 311)
        Me.DES_GARANTIA_1.MaxLength = 60
        Me.DES_GARANTIA_1.Name = "DES_GARANTIA_1"
        Me.DES_GARANTIA_1.NombreDeConsulta = Nothing
        Me.DES_GARANTIA_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DES_GARANTIA_1.Size = New System.Drawing.Size(442, 20)
        Me.DES_GARANTIA_1.TabIndex = 10
        '
        'DES_GARANTIA_2
        '
        Me.DES_GARANTIA_2.AcceptsReturn = True
        Me.DES_GARANTIA_2.BackColor = System.Drawing.SystemColors.Window
        Me.DES_GARANTIA_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DES_GARANTIA_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DES_GARANTIA_2.EsRequerido = False
        Me.DES_GARANTIA_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DES_GARANTIA_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DES_GARANTIA_2.LabelConsulta = Nothing
        Me.DES_GARANTIA_2.Location = New System.Drawing.Point(119, 331)
        Me.DES_GARANTIA_2.MaxLength = 60
        Me.DES_GARANTIA_2.Name = "DES_GARANTIA_2"
        Me.DES_GARANTIA_2.NombreDeConsulta = Nothing
        Me.DES_GARANTIA_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DES_GARANTIA_2.Size = New System.Drawing.Size(442, 20)
        Me.DES_GARANTIA_2.TabIndex = 11
        '
        'DES_GARANTIA_3
        '
        Me.DES_GARANTIA_3.AcceptsReturn = True
        Me.DES_GARANTIA_3.BackColor = System.Drawing.SystemColors.Window
        Me.DES_GARANTIA_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DES_GARANTIA_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DES_GARANTIA_3.EsRequerido = False
        Me.DES_GARANTIA_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DES_GARANTIA_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DES_GARANTIA_3.LabelConsulta = Nothing
        Me.DES_GARANTIA_3.Location = New System.Drawing.Point(119, 351)
        Me.DES_GARANTIA_3.MaxLength = 60
        Me.DES_GARANTIA_3.Name = "DES_GARANTIA_3"
        Me.DES_GARANTIA_3.NombreDeConsulta = Nothing
        Me.DES_GARANTIA_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DES_GARANTIA_3.Size = New System.Drawing.Size(442, 20)
        Me.DES_GARANTIA_3.TabIndex = 12
        '
        'DES_GARANTIA_4
        '
        Me.DES_GARANTIA_4.AcceptsReturn = True
        Me.DES_GARANTIA_4.BackColor = System.Drawing.SystemColors.Window
        Me.DES_GARANTIA_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DES_GARANTIA_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DES_GARANTIA_4.EsRequerido = False
        Me.DES_GARANTIA_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DES_GARANTIA_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DES_GARANTIA_4.LabelConsulta = Nothing
        Me.DES_GARANTIA_4.Location = New System.Drawing.Point(119, 371)
        Me.DES_GARANTIA_4.MaxLength = 60
        Me.DES_GARANTIA_4.Name = "DES_GARANTIA_4"
        Me.DES_GARANTIA_4.NombreDeConsulta = Nothing
        Me.DES_GARANTIA_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DES_GARANTIA_4.Size = New System.Drawing.Size(442, 20)
        Me.DES_GARANTIA_4.TabIndex = 13
        '
        'lblDESCRIP_CORTA_ACTIVO
        '
        Me.lblDESCRIP_CORTA_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIP_CORTA_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIP_CORTA_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIP_CORTA_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIP_CORTA_ACTIVO.Location = New System.Drawing.Point(250, 18)
        Me.lblDESCRIP_CORTA_ACTIVO.Name = "lblDESCRIP_CORTA_ACTIVO"
        Me.lblDESCRIP_CORTA_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIP_CORTA_ACTIVO.Size = New System.Drawing.Size(329, 20)
        Me.lblDESCRIP_CORTA_ACTIVO.TabIndex = 31
        Me.lblDESCRIP_CORTA_ACTIVO.UseMnemonic = False
        '
        'lblTitRESPONSABLE_ACTIVO
        '
        Me.lblTitRESPONSABLE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitRESPONSABLE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitRESPONSABLE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitRESPONSABLE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitRESPONSABLE_ACTIVO.Location = New System.Drawing.Point(6, 287)
        Me.lblTitRESPONSABLE_ACTIVO.Name = "lblTitRESPONSABLE_ACTIVO"
        Me.lblTitRESPONSABLE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitRESPONSABLE_ACTIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitRESPONSABLE_ACTIVO.TabIndex = 17
        Me.lblTitRESPONSABLE_ACTIVO.Text = "Responsable"
        '
        'lblTitUBICACION_ACTIVO
        '
        Me.lblTitUBICACION_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitUBICACION_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitUBICACION_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitUBICACION_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitUBICACION_ACTIVO.Location = New System.Drawing.Point(6, 261)
        Me.lblTitUBICACION_ACTIVO.Name = "lblTitUBICACION_ACTIVO"
        Me.lblTitUBICACION_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitUBICACION_ACTIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitUBICACION_ACTIVO.TabIndex = 18
        Me.lblTitUBICACION_ACTIVO.Text = "Ubicación"
        '
        'lblTitCHASIS_ACTIVO
        '
        Me.lblTitCHASIS_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCHASIS_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCHASIS_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCHASIS_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCHASIS_ACTIVO.Location = New System.Drawing.Point(6, 235)
        Me.lblTitCHASIS_ACTIVO.Name = "lblTitCHASIS_ACTIVO"
        Me.lblTitCHASIS_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCHASIS_ACTIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitCHASIS_ACTIVO.TabIndex = 19
        Me.lblTitCHASIS_ACTIVO.Text = "[Chasis]"
        '
        'lblTitESTILO_DEL_ACTIVO
        '
        Me.lblTitESTILO_DEL_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitESTILO_DEL_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitESTILO_DEL_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitESTILO_DEL_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitESTILO_DEL_ACTIVO.Location = New System.Drawing.Point(6, 209)
        Me.lblTitESTILO_DEL_ACTIVO.Name = "lblTitESTILO_DEL_ACTIVO"
        Me.lblTitESTILO_DEL_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitESTILO_DEL_ACTIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitESTILO_DEL_ACTIVO.TabIndex = 20
        Me.lblTitESTILO_DEL_ACTIVO.Text = "[Estilo]"
        '
        'lblTitMODELO_DEL_ACTIVO
        '
        Me.lblTitMODELO_DEL_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMODELO_DEL_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMODELO_DEL_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMODELO_DEL_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMODELO_DEL_ACTIVO.Location = New System.Drawing.Point(6, 183)
        Me.lblTitMODELO_DEL_ACTIVO.Name = "lblTitMODELO_DEL_ACTIVO"
        Me.lblTitMODELO_DEL_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMODELO_DEL_ACTIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitMODELO_DEL_ACTIVO.TabIndex = 21
        Me.lblTitMODELO_DEL_ACTIVO.Text = "[Modelo]"
        '
        'lblTitNUMERO_SERIE_ACTIVO
        '
        Me.lblTitNUMERO_SERIE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitNUMERO_SERIE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitNUMERO_SERIE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitNUMERO_SERIE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitNUMERO_SERIE_ACTIVO.Location = New System.Drawing.Point(6, 157)
        Me.lblTitNUMERO_SERIE_ACTIVO.Name = "lblTitNUMERO_SERIE_ACTIVO"
        Me.lblTitNUMERO_SERIE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitNUMERO_SERIE_ACTIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitNUMERO_SERIE_ACTIVO.TabIndex = 22
        Me.lblTitNUMERO_SERIE_ACTIVO.Text = "[Número serie]"
        '
        'lblTitMARCA
        '
        Me.lblTitMARCA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMARCA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMARCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMARCA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMARCA.Location = New System.Drawing.Point(6, 131)
        Me.lblTitMARCA.Name = "lblTitMARCA"
        Me.lblTitMARCA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMARCA.Size = New System.Drawing.Size(107, 14)
        Me.lblTitMARCA.TabIndex = 23
        Me.lblTitMARCA.Text = "[Marca]"
        '
        'lblTitDESCRIP_LARGA_UNO
        '
        Me.lblTitDESCRIP_LARGA_UNO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIP_LARGA_UNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIP_LARGA_UNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIP_LARGA_UNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIP_LARGA_UNO.Location = New System.Drawing.Point(6, 65)
        Me.lblTitDESCRIP_LARGA_UNO.Name = "lblTitDESCRIP_LARGA_UNO"
        Me.lblTitDESCRIP_LARGA_UNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIP_LARGA_UNO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitDESCRIP_LARGA_UNO.TabIndex = 24
        Me.lblTitDESCRIP_LARGA_UNO.Text = "Descripción"
        '
        'lblTitMEJORA_CORRELATIVO
        '
        Me.lblTitMEJORA_CORRELATIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitMEJORA_CORRELATIVO.Location = New System.Drawing.Point(6, 41)
        Me.lblTitMEJORA_CORRELATIVO.Name = "lblTitMEJORA_CORRELATIVO"
        Me.lblTitMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitMEJORA_CORRELATIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitMEJORA_CORRELATIVO.TabIndex = 25
        Me.lblTitMEJORA_CORRELATIVO.Text = "Correlativo"
        '
        'lblTitCODIGO_DE_ACTIVO
        '
        Me.lblTitCODIGO_DE_ACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(6, 18)
        Me.lblTitCODIGO_DE_ACTIVO.Name = "lblTitCODIGO_DE_ACTIVO"
        Me.lblTitCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(107, 14)
        Me.lblTitCODIGO_DE_ACTIVO.TabIndex = 26
        Me.lblTitCODIGO_DE_ACTIVO.Text = "Código activo"
        '
        'lblMEJORA_CORRELATIVO
        '
        Me.lblMEJORA_CORRELATIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblMEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMEJORA_CORRELATIVO.Location = New System.Drawing.Point(119, 40)
        Me.lblMEJORA_CORRELATIVO.Name = "lblMEJORA_CORRELATIVO"
        Me.lblMEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMEJORA_CORRELATIVO.Size = New System.Drawing.Size(45, 20)
        Me.lblMEJORA_CORRELATIVO.TabIndex = 27
        Me.lblMEJORA_CORRELATIVO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCODIGO_DE_ACTIVO
        '
        Me.lblCODIGO_DE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(119, 17)
        Me.lblCODIGO_DE_ACTIVO.Name = "lblCODIGO_DE_ACTIVO"
        Me.lblCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(125, 20)
        Me.lblCODIGO_DE_ACTIVO.TabIndex = 28
        '
        'lblgarantia
        '
        Me.lblgarantia.BackColor = System.Drawing.Color.Transparent
        Me.lblgarantia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblgarantia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgarantia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblgarantia.Location = New System.Drawing.Point(6, 313)
        Me.lblgarantia.Name = "lblgarantia"
        Me.lblgarantia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblgarantia.Size = New System.Drawing.Size(107, 14)
        Me.lblgarantia.TabIndex = 29
        Me.lblgarantia.Text = "[Des. garantía]"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(417, 415)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 3
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
        Me.cmdCancelar.Location = New System.Drawing.Point(510, 415)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBorrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBorrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBorrar.Location = New System.Drawing.Point(324, 415)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBorrar.Size = New System.Drawing.Size(87, 25)
        Me.cmdBorrar.TabIndex = 2
        Me.cmdBorrar.Text = "@3"
        Me.cmdBorrar.UseVisualStyleBackColor = False
        '
        'ACTAFGM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(609, 452)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTAFGM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de información general de activos fijos - ACTAFGM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDESCRIP_LARGA_TRES As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDESCRIP_LARGA_DOS As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDESCRIP_LARGA_UNO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtRESPONSABLE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtUBICACION_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCHASIS_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtESTILO_DEL_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtMODELO_DEL_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtNUMERO_SERIE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtMARCA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents DES_GARANTIA_1 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents DES_GARANTIA_2 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents DES_GARANTIA_3 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents DES_GARANTIA_4 As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDESCRIP_CORTA_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitRESPONSABLE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitUBICACION_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCHASIS_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitESTILO_DEL_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMODELO_DEL_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitNUMERO_SERIE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitMARCA As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIP_LARGA_UNO As System.Windows.Forms.Label
    Public WithEvents lblTitMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblMEJORA_CORRELATIVO As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblgarantia As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdBorrar As System.Windows.Forms.Button
End Class
