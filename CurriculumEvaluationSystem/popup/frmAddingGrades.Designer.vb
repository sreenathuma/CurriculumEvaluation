<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddingGrades
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
        Me.txtaddgrades = New System.Windows.Forms.TextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblGrades = New System.Windows.Forms.Label()
        Me.lblidno = New System.Windows.Forms.Label()
        Me.lblGradeId = New System.Windows.Forms.Label()
        Me.txtPreRequisite = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtaddgrades
        '
        Me.txtaddgrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddgrades.Location = New System.Drawing.Point(12, 46)
        Me.txtaddgrades.MaxLength = 3
        Me.txtaddgrades.Name = "txtaddgrades"
        Me.txtaddgrades.Size = New System.Drawing.Size(378, 45)
        Me.txtaddgrades.TabIndex = 6
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(6, 11)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(173, 32)
        Me.lblSubject.TabIndex = 7
        Me.lblSubject.Text = "Add Grades "
        '
        'lblGrades
        '
        Me.lblGrades.AutoSize = True
        Me.lblGrades.Location = New System.Drawing.Point(422, 26)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(41, 13)
        Me.lblGrades.TabIndex = 10
        Me.lblGrades.Text = "Grades"
        '
        'lblidno
        '
        Me.lblidno.AutoSize = True
        Me.lblidno.Location = New System.Drawing.Point(422, 59)
        Me.lblidno.Name = "lblidno"
        Me.lblidno.Size = New System.Drawing.Size(34, 13)
        Me.lblidno.TabIndex = 11
        Me.lblidno.Text = "IDNO"
        '
        'lblGradeId
        '
        Me.lblGradeId.AutoSize = True
        Me.lblGradeId.Location = New System.Drawing.Point(422, 81)
        Me.lblGradeId.Name = "lblGradeId"
        Me.lblGradeId.Size = New System.Drawing.Size(45, 13)
        Me.lblGradeId.TabIndex = 12
        Me.lblGradeId.Text = "GradeId"
        '
        'txtPreRequisite
        '
        Me.txtPreRequisite.Location = New System.Drawing.Point(424, 36)
        Me.txtPreRequisite.Name = "txtPreRequisite"
        Me.txtPreRequisite.Size = New System.Drawing.Size(168, 20)
        Me.txtPreRequisite.TabIndex = 13
        '
        'frmAddingGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 102)
        Me.Controls.Add(Me.txtPreRequisite)
        Me.Controls.Add(Me.lblGradeId)
        Me.Controls.Add(Me.txtaddgrades)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.lblidno)
        Me.MaximumSize = New System.Drawing.Size(1364, 90000)
        Me.Name = "frmAddingGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtaddgrades As TextBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblGrades As Label
    Friend WithEvents lblidno As Label
    Friend WithEvents lblGradeId As Label
    Friend WithEvents txtPreRequisite As TextBox
End Class
