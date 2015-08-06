
Imports SFML.System

Public Class GameTimer
    Private ticks As UInteger
    Private _miliseconds As Long

    Public Sub New()
        Me.ticks = 0
        _miliseconds = 0
    End Sub

    Public Function AsyncWait(ticks As UInteger)
        If (Me.ticks >= ticks) Then
            Me.ticks = 0
            Return True
        End If
        Me.ticks += 1
        Return False
    End Function

    Public Function AsyncWait(miliseconds As Long, timer As Time)
        If (_miliseconds >= miliseconds) Then
            _miliseconds = 0
            Return True
        End If
        _miliseconds += timer.AsMilliseconds
        Return False
    End Function
End Class
