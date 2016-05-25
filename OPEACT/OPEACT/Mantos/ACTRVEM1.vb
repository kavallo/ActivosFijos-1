Public Class ACTRVEM1
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        LeerIco(Me)

        MyBase.Limpiar()

        Me.LlenarCombos()

        Me.kPila(cp_POP)

        Me.Leer()

        Me.MuestraCampos()

        Grabado = False
    End Sub

    Private Sub LlenarCombos()
        Dim tipoRevaluacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With tipoRevaluacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(231, "D - División")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("T", Citi.Synergia.Traductor.Idiomas.GetMensaje(230, "T - Tipo de Activo")))
        End With
        With cboTIPO_DE_REVALUACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoRevaluacion
        End With

        Dim estadoRevaluacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estadoRevaluacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(179, "A - Autorizado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente")))
        End With
        With cboESTADO_REVALUACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estadoRevaluacion
        End With
    End Sub

    Private Sub kPila(ByRef Acción As Short)
        If Acción And cp_POP Then lblCODIGO_REVALUACION.Text = Pop()
    End Sub

    Private Sub Leer()
        Try
            meteSQL(" SELECT REVALUACION_ENC.DESC_REVALUACION, CONVERT(varchar(10), REVALUACION_ENC.FECHA_DE_REVALUACION, 103) AS Expr1,")
            meteSQL("        REVALUACION_ENC.TIPO_DE_REVALUACION, TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO, TIPOS_DE_ACTIVOS.DESCRIP_TIPO_ACTIVO,")
            meteSQL("        DIVISIONES.CODIGO_DIVISION , DIVISIONES.DESCRIPCION_DIVISION, CONVERT(VarChar(10), REVALUACION_ENC.FECHA_AUTORIZACION, 103)")
            meteSQL("        AS Expr2, REVALUACION_ENC.USUARIO_AUTORIZACION, REVALUACION_ENC.ESTADO_REVALUACION, REVALUACION_ENC.PORCENTAJE_REVAL,")
            meteSQL("        REVALUACION_ENC.TimeStamp")
            meteSQL(" FROM   DIVISIONES RIGHT OUTER JOIN")
            meteSQL("        REVALUACION_ENC ON DIVISIONES.CODIGO_DIVISION = REVALUACION_ENC.CODIGO_DIVISION LEFT OUTER JOIN")
            meteSQL("        TIPOS_DE_ACTIVOS ON REVALUACION_ENC.CODIGO_TIPO_ACTIVO = TIPOS_DE_ACTIVOS.CODIGO_TIPO_ACTIVO")
            meteSQL(" Where REVALUACION_ENC.CODIGO_REVALUACION = " & sen(lblCODIGO_REVALUACION.Text))

            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                lblDESC_REVALUACION.Text = SqlData(Sqlconn, 1).ToString
                lblFECHA_DE_REVALUACION.Text = SqlData(Sqlconn, 2).ToString
                cboTIPO_DE_REVALUACION.SelectedValue = SqlData(Sqlconn, 3).ToString
                lblCODIGO_TIPO_ACTIVO.Text = SqlData(Sqlconn, 4).ToString
                lblDESCRIP_TIPO_ACTIVO.Text = SqlData(Sqlconn, 5).ToString
                lblCODIGO_DIVISION.Text = SqlData(Sqlconn, 6).ToString
                lblDESCRIPCION_DIVISION.Text = SqlData(Sqlconn, 7).ToString
                lblFECHA_AUTORIZACION.Text = SqlData(Sqlconn, 8).ToString
                lblUSUARIO_AUTORIZACION.Text = SqlData(Sqlconn, 9).ToString
                cboESTADO_REVALUACION.SelectedValue = SqlData(Sqlconn, 10).ToString
                txtporcentaje.Text = SqlData(Sqlconn, 11).ToString

                MyBase.ReadTimeStamp()

                TimeStamp_Local = SysTimeStamp
            Loop

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MuestraCampos()
        Dim muestraDivision As Boolean
        Dim muestraTipo As Boolean

        If cboTIPO_DE_REVALUACION.SelectedValue.ToString = "T" Then
            muestraDivision = False
            muestraTipo = True
        ElseIf cboTIPO_DE_REVALUACION.SelectedValue.ToString = "D" Then
            muestraDivision = True
            muestraTipo = False
        Else
            muestraDivision = False
            muestraTipo = False
        End If

        lblTitCODIGO_TIPO_ACTIVO.Visible = muestraTipo
        lblCODIGO_TIPO_ACTIVO.Visible = muestraTipo
        lblDESCRIP_TIPO_ACTIVO.Visible = muestraTipo
        lblTitCODIGO_DIVISION.Visible = muestraDivision
        lblCODIGO_DIVISION.Visible = muestraDivision
        lblDESCRIPCION_DIVISION.Visible = muestraDivision
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class