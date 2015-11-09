<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.NotifyMenu.SuspendLayout()
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
End Class
