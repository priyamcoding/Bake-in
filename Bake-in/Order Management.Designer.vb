<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Management))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.cmbGen = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtNam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpDOP = New System.Windows.Forms.DateTimePicker()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.gp1 = New System.Windows.Forms.GroupBox()
        Me.rbPayRecNo = New System.Windows.Forms.RadioButton()
        Me.rbPayRecYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDelNeedNo = New System.Windows.Forms.RadioButton()
        Me.rbDelNeedYes = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbMOPonline = New System.Windows.Forms.RadioButton()
        Me.rbMOPcod = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_showinv = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOrdID = New System.Windows.Forms.TextBox()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(38, 295)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Phone Number :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Sienna
        Me.Label9.Location = New System.Drawing.Point(40, 231)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Gender :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Sienna
        Me.Label10.Location = New System.Drawing.Point(358, 98)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Address :"
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Location = New System.Drawing.Point(757, 97)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(145, 35)
        Me.btn_reset.TabIndex = 56
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.Location = New System.Drawing.Point(757, 46)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(145, 39)
        Me.btn_insert.TabIndex = 55
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'cmbGen
        '
        Me.cmbGen.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbGen.FormattingEnabled = True
        Me.cmbGen.Items.AddRange(New Object() {"Female", "Male", "Choose not to answer"})
        Me.cmbGen.Location = New System.Drawing.Point(202, 229)
        Me.cmbGen.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbGen.Name = "cmbGen"
        Me.cmbGen.Size = New System.Drawing.Size(129, 25)
        Me.cmbGen.TabIndex = 54
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(522, 100)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(177, 47)
        Me.txtAddress.TabIndex = 53
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPhone.Location = New System.Drawing.Point(202, 295)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(129, 22)
        Me.txtPhone.TabIndex = 52
        '
        'txtNam
        '
        Me.txtNam.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtNam.Location = New System.Drawing.Point(202, 200)
        Me.txtNam.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(129, 22)
        Me.txtNam.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(40, 263)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Date of Birth :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(40, 201)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Customer Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(40, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(256, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 37)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "ORDER MANAGEMENT"
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtCustID.Location = New System.Drawing.Point(202, 134)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(129, 22)
        Me.txtCustID.TabIndex = 61
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOB.Location = New System.Drawing.Point(202, 257)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(129, 22)
        Me.dtpDOB.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(358, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Payment Received :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Sienna
        Me.Label12.Location = New System.Drawing.Point(40, 171)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 16)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Date of purchase :"
        '
        'dtpDOP
        '
        Me.dtpDOP.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOP.Location = New System.Drawing.Point(202, 164)
        Me.dtpDOP.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDOP.Name = "dtpDOP"
        Me.dtpDOP.Size = New System.Drawing.Size(129, 22)
        Me.dtpDOP.TabIndex = 75
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.AllowUserToResizeColumns = False
        Me.dgvOrder.AllowUserToResizeRows = False
        Me.dgvOrder.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvOrder.ColumnHeadersHeight = 30
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvOrder.GridColor = System.Drawing.Color.Gray
        Me.dgvOrder.Location = New System.Drawing.Point(56, 359)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        Me.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvOrder.RowTemplate.Height = 25
        Me.dgvOrder.Size = New System.Drawing.Size(732, 124)
        Me.dgvOrder.TabIndex = 81
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(757, 144)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(145, 41)
        Me.btn_delete.TabIndex = 82
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'gp1
        '
        Me.gp1.Controls.Add(Me.rbPayRecNo)
        Me.gp1.Controls.Add(Me.rbPayRecYes)
        Me.gp1.Location = New System.Drawing.Point(522, 242)
        Me.gp1.Name = "gp1"
        Me.gp1.Size = New System.Drawing.Size(177, 40)
        Me.gp1.TabIndex = 84
        Me.gp1.TabStop = False
        '
        'rbPayRecNo
        '
        Me.rbPayRecNo.AutoSize = True
        Me.rbPayRecNo.BackColor = System.Drawing.Color.Transparent
        Me.rbPayRecNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbPayRecNo.ForeColor = System.Drawing.Color.Black
        Me.rbPayRecNo.Location = New System.Drawing.Point(100, 11)
        Me.rbPayRecNo.Name = "rbPayRecNo"
        Me.rbPayRecNo.Size = New System.Drawing.Size(47, 20)
        Me.rbPayRecNo.TabIndex = 72
        Me.rbPayRecNo.TabStop = True
        Me.rbPayRecNo.Text = "NO"
        Me.rbPayRecNo.UseVisualStyleBackColor = False
        '
        'rbPayRecYes
        '
        Me.rbPayRecYes.AutoSize = True
        Me.rbPayRecYes.BackColor = System.Drawing.Color.Transparent
        Me.rbPayRecYes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbPayRecYes.ForeColor = System.Drawing.Color.Black
        Me.rbPayRecYes.Location = New System.Drawing.Point(18, 10)
        Me.rbPayRecYes.Name = "rbPayRecYes"
        Me.rbPayRecYes.Size = New System.Drawing.Size(48, 20)
        Me.rbPayRecYes.TabIndex = 71
        Me.rbPayRecYes.TabStop = True
        Me.rbPayRecYes.Text = "YES"
        Me.rbPayRecYes.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDelNeedNo)
        Me.GroupBox1.Controls.Add(Me.rbDelNeedYes)
        Me.GroupBox1.Location = New System.Drawing.Point(522, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 40)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'rbDelNeedNo
        '
        Me.rbDelNeedNo.AutoSize = True
        Me.rbDelNeedNo.BackColor = System.Drawing.Color.Transparent
        Me.rbDelNeedNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbDelNeedNo.ForeColor = System.Drawing.Color.Black
        Me.rbDelNeedNo.Location = New System.Drawing.Point(100, 10)
        Me.rbDelNeedNo.Name = "rbDelNeedNo"
        Me.rbDelNeedNo.Size = New System.Drawing.Size(47, 20)
        Me.rbDelNeedNo.TabIndex = 80
        Me.rbDelNeedNo.TabStop = True
        Me.rbDelNeedNo.Text = "NO"
        Me.rbDelNeedNo.UseVisualStyleBackColor = False
        '
        'rbDelNeedYes
        '
        Me.rbDelNeedYes.AutoSize = True
        Me.rbDelNeedYes.BackColor = System.Drawing.Color.Transparent
        Me.rbDelNeedYes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbDelNeedYes.ForeColor = System.Drawing.Color.Black
        Me.rbDelNeedYes.Location = New System.Drawing.Point(18, 10)
        Me.rbDelNeedYes.Name = "rbDelNeedYes"
        Me.rbDelNeedYes.Size = New System.Drawing.Size(48, 20)
        Me.rbDelNeedYes.TabIndex = 79
        Me.rbDelNeedYes.TabStop = True
        Me.rbDelNeedYes.Text = "YES"
        Me.rbDelNeedYes.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Sienna
        Me.Label13.Location = New System.Drawing.Point(358, 158)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 16)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Delivery needed:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbMOPonline)
        Me.GroupBox2.Controls.Add(Me.rbMOPcod)
        Me.GroupBox2.Location = New System.Drawing.Point(522, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(177, 40)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        '
        'rbMOPonline
        '
        Me.rbMOPonline.AutoSize = True
        Me.rbMOPonline.BackColor = System.Drawing.Color.Transparent
        Me.rbMOPonline.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbMOPonline.ForeColor = System.Drawing.Color.Black
        Me.rbMOPonline.Location = New System.Drawing.Point(100, 10)
        Me.rbMOPonline.Name = "rbMOPonline"
        Me.rbMOPonline.Size = New System.Drawing.Size(69, 20)
        Me.rbMOPonline.TabIndex = 75
        Me.rbMOPonline.TabStop = True
        Me.rbMOPonline.Text = "Online"
        Me.rbMOPonline.UseVisualStyleBackColor = False
        '
        'rbMOPcod
        '
        Me.rbMOPcod.AutoSize = True
        Me.rbMOPcod.BackColor = System.Drawing.Color.Transparent
        Me.rbMOPcod.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbMOPcod.ForeColor = System.Drawing.Color.Black
        Me.rbMOPcod.Location = New System.Drawing.Point(18, 10)
        Me.rbMOPcod.Name = "rbMOPcod"
        Me.rbMOPcod.Size = New System.Drawing.Size(56, 20)
        Me.rbMOPcod.TabIndex = 74
        Me.rbMOPcod.TabStop = True
        Me.rbMOPcod.Text = "COD"
        Me.rbMOPcod.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Sienna
        Me.Label11.Location = New System.Drawing.Point(358, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 16)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Mode of Payment :"
        '
        'btn_showinv
        '
        Me.btn_showinv.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_showinv.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_showinv.Location = New System.Drawing.Point(757, 198)
        Me.btn_showinv.Name = "btn_showinv"
        Me.btn_showinv.Size = New System.Drawing.Size(145, 59)
        Me.btn_showinv.TabIndex = 90
        Me.btn_showinv.Text = "Show Sales Invoice"
        Me.btn_showinv.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(782, 262)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(105, 36)
        Me.btn_exit.TabIndex = 143
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Sienna
        Me.Label14.Location = New System.Drawing.Point(40, 103)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Order ID :"
        '
        'txtOrdID
        '
        Me.txtOrdID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtOrdID.Location = New System.Drawing.Point(202, 99)
        Me.txtOrdID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrdID.Name = "txtOrdID"
        Me.txtOrdID.ReadOnly = True
        Me.txtOrdID.Size = New System.Drawing.Size(129, 22)
        Me.txtOrdID.TabIndex = 80
        '
        'Order_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 527)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_showinv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.gp1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.txtOrdID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpDOP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.cmbGen)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Order_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order_Management"
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp1.ResumeLayout(False)
        Me.gp1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents cmbGen As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtNam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpDOP As DateTimePicker
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents gp1 As GroupBox
    Friend WithEvents rbPayRecNo As RadioButton
    Friend WithEvents rbPayRecYes As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDelNeedNo As RadioButton
    Friend WithEvents rbDelNeedYes As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbMOPonline As RadioButton
    Friend WithEvents rbMOPcod As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_showinv As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtOrdID As TextBox
End Class
