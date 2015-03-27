Imports SFML.Graphics
Public Structure Extension
    Const JPEG = "jpg"
    Const PNG = "png"
    Const FROG = "frog"
    Const FONT = "ttf"
    Const CONF = "conf"
End Structure

Public Structure ContentPath
    Const CONFIG = "Config/"
    Const WIDGETS = ContentPath.CONFIG + "Widgets/"
    Const RESOURCES = ContentPath.CONFIG + "Resources/"
End Structure

Public Structure ContentType
    Const ICONS = ContentPath.CONFIG + "Icons/"
    Const SPRITES = ContentPath.RESOURCES + "Sprites/"
    Const SPELLS = ContentPath.RESOURCES + "Spells/"
    Const TILESETS = ContentPath.RESOURCES + "Tiles/"
    Const MAPS = ContentPath.RESOURCES + "Maps/"
End Structure

Public Class ContentManager

    Private Shared resources As New Dictionary(Of String, Object)

    Public Shared Function GetContent(key As String)
        If (resources.Keys.Contains(key)) Then
            Return resources(key)
        End If
        Return Nothing
    End Function

    Public Shared Sub AddContent(key As String, obj As Drawable)
        If (Not resources.Keys.Contains(key)) Then
            resources.Add(key, obj)
        End If
    End Sub

    Public Shared Sub AddContent(key As String, obj As ContentContext)
        If (Not resources.Keys.Contains(key)) Then
            resources.Add(key, obj.ToString())
        End If
    End Sub

    Public Shared Sub AddContent(key As String, obj As String)
        If (Not resources.Keys.Contains(key)) Then
            resources.Add(key, obj)
        End If
    End Sub

    'Public Shared Function LoadContent(type As ContentType, file As String)
    '    Select Case (type.ToString())
    '        Case ContentType.ICONS

    '        Case ContentType.MAPS

    '        Case ContentType.SPELLS

    '        Case ContentType.SPRITES

    '        Case ContentType.TILESETS

    '    End Select
    'End Function
End Class
