<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales_invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sales_invoice))
        Me.dgv_invoice = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_remline = New System.Windows.Forms.Button()
        Me.btn_ClrAll = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.invoice_heading = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.dgv_prod = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_invoice
        '
        Me.dgv_invoice.AllowUserToAddRows = False
        Me.dgv_invoice.AllowUserToDeleteRows = False
        Me.dgv_invoice.AllowUserToResizeColumns = False
        Me.dgv_invoice.AllowUserToResizeRows = False
        Me.dgv_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_invoice.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgv_invoice.ColumnHeadersHeight = 30
        Me.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_invoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_invoice.GridColor = System.Drawing.Color.Gray
        Me.dgv_invoice.Location = New System.Drawing.Point(82, 131)
        Me.dgv_invoice.MultiSelect = False
        Me.dgv_invoice.Name = "dgv_invoice"
        Me.dgv_invoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_invoice.RowTemplate.Height = 25
        Me.dgv_invoice.Size = New System.Drawing.Size(470, 295)
        Me.dgv_invoice.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty "
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sum"
        Me.Column4.Name = "Column4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(171, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Name"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_add.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_add.Location = New System.Drawing.Point(594, 155)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(105, 36)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_remline
        '
        Me.btn_remline.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_remline.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_remline.Location = New System.Drawing.Point(594, 197)
        Me.btn_remline.Name = "btn_remline"
        Me.btn_remline.Size = New System.Drawing.Size(105, 36)
        Me.btn_remline.TabIndex = 3
        Me.btn_remline.Text = "Remove"
        Me.btn_remline.UseVisualStyleBackColor = False
        '
        'btn_ClrAll
        '
        Me.btn_ClrAll.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_ClrAll.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_ClrAll.Location = New System.Drawing.Point(594, 239)
        Me.btn_ClrAll.Name = "btn_ClrAll"
        Me.btn_ClrAll.Size = New System.Drawing.Size(105, 36)
        Me.btn_ClrAll.TabIndex = 4
        Me.btn_ClrAll.Text = "Clear"
        Me.btn_ClrAll.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_print.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_print.Location = New System.Drawing.Point(594, 348)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(105, 36)
        Me.btn_print.TabIndex = 5
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPrice.Location = New System.Drawing.Point(687, 82)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(631, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Price"
        '
        'invoice_heading
        '
        Me.invoice_heading.Dock = System.Windows.Forms.DockStyle.Top
        Me.invoice_heading.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_heading.ForeColor = System.Drawing.Color.Maroon
        Me.invoice_heading.Location = New System.Drawing.Point(0, 0)
        Me.invoice_heading.Name = "invoice_heading"
        Me.invoice_heading.Size = New System.Drawing.Size(1115, 69)
        Me.invoice_heading.TabIndex = 9
        Me.invoice_heading.Text = "BAKE-IN SALES INVOICE"
        Me.invoice_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtQty.Location = New System.Drawing.Point(508, 79)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 22)
        Me.txtQty.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(438, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Quantity"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txttotal.Location = New System.Drawing.Point(594, 322)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(105, 22)
        Me.txttotal.TabIndex = 12
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(600, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Invoice Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'cmbName
        '
        Me.cmbName.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbName.Items.AddRange(New Object() {"Blueberry Scones ", "blackforest Pastry ", "Dark Choclate fudge", "Strawberry Cheesecake ", "Apple Pie ", "Olive Multigrain Bread", "Butterscotch Milkshake", "Oreo Milkshake", "Rasberry Cooler ", "Chocolate Chip cookies ", "Macarons (box)"})
        Me.cmbName.Location = New System.Drawing.Point(277, 80)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(125, 25)
        Me.cmbName.TabIndex = 14
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(902, 454)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(105, 36)
        Me.btn_exit.TabIndex = 142
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'dgv_prod
        '
        Me.dgv_prod.AllowUserToAddRows = False
        Me.dgv_prod.AllowUserToDeleteRows = False
        Me.dgv_prod.AllowUserToResizeColumns = False
        Me.dgv_prod.AllowUserToResizeRows = False
        Me.dgv_prod.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgv_prod.ColumnHeadersHeight = 30
        Me.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_prod.GridColor = System.Drawing.Color.Gray
        Me.dgv_prod.Location = New System.Drawing.Point(758, 131)
        Me.dgv_prod.Name = "dgv_prod"
        Me.dgv_prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_prod.RowTemplate.Height = 25
        Me.dgv_prod.Size = New System.Drawing.Size(249, 295)
        Me.dgv_prod.TabIndex = 143
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(861, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "MENU"
        '
        'sales_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 514)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_prod)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.invoice_heading)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_ClrAll)
        Me.Controls.Add(Me.btn_remline)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_invoice)
        Me.Name = "sales_invoice"
        Me.Text = "sales_invoice"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_invoice As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_remline As Button
    Friend WithEvents btn_ClrAll As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents invoice_heading As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btn_exit As Button
    Friend WithEvents dgv_prod As DataGridView
    Friend WithEvents Label5 As Label
End Class
