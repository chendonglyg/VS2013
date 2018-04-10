<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAOYI
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("功能选择菜单")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可登记")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可进厂")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已完成")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--超时车辆")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--退回车辆")
        Me.Box2 = New System.Windows.Forms.GroupBox()
        Me.kedengji = New System.Windows.Forms.DataGridView()
        Me.C1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.del = New System.Windows.Forms.ToolStripMenuItem()
        Me.force = New System.Windows.Forms.ToolStripMenuItem()
        Me.配卡通行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.zipaiche = New System.Windows.Forms.CheckBox()
        Me.beizhu = New System.Windows.Forms.RichTextBox()
        Me.dianhuahaoma = New System.Windows.Forms.TextBox()
        Me.chehao = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.loading = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.idid = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chaxun = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.isReserved = New System.Windows.Forms.CheckBox()
        Me.Reservedtime2 = New System.Windows.Forms.TextBox()
        Me.Reservedtime1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pinming = New System.Windows.Forms.TextBox()
        Me.kehumingcheng = New System.Windows.Forms.TextBox()
        Me.tidanhao = New System.Windows.Forms.TextBox()
        Me.shuliang = New System.Windows.Forms.TextBox()
        Me.Box2.SuspendLayout()
        CType(Me.kedengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1.SuspendLayout()
        Me.jichuxinxi.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Box2
        '
        Me.Box2.Controls.Add(Me.kedengji)
        Me.Box2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Box2.ForeColor = System.Drawing.Color.Red
        Me.Box2.Location = New System.Drawing.Point(493, 12)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(759, 546)
        Me.Box2.TabIndex = 163
        Me.Box2.TabStop = False
        '
        'kedengji
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kedengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.kedengji.BackgroundColor = System.Drawing.Color.White
        Me.kedengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kedengji.ContextMenuStrip = Me.C1
        Me.kedengji.Location = New System.Drawing.Point(15, 20)
        Me.kedengji.Name = "kedengji"
        Me.kedengji.ReadOnly = True
        Me.kedengji.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kedengji.RowTemplate.Height = 23
        Me.kedengji.Size = New System.Drawing.Size(720, 517)
        Me.kedengji.TabIndex = 144
        '
        'C1
        '
        Me.C1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.del, Me.force, Me.配卡通行ToolStripMenuItem})
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(125, 70)
        '
        'del
        '
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(124, 22)
        Me.del.Text = "删除记录"
        '
        'force
        '
        Me.force.ForeColor = System.Drawing.Color.Red
        Me.force.Name = "force"
        Me.force.Size = New System.Drawing.Size(124, 22)
        Me.force.Text = "强制登记"
        '
        '配卡通行ToolStripMenuItem
        '
        Me.配卡通行ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.配卡通行ToolStripMenuItem.Name = "配卡通行ToolStripMenuItem"
        Me.配卡通行ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.配卡通行ToolStripMenuItem.Text = "配卡通行"
        '
        'jichuxinxi
        '
        Me.jichuxinxi.Controls.Add(Me.GroupBox3)
        Me.jichuxinxi.Controls.Add(Me.GroupBox2)
        Me.jichuxinxi.Controls.Add(Me.GroupBox1)
        Me.jichuxinxi.Controls.Add(Me.Label15)
        Me.jichuxinxi.Controls.Add(Me.beizhu)
        Me.jichuxinxi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(12, 32)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(298, 526)
        Me.jichuxinxi.TabIndex = 162
        Me.jichuxinxi.TabStop = False
        Me.jichuxinxi.Text = "基础信息"
        '
        'zipaiche
        '
        Me.zipaiche.AutoSize = True
        Me.zipaiche.BackColor = System.Drawing.Color.Yellow
        Me.zipaiche.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.zipaiche.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.zipaiche.Location = New System.Drawing.Point(187, 30)
        Me.zipaiche.Name = "zipaiche"
        Me.zipaiche.Size = New System.Drawing.Size(69, 22)
        Me.zipaiche.TabIndex = 168
        Me.zipaiche.Text = "自派车"
        Me.zipaiche.UseVisualStyleBackColor = False
        '
        'beizhu
        '
        Me.beizhu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.beizhu.Enabled = False
        Me.beizhu.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.beizhu.Location = New System.Drawing.Point(17, 419)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(263, 61)
        Me.beizhu.TabIndex = 159
        Me.beizhu.Text = ""
        '
        'dianhuahaoma
        '
        Me.dianhuahaoma.BackColor = System.Drawing.Color.Yellow
        Me.dianhuahaoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dianhuahaoma.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dianhuahaoma.Location = New System.Drawing.Point(8, 63)
        Me.dianhuahaoma.Name = "dianhuahaoma"
        Me.dianhuahaoma.Size = New System.Drawing.Size(173, 23)
        Me.dianhuahaoma.TabIndex = 158
        Me.dianhuahaoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chehao
        '
        Me.chehao.BackColor = System.Drawing.Color.Yellow
        Me.chehao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chehao.Location = New System.Drawing.Point(8, 30)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(173, 23)
        Me.chehao.TabIndex = 157
        Me.chehao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(129, 445)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 17)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "备注"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "电话号码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "车号"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(326, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 34)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "读取客户名称"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'loading
        '
        Me.loading.AutoSize = True
        Me.loading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loading.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.loading.ForeColor = System.Drawing.Color.Red
        Me.loading.Location = New System.Drawing.Point(341, 465)
        Me.loading.Name = "loading"
        Me.loading.Size = New System.Drawing.Size(118, 19)
        Me.loading.TabIndex = 166
        Me.loading.Text = "数据读取中,请稍后..."
        Me.loading.Visible = False
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(320, 95)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode1.ImageIndex = -2
        TreeNode1.Name = "节点0"
        TreeNode1.Text = "功能选择菜单"
        TreeNode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode2.Name = "节点1"
        TreeNode2.Text = "可登记"
        TreeNode3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode3.Name = "节点4"
        TreeNode3.Text = "已登记"
        TreeNode4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode4.Name = "节点5"
        TreeNode4.Text = "可进厂"
        TreeNode5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode5.Name = "节点0"
        TreeNode5.Text = "已完成"
        TreeNode6.ForeColor = System.Drawing.Color.Red
        TreeNode6.Name = "节点0"
        TreeNode6.Text = "--超时车辆"
        TreeNode7.ForeColor = System.Drawing.Color.Red
        TreeNode7.Name = "节点1"
        TreeNode7.Text = "--退回车辆"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Me.TreeView1.Size = New System.Drawing.Size(167, 463)
        Me.TreeView1.TabIndex = 174
        '
        'idid
        '
        Me.idid.AutoSize = True
        Me.idid.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.idid.Location = New System.Drawing.Point(495, 6)
        Me.idid.Name = "idid"
        Me.idid.Size = New System.Drawing.Size(11, 9)
        Me.idid.TabIndex = 176
        Me.idid.Text = "id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(322, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 25)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "车号查询"
        '
        'chaxun
        '
        Me.chaxun.BackColor = System.Drawing.Color.Red
        Me.chaxun.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chaxun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chaxun.Location = New System.Drawing.Point(320, 48)
        Me.chaxun.Name = "chaxun"
        Me.chaxun.Size = New System.Drawing.Size(167, 39)
        Me.chaxun.TabIndex = 180
        Me.chaxun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button4, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.ToolStrip1.TabIndex = 183
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button4
        '
        Me.Button4.Image = Global._Somesoft.My.Resources.Resources.车号按钮
        Me.Button4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 22)
        Me.Button4.Text = "更新车号信息"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global._Somesoft.My.Resources.Resources.粕
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton2.Text = "粕类数据导入"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global._Somesoft.My.Resources.Resources.卸货
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton3.Text = "卸货信息导入"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global._Somesoft.My.Resources.Resources.油脂
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton4.Text = "油脂信息导入"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global._Somesoft.My.Resources.Resources.化工
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton5.Text = "化工信息导入"
        '
        'isReserved
        '
        Me.isReserved.AutoSize = True
        Me.isReserved.Enabled = False
        Me.isReserved.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.isReserved.ForeColor = System.Drawing.Color.Red
        Me.isReserved.Location = New System.Drawing.Point(21, 32)
        Me.isReserved.Name = "isReserved"
        Me.isReserved.Size = New System.Drawing.Size(63, 21)
        Me.isReserved.TabIndex = 192
        Me.isReserved.Text = "预约否"
        Me.isReserved.UseVisualStyleBackColor = True
        '
        'Reservedtime2
        '
        Me.Reservedtime2.BackColor = System.Drawing.Color.Yellow
        Me.Reservedtime2.Enabled = False
        Me.Reservedtime2.Font = New System.Drawing.Font("微软雅黑 Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Reservedtime2.Location = New System.Drawing.Point(90, 58)
        Me.Reservedtime2.Name = "Reservedtime2"
        Me.Reservedtime2.ReadOnly = True
        Me.Reservedtime2.Size = New System.Drawing.Size(147, 21)
        Me.Reservedtime2.TabIndex = 191
        '
        'Reservedtime1
        '
        Me.Reservedtime1.BackColor = System.Drawing.Color.Yellow
        Me.Reservedtime1.Enabled = False
        Me.Reservedtime1.Font = New System.Drawing.Font("微软雅黑 Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Reservedtime1.Location = New System.Drawing.Point(90, 28)
        Me.Reservedtime1.Name = "Reservedtime1"
        Me.Reservedtime1.ReadOnly = True
        Me.Reservedtime1.Size = New System.Drawing.Size(147, 21)
        Me.Reservedtime1.TabIndex = 190
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "预约时间"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Reservedtime1)
        Me.GroupBox1.Controls.Add(Me.isReserved)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Reservedtime2)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 92)
        Me.GroupBox1.TabIndex = 184
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "预约信息"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.zipaiche)
        Me.GroupBox2.Controls.Add(Me.chehao)
        Me.GroupBox2.Controls.Add(Me.dianhuahaoma)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 101)
        Me.GroupBox2.TabIndex = 184
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "车辆信息"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.pinming)
        Me.GroupBox3.Controls.Add(Me.kehumingcheng)
        Me.GroupBox3.Controls.Add(Me.tidanhao)
        Me.GroupBox3.Controls.Add(Me.shuliang)
        Me.GroupBox3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(17, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 147)
        Me.GroupBox3.TabIndex = 145
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "客户信息"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "提单量"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.Location = New System.Drawing.Point(11, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 17)
        Me.Label25.TabIndex = 185
        Me.Label25.Text = "货物名称"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 183
        Me.Label6.Text = "提单号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "客户名称"
        '
        'pinming
        '
        Me.pinming.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pinming.Enabled = False
        Me.pinming.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pinming.Location = New System.Drawing.Point(8, 57)
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(219, 23)
        Me.pinming.TabIndex = 189
        Me.pinming.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'kehumingcheng
        '
        Me.kehumingcheng.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kehumingcheng.Enabled = False
        Me.kehumingcheng.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kehumingcheng.Location = New System.Drawing.Point(8, 28)
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(219, 23)
        Me.kehumingcheng.TabIndex = 188
        Me.kehumingcheng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tidanhao
        '
        Me.tidanhao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tidanhao.Enabled = False
        Me.tidanhao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tidanhao.Location = New System.Drawing.Point(8, 86)
        Me.tidanhao.Name = "tidanhao"
        Me.tidanhao.Size = New System.Drawing.Size(219, 23)
        Me.tidanhao.TabIndex = 184
        Me.tidanhao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'shuliang
        '
        Me.shuliang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shuliang.Enabled = False
        Me.shuliang.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shuliang.Location = New System.Drawing.Point(8, 114)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(219, 23)
        Me.shuliang.TabIndex = 187
        Me.shuliang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MAOYI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 558)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chaxun)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.idid)
        Me.Controls.Add(Me.loading)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "MAOYI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "可登记数据推送界面"
        Me.Box2.ResumeLayout(False)
        CType(Me.kedengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1.ResumeLayout(False)
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Box2 As System.Windows.Forms.GroupBox
    Friend WithEvents kedengji As System.Windows.Forms.DataGridView
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents beizhu As System.Windows.Forms.RichTextBox
    Friend WithEvents dianhuahaoma As System.Windows.Forms.TextBox
    Friend WithEvents chehao As System.Windows.Forms.TextBox
    Friend WithEvents loading As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents zipaiche As System.Windows.Forms.CheckBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents del As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents idid As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chaxun As System.Windows.Forms.TextBox
    Friend WithEvents force As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 配卡通行ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Button4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Reservedtime1 As System.Windows.Forms.TextBox
    Friend WithEvents isReserved As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Reservedtime2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pinming As System.Windows.Forms.TextBox
    Friend WithEvents kehumingcheng As System.Windows.Forms.TextBox
    Friend WithEvents tidanhao As System.Windows.Forms.TextBox
    Friend WithEvents shuliang As System.Windows.Forms.TextBox
End Class
