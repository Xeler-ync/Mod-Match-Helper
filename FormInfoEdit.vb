Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormInfoEdit
    'Dim ModSourceInfo(,), ModDisplayInfo(,), ModDisplayID() As String
    Dim jsonToFile As New ClassModInfoFile

    Private Sub FormInfoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReflashModListBox(0)
        'jsonToFile = LoadClassModInfoFileFromjson(ModListWithFullInfo)
    End Sub

    Private Sub WriteModDisplayInfo(InputInfo, ModID)
        Dim NewModDisplayInfo As New ClassSingleModDisplayInfo With {
            .displayname = InputInfo(0),
            .displaydescription = InputInfo(1)
        }
        jsonToFile.modid.Add(ModID)
        jsonToFile.moddisplayinfo.Add(ModID, NewModDisplayInfo)
        WriteFile(Application.StartupPath & "\MMH\mod.introduction.json", JsonConvert.SerializeObject(jsonToFile))
    End Sub

    Private Sub ReflashModInfo()
        ModListWithFullInfo = ReflashNewAllModInfo(ModListWithFullInfo)
        ModListWithFullInfo = ReadModIntroductionjson(ModListWithFullInfo)
        For i = 0 To ModListWithFullInfo.modid.Count - 1
            ListBoxListMod.Items.Add(System.IO.Path.GetFileName(ModListWithFullInfo.moddisplayinfo(ModListWithFullInfo.modid(i)).ModPath))
        Next
    End Sub

    Private Sub TextBoxInfoInput_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInfoInput.TextChanged
        If TextBoxInfoInput.Lines.Count = 3 And ListBoxListMod.Items.Count <> 0 Then
            For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
                If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = ListBoxListMod.SelectedItem Then 'save input
                    ModListWithFullInfo.moddisplayinfo(modid).displayname = TextBoxInfoInput.Lines(0)
                    ModListWithFullInfo.moddisplayinfo(modid).displaydescription = TextBoxInfoInput.Lines(1)
                    Exit For
                End If
            Next
            TextBoxInfoInput.Text = ""
            ListBoxListMod.Items.RemoveAt(ListBoxListMod.SelectedIndex)
        End If
    End Sub

    Private Sub ReflashModListBox(Mode As Byte)
        ListBoxListMod.Enabled = False
        ListBoxListMod.Items.Clear()
        ReflashModInfo()
        If Mode = 0 Then 'remove duplicate
            For i = 0 To ModListWithFullInfo.modid.Count - 1 'to check if it has been edited 
                If ModListWithFullInfo.moddisplayinfo(ModListWithFullInfo.modid(i)).displaydescription <> "" And ModListWithFullInfo.moddisplayinfo(ModListWithFullInfo.modid(i)).displaydescription <> "" Then
                    ListBoxListMod.Items.Remove(Path.GetFileName(ModListWithFullInfo.moddisplayinfo(ModListWithFullInfo.modid(i)).ModPath))
                End If
            Next
        ElseIf Mode = 1 Then
            'nothing to do, just say hellow
        End If
            ListBoxListMod.Enabled = True
    End Sub

    Private Sub ButtonReloadModList_Click(sender As Object, e As EventArgs) Handles ButtonReloadModList.Click
        ReflashModListBox(0)
    End Sub

    Private Sub ListBoxListMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxListMod.SelectedIndexChanged 'display mod info
        LabelModInfo.Text = ""
        If ListBoxListMod.SelectedIndex = -1 Then
            TextBoxInfoInput.Enabled = False
        Else
            TextBoxInfoInput.Enabled = True
            LabelModInfo.Text = ""
            For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
                If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = ListBoxListMod.SelectedItem Then 'save input
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
        End If
    End Sub

    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        ReflashModListBox(1)
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        jsonToFile.modid.Clear()
        jsonToFile.moddisplayinfo.Clear()
        WriteFile(Application.StartupPath & "\MMH\mod.introduction.json", JsonConvert.SerializeObject(jsonToFile))
    End Sub
End Class