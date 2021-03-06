﻿Imports System.ComponentModel
Imports System.IO

Public Class Form1
    Dim SupportedFormats As String() = {"xps", "pdf", "jpg", "jpeg", "svg", "png", "webp", "gif", "htm", "html"}
    Dim Watchers As New List(Of FileSystemWatcher)
    Dim WatchersOn As Boolean = True
    Dim WatchersOff As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MakeWatchers()

    End Sub



    Sub MakeWatchers()
        For Each format As String In SupportedFormats
            MsgBox(format)
            Dim fsw As New FileSystemWatcher
            With fsw
                .Path = "C:\"
                .IncludeSubdirectories = False
                .Filter = "*." & format
                .NotifyFilter = (NotifyFilters.FileName Or NotifyFilters.LastAccess Or NotifyFilters.LastWrite)
                .EnableRaisingEvents = False

            End With

            Watchers.Add(fsw)
        Next

    End Sub

    Sub ControlWatchers(OnOff As Boolean)
        For Each Watcher In Watchers

            Select Case OnOff
                Case WatchersOn
                    Watcher.Path = My.Settings.WatchFolder
                    Watcher.EnableRaisingEvents = True
                    AddHandler Watcher.Created, AddressOf NewFile
                Case WatchersOff
                    Watcher.EnableRaisingEvents = False
                    RemoveHandler Watcher.Created, AddressOf NewFile
            End Select
        Next
    End Sub

    Private Sub NewFile(sender As Object, e As FileSystemEventArgs)
        MsgBox("triggered")
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
            'MsgBox("Printing " & e.FullPath)

#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            PrintProcess.Start(PrintProcessStartInfo)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Start_Watching(sender As Object, e As EventArgs) Handles Me.Load, btnStart.Click
        Select Case My.Computer.FileSystem.DirectoryExists(My.Settings.WatchFolder)
            Case True
                ControlWatchers(WatchersOn)

                btnStart.Enabled = False

            Case False
                Try
                    ControlWatchers(WatchersOff)
                Catch ex As Exception
                    ' don't need to do anything here...
                End Try
                btnStart.Enabled = True
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
