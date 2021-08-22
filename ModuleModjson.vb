Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json.Linq

Module ModuleModjson
    Public ModListWithFullInfo As New ClassModListWithFullInfo
    Public AllPredefinedSelect As New ClassAllPredefinedSelect
    Public Function ExtractFabricModjson(ByVal ModPath As String) 'to extract mod info from itself
        ' Almost copied from MS official document
        Dim ExtractPath As String
        ExtractPath = Application.StartupPath & "\MMH\temp\"
        ' Ensures that the last character on the extraction path
        ' is the directory separator char. 
        ' Without this, a malicious zip file could try to traverse outside of the expected
        ' extraction path.
        If Not ExtractPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal) Then
            ExtractPath += Path.DirectorySeparatorChar
        End If
        Using archive As ZipArchive = ZipFile.OpenRead(ModPath)
            For Each entry As ZipArchiveEntry In archive.Entries
                If entry.FullName.EndsWith("mod.json", StringComparison.OrdinalIgnoreCase) Then
                    ' Gets the full path to ensure that relative segments are removed.
                    Dim destinationPath As String = Path.GetFullPath(Path.Combine(ExtractPath, entry.FullName))
                    ' Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                    ' are case-insensitive.
                    If destinationPath.StartsWith(ExtractPath, StringComparison.Ordinal) Then
                        Try
                            File.Delete(destinationPath)
                        Catch
                        End Try
                        entry.ExtractToFile(destinationPath)
                    End If

                End If
            Next
        End Using
        Dim jsonFilePath As String
        jsonFilePath = ExtractPath & "\fabric.mod.json"
        Return jsonFilePath
    End Function

    Public Function ExtractModInfoFromjson(jsonPath As String, ProcessingModFullInfo As ClassModFullInfo) 'to extract mod info from itself
        Dim jsonContent As String
        jsonContent = ReadFile(jsonPath)
        Dim jsonResults As JObject = JObject.Parse(jsonContent)
        ProcessingModFullInfo.id = jsonResults("id")
        ProcessingModFullInfo.version = jsonResults("version")
        ProcessingModFullInfo.name = jsonResults("name")
        ProcessingModFullInfo.description = jsonResults("description")
        Dim jsonArray As JArray = jsonResults("authors") 'change the array of authors into JArry
        If jsonContent.Contains("""authors"": [") Then 'check if there is authors info in json
            ReDim Preserve ProcessingModFullInfo.authersArray(0 To jsonArray.Count - 1)
            For Each i As JToken In jsonArray
                ProcessingModFullInfo.authersArray(UBound(ProcessingModFullInfo.authersArray)) = i.ToString
            Next
        Else
            ReDim Preserve ProcessingModFullInfo.authersArray(0 To 1)
            ProcessingModFullInfo.authersArray(UBound(ProcessingModFullInfo.authersArray)) = "" 'prevent error
        End If
        ProcessingModFullInfo.dependsArray = ExtractModDependFromIntroductionjsonContent(jsonContent)
        Return ProcessingModFullInfo
    End Function

    Public Function ExtractModDependFromIntroductionjsonContent(jsonContent As String)
        Dim LineNum As Byte
        Dim WrapType As String = ""
        If jsonContent.Contains(vbCrLf) Then
            WrapType = vbCrLf
        ElseIf jsonContent.Contains(vbLf) Then
            WrapType = vbLf
        ElseIf jsonContent.Contains(vbCr) Then
            WrapType = vbCr
        End If
        For LineNum = 0 To UBound(jsonContent.Split(WrapType)) 'find where is depends line
            If jsonContent.Split(WrapType)(LineNum).Contains("depends") Then
                LineNum += 1 'next line contain modid of depents
                Exit For
            End If
        Next
        Dim depends() As String = {}
        For CheckLineNum = LineNum To UBound(jsonContent.Split(WrapType)) - 1
            If jsonContent.Split(WrapType)(CheckLineNum).Contains("}") Then Exit For
            Dim FirstQuotationMarks, SecondQuotationMarks As Byte
            For FirstQuotationMarks = 1 To Len(jsonContent.Split(WrapType)(CheckLineNum)) - 1
                If Mid(jsonContent.Split(WrapType)(CheckLineNum), FirstQuotationMarks, 1) = """" Then
                    Exit For
                End If
            Next
            For SecondQuotationMarks = FirstQuotationMarks + 1 To Len(jsonContent.Split(WrapType)(CheckLineNum)) - 1
                If Mid(jsonContent.Split(WrapType)(CheckLineNum), SecondQuotationMarks, 1) = """" Then
                    Exit For
                End If
            Next
            Dim NewInfo As String
            NewInfo = Mid(jsonContent.Split(WrapType)(CheckLineNum), FirstQuotationMarks + 1, SecondQuotationMarks - FirstQuotationMarks - 1)
            Dim IgnoreString() As String = {"fabric", "minecraft", "java", "1.17", "1.16", "1.15", "1.14", "1.13", "1.12", "1.11", "1.10", "1.9", "1.8", "1.7", "1.6", "1.5", "1.4", "1.3", "1.2", "1.1", "1.0"}
            Dim IgnoreIt As Boolean = False
            For Each SingleIgnoreString In IgnoreString
                If NewInfo.Contains(SingleIgnoreString) Then 'do not add fabricload fabric minrcraft
                    IgnoreIt = True
                    Exit For
                End If
            Next
            If IgnoreIt = True Then Continue For
            For Each i In depends
                If i = NewInfo Then
                    NewInfo = ""
                End If
            Next
            If NewInfo <> "" Then
                ReDim Preserve depends(0 To UBound(depends) + 1)
                depends(UBound(depends)) = NewInfo
            End If
        Next
        Return depends
    End Function

    Public Function GetModSoruceInfo(ModPath As String, ProcessingModFullInfo As ClassModFullInfo)
        Dim jsonPath As String
        jsonPath = ExtractFabricModjson(ModPath)
        ProcessingModFullInfo = ExtractModInfoFromjson(jsonPath, ProcessingModFullInfo)
        Return ProcessingModFullInfo
    End Function

    Public Function ReflashNewAllModInfo(ProcessingModListWithFullInfo As ClassModListWithFullInfo) 'to extract mod info from itself
        Dim FilePath() As String
        FilePath = ListFileNameInFloder(Application.StartupPath & "\MMH\not-loaded-mods\", {".jar"})
        Dim ModInfo(0 To UBound(FilePath), 0 To 6) As String
        ProcessingModListWithFullInfo.modid.Clear()
        ProcessingModListWithFullInfo.moddisplayinfo.Clear()
        For i = 0 To UBound(FilePath)
            Dim SingleModFullInfo As New ClassModFullInfo
            SingleModFullInfo = GetModSoruceInfo(FilePath(i), SingleModFullInfo)
            SingleModFullInfo.ModPath = FilePath(i)
            ProcessingModListWithFullInfo.modid.Add(SingleModFullInfo.id)
            ProcessingModListWithFullInfo.moddisplayinfo.Add(SingleModFullInfo.id, SingleModFullInfo)
        Next
        Return ProcessingModListWithFullInfo
    End Function

    Public Function ReadModIntroductionjson(ProcessingModListWithFullInfo As ClassModListWithFullInfo)
        Dim jsonContent As String
        jsonContent = ReadFile(Application.StartupPath & "\MMH\mod.introduction.json")
        Dim jsonResults As JObject
        Try
            jsonResults = JObject.Parse(jsonContent)
        Catch 'if empty
            jsonResults = JObject.Parse("{""modid"" : [],""moddisplayinfo"" : {}}")
        End Try
        Dim modid As JToken = jsonResults("modid")
        For Each SingleModID In modid
            ProcessingModListWithFullInfo.moddisplayinfo(SingleModID.ToString).displayname = jsonResults("moddisplayinfo")(SingleModID.ToString)("displayname")
            ProcessingModListWithFullInfo.moddisplayinfo(SingleModID.ToString).displaydescription = jsonResults("moddisplayinfo")(SingleModID.ToString)("displaydescription")
        Next
        Return ProcessingModListWithFullInfo
    End Function

    Public Function FromModFileNameFineModIDInModListWithFullInfo(ModFileName As String)
        For Each modid In ModListWithFullInfo.modid 'find which modid can match the SelectedIndex
            If Path.GetFileName(ModListWithFullInfo.moddisplayinfo(modid).ModPath) = ModFileName Then
                Return modid
            End If
        Next
        Return ""
    End Function

    Public Function ReadAllEasyModeSetting(ProcessingAllPredefinedSelect As ClassAllPredefinedSelect)
        Dim jsonContent As String
        jsonContent = ReadFile(Application.StartupPath & "\MMH\predefined.select.json")
        Dim jsonResults As JObject
        Try
            jsonResults = JObject.Parse(jsonContent)
        Catch 'if empty
            jsonResults = JObject.Parse("{""settingsid"" : [],""settingscontent"" : {}}")
        End Try
        Dim settingsid As JToken = jsonResults("settingsid")
        For Each SingleSettingsID As String In settingsid
            ProcessingAllPredefinedSelect.settingsid.Add(SingleSettingsID)
            Dim SinglePredefinedSelect As ClassSinglePredefinedSelect
#Disable Warning BC42104 ' 在为变量赋值之前，变量已被使用
            SinglePredefinedSelect.settingsdescription = jsonResults("settingscontent")(SingleSettingsID)("settingsdescription")
            SinglePredefinedSelect.settingsname = jsonResults("settingname")(SingleSettingsID)("settingsname")
            For Each modid In jsonResults("settingscontent")(SingleSettingsID)("modidlist")
                ReDim Preserve SinglePredefinedSelect.modidlist(0 To UBound(SinglePredefinedSelect.modidlist) + 1)
                SinglePredefinedSelect.modidlist(UBound(SinglePredefinedSelect.modidlist)) = modid.ToString
            Next
#Enable Warning BC42104 ' 在为变量赋值之前，变量已被使用
            ProcessingAllPredefinedSelect.settingscontent.Add(SingleSettingsID, SinglePredefinedSelect)
        Next
        Return ProcessingAllPredefinedSelect
    End Function
End Module