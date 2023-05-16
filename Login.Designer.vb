<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MaterialSkin2Framework.Controls.MaterialForm
    'Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPassword = New MaterialSkin2Framework.Controls.MaterialTextBox2()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtUser = New MaterialSkin2Framework.Controls.MaterialTextBox2()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 559)
        Me.Panel1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(32, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 30)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "El Salvador City"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(32, 328)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(287, 51)
        Me.Panel5.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(64, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Police Station"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(47, 45)
        Me.Panel6.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel7.Location = New System.Drawing.Point(7, 7)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(32, 32)
        Me.Panel7.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(26, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(596, 50)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Police Clearance Issuance System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(657, 64)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 559)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(108, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'btnLogin
        '
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLogin.Depth = 0
        Me.btnLogin.HighEmphasis = True
        Me.btnLogin.Icon = Nothing
        Me.btnLogin.Location = New System.Drawing.Point(23, 357)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(10, 6, 4, 6)
        Me.btnLogin.MaximumSize = New System.Drawing.Size(240, 50)
        Me.btnLogin.MinimumSize = New System.Drawing.Size(286, 38)
        Me.btnLogin.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLogin.Size = New System.Drawing.Size(286, 38)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLogin.UseAccentColor = False
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Location = New System.Drawing.Point(22, 283)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(287, 55)
        Me.Panel3.TabIndex = 15
        '
        'txtPassword
        '
        Me.txtPassword.AnimateReadOnly = False
        Me.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPassword.Depth = 0
        Me.txtPassword.ErrorMessage = "Password not Match"
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPassword.HelperText = "Enter Your Password"
        Me.txtPassword.HideSelection = True
        Me.txtPassword.Hint = "Enter Password"
        Me.txtPassword.LeadingIcon = CType(resources.GetObject("txtPassword.LeadingIcon"), System.Drawing.Image)
        Me.txtPassword.Location = New System.Drawing.Point(6, 3)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.MouseState = MaterialSkin2Framework.MouseState.OUT
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PrefixSuffixText = Nothing
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(278, 48)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TabStop = False
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TrailingIcon = Nothing
        Me.txtPassword.UseAccent = False
        Me.txtPassword.UseSystemPasswordChar = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.txtUser)
        Me.Panel11.Location = New System.Drawing.Point(22, 210)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(287, 55)
        Me.Panel11.TabIndex = 14
        '
        'txtUser
        '
        Me.txtUser.AnimateReadOnly = False
        Me.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUser.Depth = 0
        Me.txtUser.ErrorMessage = "The User is Not Yet Exist"
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUser.HelperText = "Enter Your Username"
        Me.txtUser.HideSelection = True
        Me.txtUser.Hint = "Enter Username"
        Me.txtUser.LeadingIcon = CType(resources.GetObject("txtUser.LeadingIcon"), System.Drawing.Image)
        Me.txtUser.Location = New System.Drawing.Point(6, 3)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.MouseState = MaterialSkin2Framework.MouseState.OUT
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PrefixSuffixText = Nothing
        Me.txtUser.ReadOnly = False
        Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(278, 48)
        Me.txtUser.TabIndex = 0
        Me.txtUser.TabStop = False
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUser.TrailingIcon = Nothing
        Me.txtUser.UseAccent = False
        Me.txtUser.UseSystemPasswordChar = False
        '
        'Login
        '
        Me.ClientSize = New System.Drawing.Size(987, 626)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Police Clearance Issuance System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtUser As MaterialSkin2Framework.Controls.MaterialTextBox2
    Friend WithEvents txtPassword As MaterialSkin2Framework.Controls.MaterialTextBox2
    Friend WithEvents btnLogin As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
End Class
