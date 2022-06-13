''Public Class 
''    Private Sub (sender As Object, e As EventArgs) Handles MyBase.Load

''    End Sub
''End Class
'Imports System.Data.OleDb
'Public Class salesinvoice2
'    Dim con As New OleDbConnection
'    Dim daSales As New OleDbDataAdapter
'    Dim cmd As OleDbCommand
'    Dim dtSales As DataTable
'    Dim dtCust As DataTable
'    Dim dr As OleDbDataReader
'    Dim dsetSales As New DataSet
'    Dim salID As String
'    Dim id As String
'    Dim del As Integer
'    Dim index As Integer
'    Dim totalCost As Integer

'    Private Sub pCboItemNameLod()
'        cmbName.Items.Clear()
'        Dim connString As String
'        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
'        con = New OleDbConnection
'        con.ConnectionString = connString
'        If con.State = ConnectionState.Closed Then
'            con.Open()
'        End If

'        Dim sSql As String
'        sSql = "select pname from tb_prod"
'        cmd = New OleDbCommand(sSql, con)
'        dr = cmd.ExecuteReader
'        Dim cmbSource = New Dictionary(Of String, String)()


'        'While (dr.Read())
'        '    '    'cboItem.Items.Add(dr.Item("itemNam"))
'        '    cmbSource.Add(dr.Item("prodID"), dr.Item("pname"))
'        '    '    'cboItem.Items.Insert((dr.Item("itemID"), dr.Item("itemNam"))
'        'End While
'        'cmbName.DataSource = New BindingSource(cmbSource, Nothing)
'        'cmbName.DisplayMember = "Value"
'        'cmbName.ValueMember = "Key"





'        dr.Close()
'    End Sub

'    Private Sub salesinvoice2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


'        'dgv_i.Hide()
'        'lblTotal.Hide()
'        'txttotal.Hide()
'        'btnSave.Hide()
'        ''Dim qty As Integer

'        Dim connString As String
'        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
'        con = New OleDbConnection
'        con.ConnectionString = connString
'        If con.State = ConnectionState.Closed Then
'            con.Open()
'        End If


'        Call pCboItemNameLod()


'        dtSales = New DataTable
'        dtSales.Columns.Add("Product ID")
'        dtSales.Columns.Add("Product Name")
'        dtSales.Columns.Add("Cost per Product")
'        dtSales.Columns.Add("Quantity")
'        dtSales.Columns.Add("Cost")





'        con.Close()
'        Dim costItem As Integer
'        totalCost = 0


'        Dim sql As String = "select price from tb_prod where pname = '" & cmbName.SelectedValue & "'"
'        'MsgBox(sql)
'        cmd = New OleDbCommand()
'        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
'        cmd.CommandText = sql
'        cmd.Connection = con
'        If con.State = ConnectionState.Closed Then
'            con.Open()
'        End If
'        cmd.ExecuteNonQuery()
'        dr = cmd.ExecuteReader
'        dr.Read()

'        txtprice.Text = dr("price")

'        costItem = (txtprice.Text) * (txtqty.Text)

'        Dim R As DataRow = dtSales.NewRow

'        R("Product Name") = cmbName.Text
'        R("Cost per Product") = txtprice.Text
'        R("Quantity") = txtqty.Text
'        R("Cost") = costItem


'        Dim qty As Integer
'        Dim Ssql As String = "select qty from tb_prod where pname = '" & cmbName.SelectedValue & "'"
'        'MsgBox(Ssql)
'        cmd = New OleDbCommand()
'        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
'        cmd.CommandText = Ssql
'        cmd.Connection = con
'        If con.State = ConnectionState.Closed Then
'            con.Open()
'        End If
'        cmd.ExecuteNonQuery()
'        dr = cmd.ExecuteReader
'        dr.Read()
'        qty = dr.Item("qty")


'        If qty = 0 Then
'            MessageBox.Show("Out of Stock !!")
'        ElseIf qty < txtqty.Text Then
'            MessageBox.Show("Only " & qty & " products present !!")
'        Else
'            dtSales.Rows().Add(R)
'        End If

'        dgv_i.DataSource = dtSales


'        For Each row In dtSales.Rows
'            totalCost = totalCost + row("Cost")

'        Next
'        txttotal.Text = totalCost

'    End Sub

'    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

'        Dim ans As Integer
'        ans = MsgBox("Are you sure you want to insert ?", vbQuestion + vbYesNo, "Insertion")
'        If ans = vbYes Then



'            'for auto sales ID increment
'            Dim sql1 As String = "select Max(prodID) from tb_prod"
'            'MsgBox(sql1)
'            cmd = New OleDbCommand()
'            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
'            cmd.CommandText = sql1
'            cmd.Connection = con
'            If con.State = ConnectionState.Closed Then
'                con.Open()
'            End If
'            cmd.ExecuteNonQuery()
'            'dr = cmd.ExecuteReader
'            ''dr.Read()
'            'Dim ID As Integer
'            'Dim value As String
'            'value = cmd.ExecuteScalar().ToString()
'            'If String.IsNullOrEmpty(value) Then
'            '    value = "P001"
'            'End If

'            'value = value.Substring(1)
'            'Int32.TryParse(value, ID)
'            'ID = ID + 1
'            'value = "P" + ID.ToString("D3")
'            For i = 0 To dtSales.Rows.Count - 1


'                '' insert
'                'Dim Ssql1 As String = "insert into tbSales (salID, salName, salMob, salDate, itemID, salQnty, salCost)
'                '                            values('" & value & "','" & txtName.Text & "'," &
'                '                                    txtMob.Text & ",#" &
'                '                                    dtpSales.Value.Date & "#,'" &
'                '                                    dtSales.Rows(i).Item("Item ID") & "'," &
'                '                                    dtSales.Rows(i).Item("Quantity") & "," &
'                '                                    dtSales.Rows(i).Item("Cost") & ")"
'                'MsgBox(Ssql1)
'                cmd = New OleDbCommand()
'                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
'                'cmd.CommandText = Ssql1
'                'cmd.Connection = con
'                'If con.State = ConnectionState.Closed Then
'                '    con.Open()
'                'End If
'                'cmd.ExecuteNonQuery()

'                'Next
'                'quantity Update
'                Dim Ssql As String = "update tb_prod set qty = qty - " & dtSales.Rows(i).Item("Quantity") & " where prodID = '" & dtSales.Rows(i).Item("Product ID") & "'"
'                'MsgBox(Ssql)
'                cmd = New OleDbCommand()
'                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
'                cmd.CommandText = Ssql
'                cmd.Connection = con
'                If con.State = ConnectionState.Closed Then
'                    con.Open()
'                End If
'                cmd.ExecuteNonQuery()
'            Next

'            'txtName.Text = ""
'            'txtMob.Text = ""
'            'cboItem.Text = ""
'            'txtqty.Text = ""
'            'txttotal.Text = ""
'            'dgvSales.Dispose()


'        Else
'            Exit Sub
'        End If
'    End Sub

'    'Private Sub BtnAddCust_Click(sender As Object, e As EventArgs) Handles BtnAddCust.Click
'    '    grpBoxSaleEntry.Show()
'    '    dgvSales.Show()
'    '    lblTotal.Show()
'    '    txtTotal.Show()
'    '    btnSave.Show()

'    '    Dim R As DataRow = dtCust.NewRow
'    '    R("Customer Name") = txtName.Text
'    '    R("Mobile") = txtMob.Text
'    '    R("Date") = dtpSales.Value.Date
'    '    dtCust.Rows().Add(R)


'    'End Sub

'    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btn_add.Click
'        'Dim costItem As Integer
'        'totalCost = 0


'        'Dim sql As String = "select price from tb_prod where pname = '" & cmbName.SelectedValue & "'"
'        ''MsgBox(sql)
'        'cmd = New OleDbCommand()
'        'con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
'        'cmd.CommandText = sql
'        'cmd.Connection = con
'        'If con.State = ConnectionState.Closed Then
'        '    con.Open()
'        'End If
'        'cmd.ExecuteNonQuery()
'        'dr = cmd.ExecuteReader
'        'dr.Read()

'        'txtpriceperitem.Text = dr.Item("price")

'        'costItem = (txtpriceperitem.Text) * (txtqty.Text)

'        'Dim R As DataRow = dtSales.NewRow
'        'R("Product ID") = cmbProdID.SelectedValue
'        'R("Product Name") = cmbName.Text
'        'R("Cost per Product") = txtpriceperitem.Text
'        'R("Quantity") = txtqty.Text
'        'R("Cost") = costItem


'        'Dim qty As Integer
'        'Dim Ssql As String = "select qty from tb_prod where prodID = '" & cmbProdID.SelectedValue & "'"
'        ''MsgBox(Ssql)
'        'cmd = New OleDbCommand()
'        'con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
'        'cmd.CommandText = Ssql
'        'cmd.Connection = con
'        'If con.State = ConnectionState.Closed Then
'        '    con.Open()
'        'End If
'        'cmd.ExecuteNonQuery()
'        'dr = cmd.ExecuteReader
'        'dr.Read()
'        'qty = dr.Item("qty")


'        'If qty = 0 Then
'        '    MessageBox.Show("Out of Stock !!")
'        'ElseIf qty < txtqty.Text Then
'        '    MessageBox.Show("Only " & qty & " products present !!")
'        'Else
'        '    dtSales.Rows().Add(R)
'        'End If

'        'dgv_i.DataSource = dtSales


'        'For Each row In dtSales.Rows
'        '    totalCost = totalCost + row("Cost")

'        'Next
'        'txttotal.Text = totalCost

'    End Sub


'    'Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
'    '    dgvSales.Rows.RemoveAt(dgvSales.CurrentRow.Index)
'    '    'For Each row In dtSales.Rows
'    '    Dim cost As Integer
'    '    cost = del  'dgvSales.SelectedRows.Item(index).Cells(4).Value
'    '    'MessageBox.Show("Cost" & cost)
'    '    totalCost = txtTotal.Text - cost
'    '    'MsgBox(totalCost)
'    '    'Next
'    '    txtTotal.Text = totalCost
'    'End Sub

'    Private Sub dgvSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_i.CellClick
'        ' Dim index As Integer
'        index = e.RowIndex
'        Dim selectedRow As DataGridViewRow
'        selectedRow = dgv_i.Rows(index)
'        cmbName.Text = selectedRow.Cells(1).Value.ToString
'        txtqty.Text = selectedRow.Cells(3).Value.ToString
'    End Sub

'    Private Sub dgvSales_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_i.CellMouseClick
'        Dim connString As String
'        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
'        con = New OleDbConnection
'        con.ConnectionString = connString
'        If con.State = ConnectionState.Closed Then
'            con.Open()
'        End If

'        'del = dg.Rows().Item(e.RowIndex).Cells(4).Value ' for deletion
'        'MsgBox(del)
'    End Sub

'    Private Sub dgv_i_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_i.CellContentClick

'    End Sub
'End Class