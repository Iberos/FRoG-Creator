Imports TGUI
Imports SFML.Graphics
Imports SFML.System

Public Interface Designer
    Sub Load(gui As RenderInterface, configPath As String)
    Sub Draw(batch As RenderWindow)
    Sub DispatchEventsAndUpdate(batch As RenderWindow, clock As Clock)

End Interface
