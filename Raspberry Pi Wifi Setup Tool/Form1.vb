Imports System.IO

Public Class Form1
    Dim DrivePath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Raspberry Pi Zero Wifi Setup Tool"
        txtSSID.Text = My.Settings.ssid
        txtPASSWORD.Text = My.Settings.password
        txtWPA.Text = My.Settings.key_mgmt
        txtCountry.Text = My.Settings.country
        chkExit.Checked = My.Settings.checkboxExit
        chkEnableSSH.Checked = My.Settings.checkboxSSH
        GroupBoxSettings.Visible = False
        GroupBoxFind.Visible = False
    End Sub

    Private Sub btnWarning_Click(sender As Object, e As EventArgs) Handles btnWarning.Click
        GroupBoxSettings.Visible = True
        GroupBoxFind.Visible = True
        GroupBoxSettings.Enabled = False
        lblWarningTitle.Visible = False
        lblWarning.Visible = False
    End Sub

    Public Sub loadDrives()
        Dim drive As DriveInfo
        Try
            For Each drive In DriveInfo.GetDrives()
                If drive.DriveType = IO.DriveType.Removable Then
                    Try
                        Dim drvLetter As String = drive.RootDirectory.FullName
                        Dim drvFormat As String = drive.DriveFormat
                        Dim name As String = drive.VolumeLabel
                        Dim size As Double = drive.TotalSize / 1000000
                        ListboxDrives.Items.Add(drvLetter)
                        ListboxDrives.Items.Add(drvFormat)
                        ListboxDrives.Items.Add(name)
                        ListboxDrives.Items.Add(Math.Round(size) & " mb")
                        ListboxDrives.Items.Add("--------------------------------------------------------")
                        cmboDrives.Items.Add(drive.Name)
                    Catch
                    End Try
                End If
            Next
            cmboDrives.SelectedIndex = 0
            GroupBoxSettings.Enabled = True
        Catch ex As Exception
            lblStatus.Text = "Error! Have you plugged in your SD Card?"
        End Try
    End Sub

    Public Sub writeFiles()
        lblStatus.Text = "Writing files now"

        DrivePath = cmboDrives.Text.ToString()
        Try
            Dim lines() As String = {
            "ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev",
            "update_config=1",
            "country=" & txtCountry.Text,
            "network={",
            "ssid=" & Chr(34) & txtSSID.Text & Chr(34),
            "psk=" & Chr(34) & txtPASSWORD.Text & Chr(34),
            "key_mgmt=" & txtWPA.Text,
            "}",
            "#fake network workaround for headless Raspberry Pi Zero",
            "network={",
            "ssid=" & Chr(34) & "fakessid" & Chr(34),
            "psk=" & Chr(34) & "fakepass" & Chr(34),
            "key_mgmt=WPA-PSK",
            "}"
        }

            Using outputFile As New StreamWriter(DrivePath & Convert.ToString("\wpa_supplicant.conf"))
                For Each line As String In lines
                    outputFile.WriteLine(line)
                Next
            End Using

            Dim fileLoc As String = DrivePath & "\ssh"
            File.Create(fileLoc).Close()

        Catch e As Exception
            lblStatus.Text = e.Message

        Finally
            lblStatus.Text = "Successfully written files."
        End Try

        If chkExit.CheckState = CheckState.Checked Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        writeFiles()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.ssid = txtSSID.Text
        My.Settings.password = txtPASSWORD.Text
        My.Settings.key_mgmt = txtWPA.Text
        My.Settings.country = txtCountry.Text
        My.Settings.checkboxExit = chkExit.CheckState
        My.Settings.checkboxSSH = chkEnableSSH.CheckState
        My.Settings.Save()
    End Sub

    Private Sub btnFindDrives_Click(sender As Object, e As EventArgs) Handles btnFindDrives.Click
        loadDrives()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
