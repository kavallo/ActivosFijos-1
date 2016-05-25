Public Class ACTAFGC0
    Public Property CodigoActivo As String
    Public Property CodigoMejora As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        txtMejora.Text = CodigoMejora

        txtCodigoActivo.Text = CodigoActivo

        Me.Leer()

        Grabado = False
    End Sub

    Private Sub Leer()
        Try
            meteSQL("select")
            meteSQL(" ACTIVOS_FIJOS.DESCRIP_CORTA_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESCRIP_LARGA_UNO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESCRIP_LARGA_DOS, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESCRIP_LARGA_TRES, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.MARCA, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.NUMERO_SERIE_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.MODELO_DEL_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.ESTILO_DEL_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.CHASIS_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.UBICACION_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.RESPONSABLE_ACTIVO, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_1, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_2, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_3, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.DESC_GARANTIA_4, ")
            meteSQL(" ACTIVOS_FIJOS_GEN.timestamp ")
            meteSQL("from ACTIVOS_FIJOS, ACTIVOS_FIJOS_GEN")
            meteSQL(" where ACTIVOS_FIJOS_GEN.CODIGO_DE_ACTIVO = " & Scm(CodigoActivo) & " and ACTIVOS_FIJOS_GEN.MEJORA_CORRELATIVO = " & sen(CodigoMejora))
            meteSQL(" and ACTIVOS_FIJOS_GEN.CODIGO_DE_ACTIVO  =  ACTIVOS_FIJOS.CODIGO_DE_ACTIVO and ACTIVOS_FIJOS_GEN.MEJORA_CORRELATIVO  =  ACTIVOS_FIJOS.MEJORA_CORRELATIVO")

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblNombreActivo.Text = SqlData(Sqlconn, 1).ToString
                txtDescripcion1.Text = SqlData(Sqlconn, 2).ToString
                txtDescripcion2.Text = SqlData(Sqlconn, 3).ToString
                txtDescripcion3.Text = SqlData(Sqlconn, 4).ToString
                txtMarca.Text = SqlData(Sqlconn, 5).ToString
                txtNumeroSerie.Text = SqlData(Sqlconn, 6).ToString
                txtModelo.Text = SqlData(Sqlconn, 7).ToString
                txtEstilo.Text = SqlData(Sqlconn, 8).ToString
                txtChasis.Text = SqlData(Sqlconn, 9).ToString
                txtUbicacion.Text = SqlData(Sqlconn, 10).ToString
                txtResponsable.Text = SqlData(Sqlconn, 11).ToString
                txtGarantia1.Text = SqlData(Sqlconn, 12).ToString
                txtGarantia2.Text = SqlData(Sqlconn, 13).ToString
                txtGarantia3.Text = SqlData(Sqlconn, 14).ToString
                txtGarantia4.Text = SqlData(Sqlconn, 15).ToString

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