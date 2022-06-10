
Imports System.Data.OleDb
Public Class Order_Management
    Dim con As New OleDbConnection
    Dim daOrd As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtOrd As DataTable


    Private Sub Order_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Working perfectly

        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = " "

        dtpDOP.Format = DateTimePickerFormat.Custom
        dtpDOP.CustomFormat = " "

        'For DataGridView Style
        dgvOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvOrder.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvOrder.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvOrder.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvOrder.BorderStyle = BorderStyle.Fixed3D
        dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvOrder.EnableHeadersVisualStyles = False
        dgvOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrder.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvOrder.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvOrder.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvOrder.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvOrder.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvOrder.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvOrder.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvOrder.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvOrder.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black



        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select * from tb_order"
        daOrd = New OleDb.OleDbDataAdapter(sql, con)
        dtOrd = New DataTable
        daOrd.Fill(dtOrd)
        dgvOrder.DataSource = dtOrd
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim s As Boolean
        If rbDelNeedYes.Checked = True Then

            s = True
        ElseIf rbDelNeedNo.Checked = True Then
            s = False

        End If
        Dim q As Boolean
        If rbMOPcod.Checked = True Then
            q = True
        ElseIf rbMOPonline.Checked = True Then
            q = False
        End If
        Dim r As Boolean
        If rbPayRecYes.Checked = True Then
            'MessageBox.Show("Yes")
            r = True
        ElseIf rbPayRecNo.Checked = True Then
            r = False
            'MessageBox.Show("No")
        End If

        Dim sql1 As String = "insert into tb_order(custID1, dop1, custname1, gender1, dob1, phno1, add1,  del1, mop1, payrec1) values (" & txtCustID.Text & ", #" & dtpDOP.Value.Date & "#, '" & txtNam.Text & "', '" & cmbGen.SelectedItem & "', #" & dtpDOB.Value.Date & "# , " & Double.Parse(txtPhone.Text) & ", '" & txtAddress.Text & "','" & s & "', '" & q & "', '" & r & "' )"
        cmd = New OleDbCommand()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
        cmd.CommandText = sql1
        MessageBox.Show(sql1)
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        daOrd.SelectCommand = New OleDbCommand("select * from tb_order")
        daOrd.SelectCommand.Connection = con
        dtOrd.Clear()
        daOrd.Fill(dtOrd)
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
        dtpDOB.CustomFormat = " "
        dtpDOP.CustomFormat = " "
        rbDelNeedNo.Checked = False
        rbDelNeedYes.Checked = False
        rbMOPcod.Checked = False
        rbMOPonline.Checked = False
        rbPayRecNo.Checked = False
        rbPayRecYes.Checked = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_showinv.Click
        sales_invoice.Show()
    End Sub



    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you sure to delete this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Document") = DialogResult.Yes Then
            Dim sql As String = "delete from tb_order where orderID = " & txtOrdID.Text

            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()

            daOrd.SelectCommand = New OleDbCommand("select * from tb_order")
            daOrd.SelectCommand.Connection = con
            dtOrd.Clear()
            daOrd.Fill(dtOrd)
            dgvOrder.DataSource = dtOrd
        End If
        MsgBox("Record deleted successfully!!!", MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub dgvOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellClick
        Dim selectORD As DataGridViewRow
        selectORD = dgvOrder.Rows(e.RowIndex)
        txtOrdID.Text = selectORD.Cells(0).Value
        txtCustID.Text = selectORD.Cells(1).Value
        dtpDOP.Text = selectORD.Cells(2).Value
        txtNam.Text = selectORD.Cells(3).Value
        cmbGen.Text = selectORD.Cells(4).Value
        dtpDOB.Text = selectORD.Cells(5).Value
        txtPhone.Text = selectORD.Cells(6).Value
        'txtAddress.Text = selectORD.Cells(7).Value

        If selectORD.Cells(8).Value = "True" Then
            rbPayRecYes.Checked = True

        Else
            rbPayRecNo.Checked = True

        End If

        If selectORD.Cells(9).Value = "True" Then
            rbMOPcod.Checked = True

        Else
            rbMOPonline.Checked = True

        End If


        If selectORD.Cells(10).Value = "True" Then
            rbDelNeedYes.Checked = True

        Else
            rbDelNeedNo.Checked = True

        End If
    End Sub

    Private Sub dtpDOP_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOP.ValueChanged
        dtpDOP.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        dtpDOB.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Dashboard.Show()
    End Sub
End Class

