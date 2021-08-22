Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormMain
    Dim LastFirstRank As Byte
    Dim LastSelectModID As String
    ReadOnly ChoosedDepend As New List(Of String)
    Dim DependModifing As Boolean = False
    Dim FormPositionOriginalX, FormPositionNowX, FormPositionOriginalY, FormPositionNowY As Integer

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Visible = False
        ReflashModInfo()
        AllPredefinedSelect = ReadAllEasyModeSetting(AllPredefinedSelect)
        Dim PicturePathList() As String = ListFileNameInFloder(Application.StartupPath & "\MMH\background\", {".jpg", ".png"})
        Randomize()
        Dim TargetPicturePath As String
        TargetPicturePath = PicturePathList(Int(Rnd() * 114514 Mod 2))
        Me.BackgroundImage = Image.FromFile(TargetPicturePath)
        GroupBoxAdvancedMode.BackColor = Color.FromArgb(0, 255, 255, 255) ''
        LabelModInfo.BackColor = Color.FromArgb(127, 255, 255, 255)
        LabelClickMCbaike.BackColor = Color.FromArgb(127, 255, 255, 255)
        LabelClickCurseForge.BackColor = Color.FromArgb(127, 255, 255, 255)
        PanelMoveForm.BackColor = Color.FromArgb(127, 255, 255, 255)
        CheckBoxMod0.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod1.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod2.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod3.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod4.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod5.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod6.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod7.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod8.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod9.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod10.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod11.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod12.BackColor = Color.FromArgb(0, 255, 255, 255)
        CheckBoxMod13.BackColor = Color.FromArgb(0, 255, 255, 255)
        GroupBoxModList.BackColor = Color.FromArgb(127, 255, 255, 255)
        GroupBoxCheckBoxModList.BackColor = Color.FromArgb(127, 255, 255, 255)
        LabelMMH.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod0.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod1.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod2.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod3.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod4.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod5.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod6.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod7.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod8.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod9.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod10.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod11.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod12.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelMod13.BackColor = Color.FromArgb(0, 255, 255, 255)
        GroupBoxEasyMode.BackColor = Color.FromArgb(127, 255, 255, 255) ''
        LabelSelectedSettingsDescription.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelSelectedSettingsName.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelClickNextSettings.BackColor = Color.FromArgb(0, 255, 255, 255)
        LabelClickPreviousSettings.BackColor = Color.FromArgb(0, 255, 255, 255)
        Me.Visible = True
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
        VScrollBarModList.Value = 0
        If ModListWithFullInfo.modid.Count < 15 Then
            VScrollBarModList.Visible = False
        Else
            VScrollBarModList.Visible = True
        End If
        ReflashDisplayContentFromModListWithFullInfo(0)
    End Sub

    Private Sub ReflashDisplayContentFromModListWithFullInfo(FirstShowModRank As Byte)
        Dim WorkingRank As Byte = FirstShowModRank
        For i = 0 To GroupBoxModList.Controls.Count - 1
            Dim ShowText As String
            ShowText = Path.GetFileName(ModListWithFullInfo.moddisplayinfo(ModListWithFullInfo.modid(WorkingRank)).ModPath)
            GroupBoxModList.Controls(GroupBoxModList.Controls.Count - 1 - i).Text = ShowText '天知道为什么这玩意是反的，非得这么搞
            WorkingRank += 1
            If WorkingRank > ModListWithFullInfo.modid.Count - 1 Then Exit For
        Next
        CheckBoxMod0.Text = LabelMod0.Text
        CheckBoxMod1.Text = LabelMod1.Text
        CheckBoxMod2.Text = LabelMod2.Text
        CheckBoxMod3.Text = LabelMod3.Text
        CheckBoxMod4.Text = LabelMod4.Text
        CheckBoxMod5.Text = LabelMod5.Text
        CheckBoxMod6.Text = LabelMod6.Text
        CheckBoxMod7.Text = LabelMod7.Text
        CheckBoxMod8.Text = LabelMod8.Text
        CheckBoxMod9.Text = LabelMod9.Text
        CheckBoxMod10.Text = LabelMod10.Text
        CheckBoxMod11.Text = LabelMod11.Text
        CheckBoxMod12.Text = LabelMod12.Text
        CheckBoxMod13.Text = LabelMod13.Text
        For Each i In GroupBoxCheckBoxModList.Controls
            i.Checked = ModListWithFullInfo.moddisplayinfo(FromModFileNameFineModIDInModListWithFullInfo(i.Text)).Choosed
        Next
    End Sub

    Private Sub Buttontest1_Click(sender As Object, e As EventArgs) Handles ButtonTest1.Click
        FormInfoEdit.Show()
    End Sub

    Private Sub ButtonReflashModInfo_Click(sender As Object, e As EventArgs)
        ReflashModInfo()
    End Sub

    Private Sub ButtonRemoveUselessDepend_Click(sender As Object, e As EventArgs)
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
            ReflashDisplayContentFromModListWithFullInfo(LastFirstRank)
            DependModifing = False
        Next
    End Sub

    Private Sub LabelModInfo_DoubleClick(sender As Object, e As EventArgs) Handles LabelModInfo.DoubleClick
        LabelModInfo.Text = ""
    End Sub

    Private Sub LabelModInfo_TextChanged(sender As Object, e As EventArgs) Handles LabelModInfo.TextChanged
        If LabelModInfo.Text = "" Then
            LabelModInfo.Visible = False
            LabelClickMCbaike.Visible = False
            LabelClickCurseForge.Visible = False
        Else
            LabelModInfo.Visible = True
            LabelClickMCbaike.Visible = True
            LabelClickCurseForge.Visible = True
        End If
    End Sub

    Private Sub LabelClickMCbaike_Click(sender As Object, e As EventArgs) Handles LabelClickMCbaike.Click
        If LastSelectModID <> "" Then
            Process.Start("https://search.mcmod.cn/s?key=" & Replace(LastSelectModID, "-", ""))
        End If
    End Sub

    Private Sub LabelClickCurseForge_Click(sender As Object, e As EventArgs) Handles LabelClickCurseForge.Click
        If LastSelectModID <> "" Then
            Process.Start("https://www.curseforge.com/minecraft/mc-mods/" & LastSelectModID)
        End If
    End Sub

    Private Sub VScrollBarModList_ValueChanged(sender As Object, e As EventArgs) Handles VScrollBarModList.ValueChanged
        Dim FirstShowModRank As Byte
        If ModListWithFullInfo.modid.Count < 15 Then
            FirstShowModRank = 0
        Else
            FirstShowModRank = Int(VScrollBarModList.Value / (91 / (ModListWithFullInfo.modid.Count - 14)))
        End If
        If FirstShowModRank <> LastFirstRank Then
            ReflashDisplayContentFromModListWithFullInfo(FirstShowModRank)
            LastFirstRank = FirstShowModRank
        End If
    End Sub

    Private Sub ReflashLabelModInfo(Text As String)
        If Text = "" Then Exit Sub
        Dim modid As String
        modid = FromModFileNameFineModIDInModListWithFullInfo(Text)
        LabelModInfo.Text = ""
        LabelModInfo.Text += "名字 : " & ModListWithFullInfo.moddisplayinfo(modid).displayname & vbCrLf
        LabelModInfo.Text += "介绍 : " & ModListWithFullInfo.moddisplayinfo(modid).displaydescription & vbCrLf
        LabelModInfo.Text += "依赖 : " & ConnectStrArrayToString(ModListWithFullInfo.moddisplayinfo(modid).dependsArray) & vbCrLf & vbCrLf
        LabelModInfo.Text += "id : " & ModListWithFullInfo.moddisplayinfo(modid).id & vbCrLf
        LabelModInfo.Text += "version : " & ModListWithFullInfo.moddisplayinfo(modid).version & vbCrLf
        LabelModInfo.Text += "name : " & ModListWithFullInfo.moddisplayinfo(modid).name & vbCrLf
        LabelModInfo.Text += "author(s) : " & ConnectStrArrayToString(ModListWithFullInfo.moddisplayinfo(modid).authersArray) & vbCrLf
        LabelModInfo.Text += "description : " & ModListWithFullInfo.moddisplayinfo(modid).description
        LastSelectModID = modid
    End Sub

    Public Sub ReflashEasyModeSetting()
        ReadAllEasyModeSetting(AllPredefinedSelect)
    End Sub

    Private Sub CheckBoxModCheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMod0.CheckedChanged, CheckBoxMod1.CheckedChanged, CheckBoxMod2.CheckedChanged, CheckBoxMod3.CheckedChanged, CheckBoxMod4.CheckedChanged, CheckBoxMod5.CheckedChanged, CheckBoxMod6.CheckedChanged, CheckBoxMod7.CheckedChanged, CheckBoxMod8.CheckedChanged, CheckBoxMod9.CheckedChanged, CheckBoxMod10.CheckedChanged, CheckBoxMod11.CheckedChanged, CheckBoxMod12.CheckedChanged, CheckBoxMod13.CheckedChanged
        ModifyModChoose(FromModFileNameFineModIDInModListWithFullInfo(sender.Text), sender.Checked)
        ReflashLabelModInfo(sender.Text)
    End Sub

    Private Sub LabelModDoubleClick(sender As Object, e As EventArgs) Handles LabelMod0.DoubleClick, LabelMod1.DoubleClick, LabelMod2.DoubleClick, LabelMod3.DoubleClick, LabelMod4.DoubleClick, LabelMod5.DoubleClick, LabelMod6.DoubleClick, LabelMod7.DoubleClick, LabelMod8.DoubleClick, LabelMod9.DoubleClick, LabelMod10.DoubleClick, LabelMod11.DoubleClick, LabelMod12.DoubleClick, LabelMod13.DoubleClick
        ModifyModChoose(FromModFileNameFineModIDInModListWithFullInfo(sender.Text), Not ModListWithFullInfo.moddisplayinfo(FromModFileNameFineModIDInModListWithFullInfo(sender.Text)).Choosed)
        ReflashLabelModInfo(sender.Text)
    End Sub

    Private Sub ModifyModChoose(modid As String, Choose As Boolean)
        If DependModifing = True Then Exit Sub 'Add depends will call this sub, cause Stack Overflow
        ModListWithFullInfo.moddisplayinfo(modid).Choosed = Choose
        If Choose = True And ModListWithFullInfo.moddisplayinfo(modid).dependsArray.Count <> 0 Then 'check depends
            DependModifing = True
            For Each dependsmodid In ModListWithFullInfo.moddisplayinfo(modid).dependsArray
                ModListWithFullInfo.moddisplayinfo(dependsmodid).Choosed = True
                If ChoosedDepend.Count = 0 Or Not ChoosedDepend.Contains(dependsmodid) Then
                    ChoosedDepend.Add(dependsmodid) 'prevent duplicate add
                End If
            Next
            DependModifing = False
        End If
    End Sub

    Private Sub LabelModClick(sender As Object, e As EventArgs) Handles LabelMod0.Click, LabelMod1.Click, LabelMod2.Click, LabelMod3.Click, LabelMod4.Click, LabelMod5.Click, LabelMod6.Click, LabelMod7.Click, LabelMod8.Click, LabelMod9.Click, LabelMod10.Click, LabelMod11.Click, LabelMod12.Click, LabelMod13.Click
        ReflashLabelModInfo(sender.Text)
    End Sub

    Private Sub ButtonApplyAll_Click(sender As Object, e As EventArgs) Handles ButtonApplyAll.Click
        Dim MsgBoxChoose As MsgBoxResult
        Dim ModTargetDirectory As String = Application.StartupPath & "\.minecraft\mods\"
        MsgBoxChoose = MsgBox(Prompt:="是否清空原有的mods文件夹", Buttons:=vbYesNoCancel, Title:="应用模组配置")
        If MsgBoxChoose = vbYes Then
            Try 'solve empty directory
                For Each deleteFile In Directory.GetFiles(ModTargetDirectory, "*.*", SearchOption.TopDirectoryOnly)
                    File.Delete(deleteFile)
                Next
            Catch
            End Try
        ElseIf MsgBoxChoose = vbNo Then
            MsgBox(Prompt:="请自行检查是否有与原有模组重复或冲突的模组", Buttons:=vbYes, Title:="应用模组配置")
        ElseIf MsgBoxChoose = vbCancel Then
            Exit Sub
        End If
        For Each modid In ModListWithFullInfo.modid
            If ModListWithFullInfo.moddisplayinfo(modid).Choosed = True Then
                Dim SuffixIndex As Byte = 0
                Dim SuffixIndexStr As String = ""
                Do '检查重复文件名，如果有则加上序号
                    Try '组合文件路径 
                        File.Copy(ModListWithFullInfo.moddisplayinfo(modid).ModPath, ModTargetDirectory & System.IO.Path.GetFileNameWithoutExtension(ModListWithFullInfo.moddisplayinfo(modid).ModPath) & SuffixIndexStr & System.IO.Path.GetExtension(ModListWithFullInfo.moddisplayinfo(modid).ModPath), False)
                        SuffixIndex = 0 '如果正常则会进行到这，并清空缓存
                        SuffixIndexStr = ""
                        Exit Do '进行下一个文件
                    Catch a As System.IO.IOException 'Catch重复的错误
                        SuffixIndex += 1 '如果添加序号依旧有重复则+1
                        SuffixIndexStr = " (" & SuffixIndex & ")"
                    End Try
                Loop
            End If
        Next
    End Sub

    Private Sub PanelMoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMoveForm.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FormPositionOriginalX = e.X
            FormPositionOriginalY = e.Y
        End If
    End Sub

    Private Sub PanelMoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMoveForm.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FormPositionNowX = e.X
            FormPositionNowY = e.Y
            Me.Left = Me.Location.X + (FormPositionNowX - FormPositionOriginalX)
            Me.Top = Me.Location.Y + (FormPositionNowY - FormPositionOriginalY)
        End If
    End Sub
End Class