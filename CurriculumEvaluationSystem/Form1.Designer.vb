<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsAddG = New System.Windows.Forms.ToolStripButton()
        Me.tsSearchStudent = New System.Windows.Forms.ToolStripButton()
        Me.tsStudent = New System.Windows.Forms.ToolStripButton()
        Me.tsCurriculum = New System.Windows.Forms.ToolStripButton()
        Me.tsGrades = New System.Windows.Forms.ToolStripButton()
        Me.tsUtilities = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetPreRequisiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReport = New System.Windows.Forms.ToolStripButton()
        Me.tsLogin = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1079, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Curriculum Evaluation System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStudent, Me.tsCurriculum, Me.tsGrades, Me.tsUtilities, Me.tsReport, Me.tsLogin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(131, 434)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAddG, Me.tsSearchStudent})
        Me.ToolStrip2.Location = New System.Drawing.Point(131, 60)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(948, 31)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsAddG
        '
        Me.tsAddG.Image = CType(resources.GetObject("tsAddG.Image"), System.Drawing.Image)
        Me.tsAddG.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddG.Name = "tsAddG"
        Me.tsAddG.Size = New System.Drawing.Size(96, 28)
        Me.tsAddG.Text = "Add Grades"
        '
        'tsSearchStudent
        '
        Me.tsSearchStudent.Image = CType(resources.GetObject("tsSearchStudent.Image"), System.Drawing.Image)
        Me.tsSearchStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearchStudent.Name = "tsSearchStudent"
        Me.tsSearchStudent.Size = New System.Drawing.Size(137, 28)
        Me.tsSearchStudent.Text = "Search for Students"
        '
        'tsStudent
        '
        Me.tsStudent.AutoSize = False
        Me.tsStudent.Image = CType(resources.GetObject("tsStudent.Image"), System.Drawing.Image)
        Me.tsStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsStudent.Name = "tsStudent"
        Me.tsStudent.Size = New System.Drawing.Size(130, 54)
        Me.tsStudent.Text = "Student"
        '
        'tsCurriculum
        '
        Me.tsCurriculum.AutoSize = False
        Me.tsCurriculum.Image = CType(resources.GetObject("tsCurriculum.Image"), System.Drawing.Image)
        Me.tsCurriculum.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCurriculum.Name = "tsCurriculum"
        Me.tsCurriculum.Size = New System.Drawing.Size(130, 54)
        Me.tsCurriculum.Text = "Curriculum"
        '
        'tsGrades
        '
        Me.tsGrades.AutoSize = False
        Me.tsGrades.Image = CType(resources.GetObject("tsGrades.Image"), System.Drawing.Image)
        Me.tsGrades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsGrades.Name = "tsGrades"
        Me.tsGrades.Size = New System.Drawing.Size(130, 54)
        Me.tsGrades.Text = "Grades"
        '
        'tsUtilities
        '
        Me.tsUtilities.AutoSize = False
        Me.tsUtilities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoursesToolStripMenuItem, Me.ManageUserToolStripMenuItem, Me.SetPreRequisiteToolStripMenuItem})
        Me.tsUtilities.Image = CType(resources.GetObject("tsUtilities.Image"), System.Drawing.Image)
        Me.tsUtilities.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUtilities.Name = "tsUtilities"
        Me.tsUtilities.Size = New System.Drawing.Size(130, 54)
        Me.tsUtilities.Text = "Utilities"
        '
        'CoursesToolStripMenuItem
        '
        Me.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem"
        Me.CoursesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CoursesToolStripMenuItem.Text = "Courses"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ManageUserToolStripMenuItem.Text = "Manage User"
        '
        'SetPreRequisiteToolStripMenuItem
        '
        Me.SetPreRequisiteToolStripMenuItem.Name = "SetPreRequisiteToolStripMenuItem"
        Me.SetPreRequisiteToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SetPreRequisiteToolStripMenuItem.Text = "Set Pre-Requisite"
        '
        'tsReport
        '
        Me.tsReport.AutoSize = False
        Me.tsReport.Image = CType(resources.GetObject("tsReport.Image"), System.Drawing.Image)
        Me.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReport.Name = "tsReport"
        Me.tsReport.Size = New System.Drawing.Size(130, 54)
        Me.tsReport.Text = "Report"
        '
        'tsLogin
        '
        Me.tsLogin.Image = Global.CurriculumEvaluationSystem.My.Resources.Resources.login
        Me.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(128, 54)
        Me.tsLogin.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(131, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(948, 403)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 494)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsStudent As ToolStripButton
    Friend WithEvents tsCurriculum As ToolStripButton
    Friend WithEvents tsGrades As ToolStripButton
    Friend WithEvents tsUtilities As ToolStripDropDownButton
    Friend WithEvents tsReport As ToolStripButton
    Friend WithEvents CoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetPreRequisiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsAddG As ToolStripButton
    Friend WithEvents tsSearchStudent As ToolStripButton
    Friend WithEvents tsLogin As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
