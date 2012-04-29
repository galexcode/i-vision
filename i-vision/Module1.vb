Module Module1
    Public FILE_NAME As String = "settings.txt"
    Public HomePage As String
    Public objReader As New System.IO.StreamReader(FILE_NAME)
    Public ToWrite As String
End Module
