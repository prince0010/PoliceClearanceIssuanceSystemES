Imports System.Data.SqlClient
Imports System.IO
Imports TableDependency.SqlClient.Base
Imports TableDependency.SqlClient.Base.Enums
Imports TableDependency.SqlClient
Imports System.Net
Imports System.Reflection
Imports System.Drawing.Imaging
Imports MaterialSkin2Framework.Controls

Public Class Clerk2
    Friend user_id As Integer


    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    'Private command As New SqlCommand("", connection)
    Private command
    Private imgsPath_ApplicantPix As String = (New ConfigHelper).GetApplicantPictureImgPath
    Private imgsPath_ApplicantFingerprint As String = (New ConfigHelper).GetApplicantFingerprintImgPath
    Private imgsPath_ApplicantSig As String = (New ConfigHelper).GetApplicantSignatureImgPath

    'Values for Biological Sex
    Private male As Integer = 1
    Private female As Integer = 2
    Private bSex As Integer

    Private status_pending As String = "PENDING"
    Private status_paid As String = "PAID"
    Private status_validated As String = "VALIDATED"
    Private status_completed As String = "COMPLETED"

    Dim findingsRemarksDefault As String = "No Criminal/Derogatory Record on file as of this Date!"

    Dim now As DateTime = DateTime.Now
    Dim fileNameDefault As String = String.Format("image_{0:yyyyMMdd_HHmmss}.png", now)

    Dim bitmap_applicant_default
    Dim bitmap_fingerprint_default
    Dim bitmap_signature_default

    Dim signatureFileName As String = ""
    Dim applicantFileName As String = ""
    Dim fingerprintFileName As String = ""

    Private PccIDToEdit As Integer
    Dim pccDependencyPending As SqlTableDependency(Of PoliceClearanceCertificate)
    'Dim pccDependencyComplete As SqlTableDependency(Of PoliceClearanceCertificate)

    Private Sub AddButton_Click(sender As Object, e As System.EventArgs) Handles btnAdd_Saved.Click
        If txtClearanceNo.Text = "" Then
            'MsgBox("Insert/Update Police Clearance error: Fill Clearance Number to Insert/Update Police Clearance")
            MaterialMessageBox.Show("Fill Clearance Number to Insert/Update Applicant", "Insert/Update Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        Else
            If PccIDToEdit <> Nothing Then

                'Insert UPDATE data codes Here
                Try
                    connection.Open()
                    'UPDATE police SET fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, police_sig = @policesig, rank_id = @rankid, position_id = @positionid WHERE police_id =" & police_id
                    command = New SqlCommand("", connection)
                    command.CommandText = "UPDATE dbo.[pcc] SET [fname] = @fname, [mname] = @mname, [lname] = @lname, [zone_id] = @zone_id,[barangay_id] = @barangay_id,[cs_id] = @cs_id,[place_of_birth] = @place_of_birth,[date_of_birth] = @date_of_birth,[sex] = @sex,[height] = @height,[nationality] = @nationality,[contact_no] = @contact_no,[purpose_id] = @purpose_id,[ctc_number] = @ctc_number,[ctc_issued_on] = @ctc_issued_on,[ctc_issued_at] = @ctc_issued_at,[signature] = @signature,[img] = @img,[thumb] = @thumb,[pcc_number] = @pcc_number,[pcc_issue_date] = @pcc_issue_date,[police_id_verify] = @police_id_verify,[police_id_certify] = @police_id_certify,[payment_or_number] = @payment_or_number,[payment_amount] = @payment_amount WHERE [pcc_id] = " & PccIDToEdit
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@pcc_number", txtClearanceNo.Text.Trim)
                    command.Parameters.AddWithValue("@pcc_issue_date", dtClearanceDate.Value.Date)
                    command.Parameters.AddWithValue("@fname", txtClearanceFname.Text.Trim)
                    command.Parameters.AddWithValue("@mname", txtClearanceMname.Text.Trim)
                    command.Parameters.AddWithValue("@lname", txtClearanceLname.Text.Trim)
                    command.Parameters.AddWithValue("@barangay_id", cbBarangay.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@zone_id", cbZone.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@cs_id", cbCivilStatus.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@place_of_birth", txtBirthPlace.Text.Trim)
                    command.Parameters.AddWithValue("@date_of_birth", dtBirthDate.Value.Date)
                    If rbMale.Checked = True Then
                        bSex = male
                    ElseIf rbFemale.Checked = True Then
                        bSex = female
                    Else
                        bSex = 0
                    End If
                    command.Parameters.AddWithValue("@sex", bSex)
                    command.Parameters.AddWithValue("@height", txtHeight.Text.Trim)
                    command.Parameters.AddWithValue("@nationality", txtNationality.Text.Trim)
                    command.Parameters.AddWithValue("@contact_no", txtContactNo.Text.Trim)
                    command.Parameters.AddWithValue("@purpose_id", cbPurpose.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@ctc_number", txtCTCNo.Text.Trim)
                    command.Parameters.AddWithValue("@ctc_issued_on", dtCTCIssueDate.Value.Date)
                    command.Parameters.AddWithValue("@ctc_issued_at", txtCTCIssueAt.Text.Trim)

                    If signatureFileName <> "" Then
                        PictureBox3.Image.Save(signatureFileName, ImageFormat.Png)
                    End If
                    If applicantFileName <> "" Then
                        PictureBox1.Image.Save(applicantFileName, ImageFormat.Png)
                    End If
                    If fingerprintFileName <> "" Then
                        PictureBox2.Image.Save(fingerprintFileName, ImageFormat.Png)
                    End If
                    command.Parameters.AddWithValue("@signature", signatureFileName)
                    command.Parameters.AddWithValue("@img", applicantFileName)
                    command.Parameters.AddWithValue("@thumb", fingerprintFileName)

                    command.Parameters.AddWithValue("@police_id_verify", cbPoliceVerify.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@police_id_certify", cbPoliceCertify.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@payment_or_number", txtORNo.Text.Trim)
                    command.Parameters.AddWithValue("@payment_amount", txtORAmount.Text.Trim)

                    command.Parameters.AddWithValue("@user_id", user_id)
                    command.ExecuteNonQuery()
                    connection.Close()
                    command = Nothing
                Catch ex As Exception
                    connection.Close()
                    MsgBox("Update Police Clearance error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                End Try

                PccIDToEdit = Nothing
                btnAdd_Saved.Text = "Add"
                btnClear_Cancel.Text = "Clear"
                Clear()
            Else
                Try
                    'SqlData()
                    connection.Open()
                    command = New SqlCommand("", connection)
                    'command.CommandText = "INSERT INTO dbo.[police_clearance_certificate]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_OR_number], [payment_amount],[user_id],[qrcode],[payment_confirmed_user],[payment_confirmed_date]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,@purpose_id,@ctc_number,@ctc_issued_on,@ctc_issued_at,'signature','img','thumb',@pcc_number,@pcc_issue_date,@police_id_verify,@police_id_certify,@payment_OR_number, @payment_amount, " & user_id & ",'qrcode',1," & DateTime.Now.ToString("yyyy/MM/dd") & ")"
                    command.CommandText = "INSERT INTO dbo.[pcc]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_or_number],[payment_amount],[user_id]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,@purpose_id,@ctc_number,@ctc_issued_on,@ctc_issued_at,@signature,@img,@thumb,@pcc_number,@pcc_issue_date,@police_id_verify,@police_id_certify,@payment_or_number, @payment_amount,@user_id)"
                    'command.CommandText = "INSERT INTO dbo.[pcc]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_or_number],[payment_amount],[user_id]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,@purpose_id,@ctc_number,@ctc_issued_on,@ctc_issued_at,@pcc_number,@pcc_issue_date,@police_id_verify,@police_id_certify,@payment_or_number,@payment_amount,@user_id)"
                    'command.CommandText = "INSERT INTO dbo.[pcc]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_or_number],[payment_amount],[user_id]) VALUES('Wow','Wow','Wow',1,1,1,'Wow','2023-04-04',1,'123','123','123',1,'123','2023-04-04','123','','','','123','2023-04-04',1,1,'123', 123,1)"
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@pcc_number", txtClearanceNo.Text.Trim)
                    command.Parameters.AddWithValue("@pcc_issue_date", dtClearanceDate.Value.Date)
                    command.Parameters.AddWithValue("@fname", txtClearanceFname.Text.Trim)
                    command.Parameters.AddWithValue("@mname", txtClearanceMname.Text.Trim)
                    command.Parameters.AddWithValue("@lname", txtClearanceLname.Text.Trim)
                    command.Parameters.AddWithValue("@barangay_id", cbBarangay.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@zone_id", cbZone.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@cs_id", cbCivilStatus.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@place_of_birth", txtBirthPlace.Text.Trim)
                    command.Parameters.AddWithValue("@date_of_birth", dtBirthDate.Value.Date)
                    If rbMale.Checked = True Then
                        bSex = male
                    ElseIf rbFemale.Checked = True Then
                        bSex = female
                    Else
                        bSex = 0
                    End If
                    command.Parameters.AddWithValue("@sex", bSex)
                    command.Parameters.AddWithValue("@height", txtHeight.Text.Trim)
                    command.Parameters.AddWithValue("@nationality", txtNationality.Text.Trim)
                    command.Parameters.AddWithValue("@contact_no", txtContactNo.Text.Trim)
                    command.Parameters.AddWithValue("@purpose_id", cbPurpose.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@ctc_number", txtCTCNo.Text.Trim)
                    command.Parameters.AddWithValue("@ctc_issued_on", dtCTCIssueDate.Value.Date)
                    command.Parameters.AddWithValue("@ctc_issued_at", txtCTCIssueAt.Text.Trim)


                    If signatureFileName <> "" Then
                        PictureBox3.Image.Save(signatureFileName, ImageFormat.Png)
                    End If
                    If applicantFileName <> "" Then
                        PictureBox1.Image.Save(applicantFileName, ImageFormat.Png)
                    End If
                    If fingerprintFileName <> "" Then
                        PictureBox2.Image.Save(fingerprintFileName, ImageFormat.Png)
                    End If
                    command.Parameters.AddWithValue("@signature", signatureFileName)
                    command.Parameters.AddWithValue("@img", applicantFileName)
                    command.Parameters.AddWithValue("@thumb", fingerprintFileName)

                    command.Parameters.AddWithValue("@police_id_verify", cbPoliceVerify.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@police_id_certify", cbPoliceCertify.SelectedValue.ToString)
                    command.Parameters.AddWithValue("@payment_or_number", txtORNo.Text.Trim)
                    command.Parameters.AddWithValue("@payment_amount", txtORAmount.Text.Trim)

                    command.Parameters.AddWithValue("@user_id", user_id)
                    command.ExecuteNonQuery()
                    connection.Close()
                    command = Nothing
                    'File.Copy(imgFileToUpload, fileSavePath, True)

                Catch ex As Exception
                    connection.Close()
                    MsgBox("Insert Police Clearance error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                End Try
                Clear()
            End If
        End If

    End Sub

    Private Sub PopulateCombobox()
        PopulateComboboxZone()
        PopulateComboboxBarangay()
        PopulateComboboxCivilStatus()
        PopulateComboboxPurpose()
        PopulateComboboxVerifiedBy()
        PopulateComboboxCertifiedBy()

    End Sub

    Private Sub Clear()
        txtClearanceFname.Text = ""
        txtClearanceMname.Text = ""
        txtClearanceLname.Text = ""
        cbZone.SelectedIndex = 0
        cbBarangay.SelectedIndex = 0
        cbCivilStatus.SelectedIndex = 0
        txtBirthPlace.Text = ""
        dtBirthDate.Value = now
        rbMale.Checked = True
        txtHeight.Text = ""
        txtNationality.Text = ""
        txtContactNo.Text = ""
        'cbPurpose.SelectedIndex = 0
        txtCTCNo.Text = ""
        dtCTCIssueDate.Value = now
        txtCTCIssueAt.Text = ""
        'Insert Codes to Call Image Here([signature],[img],[thumb])
        Dim imageCamera As Image = PictureBox1.Image
        PictureBox1.Image = Nothing
        If imageCamera IsNot Nothing Then
            imageCamera.Dispose()
        End If
        Dim imageFingerprint As Image = PictureBox2.Image
        PictureBox2.Image = Nothing
        If imageFingerprint IsNot Nothing Then
            imageFingerprint.Dispose()
        End If
        Dim imageSignature As Image = PictureBox3.Image
        PictureBox3.Image = Nothing
        If imageSignature IsNot Nothing Then
            imageSignature.Dispose()
        End If
        LoadDefaultImages()

        signatureFileName = ""
        applicantFileName = ""
        fingerprintFileName = ""

        txtClearanceNo.Text = ""
        dtClearanceDate.Value = DateTime.Now
        'cbPoliceVerify.SelectedIndex = 0
        'cbPoliceCertify.SelectedIndex = 0
        txtORNo.Text = ""
        txtORAmount.Text = ""
    End Sub
    Private Sub PopulateComboboxZone()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT zone_id AS 'ZONE ID', name AS 'ZONE NAME' FROM zone"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbZone.DisplayMember = dt.Columns("ZONE NAME").ToString
            cbZone.ValueMember = dt.Columns("ZONE ID").ToString
            cbZone.DataSource = dt
            connection.Close()
            command = Nothing

        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Zone error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxBarangay()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT barangay_id AS 'BARANGAY ID', name AS 'BARANGAY NAME' FROM barangay"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbBarangay.DisplayMember = dt.Columns("BARANGAY NAME").ToString
            cbBarangay.ValueMember = dt.Columns("BARANGAY ID").ToString
            cbBarangay.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Barangay error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxCivilStatus()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT cs_id AS 'CIVILSTATUS ID', name AS 'CIVILSTATUS NAME' FROM civil_status"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbCivilStatus.DisplayMember = dt.Columns("CIVILSTATUS NAME").ToString
            cbCivilStatus.ValueMember = dt.Columns("CIVILSTATUS ID").ToString
            cbCivilStatus.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Civil Status error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxPurpose()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT purpose_id AS 'PURPOSE ID', name AS 'PURPOSE NAME' FROM purpose"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbPurpose.DisplayMember = dt.Columns("PURPOSE NAME").ToString
            cbPurpose.ValueMember = dt.Columns("PURPOSE ID").ToString
            cbPurpose.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Purpose error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxVerifiedBy()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT police_id AS 'POLICE ID', CONCAT(fname,' ',mname,' ',lname) AS 'POLICE NAME' FROM police"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbPoliceVerify.DisplayMember = dt.Columns("POLICE NAME").ToString
            cbPoliceVerify.ValueMember = dt.Columns("POLICE ID").ToString
            cbPoliceVerify.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police - Verified By error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxCertifiedBy()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT police_id AS 'POLICE ID', CONCAT(fname,' ',mname,' ',lname) AS 'POLICE NAME' FROM police"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbPoliceCertify.DisplayMember = dt.Columns("POLICE NAME").ToString
            cbPoliceCertify.ValueMember = dt.Columns("POLICE ID").ToString
            cbPoliceCertify.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police  - Certified By error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub LoadPCCPending(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc] WHERE [pcc].[status] <> 'COMPLETED' AND CONVERT(date, created_at) = CONVERT(date, Getdate()) ORDER BY updated_at DESC"
            Else
                command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc] WHERE (pcc.fname LIKE @searchString OR pcc.mname LIKE @searchString OR pcc.lname LIKE @searchString OR pcc.pcc_number LIKE @searchString) AND [pcc].[status] <> 'COMPLETED' AND CONVERT(date, created_at) = CONVERT(date, Getdate()) ORDER BY updated_at DESC"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If


            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dataApplicantPending.AutoGenerateColumns = False
            'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
            'If DataProperty is not set Data Wont display in that specific Column
            dataApplicantPending.Columns("dataPendingClearanceID").DataPropertyName = "pcc_id"
            dataApplicantPending.Columns("dataPendingClearanceNo").DataPropertyName = "pcc_number"
            dataApplicantPending.Columns("dataPendingClearanceFname").DataPropertyName = "fname"
            dataApplicantPending.Columns("dataPendingClearanceMname").DataPropertyName = "mname"
            dataApplicantPending.Columns("dataPendingClearanceLname").DataPropertyName = "lname"
            dataApplicantPending.Columns("dataPendingClearanceStatus").DataPropertyName = "status"
            dataApplicantPending.Columns("dataPendingClearanceID").Visible = False
            dataApplicantPending.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police Clearance Certificate - Pending Data Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub LoadPCCCompleted(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc] WHERE [pcc].[status] = 'COMPLETED' AND CONVERT(date, created_at) = CONVERT(date, Getdate()) ORDER BY updated_at DESC"
            Else
                command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc] WHERE (pcc.fname LIKE @searchString OR pcc.mname LIKE @searchString OR pcc.lname LIKE @searchString OR pcc.pcc_number LIKE @searchString) AND [pcc].[status] = 'COMPLETED' AND CONVERT(date, created_at) = CONVERT(date, Getdate()) ORDER BY updated_at DESC"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If

            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dataApplicantCompleted.AutoGenerateColumns = False
            'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
            'If DataProperty is not set Data Wont display in that specific Column
            dataApplicantCompleted.Columns("dataCompletedClearanceID").DataPropertyName = "pcc_id"
            dataApplicantCompleted.Columns("dataCompletedClearanceNo").DataPropertyName = "pcc_number"
            dataApplicantCompleted.Columns("dataCompletedClearanceFname").DataPropertyName = "fname"
            dataApplicantCompleted.Columns("dataCompletedClearanceMname").DataPropertyName = "mname"
            dataApplicantCompleted.Columns("dataCompletedClearanceLname").DataPropertyName = "lname"
            dataApplicantCompleted.Columns("dataCompletedClearanceStatus").DataPropertyName = "status"
            dataApplicantCompleted.Columns("dataCompletedClearanceID").Visible = False
            dataApplicantCompleted.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police Clearance Certificate - Completed Data Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub Clerk2_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        'If user_id Then
        '    MsgBox("UserID:" & user_id)
        'End If
        rbMale.Checked = True

        If Not Directory.Exists(imgsPath_ApplicantPix) Then
            Directory.CreateDirectory(imgsPath_ApplicantPix)
            Console.WriteLine("Images Path for Applicant Pictures Created")
        End If
        If Not Directory.Exists(imgsPath_ApplicantFingerprint) Then
            Directory.CreateDirectory(imgsPath_ApplicantFingerprint)
            Console.WriteLine("Images Path for Applicant Fingerprint Created")
        End If
        If Not Directory.Exists(imgsPath_ApplicantSig) Then
            Directory.CreateDirectory(imgsPath_ApplicantSig)
            Console.WriteLine("Images Path for Applicant Signature Created")
        End If

        LoadDefaultImages()
        'Dim names As String() = Me.GetType().Assembly.GetManifestResourceNames()
        'For Each name As String In names
        '    'Console.WriteLine(name)
        '    MsgBox(name)
        'Next

        'Populating ComboBoxes
        PopulateCombobox()

        'Populate DataGrid
        LoadPCCPending()
        LoadPCCCompleted()


        Dim pccDependencyMapper = New TableDependency.SqlClient.Base.ModelToTableMapper(Of PoliceClearanceCertificate)()
        pccDependencyMapper.AddMapping(Function(c) c.PccNo, "pcc_number").AddMapping(Function(c) c.Fname, "fname").AddMapping(Function(c) c.Mname, "mname").AddMapping(Function(c) c.Lname, "lname").AddMapping(Function(c) c.Status, "status")
        pccDependencyPending = New SqlTableDependency(Of PoliceClearanceCertificate)(connString, "pcc", "dbo", pccDependencyMapper)

        AddHandler pccDependencyPending.OnChanged, AddressOf OnPccDependencyPendingChanged

        pccDependencyPending.Start()


        'Dim pccDependencyMapper2 = New TableDependency.SqlClient.Base.ModelToTableMapper(Of PoliceClearanceCertificate)()
        'pccDependencyMapper2.AddMapping(Function(c) c.PccNo, "pcc_number").AddMapping(Function(c) c.Fname, "fname").AddMapping(Function(c) c.Mname, "mname").AddMapping(Function(c) c.Lname, "lname").AddMapping(Function(c) c.Status, "status")
        'pccDependencyComplete = New SqlTableDependency(Of PoliceClearanceCertificate)(connString, "pcc", "dbo", pccDependencyMapper2)

        'AddHandler pccDependencyComplete.OnChanged, AddressOf OnPccDependencyPendingChanged

        'pccDependencyPending.Start()
    End Sub

    Private Sub LoadDefaultImages()
        Dim applicant_stream As Stream = Me.GetType().Assembly.GetManifestResourceStream("PoliceClearanceSystemES.default-applicant.png")
        If applicant_stream IsNot Nothing Then
            bitmap_applicant_default = New Bitmap(applicant_stream)
            PictureBox1.Image = bitmap_applicant_default
        End If

        Dim fingerprint_stream As Stream = Me.GetType().Assembly.GetManifestResourceStream("PoliceClearanceSystemES.default-fingerprint.png")
        If fingerprint_stream IsNot Nothing Then
            bitmap_fingerprint_default = New Bitmap(fingerprint_stream)
            PictureBox2.Image = bitmap_fingerprint_default
        End If
        Dim signature_stream As Stream = Me.GetType().Assembly.GetManifestResourceStream("PoliceClearanceSystemES.default-signature.png")
        If signature_stream IsNot Nothing Then
            bitmap_signature_default = New Bitmap(signature_stream)
            PictureBox3.Image = bitmap_signature_default
        End If
    End Sub

    Delegate Sub UpdatePccDependencyComplete()
    'Private Sub OnPccDependencyCompleteChanged(ByVal sender As Object, ByVal e As TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs(Of PoliceClearanceCertificate))
    '    'MsgBox("Updated:" + e.ChangeType)

    '    If e.ChangeType <> TableDependency.SqlClient.Base.Enums.ChangeType.None Then
    '        Dim changedEntity = e.Entity
    '        Console.WriteLine("DML operation: " & e.ChangeType.ToString())
    '        Console.WriteLine("value: " & changedEntity.Fname)
    '        Dim reloadPccPendingData As UpdatePccDependencyPending = New UpdatePccDependencyPending(AddressOf LoadPCCPending)
    '        Me.Invoke(reloadPccPendingData, Nothing)

    '    End If
    'End Sub

    Delegate Sub UpdatePccDependencyPending()
    Private Sub OnPccDependencyPendingChanged(ByVal sender As Object, ByVal e As TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs(Of PoliceClearanceCertificate))
        'MsgBox("Updated:" + e.ChangeType)

        If e.ChangeType <> TableDependency.SqlClient.Base.Enums.ChangeType.None Then
            Dim reloadPccPendingData As UpdatePccDependencyPending = New UpdatePccDependencyPending(AddressOf LoadPCCPending)
            Me.Invoke(reloadPccPendingData, Nothing)
            Dim reloadPccCompleteData As UpdatePccDependencyComplete = New UpdatePccDependencyComplete(AddressOf LoadPCCCompleted)
            Me.Invoke(reloadPccCompleteData, Nothing)
            txtApplicantPendingSearch.Text = ""
            txtApplicantCompletedSearch.Text = ""
        End If
    End Sub
    'Camera
    Private Sub MaterialButton1_Click(sender As Object, e As System.EventArgs) Handles MaterialButton1.Click
        Dim cameraForm As New CameraForm
        If cameraForm.ShowDialog() = DialogResult.OK Then
            ' the OK button was clicked
            ' process the data entered on the form here
            PictureBox1.Image = cameraForm.CameraImg
            PictureBox1.Image.Tag = fileNameDefault
            applicantFileName = imgsPath_ApplicantPix + PictureBox1.Image.Tag
            'Else
            ' the Cancel button was clicked or the form was closed without clicking any button
        End If

    End Sub

    'Fingerprint
    Private Sub MaterialButton2_Click(sender As Object, e As System.EventArgs) Handles MaterialButton2.Click
        Dim fingerprintForm As New FingerprintForm
        If fingerprintForm.ShowDialog() = DialogResult.OK Then
            PictureBox2.Image = fingerprintForm.Fingerprint
            PictureBox2.Image.Tag = fileNameDefault
            fingerprintFileName = imgsPath_ApplicantFingerprint + PictureBox2.Image.Tag
        End If
    End Sub
    'Signature
    Private Sub MaterialButton3_Click(sender As Object, e As System.EventArgs) Handles MaterialButton3.Click
        Dim signatureForm As New SignatureForm
        If signatureForm.ShowDialog() = DialogResult.OK Then
            PictureBox3.Image = signatureForm.Singature
            PictureBox3.Image.Tag = fileNameDefault
            signatureFileName = imgsPath_ApplicantSig + PictureBox3.Image.Tag
        End If
    End Sub

    Private Sub dataApplicantPending_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dataApplicantPending.RowsAdded
        For index As Integer = e.RowIndex To e.RowIndex + e.RowCount - 1
            Dim row As DataGridViewRow = dataApplicantPending.Rows(index)
            Dim status As String = row.Cells("dataPendingClearanceStatus").Value.ToString.Trim.ToUpper
            If status = status_pending Or status = status_paid Then
                row.Cells("dataPendingClearanceSetBtn").Value = "Validate"
            ElseIf status = status_validated Then
                row.Cells("dataPendingClearanceSetBtn").Value = "Print"
            End If
        Next
    End Sub

    Private Sub Clerk2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pccDependencyPending.Stop()
        pccDependencyPending.Dispose()
    End Sub

    Private Sub dataApplicantPending_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataApplicantPending.CellContentClick
        Dim colname As String = dataApplicantPending.Columns(e.ColumnIndex).Name
        If colname = "dataPendingClearanceEdit" Then
            Try
                Dim row As DataGridViewRow = dataApplicantPending.Rows(e.RowIndex)
                Dim pcc_id As Integer = row.Cells("dataPendingClearanceID").Value
                Dim result As DialogResult = MaterialMessageBox.Show("Confirm Edit?", "Edit Applicant",
                                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, False)
                If (result = DialogResult.Yes) Then
                    PccIDToEdit = pcc_id
                    If PccIDToEdit <> Nothing Then
                        btnAdd_Saved.Text = "Save"
                        btnClear_Cancel.Text = "Cancel"
                    End If
                    connection.Open()
                    command = New SqlCommand("", connection)
                    command.CommandText = "SELECT [pcc_id],[fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_OR_number],[payment_amount] FROM [pcc] WHERE [pcc_id] = " & pcc_id
                    Dim da As New SqlDataAdapter(command)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    If (dt.Rows.Count > 0) Then

                        txtClearanceFname.Text = dt.Rows(0).Item("fname")
                        txtClearanceMname.Text = dt.Rows(0).Item("mname")
                        txtClearanceLname.Text = dt.Rows(0).Item("lname")
                        cbZone.SelectedValue = dt.Rows(0).Item("zone_id")
                        cbBarangay.SelectedValue = dt.Rows(0).Item("barangay_id")
                        cbCivilStatus.SelectedValue = dt.Rows(0).Item("cs_id")
                        txtBirthPlace.Text = dt.Rows(0).Item("place_of_birth")
                        dtBirthDate.Value = dt.Rows(0).Item("date_of_birth")
                        If dt.Rows(0).Item("sex") = male Then
                            rbMale.Checked = True
                            rbFemale.Checked = False
                        ElseIf dt.Rows(0).Item("sex") = female Then
                            rbFemale.Checked = True
                            rbMale.Checked = False
                        Else
                            rbFemale.Checked = False
                            rbMale.Checked = False
                        End If
                        txtHeight.Text = dt.Rows(0).Item("height")
                        txtNationality.Text = dt.Rows(0).Item("nationality")
                        txtContactNo.Text = dt.Rows(0).Item("contact_no")
                        cbPurpose.SelectedValue = dt.Rows(0).Item("purpose_id")
                        txtCTCNo.Text = dt.Rows(0).Item("ctc_number")
                        dtCTCIssueDate.Value = dt.Rows(0).Item("ctc_issued_on")
                        txtCTCIssueAt.Text = dt.Rows(0).Item("ctc_issued_at")
                        'Insert Codes to Call Image Here([signature],[img],[thumb])
                        If dt.Rows(0).Item("signature") = "" Then
                            Dim imageSignature As Image = PictureBox3.Image
                            PictureBox3.Image = Nothing
                            If imageSignature IsNot Nothing Then
                                imageSignature.Dispose()
                            End If
                            Dim signature_stream As Stream = Me.GetType().Assembly.GetManifestResourceStream("PoliceClearanceSystemES.default-signature.png")
                            If signature_stream IsNot Nothing Then
                                bitmap_signature_default = New Bitmap(signature_stream)
                                PictureBox3.Image = bitmap_signature_default
                            End If
                        Else
                            If System.IO.File.Exists(dt.Rows(0).Item("signature")) Then
                                Using fs As New FileStream(dt.Rows(0).Item("signature"), FileMode.Open, FileAccess.Read)
                                    PictureBox3.Image = Image.FromStream(fs)
                                    signatureFileName = dt.Rows(0).Item("signature")
                                End Using
                            Else
                                MsgBox("Police Clearance Pending Table - Signature Image not found:")
                            End If
                        End If
                        If dt.Rows(0).Item("img") = "" Then
                            Dim imageCamera As Image = PictureBox1.Image
                            PictureBox1.Image = Nothing
                            If imageCamera IsNot Nothing Then
                                imageCamera.Dispose()
                            End If
                            Dim applicant_stream As Stream = Me.GetType().Assembly.GetManifestResourceStream("PoliceClearanceSystemES.default-applicant.png")
                            If applicant_stream IsNot Nothing Then
                                bitmap_applicant_default = New Bitmap(applicant_stream)
                                PictureBox1.Image = bitmap_applicant_default
                            End If
                        Else
                            If System.IO.File.Exists(dt.Rows(0).Item("img")) Then
                                Using fs As New FileStream(dt.Rows(0).Item("img"), FileMode.Open, FileAccess.Read)
                                    PictureBox1.Image = Image.FromStream(fs)
                                    applicantFileName = dt.Rows(0).Item("img")
                                End Using
                            Else
                                MsgBox("Police Clearance Pending Table - Applicant Image not found:")
                            End If
                        End If
                        If dt.Rows(0).Item("thumb") = "" Then
                            Dim imageFingerprint As Image = PictureBox2.Image
                            PictureBox2.Image = Nothing
                            If imageFingerprint IsNot Nothing Then
                                imageFingerprint.Dispose()
                            End If
                            Dim fingerprint_stream As Stream = Me.GetType().Assembly.GetManifestResourceStream("PoliceClearanceSystemES.default-fingerprint.png")
                            If fingerprint_stream IsNot Nothing Then
                                bitmap_fingerprint_default = New Bitmap(fingerprint_stream)
                                PictureBox2.Image = bitmap_fingerprint_default
                            End If
                        Else
                            If System.IO.File.Exists(dt.Rows(0).Item("thumb")) Then
                                Using fs As New FileStream(dt.Rows(0).Item("thumb"), FileMode.Open, FileAccess.Read)
                                    PictureBox2.Image = Image.FromStream(fs)
                                    fingerprintFileName = dt.Rows(0).Item("thumb")
                                End Using
                            Else
                                MsgBox("Police Clearance Pending Table - Fingerprint Image not found:")
                            End If
                        End If
                        ',[pcc_number],[pcc_issue_date]
                        txtClearanceNo.Text = dt.Rows(0).Item("pcc_number")
                        dtClearanceDate.Value = dt.Rows(0).Item("pcc_issue_date")
                        cbPoliceVerify.SelectedValue = dt.Rows(0).Item("police_id_verify")
                        cbPoliceCertify.SelectedValue = dt.Rows(0).Item("police_id_certify")
                        txtORNo.Text = dt.Rows(0).Item("payment_OR_number")
                        txtORAmount.Text = dt.Rows(0).Item("payment_amount")
                    End If
                    connection.Close()
                    command = Nothing
                End If
            Catch ex As Exception
                MsgBox("Police Clearance Pending Table - Edit Button error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        ElseIf colname = "dataPendingClearanceDelete" Then
            Try
                Dim row As DataGridViewRow = dataApplicantPending.Rows(e.RowIndex)
                Dim pcc_to_delete As Integer = row.Cells("dataPendingClearanceID").Value
                Dim result As DialogResult = MaterialMessageBox.Show("Confirm Delete?",
                                                                     "Delete Applicant",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, False)
                If result = DialogResult.Yes Then
                    quickSqlCommand("DELETE FROM dbo.[pcc] WHERE [pcc_id] =" & pcc_to_delete)
                End If
            Catch ex As Exception
                MsgBox("Police Clearance Pending Table - Delete Button error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try

        ElseIf colname = "dataPendingClearanceSetBtn" Then
            Try
                Dim row As DataGridViewRow = dataApplicantPending.Rows(e.RowIndex)
                Dim status As String = row.Cells("dataPendingClearanceStatus").Value.ToString.Trim.ToUpper
                If status = status_pending Then
                    MaterialMessageBox.Show("Can't Validate Applicant Until Applicant's Payment is Confirmed By the Cashier!", "Validate Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
                ElseIf status = status_paid Then
                    'Search for Hit in Criminal Records Here
                    Try
                        connection.Open()
                        '[pcc].[fname] LIKE @searchString OR [pcc].[mname] LIKE @searchString OR [pcc].[lname] LIKE @searchString
                        command = New SqlCommand("", connection)
                        command.CommandText = "SELECT COUNT(*) FROM [dbo].[criminal_records] WHERE (fname LIKE @fname OR mname LIKE @mname OR lname LIKE @lname) AND deleted = 0"
                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("@fname", "%" & row.Cells("dataPendingClearanceFname").Value.ToString.Trim & "%")
                        command.Parameters.AddWithValue("@mname", "%" & row.Cells("dataPendingClearanceMname").Value.ToString.Trim & "%")
                        command.Parameters.AddWithValue("@lname", "%" & row.Cells("dataPendingClearanceLname").Value.ToString.Trim & "%")
                        Dim da As New SqlDataAdapter(command)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        connection.Close()
                        command = Nothing
                        Dim hit_record As Integer
                        If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                            hit_record = Convert.ToInt32(dt.Rows(0)(0))
                        End If
                        If (hit_record > 0) Then
                            Dim hitForm As New Validation_Hit
                            hitForm.Label2.Text = hit_record
                            If hitForm.ShowDialog() = DialogResult.OK Then
                                hitForm.Dispose()
                                'Codes for Hit commands Here
                                Dim forceValidationForm As New Validation_ForceValidation
                                forceValidationForm.lblNumberRecords.Text = hit_record
                                forceValidationForm.pcc_id = row.Cells("dataPendingClearanceID").Value
                                forceValidationForm.Fname = row.Cells("dataPendingClearanceFname").Value.ToString.Trim
                                forceValidationForm.Mname = row.Cells("dataPendingClearanceMname").Value.ToString.Trim
                                forceValidationForm.Lname = row.Cells("dataPendingClearanceLname").Value.ToString.Trim
                                forceValidationForm.ShowDialog()
                                'If forceValidationForm.ShowDialog() = DialogResult.OK Then

                                'End If
                            End If
                        Else
                            Dim NoHitForm As New Validation_NoHit
                            If NoHitForm.ShowDialog() = DialogResult.OK Then
                                connection.Open()
                                command = New SqlCommand("", connection)
                                command.CommandText = "UPDATE dbo.[pcc] SET [pcc].[status] = 'VALIDATED', [pcc].[findingsRemarks] = @findingsremarks WHERE [pcc].[pcc_id] = @pcc_id"
                                command.Parameters.Clear()
                                command.Parameters.AddWithValue("@pcc_id", row.Cells("dataPendingClearanceID").Value)
                                command.Parameters.AddWithValue("@findingsremarks", findingsRemarksDefault)
                                command.ExecuteNonQuery()
                                command = Nothing
                                connection.Close()
                            End If
                        End If

                    Catch ex As Exception
                        MsgBox("Police Clearance Pending Table - Validation error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                    End Try
                ElseIf status = status_validated Then
                    'Print Function Here
                    Dim result As DialogResult = MaterialMessageBox.Show("Confirm Print?",
                              "Print Certificate",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, False)
                    If result = DialogResult.Yes Then
                        Try
                            connection.Open()
                            command = New SqlCommand("", connection)
                            command.CommandText = "UPDATE dbo.[pcc] SET [pcc].[status] = 'COMPLETED' WHERE [pcc].[pcc_id] = @pcc_id"
                            command.Parameters.Clear()
                            command.Parameters.AddWithValue("@pcc_id", row.Cells("dataPendingClearanceID").Value)
                            command.ExecuteNonQuery()
                            command = Nothing
                            connection.Close()
                            Dim printForm As New PrintForm
                            printForm.pcc_id = row.Cells("dataPendingClearanceID").Value
                            printForm.ShowDialog()
                        Catch ex As Exception
                            MsgBox("Police Clearance Pending Table - Print error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                        End Try
                    End If
                End If
            Catch ex As Exception
                MsgBox("Police Clearance Pending Table - Validate/Print Button error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            'MsgBox("Data User: Column name does not exist")
            'Cellclick prompt
        End If
        connection.Close()
    End Sub
    Private Sub quickSqlCommand(commandString As String)
        connection.Open()
        command = New SqlCommand("", connection)
        command.CommandText = commandString
        command.ExecuteNonQuery()
        command = Nothing
        connection.Close()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As System.EventArgs) Handles btnClear_Cancel.Click
        If PccIDToEdit <> Nothing Then
            Clear()
            PccIDToEdit = Nothing
            btnAdd_Saved.Text = "Add"
            btnClear_Cancel.Text = "Clear"
        Else
            Clear()
        End If
    End Sub
    Private Sub Clerk2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub txtApplicantPendingSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtApplicantPendingSearch.TextChanged
        LoadPCCPending(txtApplicantPendingSearch.Text.Trim)
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        Dim reportForm As New ReportForm
        reportForm.ShowDialog()

    End Sub

    Private Sub dataApplicantCompleted_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataApplicantCompleted.CellContentClick
        Dim colname As String = dataApplicantCompleted.Columns(e.ColumnIndex).Name
        If colname = "dataCompletedClearancePrint" Then
            Dim row As DataGridViewRow = dataApplicantCompleted.Rows(e.RowIndex)
            Dim result As DialogResult = MaterialMessageBox.Show("Confirm Print?",
                           "Print Certificate",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, False)
            If result = DialogResult.Yes Then
                Try
                    Dim printForm As New PrintForm
                    printForm.pcc_id = row.Cells("dataCompletedClearanceID").Value
                    printForm.ShowDialog()
                Catch ex As Exception
                    MsgBox("Police Clearance Completed Table - Print error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                End Try
            End If
        Else

        End If
    End Sub



    Private Sub dataApplicantPending_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dataApplicantPending.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim sw As String = txtApplicantPendingSearch.Text.Trim

            If Not String.IsNullOrEmpty(sw) Then
                Dim val As String = CStr(e.FormattedValue)
                Dim sindx As Integer = val.ToLower().IndexOf(sw.ToLower())
                If sindx >= 0 Then
                    Dim hl_rect As New Rectangle()
                    hl_rect.Y = e.CellBounds.Y + 2
                    hl_rect.Height = e.CellBounds.Height - 5

                    Dim sBefore As String = val.Substring(0, sindx)
                    Dim sWord As String = val.Substring(sindx, sw.Length)
                    Dim s1 As Size = TextRenderer.MeasureText(e.Graphics, sBefore, e.CellStyle.Font, e.CellBounds.Size)
                    Dim s2 As Size = TextRenderer.MeasureText(e.Graphics, sWord, e.CellStyle.Font, e.CellBounds.Size)

                    If s1.Width > 5 Then
                        hl_rect.X = e.CellBounds.X + s1.Width - 5
                        hl_rect.Width = s2.Width - 6
                    Else
                        hl_rect.X = e.CellBounds.X + 2
                        hl_rect.Width = s2.Width - 6
                    End If

                    Dim hl_brush As SolidBrush = Nothing
                    If (e.State And DataGridViewElementStates.Selected) <> DataGridViewElementStates.None Then
                        hl_brush = New SolidBrush(Color.DarkGoldenrod)
                    Else
                        hl_brush = New SolidBrush(Color.Yellow)
                    End If

                    e.Graphics.FillRectangle(hl_brush, hl_rect)

                    hl_brush.Dispose()
                End If
            End If

            e.PaintContent(e.CellBounds)
        End If
    End Sub

    Private Sub txtApplicantCompletedSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtApplicantCompletedSearch.TextChanged
        LoadPCCCompleted(txtApplicantCompletedSearch.Text.Trim)
    End Sub



    Private Sub dataApplicantCompleted_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dataApplicantCompleted.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim sw As String = txtApplicantCompletedSearch.Text.Trim

            If Not String.IsNullOrEmpty(sw) Then
                Dim val As String = CStr(e.FormattedValue)
                Dim sindx As Integer = val.ToLower().IndexOf(sw.ToLower())
                If sindx >= 0 Then
                    Dim hl_rect As New Rectangle()
                    hl_rect.Y = e.CellBounds.Y + 2
                    hl_rect.Height = e.CellBounds.Height - 5

                    Dim sBefore As String = val.Substring(0, sindx)
                    Dim sWord As String = val.Substring(sindx, sw.Length)
                    Dim s1 As Size = TextRenderer.MeasureText(e.Graphics, sBefore, e.CellStyle.Font, e.CellBounds.Size)
                    Dim s2 As Size = TextRenderer.MeasureText(e.Graphics, sWord, e.CellStyle.Font, e.CellBounds.Size)

                    If s1.Width > 5 Then
                        hl_rect.X = e.CellBounds.X + s1.Width - 5
                        hl_rect.Width = s2.Width - 6
                    Else
                        hl_rect.X = e.CellBounds.X + 2
                        hl_rect.Width = s2.Width - 6
                    End If

                    Dim hl_brush As SolidBrush = Nothing
                    If (e.State And DataGridViewElementStates.Selected) <> DataGridViewElementStates.None Then
                        hl_brush = New SolidBrush(Color.DarkGoldenrod)
                    Else
                        hl_brush = New SolidBrush(Color.Yellow)
                    End If

                    e.Graphics.FillRectangle(hl_brush, hl_rect)

                    hl_brush.Dispose()
                End If
            End If

            e.PaintContent(e.CellBounds)
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        pccDependencyPending.Stop()
        pccDependencyPending.Dispose()
        Me.Dispose()
        Login.Show()
    End Sub
    'Pending Cancel Button
    Private Sub MaterialButton5_Click(sender As Object, e As System.EventArgs) Handles MaterialButton5.Click
        LoadPCCPending()
        txtApplicantPendingSearch.Text = ""
    End Sub
    'Completed Cancel Button
    Private Sub MaterialButton6_Click(sender As Object, e As System.EventArgs) Handles MaterialButton6.Click
        LoadPCCCompleted()
        txtApplicantCompletedSearch.Text = ""
    End Sub
End Class