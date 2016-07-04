Public Class frmGiaoDien

    Private Sub SảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem1.Click
        frmQLKH.Show()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        frmLoaiSP.Show()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem2.Click
        frmSanPham.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoaDon.Show()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmChiTietHoaDon.Show()
    End Sub

    Private Sub TìmKiếmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmKháchHàngToolStripMenuItem.Click
        frmTimKiem.Show()
    End Sub

    Private Sub TìmKiếmLoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmLoạiSảnPhẩmToolStripMenuItem.Click
        frmTimKiemSP.Show()
    End Sub

    Private Sub TìmKiếmThôngTinSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmThôngTinSảnPhẩmToolStripMenuItem.Click
        frmTimKiemThongTinSanPham.Show()
    End Sub

    Private Sub TrìnhDuyệtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrìnhDuyệtToolStripMenuItem.Click
        frmTrinhDuyet.Show()
    End Sub
End Class