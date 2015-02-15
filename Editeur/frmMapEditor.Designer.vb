<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapEditor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMapEditor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDataEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMap = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNewMap = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuOpenMap = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuTestMap = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSaveMapLocal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSaveMapServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuScreenshot = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuProperty = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGrill = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNight = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuInterrogation = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSendBug = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMakeDonation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelCursor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelFPS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.loadBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ButtonPlay = New System.Windows.Forms.ToolStripButton()
        Me.ButtleNewMap = New System.Windows.Forms.ToolStripButton()
        Me.ButtonOpenMap = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSaveMap = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonFill = New System.Windows.Forms.ToolStripButton()
        Me.ButtonClear = New System.Windows.Forms.ToolStripButton()
        Me.ButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ButtonErase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonNight = New System.Windows.Forms.ToolStripButton()
        Me.ButtonGrid = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonBefore = New System.Windows.Forms.ToolStripButton()
        Me.ButtonAfter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonGround = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonLower1 = New System.Windows.Forms.ToolStripButton()
        Me.ButtonLower2 = New System.Windows.Forms.ToolStripButton()
        Me.ButtonLower3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonTop1 = New System.Windows.Forms.ToolStripButton()
        Me.ButtonTop2 = New System.Windows.Forms.ToolStripButton()
        Me.ButtonTop3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LabelMapName = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.lstTiles = New System.Windows.Forms.ComboBox()
        Me.pnlTiles = New System.Windows.Forms.Panel()
        Me.picTiles = New System.Windows.Forms.PictureBox()
        Me.pnlStart = New System.Windows.Forms.Panel()
        Me.LinkLabelWebSite = New System.Windows.Forms.LinkLabel()
        Me.LabelPresentation6 = New System.Windows.Forms.Label()
        Me.LabelPresentation5 = New System.Windows.Forms.Label()
        Me.LabelPresentation4 = New System.Windows.Forms.Label()
        Me.LabelPresentation3 = New System.Windows.Forms.Label()
        Me.LabelPresentation2 = New System.Windows.Forms.Label()
        Me.LabelPresentation1 = New System.Windows.Forms.Label()
        Me.pnlAttribute = New System.Windows.Forms.Panel()
        Me.ButtonNPC = New System.Windows.Forms.Button()
        Me.pnlBlockDir = New System.Windows.Forms.Panel()
        Me.ListDirection = New System.Windows.Forms.ComboBox()
        Me.LabelBlockDirection = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonTeleport = New System.Windows.Forms.Button()
        Me.ButtonBlockDirection = New System.Windows.Forms.Button()
        Me.ButtonBlock = New System.Windows.Forms.Button()
        Me.picGame = New System.Windows.Forms.PictureBox()
        Me.vPicScroll = New System.Windows.Forms.VScrollBar()
        Me.hPicScroll = New System.Windows.Forms.HScrollBar()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlTiles.SuspendLayout()
        CType(Me.picTiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStart.SuspendLayout()
        Me.pnlAttribute.SuspendLayout()
        Me.pnlBlockDir.SuspendLayout()
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.MenuMap, Me.MenuScreen, Me.MenuInterrogation})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuDataEditor, Me.ToolStripSeparator11, Me.MenuExit})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.FichierToolStripMenuItem.Text = "Editeur"
        '
        'MenuDataEditor
        '
        Me.MenuDataEditor.Name = "MenuDataEditor"
        Me.MenuDataEditor.Size = New System.Drawing.Size(185, 22)
        Me.MenuDataEditor.Text = "Editeur de ressources"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(182, 6)
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(185, 22)
        Me.MenuExit.Text = "Quitter"
        '
        'MenuMap
        '
        Me.MenuMap.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNewMap, Me.MenuOpenMap, Me.ToolStripSeparator3, Me.MenuTestMap, Me.MenuSaveMapLocal, Me.MenuSaveMapServer, Me.ToolStripSeparator1, Me.MenuScreenshot, Me.MenuProperty})
        Me.MenuMap.Name = "MenuMap"
        Me.MenuMap.Size = New System.Drawing.Size(43, 20)
        Me.MenuMap.Text = "Map"
        '
        'MenuNewMap
        '
        Me.MenuNewMap.Name = "MenuNewMap"
        Me.MenuNewMap.Size = New System.Drawing.Size(211, 22)
        Me.MenuNewMap.Text = "Nouvelle"
        '
        'MenuOpenMap
        '
        Me.MenuOpenMap.Name = "MenuOpenMap"
        Me.MenuOpenMap.Size = New System.Drawing.Size(211, 22)
        Me.MenuOpenMap.Text = "Ouvrir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(208, 6)
        '
        'MenuTestMap
        '
        Me.MenuTestMap.Name = "MenuTestMap"
        Me.MenuTestMap.Size = New System.Drawing.Size(211, 22)
        Me.MenuTestMap.Text = "Tester"
        '
        'MenuSaveMapLocal
        '
        Me.MenuSaveMapLocal.Name = "MenuSaveMapLocal"
        Me.MenuSaveMapLocal.Size = New System.Drawing.Size(211, 22)
        Me.MenuSaveMapLocal.Text = "Sauvegarder sur le disque"
        '
        'MenuSaveMapServer
        '
        Me.MenuSaveMapServer.Name = "MenuSaveMapServer"
        Me.MenuSaveMapServer.Size = New System.Drawing.Size(211, 22)
        Me.MenuSaveMapServer.Text = "Sauvegarder sur le serveur"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'MenuScreenshot
        '
        Me.MenuScreenshot.Name = "MenuScreenshot"
        Me.MenuScreenshot.Size = New System.Drawing.Size(211, 22)
        Me.MenuScreenshot.Text = "Faire une capture d'écran"
        '
        'MenuProperty
        '
        Me.MenuProperty.Name = "MenuProperty"
        Me.MenuProperty.Size = New System.Drawing.Size(211, 22)
        Me.MenuProperty.Text = "Proprietés"
        '
        'MenuScreen
        '
        Me.MenuScreen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGrill, Me.MenuPreview, Me.MenuNight})
        Me.MenuScreen.Name = "MenuScreen"
        Me.MenuScreen.Size = New System.Drawing.Size(70, 20)
        Me.MenuScreen.Text = "Affichage"
        '
        'MenuGrill
        '
        Me.MenuGrill.Name = "MenuGrill"
        Me.MenuGrill.Size = New System.Drawing.Size(156, 22)
        Me.MenuGrill.Text = "Grille"
        '
        'MenuPreview
        '
        Me.MenuPreview.Name = "MenuPreview"
        Me.MenuPreview.Size = New System.Drawing.Size(156, 22)
        Me.MenuPreview.Text = "Prévisualisation"
        '
        'MenuNight
        '
        Me.MenuNight.Name = "MenuNight"
        Me.MenuNight.Size = New System.Drawing.Size(156, 22)
        Me.MenuNight.Text = "Nuit"
        '
        'MenuInterrogation
        '
        Me.MenuInterrogation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSendBug, Me.MenuMakeDonation, Me.ToolStripSeparator2, Me.MenuAbout})
        Me.MenuInterrogation.Name = "MenuInterrogation"
        Me.MenuInterrogation.Size = New System.Drawing.Size(24, 20)
        Me.MenuInterrogation.Text = "?"
        '
        'MenuSendBug
        '
        Me.MenuSendBug.Name = "MenuSendBug"
        Me.MenuSendBug.Size = New System.Drawing.Size(157, 22)
        Me.MenuSendBug.Text = "Signaler un bug"
        '
        'MenuMakeDonation
        '
        Me.MenuMakeDonation.Name = "MenuMakeDonation"
        Me.MenuMakeDonation.Size = New System.Drawing.Size(157, 22)
        Me.MenuMakeDonation.Text = "Faire un don"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(154, 6)
        '
        'MenuAbout
        '
        Me.MenuAbout.Name = "MenuAbout"
        Me.MenuAbout.Size = New System.Drawing.Size(157, 22)
        Me.MenuAbout.Text = "A propos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelCursor, Me.ToolStripStatusLabel2, Me.LabelFPS, Me.ToolStripStatusLabel3, Me.loadBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelCursor
        '
        Me.LabelCursor.Name = "LabelCursor"
        Me.LabelCursor.Size = New System.Drawing.Size(48, 17)
        Me.LabelCursor.Text = "X: 0 Y: 0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(25, 17)
        Me.ToolStripStatusLabel2.Text = "      "
        '
        'LabelFPS
        '
        Me.LabelFPS.Name = "LabelFPS"
        Me.LabelFPS.Size = New System.Drawing.Size(26, 17)
        Me.LabelFPS.Text = "FPS"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(25, 17)
        Me.ToolStripStatusLabel3.Text = "      "
        '
        'loadBar
        '
        Me.loadBar.Name = "loadBar"
        Me.loadBar.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonPlay, Me.ButtleNewMap, Me.ButtonOpenMap, Me.ButtonSaveMap, Me.ToolStripSeparator8, Me.ButtonFill, Me.ButtonClear, Me.ButtonCopy, Me.ButtonErase, Me.ToolStripSeparator9, Me.ButtonNight, Me.ButtonGrid, Me.ToolStripSeparator4, Me.ButtonBefore, Me.ButtonAfter, Me.ToolStripSeparator10, Me.ButtonGround, Me.ToolStripSeparator7, Me.ButtonLower1, Me.ButtonLower2, Me.ButtonLower3, Me.ToolStripSeparator6, Me.ButtonTop1, Me.ButtonTop2, Me.ButtonTop3, Me.ToolStripSeparator5, Me.LabelMapName, Me.ToolStripSeparator12})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ButtonPlay
        '
        Me.ButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonPlay.Image = Global.Editeur.My.Resources.Resources.Play
        Me.ButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(23, 22)
        Me.ButtonPlay.Text = "Tester la map"
        '
        'ButtleNewMap
        '
        Me.ButtleNewMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtleNewMap.Image = CType(resources.GetObject("ButtleNewMap.Image"), System.Drawing.Image)
        Me.ButtleNewMap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtleNewMap.Name = "ButtleNewMap"
        Me.ButtleNewMap.Size = New System.Drawing.Size(23, 22)
        Me.ButtleNewMap.Text = "&Nouveau"
        '
        'ButtonOpenMap
        '
        Me.ButtonOpenMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonOpenMap.Image = CType(resources.GetObject("ButtonOpenMap.Image"), System.Drawing.Image)
        Me.ButtonOpenMap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonOpenMap.Name = "ButtonOpenMap"
        Me.ButtonOpenMap.Size = New System.Drawing.Size(23, 22)
        Me.ButtonOpenMap.Text = "&Ouvrir"
        '
        'ButtonSaveMap
        '
        Me.ButtonSaveMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSaveMap.Image = CType(resources.GetObject("ButtonSaveMap.Image"), System.Drawing.Image)
        Me.ButtonSaveMap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSaveMap.Name = "ButtonSaveMap"
        Me.ButtonSaveMap.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSaveMap.Text = "Sauvegarder localement la map"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonFill
        '
        Me.ButtonFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonFill.Image = CType(resources.GetObject("ButtonFill.Image"), System.Drawing.Image)
        Me.ButtonFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonFill.Name = "ButtonFill"
        Me.ButtonFill.Size = New System.Drawing.Size(23, 22)
        Me.ButtonFill.Text = "Outil : Remplir"
        '
        'ButtonClear
        '
        Me.ButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonClear.Image = CType(resources.GetObject("ButtonClear.Image"), System.Drawing.Image)
        Me.ButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(23, 22)
        Me.ButtonClear.Text = "Outil : Vider"
        '
        'ButtonCopy
        '
        Me.ButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(23, 22)
        Me.ButtonCopy.Text = "Outil : Pipette"
        '
        'ButtonErase
        '
        Me.ButtonErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonErase.Image = CType(resources.GetObject("ButtonErase.Image"), System.Drawing.Image)
        Me.ButtonErase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonErase.Name = "ButtonErase"
        Me.ButtonErase.Size = New System.Drawing.Size(23, 22)
        Me.ButtonErase.Text = "Outil : Gomme"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonNight
        '
        Me.ButtonNight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonNight.Image = CType(resources.GetObject("ButtonNight.Image"), System.Drawing.Image)
        Me.ButtonNight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonNight.Name = "ButtonNight"
        Me.ButtonNight.Size = New System.Drawing.Size(23, 22)
        Me.ButtonNight.Text = "Jour/Nuit"
        Me.ButtonNight.ToolTipText = "Jour/Nuit"
        '
        'ButtonGrid
        '
        Me.ButtonGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonGrid.Image = CType(resources.GetObject("ButtonGrid.Image"), System.Drawing.Image)
        Me.ButtonGrid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonGrid.Name = "ButtonGrid"
        Me.ButtonGrid.Size = New System.Drawing.Size(23, 22)
        Me.ButtonGrid.Text = "Grille"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonBefore
        '
        Me.ButtonBefore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonBefore.Image = CType(resources.GetObject("ButtonBefore.Image"), System.Drawing.Image)
        Me.ButtonBefore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonBefore.Name = "ButtonBefore"
        Me.ButtonBefore.Size = New System.Drawing.Size(23, 22)
        Me.ButtonBefore.Text = "Annuler"
        '
        'ButtonAfter
        '
        Me.ButtonAfter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonAfter.Image = CType(resources.GetObject("ButtonAfter.Image"), System.Drawing.Image)
        Me.ButtonAfter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonAfter.Name = "ButtonAfter"
        Me.ButtonAfter.Size = New System.Drawing.Size(23, 22)
        Me.ButtonAfter.Text = "Rétablir"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonGround
        '
        Me.ButtonGround.Checked = True
        Me.ButtonGround.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ButtonGround.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonGround.Image = CType(resources.GetObject("ButtonGround.Image"), System.Drawing.Image)
        Me.ButtonGround.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonGround.Name = "ButtonGround"
        Me.ButtonGround.Size = New System.Drawing.Size(23, 22)
        Me.ButtonGround.Text = "ToolStripButton6"
        Me.ButtonGround.ToolTipText = "Couche Sol"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonLower1
        '
        Me.ButtonLower1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonLower1.Image = CType(resources.GetObject("ButtonLower1.Image"), System.Drawing.Image)
        Me.ButtonLower1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonLower1.Name = "ButtonLower1"
        Me.ButtonLower1.Size = New System.Drawing.Size(23, 22)
        Me.ButtonLower1.Text = "Couche Inférieure 1"
        '
        'ButtonLower2
        '
        Me.ButtonLower2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonLower2.Image = CType(resources.GetObject("ButtonLower2.Image"), System.Drawing.Image)
        Me.ButtonLower2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonLower2.Name = "ButtonLower2"
        Me.ButtonLower2.Size = New System.Drawing.Size(23, 22)
        Me.ButtonLower2.Text = "Couche Inférieure 2"
        '
        'ButtonLower3
        '
        Me.ButtonLower3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonLower3.Image = CType(resources.GetObject("ButtonLower3.Image"), System.Drawing.Image)
        Me.ButtonLower3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonLower3.Name = "ButtonLower3"
        Me.ButtonLower3.Size = New System.Drawing.Size(23, 22)
        Me.ButtonLower3.Text = "Couche Inférieure 3"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonTop1
        '
        Me.ButtonTop1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonTop1.Image = CType(resources.GetObject("ButtonTop1.Image"), System.Drawing.Image)
        Me.ButtonTop1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonTop1.Name = "ButtonTop1"
        Me.ButtonTop1.Size = New System.Drawing.Size(23, 22)
        Me.ButtonTop1.Text = "Couche Supérieure 1"
        '
        'ButtonTop2
        '
        Me.ButtonTop2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonTop2.Image = CType(resources.GetObject("ButtonTop2.Image"), System.Drawing.Image)
        Me.ButtonTop2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonTop2.Name = "ButtonTop2"
        Me.ButtonTop2.Size = New System.Drawing.Size(23, 22)
        Me.ButtonTop2.Text = "Couche Supérieure 2"
        '
        'ButtonTop3
        '
        Me.ButtonTop3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonTop3.Image = CType(resources.GetObject("ButtonTop3.Image"), System.Drawing.Image)
        Me.ButtonTop3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonTop3.Name = "ButtonTop3"
        Me.ButtonTop3.Size = New System.Drawing.Size(23, 22)
        Me.ButtonTop3.Text = "Couche Supérieure 3"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'LabelMapName
        '
        Me.LabelMapName.Name = "LabelMapName"
        Me.LabelMapName.Size = New System.Drawing.Size(89, 22)
        Me.LabelMapName.Text = "Nom de la map"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'lstTiles
        '
        Me.lstTiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstTiles.FormattingEnabled = True
        Me.lstTiles.Location = New System.Drawing.Point(12, 72)
        Me.lstTiles.Name = "lstTiles"
        Me.lstTiles.Size = New System.Drawing.Size(250, 21)
        Me.lstTiles.TabIndex = 5
        '
        'pnlTiles
        '
        Me.pnlTiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlTiles.AutoScroll = True
        Me.pnlTiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlTiles.BackColor = System.Drawing.Color.White
        Me.pnlTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTiles.Controls.Add(Me.picTiles)
        Me.pnlTiles.Location = New System.Drawing.Point(12, 99)
        Me.pnlTiles.Name = "pnlTiles"
        Me.pnlTiles.Size = New System.Drawing.Size(224, 436)
        Me.pnlTiles.TabIndex = 6
        '
        'picTiles
        '
        Me.picTiles.BackColor = System.Drawing.Color.White
        Me.picTiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picTiles.Cursor = System.Windows.Forms.Cursors.Default
        Me.picTiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picTiles.Location = New System.Drawing.Point(0, 0)
        Me.picTiles.Name = "picTiles"
        Me.picTiles.Size = New System.Drawing.Size(222, 434)
        Me.picTiles.TabIndex = 5
        Me.picTiles.TabStop = False
        '
        'pnlStart
        '
        Me.pnlStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStart.Controls.Add(Me.LinkLabelWebSite)
        Me.pnlStart.Controls.Add(Me.LabelPresentation6)
        Me.pnlStart.Controls.Add(Me.LabelPresentation5)
        Me.pnlStart.Controls.Add(Me.LabelPresentation4)
        Me.pnlStart.Controls.Add(Me.LabelPresentation3)
        Me.pnlStart.Controls.Add(Me.LabelPresentation2)
        Me.pnlStart.Controls.Add(Me.LabelPresentation1)
        Me.pnlStart.Location = New System.Drawing.Point(268, 72)
        Me.pnlStart.Name = "pnlStart"
        Me.pnlStart.Size = New System.Drawing.Size(672, 480)
        Me.pnlStart.TabIndex = 7
        '
        'LinkLabelWebSite
        '
        Me.LinkLabelWebSite.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabelWebSite.AutoSize = True
        Me.LinkLabelWebSite.LinkColor = System.Drawing.Color.ForestGreen
        Me.LinkLabelWebSite.Location = New System.Drawing.Point(33, 449)
        Me.LinkLabelWebSite.Name = "LinkLabelWebSite"
        Me.LinkLabelWebSite.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabelWebSite.TabIndex = 6
        Me.LinkLabelWebSite.TabStop = True
        Me.LinkLabelWebSite.Text = "Visiter le portail FRoG Creator"
        Me.LinkLabelWebSite.VisitedLinkColor = System.Drawing.Color.ForestGreen
        '
        'LabelPresentation6
        '
        Me.LabelPresentation6.AutoSize = True
        Me.LabelPresentation6.Location = New System.Drawing.Point(33, 364)
        Me.LabelPresentation6.Name = "LabelPresentation6"
        Me.LabelPresentation6.Size = New System.Drawing.Size(572, 39)
        Me.LabelPresentation6.TabIndex = 5
        Me.LabelPresentation6.Text = resources.GetString("LabelPresentation6.Text")
        '
        'LabelPresentation5
        '
        Me.LabelPresentation5.AutoSize = True
        Me.LabelPresentation5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPresentation5.Location = New System.Drawing.Point(31, 321)
        Me.LabelPresentation5.Name = "LabelPresentation5"
        Me.LabelPresentation5.Size = New System.Drawing.Size(312, 25)
        Me.LabelPresentation5.TabIndex = 4
        Me.LabelPresentation5.Text = "Besoin d'aide supplémentaire ?"
        '
        'LabelPresentation4
        '
        Me.LabelPresentation4.AutoSize = True
        Me.LabelPresentation4.Location = New System.Drawing.Point(33, 258)
        Me.LabelPresentation4.Name = "LabelPresentation4"
        Me.LabelPresentation4.Size = New System.Drawing.Size(609, 39)
        Me.LabelPresentation4.TabIndex = 3
        Me.LabelPresentation4.Text = resources.GetString("LabelPresentation4.Text")
        '
        'LabelPresentation3
        '
        Me.LabelPresentation3.AutoSize = True
        Me.LabelPresentation3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPresentation3.Location = New System.Drawing.Point(31, 215)
        Me.LabelPresentation3.Name = "LabelPresentation3"
        Me.LabelPresentation3.Size = New System.Drawing.Size(174, 25)
        Me.LabelPresentation3.TabIndex = 2
        Me.LabelPresentation3.Text = "Pour commencer"
        '
        'LabelPresentation2
        '
        Me.LabelPresentation2.AutoSize = True
        Me.LabelPresentation2.Location = New System.Drawing.Point(33, 163)
        Me.LabelPresentation2.Name = "LabelPresentation2"
        Me.LabelPresentation2.Size = New System.Drawing.Size(591, 26)
        Me.LabelPresentation2.TabIndex = 1
        Me.LabelPresentation2.Text = "C'est un outil simple, puissant, rapide et efficace qui va vous permettre de crée" & _
    "r et d'éditer le contenu de votre jeu facilement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "et de façon ludique."
        '
        'LabelPresentation1
        '
        Me.LabelPresentation1.AutoSize = True
        Me.LabelPresentation1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPresentation1.Location = New System.Drawing.Point(31, 121)
        Me.LabelPresentation1.Name = "LabelPresentation1"
        Me.LabelPresentation1.Size = New System.Drawing.Size(412, 25)
        Me.LabelPresentation1.TabIndex = 0
        Me.LabelPresentation1.Text = "Bienvenue sur l'éditeur de FRoG Creator !"
        '
        'pnlAttribute
        '
        Me.pnlAttribute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAttribute.Controls.Add(Me.ButtonNPC)
        Me.pnlAttribute.Controls.Add(Me.pnlBlockDir)
        Me.pnlAttribute.Controls.Add(Me.ButtonTeleport)
        Me.pnlAttribute.Controls.Add(Me.ButtonBlockDirection)
        Me.pnlAttribute.Controls.Add(Me.ButtonBlock)
        Me.pnlAttribute.Location = New System.Drawing.Point(-38, 70)
        Me.pnlAttribute.Name = "pnlAttribute"
        Me.pnlAttribute.Size = New System.Drawing.Size(249, 453)
        Me.pnlAttribute.TabIndex = 9
        Me.pnlAttribute.Visible = False
        '
        'ButtonNPC
        '
        Me.ButtonNPC.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonNPC.Location = New System.Drawing.Point(3, 128)
        Me.ButtonNPC.Name = "ButtonNPC"
        Me.ButtonNPC.Size = New System.Drawing.Size(241, 26)
        Me.ButtonNPC.TabIndex = 11
        Me.ButtonNPC.Text = "PNJs"
        Me.ButtonNPC.UseVisualStyleBackColor = False
        '
        'pnlBlockDir
        '
        Me.pnlBlockDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBlockDir.Controls.Add(Me.ListDirection)
        Me.pnlBlockDir.Controls.Add(Me.LabelBlockDirection)
        Me.pnlBlockDir.Controls.Add(Me.ButtonCancel)
        Me.pnlBlockDir.Controls.Add(Me.ButtonOk)
        Me.pnlBlockDir.Location = New System.Drawing.Point(23, 203)
        Me.pnlBlockDir.Name = "pnlBlockDir"
        Me.pnlBlockDir.Size = New System.Drawing.Size(200, 100)
        Me.pnlBlockDir.TabIndex = 10
        Me.pnlBlockDir.Visible = False
        '
        'ListDirection
        '
        Me.ListDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListDirection.FormattingEnabled = True
        Me.ListDirection.Items.AddRange(New Object() {"Bas", "Gauche", "Droite", "Haut"})
        Me.ListDirection.Location = New System.Drawing.Point(3, 37)
        Me.ListDirection.Name = "ListDirection"
        Me.ListDirection.Size = New System.Drawing.Size(192, 21)
        Me.ListDirection.TabIndex = 3
        '
        'LabelBlockDirection
        '
        Me.LabelBlockDirection.AutoSize = True
        Me.LabelBlockDirection.Location = New System.Drawing.Point(3, 8)
        Me.LabelBlockDirection.Name = "LabelBlockDirection"
        Me.LabelBlockDirection.Size = New System.Drawing.Size(103, 13)
        Me.LabelBlockDirection.TabIndex = 2
        Me.LabelBlockDirection.Text = "Bloquer la direction :"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(3, 72)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(95, 23)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Annuler"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(100, 72)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(95, 23)
        Me.ButtonOk.TabIndex = 0
        Me.ButtonOk.Text = "Valider"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonTeleport
        '
        Me.ButtonTeleport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonTeleport.Location = New System.Drawing.Point(3, 96)
        Me.ButtonTeleport.Name = "ButtonTeleport"
        Me.ButtonTeleport.Size = New System.Drawing.Size(241, 26)
        Me.ButtonTeleport.TabIndex = 2
        Me.ButtonTeleport.Text = "Téléporter"
        Me.ButtonTeleport.UseVisualStyleBackColor = False
        '
        'ButtonBlockDirection
        '
        Me.ButtonBlockDirection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonBlockDirection.Location = New System.Drawing.Point(3, 64)
        Me.ButtonBlockDirection.Name = "ButtonBlockDirection"
        Me.ButtonBlockDirection.Size = New System.Drawing.Size(241, 26)
        Me.ButtonBlockDirection.TabIndex = 1
        Me.ButtonBlockDirection.Text = "Bloquer la direction"
        Me.ButtonBlockDirection.UseVisualStyleBackColor = False
        '
        'ButtonBlock
        '
        Me.ButtonBlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonBlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBlock.Location = New System.Drawing.Point(3, 31)
        Me.ButtonBlock.Name = "ButtonBlock"
        Me.ButtonBlock.Size = New System.Drawing.Size(241, 27)
        Me.ButtonBlock.TabIndex = 0
        Me.ButtonBlock.Text = "Bloquer la case"
        Me.ButtonBlock.UseVisualStyleBackColor = False
        '
        'picGame
        '
        Me.picGame.BackColor = System.Drawing.Color.White
        Me.picGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGame.Location = New System.Drawing.Point(292, 72)
        Me.picGame.Name = "picGame"
        Me.picGame.Size = New System.Drawing.Size(672, 480)
        Me.picGame.TabIndex = 3
        Me.picGame.TabStop = False
        '
        'vPicScroll
        '
        Me.vPicScroll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.vPicScroll.LargeChange = 20
        Me.vPicScroll.Location = New System.Drawing.Point(239, 99)
        Me.vPicScroll.Name = "vPicScroll"
        Me.vPicScroll.Size = New System.Drawing.Size(18, 436)
        Me.vPicScroll.TabIndex = 6
        '
        'hPicScroll
        '
        Me.hPicScroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.hPicScroll.Location = New System.Drawing.Point(12, 538)
        Me.hPicScroll.Name = "hPicScroll"
        Me.hPicScroll.Size = New System.Drawing.Size(224, 17)
        Me.hPicScroll.TabIndex = 10
        '
        'frmMapEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 597)
        Me.Controls.Add(Me.hPicScroll)
        Me.Controls.Add(Me.pnlAttribute)
        Me.Controls.Add(Me.vPicScroll)
        Me.Controls.Add(Me.pnlStart)
        Me.Controls.Add(Me.pnlTiles)
        Me.Controls.Add(Me.lstTiles)
        Me.Controls.Add(Me.picGame)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1000, 636)
        Me.Name = "frmMapEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRoG Creator 1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlTiles.ResumeLayout(False)
        CType(Me.picTiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStart.ResumeLayout(False)
        Me.pnlStart.PerformLayout()
        Me.pnlAttribute.ResumeLayout(False)
        Me.pnlBlockDir.ResumeLayout(False)
        Me.pnlBlockDir.PerformLayout()
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuScreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuGrill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuInterrogation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSendBug As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuMakeDonation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ButtonPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonFill As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents picGame As System.Windows.Forms.PictureBox
    Friend WithEvents lstTiles As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTiles As System.Windows.Forms.Panel
    Friend WithEvents picTiles As System.Windows.Forms.PictureBox
    Friend WithEvents MenuMap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSaveMapLocal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSaveMapServer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuScreenshot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuProperty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuNewMap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuOpenMap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelFPS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelCursor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ButtonSaveMap As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonErase As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonGrid As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ButtonGround As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonLower1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonLower2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonLower3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonTop1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonTop2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonTop3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents loadBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ButtonNight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonBefore As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonAfter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuDataEditor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlStart As System.Windows.Forms.Panel
    Friend WithEvents LinkLabelWebSite As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelPresentation6 As System.Windows.Forms.Label
    Friend WithEvents LabelPresentation5 As System.Windows.Forms.Label
    Friend WithEvents LabelPresentation4 As System.Windows.Forms.Label
    Friend WithEvents LabelPresentation3 As System.Windows.Forms.Label
    Friend WithEvents LabelPresentation2 As System.Windows.Forms.Label
    Friend WithEvents LabelPresentation1 As System.Windows.Forms.Label
    Friend WithEvents LabelMapName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuTestMap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtleNewMap As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonOpenMap As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlAttribute As System.Windows.Forms.Panel
    Friend WithEvents ButtonTeleport As System.Windows.Forms.Button
    Friend WithEvents ButtonBlockDirection As System.Windows.Forms.Button
    Friend WithEvents ButtonBlock As System.Windows.Forms.Button
    Friend WithEvents pnlBlockDir As System.Windows.Forms.Panel
    Friend WithEvents ListDirection As System.Windows.Forms.ComboBox
    Friend WithEvents LabelBlockDirection As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents ButtonNPC As System.Windows.Forms.Button
    Friend WithEvents vPicScroll As System.Windows.Forms.VScrollBar
    Friend WithEvents hPicScroll As System.Windows.Forms.HScrollBar

End Class
