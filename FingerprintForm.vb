Imports AxZKFPEngXControl

Public Class FingerprintForm
    Dim WithEvents ZkFprint As New AxZKFPEngX
    Dim Check As Boolean
    Public Property Fingerprint As Bitmap
    ' Private Sub FingerprintForm_Load(sender As Object, e As EventArgs)
    ' Controls.Add(ZkFprint)
    '  InitialAxZkfp()

    '   End Sub
    Private Sub InitialAxZkfp()
        Try
            If (ZkFprint.InitEngine = 0) Then
                ZkFprint.FPEngineVersion = "9"
                ZkFprint.EnrollCount = 3
                deviceSerial.Text = (deviceSerial.Text + (" " _
                            + (ZkFprint.SensorSN + (" Count: " _
                            + (ZkFprint.SensorCount.ToString + (" Index: " + ZkFprint.SensorIndex.ToString))))))
                ShowHintInfo("Device successfully connected")
            End If

        Catch ex As Exception
            ShowHintInfo(("Device init err, error: " + ex.Message))
        End Try


    End Sub
    Private Sub ShowHintInfo(ByVal s As String)
        prompt.Text = s
    End Sub
    Private Sub zkFprint_OnImageReceived()
        Dim g As Graphics = fpicture.CreateGraphics
        Dim bmp As Bitmap = New Bitmap(fpicture.Width, fpicture.Height)
        g = Graphics.FromImage(bmp)
        Dim dc As Integer = g.GetHdc.ToInt32
        ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()
        fpicture.Image = bmp
    End Sub
    Private Sub ZkFprint_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent) Handles ZkFprint.OnImageReceived
        Dim g As Graphics = fpicture.CreateGraphics
        Dim bmp As Bitmap = New Bitmap(fpicture.Width, fpicture.Height)
        g = Graphics.FromImage(bmp)
        Dim dc As Integer = g.GetHdc.ToInt32
        ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()
        fpicture.Image = bmp
    End Sub

    Private Sub CancelButton_Click_1(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ConfirmButton_Click_1(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Fingerprint = fpicture.Image
        Me.DialogResult = DialogResult.OK
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ClearButton_Click_1(sender As Object, e As EventArgs) Handles ClearButton.Click
        fpicture.Image = Nothing
    End Sub

    Private Sub FingerprintForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.Add(ZkFprint)
        InitialAxZkfp()
    End Sub
End Class