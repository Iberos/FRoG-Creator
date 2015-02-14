Imports SFML
Imports SFML.Graphics
Imports SFML.Window

Public MustInherit Class GameCharacter
    Inherits GameEntity
    Implements IUpdatable

    Protected Shared DEFAULT_DIRECTION As GameDirection = GameDirection.DOWN
    Protected Shared DEFAULT_VELOCITY As GameVelocity = GameVelocity.Normal
    Protected Shared DEFAULT_ANIMATION_MARK As UInteger = 0
    Protected Shared DEFAULT_ANIMATION_TIMEWAIT As UInteger = 10
    Protected Shared DEFAULT_INACTIVE_TIMEWAIT As UInteger = 10

    Protected canMove As Boolean
    Protected futurPosition As Vector2f
    Protected direction As GameDirection
    Protected velocity As Byte
    Protected animationMark As Integer
    Protected movementPath As List(Of GameDirection)
    Protected animationTimer As GameTimer
    Protected timeleftTimer As GameTimer
    Protected characterSize As Vector2f

    Public Sub New()
        Me.canMove = True
        Me.futurPosition = Me.Position
        Me.direction = DEFAULT_DIRECTION
        Me.velocity = DEFAULT_VELOCITY
        Me.animationMark = DEFAULT_ANIMATION_MARK
        Me.movementPath = New List(Of GameDirection)
        Me.animationTimer = New GameTimer()
        Me.timeleftTimer = New GameTimer()
    End Sub

    Public Sub SetTexture(texture As Texture)
        Me.Texture = texture
        Me.characterSize = New Vector2f(texture.Size.X / 4, texture.Size.Y / 4)
        Me.TextureRect = New IntRect(0, 0, Me.characterSize.X, Me.characterSize.Y)
    End Sub

    Public Sub MoveTo(direction As GameDirection)
        Me.direction = direction
        Me.futurPosition = Me.Position + Me.direction.GetVector() * 32
        Me.canMove = False
    End Sub

    Public Sub AddMovement(direction As GameDirection)
        Me.movementPath.Add(direction)
    End Sub

    Public Sub Update() Implements IUpdatable.Update

        ' Déplacement de l'entité selon son chemin prédéfini
        If (Me.movementPath.Count > 0 And Me.canMove) Then
            Me.MoveTo(Me.movementPath.ElementAt(0))
            Me.movementPath.RemoveAt(0)
        End If

        If (Not Me.Position.Equals(Me.futurPosition) And Not Me.canMove) Then
            ' Déplacement de la position de l'entité
            Me.Position += Me.direction.GetVector * Me.velocity

            ' Animation de déplacement
            If (Me.animationTimer.AsyncWait(DEFAULT_ANIMATION_TIMEWAIT / Me.velocity)) Then
                Me.animationMark = If(Me.animationMark >= 3, 0, Me.animationMark + 1)
            End If
        Else
            ' Rend de nouveau possible les futurs déplacements de l'entité
            If (Not Me.canMove) Then
                Me.canMove = True
            End If

            ' Mise à jour de l'inactivité de l'entité
            If (Me.timeleftTimer.AsyncWait(DEFAULT_INACTIVE_TIMEWAIT)) Then
                Me.animationMark = 0
            End If
        End If

        ' Mise à jour de l'affichage de l'entité
        Me.TextureRect = New IntRect(Me.characterSize.X * Me.animationMark, Me.characterSize.Y * Me.direction.GetIndex(), Me.characterSize.X, Me.characterSize.Y)
    End Sub

    Public Property isMoveable() As Boolean
        Get
            Return Me.canMove
        End Get
        Protected Set(ByVal value As Boolean)
            Me.canMove = value
        End Set
    End Property

End Class
