'Public Class 
'    Private Sub prod_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class
'Public Class waste_search
'    Private Sub waste_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class
Imports System.Data.OleDb
Public Class prod_search
    Dim con As New OleDbConnection
    Dim daItem As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtItem As DataTable
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Product_Inventory.Show()
    End Sub

    Private Sub ItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvProductSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvProductSearch.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvProductSearch.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvProductSearch.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvProductSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvProductSearch.BorderStyle = BorderStyle.Fixed3D
        dgvProductSearch.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvProductSearch.EnableHeadersVisualStyles = False
        dgvProductSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvProductSearch.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvProductSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvProductSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvProductSearch.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvProductSearch.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvProductSearch.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvProductSearch.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvProductSearch.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvProductSearch.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvProductSearch.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvProductSearch.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvProductSearch.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim sql As String = "select * from tb_prod where pname ='" & txtItemTitleSearch.Text & "'"
        MsgBox(sql)
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
        dgvProductSearch.DataSource = dtItem
        'dgvItemSearch.Columns(4).Width = 300

        con.Close()

    End Sub
End Class

