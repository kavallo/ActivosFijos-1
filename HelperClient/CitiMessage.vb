Imports Citi.Synergia.HelperClient.Utils

Public Class CitiMessage
    Public TipoMensaje As Citi.Synergia.HelperClient.Utils.TipoDeMensaje
    Public TipoRespuesta As Citi.Synergia.HelperClient.Utils.TipoDeRespuesta

    Private Sub CitiMessage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case TipoMensaje
            Case TipoDeMensaje.TipoAviso
                lblENCABEZADO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "AVISO").ToUpper
                ImagenAviso.Top = 12
                ImagenAviso.Left = 12
                ImagenAviso.Visible = True

                cmdAceptar.Visible = False
                cmdCancelar.Visible = False
            Case TipoDeMensaje.TipoError
                lblENCABEZADO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "ERROR").ToUpper
                ImagenError.Top = 12
                ImagenError.Left = 12
                ImagenError.Visible = True

                cmdAceptar.Visible = False
                cmdCancelar.Visible = False
            Case TipoDeMensaje.TipoConfirmacion
                lblENCABEZADO.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(358, "CONFIRMACIÓN").ToUpper
                ImagenConfirmacion.Top = 12
                ImagenConfirmacion.Left = 12
                ImagenConfirmacion.Visible = True

                cmdContinuar.Visible = False
        End Select

        Me.cmdAceptar.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(15, "Aceptar")
        Me.cmdCancelar.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(16, "Cancelar")
    End Sub

    Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
        TipoRespuesta = TipoDeRespuesta.Aceptar
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        TipoRespuesta = TipoDeRespuesta.Cancelar
        Me.Close()
    End Sub

    Private Sub cmdContinuar_Click(sender As System.Object, e As System.EventArgs) Handles cmdContinuar.Click
        TipoRespuesta = TipoDeRespuesta.Continuar
        Me.Close()
    End Sub
End Class