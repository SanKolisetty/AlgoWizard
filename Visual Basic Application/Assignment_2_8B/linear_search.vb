Imports MySql.Data.MySqlClient

Public Class linear_search

    ' Class to represent a quiz question
    Private Class Question
        Public Property Text As String
        Public Property Options As List(Of String)
        Public Property CorrectAnswer As String
    End Class

    ' List to hold labels representing array elements
    Private arrayLabels As New List(Of Label)()
    Private array() As Integer ' Array to store input elements
    Private indexLabels As New List(Of Label)() ' List to hold labels representing array indices
    Private searchTimer As Timer ' Timer for controlling the search process
    Private currentSearchIndex As Integer = -1 ' Index used during the search process
    Private arrayInitialized As Boolean = False ' Boolean flag to track array initialization status

    ' Quiz-related variables
    Private questions As New List(Of Question)() ' List to hold quiz questions
    Private userAnswers As New Dictionary(Of Integer, String)() ' Dictionary to store user's answers
    Private currentQuestionIndex As Integer = 0 ' Index of the current quiz question

    ' Event handler for form load
    Private Sub LinearSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize form controls
        lblSearchResult.Visible = False
        txtInput.ReadOnly = False
        txtList.ReadOnly = False
        btnStop.Text = "Stop"
        'btnStop.Enabled = False
        'btnSearch.Enabled = False
        'btnReset.Enabled = False

        ' Show quiz section
        ShowQuizSection()
        UpdateQuestionNumberDisplay()
    End Sub

    ' Event handler for btnInitialize click
    Private Sub btnInitialize_Click(sender As Object, e As EventArgs) Handles btnInitialize.Click
        Try
            If searchTimer IsNot Nothing Then
                searchTimer.Stop() ' Stop the search process if it's running
            End If
            btnStop.Text = "Stop"
            txtInput.ReadOnly = False
            txtList.ReadOnly = False
            ' Read input from txtList TextBox
            Dim input As String = txtList.Text.Trim()

            ' Split the input into elements
            Dim elements As String() = input.Split(","c)
            If elements.Length > 40 Then
                UpdateSearchResult("Only a maximum of 40 elements are allowed.")
                Return
            End If
            ' Convert input elements to integers and initialize the array
            ReDim array(elements.Length - 1)
            For i As Integer = 0 To elements.Length - 1
                If Not Integer.TryParse(elements(i), array(i)) Then
                    MessageBox.Show("Invalid input. Please enter integers separated by commas.")
                    Return
                End If
            Next

            ' Initialize array visualization
            InitializeArrayVisualization()

            ' Set the array initialization flag to true
            arrayInitialized = True
            currentSearchIndex = -1
        Catch ex As Exception
            ResetOnError()
            MessageBox.Show("An error occurred while initializing the array: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to initialize array visualization
    Private Sub InitializeArrayVisualization()
        ' Reset UI elements
        txtInput.Clear()
        pnlLinearSearch.Controls.Clear()
        pnlLinearSearch.Controls.Add(lblSearchResult)
        arrayLabels.Clear()
        indexLabels.Clear()

        ' Constants for label dimensions and layout
        Dim labelWidth As Integer = 60
        Dim labelHeight As Integer = 40
        Dim xPosition As Integer = 20
        Dim yPosition As Integer = 30
        Dim maxWidth As Integer = pnlLinearSearch.ClientSize.Width

        ' Create labels to represent array elements and add them to the visualization panel
        For i As Integer = 0 To array.Length - 1
            Dim label As New Label()
            label.Text = array(i).ToString()
            label.AutoSize = False
            label.TextAlign = ContentAlignment.MiddleCenter
            label.BorderStyle = BorderStyle.FixedSingle
            label.BackColor = Color.White
            label.ForeColor = Color.Black
            label.Font = New Font(label.Font.FontFamily, 14)
            label.Width = labelWidth
            label.Height = labelHeight
            label.Location = New Point(xPosition, yPosition)
            pnlLinearSearch.Controls.Add(label)
            arrayLabels.Add(label)

            ' Create label for index
            Dim indexLabel As New Label()
            indexLabel.Text = i.ToString()
            indexLabel.AutoSize = False
            indexLabel.TextAlign = ContentAlignment.MiddleCenter
            indexLabel.Width = labelWidth
            indexLabel.Location = New Point(xPosition, yPosition + labelHeight) ' Adjust the y position to display below the array element label
            pnlLinearSearch.Controls.Add(indexLabel)
            indexLabels.Add(indexLabel)

            ' Update position for the next label
            xPosition += labelWidth + 5

            ' Wrap to next row if necessary
            If xPosition + labelWidth > maxWidth Then
                xPosition = 20
                yPosition += labelHeight * 2
            End If
        Next

        lblSearchResult.Visible = False
        'btnSearch.Enabled = True
        'btnReset.Enabled = True
    End Sub

    ' Event handler for Stop button click
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Try
            ' Check if the array is initialized
            If Not arrayInitialized Then
                ResetOnError()
                MessageBox.Show("Please initialize the array first.")
                Return
            End If
            lblSearchResult.Visible = False
            If searchTimer IsNot Nothing Then
                If searchTimer.Enabled Then
                    searchTimer.Stop() ' Pause the search process
                    btnStop.Text = "Resume"
                Else
                    If currentSearchIndex < array.Length Then
                        searchTimer.Start() ' Resume the search process
                        btnStop.Text = "Stop"
                    End If
                End If
            End If
        Catch ex As Exception
            ResetOnError()
            MessageBox.Show("An error occurred while stopping or resuming the search process: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for Reset button click
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            lblSearchResult.Visible = False
            If searchTimer IsNot Nothing Then
                searchTimer.Stop() ' Stop the search process if it's running
            End If
            currentSearchIndex = -1 ' Reset the currentSearchIndex
            arrayInitialized = False
            txtList.ReadOnly = False
            txtList.Clear()
            arrayLabels.Clear()
            indexLabels.Clear()
            pnlLinearSearch.Controls.Clear()
            pnlLinearSearch.Controls.Add(lblSearchResult)
            'ResetVisualization() ' Reset the visualization
            txtInput.ReadOnly = False ' Enable the text input field
            txtInput.Clear() ' Clear the text input field
            btnStop.Text = "Stop"
        Catch ex As Exception
            ResetOnError()
            MessageBox.Show("An error occurred while resetting the search process: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for Search button click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            ' Check if the array is initialized
            If Not arrayInitialized Then
                ResetOnError()
                MessageBox.Show("Please initialize the array first.")
                Return
            ElseIf searchTimer IsNot Nothing Then
                searchTimer.Stop() ' Stop the search process if it's running
            End If

            ' Perform linear search
            ResetVisualization() ' Reset the visualization
            btnStop.Text = "Stop"
            lblSearchResult.Visible = False
            Dim searchElement As Integer
            If Integer.TryParse(txtInput.Text, searchElement) Then
                lblSearchResult.Visible = False
                InitializeSearchTimer(searchElement)
            Else
                If searchTimer IsNot Nothing Then
                    searchTimer.Stop() ' Stop the search process if it's running
                End If
                MessageBox.Show("Please enter a valid integer.")
                btnStop.Text = "Stop"
            End If
        Catch ex As Exception
            ResetOnError()
            MessageBox.Show("An error occurred while performing the search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Initialize the search timer
    Private Sub InitializeSearchTimer(ByVal searchElement As Integer)
        Try

            'txtInput.Enabled = False
            txtInput.ReadOnly = True
            txtList.ReadOnly = True
            'btnSearch.Enabled = False
            currentSearchIndex = 0 'Reset the currentSearchIndex

            'Create a Timer with an interval of 1000 milliseconds (1 second)
            searchTimer = New Timer With {
                .Interval = 1000
            }

            'Add an event handler for the Tick event
            AddHandler searchTimer.Tick, Sub(sender, e) SearchAndHighlight(searchElement)

            searchTimer.Start() 'Start the timer
        Catch ex As Exception
            ResetOnError()
            MessageBox.Show("An error occurred while initializing the search timer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Search and highlight matching elements
    Private Sub SearchAndHighlight(ByVal searchElement As Integer)
        Try
            'Reset the color for all items before each search
            ResetVisualization()

            'Highlight the current item
            If currentSearchIndex < array.Length Then
                arrayLabels(currentSearchIndex).BackColor = Color.SteelBlue
            End If

            'Search and highlight the matching elements
            If currentSearchIndex < array.Length Then
                If array(currentSearchIndex) = searchElement Then
                    arrayLabels(currentSearchIndex).BackColor = Color.Yellow
                    searchTimer.Stop() 'Stop the timer after processing all elements
                    UpdateSearchResult("Element " & searchElement & " found at index " & currentSearchIndex & ".")
                    currentSearchIndex = 0 ' Reset the currentSearchIndex
                    btnStop.Text = "Stop"
                    'btnSearch.Enabled = True
                    'btnStop.Enabled = False
                    'txtInput.Enabled = True ' Enable the text input field
                    txtInput.ReadOnly = False ' Enable the text input field
                    txtList.ReadOnly = False
                    Return
                End If
                currentSearchIndex += 1 'Increment the currentSearchIndex
            Else
                searchTimer.Stop() 'Stop the timer after processing all elements
                'btnSearch.Enabled = True
                'txtInput.Enabled = True
                txtInput.ReadOnly = False
                txtList.ReadOnly = False
                UpdateSearchResult("Element " & searchElement & " not found.")
                btnStop.Text = "Stop"
                Return
            End If
        Catch ex As Exception
            ResetOnError()
            MessageBox.Show("An error occurred while searching and highlighting elements: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update the search result label
    Private Sub UpdateSearchResult(ByVal message As String)
        lblSearchResult.Text = message
        lblSearchResult.Visible = True
    End Sub

    ' Reset the visualization
    Private Sub ResetVisualization()
        For Each label In arrayLabels
            label.BackColor = Color.White ' Reset color of all labels
        Next
    End Sub

    Private Sub ResetOnError()
        If searchTimer IsNot Nothing Then
            searchTimer.Stop() ' Stop the search process if it's running
        End If
        'currentSearchIndex = 0 ' Reset the currentSearchIndex
        btnStop.Text = "Stop"
        txtInput.ReadOnly = False ' Enable the text input field
        txtList.ReadOnly = False
    End Sub

    ' Function to show quiz section
    Private Sub ShowQuizSection()
        ' Reset all variables and UI elements related to the quiz
        questions = New List(Of Question)()
        userAnswers = New Dictionary(Of Integer, String)()
        currentQuestionIndex = 0
        btnPrev.Visible = False
        btnNext.Visible = True
        ' Load quiz questions from the database
        LoadQuizQuestions()
        DisplayQuestion()
        UpdateQuestionNumberDisplay()
        ' Show quiz controls
        lblQuizQuestion.Visible = True
        rbOption1.Visible = True
        rbOption2.Visible = True
        rbOption3.Visible = True
        rbOption4.Visible = True
    End Sub

    ' Function to load quiz questions
    Private Sub LoadQuizQuestions()
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "SELECT serial_no, question, optionA, optionB, optionC, optionD, Correct_Option FROM linear_search"
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
            ResetOnError()
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

        ' Check if the user has previously answered this question
        If userAnswers.ContainsKey(currentQuestionIndex) Then
            Dim selectedOption As String = userAnswers(currentQuestionIndex)
            ' Select the corresponding RadioButton
            If selectedOption = currentQuestion.Options(0) Then
                rbOption1.Checked = True
            ElseIf selectedOption = currentQuestion.Options(1) Then
                rbOption2.Checked = True
            ElseIf selectedOption = currentQuestion.Options(2) Then
                rbOption3.Checked = True
            ElseIf selectedOption = currentQuestion.Options(3) Then
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
    End Sub

    ' Event handler for radio button selection (answer selection)
    Private Sub rbOption_CheckedChanged(sender As Object, e As EventArgs) Handles rbOption1.CheckedChanged, rbOption2.CheckedChanged, rbOption3.CheckedChanged, rbOption4.CheckedChanged
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
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click

        ' Move to the previous question if available
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
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Move to the next question if available
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
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If userAnswers.Count = questions.Count Then
            ShowQuizResults()
        Else
            ResetOnError()
            MessageBox.Show("Please answer all questions before submitting.")
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

        ' Update the users table with the new linearsearch_progress value
        Dim user As String = GlobalVariables.global_user
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "UPDATE users SET linearsearch_progress = GREATEST(IFNULL(linearsearch_progress, 0), @correctAnswers) WHERE username = @user"

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
                        If searchTimer IsNot Nothing Then
                            searchTimer.Stop() ' Stop the search process if it's running
                        End If
                        MessageBox.Show("Failed to update quiz results.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ResetOnError()
            MessageBox.Show("Error updating quiz results: " & ex.Message)
        End Try

        ResetOnError()
        ' Display the results
        MessageBox.Show("You answered " & correctAnswers & " out of " & totalQuestions & " questions correctly.")
    End Sub

    ' Event handler for the Back button click
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        txtList.Clear()
        txtInput.Clear()
        arrayLabels.Clear()
        indexLabels.Clear()
        pnlLinearSearch.Controls.Clear()
        pnlLinearSearch.Controls.Add(lblSearchResult)
        currentSearchIndex = -1
        arrayInitialized = False
        btnStop.Text = "Stop"

        Dim mainMenuForm As New searching()
        searching.StartPosition = FormStartPosition.Manual
        searching.Location = Me.Location ' Set the location of the new form to the current form's location
        searching.Show()
        Me.Hide()
    End Sub

    ' Event handler for the Profile button click
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        txtList.Clear()
        txtInput.Clear()
        arrayLabels.Clear()
        indexLabels.Clear()
        pnlLinearSearch.Controls.Clear()
        pnlLinearSearch.Controls.Add(lblSearchResult)
        currentSearchIndex = -1
        arrayInitialized = False
        btnStop.Text = "Stop"

        Dim Profile As New profile()
        Profile.PreviousForm = Me
        Profile.StartPosition = FormStartPosition.Manual
        Profile.Location = Me.Location ' Set the location of the new form to the current form's location
        Me.Hide() ' Hide the current form
        Profile.Show()
    End Sub

    ' Event handler for the Reset Questions button click
    Private Sub btnResetQues_Click(sender As System.Object, e As System.EventArgs) Handles btnResetQues.Click
        ShowQuizSection()
    End Sub

    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        txtList.Clear()
        txtInput.Clear()
        arrayLabels.Clear()
        indexLabels.Clear()
        pnlLinearSearch.Controls.Clear()
        pnlLinearSearch.Controls.Add(lblSearchResult)
        currentSearchIndex = -1
        arrayInitialized = False
        btnStop.Text = "Stop"

        Dim mainMenuForm As New main_menu()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location
        mainMenuForm.Show()
        Me.Hide()
    End Sub

End Class
