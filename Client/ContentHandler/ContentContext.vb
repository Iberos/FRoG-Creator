Public Class ContentContext

    Private file As String
    Private extension As String

    Public Sub New(file As String, extension As String)
        Me.file = file
        Me.extension = extension.ToString()
    End Sub

    Public Function GetFile()
        Return Me.file
    End Function

    Public Function GetExtension()
        Return Me.extension
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}.{1}", Me.file, Me.extension)
    End Function
End Class
