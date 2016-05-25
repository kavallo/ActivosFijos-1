Imports Citi.Synergia.HelperClient

Public Class ACTSEDM1
    Public Property NumeroPoliza As String
    Public Property NumeroEndoso As String
    Public Property CodigoCobertura As String
    Public Property CodigoActivo As String
    Public Property CodigoMejora As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        txtNoPoliza.Text = Me.NumeroPoliza
        txtNoEndoso.Text = Me.NumeroEndoso
        txtCodigoCobertura.Text = Me.CodigoCobertura
        txtCodigoActivo.Text = Me.CodigoActivo
        txtCodigoMejora.Text = Me.CodigoMejora

        Me.Leer()

        Grabado = False

        lblNombreActivo.Text = DescripcionesDB.DescripcionCortaActivo(Me.CodigoActivo, Me.CodigoMejora)
    End Sub

    Private Sub Leer()
        Try
            meteSQL("select ")
            meteSQL(" substring(SEGUROS_COB.DESCRIPCION_COBERTUR,1,50), ")
            meteSQL(" SEGUROS_DET.timestamp ")
            meteSQL("  from SEGUROS_DET,SEGUROS_COB")
            meteSQL(" where SEGUROS_DET.NO_ENDOSO          = " & Scm(Me.NumeroEndoso))
            meteSQL("   and SEGUROS_DET.NUMERO_POLIZA      = " & Scm(Me.NumeroPoliza))
            meteSQL("   and SEGUROS_DET.CODIGO_COBERTURA   = " & sen(Me.CodigoCobertura))
            meteSQL("   and SEGUROS_DET.CODIGO_DE_ACTIVO   = " & Scm(Me.CodigoActivo))
            meteSQL("   and SEGUROS_DET.MEJORA_CORRELATIVO = " & sen(Me.CodigoMejora))
            meteSQL("   and SEGUROS_COB.NUMERO_POLIZA      = SEGUROS_DET.NUMERO_POLIZA")
            meteSQL("   and SEGUROS_COB.NO_ENDOSO          = SEGUROS_DET.NO_ENDOSO")
            meteSQL("   and SEGUROS_COB.CODIGO_COBERTURA   = SEGUROS_DET.CODIGO_COBERTURA")

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblDescripcionCobertura.Text = SqlData(Sqlconn, 1).ToString

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