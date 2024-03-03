Public Class sorting

    Private Sub sorting_FormClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        main_menu.Show()
        Me.Hide() ' Hide the current form
    End Sub


    Private Sub sorting_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        'MyBase.Close()
        main_menu.Show()
        Me.Hide() ' Hide the current form

    End Sub

    Private Sub sorting_insertion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertion.Click
        Dim Insertion_sort As New insertion_sort()
        Insertion_sort.StartPosition = FormStartPosition.Manual
        Insertion_sort.Location = Me.Location ' Set the location of the new form to the current form's location
        Insertion_sort.Show()
        Me.Hide() ' Hide the current form
    End Sub

    Private Sub sorting_bubble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bubble.Click
        Dim Bubble_sort As New bubble_sort()
        Bubble_sort.StartPosition = FormStartPosition.Manual
        Bubble_sort.Location = Me.Location ' Set the location of the new form to the current form's location
        Bubble_sort.Show()
        Me.Hide() ' Hide the current form

    End Sub

    Private Sub sorting_merge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles merge.Click
        Dim Merge_sort As New merge_sort()
        Merge_sort.StartPosition = FormStartPosition.Manual
        Merge_sort.Location = Me.Location ' Set the location of the new form to the current form's location
        Merge_sort.Show()
        Me.Hide() ' Hide the current form
    End Sub
    Private Sub sorting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim Merge_sort As New profile()
        Merge_sort.PreviousForm = Me
        Merge_sort.StartPosition = FormStartPosition.Manual
        Merge_sort.Location = Me.Location ' Set the location of the new form to the current form's location

        Merge_sort.Show()
        Me.Hide() ' Hide the current form
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class