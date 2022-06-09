

Imports System.Data.OleDb
Public Class empreport
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable
    Private Sub empreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvemp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvemp.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvemp.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvemp.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvemp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvemp.BorderStyle = BorderStyle.Fixed3D
        dgvemp.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvemp.EnableHeadersVisualStyles = False
        dgvemp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvemp.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvemp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvemp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvemp.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvemp.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvemp.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvemp.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvemp.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvemp.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvemp.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvemp.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvemp.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black




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
        dgvemp.DataSource = dtCust
        con.Close()
    End Sub
End Class