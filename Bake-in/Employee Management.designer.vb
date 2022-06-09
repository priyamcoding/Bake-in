<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Management
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Management))
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.cmbDesig = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.txtSpvr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbMarStat = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtWorkHour = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.txtNam = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.dtpDOH = New System.Windows.Forms.DateTimePicker()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmpID
        '
        Me.txtEmpID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtEmpID.Location = New System.Drawing.Point(299, 103)
        Me.txtEmpID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(129, 22)
        Me.txtEmpID.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(162, 239)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Sienna
        Me.Label9.Location = New System.Drawing.Point(467, 238)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Designation:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Sienna
        Me.Label10.Location = New System.Drawing.Point(162, 268)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Date of Hiring:"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(236, 475)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(105, 36)
        Me.btn_update.TabIndex = 56
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.Location = New System.Drawing.Point(126, 475)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(105, 36)
        Me.btn_insert.TabIndex = 55
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'cmbDesig
        '
        Me.cmbDesig.AutoCompleteCustomSource.AddRange(New String() {"Chef ", "Data Analyst ", "Salesperson", "Security", "Software Engineer", "Manager"})
        Me.cmbDesig.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbDesig.FormattingEnabled = True
        Me.cmbDesig.Items.AddRange(New Object() {"Chef ", "Manager ", "Accountant ", "Software Engineer ", "Security ", "Salesperson"})
        Me.cmbDesig.Location = New System.Drawing.Point(612, 235)
        Me.cmbDesig.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDesig.Name = "cmbDesig"
        Me.cmbDesig.Size = New System.Drawing.Size(129, 25)
        Me.cmbDesig.TabIndex = 54
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(299, 237)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(129, 22)
        Me.txtAddress.TabIndex = 52
        '
        'txtPhn
        '
        Me.txtPhn.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPhn.Location = New System.Drawing.Point(299, 208)
        Me.txtPhn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhn.Name = "txtPhn"
        Me.txtPhn.Size = New System.Drawing.Size(129, 22)
        Me.txtPhn.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Sienna
        Me.Label6.Location = New System.Drawing.Point(162, 210)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Phone number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(162, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "DOB:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(162, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(162, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(162, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Employee ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(115, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 37)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "EMPLOYEE MANAGEMENT"
        '
        'txtSal
        '
        Me.txtSal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtSal.Location = New System.Drawing.Point(612, 157)
        Me.txtSal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(129, 22)
        Me.txtSal.TabIndex = 68
        '
        'txtSpvr
        '
        Me.txtSpvr.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtSpvr.Location = New System.Drawing.Point(612, 208)
        Me.txtSpvr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSpvr.Name = "txtSpvr"
        Me.txtSpvr.Size = New System.Drawing.Size(129, 22)
        Me.txtSpvr.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(467, 210)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Supervisor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Sienna
        Me.Label11.Location = New System.Drawing.Point(467, 185)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Department:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Sienna
        Me.Label12.Location = New System.Drawing.Point(467, 159)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Salary:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Sienna
        Me.Label13.Location = New System.Drawing.Point(467, 131)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Marital status:"
        '
        'cmbMarStat
        '
        Me.cmbMarStat.AutoCompleteCustomSource.AddRange(New String() {"Married ", "Unmarried"})
        Me.cmbMarStat.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbMarStat.FormattingEnabled = True
        Me.cmbMarStat.Items.AddRange(New Object() {"Unmarried", "Married "})
        Me.cmbMarStat.Location = New System.Drawing.Point(612, 131)
        Me.cmbMarStat.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMarStat.Name = "cmbMarStat"
        Me.cmbMarStat.Size = New System.Drawing.Size(129, 25)
        Me.cmbMarStat.TabIndex = 70
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtMail.Location = New System.Drawing.Point(612, 101)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(129, 22)
        Me.txtMail.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Sienna
        Me.Label14.Location = New System.Drawing.Point(467, 101)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "E-Mail:"
        '
        'txtWorkHour
        '
        Me.txtWorkHour.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtWorkHour.Location = New System.Drawing.Point(612, 262)
        Me.txtWorkHour.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWorkHour.Name = "txtWorkHour"
        Me.txtWorkHour.Size = New System.Drawing.Size(129, 22)
        Me.txtWorkHour.TabIndex = 74
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Sienna
        Me.Label15.Location = New System.Drawing.Point(467, 264)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 16)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Working Hours:"
        '
        'dgvEmp
        '
        Me.dgvEmp.AllowUserToAddRows = False
        Me.dgvEmp.AllowUserToDeleteRows = False
        Me.dgvEmp.AllowUserToResizeColumns = False
        Me.dgvEmp.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEmp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEmp.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmp.ColumnHeadersHeight = 30
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmp.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmp.EnableHeadersVisualStyles = False
        Me.dgvEmp.GridColor = System.Drawing.Color.Gray
        Me.dgvEmp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvEmp.Location = New System.Drawing.Point(186, 323)
        Me.dgvEmp.Name = "dgvEmp"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmp.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvEmp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvEmp.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmp.RowTemplate.Height = 25
        Me.dgvEmp.Size = New System.Drawing.Size(515, 127)
        Me.dgvEmp.TabIndex = 75
        '
        'txtNam
        '
        Me.txtNam.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtNam.Location = New System.Drawing.Point(299, 132)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(129, 22)
        Me.txtNam.TabIndex = 76
        '
        'cmbGender
        '
        Me.cmbGender.AutoCompleteCustomSource.AddRange(New String() {"Female", "Male", "Non Binary ", "Choose not to answer"})
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female ", "Male", "Non binary", "Choose not to answer "})
        Me.cmbGender.Location = New System.Drawing.Point(299, 159)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(129, 25)
        Me.cmbGender.TabIndex = 77
        '
        'cmbDept
        '
        Me.cmbDept.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Items.AddRange(New Object() {"Sales", "Software ", "Security ", "Mangement", "Kitchen"})
        Me.cmbDept.Location = New System.Drawing.Point(612, 183)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(129, 25)
        Me.cmbDept.TabIndex = 79
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(343, 475)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(105, 36)
        Me.btn_delete.TabIndex = 81
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Location = New System.Drawing.Point(452, 475)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(105, 36)
        Me.btn_reset.TabIndex = 84
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(909, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'dtpDOB
        '
        Me.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.Peru
        Me.dtpDOB.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOB.Location = New System.Drawing.Point(299, 183)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(129, 22)
        Me.dtpDOB.TabIndex = 86
        '
        'dtpDOH
        '
        Me.dtpDOH.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOH.Location = New System.Drawing.Point(299, 268)
        Me.dtpDOH.Name = "dtpDOH"
        Me.dtpDOH.Size = New System.Drawing.Size(129, 22)
        Me.dtpDOH.TabIndex = 87
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(675, 475)
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
        Me.btn_search.Location = New System.Drawing.Point(566, 474)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 36)
        Me.btn_search.TabIndex = 141
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Employee_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 531)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dtpDOH)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.dgvEmp)
        Me.Controls.Add(Me.txtWorkHour)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbMarStat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSal)
        Me.Controls.Add(Me.txtSpvr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.cmbDesig)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Employee_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents cmbDesig As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSal As TextBox
    Friend WithEvents txtSpvr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbMarStat As ComboBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtWorkHour As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents txtNam As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbDept As ComboBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents dtpDOH As DateTimePicker
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_search As Button
End Class
