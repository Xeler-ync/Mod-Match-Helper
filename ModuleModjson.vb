Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module ModuleModjson
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

    Public Function ExtractModInfoFromjson(jsonPath As String) 'to extract mod info from itself
        Dim jsonContent As String
        jsonContent = ReadFile(jsonPath)
        Dim jsonResults As JObject = JObject.Parse(jsonContent)
        Dim id As String = jsonResults("id")
        Dim version As String = jsonResults("version")
        Dim name As String = jsonResults("name")
        Dim description As String = jsonResults("description")
        Dim jsonArray As JArray = jsonResults("authors") 'change the array of authors into JArry
        Dim authors As New List(Of String) 'create a new list to save the contents
        If jsonContent.Contains("""authors"": [") Then 'checl if there is authors info in json
            For Each i As JToken In jsonArray
                authors.Add(i.ToString)
            Next
        Else
            authors.Add(" ") 'prevent error
        End If
        Dim Returner(0 To 5) As String 'pack result together
        Returner(0) = id
        Returner(1) = version
        Returner(2) = name
        Returner(3) = description
        For i = 0 To authors.Count - 1 'combine auther to a single String
            Returner(4) += authors(i) & " "
        Next
        Try
            If Returner(4) <> Nothing Then Returner(4).Trim()
        Catch exception As System.NullReferenceException
            Returner(4) = ""
        End Try
        Returner(5) = ExtractModRelyFromIntroductionjsonContent(jsonContent)
        Return Returner
    End Function

    Public Function ExtractModRelyFromIntroductionjsonContent(jsonContent As String)
        Dim LineNum As Byte
        For LineNum = 0 To UBound(jsonContent.Split(vbCrLf)) 'find where is depends line
            If jsonContent.Split(vbCrLf)(LineNum).Contains("depends") Then
                LineNum += 1 'next line contain modid of depents
                Exit For
            End If
        Next
        Dim depends As String = ""
        For CheckNum = LineNum To UBound(jsonContent.Split(vbCrLf))
            Dim FirstQuotationMarks, SecondQuotationMarks As Byte
            For FirstQuotationMarks = 1 To Len(jsonContent.Split(vbCrLf)(LineNum)) - 1
                If Mid(jsonContent.Split(vbCrLf)(LineNum), FirstQuotationMarks, 1) = """" Then
                    Exit For
                End If
            Next
            For SecondQuotationMarks = FirstQuotationMarks + 1 To Len(jsonContent.Split(vbCrLf)(LineNum)) - 1
                If Mid(jsonContent.Split(vbCrLf)(LineNum), SecondQuotationMarks, 1) = """" Then
                    Exit For
                End If
            Next
            Dim NewInfo As String
            NewInfo = Mid(jsonContent.Split(vbCrLf)(LineNum), FirstQuotationMarks + 1, SecondQuotationMarks - FirstQuotationMarks - 1) & " "
            If Not NewInfo.Contains("fabricload") Then depends += NewInfo 'do not add fabricload
        Next
        depends.Trim()
        Return depends
    End Function

    Public Function GetModInfo(ByVal ModPath As String)
        Dim jsonPath As String
        jsonPath = ExtractFabricModjson(ModPath)
        Dim ResultList() As String
        ResultList = ExtractModInfoFromjson(jsonPath)
        Return ResultList
    End Function

    Public Function ReflashNewAllModInfo()
        'to extract mod info from itself
        Dim FilePath() As String
        FilePath = ListFileNameInFloder(Application.StartupPath & "\MMH\not-loaded-mods\")
        Dim ModInfo(0 To UBound(FilePath), 0 To 6) As String '第二维为0时储存mod路径，剩下的按 id version name description authers depends 顺序存储信息
        For i = 0 To UBound(FilePath)
            Dim ResultList() As String
            ResultList = GetModInfo(FilePath(i))
            ModInfo(i, 0) = FilePath(i)
            Dim InfoIndex As Byte
            For InfoIndex = 0 To UBound(ResultList)
                ModInfo(i, InfoIndex + 1) = ResultList(InfoIndex)
            Next
        Next
        Return ModInfo
    End Function

    Public Function ReadModIntroductionjson()
        Dim jsonContent As String
        jsonContent = ReadFile(Application.StartupPath & "\MMH\mod.introduction.json")
        Dim jsonResults As JObject
        Try
            jsonResults = JObject.Parse(jsonContent)
        Catch 'if empty
            jsonResults = JObject.Parse("{""modid"" : [],""moddisplayinfo"" : {}}")
        End Try
        Dim modid As JToken = jsonResults("modid")
        Dim WorkCountTime As Byte
        Dim Returner(0 To jsonResults("modid").Count, 0 To 2) As String 'pack result together
        For Each SingleModID In modid
            Dim displayname As String = jsonResults("moddisplayinfo")(SingleModID.ToString)("displayname")
            Dim displaydescription As String = jsonResults("moddisplayinfo")(SingleModID.ToString)("displaydescription")
            Dim rely As String = jsonResults("moddisplayinfo")(SingleModID.ToString)("rely") 'if muti, separate with space(" ")
            Returner(WorkCountTime, 0) = SingleModID
            Returner(WorkCountTime, 1) = displayname
            Returner(WorkCountTime, 2) = displaydescription
            WorkCountTime += 1
        Next
        Return Returner
    End Function

    Public Function LoadClassModInfoFileFromjson()
        Dim jsonNonFormatedContent(,) As String
        jsonNonFormatedContent = ReadModIntroductionjson() 'get json content
        Dim jsonFormatedContent As New ClassModInfoFile
        Dim jsonContent As String
        jsonContent = ReadFile(Application.StartupPath & "\MMH\mod.introduction.json") 'get modid content
        Dim jsonResults As JObject
        Try
            jsonResults = JObject.Parse(jsonContent)
        Catch 'if empty
            jsonResults = JObject.Parse("{""modid"" : [],""moddisplayinfo"" : {}}")
        End Try
        Dim modid As JToken = jsonResults("modid")
        'jsonContent = Nothing
        'jsonResults = Nothing
        For i = 0 To UBound(jsonNonFormatedContent) 'format json content
            Dim SingleModDisplayInfo As New ClassSingleModDisplayInfo With {
            .displayname = jsonNonFormatedContent(i, 1),
            .displaydescription = jsonNonFormatedContent(i, 2)
            }
            If CType(SingleModDisplayInfo.displayname, String) = CType(SingleModDisplayInfo.displaydescription, String) Then 'this array may has a item with Nothing
            Else
                jsonFormatedContent.moddisplayinfo.Add(modid(i), SingleModDisplayInfo)
            End If
        Next
        Return jsonFormatedContent
    End Function

    Public Function ReadModIDFromIntroductionjson()
        Dim jsonContent As String
        jsonContent = ReadFile(Application.StartupPath & "\MMH\mod.introduction.json")
        Dim jsonResults As JObject
        Try
            jsonResults = JObject.Parse(jsonContent)
        Catch 'if empty
            jsonResults = JObject.Parse("{""modid"" : [],""moddisplayinfo"" : {}}")
        End Try
        Dim modid As JToken = jsonResults("modid")
        Dim ModIDList(0 To jsonResults("modid").Count) As String
        Dim WorkCountTime As Byte
        For Each SingleModID In modid
            ModIDList(WorkCountTime) = SingleModID
            WorkCountTime += 1
        Next
        Return ModIDList
    End Function
End Module