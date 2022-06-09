<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Complaint_mnmt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Complaint_mnmt))
        Me.dtpDOO = New System.Windows.Forms.DateTimePicker()
        Me.rbCRno = New System.Windows.Forms.RadioButton()
        Me.rbCRyes = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtPhno = New System.Windows.Forms.TextBox()
        Me.dgvComp1 = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvComp2 = New System.Windows.Forms.DataGridView()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        CType(Me.dgvComp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDOO
        '
        Me.dtpDOO.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOO.Location = New System.Drawing.Point(363, 173)
        Me.dtpDOO.Name = "dtpDOO"
        Me.dtpDOO.Size = New System.Drawing.Size(145, 22)
        Me.dtpDOO.TabIndex = 88
        '
        'rbCRno
        '
        Me.rbCRno.AutoSize = True
        Me.rbCRno.BackColor = System.Drawing.Color.Transparent
        Me.rbCRno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbCRno.ForeColor = System.Drawing.Color.Black
        Me.rbCRno.Location = New System.Drawing.Point(458, 204)
        Me.rbCRno.Name = "rbCRno"
        Me.rbCRno.Size = New System.Drawing.Size(47, 20)
        Me.rbCRno.TabIndex = 86
        Me.rbCRno.TabStop = True
        Me.rbCRno.Text = "NO"
        Me.rbCRno.UseVisualStyleBackColor = False
        '
        'rbCRyes
        '
        Me.rbCRyes.AutoSize = True
        Me.rbCRyes.BackColor = System.Drawing.Color.Transparent
        Me.rbCRyes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbCRyes.ForeColor = System.Drawing.Color.Black
        Me.rbCRyes.Location = New System.Drawing.Point(363, 204)
        Me.rbCRyes.Name = "rbCRyes"
        Me.rbCRyes.Size = New System.Drawing.Size(48, 20)
        Me.rbCRyes.TabIndex = 85
        Me.rbCRyes.TabStop = True
        Me.rbCRyes.Text = "YES"
        Me.rbCRyes.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(199, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 16)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Complaint Resolved?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Sienna
        Me.Label6.Location = New System.Drawing.Point(199, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Date of Order :"
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Location = New System.Drawing.Point(281, 452)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(105, 36)
        Me.btn_reset.TabIndex = 81
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.Location = New System.Drawing.Point(151, 452)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(105, 36)
        Me.btn_insert.TabIndex = 80
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtCustID.Location = New System.Drawing.Point(363, 110)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(145, 22)
        Me.txtCustID.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(199, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Phone Number :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(199, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Customer ID :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(313, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(469, 37)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "COMPLAINT MANAGEMENT"
        '
        'txtOrderID
        '
        Me.txtOrderID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtOrderID.Location = New System.Drawing.Point(363, 84)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(145, 22)
        Me.txtOrderID.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(199, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Order ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(577, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Address :"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtDesc.Location = New System.Drawing.Point(580, 179)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(196, 46)
        Me.txtDesc.TabIndex = 92
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Sienna
        Me.Label11.Location = New System.Drawing.Point(577, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 16)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Complaint Description :"
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtAdd.Location = New System.Drawing.Point(580, 96)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(196, 34)
        Me.txtAdd.TabIndex = 94
        '
        'txtPhno
        '
        Me.txtPhno.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPhno.Location = New System.Drawing.Point(363, 140)
        Me.txtPhno.Name = "txtPhno"
        Me.txtPhno.Size = New System.Drawing.Size(145, 22)
        Me.txtPhno.TabIndex = 95
        '
        'dgvComp1
        '
        Me.dgvComp1.AllowUserToAddRows = False
        Me.dgvComp1.AllowUserToDeleteRows = False
        Me.dgvComp1.AllowUserToResizeColumns = False
        Me.dgvComp1.AllowUserToResizeRows = False
        Me.dgvComp1.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvComp1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvComp1.ColumnHeadersHeight = 30
        Me.dgvComp1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvComp1.GridColor = System.Drawing.Color.Gray
        Me.dgvComp1.Location = New System.Drawing.Point(121, 260)
        Me.dgvComp1.Name = "dgvComp1"
        Me.dgvComp1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvComp1.RowTemplate.Height = 25
        Me.dgvComp1.Size = New System.Drawing.Size(361, 163)
        Me.dgvComp1.TabIndex = 96
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RosyBrown
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(392, 453)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 36)
        Me.btnDelete.TabIndex = 97
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvComp2
        '
        Me.dgvComp2.AllowUserToAddRows = False
        Me.dgvComp2.AllowUserToDeleteRows = False
        Me.dgvComp2.AllowUserToResizeColumns = False
        Me.dgvComp2.AllowUserToResizeRows = False
        Me.dgvComp2.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvComp2.ColumnHeadersHeight = 30
        Me.dgvComp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvComp2.GridColor = System.Drawing.Color.Gray
        Me.dgvComp2.Location = New System.Drawing.Point(500, 260)
        Me.dgvComp2.Name = "dgvComp2"
        Me.dgvComp2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvComp2.RowTemplate.Height = 25
        Me.dgvComp2.Size = New System.Drawing.Size(344, 163)
        Me.dgvComp2.TabIndex = 98
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(623, 453)
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
        Me.btn_search.Location = New System.Drawing.Point(514, 452)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 36)
        Me.btn_search.TabIndex = 141
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Complaint_mnmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1097, 581)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dgvComp2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvComp1)
        Me.Controls.Add(Me.txtPhno)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDOO)
        Me.Controls.Add(Me.rbCRno)
        Me.Controls.Add(Me.rbCRyes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.DoubleBuffered = True
        Me.Name = "Complaint_mnmt"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvComp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDOO As DateTimePicker
    Friend WithEvents rbCRno As RadioButton
    Friend WithEvents rbCRyes As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents txtPhno As TextBox
    Friend WithEvents dgvComp1 As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvComp2 As DataGridView
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_search As Button
End Class
