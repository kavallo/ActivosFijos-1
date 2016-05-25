Public Class ACTCPPM1
    Public Property NumeroPoliza As String
    Public Property NumeroEndoso As String
    Public Property CodigoCobertura As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        If Me.NumeroEndoso = "" Then
            Me.NumeroEndoso = "               "
        End If
        txtCODIGO_COBERTURA.Text = Me.CodigoCobertura
        txtNO_ENDOSO.Text = Me.NumeroEndoso
        txtNUMERO_POLIZA.Text = Me.NumeroPoliza

        Me.Leer()

        Grabado = False
    End Sub

    Private Sub Leer()
        Try
            meteSQL("select")
            meteSQL(" SEGUROS_COB.DESCRIPCION_COBERTUR, ")
            meteSQL(" ltrim(str(SEGUROS_COB.MONTO_ASEGURADO,14,2)), ")
            meteSQL(" SEGUROS_COB.OBSERVACIONES1, ")
            meteSQL(" SEGUROS_COB.OBSERVACIONES2, ")
            meteSQL(" SEGUROS_COB.OBSERVACIONES3, ")
            meteSQL(" SEGUROS_COB.timestamp ")
            meteSQL("from SEGUROS_COB")
            meteSQL(" where SEGUROS_COB.NO_ENDOSO = " & Scm(Me.NumeroEndoso) & " and SEGUROS_COB.NUMERO_POLIZA = " & Scm(Me.NumeroPoliza) & " and SEGUROS_COB.CODIGO_COBERTURA = " & sen(Me.CodigoCobertura))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                txtDESCRIPCION_COBERTUR.Text = SqlData(Sqlconn, 1).ToString
                txtMONTO_ASEGURADO.Text = SqlData(Sqlconn, 2).ToString
                txtOBSERVACIONES1.Text = SqlData(Sqlconn, 3).ToString
                txtOBSERVACIONES2.Text = SqlData(Sqlconn, 4).ToString
                txtOBSERVACIONES3.Text = SqlData(Sqlconn, 5).ToString

                MyBase.ReadTimeStamp()

                TimeStamp_Local = SysTimeStamp
            Loop

            MyBase.Habilitar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class