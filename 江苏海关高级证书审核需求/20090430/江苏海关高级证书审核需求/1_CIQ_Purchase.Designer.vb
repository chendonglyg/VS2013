<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIQ_Purchase
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.hetonghao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.huopin = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.重置界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除合同ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.yunshufangshi = New System.Windows.Forms.ComboBox()
        Me.danwei = New System.Windows.Forms.ComboBox()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.caozuoren = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chuanming = New System.Windows.Forms.ComboBox()
        Me.wuliaohao = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gongyingshang = New System.Windows.Forms.ComboBox()
        Me.zhifufangshi = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.hetongdanjiarmb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.hetongdanjiameiyuan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.yiduanzhuang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hetongriqi = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.hetongshuliang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guobie = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.idid = New System.Windows.Forms.Label()
        Me.htht = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.jichuxinxi.SuspendLayout()
        Me.SuspendLayout()
        '
        'hetonghao
        '
        Me.hetonghao.BackColor = System.Drawing.Color.Red
        Me.hetonghao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetonghao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetonghao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.hetonghao.Location = New System.Drawing.Point(109, 68)
        Me.hetonghao.Name = "hetonghao"
        Me.hetonghao.Size = New System.Drawing.Size(157, 29)
        Me.hetonghao.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(536, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "运输方式"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(52, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 21)
        Me.Label17.TabIndex = 164
        Me.Label17.Text = "合同号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(34, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "货品"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(636, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 41)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "采购原料"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(783, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "支付方式"
        '
        'huopin
        '
        Me.huopin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.huopin.ForeColor = System.Drawing.Color.Teal
        Me.huopin.FormattingEnabled = True
        Me.huopin.Items.AddRange(New Object() {"大豆", "棕榈油", "橄榄油"})
        Me.huopin.Location = New System.Drawing.Point(78, 70)
        Me.huopin.Name = "huopin"
        Me.huopin.Size = New System.Drawing.Size(175, 29)
        Me.huopin.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1221, 242)
        Me.GroupBox2.TabIndex = 168
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "数据浏览区"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.重置界面ToolStripMenuItem, Me.保存记录ToolStripMenuItem, Me.退出界面ToolStripMenuItem, Me.删除合同ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 92)
        '
        '重置界面ToolStripMenuItem
        '
        Me.重置界面ToolStripMenuItem.Name = "重置界面ToolStripMenuItem"
        Me.重置界面ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.重置界面ToolStripMenuItem.Text = "重置界面"
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
        '删除合同ToolStripMenuItem
        '
        Me.删除合同ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.删除合同ToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.删除合同ToolStripMenuItem.Name = "删除合同ToolStripMenuItem"
        Me.删除合同ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.删除合同ToolStripMenuItem.Text = "删除合同"
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
        Me.dgv.Location = New System.Drawing.Point(19, 32)
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
        Me.dgv.Size = New System.Drawing.Size(1186, 195)
        Me.dgv.TabIndex = 144
        '
        'yunshufangshi
        '
        Me.yunshufangshi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.yunshufangshi.ForeColor = System.Drawing.Color.Teal
        Me.yunshufangshi.FormattingEnabled = True
        Me.yunshufangshi.Items.AddRange(New Object() {"船运", "汽运", "铁路"})
        Me.yunshufangshi.Location = New System.Drawing.Point(611, 75)
        Me.yunshufangshi.Name = "yunshufangshi"
        Me.yunshufangshi.Size = New System.Drawing.Size(158, 29)
        Me.yunshufangshi.TabIndex = 7
        '
        'danwei
        '
        Me.danwei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.danwei.ForeColor = System.Drawing.Color.Teal
        Me.danwei.FormattingEnabled = True
        Me.danwei.Items.AddRange(New Object() {"吨", "袋", "仓"})
        Me.danwei.Location = New System.Drawing.Point(611, 28)
        Me.danwei.Name = "danwei"
        Me.danwei.Size = New System.Drawing.Size(158, 29)
        Me.danwei.TabIndex = 6
        '
        'jichuxinxi
        '
        Me.jichuxinxi.ContextMenuStrip = Me.ContextMenuStrip1
        Me.jichuxinxi.Controls.Add(Me.Label15)
        Me.jichuxinxi.Controls.Add(Me.caozuoren)
        Me.jichuxinxi.Controls.Add(Me.Label14)
        Me.jichuxinxi.Controls.Add(Me.Label12)
        Me.jichuxinxi.Controls.Add(Me.chuanming)
        Me.jichuxinxi.Controls.Add(Me.wuliaohao)
        Me.jichuxinxi.Controls.Add(Me.Label13)
        Me.jichuxinxi.Controls.Add(Me.gongyingshang)
        Me.jichuxinxi.Controls.Add(Me.zhifufangshi)
        Me.jichuxinxi.Controls.Add(Me.Label10)
        Me.jichuxinxi.Controls.Add(Me.Label11)
        Me.jichuxinxi.Controls.Add(Me.hetongdanjiarmb)
        Me.jichuxinxi.Controls.Add(Me.Label9)
        Me.jichuxinxi.Controls.Add(Me.hetongdanjiameiyuan)
        Me.jichuxinxi.Controls.Add(Me.Label7)
        Me.jichuxinxi.Controls.Add(Me.yiduanzhuang)
        Me.jichuxinxi.Controls.Add(Me.Label6)
        Me.jichuxinxi.Controls.Add(Me.hetongriqi)
        Me.jichuxinxi.Controls.Add(Me.Label8)
        Me.jichuxinxi.Controls.Add(Me.hetongshuliang)
        Me.jichuxinxi.Controls.Add(Me.Label1)
        Me.jichuxinxi.Controls.Add(Me.guobie)
        Me.jichuxinxi.Controls.Add(Me.Label24)
        Me.jichuxinxi.Controls.Add(Me.yunshufangshi)
        Me.jichuxinxi.Controls.Add(Me.danwei)
        Me.jichuxinxi.Controls.Add(Me.huopin)
        Me.jichuxinxi.Controls.Add(Me.Label5)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Controls.Add(Me.Label2)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(31, 91)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(1221, 208)
        Me.jichuxinxi.TabIndex = 166
        Me.jichuxinxi.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(130, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 21)
        Me.Label15.TabIndex = 208
        Me.Label15.Text = "%"
        '
        'caozuoren
        '
        Me.caozuoren.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.caozuoren.ForeColor = System.Drawing.Color.Blue
        Me.caozuoren.FormattingEnabled = True
        Me.caozuoren.Items.AddRange(New Object() {"顾红艳"})
        Me.caozuoren.Location = New System.Drawing.Point(611, 166)
        Me.caozuoren.Name = "caozuoren"
        Me.caozuoren.Size = New System.Drawing.Size(158, 29)
        Me.caozuoren.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(551, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 21)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "操作人"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(295, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 21)
        Me.Label12.TabIndex = 205
        Me.Label12.Text = "物料号"
        '
        'chuanming
        '
        Me.chuanming.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chuanming.ForeColor = System.Drawing.Color.Teal
        Me.chuanming.FormattingEnabled = True
        Me.chuanming.Location = New System.Drawing.Point(355, 75)
        Me.chuanming.Name = "chuanming"
        Me.chuanming.Size = New System.Drawing.Size(158, 29)
        Me.chuanming.TabIndex = 5
        '
        'wuliaohao
        '
        Me.wuliaohao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.wuliaohao.ForeColor = System.Drawing.Color.Teal
        Me.wuliaohao.FormattingEnabled = True
        Me.wuliaohao.Location = New System.Drawing.Point(355, 28)
        Me.wuliaohao.Name = "wuliaohao"
        Me.wuliaohao.Size = New System.Drawing.Size(158, 29)
        Me.wuliaohao.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(307, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 21)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "船名"
        '
        'gongyingshang
        '
        Me.gongyingshang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gongyingshang.ForeColor = System.Drawing.Color.Teal
        Me.gongyingshang.FormattingEnabled = True
        Me.gongyingshang.Location = New System.Drawing.Point(863, 75)
        Me.gongyingshang.Name = "gongyingshang"
        Me.gongyingshang.Size = New System.Drawing.Size(275, 29)
        Me.gongyingshang.TabIndex = 9
        '
        'zhifufangshi
        '
        Me.zhifufangshi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.zhifufangshi.ForeColor = System.Drawing.Color.Teal
        Me.zhifufangshi.FormattingEnabled = True
        Me.zhifufangshi.Items.AddRange(New Object() {"DA", "DP", "信用证", "电汇", "承兑汇票"})
        Me.zhifufangshi.Location = New System.Drawing.Point(863, 28)
        Me.zhifufangshi.Name = "zhifufangshi"
        Me.zhifufangshi.Size = New System.Drawing.Size(210, 29)
        Me.zhifufangshi.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(794, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 21)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "供应商 "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(564, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 21)
        Me.Label11.TabIndex = 200
        Me.Label11.Text = "单位"
        '
        'hetongdanjiarmb
        '
        Me.hetongdanjiarmb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetongdanjiarmb.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetongdanjiarmb.ForeColor = System.Drawing.Color.Red
        Me.hetongdanjiarmb.Location = New System.Drawing.Point(275, 164)
        Me.hetongdanjiarmb.Name = "hetongdanjiarmb"
        Me.hetongdanjiarmb.Size = New System.Drawing.Size(78, 29)
        Me.hetongdanjiarmb.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(184, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 21)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "合同单价(¥)"
        '
        'hetongdanjiameiyuan
        '
        Me.hetongdanjiameiyuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetongdanjiameiyuan.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetongdanjiameiyuan.ForeColor = System.Drawing.Color.Red
        Me.hetongdanjiameiyuan.Location = New System.Drawing.Point(275, 129)
        Me.hetongdanjiameiyuan.Name = "hetongdanjiameiyuan"
        Me.hetongdanjiameiyuan.Size = New System.Drawing.Size(78, 29)
        Me.hetongdanjiameiyuan.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(182, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 21)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "合同单价($)"
        '
        'yiduanzhuang
        '
        Me.yiduanzhuang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.yiduanzhuang.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yiduanzhuang.ForeColor = System.Drawing.Color.Red
        Me.yiduanzhuang.Location = New System.Drawing.Point(78, 166)
        Me.yiduanzhuang.Name = "yiduanzhuang"
        Me.yiduanzhuang.Size = New System.Drawing.Size(78, 29)
        Me.yiduanzhuang.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(18, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 192
        Me.Label6.Text = "溢短装"
        '
        'hetongriqi
        '
        Me.hetongriqi.Enabled = False
        Me.hetongriqi.Location = New System.Drawing.Point(611, 125)
        Me.hetongriqi.Name = "hetongriqi"
        Me.hetongriqi.Size = New System.Drawing.Size(175, 29)
        Me.hetongriqi.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(535, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 21)
        Me.Label8.TabIndex = 191
        Me.Label8.Text = "合同日期"
        '
        'hetongshuliang
        '
        Me.hetongshuliang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetongshuliang.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetongshuliang.ForeColor = System.Drawing.Color.Red
        Me.hetongshuliang.Location = New System.Drawing.Point(78, 131)
        Me.hetongshuliang.Name = "hetongshuliang"
        Me.hetongshuliang.Size = New System.Drawing.Size(78, 29)
        Me.hetongshuliang.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "合同数量"
        '
        'guobie
        '
        Me.guobie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.guobie.ForeColor = System.Drawing.Color.Teal
        Me.guobie.FormattingEnabled = True
        Me.guobie.Items.AddRange(New Object() {"美国", "阿根廷", "巴西", "中国"})
        Me.guobie.Location = New System.Drawing.Point(78, 30)
        Me.guobie.Name = "guobie"
        Me.guobie.Size = New System.Drawing.Size(175, 29)
        Me.guobie.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Teal
        Me.Label24.Location = New System.Drawing.Point(34, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 21)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "国别"
        '
        'idid
        '
        Me.idid.AutoSize = True
        Me.idid.Location = New System.Drawing.Point(12, 19)
        Me.idid.Name = "idid"
        Me.idid.Size = New System.Drawing.Size(17, 12)
        Me.idid.TabIndex = 174
        Me.idid.Text = "id"
        '
        'htht
        '
        Me.htht.AutoSize = True
        Me.htht.Location = New System.Drawing.Point(12, 31)
        Me.htht.Name = "htht"
        Me.htht.Size = New System.Drawing.Size(17, 12)
        Me.htht.TabIndex = 175
        Me.htht.Text = "ht"
        '
        'CIQ_Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.htht)
        Me.Controls.Add(Me.hetonghao)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.idid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CIQ_Purchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hetonghao As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents huopin As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents yunshufangshi As System.Windows.Forms.ComboBox
    Friend WithEvents danwei As System.Windows.Forms.ComboBox
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents guobie As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents idid As System.Windows.Forms.Label
    Friend WithEvents hetongshuliang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hetongdanjiarmb As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hetongdanjiameiyuan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents yiduanzhuang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hetongriqi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents caozuoren As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chuanming As System.Windows.Forms.ComboBox
    Friend WithEvents wuliaohao As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gongyingshang As System.Windows.Forms.ComboBox
    Friend WithEvents zhifufangshi As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重置界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除合同ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents htht As System.Windows.Forms.Label
End Class
