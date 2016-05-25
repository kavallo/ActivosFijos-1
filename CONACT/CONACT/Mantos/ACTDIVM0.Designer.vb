<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTDIVM0
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblNombreCuentaContable = New System.Windows.Forms.Label()
        Me.lblNombreCentro = New System.Windows.Forms.Label()
        Me.lblNombreCatalogo = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCodigoDivision = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.Label()
        Me.txtTipoCatalogo = New System.Windows.Forms.Label()
        Me.txtCodigoCentro = New System.Windows.Forms.Label()
        Me.txtCuentaContable = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.lblCodigoCentro = New System.Windows.Forms.Label()
        Me.lblCuentaContable = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(479, 221)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 36
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'lblNombreCuentaContable
        '
        Me.lblNombreCuentaContable.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCuentaContable.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCuentaContable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuentaContable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCuentaContable.Location = New System.Drawing.Point(322, 191)
        Me.lblNombreCuentaContable.Name = "lblNombreCuentaContable"
        Me.lblNombreCuentaContable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCuentaContable.Size = New System.Drawing.Size(244, 20)
        Me.lblNombreCuentaContable.TabIndex = 39
        Me.lblNombreCuentaContable.UseMnemonic = False
        '
        'lblNombreCentro
        '
        Me.lblNombreCentro.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCentro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCentro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCentro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCentro.Location = New System.Drawing.Point(278, 167)
        Me.lblNombreCentro.Name = "lblNombreCentro"
        Me.lblNombreCentro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCentro.Size = New System.Drawing.Size(288, 20)
        Me.lblNombreCentro.TabIndex = 38
        Me.lblNombreCentro.UseMnemonic = False
        '
        'lblNombreCatalogo
        '
        Me.lblNombreCatalogo.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombreCatalogo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCatalogo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNombreCatalogo.Location = New System.Drawing.Point(219, 143)
        Me.lblNombreCatalogo.Name = "lblNombreCatalogo"
        Me.lblNombreCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombreCatalogo.Size = New System.Drawing.Size(347, 20)
        Me.lblNombreCatalogo.TabIndex = 37
        Me.lblNombreCatalogo.UseMnemonic = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcion.Location = New System.Drawing.Point(161, 46)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.Size = New System.Drawing.Size(405, 20)
        Me.txtDescripcion.TabIndex = 21
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.SystemColors.Window
        Me.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResponsable.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtResponsable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResponsable.Location = New System.Drawing.Point(161, 70)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsable.Size = New System.Drawing.Size(405, 20)
        Me.txtResponsable.TabIndex = 22
        '
        'txtCodigoDivision
        '
        Me.txtCodigoDivision.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCodigoDivision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoDivision.Location = New System.Drawing.Point(161, 22)
        Me.txtCodigoDivision.Name = "txtCodigoDivision"
        Me.txtCodigoDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoDivision.Size = New System.Drawing.Size(87, 20)
        Me.txtCodigoDivision.TabIndex = 20
        Me.txtCodigoDivision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDireccion.Location = New System.Drawing.Point(161, 94)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDireccion.Size = New System.Drawing.Size(405, 20)
        Me.txtDireccion.TabIndex = 23
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefono.Location = New System.Drawing.Point(161, 118)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelefono.Size = New System.Drawing.Size(174, 20)
        Me.txtTelefono.TabIndex = 24
        '
        'txtTipoCatalogo
        '
        Me.txtTipoCatalogo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTipoCatalogo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCatalogo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoCatalogo.Location = New System.Drawing.Point(161, 142)
        Me.txtTipoCatalogo.Name = "txtTipoCatalogo"
        Me.txtTipoCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoCatalogo.Size = New System.Drawing.Size(52, 20)
        Me.txtTipoCatalogo.TabIndex = 25
        '
        'txtCodigoCentro
        '
        Me.txtCodigoCentro.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoCentro.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCodigoCentro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCentro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoCentro.Location = New System.Drawing.Point(161, 166)
        Me.txtCodigoCentro.Name = "txtCodigoCentro"
        Me.txtCodigoCentro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoCentro.Size = New System.Drawing.Size(111, 20)
        Me.txtCodigoCentro.TabIndex = 26
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaContable.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCuentaContable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaContable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCuentaContable.Location = New System.Drawing.Point(161, 190)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuentaContable.Size = New System.Drawing.Size(155, 20)
        Me.txtCuentaContable.TabIndex = 27
        '
        'lblDivision
        '
        Me.lblDivision.BackColor = System.Drawing.Color.Transparent
        Me.lblDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDivision.Location = New System.Drawing.Point(31, 23)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDivision.Size = New System.Drawing.Size(124, 14)
        Me.lblDivision.TabIndex = 28
        Me.lblDivision.Text = "Departamento"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDescripcion.Location = New System.Drawing.Point(31, 47)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcion.Size = New System.Drawing.Size(124, 14)
        Me.lblDescripcion.TabIndex = 29
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblResponsable
        '
        Me.lblResponsable.BackColor = System.Drawing.Color.Transparent
        Me.lblResponsable.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResponsable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblResponsable.Location = New System.Drawing.Point(31, 71)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblResponsable.Size = New System.Drawing.Size(124, 14)
        Me.lblResponsable.TabIndex = 30
        Me.lblResponsable.Text = "Responsable"
        '
        'lblDireccion
        '
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDireccion.Location = New System.Drawing.Point(31, 95)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDireccion.Size = New System.Drawing.Size(124, 14)
        Me.lblDireccion.TabIndex = 31
        Me.lblDireccion.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTelefono.Location = New System.Drawing.Point(31, 119)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTelefono.Size = New System.Drawing.Size(124, 14)
        Me.lblTelefono.TabIndex = 32
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblCatalogo
        '
        Me.lblCatalogo.BackColor = System.Drawing.Color.Transparent
        Me.lblCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCatalogo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalogo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCatalogo.Location = New System.Drawing.Point(31, 143)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCatalogo.Size = New System.Drawing.Size(124, 14)
        Me.lblCatalogo.TabIndex = 33
        Me.lblCatalogo.Text = "Catálogo"
        '
        'lblCodigoCentro
        '
        Me.lblCodigoCentro.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoCentro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodigoCentro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCentro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCodigoCentro.Location = New System.Drawing.Point(31, 167)
        Me.lblCodigoCentro.Name = "lblCodigoCentro"
        Me.lblCodigoCentro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodigoCentro.Size = New System.Drawing.Size(124, 14)
        Me.lblCodigoCentro.TabIndex = 34
        Me.lblCodigoCentro.Text = "Código centro"
        '
        'lblCuentaContable
        '
        Me.lblCuentaContable.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaContable.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCuentaContable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaContable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCuentaContable.Location = New System.Drawing.Point(31, 191)
        Me.lblCuentaContable.Name = "lblCuentaContable"
        Me.lblCuentaContable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCuentaContable.Size = New System.Drawing.Size(124, 14)
        Me.lblCuentaContable.TabIndex = 35
        Me.lblCuentaContable.Text = "Cuenta contable"
        '
        'ACTDIVM0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdAceptar
        Me.ClientSize = New System.Drawing.Size(578, 258)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblNombreCuentaContable)
        Me.Controls.Add(Me.lblNombreCentro)
        Me.Controls.Add(Me.lblNombreCatalogo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.txtCodigoDivision)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtTipoCatalogo)
        Me.Controls.Add(Me.txtCodigoCentro)
        Me.Controls.Add(Me.txtCuentaContable)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblResponsable)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblCatalogo)
        Me.Controls.Add(Me.lblCodigoCentro)
        Me.Controls.Add(Me.lblCuentaContable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTDIVM0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta a departamento - ACTDIVM0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents lblNombreCuentaContable As System.Windows.Forms.Label
    Public WithEvents lblNombreCentro As System.Windows.Forms.Label
    Public WithEvents lblNombreCatalogo As System.Windows.Forms.Label
    Public WithEvents txtDescripcion As System.Windows.Forms.Label
    Public WithEvents txtResponsable As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtCodigoDivision As System.Windows.Forms.Label
    Public WithEvents txtDireccion As System.Windows.Forms.Label
    Public WithEvents txtTelefono As System.Windows.Forms.Label
    Public WithEvents txtTipoCatalogo As System.Windows.Forms.Label
    Public WithEvents txtCodigoCentro As System.Windows.Forms.Label
    Public WithEvents txtCuentaContable As System.Windows.Forms.Label
    Public WithEvents lblDivision As System.Windows.Forms.Label
    Public WithEvents lblDescripcion As System.Windows.Forms.Label
    Public WithEvents lblResponsable As System.Windows.Forms.Label
    Public WithEvents lblDireccion As System.Windows.Forms.Label
    Public WithEvents lblTelefono As System.Windows.Forms.Label
    Public WithEvents lblCatalogo As System.Windows.Forms.Label
    Public WithEvents lblCodigoCentro As System.Windows.Forms.Label
    Public WithEvents lblCuentaContable As System.Windows.Forms.Label
End Class
