<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.tbLST = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAlt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAz = New System.Windows.Forms.TextBox()
        Me.tbLong = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbLat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbRA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbDEC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbTelescopeHA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbTargetAz = New System.Windows.Forms.TextBox()
        Me.tbTargetRA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTargetDEC = New System.Windows.Forms.TextBox()
        Me.tbTargetAlt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.tbHA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AltAzSlew.My.MySettings.Default, "Telescope", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(460, 411)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = Global.AltAzSlew.My.MySettings.Default.Telescope
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Setup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(93, 12)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'tbLST
        '
        Me.tbLST.Location = New System.Drawing.Point(93, 88)
        Me.tbLST.Name = "tbLST"
        Me.tbLST.ReadOnly = True
        Me.tbLST.Size = New System.Drawing.Size(100, 20)
        Me.tbLST.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LST"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Alt"
        '
        'tbAlt
        '
        Me.tbAlt.Location = New System.Drawing.Point(93, 114)
        Me.tbAlt.Name = "tbAlt"
        Me.tbAlt.ReadOnly = True
        Me.tbAlt.Size = New System.Drawing.Size(100, 20)
        Me.tbAlt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Az"
        '
        'tbAz
        '
        Me.tbAz.Location = New System.Drawing.Point(93, 140)
        Me.tbAz.Name = "tbAz"
        Me.tbAz.ReadOnly = True
        Me.tbAz.Size = New System.Drawing.Size(100, 20)
        Me.tbAz.TabIndex = 7
        '
        'tbLong
        '
        Me.tbLong.Location = New System.Drawing.Point(93, 166)
        Me.tbLong.Name = "tbLong"
        Me.tbLong.ReadOnly = True
        Me.tbLong.Size = New System.Drawing.Size(100, 20)
        Me.tbLong.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Long"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Lat"
        '
        'tbLat
        '
        Me.tbLat.Location = New System.Drawing.Point(93, 192)
        Me.tbLat.Name = "tbLat"
        Me.tbLat.ReadOnly = True
        Me.tbLat.Size = New System.Drawing.Size(100, 20)
        Me.tbLat.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "RA"
        '
        'tbRA
        '
        Me.tbRA.Location = New System.Drawing.Point(93, 218)
        Me.tbRA.Name = "tbRA"
        Me.tbRA.ReadOnly = True
        Me.tbRA.Size = New System.Drawing.Size(100, 20)
        Me.tbRA.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "DEC"
        '
        'tbDEC
        '
        Me.tbDEC.Location = New System.Drawing.Point(93, 244)
        Me.tbDEC.Name = "tbDEC"
        Me.tbDEC.ReadOnly = True
        Me.tbDEC.Size = New System.Drawing.Size(100, 20)
        Me.tbDEC.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(60, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "HA"
        '
        'tbTelescopeHA
        '
        Me.tbTelescopeHA.Location = New System.Drawing.Point(93, 270)
        Me.tbTelescopeHA.Name = "tbTelescopeHA"
        Me.tbTelescopeHA.ReadOnly = True
        Me.tbTelescopeHA.Size = New System.Drawing.Size(100, 20)
        Me.tbTelescopeHA.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Alt"
        '
        'tbTargetAz
        '
        Me.tbTargetAz.Location = New System.Drawing.Point(324, 119)
        Me.tbTargetAz.Name = "tbTargetAz"
        Me.tbTargetAz.Size = New System.Drawing.Size(100, 20)
        Me.tbTargetAz.TabIndex = 18
        '
        'tbTargetRA
        '
        Me.tbTargetRA.Location = New System.Drawing.Point(324, 145)
        Me.tbTargetRA.Name = "tbTargetRA"
        Me.tbTargetRA.ReadOnly = True
        Me.tbTargetRA.Size = New System.Drawing.Size(100, 20)
        Me.tbTargetRA.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(290, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "RA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Az"
        '
        'tbTargetDEC
        '
        Me.tbTargetDEC.Location = New System.Drawing.Point(324, 171)
        Me.tbTargetDEC.Name = "tbTargetDEC"
        Me.tbTargetDEC.ReadOnly = True
        Me.tbTargetDEC.Size = New System.Drawing.Size(100, 20)
        Me.tbTargetDEC.TabIndex = 24
        '
        'tbTargetAlt
        '
        Me.tbTargetAlt.Location = New System.Drawing.Point(324, 92)
        Me.tbTargetAlt.Name = "tbTargetAlt"
        Me.tbTargetAlt.Size = New System.Drawing.Size(100, 20)
        Me.tbTargetAlt.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(290, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "DEC"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(430, 118)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Calculate.TabIndex = 26
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'tbHA
        '
        Me.tbHA.Location = New System.Drawing.Point(324, 197)
        Me.tbHA.Name = "tbHA"
        Me.tbHA.ReadOnly = True
        Me.tbHA.Size = New System.Drawing.Size(100, 20)
        Me.tbHA.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "HA"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(430, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "From Scope"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(430, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "GOTO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(174, 12)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 32
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 511)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbHA)
        Me.Controls.Add(Me.tbTelescopeHA)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbDEC)
        Me.Controls.Add(Me.tbTargetAlt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbTargetDEC)
        Me.Controls.Add(Me.tbRA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbLat)
        Me.Controls.Add(Me.tbTargetRA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTargetAz)
        Me.Controls.Add(Me.tbLong)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAz)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbAlt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLST)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents tbLST As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAlt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAz As TextBox
    Friend WithEvents tbLong As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbLat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbRA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbDEC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbTelescopeHA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbTargetAz As TextBox
    Friend WithEvents tbTargetRA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbTargetDEC As TextBox
    Friend WithEvents tbTargetAlt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents tbHA As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDisconnect As Button
End Class
