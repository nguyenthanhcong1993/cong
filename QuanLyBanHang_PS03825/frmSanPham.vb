Imports System.Data.SqlClient

Public Class frmSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmetPS3825.mssql.somee.com;packet size=4096;user id=thanhcongps03825_SQLLogin_1;pwd=et6cj1mygy;data source=AssignmetPS3825.mssql.somee.com;persist security info=False;initial catalog=AssignmetPS3825"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã Sản Phẩm' ,TENSP as 'Tên Sản Phẩm', GIA as 'Giá', MALOAI from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub btnLUU_Click(sender As Object, e As EventArgs) Handles btnLUU.Click
        If txtMASP.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Sản Phẩm")
            txtMASP.Focus()
        ElseIf txtTENSP.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Sản Phẩm")
            txtTENSP.Focus()
        ElseIf txtGIA.Text = "" Then
            MessageBox.Show("Chưa Nhập Giá")
            txtGIA.Focus()
        ElseIf txtMALOAI.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Loại")
            txtMALOAI.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KHACHHANG values(@MASP,@TENSP,@GIA,@MALOAI)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMASP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
            save.Parameters.AddWithValue("@GIA", txtGIA.Text)
            save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXOA_Click(sender As Object, e As EventArgs) Handles btnXOA.Click
        If txtMASP.Text = "" Then
            MessageBox.Show("Nhập MAKH cần xóa")
            txtTENSP.Focus()
        Else
            Dim delquery As String = "delete from SANPHAM where MASP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSUA_Click(sender As Object, e As EventArgs) Handles btnSUA.Click
        If btnSUA.Text = "Sửa" Then
            txtMASP.ReadOnly = True
            btnSUA.Text = "Cập Nhật"
            txtTENSP.Focus()
        ElseIf btnSUA.Text = "Cập Nhật" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update SANPHAM set MASP=@MASP, TENSP=@TENSP, GIA=@GIA, MALOAI=@MALOAI where MASP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMASP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
            save.Parameters.AddWithValue("@GIA", txtGIA.Text)
            save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMASP.ReadOnly = False
            btnSUA.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMASP.Text = DataGridView1.Item(0, click).Value
        txtTENSP.Text = DataGridView1.Item(1, click).Value
        txtGIA.Text = DataGridView1.Item(2, click).Value
        txtMALOAI.Text = DataGridView1.Item(3, click).Value
    End Sub

    Private Sub btnTHEM_Click(sender As Object, e As EventArgs) Handles btnTHEM.Click
        reset()
    End Sub
    Private Sub reset()
        txtMASP.Text = ""
        txtTENSP.Text = ""
        txtGIA.Text = ""
        txtMALOAI.Text = ""
        txtMASP.Focus()
    End Sub
End Class