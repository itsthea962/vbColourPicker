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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.changeLogFile = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 100)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Colour Picker"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "v1.4, an open-source project"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 131)
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
        'changeLogFile
        '
        Me.changeLogFile.Location = New System.Drawing.Point(74, 271)
        Me.changeLogFile.Name = "changeLogFile"
        Me.changeLogFile.Size = New System.Drawing.Size(108, 35)
        Me.changeLogFile.TabIndex = 6
        Me.changeLogFile.Text = "Open ChangeLog"
        Me.changeLogFile.UseVisualStyleBackColor = True
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(265, 357)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.changeLogFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "About Colour Picker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents changeLogFile As Button
    Friend WithEvents Label4 As Label
End Class
