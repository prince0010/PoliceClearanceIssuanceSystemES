
Imports Microsoft.Reporting.WinForms
Imports PoliceClearanceSystemES.PoliceClearanceSystemES
Imports QRCoder
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PrintForm
    'Friend pcc As PoliceClearanceCertificate
    'Private imgsPath_ApplicantPix As String = Directory.GetCurrentDirectory & "\bin\Debug\img_applicantpix\"
    'Private imgsPath_ApplicantFingerprint As String = Directory.GetCurrentDirectory & "\bin\Debug\img_applicantfingerprint\"


    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command

    Friend pcc_id As Integer
    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(pcc_id)
        Try
            ReportViewer1.LocalReport.ReportEmbeddedResource = "PoliceClearanceSystemES.PCC.rdlc"
            ReportViewer1.LocalReport.EnableExternalImages = True
            ReportViewer1.RefreshReport()
            Dim ImageBitmap As Bitmap
            'ImageBitmap = Qrcode(pcc_id.ToString)



            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[place_of_birth],[pcc].[date_of_birth],[pcc].[sex],[pcc].[height],[pcc].[nationality],[pcc].[contact_no],[pcc].[ctc_number],[pcc].[ctc_issued_on],[pcc].[ctc_issued_at],[pcc].[signature],[pcc].[img],[pcc].[thumb],[pcc].[pcc_issue_date],[pcc].[payment_amount],[pcc].[payment_or_number],[zone].[name] As 'zone_name',[barangay].[name] As 'barangay_name',[civil_status].[name] As 'cs_name',[purpose].[name] As 'purpose_name',police_verify.fname As 'police_vfname',police_verify.mname As 'police_vmname',police_verify.lname As 'police_vlname',police_verify_rank.name As 'police_vrank',police_verify_position.name As 'police_vposition',police_verify.police_sig  As 'police_vsig',police_certify.fname As 'police_cfname',police_certify.mname As 'police_cmname',police_certify.lname As 'police_clname',police_certify_rank.name As 'police_crank',police_certify_position.name As 'police_cposition',police_certify.police_sig  As 'police_csig',pcc.cr_id,pcc.findingsRemarks,criminal_records.crime_offense FROM [dbo].[pcc] INNER JOIN [police] police_verify ON [pcc].police_id_verify = police_verify.police_id INNER JOIN [rank] police_verify_rank ON police_verify.rank_id = police_verify_rank.rank_id INNER JOIN [position] police_verify_position ON police_verify.position_id = police_verify_position.position_id INNER JOIN [police] police_certify ON [pcc].police_id_certify = police_certify.police_id INNER JOIN [rank] police_certify_rank ON police_certify.rank_id = police_certify_rank.rank_id INNER JOIN [position] police_certify_position ON police_certify.position_id = police_certify_position.position_id INNER JOIN [zone] ON [pcc].zone_id = [zone].zone_id INNER JOIN [barangay] ON [pcc].barangay_id = [barangay].barangay_id INNER JOIN [civil_status] ON [pcc].cs_id = [civil_status].cs_id INNER JOIN [purpose] ON [pcc].purpose_id = [purpose].purpose_id LEFT JOIN criminal_records ON criminal_records.cr_id = pcc.cr_id WHERE [pcc].[pcc_id] =" & pcc_id
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dt.TableName = "PCC"
            If (dt.Rows.Count > 0) Then
                Dim pccDataSet As New PCCDataSet

                Dim row As PCCDataSet.PCCRow = pccDataSet.PCC.NewPCCRow
                'MsgBox(pcc_id)

                row.pccno = dt.Rows(0).Item("pcc_number")
                row.fullname = dt.Rows(0).Item("fname").ToString.ToUpper + " " + dt.Rows(0).Item("lname").ToString.ToUpper + " y " + dt.Rows(0).Item("mname").ToString.ToUpper
                row.address = dt.Rows(0).Item("zone_name") + ", " + dt.Rows(0).Item("barangay_name")
                row.birthplace = dt.Rows(0).Item("place_of_birth")
                row.birthdate = dt.Rows(0).Item("date_of_birth")
                row.pccdate = dt.Rows(0).Item("pcc_issue_date")
                If dt.Rows(0).Item("sex") = 1 Then
                    row.sex = "MALE"
                ElseIf dt.Rows(0).Item("sex") = 2 Then
                    row.sex = "FEMALE"
                End If
                row.civilstatus = dt.Rows(0).Item("cs_name")
                row.nationality = dt.Rows(0).Item("nationality")
                row.height = dt.Rows(0).Item("height")
                row.contactno = dt.Rows(0).Item("contact_no")
                row.purpose = dt.Rows(0).Item("purpose_name")
                If dt.Rows(0).Item("cr_id") = 0 Then
                    row.findings = dt.Rows(0).Item("findingsRemarks")
                    row.findingsRemarks = ""
                Else
                    row.findings = "CRIME OFFENSE: " + dt.Rows(0).Item("crime_offense")
                    row.findingsRemarks = dt.Rows(0).Item("findingsRemarks")
                End If
                row.ctcno = dt.Rows(0).Item("ctc_number")
                row.ctcdate = dt.Rows(0).Item("ctc_issued_on")
                row.ctcissuedat = dt.Rows(0).Item("ctc_issued_at")
                row.orno = dt.Rows(0).Item("payment_or_number")
                row.amount = dt.Rows(0).Item("payment_amount")
                row.police_vname = dt.Rows(0).Item("police_vfname").ToString.ToUpper + " " + dt.Rows(0).Item("police_vmname").ToString.ToUpper + " " + dt.Rows(0).Item("police_vlname").ToString.ToUpper
                row.police_vrank = dt.Rows(0).Item("police_vrank")
                row.police_vposition = dt.Rows(0).Item("police_vposition")
                row.police_cname = dt.Rows(0).Item("police_cfname").ToString.ToUpper + " " + dt.Rows(0).Item("police_cmname").ToString.ToUpper + " " + dt.Rows(0).Item("police_clname").ToString.ToUpper
                row.police_crank = dt.Rows(0).Item("police_crank")
                row.police_cposition = dt.Rows(0).Item("police_cposition")


                Using qrMS As New MemoryStream()
                    Dim gen As New QRCodeGenerator
                    Dim data = gen.CreateQrCode(dt.Rows(0).Item("pcc_number") + ", " + dt.Rows(0).Item("fname").ToString.ToUpper + " " + dt.Rows(0).Item("mname").ToString.ToUpper + " " + dt.Rows(0).Item("lname").ToString.ToUpper + ", " + dt.Rows(0).Item("pcc_issue_date"), QRCodeGenerator.ECCLevel.Q)
                    Dim code As New QRCode(data)
                    ImageBitmap = code.GetGraphic(10)
                    ImageBitmap.Save(qrMS, ImageFormat.Bmp)
                    row.QrImage = qrMS.ToArray
                    ImageBitmap.Dispose()
                End Using
                Dim applicantImgPath As String = dt.Rows(0).Item("img")
                Dim fingerprintImgPath As String = dt.Rows(0).Item("thumb")
                Dim signatureImgPath As String = dt.Rows(0).Item("signature")
                Dim policeVSigImgPath As String = dt.Rows(0).Item("police_vsig")
                Dim policeCSigImgPath As String = dt.Rows(0).Item("police_csig")

                Using applicantImgStream As New MemoryStream()
                    If applicantImgPath = "" Then
                        Dim bmp As New Bitmap(100, 100)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            ' Fill the entire bitmap with white color
                            g.Clear(Color.White)
                        End Using
                        bmp.Save(applicantImgStream, ImageFormat.Png)
                    Else
                        Dim applicantImg As Image = Image.FromFile(applicantImgPath)
                        applicantImg.Save(applicantImgStream, ImageFormat.Png)
                    End If
                    row.ApplicantImage = applicantImgStream.ToArray
                End Using
                Using fingerprintImgStream As New MemoryStream()
                    If fingerprintImgPath = "" Then
                        Dim bmp As New Bitmap(100, 100)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            ' Fill the entire bitmap with white color
                            g.Clear(Color.White)
                        End Using
                        bmp.Save(fingerprintImgStream, ImageFormat.Png)
                    Else
                        Dim fingerprintImg As Image = Image.FromFile(fingerprintImgPath)
                        fingerprintImg.Save(fingerprintImgStream, ImageFormat.Png)
                    End If
                    row.FingerprintImage = fingerprintImgStream.ToArray
                End Using
                Using signatureImgStream As New MemoryStream()
                    If signatureImgPath = "" Then
                        Dim bmp As New Bitmap(100, 100)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            ' Fill the entire bitmap with white color
                            g.Clear(Color.White)
                        End Using
                        bmp.Save(signatureImgStream, ImageFormat.Png)
                    Else
                        Dim signatureImg As Image = Image.FromFile(signatureImgPath)
                        signatureImg.Save(signatureImgStream, ImageFormat.Png)
                    End If
                    row.SignatureImage = signatureImgStream.ToArray
                End Using
                Using policeVSigImgStream As New MemoryStream()
                    If policeVSigImgPath = "" Then
                        Dim bmp As New Bitmap(100, 100)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            ' Fill the entire bitmap with white color
                            g.Clear(Color.White)
                        End Using
                        bmp.Save(policeVSigImgStream, ImageFormat.Png)
                    Else
                        Dim policeVSigImg As Image = Image.FromFile(policeVSigImgPath)
                        policeVSigImg.Save(policeVSigImgStream, ImageFormat.Png)
                    End If
                    row.PoliceVSignature = policeVSigImgStream.ToArray
                End Using
                Using policeCSigImgStream As New MemoryStream()
                    If policeCSigImgPath = "" Then
                        Dim bmp As New Bitmap(100, 100)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            ' Fill the entire bitmap with white color
                            g.Clear(Color.White)
                        End Using
                        bmp.Save(policeCSigImgStream, ImageFormat.Png)
                    Else
                        Dim policeCSigImg As Image = Image.FromFile(policeCSigImgPath)
                        policeCSigImg.Save(policeCSigImgStream, ImageFormat.Png)
                    End If
                    row.PoliceCSignature = policeCSigImgStream.ToArray
                End Using

                pccDataSet.PCC.AddPCCRow(row)
                Dim reportDataSource As New ReportDataSource
                reportDataSource.Name = "PCCDataSet"
                reportDataSource.Value = pccDataSet.PCC


                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
                ReportViewer1.RefreshReport()

            End If
            connection.Close()
            command = Nothing
        Catch ex As Exception
            MsgBox("Police Clearance Certificate Error - Printing Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try


    End Sub

End Class