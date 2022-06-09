
Imports System.Data.OleDb
Public Class compreport
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable
    Private Sub compreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvcomp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvcomp.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcomp.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvcomp.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvcomp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvcomp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvcomp.BorderStyle = BorderStyle.Fixed3D
        dgvcomp.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvcomp.EnableHeadersVisualStyles = False
        dgvcomp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvcomp.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvcomp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvcomp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvcomp.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvcomp.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvcomp.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcomp.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvcomp.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvcomp.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvcomp.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcomp.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvcomp.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        'GridColor: Gray, Background Color: LavenderBlush,  row header width size mode : AutoSizeToAllHeaders, row template > Height : 25 = do manually


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
        dgvcomp.DataSource = dtCust
        con.Close()
    End Sub

    Private Sub dgvcomp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcomp.CellContentClick

    End Sub
End Class