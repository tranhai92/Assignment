<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcongto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcongto))
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstcongto = New System.Windows.Forms.ListView()
        Me.cotmact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotkhachhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotsocu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotsomoi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.maloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grBoxBookManagement = New System.Windows.Forms.GroupBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsomoi = New System.Windows.Forms.TextBox()
        Me.Txtsocu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.txtmact = New System.Windows.Forms.TextBox()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lstnv = New System.Windows.Forms.ListView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.grBoxBookManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(317, 369)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 37)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.Text = "Sửa"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(430, 369)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 37)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(544, 369)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 37)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstcongto
        '
        Me.lstcongto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cotmact, Me.cotkhachhang, Me.cotsocu, Me.cotsomoi, Me.maloai})
        Me.lstcongto.FullRowSelect = True
        Me.lstcongto.GridLines = True
        Me.lstcongto.Location = New System.Drawing.Point(11, 172)
        Me.lstcongto.Margin = New System.Windows.Forms.Padding(2)
        Me.lstcongto.Name = "lstcongto"
        Me.lstcongto.Size = New System.Drawing.Size(646, 181)
        Me.lstcongto.TabIndex = 25
        Me.lstcongto.UseCompatibleStateImageBehavior = False
        Me.lstcongto.View = System.Windows.Forms.View.Details
        '
        'cotmact
        '
        Me.cotmact.Text = "Mã công tơ"
        Me.cotmact.Width = 72
        '
        'cotkhachhang
        '
        Me.cotkhachhang.Text = "Mã khách hàng"
        Me.cotkhachhang.Width = 136
        '
        'cotsocu
        '
        Me.cotsocu.Text = "Số cũ"
        Me.cotsocu.Width = 146
        '
        'cotsomoi
        '
        Me.cotsomoi.Text = "Số mới"
        Me.cotsomoi.Width = 157
        '
        'maloai
        '
        Me.maloai.Text = "Mã loại"
        Me.maloai.Width = 128
        '
        'grBoxBookManagement
        '
        Me.grBoxBookManagement.BackColor = System.Drawing.Color.Transparent
        Me.grBoxBookManagement.Controls.Add(Me.txtmaloai)
        Me.grBoxBookManagement.Controls.Add(Me.Label4)
        Me.grBoxBookManagement.Controls.Add(Me.txtsomoi)
        Me.grBoxBookManagement.Controls.Add(Me.Txtsocu)
        Me.grBoxBookManagement.Controls.Add(Me.Label2)
        Me.grBoxBookManagement.Controls.Add(Me.btnAddNew)
        Me.grBoxBookManagement.Controls.Add(Me.lblPublisher)
        Me.grBoxBookManagement.Controls.Add(Me.txtmakh)
        Me.grBoxBookManagement.Controls.Add(Me.lblAuthorName)
        Me.grBoxBookManagement.Controls.Add(Me.txtmact)
        Me.grBoxBookManagement.Controls.Add(Me.lblBookName)
        Me.grBoxBookManagement.Location = New System.Drawing.Point(11, 11)
        Me.grBoxBookManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Name = "grBoxBookManagement"
        Me.grBoxBookManagement.Padding = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Size = New System.Drawing.Size(646, 152)
        Me.grBoxBookManagement.TabIndex = 24
        Me.grBoxBookManagement.TabStop = False
        Me.grBoxBookManagement.Text = "Quản lý công tơ"
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(419, 43)
        Me.txtmaloai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(200, 20)
        Me.txtmaloai.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Mã loại"
        '
        'txtsomoi
        '
        Me.txtsomoi.Location = New System.Drawing.Point(419, 17)
        Me.txtsomoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsomoi.Name = "txtsomoi"
        Me.txtsomoi.Size = New System.Drawing.Size(200, 20)
        Me.txtsomoi.TabIndex = 17
        '
        'Txtsocu
        '
        Me.Txtsocu.Location = New System.Drawing.Point(95, 69)
        Me.Txtsocu.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtsocu.Name = "Txtsocu"
        Me.Txtsocu.Size = New System.Drawing.Size(221, 20)
        Me.Txtsocu.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Số mới"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNew.Location = New System.Drawing.Point(428, 116)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(98, 32)
        Me.btnAddNew.TabIndex = 12
        Me.btnAddNew.Text = "Thêm mới"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(8, 76)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(35, 13)
        Me.lblPublisher.TabIndex = 4
        Me.lblPublisher.Text = "Số cũ"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(95, 44)
        Me.txtmakh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(221, 20)
        Me.txtmakh.TabIndex = 3
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Location = New System.Drawing.Point(9, 50)
        Me.lblAuthorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(82, 13)
        Me.lblAuthorName.TabIndex = 2
        Me.lblAuthorName.Text = "Mã khách hàng"
        '
        'txtmact
        '
        Me.txtmact.Location = New System.Drawing.Point(95, 21)
        Me.txtmact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmact.Name = "txtmact"
        Me.txtmact.Size = New System.Drawing.Size(221, 20)
        Me.txtmact.TabIndex = 1
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(8, 24)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(61, 13)
        Me.lblBookName.TabIndex = 0
        Me.lblBookName.Text = "Mã công tơ"
        '
        'lstnv
        '
        Me.lstnv.FullRowSelect = True
        Me.lstnv.GridLines = True
        Me.lstnv.Location = New System.Drawing.Point(11, 172)
        Me.lstnv.Margin = New System.Windows.Forms.Padding(2)
        Me.lstnv.Name = "lstnv"
        Me.lstnv.Size = New System.Drawing.Size(726, 181)
        Me.lstnv.TabIndex = 25
        Me.lstnv.UseCompatibleStateImageBehavior = False
        Me.lstnv.View = System.Windows.Forms.View.Details
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(428, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Frmcongto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 409)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstcongto)
        Me.Controls.Add(Me.grBoxBookManagement)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmcongto"
        Me.Text = "Quản lý công tơ"
        Me.grBoxBookManagement.ResumeLayout(False)
        Me.grBoxBookManagement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents lstcongto As System.Windows.Forms.ListView
    Friend WithEvents cotmact As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotkhachhang As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotsocu As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotsomoi As System.Windows.Forms.ColumnHeader
    Friend WithEvents grBoxBookManagement As System.Windows.Forms.GroupBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsomoi As System.Windows.Forms.TextBox
    Friend WithEvents Txtsocu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthorName As System.Windows.Forms.Label
    Friend WithEvents txtmact As System.Windows.Forms.TextBox
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Friend WithEvents maloai As System.Windows.Forms.ColumnHeader
    Public WithEvents lstnv As System.Windows.Forms.ListView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
