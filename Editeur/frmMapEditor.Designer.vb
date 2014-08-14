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
        Me.lblCursor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFPS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.loadBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btPlay = New System.Windows.Forms.ToolStripButton()
        Me.NouveauToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OuvrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btLocalSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btFill = New System.Windows.Forms.ToolStripButton()
        Me.btClear = New System.Windows.Forms.ToolStripButton()
        Me.btCopy = New System.Windows.Forms.ToolStripButton()
        Me.btErase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNight = New System.Windows.Forms.ToolStripButton()
        Me.btGrid = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblMapName = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.lstTiles = New System.Windows.Forms.ComboBox()
        Me.pnlTiles = New System.Windows.Forms.Panel()
        Me.picTiles = New System.Windows.Forms.PictureBox()
        Me.pnlStart = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAttribute = New System.Windows.Forms.Panel()
        Me.btn_attrNPC = New System.Windows.Forms.Button()
        Me.pnlBlockDir = New System.Windows.Forms.Panel()
        Me.lstDir = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picGame = New System.Windows.Forms.PictureBox()
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCursor, Me.ToolStripStatusLabel2, Me.lblFPS, Me.ToolStripStatusLabel3, Me.loadBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCursor
        '
        Me.lblCursor.Name = "lblCursor"
        Me.lblCursor.Size = New System.Drawing.Size(48, 17)
        Me.lblCursor.Text = "X: 0 Y: 0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(25, 17)
        Me.ToolStripStatusLabel2.Text = "      "
        '
        'lblFPS
        '
        Me.lblFPS.Name = "lblFPS"
        Me.lblFPS.Size = New System.Drawing.Size(26, 17)
        Me.lblFPS.Text = "FPS"
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btPlay, Me.NouveauToolStripButton, Me.OuvrirToolStripButton, Me.btLocalSave, Me.ToolStripSeparator8, Me.btFill, Me.btClear, Me.btCopy, Me.btErase, Me.ToolStripSeparator9, Me.btNight, Me.btGrid, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator10, Me.ToolStripButton15, Me.ToolStripSeparator7, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator6, Me.ToolStripButton7, Me.ToolStripButton12, Me.ToolStripButton13, Me.ToolStripSeparator5, Me.lblMapName, Me.ToolStripSeparator12})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btPlay
        '
        Me.btPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btPlay.Image = Global.Editeur.My.Resources.Resources.Play
        Me.btPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btPlay.Name = "btPlay"
        Me.btPlay.Size = New System.Drawing.Size(23, 22)
        Me.btPlay.Text = "Tester la map"
        '
        'NouveauToolStripButton
        '
        Me.NouveauToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NouveauToolStripButton.Image = CType(resources.GetObject("NouveauToolStripButton.Image"), System.Drawing.Image)
        Me.NouveauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NouveauToolStripButton.Name = "NouveauToolStripButton"
        Me.NouveauToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NouveauToolStripButton.Text = "&Nouveau"
        '
        'OuvrirToolStripButton
        '
        Me.OuvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OuvrirToolStripButton.Image = CType(resources.GetObject("OuvrirToolStripButton.Image"), System.Drawing.Image)
        Me.OuvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OuvrirToolStripButton.Name = "OuvrirToolStripButton"
        Me.OuvrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OuvrirToolStripButton.Text = "&Ouvrir"
        '
        'btLocalSave
        '
        Me.btLocalSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btLocalSave.Image = CType(resources.GetObject("btLocalSave.Image"), System.Drawing.Image)
        Me.btLocalSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btLocalSave.Name = "btLocalSave"
        Me.btLocalSave.Size = New System.Drawing.Size(23, 22)
        Me.btLocalSave.Text = "Sauvegarder localement la map"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btFill
        '
        Me.btFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btFill.Image = CType(resources.GetObject("btFill.Image"), System.Drawing.Image)
        Me.btFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFill.Name = "btFill"
        Me.btFill.Size = New System.Drawing.Size(23, 22)
        Me.btFill.Text = "Outil : Remplir"
        '
        'btClear
        '
        Me.btClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btClear.Image = CType(resources.GetObject("btClear.Image"), System.Drawing.Image)
        Me.btClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(23, 22)
        Me.btClear.Text = "Outil : Vider"
        '
        'btCopy
        '
        Me.btCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btCopy.Image = CType(resources.GetObject("btCopy.Image"), System.Drawing.Image)
        Me.btCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btCopy.Name = "btCopy"
        Me.btCopy.Size = New System.Drawing.Size(23, 22)
        Me.btCopy.Text = "Outil : Pipette"
        '
        'btErase
        '
        Me.btErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btErase.Image = CType(resources.GetObject("btErase.Image"), System.Drawing.Image)
        Me.btErase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btErase.Name = "btErase"
        Me.btErase.Size = New System.Drawing.Size(23, 22)
        Me.btErase.Text = "Outil : Gomme"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'btNight
        '
        Me.btNight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btNight.Image = CType(resources.GetObject("btNight.Image"), System.Drawing.Image)
        Me.btNight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNight.Name = "btNight"
        Me.btNight.Size = New System.Drawing.Size(23, 22)
        Me.btNight.Text = "Jour/Nuit"
        Me.btNight.ToolTipText = "Jour/Nuit"
        '
        'btGrid
        '
        Me.btGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btGrid.Image = CType(resources.GetObject("btGrid.Image"), System.Drawing.Image)
        Me.btGrid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btGrid.Name = "btGrid"
        Me.btGrid.Size = New System.Drawing.Size(23, 22)
        Me.btGrid.Text = "Grille"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Annuler"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Rétablir"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.Checked = True
        Me.ToolStripButton15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "ToolStripButton6"
        Me.ToolStripButton15.ToolTipText = "Couche Sol"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Couche Inférieure 1"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Couche Inférieure 2"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Couche Inférieure 3"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Couche Supérieure 1"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Couche Supérieure 2"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Couche Supérieure 3"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'lblMapName
        '
        Me.lblMapName.Name = "lblMapName"
        Me.lblMapName.Size = New System.Drawing.Size(89, 22)
        Me.lblMapName.Text = "Nom de la map"
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
        Me.pnlTiles.AutoScroll = True
        Me.pnlTiles.BackColor = System.Drawing.Color.White
        Me.pnlTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTiles.Controls.Add(Me.picTiles)
        Me.pnlTiles.Location = New System.Drawing.Point(12, 99)
        Me.pnlTiles.Name = "pnlTiles"
        Me.pnlTiles.Size = New System.Drawing.Size(250, 453)
        Me.pnlTiles.TabIndex = 6
        '
        'picTiles
        '
        Me.picTiles.BackColor = System.Drawing.Color.White
        Me.picTiles.Location = New System.Drawing.Point(0, 0)
        Me.picTiles.Name = "picTiles"
        Me.picTiles.Size = New System.Drawing.Size(248, 451)
        Me.picTiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTiles.TabIndex = 5
        Me.picTiles.TabStop = False
        '
        'pnlStart
        '
        Me.pnlStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStart.Controls.Add(Me.LinkLabel1)
        Me.pnlStart.Controls.Add(Me.Label6)
        Me.pnlStart.Controls.Add(Me.Label5)
        Me.pnlStart.Controls.Add(Me.Label4)
        Me.pnlStart.Controls.Add(Me.Label3)
        Me.pnlStart.Controls.Add(Me.Label2)
        Me.pnlStart.Controls.Add(Me.Label1)
        Me.pnlStart.Location = New System.Drawing.Point(268, 72)
        Me.pnlStart.Name = "pnlStart"
        Me.pnlStart.Size = New System.Drawing.Size(672, 480)
        Me.pnlStart.TabIndex = 7
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.ForestGreen
        Me.LinkLabel1.Location = New System.Drawing.Point(33, 449)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Visiter le portail FRoG Creator"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.ForestGreen
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(572, 39)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Besoin d'aide supplémentaire ?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(609, 39)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pour commencer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(591, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "C'est un outil simple, puissant, rapide et efficace qui va vous permettre de crée" & _
    "r et d'éditer le contenu de votre jeu facilement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "et de façon ludique."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenue sur l'éditeur de FRoG Creator !"
        '
        'pnlAttribute
        '
        Me.pnlAttribute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAttribute.Controls.Add(Me.btn_attrNPC)
        Me.pnlAttribute.Controls.Add(Me.pnlBlockDir)
        Me.pnlAttribute.Controls.Add(Me.Button3)
        Me.pnlAttribute.Controls.Add(Me.Button2)
        Me.pnlAttribute.Controls.Add(Me.Button1)
        Me.pnlAttribute.Location = New System.Drawing.Point(4, 99)
        Me.pnlAttribute.Name = "pnlAttribute"
        Me.pnlAttribute.Size = New System.Drawing.Size(249, 452)
        Me.pnlAttribute.TabIndex = 9
        Me.pnlAttribute.Visible = False
        '
        'btn_attrNPC
        '
        Me.btn_attrNPC.BackColor = System.Drawing.Color.LightGreen
        Me.btn_attrNPC.Location = New System.Drawing.Point(3, 128)
        Me.btn_attrNPC.Name = "btn_attrNPC"
        Me.btn_attrNPC.Size = New System.Drawing.Size(241, 26)
        Me.btn_attrNPC.TabIndex = 11
        Me.btn_attrNPC.Text = "Ajouter un PNJ"
        Me.btn_attrNPC.UseVisualStyleBackColor = False
        '
        'pnlBlockDir
        '
        Me.pnlBlockDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBlockDir.Controls.Add(Me.lstDir)
        Me.pnlBlockDir.Controls.Add(Me.Label7)
        Me.pnlBlockDir.Controls.Add(Me.Button5)
        Me.pnlBlockDir.Controls.Add(Me.Button4)
        Me.pnlBlockDir.Location = New System.Drawing.Point(23, 203)
        Me.pnlBlockDir.Name = "pnlBlockDir"
        Me.pnlBlockDir.Size = New System.Drawing.Size(200, 100)
        Me.pnlBlockDir.TabIndex = 10
        Me.pnlBlockDir.Visible = False
        '
        'lstDir
        '
        Me.lstDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstDir.FormattingEnabled = True
        Me.lstDir.Items.AddRange(New Object() {"Bas", "Gauche", "Droite", "Haut"})
        Me.lstDir.Location = New System.Drawing.Point(3, 37)
        Me.lstDir.Name = "lstDir"
        Me.lstDir.Size = New System.Drawing.Size(192, 21)
        Me.lstDir.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Bloquer la direction :"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(3, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Annuler"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(100, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Valider"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(3, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(241, 26)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Téléporter"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(3, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Bloquer la direction"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(3, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Bloquer la case"
        Me.Button1.UseVisualStyleBackColor = False
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
        'frmMapEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 597)
        Me.Controls.Add(Me.pnlAttribute)
        Me.Controls.Add(Me.pnlStart)
        Me.Controls.Add(Me.pnlTiles)
        Me.Controls.Add(Me.lstTiles)
        Me.Controls.Add(Me.picGame)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
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
        Me.pnlTiles.PerformLayout()
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
    Friend WithEvents btPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFill As System.Windows.Forms.ToolStripButton
    Friend WithEvents btClear As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents lblFPS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCursor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btLocalSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btErase As System.Windows.Forms.ToolStripButton
    Friend WithEvents btGrid As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents loadBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btNight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuDataEditor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlStart As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMapName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuTestMap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OuvrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlAttribute As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnlBlockDir As System.Windows.Forms.Panel
    Friend WithEvents lstDir As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btn_attrNPC As System.Windows.Forms.Button

End Class
