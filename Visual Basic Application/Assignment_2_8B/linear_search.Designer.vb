<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class linear_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(linear_search))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnResetQues = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblQuizQuestion = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.rbOption4 = New System.Windows.Forms.RadioButton()
        Me.rbOption3 = New System.Windows.Forms.RadioButton()
        Me.rbOption2 = New System.Windows.Forms.RadioButton()
        Me.rbOption1 = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnInitialize = New System.Windows.Forms.Button()
        Me.main_welcome = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.pnlLinearSearch = New System.Windows.Forms.Panel()
        Me.lblSearchResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.lblQuizQuestion.SuspendLayout()
        Me.pnlLinearSearch.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1338, 747)
        Me.ShapeContainer1.TabIndex = 39
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(967, 1290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(297, 26)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Enter element to be searched"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(967, 1127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(314, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Enter list of elements (max. 40)"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(47, 349)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1219, 636)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnResetQues)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.lblQuizQuestion)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnInitialize)
        Me.Panel1.Controls.Add(Me.main_welcome)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Controls.Add(Me.txtList)
        Me.Panel1.Controls.Add(Me.pnlLinearSearch)
        Me.Panel1.Location = New System.Drawing.Point(0, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 661)
        Me.Panel1.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(261, 1030)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(764, 56)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Let's now visualize what we learnt!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(261, 1652)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(705, 56)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Let's check your understanding!"
        '
        'btnResetQues
        '
        Me.btnResetQues.AutoSize = True
        Me.btnResetQues.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnResetQues.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetQues.ForeColor = System.Drawing.Color.White
        Me.btnResetQues.Location = New System.Drawing.Point(798, 2057)
        Me.btnResetQues.Name = "btnResetQues"
        Me.btnResetQues.Size = New System.Drawing.Size(150, 40)
        Me.btnResetQues.TabIndex = 26
        Me.btnResetQues.Text = "Reset"
        Me.btnResetQues.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(47, 106)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(1219, 213)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
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
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1121, 2057)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 40)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(963, 2057)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 40)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
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
        Me.lblQuizQuestion.Location = New System.Drawing.Point(37, 1753)
        Me.lblQuizQuestion.Name = "lblQuizQuestion"
        Me.lblQuizQuestion.Size = New System.Drawing.Size(1236, 235)
        Me.lblQuizQuestion.TabIndex = 17
        Me.lblQuizQuestion.TabStop = False
        Me.lblQuizQuestion.Text = "GroupBox1"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(1112, 165)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 30)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Location = New System.Drawing.Point(1013, 165)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(90, 30)
        Me.btnPrev.TabIndex = 8
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(1170, 0)
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
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(1014, 1506)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(250, 45)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(1014, 1446)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(250, 45)
        Me.btnStop.TabIndex = 15
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1014, 1386)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(250, 45)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnInitialize
        '
        Me.btnInitialize.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnInitialize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInitialize.FlatAppearance.BorderSize = 0
        Me.btnInitialize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnInitialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInitialize.ForeColor = System.Drawing.Color.White
        Me.btnInitialize.Location = New System.Drawing.Point(1014, 1221)
        Me.btnInitialize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInitialize.Name = "btnInitialize"
        Me.btnInitialize.Size = New System.Drawing.Size(250, 45)
        Me.btnInitialize.TabIndex = 13
        Me.btnInitialize.Text = "Initialize Array"
        Me.btnInitialize.UseVisualStyleBackColor = False
        '
        'main_welcome
        '
        Me.main_welcome.AutoSize = True
        Me.main_welcome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.main_welcome.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold)
        Me.main_welcome.ForeColor = System.Drawing.Color.Black
        Me.main_welcome.Location = New System.Drawing.Point(566, 26)
        Me.main_welcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.main_welcome.Name = "main_welcome"
        Me.main_welcome.Size = New System.Drawing.Size(316, 56)
        Me.main_welcome.TabIndex = 10
        Me.main_welcome.Text = "Linear Search"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.SteelBlue
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.Color.White
        Me.txtInput.Location = New System.Drawing.Point(1014, 1330)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(250, 36)
        Me.txtInput.TabIndex = 8
        '
        'txtList
        '
        Me.txtList.BackColor = System.Drawing.Color.SteelBlue
        Me.txtList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtList.ForeColor = System.Drawing.Color.White
        Me.txtList.Location = New System.Drawing.Point(1014, 1167)
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(250, 36)
        Me.txtList.TabIndex = 7
        '
        'pnlLinearSearch
        '
        Me.pnlLinearSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.pnlLinearSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLinearSearch.Controls.Add(Me.lblSearchResult)
        Me.pnlLinearSearch.Location = New System.Drawing.Point(44, 1127)
        Me.pnlLinearSearch.Name = "pnlLinearSearch"
        Me.pnlLinearSearch.Size = New System.Drawing.Size(905, 482)
        Me.pnlLinearSearch.TabIndex = 6
        '
        'lblSearchResult
        '
        Me.lblSearchResult.AutoSize = True
        Me.lblSearchResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSearchResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSearchResult.Location = New System.Drawing.Point(35, 426)
        Me.lblSearchResult.Name = "lblSearchResult"
        Me.lblSearchResult.Size = New System.Drawing.Size(85, 29)
        Me.lblSearchResult.TabIndex = 25
        Me.lblSearchResult.Text = "Result"
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
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "AlgoWizard"
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
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
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
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMenu.Location = New System.Drawing.Point(1004, 15)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(204, 54)
        Me.btnMenu.TabIndex = 55
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'linear_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1338, 747)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "linear_search"
        Me.Text = "linear_search"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.lblQuizQuestion.ResumeLayout(False)
        Me.lblQuizQuestion.PerformLayout()
        Me.pnlLinearSearch.ResumeLayout(False)
        Me.pnlLinearSearch.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblQuizQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents rbOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnInitialize As System.Windows.Forms.Button
    Friend WithEvents main_welcome As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtList As System.Windows.Forms.TextBox
    Friend WithEvents pnlLinearSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearchResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnResetQues As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
