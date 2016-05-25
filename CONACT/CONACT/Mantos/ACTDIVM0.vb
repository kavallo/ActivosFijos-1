Imports Citi.Synergia.HelperClient

Public Class ACTDIVM0
    Public Property CodigoDivision As String

    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Limpiar()

        Me.txtCodigoDivision.Text = CodigoDivision

        Leer()
    End Sub

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" DIVISIONES.DESCRIPCION_DIVISION, ")
                meteSQL(" DIVISIONES.RESPONSABLE_DIVISION, ")
                meteSQL(" DIVISIONES.DIRECCION_DIVISION, ")
                meteSQL(" DIVISIONES.TELEFONO_DIVISION, ")
                meteSQL(" DIVISIONES.TIPO_CATALOGO, ")
                meteSQL(" DIVISIONES.CODIGO_CENTRO, ")
                meteSQL(" DIVISIONES.CUENTA_CONTABLE, ")
                meteSQL(" DIVISIONES.timestamp ")
                meteSQL("from DIVISIONES")
                meteSQL(" where DIVISIONES.CODIGO_DIVISION = " & Scm(CodigoDivision))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    txtDescripcion.Text = SqlData(Sqlconn, 1).ToString
                    txtResponsable.Text = SqlData(Sqlconn, 2).ToString
                    txtDireccion.Text = SqlData(Sqlconn, 3).ToString
                    txtTelefono.Text = SqlData(Sqlconn, 4).ToString
                    txtTipoCatalogo.Text = SqlData(Sqlconn, 5).ToString
                    txtCodigoCentro.Text = SqlData(Sqlconn, 6).ToString
                    txtCuentaContable.Text = SqlData(Sqlconn, 7).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop

                Me.LeerDescripciones()
            End If

            MyBase.Habilitar()

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LeerDescripciones()
        lblNombreCatalogo.Text = DescripcionesDB.NombreCatalogoContable(txtTipoCatalogo.Text)
        lblNombreCentro.Text = DescripcionesDB.CentroPorCatalogo(txtTipoCatalogo.Text, txtCodigoCentro.Text)
        lblNombreCuentaContable.Text = DescripcionesDB.Cuentas(txtTipoCatalogo.Text, txtCuentaContable.Text)
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class