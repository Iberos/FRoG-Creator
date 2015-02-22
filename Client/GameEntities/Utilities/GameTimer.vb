Imports PathFinderLibrary

Public Class GameTimer
    Private ticks As UInteger

    Public Sub New()
        Me.ticks = 0
    End Sub

    Public Function AsyncWait(ticks As UInteger)
        If (Me.ticks >= ticks) Then
            Me.ticks = 0
            Return True
        End If
        Me.ticks += 1
        Return False
    End Function

    ' TODO : GetCurrentFPS
    Public Function AsyncWait(seconds As UInteger, fps As UInteger)
        If ((Me.ticks / fps) >= seconds) Then
            Me.ticks = 0
            Return True
        End If
        Me.ticks += 1
        Return False
    End Function
End Class
