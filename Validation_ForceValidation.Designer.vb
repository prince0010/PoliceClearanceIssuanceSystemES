<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Validation_ForceValidation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Validation_ForceValidation))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CrimeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CrimeFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeOffense = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeCCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeISNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumberRecords = New System.Windows.Forms.Label()
        Me.chkRemarks = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.chkCriminalRecord = New System.Windows.Forms.CheckBox()
        Me.MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin2Framework.Controls.MaterialButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CrimeID, Me.CrimeCheckBox, Me.CrimeFname, Me.CrimeMname, Me.CrimeLname, Me.CrimeOffense, Me.CrimeCCNO, Me.CrimeISNO, Me.CrimeRemarks})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(10, 116)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(789, 213)
        Me.DataGridView1.TabIndex = 0
        '
        'CrimeID
        '
        Me.CrimeID.HeaderText = "Column1"
        Me.CrimeID.Name = "CrimeID"
        Me.CrimeID.Visible = False
        '
        'CrimeCheckBox
        '
        Me.CrimeCheckBox.HeaderText = ""
        Me.CrimeCheckBox.Name = "CrimeCheckBox"
        Me.CrimeCheckBox.Width = 30
        '
        'CrimeFname
        '
        Me.CrimeFname.HeaderText = "  First Name"
        Me.CrimeFname.Name = "CrimeFname"
        '
        'CrimeMname
        '
        Me.CrimeMname.HeaderText = "Middle Name"
        Me.CrimeMname.Name = "CrimeMname"
        '
        'CrimeLname
        '
        Me.CrimeLname.HeaderText = "   Last Name"
        Me.CrimeLname.Name = "CrimeLname"
        '
        'CrimeOffense
        '
        Me.CrimeOffense.HeaderText = " Crime Offense"
        Me.CrimeOffense.Name = "CrimeOffense"
        '
        'CrimeCCNO
        '
        Me.CrimeCCNO.HeaderText = "  CC NO."
        Me.CrimeCCNO.Name = "CrimeCCNO"
        '
        'CrimeISNO
        '
        Me.CrimeISNO.HeaderText = "  IS NO."
        Me.CrimeISNO.Name = "CrimeISNO"
        '
        'CrimeRemarks
        '
        Me.CrimeRemarks.HeaderText = "  Remarks"
        Me.CrimeRemarks.Name = "CrimeRemarks"
        Me.CrimeRemarks.Width = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(274, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 30)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Record Found in Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(7, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Records Matched:"
        '
        'lblNumberRecords
        '
        Me.lblNumberRecords.AutoSize = True
        Me.lblNumberRecords.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumberRecords.Location = New System.Drawing.Point(118, 96)
        Me.lblNumberRecords.Name = "lblNumberRecords"
        Me.lblNumberRecords.Size = New System.Drawing.Size(15, 17)
        Me.lblNumberRecords.TabIndex = 59
        Me.lblNumberRecords.Text = "0"
        '
        'chkRemarks
        '
        Me.chkRemarks.AutoSize = True
        Me.chkRemarks.Checked = True
        Me.chkRemarks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRemarks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkRemarks.Location = New System.Drawing.Point(10, 332)
        Me.chkRemarks.Name = "chkRemarks"
        Me.chkRemarks.Size = New System.Drawing.Size(105, 21)
        Me.chkRemarks.TabIndex = 60
        Me.chkRemarks.Text = "Add Remarks"
        Me.chkRemarks.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 356)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(729, 48)
        Me.RichTextBox1.TabIndex = 61
        Me.RichTextBox1.Text = ""
        '
        'chkCriminalRecord
        '
        Me.chkCriminalRecord.AutoSize = True
        Me.chkCriminalRecord.Checked = True
        Me.chkCriminalRecord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCriminalRecord.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkCriminalRecord.Location = New System.Drawing.Point(12, 72)
        Me.chkCriminalRecord.Name = "chkCriminalRecord"
        Me.chkCriminalRecord.Size = New System.Drawing.Size(142, 21)
        Me.chkCriminalRecord.TabIndex = 62
        Me.chkCriminalRecord.Text = "Set Criminal Record"
        Me.chkCriminalRecord.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.MaterialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaterialButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(747, 356)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MaximumSize = New System.Drawing.Size(54, 48)
        Me.MaterialButton1.MinimumSize = New System.Drawing.Size(54, 48)
        Me.MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(54, 48)
        Me.MaterialButton1.TabIndex = 64
        Me.MaterialButton1.Text = "Clear"
        Me.MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.MaterialButton2.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(382, 412)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MaximumSize = New System.Drawing.Size(75, 26)
        Me.MaterialButton2.MinimumSize = New System.Drawing.Size(75, 26)
        Me.MaterialButton2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(75, 26)
        Me.MaterialButton2.TabIndex = 65
        Me.MaterialButton2.Text = "Confirm"
        Me.MaterialButton2.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'Validation_ForceValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 449)
        Me.Controls.Add(Me.MaterialButton2)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.chkCriminalRecord)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.chkRemarks)
        Me.Controls.Add(Me.lblNumberRecords)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Validation_ForceValidation"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumberRecords As Label
    Friend WithEvents chkRemarks As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents chkCriminalRecord As CheckBox
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents CrimeID As DataGridViewTextBoxColumn
    Friend WithEvents CrimeCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents CrimeFname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeMname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeLname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeOffense As DataGridViewTextBoxColumn
    Friend WithEvents CrimeCCNO As DataGridViewTextBoxColumn
    Friend WithEvents CrimeISNO As DataGridViewTextBoxColumn
    Friend WithEvents CrimeRemarks As DataGridViewTextBoxColumn
End Class
