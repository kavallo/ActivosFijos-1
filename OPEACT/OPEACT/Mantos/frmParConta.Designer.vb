<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParConta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParConta))
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblEncabezado = New System.Windows.Forms.Label()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me._Image1_2 = New System.Windows.Forms.PictureBox()
        Me.Sep = New System.Windows.Forms.Label()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.grdEmpresas = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BaseDeDatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreArchivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioCosmos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkMismoCodigo = New System.Windows.Forms.CheckBox()
        Me.chkMismoUsuario = New System.Windows.Forms.CheckBox()
        Me.panSinAcceso = New System.Windows.Forms.Panel()
        Me.grdSinAcceso = New System.Windows.Forms.DataGridView()
        Me.BDSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinAcceso = New System.Windows.Forms.Label()
        Me.lblSinMostrar = New System.Windows.Forms.Label()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.lblPathSeleccionado = New Citi.Synergia.UIGenerico.SynTextBox()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Image1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panSinAcceso.SuspendLayout()
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(368, 374)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(461, 374)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblEncabezado
        '
        Me.lblEncabezado.BackColor = System.Drawing.SystemColors.Control
        Me.lblEncabezado.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEncabezado.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEncabezado.Location = New System.Drawing.Point(58, 9)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEncabezado.Size = New System.Drawing.Size(401, 44)
        Me.lblEncabezado.TabIndex = 21
        Me.lblEncabezado.Text = "CONFIRMACIÓN"
        '
        'lblDetalles
        '
        Me.lblDetalles.BackColor = System.Drawing.SystemColors.Control
        Me.lblDetalles.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDetalles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDetalles.Location = New System.Drawing.Point(16, 60)
        Me.lblDetalles.Name = "lblDetalles"
        Me.lblDetalles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDetalles.Size = New System.Drawing.Size(532, 56)
        Me.lblDetalles.TabIndex = 20
        Me.lblDetalles.Text = "A continuación se generará la partida contable para registrar depreciaciones."
        '
        '_Image1_2
        '
        Me._Image1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Image1_2.Image = CType(resources.GetObject("_Image1_2.Image"), System.Drawing.Image)
        Me._Image1_2.Location = New System.Drawing.Point(12, 12)
        Me._Image1_2.Name = "_Image1_2"
        Me._Image1_2.Size = New System.Drawing.Size(40, 40)
        Me._Image1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._Image1_2.TabIndex = 26
        Me._Image1_2.TabStop = False
        '
        'Sep
        '
        Me.Sep.BackColor = System.Drawing.SystemColors.Control
        Me.Sep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sep.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sep.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sep.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sep.Location = New System.Drawing.Point(56, 52)
        Me.Sep.Name = "Sep"
        Me.Sep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sep.Size = New System.Drawing.Size(492, 2)
        Me.Sep.TabIndex = 19
        '
        'cmdSelect
        '
        Me.cmdSelect.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelect.Location = New System.Drawing.Point(507, 146)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSelect.Size = New System.Drawing.Size(22, 21)
        Me.cmdSelect.TabIndex = 1
        Me.cmdSelect.UseVisualStyleBackColor = False
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.BackColor = System.Drawing.SystemColors.Control
        Me.lblPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPath.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPath.Location = New System.Drawing.Point(12, 132)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPath.Size = New System.Drawing.Size(54, 14)
        Me.lblPath.TabIndex = 28
        Me.lblPath.Text = "Ubicación"
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grdEmpresas
        '
        Me.grdEmpresas.AllowUserToAddRows = False
        Me.grdEmpresas.AllowUserToDeleteRows = False
        Me.grdEmpresas.AllowUserToResizeRows = False
        Me.grdEmpresas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEmpresas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.BaseDeDatos, Me.Empresas, Me.NombreArchivo, Me.CodigoProducto, Me.UsuarioCosmos})
        Me.grdEmpresas.Location = New System.Drawing.Point(9, 221)
        Me.grdEmpresas.Name = "grdEmpresas"
        Me.grdEmpresas.RowHeadersVisible = False
        Me.grdEmpresas.Size = New System.Drawing.Size(539, 147)
        Me.grdEmpresas.TabIndex = 2
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.MinimumWidth = 75
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 75
        '
        'BaseDeDatos
        '
        Me.BaseDeDatos.HeaderText = "Base de Datos"
        Me.BaseDeDatos.MinimumWidth = 110
        Me.BaseDeDatos.Name = "BaseDeDatos"
        Me.BaseDeDatos.ReadOnly = True
        Me.BaseDeDatos.Width = 110
        '
        'Empresas
        '
        Me.Empresas.HeaderText = "Empresas"
        Me.Empresas.MinimumWidth = 175
        Me.Empresas.Name = "Empresas"
        Me.Empresas.ReadOnly = True
        Me.Empresas.Width = 200
        '
        'NombreArchivo
        '
        Me.NombreArchivo.HeaderText = "Nombre del archivo"
        Me.NombreArchivo.MinimumWidth = 100
        Me.NombreArchivo.Name = "NombreArchivo"
        Me.NombreArchivo.Width = 125
        '
        'CodigoProducto
        '
        Me.CodigoProducto.HeaderText = "Código producto"
        Me.CodigoProducto.MaxInputLength = 3
        Me.CodigoProducto.MinimumWidth = 90
        Me.CodigoProducto.Name = "CodigoProducto"
        '
        'UsuarioCosmos
        '
        Me.UsuarioCosmos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsuarioCosmos.HeaderText = "Usuario Cosmos"
        Me.UsuarioCosmos.MaxInputLength = 12
        Me.UsuarioCosmos.MinimumWidth = 90
        Me.UsuarioCosmos.Name = "UsuarioCosmos"
        '
        'chkMismoCodigo
        '
        Me.chkMismoCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.chkMismoCodigo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMismoCodigo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMismoCodigo.Enabled = False
        Me.chkMismoCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMismoCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkMismoCodigo.Location = New System.Drawing.Point(359, 173)
        Me.chkMismoCodigo.Name = "chkMismoCodigo"
        Me.chkMismoCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMismoCodigo.Size = New System.Drawing.Size(189, 18)
        Me.chkMismoCodigo.TabIndex = 3
        Me.chkMismoCodigo.Text = "Usar el mismo código de producto"
        Me.chkMismoCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMismoCodigo.UseVisualStyleBackColor = False
        '
        'chkMismoUsuario
        '
        Me.chkMismoUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.chkMismoUsuario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMismoUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMismoUsuario.Enabled = False
        Me.chkMismoUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMismoUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkMismoUsuario.Location = New System.Drawing.Point(416, 197)
        Me.chkMismoUsuario.Name = "chkMismoUsuario"
        Me.chkMismoUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMismoUsuario.Size = New System.Drawing.Size(132, 18)
        Me.chkMismoUsuario.TabIndex = 4
        Me.chkMismoUsuario.Text = "Usar el mismo usuario"
        Me.chkMismoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMismoUsuario.UseVisualStyleBackColor = False
        '
        'panSinAcceso
        '
        Me.panSinAcceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panSinAcceso.Controls.Add(Me.grdSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinMostrar)
        Me.panSinAcceso.Location = New System.Drawing.Point(12, 405)
        Me.panSinAcceso.Name = "panSinAcceso"
        Me.panSinAcceso.Size = New System.Drawing.Size(536, 117)
        Me.panSinAcceso.TabIndex = 8
        '
        'grdSinAcceso
        '
        Me.grdSinAcceso.AllowUserToAddRows = False
        Me.grdSinAcceso.AllowUserToDeleteRows = False
        Me.grdSinAcceso.AllowUserToResizeRows = False
        Me.grdSinAcceso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSinAcceso.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdSinAcceso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BDSinAcceso, Me.EmpresaSinAcceso})
        Me.grdSinAcceso.Location = New System.Drawing.Point(3, 23)
        Me.grdSinAcceso.Name = "grdSinAcceso"
        Me.grdSinAcceso.ReadOnly = True
        Me.grdSinAcceso.RowHeadersVisible = False
        Me.grdSinAcceso.Size = New System.Drawing.Size(530, 91)
        Me.grdSinAcceso.TabIndex = 1
        '
        'BDSinAcceso
        '
        Me.BDSinAcceso.HeaderText = "Base de Datos"
        Me.BDSinAcceso.MinimumWidth = 110
        Me.BDSinAcceso.Name = "BDSinAcceso"
        Me.BDSinAcceso.ReadOnly = True
        Me.BDSinAcceso.Width = 110
        '
        'EmpresaSinAcceso
        '
        Me.EmpresaSinAcceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpresaSinAcceso.HeaderText = "Empresas"
        Me.EmpresaSinAcceso.MinimumWidth = 100
        Me.EmpresaSinAcceso.Name = "EmpresaSinAcceso"
        Me.EmpresaSinAcceso.ReadOnly = True
        '
        'lblSinAcceso
        '
        Me.lblSinAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSinAcceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSinAcceso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSinAcceso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinAcceso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSinAcceso.Location = New System.Drawing.Point(0, 0)
        Me.lblSinAcceso.Name = "lblSinAcceso"
        Me.lblSinAcceso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSinAcceso.Size = New System.Drawing.Size(238, 20)
        Me.lblSinAcceso.TabIndex = 41
        Me.lblSinAcceso.Text = "Empresas sin acceso"
        '
        'lblSinMostrar
        '
        Me.lblSinMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSinMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSinMostrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSinMostrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinMostrar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSinMostrar.Location = New System.Drawing.Point(149, 48)
        Me.lblSinMostrar.Name = "lblSinMostrar"
        Me.lblSinMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSinMostrar.Size = New System.Drawing.Size(238, 20)
        Me.lblSinMostrar.TabIndex = 43
        Me.lblSinMostrar.Text = "No hay empresas sin acceso"
        Me.lblSinMostrar.Visible = False
        '
        'cmdExcel
        '
        Me.cmdExcel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExcel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExcel.Location = New System.Drawing.Point(275, 374)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExcel.Size = New System.Drawing.Size(87, 25)
        Me.cmdExcel.TabIndex = 5
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = False
        '
        'lblPathSeleccionado
        '
        Me.lblPathSeleccionado.AcceptsReturn = True
        Me.lblPathSeleccionado.BackColor = System.Drawing.SystemColors.Window
        Me.lblPathSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPathSeleccionado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPathSeleccionado.EsRequerido = True
        Me.lblPathSeleccionado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPathSeleccionado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPathSeleccionado.LabelConsulta = Nothing
        Me.lblPathSeleccionado.Location = New System.Drawing.Point(9, 148)
        Me.lblPathSeleccionado.MaxLength = 20
        Me.lblPathSeleccionado.Name = "lblPathSeleccionado"
        Me.lblPathSeleccionado.NombreDeConsulta = Nothing
        Me.lblPathSeleccionado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPathSeleccionado.Size = New System.Drawing.Size(492, 20)
        Me.lblPathSeleccionado.TabIndex = 0
        '
        'frmParConta
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(560, 533)
        Me.Controls.Add(Me.lblPathSeleccionado)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.panSinAcceso)
        Me.Controls.Add(Me.chkMismoUsuario)
        Me.Controls.Add(Me.chkMismoCodigo)
        Me.Controls.Add(Me.grdEmpresas)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.Sep)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblEncabezado)
        Me.Controls.Add(Me.lblDetalles)
        Me.Controls.Add(Me._Image1_2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "frmParConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de contabilización - frmParConta"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Image1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panSinAcceso.ResumeLayout(False)
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents lblEncabezado As System.Windows.Forms.Label
    Public WithEvents lblDetalles As System.Windows.Forms.Label
    Public WithEvents _Image1_2 As System.Windows.Forms.PictureBox
    Public WithEvents Sep As System.Windows.Forms.Label
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Public WithEvents cmdSelect As System.Windows.Forms.Button
    Public WithEvents lblPath As System.Windows.Forms.Label
    Public WithEvents grdEmpresas As System.Windows.Forms.DataGridView
    Public WithEvents chkMismoCodigo As System.Windows.Forms.CheckBox
    Public WithEvents chkMismoUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents panSinAcceso As System.Windows.Forms.Panel
    Public WithEvents grdSinAcceso As System.Windows.Forms.DataGridView
    Public WithEvents lblSinAcceso As System.Windows.Forms.Label
    Public WithEvents lblSinMostrar As System.Windows.Forms.Label
    Public WithEvents cmdExcel As System.Windows.Forms.Button
    Public WithEvents lblPathSeleccionado As Citi.Synergia.UIGenerico.SynTextBox
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BaseDeDatos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreArchivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioCosmos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
