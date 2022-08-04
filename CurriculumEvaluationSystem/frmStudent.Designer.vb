<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtg_ABorrowLists = New System.Windows.Forms.DataGridView()
        Me.txt_sid = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.rdio_female = New System.Windows.Forms.RadioButton()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rch_address = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdio_male = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.btnDisable = New System.Windows.Forms.Button()
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cboYearLevel
        '
        Me.cboYearLevel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth"})
        Me.cboYearLevel.Location = New System.Drawing.Point(378, 269)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(100, 21)
        Me.cboYearLevel.TabIndex = 96
        Me.cboYearLevel.Text = "Select"
        '
        'cboCourse
        '
        Me.cboCourse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(212, 269)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(160, 21)
        Me.cboCourse.TabIndex = 95
        Me.cboCourse.Text = "Select"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(384, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 39)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Student"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(736, 234)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 36)
        Me.btnClose.TabIndex = 91
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btn_last
        '
        Me.btn_last.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_last.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.Location = New System.Drawing.Point(717, 276)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(51, 24)
        Me.btn_last.TabIndex = 89
        Me.btn_last.Text = ">>|"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_next.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(660, 276)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(51, 24)
        Me.btn_next.TabIndex = 88
        Me.btn_next.Text = ">>"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_New.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(662, 235)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(68, 36)
        Me.btn_New.TabIndex = 86
        Me.btn_New.Text = "Clear"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_first
        '
        Me.btn_first.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_first.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.Location = New System.Drawing.Point(546, 276)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(51, 24)
        Me.btn_first.TabIndex = 90
        Me.btn_first.Text = "|<<"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(588, 234)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(68, 36)
        Me.btn_delete.TabIndex = 85
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(519, 234)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 36)
        Me.btn_save.TabIndex = 83
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_prev
        '
        Me.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_prev.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev.Location = New System.Drawing.Point(603, 276)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(51, 24)
        Me.btn_prev.TabIndex = 87
        Me.btn_prev.Text = "<<"
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(119, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Course/Year :"
        '
        'dtg_ABorrowLists
        '
        Me.dtg_ABorrowLists.AllowUserToAddRows = False
        Me.dtg_ABorrowLists.AllowUserToDeleteRows = False
        Me.dtg_ABorrowLists.AllowUserToResizeColumns = False
        Me.dtg_ABorrowLists.AllowUserToResizeRows = False
        Me.dtg_ABorrowLists.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_ABorrowLists.Location = New System.Drawing.Point(12, 306)
        Me.dtg_ABorrowLists.Name = "dtg_ABorrowLists"
        Me.dtg_ABorrowLists.RowHeadersVisible = False
        Me.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_ABorrowLists.Size = New System.Drawing.Size(877, 221)
        Me.dtg_ABorrowLists.TabIndex = 81
        '
        'txt_sid
        '
        Me.txt_sid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_sid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sid.Location = New System.Drawing.Point(212, 59)
        Me.txt_sid.Name = "txt_sid"
        Me.txt_sid.Size = New System.Drawing.Size(278, 25)
        Me.txt_sid.TabIndex = 67
        '
        'txt_fname
        '
        Me.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(212, 92)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(278, 25)
        Me.txt_fname.TabIndex = 68
        '
        'rdio_female
        '
        Me.rdio_female.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdio_female.AutoSize = True
        Me.rdio_female.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_female.Location = New System.Drawing.Point(281, 242)
        Me.rdio_female.Name = "rdio_female"
        Me.rdio_female.Size = New System.Drawing.Size(67, 21)
        Me.rdio_female.TabIndex = 79
        Me.rdio_female.TabStop = True
        Me.rdio_female.Text = "Female"
        Me.rdio_female.UseVisualStyleBackColor = True
        '
        'txt_mname
        '
        Me.txt_mname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_mname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(212, 150)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(278, 25)
        Me.txt_mname.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Student Id :"
        '
        'txt_lname
        '
        Me.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_lname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(212, 122)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(278, 25)
        Me.txt_lname.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "First Name :"
        '
        'rch_address
        '
        Me.rch_address.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rch_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rch_address.Location = New System.Drawing.Point(212, 178)
        Me.rch_address.Name = "rch_address"
        Me.rch_address.Size = New System.Drawing.Size(222, 58)
        Me.rch_address.TabIndex = 72
        Me.rch_address.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Last Name :"
        '
        'rdio_male
        '
        Me.rdio_male.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdio_male.AutoSize = True
        Me.rdio_male.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_male.Location = New System.Drawing.Point(219, 242)
        Me.rdio_male.Name = "rdio_male"
        Me.rdio_male.Size = New System.Drawing.Size(55, 21)
        Me.rdio_male.TabIndex = 78
        Me.rdio_male.TabStop = True
        Me.rdio_male.Text = "Male"
        Me.rdio_male.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "MI :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(176, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Sex :"
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(518, 234)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(64, 36)
        Me.btn_edit.TabIndex = 84
        Me.btn_edit.Text = "Update"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(533, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'txtPhoto
        '
        Me.txtPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPhoto.Location = New System.Drawing.Point(533, 97)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(209, 20)
        Me.txtPhoto.TabIndex = 92
        '
        'btnDisable
        '
        Me.btnDisable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDisable.Location = New System.Drawing.Point(588, 235)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(68, 36)
        Me.btnDisable.TabIndex = 94
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 539)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_prev)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtg_ABorrowLists)
        Me.Controls.Add(Me.txt_sid)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.rdio_female)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rch_address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdio_male)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.btnDisable)
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btn_last As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_first As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_prev As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtg_ABorrowLists As DataGridView
    Friend WithEvents txt_sid As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents rdio_female As RadioButton
    Friend WithEvents txt_mname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rch_address As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdio_male As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPhoto As TextBox
    Friend WithEvents btnDisable As Button
End Class
