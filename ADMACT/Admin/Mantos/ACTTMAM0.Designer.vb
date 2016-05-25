<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTTMAM0
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
        Me.txtTIPO_MOVIMIENTO = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.txtDESCRIPCION_TIP_MOV = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboCLASE_MOVIMIENTO = New System.Windows.Forms.ComboBox()
        Me.txtTIPO_PARTIDA = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblTitTIPO_PARTIDA = New System.Windows.Forms.Label()
        Me.lblTitCLASE_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblTitDESCRIPCION_TIP_MOV = New System.Windows.Forms.Label()
        Me.lblTitTIPO_MOVIMIENTO = New System.Windows.Forms.Label()
        Me.lblnombretipopartida = New System.Windows.Forms.Label()
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
        Me.cmdCancelar.Location = New System.Drawing.Point(437, 148)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(344, 148)
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
        Me.Frame1.Controls.Add(Me.txtTIPO_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.txtDESCRIPCION_TIP_MOV)
        Me.Frame1.Controls.Add(Me.cboCLASE_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.txtTIPO_PARTIDA)
        Me.Frame1.Controls.Add(Me.lblTitTIPO_PARTIDA)
        Me.Frame1.Controls.Add(Me.lblTitCLASE_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.lblTitDESCRIPCION_TIP_MOV)
        Me.Frame1.Controls.Add(Me.lblTitTIPO_MOVIMIENTO)
        Me.Frame1.Controls.Add(Me.lblnombretipopartida)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(512, 130)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtTIPO_MOVIMIENTO
        '
        Me.txtTIPO_MOVIMIENTO.AcceptsReturn = True
        Me.txtTIPO_MOVIMIENTO.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIPO_MOVIMIENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIPO_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIPO_MOVIMIENTO.EsRequerido = True
        Me.txtTIPO_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_MOVIMIENTO.LabelConsulta = Nothing
        Me.txtTIPO_MOVIMIENTO.Location = New System.Drawing.Point(154, 19)
        Me.txtTIPO_MOVIMIENTO.MaxLength = 1
        Me.txtTIPO_MOVIMIENTO.Multiline = True
        Me.txtTIPO_MOVIMIENTO.Name = "txtTIPO_MOVIMIENTO"
        Me.txtTIPO_MOVIMIENTO.NombreDeConsulta = Nothing
        Me.txtTIPO_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_MOVIMIENTO.Size = New System.Drawing.Size(52, 20)
        Me.txtTIPO_MOVIMIENTO.TabIndex = 1
        Me.txtTIPO_MOVIMIENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDESCRIPCION_TIP_MOV
        '
        Me.txtDESCRIPCION_TIP_MOV.AcceptsReturn = True
        Me.txtDESCRIPCION_TIP_MOV.BackColor = System.Drawing.SystemColors.Window
        Me.txtDESCRIPCION_TIP_MOV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION_TIP_MOV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDESCRIPCION_TIP_MOV.EsRequerido = True
        Me.txtDESCRIPCION_TIP_MOV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION_TIP_MOV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDESCRIPCION_TIP_MOV.LabelConsulta = Nothing
        Me.txtDESCRIPCION_TIP_MOV.Location = New System.Drawing.Point(154, 45)
        Me.txtDESCRIPCION_TIP_MOV.MaxLength = 40
        Me.txtDESCRIPCION_TIP_MOV.Name = "txtDESCRIPCION_TIP_MOV"
        Me.txtDESCRIPCION_TIP_MOV.NombreDeConsulta = Nothing
        Me.txtDESCRIPCION_TIP_MOV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDESCRIPCION_TIP_MOV.Size = New System.Drawing.Size(329, 20)
        Me.txtDESCRIPCION_TIP_MOV.TabIndex = 2
        '
        'cboCLASE_MOVIMIENTO
        '
        Me.cboCLASE_MOVIMIENTO.BackColor = System.Drawing.SystemColors.Window
        Me.cboCLASE_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCLASE_MOVIMIENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCLASE_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCLASE_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCLASE_MOVIMIENTO.Location = New System.Drawing.Point(154, 71)
        Me.cboCLASE_MOVIMIENTO.Name = "cboCLASE_MOVIMIENTO"
        Me.cboCLASE_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCLASE_MOVIMIENTO.Size = New System.Drawing.Size(329, 22)
        Me.cboCLASE_MOVIMIENTO.TabIndex = 3
        '
        'txtTIPO_PARTIDA
        '
        Me.txtTIPO_PARTIDA.AcceptsReturn = True
        Me.txtTIPO_PARTIDA.BackColor = System.Drawing.SystemColors.Window
        Me.txtTIPO_PARTIDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIPO_PARTIDA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIPO_PARTIDA.EsRequerido = False
        Me.txtTIPO_PARTIDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIPO_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTIPO_PARTIDA.LabelConsulta = Nothing
        Me.txtTIPO_PARTIDA.Location = New System.Drawing.Point(154, 99)
        Me.txtTIPO_PARTIDA.MaxLength = 3
        Me.txtTIPO_PARTIDA.Name = "txtTIPO_PARTIDA"
        Me.txtTIPO_PARTIDA.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDePartidas_TIPARC01
        Me.txtTIPO_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTIPO_PARTIDA.Size = New System.Drawing.Size(52, 20)
        Me.txtTIPO_PARTIDA.TabIndex = 4
        '
        'lblTitTIPO_PARTIDA
        '
        Me.lblTitTIPO_PARTIDA.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_PARTIDA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_PARTIDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_PARTIDA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_PARTIDA.Location = New System.Drawing.Point(6, 101)
        Me.lblTitTIPO_PARTIDA.Name = "lblTitTIPO_PARTIDA"
        Me.lblTitTIPO_PARTIDA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_PARTIDA.Size = New System.Drawing.Size(142, 14)
        Me.lblTitTIPO_PARTIDA.TabIndex = 6
        Me.lblTitTIPO_PARTIDA.Text = "Tipo de partida"
        '
        'lblTitCLASE_MOVIMIENTO
        '
        Me.lblTitCLASE_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCLASE_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCLASE_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCLASE_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCLASE_MOVIMIENTO.Location = New System.Drawing.Point(6, 74)
        Me.lblTitCLASE_MOVIMIENTO.Name = "lblTitCLASE_MOVIMIENTO"
        Me.lblTitCLASE_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCLASE_MOVIMIENTO.Size = New System.Drawing.Size(142, 14)
        Me.lblTitCLASE_MOVIMIENTO.TabIndex = 7
        Me.lblTitCLASE_MOVIMIENTO.Text = "Clase de movimiento"
        '
        'lblTitDESCRIPCION_TIP_MOV
        '
        Me.lblTitDESCRIPCION_TIP_MOV.BackColor = System.Drawing.Color.Transparent
        Me.lblTitDESCRIPCION_TIP_MOV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitDESCRIPCION_TIP_MOV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDESCRIPCION_TIP_MOV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitDESCRIPCION_TIP_MOV.Location = New System.Drawing.Point(6, 47)
        Me.lblTitDESCRIPCION_TIP_MOV.Name = "lblTitDESCRIPCION_TIP_MOV"
        Me.lblTitDESCRIPCION_TIP_MOV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitDESCRIPCION_TIP_MOV.Size = New System.Drawing.Size(142, 14)
        Me.lblTitDESCRIPCION_TIP_MOV.TabIndex = 8
        Me.lblTitDESCRIPCION_TIP_MOV.Text = "Descripción"
        '
        'lblTitTIPO_MOVIMIENTO
        '
        Me.lblTitTIPO_MOVIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTIPO_MOVIMIENTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTIPO_MOVIMIENTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTIPO_MOVIMIENTO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTIPO_MOVIMIENTO.Location = New System.Drawing.Point(6, 21)
        Me.lblTitTIPO_MOVIMIENTO.Name = "lblTitTIPO_MOVIMIENTO"
        Me.lblTitTIPO_MOVIMIENTO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTIPO_MOVIMIENTO.Size = New System.Drawing.Size(142, 14)
        Me.lblTitTIPO_MOVIMIENTO.TabIndex = 9
        Me.lblTitTIPO_MOVIMIENTO.Text = "Tipo de movimiento"
        '
        'lblnombretipopartida
        '
        Me.lblnombretipopartida.BackColor = System.Drawing.Color.Transparent
        Me.lblnombretipopartida.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombretipopartida.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombretipopartida.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombretipopartida.Location = New System.Drawing.Point(224, 101)
        Me.lblnombretipopartida.Name = "lblnombretipopartida"
        Me.lblnombretipopartida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombretipopartida.Size = New System.Drawing.Size(282, 20)
        Me.lblnombretipopartida.TabIndex = 10
        Me.lblnombretipopartida.UseMnemonic = False
        '
        'ACTTMAM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(536, 185)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTTMAM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento a tipos de movimientos de activos - ACTTMAM0"
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
    Public WithEvents txtTIPO_PARTIDA As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtDESCRIPCION_TIP_MOV As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtTIPO_MOVIMIENTO As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents lblTitTIPO_PARTIDA As System.Windows.Forms.Label
    Public WithEvents lblTitCLASE_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblTitDESCRIPCION_TIP_MOV As System.Windows.Forms.Label
    Public WithEvents lblTitTIPO_MOVIMIENTO As System.Windows.Forms.Label
    Public WithEvents lblnombretipopartida As System.Windows.Forms.Label
    Public WithEvents cboCLASE_MOVIMIENTO As System.Windows.Forms.ComboBox
End Class
