Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports PoliceClearanceSystemES.PoliceClearanceSystemES

Public Class ReportForm

    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    'Private command As New SqlCommand("", connection)
    Private command
    Private reportDate As String
    Private totalApplicants As Integer

    Dim now As DateTime = DateTime.Now.Date

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Try
            ReportViewer2.LocalReport.ReportEmbeddedResource = "PoliceClearanceSystemES.GenerateReport.rdlc"
            ReportViewer2.LocalReport.DataSources.Clear()
            ReportViewer2.RefreshReport()

            connection.Open()
            command = New SqlCommand("", connection)
            If ComboBox1.SelectedIndex = 0 Then
                command.CommandText = "SELECT [pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[pcc_issue_date] FROM [dbo].[pcc] WHERE CAST([pcc].[pcc_issue_date] AS DATE) = CAST(GETDATE() AS DATE) AND [pcc].[status] = 'COMPLETED'"
            ElseIf ComboBox1.SelectedIndex = 1 Then
                command.CommandText = "SELECT [pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[pcc_issue_date] FROM [dbo].[pcc] WHERE DATEDIFF(ww, pcc_issue_date, GETDATE()) = 0 AND [pcc].[status] = 'COMPLETED'"
            ElseIf ComboBox1.SelectedIndex = 2 Then
                command.CommandText = "SELECT [pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[pcc_issue_date] FROM [dbo].[pcc] WHERE DATEDIFF(mm, pcc_issue_date, GETDATE()) = 0 AND [pcc].[status] = 'COMPLETED'"
            End If
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dt.TableName = "Report"
            If (dt.Rows.Count > 0) Then

                totalApplicants = dt.Rows.Count

                'MsgBox(totalApplicants)
                Dim reportDataSet As New ReportDataSet
                For Each dtRow As DataRow In dt.Rows
                    ' Create a new row in the TblSample table
                    Dim row As ReportDataSet.ReportDataRow = reportDataSet.ReportData.NewReportDataRow

                    ' Set the values of the row based on the data in the dt datatable
                    row.ccno = dtRow.Item("pcc_number").ToString()
                    row.fullname = dtRow.Item("fname").ToString.ToUpper + " " + dtRow.Item("lname").ToString.ToUpper + " y " + dtRow.Item("mname").ToString.ToUpper
                    row.ccissuedate = dtRow.Item("pcc_issue_date")

                    ' Add the row to the TblSample table
                    reportDataSet.ReportData.AddReportDataRow(row)
                Next
                Dim headerRow As ReportDataSet.ReportHeaderSetRow = reportDataSet.ReportHeaderSet.NewReportHeaderSetRow
                headerRow.reporttype = ComboBox1.SelectedItem.ToString.ToUpper
                headerRow.totalapplicants = totalApplicants
                headerRow.reportdate = now
                reportDataSet.ReportHeaderSet.AddReportHeaderSetRow(headerRow)
                If reportDataSet.Tables.Count > 0 AndAlso reportDataSet.Tables(0).Rows.Count > 0 Then
                    ' Dataset is not empty, it has at least one table and one row
                    ' Do something with the data
                    'MsgBox("NOT! Empty")
                    Dim reportDataSrc As New ReportDataSource
                    reportDataSrc.Name = "ReportDataSet"
                    reportDataSrc.Value = reportDataSet.ReportData
                    Dim reportHeaderSrc As New ReportDataSource
                    reportHeaderSrc.Name = "ReportHeaderSet"
                    reportHeaderSrc.Value = reportDataSet.ReportHeaderSet

                    ReportViewer2.LocalReport.DataSources.Clear()
                    ReportViewer2.LocalReport.DataSources.Add(reportDataSrc)
                    ReportViewer2.LocalReport.DataSources.Add(reportHeaderSrc)
                    ReportViewer2.RefreshReport()
                Else
                    ' Dataset is empty
                    MsgBox("Dataset Empty")
                End If


            End If



            connection.Close()
            command = Nothing
        Catch ex As Exception
            'connection.Close()
            'command = Nothing
            MsgBox("Generate Report Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0

    End Sub


End Class