<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.station = New System.Windows.Forms.ComboBox()
        Me.S = New System.Windows.Forms.Label()
        Me.TextBox113 = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.TextBox114 = New System.Windows.Forms.TextBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.TextBox115 = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c21 = New System.Windows.Forms.GroupBox()
        Me.C7 = New System.Windows.Forms.CheckBox()
        Me.c11 = New System.Windows.Forms.CheckBox()
        Me.c10 = New System.Windows.Forms.CheckBox()
        Me.c9 = New System.Windows.Forms.CheckBox()
        Me.c3 = New System.Windows.Forms.CheckBox()
        Me.c8 = New System.Windows.Forms.CheckBox()
        Me.c1 = New System.Windows.Forms.CheckBox()
        Me.c2 = New System.Windows.Forms.CheckBox()
        Me.c4 = New System.Windows.Forms.CheckBox()
        Me.c5 = New System.Windows.Forms.CheckBox()
        Me.c6 = New System.Windows.Forms.CheckBox()
        Me.changepassword = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.c21.SuspendLayout()
        Me.changepassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(39, 213)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(341, 362)
        Me.dgv.TabIndex = 82
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(270, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 35)
        Me.Button4.TabIndex = 91
        Me.Button4.Text = "删除用户"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(270, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 35)
        Me.Button3.TabIndex = 90
        Me.Button3.Text = "增加用户"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.station)
        Me.GroupBox13.Controls.Add(Me.S)
        Me.GroupBox13.Controls.Add(Me.TextBox113)
        Me.GroupBox13.Controls.Add(Me.Label114)
        Me.GroupBox13.Controls.Add(Me.TextBox114)
        Me.GroupBox13.Controls.Add(Me.Label115)
        Me.GroupBox13.Controls.Add(Me.TextBox115)
        Me.GroupBox13.Controls.Add(Me.Label116)
        Me.GroupBox13.Location = New System.Drawing.Point(39, 25)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(225, 163)
        Me.GroupBox13.TabIndex = 89
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Information"
        '
        'station
        '
        Me.station.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.station.FormattingEnabled = True
        Me.station.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "筒仓", "粕库", "榨油厂", "精炼厂", "分提车间", "酸化油车间", "35T锅炉房", "75T锅炉房", "污水处理", "小包装罐区", "粮油罐区", "小包装成品库", "小包装辅料库", "IT", "财务", "管理"})
        Me.station.Location = New System.Drawing.Point(87, 128)
        Me.station.Name = "station"
        Me.station.Size = New System.Drawing.Size(85, 21)
        Me.station.TabIndex = 77
        '
        'S
        '
        Me.S.AutoSize = True
        Me.S.Location = New System.Drawing.Point(32, 132)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(49, 13)
        Me.S.TabIndex = 177
        Me.S.Text = "Station ?"
        '
        'TextBox113
        '
        Me.TextBox113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox113.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox113.Location = New System.Drawing.Point(78, 93)
        Me.TextBox113.Name = "TextBox113"
        Me.TextBox113.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox113.Size = New System.Drawing.Size(94, 21)
        Me.TextBox113.TabIndex = 176
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(24, 96)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(53, 13)
        Me.Label114.TabIndex = 175
        Me.Label114.Text = "Password"
        '
        'TextBox114
        '
        Me.TextBox114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox114.Enabled = False
        Me.TextBox114.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox114.Location = New System.Drawing.Point(78, 59)
        Me.TextBox114.Name = "TextBox114"
        Me.TextBox114.Size = New System.Drawing.Size(94, 21)
        Me.TextBox114.TabIndex = 174
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(12, 62)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(65, 13)
        Me.Label115.TabIndex = 173
        Me.Label115.Text = "Username"
        '
        'TextBox115
        '
        Me.TextBox115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox115.Enabled = False
        Me.TextBox115.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox115.Location = New System.Drawing.Point(78, 25)
        Me.TextBox115.Name = "TextBox115"
        Me.TextBox115.Size = New System.Drawing.Size(94, 21)
        Me.TextBox115.TabIndex = 172
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(56, 28)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(21, 13)
        Me.Label116.TabIndex = 171
        Me.Label116.Text = "ID"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(270, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 35)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "设置权限和密码"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(270, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(176, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "用户管理"
        '
        'c21
        '
        Me.c21.Controls.Add(Me.C7)
        Me.c21.Controls.Add(Me.c11)
        Me.c21.Controls.Add(Me.c10)
        Me.c21.Controls.Add(Me.c9)
        Me.c21.Controls.Add(Me.c3)
        Me.c21.Controls.Add(Me.c8)
        Me.c21.Controls.Add(Me.c1)
        Me.c21.Controls.Add(Me.c2)
        Me.c21.Controls.Add(Me.c4)
        Me.c21.Controls.Add(Me.c5)
        Me.c21.Controls.Add(Me.c6)
        Me.c21.Controls.Add(Me.dgv)
        Me.c21.Controls.Add(Me.Button1)
        Me.c21.Controls.Add(Me.Button4)
        Me.c21.Controls.Add(Me.Button2)
        Me.c21.Controls.Add(Me.Button3)
        Me.c21.Controls.Add(Me.GroupBox13)
        Me.c21.Location = New System.Drawing.Point(12, 60)
        Me.c21.Name = "c21"
        Me.c21.Size = New System.Drawing.Size(607, 581)
        Me.c21.TabIndex = 93
        Me.c21.TabStop = False
        Me.c21.Text = "用户管理界面"
        '
        'C7
        '
        Me.C7.AutoSize = True
        Me.C7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.C7.Location = New System.Drawing.Point(426, 294)
        Me.C7.Name = "C7"
        Me.C7.Size = New System.Drawing.Size(98, 17)
        Me.C7.TabIndex = 117
        Me.C7.Text = "标准密度维护"
        Me.C7.UseVisualStyleBackColor = False
        '
        'c11
        '
        Me.c11.AutoSize = True
        Me.c11.Image = Global.Inventory.My.Resources.Resources.大豆筒仓容重维护
        Me.c11.Location = New System.Drawing.Point(426, 449)
        Me.c11.Name = "c11"
        Me.c11.Size = New System.Drawing.Size(147, 18)
        Me.c11.TabIndex = 116
        Me.c11.UseVisualStyleBackColor = True
        '
        'c10
        '
        Me.c10.AutoSize = True
        Me.c10.Image = Global.Inventory.My.Resources.Resources.辅料代码维护
        Me.c10.Location = New System.Drawing.Point(426, 412)
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(125, 16)
        Me.c10.TabIndex = 115
        Me.c10.UseVisualStyleBackColor = True
        '
        'c9
        '
        Me.c9.AutoSize = True
        Me.c9.Image = Global.Inventory.My.Resources.Resources.罐区错误数据校正
        Me.c9.Location = New System.Drawing.Point(426, 373)
        Me.c9.Name = "c9"
        Me.c9.Size = New System.Drawing.Size(148, 18)
        Me.c9.TabIndex = 114
        Me.c9.UseVisualStyleBackColor = True
        '
        'c3
        '
        Me.c3.AutoSize = True
        Me.c3.Image = Global.Inventory.My.Resources.Resources.罐区任务导入
        Me.c3.Location = New System.Drawing.Point(426, 130)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(127, 21)
        Me.c3.TabIndex = 113
        Me.c3.UseVisualStyleBackColor = True
        '
        'c8
        '
        Me.c8.AutoSize = True
        Me.c8.Image = Global.Inventory.My.Resources.Resources.开发区仓库品种导入
        Me.c8.Location = New System.Drawing.Point(426, 334)
        Me.c8.Name = "c8"
        Me.c8.Size = New System.Drawing.Size(159, 18)
        Me.c8.TabIndex = 112
        Me.c8.UseVisualStyleBackColor = True
        '
        'c1
        '
        Me.c1.AutoSize = True
        Me.c1.Image = Global.Inventory.My.Resources.Resources.库场参数维护
        Me.c1.Location = New System.Drawing.Point(426, 44)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(145, 20)
        Me.c1.TabIndex = 111
        Me.c1.UseVisualStyleBackColor = True
        '
        'c2
        '
        Me.c2.AutoSize = True
        Me.c2.Image = Global.Inventory.My.Resources.Resources.库场跺位导入
        Me.c2.Location = New System.Drawing.Point(426, 85)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(127, 24)
        Me.c2.TabIndex = 110
        Me.c2.UseVisualStyleBackColor = True
        '
        'c4
        '
        Me.c4.AutoSize = True
        Me.c4.Image = Global.Inventory.My.Resources.Resources.物料编码导入
        Me.c4.Location = New System.Drawing.Point(426, 213)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(134, 20)
        Me.c4.TabIndex = 109
        Me.c4.UseVisualStyleBackColor = True
        '
        'c5
        '
        Me.c5.AutoSize = True
        Me.c5.Image = Global.Inventory.My.Resources.Resources.用户管理设置
        Me.c5.Location = New System.Drawing.Point(426, 255)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(125, 20)
        Me.c5.TabIndex = 108
        Me.c5.UseVisualStyleBackColor = True
        '
        'c6
        '
        Me.c6.AutoSize = True
        Me.c6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.c6.Location = New System.Drawing.Point(426, 173)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(98, 17)
        Me.c6.TabIndex = 106
        Me.c6.Text = "罐区任务维护"
        Me.c6.UseVisualStyleBackColor = False
        '
        'changepassword
        '
        Me.changepassword.Controls.Add(Me.Button5)
        Me.changepassword.Controls.Add(Me.TextBox3)
        Me.changepassword.Controls.Add(Me.Label2)
        Me.changepassword.Controls.Add(Me.TextBox1)
        Me.changepassword.Controls.Add(Me.Label3)
        Me.changepassword.Location = New System.Drawing.Point(625, 12)
        Me.changepassword.Name = "changepassword"
        Me.changepassword.Size = New System.Drawing.Size(339, 244)
        Me.changepassword.TabIndex = 94
        Me.changepassword.TabStop = False
        Me.changepassword.Text = "Username Display"
        Me.changepassword.Visible = False
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(14, 180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(316, 59)
        Me.Button5.TabIndex = 179
        Me.Button5.Text = "修改"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(98, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(232, 46)
        Me.TextBox3.TabIndex = 178
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "New Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(98, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 46)
        Me.TextBox1.TabIndex = 176
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Old Password"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 652)
        Me.Controls.Add(Me.changepassword)
        Me.Controls.Add(Me.c21)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "益海（广州）盘点系统"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.c21.ResumeLayout(False)
        Me.c21.PerformLayout()
        Me.changepassword.ResumeLayout(False)
        Me.changepassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents station As System.Windows.Forms.ComboBox
    Friend WithEvents S As System.Windows.Forms.Label
    Friend WithEvents TextBox113 As System.Windows.Forms.TextBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents TextBox114 As System.Windows.Forms.TextBox
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents TextBox115 As System.Windows.Forms.TextBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c21 As System.Windows.Forms.GroupBox
    Friend WithEvents changepassword As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c11 As System.Windows.Forms.CheckBox
    Friend WithEvents c10 As System.Windows.Forms.CheckBox
    Friend WithEvents c9 As System.Windows.Forms.CheckBox
    Friend WithEvents c3 As System.Windows.Forms.CheckBox
    Friend WithEvents c8 As System.Windows.Forms.CheckBox
    Friend WithEvents c1 As System.Windows.Forms.CheckBox
    Friend WithEvents c2 As System.Windows.Forms.CheckBox
    Friend WithEvents c4 As System.Windows.Forms.CheckBox
    Friend WithEvents c5 As System.Windows.Forms.CheckBox
    Friend WithEvents c6 As System.Windows.Forms.CheckBox
    Friend WithEvents C7 As System.Windows.Forms.CheckBox
End Class
