<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.CHBFullScreen = New System.Windows.Forms.CheckBox
        Me.CHBGrabMouse = New System.Windows.Forms.CheckBox
        Me.CHBCDSkip = New System.Windows.Forms.CheckBox
        Me.CHBDisplayMessages = New System.Windows.Forms.CheckBox
        Me.CHBShowBriefings = New System.Windows.Forms.CheckBox
        Me.CHBSDLSoundMixer = New System.Windows.Forms.CheckBox
        Me.CMBShowMovies = New System.Windows.Forms.ComboBox
        Me.CMBScreenResolution = New System.Windows.Forms.ComboBox
        Me.NUDMenuFade = New System.Windows.Forms.NumericUpDown
        Me.LBLMenuFade = New System.Windows.Forms.Label
        Me.LBLScreenResolution = New System.Windows.Forms.Label
        Me.TXBCustomBackground = New System.Windows.Forms.TextBox
        Me.LBLCustomBackground = New System.Windows.Forms.Label
        Me.BTNCustomBackground = New System.Windows.Forms.Button
        Me.NUDCustomBackgroundBrightness = New System.Windows.Forms.NumericUpDown
        Me.LBLCustomBackgroundBrightness = New System.Windows.Forms.Label
        Me.NUDCustomBackgroundTransparency = New System.Windows.Forms.NumericUpDown
        Me.CHBCustomBackgroundTransparency = New System.Windows.Forms.CheckBox
        Me.LBLCustomBackgroundTransparency = New System.Windows.Forms.Label
        Me.CHBCustomBackgroundGreyscale = New System.Windows.Forms.CheckBox
        Me.TABSetup = New System.Windows.Forms.TabControl
        Me.TABGameplay = New System.Windows.Forms.TabPage
        Me.CMBDefaultPlayer = New System.Windows.Forms.ComboBox
        Me.CHBSecretLevels = New System.Windows.Forms.CheckBox
        Me.CHBFreezeRobots = New System.Windows.Forms.CheckBox
        Me.LBLDefaultPlayer = New System.Windows.Forms.Label
        Me.CHBPrintDaignostic = New System.Windows.Forms.CheckBox
        Me.CHBGerman = New System.Windows.Forms.CheckBox
        Me.TABVideoSettings = New System.Windows.Forms.TabPage
        Me.GRBReticle = New System.Windows.Forms.GroupBox
        Me.NUDReticle = New System.Windows.Forms.NumericUpDown
        Me.LBLReticleLineLength = New System.Windows.Forms.Label
        Me.RDBReticleDrawn = New System.Windows.Forms.RadioButton
        Me.RDBReticleBitmap = New System.Windows.Forms.RadioButton
        Me.LBLShowMovies = New System.Windows.Forms.Label
        Me.LBLPreloadTextures = New System.Windows.Forms.Label
        Me.CMBPreloadTextures = New System.Windows.Forms.ComboBox
        Me.CHBUnloadTextures = New System.Windows.Forms.CheckBox
        Me.CHBShaders = New System.Windows.Forms.CheckBox
        Me.CHBMultriThreading = New System.Windows.Forms.CheckBox
        Me.CHBProgressBar = New System.Windows.Forms.CheckBox
        Me.LBLHiResModelSize = New System.Windows.Forms.Label
        Me.CMBHiResModelSize = New System.Windows.Forms.ComboBox
        Me.CHBHiResModels = New System.Windows.Forms.CheckBox
        Me.CHBHiResTextures = New System.Windows.Forms.CheckBox
        Me.CHBAntiAliasing = New System.Windows.Forms.CheckBox
        Me.TABSound = New System.Windows.Forms.TabPage
        Me.CHBCustomMusic = New System.Windows.Forms.CheckBox
        Me.GRBCustomMusic = New System.Windows.Forms.GroupBox
        Me.BTNCustomPlaylist = New System.Windows.Forms.Button
        Me.BTNCustomCredits = New System.Windows.Forms.Button
        Me.BTNCustomBriefing = New System.Windows.Forms.Button
        Me.BTNCustomIntro = New System.Windows.Forms.Button
        Me.TXBCustomPlaylist = New System.Windows.Forms.TextBox
        Me.TXBCustomCredits = New System.Windows.Forms.TextBox
        Me.TXBCustomBriefing = New System.Windows.Forms.TextBox
        Me.TXBCustomIntro = New System.Windows.Forms.TextBox
        Me.LBLCustomPlaylist = New System.Windows.Forms.Label
        Me.LBLCustomCredits = New System.Windows.Forms.Label
        Me.LBLCustromBriefing = New System.Windows.Forms.Label
        Me.LBLCustomIntro = New System.Windows.Forms.Label
        Me.GRBSoundFrequency = New System.Windows.Forms.GroupBox
        Me.RDB44KHZ = New System.Windows.Forms.RadioButton
        Me.RDB22KHZ = New System.Windows.Forms.RadioButton
        Me.TABCustomMenuBackground = New System.Windows.Forms.TabPage
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTNSave = New System.Windows.Forms.Button
        Me.BTNSaveRun = New System.Windows.Forms.Button
        Me.BTNCancel = New System.Windows.Forms.Button
        Me.CHBAutoDemo = New System.Windows.Forms.CheckBox
        Me.CMBAutoDemo = New System.Windows.Forms.ComboBox
        Me.CHBRunDemos = New System.Windows.Forms.CheckBox
        Me.RDBOriginalSound = New System.Windows.Forms.RadioButton
        CType(Me.NUDMenuFade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDCustomBackgroundBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDCustomBackgroundTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABSetup.SuspendLayout()
        Me.TABGameplay.SuspendLayout()
        Me.TABVideoSettings.SuspendLayout()
        Me.GRBReticle.SuspendLayout()
        CType(Me.NUDReticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABSound.SuspendLayout()
        Me.GRBCustomMusic.SuspendLayout()
        Me.GRBSoundFrequency.SuspendLayout()
        Me.TABCustomMenuBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'CHBFullScreen
        '
        Me.CHBFullScreen.AutoSize = True
        Me.CHBFullScreen.Location = New System.Drawing.Point(6, 170)
        Me.CHBFullScreen.Name = "CHBFullScreen"
        Me.CHBFullScreen.Size = New System.Drawing.Size(166, 17)
        Me.CHBFullScreen.TabIndex = 0
        Me.CHBFullScreen.Text = "Start D2X in full screen mode."
        Me.CHBFullScreen.UseVisualStyleBackColor = True
        '
        'CHBGrabMouse
        '
        Me.CHBGrabMouse.AutoSize = True
        Me.CHBGrabMouse.Checked = True
        Me.CHBGrabMouse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBGrabMouse.Location = New System.Drawing.Point(9, 69)
        Me.CHBGrabMouse.Name = "CHBGrabMouse"
        Me.CHBGrabMouse.Size = New System.Drawing.Size(199, 17)
        Me.CHBGrabMouse.TabIndex = 1
        Me.CHBGrabMouse.Text = "Keep the mouse pointer in the game."
        Me.CHBGrabMouse.UseVisualStyleBackColor = True
        '
        'CHBCDSkip
        '
        Me.CHBCDSkip.AutoSize = True
        Me.CHBCDSkip.Checked = True
        Me.CHBCDSkip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBCDSkip.Location = New System.Drawing.Point(9, 46)
        Me.CHBCDSkip.Name = "CHBCDSkip"
        Me.CHBCDSkip.Size = New System.Drawing.Size(101, 17)
        Me.CHBCDSkip.TabIndex = 2
        Me.CHBCDSkip.Text = "Skip CD check."
        Me.CHBCDSkip.UseVisualStyleBackColor = True
        '
        'CHBDisplayMessages
        '
        Me.CHBDisplayMessages.AutoSize = True
        Me.CHBDisplayMessages.Checked = True
        Me.CHBDisplayMessages.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBDisplayMessages.Location = New System.Drawing.Point(9, 115)
        Me.CHBDisplayMessages.Name = "CHBDisplayMessages"
        Me.CHBDisplayMessages.Size = New System.Drawing.Size(185, 17)
        Me.CHBDisplayMessages.TabIndex = 3
        Me.CHBDisplayMessages.Text = "Display messages from all players."
        Me.CHBDisplayMessages.UseVisualStyleBackColor = True
        '
        'CHBShowBriefings
        '
        Me.CHBShowBriefings.AutoSize = True
        Me.CHBShowBriefings.Checked = True
        Me.CHBShowBriefings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBShowBriefings.Location = New System.Drawing.Point(6, 294)
        Me.CHBShowBriefings.Name = "CHBShowBriefings"
        Me.CHBShowBriefings.Size = New System.Drawing.Size(96, 17)
        Me.CHBShowBriefings.TabIndex = 4
        Me.CHBShowBriefings.Text = "Show Briefings"
        Me.CHBShowBriefings.UseVisualStyleBackColor = True
        '
        'CHBSDLSoundMixer
        '
        Me.CHBSDLSoundMixer.AutoSize = True
        Me.CHBSDLSoundMixer.Checked = True
        Me.CHBSDLSoundMixer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBSDLSoundMixer.Location = New System.Drawing.Point(9, 23)
        Me.CHBSDLSoundMixer.Name = "CHBSDLSoundMixer"
        Me.CHBSDLSoundMixer.Size = New System.Drawing.Size(165, 17)
        Me.CHBSDLSoundMixer.TabIndex = 5
        Me.CHBSDLSoundMixer.Text = "Enable SDL sound rendering."
        Me.CHBSDLSoundMixer.UseVisualStyleBackColor = True
        '
        'CMBShowMovies
        '
        Me.CMBShowMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBShowMovies.FormattingEnabled = True
        Me.CMBShowMovies.Items.AddRange(New Object() {"Show all movies.", "Show only Robot movies.", "Show no movies."})
        Me.CMBShowMovies.Location = New System.Drawing.Point(6, 269)
        Me.CMBShowMovies.Name = "CMBShowMovies"
        Me.CMBShowMovies.Size = New System.Drawing.Size(161, 21)
        Me.CMBShowMovies.TabIndex = 20
        '
        'CMBScreenResolution
        '
        Me.CMBScreenResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBScreenResolution.FormattingEnabled = True
        Me.CMBScreenResolution.Items.AddRange(New Object() {"  320x240", "  432x240", "  480x320", "  640x480", "  800x480", "  800x600", "1024x768", "1152x864", "1280x1024", "1280x800", "1280x854", "1366x768", "1440x900", "1400x1050", "1600x1024", "1680x1050", "1600x1200"})
        Me.CMBScreenResolution.Location = New System.Drawing.Point(6, 229)
        Me.CMBScreenResolution.Name = "CMBScreenResolution"
        Me.CMBScreenResolution.Size = New System.Drawing.Size(121, 21)
        Me.CMBScreenResolution.TabIndex = 24
        Me.ToolTip.SetToolTip(Me.CMBScreenResolution, "Overwritten by setting in player file.")
        '
        'NUDMenuFade
        '
        Me.NUDMenuFade.Location = New System.Drawing.Point(6, 353)
        Me.NUDMenuFade.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NUDMenuFade.Name = "NUDMenuFade"
        Me.NUDMenuFade.Size = New System.Drawing.Size(46, 20)
        Me.NUDMenuFade.TabIndex = 25
        Me.ToolTip.SetToolTip(Me.NUDMenuFade, "100-150 Recommended")
        '
        'LBLMenuFade
        '
        Me.LBLMenuFade.AutoSize = True
        Me.LBLMenuFade.Location = New System.Drawing.Point(3, 337)
        Me.LBLMenuFade.Name = "LBLMenuFade"
        Me.LBLMenuFade.Size = New System.Drawing.Size(140, 13)
        Me.LBLMenuFade.TabIndex = 26
        Me.LBLMenuFade.Text = "Time in ms until menu fades."
        '
        'LBLScreenResolution
        '
        Me.LBLScreenResolution.AutoSize = True
        Me.LBLScreenResolution.Location = New System.Drawing.Point(6, 213)
        Me.LBLScreenResolution.Name = "LBLScreenResolution"
        Me.LBLScreenResolution.Size = New System.Drawing.Size(130, 13)
        Me.LBLScreenResolution.TabIndex = 28
        Me.LBLScreenResolution.Text = "Defualt screen resolution. "
        Me.ToolTip.SetToolTip(Me.LBLScreenResolution, "This value is overwritten by the player file.")
        '
        'TXBCustomBackground
        '
        Me.TXBCustomBackground.Location = New System.Drawing.Point(6, 19)
        Me.TXBCustomBackground.Name = "TXBCustomBackground"
        Me.TXBCustomBackground.Size = New System.Drawing.Size(219, 20)
        Me.TXBCustomBackground.TabIndex = 29
        Me.TXBCustomBackground.Text = "d2x-xl-wp-3-1500x1125.tga"
        '
        'LBLCustomBackground
        '
        Me.LBLCustomBackground.AutoSize = True
        Me.LBLCustomBackground.Location = New System.Drawing.Point(3, 3)
        Me.LBLCustomBackground.Name = "LBLCustomBackground"
        Me.LBLCustomBackground.Size = New System.Drawing.Size(103, 13)
        Me.LBLCustomBackground.TabIndex = 30
        Me.LBLCustomBackground.Text = "Custom Background"
        '
        'BTNCustomBackground
        '
        Me.BTNCustomBackground.Location = New System.Drawing.Point(231, 19)
        Me.BTNCustomBackground.Name = "BTNCustomBackground"
        Me.BTNCustomBackground.Size = New System.Drawing.Size(50, 23)
        Me.BTNCustomBackground.TabIndex = 31
        Me.BTNCustomBackground.Text = "Browse"
        Me.BTNCustomBackground.UseVisualStyleBackColor = True
        '
        'NUDCustomBackgroundBrightness
        '
        Me.NUDCustomBackgroundBrightness.DecimalPlaces = 2
        Me.NUDCustomBackgroundBrightness.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUDCustomBackgroundBrightness.Location = New System.Drawing.Point(6, 69)
        Me.NUDCustomBackgroundBrightness.Maximum = New Decimal(New Integer() {10, 0, 0, 65536})
        Me.NUDCustomBackgroundBrightness.Name = "NUDCustomBackgroundBrightness"
        Me.NUDCustomBackgroundBrightness.ReadOnly = True
        Me.NUDCustomBackgroundBrightness.Size = New System.Drawing.Size(44, 20)
        Me.NUDCustomBackgroundBrightness.TabIndex = 32
        Me.NUDCustomBackgroundBrightness.Value = New Decimal(New Integer() {75, 0, 0, 131072})
        '
        'LBLCustomBackgroundBrightness
        '
        Me.LBLCustomBackgroundBrightness.AutoSize = True
        Me.LBLCustomBackgroundBrightness.Location = New System.Drawing.Point(3, 53)
        Me.LBLCustomBackgroundBrightness.Name = "LBLCustomBackgroundBrightness"
        Me.LBLCustomBackgroundBrightness.Size = New System.Drawing.Size(56, 13)
        Me.LBLCustomBackgroundBrightness.TabIndex = 34
        Me.LBLCustomBackgroundBrightness.Text = "Brightness"
        '
        'NUDCustomBackgroundTransparency
        '
        Me.NUDCustomBackgroundTransparency.DecimalPlaces = 2
        Me.NUDCustomBackgroundTransparency.Enabled = False
        Me.NUDCustomBackgroundTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUDCustomBackgroundTransparency.Location = New System.Drawing.Point(125, 114)
        Me.NUDCustomBackgroundTransparency.Maximum = New Decimal(New Integer() {10, 0, 0, 65536})
        Me.NUDCustomBackgroundTransparency.Name = "NUDCustomBackgroundTransparency"
        Me.NUDCustomBackgroundTransparency.ReadOnly = True
        Me.NUDCustomBackgroundTransparency.Size = New System.Drawing.Size(44, 20)
        Me.NUDCustomBackgroundTransparency.TabIndex = 35
        Me.NUDCustomBackgroundTransparency.Value = New Decimal(New Integer() {75, 0, 0, 131072})
        '
        'CHBCustomBackgroundTransparency
        '
        Me.CHBCustomBackgroundTransparency.AutoSize = True
        Me.CHBCustomBackgroundTransparency.Checked = True
        Me.CHBCustomBackgroundTransparency.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBCustomBackgroundTransparency.Location = New System.Drawing.Point(6, 117)
        Me.CHBCustomBackgroundTransparency.Name = "CHBCustomBackgroundTransparency"
        Me.CHBCustomBackgroundTransparency.Size = New System.Drawing.Size(113, 17)
        Me.CHBCustomBackgroundTransparency.TabIndex = 36
        Me.CHBCustomBackgroundTransparency.Text = "Use Image Setting"
        Me.CHBCustomBackgroundTransparency.UseVisualStyleBackColor = True
        '
        'LBLCustomBackgroundTransparency
        '
        Me.LBLCustomBackgroundTransparency.AutoSize = True
        Me.LBLCustomBackgroundTransparency.Location = New System.Drawing.Point(3, 101)
        Me.LBLCustomBackgroundTransparency.Name = "LBLCustomBackgroundTransparency"
        Me.LBLCustomBackgroundTransparency.Size = New System.Drawing.Size(72, 13)
        Me.LBLCustomBackgroundTransparency.TabIndex = 37
        Me.LBLCustomBackgroundTransparency.Text = "Transparency"
        '
        'CHBCustomBackgroundGreyscale
        '
        Me.CHBCustomBackgroundGreyscale.AutoSize = True
        Me.CHBCustomBackgroundGreyscale.Location = New System.Drawing.Point(6, 140)
        Me.CHBCustomBackgroundGreyscale.Name = "CHBCustomBackgroundGreyscale"
        Me.CHBCustomBackgroundGreyscale.Size = New System.Drawing.Size(126, 17)
        Me.CHBCustomBackgroundGreyscale.TabIndex = 38
        Me.CHBCustomBackgroundGreyscale.Text = "Convert to greyscale."
        Me.CHBCustomBackgroundGreyscale.UseVisualStyleBackColor = True
        '
        'TABSetup
        '
        Me.TABSetup.Controls.Add(Me.TABGameplay)
        Me.TABSetup.Controls.Add(Me.TABVideoSettings)
        Me.TABSetup.Controls.Add(Me.TABSound)
        Me.TABSetup.Controls.Add(Me.TABCustomMenuBackground)
        Me.TABSetup.Location = New System.Drawing.Point(12, 2)
        Me.TABSetup.Name = "TABSetup"
        Me.TABSetup.SelectedIndex = 0
        Me.TABSetup.Size = New System.Drawing.Size(336, 473)
        Me.TABSetup.TabIndex = 39
        '
        'TABGameplay
        '
        Me.TABGameplay.Controls.Add(Me.CHBRunDemos)
        Me.TABGameplay.Controls.Add(Me.CMBAutoDemo)
        Me.TABGameplay.Controls.Add(Me.CHBAutoDemo)
        Me.TABGameplay.Controls.Add(Me.CMBDefaultPlayer)
        Me.TABGameplay.Controls.Add(Me.CHBSecretLevels)
        Me.TABGameplay.Controls.Add(Me.CHBFreezeRobots)
        Me.TABGameplay.Controls.Add(Me.LBLDefaultPlayer)
        Me.TABGameplay.Controls.Add(Me.CHBPrintDaignostic)
        Me.TABGameplay.Controls.Add(Me.CHBGerman)
        Me.TABGameplay.Controls.Add(Me.CHBGrabMouse)
        Me.TABGameplay.Controls.Add(Me.CHBCDSkip)
        Me.TABGameplay.Controls.Add(Me.CHBDisplayMessages)
        Me.TABGameplay.Location = New System.Drawing.Point(4, 22)
        Me.TABGameplay.Name = "TABGameplay"
        Me.TABGameplay.Padding = New System.Windows.Forms.Padding(3)
        Me.TABGameplay.Size = New System.Drawing.Size(328, 447)
        Me.TABGameplay.TabIndex = 0
        Me.TABGameplay.Text = "Gameplay"
        Me.TABGameplay.UseVisualStyleBackColor = True
        '
        'CMBDefaultPlayer
        '
        Me.CMBDefaultPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBDefaultPlayer.FormattingEnabled = True
        Me.CMBDefaultPlayer.Items.AddRange(New Object() {"Default"})
        Me.CMBDefaultPlayer.Location = New System.Drawing.Point(9, 19)
        Me.CMBDefaultPlayer.Name = "CMBDefaultPlayer"
        Me.CMBDefaultPlayer.Size = New System.Drawing.Size(147, 21)
        Me.CMBDefaultPlayer.Sorted = True
        Me.CMBDefaultPlayer.TabIndex = 28
        '
        'CHBSecretLevels
        '
        Me.CHBSecretLevels.AutoSize = True
        Me.CHBSecretLevels.Checked = True
        Me.CHBSecretLevels.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBSecretLevels.Location = New System.Drawing.Point(9, 92)
        Me.CHBSecretLevels.Name = "CHBSecretLevels"
        Me.CHBSecretLevels.Size = New System.Drawing.Size(247, 17)
        Me.CHBSecretLevels.TabIndex = 7
        Me.CHBSecretLevels.Text = "Save and restore from Descent II secret levels."
        Me.CHBSecretLevels.UseVisualStyleBackColor = True
        '
        'CHBFreezeRobots
        '
        Me.CHBFreezeRobots.AutoSize = True
        Me.CHBFreezeRobots.Location = New System.Drawing.Point(9, 138)
        Me.CHBFreezeRobots.Name = "CHBFreezeRobots"
        Me.CHBFreezeRobots.Size = New System.Drawing.Size(93, 17)
        Me.CHBFreezeRobots.TabIndex = 6
        Me.CHBFreezeRobots.Text = "Freeze robots."
        Me.CHBFreezeRobots.UseVisualStyleBackColor = True
        '
        'LBLDefaultPlayer
        '
        Me.LBLDefaultPlayer.AutoSize = True
        Me.LBLDefaultPlayer.Location = New System.Drawing.Point(6, 3)
        Me.LBLDefaultPlayer.Name = "LBLDefaultPlayer"
        Me.LBLDefaultPlayer.Size = New System.Drawing.Size(73, 13)
        Me.LBLDefaultPlayer.TabIndex = 29
        Me.LBLDefaultPlayer.Text = "Default Player"
        '
        'CHBPrintDaignostic
        '
        Me.CHBPrintDaignostic.AutoSize = True
        Me.CHBPrintDaignostic.Checked = True
        Me.CHBPrintDaignostic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBPrintDaignostic.Location = New System.Drawing.Point(9, 161)
        Me.CHBPrintDaignostic.Name = "CHBPrintDaignostic"
        Me.CHBPrintDaignostic.Size = New System.Drawing.Size(207, 17)
        Me.CHBPrintDaignostic.TabIndex = 5
        Me.CHBPrintDaignostic.Text = "Print diagnostic messages to ""d2x.log"""
        Me.CHBPrintDaignostic.UseVisualStyleBackColor = True
        '
        'CHBGerman
        '
        Me.CHBGerman.AutoSize = True
        Me.CHBGerman.Location = New System.Drawing.Point(9, 184)
        Me.CHBGerman.Name = "CHBGerman"
        Me.CHBGerman.Size = New System.Drawing.Size(143, 17)
        Me.CHBGerman.TabIndex = 4
        Me.CHBGerman.Text = "Use German localization."
        Me.CHBGerman.UseVisualStyleBackColor = True
        '
        'TABVideoSettings
        '
        Me.TABVideoSettings.Controls.Add(Me.GRBReticle)
        Me.TABVideoSettings.Controls.Add(Me.LBLShowMovies)
        Me.TABVideoSettings.Controls.Add(Me.LBLPreloadTextures)
        Me.TABVideoSettings.Controls.Add(Me.CMBPreloadTextures)
        Me.TABVideoSettings.Controls.Add(Me.CHBUnloadTextures)
        Me.TABVideoSettings.Controls.Add(Me.CHBShaders)
        Me.TABVideoSettings.Controls.Add(Me.CHBMultriThreading)
        Me.TABVideoSettings.Controls.Add(Me.CHBProgressBar)
        Me.TABVideoSettings.Controls.Add(Me.CHBFullScreen)
        Me.TABVideoSettings.Controls.Add(Me.LBLHiResModelSize)
        Me.TABVideoSettings.Controls.Add(Me.CMBHiResModelSize)
        Me.TABVideoSettings.Controls.Add(Me.CHBHiResModels)
        Me.TABVideoSettings.Controls.Add(Me.CHBHiResTextures)
        Me.TABVideoSettings.Controls.Add(Me.CHBAntiAliasing)
        Me.TABVideoSettings.Controls.Add(Me.CMBShowMovies)
        Me.TABVideoSettings.Controls.Add(Me.CHBShowBriefings)
        Me.TABVideoSettings.Controls.Add(Me.CMBScreenResolution)
        Me.TABVideoSettings.Controls.Add(Me.LBLScreenResolution)
        Me.TABVideoSettings.Controls.Add(Me.NUDMenuFade)
        Me.TABVideoSettings.Controls.Add(Me.LBLMenuFade)
        Me.TABVideoSettings.Location = New System.Drawing.Point(4, 22)
        Me.TABVideoSettings.Name = "TABVideoSettings"
        Me.TABVideoSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TABVideoSettings.Size = New System.Drawing.Size(328, 447)
        Me.TABVideoSettings.TabIndex = 1
        Me.TABVideoSettings.Text = "Video"
        Me.TABVideoSettings.UseVisualStyleBackColor = True
        '
        'GRBReticle
        '
        Me.GRBReticle.Controls.Add(Me.NUDReticle)
        Me.GRBReticle.Controls.Add(Me.LBLReticleLineLength)
        Me.GRBReticle.Controls.Add(Me.RDBReticleDrawn)
        Me.GRBReticle.Controls.Add(Me.RDBReticleBitmap)
        Me.GRBReticle.Location = New System.Drawing.Point(6, 379)
        Me.GRBReticle.Name = "GRBReticle"
        Me.GRBReticle.Size = New System.Drawing.Size(130, 64)
        Me.GRBReticle.TabIndex = 41
        Me.GRBReticle.TabStop = False
        Me.GRBReticle.Text = "Reticle"
        '
        'NUDReticle
        '
        Me.NUDReticle.Enabled = False
        Me.NUDReticle.Location = New System.Drawing.Point(71, 38)
        Me.NUDReticle.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NUDReticle.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDReticle.Name = "NUDReticle"
        Me.NUDReticle.ReadOnly = True
        Me.NUDReticle.Size = New System.Drawing.Size(34, 20)
        Me.NUDReticle.TabIndex = 43
        Me.NUDReticle.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LBLReticleLineLength
        '
        Me.LBLReticleLineLength.AutoSize = True
        Me.LBLReticleLineLength.Enabled = False
        Me.LBLReticleLineLength.Location = New System.Drawing.Point(68, 23)
        Me.LBLReticleLineLength.Name = "LBLReticleLineLength"
        Me.LBLReticleLineLength.Size = New System.Drawing.Size(58, 13)
        Me.LBLReticleLineLength.TabIndex = 42
        Me.LBLReticleLineLength.Text = "Line Width"
        '
        'RDBReticleDrawn
        '
        Me.RDBReticleDrawn.AutoSize = True
        Me.RDBReticleDrawn.Location = New System.Drawing.Point(6, 41)
        Me.RDBReticleDrawn.Name = "RDBReticleDrawn"
        Me.RDBReticleDrawn.Size = New System.Drawing.Size(56, 17)
        Me.RDBReticleDrawn.TabIndex = 1
        Me.RDBReticleDrawn.Text = "Drawn"
        Me.RDBReticleDrawn.UseVisualStyleBackColor = True
        '
        'RDBReticleBitmap
        '
        Me.RDBReticleBitmap.AutoSize = True
        Me.RDBReticleBitmap.Checked = True
        Me.RDBReticleBitmap.Location = New System.Drawing.Point(6, 19)
        Me.RDBReticleBitmap.Name = "RDBReticleBitmap"
        Me.RDBReticleBitmap.Size = New System.Drawing.Size(57, 17)
        Me.RDBReticleBitmap.TabIndex = 0
        Me.RDBReticleBitmap.TabStop = True
        Me.RDBReticleBitmap.Text = "Bitmap"
        Me.RDBReticleBitmap.UseVisualStyleBackColor = True
        '
        'LBLShowMovies
        '
        Me.LBLShowMovies.AutoSize = True
        Me.LBLShowMovies.Location = New System.Drawing.Point(3, 253)
        Me.LBLShowMovies.Name = "LBLShowMovies"
        Me.LBLShowMovies.Size = New System.Drawing.Size(71, 13)
        Me.LBLShowMovies.TabIndex = 40
        Me.LBLShowMovies.Text = "Show Movies"
        '
        'LBLPreloadTextures
        '
        Me.LBLPreloadTextures.AutoSize = True
        Me.LBLPreloadTextures.Location = New System.Drawing.Point(3, 127)
        Me.LBLPreloadTextures.Name = "LBLPreloadTextures"
        Me.LBLPreloadTextures.Size = New System.Drawing.Size(87, 13)
        Me.LBLPreloadTextures.TabIndex = 39
        Me.LBLPreloadTextures.Text = "Preload Textures"
        '
        'CMBPreloadTextures
        '
        Me.CMBPreloadTextures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPreloadTextures.FormattingEnabled = True
        Me.CMBPreloadTextures.Items.AddRange(New Object() {"Don't preload anything.", "Geometry", "Objects", "Explosions & Effects", "Hostages", "Powerups", "Weapons"})
        Me.CMBPreloadTextures.Location = New System.Drawing.Point(6, 143)
        Me.CMBPreloadTextures.Name = "CMBPreloadTextures"
        Me.CMBPreloadTextures.Size = New System.Drawing.Size(139, 21)
        Me.CMBPreloadTextures.TabIndex = 38
        '
        'CHBUnloadTextures
        '
        Me.CHBUnloadTextures.AutoSize = True
        Me.CHBUnloadTextures.Location = New System.Drawing.Point(6, 107)
        Me.CHBUnloadTextures.Name = "CHBUnloadTextures"
        Me.CHBUnloadTextures.Size = New System.Drawing.Size(322, 17)
        Me.CHBUnloadTextures.TabIndex = 37
        Me.CHBUnloadTextures.Text = "Unload textures that have been passed to the graphics drivers."
        Me.ToolTip.SetToolTip(Me.CHBUnloadTextures, "This will massively slow down in-game screen resolution or full screen mode chang" & _
                "es!")
        Me.CHBUnloadTextures.UseVisualStyleBackColor = True
        '
        'CHBShaders
        '
        Me.CHBShaders.AutoSize = True
        Me.CHBShaders.Location = New System.Drawing.Point(6, 61)
        Me.CHBShaders.Name = "CHBShaders"
        Me.CHBShaders.Size = New System.Drawing.Size(88, 17)
        Me.CHBShaders.TabIndex = 36
        Me.CHBShaders.Text = "Use shaders."
        Me.CHBShaders.UseVisualStyleBackColor = True
        '
        'CHBMultriThreading
        '
        Me.CHBMultriThreading.AutoSize = True
        Me.CHBMultriThreading.Checked = True
        Me.CHBMultriThreading.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBMultriThreading.Location = New System.Drawing.Point(6, 84)
        Me.CHBMultriThreading.Name = "CHBMultriThreading"
        Me.CHBMultriThreading.Size = New System.Drawing.Size(232, 17)
        Me.CHBMultriThreading.TabIndex = 35
        Me.CHBMultriThreading.Text = "Speed up rendering through multi-threading."
        Me.CHBMultriThreading.UseVisualStyleBackColor = True
        '
        'CHBProgressBar
        '
        Me.CHBProgressBar.AutoSize = True
        Me.CHBProgressBar.Checked = True
        Me.CHBProgressBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBProgressBar.Location = New System.Drawing.Point(6, 317)
        Me.CHBProgressBar.Name = "CHBProgressBar"
        Me.CHBProgressBar.Size = New System.Drawing.Size(219, 17)
        Me.CHBProgressBar.TabIndex = 34
        Me.CHBProgressBar.Text = "Display progress bars when loading data."
        Me.CHBProgressBar.UseVisualStyleBackColor = True
        '
        'LBLHiResModelSize
        '
        Me.LBLHiResModelSize.AutoSize = True
        Me.LBLHiResModelSize.Location = New System.Drawing.Point(171, 39)
        Me.LBLHiResModelSize.Name = "LBLHiResModelSize"
        Me.LBLHiResModelSize.Size = New System.Drawing.Size(98, 13)
        Me.LBLHiResModelSize.TabIndex = 33
        Me.LBLHiResModelSize.Text = "Model Texture Size"
        '
        'CMBHiResModelSize
        '
        Me.CMBHiResModelSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBHiResModelSize.Enabled = False
        Me.CMBHiResModelSize.FormattingEnabled = True
        Me.CMBHiResModelSize.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.CMBHiResModelSize.Location = New System.Drawing.Point(129, 34)
        Me.CMBHiResModelSize.Name = "CMBHiResModelSize"
        Me.CMBHiResModelSize.Size = New System.Drawing.Size(36, 21)
        Me.CMBHiResModelSize.TabIndex = 32
        '
        'CHBHiResModels
        '
        Me.CHBHiResModels.AutoSize = True
        Me.CHBHiResModels.Checked = True
        Me.CHBHiResModels.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBHiResModels.Enabled = False
        Me.CHBHiResModels.Location = New System.Drawing.Point(6, 38)
        Me.CHBHiResModels.Name = "CHBHiResModels"
        Me.CHBHiResModels.Size = New System.Drawing.Size(117, 17)
        Me.CHBHiResModels.TabIndex = 31
        Me.CHBHiResModels.Text = "Use Hi-Res Models"
        Me.ToolTip.SetToolTip(Me.CHBHiResModels, "This only applies if they are present.")
        Me.CHBHiResModels.UseVisualStyleBackColor = True
        '
        'CHBHiResTextures
        '
        Me.CHBHiResTextures.AutoSize = True
        Me.CHBHiResTextures.Checked = True
        Me.CHBHiResTextures.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBHiResTextures.Enabled = False
        Me.CHBHiResTextures.Location = New System.Drawing.Point(6, 15)
        Me.CHBHiResTextures.Name = "CHBHiResTextures"
        Me.CHBHiResTextures.Size = New System.Drawing.Size(124, 17)
        Me.CHBHiResTextures.TabIndex = 30
        Me.CHBHiResTextures.Text = "Use Hi-Res Textures"
        Me.ToolTip.SetToolTip(Me.CHBHiResTextures, "This only applies if they are present.")
        Me.CHBHiResTextures.UseVisualStyleBackColor = True
        '
        'CHBAntiAliasing
        '
        Me.CHBAntiAliasing.AutoSize = True
        Me.CHBAntiAliasing.Location = New System.Drawing.Point(6, 193)
        Me.CHBAntiAliasing.Name = "CHBAntiAliasing"
        Me.CHBAntiAliasing.Size = New System.Drawing.Size(139, 17)
        Me.CHBAntiAliasing.TabIndex = 29
        Me.CHBAntiAliasing.Text = "Full Screen Anti-Aliasing"
        Me.CHBAntiAliasing.UseVisualStyleBackColor = True
        '
        'TABSound
        '
        Me.TABSound.Controls.Add(Me.CHBCustomMusic)
        Me.TABSound.Controls.Add(Me.GRBCustomMusic)
        Me.TABSound.Controls.Add(Me.GRBSoundFrequency)
        Me.TABSound.Controls.Add(Me.CHBSDLSoundMixer)
        Me.TABSound.Location = New System.Drawing.Point(4, 22)
        Me.TABSound.Name = "TABSound"
        Me.TABSound.Size = New System.Drawing.Size(328, 447)
        Me.TABSound.TabIndex = 2
        Me.TABSound.Text = "Sound"
        Me.TABSound.UseVisualStyleBackColor = True
        '
        'CHBCustomMusic
        '
        Me.CHBCustomMusic.AutoSize = True
        Me.CHBCustomMusic.Location = New System.Drawing.Point(9, 163)
        Me.CHBCustomMusic.Name = "CHBCustomMusic"
        Me.CHBCustomMusic.Size = New System.Drawing.Size(115, 17)
        Me.CHBCustomMusic.TabIndex = 8
        Me.CHBCustomMusic.Text = "Use custom music."
        Me.CHBCustomMusic.UseVisualStyleBackColor = True
        '
        'GRBCustomMusic
        '
        Me.GRBCustomMusic.Controls.Add(Me.BTNCustomPlaylist)
        Me.GRBCustomMusic.Controls.Add(Me.BTNCustomCredits)
        Me.GRBCustomMusic.Controls.Add(Me.BTNCustomBriefing)
        Me.GRBCustomMusic.Controls.Add(Me.BTNCustomIntro)
        Me.GRBCustomMusic.Controls.Add(Me.TXBCustomPlaylist)
        Me.GRBCustomMusic.Controls.Add(Me.TXBCustomCredits)
        Me.GRBCustomMusic.Controls.Add(Me.TXBCustomBriefing)
        Me.GRBCustomMusic.Controls.Add(Me.TXBCustomIntro)
        Me.GRBCustomMusic.Controls.Add(Me.LBLCustomPlaylist)
        Me.GRBCustomMusic.Controls.Add(Me.LBLCustomCredits)
        Me.GRBCustomMusic.Controls.Add(Me.LBLCustromBriefing)
        Me.GRBCustomMusic.Controls.Add(Me.LBLCustomIntro)
        Me.GRBCustomMusic.Enabled = False
        Me.GRBCustomMusic.Location = New System.Drawing.Point(9, 186)
        Me.GRBCustomMusic.Name = "GRBCustomMusic"
        Me.GRBCustomMusic.Size = New System.Drawing.Size(314, 176)
        Me.GRBCustomMusic.TabIndex = 7
        Me.GRBCustomMusic.TabStop = False
        Me.GRBCustomMusic.Text = "Custom Music"
        '
        'BTNCustomPlaylist
        '
        Me.BTNCustomPlaylist.Location = New System.Drawing.Point(252, 149)
        Me.BTNCustomPlaylist.Name = "BTNCustomPlaylist"
        Me.BTNCustomPlaylist.Size = New System.Drawing.Size(56, 20)
        Me.BTNCustomPlaylist.TabIndex = 11
        Me.BTNCustomPlaylist.Text = "Browse"
        Me.BTNCustomPlaylist.UseVisualStyleBackColor = True
        '
        'BTNCustomCredits
        '
        Me.BTNCustomCredits.Location = New System.Drawing.Point(252, 110)
        Me.BTNCustomCredits.Name = "BTNCustomCredits"
        Me.BTNCustomCredits.Size = New System.Drawing.Size(56, 20)
        Me.BTNCustomCredits.TabIndex = 10
        Me.BTNCustomCredits.Text = "Browse"
        Me.BTNCustomCredits.UseVisualStyleBackColor = True
        '
        'BTNCustomBriefing
        '
        Me.BTNCustomBriefing.Location = New System.Drawing.Point(252, 71)
        Me.BTNCustomBriefing.Name = "BTNCustomBriefing"
        Me.BTNCustomBriefing.Size = New System.Drawing.Size(56, 20)
        Me.BTNCustomBriefing.TabIndex = 9
        Me.BTNCustomBriefing.Text = "Browse"
        Me.BTNCustomBriefing.UseVisualStyleBackColor = True
        '
        'BTNCustomIntro
        '
        Me.BTNCustomIntro.Location = New System.Drawing.Point(252, 32)
        Me.BTNCustomIntro.Name = "BTNCustomIntro"
        Me.BTNCustomIntro.Size = New System.Drawing.Size(56, 20)
        Me.BTNCustomIntro.TabIndex = 8
        Me.BTNCustomIntro.Text = "Browse"
        Me.BTNCustomIntro.UseVisualStyleBackColor = True
        '
        'TXBCustomPlaylist
        '
        Me.TXBCustomPlaylist.Location = New System.Drawing.Point(6, 149)
        Me.TXBCustomPlaylist.Name = "TXBCustomPlaylist"
        Me.TXBCustomPlaylist.Size = New System.Drawing.Size(240, 20)
        Me.TXBCustomPlaylist.TabIndex = 7
        Me.TXBCustomPlaylist.Text = "d:\programs\d2\music\d2x-xl-playlist.txt"
        '
        'TXBCustomCredits
        '
        Me.TXBCustomCredits.Location = New System.Drawing.Point(6, 110)
        Me.TXBCustomCredits.Name = "TXBCustomCredits"
        Me.TXBCustomCredits.Size = New System.Drawing.Size(240, 20)
        Me.TXBCustomCredits.TabIndex = 6
        '
        'TXBCustomBriefing
        '
        Me.TXBCustomBriefing.Location = New System.Drawing.Point(6, 71)
        Me.TXBCustomBriefing.Name = "TXBCustomBriefing"
        Me.TXBCustomBriefing.Size = New System.Drawing.Size(240, 20)
        Me.TXBCustomBriefing.TabIndex = 5
        '
        'TXBCustomIntro
        '
        Me.TXBCustomIntro.Location = New System.Drawing.Point(6, 32)
        Me.TXBCustomIntro.Name = "TXBCustomIntro"
        Me.TXBCustomIntro.Size = New System.Drawing.Size(240, 20)
        Me.TXBCustomIntro.TabIndex = 4
        Me.TXBCustomIntro.Text = "d:\programs\d2\music\surviving.ogg"
        '
        'LBLCustomPlaylist
        '
        Me.LBLCustomPlaylist.AutoSize = True
        Me.LBLCustomPlaylist.Location = New System.Drawing.Point(3, 133)
        Me.LBLCustomPlaylist.Name = "LBLCustomPlaylist"
        Me.LBLCustomPlaylist.Size = New System.Drawing.Size(68, 13)
        Me.LBLCustomPlaylist.TabIndex = 3
        Me.LBLCustomPlaylist.Text = "Level Playlist"
        '
        'LBLCustomCredits
        '
        Me.LBLCustomCredits.AutoSize = True
        Me.LBLCustomCredits.Location = New System.Drawing.Point(3, 94)
        Me.LBLCustomCredits.Name = "LBLCustomCredits"
        Me.LBLCustomCredits.Size = New System.Drawing.Size(39, 13)
        Me.LBLCustomCredits.TabIndex = 2
        Me.LBLCustomCredits.Text = "Credits"
        '
        'LBLCustromBriefing
        '
        Me.LBLCustromBriefing.AutoSize = True
        Me.LBLCustromBriefing.Location = New System.Drawing.Point(3, 55)
        Me.LBLCustromBriefing.Name = "LBLCustromBriefing"
        Me.LBLCustromBriefing.Size = New System.Drawing.Size(42, 13)
        Me.LBLCustromBriefing.TabIndex = 1
        Me.LBLCustromBriefing.Text = "Briefing"
        '
        'LBLCustomIntro
        '
        Me.LBLCustomIntro.AutoSize = True
        Me.LBLCustomIntro.Location = New System.Drawing.Point(3, 16)
        Me.LBLCustomIntro.Name = "LBLCustomIntro"
        Me.LBLCustomIntro.Size = New System.Drawing.Size(28, 13)
        Me.LBLCustomIntro.TabIndex = 0
        Me.LBLCustomIntro.Text = "Intro"
        '
        'GRBSoundFrequency
        '
        Me.GRBSoundFrequency.Controls.Add(Me.RDBOriginalSound)
        Me.GRBSoundFrequency.Controls.Add(Me.RDB44KHZ)
        Me.GRBSoundFrequency.Controls.Add(Me.RDB22KHZ)
        Me.GRBSoundFrequency.Location = New System.Drawing.Point(9, 69)
        Me.GRBSoundFrequency.Name = "GRBSoundFrequency"
        Me.GRBSoundFrequency.Size = New System.Drawing.Size(140, 88)
        Me.GRBSoundFrequency.TabIndex = 6
        Me.GRBSoundFrequency.TabStop = False
        Me.GRBSoundFrequency.Text = "Hi-Res Sound Frequency"
        '
        'RDB44KHZ
        '
        Me.RDB44KHZ.AutoSize = True
        Me.RDB44KHZ.Checked = True
        Me.RDB44KHZ.Location = New System.Drawing.Point(6, 65)
        Me.RDB44KHZ.Name = "RDB44KHZ"
        Me.RDB44KHZ.Size = New System.Drawing.Size(62, 17)
        Me.RDB44KHZ.TabIndex = 1
        Me.RDB44KHZ.TabStop = True
        Me.RDB44KHZ.Text = "44 KHZ"
        Me.RDB44KHZ.UseVisualStyleBackColor = True
        '
        'RDB22KHZ
        '
        Me.RDB22KHZ.AutoSize = True
        Me.RDB22KHZ.Location = New System.Drawing.Point(6, 42)
        Me.RDB22KHZ.Name = "RDB22KHZ"
        Me.RDB22KHZ.Size = New System.Drawing.Size(62, 17)
        Me.RDB22KHZ.TabIndex = 0
        Me.RDB22KHZ.Text = "22 KHZ"
        Me.RDB22KHZ.UseVisualStyleBackColor = True
        '
        'TABCustomMenuBackground
        '
        Me.TABCustomMenuBackground.Controls.Add(Me.CHBCustomBackgroundGreyscale)
        Me.TABCustomMenuBackground.Controls.Add(Me.LBLCustomBackground)
        Me.TABCustomMenuBackground.Controls.Add(Me.TXBCustomBackground)
        Me.TABCustomMenuBackground.Controls.Add(Me.NUDCustomBackgroundTransparency)
        Me.TABCustomMenuBackground.Controls.Add(Me.CHBCustomBackgroundTransparency)
        Me.TABCustomMenuBackground.Controls.Add(Me.LBLCustomBackgroundTransparency)
        Me.TABCustomMenuBackground.Controls.Add(Me.BTNCustomBackground)
        Me.TABCustomMenuBackground.Controls.Add(Me.NUDCustomBackgroundBrightness)
        Me.TABCustomMenuBackground.Controls.Add(Me.LBLCustomBackgroundBrightness)
        Me.TABCustomMenuBackground.Location = New System.Drawing.Point(4, 22)
        Me.TABCustomMenuBackground.Name = "TABCustomMenuBackground"
        Me.TABCustomMenuBackground.Size = New System.Drawing.Size(328, 447)
        Me.TABCustomMenuBackground.TabIndex = 4
        Me.TABCustomMenuBackground.Text = "Custom Menu Background"
        Me.TABCustomMenuBackground.UseVisualStyleBackColor = True
        '
        'BTNSave
        '
        Me.BTNSave.Location = New System.Drawing.Point(111, 481)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(75, 23)
        Me.BTNSave.TabIndex = 40
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'BTNSaveRun
        '
        Me.BTNSaveRun.Location = New System.Drawing.Point(192, 481)
        Me.BTNSaveRun.Name = "BTNSaveRun"
        Me.BTNSaveRun.Size = New System.Drawing.Size(75, 23)
        Me.BTNSaveRun.TabIndex = 41
        Me.BTNSaveRun.Text = "Save + Run"
        Me.BTNSaveRun.UseVisualStyleBackColor = True
        '
        'BTNCancel
        '
        Me.BTNCancel.Location = New System.Drawing.Point(273, 481)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancel.TabIndex = 42
        Me.BTNCancel.Text = "Cancel"
        Me.BTNCancel.UseVisualStyleBackColor = True
        '
        'CHBAutoDemo
        '
        Me.CHBAutoDemo.AutoSize = True
        Me.CHBAutoDemo.Enabled = False
        Me.CHBAutoDemo.Location = New System.Drawing.Point(9, 230)
        Me.CHBAutoDemo.Name = "CHBAutoDemo"
        Me.CHBAutoDemo.Size = New System.Drawing.Size(154, 17)
        Me.CHBAutoDemo.TabIndex = 30
        Me.CHBAutoDemo.Text = "Automatically run demo file."
        Me.CHBAutoDemo.UseVisualStyleBackColor = True
        '
        'CMBAutoDemo
        '
        Me.CMBAutoDemo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBAutoDemo.Enabled = False
        Me.CMBAutoDemo.FormattingEnabled = True
        Me.CMBAutoDemo.Location = New System.Drawing.Point(169, 226)
        Me.CMBAutoDemo.Name = "CMBAutoDemo"
        Me.CMBAutoDemo.Size = New System.Drawing.Size(121, 21)
        Me.CMBAutoDemo.TabIndex = 31
        '
        'CHBRunDemos
        '
        Me.CHBRunDemos.AutoSize = True
        Me.CHBRunDemos.Checked = True
        Me.CHBRunDemos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHBRunDemos.Location = New System.Drawing.Point(9, 207)
        Me.CHBRunDemos.Name = "CHBRunDemos"
        Me.CHBRunDemos.Size = New System.Drawing.Size(190, 17)
        Me.CHBRunDemos.TabIndex = 32
        Me.CHBRunDemos.Text = "Run demos when program is idling."
        Me.CHBRunDemos.UseVisualStyleBackColor = True
        '
        'RDBOriginalSound
        '
        Me.RDBOriginalSound.AutoSize = True
        Me.RDBOriginalSound.Location = New System.Drawing.Point(6, 19)
        Me.RDBOriginalSound.Name = "RDBOriginalSound"
        Me.RDBOriginalSound.Size = New System.Drawing.Size(60, 17)
        Me.RDBOriginalSound.TabIndex = 9
        Me.RDBOriginalSound.TabStop = True
        Me.RDBOriginalSound.Text = "Original"
        Me.RDBOriginalSound.UseVisualStyleBackColor = True
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 515)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSaveRun)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.TABSetup)
        Me.Name = "Setup"
        Me.Text = "Descent 2 X-XL Setup"
        CType(Me.NUDMenuFade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDCustomBackgroundBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDCustomBackgroundTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABSetup.ResumeLayout(False)
        Me.TABGameplay.ResumeLayout(False)
        Me.TABGameplay.PerformLayout()
        Me.TABVideoSettings.ResumeLayout(False)
        Me.TABVideoSettings.PerformLayout()
        Me.GRBReticle.ResumeLayout(False)
        Me.GRBReticle.PerformLayout()
        CType(Me.NUDReticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABSound.ResumeLayout(False)
        Me.TABSound.PerformLayout()
        Me.GRBCustomMusic.ResumeLayout(False)
        Me.GRBCustomMusic.PerformLayout()
        Me.GRBSoundFrequency.ResumeLayout(False)
        Me.GRBSoundFrequency.PerformLayout()
        Me.TABCustomMenuBackground.ResumeLayout(False)
        Me.TABCustomMenuBackground.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CHBFullScreen As System.Windows.Forms.CheckBox
    Friend WithEvents CHBGrabMouse As System.Windows.Forms.CheckBox
    Friend WithEvents CHBCDSkip As System.Windows.Forms.CheckBox
    Friend WithEvents CHBDisplayMessages As System.Windows.Forms.CheckBox
    Friend WithEvents CHBShowBriefings As System.Windows.Forms.CheckBox
    Friend WithEvents CHBSDLSoundMixer As System.Windows.Forms.CheckBox
    Friend WithEvents CMBShowMovies As System.Windows.Forms.ComboBox
    Friend WithEvents CMBScreenResolution As System.Windows.Forms.ComboBox
    Friend WithEvents NUDMenuFade As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBLMenuFade As System.Windows.Forms.Label
    Friend WithEvents LBLScreenResolution As System.Windows.Forms.Label
    Friend WithEvents TXBCustomBackground As System.Windows.Forms.TextBox
    Friend WithEvents LBLCustomBackground As System.Windows.Forms.Label
    Friend WithEvents BTNCustomBackground As System.Windows.Forms.Button
    Friend WithEvents NUDCustomBackgroundBrightness As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBLCustomBackgroundBrightness As System.Windows.Forms.Label
    Friend WithEvents NUDCustomBackgroundTransparency As System.Windows.Forms.NumericUpDown
    Friend WithEvents CHBCustomBackgroundTransparency As System.Windows.Forms.CheckBox
    Friend WithEvents LBLCustomBackgroundTransparency As System.Windows.Forms.Label
    Friend WithEvents CHBCustomBackgroundGreyscale As System.Windows.Forms.CheckBox
    Friend WithEvents TABSetup As System.Windows.Forms.TabControl
    Friend WithEvents TABGameplay As System.Windows.Forms.TabPage
    Friend WithEvents TABVideoSettings As System.Windows.Forms.TabPage
    Friend WithEvents TABSound As System.Windows.Forms.TabPage
    Friend WithEvents TABCustomMenuBackground As System.Windows.Forms.TabPage
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CHBHiResModels As System.Windows.Forms.CheckBox
    Friend WithEvents CHBHiResTextures As System.Windows.Forms.CheckBox
    Friend WithEvents CHBAntiAliasing As System.Windows.Forms.CheckBox
    Friend WithEvents LBLHiResModelSize As System.Windows.Forms.Label
    Friend WithEvents CMBHiResModelSize As System.Windows.Forms.ComboBox
    Friend WithEvents GRBSoundFrequency As System.Windows.Forms.GroupBox
    Friend WithEvents RDB44KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents RDB22KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents CHBProgressBar As System.Windows.Forms.CheckBox
    Friend WithEvents CHBGerman As System.Windows.Forms.CheckBox
    Friend WithEvents CHBMultriThreading As System.Windows.Forms.CheckBox
    Friend WithEvents GRBCustomMusic As System.Windows.Forms.GroupBox
    Friend WithEvents TXBCustomPlaylist As System.Windows.Forms.TextBox
    Friend WithEvents TXBCustomCredits As System.Windows.Forms.TextBox
    Friend WithEvents TXBCustomBriefing As System.Windows.Forms.TextBox
    Friend WithEvents TXBCustomIntro As System.Windows.Forms.TextBox
    Friend WithEvents LBLCustomPlaylist As System.Windows.Forms.Label
    Friend WithEvents LBLCustomCredits As System.Windows.Forms.Label
    Friend WithEvents LBLCustromBriefing As System.Windows.Forms.Label
    Friend WithEvents LBLCustomIntro As System.Windows.Forms.Label
    Friend WithEvents BTNCustomPlaylist As System.Windows.Forms.Button
    Friend WithEvents BTNCustomCredits As System.Windows.Forms.Button
    Friend WithEvents BTNCustomBriefing As System.Windows.Forms.Button
    Friend WithEvents BTNCustomIntro As System.Windows.Forms.Button
    Friend WithEvents CHBCustomMusic As System.Windows.Forms.CheckBox
    Friend WithEvents CHBPrintDaignostic As System.Windows.Forms.CheckBox
    Friend WithEvents CHBFreezeRobots As System.Windows.Forms.CheckBox
    Friend WithEvents CHBSecretLevels As System.Windows.Forms.CheckBox
    Friend WithEvents CHBUnloadTextures As System.Windows.Forms.CheckBox
    Friend WithEvents CHBShaders As System.Windows.Forms.CheckBox
    Friend WithEvents LBLPreloadTextures As System.Windows.Forms.Label
    Friend WithEvents CMBPreloadTextures As System.Windows.Forms.ComboBox
    Friend WithEvents LBLShowMovies As System.Windows.Forms.Label
    Friend WithEvents CMBDefaultPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents LBLDefaultPlayer As System.Windows.Forms.Label
    Friend WithEvents GRBReticle As System.Windows.Forms.GroupBox
    Friend WithEvents RDBReticleDrawn As System.Windows.Forms.RadioButton
    Friend WithEvents RDBReticleBitmap As System.Windows.Forms.RadioButton
    Friend WithEvents NUDReticle As System.Windows.Forms.NumericUpDown
    Friend WithEvents LBLReticleLineLength As System.Windows.Forms.Label
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents BTNSaveRun As System.Windows.Forms.Button
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents CMBAutoDemo As System.Windows.Forms.ComboBox
    Friend WithEvents CHBAutoDemo As System.Windows.Forms.CheckBox
    Friend WithEvents CHBRunDemos As System.Windows.Forms.CheckBox
    Friend WithEvents RDBOriginalSound As System.Windows.Forms.RadioButton

End Class
