Imports System.Data.OleDb
Public Class Itemsearch
    Dim con As New OleDbConnection
    Dim daItem As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtItem As DataTable
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Item_inventory.Show()
    End Sub

    Private Sub ItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvItemSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvItemSearch.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvItemSearch.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvItemSearch.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvItemSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvItemSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvItemSearch.BorderStyle = BorderStyle.Fixed3D
        dgvItemSearch.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvItemSearch.EnableHeadersVisualStyles = False
        dgvItemSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvItemSearch.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvItemSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvItemSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvItemSearch.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvItemSearch.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvItemSearch.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvItemSearch.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvItemSearch.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvItemSearch.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvItemSearch.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvItemSearch.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvItemSearch.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "Select * from tb_item"
        daItem = New OleDbDataAdapter(sql, con)
        dtItem = New DataTable
        daItem.Fill(dtItem)
        cmd = New OleDbCommand(sql, con)
        cmbItemTitleSearch.DataSource = dtItem
        cmbItemTitleSearch.ValueMember = "iname"
        cmbItemTitleSearch.DisplayMember = "itemID"
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim sql As String = "select * from tb_item where iname ='" & cmbItemTitleSearch.SelectedValue.ToString & "'"
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
        dgvItemSearch.DataSource = dtItem
        dgvItemSearch.Columns(4).Width = 300

        con.Close()

    End Sub
End Class