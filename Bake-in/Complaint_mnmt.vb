Imports System.Data.OleDb
Public Class Complaint_mnmt
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable


    Private Sub Complaint_mnmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DateTimePicker Formatting
        dtpDOO.Format = DateTimePickerFormat.Custom
        dtpDOO.CustomFormat = " "


        'For DataGridView Style
        dgvComp1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvComp1.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvComp1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvComp1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvComp1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvComp1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvComp1.BorderStyle = BorderStyle.Fixed3D
        dgvComp1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvComp1.EnableHeadersVisualStyles = False
        dgvComp1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvComp1.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvComp1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvComp1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvComp1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvComp1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvComp1.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvComp1.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvComp1.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvComp1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvComp1.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvComp1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvComp1.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        'GridColor: Gray, Background Color: LavenderBlush,  row header width size mode : AutoSizeToAllHeaders, row template > Height : 25 = do manually

        'For DataGridView2 Style
        dgvComp2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvComp2.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvComp2.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvComp2.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvComp2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvComp2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvComp2.BorderStyle = BorderStyle.Fixed3D
        dgvComp2.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvComp2.EnableHeadersVisualStyles = False
        dgvComp2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvComp2.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvComp2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvComp2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvComp2.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvComp2.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvComp2.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvComp2.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvComp2.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvComp2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvComp2.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvComp2.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvComp2.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'For Dgv1
        Dim sql As String = "SELECT orderID, custID1, phno1, dop1, add1 FROM tb_order"
        'MsgBox(sql)
        daCust = New OleDb.OleDbDataAdapter(sql, con)
        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgvComp1.DataSource = dtCust
        con.Close()

        'For Dgv2
        Dim sql2 As String = "SELECT * FROM tb_compl"
        'MsgBox(sql2)
        daCust = New OleDb.OleDbDataAdapter(sql2, con)
        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgvComp2.DataSource = dtCust
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.text = " "
            ElseIf TypeOf txt Is ComboBox Then
                txt.text = " "
            End If
        Next txt
        dtpDOO.CustomFormat = " "
        rbCRno.Checked = False
        rbCRyes.Checked = False
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim s As Boolean
        If rbCRyes.Checked = True Then
            s = True
        ElseIf rbCRno.Checked = True Then
            s = False
        End If

        'Dim sql3 As String = "insert into tb_compl(orderID, custID, Phone, dop, ComplRes, Address, desc) values(" & txtOrderID.Text & ", " & txtCustID.Text & ", " & Double.Parse(txtPhno.Text) & ", #" & dtpDOO.Value.Date & "#, '" & s & "', '" & txtAdd.Text & "', '" & txtDesc.Text & "')"
        Dim sql3 As String = "insert into tb_compl values(" & txtOrderID.Text & ", " & txtCustID.Text & ", " & Double.Parse(txtPhno.Text) & ", #" & dtpDOO.Value.Date & "#, '" & s & "', '" & txtAdd.Text & "', '" & txtDesc.Text & "')"
        MessageBox.Show(sql3)
        cmd = New OleDbCommand
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
        cmd.CommandText = sql3
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        'daCust.SelectCommand = New OleDbCommand("select orderID , custID, phno, type, dop, phno, add , desc from tb_order")
        daCust.SelectCommand = New OleDbCommand("select * from tb_compl")
        daCust.SelectCommand.Connection = con
        dtCust.Clear()
        daCust.Fill(dtCust)
        MsgBox("Record Inserted successfully!!!", MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub dtpDOO_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOO.ValueChanged
        dtpDOO.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure to delete this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Document") = DialogResult.Yes Then
            Dim sql As String = "delete from tb_compl where orderID = " & txtOrderID.Text

            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()

            daCust.SelectCommand = New OleDbCommand("select * from tb_compl")
            daCust.SelectCommand.Connection = con
            dtCust.Clear()
            daCust.Fill(dtCust)
            dgvComp2.DataSource = dtCust
        End If
        MsgBox("Record deleted successfully!!!", MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub dgvcust_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvComp1.CellMouseClick
        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        txtOrderID.Text = dgvComp1.Rows().Item(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub dgvcust_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComp1.CellClick
        Dim selectedGR As DataGridViewRow
        selectedGR = dgvComp1.Rows(e.RowIndex)
        txtOrderID.Text = selectedGR.Cells(0).Value
        txtCustID.Text = selectedGR.Cells(1).Value
        txtPhno.Text = selectedGR.Cells(2).Value
        dtpDOO.Text = selectedGR.Cells(3).Value

        'If selectedGR.Cells(4).Value = "True" Then
        '    rbCRyes.Checked = True

        'Else
        '    rbCRno.Checked = True

        'End If

        txtAdd.Text = selectedGR.Cells(4).Value
        'txtDesc.Text = selectedGR.Cells(6).Value

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        com_search.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub dgvComp2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComp2.CellContentClick

    End Sub

    Private Sub dgvComp1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComp1.CellContentClick

    End Sub
End Class