<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car1
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.编辑记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.fache = New System.Windows.Forms.ToolStripMenuItem
        Me.save = New System.Windows.Forms.ToolStripMenuItem
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dianhua = New System.Windows.Forms.ComboBox
        Me.chexing = New System.Windows.Forms.ComboBox
        Me.siji = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chehao = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.chekuang = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.zhuangtai = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.fanhuishijian = New System.Windows.Forms.MaskedTextBox
        Me.facheshijian = New System.Windows.Forms.MaskedTextBox
        Me.DT1 = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.beizhu = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.renwumiaoshu = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.zhouji = New System.Windows.Forms.TextBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.Label
        Me.idtextbox = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.编辑记录ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 48)
        '
        '编辑记录ToolStripMenuItem
        '
        Me.编辑记录ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.编辑ToolStripMenuItem, Me.fache, Me.save})
        Me.编辑记录ToolStripMenuItem.Image = Global._Somesoft.My.Resources.Resources._3
        Me.编辑记录ToolStripMenuItem.Name = "编辑记录ToolStripMenuItem"
        Me.编辑记录ToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.编辑记录ToolStripMenuItem.Text = "编辑记录"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.Image = Global._Somesoft.My.Resources.Resources.方向标
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.编辑ToolStripMenuItem.Text = "编辑"
        '
        'fache
        '
        Me.fache.Enabled = False
        Me.fache.Image = Global._Somesoft.My.Resources.Resources.轿车
        Me.fache.Name = "fache"
        Me.fache.Size = New System.Drawing.Size(152, 22)
        Me.fache.Text = "保存+发车"
        '
        'save
        '
        Me.save.Enabled = False
        Me.save.Image = Global._Somesoft.My.Resources.Resources.chinaz21
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(152, 22)
        Me.save.Text = "保存"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Image = Global._Somesoft.My.Resources.Resources._128_咖啡1
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dianhua)
        Me.GroupBox1.Controls.Add(Me.chexing)
        Me.GroupBox1.Controls.Add(Me.siji)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chehao)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "车辆基本信息"
        '
        'dianhua
        '
        Me.dianhua.FormattingEnabled = True
        Me.dianhua.Location = New System.Drawing.Point(252, 53)
        Me.dianhua.Name = "dianhua"
        Me.dianhua.Size = New System.Drawing.Size(118, 20)
        Me.dianhua.TabIndex = 10
        '
        'chexing
        '
        Me.chexing.FormattingEnabled = True
        Me.chexing.Location = New System.Drawing.Point(57, 53)
        Me.chexing.Name = "chexing"
        Me.chexing.Size = New System.Drawing.Size(118, 20)
        Me.chexing.TabIndex = 9
        '
        'siji
        '
        Me.siji.FormattingEnabled = True
        Me.siji.Location = New System.Drawing.Point(252, 18)
        Me.siji.Name = "siji"
        Me.siji.Size = New System.Drawing.Size(118, 20)
        Me.siji.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "电话"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "司机"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "车型"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "车号"
        '
        'chehao
        '
        Me.chehao.FormattingEnabled = True
        Me.chehao.Location = New System.Drawing.Point(57, 18)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(118, 20)
        Me.chehao.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.chekuang)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.zhuangtai)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.fanhuishijian)
        Me.GroupBox2.Controls.Add(Me.facheshijian)
        Me.GroupBox2.Controls.Add(Me.DT1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.beizhu)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.renwumiaoshu)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.zhouji)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(943, 88)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "发车事件信息"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(445, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 12)
        Me.Label12.TabIndex = 140
        Me.Label12.Text = "车况"
        '
        'chekuang
        '
        Me.chekuang.FormattingEnabled = True
        Me.chekuang.Items.AddRange(New Object() {"良好", "优秀", "一般", "故障"})
        Me.chekuang.Location = New System.Drawing.Point(480, 48)
        Me.chekuang.Name = "chekuang"
        Me.chekuang.Size = New System.Drawing.Size(118, 20)
        Me.chekuang.TabIndex = 139
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(445, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "状态"
        '
        'zhuangtai
        '
        Me.zhuangtai.FormattingEnabled = True
        Me.zhuangtai.Items.AddRange(New Object() {"良好", "一般", "很差"})
        Me.zhuangtai.Location = New System.Drawing.Point(480, 21)
        Me.zhuangtai.Name = "zhuangtai"
        Me.zhuangtai.Size = New System.Drawing.Size(118, 20)
        Me.zhuangtai.TabIndex = 137
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(685, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "备注"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "星期"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(671, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "任务描述"
        '
        'fanhuishijian
        '
        Me.fanhuishijian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fanhuishijian.Location = New System.Drawing.Point(324, 48)
        Me.fanhuishijian.Mask = "00:00"
        Me.fanhuishijian.Name = "fanhuishijian"
        Me.fanhuishijian.Size = New System.Drawing.Size(55, 26)
        Me.fanhuishijian.TabIndex = 133
        '
        'facheshijian
        '
        Me.facheshijian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.facheshijian.Location = New System.Drawing.Point(324, 18)
        Me.facheshijian.Mask = "00:00"
        Me.facheshijian.Name = "facheshijian"
        Me.facheshijian.Size = New System.Drawing.Size(55, 26)
        Me.facheshijian.TabIndex = 132
        '
        'DT1
        '
        Me.DT1.Location = New System.Drawing.Point(85, 26)
        Me.DT1.Name = "DT1"
        Me.DT1.Size = New System.Drawing.Size(117, 21)
        Me.DT1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "计划返回时间"
        '
        'beizhu
        '
        Me.beizhu.Location = New System.Drawing.Point(732, 52)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(194, 21)
        Me.beizhu.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "计划发车时间"
        '
        'renwumiaoshu
        '
        Me.renwumiaoshu.Location = New System.Drawing.Point(732, 24)
        Me.renwumiaoshu.Name = "renwumiaoshu"
        Me.renwumiaoshu.Size = New System.Drawing.Size(194, 21)
        Me.renwumiaoshu.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "发车日期"
        '
        'zhouji
        '
        Me.zhouji.Location = New System.Drawing.Point(85, 50)
        Me.zhouji.Name = "zhouji"
        Me.zhouji.ReadOnly = True
        Me.zhouji.Size = New System.Drawing.Size(25, 21)
        Me.zhouji.TabIndex = 6
        '
        'dgv
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgv.Location = New System.Drawing.Point(37, 267)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(943, 234)
        Me.dgv.TabIndex = 3
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(42, 510)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(17, 12)
        Me.id.TabIndex = 139
        Me.id.Text = "id"
        '
        'idtextbox
        '
        Me.idtextbox.Location = New System.Drawing.Point(65, 507)
        Me.idtextbox.Name = "idtextbox"
        Me.idtextbox.ReadOnly = True
        Me.idtextbox.Size = New System.Drawing.Size(25, 21)
        Me.idtextbox.TabIndex = 138
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(720, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 24)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "发车事件主界面"
        '
        'Car1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 529)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.idtextbox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Car1"
        Me.Text = "发车事件主界面"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chehao As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents beizhu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents renwumiaoshu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents zhouji As System.Windows.Forms.TextBox
    Friend WithEvents DT1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fanhuishijian As System.Windows.Forms.MaskedTextBox
    Friend WithEvents facheshijian As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents zhuangtai As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chekuang As System.Windows.Forms.ComboBox
    Friend WithEvents 编辑记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents idtextbox As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fache As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dianhua As System.Windows.Forms.ComboBox
    Friend WithEvents chexing As System.Windows.Forms.ComboBox
    Friend WithEvents siji As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
