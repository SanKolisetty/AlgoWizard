Imports MySql.Data.MySqlClient



Public Class array

    Private Class Question
        Public Property Text As String
        Public Property Options As List(Of String)
        Public Property CorrectAnswer As String
    End Class

    ' List to hold the quiz questions
    Private questions As New List(Of Question)()
    ' Dictionary to store user's answers
    Private userAnswers As New Dictionary(Of Integer, String)()
    ' Current question index
    Private currentQuestionIndex As Integer = 0

    Dim array(0) As Integer
    Dim label(0) As Label
    Dim indexLabel(0) As Label
    Dim size_of_array As Integer

    'Display Substring in different Font
    Private Sub DisplaySubstringInDifferentFont(ByVal richTextBox As RichTextBox, ByVal substring As String, ByVal font As Font)
        ' Find the index of the substring within the text
        Dim index As Integer = richTextBox.Find(substring)

        ' If the substring is found
        If index >= 0 Then
            ' Set the selection start and length
            richTextBox.SelectionStart = index
            richTextBox.SelectionLength = substring.Length

            ' Set the font for the selected substring
            richTextBox.SelectionFont = font

            ' Deselect the text
            richTextBox.DeselectAll()
        End If
    End Sub

    'Highlighting Text
    Private Sub HighlightText(ByVal richTextBox As RichTextBox, ByVal text As String)
        ' Find the index of the text within the RichTextBox
        Dim index As Integer = richTextBox.Find(text)

        ' If the text is found
        If index >= 0 Then
            ' Set the selection start and length
            richTextBox.SelectionStart = index
            richTextBox.SelectionLength = text.Length

            ' Set the background color for the selected text
            richTextBox.SelectionBackColor = Color.Black
            richTextBox.SelectionColor = Color.White

            ' Deselect the text
            richTextBox.DeselectAll()
        End If
    End Sub

    'Text bold
    Private Sub BoldText(ByVal richTextBox As RichTextBox, ByVal text As String)
        ' Find the index of the text within the RichTextBox
        Dim index As Integer = richTextBox.Find(text)

        ' If the text is found
        If index >= 0 Then
            ' Set the selection start and length
            richTextBox.SelectionStart = index
            richTextBox.SelectionLength = text.Length

            ' Set the font style to bold for the selected text
            richTextBox.SelectionFont = New Font(richTextBox.Font, FontStyle.Bold)

            ' Deselect the text
            richTextBox.DeselectAll()
        End If
    End Sub

    'Handling Focus of Textboxes

    Private Sub Size_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Size.GotFocus
        If Size.Text = "Enter Size..." Then
            Size.Text = ""
            'TextBox1.ForeColor = Color.Black ' Set the text color back to black
        End If
    End Sub

    Private Sub Size_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Size.LostFocus
        If String.IsNullOrWhiteSpace(Size.Text) Then
            Size.Text = "Enter Size..."
            Size.ForeColor = Color.White ' Set the text color to a lighter shade
        End If
    End Sub

    Private Sub Value_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Value.LostFocus
        If String.IsNullOrWhiteSpace(Value.Text) Then
            Value.Text = "Enter Value..."
            Value.ForeColor = Color.White ' Set the text color to a lighter shade
        End If
    End Sub

    Private Sub Value_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Value.GotFocus
        If Value.Text = "Enter Value..." Then
            Value.Text = ""
            Value.ForeColor = Color.White ' Set the text color to a lighter shade
        End If
    End Sub

    Private Sub Index_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Index.LostFocus
        If String.IsNullOrWhiteSpace(Index.Text) Then
            Index.Text = "Enter Index..."
            Index.ForeColor = Color.White ' Set the text color to a lighter shade
        End If
    End Sub

    Private Sub Index_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Index.GotFocus
        If Index.Text = "Enter Index..." Then
            Index.Text = ""
            Index.ForeColor = Color.White ' Set the text color to a lighter shade
        End If
    End Sub

    'Load 
    Private Sub array_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fontForSubstring As New Font("Courier New", 12, FontStyle.Bold) ' Define the font for the substring
        DisplaySubstringInDifferentFont(RichTextBox1, "int myArray[10];", fontForSubstring) ' Display the word "highlighted" in the RichTextBox with the specified font
        HighlightText(RichTextBox1, "int myArray[10];") ' Highlight the word "highlighted" in the RichTextBox

        DisplaySubstringInDifferentFont(RichTextBox1, "myArray[0] = 0;", fontForSubstring) ' Display the word "highlighted" in the RichTextBox with the specified font
        HighlightText(RichTextBox1, "myArray[0] = 0;") ' Highlight the word "highlighted" in the RichTextBox

        DisplaySubstringInDifferentFont(RichTextBox1, "myArray[1] = 1;", fontForSubstring) ' Display the word "highlighted" in the RichTextBox with the specified font
        HighlightText(RichTextBox1, "myArray[1] = 1;") ' Highlight the word "highlighted" in the RichTextBox

        DisplaySubstringInDifferentFont(RichTextBox1, "int firstElement = myArray[0];", fontForSubstring) ' Display the word "highlighted" in the RichTextBox with the specified font
        HighlightText(RichTextBox1, "int firstElement = myArray[0];") ' Highlight the word "highlighted" in the RichTextBox

        BoldText(RichTextBox1, "1. What is an Array?") ' Bold the word "bold" in the RichTextBox
        BoldText(RichTextBox1, "2. Declaring Arrays:") ' Bold the word "bold" in the RichTextBox
        BoldText(RichTextBox1, "4. Accessing Elements:") ' Bold the word "bold" in the RichTextBox
        BoldText(RichTextBox1, "3. Initializing Arrays:") ' Bold the word "bold" in the RichTextBox

        Size.Text = "Enter Size..."
        Size.ForeColor = Color.White

        Value.Text = "Enter Value..."
        Value.ForeColor = Color.White

        Index.Text = "Enter Index..."
        Index.ForeColor = Color.White


        ShowQuizSection()
        UpdateQuestionNumberDisplay()

    End Sub


    Private Sub declare_array_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles declare_array.Click
        If Size.Text = "Enter Size..." Then
            ' TextBox is empty
            MessageBox.Show("Please enter the size of the array to declare it.")
        Else
            Dim userInput As String = Size.Text
            Dim number As Integer

            If Integer.TryParse(userInput, number) Then
                ' The text is a valid integer
                If Int(Size.Text) > 218 Then
                    MessageBox.Show("Please enter a number less than 218.")

                Else
                    pnlArray.Controls.Clear()

                    ReDim array(Int(Size.Text) - 1)
                    ReDim label(Int(Size.Text) - 1)
                    ReDim indexLabel(Int(Size.Text) - 1)
                    size_of_array = Int(Size.Text)

                    For i As Integer = 0 To Int(Size.Text) - 1
                        label(i) = New Label()
                        indexLabel(i) = New Label()

                        ' Set properties for each Label control
                        label(i).Text = "" ' Concatenate index value with label text
                        label(i).Location = New Point(45 + i * 150, 45) ' Adjust Y position for each label
                        label(i).AutoSize = False

                        label(i).Size = New Size(75, 60)
                        label(i).BorderStyle = BorderStyle.FixedSingle
                        label(i).BackColor = Color.White
                        label(i).ForeColor = Color.Black
                        label(i).TextAlign = ContentAlignment.MiddleCenter ' Center the text
                        label(i).Font = New Font(label(i).Font.FontFamily, 14) ' Increase font size to 14

                        indexLabel(i).Text = "Index " & i ' Set the text for each index label
                        indexLabel(i).Location = New Point(55 + i * 150, 110) ' Adjust Y position for each index label
                        indexLabel(i).AutoSize = True
                        indexLabel(i).Font = New Font(indexLabel(i).Font.FontFamily, 10) ' Set font size for index label

                        pnlArray.Controls.Add(label(i))
                        pnlArray.Controls.Add(indexLabel(i))

                        label(i).BringToFront()
                        indexLabel(i).BringToFront()
                    Next i
                End If
            Else
                ' The text is not a valid integer
                MessageBox.Show("The input is not an integer.")
            End If
            
        End If
    End Sub

    Private Sub initialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles initialize.Click
        If Value.Text = "Enter Value..." Or Index.Text = "Enter Index..." Then
            ' TextBox is empty
            MessageBox.Show("Please ensure that both Index and Value are not empty.")
        Else
            Dim userInput1 As String = Value.Text
            Dim userInput2 As String = Index.Text
            Dim number1 As Integer
            Dim number2 As Integer

            If Integer.TryParse(userInput1, number1) And Integer.TryParse(userInput2, number2) Then
                ' The text is a valid integer
                If Int(Index.Text) >= size_of_array Or Int(Index.Text) < 0 Then
                    MessageBox.Show("Index is out of bounds.")
                Else
                    If label(Int(Index.Text)).Text = "" Then
                        label(Int(Index.Text)).Text = Value.Text
                        array(Int(Index.Text)) = Int(Value.Text)
                        MessageBox.Show("Index " + Index.Text + " is initialized with " + Value.Text + ".")
                    Else
                        label(Int(Index.Text)).Text = Value.Text
                        array(Int(Index.Text)) = Int(Value.Text)

                        MessageBox.Show("Index " + Index.Text + " is modified with " + Value.Text + ".")
                    End If

                End If
            Else
                ' The text is not a valid integer
                MessageBox.Show("The input is not an integer.")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainMenuForm As New main_menu()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If Value.Text = "Enter Value..." Or Index.Text = "Enter Index..." Then
            ' TextBox is empty
            MessageBox.Show("Please ensure that both Index and Value are not empty.")
        Else
            Dim userInput1 As String = Value.Text
            Dim userInput2 As String = Index.Text
            Dim number1 As Integer
            Dim number2 As Integer

            If Integer.TryParse(userInput1, number1) And Integer.TryParse(userInput2, number2) Then
                ' The text is a valid integer
                If Int(Index.Text) >= size_of_array Or Int(Index.Text) < 0 Then
                    MessageBox.Show("Index is out of bounds.")
                Else

                    size_of_array = size_of_array + 1
                    ReDim Preserve array(size_of_array)
                    ReDim Preserve label(size_of_array)
                    ReDim Preserve indexLabel(size_of_array)

                    label(size_of_array - 1) = New Label()
                    indexLabel(size_of_array - 1) = New Label()

                    label(size_of_array - 1).Location = New Point((size_of_array - 1) * 150, 45) ' Adjust Y position for each label
                    label(size_of_array - 1).AutoSize = False

                    label(size_of_array - 1).Size = New Size(75, 60)
                    label(size_of_array - 1).BorderStyle = BorderStyle.FixedSingle
                    label(size_of_array - 1I).BackColor = Color.White
                    label(size_of_array - 1I).ForeColor = Color.Black
                    label(size_of_array - 1).TextAlign = ContentAlignment.MiddleCenter ' Center the text
                    label(size_of_array - 1).Font = New Font(label(size_of_array - 1).Font.FontFamily, 14) ' Increase font size to 14

                    indexLabel(size_of_array - 1).Text = "Index " & size_of_array - 1 ' Set the text for each index label
                    indexLabel(size_of_array - 1).Location = New Point((size_of_array - 1) * 150, 110) ' Adjust Y position for each index label
                    indexLabel(size_of_array - 1).AutoSize = True
                    indexLabel(size_of_array - 1).Font = New Font(indexLabel(size_of_array - 1).Font.FontFamily, 10) ' Set font size for index label

                    pnlArray.Controls.Add(label(size_of_array - 1))
                    pnlArray.Controls.Add(indexLabel(size_of_array - 1))

                    label(size_of_array - 1).BringToFront()
                    indexLabel(size_of_array - 1).BringToFront()

                    For i As Integer = size_of_array - 1 To Int(Index.Text) + 1 Step -1
                        label(i).Text = label(i - 1).Text
                    Next

                    array(Int(Index.Text)) = Int(Value.Text)
                    label(Int(Index.Text)).Text = Value.Text

                End If
            Else
                ' The text is not a valid integer
                MessageBox.Show("The input is not an integer.")
            End If
            
        End If
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        pnlArray.Controls.Clear()
        ReDim array(0)
        ReDim label(0)
        ReDim indexLabel(0)
        size_of_array = 0
    End Sub


    ' Function to load quiz questions
    Private Sub LoadQuizQuestions()
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "SELECT serial_no, question, optionA, optionB, optionC, optionD, Correct_Option FROM array"
        Dim allQuestions As New List(Of Question)()

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim questionText As String = reader.GetString("question")
                            Dim options As New List(Of String) From {
                                reader.GetString("optionA"),
                                reader.GetString("optionB"),
                                reader.GetString("optionC"),
                                reader.GetString("optionD")
                            }
                            Dim correctAnswer As String = reader.GetString("Correct_Option")
                            allQuestions.Add(New Question With {
                                .Text = questionText,
                                .Options = options,
                                .CorrectAnswer = correctAnswer
                            })
                        End While
                    End Using
                End Using
            End Using

            ' Select 10 random questions from the retrieved questions
            questions = GetRandomQuestions(allQuestions, 10)
        Catch ex As Exception
            MessageBox.Show("Error loading quiz questions: " & ex.Message)
        End Try
    End Sub

    ' Function to select a random subset of questions
    Private Function GetRandomQuestions(ByVal allQuestions As List(Of Question), ByVal count As Integer) As List(Of Question)
        Dim random As New Random()
        Return allQuestions.OrderBy(Function(x) random.Next()).Take(count).ToList()
    End Function

    ' Function to display quiz question
    Private Sub DisplayQuestion()
        Dim currentQuestion As Question = questions(currentQuestionIndex)
        lblQuizQuestion.Text = currentQuestion.Text

        Dim questionLabelHeight As Integer = TextRenderer.MeasureText(lblQuizQuestion.Text, lblQuizQuestion.Font, New Size(lblQuizQuestion.Width, Integer.MaxValue), TextFormatFlags.WordBreak).Height

        ' Adjust the position of the options based on the height of the question label
        Dim optionTopMargin As Integer = 8 ' Adjust this value based on your layout
        rbOption1.Top = questionLabelHeight + optionTopMargin
        rbOption2.Top = rbOption1.Bottom + optionTopMargin
        rbOption3.Top = rbOption2.Bottom + optionTopMargin
        rbOption4.Top = rbOption3.Bottom + optionTopMargin
        btnPrev.Top = rbOption3.Bottom + optionTopMargin + 10
        btnNext.Top = rbOption3.Bottom + optionTopMargin + 10

        rbOption1.Text = currentQuestion.Options(0)
        rbOption2.Text = currentQuestion.Options(1)
        rbOption3.Text = currentQuestion.Options(2)
        rbOption4.Text = currentQuestion.Options(3)

        Debug.WriteLine("User Answers:")
        For Each kvp As KeyValuePair(Of Integer, String) In userAnswers
            Debug.WriteLine("Question " & kvp.Key & ": " & kvp.Value)
        Next

        ' Check if the user has previously answered this question
        If userAnswers.ContainsKey(currentQuestionIndex) Then
            Dim selectedOption As String = userAnswers(currentQuestionIndex)
            ' Select the corresponding RadioButton
            If selectedOption = "A" Then
                rbOption1.Checked = True
            ElseIf selectedOption = "B" Then
                rbOption2.Checked = True
            ElseIf selectedOption = "C" Then
                rbOption3.Checked = True
            ElseIf selectedOption = "D" Then
                rbOption4.Checked = True
            End If
        Else
            ' Clear the selection of all RadioButtons if the question is being loaded for the first time
            rbOption1.Checked = False
            rbOption2.Checked = False
            rbOption3.Checked = False
            rbOption4.Checked = False
        End If
    End Sub

    Private Sub UpdateQuestionNumberDisplay()
        lblQuestionNumber.Text = (currentQuestionIndex + 1) & "/" & questions.Count

        ' Enable the Submit button if all questions have been answered, otherwise disable it
        'btnSubmit.Enabled = (userAnswers.Count = questions.Count)
    End Sub

    ' Event handler for radio button selection (answer selection)
    Private Sub rbOption_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbOption1.CheckedChanged, rbOption2.CheckedChanged, rbOption3.CheckedChanged, rbOption4.CheckedChanged
        ' Update user's answer
        Dim selectedRadioButton As RadioButton = DirectCast(sender, RadioButton)
        If selectedRadioButton.Checked Then
            ' Extract the option code from the radio button's name
            Dim optionCode As Integer = Convert.ToInt32(selectedRadioButton.Name.Substring(selectedRadioButton.Name.Length - 1))
            ' Map the option code to a letter using a case statement
            Dim selectedOption As String = ""
            Select Case optionCode
                Case 1
                    selectedOption = "A"
                Case 2
                    selectedOption = "B"
                Case 3
                    selectedOption = "C"
                Case 4
                    selectedOption = "D"
            End Select
            ' Store the selected option in userAnswers
            userAnswers(currentQuestionIndex) = selectedOption
        End If

        UpdateQuestionNumberDisplay()
    End Sub

    ' Event handler for the Previous button click
    Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrev.Click
        If currentQuestionIndex > 0 Then
            currentQuestionIndex -= 1
            DisplayQuestion()
            UpdateQuestionNumberDisplay()
        End If

        ' Hide the "Previous" button if it's the first question
        btnPrev.Visible = (currentQuestionIndex > 0)

        ' Show the "Next" button
        btnNext.Visible = True

    End Sub

    ' Event handler for the Next button click
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        If currentQuestionIndex < questions.Count - 1 Then
            currentQuestionIndex += 1
            DisplayQuestion()
            UpdateQuestionNumberDisplay()
        End If

        ' Hide the "Next" button if it's the last question
        btnNext.Visible = (currentQuestionIndex < questions.Count - 1)

        ' Show the "Previous" button
        btnPrev.Visible = True
    End Sub

    ' Event handler for Submit button click
    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        If userAnswers.Count = questions.Count Then
            ShowQuizResults()
        Else
            MessageBox.Show("Please answer all questions before submitting. Currently " & userAnswers.Count & " answered out of " & questions.Count)
        End If
    End Sub

    ' Function to show quiz results
    Private Sub ShowQuizResults()
        Dim correctAnswers As Integer = 0
        Dim totalQuestions As Integer = questions.Count

        ' Calculate the number of correct answers
        For Each kvp As KeyValuePair(Of Integer, String) In userAnswers
            Dim questionIndex As Integer = kvp.Key
            Dim userAnswer As String = kvp.Value
            Dim correctAnswer As String = questions(questionIndex).CorrectAnswer

            If userAnswer = correctAnswer Then
                correctAnswers += 1
            End If
        Next

        ' Update the users table with the new linkedlist_progress value
        Dim user As String = GlobalVariables.global_user
        'Debug.WriteLine(user)
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "UPDATE users SET array_progress = GREATEST(IFNULL(array_progress, 0), @correctAnswers) WHERE username = @user"
        'Dim query As String = "UPDATE users SET searching_progress = GREATEST(IFNULL(searching_progress, 0), @correctAnswers) WHERE username = @user"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@correctAnswers", correctAnswers)
                    command.Parameters.AddWithValue("@user", user)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        'MessageBox.Show("Quiz results updated successfully.")
                    Else
                        MessageBox.Show("Failed to update quiz results.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating quiz results: " & ex.Message)
        End Try

        'Debug.WriteLine("User Answers:")
        'For Each kvp As KeyValuePair(Of Integer, String) In userAnswers
        'Debug.WriteLine("Question " & kvp.Key & ": " & kvp.Value)
        'Next

        'Debug.WriteLine("Questions:")
        'For Each question As Question In questions
        'Debug.WriteLine("Question: " & Question.Text)
        'Debug.WriteLine("Options: " & String.Join(", ", Question.Options))
        'Debug.WriteLine("Correct Answer: " & Question.CorrectAnswer)
        'Next

        ' Display the results
        MessageBox.Show("You answered " & correctAnswers & " out of " & totalQuestions & " questions correctly.")
    End Sub

    ' Function to show quiz section
    Private Sub ShowQuizSection()
        'Reset all variables
        questions = New List(Of Question)()
        userAnswers = New Dictionary(Of Integer, String)()
        currentQuestionIndex = 0
        btnPrev.Visible = False
        btnNext.Visible = True

        ' Load quiz questions
        LoadQuizQuestions()
        DisplayQuestion()
        UpdateQuestionNumberDisplay()

        ' Show quiz controls
        lblQuizQuestion.Visible = True
        rbOption1.Visible = True
        rbOption2.Visible = True
        rbOption3.Visible = True
        rbOption4.Visible = True
        btnSubmit.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowQuizSection()
    End Sub

    Private Sub linked_list_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linked_list_back.Click
        pnlArray.Controls.Clear()
        Dim mainMenuForm As New main_menu()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Hide()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        pnlArray.Controls.Clear()
        Dim mainMenuForm As New profile()
        mainMenuForm.PreviousForm = Me
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class