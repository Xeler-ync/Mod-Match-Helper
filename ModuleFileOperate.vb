Module ModuleFileOperate
    Public Function ReadFile(Path As String)
        Dim fs As New IO.FileStream(Path, IO.FileMode.Open)
        Dim sr As New IO.StreamReader(fs)
        Dim FileContent As String
        FileContent = sr.ReadToEnd
        fs.Close()
        sr.Close()
        Return FileContent
    End Function

    Public Sub WriteFile(Path As String, Content As String)
        Dim fs As New IO.FileStream(Path, IO.FileMode.Create)
        Dim sr As New IO.StreamWriter(fs)
        sr.Write(Content)
        sr.Close()
        fs.Close()
    End Sub

    Public Function ListFileNameInFloder(FolderPath As String)
        Dim FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.jar")
        Dim FilePath(0 To FileNames.Count - 1) As String
        For i = 0 To FileNames.Count - 1 'transform to array
            FilePath(i) = FileNames(i)
        Next
        Return FilePath
    End Function
End Module
