<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.txtSOHD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNGAYHD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.btnLUU = New System.Windows.Forms.Button()
        Me.btnTHEM = New System.Windows.Forms.Button()
        Me.btnSUA = New System.Windows.Forms.Button()
        Me.btnXOA = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số Hóa Đơn"
        '
        'txtSOHD
        '
        Me.txtSOHD.Location = New System.Drawing.Point(97, 5)
        Me.txtSOHD.Name = "txtSOHD"
        Me.txtSOHD.Size = New System.Drawing.Size(100, 20)
        Me.txtSOHD.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ngày Hóa Đơn"
        '
        'txtNGAYHD
        '
        Me.txtNGAYHD.Location = New System.Drawing.Point(97, 43)
        Me.txtNGAYHD.Name = "txtNGAYHD"
        Me.txtNGAYHD.Size = New System.Drawing.Size(100, 20)
        Me.txtNGAYHD.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã Khách Hàng"
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(295, 5)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(100, 20)
        Me.txtMAKH.TabIndex = 1
        '
        'btnLUU
        '
        Me.btnLUU.Location = New System.Drawing.Point(482, 4)
        Me.btnLUU.Name = "btnLUU"
        Me.btnLUU.Size = New System.Drawing.Size(75, 23)
        Me.btnLUU.TabIndex = 2
        Me.btnLUU.Text = "Lưu"
        Me.btnLUU.UseVisualStyleBackColor = True
        '
        'btnTHEM
        '
        Me.btnTHEM.Location = New System.Drawing.Point(401, 4)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(75, 23)
        Me.btnTHEM.TabIndex = 3
        Me.btnTHEM.Text = "Thêm"
        Me.btnTHEM.UseVisualStyleBackColor = True
        '
        'btnSUA
        '
        Me.btnSUA.Location = New System.Drawing.Point(401, 33)
        Me.btnSUA.Name = "btnSUA"
        Me.btnSUA.Size = New System.Drawing.Size(75, 23)
        Me.btnSUA.TabIndex = 3
        Me.btnSUA.Text = "Sửa"
        Me.btnSUA.UseVisualStyleBackColor = True
        '
        'btnXOA
        '
        Me.btnXOA.Location = New System.Drawing.Point(482, 33)
        Me.btnXOA.Name = "btnXOA"
        Me.btnXOA.Size = New System.Drawing.Size(75, 23)
        Me.btnXOA.TabIndex = 3
        Me.btnXOA.Text = "Xóa"
        Me.btnXOA.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 203)
        Me.DataGridView1.TabIndex = 4
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 284)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnXOA)
        Me.Controls.Add(Me.btnSUA)
        Me.Controls.Add(Me.btnTHEM)
        Me.Controls.Add(Me.btnLUU)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.txtNGAYHD)
        Me.Controls.Add(Me.txtSOHD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHoaDon"
        Me.Text = "Quản Lý Hóa Đơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSOHD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNGAYHD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents btnLUU As System.Windows.Forms.Button
    Friend WithEvents btnTHEM As System.Windows.Forms.Button
    Friend WithEvents btnSUA As System.Windows.Forms.Button
    Friend WithEvents btnXOA As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
