Public Class frmSubjects

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            'Dim unit As Integer
            Dim level As Integer

            Dim ay As String = cbosy.Text
            If txtSubject.Text = "" Then
                MsgBox("All fields are required.", MsgBoxStyle.Exclamation)
            ElseIf cboCourse.Text = "Select" Then
                MsgBox("Pls. select course", MsgBoxStyle.Exclamation)
                'ElseIf cbosy.Text = "Select" Then
                '    MsgBox("Pls. select academic year", MsgBoxStyle.Exclamation)
            ElseIf cboSemester.Text = "Select" Then
                MsgBox("Pls. select semester", MsgBoxStyle.Exclamation)

            ElseIf cboYearLevel.Text = "Select" Then
                MsgBox("Pls. select year level ", MsgBoxStyle.Exclamation)
            Else

                If cboYearLevel.Text = "First" Then
                    level = 1
                ElseIf cboYearLevel.Text = "Second" Then
                    level = 2
                ElseIf cboYearLevel.Text = "Third" Then
                    level = 3
                ElseIf cboYearLevel.Text = "Fourth" Then
                    level = 4
                End If

                '' unit = Int32.Parse(txtLabUnit.Text) + Int32.Parse(txtLecUnit.Text)


                sql = "SELECT * FROM `tblprerequisite` WHERE  SubjectId=" & txtSubjectId.Text

                sqladd = "INSERT INTO `tblprerequisite` (`SubjectId`, `Pre1`, `Pre2`, `Pre3`, `Pre4`, `Pre5`, `Pre6`, `Pre7`, `Pre8`, `Pre9`) " &
                 " VALUES (" & txtSubjectId.Text & ",'None','None','None','None','None','None','None','None','None')"

                sqledit = "UPDATE  `tblprerequisite` SET `Pre1`='None', `Pre2`='None', `Pre3`='None', `Pre4`='None', `Pre5`='None', `Pre6`='None', `Pre7`='None', `Pre8`='None', `Pre9`='None' WHERE `SubjectId`=" & txtSubjectId.Text


                SaveUpdateNoMsq(sql, sqladd, sqledit)

                sql = "SELECT * FROM `tblsubject` WHERE  SubjectId=" & txtSubjectId.Text

                sqladd = "INSERT INTO `tblsubject` (`Subject`, `DescriptiveTitle`, `LecUnit`, `LabUnit`, `CourseId`,  `Semester`,`YearLevel`,  `PreRequisite`,Level) " &
                " VALUES('" & txtSubject.Text & "','" & txtDesc.Text & "','" & txtLecUnit.Text & "','" & txtLabUnit.Text & "'," & cboCourse.SelectedValue & ",'" & cboSemester.Text &
                "','" & cboYearLevel.Text & "', '" & cboPrerequisite.Text & "'," & level & " )"


                sqledit = "UPDATE `tblsubject` SET `Subject`='" & txtSubject.Text &
                 "', `DescriptiveTitle`='" & txtDesc.Text & "', `LecUnit`='" & txtLecUnit.Text &
                 "', `LabUnit`='" & txtLabUnit.Text & "', `CourseId`=" & cboCourse.SelectedValue & ", `Semester`='" & cboSemester.Text &
                "', `YearLevel`='" & cboYearLevel.Text &
                "', `PreRequisite`='" & cboPrerequisite.Text & "',Level=" & level & "  WHERE  SubjectId=" & txtSubjectId.Text

                save_or_update(sql, sqladd, sqledit, "Subject has been updated in the database.", "New Subject has been added into the database.")



                sql = "UPDATE `tblauto` SET `autoend`=`autoend`+ 1 WHERE `id`=1"
                createNoMsg(sql)

                Call frmSubjects_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cleartext(Me)

        sql = "SELECT * FROM `tblauto` WHERE  `id`=1"
        reloadtxt(sql)
        txtSubjectId.Text = dt.Rows(0).Item(1) & dt.Rows(0).Item(2)

        sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId"
        reloadDtg(sql, dtgList)
        dtgList.Columns(0).Visible = False

        cbo_fill(cboCourse, "Course", "CourseId", "tblcourse")
        cboCourse.Text = "Select"

        cbo_fill(cboPrerequisite, "Subject", "SubjectId", "tblsubject")
        cboPrerequisite.Text = "None"



        cbosy.Text = "Select"
        cboSemester.Text = "Select"
        cboYearLevel.Text = "Select"

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call frmSubjects_Load(sender, e)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtgList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgList.Click
        Try
            With dtgList.CurrentRow
                txtSubjectId.Text = .Cells(0).Value
                txtSubject.Text = .Cells(1).Value
                txtDesc.Text = .Cells(2).Value
                txtLabUnit.Text = .Cells(4).Value
                txtLecUnit.Text = .Cells(3).Value
            End With

        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtSubjectId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectId.TextChanged
        Try
            sql = "SELECT * FROM `tblsubject` WHERE `SubjectId`  = " & txtSubjectId.Text
            reloadtxt(sql)
            With dt.Rows(0)

                cboPrerequisite.Text = .Item("PreRequisite")
                cboSemester.Text = .Item("Semester")
                cboYearLevel.Text = .Item("YearLevel")
                cboCourse.SelectedValue = .Item("CourseId")
                'cbosy.Text = .Item("AcademicYear")
                sql = "SELECT * FROM `tblcourse` WHERE `CourseId`=" & .Item("CourseId")
                reloadtxt(sql)
                cboCourse.Text = dt.Rows(0).Item("Course")
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        sql = "DELETE  FROM `tblprerequisite` WHERE `SubjectId`  = " & dtgList.CurrentRow.Cells(0).Value
        createNoMsg(sql)

        sql = "DELETE FROM `tblsubject` WHERE `SubjectId` = " & dtgList.CurrentRow.Cells(0).Value
        deletes(sql)

        MsgBox("Subject is already deleted")
        Call btnNew_Click(sender, e)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId AND Subject Like '%" & txtSearch.Text & "%'"
        reloadDtg(sql, dtgList)
        dtgList.Columns(0).Visible = False
    End Sub
End Class