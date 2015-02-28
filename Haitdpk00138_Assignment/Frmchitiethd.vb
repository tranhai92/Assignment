Imports System.Data
Imports System.Data.SqlClient
Public Class Frmchitiethd
    Dim data As New SqlConnection("Data Source=.;Initial Catalog=haitdpk00138;Integrated Security=True")
    Private Sub chaydulieu()
        data.Open()
        Dim load As New SqlCommand("select * from chitiethd", data)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatable As New DataTable
        sqldata.Fill(sqldatatable)
        data.Close()
        lstchitiet.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatable.Rows
            lstchitiet.Items.Add(Row("machitiet").ToString())
            lstchitiet.Items(a).SubItems.Add(Row("mahoadon").ToString())
            lstchitiet.Items(a).SubItems.Add(Row("makh").ToString())
            lstchitiet.Items(a).SubItems.Add(Row("macongto").ToString())
            lstchitiet.Items(a).SubItems.Add(Row("dientieuthu").ToString())
            lstchitiet.Items(a).SubItems.Add(Row("dongia").ToString())
            a += 1
        Next
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If (KiemTraThongTin() = True) Then
            Try
                data.Open()
                Dim Machitiet As String = txtmachitiet.Text
                Dim mahd As String = txtmahd.Text
                Dim makh As String = Txttmakh.Text
                Dim mact As String = txtmact.Text
                Dim dientt As String = txttieuthu.Text
                Dim dongia As String = txtdongia.Text
                Dim them As New SqlCommand("Insert into chitiethd(machitiet,mahoadon,makh,macongto,dientieuthu,dongia) values('" + Machitiet + "' , '" + mahd + "', '" + makh + "' ,'" + mact + "','" + dientt + "','" + dongia + "')", data)
                them.ExecuteNonQuery()
                data.Close()
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chaydulieu()
            Catch ex As Exception
                MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ClearBox()
        End If
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chaydulieu()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (dialogResult = Windows.Forms.DialogResult.Yes) Then
            Close()
        End If
    End Sub


    Private Sub ClearBox()
        txtmachitiet.Text = ""
        txtmahd.Text = ""
        Txttmakh.Text = ""
        txtmact.Text = ""
        txttieuthu.Text = ""
        txtdongia.Text = ""
    End Sub
    Private Sub lstchitiet_select(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstchitiet.SelectedIndexChanged
        If lstchitiet.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstchitiet.SelectedItems
                txtmachitiet.Text = lis.SubItems(0).Text
                txtmahd.Text = lis.SubItems(1).Text
                Txttmakh.Text = lis.SubItems(2).Text
                txtmact.Text = lis.SubItems(3).Text
                txttieuthu.Text = lis.SubItems(4).Text
                txtdongia.Text = lis.SubItems(5).Text
                btnDelete.Enabled = True
                btnEdit.Enabled = True
            Next
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            data.Open()
            Dim Machitiet As String = txtmachitiet.Text
            Dim xoa As New SqlCommand("delete from chitiethd where machitiet ='" + Machitiet + "'", data)
            xoa.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = Windows.Forms.DialogResult.Yes) Then
                chaydulieu()
            End If
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            data.Open()
            Dim Machitiet As String = txtmachitiet.Text
            Dim mahd As String = txtmahd.Text
            Dim makh As String = Txttmakh.Text
            Dim mact As String = txtmact.Text
            Dim tieuthu As String = txttieuthu.Text
            Dim dongia As String = txtdongia.Text
            Dim sua As New SqlCommand("update chitiethd set Mahoadon = '" + mahd + "', makh= '" + makh + "' , macongto= '" + mact + "', dientieuthu= '" + tieuthu + "', dongia= '" + dongia + "'  where Machitiet = '" + Machitiet + "'", data)
            sua.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = Windows.Forms.DialogResult.Yes) Then
                chaydulieu()
            End If
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Hàm kiểm tra thông tin. Nếu thông tin đầy đủ thì trả về là True, ngược lại False 
    Private Function KiemTraThongTin() As Boolean

        If (txtmachitiet.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã chi tiết", "Thông báo")
            Return False
        ElseIf (txtmahd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã hóa đơn", "Thông báo")
            Return False
        ElseIf (Txttmakh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng mã khách hàng", "Thông báo")
            Return False
        ElseIf (txtmact.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã công tơ", "Thông báo")
            Return False
        ElseIf (txttieuthu.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập số điện tiêu thụ", "Thông báo")
            Return False
        ElseIf (txtdongia.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo")
            Return False

        End If

        Return True
    End Function
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmahd.TextChanged, txtmahd.TextChanged, txtmachitiet.TextChanged
        If (txtmahd.Text.Trim = "") Then
            btnAddNew.Enabled = False
        Else
            btnAddNew.Enabled = True
        End If
    End Sub

End Class