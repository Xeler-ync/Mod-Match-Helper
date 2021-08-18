Public Class ClassModFullInfo
    Public displayname As String = ""
    Public displaydescription As String = ""
    Public ModPath As String = ""
    Public id As String = ""
    Public version As String = ""
    Public name As String = ""
    Public description As String = ""
    Public authersArray() As String = {}
    Public dependsArray() As String = {}

    Public Sub SaveautherArrayFromString(autherString As String)
        authersArray = Trim(autherString).Split(" ")
    End Sub

    Public Sub SavedependsArrayFromString(dependsString As String)
        dependsArray = Trim(dependsString).Split(" ")
    End Sub

    Sub SaveSourceInfoFromArray(SourceString() As String)
        Dim authersSrting, dependsString As String
        ModPath = SourceString(0)
        id = SourceString(1)
        version = SourceString(2)
        name = SourceString(3)
        description = SourceString(4)
        authersSrting = SourceString(5)
        dependsString = SourceString(6)
        authersArray = Trim(authersSrting).Split(" ")
        dependsArray = Trim(dependsString).Split(" ")
    End Sub

    Sub SaveDisplayInfoFromArray(DisplayString() As String)
        displayname = DisplayString(0)
        displaydescription = DisplayString(1)
    End Sub
End Class
