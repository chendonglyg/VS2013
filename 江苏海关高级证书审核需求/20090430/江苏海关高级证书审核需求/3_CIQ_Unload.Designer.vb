<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIQ_Unload
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.保存记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FORSQL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HTHT = New System.Windows.Forms.Label()
        Me.Receipt_id = New System.Windows.Forms.Label()
        Me.BGBG = New System.Windows.Forms.Label()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.wlmc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hetonghao = New System.Windows.Forms.TextBox()
        Me.cunfangkuwei = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xiechuanriqi = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.caozuoren = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xiechuanshuliang = New System.Windows.Forms.TextBox()
        Me.baoguandanhao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.xiechuankuwei = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Unload_id = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.jichuxinxi.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(6, 20)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(877, 168)
        Me.dgv.TabIndex = 144
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Location = New System.Drawing.Point(30, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 10)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ">>"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存记录ToolStripMenuItem, Me.退出界面ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 48)
        '
        '保存记录ToolStripMenuItem
        '
        Me.保存记录ToolStripMenuItem.Name = "保存记录ToolStripMenuItem"
        Me.保存记录ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.保存记录ToolStripMenuItem.Text = "保存记录"
        '
        '退出界面ToolStripMenuItem
        '
        Me.退出界面ToolStripMenuItem.Name = "退出界面ToolStripMenuItem"
        Me.退出界面ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.退出界面ToolStripMenuItem.Text = "退出界面"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(547, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 41)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "卸船入库"
        '
        'dgv2
        '
        Me.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.ContextMenuStrip = Me.ContextMenuStrip2
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv2.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv2.Location = New System.Drawing.Point(6, 20)
        Me.dgv2.Name = "dgv2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv2.RowHeadersVisible = False
        Me.dgv2.RowTemplate.Height = 23
        Me.dgv2.Size = New System.Drawing.Size(877, 205)
        Me.dgv2.TabIndex = 144
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(153, 48)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "删除所选记录"
        '
        'GroupBox3
        '
        Me.GroupBox3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox3.Controls.Add(Me.dgv)
        Me.GroupBox3.Location = New System.Drawing.Point(363, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(889, 204)
        Me.GroupBox3.TabIndex = 186
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reseipt"
        '
        'GroupBox2
        '
        Me.GroupBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox2.Controls.Add(Me.dgv2)
        Me.GroupBox2.Location = New System.Drawing.Point(363, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(889, 232)
        Me.GroupBox2.TabIndex = 185
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unload"
        '
        'FORSQL
        '
        Me.FORSQL.BackColor = System.Drawing.Color.Red
        Me.FORSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FORSQL.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FORSQL.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FORSQL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FORSQL.Location = New System.Drawing.Point(518, 76)
        Me.FORSQL.Name = "FORSQL"
        Me.FORSQL.Size = New System.Drawing.Size(157, 29)
        Me.FORSQL.TabIndex = 211
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(417, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 21)
        Me.Label5.TabIndex = 212
        Me.Label5.Text = "检索报关单号"
        '
        'HTHT
        '
        Me.HTHT.AutoSize = True
        Me.HTHT.Location = New System.Drawing.Point(28, 2)
        Me.HTHT.Name = "HTHT"
        Me.HTHT.Size = New System.Drawing.Size(17, 12)
        Me.HTHT.TabIndex = 213
        Me.HTHT.Text = "id"
        '
        'Receipt_id
        '
        Me.Receipt_id.AutoSize = True
        Me.Receipt_id.Location = New System.Drawing.Point(28, 18)
        Me.Receipt_id.Name = "Receipt_id"
        Me.Receipt_id.Size = New System.Drawing.Size(17, 12)
        Me.Receipt_id.TabIndex = 212
        Me.Receipt_id.Text = "id"
        '
        'BGBG
        '
        Me.BGBG.AutoSize = True
        Me.BGBG.Location = New System.Drawing.Point(28, 32)
        Me.BGBG.Name = "BGBG"
        Me.BGBG.Size = New System.Drawing.Size(17, 12)
        Me.BGBG.TabIndex = 214
        Me.BGBG.Text = "id"
        '
        'jichuxinxi
        '
        Me.jichuxinxi.ContextMenuStrip = Me.ContextMenuStrip1
        Me.jichuxinxi.Controls.Add(Me.CheckBox1)
        Me.jichuxinxi.Controls.Add(Me.wlmc)
        Me.jichuxinxi.Controls.Add(Me.Label6)
        Me.jichuxinxi.Controls.Add(Me.hetonghao)
        Me.jichuxinxi.Controls.Add(Me.cunfangkuwei)
        Me.jichuxinxi.Controls.Add(Me.Label2)
        Me.jichuxinxi.Controls.Add(Me.xiechuanriqi)
        Me.jichuxinxi.Controls.Add(Me.Label8)
        Me.jichuxinxi.Controls.Add(Me.caozuoren)
        Me.jichuxinxi.Controls.Add(Me.Label14)
        Me.jichuxinxi.Controls.Add(Me.xiechuanshuliang)
        Me.jichuxinxi.Controls.Add(Me.baoguandanhao)
        Me.jichuxinxi.Controls.Add(Me.Label1)
        Me.jichuxinxi.Controls.Add(Me.Label17)
        Me.jichuxinxi.Controls.Add(Me.Label24)
        Me.jichuxinxi.Controls.Add(Me.xiechuankuwei)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(30, 104)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(301, 445)
        Me.jichuxinxi.TabIndex = 215
        Me.jichuxinxi.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(78, 175)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 25)
        Me.CheckBox1.TabIndex = 215
        Me.CheckBox1.Text = "无需加工/直接销售"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'wlmc
        '
        Me.wlmc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.wlmc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.wlmc.FormattingEnabled = True
        Me.wlmc.Items.AddRange(New Object() {"CPS", "棕榈油", "毛豆油", "美国大豆", "巴西大豆", "阿根廷大豆", "橄榄油"})
        Me.wlmc.Location = New System.Drawing.Point(78, 240)
        Me.wlmc.Name = "wlmc"
        Me.wlmc.Size = New System.Drawing.Size(175, 29)
        Me.wlmc.TabIndex = 213
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(5, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 21)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "物料名称"
        '
        'hetonghao
        '
        Me.hetonghao.BackColor = System.Drawing.Color.White
        Me.hetonghao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetonghao.Enabled = False
        Me.hetonghao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetonghao.ForeColor = System.Drawing.Color.DarkRed
        Me.hetonghao.Location = New System.Drawing.Point(78, 36)
        Me.hetonghao.Name = "hetonghao"
        Me.hetonghao.Size = New System.Drawing.Size(175, 29)
        Me.hetonghao.TabIndex = 212
        '
        'cunfangkuwei
        '
        Me.cunfangkuwei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cunfangkuwei.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cunfangkuwei.FormattingEnabled = True
        Me.cunfangkuwei.Items.AddRange(New Object() {"大豆筒仓", "罐区"})
        Me.cunfangkuwei.Location = New System.Drawing.Point(78, 359)
        Me.cunfangkuwei.Name = "cunfangkuwei"
        Me.cunfangkuwei.Size = New System.Drawing.Size(175, 29)
        Me.cunfangkuwei.TabIndex = 209
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "存放库位"
        '
        'xiechuanriqi
        '
        Me.xiechuanriqi.Location = New System.Drawing.Point(78, 318)
        Me.xiechuanriqi.Name = "xiechuanriqi"
        Me.xiechuanriqi.Size = New System.Drawing.Size(175, 29)
        Me.xiechuanriqi.TabIndex = 208
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(2, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 21)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "卸船日期"
        '
        'caozuoren
        '
        Me.caozuoren.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.caozuoren.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.caozuoren.FormattingEnabled = True
        Me.caozuoren.Items.AddRange(New Object() {"顾红艳"})
        Me.caozuoren.Location = New System.Drawing.Point(78, 118)
        Me.caozuoren.Name = "caozuoren"
        Me.caozuoren.Size = New System.Drawing.Size(175, 29)
        Me.caozuoren.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(18, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 21)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "操作人"
        '
        'xiechuanshuliang
        '
        Me.xiechuanshuliang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xiechuanshuliang.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.xiechuanshuliang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xiechuanshuliang.Location = New System.Drawing.Point(78, 273)
        Me.xiechuanshuliang.Name = "xiechuanshuliang"
        Me.xiechuanshuliang.Size = New System.Drawing.Size(78, 29)
        Me.xiechuanshuliang.TabIndex = 11
        '
        'baoguandanhao
        '
        Me.baoguandanhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.baoguandanhao.Enabled = False
        Me.baoguandanhao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.baoguandanhao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.baoguandanhao.Location = New System.Drawing.Point(78, 74)
        Me.baoguandanhao.Name = "baoguandanhao"
        Me.baoguandanhao.Size = New System.Drawing.Size(175, 29)
        Me.baoguandanhao.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "卸船数量"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(5, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 21)
        Me.Label17.TabIndex = 177
        Me.Label17.Text = "报关单号"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(18, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 21)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "合同号"
        '
        'xiechuankuwei
        '
        Me.xiechuankuwei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.xiechuankuwei.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xiechuankuwei.FormattingEnabled = True
        Me.xiechuankuwei.Items.AddRange(New Object() {"船库", "63#", "64#"})
        Me.xiechuankuwei.Location = New System.Drawing.Point(78, 206)
        Me.xiechuankuwei.Name = "xiechuankuwei"
        Me.xiechuankuwei.Size = New System.Drawing.Size(175, 29)
        Me.xiechuankuwei.TabIndex = 3
        Me.xiechuankuwei.Text = "船库"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "卸船库位"
        '
        'Unload_id
        '
        Me.Unload_id.AutoSize = True
        Me.Unload_id.Location = New System.Drawing.Point(89, 18)
        Me.Unload_id.Name = "Unload_id"
        Me.Unload_id.Size = New System.Drawing.Size(17, 12)
        Me.Unload_id.TabIndex = 216
        Me.Unload_id.Text = "id"
        '
        'CIQ_Unload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Unload_id)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.BGBG)
        Me.Controls.Add(Me.HTHT)
        Me.Controls.Add(Me.Receipt_id)
        Me.Controls.Add(Me.FORSQL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CIQ_Unload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3.卸船入库"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORSQL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents HTHT As System.Windows.Forms.Label
    Friend WithEvents Receipt_id As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BGBG As System.Windows.Forms.Label
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents wlmc As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hetonghao As System.Windows.Forms.TextBox
    Friend WithEvents cunfangkuwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xiechuanriqi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents caozuoren As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents xiechuanshuliang As System.Windows.Forms.TextBox
    Friend WithEvents baoguandanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents xiechuankuwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Unload_id As System.Windows.Forms.Label
End Class
