Imports System.Windows.Forms

Public Class frmConexionDialog

    Private _datasource As DataTable
    Private _labelVisible As Boolean = False
    Private _ambienteLocal As Ambiente
    Private _ConexionSeleccionada As DatosConexion


    ''' <summary>
    ''' Para poder inicializar este Dialog es necesario especificar el Data table que cargará el combobox a mostrar al usuario
    ''' </summary>
    ''' <param name="datasources">Data table DATASOURCES</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal datasources As System.Data.DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        _datasource = datasources
        _ambienteLocal = gAmbienteLocal
    End Sub

    Public ReadOnly Property conexionSeleccinada() As DatosConexion
        Get
            Return _ConexionSeleccionada
        End Get
    End Property



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmConexionDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbFuentes.DisplayMember = "NOMBRE"
        Me.cmbFuentes.ValueMember = "NOMBRE"
        Me.cmbFuentes.DataSource = _datasource

        Me.Text = Me.Text + " - " + gID_Sistema.ToString + " - " + gNombreSistema
    End Sub


    Private Sub cmbFuentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFuentes.SelectedIndexChanged


        If Me.cmbFuentes.SelectedIndex > -1 Then
            Dim Q = (From dato In Me._datasource.Rows _
                   Where dato("NOMBRE") = Me.cmbFuentes.SelectedValue).Single

            _ConexionSeleccionada.Server = Q("SERVIDOR")
            _ConexionSeleccionada.Puerto = Q("PUERTO")
            _ConexionSeleccionada.Database = Q("DATABASE")


            lblDatosConexion.Text = "Ambiente: " + _ambienteLocal.ToString + "   Codigo SG: " + gCodigoSG.ToString + vbCrLf + _
            "Servidor: " + _ConexionSeleccionada.GetDataSource + vbCrLf + _
            "Base de Datos: " + _ConexionSeleccionada.Database
            lblDatosConexion.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If _labelVisible Then
            Me.Height = 195
            _labelVisible = False
            Me.Button1.Text = ">>"
        Else
            Me.Height = 244
            _labelVisible = True
            Me.Button1.Text = "<<"
        End If

    End Sub
End Class
