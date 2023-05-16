<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FingerprintForm
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FingerprintForm))
        deviceSerial = New Label()
        prompt = New Label()
        fpicture = New PictureBox()
        ClearButton = New MaterialSkin2Framework.Controls.MaterialButton()
        ConfirmButton = New MaterialSkin2Framework.Controls.MaterialButton()
        CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(fpicture, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' deviceSerial
        ' 
        deviceSerial.AutoSize = True
        deviceSerial.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        deviceSerial.Location = New Point(11, 71)
        deviceSerial.Name = "deviceSerial"
        deviceSerial.Size = New Size(85, 17)
        deviceSerial.TabIndex = 0
        deviceSerial.Text = "Device Serial:"
        ' 
        ' prompt
        ' 
        prompt.AutoSize = True
        prompt.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        prompt.Location = New Point(11, 347)
        prompt.Name = "prompt"
        prompt.Size = New Size(56, 17)
        prompt.TabIndex = 1
        prompt.Text = "Ready...."
        ' 
        ' fpicture
        ' 
        fpicture.Location = New Point(11, 91)
        fpicture.Name = "fpicture"
        fpicture.Size = New Size(250, 250)
        fpicture.TabIndex = 2
        fpicture.TabStop = False
        ' 
        ' ClearButton
        ' 
        ClearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClearButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        ClearButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        ClearButton.Depth = 0
        ClearButton.HighEmphasis = False
        ClearButton.Icon = Nothing
        ClearButton.Location = New Point(0, 1)
        ClearButton.Margin = New Padding(4, 6, 4, 6)
        ClearButton.MaximumSize = New Size(75, 23)
        ClearButton.MinimumSize = New Size(75, 23)
        ClearButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        ClearButton.Name = "ClearButton"
        ClearButton.NoAccentTextColor = Color.Empty
        ClearButton.Size = New Size(75, 23)
        ClearButton.TabIndex = 6
        ClearButton.Text = "Clear"
        ClearButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        ClearButton.UseAccentColor = False
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' ConfirmButton
        ' 
        ConfirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ConfirmButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        ConfirmButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        ConfirmButton.Depth = 0
        ConfirmButton.HighEmphasis = False
        ConfirmButton.Icon = Nothing
        ConfirmButton.Location = New Point(0, 0)
        ConfirmButton.Margin = New Padding(4, 6, 4, 6)
        ConfirmButton.MaximumSize = New Size(75, 23)
        ConfirmButton.MinimumSize = New Size(75, 23)
        ConfirmButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        ConfirmButton.Name = "ConfirmButton"
        ConfirmButton.NoAccentTextColor = Color.Empty
        ConfirmButton.Size = New Size(75, 23)
        ConfirmButton.TabIndex = 7
        ConfirmButton.Text = "Confirm"
        ConfirmButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        ConfirmButton.UseAccentColor = False
        ConfirmButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CancelButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        CancelButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        CancelButton.Depth = 0
        CancelButton.HighEmphasis = False
        CancelButton.Icon = Nothing
        CancelButton.Location = New Point(0, 1)
        CancelButton.Margin = New Padding(4, 6, 4, 6)
        CancelButton.MaximumSize = New Size(75, 23)
        CancelButton.MinimumSize = New Size(75, 23)
        CancelButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        CancelButton.Name = "CancelButton"
        CancelButton.NoAccentTextColor = Color.Empty
        CancelButton.Size = New Size(75, 23)
        CancelButton.TabIndex = 8
        CancelButton.Text = "Cancel"
        CancelButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        CancelButton.UseAccentColor = False
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel1.Controls.Add(CancelButton)
        Panel1.Location = New Point(140, 378)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 23)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(ConfirmButton)
        Panel2.Location = New Point(58, 378)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(75, 23)
        Panel2.TabIndex = 10
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(ClearButton)
        Panel3.Location = New Point(184, 315)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 23)
        Panel3.TabIndex = 11
        ' 
        ' FingerprintForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(274, 414)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(fpicture)
        Controls.Add(prompt)
        Controls.Add(deviceSerial)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FingerprintForm"
        PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fingerprint"
        CType(fpicture, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents deviceSerial As Label
    Friend WithEvents prompt As Label
    Friend WithEvents fpicture As PictureBox
    Friend WithEvents ClearButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents ConfirmButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
