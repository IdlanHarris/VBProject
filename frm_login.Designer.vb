<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Btn_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Location = New System.Drawing.Point(69, 159)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(262, 30)
        Me.txt_username.TabIndex = 0
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Location = New System.Drawing.Point(69, 241)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(262, 30)
        Me.txt_password.TabIndex = 1
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(69, 335)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(262, 45)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Btn_exit
        '
        Me.Btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_exit.FlatAppearance.BorderSize = 0
        Me.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_exit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_exit.ForeColor = System.Drawing.Color.White
        Me.Btn_exit.Location = New System.Drawing.Point(69, 386)
        Me.Btn_exit.Name = "Btn_exit"
        Me.Btn_exit.Size = New System.Drawing.Size(262, 45)
        Me.Btn_exit.TabIndex = 3
        Me.Btn_exit.Text = "Exit"
        Me.Btn_exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(63, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login Here!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(403, 505)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 70
        Me.LineShape1.X2 = 329
        Me.LineShape1.Y1 = 192
        Me.LineShape1.Y2 = 192
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 67
        Me.LineShape2.X2 = 328
        Me.LineShape2.Y1 = 278
        Me.LineShape2.Y2 = 275
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 69
        Me.LineShape3.X2 = 203
        Me.LineShape3.Y1 = 72
        Me.LineShape3.Y2 = 73
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(403, 505)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents Btn_exit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
