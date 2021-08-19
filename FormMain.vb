Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormMain
    Dim ChoosedDepend As New List(Of String)
    Dim DependModifing As Boolean = False

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReflashModInfo()
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
        For i = 0 To ModListWithFullInfo.modid.Count - 1
            CheckedListBoxSelectMods.Items.Add(System.IO.Path.GetFileName(ModListWithFullInfo.moddisplayinfo(ModListWithFullInfo.modid(i)).ModPath))
        Next
    End Sub

    Private Sub CheckedListBoxSelectMods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxSelectMods.SelectedIndexChanged
        LabelModInfo.Text = ""
        For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
            If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = CheckedListBoxSelectMods.SelectedItem Then
                LabelModInfo.Text += "名字 : " & ModListWithFullInfo.moddisplayinfo(modid).displayname & vbCrLf
                LabelModInfo.Text += "介绍 : " & ModListWithFullInfo.moddisplayinfo(modid).displaydescription & vbCrLf
                LabelModInfo.Text += "依赖 : " & ConnectStrArrayToString(ModListWithFullInfo.moddisplayinfo(modid).dependsArray) & vbCrLf & vbCrLf
                LabelModInfo.Text += "id : " & ModListWithFullInfo.moddisplayinfo(modid).id & vbCrLf
                LabelModInfo.Text += "version : " & ModListWithFullInfo.moddisplayinfo(modid).version & vbCrLf
                LabelModInfo.Text += "name : " & ModListWithFullInfo.moddisplayinfo(modid).name & vbCrLf
                LabelModInfo.Text += "author(s) : " & ConnectStrArrayToString(ModListWithFullInfo.moddisplayinfo(modid).authersArray) & vbCrLf
                LabelModInfo.Text += "description : " & ModListWithFullInfo.moddisplayinfo(modid).description
                ModListWithFullInfo.moddisplayinfo(modid).Choosed = CheckedListBoxSelectMods.GetItemChecked(CheckedListBoxSelectMods.SelectedIndex)
            End If
        Next
        ButtonTest1.Text = CheckedListBoxSelectMods.SelectedItem
    End Sub

    Private Sub ButtonMCBBS_Click(sender As Object, e As EventArgs) Handles ButtonMCBBS.Click
        If CheckedListBoxSelectMods.SelectedIndex <> -1 Then
            For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
                If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = CheckedListBoxSelectMods.SelectedItem Then
                    Process.Start("https://search.mcmod.cn/s?key=" & Replace(ModListWithFullInfo.moddisplayinfo(modid).name, "-", ""))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub ButtonCurseForge_Click(sender As Object, e As EventArgs) Handles ButtonCurseForge.Click
        If CheckedListBoxSelectMods.SelectedIndex <> -1 Then
            For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
                If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = CheckedListBoxSelectMods.SelectedItem Then
                    Process.Start("https://www.curseforge.com/minecraft/mc-mods/" & ModListWithFullInfo.moddisplayinfo(modid).name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Buttontest1_Click(sender As Object, e As EventArgs) Handles ButtonTest1.Click
        FormInfoEdit.Show()
    End Sub

    Private Sub ButtonReflashModInfo_Click(sender As Object, e As EventArgs) Handles ButtonReflashModInfo.Click
        ReflashModInfo()
    End Sub

    Private Sub ButtonRemoveUselessDepend_Click(sender As Object, e As EventArgs) Handles ButtonRemoveUselessDepend.Click
        Dim DependToRemove As New List(Of String)
        For Each SingleChoosedDepend In ChoosedDepend
            Dim Useful As Boolean = False
            For Each modid In ModListWithFullInfo.modid
                If ModListWithFullInfo.moddisplayinfo(modid).Choosed = True And ModListWithFullInfo.moddisplayinfo(modid).dependsArray.Contains(SingleChoosedDepend) Then
                    Useful = True
                End If
            Next
            If Useful = False Then
                DependToRemove.Add(SingleChoosedDepend)
            End If
        Next
        For Each modid In DependToRemove
            ChoosedDepend.Remove(modid)
            ModListWithFullInfo.moddisplayinfo(modid).Choosed = False
            DependModifing = True
            CheckedListBoxSelectMods.SetItemChecked(CheckedListBoxSelectMods.FindString(Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath)), False)
            DependModifing = False
        Next
    End Sub

    Private Sub CheckedListBoxSelectMods_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBoxSelectMods.ItemCheck 'the checked status will change after this sub
        If DependModifing = True Then Exit Sub 'Add depends will call this sub, cause Stack Overflow
        For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
            If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = CheckedListBoxSelectMods.SelectedItem Then
                ModListWithFullInfo.moddisplayinfo(modid).Choosed = CheckedListBoxSelectMods.GetItemChecked(CheckedListBoxSelectMods.SelectedIndex)
                If CheckedListBoxSelectMods.GetItemChecked(CheckedListBoxSelectMods.SelectedIndex) = False Then 'the checked status will change after this sub
                    ModListWithFullInfo.moddisplayinfo(modid).Choosed = True
                    If ModListWithFullInfo.moddisplayinfo(modid).dependsArray.Count <> 0 Then
                        DependModifing = True
                        For Each dependsmodid In ModListWithFullInfo.moddisplayinfo(modid).dependsArray
                            ModListWithFullInfo.moddisplayinfo(dependsmodid).Choosed = True
                            CheckedListBoxSelectMods.SetItemChecked(CheckedListBoxSelectMods.FindString(Path.GetFileName(ModListWithFullInfo.moddisplayinfo(dependsmodid).ModPath)), True)
                            If ChoosedDepend.Count = 0 Or Not ChoosedDepend.Contains(dependsmodid) Then
                                ChoosedDepend.Add(dependsmodid) 'prevent duplicate add
                            End If
                        Next
                        DependModifing = False
                    End If
                    Exit For
                ElseIf CheckedListBoxSelectMods.GetItemChecked(CheckedListBoxSelectMods.SelectedIndex) = True Then 'the checked status will change after this sub
                    ModListWithFullInfo.moddisplayinfo(modid).Choosed = False
                End If
            End If
        Next
    End Sub 'the checked status will change after this Sub
End Class