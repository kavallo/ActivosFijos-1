Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FAplicaciones
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LeerData()
    End Sub

    Private Sub LeerData()
        Dim aplicaciones As List(Of Citi.Synergia.Entidades.Aplicaciones) = AdminLANG.Helper.LeerAplicaciones()

        lstAplicaciones.Items.Clear()

        For Each app As Citi.Synergia.Entidades.Aplicaciones In aplicaciones
            Dim oitem As New ListViewItem(app.Aplicacion)

            lstAplicaciones.Items.Add(oitem)
        Next
    End Sub

    Private Sub Seleccionar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAplicaciones.DoubleClick
        Me.AplicacionManto()
    End Sub

    Private Sub AplicacionManto()
        If Me.lstAplicaciones.SelectedItems.Count > 0 Then
            Dim aplicacion As String = Me.lstAplicaciones.SelectedItems.Item(0).Text

            Dim frmMantenimiento As New FAplicacionManto
            With frmMantenimiento
                .Aplicacion = aplicacion
                .NombreForma = ""
                .Show()
            End With
        End If
    End Sub

    Private Sub Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAgregar.Click
        Dim frmAgregar As New FAplicacionAgregar
        With frmAgregar
            .ShowDialog(Me)
            If .HubieronCambios Then
                Me.LeerData()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub
End Class