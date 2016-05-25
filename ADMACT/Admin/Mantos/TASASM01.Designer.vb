<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TASASM01
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
        Me.txtFECHA_DE_LA_TASA = New Citi.Synergia.UIGenerico.SynTextoFecha()
        Me.cboTIP_CAMBIO_TASAS_CAM = New System.Windows.Forms.ComboBox()
        Me.txtTASA_CONVERSION = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtTASA_COMPRA = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDescripcionMonedaParam = New System.Windows.Forms.Label()
        Me.lblCodigoMonedaParam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreMoneda = New System.Windows.Forms.Label()
        Me.lblCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitCODIGO_DE_MONEDA = New System.Windows.Forms.Label()
        Me.lblTitTIP_CAMBIO_TASAS_CAM = New System.Windows.Forms.Label()
        Me.lblTitFECHA_DE_LA_TASA = New System.Windows.Forms.Label()
        Me.lblTitTASA_CONVERSION = New System.Windows.Forms.Label()
        Me.lblTitTASA_COMPRA = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFECHA_DE_LA_TASA
        '
        Me.txtFECHA_DE_LA_TASA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFECHA_DE_LA_TASA.EsRequerido = True
        Me.txtFECHA_DE_LA_TASA.Location = New System.Drawing.Point(137, 61)
        Me.txtFECHA_DE_LA_TASA.Mask = "00/00/0000"
        Me.txtFECHA_DE_LA_TASA.Name = "txtFECHA_DE_LA_TASA"
        Me.txtFECHA_DE_LA_TASA.Size = New System.Drawing.Size(160, 20)
        Me.txtFECHA_DE_LA_TASA.TabIndex = 3
        Me.txtFECHA_DE_LA_TASA.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFECHA_DE_LA_TASA.ValidatingType = GetType(Date)
        '
        'cboTIP_CAMBIO_TASAS_CAM
        '
        Me.cboTIP_CAMBIO_TASAS_CAM.BackColor = System.Drawing.SystemColors.Window
        Me.cboTIP_CAMBIO_TASAS_CAM.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTIP_CAMBIO_TASAS_CAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTIP_CAMBIO_TASAS_CAM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTIP_CAMBIO_TASAS_CAM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTIP_CAMBIO_TASAS_CAM.Location = New System.Drawing.Point(137, 33)
        Me.cboTIP_CAMBIO_TASAS_CAM.Name = "cboTIP_CAMBIO_TASAS_CAM"
        Me.cboTIP_CAMBIO_TASAS_CAM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTIP_CAMBIO_TASAS_CAM.Size = New System.Drawing.Size(253, 22)
        Me.cboTIP_CAMBIO_TASAS_CAM.TabIndex = 2
        '
        'txtTASA_CONVERSION
        '
        Me.txtTASA_CONVERSION.AcceptsReturn = True
        Me.txtTASA_CONVERSION.BackColor = System.Drawing.SystemColors.Window
        Me.txtTASA_CONVERSION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTASA_CONVERSION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTASA_CONVERSION.EsRequerido = True
        Me.txtTASA_CONVERSION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTASA_CONVERSION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTASA_CONVERSION.LabelConsulta = Nothing
        Me.txtTASA_CONVERSION.Location = New System.Drawing.Point(137, 87)
        Me.txtTASA_CONVERSION.MaxLength = 15
        Me.txtTASA_CONVERSION.Multiline = True
        Me.txtTASA_CONVERSION.Name = "txtTASA_CONVERSION"
        Me.txtTASA_CONVERSION.NombreDeConsulta = Nothing
        Me.txtTASA_CONVERSION.NumeroDecimales = 6
        Me.txtTASA_CONVERSION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTASA_CONVERSION.Size = New System.Drawing.Size(113, 21)
        Me.txtTASA_CONVERSION.TabIndex = 4
        Me.txtTASA_CONVERSION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTASA_COMPRA
        '
        Me.txtTASA_COMPRA.AcceptsReturn = True
        Me.txtTASA_COMPRA.BackColor = System.Drawing.SystemColors.Window
        Me.txtTASA_COMPRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTASA_COMPRA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTASA_COMPRA.EsRequerido = True
        Me.txtTASA_COMPRA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTASA_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTASA_COMPRA.LabelConsulta = Nothing
        Me.txtTASA_COMPRA.Location = New System.Drawing.Point(137, 114)
        Me.txtTASA_COMPRA.MaxLength = 15
        Me.txtTASA_COMPRA.Multiline = True
        Me.txtTASA_COMPRA.Name = "txtTASA_COMPRA"
        Me.txtTASA_COMPRA.NombreDeConsulta = Nothing
        Me.txtTASA_COMPRA.NumeroDecimales = 6
        Me.txtTASA_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTASA_COMPRA.Size = New System.Drawing.Size(113, 21)
        Me.txtTASA_COMPRA.TabIndex = 5
        Me.txtTASA_COMPRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(210, 204)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseMnemonic = False
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(303, 204)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseMnemonic = False
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(314, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "(DD/MM/AAAA)"
        Me.Label4.UseMnemonic = False
        '
        'lblDescripcionMonedaParam
        '
        Me.lblDescripcionMonedaParam.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcionMonedaParam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcionMonedaParam.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionMonedaParam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDescripcionMonedaParam.Location = New System.Drawing.Point(195, 165)
        Me.lblDescripcionMonedaParam.Name = "lblDescripcionMonedaParam"
        Me.lblDescripcionMonedaParam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcionMonedaParam.Size = New System.Drawing.Size(195, 20)
        Me.lblDescripcionMonedaParam.TabIndex = 31
        '
        'lblCodigoMonedaParam
        '
        Me.lblCodigoMonedaParam.BackColor = System.Drawing.SystemColors.Window
        Me.lblCodigoMonedaParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoMonedaParam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoMonedaParam.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoMonedaParam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoMonedaParam.Location = New System.Drawing.Point(137, 164)
        Me.lblCodigoMonedaParam.Name = "lblCodigoMonedaParam"
        Me.lblCodigoMonedaParam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoMonedaParam.Size = New System.Drawing.Size(52, 21)
        Me.lblCodigoMonedaParam.TabIndex = 6
        Me.lblCodigoMonedaParam.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(134, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(256, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tasas de cambio expresada para la moneda"
        Me.Label1.UseMnemonic = False
        '
        'lblNombreMoneda
        '
        Me.lblNombreMoneda.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreMoneda.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreMoneda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMoneda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreMoneda.Location = New System.Drawing.Point(195, 10)
        Me.lblNombreMoneda.Name = "lblNombreMoneda"
        Me.lblNombreMoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreMoneda.Size = New System.Drawing.Size(195, 20)
        Me.lblNombreMoneda.TabIndex = 29
        '
        'lblCODIGO_DE_MONEDA
        '
        Me.lblCODIGO_DE_MONEDA.BackColor = System.Drawing.SystemColors.Window
        Me.lblCODIGO_DE_MONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_DE_MONEDA.Location = New System.Drawing.Point(137, 9)
        Me.lblCODIGO_DE_MONEDA.Name = "lblCODIGO_DE_MONEDA"
        Me.lblCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_DE_MONEDA.Size = New System.Drawing.Size(52, 21)
        Me.lblCODIGO_DE_MONEDA.TabIndex = 1
        Me.lblCODIGO_DE_MONEDA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitCODIGO_DE_MONEDA
        '
        Me.lblTitCODIGO_DE_MONEDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCODIGO_DE_MONEDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCODIGO_DE_MONEDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCODIGO_DE_MONEDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCODIGO_DE_MONEDA.Location = New System.Drawing.Point(12, 12)
        Me.lblTitCODIGO_DE_MONEDA.Name = "lblTitCODIGO_DE_MONEDA"
        Me.lblTitCODIGO_DE_MONEDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCODIGO_DE_MONEDA.Size = New System.Drawing.Size(119, 14)
        Me.lblTitCODIGO_DE_MONEDA.TabIndex = 24
        Me.lblTitCODIGO_DE_MONEDA.Text = "Moneda"
        Me.lblTitCODIGO_DE_MONEDA.UseMnemonic = False
        '
        'lblTitTIP_CAMBIO_TASAS_CAM
        '
        Me.lblTitTIP_CAMBIO_TASAS_CAM.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIP_CAMBIO_TASAS_CAM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Location = New System.Drawing.Point(12, 36)
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Name = "lblTitTIP_CAMBIO_TASAS_CAM"
        Me.lblTitTIP_CAMBIO_TASAS_CAM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Size = New System.Drawing.Size(119, 14)
        Me.lblTitTIP_CAMBIO_TASAS_CAM.TabIndex = 25
        Me.lblTitTIP_CAMBIO_TASAS_CAM.Text = "Tipo de cambio"
        Me.lblTitTIP_CAMBIO_TASAS_CAM.UseMnemonic = False
        '
        'lblTitFECHA_DE_LA_TASA
        '
        Me.lblTitFECHA_DE_LA_TASA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitFECHA_DE_LA_TASA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitFECHA_DE_LA_TASA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFECHA_DE_LA_TASA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitFECHA_DE_LA_TASA.Location = New System.Drawing.Point(12, 64)
        Me.lblTitFECHA_DE_LA_TASA.Name = "lblTitFECHA_DE_LA_TASA"
        Me.lblTitFECHA_DE_LA_TASA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitFECHA_DE_LA_TASA.Size = New System.Drawing.Size(119, 14)
        Me.lblTitFECHA_DE_LA_TASA.TabIndex = 26
        Me.lblTitFECHA_DE_LA_TASA.Text = "Fecha de la tasa"
        Me.lblTitFECHA_DE_LA_TASA.UseMnemonic = False
        '
        'lblTitTASA_CONVERSION
        '
        Me.lblTitTASA_CONVERSION.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_CONVERSION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_CONVERSION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_CONVERSION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_CONVERSION.Location = New System.Drawing.Point(12, 89)
        Me.lblTitTASA_CONVERSION.Name = "lblTitTASA_CONVERSION"
        Me.lblTitTASA_CONVERSION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_CONVERSION.Size = New System.Drawing.Size(119, 14)
        Me.lblTitTASA_CONVERSION.TabIndex = 27
        Me.lblTitTASA_CONVERSION.Text = "Tasa de venta"
        Me.lblTitTASA_CONVERSION.UseMnemonic = False
        '
        'lblTitTASA_COMPRA
        '
        Me.lblTitTASA_COMPRA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTASA_COMPRA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTASA_COMPRA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTASA_COMPRA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTASA_COMPRA.Location = New System.Drawing.Point(12, 116)
        Me.lblTitTASA_COMPRA.Name = "lblTitTASA_COMPRA"
        Me.lblTitTASA_COMPRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTASA_COMPRA.Size = New System.Drawing.Size(119, 14)
        Me.lblTitTASA_COMPRA.TabIndex = 28
        Me.lblTitTASA_COMPRA.Text = "Tasa de compra"
        Me.lblTitTASA_COMPRA.UseMnemonic = False
        '
        'TASASM01
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(409, 245)
        Me.Controls.Add(Me.txtFECHA_DE_LA_TASA)
        Me.Controls.Add(Me.cboTIP_CAMBIO_TASAS_CAM)
        Me.Controls.Add(Me.txtTASA_CONVERSION)
        Me.Controls.Add(Me.txtTASA_COMPRA)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDescripcionMonedaParam)
        Me.Controls.Add(Me.lblCodigoMonedaParam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombreMoneda)
        Me.Controls.Add(Me.lblCODIGO_DE_MONEDA)
        Me.Controls.Add(Me.lblTitCODIGO_DE_MONEDA)
        Me.Controls.Add(Me.lblTitTIP_CAMBIO_TASAS_CAM)
        Me.Controls.Add(Me.lblTitFECHA_DE_LA_TASA)
        Me.Controls.Add(Me.lblTitTASA_CONVERSION)
        Me.Controls.Add(Me.lblTitTASA_COMPRA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "TASASM01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de tasas de cambio - TASASM01"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtFECHA_DE_LA_TASA As Citi.Synergia.UIGenerico.SynTextoFecha
    Public WithEvents cboTIP_CAMBIO_TASAS_CAM As System.Windows.Forms.ComboBox
    Public WithEvents txtTASA_CONVERSION As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents txtTASA_COMPRA As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lblDescripcionMonedaParam As System.Windows.Forms.Label
    Public WithEvents lblCodigoMonedaParam As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblNombreMoneda As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitCODIGO_DE_MONEDA As System.Windows.Forms.Label
    Public WithEvents lblTitTIP_CAMBIO_TASAS_CAM As System.Windows.Forms.Label
    Public WithEvents lblTitFECHA_DE_LA_TASA As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_CONVERSION As System.Windows.Forms.Label
    Public WithEvents lblTitTASA_COMPRA As System.Windows.Forms.Label
End Class
