Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer

    Private Sub SSChk_Tick(sender As Object, e As EventArgs) Handles SSChk.Tick

        If (GetAsyncKeyState(117) < 0) Then

            Timer1.Start()

        End If

        If (GetAsyncKeyState(118) < 0) Then

            Timer1.Stop()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        XYmouse.Text = "X: " & MousePosition.X & " Y: " & MousePosition.Y
        XYmouse.Refresh()
        'to show and update the coordinates of the mouse pointer

        PictureBox1.Refresh()
        'to update the picture box when mouse cursor moves around

        Dim BMP As New Drawing.Bitmap(1, 1)
        Dim GFX As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y),
                           New Drawing.Point(0, 0), BMP.Size)

        Dim Pixel As Drawing.Color = BMP.GetPixel(0, 0)

        Panel.BackColor = Pixel

        RedTxt.Text = Pixel.R
        GreenTxt.Text = Pixel.G
        BlueTxt.Text = Pixel.B
        'all of this code above gets the colour at mouse pointer and converts it to RGB

        Dim RedCode As Integer = RedTxt.Text
        Dim GreenCode As Integer = GreenTxt.Text
        Dim BlueCode As Integer = BlueTxt.Text

        Dim decValue As String

        Dim hexStringRed As String

        Dim hexStringGreen As String

        Dim hexStringBlue As String

        hexStringRed = Hex(RedCode)
        hexStringGreen = Hex(GreenCode)
        hexStringBlue = Hex(BlueCode)

        If RedCode = "0" Then

            hexStringRed = 0 & 0
            'to get two zeros in the colour code and not just one

        End If

        If GreenCode = "0" Then

            hexStringGreen = 0 & 0
            'to get two zeros in the colour code and not just one

        End If

        If BlueCode = "0" Then

            hexStringBlue = 0 & 0
            'to get two zeros in the colour code and not just one

        End If



        If RedCode = "1" Then

            hexStringRed = 0 & 1
            'to get the zero in the colour code

        End If

        If GreenCode = "1" Then

            hexStringGreen = 0 & 1
            'to get the zero in the colour code

        End If

        If BlueCode = "1" Then

            hexStringBlue = 0 & 1
            'to get the zero in the colour code

        End If



        If RedCode = "2" Then

            hexStringRed = 0 & 2
            'to get the zero in the colour code

        End If

        If GreenCode = "2" Then

            hexStringGreen = 0 & 2
            'to get the zero in the colour code

        End If

        If BlueCode = "2" Then

            hexStringBlue = 0 & 2
            'to get the zero in the colour code

        End If



        If RedCode = "3" Then

            hexStringRed = 0 & 3
            'to get the zero in the colour code

        End If

        If GreenCode = "3" Then

            hexStringGreen = 0 & 3
            'to get the zero in the colour code

        End If

        If BlueCode = "3" Then

            hexStringBlue = 0 & 3
            'to get the zero in the colour code

        End If



        If RedCode = "4" Then

            hexStringRed = 0 & 4
            'to get the zero in the colour code

        End If

        If GreenCode = "4" Then

            hexStringGreen = 0 & 4
            'to get the zero in the colour code

        End If

        If BlueCode = "4" Then

            hexStringBlue = 0 & 4
            'to get the zero in the colour code

        End If



        If RedCode = "5" Then

            hexStringRed = 0 & 5
            'to get the zero in the colour code

        End If

        If GreenCode = "5" Then

            hexStringGreen = 0 & 5
            'to get the zero in the colour code

        End If

        If BlueCode = "5" Then

            hexStringBlue = 0 & 5
            'to get the zero in the colour code

        End If



        If RedCode = "6" Then

            hexStringRed = 0 & 6
            'to get the zero in the colour code

        End If

        If GreenCode = "6" Then

            hexStringGreen = 0 & 6
            'to get the zero in the colour code

        End If

        If BlueCode = "6" Then

            hexStringBlue = 0 & 6
            'to get the zero in the colour code

        End If



        If RedCode = "7" Then

            hexStringRed = 0 & 7
            'to get the zero in the colour code

        End If

        If GreenCode = "7" Then

            hexStringGreen = 0 & 7
            'to get the zero in the colour code

        End If

        If BlueCode = "7" Then

            hexStringBlue = 0 & 7
            'to get the zero in the colour code

        End If



        If RedCode = "8" Then

            hexStringRed = 0 & 8
            'to get the zero in the colour code

        End If

        If GreenCode = "8" Then

            hexStringGreen = 0 & 8
            'to get the zero in the colour code

        End If

        If BlueCode = "8" Then

            hexStringBlue = 0 & 8
            'to get the zero in the colour code

        End If



        If RedCode = "9" Then

            hexStringRed = 0 & 9
            'to get the zero in the colour code

        End If

        If GreenCode = "9" Then

            hexStringGreen = 0 & 9
            'to get the zero in the colour code

        End If

        If BlueCode = "9" Then

            hexStringBlue = 0 & 9
            'to get the zero in the colour code

        End If


        If hexStringRed = "A" Then

            hexStringRed = 0 & "A"
            'to get the missing zero

        End If

        If hexStringGreen = "A" Then

            hexStringGreen = 0 & "A"
            'to get the missing zero

        End If

        If hexStringBlue = "A" Then

            hexStringBlue = 0 & "A"
            'to get the missing zero

        End If


        If hexStringRed = "B" Then

            hexStringRed = 0 & "B"
            'to get the missing zero

        End If

        If hexStringGreen = "B" Then

            hexStringGreen = 0 & "B"
            'to get the missing zero

        End If

        If hexStringBlue = "B" Then

            hexStringBlue = 0 & "B"
            'to get the missing zero

        End If


        If hexStringRed = "C" Then

            hexStringRed = 0 & "C"
            'to get the missing zero

        End If

        If hexStringGreen = "C" Then

            hexStringGreen = 0 & "C"
            'to get the missing zero

        End If

        If hexStringBlue = "C" Then

            hexStringBlue = 0 & "C"
            'to get the missing zero

        End If


        If hexStringRed = "D" Then

            hexStringRed = 0 & "D"
            'to get the missing zero

        End If

        If hexStringGreen = "D" Then

            hexStringGreen = 0 & "D"
            'to get the missing zero

        End If

        If hexStringBlue = "D" Then

            hexStringBlue = 0 & "D"
            'to get the missing zero

        End If


        If hexStringRed = "E" Then

            hexStringRed = 0 & "E"
            'to get the missing zero

        End If

        If hexStringGreen = "E" Then

            hexStringGreen = 0 & "E"
            'to get the missing zero

        End If

        If hexStringBlue = "E" Then

            hexStringBlue = 0 & "E"
            'to get the missing zero

        End If


        If hexStringRed = "F" Then

            hexStringRed = 0 & "F"
            'to get the missing zero

        End If

        If hexStringGreen = "F" Then

            hexStringGreen = 0 & "F"
            'to get the missing zero

        End If

        If hexStringBlue = "F" Then

            hexStringBlue = 0 & "F"
            'to get the missing zero

        End If

        decValue = hexStringRed & hexStringGreen & hexStringBlue
        'to concatenate the values together

        ColourCode.Text = decValue
        'the label that shows the colour code

    End Sub

    Private Sub RedCopy_Click(sender As Object, e As EventArgs) Handles RedCopy.Click

        If RedTxt.Text <> String.Empty Then
            Clipboard.SetText(RedTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub GreenCopy_Click(sender As Object, e As EventArgs) Handles GreenCopy.Click

        If GreenTxt.Text <> String.Empty Then
            Clipboard.SetText(GreenTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub BlueCopy_Click(sender As Object, e As EventArgs) Handles BlueCopy.Click

        If BlueTxt.Text <> String.Empty Then
            Clipboard.SetText(BlueTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub HexCopy_Click(sender As Object, e As EventArgs) Handles HexCopy.Click

        If ColourCode.Text <> String.Empty Then
            Clipboard.SetText(ColourCode.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
        'to close the program

    End Sub

    Private Sub CopyRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyRedToolStripMenuItem.Click

        If RedTxt.Text <> String.Empty Then
            Clipboard.SetText(RedTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub CopyGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyGreenToolStripMenuItem.Click

        If GreenTxt.Text <> String.Empty Then
            Clipboard.SetText(GreenTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub CopyBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyBlueToolStripMenuItem.Click

        If BlueTxt.Text <> String.Empty Then
            Clipboard.SetText(BlueTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub CopyHexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyHexToolStripMenuItem.Click

        If ColourCode.Text <> String.Empty Then
            Clipboard.SetText(ColourCode.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub AddCode_Click(sender As Object, e As EventArgs) Handles AddHex.Click

        If Hex1.Text = "" Then

            Hex1.Text = ColourCode.Text
            Red1.Text = RedTxt.Text
            Green1.Text = GreenTxt.Text
            Blue1.Text = BlueTxt.Text

            Slot1.BackColor = Panel.BackColor

        ElseIf Hex2.Text = "" Then

            Hex2.Text = ColourCode.Text
            Red2.Text = RedTxt.Text
            Green2.Text = GreenTxt.Text
            Blue2.Text = BlueTxt.Text

            Slot2.BackColor = Panel.BackColor

        ElseIf Hex3.Text = "" Then

            Hex3.Text = ColourCode.Text
            Red3.Text = RedTxt.Text
            Green3.Text = GreenTxt.Text
            Blue3.Text = BlueTxt.Text

            Slot3.BackColor = Panel.BackColor

        ElseIf Hex4.Text = "" Then

            Hex4.Text = ColourCode.Text
            Red4.Text = RedTxt.Text
            Green4.Text = GreenTxt.Text
            Blue4.Text = BlueTxt.Text

            Slot4.BackColor = Panel.BackColor

        ElseIf Hex5.Text = "" Then

            Hex5.Text = ColourCode.Text
            Red5.Text = RedTxt.Text
            Green5.Text = GreenTxt.Text
            Blue5.Text = BlueTxt.Text

            Slot5.BackColor = Panel.BackColor
            'all of the above (in this sub) is to check if the next available slot is free, and if it is it will save the hex, rgb

        Else

            MessageBox.Show("Please delete a row to free up space for more values.", "No space remaining")

        End If

    End Sub

    Private Sub PictureBox1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

        If PixelSlider.Value = 1 Then

            Dim bmp1 As New Bitmap(1, 1)

            Using g As Graphics = Graphics.FromImage(bmp1)

                Dim p As Point = MousePosition
                p.Offset(0, 0) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp1.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp1, 0, 0, w, h)
            'code for pixel size 1

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x1"

        End If

        If PixelSlider.Value = 2 Then

            Dim bmp2 As New Bitmap(2, 2)

            Using g As Graphics = Graphics.FromImage(bmp2)

                Dim p As Point = MousePosition
                p.Offset(-1, -1) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp2.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp2, 0, 0, w, h)
            'code for pixel size 2

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x2"

        End If

        If PixelSlider.Value = 3 Then

            Dim bmp3 As New Bitmap(3, 3)

            Using g As Graphics = Graphics.FromImage(bmp3)

                Dim p As Point = MousePosition
                p.Offset(-1, -1) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp3.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp3, 0, 0, w, h)
            'code for pixel size 3

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x3"

        End If

        If PixelSlider.Value = 4 Then

            Dim bmp4 As New Bitmap(4, 4)

            Using g As Graphics = Graphics.FromImage(bmp4)

                Dim p As Point = MousePosition
                p.Offset(-2, -1) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp4.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp4, 0, 0, w, h)
            'code for pixel size 4

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x4"

        End If

        If PixelSlider.Value = 5 Then

            Dim bmp5 As New Bitmap(5, 5)

            Using g As Graphics = Graphics.FromImage(bmp5)

                Dim p As Point = MousePosition
                p.Offset(-2, -2) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp5.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp5, 0, 0, w, h)
            'code for pixel size 5

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x5"

        End If

        If PixelSlider.Value = 6 Then

            Dim bmp6 As New Bitmap(6, 6)

            Using g As Graphics = Graphics.FromImage(bmp6)

                Dim p As Point = MousePosition
                p.Offset(-3, -2) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp6.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp6, 0, 0, w, h)
            'code for pixel size 6

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x6"

        End If

        If PixelSlider.Value = 7 Then

            Dim bmp7 As New Bitmap(7, 7)

            Using g As Graphics = Graphics.FromImage(bmp7)

                Dim p As Point = MousePosition
                p.Offset(-3, -3) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp7.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp7, 0, 0, w, h)
            'code for pixel size 7

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x7"

        End If

        If PixelSlider.Value = 8 Then

            Dim bmp8 As New Bitmap(8, 8)

            Using g As Graphics = Graphics.FromImage(bmp8)

                Dim p As Point = MousePosition
                p.Offset(-4, -3) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp8.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp8, 0, 0, w, h)
            'code for pixel size 8

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x8"

        End If

        If PixelSlider.Value = 9 Then

            Dim bmp9 As New Bitmap(9, 9)

            Using g As Graphics = Graphics.FromImage(bmp9)

                Dim p As Point = MousePosition
                p.Offset(-4, -4) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp9.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp9, 0, 0, w, h)
            'code for pixel size 9

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x9"

        End If

        If PixelSlider.Value = 10 Then

            Dim bmp10 As New Bitmap(10, 10)

            Using g As Graphics = Graphics.FromImage(bmp10)

                Dim p As Point = MousePosition
                p.Offset(-5, -4) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp10.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp10, 0, 0, w, h)
            'code for pixel size 10

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x10"

        End If

        If PixelSlider.Value = 11 Then

            Dim bmp11 As New Bitmap(11, 11)

            Using g As Graphics = Graphics.FromImage(bmp11)

                Dim p As Point = MousePosition
                p.Offset(-5, -5) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp11.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp11, 0, 0, w, h)
            'code for pixel size 11

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x11"

        End If

        If PixelSlider.Value = 12 Then

            Dim bmp12 As New Bitmap(12, 12)

            Using g As Graphics = Graphics.FromImage(bmp12)

                Dim p As Point = MousePosition
                p.Offset(-6, -5) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp12.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp12, 0, 0, w, h)
            'code for pixel size 12

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x12"

        End If

        If PixelSlider.Value = 13 Then

            Dim bmp13 As New Bitmap(13, 13)

            Using g As Graphics = Graphics.FromImage(bmp13)

                Dim p As Point = MousePosition
                p.Offset(-6, -6) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp13.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp13, 0, 0, w, h)
            'code for pixel size 13

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x13"

        End If

        If PixelSlider.Value = 14 Then

            Dim bmp14 As New Bitmap(14, 14)

            Using g As Graphics = Graphics.FromImage(bmp14)

                Dim p As Point = MousePosition
                p.Offset(-7, -6) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp14.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp14, 0, 0, w, h)
            'code for pixel size 14

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x14"

        End If

        If PixelSlider.Value = 15 Then

            Dim bmp15 As New Bitmap(15, 15)

            Using g As Graphics = Graphics.FromImage(bmp15)

                Dim p As Point = MousePosition
                p.Offset(-7, -7) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp15.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp15, 0, 0, w, h)
            'code for pixel size 15

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x15"

        End If

        If PixelSlider.Value = 16 Then
            '16 is actually 20 btw

            Dim bmp3 As New Bitmap(20, 20)

            Using g As Graphics = Graphics.FromImage(bmp3)

                Dim p As Point = MousePosition
                p.Offset(-10, -10) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp3.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp3, 0, 0, w, h)
            'code for pixel size 3

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x20"

        End If

        If PixelSlider.Value = 17 Then
            '17 is actually zoom 30 btw

            Dim bmp3 As New Bitmap(30, 30)

            Using g As Graphics = Graphics.FromImage(bmp3)

                Dim p As Point = MousePosition
                p.Offset(-15, -15) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp3.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp3, 0, 0, w, h)
            'code for pixel size 3

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x20"

        End If

        If PixelSlider.Value = 18 Then
            '18 is actually 50 btw

            Dim bmp3 As New Bitmap(50, 50)

            Using g As Graphics = Graphics.FromImage(bmp3)

                Dim p As Point = MousePosition
                p.Offset(-25, -25) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp3.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp3, 0, 0, w, h)
            'code for pixel size 3

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x50"

        End If

        If PixelSlider.Value = 19 Then
            '19 is actually 150 btw lol

            Dim bmp3 As New Bitmap(150, 150)

            Using g As Graphics = Graphics.FromImage(bmp3)

                Dim p As Point = MousePosition
                p.Offset(-75, -75) 'centre the square around the mouse position
                g.CopyFromScreen(p, New Point(0, 0), bmp3.Size)

            End Using

            Dim w As Integer = PictureBox1.Width
            Dim h As Integer = PictureBox1.Height
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
            e.Graphics.DrawImage(bmp3, 0, 0, w, h)
            'code for pixel size 3

            Dim r As Rectangle
            r.X = w \ 2 - w \ 10
            r.Y = h \ 2 - h \ 10
            r.Width = w \ 5
            r.Height = h \ 5
            e.Graphics.DrawRectangle(Pens.LightGray, r)

            Zoom.Text = "Zoom x150"

        End If

    End Sub

    Private Sub Del1_Click(sender As Object, e As EventArgs) Handles Del1.Click

        Hex1.Text = ""
        Red1.Text = ""
        Green1.Text = ""
        Blue1.Text = ""

        Slot1.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

    End Sub

    Private Sub Del2_Click(sender As Object, e As EventArgs) Handles Del2.Click

        Hex2.Text = ""
        Red2.Text = ""
        Green2.Text = ""
        Blue2.Text = ""

        Slot2.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

    End Sub

    Private Sub Del3_Click(sender As Object, e As EventArgs) Handles Del3.Click

        Hex3.Text = ""
        Red3.Text = ""
        Green3.Text = ""
        Blue3.Text = ""

        Slot3.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

    End Sub

    Private Sub Del4_Click(sender As Object, e As EventArgs) Handles Del4.Click

        Hex4.Text = ""
        Red4.Text = ""
        Green4.Text = ""
        Blue4.Text = ""

        Slot4.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

    End Sub

    Private Sub Del5_Click(sender As Object, e As EventArgs) Handles Del5.Click

        Hex5.Text = ""
        Red5.Text = ""
        Green5.Text = ""
        Blue5.Text = ""

        Slot5.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBox1.BackColor = Color.Black
        'bit buggy atm, supposed to set the zoom panel to black on program launch
        'needs to be fixed

        Me.MaximizeBox = False
        'stop the window being maximised in size


        backgroundColourSetting.Start()
        'starts the timer that constantly saves the background colour setting

        Dim theBackgroundColourOfThisForm As Color
        theBackgroundColourOfThisForm = Me.BackColor
        'code above to set the preliminary/preloaded background colour thats in the settings


        Dim theHeightOfThisForm As String
        theHeightOfThisForm = Me.Height

        Dim theWidthOfThisForm As String
        theWidthOfThisForm = Me.Width
        'code above to load the preliminary/preloaded window size that's in the settings

        Me.Opacity = My.Settings.opacitySetting
        Form2.Opacity = My.Settings.opacitySetting

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If (MessageBox.Show("Are you sure that you want to exit?", "Colour Picker", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then

            e.Cancel = True

        End If
        'code above to confirm the user's exit of the program

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim BMP As New Drawing.Bitmap(1, 1)
        Dim GFX As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y),
                           New Drawing.Point(0, 0), BMP.Size)

        Dim Pixel As Drawing.Color = BMP.GetPixel(0, 0)

        Panel.BackColor = Pixel

        RedTxt.Text = Pixel.R
        GreenTxt.Text = Pixel.G
        BlueTxt.Text = Pixel.B
        'all of this code above gets the colour at mouse pointer and converts it to RGB

        Dim RedCode As Integer = RedTxt.Text
        Dim GreenCode As Integer = GreenTxt.Text
        Dim BlueCode As Integer = BlueTxt.Text

        Dim decValue As String

        Dim hexStringRed As String

        Dim hexStringGreen As String

        Dim hexStringBlue As String

        hexStringRed = Hex(RedCode)
        hexStringGreen = Hex(GreenCode)
        hexStringBlue = Hex(BlueCode)

        decValue = hexStringRed & hexStringGreen & hexStringBlue
        'to concatenate the values together

        ColourCode.Text = decValue
        'the label that shows the colour code

    End Sub

    Private Sub StartBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles StartBtn.MouseDown

        Timer1.Start()

        Cursor = Cursors.Cross
    End Sub

    Private Sub StartBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles StartBtn.MouseUp

        Timer1.Stop()

        Cursor = Cursors.Default

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        Timer1.Stop()

        Cursor = Cursors.Default

    End Sub

    Private Sub ColourCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ColourCode.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            Try
                Dim hexColour As String = "#" & ColourCode.Text

                Panel.BackColor = ColorTranslator.FromHtml(hexColour)
                'change panel colour to hexadecimal code

            Catch err As Exception

                MessageBox.Show("Error occurred", "Colour Picker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try
            ' the entire try...catch block is to stop bad characters being caluclated in the textboxes and crashing the program

        End If

    End Sub

    Private Sub PixelSlider_Scroll(sender As Object, e As EventArgs) Handles PixelSlider.Scroll

        If PixelSlider.Value = 1 Then

            Zoom.Text = "Zoom x1"

        End If

        If PixelSlider.Value = 2 Then

            Zoom.Text = "Zoom x2"

        End If

        If PixelSlider.Value = 3 Then

            Zoom.Text = "Zoom x3"

        End If

        If PixelSlider.Value = 4 Then

            Zoom.Text = "Zoom x4"

        End If

        If PixelSlider.Value = 5 Then

            Zoom.Text = "Zoom x5"

        End If

        If PixelSlider.Value = 6 Then

            Zoom.Text = "Zoom x6"

        End If

        If PixelSlider.Value = 7 Then

            Zoom.Text = "Zoom x7"

        End If

        If PixelSlider.Value = 8 Then

            Zoom.Text = "Zoom x8"

        End If

        If PixelSlider.Value = 9 Then

            Zoom.Text = "Zoom x9"

        End If

        If PixelSlider.Value = 10 Then

            Zoom.Text = "Zoom x10"

        End If

        If PixelSlider.Value = 11 Then

            Zoom.Text = "Zoom x11"

        End If

        If PixelSlider.Value = 12 Then

            Zoom.Text = "Zoom x12"

        End If

        If PixelSlider.Value = 13 Then

            Zoom.Text = "Zoom x13"

        End If

        If PixelSlider.Value = 14 Then

            Zoom.Text = "Zoom x14"

        End If

        If PixelSlider.Value = 15 Then

            Zoom.Text = "Zoom x15"

        End If

        If PixelSlider.Value = 16 Then

            Zoom.Text = "Zoom x20"
            'the value of 16 on the slider is zoom 20 btw

        End If

        If PixelSlider.Value = 17 Then

            Zoom.Text = "Zoom x30"
            'value of 17 is zoom 30

        End If

        If PixelSlider.Value = 18 Then

            Zoom.Text = "Zoom x50"
            'value of 18 is zoom 50

        End If

        If PixelSlider.Value = 19 Then

            Zoom.Text = "Zoom x150"
            'value of 19 is zoom 150 YEET

        End If

    End Sub

    Private Sub Row1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Row1ToolStripMenuItem.Click

        Hex1.Text = ""
        Red1.Text = ""
        Green1.Text = ""
        Blue1.Text = ""

        Slot1.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

    End Sub

    Private Sub Row2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Row2ToolStripMenuItem.Click

        Hex2.Text = ""
        Red2.Text = ""
        Green2.Text = ""
        Blue2.Text = ""

        Slot2.BackColor = Color.Transparent
        'delete second row of values and reset preview colour to transparent

    End Sub

    Private Sub Row3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Row3ToolStripMenuItem.Click

        Hex3.Text = ""
        Red3.Text = ""
        Green3.Text = ""
        Blue3.Text = ""

        Slot3.BackColor = Color.Transparent
        'delete third row of values and reset preview colour to transparent

    End Sub

    Private Sub Row4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Row4ToolStripMenuItem.Click

        Hex4.Text = ""
        Red4.Text = ""
        Green4.Text = ""
        Blue4.Text = ""

        Slot4.BackColor = Color.Transparent
        'delete fourth row of values and reset preview colour to transparent

    End Sub

    Private Sub Row5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Row5ToolStripMenuItem.Click

        Hex5.Text = ""
        Red5.Text = ""
        Green5.Text = ""
        Blue5.Text = ""

        Slot5.BackColor = Color.Transparent
        'delete fifth row of values and reset preview colour to transparent

    End Sub

    Private Sub AllRowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllRowsToolStripMenuItem.Click

        Hex1.Text = ""
        Red1.Text = ""
        Green1.Text = ""
        Blue1.Text = ""

        Slot1.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent



        Hex2.Text = ""
        Red2.Text = ""
        Green2.Text = ""
        Blue2.Text = ""

        Slot2.BackColor = Color.Transparent
        'delete second row of values and reset preview colour to transparent



        Hex3.Text = ""
        Red3.Text = ""
        Green3.Text = ""
        Blue3.Text = ""

        Slot3.BackColor = Color.Transparent
        'delete third row of values and reset preview colour to transparent



        Hex4.Text = ""
        Red4.Text = ""
        Green4.Text = ""
        Blue4.Text = ""

        Slot4.BackColor = Color.Transparent
        'delete fourth row of values and reset preview colour to transparent



        Hex5.Text = ""
        Red5.Text = ""
        Green5.Text = ""
        Blue5.Text = ""

        Slot5.BackColor = Color.Transparent
        'delete fifth row of values and reset preview colour to transparent

        'code above deletes all values stored

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click

        Form2.Show()
        'opens form2 which is the configuration

    End Sub

    Private Sub backgroundColourSetting_Tick(sender As Object, e As EventArgs) Handles backgroundColourSetting.Tick

        Me.BackColor = My.Settings.backcolour
        Form2.BackColor = My.Settings.backcolour
        Form3.BackColor = My.Settings.backcolour
        'just sets the background colour to the saved colour in the settings

    End Sub

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel.MouseDown

        If Hex1.Text = "" Then

            Hex1.Text = ColourCode.Text
            Red1.Text = RedTxt.Text
            Green1.Text = GreenTxt.Text
            Blue1.Text = BlueTxt.Text

            Slot1.BackColor = Panel.BackColor

        ElseIf Hex2.Text = "" Then

            Hex2.Text = ColourCode.Text
            Red2.Text = RedTxt.Text
            Green2.Text = GreenTxt.Text
            Blue2.Text = BlueTxt.Text

            Slot2.BackColor = Panel.BackColor

        ElseIf Hex3.Text = "" Then

            Hex3.Text = ColourCode.Text
            Red3.Text = RedTxt.Text
            Green3.Text = GreenTxt.Text
            Blue3.Text = BlueTxt.Text

            Slot3.BackColor = Panel.BackColor

        ElseIf Hex4.Text = "" Then

            Hex4.Text = ColourCode.Text
            Red4.Text = RedTxt.Text
            Green4.Text = GreenTxt.Text
            Blue4.Text = BlueTxt.Text

            Slot4.BackColor = Panel.BackColor

        ElseIf Hex5.Text = "" Then

            Hex5.Text = ColourCode.Text
            Red5.Text = RedTxt.Text
            Green5.Text = GreenTxt.Text
            Blue5.Text = BlueTxt.Text

            Slot5.BackColor = Panel.BackColor
            'all of the above (in this sub) is to check if the next available slot is free, and if it is it will save the hex, rgb

        Else

            MessageBox.Show("Please delete a row to free up space for more values.", "No space remaining")

        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Form3.Show()
        'opens the about colour picker form

    End Sub
End Class