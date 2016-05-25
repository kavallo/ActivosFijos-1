<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MENU_Renamed = New System.Windows.Forms.GroupBox()
        Me.MenuPolizas = New System.Windows.Forms.Button()
        Me.MenuMovimientos = New System.Windows.Forms.Button()
        Me.MenuActivosPorDivision = New System.Windows.Forms.Button()
        Me.MenuActivosPorTipo = New System.Windows.Forms.Button()
        Me.lblPolizas = New System.Windows.Forms.Label()
        Me.lblActivosPorTipo = New System.Windows.Forms.Label()
        Me.lblMovimientos = New System.Windows.Forms.Label()
        Me.lblActivosPorDivision = New System.Windows.Forms.Label()
        Me.lblACTSEES2 = New System.Windows.Forms.Label()
        Me.lblACTTACS0 = New System.Windows.Forms.Label()
        Me.lblACTMAFS7 = New System.Windows.Forms.Label()
        Me.lblACTDIVS0 = New System.Windows.Forms.Label()
        Me.cm3Salir = New System.Windows.Forms.Button()
        Me.LabelEmpresa = New System.Windows.Forms.Label()
        Me.IconosMenus = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MENU_Renamed.SuspendLayout()
        Me.SuspendLayout()
        '
        'MENU_Renamed
        '
        Me.MENU_Renamed.BackColor = System.Drawing.SystemColors.Control
        Me.MENU_Renamed.Controls.Add(Me.MenuPolizas)
        Me.MENU_Renamed.Controls.Add(Me.MenuMovimientos)
        Me.MENU_Renamed.Controls.Add(Me.MenuActivosPorDivision)
        Me.MENU_Renamed.Controls.Add(Me.MenuActivosPorTipo)
        Me.MENU_Renamed.Controls.Add(Me.lblPolizas)
        Me.MENU_Renamed.Controls.Add(Me.lblActivosPorTipo)
        Me.MENU_Renamed.Controls.Add(Me.lblMovimientos)
        Me.MENU_Renamed.Controls.Add(Me.lblActivosPorDivision)
        Me.MENU_Renamed.Controls.Add(Me.lblACTSEES2)
        Me.MENU_Renamed.Controls.Add(Me.lblACTTACS0)
        Me.MENU_Renamed.Controls.Add(Me.lblACTMAFS7)
        Me.MENU_Renamed.Controls.Add(Me.lblACTDIVS0)
        Me.MENU_Renamed.Controls.Add(Me.cm3Salir)
        Me.MENU_Renamed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENU_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MENU_Renamed.Location = New System.Drawing.Point(12, 35)
        Me.MENU_Renamed.Name = "MENU_Renamed"
        Me.MENU_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MENU_Renamed.Size = New System.Drawing.Size(562, 188)
        Me.MENU_Renamed.TabIndex = 15
        Me.MENU_Renamed.TabStop = False
        '
        'MenuPolizas
        '
        Me.MenuPolizas.BackColor = System.Drawing.SystemColors.Control
        Me.MenuPolizas.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuPolizas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPolizas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuPolizas.Location = New System.Drawing.Point(110, 100)
        Me.MenuPolizas.Name = "MenuPolizas"
        Me.MenuPolizas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuPolizas.Size = New System.Drawing.Size(17, 17)
        Me.MenuPolizas.TabIndex = 4
        Me.MenuPolizas.Tag = "0304000"
        Me.MenuPolizas.UseVisualStyleBackColor = False
        '
        'MenuMovimientos
        '
        Me.MenuMovimientos.BackColor = System.Drawing.SystemColors.Control
        Me.MenuMovimientos.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuMovimientos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMovimientos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuMovimientos.Location = New System.Drawing.Point(110, 77)
        Me.MenuMovimientos.Name = "MenuMovimientos"
        Me.MenuMovimientos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuMovimientos.Size = New System.Drawing.Size(17, 17)
        Me.MenuMovimientos.TabIndex = 3
        Me.MenuMovimientos.Tag = "0303000"
        Me.MenuMovimientos.UseVisualStyleBackColor = False
        '
        'MenuActivosPorDivision
        '
        Me.MenuActivosPorDivision.BackColor = System.Drawing.SystemColors.Control
        Me.MenuActivosPorDivision.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuActivosPorDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuActivosPorDivision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuActivosPorDivision.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuActivosPorDivision.Location = New System.Drawing.Point(110, 54)
        Me.MenuActivosPorDivision.Name = "MenuActivosPorDivision"
        Me.MenuActivosPorDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuActivosPorDivision.Size = New System.Drawing.Size(17, 17)
        Me.MenuActivosPorDivision.TabIndex = 2
        Me.MenuActivosPorDivision.Tag = "0302000"
        Me.MenuActivosPorDivision.UseVisualStyleBackColor = False
        '
        'MenuActivosPorTipo
        '
        Me.MenuActivosPorTipo.BackColor = System.Drawing.SystemColors.Control
        Me.MenuActivosPorTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuActivosPorTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuActivosPorTipo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuActivosPorTipo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuActivosPorTipo.Location = New System.Drawing.Point(110, 31)
        Me.MenuActivosPorTipo.Name = "MenuActivosPorTipo"
        Me.MenuActivosPorTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuActivosPorTipo.Size = New System.Drawing.Size(17, 17)
        Me.MenuActivosPorTipo.TabIndex = 1
        Me.MenuActivosPorTipo.Tag = "0301000"
        Me.MenuActivosPorTipo.UseVisualStyleBackColor = False
        '
        'lblPolizas
        '
        Me.lblPolizas.BackColor = System.Drawing.Color.Transparent
        Me.lblPolizas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblPolizas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPolizas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPolizas.Location = New System.Drawing.Point(133, 101)
        Me.lblPolizas.Name = "lblPolizas"
        Me.lblPolizas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPolizas.Size = New System.Drawing.Size(213, 17)
        Me.lblPolizas.TabIndex = 66
        Me.lblPolizas.Text = "Pólizas de seguro"
        Me.lblPolizas.UseMnemonic = False
        '
        'lblActivosPorTipo
        '
        Me.lblActivosPorTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblActivosPorTipo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblActivosPorTipo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivosPorTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblActivosPorTipo.Location = New System.Drawing.Point(133, 32)
        Me.lblActivosPorTipo.Name = "lblActivosPorTipo"
        Me.lblActivosPorTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblActivosPorTipo.Size = New System.Drawing.Size(213, 17)
        Me.lblActivosPorTipo.TabIndex = 65
        Me.lblActivosPorTipo.Text = "Activos por tipo"
        Me.lblActivosPorTipo.UseMnemonic = False
        '
        'lblMovimientos
        '
        Me.lblMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.lblMovimientos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblMovimientos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovimientos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMovimientos.Location = New System.Drawing.Point(133, 78)
        Me.lblMovimientos.Name = "lblMovimientos"
        Me.lblMovimientos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMovimientos.Size = New System.Drawing.Size(213, 17)
        Me.lblMovimientos.TabIndex = 64
        Me.lblMovimientos.Text = "Movimientos de activos"
        Me.lblMovimientos.UseMnemonic = False
        '
        'lblActivosPorDivision
        '
        Me.lblActivosPorDivision.BackColor = System.Drawing.Color.Transparent
        Me.lblActivosPorDivision.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblActivosPorDivision.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivosPorDivision.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblActivosPorDivision.Location = New System.Drawing.Point(133, 55)
        Me.lblActivosPorDivision.Name = "lblActivosPorDivision"
        Me.lblActivosPorDivision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblActivosPorDivision.Size = New System.Drawing.Size(213, 17)
        Me.lblActivosPorDivision.TabIndex = 63
        Me.lblActivosPorDivision.Text = "Activos por departamento"
        Me.lblActivosPorDivision.UseMnemonic = False
        '
        'lblACTSEES2
        '
        Me.lblACTSEES2.BackColor = System.Drawing.Color.Transparent
        Me.lblACTSEES2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTSEES2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTSEES2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTSEES2.Location = New System.Drawing.Point(352, 101)
        Me.lblACTSEES2.Name = "lblACTSEES2"
        Me.lblACTSEES2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTSEES2.Size = New System.Drawing.Size(101, 17)
        Me.lblACTSEES2.TabIndex = 62
        Me.lblACTSEES2.Text = "ACTSEES2"
        Me.lblACTSEES2.UseMnemonic = False
        '
        'lblACTTACS0
        '
        Me.lblACTTACS0.BackColor = System.Drawing.Color.Transparent
        Me.lblACTTACS0.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTTACS0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTTACS0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTTACS0.Location = New System.Drawing.Point(352, 32)
        Me.lblACTTACS0.Name = "lblACTTACS0"
        Me.lblACTTACS0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTTACS0.Size = New System.Drawing.Size(101, 17)
        Me.lblACTTACS0.TabIndex = 61
        Me.lblACTTACS0.Text = "ACTTACS1"
        Me.lblACTTACS0.UseMnemonic = False
        '
        'lblACTMAFS7
        '
        Me.lblACTMAFS7.BackColor = System.Drawing.Color.Transparent
        Me.lblACTMAFS7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTMAFS7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTMAFS7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTMAFS7.Location = New System.Drawing.Point(352, 78)
        Me.lblACTMAFS7.Name = "lblACTMAFS7"
        Me.lblACTMAFS7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTMAFS7.Size = New System.Drawing.Size(101, 17)
        Me.lblACTMAFS7.TabIndex = 60
        Me.lblACTMAFS7.Text = "ACTMAFS7"
        Me.lblACTMAFS7.UseMnemonic = False
        '
        'lblACTDIVS0
        '
        Me.lblACTDIVS0.BackColor = System.Drawing.Color.Transparent
        Me.lblACTDIVS0.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblACTDIVS0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACTDIVS0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblACTDIVS0.Location = New System.Drawing.Point(352, 55)
        Me.lblACTDIVS0.Name = "lblACTDIVS0"
        Me.lblACTDIVS0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACTDIVS0.Size = New System.Drawing.Size(101, 17)
        Me.lblACTDIVS0.TabIndex = 59
        Me.lblACTDIVS0.Text = "ACTDIVS0"
        Me.lblACTDIVS0.UseMnemonic = False
        '
        'cm3Salir
        '
        Me.cm3Salir.BackColor = System.Drawing.SystemColors.Control
        Me.cm3Salir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cm3Salir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cm3Salir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cm3Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cm3Salir.Location = New System.Drawing.Point(486, 114)
        Me.cm3Salir.Name = "cm3Salir"
        Me.cm3Salir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cm3Salir.Size = New System.Drawing.Size(61, 59)
        Me.cm3Salir.TabIndex = 14
        Me.cm3Salir.Text = "@1"
        Me.cm3Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cm3Salir.UseMnemonic = False
        Me.cm3Salir.UseVisualStyleBackColor = False
        '
        'LabelEmpresa
        '
        Me.LabelEmpresa.AutoEllipsis = True
        Me.LabelEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelEmpresa.Location = New System.Drawing.Point(12, 9)
        Me.LabelEmpresa.Name = "LabelEmpresa"
        Me.LabelEmpresa.Size = New System.Drawing.Size(562, 23)
        Me.LabelEmpresa.TabIndex = 16
        Me.LabelEmpresa.UseMnemonic = False
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
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 235)
        Me.Controls.Add(Me.LabelEmpresa)
        Me.Controls.Add(Me.MENU_Renamed)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LeerPosicion = True
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPC - Activos Fijos [Consultas]"
        CType(Me.ErrorCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MENU_Renamed.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents MENU_Renamed As System.Windows.Forms.GroupBox
    Public WithEvents cm3Salir As System.Windows.Forms.Button
    Friend WithEvents LabelEmpresa As System.Windows.Forms.Label
    Public WithEvents MenuPolizas As System.Windows.Forms.Button
    Public WithEvents MenuMovimientos As System.Windows.Forms.Button
    Public WithEvents MenuActivosPorDivision As System.Windows.Forms.Button
    Public WithEvents MenuActivosPorTipo As System.Windows.Forms.Button
    Public WithEvents lblPolizas As System.Windows.Forms.Label
    Public WithEvents lblActivosPorTipo As System.Windows.Forms.Label
    Public WithEvents lblMovimientos As System.Windows.Forms.Label
    Public WithEvents lblActivosPorDivision As System.Windows.Forms.Label
    Public WithEvents lblACTSEES2 As System.Windows.Forms.Label
    Public WithEvents lblACTTACS0 As System.Windows.Forms.Label
    Public WithEvents lblACTMAFS7 As System.Windows.Forms.Label
    Public WithEvents lblACTDIVS0 As System.Windows.Forms.Label
    Friend WithEvents IconosMenus As System.Windows.Forms.ImageList
End Class
