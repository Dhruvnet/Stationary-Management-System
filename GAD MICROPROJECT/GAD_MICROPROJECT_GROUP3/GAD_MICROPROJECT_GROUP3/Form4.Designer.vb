<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stocksform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stocksform))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Buttonreturnhomepage = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Combocategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textprice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textquantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Textname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Buttonlogout = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Buttonlast = New System.Windows.Forms.Button()
        Me.Buttondelete = New System.Windows.Forms.Button()
        Me.Buttonprevious = New System.Windows.Forms.Button()
        Me.Buttonnext = New System.Windows.Forms.Button()
        Me.ButtonAddnew = New System.Windows.Forms.Button()
        Me.Buttonfirst = New System.Windows.Forms.Button()
        Me.Buttonsave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Buttonreturnhomepage)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Buttonlogout)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Buttonlast)
        Me.Panel2.Controls.Add(Me.Buttondelete)
        Me.Panel2.Controls.Add(Me.Buttonprevious)
        Me.Panel2.Controls.Add(Me.Buttonnext)
        Me.Panel2.Controls.Add(Me.ButtonAddnew)
        Me.Panel2.Controls.Add(Me.Buttonfirst)
        Me.Panel2.Controls.Add(Me.Buttonsave)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(12, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 665)
        Me.Panel2.TabIndex = 4
        '
        'Buttonreturnhomepage
        '
        Me.Buttonreturnhomepage.BackColor = System.Drawing.Color.DarkViolet
        Me.Buttonreturnhomepage.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonreturnhomepage.ForeColor = System.Drawing.Color.White
        Me.Buttonreturnhomepage.Location = New System.Drawing.Point(58, 495)
        Me.Buttonreturnhomepage.Name = "Buttonreturnhomepage"
        Me.Buttonreturnhomepage.Size = New System.Drawing.Size(145, 65)
        Me.Buttonreturnhomepage.TabIndex = 7
        Me.Buttonreturnhomepage.Text = "Return to HOME PAGE"
        Me.Buttonreturnhomepage.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTime)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Combocategory)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Textprice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Textquantity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Textname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 151)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TextID
        '
        Me.TextID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(174, 9)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(296, 26)
        Me.TextID.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(66, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Product ID"
        '
        'DateTime
        '
        Me.DateTime.CustomFormat = "yyyy-MM-dd"
        Me.DateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTime.Location = New System.Drawing.Point(623, 107)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(309, 26)
        Me.DateTime.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(515, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Entry Date"
        '
        'Combocategory
        '
        Me.Combocategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combocategory.FormattingEnabled = True
        Me.Combocategory.Items.AddRange(New Object() {"Books", "Pages", "Pens", "Penciles", "Printer Accessiories", "Computer Accessiories"})
        Me.Combocategory.Location = New System.Drawing.Point(175, 107)
        Me.Combocategory.Name = "Combocategory"
        Me.Combocategory.Size = New System.Drawing.Size(295, 28)
        Me.Combocategory.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Product Category "
        '
        'Textprice
        '
        Me.Textprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textprice.Location = New System.Drawing.Point(622, 59)
        Me.Textprice.Name = "Textprice"
        Me.Textprice.Size = New System.Drawing.Size(310, 26)
        Me.Textprice.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(499, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Product Price"
        '
        'Textquantity
        '
        Me.Textquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textquantity.Location = New System.Drawing.Point(174, 59)
        Me.Textquantity.Name = "Textquantity"
        Me.Textquantity.Size = New System.Drawing.Size(296, 26)
        Me.Textquantity.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Product Quantity"
        '
        'Textname
        '
        Me.Textname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textname.Location = New System.Drawing.Point(622, 9)
        Me.Textname.Name = "Textname"
        Me.Textname.Size = New System.Drawing.Size(310, 26)
        Me.Textname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(496, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Name"
        '
        'Buttonlogout
        '
        Me.Buttonlogout.BackColor = System.Drawing.Color.DarkViolet
        Me.Buttonlogout.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonlogout.ForeColor = System.Drawing.Color.White
        Me.Buttonlogout.Location = New System.Drawing.Point(729, 367)
        Me.Buttonlogout.Name = "Buttonlogout"
        Me.Buttonlogout.Size = New System.Drawing.Size(148, 65)
        Me.Buttonlogout.TabIndex = 8
        Me.Buttonlogout.Text = "LOGOUT"
        Me.Buttonlogout.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gold
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Font = New System.Drawing.Font("Lucida Bright", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(589, 519)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(250, 49)
        Me.Button9.TabIndex = 26
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Books", "Pages", "Pens", "Penciles", "Printer Accessiories", "Computer Accessiories"})
        Me.ComboBox2.Location = New System.Drawing.Point(288, 532)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(271, 28)
        Me.ComboBox2.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(192, 541)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 19)
        Me.Label8.TabIndex = 24
        '
        'Buttonlast
        '
        Me.Buttonlast.BackColor = System.Drawing.Color.LawnGreen
        Me.Buttonlast.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonlast.ForeColor = System.Drawing.Color.Black
        Me.Buttonlast.Location = New System.Drawing.Point(746, 438)
        Me.Buttonlast.Name = "Buttonlast"
        Me.Buttonlast.Size = New System.Drawing.Size(196, 75)
        Me.Buttonlast.TabIndex = 23
        Me.Buttonlast.Text = "LAST"
        Me.Buttonlast.UseVisualStyleBackColor = False
        '
        'Buttondelete
        '
        Me.Buttondelete.BackColor = System.Drawing.Color.LawnGreen
        Me.Buttondelete.BackgroundImage = CType(resources.GetObject("Buttondelete.BackgroundImage"), System.Drawing.Image)
        Me.Buttondelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttondelete.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttondelete.ForeColor = System.Drawing.Color.Black
        Me.Buttondelete.Location = New System.Drawing.Point(364, 246)
        Me.Buttondelete.Name = "Buttondelete"
        Me.Buttondelete.Size = New System.Drawing.Size(168, 94)
        Me.Buttondelete.TabIndex = 22
        Me.Buttondelete.UseVisualStyleBackColor = False
        '
        'Buttonprevious
        '
        Me.Buttonprevious.BackColor = System.Drawing.Color.LawnGreen
        Me.Buttonprevious.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonprevious.ForeColor = System.Drawing.Color.Black
        Me.Buttonprevious.Location = New System.Drawing.Point(725, 246)
        Me.Buttonprevious.Name = "Buttonprevious"
        Me.Buttonprevious.Size = New System.Drawing.Size(152, 94)
        Me.Buttonprevious.TabIndex = 21
        Me.Buttonprevious.Text = "PREVIOUS"
        Me.Buttonprevious.UseVisualStyleBackColor = False
        '
        'Buttonnext
        '
        Me.Buttonnext.BackColor = System.Drawing.Color.LawnGreen
        Me.Buttonnext.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonnext.ForeColor = System.Drawing.Color.Black
        Me.Buttonnext.Location = New System.Drawing.Point(551, 246)
        Me.Buttonnext.Name = "Buttonnext"
        Me.Buttonnext.Size = New System.Drawing.Size(168, 94)
        Me.Buttonnext.TabIndex = 19
        Me.Buttonnext.Text = "NEXT"
        Me.Buttonnext.UseVisualStyleBackColor = False
        '
        'ButtonAddnew
        '
        Me.ButtonAddnew.BackColor = System.Drawing.Color.LawnGreen
        Me.ButtonAddnew.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddnew.ForeColor = System.Drawing.Color.Black
        Me.ButtonAddnew.Location = New System.Drawing.Point(185, 246)
        Me.ButtonAddnew.Name = "ButtonAddnew"
        Me.ButtonAddnew.Size = New System.Drawing.Size(157, 94)
        Me.ButtonAddnew.TabIndex = 18
        Me.ButtonAddnew.Text = "CLEAR"
        Me.ButtonAddnew.UseVisualStyleBackColor = False
        '
        'Buttonfirst
        '
        Me.Buttonfirst.BackColor = System.Drawing.Color.LawnGreen
        Me.Buttonfirst.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonfirst.ForeColor = System.Drawing.Color.Black
        Me.Buttonfirst.Location = New System.Drawing.Point(480, -115)
        Me.Buttonfirst.Name = "Buttonfirst"
        Me.Buttonfirst.Size = New System.Drawing.Size(196, 75)
        Me.Buttonfirst.TabIndex = 17
        Me.Buttonfirst.Text = "FIRST"
        Me.Buttonfirst.UseVisualStyleBackColor = False
        '
        'Buttonsave
        '
        Me.Buttonsave.BackColor = System.Drawing.Color.LawnGreen
        Me.Buttonsave.BackgroundImage = CType(resources.GetObject("Buttonsave.BackgroundImage"), System.Drawing.Image)
        Me.Buttonsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonsave.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonsave.ForeColor = System.Drawing.Color.Black
        Me.Buttonsave.Location = New System.Drawing.Point(10, 246)
        Me.Buttonsave.Name = "Buttonsave"
        Me.Buttonsave.Size = New System.Drawing.Size(167, 94)
        Me.Buttonsave.TabIndex = 9
        Me.Buttonsave.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1133, -12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(499, 225)
        Me.DataGridView1.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Olive
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(955, 78)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Wide Latin", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(334, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Stock's Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 81)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(114, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(777, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Stationary  Shop  Management  Software"
        '
        'Stocksform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(991, 776)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stocksform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Buttonlast As Button
    Friend WithEvents Buttondelete As Button
    Friend WithEvents Buttonprevious As Button
    Friend WithEvents Buttonnext As Button
    Friend WithEvents ButtonAddnew As Button
    Friend WithEvents Buttonfirst As Button
    Friend WithEvents Buttonsave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Combocategory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Textprice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Textquantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Textname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Buttonlogout As Button
    Friend WithEvents Buttonreturnhomepage As Button
    Friend WithEvents TextID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
