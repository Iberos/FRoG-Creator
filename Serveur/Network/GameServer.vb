Imports System.Net
Imports System.Net.Sockets

Public Class GameServer

    Public listenSock As TcpListener

    ' - Initialisation de l'écoute
    Public Sub Start()
        Dim port As Integer = 4608
        Dim IP As String = "127.0.0.1"
        listenSock = New TcpListener(IPAddress.Any, port)
        listenSock.Start()
        Console.WriteLine("Serveur lancé")
        Console.WriteLine("========== Informations de connexion ==========")
        Console.WriteLine("Adresse IP: " & IP)
        Console.WriteLine("Port: " & port)
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
