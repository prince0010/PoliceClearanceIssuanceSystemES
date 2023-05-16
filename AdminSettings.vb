Imports System.Data.SqlClient
Imports Microsoft.ReportingServices.Diagnostics.Internal

Public Class AdminSettings
    Friend user_id As Integer


    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)
    'save
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If user_id Then
            Try
                SqlData("UPDATE [dbo].[user] SET password = @pword, salt = @salt, fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, usertype_id = 1 WHERE user_id =" & user_id)
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Update Admin Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub
    Private Sub SqlData(sqlCommand As String)
        connection.Open()
        command = New SqlCommand("", connection)
        command.CommandText = sqlCommand
        command.Parameters.Clear()
        'command.Parameters.AddWithValue("@uname", txtUname.Text.Trim)
        Dim salt As String = SecurityHelper.GenerateSalt
        Dim hashedPassword As String = SecurityHelper.HashPassword(txtPassword.Text.Trim, salt)
        command.Parameters.AddWithValue("@salt", salt)
        command.Parameters.AddWithValue("@pword", hashedPassword)
        command.Parameters.AddWithValue("@fname", txtFname.Text.Trim)
        command.Parameters.AddWithValue("@mname", txtMname.Text.Trim)
        command.Parameters.AddWithValue("@lname", txtLname.Text.Trim)
        command.Parameters.AddWithValue("@contactno", txtContactNo.Text.Trim)

        command.ExecuteNonQuery()
        connection.Close()
        command = Nothing
    End Sub
    Private Sub AdminSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                txtFname.Text = dt.Rows(0).Item("fname")
                txtMname.Text = dt.Rows(0).Item("mname")
                txtLname.Text = dt.Rows(0).Item("lname")
                txtContactNo.Text = dt.Rows(0).Item("contact_no")
            End If
            connection.Close()
            command = Nothing
        End If
        connection.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        Me.Dispose()
    End Sub

End Class