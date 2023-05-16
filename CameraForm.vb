
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Imaging.Filters
Imports System.Drawing.Imaging


Public Class CameraForm
    Dim CAM As VideoCaptureDevice
    Dim videoDevices As FilterInfoCollection
    Dim bmp As Bitmap
    Dim img As Image
    Public Property CameraImg As Bitmap
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If CAM.IsRunning = False Then
            CAM.Start()
        End If
    End Sub
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
        End If
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub




    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles BtnCapture.Click


        PictureBox2.Image = PictureBox1.Image.Clone
        If PictureBox2.Image IsNot Nothing Then
            img = PictureBox2.Image
        End If



    End Sub
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim rect1 As Rectangle = New Rectangle(0, 0, img.Width, img.Height)
        Dim rect2 As Rectangle = New Rectangle(PictureBox2.Bounds.X, PictureBox2.Bounds.Y, PictureBox2.Bounds.Width, PictureBox2.Bounds.Height)

        rect2.X = CInt(rect1.X + ((rect1.Width / 2) - (rect2.Width / 2)))
        rect2.Y = CInt(rect1.Y + ((rect1.Height / 2) - (rect2.Height / 2)))



        Dim cropFilter As New Crop(rect2)
        bmp = cropFilter.Apply(img)

        PictureBox2.Image = bmp

        CameraImg = PictureBox2.Image

        Me.DialogResult = DialogResult.OK
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub EnumerateVideoDevices()
        ' enumerate video devices
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count <> 0 Then
            ' add all devices to combo
            For Each device As FilterInfo In videoDevices
                ComboboxSources.Items.Add(device.Name)
            Next
            CAM = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler CAM.NewFrame, New NewFrameEventHandler(AddressOf Captured)
        Else
            ComboboxSources.Items.Add("No DirectShow devices found")
        End If
        ComboboxSources.SelectedIndex = 0
    End Sub




    Private Sub CameraStop()
        If CAM IsNot Nothing And CAM.IsRunning Then
            ' stop video device
            CAM.SignalToStop()
            CAM = Nothing
        End If
    End Sub

    Private Sub CameraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnumerateVideoDevices()

    End Sub

    Private Sub CameraForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CameraStop()
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
        Me.Dispose()
    End Sub

End Class