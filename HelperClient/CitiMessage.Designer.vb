<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitiMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CitiMessage))
        Me.cmdContinuar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.ImagenAviso = New System.Windows.Forms.PictureBox()
        Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
        Me.lblDETALLES = New System.Windows.Forms.Label()
        Me.lblENCABEZADO = New System.Windows.Forms.Label()
        Me.ImagenError = New System.Windows.Forms.PictureBox()
        Me.ImagenConfirmacion = New System.Windows.Forms.PictureBox()
        CType(Me.ImagenAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenConfirmacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdContinuar
        '
        Me.cmdContinuar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdContinuar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdContinuar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinuar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdContinuar.Location = New System.Drawing.Point(317, 140)
        Me.cmdContinuar.Name = "cmdContinuar"
        Me.cmdContinuar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdContinuar.Size = New System.Drawing.Size(87, 25)
        Me.cmdContinuar.TabIndex = 5
        Me.cmdContinuar.Text = "C&ontinuar"
        Me.cmdContinuar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(224, 140)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(131, 140)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ImagenAviso
        '
        Me.ImagenAviso.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImagenAviso.Image = CType(resources.GetObject("ImagenAviso.Image"), System.Drawing.Image)
        Me.ImagenAviso.Location = New System.Drawing.Point(12, 12)
        Me.ImagenAviso.Name = "ImagenAviso"
        Me.ImagenAviso.Size = New System.Drawing.Size(46, 46)
        Me.ImagenAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenAviso.TabIndex = 7
        Me.ImagenAviso.TabStop = False
        Me.ImagenAviso.Visible = False
        '
        'Iconos
        '
        Me.Iconos.ImageStream = CType(resources.GetObject("Iconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Iconos.TransparentColor = System.Drawing.Color.Transparent
        Me.Iconos.Images.SetKeyName(0, "Alerta")
        '
        'lblDETALLES
        '
        Me.lblDETALLES.BackColor = System.Drawing.SystemColors.Control
        Me.lblDETALLES.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDETALLES.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDETALLES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDETALLES.Location = New System.Drawing.Point(64, 42)
        Me.lblDETALLES.Name = "lblDETALLES"
        Me.lblDETALLES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDETALLES.Size = New System.Drawing.Size(340, 95)
        Me.lblDETALLES.TabIndex = 8
        Me.lblDETALLES.Text = "Label1"
        '
        'lblENCABEZADO
        '
        Me.lblENCABEZADO.BackColor = System.Drawing.SystemColors.Control
        Me.lblENCABEZADO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblENCABEZADO.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblENCABEZADO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblENCABEZADO.Location = New System.Drawing.Point(64, 12)
        Me.lblENCABEZADO.Name = "lblENCABEZADO"
        Me.lblENCABEZADO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblENCABEZADO.Size = New System.Drawing.Size(257, 25)
        Me.lblENCABEZADO.TabIndex = 9
        '
        'ImagenError
        '
        Me.ImagenError.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImagenError.Image = CType(resources.GetObject("ImagenError.Image"), System.Drawing.Image)
        Me.ImagenError.Location = New System.Drawing.Point(12, 64)
        Me.ImagenError.Name = "ImagenError"
        Me.ImagenError.Size = New System.Drawing.Size(46, 46)
        Me.ImagenError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenError.TabIndex = 10
        Me.ImagenError.TabStop = False
        Me.ImagenError.Visible = False
        '
        'ImagenConfirmacion
        '
        Me.ImagenConfirmacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImagenConfirmacion.Image = CType(resources.GetObject("ImagenConfirmacion.Image"), System.Drawing.Image)
        Me.ImagenConfirmacion.Location = New System.Drawing.Point(12, 116)
        Me.ImagenConfirmacion.Name = "ImagenConfirmacion"
        Me.ImagenConfirmacion.Size = New System.Drawing.Size(46, 46)
        Me.ImagenConfirmacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenConfirmacion.TabIndex = 11
        Me.ImagenConfirmacion.TabStop = False
        Me.ImagenConfirmacion.Visible = False
        '
        'CitiMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 177)
        Me.Controls.Add(Me.ImagenConfirmacion)
        Me.Controls.Add(Me.ImagenError)
        Me.Controls.Add(Me.lblENCABEZADO)
        Me.Controls.Add(Me.lblDETALLES)
        Me.Controls.Add(Me.ImagenAviso)
        Me.Controls.Add(Me.cmdContinuar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CitiMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma de confirmación - CITIMESSAGE"
        CType(Me.ImagenAviso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenConfirmacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdContinuar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents ImagenAviso As System.Windows.Forms.PictureBox
    Friend WithEvents Iconos As System.Windows.Forms.ImageList
    Public WithEvents lblDETALLES As System.Windows.Forms.Label
    Public WithEvents lblENCABEZADO As System.Windows.Forms.Label
    Public WithEvents ImagenError As System.Windows.Forms.PictureBox
    Public WithEvents ImagenConfirmacion As System.Windows.Forms.PictureBox
End Class
