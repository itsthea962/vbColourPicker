Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.backcolour
        Me.Opacity = My.Settings.opacitySetting
        'if you can read English then you can read this

        Me.MaximumSize = New Size(Width, Height)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        'I've used this same block of code too many times now lol

    End Sub
End Class