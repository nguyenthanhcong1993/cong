Imports System.Data.SqlClient

Public Class frmLoaiSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmetPS3825.mssql.somee.com;packet size=4096;user id=thanhcongps03825_SQLLogin_1;pwd=et6cj1mygy;data source=AssignmetPS3825.mssql.somee.com;persist security info=False;initial catalog=AssignmetPS3825"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MALOAI as 'Mã Loại' ,TENLOAI as 'Tên Loại' from LOAISP ", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub frmLoaiSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLUU_Click(sender As Object, e As EventArgs) Handles btnLUU.Click
        If txtMALOAI.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Loại")
            txtMALOAI.Focus()
        ElseIf txtTENLOAISP.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Loại SP")
            txtTENLOAISP.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into LOAISP values(@MALOAI,@TENLOAI)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
            save.Parameters.AddWithValue("@TENLOAI", txtTENLOAISP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXOA_Click(sender As Object, e As EventArgs) Handles btnXOA.Click
        If txtMALOAI.Text = "" Then
            MessageBox.Show("Nhập Mã Loại Sản Phẩm cần xóa")
            txtTENLOAISP.Focus()
        Else
            Dim delquery As String = "delete from LOAISP where MALOAI=@MALOAI"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSUA_Click(sender As Object, e As EventArgs) Handles btnSUA.Click
        If btnSUA.Text = "Sửa" Then
            txtMALOAI.ReadOnly = True
            btnSUA.Text = "Cập Nhật"
            txtTENLOAISP.Focus()
        ElseIf btnSUA.Text = "Cập Nhật" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update LOAISP set MALOAI=@MALOAI, TENLOAI=@TENLOAI"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
            save.Parameters.AddWithValue("@TENLOAI", txtTENLOAISP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMALOAI.ReadOnly = False
            btnSUA.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMALOAI.Text = DataGridView1.Item(0, click).Value
        txtTENLOAISP.Text = DataGridView1.Item(1, click).Value
    End Sub
End Class