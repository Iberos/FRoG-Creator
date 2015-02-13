Public Class NetworkBuffer

    Private Sub WriteByte(ByVal value As Byte)

    End Sub

    Private Sub WriteInteger(ByVal value As Integer)

    End Sub

    Private Sub WriteString(ByVal value As String)

    End Sub

    Public Sub Write(ByVal index As Byte, ByVal value As Object)
        Select Case value.GetTypeCode
            Case TypeCode.Byte
                WriteByte(value)
            Case TypeCode.Int32
                WriteInteger(value)
            Case TypeCode.String
                WriteString(value)
        End Select
    End Sub

    Public Function ReadByte() As Byte

        Return 0
    End Function

    Public Function ReadInteger() As Integer

        Return 0
    End Function

    Public Function ReadString() As String

        Return 0
    End Function

    Public Function Read(ByVal index As Byte, ByVal type As TypeCode) As Object
        Select Case type
            Case TypeCode.Byte
                Return ReadByte()
            Case TypeCode.Int32
                Return ReadInteger()
            Case TypeCode.String
                Return ReadString()
        End Select
        Return 0
    End Function
End Class
