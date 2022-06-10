Public Class Splash2
    Dim a As Integer

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ("Please Wait for a moment")
        Label2.Text = "Completed " & ProgressBar1.Value & "%"
        ProgressBar1.ForeColor = Color.RosyBrown
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 2
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
                Me.Hide()
                Dashboard.Show()
            End If
        End If
    End Sub

    Private Sub Splash2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class