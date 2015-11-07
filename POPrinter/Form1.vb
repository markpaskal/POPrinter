Imports System.ComponentModel
Imports System.IO

Public Class Form1

    Private Sub NewFile(sender As Object, e As FileSystemEventArgs) Handles XPSWatcher.Created, PDFWatcher.Created, JPGWatcher.Created
        Dim PrintProcess As New Process
        Dim PrintProcessStartInfo As New ProcessStartInfo


        With PrintProcessStartInfo
            .Verb = "print"
            .FileName = e.FullPath
        End With

        Try
            Do Until System.DateTime.Now >= FileSystem.FileDateTime(e.FullPath).AddSeconds(1)
                System.Threading.Thread.Sleep(1000)
            Loop
            MsgBox("Printing " & e.FullPath)
            PrintProcess.Start(PrintProcessStartInfo)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Start_Watching(sender As Object, e As EventArgs) Handles Me.Load, btnStart.Click
        Select Case My.Computer.FileSystem.DirectoryExists(My.Settings.WatchFolder)
            Case True

                'todo: use a list and a loop to get this done, create the watchers in the method that geneerates the list.

                XPSWatcher.Path = My.Settings.WatchFolder
                XPSWatcher.EnableRaisingEvents = True

                PDFWatcher.Path = My.Settings.WatchFolder
                PDFWatcher.EnableRaisingEvents = True

                JPGWatcher.Path = My.Settings.WatchFolder
                JPGWatcher.EnableRaisingEvents = True

                btnStart.Enabled = False
            Case False
                Select Case sender.Equals(Me)
                    Case True
                        MsgBox(My.Resources.WelcomeText1 & vbNewLine & My.Resources.WelcomeText2, MsgBoxStyle.Information)
                    Case False
                        MsgBox(My.Resources.OnLoadErrorText, MsgBoxStyle.Exclamation)
                End Select
        End Select

    End Sub

    Private Sub OpenBrowseDiaglog(sender As Object, e As EventArgs) Handles btnBrowse.Click
        fbd.ShowDialog()
        My.Settings.WatchFolder = fbd.SelectedPath

    End Sub

    Private Sub HideShowForm(sender As Object, e As EventArgs) Handles ShowHideToolStripMenuItem.Click, NotifyIcon.DoubleClick

        Select Case Me.Visible
            Case True
                Me.Hide()
            Case False
                Me.Show()
        End Select
    End Sub

    Private Sub Window_Closing(sender As Object, e As CancelEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
        NotifyIcon.ShowBalloonTip(3000, "I'm down here!", "PO Printer lives in the tray until you close via the menu.", ToolTipIcon.Info)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        RemoveHandler Me.FormClosing, AddressOf Window_Closing
        Me.Close()
    End Sub
End Class
