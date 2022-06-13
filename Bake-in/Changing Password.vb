Imports System.Data.OleDb


Public Class Changing_Password
    Dim read As String
    Dim datafile As String
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand

    Dim dbcon As New OleDbConnection
    Private Sub Changing_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        dbcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\maneesh\source\repos\dbBakeIn.accdb"

        dbcon.Open()

        Dim sql1 As String
        If (txtNewPass.Text = "" And txtRepNewPass.Text = "") Then


            MessageBox.Show("all information required")


        ElseIf (txtNewPass.Text <> txtRepNewPass.Text) Then

            MessageBox.Show("new password and confirm password didn't match")

        Else

            'new statement - trying 
            sql1 = "update tb_login set password1=" & txtNewPass.Text & " , secans = '" & txtSecAns.Text & "' where userID='" & userid.Text & "'"
            'end of new statement 

            'MessageBox.Show(sql1)
            cmd = New OleDbCommand(sql1, dbcon)
            cmd.ExecuteNonQuery()

            MsgBox("Record Updated successfully!!!", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub changepassword_Closed(sender As Object, e As EventArgs) Handles Me.Closed


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Login.Show()



    End Sub



End Class