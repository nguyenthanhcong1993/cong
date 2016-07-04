Imports System.Data.SqlClient

Public Class frmHoaDon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmetPS3825.mssql.somee.com;packet size=4096;user id=thanhcongps03825_SQLLogin_1;pwd=et6cj1mygy;data source=AssignmetPS3825.mssql.somee.com;persist security info=False;initial catalog=AssignmetPS3825"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SOHD as 'Số Hóa Đơn' ,MAKH as 'Mã Khách Hàng', NGAYHD as 'Ngày Hóa Đơn' from HOADON", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub btnLUU_Click(sender As Object, e As EventArgs) Handles btnLUU.Click
        If txtSOHD.Text = "" Then
            MessageBox.Show("Chưa Nhập Số Hóa Đơn")
            txtSOHD.Focus()
        ElseIf txtMAKH.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Khách Hàng")
            txtMAKH.Focus()
        ElseIf txtNGAYHD.Text = "" Then
            MessageBox.Show("Chưa Nhập Giá")
            txtNGAYHD.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into HOADON values(@SOHD,@MAKH,@NGAYHD)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@NGAYHD", txtNGAYHD.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXOA_Click(sender As Object, e As EventArgs) Handles btnXOA.Click
        If txtSOHD.Text = "" Then
            MessageBox.Show("Nhập Số Hóa Đơn cần xóa")
            txtMAKH.Focus()
        Else
            Dim delquery As String = "delete from HOADON where SOHD=@SOHD"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSUA_Click(sender As Object, e As EventArgs) Handles btnSUA.Click
        If btnSUA.Text = "Sửa" Then
            txtSOHD.ReadOnly = True
            btnSUA.Text = "Cập Nhật"
            txtMAKH.Focus()
        ElseIf btnSUA.Text = "Cập Nhật" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update HOADON set SOHD=@SOHD, MAKH=@MAKH, NGAYHD=@NGAYHD where SOHD=@SOHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@NGAYHD", txtNGAYHD.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtSOHD.ReadOnly = False
            btnSUA.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtSOHD.Text = DataGridView1.Item(0, click).Value
        txtMAKH.Text = DataGridView1.Item(1, click).Value
        txtNGAYHD.Text = DataGridView1.Item(2, click).Value
    End Sub

    Private Sub btnTHEM_Click(sender As Object, e As EventArgs) Handles btnTHEM.Click
        reset()
    End Sub
    Private Sub reset()
        txtSOHD.Text = ""
        txtMAKH.Text = ""
        txtNGAYHD.Text = ""
        txtSOHD.Focus()
    End Sub
End Class