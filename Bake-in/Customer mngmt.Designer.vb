<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_mnmgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_mnmgt))
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcustID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtPhno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_cust = New System.Windows.Forms.DataGridView()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.dgvcust2 = New System.Windows.Forms.DataGridView()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        CType(Me.dgv_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcust2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOB.Location = New System.Drawing.Point(326, 211)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(129, 22)
        Me.dtpDOB.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Sienna
        Me.Label9.Location = New System.Drawing.Point(164, 179)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Gender :"
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male", "Choose not to answer"})
        Me.cmbGender.Location = New System.Drawing.Point(326, 170)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(129, 25)
        Me.cmbGender.TabIndex = 68
        '
        'txtCustName
        '
        Me.txtCustName.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtCustName.Location = New System.Drawing.Point(326, 129)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(129, 22)
        Me.txtCustName.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(164, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Date of Birth :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(164, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Customer Name :"
        '
        'txtcustID
        '
        Me.txtcustID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtcustID.Location = New System.Drawing.Point(326, 94)
        Me.txtcustID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcustID.Name = "txtcustID"
        Me.txtcustID.Size = New System.Drawing.Size(129, 22)
        Me.txtcustID.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(164, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Customer ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(491, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Phone Number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Sienna
        Me.Label10.Location = New System.Drawing.Point(491, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Address :"
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtAdd.Location = New System.Drawing.Point(655, 151)
        Me.txtAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(177, 47)
        Me.txtAdd.TabIndex = 74
        '
        'txtPhno
        '
        Me.txtPhno.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPhno.Location = New System.Drawing.Point(655, 98)
        Me.txtPhno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhno.Name = "txtPhno"
        Me.txtPhno.Size = New System.Drawing.Size(129, 22)
        Me.txtPhno.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(319, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(454, 37)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "CUSTOMER MANAGEMENT"
        '
        'dgv_cust
        '
        Me.dgv_cust.AllowUserToAddRows = False
        Me.dgv_cust.AllowUserToDeleteRows = False
        Me.dgv_cust.AllowUserToResizeColumns = False
        Me.dgv_cust.AllowUserToResizeRows = False
        Me.dgv_cust.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgv_cust.ColumnHeadersHeight = 30
        Me.dgv_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_cust.GridColor = System.Drawing.Color.Gray
        Me.dgv_cust.Location = New System.Drawing.Point(115, 254)
        Me.dgv_cust.Name = "dgv_cust"
        Me.dgv_cust.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_cust.RowTemplate.Height = 25
        Me.dgv_cust.Size = New System.Drawing.Size(365, 140)
        Me.dgv_cust.TabIndex = 81
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_update.Location = New System.Drawing.Point(248, 409)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(105, 36)
        Me.btn_update.TabIndex = 84
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Location = New System.Drawing.Point(470, 409)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(105, 36)
        Me.btn_reset.TabIndex = 83
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RosyBrown
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.Location = New System.Drawing.Point(359, 409)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 36)
        Me.btnDelete.TabIndex = 85
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_insert.Location = New System.Drawing.Point(137, 409)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(105, 36)
        Me.btn_insert.TabIndex = 86
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'dgvcust2
        '
        Me.dgvcust2.AllowUserToAddRows = False
        Me.dgvcust2.AllowUserToDeleteRows = False
        Me.dgvcust2.AllowUserToResizeColumns = False
        Me.dgvcust2.AllowUserToResizeRows = False
        Me.dgvcust2.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvcust2.ColumnHeadersHeight = 30
        Me.dgvcust2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvcust2.GridColor = System.Drawing.Color.Gray
        Me.dgvcust2.Location = New System.Drawing.Point(486, 254)
        Me.dgvcust2.Name = "dgvcust2"
        Me.dgvcust2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvcust2.RowTemplate.Height = 25
        Me.dgvcust2.Size = New System.Drawing.Size(335, 140)
        Me.dgvcust2.TabIndex = 87
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(689, 409)
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
        Me.btn_search.Location = New System.Drawing.Point(580, 409)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 36)
        Me.btn_search.TabIndex = 141
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Customer_mnmgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1144, 551)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dgvcust2)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.dgv_cust)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtPhno)
        Me.Controls.Add(Me.txtcustID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer_mnmgt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer_mngmt"
        CType(Me.dgv_cust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcust2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcustID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents txtPhno As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_cust As DataGridView
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents dgvcust2 As DataGridView
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_search As Button
End Class
