Public Class Form1

    Dim a As New WriterClass
    Dim My_map As String
    Dim Game_mode As String
    Dim I, O, U, R, R2, G1, G2, B, B2 As Integer
    Dim allowname As Integer = 0
    Dim Gun_number, Camo_number As Integer

#Region "           OFFSETS         "
    Dim Tdisabler As Integer = &H3A458F4

    Dim map_name As Integer = &H1149FE0
    Dim gametype As Integer = &H114A020
    Dim number_player As Integer = &H1149ECC


    Dim DVAR As Integer = &H18
    Dim cg_hue As Integer = &H10A7EA4
    Dim cg_saturation As Integer = &H10A7E1C
    Dim cg_temp As Integer = &H10A7E30
    Dim cg_coloro_on As Integer = &H10A7EAC
    Dim cg_fov As Integer = &H114227C
    Dim cg_fovscale As Integer = &H1140880
    Dim com_fps As Integer = &H25E45B0
    Dim detailcamo As Integer = &H10A7E64
    Dim cg_overheadnamessize As Integer = &H113F158
    Dim cg_overheadiconsize As Integer = &H11422B8
    Dim cg_overheadranksize As Integer = &H113F188
    Dim cg_gun_x As Integer = &H1153184  '2A4B340 1153184 
    Dim cg_gun_y As Integer = &H1153160
    Dim cg_gun_z As Integer = &H115316C
    Dim cg_crosshaire As Integer = &H10AA244
    Dim cg_names As Integer = &H113F158
    Dim cg_ranks As Integer = &H113F188
    Dim cg_radar As Integer = &H11423C8
    Dim cg_chatheight As Integer = &H2A1AC3C
    Dim cg_crosshaire_name As Integer = &H11409C8
    Dim r_aaalpha As Integer = &H34559B4
    Dim cg_gun As Integer = &H10AC1A8
    Dim cg_draw2D As Integer = &H10AC164
    Dim night_sky As Integer = &H345595C
    Dim night_sky2 As Integer = &H3455910
    Dim red_sky As Integer = &H3455A74
    Dim sun_direction As Integer = &H34558EC
    Dim sky_transition As Integer = &H3455B24
    Dim sky_rortation As Integer = &H3455888
    Dim sunlight_dir As Integer = &H34558EC
    Dim bloomTweaks As Integer = &H3455698
    Dim heroLightScale As Integer = &H3455B3C
    Dim HLSR As Integer = &H2A3E200
    Dim HLSG As Integer = &H2A3E204
    Dim HLSB As Integer = &H2A3E208
    Dim dobjLimit As Integer = &H3455A6C
    'light color
    Dim sun_light_on As Integer = &H345560C
    Dim sun_light_color As Integer = &H34559A8
    Dim z_on As Integer = &H3455954
    Dim z_nblur As Integer = &H2A3C940 '2A3C950 '34559CC  
    Dim z_fblur As Integer = &H2A3C9A0 '2A3C9B0 '3455B0C  
    Dim z_fstart As Integer = &H2A3CB80 '2A3CB90 '3455640 
    Dim z_fend As Integer = &H2A3CBE0 '2A3CBF0 ' 3455B04 ' 
    Dim z_nstart As Integer = &H2A3CAC0 '2A3CAD0 '3455A34 ' 
    Dim z_nend As Integer = &H2A3CB20 '2A3CB30 '34555D8 ' 
    Dim SS_bias As Integer = &H34556AC
    Dim SS_Scale As Integer = &H3455B4C
    Dim SS_Radius As Integer = &H3455AAC
    Dim SS_Intensity As Integer = &H3455A60
    'fog
    Dim f_start As Integer = &H36434B8
    Dim f_distance As Integer = &H36434BC
    Dim f_height As Integer = &H36434C4
    Dim f_bias As Integer = &H36434C8
    Dim f_baseExp As Integer = &H36434E4
    Dim f_farExp As Integer = &H3634F4
    Dim f_FBR As Integer = &H36434D8
    Dim f_FBG As Integer = &H36434DC
    Dim f_FBB As Integer = &H36434E0
    Dim f_FFR As Integer = &H36434E8
    Dim f_FFG As Integer = &H36434EC
    Dim f_FFB As Integer = &H36434F0

    Dim sunX1 As Integer = &H2A391C0
    Dim sunX2 As Integer = &H2A391D0
    Dim sunY1 As Integer = &H2A391C4
    Dim sunY2 As Integer = &H2A391D4

    Dim zz_nblur As Integer = &H2A3C940  '2A3C950
    Dim zz_fblur As Integer = &H2A3C9A0  '2A3C9B0
    Dim zz_fstart As Integer = &H2A3CB80  '2A3CB90
    Dim zz_fend As Integer = &H2A3CBE0    '2A3CBF0
    Dim zz_nstart As Integer = &H2A3CAC0  '2A3CAD0
    Dim zz_nend As Integer = &H2A3CB20  '2A3CB30

    Dim zz_nblur2 As Integer = &H2A3C950
    Dim zz_fblur2 As Integer = &H2A3C9B0
    Dim zz_fstart2 As Integer = &H2A3CB90
    Dim zz_fend2 As Integer = &H2A3CBF0
    Dim zz_nstart2 As Integer = &H2A3CAD0
    Dim zz_nend2 As Integer = &H2A3CB30

    Dim light_color_R1 As Integer = &H2A39110
    Dim light_color_G1 As Integer = &H2A39114
    Dim light_color_B1 As Integer = &H2A39118
    Dim light_color_R2 As Integer = &H2A39100
    Dim light_color_G2 As Integer = &H2A39104
    Dim light_color_B2 As Integer = &H2A39108

    Dim my_team As Integer = &H2376094
    Dim health1 As Integer = &H23737E0
    Dim health2 As Integer = &H21EF968

    Dim health_size As Integer = &H31C
    Dim main_size As Integer = &H57F8

    Dim Arc1 As Integer = &H237B938
    Dim Arc2 As Integer = &H2381130
    Dim Arc3 As Integer = &H2386928
    Dim Arc4 As Integer = &H238C120
    Dim Arc5 As Integer = &H2391918
    Dim Arc6 As Integer = &H2397110
    Dim Arc7 As Integer = &H239C908
    Dim Arc8 As Integer = &H23A2100
    Dim Arc9 As Integer = &H23A78F8
    Dim Arc10 As Integer = &H23AD0F0
    Dim Arc11 As Integer = &H23B28E8
    Dim Arc0 As Integer = &H2376140



    Dim bot_name1 As Integer = &H237B8CC
    Dim bot_name2 As Integer = &H23810C4
    Dim bot_name3 As Integer = &H23868BC
    Dim bot_name4 As Integer = &H238C0B4
    Dim bot_name5 As Integer = &H23918AC
    Dim bot_name6 As Integer = &H23970A4
    Dim bot_name7 As Integer = &H239C89C
    Dim bot_name8 As Integer = &H23A2094
    Dim bot_name9 As Integer = &H23A788C
    Dim bot_name10 As Integer = &H23AD084
    Dim bot_name11 As Integer = &H23B287C
    Dim bot_name0 As Integer = &H23760D4

    Dim Camo1 As Integer = &H2370E78
    Dim Camo2 As Integer = &H2370E5C

    Dim weapon_P As Integer = &H2370E74
    Dim weapon_S As Integer = &H2370E58

    Dim no_spread As Integer = &H2A2F200
    Dim no_reload As Integer = &H2A2F260
    Dim no_FireRate As Integer = &H2A2F2C0
    Dim no_scopeFast As Integer = &H2A2F320

    Dim perk1 As Integer = &H23710E8
    Dim perk2 As Integer = &H23710EC
    Dim perk3 As Integer = &H2373AF0
    Dim perk4 As Integer = &H2373AF4
    Dim perk5 As Integer = &H2376134
    Dim perk6 As Integer = &H2376138

    Dim my_vsat As Integer = &H2E4911D4
    Dim my_recoil As Integer = &H56EC09
    Dim re_on As Byte() = {116}
    Dim re_off As Byte() = {235}

    Dim compass As Integer = &H1079D58




#End Region


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a.Process_Handle("t6mp")
        a.WriteInteger(Tdisabler, 1)


#Region "Vac counter mesure"
        Me.Text = ""

        For i As Integer = 1 To 30

            generate_name()
        Next
#End Region

#Region "ComboBoxes"
        CFG_box.Items.Add("cg_")
        CFG_box.Items.Add("g_")

        foggmzor.Items.Add("Custom Config")
        foggmzor.Items.Add("FoggyDay")
        foggmzor.Items.Add("Aqua")
        foggmzor.Items.Add("PitchBlack")
        foggmzor.Items.Add("Denpa")
        foggmzor.Items.Add("Forest fire")
        foggmzor.Items.Add("Smog")
        foggmzor.Items.Add("Buffer")

        ' / feed allies \ '
        Allies_combo.Items.Add("Black")
        Allies_combo.Items.Add("Blue")
        Allies_combo.Items.Add("Cyan")
        Allies_combo.Items.Add("Green")
        Allies_combo.Items.Add("Pink")
        Allies_combo.Items.Add("Purple")
        Allies_combo.Items.Add("Red")
        Allies_combo.Items.Add("White")
        Allies_combo.Items.Add("Yellow")


        ' / feed ennemies \ '
        ennemies_combo.Items.Add("Black")
        ennemies_combo.Items.Add("Blue")
        ennemies_combo.Items.Add("Cyan")
        ennemies_combo.Items.Add("Green")
        ennemies_combo.Items.Add("Pink")
        ennemies_combo.Items.Add("Purple")
        ennemies_combo.Items.Add("Red")
        ennemies_combo.Items.Add("White")
        ennemies_combo.Items.Add("Yellow")

        GScom.Items.Add("None")
        GScom.Items.Add("Alien")
        GScom.Items.Add("Aqua")
        GScom.Items.Add("Blue")
        GScom.Items.Add("GreenLime")
        GScom.Items.Add("Morning")
        GScom.Items.Add("Orange")
        GScom.Items.Add("Red")
        GScom.Items.Add("Purple")
        GScom.Items.Add("Yellow")

        weapon_choose.Items.Add("MP7") '2 
        weapon_choose.Items.Add("PDW-57") '4 
        weapon_choose.Items.Add("Vector") '6 
        weapon_choose.Items.Add("MSMC") '8 
        weapon_choose.Items.Add("Chicom") '10
        weapon_choose.Items.Add("Skorpion-Evo") '12
        weapon_choose.Items.Add("Peacekeeper") '14
        weapon_choose.Items.Add("MTAR") '16
        weapon_choose.Items.Add("Type95") '20
        weapon_choose.Items.Add("SwaT-556") '24 
        weapon_choose.Items.Add("FAL DSW") '28
        weapon_choose.Items.Add("M27") '32 
        weapon_choose.Items.Add("Scar-H") '36
        weapon_choose.Items.Add("SMR") '40
        weapon_choose.Items.Add("M8A1") '44 
        weapon_choose.Items.Add("AN-94") '48 
        weapon_choose.Items.Add("R870 MCS") '52
        weapon_choose.Items.Add("S12") '53
        weapon_choose.Items.Add("KSG") '54
        weapon_choose.Items.Add("M1216") '55
        weapon_choose.Items.Add("MK-48") '56
        weapon_choose.Items.Add("QBB LSW") '58 
        weapon_choose.Items.Add("LSAT") '60
        weapon_choose.Items.Add("HAMR") '62
        weapon_choose.Items.Add("SVU-AS") '64
        weapon_choose.Items.Add("DSR50") '65
        weapon_choose.Items.Add("Ballista") '66 
        weapon_choose.Items.Add("XPR-50") '67
        weapon_choose.Items.Add("Kap-40 akimbo") '68 
        weapon_choose.Items.Add("Tac-45 akimbo") '70 
        weapon_choose.Items.Add("Five-Seven akimbo") '72 
        weapon_choose.Items.Add("Executioner akimbo") '74 
        weapon_choose.Items.Add("B23R akimbo") '76 
        weapon_choose.Items.Add("Five-Seven") '78 
        weapon_choose.Items.Add("Tac-45") '79 
        weapon_choose.Items.Add("B23R") '80
        weapon_choose.Items.Add("Executioner") '81
        weapon_choose.Items.Add("Kap-40") '82
        weapon_choose.Items.Add("SMAW") '84
        weapon_choose.Items.Add("FHJ-18 AA") '85
        weapon_choose.Items.Add("RPG") '86
        weapon_choose.Items.Add("Combat Knife") '87
        weapon_choose.Items.Add("Assault Shield") '89
        weapon_choose.Items.Add("Crossbow") '90
        weapon_choose.Items.Add("Ballistic Knife") '91
        weapon_choose.Items.Add("Grenade") '92
        weapon_choose.Items.Add("Concussion Grenade") '93
        weapon_choose.Items.Add("Semtex") '94
        weapon_choose.Items.Add("Smoke Grenade") '95
        weapon_choose.Items.Add("Combat Axe") '96
        weapon_choose.Items.Add("Bouncing Betty") '98
        weapon_choose.Items.Add("EMP Grenade") '99
        weapon_choose.Items.Add("C4") '103
        weapon_choose.Items.Add("Flash Grenade") '104
        weapon_choose.Items.Add("Claymore") '102
        weapon_choose.Items.Add("Trophy system") '105
        weapon_choose.Items.Add("Knife") '110


        camo_box.Items.Add("No Camo")
        camo_box.Items.Add("DEVGRU")
        camo_box.Items.Add("A-TAC")
        camo_box.Items.Add("ERDL")
        camo_box.Items.Add("Siberia")
        camo_box.Items.Add("Choco")
        camo_box.Items.Add("Blue Tiger")
        camo_box.Items.Add("Blood Shot")
        camo_box.Items.Add("Ghostex")
        camo_box.Items.Add("Kryptek")
        camo_box.Items.Add("Carbon Fiber")
        camo_box.Items.Add("Cherry Blossom")
        camo_box.Items.Add("Art Of War")
        camo_box.Items.Add("Ronin")
        camo_box.Items.Add("Sulls")
        camo_box.Items.Add("Gold")
        camo_box.Items.Add("Diamond")
        camo_box.Items.Add("Elite Member")
        camo_box.Items.Add("Jungle Warfare")
        camo_box.Items.Add("Bo2 Hidden Camo")
        camo_box.Items.Add("Benjamin")
        camo_box.Items.Add("Dia De Muertos")
        camo_box.Items.Add("Graffity")
        camo_box.Items.Add("Kawai")
        camo_box.Items.Add("Party Rock")
        camo_box.Items.Add("Zombies")
        camo_box.Items.Add("Viper")
        camo_box.Items.Add("Bacon")
        camo_box.Items.Add("Ghost")
        camo_box.Items.Add("Paladin")
        camo_box.Items.Add("Cyborg")
        camo_box.Items.Add("Aqua")
        camo_box.Items.Add("Breach")
        camo_box.Items.Add("Coyote")
        camo_box.Items.Add("Glam")
        camo_box.Items.Add("Rogue")
        camo_box.Items.Add("Pack A Punch")
        camo_box.Items.Add("UK Punk")
        camo_box.Items.Add("Dragon")
        camo_box.Items.Add("Coomics")
        camo_box.Items.Add("After Life")
        camo_box.Items.Add("Dead Man's Hand")
        camo_box.Items.Add("Beast")
        camo_box.Items.Add("Octane")
        camo_box.Items.Add("Weaponized 115")
        camo_box.Items.Add("AW Hidden Camo")


#End Region

        Main_timer.Start()
        Theater_Timer.Start()
        Fog_Timer.Start()
        Sun_Timer.Start()
        C_Timer.Start()

    End Sub

#Region "Vac counter mesure 2 "
    Private Sub generate_name()
        Dim LetterRdm As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890<>#*!§$%&/()=?"

        Dim r As New Random
        Try
            For i As Integer = 0 To 10
                Me.Text += LetterRdm.Substring(r.Next(1, 76), 1)
            Next
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub



#End Region

    Private Sub Main_timer_Tick(sender As Object, e As EventArgs) Handles Main_timer.Tick
        a.Process_Handle("t6mp")
#Region "Public or private status"
        If MyTabControl.SelectedTab.TabIndex = 0 Then 'CFG
            Public_lbl.Text = "Public"
            Public_lbl.ForeColor = Color.Green
        ElseIf MyTabControl.SelectedTab.TabIndex = 1 Then 'Theater
            Public_lbl.Text = "Public"
            Public_lbl.ForeColor = Color.Green
        ElseIf MyTabControl.SelectedTab.TabIndex = 2 Then 'FOG
            Public_lbl.Text = "Public"
            Public_lbl.ForeColor = Color.Green
        ElseIf MyTabControl.SelectedTab.TabIndex = 3 Then 'Sun
            Public_lbl.Text = "Public"
            Public_lbl.ForeColor = Color.Green
        ElseIf MyTabControl.SelectedTab.TabIndex = 4 Then 'Bot Rennamer
            Public_lbl.Text = "Private"
            Public_lbl.ForeColor = Color.Red
        ElseIf MyTabControl.SelectedTab.TabIndex = 5 Then 'Weapon
            Public_lbl.Text = "Private"
            Public_lbl.ForeColor = Color.Red
        ElseIf MyTabControl.SelectedTab.TabIndex = 6 Then 'Cheats
            Public_lbl.Text = "Mixed"
            Public_lbl.ForeColor = Color.Yellow
        End If
#End Region

#Region "       Status      "

#Region "       MAP NAME        "


        My_map = a.ReadString(map_name, 16)

        If My_map.Contains("mp_nuketown_2020") Then
            mapName.Text = "NukeTown 2025"

        ElseIf My_map.Contains("mp_la") Then
            mapName.Text = "Aftermath"

        ElseIf My_map.Contains("mp_carrier") Then
            mapName.Text = "Carrier"

        ElseIf My_map.Contains("mp_drone") Then
            mapName.Text = "Drone"

        ElseIf My_map.Contains("mp_express") Then
            mapName.Text = "Express"

        ElseIf My_map.Contains("mp_hijacked") Then
            mapName.Text = "Hijacked"

        ElseIf My_map.Contains("mp_meltdown") Then
            mapName.Text = "Meltdown"

        ElseIf My_map.Contains("mp_overflow") Then
            mapName.Text = "Overflow"

        ElseIf My_map.Contains("mp_nightclub") Then
            mapName.Text = "Plaza"

        ElseIf My_map.Contains("mp_raid") Then
            mapName.Text = "Raid"

        ElseIf My_map.Contains("mp_slums") Then
            mapName.Text = "Slums"

        ElseIf My_map.Contains("mp_village") Then
            mapName.Text = "Standoff"

        ElseIf My_map.Contains("mp_turbine") Then
            mapName.Text = "Turbine"

        ElseIf My_map.Contains("mp_socotra") Then
            mapName.Text = "Yemen"

        ElseIf My_map.Contains("mp_dig") Then
            mapName.Text = "Dig"

        ElseIf My_map.Contains("mp_pod") Then
            mapName.Text = "Pod"

        ElseIf My_map.Contains("mp_takeoff") Then
            mapName.Text = "Take Off"

        ElseIf My_map.Contains("mp_frostbite") Then
            mapName.Text = "Frost"

        ElseIf My_map.Contains("mp_mirage") Then
            mapName.Text = "Mirage"

        ElseIf My_map.Contains("mp_hydro") Then
            mapName.Text = "Hydro"

        ElseIf My_map.Contains("mp_skate") Then
            mapName.Text = "Grind"

        ElseIf My_map.Contains("mp_downhill") Then
            mapName.Text = "Down Hill"

        ElseIf My_map.Contains("mp_concert") Then
            mapName.Text = "Encore"

        ElseIf My_map.Contains("mp_vertigo") Then
            mapName.Text = "Vertigo"

        ElseIf My_map.Contains("mp_magma") Then
            mapName.Text = "Magma"

        ElseIf My_map.Contains("mp_studio") Then
            mapName.Text = "Studio"

        ElseIf My_map.Contains("mp_paintball") Then
            mapName.Text = "Rush"

        ElseIf My_map.Contains("mp_Cove") Then
            mapName.Text = "Castaway"

        ElseIf My_map.Contains("mp_detour") Then
            mapName.Text = "Bridge"

        ElseIf My_map.Contains("mp_uplink") Then
            mapName.Text = "Uplink"

        End If

#End Region

#Region "       GameType        "
        Game_mode = a.ReadString(gametype, 8)

        If Game_mode.Contains("tdm") Then
            gameMode.Text = "Team Deathmatch"

        ElseIf Game_mode.Contains("dm") Then
            gameMode.Text = "Free-for-All"

        ElseIf Game_mode.Contains("dom") Then
            gameMode.Text = "Domination"

        ElseIf Game_mode.Contains("dem") Then
            gameMode.Text = "Demolition"

        ElseIf Game_mode.Contains("conf") Then
            gameMode.Text = "Kill Confirmed"

        ElseIf Game_mode.Contains("koth") Then
            gameMode.Text = "Hardpoint"

        ElseIf Game_mode.Contains("hq") Then
            gameMode.Text = "Headquarters"

        ElseIf Game_mode.Contains("ctf") Then
            gameMode.Text = "Capture the Flag"

        ElseIf Game_mode.Contains("sd") Then
            gameMode.Text = "Search and Destroy"

        ElseIf Game_mode.Contains("oneflag") Then
            gameMode.Text = "One Flag CTF"

        ElseIf Game_mode.Contains("gun") Then
            gameMode.Text = "Gun Game"

        ElseIf Game_mode.Contains("oic") Then
            gameMode.Text = "One in the Chamber"

        ElseIf Game_mode.Contains("sas") Then
            gameMode.Text = "Sticks and Stones"

        End If
#End Region

        PlayerNb.Text = a.ReadInteger(number_player, 4)

        Dim p() As Process
        p = Process.GetProcessesByName("t6mp")
        If p.Count > 0 Then
            in_game.ForeColor = Color.Green
            in_game.Text = "In-Game"
        Else
            in_game.Text = "Not In-Game"
            in_game.ForeColor = Color.Red
        End If
#End Region

#Region "CFG Combobox "


        If CFG_box.Text = "cg_" Then
            CG.Visible = True
            G.Visible = False

            Me.Height = 800
            MyTabControl.Height = 670
        ElseIf CFG_box.Text = "g_" Then
            G.Visible = True
            CG.Visible = False
            Me.Height = 400
            MyTabControl.Height = 270

        End If
#End Region

#Region "      & Guns & Che      "


        If Weapons_on.Checked = True Then
            Gun_Timer.Start()
        Else
            Gun_Timer.Stop()
        End If

        If AHO.Checked = True Then
            C_Timer.Start()
        ElseIf AHO.Checked = False Then
            C_Timer.Stop()
        End If

        If ANH.Checked = True Then
            NC_Timer.Start()
        ElseIf ANH.Checked = False Then
            NC_Timer.Stop()
        End If
#End Region

        cg_tab()


    End Sub


#Region "Minnimized notifyIcon"


    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        NotifyIcon1.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub





#End Region

#Region "       CG TAB      "
    Private Sub cg_tab()
        a.Process_Handle("t6mp")

#Region "CG Fov FPS Gun Position Region "
        a.WriteFloat(a.ReadInteger(cg_fov) + DVAR, (Fov_Bar.Value)) '/ fov
        a.WriteFloat(a.ReadInteger(cg_fovscale) + DVAR, 1 + (FOVS_Bar.Value / 1000)) '/ fovScale
        a.WriteInteger(a.ReadInteger(com_fps) + DVAR, (FPS_Bar.Value)) '/ fps
        '// gun position
        If GunX_Box.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_gun_x) + DVAR, (GunX_Bar.Value)) '/ x
            GunX_lbl.Text = GunX_Bar.Value
        ElseIf GunX_Box.Checked = False Then
            GunX_Bar.Value = 0
            a.WriteFloat(a.ReadInteger(cg_gun_x) + DVAR, (GunX_Bar.Value)) '/ x reset
            GunX_lbl.Text = GunX_Bar.Value
        End If
        If GunY_Box.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_gun_y) + DVAR, (GunY_Bar.Value)) '/y
            GunY_lbl.Text = GunY_Bar.Value
        ElseIf GunY_Box.Checked = False Then
            GunY_Bar.Value = 0
            a.WriteFloat(a.ReadInteger(cg_gun_y) + DVAR, (GunY_Bar.Value)) '/y
            GunY_lbl.Text = GunY_Bar.Value
        End If
        If GunZ_Box.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_gun_z) + DVAR, (GunZ_Bar.Value)) '/z
            GunZ_lbl.Text = GunZ_Bar.Value
        ElseIf GunZ_Box.Checked = False Then
            GunZ_Bar.Value = 0
            a.WriteFloat(a.ReadInteger(cg_gun_z) + DVAR, (GunZ_Bar.Value)) '/z
            GunZ_lbl.Text = GunZ_Bar.Value
        End If
#End Region

        If ANRI.Checked = True Then
            a.WriteInteger(a.ReadInteger(cg_overheadiconsize) + DVAR, Convert.ToInt32(Icon_txt.Text) / 10)
            a.WriteInteger(a.ReadInteger(cg_overheadranksize) + DVAR, Convert.ToInt32(Rank_txt.Text) / 10)
            a.WriteInteger(a.ReadInteger(cg_overheadnamessize) + DVAR, Convert.ToInt32(Names_txt.Text) / 10)
        ElseIf ANRI.Checked = False Then
        End If
#Region "Remove region "
        If R_crosshair.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_crosshaire) + DVAR, 0)
            '  ElseIf R_crosshair.Checked = True Then
            '   a.WriteFloat(a.ReadInteger(cg_crosshaire) + DVAR, 1)
        End If
        If R_2d.Checked = True Then
            a.WriteInteger(a.ReadInteger(cg_draw2D) + DVAR, 0)
            ' ElseIf R_2d.Checked = True Then
            '    a.WriteInteger(a.ReadInteger(cg_draw2D) + DVAR, 1)
        End If
        If R_Gun.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_gun) + DVAR, 0)
        End If
        If R_Player.Checked = True Then
            a.WriteFloat(a.ReadInteger(dobjLimit) + DVAR, 0)
        ElseIf R_Player.Checked = False Then
            a.WriteFloat(a.ReadInteger(dobjLimit) + DVAR, 512)
        End If
        If R_Name.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_names) + DVAR, 0)
        ElseIf R_Name.Checked = False Then
            a.WriteFloat(a.ReadInteger(cg_names) + DVAR, 1)
        End If
        If R_Rank.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_ranks) + DVAR, 0)
        ElseIf R_Rank.Checked = False Then
            a.WriteFloat(a.ReadInteger(cg_ranks) + DVAR, 1)
        End If
        If nochat.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_chatheight) + DVAR, 0)
        ElseIf nochat.Checked = False Then
            a.WriteFloat(a.ReadInteger(cg_chatheight) + DVAR, 4)
        End If
#End Region

#Region "color saturation temp hue"
        If cg_color_activate.Checked = True Then
            a.WriteInteger(a.ReadInteger(cg_coloro_on) + &H18, 1)

            a.WriteInteger(a.ReadInteger(cg_hue) + &H18, 0)
            a.WriteInteger(a.ReadInteger(cg_saturation) + &H18, (saturation.Value))
            a.WriteInteger(a.ReadInteger(cg_temp) + &H18, (temp.Value))
        ElseIf cg_color_activate.Checked = False Then
            a.WriteInteger(a.ReadInteger(cg_coloro_on) + &H18, 0)
            a.WriteInteger(a.ReadInteger(cg_hue) + &H18, 0)
            saturation.Value = (1065353216)
            temp.Value = (1170939904)
        End If
#End Region

#Region "Feed Color Changer"

#Region "Allies"
        If Allies_combo.SelectedItem = "Black" Then
            R = 0
            G1 = 0
            B = 0
            allies_pic.BackColor = Color.Black

        ElseIf Allies_combo.SelectedItem = "Blue" Then
            R = 136
            G1 = 48
            B = 42
            allies_pic.BackColor = Color.Blue

        ElseIf Allies_combo.SelectedItem = "Cyan" Then
            R = 167
            G1 = 55
            B = 73
            allies_pic.BackColor = Color.Cyan

        ElseIf Allies_combo.SelectedItem = "Green" Then
            R = 255
            G1 = 0
            B = 0
            allies_pic.BackColor = Color.Green

        ElseIf Allies_combo.SelectedItem = "Pink" Then
            R = 155
            G1 = 42
            B = 48
            allies_pic.BackColor = Color.Pink

        ElseIf Allies_combo.SelectedItem = "Purple" Then
            R = 132
            G1 = 48
            B = 42
            allies_pic.BackColor = Color.Purple

        ElseIf Allies_combo.SelectedItem = "Red" Then
            R = 1
            G1 = 0
            B = 0
            allies_pic.BackColor = Color.Red

        ElseIf Allies_combo.SelectedItem = "White" Then
            R = 82
            G1 = 106
            B = 83
            allies_pic.BackColor = Color.White

        ElseIf Allies_combo.SelectedItem = "Yellow" Then
            R = 168
            G1 = 42
            B = 48
            allies_pic.BackColor = Color.Yellow

        End If

#End Region

#Region "Ennemies"
        If ennemies_combo.SelectedItem = "Black" Then
            R2 = 0
            G2 = 0
            B2 = 0
            ennemies_pic.BackColor = Color.Black

        ElseIf ennemies_combo.SelectedItem = "Blue" Then
            R2 = 136
            G2 = 48
            B2 = 42
            ennemies_pic.BackColor = Color.Blue

        ElseIf ennemies_combo.SelectedItem = "Cyan" Then
            R2 = 167
            G2 = 55
            B2 = 73
            ennemies_pic.BackColor = Color.Cyan

        ElseIf ennemies_combo.SelectedItem = "Green" Then
            R2 = 255
            G2 = 0
            B2 = 0
            ennemies_pic.BackColor = Color.Green

        ElseIf ennemies_combo.SelectedItem = "Pink" Then
            R2 = 155
            G2 = 42
            B2 = 48
            ennemies_pic.BackColor = Color.Pink

        ElseIf ennemies_combo.SelectedItem = "Purple" Then
            R2 = 132
            G2 = 48
            B2 = 42
            ennemies_pic.BackColor = Color.Purple

        ElseIf ennemies_combo.SelectedItem = "Red" Then
            R2 = 1
            G2 = 0
            B2 = 0
            ennemies_pic.BackColor = Color.Red

        ElseIf ennemies_combo.SelectedItem = "White" Then
            R2 = 82
            G2 = 106
            B2 = 83
            ennemies_pic.BackColor = Color.White

        ElseIf ennemies_combo.SelectedItem = "Yellow" Then
            R2 = 168
            G2 = 42
            B2 = 48
            ennemies_pic.BackColor = Color.Yellow

        End If

#End Region

        If Feed_ok.Checked = True Then
            a.WriteInteger(a.ReadInteger(&H10AA27C) + &H18, (R & G1 & B & 1))
            a.WriteInteger(a.ReadInteger(&H10AC188) + &H18, (R2 & G2 & B2 & 1))
        ElseIf Feed_ok.Checked = False Then
            a.WriteInteger(a.ReadInteger(&H10AA27C) + &H18, (165 & 48 & 42 & 1))
            a.WriteInteger(a.ReadInteger(&H10AC188) + &H18, (180 & 48 & 42 & 1))
        End If
#End Region

    End Sub



#End Region

#Region "YTB MPGH Twitter Links "

    Private Sub mpghlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles mpghlink.LinkClicked
        Process.Start("https://www.mpgh.net/forum/member.php?u=3815157")
    End Sub

#End Region

    Private Sub Theater_Timer_Tick(sender As Object, e As EventArgs) Handles Theater_Timer.Tick
#Region "DOF"
        If DOF_On.Checked = True Then
            a.WriteFloat((z_on), 0)
            a.WriteFloat((zz_fblur), (fblur.Value))
            a.WriteFloat((zz_nblur), (nblur.Value))
            a.WriteFloat((zz_fstart), (fstart.Value))
            a.WriteFloat((zz_nstart), (nstart.Value))
            a.WriteFloat((zz_fend), (fend.Value))
            a.WriteFloat((zz_nend), (nend.Value))

            a.WriteFloat((zz_fblur2), (fblur.Value))
            a.WriteFloat((zz_nblur2), (nblur.Value))
            a.WriteFloat((zz_fstart2), (fstart.Value))
            a.WriteFloat((zz_nstart2), (nstart.Value))
            a.WriteFloat((zz_fend2), (fend.Value))
            a.WriteFloat((zz_nend2), (nend.Value))

        ElseIf DOF_On.Checked = False Then
            a.WriteFloat(a.ReadInteger(z_on) + DVAR, 1)
        End If
#End Region
#Region "SSAO"
        If SAO_enable.Checked = True Then
            a.WriteFloat(a.ReadInteger(SS_Scale) + DVAR, (SAO_Scale.Value))
            a.WriteFloat(a.ReadInteger(SS_Radius) + DVAR, (SAO_Radius.Value))
        ElseIf SAO_enable.Checked = False Then
            a.WriteFloat(a.ReadInteger(SS_Scale) + DVAR, 0)
            a.WriteFloat(a.ReadInteger(SS_Radius) + DVAR, 0)
        End If
#End Region
#Region "GreenScreen"
        If GScom.SelectedItem = "Alien" Then
            I = 81
            O = 255

        ElseIf GScom.SelectedItem = "Aqua" Then
            I = 100
            O = 255

        ElseIf GScom.SelectedItem = "Blue" Then
            I = 220
            O = 255

        ElseIf GScom.SelectedItem = "GreenLime" Then
            I = 20
            O = 255

        ElseIf GScom.SelectedItem = "Morning" Then
            I = 255
            O = 255

        ElseIf GScom.SelectedItem = "Orange" Then
            I = 15
            O = 255

        ElseIf GScom.SelectedItem = "Red" Then
            I = 5
            O = 255

        ElseIf GScom.SelectedItem = "Purple" Then
            I = 110
            O = 255

        ElseIf GScom.SelectedItem = "Yellow" Then
            I = 0
            O = 255
            U = 33

        End If

        If GScom.SelectedItem = "None" Or GScom.Text = "" Then
            a.WriteInteger(a.ReadInteger(&H3455780) + &H18, 1024) 'modellimit
            a.WriteInteger(a.ReadInteger(&H34559E4) + &H18, (0 & 0 & 0 & 0)) 'ClearColor
            a.WriteInteger(a.ReadInteger(&H34559BC) + &H18, (0 & 0 & 0 & 0)) 'ClearColor2
        Else

            a.WriteInteger(a.ReadInteger(&H3455780) + &H18, 0) 'modellimit
            a.WriteInteger(a.ReadInteger(&H34559E4) + &H18, (I & O & 0 & 0)) 'ClearColor
            a.WriteInteger(a.ReadInteger(&H34559BC) + &H18, (I & O & 0 & 0)) 'ClearColor2

        End If

#End Region

    End Sub

    Private Sub Fog_Timer_Tick(sender As Object, e As EventArgs) Handles Fog_Timer.Tick

#Region "Color Wheel"
        Dim MyBackColor As New Bitmap(16, 16)
        Dim GG As Graphics = Graphics.FromImage(MyBackColor) : GG.FillRectangle(New SolidBrush(CM.Color), 0, 0, 16, 16) : GList.Images.Add(MyBackColor)
        Dim GG2 As Graphics = Graphics.FromImage(MyBackColor) : GG.FillRectangle(New SolidBrush(CM2.Color), 0, 0, 16, 16) : GList.Images.Add(MyBackColor)
        Dim CL As Color = CM.Color
        Dim CL2 As Color = CM2.Color

        If SyncColors.Checked = True Then
            FBC1.Value = CL.R
            FBC2.Value = CL.G
            FBC3.Value = CL.B
            FFC1.Value = CL.R
            FFC2.Value = CL.G
            FFC3.Value = CL.B
        ElseIf SyncColors.Checked = False Then
            FBC1.Value = CL.R
            FBC2.Value = CL.G
            FBC3.Value = CL.B
            FFC1.Value = CL2.R
            FFC2.Value = CL2.G
            FFC3.Value = CL2.B
        End If
#End Region

#Region "Gmzorz + Perso config"
        a.Process_Handle("t6mp")
        If GmzorzConfig.Checked = True Then

            If foggmzor.SelectedItem = "Custom Config" Then

            ElseIf foggmzor.SelectedItem = "FoggyDay" Then
                fogStart.Value = 150
                fogDistance.Value = 1000
                fogHeight.Value = 5000000
                fogBias.Value = 1
                FBC1.Value = 10
                FBC2.Value = 10
                FBC3.Value = 10
                fogBaseExp.Value = 1
                FFC1.Value = 10
                FFC2.Value = 10
                FFC3.Value = 10
                fogFarExp.Value = 1

            ElseIf foggmzor.SelectedItem = "Aqua" Then
                fogStart.Value = 60
                fogDistance.Value = 1000
                fogHeight.Value = 500
                fogBias.Value = 1
                FBC1.Value = 10
                FBC2.Value = 15
                FBC3.Value = 20
                fogBaseExp.Value = 1
                FFC1.Value = 10
                FFC2.Value = 15
                FFC3.Value = 20
                fogFarExp.Value = 1


            ElseIf foggmzor.SelectedItem = "PitchBlack" Then
                fogStart.Value = 50
                fogDistance.Value = 100
                fogHeight.Value = 1200
                fogBias.Value = 1
                FBC1.Value = 0
                FBC2.Value = 0
                FBC3.Value = 0
                fogBaseExp.Value = 1
                FFC1.Value = 0
                FFC2.Value = 0
                FFC3.Value = 0
                fogFarExp.Value = 1

            ElseIf foggmzor.SelectedItem = "Denpa" Then
                fogStart.Value = 100
                fogDistance.Value = 10000
                fogHeight.Value = 10000000
                fogBias.Value = 1
                FBC1.Value = 40
                FBC2.Value = 20
                FBC3.Value = 30
                fogBaseExp.Value = 1
                FFC1.Value = 40
                FFC2.Value = 20
                FFC3.Value = 30
                fogFarExp.Value = 1

            ElseIf foggmzor.SelectedItem = "Forest fire" Then
                fogStart.Value = 100
                fogDistance.Value = 3000
                fogHeight.Value = 1000
                fogBias.Value = 1
                FBC1.Value = 40
                FBC2.Value = 10
                FBC3.Value = 5
                fogBaseExp.Value = 1
                FFC1.Value = 40
                FFC2.Value = 10
                FFC3.Value = 5
                fogFarExp.Value = 1

            ElseIf foggmzor.SelectedItem = "Smog" Then
                fogStart.Value = 100
                fogDistance.Value = 300
                fogHeight.Value = 10000
                fogBias.Value = 1
                FBC1.Value = 1
                FBC2.Value = 1
                FBC3.Value = 1
                fogBaseExp.Value = 1
                FFC1.Value = 1
                FFC2.Value = 1
                FFC3.Value = 1
                fogFarExp.Value = 1

            ElseIf foggmzor.SelectedItem = "Buffer" Then
                fogStart.Value = 200
                fogDistance.Value = 36000
                fogHeight.Value = 18070
                fogBias.Value = 37
                FBC1.Value = 12
                FBC2.Value = 12
                FBC3.Value = 12
                fogBaseExp.Value = 1
                FFC1.Value = 12
                FFC2.Value = 12
                FFC3.Value = 12
                fogFarExp.Value = 1
            End If
        ElseIf GmzorzConfig.Checked = False Then
            fogStart.Value = 200
            fogDistance.Value = 36631
            fogHeight.Value = 10702
            fogBias.Value = 199
            FBC1.Value = 5
            FBC2.Value = 5
            FBC3.Value = 5
            fogBaseExp.Value = (8 / 10)
            FFC1.Value = 5
            FFC2.Value = 5
            FFC3.Value = 5
            fogFarExp.Value = (8 / 10)

        End If
#End Region

#Region "FOG"
        a.WriteFloat((f_start), (fogStart.Value))
        a.WriteFloat((f_distance), (fogDistance.Value))
        a.WriteFloat((f_height), (fogHeight.Value))
        a.WriteFloat((f_bias), (-fogBias.Value - 1))
        a.WriteFloat((f_baseExp), (fogBaseExp.Value))
        a.WriteFloat((f_farExp), (fogFarExp.Value))

        a.WriteFloat((f_FBR), (FBC1.Value))
        a.WriteFloat((f_FBG), (FBC2.Value))
        a.WriteFloat((f_FBB), (FBC3.Value))

        a.WriteFloat((f_FFR), (FFC1.Value))
        a.WriteFloat((f_FFG), (FFC2.Value))
        a.WriteFloat((f_FFB), (FFC3.Value))
#End Region

    End Sub

    Private Sub Sun_Timer_Tick(sender As Object, e As EventArgs) Handles Sun_Timer.Tick

#Region "Sun tab"
        Dim MyBackColor As New Bitmap(16, 16)
        Dim GG3 As Graphics = Graphics.FromImage(MyBackColor) : GG3.FillRectangle(New SolidBrush(CM2.Color), 0, 0, 16, 16) : GList.Images.Add(MyBackColor)
        Dim CL3 As Color = CM3.Color
        a.WriteFloat(a.ReadInteger(sky_rortation) + DVAR, (SkyR.Value))
        a.WriteFloat(a.ReadInteger(sky_transition) + DVAR, (SkyT.Value / 100))
        a.WriteFloat(a.ReadInteger(night_sky) + DVAR, (SkyB.Value) / 100)
        a.WriteFloat(a.ReadInteger(night_sky2) + DVAR, (SkyB.Value) / 100)
        a.WriteFloat(a.ReadInteger(red_sky) + DVAR, (SkyTemp.Value))

        a.WriteFloat((sunX1), -Sun_X.Value)
        a.WriteFloat((sunX2), -Sun_X.Value)
        a.WriteFloat((sunY1), Sun_Y.Value)
        a.WriteFloat((sunY2), Sun_Y.Value)


        a.WriteFloat((light_color_R1), CL3.R)
        a.WriteFloat((light_color_G1), CL3.G)
        a.WriteFloat((light_color_B1), CL3.B)
        a.WriteFloat((light_color_R2), CL3.R)
        a.WriteFloat((light_color_G2), CL3.G)
        a.WriteFloat((light_color_B2), CL3.B)
        Light_color_lbl.Text = (" R " + CL3.R.ToString() + " ; " + " G " + CL3.G.ToString() + " ; " + " B " + CL3.B.ToString() + " ;")
#End Region

    End Sub

#Region "           CHEAT         "
    Private Sub NC_Timer_Tick(sender As Object, e As EventArgs) Handles NC_Timer.Tick
        Dim img_default As String = Application.StartupPath + "\image\default.png"
        If ANH.Checked = True Then
            If Uav.Checked = True Then
                a.WriteInteger(my_vsat, 1)
            ElseIf Uav.Checked = False Then
                a.WriteInteger(my_vsat, 0)
            End If
            If Recoil.Checked = True Then
                If a.ReadInteger(my_recoil) <> 0 Then
                    a.WriteInteger(my_recoil, 0)
                End If
            End If



            If greenplayer.Checked = True Then
                If player1.Checked = True Then
                    a.WriteInteger(a.ReadInteger(bloomTweaks) + DVAR, 1)
                ElseIf player2.Checked = True Then
                    a.WriteInteger(a.ReadInteger(bloomTweaks) + DVAR, 0)
                End If



                a.WriteFloat((HLSR), (playerR.Value))
                a.WriteFloat((HLSG), (playerG.Value))
                a.WriteFloat((HLSB), (playerB.Value))

            ElseIf greenplayer.Checked = False Then

                a.WriteFloat((HLSR), 1)
                a.WriteFloat((HLSG), 1)
                a.WriteFloat((HLSB), 1)



            End If

        ElseIf ANH.Checked = False Then

        End If


    End Sub
#Region "      \\ OLD // Compact v2.0 picture box \\ OLD //"
    'Private Sub Preview_butt_Click(sender As Object, e As EventArgs) Handles Preview_butt.Click
    '    playercolor()
    '    PictureBox2.Visible = False
    '    PictureBox1.Visible = True
    'End Sub

    'Private Sub playercolor()
    '    Dim img As String = Application.StartupPath + "\image\FBI_Sniper_model_BOII.png"
    '    Dim bmp As Bitmap = New Bitmap(img)
    '    PictureBox1.Image = Image.FromFile(img)
    '    Dim width As Integer = bmp.Width
    '    Dim height As Integer = bmp.Height
    '    Dim rbmp As Bitmap = New Bitmap(bmp)
    '    Dim gbmp As Bitmap = New Bitmap(bmp)
    '    Dim bbmp As Bitmap = New Bitmap(bmp)

    '    For y As Integer = 0 To height - 1

    '        For x As Integer = 0 To width - 1
    '            Dim p As Color = bmp.GetPixel(x, y)
    '            Dim a As Integer = p.A
    '            Dim r As Integer = p.R
    '            Dim g As Integer = p.G
    '            Dim b As Integer = p.B
    '            rbmp.SetPixel(x, y, Color.FromArgb(a, playerR.Value, playerG.Value, playerB.Value))

    '            PictureBox1.Image = rbmp
    '        Next
    '    Next

    'End Sub
#End Region
#End Region


    Private Sub Info_button_Click(sender As Object, e As EventArgs) Handles Info_button.Click
        MessageBox.Show("This Cheat has been made by :" + vbNewLine + "Designed & Coding by LINDRA" + vbNewLine + "Credits for some Offsets : Jordnel, Hydra, Gmzorz", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#Region "Save and load "
    Private Sub Save_button_Click(sender As Object, e As EventArgs) Handles Save_button.Click
        My.Settings.fov = Fov_Bar.Value
        My.Settings.fovs = FOVS_Bar.Value
        My.Settings.fps = FPS_Bar.Value
        My.Settings.gunxcheck = GunX_Box.Checked
        My.Settings.gunycheck = GunY_Box.Checked
        My.Settings.gunzcheck = GunZ_Box.Checked
        My.Settings.gunxbar = GunX_Bar.Value
        My.Settings.gunybar = GunY_Bar.Value
        My.Settings.gunzbar = GunZ_Bar.Value
        My.Settings.icontext = Icon_txt.Text
        My.Settings.ranktext = Rank_txt.Text
        My.Settings.nametext = Names_txt.Text
        My.Settings.rankcheck = R_Rank.Checked
        My.Settings.namecheck = R_Name.Checked
        My.Settings.crosscheck = R_crosshair.Checked
        My.Settings.guncheck = R_Gun.Checked
        My.Settings.ddcheck = R_2d.Checked
        My.Settings.chatcheck = nochat.Checked
        My.Settings.colorcheck = cg_color_activate.Checked
        My.Settings.tempbar = temp.Value
        My.Settings.saturation = saturation.Value
        My.Settings.alliesbox = Allies_combo.SelectedText
        My.Settings.ennemiesbox = ennemies_combo.SelectedText
        My.Settings.greenscreenbox = GScom.SelectedText
        My.Settings.noplayercheck = R_Player.Checked
        My.Settings.dofenablecheck = DOF_On.Checked
        My.Settings.farblur = fblur.Value
        My.Settings.nearblur = nblur.Value
        My.Settings.farstart = fstart.Value
        My.Settings.nearstart = nstart.Value
        My.Settings.farend = fend.Value
        My.Settings.nearend = nend.Value
        My.Settings.saocheck = SAO_enable.Checked
        My.Settings.intensity = SAO_Intensity.Value
        My.Settings.bias = SAO_Bias.Value
        My.Settings.radius = SAO_Radius.Value
        My.Settings.scalebar = SAO_Scale.Value
        My.Settings.gmzorzcheck = GmzorzConfig.Checked
        My.Settings.gmzorzbox = foggmzor.SelectedText
        My.Settings.sync = SyncColors.Checked
        My.Settings.SkyTemp = SkyTemp.Value
        My.Settings.SkyT = SkyT.Value
        My.Settings.SkyR = SkyR.Value
        My.Settings.SkyB = SkyB.Value
        My.Settings.SunX = Sun_X.Value
        My.Settings.SunY = Sun_Y.Value
        My.Settings.botenable = Bot_Rennamer_on.Checked
        My.Settings.DSWM = DSWM.Checked
        My.Settings.SWM = SWM.Checked
        My.Settings.myHealth = your_health.Value
        My.Settings.botHealth = bot_health.Value
        My.Settings.CT0 = BotT0.Text
        My.Settings.CT1 = BotT1.Text
        My.Settings.CT2 = BotT2.Text
        My.Settings.CT3 = BotT3.Text
        My.Settings.CT4 = BotT4.Text
        My.Settings.CT5 = BotT5.Text
        My.Settings.CT6 = BotT6.Text
        My.Settings.CT7 = BotT7.Text
        My.Settings.CT8 = BotT8.Text
        My.Settings.CT9 = BotT9.Text
        My.Settings.CT10 = BotT10.Text
        My.Settings.CT11 = BotT11.Text
        My.Settings.BN0 = BotN0.Text
        My.Settings.BN1 = BotN1.Text
        My.Settings.BN2 = BotN2.Text
        My.Settings.BN3 = BotN3.Text
        My.Settings.BN4 = BotN4.Text
        My.Settings.BN5 = BotN5.Text
        My.Settings.BN6 = BotN6.Text
        My.Settings.BN7 = BotN7.Text
        My.Settings.BN8 = BotN8.Text
        My.Settings.BN9 = BotN9.Text
        My.Settings.BN10 = BotN10.Text
        My.Settings.BN11 = BotN11.Text
        My.Settings.weaponcheck = Weapons_on.Checked
        My.Settings.weapontext = weapon_choose.SelectedText
        My.Settings.camotext = camo_box.SelectedText


    End Sub

    Private Sub Load_button_Click(sender As Object, e As EventArgs) Handles Load_button.Click
        Fov_Bar.Value = My.Settings.fov
        FOVS_Bar.Value = My.Settings.fovs
        FPS_Bar.Value = My.Settings.fps
        GunX_Box.Checked = My.Settings.gunxcheck
        GunY_Box.Checked = My.Settings.gunycheck
        GunZ_Box.Checked = My.Settings.gunzcheck
        GunX_Bar.Value = My.Settings.gunxbar
        GunY_Bar.Value = My.Settings.gunybar
        GunZ_Bar.Value = My.Settings.gunzbar
        Icon_txt.Text = My.Settings.icontext
        Rank_txt.Text = My.Settings.ranktext
        Names_txt.Text = My.Settings.nametext
        R_Rank.Checked = My.Settings.rankcheck
        R_Name.Checked = My.Settings.namecheck
        R_crosshair.Checked = My.Settings.crosscheck
        R_Gun.Checked = My.Settings.guncheck
        R_2d.Checked = My.Settings.ddcheck
        nochat.Checked = My.Settings.chatcheck
        cg_color_activate.Checked = My.Settings.colorcheck
        temp.Value = My.Settings.tempbar
        saturation.Value = My.Settings.saturation
        Allies_combo.SelectedText = My.Settings.alliesbox
        ennemies_combo.SelectedText = My.Settings.ennemiesbox
        GScom.SelectedText = My.Settings.greenscreenbox
        R_Player.Checked = My.Settings.noplayercheck
        DOF_On.Checked = My.Settings.dofenablecheck
        fblur.Value = My.Settings.farblur
        nblur.Value = My.Settings.nearblur
        fstart.Value = My.Settings.farstart
        nstart.Value = My.Settings.nearstart
        fend.Value = My.Settings.farend
        nend.Value = My.Settings.nearend
        SAO_enable.Checked = My.Settings.saocheck
        SAO_Intensity.Value = My.Settings.intensity
        SAO_Bias.Value = My.Settings.bias
        SAO_Radius.Value = My.Settings.radius
        SAO_Scale.Value = My.Settings.scalebar
        GmzorzConfig.Checked = My.Settings.gmzorzcheck
        foggmzor.SelectedText = My.Settings.gmzorzbox
        SyncColors.Checked = My.Settings.sync
        SkyTemp.Value = My.Settings.SkyTemp
        SkyT.Value = My.Settings.SkyT
        SkyR.Value = My.Settings.SkyR
        SkyB.Value = My.Settings.SkyB
        Sun_X.Value = My.Settings.SunX
        Sun_Y.Value = My.Settings.SunY
        Bot_Rennamer_on.Checked = My.Settings.botenable
        DSWM.Checked = My.Settings.DSWM
        SWM.Checked = My.Settings.SWM
        your_health.Value = My.Settings.myHealth
        bot_health.Value = My.Settings.botHealth
        BotT0.Text = My.Settings.CT0
        BotT1.Text = My.Settings.CT1
        BotT2.Text = My.Settings.CT2
        BotT3.Text = My.Settings.CT3
        BotT4.Text = My.Settings.CT4
        BotT5.Text = My.Settings.CT5
        BotT6.Text = My.Settings.CT6
        BotT7.Text = My.Settings.CT7
        BotT8.Text = My.Settings.CT8
        BotT9.Text = My.Settings.CT9
        BotT10.Text = My.Settings.CT10
        BotT11.Text = My.Settings.CT11
        BotN0.Text = My.Settings.BN0
        BotN1.Text = My.Settings.BN1
        BotN2.Text = My.Settings.BN2
        BotN3.Text = My.Settings.BN3
        BotN4.Text = My.Settings.BN4
        BotN5.Text = My.Settings.BN5
        BotN6.Text = My.Settings.BN6
        BotN7.Text = My.Settings.BN7
        BotN8.Text = My.Settings.BN8
        BotN9.Text = My.Settings.BN9
        BotN10.Text = My.Settings.BN10
        BotN11.Text = My.Settings.BN11
        Weapons_on.Checked = My.Settings.weaponcheck
        weapon_choose.SelectedText = My.Settings.weapontext
        camo_box.SelectedText = My.Settings.camotext
    End Sub
#End Region

    Private Sub Bot_Rennamer_on_CheckedChanged(sender As Object) Handles Bot_Rennamer_on.CheckedChanged
        If Bot_Rennamer_on.Checked = True Then
            If SWM.Checked = True Then
                MessageBox.Show("Be sure to be in a private looby to use this tab", "Important infos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf DSWM.Checked = True Then
            End If
            Bot_Rennamer_Timer.Start()
            If Bot_Rennamer_on.Checked = False Then
                Bot_Rennamer_Timer.Stop()
                allowname = 0
            End If
        End If
    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
#Region "Minnimized notifyIcon"

        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(1000, "MultiPlayer Bo2 Compact v2.1", "You have minnimized Bo2 Zombie form", ToolTipIcon.Info)
        Else
        End If
#End Region
    End Sub





#Region "Bot Rennamer "


    Private Sub Bot_Rennamer_Timer_Tick(sender As Object, e As EventArgs) Handles Bot_Rennamer_Timer.Tick
        If allowname <> 0 Then

            If BotT0.Text = "" Then
                a.WriteInteger(Arc0, 0)
            Else
                a.WriteString(Arc0, BotT0.Text)
            End If

            If BotT1.Text = "" Then
                a.WriteInteger(Arc1, 0)
            Else
                a.WriteString(Arc1, BotT1.Text)
            End If

            If BotT2.Text = "" Then
                a.WriteInteger(Arc2, 0)
            Else
                a.WriteString(Arc2, BotT2.Text)
            End If

            If BotT3.Text = "" Then
                a.WriteInteger(Arc3, 0)
            Else
                a.WriteString(Arc3, BotT3.Text)
            End If

            If BotT4.Text = "" Then
                a.WriteInteger(Arc4, 0)
            Else
                a.WriteString(Arc4, BotT4.Text)
            End If

            If BotT5.Text = "" Then
                a.WriteInteger(Arc5, 0)
            Else
                a.WriteString(Arc5, BotT5.Text)
            End If

            If BotT6.Text = "" Then
                a.WriteInteger(Arc6, 0)
            Else
                a.WriteString(Arc6, BotT6.Text)
            End If

            If BotT7.Text = "" Then
                a.WriteInteger(Arc7, 0)
            Else
                a.WriteString(Arc7, BotT7.Text)
            End If

            If BotT8.Text = "" Then
                a.WriteInteger(Arc8, 0)
            Else
                a.WriteString(Arc8, BotT8.Text)
            End If

            If BotT9.Text = "" Then
                a.WriteInteger(Arc9, 0)
            Else
                a.WriteString(Arc9, BotT9.Text)
            End If

            If BotT10.Text = "" Then
                a.WriteInteger(Arc10, 0)
            Else
                a.WriteString(Arc10, BotT10.Text)
            End If

            If BotT11.Text = "" Then
                a.WriteInteger(Arc11, 0)
            Else
                a.WriteString(Arc11, BotT11.Text)
            End If


            a.WriteString(bot_name0, BotN0.Text)
            a.WriteString(bot_name1, BotN1.Text)
            a.WriteString(bot_name2, BotN2.Text)
            a.WriteString(bot_name3, BotN3.Text)
            a.WriteString(bot_name4, BotN4.Text)
            a.WriteString(bot_name5, BotN5.Text)
            a.WriteString(bot_name6, BotN6.Text)
            a.WriteString(bot_name7, BotN7.Text)
            a.WriteString(bot_name8, BotN8.Text)
            a.WriteString(bot_name9, BotN9.Text)
            a.WriteString(bot_name10, BotN10.Text)
            a.WriteString(bot_name11, BotN11.Text)


        Else
        End If

        If Enable_health.Checked = True Then
            a.WriteInteger((health1 + 0 * health_size), your_health.Value)
            a.WriteInteger((health2 + 0 * health_size), your_health.Value)

            a.WriteInteger((health1 + 1 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 1 * health_size), bot_health.Value)

            a.WriteInteger((health1 + 2 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 2 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 3 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 3 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 4 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 4 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 5 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 5 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 6 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 6 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 7 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 7 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 8 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 8 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 9 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 9 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 10 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 10 * health_size), bot_health.Value)
            a.WriteInteger((health1 + 11 * health_size), bot_health.Value)
            a.WriteInteger((health2 + 11 * health_size), bot_health.Value)
        Else

        End If

    End Sub

    Private Sub Refresh_names_Click(sender As Object, e As EventArgs) Handles Refresh_names.Click
        a.Process_Handle("t6mp")
        bot0.Text = a.ReadString(Arc0, 4) + "  " + a.ReadString(bot_name0, 10)

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 1 * main_size)) Then
            bot1.Text = a.ReadString(Arc1, 4) + "  " + a.ReadString(bot_name1, 10)
        Else
            bot6.Text = a.ReadString(Arc1, 4) + "  " + a.ReadString(bot_name1, 10)
        End If
        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 2 * main_size)) Then
            bot2.Text = a.ReadString(Arc2, 4) + "  " + a.ReadString(bot_name2, 10)
        Else
            bot7.Text = a.ReadString(Arc2, 4) + "  " + a.ReadString(bot_name2, 10)
        End If

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 3 * main_size)) Then
            bot3.Text = a.ReadString(Arc3, 4) + "  " + a.ReadString(bot_name3, 10)
        Else
            bot8.Text = a.ReadString(Arc3, 4) + "  " + a.ReadString(bot_name3, 10)
        End If

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 4 * main_size)) Then
            bot4.Text = a.ReadString(Arc4, 4) + "  " + a.ReadString(bot_name4, 10)
        Else
            bot9.Text = a.ReadString(Arc4, 4) + "  " + a.ReadString(bot_name4, 10)
        End If

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 5 * main_size)) Then
            bot5.Text = a.ReadString(Arc5, 4) + "  " + a.ReadString(bot_name5, 10)
        Else
            bot10.Text = a.ReadString(Arc5, 4) + "  " + a.ReadString(bot_name5, 10)
        End If


        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 6 * main_size)) Then
            bot1.Text = a.ReadString(Arc6, 4) + "  " + a.ReadString(bot_name6, 10)
        Else
            bot6.Text = a.ReadString(Arc6, 4) + "  " + a.ReadString(bot_name6, 10)
        End If
        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 7 * main_size)) Then
            bot2.Text = a.ReadString(Arc7, 4) + "  " + a.ReadString(bot_name7, 10)
        Else
            bot7.Text = a.ReadString(Arc7, 4) + "  " + a.ReadString(bot_name7, 10)
        End If

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 8 * main_size)) Then
            bot3.Text = a.ReadString(Arc8, 4) + "  " + a.ReadString(bot_name8, 10)
        Else
            bot8.Text = a.ReadString(Arc8, 4) + "  " + a.ReadString(bot_name8, 10)
        End If

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 9 * main_size)) Then
            bot4.Text = a.ReadString(Arc9, 4) + "  " + a.ReadString(bot_name9, 10)
        Else
            bot9.Text = a.ReadString(Arc9, 4) + "  " + a.ReadString(bot_name9, 10)
        End If

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 10 * main_size)) Then
            bot5.Text = a.ReadString(Arc10, 4) + "  " + a.ReadString(bot_name10, 10)
        Else
            bot10.Text = a.ReadString(Arc10, 4) + "  " + a.ReadString(bot_name10, 10)
        End If

        If a.ReadInteger((my_team + 0 * main_size)) = a.ReadInteger((my_team + 11 * main_size)) Then
            bot0.Text = a.ReadString(Arc11, 4) + "  " + a.ReadString(bot_name11, 10)
        Else
            bot11.Text = a.ReadString(Arc11, 4) + "  " + a.ReadString(bot_name11, 10)
        End If

    End Sub

    Private Sub Send_names_Click(sender As Object, e As EventArgs) Handles Send_names.Click
        allowname = 1

        a.WriteInteger(bot_name0, 0)
        a.WriteInteger(bot_name1, 0)
        a.WriteInteger(bot_name2, 0)
        a.WriteInteger(bot_name3, 0)
        a.WriteInteger(bot_name4, 0)
        a.WriteInteger(bot_name5, 0)
        a.WriteInteger(bot_name6, 0)
        a.WriteInteger(bot_name7, 0)
        a.WriteInteger(bot_name8, 0)
        a.WriteInteger(bot_name9, 0)
        a.WriteInteger(bot_name10, 0)
        a.WriteInteger(bot_name11, 0)
    End Sub
#End Region


    Private Sub Gun_Timer_Tick(sender As Object, e As EventArgs) Handles Gun_Timer.Tick

#Region "weapon choosen"
        If weapon_choose.SelectedIndex = 0 Then
            Gun_number = 2
        ElseIf weapon_choose.SelectedIndex = 1 Then
            Gun_number = 4
        ElseIf weapon_choose.SelectedIndex = 2 Then
            Gun_number = 6
        ElseIf weapon_choose.SelectedIndex = 3 Then
            Gun_number = 8
        ElseIf weapon_choose.SelectedIndex = 4 Then
            Gun_number = 10
        ElseIf weapon_choose.SelectedIndex = 5 Then
            Gun_number = 12
        ElseIf weapon_choose.SelectedIndex = 6 Then
            Gun_number = 14
        ElseIf weapon_choose.SelectedIndex = 7 Then
            Gun_number = 16
        ElseIf weapon_choose.SelectedIndex = 8 Then
            Gun_number = 20
        ElseIf weapon_choose.SelectedIndex = 9 Then
            Gun_number = 24
        ElseIf weapon_choose.SelectedIndex = 10 Then
            Gun_number = 28
        ElseIf weapon_choose.SelectedIndex = 11 Then
            Gun_number = 32
        ElseIf weapon_choose.SelectedIndex = 12 Then
            Gun_number = 36
        ElseIf weapon_choose.SelectedIndex = 13 Then
            Gun_number = 40
        ElseIf weapon_choose.SelectedIndex = 14 Then
            Gun_number = 44
        ElseIf weapon_choose.SelectedIndex = 15 Then
            Gun_number = 48
        ElseIf weapon_choose.SelectedIndex = 16 Then
            Gun_number = 52
        ElseIf weapon_choose.SelectedIndex = 17 Then
            Gun_number = 53
        ElseIf weapon_choose.SelectedIndex = 18 Then
            Gun_number = 54
        ElseIf weapon_choose.SelectedIndex = 19 Then
            Gun_number = 55
        ElseIf weapon_choose.SelectedIndex = 20 Then
            Gun_number = 56
        ElseIf weapon_choose.SelectedIndex = 21 Then
            Gun_number = 58
        ElseIf weapon_choose.SelectedIndex = 22 Then
            Gun_number = 60
        ElseIf weapon_choose.SelectedIndex = 23 Then
            Gun_number = 62
        ElseIf weapon_choose.SelectedIndex = 24 Then
            Gun_number = 64
        ElseIf weapon_choose.SelectedIndex = 25 Then
            Gun_number = 65
        ElseIf weapon_choose.SelectedIndex = 26 Then
            Gun_number = 66
        ElseIf weapon_choose.SelectedIndex = 27 Then
            Gun_number = 67
        ElseIf weapon_choose.SelectedIndex = 28 Then
            Gun_number = 68
        ElseIf weapon_choose.SelectedIndex = 29 Then
            Gun_number = 70
        ElseIf weapon_choose.SelectedIndex = 30 Then
            Gun_number = 72
        ElseIf weapon_choose.SelectedIndex = 31 Then
            Gun_number = 74
        ElseIf weapon_choose.SelectedIndex = 32 Then
            Gun_number = 76
        ElseIf weapon_choose.SelectedIndex = 33 Then
            Gun_number = 78
        ElseIf weapon_choose.SelectedIndex = 34 Then
            Gun_number = 79
        ElseIf weapon_choose.SelectedIndex = 35 Then
            Gun_number = 80
        ElseIf weapon_choose.SelectedIndex = 36 Then
            Gun_number = 81
        ElseIf weapon_choose.SelectedIndex = 37 Then
            Gun_number = 82
        ElseIf weapon_choose.SelectedIndex = 38 Then
            Gun_number = 84
        ElseIf weapon_choose.SelectedIndex = 39 Then
            Gun_number = 85
        ElseIf weapon_choose.SelectedIndex = 40 Then
            Gun_number = 86
        ElseIf weapon_choose.SelectedIndex = 41 Then
            Gun_number = 87
        ElseIf weapon_choose.SelectedIndex = 42 Then
            Gun_number = 89
        ElseIf weapon_choose.SelectedIndex = 43 Then
            Gun_number = 90
        ElseIf weapon_choose.SelectedIndex = 44 Then
            Gun_number = 91
        ElseIf weapon_choose.SelectedIndex = 45 Then
            Gun_number = 92
        ElseIf weapon_choose.SelectedIndex = 46 Then
            Gun_number = 93
        ElseIf weapon_choose.SelectedIndex = 47 Then
            Gun_number = 94
        ElseIf weapon_choose.SelectedIndex = 48 Then
            Gun_number = 95
        ElseIf weapon_choose.SelectedIndex = 49 Then
            Gun_number = 96
        ElseIf weapon_choose.SelectedIndex = 50 Then
            Gun_number = 98
        ElseIf weapon_choose.SelectedIndex = 51 Then
            Gun_number = 99
        ElseIf weapon_choose.SelectedIndex = 52 Then
            Gun_number = 103
        ElseIf weapon_choose.SelectedIndex = 53 Then
            Gun_number = 104
        ElseIf weapon_choose.SelectedIndex = 54 Then
            Gun_number = 102
        ElseIf weapon_choose.SelectedIndex = 55 Then
            Gun_number = 105
        ElseIf weapon_choose.SelectedIndex = 56 Then
            Gun_number = 110

        End If
#End Region

#Region "Camos Choosen"
        If camo_box.SelectedIndex = 0 Then
            Camo_number = 32768
        ElseIf camo_box.SelectedIndex = 1 Then
            Camo_number = 32770
        ElseIf camo_box.SelectedIndex = 2 Then
            Camo_number = 32769
        ElseIf camo_box.SelectedIndex = 3 Then
            Camo_number = 32771
        ElseIf camo_box.SelectedIndex = 4 Then
            Camo_number = 32772
        ElseIf camo_box.SelectedIndex = 5 Then
            Camo_number = 32773
        ElseIf camo_box.SelectedIndex = 6 Then
            Camo_number = 32774
        ElseIf camo_box.SelectedIndex = 7 Then
            Camo_number = 32775
        ElseIf camo_box.SelectedIndex = 8 Then
            Camo_number = 32776
        ElseIf camo_box.SelectedIndex = 9 Then
            Camo_number = 32777
        ElseIf camo_box.SelectedIndex = 10 Then
            Camo_number = 32778
        ElseIf camo_box.SelectedIndex = 11 Then
            Camo_number = 32779
        ElseIf camo_box.SelectedIndex = 12 Then
            Camo_number = 32780
        ElseIf camo_box.SelectedIndex = 13 Then
            Camo_number = 32781
        ElseIf camo_box.SelectedIndex = 14 Then
            Camo_number = 32782
        ElseIf camo_box.SelectedIndex = 15 Then
            Camo_number = 32783
        ElseIf camo_box.SelectedIndex = 16 Then
            Camo_number = 32784
        ElseIf camo_box.SelectedIndex = 17 Then
            Camo_number = 32785
        ElseIf camo_box.SelectedIndex = 18 Then
            Camo_number = 32915
        ElseIf camo_box.SelectedIndex = 19 Then
            Camo_number = 32786
        ElseIf camo_box.SelectedIndex = 20 Then
            Camo_number = 32917
        ElseIf camo_box.SelectedIndex = 21 Then
            Camo_number = 32918
        ElseIf camo_box.SelectedIndex = 22 Then
            Camo_number = 32791
        ElseIf camo_box.SelectedIndex = 23 Then
            Camo_number = 32920
        ElseIf camo_box.SelectedIndex = 24 Then
            Camo_number = 32793
        ElseIf camo_box.SelectedIndex = 25 Then
            Camo_number = 32794
        ElseIf camo_box.SelectedIndex = 26 Then
            Camo_number = 32795
        ElseIf camo_box.SelectedIndex = 27 Then
            Camo_number = 32796
        ElseIf camo_box.SelectedIndex = 28 Then
            Camo_number = 32797
        ElseIf camo_box.SelectedIndex = 29 Then
            Camo_number = 32798
        ElseIf camo_box.SelectedIndex = 30 Then
            Camo_number = 32799
        ElseIf camo_box.SelectedIndex = 31 Then
            Camo_number = 32802
        ElseIf camo_box.SelectedIndex = 32 Then
            Camo_number = 32803
        ElseIf camo_box.SelectedIndex = 33 Then
            Camo_number = 32804
        ElseIf camo_box.SelectedIndex = 34 Then
            Camo_number = 32805
        ElseIf camo_box.SelectedIndex = 35 Then
            Camo_number = 32806
        ElseIf camo_box.SelectedIndex = 36 Then
            Camo_number = 32935
        ElseIf camo_box.SelectedIndex = 37 Then
            Camo_number = 32916
        ElseIf camo_box.SelectedIndex = 38 Then
            Camo_number = 32808
        ElseIf camo_box.SelectedIndex = 39 Then
            Camo_number = 32809
        ElseIf camo_box.SelectedIndex = 40 Then
            Camo_number = 32810
        ElseIf camo_box.SelectedIndex = 41 Then
            Camo_number = 32511
        ElseIf camo_box.SelectedIndex = 42 Then
            Camo_number = 32813

        End If
#End Region

    End Sub

#Region "Host CHE"
    Private Sub W_Primary_Click(sender As Object, e As EventArgs) Handles W_Primary.Click
        If Weapons_on.Checked = True Then
            a.WriteInteger(weapon_P, Gun_number)
        Else
        End If
    End Sub

    Private Sub W_Secondary_Click(sender As Object, e As EventArgs) Handles W_Secondary.Click
        If Weapons_on.Checked = True Then
            a.WriteInteger(weapon_S, Gun_number)
        Else
        End If
    End Sub

    Private Sub P_Primary_Click(sender As Object, e As EventArgs) Handles P_Primary.Click
        If Weapons_on.Checked = True Then
            a.WriteInteger(Camo1, Camo_number)
        Else
        End If
    End Sub

    Private Sub C_Secondary_Click(sender As Object, e As EventArgs) Handles C_Secondary.Click
        If Weapons_on.Checked = True Then
            a.WriteInteger(Camo2, Camo_number)
        Else
        End If
    End Sub

    Private Sub C_Timer_Tick(sender As Object, e As EventArgs) Handles C_Timer.Tick
        If Spread.Checked = True Then
            a.WriteInteger(no_spread, 1 / 100)
        Else
            a.WriteInteger(no_spread, 6499999762 / 10000000000) ' need to be check
        End If

        If ReloadSpeed.Checked = True Then
            a.WriteInteger(no_reload, 1 / 100)
        Else
            a.WriteInteger(no_reload, 5 / 10)
        End If

        If RapideFire.Checked = True Then
            a.WriteInteger(no_FireRate, 1 / 100)
        Else
            a.WriteInteger(no_FireRate, 75 / 100)
        End If

        If AimSpeed.Checked = True Then
            a.WriteInteger(no_scopeFast, 1 / 100)
        Else
            a.WriteInteger(no_scopeFast, 5 / 10)
        End If

        If AllPerks.Checked = True Then
            a.WriteInteger(perk1, -1)
            a.WriteInteger(perk2, -1)
            a.WriteInteger(perk3, -1)
            a.WriteInteger(perk4, -1)
            a.WriteInteger(perk5, -1)
            a.WriteInteger(perk6, -1)
        ElseIf AllPerks.Checked = False Then
            a.WriteInteger(perk1, 7290880)
            a.WriteInteger(perk2, 33571072)
            a.WriteInteger(perk3, 7290880)
            a.WriteInteger(perk4, 33571072)
            a.WriteInteger(perk5, 7290880)
            a.WriteInteger(perk6, 33571072)
        End If

    End Sub
#End Region

End Class
