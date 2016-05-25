<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepreciacionPendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepreciacionPendientes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOperacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdSalir = New Citi.Synergia.UIGenerico.BotonMenu()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.grdPendientes = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.lblTitEmpresa = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblTitBaseDeDatos = New System.Windows.Forms.Label()
        Me.lblBaseDeDatos = New System.Windows.Forms.Label()
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.grdPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOperacion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(553, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOperacion
        '
        Me.MenuOperacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir})
        Me.MenuOperacion.Name = "MenuOperacion"
        Me.MenuOperacion.Size = New System.Drawing.Size(42, 20)
        Me.MenuOperacion.Text = "@17"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(152, 22)
        Me.mnuSalir.Text = "@1"
        '
        'IconosMenus
        '
        Me.IconosMenus.ImageStream = CType(resources.GetObject("IconosMenus.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosMenus.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosMenus.Images.SetKeyName(0, "Baja")
        Me.IconosMenus.Images.SetKeyName(1, "Alta")
        Me.IconosMenus.Images.SetKeyName(2, "Cambio")
        Me.IconosMenus.Images.SetKeyName(3, "Llenar")
        Me.IconosMenus.Images.SetKeyName(4, "Salir")
        Me.IconosMenus.Images.SetKeyName(5, "Consulta")
        Me.IconosMenus.Images.SetKeyName(6, "Salir2")
        Me.IconosMenus.Images.SetKeyName(7, "Reporte")
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageKey = "Salir2"
        Me.cmdSalir.ImageList = Me.IconosMenus
        Me.cmdSalir.LabelMensaje = Me.LabelMensaje
        Me.cmdSalir.Location = New System.Drawing.Point(8, 30)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalir.TabIndex = 43
        Me.cmdSalir.Texto = "@1"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'LabelMensaje
        '
        Me.LabelMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMensaje.Location = New System.Drawing.Point(0, 345)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(553, 23)
        Me.LabelMensaje.TabIndex = 42
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdPendientes
        '
        Me.grdPendientes.AllowUserToAddRows = False
        Me.grdPendientes.AllowUserToDeleteRows = False
        Me.grdPendientes.AllowUserToResizeRows = False
        Me.grdPendientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPendientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Ubicacion})
        Me.grdPendientes.Location = New System.Drawing.Point(12, 144)
        Me.grdPendientes.Name = "grdPendientes"
        Me.grdPendientes.RowHeadersVisible = False
        Me.grdPendientes.Size = New System.Drawing.Size(529, 198)
        Me.grdPendientes.TabIndex = 45
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.MinimumWidth = 75
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 75
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 250
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicación"
        Me.Ubicacion.MinimumWidth = 150
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.ReadOnly = True
        Me.Ubicacion.Width = 161
        '
        'Encabezado
        '
        Me.Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Encabezado.Controls.Add(Me.lblBaseDeDatos)
        Me.Encabezado.Controls.Add(Me.lblTitBaseDeDatos)
        Me.Encabezado.Controls.Add(Me.lblTitEmpresa)
        Me.Encabezado.Controls.Add(Me.lblEmpresa)
        Me.Encabezado.Location = New System.Drawing.Point(12, 97)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(529, 41)
        Me.Encabezado.TabIndex = 46
        '
        'lblTitEmpresa
        '
        Me.lblTitEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitEmpresa.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitEmpresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitEmpresa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.lblTitEmpresa.Name = "lblTitEmpresa"
        Me.lblTitEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitEmpresa.Size = New System.Drawing.Size(108, 20)
        Me.lblTitEmpresa.TabIndex = 15
        Me.lblTitEmpresa.Text = "Empresa"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmpresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEmpresa.Location = New System.Drawing.Point(108, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmpresa.Size = New System.Drawing.Size(421, 20)
        Me.lblEmpresa.TabIndex = 16
        '
        'lblTitBaseDeDatos
        '
        Me.lblTitBaseDeDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitBaseDeDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitBaseDeDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitBaseDeDatos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitBaseDeDatos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitBaseDeDatos.Location = New System.Drawing.Point(0, 20)
        Me.lblTitBaseDeDatos.Name = "lblTitBaseDeDatos"
        Me.lblTitBaseDeDatos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitBaseDeDatos.Size = New System.Drawing.Size(108, 20)
        Me.lblTitBaseDeDatos.TabIndex = 17
        Me.lblTitBaseDeDatos.Text = "Base de Datos"
        '
        'lblBaseDeDatos
        '
        Me.lblBaseDeDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBaseDeDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBaseDeDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBaseDeDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBaseDeDatos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaseDeDatos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblBaseDeDatos.Location = New System.Drawing.Point(108, 20)
        Me.lblBaseDeDatos.Name = "lblBaseDeDatos"
        Me.lblBaseDeDatos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBaseDeDatos.Size = New System.Drawing.Size(421, 20)
        Me.lblBaseDeDatos.TabIndex = 18
        '
        'DepreciacionPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 368)
        Me.Controls.Add(Me.Encabezado)
        Me.Controls.Add(Me.grdPendientes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.LabelMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LeerPosicion = True
        Me.Name = "DepreciacionPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activos con información pendiente - DepreciacionPendientes"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.grdPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents MenuOperacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
    Friend WithEvents cmdSalir As Citi.Synergia.UIGenerico.BotonMenu
    Friend WithEvents LabelMensaje As System.Windows.Forms.Label
    Public WithEvents grdPendientes As System.Windows.Forms.DataGridView
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Public WithEvents lblTitEmpresa As System.Windows.Forms.Label
    Public WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents lblBaseDeDatos As System.Windows.Forms.Label
    Public WithEvents lblTitBaseDeDatos As System.Windows.Forms.Label
End Class
