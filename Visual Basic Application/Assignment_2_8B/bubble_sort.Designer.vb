<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bubble_sort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bubble_sort))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.rbOption4 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbOption3 = New System.Windows.Forms.RadioButton()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bubble_sort_text = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblQuizQuestion = New System.Windows.Forms.GroupBox()
        Me.rbOption2 = New System.Windows.Forms.RadioButton()
        Me.rbOption1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bubble_sort_reset = New System.Windows.Forms.Button()
        Me.bubble_sort_size = New System.Windows.Forms.TextBox()
        Me.bubble_sort_create = New System.Windows.Forms.Button()
        Me.linked_list_back = New System.Windows.Forms.Button()
        Me.bubble_sort_fillRandom = New System.Windows.Forms.Button()
        Me.bubble_sort_step = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bubble_sort_title = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.lblQuizQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnNext.Location = New System.Drawing.Point(715, 232)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 39)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(822, 31)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(51, 17)
        Me.lblQuestionNumber.TabIndex = 4
        Me.lblQuestionNumber.Text = "Label1"
        '
        'rbOption4
        '
        Me.rbOption4.AutoSize = True
        Me.rbOption4.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbOption4.Location = New System.Drawing.Point(44, 160)
        Me.rbOption4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption4.Name = "rbOption4"
        Me.rbOption4.Size = New System.Drawing.Size(147, 29)
        Me.rbOption4.TabIndex = 3
        Me.rbOption4.TabStop = True
        Me.rbOption4.Text = "RadioButton4"
        Me.rbOption4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(43, 457)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 272)
        Me.Panel1.TabIndex = 0
        '
        'rbOption3
        '
        Me.rbOption3.AutoSize = True
        Me.rbOption3.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbOption3.Location = New System.Drawing.Point(44, 121)
        Me.rbOption3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption3.Name = "rbOption3"
        Me.rbOption3.Size = New System.Drawing.Size(147, 29)
        Me.rbOption3.TabIndex = 2
        Me.rbOption3.TabStop = True
        Me.rbOption3.Text = "RadioButton3"
        Me.rbOption3.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnPrev.Location = New System.Drawing.Point(590, 232)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(101, 39)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox2.Image = Global.Assignment_2_8B.My.Resources.Resources.neural_network__1_
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.ErrorImage = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.Image = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.InitialImage = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(914, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSubmit.Location = New System.Drawing.Point(648, 1112)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(123, 32)
        Me.btnSubmit.TabIndex = 42
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(48, 750)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(585, 44)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Let's check your understanding!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(69, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(635, 44)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Let's now visualize what we learnt!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(87, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 46)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "AlgoWizard"
        '
        'bubble_sort_text
        '
        Me.bubble_sort_text.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.bubble_sort_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubble_sort_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bubble_sort_text.Location = New System.Drawing.Point(21, 113)
        Me.bubble_sort_text.Name = "bubble_sort_text"
        Me.bubble_sort_text.ReadOnly = True
        Me.bubble_sort_text.Size = New System.Drawing.Size(898, 253)
        Me.bubble_sort_text.TabIndex = 46
        Me.bubble_sort_text.Text = resources.GetString("bubble_sort_text.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(340, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 55)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Bubble Sort"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblQuizQuestion)
        Me.Panel2.Controls.Add(Me.btnSubmit)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.bubble_sort_text)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.bubble_sort_reset)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.bubble_sort_size)
        Me.Panel2.Controls.Add(Me.bubble_sort_create)
        Me.Panel2.Controls.Add(Me.linked_list_back)
        Me.Panel2.Controls.Add(Me.bubble_sort_fillRandom)
        Me.Panel2.Controls.Add(Me.bubble_sort_step)
        Me.Panel2.Location = New System.Drawing.Point(9, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(990, 492)
        Me.Panel2.TabIndex = 60
        '
        'lblQuizQuestion
        '
        Me.lblQuizQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblQuizQuestion.Controls.Add(Me.btnNext)
        Me.lblQuizQuestion.Controls.Add(Me.lblQuestionNumber)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption4)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption3)
        Me.lblQuizQuestion.Controls.Add(Me.btnPrev)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption2)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption1)
        Me.lblQuizQuestion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQuizQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuizQuestion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuizQuestion.Location = New System.Drawing.Point(43, 822)
        Me.lblQuizQuestion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblQuizQuestion.Name = "lblQuizQuestion"
        Me.lblQuizQuestion.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblQuizQuestion.Size = New System.Drawing.Size(887, 253)
        Me.lblQuizQuestion.TabIndex = 43
        Me.lblQuizQuestion.TabStop = False
        Me.lblQuizQuestion.Text = "GroupBox1"
        '
        'rbOption2
        '
        Me.rbOption2.AutoSize = True
        Me.rbOption2.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbOption2.Location = New System.Drawing.Point(44, 80)
        Me.rbOption2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption2.Name = "rbOption2"
        Me.rbOption2.Size = New System.Drawing.Size(147, 29)
        Me.rbOption2.TabIndex = 1
        Me.rbOption2.TabStop = True
        Me.rbOption2.Text = "RadioButton2"
        Me.rbOption2.UseVisualStyleBackColor = True
        '
        'rbOption1
        '
        Me.rbOption1.AutoSize = True
        Me.rbOption1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbOption1.Location = New System.Drawing.Point(44, 39)
        Me.rbOption1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOption1.Name = "rbOption1"
        Me.rbOption1.Size = New System.Drawing.Size(147, 29)
        Me.rbOption1.TabIndex = 0
        Me.rbOption1.TabStop = True
        Me.rbOption1.Text = "RadioButton1"
        Me.rbOption1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(529, 1112)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 32)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bubble_sort_reset
        '
        Me.bubble_sort_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bubble_sort_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bubble_sort_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubble_sort_reset.Location = New System.Drawing.Point(784, 691)
        Me.bubble_sort_reset.Margin = New System.Windows.Forms.Padding(4)
        Me.bubble_sort_reset.Name = "bubble_sort_reset"
        Me.bubble_sort_reset.Size = New System.Drawing.Size(135, 38)
        Me.bubble_sort_reset.TabIndex = 54
        Me.bubble_sort_reset.Text = "Reset"
        Me.bubble_sort_reset.UseVisualStyleBackColor = False
        '
        'bubble_sort_size
        '
        Me.bubble_sort_size.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.bubble_sort_size.Cursor = System.Windows.Forms.Cursors.Default
        Me.bubble_sort_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubble_sort_size.Location = New System.Drawing.Point(784, 474)
        Me.bubble_sort_size.Margin = New System.Windows.Forms.Padding(4)
        Me.bubble_sort_size.Multiline = True
        Me.bubble_sort_size.Name = "bubble_sort_size"
        Me.bubble_sort_size.Size = New System.Drawing.Size(135, 37)
        Me.bubble_sort_size.TabIndex = 2
        '
        'bubble_sort_create
        '
        Me.bubble_sort_create.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bubble_sort_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bubble_sort_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubble_sort_create.Location = New System.Drawing.Point(784, 545)
        Me.bubble_sort_create.Margin = New System.Windows.Forms.Padding(4)
        Me.bubble_sort_create.Name = "bubble_sort_create"
        Me.bubble_sort_create.Size = New System.Drawing.Size(135, 42)
        Me.bubble_sort_create.TabIndex = 4
        Me.bubble_sort_create.Text = "Create"
        Me.bubble_sort_create.UseVisualStyleBackColor = False
        '
        'linked_list_back
        '
        Me.linked_list_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linked_list_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linked_list_back.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.linked_list_back.Location = New System.Drawing.Point(787, 1112)
        Me.linked_list_back.Margin = New System.Windows.Forms.Padding(4)
        Me.linked_list_back.Name = "linked_list_back"
        Me.linked_list_back.Size = New System.Drawing.Size(123, 32)
        Me.linked_list_back.TabIndex = 41
        Me.linked_list_back.Text = "Back"
        Me.linked_list_back.UseVisualStyleBackColor = False
        '
        'bubble_sort_fillRandom
        '
        Me.bubble_sort_fillRandom.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bubble_sort_fillRandom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bubble_sort_fillRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubble_sort_fillRandom.Location = New System.Drawing.Point(784, 595)
        Me.bubble_sort_fillRandom.Margin = New System.Windows.Forms.Padding(4)
        Me.bubble_sort_fillRandom.Name = "bubble_sort_fillRandom"
        Me.bubble_sort_fillRandom.Size = New System.Drawing.Size(135, 39)
        Me.bubble_sort_fillRandom.TabIndex = 0
        Me.bubble_sort_fillRandom.Text = "Fill Random"
        Me.bubble_sort_fillRandom.UseVisualStyleBackColor = False
        '
        'bubble_sort_step
        '
        Me.bubble_sort_step.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bubble_sort_step.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bubble_sort_step.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubble_sort_step.Location = New System.Drawing.Point(784, 642)
        Me.bubble_sort_step.Margin = New System.Windows.Forms.Padding(4)
        Me.bubble_sort_step.Name = "bubble_sort_step"
        Me.bubble_sort_step.Size = New System.Drawing.Size(135, 41)
        Me.bubble_sort_step.TabIndex = 5
        Me.bubble_sort_step.Text = "Step"
        Me.bubble_sort_step.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(723, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 48)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Main Menu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bubble_sort_title
        '
        Me.bubble_sort_title.AutoSize = True
        Me.bubble_sort_title.BackColor = System.Drawing.Color.White
        Me.bubble_sort_title.Cursor = System.Windows.Forms.Cursors.Default
        Me.bubble_sort_title.Font = New System.Drawing.Font("Arial", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubble_sort_title.ForeColor = System.Drawing.Color.OliveDrab
        Me.bubble_sort_title.Location = New System.Drawing.Point(177, -741)
        Me.bubble_sort_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bubble_sort_title.Name = "bubble_sort_title"
        Me.bubble_sort_title.Size = New System.Drawing.Size(209, 39)
        Me.bubble_sort_title.TabIndex = 55
        Me.bubble_sort_title.Text = "Bubble Sort"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1002, 582)
        Me.ShapeContainer1.TabIndex = 63
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(-2, -1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1004, 589)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(780, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Size"
        '
        'bubble_sort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1002, 582)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bubble_sort_title)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "bubble_sort"
        Me.Text = "bubble_sort"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.lblQuizQuestion.ResumeLayout(False)
        Me.lblQuizQuestion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents rbOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bubble_sort_text As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblQuizQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents rbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bubble_sort_size As System.Windows.Forms.TextBox
    Friend WithEvents bubble_sort_create As System.Windows.Forms.Button
    Friend WithEvents linked_list_back As System.Windows.Forms.Button
    Friend WithEvents bubble_sort_fillRandom As System.Windows.Forms.Button
    Friend WithEvents bubble_sort_step As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bubble_sort_reset As System.Windows.Forms.Button
    Friend WithEvents bubble_sort_title As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
