Imports System.Runtime.Serialization.Formatters
Imports System.IO

Public Class Configs
    Public Const SCREEN_TITLE = "Frog Creator 1.0"
    Public Const WIDGET_PATH = "Config/Widgets/"
    Public Const ICONS_PATH = "Config/Icons/"
    Public Const RESOURCES_PATH = "Config/Resources/"
    Public Const SPRITES_PATH = RESOURCES_PATH + "Sprites/"
    Public Const SPELLS_PATH = RESOURCES_PATH + "Spells/"
    Public Const TILESETS_PATH = RESOURCES_PATH + "Tiles/"
    Public Const MAPS_PATH = RESOURCES_PATH + "Maps/"

    Public Const CONFIG_FILE = "Configs.fg"
    Public Const GUI_CONFIG_FILE = "Black.conf"
    Public Const FONT_FILE = "GoBoom.ttf"
    Public Const ICON_FILE = "FC.png"

    Public Shared SCREEN_WIDTH As UShort = 640
    Public Shared SCREEN_HEIGHT As UShort = 448
    Public Shared FPS As Byte = 60
End Class
