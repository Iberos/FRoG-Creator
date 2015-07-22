Public Class GameWorldMap

    Private Panel As Panel
    Private ButtonSize = New Size(50, 28)
    Private Maps(,) As GameWorldMapEntity = New GameWorldMapEntity(10, 10) {}

    Public Event EntityClick(sender As Object, e As EventArgs)

    Public Sub New(ByRef panel As Panel)
        ' Initialise la référence du panel
        Me.Panel = panel

        ' Initialisation du tableau de maps
        For x As Integer = 0 To Me.Maps.GetLength(0) - 1
            For y As Integer = 0 To Me.Maps.GetLength(1) - 1
                Me.Maps(x, y) = New GameWorldMapEntity(New GameMap(-1), New ExtendedButton(x, y))
            Next
        Next

        GeneratePanelContents()
    End Sub

    ''' <summary>
    ''' Obtient ou définit la map aux coordonées spécifiées (WorldMap)
    ''' </summary>
    ''' <param name="x">Coordonnée X (horizontale)</param>
    ''' <param name="y">Coordonnée Y (verticale)</param>
    ''' <value>La map à insérer</value>
    ''' <returns>La map correspondante</returns>
    ''' <remarks></remarks>
    Public Property Map(x As Integer, y As Integer) As GameMap
        Get
            If (Me.Maps.GetLength(0) > x Or Not Me.Maps.GetLength(1) > y Or x < 0 Or y < 0) Then
                Return Nothing
            Else
                Return Me.Maps(x, y).Map
            End If
        End Get
        Set(value As GameMap)
            If (Me.Maps.GetLength(0) > x Or Not Me.Maps.GetLength(1) > y Or x < 0 Or y < 0) Then
                Throw New NullReferenceException("Coordonnées en dehors des limites du tableau de maps.")
            Else
                Me.Maps(x, y).Map = value
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

End Class
