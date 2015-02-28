Imports System.Data
Imports System.Data.SqlClient

Public Class Frmhoadon
    Dim data As New SqlConnection("Data Source=.;Initial Catalog=haitdpk00138;Integrated Security=True")
    Private Sub chaydulieu()
        data.Open()
        Dim load As New SqlCommand("select * from hoadon", data)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        data.Close()
        lsthd.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsthd.Items.Add(Row("Mahoadon").ToString())
            lsthd.Items(a).SubItems.Add(Row("macongto").ToString())
            lsthd.Items(a).SubItems.Add(Row("kwtieuthu").ToString())
            lsthd.Items(a).SubItems.Add(Row("Thanhtien").ToString())
            lsthd.Items(a).SubItems.Add(Row("Trangthai").ToString())
            a += 1
        Next
    End Sub

    Private Sub btnAddNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If (KiemTraThongTin() = True) Then
            Try
                data.Open()
                Dim Mahd As String = txtmahd.Text
                Dim mact As String = txtmact.Text
                Dim tieuthu As String = Txttieuthu.Text
                Dim thanhtien As String = txtthanhtien.Text
                Dim trangthai As String = txttrangthai.Text
                Dim them As New SqlCommand("Insert into hoadon(mahoadon,macongto,kwtieuthu,thanhtien,trangthai) values('" + Mahd + "' , '" + mact + "', '" + tieuthu + "' ,'" + thanhtien + "','" + trangthai + "')", data)
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
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chaydulieu()
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (dialogResult = Windows.Forms.DialogResult.Yes) Then
            Close()
        End If
    End Sub


    Private Sub ClearBox()
        txtmahd.Text = ""
        txtmact.Text = ""
        Txttieuthu.Text = ""
        txtthanhtien.Text = ""
        txttrangthai.Text = ""
    End Sub
    Private Sub lsthd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsthd.SelectedIndexChanged
        If lsthd.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsthd.SelectedItems
                txtmahd.Text = lis.SubItems(0).Text
                txtmact.Text = lis.SubItems(1).Text
                Txttieuthu.Text = lis.SubItems(2).Text
                txtthanhtien.Text = lis.SubItems(3).Text
                txttrangthai.Text = lis.SubItems(4).Text
                btnDelete.Enabled = True
                btnEdit.Enabled = True
            Next
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            data.Open()
            Dim Mahd As String = txtmahd.Text
            Dim xoa As New SqlCommand("delete from hoadon where mahoadon ='" + Mahd + "'", data)
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
            Dim Mahd As String = txtmahd.Text
            Dim mact As String = txtmact.Text
            Dim tieuthu As String = Txttieuthu.Text
            Dim thanhtien As String = txtthanhtien.Text
            Dim trangthai As String = txttrangthai.Text
            Dim sua As New SqlCommand("update hoadon set Macongto = '" + mact + "', Kwtieuthu= '" + tieuthu + "' , Thanhtien= '" + thanhtien + "', trangthai= '" + trangthai + "'  where Mahoadon = '" + Mahd + "'", data)
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

        If (txtmahd.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã hóa đơn", "Thông báo")
            Return False
        ElseIf (txtmact.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã công tơ", "Thông báo")
            Return False
        ElseIf (Txttieuthu.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập điện tiêu thụ (KW)", "Thông báo")
            Return False
        ElseIf (txtthanhtien.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập tổng tiền", "Thông báo")
            Return False
        ElseIf (txttrangthai.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập trạng thái", "Thông báo")
            Return False

        End If

        Return True
    End Function
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmahd.TextChanged, txtmahd.TextChanged
        If (txtmahd.Text.Trim = "") Then
            btnAddNew.Enabled = False
        Else
            btnAddNew.Enabled = True
        End If
    End Sub

End Class