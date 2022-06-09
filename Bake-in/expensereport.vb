Imports System.Data.OleDb
Public Class expensereport
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable
    Private Sub expensereport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvexp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvexp.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvexp.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvexp.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvexp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvexp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvexp.BorderStyle = BorderStyle.Fixed3D
        dgvexp.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvexp.EnableHeadersVisualStyles = False
        dgvexp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvexp.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvexp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvexp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvexp.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvexp.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvexp.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvexp.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvexp.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvexp.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvexp.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvexp.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvexp.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black




        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select * from tb_item"
        daCust = New OleDb.OleDbDataAdapter(sql, con)
        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgvexp.DataSource = dtCust
        con.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Item_inventory.Show()
    End Sub
End Class