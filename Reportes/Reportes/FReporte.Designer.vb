<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReporte
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
        Me.View = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'View
        '
        Me.View.ActiveViewIndex = -1
        Me.View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.View.Cursor = System.Windows.Forms.Cursors.Default
        Me.View.Dock = System.Windows.Forms.DockStyle.Fill
        Me.View.Location = New System.Drawing.Point(0, 0)
        Me.View.Name = "View"
        Me.View.SelectionFormula = ""
        Me.View.Size = New System.Drawing.Size(805, 528)
        Me.View.TabIndex = 0
        Me.View.ViewTimeSelectionFormula = ""
        '
        'FReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 528)
        Me.Controls.Add(Me.View)
        Me.Name = "FReporte"
        Me.Text = "FReporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents View As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
