Imports System.Runtime.CompilerServices
Imports TGUI
Imports SFML.Graphics


Module GuiExtension
    <Extension()>
    Public Sub AddReckonLine(ByVal chatbox As ChatBox, ByVal text As String, ByVal color As Color)
        chatbox.AddLine(text, color)
        Dim ftext As New Text(text, chatbox.TextFont, chatbox.TextSize)
        Dim nbLines = Math.Floor(ftext.GetLocalBounds.Width / (chatbox.Size.X - 10))

        Dim i As Integer = 0
        While (i < nbLines)
            i += 1
            chatbox.AddLine("") 'new line
        End While

    End Sub
End Module
