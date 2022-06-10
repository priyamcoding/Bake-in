'Public Class waste_search
'    Private Sub waste_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class
Imports System.Data.OleDb
Public Class waste_search
    Dim con As New OleDbConnection
    Dim daItem As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtItem As DataTable
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        waste2.Show()
    End Sub

    Private Sub ItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvWasteSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvWasteSearch.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvWasteSearch.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvWasteSearch.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvWasteSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvWasteSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvWasteSearch.BorderStyle = BorderStyle.Fixed3D
        dgvWasteSearch.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvWasteSearch.EnableHeadersVisualStyles = False
        dgvWasteSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvWasteSearch.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvWasteSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvWasteSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvWasteSearch.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvWasteSearch.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvWasteSearch.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvWasteSearch.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvWasteSearch.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvWasteSearch.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvWasteSearch.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvWasteSearch.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvWasteSearch.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim sql As String = "select * from tb_waste where pname ='" & txtItemTitleSearch.Text & "'"
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
        dgvWasteSearch.DataSource = dtItem
        'dgvItemSearch.Columns(4).Width = 300

        con.Close()

    End Sub
End Class

