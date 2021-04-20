Imports System.Drawing

Public Class Form1

    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer

    Dim isStartBtnMouseDownYes As Boolean

    Dim hasTheProgramBeenStarted As Boolean = My.Settings.hasBeenAlreadyLoaded

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

        Try

            Dim bmpPICBOX As New Bitmap(PictureBox1.Width, PictureBox1.Height)

            PictureBox1.DrawToBitmap(bmpPICBOX, PictureBox1.ClientRectangle)

            Dim userNameLocation As String = Application.UserAppDataPath

            bmpPICBOX.Save(userNameLocation & "lastPicture.bmp", Imaging.ImageFormat.Bmp)
            'saves the last picture in the picturebox to the application directory

        Catch err As Exception

            'nothing needs to be done I don't think

        End Try

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

        If My.Settings.hexInColourCode = True Then

            ColourCode.Text = "#" & decValue
            'the label that shows the colour code

        Else

            ColourCode.Text = decValue

        End If

        My.Settings.hexMain = ColourCode.Text

        My.Settings.red = RedTxt.Text
        My.Settings.green = GreenTxt.Text
        My.Settings.blue = BlueTxt.Text

        My.Settings.solidColour = Panel.BackColor

    End Sub

    Private Sub PictureBox1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

        If isStartBtnMouseDownYes = True Then

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
                'code for pixel size 6.9 lol no it's actually just 6

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

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If hasTheProgramBeenStarted = False Then
            'public variable

            My.Settings.hasBeenAlreadyLoaded = True

            Hex1.Text = My.Settings.hexOne
            Hex2.Text = My.Settings.hexTwo
            Hex3.Text = My.Settings.hexThree
            Hex4.Text = My.Settings.hexFour
            Hex5.Text = My.Settings.hexFive

            Red1.Text = My.Settings.redOne
            Red2.Text = My.Settings.redTwo
            Red3.Text = My.Settings.redThree
            Red4.Text = My.Settings.redFour
            Red5.Text = My.Settings.redFive

            Green1.Text = My.Settings.greenOne
            Green2.Text = My.Settings.greenTwo
            Green3.Text = My.Settings.greenThree
            Green4.Text = My.Settings.greenFour
            Green5.Text = My.Settings.greenFive

            Blue1.Text = My.Settings.blueOne
            Blue2.Text = My.Settings.blueTwo
            Blue3.Text = My.Settings.blueThree
            Blue4.Text = My.Settings.blueFour
            Blue5.Text = My.Settings.blueFive
            'all 4 blocks of code above are to load the last values of each box stored in the settings

            Slot1.BackColor = My.Settings.colourOne
            Slot2.BackColor = My.Settings.colourTwo
            Slot3.BackColor = My.Settings.colourThree
            Slot4.BackColor = My.Settings.colourFour
            Slot5.BackColor = My.Settings.colourFive
            'block of code above to load the last saved colours, if any

        End If

        Me.Location = My.Settings.location

        backgroundColourSetting.Start()
        'starts the timer that constantly saves the background colour setting

        Dim theBackgroundColourOfThisForm As Color
        theBackgroundColourOfThisForm = BackColor
        'code above to set the preliminary/preloaded background colour thats in the settings

        Dim solidStartupColour As Color = My.Settings.solidColour
        Panel.BackColor = solidStartupColour
        'code to set the solid colour panel to the previous colour

        RedTxt.Text = My.Settings.red
        GreenTxt.Text = My.Settings.green
        BlueTxt.Text = My.Settings.blue
        ColourCode.Text = My.Settings.hexMain
        'code above to set the last values of each box etc yes

        PixelSlider.Value = My.Settings.zoomLevel
        PixelSlider_Scroll(sender, e)

        Zoom.Text = "Zoom x" & PixelSlider.Value
        'to set the text as I cannot be arsed to change the inteference with other code LMAO

        PictureBox2.Image = My.Resources.plus
        Delete1.Image = My.Resources._error
        Delete2.Image = My.Resources._error
        Delete3.Image = My.Resources._error
        Delete4.Image = My.Resources._error
        Delete5.Image = My.Resources._error
        EXITPicBtn.Image = My.Resources._error
        'set all the images on form load as obviouly my code is buggy

        If My.Settings.effects = True Then

            Opacity = 0
            'important line of code here

            fadeInTimer.Start()

        Else

            Opacity = My.Settings.opacitySetting

        End If

        If My.Settings.alwaysOnTop = True Then

            TopMost = True
            MinimisePicBtn.Hide()

        Else

            TopMost = False
            MinimisePicBtn.Show()

        End If

        If My.Settings.windowsizeButton = "smaller" Then

            Height = 198
            Width = 310
            'the height for the smaller size

            My.Settings.windowsizeHeight = "198"
            My.Settings.windowsizeWidth = "310"
            My.Settings.windowsizeButton = "smaller"

            EXITPicBtn.Location = New Point(274, 6)
            MinimisePicBtn.Location = New Point(234, 6)
            OptionsPicBox.Location = New Point(42, 6)
            logoPicBox.Location = New Point(2, 6)

            If My.Settings.alwaysOnTop = True Then

                Label1.Location = New Point(90, 9)
                MinimisePicBtn.Show()

            Else

                Label1.Location = New Point(108, 9)
                MinimisePicBtn.Hide()

            End If

            Label1.Size = New Size(133, 30)
            EXITPicBtn.Size = New Size(34, 34)
            MinimisePicBtn.Size = New Size(34, 34)
            OptionsPicBox.Size = New Size(34, 34)
            logoPicBox.Size = New Size(34, 34)

            Hex1.Hide()
            Hex2.Hide()
            Hex3.Hide()
            Hex4.Hide()
            Hex5.Hide()

            PictureBox1.Hide()
            redCopyPicBox.Hide()
            hexCopyPicBox.Hide()

        ElseIf My.Settings.windowsizeButton = "small" Then

            Height = 312
            Width = 310
            'the height for the small size

            My.Settings.windowsizeHeight = "312"
            My.Settings.windowsizeWidth = "310"
            My.Settings.windowsizeButton = "small"

            EXITPicBtn.Location = New Point(274, 6)
            MinimisePicBtn.Location = New Point(234, 6)
            OptionsPicBox.Location = New Point(42, 6)
            logoPicBox.Location = New Point(2, 6)

            If My.Settings.alwaysOnTop = True Then

                Label1.Location = New Point(90, 9)
                MinimisePicBtn.Show()

            Else

                Label1.Location = New Point(108, 9)
                MinimisePicBtn.Hide()

            End If

            Label1.Size = New Size(133, 30)
            EXITPicBtn.Size = New Size(34, 34)
            MinimisePicBtn.Size = New Size(34, 34)
            OptionsPicBox.Size = New Size(34, 34)
            logoPicBox.Size = New Size(34, 34)

            Hex1.Hide()
            Hex2.Hide()
            Hex3.Hide()
            Hex4.Hide()
            Hex5.Hide()
            PictureBox1.Hide()

            hexCopyPicBox.Show()
            redCopyPicBox.Show()

        ElseIf My.Settings.windowsizeButton = "normal" Then

            Height = 312
            Width = 582
            'the height for the normal size

            My.Settings.windowsizeHeight = "312"
            My.Settings.windowsizeWidth = "582"
            My.Settings.windowsizeButton = "normal"

            EXITPicBtn.Location = New Point(542, 2)
            MinimisePicBtn.Location = New Point(500, 2)
            OptionsPicBox.Location = New Point(534, 179)
            logoPicBox.Location = New Point(2, 2)
            Label1.Location = New Point(173, 6)

            Label1.Font = New Font("Segoe UI Light", 16)

            Label1.Size = New Size(221, 42)
            EXITPicBtn.Size = New Size(38, 38)
            MinimisePicBtn.Size = New Size(38, 38)
            OptionsPicBox.Size = New Size(37, 35)
            logoPicBox.Size = New Size(38, 38)

            hexCopyPicBox.Show()
            redCopyPicBox.Show()
            Panel.Show()
            PictureBox1.Show()
            Hex1.Show()
            Hex2.Show()
            Hex3.Show()
            Hex4.Show()
            Hex5.Show()

        End If

        If My.Settings.hexInColourCode = True Then

            Hashtag.Hide()
            ColourCode.Location = New Point(195, 158)
            ColourCode.Size = New Size(100, 27)

        Else

            Hashtag.Show()
            ColourCode.Location = New Point(217, 158)
            ColourCode.Size = New Size(78, 27)

        End If

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

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        Timer1.Stop()

        Cursor = Cursors.Default

    End Sub

    Private Sub ColourCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ColourCode.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            e.Handled = True
            'to stop the DING on enter key

            Try

                Dim hexColour As String = "#" & ColourCode.Text

                Panel.BackColor = ColorTranslator.FromHtml(hexColour)
                'change panel colour to hexadecimal code

                Dim redValue As String = hexColour.Substring(1, 2)
                Dim theNewRedValue As Integer = Convert.ToInt64(redValue, 16)
                RedTxt.Text = theNewRedValue
                'code above to convert the red part of the hex code to display it in the box

                Dim greenValue As String = hexColour.Substring(3, 2)
                Dim theNewGreenValue As Integer = Convert.ToInt64(greenValue, 16)
                GreenTxt.Text = theNewGreenValue
                'code above to convert the green part of the hex code to display it in the box

                Dim blueValue As String = hexColour.Substring(5, 2)
                Dim theNewBlueValue As Integer = Convert.ToInt64(blueValue, 16)
                BlueTxt.Text = theNewBlueValue
                'code above to convert the blue part of the hex code to display it in the box

            Catch err As Exception

                MessageBox.Show("Error occurred", "Colour Picker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

            ' the entire try...catch block is to stop bad characters being calculated in the textboxes and crashing the program

        End If

    End Sub

    Private Sub PixelSlider_Scroll(sender As Object, e As EventArgs) Handles PixelSlider.Scroll

        If PixelSlider.Value = 1 Then

            Zoom.Text = "Zoom x1"
            My.Settings.zoomLevel = "1"

        End If

        If PixelSlider.Value = 2 Then

            Zoom.Text = "Zoom x2"
            My.Settings.zoomLevel = "2"

        End If

        If PixelSlider.Value = 3 Then

            Zoom.Text = "Zoom x3"
            My.Settings.zoomLevel = "3"

        End If

        If PixelSlider.Value = 4 Then

            Zoom.Text = "Zoom x4"
            My.Settings.zoomLevel = "4"

        End If

        If PixelSlider.Value = 5 Then

            Zoom.Text = "Zoom x5"
            My.Settings.zoomLevel = "5"

        End If

        If PixelSlider.Value = 6 Then

            Zoom.Text = "Zoom x6"
            My.Settings.zoomLevel = "6"

        End If

        If PixelSlider.Value = 7 Then

            Zoom.Text = "Zoom x7"
            My.Settings.zoomLevel = "7"

        End If

        If PixelSlider.Value = 8 Then

            Zoom.Text = "Zoom x8"
            My.Settings.zoomLevel = "8"

        End If

        If PixelSlider.Value = 9 Then

            Zoom.Text = "Zoom x9"
            My.Settings.zoomLevel = "9"

        End If

        If PixelSlider.Value = 10 Then

            Zoom.Text = "Zoom x10"
            My.Settings.zoomLevel = "10"

        End If

        If PixelSlider.Value = 11 Then

            Zoom.Text = "Zoom x11"
            My.Settings.zoomLevel = "11"

        End If

        If PixelSlider.Value = 12 Then

            Zoom.Text = "Zoom x12"
            My.Settings.zoomLevel = "12"

        End If

        If PixelSlider.Value = 13 Then

            Zoom.Text = "Zoom x13"
            My.Settings.zoomLevel = "13"

        End If

        If PixelSlider.Value = 14 Then

            Zoom.Text = "Zoom x14"
            My.Settings.zoomLevel = "14"

        End If

        If PixelSlider.Value = 15 Then

            Zoom.Text = "Zoom x15"
            My.Settings.zoomLevel = "15"

        End If

        If PixelSlider.Value = 16 Then

            Zoom.Text = "Zoom x20"
            'the value of 16 on the slider is zoom 20 btw
            My.Settings.zoomLevel = "16"

        End If

        If PixelSlider.Value = 17 Then

            Zoom.Text = "Zoom x30"
            'value of 17 is zoom 30
            My.Settings.zoomLevel = "17"

        End If

        If PixelSlider.Value = 18 Then

            Zoom.Text = "Zoom x50"
            'value of 18 is zoom 50
            My.Settings.zoomLevel = "18"

        End If

        If PixelSlider.Value = 19 Then

            Zoom.Text = "Zoom x150"
            'value of 19 is zoom 150 YEET
            My.Settings.zoomLevel = "19"

        End If

    End Sub

    Private Sub Row1ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Hex1.Text = ""
        Red1.Text = "0"
        Green1.Text = "0"
        Blue1.Text = "0"

        Slot1.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

    End Sub

    Private Sub Row2ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Hex2.Text = ""
        Red2.Text = "0"
        Green2.Text = "0"
        Blue2.Text = "0"

        Slot2.BackColor = Color.Transparent
        'delete second row of values and reset preview colour to transparent

    End Sub

    Private Sub Row3ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Hex3.Text = ""
        Red3.Text = "0"
        Green3.Text = "0"
        Blue3.Text = "0"

        Slot3.BackColor = Color.Transparent
        'delete third row of values and reset preview colour to transparent

    End Sub

    Private Sub Row4ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Hex4.Text = ""
        Red4.Text = "0"
        Green4.Text = "0"
        Blue4.Text = "0"

        Slot4.BackColor = Color.Transparent
        'delete fourth row of values and reset preview colour to transparent

    End Sub

    Private Sub Row5ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Hex5.Text = ""
        Red5.Text = "0"
        Green5.Text = "0"
        Blue5.Text = "0"

        Slot5.BackColor = Color.Transparent
        'delete fifth row of values and reset preview colour to transparent

    End Sub

    Private Sub AllRowsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Hex1.Text = ""
        Red1.Text = "0"
        Green1.Text = "0"
        Blue1.Text = "0"

        Slot1.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent



        Hex2.Text = ""
        Red2.Text = "0"
        Green2.Text = "0"
        Blue2.Text = "0"

        Slot2.BackColor = Color.Transparent
        'delete second row of values and reset preview colour to transparent



        Hex3.Text = ""
        Red3.Text = "0"
        Green3.Text = "0"
        Blue3.Text = "0"

        Slot3.BackColor = Color.Transparent
        'delete third row of values and reset preview colour to transparent



        Hex4.Text = ""
        Red4.Text = "0"
        Green4.Text = "0"
        Blue4.Text = "0"

        Slot4.BackColor = Color.Transparent
        'delete fourth row of values and reset preview colour to transparent



        Hex5.Text = ""
        Red5.Text = "0"
        Green5.Text = "0"
        Blue5.Text = "0"

        Slot5.BackColor = Color.Transparent
        'delete fifth row of values and reset preview colour to transparent

        'code above deletes all values stored

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form2.Show()
        'opens form2 which is the configuration

    End Sub

    Private Sub backgroundColourSetting_Tick(sender As Object, e As EventArgs) Handles backgroundColourSetting.Tick

        BackColor = My.Settings.backcolour
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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form3.Show()
        'opens the about colour picker form

    End Sub

    Private Sub RedTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RedTxt.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            Dim intValue As Integer

            If Integer.TryParse(RedTxt.Text, intValue) AndAlso intValue > -1 AndAlso intValue < 256 Then

                e.Handled = True
                'to stop the DING on enter key

                Try

                    Dim RedCode As Integer = RedTxt.Text
                    Dim GreenCode As Integer = GreenTxt.Text
                    Dim BlueCode As Integer = BlueTxt.Text

                    Dim hexStringRed As String
                    Dim hexStringGreen As String
                    Dim hexStringBlue As String

                    hexStringRed = Hex(RedCode)
                    hexStringGreen = Hex(GreenCode)
                    hexStringBlue = Hex(BlueCode)

                    Dim panelBackColour As Color = Color.FromArgb(RedCode, GreenCode, BlueCode)

                    Panel.BackColor = panelBackColour

                    ColourCode.Text = hexStringRed & hexStringGreen & hexStringBlue

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

                    ColourCode.Text = hexStringRed & hexStringGreen & hexStringBlue

                Catch err As Exception

                    MessageBox.Show("Invalid characters, please try again.", "Colour Picker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If

        End If

    End Sub

    Private Sub GreenTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GreenTxt.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            'Dim intValue As Integer

            'If Integer.TryParse(GreenTxt.Text, intValue) AndAlso intValue > 0 AndAlso intValue < 256 Then

            e.Handled = True
            'to stop the DING on enter key

            Try

                Dim RedCode As Integer = RedTxt.Text
                Dim GreenCode As Integer = GreenTxt.Text
                Dim BlueCode As Integer = BlueTxt.Text

                Dim hexStringRed As String
                Dim hexStringGreen As String
                Dim hexStringBlue As String

                hexStringRed = Hex(RedCode)
                hexStringGreen = Hex(GreenCode)
                hexStringBlue = Hex(BlueCode)

                Dim panelBackColour As Color = Color.FromArgb(RedCode, GreenCode, BlueCode)

                Panel.BackColor = panelBackColour

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

                ColourCode.Text = hexStringRed & hexStringGreen & hexStringBlue

            Catch err As Exception

                MessageBox.Show("Invalid characters, please try again.", "Colour Picker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

            'End If

        End If

    End Sub

    Private Sub BlueTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BlueTxt.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            'Dim intValue As Integer

            'If Integer.TryParse(BlueTxt.Text, intValue) AndAlso intValue > 0 AndAlso intValue < 256 Then

            e.Handled = True
            'to stop the DING on enter key

            Try

                Dim RedCode As Integer = RedTxt.Text
                Dim GreenCode As Integer = GreenTxt.Text
                Dim BlueCode As Integer = BlueTxt.Text

                Dim hexStringRed As String
                Dim hexStringGreen As String
                Dim hexStringBlue As String

                hexStringRed = Hex(RedCode)
                hexStringGreen = Hex(GreenCode)
                hexStringBlue = Hex(BlueCode)

                Dim panelBackColour As Color = Color.FromArgb(RedCode, GreenCode, BlueCode)

                Panel.BackColor = panelBackColour

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

                ColourCode.Text = hexStringRed & hexStringGreen & hexStringBlue

            Catch err As Exception

                MessageBox.Show("Invalid characters, please try again.", "Colour Picker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

            'End If

        End If

    End Sub

    Private Sub HelpWithColourPickerToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form4.Show()
        'to open form4 which is help

    End Sub

    Private Sub picBoxTimer_Tick(sender As Object, e As EventArgs) Handles picBoxTimer.Tick

        Try

            PictureBox1.Enabled = False

            Dim userNameLocation As String = Application.UserAppDataPath

            Dim img1 As New Bitmap(userNameLocation & "lastPicture.bmp")

            Dim img2 As New Bitmap(img1)

            img1.Dispose()

            PictureBox1.Image = img2

            PictureBox1.Enabled = True

        Catch err As Exception

            'do nothing as nothing needs to be done until the user has started to use the application

        End Try

    End Sub

    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs) Handles Panel.MouseEnter

        Cursor = Cursors.Hand()

    End Sub

    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs) Handles Panel.MouseLeave

        Cursor = Cursors.Default()

    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown

        Timer1.Start()

        Cursor = Cursors.Cross

        isStartBtnMouseDownYes = True

    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp

        Timer1.Stop()

        Cursor = Cursors.Default

        isStartBtnMouseDownYes = False
        'code above is the same as startbtn code

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter

        If My.Settings.effects = True Then

            PictureBox2.Image = My.Resources.plus_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave

        PictureBox2.Image = My.Resources.plus
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub Delete1_Click(sender As Object, e As EventArgs) Handles Delete1.Click

        Hex1.Text = ""
        Red1.Text = "0"
        Green1.Text = "0"
        Blue1.Text = "0"

        Slot1.BackColor = Color.Transparent
        'delete first row of values and reset preview colour to transparent

        My.Settings.hexOne = ""
        My.Settings.redOne = "0"
        My.Settings.greenOne = "0"
        My.Settings.blueOne = "0"

        My.Settings.colourOne = Color.Transparent

    End Sub

    Private Sub Delete2_Click(sender As Object, e As EventArgs) Handles Delete2.Click

        Hex2.Text = ""
        Red2.Text = "0"
        Green2.Text = "0"
        Blue2.Text = "0"

        Slot2.BackColor = Color.Transparent
        'delete second row of values and reset preview colour to transparent

        My.Settings.hexTwo = ""
        My.Settings.redTwo = "0"
        My.Settings.greenTwo = "0"
        My.Settings.blueTwo = "0"

        My.Settings.colourTwo = Color.Transparent

    End Sub

    Private Sub Delete3_Click(sender As Object, e As EventArgs) Handles Delete3.Click

        Hex3.Text = ""
        Red3.Text = "0"
        Green3.Text = "0"
        Blue3.Text = "0"

        Slot3.BackColor = Color.Transparent
        'delete thrid row of values and reset preview colour to transparent

        My.Settings.hexThree = ""
        My.Settings.redThree = "0"
        My.Settings.greenThree = "0"
        My.Settings.blueThree = "0"

        My.Settings.colourThree = Color.Transparent

    End Sub

    Private Sub Delete4_Click(sender As Object, e As EventArgs) Handles Delete4.Click

        Hex4.Text = ""
        Red4.Text = "0"
        Green4.Text = "0"
        Blue4.Text = "0"

        Slot4.BackColor = Color.Transparent
        'delete fourth row of values and reset preview colour to transparent

        My.Settings.hexFour = ""
        My.Settings.redFour = "0"
        My.Settings.greenFour = "0"
        My.Settings.blueFour = "0"

        My.Settings.colourFour = Color.Transparent

    End Sub

    Private Sub Delete5_Click(sender As Object, e As EventArgs) Handles Delete5.Click

        Hex5.Text = ""
        Red5.Text = "0"
        Green5.Text = "0"
        Blue5.Text = "0"

        Slot5.BackColor = Color.Transparent
        'delete fifth row of values and reset preview colour to transparent

        My.Settings.hexFive = ""
        My.Settings.redFive = "0"
        My.Settings.greenFive = "0"
        My.Settings.blueFive = "0"

        My.Settings.colourFive = Color.Transparent

    End Sub

    Private Sub Delete1_MouseEnter(sender As Object, e As EventArgs) Handles Delete1.MouseEnter

        If My.Settings.effects = True Then

            Delete1.Image = My.Resources.error_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub Delete1_MouseLeave(sender As Object, e As EventArgs) Handles Delete1.MouseLeave

        Delete1.Image = My.Resources._error
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub Delete2_MouseEnter(sender As Object, e As EventArgs) Handles Delete2.MouseEnter

        If My.Settings.effects = True Then

            Delete2.Image = My.Resources.error_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub Delete2_MouseLeave(sender As Object, e As EventArgs) Handles Delete2.MouseLeave

        Delete2.Image = My.Resources._error
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub Delete3_MouseEnter(sender As Object, e As EventArgs) Handles Delete3.MouseEnter

        If My.Settings.effects = True Then

            Delete3.Image = My.Resources.error_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub Delete3_MouseLeave(sender As Object, e As EventArgs) Handles Delete3.MouseLeave

        Delete3.Image = My.Resources._error
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub Delete4_MouseEnter(sender As Object, e As EventArgs) Handles Delete4.MouseEnter

        If My.Settings.effects = True Then

            Delete4.Image = My.Resources.error_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub Delete4_MouseLeave(sender As Object, e As EventArgs) Handles Delete4.MouseLeave

        Delete4.Image = My.Resources._error
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub Delete5_MouseEnter(sender As Object, e As EventArgs) Handles Delete5.MouseEnter

        If My.Settings.effects = True Then

            Delete5.Image = My.Resources.error_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub Delete5_MouseLeave(sender As Object, e As EventArgs) Handles Delete5.MouseLeave

        Delete5.Image = My.Resources._error
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub AddHEXRGBPicBox_Click(sender As Object, e As EventArgs) Handles AddHEXRGBPicBox.Click

        Try

            If IsNumeric(RedTxt.Text And GreenTxt.Text And BlueTxt.Text) Then

                If Hex1.Text = "" Then

                    Hex1.Text = ColourCode.Text
                    Red1.Text = RedTxt.Text
                    Green1.Text = GreenTxt.Text
                    Blue1.Text = BlueTxt.Text
                    Slot1.BackColor = Panel.BackColor

                    My.Settings.hexOne = Hex1.Text
                    My.Settings.redOne = Red1.Text
                    My.Settings.greenOne = Green1.Text
                    My.Settings.blueOne = Blue1.Text
                    My.Settings.colourOne = Slot1.BackColor

                ElseIf Hex2.Text = "" Then

                    Hex2.Text = ColourCode.Text
                    Red2.Text = RedTxt.Text
                    Green2.Text = GreenTxt.Text
                    Blue2.Text = BlueTxt.Text
                    Slot2.BackColor = Panel.BackColor

                    My.Settings.hexTwo = Hex2.Text
                    My.Settings.redTwo = Red2.Text
                    My.Settings.greenTwo = Green2.Text
                    My.Settings.blueTwo = Blue2.Text
                    My.Settings.colourTwo = Slot2.BackColor

                ElseIf Hex3.Text = "" Then

                    Hex3.Text = ColourCode.Text
                    Red3.Text = RedTxt.Text
                    Green3.Text = GreenTxt.Text
                    Blue3.Text = BlueTxt.Text
                    Slot3.BackColor = Panel.BackColor

                    My.Settings.hexThree = Hex3.Text
                    My.Settings.redThree = Red3.Text
                    My.Settings.greenThree = Green3.Text
                    My.Settings.blueThree = Blue3.Text
                    My.Settings.colourThree = Slot3.BackColor

                ElseIf Hex4.Text = "" Then

                    Hex4.Text = ColourCode.Text
                    Red4.Text = RedTxt.Text
                    Green4.Text = GreenTxt.Text
                    Blue4.Text = BlueTxt.Text
                    Slot4.BackColor = Panel.BackColor

                    My.Settings.hexFour = Hex4.Text
                    My.Settings.redFour = Red4.Text
                    My.Settings.greenFour = Green4.Text
                    My.Settings.blueFour = Blue4.Text
                    My.Settings.colourFour = Slot4.BackColor

                ElseIf Hex5.Text = "" Then

                    Hex5.Text = ColourCode.Text
                    Red5.Text = RedTxt.Text
                    Green5.Text = GreenTxt.Text
                    Blue5.Text = BlueTxt.Text
                    Slot5.BackColor = Panel.BackColor

                    My.Settings.hexFive = Hex5.Text
                    My.Settings.redFive = Red5.Text
                    My.Settings.greenFive = Green5.Text
                    My.Settings.blueFive = Blue5.Text
                    My.Settings.colourFive = Slot5.BackColor

                Else

                    MessageBox.Show("Please delete a row to free up space for more values.", "No space remaining")

                End If

            End If

        Catch err As Exception

            MessageBox.Show("Invalid characters, please try again.", "Colour Picker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'to only allow numbers to be added

        End Try
        'all of the above (in this sub) is to check if the next available slot is free, and if it is it will save the hex, rgb

    End Sub

    Private Sub AddHEXRGBPicBox_MouseEnter(sender As Object, e As EventArgs) Handles AddHEXRGBPicBox.MouseEnter

        If My.Settings.effects = True Then

            AddHEXRGBPicBox.Image = My.Resources.upload_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub AddHEXRGBPicBox_MouseLeave(sender As Object, e As EventArgs) Handles AddHEXRGBPicBox.MouseLeave

        AddHEXRGBPicBox.Image = My.Resources.upload
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub OptionsPicBox_Click(sender As Object, e As EventArgs) Handles OptionsPicBox.Click

        My.Settings.location = Me.Location
        'to save last location

        If My.Settings.effects = True Then

            fadeOutForOptionWindowToOpen.Start()
            'indeed

        Else

            Form2.Show()
            Dispose()

        End If

    End Sub

    Private Sub OptionsPicBox_MouseEnter(sender As Object, e As EventArgs) Handles OptionsPicBox.MouseEnter

        If My.Settings.effects = True Then

            OptionsPicBox.Image = My.Resources.controls_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub OptionsPicBox_MouseLeave(sender As Object, e As EventArgs) Handles OptionsPicBox.MouseLeave

        OptionsPicBox.Image = My.Resources.controls
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub EXITPicBtn_Click(sender As Object, e As EventArgs) Handles EXITPicBtn.Click

        Try

            My.Settings.hexOne = Hex1.Text
            My.Settings.redOne = Red1.Text
            My.Settings.greenOne = Green1.Text
            My.Settings.blueOne = Blue1.Text
            My.Settings.colourOne = Slot1.BackColor

            My.Settings.hexTwo = Hex2.Text
            My.Settings.redTwo = Red2.Text
            My.Settings.greenTwo = Green2.Text
            My.Settings.blueTwo = Blue2.Text
            My.Settings.colourTwo = Slot2.BackColor

            My.Settings.hexThree = Hex3.Text
            My.Settings.redThree = Red3.Text
            My.Settings.greenThree = Green3.Text
            My.Settings.blueThree = Blue3.Text
            My.Settings.colourThree = Slot3.BackColor

            My.Settings.hexFour = Hex4.Text
            My.Settings.redFour = Red4.Text
            My.Settings.greenFour = Green4.Text
            My.Settings.blueFour = Blue4.Text
            My.Settings.colourFour = Slot4.BackColor

            My.Settings.hexFive = Hex5.Text
            My.Settings.redFive = Red5.Text
            My.Settings.greenFive = Green5.Text
            My.Settings.blueFive = Blue5.Text
            My.Settings.colourFive = Slot5.BackColor

        Catch err As Exception

            'yeet

        End Try


        My.Settings.hasBeenAlreadyLoaded = False

        If My.Settings.effects = True Then

            fadeOutTimer.Enabled = True
            fadeOutTimer.Start()
            'starts the fancy fade out timer

        Else

            Application.Exit()

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

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown

        xpos1 = Control.MousePosition.X - Location.X
        ypos1 = Control.MousePosition.Y - Location.Y
        'to change the public variables so that the sub below can access it

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then

            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Location = newpoint

        End If
        'code to check if it's left mouse button that is down to move the window

    End Sub

    Private Sub fadeOutTimer_Tick(sender As Object, e As EventArgs) Handles fadeOutTimer.Tick

        If Opacity <= 0 Then

            Application.Exit()

        Else

            Opacity = Opacity - 0.04

        End If
        'code above to fade out the program then close it

    End Sub

    Private Sub MinimisePicBtn_MouseEnter(sender As Object, e As EventArgs) Handles MinimisePicBtn.MouseEnter

        If My.Settings.effects = True Then

            MinimisePicBtn.Image = My.Resources.minus_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub MinimisePicBtn_MouseLeave(sender As Object, e As EventArgs) Handles MinimisePicBtn.MouseLeave

        MinimisePicBtn.Image = My.Resources.minus
        'code above to change to original picture after hover leaves


    End Sub

    Private Sub MinimisePicBtn_Click(sender As Object, e As EventArgs) Handles MinimisePicBtn.Click

        If My.Settings.effects = True Then

            minimiseTimer.Enabled = True
            minimiseTimer.Start()

        Else

            WindowState = System.Windows.Forms.FormWindowState.Minimized

        End If

    End Sub

    Private Sub minimiseTimer_Tick(sender As Object, e As EventArgs) Handles minimiseTimer.Tick

        If My.Settings.effects = True Then

            If Opacity <= 0 Then

                WindowState = System.Windows.Forms.FormWindowState.Minimized

                minimiseTimer.Enabled = False

            Else

                Opacity = Opacity - 0.04

            End If
            'code above to fade out the program, minimise it, and set the opacity back to normal

        Else

            WindowState = System.Windows.Forms.FormWindowState.Minimized
            Opacity = 1

            minimiseTimer.Enabled = False

        End If

    End Sub

    Private Sub hexCopyPicBox_Click(sender As Object, e As EventArgs) Handles hexCopyPicBox.Click

        If ColourCode.Text <> String.Empty Then
            Clipboard.SetText(ColourCode.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub redCopyPicBox_Click(sender As Object, e As EventArgs) Handles redCopyPicBox.Click

        If RedTxt.Text <> String.Empty Then
            Clipboard.SetText(RedTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub greenCopyPicBox_Click(sender As Object, e As EventArgs) Handles greenCopyPicBox.Click

        If GreenTxt.Text <> String.Empty Then
            Clipboard.SetText(GreenTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub blueCopyPicBox_Click(sender As Object, e As EventArgs) Handles blueCopyPicBox.Click

        If BlueTxt.Text <> String.Empty Then
            Clipboard.SetText(BlueTxt.Text)
        Else
            Clipboard.Clear()
        End If
        'some rather complicated code 'just' to copy the value to the clipboard

    End Sub

    Private Sub hexCopyPicBox_MouseEnter(sender As Object, e As EventArgs) Handles hexCopyPicBox.MouseEnter

        If My.Settings.effects = True Then

            hexCopyPicBox.Image = My.Resources.hexfile_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub hexCopyPicBox_MouseLeave(sender As Object, e As EventArgs) Handles hexCopyPicBox.MouseLeave

        hexCopyPicBox.Image = My.Resources.hexfile
        'code above to change to original picture after hover leaves   

    End Sub

    Private Sub redCopyPicBox_MouseEnter(sender As Object, e As EventArgs) Handles redCopyPicBox.MouseEnter

        If My.Settings.effects = True Then

            redCopyPicBox.Image = My.Resources.redfile_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub redCopyPicBox_MouseLeave(sender As Object, e As EventArgs) Handles redCopyPicBox.MouseLeave

        redCopyPicBox.Image = My.Resources.redfile
        'code above to change to original picture after hover leaves   

    End Sub

    Private Sub greenCopyPicBox_MouseEnter(sender As Object, e As EventArgs) Handles greenCopyPicBox.MouseEnter

        If My.Settings.effects = True Then

            greenCopyPicBox.Image = My.Resources.greenfile_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub greenCopyPicBox_MouseLeave(sender As Object, e As EventArgs) Handles greenCopyPicBox.MouseLeave

        greenCopyPicBox.Image = My.Resources.greenfile
        'code above to change to original picture after hover leaves   

    End Sub

    Private Sub blueCopyPicBox_MouseEnter(sender As Object, e As EventArgs) Handles blueCopyPicBox.MouseEnter

        If My.Settings.effects = True Then

            blueCopyPicBox.Image = My.Resources.bluefile_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub blueCopyPicBox_MouseLeave(sender As Object, e As EventArgs) Handles blueCopyPicBox.MouseLeave

        blueCopyPicBox.Image = My.Resources.bluefile
        'code above to change to original picture after hover leaves   

    End Sub

    Private Sub fadeInTimer_Tick(sender As Object, e As EventArgs) Handles fadeInTimer.Tick

        If Opacity >= My.Settings.opacitySetting Then

            Opacity = My.Settings.opacitySetting

            fadeInTimer.Enabled = False
            'to force stop it

        Else

            Opacity = Opacity + 0.04

        End If
        'code above to fade in the form

    End Sub

    Private Sub fadeOutForOptionWindowToOpen_Tick(sender As Object, e As EventArgs) Handles fadeOutForOptionWindowToOpen.Tick

        If Opacity <= 0 Then

            Form2.Show()
            Dispose()

        Else

            Opacity = Opacity - 0.04

        End If
        'code above to fade out the form then close it

    End Sub

    Private Sub logoPicBox_Click(sender As Object, e As EventArgs) Handles logoPicBox.Click

        My.Settings.location = Me.Location
        'to save last location

        If My.Settings.effects = True Then

            fadeOutForAboutWindowToOpen.Start()

        Else

            Form3.Show()
            Dispose()

        End If


    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If Form2.Visible = True Then

            'nope

        Else

            If My.Settings.effects = True Then

                fadeInTimer.Enabled = True
                fadeInTimer.Start()

            Else

                Opacity = 1

            End If

        End If
        'just some extra validation to do with some quirks

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        My.Settings.location = Me.Location

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs)

        xpos1 = Control.MousePosition.X - Location.X
        ypos1 = Control.MousePosition.Y - Location.Y
        'to change the public variables so that the sub below can access it

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs)

        If e.Button = Windows.Forms.MouseButtons.Left Then

            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Location = newpoint

        End If
        'code to check if it's left mouse button that is down to move the window

    End Sub

    Private Sub helpPicBox_MouseEnter(sender As Object, e As EventArgs) Handles helpPicBox.MouseEnter

        If My.Settings.effects = True Then

            helpPicBox.Image = My.Resources.info_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub helpPicBox_MouseLeave(sender As Object, e As EventArgs) Handles helpPicBox.MouseLeave

        helpPicBox.Image = My.Resources.info
        'code above to change to original picture after hover leaves  

    End Sub

    Private Sub helpPicBox_Click(sender As Object, e As EventArgs) Handles helpPicBox.Click

        My.Settings.location = Me.Location
        'to save last location

        If My.Settings.effects = True Then

            fadeOutForHelpWindowToOpen.Start()
            'indeed

        Else

            Form4.Show()
            Dispose()

        End If

    End Sub

    Private Sub fadeOutForHelpWindowToOpen_Tick(sender As Object, e As EventArgs) Handles fadeOutForHelpWindowToOpen.Tick

        If Opacity <= 0 Then

            Form4.Show()
            Dispose()

        Else

            Opacity = Opacity - 0.04

        End If
        'code above to fade out the program then close it

    End Sub

    Private Sub fadeOutForAboutWindowToOpen_Tick(sender As Object, e As EventArgs) Handles fadeOutForAboutWindowToOpen.Tick

        If Opacity <= 0 Then

            Form3.Show()
            Dispose()

        Else

            Opacity = Opacity - 0.04

        End If
        'code above to fade out the form then close it

    End Sub

    Private Sub logoPicBox_MouseEnter(sender As Object, e As EventArgs) Handles logoPicBox.MouseEnter

        If My.Settings.effects = True Then

            logoPicBox.Image = My.Resources.Bigicon_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub logoPicBox_MouseLeave(sender As Object, e As EventArgs) Handles logoPicBox.MouseLeave

        logoPicBox.Image = My.Resources.Bigicon
        'code above to change to original picture after hover leaves 

    End Sub

End Class