'Public Class Cust_search
'    Private Sub Cust_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class
'Public Class waste_search
'    Private Sub waste_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class
Imports System.Data.OleDb
Public Class Cust_search
    Dim con As New OleDbConnection
    Dim daItem As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtItem As DataTable
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Customer_mnmgt.Show()
    End Sub

    Private Sub ItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvCustSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvCustSearch.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvCustSearch.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvCustSearch.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvCustSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvCustSearch.BorderStyle = BorderStyle.Fixed3D
        dgvCustSearch.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvCustSearch.EnableHeadersVisualStyles = False
        dgvCustSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvCustSearch.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvCustSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvCustSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvCustSearch.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvCustSearch.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvCustSearch.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvCustSearch.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvCustSearch.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvCustSearch.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvCustSearch.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvCustSearch.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvCustSearch.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black


        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim sql As String = "select * from tb_cust where custname ='" & txtItemTitleSearch.Text & "'"
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
        dgvCustSearch.DataSource = dtItem
        'dgvItemSearch.Columns(4).Width = 300

        con.Close()

    End Sub
End Class

