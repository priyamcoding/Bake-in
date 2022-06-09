

Imports System.Data.OleDb
Public Class custreport
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable
    Private Sub custreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView Style
        dgvcust.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvcust.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcust.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvcust.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvcust.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvcust.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvcust.BorderStyle = BorderStyle.Fixed3D
        dgvcust.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvcust.EnableHeadersVisualStyles = False
        dgvcust.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvcust.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvcust.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvcust.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvcust.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvcust.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvcust.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcust.DefaultCellStyle.ForeColor = Color.Black
        dgvcust.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvcust.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvcust.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvcust.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvcust.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvcust.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

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
        dgvcust.DataSource = dtCust
        con.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Customer_mnmgt.Show()
    End Sub
End Class