Imports SFML.Graphics
Imports System.IO

Public Class GameTileset
    Inherits Sprite

    Public Sub New(texture As Texture)
        MyBase.New(texture)
    End Sub

    Public Shared Function Load(ByVal tilesetNum As UInteger)
        Dim tilesetResult As GameTileset
        If (File.Exists(Main.TILESETS_PATH + "Tiles" & tilesetNum.ToString() & ".png")) Then
            tilesetResult = New GameTileset(New Texture(Main.TILESETS_PATH + "Tiles" & tilesetNum.ToString() & ".png"))
            Return tilesetResult
        End If
        Return Nothing
    End Function

    Public Shared Function Load(ByVal tilesetName As String)
        Dim tilesetResult As GameTileset
        If (File.Exists(Main.TILESETS_PATH + tilesetName)) Then
            tilesetResult = New GameTileset(New Texture(Main.TILESETS_PATH + tilesetName))
            Return tilesetResult
        End If
        Return Nothing
    End Function

    ' - Comptacte les valeurs X et Y du tiles
    Public Shared Function EncodeXY(ByVal X As UShort, ByVal Y As UShort) As UShort
        Return Y * 20 + X
    End Function

    ' - Recupère la valeur X du tiles
    Public Shared Function DecodeX(ByVal code As UShort) As UShort
        Return Math.Floor(code - Math.Floor(code / 20) * 20)
    End Function

    ' - Recupère la valeur Y du tiles
    Public Shared Function DecodeY(ByVal code As UShort) As UShort
        Return Math.Floor(code / 20)
    End Function
End Class
