<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        GroupBox1 = New GroupBox()
        btnbck = New Button()
        btnffwd = New Button()
        btnStop = New Button()
        btnPlay = New Button()
        Label1 = New Label()
        tmridle = New Timer(components)
        Button1 = New Button()
        lblheader = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnbck)
        GroupBox1.Controls.Add(btnffwd)
        GroupBox1.Controls.Add(btnStop)
        GroupBox1.Controls.Add(btnPlay)
        GroupBox1.Location = New Point(12, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(360, 88)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "MultiMedia Controls"
        ' 
        ' btnbck
        ' 
        btnbck.BackColor = Color.White
        btnbck.BackgroundImage = My.Resources.Resources.previous_track_red_circle_arrow_20593
        btnbck.BackgroundImageLayout = ImageLayout.Stretch
        btnbck.Location = New Point(192, 26)
        btnbck.Name = "btnbck"
        btnbck.Size = New Size(61, 50)
        btnbck.TabIndex = 3
        btnbck.UseVisualStyleBackColor = False
        ' 
        ' btnffwd
        ' 
        btnffwd.BackColor = Color.White
        btnffwd.BackgroundImage = My.Resources.Resources.fast_forward_red_circle_arrow_20592
        btnffwd.BackgroundImageLayout = ImageLayout.Stretch
        btnffwd.Location = New Point(277, 26)
        btnffwd.Name = "btnffwd"
        btnffwd.Size = New Size(61, 50)
        btnffwd.TabIndex = 2
        btnffwd.UseVisualStyleBackColor = False
        ' 
        ' btnStop
        ' 
        btnStop.BackColor = Color.White
        btnStop.BackgroundImage = My.Resources.Resources.video_stop_5879
        btnStop.BackgroundImageLayout = ImageLayout.Stretch
        btnStop.Location = New Point(105, 26)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(61, 50)
        btnStop.TabIndex = 1
        btnStop.UseVisualStyleBackColor = False
        ' 
        ' btnPlay
        ' 
        btnPlay.BackColor = Color.White
        btnPlay.BackgroundImage = My.Resources.Resources.play_button_4214
        btnPlay.BackgroundImageLayout = ImageLayout.Stretch
        btnPlay.Location = New Point(20, 26)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(61, 50)
        btnPlay.TabIndex = 0
        btnPlay.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(129, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 15)
        Label1.TabIndex = 1
        Label1.Text = "Meij's Soft Development"
        ' 
        ' tmridle
        ' 
        tmridle.Interval = 1000
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(342, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(30, 25)
        Button1.TabIndex = 2
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        Button1.Visible = False
        ' 
        ' lblheader
        ' 
        lblheader.AutoSize = True
        lblheader.Location = New Point(12, 8)
        lblheader.Name = "lblheader"
        lblheader.Size = New Size(146, 15)
        lblheader.TabIndex = 3
        lblheader.Text = "Extended Virtual Keyboard"
        lblheader.Visible = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(394, 179)
        Controls.Add(lblheader)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmMain"
        Text = "Extra Virtual Key"
        TopMost = True
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnffwd As Button
    Friend WithEvents btnbck As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tmridle As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents lblheader As Label

End Class
