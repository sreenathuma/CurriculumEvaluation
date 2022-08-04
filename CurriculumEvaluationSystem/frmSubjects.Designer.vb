<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSubjects
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.txtLecUnit = New System.Windows.Forms.TextBox()
        Me.txtLabUnit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtSubjectId = New System.Windows.Forms.TextBox()
        Me.cboPrerequisite = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbosy = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.Location = New System.Drawing.Point(372, 217)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboSemester
        '
        Me.cboSemester.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Items.AddRange(New Object() {"First", "Second"})
        Me.cboSemester.Location = New System.Drawing.Point(576, 115)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(211, 21)
        Me.cboSemester.TabIndex = 55
        Me.cboSemester.Text = "Select"
        '
        'cboYearLevel
        '
        Me.cboYearLevel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth"})
        Me.cboYearLevel.Location = New System.Drawing.Point(576, 86)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(211, 21)
        Me.cboYearLevel.TabIndex = 52
        Me.cboYearLevel.Text = "Select"
        '
        'cboCourse
        '
        Me.cboCourse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(576, 60)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(211, 21)
        Me.cboCourse.TabIndex = 51
        Me.cboCourse.Text = "Select"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(486, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Year Level :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(494, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Semester :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(509, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Course :"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.Location = New System.Drawing.Point(453, 217)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 35)
        Me.btnClose.TabIndex = 45
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNew.Location = New System.Drawing.Point(291, 217)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 35)
        Me.btnNew.TabIndex = 44
        Me.btnNew.Text = "Clear"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.Location = New System.Drawing.Point(210, 217)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtgList
        '
        Me.dtgList.AllowUserToAddRows = False
        Me.dtgList.AllowUserToDeleteRows = False
        Me.dtgList.AllowUserToResizeColumns = False
        Me.dtgList.AllowUserToResizeRows = False
        Me.dtgList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgList.Location = New System.Drawing.Point(12, 273)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.RowHeadersVisible = False
        Me.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgList.Size = New System.Drawing.Size(876, 260)
        Me.dtgList.TabIndex = 40
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(210, 89)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(216, 64)
        Me.txtDesc.TabIndex = 39
        Me.txtDesc.Text = ""
        '
        'txtLecUnit
        '
        Me.txtLecUnit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLecUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecUnit.Location = New System.Drawing.Point(210, 159)
        Me.txtLecUnit.Name = "txtLecUnit"
        Me.txtLecUnit.Size = New System.Drawing.Size(75, 23)
        Me.txtLecUnit.TabIndex = 41
        '
        'txtLabUnit
        '
        Me.txtLabUnit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLabUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabUnit.Location = New System.Drawing.Point(210, 188)
        Me.txtLabUnit.Name = "txtLabUnit"
        Me.txtLabUnit.Size = New System.Drawing.Size(75, 23)
        Me.txtLabUnit.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Lecture Unit :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Descriptive Title :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Lab. Unit :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 31.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 48)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Curriculum"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Course No .:"
        '
        'txtSubject
        '
        Me.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(210, 60)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(216, 23)
        Me.txtSubject.TabIndex = 38
        '
        'txtSubjectId
        '
        Me.txtSubjectId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSubjectId.Enabled = False
        Me.txtSubjectId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectId.Location = New System.Drawing.Point(210, 60)
        Me.txtSubjectId.Name = "txtSubjectId"
        Me.txtSubjectId.Size = New System.Drawing.Size(216, 23)
        Me.txtSubjectId.TabIndex = 37
        '
        'cboPrerequisite
        '
        Me.cboPrerequisite.FormattingEnabled = True
        Me.cboPrerequisite.Items.AddRange(New Object() {"First", "Second"})
        Me.cboPrerequisite.Location = New System.Drawing.Point(519, 345)
        Me.cboPrerequisite.Name = "cboPrerequisite"
        Me.cboPrerequisite.Size = New System.Drawing.Size(211, 21)
        Me.cboPrerequisite.TabIndex = 53
        Me.cboPrerequisite.Text = "None"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(412, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Pre Requisite :"
        '
        'cbosy
        '
        Me.cbosy.FormattingEnabled = True
        Me.cbosy.Items.AddRange(New Object() {"2014-2015", "2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020", "2020-2021", "2021-2022"})
        Me.cbosy.Location = New System.Drawing.Point(480, 342)
        Me.cbosy.Name = "cbosy"
        Me.cbosy.Size = New System.Drawing.Size(211, 21)
        Me.cbosy.TabIndex = 54
        Me.cbosy.Text = "2014-2015"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(373, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Acaemic Year:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(653, 247)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 20)
        Me.txtSearch.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(586, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Search :"
        '
        'frmSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 537)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboSemester)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtgList)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtLecUnit)
        Me.Controls.Add(Me.txtLabUnit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtSubjectId)
        Me.Controls.Add(Me.cboPrerequisite)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbosy)
        Me.Controls.Add(Me.Label10)
        Me.Name = "frmSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "6"
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents cboSemester As ComboBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents txtDesc As RichTextBox
    Friend WithEvents txtLecUnit As TextBox
    Friend WithEvents txtLabUnit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtSubjectId As TextBox
    Friend WithEvents cboPrerequisite As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbosy As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
End Class
