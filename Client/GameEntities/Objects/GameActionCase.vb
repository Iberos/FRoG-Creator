Imports TGUI
Imports SFML.Window

Public Class GameActionCase
    Inherits AnimatedPicture

    Private inDragAndDrop As Boolean
    Private isEmptyCase As Boolean
    Private canDragDrop As Boolean
    Private tmpLocation As Vector2f
    Private tmpPaddingSelection As Vector2f

    Public Sub New()
        Me.inDragAndDrop = False
        Me.isEmptyCase = True
        Me.canDragDrop = True
        Me.tmpLocation = Me.Position
        Me.tmpPaddingSelection = New Vector2f()
    End Sub

    Private Sub GameActionCase_LeftMouseClick() Handles Me.LeftMouseClickedCallback
        If (Not isEmpty()) Then
            ' Do Something
        End If
    End Sub

    Private Sub GameActionCase_LeftMousePressed() Handles Me.LeftMousePressedCallback
        If (Not isEmpty() And canDragAndDrop()) Then
            If (Not inDragAndDrop) Then
                tmpPaddingSelection = New Vector2f(Mouse.GetPosition(Main.window).X - Me.Position.X, Mouse.GetPosition(Main.window).Y - Me.Position.Y)
                inDragAndDrop = True
            End If
        End If
    End Sub

    Private Sub GameActionCase_LeftMouseReleased() Handles Me.LeftMouseReleasedCallback
        If (Not isEmpty() And canDragAndDrop()) Then
            inDragAndDrop = False
        End If
    End Sub

    Protected Overrides Sub OnUpdate()
        MyBase.OnUpdate()

        ' Update DragAndDrop current location
        If (inDragAndDrop And Mouse.IsButtonPressed(Mouse.Button.Left) And Me.Focused) Then
            Me.Position = New Vector2f(Mouse.GetPosition(Main.window).X - tmpPaddingSelection.X, Mouse.GetPosition(Main.window).Y - tmpPaddingSelection.Y)
        End If
    End Sub

    Public Property isEmpty() As Boolean
        Get
            Return Me.isEmptyCase
        End Get
        Set(value As Boolean)
            Me.isEmptyCase = value
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
End Class
