Imports MySql.Data.MySqlClient
Module funtion
    Public con As MySqlConnection = mysqldb()
    Public Sub cleartext(ByVal group As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
    End Sub


    Public Sub getallforms()
        Try
 

            For Each f As Form In My.Application.OpenForms
                Select Case f.Name
                    Case "frm_Login"
                        'frm_Login.Show()
                    Case Else
                        f.Hide()
                End Select

            Next
        Catch ex As Exception

        End Try

        'For Each t As Type In sender.GetType().Assembly.GetTypes()
        '    If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then

        '        MsgBox(t.Name)

        '    End If
        'Next
    End Sub

    Public Sub cbo_fill(ByVal cbo As ComboBox, ByVal member As String, ByVal id As String, ByVal table As String)

        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "Select * From " & table
            End With 
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            dt = New DataTable
            da.Fill(dt)
            With cbo
                .DataSource = dt
                .ValueMember = id
                .DisplayMember = member
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        'da.Dispose()

    End Sub
   
    Public Sub emptymessage()
        MsgBox("There are empty fields left that must be filled up!", MsgBoxStyle.Exclamation)
    End Sub
 
 
    Public inc As Integer = 0
    Public maxrows As Integer

    Public Sub select_navigation(ByVal sql As String)
        Try
            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                dt = New DataTable
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                maxrows = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message & "select_navigation")
            End Try

            con.Close()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub navagate_records(ByVal txt As Object)
        Try
            txt.text = dt.Rows(inc).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub auto_suggest(ByVal member As String, ByVal table As String, ByVal txt As Object)
        Try
            con.Open()
            sql = "SELECT  " & member & " FROM  " & table
            Dim da As New MySqlDataAdapter(sql, con)
            Dim dt As New DataTable
            dt = New DataTable
            da.Fill(dt)

            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub validation(ByVal frm As Object)
        Try
            For Each txt As Control In frm.Controls

                If txt.GetType Is GetType(TextBox) Then
                    If txt.Text = "" Then
                        MsgBox("One of the box is empty, you filled out!")
                    Else
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ErrorMessage(ByVal lbl As Label, ByVal message As String, ByVal btn As Button)
        lbl.BackColor = Color.Red
        lbl.ForeColor = Color.White
        lbl.Text = message
        btn.Enabled = False
    End Sub
    Public Sub ClearErrorMessage(ByVal lbl As Label, ByVal btn As Button)
        lbl.BackColor = Color.Transparent
        lbl.Text = ""
        btn.Enabled = True
    End Sub

    Public pre As String = ""
    Public pre1 As String = ""
    Public pre2 As String = ""
    Public pre3 As String = ""
    Public pre4 As String = ""
    Public pre5 As String = ""
    Public pre6 As String = ""
    Public pre7 As String = ""
    Public pre8 As String = ""
    Public pre9 As String = ""
    Public pre10 As String = ""
    Public Function PreRequisite() As Boolean
        If dt.Rows.Count > 0 Then
            Try
                If dt.Rows(0).Item(0) <> "" Then
                    pre1 = dt.Rows(0).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(1).Item(0) <> "" Then
                    pre2 = dt.Rows(1).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(2).Item(0) <> "" Then
                    pre3 = dt.Rows(2).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(3).Item(0) <> "" Then
                    pre4 = dt.Rows(3).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(4).Item(0) <> "" Then
                    pre5 = dt.Rows(4).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(5).Item(0) <> "" Then
                    pre6 = dt.Rows(5).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(6).Item(0) <> "" Then
                    pre7 = dt.Rows(6).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(7).Item(0) <> "" Then
                    pre8 = dt.Rows(7).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(8).Item(0) <> "" Then
                    pre9 = dt.Rows(8).Item(0)
                End If
            Catch ex As Exception

            End Try
            Try
                If dt.Rows(9).Item(0) <> "" Then
                    pre10 = dt.Rows(9).Item(0)
                End If
            Catch ex As Exception

            End Try

        End If
        Return True
    End Function
    'Public Sub formulaofpayments(ByVal frm As frmPayments)
    '    Try
    '        Dim totaltime As Integer
    '        Dim ts As TimeSpan = TimeSpan.Parse(frm.txtOverdueTime.Text)
    '        Dim TValueMin As Integer = ts.Minutes.ToString
    '        Dim tValueHour As Integer = 60 * ts.Hours.ToString
    '        Dim condays As Integer = 24 * ts.Days.ToString

    '        totaltime = condays + tValueHour + TValueMin
    '        totaltime = totaltime / Val(frm.txtminutes.Text)
    '        frm.txtTotPay.Text = totaltime * Val(frm.txtamount.Text)

    '    Catch ex As Exception
    '        'MsgBox(ex.Message & "lbl_Rduedate_Click")
    '    End Try
    'End Sub 
    Public Sub columnInvisible(ByVal dtg As DataGridView)
        Dim c As DataGridViewColumn
        For Each c In dtg.Columns

        Next

    End Sub
End Module
