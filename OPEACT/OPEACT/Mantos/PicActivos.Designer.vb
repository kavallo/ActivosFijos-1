<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PicActivos
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
        Me.cmdReporte = New System.Windows.Forms.Button()
        Me.txtMejora = New Citi.Synergia.UIGenerico.SynTextBoxNumerico()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.txtPathImagen = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.txtActivo = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblDescripcionActivo = New System.Windows.Forms.Label()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.lblMejora = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.opnDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdReporte
        '
        Me.cmdReporte.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReporte.Location = New System.Drawing.Point(392, 123)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReporte.Size = New System.Drawing.Size(70, 25)
        Me.cmdReporte.TabIndex = 34
        Me.cmdReporte.Text = "&Reporte"
        Me.cmdReporte.UseVisualStyleBackColor = False
        '
        'txtMejora
        '
        Me.txtMejora.AcceptsReturn = True
        Me.txtMejora.BackColor = System.Drawing.SystemColors.Window
        Me.txtMejora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMejora.Enabled = False
        Me.txtMejora.EsRequerido = False
        Me.txtMejora.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMejora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMejora.LabelConsulta = Nothing
        Me.txtMejora.Location = New System.Drawing.Point(108, 51)
        Me.txtMejora.MaxLength = 0
        Me.txtMejora.Name = "txtMejora"
        Me.txtMejora.NombreDeConsulta = Nothing
        Me.txtMejora.NumeroDecimales = 0
        Me.txtMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMejora.Size = New System.Drawing.Size(45, 20)
        Me.txtMejora.TabIndex = 29
        Me.txtMejora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGrabar.Location = New System.Drawing.Point(240, 123)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGrabar.Size = New System.Drawing.Size(70, 25)
        Me.cmdGrabar.TabIndex = 28
        Me.cmdGrabar.Text = "&Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEliminar.Location = New System.Drawing.Point(164, 123)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEliminar.Size = New System.Drawing.Size(70, 25)
        Me.cmdEliminar.TabIndex = 27
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAnterior.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAnterior.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAnterior.Location = New System.Drawing.Point(12, 123)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAnterior.Size = New System.Drawing.Size(70, 25)
        Me.cmdAnterior.TabIndex = 26
        Me.cmdAnterior.Text = "A&nterior"
        Me.cmdAnterior.UseVisualStyleBackColor = False
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSiguiente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSiguiente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSiguiente.Location = New System.Drawing.Point(88, 123)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSiguiente.Size = New System.Drawing.Size(70, 25)
        Me.cmdSiguiente.TabIndex = 25
        Me.cmdSiguiente.Text = "&Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAgregar.Enabled = False
        Me.cmdAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAgregar.Location = New System.Drawing.Point(316, 123)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAgregar.Size = New System.Drawing.Size(70, 25)
        Me.cmdAgregar.TabIndex = 23
        Me.cmdAgregar.Text = "&Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'cmdSelect
        '
        Me.cmdSelect.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelect.Location = New System.Drawing.Point(397, 97)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSelect.Size = New System.Drawing.Size(22, 22)
        Me.cmdSelect.TabIndex = 22
        Me.cmdSelect.Text = "..."
        Me.cmdSelect.UseVisualStyleBackColor = False
        '
        'txtPathImagen
        '
        Me.txtPathImagen.AcceptsReturn = True
        Me.txtPathImagen.BackColor = System.Drawing.SystemColors.Window
        Me.txtPathImagen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPathImagen.Enabled = False
        Me.txtPathImagen.EsRequerido = False
        Me.txtPathImagen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathImagen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPathImagen.LabelConsulta = Nothing
        Me.txtPathImagen.Location = New System.Drawing.Point(108, 97)
        Me.txtPathImagen.MaxLength = 0
        Me.txtPathImagen.Name = "txtPathImagen"
        Me.txtPathImagen.NombreDeConsulta = Nothing
        Me.txtPathImagen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPathImagen.Size = New System.Drawing.Size(289, 20)
        Me.txtPathImagen.TabIndex = 21
        '
        'txtActivo
        '
        Me.txtActivo.AcceptsReturn = True
        Me.txtActivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtActivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtActivo.Enabled = False
        Me.txtActivo.EsRequerido = False
        Me.txtActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtActivo.LabelConsulta = Nothing
        Me.txtActivo.Location = New System.Drawing.Point(108, 25)
        Me.txtActivo.MaxLength = 0
        Me.txtActivo.Name = "txtActivo"
        Me.txtActivo.NombreDeConsulta = Nothing
        Me.txtActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActivo.Size = New System.Drawing.Size(289, 20)
        Me.txtActivo.TabIndex = 19
        '
        'picImagen
        '
        Me.picImagen.BackColor = System.Drawing.SystemColors.Control
        Me.picImagen.Cursor = System.Windows.Forms.Cursors.Default
        Me.picImagen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picImagen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picImagen.Location = New System.Drawing.Point(108, 154)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picImagen.Size = New System.Drawing.Size(379, 313)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 33
        Me.picImagen.TabStop = False
        '
        'lblCantidad
        '
        Me.lblCantidad.BackColor = System.Drawing.SystemColors.Control
        Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCantidad.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCantidad.Location = New System.Drawing.Point(373, 470)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCantidad.Size = New System.Drawing.Size(114, 23)
        Me.lblCantidad.TabIndex = 35
        Me.lblCantidad.Text = " :Imagen(es)"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescripcionActivo
        '
        Me.lblDescripcionActivo.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescripcionActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcionActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionActivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescripcionActivo.Location = New System.Drawing.Point(108, 74)
        Me.lblDescripcionActivo.Name = "lblDescripcionActivo"
        Me.lblDescripcionActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescripcionActivo.Size = New System.Drawing.Size(289, 20)
        Me.lblDescripcionActivo.TabIndex = 32
        Me.lblDescripcionActivo.Text = "Mejora"
        '
        'lblImagen
        '
        Me.lblImagen.BackColor = System.Drawing.SystemColors.Control
        Me.lblImagen.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblImagen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblImagen.Location = New System.Drawing.Point(12, 154)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblImagen.Size = New System.Drawing.Size(73, 21)
        Me.lblImagen.TabIndex = 31
        Me.lblImagen.Text = "Imagen"
        Me.lblImagen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMejora
        '
        Me.lblMejora.BackColor = System.Drawing.SystemColors.Control
        Me.lblMejora.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMejora.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMejora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMejora.Location = New System.Drawing.Point(12, 54)
        Me.lblMejora.Name = "lblMejora"
        Me.lblMejora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMejora.Size = New System.Drawing.Size(73, 21)
        Me.lblMejora.TabIndex = 30
        Me.lblMejora.Text = "Mejora"
        Me.lblMejora.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPath
        '
        Me.lblPath.BackColor = System.Drawing.SystemColors.Control
        Me.lblPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPath.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPath.Location = New System.Drawing.Point(12, 100)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPath.Size = New System.Drawing.Size(73, 21)
        Me.lblPath.TabIndex = 20
        Me.lblPath.Text = "Path"
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblActivo
        '
        Me.lblActivo.BackColor = System.Drawing.SystemColors.Control
        Me.lblActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblActivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblActivo.Location = New System.Drawing.Point(12, 28)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblActivo.Size = New System.Drawing.Size(73, 21)
        Me.lblActivo.TabIndex = 18
        Me.lblActivo.Text = "Activo fijo"
        Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdSalir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalir.Location = New System.Drawing.Point(400, 496)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(87, 25)
        Me.cmdSalir.TabIndex = 37
        Me.cmdSalir.Text = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'PicActivos
        '
        Me.AcceptButton = Me.cmdSalir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(499, 533)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdReporte)
        Me.Controls.Add(Me.txtMejora)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.txtPathImagen)
        Me.Controls.Add(Me.txtActivo)
        Me.Controls.Add(Me.picImagen)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblDescripcionActivo)
        Me.Controls.Add(Me.lblImagen)
        Me.Controls.Add(Me.lblMejora)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblActivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "PicActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imágenes de activos - PicActivos"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdReporte As System.Windows.Forms.Button
    Public WithEvents txtMejora As Citi.Synergia.UIGenerico.SynTextBoxNumerico
    Public WithEvents cmdGrabar As System.Windows.Forms.Button
    Public WithEvents cmdEliminar As System.Windows.Forms.Button
    Public WithEvents cmdAnterior As System.Windows.Forms.Button
    Public WithEvents cmdSiguiente As System.Windows.Forms.Button
    Public WithEvents cmdAgregar As System.Windows.Forms.Button
    Public WithEvents cmdSelect As System.Windows.Forms.Button
    Public WithEvents txtPathImagen As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents txtActivo As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents picImagen As System.Windows.Forms.PictureBox
    Public WithEvents lblCantidad As System.Windows.Forms.Label
    Public WithEvents lblDescripcionActivo As System.Windows.Forms.Label
    Public WithEvents lblImagen As System.Windows.Forms.Label
    Public WithEvents lblMejora As System.Windows.Forms.Label
    Public WithEvents lblPath As System.Windows.Forms.Label
    Public WithEvents lblActivo As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents opnDialog As System.Windows.Forms.OpenFileDialog
End Class
