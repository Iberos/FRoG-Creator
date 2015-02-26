Public Class GameTileset
    ' - Compacte les valeurs X et Y du tiles
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
