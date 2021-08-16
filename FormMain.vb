Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormMain
    Dim ModSourceInfo(,) As String
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Function RunCmd(ByVal StrCommand As String) As String
        Dim cmd As New Process
        With cmd.StartInfo
            .FileName = "cmd.exe"
            .Arguments = "/c " + StrCommand
            .UseShellExecute = False
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        cmd.Start()
        Dim result As String = cmd.StandardOutput.ReadToEnd()
        cmd.Close()
        Return result
    End Function

    Private Sub CheckedListBoxSelectMods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxSelectMods.SelectedIndexChanged
        LabelModInfo.Text = "id : " & ModSourceInfo(CheckedListBoxSelectMods.SelectedIndex, 1) & vbCrLf
        LabelModInfo.Text += "version : " & ModSourceInfo(CheckedListBoxSelectMods.SelectedIndex, 2) & vbCrLf
        LabelModInfo.Text += "name : " & ModSourceInfo(CheckedListBoxSelectMods.SelectedIndex, 3) & vbCrLf
        LabelModInfo.Text += "author(s) : " & ModSourceInfo(CheckedListBoxSelectMods.SelectedIndex, 5) & vbCrLf
        LabelModInfo.Text += "description : " & ModSourceInfo(CheckedListBoxSelectMods.SelectedIndex, 4)
    End Sub

    Public Sub ReflashModInfo()
        ModSourceInfo = ReflashNewAllModInfo()
        For i = 0 To UBound(ModSourceInfo)
            CheckedListBoxSelectMods.Items.Add(System.IO.Path.GetFileName(ModSourceInfo(i, 0)))
        Next
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        ReflashModInfo()
    End Sub

    Private Sub Buttontest1_Click(sender As Object, e As EventArgs) Handles ButtonTest1.Click
        FormInfoEdit.Show()
    End Sub
End Class