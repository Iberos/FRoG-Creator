Imports SFML.Graphics

Public Class GamePlayer
    Inherits GameCharacter

    Public Sub New(texture As Texture)
        MyBase.New()
        MyBase.SetTexture(texture)
    End Sub

End Class
