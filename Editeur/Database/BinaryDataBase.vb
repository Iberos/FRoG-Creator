Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class BinaryDataBase

    ' - Chargement des ressources
    Public Sub Load()
        ' Chargement des classes
        If Not Directory.Exists("Classes") Then Directory.CreateDirectory("Classes")
        LoadClasses()
        frmMapEditor.loadBar.Increment(25)

        ' Chargement des objets
        If Not Directory.Exists("Objets") Then Directory.CreateDirectory("Objets")
        LoadItems()
        frmMapEditor.loadBar.Increment(25)

        ' Chargement des sorts
        If Not Directory.Exists("Sorts") Then Directory.CreateDirectory("Sorts")
        LoadSpells()
        frmMapEditor.loadBar.Increment(25)

        ' Chargement des PNJs
        If Not Directory.Exists("PNJs") Then Directory.CreateDirectory("PNJs")
        LoadNPCs()
        frmMapEditor.loadBar.Increment(25)
    End Sub

    ' - Chargement des classes
    Private Sub LoadClasses()
        Dim reader As Stream
        Dim deserializer As New BinaryFormatter
        Dim num As Integer
        Dim tmp As New GameClass

        lstClasses.Clear()
        While File.Exists("Classes/Classe" & num & ".frog")
            Using reader = File.OpenRead("Classes/Classe" & num & ".frog")
                tmp = DirectCast(deserializer.Deserialize(reader), GameClass)
                lstClasses.Add(tmp)
                num += 1
            End Using
        End While
    End Sub

    ' - Chargement des objets
    Private Sub LoadItems()
        Dim reader As Stream
        Dim deserializer As New BinaryFormatter
        Dim num As Integer
        Dim tmp As New GameItem

        lstItems.Clear()
        While File.Exists("Objets/Objet" & num & ".frog")
            Using reader = File.OpenRead("Objets/Objet" & num & ".frog")
                tmp = DirectCast(deserializer.Deserialize(reader), GameItem)
                lstItems.Add(tmp)
                num += 1
            End Using
        End While
    End Sub

    ' - Chargement des sorts
    Private Sub LoadSpells()
        Dim reader As Stream
        Dim deserializer As New BinaryFormatter
        Dim num As Integer
        Dim tmp As New GameSpell

        lstSpells.Clear()
        While File.Exists("Sorts/Sort" & num & ".frog")
            Using reader = File.OpenRead("Sorts/Sort" & num & ".frog")
                tmp = DirectCast(deserializer.Deserialize(reader), GameSpell)
                lstSpells.Add(tmp)
                num += 1
            End Using
        End While
    End Sub

    ' - Chargement des PNJs
    Private Sub LoadNPCs()
        Dim reader As Stream
        Dim deserializer As New BinaryFormatter
        Dim num As Integer
        Dim tmp As New GameNPC

        lstNPCs.Clear()
        While File.Exists("PNJs/PNJ" & num & ".frog")
            Using reader = File.OpenRead("PNJs/PNJ" & num & ".frog")
                tmp = DirectCast(deserializer.Deserialize(reader), GameNPC)
                lstNPCs.Add(tmp)
                num += 1
            End Using
        End While
    End Sub

    ' - Sauvegarde de toutes les classes
    Public Sub SaveClasses()
        For i = 0 To lstClasses.Count - 1
            lstClasses(i).Save()
        Next
    End Sub

    ' - Sauvegarde de tous les objets
    Public Sub SaveItems()
        For i = 0 To lstItems.Count - 1
            lstClasses(i).Save()
        Next
    End Sub

    ' - Sauvegarde de tous les sorts
    Public Sub SaveSpells()
        For i = 0 To lstSpells.Count - 1
            lstSpells(i).Save()
        Next
    End Sub

    ' - Sauvegarde de tous les PNJs
    Public Sub SaveNPCs()
        For i = 0 To lstNPCs.Count - 1
            lstNPCs(i).Save()
        Next
    End Sub
End Class
