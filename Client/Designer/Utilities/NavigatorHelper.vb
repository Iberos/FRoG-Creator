Public Class NavigatorHelper

    Public Shared Sub NavigateTo(state As GameStates)
        Select Case (state)
            Case GameStates.AccountConnectionState
                Main.Designer = RenderInterface.AccountConnecterState
            Case GameStates.CharacterSelectionState
                Main.Designer = RenderInterface.CharacterSelectionState
            Case GameStates.GamePlayState
                Main.Designer = RenderInterface.GamePlayState
            Case GameStates.ServerSelectionState
                Main.Designer = RenderInterface.ServerConnecterState
        End Select
        Main.Render.InitializeDesigner()
    End Sub
End Class
