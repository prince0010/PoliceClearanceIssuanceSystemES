Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Security.Cryptography
Imports PoliceClearanceSystemES.SecurityHelper
Imports MaterialSkin2Framework.Controls

Public Class User
    Friend user_id As Integer


    Private connString As String = (New ConfigHelper).ConnectionString

    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)
    Private user_exists As Integer
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        'If value of user_id is passed here, execute update data then

        If user_id Then
            Try
                connection.Open()
                command = New SqlCommand("", connection)
                command.CommandText = "SELECT COUNT(*) AS 'count', user_id FROM [dbo].[user] WHERE username = @uname AND deleted = 0 GROUP BY user_id"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@uname", txtUname.Text.Trim)
                Dim da As New SqlDataAdapter(command)
                Dim dt As New DataTable()
                da.Fill(dt)
                'user_exists = dt.Rows(0)(0)
                If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                    user_exists = Convert.ToInt32(dt.Rows(0)(0))
                End If
                'closing connection early, if 2 connections are opened at the same time or nested connections it will prompt SQLiteDB lock!
                connection.Close()
                command = Nothing
                If (user_exists > 0 And user_id <> dt.Rows(0).Item("user_id")) Then
                    MaterialMessageBox.Show("Username Taken", "Update Error", MessageBoxButtons.OK, False)
                ElseIf (user_exists > 0 And user_id = dt.Rows(0).Item("user_id")) Then
                    Try
                        SqlData("UPDATE [dbo].[user] SET username = @uname, password = @pword, salt = @salt, fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, usertype_id = @utype_id WHERE user_id =" & user_id)
                        Me.Dispose()
                    Catch ex As Exception
                        connection.Close()
                        MsgBox("Update User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                    End Try
                Else

                End If
            Catch ex As Exception
                connection.Close()
                MsgBox("Username taken error(Update)" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
            'MsgBox(Me.Name & " UserID:" & user_id)
        Else
            'If no user_id value then add new User to data table
            Try
                connection.Open()
                command = New SqlCommand("", connection)
                command.CommandText = "SELECT COUNT(*) FROM [dbo].[user] WHERE username = @uname AND deleted = 0"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@uname", txtUname.Text.Trim)
                Dim da As New SqlDataAdapter(command)
                Dim dt As New DataTable()
                da.Fill(dt)
                If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                    user_exists = Convert.ToInt32(dt.Rows(0)(0))
                End If
                connection.Close()
                command = Nothing
                If (user_exists > 0) Then
                    MaterialMessageBox.Show("Username Taken", "Insert Error", MessageBoxButtons.OK, False)
                Else
                    Try
                        SqlData("INSERT INTO [dbo].[user](username,password,salt,fname,mname,lname,contact_no,usertype_id,deleted) VALUES(@uname,@pword,@salt,@fname,@mname,@lname,@contactno,@utype_id,0)")
                        Me.Dispose()
                    Catch ex As Exception
                        connection.Close()
                        MsgBox("Insert User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                    End Try
                End If

            Catch ex As Exception
                connection.Close()
                MsgBox("Username taken error(Insert)" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub
    Private Sub SqlData(sqlCommand As String)
        connection.Open()
        command = New SqlCommand("", connection)
        command.CommandText = sqlCommand
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@uname", txtUname.Text.Trim)
        Dim salt As String = SecurityHelper.GenerateSalt
        Dim hashedPassword As String = SecurityHelper.HashPassword(txtPassword.Text.Trim, salt)
        command.Parameters.AddWithValue("@salt", salt)
        command.Parameters.AddWithValue("@pword", hashedPassword)
        command.Parameters.AddWithValue("@fname", txtFname.Text.Trim)
        command.Parameters.AddWithValue("@mname", txtMname.Text.Trim)
        command.Parameters.AddWithValue("@lname", txtLname.Text.Trim)
        command.Parameters.AddWithValue("@contactno", txtContactNo.Text.Trim)
        command.Parameters.AddWithValue("@utype_id", cbUsertype.SelectedValue.ToString)

        command.ExecuteNonQuery()
        connection.Close()
        command = Nothing
    End Sub
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Preload data
        PopulateCombobox()
        'If value of user_id is passed here, execute update data then
        If user_id Then
            'MsgBox(Me.Name & " UserID:" & user_id)
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT * FROM [user] WHERE deleted = 0 AND user_id = " & user_id
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                txtUname.Text = dt.Rows(0).Item("username")
                'txtPassword.Text = dt.Rows(0).Item("password
                txtFname.Text = dt.Rows(0).Item("fname")
                txtMname.Text = dt.Rows(0).Item("mname")
                txtLname.Text = dt.Rows(0).Item("lname")
                txtContactNo.Text = dt.Rows(0).Item("contact_no")
                cbUsertype.SelectedValue = dt.Rows(0).Item("usertype_id")
            End If
            connection.Close()
            command = Nothing
        Else
            'MsgBox("No user_ID")
        End If


        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub

    Private Sub PopulateCombobox()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT usertype_id AS 'USERTYPE ID', name AS 'USERTYPE NAME' FROM usertype WHERE usertype_id != 1"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbUsertype.DisplayMember = dt.Columns("USERTYPE NAME").ToString
            cbUsertype.ValueMember = dt.Columns("USERTYPE ID").ToString
            cbUsertype.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            MsgBox("Loading User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        Me.Dispose()

    End Sub

End Class