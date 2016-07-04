<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.txtGIA = New System.Windows.Forms.TextBox()
        Me.txtTENSP = New System.Windows.Forms.TextBox()
        Me.txtMALOAI = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tên Sản Phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Loại"
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(93, 10)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(100, 20)
        Me.txtMASP.TabIndex = 2
        '
        'txtGIA
        '
        Me.txtGIA.Location = New System.Drawing.Point(41, 45)
        Me.txtGIA.Name = "txtGIA"
        Me.txtGIA.Size = New System.Drawing.Size(100, 20)
        Me.txtGIA.TabIndex = 2
        '
        'txtTENSP
        '
        Me.txtTENSP.Location = New System.Drawing.Point(301, 10)
        Me.txtTENSP.Name = "txtTENSP"
        Me.txtTENSP.Size = New System.Drawing.Size(123, 20)
        Me.txtTENSP.TabIndex = 2
        '
        'txtMALOAI
        '
        Me.txtMALOAI.Location = New System.Drawing.Point(268, 45)
        Me.txtMALOAI.Name = "txtMALOAI"
        Me.txtMALOAI.Size = New System.Drawing.Size(100, 20)
        Me.txtMALOAI.TabIndex = 2
        '
        'btnTHEM
        '
        Me.btnTHEM.Location = New System.Drawing.Point(442, 13)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(75, 23)
        Me.btnTHEM.TabIndex = 3
        Me.btnTHEM.Text = "Thêm"
        Me.btnTHEM.UseVisualStyleBackColor = True
        '
        'btnLUU
        '
        Me.btnLUU.Location = New System.Drawing.Point(523, 13)
        Me.btnLUU.Name = "btnLUU"
        Me.btnLUU.Size = New System.Drawing.Size(75, 23)
        Me.btnLUU.TabIndex = 4
        Me.btnLUU.Text = "Lưu"
        Me.btnLUU.UseVisualStyleBackColor = True
        '
        'btnSUA
        '
        Me.btnSUA.Location = New System.Drawing.Point(442, 43)
        Me.btnSUA.Name = "btnSUA"
        Me.btnSUA.Size = New System.Drawing.Size(75, 23)
        Me.btnSUA.TabIndex = 3
        Me.btnSUA.Text = "Sửa"
        Me.btnSUA.UseVisualStyleBackColor = True
        '
        'btnXOA
        '
        Me.btnXOA.Location = New System.Drawing.Point(523, 43)
        Me.btnXOA.Name = "btnXOA"
        Me.btnXOA.Size = New System.Drawing.Size(75, 23)
        Me.btnXOA.TabIndex = 4
        Me.btnXOA.Text = "Xóa"
        Me.btnXOA.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 229)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnXOA)
        Me.Controls.Add(Me.btnLUU)
        Me.Controls.Add(Me.btnSUA)
        Me.Controls.Add(Me.btnTHEM)
        Me.Controls.Add(Me.txtMALOAI)
        Me.Controls.Add(Me.txtGIA)
        Me.Controls.Add(Me.txtTENSP)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSanPham"
        Me.Text = "Quản Lý Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents txtGIA As System.Windows.Forms.TextBox
    Friend WithEvents txtTENSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMALOAI As System.Windows.Forms.TextBox
    Friend WithEvents btnTHEM As System.Windows.Forms.Button
    Friend WithEvents btnLUU As System.Windows.Forms.Button
    Friend WithEvents btnSUA As System.Windows.Forms.Button
    Friend WithEvents btnXOA As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
