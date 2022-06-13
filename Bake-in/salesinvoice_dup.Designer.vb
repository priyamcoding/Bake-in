<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesinvoice_dup
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesinvoice_dup))
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_invoice = New System.Windows.Forms.DataGridView()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_remline = New System.Windows.Forms.Button()
        Me.btn_ClrAll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.invoice_heading = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.DbBakeInDataSet = New Bake_in.dbBakeInDataSet()
        Me.DbBakeInDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdDataset = New Bake_in.ProdDataset()
        Me.ProdDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBakeInDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBakeInDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sum"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 53
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 56
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty "
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 48
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.Name = "Column1"
        '
        'dgv_invoice
        '
        Me.dgv_invoice.AllowUserToAddRows = False
        Me.dgv_invoice.AllowUserToDeleteRows = False
        Me.dgv_invoice.AllowUserToResizeColumns = False
        Me.dgv_invoice.AllowUserToResizeRows = False
        Me.dgv_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_invoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_invoice.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgv_invoice.ColumnHeadersHeight = 30
        Me.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_invoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_invoice.EnableHeadersVisualStyles = False
        Me.dgv_invoice.GridColor = System.Drawing.Color.Gray
        Me.dgv_invoice.Location = New System.Drawing.Point(50, 134)
        Me.dgv_invoice.MultiSelect = False
        Me.dgv_invoice.Name = "dgv_invoice"
        Me.dgv_invoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_invoice.RowTemplate.Height = 25
        Me.dgv_invoice.Size = New System.Drawing.Size(322, 313)
        Me.dgv_invoice.TabIndex = 145
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPrice.Location = New System.Drawing.Point(626, 83)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 25)
        Me.txtPrice.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(24, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Product Name"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_add.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_add.Location = New System.Drawing.Point(429, 143)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(105, 36)
        Me.btn_add.TabIndex = 147
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_remline
        '
        Me.btn_remline.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_remline.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_remline.Location = New System.Drawing.Point(429, 185)
        Me.btn_remline.Name = "btn_remline"
        Me.btn_remline.Size = New System.Drawing.Size(105, 36)
        Me.btn_remline.TabIndex = 148
        Me.btn_remline.Text = "Remove"
        Me.btn_remline.UseVisualStyleBackColor = False
        '
        'btn_ClrAll
        '
        Me.btn_ClrAll.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_ClrAll.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_ClrAll.Location = New System.Drawing.Point(429, 227)
        Me.btn_ClrAll.Name = "btn_ClrAll"
        Me.btn_ClrAll.Size = New System.Drawing.Size(105, 36)
        Me.btn_ClrAll.TabIndex = 149
        Me.btn_ClrAll.Text = "Clear"
        Me.btn_ClrAll.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(579, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Price"
        '
        'invoice_heading
        '
        Me.invoice_heading.Dock = System.Windows.Forms.DockStyle.Top
        Me.invoice_heading.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_heading.ForeColor = System.Drawing.Color.Maroon
        Me.invoice_heading.Location = New System.Drawing.Point(0, 0)
        Me.invoice_heading.Name = "invoice_heading"
        Me.invoice_heading.Size = New System.Drawing.Size(800, 69)
        Me.invoice_heading.TabIndex = 152
        Me.invoice_heading.Text = "BAKE-IN SALES INVOICE"
        Me.invoice_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(308, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Order Quantity"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtQty.Location = New System.Drawing.Point(429, 80)
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(105, 25)
        Me.txtQty.TabIndex = 154
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txttotal.Location = New System.Drawing.Point(429, 425)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(105, 22)
        Me.txttotal.TabIndex = 155
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(435, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 156
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
        'cmbName
        '
        Me.cmbName.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbName.Location = New System.Drawing.Point(130, 80)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(155, 25)
        Me.cmbName.TabIndex = 157
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(429, 268)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(105, 36)
        Me.btn_exit.TabIndex = 158
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'DbBakeInDataSet
        '
        Me.DbBakeInDataSet.DataSetName = "dbBakeInDataSet"
        Me.DbBakeInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbBakeInDataSetBindingSource
        '
        Me.DbBakeInDataSetBindingSource.DataSource = Me.DbBakeInDataSet
        Me.DbBakeInDataSetBindingSource.Position = 0
        '
        'ProdDataset
        '
        Me.ProdDataset.DataSetName = "ProdDataset"
        Me.ProdDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdDatasetBindingSource
        '
        Me.ProdDatasetBindingSource.DataSource = Me.ProdDataset
        Me.ProdDatasetBindingSource.Position = 0
        '
        'salesinvoice_dup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.invoice_heading)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_ClrAll)
        Me.Controls.Add(Me.btn_remline)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.dgv_invoice)
        Me.Name = "salesinvoice_dup"
        Me.Text = "salesinvoice_dup"
        CType(Me.dgv_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBakeInDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBakeInDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_invoice As DataGridView
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_remline As Button
    Friend WithEvents btn_ClrAll As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents invoice_heading As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents DbBakeInDataSet As dbBakeInDataSet
    Friend WithEvents DbBakeInDataSetBindingSource As BindingSource
    Friend WithEvents ProdDataset As ProdDataset
    Friend WithEvents ProdDatasetBindingSource As BindingSource
End Class
