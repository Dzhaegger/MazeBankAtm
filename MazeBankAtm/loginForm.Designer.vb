<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lblpin = New System.Windows.Forms.Label()
        Me.lblacc = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtaccountnumber = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 77)
        Me.Panel1.TabIndex = 2
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.mazelogo
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Location = New System.Drawing.Point(0, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(353, 77)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Red
        Me.btnlogin.Font = New System.Drawing.Font("BankGothic Md BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.Control
        Me.btnlogin.Location = New System.Drawing.Point(12, 329)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(329, 85)
        Me.btnlogin.TabIndex = 1
        Me.btnlogin.Text = "Done"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'lblpin
        '
        Me.lblpin.AutoSize = True
        Me.lblpin.BackColor = System.Drawing.Color.Red
        Me.lblpin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblpin.Font = New System.Drawing.Font("BankGothic Md BT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpin.ForeColor = System.Drawing.SystemColors.Control
        Me.lblpin.Location = New System.Drawing.Point(12, 219)
        Me.lblpin.Name = "lblpin"
        Me.lblpin.Size = New System.Drawing.Size(137, 22)
        Me.lblpin.TabIndex = 9
        Me.lblpin.Text = "Password"
        '
        'lblacc
        '
        Me.lblacc.AutoSize = True
        Me.lblacc.BackColor = System.Drawing.Color.Red
        Me.lblacc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblacc.Font = New System.Drawing.Font("BankGothic Md BT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc.ForeColor = System.Drawing.SystemColors.Control
        Me.lblacc.Location = New System.Drawing.Point(12, 106)
        Me.lblacc.Name = "lblacc"
        Me.lblacc.Size = New System.Drawing.Size(221, 22)
        Me.lblacc.TabIndex = 8
        Me.lblacc.Text = "Account Number"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(12, 136)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(329, 57)
        Me.txtpass.TabIndex = 7
        '
        'txtaccountnumber
        '
        Me.txtaccountnumber.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccountnumber.Location = New System.Drawing.Point(12, 249)
        Me.txtaccountnumber.Multiline = True
        Me.txtaccountnumber.Name = "txtaccountnumber"
        Me.txtaccountnumber.Size = New System.Drawing.Size(329, 57)
        Me.txtaccountnumber.TabIndex = 6
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(239, 217)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 27)
        Me.txtuser.TabIndex = 10
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Red
        Me.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblname.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.SystemColors.Control
        Me.lblname.Location = New System.Drawing.Point(239, 202)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(73, 12)
        Me.lblname.TabIndex = 11
        Me.lblname.Text = "Username"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.ClientSize = New System.Drawing.Size(353, 439)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lblpin)
        Me.Controls.Add(Me.lblacc)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtaccountnumber)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginForm"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnlogin As Button
    Friend WithEvents lblpin As Label
    Friend WithEvents lblacc As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtaccountnumber As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents btncerrar As Button
End Class
