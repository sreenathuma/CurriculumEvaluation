Public Class frmCourse
    Dim courseid = 0
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtCourse.Text = "" Then
            MsgBox("Field is required.", MsgBoxStyle.Exclamation)
        Else
            sql = "Select * From tblcourse WHERE CourseId = " & courseid

            sqladd = "INSERT INTO `tblcourse` (`Course`) VALUES ('" & txtCourse.Text & "')"

            sqledit = "UPDATE `tblcourse` SET `Course`='" & txtCourse.Text & "' WHERE CourseId=" & courseid

            save_or_update(sql, sqladd, sqledit, "Course has been updated in the database.", "New course has been saved in the database.")

            Call frmCourse_Load(sender, e)

        End If
    End Sub
    Private Sub frmCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "Select * From tblcourse"
        reloadDtg(sql, dtglist)

        txtCourse.Text = ""
    End Sub

    Private Sub dtglist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.Click
        Try
            With dtglist
                courseid = .CurrentRow.Cells(0).Value
                txtCourse.Text = .CurrentRow.Cells(1).Value
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        courseid = 0
        txtCourse.Clear()
        sql = "Select * From tblcourse"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "Select * From tblcourse WHERE Course Like '%" & txtSearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = "Delete From tblcourse WHERE CourseId=" & dtglist.CurrentRow.Cells(0).Value
        deletes(sql)
        MsgBox("Course has been deleted!")
        Call btnnew_Click(sender, e)
    End Sub
End Class