Imports MySql.Data.MySqlClient

Module Main

    Dim server As String
    Dim user As String
    Dim password As String
    Dim database As String
    Dim conn As New MySqlConnection

    Sub Main()
        Console.WriteLine("Frog Creator Version VB.NET")
    End Sub

    Sub CheckBDD(ByVal server As String, ByRef user As String, ByRef password As String, ByRef database As String)
        conn.ConnectionString = "server=" + server + ";" _
        & "user id=" + user + ";" _
        & "password=" + password + ";" _
        & "database=" + database + ";"
        Try
            conn.Open()

        Catch ex As MySqlException
            ' Si il y a un problème
            Console.WriteLine("Connection à la base de donnée MYSQL impossible")
        End Try
    End Sub

    Sub Login(ByVal Pseudo As String, ByRef Password As String)
        'Lancement de la connection sur le serveur SQL
        Dim myAdapter As New MySqlDataAdapter ' /!\ Attention aux injections SQL
        Dim sqlquery = String.Format("SELECT * FROM Frog_User Where login = '{0}' AND password '{1}'", Pseudo, Password) ' Table Name : Accounts (better ?)
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = conn
        myCommand.CommandText = sqlquery
        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader
        If myData.HasRows = 0 Then
            Console.WriteLine("Pseudo ou mot de passe incorrect")
        Else
            Console.WriteLine("Identification acceptée")
        End If
    End Sub

End Module
