
Imports System.Data.OleDb

Public Class Login
    Dim read As String
    Dim datafile As String
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim dbcon As OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        dbcon = New OleDbConnection
        dbcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"
        'dbcon.ConnectionString = connString
        dbcon.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from tb_login where userID = '" & txtUser.Text & "' and password1 = " & txtPass.Text & " ", dbcon)
        'MsgBox("Select * from tb_login where [userID] = ' " & TextBox1.Text & " ' and [password1] = " & TextBox2.Text & " ")

        Dim dr As OleDbDataReader = cmd.ExecuteReader


        Dim userfound As Boolean = False

        Dim Firstname1 As String = " "
        Dim Lastname1 As String = " "


        If dr.Read() Then
            userfound = True
            Firstname1 = dr("Firstname1").ToString
            Lastname1 = dr("Lastname1").ToString
        End If

        If userfound = True Then
            Dashboard.Show()
            Dashboard.Label1.Text = "Welcome" & " " & Firstname1 & " " & Lastname1
        Else
            MsgBox("Sorry!!! Credentials do not match.", MsgBoxStyle.OkOnly, "Invalid Login")

        End If

    End Sub

    'Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    '    If dbcon.State = ConnectionState.Open Then
    '        MessageBox.Show("Open")
    '    Else
    '        MessageBox.Show("Closed")
    '    End If
    'End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Changing_Password.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'first make password don't show
        If CheckBox1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            txtPass.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class