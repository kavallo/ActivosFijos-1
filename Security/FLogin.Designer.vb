<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLogin
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FLogin))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.ComboCompania = New System.Windows.Forms.ComboBox()
        Me.TextoPassword = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelCompania = New System.Windows.Forms.Label()
        Me.ComboIdioma = New System.Windows.Forms.ComboBox()
        Me.LabelIdioma = New System.Windows.Forms.Label()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.ValidacionCampos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextoUsuario = New Citi.Synergia.UIGenerico.SynTextBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        CType(Me.ValidacionCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.White
        Me.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Logo.Image = Global.Citi.Synergia.Security.My.Resources.Resources.LogoCiti
        Me.Logo.Location = New System.Drawing.Point(0, 0)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(387, 52)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'ComboCompania
        '
        Me.ComboCompania.BackColor = System.Drawing.SystemColors.Window
        Me.ComboCompania.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCompania.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCompania.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboCompania.Location = New System.Drawing.Point(88, 106)
        Me.ComboCompania.Name = "ComboCompania"
        Me.ComboCompania.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboCompania.Size = New System.Drawing.Size(274, 22)
        Me.ComboCompania.TabIndex = 2
        '
        'TextoPassword
        '
        Me.TextoPassword.AcceptsReturn = True
        Me.TextoPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TextoPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextoPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextoPassword.EsRequerido = False
        Me.TextoPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextoPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextoPassword.LabelConsulta = Nothing
        Me.TextoPassword.Location = New System.Drawing.Point(88, 82)
        Me.TextoPassword.MaxLength = 0
        Me.TextoPassword.Name = "TextoPassword"
        Me.TextoPassword.NombreDeConsulta = Nothing
        Me.TextoPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextoPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextoPassword.Size = New System.Drawing.Size(274, 20)
        Me.TextoPassword.TabIndex = 1
        '
        'LabelUsuario
        '
        Me.LabelUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelUsuario.Location = New System.Drawing.Point(18, 58)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelUsuario.Size = New System.Drawing.Size(65, 17)
        Me.LabelUsuario.TabIndex = 15
        Me.LabelUsuario.Text = "&User:"
        '
        'LabelPassword
        '
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelPassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelPassword.Location = New System.Drawing.Point(18, 82)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPassword.Size = New System.Drawing.Size(73, 17)
        Me.LabelPassword.TabIndex = 14
        Me.LabelPassword.Text = "&Password:"
        '
        'LabelCompania
        '
        Me.LabelCompania.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompania.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelCompania.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompania.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelCompania.Location = New System.Drawing.Point(18, 106)
        Me.LabelCompania.Name = "LabelCompania"
        Me.LabelCompania.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelCompania.Size = New System.Drawing.Size(65, 17)
        Me.LabelCompania.TabIndex = 13
        Me.LabelCompania.Text = "C&ompany:"
        '
        'ComboIdioma
        '
        Me.ComboIdioma.BackColor = System.Drawing.SystemColors.Window
        Me.ComboIdioma.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboIdioma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboIdioma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboIdioma.Location = New System.Drawing.Point(88, 134)
        Me.ComboIdioma.Name = "ComboIdioma"
        Me.ComboIdioma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboIdioma.Size = New System.Drawing.Size(274, 22)
        Me.ComboIdioma.TabIndex = 3
        '
        'LabelIdioma
        '
        Me.LabelIdioma.BackColor = System.Drawing.Color.Transparent
        Me.LabelIdioma.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelIdioma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdioma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelIdioma.Location = New System.Drawing.Point(18, 134)
        Me.LabelIdioma.Name = "LabelIdioma"
        Me.LabelIdioma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelIdioma.Size = New System.Drawing.Size(65, 17)
        Me.LabelIdioma.TabIndex = 17
        Me.LabelIdioma.Text = "&Language:"
        '
        'CmdCancelar
        '
        Me.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancelar.Location = New System.Drawing.Point(265, 14)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(97, 23)
        Me.CmdCancelar.TabIndex = 2
        Me.CmdCancelar.Text = "&Cancel"
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Location = New System.Drawing.Point(162, 14)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(97, 23)
        Me.CmdAceptar.TabIndex = 1
        Me.CmdAceptar.Text = "&Ok"
        Me.CmdAceptar.UseVisualStyleBackColor = True
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.Color.White
        Me.PanelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBotones.Controls.Add(Me.CmdCancelar)
        Me.PanelBotones.Controls.Add(Me.CmdAceptar)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotones.Location = New System.Drawing.Point(0, 167)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(387, 49)
        Me.PanelBotones.TabIndex = 4
        '
        'ValidacionCampos
        '
        Me.ValidacionCampos.ContainerControl = Me
        '
        'TextoUsuario
        '
        Me.TextoUsuario.AcceptsReturn = True
        Me.TextoUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.TextoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextoUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextoUsuario.EsRequerido = False
        Me.TextoUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextoUsuario.LabelConsulta = Nothing
        Me.TextoUsuario.Location = New System.Drawing.Point(88, 58)
        Me.TextoUsuario.MaxLength = 0
        Me.TextoUsuario.Name = "TextoUsuario"
        Me.TextoUsuario.NombreDeConsulta = Nothing
        Me.TextoUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextoUsuario.Size = New System.Drawing.Size(274, 20)
        Me.TextoUsuario.TabIndex = 0
        '
        'FLogin
        '
        Me.AcceptButton = Me.CmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdCancelar
        Me.ClientSize = New System.Drawing.Size(387, 216)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.ComboIdioma)
        Me.Controls.Add(Me.LabelIdioma)
        Me.Controls.Add(Me.ComboCompania)
        Me.Controls.Add(Me.TextoPassword)
        Me.Controls.Add(Me.TextoUsuario)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelCompania)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign On"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        CType(Me.ValidacionCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Public WithEvents ComboCompania As System.Windows.Forms.ComboBox
    Public WithEvents TextoPassword As UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents TextoUsuario As UIGenerico.SynTextBox ' System.Windows.Forms.TextBox
    Public WithEvents LabelUsuario As System.Windows.Forms.Label
    Public WithEvents LabelPassword As System.Windows.Forms.Label
    Public WithEvents LabelCompania As System.Windows.Forms.Label
    Public WithEvents ComboIdioma As System.Windows.Forms.ComboBox
    Public WithEvents LabelIdioma As System.Windows.Forms.Label
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    Friend WithEvents PanelBotones As System.Windows.Forms.Panel
    Friend WithEvents ValidacionCampos As System.Windows.Forms.ErrorProvider
End Class
