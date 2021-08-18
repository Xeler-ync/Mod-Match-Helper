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
        ModSourceInfo = ReflashNewAllModInfo()
        ModDisplayInfo = ReadModIntroductionjson()
        For i = 0 To UBound(ModSourceInfo)
            CheckedListBoxSelectMods.Items.Add(System.IO.Path.GetFileName(ModSourceInfo(i, 0)))
        Next
    End Sub

    Private Sub CheckedListBoxSelectMods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxSelectMods.SelectedIndexChanged
        LabelModInfo.Text = ""
        Dim ModSourceInfoDisplayIndex, ModIntroduceInfoDisplayIndex As Byte
        For ModSourceInfoDisplayIndex = 0 To UBound(ModSourceInfo) 'find which index of content from source json can match the SelectedIndex
            If Path.GetFileName(ModSourceInfo(ModSourceInfoDisplayIndex, 0)) = CheckedListBoxSelectMods.SelectedItem Then
                Exit For
            End If
        Next
        Try
            For ModIntroduceInfoDisplayIndex = 0 To UBound(ModSourceInfo) 'find which index of content from introduce json can match the SelectedIndex
                If ModDisplayInfo(ModIntroduceInfoDisplayIndex, 0) = ModSourceInfo(ModSourceInfoDisplayIndex, 1) Then
                    Exit For
                End If
            Next
        Catch
            ModIntroduceInfoDisplayIndex = 233 '反正返回啥下面都会catch
        End Try
        Dim displayname, displaydescription As String
        Try
            displayname = ModDisplayInfo(ModIntroduceInfoDisplayIndex, 1)
        Catch
            displayname = ""
        End Try
        Try
            displaydescription = ModDisplayInfo(ModIntroduceInfoDisplayIndex, 2)
        Catch
            displaydescription = ""
        End Try
        LabelModInfo.Text += "名字 : " & displayname & vbCrLf
        LabelModInfo.Text += "介绍 : " & displaydescription & vbCrLf
        LabelModInfo.Text += "依赖 : " & ModSourceInfo(ModSourceInfoDisplayIndex, 6) & vbCrLf
        LabelModInfo.Text += "id : " & ModSourceInfo(ModSourceInfoDisplayIndex, 1) & vbCrLf
        LabelModInfo.Text += "version : " & ModSourceInfo(ModSourceInfoDisplayIndex, 2) & vbCrLf
        LabelModInfo.Text += "name : " & ModSourceInfo(ModSourceInfoDisplayIndex, 3) & vbCrLf
        LabelModInfo.Text += "author(s) : " & ModSourceInfo(ModSourceInfoDisplayIndex, 5) & vbCrLf
        LabelModInfo.Text += "description : " & ModSourceInfo(ModSourceInfoDisplayIndex, 4)
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