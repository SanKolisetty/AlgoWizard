<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class linked_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(linked_list))
        Me.linked_list_back = New System.Windows.Forms.Button()
        Me.pnlLinkedList = New System.Windows.Forms.Panel()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtIndex = New System.Windows.Forms.TextBox()
        Me.linked_list_delete = New System.Windows.Forms.Button()
        Me.linked_list_insert = New System.Windows.Forms.Button()
        Me.linked_list_search = New System.Windows.Forms.Button()
        Me.linked_list_append = New System.Windows.Forms.Button()
        Me.main_welcome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.linked_list_reset = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.lblQuizQuestion = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.rbOption4 = New System.Windows.Forms.RadioButton()
        Me.rbOption3 = New System.Windows.Forms.RadioButton()
        Me.rbOption2 = New System.Windows.Forms.RadioButton()
        Me.rbOption1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.lblQuizQuestion.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'linked_list_back
        '
        Me.linked_list_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.linked_list_back.ForeColor = System.Drawing.Color.White
        Me.linked_list_back.Location = New System.Drawing.Point(1121, 2042)
        Me.linked_list_back.Margin = New System.Windows.Forms.Padding(4)
        Me.linked_list_back.Name = "linked_list_back"
        Me.linked_list_back.Size = New System.Drawing.Size(150, 40)
        Me.linked_list_back.TabIndex = 5
        Me.linked_list_back.Text = "Back"
        Me.linked_list_back.UseVisualStyleBackColor = False
        '
        'pnlLinkedList
        '
        Me.pnlLinkedList.AutoScroll = True
        Me.pnlLinkedList.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.pnlLinkedList.Location = New System.Drawing.Point(53, 1078)
        Me.pnlLinkedList.Name = "pnlLinkedList"
        Me.pnlLinkedList.Size = New System.Drawing.Size(905, 482)
        Me.pnlLinkedList.TabIndex = 6
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.SteelBlue
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.ForeColor = System.Drawing.Color.White
        Me.txtValue.Location = New System.Drawing.Point(1026, 1125)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(250, 36)
        Me.txtValue.TabIndex = 7
        '
        'txtIndex
        '
        Me.txtIndex.BackColor = System.Drawing.Color.SteelBlue
        Me.txtIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndex.ForeColor = System.Drawing.Color.White
        Me.txtIndex.Location = New System.Drawing.Point(1026, 1209)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Size = New System.Drawing.Size(250, 36)
        Me.txtIndex.TabIndex = 8
        '
        'linked_list_delete
        '
        Me.linked_list_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linked_list_delete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.linked_list_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.linked_list_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.linked_list_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linked_list_delete.ForeColor = System.Drawing.Color.White
        Me.linked_list_delete.Location = New System.Drawing.Point(1023, 1458)
        Me.linked_list_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.linked_list_delete.Name = "linked_list_delete"
        Me.linked_list_delete.Size = New System.Drawing.Size(250, 45)
        Me.linked_list_delete.TabIndex = 16
        Me.linked_list_delete.Text = "Delete"
        Me.linked_list_delete.UseVisualStyleBackColor = False
        '
        'linked_list_insert
        '
        Me.linked_list_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linked_list_insert.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.linked_list_insert.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.linked_list_insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.linked_list_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linked_list_insert.ForeColor = System.Drawing.Color.White
        Me.linked_list_insert.Location = New System.Drawing.Point(1023, 1398)
        Me.linked_list_insert.Margin = New System.Windows.Forms.Padding(4)
        Me.linked_list_insert.Name = "linked_list_insert"
        Me.linked_list_insert.Size = New System.Drawing.Size(250, 45)
        Me.linked_list_insert.TabIndex = 15
        Me.linked_list_insert.Text = "Insert"
        Me.linked_list_insert.UseVisualStyleBackColor = False
        '
        'linked_list_search
        '
        Me.linked_list_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linked_list_search.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.linked_list_search.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.linked_list_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.linked_list_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linked_list_search.ForeColor = System.Drawing.Color.White
        Me.linked_list_search.Location = New System.Drawing.Point(1023, 1338)
        Me.linked_list_search.Margin = New System.Windows.Forms.Padding(4)
        Me.linked_list_search.Name = "linked_list_search"
        Me.linked_list_search.Size = New System.Drawing.Size(250, 45)
        Me.linked_list_search.TabIndex = 14
        Me.linked_list_search.Text = "Searching"
        Me.linked_list_search.UseVisualStyleBackColor = False
        '
        'linked_list_append
        '
        Me.linked_list_append.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_append.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linked_list_append.FlatAppearance.BorderSize = 0
        Me.linked_list_append.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.linked_list_append.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linked_list_append.ForeColor = System.Drawing.Color.White
        Me.linked_list_append.Location = New System.Drawing.Point(1023, 1278)
        Me.linked_list_append.Margin = New System.Windows.Forms.Padding(4)
        Me.linked_list_append.Name = "linked_list_append"
        Me.linked_list_append.Size = New System.Drawing.Size(250, 45)
        Me.linked_list_append.TabIndex = 13
        Me.linked_list_append.Text = "Append"
        Me.linked_list_append.UseVisualStyleBackColor = False
        '
        'main_welcome
        '
        Me.main_welcome.AutoSize = True
        Me.main_welcome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.main_welcome.Font = New System.Drawing.Font("Bell MT", 36.0!, System.Drawing.FontStyle.Bold)
        Me.main_welcome.ForeColor = System.Drawing.Color.Black
        Me.main_welcome.Location = New System.Drawing.Point(483, 26)
        Me.main_welcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.main_welcome.Name = "main_welcome"
        Me.main_welcome.Size = New System.Drawing.Size(333, 69)
        Me.main_welcome.TabIndex = 10
        Me.main_welcome.Text = "Linked List"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.linked_list_reset)
        Me.Panel1.Controls.Add(Me.Reset)
        Me.Panel1.Controls.Add(Me.lblQuizQuestion)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.linked_list_back)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.linked_list_delete)
        Me.Panel1.Controls.Add(Me.linked_list_insert)
        Me.Panel1.Controls.Add(Me.linked_list_search)
        Me.Panel1.Controls.Add(Me.linked_list_append)
        Me.Panel1.Controls.Add(Me.main_welcome)
        Me.Panel1.Controls.Add(Me.txtIndex)
        Me.Panel1.Controls.Add(Me.txtValue)
        Me.Panel1.Controls.Add(Me.pnlLinkedList)
        Me.Panel1.Location = New System.Drawing.Point(2, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1333, 661)
        Me.Panel1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(43, 1605)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(705, 56)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Let's check your understanding!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(43, 979)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(764, 56)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Let's now visualize what we learnt!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1033, 1175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 26)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Enter Index:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1032, 1084)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 26)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Enter Value:"
        '
        'linked_list_reset
        '
        Me.linked_list_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linked_list_reset.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.linked_list_reset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.linked_list_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.linked_list_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linked_list_reset.ForeColor = System.Drawing.Color.White
        Me.linked_list_reset.Location = New System.Drawing.Point(1023, 1516)
        Me.linked_list_reset.Margin = New System.Windows.Forms.Padding(4)
        Me.linked_list_reset.Name = "linked_list_reset"
        Me.linked_list_reset.Size = New System.Drawing.Size(250, 45)
        Me.linked_list_reset.TabIndex = 27
        Me.linked_list_reset.Text = "Reset"
        Me.linked_list_reset.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.ForeColor = System.Drawing.Color.White
        Me.Reset.Location = New System.Drawing.Point(805, 2041)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(150, 40)
        Me.Reset.TabIndex = 26
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'lblQuizQuestion
        '
        Me.lblQuizQuestion.AutoSize = True
        Me.lblQuizQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblQuizQuestion.Controls.Add(Me.btnNext)
        Me.lblQuizQuestion.Controls.Add(Me.btnPrev)
        Me.lblQuizQuestion.Controls.Add(Me.lblQuestionNumber)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption4)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption3)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption2)
        Me.lblQuizQuestion.Controls.Add(Me.rbOption1)
        Me.lblQuizQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuizQuestion.ForeColor = System.Drawing.Color.Black
        Me.lblQuizQuestion.Location = New System.Drawing.Point(38, 1710)
        Me.lblQuizQuestion.Name = "lblQuizQuestion"
        Me.lblQuizQuestion.Size = New System.Drawing.Size(1251, 242)
        Me.lblQuizQuestion.TabIndex = 25
        Me.lblQuizQuestion.TabStop = False
        Me.lblQuizQuestion.Text = "GroupBox1"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(1130, 177)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 30)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Location = New System.Drawing.Point(1031, 177)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(90, 30)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(1186, 0)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(59, 20)
        Me.lblQuestionNumber.TabIndex = 4
        Me.lblQuestionNumber.Text = "Label1"
        '
        'rbOption4
        '
        Me.rbOption4.AutoSize = True
        Me.rbOption4.Location = New System.Drawing.Point(6, 160)
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
        Me.rbOption3.Location = New System.Drawing.Point(6, 120)
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
        Me.rbOption2.Location = New System.Drawing.Point(6, 80)
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
        Me.rbOption1.Location = New System.Drawing.Point(6, 40)
        Me.rbOption1.Name = "rbOption1"
        Me.rbOption1.Size = New System.Drawing.Size(187, 33)
        Me.rbOption1.TabIndex = 0
        Me.rbOption1.TabStop = True
        Me.rbOption1.Text = "RadioButton1"
        Me.rbOption1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Assignment_2_8B.My.Resources.Resources.Linked_List_Data_Structure
        Me.PictureBox3.Location = New System.Drawing.Point(321, 292)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(737, 288)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(47, 117)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(1219, 137)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(53, 635)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1219, 297)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
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
        Me.Label2.Location = New System.Drawing.Point(50, 693)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 19
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(963, 2041)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 40)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1338, 747)
        Me.ShapeContainer1.TabIndex = 36
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1338, 85)
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMenu.Location = New System.Drawing.Point(1004, 15)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(204, 54)
        Me.btnMenu.TabIndex = 59
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox2.Location = New System.Drawing.Point(1243, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox1.Image = Global.Assignment_2_8B.My.Resources.Resources.neural_network__1_
        Me.PictureBox1.Location = New System.Drawing.Point(31, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(134, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 52)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "AlgoWizard"
        '
        'linked_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1338, 747)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "linked_list"
        Me.Text = "linked_list"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.lblQuizQuestion.ResumeLayout(False)
        Me.lblQuizQuestion.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents linked_list_back As System.Windows.Forms.Button
    Friend WithEvents pnlLinkedList As System.Windows.Forms.Panel
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents txtIndex As System.Windows.Forms.TextBox
    Friend WithEvents linked_list_delete As System.Windows.Forms.Button
    Friend WithEvents linked_list_insert As System.Windows.Forms.Button
    Friend WithEvents linked_list_search As System.Windows.Forms.Button
    Friend WithEvents linked_list_append As System.Windows.Forms.Button
    Friend WithEvents main_welcome As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblQuizQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents rbOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents linked_list_reset As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
