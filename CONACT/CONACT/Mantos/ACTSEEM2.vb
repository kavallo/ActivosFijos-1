Imports Citi.Synergia.HelperClient

Public Class ACTSEEM2
    Public Property NumeroPoliza As String
    Public Property NumeroEndoso As String

    Private _endosoAnterior As String = String.Empty
    Private _estadoPoliza As String = String.Empty

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        If Me.NumeroEndoso = "" Then
            Me.NumeroEndoso = "               "
        End If

        txtNO_ENDOSO.Text = Me.NumeroEndoso
        txtNUMERO_POLIZA.Text = Me.NumeroPoliza

        Me.Leer()

        Grabado = False
    End Sub

    Private Sub Leer()
        Try
            meteSQL("select")
            meteSQL(" SEGUROS_ENC.ENDOSO_ANTERIOR, ")
            meteSQL(" SEGUROS_ENC.ESTADO_POLIZA, ")
            meteSQL(" convert(varchar(10),SEGUROS_ENC.FECHA_I_VIGENCIA,101), ")
            meteSQL(" convert(varchar(10),SEGUROS_ENC.FECHA_F_VIGENCIA,101), ")
            meteSQL(" SEGUROS_ENC.COMPANIA_SEGUROS, ")
            meteSQL(" SEGUROS_ENC.CONTACTO_COMPANIA, ")
            meteSQL(" SEGUROS_ENC.TELEFONO_COMPANIA, ")
            meteSQL(" SEGUROS_ENC.FAX_COMPANIA, ")
            meteSQL(" SEGUROS_ENC.NOMBRE_CORREDOR, ")
            meteSQL(" SEGUROS_ENC.CONTACTO_CORREDOR, ")
            meteSQL(" SEGUROS_ENC.TELEFONO_CORREDOR, ")
            meteSQL(" SEGUROS_ENC.FAX_CORREDOR, ")
            meteSQL(" ltrim(str(SEGUROS_ENC.MONTO_PRIMA,14,2)), ")
            meteSQL(" ltrim(str(SEGUROS_ENC.TOTAL_SEGURO,14,2)), ")
            meteSQL(" SEGUROS_ENC.CODIGO_DE_MONEDA, ")
            meteSQL(" SEGUROS_ENC.timestamp ")
            meteSQL("from SEGUROS_ENC")
            meteSQL(" where SEGUROS_ENC.NO_ENDOSO = " & Scm(Me.NumeroEndoso) & " and SEGUROS_ENC.NUMERO_POLIZA = " & Scm(Me.NumeroPoliza))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                _endosoAnterior = SqlData(Sqlconn, 1).ToString
                _estadoPoliza = SqlData(Sqlconn, 2).ToString
                'mskFECHAI.defaultText = SqlData(sqlconn, 3)
                mskfechai.EscribirFecha(SqlData(Sqlconn, 3).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                'mskFECHAF.defaultText = SqlData(sqlconn, 4)
                mskfechaf.EscribirFecha(SqlData(Sqlconn, 4).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                txtCOMPANIA_SEGUROS.Text = SqlData(Sqlconn, 5).ToString
                txtCONTACTO_COMPANIA.Text = SqlData(Sqlconn, 6).ToString
                txtTELEFONO_COMPANIA.Text = SqlData(Sqlconn, 7).ToString
                txtFAX_COMPANIA.Text = SqlData(Sqlconn, 8).ToString
                txtNOMBRE_CORREDOR.Text = SqlData(Sqlconn, 9).ToString
                txtCONTACTO_CORREDOR.Text = SqlData(Sqlconn, 10).ToString
                txtTELEFONO_CORREDOR.Text = SqlData(Sqlconn, 11).ToString
                txtFAX_CORREDOR.Text = SqlData(Sqlconn, 12).ToString
                txtMONTO_PRIMA.Text = SqlData(Sqlconn, 13).ToString
                txtTOTAL_SEGURO.Text = SqlData(Sqlconn, 14).ToString
                txtCODIGO_DE_MONEDA.Text = SqlData(Sqlconn, 15).ToString

                MyBase.ReadTimeStamp()

                TimeStamp_Local = SysTimeStamp
            Loop

            lblnombremoneda.Text = DescripcionesDB.Monedas(txtCODIGO_DE_MONEDA.Text)

            MyBase.Habilitar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Moneda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCODIGO_DE_MONEDA.TextChanged
        If txtCODIGO_DE_MONEDA.Text.Trim.Length > 0 Then
            lblnombremoneda.Text = DescripcionesDB.Monedas(txtCODIGO_DE_MONEDA.Text)
        End If
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class