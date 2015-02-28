Public Class Frmdangnhap

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtcode.Text &= "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtcode.Text &= "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtcode.Text &= "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtcode.Text &= "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtcode.Text &= "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txtcode.Text &= "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txtcode.Text &= "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txtcode.Text &= "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        txtcode.Text &= "9"
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        txtcode.Text &= "0"
    End Sub
    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        txtcode.Text = ""
    End Sub


    Private Sub Frmdangnhap_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Frmquanly.Show()
        Me.Hide()
    End Sub


    Private Sub Frmdangnhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtid.Text = "admin"
        txtcode.Text = ""
    End Sub

    Private Sub btnnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnhap.Click
        If txtcode.Text = "123456789" And txtid.Text = "admin" Then
            Frmquanly.Show()
            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
        Else
            MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If
    End Sub
End Class