<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class can_input
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
        Me.components = New System.ComponentModel.Container
        Me.Label12 = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.save = New System.Windows.Forms.ToolStripMenuItem
        Me.edit = New System.Windows.Forms.ToolStripMenuItem
        Me.update = New System.Windows.Forms.ToolStripMenuItem
        Me.del = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.zuoriguancun = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.lurushijian = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.youwen = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dachishu = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.jinriguancun = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chuku = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ruku = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.jinkouhetonghao = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dianzizhangcehao = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chuanming = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.youpin = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.guanhao = New System.Windows.Forms.ComboBox
        Me.ruguanriqi = New System.Windows.Forms.DateTimePicker
        Me.chuguanriqi = New System.Windows.Forms.DateTimePicker
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(366, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(306, 25)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "益海（连云港）保税罐录入界面"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 256)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1240, 344)
        Me.dgv.TabIndex = 150
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.save, Me.edit, Me.update, Me.del, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 114)
        '
        'save
        '
        Me.save.Image = Global._Somesoft.My.Resources.Resources.常用系统电脑图标下载24
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(124, 22)
        Me.save.Text = "保存记录"
        '
        'edit
        '
        Me.edit.Image = Global._Somesoft.My.Resources.Resources.Osx42
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(124, 22)
        Me.edit.Text = "修改记录"
        '
        'update
        '
        Me.update.Enabled = False
        Me.update.Image = Global._Somesoft.My.Resources.Resources.Hein28
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(124, 22)
        Me.update.Text = "修改完毕"
        '
        'del
        '
        Me.del.Image = Global._Somesoft.My.Resources.Resources.Kobra
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(124, 22)
        Me.del.Text = "删除记录"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Image = Global._Somesoft.My.Resources.Resources._128_咖啡
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chuguanriqi)
        Me.GroupBox1.Controls.Add(Me.ruguanriqi)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.zuoriguancun)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lurushijian)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.youwen)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dachishu)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.jinriguancun)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chuku)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ruku)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.jinkouhetonghao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dianzizhangcehao)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chuanming)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.youpin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.guanhao)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 149)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "货物基本信息录入区域"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(239, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 183
        Me.Label14.Text = "出罐日期"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(529, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "昨日罐存"
        '
        'zuoriguancun
        '
        Me.zuoriguancun.Location = New System.Drawing.Point(590, 112)
        Me.zuoriguancun.Name = "zuoriguancun"
        Me.zuoriguancun.Size = New System.Drawing.Size(100, 21)
        Me.zuoriguancun.TabIndex = 181
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(698, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 12)
        Me.Label19.TabIndex = 180
        Me.Label19.Text = "录入时间"
        '
        'lurushijian
        '
        Me.lurushijian.ForeColor = System.Drawing.Color.Red
        Me.lurushijian.Location = New System.Drawing.Point(759, 110)
        Me.lurushijian.Name = "lurushijian"
        Me.lurushijian.ReadOnly = True
        Me.lurushijian.Size = New System.Drawing.Size(195, 21)
        Me.lurushijian.TabIndex = 179
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(722, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 178
        Me.Label11.Text = "油温"
        '
        'youwen
        '
        Me.youwen.Location = New System.Drawing.Point(759, 71)
        Me.youwen.Name = "youwen"
        Me.youwen.Size = New System.Drawing.Size(100, 21)
        Me.youwen.TabIndex = 177
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(710, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "打尺数"
        '
        'dachishu
        '
        Me.dachishu.Location = New System.Drawing.Point(759, 24)
        Me.dachishu.Name = "dachishu"
        Me.dachishu.Size = New System.Drawing.Size(100, 21)
        Me.dachishu.TabIndex = 175
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(529, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "今日罐存"
        '
        'jinriguancun
        '
        Me.jinriguancun.Location = New System.Drawing.Point(590, 82)
        Me.jinriguancun.Name = "jinriguancun"
        Me.jinriguancun.Size = New System.Drawing.Size(100, 21)
        Me.jinriguancun.TabIndex = 173
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(553, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 172
        Me.Label8.Text = "出库"
        '
        'chuku
        '
        Me.chuku.Location = New System.Drawing.Point(590, 53)
        Me.chuku.Name = "chuku"
        Me.chuku.Size = New System.Drawing.Size(100, 21)
        Me.chuku.TabIndex = 171
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(553, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "入库"
        '
        'ruku
        '
        Me.ruku.Location = New System.Drawing.Point(590, 23)
        Me.ruku.Name = "ruku"
        Me.ruku.Size = New System.Drawing.Size(100, 21)
        Me.ruku.TabIndex = 169
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "入罐日期"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "进口合同号"
        '
        'jinkouhetonghao
        '
        Me.jinkouhetonghao.FormattingEnabled = True
        Me.jinkouhetonghao.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.jinkouhetonghao.Location = New System.Drawing.Point(300, 59)
        Me.jinkouhetonghao.Name = "jinkouhetonghao"
        Me.jinkouhetonghao.Size = New System.Drawing.Size(169, 20)
        Me.jinkouhetonghao.TabIndex = 165
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "电子账册号"
        '
        'dianzizhangcehao
        '
        Me.dianzizhangcehao.FormattingEnabled = True
        Me.dianzizhangcehao.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.dianzizhangcehao.Location = New System.Drawing.Point(300, 31)
        Me.dianzizhangcehao.Name = "dianzizhangcehao"
        Me.dianzizhangcehao.Size = New System.Drawing.Size(169, 20)
        Me.dianzizhangcehao.TabIndex = 163
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "船名"
        '
        'chuanming
        '
        Me.chuanming.FormattingEnabled = True
        Me.chuanming.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.chuanming.Location = New System.Drawing.Point(76, 110)
        Me.chuanming.Name = "chuanming"
        Me.chuanming.Size = New System.Drawing.Size(101, 20)
        Me.chuanming.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "油品"
        '
        'youpin
        '
        Me.youpin.FormattingEnabled = True
        Me.youpin.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.youpin.Location = New System.Drawing.Point(76, 73)
        Me.youpin.Name = "youpin"
        Me.youpin.Size = New System.Drawing.Size(101, 20)
        Me.youpin.TabIndex = 159
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "罐号"
        '
        'guanhao
        '
        Me.guanhao.FormattingEnabled = True
        Me.guanhao.Items.AddRange(New Object() {"8503", "8504", "8505"})
        Me.guanhao.Location = New System.Drawing.Point(76, 34)
        Me.guanhao.Name = "guanhao"
        Me.guanhao.Size = New System.Drawing.Size(101, 20)
        Me.guanhao.TabIndex = 157
        '
        'ruguanriqi
        '
        Me.ruguanriqi.Location = New System.Drawing.Point(300, 88)
        Me.ruguanriqi.Name = "ruguanriqi"
        Me.ruguanriqi.Size = New System.Drawing.Size(169, 21)
        Me.ruguanriqi.TabIndex = 184
        '
        'chuguanriqi
        '
        Me.chuguanriqi.Location = New System.Drawing.Point(300, 117)
        Me.chuguanriqi.Name = "chuguanriqi"
        Me.chuguanriqi.Size = New System.Drawing.Size(169, 21)
        Me.chuguanriqi.TabIndex = 185
        '
        'can_input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 617)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Name = "can_input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Can_input"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents zuoriguancun As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lurushijian As System.Windows.Forms.TextBox
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents del As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ruguanriqi As System.Windows.Forms.DateTimePicker
    Friend WithEvents chuguanriqi As System.Windows.Forms.DateTimePicker
End Class
