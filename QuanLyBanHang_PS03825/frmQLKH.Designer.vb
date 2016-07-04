<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLKH
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.txtTENKH = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDIACHI = New System.Windows.Forms.TextBox()
        Me.btnTHEM = New System.Windows.Forms.Button()
        Me.btnSUA = New System.Windows.Forms.Button()
        Me.btnLUU = New System.Windows.Forms.Button()
        Me.btnXOA = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Địa Chỉ"
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(311, 15)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(100, 20)
        Me.txtMAKH.TabIndex = 4
        '
        'txtTENKH
        '
        Me.txtTENKH.Location = New System.Drawing.Point(512, 15)
        Me.txtTENKH.Name = "txtTENKH"
        Me.txtTENKH.Size = New System.Drawing.Size(172, 20)
        Me.txtTENKH.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(223, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(623, 196)
        Me.DataGridView1.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(258, 50)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(153, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtDIACHI
        '
        Me.txtDIACHI.Location = New System.Drawing.Point(465, 45)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(219, 20)
        Me.txtDIACHI.TabIndex = 8
        '
        'btnTHEM
        '
        Me.btnTHEM.Location = New System.Drawing.Point(690, 13)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(75, 23)
        Me.btnTHEM.TabIndex = 9
        Me.btnTHEM.Text = "Thêm"
        Me.btnTHEM.UseVisualStyleBackColor = True
        '
        'btnSUA
        '
        Me.btnSUA.Location = New System.Drawing.Point(690, 43)
        Me.btnSUA.Name = "btnSUA"
        Me.btnSUA.Size = New System.Drawing.Size(75, 23)
        Me.btnSUA.TabIndex = 10
        Me.btnSUA.Text = "Sửa"
        Me.btnSUA.UseVisualStyleBackColor = True
        '
        'btnLUU
        '
        Me.btnLUU.Location = New System.Drawing.Point(771, 13)
        Me.btnLUU.Name = "btnLUU"
        Me.btnLUU.Size = New System.Drawing.Size(75, 23)
        Me.btnLUU.TabIndex = 11
        Me.btnLUU.Text = "Lưu"
        Me.btnLUU.UseVisualStyleBackColor = True
        '
        'btnXOA
        '
        Me.btnXOA.Location = New System.Drawing.Point(771, 42)
        Me.btnXOA.Name = "btnXOA"
        Me.btnXOA.Size = New System.Drawing.Size(75, 23)
        Me.btnXOA.TabIndex = 12
        Me.btnXOA.Text = "Xóa"
        Me.btnXOA.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuanLyBanHang_PS03825.My.Resources.Resources.crm_1_jpg_1437639763
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'frmQLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 300)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnXOA)
        Me.Controls.Add(Me.btnLUU)
        Me.Controls.Add(Me.btnSUA)
        Me.Controls.Add(Me.btnTHEM)
        Me.Controls.Add(Me.txtDIACHI)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtTENKH)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLKH"
        Me.Text = "Quản Lý Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTENKH As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents btnTHEM As System.Windows.Forms.Button
    Friend WithEvents btnSUA As System.Windows.Forms.Button
    Friend WithEvents btnLUU As System.Windows.Forms.Button
    Friend WithEvents btnXOA As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
