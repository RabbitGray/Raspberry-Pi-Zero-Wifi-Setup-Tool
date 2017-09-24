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
        Me.GroupBoxSettings = New System.Windows.Forms.GroupBox()
        Me.txtSSID = New System.Windows.Forms.TextBox()
        Me.txtPASSWORD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.cmboDrives = New System.Windows.Forms.ComboBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkEnableSSH = New System.Windows.Forms.CheckBox()
        Me.txtWPA = New System.Windows.Forms.TextBox()
        Me.ListboxDrives = New System.Windows.Forms.ListBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.GroupBoxSettings.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBoxFind.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxSettings
        '
        Me.GroupBoxSettings.Controls.Add(Me.txtSSID)
        Me.GroupBoxSettings.Controls.Add(Me.txtPASSWORD)
        Me.GroupBoxSettings.Controls.Add(Me.Label1)
        Me.GroupBoxSettings.Controls.Add(Me.Label2)
        Me.GroupBoxSettings.Controls.Add(Me.btnWrite)
        Me.GroupBoxSettings.Controls.Add(Me.cmboDrives)
        Me.GroupBoxSettings.Controls.Add(Me.chkShowPassword)
        Me.GroupBoxSettings.Controls.Add(Me.Label3)
        Me.GroupBoxSettings.Controls.Add(Me.chkEnableSSH)
        Me.GroupBoxSettings.Controls.Add(Me.txtWPA)
        Me.GroupBoxSettings.Controls.Add(Me.ListboxDrives)
        Me.GroupBoxSettings.Controls.Add(Me.txtCountry)
        Me.GroupBoxSettings.Controls.Add(Me.Label5)
        Me.GroupBoxSettings.Controls.Add(Me.Label4)
        Me.GroupBoxSettings.Controls.Add(Me.chkExit)
        Me.GroupBoxSettings.Location = New System.Drawing.Point(12, 70)
        Me.GroupBoxSettings.Name = "GroupBoxSettings"
        Me.GroupBoxSettings.Size = New System.Drawing.Size(328, 317)
        Me.GroupBoxSettings.TabIndex = 24
        Me.GroupBoxSettings.TabStop = False
        Me.GroupBoxSettings.Text = "Settings"
        '
        'txtSSID
        '
        Me.txtSSID.Location = New System.Drawing.Point(121, 18)
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.Size = New System.Drawing.Size(100, 20)
        Me.txtSSID.TabIndex = 0
        '
        'txtPASSWORD
        '
        Me.txtPASSWORD.Location = New System.Drawing.Point(121, 44)
        Me.txtPASSWORD.Name = "txtPASSWORD"
        Me.txtPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPASSWORD.Size = New System.Drawing.Size(100, 20)
        Me.txtPASSWORD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = ""
        Me.Label1.Text = "WIFI SSID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(181, 254)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(115, 36)
        Me.btnWrite.TabIndex = 4
        Me.btnWrite.Text = "Write Files"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'cmboDrives
        '
        Me.cmboDrives.FormattingEnabled = True
        Me.cmboDrives.Location = New System.Drawing.Point(181, 215)
        Me.cmboDrives.Name = "cmboDrives"
        Me.cmboDrives.Size = New System.Drawing.Size(115, 21)
        Me.cmboDrives.TabIndex = 5
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(226, 46)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(86, 17)
        Me.chkShowPassword.TabIndex = 14
        Me.chkShowPassword.Text = "Show / Hide"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Key Mgmt"
        '
        'chkEnableSSH
        '
        Me.chkEnableSSH.AutoSize = True
        Me.chkEnableSSH.Checked = True
        Me.chkEnableSSH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableSSH.Location = New System.Drawing.Point(178, 153)
        Me.chkEnableSSH.Name = "chkEnableSSH"
        Me.chkEnableSSH.Size = New System.Drawing.Size(118, 17)
        Me.chkEnableSSH.TabIndex = 13
        Me.chkEnableSSH.Text = "Enable SSH Server"
        Me.chkEnableSSH.UseVisualStyleBackColor = True
        '
        'txtWPA
        '
        Me.txtWPA.Location = New System.Drawing.Point(121, 70)
        Me.txtWPA.Name = "txtWPA"
        Me.txtWPA.Size = New System.Drawing.Size(100, 20)
        Me.txtWPA.TabIndex = 7
        '
        'ListboxDrives
        '
        Me.ListboxDrives.FormattingEnabled = True
        Me.ListboxDrives.Location = New System.Drawing.Point(17, 153)
        Me.ListboxDrives.Name = "ListboxDrives"
        Me.ListboxDrives.Size = New System.Drawing.Size(120, 147)
        Me.ListboxDrives.TabIndex = 12
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(121, 96)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(50, 20)
        Me.txtCountry.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Selected Drive"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Country Code "
        '
        'chkExit
        '
        Me.chkExit.AutoSize = True
        Me.chkExit.Checked = True
        Me.chkExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExit.Location = New System.Drawing.Point(190, 296)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 402)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(353, 22)
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
        Me.GroupBoxFind.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxFind.Name = "GroupBoxFind"
        Me.GroupBoxFind.Size = New System.Drawing.Size(328, 52)
        Me.GroupBoxFind.TabIndex = 25
        Me.GroupBoxFind.TabStop = False
        Me.GroupBoxFind.Text = "Find"
        '
        'btnWarning
        '
        Me.btnWarning.Location = New System.Drawing.Point(58, 210)
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
        Me.lblWarningTitle.Location = New System.Drawing.Point(130, 9)
        Me.lblWarningTitle.Name = "lblWarningTitle"
        Me.lblWarningTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblWarningTitle.TabIndex = 28
        Me.lblWarningTitle.Text = "WARNING"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(11, 31)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(332, 169)
        Me.lblWarning.TabIndex = 29
        Me.lblWarning.Text = resources.GetString("lblWarning.Text")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(58, 288)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(232, 72)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "I do not agree"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 424)
        Me.Controls.Add(Me.GroupBoxSettings)
        Me.Controls.Add(Me.lblWarningTitle)
        Me.Controls.Add(Me.btnWarning)
        Me.Controls.Add(Me.GroupBoxFind)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBoxSettings.ResumeLayout(False)
        Me.GroupBoxSettings.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBoxFind.ResumeLayout(False)
        Me.GroupBoxFind.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxSettings As GroupBox
    Friend WithEvents txtSSID As TextBox
    Friend WithEvents txtPASSWORD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWrite As Button
    Friend WithEvents cmboDrives As ComboBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkEnableSSH As CheckBox
    Friend WithEvents txtWPA As TextBox
    Friend WithEvents ListboxDrives As ListBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label5 As Label
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
End Class
