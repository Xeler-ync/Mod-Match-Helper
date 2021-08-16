Imports System.IO
Imports System.IO.Compression
Imports Newtonsoft.Json.Linq

Public Class FormMain
    Dim ModInfo(,) As String
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Function ExtractFabricModjson(ByVal ModPath As String) ' Almost copied from MS official document
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

    Private Function ReadFile(Path As String)
        Dim fs As New IO.FileStream(Path, IO.FileMode.Open)
        Dim sr As New IO.StreamReader(fs)
        Dim FileContent As String
        FileContent = sr.ReadToEnd
        fs.Close()
        sr.Close()
        Return FileContent
    End Function

    Private Function ExtractModInfoFromjson(jsonPath As String)
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

    Private Function ListFileNameInFloder(FolderPath As String)
        Dim FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.jar")
        Dim FilePath(0 To FileNames.Count - 1) As String
        For i = 0 To FileNames.Count - 1 'transform to array
            FilePath(i) = FileNames(i)
        Next
        Return FilePath
    End Function

    Private Function GetModInfo(ByVal ModPath As String)
        Dim jsonPath As String
        jsonPath = ExtractFabricModjson(ModPath)
        Dim ResultList() As String
        ResultList = ExtractModInfoFromjson(jsonPath)
        Return ResultList
    End Function

    Private Sub ReflashModInfo()
        Dim FilePath() As String
        FilePath = ListFileNameInFloder(Application.StartupPath & "\MMH\not-loaded-mods\")
        ReDim ModInfo(0 To UBound(FilePath), 0 To 5) '第二维为0时储存mod路径，剩下的按顺序存储信息
        For i = 0 To UBound(FilePath)
            Dim ResultList() As String
            ResultList = GetModInfo(FilePath(i))
            ModInfo(i, 0) = FilePath(i)
            Dim InfoIndex As Byte
            For InfoIndex = 0 To UBound(ResultList)
                ModInfo(i, InfoIndex + 1) = ResultList(InfoIndex)
            Next
            InfoIndex = 0 'reset it
        Next
        For i = 0 To UBound(ModInfo)
            CheckedListBoxSelectMods.Items.Add(System.IO.Path.GetFileName(ModInfo(i, 0)))
        Next
    End Sub

    Private Sub CheckedListBoxSelectMods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxSelectMods.SelectedIndexChanged
        LabelModInfo.Text = "id : " & ModInfo(CheckedListBoxSelectMods.SelectedIndex, 1) & vbCrLf
        LabelModInfo.Text += "version : " & ModInfo(CheckedListBoxSelectMods.SelectedIndex, 2) & vbCrLf
        LabelModInfo.Text += "name : " & ModInfo(CheckedListBoxSelectMods.SelectedIndex, 3) & vbCrLf
        LabelModInfo.Text += "author(s) : " & ModInfo(CheckedListBoxSelectMods.SelectedIndex, 5) & vbCrLf
        LabelModInfo.Text += "description : " & ModInfo(CheckedListBoxSelectMods.SelectedIndex, 4)
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        ReflashModInfo()
    End Sub
End Class