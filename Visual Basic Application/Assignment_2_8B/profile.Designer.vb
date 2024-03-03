<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profile))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Topics = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SearchProgress = New System.Windows.Forms.ProgressBar()
        Me.ArrayProgress = New System.Windows.Forms.ProgressBar()
        Me.StackProgress = New System.Windows.Forms.ProgressBar()
        Me.LLProgress = New System.Windows.Forms.ProgressBar()
        Me.QueueProgress = New System.Windows.Forms.ProgressBar()
        Me.SortingProgress = New System.Windows.Forms.ProgressBar()
        Me.UserInfo = New System.Windows.Forms.Panel()
        Me.Username = New System.Windows.Forms.Label()
        Me.UserName2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.main_welcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Topics.SuspendLayout()
        Me.UserInfo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Topics)
        Me.Panel1.Controls.Add(Me.UserInfo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.main_welcome)
        Me.Panel1.Location = New System.Drawing.Point(0, 114)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1339, 639)
        Me.Panel1.TabIndex = 53
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(111, 543)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(251, 54)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Topics
        '
        Me.Topics.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Topics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Topics.Controls.Add(Me.Label6)
        Me.Topics.Controls.Add(Me.Label14)
        Me.Topics.Controls.Add(Me.Label13)
        Me.Topics.Controls.Add(Me.Label12)
        Me.Topics.Controls.Add(Me.Label11)
        Me.Topics.Controls.Add(Me.Label9)
        Me.Topics.Controls.Add(Me.Label15)
        Me.Topics.Controls.Add(Me.SearchProgress)
        Me.Topics.Controls.Add(Me.ArrayProgress)
        Me.Topics.Controls.Add(Me.StackProgress)
        Me.Topics.Controls.Add(Me.LLProgress)
        Me.Topics.Controls.Add(Me.QueueProgress)
        Me.Topics.Controls.Add(Me.SortingProgress)
        Me.Topics.Location = New System.Drawing.Point(489, 132)
        Me.Topics.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Topics.Name = "Topics"
        Me.Topics.Size = New System.Drawing.Size(749, 465)
        Me.Topics.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(292, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 43)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Progress"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(59, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 43)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Searching"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(59, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 43)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Linked Lists"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(59, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 43)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Queues"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(59, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 43)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Stacks"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(59, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 43)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Arrays"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(59, 400)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 43)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Sorting"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchProgress
        '
        Me.SearchProgress.Location = New System.Drawing.Point(253, 336)
        Me.SearchProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchProgress.Maximum = 10
        Me.SearchProgress.Name = "SearchProgress"
        Me.SearchProgress.Size = New System.Drawing.Size(444, 43)
        Me.SearchProgress.TabIndex = 10
        '
        'ArrayProgress
        '
        Me.ArrayProgress.Location = New System.Drawing.Point(253, 87)
        Me.ArrayProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ArrayProgress.Maximum = 10
        Me.ArrayProgress.Name = "ArrayProgress"
        Me.ArrayProgress.Size = New System.Drawing.Size(444, 43)
        Me.ArrayProgress.TabIndex = 9
        '
        'StackProgress
        '
        Me.StackProgress.Location = New System.Drawing.Point(253, 146)
        Me.StackProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StackProgress.Maximum = 10
        Me.StackProgress.Name = "StackProgress"
        Me.StackProgress.Size = New System.Drawing.Size(444, 43)
        Me.StackProgress.TabIndex = 8
        '
        'LLProgress
        '
        Me.LLProgress.Location = New System.Drawing.Point(253, 271)
        Me.LLProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LLProgress.Maximum = 10
        Me.LLProgress.Name = "LLProgress"
        Me.LLProgress.Size = New System.Drawing.Size(444, 43)
        Me.LLProgress.TabIndex = 7
        '
        'QueueProgress
        '
        Me.QueueProgress.Location = New System.Drawing.Point(253, 207)
        Me.QueueProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QueueProgress.Maximum = 10
        Me.QueueProgress.Name = "QueueProgress"
        Me.QueueProgress.Size = New System.Drawing.Size(444, 43)
        Me.QueueProgress.TabIndex = 6
        '
        'SortingProgress
        '
        Me.SortingProgress.Location = New System.Drawing.Point(253, 400)
        Me.SortingProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SortingProgress.Maximum = 10
        Me.SortingProgress.Name = "SortingProgress"
        Me.SortingProgress.Size = New System.Drawing.Size(444, 43)
        Me.SortingProgress.TabIndex = 5
        '
        'UserInfo
        '
        Me.UserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserInfo.Controls.Add(Me.Username)
        Me.UserInfo.Controls.Add(Me.UserName2)
        Me.UserInfo.Controls.Add(Me.PictureBox3)
        Me.UserInfo.Location = New System.Drawing.Point(81, 132)
        Me.UserInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(317, 384)
        Me.UserInfo.TabIndex = 21
        '
        'Username
        '
        Me.Username.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.Black
        Me.Username.Location = New System.Drawing.Point(87, 304)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(149, 39)
        Me.Username.TabIndex = 33
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName2
        '
        Me.UserName2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UserName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.UserName2.Location = New System.Drawing.Point(76, 254)
        Me.UserName2.Name = "UserName2"
        Me.UserName2.Size = New System.Drawing.Size(171, 50)
        Me.UserName2.TabIndex = 32
        Me.UserName2.Text = "Name"
        Me.UserName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(88, 65)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 135)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 935)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 693)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 19
        '
        'main_welcome
        '
        Me.main_welcome.AutoSize = True
        Me.main_welcome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.main_welcome.Font = New System.Drawing.Font("Bell MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_welcome.ForeColor = System.Drawing.Color.Black
        Me.main_welcome.Location = New System.Drawing.Point(565, 26)
        Me.main_welcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.main_welcome.Name = "main_welcome"
        Me.main_welcome.Size = New System.Drawing.Size(210, 69)
        Me.main_welcome.TabIndex = 10
        Me.main_welcome.Text = "Profile"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(129, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 52)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "AlgoWizard"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Location = New System.Drawing.Point(1, -1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1338, 115)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1339, 747)
        Me.ShapeContainer1.TabIndex = 56
        Me.ShapeContainer1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox2.Image = Global.Assignment_2_8B.My.Resources.Resources.neural_network__1_
        Me.PictureBox2.Location = New System.Drawing.Point(28, 17)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(89, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(1144, 30)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(163, 54)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 747)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "profile"
        Me.Text = "profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Topics.ResumeLayout(False)
        Me.UserInfo.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents main_welcome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Topics As System.Windows.Forms.Panel
    Friend WithEvents SortingProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents UserInfo As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents SearchProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents ArrayProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents StackProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents LLProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents QueueProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents UserName2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
