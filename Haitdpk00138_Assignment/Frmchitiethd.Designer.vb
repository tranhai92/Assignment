<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmchitiethd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstchitiet = New System.Windows.Forms.ListView()
        Me.machitiet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mahd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.makh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dientieuthu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dongia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grBoxBookManagement = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmact = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttieuthu = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.Txttmakh = New System.Windows.Forms.TextBox()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.txtmachitiet = New System.Windows.Forms.TextBox()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.grBoxBookManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(613, 378)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 37)
        Me.btnClose.TabIndex = 41
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstchitiet
        '
        Me.lstchitiet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.machitiet, Me.mahd, Me.makh, Me.mact, Me.dientieuthu, Me.dongia})
        Me.lstchitiet.FullRowSelect = True
        Me.lstchitiet.GridLines = True
        Me.lstchitiet.Location = New System.Drawing.Point(11, 180)
        Me.lstchitiet.Margin = New System.Windows.Forms.Padding(2)
        Me.lstchitiet.Name = "lstchitiet"
        Me.lstchitiet.Size = New System.Drawing.Size(701, 181)
        Me.lstchitiet.TabIndex = 40
        Me.lstchitiet.UseCompatibleStateImageBehavior = False
        Me.lstchitiet.View = System.Windows.Forms.View.Details
        '
        'machitiet
        '
        Me.machitiet.Text = "Mã chi tiết hóa đơn"
        Me.machitiet.Width = 108
        '
        'mahd
        '
        Me.mahd.Text = "Mã hóa đơn"
        Me.mahd.Width = 90
        '
        'makh
        '
        Me.makh.Text = "Mã khách hàng"
        Me.makh.Width = 109
        '
        'mact
        '
        Me.mact.Text = "Mã công tơ"
        Me.mact.Width = 96
        '
        'dientieuthu
        '
        Me.dientieuthu.Text = "Điện tiêu thụ"
        Me.dientieuthu.Width = 204
        '
        'dongia
        '
        Me.dongia.Text = "Đơn giá"
        Me.dongia.Width = 92
        '
        'grBoxBookManagement
        '
        Me.grBoxBookManagement.BackColor = System.Drawing.Color.Transparent
        Me.grBoxBookManagement.Controls.Add(Me.Label1)
        Me.grBoxBookManagement.Controls.Add(Me.txtmact)
        Me.grBoxBookManagement.Controls.Add(Me.btnEdit)
        Me.grBoxBookManagement.Controls.Add(Me.btnDelete)
        Me.grBoxBookManagement.Controls.Add(Me.Label2)
        Me.grBoxBookManagement.Controls.Add(Me.Label4)
        Me.grBoxBookManagement.Controls.Add(Me.txttieuthu)
        Me.grBoxBookManagement.Controls.Add(Me.txtdongia)
        Me.grBoxBookManagement.Controls.Add(Me.btnAddNew)
        Me.grBoxBookManagement.Controls.Add(Me.lblPublisher)
        Me.grBoxBookManagement.Controls.Add(Me.Txttmakh)
        Me.grBoxBookManagement.Controls.Add(Me.txtmahd)
        Me.grBoxBookManagement.Controls.Add(Me.lblBookName)
        Me.grBoxBookManagement.Controls.Add(Me.txtmachitiet)
        Me.grBoxBookManagement.Controls.Add(Me.lblAuthorName)
        Me.grBoxBookManagement.Location = New System.Drawing.Point(11, 24)
        Me.grBoxBookManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Name = "grBoxBookManagement"
        Me.grBoxBookManagement.Padding = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Size = New System.Drawing.Size(701, 152)
        Me.grBoxBookManagement.TabIndex = 42
        Me.grBoxBookManagement.TabStop = False
        Me.grBoxBookManagement.Text = "Chi tiết hóa đơn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Mã công tơ"
        '
        'txtmact
        '
        Me.txtmact.Location = New System.Drawing.Point(454, 23)
        Me.txtmact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmact.Name = "txtmact"
        Me.txtmact.Size = New System.Drawing.Size(200, 20)
        Me.txtmact.TabIndex = 40
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(251, 111)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 37)
        Me.btnEdit.TabIndex = 38
        Me.btnEdit.Text = "Sửa"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(365, 111)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 37)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Đơn giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Điện tiêu thụ "
        '
        'txttieuthu
        '
        Me.txttieuthu.Location = New System.Drawing.Point(454, 50)
        Me.txttieuthu.Margin = New System.Windows.Forms.Padding(2)
        Me.txttieuthu.Name = "txttieuthu"
        Me.txttieuthu.Size = New System.Drawing.Size(200, 20)
        Me.txttieuthu.TabIndex = 34
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(454, 77)
        Me.txtdongia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(200, 20)
        Me.txtdongia.TabIndex = 32
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNew.Location = New System.Drawing.Point(137, 111)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(98, 37)
        Me.btnAddNew.TabIndex = 29
        Me.btnAddNew.Text = "Thêm mới"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(13, 84)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(82, 13)
        Me.lblPublisher.TabIndex = 28
        Me.lblPublisher.Text = "Mã khách hàng"
        '
        'Txttmakh
        '
        Me.Txttmakh.Location = New System.Drawing.Point(116, 77)
        Me.Txttmakh.Margin = New System.Windows.Forms.Padding(2)
        Me.Txttmakh.Name = "Txttmakh"
        Me.Txttmakh.Size = New System.Drawing.Size(221, 20)
        Me.Txttmakh.TabIndex = 31
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(116, 50)
        Me.txtmahd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(221, 20)
        Me.txtmahd.TabIndex = 27
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(13, 30)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(59, 13)
        Me.lblBookName.TabIndex = 24
        Me.lblBookName.Text = "Mã chi tiết "
        '
        'txtmachitiet
        '
        Me.txtmachitiet.Location = New System.Drawing.Point(116, 23)
        Me.txtmachitiet.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmachitiet.Name = "txtmachitiet"
        Me.txtmachitiet.Size = New System.Drawing.Size(221, 20)
        Me.txtmachitiet.TabIndex = 25
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Location = New System.Drawing.Point(13, 57)
        Me.lblAuthorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(65, 13)
        Me.lblAuthorName.TabIndex = 26
        Me.lblAuthorName.Text = "Mã hóa đơn"
        '
        'Frmchitiethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 426)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstchitiet)
        Me.Controls.Add(Me.grBoxBookManagement)
        Me.Name = "Frmchitiethd"
        Me.Text = "Chi tiết hóa đơn"
        Me.grBoxBookManagement.ResumeLayout(False)
        Me.grBoxBookManagement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents lstchitiet As System.Windows.Forms.ListView
    Friend WithEvents machitiet As System.Windows.Forms.ColumnHeader
    Friend WithEvents mahd As System.Windows.Forms.ColumnHeader
    Friend WithEvents makh As System.Windows.Forms.ColumnHeader
    Friend WithEvents mact As System.Windows.Forms.ColumnHeader
    Friend WithEvents dientieuthu As System.Windows.Forms.ColumnHeader
    Friend WithEvents grBoxBookManagement As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttieuthu As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents Txttmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Friend WithEvents txtmachitiet As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthorName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmact As System.Windows.Forms.TextBox
    Friend WithEvents dongia As System.Windows.Forms.ColumnHeader
End Class
