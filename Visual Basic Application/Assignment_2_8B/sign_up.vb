Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class sign_up
    ' Declaration of MySqlConnection and MySqlCommand for database operations
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    ' Function to hash a string using SHA512 algorithm
    Private Function hash512(ByVal txt As String)
        ' Convert the input string to a byte array
        Dim a() As Byte = Encoding.UTF8.GetBytes(txt)
        Dim b As Byte()
        Dim c As New SHA512Managed
        ' Compute the hash of the byte array
        b = c.ComputeHash(a)
        ' Convert the hashed byte array to a base64 string
        Dim d As String = Convert.ToBase64String(b)
        ' Return the hashed string
        hash512 = d
    End Function

    ' Event handler for closing the sign-up form
    Private Sub sign_up_cross_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        ' Redirect to the home_page form when the sign-up form is closed
        Dim homePageForm As New home_page()
        homePageForm.StartPosition = FormStartPosition.Manual
        homePageForm.Location = Me.Location ' Set the location of the new form to the current form's location
        homePageForm.Show()
        Me.Hide()
    End Sub

    ' Event handler for the Sign Up button click event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If User_Name.Text = "" Then
            MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Username.Text = "" Then
            MessageBox.Show("Username cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Password.Text = "" Then
            MessageBox.Show("Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Password2.Text = "" Then
            MessageBox.Show("Password2 cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            ' Attempt MySQL connection and user registration
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=pwd;database=swe_assign2"

            ' Check if the passwords match before proceeding with the registration
            If Password.Text <> Password2.Text Then
                MessageBox.Show("Passwords do not match")
            Else
                Dim READER As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Dim hashed_pw As String
                    ' Hash the password before storing it in the database
                    hashed_pw = hash512(Password.Text)
                    ' SQL query to insert user data into the database
                    Query = "insert into swe_assign2.users (name,username,password) values ('" & User_Name.Text & "','" & Username.Text & "','" & hashed_pw & "')"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    ' Display a success message upon successful registration
                    MessageBox.Show("Successfully registered")
                    ' Set the global username variable for future reference
                    GlobalVariables.global_user = Username.Text
                    ' Redirect to the log_in form after successful registration
                    Dim mainMenuForm As New log_in()
                    mainMenuForm.StartPosition = FormStartPosition.Manual
                    mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
                    mainMenuForm.Show()
                    Me.Hide()

                    MysqlConn.Close()

                Catch ex As Exception
                    ' Display an error message if an exception occurs during registration
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            End If
        End If

    End Sub

    ' Event handler for the Back to Login button click event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Redirect to the log_in form when the Back to Login button is clicked
        Dim mainMenuForm As New log_in()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Me.Hide()
    End Sub


    Private Sub User_Name_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.Enter, User_Name.Enter, Password2.Enter, Password.Enter
        If User_Name.Text = "-> Username" Then
            User_Name.Text = ""
        End If
    End Sub

    Private Sub sign_up_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        User_Name.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Exit the application when the Exit button is clicked
        Application.Exit()
    End Sub
End Class
