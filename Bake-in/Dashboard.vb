Public Class Dashboard
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropPanel1.Size = DropPanel1.MinimumSize
        DropPanel2.Size = DropPanel2.MinimumSize

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Are you sure you want to log out?")
        Me.Close()
        Splash.Show()

    End Sub

    Private Sub SalesReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem1.Click
        salesreport.Show()
    End Sub

    Private Sub EnterNewOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterNewOrderToolStripMenuItem.Click
        Order_Management.Show()
    End Sub

    Private Sub AddNewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewItemToolStripMenuItem.Click
        Item_inventory.Show()
    End Sub

    Private Sub ItemReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemReportToolStripMenuItem.Click
        expensereport.Show()
    End Sub

    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem.Click
        Product_Inventory.Show()
    End Sub



    Private Sub UpdateCustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomerDetailsToolStripMenuItem.Click
        Customer_mnmgt.Show()
    End Sub

    Private Sub UpdateWasteDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateWasteDetailsToolStripMenuItem.Click
        Waste_Management.Show()
    End Sub

    Private Sub AddComplaintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddComplaintToolStripMenuItem.Click
        Complaint_mnmt.Show()
    End Sub

    Private Sub AddupdateEmpDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddupdateEmpDetailsToolStripMenuItem.Click
        Employee_Management.Show()
    End Sub

    Private Sub ProductReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductReportToolStripMenuItem.Click

    End Sub


    Private Sub CustomerReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReportToolStripMenuItem.Click
        custreport.Show()
    End Sub

    Private Sub WasteReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WasteReportToolStripMenuItem.Click
        wastereport.Show()
    End Sub

    Private Sub ComplaintReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplaintReportToolStripMenuItem.Click
        compreport.Show()
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        empreport.Show()
    End Sub

    Private Sub ItemINnvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemINnvToolStripMenuItem.Click

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        bakein_menu.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            DropPanel1.Height += 10
            If DropPanel1.Size = DropPanel1.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            DropPanel1.Height -= 10
            If DropPanel1.Size = DropPanel1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            DropPanel2.Height += 10
            If DropPanel2.Size = DropPanel2.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            DropPanel1.Height -= 10
            If DropPanel1.Size = DropPanel1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If

        End If
    End Sub

    Private Sub DropButton2_Click(sender As Object, e As EventArgs)
        isCollapsed = False

        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub DropButton1_Click(sender As Object, e As EventArgs)
        isCollapsed2 = False

        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class