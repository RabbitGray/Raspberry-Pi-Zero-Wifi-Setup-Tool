<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBoxDrive = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmboDrives = New System.Windows.Forms.ComboBox()
        Me.txtSSID = New System.Windows.Forms.TextBox()
        Me.txtPASSWORD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWPA = New System.Windows.Forms.TextBox()
        Me.ListboxDrives = New System.Windows.Forms.ListBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.chkEnableSSH = New System.Windows.Forms.CheckBox()
        Me.chkExit = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFindDrives = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBoxFind = New System.Windows.Forms.GroupBox()
        Me.btnWarning = New System.Windows.Forms.Button()
        Me.lblWarningTitle = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBoxSettings = New System.Windows.Forms.GroupBox()
        Me.chkStorePassword = New System.Windows.Forms.CheckBox()
        Me.chkSSIDHidden = New System.Windows.Forms.CheckBox()
        Me.GroupBoxWrite = New System.Windows.Forms.GroupBox()
        Me.GroupBoxWarning = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDrive.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBoxFind.SuspendLayout()
        Me.GroupBoxSettings.SuspendLayout()
        Me.GroupBoxWrite.SuspendLayout()
        Me.GroupBoxWarning.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxDrive
        '
        Me.GroupBoxDrive.Controls.Add(Me.Label6)
        Me.GroupBoxDrive.Controls.Add(Me.cmboDrives)
        Me.GroupBoxDrive.Controls.Add(Me.txtSSID)
        Me.GroupBoxDrive.Controls.Add(Me.txtPASSWORD)
        Me.GroupBoxDrive.Controls.Add(Me.Label1)
        Me.GroupBoxDrive.Controls.Add(Me.Label2)
        Me.GroupBoxDrive.Controls.Add(Me.Label3)
        Me.GroupBoxDrive.Controls.Add(Me.txtWPA)
        Me.GroupBoxDrive.Controls.Add(Me.ListboxDrives)
        Me.GroupBoxDrive.Controls.Add(Me.txtCountry)
        Me.GroupBoxDrive.Controls.Add(Me.Label4)
        Me.GroupBoxDrive.Location = New System.Drawing.Point(15, 70)
        Me.GroupBoxDrive.Name = "GroupBoxDrive"
        Me.GroupBoxDrive.Size = New System.Drawing.Size(328, 347)
        Me.GroupBoxDrive.TabIndex = 24
        Me.GroupBoxDrive.TabStop = False
        Me.GroupBoxDrive.Text = "Settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Selected Drive"
        '
        'cmboDrives
        '
        Me.cmboDrives.FormattingEnabled = True
        Me.cmboDrives.Location = New System.Drawing.Point(121, 296)
        Me.cmboDrives.Name = "cmboDrives"
        Me.cmboDrives.Size = New System.Drawing.Size(142, 21)
        Me.cmboDrives.TabIndex = 5
        '
        'txtSSID
        '
        Me.txtSSID.Location = New System.Drawing.Point(121, 28)
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.Size = New System.Drawing.Size(142, 20)
        Me.txtSSID.TabIndex = 0
        '
        'txtPASSWORD
        '
        Me.txtPASSWORD.Location = New System.Drawing.Point(121, 54)
        Me.txtPASSWORD.Name = "txtPASSWORD"
        Me.txtPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPASSWORD.Size = New System.Drawing.Size(142, 20)
        Me.txtPASSWORD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = ""
        Me.Label1.Text = "WIFI SSID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Key Mgmt"
        '
        'txtWPA
        '
        Me.txtWPA.Location = New System.Drawing.Point(121, 80)
        Me.txtWPA.Name = "txtWPA"
        Me.txtWPA.Size = New System.Drawing.Size(142, 20)
        Me.txtWPA.TabIndex = 7
        '
        'ListboxDrives
        '
        Me.ListboxDrives.FormattingEnabled = True
        Me.ListboxDrives.Location = New System.Drawing.Point(121, 143)
        Me.ListboxDrives.Name = "ListboxDrives"
        Me.ListboxDrives.Size = New System.Drawing.Size(142, 147)
        Me.ListboxDrives.TabIndex = 12
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(121, 106)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(72, 20)
        Me.txtCountry.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Country Code "
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(40, 26)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(115, 36)
        Me.btnWrite.TabIndex = 4
        Me.btnWrite.Text = "Write Files"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'chkEnableSSH
        '
        Me.chkEnableSSH.AutoSize = True
        Me.chkEnableSSH.Checked = True
        Me.chkEnableSSH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableSSH.Location = New System.Drawing.Point(29, 43)
        Me.chkEnableSSH.Name = "chkEnableSSH"
        Me.chkEnableSSH.Size = New System.Drawing.Size(118, 17)
        Me.chkEnableSSH.TabIndex = 13
        Me.chkEnableSSH.Text = "Enable SSH Server"
        Me.chkEnableSSH.UseVisualStyleBackColor = True
        '
        'chkExit
        '
        Me.chkExit.AutoSize = True
        Me.chkExit.Checked = True
        Me.chkExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExit.Location = New System.Drawing.Point(44, 79)
        Me.chkExit.Name = "chkExit"
        Me.chkExit.Size = New System.Drawing.Size(103, 17)
        Me.chkExit.TabIndex = 10
        Me.chkExit.Text = "Exit after Writing"
        Me.chkExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Find SD Cards ->"
        '
        'btnFindDrives
        '
        Me.btnFindDrives.Location = New System.Drawing.Point(143, 14)
        Me.btnFindDrives.Name = "btnFindDrives"
        Me.btnFindDrives.Size = New System.Drawing.Size(135, 32)
        Me.btnFindDrives.TabIndex = 22
        Me.btnFindDrives.Text = "Find SD / USB"
        Me.btnFindDrives.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(563, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBoxFind
        '
        Me.GroupBoxFind.Controls.Add(Me.btnFindDrives)
        Me.GroupBoxFind.Controls.Add(Me.Label7)
        Me.GroupBoxFind.Location = New System.Drawing.Point(15, 12)
        Me.GroupBoxFind.Name = "GroupBoxFind"
        Me.GroupBoxFind.Size = New System.Drawing.Size(328, 52)
        Me.GroupBoxFind.TabIndex = 25
        Me.GroupBoxFind.TabStop = False
        Me.GroupBoxFind.Text = "Find"
        '
        'btnWarning
        '
        Me.btnWarning.Location = New System.Drawing.Point(105, 204)
        Me.btnWarning.Name = "btnWarning"
        Me.btnWarning.Size = New System.Drawing.Size(232, 72)
        Me.btnWarning.TabIndex = 27
        Me.btnWarning.Text = "I understant the risk and wish to continue."
        Me.btnWarning.UseVisualStyleBackColor = True
        '
        'lblWarningTitle
        '
        Me.lblWarningTitle.AutoSize = True
        Me.lblWarningTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblWarningTitle.Location = New System.Drawing.Point(187, 16)
        Me.lblWarningTitle.Name = "lblWarningTitle"
        Me.lblWarningTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblWarningTitle.TabIndex = 28
        Me.lblWarningTitle.Text = "WARNING"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(58, 32)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(332, 169)
        Me.lblWarning.TabIndex = 29
        Me.lblWarning.Text = resources.GetString("lblWarning.Text")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(105, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(232, 72)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "I do not agree"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBoxSettings
        '
        Me.GroupBoxSettings.Controls.Add(Me.chkStorePassword)
        Me.GroupBoxSettings.Controls.Add(Me.chkSSIDHidden)
        Me.GroupBoxSettings.Controls.Add(Me.chkEnableSSH)
        Me.GroupBoxSettings.Location = New System.Drawing.Point(349, 12)
        Me.GroupBoxSettings.Name = "GroupBoxSettings"
        Me.GroupBoxSettings.Size = New System.Drawing.Size(200, 184)
        Me.GroupBoxSettings.TabIndex = 31
        Me.GroupBoxSettings.TabStop = False
        Me.GroupBoxSettings.Text = "Optional Settings"
        '
        'chkStorePassword
        '
        Me.chkStorePassword.AutoSize = True
        Me.chkStorePassword.Location = New System.Drawing.Point(29, 89)
        Me.chkStorePassword.Name = "chkStorePassword"
        Me.chkStorePassword.Size = New System.Drawing.Size(126, 17)
        Me.chkStorePassword.TabIndex = 15
        Me.chkStorePassword.Text = "Dont Store Password"
        Me.chkStorePassword.UseVisualStyleBackColor = True
        '
        'chkSSIDHidden
        '
        Me.chkSSIDHidden.AutoSize = True
        Me.chkSSIDHidden.Checked = True
        Me.chkSSIDHidden.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSSIDHidden.Location = New System.Drawing.Point(29, 66)
        Me.chkSSIDHidden.Name = "chkSSIDHidden"
        Me.chkSSIDHidden.Size = New System.Drawing.Size(98, 17)
        Me.chkSSIDHidden.TabIndex = 14
        Me.chkSSIDHidden.Text = "SSID is Hidden"
        Me.chkSSIDHidden.UseVisualStyleBackColor = True
        '
        'GroupBoxWrite
        '
        Me.GroupBoxWrite.Controls.Add(Me.btnWrite)
        Me.GroupBoxWrite.Controls.Add(Me.chkExit)
        Me.GroupBoxWrite.Location = New System.Drawing.Point(349, 300)
        Me.GroupBoxWrite.Name = "GroupBoxWrite"
        Me.GroupBoxWrite.Size = New System.Drawing.Size(200, 117)
        Me.GroupBoxWrite.TabIndex = 32
        Me.GroupBoxWrite.TabStop = False
        Me.GroupBoxWrite.Text = "Write Files"
        '
        'GroupBoxWarning
        '
        Me.GroupBoxWarning.Controls.Add(Me.lblWarning)
        Me.GroupBoxWarning.Controls.Add(Me.btnExit)
        Me.GroupBoxWarning.Controls.Add(Me.btnWarning)
        Me.GroupBoxWarning.Controls.Add(Me.lblWarningTitle)
        Me.GroupBoxWarning.Location = New System.Drawing.Point(58, 12)
        Me.GroupBoxWarning.Name = "GroupBoxWarning"
        Me.GroupBoxWarning.Size = New System.Drawing.Size(431, 366)
        Me.GroupBoxWarning.TabIndex = 33
        Me.GroupBoxWarning.TabStop = False
        Me.GroupBoxWarning.Text = "Warning"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 442)
        Me.Controls.Add(Me.GroupBoxWrite)
        Me.Controls.Add(Me.GroupBoxSettings)
        Me.Controls.Add(Me.GroupBoxDrive)
        Me.Controls.Add(Me.GroupBoxFind)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBoxWarning)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBoxDrive.ResumeLayout(False)
        Me.GroupBoxDrive.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBoxFind.ResumeLayout(False)
        Me.GroupBoxFind.PerformLayout()
        Me.GroupBoxSettings.ResumeLayout(False)
        Me.GroupBoxSettings.PerformLayout()
        Me.GroupBoxWrite.ResumeLayout(False)
        Me.GroupBoxWrite.PerformLayout()
        Me.GroupBoxWarning.ResumeLayout(False)
        Me.GroupBoxWarning.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxDrive As GroupBox
    Friend WithEvents txtSSID As TextBox
    Friend WithEvents txtPASSWORD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWrite As Button
    Friend WithEvents cmboDrives As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkEnableSSH As CheckBox
    Friend WithEvents txtWPA As TextBox
    Friend WithEvents ListboxDrives As ListBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkExit As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnFindDrives As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents GroupBoxFind As GroupBox
    Friend WithEvents btnWarning As Button
    Friend WithEvents lblWarningTitle As Label
    Friend WithEvents lblWarning As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBoxSettings As GroupBox
    Friend WithEvents chkSSIDHidden As CheckBox
    Friend WithEvents chkStorePassword As CheckBox
    Friend WithEvents GroupBoxWrite As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBoxWarning As GroupBox
End Class
