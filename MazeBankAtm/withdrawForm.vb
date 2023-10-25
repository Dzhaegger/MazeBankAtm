Public Class withdrawForm

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
    'Botnes para retirar diferentes cantidades de dinero
    Private Sub depositButton50_Click(sender As Object, e As EventArgs) Handles btnwithdraw50.Click
        Dim depositAmount As Decimal = -10
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton100_Click(sender As Object, e As EventArgs) Handles btnwithdraw100.Click
        Dim depositAmount As Decimal = -25
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton500_Click(sender As Object, e As EventArgs) Handles btnwithdraw500.Click
        Dim depositAmount As Decimal = -100
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton1000_Click(sender As Object, e As EventArgs) Handles btnwithdraw1000.Click
        Dim depositAmount As Decimal = -500
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton2500_Click(sender As Object, e As EventArgs) Handles btnwithdraw2500.Click
        Dim depositAmount As Decimal = -1000
        UpdateBalance(depositAmount)
    End Sub

    Private Sub depositButton10000_Click(sender As Object, e As EventArgs) Handles btnwithdraw10000.Click
        Dim depositAmount As Decimal = -2500
        UpdateBalance(depositAmount)
    End Sub
    Private Sub btnConfirmTransaction_Click(sender As Object, e As EventArgs) Handles btnConfirmTransaction.Click
        CurrentBalance += depositAmountConfirmation
        Me.Close()
        End Sub
        Public Sub depositForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            If Application.OpenForms.OfType(Of MainMenu).Any() Then
                Dim mainMenuForm As MainMenu = Application.OpenForms.OfType(Of MainMenu).First()
                mainMenuForm.UpdateBalanceLabel()
            End If
        End Sub
    Private Sub UpdateBalance(depositAmount As Decimal)
        ' Verificar si el saldo no se vuelve negativo
        If MainMenu.Balance + depositAmount < 0 Then
            MessageBox.Show("You cannot withdraw this amount of money.")
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

    'Para que no permita poner letras u otros carateres
    Private Sub txtcustomcash_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


End Class
