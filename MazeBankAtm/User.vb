'Clase para guardar las credenciales de cada usuario
Public Class User
    Public Property Username As String
    Public Property Password As String
    Public Property Accountnumber As String

    Public Sub New(username As String, password As String, accountnumber As String)
        Me.Username = username
        Me.Password = password
        Me.Accountnumber = accountnumber

    End Sub
End Class
