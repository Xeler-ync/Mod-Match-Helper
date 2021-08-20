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

    Public Function ListFileNameInFloder(FolderPath As String, Extension() As String)
        Dim FilePath() As String = {}
        For Each i In Extension
            Dim FileNames = My.Computer.FileSystem.GetFiles(FolderPath, FileIO.SearchOption.SearchTopLevelOnly, "*" & i)
            For ii = 0 To FileNames.Count - 1 'transform to array
                ReDim Preserve FilePath(0 To UBound(FilePath) + 1)
                FilePath(UBound(FilePath)) = FileNames(ii)
            Next
        Next
        Return FilePath
    End Function

    Public Function ConnectStrArrayToString(Array() As String)
        Dim ProcessingString As String = ""
        If Array.Length > 0 Then
            For Each i In Array
                ProcessingString += i & " "
            Next
            ProcessingString.Trim()
        End If
        Return ProcessingString
    End Function
End Module