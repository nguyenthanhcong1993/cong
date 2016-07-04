Public Class frmTrinhDuyet

    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        WebBrowser1.Navigate(txtTimKiem.Text)
    End Sub
    Private Sub btnLUI_Click(sender As Object, e As EventArgs) Handles btnLUI.Click
        WebBrowser1.GoBack()
    End Sub
    Private Sub btnTIEN_Click(sender As Object, e As EventArgs) Handles btnTIEN.Click
        WebBrowser1.GoForward()
    End Sub
    Private Sub btnTAILAI_Click(sender As Object, e As EventArgs) Handles btnTAILAI.Click
        WebBrowser1.Refresh()
    End Sub
    Private Sub frmTrinhDuyet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class