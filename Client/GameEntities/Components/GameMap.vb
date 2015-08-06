Imports SFML.Graphics
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Reflection
Imports SFML.System

<Serializable>
Public Class GameMap
    Implements SFML.Graphics.Drawable

    Public Const NEIGHBOORS_COUNT = 8
    Public Const WIDTH As UInteger = 672
    Public Const HEIGHT As UInteger = 480

    Private name As String
    Private type As Byte
    Private mapIndex As Integer
    Private location As Vector2
    Private layer(6) As MapLayer ' couche entière
    Private attribute(20, 14) As GameAttribute ' attribut sur une case
    Private neighborsMapsIndexes(NEIGHBOORS_COUNT) As Integer ' maps au voisinage

    ' - Constructeur
    Public Sub New()
        Me.location = Vector2.Zero
        'For i = 0 To 6
        'layer(i) = New MapLayer
        'Next

        'For x = 0 To 20
        'For y = 0 To 14
        'attribute(x, y) = New GameAttribute
        'Next
        'Next
    End Sub

    Public Function isWalkable(location As Vector2f)
        ' TODO isWalkable condition  
        Return True
    End Function

    ' TODO : Générer 2 RenderTexture à la création de la map
    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw
        For x = 0 To 20
            For y = 0 To 14
                For z = 0 To 3
                    If (Not IsNothing(layer(z))) Then

                        If (Not layer(z).TileCode(x, y) = 0) Then
                            ' TODO : Try Catch Le cas où le tileset voulu n'a pas été chargé
                            Dim tilesetIndex = layer(z).TilesetIndex(x, y)
                            If (GameEnvironment.TILESETS.Count > tilesetIndex) Then
                                Using sprt As New Sprite(GameEnvironment.TILESETS.ElementAt(tilesetIndex))
                                    sprt.TextureRect = New IntRect(GameTileset.DecodeX(layer(z).TileCode(x, y)) * 32, GameTileset.DecodeY(layer(z).TileCode(x, y)) * 32, 32, 32)
                                    sprt.Position = New Vector2f(x * 32 + Me.location.X, y * 32 + Me.location.Y)
                                    target.Draw(sprt)
                                End Using
                            End If
                        End If
                    End If
                Next
            Next
        Next
    End Sub

    ' TODO : Remplacer par le deuxième RenderTexture
    Public Sub Draw2(target As RenderTarget, states As RenderStates)
        'Dim sprt As Sprite
        For x = 0 To 20
            For y = 0 To 14
                For z = 3 To 6
                    If Not layer(z).TileCode(x, y) = 0 Then
                        ' TODO : Try Catch Le cas où le tileset voulu n'a pas été chargé
                        Dim tilesetIndex = layer(z).TilesetIndex(x, y)
                        If (GameEnvironment.TILESETS.Count > tilesetIndex) Then
                            Using sprt As New Sprite(GameEnvironment.TILESETS.ElementAt(tilesetIndex))
                                sprt.TextureRect = New IntRect(GameTileset.DecodeX(layer(z).TileCode(x, y)) * 32, GameTileset.DecodeY(layer(z).TileCode(x, y)) * 32, 32, 32)
                                sprt.Position = New Vector2f(x * 32 + Me.location.X, y * 32 + Me.location.Y)
                                target.Draw(sprt)
                            End Using
                        End If
                    End If
                Next
            Next
        Next
    End Sub

    Public Shared Function Load(ByVal mapNum As Integer) As GameMap
        Try
            Dim deserializer As New BinaryFormatter
            Dim mapResult As GameMap
            If File.Exists(ContentType.MAPS + "Map" & mapNum & ".frog") Then
                deserializer.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
                deserializer.Binder = New GameMapDeserializationBinder

                Using reader = File.OpenRead(ContentType.MAPS + "Map" & mapNum & ".frog")
                    mapResult = DirectCast(deserializer.Deserialize(reader), GameMap)
                End Using

                Return mapResult
            End If
        Catch ex As Exception
            MsgBox("Une erreur est survenue lors du chargement d'une carte de jeu." _
                   + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "Erreur critique")
            Environment.Exit(1)
        End Try
        Return Nothing
    End Function

    Public Shared Function Load(ByVal mapName As String) As GameMap
        Try
            Dim deserializer As New BinaryFormatter
            Dim mapResult As GameMap
            If File.Exists(ContentType.MAPS + mapName) Then
                deserializer.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
                deserializer.Binder = New GameMapDeserializationBinder

                Using reader = File.OpenRead(ContentType.MAPS + mapName)
                    mapResult = DirectCast(deserializer.Deserialize(reader), GameMap)
                End Using

                Return mapResult
            End If
        Catch ex As Exception
            MsgBox("Une erreur est survenue lors du chargement d'une carte de jeu." _
                   + Environment.NewLine + ex.Message, MsgBoxStyle.Critical, "Erreur critique")
            Environment.Exit(1)
        End Try
        Return Nothing
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
            Me.location = value
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

    Public Property NeighborIndex(neighborNum As Byte) As Integer
        Get
            Return If(Me.neighborsMapsIndexes.Count > neighborNum, Me.neighborsMapsIndexes(neighborNum), -1)
        End Get
        Set(value As Integer)
            If (Me.neighborsMapsIndexes.Count > neighborNum) Then
                Me.neighborsMapsIndexes(neighborNum) = value
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
End Class
