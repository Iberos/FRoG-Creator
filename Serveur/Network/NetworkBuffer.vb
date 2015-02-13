Public Class NetworkBuffer

    Private Sub WriteByte(ByVal index As Byte, ByVal value As Byte)

    End Sub

    Private Sub WriteInteger(ByVal index As Byte, ByVal value As Integer)

    End Sub

    Private Sub WriteString(ByVal index As Byte, ByVal value As String)

    End Sub

    Public Sub Write(ByVal index As Byte, ByVal value As Object)
        Select Case value.GetTypeCode
            Case TypeCode.Byte
                WriteByte(index, value)
            Case TypeCode.Int32
                WriteInteger(index, value)
            Case TypeCode.String
                WriteString(index, value)
        End Select
    End Sub

    Public Function ReadByte(ByVal index As Byte) As Byte

        Return 0
    End Function

    Public Function ReadInteger(ByVal index As Byte) As Integer

        Return 0
    End Function

    Public Function ReadString(ByVal index As Byte) As String

        Return 0
    End Function

    Public Function Read(ByVal index As Byte, ByVal type As TypeCode) As Object
        Select Case type
            Case TypeCode.Byte
                Return ReadByte(index)
            Case TypeCode.Int32
                Return ReadInteger(index)
            Case TypeCode.String
                Return ReadString(index)
        End Select
        Return 0
    End Function
End Class
