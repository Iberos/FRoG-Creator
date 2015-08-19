Imports SFML.Graphics
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Reflection
Imports SFML.System
Imports System.Runtime.Serialization.Formatters

<Serializable>
Public Class GameMap
    Implements Drawable

    Public Const WIDTH As UInteger = 672
    Public Const HEIGHT As UInteger = 480

    Private name As String
    Private type As Byte
    Private mapIndex As Integer
    Private location As Vector2
    Private layer(6) As MapLayer ' couche entière
    Private attribute(20, 14) As GameAttribute ' attribut sur une case

    Private renderTexture As RenderTexture
    Private render As Sprite

    ' - Constructeur
    Public Sub New()
        Me.location = Vector2.Zero
    End Sub

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw
        target.Draw(MapRender)
    End Sub

    Public Shared Function Load(ByVal mapNum As Integer) As GameMap
        Try
            Dim deserializer As New BinaryFormatter
            Dim mapResult As GameMap
            If File.Exists(ContentType.MAPS + "Map" & mapNum & ".frog") Then
                deserializer.AssemblyFormat = FormatterAssemblyStyle.Simple
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
                deserializer.AssemblyFormat = FormatterAssemblyStyle.Simple
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

    ''' <summary>
    ''' Retourne le rendu de la map à dessiner. Le créer s'il n'existe pas
    ''' </summary>
    ''' <returns>Le rendu de la map</returns>
    Private ReadOnly Property MapRender
        Get
            ' Génération du Render s'il n'existe pas
            If (IsNothing(Me.render)) Then
                Me.renderTexture = New RenderTexture(GameMap.WIDTH, GameMap.HEIGHT)
                Me.renderTexture.Clear()

#Region "Boucle de dessin"
                For x = 0 To 20
                    For y = 0 To 14
                        For z = 0 To 3
                            If (Not IsNothing(layer(z)) And Not layer(z).TileCode(x, y) = 0) Then
                                ' TODO : Try Catch Le cas où le tileset voulu n'a pas été chargé
                                Dim tilesetIndex = layer(z).TilesetIndex(x, y)
                                If (GameEnvironment.Tilesets.Count > tilesetIndex) Then
                                    Using sprt As New Sprite(GameEnvironment.Tilesets.ElementAt(tilesetIndex))
                                        sprt.TextureRect = New IntRect(GameTileset.DecodeX(layer(z).TileCode(x, y)) * 32, GameTileset.DecodeY(layer(z).TileCode(x, y)) * 32, 32, 32)
                                        sprt.Position = New Vector2f(x * 32 + Me.location.X, y * 32 + Me.location.Y)
                                        renderTexture.Draw(sprt)
                                    End Using
                                End If
                            End If
                        Next
                    Next
                Next
#End Region

                Me.renderTexture.Display()
            End If
            ' Obligation de recréation du sprite afin d'éviter sa suppression par le garbage
            Me.render = New Sprite(renderTexture.Texture)
            Return Me.render
        End Get
    End Property
End Class
