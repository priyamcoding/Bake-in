
Imports System.Data.OleDb
Public Class Employee_Management
    Dim con As New OleDbConnection
    Dim daStu As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtStu As DataTable
    Dim ds As DataSet


    Private Sub Employee_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DateTimePicker
        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = " "

        dtpDOH.Format = DateTimePickerFormat.Custom
        dtpDOH.CustomFormat = " "


        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select * from tb_emp"
        daStu = New OleDb.OleDbDataAdapter(sql, con)
        dtStu = New DataTable
        daStu.Fill(dtStu)
        'For Datagridview Row Height
        'dgvEmp.RowTemplate.Height = 60
        dgvEmp.DataSource = dtStu
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Try
            Dim sql1 As String = "insert into tb_emp(empID, ename1, gender1, dob1, phno1, add1, doh1, email1, marital1, salary1, dept1, sup1, desg1, hours1) 
                            values (" & txtEmpID.Text & ", '" & txtNam.Text & "' , '" & cmbGender.SelectedItem & "' , 
                            #" & dtpDOB.Value.Date & "#, " & Double.Parse(txtPhn.Text) & ", '" & txtAddress.Text & "', 
                            #" & dtpDOH.Value.Date & "#, '" & txtMail.Text & "', '" & cmbMarStat.SelectedItem & "', 
                            " & txtSal.Text & " , '" & cmbDept.SelectedItem & "', '" & txtSpvr.Text & "', 
                            '" & cmbDesig.SelectedItem & "', " & txtWorkHour.Text & ")"
            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
            cmd.CommandText = sql1
            MessageBox.Show(sql1)
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            daStu.SelectCommand = New OleDbCommand("select * from tb_emp")
            daStu.SelectCommand.Connection = con
            dtStu.Clear()
            daStu.Fill(dtStu)
            MsgBox("Record Inserted successfully!!!", MessageBoxIcon.Information)
            con.Close()


        Catch ex As Exception
            MsgBox("Could not perform this task because " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        Finally
            con.Dispose()
        End Try




    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'con = New OleDbConnection
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        'Dim dr As OleDbDataReader

        'Try
        '    con.Open()
        '    Dim sql As String
        '    sql = "update tb_emp set empID = " & txtEmpID.Text & ", ename1 = '" & txtNam.Text & "' , gender1 =  '" & cmbGender.SelectedItem & "' , 
        '                    dob1 = #" & dtpDOB.Value.Date & "#, phno1 = " & Double.Parse(txtPhn.Text) & ", add1 = '" & txtAddress.Text & "', 
        '                    doh1 = #" & dtpDOH.Value.Date & "#, email1 = '" & txtMail.Text & "', marital1 = '" & cmbMarStat.SelectedItem & "', 
        '                    salary1 = " & txtSal.Text & " , dept1 = '" & cmbDept.SelectedItem & "', sup1 = '" & txtSpvr.Text & "', 
        '                    desg1 = '" & cmbDesig.SelectedItem & "', hours1 = " & txtWorkHour.Text & " where empID = " & txtEmpID.Text & " "
        '    cmd = New OleDbCommand(sql, con)
        '    dr = cmd.ExecuteReader
        '    cmd.ExecuteNonQuery()

        '    daStu.SelectCommand = New OleDbCommand("select * from tb_emp")
        '    daStu.SelectCommand.Connection = con
        '    dtStu.Clear()
        '    daStu.Fill(dtStu)
        '    dgvEmp.DataSource = dtStu

        '    MessageBox.Show("Data Updated Successfully.")
        '    con.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    con.Dispose()

        'End Try





        If MsgBox("Are you sure you want to update this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Document") = DialogResult.Yes Then

            Dim sSql As String = "update tb_emp set empID = " & txtEmpID.Text & ", ename1 = '" & txtNam.Text & "' , gender1 =  '" & cmbGender.SelectedItem & "' ,  dob1 = #" & dtpDOB.Value.Date & "#, phno1 = " & Double.Parse(txtPhn.Text) & ", add1 = '" & txtAddress.Text & "', doh1 = #" & dtpDOH.Value.Date & "#, email1 = '" & txtMail.Text & "', marital1 = '" & cmbMarStat.SelectedItem & "', salary1 = " & txtSal.Text & " , dept1 = '" & cmbDept.SelectedItem & "', sup1 = '" & txtSpvr.Text & "',  desg1 = '" & cmbDesig.SelectedItem & "', hours1 = " & txtWorkHour.Text & " where empID = " & txtEmpID.Text & " "

            MsgBox(sSql)
            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sSql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            daStu.SelectCommand = New OleDbCommand("select * from tb_emp")
            daStu.SelectCommand.Connection = con
            dtStu.Clear()
            daStu.Fill(dtStu)
            dgvEmp.DataSource = dtStu

        End If

        MsgBox("Record updated successfully!!!", MessageBoxIcon.Information)
        con.Close()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you sure to delete this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Document") = DialogResult.Yes Then
            Dim sql As String = "delete from tb_emp where empID = " & txtEmpID.Text

            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()

            daStu.SelectCommand = New OleDbCommand("select * from tb_emp")
            daStu.SelectCommand.Connection = con
            dtStu.Clear()
            daStu.Fill(dtStu)
            dgvEmp.DataSource = dtStu
        End If
        MsgBox("Record deleted successfully!!!", MessageBoxIcon.Information)
        con.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.text = " "
            ElseIf TypeOf txt Is ComboBox Then
                txt.text = " "
            End If
        Next txt
        dtpDOB.CustomFormat = " "
        dtpDOH.CustomFormat = " "


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to EXIT!!!", "DataGridView System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub dgvEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellClick
        Dim selectedGR As DataGridViewRow
        selectedGR = dgvEmp.Rows(e.RowIndex)
        txtEmpID.Text = selectedGR.Cells(0).Value
        txtNam.Text = selectedGR.Cells(1).Value
        cmbGender.Text = selectedGR.Cells(2).Value
        dtpDOB.Text = selectedGR.Cells(3).Value
        txtPhn.Text = selectedGR.Cells(4).Value
        txtAddress.Text = selectedGR.Cells(5).Value
        dtpDOH.Text = selectedGR.Cells(6).Value
        txtMail.Text = selectedGR.Cells(7).Value
        cmbMarStat.Text = selectedGR.Cells(8).Value
        txtSal.Text = selectedGR.Cells(9).Value
        cmbDept.Text = selectedGR.Cells(10).Value
        txtSpvr.Text = selectedGR.Cells(11).Value
        cmbDesig.Text = selectedGR.Cells(12).Value
        txtWorkHour.Text = selectedGR.Cells(13).Value
    End Sub

    Private Sub dgvEmp_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmp.CellMouseClick
        'Dim connString As String
        'connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        'con = New OleDbConnection
        'con.ConnectionString = connString
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        'End If

        txtEmpID.Text = dgvEmp.Rows().Item(e.RowIndex).Cells(0).Value


    End Sub



    Private Sub dtpDOH_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOH.ValueChanged
        dtpDOH.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        dtpDOB.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        empsearch.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Dashboard.Show()
    End Sub
End Class

