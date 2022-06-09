Imports System.Data.OleDb
Public Class Product_Inventory
    Dim con As New OleDbConnection
    Dim daPro As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dtPro As DataTable

    Private Sub Product_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDOC.Format = DateTimePickerFormat.Custom
        dtpDOC.CustomFormat = " "

        dtpDOE.Format = DateTimePickerFormat.Custom
        dtpDOE.CustomFormat = " "


        'For DataGridView Style
        dgvpro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvpro.AlternatingRowsDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvpro.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvpro.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvpro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvpro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvpro.BorderStyle = BorderStyle.Fixed3D
        dgvpro.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvpro.EnableHeadersVisualStyles = False
        dgvpro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvpro.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        dgvpro.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 60, 79)
        dgvpro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvpro.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 60, 79)
        dgvpro.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgvpro.DefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvpro.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvpro.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvpro.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        dgvpro.RowHeadersDefaultCellStyle.Font = New Font("Century Gothic", 9)
        dgvpro.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White
        dgvpro.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

        'GridColor, Background Color, row header width size mode : AutoSizeToAllHeaders, row template > Height : 25 = do manually


        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String = "select * from tb_prod"
        daPro = New OleDb.OleDbDataAdapter(sql, con)
        dtPro = New DataTable
        daPro.Fill(dtPro)
        dgvpro.DataSource = dtPro
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim s As Boolean
        If rbRef_yes.Checked = True Then

            s = True
        ElseIf rbRef_no.Checked = True Then
            s = False

        End If

        Dim sql As String = "insert into tb_prod( pname, cat, qty , type,  price, doc, doe, ref ) values ( '" & txtProdName.Text & "' ,
                            '" & cmbCategory.SelectedItem & "' ," & txtqty.Text & ",  '" & cmbOrd.SelectedItem & "' , " & txtLisPrc.Text & ",
                            #" & dtpDOC.Value.Date & "#, 
                            #" & dtpDOE.Value.Date & "#, '" & s & "')"
        cmd = New OleDbCommand()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maneesh\\source\\repos\\dbBakeIn.accdb")
        cmd.CommandText = sql
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        daPro.SelectCommand = New OleDbCommand("select * from tb_prod")
        daPro.SelectCommand.Connection = con
        dtPro.Clear()
        daPro.Fill(dtPro)
        con.Close()


    End Sub

    Private Sub dtpDOC_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOC.ValueChanged
        dtpDOC.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub dtpDOE_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOE.ValueChanged
        dtpDOE.CustomFormat = "dd-MMM-yyyy"
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
        dtpDOC.CustomFormat = " "
        dtpDOE.CustomFormat = " "
        rbRef_no.Checked = False
        rbRef_yes.Checked = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you sure to delete this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Document") = DialogResult.Yes Then
            Dim sql As String = "delete from tb_prod where prodID = " & txtProdID.Text

            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()

            daPro.SelectCommand = New OleDbCommand("select * from tb_prod")
            daPro.SelectCommand.Connection = con
            dtPro.Clear()
            daPro.Fill(dtPro)
            dgvpro.DataSource = dtPro
        End If
        MsgBox("Record deleted successfully!!!", MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub dgvpro_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvpro.CellMouseClick
        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        con = New OleDbConnection
        con.ConnectionString = connString
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        txtProdID.Text = dgvpro.Rows().Item(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub dgvpro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpro.CellClick
        Dim selectPRO As DataGridViewRow
        selectPRO = dgvpro.Rows(e.RowIndex)
        txtProdID.Text = selectPRO.Cells(0).Value
        txtProdName.Text = selectPRO.Cells(1).Value
        cmbCategory.Text = selectPRO.Cells(2).Value
        txtqty.Text = selectPRO.Cells(3).Value
        cmbOrd.Text = selectPRO.Cells(4).Value
        txtLisPrc.Text = selectPRO.Cells(5).Value
        dtpDOC.Text = selectPRO.Cells(6).Value
        dtpDOE.Text = selectPRO.Cells(7).Value

        If selectPRO.Cells(8).Value = "True" Then
            rbRef_yes.Checked = True

        Else
            rbRef_no.Checked = True

        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        prod_search.Show()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim s As Boolean
        If rbRef_yes.Checked = True Then

            s = True
        ElseIf rbRef_no.Checked = True Then
            s = False

        End If
        If MsgBox("Are you sure you want to update this entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Document") = DialogResult.Yes Then

            Dim sSql As String = "update tb_prod set pname = '" & txtProdName.Text & "' , 
            cat =  '" & cmbCategory.SelectedItem & "' , qty = " & txtqty.Text & ", type = '" & cmbOrd.Text & "', price = " & txtLisPrc.Text & ", doc = #" & dtpDOC.Value.Date & "#,
            doe = #" & dtpDOE.Value.Date & "# , ref = '" & s & "' where prodID = " & txtProdID.Text & " "

            MsgBox(sSql)
            cmd = New OleDbCommand()
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb")
            cmd.CommandText = sSql
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            daPro.SelectCommand = New OleDbCommand("select * from tb_prod")
            daPro.SelectCommand.Connection = con
            dtPro.Clear()
            daPro.Fill(dtPro)
            dgvpro.DataSource = dtPro

        End If

        MsgBox("Record updated successfully!!!", MessageBoxIcon.Information)
        con.Close()

    End Sub
End Class
