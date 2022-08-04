Public Class frmViewGrades

    Public idno As Integer
    Public courseid As Integer
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Try


            sql = "SELECT * FROM `tblstudent` s, `tblcourse` c " &
            " WHERE s.`CourseId`=c.`CourseId` " &
            " AND (`IdNo` LIKE '%" & txtSearch.Text &
            "%' OR  `Firstname`  LIKE '%" & txtSearch.Text &
            "%' OR  `Lastname` LIKE '%" & txtSearch.Text & "%' OR CONCAT(`Firstname`,' ', `Lastname`) LIKE '%" & txtSearch.Text & "%')"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                lblName.Text = dt.Rows(0).Item("Firstname") & " " & dt.Rows(0).Item("MI") & " " & dt.Rows(0).Item("Lastname")
                lblAddress.Text = dt.Rows(0).Item("HomeAddress")
                lblCourse.Text = dt.Rows(0).Item("Course")
                lblYearLevel.Text = dt.Rows(0).Item("YearLevel")
                idno = dt.Rows(0).Item("IdNo")
                courseid = dt.Rows(0).Item("CourseId")

                sql = "SELECT s.`SubjectId` ,`Subject`, `DescriptiveTitle`, `LecUnit`, `LabUnit`,`PreRequisite`,`Grades` " &
                " FROM `tblsubject` s, `tblgrades` g  " &
                " WHERE s.`SubjectId`=g.`SubjectId`  AND IdNo= '" & idno &
                "' AND g.CourseId = " & courseid & " AND s.YearLevel = '" & lblYearLevel.Text & "'"
                reloadDtg(sql, dtgList)
                tsAdd.Enabled = True
            Else
                MsgBox("No found Record!", MsgBoxStyle.Exclamation)
                lblName.Text = "None"
                lblAddress.Text = "None"
                lblCourse.Text = "None"
                lblYearLevel.Text = "None"
                idno = 0
                courseid = 0
                dtgList.Columns.Clear()
                txtSearch.Clear()
                txtSearch.Focus()
                tsAdd.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmViewGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        auto_suggest("CONCAT(`Firstname`,' ', `Lastname`)", "tblstudent", txtSearch)
        txtSearch.Clear()
        txtSearch.Focus()
        tsAdd.Enabled = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsAdd.Click
        Try
            If idno = 0 Then
                MsgBox("Pls enter id number.", MsgBoxStyle.Exclamation)
                Return
            End If

            With frmViewCurriculum
                sql = "SELECT * FROM `tblstudent`  s , `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND IdNo=" & idno
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then

                    courseid = dt.Rows(0).Item("CourseId")


                    .lblName.Text = dt.Rows(0).Item("Firstname") & " " & dt.Rows(0).Item("Lastname")
                    .lblCourse.Text = dt.Rows(0).Item("Course")
                    .lblYearLevel.Text = dt.Rows(0).Item("YearLevel")
                    .lblIdNo.Text = dt.Rows(0).Item("IdNo")
                    .lblSemester.Text = dt.Rows(0).Item("IdNo")


                    ' sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId` " &
                    '" AND s.`SubjectId`=g.`SubjectId` " &
                    '" AND g.`CourseId`=" & courseid & " AND g.YearLevel='First' AND Semester= 'First' AND IdNo=" & idno
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='First' AND Semester= 'First' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgFirstYearFirst)
                    .dtgFirstYearFirst.Columns(0).Visible = False



                    'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId` " &
                    '      " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='First' AND Semester= 'Second' " &
                    '      " AND g.`CourseId`=" & courseid & " AND IdNo=" & idno
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='First' AND Semester= 'Second' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgFirstYearSecond)
                    .dtgFirstYearSecond.Columns(0).Visible = False


                    'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`  " &
                    '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'First' " &
                    '     " AND g.`CourseId`=" & courseid & " AND IdNo=" & idno
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='Second' AND Semester= 'First' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgSecondYearFirst)
                    .dtgSecondYearFirst.Columns(0).Visible = False

                    'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`   " &
                    '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'Second' " &
                    '     " AND g.`CourseId`=" & courseid & " AND IdNo=" & idno
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='Second' AND Semester= 'Second' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgSecondYearSecond)
                    .dtgSecondYearSecond.Columns(0).Visible = False


                    'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`   " &
                    '    " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'First' " &
                    '    " AND g.`CourseId`=" & courseid &
                    '    " AND IdNo=" & idno
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='Third' AND Semester= 'First' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgThirdYearFirst)
                    .dtgThirdYearFirst.Columns(0).Visible = False

                    'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`   " &
                    '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'Second' " &
                    '     " AND g.`CourseId`=" & courseid & " AND IdNo=" & idno 
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='Third' AND Semester= 'Second' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgThirdYearSecond)
                    .dtgThirdYearSecond.Columns(0).Visible = False

                    'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`  " &
                    '   " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'First' " &
                    '   " AND g.`CourseId`=" & courseid & " AND IdNo=" & idno
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='Fourth' AND Semester= 'First' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgFourthYearFirst)
                    .dtgFourthYearFirst.Columns(0).Visible = False

                    'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`  " &
                    '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'Second' " &
                    '     " AND g.`CourseId`=" & courseid & " AND IdNo=" & idno
                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.`CourseId`=" & courseid & " AND g.YearLevel='Fourth' AND Semester= 'Second' AND IdNo=" & idno
                    reloadDtgWithGrades(sql, .dtgFourthYearSecond)
                    .dtgFourthYearSecond.Columns(0).Visible = False

                    .Show()
                    .Focus()

                    .lblcoursId.Text = courseid

                    Me.Close()
                Else
                    MsgBox("Id number is not registered.", MsgBoxStyle.Exclamation)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class