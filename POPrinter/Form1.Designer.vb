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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbPrintNew = New System.Windows.Forms.CheckBox()
        Me.tbWatchFolder = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.XPSWatcher = New System.IO.FileSystemWatcher()
        Me.PDFWatcher = New System.IO.FileSystemWatcher()
        Me.JPGWatcher = New System.IO.FileSystemWatcher()
        Me.NotifyMenu.SuspendLayout()
        CType(Me.XPSWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDFWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JPGWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Watch Folder:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(268, 13)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.NotifyMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "PO Printer"
        Me.NotifyIcon.Visible = True
        '
        'NotifyMenu
        '
        Me.NotifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHideToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.NotifyMenu.Name = "NotifyMenu"
        Me.NotifyMenu.Size = New System.Drawing.Size(140, 48)
        '
        'ShowHideToolStripMenuItem
        '
        Me.ShowHideToolStripMenuItem.Name = "ShowHideToolStripMenuItem"
        Me.ShowHideToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ShowHideToolStripMenuItem.Text = "Show / Hide"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'cbPrintNew
        '
        Me.cbPrintNew.AutoSize = True
        Me.cbPrintNew.Checked = Global.POPrinter.My.MySettings.Default.PrintNew
        Me.cbPrintNew.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPrintNew.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.POPrinter.My.MySettings.Default, "PrintNew", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbPrintNew.Location = New System.Drawing.Point(92, 41)
        Me.cbPrintNew.Name = "cbPrintNew"
        Me.cbPrintNew.Size = New System.Drawing.Size(91, 17)
        Me.cbPrintNew.TabIndex = 6
        Me.cbPrintNew.Text = "Print new files"
        Me.cbPrintNew.UseVisualStyleBackColor = True
        '
        'tbWatchFolder
        '
        Me.tbWatchFolder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.POPrinter.My.MySettings.Default, "WatchFolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbWatchFolder.Location = New System.Drawing.Point(92, 15)
        Me.tbWatchFolder.Name = "tbWatchFolder"
        Me.tbWatchFolder.ReadOnly = True
        Me.tbWatchFolder.Size = New System.Drawing.Size(170, 20)
        Me.tbWatchFolder.TabIndex = 4
        Me.tbWatchFolder.Text = Global.POPrinter.My.MySettings.Default.WatchFolder
        Me.tbWatchFolder.WordWrap = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(271, 62)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'XPSWatcher
        '
        Me.XPSWatcher.EnableRaisingEvents = True
        Me.XPSWatcher.Filter = "*.xps"
        Me.XPSWatcher.NotifyFilter = CType(((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.LastWrite) _
            Or System.IO.NotifyFilters.LastAccess), System.IO.NotifyFilters)
        Me.XPSWatcher.SynchronizingObject = Me
        '
        'PDFWatcher
        '
        Me.PDFWatcher.EnableRaisingEvents = True
        Me.PDFWatcher.Filter = "*.pdf"
        Me.PDFWatcher.NotifyFilter = CType(((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.LastWrite) _
            Or System.IO.NotifyFilters.LastAccess), System.IO.NotifyFilters)
        Me.PDFWatcher.SynchronizingObject = Me
        '
        'JPGWatcher
        '
        Me.JPGWatcher.EnableRaisingEvents = True
        Me.JPGWatcher.Filter = "*.jpg"
        Me.JPGWatcher.NotifyFilter = CType(((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.LastWrite) _
            Or System.IO.NotifyFilters.LastAccess), System.IO.NotifyFilters)
        Me.JPGWatcher.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 97)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cbPrintNew)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbWatchFolder)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PO Printer"
        Me.NotifyMenu.ResumeLayout(False)
        CType(Me.XPSWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDFWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JPGWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbWatchFolder As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents cbPrintNew As CheckBox
    Friend WithEvents fbd As FolderBrowserDialog
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents NotifyMenu As ContextMenuStrip
    Friend WithEvents ShowHideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStart As Button
    Friend WithEvents XPSWatcher As IO.FileSystemWatcher
    Friend WithEvents PDFWatcher As IO.FileSystemWatcher
    Friend WithEvents JPGWatcher As IO.FileSystemWatcher
End Class
