<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.openChangelogPicBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EXITPicBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.openChangelogPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "v1.5, an open-source project"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 131)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(241, 16)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/theo3334/vbColourPicker"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 35)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Go to my GitHib repo to report bugs or give suggestions"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 35)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Coded in da wonderful Visual Basic.NET"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fadeInTimer
        '
        Me.fadeInTimer.Interval = 1
        '
        'fadeOutTimer
        '
        Me.fadeOutTimer.Interval = 1
        '
        'openChangelogPicBox
        '
        Me.openChangelogPicBox.BackColor = System.Drawing.Color.Transparent
        Me.openChangelogPicBox.Image = Global.colourpicker.My.Resources.Resources.changeLog
        Me.openChangelogPicBox.Location = New System.Drawing.Point(54, 269)
        Me.openChangelogPicBox.Name = "openChangelogPicBox"
        Me.openChangelogPicBox.Size = New System.Drawing.Size(155, 39)
        Me.openChangelogPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.openChangelogPicBox.TabIndex = 10
        Me.openChangelogPicBox.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(73, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 104)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'EXITPicBtn
        '
        Me.EXITPicBtn.Image = Global.colourpicker.My.Resources.Resources._error
        Me.EXITPicBtn.Location = New System.Drawing.Point(225, 2)
        Me.EXITPicBtn.Name = "EXITPicBtn"
        Me.EXITPicBtn.Size = New System.Drawing.Size(38, 38)
        Me.EXITPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EXITPicBtn.TabIndex = 8
        Me.EXITPicBtn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(265, 357)
        Me.Controls.Add(Me.openChangelogPicBox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.EXITPicBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Colour Picker"
        CType(Me.openChangelogPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fadeInTimer As Timer
    Friend WithEvents EXITPicBtn As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents fadeOutTimer As Timer
    Friend WithEvents openChangelogPicBox As PictureBox
End Class
