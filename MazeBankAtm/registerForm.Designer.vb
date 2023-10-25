<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnregist = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtaccountnumber = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblaccount = New System.Windows.Forms.Label()
        Me.lblpin = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnregist
        '
        Me.btnregist.BackColor = System.Drawing.Color.Red
        Me.btnregist.Font = New System.Drawing.Font("BankGothic Md BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregist.ForeColor = System.Drawing.SystemColors.Control
        Me.btnregist.Location = New System.Drawing.Point(12, 329)
        Me.btnregist.Name = "btnregist"
        Me.btnregist.Size = New System.Drawing.Size(329, 85)
        Me.btnregist.TabIndex = 0
        Me.btnregist.Text = "Done"
        Me.btnregist.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 1
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
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(239, 217)
        Me.txtuser.Multiline = True
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 24)
        Me.txtuser.TabIndex = 2
        '
        'txtaccountnumber
        '
        Me.txtaccountnumber.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccountnumber.Location = New System.Drawing.Point(12, 136)
        Me.txtaccountnumber.Multiline = True
        Me.txtaccountnumber.Name = "txtaccountnumber"
        Me.txtaccountnumber.Size = New System.Drawing.Size(329, 57)
        Me.txtaccountnumber.TabIndex = 3
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
        Me.lblname.Size = New System.Drawing.Size(80, 12)
        Me.lblname.TabIndex = 4
        Me.lblname.Text = "*Username"
        '
        'lblaccount
        '
        Me.lblaccount.AutoSize = True
        Me.lblaccount.BackColor = System.Drawing.Color.Red
        Me.lblaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblaccount.Font = New System.Drawing.Font("BankGothic Md BT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccount.ForeColor = System.Drawing.SystemColors.Control
        Me.lblaccount.Location = New System.Drawing.Point(12, 106)
        Me.lblaccount.Name = "lblaccount"
        Me.lblaccount.Size = New System.Drawing.Size(233, 22)
        Me.lblaccount.TabIndex = 5
        Me.lblaccount.Text = "*Account Number"
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
        Me.lblpin.Size = New System.Drawing.Size(149, 22)
        Me.lblpin.TabIndex = 7
        Me.lblpin.Text = "*Password"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(12, 249)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(329, 57)
        Me.txtpass.TabIndex = 6
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.ClientSize = New System.Drawing.Size(353, 439)
        Me.Controls.Add(Me.lblpin)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.lblaccount)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtaccountnumber)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnregist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registerForm"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnregist As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtaccountnumber As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblaccount As Label
    Friend WithEvents lblpin As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents txtpass As TextBox
End Class
