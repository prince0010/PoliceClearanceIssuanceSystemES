Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MaterialSkin2Framework.Controls

Public Class Validation_ForceValidation
    Dim findingsRemarksDefault As String = "No Criminal/Derogatory Record on file as of this Date!"
    Public Property Fname As String
    Public Property Mname As String
    Public Property Lname As String

    Public Property pcc_id As Integer

    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    'Private command As New SqlCommand("", connection)
    Private command
    Private Sub Validation_ForceValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = findingsRemarksDefault
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT * FROM [dbo].[criminal_records] WHERE (fname LIKE @fname OR mname LIKE @mname OR lname LIKE @lname) AND deleted = 0"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@fname", "%" & Fname & "%")
            command.Parameters.AddWithValue("@mname", "%" & Mname & "%")
            command.Parameters.AddWithValue("@lname", "%" & Lname & "%")
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns("CrimeID").DataPropertyName = "cr_id"
            DataGridView1.Columns("CrimeFname").DataPropertyName = "fname"
            DataGridView1.Columns("CrimeMname").DataPropertyName = "mname"
            DataGridView1.Columns("CrimeLname").DataPropertyName = "lname"
            DataGridView1.Columns("CrimeOffense").DataPropertyName = "crime_offense"
            DataGridView1.Columns("CrimeCCNO").DataPropertyName = "ccno"
            DataGridView1.Columns("CrimeISNO").DataPropertyName = "isno"
            DataGridView1.Columns("CrimeRemarks").DataPropertyName = "remarks"
            DataGridView1.DataSource = dt
            connection.Close()
            command = Nothing
            If DataGridView1.Rows.Count > 0 Then
                Dim firstCheckBoxRow As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(0).Cells("CrimeCheckBox"), DataGridViewCheckBoxCell)
                firstCheckBoxRow.Value = True
            End If
        Catch ex As Exception
            MsgBox("Force Validation Error - Loading Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Dim chosen_cr_id As Integer
        Dim findingsRemarks As String
        If chkCriminalRecord.Checked = True Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If CBool(row.Cells("CrimeCheckBox").Value) Then
                    chosen_cr_id = CInt(row.Cells("CrimeID").Value)
                End If
            Next
        Else
            chosen_cr_id = 0
        End If
        If chkRemarks.Checked = True Then
            findingsRemarks = RichTextBox1.Text
        Else
            findingsRemarks = ""
        End If
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "UPDATE dbo.[pcc] SET [pcc].[status] = 'VALIDATED', [pcc].[cr_id] = @cr_id, [pcc].[findingsRemarks] = @findingsremarks WHERE [pcc].[pcc_id] =" & pcc_id
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@cr_id", chosen_cr_id)
            command.Parameters.AddWithValue("@findingsremarks", findingsRemarks)
            command.ExecuteNonQuery()
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Force Validation Error - Confirm Button Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
        Me.DialogResult = DialogResult.OK
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "CrimeCheckBox" AndAlso e.RowIndex >= 0 Then
            ' Uncheck all other rows in the CheckBox column
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Index <> e.RowIndex Then
                    Dim checkBox As DataGridViewCheckBoxCell = CType(row.Cells("CrimeCheckBox"), DataGridViewCheckBoxCell)
                    checkBox.Value = False
                End If
            Next
        End If
    End Sub

    Private Sub chkCriminalRecord_CheckStateChanged(sender As Object, e As EventArgs) Handles chkCriminalRecord.CheckStateChanged
        If chkCriminalRecord.CheckState = CheckState.Checked Then
            ' Do something when the CheckBox is checked.
            DataGridView1.Enabled = True

            If DataGridView1.Rows.Count > 0 Then
                Dim firstCheckBoxRow As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(0).Cells("CrimeCheckBox"), DataGridViewCheckBoxCell)
                firstCheckBoxRow.Value = True
            End If


        ElseIf chkCriminalRecord.CheckState = CheckState.Unchecked Then
            ' Do something when the CheckBox is unchecked.
            DataGridView1.Enabled = False
            'DataGridView1.EnableHeadersVisualStyles = False
            chkRemarks.Checked = True
            RichTextBox1.Text = findingsRemarksDefault
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim checkBox As DataGridViewCheckBoxCell = CType(row.Cells("CrimeCheckBox"), DataGridViewCheckBoxCell)
                checkBox.Value = False
            Next
        End If
    End Sub

    Private Sub DataGridView1_EnabledChanged(sender As Object, e As EventArgs) Handles DataGridView1.EnabledChanged
        If Not DataGridView1.Enabled Then
            DataGridView1.DefaultCellStyle.BackColor = SystemColors.Control
            DataGridView1.DefaultCellStyle.ForeColor = SystemColors.GrayText
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText
            DataGridView1.CurrentCell = Nothing
            DataGridView1.ReadOnly = True
            DataGridView1.EnableHeadersVisualStyles = False
        Else
            DataGridView1.DefaultCellStyle.BackColor = SystemColors.Window
            DataGridView1.DefaultCellStyle.ForeColor = SystemColors.ControlText
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText
            DataGridView1.ReadOnly = False
            DataGridView1.EnableHeadersVisualStyles = True
        End If
    End Sub

    Private Sub chkRemarks_CheckStateChanged(sender As Object, e As EventArgs) Handles chkRemarks.CheckStateChanged
        If chkRemarks.CheckState = CheckState.Checked Then
            ' Do something when the CheckBox is checked.
            RichTextBox1.Enabled = True
            'DataGridView1.EnableHeadersVisualStyles = True
        ElseIf chkRemarks.CheckState = CheckState.Unchecked Then
            ' Do something when the CheckBox is unchecked.
            RichTextBox1.Enabled = False
        End If
    End Sub

    Private Sub chkCriminalRecord_CheckedChanged(sender As Object, e As EventArgs) Handles chkCriminalRecord.CheckedChanged
        If Not chkCriminalRecord.Checked Then
            Dim result As DialogResult = MaterialMessageBox.Show("Are you sure you don't want to set Criminal Record?, Unchecking this would result Applicant Findings to 'NULL'", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, False)

            If result = DialogResult.Yes Then
                ' Do something if the user wants to proceed with unchecking the CheckBox.
            Else
                ' Set the Checked property back to True to prevent unchecking the CheckBox.
                chkCriminalRecord.Checked = True
            End If
        End If
    End Sub
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If RichTextBox1.Enabled = True Then
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub chkRemarks_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemarks.CheckedChanged
        If Not chkRemarks.Checked Then

            If chkCriminalRecord.Checked = False Then
                Dim result As DialogResult = MaterialMessageBox.Show("Cannot uncheck Remarks unless you set A Criminal Record to display for Findings in Police Clearance Certificate", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error, False)
                chkRemarks.Checked = True
            End If
            'If result = DialogResult.Yes Then
            '    ' Do something if the user wants to proceed with unchecking the CheckBox.
            'Else
            ' Set the Checked property back to True to prevent unchecking the CheckBox.

            'End If
        End If
    End Sub


End Class