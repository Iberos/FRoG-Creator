Imports System.IO
Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable>
Public Class GameWorldMap

    <NonSerialized>
    Private Panel As Panel

    <NonSerialized>
    Private ButtonSize = New Size(50, 28)

    Private Maps(,) As GameWorldMapEntity = New GameWorldMapEntity(10, 10) {}

    Public Event EntityClick(sender As Object, e As EventArgs)

    Public Sub New(ByRef panel As Panel)
        ' Initialise la référence du panel
        Me.Panel = panel

        ' Initialisation du tableau de maps
        For x As Integer = 0 To Me.Maps.GetLength(0) - 1
            For y As Integer = 0 To Me.Maps.GetLength(1) - 1
                Me.Maps(x, y) = New GameWorldMapEntity(-1, New ExtendedButton(x, y))
            Next
        Next

        GeneratePanelContents()
    End Sub

    ''' <summary>
    ''' Obtient ou définit l'index de la map aux coordonées spécifiées
    ''' </summary>
    ''' <param name="x">Coordonnée X (horizontale)</param>
    ''' <param name="y">Coordonnée Y (verticale)</param>
    ''' <value>La map à insérer</value>
    ''' <returns>La map correspondante</returns>
    ''' <remarks></remarks>
    Public Property MapIndex(x As Integer, y As Integer) As Integer
        Get
            If (Me.Maps.GetLength(0) > x Or Not Me.Maps.GetLength(1) > y Or x < 0 Or y < 0) Then
                Return Nothing
            Else
                Return Me.Maps(x, y).Index
            End If
        End Get
        Set(value As Integer)
            If (Me.Maps.GetLength(0) > x Or Not Me.Maps.GetLength(1) > y Or x < 0 Or y < 0) Then
                Throw New NullReferenceException("Coordonnées en dehors des limites du tableau.")
            Else
                Me.Maps(x, y).Index = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Génère et initialise les boutons et les ajoutes dans le panel
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GeneratePanelContents()
        If (Me.Maps.Length > 0) Then

            For Each entity As GameWorldMapEntity In Me.Maps
                Dim button As ExtendedButton = entity.Button

                button.Size = ButtonSize
                button.Location = New Point(button.X * ButtonSize.Width - Me.Panel.HorizontalScroll.Value,
                                            button.Y * ButtonSize.Height - Me.Panel.VerticalScroll.Value)
                AddHandler button.Click, AddressOf Me.WorldMapButton_Click
                Me.Panel.Controls.Add(button)
            Next
        End If
    End Sub

    Private Sub WorldMapButton_Click(sender As Object, e As EventArgs)
        RaiseEvent EntityClick(sender, e)
    End Sub

    ' TODO : À tester
    Public Shared Function Load() As GameWorldMap
        Dim deserializer As New BinaryFormatter
        If File.Exists("Maps/WorldMap.frog") Then
            Using reader = File.OpenRead("Maps/WorldMap.frog")
                ' TODO : Catch les erreurs de déserialisation
                Return DirectCast(deserializer.Deserialize(reader), GameWorldMap)
            End Using
        End If
        Return Nothing
    End Function


    ' TODO : À tester
    Public Sub Save()
        Dim serializer As New BinaryFormatter
        serializer.AssemblyFormat = FormatterAssemblyStyle.Simple
        Using writer = File.Create("Maps/WorldMap.frog")
            serializer.Serialize(writer, Me)
        End Using
    End Sub
End Class
