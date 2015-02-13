Imports System.Net
Imports System.Net.Sockets

Public Class GameServer

    Public listenSock As TcpListener

    ' - Initialisation de l'écoute
    Public Sub Start()
        listenSock = New TcpListener(IPAddress.Any, 4608)
        listenSock.Start()
        Console.WriteLine("Serveur en écoute...")
        AcceptConnection()
    End Sub

    ' - Accepte la connexion entrante de manière asynchrone
    Private Sub AcceptConnection()
        Try
            listenSock.BeginAcceptTcpClient(AddressOf AcceptConnectionCallback, listenSock)
        Catch ex As Exception
            Console.WriteLine("Erreur lors de l'acceptation du client - " & ex.ToString)
        End Try
    End Sub

    Private Sub AcceptConnectionCallback(ByVal asyncResult As IAsyncResult)
        tmpClient.Add(New GameClient(listenSock.EndAcceptTcpClient(asyncResult)))
        AcceptConnection()
    End Sub

End Class
