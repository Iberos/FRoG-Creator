Imports System.Net
Imports System.Net.Sockets

Public Class GameClient
    Implements IDisposable

    Public socket As TcpClient
    Public stream As NetworkStream
    Public handler As Dictionary(Of Byte, Action)

    ' - Constructeur
    Public Sub New()
        InitHandler()
        socket = New TcpClient()
    End Sub

    ' - Initialisation des packets
    Private Sub InitHandler()
        handler = New Dictionary(Of Byte, Action)
        handler.Add(ServerPacket.LoginANS, AddressOf HandleLoginANS)
        handler.Add(ServerPacket.RegisterANS, AddressOf HandleRegisterANS)
        handler.Add(ServerPacket.NewCharANS, AddressOf HandleNewCharANS)
    End Sub

    ' - Connexion au serveur
    Public Sub Connect(ByVal ip As String, ByVal port As Integer)
        Try
            socket.BeginConnect(ip, port, AddressOf ConnectCallback, socket)
        Catch ex As Exception
            Console.WriteLine("Impossible de se connecter au serveur")
        End Try
    End Sub

    Private Sub ConnectCallback(ByVal asyncResult As IAsyncResult)
        If socket.Connected Then
            stream = socket.GetStream
            Console.WriteLine("Connecté au serveur")
        Else
            Console.WriteLine("Serveur hors ligne")
        End If
    End Sub

    ' - Réception des packets venant du serveur
    Public Sub HandleData()
        If socket.Client.Poll(10, SelectMode.SelectRead) AndAlso socket.Client.Available = 0 Then
            socket.Close()
            'stream.Close()
            Console.WriteLine("connexion perdue avec le serveur")
        ElseIf socket.Client.Available > 0 Then
            Console.WriteLine("Ok")
        End If
    End Sub

    Public Function isConnected() As Boolean
        Return Me.socket.Connected
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        Me.socket.Close()
    End Sub
End Class
