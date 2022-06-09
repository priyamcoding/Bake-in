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
        dgv_prod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
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

    'Private Sub sales_invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim connString As String
    '    Dim dtSal As New DataTable
    '    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
    '    con = New OleDbConnection
    '    con.ConnectionString = connString
    '    If con.State = ConnectionState.Closed Then
    '        con.Open()
    '    End If
    '    Dim sql As String = "select pname, price from tb_prod"
    '    daSal = New OleDb.OleDbDataAdapter(sql, con)
    '    'Dim Ssql As String = "update tb_prod set qty = qty - " & dtSal.Columns(1).ColumnName("Qty") & " where itemID = '" & dtSal.Columns(0).ColumnName("pname") & "'"
    '    ''MsgBox(Ssql)
    '    'cmd = New OleDbCommand()
    '    'con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
    '    'cmd.CommandText = Ssql
    '    'cmd.Connection = con
    '    'If con.State = ConnectionState.Closed Then
    '    '    con.Open()
    '    'End If
    '    cmd.ExecuteNonQuery()


    '    'txtName.Text = ""
    '    'txtMob.Text = ""
    '    cmbName.Text = ""
    '    txtQty.Text = ""
    '    txttotal.Text = ""
    '    dgv_invoice.Dispose()
    '    'If cmbName.SelectedItem = "Blueberry Scones" Then
    '    '    txtPrice.Text = 250

    '    'End If
    '    'dtSal = New DataTable
    '    'daSal.Fill(dtSal)
    '    'dgv_invoice.DataSource = dtSal
    '    con.Close()
    'End Sub

    'changes made
    'Private Sub dgv_invoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_invoice.CellClick
    '    Dim index As Integer
    '    index = e.RowIndex
    '    Dim selectedRow As DataGridViewRow
    '    selectedRow = dgv_invoice.Rows(index)
    '    cmbName.Text = selectedRow.Cells(1).Value.ToString
    '    txtQty.Text = selectedRow.Cells(3).Value.ToString
    'End Sub
    'changes stopped

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select pname, price from tb_prod"
        MsgBox(sql)

        daSal = New OleDbDataAdapter(sql, con)
        Dim Qty As Decimal = Decimal.Parse(txtQty.Text)
        Dim price As Decimal = Decimal.Parse(txtPrice.Text)
        Dim sum = Qty * price

        'changes
        'Dim ans As Integer
        'ans = MsgBox("Are you sure you want to insert ?", vbQuestion + vbYesNo, "Insertion")

        'Dim sql1 As String = "select Max(prodID) from tb_prod"
        'Dim sql2 As String = "select price from tb_prod where pname = '" & cmbName.SelectedValue & "'"
        'dr = cmd.ExecuteReader
        'dr.Read()
        'txtPrice.Text = dr.Item("price")
        ''Dim sum = Qty * price
        ''dgv_invoice.Rows.Add("Product" & itemnumber, Qty, price, sum)
        dgv_invoice.Rows.Add(cmbName.SelectedItem, Qty, price, sum)
        itemnumber += 1
        'If cmbName.SelectedItem = "Blueberry Scones" Then
        '    txtPrice.Text = 250
        'End If

        'changes started 

        'Dim Ssql As String = "select qty from tb_prod where prodID = '" & cmbName.SelectedValue & "'"
        'MsgBox(Ssql)
        'cmd = New OleDbCommand()
        'con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
        'cmd.CommandText = Ssql
        'cmd.Connection = con
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        'End If
        'cmd.ExecuteNonQuery()
        'dr = cmd.ExecuteReader
        'dr.Read()
        'Qty = dr.Item("qty")
        'changes endded
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

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If dgv_invoice.Rows.Count = 0 Then
            Exit Sub
        End If
        receiptID += 1

        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.5
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        Me.Close()

    End Sub

    ''changes made
    'Private Sub dgv_invoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_invoice.CellClick
    '    Dim index As Integer
    '    index = e.RowIndex
    '    Dim selectedRow As DataGridViewRow
    '    selectedRow = dgv_invoice.Rows(index)
    '    cmbName.Text = selectedRow.Cells(1).Value.ToString
    '    txtQty.Text = selectedRow.Cells(3).Value.ToString
    'End Sub
    ''changes stopped

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Count the Rows in the Bill



        Dim Rows As DataGridViewRowCollection = Me.dgv_invoice.Rows


        'set Standard Width and Height
        Dim UnitWidth As Integer = 22
        Dim UnitHeight As Integer = 22

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
        Dim TRecwidth As Integer = 283
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
        'e.Graphics.DrawString(TboxShopName.Text, FontboldHeader, Brushes.Black, Rect, Str)
        'e.Graphics.DrawString(TboxAddress.Text, Fontbold, Brushes.Black, Rect1, Str)
        'e.Graphics.DrawString(TboxPhone.Text, Fontbold, Brushes.Black, Rect2, Str)
        e.Graphics.DrawString("Date: " & DtValue, font, Brushes.Black, Rect4, strLeft)
        e.Graphics.DrawString("Recipt No. " & receiptID, font, Brushes.Black, Rect3, strLeft)



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
        e.Graphics.DrawString("No", font, Brushes.Black, Rect01, Str)
        e.Graphics.DrawString("Item Name", font, Brushes.Black, Rect02, Str)
        e.Graphics.DrawString("Qty", font, Brushes.Black, Rect03, Str)
        e.Graphics.DrawString("Price", font, Brushes.Black, Rect04, Str)
        e.Graphics.DrawString("Sum", font, Brushes.Black, Rect041, Str)
        ''




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
            Dim Rect2g As New Rectangle(LeftMargin + UnitWidth * 1, topMargin + Yloc, UnitWidth * 6, UnitHeight)
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
        e.Graphics.DrawString("Total Items:  " & Rows.Count, font, Brushes.Black, Rect4x, strLeft)


        'Render the Total Bill Amount
        Dim Rect5 As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 5), TRecwidth, UnitHeight)
        e.Graphics.DrawRectangle(Pens.Black, Rect5)
        Dim ReciptTotal As Decimal = txttotal.Text
        e.Graphics.DrawString("Total Bill:  " & ReciptTotal, Fontbold, Brushes.Black, Rect5, Str)

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Order_Management.Show()

    End Sub










    'Private Sub sales_invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    Dim connString As String
    '    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
    '    con = New OleDbConnection
    '    con.ConnectionString = connString
    '    If con.State = ConnectionState.Closed Then
    '        con.Open()
    '    End If
    '    Dim sql As String = "select pname, price from tb_prod"
    '    daSal = New OleDb.OleDbDataAdapter(Sql, con)
    '    dtSal = New DataTable
    '    'dtSal.Columns.Add("Sno")
    '    'dtSal.Columns.Add("Product Name")
    '    'dtSal.Columns.Add("qty")
    '    'dtSal.Columns.Add("Price")

    '    'daSal.Fill(dtSal)
    '    dgv_invoice.DataSource = dtSal
    '    con.Close()
    'End Sub
End Class