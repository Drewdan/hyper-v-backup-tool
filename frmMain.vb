Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResolveVMs()

        cboVMList.SelectedIndex = 0
        'enable the timer so the list gets refreshed at an interval
        ' tmrVMList.Enabled = True

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tmrVMList_Tick(sender As Object, e As EventArgs) Handles tmrVMList.Tick
        ResolveVMs()
    End Sub
    Public Function PopulateComboBox(list As String)
        cboVMList.Items.Add(list)
        Return True
    End Function
    Public Function ResolveVMs()
        Dim results = runPowerShellCommand("Get-VM")

        ' convert the script result into a single string
        Dim MyStringBuilder As New StringBuilder()
        Dim lines As String()
        'clear the table list
        vmTable.Rows.Clear()
        'clear the combo box
        cboVMList.Items.Clear()

        For Each obj As PSObject In results
            Dim row As String() = New String() {obj.BaseObject.Name, obj.BaseObject.HardDrives(0).Path, obj.BaseObject.State.ToString, obj.BaseObject.Uptime.ToString}
            vmTable.Rows.Add(row)
            PopulateComboBox(obj.BaseObject.Name)

            'MyStringBuilder.AppendLine(obj.ToString())
        Next
    End Function
    Public Function runPowerShellCommand(cmd As String, Optional human As Boolean = False)
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' open it
        MyRunSpace.Open()

        ' create a pipeline and feed it the script text
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        MyPipeline.Commands.AddScript(cmd)

        ' add an extra command to transform the script output objects into nicely formatted strings
        ' remove this line to get the actual objects that the script returns. For example, the script
        ' "Get-Process" returns a collection of System.Diagnostics.Process instances.
        If (human = True) Then
            MyPipeline.Commands.Add("Out-String")
        End If


        ' execute the script
        Dim results As Collection(Of PSObject) = MyPipeline.Invoke()

        ' close the runspace
        MyRunSpace.Close()

        Return results
    End Function

    Private Sub btnSaveLocation_Click(sender As Object, e As EventArgs) Handles btnSaveLocation.Click
        If (fbdSaveLocation.ShowDialog() = DialogResult.OK) Then
            txtBackupSaveLocation.Text = fbdSaveLocation.SelectedPath
        End If
    End Sub

    Private Sub btnRunBackup_Click(sender As Object, e As EventArgs) Handles btnRunBackup.Click
        'this will run the backup
        If (txtBackupSaveLocation.Text = "" Or Directory.Exists(txtBackupSaveLocation.Text) = False) Then
            MsgBox("Please select a valid backup location!", MsgBoxStyle.Critical)
            Return
        Else
            Dim result = MsgBox("Do you wish to backup the selected Virtual Machine?", MsgBoxStyle.YesNo)
            If result = DialogResult.No Then
                MsgBox("Backup Cancelled", MsgBoxStyle.Information)
                Return
            End If
        End If
        'validation checks have all passed, on we continue with the backup
        'firstly we need to stop the virtual machine
        prgBackupProgress.Value() = 10
        Dim command As String = "Stop-VM -Name """ + cboVMList.SelectedItem + """"
        'Dim response = runPowerShellCommand(command, True)

        prgBackupProgress.Value() = 25

        'get the vhd path
        command = "Get-VM -Name """ + cboVMList.SelectedItem + """"
        Dim response = runPowerShellCommand(command, False)



        For Each obj As PSObject In response
            For Each HardDrive In obj.BaseObject.HardDrives
                Dim filePath As String = HardDrive.Path

                Dim directoryPath As String = Path.GetDirectoryName(filePath)
                Dim hardDriveFile As String = filePath.Replace(directoryPath + "\", "")

                Dim timestamp As String = CLng(DateTime.Now.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)

                Dim NewFileName = timestamp + "-backup-" + hardDriveFile
                Dim backupPath = txtBackupSaveLocation.Text + "\" + NewFileName

                'copy the file
                My.Computer.FileSystem.CopyFile(
                filePath,
                backupPath)

            Next
        Next



            'then copy the vhd to the selected directory

            'when we are done we need to start the virtual machine again
            command = "Start-VM -Name """ + cboVMList.SelectedItem + """"
        response = runPowerShellCommand(command, True)

        prgBackupProgress.Value() = 100
        MsgBox("Backup Complete", MsgBoxStyle.Information)

    End Sub
End Class
