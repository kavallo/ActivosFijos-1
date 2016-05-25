Imports System.Windows.Forms

Public Class FAplicacionAgregar
    Public Property HubieronCambios As Boolean


    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click
        Me.Grabar()
    End Sub

    Private Sub Grabar()
        If txtNombre.Text = "" Then txtNombre.Focus() : Beep() : Exit Sub

        If AdminLANG.Helper.AplicacionAgregar(txtNombre.Text) Then
            Me.HubieronCambios = True
            MessageBox.Show("Aplicación agregada.", "Aviso.", MessageBoxButtons.OK)
            Me.Close()
        End If
    End Sub

    Private Sub Forma_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                Me.Close()

            Case Microsoft.VisualBasic.ChrW(Keys.Enter)
                Me.Grabar()
        End Select
    End Sub
End Class