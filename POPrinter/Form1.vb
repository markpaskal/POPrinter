﻿Imports System.ComponentModel
Imports System.IO

Public Class Form1

    Private Sub NewFile(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Dim PrintProcess As New Process
        Dim PrintProcessStartInfo As New ProcessStartInfo


        With PrintProcessStartInfo
            .CreateNoWindow = True
            .Verb = "print"
            .FileName = e.FullPath
        End With

        Try
            Do Until System.DateTime.Now >= FileSystem.FileDateTime(e.FullPath).AddSeconds(1)
                System.Threading.Thread.Sleep(1000)
            Loop

            PrintProcess.Start()
            PrintProcess.WaitForExit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Start_Watching(sender As Object, e As EventArgs) Handles Me.Load, btnStart.Click
        Select Case My.Computer.FileSystem.DirectoryExists(My.Settings.WatchFolder)
            Case True

                FileSystemWatcher1.Path = My.Settings.WatchFolder
                FileSystemWatcher1.EnableRaisingEvents = True
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