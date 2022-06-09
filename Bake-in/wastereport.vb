
Imports System.Data.OleDb
Public Class wastereport
    Dim con As New OleDbConnection
    Dim daCust As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtCust As DataTable
    Private Sub wastereport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
        Dim sql As String = "select * from tb_waste"
        daCust = New OleDb.OleDbDataAdapter(sql, con)
        dtCust = New DataTable
        daCust.Fill(dtCust)
        dgvwaste.DataSource = dtCust
        con.Close()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If dgvwaste.Rows.Count = 0 Then
            Exit Sub
        End If

        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.5
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Count the Rows in the Bill



        Dim Rows As DataGridViewRowCollection = Me.dgvwaste.Rows


        'set Standard Width and Height
        Dim UnitWidth As Integer = 40
        Dim UnitHeight As Integer = 40

        Dim LeftMargin As Integer = 0
        Dim topMargin As Integer = 0


        ' Set the height of Bill Details part
        Dim ReciptDetailsHeight = Rows.Count * UnitHeight




        ' Standard Font
        Dim font As New Font("Times", 12)
        Dim fontB As New Font("Times", 12, FontStyle.Bold)

        Dim Fontbold As New Font("Times", 12, FontStyle.Bold)
        Dim FontboldHeader As New Font("Times", 16, FontStyle.Bold)


        'separate things for experiecne
        Dim TRecwidth As Integer = 300
        Dim Str As New StringFormat
        Str.Alignment = StringAlignment.Center
        Dim strLeft As New StringFormat
        strLeft.Alignment = StringAlignment.Near
        Dim strRight As New StringFormat
        strRight.Alignment = StringAlignment.Far

        'draw basic lines
        Dim YBillStart As Integer = 4 * UnitHeight

        'draw the headers
        Dim YHeaderStrat As Integer = YBillStart + (3 * UnitHeight)
        Dim YDetailsStart As Integer = YHeaderStrat + UnitHeight



        'Draw top rect
        Dim Rect As New Rectangle(LeftMargin + 0, topMargin + 0, TRecwidth, UnitHeight + 10)
        e.Graphics.DrawRectangle(Pens.White, Rect)
        Dim Rect1 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight, TRecwidth, UnitHeight)
        e.Graphics.DrawRectangle(Pens.White, Rect1)
        Dim Rect2 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 2, TRecwidth, UnitHeight * 3)
        e.Graphics.DrawRectangle(Pens.White, Rect2)
        Dim Rect3 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 4, TRecwidth, UnitHeight)
        e.Graphics.DrawRectangle(Pens.Black, Rect3)
        Dim Rect4 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 5, TRecwidth, UnitHeight)
        e.Graphics.DrawRectangle(Pens.Black, Rect4)

        Dim DtValue As String = Format(Now.Date, "MMM-dd-yyyy")

        'Write Recipt No. & Recipt Date & Company Name
        e.Graphics.DrawString("BAKE IN WASTE REPORT", FontboldHeader, Brushes.Black, Rect, Str)
        'e.Graphics.DrawString(TboxAddress.Text, Fontbold, Brushes.Black, Rect1, Str)
        'e.Graphics.DrawString(TboxPhone.Text, Fontbold, Brushes.Black, Rect2, Str)
        e.Graphics.DrawString("Date: " & DtValue, font, Brushes.Black, Rect4, strLeft)
        'e.Graphics.DrawString("Recipt No. " & receiptID, font, Brushes.Black, Rect3, strLeft)



        'Draw Black Line
        Dim Rect01 As New Rectangle(LeftMargin + UnitWidth * 0, topMargin + YHeaderStrat, UnitWidth * 1, UnitHeight)
        Dim Rect02 As New Rectangle(LeftMargin + UnitWidth * 1, topMargin + YHeaderStrat, UnitWidth * 6, UnitHeight)
        Dim Rect03 As New Rectangle(LeftMargin + UnitWidth * 7, topMargin + YHeaderStrat, UnitWidth * 2, UnitHeight)
        Dim Rect04 As New Rectangle(LeftMargin + UnitWidth * 9, topMargin + YHeaderStrat, UnitWidth * 2, UnitHeight)
        Dim Rect041 As New Rectangle(LeftMargin + UnitWidth * 11, topMargin + YHeaderStrat, UnitWidth * 2, UnitHeight)


        e.Graphics.DrawRectangle(Pens.Black, Rect01)
        e.Graphics.DrawRectangle(Pens.Black, Rect02)
        e.Graphics.DrawRectangle(Pens.Black, Rect03)
        e.Graphics.DrawRectangle(Pens.Black, Rect04)
        e.Graphics.DrawRectangle(Pens.Black, Rect041)

        'Fill Headers with Texts
        e.Graphics.DrawString("Sno", font, Brushes.Black, Rect01, Str)
        e.Graphics.DrawString("Product ID", font, Brushes.Black, Rect02, Str)
        e.Graphics.DrawString("Product Name", font, Brushes.Black, Rect03, Str)
        e.Graphics.DrawString("Qty", font, Brushes.Black, Rect04, Str)
        e.Graphics.DrawString("Date", font, Brushes.Black, Rect041, Str)
        '''




        'Draw the details part
        e.Graphics.DrawRectangle(Pens.Black, LeftMargin + UnitWidth * 0, topMargin + YDetailsStart, UnitWidth * 1, ReciptDetailsHeight)
        e.Graphics.DrawRectangle(Pens.Black, LeftMargin + UnitWidth * 1, topMargin + YDetailsStart, UnitWidth * 6, ReciptDetailsHeight)
        e.Graphics.DrawRectangle(Pens.Black, LeftMargin + UnitWidth * 7, topMargin + YDetailsStart, UnitWidth * 2, ReciptDetailsHeight)
        e.Graphics.DrawRectangle(Pens.Black, LeftMargin + UnitWidth * 9, topMargin + YDetailsStart, UnitWidth * 2, ReciptDetailsHeight)
        e.Graphics.DrawRectangle(Pens.Black, LeftMargin + UnitWidth * 11, topMargin + YDetailsStart, UnitWidth * 2, ReciptDetailsHeight)


        'final part is to render the text into the image
        Dim I As Integer
        For I = 0 To Rows.Count - 1
            'find the Y
            Dim Yloc = UnitHeight * I + YDetailsStart


            Dim Rect1g As New Rectangle(LeftMargin + UnitWidth * 0, topMargin + Yloc, UnitWidth * 1, UnitHeight)
            Dim Rect2g As New Rectangle(LeftMargin + UnitWidth * 1, topMargin + Yloc, UnitWidth * 2, UnitHeight)
            Dim Rect3g As New Rectangle(LeftMargin + UnitWidth * 7, topMargin + Yloc, UnitWidth * 2, UnitHeight)
            Dim Rect4g As New Rectangle(LeftMargin + UnitWidth * 9, topMargin + Yloc, UnitWidth * 2, UnitHeight)
            Dim Rect5g As New Rectangle(LeftMargin + UnitWidth * 11, topMargin + Yloc, UnitWidth * 2, UnitHeight)



            'Serial Number
            e.Graphics.DrawString(I + 1, font, Brushes.Black, Rect1g, Str)
            'Item Name
            e.Graphics.DrawString(Rows(I).Cells(0).Value, font, Brushes.Black, Rect2g, strLeft)
            'Qty
            e.Graphics.DrawString(Rows(I).Cells(1).Value, font, Brushes.Black, Rect3g, Str)
            'Price
            e.Graphics.DrawString(Rows(I).Cells(2).Value, font, Brushes.Black, Rect4g, Str)
            'Sum
            e.Graphics.DrawString(Rows(I).Cells(3).Value, font, Brushes.Black, Rect5g, Str)

        Next


        'Render Total Items
        Dim Rect4x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 4), TRecwidth, UnitHeight)
        e.Graphics.DrawString("Total Waste:  " & Rows.Count, font, Brushes.Black, Rect4x, strLeft)


        'Render the Total Bill Amount
        Dim Rect5 As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 5), TRecwidth, UnitHeight)
        e.Graphics.DrawRectangle(Pens.Black, Rect5)
        'Dim ReciptTotal As Decimal = txttotal.Text
        'e.Graphics.DrawString("Total Bill:  " & ReciptTotal, Fontbold, Brushes.Black, Rect5, Str)

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Waste_Management.Show()

    End Sub
End Class