<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item_inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item_inventory))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.rbRefNo = New System.Windows.Forms.RadioButton()
        Me.rbRefYes = New System.Windows.Forms.RadioButton()
        Me.dtpDOA = New System.Windows.Forms.DateTimePicker()
        Me.dtpDOE = New System.Windows.Forms.DateTimePicker()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dgvitem = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(355, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(310, 37)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "ITEM INVENTORY"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Sienna
        Me.Label9.Location = New System.Drawing.Point(197, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Quantity :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(198, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Needs Refrigeration?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(198, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Category :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(199, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(198, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Date of Arrival :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(199, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Expiration Date :"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPrice.Location = New System.Drawing.Point(362, 233)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(145, 22)
        Me.txtPrice.TabIndex = 34
        '
        'cmbCat
        '
        Me.cmbCat.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Items.AddRange(New Object() {"Sugar ", "Fat ", "Flavoring ", "Flour", "Fruit"})
        Me.cmbCat.Location = New System.Drawing.Point(362, 160)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(145, 25)
        Me.cmbCat.TabIndex = 35
        '
        'rbRefNo
        '
        Me.rbRefNo.AutoSize = True
        Me.rbRefNo.BackColor = System.Drawing.Color.Transparent
        Me.rbRefNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbRefNo.ForeColor = System.Drawing.Color.Black
        Me.rbRefNo.Location = New System.Drawing.Point(457, 267)
        Me.rbRefNo.Name = "rbRefNo"
        Me.rbRefNo.Size = New System.Drawing.Size(47, 20)
        Me.rbRefNo.TabIndex = 38
        Me.rbRefNo.TabStop = True
        Me.rbRefNo.Text = "NO"
        Me.rbRefNo.UseVisualStyleBackColor = False
        '
        'rbRefYes
        '
        Me.rbRefYes.AutoSize = True
        Me.rbRefYes.BackColor = System.Drawing.Color.Transparent
        Me.rbRefYes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbRefYes.ForeColor = System.Drawing.Color.Black
        Me.rbRefYes.Location = New System.Drawing.Point(362, 267)
        Me.rbRefYes.Name = "rbRefYes"
        Me.rbRefYes.Size = New System.Drawing.Size(48, 20)
        Me.rbRefYes.TabIndex = 37
        Me.rbRefYes.TabStop = True
        Me.rbRefYes.Text = "YES"
        Me.rbRefYes.UseVisualStyleBackColor = False
        '
        'dtpDOA
        '
        Me.dtpDOA.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOA.Location = New System.Drawing.Point(362, 305)
        Me.dtpDOA.Name = "dtpDOA"
        Me.dtpDOA.Size = New System.Drawing.Size(145, 22)
        Me.dtpDOA.TabIndex = 39
        '
        'dtpDOE
        '
        Me.dtpDOE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOE.Location = New System.Drawing.Point(362, 339)
        Me.dtpDOE.Name = "dtpDOE"
        Me.dtpDOE.Size = New System.Drawing.Size(145, 22)
        Me.dtpDOE.TabIndex = 40
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Location = New System.Drawing.Point(312, 391)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(105, 36)
        Me.btn_reset.TabIndex = 42
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(89, 391)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(105, 36)
        Me.btn_save.TabIndex = 41
        Me.btn_save.Text = "Insert"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'dgvitem
        '
        Me.dgvitem.AllowUserToAddRows = False
        Me.dgvitem.AllowUserToDeleteRows = False
        Me.dgvitem.AllowUserToResizeColumns = False
        Me.dgvitem.AllowUserToResizeRows = False
        Me.dgvitem.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvitem.ColumnHeadersHeight = 30
        Me.dgvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvitem.GridColor = System.Drawing.Color.Gray
        Me.dgvitem.Location = New System.Drawing.Point(552, 93)
        Me.dgvitem.Name = "dgvitem"
        Me.dgvitem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvitem.RowTemplate.Height = 25
        Me.dgvitem.Size = New System.Drawing.Size(352, 194)
        Me.dgvitem.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(198, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Item name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtName.Location = New System.Drawing.Point(362, 126)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(145, 22)
        Me.txtName.TabIndex = 33
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.Location = New System.Drawing.Point(433, 391)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(105, 36)
        Me.btn_delete.TabIndex = 44
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtQty.Location = New System.Drawing.Point(362, 199)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(145, 22)
        Me.txtQty.TabIndex = 45
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(652, 391)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(105, 36)
        Me.btn_exit.TabIndex = 142
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Location = New System.Drawing.Point(543, 391)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 36)
        Me.btn_search.TabIndex = 141
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(198, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Item ID :"
        '
        'txtItemID
        '
        Me.txtItemID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtItemID.Location = New System.Drawing.Point(362, 93)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.ReadOnly = True
        Me.txtItemID.Size = New System.Drawing.Size(145, 22)
        Me.txtItemID.TabIndex = 32
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RosyBrown
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(200, 391)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 36)
        Me.btnUpdate.TabIndex = 143
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Item_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 562)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.dgvitem)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.dtpDOE)
        Me.Controls.Add(Me.dtpDOA)
        Me.Controls.Add(Me.rbRefNo)
        Me.Controls.Add(Me.rbRefYes)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Item_inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dgvitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents rbRefNo As RadioButton
    Friend WithEvents rbRefYes As RadioButton
    Friend WithEvents dtpDOA As DateTimePicker
    Friend WithEvents dtpDOE As DateTimePicker
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents dgvitem As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents btnUpdate As Button
End Class
