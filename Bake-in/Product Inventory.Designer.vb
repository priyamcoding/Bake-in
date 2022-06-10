<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Inventory))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtLisPrc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbOrd = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbRef_no = New System.Windows.Forms.RadioButton()
        Me.rbRef_yes = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvpro = New System.Windows.Forms.DataGridView()
        Me.dtpDOC = New System.Windows.Forms.DateTimePicker()
        Me.dtpDOE = New System.Windows.Forms.DateTimePicker()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        CType(Me.dgvpro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(305, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(385, 37)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "PRODUCT INVENTORY"
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Location = New System.Drawing.Point(262, 367)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(109, 37)
        Me.btn_reset.TabIndex = 61
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.Location = New System.Drawing.Point(135, 367)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(117, 37)
        Me.btn_insert.TabIndex = 60
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'cmbCategory
        '
        Me.cmbCategory.AutoCompleteCustomSource.AddRange(New String() {"a", "b", "c", "d", "e"})
        Me.cmbCategory.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Cakes ", "Biscuits ", "Pastries ", "Breads ", "Drinks"})
        Me.cmbCategory.Location = New System.Drawing.Point(293, 154)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(145, 25)
        Me.cmbCategory.TabIndex = 54
        '
        'txtLisPrc
        '
        Me.txtLisPrc.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtLisPrc.Location = New System.Drawing.Point(293, 231)
        Me.txtLisPrc.Name = "txtLisPrc"
        Me.txtLisPrc.Size = New System.Drawing.Size(145, 22)
        Me.txtLisPrc.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(107, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "In-house/Ordered :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Sienna
        Me.Label9.Location = New System.Drawing.Point(107, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 16)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Date of Creation :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(107, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Category :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(108, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Listing Price :"
        '
        'cmbOrd
        '
        Me.cmbOrd.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbOrd.FormattingEnabled = True
        Me.cmbOrd.Items.AddRange(New Object() {"In-house", "Ordered "})
        Me.cmbOrd.Location = New System.Drawing.Point(293, 204)
        Me.cmbOrd.Name = "cmbOrd"
        Me.cmbOrd.Size = New System.Drawing.Size(145, 25)
        Me.cmbOrd.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Sienna
        Me.Label6.Location = New System.Drawing.Point(107, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 16)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Date of Expiry :"
        '
        'rbRef_no
        '
        Me.rbRef_no.AutoSize = True
        Me.rbRef_no.BackColor = System.Drawing.Color.Transparent
        Me.rbRef_no.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbRef_no.ForeColor = System.Drawing.Color.Black
        Me.rbRef_no.Location = New System.Drawing.Point(389, 320)
        Me.rbRef_no.Name = "rbRef_no"
        Me.rbRef_no.Size = New System.Drawing.Size(47, 20)
        Me.rbRef_no.TabIndex = 67
        Me.rbRef_no.TabStop = True
        Me.rbRef_no.Text = "NO"
        Me.rbRef_no.UseVisualStyleBackColor = False
        '
        'rbRef_yes
        '
        Me.rbRef_yes.AutoSize = True
        Me.rbRef_yes.BackColor = System.Drawing.Color.Transparent
        Me.rbRef_yes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbRef_yes.ForeColor = System.Drawing.Color.Black
        Me.rbRef_yes.Location = New System.Drawing.Point(294, 320)
        Me.rbRef_yes.Name = "rbRef_yes"
        Me.rbRef_yes.Size = New System.Drawing.Size(48, 20)
        Me.rbRef_yes.TabIndex = 66
        Me.rbRef_yes.TabStop = True
        Me.rbRef_yes.Text = "YES"
        Me.rbRef_yes.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(108, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Needs Refrigeration?"
        '
        'dgvpro
        '
        Me.dgvpro.AllowUserToAddRows = False
        Me.dgvpro.AllowUserToDeleteRows = False
        Me.dgvpro.AllowUserToResizeColumns = False
        Me.dgvpro.AllowUserToResizeRows = False
        Me.dgvpro.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvpro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvpro.ColumnHeadersHeight = 30
        Me.dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvpro.GridColor = System.Drawing.Color.Gray
        Me.dgvpro.Location = New System.Drawing.Point(473, 102)
        Me.dgvpro.Name = "dgvpro"
        Me.dgvpro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvpro.RowTemplate.Height = 25
        Me.dgvpro.Size = New System.Drawing.Size(408, 235)
        Me.dgvpro.TabIndex = 68
        '
        'dtpDOC
        '
        Me.dtpDOC.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOC.Location = New System.Drawing.Point(293, 261)
        Me.dtpDOC.Name = "dtpDOC"
        Me.dtpDOC.Size = New System.Drawing.Size(145, 22)
        Me.dtpDOC.TabIndex = 69
        '
        'dtpDOE
        '
        Me.dtpDOE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOE.Location = New System.Drawing.Point(293, 287)
        Me.dtpDOE.Name = "dtpDOE"
        Me.dtpDOE.Size = New System.Drawing.Size(145, 22)
        Me.dtpDOE.TabIndex = 70
        '
        'txtProdName
        '
        Me.txtProdName.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtProdName.Location = New System.Drawing.Point(293, 128)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(145, 22)
        Me.txtProdName.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(107, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Product Name :"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.Location = New System.Drawing.Point(486, 365)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(113, 37)
        Me.btn_delete.TabIndex = 73
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtqty.Location = New System.Drawing.Point(293, 181)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(146, 22)
        Me.txtqty.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(108, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Qty"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(713, 367)
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
        Me.btn_search.Location = New System.Drawing.Point(604, 366)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 36)
        Me.btn_search.TabIndex = 141
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(376, 366)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(105, 36)
        Me.btn_update.TabIndex = 143
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(107, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Product ID :"
        '
        'txtProdID
        '
        Me.txtProdID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtProdID.Location = New System.Drawing.Point(293, 102)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.ReadOnly = True
        Me.txtProdID.Size = New System.Drawing.Size(145, 22)
        Me.txtProdID.TabIndex = 51
        '
        'Product_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 542)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDOE)
        Me.Controls.Add(Me.dtpDOC)
        Me.Controls.Add(Me.dgvpro)
        Me.Controls.Add(Me.rbRef_no)
        Me.Controls.Add(Me.rbRef_yes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbOrd)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtLisPrc)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Product_Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Management"
        CType(Me.dgvpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtLisPrc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbOrd As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbRef_no As RadioButton
    Friend WithEvents rbRef_yes As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvpro As DataGridView
    Friend WithEvents dtpDOC As DateTimePicker
    Friend WithEvents dtpDOE As DateTimePicker
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProdID As TextBox
End Class
