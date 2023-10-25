<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class withdrawForm
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
        Me.pnlredstrip = New System.Windows.Forms.Panel()
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.pnlred = New System.Windows.Forms.Panel()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblchoose = New System.Windows.Forms.Label()
        Me.btnwithdraw50 = New System.Windows.Forms.Button()
        Me.btnwithdraw100 = New System.Windows.Forms.Button()
        Me.btnwithdraw500 = New System.Windows.Forms.Button()
        Me.btnwithdraw1000 = New System.Windows.Forms.Button()
        Me.btnwithdraw2500 = New System.Windows.Forms.Button()
        Me.btnwithdraw10000 = New System.Windows.Forms.Button()
        Me.pnltopstrip = New System.Windows.Forms.Panel()
        Me.btnConfirmTransaction = New System.Windows.Forms.Button()
        Me.balanceLabel = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.imgmaze = New System.Windows.Forms.PictureBox()
        Me.pnlldock = New System.Windows.Forms.Panel()
        Me.pnlrdock = New System.Windows.Forms.Panel()
        Me.pnltop.SuspendLayout()
        Me.pnlred.SuspendLayout()
        CType(Me.imgmaze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlredstrip
        '
        Me.pnlredstrip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlredstrip.BackColor = System.Drawing.Color.Red
        Me.pnlredstrip.Location = New System.Drawing.Point(187, 168)
        Me.pnlredstrip.Name = "pnlredstrip"
        Me.pnlredstrip.Size = New System.Drawing.Size(782, 5)
        Me.pnlredstrip.TabIndex = 14
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
        Me.pnltop.TabIndex = 15
        '
        'pnlred
        '
        Me.pnlred.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlred.BackColor = System.Drawing.Color.Red
        Me.pnlred.Controls.Add(Me.lbluser)
        Me.pnlred.Controls.Add(Me.lblchoose)
        Me.pnlred.Location = New System.Drawing.Point(187, 184)
        Me.pnlred.Name = "pnlred"
        Me.pnlred.Size = New System.Drawing.Size(782, 75)
        Me.pnlred.TabIndex = 10
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
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "A"
        '
        'lblchoose
        '
        Me.lblchoose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblchoose.AutoSize = True
        Me.lblchoose.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchoose.ForeColor = System.Drawing.SystemColors.Control
        Me.lblchoose.Location = New System.Drawing.Point(83, 46)
        Me.lblchoose.Name = "lblchoose"
        Me.lblchoose.Size = New System.Drawing.Size(634, 16)
        Me.lblchoose.TabIndex = 0
        Me.lblchoose.Text = "Select the amount you wish to withdraw from this account."
        Me.lblchoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnwithdraw50
        '
        Me.btnwithdraw50.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnwithdraw50.BackColor = System.Drawing.Color.Red
        Me.btnwithdraw50.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwithdraw50.ForeColor = System.Drawing.SystemColors.Control
        Me.btnwithdraw50.Location = New System.Drawing.Point(290, 293)
        Me.btnwithdraw50.Name = "btnwithdraw50"
        Me.btnwithdraw50.Size = New System.Drawing.Size(261, 73)
        Me.btnwithdraw50.TabIndex = 16
        Me.btnwithdraw50.Text = "$10"
        Me.btnwithdraw50.UseVisualStyleBackColor = False
        '
        'btnwithdraw100
        '
        Me.btnwithdraw100.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnwithdraw100.BackColor = System.Drawing.Color.Red
        Me.btnwithdraw100.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwithdraw100.ForeColor = System.Drawing.SystemColors.Control
        Me.btnwithdraw100.Location = New System.Drawing.Point(290, 386)
        Me.btnwithdraw100.Name = "btnwithdraw100"
        Me.btnwithdraw100.Size = New System.Drawing.Size(261, 73)
        Me.btnwithdraw100.TabIndex = 17
        Me.btnwithdraw100.Text = "$25"
        Me.btnwithdraw100.UseVisualStyleBackColor = False
        '
        'btnwithdraw500
        '
        Me.btnwithdraw500.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnwithdraw500.BackColor = System.Drawing.Color.Red
        Me.btnwithdraw500.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwithdraw500.ForeColor = System.Drawing.SystemColors.Control
        Me.btnwithdraw500.Location = New System.Drawing.Point(290, 482)
        Me.btnwithdraw500.Name = "btnwithdraw500"
        Me.btnwithdraw500.Size = New System.Drawing.Size(261, 73)
        Me.btnwithdraw500.TabIndex = 18
        Me.btnwithdraw500.Text = "$100"
        Me.btnwithdraw500.UseVisualStyleBackColor = False
        '
        'btnwithdraw1000
        '
        Me.btnwithdraw1000.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnwithdraw1000.BackColor = System.Drawing.Color.Red
        Me.btnwithdraw1000.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwithdraw1000.ForeColor = System.Drawing.SystemColors.Control
        Me.btnwithdraw1000.Location = New System.Drawing.Point(613, 293)
        Me.btnwithdraw1000.Name = "btnwithdraw1000"
        Me.btnwithdraw1000.Size = New System.Drawing.Size(261, 73)
        Me.btnwithdraw1000.TabIndex = 19
        Me.btnwithdraw1000.Text = "$500"
        Me.btnwithdraw1000.UseVisualStyleBackColor = False
        '
        'btnwithdraw2500
        '
        Me.btnwithdraw2500.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnwithdraw2500.BackColor = System.Drawing.Color.Red
        Me.btnwithdraw2500.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwithdraw2500.ForeColor = System.Drawing.SystemColors.Control
        Me.btnwithdraw2500.Location = New System.Drawing.Point(613, 386)
        Me.btnwithdraw2500.Name = "btnwithdraw2500"
        Me.btnwithdraw2500.Size = New System.Drawing.Size(261, 73)
        Me.btnwithdraw2500.TabIndex = 20
        Me.btnwithdraw2500.Text = "$1.000"
        Me.btnwithdraw2500.UseVisualStyleBackColor = False
        '
        'btnwithdraw10000
        '
        Me.btnwithdraw10000.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnwithdraw10000.BackColor = System.Drawing.Color.Red
        Me.btnwithdraw10000.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwithdraw10000.ForeColor = System.Drawing.SystemColors.Control
        Me.btnwithdraw10000.Location = New System.Drawing.Point(613, 482)
        Me.btnwithdraw10000.Name = "btnwithdraw10000"
        Me.btnwithdraw10000.Size = New System.Drawing.Size(261, 73)
        Me.btnwithdraw10000.TabIndex = 21
        Me.btnwithdraw10000.Text = "$2.500"
        Me.btnwithdraw10000.UseVisualStyleBackColor = False
        '
        'pnltopstrip
        '
        Me.pnltopstrip.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnltopstrip.BackColor = System.Drawing.Color.Red
        Me.pnltopstrip.Location = New System.Drawing.Point(0, 39)
        Me.pnltopstrip.Name = "pnltopstrip"
        Me.pnltopstrip.Size = New System.Drawing.Size(1166, 10)
        Me.pnltopstrip.TabIndex = 22
        '
        'btnConfirmTransaction
        '
        Me.btnConfirmTransaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmTransaction.BackColor = System.Drawing.Color.Red
        Me.btnConfirmTransaction.Font = New System.Drawing.Font("BankGothic Lt BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmTransaction.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmTransaction.Location = New System.Drawing.Point(480, 580)
        Me.btnConfirmTransaction.Name = "btnConfirmTransaction"
        Me.btnConfirmTransaction.Size = New System.Drawing.Size(195, 53)
        Me.btnConfirmTransaction.TabIndex = 23
        Me.btnConfirmTransaction.Text = "Withdraw"
        Me.btnConfirmTransaction.UseVisualStyleBackColor = False
        '
        'balanceLabel
        '
        Me.balanceLabel.AutoSize = True
        Me.balanceLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceLabel.Location = New System.Drawing.Point(688, 133)
        Me.balanceLabel.Name = "balanceLabel"
        Me.balanceLabel.Size = New System.Drawing.Size(18, 26)
        Me.balanceLabel.TabIndex = 24
        Me.balanceLabel.Text = " "
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
        'imgmaze
        '
        Me.imgmaze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgmaze.Image = Global.MazeBankAtm.My.Resources.Resources.maze
        Me.imgmaze.Location = New System.Drawing.Point(187, 62)
        Me.imgmaze.Name = "imgmaze"
        Me.imgmaze.Size = New System.Drawing.Size(192, 100)
        Me.imgmaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgmaze.TabIndex = 13
        Me.imgmaze.TabStop = False
        '
        'pnlldock
        '
        Me.pnlldock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlldock.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.pnlldock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlldock.Location = New System.Drawing.Point(-9, 50)
        Me.pnlldock.Name = "pnlldock"
        Me.pnlldock.Size = New System.Drawing.Size(178, 614)
        Me.pnlldock.TabIndex = 7
        '
        'pnlrdock
        '
        Me.pnlrdock.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnlrdock.BackgroundImage = Global.MazeBankAtm.My.Resources.Resources.maze_bank
        Me.pnlrdock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlrdock.Location = New System.Drawing.Point(986, 50)
        Me.pnlrdock.Name = "pnlrdock"
        Me.pnlrdock.Size = New System.Drawing.Size(180, 614)
        Me.pnlrdock.TabIndex = 6
        '
        'withdrawForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 664)
        Me.Controls.Add(Me.balanceLabel)
        Me.Controls.Add(Me.btnConfirmTransaction)
        Me.Controls.Add(Me.pnltopstrip)
        Me.Controls.Add(Me.btnwithdraw10000)
        Me.Controls.Add(Me.btnwithdraw2500)
        Me.Controls.Add(Me.btnwithdraw1000)
        Me.Controls.Add(Me.btnwithdraw500)
        Me.Controls.Add(Me.btnwithdraw100)
        Me.Controls.Add(Me.btnwithdraw50)
        Me.Controls.Add(Me.pnlred)
        Me.Controls.Add(Me.pnltop)
        Me.Controls.Add(Me.pnlredstrip)
        Me.Controls.Add(Me.imgmaze)
        Me.Controls.Add(Me.pnlldock)
        Me.Controls.Add(Me.pnlrdock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "withdrawForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "withdrawForm"
        Me.pnltop.ResumeLayout(False)
        Me.pnlred.ResumeLayout(False)
        Me.pnlred.PerformLayout()
        CType(Me.imgmaze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlrdock As Panel
    Friend WithEvents pnlldock As Panel
    Friend WithEvents imgmaze As PictureBox
    Friend WithEvents pnlredstrip As Panel
    Friend WithEvents pnltop As Panel
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents pnlred As Panel
    Friend WithEvents lbluser As Label
    Friend WithEvents lblchoose As Label
    Friend WithEvents btnwithdraw50 As Button
    Friend WithEvents btnwithdraw100 As Button
    Friend WithEvents btnwithdraw500 As Button
    Friend WithEvents btnwithdraw1000 As Button
    Friend WithEvents btnwithdraw2500 As Button
    Friend WithEvents btnwithdraw10000 As Button
    Friend WithEvents pnltopstrip As Panel
    Friend WithEvents btnConfirmTransaction As Button
    Friend WithEvents balanceLabel As Label
End Class
