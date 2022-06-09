<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ItemINnvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderMngtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderMnmtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterNewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesMnmtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WasteMngmtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateWasteDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WasteReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintMnmgtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddComplaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpMnmgtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddupdateEmpDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RosyBrown
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(8, 8, 8, 10)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemINnvToolStripMenuItem, Me.OrderMngtToolStripMenuItem, Me.OrderMnmtToolStripMenuItem, Me.SalesMnmtToolStripMenuItem, Me.WasteMngmtToolStripMenuItem, Me.ComplaintMnmgtToolStripMenuItem, Me.EmpMnmgtToolStripMenuItem, Me.MenuToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ItemINnvToolStripMenuItem
        '
        Me.ItemINnvToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewItemToolStripMenuItem, Me.ItemReportToolStripMenuItem})
        Me.ItemINnvToolStripMenuItem.Name = "ItemINnvToolStripMenuItem"
        Me.ItemINnvToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.ItemINnvToolStripMenuItem.Text = "Item inv"
        '
        'AddNewItemToolStripMenuItem
        '
        Me.AddNewItemToolStripMenuItem.Name = "AddNewItemToolStripMenuItem"
        Me.AddNewItemToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewItemToolStripMenuItem.Text = "add new item"
        '
        'ItemReportToolStripMenuItem
        '
        Me.ItemReportToolStripMenuItem.Name = "ItemReportToolStripMenuItem"
        Me.ItemReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ItemReportToolStripMenuItem.Text = "expense report"
        '
        'OrderMngtToolStripMenuItem
        '
        Me.OrderMngtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProductToolStripMenuItem, Me.ProductReportToolStripMenuItem})
        Me.OrderMngtToolStripMenuItem.Name = "OrderMngtToolStripMenuItem"
        Me.OrderMngtToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.OrderMngtToolStripMenuItem.Text = "Prod inv"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AddNewProductToolStripMenuItem.Text = "add new product"
        '
        'ProductReportToolStripMenuItem
        '
        Me.ProductReportToolStripMenuItem.Name = "ProductReportToolStripMenuItem"
        Me.ProductReportToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ProductReportToolStripMenuItem.Text = "product report"
        '
        'OrderMnmtToolStripMenuItem
        '
        Me.OrderMnmtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterNewOrderToolStripMenuItem, Me.SalesReportToolStripMenuItem1})
        Me.OrderMnmtToolStripMenuItem.Name = "OrderMnmtToolStripMenuItem"
        Me.OrderMnmtToolStripMenuItem.Size = New System.Drawing.Size(108, 21)
        Me.OrderMnmtToolStripMenuItem.Text = "Order mngmt"
        '
        'EnterNewOrderToolStripMenuItem
        '
        Me.EnterNewOrderToolStripMenuItem.Name = "EnterNewOrderToolStripMenuItem"
        Me.EnterNewOrderToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EnterNewOrderToolStripMenuItem.Text = "enter new order "
        '
        'SalesReportToolStripMenuItem1
        '
        Me.SalesReportToolStripMenuItem1.Name = "SalesReportToolStripMenuItem1"
        Me.SalesReportToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.SalesReportToolStripMenuItem1.Text = "sales report "
        '
        'SalesMnmtToolStripMenuItem
        '
        Me.SalesMnmtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateCustomerDetailsToolStripMenuItem, Me.CustomerReportToolStripMenuItem})
        Me.SalesMnmtToolStripMenuItem.Name = "SalesMnmtToolStripMenuItem"
        Me.SalesMnmtToolStripMenuItem.Size = New System.Drawing.Size(135, 21)
        Me.SalesMnmtToolStripMenuItem.Text = "Customer mngmt"
        '
        'UpdateCustomerDetailsToolStripMenuItem
        '
        Me.UpdateCustomerDetailsToolStripMenuItem.Name = "UpdateCustomerDetailsToolStripMenuItem"
        Me.UpdateCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.UpdateCustomerDetailsToolStripMenuItem.Text = "update customer details"
        '
        'CustomerReportToolStripMenuItem
        '
        Me.CustomerReportToolStripMenuItem.Name = "CustomerReportToolStripMenuItem"
        Me.CustomerReportToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.CustomerReportToolStripMenuItem.Text = "customer report"
        '
        'WasteMngmtToolStripMenuItem
        '
        Me.WasteMngmtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateWasteDetailsToolStripMenuItem, Me.WasteReportToolStripMenuItem})
        Me.WasteMngmtToolStripMenuItem.Name = "WasteMngmtToolStripMenuItem"
        Me.WasteMngmtToolStripMenuItem.Size = New System.Drawing.Size(110, 21)
        Me.WasteMngmtToolStripMenuItem.Text = "Waste Mngmt"
        '
        'UpdateWasteDetailsToolStripMenuItem
        '
        Me.UpdateWasteDetailsToolStripMenuItem.Name = "UpdateWasteDetailsToolStripMenuItem"
        Me.UpdateWasteDetailsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.UpdateWasteDetailsToolStripMenuItem.Text = "Update waste details"
        '
        'WasteReportToolStripMenuItem
        '
        Me.WasteReportToolStripMenuItem.Name = "WasteReportToolStripMenuItem"
        Me.WasteReportToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.WasteReportToolStripMenuItem.Text = "waste report"
        '
        'ComplaintMnmgtToolStripMenuItem
        '
        Me.ComplaintMnmgtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddComplaintToolStripMenuItem, Me.ComplaintReportToolStripMenuItem})
        Me.ComplaintMnmgtToolStripMenuItem.Name = "ComplaintMnmgtToolStripMenuItem"
        Me.ComplaintMnmgtToolStripMenuItem.Size = New System.Drawing.Size(114, 21)
        Me.ComplaintMnmgtToolStripMenuItem.Text = "Comp mnmgt"
        '
        'AddComplaintToolStripMenuItem
        '
        Me.AddComplaintToolStripMenuItem.Name = "AddComplaintToolStripMenuItem"
        Me.AddComplaintToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AddComplaintToolStripMenuItem.Text = "add complaint"
        '
        'ComplaintReportToolStripMenuItem
        '
        Me.ComplaintReportToolStripMenuItem.Name = "ComplaintReportToolStripMenuItem"
        Me.ComplaintReportToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ComplaintReportToolStripMenuItem.Text = "complaint report"
        '
        'EmpMnmgtToolStripMenuItem
        '
        Me.EmpMnmgtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddupdateEmpDetailsToolStripMenuItem, Me.EmployeeReportToolStripMenuItem})
        Me.EmpMnmgtToolStripMenuItem.Name = "EmpMnmgtToolStripMenuItem"
        Me.EmpMnmgtToolStripMenuItem.Size = New System.Drawing.Size(99, 21)
        Me.EmpMnmgtToolStripMenuItem.Text = "Emp Mnmgt"
        '
        'AddupdateEmpDetailsToolStripMenuItem
        '
        Me.AddupdateEmpDetailsToolStripMenuItem.Name = "AddupdateEmpDetailsToolStripMenuItem"
        Me.AddupdateEmpDetailsToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.AddupdateEmpDetailsToolStripMenuItem.Text = "add/update emp details"
        '
        'EmployeeReportToolStripMenuItem
        '
        Me.EmployeeReportToolStripMenuItem.Name = "EmployeeReportToolStripMenuItem"
        Me.EmployeeReportToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.EmployeeReportToolStripMenuItem.Text = "employee report"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.MenuToolStripMenuItem.Text = "Menu "
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        Me.Timer2.Interval = 15
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bake_in.My.Resources.Resources.priyamprojectbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ItemINnvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderMngtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderMnmtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesMnmtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WasteMngmtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComplaintMnmgtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpMnmgtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EnterNewOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateCustomerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateWasteDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WasteReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddComplaintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComplaintReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddupdateEmpDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
