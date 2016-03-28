Imports Intelexion.Framework.Model
Imports System.Data
Imports Intelexion.Nomina
Imports System.Web
Imports System.Collections
Imports System.Collections.Specialized
Imports Intelexion.Framework.Controller
Imports Intelexion.Framework.View
Imports System.IO
Imports System.Data.SqlClient

Public Class DAO
    Inherits Intelexion.Framework.Model.DAO


    Private Const spReporteBajasFA As String = "sp_Reporte_BajasFondoAhorro '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@AnioDesde','@PeriodoDesde','@AnioHasta','@PeriodoHasta','@UID','@LID','@idAccion'"
    Private Const spReporteAltasFA As String = "sp_Reporte_AltasFondoAhorro '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@AnioDesde','@PeriodoDesde','@AnioHasta','@PeriodoHasta','@UID','@LID','@idAccion'"
    Private Const spReporteDescuentoFA As String = "sp_Reporte_DescuentosFondoAhorro '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const spReporteAportacionFA As String = "sp_Reporte_AportacionFondoAhorro '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const ValesDespensaDispersion As String = "ValesDespensa_Dispersion '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const ValesDespensaAltas As String = "sp_Reporte_AltasValesDespensa '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@AnioDesde','@PeriodoDesde','@AnioHasta','@PeriodoHasta','@UID','@LID','@idAccion'"
    Private Const LayoutDispersionHSBC_ALI As String = "sp_Reporte_LayoutDispersionHSBC_ALI '@IdRazonSocial','@IdEmpleado','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const LayoutDispersionBANAMEXS As String = "sp_Reporte_LayoutDispersion_BANAMEXS '@IdRazonSocial','@IdEmpleado','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const LayoutDispersionBANORTE_SIGA As String = "sp_Reporte_LayoutBANORTE_SIGA '@IdRazonSocial','@IdEmpleado','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const PolizaSeglo As String = "sp_Reporte_PolizaContableSEGLO '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const PolizaSegloProvision As String = "sp_Reporte_PolizaContableSEGLO_Provision '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const PolizaSegloReclasificacion As String = "sp_Reporte_PolizaContableSEGLO_Reclasificacion '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const ReciboNominaTXT As String = "spq_ReciboNomina_SegloTXT '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@IdEmpleado','@UID','@LID','@idAccion'"
    Private Const Reporte_LayoutDispersionBANCOMER_NETCASH108_Historico As String = "sp_Reporte_LayoutDispersionBANCOMER_NETCASH108_Historico '@IdRazonSocial','@IdEmpleado','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const DispersionInterbancario As String = "sp_Reporte_LayoutDispersion_Interbancario '@IdRazonSocial','@IdEmpleado','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const Baja_Fondo_Ahorro_IXE As String = "sp_Reporte_LayoutDispersionHSBC_Historico '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"


    Public Sub New(ByVal DataConnection As SQLDataConnection)
        MyBase.New(DataConnection)
    End Sub
    Public Function Layout(ByVal ReportesProceso As EntitiesITX.ReportesProceso, ByVal opL As String) As DataSet
        Dim ds As New DataSet
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            Select Case opL


                Case "spReporteAportacionFA"
                    comandstr = spReporteAportacionFA
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "spReporteDescuentoFA"
                    comandstr = spReporteDescuentoFA
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "spReporteAltasFA"
                    comandstr = spReporteAltasFA
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "spReporteBajasFA"
                    comandstr = spReporteBajasFA
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "ValesDespensaDispersion"
                    comandstr = ValesDespensaDispersion
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "ValesDespensaAltas"
                    comandstr = ValesDespensaAltas
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "Baja_Fondo_Ahorro_IXE"
                    comandstr = spReporteAportacionFA
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds


            End Select
        Catch e As Exception
        End Try
        Return ds
    End Function

    Public Function LayoutTxt(ByVal ReportesProceso As EntitiesITX.ReportesProceso, ByVal opL As String, ByVal context As System.Web.HttpContext) As String
        Dim ds As New DataSet
        Dim sFile As String
        Dim sPathApp As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath")
        Dim sPathArchivosTemp As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ArchivosTemporales")
        'Dim ruta As String
        Try
            Select Case opL

                


                Case "LayoutDispersionHSBC_ALI"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\LayoutDispersionHSBC_ALI" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReporteDispersionHSBC(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile

                Case "LayoutDispersionBANAMEXS"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\LayoutDispersionBANAMEXS" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReporteDispersionBANAMEX(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile


                Case "LayoutDispersionBANORTE_SIGA"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\LayoutDispersionBANORTE_SIGA" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReporteDispersionBANORTE(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile

                Case "PolizaSeglo"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\PolizaSeglo" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReportePolizaSeglo(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile

                Case "PolizaSegloProvision"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\PolizaSegloProvision" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReportePolizaSegloProvision(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile

                Case "PolizaSegloReclasificacion"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\PolizaSegloReclasificacion" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReportePolizaSegloReclasificacion(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile

                Case "ReciboNominaTXT"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\ReciboNomina" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReporteReciboNominaTXT(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile


                Case "Reporte_LayoutDispersionBANCOMER_NETCASH108_Historico"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\Reporte_LayoutDispersionBANCOMER_NETCASH108_Historico" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReporteDispersionBANCOMER_NETCASH108_H(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile


                Case "DispersionInterbancario"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\DispersionInterbancario" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReporteDispersionInterbancario(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb, System.Text.Encoding.ASCII)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)

                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile

            End Select
        Catch e As Exception
        End Try
        Return ""
    End Function
    Public Function ReporteDispersionHSBC(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = LayoutDispersionHSBC_ALI
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function

    Public Function ReporteDispersionBANAMEX(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = LayoutDispersionBANAMEXS
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function



    Public Function ReporteDispersionBANORTE(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = LayoutDispersionBANORTE_SIGA
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function

    Public Function ReportePolizaSeglo(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = PolizaSeglo
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function

    Public Function ReportePolizaSegloProvision(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = PolizaSegloProvision
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function

    Public Function ReportePolizaSegloReclasificacion(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = PolizaSegloReclasificacion
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function

    Public Function ReporteReciboNominaTXT(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = ReciboNominaTXT
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function


    Public Function ReporteDispersionBANCOMER_NETCASH108_H(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = Reporte_LayoutDispersionBANCOMER_NETCASH108_Historico
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function

    Public Function ReporteDispersionInterbancario(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = DispersionInterbancario
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function


End Class
