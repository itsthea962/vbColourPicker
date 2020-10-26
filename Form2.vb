Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Width, Height)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        'prevents the windows from being resizedackgroundColour.Start()
        'starts the timer to change the background colour

        ComboBox1.Text = Form1.BackColor.Name
        'sets the combobox text to the current colour

        Me.MaximizeBox = False
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

        Form1.Height = 211
        Form1.Width = 321
        'the height for the smaller size

        My.Settings.windowsizeHeight = "211"
        My.Settings.windowsizeWidth = "321"
        My.Settings.windowsizeButton = "smaller"

    End Sub

    Private Sub RadioButtonSmall_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSmall.CheckedChanged

        Form1.Height = 330
        Form1.Width = 321
        'the height for the small size

        My.Settings.windowsizeHeight = "330"
        My.Settings.windowsizeWidth = "321"
        My.Settings.windowsizeButton = "small"

    End Sub

    Private Sub RadioButtonNormal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNormal.CheckedChanged

        Form1.Height = 330
        Form1.Width = 608
        'the height for the normal size

        My.Settings.windowsizeHeight = "330"
        My.Settings.windowsizeWidth = "608"
        My.Settings.windowsizeButton = "normal"

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
            Me.Opacity = theSliderValue / 100
            Form3.Opacity = theSliderValue / 100
            'to change the opacity of both forms

            My.Settings.opacitySetting = theSliderValue / 100
            'to set the value in the settings

        End If
        'suprisingly, an if statement works better than a while statement (when run within a timer anyway)

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then

            e.Cancel = True
            Me.Hide()

        End If
        'code to HIDE the form, not close it (on X button press)

    End Sub

End Class