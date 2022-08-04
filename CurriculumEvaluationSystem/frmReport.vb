Public Class frmReport


    Private Sub btnListStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListStudents.Click
        sql = "SELECT  `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,Course,`YearLevel` FROM `tblstudent` s, tblcourse c WHERE s.`CourseId`=c.`CourseId`"
        reports(sql, "ListStudents", CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId`  AND st.`IdNo`=g.`IdNo` AND  st.`IdNo`=" & TextBox1.Text & " ORDER BY GradesId ASC  "
        reports(sql, "EvaluationShit", CrystalReportViewer1)
    End Sub

    Private Sub btnCurriculum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurriculum.Click
        sql = "Select * From tblsubject s, tblcourse c WHERE s.CourseId=c.CourseId AND Course LIKE '%" & txtCourse.Text & "%'"
        reports(sql, "Curriculum", CrystalReportViewer1)
    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo_fill(cboSubjId, "Subject", "SubjectId", "`tblsubject` s,`tblprerequisite` p WHERE s.`SubjectId`=p.`SubjectId` and `Pre1` in ('none','') AND  `Pre2` in ('none','') AND  `Pre3` in ('none','') AND  `Pre4` in ('none','') AND  `Pre5` in ('none','') AND  `Pre6` in ('none','') AND  `Pre7` in ('none','') AND  `Pre8` in ('none','') AND  `Pre9` in ('none','')")
        auto_suggest("Course", "tblcourse", txtCourse)
    End Sub


    Private Sub btnSubjPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubjPre.Click
        Try

            sql = "SELECT * FROM tblstudent WHERE IdNo = '" & txtStudentId.Text & "'"
            reloadtxt(sql)
            Dim studlevel As String = dt.Rows(0).Item("YearLevel").ToString



            sql = "SELECT  Subject FROM  `tblsubject` s, `tblgrades` g " &
            " WHERE s.`SubjectId`=g.`SubjectId`  " &
            " AND ( Grades < 1 OR Grades > 3 )" &
            "  AND g.`IdNo`='" & txtStudentId.Text & "'"

            reloadtxt(sql)

            PreRequisite()

            '   semester = "Second"

            sql = "SELECT *  FROM `tblsubject` s, tblcourse c, tblprerequisite p, `tblgrades` g, tblstudent st  " &
              " WHERE s.CourseId=c.CourseId AND s.`SubjectId`=p.`SubjectId` AND p.`SubjectId`=g.`SubjectId`  AND st.`IdNo`=g.`IdNo` " &
              " AND s.YearLevel='" & studlevel & "' AND Grades NOT BETWEEN  1 and 3  AND Pre1 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              "  AND Pre2 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND Pre3 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND Pre4 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND Pre5 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND Pre6 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND Pre7 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND Pre8 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND Pre9 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
              "','" & pre5 & "','" & pre6 & "','" & pre7 & "','" & pre8 & "','" & pre9 & "','" & pre10 & "') " &
              " AND st.`IdNo`='" & txtStudentId.Text & "'"
            reports(sql, "OfferedSubject", CrystalReportViewer1)
            '   SubjEnrolled(sql, "OfferedSubject", CrystalReportViewer1, cboSubjId.SelectedValue)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class