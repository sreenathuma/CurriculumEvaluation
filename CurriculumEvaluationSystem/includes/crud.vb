Imports MySql.Data.MySqlClient
Module crud
    Public con As MySqlConnection = mysqldb()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public sql As String
    Public result As String
    Public sqladd As String
    Public sqledit As String
#Region "old crud"
    Function save_or_update(ByVal sql As String, ByVal add As String, ByVal edit As String, ByVal msgedit As String, ByVal msgadd As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                With cmd
                    .Connection = con
                    .CommandText = edit
                    result = cmd.ExecuteNonQuery
                End With
                If result > 0 Then
                    MsgBox(msgedit)


                End If
            Else
                With cmd
                    .Connection = con
                    .CommandText = add
                    result = cmd.ExecuteNonQuery
                End With
                If result > 0 Then
                    MsgBox(msgadd)

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return True
    End Function
    Function SaveUpdateNoMsq(ByVal sql As String, ByVal add As String, ByVal edit As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                With cmd
                    .Connection = con
                    .CommandText = edit
                    result = cmd.ExecuteNonQuery
                End With

            Else
                With cmd
                    .Connection = con
                    .CommandText = add
                    result = cmd.ExecuteNonQuery
                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return True
    End Function
    Public Sub createNoMsg(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                cmd.ExecuteNonQuery()
            End With

        Catch ex As Exception
            ' MsgBox(ex.Message & "createNoMsg")
        Finally
            con.Close()
        End Try

    End Sub
    Function create(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery

            End With

        Catch ex As Exception
            MsgBox(ex.Message & " create")
        Finally
            con.Close()
        End Try
        Return result

    End Function
    Public Sub reloadDtg(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter()
            da.SelectCommand = cmd
            da.Fill(dt)

            dtg.DataSource = dt

            'For i = 0 To dtg.Rows.Count - 1
            '    Dim r As DataGridViewRow = dtg.Rows(i).Cells(2).Value
            '    r.Height = 50
            'Next
        Catch ex As Exception
            MsgBox(ex.Message & "reloadDtg")
        Finally
            da.Dispose()
            con.Close()
        End Try

    End Sub
    Public Sub reloadDtgWithGrades(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)



            dtg.DataSource = dt

            'Dim btn As New DataGridViewButtonColumn()
            'dtg.Columns.Add(btn)
            'btn.HeaderText = "Action"
            'btn.Text = "Add Grades"
            'btn.Name = "btn"
            'btn.UseColumnTextForButtonValue = True
            'btn.Width = 8
        Catch ex As Exception
            MsgBox(ex.Message & "reloadDtg")
        Finally
            da.Dispose()
            con.Close()
        End Try

    End Sub
    Public Sub reloadtxt(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

        Catch ex As Exception
            '   MsgBox(ex.Message & "reloadtxt")
        Finally
            da.Dispose()
            con.Close()
        End Try


    End Sub
    Function updates(ByVal sql As String)
        Try
            con.Open()
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                'If result = 0 Then
                '    MsgBox("No updated data", MsgBoxStyle.Information)
                'Else
                '    MsgBox("Data in the database has been updated")
                'End If
            End With
            con.Close()
        Catch ex As Exception
            '   MsgBox(ex.Message & "updates")
        End Try
        Return result
    End Function
    Function deletes(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            'If MessageBox.Show("Do you want to delete this rocord?", "Delete" _
            '                     , MessageBoxButtons.YesNo, MessageBoxIcon.Information) _
            '                     = Windows.Forms.DialogResult.Yes Then
            result = cmd.ExecuteNonQuery

            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return result
    End Function

#End Region

#Region "Report"
    Public Sub SubjEnrolled(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object, ByVal subjid As Integer)
        Try
            con.Open()


            Dim cmds As MySqlCommand = New MySqlCommand
            With cmds
                .Connection = con
                .CommandText = "SELECT * FROM tblsubject WHERE SubjectId = " & subjid
            End With
            Dim das As MySqlDataAdapter = New MySqlDataAdapter
            Dim dts As DataTable = New DataTable
            das.SelectCommand = cmds
            das.Fill(dts)

            Dim id As Integer = dts.Rows(0).Item("SubjectId")
            Dim subject As String = dts.Rows(0).Item("Subject")
            Dim title As String = dts.Rows(0).Item("DescriptiveTitle")
            Dim lecunit As Integer = dts.Rows(0).Item("LecUnit")
            Dim labunit As Integer = dts.Rows(0).Item("LabUnit")
            Dim prerequisite As String = dts.Rows(0).Item("PreRequisite")
            Dim courseid As Integer = dts.Rows(0).Item("CourseId")
            Dim semester As String = dts.Rows(0).Item("Semester")
            Dim yearlevel As String = dts.Rows(0).Item("YearLevel")

            'MsgBox(subject)


            Dim reportname As String

            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim r As DataRow = dt.NewRow()


            r("SubjectId") = id
            r("Subject") = subject
            r("DescriptiveTitle") = title
            r("LecUnit") = lecunit
            r("LabUnit") = labunit
            r("PreRequisite") = prerequisite
            r("CourseId") = courseid
            r("Semester") = semester
            r("YearLevel") = yearlevel


            dt.Rows.Add(r)

            ''With frmViewCurriculum
            ''    For Each rw As DataGridViewRow In .dtgCart.Rows
            ''        r("SubjectId") = rw.Cells(0).Value
            ''        r("Subject") = rw.Cells(1).Value
            ''        r("DescriptiveTitle") = rw.Cells(2).Value
            ''        r("LecUnit") = rw.Cells(3).Value
            ''        r("LabUnit") = rw.Cells(4).Value
            ''        r("PreRequisite") = rw.Cells(5).Value
            ''        r("CourseId") = rw.Cells(6).Value
            ''        r("Semester") = rw.Cells(7).Value
            ''        r("YearLevel") = rw.Cells(8).Value
            ''        dt.Rows.Add(r)
            ''    Next
            ''End With

            reportname = rptname
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\report\" & reportname & ".rpt"
            With reportdoc
                .Load(strReportPath)
                .SetDataSource(dt)
            End With
            With crystalRpt
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False
                .ReportSource = reportdoc
            End With

        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub reports(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
        Try
            con.Open()

            Dim reportname As String
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            ds = New DataSet
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds)
            reportname = rptname
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\report\" & reportname & ".rpt"
            With reportdoc
                .Load(strReportPath)
                .SetDataSource(ds.Tables(0))
            End With
            With crystalRpt
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False
                .ReportSource = reportdoc
            End With
        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        End Try
        con.Close()
        da.Dispose()
    End Sub
#End Region
End Module


