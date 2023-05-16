
Imports System.Data.SqlClient

Public Class Login
    'Private dbName As String = "ESPCS.db"
    'Private dbPath As String = Directory.GetCurrentDirectory & "\bin\Debug\db\" & dbName
    'Private dbPath As String = Application.StartupPath & "\" & dbName


    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)

    Private usertype_admin As Integer = 1
    Private usertype_clerk As Integer = 2
    Private usertype_cashier As Integer = 3

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (txtUser.Text.Trim = "" And txtPassword.Text.Trim = "") Then
            MsgBox("Username & Password Empty")
        ElseIf txtUser.Text.Trim = "" Then
            MsgBox("Username Empty")
        ElseIf txtPassword.Text.Trim = "" Then
            MsgBox("Password Empty")
        Else
            Try
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    'MsgBox("Logging In")
                    command = New SqlCommand("", connection)
                    command.CommandText = "SELECT salt, password, usertype_id, user_id FROM [dbo].[user] WHERE username = @user AND deleted=0"
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@user", txtUser.Text.Trim)

                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        ' Read the first row of results
                        reader.Read()
                        'MsgBox("Logging In")
                        ' Retrieve the salt and hashed password values from the row
                        Dim saltIndex As Integer = reader.GetOrdinal("salt")
                        Dim salt As String = reader.GetString(saltIndex)
                        Dim hashedPasswordIndex As Integer = reader.GetOrdinal("password")
                        Dim hashedPassword As String = reader.GetString(hashedPasswordIndex)
                        Dim utypeIndex As Integer = reader.GetOrdinal("usertype_id")
                        Dim utype As Integer = reader.GetInt32(utypeIndex)
                        Dim userIndex As Integer = reader.GetOrdinal("user_id")
                        Dim userID As Integer = reader.GetInt32(userIndex)

                        ' Verify the password entered by the user against the stored hashed password
                        If SecurityHelper.VerifyPassword(txtPassword.Text.Trim, salt, hashedPassword) Then
                            ' Login successful, do something here (e.g., redirect to a secured page)
                            If utype = usertype_admin Then
                                Dim adminForm As New Admin
                                adminForm.user_id = userID
                                adminForm.Show()
                                Me.Hide()
                            ElseIf utype = usertype_clerk Then
                                Dim clerkForm As New Clerk2
                                clerkForm.user_id = userID
                                clerkForm.Show()
                                Me.Hide()
                            ElseIf utype = usertype_cashier Then
                                Dim cashierForm As New Cashier
                                cashierForm.user_id = userID
                                cashierForm.Show()
                                Me.Hide()
                            Else
                                MsgBox("User Usertype nonexistent")
                                connection.Close()
                            End If

                        Else
                            ' Login failed, show an error message to the user
                            MessageBox.Show("Invalid username or password.")
                            connection.Close()
                        End If
                    Else
                        ' No rows were returned, show an error message to the user
                        MessageBox.Show("User nonexistent.")
                        connection.Close()
                    End If
                    reader.Close()
                    command = Nothing
                End If
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MsgBox("Connection Error!: Cannot Proceed" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    connection.Open()
        '    If connection.State = ConnectionState.Open Then
        '        MsgBox("Database Connected")
        '        connection.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox("Connection Error!: Cannot connect to Database" & vbCrLf & String.Format("Error: {0}", ex.Message))
        '    connection.Close()
        'End Try


    End Sub

End Class
