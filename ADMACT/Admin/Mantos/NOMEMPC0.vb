Imports Citi.Synergia.HelperClient

Public Class NOMEMPC0
    Private _muestraSalarios As Boolean = False
    Private _estadoEmpleado As String = String.Empty
    Private _fechaRetiro As String = String.Empty

    Private Sub Forma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Modo = Modo_Local

        MyBase.Limpiar()

        Me.LlenarCombos()

        Me.CreaControlesCampos()

        If Modo = Modo_Alta Then
            Me.kPila(cp_POP)
            Me._muestraSalarios = Me.TieneAccesoSalario("N")
        Else
            Me.kPila(cp_POP Or cp_IFPOP)
            Me._muestraSalarios = Me.TieneAccesoSalario("N")
            Me.Leer()
        End If

        Grabado = False
    End Sub

    Private Sub LlenarCombos()
        Dim estadoCivil As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With estadoCivil
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("C", Citi.Synergia.Traductor.Idiomas.GetMensaje(281, "C - Casado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(282, "D - Divorciado")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(283, "N - No proporcionó el dato")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(284, "S - Soltero")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("U", Citi.Synergia.Traductor.Idiomas.GetMensaje(285, "U - Unido")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("V", Citi.Synergia.Traductor.Idiomas.GetMensaje(286, "V - Viudo")))
        End With
        With cboESTADO_CIVIL
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = estadoCivil
        End With

        Dim sexo As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With sexo
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("F", Citi.Synergia.Traductor.Idiomas.GetMensaje(287, "F - Femenino")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("M", Citi.Synergia.Traductor.Idiomas.GetMensaje(288, "M - Masculino")))
        End With
        With cboINDICA_SEXO
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = sexo
        End With

        Dim tipoPago As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With tipoPago
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("A", Citi.Synergia.Traductor.Idiomas.GetMensaje(289, "A - Depósito de ahorro")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("C", Citi.Synergia.Traductor.Idiomas.GetMensaje(290, "C - Cheque")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("D", Citi.Synergia.Traductor.Idiomas.GetMensaje(291, "D - Depósito monetario")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("E", Citi.Synergia.Traductor.Idiomas.GetMensaje(292, "E - Efectivo")))
        End With
        With cboTIPO_DE_PAGO
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoPago
        End With

        Dim tipoasociacion As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With tipoasociacion
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(293, "N - Ninguna asociación")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(294, "S - Sindicato laboral")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("O", Citi.Synergia.Traductor.Idiomas.GetMensaje(295, "O - Solidarismo")))
        End With
        With CboTIPO_ASOCIACION
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = tipoasociacion
        End With

        Dim marcaTarjeta As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
        With marcaTarjeta
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("N", Citi.Synergia.Traductor.Idiomas.GetMensaje(296, "N - No marca tarjeta de control")))
            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("S", Citi.Synergia.Traductor.Idiomas.GetMensaje(297, "S - Si marca tarjeta de control")))
        End With
        With cboINDICA_MARCA_TARJETA
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
            .DataSource = marcaTarjeta
        End With
    End Sub

    Private Sub CreaControlesCampos()
        '-- Esta rutina crea los Textbox y ComboBox que iran en el panel

        '-- Posición de labels
        Dim labelX As Integer = 17
        Dim labelY As Integer = 21
        '-- Posicion de TextBox y/o ComboBox
        Dim campoX As Integer = 250 '-- Provisionalmente
        Dim campoY As Integer = 19
        '-- Incremento
        Dim incrementoCampo As Integer = 6
        Dim incrementoLabel As Integer = 26

        '-- Controles a usar
        Dim oLabel As Label
        Dim oTexto As Citi.Synergia.UIGenerico.SynTextBox
        Dim oCombo As ComboBox

        Try
            '-- Limpio los controles que existan en el Panel
            Me.panCampos.Controls.Clear()

            '-- Valores a usar en los controles
            '-- Creación de etiquetas y controles
            Dim tabIndice As Integer = 1
            Dim opcional As String = String.Empty
            Dim nombreCampo As String = String.Empty
            Dim idCampo As String = String.Empty
            Dim listaValores As String = String.Empty
            Dim listaAnterior As String = String.Empty
            Dim textoCampo As String = String.Empty
            Dim band As Boolean

            Dim comandoLabels As New System.Text.StringBuilder
            With comandoLabels
                .Append("Select ")
                .Append("       CAMPO_OPCIONAL")
                .Append("     , CAMPO_TITULO")
                .Append("     , CAMPO_ID")
                .Append("     , CAMPO_LISTA_VALORES")
                .Append("  From EMPLEADO_CAMPOS")
                .Append("       Order By CAMPO_LISTA_VALORES, CAMPO_TITULO")
            End With

            Dim comando As New SqlClient.SqlCommand
            With comando
                .CommandText = comandoLabels.ToString
            End With

            Dim dataLabels As DataSet = GetDataSet(comando)

            If Not dataLabels Is Nothing Then
                If dataLabels.Tables.Count > 0 Then
                    For Each filaData As DataRow In dataLabels.Tables(0).Rows
                        band = False
                        opcional = filaData.Item(0).ToString
                        textoCampo = filaData.Item(1).ToString
                        idCampo = filaData.Item(2).ToString
                        listaValores = filaData.Item(3).ToString

                        '-- Label
                        oLabel = New Label
                        With oLabel
                            .AutoSize = True
                            .Tag = opcional
                            If opcional = "S" Then
                                .Text = "[ " & textoCampo & " ]"
                            Else
                                .Text = textoCampo
                            End If
                            .Left = labelX
                            If listaValores = "S" Then
                                If listaAnterior = "N" Then
                                    labelY += 1
                                Else
                                    labelY += 2
                                End If
                            Else
                                If listaAnterior = "S" Then
                                    labelY += 1
                                End If
                            End If
                            .Top = labelY
                        End With
                        Me.panCampos.Controls.Add(oLabel)

                        '-- Se creará un label invisible que servirá de link entre
                        '-- el que se muestra y el control con la data
                        oLabel = New Label
                        With oLabel
                            .Visible = False
                            .Tag = opcional & "-" & listaValores
                            .Text = idCampo
                        End With
                        Me.panCampos.Controls.Add(oLabel)

                        '-- Campo
                        If listaValores = "N" Then
                            '-- Textbox
                            oTexto = New Citi.Synergia.UIGenerico.SynTextBox
                            With oTexto
                                .Text = ""
                                .Tag = idCampo
                                .AcceptsReturn = True
                                .BackColor = Color.White
                                .BorderStyle = BorderStyle.FixedSingle
                                .Width = 210
                                .Left = campoX
                                .Top = campoY
                                .TabIndex = tabIndice
                                campoY += .Height
                                '-- Para efectos de validacion al grabar
                                If opcional = "S" Then
                                    .EsRequerido = False
                                Else
                                    .EsRequerido = True
                                End If
                            End With
                            Me.panCampos.Controls.Add(oTexto)
                        Else
                            oCombo = New ComboBox
                            With oCombo
                                .DropDownStyle = ComboBoxStyle.DropDownList
                                .FormattingEnabled = False
                                .Width = 210
                                .Left = campoX
                                .Top = campoY
                                .TabIndex = tabIndice
                                .Tag = idCampo

                                Dim dsLista As New DataSet
                                Dim comandoLista As New SqlClient.SqlCommand
                                With comandoLista
                                    .CommandType = CommandType.Text
                                    .CommandText = "select CAMPO_VALOR, CAMPO_DESCRIPCION from EMPLEADO_CAMPOS_LV Where CAMPO_ID = " & Scm(idCampo)
                                End With
                                dsLista = GetDataSet(comandoLista)

                                Dim temp, temp1 As String
                                Dim combo As New List(Of Citi.Synergia.Entidades.CodigoDescripcion)
                                If Not dsLista Is Nothing Then
                                    If dsLista.Tables(0).Rows.Count > 0 Then
                                        For Each filaLista As DataRow In dsLista.Tables(0).Rows
                                            band = True
                                            temp = filaLista.Item("CAMPO_VALOR").ToString
                                            temp1 = filaLista.Item("CAMPO_DESCRIPCION").ToString
                                            With combo
                                                .Add(New Citi.Synergia.Entidades.CodigoDescripcion(temp, temp & " - " & temp1))
                                            End With
                                        Next
                                    Else
                                        With combo
                                            .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente de Definicion")))
                                        End With
                                    End If
                                Else
                                    With combo
                                        .Add(New Citi.Synergia.Entidades.CodigoDescripcion("P", Citi.Synergia.Traductor.Idiomas.GetMensaje(103, "P - Pendiente de Definicion")))
                                    End With
                                End If

                                With oCombo
                                    .ValueMember = "Codigo"
                                    .DisplayMember = "Descripcion"
                                    .DataSource = combo
                                End With

                                If band Then
                                    .Enabled = True
                                Else
                                    .Enabled = False
                                End If

                                campoY += .Height
                            End With
                            Me.panCampos.Controls.Add(oCombo)
                        End If

                        '-- Incrementos
                        campoY += incrementoCampo
                        labelY += incrementoLabel

                        listaAnterior = listaValores

                        tabIndice += 1
                    Next
                End If
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub kPila(ByVal Acción As Short)
        If Acción And cp_POP Then txtEMPLEADO_ID.Text = Pop()
    End Sub

    Private Function TieneAccesoSalario(ByVal muestraMensaje As String) As Boolean
        Dim retorno As Boolean = False
        Dim tieneAcceso As String

        tieneAcceso = "X"

        Try
            meteSQL("declare @VALOR varchar(255)")
            meteSQL(" exec Obtiene_Bloqueos " & Scm(Citi.Synergia.Locals.Cache.UsuarioSSO) & ", 'BLOQUEA_SALARIOS', @VALOR = @VALOR OutPut")
            meteSQL(" select @VALOR")

            'Mostrarsql
            EjecutaSQL("")

            Do While SqlNextRow(Sqlconn) = MOREROWS
                tieneAcceso = SqlData(Sqlconn, 1).ToString
            Loop
            If muestraMensaje = "S" And tieneAcceso = "X" Then
                Citi.Synergia.HelperClient.Utils.CITIMsgBox(Citi.Synergia.Traductor.Idiomas.GetMensaje(298, "El usuario no tiene acceso a consultar/modificar salarios."), Utils.TipoDeMensaje.TipoError)
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If tieneAcceso = "X" Then
            retorno = False
        Else
            retorno = True
        End If

        Return retorno
    End Function

    Private Sub Leer()
        Try
            If Modo_Local <> Modo_Alta Then
                meteSQL("select")
                meteSQL(" EMPLEADO.ESTADO_EMPLEADO, ")
                meteSQL(" convert(varchar, EMPLEADO.FECHA_RETIRO, 101), ")
                meteSQL(" EMPLEADO.APELLIDO_PATERNO, ")
                meteSQL(" EMPLEADO.APELLIDO_MATERNO, ")
                meteSQL(" EMPLEADO.APELLIDO_CASADA, ")
                meteSQL(" EMPLEADO.NOMBRES, ")
                meteSQL(" EMPLEADO.NOMBRE_USUAL, ")
                meteSQL(" EMPLEADO.LICENCIA_CONDUCIR, ")
                meteSQL(" EMPLEADO.PASAPORTE, ")
                meteSQL(" EMPLEADO.NACIONALIDAD, ")
                meteSQL(" convert(varchar,EMPLEADO.FECHA_NACIMIENTO,101), ")
                meteSQL(" EMPLEADO.ESTADO_CIVIL, ")
                meteSQL(" EMPLEADO.CEDULA_EXT, ")
                meteSQL(" EMPLEADO.CEDULA, ")
                meteSQL(" EMPLEADO.NUMERO_SEGURO_SOCIAL, ")
                meteSQL(" EMPLEADO.DIRECCION_DOMICILIO, ")
                meteSQL(" EMPLEADO.TELEFONO, ")
                meteSQL(" EMPLEADO.INDICA_SEXO, ")
                meteSQL(" EMPLEADO.LUGAR_NACIMIENTO, ")
                meteSQL(" IsNull(EMPLEADO.PESO, 0), ")
                meteSQL(" IsNull(EMPLEADO.ESTATURA, 0.00), ")
                meteSQL(" EMPLEADO.RELIGION, ")
                meteSQL(" EMPLEADO.NIT, ")
                meteSQL(" convert(varchar,EMPLEADO.FECHA_CONTRATACION,101), ")
                meteSQL(" EMPLEADO.TIPO_DE_PAGO, ")
                meteSQL(" EMPLEADO.BANCO_DEPOSITO, ")
                meteSQL(" EMPLEADO.CUENTA_DEPOSITO, ")
                meteSQL(" IsNull(EMPLEADO.PORC_ANTICIPO, 0), ")
                meteSQL(" EMPLEADO.CODIGO_TIPO, ")
                meteSQL(" EMPLEADO.CODIGO_DIVISION, ")
                meteSQL(" EMPLEADO.TIPO_EMPLEADO, ")
                meteSQL(" EMPLEADO.CODIGO_PUESTO, ")
                meteSQL(" convert(varchar,EMPLEADO.FECHA_ULT_VACACION,101), ")
                meteSQL(" convert(varchar,EMPLEADO.FECHA_RETIRO,101), ")
                meteSQL(" EMPLEADO.ESTADO_EMPLEADO, ")
                meteSQL(" EMPLEADO.TIPO_ASOCIACION, ")
                meteSQL(" IsNull(round(EMPLEADO.DIAS_ANT_VACACION,2), 0.00), ")
                meteSQL(" EMPLEADO.INDICA_MARCA_TARJETA, ")
                meteSQL(" EMPLEADO.NO_TARJETA_RELOJ, ")
                meteSQL(" Convert(varchar(10),EMPLEADO.FECHA_ULT_INDEMNIZA, 101), ")
                meteSQL(" EMPLEADO.CARNET_ELECTORAL,")
                meteSQL(" EMPLEADO.CODIGO_DE_CLIENTE, ")
                meteSQL(" EMPLEADO.NOMBRE_SEGURO_SOCIAL, ")
                meteSQL(" isnull(convert(varchar,EMPLEADO.FECHA_INICIO_REL_LAB,101), '__/__/____'), ")
                meteSQL(" EMPLEADO.TIPO_SANGRE, ")
                meteSQL(" EMPLEADO.JEFE, ")
                meteSQL(" EMPLEADO.NOMBRE_CORTO_ID, ")
                meteSQL(" isnull(convert(varchar,EMPLEADO.ULT_ASIGNACION_VACAC,101), '__/__/____'), ")
                meteSQL(" EMPLEADO.DIRECCION_EMAIL, ")
                meteSQL(" EMPLEADO.timestamp ")
                meteSQL("from EMPLEADO")
                meteSQL(" where EMPLEADO.EMPLEADO_ID     = " & Scm(txtEMPLEADO_ID.Text))

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    Me._estadoEmpleado = SqlData(Sqlconn, 1).ToString
                    Me._fechaRetiro = SqlData(Sqlconn, 2).ToString
                    txtAPELLIDO_PATERNO.Text = SqlData(Sqlconn, 3).ToString
                    txtAPELLIDO_MATERNO.Text = SqlData(Sqlconn, 4).ToString
                    txtAPELLIDO_CASADA.Text = SqlData(Sqlconn, 5).ToString
                    txtNOMBRES.Text = SqlData(Sqlconn, 6).ToString
                    txtNOMBRE_USUAL.Text = SqlData(Sqlconn, 7).ToString
                    txtLICENCIA_CONDUCIR.Text = SqlData(Sqlconn, 8).ToString
                    txtPASAPORTE.Text = SqlData(Sqlconn, 9).ToString
                    txtNACIONALIDAD.Text = SqlData(Sqlconn, 10).ToString
                    txtFECHA_NACIMIENTO.EscribirFecha(SqlData(Sqlconn, 11).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    cboESTADO_CIVIL.SelectedValue = SqlData(Sqlconn, 12).ToString
                    txtCEDULA_EXT.Text = SqlData(Sqlconn, 13).ToString
                    txtCEDULA.Text = SqlData(Sqlconn, 14).ToString
                    txtNUMERO_SEGURO_SOCIAL.Text = SqlData(Sqlconn, 15).ToString
                    txtDIRECCION_DOMICILIO.Text = SqlData(Sqlconn, 16).ToString
                    txtTELEFONO.Text = SqlData(Sqlconn, 17).ToString
                    cboINDICA_SEXO.SelectedValue = SqlData(Sqlconn, 18).ToString
                    txtLUGAR_NACIMIENTO.Text = SqlData(Sqlconn, 19).ToString
                    txtPESO.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 20))
                    txtESTATURA.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 21))
                    txtRELIGION.Text = SqlData(Sqlconn, 22).ToString
                    txtNIT.Text = SqlData(Sqlconn, 23).ToString
                    txtFECHA_CONTRATACION.EscribirFecha(SqlData(Sqlconn, 24).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    cboTIPO_DE_PAGO.SelectedValue = SqlData(Sqlconn, 25).ToString
                    txtBANCO_DEPOSITO.Text = SqlData(Sqlconn, 26).ToString
                    txtCUENTA_DEPOSITO.Text = SqlData(Sqlconn, 27).ToString
                    txtPORC_ANTICIPO.Text = String.Format("{0:0,0}", SqlData(Sqlconn, 28))
                    txtCODIGO_TIPO.Text = SqlData(Sqlconn, 29).ToString
                    txtCODIGO_DIVISION.Text = SqlData(Sqlconn, 30).ToString
                    txtTIPO_EMPLEADO.Text = SqlData(Sqlconn, 31).ToString
                    txtCODIGO_PUESTO.Text = SqlData(Sqlconn, 32).ToString
                    txtFECHA_VACACION.EscribirFecha(IIf(SqlData(Sqlconn, 33).ToString <> "", SqlData(Sqlconn, 33).ToString, "__/__/____"), Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtF_RETIRO.EscribirFecha(IIf(SqlData(Sqlconn, 34).ToString <> "", SqlData(Sqlconn, 34).ToString, "__/__/____"), Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    Activo.CheckState = IIf(SqlData(Sqlconn, 35).ToString = "A", 1, 0)
                    CboTIPO_ASOCIACION.SelectedValue = SqlData(Sqlconn, 36).ToString
                    txtDIAS_ANT_VACACIONES.Text = String.Format("{0:0,0.00}", SqlData(Sqlconn, 37))
                    cboINDICA_MARCA_TARJETA.SelectedValue = SqlData(Sqlconn, 38).ToString
                    txtNO_TARJETA_RELOJ.Text = SqlData(Sqlconn, 39).ToString
                    txtFECH_ULT_INDEMNIZA.EscribirFecha(IIf(SqlData(Sqlconn, 40).ToString = "", "__/__/____", SqlData(Sqlconn, 40).ToString), Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtCARNET_ELECTORAL.Text = SqlData(Sqlconn, 41).ToString
                    txtCODIGO_DE_CLIENTE.Text = SqlData(Sqlconn, 42).ToString
                    txtNOMBRE_SEGURO_SOCIAL.Text = SqlData(Sqlconn, 43).ToString
                    MskFECHA_INICIO_REL_LAB.EscribirFecha(SqlData(Sqlconn, 44).ToString, Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtTIPO_SANGRE.Text = SqlData(Sqlconn, 45).ToString
                    txtJEFE.Text = SqlData(Sqlconn, 46).ToString
                    txtNOMBRE_CORTO_ID.Text = SqlData(Sqlconn, 47).ToString
                    txtULT_ASIGNACION_VACAC.EscribirFecha(IIf(SqlData(Sqlconn, 48).ToString = "", "__/__/____", SqlData(Sqlconn, 48).ToString), Citi.Synergia.UIGenerico.SynTextoFecha.FormatoFecha.MDY)
                    txtDIRECCION_EMAIL.Text = SqlData(Sqlconn, 49).ToString

                    MyBase.ReadTimeStamp()

                    TimeStamp_Local = SysTimeStamp
                Loop

                '***********************
                'Leemos Campos customizados
                '***********************
                Me.LeeCampos()
            End If

            If Me._muestraSalarios Then
                'OBTENER SUELDOS
                Dim comando As New SqlClient.SqlCommand
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "OBTENER_EMPLEADO_SUELDO"
                    .Parameters.Add("@EMPLEADO_ID", SqlDbType.VarChar, 10).Value = txtEMPLEADO_ID.Text
                    .Parameters.Add("@NO_SUELDO", SqlDbType.SmallInt).Value = 0
                    .Parameters.Add("@MONTO_SUELDO", SqlDbType.Money).Value = 0
                    .Parameters.Add("@TARIFA_EXT_SIMPLE", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@TARIFA_EXT_DOBLE", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@BONIFICACION", SqlDbType.Money).Value = 0
                    .Parameters.Add("@DEPRECIA_VEHICULO", SqlDbType.Money).Value = 0
                    .Parameters.Add("@VIATICOS", SqlDbType.Money).Value = 0

                    '-- Input/Output
                    .Parameters(0).Direction = ParameterDirection.Input

                    For i As Integer = 1 To .Parameters.Count - 1
                        .Parameters(i).Direction = ParameterDirection.Output
                    Next
                End With

                Dim parametro As SqlClient.SqlParameter
                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@EMPLEADO_ID"
                    .Direction = ParameterDirection.Input
                    .SqlDbType = SqlDbType.VarChar
                    .Size = 10
                    .Value = txtEMPLEADO_ID.Text
                End With

                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@NO_SUELDO"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.SmallInt
                    .Value = 0
                End With

                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@MONTO_SUELDO"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Money
                    .Value = 0
                End With

                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@TARIFA_EXT_SIMPLE"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Decimal
                    .Value = 0
                End With

                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@TARIFA_EXT_DOBLE"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Decimal
                    .Value = 0
                End With

                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@BONIFICACION"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Money
                    .Value = 0
                End With

                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@DEPRECIA_VEHICULO"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Money
                    .Value = 0
                End With

                parametro = New SqlClient.SqlParameter
                With parametro
                    .ParameterName = "@VIATICOS"
                    .Direction = ParameterDirection.Output
                    .SqlDbType = SqlDbType.Money
                    .Value = 0
                End With

                EjecutarComando(comando)

                txtSUELDO_ORD.Text = String.Format("{0:0,0.00}", comando.Parameters(2).Value)
                txtTARIFA_SIMPLE.Text = String.Format("{0:0,0.00}", comando.Parameters(3).Value)
                txtTARIFA_DOBLE.Text = String.Format("{0:0,0.00}", comando.Parameters(4).Value)
                txtBONIFICACION.Text = String.Format("{0:0,0.00}", comando.Parameters(5).Value)
                txtDEPRECIACION_VEHICULO.Text = String.Format("{0:0,0.00}", comando.Parameters(6).Value)
                txtVIATICOS.Text = String.Format("{0:0,0.00}", comando.Parameters(7).Value)
            Else
                txtSUELDO_ORD.Text = "*******.**"
                txtTARIFA_SIMPLE.Text = "*******.**"
                txtTARIFA_DOBLE.Text = "*******.**"
                txtBONIFICACION.Text = "*******.**"
                txtDEPRECIACION_VEHICULO.Text = "*******.**"
                txtVIATICOS.Text = "*******.**"
            End If

            'OBTENER TIEMPO TRABAJADO
            ' Y EDAD
            If Me.txtFECHA_NACIMIENTO.Text <> "__/__/____" Then
                meteSQL(" declare ")
                meteSQL(" @hoy datetime,")
                meteSQL(" @meses int,")
                meteSQL(" @anos  int")
                meteSQL(" select @hoy = getdate()")
                meteSQL(" select @meses = datediff(mm," & Scm(txtFECHA_NACIMIENTO.TextMMDDYYYY()) & ", @hoy)")
                meteSQL(" select @anos = @meses / 12")
                meteSQL(" select @meses = @meses - (@anos * 12)")
                meteSQL(" select @anos, @meses")

                EjecutaSQL("")

                Do While SqlNextRow(Sqlconn) = MOREROWS
                    _txtEDAD_0.Text = SqlData(Sqlconn, 1).ToString
                    _txtEDAD_1.Text = SqlData(Sqlconn, 2).ToString
                Loop
            End If

            If Me.txtFECHA_CONTRATACION.TextMMDDYYYY <> "__/__/____" Then
                meteSQL(" declare ")
                meteSQL(" @hoy datetime,")
                meteSQL(" @meses int  ,")
                meteSQL(" @anos  int ")
                meteSQL(" select @hoy = getdate()  ")
                If Me.txtF_RETIRO.Text = "__/__/____" Then
                    meteSQL(" select @meses = datediff(mm," & Scm(txtFECHA_CONTRATACION.TextMMDDYYYY()) & ",@hoy)  ")
                Else
                    meteSQL(" select @meses = datediff(mm," & Scm(txtFECHA_CONTRATACION.TextMMDDYYYY()) & "," & Scm(txtF_RETIRO.TextMMDDYYYY()) & ")")
                End If
                meteSQL(" select @anos = @meses / 12")
                meteSQL(" select @meses = @meses - (@anos * 12)")
                meteSQL(" select @anos,@meses")

                EjecutaSQL("")
                
                Do While SqlNextRow(Sqlconn) = MOREROWS
                    _txtTIEMPO_LABORADO_0.Text = SqlData(Sqlconn, 1).ToString
                    _txtTIEMPO_LABORADO_1.Text = SqlData(Sqlconn, 2).ToString
                Loop
            End If

            If Not String.IsNullOrEmpty(TraeDato("Select NOMBRE_CLIENTE from CLIENTES where CODIGO_DE_CLIENTE = " & sen(txtCODIGO_DE_CLIENTE.Text))) Then
                lblNOMBRE_CLIENTE.Text = TraeDato("Select NOMBRE_CLIENTE from CLIENTES where CODIGO_DE_CLIENTE = " & sen(txtCODIGO_DE_CLIENTE.Text)).ToString
            End If

            Habilitar()

            txtF_RETIRO.Visible = IIf(txtF_RETIRO.Text = "__/__/____", False, True)
            lbltitF_RETIRO.Visible = txtF_RETIRO.Visible
            Label6.Visible = lbltitF_RETIRO.Visible

            If Modo_Local <> Modo_Alta Then
                txtF_RETIRO.Enabled = False
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LeeCampos()
        Try
            If Me.panCampos.Controls.Count > 0 Then
                For Each ctrl As Control In Me.panCampos.Controls
                    Dim idCampo As String = String.Empty
                    If TypeOf ctrl Is Citi.Synergia.UIGenerico.SynTextBox Or TypeOf ctrl Is ComboBox Then
                        If Not String.IsNullOrEmpty(ctrl.Tag) Then
                            idCampo = ctrl.Tag.ToString
                        End If

                        Dim comandoSQL As New System.Text.StringBuilder
                        With comandoSQL
                            .Append("Select")
                            .Append("       EMPLEADO_CAMPOS.CAMPO_LISTA_VALORES")
                            .Append("     , EMPLEADO_CAMPOS_VAL.VALOR_CAMPO")
                            .Append("  From EMPLEADO_CAMPOS_VAL")
                            .Append("     , EMPLEADO_CAMPOS")
                            .Append(" where EMPLEADO_CAMPOS_VAL.EMPLEADO_ID = " & Scm(txtEMPLEADO_ID.Text))
                            .Append("   And EMPLEADO_CAMPOS_VAL.CAMPO_ID    = " & Scm(idCampo))
                            .Append("   And EMPLEADO_CAMPOS.CAMPO_ID        = EMPLEADO_CAMPOS_VAL.CAMPO_ID")
                            .Append("       Order by EMPLEADO_CAMPOS.CAMPO_LISTA_VALORES,EMPLEADO_CAMPOS_VAL.CAMPO_ID")
                        End With
                        Dim comando As New SqlClient.SqlCommand
                        With comando
                            .CommandText = comandoSQL.ToString()
                        End With

                        Dim data As DataSet = GetDataSet(comando)

                        If Not data Is Nothing Then
                            If data.Tables.Count > 0 Then
                                For Each filaData As DataRow In data.Tables(0).Rows
                                    Dim lista As String = String.Empty
                                    Dim campoValor As String = String.Empty

                                    lista = filaData.Item(0).ToString
                                    campoValor = filaData.Item(1).ToString

                                    If TypeOf ctrl Is ComboBox And lista = "S" Then
                                        Dim cboBox As ComboBox = ctrl
                                        If cboBox.Enabled Then
                                            If campoValor.Trim.Length > 0 Then
                                                cboBox.SelectedValue = campoValor
                                            Else
                                                cboBox.SelectedIndex = -1
                                            End If
                                        End If
                                    End If

                                    If TypeOf ctrl Is Citi.Synergia.UIGenerico.SynTextBox And lista = "N" Then
                                        Dim ctrlTexto As Citi.Synergia.UIGenerico.SynTextBox = ctrl
                                        ctrlTexto.Text = campoValor
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next
            End If

        Catch errSQL As SqlClient.SqlException
            MessageBox.Show(errSQL.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Citi.Synergia.Traductor.Idiomas.GetMensaje(279, "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Codigos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCODIGO_TIPO.TextChanged, txtCODIGO_DIVISION.TextChanged, txtTIPO_EMPLEADO.TextChanged, txtCODIGO_PUESTO.TextChanged, txtNOMBRE_CORTO_ID.TextChanged, txtJEFE.TextChanged
        Select Case sender.Name
            Case "txtCODIGO_TIPO"
                lblDESCRIPCION_NOMINA.Text = DescripcionesDB.NominaTipo(txtCODIGO_TIPO.Text)
            Case "txtCODIGO_DIVISION"
                lblDESCRIPCION_DIVISION.Text = DescripcionesDB.Division(txtCODIGO_DIVISION.Text)
            Case "txtTIPO_EMPLEADO"
                lblDESCRIPCION_TIPO.Text = DescripcionesDB.EmpleadoTipo(txtTIPO_EMPLEADO.Text)
            Case "txtCODIGO_PUESTO"
                lblDESCRIPCION_PUESTO.Text = DescripcionesDB.Puestos(txtCODIGO_PUESTO.Text)
            Case "txtNOMBRE_CORTO_ID"
                lblNOMBRE.Text = DescripcionesDB.UsuariosNombre(txtNOMBRE_CORTO_ID.Text)
            Case "txtJEFE"
                If Not String.IsNullOrEmpty(TraeDato("select NOMBRE_USUAL from EMPLEADO where EMPLEADO_ID = " & Scm(txtJEFE.Text))) Then
                    lblJEFE.Text = TraeDato("select NOMBRE_USUAL from EMPLEADO where EMPLEADO_ID = " & Scm(txtJEFE.Text)).ToString
                End If
        End Select
    End Sub

    Private Sub TipoDePago_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTIPO_DE_PAGO.SelectedValueChanged
        If cboTIPO_DE_PAGO.SelectedValue <> "D" Then
            txtCUENTA_DEPOSITO.Visible = False
        Else
            txtCUENTA_DEPOSITO.Visible = True
        End If
    End Sub

    Private Sub Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class