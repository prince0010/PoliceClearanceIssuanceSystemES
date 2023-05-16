Public Class Validation_Hit
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
        Me.Dispose()
    End Sub
End Class