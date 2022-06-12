
Imports System.Data.OleDb
Public Class Customer_mnmgt
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable

    Private Sub Customer_mngmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView1 Style
        dgv_cust.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgv_cust.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_cust.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgv_cust.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgv_cust.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_cust.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_cust.BorderStyle = BorderStyle.Fixed3D
        dgv_cust.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgv_cust.EnableHeadersVisualStyles = False
        dgv_cust.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_cust.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgv_cust.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgv_cust.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_cust.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgv_cust.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgv_cust.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_cust.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgv_cust.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv_cust.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgv_cust.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_cust.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgv_cust.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        'GridColor: Gray, Background Color: LavenderBlush,  row header width size mode : AutoSizeToAllHeaders, row template > Height : 25 = do manually

        'For DataGridView2 Style
        dgvcust2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvcust2.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcust2.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvcust2.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvcust2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvcust2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvcust2.BorderStyle = BorderStyle.Fixed3D
        dgvcust2.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvcust2.EnableHeadersVisualStyles = False
        dgvcust2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvcust2.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvcust2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvcust2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvcust2.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvcust2.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvcust2.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcust2.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvcust2.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvcust2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvcust2.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcust2.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvcust2.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = " "

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'For Dgv1
        Dim sql As String = "select custID1, custname1, gender1, dob1, phno1, add1 from tb_order"
        MsgBox(sql)
        daCust = New OleDbDataAdapter(sql, con)
        'Dim ds As New DataSet
        'daCust.Fill(ds, "tb_order")
        'dgv_cust.DataMember = "tb_order"
        'dgv_cust.Columns(0).ReadOnly = True

        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgv_cust.DataSource = dtCust
        con.Close()


        'For Dgv2
        Dim sql2 As String = "SELECT * FROM tb_cust"
        MsgBox(sql2)
        daCust = New OleDb.OleDbDataAdapter(sql2, con)
        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgvcust2.DataSource = dtCust
        con.Close()

    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs)




    '    If MsgBox("Are you sure you want to update this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Document") = DialogResult.Yes Then

    '        Dim sSql As String = "update tb_cust set custname = '" & txtCustName.Text & "', 
    '        gender =  '" & cmbGender.SelectedItem & "' , dob = #" & dtpDOB.Value.Date & "#, phone = " & Double.Parse(txtPhno.Text) & ", address = '" & txtAdd.Text & "' where custID = " & txtcustID.Text & " "

    '        MsgBox(sSql)
    '        cmd = New OleDbCommand()
    '        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
    '        cmd.CommandText = sSql
    '        cmd.Connection = con
    '        If con.State = ConnectionState.Closed Then
    '            con.Open()
    '        End If
    '        cmd.ExecuteNonQuery()
    '        daCust.SelectCommand = New OleDbCommand("select * from tb_prod")
    '        daCust.SelectCommand.Connection = con
    '        dtCust.Clear()
    '        daCust.Fill(dtCust)
    '        dgvcust2.DataSource = dtCust

    '    End If

    '    MsgBox("Record updated successfully!!!", MessageBoxIcon.Information)
    '    con.Close()

    'End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.text = " "
            ElseIf TypeOf txt Is ComboBox Then
                txt.text = " "
            End If
        Next txt
        dtpDOB.CustomFormat = " "

    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        dtpDOB.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub dgvcust_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cust.CellClick
        Dim selectedGR As DataGridViewRow
        selectedGR = dgv_cust.Rows(e.RowIndex)
        txtcustID.Text = selectedGR.Cells(0).Value
        txtCustName.Text = selectedGR.Cells(1).Value
        cmbGender.Text = selectedGR.Cells(2).Value
        dtpDOB.Text = selectedGR.Cells(3).Value
        txtPhno.Text = selectedGR.Cells(4).Value
        txtAdd.Text = selectedGR.Cells(5).Value

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure to delete this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Document") = DialogResult.Yes Then
            Dim sql1 As String = "delete from tb_cust where custID = " & txtcustID.Text

            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sql1
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()

            daCust.SelectCommand = New OleDbCommand("select * from tb_cust")
            daCust.SelectCommand.Connection = con
            dtCust.Clear()
            daCust.Fill(dtCust)
            dgvcust2.DataSource = dtCust
        End If
        MsgBox("Record deleted successfully!!!", MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub dgvcust_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_cust.CellMouseClick
        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        txtcustID.Text = dgv_cust.Rows().Item(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click




        Dim sql3 As String = "insert into tb_cust values(" & txtcustID.Text & ", '" & txtCustName.Text & "', '" & cmbGender.SelectedItem & "', #" & dtpDOB.Value.Date & "#, " & Double.Parse(txtPhno.Text) & ", '" & txtAdd.Text & "')"
        MessageBox.Show(sql3)
        cmd = New OleDbCommand
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
        cmd.CommandText = sql3
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        'daCust.SelectCommand = New OleDbCommand("select orderID , custID, phno, type, dop, phno, add , desc from tb_order")
        daCust.SelectCommand = New OleDbCommand("select * from tb_cust")
        daCust.SelectCommand.Connection = con
        dtCust.Clear()
        daCust.Fill(dtCust)
        MsgBox("Record Inserted successfully!!!", MessageBoxIcon.Information)
        con.Close()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Cust_search.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub dgvcust2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcust2.CellClick
        Dim selectedGR As DataGridViewRow
        selectedGR = dgvcust2.Rows(e.RowIndex)
        txtcustID.Text = selectedGR.Cells(0).Value
        txtCustName.Text = selectedGR.Cells(1).Value
        cmbGender.Text = selectedGR.Cells(2).Value
        dtpDOB.Text = selectedGR.Cells(3).Value
        txtPhno.Text = selectedGR.Cells(4).Value
        txtAdd.Text = selectedGR.Cells(5).Value
    End Sub

    Private Sub dgvcust2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcust2.CellContentClick

    End Sub





End Class