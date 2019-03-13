<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Main_timer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CM = New Cyotek.Windows.Forms.ColorEditorManager()
        Me.colorWheel = New Cyotek.Windows.Forms.ColorWheel()
        Me.lightnessColorSlider = New Cyotek.Windows.Forms.LightnessColorSlider()
        Me.CM2 = New Cyotek.Windows.Forms.ColorEditorManager()
        Me.ColorWheel1 = New Cyotek.Windows.Forms.ColorWheel()
        Me.LightnessColorSlider1 = New Cyotek.Windows.Forms.LightnessColorSlider()
        Me.Fog_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.CM3 = New Cyotek.Windows.Forms.ColorEditorManager()
        Me.ColorWheel2 = New Cyotek.Windows.Forms.ColorWheel()
        Me.LightnessColorSlider2 = New Cyotek.Windows.Forms.LightnessColorSlider()
        Me.Theater_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Sun_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Bot_Rennamer_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GList = New System.Windows.Forms.ImageList(Me.components)
        Me.Gun_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.C_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NC_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New Bo2_Compact_v2._0.LogInThemeContainer()
        Me.Info_button = New Bo2_Compact_v2._0.LogInButton()
        Me.LogInGroupBox1 = New Bo2_Compact_v2._0.LogInGroupBox()
        Me.Load_button = New Bo2_Compact_v2._0.LogInButton()
        Me.Save_button = New Bo2_Compact_v2._0.LogInButton()
        Me.Public_lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PlayerNb = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gameMode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mapName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.in_game = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyTabControl = New Bo2_Compact_v2._0.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.G = New System.Windows.Forms.GroupBox()
        Me.Feed_ok = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.ennemies_pic = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ennemies_combo = New Bo2_Compact_v2._0.LogInComboBox()
        Me.allies_pic = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Allies_combo = New Bo2_Compact_v2._0.LogInComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CFG_box = New Bo2_Compact_v2._0.LogInComboBox()
        Me.CG = New System.Windows.Forms.GroupBox()
        Me.mpghlink = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.R_2d = New System.Windows.Forms.CheckBox()
        Me.nochat = New System.Windows.Forms.CheckBox()
        Me.R_Gun = New System.Windows.Forms.CheckBox()
        Me.R_crosshair = New System.Windows.Forms.CheckBox()
        Me.R_Rank = New System.Windows.Forms.CheckBox()
        Me.R_Name = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cg_color_activate = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.temp = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.saturation = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ANRI = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Rank_txt = New Bo2_Compact_v2._0.LogInUserTextBox()
        Me.Names_txt = New Bo2_Compact_v2._0.LogInUserTextBox()
        Me.Icon_txt = New Bo2_Compact_v2._0.LogInUserTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GunZ_lbl = New System.Windows.Forms.Label()
        Me.GunZ_Box = New System.Windows.Forms.CheckBox()
        Me.GunZ_Bar = New System.Windows.Forms.TrackBar()
        Me.GunY_lbl = New System.Windows.Forms.Label()
        Me.GunY_Box = New System.Windows.Forms.CheckBox()
        Me.GunY_Bar = New System.Windows.Forms.TrackBar()
        Me.GunX_lbl = New System.Windows.Forms.Label()
        Me.GunX_Box = New System.Windows.Forms.CheckBox()
        Me.GunX_Bar = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FOVS_Bar = New Bo2_Compact_v2._0.LogInTrackBar2()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FPS_Bar = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fov_Bar = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.R_Player = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.SAO_Intensity_On = New Bo2_Compact_v2._0.LogInButton()
        Me.SAO_Bias_On = New Bo2_Compact_v2._0.LogInButton()
        Me.SAO_Intensity = New System.Windows.Forms.NumericUpDown()
        Me.SAO_Bias = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.SAO_enable = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.SAO_Radius = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.SAO_Scale = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.nend = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.nstart = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.fstart = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.fend = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.nblur = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.fblur = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.DOF_On = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GScom = New Bo2_Compact_v2._0.LogInComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.FFC3 = New System.Windows.Forms.NumericUpDown()
        Me.FFC2 = New System.Windows.Forms.NumericUpDown()
        Me.FFC1 = New System.Windows.Forms.NumericUpDown()
        Me.FBC3 = New System.Windows.Forms.NumericUpDown()
        Me.FBC2 = New System.Windows.Forms.NumericUpDown()
        Me.FBC1 = New System.Windows.Forms.NumericUpDown()
        Me.foggmzor = New Bo2_Compact_v2._0.LogInComboBox()
        Me.GmzorzConfig = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.SyncColors = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.fogFarExp = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.fogBaseExp = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.fogBias = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.fogHeight = New Bo2_Compact_v2._0.LogInTrackBar3()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.fogDistance = New Bo2_Compact_v2._0.LogInTrackBar3()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.fogStart = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Light_color_lbl = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Sun_Y = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Sun_X = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.SkyR = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.SkyB = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.SkyT = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.SkyTemp = New Bo2_Compact_v2._0.LogInTrackBar3()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Enable_health = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.bot_health = New System.Windows.Forms.NumericUpDown()
        Me.your_health = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Send_names = New Bo2_Compact_v2._0.LogInButton()
        Me.Refresh_names = New Bo2_Compact_v2._0.LogInButton()
        Me.LogInTabControl1 = New Bo2_Compact_v2._0.LogInTabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.bot5 = New System.Windows.Forms.Label()
        Me.bot4 = New System.Windows.Forms.Label()
        Me.bot3 = New System.Windows.Forms.Label()
        Me.bot2 = New System.Windows.Forms.Label()
        Me.bot1 = New System.Windows.Forms.Label()
        Me.bot0 = New System.Windows.Forms.Label()
        Me.BotN5 = New System.Windows.Forms.TextBox()
        Me.BotN4 = New System.Windows.Forms.TextBox()
        Me.BotN3 = New System.Windows.Forms.TextBox()
        Me.BotN2 = New System.Windows.Forms.TextBox()
        Me.BotN1 = New System.Windows.Forms.TextBox()
        Me.BotN0 = New System.Windows.Forms.TextBox()
        Me.BotT5 = New System.Windows.Forms.TextBox()
        Me.BotT4 = New System.Windows.Forms.TextBox()
        Me.BotT3 = New System.Windows.Forms.TextBox()
        Me.BotT2 = New System.Windows.Forms.TextBox()
        Me.BotT1 = New System.Windows.Forms.TextBox()
        Me.BotT0 = New System.Windows.Forms.TextBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.bot11 = New System.Windows.Forms.Label()
        Me.bot10 = New System.Windows.Forms.Label()
        Me.bot9 = New System.Windows.Forms.Label()
        Me.bot8 = New System.Windows.Forms.Label()
        Me.bot7 = New System.Windows.Forms.Label()
        Me.bot6 = New System.Windows.Forms.Label()
        Me.BotN11 = New System.Windows.Forms.TextBox()
        Me.BotN10 = New System.Windows.Forms.TextBox()
        Me.BotN9 = New System.Windows.Forms.TextBox()
        Me.BotN8 = New System.Windows.Forms.TextBox()
        Me.BotN7 = New System.Windows.Forms.TextBox()
        Me.BotN6 = New System.Windows.Forms.TextBox()
        Me.BotT11 = New System.Windows.Forms.TextBox()
        Me.BotT10 = New System.Windows.Forms.TextBox()
        Me.BotT9 = New System.Windows.Forms.TextBox()
        Me.BotT8 = New System.Windows.Forms.TextBox()
        Me.BotT7 = New System.Windows.Forms.TextBox()
        Me.BotT6 = New System.Windows.Forms.TextBox()
        Me.DSWM = New Bo2_Compact_v2._0.LogInRadioButton()
        Me.SWM = New Bo2_Compact_v2._0.LogInRadioButton()
        Me.Bot_Rennamer_on = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Weapons_on = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.C_Secondary = New Bo2_Compact_v2._0.LogInButton()
        Me.P_Primary = New Bo2_Compact_v2._0.LogInButton()
        Me.camo_box = New Bo2_Compact_v2._0.LogInComboBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.W_Secondary = New Bo2_Compact_v2._0.LogInButton()
        Me.W_Primary = New Bo2_Compact_v2._0.LogInButton()
        Me.weapon_choose = New Bo2_Compact_v2._0.LogInComboBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.LogInGroupBox3 = New Bo2_Compact_v2._0.LogInGroupBox()
        Me.ANH = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.player2 = New Bo2_Compact_v2._0.LogInRadioButton()
        Me.player1 = New Bo2_Compact_v2._0.LogInRadioButton()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.playerB = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.playerG = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.playerR = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.greenplayer = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Recoil = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Uav = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.LogInGroupBox2 = New Bo2_Compact_v2._0.LogInGroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.ReloadSpeed = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.RapideFire = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.Spread = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.AimSpeed = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.AHO = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.AllPerks = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.LogInGroupBox1.SuspendLayout()
        Me.MyTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.G.SuspendLayout()
        CType(Me.ennemies_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allies_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CG.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saturation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GunZ_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunY_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunX_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.SAO_Intensity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAO_Bias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.FFC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FFC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FFC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.bot_health, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.your_health, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.LogInGroupBox3.SuspendLayout()
        Me.LogInGroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main_timer
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Bo2 Compact 2.0 by LINDRA"
        Me.NotifyIcon1.Visible = True
        '
        'CM
        '
        Me.CM.ColorWheel = Me.colorWheel
        Me.CM.LightnessColorSlider = Me.lightnessColorSlider
        '
        'colorWheel
        '
        Me.colorWheel.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colorWheel.Location = New System.Drawing.Point(19, 391)
        Me.colorWheel.Name = "colorWheel"
        Me.colorWheel.Size = New System.Drawing.Size(158, 158)
        Me.colorWheel.TabIndex = 38
        '
        'lightnessColorSlider
        '
        Me.lightnessColorSlider.Location = New System.Drawing.Point(179, 391)
        Me.lightnessColorSlider.Name = "lightnessColorSlider"
        Me.lightnessColorSlider.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.lightnessColorSlider.Size = New System.Drawing.Size(28, 158)
        Me.lightnessColorSlider.TabIndex = 39
        '
        'CM2
        '
        Me.CM2.ColorWheel = Me.ColorWheel1
        Me.CM2.LightnessColorSlider = Me.LightnessColorSlider1
        '
        'ColorWheel1
        '
        Me.ColorWheel1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel1.Location = New System.Drawing.Point(299, 391)
        Me.ColorWheel1.Name = "ColorWheel1"
        Me.ColorWheel1.Size = New System.Drawing.Size(158, 158)
        Me.ColorWheel1.TabIndex = 52
        '
        'LightnessColorSlider1
        '
        Me.LightnessColorSlider1.Location = New System.Drawing.Point(459, 391)
        Me.LightnessColorSlider1.Name = "LightnessColorSlider1"
        Me.LightnessColorSlider1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LightnessColorSlider1.Size = New System.Drawing.Size(28, 158)
        Me.LightnessColorSlider1.TabIndex = 53
        '
        'Fog_Timer
        '
        Me.Fog_Timer.Interval = 10
        '
        'CM3
        '
        Me.CM3.ColorWheel = Me.ColorWheel2
        Me.CM3.LightnessColorSlider = Me.LightnessColorSlider2
        '
        'ColorWheel2
        '
        Me.ColorWheel2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel2.Location = New System.Drawing.Point(149, 429)
        Me.ColorWheel2.Name = "ColorWheel2"
        Me.ColorWheel2.Size = New System.Drawing.Size(158, 158)
        Me.ColorWheel2.TabIndex = 54
        '
        'LightnessColorSlider2
        '
        Me.LightnessColorSlider2.Location = New System.Drawing.Point(309, 429)
        Me.LightnessColorSlider2.Name = "LightnessColorSlider2"
        Me.LightnessColorSlider2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LightnessColorSlider2.Size = New System.Drawing.Size(28, 158)
        Me.LightnessColorSlider2.TabIndex = 55
        '
        'Theater_Timer
        '
        Me.Theater_Timer.Interval = 10
        '
        'Sun_Timer
        '
        Me.Sun_Timer.Interval = 10
        '
        'Bot_Rennamer_Timer
        '
        Me.Bot_Rennamer_Timer.Interval = 10
        '
        'GList
        '
        Me.GList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.GList.ImageSize = New System.Drawing.Size(16, 16)
        Me.GList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Gun_Timer
        '
        Me.Gun_Timer.Interval = 10
        '
        'C_Timer
        '
        Me.C_Timer.Interval = 10
        '
        'NC_Timer
        '
        Me.NC_Timer.Interval = 1
        '
        'LogInThemeContainer1
        '
        Me.LogInThemeContainer1.AllowClose = True
        Me.LogInThemeContainer1.AllowMaximize = True
        Me.LogInThemeContainer1.AllowMinimize = True
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.CloseChoice = Bo2_Compact_v2._0.LogInThemeContainer.__CloseChoice.Form
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.Info_button)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInGroupBox1)
        Me.LogInThemeContainer1.Controls.Add(Me.MyTabControl)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Movable = True
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Sizable = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(550, 800)
        Me.LogInThemeContainer1.SmartBounds = True
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "MultiPlayer Bo2 Compact v2.1 by LINDRA"
        '
        'Info_button
        '
        Me.Info_button.BackColor = System.Drawing.Color.Transparent
        Me.Info_button.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Info_button.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Info_button.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Info_button.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Info_button.Location = New System.Drawing.Point(373, 3)
        Me.Info_button.Name = "Info_button"
        Me.Info_button.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Info_button.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Info_button.Size = New System.Drawing.Size(75, 30)
        Me.Info_button.TabIndex = 2
        Me.Info_button.Text = "Infos"
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.Load_button)
        Me.LogInGroupBox1.Controls.Add(Me.Save_button)
        Me.LogInGroupBox1.Controls.Add(Me.Public_lbl)
        Me.LogInGroupBox1.Controls.Add(Me.Label7)
        Me.LogInGroupBox1.Controls.Add(Me.PlayerNb)
        Me.LogInGroupBox1.Controls.Add(Me.Label6)
        Me.LogInGroupBox1.Controls.Add(Me.gameMode)
        Me.LogInGroupBox1.Controls.Add(Me.Label4)
        Me.LogInGroupBox1.Controls.Add(Me.mapName)
        Me.LogInGroupBox1.Controls.Add(Me.Label3)
        Me.LogInGroupBox1.Controls.Add(Me.in_game)
        Me.LogInGroupBox1.Controls.Add(Me.Label1)
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(10, 40)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(533, 81)
        Me.LogInGroupBox1.TabIndex = 1
        Me.LogInGroupBox1.Text = "Status"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Load_button
        '
        Me.Load_button.BackColor = System.Drawing.Color.Transparent
        Me.Load_button.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Load_button.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Load_button.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Load_button.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Load_button.Location = New System.Drawing.Point(150, 0)
        Me.Load_button.Name = "Load_button"
        Me.Load_button.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Load_button.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Load_button.Size = New System.Drawing.Size(75, 24)
        Me.Load_button.TabIndex = 11
        Me.Load_button.Text = "Load"
        '
        'Save_button
        '
        Me.Save_button.BackColor = System.Drawing.Color.Transparent
        Me.Save_button.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Save_button.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Save_button.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save_button.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Save_button.Location = New System.Drawing.Point(69, 0)
        Me.Save_button.Name = "Save_button"
        Me.Save_button.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Save_button.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save_button.Size = New System.Drawing.Size(75, 24)
        Me.Save_button.TabIndex = 10
        Me.Save_button.Text = "Save"
        '
        'Public_lbl
        '
        Me.Public_lbl.AutoSize = True
        Me.Public_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Public_lbl.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Public_lbl.ForeColor = System.Drawing.Color.Green
        Me.Public_lbl.Location = New System.Drawing.Point(455, 38)
        Me.Public_lbl.Name = "Public_lbl"
        Me.Public_lbl.Size = New System.Drawing.Size(39, 13)
        Me.Public_lbl.TabIndex = 9
        Me.Public_lbl.Text = "Public"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(360, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Public / Private : "
        '
        'PlayerNb
        '
        Me.PlayerNb.AutoSize = True
        Me.PlayerNb.BackColor = System.Drawing.Color.Transparent
        Me.PlayerNb.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.PlayerNb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PlayerNb.Location = New System.Drawing.Point(131, 60)
        Me.PlayerNb.Name = "PlayerNb"
        Me.PlayerNb.Size = New System.Drawing.Size(13, 13)
        Me.PlayerNb.TabIndex = 7
        Me.PlayerNb.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Number of Players :"
        '
        'gameMode
        '
        Me.gameMode.AutoSize = True
        Me.gameMode.BackColor = System.Drawing.Color.Transparent
        Me.gameMode.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gameMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.gameMode.Location = New System.Drawing.Point(271, 60)
        Me.gameMode.Name = "gameMode"
        Me.gameMode.Size = New System.Drawing.Size(69, 13)
        Me.gameMode.TabIndex = 5
        Me.gameMode.Text = "Domination"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(191, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "GameType : "
        '
        'mapName
        '
        Me.mapName.AutoSize = True
        Me.mapName.BackColor = System.Drawing.Color.Transparent
        Me.mapName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mapName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.mapName.Location = New System.Drawing.Point(271, 38)
        Me.mapName.Name = "mapName"
        Me.mapName.Size = New System.Drawing.Size(62, 13)
        Me.mapName.TabIndex = 3
        Me.mapName.Text = "Nuketwon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(191, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Map Name : "
        '
        'in_game
        '
        Me.in_game.AutoSize = True
        Me.in_game.BackColor = System.Drawing.Color.Transparent
        Me.in_game.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.in_game.ForeColor = System.Drawing.Color.Red
        Me.in_game.Location = New System.Drawing.Point(102, 38)
        Me.in_game.Name = "in_game"
        Me.in_game.Size = New System.Drawing.Size(73, 13)
        Me.in_game.TabIndex = 1
        Me.in_game.Text = "Not in-game"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game Status : "
        '
        'MyTabControl
        '
        Me.MyTabControl.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.MyTabControl.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.MyTabControl.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MyTabControl.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MyTabControl.Controls.Add(Me.TabPage1)
        Me.MyTabControl.Controls.Add(Me.TabPage2)
        Me.MyTabControl.Controls.Add(Me.TabPage3)
        Me.MyTabControl.Controls.Add(Me.TabPage4)
        Me.MyTabControl.Controls.Add(Me.TabPage5)
        Me.MyTabControl.Controls.Add(Me.TabPage6)
        Me.MyTabControl.Controls.Add(Me.TabPage7)
        Me.MyTabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MyTabControl.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MyTabControl.ItemSize = New System.Drawing.Size(240, 32)
        Me.MyTabControl.Location = New System.Drawing.Point(3, 127)
        Me.MyTabControl.Name = "MyTabControl"
        Me.MyTabControl.SelectedIndex = 0
        Me.MyTabControl.Size = New System.Drawing.Size(544, 670)
        Me.MyTabControl.TabIndex = 0
        Me.MyTabControl.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyTabControl.UpLineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.G)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.CFG_box)
        Me.TabPage1.Controls.Add(Me.CG)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(536, 630)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CFG & Basic"
        '
        'G
        '
        Me.G.Controls.Add(Me.Feed_ok)
        Me.G.Controls.Add(Me.ennemies_pic)
        Me.G.Controls.Add(Me.Label17)
        Me.G.Controls.Add(Me.ennemies_combo)
        Me.G.Controls.Add(Me.allies_pic)
        Me.G.Controls.Add(Me.Label16)
        Me.G.Controls.Add(Me.Allies_combo)
        Me.G.Location = New System.Drawing.Point(6, 44)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(522, 183)
        Me.G.TabIndex = 9
        Me.G.TabStop = False
        Me.G.Visible = False
        '
        'Feed_ok
        '
        Me.Feed_ok.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Feed_ok.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Feed_ok.Checked = False
        Me.Feed_ok.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Feed_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Feed_ok.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Feed_ok.Location = New System.Drawing.Point(130, 138)
        Me.Feed_ok.Name = "Feed_ok"
        Me.Feed_ok.Size = New System.Drawing.Size(115, 22)
        Me.Feed_ok.TabIndex = 6
        Me.Feed_ok.Text = "Activate Feed"
        '
        'ennemies_pic
        '
        Me.ennemies_pic.Location = New System.Drawing.Point(289, 90)
        Me.ennemies_pic.Name = "ennemies_pic"
        Me.ennemies_pic.Size = New System.Drawing.Size(100, 26)
        Me.ennemies_pic.TabIndex = 5
        Me.ennemies_pic.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(28, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 19)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Ennemies"
        '
        'ennemies_combo
        '
        Me.ennemies_combo.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ennemies_combo.BackColor = System.Drawing.Color.Transparent
        Me.ennemies_combo.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ennemies_combo.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ennemies_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ennemies_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ennemies_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ennemies_combo.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ennemies_combo.FormattingEnabled = True
        Me.ennemies_combo.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ennemies_combo.Location = New System.Drawing.Point(102, 90)
        Me.ennemies_combo.Name = "ennemies_combo"
        Me.ennemies_combo.Size = New System.Drawing.Size(163, 26)
        Me.ennemies_combo.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ennemies_combo.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ennemies_combo.StartIndex = 0
        Me.ennemies_combo.TabIndex = 3
        '
        'allies_pic
        '
        Me.allies_pic.Location = New System.Drawing.Point(288, 53)
        Me.allies_pic.Name = "allies_pic"
        Me.allies_pic.Size = New System.Drawing.Size(100, 26)
        Me.allies_pic.TabIndex = 2
        Me.allies_pic.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(39, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Allies"
        '
        'Allies_combo
        '
        Me.Allies_combo.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Allies_combo.BackColor = System.Drawing.Color.Transparent
        Me.Allies_combo.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Allies_combo.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Allies_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Allies_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Allies_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Allies_combo.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Allies_combo.FormattingEnabled = True
        Me.Allies_combo.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Allies_combo.Location = New System.Drawing.Point(101, 53)
        Me.Allies_combo.Name = "Allies_combo"
        Me.Allies_combo.Size = New System.Drawing.Size(163, 26)
        Me.Allies_combo.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Allies_combo.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Allies_combo.StartIndex = 0
        Me.Allies_combo.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(17, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Choose Dvar Type : "
        '
        'CFG_box
        '
        Me.CFG_box.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CFG_box.BackColor = System.Drawing.Color.Transparent
        Me.CFG_box.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CFG_box.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CFG_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CFG_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CFG_box.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CFG_box.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CFG_box.FormattingEnabled = True
        Me.CFG_box.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.CFG_box.Location = New System.Drawing.Point(136, 13)
        Me.CFG_box.Name = "CFG_box"
        Me.CFG_box.Size = New System.Drawing.Size(163, 26)
        Me.CFG_box.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.CFG_box.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.CFG_box.StartIndex = 0
        Me.CFG_box.TabIndex = 0
        '
        'CG
        '
        Me.CG.Controls.Add(Me.mpghlink)
        Me.CG.Controls.Add(Me.Label15)
        Me.CG.Controls.Add(Me.GroupBox5)
        Me.CG.Controls.Add(Me.GroupBox4)
        Me.CG.Controls.Add(Me.GroupBox3)
        Me.CG.Controls.Add(Me.GroupBox2)
        Me.CG.Controls.Add(Me.GroupBox1)
        Me.CG.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.CG.Location = New System.Drawing.Point(6, 35)
        Me.CG.Name = "CG"
        Me.CG.Size = New System.Drawing.Size(522, 587)
        Me.CG.TabIndex = 1
        Me.CG.TabStop = False
        Me.CG.Visible = False
        '
        'mpghlink
        '
        Me.mpghlink.AutoSize = True
        Me.mpghlink.LinkColor = System.Drawing.Color.Aqua
        Me.mpghlink.Location = New System.Drawing.Point(333, 513)
        Me.mpghlink.Name = "mpghlink"
        Me.mpghlink.Size = New System.Drawing.Size(73, 19)
        Me.mpghlink.TabIndex = 6
        Me.mpghlink.TabStop = True
        Me.mpghlink.Text = "MPGH.net"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 513)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(318, 19)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "If you have any idea feel free to submit them on :  "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.R_2d)
        Me.GroupBox5.Controls.Add(Me.nochat)
        Me.GroupBox5.Controls.Add(Me.R_Gun)
        Me.GroupBox5.Controls.Add(Me.R_crosshair)
        Me.GroupBox5.Controls.Add(Me.R_Rank)
        Me.GroupBox5.Controls.Add(Me.R_Name)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 326)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(255, 156)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Remove"
        '
        'R_2d
        '
        Me.R_2d.AutoSize = True
        Me.R_2d.Location = New System.Drawing.Point(140, 116)
        Me.R_2d.Name = "R_2d"
        Me.R_2d.Size = New System.Drawing.Size(85, 17)
        Me.R_2d.TabIndex = 5
        Me.R_2d.Text = "No 2Ditems"
        Me.R_2d.UseVisualStyleBackColor = True
        '
        'nochat
        '
        Me.nochat.AutoSize = True
        Me.nochat.Location = New System.Drawing.Point(21, 116)
        Me.nochat.Name = "nochat"
        Me.nochat.Size = New System.Drawing.Size(68, 17)
        Me.nochat.TabIndex = 4
        Me.nochat.Text = "No Chat"
        Me.nochat.UseVisualStyleBackColor = True
        '
        'R_Gun
        '
        Me.R_Gun.AutoSize = True
        Me.R_Gun.Location = New System.Drawing.Point(140, 78)
        Me.R_Gun.Name = "R_Gun"
        Me.R_Gun.Size = New System.Drawing.Size(66, 17)
        Me.R_Gun.TabIndex = 3
        Me.R_Gun.Text = "No Gun"
        Me.R_Gun.UseVisualStyleBackColor = True
        '
        'R_crosshair
        '
        Me.R_crosshair.AutoSize = True
        Me.R_crosshair.Location = New System.Drawing.Point(21, 78)
        Me.R_crosshair.Name = "R_crosshair"
        Me.R_crosshair.Size = New System.Drawing.Size(98, 17)
        Me.R_crosshair.TabIndex = 2
        Me.R_crosshair.Text = "No Crosshaire"
        Me.R_crosshair.UseVisualStyleBackColor = True
        '
        'R_Rank
        '
        Me.R_Rank.AutoSize = True
        Me.R_Rank.Location = New System.Drawing.Point(140, 40)
        Me.R_Rank.Name = "R_Rank"
        Me.R_Rank.Size = New System.Drawing.Size(75, 17)
        Me.R_Rank.TabIndex = 1
        Me.R_Rank.Text = "No Ranks"
        Me.R_Rank.UseVisualStyleBackColor = True
        '
        'R_Name
        '
        Me.R_Name.AutoSize = True
        Me.R_Name.Location = New System.Drawing.Point(21, 40)
        Me.R_Name.Name = "R_Name"
        Me.R_Name.Size = New System.Drawing.Size(81, 17)
        Me.R_Name.TabIndex = 0
        Me.R_Name.Text = "No Names "
        Me.R_Name.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cg_color_activate)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.temp)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.saturation)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(267, 326)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(249, 156)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cg_Color"
        '
        'cg_color_activate
        '
        Me.cg_color_activate.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cg_color_activate.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cg_color_activate.Checked = False
        Me.cg_color_activate.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.cg_color_activate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cg_color_activate.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cg_color_activate.Location = New System.Drawing.Point(127, 128)
        Me.cg_color_activate.Name = "cg_color_activate"
        Me.cg_color_activate.Size = New System.Drawing.Size(118, 22)
        Me.cg_color_activate.TabIndex = 12
        Me.cg_color_activate.Text = "Activate Cg_Color"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(147, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 19)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Cg_Temp"
        '
        'temp
        '
        Me.temp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.temp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.temp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.temp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.temp.Location = New System.Drawing.Point(21, 92)
        Me.temp.Maximum = New Decimal(New Integer() {1187205120, 0, 0, 0})
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(120, 21)
        Me.temp.TabIndex = 10
        Me.temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.temp.Value = New Decimal(New Integer() {1170939904, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(147, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 19)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Cg_Saturation"
        '
        'saturation
        '
        Me.saturation.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.saturation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.saturation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.saturation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.saturation.Location = New System.Drawing.Point(21, 36)
        Me.saturation.Maximum = New Decimal(New Integer() {1065353216, 0, 0, 0})
        Me.saturation.Name = "saturation"
        Me.saturation.Size = New System.Drawing.Size(120, 21)
        Me.saturation.TabIndex = 0
        Me.saturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.saturation.Value = New Decimal(New Integer() {1065353216, 0, 0, 0})
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ANRI)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Rank_txt)
        Me.GroupBox3.Controls.Add(Me.Names_txt)
        Me.GroupBox3.Controls.Add(Me.Icon_txt)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(321, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 188)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resize Name/Icon/Rank"
        '
        'ANRI
        '
        Me.ANRI.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ANRI.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ANRI.Checked = False
        Me.ANRI.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ANRI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ANRI.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ANRI.Location = New System.Drawing.Point(6, 15)
        Me.ANRI.Name = "ANRI"
        Me.ANRI.Size = New System.Drawing.Size(100, 22)
        Me.ANRI.TabIndex = 9
        Me.ANRI.Text = "Activate this"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(23, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 21)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Rank Size"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(23, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 21)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Names Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(25, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 21)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Icon Size"
        '
        'Rank_txt
        '
        Me.Rank_txt.BackColor = System.Drawing.Color.Transparent
        Me.Rank_txt.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Rank_txt.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Rank_txt.Location = New System.Drawing.Point(120, 128)
        Me.Rank_txt.MaxLength = 32767
        Me.Rank_txt.Multiline = False
        Me.Rank_txt.Name = "Rank_txt"
        Me.Rank_txt.ReadOnly = False
        Me.Rank_txt.Size = New System.Drawing.Size(59, 29)
        Me.Rank_txt.TabIndex = 2
        Me.Rank_txt.Text = "5"
        Me.Rank_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Rank_txt.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Rank_txt.UseSystemPasswordChar = False
        '
        'Names_txt
        '
        Me.Names_txt.BackColor = System.Drawing.Color.Transparent
        Me.Names_txt.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Names_txt.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Names_txt.Location = New System.Drawing.Point(120, 81)
        Me.Names_txt.MaxLength = 32767
        Me.Names_txt.Multiline = False
        Me.Names_txt.Name = "Names_txt"
        Me.Names_txt.ReadOnly = False
        Me.Names_txt.Size = New System.Drawing.Size(59, 29)
        Me.Names_txt.TabIndex = 1
        Me.Names_txt.Text = "5"
        Me.Names_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Names_txt.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Names_txt.UseSystemPasswordChar = False
        '
        'Icon_txt
        '
        Me.Icon_txt.BackColor = System.Drawing.Color.Transparent
        Me.Icon_txt.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Icon_txt.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Icon_txt.Location = New System.Drawing.Point(120, 35)
        Me.Icon_txt.MaxLength = 32767
        Me.Icon_txt.Multiline = False
        Me.Icon_txt.Name = "Icon_txt"
        Me.Icon_txt.ReadOnly = False
        Me.Icon_txt.Size = New System.Drawing.Size(59, 29)
        Me.Icon_txt.TabIndex = 0
        Me.Icon_txt.Text = "7"
        Me.Icon_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Icon_txt.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Icon_txt.UseSystemPasswordChar = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GunZ_lbl)
        Me.GroupBox2.Controls.Add(Me.GunZ_Box)
        Me.GroupBox2.Controls.Add(Me.GunZ_Bar)
        Me.GroupBox2.Controls.Add(Me.GunY_lbl)
        Me.GroupBox2.Controls.Add(Me.GunY_Box)
        Me.GroupBox2.Controls.Add(Me.GunY_Bar)
        Me.GroupBox2.Controls.Add(Me.GunX_lbl)
        Me.GroupBox2.Controls.Add(Me.GunX_Box)
        Me.GroupBox2.Controls.Add(Me.GunX_Bar)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gun Position (X,Y,Z)"
        '
        'GunZ_lbl
        '
        Me.GunZ_lbl.AutoSize = True
        Me.GunZ_lbl.Location = New System.Drawing.Point(252, 55)
        Me.GunZ_lbl.Name = "GunZ_lbl"
        Me.GunZ_lbl.Size = New System.Drawing.Size(13, 13)
        Me.GunZ_lbl.TabIndex = 8
        Me.GunZ_lbl.Text = "0"
        '
        'GunZ_Box
        '
        Me.GunZ_Box.AutoSize = True
        Me.GunZ_Box.Location = New System.Drawing.Point(230, 35)
        Me.GunZ_Box.Name = "GunZ_Box"
        Me.GunZ_Box.Size = New System.Drawing.Size(57, 17)
        Me.GunZ_Box.TabIndex = 7
        Me.GunZ_Box.Text = "Gun Z"
        Me.GunZ_Box.UseVisualStyleBackColor = True
        '
        'GunZ_Bar
        '
        Me.GunZ_Bar.Location = New System.Drawing.Point(242, 68)
        Me.GunZ_Bar.Minimum = -10
        Me.GunZ_Bar.Name = "GunZ_Bar"
        Me.GunZ_Bar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GunZ_Bar.Size = New System.Drawing.Size(45, 104)
        Me.GunZ_Bar.TabIndex = 6
        '
        'GunY_lbl
        '
        Me.GunY_lbl.AutoSize = True
        Me.GunY_lbl.Location = New System.Drawing.Point(148, 55)
        Me.GunY_lbl.Name = "GunY_lbl"
        Me.GunY_lbl.Size = New System.Drawing.Size(13, 13)
        Me.GunY_lbl.TabIndex = 5
        Me.GunY_lbl.Text = "0"
        '
        'GunY_Box
        '
        Me.GunY_Box.AutoSize = True
        Me.GunY_Box.Location = New System.Drawing.Point(124, 35)
        Me.GunY_Box.Name = "GunY_Box"
        Me.GunY_Box.Size = New System.Drawing.Size(56, 17)
        Me.GunY_Box.TabIndex = 4
        Me.GunY_Box.Text = "Gun Y"
        Me.GunY_Box.UseVisualStyleBackColor = True
        '
        'GunY_Bar
        '
        Me.GunY_Bar.Location = New System.Drawing.Point(136, 68)
        Me.GunY_Bar.Minimum = -10
        Me.GunY_Bar.Name = "GunY_Bar"
        Me.GunY_Bar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GunY_Bar.Size = New System.Drawing.Size(45, 104)
        Me.GunY_Bar.TabIndex = 3
        '
        'GunX_lbl
        '
        Me.GunX_lbl.AutoSize = True
        Me.GunX_lbl.Location = New System.Drawing.Point(32, 55)
        Me.GunX_lbl.Name = "GunX_lbl"
        Me.GunX_lbl.Size = New System.Drawing.Size(13, 13)
        Me.GunX_lbl.TabIndex = 2
        Me.GunX_lbl.Text = "0"
        '
        'GunX_Box
        '
        Me.GunX_Box.AutoSize = True
        Me.GunX_Box.Location = New System.Drawing.Point(9, 35)
        Me.GunX_Box.Name = "GunX_Box"
        Me.GunX_Box.Size = New System.Drawing.Size(57, 17)
        Me.GunX_Box.TabIndex = 1
        Me.GunX_Box.Text = "Gun X"
        Me.GunX_Box.UseVisualStyleBackColor = True
        '
        'GunX_Bar
        '
        Me.GunX_Bar.Location = New System.Drawing.Point(21, 68)
        Me.GunX_Bar.Minimum = -10
        Me.GunX_Bar.Name = "GunX_Bar"
        Me.GunX_Bar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GunX_Bar.Size = New System.Drawing.Size(45, 104)
        Me.GunX_Bar.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FOVS_Bar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.FPS_Bar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Fov_Bar)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fov and Fps "
        '
        'FOVS_Bar
        '
        Me.FOVS_Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FOVS_Bar.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.FOVS_Bar.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FOVS_Bar.Location = New System.Drawing.Point(92, 54)
        Me.FOVS_Bar.Maximum = 1000
        Me.FOVS_Bar.Name = "FOVS_Bar"
        Me.FOVS_Bar.Size = New System.Drawing.Size(402, 18)
        Me.FOVS_Bar.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.FOVS_Bar.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FOVS_Bar.TabIndex = 5
        Me.FOVS_Bar.Text = "LogInTrackBar21"
        Me.FOVS_Bar.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FOVS_Bar.Value = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "cg_FovScale"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "com_MaxFPS"
        '
        'FPS_Bar
        '
        Me.FPS_Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FPS_Bar.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.FPS_Bar.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FPS_Bar.Location = New System.Drawing.Point(95, 80)
        Me.FPS_Bar.Maximum = 333
        Me.FPS_Bar.Name = "FPS_Bar"
        Me.FPS_Bar.Size = New System.Drawing.Size(399, 24)
        Me.FPS_Bar.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.FPS_Bar.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FPS_Bar.TabIndex = 2
        Me.FPS_Bar.Text = "LogInTrackBar2"
        Me.FPS_Bar.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FPS_Bar.Value = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "cg_Fov"
        '
        'Fov_Bar
        '
        Me.Fov_Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Fov_Bar.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Fov_Bar.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Fov_Bar.Location = New System.Drawing.Point(75, 21)
        Me.Fov_Bar.Maximum = 180
        Me.Fov_Bar.Name = "Fov_Bar"
        Me.Fov_Bar.Size = New System.Drawing.Size(419, 24)
        Me.Fov_Bar.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Fov_Bar.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Fov_Bar.TabIndex = 0
        Me.Fov_Bar.Text = "LogInTrackBar1"
        Me.Fov_Bar.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Fov_Bar.Value = 65
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.R_Player)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.GScom)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(536, 630)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Theater"
        '
        'R_Player
        '
        Me.R_Player.AutoSize = True
        Me.R_Player.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.R_Player.Location = New System.Drawing.Point(336, 20)
        Me.R_Player.Name = "R_Player"
        Me.R_Player.Size = New System.Drawing.Size(87, 23)
        Me.R_Player.TabIndex = 4
        Me.R_Player.Text = "No Player"
        Me.R_Player.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.SAO_Intensity_On)
        Me.GroupBox7.Controls.Add(Me.SAO_Bias_On)
        Me.GroupBox7.Controls.Add(Me.SAO_Intensity)
        Me.GroupBox7.Controls.Add(Me.SAO_Bias)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.SAO_enable)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.SAO_Radius)
        Me.GroupBox7.Controls.Add(Me.SAO_Scale)
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(6, 345)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(522, 277)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ambient Occlusion"
        '
        'SAO_Intensity_On
        '
        Me.SAO_Intensity_On.BackColor = System.Drawing.Color.Transparent
        Me.SAO_Intensity_On.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SAO_Intensity_On.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SAO_Intensity_On.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SAO_Intensity_On.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SAO_Intensity_On.Location = New System.Drawing.Point(270, 238)
        Me.SAO_Intensity_On.Name = "SAO_Intensity_On"
        Me.SAO_Intensity_On.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SAO_Intensity_On.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SAO_Intensity_On.Size = New System.Drawing.Size(77, 21)
        Me.SAO_Intensity_On.TabIndex = 19
        Me.SAO_Intensity_On.Text = "Send"
        '
        'SAO_Bias_On
        '
        Me.SAO_Bias_On.BackColor = System.Drawing.Color.Transparent
        Me.SAO_Bias_On.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SAO_Bias_On.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SAO_Bias_On.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SAO_Bias_On.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SAO_Bias_On.Location = New System.Drawing.Point(270, 179)
        Me.SAO_Bias_On.Name = "SAO_Bias_On"
        Me.SAO_Bias_On.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SAO_Bias_On.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SAO_Bias_On.Size = New System.Drawing.Size(77, 21)
        Me.SAO_Bias_On.TabIndex = 18
        Me.SAO_Bias_On.Text = "Send"
        '
        'SAO_Intensity
        '
        Me.SAO_Intensity.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SAO_Intensity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SAO_Intensity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SAO_Intensity.Location = New System.Drawing.Point(138, 238)
        Me.SAO_Intensity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.SAO_Intensity.Name = "SAO_Intensity"
        Me.SAO_Intensity.Size = New System.Drawing.Size(120, 21)
        Me.SAO_Intensity.TabIndex = 17
        Me.SAO_Intensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SAO_Bias
        '
        Me.SAO_Bias.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SAO_Bias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SAO_Bias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SAO_Bias.Location = New System.Drawing.Point(138, 179)
        Me.SAO_Bias.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.SAO_Bias.Name = "SAO_Bias"
        Me.SAO_Bias.Size = New System.Drawing.Size(120, 21)
        Me.SAO_Bias.TabIndex = 16
        Me.SAO_Bias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(15, 240)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 19)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "SSAO Intensity"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(15, 179)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 19)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "SSAO Bias"
        '
        'SAO_enable
        '
        Me.SAO_enable.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SAO_enable.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SAO_enable.Checked = False
        Me.SAO_enable.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.SAO_enable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SAO_enable.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SAO_enable.Location = New System.Drawing.Point(14, 24)
        Me.SAO_enable.Name = "SAO_enable"
        Me.SAO_enable.Size = New System.Drawing.Size(107, 22)
        Me.SAO_enable.TabIndex = 13
        Me.SAO_enable.Text = "SSAO Enable"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(15, 129)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 19)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "SSAO Radius"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(15, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 19)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "SSAO Scale"
        '
        'SAO_Radius
        '
        Me.SAO_Radius.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SAO_Radius.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SAO_Radius.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SAO_Radius.Location = New System.Drawing.Point(108, 129)
        Me.SAO_Radius.Maximum = 10
        Me.SAO_Radius.Name = "SAO_Radius"
        Me.SAO_Radius.Size = New System.Drawing.Size(302, 23)
        Me.SAO_Radius.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SAO_Radius.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SAO_Radius.TabIndex = 1
        Me.SAO_Radius.Text = "LogInTrackBar8"
        Me.SAO_Radius.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SAO_Radius.Value = 0
        '
        'SAO_Scale
        '
        Me.SAO_Scale.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SAO_Scale.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SAO_Scale.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SAO_Scale.Location = New System.Drawing.Point(108, 68)
        Me.SAO_Scale.Maximum = 10
        Me.SAO_Scale.Name = "SAO_Scale"
        Me.SAO_Scale.Size = New System.Drawing.Size(303, 23)
        Me.SAO_Scale.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SAO_Scale.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SAO_Scale.TabIndex = 0
        Me.SAO_Scale.Text = "LogInTrackBar7"
        Me.SAO_Scale.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SAO_Scale.Value = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.nend)
        Me.GroupBox6.Controls.Add(Me.nstart)
        Me.GroupBox6.Controls.Add(Me.fstart)
        Me.GroupBox6.Controls.Add(Me.fend)
        Me.GroupBox6.Controls.Add(Me.nblur)
        Me.GroupBox6.Controls.Add(Me.fblur)
        Me.GroupBox6.Controls.Add(Me.DOF_On)
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 61)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(522, 263)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Depth of Field"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(366, 195)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 15)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Near End"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(366, 134)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 15)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Near Start"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(366, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 15)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Far Start"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(93, 195)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 15)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Far End"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(93, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 15)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Near Blur"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(93, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Far Blur"
        '
        'nend
        '
        Me.nend.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.nend.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.nend.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.nend.Location = New System.Drawing.Point(291, 213)
        Me.nend.Maximum = 1500
        Me.nend.Name = "nend"
        Me.nend.Size = New System.Drawing.Size(188, 23)
        Me.nend.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.nend.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.nend.TabIndex = 6
        Me.nend.Text = "LogInTrackBar4"
        Me.nend.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nend.Value = 0
        '
        'nstart
        '
        Me.nstart.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.nstart.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.nstart.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.nstart.Location = New System.Drawing.Point(291, 152)
        Me.nstart.Maximum = 1500
        Me.nstart.Name = "nstart"
        Me.nstart.Size = New System.Drawing.Size(188, 23)
        Me.nstart.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.nstart.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.nstart.TabIndex = 5
        Me.nstart.Text = "LogInTrackBar5"
        Me.nstart.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nstart.Value = 0
        '
        'fstart
        '
        Me.fstart.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fstart.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fstart.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fstart.Location = New System.Drawing.Point(291, 93)
        Me.fstart.Maximum = 1500
        Me.fstart.Name = "fstart"
        Me.fstart.Size = New System.Drawing.Size(188, 23)
        Me.fstart.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fstart.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fstart.TabIndex = 4
        Me.fstart.Text = "LogInTrackBar6"
        Me.fstart.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fstart.Value = 0
        '
        'fend
        '
        Me.fend.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fend.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fend.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fend.Location = New System.Drawing.Point(27, 213)
        Me.fend.Maximum = 1500
        Me.fend.Name = "fend"
        Me.fend.Size = New System.Drawing.Size(174, 23)
        Me.fend.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fend.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fend.TabIndex = 3
        Me.fend.Text = "LogInTrackBar3"
        Me.fend.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fend.Value = 0
        '
        'nblur
        '
        Me.nblur.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.nblur.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.nblur.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.nblur.Location = New System.Drawing.Point(27, 152)
        Me.nblur.Maximum = 10
        Me.nblur.Name = "nblur"
        Me.nblur.Size = New System.Drawing.Size(174, 23)
        Me.nblur.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.nblur.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.nblur.TabIndex = 2
        Me.nblur.Text = "LogInTrackBar2"
        Me.nblur.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nblur.Value = 0
        '
        'fblur
        '
        Me.fblur.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fblur.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fblur.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fblur.Location = New System.Drawing.Point(27, 93)
        Me.fblur.Maximum = 10
        Me.fblur.Name = "fblur"
        Me.fblur.Size = New System.Drawing.Size(174, 23)
        Me.fblur.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fblur.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fblur.TabIndex = 1
        Me.fblur.Text = "LogInTrackBar1"
        Me.fblur.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fblur.Value = 0
        '
        'DOF_On
        '
        Me.DOF_On.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DOF_On.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DOF_On.Checked = False
        Me.DOF_On.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.DOF_On.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DOF_On.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DOF_On.Location = New System.Drawing.Point(14, 36)
        Me.DOF_On.Name = "DOF_On"
        Me.DOF_On.Size = New System.Drawing.Size(107, 22)
        Me.DOF_On.TabIndex = 0
        Me.DOF_On.Text = "DOF Enable"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(16, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 19)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "GreenScreen"
        '
        'GScom
        '
        Me.GScom.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GScom.BackColor = System.Drawing.Color.Transparent
        Me.GScom.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GScom.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GScom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GScom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GScom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GScom.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GScom.FormattingEnabled = True
        Me.GScom.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GScom.Location = New System.Drawing.Point(114, 20)
        Me.GScom.Name = "GScom"
        Me.GScom.Size = New System.Drawing.Size(163, 26)
        Me.GScom.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GScom.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GScom.StartIndex = 0
        Me.GScom.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.FFC3)
        Me.TabPage3.Controls.Add(Me.FFC2)
        Me.TabPage3.Controls.Add(Me.FFC1)
        Me.TabPage3.Controls.Add(Me.FBC3)
        Me.TabPage3.Controls.Add(Me.FBC2)
        Me.TabPage3.Controls.Add(Me.FBC1)
        Me.TabPage3.Controls.Add(Me.foggmzor)
        Me.TabPage3.Controls.Add(Me.GmzorzConfig)
        Me.TabPage3.Controls.Add(Me.SyncColors)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.LightnessColorSlider1)
        Me.TabPage3.Controls.Add(Me.ColorWheel1)
        Me.TabPage3.Controls.Add(Me.fogFarExp)
        Me.TabPage3.Controls.Add(Me.fogBaseExp)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.fogBias)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.fogHeight)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.fogDistance)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.fogStart)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.lightnessColorSlider)
        Me.TabPage3.Controls.Add(Me.colorWheel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(536, 630)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "FOG"
        '
        'FFC3
        '
        Me.FFC3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FFC3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FFC3.ForeColor = System.Drawing.Color.White
        Me.FFC3.Location = New System.Drawing.Point(425, 567)
        Me.FFC3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.FFC3.Name = "FFC3"
        Me.FFC3.Size = New System.Drawing.Size(58, 21)
        Me.FFC3.TabIndex = 64
        Me.FFC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FFC2
        '
        Me.FFC2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FFC2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FFC2.ForeColor = System.Drawing.Color.White
        Me.FFC2.Location = New System.Drawing.Point(361, 567)
        Me.FFC2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.FFC2.Name = "FFC2"
        Me.FFC2.Size = New System.Drawing.Size(58, 21)
        Me.FFC2.TabIndex = 63
        Me.FFC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FFC1
        '
        Me.FFC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FFC1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FFC1.ForeColor = System.Drawing.Color.White
        Me.FFC1.Location = New System.Drawing.Point(297, 567)
        Me.FFC1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.FFC1.Name = "FFC1"
        Me.FFC1.Size = New System.Drawing.Size(58, 21)
        Me.FFC1.TabIndex = 62
        Me.FFC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FBC3
        '
        Me.FBC3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FBC3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FBC3.ForeColor = System.Drawing.Color.White
        Me.FBC3.Location = New System.Drawing.Point(147, 567)
        Me.FBC3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.FBC3.Name = "FBC3"
        Me.FBC3.Size = New System.Drawing.Size(58, 21)
        Me.FBC3.TabIndex = 61
        Me.FBC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FBC2
        '
        Me.FBC2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FBC2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FBC2.ForeColor = System.Drawing.Color.White
        Me.FBC2.Location = New System.Drawing.Point(83, 567)
        Me.FBC2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.FBC2.Name = "FBC2"
        Me.FBC2.Size = New System.Drawing.Size(58, 21)
        Me.FBC2.TabIndex = 60
        Me.FBC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FBC1
        '
        Me.FBC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FBC1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FBC1.ForeColor = System.Drawing.Color.White
        Me.FBC1.Location = New System.Drawing.Point(19, 567)
        Me.FBC1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.FBC1.Name = "FBC1"
        Me.FBC1.Size = New System.Drawing.Size(58, 21)
        Me.FBC1.TabIndex = 59
        Me.FBC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foggmzor
        '
        Me.foggmzor.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.foggmzor.BackColor = System.Drawing.Color.Transparent
        Me.foggmzor.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.foggmzor.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.foggmzor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.foggmzor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.foggmzor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.foggmzor.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.foggmzor.FormattingEnabled = True
        Me.foggmzor.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.foggmzor.Location = New System.Drawing.Point(348, 300)
        Me.foggmzor.Name = "foggmzor"
        Me.foggmzor.Size = New System.Drawing.Size(163, 26)
        Me.foggmzor.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.foggmzor.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.foggmzor.StartIndex = 0
        Me.foggmzor.TabIndex = 58
        '
        'GmzorzConfig
        '
        Me.GmzorzConfig.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GmzorzConfig.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GmzorzConfig.Checked = False
        Me.GmzorzConfig.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.GmzorzConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GmzorzConfig.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GmzorzConfig.Location = New System.Drawing.Point(220, 304)
        Me.GmzorzConfig.Name = "GmzorzConfig"
        Me.GmzorzConfig.Size = New System.Drawing.Size(122, 22)
        Me.GmzorzConfig.TabIndex = 57
        Me.GmzorzConfig.Text = "Gmzorz Config"
        '
        'SyncColors
        '
        Me.SyncColors.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SyncColors.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SyncColors.Checked = False
        Me.SyncColors.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.SyncColors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SyncColors.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SyncColors.Location = New System.Drawing.Point(33, 304)
        Me.SyncColors.Name = "SyncColors"
        Me.SyncColors.Size = New System.Drawing.Size(100, 22)
        Me.SyncColors.TabIndex = 56
        Me.SyncColors.Text = "Sync Colors"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(328, 358)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(108, 19)
        Me.Label36.TabIndex = 55
        Me.Label36.Text = "FOG Far Color : "
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(47, 358)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(117, 19)
        Me.Label35.TabIndex = 54
        Me.Label35.Text = "FOG Base Color : "
        '
        'fogFarExp
        '
        Me.fogFarExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fogFarExp.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fogFarExp.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fogFarExp.Location = New System.Drawing.Point(232, 227)
        Me.fogFarExp.Maximum = 2
        Me.fogFarExp.Name = "fogFarExp"
        Me.fogFarExp.Size = New System.Drawing.Size(187, 23)
        Me.fogFarExp.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fogFarExp.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fogFarExp.TabIndex = 51
        Me.fogFarExp.Text = "LogInTrackBar4"
        Me.fogFarExp.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fogFarExp.Value = 0
        '
        'fogBaseExp
        '
        Me.fogBaseExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fogBaseExp.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fogBaseExp.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fogBaseExp.Location = New System.Drawing.Point(232, 191)
        Me.fogBaseExp.Maximum = 2
        Me.fogBaseExp.Name = "fogBaseExp"
        Me.fogBaseExp.Size = New System.Drawing.Size(187, 23)
        Me.fogBaseExp.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fogBaseExp.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fogBaseExp.TabIndex = 50
        Me.fogBaseExp.Text = "LogInTrackBar3"
        Me.fogBaseExp.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fogBaseExp.Value = 0
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(87, 227)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(130, 19)
        Me.Label34.TabIndex = 49
        Me.Label34.Text = "FOG Far Exposure : "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(87, 191)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(139, 19)
        Me.Label33.TabIndex = 48
        Me.Label33.Text = "FOG Base Exposure : "
        '
        'fogBias
        '
        Me.fogBias.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fogBias.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fogBias.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fogBias.Location = New System.Drawing.Point(115, 142)
        Me.fogBias.Maximum = 400
        Me.fogBias.Name = "fogBias"
        Me.fogBias.Size = New System.Drawing.Size(359, 23)
        Me.fogBias.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fogBias.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fogBias.TabIndex = 47
        Me.fogBias.Text = "LogInTrackBar2"
        Me.fogBias.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fogBias.Value = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(29, 142)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(76, 19)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "FOG Bias : "
        '
        'fogHeight
        '
        Me.fogHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fogHeight.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fogHeight.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fogHeight.Location = New System.Drawing.Point(115, 101)
        Me.fogHeight.Maximum = 50000
        Me.fogHeight.Name = "fogHeight"
        Me.fogHeight.Size = New System.Drawing.Size(358, 23)
        Me.fogHeight.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fogHeight.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fogHeight.TabIndex = 45
        Me.fogHeight.Text = "LogInTrackBar32"
        Me.fogHeight.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fogHeight.Value = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(17, 101)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(93, 19)
        Me.Label31.TabIndex = 44
        Me.Label31.Text = "FOG Height : "
        '
        'fogDistance
        '
        Me.fogDistance.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fogDistance.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fogDistance.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fogDistance.Location = New System.Drawing.Point(115, 59)
        Me.fogDistance.Maximum = 50000
        Me.fogDistance.Name = "fogDistance"
        Me.fogDistance.Size = New System.Drawing.Size(358, 23)
        Me.fogDistance.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fogDistance.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fogDistance.TabIndex = 43
        Me.fogDistance.Text = "LogInTrackBar31"
        Me.fogDistance.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fogDistance.Value = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(6, 59)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 19)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "FOG Distance : "
        '
        'fogStart
        '
        Me.fogStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fogStart.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.fogStart.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.fogStart.Location = New System.Drawing.Point(115, 16)
        Me.fogStart.Maximum = 400
        Me.fogStart.Name = "fogStart"
        Me.fogStart.Size = New System.Drawing.Size(359, 23)
        Me.fogStart.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.fogStart.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.fogStart.TabIndex = 41
        Me.fogStart.Text = "LogInTrackBar1"
        Me.fogStart.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fogStart.Value = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(29, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 19)
        Me.Label29.TabIndex = 40
        Me.Label29.Text = "FOG Start : "
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.Light_color_lbl)
        Me.TabPage4.Controls.Add(Me.Label42)
        Me.TabPage4.Controls.Add(Me.LightnessColorSlider2)
        Me.TabPage4.Controls.Add(Me.ColorWheel2)
        Me.TabPage4.Controls.Add(Me.Sun_Y)
        Me.TabPage4.Controls.Add(Me.Sun_X)
        Me.TabPage4.Controls.Add(Me.Label41)
        Me.TabPage4.Controls.Add(Me.SkyR)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.SkyB)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.SkyT)
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.SkyTemp)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(536, 630)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sun"
        '
        'Light_color_lbl
        '
        Me.Light_color_lbl.AutoSize = True
        Me.Light_color_lbl.ForeColor = System.Drawing.Color.White
        Me.Light_color_lbl.Location = New System.Drawing.Point(192, 398)
        Me.Light_color_lbl.Name = "Light_color_lbl"
        Me.Light_color_lbl.Size = New System.Drawing.Size(100, 19)
        Me.Light_color_lbl.TabIndex = 57
        Me.Light_color_lbl.Text = "R 0 ; G 0 ; B 0 ;"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(51, 398)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(115, 19)
        Me.Label42.TabIndex = 56
        Me.Label42.Text = "Sun Light Color : "
        '
        'Sun_Y
        '
        Me.Sun_Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Sun_Y.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Sun_Y.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Sun_Y.Location = New System.Drawing.Point(55, 329)
        Me.Sun_Y.Maximum = 255
        Me.Sun_Y.Name = "Sun_Y"
        Me.Sun_Y.Size = New System.Drawing.Size(256, 23)
        Me.Sun_Y.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Sun_Y.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Sun_Y.TabIndex = 10
        Me.Sun_Y.Text = "LogInTrackBar5"
        Me.Sun_Y.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sun_Y.Value = 0
        '
        'Sun_X
        '
        Me.Sun_X.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Sun_X.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Sun_X.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Sun_X.Location = New System.Drawing.Point(55, 300)
        Me.Sun_X.Maximum = 100
        Me.Sun_X.Name = "Sun_X"
        Me.Sun_X.Size = New System.Drawing.Size(256, 23)
        Me.Sun_X.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Sun_X.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Sun_X.TabIndex = 9
        Me.Sun_X.Text = "LogInTrackBar4"
        Me.Sun_X.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sun_X.Value = 0
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(51, 268)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(126, 19)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "Sun Light Direction"
        '
        'SkyR
        '
        Me.SkyR.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SkyR.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SkyR.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SkyR.Location = New System.Drawing.Point(70, 194)
        Me.SkyR.Maximum = 180
        Me.SkyR.Name = "SkyR"
        Me.SkyR.Size = New System.Drawing.Size(386, 23)
        Me.SkyR.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SkyR.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SkyR.TabIndex = 7
        Me.SkyR.Text = "LogInTrackBar3"
        Me.SkyR.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkyR.Value = 0
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(226, 172)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(82, 19)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "SkyRotation"
        '
        'SkyB
        '
        Me.SkyB.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SkyB.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SkyB.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SkyB.Location = New System.Drawing.Point(71, 137)
        Me.SkyB.Maximum = 100
        Me.SkyB.Name = "SkyB"
        Me.SkyB.Size = New System.Drawing.Size(386, 23)
        Me.SkyB.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SkyB.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SkyB.TabIndex = 5
        Me.SkyB.Text = "LogInTrackBar2"
        Me.SkyB.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkyB.Value = 100
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(226, 115)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(94, 19)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "SkyBrightness"
        '
        'SkyT
        '
        Me.SkyT.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SkyT.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SkyT.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SkyT.Location = New System.Drawing.Point(71, 80)
        Me.SkyT.Maximum = 200
        Me.SkyT.Name = "SkyT"
        Me.SkyT.Size = New System.Drawing.Size(386, 23)
        Me.SkyT.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SkyT.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SkyT.TabIndex = 3
        Me.SkyT.Text = "LogInTrackBar1"
        Me.SkyT.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkyT.Value = 0
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(226, 58)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(81, 19)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "SkyTrasition"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(226, 10)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 19)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "SkyTemp"
        '
        'SkyTemp
        '
        Me.SkyTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SkyTemp.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SkyTemp.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SkyTemp.Location = New System.Drawing.Point(71, 32)
        Me.SkyTemp.Maximum = 16000
        Me.SkyTemp.Name = "SkyTemp"
        Me.SkyTemp.Size = New System.Drawing.Size(386, 23)
        Me.SkyTemp.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.SkyTemp.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SkyTemp.TabIndex = 0
        Me.SkyTemp.Text = "LogInTrackBar31"
        Me.SkyTemp.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkyTemp.Value = 7000
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage5.Controls.Add(Me.GroupBox9)
        Me.TabPage5.Controls.Add(Me.GroupBox8)
        Me.TabPage5.Controls.Add(Me.Send_names)
        Me.TabPage5.Controls.Add(Me.Refresh_names)
        Me.TabPage5.Controls.Add(Me.LogInTabControl1)
        Me.TabPage5.Controls.Add(Me.DSWM)
        Me.TabPage5.Controls.Add(Me.SWM)
        Me.TabPage5.Controls.Add(Me.Bot_Rennamer_on)
        Me.TabPage5.Location = New System.Drawing.Point(4, 36)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(536, 630)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Bot Rennamer"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Enable_health)
        Me.GroupBox9.Controls.Add(Me.Label66)
        Me.GroupBox9.Controls.Add(Me.Label65)
        Me.GroupBox9.Controls.Add(Me.bot_health)
        Me.GroupBox9.Controls.Add(Me.your_health)
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(8, 55)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(327, 165)
        Me.GroupBox9.TabIndex = 7
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Custom Health "
        '
        'Enable_health
        '
        Me.Enable_health.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Enable_health.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Enable_health.Checked = False
        Me.Enable_health.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Enable_health.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enable_health.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Enable_health.Location = New System.Drawing.Point(128, 137)
        Me.Enable_health.Name = "Enable_health"
        Me.Enable_health.Size = New System.Drawing.Size(119, 22)
        Me.Enable_health.TabIndex = 4
        Me.Enable_health.Text = "Enable Health"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(13, 73)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(74, 19)
        Me.Label66.TabIndex = 3
        Me.Label66.Text = "Bot Health"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(6, 33)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(81, 19)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Your Health"
        '
        'bot_health
        '
        Me.bot_health.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.bot_health.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bot_health.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.bot_health.Location = New System.Drawing.Point(96, 71)
        Me.bot_health.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.bot_health.Name = "bot_health"
        Me.bot_health.Size = New System.Drawing.Size(94, 21)
        Me.bot_health.TabIndex = 1
        Me.bot_health.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.bot_health.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'your_health
        '
        Me.your_health.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.your_health.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.your_health.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.your_health.Location = New System.Drawing.Point(96, 33)
        Me.your_health.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.your_health.Name = "your_health"
        Me.your_health.Size = New System.Drawing.Size(94, 21)
        Me.your_health.TabIndex = 0
        Me.your_health.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.your_health.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label63)
        Me.GroupBox8.Controls.Add(Me.Label64)
        Me.GroupBox8.Controls.Add(Me.Label59)
        Me.GroupBox8.Controls.Add(Me.Label60)
        Me.GroupBox8.Controls.Add(Me.Label61)
        Me.GroupBox8.Controls.Add(Me.Label62)
        Me.GroupBox8.Controls.Add(Me.Label57)
        Me.GroupBox8.Controls.Add(Me.Label58)
        Me.GroupBox8.Controls.Add(Me.Label56)
        Me.GroupBox8.Controls.Add(Me.Label55)
        Me.GroupBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GroupBox8.Location = New System.Drawing.Point(336, 55)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(188, 165)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Color Code"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(54, 111)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(27, 19)
        Me.Label63.TabIndex = 9
        Me.Label63.Text = "^0"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.ForeColor = System.Drawing.Color.Gray
        Me.Label64.Location = New System.Drawing.Point(15, 111)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(27, 19)
        Me.Label64.TabIndex = 8
        Me.Label64.Text = "^9"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label59.Location = New System.Drawing.Point(133, 71)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(27, 19)
        Me.Label59.TabIndex = 7
        Me.Label59.Text = "^8"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(94, 71)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(27, 19)
        Me.Label60.TabIndex = 6
        Me.Label60.Text = "^7"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.Color.Purple
        Me.Label61.Location = New System.Drawing.Point(54, 71)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(27, 19)
        Me.Label61.TabIndex = 5
        Me.Label61.Text = "^6"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.ForeColor = System.Drawing.Color.Cyan
        Me.Label62.Location = New System.Drawing.Point(15, 71)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(27, 19)
        Me.Label62.TabIndex = 4
        Me.Label62.Text = "^5"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.Blue
        Me.Label57.Location = New System.Drawing.Point(133, 33)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(27, 19)
        Me.Label57.TabIndex = 3
        Me.Label57.Text = "^4"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.Color.Yellow
        Me.Label58.Location = New System.Drawing.Point(94, 33)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(27, 19)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "^3"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.Green
        Me.Label56.Location = New System.Drawing.Point(54, 33)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(27, 19)
        Me.Label56.TabIndex = 1
        Me.Label56.Text = "^2"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Red
        Me.Label55.Location = New System.Drawing.Point(15, 33)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(27, 19)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "^1"
        '
        'Send_names
        '
        Me.Send_names.BackColor = System.Drawing.Color.Transparent
        Me.Send_names.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Send_names.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Send_names.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Send_names.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Send_names.Location = New System.Drawing.Point(433, 231)
        Me.Send_names.Name = "Send_names"
        Me.Send_names.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Send_names.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Send_names.Size = New System.Drawing.Size(92, 30)
        Me.Send_names.TabIndex = 5
        Me.Send_names.Text = "Send Name"
        '
        'Refresh_names
        '
        Me.Refresh_names.BackColor = System.Drawing.Color.Transparent
        Me.Refresh_names.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Refresh_names.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Refresh_names.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Refresh_names.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Refresh_names.Location = New System.Drawing.Point(335, 231)
        Me.Refresh_names.Name = "Refresh_names"
        Me.Refresh_names.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Refresh_names.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Refresh_names.Size = New System.Drawing.Size(92, 30)
        Me.Refresh_names.TabIndex = 4
        Me.Refresh_names.Text = "Refresh Name"
        '
        'LogInTabControl1
        '
        Me.LogInTabControl1.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInTabControl1.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInTabControl1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInTabControl1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInTabControl1.Controls.Add(Me.TabPage8)
        Me.LogInTabControl1.Controls.Add(Me.TabPage9)
        Me.LogInTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInTabControl1.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.LogInTabControl1.Location = New System.Drawing.Point(4, 267)
        Me.LogInTabControl1.Name = "LogInTabControl1"
        Me.LogInTabControl1.SelectedIndex = 0
        Me.LogInTabControl1.Size = New System.Drawing.Size(528, 355)
        Me.LogInTabControl1.TabIndex = 3
        Me.LogInTabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInTabControl1.UpLineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage8.Controls.Add(Me.Label69)
        Me.TabPage8.Controls.Add(Me.Label68)
        Me.TabPage8.Controls.Add(Me.bot5)
        Me.TabPage8.Controls.Add(Me.bot4)
        Me.TabPage8.Controls.Add(Me.bot3)
        Me.TabPage8.Controls.Add(Me.bot2)
        Me.TabPage8.Controls.Add(Me.bot1)
        Me.TabPage8.Controls.Add(Me.bot0)
        Me.TabPage8.Controls.Add(Me.BotN5)
        Me.TabPage8.Controls.Add(Me.BotN4)
        Me.TabPage8.Controls.Add(Me.BotN3)
        Me.TabPage8.Controls.Add(Me.BotN2)
        Me.TabPage8.Controls.Add(Me.BotN1)
        Me.TabPage8.Controls.Add(Me.BotN0)
        Me.TabPage8.Controls.Add(Me.BotT5)
        Me.TabPage8.Controls.Add(Me.BotT4)
        Me.TabPage8.Controls.Add(Me.BotT3)
        Me.TabPage8.Controls.Add(Me.BotT2)
        Me.TabPage8.Controls.Add(Me.BotT1)
        Me.TabPage8.Controls.Add(Me.BotT0)
        Me.TabPage8.Location = New System.Drawing.Point(4, 36)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(520, 315)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Allies Bots"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label69.Location = New System.Drawing.Point(195, 17)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(49, 19)
        Me.Label69.TabIndex = 19
        Me.Label69.Text = "Name "
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label68.Location = New System.Drawing.Point(33, 17)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(56, 19)
        Me.Label68.TabIndex = 18
        Me.Label68.Text = "ClanTag"
        '
        'bot5
        '
        Me.bot5.AutoSize = True
        Me.bot5.ForeColor = System.Drawing.Color.White
        Me.bot5.Location = New System.Drawing.Point(317, 276)
        Me.bot5.Name = "bot5"
        Me.bot5.Size = New System.Drawing.Size(43, 19)
        Me.bot5.TabIndex = 17
        Me.bot5.Text = "name"
        '
        'bot4
        '
        Me.bot4.AutoSize = True
        Me.bot4.ForeColor = System.Drawing.Color.White
        Me.bot4.Location = New System.Drawing.Point(317, 230)
        Me.bot4.Name = "bot4"
        Me.bot4.Size = New System.Drawing.Size(43, 19)
        Me.bot4.TabIndex = 16
        Me.bot4.Text = "name"
        '
        'bot3
        '
        Me.bot3.AutoSize = True
        Me.bot3.ForeColor = System.Drawing.Color.White
        Me.bot3.Location = New System.Drawing.Point(317, 182)
        Me.bot3.Name = "bot3"
        Me.bot3.Size = New System.Drawing.Size(43, 19)
        Me.bot3.TabIndex = 15
        Me.bot3.Text = "name"
        '
        'bot2
        '
        Me.bot2.AutoSize = True
        Me.bot2.ForeColor = System.Drawing.Color.White
        Me.bot2.Location = New System.Drawing.Point(317, 135)
        Me.bot2.Name = "bot2"
        Me.bot2.Size = New System.Drawing.Size(43, 19)
        Me.bot2.TabIndex = 14
        Me.bot2.Text = "name"
        '
        'bot1
        '
        Me.bot1.AutoSize = True
        Me.bot1.ForeColor = System.Drawing.Color.White
        Me.bot1.Location = New System.Drawing.Point(317, 86)
        Me.bot1.Name = "bot1"
        Me.bot1.Size = New System.Drawing.Size(43, 19)
        Me.bot1.TabIndex = 13
        Me.bot1.Text = "name"
        '
        'bot0
        '
        Me.bot0.AutoSize = True
        Me.bot0.ForeColor = System.Drawing.Color.White
        Me.bot0.Location = New System.Drawing.Point(317, 40)
        Me.bot0.Name = "bot0"
        Me.bot0.Size = New System.Drawing.Size(43, 19)
        Me.bot0.TabIndex = 12
        Me.bot0.Text = "name"
        '
        'BotN5
        '
        Me.BotN5.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN5.ForeColor = System.Drawing.Color.White
        Me.BotN5.Location = New System.Drawing.Point(135, 272)
        Me.BotN5.Name = "BotN5"
        Me.BotN5.Size = New System.Drawing.Size(166, 25)
        Me.BotN5.TabIndex = 11
        Me.BotN5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN4
        '
        Me.BotN4.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN4.ForeColor = System.Drawing.Color.White
        Me.BotN4.Location = New System.Drawing.Point(135, 224)
        Me.BotN4.Name = "BotN4"
        Me.BotN4.Size = New System.Drawing.Size(166, 25)
        Me.BotN4.TabIndex = 10
        Me.BotN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN3
        '
        Me.BotN3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN3.ForeColor = System.Drawing.Color.White
        Me.BotN3.Location = New System.Drawing.Point(135, 179)
        Me.BotN3.Name = "BotN3"
        Me.BotN3.Size = New System.Drawing.Size(166, 25)
        Me.BotN3.TabIndex = 9
        Me.BotN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN2
        '
        Me.BotN2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN2.ForeColor = System.Drawing.Color.White
        Me.BotN2.Location = New System.Drawing.Point(135, 130)
        Me.BotN2.Name = "BotN2"
        Me.BotN2.Size = New System.Drawing.Size(166, 25)
        Me.BotN2.TabIndex = 8
        Me.BotN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN1
        '
        Me.BotN1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN1.ForeColor = System.Drawing.Color.White
        Me.BotN1.Location = New System.Drawing.Point(135, 83)
        Me.BotN1.Name = "BotN1"
        Me.BotN1.Size = New System.Drawing.Size(166, 25)
        Me.BotN1.TabIndex = 7
        Me.BotN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN0
        '
        Me.BotN0.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN0.ForeColor = System.Drawing.Color.White
        Me.BotN0.Location = New System.Drawing.Point(135, 37)
        Me.BotN0.Name = "BotN0"
        Me.BotN0.Size = New System.Drawing.Size(166, 25)
        Me.BotN0.TabIndex = 6
        Me.BotN0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT5
        '
        Me.BotT5.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT5.ForeColor = System.Drawing.Color.White
        Me.BotT5.Location = New System.Drawing.Point(36, 272)
        Me.BotT5.Name = "BotT5"
        Me.BotT5.Size = New System.Drawing.Size(53, 25)
        Me.BotT5.TabIndex = 5
        Me.BotT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT4
        '
        Me.BotT4.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT4.ForeColor = System.Drawing.Color.White
        Me.BotT4.Location = New System.Drawing.Point(36, 224)
        Me.BotT4.Name = "BotT4"
        Me.BotT4.Size = New System.Drawing.Size(53, 25)
        Me.BotT4.TabIndex = 4
        Me.BotT4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT3
        '
        Me.BotT3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT3.ForeColor = System.Drawing.Color.White
        Me.BotT3.Location = New System.Drawing.Point(36, 181)
        Me.BotT3.Name = "BotT3"
        Me.BotT3.Size = New System.Drawing.Size(53, 25)
        Me.BotT3.TabIndex = 3
        Me.BotT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT2
        '
        Me.BotT2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT2.ForeColor = System.Drawing.Color.White
        Me.BotT2.Location = New System.Drawing.Point(36, 132)
        Me.BotT2.Name = "BotT2"
        Me.BotT2.Size = New System.Drawing.Size(53, 25)
        Me.BotT2.TabIndex = 2
        Me.BotT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT1
        '
        Me.BotT1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT1.ForeColor = System.Drawing.Color.White
        Me.BotT1.Location = New System.Drawing.Point(36, 83)
        Me.BotT1.Name = "BotT1"
        Me.BotT1.Size = New System.Drawing.Size(53, 25)
        Me.BotT1.TabIndex = 1
        Me.BotT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT0
        '
        Me.BotT0.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT0.ForeColor = System.Drawing.Color.White
        Me.BotT0.Location = New System.Drawing.Point(36, 39)
        Me.BotT0.Name = "BotT0"
        Me.BotT0.Size = New System.Drawing.Size(53, 25)
        Me.BotT0.TabIndex = 0
        Me.BotT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage9.Controls.Add(Me.Label49)
        Me.TabPage9.Controls.Add(Me.Label50)
        Me.TabPage9.Controls.Add(Me.bot11)
        Me.TabPage9.Controls.Add(Me.bot10)
        Me.TabPage9.Controls.Add(Me.bot9)
        Me.TabPage9.Controls.Add(Me.bot8)
        Me.TabPage9.Controls.Add(Me.bot7)
        Me.TabPage9.Controls.Add(Me.bot6)
        Me.TabPage9.Controls.Add(Me.BotN11)
        Me.TabPage9.Controls.Add(Me.BotN10)
        Me.TabPage9.Controls.Add(Me.BotN9)
        Me.TabPage9.Controls.Add(Me.BotN8)
        Me.TabPage9.Controls.Add(Me.BotN7)
        Me.TabPage9.Controls.Add(Me.BotN6)
        Me.TabPage9.Controls.Add(Me.BotT11)
        Me.TabPage9.Controls.Add(Me.BotT10)
        Me.TabPage9.Controls.Add(Me.BotT9)
        Me.TabPage9.Controls.Add(Me.BotT8)
        Me.TabPage9.Controls.Add(Me.BotT7)
        Me.TabPage9.Controls.Add(Me.BotT6)
        Me.TabPage9.Location = New System.Drawing.Point(4, 36)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(520, 315)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "Ennemies Bots"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(195, 15)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(49, 19)
        Me.Label49.TabIndex = 39
        Me.Label49.Text = "Name "
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(33, 15)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(56, 19)
        Me.Label50.TabIndex = 38
        Me.Label50.Text = "ClanTag"
        '
        'bot11
        '
        Me.bot11.AutoSize = True
        Me.bot11.ForeColor = System.Drawing.Color.White
        Me.bot11.Location = New System.Drawing.Point(317, 274)
        Me.bot11.Name = "bot11"
        Me.bot11.Size = New System.Drawing.Size(43, 19)
        Me.bot11.TabIndex = 37
        Me.bot11.Text = "name"
        '
        'bot10
        '
        Me.bot10.AutoSize = True
        Me.bot10.ForeColor = System.Drawing.Color.White
        Me.bot10.Location = New System.Drawing.Point(317, 228)
        Me.bot10.Name = "bot10"
        Me.bot10.Size = New System.Drawing.Size(43, 19)
        Me.bot10.TabIndex = 36
        Me.bot10.Text = "name"
        '
        'bot9
        '
        Me.bot9.AutoSize = True
        Me.bot9.ForeColor = System.Drawing.Color.White
        Me.bot9.Location = New System.Drawing.Point(317, 180)
        Me.bot9.Name = "bot9"
        Me.bot9.Size = New System.Drawing.Size(43, 19)
        Me.bot9.TabIndex = 35
        Me.bot9.Text = "name"
        '
        'bot8
        '
        Me.bot8.AutoSize = True
        Me.bot8.ForeColor = System.Drawing.Color.White
        Me.bot8.Location = New System.Drawing.Point(317, 131)
        Me.bot8.Name = "bot8"
        Me.bot8.Size = New System.Drawing.Size(43, 19)
        Me.bot8.TabIndex = 34
        Me.bot8.Text = "name"
        '
        'bot7
        '
        Me.bot7.AutoSize = True
        Me.bot7.ForeColor = System.Drawing.Color.White
        Me.bot7.Location = New System.Drawing.Point(317, 84)
        Me.bot7.Name = "bot7"
        Me.bot7.Size = New System.Drawing.Size(43, 19)
        Me.bot7.TabIndex = 33
        Me.bot7.Text = "name"
        '
        'bot6
        '
        Me.bot6.AutoSize = True
        Me.bot6.ForeColor = System.Drawing.Color.White
        Me.bot6.Location = New System.Drawing.Point(317, 40)
        Me.bot6.Name = "bot6"
        Me.bot6.Size = New System.Drawing.Size(43, 19)
        Me.bot6.TabIndex = 32
        Me.bot6.Text = "name"
        '
        'BotN11
        '
        Me.BotN11.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN11.ForeColor = System.Drawing.Color.White
        Me.BotN11.Location = New System.Drawing.Point(135, 270)
        Me.BotN11.Name = "BotN11"
        Me.BotN11.Size = New System.Drawing.Size(166, 25)
        Me.BotN11.TabIndex = 31
        Me.BotN11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN10
        '
        Me.BotN10.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN10.ForeColor = System.Drawing.Color.White
        Me.BotN10.Location = New System.Drawing.Point(135, 222)
        Me.BotN10.Name = "BotN10"
        Me.BotN10.Size = New System.Drawing.Size(166, 25)
        Me.BotN10.TabIndex = 30
        Me.BotN10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN9
        '
        Me.BotN9.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN9.ForeColor = System.Drawing.Color.White
        Me.BotN9.Location = New System.Drawing.Point(135, 177)
        Me.BotN9.Name = "BotN9"
        Me.BotN9.Size = New System.Drawing.Size(166, 25)
        Me.BotN9.TabIndex = 29
        Me.BotN9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN8
        '
        Me.BotN8.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN8.ForeColor = System.Drawing.Color.White
        Me.BotN8.Location = New System.Drawing.Point(135, 128)
        Me.BotN8.Name = "BotN8"
        Me.BotN8.Size = New System.Drawing.Size(166, 25)
        Me.BotN8.TabIndex = 28
        Me.BotN8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN7
        '
        Me.BotN7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN7.ForeColor = System.Drawing.Color.White
        Me.BotN7.Location = New System.Drawing.Point(135, 81)
        Me.BotN7.Name = "BotN7"
        Me.BotN7.Size = New System.Drawing.Size(166, 25)
        Me.BotN7.TabIndex = 27
        Me.BotN7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotN6
        '
        Me.BotN6.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotN6.ForeColor = System.Drawing.Color.White
        Me.BotN6.Location = New System.Drawing.Point(135, 35)
        Me.BotN6.Name = "BotN6"
        Me.BotN6.Size = New System.Drawing.Size(166, 25)
        Me.BotN6.TabIndex = 26
        Me.BotN6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT11
        '
        Me.BotT11.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT11.ForeColor = System.Drawing.Color.White
        Me.BotT11.Location = New System.Drawing.Point(37, 270)
        Me.BotT11.Name = "BotT11"
        Me.BotT11.Size = New System.Drawing.Size(53, 25)
        Me.BotT11.TabIndex = 25
        Me.BotT11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT10
        '
        Me.BotT10.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT10.ForeColor = System.Drawing.Color.White
        Me.BotT10.Location = New System.Drawing.Point(37, 222)
        Me.BotT10.Name = "BotT10"
        Me.BotT10.Size = New System.Drawing.Size(53, 25)
        Me.BotT10.TabIndex = 24
        Me.BotT10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT9
        '
        Me.BotT9.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT9.ForeColor = System.Drawing.Color.White
        Me.BotT9.Location = New System.Drawing.Point(36, 179)
        Me.BotT9.Name = "BotT9"
        Me.BotT9.Size = New System.Drawing.Size(53, 25)
        Me.BotT9.TabIndex = 23
        Me.BotT9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT8
        '
        Me.BotT8.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT8.ForeColor = System.Drawing.Color.White
        Me.BotT8.Location = New System.Drawing.Point(36, 130)
        Me.BotT8.Name = "BotT8"
        Me.BotT8.Size = New System.Drawing.Size(53, 25)
        Me.BotT8.TabIndex = 22
        Me.BotT8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT7
        '
        Me.BotT7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT7.ForeColor = System.Drawing.Color.White
        Me.BotT7.Location = New System.Drawing.Point(36, 81)
        Me.BotT7.Name = "BotT7"
        Me.BotT7.Size = New System.Drawing.Size(53, 25)
        Me.BotT7.TabIndex = 21
        Me.BotT7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotT6
        '
        Me.BotT6.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotT6.ForeColor = System.Drawing.Color.White
        Me.BotT6.Location = New System.Drawing.Point(36, 37)
        Me.BotT6.Name = "BotT6"
        Me.BotT6.Size = New System.Drawing.Size(53, 25)
        Me.BotT6.TabIndex = 20
        Me.BotT6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DSWM
        '
        Me.DSWM.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DSWM.BorderColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DSWM.Checked = False
        Me.DSWM.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.DSWM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DSWM.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DSWM.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DSWM.Location = New System.Drawing.Point(176, 6)
        Me.DSWM.Name = "DSWM"
        Me.DSWM.Size = New System.Drawing.Size(133, 22)
        Me.DSWM.TabIndex = 2
        Me.DSWM.Text = "Don't Show WM"
        '
        'SWM
        '
        Me.SWM.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SWM.BorderColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWM.Checked = True
        Me.SWM.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.SWM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SWM.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWM.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SWM.Location = New System.Drawing.Point(315, 6)
        Me.SWM.Name = "SWM"
        Me.SWM.Size = New System.Drawing.Size(102, 22)
        Me.SWM.TabIndex = 1
        Me.SWM.Text = "Show WM"
        '
        'Bot_Rennamer_on
        '
        Me.Bot_Rennamer_on.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Bot_Rennamer_on.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Bot_Rennamer_on.Checked = False
        Me.Bot_Rennamer_on.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Bot_Rennamer_on.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Rennamer_on.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bot_Rennamer_on.Location = New System.Drawing.Point(6, 6)
        Me.Bot_Rennamer_on.Name = "Bot_Rennamer_on"
        Me.Bot_Rennamer_on.Size = New System.Drawing.Size(157, 22)
        Me.Bot_Rennamer_on.TabIndex = 0
        Me.Bot_Rennamer_on.Text = "Enable Bot Rennamer"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage6.Controls.Add(Me.Weapons_on)
        Me.TabPage6.Controls.Add(Me.C_Secondary)
        Me.TabPage6.Controls.Add(Me.P_Primary)
        Me.TabPage6.Controls.Add(Me.camo_box)
        Me.TabPage6.Controls.Add(Me.Label70)
        Me.TabPage6.Controls.Add(Me.W_Secondary)
        Me.TabPage6.Controls.Add(Me.W_Primary)
        Me.TabPage6.Controls.Add(Me.weapon_choose)
        Me.TabPage6.Controls.Add(Me.Label67)
        Me.TabPage6.Location = New System.Drawing.Point(4, 36)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(536, 630)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Weapon"
        '
        'Weapons_on
        '
        Me.Weapons_on.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Weapons_on.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Weapons_on.Checked = False
        Me.Weapons_on.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Weapons_on.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Weapons_on.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Weapons_on.Location = New System.Drawing.Point(170, 6)
        Me.Weapons_on.Name = "Weapons_on"
        Me.Weapons_on.Size = New System.Drawing.Size(126, 22)
        Me.Weapons_on.TabIndex = 8
        Me.Weapons_on.Text = "Enable Weapons"
        '
        'C_Secondary
        '
        Me.C_Secondary.BackColor = System.Drawing.Color.Transparent
        Me.C_Secondary.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.C_Secondary.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.C_Secondary.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C_Secondary.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.C_Secondary.Location = New System.Drawing.Point(367, 113)
        Me.C_Secondary.Name = "C_Secondary"
        Me.C_Secondary.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.C_Secondary.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C_Secondary.Size = New System.Drawing.Size(76, 26)
        Me.C_Secondary.TabIndex = 7
        Me.C_Secondary.Text = "Secondary"
        '
        'P_Primary
        '
        Me.P_Primary.BackColor = System.Drawing.Color.Transparent
        Me.P_Primary.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.P_Primary.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.P_Primary.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P_Primary.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.P_Primary.Location = New System.Drawing.Point(285, 113)
        Me.P_Primary.Name = "P_Primary"
        Me.P_Primary.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.P_Primary.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P_Primary.Size = New System.Drawing.Size(76, 26)
        Me.P_Primary.TabIndex = 6
        Me.P_Primary.Text = "Primary"
        '
        'camo_box
        '
        Me.camo_box.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.camo_box.BackColor = System.Drawing.Color.Transparent
        Me.camo_box.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.camo_box.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.camo_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.camo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.camo_box.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.camo_box.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.camo_box.FormattingEnabled = True
        Me.camo_box.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.camo_box.Location = New System.Drawing.Point(107, 113)
        Me.camo_box.Name = "camo_box"
        Me.camo_box.Size = New System.Drawing.Size(163, 26)
        Me.camo_box.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.camo_box.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.camo_box.StartIndex = 0
        Me.camo_box.TabIndex = 5
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label70.Location = New System.Drawing.Point(35, 116)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(51, 19)
        Me.Label70.TabIndex = 4
        Me.Label70.Text = "Camos"
        '
        'W_Secondary
        '
        Me.W_Secondary.BackColor = System.Drawing.Color.Transparent
        Me.W_Secondary.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.W_Secondary.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.W_Secondary.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.W_Secondary.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.W_Secondary.Location = New System.Drawing.Point(367, 49)
        Me.W_Secondary.Name = "W_Secondary"
        Me.W_Secondary.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.W_Secondary.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.W_Secondary.Size = New System.Drawing.Size(76, 26)
        Me.W_Secondary.TabIndex = 3
        Me.W_Secondary.Text = "Secondary"
        '
        'W_Primary
        '
        Me.W_Primary.BackColor = System.Drawing.Color.Transparent
        Me.W_Primary.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.W_Primary.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.W_Primary.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.W_Primary.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.W_Primary.Location = New System.Drawing.Point(285, 49)
        Me.W_Primary.Name = "W_Primary"
        Me.W_Primary.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.W_Primary.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.W_Primary.Size = New System.Drawing.Size(76, 26)
        Me.W_Primary.TabIndex = 2
        Me.W_Primary.Text = "Primary"
        '
        'weapon_choose
        '
        Me.weapon_choose.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.weapon_choose.BackColor = System.Drawing.Color.Transparent
        Me.weapon_choose.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.weapon_choose.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.weapon_choose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.weapon_choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.weapon_choose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.weapon_choose.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.weapon_choose.FormattingEnabled = True
        Me.weapon_choose.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.weapon_choose.Location = New System.Drawing.Point(107, 49)
        Me.weapon_choose.Name = "weapon_choose"
        Me.weapon_choose.Size = New System.Drawing.Size(163, 26)
        Me.weapon_choose.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.weapon_choose.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.weapon_choose.StartIndex = 0
        Me.weapon_choose.TabIndex = 1
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label67.Location = New System.Drawing.Point(35, 52)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(63, 19)
        Me.Label67.TabIndex = 0
        Me.Label67.Text = "Weapon "
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage7.Controls.Add(Me.LogInGroupBox3)
        Me.TabPage7.Controls.Add(Me.LogInGroupBox2)
        Me.TabPage7.Location = New System.Drawing.Point(4, 36)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(536, 630)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Cheats"
        '
        'LogInGroupBox3
        '
        Me.LogInGroupBox3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox3.Controls.Add(Me.ANH)
        Me.LogInGroupBox3.Controls.Add(Me.player2)
        Me.LogInGroupBox3.Controls.Add(Me.player1)
        Me.LogInGroupBox3.Controls.Add(Me.Label75)
        Me.LogInGroupBox3.Controls.Add(Me.Label74)
        Me.LogInGroupBox3.Controls.Add(Me.Label73)
        Me.LogInGroupBox3.Controls.Add(Me.playerB)
        Me.LogInGroupBox3.Controls.Add(Me.playerG)
        Me.LogInGroupBox3.Controls.Add(Me.playerR)
        Me.LogInGroupBox3.Controls.Add(Me.greenplayer)
        Me.LogInGroupBox3.Controls.Add(Me.Recoil)
        Me.LogInGroupBox3.Controls.Add(Me.Uav)
        Me.LogInGroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox3.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox3.Location = New System.Drawing.Point(14, 231)
        Me.LogInGroupBox3.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox3.Name = "LogInGroupBox3"
        Me.LogInGroupBox3.Size = New System.Drawing.Size(506, 380)
        Me.LogInGroupBox3.TabIndex = 5
        Me.LogInGroupBox3.Text = "Non Host"
        Me.LogInGroupBox3.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'ANH
        '
        Me.ANH.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ANH.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ANH.Checked = False
        Me.ANH.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ANH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ANH.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ANH.Location = New System.Drawing.Point(93, 0)
        Me.ANH.Name = "ANH"
        Me.ANH.Size = New System.Drawing.Size(147, 22)
        Me.ANH.TabIndex = 7
        Me.ANH.Text = "Activate Non-Host "
        '
        'player2
        '
        Me.player2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.player2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.player2.Checked = False
        Me.player2.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.player2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.player2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.player2.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.player2.Location = New System.Drawing.Point(327, 171)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(115, 22)
        Me.player2.TabIndex = 10
        Me.player2.Text = "Alpha Mode"
        '
        'player1
        '
        Me.player1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.player1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.player1.Checked = False
        Me.player1.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.player1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.player1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.player1.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.player1.Location = New System.Drawing.Point(194, 171)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(115, 22)
        Me.player1.TabIndex = 9
        Me.player1.Text = "Normal Mode"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label75.ForeColor = System.Drawing.Color.White
        Me.Label75.Location = New System.Drawing.Point(37, 331)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(32, 15)
        Me.Label75.TabIndex = 8
        Me.Label75.Text = "Blue"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(37, 280)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(42, 15)
        Me.Label74.TabIndex = 7
        Me.Label74.Text = "Green"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(37, 234)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(29, 15)
        Me.Label73.TabIndex = 6
        Me.Label73.Text = "Red"
        '
        'playerB
        '
        Me.playerB.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.playerB.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.playerB.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.playerB.Location = New System.Drawing.Point(104, 323)
        Me.playerB.Maximum = 255
        Me.playerB.Name = "playerB"
        Me.playerB.Size = New System.Drawing.Size(389, 23)
        Me.playerB.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.playerB.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.playerB.TabIndex = 5
        Me.playerB.Text = "LogInTrackBar8"
        Me.playerB.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.playerB.Value = 0
        '
        'playerG
        '
        Me.playerG.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.playerG.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.playerG.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.playerG.Location = New System.Drawing.Point(104, 272)
        Me.playerG.Maximum = 255
        Me.playerG.Name = "playerG"
        Me.playerG.Size = New System.Drawing.Size(389, 23)
        Me.playerG.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.playerG.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.playerG.TabIndex = 4
        Me.playerG.Text = "LogInTrackBar7"
        Me.playerG.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.playerG.Value = 0
        '
        'playerR
        '
        Me.playerR.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.playerR.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.playerR.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.playerR.Location = New System.Drawing.Point(104, 226)
        Me.playerR.Maximum = 255
        Me.playerR.Name = "playerR"
        Me.playerR.Size = New System.Drawing.Size(389, 23)
        Me.playerR.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.playerR.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.playerR.TabIndex = 3
        Me.playerR.Text = "LogInTrackBar6"
        Me.playerR.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.playerR.Value = 0
        '
        'greenplayer
        '
        Me.greenplayer.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.greenplayer.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.greenplayer.Checked = False
        Me.greenplayer.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.greenplayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.greenplayer.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.greenplayer.Location = New System.Drawing.Point(57, 171)
        Me.greenplayer.Name = "greenplayer"
        Me.greenplayer.Size = New System.Drawing.Size(132, 22)
        Me.greenplayer.TabIndex = 2
        Me.greenplayer.Text = "Physical Chams "
        '
        'Recoil
        '
        Me.Recoil.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Recoil.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Recoil.Checked = False
        Me.Recoil.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Recoil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Recoil.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Recoil.Location = New System.Drawing.Point(40, 91)
        Me.Recoil.Name = "Recoil"
        Me.Recoil.Size = New System.Drawing.Size(101, 22)
        Me.Recoil.TabIndex = 1
        Me.Recoil.Text = "No Recoil "
        '
        'Uav
        '
        Me.Uav.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Uav.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Uav.Checked = False
        Me.Uav.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Uav.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Uav.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Uav.Location = New System.Drawing.Point(40, 63)
        Me.Uav.Name = "Uav"
        Me.Uav.Size = New System.Drawing.Size(76, 22)
        Me.Uav.TabIndex = 0
        Me.Uav.Text = " Vsat"
        '
        'LogInGroupBox2
        '
        Me.LogInGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox2.Controls.Add(Me.GroupBox10)
        Me.LogInGroupBox2.Controls.Add(Me.AHO)
        Me.LogInGroupBox2.Controls.Add(Me.AllPerks)
        Me.LogInGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox2.Location = New System.Drawing.Point(14, 21)
        Me.LogInGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox2.Name = "LogInGroupBox2"
        Me.LogInGroupBox2.Size = New System.Drawing.Size(506, 189)
        Me.LogInGroupBox2.TabIndex = 4
        Me.LogInGroupBox2.Text = "Host Only"
        Me.LogInGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.ReloadSpeed)
        Me.GroupBox10.Controls.Add(Me.RapideFire)
        Me.GroupBox10.Controls.Add(Me.Spread)
        Me.GroupBox10.Controls.Add(Me.AimSpeed)
        Me.GroupBox10.Location = New System.Drawing.Point(212, 41)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(156, 135)
        Me.GroupBox10.TabIndex = 7
        Me.GroupBox10.TabStop = False
        '
        'ReloadSpeed
        '
        Me.ReloadSpeed.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ReloadSpeed.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ReloadSpeed.Checked = False
        Me.ReloadSpeed.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ReloadSpeed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReloadSpeed.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReloadSpeed.Location = New System.Drawing.Point(18, 46)
        Me.ReloadSpeed.Name = "ReloadSpeed"
        Me.ReloadSpeed.Size = New System.Drawing.Size(117, 22)
        Me.ReloadSpeed.TabIndex = 1
        Me.ReloadSpeed.Text = "Reload Speed"
        '
        'RapideFire
        '
        Me.RapideFire.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.RapideFire.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.RapideFire.Checked = False
        Me.RapideFire.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.RapideFire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RapideFire.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RapideFire.Location = New System.Drawing.Point(18, 74)
        Me.RapideFire.Name = "RapideFire"
        Me.RapideFire.Size = New System.Drawing.Size(100, 22)
        Me.RapideFire.TabIndex = 3
        Me.RapideFire.Text = "Rapide Fire"
        '
        'Spread
        '
        Me.Spread.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Spread.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Spread.Checked = False
        Me.Spread.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Spread.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Spread.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Spread.Location = New System.Drawing.Point(18, 18)
        Me.Spread.Name = "Spread"
        Me.Spread.Size = New System.Drawing.Size(86, 22)
        Me.Spread.TabIndex = 0
        Me.Spread.Text = "Spread"
        '
        'AimSpeed
        '
        Me.AimSpeed.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.AimSpeed.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.AimSpeed.Checked = False
        Me.AimSpeed.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.AimSpeed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AimSpeed.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AimSpeed.Location = New System.Drawing.Point(18, 102)
        Me.AimSpeed.Name = "AimSpeed"
        Me.AimSpeed.Size = New System.Drawing.Size(100, 22)
        Me.AimSpeed.TabIndex = 5
        Me.AimSpeed.Text = "Aim Speed"
        '
        'AHO
        '
        Me.AHO.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.AHO.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.AHO.Checked = False
        Me.AHO.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.AHO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AHO.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AHO.Location = New System.Drawing.Point(93, 3)
        Me.AHO.Name = "AHO"
        Me.AHO.Size = New System.Drawing.Size(147, 22)
        Me.AHO.TabIndex = 6
        Me.AHO.Text = "Activate Host only"
        '
        'AllPerks
        '
        Me.AllPerks.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.AllPerks.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.AllPerks.Checked = False
        Me.AllPerks.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.AllPerks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AllPerks.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AllPerks.Location = New System.Drawing.Point(104, 100)
        Me.AllPerks.Name = "AllPerks"
        Me.AllPerks.Size = New System.Drawing.Size(100, 22)
        Me.AllPerks.TabIndex = 2
        Me.AllPerks.Text = "All Perks"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 800)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.LogInGroupBox1.PerformLayout()
        Me.MyTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.G.ResumeLayout(False)
        Me.G.PerformLayout()
        CType(Me.ennemies_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allies_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CG.ResumeLayout(False)
        Me.CG.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saturation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GunZ_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunY_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunX_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.SAO_Intensity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAO_Bias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.FFC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FFC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FFC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.bot_health, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.your_health, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.LogInGroupBox3.ResumeLayout(False)
        Me.LogInGroupBox3.PerformLayout()
        Me.LogInGroupBox2.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents LogInGroupBox1 As LogInGroupBox
    Friend WithEvents MyTabControl As LogInTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents mapName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents in_game As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Public_lbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PlayerNb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gameMode As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CG As GroupBox
    Friend WithEvents CFG_box As LogInComboBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Main_timer As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Private WithEvents lightnessColorSlider As Cyotek.Windows.Forms.LightnessColorSlider
    Private WithEvents colorWheel As Cyotek.Windows.Forms.ColorWheel
    Private WithEvents CM As Cyotek.Windows.Forms.ColorEditorManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FPS_Bar As LogInTrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Fov_Bar As LogInTrackBar
    Friend WithEvents FOVS_Bar As LogInTrackBar2
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GunZ_lbl As Label
    Friend WithEvents GunZ_Box As CheckBox
    Friend WithEvents GunZ_Bar As TrackBar
    Friend WithEvents GunY_lbl As Label
    Friend WithEvents GunY_Box As CheckBox
    Friend WithEvents GunY_Bar As TrackBar
    Friend WithEvents GunX_lbl As Label
    Friend WithEvents GunX_Box As CheckBox
    Friend WithEvents GunX_Bar As TrackBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Rank_txt As LogInUserTextBox
    Friend WithEvents Names_txt As LogInUserTextBox
    Friend WithEvents Icon_txt As LogInUserTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents temp As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents saturation As NumericUpDown
    Friend WithEvents cg_color_activate As LogInCheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents R_2d As CheckBox
    Friend WithEvents nochat As CheckBox
    Friend WithEvents R_Gun As CheckBox
    Friend WithEvents R_crosshair As CheckBox
    Friend WithEvents R_Rank As CheckBox
    Friend WithEvents R_Name As CheckBox
    Friend WithEvents mpghlink As LinkLabel
    Friend WithEvents Label15 As Label
    Friend WithEvents G As GroupBox
    Friend WithEvents Feed_ok As LogInCheckBox
    Friend WithEvents ennemies_pic As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ennemies_combo As LogInComboBox
    Friend WithEvents allies_pic As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Allies_combo As LogInComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GScom As LogInComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents nend As LogInTrackBar
    Friend WithEvents nstart As LogInTrackBar
    Friend WithEvents fstart As LogInTrackBar
    Friend WithEvents fend As LogInTrackBar
    Friend WithEvents nblur As LogInTrackBar
    Friend WithEvents fblur As LogInTrackBar
    Friend WithEvents DOF_On As LogInCheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents SAO_Radius As LogInTrackBar
    Friend WithEvents SAO_Scale As LogInTrackBar
    Friend WithEvents SAO_Intensity_On As LogInButton
    Friend WithEvents SAO_Bias_On As LogInButton
    Friend WithEvents SAO_Intensity As NumericUpDown
    Friend WithEvents SAO_Bias As NumericUpDown
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents SAO_enable As LogInCheckBox
    Friend WithEvents FFC3 As NumericUpDown
    Friend WithEvents FFC2 As NumericUpDown
    Friend WithEvents FFC1 As NumericUpDown
    Friend WithEvents FBC3 As NumericUpDown
    Friend WithEvents FBC2 As NumericUpDown
    Friend WithEvents FBC1 As NumericUpDown
    Friend WithEvents foggmzor As LogInComboBox
    Friend WithEvents GmzorzConfig As LogInCheckBox
    Friend WithEvents SyncColors As LogInCheckBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Private WithEvents LightnessColorSlider1 As Cyotek.Windows.Forms.LightnessColorSlider
    Private WithEvents ColorWheel1 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents fogFarExp As LogInTrackBar
    Friend WithEvents fogBaseExp As LogInTrackBar
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents fogBias As LogInTrackBar
    Friend WithEvents Label32 As Label
    Friend WithEvents fogHeight As LogInTrackBar3
    Friend WithEvents Label31 As Label
    Friend WithEvents fogDistance As LogInTrackBar3
    Friend WithEvents Label30 As Label
    Friend WithEvents fogStart As LogInTrackBar
    Friend WithEvents Label29 As Label
    Friend WithEvents Light_color_lbl As Label
    Friend WithEvents Label42 As Label
    Private WithEvents LightnessColorSlider2 As Cyotek.Windows.Forms.LightnessColorSlider
    Private WithEvents ColorWheel2 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents Sun_Y As LogInTrackBar
    Friend WithEvents Sun_X As LogInTrackBar
    Friend WithEvents Label41 As Label
    Friend WithEvents SkyR As LogInTrackBar
    Friend WithEvents Label40 As Label
    Friend WithEvents SkyB As LogInTrackBar
    Friend WithEvents Label39 As Label
    Friend WithEvents SkyT As LogInTrackBar
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents SkyTemp As LogInTrackBar3
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Enable_health As LogInCheckBox
    Friend WithEvents Label66 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents bot_health As NumericUpDown
    Friend WithEvents your_health As NumericUpDown
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Send_names As LogInButton
    Friend WithEvents Refresh_names As LogInButton
    Friend WithEvents LogInTabControl1 As LogInTabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents bot5 As Label
    Friend WithEvents bot4 As Label
    Friend WithEvents bot3 As Label
    Friend WithEvents bot2 As Label
    Friend WithEvents bot1 As Label
    Friend WithEvents bot0 As Label
    Friend WithEvents BotN5 As TextBox
    Friend WithEvents BotN4 As TextBox
    Friend WithEvents BotN3 As TextBox
    Friend WithEvents BotN2 As TextBox
    Friend WithEvents BotN1 As TextBox
    Friend WithEvents BotN0 As TextBox
    Friend WithEvents BotT5 As TextBox
    Friend WithEvents BotT4 As TextBox
    Friend WithEvents BotT3 As TextBox
    Friend WithEvents BotT2 As TextBox
    Friend WithEvents BotT1 As TextBox
    Friend WithEvents BotT0 As TextBox
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents DSWM As LogInRadioButton
    Friend WithEvents SWM As LogInRadioButton
    Friend WithEvents Bot_Rennamer_on As LogInCheckBox
    Friend WithEvents W_Secondary As LogInButton
    Friend WithEvents W_Primary As LogInButton
    Friend WithEvents weapon_choose As LogInComboBox
    Friend WithEvents Label67 As Label
    Private WithEvents CM2 As Cyotek.Windows.Forms.ColorEditorManager
    Friend WithEvents Fog_Timer As Timer
    Private WithEvents CM3 As Cyotek.Windows.Forms.ColorEditorManager
    Friend WithEvents Label69 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents C_Secondary As LogInButton
    Friend WithEvents P_Primary As LogInButton
    Friend WithEvents camo_box As LogInComboBox
    Friend WithEvents Label70 As Label
    Friend WithEvents Weapons_on As LogInCheckBox
    Friend WithEvents LogInGroupBox3 As LogInGroupBox
    Friend WithEvents player2 As LogInRadioButton
    Friend WithEvents player1 As LogInRadioButton
    Friend WithEvents Label75 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents playerB As LogInTrackBar
    Friend WithEvents playerG As LogInTrackBar
    Friend WithEvents playerR As LogInTrackBar
    Friend WithEvents greenplayer As LogInCheckBox
    Friend WithEvents Recoil As LogInCheckBox
    Friend WithEvents Uav As LogInCheckBox
    Friend WithEvents LogInGroupBox2 As LogInGroupBox
    Friend WithEvents AllPerks As LogInCheckBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents bot11 As Label
    Friend WithEvents bot10 As Label
    Friend WithEvents bot9 As Label
    Friend WithEvents bot8 As Label
    Friend WithEvents bot7 As Label
    Friend WithEvents bot6 As Label
    Friend WithEvents BotN11 As TextBox
    Friend WithEvents BotN10 As TextBox
    Friend WithEvents BotN9 As TextBox
    Friend WithEvents BotN8 As TextBox
    Friend WithEvents BotN7 As TextBox
    Friend WithEvents BotN6 As TextBox
    Friend WithEvents BotT11 As TextBox
    Friend WithEvents BotT10 As TextBox
    Friend WithEvents BotT9 As TextBox
    Friend WithEvents BotT8 As TextBox
    Friend WithEvents BotT7 As TextBox
    Friend WithEvents BotT6 As TextBox
    Friend WithEvents R_Player As CheckBox
    Friend WithEvents Theater_Timer As Timer
    Friend WithEvents Sun_Timer As Timer
    Friend WithEvents Bot_Rennamer_Timer As Timer
    Friend WithEvents GList As ImageList
    Friend WithEvents Gun_Timer As Timer
    Friend WithEvents ANH As LogInCheckBox
    Friend WithEvents AHO As LogInCheckBox
    Friend WithEvents C_Timer As Timer
    Friend WithEvents NC_Timer As Timer
    Friend WithEvents Info_button As LogInButton
    Friend WithEvents Load_button As LogInButton
    Friend WithEvents Save_button As LogInButton
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents ReloadSpeed As LogInCheckBox
    Friend WithEvents RapideFire As LogInCheckBox
    Friend WithEvents Spread As LogInCheckBox
    Friend WithEvents AimSpeed As LogInCheckBox
    Friend WithEvents ANRI As LogInCheckBox
End Class
