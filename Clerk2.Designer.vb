Imports MaterialSkin2Framework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clerk2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clerk2))
        Me.cbPoliceCertify = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbPoliceVerify = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtORAmount = New System.Windows.Forms.TextBox()
        Me.txtORNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtClearanceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCTCIssueAt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtCTCIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCTCNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbPurpose = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbBarangay = New System.Windows.Forms.ComboBox()
        Me.cbZone = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClearanceMname = New System.Windows.Forms.TextBox()
        Me.txtClearanceFname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtClearanceLname = New System.Windows.Forms.TextBox()
        Me.txtClearanceNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialButton5 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.MaterialButton4 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.txtApplicantPendingSearch = New System.Windows.Forms.TextBox()
        Me.dataApplicantPending = New System.Windows.Forms.DataGridView()
        Me.dataPendingClearanceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataPendingClearanceSetBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataPendingClearanceDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialButton6 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.dataApplicantCompleted = New System.Windows.Forms.DataGridView()
        Me.dataCompletedClearanceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearancePrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtApplicantCompletedSearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClear_Cancel = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd_Saved = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MaterialButton2 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.MaterialButton3 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dataApplicantPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataApplicantCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbPoliceCertify
        '
        Me.cbPoliceCertify.FormattingEnabled = True
        Me.cbPoliceCertify.Location = New System.Drawing.Point(15, 580)
        Me.cbPoliceCertify.Name = "cbPoliceCertify"
        Me.cbPoliceCertify.Size = New System.Drawing.Size(471, 23)
        Me.cbPoliceCertify.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 562)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 138
        Me.Label22.Text = "Certified By"
        '
        'cbPoliceVerify
        '
        Me.cbPoliceVerify.FormattingEnabled = True
        Me.cbPoliceVerify.Location = New System.Drawing.Point(15, 531)
        Me.cbPoliceVerify.Name = "cbPoliceVerify"
        Me.cbPoliceVerify.Size = New System.Drawing.Size(471, 23)
        Me.cbPoliceVerify.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 515)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 15)
        Me.Label21.TabIndex = 136
        Me.Label21.Text = "Verified By"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(566, 511)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 20)
        Me.Label20.TabIndex = 132
        Me.Label20.Text = "Signature"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(548, 303)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 20)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "R. Thumbmark"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(574, 94)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 20)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Camera"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(256, 411)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 15)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Amount"
        '
        'txtORAmount
        '
        Me.txtORAmount.Location = New System.Drawing.Point(256, 429)
        Me.txtORAmount.Name = "txtORAmount"
        Me.txtORAmount.PlaceholderText = " Amount*"
        Me.txtORAmount.Size = New System.Drawing.Size(230, 23)
        Me.txtORAmount.TabIndex = 19
        '
        'txtORNo
        '
        Me.txtORNo.Location = New System.Drawing.Point(256, 385)
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.PlaceholderText = " OR Number*"
        Me.txtORNo.Size = New System.Drawing.Size(230, 23)
        Me.txtORNo.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(256, 367)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 15)
        Me.Label17.TabIndex = 122
        Me.Label17.Text = "OR Number"
        '
        'dtClearanceDate
        '
        Me.dtClearanceDate.Enabled = False
        Me.dtClearanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtClearanceDate.Location = New System.Drawing.Point(387, 96)
        Me.dtClearanceDate.Name = "dtClearanceDate"
        Me.dtClearanceDate.Size = New System.Drawing.Size(99, 23)
        Me.dtClearanceDate.TabIndex = 121
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(347, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 15)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Date:"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(336, 285)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PlaceholderText = " Contact Number*"
        Me.txtContactNo.Size = New System.Drawing.Size(150, 23)
        Me.txtContactNo.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(333, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 15)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Contact Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 458)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Issued At"
        '
        'txtCTCIssueAt
        '
        Me.txtCTCIssueAt.Location = New System.Drawing.Point(15, 476)
        Me.txtCTCIssueAt.Name = "txtCTCIssueAt"
        Me.txtCTCIssueAt.PlaceholderText = " Issued At*"
        Me.txtCTCIssueAt.Size = New System.Drawing.Size(230, 23)
        Me.txtCTCIssueAt.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 411)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Issued On"
        '
        'dtCTCIssueDate
        '
        Me.dtCTCIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCTCIssueDate.Location = New System.Drawing.Point(15, 429)
        Me.dtCTCIssueDate.Name = "dtCTCIssueDate"
        Me.dtCTCIssueDate.Size = New System.Drawing.Size(230, 23)
        Me.dtCTCIssueDate.TabIndex = 18
        '
        'txtCTCNo
        '
        Me.txtCTCNo.Location = New System.Drawing.Point(15, 385)
        Me.txtCTCNo.Name = "txtCTCNo"
        Me.txtCTCNo.PlaceholderText = " CTC Number*"
        Me.txtCTCNo.Size = New System.Drawing.Size(230, 23)
        Me.txtCTCNo.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 15)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "CTC Number"
        '
        'cbPurpose
        '
        Me.cbPurpose.FormattingEnabled = True
        Me.cbPurpose.Location = New System.Drawing.Point(15, 335)
        Me.cbPurpose.Name = "cbPurpose"
        Me.cbPurpose.Size = New System.Drawing.Size(471, 23)
        Me.cbPurpose.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Purpose"
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(225, 285)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.PlaceholderText = " Nationality*"
        Me.txtNationality.Size = New System.Drawing.Size(105, 23)
        Me.txtNationality.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Nationality"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(141, 285)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.PlaceholderText = " Height*"
        Me.txtHeight.Size = New System.Drawing.Size(78, 23)
        Me.txtHeight.TabIndex = 12
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(72, 287)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(63, 19)
        Me.rbFemale.TabIndex = 11
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(15, 287)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(51, 19)
        Me.rbMale.TabIndex = 10
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(141, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Height(ft)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(15, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 15)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Date of Birth"
        '
        'dtBirthDate
        '
        Me.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthDate.Location = New System.Drawing.Point(336, 243)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(150, 23)
        Me.dtBirthDate.TabIndex = 9
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Location = New System.Drawing.Point(15, 243)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.PlaceholderText = " Place of Birth*"
        Me.txtBirthPlace.Size = New System.Drawing.Size(274, 23)
        Me.txtBirthPlace.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Place of Birth"
        '
        'cbCivilStatus
        '
        Me.cbCivilStatus.FormattingEnabled = True
        Me.cbCivilStatus.Location = New System.Drawing.Point(336, 199)
        Me.cbCivilStatus.Name = "cbCivilStatus"
        Me.cbCivilStatus.Size = New System.Drawing.Size(150, 23)
        Me.cbCivilStatus.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Civil Status"
        '
        'cbBarangay
        '
        Me.cbBarangay.FormattingEnabled = True
        Me.cbBarangay.Location = New System.Drawing.Point(86, 199)
        Me.cbBarangay.Name = "cbBarangay"
        Me.cbBarangay.Size = New System.Drawing.Size(203, 23)
        Me.cbBarangay.TabIndex = 6
        '
        'cbZone
        '
        Me.cbZone.FormattingEnabled = True
        Me.cbZone.Location = New System.Drawing.Point(15, 199)
        Me.cbZone.Name = "cbZone"
        Me.cbZone.Size = New System.Drawing.Size(68, 23)
        Me.cbZone.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 15)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Address(Zone, Barangay)"
        '
        'txtClearanceMname
        '
        Me.txtClearanceMname.Location = New System.Drawing.Point(336, 150)
        Me.txtClearanceMname.Name = "txtClearanceMname"
        Me.txtClearanceMname.PlaceholderText = " Middle Name*"
        Me.txtClearanceMname.Size = New System.Drawing.Size(150, 23)
        Me.txtClearanceMname.TabIndex = 4
        '
        'txtClearanceFname
        '
        Me.txtClearanceFname.Location = New System.Drawing.Point(180, 150)
        Me.txtClearanceFname.Name = "txtClearanceFname"
        Me.txtClearanceFname.PlaceholderText = " First Name*"
        Me.txtClearanceFname.Size = New System.Drawing.Size(150, 23)
        Me.txtClearanceFname.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(266, 15)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Full Name(Last Name, First Name, Middle Name)"
        '
        'txtClearanceLname
        '
        Me.txtClearanceLname.Location = New System.Drawing.Point(15, 150)
        Me.txtClearanceLname.Name = "txtClearanceLname"
        Me.txtClearanceLname.PlaceholderText = " Last Name*"
        Me.txtClearanceLname.Size = New System.Drawing.Size(150, 23)
        Me.txtClearanceLname.TabIndex = 2
        '
        'txtClearanceNo
        '
        Me.txtClearanceNo.Location = New System.Drawing.Point(102, 95)
        Me.txtClearanceNo.Name = "txtClearanceNo"
        Me.txtClearanceNo.PlaceholderText = "Clearance No. "
        Me.txtClearanceNo.Size = New System.Drawing.Size(95, 23)
        Me.txtClearanceNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Clearance No."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(706, 101)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(623, 575)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MaterialButton5)
        Me.TabPage1.Controls.Add(Me.MaterialButton4)
        Me.TabPage1.Controls.Add(Me.txtApplicantPendingSearch)
        Me.TabPage1.Controls.Add(Me.dataApplicantPending)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(615, 547)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pending"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MaterialButton5
        '
        Me.MaterialButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton5.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton5.Depth = 0
        Me.MaterialButton5.HighEmphasis = True
        Me.MaterialButton5.Icon = CType(resources.GetObject("MaterialButton5.Icon"), System.Drawing.Image)
        Me.MaterialButton5.Location = New System.Drawing.Point(508, 7)
        Me.MaterialButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialButton5.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton5.Name = "MaterialButton5"
        Me.MaterialButton5.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton5.Size = New System.Drawing.Size(94, 36)
        Me.MaterialButton5.TabIndex = 3
        Me.MaterialButton5.Text = "Clear"
        Me.MaterialButton5.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton5.UseAccentColor = False
        Me.MaterialButton5.UseVisualStyleBackColor = True
        '
        'MaterialButton4
        '
        Me.MaterialButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton4.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton4.Depth = 0
        Me.MaterialButton4.HighEmphasis = True
        Me.MaterialButton4.Icon = CType(resources.GetObject("MaterialButton4.Icon"), System.Drawing.Image)
        Me.MaterialButton4.Location = New System.Drawing.Point(1067, 7)
        Me.MaterialButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialButton4.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton4.Name = "MaterialButton4"
        Me.MaterialButton4.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton4.Size = New System.Drawing.Size(94, 36)
        Me.MaterialButton4.TabIndex = 148
        Me.MaterialButton4.Text = "Clear"
        Me.MaterialButton4.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton4.UseAccentColor = False
        Me.MaterialButton4.UseVisualStyleBackColor = True
        '
        'txtApplicantPendingSearch
        '
        Me.txtApplicantPendingSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplicantPendingSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtApplicantPendingSearch.Location = New System.Drawing.Point(222, 13)
        Me.txtApplicantPendingSearch.Multiline = True
        Me.txtApplicantPendingSearch.Name = "txtApplicantPendingSearch"
        Me.txtApplicantPendingSearch.PlaceholderText = "  Search..."
        Me.txtApplicantPendingSearch.Size = New System.Drawing.Size(279, 29)
        Me.txtApplicantPendingSearch.TabIndex = 2
        '
        'dataApplicantPending
        '
        Me.dataApplicantPending.AllowUserToAddRows = False
        Me.dataApplicantPending.AllowUserToDeleteRows = False
        Me.dataApplicantPending.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataApplicantPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicantPending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataPendingClearanceID, Me.dataPendingClearanceNo, Me.dataPendingClearanceFname, Me.dataPendingClearanceMname, Me.dataPendingClearanceLname, Me.dataPendingClearanceStatus, Me.dataPendingClearanceEdit, Me.dataPendingClearanceSetBtn, Me.dataPendingClearanceDelete})
        Me.dataApplicantPending.Location = New System.Drawing.Point(4, 49)
        Me.dataApplicantPending.Name = "dataApplicantPending"
        Me.dataApplicantPending.ReadOnly = True
        Me.dataApplicantPending.RowTemplate.Height = 25
        Me.dataApplicantPending.Size = New System.Drawing.Size(608, 501)
        Me.dataApplicantPending.TabIndex = 142
        '
        'dataPendingClearanceID
        '
        Me.dataPendingClearanceID.HeaderText = "ClearanceID"
        Me.dataPendingClearanceID.Name = "dataPendingClearanceID"
        Me.dataPendingClearanceID.ReadOnly = True
        '
        'dataPendingClearanceNo
        '
        Me.dataPendingClearanceNo.HeaderText = "Clearance Number"
        Me.dataPendingClearanceNo.Name = "dataPendingClearanceNo"
        Me.dataPendingClearanceNo.ReadOnly = True
        Me.dataPendingClearanceNo.Width = 130
        '
        'dataPendingClearanceFname
        '
        Me.dataPendingClearanceFname.HeaderText = "  First Name"
        Me.dataPendingClearanceFname.Name = "dataPendingClearanceFname"
        Me.dataPendingClearanceFname.ReadOnly = True
        '
        'dataPendingClearanceMname
        '
        Me.dataPendingClearanceMname.HeaderText = "      Middle Name"
        Me.dataPendingClearanceMname.Name = "dataPendingClearanceMname"
        Me.dataPendingClearanceMname.ReadOnly = True
        Me.dataPendingClearanceMname.Width = 120
        '
        'dataPendingClearanceLname
        '
        Me.dataPendingClearanceLname.HeaderText = "      Last Name"
        Me.dataPendingClearanceLname.Name = "dataPendingClearanceLname"
        Me.dataPendingClearanceLname.ReadOnly = True
        Me.dataPendingClearanceLname.Width = 120
        '
        'dataPendingClearanceStatus
        '
        Me.dataPendingClearanceStatus.HeaderText = "           Status"
        Me.dataPendingClearanceStatus.Name = "dataPendingClearanceStatus"
        Me.dataPendingClearanceStatus.ReadOnly = True
        '
        'dataPendingClearanceEdit
        '
        Me.dataPendingClearanceEdit.HeaderText = ""
        Me.dataPendingClearanceEdit.Name = "dataPendingClearanceEdit"
        Me.dataPendingClearanceEdit.ReadOnly = True
        Me.dataPendingClearanceEdit.Text = "Edit"
        Me.dataPendingClearanceEdit.UseColumnTextForButtonValue = True
        '
        'dataPendingClearanceSetBtn
        '
        Me.dataPendingClearanceSetBtn.HeaderText = ""
        Me.dataPendingClearanceSetBtn.Name = "dataPendingClearanceSetBtn"
        Me.dataPendingClearanceSetBtn.ReadOnly = True
        Me.dataPendingClearanceSetBtn.Text = ""
        '
        'dataPendingClearanceDelete
        '
        Me.dataPendingClearanceDelete.HeaderText = ""
        Me.dataPendingClearanceDelete.Name = "dataPendingClearanceDelete"
        Me.dataPendingClearanceDelete.ReadOnly = True
        Me.dataPendingClearanceDelete.Text = "Delete"
        Me.dataPendingClearanceDelete.UseColumnTextForButtonValue = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MaterialButton6)
        Me.TabPage2.Controls.Add(Me.dataApplicantCompleted)
        Me.TabPage2.Controls.Add(Me.txtApplicantCompletedSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(615, 547)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Completed"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaterialButton6
        '
        Me.MaterialButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton6.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton6.Depth = 0
        Me.MaterialButton6.HighEmphasis = True
        Me.MaterialButton6.Icon = CType(resources.GetObject("MaterialButton6.Icon"), System.Drawing.Image)
        Me.MaterialButton6.Location = New System.Drawing.Point(508, 7)
        Me.MaterialButton6.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialButton6.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton6.Name = "MaterialButton6"
        Me.MaterialButton6.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton6.Size = New System.Drawing.Size(94, 36)
        Me.MaterialButton6.TabIndex = 5
        Me.MaterialButton6.Text = "Clear"
        Me.MaterialButton6.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton6.UseAccentColor = False
        Me.MaterialButton6.UseVisualStyleBackColor = True
        '
        'dataApplicantCompleted
        '
        Me.dataApplicantCompleted.AllowUserToAddRows = False
        Me.dataApplicantCompleted.AllowUserToDeleteRows = False
        Me.dataApplicantCompleted.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataApplicantCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicantCompleted.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataCompletedClearanceID, Me.dataCompletedClearanceNo, Me.dataCompletedClearanceFname, Me.dataCompletedClearanceMname, Me.dataCompletedClearanceLname, Me.dataCompletedClearanceStatus, Me.dataCompletedClearancePrint})
        Me.dataApplicantCompleted.Location = New System.Drawing.Point(4, 49)
        Me.dataApplicantCompleted.Name = "dataApplicantCompleted"
        Me.dataApplicantCompleted.ReadOnly = True
        Me.dataApplicantCompleted.RowTemplate.Height = 25
        Me.dataApplicantCompleted.Size = New System.Drawing.Size(608, 501)
        Me.dataApplicantCompleted.TabIndex = 150
        '
        'dataCompletedClearanceID
        '
        Me.dataCompletedClearanceID.HeaderText = "ClearanceID"
        Me.dataCompletedClearanceID.Name = "dataCompletedClearanceID"
        Me.dataCompletedClearanceID.ReadOnly = True
        '
        'dataCompletedClearanceNo
        '
        Me.dataCompletedClearanceNo.HeaderText = "Clearance Number"
        Me.dataCompletedClearanceNo.Name = "dataCompletedClearanceNo"
        Me.dataCompletedClearanceNo.ReadOnly = True
        Me.dataCompletedClearanceNo.Width = 130
        '
        'dataCompletedClearanceFname
        '
        Me.dataCompletedClearanceFname.HeaderText = "  First Name"
        Me.dataCompletedClearanceFname.Name = "dataCompletedClearanceFname"
        Me.dataCompletedClearanceFname.ReadOnly = True
        '
        'dataCompletedClearanceMname
        '
        Me.dataCompletedClearanceMname.HeaderText = "      Middle Name"
        Me.dataCompletedClearanceMname.Name = "dataCompletedClearanceMname"
        Me.dataCompletedClearanceMname.ReadOnly = True
        Me.dataCompletedClearanceMname.Width = 120
        '
        'dataCompletedClearanceLname
        '
        Me.dataCompletedClearanceLname.HeaderText = "      Last Name"
        Me.dataCompletedClearanceLname.Name = "dataCompletedClearanceLname"
        Me.dataCompletedClearanceLname.ReadOnly = True
        Me.dataCompletedClearanceLname.Width = 114
        '
        'dataCompletedClearanceStatus
        '
        Me.dataCompletedClearanceStatus.HeaderText = "           Status"
        Me.dataCompletedClearanceStatus.Name = "dataCompletedClearanceStatus"
        Me.dataCompletedClearanceStatus.ReadOnly = True
        Me.dataCompletedClearanceStatus.Width = 120
        '
        'dataCompletedClearancePrint
        '
        Me.dataCompletedClearancePrint.HeaderText = ""
        Me.dataCompletedClearancePrint.Name = "dataCompletedClearancePrint"
        Me.dataCompletedClearancePrint.ReadOnly = True
        Me.dataCompletedClearancePrint.Text = "Print"
        Me.dataCompletedClearancePrint.UseColumnTextForButtonValue = True
        '
        'txtApplicantCompletedSearch
        '
        Me.txtApplicantCompletedSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplicantCompletedSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtApplicantCompletedSearch.Location = New System.Drawing.Point(222, 13)
        Me.txtApplicantCompletedSearch.Name = "txtApplicantCompletedSearch"
        Me.txtApplicantCompletedSearch.PlaceholderText = "  Search..."
        Me.txtApplicantCompletedSearch.Size = New System.Drawing.Size(279, 29)
        Me.txtApplicantCompletedSearch.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 64)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1329, 28)
        Me.MenuStrip1.TabIndex = 141
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Image = CType(resources.GetObject("ReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(528, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 142
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(528, 326)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 143
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(528, 533)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 144
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnClear_Cancel)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(246, 622)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(132, 25)
        Me.Panel3.TabIndex = 146
        '
        'btnClear_Cancel
        '
        Me.btnClear_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClear_Cancel.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClear_Cancel.Depth = 0
        Me.btnClear_Cancel.HighEmphasis = False
        Me.btnClear_Cancel.Icon = Nothing
        Me.btnClear_Cancel.Location = New System.Drawing.Point(0, 0)
        Me.btnClear_Cancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClear_Cancel.MaximumSize = New System.Drawing.Size(132, 25)
        Me.btnClear_Cancel.MinimumSize = New System.Drawing.Size(132, 25)
        Me.btnClear_Cancel.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnClear_Cancel.Name = "btnClear_Cancel"
        Me.btnClear_Cancel.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClear_Cancel.Size = New System.Drawing.Size(132, 25)
        Me.btnClear_Cancel.TabIndex = 55
        Me.btnClear_Cancel.Text = "Clear"
        Me.btnClear_Cancel.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnClear_Cancel.UseAccentColor = False
        Me.btnClear_Cancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnAdd_Saved)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(84, 622)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 25)
        Me.Panel1.TabIndex = 145
        '
        'btnAdd_Saved
        '
        Me.btnAdd_Saved.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdd_Saved.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd_Saved.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnAdd_Saved.Depth = 0
        Me.btnAdd_Saved.DrawShadows = False
        Me.btnAdd_Saved.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd_Saved.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAdd_Saved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAdd_Saved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd_Saved.ForeColor = System.Drawing.Color.White
        Me.btnAdd_Saved.HighEmphasis = False
        Me.btnAdd_Saved.Icon = Nothing
        Me.btnAdd_Saved.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd_Saved.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAdd_Saved.MaximumSize = New System.Drawing.Size(132, 25)
        Me.btnAdd_Saved.MinimumSize = New System.Drawing.Size(132, 25)
        Me.btnAdd_Saved.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnAdd_Saved.Name = "btnAdd_Saved"
        Me.btnAdd_Saved.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnAdd_Saved.Size = New System.Drawing.Size(132, 25)
        Me.btnAdd_Saved.TabIndex = 53
        Me.btnAdd_Saved.Text = "Add"
        Me.btnAdd_Saved.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnAdd_Saved.UseAccentColor = False
        Me.btnAdd_Saved.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.MaterialButton1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(567, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 23)
        Me.Panel2.TabIndex = 146
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.MaterialButton1.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
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
        Me.MaterialButton1.MaximumSize = New System.Drawing.Size(75, 23)
        Me.MaterialButton1.MinimumSize = New System.Drawing.Size(75, 23)
        Me.MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(75, 23)
        Me.MaterialButton1.TabIndex = 53
        Me.MaterialButton1.Text = "Upload"
        Me.MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.MaterialButton2)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(567, 482)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(75, 23)
        Me.Panel4.TabIndex = 147
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.MaterialButton2.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.MaterialButton2.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.DrawShadows = False
        Me.MaterialButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.MaterialButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MaterialButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.MaterialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialButton2.ForeColor = System.Drawing.Color.White
        Me.MaterialButton2.HighEmphasis = False
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(0, 0)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MaximumSize = New System.Drawing.Size(75, 23)
        Me.MaterialButton2.MinimumSize = New System.Drawing.Size(75, 23)
        Me.MaterialButton2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(75, 23)
        Me.MaterialButton2.TabIndex = 53
        Me.MaterialButton2.Text = "Upload"
        Me.MaterialButton2.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Controls.Add(Me.MaterialButton3)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(567, 691)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(75, 23)
        Me.Panel5.TabIndex = 148
        '
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.MaterialButton3.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.MaterialButton3.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.DrawShadows = False
        Me.MaterialButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.MaterialButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MaterialButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.MaterialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialButton3.ForeColor = System.Drawing.Color.White
        Me.MaterialButton3.HighEmphasis = False
        Me.MaterialButton3.Icon = Nothing
        Me.MaterialButton3.Location = New System.Drawing.Point(0, 0)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MaximumSize = New System.Drawing.Size(75, 23)
        Me.MaterialButton3.MinimumSize = New System.Drawing.Size(75, 23)
        Me.MaterialButton3.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton3.Size = New System.Drawing.Size(75, 23)
        Me.MaterialButton3.TabIndex = 54
        Me.MaterialButton3.Text = "Upload"
        Me.MaterialButton3.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(168, 159)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 15)
        Me.Label23.TabIndex = 149
        Me.Label23.Text = ","
        '
        'Clerk2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 730)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cbPoliceCertify)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbPoliceVerify)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtORAmount)
        Me.Controls.Add(Me.txtORNo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtClearanceDate)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCTCIssueAt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtCTCIssueDate)
        Me.Controls.Add(Me.txtCTCNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbPurpose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtBirthDate)
        Me.Controls.Add(Me.txtBirthPlace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbCivilStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbBarangay)
        Me.Controls.Add(Me.cbZone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClearanceMname)
        Me.Controls.Add(Me.txtClearanceFname)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtClearanceLname)
        Me.Controls.Add(Me.txtClearanceNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Clerk2"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.Text = "Clerk"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dataApplicantPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataApplicantCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPoliceCertify As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbPoliceVerify As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtORAmount As TextBox
    Friend WithEvents txtORNo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtClearanceDate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCTCIssueAt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtCTCIssueDate As DateTimePicker
    Friend WithEvents txtCTCNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbPurpose As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtBirthDate As DateTimePicker
    Friend WithEvents txtBirthPlace As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCivilStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbBarangay As ComboBox
    Friend WithEvents cbZone As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClearanceMname As TextBox
    Friend WithEvents txtClearanceFname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtClearanceLname As TextBox
    Friend WithEvents txtClearanceNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtApplicantPendingSearch As TextBox
    Friend WithEvents dataApplicantPending As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtApplicantCompletedSearch As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dataApplicantCompleted As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClear_Cancel As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd_Saved As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MaterialButton2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents MaterialButton3 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Label23 As Label
    Friend WithEvents MaterialButton4 As MaterialButton
    Friend WithEvents MaterialButton5 As MaterialButton
    Friend WithEvents MaterialButton6 As MaterialButton
    Friend WithEvents dataCompletedClearanceID As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceNo As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceFname As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceMname As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceLname As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceStatus As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearancePrint As DataGridViewButtonColumn
    Friend WithEvents dataPendingClearanceID As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceNo As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceFname As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceMname As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceLname As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceStatus As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceEdit As DataGridViewButtonColumn
    Friend WithEvents dataPendingClearanceSetBtn As DataGridViewButtonColumn
    Friend WithEvents dataPendingClearanceDelete As DataGridViewButtonColumn
End Class
