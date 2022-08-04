Public Class frmViewCurriculum
    Private Sub AddGrades(yr As String, txt As Object, e As DataGridViewCellEventArgs)
        Try
            If e.ColumnIndex = 6 Then
                sql = "SELECT * FROM `tblgrades` g,`tblsubject` s WHERE g.`SubjectId`=s.`SubjectId` AND  Idno =" & lblIdNo.Text & " AND GradesId= " & txt
                reloadtxt(sql)
                If dt.Rows.Count > 0 Then
                    With frmAddingGrades
                        .lblSubject.Text = dt.Rows(0).Item("Subject")
                        .lblGrades.Text = yr
                        .lblidno.Text = lblIdNo.Text
                        .txtPreRequisite.Text = dt.Rows(0).Item("PreRequisite")
                        .lblGradeId.Text = dt.Rows(0).Item("GradesId")
                        .txtaddgrades.Text = dt.Rows(0).Item("Grades")
                        .Show()
                        .Focus()
                        .txtaddgrades.Focus()
                        .txtaddgrades.SelectAll()
                    End With
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmViewCurriculum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BringToFront()
        'dtgFirstYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically
        dtgFirstYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgFirstYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgSecondYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgSecondYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgThirdYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgThirdYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgFourthYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgFourthYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try


            Dim row As DataGridViewRow
            ''''''''''''''first year
            For Each row In dtgFirstYearFirst.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next

            For Each row In dtgFirstYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            '''''''''''''''''Second Year
            For Each row In dtgSecondYearFirst.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next

            For Each row In dtgSecondYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            '''''''''''''''''Third Year
            For Each row In dtgThirdYearFirst.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next


            For Each row In dtgThirdYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            ''''''''''''''''''''Fourth Year
            For Each row In dtgFourthYearFirst.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next

            For Each row In dtgFourthYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            ''''''''''''''end


            'sql = "SELECT sum( (`LecUnit` + `LabUnit`)) FROM `tblsubject` s,`tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` AND Grades > 0 AND IdNo=" & lblIdNo.Text
            'reloadtxt(sql)

            'MsgBox(dt.Rows(0).Item(0).ToString)

            MsgBox("Grades have been updated.")
            LoadData()

        Catch ex As Exception

        End Try
    End Sub
    'Dim btn As New DataGridViewButtonColumn()
    '    dtg.Columns.Add(btn)
    '    btn.HeaderText = "Click Data"
    '    btn.Text = "Click Here"
    '    btn.Name = "btn"
    '    btn.UseColumnTextForButtonValue = True

    'End Sub
    'Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    If e.ColumnIndex = 3 Then
    '        MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
    '    End If
    'End Sub
    Private Sub LoadData()
        Try

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='First' AND Semester= 'First' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgFirstYearFirst)
            dtgFirstYearFirst.Columns(0).Visible = False


            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='First' AND Semester= 'Second' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgFirstYearSecond)
            dtgFirstYearSecond.Columns(0).Visible = False


            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='Second' AND Semester= 'First' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgSecondYearFirst)
            dtgSecondYearFirst.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='Second' AND Semester= 'Second' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgSecondYearSecond)
            dtgSecondYearSecond.Columns(0).Visible = False


            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='Third' AND Semester= 'First' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgThirdYearFirst)
            dtgThirdYearFirst.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='Third' AND Semester= 'Second' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgThirdYearSecond)
            dtgThirdYearSecond.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='Fourth' AND Semester= 'First' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgFourthYearFirst)
            dtgFourthYearFirst.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " &
                   " AND g.YearLevel='Fourth' AND Semester= 'Second' AND g.`CourseId`=" & lblcoursId.Text & "  AND IdNo='" & lblIdNo.Text & "'"
            reloadDtgWithGrades(sql, dtgFourthYearSecond)
            dtgFourthYearSecond.Columns(0).Visible = False

        Catch ex As Exception

        End Try

    End Sub
    Private Sub dtgFirstYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFirstYearSecond.Click
        If dtgFirstYearSecond.CurrentRow.Cells(6).Selected Then
            dtgFirstYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

            dtgFirstYearSecond.CurrentRow.Cells(6).ReadOnly = False
        Else
            dtgFirstYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

            dtgFirstYearSecond.CurrentRow.Cells(6).ReadOnly = True
        End If
    End Sub

    'Private Sub dtgSecondYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSecondYearFirst.Click
    '    If dtgSecondYearFirst.CurrentRow.Cells(6).Selected Then
    '        dtgSecondYearFirst.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '        dtgSecondYearFirst.CurrentRow.Cells(6).ReadOnly = False
    '    Else
    '        dtgSecondYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically

    '        dtgSecondYearFirst.CurrentRow.Cells(6).ReadOnly = True
    '    End If
    'End Sub

    'Private Sub dtgSecondYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSecondYearSecond.Click
    '    If dtgSecondYearSecond.CurrentRow.Cells(6).Selected Then
    '        dtgSecondYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '        dtgSecondYearSecond.CurrentRow.Cells(6).ReadOnly = False
    '    Else
    '        dtgSecondYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

    '        dtgSecondYearSecond.CurrentRow.Cells(6).ReadOnly = True
    '    End If
    'End Sub

    'Private Sub dtgThirdYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgThirdYearFirst.Click
    '    Try
    '        If dtgThirdYearFirst.CurrentRow.Cells(6).Selected Then
    '            dtgThirdYearFirst.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgThirdYearFirst.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgThirdYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgThirdYearFirst.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgThirdYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgThirdYearSecond.Click
    '    Try
    '        If dtgThirdYearSecond.CurrentRow.Cells(6).Selected Then
    '            dtgThirdYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgThirdYearSecond.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgThirdYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgThirdYearSecond.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgFourthYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFourthYearFirst.Click
    '    Try
    '        If dtgFourthYearFirst.CurrentRow.Cells(6).Selected Then
    '            dtgFourthYearFirst.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgFourthYearFirst.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgFourthYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgFourthYearFirst.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgFourthYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFourthYearSecond.Click
    '    Try
    '        If dtgFourthYearSecond.CurrentRow.Cells(6).Selected Then
    '            dtgFourthYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgFourthYearSecond.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgFourthYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgFourthYearSecond.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgFirstYearFirst_CellClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFirstYearSecond.CellClick, dtgFirstYearFirst.CellClick
    '    If e.ColumnIndex = 7 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()

    '    End If
    'End Sub

    'Private Sub dtgFirstYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFirstYearFirst.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgFirstYearFirst"
    '        frmAddingGrades.txtaddgrades.Text = dtgFirstYearFirst.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgFirstYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgFirstYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub
    'Private Sub dtgFirstYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFirstYearSecond.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgFirstYearSecond"
    '        frmAddingGrades.txtaddgrades.Text = dtgFirstYearSecond.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgFirstYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgFirstYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub

    'Private Sub dtgSecondYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSecondYearFirst.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgSecondYearFirst"
    '        frmAddingGrades.txtaddgrades.Text = dtgSecondYearFirst.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgSecondYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgSecondYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub

    'Private Sub dtgSecondYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSecondYearSecond.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgSecondYearSecond"
    '        frmAddingGrades.txtaddgrades.Text = dtgSecondYearSecond.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgSecondYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgSecondYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub

    'Private Sub dtgThirdYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgThirdYearFirst.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgThirdYearFirst"
    '        frmAddingGrades.txtaddgrades.Text = dtgThirdYearFirst.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgThirdYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgThirdYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub

    'Private Sub dtgThirdYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgThirdYearSecond.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgThirdYearSecond"
    '        frmAddingGrades.txtaddgrades.Text = dtgThirdYearSecond.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgThirdYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgThirdYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub

    'Private Sub dtgFourthYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFourthYearFirst.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgFourthYearFirst"
    '        frmAddingGrades.txtaddgrades.Text = dtgFourthYearFirst.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgFourthYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgFourthYearFirst.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub

    'Private Sub dtgFourthYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFourthYearSecond.CellClick
    '    If e.ColumnIndex = 6 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()
    '        frmAddingGrades.lblGrades.Text = "dtgFourthYearSecond"
    '        frmAddingGrades.txtaddgrades.Text = dtgFourthYearSecond.CurrentRow.Cells(6).Value
    '        frmAddingGrades.lblPreRequisite.Text = dtgFourthYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.txtPreRequisite.Text = dtgFourthYearSecond.CurrentRow.Cells(5).Value
    '        frmAddingGrades.lblidno.Text = lblIdNo.Text
    '        frmAddingGrades.txtaddgrades.Focus()
    '        frmAddingGrades.txtaddgrades.SelectAll()
    '    End If
    'End Sub

    Private Sub btnViewCurriculum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCurriculum.Click
        Try
            sql = "SELECT * FROM `tblsubject` s, `tblgrades` g, tblstudent st,tblcourse c " &
                " WHERE s.`SubjectId`=g.`SubjectId` AND g.`IdNo`=st.`IdNo` AND g.`CourseId`  = c.`CourseId` " &
                " AND c.CourseId=" & lblcoursId.Text & " AND g.IdNo='" & lblIdNo.Text & "'"
            reports(sql, "StudentCurriculum", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboSubjId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAddSubj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmAddingSubjectTobeEnroll.ShowDialog()
    End Sub

    Private Sub btnSubjectEnroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubjectEnroll.Click
        Try

            sql = "SELECT SUM((LecUnit + LabUnit)) FROM  tblcourse c,`tblsubject` s WHERE c.CourseId=s.CourseId AND Course='" & lblCourse.Text & "'"
            reloadtxt(sql)
            Dim sunit As Integer = dt.Rows(0).Item(0)

            sql = "SELECT SUM((LecUnit + LabUnit)) FROM  `tblsubject` s,  `tblgrades` g " &
            " WHERE s.`SubjectId` = g.`SubjectId` AND Grades  BETWEEN 1 AND 2.78 AND IdNo='" & lblIdNo.Text & "' AND g.YearLevel='" & lblYearLevel.Text & "'"
            reloadtxt(sql)

            Dim gunit As Integer = dt.Rows(0).Item(0)


            'Select Case lblSemester.Text
            '    Case "First"
            '        If gunit = sunit Then
            '            regularOfferedSubject("First")
            '        Else
            '            irregularOfferedSubject()
            '        End If
            '    Case "Second"
            '        If gunit = sunit Then

            '            regularOfferedSubject("Second")
            '        Else

            '            irregularOfferedSubject()
            '        End If
            'End Select
            irregularOfferedSubject()
            'If gunit = sunit Then
            '    regularOfferedSubject("First")
            'Else
            '    irregularOfferedSubject()
            'End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub regularOfferedSubject(ByVal semester As String)
        Dim yearlevel As String = lblYearLevel.Text
        ' Dim semester As String = lblSemester.Text
        ' Dim dtg As DataGridView = dtgFirstYearSecond

        sql = "SELECT  Subject FROM  `tblsubject` s, `tblgrades` g " &
        " WHERE s.`SubjectId`=g.`SubjectId`  " &
        "  AND g.`IdNo`='" & lblIdNo.Text &
        "'  AND ( Grades < 1 OR Grades > 3 )"
        reloadtxt(sql)

        PreRequisite()

        '   semester = "Second"

        sql = "SELECT *  FROM tblcourse c, `tblsubject` s,tblprerequisite p, `tblgrades` g, tblstudent st  " &
         " WHERE c.CourseId=s.CourseId AND s.`SubjectId`=p.`SubjectId` AND p.`SubjectId`=g.`SubjectId`  AND st.`IdNo`=g.`IdNo` " &
         " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel &
         "' AND Pre1 NOT IN  ('" & pre1 & "','" & pre2 & "','" & pre3 & "','" & pre4 &
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
         " AND st.`IdNo`='" & lblIdNo.Text & "'"

        reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)


        frmPrintGrades.Show()
        frmPrintGrades.Focus()
    End Sub


    Public Sub irregularOfferedSubject()

        sql = "SELECT * FROM tblstudent WHERE IdNo = '" & lblIdNo.Text & "'"
        reloadtxt(sql)
        Dim studlevel As String = dt.Rows(0).Item("YearLevel").ToString



        sql = "SELECT * FROM  `tblsubject` s, `tblgrades` g " &
        " WHERE s.`SubjectId`=g.`SubjectId`  " &
        " AND ( Grades < 1 OR Grades > 3 )" &
        "  AND g.`IdNo`='" & lblIdNo.Text & "'"

        reloadtxt(sql)

        Dim strsubj As String = dt.Rows(0).Item("Subject")
        Dim subj As String() = strsubj.Split(",")

        ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
        For Each prerequisite As String In subj
            'MsgBox(prerequisite)

            sql = "SELECT *  FROM `tblsubject` s, tblcourse c, tblprerequisite p, `tblgrades` g, tblstudent st  " &
          " WHERE s.CourseId=c.CourseId AND s.`SubjectId`=p.`SubjectId` AND p.`SubjectId`=g.`SubjectId`  AND st.`IdNo`=g.`IdNo` " &
              " AND s.YearLevel='" & studlevel & "' AND Grades NOT BETWEEN  1 and 3  AND Subject NOT IN  ('" & prerequisite & "') AND st.`IdNo`='" & lblIdNo.Text & "'"
        Next

        reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
        frmPrintGrades.Show()
        frmPrintGrades.Focus()
    End Sub



    Private Sub dtgFirstYearFirst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgFirstYearFirst.CellClick
        AddGrades(dtgFirstYearFirst.Name, dtgFirstYearFirst.CurrentRow.Cells(0).Value, e)
    End Sub
    Private Sub dtgFirstYearSecond_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgFirstYearSecond.CellClick
        AddGrades(dtgFirstYearSecond.Name, dtgFirstYearSecond.CurrentRow.Cells(0).Value, e)
    End Sub
    Private Sub dtgSecondYearFirst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSecondYearFirst.CellClick
        AddGrades(dtgSecondYearFirst.Name, dtgSecondYearFirst.CurrentRow.Cells(0).Value, e)
    End Sub
    Private Sub dtgSecondYearSecond_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSecondYearSecond.CellClick
        AddGrades(dtgSecondYearSecond.Name, dtgSecondYearSecond.CurrentRow.Cells(0).Value, e)
    End Sub
    Private Sub dtgThirdYearFirst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgThirdYearFirst.CellClick
        AddGrades(dtgThirdYearFirst.Name, dtgThirdYearFirst.CurrentRow.Cells(0).Value, e)
    End Sub
    Private Sub dtgThirdYearSecond_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgThirdYearSecond.CellClick
        AddGrades(dtgThirdYearSecond.Name, dtgThirdYearSecond.CurrentRow.Cells(0).Value, e)
    End Sub
    Private Sub dtgFourthYearFirst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgFourthYearFirst.CellClick
        AddGrades(dtgFourthYearFirst.Name, dtgFourthYearFirst.CurrentRow.Cells(0).Value, e)
    End Sub
    Private Sub dtgFourthYearSecond_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgFourthYearSecond.CellClick
        AddGrades(dtgFourthYearSecond.Name, dtgFourthYearSecond.CurrentRow.Cells(0).Value, e)
    End Sub
End Class