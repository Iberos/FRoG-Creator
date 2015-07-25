Imports SFML.Graphics
Imports SFML.System

Public MustInherit Class GameEntity
    Inherits Sprite

    Protected Margin As New Vector2f

    Public ReadOnly Property Location As Vector2f
        Get
            Return Me.Position - Me.Margin
        End Get
    End Property

    Public ReadOnly Property WorldPosition As Vector2
        Get
            Return New Vector2(Me.Location.X / 32, Me.Location.Y / 32)
        End Get
    End Property
End Class
