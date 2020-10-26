Public Class Form3
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim webAddress As String = "https://github.com/theo3334/vbColourPicker"
        Process.Start(webAddress)
        'when the link is clicked it opens the github page

    End Sub

End Class