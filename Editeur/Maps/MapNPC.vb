<Serializable>
Public Class MapNPC

    Public npc As GameNPC
    Public index As Short
    Public standing As Boolean
    Public random As Boolean
    Public perimeter As Boolean
    Public custom As Boolean
    Public velocity As Byte

    Public X As Byte
    Public Y As Byte

    Public Sub New(npc As GameNPC, x As Byte, y As Byte)
        Me.npc = npc
        Me.X = x
        Me.Y = y
    End Sub

End Class
