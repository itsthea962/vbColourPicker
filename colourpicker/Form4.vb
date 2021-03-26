Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackColor = My.Settings.backcolour

        If My.Settings.effects = True Then

            Opacity = 0
            'important line of code here

            fadeInTimer.Start()

        Else

            Opacity = My.Settings.opacitySetting

        End If

        TopMost = True

    End Sub

    Private Sub EXITPicBtn_Click(sender As Object, e As EventArgs) Handles EXITPicBtn.Click

        If My.Settings.effects = True Then

            fadeOutTimer.Start()

        Else

            Form1.Show()
            reloadForm.FormOneFix()
            Dispose()

        End If

        If My.Settings.alwaysOnTop = True Then

            Form1.TopMost = True
            Form1.MinimisePicBtn.Hide()

        Else

            Form1.TopMost = False
            Form1.MinimisePicBtn.Show()

        End If

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

    Private Sub fadeInTimer_Tick(sender As Object, e As EventArgs) Handles fadeInTimer.Tick

        If Opacity >= My.Settings.opacitySetting Then

            fadeInTimer.Enabled = False
            'to force stop it

        Else

            Opacity = Opacity + 0.04

            End If
            'code above to fade in the form

    End Sub

    Private Sub fadeOutTimer_Tick(sender As Object, e As EventArgs) Handles fadeOutTimer.Tick

        If Opacity <= 0 Then

            Form1.Show()
            reloadForm.FormOneFix()
            Dispose()

        Else

            Opacity = Opacity - 0.04

        End If
        'code above to fade out the form then close it

    End Sub

End Class