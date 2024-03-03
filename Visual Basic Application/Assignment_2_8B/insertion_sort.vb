Imports MySql.Data.MySqlClient
Public Class insertion_sort

    Private Sub insertion_sort_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        sorting.StartPosition = FormStartPosition.Manual
        sorting.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        sorting.Show()
    End Sub

    Dim init_flag As Integer = 1

    Dim array_size As Integer = 5
    Dim text_boxes As New List(Of TextBox)()
    Dim input_array As New List(Of Integer)()
    Dim value As Integer
    Dim temp As Integer
    Dim temp2 As String
    Dim step_index As Integer = 0
    Dim step_i As Integer = 0
    Dim step_j As Integer = 1
    Dim wait_flag As Integer = 0

    'Dim key As String = "A"
    Dim start As Integer = 1
    Dim temp4 As Integer
    Dim key_int As Integer = -100001
    Dim key_placed As Boolean = False
    Dim all_textbox_filled As Boolean = True
    Dim all_textbox_values_valid As Boolean = True
    Dim wait_flag_2 As Boolean = True

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

    Private Sub textboxParse()
        ' Initialize the integer list with values from TextBox controls
        For Each tb As TextBox In text_boxes
            If Integer.TryParse(tb.Text, value) Then
                input_array.Add(value)
            End If
        Next
        'For Each Val As Integer In input_array
        ' bubble_sort_size_label.Text = bubble_sort_size_label.Text & Val.ToString & " "
        ' Next
    End Sub
    Private Sub UpdateTextBoxValues(ByVal values As List(Of Integer))
        For i As Integer = 0 To values.Count - 1
            Dim value As Integer = values(i)
            Dim textBox As TextBox = text_boxes(i)

            ' Update TextBox value
            If textBox.InvokeRequired Then
                textBox.Invoke(Sub() textBox.Text = value.ToString())
            Else
                textBox.Text = value.ToString()
            End If
        Next
    End Sub
    Private Sub HighlightTextBox(ByVal index As Integer, ByVal color As Color)
        If index >= 0 AndAlso index < text_boxes.Count Then
            text_boxes(index).BackColor = color
        End If
    End Sub
    Public Sub CreateDynamicTextBoxArray(ByVal size As Integer, ByVal container As Control)
        ' Clear existing TextBox controls if any
        ' container.Controls.Clear()





        ' Create TextBox controls dynamically
        If init_flag = 1 Then
            For i As Integer = 0 To size - 1
                Dim textBox As New TextBox()
                textBox.Name = "txtBox" & i.ToString()
                textBox.Location = New Point(120 + (i * 60), 130) ' Adjust the location as needed
                textBox.Size = New Size(50, 30) ' Adjust the size as needed
                textBox.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
                textBox.TextAlign = HorizontalAlignment.Center
                textBox.BorderStyle = BorderStyle.FixedSingle
                container.Controls.Add(textBox)
                text_boxes.Add(textBox)
            Next
            init_flag = 0
        Else
            MessageBox.Show("Reset first before creating new array", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub insertion_step()

        Dim x_temp As Integer
        If init_flag = 0 Then
            For Each t As TextBox In text_boxes
                If String.IsNullOrWhiteSpace(t.Text) Then
                    all_textbox_filled = False
                    Exit For
                End If
                If Integer.TryParse(t.Text, x_temp) = False Then
                    all_textbox_values_valid = False
                    Exit For
                End If
                all_textbox_filled = True
                all_textbox_values_valid = True
            Next
        End If
        If init_flag = 0 And all_textbox_filled And all_textbox_values_valid Then
            textboxParse()
            'Size = input_array.Count
            init_flag = -1
        End If
        If all_textbox_filled = False And init_flag = 0 Then
            MessageBox.Show("Fill all text boxes first")
            'init_flag = 0
        End If
        If all_textbox_values_valid = False And init_flag = 0 Then
            MessageBox.Show("Fill all text boxes first with valid numeric positive integer values only.")
            'init_flag = 0
        End If

        If init_flag = -1 Then
            For i As Integer = 0 To text_boxes.Count - 1
                text_boxes(i).ReadOnly = True
            Next
        End If
        '(((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((

        Dim x As Integer = 0
        If init_flag = -1 Then
            For i As Integer = 0 To input_array.Count - 2
                If input_array(i) > input_array(i + 1) Then
                    x = 1
                    Exit For
                End If
            Next
        End If
        If x = 0 And key_int = -100001 And init_flag = -1 Then
            MessageBox.Show("Sorted")
        End If
        If step_j < input_array.Count And init_flag = -1 Then
            If start = 1 Then
                key_int = input_array(step_j)
                'HighlightTextBox(step_i, Color.White)
                step_i = step_j - 1
                'HighlightTextBox(step_i, Color.Yellow)
                start = 0
            End If
            'Integer.TryParse(key, key_int)
            If (step_i >= 0) And (input_array(If(step_i = -1, 0, step_i)) > key_int) Then
                If wait_flag_2 = True Then
                    HighlightTextBox(step_i + 1, Color.LightBlue)
                    wait_flag_2 = False
                Else
                    input_array(step_i + 1) = input_array(step_i)
                    HighlightTextBox(step_i, Color.Cyan)
                    HighlightTextBox(step_i + 1, Color.White)
                    step_i = step_i - 1
                End If

            Else
                input_array(step_i + 1) = key_int
                'HighlightTextBox(step_i - 1, Color.White)
                'HighlightTextBox(step_i, Color.DarkCyan)
                HighlightTextBox(step_i + 1, Color.White)
                step_j = step_j + 1
                start = 1
                key_int = -100001
                wait_flag_2 = True
            End If
        End If
        'HighlightTextBox(step_i + 2, Color.White)
        'insertion_sort_size_label.Text = key_int.ToString & " i= " & step_i.ToString & " j= " & step_j.ToString & " St= " & start.ToString & " x= " & x.ToString
        insertion_sort_key_label.Text = "KEY = " + If(key_int = -100001, "EMPTY", key_int.ToString)
        UpdateTextBoxValues(input_array)
    End Sub
    Private Sub insertion_sort_fill_random_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertion_sort_fill_random.Click
        Dim rand As New Random()
        If init_flag = 0 Then
            For Each t As TextBox In text_boxes
                t.Text = rand.Next(100)
            Next
            all_textbox_filled = True
            'init_flag = -1
        End If

    End Sub

    Private Sub insertion_sort_step_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertion_sort_step.Click
        insertion_step()
    End Sub

    Private Sub insertion_sort_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertion_sort_create.Click

        If init_flag = 1 Then
            If String.IsNullOrEmpty(insertion_sort_size.Text) = False Then
                If Integer.TryParse(insertion_sort_size.Text, array_size) = False Then
                    MessageBox.Show("Enter a positive numeric value for size")
                Else
                    If array_size <= 0 Then
                        MessageBox.Show("Enter a positive value for size")

                    ElseIf array_size = 1 Then
                        MessageBox.Show("Any array of size 1 is always sorted")
                    Else
                        CreateDynamicTextBoxArray(array_size, Panel1)
                        init_flag = 0
                    End If
                    ' array_size = Integer.Parse(bubble_sort_size.Text)
                End If

            Else
                MessageBox.Show("Size given is empty")
            End If
        Else
            MessageBox.Show("Already created, reset first")
        End If
    End Sub

    Private Sub insertion_sort_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertion_sort_reset.Click
        For i As Integer = Panel1.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = Panel1.Controls(i)
            ' If TypeOf ctrl Is TextBox AndAlso ctrl.Name.StartsWith("txtBox") Then
            If ctrl.Name.StartsWith("txtBox") Then
                Panel1.Controls.Remove(ctrl)
                ctrl.Dispose() ' Dispose the control to release its resources
            End If
        Next
        input_array = New List(Of Integer)
        text_boxes = New List(Of TextBox)
        init_flag = 1

        step_index = 0
        step_i = 0
        step_j = 1
        wait_flag = 0

        'Dim key As String = "A"
        start = 1
        key_int = -100001
        key_placed = False
    End Sub



    Private Sub LoadQuizQuestions()
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "SELECT serial_no, question, optionA, optionB, optionC, optionD, Correct_Option FROM insertion_sort"
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
        Dim query As String = "UPDATE users SET insertionsort_progress = GREATEST(IFNULL(array_progress, 0), @correctAnswers) WHERE username = @user"
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

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        ShowQuizSection()
        btnNext.Visible = True
    End Sub

    Private Sub insertion_sort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowQuizSection()
        UpdateQuestionNumberDisplay()
    End Sub


    Private Sub insertion_sort_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertion_sort_back.Click
        sorting.StartPosition = FormStartPosition.Manual
        sorting.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        sorting.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        main_menu.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ' pnlArray.Controls.Clear()
        Dim Profile As New profile()
        Profile.StartPosition = FormStartPosition.Manual
        Profile.Location = Me.Location ' Set the location of the new form to the current form's location
        Profile.Show()
        Profile.PreviousForm = Me
        Hide()
    End Sub

    
End Class