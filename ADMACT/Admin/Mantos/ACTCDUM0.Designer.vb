<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTCDUM0
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
        Me.txtCAMPO_ID = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCAMPO_NOMBRE = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtCAMPO_TITULO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.cboCAMPO_LISTA_VALORES = New System.Windows.Forms.ComboBox()
        Me.cboCAMPO_OPCIONAL = New System.Windows.Forms.ComboBox()
        Me.txtCODIGO_TIPOACTIVO = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblDESCRIPCION_TIPOACTIVO = New System.Windows.Forms.Label()
        Me.lblTIPOACTIVO = New System.Windows.Forms.Label()
        Me.lblTitCAMPO_LISTA_VALORES = New System.Windows.Forms.Label()
        Me.lblTitCAMPO_OPCIONAL = New System.Windows.Forms.Label()
        Me.lblTitCAMPO_TITULO = New System.Windows.Forms.Label()
        Me.lblTitCAMPO_NOMBRE = New System.Windows.Forms.Label()
        Me.lblTitCAMPO_ID = New System.Windows.Forms.Label()
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
        Me.cmdCancelar.Location = New System.Drawing.Point(437, 198)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(344, 198)
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
        Me.Frame1.Controls.Add(Me.txtCAMPO_ID)
        Me.Frame1.Controls.Add(Me.txtCAMPO_NOMBRE)
        Me.Frame1.Controls.Add(Me.txtCAMPO_TITULO)
        Me.Frame1.Controls.Add(Me.cboCAMPO_LISTA_VALORES)
        Me.Frame1.Controls.Add(Me.cboCAMPO_OPCIONAL)
        Me.Frame1.Controls.Add(Me.txtCODIGO_TIPOACTIVO)
        Me.Frame1.Controls.Add(Me.lblDESCRIPCION_TIPOACTIVO)
        Me.Frame1.Controls.Add(Me.lblTIPOACTIVO)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_LISTA_VALORES)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_OPCIONAL)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_TITULO)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_NOMBRE)
        Me.Frame1.Controls.Add(Me.lblTitCAMPO_ID)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(512, 180)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtCAMPO_ID
        '
        Me.txtCAMPO_ID.AcceptsReturn = True
        Me.txtCAMPO_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCAMPO_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCAMPO_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCAMPO_ID.EsRequerido = True
        Me.txtCAMPO_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAMPO_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCAMPO_ID.LabelConsulta = Nothing
        Me.txtCAMPO_ID.Location = New System.Drawing.Point(140, 19)
        Me.txtCAMPO_ID.MaxLength = 3
        Me.txtCAMPO_ID.Name = "txtCAMPO_ID"
        Me.txtCAMPO_ID.NombreDeConsulta = Nothing
        Me.txtCAMPO_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCAMPO_ID.Size = New System.Drawing.Size(33, 20)
        Me.txtCAMPO_ID.TabIndex = 1
        '
        'txtCAMPO_NOMBRE
        '
        Me.txtCAMPO_NOMBRE.AcceptsReturn = True
        Me.txtCAMPO_NOMBRE.BackColor = System.Drawing.SystemColors.Window
        Me.txtCAMPO_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCAMPO_NOMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCAMPO_NOMBRE.EsRequerido = True
        Me.txtCAMPO_NOMBRE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAMPO_NOMBRE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCAMPO_NOMBRE.LabelConsulta = Nothing
        Me.txtCAMPO_NOMBRE.Location = New System.Drawing.Point(140, 45)
        Me.txtCAMPO_NOMBRE.MaxLength = 40
        Me.txtCAMPO_NOMBRE.Name = "txtCAMPO_NOMBRE"
        Me.txtCAMPO_NOMBRE.NombreDeConsulta = Nothing
        Me.txtCAMPO_NOMBRE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCAMPO_NOMBRE.Size = New System.Drawing.Size(347, 20)
        Me.txtCAMPO_NOMBRE.TabIndex = 2
        '
        'txtCAMPO_TITULO
        '
        Me.txtCAMPO_TITULO.AcceptsReturn = True
        Me.txtCAMPO_TITULO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCAMPO_TITULO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCAMPO_TITULO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCAMPO_TITULO.EsRequerido = True
        Me.txtCAMPO_TITULO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAMPO_TITULO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCAMPO_TITULO.LabelConsulta = Nothing
        Me.txtCAMPO_TITULO.Location = New System.Drawing.Point(140, 71)
        Me.txtCAMPO_TITULO.MaxLength = 20
        Me.txtCAMPO_TITULO.Name = "txtCAMPO_TITULO"
        Me.txtCAMPO_TITULO.NombreDeConsulta = Nothing
        Me.txtCAMPO_TITULO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCAMPO_TITULO.Size = New System.Drawing.Size(174, 20)
        Me.txtCAMPO_TITULO.TabIndex = 3
        '
        'cboCAMPO_LISTA_VALORES
        '
        Me.cboCAMPO_LISTA_VALORES.BackColor = System.Drawing.SystemColors.Window
        Me.cboCAMPO_LISTA_VALORES.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCAMPO_LISTA_VALORES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCAMPO_LISTA_VALORES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCAMPO_LISTA_VALORES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCAMPO_LISTA_VALORES.Location = New System.Drawing.Point(140, 125)
        Me.cboCAMPO_LISTA_VALORES.Name = "cboCAMPO_LISTA_VALORES"
        Me.cboCAMPO_LISTA_VALORES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCAMPO_LISTA_VALORES.Size = New System.Drawing.Size(174, 22)
        Me.cboCAMPO_LISTA_VALORES.TabIndex = 5
        '
        'cboCAMPO_OPCIONAL
        '
        Me.cboCAMPO_OPCIONAL.BackColor = System.Drawing.SystemColors.Window
        Me.cboCAMPO_OPCIONAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCAMPO_OPCIONAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCAMPO_OPCIONAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCAMPO_OPCIONAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCAMPO_OPCIONAL.Location = New System.Drawing.Point(140, 97)
        Me.cboCAMPO_OPCIONAL.Name = "cboCAMPO_OPCIONAL"
        Me.cboCAMPO_OPCIONAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCAMPO_OPCIONAL.Size = New System.Drawing.Size(174, 22)
        Me.cboCAMPO_OPCIONAL.TabIndex = 4
        '
        'txtCODIGO_TIPOACTIVO
        '
        Me.txtCODIGO_TIPOACTIVO.AcceptsReturn = True
        Me.txtCODIGO_TIPOACTIVO.BackColor = System.Drawing.SystemColors.Window
        Me.txtCODIGO_TIPOACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO_TIPOACTIVO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCODIGO_TIPOACTIVO.EsRequerido = False
        Me.txtCODIGO_TIPOACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO_TIPOACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCODIGO_TIPOACTIVO.LabelConsulta = Nothing
        Me.txtCODIGO_TIPOACTIVO.Location = New System.Drawing.Point(140, 153)
        Me.txtCODIGO_TIPOACTIVO.MaxLength = 7
        Me.txtCODIGO_TIPOACTIVO.Name = "txtCODIGO_TIPOACTIVO"
        Me.txtCODIGO_TIPOACTIVO.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeTiposDeActivos_TIPOACT
        Me.txtCODIGO_TIPOACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCODIGO_TIPOACTIVO.Size = New System.Drawing.Size(71, 20)
        Me.txtCODIGO_TIPOACTIVO.TabIndex = 6
        '
        'lblDESCRIPCION_TIPOACTIVO
        '
        Me.lblDESCRIPCION_TIPOACTIVO.BackColor = System.Drawing.SystemColors.Control
        Me.lblDESCRIPCION_TIPOACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDESCRIPCION_TIPOACTIVO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION_TIPOACTIVO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDESCRIPCION_TIPOACTIVO.Location = New System.Drawing.Point(240, 155)
        Me.lblDESCRIPCION_TIPOACTIVO.Name = "lblDESCRIPCION_TIPOACTIVO"
        Me.lblDESCRIPCION_TIPOACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDESCRIPCION_TIPOACTIVO.Size = New System.Drawing.Size(266, 20)
        Me.lblDESCRIPCION_TIPOACTIVO.TabIndex = 15
        Me.lblDESCRIPCION_TIPOACTIVO.UseMnemonic = False
        '
        'lblTIPOACTIVO
        '
        Me.lblTIPOACTIVO.BackColor = System.Drawing.Color.Transparent
        Me.lblTIPOACTIVO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTIPOACTIVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIPOACTIVO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTIPOACTIVO.Location = New System.Drawing.Point(6, 155)
        Me.lblTIPOACTIVO.Name = "lblTIPOACTIVO"
        Me.lblTIPOACTIVO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTIPOACTIVO.Size = New System.Drawing.Size(128, 14)
        Me.lblTIPOACTIVO.TabIndex = 14
        Me.lblTIPOACTIVO.Text = "Tipo de activo"
        '
        'lblTitCAMPO_LISTA_VALORES
        '
        Me.lblTitCAMPO_LISTA_VALORES.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_LISTA_VALORES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_LISTA_VALORES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_LISTA_VALORES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_LISTA_VALORES.Location = New System.Drawing.Point(6, 128)
        Me.lblTitCAMPO_LISTA_VALORES.Name = "lblTitCAMPO_LISTA_VALORES"
        Me.lblTitCAMPO_LISTA_VALORES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_LISTA_VALORES.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCAMPO_LISTA_VALORES.TabIndex = 8
        Me.lblTitCAMPO_LISTA_VALORES.Text = "Lista valores"
        '
        'lblTitCAMPO_OPCIONAL
        '
        Me.lblTitCAMPO_OPCIONAL.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_OPCIONAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_OPCIONAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_OPCIONAL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_OPCIONAL.Location = New System.Drawing.Point(6, 100)
        Me.lblTitCAMPO_OPCIONAL.Name = "lblTitCAMPO_OPCIONAL"
        Me.lblTitCAMPO_OPCIONAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_OPCIONAL.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCAMPO_OPCIONAL.TabIndex = 9
        Me.lblTitCAMPO_OPCIONAL.Text = "Obligatorio / Opcional"
        '
        'lblTitCAMPO_TITULO
        '
        Me.lblTitCAMPO_TITULO.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_TITULO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_TITULO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_TITULO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_TITULO.Location = New System.Drawing.Point(6, 73)
        Me.lblTitCAMPO_TITULO.Name = "lblTitCAMPO_TITULO"
        Me.lblTitCAMPO_TITULO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_TITULO.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCAMPO_TITULO.TabIndex = 10
        Me.lblTitCAMPO_TITULO.Text = "Título"
        '
        'lblTitCAMPO_NOMBRE
        '
        Me.lblTitCAMPO_NOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_NOMBRE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_NOMBRE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_NOMBRE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_NOMBRE.Location = New System.Drawing.Point(6, 47)
        Me.lblTitCAMPO_NOMBRE.Name = "lblTitCAMPO_NOMBRE"
        Me.lblTitCAMPO_NOMBRE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_NOMBRE.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCAMPO_NOMBRE.TabIndex = 11
        Me.lblTitCAMPO_NOMBRE.Text = "Nombre"
        '
        'lblTitCAMPO_ID
        '
        Me.lblTitCAMPO_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblTitCAMPO_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitCAMPO_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCAMPO_ID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitCAMPO_ID.Location = New System.Drawing.Point(6, 21)
        Me.lblTitCAMPO_ID.Name = "lblTitCAMPO_ID"
        Me.lblTitCAMPO_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitCAMPO_ID.Size = New System.Drawing.Size(128, 14)
        Me.lblTitCAMPO_ID.TabIndex = 12
        Me.lblTitCAMPO_ID.Text = "Campo"
        '
        'ACTCDUM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(536, 235)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTCDUM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de campos definidos por el usuario - ACTCDUM0"
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
    Public WithEvents txtCODIGO_TIPOACTIVO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCAMPO_TITULO As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCAMPO_NOMBRE As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtCAMPO_ID As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblDESCRIPCION_TIPOACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTIPOACTIVO As System.Windows.Forms.Label
    Public WithEvents lblTitCAMPO_LISTA_VALORES As System.Windows.Forms.Label
    Public WithEvents lblTitCAMPO_OPCIONAL As System.Windows.Forms.Label
    Public WithEvents lblTitCAMPO_TITULO As System.Windows.Forms.Label
    Public WithEvents lblTitCAMPO_NOMBRE As System.Windows.Forms.Label
    Public WithEvents lblTitCAMPO_ID As System.Windows.Forms.Label
    Public WithEvents cboCAMPO_LISTA_VALORES As System.Windows.Forms.ComboBox
    Public WithEvents cboCAMPO_OPCIONAL As System.Windows.Forms.ComboBox
End Class
