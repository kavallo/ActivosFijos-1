Imports Citi.Synergia.HelperClient

Public Class ACTMAFN4
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        LeerPos(Me, "ACTMAFN4")
        LeerIco(Me)

        lblmejora_correlativo.Text = Pop()
        lblcodigo_activo.Text = Pop()

        Try
            meteSQL("select A.DESCRIP_CORTA_ACTIVO, A.CODIGO_DIVISION, T.CODIGO_TIPO_ACTIVO, ")
            meteSQL("       T.DESCRIP_TIPO_ACTIVO,  T.CLA_CONTABILIZACION, D.DESCRIPCION_DIVISION ")
            meteSQL("  from ACTIVOS_FIJOS A, TIPOS_DE_ACTIVOS T, DIVISIONES D")
            meteSQL(" where CODIGO_DE_ACTIVO     = " & Scm(lblcodigo_activo.Text))
            meteSQL("   and MEJORA_CORRELATIVO   = " & sen(lblmejora_correlativo.Text))
            meteSQL("   and T.CODIGO_TIPO_ACTIVO = A.CODIGO_TIPO_ACTIVO ")
            meteSQL("   and A.CODIGO_DIVISION    = D.CODIGO_DIVISION ")

            EjecutaSQL("")

            ' Obtenemos el resultado de SQL
            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblnombre_activo.Text = SqlData(Sqlconn, 1).ToString
                lblcodigo_division.Text = SqlData(Sqlconn, 2).ToString
                lbltipo_activo.Text = SqlData(Sqlconn, 3).ToString
                lblnombre_tipo_activo.Text = SqlData(Sqlconn, 4).ToString
                lblClave_Contabilizacion.Text = SqlData(Sqlconn, 5).ToString
                lblnombre_division.Text = SqlData(Sqlconn, 6)
            Loop
            If lblClave_Contabilizacion.Text = "D" Then
                lblTipo_Clave.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(219, "Toma centro de division")
            Else
                lblTipo_Clave.Text = Citi.Synergia.Traductor.Idiomas.GetMensaje(218, "Toma centro de tipo de activo")
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DivisionDestinoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitdivision.DoubleClick
        txtdivision.GenerarConsulta()
    End Sub

    Private Sub DivisionDestino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdivision.Leave
        lblnombredivision.Text = DescripcionesDB.Division(txtdivision.Text)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Traslado_De_Activos"
                .Parameters.Add("@CODIGO_DE_ACTIVO", SqlDbType.Char, 15).Value = lblcodigo_activo.Text
                .Parameters.Add("@MEJORA_CORRELATIVO", SqlDbType.Int).Value = lblmejora_correlativo.Text
                .Parameters.Add("@CODIGO_DE_DIVISION_ANT", SqlDbType.Char, 10).Value = lblcodigo_division.Text
                .Parameters.Add("@CODIGO_DE_DIVISION_DES", SqlDbType.Char, 10).Value = txtdivision.Text
                .Parameters.Add("@CLAVE_DE_CONTABILIZACION", SqlDbType.Char, 1).Value = lblClave_Contabilizacion.Text
                For i As Integer = 0 To .Parameters.Count - 1
                    .Parameters(i).Direction = ParameterDirection.Input
                Next
            End With
            Dim parametro As SqlClient.SqlParameter

            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@CODIGO_DE_ACTIVO"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblcodigo_activo.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@MEJORA_CORRELATIVO"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Int
                .Value = lblmejora_correlativo.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@CODIGO_DE_DIVISION_ANT"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 10
                .Value = lblcodigo_division.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "CODIGO_DE_DIVISION_DES"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 10
                .Value = txtdivision.Text
            End With
            parametro = New SqlClient.SqlParameter
            With parametro
                .ParameterName = "@CLAVE_DE_CONTABILIZACION"
                .Direction = ParameterDirection.Input
                .SqlDbType = SqlDbType.Char
                .Size = 15
                .Value = lblClave_Contabilizacion.Text
            End With

            EjecutarComando(comando)

            HubieronCambios = True

            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(220, "El traslado del activo fue satisfactorio."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(221, "Se detectó problemas en el traslado del activo."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(Citi.Synergia.Traductor.Idiomas.GetMensaje(221, "Se detectó problemas en el traslado del activo."), Citi.Synergia.Traductor.Idiomas.GetMensaje(108, "Aviso"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub
End Class