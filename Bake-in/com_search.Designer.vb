<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class com_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(com_search))
        Me.dgvItemSearch = New System.Windows.Forms.DataGridView()
        Me.btnItemSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbItemTitleSearch = New System.Windows.Forms.ComboBox()
        CType(Me.dgvItemSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItemSearch
        '
        Me.dgvItemSearch.AllowUserToAddRows = False
        Me.dgvItemSearch.AllowUserToDeleteRows = False
        Me.dgvItemSearch.AllowUserToResizeColumns = False
        Me.dgvItemSearch.AllowUserToResizeRows = False
        Me.dgvItemSearch.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvItemSearch.ColumnHeadersHeight = 30
        Me.dgvItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItemSearch.GridColor = System.Drawing.Color.Gray
        Me.dgvItemSearch.Location = New System.Drawing.Point(88, 141)
        Me.dgvItemSearch.Name = "dgvItemSearch"
        Me.dgvItemSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvItemSearch.RowTemplate.Height = 25
        Me.dgvItemSearch.Size = New System.Drawing.Size(565, 235)
        Me.dgvItemSearch.TabIndex = 17
        '
        'btnItemSearch
        '
        Me.btnItemSearch.BackColor = System.Drawing.Color.RosyBrown
        Me.btnItemSearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnItemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnItemSearch.Location = New System.Drawing.Point(539, 89)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(105, 36)
        Me.btnItemSearch.TabIndex = 16
        Me.btnItemSearch.Text = "Search"
        Me.btnItemSearch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(157, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Order ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(242, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "COMPLAINT SEARCH"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.RosyBrown
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(539, 392)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 36)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cmbItemTitleSearch
        '
        Me.cmbItemTitleSearch.FormattingEnabled = True
        Me.cmbItemTitleSearch.Location = New System.Drawing.Point(240, 89)
        Me.cmbItemTitleSearch.Name = "cmbItemTitleSearch"
        Me.cmbItemTitleSearch.Size = New System.Drawing.Size(181, 21)
        Me.cmbItemTitleSearch.TabIndex = 18
        '
        'com_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(876, 475)
        Me.Controls.Add(Me.cmbItemTitleSearch)
        Me.Controls.Add(Me.dgvItemSearch)
        Me.Controls.Add(Me.btnItemSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "com_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "com_search"
        CType(Me.dgvItemSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvItemSearch As DataGridView
    Friend WithEvents btnItemSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbItemTitleSearch As ComboBox
End Class
