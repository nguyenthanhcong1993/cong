<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemThongTinSanPham
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
        Me.cboTIMKIEM = New System.Windows.Forms.ComboBox()
        Me.txtTIMKIEMSP = New System.Windows.Forms.TextBox()
        Me.dgvTIMKIEMSP = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTIMKIEMSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tìm Kiếm Thông Tin"
        '
        'cboTIMKIEM
        '
        Me.cboTIMKIEM.FormattingEnabled = True
        Me.cboTIMKIEM.Items.AddRange(New Object() {"Mã Sản Phẩm", "Tên Sản Phẩm", "Giá", "Mã Loại"})
        Me.cboTIMKIEM.Location = New System.Drawing.Point(122, 4)
        Me.cboTIMKIEM.Name = "cboTIMKIEM"
        Me.cboTIMKIEM.Size = New System.Drawing.Size(121, 21)
        Me.cboTIMKIEM.TabIndex = 1
        '
        'txtTIMKIEMSP
        '
        Me.txtTIMKIEMSP.Location = New System.Drawing.Point(250, 4)
        Me.txtTIMKIEMSP.Name = "txtTIMKIEMSP"
        Me.txtTIMKIEMSP.Size = New System.Drawing.Size(318, 20)
        Me.txtTIMKIEMSP.TabIndex = 2
        '
        'dgvTIMKIEMSP
        '
        Me.dgvTIMKIEMSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTIMKIEMSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTIMKIEMSP.Location = New System.Drawing.Point(13, 30)
        Me.dgvTIMKIEMSP.Name = "dgvTIMKIEMSP"
        Me.dgvTIMKIEMSP.Size = New System.Drawing.Size(555, 249)
        Me.dgvTIMKIEMSP.TabIndex = 3
        '
        'frmTimKiemThongTinSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 291)
        Me.Controls.Add(Me.dgvTIMKIEMSP)
        Me.Controls.Add(Me.txtTIMKIEMSP)
        Me.Controls.Add(Me.cboTIMKIEM)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTimKiemThongTinSanPham"
        Me.Text = "Tìm Kiếm Thông Tin Sản Phẩm"
        CType(Me.dgvTIMKIEMSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTIMKIEM As System.Windows.Forms.ComboBox
    Friend WithEvents txtTIMKIEMSP As System.Windows.Forms.TextBox
    Friend WithEvents dgvTIMKIEMSP As System.Windows.Forms.DataGridView
End Class
