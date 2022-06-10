Imports System.Data.OleDb
Public Class sales_invoice
    Dim con As New OleDbConnection
    Dim daSal As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtSal As DataTable
    Dim ds As DataSet
    Dim itemnumber As Integer = 1
    Dim receiptID As Integer = 1
    Dim dr As OleDbDataReader

    Private Sub sales_invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For DataGridView1 Style
        dgv_invoice.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgv_invoice.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_invoice.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgv_invoice.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgv_invoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_invoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_invoice.BorderStyle = BorderStyle.Fixed3D
        dgv_invoice.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgv_invoice.EnableHeadersVisualStyles = False
        dgv_invoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_invoice.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgv_invoice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgv_invoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_invoice.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgv_invoice.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgv_invoice.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_invoice.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgv_invoice.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv_invoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgv_invoice.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgv_invoice.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgv_invoice.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        'For DataGridView2 Style
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

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select pname, price from tb_prod"
        'MsgBox(sql)

        daSal = New OleDbDataAdapter(sql, con)
        Dim Qty As Decimal = Decimal.Parse(txtQty.Text)
        Dim price As Decimal = Decimal.Parse(txtPrice.Text)
        Dim sum = Qty * price
        dgv_invoice.Rows.Add(cmbName.SelectedItem, Qty, price, sum)
        itemnumber += 1

        Calculate_invoice_total()
        ClearBoxes()

    End Sub
    Private Sub ClearBoxes()
        txtQty.Clear()
        txtPrice.Clear()
        txtQty.Select()
    End Sub

    Private Sub Calculate_invoice_total()

        Dim sum As Decimal = 0
        For i As Integer = 0 To dgv_invoice.Rows.Count - 1
            sum += dgv_invoice.Rows(i).Cells(3).Value
        Next

        txttotal.Text = sum




    End Sub

    Private Sub btn_remline_Click(sender As Object, e As EventArgs) Handles btn_remline.Click
        If dgv_invoice.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        dgv_invoice.Rows.Remove(dgv_invoice.SelectedRows(0))
        Calculate_invoice_total()
    End Sub

    Private Sub btn_ClrAll_Click(sender As Object, e As EventArgs) Handles btn_ClrAll.Click
        dgv_invoice.Rows.Clear()
        ClearBoxes()
        itemnumber = 1
        txttotal.Text = 0

    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Order_Management.Show()

    End Sub



    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        'PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub dgv_invoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_invoice.CellContentClick

    End Sub

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim imagebmp As New Bitmap(Me.dgv_invoice.Width, Me.dgv_invoice.Height)
    '    e.Graphics.DrawImage(imagebmp, 0, 0)
    'End Sub
End Class