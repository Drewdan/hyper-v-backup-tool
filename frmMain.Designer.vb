<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vmTable = New System.Windows.Forms.DataGridView()
        Me.vmname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vmpath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vmstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vmuptime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboVMList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fbdSaveLocation = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtBackupSaveLocation = New System.Windows.Forms.TextBox()
        Me.btnSaveLocation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRunBackup = New System.Windows.Forms.Button()
        Me.tmrVMList = New System.Windows.Forms.Timer(Me.components)
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.prgBackupProgress = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.vmTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FleToolStripMenuItem
        '
        Me.FleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FleToolStripMenuItem.Name = "FleToolStripMenuItem"
        Me.FleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FleToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'vmTable
        '
        Me.vmTable.AllowUserToAddRows = False
        Me.vmTable.AllowUserToDeleteRows = False
        Me.vmTable.AllowUserToResizeColumns = False
        Me.vmTable.AllowUserToResizeRows = False
        Me.vmTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.vmTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.vmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.vmTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vmname, Me.vmpath, Me.vmstatus, Me.vmuptime})
        Me.vmTable.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.vmTable.Location = New System.Drawing.Point(32, 40)
        Me.vmTable.MultiSelect = False
        Me.vmTable.Name = "vmTable"
        Me.vmTable.ReadOnly = True
        Me.vmTable.RowHeadersVisible = False
        Me.vmTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.vmTable.ShowCellErrors = False
        Me.vmTable.ShowCellToolTips = False
        Me.vmTable.ShowEditingIcon = False
        Me.vmTable.ShowRowErrors = False
        Me.vmTable.Size = New System.Drawing.Size(741, 139)
        Me.vmTable.TabIndex = 2
        '
        'vmname
        '
        Me.vmname.HeaderText = "VM Name"
        Me.vmname.Name = "vmname"
        Me.vmname.ReadOnly = True
        '
        'vmpath
        '
        Me.vmpath.HeaderText = "VM Path"
        Me.vmpath.Name = "vmpath"
        Me.vmpath.ReadOnly = True
        '
        'vmstatus
        '
        Me.vmstatus.HeaderText = "VM Status"
        Me.vmstatus.Name = "vmstatus"
        Me.vmstatus.ReadOnly = True
        '
        'vmuptime
        '
        Me.vmuptime.HeaderText = "VM Uptime"
        Me.vmuptime.Name = "vmuptime"
        Me.vmuptime.ReadOnly = True
        '
        'cboVMList
        '
        Me.cboVMList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVMList.FormattingEnabled = True
        Me.cboVMList.Location = New System.Drawing.Point(158, 201)
        Me.cboVMList.Name = "cboVMList"
        Me.cboVMList.Size = New System.Drawing.Size(615, 21)
        Me.cboVMList.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select VM To Backup: "
        '
        'txtBackupSaveLocation
        '
        Me.txtBackupSaveLocation.Location = New System.Drawing.Point(158, 233)
        Me.txtBackupSaveLocation.Name = "txtBackupSaveLocation"
        Me.txtBackupSaveLocation.Size = New System.Drawing.Size(436, 20)
        Me.txtBackupSaveLocation.TabIndex = 5
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(601, 233)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(172, 23)
        Me.btnSaveLocation.TabIndex = 6
        Me.btnSaveLocation.Text = "Browse"
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Backup Location: "
        '
        'btnRunBackup
        '
        Me.btnRunBackup.Location = New System.Drawing.Point(158, 263)
        Me.btnRunBackup.Name = "btnRunBackup"
        Me.btnRunBackup.Size = New System.Drawing.Size(614, 27)
        Me.btnRunBackup.TabIndex = 8
        Me.btnRunBackup.Text = "Run Backup"
        Me.btnRunBackup.UseVisualStyleBackColor = True
        '
        'tmrVMList
        '
        Me.tmrVMList.Interval = 10000
        '
        'prgBackupProgress
        '
        Me.prgBackupProgress.Location = New System.Drawing.Point(158, 296)
        Me.prgBackupProgress.Name = "prgBackupProgress"
        Me.prgBackupProgress.Size = New System.Drawing.Size(614, 23)
        Me.prgBackupProgress.TabIndex = 9
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 384)
        Me.Controls.Add(Me.prgBackupProgress)
        Me.Controls.Add(Me.btnRunBackup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSaveLocation)
        Me.Controls.Add(Me.txtBackupSaveLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboVMList)
        Me.Controls.Add(Me.vmTable)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Hyper-V Backup Facility"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.vmTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents vmTable As DataGridView
    Friend WithEvents vmname As DataGridViewTextBoxColumn
    Friend WithEvents vmpath As DataGridViewTextBoxColumn
    Friend WithEvents vmstatus As DataGridViewTextBoxColumn
    Friend WithEvents vmuptime As DataGridViewTextBoxColumn
    Friend WithEvents cboVMList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fbdSaveLocation As FolderBrowserDialog
    Friend WithEvents txtBackupSaveLocation As TextBox
    Friend WithEvents btnSaveLocation As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRunBackup As Button
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrVMList As Timer
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents prgBackupProgress As ProgressBar
End Class
