Public Class searching

    Private Sub searching_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide()
        main_menu.Show()

    End Sub

    Private Sub searching_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        main_menu.StartPosition = FormStartPosition.Manual
        main_menu.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        main_menu.Show()
    End Sub

    Private Sub searching_linear_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searching_linear_search.Click
        Dim Linear_search As New linear_search()
        Linear_search.StartPosition = FormStartPosition.Manual
        Linear_search.Location = Me.Location ' Set the location of the new form to the current form's location
        Hide() ' Hide the current form
        Linear_search.Show()
    End Sub

    Private Sub searching_binary_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searching_binary_search.Click
        Dim Binary_search As New binary_search()
        Binary_search.StartPosition = FormStartPosition.Manual
        Binary_search.Location = Me.Location ' Set the location of the new form to the current form's location

        Binary_search.Show()
        Me.Hide() ' Hide the current form
    End Sub
    Private Sub sorting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim Binary_search As New profile()
        Binary_search.PreviousForm = Me
        Binary_search.StartPosition = FormStartPosition.Manual
        Binary_search.Location = Me.Location ' Set the location of the new form to the current form's location

        Binary_search.Show()
        Me.Hide() ' Hide the current form
    End Sub
End Class