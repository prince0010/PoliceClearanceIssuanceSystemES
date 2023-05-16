
Imports System.Data.SqlClient

Public Class Admin
    Friend user_id As Integer

    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If user_id Then
            'MsgBox(Me.Name & " UserID:" & user_id)
            LoadAllTable()
            LoadCounts()
        End If
        connection.Close()
    End Sub
    Private Sub LoadCounts()
        UserCount()
        PoliceCount()
        CRCount()
    End Sub

    Private Sub UserCount()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT COUNT(*) FROM [dbo].[user] WHERE deleted = 0"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            'user_exists = dt.Rows(0)(0)
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                lblUserCount.Text = Convert.ToInt32(dt.Rows(0)(0))
            End If
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading User Count error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PoliceCount()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT COUNT(*) FROM [dbo].[police] WHERE deleted = 0"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            'user_exists = dt.Rows(0)(0)
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                lblPoliceCount.Text = Convert.ToInt32(dt.Rows(0)(0))
            End If
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police Count error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub CRCount()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT COUNT(*) FROM [dbo].[criminal_records] WHERE deleted = 0"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            'user_exists = dt.Rows(0)(0)
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                lblCRCount.Text = Convert.ToInt32(dt.Rows(0)(0))
            End If
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Criminal Records Count error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub LoadAllTable()
        LoadUserTable()
        LoadPoliceTable()
        LoadCRTable()
    End Sub

    Private Sub LoadUserTable(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                'command.CommandText = "SELECT user.user_id AS 'ID', user.username AS 'USERNAME', user.fname AS 'FIRST NAME', user.mname AS 'MIDDLE NAME', user.lname AS 'LAST NAME', user.contact_no AS 'CONTACT NUMBER', usertype.name AS 'USER ROLE' FROM user INNER JOIN usertype ON user.usertype_id = usertype.usertype_id WHERE user.usertype_id != 1 AND deleted=0"
                command.CommandText = "SELECT [user].user_id AS 'ID',[user].username AS 'USERNAME', [user].fname AS 'FIRST NAME', [user].mname AS 'MIDDLE NAME', [user].lname AS 'LAST NAME', [user].contact_no AS 'CONTACT NUMBER', [usertype].name AS 'USER ROLE' FROM [dbo].[user] INNER JOIN [dbo].[usertype] ON [user].usertype_id = [usertype].usertype_id WHERE [user].usertype_id != 1 AND deleted=0"
            Else
                command.CommandText = "SELECT [user].user_id AS 'ID',[user].username AS 'USERNAME', [user].fname AS 'FIRST NAME', [user].mname AS 'MIDDLE NAME', [user].lname AS 'LAST NAME', [user].contact_no AS 'CONTACT NUMBER', [usertype].name AS 'USER ROLE' FROM [dbo].[user] INNER JOIN [dbo].[usertype] ON [user].usertype_id = [usertype].usertype_id WHERE ([user].username LIKE @searchString OR [user].fname LIKE @searchString OR [user].mname LIKE @searchString OR [user].lname LIKE @searchString OR [usertype].name LIKE @searchString) AND [user].usertype_id != 1 AND deleted=0"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            'Setting Autogenerating of Columns to False to Utilize Designer made Columns
            dataUser.AutoGenerateColumns = False
            'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
            'If DataProperty is not set Data Wont display in that specific Column
            dataUser.Columns("dataUserID").DataPropertyName = "ID"
            dataUser.Columns("dataUserUname").DataPropertyName = "USERNAME"
            dataUser.Columns("dataUserFname").DataPropertyName = "FIRST NAME"
            dataUser.Columns("dataUserMname").DataPropertyName = "MIDDLE NAME"
            dataUser.Columns("dataUserLname").DataPropertyName = "LAST NAME"
            dataUser.Columns("dataUserContactNo").DataPropertyName = "CONTACT NUMBER"
            dataUser.Columns("dataUserUtype").DataPropertyName = "USER ROLE"
            dataUser.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try

    End Sub

    Private Sub LoadPoliceTable(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                command.CommandText = "SELECT police.police_id AS 'ID', police.fname  AS 'FIRST NAME', police.mname AS 'MIDDLE NAME', police.lname AS 'LAST NAME', police.contact_no  AS 'CONTACT NUMBER', rank.name AS 'RANK', position.name AS 'POSITION' FROM [dbo].police INNER JOIN [dbo].rank ON rank.rank_id = police.rank_id INNER JOIN [dbo].position ON position.position_id = police.position_id WHERE deleted=0"
            Else
                command.CommandText = "SELECT police.police_id AS 'ID', police.fname  AS 'FIRST NAME', police.mname AS 'MIDDLE NAME', police.lname AS 'LAST NAME', police.contact_no  AS 'CONTACT NUMBER', rank.name AS 'RANK', position.name AS 'POSITION' FROM [dbo].police INNER JOIN [dbo].rank ON rank.rank_id = police.rank_id INNER JOIN [dbo].position ON position.position_id = police.position_id WHERE (police.fname LIKE @searchString OR police.mname LIKE @searchString OR police.lname LIKE @searchString OR rank.name LIKE @searchString OR position.name LIKE @searchString) AND deleted=0"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dataPolice.AutoGenerateColumns = False
            dataPolice.Columns("dataPoliceID").DataPropertyName = "ID"
            dataPolice.Columns("dataPoliceFname").DataPropertyName = "FIRST NAME"
            dataPolice.Columns("dataPoliceMname").DataPropertyName = "MIDDLE NAME"
            dataPolice.Columns("dataPoliceLname").DataPropertyName = "LAST NAME"
            dataPolice.Columns("dataPoliceContactNo").DataPropertyName = "CONTACT NUMBER"
            dataPolice.Columns("dataPoliceRank").DataPropertyName = "RANK"
            dataPolice.Columns("dataPolicePosition").DataPropertyName = "POSITION"
            dataPolice.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try

    End Sub

    Private Sub LoadCRTable(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                command.CommandText = "SELECT cr_id AS 'ID', fname AS 'FNAME', mname AS 'MNAME', lname AS 'LNAME', crime_offense AS 'CRIME', ccno AS 'CC NO', isno AS 'IS NO', remarks AS 'REMARKS' FROM criminal_records WHERE deleted=0"
            Else
                command.CommandText = "SELECT cr_id AS 'ID', fname AS 'FNAME', mname AS 'MNAME', lname AS 'LNAME', crime_offense AS 'CRIME', ccno AS 'CC NO', isno AS 'IS NO', remarks AS 'REMARKS' FROM criminal_records WHERE (fname LIKE @searchString OR mname LIKE @searchString OR lname LIKE @searchString OR crime_offense LIKE @searchString OR ccno LIKE @searchString OR isno LIKE @searchString OR remarks LIKE @searchString) AND deleted=0"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dataCR.AutoGenerateColumns = False
            dataCR.Columns("dataCriminalRecordsID").DataPropertyName = "ID"
            dataCR.Columns("dataCriminalRecordsFName").DataPropertyName = "FNAME"
            dataCR.Columns("dataCriminalRecordsMName").DataPropertyName = "MNAME"
            dataCR.Columns("dataCriminalRecordsLName").DataPropertyName = "LNAME"
            dataCR.Columns("dataCriminalRecordsOffense").DataPropertyName = "CRIME"
            dataCR.Columns("dataCriminalRecordsCCNo").DataPropertyName = "CC NO"
            dataCR.Columns("dataCriminalRecordsISNO").DataPropertyName = "IS NO"
            dataCR.Columns("dataCriminalRecordsRemarks").DataPropertyName = "REMARKS"
            dataCR.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Criminal Records error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try

    End Sub

    Private Sub deleteCommand(deleteDataCommand As String)
        connection.Open()
        command = New SqlCommand("", connection)
        command.CommandText = deleteDataCommand
        command.ExecuteNonQuery()
        connection.Close()
        command = Nothing
    End Sub



    Private Sub txtUserSearch_TextChanged(sender As Object, e As EventArgs) Handles txtUserSearch.TextChanged
        LoadUserTable(txtUserSearch.Text.Trim)
    End Sub

    Private Sub dataUser_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dataUser.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim sw As String = txtUserSearch.Text.Trim

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


    Private Sub txtPoliceSearch_TextChanged(sender As Object, e As EventArgs) Handles txtPoliceSearch.TextChanged
        LoadPoliceTable(txtPoliceSearch.Text.Trim)
    End Sub


    Private Sub dataPolice_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dataPolice.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim sw As String = txtPoliceSearch.Text.Trim

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


    Private Sub dataCR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataCR.CellContentClick
        Dim colname As String = dataCR.Columns(e.ColumnIndex).Name
        If colname = "dataCriminalRecordsBtnEdit" Then
            Try
                Dim row As DataGridViewRow = dataCR.Rows(e.RowIndex)
                Dim criminalrecordsForm As New CriminalRecords
                criminalrecordsForm.cr_id = row.Cells("dataCriminalRecordsID").Value
                criminalrecordsForm.ShowDialog()
                LoadCRTable()
            Catch ex As Exception
                MsgBox("Criminal Record Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        ElseIf colname = "dataCriminalRecordsBtnDelete" Then
            Try
                Dim row As DataGridViewRow = dataCR.Rows(e.RowIndex)
                Dim cr_id_to_delete As Integer = row.Cells("dataCriminalRecordsID").Value
                If (MessageBox.Show("Delete", "Are you sure you want to delete the data?", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    deleteCommand("UPDATE criminal_records SET deleted = 1 WHERE cr_id =" & cr_id_to_delete)
                End If
                LoadCRTable()
            Catch ex As Exception
                MsgBox("Criminal Record Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            'MsgBox("Data User: Column name does not exist")
            'Cellclick prompt
        End If
        connection.Close()
    End Sub

    Private Sub txtCRSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCRSearch.TextChanged
        LoadCRTable(txtCRSearch.Text.Trim)
    End Sub


    Private Sub dataCR_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dataCR.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim sw As String = txtCRSearch.Text.Trim

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

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim adminSettingsForm As New AdminSettings
        adminSettingsForm.user_id = user_id
        adminSettingsForm.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub Admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub MaterialDataTable1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUser.CellContentClick
        Dim colname As String = dataUser.Columns(e.ColumnIndex).Name
        If colname = "dataUserBtnEdit" Then
            Try
                Dim row As DataGridViewRow = dataUser.Rows(e.RowIndex)
                Dim userForm As New User
                userForm.user_id = row.Cells("dataUserID").Value
                userForm.ShowDialog()
                LoadUserTable()
            Catch ex As Exception
                MsgBox("User Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        ElseIf colname = "dataUserBtnDelete" Then
            Try
                Dim row As DataGridViewRow = dataUser.Rows(e.RowIndex)
                Dim user_id_to_delete As Integer = row.Cells("dataUserID").Value
                If (MessageBox.Show("Delete", "Are you sure you want to delete the data?", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    deleteCommand("UPDATE [user] SET deleted = 1 WHERE user_id =" & user_id_to_delete)
                End If
                LoadUserTable()
            Catch ex As Exception
                MsgBox("User Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            'MsgBox("Data User: Column name does not exist")
            'Cellclick prompt
        End If
        connection.Close()
    End Sub

    Private Sub dataPolice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPolice.CellContentClick
        Dim colname As String = dataPolice.Columns(e.ColumnIndex).Name
        If colname = "dataPoliceBtnEdit" Then
            Try
                Dim row As DataGridViewRow = dataPolice.Rows(e.RowIndex)
                Dim policeForm As New Police
                policeForm.police_id = row.Cells("dataPoliceID").Value
                policeForm.ShowDialog()
                LoadPoliceTable()
            Catch ex As Exception
                MsgBox("Police Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        ElseIf colname = "dataPoliceBtnDelete" Then
            Try
                Dim row As DataGridViewRow = dataPolice.Rows(e.RowIndex)
                Dim police_id_to_delete As Integer = row.Cells("dataPoliceID").Value
                If (MessageBox.Show("Delete", "Are you sure you want to delete the data?", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    deleteCommand("UPDATE police SET deleted = 1 WHERE police_id =" & police_id_to_delete)
                End If
                LoadPoliceTable()
            Catch ex As Exception
                MsgBox("Police Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            'MsgBox("Data User: Column name does not exist")
            'Cellclick prompt
        End If
        connection.Close()
    End Sub

    Private Sub btnPoliceAdd_Click(sender As Object, e As EventArgs) Handles btnPoliceAdd.Click
        Dim policeForm As New Police
        policeForm.ShowDialog()
        LoadPoliceTable()
        PoliceCount()
    End Sub

    Private Sub btnPoliceSearchRefresh_Click(sender As Object, e As EventArgs) Handles btnPoliceSearchRefresh.Click
        LoadPoliceTable()
        txtPoliceSearch.Text = ""
    End Sub

    Private Sub btnCRAdd_Click(sender As Object, e As EventArgs) Handles btnCRAdd.Click
        Dim criminalRecordsForm As New CriminalRecords
        criminalRecordsForm.ShowDialog()
        LoadCRTable()
        CRCount()
    End Sub

    Private Sub btnUsersSearchRefresh_Click(sender As Object, e As EventArgs) Handles btnUsersSearchRefresh.Click
        LoadUserTable()
        txtUserSearch.Text = ""
    End Sub

    Private Sub btnCRsSearchRefresh_Click(sender As Object, e As EventArgs) Handles btnCRsSearchRefresh.Click
        LoadCRTable()
        txtCRSearch.Text = ""
    End Sub


    Private Sub btnUsersAdd_Click(sender As Object, e As EventArgs) Handles btnUsersAdd.Click
        Dim userForm As New User
        userForm.ShowDialog()
        LoadUserTable()
        UserCount()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class