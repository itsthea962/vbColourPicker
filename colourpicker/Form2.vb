Public Class Form2

    Public topMostCheckBox As Boolean
    'public variable for the always on top checkbox

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Opacity = 0

        fadeInTimer.Enabled = True
        fadeInTimer.Start()

        backgroundColour.Start()
        'starts the timer to change the background colour
        'no u

        ComboBox1.Text = Form1.BackColor.Name
        'sets the combobox text to the current colour

        MaximizeBox = False
        'stop the window being maximised in size

        ComboBox1.Items.Add("White")
        ComboBox1.Items.Add("Silver")
        ComboBox1.Items.Add("Grey")
        ComboBox1.Items.Add("Black")
        ComboBox1.Items.Add("Red")
        ComboBox1.Items.Add("Maroon")
        ComboBox1.Items.Add("Yellow")
        ComboBox1.Items.Add("Olive")
        ComboBox1.Items.Add("Lime")
        ComboBox1.Items.Add("Green")
        ComboBox1.Items.Add("Aqua")
        ComboBox1.Items.Add("Teal")
        ComboBox1.Items.Add("Blue")
        ComboBox1.Items.Add("Navy")
        ComboBox1.Items.Add("Magenta")
        ComboBox1.Items.Add("Purple")
        'cba to do it in one line, fat effort
        'anyways this block of code is for the combobox dropdown to change the background colour

        opacitySlider.Value = My.Settings.opacitySetting * 100

        If My.Settings.alwaysOnTop = True Then

            alwaysOnTopCheckBox.Checked = True

        End If

        If My.Settings.windowsizeButton = "smaller" Then

            RadioButtonSmaller.Checked = True

        ElseIf My.Settings.windowsizeButton = "small" Then

            RadioButtonSmall.Checked = True

        ElseIf My.Settings.windowsizeButton = "normal" Then

            RadioButtonNormal.Checked = True

        End If

        If My.Settings.hexInColourCode = True Then

            withHashtagCheckbox.Checked = True

        End If

        If My.Settings.effects = True Then

            effectCheckbox.Checked = True

        End If

    End Sub

    Private Sub backgroundColour_Tick(sender As Object, e As EventArgs) Handles backgroundColour.Tick

        If ComboBox1.Text = "White" Then

            Form1.BackColor = Color.White
            My.Settings.backcolour = Color.White

        ElseIf ComboBox1.Text = "Silver" Then

            Form1.BackColor = Color.Silver
            My.Settings.backcolour = Color.Silver

        ElseIf ComboBox1.Text = "Grey" Then

            Form1.BackColor = Color.Gray
            My.Settings.backcolour = Color.Gray

        ElseIf ComboBox1.Text = "Black" Then

            Form1.BackColor = Color.Black
            My.Settings.backcolour = Color.Black

        ElseIf ComboBox1.Text = "Red" Then

            Form1.BackColor = Color.Red
            My.Settings.backcolour = Color.Red

        ElseIf ComboBox1.Text = "Maroon" Then

            Form1.BackColor = Color.Maroon
            My.Settings.backcolour = Color.Maroon

        ElseIf ComboBox1.Text = "Yellow" Then

            Form1.BackColor = Color.Yellow
            My.Settings.backcolour = Color.Yellow

        ElseIf ComboBox1.Text = "Olive" Then

            Form1.BackColor = Color.Olive
            My.Settings.backcolour = Color.Olive

        ElseIf ComboBox1.Text = "Lime" Then

            Form1.BackColor = Color.Lime
            My.Settings.backcolour = Color.Lime

        ElseIf ComboBox1.Text = "Green" Then

            Form1.BackColor = Color.Green
            My.Settings.backcolour = Color.Green

        ElseIf ComboBox1.Text = "Aqua" Then

            Form1.BackColor = Color.Aqua
            My.Settings.backcolour = Color.Aqua

        ElseIf ComboBox1.Text = "Teal" Then

            Form1.BackColor = Color.Teal
            My.Settings.backcolour = Color.Teal

        ElseIf ComboBox1.Text = "Blue" Then

            Form1.BackColor = Color.Blue
            My.Settings.backcolour = Color.Blue

        ElseIf ComboBox1.Text = "Navy" Then

            Form1.BackColor = Color.Navy
            My.Settings.backcolour = Color.Navy

        ElseIf ComboBox1.Text = "Magenta" Then

            Form1.BackColor = Color.Magenta
            My.Settings.backcolour = Color.Magenta

        ElseIf ComboBox1.Text = "Purple" Then

            Form1.BackColor = Color.Purple
            My.Settings.backcolour = Color.Purple

        End If
        'the biggest if statement in the world
        'runs on a timer so every 1ms it will change the form1 backcolour if necessary
        'and it should also save the colour in the mysettings within backcolour

    End Sub

    Private Sub RadioButtonSmaller_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSmaller.CheckedChanged

        Form1.Height = 198
        Form1.Width = 310
        'the height for the smaller size

        My.Settings.windowsizeHeight = "198"
        My.Settings.windowsizeWidth = "310"
        My.Settings.windowsizeButton = "smaller"

        Form1.EXITPicBtn.Location = New Point(274, 6)
        Form1.MinimisePicBtn.Location = New Point(234, 6)
        Form1.OptionsPicBox.Location = New Point(42, 6)
        Form1.logoPicBox.Location = New Point(2, 6)
        Form1.Label1.Location = New Point(90, 9)

        Form1.Label1.Size = New Size(133, 30)
        Form1.EXITPicBtn.Size = New Size(34, 34)
        Form1.MinimisePicBtn.Size = New Size(34, 34)
        Form1.OptionsPicBox.Size = New Size(34, 34)
        Form1.logoPicBox.Size = New Size(34, 34)

        Form1.Hex1.Hide()
        Form1.Hex2.Hide()
        Form1.Hex3.Hide()
        Form1.Hex4.Hide()
        Form1.Hex5.Hide()

        Form1.PictureBox1.Hide()
        Form1.redCopyPicBox.Hide()
        Form1.hexCopyPicBox.Hide()

    End Sub

    Private Sub RadioButtonSmall_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSmall.CheckedChanged

        Form1.Height = 312
        Form1.Width = 310
        'the height for the small size

        My.Settings.windowsizeHeight = "312"
        My.Settings.windowsizeWidth = "310"
        My.Settings.windowsizeButton = "small"

        Form1.EXITPicBtn.Location = New Point(274, 6)
        Form1.MinimisePicBtn.Location = New Point(234, 6)
        Form1.OptionsPicBox.Location = New Point(42, 6)
        Form1.logoPicBox.Location = New Point(2, 6)
        Form1.Label1.Location = New Point(90, 9)

        Form1.Label1.Size = New Size(133, 30)
        Form1.EXITPicBtn.Size = New Size(34, 34)
        Form1.MinimisePicBtn.Size = New Size(34, 34)
        Form1.OptionsPicBox.Size = New Size(34, 34)
        Form1.logoPicBox.Size = New Size(34, 34)

        Form1.Hex1.Hide()
        Form1.Hex2.Hide()
        Form1.Hex3.Hide()
        Form1.Hex4.Hide()
        Form1.Hex5.Hide()

        Form1.PictureBox1.Hide()

    End Sub

    Private Sub RadioButtonNormal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNormal.CheckedChanged

        Form1.Height = 312
        Form1.Width = 582
        'the height for the normal size

        My.Settings.windowsizeHeight = "312"
        My.Settings.windowsizeWidth = "582"
        My.Settings.windowsizeButton = "normal"

        Form1.EXITPicBtn.Location = New Point(542, 2)
        Form1.MinimisePicBtn.Location = New Point(500, 2)
        Form1.OptionsPicBox.Location = New Point(535, 176)
        Form1.logoPicBox.Location = New Point(2, 2)
        Form1.Label1.Location = New Point(173, 7)

        Form1.Label1.Font = New Font("Segoe UI Light", 16)

        Form1.Label1.Size = New Size(221, 40)
        Form1.EXITPicBtn.Size = New Size(38, 38)
        Form1.MinimisePicBtn.Size = New Size(38, 38)
        Form1.OptionsPicBox.Size = New Size(37, 35)
        Form1.logoPicBox.Size = New Size(38, 38)

    End Sub

    Private Sub sizeWindow_Tick(sender As Object, e As EventArgs) Handles sizeWindow.Tick

        If My.Settings.windowsizeButton = "smaller" Then

            RadioButtonSmaller.Checked = True

        ElseIf My.Settings.windowsizeButton = "small" Then

            RadioButtonSmall.Checked = True

        ElseIf My.Settings.windowsizeButton = "normal" Then

            RadioButtonNormal.Checked = True

        End If
        'self explanatory code above to keep the radio button checked

    End Sub

    Private Sub opacitySilderTimer_Tick(sender As Object, e As EventArgs) Handles opacitySilderTimer.Tick

        Dim theSliderValue As Decimal

        theSliderValue = opacitySlider.Value

        If theSliderValue > 50 Then

            Form1.Opacity = theSliderValue / 100
            Opacity = theSliderValue / 100
            Form3.Opacity = theSliderValue / 100
            Form4.Opacity = theSliderValue / 100
            'to change the opacity of all forms

            My.Settings.opacitySetting = theSliderValue / 100
            'to set the value in the settings

        End If
        'suprisingly, an if statement works better than a while statement (when run within a timer anyway)

    End Sub

    Private Sub alwaysOnTopCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles alwaysOnTopCheckBox.CheckedChanged

        If topMostCheckBox = True Then

            topMostCheckBox = False
            Form1.TopMost = False
            Form1.MinimisePicBtn.Hide()
            My.Settings.alwaysOnTop = False
            'if the variable is set to true

        Else

            topMostCheckBox = True
            Form1.TopMost = True
            Form1.MinimisePicBtn.Show()
            My.Settings.alwaysOnTop = True
            'if the variable is set to false

        End If

    End Sub

    Private Sub EXITPicBtn_Click(sender As Object, e As EventArgs) Handles EXITPicBtn.Click

        If My.Settings.effects = True Then

            fadeOutTimer.Start()

        Else

            Form1.Show()
            reloadForm.FormOneFix()
            Dispose()

        End If

        sizeWindow.Start()

        If My.Settings.alwaysOnTop = True Then

            Form1.TopMost = True
            Form1.MinimisePicBtn.Hide()

        Else

            Form1.TopMost = False
            Form1.MinimisePicBtn.Show()

        End If

        sizeWindow.Enabled = False

    End Sub

    Private Sub fadeInTimer_Tick(sender As Object, e As EventArgs) Handles fadeInTimer.Tick

        If My.Settings.effects = True Then

            If Opacity >= My.Settings.opacitySetting Then

                fadeInTimer.Enabled = False
                'to force stop it

                opacitySilderTimer.Enabled = True
                opacitySilderTimer.Start()

            Else

                Opacity = Opacity + 0.04

            End If
            'code above to fade in the form

        Else

            Opacity = My.Settings.opacitySetting

        End If

    End Sub

    Private Sub fadeOutTimer_Tick(sender As Object, e As EventArgs) Handles fadeOutTimer.Tick

        opacitySilderTimer.Enabled = False
        'force stop it

        If Opacity <= 0 Then

            Form1.Show()
            reloadForm.FormOneFix()
            Dispose()

        Else

            Opacity = Opacity - 0.04

        End If
        'code above to fade out the form then close it

    End Sub

    Private Sub EXITPicBtn_MouseEnter(sender As Object, e As EventArgs) Handles EXITPicBtn.MouseEnter

        If My.Settings.effects = True Then

            EXITPicBtn.Image = My.Resources.error_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub EXITPicBtn_MouseLeave(sender As Object, e As EventArgs) Handles EXITPicBtn.MouseLeave

        EXITPicBtn.Image = My.Resources._error
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub withHashtagCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles withHashtagCheckbox.CheckedChanged

        If withHashtagCheckbox.Checked = True Then

            My.Settings.hexInColourCode = True
            Form1.Hashtag.Hide()
            Form1.ColourCode.Location = New Point(195, 158)
            Form1.ColourCode.Size = New Size(100, 27)

        Else

            My.Settings.hexInColourCode = False
            Form1.Hashtag.Show()
            Form1.ColourCode.Location = New Point(217, 158)
            Form1.ColourCode.Size = New Size(78, 27)

        End If

    End Sub

    Private Sub effectCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles effectCheckbox.CheckedChanged

        If effectCheckbox.Checked = True Then

            My.Settings.effects = True

        Else

            My.Settings.effects = False

        End If

    End Sub

    Private Sub resetSettingsPicBox_Click(sender As Object, e As EventArgs) Handles resetSettingsPicBox.Click

        My.Settings.backcolour = Color.Teal
        ComboBox1.Text = "Teal"
        Form1.BackColor = Color.Teal
        BackColor = Color.Teal
        Form3.BackColor = Color.Teal
        Form4.BackColor = Color.Teal
        'to reset background colours

        Form1.Height = 330
        Form1.Width = 608
        My.Settings.windowsizeHeight = "330"
        My.Settings.windowsizeWidth = "608"
        My.Settings.windowsizeButton = "normal"
        'to reset window size settings

        My.Settings.opacitySetting = 1
        Form1.Opacity = 1
        Opacity = 1
        Form3.Opacity = 1
        Form4.Opacity = 1
        opacitySlider.Value = 100
        'to reset opacity settings

        My.Settings.alwaysOnTop = False
        Form1.TopMost = False
        alwaysOnTopCheckBox.Checked = False
        topMostCheckBox = False

        My.Settings.hexInColourCode = False
        withHashtagCheckbox.Checked = False

        My.Settings.effects = True

    End Sub

    Private Sub resetSettingsPicBox_MouseEnter(sender As Object, e As EventArgs) Handles resetSettingsPicBox.MouseEnter

        If My.Settings.effects = True Then

            resetSettingsPicBox.Image = My.Resources.resetSettings_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub resetSettingsPicBox_MouseLeave(sender As Object, e As EventArgs) Handles resetSettingsPicBox.MouseLeave

        resetSettingsPicBox.Image = My.Resources.resetSettings
        'code above to change to original picture after hover leaves

    End Sub

End Class