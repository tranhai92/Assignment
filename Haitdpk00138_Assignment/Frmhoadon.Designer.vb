<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmhoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmhoadon))
        Me.txttrangthai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtthanhtien = New System.Windows.Forms.TextBox()
        Me.Txttieuthu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.txtmact = New System.Windows.Forms.TextBox()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lsthd = New System.Windows.Forms.ListView()
        Me.cotmahd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dientieuthu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.thanhtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.trangthai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grBoxBookManagement = New System.Windows.Forms.GroupBox()
        Me.lsthoadon = New System.Windows.Forms.ListView()
        Me.grBoxBookManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttrangthai
        '
        Me.txttrangthai.Location = New System.Drawing.Point(442, 50)
        Me.txttrangthai.Margin = New System.Windows.Forms.Padding(2)
        Me.txttrangthai.Name = "txttrangthai"
        Me.txttrangthai.Size = New System.Drawing.Size(200, 20)
        Me.txttrangthai.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Trạng thái"
        '
        'txtthanhtien
        '
        Me.txtthanhtien.Location = New System.Drawing.Point(442, 23)
        Me.txtthanhtien.Margin = New System.Windows.Forms.Padding(2)
        Me.txtthanhtien.Name = "txtthanhtien"
        Me.txtthanhtien.Size = New System.Drawing.Size(200, 20)
        Me.txtthanhtien.TabIndex = 32
        '
        'Txttieuthu
        '
        Me.Txttieuthu.Location = New System.Drawing.Point(106, 77)
        Me.Txttieuthu.Margin = New System.Windows.Forms.Padding(2)
        Me.Txttieuthu.Name = "Txttieuthu"
        Me.Txttieuthu.Size = New System.Drawing.Size(221, 20)
        Me.Txttieuthu.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Thành tiền"
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
        Me.lblPublisher.Size = New System.Drawing.Size(90, 13)
        Me.lblPublisher.TabIndex = 28
        Me.lblPublisher.Text = "Điện tiêu thụ (kw)"
        '
        'txtmact
        '
        Me.txtmact.Location = New System.Drawing.Point(106, 50)
        Me.txtmact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmact.Name = "txtmact"
        Me.txtmact.Size = New System.Drawing.Size(221, 20)
        Me.txtmact.TabIndex = 27
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Location = New System.Drawing.Point(13, 57)
        Me.lblAuthorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(61, 13)
        Me.lblAuthorName.TabIndex = 26
        Me.lblAuthorName.Text = "Mã công tơ"
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(106, 23)
        Me.txtmahd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(221, 20)
        Me.txtmahd.TabIndex = 25
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(13, 30)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(65, 13)
        Me.lblBookName.TabIndex = 24
        Me.lblBookName.Text = "Mã hóa đơn"
        '
        'lsthd
        '
        Me.lsthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cotmahd, Me.mact, Me.dientieuthu, Me.thanhtien, Me.trangthai})
        Me.lsthd.FullRowSelect = True
        Me.lsthd.GridLines = True
        Me.lsthd.Location = New System.Drawing.Point(1, 163)
        Me.lsthd.Margin = New System.Windows.Forms.Padding(2)
        Me.lsthd.Name = "lsthd"
        Me.lsthd.Size = New System.Drawing.Size(679, 181)
        Me.lsthd.TabIndex = 35
        Me.lsthd.UseCompatibleStateImageBehavior = False
        Me.lsthd.View = System.Windows.Forms.View.Details
        '
        'cotmahd
        '
        Me.cotmahd.Text = "Mã hóa đơn"
        Me.cotmahd.Width = 96
        '
        'mact
        '
        Me.mact.Text = "Mã công tơ"
        Me.mact.Width = 114
        '
        'dientieuthu
        '
        Me.dientieuthu.Text = "Điện tiêu thụ"
        Me.dientieuthu.Width = 236
        '
        'thanhtien
        '
        Me.thanhtien.Text = "Thành tiền"
        Me.thanhtien.Width = 152
        '
        'trangthai
        '
        Me.trangthai.Text = "Trạng thái"
        Me.trangthai.Width = 176
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
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(569, 348)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 37)
        Me.btnClose.TabIndex = 36
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grBoxBookManagement
        '
        Me.grBoxBookManagement.BackColor = System.Drawing.Color.Transparent
        Me.grBoxBookManagement.Controls.Add(Me.btnEdit)
        Me.grBoxBookManagement.Controls.Add(Me.btnDelete)
        Me.grBoxBookManagement.Controls.Add(Me.Label2)
        Me.grBoxBookManagement.Controls.Add(Me.Label4)
        Me.grBoxBookManagement.Controls.Add(Me.txttrangthai)
        Me.grBoxBookManagement.Controls.Add(Me.txtthanhtien)
        Me.grBoxBookManagement.Controls.Add(Me.btnAddNew)
        Me.grBoxBookManagement.Controls.Add(Me.lblPublisher)
        Me.grBoxBookManagement.Controls.Add(Me.Txttieuthu)
        Me.grBoxBookManagement.Controls.Add(Me.txtmact)
        Me.grBoxBookManagement.Controls.Add(Me.lblBookName)
        Me.grBoxBookManagement.Controls.Add(Me.txtmahd)
        Me.grBoxBookManagement.Controls.Add(Me.lblAuthorName)
        Me.grBoxBookManagement.Location = New System.Drawing.Point(1, 7)
        Me.grBoxBookManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Name = "grBoxBookManagement"
        Me.grBoxBookManagement.Padding = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Size = New System.Drawing.Size(646, 152)
        Me.grBoxBookManagement.TabIndex = 39
        Me.grBoxBookManagement.TabStop = False
        Me.grBoxBookManagement.Text = "Quản lý hóa đơn"
        '
        'lsthoadon
        '
        Me.lsthoadon.FullRowSelect = True
        Me.lsthoadon.GridLines = True
        Me.lsthoadon.Location = New System.Drawing.Point(1, 163)
        Me.lsthoadon.Margin = New System.Windows.Forms.Padding(2)
        Me.lsthoadon.Name = "lsthoadon"
        Me.lsthoadon.Size = New System.Drawing.Size(679, 181)
        Me.lsthoadon.TabIndex = 35
        Me.lsthoadon.UseCompatibleStateImageBehavior = False
        Me.lsthoadon.View = System.Windows.Forms.View.Details
        '
        'Frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 391)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lsthd)
        Me.Controls.Add(Me.grBoxBookManagement)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmhoadon"
        Me.Text = "Quản lý hóa đơn"
        Me.grBoxBookManagement.ResumeLayout(False)
        Me.grBoxBookManagement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txttrangthai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtthanhtien As System.Windows.Forms.TextBox
    Friend WithEvents Txttieuthu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents txtmact As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthorName As System.Windows.Forms.Label
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Public WithEvents lsthd As System.Windows.Forms.ListView
    Friend WithEvents cotmahd As System.Windows.Forms.ColumnHeader
    Friend WithEvents mact As System.Windows.Forms.ColumnHeader
    Friend WithEvents dientieuthu As System.Windows.Forms.ColumnHeader
    Friend WithEvents thanhtien As System.Windows.Forms.ColumnHeader
    Friend WithEvents trangthai As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grBoxBookManagement As System.Windows.Forms.GroupBox
    Public WithEvents lsthoadon As System.Windows.Forms.ListView
End Class
