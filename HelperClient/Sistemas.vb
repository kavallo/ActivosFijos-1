Public Class Sistemas
    Private Const nombreArchivoXml As String = "\Sistemas.xml"
    Public Enum ErrHandler
        ArchivoXmlNoEncontrado
        NingunError
    End Enum

    Public Shared ErrorEncontrado As ErrHandler

    Public Shared Function LeerNumeroRegistrosEnGrid() As Integer
        Dim retorno As Integer = 0

        If System.IO.File.Exists(My.Application.Info.DirectoryPath + nombreArchivoXml) Then
            Dim archivo As String = My.Application.Info.DirectoryPath + nombreArchivoXml
            Dim oXml As Xml.XmlDocument = Utils.AbrirArchivoXml(archivo)
            If Not oXml Is Nothing Then
                Dim oConfiguracion As Xml.XmlNode = oXml.SelectSingleNode("ROOT").SelectSingleNode("CONFIGURACION").SelectSingleNode("GENERALES").SelectSingleNode("baseDeDatos")

                If Not oConfiguracion Is Nothing Then
                    Dim registros As Xml.XmlNode = oConfiguracion.SelectSingleNode("numeroRegistrosEnGrid")
                    If Not registros Is Nothing Then
                        If Not registros.InnerText Is Nothing Then
                            If registros.InnerText.ToString().Trim.Length > 0 Then
                                Integer.TryParse(registros.InnerText, retorno)
                            End If
                        End If
                        retorno = registros.InnerText
                    End If
                End If
            End If
        Else
            ErrorEncontrado = ErrHandler.ArchivoXmlNoEncontrado
        End If

        Return retorno
    End Function

    Public Shared Function LeerCompanias() As List(Of Citi.Synergia.Entidades.Companias)
        ErrorEncontrado = ErrHandler.NingunError

        Dim companias As New List(Of Citi.Synergia.Entidades.Companias)

        If System.IO.File.Exists(My.Application.Info.DirectoryPath + nombreArchivoXml) Then
            Dim archivo As String = My.Application.Info.DirectoryPath + nombreArchivoXml
            Dim oXml As Xml.XmlDocument = Utils.AbrirArchivoXml(archivo)
            If Not oXml Is Nothing Then
                Dim oNodoCias As Xml.XmlNode = oXml.SelectSingleNode("ROOT").SelectSingleNode("COMPANIAS")
                If Not oNodoCias Is Nothing Then
                    For Each oNodo As Xml.XmlNode In oNodoCias.SelectNodes("LINEA")
                        Dim branchCode As String = String.Empty
                        Dim branchCodeLength As Integer = 0
                        Dim adeComplement As String = String.Empty
                        Dim adeComplementLength As Integer = 0

                        branchCode = oNodo.Attributes("BranchCode").InnerText
                        If Integer.TryParse(oNodo.Attributes("BranchCodeLength").InnerText, branchCodeLength) Then
                            branchCodeLength = oNodo.Attributes("BranchCodeLength").InnerText
                        Else
                            branchCodeLength = 0
                        End If
                        adeComplement = oNodo.Attributes("ADEComplement").InnerText
                        If Integer.TryParse(oNodo.Attributes("ADEComplementLength").InnerText, adeComplementLength) Then
                            adeComplementLength = oNodo.Attributes("ADEComplementLength").InnerText
                        Else
                            adeComplementLength = 0
                        End If

                        Dim compania As New Citi.Synergia.Entidades.Companias(oNodo.Attributes("Indice").InnerText, oNodo.Attributes("Servidor").InnerText, oNodo.Attributes("BaseDeDatos").InnerText, oNodo.Attributes("Descripcion").InnerText, oNodo.Attributes("LegalEntity").InnerText, oNodo.Attributes("Country").InnerText, oNodo.Attributes("BatchCode").InnerText, oNodo.Attributes("TransactionCodeDebit").InnerText, oNodo.Attributes("TransactionCodeCredit").InnerText, branchCode, branchCodeLength, adeComplement, adeComplementLength)
                        companias.Add(compania)
                    Next
                End If
            End If
        Else
            ErrorEncontrado = ErrHandler.ArchivoXmlNoEncontrado
        End If

        Return companias
    End Function

    Public Shared Function LeerIdiomas(ByRef utilizarIdiomas As Boolean, ByRef crearIdioma As Boolean) As List(Of Citi.Synergia.Entidades.Idiomas)
        ErrorEncontrado = ErrHandler.NingunError
        Dim idiomas As New List(Of Citi.Synergia.Entidades.Idiomas)

        Dim archivo As String = My.Application.Info.DirectoryPath + nombreArchivoXml
        If Utils.ArchivoExiste(archivo) Then
            Dim oXml As Xml.XmlDocument = Utils.AbrirArchivoXml(archivo)
            If Not oXml Is Nothing Then
                Dim oConfiguracion As Xml.XmlNode = oXml.SelectSingleNode("ROOT").SelectSingleNode("CONFIGURACION")
                If Not oConfiguracion Is Nothing Then
                    utilizarIdiomas = oConfiguracion.SelectSingleNode("IDIOMAS").Attributes("UtilizarIdiomas").InnerText
                    crearIdioma = oConfiguracion.SelectSingleNode("IDIOMAS").Attributes("CrearIdiomas").InnerText

                    For Each oNodo As Xml.XmlNode In oConfiguracion.SelectSingleNode("IDIOMAS").SelectNodes("LINEA")
                        Dim idioma As New Citi.Synergia.Entidades.Idiomas(oNodo.Attributes("Codigo").InnerText, oNodo.Attributes("Descripcion").InnerText)
                        idiomas.Add(idioma)
                    Next
                End If
            End If
        Else
            ErrorEncontrado = ErrHandler.ArchivoXmlNoEncontrado
        End If

        Return idiomas
    End Function

    Public Shared Sub LeerConfigXmlSG(ByRef applicationID As String, ByRef pathConfigXml As String)
        ErrorEncontrado = ErrHandler.NingunError

        Dim archivo As String = My.Application.Info.DirectoryPath + nombreArchivoXml
        If Utils.ArchivoExiste(archivo) Then
            Dim oXml As Xml.XmlDocument = Utils.AbrirArchivoXml(archivo)
            If Not oXml Is Nothing Then
                Dim oConfiguracion As Xml.XmlNode = oXml.SelectSingleNode("ROOT").SelectSingleNode("SecuritySG")
                If Not oConfiguracion Is Nothing Then
                    applicationID = oConfiguracion.SelectSingleNode("ApplicationID").InnerText
                    pathConfigXml = oConfiguracion.SelectSingleNode("PathConfigXmlSG").InnerText
                Else
                    System.Windows.Forms.MessageBox.Show("Node 'SecuritySG\ApplicationID' not found. Contact local support.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
                End If
            End If
        Else
            ErrorEncontrado = ErrHandler.ArchivoXmlNoEncontrado
        End If
    End Sub

    Public Shared Function LeerDiaInicioProcesoDepreciacion() As Integer
        Dim retorno As Integer = 0

        If System.IO.File.Exists(My.Application.Info.DirectoryPath + nombreArchivoXml) Then
            Dim archivo As String = My.Application.Info.DirectoryPath + nombreArchivoXml
            Dim oXml As Xml.XmlDocument = Utils.AbrirArchivoXml(archivo)
            If Not oXml Is Nothing Then
                Dim oConfiguracion As Xml.XmlNode = oXml.SelectSingleNode("ROOT").SelectSingleNode("CONFIGURACION").SelectSingleNode("GENERALES").SelectSingleNode("baseDeDatos")

                If Not oConfiguracion Is Nothing Then
                    Dim diaInicio As Xml.XmlNode = oConfiguracion.SelectSingleNode("DiaInicioProcesoDepreciacion")
                    If Not diaInicio Is Nothing Then
                        If Not diaInicio.InnerText Is Nothing Then
                            If diaInicio.InnerText.ToString().Trim.Length > 0 Then
                                Integer.TryParse(diaInicio.InnerText, retorno)
                            End If
                        End If
                        retorno = diaInicio.InnerText
                    Else
                        diaInicio = oXml.CreateElement("DiaInicioProcesoDepreciacion")
                        diaInicio.InnerText = "22"
                        oConfiguracion.AppendChild(diaInicio)
                        oXml.Save(archivo)
                    End If
                End If
            End If
        Else
            ErrorEncontrado = ErrHandler.ArchivoXmlNoEncontrado
        End If

        Return retorno
    End Function
End Class
