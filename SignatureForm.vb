Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO

Public Class SignatureForm
    Private signatureObject As New Dictionary(Of Integer, List(Of Point))
    Private signaturePen As New Pen(Color.Black, 4)
    Private currentCurvePoints As List(Of Point)
    Private currentCurve As Integer = -1
    Public Property Singature As Bitmap

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If currentCurve < 0 OrElse signatureObject(currentCurve).Count = 0 Then Return

        Dim imgSignature As Bitmap = New Bitmap(pBoxSignature.Width, pBoxSignature.Height, PixelFormat.Format32bppArgb)
        Using g As Graphics = Graphics.FromImage(imgSignature)
            DrawSignature(g)
            pBoxSignature.Image = imgSignature
        End Using

        Singature = pBoxSignature.Image
        Me.DialogResult = DialogResult.OK
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub pBoxSignature_MouseDown(sender As Object, e As MouseEventArgs) Handles pBoxSignature.MouseDown
        currentCurvePoints = New List(Of Point)
        currentCurve += 1
        signatureObject.Add(currentCurve, currentCurvePoints)
    End Sub
    Private Sub pBoxSignature_Paint(sender As Object, e As PaintEventArgs) Handles pBoxSignature.Paint
        If currentCurve < 0 OrElse signatureObject(currentCurve).Count = 0 Then Return
        DrawSignature(e.Graphics)
    End Sub
    Private Sub pBoxSignature_MouseMove(sender As Object, e As MouseEventArgs) Handles pBoxSignature.MouseMove
        If e.Button <> MouseButtons.Left OrElse currentCurve < 0 Then Return
        signatureObject(currentCurve).Add(e.Location)
        pBoxSignature.Invalidate()
    End Sub
    Private Sub DrawSignature(g As Graphics)
        g.CompositingQuality = CompositingQuality.HighQuality
        g.SmoothingMode = SmoothingMode.AntiAlias

        For Each curve In signatureObject
            If curve.Value.Count < 2 Then Continue For
            Using gPath As New GraphicsPath()
                gPath.AddCurve(curve.Value.ToArray(), 0.5F)
                g.DrawPath(signaturePen, gPath)
            End Using
        Next
    End Sub
    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub pBoxSignature_Click(sender As Object, e As EventArgs) Handles pBoxSignature.Click

    End Sub
End Class