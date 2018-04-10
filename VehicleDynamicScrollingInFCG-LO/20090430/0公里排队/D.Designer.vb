<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wuliu
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("豆粕类功能选择菜单")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可登记")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记43%粕车辆")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记其他车辆")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("自派的车辆")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("散货车辆")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可进厂车辆")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已完成车辆")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--超时车辆")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--退回车辆")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记卸货车辆")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("油脂类功能选择菜单")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记车辆")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可进厂车辆")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已完成车辆")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--超时车辆")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--退回车辆")
        Me.beizhu = New System.Windows.Forms.RichTextBox()
        Me.dianhuahaoma = New System.Windows.Forms.TextBox()
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.Box2 = New System.Windows.Forms.GroupBox()
        Me.shuliang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.Color = New System.Windows.Forms.CheckBox()
        Me.chehao = New System.Windows.Forms.TextBox()
        Me.pinming = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tidanhao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kehumingcheng = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chaxun = New System.Windows.Forms.TextBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Box2.SuspendLayout()
        Me.jichuxinxi.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'beizhu
        '
        Me.beizhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.beizhu.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.beizhu.Location = New System.Drawing.Point(77, 327)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(135, 67)
        Me.beizhu.TabIndex = 159
        Me.beizhu.Text = ""
        '
        'dianhuahaoma
        '
        Me.dianhuahaoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dianhuahaoma.Enabled = False
        Me.dianhuahaoma.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dianhuahaoma.Location = New System.Drawing.Point(77, 289)
        Me.dianhuahaoma.Name = "dianhuahaoma"
        Me.dianhuahaoma.Size = New System.Drawing.Size(135, 21)
        Me.dianhuahaoma.TabIndex = 158
        '
        'yidengji
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.yidengji.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.yidengji.Location = New System.Drawing.Point(6, 22)
        Me.yidengji.Name = "yidengji"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.yidengji.RowTemplate.Height = 23
        Me.yidengji.Size = New System.Drawing.Size(741, 522)
        Me.yidengji.TabIndex = 144
        '
        'Box2
        '
        Me.Box2.Controls.Add(Me.yidengji)
        Me.Box2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Box2.ForeColor = System.Drawing.Color.Red
        Me.Box2.Location = New System.Drawing.Point(497, 5)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(753, 550)
        Me.Box2.TabIndex = 179
        Me.Box2.TabStop = False
        '
        'shuliang
        '
        Me.shuliang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shuliang.Enabled = False
        Me.shuliang.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shuliang.Location = New System.Drawing.Point(77, 190)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(41, 21)
        Me.shuliang.TabIndex = 181
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "提单量"
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Location = New System.Drawing.Point(73, 38)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(24, 21)
        Me.IDID.TabIndex = 167
        Me.IDID.Text = "id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 20)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "ID"
        '
        'jichuxinxi
        '
        Me.jichuxinxi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.jichuxinxi.Controls.Add(Me.Color)
        Me.jichuxinxi.Controls.Add(Me.shuliang)
        Me.jichuxinxi.Controls.Add(Me.Label5)
        Me.jichuxinxi.Controls.Add(Me.IDID)
        Me.jichuxinxi.Controls.Add(Me.Label1)
        Me.jichuxinxi.Controls.Add(Me.beizhu)
        Me.jichuxinxi.Controls.Add(Me.dianhuahaoma)
        Me.jichuxinxi.Controls.Add(Me.chehao)
        Me.jichuxinxi.Controls.Add(Me.pinming)
        Me.jichuxinxi.Controls.Add(Me.Label25)
        Me.jichuxinxi.Controls.Add(Me.tidanhao)
        Me.jichuxinxi.Controls.Add(Me.Label6)
        Me.jichuxinxi.Controls.Add(Me.Label15)
        Me.jichuxinxi.Controls.Add(Me.kehumingcheng)
        Me.jichuxinxi.Controls.Add(Me.Label4)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Controls.Add(Me.Label2)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(14, 5)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(234, 413)
        Me.jichuxinxi.TabIndex = 178
        Me.jichuxinxi.TabStop = False
        Me.jichuxinxi.Text = "基础信息"
        '
        'Color
        '
        Me.Color.AutoSize = True
        Me.Color.ForeColor = System.Drawing.Color.Red
        Me.Color.Location = New System.Drawing.Point(12, 388)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(205, 25)
        Me.Color.TabIndex = 184
        Me.Color.Text = "蓝牌（不选默认为黄牌）"
        Me.Color.UseVisualStyleBackColor = True
        Me.Color.Visible = False
        '
        'chehao
        '
        Me.chehao.Enabled = False
        Me.chehao.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chehao.Location = New System.Drawing.Point(77, 235)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(135, 21)
        Me.chehao.TabIndex = 157
        '
        'pinming
        '
        Me.pinming.Enabled = False
        Me.pinming.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pinming.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pinming.FormattingEnabled = True
        Me.pinming.Items.AddRange(New Object() {"经销出", "赠品出", "食堂领用", "礼品领用", "品控抽检", "回填", "换货出"})
        Me.pinming.Location = New System.Drawing.Point(77, 131)
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(135, 20)
        Me.pinming.TabIndex = 155
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 129)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 20)
        Me.Label25.TabIndex = 156
        Me.Label25.Text = "货物名称"
        '
        'tidanhao
        '
        Me.tidanhao.Enabled = False
        Me.tidanhao.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tidanhao.Location = New System.Drawing.Point(77, 169)
        Me.tidanhao.Name = "tidanhao"
        Me.tidanhao.Size = New System.Drawing.Size(91, 21)
        Me.tidanhao.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "提单号"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(36, 318)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 20)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "备注"
        '
        'kehumingcheng
        '
        Me.kehumingcheng.Enabled = False
        Me.kehumingcheng.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.kehumingcheng.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kehumingcheng.FormattingEnabled = True
        Me.kehumingcheng.Location = New System.Drawing.Point(77, 79)
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(135, 20)
        Me.kehumingcheng.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "电话号码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "客户名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "车号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(272, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 21)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "车号查询"
        '
        'chaxun
        '
        Me.chaxun.BackColor = System.Drawing.Color.Red
        Me.chaxun.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chaxun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chaxun.Location = New System.Drawing.Point(352, 12)
        Me.chaxun.Name = "chaxun"
        Me.chaxun.Size = New System.Drawing.Size(139, 33)
        Me.chaxun.TabIndex = 183
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(254, 63)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode1.ForeColor = System.Drawing.Color.Yellow
        TreeNode1.ImageIndex = -2
        TreeNode1.Name = "节点0"
        TreeNode1.Text = "豆粕类功能选择菜单"
        TreeNode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        TreeNode2.Name = "节点0"
        TreeNode2.Text = "可登记"
        TreeNode3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode3.ForeColor = System.Drawing.Color.Yellow
        TreeNode3.Name = "节点1"
        TreeNode3.Text = "已登记43%粕车辆"
        TreeNode4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode4.ForeColor = System.Drawing.Color.Yellow
        TreeNode4.Name = "节点4"
        TreeNode4.Text = "已登记其他车辆"
        TreeNode5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode5.ForeColor = System.Drawing.Color.Yellow
        TreeNode5.Name = "节点5"
        TreeNode5.Text = "自派的车辆"
        TreeNode6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode6.ForeColor = System.Drawing.Color.Yellow
        TreeNode6.Name = "节点1"
        TreeNode6.Text = "散货车辆"
        TreeNode7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode7.ForeColor = System.Drawing.Color.Yellow
        TreeNode7.Name = "节点0"
        TreeNode7.Text = "可进厂车辆"
        TreeNode8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode8.ForeColor = System.Drawing.Color.Yellow
        TreeNode8.Name = "节点0"
        TreeNode8.Text = "已完成车辆"
        TreeNode9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode9.ForeColor = System.Drawing.Color.Yellow
        TreeNode9.Name = "节点0"
        TreeNode9.Text = "--超时车辆"
        TreeNode10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode10.ForeColor = System.Drawing.Color.Yellow
        TreeNode10.Name = "节点0"
        TreeNode10.Text = "--退回车辆"
        TreeNode11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode11.ForeColor = System.Drawing.Color.Yellow
        TreeNode11.Name = "节点1"
        TreeNode11.Text = "已登记卸货车辆"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Me.TreeView1.Size = New System.Drawing.Size(237, 208)
        Me.TreeView1.TabIndex = 185
        '
        'TreeView2
        '
        Me.TreeView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TreeView2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView2.ForeColor = System.Drawing.Color.Yellow
        Me.TreeView2.Location = New System.Drawing.Point(254, 277)
        Me.TreeView2.Name = "TreeView2"
        TreeNode12.ForeColor = System.Drawing.Color.Yellow
        TreeNode12.ImageIndex = -2
        TreeNode12.Name = "节点0"
        TreeNode12.Text = "油脂类功能选择菜单"
        TreeNode13.Name = "节点1"
        TreeNode13.Text = "已登记车辆"
        TreeNode14.Name = "节点0"
        TreeNode14.Text = "可进厂车辆"
        TreeNode15.Name = "节点0"
        TreeNode15.Text = "已完成车辆"
        TreeNode16.ForeColor = System.Drawing.Color.Yellow
        TreeNode16.Name = "节点0"
        TreeNode16.Text = "--超时车辆"
        TreeNode17.ForeColor = System.Drawing.Color.Yellow
        TreeNode17.Name = "节点0"
        TreeNode17.Text = "--退回车辆"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17})
        Me.TreeView2.Size = New System.Drawing.Size(237, 141)
        Me.TreeView2.TabIndex = 186
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(254, 424)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(237, 131)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 188
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(14, 424)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 187
        Me.PictureBox1.TabStop = False
        '
        'wuliu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 562)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chaxun)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Name = "wuliu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "物流查看界面"
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Box2.ResumeLayout(False)
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents beizhu As System.Windows.Forms.RichTextBox
    Friend WithEvents dianhuahaoma As System.Windows.Forms.TextBox
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Friend WithEvents Box2 As System.Windows.Forms.GroupBox
    Friend WithEvents shuliang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents chehao As System.Windows.Forms.TextBox
    Friend WithEvents pinming As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tidanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents kehumingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chaxun As System.Windows.Forms.TextBox
    Friend WithEvents Color As System.Windows.Forms.CheckBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
