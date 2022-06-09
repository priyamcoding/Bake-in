Imports System.Data.OleDb
Public Class bakein_menu
    Dim con As New OleDbConnection
    Dim daSal As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtSal As DataTable
    Dim ds As DataSet
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgv_prod.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgv_prod.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_prod.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgv_prod.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgv_prod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_prod.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_prod.BorderStyle = BorderStyle.Fixed3D
        dgv_prod.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgv_prod.EnableHeadersVisualStyles = False
        dgv_prod.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_prod.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgv_prod.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgv_prod.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_prod.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgv_prod.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgv_prod.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_prod.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgv_prod.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv_prod.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgv_prod.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_prod.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgv_prod.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black


        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select pname, price from tb_prod"
        daSal = New OleDb.OleDbDataAdapter(sql, con)
        dtSal = New DataTable
        daSal.Fill(dtSal)
        dgv_prod.DataSource = dtSal
        con.Close()
    End Sub
End Class