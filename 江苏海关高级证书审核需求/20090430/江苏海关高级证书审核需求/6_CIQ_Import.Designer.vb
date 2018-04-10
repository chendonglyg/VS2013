<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIQ_Import
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jieshu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kaishi = New System.Windows.Forms.TextBox()
        Me.lingyongkuwei = New System.Windows.Forms.TextBox()
        Me.cunfangkuwei = New System.Windows.Forms.TextBox()
        Me.hetonghao = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.baoguandanhao = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(81, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "选择模板"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("幼圆", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(259, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(669, 30)
        Me.TextBox1.TabIndex = 7
        '
        'pb
        '
        Me.pb.ForeColor = System.Drawing.Color.Red
        Me.pb.Location = New System.Drawing.Point(259, 125)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(669, 18)
        Me.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb.TabIndex = 38
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lingyongkuwei)
        Me.GroupBox1.Controls.Add(Me.cunfangkuwei)
        Me.GroupBox1.Controls.Add(Me.hetonghao)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.baoguandanhao)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.jieshu)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.kaishi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.pb)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(28, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 165)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "处理区域"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(30, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "第二步:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(30, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "第一步:"
        '
        'OK
        '
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OK.Location = New System.Drawing.Point(167, 256)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(653, 66)
        Me.OK.TabIndex = 10
        Me.OK.Text = "Start"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(393, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 41)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "贸易数据导入"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(93, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "到第几行结束？"
        '
        'jieshu
        '
        Me.jieshu.Location = New System.Drawing.Point(183, 137)
        Me.jieshu.Name = "jieshu"
        Me.jieshu.Size = New System.Drawing.Size(48, 21)
        Me.jieshu.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(92, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 12)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "从第几行开始？"
        '
        'kaishi
        '
        Me.kaishi.Location = New System.Drawing.Point(183, 110)
        Me.kaishi.Name = "kaishi"
        Me.kaishi.Size = New System.Drawing.Size(49, 21)
        Me.kaishi.TabIndex = 51
        '
        'lingyongkuwei
        '
        Me.lingyongkuwei.BackColor = System.Drawing.SystemColors.Control
        Me.lingyongkuwei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lingyongkuwei.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lingyongkuwei.ForeColor = System.Drawing.Color.Red
        Me.lingyongkuwei.Location = New System.Drawing.Point(555, 29)
        Me.lingyongkuwei.Name = "lingyongkuwei"
        Me.lingyongkuwei.ReadOnly = True
        Me.lingyongkuwei.Size = New System.Drawing.Size(129, 23)
        Me.lingyongkuwei.TabIndex = 239
        '
        'cunfangkuwei
        '
        Me.cunfangkuwei.BackColor = System.Drawing.SystemColors.Control
        Me.cunfangkuwei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cunfangkuwei.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cunfangkuwei.ForeColor = System.Drawing.Color.Red
        Me.cunfangkuwei.Location = New System.Drawing.Point(799, 29)
        Me.cunfangkuwei.Name = "cunfangkuwei"
        Me.cunfangkuwei.ReadOnly = True
        Me.cunfangkuwei.Size = New System.Drawing.Size(129, 23)
        Me.cunfangkuwei.TabIndex = 238
        '
        'hetonghao
        '
        Me.hetonghao.BackColor = System.Drawing.SystemColors.Control
        Me.hetonghao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetonghao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetonghao.ForeColor = System.Drawing.Color.Red
        Me.hetonghao.Location = New System.Drawing.Point(81, 29)
        Me.hetonghao.Name = "hetonghao"
        Me.hetonghao.ReadOnly = True
        Me.hetonghao.Size = New System.Drawing.Size(129, 23)
        Me.hetonghao.TabIndex = 237
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(475, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 17)
        Me.Label14.TabIndex = 236
        Me.Label14.Text = "原料领用库位"
        '
        'baoguandanhao
        '
        Me.baoguandanhao.BackColor = System.Drawing.SystemColors.Control
        Me.baoguandanhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.baoguandanhao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.baoguandanhao.ForeColor = System.Drawing.Color.Red
        Me.baoguandanhao.Location = New System.Drawing.Point(313, 29)
        Me.baoguandanhao.Name = "baoguandanhao"
        Me.baoguandanhao.ReadOnly = True
        Me.baoguandanhao.Size = New System.Drawing.Size(129, 23)
        Me.baoguandanhao.TabIndex = 234
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(236, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 17)
        Me.Label17.TabIndex = 235
        Me.Label17.Text = "原料报关单号"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(15, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 17)
        Me.Label24.TabIndex = 233
        Me.Label24.Text = "原料合同号"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(721, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "产品存放库位"
        '
        'CIQ_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CIQ_Import"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "6.数据导入"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents jieshu As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents kaishi As System.Windows.Forms.TextBox
    Friend WithEvents lingyongkuwei As System.Windows.Forms.TextBox
    Friend WithEvents cunfangkuwei As System.Windows.Forms.TextBox
    Friend WithEvents hetonghao As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents baoguandanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
