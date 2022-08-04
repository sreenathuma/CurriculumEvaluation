Public Class Form1
    Public Sub visibleMenu(ByVal res As String)
        tsAddG.Enabled = res
        tsStudent.Enabled = res
        tsCurriculum.Enabled = res
        tsGrades.Enabled = res
        tsReport.Enabled = res
        tsUtilities.Enabled = res
        tsSearchStudent.Enabled = res
    End Sub
    Private Sub tsStudent_Click(sender As Object, e As EventArgs) Handles tsStudent.Click
        With frmStudent
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub tsCurriculum_Click(sender As Object, e As EventArgs) Handles tsCurriculum.Click
        With frmSubjects
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub tsGrades_Click(sender As Object, e As EventArgs) Handles tsGrades.Click
        With frmViewGrades
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoursesToolStripMenuItem.Click
        With frmCourse
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub SetPreRequisiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPreRequisiteToolStripMenuItem.Click
        With frmPreRequisite
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUserToolStripMenuItem.Click
        With frmUser
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub tsReport_Click(sender As Object, e As EventArgs) Handles tsReport.Click
        With frmReport
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub tsAddG_Click(sender As Object, e As EventArgs) Handles tsAddG.Click
        With frmSearchIDNO
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub tsLogin_Click(sender As Object, e As EventArgs) Handles tsLogin.Click
        If tsLogin.Text = "Login" Then
            LoginForm1.Show()
        Else

            visibleMenu("False")
            tsLogin.Text = "Login"
            tsLogin.Image = My.Resources.login
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibleMenu("False")
    End Sub

    Private Sub tsSearchStudent_Click(sender As Object, e As EventArgs) Handles tsSearchStudent.Click
        With frmSearchStudent
            .Show()
            .Focus()
        End With
    End Sub
End Class
