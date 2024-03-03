<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class merge_sort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(merge_sort))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.merge_sort_text = New System.Windows.Forms.TextBox()
        Me.lblQuizQuestion = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.rbOption4 = New System.Windows.Forms.RadioButton()
        Me.rbOption3 = New System.Windows.Forms.RadioButton()
        Me.rbOption2 = New System.Windows.Forms.RadioButton()
        Me.rbOption1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.merge_sort_fill_random = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mereg_sort_reset = New System.Windows.Forms.Button()
        Me.merge_sort_size = New System.Windows.Forms.TextBox()
        Me.merge_sort_step = New System.Windows.Forms.Button()
        Me.merge_sort_create = New System.Windows.Forms.Button()
        Me.merge_sort_feed = New System.Windows.Forms.Button()
        Me.merge_sort_size_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.lblQuizQuestion.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.merge_sort_text)
        Me.Panel2.Controls.Add(Me.lblQuizQuestion)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.merge_sort_fill_random)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.mereg_sort_reset)
        Me.Panel2.Controls.Add(Me.merge_sort_size)
        Me.Panel2.Controls.Add(Me.merge_sort_step)
        Me.Panel2.Controls.Add(Me.merge_sort_create)
        Me.Panel2.Controls.Add(Me.merge_sort_feed)
        Me.Panel2.Controls.Add(Me.merge_sort_size_label)
        Me.Panel2.Location = New System.Drawing.Point(5, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1297, 560)
        Me.Panel2.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(17, 999)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(705, 56)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Let's check your understanding!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(764, 56)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Let's now visualize what we learnt!"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Bell MT", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(488, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(329, 69)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Merge Sort"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1101, 1456)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 39)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(942, 1456)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 39)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'merge_sort_text
        '
        Me.merge_sort_text.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.merge_sort_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.merge_sort_text.Location = New System.Drawing.Point(24, 96)
        Me.merge_sort_text.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.merge_sort_text.Multiline = True
        Me.merge_sort_text.Name = "merge_sort_text"
        Me.merge_sort_text.ReadOnly = True
        Me.merge_sort_text.Size = New System.Drawing.Size(1211, 347)
        Me.merge_sort_text.TabIndex = 78
        Me.merge_sort_text.Text = resources.GetString("merge_sort_text.Text")
        '
        'lblQuizQuestion
        '
        Me.lblQuizQuestion.AutoSize = True
        Me.lblQuizQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblQuizQuestion.Controls.Add(Me.btnNext)
        Me.lblQuizQuestion.Controls.Add(Me.btnPrev)
        Me.lblQuizQuestion.Controls.Add(Me.lblQuestionNumber)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption4)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption3)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption2)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption1)
        Me.lblQuizQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuizQuestion.Location = New System.Drawing.Point(23, 1123)
        Me.lblQuizQuestion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblQuizQuestion.Name = "lblQuizQuestion"
        Me.lblQuizQuestion.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblQuizQuestion.Size = New System.Drawing.Size(1220, 270)
        Me.lblQuizQuestion.TabIndex = 75
        Me.lblQuizQuestion.TabStop = False
        Me.lblQuizQuestion.Text = "GroupBox1"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(1112, 207)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 30)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrev.Location = New System.Drawing.Point(1012, 207)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(91, 30)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(1151, 8)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(59, 20)
        Me.lblQuestionNumber.TabIndex = 4
        Me.lblQuestionNumber.Text = "Label1"
        '
        'rbOption4
        '
        Me.rbOption4.AutoSize = True
        Me.rbOption4.Location = New System.Drawing.Point(5, 185)
        Me.rbOption4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption4.Name = "rbOption4"
        Me.rbOption4.Size = New System.Drawing.Size(187, 33)
        Me.rbOption4.TabIndex = 3
        Me.rbOption4.TabStop = True
        Me.rbOption4.Text = "RadioButton4"
        Me.rbOption4.UseVisualStyleBackColor = True
        '
        'rbOption3
        '
        Me.rbOption3.AutoSize = True
        Me.rbOption3.Location = New System.Drawing.Point(5, 145)
        Me.rbOption3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption3.Name = "rbOption3"
        Me.rbOption3.Size = New System.Drawing.Size(187, 33)
        Me.rbOption3.TabIndex = 2
        Me.rbOption3.TabStop = True
        Me.rbOption3.Text = "RadioButton3"
        Me.rbOption3.UseVisualStyleBackColor = True
        '
        'rbOption2
        '
        Me.rbOption2.AutoSize = True
        Me.rbOption2.Location = New System.Drawing.Point(5, 105)
        Me.rbOption2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption2.Name = "rbOption2"
        Me.rbOption2.Size = New System.Drawing.Size(187, 33)
        Me.rbOption2.TabIndex = 1
        Me.rbOption2.TabStop = True
        Me.rbOption2.Text = "RadioButton2"
        Me.rbOption2.UseVisualStyleBackColor = True
        '
        'rbOption1
        '
        Me.rbOption1.AutoSize = True
        Me.rbOption1.Location = New System.Drawing.Point(5, 64)
        Me.rbOption1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption1.Name = "rbOption1"
        Me.rbOption1.Size = New System.Drawing.Size(187, 33)
        Me.rbOption1.TabIndex = 0
        Me.rbOption1.TabStop = True
        Me.rbOption1.Text = "RadioButton1"
        Me.rbOption1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(788, 1456)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 39)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'merge_sort_fill_random
        '
        Me.merge_sort_fill_random.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.merge_sort_fill_random.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.merge_sort_fill_random.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.merge_sort_fill_random.Location = New System.Drawing.Point(1032, 889)
        Me.merge_sort_fill_random.Margin = New System.Windows.Forms.Padding(4)
        Me.merge_sort_fill_random.Name = "merge_sort_fill_random"
        Me.merge_sort_fill_random.Size = New System.Drawing.Size(188, 41)
        Me.merge_sort_fill_random.TabIndex = 72
        Me.merge_sort_fill_random.Text = "Fill Random"
        Me.merge_sort_fill_random.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(23, 558)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(972, 390)
        Me.Panel1.TabIndex = 66
        '
        'mereg_sort_reset
        '
        Me.mereg_sort_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.mereg_sort_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mereg_sort_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mereg_sort_reset.Location = New System.Drawing.Point(1032, 798)
        Me.mereg_sort_reset.Margin = New System.Windows.Forms.Padding(4)
        Me.mereg_sort_reset.Name = "mereg_sort_reset"
        Me.mereg_sort_reset.Size = New System.Drawing.Size(188, 42)
        Me.mereg_sort_reset.TabIndex = 71
        Me.mereg_sort_reset.Text = "Reset"
        Me.mereg_sort_reset.UseVisualStyleBackColor = False
        '
        'merge_sort_size
        '
        Me.merge_sort_size.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.merge_sort_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.merge_sort_size.Location = New System.Drawing.Point(1032, 596)
        Me.merge_sort_size.Margin = New System.Windows.Forms.Padding(4)
        Me.merge_sort_size.Name = "merge_sort_size"
        Me.merge_sort_size.Size = New System.Drawing.Size(187, 30)
        Me.merge_sort_size.TabIndex = 68
        '
        'merge_sort_step
        '
        Me.merge_sort_step.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.merge_sort_step.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.merge_sort_step.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.merge_sort_step.Location = New System.Drawing.Point(1032, 746)
        Me.merge_sort_step.Margin = New System.Windows.Forms.Padding(4)
        Me.merge_sort_step.Name = "merge_sort_step"
        Me.merge_sort_step.Size = New System.Drawing.Size(188, 44)
        Me.merge_sort_step.TabIndex = 67
        Me.merge_sort_step.Text = "Step"
        Me.merge_sort_step.UseVisualStyleBackColor = False
        '
        'merge_sort_create
        '
        Me.merge_sort_create.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.merge_sort_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.merge_sort_create.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.merge_sort_create.Location = New System.Drawing.Point(1032, 644)
        Me.merge_sort_create.Margin = New System.Windows.Forms.Padding(4)
        Me.merge_sort_create.Name = "merge_sort_create"
        Me.merge_sort_create.Size = New System.Drawing.Size(188, 43)
        Me.merge_sort_create.TabIndex = 70
        Me.merge_sort_create.Text = "Create"
        Me.merge_sort_create.UseVisualStyleBackColor = False
        '
        'merge_sort_feed
        '
        Me.merge_sort_feed.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.merge_sort_feed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.merge_sort_feed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.merge_sort_feed.Location = New System.Drawing.Point(1032, 694)
        Me.merge_sort_feed.Margin = New System.Windows.Forms.Padding(4)
        Me.merge_sort_feed.Name = "merge_sort_feed"
        Me.merge_sort_feed.Size = New System.Drawing.Size(188, 44)
        Me.merge_sort_feed.TabIndex = 65
        Me.merge_sort_feed.Text = "Feed"
        Me.merge_sort_feed.UseVisualStyleBackColor = False
        Me.merge_sort_feed.Visible = False
        '
        'merge_sort_size_label
        '
        Me.merge_sort_size_label.AutoSize = True
        Me.merge_sort_size_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.merge_sort_size_label.Location = New System.Drawing.Point(1028, 567)
        Me.merge_sort_size_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.merge_sort_size_label.Name = "merge_sort_size_label"
        Me.merge_sort_size_label.Size = New System.Drawing.Size(51, 25)
        Me.merge_sort_size_label.TabIndex = 69
        Me.merge_sort_size_label.Text = "Size"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.Image = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.InitialImage = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(1205, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Footlight MT Light", 30.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 52)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "AlgoWizard"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox3.Image = Global.Assignment_2_8B.My.Resources.Resources.neural_network__1_
        Me.PictureBox3.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 74)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(1010, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 48)
        Me.Button4.TabIndex = 86
        Me.Button4.Text = "Main Menu"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'merge_sort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1302, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "merge_sort"
        Me.Text = "merge_sort"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.lblQuizQuestion.ResumeLayout(False)
        Me.lblQuizQuestion.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents merge_sort_text As System.Windows.Forms.TextBox
    Friend WithEvents lblQuizQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents rbOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents merge_sort_fill_random As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mereg_sort_reset As System.Windows.Forms.Button
    Friend WithEvents merge_sort_size As System.Windows.Forms.TextBox
    Friend WithEvents merge_sort_step As System.Windows.Forms.Button
    Friend WithEvents merge_sort_create As System.Windows.Forms.Button
    Friend WithEvents merge_sort_feed As System.Windows.Forms.Button
    Friend WithEvents merge_sort_size_label As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
