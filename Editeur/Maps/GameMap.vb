Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports SFML.Window
Imports SFML.Graphics

<Serializable>
Public Class GameMap
    Implements Drawable

    Public Const NEIGHBOORS_COUNT = 8
    Private Const WIDTH As UInteger = 672
    Private Const HEIGHT As UInteger = 480

    Private name As String
    Private type As Byte
    Private mapIndex As Integer
    Private location As Vector2
    Private layer(6) As MapLayer ' couche entière
    Private attribute(20, 14) As GameAttribute ' attribut sur une case

    'Non serializable : RenderTexture, Sprite, Texture, Image

    <NonSerialized>
    Private mapNPCs As New List(Of MapNPC) ' Liste des pnjs sur la map

    ' - Constructeur
    Sub New(ByVal index As Integer)
        Me.location = Vector2.Zero
        Me.Index = index

        For i = 0 To 6
            layer(i) = New MapLayer
        Next

        For x = 0 To 20
            For y = 0 To 14
                attribute(x, y) = New GameAttribute
            Next
        Next
    End Sub

    Public Function GetMapNPCList() As List(Of MapNPC)
        If IsNothing(mapNPCs) Then
            mapNPCs = New List(Of MapNPC)
        End If
        Return mapNPCs
    End Function

    Public Property Attribut(X As Byte, Y As Byte) As GameAttribute
        Get
            Return If(Me.attribute.GetLength(0) > X And Me.attribute.GetLength(1) > Y, Me.attribute(X, Y), Nothing)
        End Get
        Set(value As GameAttribute)
            If (Me.attribute.GetLength(0) > X And Me.attribute.GetLength(1) > Y) Then
                Me.attribute(X, Y) = value
            End If
        End Set
    End Property

    Public Property Origin As Vector2
        Get
            Return If(Not IsNothing(Me.location), Me.location, Vector2.Zero)
        End Get
        Set(value As Vector2)
            If (Not IsNothing(Me.location)) Then
                Me.location = value
            End If
        End Set
    End Property

    Public Property MapLayer(layerNum As Byte) As MapLayer
        Get
            Return If(Me.layer.Count > layerNum, Me.layer(layerNum), Nothing)
        End Get
        Set(value As MapLayer)
            If (Me.layer.Count > layerNum) Then
                Me.layer(layerNum) = value
            End If
        End Set
    End Property

    Public Property MapName As String
        Get
            Return If(Not IsNothing(Me.name), Me.name, String.Empty)
        End Get
        Set(value As String)
            Me.name = value
        End Set
    End Property

    Public Property Index As Integer
        Get
            Return If(Not IsNothing(Me.mapIndex), Me.mapIndex, 0)
        End Get
        Set(value As Integer)
            Me.mapIndex = value
        End Set
    End Property

    Public Property MapType As Byte
        Get
            Return If(Not IsNothing(Me.type), Me.type, 0)
        End Get
        Set(value As Byte)
            If (Not IsNothing(Me.type)) Then
                Me.type = value
            End If
        End Set
    End Property

    Public Shared Function Load(ByVal mapNum As Integer) As GameMap
        Dim deserializer As New BinaryFormatter
        If File.Exists("Maps/Map" & mapNum & ".frog") Then
            Using reader = File.OpenRead("Maps/Map" & mapNum & ".frog")
                ' TODO : Catch les erreurs de déserialisation
                Return DirectCast(deserializer.Deserialize(reader), GameMap)
            End Using
        End If
        Return Nothing
    End Function

    ' - Charge la map indiquée
    Public Sub LoadIntoEditor(ByVal mapNum As Integer)
        map = Load(mapNum)
        If (IsNothing(map)) Then
            MsgBox("Erreur lors du chargement de la carte de jeu.", MsgBoxStyle.Critical, "Erreur")
            Return ' Afficher erreur de chargement
        End If
        lstBackup = New List(Of Byte())
        curBck = 0
        BackUp()
        ' Verouillage des boutons "annuler" et "rétablir"
        frmMapEditor.ButtonBefore.Enabled = False
        frmMapEditor.ButtonAfter.Enabled = False
        ' Affiche le nom de la map
        If Not map.name = "" Then frmMapEditor.LabelMapName.Text = map.name Else frmMapEditor.LabelMapName.Text = "Sans Titre"
    End Sub

    ' - Sauvegarde la map en cours
    Public Sub Save()
        Dim serializer As New BinaryFormatter
        serializer.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
        Using writer = File.Create("Maps/Map" & curMap & ".frog")
            serializer.Serialize(writer, map)
        End Using
    End Sub

    ' - Sauvegarde en mémoire la map avant modification
    Public Sub BackUp()
        Dim formater As New BinaryFormatter
        Using stream As New IO.MemoryStream
            formater.Serialize(stream, map)
            lstBackup.Insert(curBck, stream.ToArray)
        End Using
        curBck += 1
        ' Déverouillage du bouton "annuler"
        frmMapEditor.ButtonBefore.Enabled = True
    End Sub

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw

    End Sub
End Class
