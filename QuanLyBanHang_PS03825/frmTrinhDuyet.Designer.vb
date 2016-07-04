<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrinhDuyet
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
        Me.btnGO = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnLUI = New System.Windows.Forms.Button()
        Me.btnTIEN = New System.Windows.Forms.Button()
        Me.btnTAILAI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(681, 10)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(75, 23)
        Me.btnGO.TabIndex = 0
        Me.btnGO.Text = "Go"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 67)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(744, 370)
        Me.WebBrowser1.TabIndex = 1
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(12, 12)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(663, 20)
        Me.txtTimKiem.TabIndex = 2
        '
        'btnLUI
        '
        Me.btnLUI.Location = New System.Drawing.Point(12, 38)
        Me.btnLUI.Name = "btnLUI"
        Me.btnLUI.Size = New System.Drawing.Size(75, 23)
        Me.btnLUI.TabIndex = 3
        Me.btnLUI.Text = "Lùi"
        Me.btnLUI.UseVisualStyleBackColor = True
        '
        'btnTIEN
        '
        Me.btnTIEN.Location = New System.Drawing.Point(93, 38)
        Me.btnTIEN.Name = "btnTIEN"
        Me.btnTIEN.Size = New System.Drawing.Size(75, 23)
        Me.btnTIEN.TabIndex = 3
        Me.btnTIEN.Text = "Tiến"
        Me.btnTIEN.UseVisualStyleBackColor = True
        '
        'btnTAILAI
        '
        Me.btnTAILAI.Location = New System.Drawing.Point(174, 38)
        Me.btnTAILAI.Name = "btnTAILAI"
        Me.btnTAILAI.Size = New System.Drawing.Size(75, 23)
        Me.btnTAILAI.TabIndex = 3
        Me.btnTAILAI.Text = "Tải Lại"
        Me.btnTAILAI.UseVisualStyleBackColor = True
        '
        'frmTrinhDuyet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 449)
        Me.Controls.Add(Me.btnTAILAI)
        Me.Controls.Add(Me.btnTIEN)
        Me.Controls.Add(Me.btnLUI)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnGO)
        Me.Name = "frmTrinhDuyet"
        Me.Text = "Trình Duyệt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtTimKiem As System.Windows.Forms.TextBox
    Friend WithEvents btnLUI As System.Windows.Forms.Button
    Friend WithEvents btnTIEN As System.Windows.Forms.Button
    Friend WithEvents btnTAILAI As System.Windows.Forms.Button
End Class
