Imports System.Threading

Public Class LoginForm
    Public Shared userList As New List(Of User)()
    Private loginAttempts As Integer = 0
    Private ReadOnly balance As Decimal
    Private Const maxLoginAttempts As Integer = 3

    Public Sub loginButton_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtuser.Text
        Dim accountnumber As String = txtaccountnumber.Text
        Dim password As String = txtpass.Text

        ' Lógica de validación del inicio de sesión con límite de intentos
        If ValidateLogin(username, accountnumber, password) Then
            ' Restablecer el contador de intentos si el inicio de sesión es exitoso
            loginAttempts = 0
            MessageBox.Show("Successful login.")
            Dim mainMenu As New MainMenu()
            mainMenu.LoggedInUser = username
            mainMenu.ShowDialog()
            Me.Close()
        Else
            ' Incrementar el contador de intentos si el inicio de sesión falla
            loginAttempts += 1
            If loginAttempts >= maxLoginAttempts Then
                ' Bloquear temporalmente la cuenta si se supera el límite de intentos
                MessageBox.Show("Too many failed attempts. The account has been temporarily blocked for security reasons.")
                txtuser.Enabled = False
                txtaccountnumber.Enabled = False
                txtpass.Enabled = False
                btnlogin.Enabled = False
                btncerrar.Enabled = True

                ' Bloquear temporalmente la cuenta por 10 segundos
                Thread.Sleep(10000) ' Bloquea la ejecución durante 10 segundos (10000 milisegundos)
                txtuser.Enabled = True
                txtaccountnumber.Enabled = True
                txtpass.Enabled = True
                btnlogin.Enabled = True
                txtuser.Text = ""
                txtaccountnumber.Text = ""
                txtpass.Text = ""
            Else
                MessageBox.Show("Username or password incorrect. Try again.")
            End If
        End If
    End Sub

    Private Function ValidateLogin(username As String, accountnumber As String, password As String) As Boolean
        ' Lógica de validación del inicio de sesión aquí
        Dim user = Form2.userList.FirstOrDefault(Function(u) u.Accountnumber = accountnumber And u.Username = username AndAlso u.Password = password)
        If user IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblpin.Click

    End Sub
End Class
