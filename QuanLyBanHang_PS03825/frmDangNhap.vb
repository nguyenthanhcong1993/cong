Public Class frmDangNhap

    Private Sub txtEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub txtLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        If txtUSER.Text = "admin" And txtPASS.Text = "password" Then
            frmGiaoDien.Show()
        Else
            MsgBox("Bạn đã nhập sai tài khoản hoặc mật khẩu!")
        End If
    End Sub
End Class