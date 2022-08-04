Public Class frmAddingGrades
    Private Sub validatePreRequisite()

    End Sub
    Private Sub txtaddgrades_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtaddgrades.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                Dim strsubj As String = txtPreRequisite.Text.Trim()
                Dim subj As String() = strsubj.Split(",")

                ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
                For Each prerequisite As String In subj
                    'MsgBox(prerequisite)
                    If txtaddgrades.Text = "" Then
                        txtaddgrades.Text = 0
                    End If

                    Select Case lblGrades.Text
                        Case "dtgFirstYearFirst"
                            frmViewCurriculum.dtgFirstYearFirst.CurrentRow.Cells(6).Value = txtaddgrades.Text
                            Me.Close()
                            txtaddgrades.Text = 0

                        Case "dtgFirstYearSecond"
                            sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId`  AND IdNo = " & lblidno.Text & " AND UPPER(Subject) in ('" & prerequisite & "') AND (Grades < 1 OR Grades > 3)"
                            reloadtxt(sql)
                            If dt.Rows.Count > 0 Then
                                MsgBox("You take first the pre-requisite of this subject before adding grades on this subject.", MsgBoxStyle.Information)
                                txtaddgrades.Text = 0
                            Else
                                frmViewCurriculum.dtgFirstYearSecond.CurrentRow.Cells(6).Value = txtaddgrades.Text
                                Me.Close()
                            End If

                        Case "dtgSecondYearFirst"
                            sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId`  AND IdNo = " & lblidno.Text & "  AND UPPER(Subject) in ('" & prerequisite & "') AND (Grades < 1 OR Grades > 3)"
                            reloadtxt(sql)
                            If dt.Rows.Count > 0 Then
                                MsgBox("You take first the pre-requisite of this subject before adding grades on this subject.", MsgBoxStyle.Information)
                                txtaddgrades.Text = 0
                            Else
                                frmViewCurriculum.dtgSecondYearFirst.CurrentRow.Cells(6).Value = txtaddgrades.Text
                                Me.Close()
                            End If

                        Case "dtgSecondYearSecond"
                            sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId` AND IdNo = " & lblidno.Text & "  AND UPPER(Subject) in ('" & prerequisite & "') AND (Grades < 1 OR Grades > 3)"
                            reloadtxt(sql)
                            If dt.Rows.Count > 0 Then
                                MsgBox("You take first the pre-requisite of this subject before adding grades on this subject.", MsgBoxStyle.Information)
                                txtaddgrades.Text = 0
                            Else
                                frmViewCurriculum.dtgSecondYearSecond.CurrentRow.Cells(6).Value = txtaddgrades.Text
                                Me.Close()
                            End If

                        Case "dtgThirdYearFirst"

                            sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId`  AND IdNo = " & lblidno.Text & "  AND UPPER(Subject) in ('" & prerequisite & "') AND (Grades < 1 OR Grades > 3)"
                            reloadtxt(sql)
                            If dt.Rows.Count > 0 Then
                                MsgBox("You take first the pre-requisite of this subject before adding grades on this subject.", MsgBoxStyle.Information)
                                txtaddgrades.Text = 0
                            Else
                                frmViewCurriculum.dtgThirdYearFirst.CurrentRow.Cells(6).Value = txtaddgrades.Text
                                Me.Close()
                            End If

                        Case "dtgThirdYearSecond"
                            sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId`  AND IdNo = " & lblidno.Text & "  AND UPPER(Subject) in ('" & prerequisite & "') AND (Grades < 1 OR Grades > 3)"
                            reloadtxt(sql)
                            If dt.Rows.Count > 0 Then
                                MsgBox("You take first the pre-requisite of this subject before adding grades on this subject.", MsgBoxStyle.Information)
                                txtaddgrades.Text = 0
                            Else
                                frmViewCurriculum.dtgThirdYearSecond.CurrentRow.Cells(6).Value = txtaddgrades.Text
                                Me.Close()
                            End If

                        Case "dtgFourthYearFirst"

                            sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId`  AND IdNo = " & lblidno.Text & "  AND UPPER(Subject) in ('" & prerequisite & "') AND (Grades < 1 OR Grades > 3)"
                            reloadtxt(sql)
                            If dt.Rows.Count > 0 Then
                                MsgBox("You take first the pre-requisite of this subject before adding grades on this subject.", MsgBoxStyle.Information)
                                txtaddgrades.Text = 0
                            Else
                                frmViewCurriculum.dtgFourthYearFirst.CurrentRow.Cells(6).Value = txtaddgrades.Text
                                Me.Close()
                            End If


                        Case "dtgFourthYearSecond"

                            sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId`  AND IdNo = " & lblidno.Text & "   AND UPPER(Subject) in ('" & prerequisite & "') AND (Grades < 1 OR Grades > 3)"
                            reloadtxt(sql)
                            If dt.Rows.Count > 0 Then
                                MsgBox("You take first the pre-requisite of this subject before adding grades on this subject.", MsgBoxStyle.Information)
                                txtaddgrades.Text = 0
                            Else
                                frmViewCurriculum.dtgFourthYearSecond.CurrentRow.Cells(6).Value = txtaddgrades.Text
                                Me.Close()
                            End If
                    End Select


                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtaddgrades_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddgrades.KeyPress
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If

        'If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

        '    If e.KeyChar = CChar(".") Then

        '        e.Handled = True

        '    ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

        '        Me.txtaddgrades.Select() ''<---jump to next text box after press Enter

        '        e.Handled = False

        '    Else

        '        e.Handled = True

        '    End If

        'End If
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 127) Then
            e.KeyChar = ""
            e.Handled = False

        End If
    End Sub

    Private Sub txtaddgrades_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddgrades.TextChanged

        Try
            Dim grades As Double = txtaddgrades.Text
            If grades > 3 Or grades < 0 Then
                txtaddgrades.Clear()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmAddingGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class