Imports System.Text

Public Class NetworkBuffer

    Private Sub WriteByte(ByVal value As Byte)
        client.stream.WriteByte(value)
    End Sub

    Private Sub WriteInteger(ByVal value As Integer)
        Dim tmp() As Byte = ASCIIEncoding.UTF8.GetBytes(value.ToString())
        client.stream.WriteByte(CByte(value.ToString().Length))
        For i = 0 To value.ToString().Length - 1
            client.stream.WriteByte(tmp(i))
        Next
    End Sub

    Private Sub WriteString(ByVal value As String)
        If (value.Length < 256) Then
            Dim tmp() As Byte = ASCIIEncoding.UTF8.GetBytes(value)
            client.stream.WriteByte(CByte(value.Length))
            For i = 0 To value.ToString().Length - 1
                client.stream.WriteByte(tmp(i))
            Next
        End If
    End Sub

    Public Sub Write(ByVal value As Object)
        Select Case value.GetTypeCode
            Case TypeCode.Byte
                WriteByte(value)
            Case TypeCode.Int32
                WriteInteger(value)
            Case TypeCode.String
                WriteString(value)
        End Select
    End Sub

    Private Function ReadByte() As Byte
        Return client.stream.ReadByte()
    End Function

    Private Function ReadInteger() As Integer
        Dim length As Byte = client.stream.ReadByte()
        Dim tmp(length) As Byte
        client.stream.Read(tmp, 0, length)
        Return Convert.ToInt32(ASCIIEncoding.UTF8.GetString(tmp))
    End Function

    Private Function ReadString() As String
        Dim length As Byte = client.stream.ReadByte()
        Dim tmp(length) As Byte
        client.stream.Read(tmp, 0, length)
        Return ASCIIEncoding.UTF8.GetString(tmp)
    End Function

    Public Function Read(ByVal type As TypeCode) As Object
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
