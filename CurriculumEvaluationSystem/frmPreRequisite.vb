Public Class frmPreRequisite
    Private Sub frmPreRequisite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId"
        reloadDtg(sql, dtgList)
        dtgList.Columns(0).Visible = False
        txtPreRequisite.Clear()
        txtSemester.Clear()
        txtSubject.Clear()
        txtYear.Clear()
        txtdesc.Clear()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtSubject.Text = "" Then
                MsgBox("Select the Subject you want to update.", MsgBoxStyle.Exclamation)
                Return
            End If
            sql = "UPDATE  `tblsubject` SET `PreRequisite` ='" & txtPreRequisite.Text.ToUpper() & "' WHERE `SubjectId` = " & dtgList.CurrentRow.Cells(0).Value
            result = updates(sql)

            If result > 0 Then
                MsgBox("Subject Prerequisites have been updated.")
            End If

            Call frmPreRequisite_Load(sender, e)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtgList_Click(sender As Object, e As EventArgs) Handles dtgList.Click
        Try
            sql = "SELECT * FROM `tblsubject` WHERE `SubjectId`=" & dtgList.CurrentRow.Cells(0).Value
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtSubject.Text = dt.Rows(0).Item("Subject")
                txtdesc.Text = dt.Rows(0).Item("DescriptiveTitle")
                txtYear.Text = dt.Rows(0).Item("YearLevel")
                txtSemester.Text = dt.Rows(0).Item("Semester")
                txtPreRequisite.Text = dt.Rows(0).Item("PreRequisite")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId AND Subject Like '%" & txtSearch.Text & "%'"
        reloadDtg(sql, dtgList)
        dtgList.Columns(0).Visible = False
    End Sub
End Class