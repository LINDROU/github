<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zombie
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zombie))
        Me.Status_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Host_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Non_Host_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LogInThemeContainer1 = New Bo2_Compact_v2._0.LogInThemeContainer()
        Me.LogInTabControl1 = New Bo2_Compact_v2._0.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LogInLabel3 = New Bo2_Compact_v2._0.LogInLabel()
        Me.LogInComboBox1 = New Bo2_Compact_v2._0.LogInComboBox()
        Me.Player_tab = New Bo2_Compact_v2._0.LogInTabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TP_to_P4 = New Bo2_Compact_v2._0.LogInButton()
        Me.TP_to_P3 = New Bo2_Compact_v2._0.LogInButton()
        Me.TP_to_P2 = New Bo2_Compact_v2._0.LogInButton()
        Me.TP_P4 = New Bo2_Compact_v2._0.LogInButton()
        Me.TP_P3 = New Bo2_Compact_v2._0.LogInButton()
        Me.TP_P2 = New Bo2_Compact_v2._0.LogInButton()
        Me.P1_SW = New System.Windows.Forms.TextBox()
        Me.zm_P1_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P1_PW = New System.Windows.Forms.TextBox()
        Me.zm_P1_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.inf_ammo = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.P1_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.nb_round = New Bo2_Compact_v2._0.LogInButton()
        Me.inf_gre = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.round = New System.Windows.Forms.TextBox()
        Me.P1_Money = New System.Windows.Forms.TextBox()
        Me.zm_P1_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.P2_SW = New System.Windows.Forms.TextBox()
        Me.zm_P2_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P2_PW = New System.Windows.Forms.TextBox()
        Me.zm_P2_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.P2_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.P2_Money = New System.Windows.Forms.TextBox()
        Me.zm_P2_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.P3_SW = New System.Windows.Forms.TextBox()
        Me.zm_P3_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P3_PW = New System.Windows.Forms.TextBox()
        Me.zm_P3_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.P3_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.P3_Money = New System.Windows.Forms.TextBox()
        Me.zm_P3_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.P4_SW = New System.Windows.Forms.TextBox()
        Me.zm_P4_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P4_PW = New System.Windows.Forms.TextBox()
        Me.zm_P4_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.P4_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.P4_Money = New System.Windows.Forms.TextBox()
        Me.zm_P4_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.P5_SW = New System.Windows.Forms.TextBox()
        Me.zm_P5_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P5_PW = New System.Windows.Forms.TextBox()
        Me.zm_P5_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.P5_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.P5_Money = New System.Windows.Forms.TextBox()
        Me.zm_P5_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.P6_SW = New System.Windows.Forms.TextBox()
        Me.zm_P6_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P6_PW = New System.Windows.Forms.TextBox()
        Me.zm_P6_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.P6_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.P6_Money = New System.Windows.Forms.TextBox()
        Me.zm_P6_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.P7_SW = New System.Windows.Forms.TextBox()
        Me.zm_P7_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P7_PW = New System.Windows.Forms.TextBox()
        Me.zm_P7_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.P7_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.P7_Money = New System.Windows.Forms.TextBox()
        Me.zm_P7_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.P8_SW = New System.Windows.Forms.TextBox()
        Me.zm_P8_SW = New Bo2_Compact_v2._0.LogInButton()
        Me.P8_PW = New System.Windows.Forms.TextBox()
        Me.zm_P8_PW = New Bo2_Compact_v2._0.LogInButton()
        Me.P8_CW = New Bo2_Compact_v2._0.LogInLabel()
        Me.P8_Money = New System.Windows.Forms.TextBox()
        Me.zm_P8_Money = New Bo2_Compact_v2._0.LogInButton()
        Me.LogInGroupBox2 = New Bo2_Compact_v2._0.LogInGroupBox()
        Me.zm_lobby_size = New Bo2_Compact_v2._0.LogInButton()
        Me.Force_Host = New Bo2_Compact_v2._0.LogInCheckBox()
        Me.lobby_size = New Bo2_Compact_v2._0.LogInNumeric()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NR = New Bo2_Compact_v2._0.LogInCheckBox()
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
        Me.FOVS = New Bo2_Compact_v2._0.LogInTrackBar2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FOV = New Bo2_Compact_v2._0.LogInTrackBar()
        Me.LogInGroupBox1 = New Bo2_Compact_v2._0.LogInGroupBox()
        Me.ZombieRd = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ZombieHh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mapName = New System.Windows.Forms.Label()
        Me.in_game = New System.Windows.Forms.Label()
        Me.ZombieNB = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Player_tab.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.LogInGroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GunZ_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunY_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunX_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogInGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Status_Timer
        '
        Me.Status_Timer.Enabled = True
        '
        'Host_Timer
        '
        '
        'Non_Host_Timer
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Zombie Bo2 Compact 2.0 by LINDRA"
        Me.NotifyIcon1.Visible = True
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
        Me.LogInThemeContainer1.Controls.Add(Me.LogInTabControl1)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInGroupBox1)
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
        Me.LogInThemeContainer1.Text = "Zombie BO2 Compact v2.1 by LINDRA"
        '
        'LogInTabControl1
        '
        Me.LogInTabControl1.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInTabControl1.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInTabControl1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInTabControl1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInTabControl1.Controls.Add(Me.TabPage1)
        Me.LogInTabControl1.Controls.Add(Me.TabPage2)
        Me.LogInTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInTabControl1.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.LogInTabControl1.Location = New System.Drawing.Point(8, 166)
        Me.LogInTabControl1.Name = "LogInTabControl1"
        Me.LogInTabControl1.SelectedIndex = 0
        Me.LogInTabControl1.Size = New System.Drawing.Size(530, 585)
        Me.LogInTabControl1.TabIndex = 1
        Me.LogInTabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInTabControl1.UpLineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.LogInLabel3)
        Me.TabPage1.Controls.Add(Me.LogInComboBox1)
        Me.TabPage1.Controls.Add(Me.Player_tab)
        Me.TabPage1.Controls.Add(Me.LogInGroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 545)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Host Only"
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(97, 415)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(65, 15)
        Me.LogInLabel3.TabIndex = 13
        Me.LogInLabel3.Text = "Weapon ID"
        '
        'LogInComboBox1
        '
        Me.LogInComboBox1.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInComboBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInComboBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LogInComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LogInComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInComboBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInComboBox1.FormattingEnabled = True
        Me.LogInComboBox1.Items.AddRange(New Object() {"AK74U = 2", "MP5 = 3", "Chicom_CQB = 4;", "AK74FU2 = 5", "MP115_Kollider = 6", "Chicom_Cataclysmic_Quadruple_Burst = 7", "Olympia_Standard = 8", " M14 = 9", "Colt_M16A1 = 10", "SMR = 11", "M8A1 = 12", "Type_25 = 13", "MTAR = 14", "Mnesia = 15", "Skullcrusher = 16", "SM1L3R = 18", "Micro_Aerator = 20", "Strain_25 = 22", "Malevolent_Taxonomic_Anodized_Redeemer = 24", "S12 = 28", "M1216 = 29", "Refitted_870_Mechanical_Cranium_Sequencer = 30", "Hades = 31", "Synthetic_Dozen = 32", "Mesmerizer = 33", "Galil = 34", "FAL = 35", "RPD = 36", "HAMR = 37", "Lamentation = 38", "WN = 39", "Relativicstic_Punishment_Devize = 40", "SLDG_HAMR = 41", "DSR_50 = 42", "Barret_M82A1 = 43", "Dead_Specimen_Reactor_5000 = 44", "Macro_Annihilator = 45", "M1911 = 47", "Python = 48", "Executioner = 49", "KAP_40 = 50", "Five_Seven = 51", "B23R = 52", "Knife = 54", "Cobra = 57", "Voice_of_Justice = 58", "Karmic_Atom_Perforator_4000 = 59", "Ultra = 60", "B34R = 61", "RPG = 64", "War_Machine = 65", "Rocket_Propelled_Grievance = 66", "Dystopic_Demolisher = 67", "Ray_Gun = 68", "Ballistic_Knife = 72", "The_Krauss_Refribrillator = 73", "Ballistic_Knife_DifferentSkin = 74", "The_Krauss_Refribrillator_DifferentSkin = 75", "Ray_Gun_MKII = 76", "Porters_MKII_Ray_Gun = 77", "Porters_XII_Ray_Gun = 78"})
        Me.LogInComboBox1.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInComboBox1.Location = New System.Drawing.Point(167, 410)
        Me.LogInComboBox1.Name = "LogInComboBox1"
        Me.LogInComboBox1.Size = New System.Drawing.Size(251, 26)
        Me.LogInComboBox1.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInComboBox1.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInComboBox1.StartIndex = 0
        Me.LogInComboBox1.TabIndex = 12
        '
        'Player_tab
        '
        Me.Player_tab.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Player_tab.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Player_tab.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Player_tab.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Player_tab.Controls.Add(Me.TabPage3)
        Me.Player_tab.Controls.Add(Me.TabPage4)
        Me.Player_tab.Controls.Add(Me.TabPage5)
        Me.Player_tab.Controls.Add(Me.TabPage6)
        Me.Player_tab.Controls.Add(Me.TabPage7)
        Me.Player_tab.Controls.Add(Me.TabPage8)
        Me.Player_tab.Controls.Add(Me.TabPage9)
        Me.Player_tab.Controls.Add(Me.TabPage10)
        Me.Player_tab.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Player_tab.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Player_tab.ItemSize = New System.Drawing.Size(240, 32)
        Me.Player_tab.Location = New System.Drawing.Point(10, 132)
        Me.Player_tab.Name = "Player_tab"
        Me.Player_tab.SelectedIndex = 0
        Me.Player_tab.Size = New System.Drawing.Size(504, 239)
        Me.Player_tab.TabIndex = 11
        Me.Player_tab.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Player_tab.UpLineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.TP_to_P4)
        Me.TabPage3.Controls.Add(Me.TP_to_P3)
        Me.TabPage3.Controls.Add(Me.TP_to_P2)
        Me.TabPage3.Controls.Add(Me.TP_P4)
        Me.TabPage3.Controls.Add(Me.TP_P3)
        Me.TabPage3.Controls.Add(Me.TP_P2)
        Me.TabPage3.Controls.Add(Me.P1_SW)
        Me.TabPage3.Controls.Add(Me.zm_P1_SW)
        Me.TabPage3.Controls.Add(Me.P1_PW)
        Me.TabPage3.Controls.Add(Me.zm_P1_PW)
        Me.TabPage3.Controls.Add(Me.inf_ammo)
        Me.TabPage3.Controls.Add(Me.P1_CW)
        Me.TabPage3.Controls.Add(Me.nb_round)
        Me.TabPage3.Controls.Add(Me.inf_gre)
        Me.TabPage3.Controls.Add(Me.round)
        Me.TabPage3.Controls.Add(Me.P1_Money)
        Me.TabPage3.Controls.Add(Me.zm_P1_Money)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(496, 199)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Yourself"
        '
        'TP_to_P4
        '
        Me.TP_to_P4.BackColor = System.Drawing.Color.Transparent
        Me.TP_to_P4.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TP_to_P4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TP_to_P4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_to_P4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TP_to_P4.Location = New System.Drawing.Point(133, 161)
        Me.TP_to_P4.Name = "TP_to_P4"
        Me.TP_to_P4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TP_to_P4.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_to_P4.Size = New System.Drawing.Size(84, 30)
        Me.TP_to_P4.TabIndex = 20
        Me.TP_to_P4.Text = "TP to Player 4"
        '
        'TP_to_P3
        '
        Me.TP_to_P3.BackColor = System.Drawing.Color.Transparent
        Me.TP_to_P3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TP_to_P3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TP_to_P3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_to_P3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TP_to_P3.Location = New System.Drawing.Point(133, 126)
        Me.TP_to_P3.Name = "TP_to_P3"
        Me.TP_to_P3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TP_to_P3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_to_P3.Size = New System.Drawing.Size(84, 30)
        Me.TP_to_P3.TabIndex = 19
        Me.TP_to_P3.Text = "TP to Player 3"
        '
        'TP_to_P2
        '
        Me.TP_to_P2.BackColor = System.Drawing.Color.Transparent
        Me.TP_to_P2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TP_to_P2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TP_to_P2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_to_P2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TP_to_P2.Location = New System.Drawing.Point(133, 90)
        Me.TP_to_P2.Name = "TP_to_P2"
        Me.TP_to_P2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TP_to_P2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_to_P2.Size = New System.Drawing.Size(84, 30)
        Me.TP_to_P2.TabIndex = 18
        Me.TP_to_P2.Text = "TP to Player 2"
        '
        'TP_P4
        '
        Me.TP_P4.BackColor = System.Drawing.Color.Transparent
        Me.TP_P4.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TP_P4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TP_P4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_P4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TP_P4.Location = New System.Drawing.Point(36, 161)
        Me.TP_P4.Name = "TP_P4"
        Me.TP_P4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TP_P4.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_P4.Size = New System.Drawing.Size(75, 30)
        Me.TP_P4.TabIndex = 17
        Me.TP_P4.Text = "TP Player 4"
        '
        'TP_P3
        '
        Me.TP_P3.BackColor = System.Drawing.Color.Transparent
        Me.TP_P3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TP_P3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TP_P3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_P3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TP_P3.Location = New System.Drawing.Point(36, 126)
        Me.TP_P3.Name = "TP_P3"
        Me.TP_P3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TP_P3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_P3.Size = New System.Drawing.Size(75, 30)
        Me.TP_P3.TabIndex = 16
        Me.TP_P3.Text = "TP Player 3"
        '
        'TP_P2
        '
        Me.TP_P2.BackColor = System.Drawing.Color.Transparent
        Me.TP_P2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TP_P2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TP_P2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_P2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TP_P2.Location = New System.Drawing.Point(36, 90)
        Me.TP_P2.Name = "TP_P2"
        Me.TP_P2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TP_P2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP_P2.Size = New System.Drawing.Size(75, 30)
        Me.TP_P2.TabIndex = 15
        Me.TP_P2.Text = "TP Player 2"
        '
        'P1_SW
        '
        Me.P1_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P1_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P1_SW.Location = New System.Drawing.Point(291, 151)
        Me.P1_SW.Name = "P1_SW"
        Me.P1_SW.Size = New System.Drawing.Size(70, 25)
        Me.P1_SW.TabIndex = 14
        Me.P1_SW.Text = "78"
        Me.P1_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P1_SW
        '
        Me.zm_P1_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P1_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P1_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P1_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P1_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P1_SW.Location = New System.Drawing.Point(367, 151)
        Me.zm_P1_SW.Name = "zm_P1_SW"
        Me.zm_P1_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P1_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P1_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P1_SW.TabIndex = 13
        Me.zm_P1_SW.Text = "Secondary Weapon"
        '
        'P1_PW
        '
        Me.P1_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P1_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P1_PW.Location = New System.Drawing.Point(291, 120)
        Me.P1_PW.Name = "P1_PW"
        Me.P1_PW.Size = New System.Drawing.Size(70, 25)
        Me.P1_PW.TabIndex = 12
        Me.P1_PW.Text = "78"
        Me.P1_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P1_PW
        '
        Me.zm_P1_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P1_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P1_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P1_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P1_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P1_PW.Location = New System.Drawing.Point(367, 120)
        Me.zm_P1_PW.Name = "zm_P1_PW"
        Me.zm_P1_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P1_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P1_PW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P1_PW.TabIndex = 11
        Me.zm_P1_PW.Text = "Primary Weapon"
        '
        'inf_ammo
        '
        Me.inf_ammo.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.inf_ammo.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.inf_ammo.Checked = False
        Me.inf_ammo.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.inf_ammo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inf_ammo.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inf_ammo.Location = New System.Drawing.Point(18, 17)
        Me.inf_ammo.Name = "inf_ammo"
        Me.inf_ammo.Size = New System.Drawing.Size(124, 22)
        Me.inf_ammo.TabIndex = 4
        Me.inf_ammo.Text = "Infinit Ammo"
        '
        'P1_CW
        '
        Me.P1_CW.AutoSize = True
        Me.P1_CW.BackColor = System.Drawing.Color.Transparent
        Me.P1_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P1_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P1_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P1_CW.Location = New System.Drawing.Point(288, 90)
        Me.P1_CW.Name = "P1_CW"
        Me.P1_CW.Size = New System.Drawing.Size(127, 15)
        Me.P1_CW.TabIndex = 10
        Me.P1_CW.Text = "Current Weapon ID -> "
        '
        'nb_round
        '
        Me.nb_round.BackColor = System.Drawing.Color.Transparent
        Me.nb_round.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.nb_round.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.nb_round.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nb_round.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.nb_round.Location = New System.Drawing.Point(376, 14)
        Me.nb_round.Name = "nb_round"
        Me.nb_round.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.nb_round.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nb_round.Size = New System.Drawing.Size(105, 25)
        Me.nb_round.TabIndex = 5
        Me.nb_round.Text = "Number of round "
        '
        'inf_gre
        '
        Me.inf_gre.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.inf_gre.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.inf_gre.Checked = False
        Me.inf_gre.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.inf_gre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inf_gre.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inf_gre.Location = New System.Drawing.Point(20, 45)
        Me.inf_gre.Name = "inf_gre"
        Me.inf_gre.Size = New System.Drawing.Size(122, 22)
        Me.inf_gre.TabIndex = 9
        Me.inf_gre.Text = "Infinit Grenades"
        '
        'round
        '
        Me.round.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.round.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.round.Location = New System.Drawing.Point(288, 14)
        Me.round.Name = "round"
        Me.round.Size = New System.Drawing.Size(70, 25)
        Me.round.TabIndex = 6
        Me.round.Text = "1"
        Me.round.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P1_Money
        '
        Me.P1_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P1_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P1_Money.Location = New System.Drawing.Point(288, 45)
        Me.P1_Money.Name = "P1_Money"
        Me.P1_Money.Size = New System.Drawing.Size(70, 25)
        Me.P1_Money.TabIndex = 8
        Me.P1_Money.Text = "800"
        Me.P1_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P1_Money
        '
        Me.zm_P1_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P1_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P1_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P1_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P1_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P1_Money.Location = New System.Drawing.Point(376, 45)
        Me.zm_P1_Money.Name = "zm_P1_Money"
        Me.zm_P1_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P1_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P1_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P1_Money.TabIndex = 7
        Me.zm_P1_Money.Text = "Your Money"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.P2_SW)
        Me.TabPage4.Controls.Add(Me.zm_P2_SW)
        Me.TabPage4.Controls.Add(Me.P2_PW)
        Me.TabPage4.Controls.Add(Me.zm_P2_PW)
        Me.TabPage4.Controls.Add(Me.P2_CW)
        Me.TabPage4.Controls.Add(Me.P2_Money)
        Me.TabPage4.Controls.Add(Me.zm_P2_Money)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(496, 199)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Player2"
        '
        'P2_SW
        '
        Me.P2_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P2_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P2_SW.Location = New System.Drawing.Point(266, 137)
        Me.P2_SW.Name = "P2_SW"
        Me.P2_SW.Size = New System.Drawing.Size(70, 25)
        Me.P2_SW.TabIndex = 32
        Me.P2_SW.Text = "78"
        Me.P2_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P2_SW
        '
        Me.zm_P2_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P2_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P2_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P2_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P2_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P2_SW.Location = New System.Drawing.Point(345, 137)
        Me.zm_P2_SW.Name = "zm_P2_SW"
        Me.zm_P2_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P2_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P2_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P2_SW.TabIndex = 31
        Me.zm_P2_SW.Text = "Secondary Weapon"
        '
        'P2_PW
        '
        Me.P2_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P2_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P2_PW.Location = New System.Drawing.Point(34, 137)
        Me.P2_PW.Name = "P2_PW"
        Me.P2_PW.Size = New System.Drawing.Size(70, 25)
        Me.P2_PW.TabIndex = 30
        Me.P2_PW.Text = "78"
        Me.P2_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P2_PW
        '
        Me.zm_P2_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P2_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P2_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P2_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P2_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P2_PW.Location = New System.Drawing.Point(113, 137)
        Me.zm_P2_PW.Name = "zm_P2_PW"
        Me.zm_P2_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P2_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P2_PW.Size = New System.Drawing.Size(99, 25)
        Me.zm_P2_PW.TabIndex = 29
        Me.zm_P2_PW.Text = "Primary Weapon"
        '
        'P2_CW
        '
        Me.P2_CW.AutoSize = True
        Me.P2_CW.BackColor = System.Drawing.Color.Transparent
        Me.P2_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P2_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P2_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P2_CW.Location = New System.Drawing.Point(96, 86)
        Me.P2_CW.Name = "P2_CW"
        Me.P2_CW.Size = New System.Drawing.Size(162, 15)
        Me.P2_CW.TabIndex = 28
        Me.P2_CW.Text = "Player Current Weapon ID -> "
        '
        'P2_Money
        '
        Me.P2_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P2_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P2_Money.Location = New System.Drawing.Point(154, 34)
        Me.P2_Money.Name = "P2_Money"
        Me.P2_Money.Size = New System.Drawing.Size(70, 25)
        Me.P2_Money.TabIndex = 27
        Me.P2_Money.Text = "800"
        Me.P2_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P2_Money
        '
        Me.zm_P2_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P2_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P2_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P2_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P2_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P2_Money.Location = New System.Drawing.Point(242, 34)
        Me.zm_P2_Money.Name = "zm_P2_Money"
        Me.zm_P2_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P2_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P2_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P2_Money.TabIndex = 26
        Me.zm_P2_Money.Text = "Player Money"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage5.Controls.Add(Me.P3_SW)
        Me.TabPage5.Controls.Add(Me.zm_P3_SW)
        Me.TabPage5.Controls.Add(Me.P3_PW)
        Me.TabPage5.Controls.Add(Me.zm_P3_PW)
        Me.TabPage5.Controls.Add(Me.P3_CW)
        Me.TabPage5.Controls.Add(Me.P3_Money)
        Me.TabPage5.Controls.Add(Me.zm_P3_Money)
        Me.TabPage5.Location = New System.Drawing.Point(4, 36)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(496, 199)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Player3"
        '
        'P3_SW
        '
        Me.P3_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P3_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P3_SW.Location = New System.Drawing.Point(266, 137)
        Me.P3_SW.Name = "P3_SW"
        Me.P3_SW.Size = New System.Drawing.Size(70, 25)
        Me.P3_SW.TabIndex = 32
        Me.P3_SW.Text = "78"
        Me.P3_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P3_SW
        '
        Me.zm_P3_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P3_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P3_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P3_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P3_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P3_SW.Location = New System.Drawing.Point(345, 137)
        Me.zm_P3_SW.Name = "zm_P3_SW"
        Me.zm_P3_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P3_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P3_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P3_SW.TabIndex = 31
        Me.zm_P3_SW.Text = "Secondary Weapon"
        '
        'P3_PW
        '
        Me.P3_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P3_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P3_PW.Location = New System.Drawing.Point(34, 137)
        Me.P3_PW.Name = "P3_PW"
        Me.P3_PW.Size = New System.Drawing.Size(70, 25)
        Me.P3_PW.TabIndex = 30
        Me.P3_PW.Text = "78"
        Me.P3_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P3_PW
        '
        Me.zm_P3_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P3_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P3_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P3_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P3_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P3_PW.Location = New System.Drawing.Point(113, 137)
        Me.zm_P3_PW.Name = "zm_P3_PW"
        Me.zm_P3_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P3_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P3_PW.Size = New System.Drawing.Size(99, 25)
        Me.zm_P3_PW.TabIndex = 29
        Me.zm_P3_PW.Text = "Primary Weapon"
        '
        'P3_CW
        '
        Me.P3_CW.AutoSize = True
        Me.P3_CW.BackColor = System.Drawing.Color.Transparent
        Me.P3_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P3_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P3_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P3_CW.Location = New System.Drawing.Point(96, 86)
        Me.P3_CW.Name = "P3_CW"
        Me.P3_CW.Size = New System.Drawing.Size(162, 15)
        Me.P3_CW.TabIndex = 28
        Me.P3_CW.Text = "Player Current Weapon ID -> "
        '
        'P3_Money
        '
        Me.P3_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P3_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P3_Money.Location = New System.Drawing.Point(154, 34)
        Me.P3_Money.Name = "P3_Money"
        Me.P3_Money.Size = New System.Drawing.Size(70, 25)
        Me.P3_Money.TabIndex = 27
        Me.P3_Money.Text = "800"
        Me.P3_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P3_Money
        '
        Me.zm_P3_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P3_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P3_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P3_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P3_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P3_Money.Location = New System.Drawing.Point(242, 34)
        Me.zm_P3_Money.Name = "zm_P3_Money"
        Me.zm_P3_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P3_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P3_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P3_Money.TabIndex = 26
        Me.zm_P3_Money.Text = "Player Money"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage6.Controls.Add(Me.P4_SW)
        Me.TabPage6.Controls.Add(Me.zm_P4_SW)
        Me.TabPage6.Controls.Add(Me.P4_PW)
        Me.TabPage6.Controls.Add(Me.zm_P4_PW)
        Me.TabPage6.Controls.Add(Me.P4_CW)
        Me.TabPage6.Controls.Add(Me.P4_Money)
        Me.TabPage6.Controls.Add(Me.zm_P4_Money)
        Me.TabPage6.Location = New System.Drawing.Point(4, 36)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(496, 199)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Player4"
        '
        'P4_SW
        '
        Me.P4_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P4_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P4_SW.Location = New System.Drawing.Point(266, 137)
        Me.P4_SW.Name = "P4_SW"
        Me.P4_SW.Size = New System.Drawing.Size(70, 25)
        Me.P4_SW.TabIndex = 32
        Me.P4_SW.Text = "78"
        Me.P4_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P4_SW
        '
        Me.zm_P4_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P4_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P4_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P4_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P4_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P4_SW.Location = New System.Drawing.Point(345, 137)
        Me.zm_P4_SW.Name = "zm_P4_SW"
        Me.zm_P4_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P4_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P4_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P4_SW.TabIndex = 31
        Me.zm_P4_SW.Text = "Secondary Weapon"
        '
        'P4_PW
        '
        Me.P4_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P4_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P4_PW.Location = New System.Drawing.Point(34, 137)
        Me.P4_PW.Name = "P4_PW"
        Me.P4_PW.Size = New System.Drawing.Size(70, 25)
        Me.P4_PW.TabIndex = 30
        Me.P4_PW.Text = "78"
        Me.P4_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P4_PW
        '
        Me.zm_P4_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P4_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P4_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P4_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P4_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P4_PW.Location = New System.Drawing.Point(113, 137)
        Me.zm_P4_PW.Name = "zm_P4_PW"
        Me.zm_P4_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P4_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P4_PW.Size = New System.Drawing.Size(99, 25)
        Me.zm_P4_PW.TabIndex = 29
        Me.zm_P4_PW.Text = "Primary Weapon"
        '
        'P4_CW
        '
        Me.P4_CW.AutoSize = True
        Me.P4_CW.BackColor = System.Drawing.Color.Transparent
        Me.P4_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P4_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P4_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P4_CW.Location = New System.Drawing.Point(96, 86)
        Me.P4_CW.Name = "P4_CW"
        Me.P4_CW.Size = New System.Drawing.Size(162, 15)
        Me.P4_CW.TabIndex = 28
        Me.P4_CW.Text = "Player Current Weapon ID -> "
        '
        'P4_Money
        '
        Me.P4_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P4_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P4_Money.Location = New System.Drawing.Point(154, 34)
        Me.P4_Money.Name = "P4_Money"
        Me.P4_Money.Size = New System.Drawing.Size(70, 25)
        Me.P4_Money.TabIndex = 27
        Me.P4_Money.Text = "800"
        Me.P4_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P4_Money
        '
        Me.zm_P4_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P4_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P4_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P4_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P4_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P4_Money.Location = New System.Drawing.Point(242, 34)
        Me.zm_P4_Money.Name = "zm_P4_Money"
        Me.zm_P4_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P4_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P4_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P4_Money.TabIndex = 26
        Me.zm_P4_Money.Text = "Player Money"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage7.Controls.Add(Me.P5_SW)
        Me.TabPage7.Controls.Add(Me.zm_P5_SW)
        Me.TabPage7.Controls.Add(Me.P5_PW)
        Me.TabPage7.Controls.Add(Me.zm_P5_PW)
        Me.TabPage7.Controls.Add(Me.P5_CW)
        Me.TabPage7.Controls.Add(Me.P5_Money)
        Me.TabPage7.Controls.Add(Me.zm_P5_Money)
        Me.TabPage7.Location = New System.Drawing.Point(4, 36)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(496, 199)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Player5"
        '
        'P5_SW
        '
        Me.P5_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P5_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P5_SW.Location = New System.Drawing.Point(266, 137)
        Me.P5_SW.Name = "P5_SW"
        Me.P5_SW.Size = New System.Drawing.Size(70, 25)
        Me.P5_SW.TabIndex = 32
        Me.P5_SW.Text = "78"
        Me.P5_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P5_SW
        '
        Me.zm_P5_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P5_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P5_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P5_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P5_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P5_SW.Location = New System.Drawing.Point(345, 137)
        Me.zm_P5_SW.Name = "zm_P5_SW"
        Me.zm_P5_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P5_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P5_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P5_SW.TabIndex = 31
        Me.zm_P5_SW.Text = "Secondary Weapon"
        '
        'P5_PW
        '
        Me.P5_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P5_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P5_PW.Location = New System.Drawing.Point(34, 137)
        Me.P5_PW.Name = "P5_PW"
        Me.P5_PW.Size = New System.Drawing.Size(70, 25)
        Me.P5_PW.TabIndex = 30
        Me.P5_PW.Text = "78"
        Me.P5_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P5_PW
        '
        Me.zm_P5_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P5_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P5_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P5_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P5_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P5_PW.Location = New System.Drawing.Point(113, 137)
        Me.zm_P5_PW.Name = "zm_P5_PW"
        Me.zm_P5_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P5_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P5_PW.Size = New System.Drawing.Size(99, 25)
        Me.zm_P5_PW.TabIndex = 29
        Me.zm_P5_PW.Text = "Primary Weapon"
        '
        'P5_CW
        '
        Me.P5_CW.AutoSize = True
        Me.P5_CW.BackColor = System.Drawing.Color.Transparent
        Me.P5_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P5_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P5_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P5_CW.Location = New System.Drawing.Point(96, 86)
        Me.P5_CW.Name = "P5_CW"
        Me.P5_CW.Size = New System.Drawing.Size(162, 15)
        Me.P5_CW.TabIndex = 28
        Me.P5_CW.Text = "Player Current Weapon ID -> "
        '
        'P5_Money
        '
        Me.P5_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P5_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P5_Money.Location = New System.Drawing.Point(154, 34)
        Me.P5_Money.Name = "P5_Money"
        Me.P5_Money.Size = New System.Drawing.Size(70, 25)
        Me.P5_Money.TabIndex = 27
        Me.P5_Money.Text = "800"
        Me.P5_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P5_Money
        '
        Me.zm_P5_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P5_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P5_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P5_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P5_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P5_Money.Location = New System.Drawing.Point(242, 34)
        Me.zm_P5_Money.Name = "zm_P5_Money"
        Me.zm_P5_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P5_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P5_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P5_Money.TabIndex = 26
        Me.zm_P5_Money.Text = "Player Money"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage8.Controls.Add(Me.P6_SW)
        Me.TabPage8.Controls.Add(Me.zm_P6_SW)
        Me.TabPage8.Controls.Add(Me.P6_PW)
        Me.TabPage8.Controls.Add(Me.zm_P6_PW)
        Me.TabPage8.Controls.Add(Me.P6_CW)
        Me.TabPage8.Controls.Add(Me.P6_Money)
        Me.TabPage8.Controls.Add(Me.zm_P6_Money)
        Me.TabPage8.Location = New System.Drawing.Point(4, 36)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(496, 199)
        Me.TabPage8.TabIndex = 5
        Me.TabPage8.Text = "Player6"
        '
        'P6_SW
        '
        Me.P6_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P6_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P6_SW.Location = New System.Drawing.Point(266, 137)
        Me.P6_SW.Name = "P6_SW"
        Me.P6_SW.Size = New System.Drawing.Size(70, 25)
        Me.P6_SW.TabIndex = 32
        Me.P6_SW.Text = "78"
        Me.P6_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P6_SW
        '
        Me.zm_P6_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P6_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P6_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P6_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P6_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P6_SW.Location = New System.Drawing.Point(345, 137)
        Me.zm_P6_SW.Name = "zm_P6_SW"
        Me.zm_P6_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P6_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P6_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P6_SW.TabIndex = 31
        Me.zm_P6_SW.Text = "Secondary Weapon"
        '
        'P6_PW
        '
        Me.P6_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P6_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P6_PW.Location = New System.Drawing.Point(34, 137)
        Me.P6_PW.Name = "P6_PW"
        Me.P6_PW.Size = New System.Drawing.Size(70, 25)
        Me.P6_PW.TabIndex = 30
        Me.P6_PW.Text = "78"
        Me.P6_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P6_PW
        '
        Me.zm_P6_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P6_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P6_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P6_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P6_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P6_PW.Location = New System.Drawing.Point(113, 137)
        Me.zm_P6_PW.Name = "zm_P6_PW"
        Me.zm_P6_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P6_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P6_PW.Size = New System.Drawing.Size(99, 25)
        Me.zm_P6_PW.TabIndex = 29
        Me.zm_P6_PW.Text = "Primary Weapon"
        '
        'P6_CW
        '
        Me.P6_CW.AutoSize = True
        Me.P6_CW.BackColor = System.Drawing.Color.Transparent
        Me.P6_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P6_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P6_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P6_CW.Location = New System.Drawing.Point(96, 86)
        Me.P6_CW.Name = "P6_CW"
        Me.P6_CW.Size = New System.Drawing.Size(162, 15)
        Me.P6_CW.TabIndex = 28
        Me.P6_CW.Text = "Player Current Weapon ID -> "
        '
        'P6_Money
        '
        Me.P6_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P6_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P6_Money.Location = New System.Drawing.Point(154, 34)
        Me.P6_Money.Name = "P6_Money"
        Me.P6_Money.Size = New System.Drawing.Size(70, 25)
        Me.P6_Money.TabIndex = 27
        Me.P6_Money.Text = "800"
        Me.P6_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P6_Money
        '
        Me.zm_P6_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P6_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P6_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P6_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P6_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P6_Money.Location = New System.Drawing.Point(242, 34)
        Me.zm_P6_Money.Name = "zm_P6_Money"
        Me.zm_P6_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P6_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P6_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P6_Money.TabIndex = 26
        Me.zm_P6_Money.Text = "Player Money"
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage9.Controls.Add(Me.P7_SW)
        Me.TabPage9.Controls.Add(Me.zm_P7_SW)
        Me.TabPage9.Controls.Add(Me.P7_PW)
        Me.TabPage9.Controls.Add(Me.zm_P7_PW)
        Me.TabPage9.Controls.Add(Me.P7_CW)
        Me.TabPage9.Controls.Add(Me.P7_Money)
        Me.TabPage9.Controls.Add(Me.zm_P7_Money)
        Me.TabPage9.Location = New System.Drawing.Point(4, 36)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(496, 199)
        Me.TabPage9.TabIndex = 6
        Me.TabPage9.Text = "Player7"
        '
        'P7_SW
        '
        Me.P7_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P7_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P7_SW.Location = New System.Drawing.Point(266, 137)
        Me.P7_SW.Name = "P7_SW"
        Me.P7_SW.Size = New System.Drawing.Size(70, 25)
        Me.P7_SW.TabIndex = 32
        Me.P7_SW.Text = "78"
        Me.P7_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P7_SW
        '
        Me.zm_P7_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P7_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P7_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P7_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P7_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P7_SW.Location = New System.Drawing.Point(345, 137)
        Me.zm_P7_SW.Name = "zm_P7_SW"
        Me.zm_P7_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P7_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P7_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P7_SW.TabIndex = 31
        Me.zm_P7_SW.Text = "Secondary Weapon"
        '
        'P7_PW
        '
        Me.P7_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P7_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P7_PW.Location = New System.Drawing.Point(34, 137)
        Me.P7_PW.Name = "P7_PW"
        Me.P7_PW.Size = New System.Drawing.Size(70, 25)
        Me.P7_PW.TabIndex = 30
        Me.P7_PW.Text = "78"
        Me.P7_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P7_PW
        '
        Me.zm_P7_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P7_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P7_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P7_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P7_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P7_PW.Location = New System.Drawing.Point(113, 137)
        Me.zm_P7_PW.Name = "zm_P7_PW"
        Me.zm_P7_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P7_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P7_PW.Size = New System.Drawing.Size(99, 25)
        Me.zm_P7_PW.TabIndex = 29
        Me.zm_P7_PW.Text = "Primary Weapon"
        '
        'P7_CW
        '
        Me.P7_CW.AutoSize = True
        Me.P7_CW.BackColor = System.Drawing.Color.Transparent
        Me.P7_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P7_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P7_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P7_CW.Location = New System.Drawing.Point(96, 86)
        Me.P7_CW.Name = "P7_CW"
        Me.P7_CW.Size = New System.Drawing.Size(162, 15)
        Me.P7_CW.TabIndex = 28
        Me.P7_CW.Text = "Player Current Weapon ID -> "
        '
        'P7_Money
        '
        Me.P7_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P7_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P7_Money.Location = New System.Drawing.Point(154, 34)
        Me.P7_Money.Name = "P7_Money"
        Me.P7_Money.Size = New System.Drawing.Size(70, 25)
        Me.P7_Money.TabIndex = 27
        Me.P7_Money.Text = "800"
        Me.P7_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P7_Money
        '
        Me.zm_P7_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P7_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P7_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P7_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P7_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P7_Money.Location = New System.Drawing.Point(242, 34)
        Me.zm_P7_Money.Name = "zm_P7_Money"
        Me.zm_P7_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P7_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P7_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P7_Money.TabIndex = 26
        Me.zm_P7_Money.Text = "Player Money"
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage10.Controls.Add(Me.P8_SW)
        Me.TabPage10.Controls.Add(Me.zm_P8_SW)
        Me.TabPage10.Controls.Add(Me.P8_PW)
        Me.TabPage10.Controls.Add(Me.zm_P8_PW)
        Me.TabPage10.Controls.Add(Me.P8_CW)
        Me.TabPage10.Controls.Add(Me.P8_Money)
        Me.TabPage10.Controls.Add(Me.zm_P8_Money)
        Me.TabPage10.Location = New System.Drawing.Point(4, 36)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(496, 199)
        Me.TabPage10.TabIndex = 7
        Me.TabPage10.Text = "Player8"
        '
        'P8_SW
        '
        Me.P8_SW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P8_SW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P8_SW.Location = New System.Drawing.Point(266, 137)
        Me.P8_SW.Name = "P8_SW"
        Me.P8_SW.Size = New System.Drawing.Size(70, 25)
        Me.P8_SW.TabIndex = 32
        Me.P8_SW.Text = "78"
        Me.P8_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P8_SW
        '
        Me.zm_P8_SW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P8_SW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P8_SW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P8_SW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P8_SW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P8_SW.Location = New System.Drawing.Point(345, 137)
        Me.zm_P8_SW.Name = "zm_P8_SW"
        Me.zm_P8_SW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P8_SW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P8_SW.Size = New System.Drawing.Size(116, 25)
        Me.zm_P8_SW.TabIndex = 31
        Me.zm_P8_SW.Text = "Secondary Weapon"
        '
        'P8_PW
        '
        Me.P8_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P8_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P8_PW.Location = New System.Drawing.Point(34, 137)
        Me.P8_PW.Name = "P8_PW"
        Me.P8_PW.Size = New System.Drawing.Size(70, 25)
        Me.P8_PW.TabIndex = 30
        Me.P8_PW.Text = "78"
        Me.P8_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P8_PW
        '
        Me.zm_P8_PW.BackColor = System.Drawing.Color.Transparent
        Me.zm_P8_PW.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P8_PW.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P8_PW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P8_PW.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P8_PW.Location = New System.Drawing.Point(113, 137)
        Me.zm_P8_PW.Name = "zm_P8_PW"
        Me.zm_P8_PW.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P8_PW.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P8_PW.Size = New System.Drawing.Size(99, 25)
        Me.zm_P8_PW.TabIndex = 29
        Me.zm_P8_PW.Text = "Primary Weapon"
        '
        'P8_CW
        '
        Me.P8_CW.AutoSize = True
        Me.P8_CW.BackColor = System.Drawing.Color.Transparent
        Me.P8_CW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P8_CW.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P8_CW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P8_CW.Location = New System.Drawing.Point(96, 86)
        Me.P8_CW.Name = "P8_CW"
        Me.P8_CW.Size = New System.Drawing.Size(162, 15)
        Me.P8_CW.TabIndex = 28
        Me.P8_CW.Text = "Player Current Weapon ID -> "
        '
        'P8_Money
        '
        Me.P8_Money.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.P8_Money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.P8_Money.Location = New System.Drawing.Point(154, 34)
        Me.P8_Money.Name = "P8_Money"
        Me.P8_Money.Size = New System.Drawing.Size(70, 25)
        Me.P8_Money.TabIndex = 27
        Me.P8_Money.Text = "800"
        Me.P8_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zm_P8_Money
        '
        Me.zm_P8_Money.BackColor = System.Drawing.Color.Transparent
        Me.zm_P8_Money.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_P8_Money.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_P8_Money.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P8_Money.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_P8_Money.Location = New System.Drawing.Point(242, 34)
        Me.zm_P8_Money.Name = "zm_P8_Money"
        Me.zm_P8_Money.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_P8_Money.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_P8_Money.Size = New System.Drawing.Size(105, 25)
        Me.zm_P8_Money.TabIndex = 26
        Me.zm_P8_Money.Text = "Player Money"
        '
        'LogInGroupBox2
        '
        Me.LogInGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox2.Controls.Add(Me.zm_lobby_size)
        Me.LogInGroupBox2.Controls.Add(Me.Force_Host)
        Me.LogInGroupBox2.Controls.Add(Me.lobby_size)
        Me.LogInGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox2.Location = New System.Drawing.Point(13, 6)
        Me.LogInGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox2.Name = "LogInGroupBox2"
        Me.LogInGroupBox2.Size = New System.Drawing.Size(501, 120)
        Me.LogInGroupBox2.TabIndex = 3
        Me.LogInGroupBox2.Text = "Lobby Settings"
        Me.LogInGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'zm_lobby_size
        '
        Me.zm_lobby_size.BackColor = System.Drawing.Color.Transparent
        Me.zm_lobby_size.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.zm_lobby_size.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.zm_lobby_size.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_lobby_size.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.zm_lobby_size.Location = New System.Drawing.Point(114, 68)
        Me.zm_lobby_size.Name = "zm_lobby_size"
        Me.zm_lobby_size.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.zm_lobby_size.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.zm_lobby_size.Size = New System.Drawing.Size(105, 25)
        Me.zm_lobby_size.TabIndex = 8
        Me.zm_lobby_size.Text = "Lobby Size"
        '
        'Force_Host
        '
        Me.Force_Host.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Force_Host.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Force_Host.Checked = False
        Me.Force_Host.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Force_Host.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Force_Host.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Force_Host.Location = New System.Drawing.Point(26, 41)
        Me.Force_Host.Name = "Force_Host"
        Me.Force_Host.Size = New System.Drawing.Size(106, 22)
        Me.Force_Host.TabIndex = 0
        Me.Force_Host.Text = "Force Host"
        '
        'lobby_size
        '
        Me.lobby_size.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lobby_size.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lobby_size.ButtonColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lobby_size.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lobby_size.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lobby_size.Location = New System.Drawing.Point(26, 69)
        Me.lobby_size.Maximum = CType(8, Long)
        Me.lobby_size.Minimum = CType(0, Long)
        Me.lobby_size.Name = "lobby_size"
        Me.lobby_size.SecondBorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lobby_size.Size = New System.Drawing.Size(79, 24)
        Me.lobby_size.TabIndex = 1
        Me.lobby_size.Text = "LogInNumeric1"
        Me.lobby_size.Value = CType(4, Long)
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.NR)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.FOVS)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.FOV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 545)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Non-Host"
        '
        'NR
        '
        Me.NR.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.NR.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.NR.Checked = False
        Me.NR.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.NR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NR.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NR.Location = New System.Drawing.Point(210, 423)
        Me.NR.Name = "NR"
        Me.NR.Size = New System.Drawing.Size(87, 22)
        Me.NR.TabIndex = 7
        Me.NR.Text = "No Recoil"
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
        Me.GroupBox2.Location = New System.Drawing.Point(100, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 189)
        Me.GroupBox2.TabIndex = 6
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
        'FOVS
        '
        Me.FOVS.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FOVS.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.FOVS.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FOVS.Location = New System.Drawing.Point(115, 79)
        Me.FOVS.Maximum = 1000
        Me.FOVS.Name = "FOVS"
        Me.FOVS.Size = New System.Drawing.Size(359, 19)
        Me.FOVS.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.FOVS.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FOVS.TabIndex = 5
        Me.FOVS.Text = "LogInTrackBar21"
        Me.FOVS.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FOVS.Value = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(31, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "cg_fovScale"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(31, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 19)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "cg_fov"
        '
        'FOV
        '
        Me.FOV.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FOV.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.FOV.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FOV.Location = New System.Drawing.Point(100, 50)
        Me.FOV.Maximum = 140
        Me.FOV.Name = "FOV"
        Me.FOV.Size = New System.Drawing.Size(374, 23)
        Me.FOV.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.FOV.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FOV.TabIndex = 0
        Me.FOV.Text = "LogInTrackBar1"
        Me.FOV.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FOV.Value = 65
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.ZombieRd)
        Me.LogInGroupBox1.Controls.Add(Me.Label7)
        Me.LogInGroupBox1.Controls.Add(Me.ZombieHh)
        Me.LogInGroupBox1.Controls.Add(Me.Label6)
        Me.LogInGroupBox1.Controls.Add(Me.mapName)
        Me.LogInGroupBox1.Controls.Add(Me.in_game)
        Me.LogInGroupBox1.Controls.Add(Me.ZombieNB)
        Me.LogInGroupBox1.Controls.Add(Me.Label3)
        Me.LogInGroupBox1.Controls.Add(Me.Label2)
        Me.LogInGroupBox1.Controls.Add(Me.Label1)
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(532, 120)
        Me.LogInGroupBox1.TabIndex = 0
        Me.LogInGroupBox1.Text = "Status"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'ZombieRd
        '
        Me.ZombieRd.AutoSize = True
        Me.ZombieRd.BackColor = System.Drawing.Color.Transparent
        Me.ZombieRd.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ZombieRd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ZombieRd.Location = New System.Drawing.Point(137, 94)
        Me.ZombieRd.Name = "ZombieRd"
        Me.ZombieRd.Size = New System.Drawing.Size(13, 13)
        Me.ZombieRd.TabIndex = 14
        Me.ZombieRd.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Number of Round : "
        '
        'ZombieHh
        '
        Me.ZombieHh.AutoSize = True
        Me.ZombieHh.BackColor = System.Drawing.Color.Transparent
        Me.ZombieHh.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ZombieHh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ZombieHh.Location = New System.Drawing.Point(341, 71)
        Me.ZombieHh.Name = "ZombieHh"
        Me.ZombieHh.Size = New System.Drawing.Size(13, 13)
        Me.ZombieHh.TabIndex = 12
        Me.ZombieHh.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(231, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zombie Health : "
        '
        'mapName
        '
        Me.mapName.AutoSize = True
        Me.mapName.BackColor = System.Drawing.Color.Transparent
        Me.mapName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mapName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.mapName.Location = New System.Drawing.Point(308, 40)
        Me.mapName.Name = "mapName"
        Me.mapName.Size = New System.Drawing.Size(62, 13)
        Me.mapName.TabIndex = 10
        Me.mapName.Text = "Nuketwon"
        '
        'in_game
        '
        Me.in_game.AutoSize = True
        Me.in_game.BackColor = System.Drawing.Color.Transparent
        Me.in_game.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.in_game.ForeColor = System.Drawing.Color.Red
        Me.in_game.Location = New System.Drawing.Point(102, 40)
        Me.in_game.Name = "in_game"
        Me.in_game.Size = New System.Drawing.Size(73, 13)
        Me.in_game.TabIndex = 9
        Me.in_game.Text = "Not in-game"
        '
        'ZombieNB
        '
        Me.ZombieNB.AutoSize = True
        Me.ZombieNB.BackColor = System.Drawing.Color.Transparent
        Me.ZombieNB.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ZombieNB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ZombieNB.Location = New System.Drawing.Point(137, 71)
        Me.ZombieNB.Name = "ZombieNB"
        Me.ZombieNB.Size = New System.Drawing.Size(13, 13)
        Me.ZombieNB.TabIndex = 8
        Me.ZombieNB.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number of Zombie : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(231, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Map Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Game Status : "
        '
        'Zombie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 800)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Zombie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zombie"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Player_tab.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.LogInGroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GunZ_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunY_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunX_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.LogInGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents LogInGroupBox1 As LogInGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ZombieNB As Label
    Friend WithEvents in_game As Label
    Friend WithEvents LogInTabControl1 As LogInTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents mapName As Label
    Friend WithEvents lobby_size As LogInNumeric
    Friend WithEvents Force_Host As LogInCheckBox
    Friend WithEvents inf_ammo As LogInCheckBox
    Friend WithEvents LogInGroupBox2 As LogInGroupBox
    Friend WithEvents P1_CW As LogInLabel
    Friend WithEvents inf_gre As LogInCheckBox
    Friend WithEvents P1_Money As TextBox
    Friend WithEvents zm_P1_Money As LogInButton
    Friend WithEvents round As TextBox
    Friend WithEvents nb_round As LogInButton
    Friend WithEvents FOV As LogInTrackBar
    Friend WithEvents FOVS As LogInTrackBar2
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
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
    Friend WithEvents Player_tab As LogInTabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents LogInLabel3 As LogInLabel
    Friend WithEvents LogInComboBox1 As LogInComboBox
    Friend WithEvents P1_SW As TextBox
    Friend WithEvents zm_P1_SW As LogInButton
    Friend WithEvents P1_PW As TextBox
    Friend WithEvents zm_P1_PW As LogInButton
    Friend WithEvents P3_SW As TextBox
    Friend WithEvents zm_P3_SW As LogInButton
    Friend WithEvents P3_PW As TextBox
    Friend WithEvents zm_P3_PW As LogInButton
    Friend WithEvents P3_CW As LogInLabel
    Friend WithEvents P3_Money As TextBox
    Friend WithEvents zm_P3_Money As LogInButton
    Friend WithEvents P4_SW As TextBox
    Friend WithEvents zm_P4_SW As LogInButton
    Friend WithEvents P4_PW As TextBox
    Friend WithEvents zm_P4_PW As LogInButton
    Friend WithEvents P4_CW As LogInLabel
    Friend WithEvents P4_Money As TextBox
    Friend WithEvents zm_P4_Money As LogInButton
    Friend WithEvents P5_SW As TextBox
    Friend WithEvents zm_P5_SW As LogInButton
    Friend WithEvents P5_PW As TextBox
    Friend WithEvents zm_P5_PW As LogInButton
    Friend WithEvents P5_CW As LogInLabel
    Friend WithEvents P5_Money As TextBox
    Friend WithEvents zm_P5_Money As LogInButton
    Friend WithEvents P6_SW As TextBox
    Friend WithEvents zm_P6_SW As LogInButton
    Friend WithEvents P6_PW As TextBox
    Friend WithEvents zm_P6_PW As LogInButton
    Friend WithEvents P6_CW As LogInLabel
    Friend WithEvents P6_Money As TextBox
    Friend WithEvents zm_P6_Money As LogInButton
    Friend WithEvents P7_SW As TextBox
    Friend WithEvents zm_P7_SW As LogInButton
    Friend WithEvents P7_PW As TextBox
    Friend WithEvents zm_P7_PW As LogInButton
    Friend WithEvents P7_CW As LogInLabel
    Friend WithEvents P7_Money As TextBox
    Friend WithEvents zm_P7_Money As LogInButton
    Friend WithEvents P8_SW As TextBox
    Friend WithEvents zm_P8_SW As LogInButton
    Friend WithEvents P8_PW As TextBox
    Friend WithEvents zm_P8_PW As LogInButton
    Friend WithEvents P8_CW As LogInLabel
    Friend WithEvents P8_Money As TextBox
    Friend WithEvents zm_P8_Money As LogInButton
    Friend WithEvents zm_lobby_size As LogInButton
    Friend WithEvents ZombieHh As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Status_Timer As Timer
    Friend WithEvents P2_SW As TextBox
    Friend WithEvents zm_P2_SW As LogInButton
    Friend WithEvents P2_PW As TextBox
    Friend WithEvents zm_P2_PW As LogInButton
    Friend WithEvents P2_CW As LogInLabel
    Friend WithEvents P2_Money As TextBox
    Friend WithEvents zm_P2_Money As LogInButton
    Friend WithEvents ZombieRd As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Host_Timer As Timer
    Friend WithEvents TP_P4 As LogInButton
    Friend WithEvents TP_P3 As LogInButton
    Friend WithEvents TP_P2 As LogInButton
    Friend WithEvents Non_Host_Timer As Timer
    Friend WithEvents NR As LogInCheckBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TP_to_P4 As LogInButton
    Friend WithEvents TP_to_P3 As LogInButton
    Friend WithEvents TP_to_P2 As LogInButton
End Class
