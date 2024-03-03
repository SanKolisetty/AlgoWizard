Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class log_in

    ' Declaration of MySqlConnection and MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    ' Function to hash a string using SHA512 algorithm
    Private Function hash512(ByVal txt As String)
        Dim a() As Byte = Encoding.UTF8.GetBytes(txt)
        Dim b As Byte()
        Dim c As New SHA512Managed
        b = c.ComputeHash(a)
        Dim d As String = Convert.ToBase64String(b)
        hash512 = d
    End Function

    ' Event handler for Button2 click event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Redirect to sign_up form
        Dim mainMenuForm As New sign_up()
        mainMenuForm.StartPosition = FormStartPosition.Manual
        mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
        mainMenuForm.Show()
        Me.Hide()
    End Sub

    ' Event handler for Button1 click event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Attempt MySQL connection and login
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=pwd;database=swe_assign2"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Dim hashed_pw As String
            hashed_pw = hash512(Password.Text)
            Query = "select * from swe_assign2.users where username='" & Username.Text & "' and password='" & hashed_pw & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                ' Redirect to main_menu form
                Dim mainMenuForm As New main_menu()
                mainMenuForm.StartPosition = FormStartPosition.Manual
                mainMenuForm.Location = Me.Location ' Set the location of the new form to the current form's location
                'mainMenuForm.current_username = Username.Text
                GlobalVariables.global_user = Username.Text
                mainMenuForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username and Password are not correct")
            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    '' Event handler for log_in_cross click event
    'Private Sub log_in_cross_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
    '    ' Redirect to home_page form
    '    Dim homePageForm As New home_page()
    '    homePageForm.StartPosition = FormStartPosition.Manual
    '    homePageForm.Location = Me.Location ' Set the location of the new form to the current form's location
    '    homePageForm.Show()
    '    Me.Hide()
    'End Sub

    ' Event handler for log_in form load event
    Private Sub log_in_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Check the CheckBox1 by default
        CheckBox1.Checked = True
    End Sub

    ' Event handler for Username text box enter event
    Private Sub Username_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.Enter
        If Username.Text = "-> Username" Then
            Username.Text = ""
        End If
    End Sub

    ' Event handler for Password text box enter event
    Private Sub Password_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.Enter
        If Password.Text = "-> Password" Then
            Password.Text = ""
        End If
    End Sub

    ' Event handler for Username text box leave event
    Private Sub Username_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.Leave
        If Username.Text = "" Then
            Username.Text = "-> Username"
        End If
    End Sub

    ' Event handler for Password text box leave event
    Private Sub Password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.Leave
        If Password.Text = "" Then
            Password.Text = "-> Password"
        End If
    End Sub

    ' Event handler for CheckBox1 checked changed event
    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Password.PasswordChar = ControlChars.NullChar ' Show raw password
        Else
            Password.PasswordChar = "*"c ' Show asterisks
        End If
    End Sub

    ' Event handler for Button3 click event
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Exit the application
        Application.Exit()
    End Sub


End Class