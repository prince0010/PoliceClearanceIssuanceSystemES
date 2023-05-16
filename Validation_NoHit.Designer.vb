<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Validation_NoHit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Validation_NoHit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(13, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(592, 32)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "No Criminal/Derogatory Record on file as of this Date!"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(-1, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(616, 56)
        Me.Panel2.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(162, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(306, 30)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "No Record Found in Database"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CancelButton)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(330, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 33)
        Me.Panel3.TabIndex = 58
        '
        'CancelButton
        '
        Me.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.CancelButton.Depth = 0
        Me.CancelButton.HighEmphasis = False
        Me.CancelButton.Icon = Nothing
        Me.CancelButton.Location = New System.Drawing.Point(0, 0)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CancelButton.MaximumSize = New System.Drawing.Size(75, 33)
        Me.CancelButton.MinimumSize = New System.Drawing.Size(75, 33)
        Me.CancelButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.CancelButton.Size = New System.Drawing.Size(75, 33)
        Me.CancelButton.TabIndex = 55
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.CancelButton.UseAccentColor = False
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.MaterialButton1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(229, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 33)
        Me.Panel1.TabIndex = 57
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.MaterialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.DrawShadows = False
        Me.MaterialButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.MaterialButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MaterialButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.MaterialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialButton1.ForeColor = System.Drawing.Color.White
        Me.MaterialButton1.HighEmphasis = False
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MaximumSize = New System.Drawing.Size(75, 33)
        Me.MaterialButton1.MinimumSize = New System.Drawing.Size(75, 33)
        Me.MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(75, 33)
        Me.MaterialButton1.TabIndex = 53
        Me.MaterialButton1.Text = "Save"
        Me.MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-1, 116)
        Me.MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(616, 3)
        Me.MaterialDivider1.TabIndex = 59
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(-1, 63)
        Me.MaterialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(616, 3)
        Me.MaterialDivider2.TabIndex = 60
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'Validation_NoHit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Validation_NoHit"
        Me.Text = "Validation_NoHit"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin2Framework.Controls.MaterialDivider
End Class
