<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTMAFN4
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
        Me.Frame3D1 = New System.Windows.Forms.GroupBox()
        Me.txtdivision = New Citi.Synergia.UIGenerico.SynTextBox()
        Me.lblcodigo_division = New System.Windows.Forms.Label()
        Me.lblTit_Division = New System.Windows.Forms.Label()
        Me.lblnombre_division = New System.Windows.Forms.Label()
        Me.lblnombredivision = New System.Windows.Forms.Label()
        Me.lbltitdivision = New System.Windows.Forms.Label()
        Me.frmtipos = New System.Windows.Forms.GroupBox()
        Me.lblTipo_Clave = New System.Windows.Forms.Label()
        Me.lblClave_Contabilizacion = New System.Windows.Forms.Label()
        Me.lblTitClave_Contabilizacion = New System.Windows.Forms.Label()
        Me.lblnombre_tipo_activo = New System.Windows.Forms.Label()
        Me.lbltipo_activo = New System.Windows.Forms.Label()
        Me.lblTitTipo_Activo = New System.Windows.Forms.Label()
        Me.frmactivo = New System.Windows.Forms.GroupBox()
        Me.lblmejora_correlativo = New System.Windows.Forms.Label()
        Me.lblcodigo_activo = New System.Windows.Forms.Label()
        Me.lblnombre_activo = New System.Windows.Forms.Label()
        Me.lblTitmejora_correlativo = New System.Windows.Forms.Label()
        Me.lblTitcodigo_activo = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3D1.SuspendLayout()
        Me.frmtipos.SuspendLayout()
        Me.frmactivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3D1
        '
        Me.Frame3D1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3D1.Controls.Add(Me.txtdivision)
        Me.Frame3D1.Controls.Add(Me.lblcodigo_division)
        Me.Frame3D1.Controls.Add(Me.lblTit_Division)
        Me.Frame3D1.Controls.Add(Me.lblnombre_division)
        Me.Frame3D1.Controls.Add(Me.lblnombredivision)
        Me.Frame3D1.Controls.Add(Me.lbltitdivision)
        Me.Frame3D1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3D1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame3D1.Location = New System.Drawing.Point(12, 172)
        Me.Frame3D1.Name = "Frame3D1"
        Me.Frame3D1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3D1.Size = New System.Drawing.Size(606, 70)
        Me.Frame3D1.TabIndex = 25
        Me.Frame3D1.TabStop = False
        '
        'txtdivision
        '
        Me.txtdivision.AcceptsReturn = True
        Me.txtdivision.BackColor = System.Drawing.SystemColors.Window
        Me.txtdivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdivision.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdivision.EsRequerido = False
        Me.txtdivision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdivision.LabelConsulta = Nothing
        Me.txtdivision.Location = New System.Drawing.Point(194, 42)
        Me.txtdivision.MaxLength = 10
        Me.txtdivision.Name = "txtdivision"
        Me.txtdivision.NombreDeConsulta = Citi.Synergia.Entidades.ConGen.NombreConsulta.ListaDeDivisiones_DIVISC01
        Me.txtdivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdivision.Size = New System.Drawing.Size(100, 20)
        Me.txtdivision.TabIndex = 0
        '
        'lblcodigo_division
        '
        Me.lblcodigo_division.BackColor = System.Drawing.SystemColors.Window
        Me.lblcodigo_division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo_division.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcodigo_division.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo_division.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblcodigo_division.Location = New System.Drawing.Point(194, 16)
        Me.lblcodigo_division.Name = "lblcodigo_division"
        Me.lblcodigo_division.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcodigo_division.Size = New System.Drawing.Size(100, 20)
        Me.lblcodigo_division.TabIndex = 3
        '
        'lblTit_Division
        '
        Me.lblTit_Division.BackColor = System.Drawing.Color.Transparent
        Me.lblTit_Division.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTit_Division.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit_Division.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTit_Division.Location = New System.Drawing.Point(6, 18)
        Me.lblTit_Division.Name = "lblTit_Division"
        Me.lblTit_Division.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTit_Division.Size = New System.Drawing.Size(182, 20)
        Me.lblTit_Division.TabIndex = 4
        Me.lblTit_Division.Text = "Departamento actual"
        '
        'lblnombre_division
        '
        Me.lblnombre_division.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre_division.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombre_division.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_division.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombre_division.Location = New System.Drawing.Point(316, 18)
        Me.lblnombre_division.Name = "lblnombre_division"
        Me.lblnombre_division.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombre_division.Size = New System.Drawing.Size(284, 20)
        Me.lblnombre_division.TabIndex = 5
        Me.lblnombre_division.UseMnemonic = False
        '
        'lblnombredivision
        '
        Me.lblnombredivision.BackColor = System.Drawing.Color.Transparent
        Me.lblnombredivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombredivision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombredivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombredivision.Location = New System.Drawing.Point(313, 42)
        Me.lblnombredivision.Name = "lblnombredivision"
        Me.lblnombredivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombredivision.Size = New System.Drawing.Size(287, 20)
        Me.lblnombredivision.TabIndex = 6
        Me.lblnombredivision.UseMnemonic = False
        '
        'lbltitdivision
        '
        Me.lbltitdivision.BackColor = System.Drawing.Color.Transparent
        Me.lbltitdivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitdivision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitdivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltitdivision.Location = New System.Drawing.Point(6, 44)
        Me.lbltitdivision.Name = "lbltitdivision"
        Me.lbltitdivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltitdivision.Size = New System.Drawing.Size(182, 20)
        Me.lbltitdivision.TabIndex = 7
        Me.lbltitdivision.Text = "Departamento destino"
        '
        'frmtipos
        '
        Me.frmtipos.BackColor = System.Drawing.SystemColors.Control
        Me.frmtipos.Controls.Add(Me.lblTipo_Clave)
        Me.frmtipos.Controls.Add(Me.lblClave_Contabilizacion)
        Me.frmtipos.Controls.Add(Me.lblTitClave_Contabilizacion)
        Me.frmtipos.Controls.Add(Me.lblnombre_tipo_activo)
        Me.frmtipos.Controls.Add(Me.lbltipo_activo)
        Me.frmtipos.Controls.Add(Me.lblTitTipo_Activo)
        Me.frmtipos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmtipos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmtipos.Location = New System.Drawing.Point(12, 92)
        Me.frmtipos.Name = "frmtipos"
        Me.frmtipos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmtipos.Size = New System.Drawing.Size(606, 74)
        Me.frmtipos.TabIndex = 24
        Me.frmtipos.TabStop = False
        '
        'lblTipo_Clave
        '
        Me.lblTipo_Clave.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo_Clave.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipo_Clave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo_Clave.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipo_Clave.Location = New System.Drawing.Point(316, 42)
        Me.lblTipo_Clave.Name = "lblTipo_Clave"
        Me.lblTipo_Clave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipo_Clave.Size = New System.Drawing.Size(284, 20)
        Me.lblTipo_Clave.TabIndex = 8
        Me.lblTipo_Clave.UseMnemonic = False
        '
        'lblClave_Contabilizacion
        '
        Me.lblClave_Contabilizacion.BackColor = System.Drawing.SystemColors.Window
        Me.lblClave_Contabilizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClave_Contabilizacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblClave_Contabilizacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave_Contabilizacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblClave_Contabilizacion.Location = New System.Drawing.Point(194, 42)
        Me.lblClave_Contabilizacion.Name = "lblClave_Contabilizacion"
        Me.lblClave_Contabilizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClave_Contabilizacion.Size = New System.Drawing.Size(100, 20)
        Me.lblClave_Contabilizacion.TabIndex = 9
        '
        'lblTitClave_Contabilizacion
        '
        Me.lblTitClave_Contabilizacion.BackColor = System.Drawing.Color.Transparent
        Me.lblTitClave_Contabilizacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitClave_Contabilizacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitClave_Contabilizacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitClave_Contabilizacion.Location = New System.Drawing.Point(6, 43)
        Me.lblTitClave_Contabilizacion.Name = "lblTitClave_Contabilizacion"
        Me.lblTitClave_Contabilizacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitClave_Contabilizacion.Size = New System.Drawing.Size(182, 20)
        Me.lblTitClave_Contabilizacion.TabIndex = 10
        Me.lblTitClave_Contabilizacion.Text = "Clave de contabilizacion"
        '
        'lblnombre_tipo_activo
        '
        Me.lblnombre_tipo_activo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre_tipo_activo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombre_tipo_activo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_tipo_activo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombre_tipo_activo.Location = New System.Drawing.Point(316, 18)
        Me.lblnombre_tipo_activo.Name = "lblnombre_tipo_activo"
        Me.lblnombre_tipo_activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombre_tipo_activo.Size = New System.Drawing.Size(284, 20)
        Me.lblnombre_tipo_activo.TabIndex = 11
        Me.lblnombre_tipo_activo.UseMnemonic = False
        '
        'lbltipo_activo
        '
        Me.lbltipo_activo.BackColor = System.Drawing.SystemColors.Window
        Me.lbltipo_activo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltipo_activo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltipo_activo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo_activo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltipo_activo.Location = New System.Drawing.Point(194, 16)
        Me.lbltipo_activo.Name = "lbltipo_activo"
        Me.lbltipo_activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltipo_activo.Size = New System.Drawing.Size(100, 20)
        Me.lbltipo_activo.TabIndex = 12
        '
        'lblTitTipo_Activo
        '
        Me.lblTitTipo_Activo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitTipo_Activo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitTipo_Activo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTipo_Activo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitTipo_Activo.Location = New System.Drawing.Point(6, 18)
        Me.lblTitTipo_Activo.Name = "lblTitTipo_Activo"
        Me.lblTitTipo_Activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitTipo_Activo.Size = New System.Drawing.Size(182, 20)
        Me.lblTitTipo_Activo.TabIndex = 13
        Me.lblTitTipo_Activo.Text = "Tipo de activo al que pertenece"
        '
        'frmactivo
        '
        Me.frmactivo.BackColor = System.Drawing.SystemColors.Control
        Me.frmactivo.Controls.Add(Me.lblmejora_correlativo)
        Me.frmactivo.Controls.Add(Me.lblcodigo_activo)
        Me.frmactivo.Controls.Add(Me.lblnombre_activo)
        Me.frmactivo.Controls.Add(Me.lblTitmejora_correlativo)
        Me.frmactivo.Controls.Add(Me.lblTitcodigo_activo)
        Me.frmactivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmactivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.frmactivo.Location = New System.Drawing.Point(12, 12)
        Me.frmactivo.Name = "frmactivo"
        Me.frmactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmactivo.Size = New System.Drawing.Size(606, 74)
        Me.frmactivo.TabIndex = 23
        Me.frmactivo.TabStop = False
        '
        'lblmejora_correlativo
        '
        Me.lblmejora_correlativo.BackColor = System.Drawing.SystemColors.Window
        Me.lblmejora_correlativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmejora_correlativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmejora_correlativo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmejora_correlativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblmejora_correlativo.Location = New System.Drawing.Point(194, 42)
        Me.lblmejora_correlativo.Name = "lblmejora_correlativo"
        Me.lblmejora_correlativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmejora_correlativo.Size = New System.Drawing.Size(45, 20)
        Me.lblmejora_correlativo.TabIndex = 14
        '
        'lblcodigo_activo
        '
        Me.lblcodigo_activo.BackColor = System.Drawing.SystemColors.Window
        Me.lblcodigo_activo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo_activo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcodigo_activo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo_activo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblcodigo_activo.Location = New System.Drawing.Point(194, 16)
        Me.lblcodigo_activo.Name = "lblcodigo_activo"
        Me.lblcodigo_activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcodigo_activo.Size = New System.Drawing.Size(125, 20)
        Me.lblcodigo_activo.TabIndex = 15
        '
        'lblnombre_activo
        '
        Me.lblnombre_activo.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre_activo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnombre_activo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_activo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblnombre_activo.Location = New System.Drawing.Point(245, 42)
        Me.lblnombre_activo.Name = "lblnombre_activo"
        Me.lblnombre_activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnombre_activo.Size = New System.Drawing.Size(355, 20)
        Me.lblnombre_activo.TabIndex = 16
        Me.lblnombre_activo.UseMnemonic = False
        '
        'lblTitmejora_correlativo
        '
        Me.lblTitmejora_correlativo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitmejora_correlativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitmejora_correlativo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitmejora_correlativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitmejora_correlativo.Location = New System.Drawing.Point(6, 43)
        Me.lblTitmejora_correlativo.Name = "lblTitmejora_correlativo"
        Me.lblTitmejora_correlativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitmejora_correlativo.Size = New System.Drawing.Size(182, 20)
        Me.lblTitmejora_correlativo.TabIndex = 17
        Me.lblTitmejora_correlativo.Text = "Mejora correlativo"
        '
        'lblTitcodigo_activo
        '
        Me.lblTitcodigo_activo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitcodigo_activo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitcodigo_activo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitcodigo_activo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitcodigo_activo.Location = New System.Drawing.Point(6, 17)
        Me.lblTitcodigo_activo.Name = "lblTitcodigo_activo"
        Me.lblTitcodigo_activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitcodigo_activo.Size = New System.Drawing.Size(182, 20)
        Me.lblTitcodigo_activo.TabIndex = 21
        Me.lblTitcodigo_activo.Text = "Codigo de activo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(531, 248)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(438, 248)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 21
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ACTMAFN4
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(632, 283)
        Me.Controls.Add(Me.Frame3D1)
        Me.Controls.Add(Me.frmtipos)
        Me.Controls.Add(Me.frmactivo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ACTMAFN4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado de activos entre departamentos - ACTMAFN4"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3D1.ResumeLayout(False)
        Me.Frame3D1.PerformLayout()
        Me.frmtipos.ResumeLayout(False)
        Me.frmactivo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame3D1 As System.Windows.Forms.GroupBox
    Public WithEvents txtdivision As Citi.Synergia.UIGenerico.SynTextBox
    Public WithEvents lblcodigo_division As System.Windows.Forms.Label
    Public WithEvents lblTit_Division As System.Windows.Forms.Label
    Public WithEvents lblnombre_division As System.Windows.Forms.Label
    Public WithEvents lblnombredivision As System.Windows.Forms.Label
    Public WithEvents lbltitdivision As System.Windows.Forms.Label
    Public WithEvents frmtipos As System.Windows.Forms.GroupBox
    Public WithEvents lblTipo_Clave As System.Windows.Forms.Label
    Public WithEvents lblClave_Contabilizacion As System.Windows.Forms.Label
    Public WithEvents lblTitClave_Contabilizacion As System.Windows.Forms.Label
    Public WithEvents lblnombre_tipo_activo As System.Windows.Forms.Label
    Public WithEvents lbltipo_activo As System.Windows.Forms.Label
    Public WithEvents lblTitTipo_Activo As System.Windows.Forms.Label
    Public WithEvents frmactivo As System.Windows.Forms.GroupBox
    Public WithEvents lblmejora_correlativo As System.Windows.Forms.Label
    Public WithEvents lblcodigo_activo As System.Windows.Forms.Label
    Public WithEvents lblnombre_activo As System.Windows.Forms.Label
    Public WithEvents lblTitmejora_correlativo As System.Windows.Forms.Label
    Public WithEvents lblTitcodigo_activo As System.Windows.Forms.Label
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
