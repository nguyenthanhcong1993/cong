<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemSP
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
        Me.cmbTKSP = New System.Windows.Forms.ComboBox()
        Me.txtTIMSP = New System.Windows.Forms.TextBox()
        Me.dgvTKSP = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTKSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tìm Kiếm Sản Phẩm"
        '
        'cmbTKSP
        '
        Me.cmbTKSP.FormattingEnabled = True
        Me.cmbTKSP.Items.AddRange(New Object() {"Mã Loại", "Tên Loại Sản Phẩm"})
        Me.cmbTKSP.Location = New System.Drawing.Point(120, 6)
        Me.cmbTKSP.Name = "cmbTKSP"
        Me.cmbTKSP.Size = New System.Drawing.Size(121, 21)
        Me.cmbTKSP.TabIndex = 1
        '
        'txtTIMSP
        '
        Me.txtTIMSP.Location = New System.Drawing.Point(248, 6)
        Me.txtTIMSP.Name = "txtTIMSP"
        Me.txtTIMSP.Size = New System.Drawing.Size(180, 20)
        Me.txtTIMSP.TabIndex = 2
        '
        'dgvTKSP
        '
        Me.dgvTKSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTKSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTKSP.Location = New System.Drawing.Point(1, 33)
        Me.dgvTKSP.Name = "dgvTKSP"
        Me.dgvTKSP.Size = New System.Drawing.Size(427, 236)
        Me.dgvTKSP.TabIndex = 3
        '
        'frmTimKiemSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 281)
        Me.Controls.Add(Me.dgvTKSP)
        Me.Controls.Add(Me.txtTIMSP)
        Me.Controls.Add(Me.cmbTKSP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTimKiemSP"
        Me.Text = "Tìm Kiếm Sản Phẩm"
        CType(Me.dgvTKSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTKSP As System.Windows.Forms.ComboBox
    Friend WithEvents txtTIMSP As System.Windows.Forms.TextBox
    Friend WithEvents dgvTKSP As System.Windows.Forms.DataGridView
End Class
