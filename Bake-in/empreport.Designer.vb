<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empreport))
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvemp = New System.Windows.Forms.DataGridView()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.dgvemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_print.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_print.Location = New System.Drawing.Point(297, 319)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(106, 36)
        Me.btn_print.TabIndex = 8
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(271, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "EMPLOYEE REPORT"
        '
        'dgvemp
        '
        Me.dgvemp.AllowUserToAddRows = False
        Me.dgvemp.AllowUserToDeleteRows = False
        Me.dgvemp.AllowUserToResizeColumns = False
        Me.dgvemp.AllowUserToResizeRows = False
        Me.dgvemp.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvemp.ColumnHeadersHeight = 30
        Me.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvemp.GridColor = System.Drawing.Color.Gray
        Me.dgvemp.Location = New System.Drawing.Point(81, 68)
        Me.dgvemp.Name = "dgvemp"
        Me.dgvemp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvemp.RowTemplate.Height = 25
        Me.dgvemp.Size = New System.Drawing.Size(599, 227)
        Me.dgvemp.TabIndex = 6
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.RosyBrown
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(424, 319)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(105, 36)
        Me.btn_exit.TabIndex = 143
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'empreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvemp)
        Me.Name = "empreport"
        Me.Text = "empreport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_print As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvemp As DataGridView
    Friend WithEvents btn_exit As Button
End Class
