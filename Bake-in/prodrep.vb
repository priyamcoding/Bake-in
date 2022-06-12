'Public Class 
'    Private Sub (sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class

Imports System.Data.OleDb
Public Class prodrep
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable
    Private Sub prodrep_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'For DataGridView Style
        dgvwaste.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvwaste.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvwaste.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvwaste.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvwaste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvwaste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvwaste.BorderStyle = BorderStyle.Fixed3D
        dgvwaste.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvwaste.EnableHeadersVisualStyles = False
        dgvwaste.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvwaste.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvwaste.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvwaste.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvwaste.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvwaste.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvwaste.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvwaste.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvwaste.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvwaste.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvwaste.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvwaste.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvwaste.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black




        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select * from tb_prod"
        daCust = New OleDb.OleDbDataAdapter(sql, con)
        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgvwaste.DataSource = dtCust
        con.Close()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs)
        If dgvwaste.Rows.Count = 0 Then
            Exit Sub
        End If

        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.5
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub



    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        waste2.Show()

    End Sub
End Class