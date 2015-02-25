Imports TGUI
Imports SFML.Window
Imports SFML.Graphics

Public Class GameActionCase
    Inherits AnimatedPicture

    Private Const PADDING = 5

    Private Shared emptyGameActionCases As List(Of GameActionCase) = New List(Of GameActionCase)

    Private inDragAndDrop As Boolean
    Private isEmptyCase As Boolean
    Private canDragDrop As Boolean
    Private tmpLocation As Vector2f
    Private tmpPaddingSelection As Vector2f
    Private dragNDropPadding As IntRect
    Private cliped As Boolean
    Private caseParent As Container

    Public Sub New()
        Me.inDragAndDrop = False
        Me.isEmptyCase = True
        Me.canDragDrop = True
        Me.tmpLocation = Me.Position
        Me.tmpPaddingSelection = New Vector2f
        Me.dragNDropPadding = New IntRect(PADDING, PADDING, Me.Size.X - PADDING * 2, Me.Size.Y - PADDING * 2)
        Me.cliped = False
    End Sub

    Private Sub GameActionCase_LeftMouseClick() Handles Me.LeftMouseClickedCallback
        If (Not isEmpty()) Then
            ' Do Something
        End If
    End Sub

    Private Sub GameActionCase_LeftMousePressed() Handles Me.LeftMousePressedCallback
        If (Not isEmpty() And canDragAndDrop()) Then
            If (Not inDragAndDrop) Then
                Me.tmpPaddingSelection = New Vector2f(Mouse.GetPosition(Main.window).X - Me.Position.X, Mouse.GetPosition(Main.window).Y - Me.Position.Y)
                Me.tmpLocation = Me.Position
                Me.inDragAndDrop = True
            End If
        End If
    End Sub

    Private Sub GameActionCase_LeftMouseReleased() Handles Me.LeftMouseReleasedCallback
        If (Not isEmpty() And canDragAndDrop()) Then
            inDragAndDrop = False

            If (Me.cliped) Then ' Si composant clipsé dans un autre
                Me.tmpLocation = Me.Position
            Else
                Me.Position = Me.tmpLocation
            End If
        End If
    End Sub

    ''' <summary>
    ''' Déplace le composant vers la position spécifiée en prenant en compte la position relative de selection
    ''' </summary>
    ''' <param name="X">Position horizontale de la selection</param>
    ''' <param name="Y">Position verticale de la selection</param>
    ''' <remarks></remarks>
    Protected Sub Move(X As Integer, Y As Integer)
        Me.Position = New Vector2f(X - tmpPaddingSelection.X, Y - tmpPaddingSelection.Y)
    End Sub

    Protected Overrides Sub OnUpdate()
        MyBase.OnUpdate()

        ' Update DragAndDrop current location
        If (inDragAndDrop And Mouse.IsButtonPressed(Mouse.Button.Left) And Me.Focused) Then
            Me.Move(Mouse.GetPosition(Main.window).X, Mouse.GetPosition(Main.window).Y)
        End If
    End Sub

    ''' <summary>
    ''' Défini ou obtient l'état du composant : Possibilité d'aquérir ou non un composant par Glisser Et Déposer
    ''' </summary>
    ''' <value>True si composant parent, False si composant enfant</value>
    ''' <returns>True si composant parent, False si composant enfant</returns>
    ''' <remarks></remarks>
    Public Property isEmpty() As Boolean
        Get
            Return Me.isEmptyCase
        End Get
        Set(value As Boolean)
            Me.isEmptyCase = value
            If (value) Then
                Me.MoveToBack()
            Else

            End If
        End Set
    End Property

    Public Property canDragAndDrop() As Boolean
        Get
            Return Me.canDragDrop
        End Get
        Set(value As Boolean)
            Me.canDragDrop = value
        End Set
    End Property

    Public Property ParentCase() As Container
        Get
            Return Me.caseParent
        End Get
        Private Set(value As Container)
            Me.caseParent = value
        End Set
    End Property
End Class
