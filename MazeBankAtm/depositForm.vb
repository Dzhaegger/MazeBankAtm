Public Class depositForm
    Private depositAmountConfirmation As Decimal = 0
    Public Property LoggedInUser As String
    Public Property CurrentBalance As Decimal ' Debes tener acceso al saldo actual del usuario desde el formulario

    Public Sub New(initialBalance As Decimal, loggedInUser As String)
        ' Inicializar componentes y otras configuraciones
        InitializeComponent()
        CurrentBalance = initialBalance
        loggedInUser = loggedInUser
        lbluser.Text = loggedInUser
        ' Utiliza la propiedad LoggedInUser en el formulario según sea necesario
        UpdateBalanceLabel()
    End Sub
    'Botones para depositar diferentes cantidades de dinero
    Private Sub depositButton50_Click(sender As Object, e As EventArgs) Handles btndeposit50.Click
        Dim depositAmount As Decimal = 50
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton100_Click(sender As Object, e As EventArgs) Handles btndeposit100.Click
        Dim depositAmount As Decimal = 100
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton500_Click(sender As Object, e As EventArgs) Handles btndeposit500.Click
        Dim depositAmount As Decimal = 500
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton1000_Click(sender As Object, e As EventArgs) Handles btndeposit1000.Click
        Dim depositAmount As Decimal = 1000
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton2500_Click(sender As Object, e As EventArgs) Handles btndeposit2500.Click
        Dim depositAmount As Decimal = 2500
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton10000_Click(sender As Object, e As EventArgs) Handles btndeposit10000.Click
        Dim depositAmount As Decimal = 10000
        UpdateBalance(depositAmount)
    End Sub

    'Validacion que no permite depositar más de 10.000$
    Private Sub btnConfirmTransaction_Click(sender As Object, e As EventArgs) Handles btnConfirmTransaction.Click
        Dim customAmount As Decimal
        If Decimal.TryParse(txtcustomcash.Text, customAmount) Then
            If customAmount <= 10000 Then
                UpdateBalance(customAmount)
                CurrentBalance += customAmount
            Else
                MessageBox.Show("The deposit amount cannot be more than $10,000.")
            End If
        Else

        End If
        Me.Close()
    End Sub
    Public Sub depositForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Application.OpenForms.OfType(Of MainMenu).Any() Then
            Dim mainMenuForm As MainMenu = Application.OpenForms.OfType(Of MainMenu).First()
            mainMenuForm.UpdateBalanceLabel()
        End If
    End Sub
    Private Sub UpdateBalance(depositAmount As Decimal)
        If MainMenu.Balance + depositAmount > 20000 Then
            MessageBox.Show("You cannot deposit an amount higher than $20.000 per day.")
            Return
        End If
        ' Actualizar el saldo con la cantidad depositada
        MainMenu.Balance += depositAmount
        depositAmountConfirmation = depositAmount

        UpdateBalanceLabel()

    End Sub

    Private Sub UpdateBalanceLabel()
        balanceLabel.Text = $"Account Balance: ${MainMenu.Balance:N2}"

    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub balanceLabel_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcustomcash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcustomcash.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub lbluser_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub
End Class
