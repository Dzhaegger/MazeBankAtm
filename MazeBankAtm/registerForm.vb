Imports System.Text.RegularExpressions

Public Class registerForm
    ' Propiedad que indica si el registro fue exitoso
    Public Property RegisterSuccessful As Boolean = False

    ' Este método se ejecuta al hacer clic en el botón de registro
    Private Sub btnregist_Click(sender As Object, e As EventArgs) Handles btnregist.Click
        ' Obtener los valores de los campos de texto
        Dim username As String = txtuser.Text
        Dim accountnumber As String = txtaccountnumber.Text
        Dim password As String = txtpass.Text

        ' Verificar si el usuario ya está en la lista
        Dim existingUser = Form2.userList.FirstOrDefault(Function(u) u.Username = username)

        ' Mostrar un mensaje si el usuario ya está registrado y salir del método
        If existingUser IsNot Nothing Then
            MessageBox.Show("This user is already registered. Please choose another username.")
            Return
        End If

        ' Validar el número de cuenta
        If Not Regex.IsMatch(accountnumber, "^\d{8}$") Then
            MessageBox.Show("The account number must contain exactly 8 numerical digits.")
            Return
        End If

        ' Validar la contraseña
        If Not Regex.IsMatch(password, "^\d{4}$") Then
            MessageBox.Show("The password must contain exactly 4 numerical digits.")
            Return
        End If

        ' Si el usuario no existe y el número de cuenta y la contraseña tienen el formato correcto, agregarlo a la lista
        Dim newUser As New User(username, accountnumber, password)
        Form2.userList.Add(newUser) ' Asumiendo que userList es pública en Form2.
        RegisterSuccessful = True
        MainMenu.Balance = 0
        Me.Close()
    End Sub

    ' Métodos adicionales sin implementación específica
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnregist.Click

    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub lblname_Click(sender As Object, e As EventArgs) Handles lblname.Click

    End Sub
End Class
