
Imports System.Data.OleDb
Public Class waste2
    Dim con As New OleDbConnection
    Dim daWaste As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtWaste As DataTable

    Private Sub waste2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDOD.Format = DateTimePickerFormat.Custom
        dtpDOD.CustomFormat = " "


        'For DataGridView Style
        dgvWaste.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvWaste.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvWaste.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvWaste.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvWaste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvWaste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvWaste.BorderStyle = BorderStyle.Fixed3D
        dgvWaste.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvWaste.EnableHeadersVisualStyles = False
        dgvWaste.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvWaste.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvWaste.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvWaste.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvWaste.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvWaste.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvWaste.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvWaste.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvWaste.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvWaste.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvWaste.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvWaste.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvWaste.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black



        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim sql As String = "select prodID, pname, qty, DOE  from tb_prod "
        'MsgBox(sql)
        daWaste = New OleDb.OleDbDataAdapter(sql, con)

        dtWaste = New DataTable
        daWaste.Fill(dtWaste)
        dgvWaste.DataSource = dtWaste
        con.Close()

    End Sub


    Private Sub dtpDOD_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOD.ValueChanged
        dtpDOD.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.text = " "
            ElseIf TypeOf txt Is ComboBox Then
                txt.text = " "
            End If
        Next txt
        dtpDOD.CustomFormat = " "


    End Sub



    Private Sub dgvWaste_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvWaste.CellMouseClick
        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        txtProID.Text = dgvWaste.Rows().Item(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub dgvWaste_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWaste.CellClick
        Dim selectedWaste As DataGridViewRow
        selectedWaste = dgvWaste.Rows(e.RowIndex)
        txtProID.Text = selectedWaste.Cells(0).Value
        txtProNam.Text = selectedWaste.Cells(1).Value
        txtQuan.Text = selectedWaste.Cells(2).Value
        dtpDOD.Text = selectedWaste.Cells(3).Value
    End Sub



    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim sql As String = "insert into tb_waste( prodID, pname, qty , DOD) values ( " & txtProID.Text & "  ,
                            '" & txtProNam.Text & "' ," & txtQuan.Text & ",  
                            #" & dtpDOD.Value.Date & "#
                           )"
        cmd = New OleDbCommand()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
        cmd.CommandText = sql
        cmd.Connection = con
        con.Open()

        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully.", MessageBoxIcon.Information)
        daWaste.SelectCommand = New OleDbCommand("select prodID, pname, qty, doe from tb_prod", con)
        daWaste.SelectCommand.Connection = con
        dtWaste.Clear()
        daWaste.Fill(dtWaste)
        con.Close()
    End Sub

    Private Sub dgvWaste_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWaste.CellContentClick

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        Me.Close()
        Dashboard.Show()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        waste_search.Show()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

    End Sub
End Class

