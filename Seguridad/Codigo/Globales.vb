Module Globales

    Public gCodigoSG As String
    Public gNombreSistema As String
    Public gID_Sistema As Integer
    Public gAmbienteLocal As Ambiente




    Public Sub msgError(ByVal mensaje As String)
        System.Windows.Forms.MessageBox.Show(mensaje, "Citi- Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
    End Sub


End Module
