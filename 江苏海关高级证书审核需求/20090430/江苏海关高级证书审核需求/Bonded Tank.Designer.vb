<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bonded
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.youwen = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dachishu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.jinriguancun = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chuku = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ruku = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jinkouhetonghao = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dianzizhangcehao = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chuanming = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.youpin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guanhao = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.zuoriguancun = New System.Windows.Forms.TextBox()
        Me.货物信息2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chuguanriqi = New System.Windows.Forms.DateTimePicker()
        Me.ruguanriqi = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.idid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.jilushu = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.修改保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.货物信息2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv.Location = New System.Drawing.Point(12, 331)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1222, 250)
        Me.dgv.TabIndex = 180
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(422, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(421, 32)
        Me.Label12.TabIndex = 179
        Me.Label12.Text = "益海（连云港）保税罐信息管理"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(199, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "货物编号"
        '
        'youwen
        '
        Me.youwen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.youwen.Location = New System.Drawing.Point(260, 21)
        Me.youwen.Name = "youwen"
        Me.youwen.Size = New System.Drawing.Size(169, 20)
        Me.youwen.TabIndex = 175
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 174
        Me.Label10.Text = "打尺数"
        '
        'dachishu
        '
        Me.dachishu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dachishu.Location = New System.Drawing.Point(370, 30)
        Me.dachishu.Name = "dachishu"
        Me.dachishu.Size = New System.Drawing.Size(100, 20)
        Me.dachishu.TabIndex = 173
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(161, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "今日罐存"
        '
        'jinriguancun
        '
        Me.jinriguancun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jinriguancun.Location = New System.Drawing.Point(219, 31)
        Me.jinriguancun.Name = "jinriguancun"
        Me.jinriguancun.Size = New System.Drawing.Size(100, 20)
        Me.jinriguancun.TabIndex = 171
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "出库"
        '
        'chuku
        '
        Me.chuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chuku.Location = New System.Drawing.Point(51, 61)
        Me.chuku.Name = "chuku"
        Me.chuku.Size = New System.Drawing.Size(100, 20)
        Me.chuku.TabIndex = 169
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "入库"
        '
        'ruku
        '
        Me.ruku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ruku.Location = New System.Drawing.Point(51, 31)
        Me.ruku.Name = "ruku"
        Me.ruku.Size = New System.Drawing.Size(100, 20)
        Me.ruku.TabIndex = 167
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "入罐日期"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "进口合同号"
        '
        'jinkouhetonghao
        '
        Me.jinkouhetonghao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jinkouhetonghao.FormattingEnabled = True
        Me.jinkouhetonghao.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.jinkouhetonghao.Location = New System.Drawing.Point(260, 72)
        Me.jinkouhetonghao.Name = "jinkouhetonghao"
        Me.jinkouhetonghao.Size = New System.Drawing.Size(169, 21)
        Me.jinkouhetonghao.TabIndex = 163
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "电子账册号"
        '
        'dianzizhangcehao
        '
        Me.dianzizhangcehao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dianzizhangcehao.FormattingEnabled = True
        Me.dianzizhangcehao.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.dianzizhangcehao.Location = New System.Drawing.Point(260, 46)
        Me.dianzizhangcehao.Name = "dianzizhangcehao"
        Me.dianzizhangcehao.Size = New System.Drawing.Size(169, 21)
        Me.dianzizhangcehao.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "船名"
        '
        'chuanming
        '
        Me.chuanming.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chuanming.FormattingEnabled = True
        Me.chuanming.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.chuanming.Location = New System.Drawing.Point(59, 72)
        Me.chuanming.Name = "chuanming"
        Me.chuanming.Size = New System.Drawing.Size(101, 21)
        Me.chuanming.TabIndex = 159
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "油品"
        '
        'youpin
        '
        Me.youpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.youpin.FormattingEnabled = True
        Me.youpin.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.youpin.Location = New System.Drawing.Point(59, 46)
        Me.youpin.Name = "youpin"
        Me.youpin.Size = New System.Drawing.Size(101, 21)
        Me.youpin.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "罐号"
        '
        'guanhao
        '
        Me.guanhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guanhao.FormattingEnabled = True
        Me.guanhao.Items.AddRange(New Object() {"8503", "8504", "8505"})
        Me.guanhao.Location = New System.Drawing.Point(59, 20)
        Me.guanhao.Name = "guanhao"
        Me.guanhao.Size = New System.Drawing.Size(101, 21)
        Me.guanhao.TabIndex = 155
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(161, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 193
        Me.Label15.Text = "昨日罐存"
        '
        'zuoriguancun
        '
        Me.zuoriguancun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.zuoriguancun.Location = New System.Drawing.Point(219, 61)
        Me.zuoriguancun.Name = "zuoriguancun"
        Me.zuoriguancun.Size = New System.Drawing.Size(100, 20)
        Me.zuoriguancun.TabIndex = 192
        '
        '货物信息2
        '
        Me.货物信息2.Controls.Add(Me.ruku)
        Me.货物信息2.Controls.Add(Me.Label15)
        Me.货物信息2.Controls.Add(Me.Label7)
        Me.货物信息2.Controls.Add(Me.chuku)
        Me.货物信息2.Controls.Add(Me.zuoriguancun)
        Me.货物信息2.Controls.Add(Me.Label8)
        Me.货物信息2.Controls.Add(Me.jinriguancun)
        Me.货物信息2.Controls.Add(Me.Label9)
        Me.货物信息2.Controls.Add(Me.dachishu)
        Me.货物信息2.Controls.Add(Me.Label10)
        Me.货物信息2.Location = New System.Drawing.Point(717, 109)
        Me.货物信息2.Name = "货物信息2"
        Me.货物信息2.Size = New System.Drawing.Size(484, 99)
        Me.货物信息2.TabIndex = 195
        Me.货物信息2.TabStop = False
        Me.货物信息2.Text = "货物信息2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chuguanriqi)
        Me.GroupBox1.Controls.Add(Me.ruguanriqi)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.guanhao)
        Me.GroupBox1.Controls.Add(Me.youpin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.chuanming)
        Me.GroupBox1.Controls.Add(Me.dianzizhangcehao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.youwen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.jinkouhetonghao)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 99)
        Me.GroupBox1.TabIndex = 196
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "货物信息1"
        '
        'chuguanriqi
        '
        Me.chuguanriqi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chuguanriqi.Location = New System.Drawing.Point(524, 62)
        Me.chuguanriqi.Name = "chuguanriqi"
        Me.chuguanriqi.Size = New System.Drawing.Size(169, 26)
        Me.chuguanriqi.TabIndex = 186
        '
        'ruguanriqi
        '
        Me.ruguanriqi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ruguanriqi.Location = New System.Drawing.Point(524, 24)
        Me.ruguanriqi.Name = "ruguanriqi"
        Me.ruguanriqi.Size = New System.Drawing.Size(169, 26)
        Me.ruguanriqi.TabIndex = 185
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(465, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 167
        Me.Label16.Text = "出罐日期"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(123, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 57)
        Me.Button1.TabIndex = 197
        Me.Button1.Text = "保存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(891, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 57)
        Me.Button2.TabIndex = 198
        Me.Button2.Text = "退出"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(380, 246)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 57)
        Me.Button3.TabIndex = 199
        Me.Button3.Text = "WEB查询"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(632, 246)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(215, 57)
        Me.Button4.TabIndex = 200
        Me.Button4.Text = "删除ID"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'idid
        '
        Me.idid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idid.Location = New System.Drawing.Point(632, 246)
        Me.idid.Name = "idid"
        Me.idid.Size = New System.Drawing.Size(55, 20)
        Me.idid.TabIndex = 201
        Me.idid.Text = "ID号"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(595, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 202
        Me.Label13.Text = "Ver 20140612"
        '
        'jilushu
        '
        Me.jilushu.AutoSize = True
        Me.jilushu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jilushu.ForeColor = System.Drawing.Color.Red
        Me.jilushu.Location = New System.Drawing.Point(12, 315)
        Me.jilushu.Name = "jilushu"
        Me.jilushu.Size = New System.Drawing.Size(75, 13)
        Me.jilushu.TabIndex = 203
        Me.jilushu.Text = "总计N笔记录"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改保存ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        '修改保存ToolStripMenuItem
        '
        Me.修改保存ToolStripMenuItem.Name = "修改保存ToolStripMenuItem"
        Me.修改保存ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.修改保存ToolStripMenuItem.Text = "修改保存"
        '
        'Bonded
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 621)
        Me.Controls.Add(Me.jilushu)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.idid)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.货物信息2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label12)
        Me.Name = "Bonded"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "益海（连云港）保税罐信息管理界面"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.货物信息2.ResumeLayout(False)
        Me.货物信息2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents youwen As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dachishu As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents jinriguancun As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chuku As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ruku As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jinkouhetonghao As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dianzizhangcehao As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chuanming As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents youpin As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents guanhao As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents zuoriguancun As System.Windows.Forms.TextBox
    Friend WithEvents 货物信息2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chuguanriqi As System.Windows.Forms.DateTimePicker
    Friend WithEvents ruguanriqi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents idid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents jilushu As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 修改保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
