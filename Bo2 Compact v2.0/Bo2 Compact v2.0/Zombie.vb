Public Class Zombie
#Region "       Offsets     "
    Dim a As New WriterClass
    Dim Dvar_size As Integer = &H18
    Dim Main_size As Integer = &H31C

    Dim cg_fov As Integer = &H111810C
    Dim cg_fovscale As Integer = &H1116710
    Dim cg_gun_x As Integer = &H1129014
    Dim cg_gun_y As Integer = &H1128FF0
    Dim cg_gun_z As Integer = &H1128FFC
    Dim party_minplayer As Integer = &H127CD9C

    ' CE Stuff'
    Dim map_name As String = &H12BD218
    Dim party_maxplayer As Integer = &H2A28FE0

    Dim first_gun_ammo As Integer = &H2346ECC
    Dim second_gun_ammo As Integer = &H2346ED4
    Dim third_gun_ammo As Integer = &H2346EC8
    Dim first_gun_loader As Integer = &H2346E90
    Dim second_gun_loader As Integer = &H2346E98
    Dim nades As Integer = &H2346ED0
    Dim secondary_nades As Integer = &H2346ED8
    Dim Current_weapon_ID As Integer = &H2346C58


    Dim number_zombie As Integer = &H2334688
    Dim money As Integer = &H234C068
    Dim number_rounds As Integer = &H233FA10
    Dim zombie_health As Integer = &H21C9CD0


    Dim No_recoil As Integer = &H6F8754
    Dim health As Integer = &H21C5868
    Dim player_X As Integer = &H2346AC8
    Dim player_Y As Integer = &H2346AD0
    Dim player_Z As Integer = &H2346ACC
    Dim primary_ID As Integer = &H2346D04
    Dim secondary_ID As Integer = &H2346D3C

    '//'

#End Region

    Private Sub Zombie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status_Timer.Start()
        Host_Timer.Start()
        Non_Host_Timer.Start()
        a.Process_Handle("t6zm")
        generate_name()
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

#Region "Notificon"

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        NotifyIcon1.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub
#End Region

    Private Sub Status_Timer_Tick(sender As Object, e As EventArgs) Handles Status_Timer.Tick

#Region "Map Name"
        Dim my_map As String = a.ReadString(map_name, 25)

        If my_map.Contains("zm_transit_gump_town") Then
            mapName.Text = "Town"
        ElseIf my_map.Contains("zm_transit_gump_diner") Then
            mapName.Text = "Diner"
        ElseIf my_map.Contains("zm_transit_gump_busstation") Then
            mapName.Text = "Bus Depot"
        ElseIf my_map.Contains("zm_transit") Then
            mapName.Text = "Tranzit"
        ElseIf my_map.Contains("zm_transit_gump_farm") Then
            mapName.Text = "Farm"
        ElseIf my_map.Contains("zm_tomb") Then
            mapName.Text = "Origins"
        ElseIf my_map.Contains("zm_castle") Then
            mapName.Text = "Der Eisendrache"
        ElseIf my_map.Contains("zm_stalingrad") Then
            mapName.Text = "Der Gorod Krovi"
        ElseIf my_map.Contains("zm_theater") Then
            mapName.Text = "Kino der Toten"
        ElseIf my_map.Contains("zm_cosmodrome") Then
            mapName.Text = "Ascension"
        ElseIf my_map.Contains("zm_moon") Then
            mapName.Text = "Moon"
        ElseIf my_map.Contains("zm_prototype") Then
            mapName.Text = "Nacht der Untoten"
        ElseIf my_map.Contains("zm_genesis") Then
            mapName.Text = "Revelations"
        ElseIf my_map.Contains("zm_zod") Then
            mapName.Text = "Shadows of Evil"
        ElseIf my_map.Contains("zm_temple") Then
            mapName.Text = "Shangri-La"
        ElseIf my_map.Contains("zm_sumpf") Then
            mapName.Text = "Shi No Numa"
        ElseIf my_map.Contains("zm_factory") Then
            mapName.Text = "The Giant"
        ElseIf my_map.Contains("zm_asylum") Then
            mapName.Text = "Verrückt"
        ElseIf my_map.Contains("zm_island") Then
            mapName.Text = "Zetsubou No Shima"
        ElseIf my_map.Contains("zm_nuked") Then
            mapName.Text = "Nuketown"
        Else
            mapName.Text = "Not in a party"
        End If
#End Region

#Region "Number of zombie & zombie health"
        ZombieNB.Text = a.ReadInteger(number_zombie) '/ number of zombies
        ZombieHh.Text = a.ReadInteger(zombie_health) '/  zombies health based on the first zombie
        ZombieRd.Text = a.ReadInteger(number_rounds) '/ number of rounds
#End Region

#Region "in-game status"
        Dim p() As Process
        p = Process.GetProcessesByName("t6zm")
        If p.Count > 0 Then
            in_game.ForeColor = Color.Green
            in_game.Text = "In-Game"
        Else
            in_game.Text = "Not In-Game"
            in_game.ForeColor = Color.Red
        End If
#End Region

    End Sub
#Region "       HOST        "


    Private Sub Host_Timer_Tick(sender As Object, e As EventArgs) Handles Host_Timer.Tick
        If Force_Host.Checked = True Then
            a.WriteInteger(a.ReadInteger(party_minplayer) + Dvar_size, 1) '/ party_minplayer = 1
        Else
            a.WriteInteger(a.ReadInteger(party_minplayer) + Dvar_size, 4) '/ party_minplayer = 4
        End If
        If inf_ammo.Checked = True Then
            a.WriteInteger(first_gun_ammo, 20) '/ freeze first gun ammos to 20
            a.WriteInteger(second_gun_ammo, 20) '/ freeze second gun ammos to 20
            a.WriteInteger(third_gun_ammo, 20) '/ freeze third gun ammos to 20
        Else

        End If
        If inf_gre.Checked = True Then
            a.WriteInteger(nades, 8) '/ freeze nades to 20
            a.WriteInteger(secondary_nades, 8) '/ freeze secondary nades to 20
        End If

        P1_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (0 * Main_size)).ToString) '/ weapon ID of the first player /  etc
        P2_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (1 * Main_size)).ToString)
        P3_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (2 * Main_size)).ToString)
        P4_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (3 * Main_size)).ToString)
        P5_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (4 * Main_size)).ToString)
        P6_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (5 * Main_size)).ToString)
        P7_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (6 * Main_size)).ToString)
        P8_CW.Text = ("Current Weapon ID -> " + a.ReadInteger(Current_weapon_ID + (7 * Main_size)).ToString)

    End Sub


    Private Sub zm_lobby_size_Click(sender As Object, e As EventArgs) Handles zm_lobby_size.Click
        a.WriteInteger(party_maxplayer, lobby_size.Value) ' / party_maxplayer = (number of people you wants to be in the lobby)
    End Sub

#Region "Player 1"
    Private Sub nb_round_Click(sender As Object, e As EventArgs) Handles nb_round.Click
        a.WriteInteger(number_rounds, Convert.ToInt32(round.Text))
    End Sub

    Private Sub zm_P1_Money_Click(sender As Object, e As EventArgs) Handles zm_P1_Money.Click
        a.WriteInteger((money + (0 * Main_size)), P1_Money.Text)
    End Sub

    Private Sub zm_P1_SW_Click(sender As Object, e As EventArgs) Handles zm_P1_SW.Click
        a.WriteInteger((secondary_ID + (0 * Main_size)), P1_SW.Text)
    End Sub

    Private Sub zm_P1_PW_Click(sender As Object, e As EventArgs) Handles zm_P1_PW.Click
        a.WriteInteger((primary_ID + (0 * Main_size)), P1_PW.Text)
    End Sub

    Private Sub TP_P2_Click(sender As Object, e As EventArgs) Handles TP_P2.Click
        a.WriteInteger(player_X + (1 * Main_size), a.ReadInteger(player_X))
        a.WriteInteger(player_Y + (1 * Main_size), a.ReadInteger(player_Y))
        a.WriteInteger(player_Z + (1 * Main_size), a.ReadInteger(player_Z))
    End Sub

    Private Sub TP_P3_Click(sender As Object, e As EventArgs) Handles TP_P3.Click
        a.WriteInteger(player_X + (2 * Main_size), a.ReadInteger(player_X))
        a.WriteInteger(player_Y + (2 * Main_size), a.ReadInteger(player_Y))
        a.WriteInteger(player_Z + (2 * Main_size), a.ReadInteger(player_Z))
    End Sub

    Private Sub TP_P4_Click(sender As Object, e As EventArgs) Handles TP_P4.Click
        a.WriteInteger(player_X + (3 * Main_size), a.ReadInteger(player_X))
        a.WriteInteger(player_Y + (3 * Main_size), a.ReadInteger(player_Y))
        a.WriteInteger(player_Z + (3 * Main_size), a.ReadInteger(player_Z))
    End Sub

    Private Sub TP_to_P2_Click(sender As Object, e As EventArgs) Handles TP_to_P2.Click
        a.WriteInteger(player_X, a.ReadInteger(player_X + (1 * Main_size)))
        a.WriteInteger(player_Y, a.ReadInteger(player_Y + (1 * Main_size)))
        a.WriteInteger(player_Z, a.ReadInteger(player_Z + (1 * Main_size)))
    End Sub

    Private Sub TP_to_P3_Click(sender As Object, e As EventArgs) Handles TP_to_P3.Click
        a.WriteInteger(player_X, a.ReadInteger(player_X + (2 * Main_size)))
        a.WriteInteger(player_Y, a.ReadInteger(player_Y + (2 * Main_size)))
        a.WriteInteger(player_Z, a.ReadInteger(player_Z + (2 * Main_size)))
    End Sub

    Private Sub TP_to_P4_Click(sender As Object, e As EventArgs) Handles TP_to_P4.Click
        a.WriteInteger(player_X, a.ReadInteger(player_X + (3 * Main_size)))
        a.WriteInteger(player_Y, a.ReadInteger(player_Y + (3 * Main_size)))
        a.WriteInteger(player_Z, a.ReadInteger(player_Z + (3 * Main_size)))
    End Sub

#End Region ' player 1/ Money, Change Weapon, TP players to you
#Region "Player 2"
    Private Sub zm_P2_Money_Click(sender As Object, e As EventArgs) Handles zm_P2_Money.Click
        a.WriteInteger((money + (1 * Main_size)), P2_Money.Text)
    End Sub

    Private Sub zm_P2_PW_Click(sender As Object, e As EventArgs) Handles zm_P2_PW.Click
        a.WriteInteger((primary_ID + (1 * Main_size)), P2_PW.Text)
    End Sub

    Private Sub zm_P2_SW_Click(sender As Object, e As EventArgs) Handles zm_P2_SW.Click
        a.WriteInteger((secondary_ID + (1 * Main_size)), P2_SW.Text)
    End Sub
#End Region ' player 2/ Money, Change Weapon / etc
#Region "Player 3"
    Private Sub zm_P3_Money_Click(sender As Object, e As EventArgs) Handles zm_P3_Money.Click
        a.WriteInteger((money + (2 * Main_size)), P3_Money.Text)
    End Sub

    Private Sub zm_P3_PW_Click(sender As Object, e As EventArgs) Handles zm_P3_PW.Click
        a.WriteInteger((primary_ID + (2 * Main_size)), P3_PW.Text)
    End Sub

    Private Sub zm_P3_SW_Click(sender As Object, e As EventArgs) Handles zm_P3_SW.Click
        a.WriteInteger((secondary_ID + (2 * Main_size)), P3_SW.Text)
    End Sub

#End Region
#Region "Player 4"

    Private Sub zm_P4_Money_Click(sender As Object, e As EventArgs) Handles zm_P4_Money.Click
        a.WriteInteger((money + (3 * Main_size)), P4_Money.Text)
    End Sub

    Private Sub zm_P4_PW_Click(sender As Object, e As EventArgs) Handles zm_P4_PW.Click
        a.WriteInteger((primary_ID + (3 * Main_size)), P4_PW.Text)
    End Sub

    Private Sub zm_P4_SW_Click(sender As Object, e As EventArgs) Handles zm_P4_SW.Click
        a.WriteInteger((secondary_ID + (3 * Main_size)), P4_SW.Text)
    End Sub

#End Region
#Region "Player 5"

    Private Sub zm_P5_Money_Click(sender As Object, e As EventArgs) Handles zm_P5_Money.Click
        a.WriteInteger((money + (4 * Main_size)), P5_Money.Text)
    End Sub

    Private Sub zm_P5_PW_Click(sender As Object, e As EventArgs) Handles zm_P5_PW.Click
        a.WriteInteger((primary_ID + (4 * Main_size)), P5_PW.Text)
    End Sub

    Private Sub zm_P5_SW_Click(sender As Object, e As EventArgs) Handles zm_P5_SW.Click
        a.WriteInteger((secondary_ID + (4 * Main_size)), P5_SW.Text)
    End Sub

#End Region
#Region "Player 6"
    Private Sub zm_P6_Money_Click(sender As Object, e As EventArgs) Handles zm_P6_Money.Click
        a.WriteInteger((money + (5 * Main_size)), P6_Money.Text)
    End Sub

    Private Sub zm_P6_PW_Click(sender As Object, e As EventArgs) Handles zm_P6_PW.Click
        a.WriteInteger((primary_ID + (5 * Main_size)), P6_PW.Text)
    End Sub

    Private Sub zm_P6_SW_Click(sender As Object, e As EventArgs) Handles zm_P6_SW.Click
        a.WriteInteger((secondary_ID + (5 * Main_size)), P6_SW.Text)
    End Sub

#End Region
#Region "Player 7"

    Private Sub zm_P7_Money_Click(sender As Object, e As EventArgs) Handles zm_P7_Money.Click
        a.WriteInteger((money + (6 * Main_size)), P7_Money.Text)
    End Sub

    Private Sub zm_P7_PW_Click(sender As Object, e As EventArgs) Handles zm_P7_PW.Click
        a.WriteInteger((primary_ID + (6 * Main_size)), P7_PW.Text)
    End Sub

    Private Sub zm_P7_SW_Click(sender As Object, e As EventArgs) Handles zm_P7_SW.Click
        a.WriteInteger((secondary_ID + (6 * Main_size)), P7_SW.Text)
    End Sub

#End Region
#Region "Player 8"

    Private Sub zm_P8_Money_Click(sender As Object, e As EventArgs) Handles zm_P8_Money.Click
        a.WriteInteger((money + (7 * Main_size)), P8_Money.Text)
    End Sub

    Private Sub zm_P8_PW_Click(sender As Object, e As EventArgs) Handles zm_P8_PW.Click
        a.WriteInteger((primary_ID + (7 * Main_size)), P8_PW.Text)
    End Sub

    Private Sub zm_P8_SW_Click(sender As Object, e As EventArgs) Handles zm_P8_SW.Click
        a.WriteInteger((secondary_ID + (7 * Main_size)), P8_SW.Text)
    End Sub

#End Region

#End Region


#Region "       Non-Host        "


    Private Sub Non_Host_Timer_Tick(sender As Object, e As EventArgs) Handles Non_Host_Timer.Tick
        a.WriteFloat(a.ReadInteger(cg_fov) + Dvar_size, FOV.Value) ' / cg_fov 
        a.WriteFloat(a.ReadInteger(cg_fovscale) + Dvar_size, 1 + FOVS.Value / 1000) ' / cg_fovScale
        '// gun position
        If GunX_Box.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_gun_x) + Dvar_size, (GunX_Bar.Value)) '/ x
            GunX_lbl.Text = GunX_Bar.Value
        ElseIf GunX_Box.Checked = False Then
            GunX_Bar.Value = 0
            a.WriteFloat(a.ReadInteger(cg_gun_x) + Dvar_size, (GunX_Bar.Value)) '/ x reset
            GunX_lbl.Text = GunX_Bar.Value
        End If
        If GunY_Box.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_gun_y) + Dvar_size, (GunY_Bar.Value)) '/y
            GunY_lbl.Text = GunY_Bar.Value
        ElseIf GunY_Box.Checked = False Then
            GunY_Bar.Value = 0
            a.WriteFloat(a.ReadInteger(cg_gun_y) + Dvar_size, (GunY_Bar.Value)) '/y
            GunY_lbl.Text = GunY_Bar.Value
        End If
        If GunZ_Box.Checked = True Then
            a.WriteFloat(a.ReadInteger(cg_gun_z) + Dvar_size, (GunZ_Bar.Value)) '/z
            GunZ_lbl.Text = GunZ_Bar.Value
        ElseIf GunZ_Box.Checked = False Then
            GunZ_Bar.Value = 0
            a.WriteFloat(a.ReadInteger(cg_gun_z) + Dvar_size, (GunZ_Bar.Value)) '/z
            GunZ_lbl.Text = GunZ_Bar.Value
        End If

        If NR.Checked = True Then
            If a.ReadInteger(No_recoil) <> 116 Then
                a.WriteInteger(No_recoil, 116)
            End If
        Else

        End If

    End Sub
#End Region

#Region "Minimize"
    Private Sub Zombie_Move(sender As Object, e As EventArgs) Handles MyBase.Move

        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(1000, "Zombie Bo2 Compact v2.1", "You have minnimized Bo2 Zombie form", ToolTipIcon.Info)
        Else
        End If

    End Sub




#End Region

End Class