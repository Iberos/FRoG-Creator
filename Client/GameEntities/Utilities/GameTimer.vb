
Public Class GameTimer
    Private ticks As UInteger

    Public Sub New()
        Me.ticks = 0
    End Sub

    'TODO : Prendre en compte les FPS
    Public Function AsyncWait(ticks As UInteger)
        If (Me.ticks >= ticks) Then
            Me.ticks = 0
            Return True
        End If
        Me.ticks += 1
        Return False
    End Function
End Class
