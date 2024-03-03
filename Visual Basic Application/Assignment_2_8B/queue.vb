Imports System.Collections.Generic
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class queue
    ' Define a queue to store integer values
    Private queue As New Queue(Of Integer)()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainMenuForm As New main_menu()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the size and position of the panelContainer
        '  panelContainer.Size = New Size(400, 400)
        '  panelContainer.Location = New Point(10, 10)
        'Me.Controls.Add(panelContainer)
        txtInput.Text = "Enter value..."
        txtInput.ForeColor = Color.White
        DequeuedValueTextBox.Text = "Dequeued value..."
        DequeuedValueTextBox.ForeColor = Color.White
        FrontTextBox.Text = "Front value..."
        FrontTextBox.ForeColor = Color.White
        RearTextBox.Text = "Rear value..."
        RearTextBox.ForeColor = Color.White
        '     Button1.Location = New Point(735, 20)
        '   Button1.Size = New Size(145, 34)
        '  RectangleShape2.Location = New Point(719, 16)
        '  RectangleShape2.Size = New Size(175, 40)
        ' Add buttons and text boxes to the panelContainer
        'panelContainer.Controls.Add(EnqueueButton)
        'panelContainer.Controls.Add(DequeueButton)
        'panelContainer.Controls.Add(FrontButton)
        'panelContainer.Controls.Add(ClearButton)
        'panelContainer.Controls.Add(txtInput)
        'panelContainer.Controls.Add(DequeuedValueTextBox)
        'panelContainer.Controls.Add(FrontTextBox)
        ShowQuizSection()
        UpdateQuestionNumberDisplay()
    End Sub
    ' Define a class to represent each question
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
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "UPDATE users SET queue_progress = GREATEST(IFNULL(queue_progress, 0), @correctAnswers) WHERE username = @user"
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

    Private Sub LoadQuizQuestions()
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "SELECT serial_no, question, optionA, optionB, optionC, optionD, Correct_Option FROM queue"
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
            MessageBox.Show("Please answer all questions before submitting.")
        End If
    End Sub
    Private Sub queue_FormClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        main_menu.Show()
    End Sub


    Private Sub queue_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queue_back.Click
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        main_menu.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowQuizSection()
    End Sub

    Private Sub EnqueueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnqueueButton.Click
        Try
            ' check if queue size is less than 9 before enqueueing
            If queue.Count < 8 Then
                ' Enqueue the value from the textbox
                Dim value As Integer
                If Integer.TryParse(txtInput.Text, value) Then
                    queue.Enqueue(value)
                    UpdateQueueDisplay()
                Else
                    MessageBox.Show("Please enter a valid integer value.")
                End If
            Else
                MessageBox.Show("queue is already at maximum capacity.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DequeueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DequeueButton.Click
        Try
            ' Dequeue the value
            If queue.Count > 0 Then
                Dim dequeuedValue As Integer = queue.Dequeue()
                UpdateQueueDisplay()
                ' Display the dequeued value
                DequeuedValueTextBox.Text = dequeuedValue.ToString()
            Else
                MessageBox.Show("Queue is empty. Cannot dequeue.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FrontButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrontButton.Click
        Try
            ' Get the value at the front of the queue
            If queue.Count > 0 Then
                Dim frontValue As Integer = queue.Peek()
                FrontTextBox.Text = frontValue.ToString()
            Else
                MessageBox.Show("Queue is empty.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Try
            ' Clear the queue
            queue.Clear()
            UpdateQueueDisplay()
            ' Clear other textboxes
            txtInput.Text = "Enter value..."
            FrontTextBox.Text = "Front value..."
            RearTextBox.Text = "Rear value..."
            DequeuedValueTextBox.Text = "Dequeued value..."
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdateQueueDisplay()
        ' Create a list to hold controls that need to be removed
        Dim controlsToRemove As New List(Of Control)

        ' Find and add TextBox controls (except for txtInput, peekTextBox, and popTextBox) to the removal list
        For Each ctrl As Control In panelContainer.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "txtInput" AndAlso ctrl.Name <> "FrontTextBox" AndAlso ctrl.Name <> "DequeuedValueTextBox" AndAlso ctrl.Name <> "RearTextBox" Then
                controlsToRemove.Add(ctrl)
            End If
        Next

        ' Remove controls in the removal list
        For Each ctrl As Control In controlsToRemove
            panelContainer.Controls.Remove(ctrl)
            ctrl.Dispose() ' Dispose the control to release resources
        Next

        ' Create TextBoxes based on the size of the stack
        Dim index As Integer = 0
        Dim textBoxTop As Integer = 10 ' Initial top position for the text boxes

        For Each item As Integer In queue
            ' Create a new TextBox
            Dim textBox As New TextBox()
            textBox.Text = item.ToString()

            ' Position the TextBox within the panel
            textBox.Top = textBoxTop
            textBox.Left = 10

            ' Add the TextBox to the panel
            panelContainer.Controls.Add(textBox)

            ' Update the top position for the next TextBox
            textBoxTop += textBox.Height + 5 ' Add some spacing between text boxes
            index += 1
        Next
    End Sub

    Private Sub RearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RearButton.Click
        Try
            ' Get the value at the rear of the queue
            If queue.Count > 0 Then
                Dim rearValue As Integer = GetRear()
                RearTextBox.Text = rearValue.ToString()
            Else
                MessageBox.Show("Queue is empty.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetRear() As Integer
        ' Create a copy of the queue
        Dim tempQueue As New Queue(Of Integer)(queue)

        ' Dequeue elements until only one element remains
        While tempQueue.Count > 1
            tempQueue.Dequeue()
        End While

        ' Return the rear element
        Return tempQueue.Peek()
    End Function
    Private Sub txtInput_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtInput.GotFocus
        If txtInput.Text = "Enter value..." Then
            txtInput.Text = ""
            'txtIndex.ForeColor = Color.Black ' Change text color to black
        End If
    End Sub

    Private Sub txtInput_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtInput.LostFocus
        If String.IsNullOrWhiteSpace(txtInput.Text) Then
            txtInput.Text = "Enter value..."
            'txtIndex.ForeColor = Color.Gray ' Change text color to gray
        End If
    End Sub
    Private Sub DequeuedValueTextBox_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DequeuedValueTextBox.GotFocus
        If DequeuedValueTextBox.Text = "Dequeued value..." Then
            DequeuedValueTextBox.Text = ""
            'txtIndex.ForeColor = Color.Black ' Change text color to black
        End If
    End Sub

    Private Sub DequeuedValueTextBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DequeuedValueTextBox.LostFocus
        If String.IsNullOrWhiteSpace(DequeuedValueTextBox.Text) Then
            DequeuedValueTextBox.Text = "Dequeued value..."
            'txtIndex.ForeColor = Color.Gray ' Change text color to gray
        End If
    End Sub
    Private Sub FrontTextBox_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles FrontTextBox.GotFocus
        If FrontTextBox.Text = "Front value..." Then
            FrontTextBox.Text = ""
            'txtIndex.ForeColor = Color.Black ' Change text color to black
        End If
    End Sub

    Private Sub FrontTextBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles FrontTextBox.LostFocus
        If String.IsNullOrWhiteSpace(FrontTextBox.Text) Then
            FrontTextBox.Text = "Front value..."
            'txtIndex.ForeColor = Color.Gray ' Change text color to gray
        End If
    End Sub
    Private Sub RearTextBox_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RearTextBox.GotFocus
        If RearTextBox.Text = "Rear value..." Then
            RearTextBox.Text = ""
            'txtIndex.ForeColor = Color.Black ' Change text color to black
        End If
    End Sub

    Private Sub RearTextBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RearTextBox.LostFocus
        If String.IsNullOrWhiteSpace(RearTextBox.Text) Then
            RearTextBox.Text = "Rear value..."
            'txtIndex.ForeColor = Color.Gray ' Change text color to gray
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim mainMenuForm As New profile()
        mainMenuForm.PreviousForm = Me
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Hide()
    End Sub
End Class