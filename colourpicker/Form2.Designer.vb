<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backgroundColour = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButtonSmall = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNormal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSmaller = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sizeWindow = New System.Windows.Forms.Timer(Me.components)
        Me.opacitySilderTimer = New System.Windows.Forms.Timer(Me.components)
        Me.opacitySlider = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.alwaysOnTopCheckBox = New System.Windows.Forms.CheckBox()
        Me.onTopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.backColourToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.fadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.withHashtagCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.effectCheckbox = New System.Windows.Forms.CheckBox()
        Me.resetSettingsPicBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logoPicBoxFrm2 = New System.Windows.Forms.PictureBox()
        Me.EXITPicBtn = New System.Windows.Forms.PictureBox()
        CType(Me.opacitySlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resetSettingsPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoPicBoxFrm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.backColourToolTip.SetToolTip(Me.ComboBox1, "Beware, some colours of fonts may not work!")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Background Colour:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'backgroundColour
        '
        Me.backgroundColour.Enabled = True
        Me.backgroundColour.Interval = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Size Of Window:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButtonSmall
        '
        Me.RadioButtonSmall.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSmall.Location = New System.Drawing.Point(142, 104)
        Me.RadioButtonSmall.Name = "RadioButtonSmall"
        Me.RadioButtonSmall.Size = New System.Drawing.Size(73, 21)
        Me.RadioButtonSmall.TabIndex = 3
        Me.RadioButtonSmall.TabStop = True
        Me.RadioButtonSmall.Text = "Small"
        Me.RadioButtonSmall.UseVisualStyleBackColor = True
        '
        'RadioButtonNormal
        '
        Me.RadioButtonNormal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNormal.Location = New System.Drawing.Point(142, 131)
        Me.RadioButtonNormal.Name = "RadioButtonNormal"
        Me.RadioButtonNormal.Size = New System.Drawing.Size(73, 21)
        Me.RadioButtonNormal.TabIndex = 4
        Me.RadioButtonNormal.TabStop = True
        Me.RadioButtonNormal.Text = "Normal"
        Me.RadioButtonNormal.UseVisualStyleBackColor = True
        '
        'RadioButtonSmaller
        '
        Me.RadioButtonSmaller.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSmaller.Location = New System.Drawing.Point(142, 77)
        Me.RadioButtonSmaller.Name = "RadioButtonSmaller"
        Me.RadioButtonSmaller.Size = New System.Drawing.Size(73, 21)
        Me.RadioButtonSmaller.TabIndex = 5
        Me.RadioButtonSmaller.TabStop = True
        Me.RadioButtonSmaller.Text = "Smaller"
        Me.RadioButtonSmaller.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Opacity:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sizeWindow
        '
        Me.sizeWindow.Interval = 1
        '
        'opacitySilderTimer
        '
        Me.opacitySilderTimer.Interval = 1
        '
        'opacitySlider
        '
        Me.opacitySlider.AutoSize = False
        Me.opacitySlider.LargeChange = 1
        Me.opacitySlider.Location = New System.Drawing.Point(73, 158)
        Me.opacitySlider.Maximum = 100
        Me.opacitySlider.Minimum = 50
        Me.opacitySlider.Name = "opacitySlider"
        Me.opacitySlider.Size = New System.Drawing.Size(190, 45)
        Me.opacitySlider.TabIndex = 10
        Me.opacitySlider.Value = 50
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Always On Top:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'alwaysOnTopCheckBox
        '
        Me.alwaysOnTopCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alwaysOnTopCheckBox.Location = New System.Drawing.Point(217, 206)
        Me.alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox"
        Me.alwaysOnTopCheckBox.Size = New System.Drawing.Size(47, 24)
        Me.alwaysOnTopCheckBox.TabIndex = 12
        Me.alwaysOnTopCheckBox.Text = "Yes"
        Me.alwaysOnTopCheckBox.UseVisualStyleBackColor = True
        '
        'onTopTimer
        '
        Me.onTopTimer.Enabled = True
        Me.onTopTimer.Interval = 1
        '
        'backColourToolTip
        '
        Me.backColourToolTip.AutomaticDelay = 250
        '
        'fadeInTimer
        '
        Me.fadeInTimer.Interval = 1
        '
        'fadeOutTimer
        '
        Me.fadeOutTimer.Interval = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 17)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "With # In Hex Code:"
        '
        'withHashtagCheckbox
        '
        Me.withHashtagCheckbox.AutoSize = True
        Me.withHashtagCheckbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withHashtagCheckbox.Location = New System.Drawing.Point(217, 245)
        Me.withHashtagCheckbox.Name = "withHashtagCheckbox"
        Me.withHashtagCheckbox.Size = New System.Drawing.Size(46, 21)
        Me.withHashtagCheckbox.TabIndex = 117
        Me.withHashtagCheckbox.Text = "Yes"
        Me.withHashtagCheckbox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Effects:"
        '
        'effectCheckbox
        '
        Me.effectCheckbox.AutoSize = True
        Me.effectCheckbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.effectCheckbox.Location = New System.Drawing.Point(217, 282)
        Me.effectCheckbox.Name = "effectCheckbox"
        Me.effectCheckbox.Size = New System.Drawing.Size(46, 21)
        Me.effectCheckbox.TabIndex = 119
        Me.effectCheckbox.Text = "Yes"
        Me.effectCheckbox.UseVisualStyleBackColor = True
        '
        'resetSettingsPicBox
        '
        Me.resetSettingsPicBox.BackColor = System.Drawing.Color.Transparent
        Me.resetSettingsPicBox.Image = Global.colourpicker.My.Resources.Resources.resetSettings
        Me.resetSettingsPicBox.Location = New System.Drawing.Point(44, 319)
        Me.resetSettingsPicBox.Name = "resetSettingsPicBox"
        Me.resetSettingsPicBox.Size = New System.Drawing.Size(192, 36)
        Me.resetSettingsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.resetSettingsPicBox.TabIndex = 121
        Me.resetSettingsPicBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.colourpicker.My.Resources.Resources.options
        Me.PictureBox1.Location = New System.Drawing.Point(92, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'logoPicBoxFrm2
        '
        Me.logoPicBoxFrm2.Image = Global.colourpicker.My.Resources.Resources.Bigicon
        Me.logoPicBoxFrm2.Location = New System.Drawing.Point(2, 2)
        Me.logoPicBoxFrm2.Name = "logoPicBoxFrm2"
        Me.logoPicBoxFrm2.Size = New System.Drawing.Size(38, 38)
        Me.logoPicBoxFrm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPicBoxFrm2.TabIndex = 115
        Me.logoPicBoxFrm2.TabStop = False
        '
        'EXITPicBtn
        '
        Me.EXITPicBtn.BackColor = System.Drawing.Color.Transparent
        Me.EXITPicBtn.Image = Global.colourpicker.My.Resources.Resources._error
        Me.EXITPicBtn.Location = New System.Drawing.Point(242, 2)
        Me.EXITPicBtn.Name = "EXITPicBtn"
        Me.EXITPicBtn.Size = New System.Drawing.Size(38, 38)
        Me.EXITPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EXITPicBtn.TabIndex = 104
        Me.EXITPicBtn.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(282, 369)
        Me.Controls.Add(Me.resetSettingsPicBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.effectCheckbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.withHashtagCheckbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.logoPicBoxFrm2)
        Me.Controls.Add(Me.EXITPicBtn)
        Me.Controls.Add(Me.alwaysOnTopCheckBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.opacitySlider)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButtonSmaller)
        Me.Controls.Add(Me.RadioButtonNormal)
        Me.Controls.Add(Me.RadioButtonSmall)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TopMost = True
        CType(Me.opacitySlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resetSettingsPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoPicBoxFrm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backgroundColour As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButtonSmall As RadioButton
    Friend WithEvents RadioButtonNormal As RadioButton
    Friend WithEvents RadioButtonSmaller As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents sizeWindow As Timer
    Friend WithEvents opacitySilderTimer As Timer
    Friend WithEvents opacitySlider As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents alwaysOnTopCheckBox As CheckBox
    Friend WithEvents onTopTimer As Timer
    Friend WithEvents backColourToolTip As ToolTip
    Friend WithEvents fadeInTimer As Timer
    Friend WithEvents fadeOutTimer As Timer
    Friend WithEvents EXITPicBtn As PictureBox
    Friend WithEvents logoPicBoxFrm2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents withHashtagCheckbox As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents effectCheckbox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents resetSettingsPicBox As PictureBox
End Class
