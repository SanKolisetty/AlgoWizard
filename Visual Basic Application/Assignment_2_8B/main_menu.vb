Imports System.Diagnostics

Public Class main_menu

    ' Define a flag to track the current category
    Private currentCategory As String = ""

    ' Method to show buttons based on the selected category
    Private Const AnimationDuration As Integer = 300 ' milliseconds
    Private Const AnimationSteps As Integer = 20 ' number of steps for animation
    Private Const DropDownDistance As Integer = 30 ' distance to drop down, in pixels

    Private buttonsToDropDown As New Queue(Of Button)()
    Private originalTopMap As New Dictionary(Of Button, Integer)()


    Private Sub ShowCategoryButtons(ByVal category As String)
        ' Hide all buttons first
        HideAllButtons()

        ' Show buttons based on the selected category
        Select Case category
            Case "Data Structures"
                buttonsToDropDown.Enqueue(main_array)
                buttonsToDropDown.Enqueue(main_stack)
                buttonsToDropDown.Enqueue(main_queue)
                buttonsToDropDown.Enqueue(main_linkedlist)
            Case "Algorithms"
                buttonsToDropDown.Enqueue(main_searching)
                buttonsToDropDown.Enqueue(main_sorting)
        End Select

        StartDropDownAnimation()
    End Sub

    Private Sub HideAllButtons()
        main_array.Visible = False
        main_stack.Visible = False
        main_queue.Visible = False
        main_linkedlist.Visible = False
        main_searching.Visible = False
        main_sorting.Visible = False
    End Sub

    Private Sub StartDropDownAnimation()
        If buttonsToDropDown.Count > 0 Then
            Dim nextButton As Button = buttonsToDropDown.Dequeue()
            If Not originalTopMap.ContainsKey(nextButton) Then
                originalTopMap.Add(nextButton, nextButton.Top)
            End If
            nextButton.Top -= DropDownDistance
            nextButton.Visible = True
            AnimateDropDown(nextButton)
        End If
    End Sub

    Private Sub AnimateDropDown(ByVal button As Button)
        Dim originalTop As Integer = originalTopMap(button)
        Dim stepSize As Single = DropDownDistance / AnimationSteps

        Dim timer As New Timer()
        AddHandler timer.Tick, Sub(sender, e)
                                   button.Top += CInt(stepSize)
                                   If button.Top >= originalTop Then
                                       button.Top = originalTop ' Ensure it reaches original position
                                       timer.Stop()
                                       StartDropDownAnimation() ' Start animation for next button
                                   End If
                               End Sub
        timer.Interval = AnimationDuration / AnimationSteps
        timer.Start()
    End Sub

    ' Event handler for Data Structures button
    Private Sub main_data_structures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_data_structures.Click
        currentCategory = "Data Structures"
        ShowCategoryButtons(currentCategory)
    End Sub


    ' Event handler for Algorithms button
    Private Sub main_algorithms_Click(ByVal sender As Object, ByVal e As EventArgs) Handles main_algorithms.Click
        currentCategory = "Algorithms"
        ShowCategoryButtons(currentCategory)
    End Sub
    'Private Sub main_cross_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
    '    Dim homePageForm As New home_page()
    '    homePageForm.StartPosition = FormStartPosition.Manual
    '    homePageForm.Location = Me.Location ' Set the location of the new form to the current form's location
    '    homePageForm.Show()
    '    Me.Hide()
    'End Sub
    ' Event handler for Close button
    Private Sub main_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_close.Click
        Dim homePageForm As New home_page()
        homePageForm.StartPosition = FormStartPosition.Manual
        homePageForm.Location = Me.Location ' Set the location of the new form to the current form's location
        homePageForm.Show()
        Me.Hide()
    End Sub
    ' Event handler for Searching button
    Private Sub main_searching_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_searching.Click
        Dim Searching As New searching()
        Searching.StartPosition = FormStartPosition.Manual
        Searching.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        Searching.Show()
    End Sub

    ' Event handler for Sorting button
    Private Sub main_sorting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_sorting.Click
        Dim Sorting As New sorting()
        Sorting.StartPosition = FormStartPosition.Manual
        Sorting.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        Sorting.Show()
    End Sub

    ' Event handler for Array button
    Private Sub main_array_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_array.Click
        Dim Array As New array()
        Array.StartPosition = FormStartPosition.Manual
        Array.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        Array.Show()
    End Sub

    ' Event handler for Stack button
    Private Sub main_stack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_stack.Click
        Dim Stack As New stack()
        Stack.StartPosition = FormStartPosition.Manual
        Stack.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        Stack.Show()
    End Sub

    ' Event handler for Queue button
    Private Sub main_queue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_queue.Click
        Dim Queue As New queue()
        Queue.StartPosition = FormStartPosition.Manual
        Queue.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        Queue.Show()
    End Sub

    ' Event handler for Linked List button
    Private Sub main_linkedlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main_linkedlist.Click
        Dim Queue As New linked_list()
        linked_list.StartPosition = FormStartPosition.Manual
        linked_list.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        linked_list.Show()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim url As String = "https://www.sololearn.com/en/compiler-playground"
        ' Open the URL in the default web browser
        Process.Start(url)
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim mainMenuForm As New profile()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Me.Hide()
    End Sub
End Class
