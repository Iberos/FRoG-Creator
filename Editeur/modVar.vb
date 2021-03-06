﻿Module modVar

    ' Constantes
    Public Const MAP_WIDTH As Byte = 20
    Public Const MAP_HEIGHT As Byte = 14
    Public Const CASE_LENGTH As Single = 32

    'TODO Initialiser les variables en chargement et non comme suit
    ' - Général
    Public game As New GameManager
    Public player As New GamePlayer
    Public editorOptions As New GameOptions
    Public npcConfigurator As frmConfigNPC

    ' - Maps
    Public map As New GameMap(-1)
    Public lstBackup As List(Of Byte())
    Public curBck As Integer
    Public curX As Byte = 0
    Public curY As Byte = 0
    Public curLayer As Byte = 0
    Public curMap As Integer
    Public curAttribute As New GameAttribute

    ' - BDD Binaire
    Public DB As New BinaryDataBase
    Public lstClasses As New List(Of GameClass)
    Public lstItems As New List(Of GameItem)
    Public lstSpells As New List(Of GameSpell)
    Public lstNPCs As New List(Of GameNPC)

    ' - Divers
    Public testMode As Byte
    Public FPS As Short
End Module
