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

    Private Property canMove As Boolean
    Private Property canControl As Boolean

    Private futurPosition As Vector2f
    Private direction As GameDirection
    Private velocity As Byte
    Private animationMark As Integer
    Private movementPath As List(Of GameDirection)
    Private animationTimer As GameTimer
    Private timeleftTimer As GameTimer
    Private characterHitboxSize As Vector2f

    Public Sub New()
        Me.canMove = True
        Me.canControl = True
        Me.futurPosition = Me.Position
        Me.direction = DEFAULT_DIRECTION
        Me.velocity = DEFAULT_VELOCITY
        Me.animationMark = DEFAULT_ANIMATION_MARK
        Me.movementPath = New List(Of GameDirection)
        Me.animationTimer = New GameTimer()
        Me.timeleftTimer = New GameTimer()
    End Sub

    Private Sub Move(direction As GameDirection)
        If (Me.canMove) Then
            Me.direction = direction
            Me.futurPosition = Me.Position + Me.direction.GetVector() * 32
            Me.canMove = False
        End If
    End Sub

    Public Sub WarpTo(x As Integer, y As Integer)
        Me.Position = New Vector2f(x, y) * 32
        Me.futurPosition = Position
    End Sub

    Public Sub MoveTo(direction As GameDirection)
        If (canControl) Then
            Me.movementPath.Clear()
            Move(direction)
        End If
    End Sub

    Public Sub AddMovement(direction As GameDirection)
        Me.movementPath.Add(direction)
    End Sub

    Public Sub Update() Implements IUpdatable.Update

        ' Déplacement de l'entité selon son chemin prédéfini
        If (Me.movementPath.Count > 0 And Me.canMove) Then
            Me.Move(Me.movementPath.ElementAt(0))
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
        Me.TextureRect = New IntRect(Me.characterHitboxSize.X * Me.animationMark, Me.characterHitboxSize.Y * Me.direction.GetIndex(), Me.characterHitboxSize.X, Me.characterHitboxSize.Y)
    End Sub

#Region "Getter & Setter"
    ''' <summary>
    ''' Modifie l'état de controle du caractère
    ''' </summary>
    ''' <param name="state">True pour laisser le character controlable et False pour en interdire le controle</param>
    ''' <remarks></remarks>
    Public Sub SetCharacterControls(ByRef state As Boolean)
        Me.canControl = state
    End Sub

    ''' <summary>
    ''' Modifie la vitesse de course du caractère
    ''' </summary>
    ''' <param name="velocity">La vitesse du caractère</param>
    ''' <remarks></remarks>
    Public Sub SetVelocity(ByRef velocity As GameVelocity)
        Me.velocity = velocity
    End Sub

    ''' <summary>
    ''' Modifie le rendu du caractère
    ''' </summary>
    ''' <param name="texture">La nouvelle texture de rendu du caractère</param>
    ''' <remarks></remarks>
    Public Sub SetTexture(texture As Texture)
        Me.Texture = texture
        Me.characterHitboxSize = New Vector2f(texture.Size.X / 4, texture.Size.Y / 4)
        Me.TextureRect = New IntRect(0, 0, Me.characterHitboxSize.X, Me.characterHitboxSize.Y)
    End Sub

    Public Function isMoveable() As Boolean
        Return Me.canMove
    End Function

    Public Function isControlable() As Boolean
        Return Me.canControl
    End Function

    Public Function getVelocity() As GameVelocity
        Return Me.velocity
    End Function
#End Region

End Class
