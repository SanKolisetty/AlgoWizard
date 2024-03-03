Public Class home_page

    'Private Sub Button1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
    'Button1.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#294B29")
    'End Sub

    ' This event handler is triggered when Button1 is clicked
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a new instance of the sign_up form
        Dim mainMenuForm As New sign_up()
        ' Set the position of the new form to be the same as the current form
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        ' Show the new form and hide the current form
        mainMenuForm.Show()
        Me.Hide()
    End Sub

    'Private Sub sign_up_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
    '    ' Make sure the application exits properly
    '    Application.Exit()
    'End Sub
    'Private Sub Button2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
    'Button2.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#294B29")
    'End Sub

    ' This event handler is triggered when Button2 is clicked
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Exit the application
        Application.Exit()
    End Sub

    ' This event handler is triggered when Button3 is clicked
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Create a new instance of the log_in form
        Dim mainMenuForm As New log_in()
        ' Set the position of the new form to be the same as the current form
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        ' Show the new form and hide the current form
        mainMenuForm.Show()
        Me.Hide()
    End Sub

End Class