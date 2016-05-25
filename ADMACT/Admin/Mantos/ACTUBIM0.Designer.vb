<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTUBIM0
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
        Me.CODIGO_UBICACION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.DESCRIPCION_UBICACION = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboESTADO_UBICACION = New System.Windows.Forms.ComboBox()
        Me.lblESTADO_UBICACION = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION_UBICACION = New System.Windows.Forms.Label()
        Me.lblCODIGO_UBICACION = New System.Windows.Forms.Label()
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
        Me.cmdCancelar.Location = New System.Drawing.Point(437, 124)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(341, 124)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.CODIGO_UBICACION)
        Me.Frame1.Controls.Add(Me.DESCRIPCION_UBICACION)
        Me.Frame1.Controls.Add(Me.cboESTADO_UBICACION)
        Me.Frame1.Controls.Add(Me.lblESTADO_UBICACION)
        Me.Frame1.Controls.Add(Me.lblDESCRIPCION_UBICACION)
        Me.Frame1.Controls.Add(Me.lblCODIGO_UBICACION)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(512, 106)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'CODIGO_UBICACION
        '
        Me.CODIGO_UBICACION.AcceptsReturn = True
        Me.CODIGO_UBICACION.BackColor = System.Drawing.SystemColors.Window
        Me.CODIGO_UBICACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CODIGO_UBICACION.EsRequerido = True
        Me.CODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CODIGO_UBICACION.LabelConsulta = Nothing
        Me.CODIGO_UBICACION.Location = New System.Drawing.Point(108, 19)
        Me.CODIGO_UBICACION.MaxLength = 10
        Me.CODIGO_UBICACION.Name = "CODIGO_UBICACION"
        Me.CODIGO_UBICACION.NombreDeConsulta = Nothing
        Me.CODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CODIGO_UBICACION.Size = New System.Drawing.Size(90, 20)
        Me.CODIGO_UBICACION.TabIndex = 0
        '
        'DESCRIPCION_UBICACION
        '
        Me.DESCRIPCION_UBICACION.AcceptsReturn = True
        Me.DESCRIPCION_UBICACION.BackColor = System.Drawing.SystemColors.Window
        Me.DESCRIPCION_UBICACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DESCRIPCION_UBICACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DESCRIPCION_UBICACION.EsRequerido = True
        Me.DESCRIPCION_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESCRIPCION_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DESCRIPCION_UBICACION.LabelConsulta = Nothing
        Me.DESCRIPCION_UBICACION.Location = New System.Drawing.Point(108, 45)
        Me.DESCRIPCION_UBICACION.MaxLength = 50
        Me.DESCRIPCION_UBICACION.Name = "DESCRIPCION_UBICACION"
        Me.DESCRIPCION_UBICACION.NombreDeConsulta = Nothing
        Me.DESCRIPCION_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DESCRIPCION_UBICACION.Size = New System.Drawing.Size(347, 20)
        Me.DESCRIPCION_UBICACION.TabIndex = 1
        '
        'cboESTADO_UBICACION
        '
        Me.cboESTADO_UBICACION.BackColor = System.Drawing.SystemColors.Window
        Me.cboESTADO_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboESTADO_UBICACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboESTADO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboESTADO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboESTADO_UBICACION.Location = New System.Drawing.Point(108, 71)
        Me.cboESTADO_UBICACION.Name = "cboESTADO_UBICACION"
        Me.cboESTADO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboESTADO_UBICACION.Size = New System.Drawing.Size(275, 22)
        Me.cboESTADO_UBICACION.TabIndex = 2
        '
        'lblESTADO_UBICACION
        '
        Me.lblESTADO_UBICACION.BackColor = System.Drawing.Color.Transparent
        Me.lblESTADO_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblESTADO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESTADO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblESTADO_UBICACION.Location = New System.Drawing.Point(6, 74)
        Me.lblESTADO_UBICACION.Name = "lblESTADO_UBICACION"
        Me.lblESTADO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblESTADO_UBICACION.Size = New System.Drawing.Size(96, 14)
        Me.lblESTADO_UBICACION.TabIndex = 5
        Me.lblESTADO_UBICACION.Text = "Estado"
        '
        'lblDESCRIPCION_UBICACION
        '
        Me.lblDESCRIPCION_UBICACION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDESCRIPCION_UBICACION.Location = New System.Drawing.Point(6, 47)
        Me.lblDESCRIPCION_UBICACION.Name = "lblDESCRIPCION_UBICACION"
        Me.lblDESCRIPCION_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_UBICACION.Size = New System.Drawing.Size(96, 14)
        Me.lblDESCRIPCION_UBICACION.TabIndex = 6
        Me.lblDESCRIPCION_UBICACION.Text = "Descripción"
        '
        'lblCODIGO_UBICACION
        '
        Me.lblCODIGO_UBICACION.BackColor = System.Drawing.Color.Transparent
        Me.lblCODIGO_UBICACION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCODIGO_UBICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO_UBICACION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCODIGO_UBICACION.Location = New System.Drawing.Point(6, 21)
        Me.lblCODIGO_UBICACION.Name = "lblCODIGO_UBICACION"
        Me.lblCODIGO_UBICACION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCODIGO_UBICACION.Size = New System.Drawing.Size(96, 14)
        Me.lblCODIGO_UBICACION.TabIndex = 7
        Me.lblCODIGO_UBICACION.Text = "Código"
        '
        'ACTUBIM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(536, 161)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTUBIM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de ubicaciones - ACTUBIM0"
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
    Public WithEvents DESCRIPCION_UBICACION As Citi.Synergia.UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents CODIGO_UBICACION As Citi.Synergia.UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents lblESTADO_UBICACION As System.Windows.Forms.Label
    Public WithEvents lblDESCRIPCION_UBICACION As System.Windows.Forms.Label
    Public WithEvents lblCODIGO_UBICACION As System.Windows.Forms.Label
    Public WithEvents cboESTADO_UBICACION As System.Windows.Forms.ComboBox
End Class
