<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMVAN2
    Inherits Citi.Synergia.UIGenerico.Forma 'System.Windows.Forms.Form

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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cboMeses = New System.Windows.Forms.ComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblENCABEZADO = New System.Windows.Forms.Label()
        Me.Sep = New System.Windows.Forms.Label()
        Me.ValidaCampos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtAno = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.lblAnio = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ValidaCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdCancelar)
        Me.Panel2.Controls.Add(Me.cmdAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(398, 52)
        Me.Panel2.TabIndex = 3
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(298, 13)
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
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(205, 13)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cboMeses
        '
        Me.cboMeses.BackColor = System.Drawing.SystemColors.Window
        Me.cboMeses.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeses.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMeses.Location = New System.Drawing.Point(170, 144)
        Me.cboMeses.Name = "cboMeses"
        Me.cboMeses.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMeses.Size = New System.Drawing.Size(174, 22)
        Me.cboMeses.TabIndex = 1
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(55, 147)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(91, 13)
        Me.lblMes.TabIndex = 17
        Me.lblMes.Text = "Mes depreciación"
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
        Me.Panel1.Size = New System.Drawing.Size(398, 128)
        Me.Panel1.TabIndex = 15
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
        Me.Label1.Size = New System.Drawing.Size(381, 73)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "A continuación se procedera a la autorizacion de la depreciacion actualizando los" & _
    " valores de cada activo fijo y generando una partida contable en el periodo y añ" & _
    "o seleccionados."
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
        Me.Sep.Size = New System.Drawing.Size(380, 1)
        Me.Sep.TabIndex = 11
        '
        'ValidaCampos
        '
        Me.ValidaCampos.ContainerControl = Me
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
        Me.txtAno.Location = New System.Drawing.Point(170, 172)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.NombreDeConsulta = Nothing
        Me.txtAno.NumeroDecimales = 0
        Me.txtAno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAno.Size = New System.Drawing.Size(81, 20)
        Me.txtAno.TabIndex = 2
        Me.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(55, 174)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(90, 13)
        Me.lblAnio.TabIndex = 18
        Me.lblAnio.Text = "Año depreciación"
        '
        'ACTMVAN2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 257)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cboMeses)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.lblAnio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMVAN2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de activos por depreciación - ACTMVAN2"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ValidaCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cboMeses As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblENCABEZADO As System.Windows.Forms.Label
    Public WithEvents Sep As System.Windows.Forms.Label
    Friend WithEvents ValidaCampos As System.Windows.Forms.ErrorProvider
    Public WithEvents txtAno As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Friend WithEvents lblAnio As System.Windows.Forms.Label
End Class
