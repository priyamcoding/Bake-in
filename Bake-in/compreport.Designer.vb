<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(compreport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvcomp = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvcomp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(282, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "COMPLAINT REPORT"
        '
        'dgvcomp
        '
        Me.dgvcomp.AllowUserToAddRows = False
        Me.dgvcomp.AllowUserToDeleteRows = False
        Me.dgvcomp.AllowUserToResizeColumns = False
        Me.dgvcomp.AllowUserToResizeRows = False
        Me.dgvcomp.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvcomp.ColumnHeadersHeight = 30
        Me.dgvcomp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvcomp.GridColor = System.Drawing.Color.Gray
        Me.dgvcomp.Location = New System.Drawing.Point(46, 71)
        Me.dgvcomp.Name = "dgvcomp"
        Me.dgvcomp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvcomp.RowTemplate.Height = 25
        Me.dgvcomp.Size = New System.Drawing.Size(539, 261)
        Me.dgvcomp.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.RosyBrown
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(480, 338)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 36)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'compreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvcomp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "compreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "compreport"
        CType(Me.dgvcomp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvcomp As DataGridView
    Friend WithEvents btnExit As Button
End Class
