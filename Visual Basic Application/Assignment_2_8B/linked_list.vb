Imports MySql.Data.MySqlClient ' Import MySQL library

Public Class linked_list

    ' Class to represent a quiz question
    Private Class Question
        Public Property Text As String ' Property to store the text of the question
        Public Property Options As List(Of String) ' Property to store the options for the question
        Public Property CorrectAnswer As String ' Property to store the correct answer for the question
    End Class

    ' Declare variables
    Private linkedList As New LinkedList() ' Initialize a linked list
    Private targetNodeValue As Integer = 0 ' Value of the node to search for
    Private highlightIndex = -1 ' Index of the node to highlight
    Dim highlightColor As String = "MidnightBlue" ' Color for highlighting

    ' List to hold the quiz questions
    Private questions As New List(Of Question)() ' Initialize a list of quiz questions
    ' Dictionary to store user's answers
    Private userAnswers As New Dictionary(Of Integer, String)() ' Initialize a dictionary to store user answers
    ' Current question index
    Private currentQuestionIndex As Integer = 0 ' Initialize the current question index

    ' Event handler for form load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtIndex.Text = "Enter Index..."
        txtIndex.ForeColor = Color.White
        txtValue.Text = "Enter Value..."
        txtValue.ForeColor = Color.White
        ' Clear the panel for linked list visualization
        pnlLinkedList.Controls.Clear()
        ' Draw the linked list visualization initially
        DrawLinkedListVisualization()


        ShowQuizSection()
        UpdateQuestionNumberDisplay()
    End Sub

    Private Sub pnlLinkedList_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlLinkedList.Paint
        ' Initialize graphics object
        Dim g As Graphics = e.Graphics
        ' Clear the panel with a specific color
        g.Clear(Color.FromArgb(172, 206, 231))
        ' Adjust graphics to match current AutoScroll position
        e.Graphics.TranslateTransform(pnlLinkedList.AutoScrollPosition.X, pnlLinkedList.AutoScrollPosition.Y)
        ' Set smoothing mode to improve drawing quality
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' Access the linked list data
        Dim nodeCount As Integer = linkedList.Count() ' Get the number of nodes
        Dim startX As Integer = 30 ' Initial X-coordinate
        Dim startY As Integer = pnlLinkedList.ClientSize.Height \ 2 ' Y-coordinate of the center
        Dim spacingX As Integer = 65 ' Spacing between nodes
        Dim circleSize As Integer = 40 ' Diameter of the circle
        Dim totalWidth As Integer = startX + (nodeCount - 1) * (spacingX) + circleSize ' Calculate total width of the content
        ' Set minimum size for autoscrolling
        pnlLinkedList.AutoScrollMinSize = New Size(totalWidth, pnlLinkedList.ClientSize.Height)

        ' Draw circles for each node
        Dim current As Node = linkedList.GetHead()
        For i As Integer = 0 To nodeCount - 1
            Dim x As Integer = startX + i * spacingX
            Dim y As Integer = startY
            Dim nodeValue As String = current.Value.ToString() ' Get value of current node
            g.DrawEllipse(Pens.Black, x - circleSize \ 2, y - circleSize \ 2, circleSize, circleSize) ' Draw circle
            g.DrawString(nodeValue, Me.Font, Brushes.Black, x - 6, y - 6) ' Display node value
            current = current.NextNode ' Move to next node
        Next

        ' Highlight the node at the specified index
        If highlightIndex >= 0 AndAlso highlightIndex < nodeCount Then
            ' Get node value
            current = linkedList.GetHead()
            For i As Integer = 0 To highlightIndex - 1
                current = current.NextNode ' Move to next node
            Next

            Dim x As Integer = startX + highlightIndex * spacingX
            Dim y As Integer = startY
            Dim highlightBrush As New SolidBrush(Color.FromName(highlightColor))
            g.FillEllipse(highlightBrush, x - circleSize \ 2, y - circleSize \ 2, circleSize, circleSize) ' Highlight node
            Dim highlightedValue As String = current.Value.ToString() ' Get value of highlighted node
            g.DrawString(highlightedValue, Me.Font, Brushes.White, x - 6, y - 6) ' Display highlighted node value
        End If

        ' Draw arrows between nodes
        For i As Integer = 0 To nodeCount - 2
            Dim startXArrow As Integer = startX + i * spacingX + circleSize \ 2 ' Arrow start X-coordinate
            Dim startYArrow As Integer = startY ' Arrow start Y-coordinate
            Dim endXArrow As Integer = startX + (i + 1) * spacingX - circleSize \ 2 ' Arrow end X-coordinate
            Dim endYArrow As Integer = startY ' Arrow end Y-coordinate
            DrawArrow(g, Pens.Black, startXArrow, startYArrow, endXArrow, endYArrow) ' Draw arrow between nodes
        Next
    End Sub

    ' Function to draw an arrow
    Private Sub DrawArrow(ByVal g As Graphics, ByVal pen As Pen, ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer)
        ' Draw line
        g.DrawLine(pen, x1, y1, x2, y2)
        ' Calculate angle for arrow direction
        Dim angle As Double = Math.Atan2(y2 - y1, x2 - x1)
        Dim arrowSize As Integer = 10 ' Size of the arrow
        ' Calculate points for arrow polygon
        Dim points() As Point = {New Point(x2, y2), New Point(x2 - CInt(arrowSize * Math.Cos(angle - Math.PI / 6)), y2 - CInt(arrowSize * Math.Sin(angle - Math.PI / 6))), New Point(x2 - CInt(arrowSize * Math.Cos(angle + Math.PI / 6)), y2 - CInt(arrowSize * Math.Sin(angle + Math.PI / 6)))}
        ' Fill polygon to create arrow
        g.FillPolygon(Brushes.Black, points)
    End Sub

    ' Method to trigger panel redrawing for updating the linked list visualization
    Private Sub DrawLinkedListVisualization()
        pnlLinkedList.Invalidate()
    End Sub

    ' Event handler for appending a node to the linked list
    Private Sub linked_list_append_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linked_list_append.Click
        Dim value As Integer
        ' Check if the maximum node limit has been reached
        If linkedList.Count() >= 100 Then
            MessageBox.Show("Maximum node limit (100) reached. No more nodes can be inserted.")
            Return
        End If
        ' Validate input value
        If Not Integer.TryParse(txtValue.Text, value) Then
            MessageBox.Show("Invalid Value: Please enter a valid integer for the node value.")
            Return
        Else
            ' Append a node to the end of the linked list
            linkedList.Append(value)
            DrawLinkedListVisualization() ' Redraw the linked list visualization
        End If
    End Sub

    ' Event handler for inserting a node into the linked list
    Private Sub linked_list_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linked_list_insert.Click
        Dim index As Integer
        Dim value As Integer
        ' Check if the maximum node limit has been reached
        If linkedList.Count() >= 100 Then
            MessageBox.Show("Maximum node limit (100) reached. No more nodes can be inserted.")
            Return
        End If
        ' Validate input index and value
        If Not Integer.TryParse(txtIndex.Text, index) Then
            MessageBox.Show("Invalid Index: Please enter a valid integer for the node index.")
            Return
        ElseIf Not Integer.TryParse(txtValue.Text, value) Then
            MessageBox.Show("Invalid Value: Please enter a valid integer for the node value.")
            Return
        Else
            ' Insert a node at a specific position in the linked list
            Dim result As Integer = linkedList.Insert(index, value)
            If result = -1 Then
                MessageBox.Show("Index out of range: The specified index is not within the valid range of the linked list.")
            Else
                DrawLinkedListVisualization() ' Redraw the linked list visualization
            End If
        End If
    End Sub

    ' Event handler for deleting a node from the linked list
    Private Sub linked_list_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linked_list_delete.Click
        Dim value As Integer
        ' Validate input value
        If Not Integer.TryParse(txtValue.Text, value) Then
            MessageBox.Show("Invalid Value: Please enter a valid integer for the node value.")
            Return
        Else
            ' Delete a node from the linked list
            Dim result As Integer = linkedList.Delete(value)
            If result = -1 Then
                MessageBox.Show("Node with value " & value.ToString() & " not found.")
            Else
                MessageBox.Show("Node with value " & value.ToString() & " deleted from index " & result.ToString() & ".")
                DrawLinkedListVisualization() ' Redraw the linked list visualization
            End If
        End If
    End Sub

    ' Event handler for searching a node in the linked list
    Private Sub linked_list_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linked_list_search.Click
        Dim value As Integer
        ' Validate input value
        If Not Integer.TryParse(txtValue.Text, value) Then
            MessageBox.Show("Invalid Value: Please enter a valid integer for the node value.")
            Return
        Else
            ' Search for a node in the linked list
            Dim result As Integer = linkedList.Search(value)

            ' Get the number of nodes in the linked list
            Dim nodeCount As Integer = linkedList.Count()

            ' Highlight each node sequentially
            highlightColor = "SteelBlue"
            For i As Integer = 0 To nodeCount - 1
                ' Redraw the linked list visualization with the highlighted node
                highlightIndex = i

                If highlightIndex = result Then
                    Exit For ' Exit the loop if the desired node is found
                End If

                DrawLinkedListVisualization()
                Application.DoEvents()
                ' Pause briefly to observe the highlighted node (optional)
                System.Threading.Thread.Sleep(500)
            Next

            highlightColor = "MidnightBlue"
            ' Redraw the linked list visualization with the highlighted node
            DrawLinkedListVisualization()

            If highlightIndex = -1 Then
                MessageBox.Show("Node not found in the linked list.")
            Else
                MessageBox.Show("Node found at index: " & highlightIndex.ToString())
            End If
            highlightIndex = -1
        End If
    End Sub

    ' Event handler for resetting the linked list
    Private Sub linked_list_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linked_list_reset.Click
        ' Clear the linked list
        linkedList.Clear()

        ' Redraw the linked list visualization
        DrawLinkedListVisualization()
    End Sub

    ' Function to load quiz questions from the database
    Private Sub LoadQuizQuestions()
        ' Connection string for the MySQL database
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        ' SQL query to retrieve quiz questions from the database
        Dim query As String = "SELECT serial_no, question, optionA, optionB, optionC, optionD, Correct_Option FROM linkedlist"
        ' List to store all retrieved quiz questions
        Dim allQuestions As New List(Of Question)()

        Try
            ' Establishing a connection to the database
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    ' Executing the SQL query to retrieve quiz questions
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Iterating through the retrieved records
                        While reader.Read()
                            ' Extracting question text, options, and correct answer from the database record
                            Dim questionText As String = reader.GetString("question")
                            Dim options As New List(Of String) From {
                                reader.GetString("optionA"),
                                reader.GetString("optionB"),
                                reader.GetString("optionC"),
                                reader.GetString("optionD")
                            }
                            Dim correctAnswer As String = reader.GetString("Correct_Option")
                            ' Creating a new Question object and adding it to the list of all questions
                            allQuestions.Add(New Question With {
                                .Text = questionText,
                                .Options = options,
                                .CorrectAnswer = correctAnswer
                            })
                        End While
                    End Using
                End Using
            End Using

            ' Selecting a random subset of questions from all retrieved questions
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

    ' Function to display a quiz question
    Private Sub DisplayQuestion()
        ' Retrieving the current question to be displayed
        Dim currentQuestion As Question = questions(currentQuestionIndex)
        ' Displaying the question text
        lblQuizQuestion.Text = currentQuestion.Text

        ' Calculating the height of the question label to position the options properly
        Dim questionLabelHeight As Integer = TextRenderer.MeasureText(lblQuizQuestion.Text, lblQuizQuestion.Font, New Size(lblQuizQuestion.Width, Integer.MaxValue), TextFormatFlags.WordBreak).Height

        ' Positioning the options based on the height of the question label
        Dim optionTopMargin As Integer = 8 ' Adjust this value based on your layout
        rbOption1.Top = questionLabelHeight + optionTopMargin
        rbOption2.Top = rbOption1.Bottom + optionTopMargin
        rbOption3.Top = rbOption2.Bottom + optionTopMargin
        rbOption4.Top = rbOption3.Bottom + optionTopMargin
        btnPrev.Top = rbOption3.Bottom + optionTopMargin + 10
        btnNext.Top = rbOption3.Bottom + optionTopMargin + 10

        ' Setting the text of RadioButton controls to display options
        rbOption1.Text = currentQuestion.Options(0)
        rbOption2.Text = currentQuestion.Options(1)
        rbOption3.Text = currentQuestion.Options(2)
        rbOption4.Text = currentQuestion.Options(3)

        ' Checking the RadioButton corresponding to the user's previous answer, if any
        If userAnswers.ContainsKey(currentQuestionIndex) Then
            Dim selectedOption As String = userAnswers(currentQuestionIndex)
            Select Case selectedOption
                Case "A"
                    rbOption1.Checked = True
                Case "B"
                    rbOption2.Checked = True
                Case "C"
                    rbOption3.Checked = True
                Case "D"
                    rbOption4.Checked = True
            End Select
        Else
            ' Clearing the selection of all RadioButtons if the question is being loaded for the first time
            rbOption1.Checked = False
            rbOption2.Checked = False
            rbOption3.Checked = False
            rbOption4.Checked = False
        End If
    End Sub

    ' Function to update the display of the current question number
    Private Sub UpdateQuestionNumberDisplay()
        lblQuestionNumber.Text = (currentQuestionIndex + 1) & "/" & questions.Count

        ' Enabling the Submit button if all questions have been answered, otherwise disabling it
        'btnSubmit.Enabled = (userAnswers.Count = questions.Count)
    End Sub

    ' Event handler for radio button selection (answer selection)
    Private Sub rbOption_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbOption1.CheckedChanged, rbOption2.CheckedChanged, rbOption3.CheckedChanged, rbOption4.CheckedChanged
        ' Update user's answer when a radio button is checked
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
            ' Store the selected option in userAnswers dictionary
            userAnswers(currentQuestionIndex) = selectedOption
        End If

        ' Update the display of the current question number
        UpdateQuestionNumberDisplay()
    End Sub

    ' Event handler for the Previous button click
    Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrev.Click
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
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
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
    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        ' Check if all questions have been answered before submitting
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
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "UPDATE users SET linkedlist_progress = GREATEST(IFNULL(linkedlist_progress, 0), @correctAnswers) WHERE username = @user"
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

    ' Function to show the quiz section
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
        btnSubmit.Visible = True
    End Sub

    ' Event handler for the Back button click to return to the main menu
    Private Sub linked_list_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linked_list_back.Click
        ' Clear the linked list and UI controls related to the linked list visualization
        linkedList.Clear()
        pnlLinkedList.Controls.Clear()
        ' Show the main menu form
        Dim mainMenuForm As New main_menu()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Me.Hide() ' Hide the current form
    End Sub
    ' Event handler for when the "Enter Index" textbox gains focus
    Private Sub txtIndex_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtIndex.GotFocus
        ' Clear the "Enter Index" text if it is the current text
        If txtIndex.Text = "Enter Index..." Then
            txtIndex.Text = ""
        End If
    End Sub

    ' Event handler for when the "Enter Index" textbox loses focus
    Private Sub txtIndex_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtIndex.LostFocus
        ' Reset the "Enter Index" text if it is empty
        If String.IsNullOrWhiteSpace(txtIndex.Text) Then
            txtIndex.Text = "Enter Index..."
        End If
    End Sub

    ' Event handler for when the "Enter Value" textbox gains focus
    Private Sub txtValue_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtValue.GotFocus
        ' Clear the "Enter Value" text if it is the current text
        If txtValue.Text = "Enter Value..." Then
            txtValue.Text = ""
        End If
    End Sub

    ' Event handler for when the "Enter Value" textbox loses focus
    Private Sub txtValue_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtValue.LostFocus
        ' Reset the "Enter Value" text if it is empty
        If String.IsNullOrWhiteSpace(txtValue.Text) Then
            txtValue.Text = "Enter Value..."
        End If
    End Sub

    ' Event handler for the Profile button click
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ' Clear the linked list and UI controls related to the linked list visualization
        linkedList.Clear()
        pnlLinkedList.Controls.Clear()
        ' Show the profile form
        Dim Profile As New profile()
        Profile.PreviousForm = Me
        Profile.StartPosition = FormStartPosition.Manual
        Profile.Location = Me.Location ' Set the location of the new form to the current form's location
        Profile.Show()
        Me.Hide() ' Hide the current form
    End Sub

    ' Event handler for the Menu button click
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        ' Clear the linked list and UI controls related to the linked list visualization
        linkedList.Clear()
        pnlLinkedList.Controls.Clear()
        ' Show the main menu form
        Dim mainMenuForm As New main_menu()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location
        mainMenuForm.Show()
        Me.Hide() ' Hide the current form
    End Sub

    ' Event handler for the Reset button click
    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        ' Reset the quiz section
        ShowQuizSection()
    End Sub
End Class

' Class representing a Node in a linked list
Public Class Node
    Public Value As Integer
    Public NextNode As Node

    Public Sub New(ByVal value As Integer)
        Me.Value = value
        Me.NextNode = Nothing
    End Sub
End Class

' Class representing a Linked List
Public Class LinkedList
    Private head As Node

    ' Method to append a node to the end of the linked list
    Public Sub Append(ByVal value As Integer)
        ' Append a new node with the given value
        If head Is Nothing Then
            head = New Node(value)
            Return
        End If

        Dim current As Node = head
        While current.NextNode IsNot Nothing
            current = current.NextNode
        End While

        current.NextNode = New Node(value)
    End Sub

    ' Method to insert a node at a specific position in the linked list
    Public Function Insert(ByVal index As Integer, ByVal value As Integer) As Integer
        ' Insert a new node with the given value at the specified index
        Dim newNode As New Node(value)

        If index < 0 Then
            Return -1 ' Index out of range
        End If

        If index = 0 Then
            newNode.NextNode = head
            head = newNode
            Return index ' Successfully inserted at index 0
        End If

        Dim current As Node = head
        Dim currentIndex As Integer = 0

        While current IsNot Nothing AndAlso currentIndex < index - 1
            current = current.NextNode
            currentIndex += 1
        End While

        If current Is Nothing Then
            Return -1 ' Index out of range
        End If

        Dim newNodeAfter As Node = current.NextNode
        current.NextNode = newNode
        newNode.NextNode = newNodeAfter
        Return index ' Successfully inserted at specified index
    End Function

    ' Method to delete a node with a specific value from the linked list
    Public Function Delete(ByVal value As Integer) As Integer
        ' Delete the node with the given value from the linked list
        If head Is Nothing Then
            Return -1 ' Empty list
        End If

        If head.Value = value Then
            head = head.NextNode
            Return 0 ' Node deleted at index 0
        End If

        Dim current As Node = head
        Dim index As Integer = 0

        While current.NextNode IsNot Nothing
            If current.NextNode.Value = value Then
                current.NextNode = current.NextNode.NextNode
                Return index + 1 ' Node deleted at index (index + 1)
            End If
            current = current.NextNode
            index += 1
        End While

        Return -1 ' Node not found
    End Function

    ' Method to search for a node with a specific value in the linked list
    Public Function Search(ByVal value As Integer) As Integer
        ' Search for the node with the given value in the linked list
        Dim current As Node = head
        Dim index As Integer = 0

        While current IsNot Nothing
            If current.Value = value Then
                Return index
            End If
            current = current.NextNode
            index += 1
        End While

        Return -1 ' Node not found
    End Function

    ' Method to get the head of the linked list
    Public Function GetHead() As Node
        ' Get the head node of the linked list
        Return head
    End Function

    ' Method to count the number of nodes in the linked list
    Public Function Count() As Integer
        ' Count the number of nodes in the linked list
        Dim num_nodes As Integer = 0
        Dim current As Node = head
        While current IsNot Nothing
            num_nodes += 1
            current = current.NextNode
        End While
        Return num_nodes
    End Function

    ' Method to clear the linked list
    Public Sub Clear()
        head = Nothing
    End Sub
End Class

