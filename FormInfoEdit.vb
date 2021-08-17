Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormInfoEdit
    Dim ModSourceInfo(,), ModDisplayInfo(,) As String
    Dim jsonToFile As New ClassModInfoFile

    Private Sub FormInfoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReflashModListBox(0)
        jsonToFile = LoadClassModInfoFileFromjson()
    End Sub

    Private Sub WriteModDisplayInfo(InputInfo, ModID)
        Dim NewModDisplayInfo As New ClassSingleModDisplayInfo With {
            .displayname = InputInfo(0),
            .displaydescription = InputInfo(1),
            .rely = InputInfo(2)
        }
        jsonToFile.modid.Add(ModID)
        jsonToFile.moddisplayinfo.Add(ModID, NewModDisplayInfo)
        WriteFile(Application.StartupPath & "\MMH\mod.introduction.json", JsonConvert.SerializeObject(jsonToFile))
    End Sub

    Private Sub ReflashModInfo()
        ModSourceInfo = ReflashNewAllModInfo()
        ModDisplayInfo = ReadModIntroductionjson()
        For i = 0 To UBound(ModSourceInfo)
            ListBoxListMod.Items.Add(System.IO.Path.GetFileName(ModSourceInfo(i, 0)))
        Next
    End Sub

    Private Sub TextBoxInfoInput_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInfoInput.TextChanged
        If TextBoxInfoInput.Lines.Count = 4 And ListBoxListMod.Items.Count <> 0 Then
            Dim ModSourceInfoDisplayIndex As Byte
            For ModSourceInfoDisplayIndex = 0 To UBound(ModSourceInfo) 'find which index of content from source json can match the SelectedIndex
                If Path.GetFileName(ModSourceInfo(ModSourceInfoDisplayIndex, 0)) = ListBoxListMod.SelectedItem Then
                    Exit For
                End If
            Next
            WriteModDisplayInfo(TextBoxInfoInput.Lines, ModSourceInfo(ModSourceInfoDisplayIndex, 1))
            TextBoxInfoInput.Text = ""
            ListBoxListMod.Items.RemoveAt(ListBoxListMod.SelectedIndex)
        End If
    End Sub

    Private Sub ReflashModListBox(Mode As Byte)
        ListBoxListMod.Enabled = False
        ListBoxListMod.Items.Clear()
        ReflashModInfo()
        If Mode = 0 Then 'remove duplicate
            For i = 0 To UBound(ModSourceInfo) 'to check if it has been edited 
                For ii = 0 To UBound(ModDisplayInfo)
                    If ModSourceInfo(i, 1) = ModDisplayInfo(ii, 0) Then
                        ListBoxListMod.Items.Remove(Path.GetFileName(ModSourceInfo(i, 0)))
                        Exit For
                    End If
                Next
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
        If ListBoxListMod.SelectedIndex = -1 Then
            TextBoxInfoInput.Enabled = False
        Else
            TextBoxInfoInput.Enabled = True
            LabelModInfo.Text = ""
            Dim ModSourceInfoDisplayIndex, ModIntroduceInfoDisplayIndex As Byte
            For ModSourceInfoDisplayIndex = 0 To UBound(ModSourceInfo) 'find which index of content from source json can match the SelectedIndex
                If Path.GetFileName(ModSourceInfo(ModSourceInfoDisplayIndex, 0)) = ListBoxListMod.SelectedItem Then
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
            Dim displayname, displaydescription, rely As String
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
            Try
                rely = ModDisplayInfo(ModIntroduceInfoDisplayIndex, 3)
            Catch
                rely = ""
            End Try
            LabelModInfo.Text += "displayname : " & displayname & vbCrLf
            LabelModInfo.Text += "displaydescription : " & displaydescription & vbCrLf
            LabelModInfo.Text += "rely : " & rely & vbCrLf
            LabelModInfo.Text += "id : " & ModSourceInfo(ModSourceInfoDisplayIndex, 1) & vbCrLf
            LabelModInfo.Text += "version : " & ModSourceInfo(ModSourceInfoDisplayIndex, 2) & vbCrLf
            LabelModInfo.Text += "name : " & ModSourceInfo(ModSourceInfoDisplayIndex, 3) & vbCrLf
            LabelModInfo.Text += "author(s) : " & ModSourceInfo(ModSourceInfoDisplayIndex, 5) & vbCrLf
            LabelModInfo.Text += "description : " & ModSourceInfo(ModSourceInfoDisplayIndex, 4)
        End If
    End Sub

    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        ReflashModListBox(1)
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        jsonToFile.modid.Clear()
        WriteFile(Application.StartupPath & "\MMH\mod.introduction.json", JsonConvert.SerializeObject(jsonToFile))
    End Sub
End Class