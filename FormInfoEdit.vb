Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormInfoEdit
    Dim ModSourceInfo(,), ModDisplayInfo(,) As String
    Dim jsonToFile As New ClassModInfoFile

    Public Sub WriteModDisplayInfo(InputInfo, ModID)
        Dim NewModDisplayInfo As New ClassSingleModDisplayInfo With {
            .displayname = InputInfo(0),
            .displaydescription = InputInfo(1),
            .rely = InputInfo(2)
        }
        jsonToFile.modid.Add(ModID)
        jsonToFile.moddisplayinfo.Add(ModID, NewModDisplayInfo)
        'WriteFile(Application.StartupPath & "\MMH\mod.introduction.json", Replace(JsonConvert.SerializeObject(jsonToFile), "\", ""))
        WriteFile(Application.StartupPath & "\MMH\mod.introduction.json", JsonConvert.SerializeObject(jsonToFile))
    End Sub

    Public Function ReadIntroductionjson()
        Dim jsonContent As String
        jsonContent = ReadFile(Application.StartupPath & "\MMH\mod.introduction.json")
        Dim jsonResults As JObject = JObject.Parse(jsonContent)
        Dim modid As JToken = jsonResults("modid")
        Dim WorkCountTime As Byte
        Dim Returner(0 To jsonResults("modid").Count, 0 To 2) As String 'pack result together

        For Each SingleModID In modid

            Dim displayname As String = jsonResults("moddisplayinfo")(SingleModID.ToString)("displayname")
            Dim displaydescription As String = jsonResults("moddisplayinfo")(SingleModID.ToString)("displaydescription")
            Dim rely As String = jsonResults("moddisplayinfo")(SingleModID.ToString)("rely") 'if muti, separate with space(" ")
            Returner(WorkCountTime, 0) = displayname
            Returner(WorkCountTime, 1) = displaydescription
            Returner(WorkCountTime, 2) = rely

            WorkCountTime += 1
        Next

        Return Returner
    End Function


    Private Sub TextBoxInfoInput_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInfoInput.TextChanged
        If TextBoxInfoInput.Lines.Count = 4 And ListBoxListMod.Items.Count <> 0 Then
            WriteModDisplayInfo(TextBoxInfoInput.Lines, ModSourceInfo(ListBoxListMod.SelectedIndex, 1))
            TextBoxInfoInput.Text = ""
            ListBoxListMod.Items.Remove(ListBoxListMod.SelectedIndex)
        End If
    End Sub
    Public Sub ReflashModInfo()
        ModSourceInfo = ReflashNewAllModInfo()
        ModDisplayInfo = ReadIntroductionjson()
        For i = 0 To UBound(ModSourceInfo)
            ListBoxListMod.Items.Add(System.IO.Path.GetFileName(ModSourceInfo(i, 0)))
        Next
    End Sub

    Private Sub ButtonReloadModList_Click(sender As Object, e As EventArgs) Handles ButtonReloadModList.Click
        ReflashModInfo()
    End Sub

    Private Sub ListBoxListMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxListMod.SelectedIndexChanged 'display mod info
        If ListBoxListMod.SelectedIndex = -1 Then
            TextBoxInfoInput.Enabled = False
        Else
            TextBoxInfoInput.Enabled = True
            LabelModInfo.Text += "displayname : " & ModDisplayInfo(ListBoxListMod.SelectedIndex, 0) & vbCrLf
            LabelModInfo.Text += "displaydescription : " & ModDisplayInfo(ListBoxListMod.SelectedIndex, 1) & vbCrLf
            LabelModInfo.Text += "rely : " & ModDisplayInfo(ListBoxListMod.SelectedIndex, 2) & vbCrLf
            LabelModInfo.Text += "id : " & ModSourceInfo(ListBoxListMod.SelectedIndex, 1) & vbCrLf
            LabelModInfo.Text += "version : " & ModSourceInfo(ListBoxListMod.SelectedIndex, 2) & vbCrLf
            LabelModInfo.Text += "name : " & ModSourceInfo(ListBoxListMod.SelectedIndex, 3) & vbCrLf
            LabelModInfo.Text += "author(s) : " & ModSourceInfo(ListBoxListMod.SelectedIndex, 5) & vbCrLf
            LabelModInfo.Text += "description : " & ModSourceInfo(ListBoxListMod.SelectedIndex, 4)
        End If
    End Sub

    Private Sub FormInfoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        jsonToFile.modid.Clear()
        WriteFile(Application.StartupPath & "\MMH\mod.introduction.json", JsonConvert.SerializeObject(jsonToFile))
    End Sub
End Class