<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CameraForm
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin2Framework.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CameraForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ComboboxSources = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ConfirmButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCapture = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.BtnStart = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(324, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(282, 263)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(86, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Camera Feed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(112, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Capture"
        '
        'ComboboxSources
        '
        Me.ComboboxSources.FormattingEnabled = True
        Me.ComboboxSources.Location = New System.Drawing.Point(235, 397)
        Me.ComboboxSources.Name = "ComboboxSources"
        Me.ComboboxSources.Size = New System.Drawing.Size(166, 23)
        Me.ComboboxSources.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.ConfirmButton)
        Me.Panel2.Location = New System.Drawing.Point(235, 458)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 23)
        Me.Panel2.TabIndex = 62
        '
        'ConfirmButton
        '
        Me.ConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ConfirmButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.ConfirmButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.ConfirmButton.Depth = 0
        Me.ConfirmButton.HighEmphasis = False
        Me.ConfirmButton.Icon = Nothing
        Me.ConfirmButton.Location = New System.Drawing.Point(0, 0)
        Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ConfirmButton.MaximumSize = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.MinimumSize = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.TabIndex = 7
        Me.ConfirmButton.Text = "Save"
        Me.ConfirmButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.ConfirmButton.UseAccentColor = False
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Location = New System.Drawing.Point(326, 458)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 23)
        Me.Panel1.TabIndex = 61
        '
        'CancelButton
        '
        Me.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.CancelButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.CancelButton.Depth = 0
        Me.CancelButton.HighEmphasis = False
        Me.CancelButton.Icon = Nothing
        Me.CancelButton.Location = New System.Drawing.Point(0, 0)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CancelButton.MaximumSize = New System.Drawing.Size(75, 23)
        Me.CancelButton.MinimumSize = New System.Drawing.Size(75, 23)
        Me.CancelButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.CancelButton.UseAccentColor = False
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.BtnCapture)
        Me.Panel3.Location = New System.Drawing.Point(326, 429)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 23)
        Me.Panel3.TabIndex = 64
        '
        'BtnCapture
        '
        Me.BtnCapture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCapture.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.BtnCapture.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnCapture.Depth = 0
        Me.BtnCapture.HighEmphasis = False
        Me.BtnCapture.Icon = Nothing
        Me.BtnCapture.Location = New System.Drawing.Point(0, 0)
        Me.BtnCapture.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnCapture.MaximumSize = New System.Drawing.Size(75, 23)
        Me.BtnCapture.MinimumSize = New System.Drawing.Size(75, 23)
        Me.BtnCapture.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.BtnCapture.Name = "BtnCapture"
        Me.BtnCapture.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnCapture.Size = New System.Drawing.Size(75, 23)
        Me.BtnCapture.TabIndex = 8
        Me.BtnCapture.Text = "Capture"
        Me.BtnCapture.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.BtnCapture.UseAccentColor = False
        Me.BtnCapture.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnStart.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.BtnStart.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnStart.Depth = 0
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.HighEmphasis = False
        Me.BtnStart.Icon = Nothing
        Me.BtnStart.Location = New System.Drawing.Point(0, 0)
        Me.BtnStart.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnStart.MaximumSize = New System.Drawing.Size(75, 23)
        Me.BtnStart.MinimumSize = New System.Drawing.Size(75, 23)
        Me.BtnStart.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 7
        Me.BtnStart.Text = "Start"
        Me.BtnStart.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.BtnStart.UseAccentColor = False
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BtnStart)
        Me.Panel4.Location = New System.Drawing.Point(235, 429)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(75, 23)
        Me.Panel4.TabIndex = 63
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(25, 82)
        Me.MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(283, 3)
        Me.MaterialDivider1.TabIndex = 65
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(324, 82)
        Me.MaterialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(283, 3)
        Me.MaterialDivider2.TabIndex = 66
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(26, 350)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(282, 32)
        Me.Panel5.TabIndex = 64
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(324, 350)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(282, 32)
        Me.Panel6.TabIndex = 65
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(26, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(-1, 494)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(636, 5)
        Me.Panel7.TabIndex = 64
        '
        'CameraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 497)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboboxSources)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "CameraForm"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.Text = "Camera"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ComboboxSources As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ConfirmButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnStart As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnCapture As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
End Class
