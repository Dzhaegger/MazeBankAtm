<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.balanceLabel = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnwithdraw = New System.Windows.Forms.Button()
        Me.pnlred = New System.Windows.Forms.Panel()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblchoose = New System.Windows.Forms.Label()
        Me.pnlredstrip = New System.Windows.Forms.Panel()
        Me.btndepositcash = New System.Windows.Forms.Button()
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.pnltopstrip = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.pnlrdock = New System.Windows.Forms.Panel()
        Me.pnlldock = New System.Windows.Forms.Panel()
        Me.imgmaze = New System.Windows.Forms.PictureBox()
        Me.pnlmain.SuspendLayout()
        Me.pnlred.SuspendLayout()
        Me.pnltop.SuspendLayout()
        CType(Me.imgmaze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlmain.Controls.Add(Me.balanceLabel)
        Me.pnlmain.Controls.Add(Me.btnlogout)
        Me.pnlmain.Controls.Add(Me.btnwithdraw)
        Me.pnlmain.Controls.Add(Me.pnlred)
        Me.pnlmain.Controls.Add(Me.pnlredstrip)
        Me.pnlmain.Controls.Add(Me.imgmaze)
        Me.pnlmain.Controls.Add(Me.btndepositcash)
        Me.pnlmain.Location = New System.Drawing.Point(170, 45)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(816, 619)
        Me.pnlmain.TabIndex = 2
        '
        'balanceLabel
        '
        Me.balanceLabel.AutoSize = True
        Me.balanceLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceLabel.Location = New System.Drawing.Point(518, 88)
        Me.balanceLabel.Name = "balanceLabel"
        Me.balanceLabel.Size = New System.Drawing.Size(18, 26)
        Me.balanceLabel.TabIndex = 26
        Me.balanceLabel.Text = " "
        '
        'btnlogout
        '
        Me.btnlogout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogout.BackColor = System.Drawing.Color.Red
        Me.btnlogout.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnlogout.Location = New System.Drawing.Point(246, 481)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(321, 94)
        Me.btnlogout.TabIndex = 6
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnwithdraw
        '
        Me.btnwithdraw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnwithdraw.BackColor = System.Drawing.Color.Red
        Me.btnwithdraw.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwithdraw.ForeColor = System.Drawing.SystemColors.Control
        Me.btnwithdraw.Location = New System.Drawing.Point(246, 357)
        Me.btnwithdraw.Name = "btnwithdraw"
        Me.btnwithdraw.Size = New System.Drawing.Size(321, 94)
        Me.btnwithdraw.TabIndex = 5
        Me.btnwithdraw.Text = "Withdraw"
        Me.btnwithdraw.UseVisualStyleBackColor = False
        '
        'pnlred
        '
        Me.pnlred.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlred.BackColor = System.Drawing.Color.Red
        Me.pnlred.Controls.Add(Me.lbluser)
        Me.pnlred.Controls.Add(Me.lblchoose)
        Me.pnlred.Location = New System.Drawing.Point(17, 139)
        Me.pnlred.Name = "pnlred"
        Me.pnlred.Size = New System.Drawing.Size(782, 75)
        Me.pnlred.TabIndex = 4
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Brown
        Me.lbluser.Font = New System.Drawing.Font("BankGothic Md BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.Transparent
        Me.lbluser.Location = New System.Drawing.Point(37, 5)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(32, 25)
        Me.lbluser.TabIndex = 1
        Me.lbluser.Text = "A"
        '
        'lblchoose
        '
        Me.lblchoose.AutoSize = True
        Me.lblchoose.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchoose.ForeColor = System.Drawing.SystemColors.Control
        Me.lblchoose.Location = New System.Drawing.Point(272, 39)
        Me.lblchoose.Name = "lblchoose"
        Me.lblchoose.Size = New System.Drawing.Size(234, 21)
        Me.lblchoose.TabIndex = 0
        Me.lblchoose.Text = "Choose a service"
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
        'btndepositcash
        '
        Me.btndepositcash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndepositcash.BackColor = System.Drawing.Color.Red
        Me.btndepositcash.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndepositcash.ForeColor = System.Drawing.SystemColors.Control
        Me.btndepositcash.Location = New System.Drawing.Point(246, 232)
        Me.btndepositcash.Name = "btndepositcash"
        Me.btndepositcash.Size = New System.Drawing.Size(321, 94)
        Me.btndepositcash.TabIndex = 1
        Me.btndepositcash.Text = "Deposit"
        Me.btndepositcash.UseVisualStyleBackColor = False
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.LightGray
        Me.pnltop.Controls.Add(Me.btncerrar)
        Me.pnltop.Controls.Add(Me.btnminimizar)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(1165, 39)
        Me.pnltop.TabIndex = 7
        '
        'pnltopstrip
        '
        Me.pnltopstrip.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnltopstrip.BackColor = System.Drawing.Color.Red
        Me.pnltopstrip.Location = New System.Drawing.Point(0, 39)
        Me.pnltopstrip.Name = "pnltopstrip"
        Me.pnltopstrip.Size = New System.Drawing.Size(1166, 10)
        Me.pnltopstrip.TabIndex = 8
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
        'pnlrdock
        '
        Me.pnlrdock.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnlrdock.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.pnlrdock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlrdock.Location = New System.Drawing.Point(986, 50)
        Me.pnlrdock.Name = "pnlrdock"
        Me.pnlrdock.Size = New System.Drawing.Size(180, 614)
        Me.pnlrdock.TabIndex = 4
        '
        'pnlldock
        '
        Me.pnlldock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlldock.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.pnlldock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlldock.Location = New System.Drawing.Point(-9, 50)
        Me.pnlldock.Name = "pnlldock"
        Me.pnlldock.Size = New System.Drawing.Size(178, 614)
        Me.pnlldock.TabIndex = 6
        '
        'imgmaze
        '
        Me.imgmaze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgmaze.Image = Global.MazeBankAtm.My.Resources.Resources.maze
        Me.imgmaze.Location = New System.Drawing.Point(17, 17)
        Me.imgmaze.Name = "imgmaze"
        Me.imgmaze.Size = New System.Drawing.Size(192, 100)
        Me.imgmaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgmaze.TabIndex = 2
        Me.imgmaze.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 664)
        Me.Controls.Add(Me.pnltopstrip)
        Me.Controls.Add(Me.pnltop)
        Me.Controls.Add(Me.pnlrdock)
        Me.Controls.Add(Me.pnlldock)
        Me.Controls.Add(Me.pnlmain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.pnlmain.ResumeLayout(False)
        Me.pnlmain.PerformLayout()
        Me.pnlred.ResumeLayout(False)
        Me.pnlred.PerformLayout()
        Me.pnltop.ResumeLayout(False)
        CType(Me.imgmaze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlmain As Panel
    Friend WithEvents btnwithdraw As Button
    Friend WithEvents pnlred As Panel
    Friend WithEvents pnlredstrip As Panel
    Friend WithEvents imgmaze As PictureBox
    Friend WithEvents btndepositcash As Button
    Friend WithEvents pnlldock As Panel
    Friend WithEvents pnlrdock As Panel
    Friend WithEvents pnltop As Panel
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents pnltopstrip As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents lblchoose As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents balanceLabel As Label
End Class
