Public Class Form1
    Private objTelescope As ASCOM.DriverAccess.Telescope

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "Telescope"
        My.Settings.Telescope = obj.Choose(My.Settings.Telescope)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        objTelescope = New ASCOM.DriverAccess.Telescope(My.Settings.Telescope)
        objTelescope.Connected = True
        Timer1.Enabled = True
        sender.enabled = False
        btnDisconnect.Enabled = True
        tbLong.Text = objTelescope.SiteLongitude
        tbLat.Text = objTelescope.SiteLatitude
        tbTargetAlt.Text = objTelescope.Altitude
        tbTargetAz.Text = objTelescope.Azimuth
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbLST.Text = objTelescope.SiderealTime
        tbAlt.Text = objTelescope.Altitude
        tbAz.Text = objTelescope.Azimuth
        tbDEC.Text = objTelescope.Declination
        tbRA.Text = objTelescope.RightAscension
        tbTelescopeHA.Text = objTelescope.SiderealTime - objTelescope.RightAscension
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim Altitude, Azimuth, Latitude, DEC, HourAngle, RA, LST, fuzzy As Double
        'Get required Data, convert to radians
        Altitude = tbTargetAlt.Text * Math.PI / 180
        If (tbTargetAz.Text < 180) Then
            fuzzy = -1
        Else
            fuzzy = 1
        End If
        Azimuth = tbTargetAz.Text * Math.PI / 180
        Latitude = objTelescope.SiteLatitude * Math.PI / 180
        LST = objTelescope.SiderealTime * Math.PI / 12
        DEC = Math.Asin(Math.Sin(Altitude) * Math.Sin(Latitude) + Math.Cos(Altitude) * Math.Cos(Latitude) * Math.Cos(Azimuth))

        'Calculate HourAngle in radians
        HourAngle = Math.Acos((Math.Sin(Altitude) - Math.Sin(Latitude) * Math.Sin(DEC)) / (Math.Cos(Latitude) * Math.Cos(DEC))) * fuzzy

        RA = (LST - HourAngle) 'Mod (2 * Math.PI)

        'Convert RA to hours
        RA = RA / (Math.PI / 12)

        'Convert DEC to degree
        DEC = DEC * 180 / Math.PI

        'Convert HourAngle to hours
        HourAngle = HourAngle / (Math.PI / 12)

        tbTargetDEC.Text =DEC
        tbTargetRA.Text = RA
        tbHA.Text = HourAngle
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tbTargetAlt.Text = objTelescope.Altitude
        tbTargetAz.Text = objTelescope.Azimuth
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        objTelescope.SlewToCoordinates(tbTargetRA.Text, tbTargetDEC.Text)
        objTelescope.Tracking = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        objTelescope.Connected = False
        btnConnect.Enabled = True
    End Sub
End Class