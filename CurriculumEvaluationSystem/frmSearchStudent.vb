Public Class frmSearchStudent

    Private Sub frmSearchStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,`Course`, `YearLevel`,c.CourseId FROM `tblstudent` s, `tblcourse` c WHERE s.`CourseId`=c.`CourseId`"
        reloadDtg(sql, dtgList)
        dtgList.Columns(8).Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        sql = " SELECT `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,`Course`, `YearLevel`,c.CourseId FROM `tblstudent` s, `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND (Firstname LIKE '%" & TextBox1.Text & "%' Or Lastname LIKE '%" & TextBox1.Text & "%' OR IdNo Like '%" & TextBox1.Text & "%')"
        reloadDtg(sql, dtgList)
        dtgList.Columns(8).Visible = False
    End Sub

    Private Sub btnAddGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGrades.Click
        Try
            sql = "SELECT * FROM `tblsubject` s, `tblgrades` g, tblstudent st,tblcourse c " &
                " WHERE s.`SubjectId`=g.`SubjectId` AND g.`IdNo`=st.`IdNo` AND g.`CourseId`  = c.`CourseId` " &
                " AND c.CourseId=" & dtgList.CurrentRow.Cells(8).Value & " AND g.IdNo='" & dtgList.CurrentRow.Cells(0).Value & "'"
            reports(sql, "StudentCurriculum", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class