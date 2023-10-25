Imports MazeBankAtm.User ' Importa el espacio de nombres "User" del proyecto MazeBankAtm

Imports Microsoft.VisualBasic.ApplicationServices ' Importa el espacio de nombres "Microsoft.VisualBasic.ApplicationServices"

Public Class Form2

    Public Shared userList As New List(Of User) ' Crea una lista de usuarios compartida para el formulario

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Código que se ejecuta cuando se carga el formulario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        LoginForm.ShowDialog() ' Abre el formulario de inicio de sesión
    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        Dim registerForm As New registerForm() ' Crea una instancia del formulario de registro
        registerForm.ShowDialog() ' Muestra el formulario de registro
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close() ' Cierra el formulario actual
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized ' Minimiza el formulario actual
    End Sub

End Class
