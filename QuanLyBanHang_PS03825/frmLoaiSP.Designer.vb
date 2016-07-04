<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMALOAI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTENLOAISP = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTHEM = New System.Windows.Forms.Button()
        Me.btnLUU = New System.Windows.Forms.Button()
        Me.btnSUA = New System.Windows.Forms.Button()
        Me.btnXOA = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Loại Sản Phẩm"
        '
        'txtMALOAI
        '
        Me.txtMALOAI.Location = New System.Drawing.Point(116, 6)
        Me.txtMALOAI.Name = "txtMALOAI"
        Me.txtMALOAI.Size = New System.Drawing.Size(100, 20)
        Me.txtMALOAI.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Loại Sản Phẩm"
        '
        'txtTENLOAISP
        '
        Me.txtTENLOAISP.Location = New System.Drawing.Point(329, 6)
        Me.txtTENLOAISP.Name = "txtTENLOAISP"
        Me.txtTENLOAISP.Size = New System.Drawing.Size(100, 20)
        Me.txtTENLOAISP.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(416, 169)
        Me.DataGridView1.TabIndex = 4
        '
        'btnTHEM
        '
        Me.btnTHEM.Location = New System.Drawing.Point(12, 30)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(75, 23)
        Me.btnTHEM.TabIndex = 5
        Me.btnTHEM.Text = "Thêm"
        Me.btnTHEM.UseVisualStyleBackColor = True
        '
        'btnLUU
        '
        Me.btnLUU.Location = New System.Drawing.Point(116, 30)
        Me.btnLUU.Name = "btnLUU"
        Me.btnLUU.Size = New System.Drawing.Size(75, 23)
        Me.btnLUU.TabIndex = 6
        Me.btnLUU.Text = "Lưu"
        Me.btnLUU.UseVisualStyleBackColor = True
        '
        'btnSUA
        '
        Me.btnSUA.Location = New System.Drawing.Point(248, 30)
        Me.btnSUA.Name = "btnSUA"
        Me.btnSUA.Size = New System.Drawing.Size(75, 23)
        Me.btnSUA.TabIndex = 7
        Me.btnSUA.Text = "Sửa"
        Me.btnSUA.UseVisualStyleBackColor = True
        '
        'btnXOA
        '
        Me.btnXOA.Location = New System.Drawing.Point(353, 30)
        Me.btnXOA.Name = "btnXOA"
        Me.btnXOA.Size = New System.Drawing.Size(75, 23)
        Me.btnXOA.TabIndex = 8
        Me.btnXOA.Text = "Xóa"
        Me.btnXOA.UseVisualStyleBackColor = True
        '
        'frmLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 240)
        Me.Controls.Add(Me.btnXOA)
        Me.Controls.Add(Me.btnSUA)
        Me.Controls.Add(Me.btnLUU)
        Me.Controls.Add(Me.btnTHEM)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtTENLOAISP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMALOAI)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLoaiSP"
        Me.Text = "Nhập Loại Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMALOAI As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTENLOAISP As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTHEM As System.Windows.Forms.Button
    Friend WithEvents btnLUU As System.Windows.Forms.Button
    Friend WithEvents btnSUA As System.Windows.Forms.Button
    Friend WithEvents btnXOA As System.Windows.Forms.Button
End Class
