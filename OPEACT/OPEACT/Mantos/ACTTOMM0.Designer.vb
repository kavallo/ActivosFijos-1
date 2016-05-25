<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTTOMM0
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
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.OBSERVACIONES = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.frmTOMA = New System.Windows.Forms.GroupBox()
        Me.NUMERO_TOMA = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.FECHA_TOMA = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.RESPONSABLE_TOMA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.ESTADO_TOMA = New System.Windows.Forms.Label()
        Me.lblOBSERVACIONES = New System.Windows.Forms.Label()
        Me.lblRESPONSABLE_TOMA = New System.Windows.Forms.Label()
        Me.lblNUMERO_TOMA = New System.Windows.Forms.Label()
        Me.lblFECHA_TOMA = New System.Windows.Forms.Label()
        Me.lblMask = New System.Windows.Forms.Label()
        Me.IMPORTADA = New System.Windows.Forms.CheckBox()
        Me.lblCODIGO_UBICACION = New System.Windows.Forms.Label()
        Me.FECHA_AUT = New System.Windows.Forms.Label()
        Me.frmAUDIT = New System.Windows.Forms.GroupBox()
        Me.lblModificada = New System.Windows.Forms.Label()
        Me.USUARIO_AUT = New System.Windows.Forms.Label()
        Me.lblAUTOR = New System.Windows.Forms.Label()
        Me.FECHA_IMP = New System.Windows.Forms.Label()
        Me.USUARIO_IMP = New System.Windows.Forms.Label()
        Me.lblIMPORT = New System.Windows.Forms.Label()
        Me.FECHA_ING = New System.Windows.Forms.Label()
        Me.USUARIO_ING = New System.Windows.Forms.Label()
        Me.lblFECHA = New System.Windows.Forms.Label()
        Me.lblUSUARIO = New System.Windows.Forms.Label()
        Me.lblINGRESO = New System.Windows.Forms.Label()
        Me.desCODIGO_UBICACION = New System.Windows.Forms.Label()
        Me.OBSERVACIONES_DET = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.CODIGO_DE_ACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.MEJORA_CORRELATIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.desRESPONSABLE_ID = New System.Windows.Forms.Label()
        Me.frmDET = New System.Windows.Forms.GroupBox()
        Me.CODIGO_UBICACION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.RESPONSABLE_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.DETALLE = New System.Windows.Forms.DataGridView()
        Me.lblOBSERVACIONES_DET = New System.Windows.Forms.Label()
        Me.desCODIGO_DE_ACTIVO = New System.Windows.Forms.Label()
        Me.lblACTIVO = New System.Windows.Forms.Label()
        Me.lblRESPONSABLE_ID = New System.Windows.Forms.Label()
        Me.cmdImportar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblRegistro = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmTOMA.SuspendLayout()
        Me.frmAUDIT.SuspendLayout()
        Me.frmDET.SuspendLayout()
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExportar
        '
        Me.cmdExportar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExportar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExportar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExportar.Location = New System.Drawing.Point(317, 529)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExportar.Size = New System.Drawing.Size(87, 25)
        Me.cmdExportar.TabIndex = 35
        Me.cmdExportar.Text = "&Exportar"
        Me.cmdExportar.UseVisualStyleBackColor = False
        Me.cmdExportar.Visible = False
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.AcceptsReturn = True
        Me.OBSERVACIONES.BackColor = System.Drawing.SystemColors.Window
        Me.OBSERVACIONES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OBSERVACIONES.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OBSERVACIONES.EsRequerido = False
        Me.OBSERVACIONES.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBSERVACIONES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OBSERVACIONES.LabelConsulta = Nothing
        Me.OBSERVACIONES.Location = New System.Drawing.Point(125, 79)
        Me.OBSERVACIONES.MaxLength = 255
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.NombreDeConsulta = Nothing
        Me.OBSERVACIONES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OBSERVACIONES.Size = New System.Drawing.Size(526, 20)
        Me.OBSERVACIONES.TabIndex = 3
        '
        'frmTOMA
        '
        Me.frmTOMA.BackColor = System.Drawing.SystemColors.Control
        Me.frmTOMA.Controls.Add(Me.NUMERO_TOMA)
        Me.frmTOMA.Controls.Add(Me.FECHA_TOMA)
        Me.frmTOMA.Controls.Add(Me.RESPONSABLE_TOMA)
        Me.frmTOMA.Controls.Add(Me.OBSERVACIONES)
        Me.frmTOMA.Controls.Add(Me.ESTADO_TOMA)
        Me.frmTOMA.Controls.Add(Me.lblOBSERVACIONES)
        Me.frmTOMA.Controls.Add(Me.lblRESPONSABLE_TOMA)
        Me.frmTOMA.Controls.Add(Me.lblNUMERO_TOMA)
        Me.frmTOMA.Controls.Add(Me.lblFECHA_TOMA)
        Me.frmTOMA.Controls.Add(Me.lblMask)
        Me.frmTOMA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmTOMA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmTOMA.Location = New System.Drawing.Point(12, 12)
        Me.frmTOMA.Name = "frmTOMA"
        Me.frmTOMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmTOMA.Size = New System.Drawing.Size(671, 113)
        Me.frmTOMA.TabIndex = 39
        Me.frmTOMA.TabStop = False
        Me.frmTOMA.Text = "Información de la toma física:"
        '
        'NUMERO_TOMA
        '
        Me.NUMERO_TOMA.AcceptsReturn = True
        Me.NUMERO_TOMA.BackColor = System.Drawing.SystemColors.Window
        Me.NUMERO_TOMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUMERO_TOMA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUMERO_TOMA.EsRequerido = True
        Me.NUMERO_TOMA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUMERO_TOMA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NUMERO_TOMA.LabelConsulta = Nothing
        Me.NUMERO_TOMA.Location = New System.Drawing.Point(125, 19)
        Me.NUMERO_TOMA.MaxLength = 10
        Me.NUMERO_TOMA.Name = "NUMERO_TOMA"
        Me.NUMERO_TOMA.NombreDeConsulta = Nothing
        Me.NUMERO_TOMA.NumeroDecimales = 0
        Me.NUMERO_TOMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NUMERO_TOMA.Size = New System.Drawing.Size(95, 20)
        Me.NUMERO_TOMA.TabIndex = 0
        Me.NUMERO_TOMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FECHA_TOMA
        '
        Me.FECHA_TOMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FECHA_TOMA.EsRequerido = True
        Me.FECHA_TOMA.Location = New System.Drawing.Point(125, 39)
        Me.FECHA_TOMA.Mask = "00/00/0000"
        Me.FECHA_TOMA.Name = "FECHA_TOMA"
        Me.FECHA_TOMA.Size = New System.Drawing.Size(181, 20)
        Me.FECHA_TOMA.TabIndex = 1
        Me.FECHA_TOMA.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.FECHA_TOMA.ValidatingType = GetType(Date)
        '
        'RESPONSABLE_TOMA
        '
        Me.RESPONSABLE_TOMA.AcceptsReturn = True
        Me.RESPONSABLE_TOMA.BackColor = System.Drawing.SystemColors.Window
        Me.RESPONSABLE_TOMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RESPONSABLE_TOMA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RESPONSABLE_TOMA.EsRequerido = False
        Me.RESPONSABLE_TOMA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESPONSABLE_TOMA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RESPONSABLE_TOMA.LabelConsulta = Nothing
        Me.RESPONSABLE_TOMA.Location = New System.Drawing.Point(125, 59)
        Me.RESPONSABLE_TOMA.MaxLength = 255
        Me.RESPONSABLE_TOMA.Name = "RESPONSABLE_TOMA"
        Me.RESPONSABLE_TOMA.NombreDeConsulta = Nothing
        Me.RESPONSABLE_TOMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RESPONSABLE_TOMA.Size = New System.Drawing.Size(526, 20)
        Me.RESPONSABLE_TOMA.TabIndex = 2
        '
        'ESTADO_TOMA
        '
        Me.ESTADO_TOMA.BackColor = System.Drawing.SystemColors.Control
        Me.ESTADO_TOMA.Cursor = System.Windows.Forms.Cursors.Default
        Me.ESTADO_TOMA.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTADO_TOMA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ESTADO_TOMA.Location = New System.Drawing.Point(535, 16)
        Me.ESTADO_TOMA.Name = "ESTADO_TOMA"
        Me.ESTADO_TOMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ESTADO_TOMA.Size = New System.Drawing.Size(130, 19)
        Me.ESTADO_TOMA.TabIndex = 27
        Me.ESTADO_TOMA.Text = "** EN PROCESO **"
        Me.ESTADO_TOMA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOBSERVACIONES
        '
        Me.lblOBSERVACIONES.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblOBSERVACIONES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOBSERVACIONES.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOBSERVACIONES.ForeColor = System.Drawing.SystemColors.Window
        Me.lblOBSERVACIONES.Location = New System.Drawing.Point(6, 79)
        Me.lblOBSERVACIONES.Name = "lblOBSERVACIONES"
        Me.lblOBSERVACIONES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOBSERVACIONES.Size = New System.Drawing.Size(119, 20)
        Me.lblOBSERVACIONES.TabIndex = 26
        Me.lblOBSERVACIONES.Text = "[Observaciones]"
        Me.lblOBSERVACIONES.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRESPONSABLE_TOMA
        '
        Me.lblRESPONSABLE_TOMA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRESPONSABLE_TOMA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRESPONSABLE_TOMA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRESPONSABLE_TOMA.ForeColor = System.Drawing.SystemColors.Window
        Me.lblRESPONSABLE_TOMA.Location = New System.Drawing.Point(6, 59)
        Me.lblRESPONSABLE_TOMA.Name = "lblRESPONSABLE_TOMA"
        Me.lblRESPONSABLE_TOMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRESPONSABLE_TOMA.Size = New System.Drawing.Size(119, 20)
        Me.lblRESPONSABLE_TOMA.TabIndex = 25
        Me.lblRESPONSABLE_TOMA.Text = "[Responsable]"
        Me.lblRESPONSABLE_TOMA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNUMERO_TOMA
        '
        Me.lblNUMERO_TOMA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblNUMERO_TOMA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNUMERO_TOMA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUMERO_TOMA.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNUMERO_TOMA.Location = New System.Drawing.Point(6, 19)
        Me.lblNUMERO_TOMA.Name = "lblNUMERO_TOMA"
        Me.lblNUMERO_TOMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNUMERO_TOMA.Size = New System.Drawing.Size(119, 20)
        Me.lblNUMERO_TOMA.TabIndex = 24
        Me.lblNUMERO_TOMA.Text = "Número de toma"
        Me.lblNUMERO_TOMA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFECHA_TOMA
        '
        Me.lblFECHA_TOMA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblFECHA_TOMA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA_TOMA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_TOMA.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFECHA_TOMA.Location = New System.Drawing.Point(6, 39)
        Me.lblFECHA_TOMA.Name = "lblFECHA_TOMA"
        Me.lblFECHA_TOMA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA_TOMA.Size = New System.Drawing.Size(119, 20)
        Me.lblFECHA_TOMA.TabIndex = 23
        Me.lblFECHA_TOMA.Text = "Fecha"
        Me.lblFECHA_TOMA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMask
        '
        Me.lblMask.BackColor = System.Drawing.Color.Transparent
        Me.lblMask.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMask.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMask.Location = New System.Drawing.Point(312, 41)
        Me.lblMask.Name = "lblMask"
        Me.lblMask.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMask.Size = New System.Drawing.Size(91, 20)
        Me.lblMask.TabIndex = 22
        Me.lblMask.Text = "(DD/MM/AAAA)"
        '
        'IMPORTADA
        '
        Me.IMPORTADA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.IMPORTADA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IMPORTADA.Cursor = System.Windows.Forms.Cursors.Default
        Me.IMPORTADA.Enabled = False
        Me.IMPORTADA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMPORTADA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.IMPORTADA.Location = New System.Drawing.Point(250, 17)
        Me.IMPORTADA.Name = "IMPORTADA"
        Me.IMPORTADA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IMPORTADA.Size = New System.Drawing.Size(19, 15)
        Me.IMPORTADA.TabIndex = 4
        Me.IMPORTADA.UseVisualStyleBackColor = False
        '
        'lblCODIGO_UBICACION
        '
        Me.lblCODIGO_UBICACION.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblCODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_UBICACION.Location = New System.Drawing.Point(6, 19)
        Me.lblCODIGO_UBICACION.Name = "lblCODIGO_UBICACION"
        Me.lblCODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_UBICACION.Size = New System.Drawing.Size(119, 20)
        Me.lblCODIGO_UBICACION.TabIndex = 35
        Me.lblCODIGO_UBICACION.Text = "Ubicación"
        Me.lblCODIGO_UBICACION.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FECHA_AUT
        '
        Me.FECHA_AUT.BackColor = System.Drawing.SystemColors.Window
        Me.FECHA_AUT.Cursor = System.Windows.Forms.Cursors.Default
        Me.FECHA_AUT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHA_AUT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FECHA_AUT.Location = New System.Drawing.Point(363, 53)
        Me.FECHA_AUT.Name = "FECHA_AUT"
        Me.FECHA_AUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FECHA_AUT.Size = New System.Drawing.Size(119, 20)
        Me.FECHA_AUT.TabIndex = 10
        '
        'frmAUDIT
        '
        Me.frmAUDIT.BackColor = System.Drawing.SystemColors.Control
        Me.frmAUDIT.Controls.Add(Me.lblModificada)
        Me.frmAUDIT.Controls.Add(Me.IMPORTADA)
        Me.frmAUDIT.Controls.Add(Me.FECHA_AUT)
        Me.frmAUDIT.Controls.Add(Me.USUARIO_AUT)
        Me.frmAUDIT.Controls.Add(Me.lblAUTOR)
        Me.frmAUDIT.Controls.Add(Me.FECHA_IMP)
        Me.frmAUDIT.Controls.Add(Me.USUARIO_IMP)
        Me.frmAUDIT.Controls.Add(Me.lblIMPORT)
        Me.frmAUDIT.Controls.Add(Me.FECHA_ING)
        Me.frmAUDIT.Controls.Add(Me.USUARIO_ING)
        Me.frmAUDIT.Controls.Add(Me.lblFECHA)
        Me.frmAUDIT.Controls.Add(Me.lblUSUARIO)
        Me.frmAUDIT.Controls.Add(Me.lblINGRESO)
        Me.frmAUDIT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmAUDIT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmAUDIT.Location = New System.Drawing.Point(12, 131)
        Me.frmAUDIT.Name = "frmAUDIT"
        Me.frmAUDIT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmAUDIT.Size = New System.Drawing.Size(671, 83)
        Me.frmAUDIT.TabIndex = 40
        Me.frmAUDIT.TabStop = False
        Me.frmAUDIT.Text = "Auditoría:"
        '
        'lblModificada
        '
        Me.lblModificada.BackColor = System.Drawing.SystemColors.Control
        Me.lblModificada.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblModificada.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblModificada.Location = New System.Drawing.Point(491, 17)
        Me.lblModificada.Name = "lblModificada"
        Me.lblModificada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblModificada.Size = New System.Drawing.Size(174, 56)
        Me.lblModificada.TabIndex = 34
        Me.lblModificada.Text = "La transacción fue modificada después de haber sido importada."
        '
        'USUARIO_AUT
        '
        Me.USUARIO_AUT.BackColor = System.Drawing.SystemColors.Window
        Me.USUARIO_AUT.Cursor = System.Windows.Forms.Cursors.Default
        Me.USUARIO_AUT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USUARIO_AUT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.USUARIO_AUT.Location = New System.Drawing.Point(363, 33)
        Me.USUARIO_AUT.Name = "USUARIO_AUT"
        Me.USUARIO_AUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.USUARIO_AUT.Size = New System.Drawing.Size(119, 20)
        Me.USUARIO_AUT.TabIndex = 9
        '
        'lblAUTOR
        '
        Me.lblAUTOR.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblAUTOR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAUTOR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAUTOR.ForeColor = System.Drawing.SystemColors.Window
        Me.lblAUTOR.Location = New System.Drawing.Point(363, 16)
        Me.lblAUTOR.Name = "lblAUTOR"
        Me.lblAUTOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAUTOR.Size = New System.Drawing.Size(119, 17)
        Me.lblAUTOR.TabIndex = 33
        Me.lblAUTOR.Text = "Autorización"
        Me.lblAUTOR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FECHA_IMP
        '
        Me.FECHA_IMP.BackColor = System.Drawing.SystemColors.Window
        Me.FECHA_IMP.Cursor = System.Windows.Forms.Cursors.Default
        Me.FECHA_IMP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHA_IMP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FECHA_IMP.Location = New System.Drawing.Point(244, 53)
        Me.FECHA_IMP.Name = "FECHA_IMP"
        Me.FECHA_IMP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FECHA_IMP.Size = New System.Drawing.Size(119, 20)
        Me.FECHA_IMP.TabIndex = 8
        '
        'USUARIO_IMP
        '
        Me.USUARIO_IMP.BackColor = System.Drawing.SystemColors.Window
        Me.USUARIO_IMP.Cursor = System.Windows.Forms.Cursors.Default
        Me.USUARIO_IMP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USUARIO_IMP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.USUARIO_IMP.Location = New System.Drawing.Point(244, 33)
        Me.USUARIO_IMP.Name = "USUARIO_IMP"
        Me.USUARIO_IMP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.USUARIO_IMP.Size = New System.Drawing.Size(119, 20)
        Me.USUARIO_IMP.TabIndex = 7
        '
        'lblIMPORT
        '
        Me.lblIMPORT.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblIMPORT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIMPORT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMPORT.ForeColor = System.Drawing.SystemColors.Window
        Me.lblIMPORT.Location = New System.Drawing.Point(244, 16)
        Me.lblIMPORT.Name = "lblIMPORT"
        Me.lblIMPORT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIMPORT.Size = New System.Drawing.Size(119, 17)
        Me.lblIMPORT.TabIndex = 32
        Me.lblIMPORT.Text = "Importación"
        Me.lblIMPORT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FECHA_ING
        '
        Me.FECHA_ING.BackColor = System.Drawing.SystemColors.Window
        Me.FECHA_ING.Cursor = System.Windows.Forms.Cursors.Default
        Me.FECHA_ING.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHA_ING.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FECHA_ING.Location = New System.Drawing.Point(125, 53)
        Me.FECHA_ING.Name = "FECHA_ING"
        Me.FECHA_ING.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FECHA_ING.Size = New System.Drawing.Size(119, 20)
        Me.FECHA_ING.TabIndex = 6
        '
        'USUARIO_ING
        '
        Me.USUARIO_ING.BackColor = System.Drawing.SystemColors.Window
        Me.USUARIO_ING.Cursor = System.Windows.Forms.Cursors.Default
        Me.USUARIO_ING.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USUARIO_ING.ForeColor = System.Drawing.SystemColors.WindowText
        Me.USUARIO_ING.Location = New System.Drawing.Point(125, 33)
        Me.USUARIO_ING.Name = "USUARIO_ING"
        Me.USUARIO_ING.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.USUARIO_ING.Size = New System.Drawing.Size(119, 20)
        Me.USUARIO_ING.TabIndex = 5
        '
        'lblFECHA
        '
        Me.lblFECHA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblFECHA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFECHA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFECHA.Location = New System.Drawing.Point(6, 53)
        Me.lblFECHA.Name = "lblFECHA"
        Me.lblFECHA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFECHA.Size = New System.Drawing.Size(119, 20)
        Me.lblFECHA.TabIndex = 31
        Me.lblFECHA.Text = "Fecha (DD/MM/AAAA) "
        Me.lblFECHA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUSUARIO
        '
        Me.lblUSUARIO.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblUSUARIO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUSUARIO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSUARIO.ForeColor = System.Drawing.SystemColors.Window
        Me.lblUSUARIO.Location = New System.Drawing.Point(6, 33)
        Me.lblUSUARIO.Name = "lblUSUARIO"
        Me.lblUSUARIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUSUARIO.Size = New System.Drawing.Size(119, 20)
        Me.lblUSUARIO.TabIndex = 30
        Me.lblUSUARIO.Text = "Usuario "
        Me.lblUSUARIO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblINGRESO
        '
        Me.lblINGRESO.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblINGRESO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblINGRESO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINGRESO.ForeColor = System.Drawing.SystemColors.Window
        Me.lblINGRESO.Location = New System.Drawing.Point(125, 16)
        Me.lblINGRESO.Name = "lblINGRESO"
        Me.lblINGRESO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblINGRESO.Size = New System.Drawing.Size(119, 17)
        Me.lblINGRESO.TabIndex = 29
        Me.lblINGRESO.Text = "Ingreso"
        Me.lblINGRESO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'desCODIGO_UBICACION
        '
        Me.desCODIGO_UBICACION.BackColor = System.Drawing.SystemColors.Window
        Me.desCODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.desCODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desCODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.desCODIGO_UBICACION.Location = New System.Drawing.Point(228, 19)
        Me.desCODIGO_UBICACION.Name = "desCODIGO_UBICACION"
        Me.desCODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.desCODIGO_UBICACION.Size = New System.Drawing.Size(423, 20)
        Me.desCODIGO_UBICACION.TabIndex = 36
        '
        'OBSERVACIONES_DET
        '
        Me.OBSERVACIONES_DET.AcceptsReturn = True
        Me.OBSERVACIONES_DET.BackColor = System.Drawing.SystemColors.Window
        Me.OBSERVACIONES_DET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OBSERVACIONES_DET.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OBSERVACIONES_DET.EsRequerido = False
        Me.OBSERVACIONES_DET.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBSERVACIONES_DET.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OBSERVACIONES_DET.LabelConsulta = Nothing
        Me.OBSERVACIONES_DET.Location = New System.Drawing.Point(125, 79)
        Me.OBSERVACIONES_DET.MaxLength = 255
        Me.OBSERVACIONES_DET.Name = "OBSERVACIONES_DET"
        Me.OBSERVACIONES_DET.NombreDeConsulta = Nothing
        Me.OBSERVACIONES_DET.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OBSERVACIONES_DET.Size = New System.Drawing.Size(526, 20)
        Me.OBSERVACIONES_DET.TabIndex = 15
        '
        'CODIGO_DE_ACTIVO
        '
        Me.CODIGO_DE_ACTIVO.AcceptsReturn = True
        Me.CODIGO_DE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.CODIGO_DE_ACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CODIGO_DE_ACTIVO.EsRequerido = False
        Me.CODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CODIGO_DE_ACTIVO.LabelConsulta = Nothing
        Me.CODIGO_DE_ACTIVO.Location = New System.Drawing.Point(125, 59)
        Me.CODIGO_DE_ACTIVO.MaxLength = 15
        Me.CODIGO_DE_ACTIVO.Name = "CODIGO_DE_ACTIVO"
        Me.CODIGO_DE_ACTIVO.NombreDeConsulta = Nothing
        Me.CODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CODIGO_DE_ACTIVO.Size = New System.Drawing.Size(103, 20)
        Me.CODIGO_DE_ACTIVO.TabIndex = 13
        Me.CODIGO_DE_ACTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MEJORA_CORRELATIVO
        '
        Me.MEJORA_CORRELATIVO.AcceptsReturn = True
        Me.MEJORA_CORRELATIVO.BackColor = System.Drawing.SystemColors.Window
        Me.MEJORA_CORRELATIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MEJORA_CORRELATIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MEJORA_CORRELATIVO.EsRequerido = False
        Me.MEJORA_CORRELATIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEJORA_CORRELATIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MEJORA_CORRELATIVO.LabelConsulta = Nothing
        Me.MEJORA_CORRELATIVO.Location = New System.Drawing.Point(228, 59)
        Me.MEJORA_CORRELATIVO.MaxLength = 10
        Me.MEJORA_CORRELATIVO.Name = "MEJORA_CORRELATIVO"
        Me.MEJORA_CORRELATIVO.NombreDeConsulta = Nothing
        Me.MEJORA_CORRELATIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MEJORA_CORRELATIVO.Size = New System.Drawing.Size(79, 20)
        Me.MEJORA_CORRELATIVO.TabIndex = 14
        Me.MEJORA_CORRELATIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'desRESPONSABLE_ID
        '
        Me.desRESPONSABLE_ID.BackColor = System.Drawing.SystemColors.Window
        Me.desRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.desRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.desRESPONSABLE_ID.Location = New System.Drawing.Point(195, 39)
        Me.desRESPONSABLE_ID.Name = "desRESPONSABLE_ID"
        Me.desRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.desRESPONSABLE_ID.Size = New System.Drawing.Size(456, 20)
        Me.desRESPONSABLE_ID.TabIndex = 37
        '
        'frmDET
        '
        Me.frmDET.BackColor = System.Drawing.SystemColors.Control
        Me.frmDET.Controls.Add(Me.CODIGO_UBICACION)
        Me.frmDET.Controls.Add(Me.RESPONSABLE_ID)
        Me.frmDET.Controls.Add(Me.CODIGO_DE_ACTIVO)
        Me.frmDET.Controls.Add(Me.MEJORA_CORRELATIVO)
        Me.frmDET.Controls.Add(Me.OBSERVACIONES_DET)
        Me.frmDET.Controls.Add(Me.DETALLE)
        Me.frmDET.Controls.Add(Me.lblOBSERVACIONES_DET)
        Me.frmDET.Controls.Add(Me.desCODIGO_DE_ACTIVO)
        Me.frmDET.Controls.Add(Me.lblACTIVO)
        Me.frmDET.Controls.Add(Me.lblRESPONSABLE_ID)
        Me.frmDET.Controls.Add(Me.desRESPONSABLE_ID)
        Me.frmDET.Controls.Add(Me.desCODIGO_UBICACION)
        Me.frmDET.Controls.Add(Me.lblCODIGO_UBICACION)
        Me.frmDET.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmDET.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmDET.Location = New System.Drawing.Point(12, 220)
        Me.frmDET.Name = "frmDET"
        Me.frmDET.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmDET.Size = New System.Drawing.Size(671, 303)
        Me.frmDET.TabIndex = 41
        Me.frmDET.TabStop = False
        Me.frmDET.Text = "Información de activos encontrados:"
        '
        'CODIGO_UBICACION
        '
        Me.CODIGO_UBICACION.AcceptsReturn = True
        Me.CODIGO_UBICACION.BackColor = System.Drawing.SystemColors.Window
        Me.CODIGO_UBICACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CODIGO_UBICACION.EsRequerido = False
        Me.CODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CODIGO_UBICACION.LabelConsulta = Nothing
        Me.CODIGO_UBICACION.Location = New System.Drawing.Point(125, 19)
        Me.CODIGO_UBICACION.MaxLength = 10
        Me.CODIGO_UBICACION.Name = "CODIGO_UBICACION"
        Me.CODIGO_UBICACION.NombreDeConsulta = Nothing
        Me.CODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CODIGO_UBICACION.Size = New System.Drawing.Size(103, 20)
        Me.CODIGO_UBICACION.TabIndex = 11
        '
        'RESPONSABLE_ID
        '
        Me.RESPONSABLE_ID.AcceptsReturn = True
        Me.RESPONSABLE_ID.BackColor = System.Drawing.SystemColors.Window
        Me.RESPONSABLE_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RESPONSABLE_ID.EsRequerido = False
        Me.RESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RESPONSABLE_ID.LabelConsulta = Nothing
        Me.RESPONSABLE_ID.Location = New System.Drawing.Point(125, 39)
        Me.RESPONSABLE_ID.MaxLength = 5
        Me.RESPONSABLE_ID.Name = "RESPONSABLE_ID"
        Me.RESPONSABLE_ID.NombreDeConsulta = Nothing
        Me.RESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RESPONSABLE_ID.Size = New System.Drawing.Size(70, 20)
        Me.RESPONSABLE_ID.TabIndex = 12
        '
        'DETALLE
        '
        Me.DETALLE.AllowUserToAddRows = False
        Me.DETALLE.AllowUserToDeleteRows = False
        Me.DETALLE.Location = New System.Drawing.Point(6, 105)
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.RowHeadersVisible = False
        Me.DETALLE.Size = New System.Drawing.Size(659, 192)
        Me.DETALLE.TabIndex = 16
        '
        'lblOBSERVACIONES_DET
        '
        Me.lblOBSERVACIONES_DET.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblOBSERVACIONES_DET.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOBSERVACIONES_DET.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOBSERVACIONES_DET.ForeColor = System.Drawing.SystemColors.Window
        Me.lblOBSERVACIONES_DET.Location = New System.Drawing.Point(6, 79)
        Me.lblOBSERVACIONES_DET.Name = "lblOBSERVACIONES_DET"
        Me.lblOBSERVACIONES_DET.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOBSERVACIONES_DET.Size = New System.Drawing.Size(119, 20)
        Me.lblOBSERVACIONES_DET.TabIndex = 41
        Me.lblOBSERVACIONES_DET.Text = "[Observaciones]"
        Me.lblOBSERVACIONES_DET.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'desCODIGO_DE_ACTIVO
        '
        Me.desCODIGO_DE_ACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.desCODIGO_DE_ACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.desCODIGO_DE_ACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desCODIGO_DE_ACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.desCODIGO_DE_ACTIVO.Location = New System.Drawing.Point(307, 59)
        Me.desCODIGO_DE_ACTIVO.Name = "desCODIGO_DE_ACTIVO"
        Me.desCODIGO_DE_ACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.desCODIGO_DE_ACTIVO.Size = New System.Drawing.Size(344, 20)
        Me.desCODIGO_DE_ACTIVO.TabIndex = 40
        '
        'lblACTIVO
        '
        Me.lblACTIVO.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTIVO.ForeColor = System.Drawing.SystemColors.Window
        Me.lblACTIVO.Location = New System.Drawing.Point(6, 59)
        Me.lblACTIVO.Name = "lblACTIVO"
        Me.lblACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTIVO.Size = New System.Drawing.Size(119, 20)
        Me.lblACTIVO.TabIndex = 39
        Me.lblACTIVO.Text = "Activo fijo"
        Me.lblACTIVO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRESPONSABLE_ID
        '
        Me.lblRESPONSABLE_ID.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRESPONSABLE_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRESPONSABLE_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRESPONSABLE_ID.ForeColor = System.Drawing.SystemColors.Window
        Me.lblRESPONSABLE_ID.Location = New System.Drawing.Point(6, 39)
        Me.lblRESPONSABLE_ID.Name = "lblRESPONSABLE_ID"
        Me.lblRESPONSABLE_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRESPONSABLE_ID.Size = New System.Drawing.Size(119, 20)
        Me.lblRESPONSABLE_ID.TabIndex = 38
        Me.lblRESPONSABLE_ID.Text = "Responsable"
        Me.lblRESPONSABLE_ID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdImportar
        '
        Me.cmdImportar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImportar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImportar.Location = New System.Drawing.Point(410, 529)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportar.Size = New System.Drawing.Size(87, 25)
        Me.cmdImportar.TabIndex = 36
        Me.cmdImportar.Text = "&Importar"
        Me.cmdImportar.UseVisualStyleBackColor = False
        Me.cmdImportar.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(596, 529)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 38
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(503, 529)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 37
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'lblRegistro
        '
        Me.lblRegistro.BackColor = System.Drawing.SystemColors.Control
        Me.lblRegistro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRegistro.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRegistro.Location = New System.Drawing.Point(12, 526)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRegistro.Size = New System.Drawing.Size(299, 31)
        Me.lblRegistro.TabIndex = 42
        Me.lblRegistro.Text = "No se puede agregar ningún registro porque ésta transacción ha sido importada."
        '
        'ACTTOMM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(695, 566)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.frmTOMA)
        Me.Controls.Add(Me.frmAUDIT)
        Me.Controls.Add(Me.frmDET)
        Me.Controls.Add(Me.cmdImportar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTTOMM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toma física de activos - ACTTOMM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmTOMA.ResumeLayout(False)
        Me.frmTOMA.PerformLayout()
        Me.frmAUDIT.ResumeLayout(False)
        Me.frmDET.ResumeLayout(False)
        Me.frmDET.PerformLayout()
        CType(Me.DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdExportar As System.Windows.Forms.Button
    Public WithEvents OBSERVACIONES As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents frmTOMA As System.Windows.Forms.GroupBox
    Public WithEvents RESPONSABLE_TOMA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents NUMERO_TOMA As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents FECHA_TOMA As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents ESTADO_TOMA As System.Windows.Forms.Label
    Public WithEvents lblOBSERVACIONES As System.Windows.Forms.Label
    Public WithEvents lblRESPONSABLE_TOMA As System.Windows.Forms.Label
    Public WithEvents lblNUMERO_TOMA As System.Windows.Forms.Label
    Public WithEvents lblFECHA_TOMA As System.Windows.Forms.Label
    Public WithEvents lblMask As System.Windows.Forms.Label
    Public WithEvents IMPORTADA As System.Windows.Forms.CheckBox
    Public WithEvents lblCODIGO_UBICACION As System.Windows.Forms.Label
    Public WithEvents FECHA_AUT As System.Windows.Forms.Label
    Public WithEvents frmAUDIT As System.Windows.Forms.GroupBox
    Public WithEvents USUARIO_AUT As System.Windows.Forms.Label
    Public WithEvents lblAUTOR As System.Windows.Forms.Label
    Public WithEvents FECHA_IMP As System.Windows.Forms.Label
    Public WithEvents USUARIO_IMP As System.Windows.Forms.Label
    Public WithEvents lblIMPORT As System.Windows.Forms.Label
    Public WithEvents FECHA_ING As System.Windows.Forms.Label
    Public WithEvents USUARIO_ING As System.Windows.Forms.Label
    Public WithEvents lblFECHA As System.Windows.Forms.Label
    Public WithEvents lblUSUARIO As System.Windows.Forms.Label
    Public WithEvents lblINGRESO As System.Windows.Forms.Label
    Public WithEvents desCODIGO_UBICACION As System.Windows.Forms.Label
    Public WithEvents OBSERVACIONES_DET As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents CODIGO_DE_ACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents MEJORA_CORRELATIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents desRESPONSABLE_ID As System.Windows.Forms.Label
    Public WithEvents frmDET As System.Windows.Forms.GroupBox
    Public WithEvents RESPONSABLE_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents CODIGO_UBICACION As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents DETALLE As System.Windows.Forms.DataGridView
    Public WithEvents lblOBSERVACIONES_DET As System.Windows.Forms.Label
    Public WithEvents desCODIGO_DE_ACTIVO As System.Windows.Forms.Label
    Public WithEvents lblACTIVO As System.Windows.Forms.Label
    Public WithEvents lblRESPONSABLE_ID As System.Windows.Forms.Label
    Public WithEvents cmdImportar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents lblModificada As System.Windows.Forms.Label
    Public WithEvents lblRegistro As System.Windows.Forms.Label
End Class
