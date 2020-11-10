Public Class Form3
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim webAddress As String = "https://github.com/theo3334/vbColourPicker"
        Process.Start(webAddress)
        'when the link is clicked it opens the github page

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Width, Height)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        'no need to explain

    End Sub

    Private Sub changeLogFile_Click(sender As Object, e As EventArgs) Handles changeLogFile.Click

        Dim FILE_NAME As String = "UPDATELOG.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Process.Start(FILE_NAME)

        Else

            MsgBox("Yo the file doesn't exist for some reason, it's on my GitHub Repo though")

        End If

    End Sub
End Class