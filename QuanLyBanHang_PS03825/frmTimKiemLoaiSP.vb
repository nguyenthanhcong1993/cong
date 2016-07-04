Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmTimKiemSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmetPS3825.mssql.somee.com;packet size=4096;user id=thanhcongps03825_SQLLogin_1;pwd=et6cj1mygy;data source=AssignmetPS3825.mssql.somee.com;persist security info=False;initial catalog=AssignmetPS3825"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    Private Sub frmTimKiemSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MALOAI as 'Mã Loại' ,TENLOAI as 'Tên Loại' from LOAISP ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvTKSP.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub txtTIMSP_TextChanged(sender As Object, e As EventArgs) Handles txtTIMSP.TextChanged
        SearchTIMKIEMSANPHAM(txtTIMSP.Text)
    End Sub
    Private Sub SearchTIMKIEMSANPHAM(value As String)
        Dim sqlQuery As String = String.Format("select MALOAI as 'Mã Loại' ,TENLOAI as 'Tên Loại' from LOAISP ")
        If cmbTKSP.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MALOAI like '{0}%'", value)
        ElseIf cmbTKSP.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TENLOAI LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgvTKSP.DataSource = data
        With dgvTKSP
            .Columns(0).HeaderText = "Mã Loại"
            .Columns(1).HeaderText = "Tên Loại"
        End With
    End Sub
End Class