Imports MySql.Data.MySqlClient
Imports System.Text

Public Class profile

    ' Property to hold the reference of the previous form
    Public Property PreviousForm As Form

    ' MySQL connection and command objects
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    ' Form load event handler
    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to MySQL database
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=pwd;database=swe_assign2"

        Try
            MysqlConn.Open()

            ' Query to select user information based on the current username
            Dim Query As String = "SELECT username, name FROM users WHERE username = '" & GlobalVariables.global_user & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim READER As MySqlDataReader = COMMAND.ExecuteReader

            ' Check if there are any rows returned
            If READER.Read() Then
                ' Display user information
                UserName2.Text = READER.GetString("name")
                Username.Text = "@" & GlobalVariables.global_user
            End If

            READER.Close()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()

            ' Query to retrieve progress values from the database
            Dim query As String = "SELECT array_progress, stack_progress, linkedlist_progress, queue_progress, linearsearch_progress, binarysearch_progress, bubblesort_progress, insertionsort_progress, mergesort_progress FROM users WHERE username = '" & GlobalVariables.global_user & "'"
            COMMAND = New MySqlCommand(query, MysqlConn)
            Dim READER As MySqlDataReader = COMMAND.ExecuteReader

            Dim linear_search As Integer = 0
            Dim binary_search As Integer = 0
            Dim bubble_sort As Integer = 0
            Dim insertion_sort As Integer = 0
            Dim merge_sort As Integer = 0

            If READER.Read() Then
                ' Check if the value is DBNull before converting
                If Not READER.IsDBNull(READER.GetOrdinal("array_progress")) Then
                    ArrayProgress.Value = Convert.ToInt32(READER("array_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("stack_progress")) Then
                    StackProgress.Value = Convert.ToInt32(READER("stack_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("linkedlist_progress")) Then
                    LLProgress.Value = Convert.ToInt32(READER("linkedlist_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("queue_progress")) Then
                    QueueProgress.Value = Convert.ToInt32(READER("queue_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("linearsearch_progress")) Then
                    linear_search = Convert.ToInt32(READER("linearsearch_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("binarysearch_progress")) Then
                    binary_search = Convert.ToInt32(READER("binarysearch_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("bubblesort_progress")) Then
                    bubble_sort = Convert.ToInt32(READER("bubblesort_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("insertionsort_progress")) Then
                    insertion_sort = Convert.ToInt32(READER("insertionsort_progress"))
                End If
                If Not READER.IsDBNull(READER.GetOrdinal("mergesort_progress")) Then
                    merge_sort = Convert.ToInt32(READER("mergesort_progress"))
                End If
                ' Calculate search progress as average of linear and binary search
                SearchProgress.Value = (binary_search + linear_search) / 2
                ' Calculate sorting progress as average of bubble, insertion, and merge sort
                SortingProgress.Value = (bubble_sort + insertion_sort + merge_sort) / 3
            End If

            READER.Close()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    ' Back button click event handler
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If PreviousForm IsNot Nothing Then
            ' Show the previous form and hide the current form
            PreviousForm.StartPosition = FormStartPosition.Manual
            PreviousForm.Location = Me.Location
            PreviousForm.Show()
            Hide()
        Else
            ' If there is no previous form, go back to the main menu
            Dim mainMenuForm As New main_menu()
            mainMenuForm.StartPosition = FormStartPosition.Manual
            mainMenuForm.Location = Me.Location
            mainMenuForm.Show()
            Hide()
        End If
    End Sub

    ' Logout button click event handler
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Clear the current user's username
        GlobalVariables.global_user = ""
        ' Show the home page
        Dim homePage As New home_page()
        homePage.StartPosition = FormStartPosition.Manual
        homePage.Location = Me.Location
        homePage.Show()
        Hide()
    End Sub

End Class
