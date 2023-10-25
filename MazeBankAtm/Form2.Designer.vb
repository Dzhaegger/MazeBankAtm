<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.pnlhub = New System.Windows.Forms.Panel()
        Me.pnlredstrip = New System.Windows.Forms.Panel()
        Me.imgmazebank = New System.Windows.Forms.PictureBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.pnltopstrip = New System.Windows.Forms.Panel()
        Me.pnllback = New System.Windows.Forms.Panel()
        Me.pnlrback = New System.Windows.Forms.Panel()
        Me.lblchoose = New System.Windows.Forms.Label()
        Me.pnltop.SuspendLayout()
        Me.pnlmain.SuspendLayout()
        Me.pnlhub.SuspendLayout()
        CType(Me.imgmazebank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnltop.BackColor = System.Drawing.Color.LightGray
        Me.pnltop.Controls.Add(Me.btncerrar)
        Me.pnltop.Controls.Add(Me.btnminimizar)
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(1165, 39)
        Me.pnltop.TabIndex = 0
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btncerrar.FlatAppearance.BorderSize = 4
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.MazeBankAtm.My.Resources.Resources.CROSS_1
        Me.btncerrar.Location = New System.Drawing.Point(1116, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(47, 39)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnminimizar.FlatAppearance.BorderSize = 4
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = Global.MazeBankAtm.My.Resources.Resources._211863_minus_round_icon
        Me.btnminimizar.Location = New System.Drawing.Point(1069, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(47, 39)
        Me.btnminimizar.TabIndex = 0
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlmain.Controls.Add(Me.registerButton)
        Me.pnlmain.Controls.Add(Me.pnlhub)
        Me.pnlmain.Controls.Add(Me.pnlredstrip)
        Me.pnlmain.Controls.Add(Me.imgmazebank)
        Me.pnlmain.Controls.Add(Me.loginButton)
        Me.pnlmain.Location = New System.Drawing.Point(170, 45)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(816, 619)
        Me.pnlmain.TabIndex = 1
        '
        'registerButton
        '
        Me.registerButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.registerButton.BackColor = System.Drawing.Color.Red
        Me.registerButton.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerButton.ForeColor = System.Drawing.SystemColors.Control
        Me.registerButton.Location = New System.Drawing.Point(246, 411)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(321, 94)
        Me.registerButton.TabIndex = 5
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'pnlhub
        '
        Me.pnlhub.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlhub.BackColor = System.Drawing.Color.Red
        Me.pnlhub.Controls.Add(Me.lblchoose)
        Me.pnlhub.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlhub.ForeColor = System.Drawing.SystemColors.Control
        Me.pnlhub.Location = New System.Drawing.Point(17, 139)
        Me.pnlhub.Name = "pnlhub"
        Me.pnlhub.Size = New System.Drawing.Size(782, 75)
        Me.pnlhub.TabIndex = 4
        '
        'pnlredstrip
        '
        Me.pnlredstrip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlredstrip.BackColor = System.Drawing.Color.Red
        Me.pnlredstrip.Location = New System.Drawing.Point(17, 123)
        Me.pnlredstrip.Name = "pnlredstrip"
        Me.pnlredstrip.Size = New System.Drawing.Size(782, 5)
        Me.pnlredstrip.TabIndex = 3
        '
        'imgmazebank
        '
        Me.imgmazebank.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgmazebank.Image = Global.MazeBankAtm.My.Resources.Resources.maze
        Me.imgmazebank.Location = New System.Drawing.Point(17, 17)
        Me.imgmazebank.Name = "imgmazebank"
        Me.imgmazebank.Size = New System.Drawing.Size(192, 100)
        Me.imgmazebank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgmazebank.TabIndex = 2
        Me.imgmazebank.TabStop = False
        '
        'loginButton
        '
        Me.loginButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginButton.BackColor = System.Drawing.Color.Red
        Me.loginButton.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.SystemColors.Control
        Me.loginButton.Location = New System.Drawing.Point(246, 253)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(321, 94)
        Me.loginButton.TabIndex = 1
        Me.loginButton.Text = "Log In"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'pnltopstrip
        '
        Me.pnltopstrip.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnltopstrip.BackColor = System.Drawing.Color.Red
        Me.pnltopstrip.Location = New System.Drawing.Point(0, 39)
        Me.pnltopstrip.Name = "pnltopstrip"
        Me.pnltopstrip.Size = New System.Drawing.Size(1166, 10)
        Me.pnltopstrip.TabIndex = 2
        '
        'pnllback
        '
        Me.pnllback.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnllback.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.pnllback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnllback.Location = New System.Drawing.Point(-9, 50)
        Me.pnllback.Name = "pnllback"
        Me.pnllback.Size = New System.Drawing.Size(178, 614)
        Me.pnllback.TabIndex = 4
        '
        'pnlrback
        '
        Me.pnlrback.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnlrback.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.pnlrback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlrback.Location = New System.Drawing.Point(986, 50)
        Me.pnlrback.Name = "pnlrback"
        Me.pnlrback.Size = New System.Drawing.Size(180, 614)
        Me.pnlrback.TabIndex = 3
        '
        'lblchoose
        '
        Me.lblchoose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblchoose.AutoSize = True
        Me.lblchoose.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchoose.ForeColor = System.Drawing.SystemColors.Control
        Me.lblchoose.Location = New System.Drawing.Point(162, 28)
        Me.lblchoose.Name = "lblchoose"
        Me.lblchoose.Size = New System.Drawing.Size(460, 24)
        Me.lblchoose.TabIndex = 1
        Me.lblchoose.Text = "Welcome to Maze Bank Services!"
        Me.lblchoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 664)
        Me.Controls.Add(Me.pnllback)
        Me.Controls.Add(Me.pnlrback)
        Me.Controls.Add(Me.pnltopstrip)
        Me.Controls.Add(Me.pnlmain)
        Me.Controls.Add(Me.pnltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maze Bank"
        Me.pnltop.ResumeLayout(False)
        Me.pnlmain.ResumeLayout(False)
        Me.pnlhub.ResumeLayout(False)
        Me.pnlhub.PerformLayout()
        CType(Me.imgmazebank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnltop As Panel
    Friend WithEvents pnlmain As Panel
    Friend WithEvents pnltopstrip As Panel
    Friend WithEvents imgmazebank As PictureBox
    Friend WithEvents loginButton As Button
    Friend WithEvents pnlhub As Panel
    Friend WithEvents pnlredstrip As Panel
    Friend WithEvents registerButton As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents pnlrback As Panel
    Friend WithEvents pnllback As Panel
    Friend WithEvents lblchoose As Label
End Class
