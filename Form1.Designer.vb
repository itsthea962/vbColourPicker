<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SSChk = New System.Windows.Forms.Timer(Me.components)
        Me.RedLbl = New System.Windows.Forms.Label()
        Me.GreenLbl = New System.Windows.Forms.Label()
        Me.BlueLbl = New System.Windows.Forms.Label()
        Me.RedCopy = New System.Windows.Forms.Button()
        Me.GreenCopy = New System.Windows.Forms.Button()
        Me.BlueCopy = New System.Windows.Forms.Button()
        Me.HexCopy = New System.Windows.Forms.Button()
        Me.AddHex = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Row1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Row2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Row3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Row4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Row5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpWithColourPickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hashtag = New System.Windows.Forms.Label()
        Me.Del1 = New System.Windows.Forms.Button()
        Me.Del2 = New System.Windows.Forms.Button()
        Me.Del3 = New System.Windows.Forms.Button()
        Me.Del4 = New System.Windows.Forms.Button()
        Me.Del5 = New System.Windows.Forms.Button()
        Me.XYmouse = New System.Windows.Forms.Label()
        Me.Hex1 = New System.Windows.Forms.TextBox()
        Me.Hex2 = New System.Windows.Forms.TextBox()
        Me.Hex3 = New System.Windows.Forms.TextBox()
        Me.Hex4 = New System.Windows.Forms.TextBox()
        Me.Hex5 = New System.Windows.Forms.TextBox()
        Me.Red1 = New System.Windows.Forms.TextBox()
        Me.Red2 = New System.Windows.Forms.TextBox()
        Me.Red3 = New System.Windows.Forms.TextBox()
        Me.Red4 = New System.Windows.Forms.TextBox()
        Me.Red5 = New System.Windows.Forms.TextBox()
        Me.Green1 = New System.Windows.Forms.TextBox()
        Me.Green2 = New System.Windows.Forms.TextBox()
        Me.Green3 = New System.Windows.Forms.TextBox()
        Me.Green4 = New System.Windows.Forms.TextBox()
        Me.Green5 = New System.Windows.Forms.TextBox()
        Me.Blue1 = New System.Windows.Forms.TextBox()
        Me.Blue2 = New System.Windows.Forms.TextBox()
        Me.Blue3 = New System.Windows.Forms.TextBox()
        Me.Blue4 = New System.Windows.Forms.TextBox()
        Me.Blue5 = New System.Windows.Forms.TextBox()
        Me.PixelSlider = New System.Windows.Forms.TrackBar()
        Me.Zoom = New System.Windows.Forms.Label()
        Me.ColourCode = New System.Windows.Forms.TextBox()
        Me.RedTxt = New System.Windows.Forms.TextBox()
        Me.GreenTxt = New System.Windows.Forms.TextBox()
        Me.BlueTxt = New System.Windows.Forms.TextBox()
        Me.backgroundColourSetting = New System.Windows.Forms.Timer(Me.components)
        Me.startTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.RGBHEXSOLIDTIMER = New System.Windows.Forms.Timer(Me.components)
        Me.savedColourTimer = New System.Windows.Forms.Timer(Me.components)
        Me.picBoxTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Slot5 = New System.Windows.Forms.PictureBox()
        Me.Slot4 = New System.Windows.Forms.PictureBox()
        Me.Slot3 = New System.Windows.Forms.PictureBox()
        Me.Slot2 = New System.Windows.Forms.PictureBox()
        Me.Slot1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PixelSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Black
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Location = New System.Drawing.Point(193, 36)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(100, 100)
        Me.Panel.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'SSChk
        '
        Me.SSChk.Interval = 1
        '
        'RedLbl
        '
        Me.RedLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedLbl.Location = New System.Drawing.Point(13, 175)
        Me.RedLbl.Name = "RedLbl"
        Me.RedLbl.Size = New System.Drawing.Size(65, 29)
        Me.RedLbl.TabIndex = 3
        Me.RedLbl.Text = "RED:"
        Me.RedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GreenLbl
        '
        Me.GreenLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenLbl.Location = New System.Drawing.Point(13, 212)
        Me.GreenLbl.Name = "GreenLbl"
        Me.GreenLbl.Size = New System.Drawing.Size(65, 29)
        Me.GreenLbl.TabIndex = 4
        Me.GreenLbl.Text = "GREEN:"
        Me.GreenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BlueLbl
        '
        Me.BlueLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueLbl.Location = New System.Drawing.Point(13, 250)
        Me.BlueLbl.Name = "BlueLbl"
        Me.BlueLbl.Size = New System.Drawing.Size(65, 29)
        Me.BlueLbl.TabIndex = 5
        Me.BlueLbl.Text = "BLUE:"
        Me.BlueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RedCopy
        '
        Me.RedCopy.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedCopy.Location = New System.Drawing.Point(190, 174)
        Me.RedCopy.Name = "RedCopy"
        Me.RedCopy.Size = New System.Drawing.Size(47, 32)
        Me.RedCopy.TabIndex = 13
        Me.RedCopy.Text = "COPY"
        Me.RedCopy.UseVisualStyleBackColor = True
        '
        'GreenCopy
        '
        Me.GreenCopy.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenCopy.Location = New System.Drawing.Point(190, 211)
        Me.GreenCopy.Name = "GreenCopy"
        Me.GreenCopy.Size = New System.Drawing.Size(47, 31)
        Me.GreenCopy.TabIndex = 14
        Me.GreenCopy.Text = "COPY"
        Me.GreenCopy.UseVisualStyleBackColor = True
        '
        'BlueCopy
        '
        Me.BlueCopy.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueCopy.Location = New System.Drawing.Point(190, 248)
        Me.BlueCopy.Name = "BlueCopy"
        Me.BlueCopy.Size = New System.Drawing.Size(47, 32)
        Me.BlueCopy.TabIndex = 15
        Me.BlueCopy.Text = "COPY"
        Me.BlueCopy.UseVisualStyleBackColor = True
        '
        'HexCopy
        '
        Me.HexCopy.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexCopy.Location = New System.Drawing.Point(245, 174)
        Me.HexCopy.Name = "HexCopy"
        Me.HexCopy.Size = New System.Drawing.Size(48, 106)
        Me.HexCopy.TabIndex = 16
        Me.HexCopy.Text = "COPY HEX"
        Me.HexCopy.UseVisualStyleBackColor = True
        '
        'AddHex
        '
        Me.AddHex.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddHex.Location = New System.Drawing.Point(431, 165)
        Me.AddHex.Name = "AddHex"
        Me.AddHex.Size = New System.Drawing.Size(149, 32)
        Me.AddHex.TabIndex = 19
        Me.AddHex.Text = "ADD CURRENT VALUES"
        Me.AddHex.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyHexToolStripMenuItem, Me.CopyRedToolStripMenuItem, Me.CopyGreenToolStripMenuItem, Me.CopyBlueToolStripMenuItem, Me.DeleteRowsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CopyHexToolStripMenuItem
        '
        Me.CopyHexToolStripMenuItem.Name = "CopyHexToolStripMenuItem"
        Me.CopyHexToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CopyHexToolStripMenuItem.Text = "Copy Hex"
        '
        'CopyRedToolStripMenuItem
        '
        Me.CopyRedToolStripMenuItem.Name = "CopyRedToolStripMenuItem"
        Me.CopyRedToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CopyRedToolStripMenuItem.Text = "Copy Red"
        '
        'CopyGreenToolStripMenuItem
        '
        Me.CopyGreenToolStripMenuItem.Name = "CopyGreenToolStripMenuItem"
        Me.CopyGreenToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CopyGreenToolStripMenuItem.Text = "Copy Green"
        '
        'CopyBlueToolStripMenuItem
        '
        Me.CopyBlueToolStripMenuItem.Name = "CopyBlueToolStripMenuItem"
        Me.CopyBlueToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CopyBlueToolStripMenuItem.Text = "Copy Blue"
        '
        'DeleteRowsToolStripMenuItem
        '
        Me.DeleteRowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Row1ToolStripMenuItem, Me.Row2ToolStripMenuItem, Me.Row3ToolStripMenuItem, Me.Row4ToolStripMenuItem, Me.Row5ToolStripMenuItem, Me.AllRowsToolStripMenuItem})
        Me.DeleteRowsToolStripMenuItem.Name = "DeleteRowsToolStripMenuItem"
        Me.DeleteRowsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.DeleteRowsToolStripMenuItem.Text = "Delete Rows"
        '
        'Row1ToolStripMenuItem
        '
        Me.Row1ToolStripMenuItem.Name = "Row1ToolStripMenuItem"
        Me.Row1ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Row1ToolStripMenuItem.Text = "Row 1"
        '
        'Row2ToolStripMenuItem
        '
        Me.Row2ToolStripMenuItem.Name = "Row2ToolStripMenuItem"
        Me.Row2ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Row2ToolStripMenuItem.Text = "Row 2"
        '
        'Row3ToolStripMenuItem
        '
        Me.Row3ToolStripMenuItem.Name = "Row3ToolStripMenuItem"
        Me.Row3ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Row3ToolStripMenuItem.Text = "Row 3"
        '
        'Row4ToolStripMenuItem
        '
        Me.Row4ToolStripMenuItem.Name = "Row4ToolStripMenuItem"
        Me.Row4ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Row4ToolStripMenuItem.Text = "Row 4"
        '
        'Row5ToolStripMenuItem
        '
        Me.Row5ToolStripMenuItem.Name = "Row5ToolStripMenuItem"
        Me.Row5ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Row5ToolStripMenuItem.Text = "Row 5"
        '
        'AllRowsToolStripMenuItem
        '
        Me.AllRowsToolStripMenuItem.Name = "AllRowsToolStripMenuItem"
        Me.AllRowsToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AllRowsToolStripMenuItem.Text = "All Rows"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpWithColourPickerToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AboutToolStripMenuItem.Text = "About Colour Picker"
        '
        'HelpWithColourPickerToolStripMenuItem
        '
        Me.HelpWithColourPickerToolStripMenuItem.Name = "HelpWithColourPickerToolStripMenuItem"
        Me.HelpWithColourPickerToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.HelpWithColourPickerToolStripMenuItem.Text = "Help with Colour Picker"
        '
        'Hashtag
        '
        Me.Hashtag.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hashtag.Location = New System.Drawing.Point(193, 137)
        Me.Hashtag.Name = "Hashtag"
        Me.Hashtag.Size = New System.Drawing.Size(17, 22)
        Me.Hashtag.TabIndex = 22
        Me.Hashtag.Text = "#"
        Me.Hashtag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Del1
        '
        Me.Del1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del1.Location = New System.Drawing.Point(551, 36)
        Me.Del1.Name = "Del1"
        Me.Del1.Size = New System.Drawing.Size(29, 22)
        Me.Del1.TabIndex = 51
        Me.Del1.Text = "X"
        Me.Del1.UseVisualStyleBackColor = True
        '
        'Del2
        '
        Me.Del2.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del2.Location = New System.Drawing.Point(551, 59)
        Me.Del2.Name = "Del2"
        Me.Del2.Size = New System.Drawing.Size(29, 22)
        Me.Del2.TabIndex = 52
        Me.Del2.Text = "X"
        Me.Del2.UseVisualStyleBackColor = True
        '
        'Del3
        '
        Me.Del3.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del3.Location = New System.Drawing.Point(551, 82)
        Me.Del3.Name = "Del3"
        Me.Del3.Size = New System.Drawing.Size(29, 22)
        Me.Del3.TabIndex = 53
        Me.Del3.Text = "X"
        Me.Del3.UseVisualStyleBackColor = True
        '
        'Del4
        '
        Me.Del4.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del4.Location = New System.Drawing.Point(551, 105)
        Me.Del4.Name = "Del4"
        Me.Del4.Size = New System.Drawing.Size(29, 22)
        Me.Del4.TabIndex = 54
        Me.Del4.Text = "X"
        Me.Del4.UseVisualStyleBackColor = True
        '
        'Del5
        '
        Me.Del5.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del5.Location = New System.Drawing.Point(551, 128)
        Me.Del5.Name = "Del5"
        Me.Del5.Size = New System.Drawing.Size(29, 22)
        Me.Del5.TabIndex = 55
        Me.Del5.Text = "X"
        Me.Del5.UseVisualStyleBackColor = True
        '
        'XYmouse
        '
        Me.XYmouse.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XYmouse.Location = New System.Drawing.Point(431, 259)
        Me.XYmouse.Name = "XYmouse"
        Me.XYmouse.Size = New System.Drawing.Size(149, 21)
        Me.XYmouse.TabIndex = 62
        Me.XYmouse.Text = "X: Y:"
        Me.XYmouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Hex1
        '
        Me.Hex1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hex1.Location = New System.Drawing.Point(308, 36)
        Me.Hex1.Name = "Hex1"
        Me.Hex1.ReadOnly = True
        Me.Hex1.Size = New System.Drawing.Size(73, 22)
        Me.Hex1.TabIndex = 63
        Me.Hex1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Hex2
        '
        Me.Hex2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hex2.Location = New System.Drawing.Point(308, 59)
        Me.Hex2.Name = "Hex2"
        Me.Hex2.ReadOnly = True
        Me.Hex2.Size = New System.Drawing.Size(73, 22)
        Me.Hex2.TabIndex = 64
        Me.Hex2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Hex3
        '
        Me.Hex3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hex3.Location = New System.Drawing.Point(308, 82)
        Me.Hex3.Name = "Hex3"
        Me.Hex3.ReadOnly = True
        Me.Hex3.Size = New System.Drawing.Size(73, 22)
        Me.Hex3.TabIndex = 65
        Me.Hex3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Hex4
        '
        Me.Hex4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hex4.Location = New System.Drawing.Point(308, 105)
        Me.Hex4.Name = "Hex4"
        Me.Hex4.ReadOnly = True
        Me.Hex4.Size = New System.Drawing.Size(73, 22)
        Me.Hex4.TabIndex = 66
        Me.Hex4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Hex5
        '
        Me.Hex5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hex5.Location = New System.Drawing.Point(308, 128)
        Me.Hex5.Name = "Hex5"
        Me.Hex5.ReadOnly = True
        Me.Hex5.Size = New System.Drawing.Size(73, 22)
        Me.Hex5.TabIndex = 67
        Me.Hex5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Red1
        '
        Me.Red1.BackColor = System.Drawing.Color.Red
        Me.Red1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red1.Location = New System.Drawing.Point(387, 36)
        Me.Red1.Name = "Red1"
        Me.Red1.ReadOnly = True
        Me.Red1.Size = New System.Drawing.Size(42, 22)
        Me.Red1.TabIndex = 68
        Me.Red1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Red2
        '
        Me.Red2.BackColor = System.Drawing.Color.Red
        Me.Red2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red2.Location = New System.Drawing.Point(387, 59)
        Me.Red2.Name = "Red2"
        Me.Red2.ReadOnly = True
        Me.Red2.Size = New System.Drawing.Size(42, 22)
        Me.Red2.TabIndex = 69
        Me.Red2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Red3
        '
        Me.Red3.BackColor = System.Drawing.Color.Red
        Me.Red3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red3.Location = New System.Drawing.Point(387, 82)
        Me.Red3.Name = "Red3"
        Me.Red3.ReadOnly = True
        Me.Red3.Size = New System.Drawing.Size(42, 22)
        Me.Red3.TabIndex = 70
        Me.Red3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Red4
        '
        Me.Red4.BackColor = System.Drawing.Color.Red
        Me.Red4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red4.Location = New System.Drawing.Point(387, 105)
        Me.Red4.Name = "Red4"
        Me.Red4.ReadOnly = True
        Me.Red4.Size = New System.Drawing.Size(42, 22)
        Me.Red4.TabIndex = 71
        Me.Red4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Red5
        '
        Me.Red5.BackColor = System.Drawing.Color.Red
        Me.Red5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red5.Location = New System.Drawing.Point(387, 128)
        Me.Red5.Name = "Red5"
        Me.Red5.ReadOnly = True
        Me.Red5.Size = New System.Drawing.Size(42, 22)
        Me.Red5.TabIndex = 72
        Me.Red5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Green1
        '
        Me.Green1.BackColor = System.Drawing.Color.Green
        Me.Green1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green1.Location = New System.Drawing.Point(431, 36)
        Me.Green1.Name = "Green1"
        Me.Green1.ReadOnly = True
        Me.Green1.Size = New System.Drawing.Size(42, 22)
        Me.Green1.TabIndex = 73
        Me.Green1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Green2
        '
        Me.Green2.BackColor = System.Drawing.Color.Green
        Me.Green2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green2.Location = New System.Drawing.Point(431, 59)
        Me.Green2.Name = "Green2"
        Me.Green2.ReadOnly = True
        Me.Green2.Size = New System.Drawing.Size(42, 22)
        Me.Green2.TabIndex = 74
        Me.Green2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Green3
        '
        Me.Green3.BackColor = System.Drawing.Color.Green
        Me.Green3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green3.Location = New System.Drawing.Point(431, 82)
        Me.Green3.Name = "Green3"
        Me.Green3.ReadOnly = True
        Me.Green3.Size = New System.Drawing.Size(42, 22)
        Me.Green3.TabIndex = 75
        Me.Green3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Green4
        '
        Me.Green4.BackColor = System.Drawing.Color.Green
        Me.Green4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green4.Location = New System.Drawing.Point(431, 105)
        Me.Green4.Name = "Green4"
        Me.Green4.ReadOnly = True
        Me.Green4.Size = New System.Drawing.Size(42, 22)
        Me.Green4.TabIndex = 76
        Me.Green4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Green5
        '
        Me.Green5.BackColor = System.Drawing.Color.Green
        Me.Green5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green5.Location = New System.Drawing.Point(431, 128)
        Me.Green5.Name = "Green5"
        Me.Green5.ReadOnly = True
        Me.Green5.Size = New System.Drawing.Size(42, 22)
        Me.Green5.TabIndex = 77
        Me.Green5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Blue1
        '
        Me.Blue1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Blue1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue1.Location = New System.Drawing.Point(475, 36)
        Me.Blue1.Name = "Blue1"
        Me.Blue1.ReadOnly = True
        Me.Blue1.Size = New System.Drawing.Size(42, 22)
        Me.Blue1.TabIndex = 78
        Me.Blue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Blue2
        '
        Me.Blue2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Blue2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue2.Location = New System.Drawing.Point(475, 59)
        Me.Blue2.Name = "Blue2"
        Me.Blue2.ReadOnly = True
        Me.Blue2.Size = New System.Drawing.Size(42, 22)
        Me.Blue2.TabIndex = 79
        Me.Blue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Blue3
        '
        Me.Blue3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Blue3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue3.Location = New System.Drawing.Point(475, 82)
        Me.Blue3.Name = "Blue3"
        Me.Blue3.ReadOnly = True
        Me.Blue3.Size = New System.Drawing.Size(42, 22)
        Me.Blue3.TabIndex = 80
        Me.Blue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Blue4
        '
        Me.Blue4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Blue4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue4.Location = New System.Drawing.Point(475, 105)
        Me.Blue4.Name = "Blue4"
        Me.Blue4.ReadOnly = True
        Me.Blue4.Size = New System.Drawing.Size(42, 22)
        Me.Blue4.TabIndex = 81
        Me.Blue4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Blue5
        '
        Me.Blue5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Blue5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue5.Location = New System.Drawing.Point(475, 128)
        Me.Blue5.Name = "Blue5"
        Me.Blue5.ReadOnly = True
        Me.Blue5.Size = New System.Drawing.Size(42, 22)
        Me.Blue5.TabIndex = 82
        Me.Blue5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PixelSlider
        '
        Me.PixelSlider.Location = New System.Drawing.Point(431, 197)
        Me.PixelSlider.Maximum = 19
        Me.PixelSlider.Minimum = 1
        Me.PixelSlider.Name = "PixelSlider"
        Me.PixelSlider.Size = New System.Drawing.Size(149, 45)
        Me.PixelSlider.TabIndex = 83
        Me.PixelSlider.Value = 5
        '
        'Zoom
        '
        Me.Zoom.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zoom.Location = New System.Drawing.Point(429, 230)
        Me.Zoom.Name = "Zoom"
        Me.Zoom.Size = New System.Drawing.Size(151, 21)
        Me.Zoom.TabIndex = 85
        Me.Zoom.Text = "Zoom"
        Me.Zoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColourCode
        '
        Me.ColourCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColourCode.Location = New System.Drawing.Point(215, 138)
        Me.ColourCode.Name = "ColourCode"
        Me.ColourCode.Size = New System.Drawing.Size(78, 27)
        Me.ColourCode.TabIndex = 91
        Me.ColourCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RedTxt
        '
        Me.RedTxt.BackColor = System.Drawing.Color.Red
        Me.RedTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedTxt.Location = New System.Drawing.Point(84, 175)
        Me.RedTxt.Name = "RedTxt"
        Me.RedTxt.Size = New System.Drawing.Size(100, 29)
        Me.RedTxt.TabIndex = 92
        Me.RedTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GreenTxt
        '
        Me.GreenTxt.BackColor = System.Drawing.Color.Green
        Me.GreenTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenTxt.Location = New System.Drawing.Point(84, 212)
        Me.GreenTxt.Name = "GreenTxt"
        Me.GreenTxt.Size = New System.Drawing.Size(100, 29)
        Me.GreenTxt.TabIndex = 93
        Me.GreenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BlueTxt
        '
        Me.BlueTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.BlueTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueTxt.Location = New System.Drawing.Point(84, 250)
        Me.BlueTxt.Name = "BlueTxt"
        Me.BlueTxt.Size = New System.Drawing.Size(100, 29)
        Me.BlueTxt.TabIndex = 94
        Me.BlueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'backgroundColourSetting
        '
        Me.backgroundColourSetting.Enabled = True
        Me.backgroundColourSetting.Interval = 1
        '
        'StartBtn
        '
        Me.StartBtn.BackgroundImage = Global.colourpicker.My.Resources.Resources.pen_il
        Me.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StartBtn.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBtn.Location = New System.Drawing.Point(12, 36)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(172, 129)
        Me.StartBtn.TabIndex = 0
        Me.startTip.SetToolTip(Me.StartBtn, "Drag me to start picking a colour")
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'RGBHEXSOLIDTIMER
        '
        Me.RGBHEXSOLIDTIMER.Enabled = True
        Me.RGBHEXSOLIDTIMER.Interval = 1
        '
        'savedColourTimer
        '
        Me.savedColourTimer.Enabled = True
        Me.savedColourTimer.Interval = 1
        '
        'picBoxTimer
        '
        Me.picBoxTimer.Enabled = True
        Me.picBoxTimer.Interval = 1
        '
        'Slot5
        '
        Me.Slot5.BackColor = System.Drawing.Color.Transparent
        Me.Slot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Slot5.Location = New System.Drawing.Point(523, 128)
        Me.Slot5.Name = "Slot5"
        Me.Slot5.Size = New System.Drawing.Size(22, 22)
        Me.Slot5.TabIndex = 90
        Me.Slot5.TabStop = False
        '
        'Slot4
        '
        Me.Slot4.BackColor = System.Drawing.Color.Transparent
        Me.Slot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Slot4.Location = New System.Drawing.Point(523, 105)
        Me.Slot4.Name = "Slot4"
        Me.Slot4.Size = New System.Drawing.Size(22, 22)
        Me.Slot4.TabIndex = 89
        Me.Slot4.TabStop = False
        '
        'Slot3
        '
        Me.Slot3.BackColor = System.Drawing.Color.Transparent
        Me.Slot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Slot3.Location = New System.Drawing.Point(523, 82)
        Me.Slot3.Name = "Slot3"
        Me.Slot3.Size = New System.Drawing.Size(22, 22)
        Me.Slot3.TabIndex = 88
        Me.Slot3.TabStop = False
        '
        'Slot2
        '
        Me.Slot2.BackColor = System.Drawing.Color.Transparent
        Me.Slot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Slot2.Location = New System.Drawing.Point(523, 59)
        Me.Slot2.Name = "Slot2"
        Me.Slot2.Size = New System.Drawing.Size(22, 22)
        Me.Slot2.TabIndex = 87
        Me.Slot2.TabStop = False
        '
        'Slot1
        '
        Me.Slot1.BackColor = System.Drawing.Color.Transparent
        Me.Slot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Slot1.Location = New System.Drawing.Point(523, 36)
        Me.Slot1.Name = "Slot1"
        Me.Slot1.Size = New System.Drawing.Size(22, 22)
        Me.Slot1.TabIndex = 86
        Me.Slot1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox1.Location = New System.Drawing.Point(308, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 115)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(592, 291)
        Me.Controls.Add(Me.BlueTxt)
        Me.Controls.Add(Me.GreenTxt)
        Me.Controls.Add(Me.RedTxt)
        Me.Controls.Add(Me.ColourCode)
        Me.Controls.Add(Me.Slot5)
        Me.Controls.Add(Me.Slot4)
        Me.Controls.Add(Me.Slot3)
        Me.Controls.Add(Me.Slot2)
        Me.Controls.Add(Me.Slot1)
        Me.Controls.Add(Me.Zoom)
        Me.Controls.Add(Me.PixelSlider)
        Me.Controls.Add(Me.Blue5)
        Me.Controls.Add(Me.Blue4)
        Me.Controls.Add(Me.Blue3)
        Me.Controls.Add(Me.Blue2)
        Me.Controls.Add(Me.Blue1)
        Me.Controls.Add(Me.Green5)
        Me.Controls.Add(Me.Green4)
        Me.Controls.Add(Me.Green3)
        Me.Controls.Add(Me.Green2)
        Me.Controls.Add(Me.Green1)
        Me.Controls.Add(Me.Red5)
        Me.Controls.Add(Me.Red4)
        Me.Controls.Add(Me.Red3)
        Me.Controls.Add(Me.Red2)
        Me.Controls.Add(Me.Red1)
        Me.Controls.Add(Me.Hex5)
        Me.Controls.Add(Me.Hex4)
        Me.Controls.Add(Me.Hex3)
        Me.Controls.Add(Me.Hex2)
        Me.Controls.Add(Me.Hex1)
        Me.Controls.Add(Me.XYmouse)
        Me.Controls.Add(Me.AddHex)
        Me.Controls.Add(Me.Del5)
        Me.Controls.Add(Me.Del4)
        Me.Controls.Add(Me.Del3)
        Me.Controls.Add(Me.Del2)
        Me.Controls.Add(Me.Del1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Hashtag)
        Me.Controls.Add(Me.HexCopy)
        Me.Controls.Add(Me.BlueCopy)
        Me.Controls.Add(Me.GreenCopy)
        Me.Controls.Add(Me.RedCopy)
        Me.Controls.Add(Me.BlueLbl)
        Me.Controls.Add(Me.GreenLbl)
        Me.Controls.Add(Me.RedLbl)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colour Picker v1.4.1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PixelSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartBtn As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SSChk As Timer
    Friend WithEvents RedLbl As Label
    Friend WithEvents GreenLbl As Label
    Friend WithEvents BlueLbl As Label
    Friend WithEvents RedCopy As Button
    Friend WithEvents GreenCopy As Button
    Friend WithEvents BlueCopy As Button
    Friend WithEvents HexCopy As Button
    Friend WithEvents AddHex As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyRedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyGreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyHexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hashtag As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Del1 As Button
    Friend WithEvents Del2 As Button
    Friend WithEvents Del3 As Button
    Friend WithEvents Del4 As Button
    Friend WithEvents Del5 As Button
    Friend WithEvents XYmouse As Label
    Friend WithEvents Hex1 As TextBox
    Friend WithEvents Hex2 As TextBox
    Friend WithEvents Hex3 As TextBox
    Friend WithEvents Hex4 As TextBox
    Friend WithEvents Hex5 As TextBox
    Friend WithEvents Red1 As TextBox
    Friend WithEvents Red2 As TextBox
    Friend WithEvents Red3 As TextBox
    Friend WithEvents Red4 As TextBox
    Friend WithEvents Red5 As TextBox
    Friend WithEvents Green1 As TextBox
    Friend WithEvents Green2 As TextBox
    Friend WithEvents Green3 As TextBox
    Friend WithEvents Green4 As TextBox
    Friend WithEvents Green5 As TextBox
    Friend WithEvents Blue1 As TextBox
    Friend WithEvents Blue2 As TextBox
    Friend WithEvents Blue3 As TextBox
    Friend WithEvents Blue4 As TextBox
    Friend WithEvents Blue5 As TextBox
    Friend WithEvents PixelSlider As TrackBar
    Friend WithEvents Zoom As Label
    Friend WithEvents Slot1 As PictureBox
    Friend WithEvents Slot2 As PictureBox
    Friend WithEvents Slot3 As PictureBox
    Friend WithEvents Slot4 As PictureBox
    Friend WithEvents Slot5 As PictureBox
    Friend WithEvents ColourCode As TextBox
    Friend WithEvents RedTxt As TextBox
    Friend WithEvents GreenTxt As TextBox
    Friend WithEvents BlueTxt As TextBox
    Friend WithEvents DeleteRowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Row1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Row2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Row3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Row4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Row5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents backgroundColourSetting As Timer
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents startTip As ToolTip
    Friend WithEvents RGBHEXSOLIDTIMER As Timer
    Friend WithEvents savedColourTimer As Timer
    Friend WithEvents HelpWithColourPickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picBoxTimer As Timer
End Class
