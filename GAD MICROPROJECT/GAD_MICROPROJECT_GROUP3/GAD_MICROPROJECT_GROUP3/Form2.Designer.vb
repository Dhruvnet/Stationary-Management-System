<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formloginpg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formloginpg))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textusername = New System.Windows.Forms.TextBox()
        Me.Textpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Checkpassword = New System.Windows.Forms.CheckBox()
        Me.Buttonlogin = New System.Windows.Forms.Button()
        Me.Buttonclear = New System.Windows.Forms.Button()
        Me.Buttonexit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 73)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(179, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 42)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Login page"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(650, 178)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Textusername
        '
        Me.Textusername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textusername.Location = New System.Drawing.Point(253, 291)
        Me.Textusername.Name = "Textusername"
        Me.Textusername.Size = New System.Drawing.Size(265, 23)
        Me.Textusername.TabIndex = 3
        '
        'Textpassword
        '
        Me.Textpassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textpassword.Location = New System.Drawing.Point(253, 334)
        Me.Textpassword.Name = "Textpassword"
        Me.Textpassword.Size = New System.Drawing.Size(265, 23)
        Me.Textpassword.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Wide Latin", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(90, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Checkpassword
        '
        Me.Checkpassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Checkpassword.AutoSize = True
        Me.Checkpassword.Checked = True
        Me.Checkpassword.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.Checkpassword.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkpassword.ForeColor = System.Drawing.Color.White
        Me.Checkpassword.Location = New System.Drawing.Point(253, 360)
        Me.Checkpassword.Name = "Checkpassword"
        Me.Checkpassword.Size = New System.Drawing.Size(206, 19)
        Me.Checkpassword.TabIndex = 6
        Me.Checkpassword.Text = "Show Password"
        Me.Checkpassword.UseVisualStyleBackColor = True
        '
        'Buttonlogin
        '
        Me.Buttonlogin.BackColor = System.Drawing.Color.BlueViolet
        Me.Buttonlogin.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonlogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Buttonlogin.Location = New System.Drawing.Point(233, 390)
        Me.Buttonlogin.Name = "Buttonlogin"
        Me.Buttonlogin.Size = New System.Drawing.Size(199, 74)
        Me.Buttonlogin.TabIndex = 7
        Me.Buttonlogin.Text = "LOGIN"
        Me.Buttonlogin.UseVisualStyleBackColor = False
        '
        'Buttonclear
        '
        Me.Buttonclear.BackColor = System.Drawing.Color.BlueViolet
        Me.Buttonclear.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonclear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Buttonclear.Location = New System.Drawing.Point(22, 390)
        Me.Buttonclear.Name = "Buttonclear"
        Me.Buttonclear.Size = New System.Drawing.Size(179, 74)
        Me.Buttonclear.TabIndex = 8
        Me.Buttonclear.Text = "CLEAR"
        Me.Buttonclear.UseVisualStyleBackColor = False
        '
        'Buttonexit
        '
        Me.Buttonexit.BackColor = System.Drawing.Color.BlueViolet
        Me.Buttonexit.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonexit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Buttonexit.Location = New System.Drawing.Point(483, 390)
        Me.Buttonexit.Name = "Buttonexit"
        Me.Buttonexit.Size = New System.Drawing.Size(179, 74)
        Me.Buttonexit.TabIndex = 9
        Me.Buttonexit.Text = "EXIT"
        Me.Buttonexit.UseVisualStyleBackColor = False
        '
        'Formloginpg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.ClientSize = New System.Drawing.Size(686, 482)
        Me.Controls.Add(Me.Buttonexit)
        Me.Controls.Add(Me.Buttonclear)
        Me.Controls.Add(Me.Buttonlogin)
        Me.Controls.Add(Me.Checkpassword)
        Me.Controls.Add(Me.Textpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Textusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formloginpg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Textusername As TextBox
    Friend WithEvents Textpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Checkpassword As CheckBox
    Friend WithEvents Buttonlogin As Button
    Friend WithEvents Buttonclear As Button
    Friend WithEvents Buttonexit As Button
    Friend WithEvents Label4 As Label
End Class
