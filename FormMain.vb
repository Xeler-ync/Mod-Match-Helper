Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormMain
    Dim ModSourceInfo(,), ModDisplayInfo(,) As String


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

    Private Sub ReflashModInfo()
        ModListWithFullInfo = ReflashNewAllModInfo(ModListWithFullInfo)
        ModListWithFullInfo = ReadModIntroductionjson(ModListWithFullInfo)
        For i = 0 To ModListWithFullInfo.modid.Count
            CheckedListBoxSelectMods.Items.Add(System.IO.Path.GetFileName(ModListWithFullInfo.moddisplayinfo(ModListWithFullInfo.modid(i)).ModPath))
        Next
    End Sub

    Private Sub CheckedListBoxSelectMods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxSelectMods.SelectedIndexChanged
        LabelModInfo.Text = ""
        For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
            If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = CheckedListBoxSelectMods.SelectedItem Then 'save input
                LabelModInfo.Text += "displayname : " & ModListWithFullInfo.moddisplayinfo(modid).displayname & vbCrLf
                LabelModInfo.Text += "displaydescription : " & ModListWithFullInfo.moddisplayinfo(modid).displaydescription & vbCrLf
                LabelModInfo.Text += "depend(s) : " & ConnectStrArrayToString(ModListWithFullInfo.moddisplayinfo(modid).dependsArray) & vbCrLf
                LabelModInfo.Text += "id : " & ModListWithFullInfo.moddisplayinfo(modid).id & vbCrLf
                LabelModInfo.Text += "version : " & ModListWithFullInfo.moddisplayinfo(modid).version & vbCrLf
                LabelModInfo.Text += "name : " & ModListWithFullInfo.moddisplayinfo(modid).name & vbCrLf
                LabelModInfo.Text += "author(s) : " & ConnectStrArrayToString(ModListWithFullInfo.moddisplayinfo(modid).authersArray) & vbCrLf
                LabelModInfo.Text += "description : " & ModListWithFullInfo.moddisplayinfo(modid).description
                Exit For
            End If
        Next
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        ReflashModInfo()
    End Sub

    Private Sub ButtonMCBBS_Click(sender As Object, e As EventArgs) Handles ButtonMCBBS.Click
        If CheckedListBoxSelectMods.SelectedIndex <> -1 Then
            Process.Start("https://search.mcmod.cn/s?key=" & Replace(ModSourceInfo(CheckedListBoxSelectMods.SelectedIndex, 1), "-", ""）)
        End If
    End Sub

    Private Sub ButtonCurseForge_Click(sender As Object, e As EventArgs) Handles ButtonCurseForge.Click
        If CheckedListBoxSelectMods.SelectedIndex <> -1 Then
            Process.Start("https://www.curseforge.com/minecraft/mc-mods/" & ModSourceInfo(CheckedListBoxSelectMods.SelectedIndex, 1))
        End If
    End Sub

    Private Sub Buttontest1_Click(sender As Object, e As EventArgs) Handles ButtonTest1.Click
        FormInfoEdit.Show()
    End Sub

    Private Sub Buttontest2_Click(sender As Object, e As EventArgs) Handles Buttontest2.Click
        Dim depends As String
        depends = ExtractModRelyFromIntroductionjsonContent("K:\Code\Git\Mod-Match-Helper\bin\Debug\MMH\temp\test.json")
        MsgBox(depends)
    End Sub
End Class