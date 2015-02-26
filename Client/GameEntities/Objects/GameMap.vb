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

    <NonSerialized>
    Private mapSurface(6) As RenderTexture


    ' - Constructeur
    Public Sub New()
        'AddHandler AppDomain.CurrentDomain.AssemblyResolve, New ResolveEventHandler(AddressOf CurrentDomain_AssemblyResolve)

        For i = 0 To 6
            layer(i) = New Layer
        Next

        For x = 0 To 20
            For y = 0 To 14
                attribute(x, y) = New GameAttribute
            Next
        Next

        For mapLayerIndex As Integer = 0 To 6
            mapSurface(mapLayerIndex) = New RenderTexture(MAP_WIDTH, MAP_HEIGHT)
            mapSurface(mapLayerIndex).Draw(LayerTexture(mapLayerIndex))
        Next
    End Sub

    'Private Function CurrentDomain_AssemblyResolve(sender As Object, args As ResolveEventArgs) As Assembly
    '    Dim ayResult As Assembly = Nothing
    '    Dim sShortAssemblyName As String = args.Name.Split(","c)(0)
    '    Dim ayAssemblies As Assembly() = AppDomain.CurrentDomain.GetAssemblies()
    '    For Each ayAssembly As Assembly In ayAssemblies
    '        If sShortAssemblyName = ayAssembly.FullName.Split(","c)(0) Then
    '            ayResult = ayAssembly
    '            Exit For
    '        End If
    '    Next
    '    Return ayResult
    'End Function

    Public Function isWalkable(location As Vector2f)
        ' TODO isWalkable condition  
        Return True
    End Function

    ' - Retourne une texture correspondant à la couche demandée
    Private Function LayerTexture(ByVal layerNum As Byte) As Texture
        Dim layerSurface As New RenderTexture(MAP_WIDTH, MAP_HEIGHT)
        Dim sprt As Sprite
        layerSurface.Clear(New Color(0, 0, 0, 0))

        With Me.layer(layerNum)
            For x = 0 To 20
                For y = 0 To 14
                    If Not layer(layerNum).tileCode(x, y) = 0 Then
                        ' TODO : Try Catch Le cas où le tileset voulu n'a pas été chargé
                        sprt = New Sprite(GameDesigner.TILESETS_MEMORY_DATA.ElementAtOrDefault(.tileset(x, y)))
                        sprt.TextureRect = New IntRect(GameTileset.DecodeX(.tileCode(x, y)) * 32, GameTileset.DecodeY(.tileCode(x, y)) * 32, 32, 32)
                        sprt.Position = New Vector2f(x * 32, y * 32)
                        layerSurface.Draw(sprt)
                        sprt.Dispose()
                    End If
                Next
            Next
        End With

        Return layerSurface.Texture
    End Function

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw
        ' Dessin des couches inférieures seulement
        For i = 0 To 3
            target.Draw(New Sprite(mapSurface(i).Texture))
        Next
    End Sub

    Public Shared Function Load(ByVal mapNum As UInteger)
        Try
            ' TODO : Erreur de version
            Dim deserializer As New BinaryFormatter
            Dim reader As Stream
            Dim mapResult As GameMap
            If File.Exists(Main.MAPS_PATH + "Map" & mapNum & ".frog") Then
                'deserializer.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
                deserializer.Binder = New GameMapDeserializationBinder
                reader = File.OpenRead(Main.MAPS_PATH + "Map" & mapNum & ".frog")
                mapResult = DirectCast(deserializer.Deserialize(reader), GameMap)
                reader.Close() : reader.Dispose()
                Return mapResult
            End If
        Catch ex As Exception
            Console.WriteLine("{0}" + Environment.NewLine + "{1}", ex.Data.ToString(), ex.Message)
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
