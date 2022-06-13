<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesinvoice2
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
        Me.dgv_i = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_i, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_i
        '
        Me.dgv_i.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_i.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_i.Location = New System.Drawing.Point(27, 198)
        Me.dgv_i.Name = "dgv_i"
        Me.dgv_i.Size = New System.Drawing.Size(707, 150)
        Me.dgv_i.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(481, 107)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Cost"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(313, 109)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 6
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(456, 399)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 7
        '
        'cmbName
        '
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(117, 110)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(121, 21)
        Me.cmbName.TabIndex = 8
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(649, 396)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 9
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(340, 135)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 20)
        Me.txtprice.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Price of Item"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price per Item"
        Me.Column4.Name = "Column4"
        '
        'salesinvoice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_i)
        Me.Name = "salesinvoice2"
        Me.Text = "salesinvoice2"
        CType(Me.dgv_i, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_i As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
