<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportAllFields
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
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.panSinAcceso = New System.Windows.Forms.Panel()
        Me.grdSinAcceso = New System.Windows.Forms.DataGridView()
        Me.DBSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaSinAcceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinAcceso = New System.Windows.Forms.Label()
        Me.lblSinMostrar = New System.Windows.Forms.Label()
        Me.grdEmpresas = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BaseDeDatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panBarras = New System.Windows.Forms.Panel()
        Me.barRegistros = New System.Windows.Forms.ProgressBar()
        Me.barBases = New System.Windows.Forms.ProgressBar()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panSinAcceso.SuspendLayout()
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBarras.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(385, 252)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(87, 25)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "@15"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(478, 252)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "@16"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'panSinAcceso
        '
        Me.panSinAcceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panSinAcceso.Controls.Add(Me.grdSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinAcceso)
        Me.panSinAcceso.Controls.Add(Me.lblSinMostrar)
        Me.panSinAcceso.Location = New System.Drawing.Point(12, 283)
        Me.panSinAcceso.Name = "panSinAcceso"
        Me.panSinAcceso.Size = New System.Drawing.Size(553, 148)
        Me.panSinAcceso.TabIndex = 6
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
        Me.grdSinAcceso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DBSinAcceso, Me.EmpresaSinAcceso})
        Me.grdSinAcceso.Location = New System.Drawing.Point(3, 23)
        Me.grdSinAcceso.Name = "grdSinAcceso"
        Me.grdSinAcceso.ReadOnly = True
        Me.grdSinAcceso.RowHeadersVisible = False
        Me.grdSinAcceso.Size = New System.Drawing.Size(547, 122)
        Me.grdSinAcceso.TabIndex = 1
        '
        'DBSinAcceso
        '
        Me.DBSinAcceso.HeaderText = "Base de Datos"
        Me.DBSinAcceso.MinimumWidth = 110
        Me.DBSinAcceso.Name = "DBSinAcceso"
        Me.DBSinAcceso.ReadOnly = True
        Me.DBSinAcceso.Width = 110
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
        Me.lblSinMostrar.Location = New System.Drawing.Point(157, 48)
        Me.lblSinMostrar.Name = "lblSinMostrar"
        Me.lblSinMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSinMostrar.Size = New System.Drawing.Size(238, 20)
        Me.lblSinMostrar.TabIndex = 43
        Me.lblSinMostrar.Text = "No hay empresas sin acceso"
        Me.lblSinMostrar.Visible = False
        '
        'grdEmpresas
        '
        Me.grdEmpresas.AllowUserToAddRows = False
        Me.grdEmpresas.AllowUserToDeleteRows = False
        Me.grdEmpresas.AllowUserToResizeRows = False
        Me.grdEmpresas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEmpresas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.BaseDeDatos, Me.Empresas})
        Me.grdEmpresas.Location = New System.Drawing.Point(12, 12)
        Me.grdEmpresas.Name = "grdEmpresas"
        Me.grdEmpresas.RowHeadersVisible = False
        Me.grdEmpresas.Size = New System.Drawing.Size(553, 169)
        Me.grdEmpresas.TabIndex = 1
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
        Me.Empresas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Empresas.HeaderText = "Empresas"
        Me.Empresas.MinimumWidth = 175
        Me.Empresas.Name = "Empresas"
        Me.Empresas.ReadOnly = True
        '
        'panBarras
        '
        Me.panBarras.Controls.Add(Me.barRegistros)
        Me.panBarras.Controls.Add(Me.barBases)
        Me.panBarras.Location = New System.Drawing.Point(12, 187)
        Me.panBarras.Name = "panBarras"
        Me.panBarras.Size = New System.Drawing.Size(553, 59)
        Me.panBarras.TabIndex = 3
        '
        'barRegistros
        '
        Me.barRegistros.Location = New System.Drawing.Point(3, 32)
        Me.barRegistros.Name = "barRegistros"
        Me.barRegistros.Size = New System.Drawing.Size(547, 23)
        Me.barRegistros.TabIndex = 1
        '
        'barBases
        '
        Me.barBases.Location = New System.Drawing.Point(3, 3)
        Me.barBases.Maximum = 2
        Me.barBases.Name = "barBases"
        Me.barBases.Size = New System.Drawing.Size(547, 23)
        Me.barBases.TabIndex = 0
        Me.barBases.Value = 1
        '
        'ExportAllFields
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(577, 443)
        Me.Controls.Add(Me.grdEmpresas)
        Me.Controls.Add(Me.panSinAcceso)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.panBarras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "ExportAllFields"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Excel - AddDispFull"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panSinAcceso.ResumeLayout(False)
        CType(Me.grdSinAcceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBarras.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents panSinAcceso As System.Windows.Forms.Panel
    Public WithEvents grdSinAcceso As System.Windows.Forms.DataGridView
    Public WithEvents lblSinAcceso As System.Windows.Forms.Label
    Public WithEvents lblSinMostrar As System.Windows.Forms.Label
    Public WithEvents grdEmpresas As System.Windows.Forms.DataGridView
    Friend WithEvents panBarras As System.Windows.Forms.Panel
    Friend WithEvents barRegistros As System.Windows.Forms.ProgressBar
    Friend WithEvents barBases As System.Windows.Forms.ProgressBar
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BaseDeDatos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaSinAcceso As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
