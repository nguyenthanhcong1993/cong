Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQLKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmetPS3825.mssql.somee.com;packet size=4096;user id=thanhcongps03825_SQLLogin_1;pwd=et6cj1mygy;data source=AssignmetPS3825.mssql.somee.com;persist security info=False;initial catalog=AssignmetPS3825"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', EMAIL as 'Email', DIACHI from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub frmQLKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub btnLUU_Click(sender As Object, e As EventArgs) Handles btnLUU.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Khách Hàng")
            txtMAKH.Focus()
        ElseIf txtTENKH.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Khách Hàng")
            txtTENKH.Focus()
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Chưa Nhập Email")
            txtEmail.Focus()
        ElseIf txtDIACHI.Text = "" Then
            MessageBox.Show("Chưa Nhập Địa Chỉ")
            txtDIACHI.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@EMAIL,@DIACHI)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
            save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXOA_Click(sender As Object, e As EventArgs) Handles btnXOA.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("Nhập MAKH cần xóa")
            txtTENKH.Focus()
        Else
            Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSUA_Click(sender As Object, e As EventArgs) Handles btnSUA.Click
        If btnSUA.Text = "Sửa" Then
            txtMAKH.ReadOnly = True
            btnSUA.Text = "Cập Nhật"
            txtTENKH.Focus()
        ElseIf btnSUA.Text = "Cập Nhật" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KHACHHANG set TENKH=@TENKH, EMAIL=@Email, DIACHI=@DIACHI where MAKH=@MAKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
            save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMAKH.ReadOnly = False
            btnSUA.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMAKH.Text = DataGridView1.Item(0, click).Value
        txtTENKH.Text = DataGridView1.Item(1, click).Value
        txtEmail.Text = DataGridView1.Item(2, click).Value
        txtDIACHI.Text = DataGridView1.Item(3, click).Value
    End Sub
    Private Sub reset()
        txtMAKH.Text = ""
        txtTENKH.Text = ""
        txtEmail.Text = ""
        txtDIACHI.Text = ""
        txtMAKH.Focus()
    End Sub
    Private Sub btnTHEM_Click(sender As Object, e As EventArgs) Handles btnTHEM.Click
        reset()
    End Sub
End Class
