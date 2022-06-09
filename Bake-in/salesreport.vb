Imports System.Data.OleDb
Public Class salesreport
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable
    Private Sub salesreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'For DataGridView Style
        dgvsales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvsales.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvsales.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvsales.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvsales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvsales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvsales.BorderStyle = BorderStyle.Fixed3D
        dgvsales.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvsales.EnableHeadersVisualStyles = False
        dgvsales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvsales.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvsales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvsales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvsales.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvsales.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvsales.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvsales.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvsales.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvsales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvsales.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvsales.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvsales.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black



        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select * from tb_order"
        daCust = New OleDb.OleDbDataAdapter(sql, con)
        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgvsales.DataSource = dtCust
        con.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Order_Management.Show()
    End Sub
End Class