<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Total_Export
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
        Me.components = New System.ComponentModel.Container()
        Me.dt12 = New System.Windows.Forms.DateTimePicker()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fahuodanwei1 = New System.Windows.Forms.CheckBox()
        Me.fahuodanwei = New System.Windows.Forms.ComboBox()
        Me.shouhuodanwei1 = New System.Windows.Forms.CheckBox()
        Me.shouhuodanwei = New System.Windows.Forms.ComboBox()
        Me.chuanming1 = New System.Windows.Forms.CheckBox()
        Me.chuanming = New System.Windows.Forms.ComboBox()
        Me.yunshudanwei1 = New System.Windows.Forms.CheckBox()
        Me.yunshudanwei = New System.Windows.Forms.ComboBox()
        Me.huowuliuxiang1 = New System.Windows.Forms.CheckBox()
        Me.huowuliuxiang = New System.Windows.Forms.ComboBox()
        Me.baojianhao1 = New System.Windows.Forms.CheckBox()
        Me.baojianhao = New System.Windows.Forms.ComboBox()
        Me.huoming1 = New System.Windows.Forms.CheckBox()
        Me.huoming = New System.Windows.Forms.ComboBox()
        Me.piaohao1 = New System.Windows.Forms.CheckBox()
        Me.piaohao = New System.Windows.Forms.ComboBox()
        Me.chehao1 = New System.Windows.Forms.CheckBox()
        Me.chehao = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.gxsj = New System.Windows.Forms.ToolStripMenuItem()
        Me.scjl = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sumnet = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dt12
        '
        Me.dt12.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt12.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt12.Location = New System.Drawing.Point(642, 93)
        Me.dt12.Name = "dt12"
        Me.dt12.Size = New System.Drawing.Size(141, 21)
        Me.dt12.TabIndex = 290
        '
        'dt11
        '
        Me.dt11.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt11.Location = New System.Drawing.Point(463, 93)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(141, 21)
        Me.dt11.TabIndex = 289
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 38)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "主库数据维护"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fahuodanwei1)
        Me.GroupBox1.Controls.Add(Me.fahuodanwei)
        Me.GroupBox1.Controls.Add(Me.shouhuodanwei1)
        Me.GroupBox1.Controls.Add(Me.shouhuodanwei)
        Me.GroupBox1.Controls.Add(Me.chuanming1)
        Me.GroupBox1.Controls.Add(Me.chuanming)
        Me.GroupBox1.Controls.Add(Me.yunshudanwei1)
        Me.GroupBox1.Controls.Add(Me.yunshudanwei)
        Me.GroupBox1.Controls.Add(Me.huowuliuxiang1)
        Me.GroupBox1.Controls.Add(Me.huowuliuxiang)
        Me.GroupBox1.Controls.Add(Me.baojianhao1)
        Me.GroupBox1.Controls.Add(Me.baojianhao)
        Me.GroupBox1.Controls.Add(Me.huoming1)
        Me.GroupBox1.Controls.Add(Me.huoming)
        Me.GroupBox1.Controls.Add(Me.piaohao1)
        Me.GroupBox1.Controls.Add(Me.piaohao)
        Me.GroupBox1.Controls.Add(Me.chehao1)
        Me.GroupBox1.Controls.Add(Me.chehao)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 150)
        Me.GroupBox1.TabIndex = 292
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询字段"
        '
        'fahuodanwei1
        '
        Me.fahuodanwei1.AutoSize = True
        Me.fahuodanwei1.Location = New System.Drawing.Point(560, 77)
        Me.fahuodanwei1.Name = "fahuodanwei1"
        Me.fahuodanwei1.Size = New System.Drawing.Size(74, 17)
        Me.fahuodanwei1.TabIndex = 19
        Me.fahuodanwei1.Text = "发货单位"
        Me.fahuodanwei1.UseVisualStyleBackColor = True
        '
        'fahuodanwei
        '
        Me.fahuodanwei.FormattingEnabled = True
        Me.fahuodanwei.Location = New System.Drawing.Point(634, 73)
        Me.fahuodanwei.Name = "fahuodanwei"
        Me.fahuodanwei.Size = New System.Drawing.Size(127, 21)
        Me.fahuodanwei.TabIndex = 18
        '
        'shouhuodanwei1
        '
        Me.shouhuodanwei1.AutoSize = True
        Me.shouhuodanwei1.Location = New System.Drawing.Point(560, 38)
        Me.shouhuodanwei1.Name = "shouhuodanwei1"
        Me.shouhuodanwei1.Size = New System.Drawing.Size(74, 17)
        Me.shouhuodanwei1.TabIndex = 17
        Me.shouhuodanwei1.Text = "收货单位"
        Me.shouhuodanwei1.UseVisualStyleBackColor = True
        '
        'shouhuodanwei
        '
        Me.shouhuodanwei.FormattingEnabled = True
        Me.shouhuodanwei.Location = New System.Drawing.Point(634, 34)
        Me.shouhuodanwei.Name = "shouhuodanwei"
        Me.shouhuodanwei.Size = New System.Drawing.Size(127, 21)
        Me.shouhuodanwei.TabIndex = 16
        '
        'chuanming1
        '
        Me.chuanming1.AutoSize = True
        Me.chuanming1.Location = New System.Drawing.Point(560, 114)
        Me.chuanming1.Name = "chuanming1"
        Me.chuanming1.Size = New System.Drawing.Size(50, 17)
        Me.chuanming1.TabIndex = 15
        Me.chuanming1.Text = "船名"
        Me.chuanming1.UseVisualStyleBackColor = True
        '
        'chuanming
        '
        Me.chuanming.FormattingEnabled = True
        Me.chuanming.Location = New System.Drawing.Point(634, 111)
        Me.chuanming.Name = "chuanming"
        Me.chuanming.Size = New System.Drawing.Size(127, 21)
        Me.chuanming.TabIndex = 14
        '
        'yunshudanwei1
        '
        Me.yunshudanwei1.AutoSize = True
        Me.yunshudanwei1.Location = New System.Drawing.Point(300, 114)
        Me.yunshudanwei1.Name = "yunshudanwei1"
        Me.yunshudanwei1.Size = New System.Drawing.Size(74, 17)
        Me.yunshudanwei1.TabIndex = 13
        Me.yunshudanwei1.Text = "运输单位"
        Me.yunshudanwei1.UseVisualStyleBackColor = True
        '
        'yunshudanwei
        '
        Me.yunshudanwei.FormattingEnabled = True
        Me.yunshudanwei.Location = New System.Drawing.Point(374, 111)
        Me.yunshudanwei.Name = "yunshudanwei"
        Me.yunshudanwei.Size = New System.Drawing.Size(127, 21)
        Me.yunshudanwei.TabIndex = 12
        '
        'huowuliuxiang1
        '
        Me.huowuliuxiang1.AutoSize = True
        Me.huowuliuxiang1.Location = New System.Drawing.Point(300, 77)
        Me.huowuliuxiang1.Name = "huowuliuxiang1"
        Me.huowuliuxiang1.Size = New System.Drawing.Size(74, 17)
        Me.huowuliuxiang1.TabIndex = 11
        Me.huowuliuxiang1.Text = "货物流向"
        Me.huowuliuxiang1.UseVisualStyleBackColor = True
        '
        'huowuliuxiang
        '
        Me.huowuliuxiang.FormattingEnabled = True
        Me.huowuliuxiang.Location = New System.Drawing.Point(374, 73)
        Me.huowuliuxiang.Name = "huowuliuxiang"
        Me.huowuliuxiang.Size = New System.Drawing.Size(127, 21)
        Me.huowuliuxiang.TabIndex = 10
        '
        'baojianhao1
        '
        Me.baojianhao1.AutoSize = True
        Me.baojianhao1.Location = New System.Drawing.Point(301, 38)
        Me.baojianhao1.Name = "baojianhao1"
        Me.baojianhao1.Size = New System.Drawing.Size(62, 17)
        Me.baojianhao1.TabIndex = 9
        Me.baojianhao1.Text = "报检号"
        Me.baojianhao1.UseVisualStyleBackColor = True
        '
        'baojianhao
        '
        Me.baojianhao.FormattingEnabled = True
        Me.baojianhao.Location = New System.Drawing.Point(374, 34)
        Me.baojianhao.Name = "baojianhao"
        Me.baojianhao.Size = New System.Drawing.Size(127, 21)
        Me.baojianhao.TabIndex = 8
        '
        'huoming1
        '
        Me.huoming1.AutoSize = True
        Me.huoming1.Location = New System.Drawing.Point(79, 114)
        Me.huoming1.Name = "huoming1"
        Me.huoming1.Size = New System.Drawing.Size(50, 17)
        Me.huoming1.TabIndex = 7
        Me.huoming1.Text = "货名"
        Me.huoming1.UseVisualStyleBackColor = True
        '
        'huoming
        '
        Me.huoming.FormattingEnabled = True
        Me.huoming.Location = New System.Drawing.Point(128, 111)
        Me.huoming.Name = "huoming"
        Me.huoming.Size = New System.Drawing.Size(127, 21)
        Me.huoming.TabIndex = 6
        '
        'piaohao1
        '
        Me.piaohao1.AutoSize = True
        Me.piaohao1.Location = New System.Drawing.Point(79, 77)
        Me.piaohao1.Name = "piaohao1"
        Me.piaohao1.Size = New System.Drawing.Size(50, 17)
        Me.piaohao1.TabIndex = 5
        Me.piaohao1.Text = "票号"
        Me.piaohao1.UseVisualStyleBackColor = True
        '
        'piaohao
        '
        Me.piaohao.FormattingEnabled = True
        Me.piaohao.Location = New System.Drawing.Point(128, 73)
        Me.piaohao.Name = "piaohao"
        Me.piaohao.Size = New System.Drawing.Size(127, 21)
        Me.piaohao.TabIndex = 4
        '
        'chehao1
        '
        Me.chehao1.AutoSize = True
        Me.chehao1.Location = New System.Drawing.Point(79, 38)
        Me.chehao1.Name = "chehao1"
        Me.chehao1.Size = New System.Drawing.Size(50, 17)
        Me.chehao1.TabIndex = 3
        Me.chehao1.Text = "车号"
        Me.chehao1.UseVisualStyleBackColor = True
        '
        'chehao
        '
        Me.chehao.FormattingEnabled = True
        Me.chehao.Location = New System.Drawing.Point(128, 34)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(127, 21)
        Me.chehao.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(610, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 293
        Me.Label3.Text = "至"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Balance.My.Resources.Resources.Hein30
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(885, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 47)
        Me.Button1.TabIndex = 294
        Me.Button1.Text = "         打印"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Balance.My.Resources.Resources.Slayman3
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(885, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 46)
        Me.Button2.TabIndex = 295
        Me.Button2.Text = "          离开"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Balance.My.Resources.Resources.Hein18
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(885, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 47)
        Me.Button3.TabIndex = 296
        Me.Button3.Text = "        检索"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv.Location = New System.Drawing.Point(19, 307)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1241, 426)
        Me.dgv.TabIndex = 297
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gxsj, Me.scjl})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 48)
        '
        'gxsj
        '
        Me.gxsj.Image = Global.Balance.My.Resources.Resources.Hein30
        Me.gxsj.Name = "gxsj"
        Me.gxsj.Size = New System.Drawing.Size(146, 22)
        Me.gxsj.Text = "更新数据"
        '
        'scjl
        '
        Me.scjl.Image = Global.Balance.My.Resources.Resources.Osx10
        Me.scjl.Name = "scjl"
        Me.scjl.Size = New System.Drawing.Size(146, 22)
        Me.scjl.Text = "删除单笔记录"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 14)
        Me.Label11.TabIndex = 298
        Me.Label11.Text = "预览区"
        '
        'sumnet
        '
        Me.sumnet.AutoSize = True
        Me.sumnet.ForeColor = System.Drawing.Color.Red
        Me.sumnet.Location = New System.Drawing.Point(1013, 736)
        Me.sumnet.Name = "sumnet"
        Me.sumnet.Size = New System.Drawing.Size(58, 13)
        Me.sumnet.TabIndex = 299
        Me.sumnet.Text = "净重总计:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(727, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox1.TabIndex = 300
        Me.CheckBox1.Text = "只显示未完成"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Report_Total_Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 774)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.sumnet)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt12)
        Me.Controls.Add(Me.dt11)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Report_Total_Export"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "m"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dt12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents yunshudanwei1 As System.Windows.Forms.CheckBox
    Friend WithEvents yunshudanwei As System.Windows.Forms.ComboBox
    Friend WithEvents huowuliuxiang1 As System.Windows.Forms.CheckBox
    Friend WithEvents huowuliuxiang As System.Windows.Forms.ComboBox
    Friend WithEvents baojianhao1 As System.Windows.Forms.CheckBox
    Friend WithEvents baojianhao As System.Windows.Forms.ComboBox
    Friend WithEvents huoming1 As System.Windows.Forms.CheckBox
    Friend WithEvents huoming As System.Windows.Forms.ComboBox
    Friend WithEvents piaohao1 As System.Windows.Forms.CheckBox
    Friend WithEvents piaohao As System.Windows.Forms.ComboBox
    Friend WithEvents chehao1 As System.Windows.Forms.CheckBox
    Friend WithEvents chehao As System.Windows.Forms.ComboBox
    Friend WithEvents fahuodanwei1 As System.Windows.Forms.CheckBox
    Friend WithEvents fahuodanwei As System.Windows.Forms.ComboBox
    Friend WithEvents shouhuodanwei1 As System.Windows.Forms.CheckBox
    Friend WithEvents shouhuodanwei As System.Windows.Forms.ComboBox
    Friend WithEvents chuanming1 As System.Windows.Forms.CheckBox
    Friend WithEvents chuanming As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents gxsj As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scjl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sumnet As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
