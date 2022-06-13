
Imports System.Data.OleDb
Public Class Item_inventory
    Dim con As New OleDbConnection
    Dim daOrd As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtOrd As DataTable

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDOA.Format = DateTimePickerFormat.Custom
        dtpDOA.CustomFormat = " "

        dtpDOE.Format = DateTimePickerFormat.Custom
        dtpDOE.CustomFormat = " "

        'For DataGridView Style
        dgvitem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvitem.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvitem.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvitem.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvitem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvitem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvitem.BorderStyle = BorderStyle.Fixed3D
        dgvitem.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvitem.EnableHeadersVisualStyles = False
        dgvitem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvitem.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvitem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvitem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvitem.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvitem.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvitem.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvitem.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvitem.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvitem.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvitem.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvitem.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvitem.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select * from tb_item"
        daOrd = New OleDb.OleDbDataAdapter(sql, con)
        dtOrd = New DataTable
        daOrd.Fill(dtOrd)
        dgvitem.DataSource = dtOrd
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim s As Boolean
        If rbRefYes.Checked = True Then
            s = True
        ElseIf rbRefNo.Checked = True Then
            s = False
        End If
        Dim sql1 As String = "insert into tb_item(iname, cat, qty, price, ref, doa, doe)
                            values ( '" & txtName.Text & "','" & cmbCat.SelectedItem & "', " & txtQty.Text & ", 
                           " & txtPrice.Text & ",'" & s & "', #" & dtpDOA.Value.Date & "#, 
                             #" & dtpDOE.Value.Date & "# )"
        cmd = New OleDbCommand()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
        cmd.CommandText = sql1
        MessageBox.Show(sql1)
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        daOrd.SelectCommand = New OleDbCommand("select * from tb_item")
        daOrd.SelectCommand.Connection = con
        dtOrd.Clear()
        daOrd.Fill(dtOrd)
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.text = " "
            ElseIf TypeOf txt Is ComboBox Then
                txt.text = " "
            End If
        Next txt

        rbRefNo.Checked = False
        rbRefYes.Checked = False

        dtpDOA.CustomFormat = " "
        dtpDOE.CustomFormat = " "

    End Sub

    Private Sub dtpDOA_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOA.ValueChanged
        dtpDOA.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub dtpDOE_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOE.ValueChanged
        dtpDOE.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you sure to delete this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Document") = DialogResult.Yes Then
            Dim sql As String = "delete from tb_item where itemID = " & txtItemID.Text

            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()

            daOrd.SelectCommand = New OleDbCommand("select * from tb_item")
            daOrd.SelectCommand.Connection = con
            dtOrd.Clear()
            daOrd.Fill(dtOrd)
            dgvitem.DataSource = dtOrd
        End If
        MsgBox("Record deleted successfully!!!", MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub dgvitem_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvitem.CellMouseClick
        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        txtItemID.Text = dgvitem.Rows().Item(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub dgvitem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvitem.CellClick
        Dim selectItem As DataGridViewRow
        selectItem = dgvitem.Rows(e.RowIndex)
        txtItemID.Text = selectItem.Cells(0).Value
        txtName.Text = selectItem.Cells(1).Value
        cmbCat.Text = selectItem.Cells(2).Value
        txtQty.Text = selectItem.Cells(3).Value
        txtPrice.Text = selectItem.Cells(4).Value

        If selectItem.Cells(5).Value = "True" Then
            rbRefYes.Checked = True

        Else
            rbRefNo.Checked = True

        End If

        dtpDOA.Text = selectItem.Cells(6).Value
        dtpDOE.Text = selectItem.Cells(7).Value
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Itemsearch.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim s As Boolean
        If rbRefYes.Checked = True Then
            s = True
        ElseIf rbRefNo.Checked = True Then
            s = False
        End If

        Try
            Dim sSql As String = "update tb_item set [iname] = '" & txtName.Text & "', [cat] = '" & cmbCat.SelectedItem & "', [Qty] = " & txtQty.Text & ", 
                          [price] = " & txtPrice.Text & ", [ref] = '" & s & "', [DOA] = #" & dtpDOA.Value.Date & "#, 
                            [DOE] = #" & dtpDOE.Value.Date & "# where [itemID] = " & txtItemID.Text & " "


            MsgBox(sSql)
            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sSql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.ExecuteNonQuery()
            daOrd.SelectCommand = New OleDbCommand("select * from tb_item")
            daOrd.SelectCommand.Connection = con
            dtOrd.Clear()
            daOrd.Fill(dtOrd)
            dgvitem.DataSource = dtOrd
            MsgBox("Record Updated successfully!!!", MessageBoxIcon.Information)
            con.Close()


        Catch ex As Exception
            MsgBox("Could not perform this task because " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        Finally
            con.Dispose()
        End Try
    End Sub
End Class