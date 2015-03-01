Imports SFML.Graphics
Imports SFML.Window
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Reflection

<Serializable>
Public Class GameMap
    Implements SFML.Graphics.Drawable

    Private Const MAP_WIDTH As UInteger = 672
    Private Const MAP_HEIGHT As UInteger = 480

    Private name As String
    Private type As Byte
    Private layer(6) As Layer ' couche entière
    Private attribute(20, 14) As GameAttribute ' attribut sur une case
    Private borderMap(8) As Integer ' maps au voisinage

    ' - Constructeur
    Public Sub New()
        For i = 0 To 6
            layer(i) = New Layer
        Next

        For x = 0 To 20
            For y = 0 To 14
                attribute(x, y) = New GameAttribute
            Next
        Next
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
                    If Not layer(z).tileCode(x, y) = 0 Then
                        ' TODO : Try Catch Le cas où le tileset voulu n'a pas été chargé
                        ' Console.WriteLine(.tileset(x, y).ToString())
                        Using sprt As New Sprite(GameDesigner.TILESETS_MEMORY_DATA.ElementAt(layer(z).tileset(x, y)))
                            sprt.TextureRect = New IntRect(GameTileset.DecodeX(layer(z).tileCode(x, y)) * 32, GameTileset.DecodeY(layer(z).tileCode(x, y)) * 32, 32, 32)
                            sprt.Position = New Vector2f(x * 32, y * 32)
                            target.Draw(sprt)
                        End Using
                    End If
                Next
            Next
        Next
    End Sub

    ' TODO : Remplacer par le deuxième RenderTexture
    Public Sub Draw2(target As RenderTarget, states As RenderStates)
        Dim sprt As Sprite
        For x = 0 To 20
            For y = 0 To 14
                For z = 3 To 6
                    If Not layer(z).tileCode(x, y) = 0 Then
                        ' TODO : Try Catch Le cas où le tileset voulu n'a pas été chargé
                        ' Console.WriteLine(.tileset(x, y).ToString())
                        Using sprt As New Sprite(GameDesigner.TILESETS_MEMORY_DATA.ElementAt(layer(z).tileset(x, y)))
                            sprt.TextureRect = New IntRect(GameTileset.DecodeX(layer(z).tileCode(x, y)) * 32, GameTileset.DecodeY(layer(z).tileCode(x, y)) * 32, 32, 32)
                            sprt.Position = New Vector2f(x * 32, y * 32)
                            target.Draw(sprt)
                        End Using
                    End If
                Next
            Next
        Next
    End Sub

    Public Shared Function Load(ByVal mapNum As UInteger)
        Try
            Dim deserializer As New BinaryFormatter
            Dim mapResult As GameMap
            If File.Exists(Main.MAPS_PATH + "Map" & mapNum & ".frog") Then
                deserializer.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
                deserializer.Binder = New GameMapDeserializationBinder

                Using reader = File.OpenRead(Main.MAPS_PATH + "Map" & mapNum & ".frog")
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

    Public Property MapsBorder(mapNum As Byte) As Integer
        Get
            Return If(Me.borderMap.Count > mapNum, Me.borderMap(mapNum), Nothing)
        End Get
        Set(value As Integer)
            If (Me.borderMap.Count > mapNum) Then
                Me.borderMap(mapNum) = value
            End If
        End Set
    End Property

    Public Property MapLayer(layerNum As Byte) As Layer
        Get
            Return If(Me.layer.Count > layerNum, Me.layer(layerNum), Nothing)
        End Get
        Set(value As Layer)
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
            If (Not IsNothing(Me.name)) Then
                Me.name = value
            End If
        End Set
    End Property

    Public Property MapType As Byte
        Get
            Return If(Not IsNothing(Me.type), Me.type, String.Empty)
        End Get
        Set(value As Byte)
            If (Not IsNothing(Me.type)) Then
                Me.type = value
            End If
        End Set
    End Property
End Class
