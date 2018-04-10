<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QZ_Users
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c21 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.S = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.station = New System.Windows.Forms.ComboBox()
        Me.TextBox113 = New System.Windows.Forms.TextBox()
        Me.DisplayShowPasswordMark = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.isShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox114 = New System.Windows.Forms.TextBox()
        Me.TextBox115 = New System.Windows.Forms.TextBox()
        Me.changepassword = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.c21.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.DisplayShowPasswordMark.SuspendLayout()
        Me.changepassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(14, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(316, 54)
        Me.Button5.TabIndex = 179
        Me.Button5.Text = "修改"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(98, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(232, 46)
        Me.TextBox3.TabIndex = 178
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Old Password"
        '
        'c21
        '
        Me.c21.Controls.Add(Me.dgv)
        Me.c21.Controls.Add(Me.Button1)
        Me.c21.Controls.Add(Me.Button4)
        Me.c21.Controls.Add(Me.Button2)
        Me.c21.Controls.Add(Me.Button3)
        Me.c21.Controls.Add(Me.GroupBox13)
        Me.c21.Location = New System.Drawing.Point(12, 9)
        Me.c21.Name = "c21"
        Me.c21.Size = New System.Drawing.Size(943, 439)
        Me.c21.TabIndex = 95
        Me.c21.TabStop = False
        Me.c21.Text = "用户管理界面"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(292, 23)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(645, 400)
        Me.dgv.TabIndex = 82
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 46)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 283)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(276, 46)
        Me.Button4.TabIndex = 91
        Me.Button4.Text = "删除用户"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(276, 46)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "设置密码"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(276, 46)
        Me.Button3.TabIndex = 90
        Me.Button3.Text = "增加用户"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.S)
        Me.GroupBox13.Controls.Add(Me.Label114)
        Me.GroupBox13.Controls.Add(Me.Label115)
        Me.GroupBox13.Controls.Add(Me.Label116)
        Me.GroupBox13.Controls.Add(Me.station)
        Me.GroupBox13.Controls.Add(Me.TextBox113)
        Me.GroupBox13.Controls.Add(Me.TextBox114)
        Me.GroupBox13.Controls.Add(Me.TextBox115)
        Me.GroupBox13.Location = New System.Drawing.Point(10, 20)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(276, 210)
        Me.GroupBox13.TabIndex = 89
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Information"
        '
        'S
        '
        Me.S.AutoSize = True
        Me.S.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.S.Location = New System.Drawing.Point(142, 174)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(77, 21)
        Me.S.TabIndex = 177
        Me.S.Text = "Station ?"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label114.Location = New System.Drawing.Point(172, 131)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(82, 21)
        Me.Label114.TabIndex = 175
        Me.Label114.Text = "Password"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label115.Location = New System.Drawing.Point(167, 92)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(87, 21)
        Me.Label115.TabIndex = 173
        Me.Label115.Text = "Username"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label116.Location = New System.Drawing.Point(227, 53)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(27, 21)
        Me.Label116.TabIndex = 171
        Me.Label116.Text = "ID"
        '
        'station
        '
        Me.station.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.station.FormattingEnabled = True
        Me.station.Items.AddRange(New Object() {"粮油罐区", "筒仓", "------------", "粕库", "榨油厂", "精炼厂", "分提车间", "酸化油车间", "35T锅炉房", "75T锅炉房", "污水处理", "小包装罐区", "", "小包装成品库", "小包装辅料库", "IT", "财务", "管理"})
        Me.station.Location = New System.Drawing.Point(28, 171)
        Me.station.Name = "station"
        Me.station.Size = New System.Drawing.Size(226, 29)
        Me.station.TabIndex = 77
        '
        'TextBox113
        '
        Me.TextBox113.ContextMenuStrip = Me.DisplayShowPasswordMark
        Me.TextBox113.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox113.Location = New System.Drawing.Point(28, 128)
        Me.TextBox113.Name = "TextBox113"
        Me.TextBox113.Size = New System.Drawing.Size(226, 29)
        Me.TextBox113.TabIndex = 176
        Me.TextBox113.UseSystemPasswordChar = True
        '
        'DisplayShowPasswordMark
        '
        Me.DisplayShowPasswordMark.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.isShow})
        Me.DisplayShowPasswordMark.Name = "DisplayShowPasswordMark"
        Me.DisplayShowPasswordMark.Size = New System.Drawing.Size(125, 26)
        '
        'isShow
        '
        Me.isShow.Name = "isShow"
        Me.isShow.Size = New System.Drawing.Size(124, 22)
        Me.isShow.Text = "显示明码"
        '
        'TextBox114
        '
        Me.TextBox114.Enabled = False
        Me.TextBox114.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox114.Location = New System.Drawing.Point(28, 89)
        Me.TextBox114.Name = "TextBox114"
        Me.TextBox114.Size = New System.Drawing.Size(226, 29)
        Me.TextBox114.TabIndex = 174
        '
        'TextBox115
        '
        Me.TextBox115.Enabled = False
        Me.TextBox115.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox115.Location = New System.Drawing.Point(28, 50)
        Me.TextBox115.Name = "TextBox115"
        Me.TextBox115.Size = New System.Drawing.Size(226, 29)
        Me.TextBox115.TabIndex = 172
        '
        'changepassword
        '
        Me.changepassword.Controls.Add(Me.Button5)
        Me.changepassword.Controls.Add(Me.TextBox3)
        Me.changepassword.Controls.Add(Me.Label2)
        Me.changepassword.Controls.Add(Me.TextBox1)
        Me.changepassword.Controls.Add(Me.Label3)
        Me.changepassword.Location = New System.Drawing.Point(625, 9)
        Me.changepassword.Name = "changepassword"
        Me.changepassword.Size = New System.Drawing.Size(339, 225)
        Me.changepassword.TabIndex = 96
        Me.changepassword.TabStop = False
        Me.changepassword.Text = "Username Display"
        Me.changepassword.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(98, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 46)
        Me.TextBox1.TabIndex = 176
        '
        'QZ_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 456)
        Me.Controls.Add(Me.c21)
        Me.Controls.Add(Me.changepassword)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "QZ_Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "用户管理界面"
        Me.c21.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.DisplayShowPasswordMark.ResumeLayout(False)
        Me.changepassword.ResumeLayout(False)
        Me.changepassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c21 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents S As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents station As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox113 As System.Windows.Forms.TextBox
    Friend WithEvents DisplayShowPasswordMark As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents isShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox114 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox115 As System.Windows.Forms.TextBox
    Friend WithEvents changepassword As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
