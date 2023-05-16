Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports MaterialSkin2Framework.Controls
Imports PoliceClearanceSystemES.Clerk2
Imports TableDependency.SqlClient

Public Class Cashier
    Friend user_id As Integer

    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command

    Private status_pending As String = "PENDING"
    Private status_paid As String = "PAID"
    Private status_validated As String = "VALIDATED"
    Private status_completed As String = "COMPLETED"

    Dim now As DateTime = DateTime.Now

    Dim pccDependency As SqlTableDependency(Of PoliceClearanceCertificate)

    Private Sub Cashier_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        LoadPCC()

        Dim pccMapper = New TableDependency.SqlClient.Base.ModelToTableMapper(Of PoliceClearanceCertificate)()
        pccMapper.AddMapping(Function(c) c.PccNo, "pcc_number").AddMapping(Function(c) c.Fname, "fname").AddMapping(Function(c) c.Mname, "mname").AddMapping(Function(c) c.Lname, "lname").AddMapping(Function(c) c.Status, "status")
        pccDependency = New SqlTableDependency(Of PoliceClearanceCertificate)(connString, "pcc", "dbo", pccMapper)

        AddHandler pccDependency.OnChanged, AddressOf OnPccDependencyChanged

        pccDependency.Start()
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As System.EventArgs) Handles MaterialButton2.Click
        Dim result As DialogResult = MaterialMessageBox.Show("Confirm Applicant on Payment?",
                              "Confirm Applicant",
                              MessageBoxButtons.YesNo, False)
        If result = DialogResult.Yes Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If CBool(row.Cells("ClearanceCheckBox").Value) Then
                    ' Do something with the checked row
                    ' For example:
                    Dim pcc_id As String = CStr(row.Cells("ClearanceID").Value)
                    connection.Open()
                    command = New SqlCommand("", connection)
                    command.CommandText = "UPDATE dbo.[pcc] SET [pcc].[status] = 'PAID', [pcc].[payment_confirmed_date] = @cashier_confirmed_date, [pcc].[payment_confirmed_user] = @user_id_cashier WHERE [pcc].[pcc_id] =" & pcc_id
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@user_id_cashier", user_id)
                    command.Parameters.AddWithValue("@cashier_confirmed_date", now.Date)
                    command.ExecuteNonQuery()
                    connection.Close()
                    command = Nothing

                End If
            Next
            LoadPCC()
        End If
    End Sub

    Private Sub Cashier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
    Private Sub LoadPCC(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname] FROM dbo.[pcc] WHERE [pcc].[status] = 'PENDING' AND CONVERT(date, created_at) = CONVERT(date, Getdate()) ORDER BY updated_at DESC"
            Else
                'command.CommandText = "SELECT cr_id AS 'ID', name AS 'NAME', crime_offense AS 'CRIME', ccno AS 'CC NO', isno AS 'IS NO', remarks AS 'REMARKS' FROM criminal_records WHERE (name LIKE '%" & searchString & "%' OR crime_offense LIKE '%" & searchString & "%' OR ccno LIKE '%" & searchString & "%' OR isno LIKE '%" & searchString & "%' OR remarks LIKE '%" & searchString & "%') AND deleted=0"
                command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname] FROM dbo.[pcc] WHERE ([pcc].[pcc_number] LIKE @searchString OR [pcc].[fname] LIKE @searchString OR [pcc].[mname] LIKE @searchString OR [pcc].[lname] LIKE @searchString) AND [pcc].[status] = 'PENDING' AND CONVERT(date, created_at) = CONVERT(date, Getdate()) ORDER BY updated_at DESC"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If
            'command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc] WHERE [pcc].[status] = 'PENDING'"

            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns("ClearanceID").DataPropertyName = "pcc_id"
            DataGridView1.Columns("ClearanceNo").DataPropertyName = "pcc_number"
            DataGridView1.Columns("ClearanceFname").DataPropertyName = "fname"
            DataGridView1.Columns("ClearanceMname").DataPropertyName = "mname"
            DataGridView1.Columns("ClearanceLname").DataPropertyName = "lname"
            'DataGridView1.Columns("ClearanceStatus").DataPropertyName = "status"
            DataGridView1.Columns("ClearanceID").Visible = False

            DataGridView1.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police Clearance Certificate - Pending Data Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Delegate Sub UpdatePccDependency()

    Private Sub OnPccDependencyChanged(ByVal sender As Object, ByVal e As TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs(Of PoliceClearanceCertificate))
        'MsgBox("Updated:" + e.ChangeType)

        If e.ChangeType <> TableDependency.SqlClient.Base.Enums.ChangeType.None Then
            Dim changedEntity = e.Entity
            Console.WriteLine("DML operation: " & e.ChangeType.ToString())
            Console.WriteLine("value: " & changedEntity.Fname)
            Dim reloadData As UpdatePccDependency = New UpdatePccDependency(AddressOf LoadPCC)
            Me.Invoke(reloadData, Nothing)

        End If
    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim sw As String = TextBox1.Text.Trim

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



    Private Sub chbAll_CheckedChanged(sender As Object, e As System.EventArgs) Handles chbAll.CheckedChanged
        Dim chkHeader As CheckBox = CType(sender, CheckBox)
        If chkHeader.Checked Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("ClearanceCheckBox").Value = True
            Next
        Else
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("ClearanceCheckBox").Value = False
            Next
        End If
    End Sub
    Private Sub MaterialButton1_Click(sender As Object, e As System.EventArgs) Handles MaterialButton1.Click
        LoadPCC()
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        LoadPCC(TextBox1.Text.Trim)
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        pccDependency.Stop()
        pccDependency.Dispose()
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub Cashier_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pccDependency.Stop()
        pccDependency.Dispose()
    End Sub

End Class