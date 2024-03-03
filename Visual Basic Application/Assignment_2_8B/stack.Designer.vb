<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stack))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PeekTextBox = New System.Windows.Forms.TextBox()
        Me.Reset = New System.Windows.Forms.Button()
        Me.lblQuizQuestion = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.rbOption4 = New System.Windows.Forms.RadioButton()
        Me.rbOption3 = New System.Windows.Forms.RadioButton()
        Me.rbOption2 = New System.Windows.Forms.RadioButton()
        Me.rbOption1 = New System.Windows.Forms.RadioButton()
        Me.linked_list_back = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.main_welcome = New System.Windows.Forms.Label()
        Me.popTextBox = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.panelcontainer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.lblQuizQuestion.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.PeekTextBox)
        Me.Panel1.Controls.Add(Me.Reset)
        Me.Panel1.Controls.Add(Me.lblQuizQuestion)
        Me.Panel1.Controls.Add(Me.linked_list_back)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.main_welcome)
        Me.Panel1.Controls.Add(Me.popTextBox)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Controls.Add(Me.panelcontainer)
        Me.Panel1.Location = New System.Drawing.Point(3, 104)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1500, 826)
        Me.Panel1.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(312, 636)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(899, 67)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Let's now visualize what we learnt!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(320, 1316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(830, 67)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Let's check your understanding!"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1151, 1203)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(281, 56)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Clear Stack"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PeekTextBox
        '
        Me.PeekTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.PeekTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeekTextBox.Location = New System.Drawing.Point(1154, 903)
        Me.PeekTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PeekTextBox.Name = "PeekTextBox"
        Me.PeekTextBox.ReadOnly = True
        Me.PeekTextBox.Size = New System.Drawing.Size(281, 41)
        Me.PeekTextBox.TabIndex = 32
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Reset.ForeColor = System.Drawing.Color.White
        Me.Reset.Location = New System.Drawing.Point(903, 1742)
        Me.Reset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(169, 50)
        Me.Reset.TabIndex = 31
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
        Me.lblQuizQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblQuizQuestion.Location = New System.Drawing.Point(37, 1409)
        Me.lblQuizQuestion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblQuizQuestion.Name = "lblQuizQuestion"
        Me.lblQuizQuestion.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblQuizQuestion.Size = New System.Drawing.Size(1416, 300)
        Me.lblQuizQuestion.TabIndex = 30
        Me.lblQuizQuestion.TabStop = False
        Me.lblQuizQuestion.Text = "GroupBox1"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(1271, 212)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 38)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Location = New System.Drawing.Point(1160, 212)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(101, 38)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(1330, 0)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(71, 25)
        Me.lblQuestionNumber.TabIndex = 4
        Me.lblQuestionNumber.Text = "Label1"
        '
        'rbOption4
        '
        Me.rbOption4.AutoSize = True
        Me.rbOption4.Location = New System.Drawing.Point(7, 200)
        Me.rbOption4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbOption4.Name = "rbOption4"
        Me.rbOption4.Size = New System.Drawing.Size(223, 40)
        Me.rbOption4.TabIndex = 3
        Me.rbOption4.TabStop = True
        Me.rbOption4.Text = "RadioButton4"
        Me.rbOption4.UseVisualStyleBackColor = True
        '
        'rbOption3
        '
        Me.rbOption3.AutoSize = True
        Me.rbOption3.Location = New System.Drawing.Point(7, 150)
        Me.rbOption3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbOption3.Name = "rbOption3"
        Me.rbOption3.Size = New System.Drawing.Size(223, 40)
        Me.rbOption3.TabIndex = 2
        Me.rbOption3.TabStop = True
        Me.rbOption3.Text = "RadioButton3"
        Me.rbOption3.UseVisualStyleBackColor = True
        '
        'rbOption2
        '
        Me.rbOption2.AutoSize = True
        Me.rbOption2.Location = New System.Drawing.Point(7, 100)
        Me.rbOption2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbOption2.Name = "rbOption2"
        Me.rbOption2.Size = New System.Drawing.Size(223, 40)
        Me.rbOption2.TabIndex = 1
        Me.rbOption2.TabStop = True
        Me.rbOption2.Text = "RadioButton2"
        Me.rbOption2.UseVisualStyleBackColor = True
        '
        'rbOption1
        '
        Me.rbOption1.AutoSize = True
        Me.rbOption1.Location = New System.Drawing.Point(7, 50)
        Me.rbOption1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbOption1.Name = "rbOption1"
        Me.rbOption1.Size = New System.Drawing.Size(223, 40)
        Me.rbOption1.TabIndex = 0
        Me.rbOption1.TabStop = True
        Me.rbOption1.Text = "RadioButton1"
        Me.rbOption1.UseVisualStyleBackColor = True
        '
        'linked_list_back
        '
        Me.linked_list_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.linked_list_back.ForeColor = System.Drawing.Color.White
        Me.linked_list_back.Location = New System.Drawing.Point(1254, 1741)
        Me.linked_list_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.linked_list_back.Name = "linked_list_back"
        Me.linked_list_back.Size = New System.Drawing.Size(169, 50)
        Me.linked_list_back.TabIndex = 28
        Me.linked_list_back.Text = "Back"
        Me.linked_list_back.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1078, 1742)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(169, 50)
        Me.btnSubmit.TabIndex = 29
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(53, 146)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(1371, 462)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 1246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 943)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1151, 1125)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(281, 56)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Peek"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1151, 1049)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(281, 56)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Pop"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1151, 975)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 56)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Push"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'main_welcome
        '
        Me.main_welcome.AutoSize = True
        Me.main_welcome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.main_welcome.Font = New System.Drawing.Font("Bell MT", 36.0!, System.Drawing.FontStyle.Bold)
        Me.main_welcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.main_welcome.Location = New System.Drawing.Point(637, 32)
        Me.main_welcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.main_welcome.Name = "main_welcome"
        Me.main_welcome.Size = New System.Drawing.Size(210, 82)
        Me.main_welcome.TabIndex = 10
        Me.main_welcome.Text = "Stack"
        '
        'popTextBox
        '
        Me.popTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.popTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.popTextBox.Location = New System.Drawing.Point(1154, 826)
        Me.popTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.popTextBox.Name = "popTextBox"
        Me.popTextBox.ReadOnly = True
        Me.popTextBox.Size = New System.Drawing.Size(281, 41)
        Me.popTextBox.TabIndex = 8
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(1154, 749)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(281, 41)
        Me.txtInput.TabIndex = 7
        '
        'panelcontainer
        '
        Me.panelcontainer.AutoScroll = True
        Me.panelcontainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panelcontainer.Location = New System.Drawing.Point(60, 747)
        Me.panelcontainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelcontainer.Name = "panelcontainer"
        Me.panelcontainer.Size = New System.Drawing.Size(1018, 518)
        Me.panelcontainer.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(122, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 63)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "AlgoWizard"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1501, 105)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1505, 934)
        Me.ShapeContainer1.TabIndex = 40
        Me.ShapeContainer1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Assignment_2_8B.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(1393, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox2.Image = Global.Assignment_2_8B.My.Resources.Resources.neural_network__1_
        Me.PictureBox2.Location = New System.Drawing.Point(25, 8)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
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
        Me.Button1.Location = New System.Drawing.Point(1154, 20)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 60)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Main Menu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'stack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1505, 934)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "stack"
        Me.Text = "stack"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.lblQuizQuestion.ResumeLayout(False)
        Me.lblQuizQuestion.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents main_welcome As System.Windows.Forms.Label
    Friend WithEvents popTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents panelcontainer As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents lblQuizQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents rbOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents linked_list_back As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents PeekTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
