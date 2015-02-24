Imports System.Text

Public Class NetworkBuffer

    Private Sub WriteByte(ByVal index As Byte, ByVal value As Byte)
        tmpClient(index).stream.WriteByte(value)
    End Sub

    Private Sub WriteInteger(ByVal index As Byte, ByVal value As Integer)
        Dim tmp() As Byte = ASCIIEncoding.UTF8.GetBytes(value.ToString())
        tmpClient(index).stream.WriteByte(CByte(value.ToString().Length))
        For i = 0 To value.ToString().Length - 1
            tmpClient(index).stream.WriteByte(tmp(i))
        Next
    End Sub

    Private Sub WriteString(ByVal index As Byte, ByVal value As String)
        If (value.Length < 256) Then
            Dim tmp() As Byte = ASCIIEncoding.UTF8.GetBytes(value)
            tmpClient(index).stream.WriteByte(CByte(value.Length))
            For i = 0 To value.ToString().Length - 1
                tmpClient(index).stream.WriteByte(tmp(i))
            Next
        End If
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

    Private Function ReadByte(ByVal index As Byte) As Byte
        Return tmpClient(index).stream.ReadByte()
    End Function

    Private Function ReadInteger(ByVal index As Byte) As Integer
        Dim length As Byte = tmpClient(index).stream.ReadByte()
        Dim tmp(length) As Byte
        tmpClient(index).stream.Read(tmp, 0, length)
        Return Convert.ToInt32(ASCIIEncoding.UTF8.GetString(tmp))
    End Function

    Private Function ReadString(ByVal index As Byte) As String
        Dim length As Byte = tmpClient(index).stream.ReadByte()
        Dim tmp(length) As Byte
        tmpClient(index).stream.Read(tmp, 0, length)
        Return ASCIIEncoding.UTF8.GetString(tmp)
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
