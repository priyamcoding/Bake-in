<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Itemsearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Itemsearch))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemTitleSearch = New System.Windows.Forms.TextBox()
        Me.btnItemSearch = New System.Windows.Forms.Button()
        Me.dgvItemSearch = New System.Windows.Forms.DataGridView()
        CType(Me.dgvItemSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.RosyBrown
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(649, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 36)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(382, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ITEM SEARCH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(217, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Name"
        '
        'txtItemTitleSearch
        '
        Me.txtItemTitleSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtItemTitleSearch.Location = New System.Drawing.Point(312, 75)
        Me.txtItemTitleSearch.Name = "txtItemTitleSearch"
        Me.txtItemTitleSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtItemTitleSearch.TabIndex = 3
        '
        'btnItemSearch
        '
        Me.btnItemSearch.BackColor = System.Drawing.Color.RosyBrown
        Me.btnItemSearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnItemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnItemSearch.Location = New System.Drawing.Point(640, 72)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(105, 36)
        Me.btnItemSearch.TabIndex = 4
        Me.btnItemSearch.Text = "Search"
        Me.btnItemSearch.UseVisualStyleBackColor = False
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
        Me.dgvItemSearch.Location = New System.Drawing.Point(138, 121)
        Me.dgvItemSearch.Name = "dgvItemSearch"
        Me.dgvItemSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvItemSearch.RowTemplate.Height = 25
        Me.dgvItemSearch.Size = New System.Drawing.Size(616, 256)
        Me.dgvItemSearch.TabIndex = 5
        '
        'Itemsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1037, 450)
        Me.Controls.Add(Me.dgvItemSearch)
        Me.Controls.Add(Me.btnItemSearch)
        Me.Controls.Add(Me.txtItemTitleSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Itemsearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itemsearch"
        CType(Me.dgvItemSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemTitleSearch As TextBox
    Friend WithEvents btnItemSearch As Button
    Friend WithEvents dgvItemSearch As DataGridView
End Class
