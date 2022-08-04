Imports System.IO

Public Class frmStudent

    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,Course,`YearLevel` FROM `tblstudent` s, tblcourse c WHERE s.`CourseId`=c.`CourseId`"
        reloadDtg(sql, dtg_ABorrowLists)

        select_navigation("select IdNo from tblstudent")


        cbo_fill(cboCourse, "Course", "CourseId", "tblcourse")

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1

                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True


                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True


                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"


                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"

                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False



                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        txtPhoto.Text = .FileName
                        'PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                        PictureBox1.ImageLocation = .FileName
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub txt_sid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sid.TextChanged
        reloadtxt("SELECT * FROM `tblstudent` s , tblcourse c WHERE s.`CourseId`=c.`CourseId` AND  `IdNo` = '" & txt_sid.Text & "'")

        If dt.Rows.Count > 0 Then
            txt_fname.Text = dt.Rows(0).Item("Firstname")
            txt_lname.Text = dt.Rows(0).Item("Lastname")
            txt_mname.Text = dt.Rows(0).Item("MI")
            rch_address.Text = dt.Rows(0).Item("HomeAddress")
            cboCourse.SelectedValue = dt.Rows(0).Item("CourseId")
            cboCourse.Text = dt.Rows(0).Item("Course")
            cboYearLevel.Text = dt.Rows(0).Item("YearLevel")
            PictureBox1.ImageLocation = Application.StartupPath & "\StudentPhoto\" & dt.Rows(0).Item("StudentPhoto")


            If dt.Rows(0).Item("Sex") = "Female" Then
                rdio_female.Checked = True
            Else
                rdio_male.Checked = True
            End If
            'btn_edit.Enabled = True
            'btn_delete.Enabled = True
            'btn_save.Enabled = False
        Else

            clearme()
            'btn_edit.Enabled = False
            'btn_delete.Enabled = False
            'btn_save.Enabled = True 
            ''cleartext(grp_addBorrower)
        End If
    End Sub
    Public Sub clearme()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_mname.Clear()
        rch_address.Clear()
        cboCourse.Text = "Select"
        cboYearLevel.Text = "Select"
        txtPhoto.Clear()
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click

        sql = "SELECT  `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`, Course,`YearLevel`  FROM `tblstudent` s, tblcourse c WHERE s.`CourseId`=c.`CourseId`"
        reloadDtg(sql, dtg_ABorrowLists)
        PictureBox1.ImageLocation = ""

        cleartext(Me)

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            If txt_sid.Text = "" _
            Or txt_fname.Text = "" Or txt_lname.Text = "" _
            Or txt_mname.Text = "" Or cboCourse.Text = "Select" _
            Or cboYearLevel.Text = "Select" Then
                emptymessage()
            Else
                ''conditionin the gender of a borrower
                Dim gender As String
                If rdio_female.Checked = True Then
                    gender = "Female"
                Else
                    gender = "Male"
                End If



                sql = "SELECT * FROM `tblstudent` WHERE `IdNo`='" & txt_sid.Text & "'"

                sqladd = "insert into tblstudent (`IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, " _
                       & "`Sex`, `CourseId`,YearLevel,  `StudentPhoto`)" _
                       & "values ('" & txt_sid.Text & "','" & txt_fname.Text & "','" & txt_lname.Text _
                       & "','" & txt_mname.Text & "','" & rch_address.Text _
                       & "','" & gender & "','" & cboCourse.SelectedValue _
                       & "','" & cboYearLevel.Text & "','" & Path.GetFileName(PictureBox1.ImageLocation) & "')"

                sqledit = "update  tblstudent set  `Firstname`='" & txt_fname.Text _
                      & "', `Lastname`='" & txt_lname.Text & "', `MI`='" & txt_mname.Text _
                      & "', `HomeAddress`='" & rch_address.Text & "', `Sex`='" & gender _
                      & "', `CourseId`='" & cboCourse.SelectedValue _
                      & "', `YearLevel`='" & cboYearLevel.Text _
                      & "', `StudentPhoto`='" & Path.GetFileName(PictureBox1.ImageLocation) & "' where `IdNo`='" & txt_sid.Text & "'"

                save_or_update(sql, sqladd, sqledit, "Student has been updated in the database.", "New Student has been added in the database.")


                sql = "SELECT * FROM `tblgrades` WHERE IdNo=" & txt_sid.Text &
                " AND `YearLevel`='" & cboYearLevel.Text & "' AND `CourseId`=" & cboCourse.SelectedValue
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then


                    'sql = "SELECT * FROM `tblsubject` WHERE `CourseId`=" & cboCourse.SelectedValue
                    'reloadtxt(sql)

                    'For Each r As DataRow In dt.Rows
                    '    With r
                    '        sql = "UPDATE `tblgrades` SET `CourseId`=" & cboCourse.SelectedValue & _
                    '        ", `SubjectId`=" & .Item("SubjectId") & _
                    '        ", `YearLevel`='" & .Item("YearLevel") & _
                    '        "'  WHERE `CourseId`=" & cboCourse.SelectedValue & _
                    '        " AND `YearLevel`='" & .Item("YearLevel") & "'"
                    '        createNoMsg(sql)
                    '    End With
                    'Next

                Else

                    sql = "SELECT * FROM `tblsubject` WHERE `CourseId`=" & cboCourse.SelectedValue
                    reloadtxt(sql)

                    For Each r As DataRow In dt.Rows
                        With r
                            sql = "INSERT INTO `tblgrades` (`CourseId`, `IdNo`, `SubjectId`, `YearLevel`,`Sem`) " &
                            " VALUES (" & cboCourse.SelectedValue & ",'" & txt_sid.Text & "'," & .Item("SubjectId") & ",'" & .Item("YearLevel") & "','" & .Item("Semester") & "')"
                            createNoMsg(sql)
                        End With
                    Next


                End If





                If txtPhoto.Text <> "" Then
                    File.Copy(txtPhoto.Text, Application.StartupPath & "\StudentPhoto\" & Path.GetFileName(PictureBox1.ImageLocation), True)
                End If




                '''''''''''''''''''''''''''''''''''''''''''

                'Call frmBorrower_Load(sender, e)
                'txt_sid.Clear()
                Call btn_New_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        select_navigation("select IdNo from tblstudent")

        If inc <> maxrows - 1 Then
            inc = inc + 1
            navagate_records(txt_sid)
        Else
            If inc = maxrows - 1 Then
                MsgBox("No more rows", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btn_prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prev.Click
        select_navigation("select IdNo from tblstudent")

        If inc > 0 Then
            inc = inc - 1
            navagate_records(txt_sid)
        Else
            If inc - 1 Then
                MsgBox("First records", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            select_navigation("select IdNo from tblstudent")

            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                navagate_records(txt_sid)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        Try
            select_navigation("select IdNo from tblstudent")

            inc = 0
            navagate_records(txt_sid)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPhoto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoto.TextChanged
        PictureBox1.ImageLocation = txtPhoto.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub dtg_ABorrowLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_ABorrowLists.Click
        Try
            txt_sid.Text = dtg_ABorrowLists.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            sql = "Delete From tblstudent Where Idno = '" & dtg_ABorrowLists.CurrentRow.Cells(0).Value & "'"
            deletes(sql)
            MsgBox("Student is already deleted.")
            Call btn_New_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class