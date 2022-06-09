

Imports System.Data.OleDb
Public Class empsearch
    Dim con As New OleDbConnection
    Dim daItem As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtItem As DataTable
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Employee_Management.Show()
    End Sub

    Private Sub ItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvEmpSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvEmpSearch.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvEmpSearch.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvEmpSearch.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvEmpSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmpSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvEmpSearch.BorderStyle = BorderStyle.Fixed3D
        dgvEmpSearch.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvEmpSearch.EnableHeadersVisualStyles = False
        dgvEmpSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvEmpSearch.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvEmpSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvEmpSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvEmpSearch.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvEmpSearch.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvEmpSearch.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvEmpSearch.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvEmpSearch.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvEmpSearch.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvEmpSearch.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvEmpSearch.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvEmpSearch.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black


        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim sql As String = "select * from tb_emp where ename1 ='" & txtItemTitleSearch.Text & "'"
        'MsgBox(sql)
        cmd = New OleDbCommand()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
        cmd.CommandText = sql
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        cmd.ExecuteNonQuery()
        daItem = New OleDb.OleDbDataAdapter(sql, con)
        dtItem = New DataTable
        daItem.Fill(dtItem)

        daItem.SelectCommand = New OleDbCommand(sql)
        daItem.SelectCommand.Connection = con
        dtItem.Clear()
        daItem.Fill(dtItem)
        dgvEmpSearch.DataSource = dtItem
        'dgvItemSearch.Columns(4).Width = 300

        con.Close()

    End Sub
End Class

