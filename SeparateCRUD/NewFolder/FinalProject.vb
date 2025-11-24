Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FinalProject

    Private Sub FinalProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDGV(My.Settings.queryDisplay)
    End Sub
    ''Clear Fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTaskName.Clear()
        txtDescription.Clear()
        dateDueDate.Value = DateTime.Now
        cbStatus.Text = "Select Status"
        cbPriority.Text = "Select Priority"
    End Sub

    ''load dgvTask
    Private Sub loadDGV(sql As String, Optional param As String = "")
        Dim DA As New OdbcDataAdapter
        Dim cmd As OdbcCommand
        Dim DT As New DataTable

        Try
            dbConnect()
            cmd = New OdbcCommand(sql, conn)

            If Len(param) <> 0 Then
                cmd.Parameters.AddWithValue("@param", param)
            End If

            DA.SelectCommand = cmd
            DA.Fill(DT)
            dgvTask.DataSource = DT
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Database Connection Error")
        Finally
            GC.Collect()
            conn.Close()
        End Try
    End Sub

    ''Toggle Enable/Disable Controls
    Private Sub btnToggle(isEnabled As Boolean, Optional EnableDGV As Boolean = True)
        btnAdd.Enabled = isEnabled
        btnUpdate.Enabled = isEnabled
        btnSave.Enabled = Not isEnabled
        btnCancel.Enabled = Not isEnabled
        btnDelete.Enabled = isEnabled
        btnClose.Enabled = isEnabled
        btnClear.Enabled = Not isEnabled
        cbStatus.Enabled = Not isEnabled
        pnlFields.Enabled = Not isEnabled
        If EnableDGV = True Then
            dgvTask.Enabled = EnableDGV
        ElseIf EnableDGV = False Then
            dgvTask.Enabled = EnableDGV
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnToggle(False, False)
        cbStatus.Enabled = False 'Adding task and saying your already done? Why?
        dgvTask.Tag = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim cmd As OdbcCommand

        If checker() = True Then
            Try
                dbConnect()

                If Val(dgvTask.Tag) = 0 Then
                    sql = My.Settings.queryCreate
                    cmd = New OdbcCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@task_name", txtTaskName.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@due_date", dateDueDate.Value)
                    cmd.Parameters.AddWithValue("@priority", cbPriority.SelectedItem.ToString())
                    'cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString()) If adding task supposedly you haven't done it.
                Else
                    sql = My.Settings.queryUpdate
                    cmd = New OdbcCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@task_name", txtTaskName.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@due_date", dateDueDate.Value)
                    cmd.Parameters.AddWithValue("@priority", cbPriority.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvTask.Tag)) 'getting the selected taskID
                End If

                cmd.ExecuteNonQuery()
                cleaner()
                btnToggle(True)
                loadDGV(My.Settings.queryDisplay)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                GC.Collect()
                conn.Close()
            End Try
        End If
    End Sub

    ' For every field in the pnlFields, checks if its actually filled / valid
    Function checker() As Boolean
        For Each obj In pnlFields.Controls
            If TypeOf obj Is System.Windows.Forms.TextBox Then
                If Len(obj.Text) = 0 Then
                    MsgBox("Fill in all text fields.", MsgBoxStyle.Exclamation, "Input Error")
                    obj.Focus()
                    Return False
                End If
            ElseIf TypeOf obj Is System.Windows.Forms.ComboBox Then
                If obj.SelectedIndex = -1 Then
                    If obj Is cbStatus And Not cbStatus.Enabled Then
                        Continue For 'skip check if cbstatus is disabled. Only for new tasks
                    Else
                        MsgBox("Please select an option from all dropdowns.", MsgBoxStyle.Exclamation, "Input Error")
                        obj.Focus()
                    End If
                End If
            End If
        Next
        Return True
    End Function

    ''Cleaner
    Private Sub cleaner()
        For Each obj In pnlFields.Controls
            If TypeOf obj Is System.Windows.Forms.TextBox Then
                obj.Clear()
            ElseIf TypeOf obj Is System.Windows.Forms.ComboBox Then
                obj.SelectedIndex = -1
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cleaner()
        btnToggle(True, True)
    End Sub

    Private Sub dgvTask_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTask.CellContentClick
        ' Too specific. You need to click it in a certain column to work.
    End Sub
    Private Sub dgvTask_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTask.CellClick
        Try
            dgvTask.Tag = Val(dgvTask.Item(0, e.RowIndex).Value)
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Selection Error")
            ' or leave it blank to silently fail. 
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Val(dgvTask.Tag) = 0 Then
            MsgBox("Please select a task to update.", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Are you sure you want to update this task?", MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                btnToggle(False, False)
                Try
                    dbConnect()
                    Dim sql As String = My.Settings.querySelectById
                    Dim cmd As OdbcCommand = New OdbcCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@task_id", Val(dgvTask.Tag))
                    Dim da As OdbcDataAdapter = New OdbcDataAdapter
                    da.SelectCommand = cmd
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        txtTaskName.Text = dt.Rows(0).Item("task_name").ToString()
                        txtDescription.Text = dt.Rows(0).Item("description").ToString()
                        dateDueDate.Value = Convert.ToDateTime(dt.Rows(0).Item("due_date"))
                        cbPriority.SelectedItem = dt.Rows(0).Item("priority").ToString()
                        cbStatus.SelectedItem = dt.Rows(0).Item("status").ToString()
                    End If

                    txtTaskName.Focus()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Edit Error")
                Finally
                    GC.Collect()
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Val(dgvTask.Tag) = 0 Then
            MsgBox("Please select a task to delete.", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Are you sure you want to delete this task?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                Try
                    dbConnect()

                    Dim sql As String = My.Settings.queryDelete
                    Dim cmd As OdbcCommand = New OdbcCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@task_id", Val(dgvTask.Tag))

                    cmd.ExecuteNonQuery()
                    loadDGV(My.Settings.queryDisplay)
                    dgvTask.Tag = 0 'reset
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete Error")
                Finally
                    GC.Collect()
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        loadDGV(My.Settings.querySearch, "%" & tbSearch.Text & "%")
    End Sub
End Class
