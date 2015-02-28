<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmquanly
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnchitiethd = New System.Windows.Forms.Button()
        Me.btncongto = New System.Windows.Forms.Button()
        Me.btnhoadon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Constantia", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(50, 172)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(354, 78)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "HỆ THỐNG QUẢN LÝ ĐIỆN "
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnchitiethd
        '
        Me.btnchitiethd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchitiethd.ForeColor = System.Drawing.Color.Blue
        Me.btnchitiethd.Location = New System.Drawing.Point(313, 24)
        Me.btnchitiethd.Name = "btnchitiethd"
        Me.btnchitiethd.Size = New System.Drawing.Size(116, 82)
        Me.btnchitiethd.TabIndex = 11
        Me.btnchitiethd.Text = "Chi tiết hóa đơn"
        Me.btnchitiethd.UseVisualStyleBackColor = True
        '
        'btncongto
        '
        Me.btncongto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncongto.ForeColor = System.Drawing.Color.Blue
        Me.btncongto.Location = New System.Drawing.Point(32, 24)
        Me.btncongto.Name = "btncongto"
        Me.btncongto.Size = New System.Drawing.Size(116, 82)
        Me.btncongto.TabIndex = 12
        Me.btncongto.Text = "Quản lý công tơ"
        Me.btncongto.UseVisualStyleBackColor = True
        '
        'btnhoadon
        '
        Me.btnhoadon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhoadon.ForeColor = System.Drawing.Color.Blue
        Me.btnhoadon.Location = New System.Drawing.Point(174, 24)
        Me.btnhoadon.Name = "btnhoadon"
        Me.btnhoadon.Size = New System.Drawing.Size(116, 82)
        Me.btnhoadon.TabIndex = 13
        Me.btnhoadon.Text = "Quản lý hóa đơn"
        Me.btnhoadon.UseVisualStyleBackColor = True
        '
        'Frmquanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 327)
        Me.Controls.Add(Me.btnhoadon)
        Me.Controls.Add(Me.btncongto)
        Me.Controls.Add(Me.btnchitiethd)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Frmquanly"
        Me.Text = "Frmquanly"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnchitiethd As System.Windows.Forms.Button
    Friend WithEvents btncongto As System.Windows.Forms.Button
    Friend WithEvents btnhoadon As System.Windows.Forms.Button
End Class
