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
        Dim Returner(0 To 4) As String 'pack result together
        Returner(0) = id
        Returner(1) = version
        Returner(2) = name
        Returner(3) = description
        For i = 0 To authors.Count - 1 'combine auther to a single String
            Returner(4) += authors(i) & " "
        Next
        Returner(4).Trim()
        Return Returner
    End Function

    Public Function ReflashNewAllModInfo()
        'to extract mod info from itself
        Dim FilePath() As String
        FilePath = ListFileNameInFloder(Application.StartupPath & "\MMH\not-loaded-mods\")
        Dim ModInfo(0 To UBound(FilePath), 0 To 5) As String '第二维为0时储存mod路径，剩下的按顺序存储信息
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
End Module