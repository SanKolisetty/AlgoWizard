Imports MySql.Data.MySqlClient
Public Class merge_sort

    Private Sub merge_sort_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
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

    Dim key As String = "A"
    Dim start As Integer = 1
    Dim temp4 As Integer
    Dim key_int As Integer = -1

    Dim x_sepr As Integer = 15
    Dim y_sepr As Integer = 20
    Dim x_par As Integer = 140
    Dim y_par As Integer = 130
    Public x_box As Integer = 20
    Dim y_box As Integer = 20


    Dim main_fragment As New Fragment(0, -1, 0, False, False)
    Dim all_fragments As New List(Of Fragment)()
    Dim max_hierarchy As Integer = 0
    Dim fragments_count As Integer = 1

    Dim mergeFragmentsIndex As New List(Of Integer)()
    Dim leftPointer As Integer = 0
    Dim rightPointer As Integer = 0
    Dim counter As Integer = 0
    Dim no_steps As Integer = 0
    Dim parent_index As Integer = 0
    Dim zz As Integer = 0
    Dim merge_active = 0
    Dim all_textbox_filled As Boolean = True
    Dim all_textbox_values_valid As Boolean = True



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




    Public Class Fragment
        Public array As New List(Of Integer)()
        Public id As Integer
        Public parent As Integer
        Public hierarchy As Integer
        Public sorted As Boolean
        Public splitted As Boolean

        Public x_cor As Integer
        Public y_cor As Integer
        Public text_box As New List(Of TextBox)()
        ' Public Sub New(ByVal array As List(Of Integer)(), ByVal id As Integer, ByVal parent As Integer, ByVal hierarchy As Integer, ByVal sorted As Boolean, ByVal splitted As Boolean)
        Public Sub New(ByVal id As Integer, ByVal parent As Integer, ByVal hierarchy As Integer, ByVal sorted As Boolean, ByVal splitted As Boolean)
            Me.id = id
            Me.parent = parent
            Me.hierarchy = hierarchy
            Me.sorted = sorted
            Me.splitted = splitted
        End Sub

        Public Sub add_element(ByVal i As Integer)
            array.Add(i)
        End Sub

        Public Sub set_coordinates(ByVal x As Integer, ByVal y As Integer)
            x_cor = x
            y_cor = y
        End Sub
        Public Sub create_textbox()
            text_box = New List(Of TextBox)()
            For i As Integer = 0 To array.Count - 1
                Dim textbox As New TextBox




                textbox.Name = "fragBox" & id & "." & i.ToString()
                textbox.Location = New Point(x_cor + (i * 20), y_cor) ' Adjust the location as needed
                textbox.Size = New Size(20, 20) ' Adjust the size as needed
                textbox.BorderStyle = BorderStyle.FixedSingle
                'Container.Controls.Add(TextBox)

                If array(i) > -1000000000 Then
                    textbox.Text = array(i)
                Else
                    textbox.Text = " "
                End If
                If array(i) < 1000000000 Then
                    text_box.Add(textbox)
                End If

            Next
        End Sub
    End Class





    Private Sub splitSubArray()
        For Each i As Fragment In all_fragments
            If (i.hierarchy = max_hierarchy) And (i.sorted = False) Then
                Dim mid_sz As Integer = i.array.Count \ 2
                Dim frag_1 As New Fragment(fragments_count, i.id, i.hierarchy + 1, False, False)
                fragments_count += 1
                Dim frag_2 As New Fragment(fragments_count, i.id, i.hierarchy + 1, False, False)
                fragments_count += 1
                max_hierarchy += 1


                For f As Integer = 0 To mid_sz - 1
                    frag_1.array.Add(i.array(f))
                Next
                For g As Integer = mid_sz To i.array.Count - 1
                    frag_2.array.Add(i.array(g))
                Next
                If frag_1.array.Count = 1 Then
                    frag_1.sorted = True
                End If
                If frag_2.array.Count = 1 Then
                    frag_2.sorted = True
                End If
                frag_1.set_coordinates(i.x_cor - (Math.Pow(2, 2 - i.hierarchy)) * x_sepr, i.y_cor + y_box + y_sepr)
                frag_2.set_coordinates(i.x_cor + (Math.Pow(2, 2 - i.hierarchy)) * x_sepr + (Math.Pow(2, 3 - i.hierarchy)) * x_box, i.y_cor + y_box + y_sepr)
                i.splitted = True
                all_fragments.Add(frag_1)
                all_fragments.Add(frag_2)
                For j As Integer = 0 To i.array.Count - 1
                    i.array(j) = -1000000002
                Next
                Exit For
            End If
        Next
    End Sub



    Private Sub mergeSortedSubArray()
        For i As Integer = 0 To all_fragments.Count - 1
            If all_fragments(i).hierarchy = max_hierarchy And all_fragments(i).sorted = True And zz = 0 Then
                mergeFragmentsIndex.Add(i)

            End If

        Next
        If mergeFragmentsIndex.Count = 1 Then
            counter = 0
            leftPointer = 0
            rightPointer = 0
            no_steps = 0
            mergeFragmentsIndex = New List(Of Integer)()
            zz = 0
            merge_active = 0
        End If
        If mergeFragmentsIndex.Count = 2 Then
            zz = 1
        End If
        If mergeFragmentsIndex.Count > 0 And zz = 1 Then

            For i As Integer = 0 To all_fragments.Count - 1
                If all_fragments(i).id = all_fragments(mergeFragmentsIndex(0)).parent Then
                    parent_index = i
                End If
            Next
            If merge_active = 0 Then
                no_steps = all_fragments(mergeFragmentsIndex(0)).array.Count + all_fragments(mergeFragmentsIndex(1)).array.Count
                all_fragments(mergeFragmentsIndex(0)).array.Add(1000000000)
                all_fragments(mergeFragmentsIndex(1)).array.Add(1000000000)
            End If
            merge_active = 1
            If counter < no_steps Then
                If all_fragments(mergeFragmentsIndex(0)).array(leftPointer) <= all_fragments(mergeFragmentsIndex(1)).array(rightPointer) Then
                    all_fragments(parent_index).array(counter) = all_fragments(mergeFragmentsIndex(0)).array(leftPointer)
                    all_fragments(mergeFragmentsIndex(0)).array(leftPointer) = -1000000009
                    leftPointer += 1
                Else
                    all_fragments(parent_index).array(counter) = all_fragments(mergeFragmentsIndex(1)).array(rightPointer)
                    all_fragments(mergeFragmentsIndex(1)).array(rightPointer) = -1000000009
                    rightPointer += 1
                End If
                counter += 1
            Else
                counter = 0
                leftPointer = 0
                rightPointer = 0
                no_steps = 0
                Dim remove_id As New List(Of Integer)()
                remove_id.Add(all_fragments(mergeFragmentsIndex(0)).id)
                remove_id.Add(all_fragments(mergeFragmentsIndex(1)).id)

                mergeFragmentsIndex = New List(Of Integer)()
                max_hierarchy -= 1
                all_fragments(parent_index).sorted = True
                all_fragments(parent_index).splitted = False
                all_fragments.RemoveAll(Function(x) remove_id.Contains(x.id))
                zz = 0
                merge_active = 0
            End If
        End If
    End Sub
    Private Sub drawFragments(ByVal container As Control)

        For i As Integer = Panel1.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = Panel1.Controls(i)
            ' If TypeOf ctrl Is TextBox AndAlso ctrl.Name.StartsWith("txtBox") Then
            If ctrl.Name.StartsWith("txtBox") Or ctrl.Name.StartsWith("fragBox") Then
                Panel1.Controls.Remove(ctrl)
                ctrl.Dispose() ' Dispose the control to release its resources
            End If
        Next
        For Each i As Fragment In all_fragments
            i.create_textbox()
        Next
        UpdateTextBoxValues()
        For Each i As Fragment In all_fragments
            For Each j As TextBox In i.text_box
                container.Controls.Add(j)
            Next
        Next
    End Sub



    Private Sub textboxParse()
        ' Initialize the integer list with values from TextBox controls
        For Each tb As TextBox In text_boxes
            If Integer.TryParse(tb.Text, value) Then
                main_fragment.array.Add(value)
            End If
        Next
        'For Each Val As Integer In input_array
        ' bubble_sort_size_label.Text = bubble_sort_size_label.Text & Val.ToString & " "
        ' Next
    End Sub
    Private Sub UpdateTextBoxValues()

        For Each i As Fragment In all_fragments
            For Each j As TextBox In i.text_box
                Dim x As String = j.Text
                If j.InvokeRequired Then
                    j.Invoke(Sub() j.Text = x)
                End If
            Next
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
                textBox.Location = New Point(140 + (i * 20), 130) ' Adjust the location as needed
                textBox.Size = New Size(20, 20) ' Adjust the size as needed
                textBox.BorderStyle = BorderStyle.FixedSingle
                container.Controls.Add(textBox)
                text_boxes.Add(textBox)
            Next
            init_flag = 0
        Else
            MessageBox.Show("Reset first before creating new array", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub merge_step()
        Dim x As Integer = 0
        For i As Integer = 0 To input_array.Count - 2
            If input_array(i) > input_array(i + 1) Then
                x = 1
                Exit For
            End If
        Next
        If x = 0 And key_int = -1 Then
            MessageBox.Show("Sorted")
        End If
        If step_j < input_array.Count Then
            If start = 1 Then
                key_int = input_array(step_j)

                step_i = step_j - 1
                start = 0
            End If
            'Integer.TryParse(key, key_int)
            If (step_i >= 0) And (input_array(If(step_i = -1, 0, step_i)) > key_int) Then

                input_array(step_i + 1) = input_array(step_i)
                step_i = step_i - 1

            Else
                input_array(step_i + 1) = key_int
                step_j = step_j + 1
                start = 1
                key_int = -1
            End If
        End If
        merge_sort_size_label.Text = key_int.ToString & " i= " & step_i.ToString & " j= " & step_j.ToString & " St= " & start.ToString & " x= " & x.ToString
        UpdateTextBoxValues()
    End Sub
    Private Sub merge_sort_feed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles merge_sort_feed.Click
        If init_flag = 0 Then
            textboxParse()
            'main_fragment.array.AddRange(input_array)
            main_fragment.set_coordinates(x_par, y_par)
            all_fragments.Add(main_fragment)
            init_flag = -1
        End If

    End Sub

    Private Sub merge_sort_step_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles merge_sort_step.Click




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
            main_fragment.set_coordinates(x_par, y_par)
            all_fragments.Add(main_fragment)
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





        '(((((((((((((((((((((((((((((())))))))))))))))))))))))))))))))))))))))))))))))))))))))
        If all_textbox_values_valid And all_textbox_filled Then
            If init_flag = -1 And (all_fragments(0).sorted = True Or all_fragments(0).array.Count = 1) Then
                MessageBox.Show("SORTED")
            Else


                If merge_active = 0 Then
                    splitSubArray()
                End If
                drawFragments(Panel1)
                mergeSortedSubArray()
            End If
        End If

    End Sub

    Private Sub merge_sort_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles merge_sort_create.Click

        If init_flag = 1 Then
            If String.IsNullOrEmpty(merge_sort_size.Text) = False Then
                If Integer.TryParse(merge_sort_size.Text, array_size) = False Then
                    MessageBox.Show("Enter a positive numeric value for size")
                Else
                    If array_size <= 0 Then
                        MessageBox.Show("Enter a positive value for size")

                    ElseIf array_size = 1 Then
                        MessageBox.Show("Any array of size 1 is always sorted")
                    ElseIf array_size > 16 Then
                        MessageBox.Show("Enter size <= 16 for visualisation")
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

        ''()()()()()()()()())))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
        'array_size = Integer.Parse(merge_sort_size.Text)
        '''' text_boxes.dispose()
        'CreateDynamicTextBoxArray(array_size, Panel1)
        ''''merge_sort_size_label.Text = "Size " & (main_fragment.array.Count).ToString
    End Sub

    Private Sub merge_sort_fill_random_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles merge_sort_fill_random.Click
        Dim rand As New Random()
        Dim j As Integer
        array_size = Integer.Parse(merge_sort_size.Text)
        'main_fragment = New Fragment(0, -1, 0, False, False)
        'all_fragments = New List(Of Fragment)
        If init_flag = 0 Then
            For i As Integer = 0 To array_size - 1
                j = rand.Next(100)
                'main_fragment.array.Add(j)
                text_boxes(i).Text = j.ToString
            Next
            'main_fragment.set_coordinates(x_par, y_par)
            'all_fragments.Add(main_fragment)
            'drawFragments(Panel1)
            all_textbox_filled = True
            all_textbox_values_valid = True
        End If
    End Sub

    Private Sub merge_sort_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mereg_sort_reset.Click
        init_flag = 1

        array_size = 5

        step_index = 0
        step_i = 0
        step_j = 1
        wait_flag = 0

        key = "A"
        start = 1
        key_int = -1

        x_sepr = 15
        y_sepr = 20
        x_par = 140
        y_par = 130
        x_box = 20
        y_box = 20
        main_fragment = New Fragment(0, -1, 0, False, False)
        all_fragments = New List(Of Fragment)()
        text_boxes = New List(Of TextBox)
        max_hierarchy = 0
        fragments_count = 1

        mergeFragmentsIndex = New List(Of Integer)()
        leftPointer = 0
        rightPointer = 0
        counter = 0
        no_steps = 0
        parent_index = 0
        zz = 0
        merge_active = 0
        drawFragments(Panel1)
    End Sub

    Private Sub LoadQuizQuestions()
        Dim connectionString As String = "server=localhost;userid=root;password=pwd;database=swe_assign2"
        Dim query As String = "SELECT serial_no, question, optionA, optionB, optionC, optionD, Correct_Option FROM merge_sort"
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
    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Dim query As String = "UPDATE users SET mergesort_progress = GREATEST(IFNULL(array_progress, 0), @correctAnswers) WHERE username = @user"
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
        '.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowQuizSection()

    End Sub

    Private Sub merge_sort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowQuizSection()
        UpdateQuestionNumberDisplay()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim Profile As New profile()
        Profile.StartPosition = FormStartPosition.Manual
        Profile.Location = Me.Location ' Set the location of the new form to the current form's location
        Profile.Show()
        Profile.PreviousForm = Me
        Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If userAnswers.Count = questions.Count Then
            ShowQuizResults()
        Else
            MessageBox.Show("Please answer all questions before submitting. Currently " & userAnswers.Count & " answered out of " & questions.Count)
        End If
    End Sub

    Private Sub linked_list_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sorting.StartPosition = FormStartPosition.Manual
        sorting.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        sorting.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        main_menu.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        main_menu.Show()
    End Sub
End Class