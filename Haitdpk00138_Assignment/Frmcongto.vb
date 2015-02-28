Imports System.Data
Imports System.Data.SqlClient

Public Class Frmcongto
    Dim data As New SqlConnection("Data Source=.;Initial Catalog=haitdpk00138;Integrated Security=True")
    Private Sub loaddatabase()
        data.Open()
        Dim load As New SqlCommand("select * from Congto", data)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        data.Close()
        lstcongto.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lstcongto.Items.Add(Row("Macongto").ToString())
            lstcongto.Items(a).SubItems.Add(Row("MaKH").ToString())
            lstcongto.Items(a).SubItems.Add(Row("Socu").ToString())
            lstcongto.Items(a).SubItems.Add(Row("Somoi").ToString())
            lstcongto.Items(a).SubItems.Add(Row("Maloai").ToString())
            a += 1
        Next
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If (KiemTraThongTin() = True) Then
            Try
                data.Open()
                Dim Ma As String = txtmact.Text
                Dim makh As String = txtmakh.Text
                Dim socu As String = Txtsocu.Text
                Dim somoi As String = txtsomoi.Text
                Dim maloai As String = txtmaloai.Text
                Dim them As New SqlCommand("Insert into congto(macongto,MaKH,Socu,Somoi,Maloai) values('" + Ma + "' , '" + makh + "', '" + socu + "' ,'" + somoi + "','" + maloai + "')", data)
                them.ExecuteNonQuery()
                data.Close()
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loaddatabase()
            Catch ex As Exception
                MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ClearBox()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddatabase()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (dialogResult = Windows.Forms.DialogResult.Yes) Then
            Close()
        End If
    End Sub


    Private Sub ClearBox()
        txtmact.Text = ""
        txtmakh.Text = ""
        Txtsocu.Text = ""
        txtsomoi.Text = ""
        txtmaloai.Text = ""
    End Sub
    Private Sub lstViewBook_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcongto.SelectedIndexChanged
        If lstcongto.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstcongto.SelectedItems
                txtmact.Text = lis.SubItems(0).Text
                txtmakh.Text = lis.SubItems(1).Text
                Txtsocu.Text = lis.SubItems(2).Text
                txtsomoi.Text = lis.SubItems(3).Text
                txtmaloai.Text = lis.SubItems(4).Text
                btnDelete.Enabled = True
                btnEdit.Enabled = True
            Next
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            data.Open()
            Dim Mact As String = txtmact.Text
            Dim xoa As New SqlCommand("delete from congto where macongto ='" + Mact + "'", data)
            xoa.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = Windows.Forms.DialogResult.Yes) Then
                loaddatabase()
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
            Dim Ma As String = txtmact.Text
            Dim makh As String = txtmakh.Text
            Dim socu As String = Txtsocu.Text
            Dim somoi As String = txtsomoi.Text
            Dim maloai As String = txtmaloai.Text
            Dim sua As New SqlCommand("update Congto set maKH = '" + makh + "', Socu= '" + socu + "' , Somoi= '" + somoi + "', Maloai= '" + maloai + "'  where Macongto = '" + Ma + "'", data)
            sua.ExecuteNonQuery()
            data.Close()
            Dim dialogResult As DialogResult = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (dialogResult = Windows.Forms.DialogResult.Yes) Then
                loaddatabase()
            End If
        Catch ex As Exception
            MessageBox.Show("Sửa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Hàm kiểm tra thông tin. Nếu thông tin đầy đủ thì trả về là True, ngược lại False 
    Private Function KiemTraThongTin() As Boolean

        If (txtmact.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã công tơ", "Thông báo")
            Return False
        ElseIf (txtmakh.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập mã khách hàng", "Thông báo")
            Return False
        ElseIf (Txtsocu.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập số cũ", "Thông báo")
            Return False
        ElseIf (txtsomoi.Text.Trim = "") Then
            MessageBox.Show("Bạn vui lòng nhập số mới", "Thông báo")
            Return False
        ElseIf (txtmaloai.Text.Trim = "") Then
            MessageBox.Show("Bạn chưa nhập mã loại", "Thông báo")
            Return False

        End If

        Return True
    End Function
    Private Sub txtBookName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmact.TextChanged, txtmact.TextChanged
        If (txtmact.Text.Trim = "") Then
            btnAddNew.Enabled = False
        Else
            btnAddNew.Enabled = True
        End If
    End Sub
End Class
