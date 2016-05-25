<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN0
    Inherits Citi.Synergia.UIGenerico.Forma

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblENCABEZADO = New System.Windows.Forms.Label()
        Me.Sep = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAno = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.ValidaCampos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboMeses = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ValidaCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblENCABEZADO)
        Me.Panel1.Controls.Add(Me.Sep)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(4, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(362, 54)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "A continuación se procedera a la generación de movimientos de activos fijos para " & _
    "poder calcularle su depreciación mensual."
        '
        'lblENCABEZADO
        '
        Me.lblENCABEZADO.BackColor = System.Drawing.Color.White
        Me.lblENCABEZADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblENCABEZADO.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblENCABEZADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblENCABEZADO.Location = New System.Drawing.Point(3, 8)
        Me.lblENCABEZADO.Name = "lblENCABEZADO"
        Me.lblENCABEZADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblENCABEZADO.Size = New System.Drawing.Size(257, 25)
        Me.lblENCABEZADO.TabIndex = 10
        Me.lblENCABEZADO.Text = "CONFIRMACIÓN"
        '
        'Sep
        '
        Me.Sep.BackColor = System.Drawing.SystemColors.WindowText
        Me.Sep.Location = New System.Drawing.Point(2, 41)
        Me.Sep.Name = "Sep"
        Me.Sep.Size = New System.Drawing.Size(360, 1)
        Me.Sep.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes depreciación"
        '
        'txtAno
        '
        Me.txtAno.AcceptsReturn = True
        Me.txtAno.BackColor = System.Drawing.SystemColors.Window
        Me.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAno.EsRequerido = False
        Me.txtAno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAno.LabelConsulta = Nothing
        Me.txtAno.Location = New System.Drawing.Point(147, 137)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.NombreDeConsulta = Nothing
        Me.txtAno.NumeroDecimales = 0
        Me.txtAno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAno.Size = New System.Drawing.Size(81, 20)
        Me.txtAno.TabIndex = 1
        Me.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Año depreciación"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(275, 12)
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
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(178, 13)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ValidaCampos
        '
        Me.ValidaCampos.ContainerControl = Me
        '
        'cboMeses
        '
        Me.cboMeses.BackColor = System.Drawing.SystemColors.Window
        Me.cboMeses.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeses.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMeses.Location = New System.Drawing.Point(147, 110)
        Me.cboMeses.Name = "cboMeses"
        Me.cboMeses.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMeses.Size = New System.Drawing.Size(174, 22)
        Me.cboMeses.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdCancelar)
        Me.Panel2.Controls.Add(Me.cmdAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 173)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 52)
        Me.Panel2.TabIndex = 13
        '
        'ACTMVAN0
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(371, 225)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cboMeses)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMVAN0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de activos por depreciación - ACTMVAN0"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ValidaCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblENCABEZADO As System.Windows.Forms.Label
    Public WithEvents Sep As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtAno As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents ValidaCampos As System.Windows.Forms.ErrorProvider
    Public WithEvents cboMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
