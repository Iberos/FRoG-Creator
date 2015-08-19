<Serializable>
Public Class GameWorldMapEntity

    Public Index As Integer

    <NonSerialized>
    Public Button As ExtendedButton


    Public Sub New(index As Integer, button As ExtendedButton)
        Me.Index = index
        Me.Button = button
    End Sub
End Class
