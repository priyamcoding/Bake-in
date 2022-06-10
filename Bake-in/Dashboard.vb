Public Class Dashboard
    Dim isCollapsed1 As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True
    Dim isCollapsed4 As Boolean = True
    Dim isCollapsed5 As Boolean = True
    Dim isCollapsed6 As Boolean = True
    Dim isCollapsed7 As Boolean = True


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        MsgBox("Are you sure you want to log out?")
        Me.Close()
        Splash.Show()

    End Sub

    Private Sub SalesReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        salesreport.Show()
    End Sub

    Private Sub EnterNewOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Order_Management.Show()
    End Sub

    Private Sub AddNewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Item_inventory.Show()
    End Sub

    Private Sub ItemReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        expensereport.Show()
    End Sub

    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Product_Inventory.Show()
    End Sub



    Private Sub UpdateCustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Customer_mnmgt.Show()
    End Sub

    Private Sub UpdateWasteDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        waste2.Show()
    End Sub

    Private Sub AddComplaintToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Complaint_mnmt.Show()
    End Sub

    Private Sub AddupdateEmpDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Employee_Management.Show()
    End Sub

    Private Sub ProductReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        prodrep.Show()
    End Sub


    Private Sub CustomerReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        custreport.Show()
    End Sub

    Private Sub WasteReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        wastereport.Show()
    End Sub

    Private Sub ComplaintReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        compreport.Show()
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        empreport.Show()
    End Sub

    Private Sub ItemINnvToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropPanel1Item.Size = dropPanel1Item.MinimumSize
        dropPanel2Prod.Size = dropPanel2Prod.MinimumSize
        dropPanel3Ord.Size = dropPanel3Ord.MinimumSize
        dropPanel4Cust.Size = dropPanel1Item.MinimumSize
        dropPanel5Comp.Size = dropPanel2Prod.MinimumSize
        dropPanel6Waste.Size = dropPanel3Ord.MinimumSize
        dropPanel7Emp.Size = dropPanel3Ord.MinimumSize
    End Sub

    Private Sub DropBtnItem_Click(sender As Object, e As EventArgs) Handles DropBtn1Item.Click
        isCollapsed2 = False
        isCollapsed3 = False
        isCollapsed4 = False
        isCollapsed5 = False
        isCollapsed6 = False
        isCollapsed7 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Item_inventory.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed1 Then
            PBInv.Image = My.Resources.down_arrow
            dropPanel1Item.Height += 10
            If dropPanel1Item.Size = dropPanel1Item.MaximumSize Then
                Timer1.Stop()
                isCollapsed1 = False
            End If
        Else
            PBInv.Image = My.Resources._next
            dropPanel1Item.Height -= 10
            If dropPanel1Item.Size = dropPanel1Item.MinimumSize Then
                Timer1.Stop()
                isCollapsed1 = True
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            PBprod.Image = My.Resources.down_arrow
            dropPanel2Prod.Height += 10
            If dropPanel2Prod.Size = dropPanel2Prod.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            PBprod.Image = My.Resources._next
            dropPanel2Prod.Height -= 10
            If dropPanel2Prod.Size = dropPanel2Prod.MinimumSize Then
                Timer2.Stop()
                isCollapsed2 = True
            End If

        End If
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If isCollapsed3 Then
            PBOrd.Image = My.Resources.down_arrow
            dropPanel3Ord.Height += 10
            If dropPanel3Ord.Size = dropPanel3Ord.MaximumSize Then
                Timer3.Stop()
                isCollapsed3 = False
            End If
        Else
            PBOrd.Image = My.Resources._next
            dropPanel3Ord.Height -= 10
            If dropPanel3Ord.Size = dropPanel3Ord.MinimumSize Then
                Timer3.Stop()
                isCollapsed3 = True
            End If

        End If
    End Sub



    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If isCollapsed4 Then
            PBCust.Image = My.Resources.down_arrow
            dropPanel4Cust.Height += 10
            If dropPanel4Cust.Size = dropPanel4Cust.MaximumSize Then
                Timer4.Stop()
                isCollapsed4 = False
            End If
        Else
            PBCust.Image = My.Resources._next
            dropPanel4Cust.Height -= 10
            If dropPanel4Cust.Size = dropPanel4Cust.MinimumSize Then
                Timer4.Stop()
                isCollapsed4 = True
            End If

        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If isCollapsed5 Then
            PBComp.Image = My.Resources.down_arrow
            dropPanel5Comp.Height += 10
            If dropPanel5Comp.Size = dropPanel5Comp.MaximumSize Then
                Timer5.Stop()
                isCollapsed5 = False
            End If
        Else

            PBComp.Image = My.Resources._next
            dropPanel5Comp.Height -= 10
            If dropPanel5Comp.Size = dropPanel5Comp.MinimumSize Then
                Timer5.Stop()
                isCollapsed5 = True
            End If

        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If isCollapsed6 Then
            pbWaste.Image = My.Resources.down_arrow
            dropPanel6Waste.Height += 10
            If dropPanel6Waste.Size = dropPanel6Waste.MaximumSize Then
                Timer6.Stop()
                isCollapsed6 = False
            End If
        Else
            pbWaste.Image = My.Resources._next
            dropPanel6Waste.Height -= 10
            If dropPanel6Waste.Size = dropPanel6Waste.MinimumSize Then
                Timer6.Stop()
                isCollapsed6 = True
            End If

        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If isCollapsed7 Then
            pbEmp.Image = My.Resources.down_arrow
            dropPanel7Emp.Height += 10
            If dropPanel7Emp.Size = dropPanel7Emp.MaximumSize Then
                Timer7.Stop()
                isCollapsed7 = False
            End If
        Else
            pbEmp.Image = My.Resources._next
            dropPanel7Emp.Height -= 10
            If dropPanel7Emp.Size = dropPanel7Emp.MinimumSize Then
                Timer7.Stop()
                isCollapsed7 = True
            End If

        End If
    End Sub

    Private Sub DropBtn2Prod_Click(sender As Object, e As EventArgs) Handles DropBtn2Prod.Click
        isCollapsed1 = False
        isCollapsed3 = False
        isCollapsed4 = False
        isCollapsed5 = False
        isCollapsed6 = False
        isCollapsed7 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
    End Sub

    Private Sub DropBtn3Ord_Click(sender As Object, e As EventArgs) Handles DropBtn3Ord.Click
        isCollapsed1 = False
        isCollapsed2 = False
        isCollapsed4 = False
        isCollapsed5 = False
        isCollapsed6 = False
        isCollapsed7 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
    End Sub

    Private Sub DropBtn4Cust_Click(sender As Object, e As EventArgs) Handles DropBtn4Cust.Click
        isCollapsed1 = False
        isCollapsed2 = False
        isCollapsed3 = False
        isCollapsed5 = False
        isCollapsed6 = False
        isCollapsed7 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
    End Sub


    Private Sub dropBtn7Emp_Click(sender As Object, e As EventArgs) Handles dropBtn7Emp.Click

        isCollapsed1 = False
        isCollapsed2 = False
        isCollapsed3 = False
        isCollapsed4 = False
        isCollapsed5 = False
        isCollapsed6 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
    End Sub

    Private Sub dropBtn6Waste_Click(sender As Object, e As EventArgs) Handles dropBtn6Waste.Click
        isCollapsed1 = False
        isCollapsed2 = False
        isCollapsed3 = False
        isCollapsed4 = False
        isCollapsed5 = False
        isCollapsed7 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
    End Sub

    Private Sub DropBtn5Comp_Click(sender As Object, e As EventArgs) Handles DropBtn5Comp.Click
        isCollapsed1 = False
        isCollapsed2 = False
        isCollapsed3 = False
        isCollapsed4 = False
        isCollapsed6 = False
        isCollapsed7 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        expensereport.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Product_Inventory.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        prodrep.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Order_Management.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        salesreport.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Customer_mnmgt.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        custreport.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Complaint_mnmt.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        compreport.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        waste2.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        wastereport.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Employee_Management.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        empreport.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PBCust.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit the Application?", "Sign Off", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.Exit()

        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        bakein_menu.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Changing_Password.Show()

    End Sub
End Class