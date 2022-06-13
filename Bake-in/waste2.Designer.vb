<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class waste2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(waste2))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txtProNam = New System.Windows.Forms.TextBox()
        Me.txtProID = New System.Windows.Forms.TextBox()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.dgvWaste = New System.Windows.Forms.DataGridView()
        Me.txtQuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDOD = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvWaste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(588, 396)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(105, 36)
        Me.btn_exit.TabIndex = 153
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Location = New System.Drawing.Point(370, 396)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 36)
        Me.btn_search.TabIndex = 152
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txtProNam
        '
        Me.txtProNam.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtProNam.Location = New System.Drawing.Point(221, 162)
        Me.txtProNam.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProNam.Name = "txtProNam"
        Me.txtProNam.Size = New System.Drawing.Size(129, 22)
        Me.txtProNam.TabIndex = 151
        '
        'txtProID
        '
        Me.txtProID.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtProID.Location = New System.Drawing.Point(221, 119)
        Me.txtProID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProID.Name = "txtProID"
        Me.txtProID.Size = New System.Drawing.Size(129, 22)
        Me.txtProID.TabIndex = 150
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_Reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_Reset.ForeColor = System.Drawing.Color.Black
        Me.btn_Reset.Location = New System.Drawing.Point(479, 396)
        Me.btn_Reset.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(105, 36)
        Me.btn_Reset.TabIndex = 149
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = False
        '
        'dgvWaste
        '
        Me.dgvWaste.AllowUserToAddRows = False
        Me.dgvWaste.AllowUserToDeleteRows = False
        Me.dgvWaste.AllowUserToResizeColumns = False
        Me.dgvWaste.AllowUserToResizeRows = False
        Me.dgvWaste.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvWaste.ColumnHeadersHeight = 30
        Me.dgvWaste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvWaste.GridColor = System.Drawing.Color.Gray
        Me.dgvWaste.Location = New System.Drawing.Point(367, 119)
        Me.dgvWaste.Name = "dgvWaste"
        Me.dgvWaste.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvWaste.RowTemplate.Height = 25
        Me.dgvWaste.Size = New System.Drawing.Size(406, 224)
        Me.dgvWaste.TabIndex = 148
        '
        'txtQuan
        '
        Me.txtQuan.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtQuan.Location = New System.Drawing.Point(221, 206)
        Me.txtQuan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.Size = New System.Drawing.Size(129, 22)
        Me.txtQuan.TabIndex = 147
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(64, 212)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Quantity :"
        '
        'dtpDOD
        '
        Me.dtpDOD.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dtpDOD.Location = New System.Drawing.Point(221, 245)
        Me.dtpDOD.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDOD.Name = "dtpDOD"
        Me.dtpDOD.Size = New System.Drawing.Size(129, 22)
        Me.dtpDOD.TabIndex = 145
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(64, 247)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Date of Disposal :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(64, 165)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Product Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(64, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Product ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(284, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 37)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "WASTE MANAGEMENT"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.Location = New System.Drawing.Point(152, 396)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(105, 36)
        Me.btn_insert.TabIndex = 154
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RosyBrown
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(261, 396)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 36)
        Me.btnUpdate.TabIndex = 155
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'waste2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(929, 516)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txtProNam)
        Me.Controls.Add(Me.txtProID)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.dgvWaste)
        Me.Controls.Add(Me.txtQuan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpDOD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "waste2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "waste2"
        CType(Me.dgvWaste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents txtProNam As TextBox
    Friend WithEvents txtProID As TextBox
    Friend WithEvents btn_Reset As Button
    Friend WithEvents dgvWaste As DataGridView
    Friend WithEvents txtQuan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDOD As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btnUpdate As Button
End Class
