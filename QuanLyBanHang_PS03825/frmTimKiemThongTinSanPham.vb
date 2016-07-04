Imports System.Data.SqlClient

Public Class frmTimKiemThongTinSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmetPS3825.mssql.somee.com;packet size=4096;user id=thanhcongps03825_SQLLogin_1;pwd=et6cj1mygy;data source=AssignmetPS3825.mssql.somee.com;persist security info=False;initial catalog=AssignmetPS3825"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    Private Sub frmTimKiemThongTinSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã Sản Phẩm' ,TENSP as 'Tên Sản Phẩm', GIA as 'Giá', MALOAI from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvTIMKIEMSP.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub SearchTimKiemSanPham(value As String)
        Dim sqlQuery As String = String.Format("select MASP as 'Mã Sản Phẩm' ,TENSP as 'Tên Sản Phẩm', GIA as 'Giá', MALOAI from SANPHAM")
        If cboTIMKIEM.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MASP like '{0}%'", value)
        ElseIf cboTIMKIEM.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TENSP LIKE N'{0}%'", value)
        ElseIf cboTIMKIEM.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where GIA LIKE N'{0}%'", value)
        ElseIf cboTIMKIEM.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where MALOAI LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgvTIMKIEMSP.DataSource = data
        With dgvTIMKIEMSP
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Tên Sản Phẩm"
            .Columns(2).HeaderText = "Giá"
            .Columns(3).HeaderText = "Mã Loại"
        End With
    End Sub
    Private Sub txtTIMKIEMSP_TextChanged(sender As Object, e As EventArgs) Handles txtTIMKIEMSP.TextChanged
        SearchTimKiemSanPham(txtTIMKIEMSP.Text)
    End Sub
End Class