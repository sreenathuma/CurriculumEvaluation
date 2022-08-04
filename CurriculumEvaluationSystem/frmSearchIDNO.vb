Public Class frmSearchIDNO
    Dim courseid As Integer
    Dim idno As String
    Private Sub frmSearchIDNO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto_suggest("IDNO", "tblstudent", txtSearch)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            idno = txtSearch.Text
            If idno = "" Then
                MsgBox("Pls enter id number.", MsgBoxStyle.Exclamation)
                Return
            End If

            With frmViewCurriculum
                sql = "SELECT * FROM `tblstudent`  s , `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND IdNo='" & idno & "'"
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
            'MessageBox.Show(ex.Message)
            MsgBox("Id number is not registered.", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class