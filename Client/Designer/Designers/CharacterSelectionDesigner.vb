Imports TGUI
Imports SFML.Window
Imports SFML.Graphics
Imports SFML.System

Public Class CharacterSelectionDesigner
    Implements Designer

    Public Sub New()

    End Sub

    Public Sub Load(gui As RenderInterface, configPath As String) Implements Designer.Load
        gui.RemoveAllWidgets()
    End Sub

    Public Sub DispatchEventsAndUpdate(batch As RenderWindow, time As Time) Implements Designer.DispatchEventsAndUpdate

    End Sub

    Public Sub Draw(batch As RenderWindow) Implements Designer.Draw

    End Sub
End Class
