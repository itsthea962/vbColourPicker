<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EXITPicBtn = New System.Windows.Forms.PictureBox()
        Me.logoPicBoxFrm2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoPicBoxFrm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Click and drag to start picking a colour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Click to save the current Hex, R, G and B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(375, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Next to saved data: remove the saved data | Top-right: exit Colour Picker"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Open the Options menu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Open this Help Menu you are currently on"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(399, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Depending on the colour, this will either copy the main R, G, B or Hex values"
        '
        'fadeInTimer
        '
        Me.fadeInTimer.Interval = 1
        '
        'fadeOutTimer
        '
        Me.fadeOutTimer.Interval = 1
        '
        'EXITPicBtn
        '
        Me.EXITPicBtn.BackColor = System.Drawing.Color.Transparent
        Me.EXITPicBtn.Image = Global.colourpicker.My.Resources.Resources._error
        Me.EXITPicBtn.Location = New System.Drawing.Point(444, 2)
        Me.EXITPicBtn.Name = "EXITPicBtn"
        Me.EXITPicBtn.Size = New System.Drawing.Size(38, 38)
        Me.EXITPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EXITPicBtn.TabIndex = 117
        Me.EXITPicBtn.TabStop = False
        '
        'logoPicBoxFrm2
        '
        Me.logoPicBoxFrm2.Image = Global.colourpicker.My.Resources.Resources.Bigicon
        Me.logoPicBoxFrm2.Location = New System.Drawing.Point(2, 2)
        Me.logoPicBoxFrm2.Name = "logoPicBoxFrm2"
        Me.logoPicBoxFrm2.Size = New System.Drawing.Size(38, 38)
        Me.logoPicBoxFrm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPicBoxFrm2.TabIndex = 116
        Me.logoPicBoxFrm2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.colourpicker.My.Resources.Resources._256_file
        Me.PictureBox6.Location = New System.Drawing.Point(12, 269)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.colourpicker.My.Resources.Resources.info
        Me.PictureBox5.Location = New System.Drawing.Point(12, 225)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.colourpicker.My.Resources.Resources.controls
        Me.PictureBox4.Location = New System.Drawing.Point(12, 181)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.colourpicker.My.Resources.Resources._error
        Me.PictureBox3.Location = New System.Drawing.Point(12, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.colourpicker.My.Resources.Resources.upload
        Me.PictureBox2.Location = New System.Drawing.Point(12, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.colourpicker.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(12, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.colourpicker.My.Resources.Resources.help
        Me.PictureBox7.Location = New System.Drawing.Point(200, 5)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(85, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 118
        Me.PictureBox7.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(483, 324)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.EXITPicBtn)
        Me.Controls.Add(Me.logoPicBoxFrm2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help with Colour Picker"
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoPicBoxFrm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents logoPicBoxFrm2 As PictureBox
    Friend WithEvents EXITPicBtn As PictureBox
    Friend WithEvents fadeInTimer As Timer
    Friend WithEvents fadeOutTimer As Timer
    Friend WithEvents PictureBox7 As PictureBox
End Class
