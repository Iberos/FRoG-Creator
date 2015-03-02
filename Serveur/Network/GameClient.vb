Imports System.Net
Imports System.Net.Sockets
Imports System.Collections.Generic
Imports System.Threading.Thread

Public Class GameClient

    Public socket As TcpClient
    Public stream As NetworkStream
    Public buffer As NetworkBuffer
    Public handler As Dictionary(Of Byte, Action(Of Byte))
    Private handleTask As New Task(AddressOf HandleData)

    Public Sub New(ByVal acceptedSock As TcpClient)

        Try
            socket = acceptedSock
            stream = socket.GetStream
            buffer = New NetworkBuffer
            InitHandler()
            handleTask.Start()
            Console.WriteLine("Connexion acceptée sur le slot #" & tmpClient.Count)
        Catch ex As Exception
            Console.WriteLine("Impossible d'accepter le client - " & ex.ToString)
        End Try

    End Sub

    Private Sub InitHandler()
        handler = New Dictionary(Of Byte, Action(Of Byte))
        handler.Add(ClientPacket.Login, AddressOf HandleLogin)
        handler.Add(ClientPacket.Register, AddressOf HandleRegister)
        handler.Add(ClientPacket.NewChar, AddressOf HandleNewChar)
    End Sub

    Private Sub HandleData()
        Dim myIndex As Byte = tmpClient.IndexOf(Me)

        While socket.Connected
            If socket.Client.Poll(10, SelectMode.SelectRead) AndAlso socket.Client.Available = 0 Then
                socket.Close()
                stream.Close()
            ElseIf socket.Client.Available > 0 Then
                handler(buffer.Read(myIndex, TypeCode.Byte))(myIndex)
            End If
        End While
        Console.WriteLine("Connexion perdue sur le slot #" & myIndex.ToString)
    End Sub
End Class
