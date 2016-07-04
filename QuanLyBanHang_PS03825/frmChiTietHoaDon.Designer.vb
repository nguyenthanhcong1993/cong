<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietHoaDon
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSOHD = New System.Windows.Forms.TextBox()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.txtSOLUONG = New System.Windows.Forms.TextBox()
        Me.btnTHEM = New System.Windows.Forms.Button()
        Me.btnLUU = New System.Windows.Forms.Button()
        Me.btnSUA = New System.Windows.Forms.Button()
        Me.btnXOA = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Số Lượng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã Sản Phẩm"
        '
        'txtSOHD
        '
        Me.txtSOHD.Location = New System.Drawing.Point(81, 8)
        Me.txtSOHD.Name = "txtSOHD"
        Me.txtSOHD.Size = New System.Drawing.Size(100, 20)
        Me.txtSOHD.TabIndex = 1
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(442, 6)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(100, 20)
        Me.txtMASP.TabIndex = 1
        '
        'txtSOLUONG
        '
        Me.txtSOLUONG.Location = New System.Drawing.Point(256, 8)
        Me.txtSOLUONG.Name = "txtSOLUONG"
        Me.txtSOLUONG.Size = New System.Drawing.Size(100, 20)
        Me.txtSOLUONG.TabIndex = 1
        '
        'btnTHEM
        '
        Me.btnTHEM.Location = New System.Drawing.Point(15, 34)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(75, 23)
        Me.btnTHEM.TabIndex = 2
        Me.btnTHEM.Text = "Thêm"
        Me.btnTHEM.UseVisualStyleBackColor = True
        '
        'btnLUU
        '
        Me.btnLUU.Location = New System.Drawing.Point(165, 34)
        Me.btnLUU.Name = "btnLUU"
        Me.btnLUU.Size = New System.Drawing.Size(75, 23)
        Me.btnLUU.TabIndex = 2
        Me.btnLUU.Text = "Lưu"
        Me.btnLUU.UseVisualStyleBackColor = True
        '
        'btnSUA
        '
        Me.btnSUA.Location = New System.Drawing.Point(281, 34)
        Me.btnSUA.Name = "btnSUA"
        Me.btnSUA.Size = New System.Drawing.Size(75, 23)
        Me.btnSUA.TabIndex = 2
        Me.btnSUA.Text = "Sửa"
        Me.btnSUA.UseVisualStyleBackColor = True
        '
        'btnXOA
        '
        Me.btnXOA.Location = New System.Drawing.Point(442, 32)
        Me.btnXOA.Name = "btnXOA"
        Me.btnXOA.Size = New System.Drawing.Size(75, 23)
        Me.btnXOA.TabIndex = 2
        Me.btnXOA.Text = "Xóa"
        Me.btnXOA.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(529, 200)
        Me.DataGridView1.TabIndex = 3
        '
        'frmChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 276)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnXOA)
        Me.Controls.Add(Me.btnSUA)
        Me.Controls.Add(Me.btnLUU)
        Me.Controls.Add(Me.btnTHEM)
        Me.Controls.Add(Me.txtSOLUONG)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.txtSOHD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChiTietHoaDon"
        Me.Text = "Chi Tiết Hóa Đơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSOHD As System.Windows.Forms.TextBox
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents txtSOLUONG As System.Windows.Forms.TextBox
    Friend WithEvents btnTHEM As System.Windows.Forms.Button
    Friend WithEvents btnLUU As System.Windows.Forms.Button
    Friend WithEvents btnSUA As System.Windows.Forms.Button
    Friend WithEvents btnXOA As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
