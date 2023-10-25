Public Class MainMenu

    ' Variable pública para almacenar el saldo de la cuenta
    Public Shared Balance As Decimal = 0

    ' Propiedad para almacenar el nombre de usuario que ha iniciado sesión
    Public Property LoggedInUser As String

    ' Este método se ejecuta cuando se carga la ventana principal
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el nombre del usuario en un label
        lbluser.Text = LoggedInUser
        ' Mostrar el saldo actual llamando al método correspondiente
        UpdateBalanceLabel()
    End Sub

    ' Este método se ejecuta cuando se hace clic en el botón de depósito
    Private Sub btndeposit_Click(sender As Object, e As EventArgs) Handles btndepositcash.Click

        Dim initialBalance As Decimal = 0

        Dim depositFormInstance As New depositForm(initialBalance, LoggedInUser)
        depositFormInstance.ShowDialog()

        UpdateBalanceLabel()
    End Sub

    'Minimizar
    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Cerrar
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    ' Este método actualiza el texto de la etiqueta de saldo
    Public Sub UpdateBalanceLabel()
        balanceLabel.Text = $"Account Balance: ${Balance:N2}"
    End Sub

    'Cerrar sesión
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        ' Abrir una nueva instancia de Form2 
        Dim form2 As New Form2()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub btnwithdraw_Click(sender As Object, e As EventArgs) Handles btnwithdraw.Click
        Dim initialBalance As Decimal = 0
        Dim depositFormInstance As New withdrawForm(initialBalance, LoggedInUser)
        depositFormInstance.ShowDialog()
        UpdateBalanceLabel()
    End Sub

    Private Sub lbluser_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub
End Class
