Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmTimKiem
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmetPS3825.mssql.somee.com;packet size=4096;user id=thanhcongps03825_SQLLogin_1;pwd=et6cj1mygy;data source=AssignmetPS3825.mssql.somee.com;persist security info=False;initial catalog=AssignmetPS3825"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', EMAIL as 'Email', DIACHI from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvTIMKIEM.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub txtTIMKIEM_TextChanged(sender As Object, e As EventArgs) Handles txtTIMKIEM.TextChanged
        SearchKhachHang(txtTIMKIEM.Text)
    End Sub

    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub SearchKhachHang(value As String)
        Dim sqlQuery As String = String.Format("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', EMAIL as 'Email', DIACHI from KHACHHANG")
        If cmbTRACUU.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaKH like '{0}%'", value)
        ElseIf cmbTRACUU.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TENKH LIKE N'{0}%'", value)
        ElseIf cmbTRACUU.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where DIACHI LIKE N'{0}%'", value)
        ElseIf cmbTRACUU.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where EMAIL LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgvTIMKIEM.DataSource = data
        With dgvTIMKIEM
            .Columns(0).HeaderText = "Mã KH"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Địa Chỉ"
            .Columns(3).HeaderText = "Email"
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTIMKIEM.CellContentClick

    End Sub
End Class