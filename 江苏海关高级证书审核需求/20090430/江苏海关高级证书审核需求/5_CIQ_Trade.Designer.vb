<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIQ_Trade
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
        Me.批量导入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.HTHT = New System.Windows.Forms.Label()
        Me.Receipt_id = New System.Windows.Forms.Label()
        Me.FORSQL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bgbg = New System.Windows.Forms.Label()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.lingyongkuwei = New System.Windows.Forms.TextBox()
        Me.cunfangkuwei = New System.Windows.Forms.TextBox()
        Me.zhongliang = New System.Windows.Forms.TextBox()
        Me.zhonglianglabel = New System.Windows.Forms.Label()
        Me.chechuanhao = New System.Windows.Forms.ComboBox()
        Me.hetonghao = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pinming = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kehumingcheng = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xstdh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.riqi = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xshth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.jianshu = New System.Windows.Forms.TextBox()
        Me.baoguandanhao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Unload_id = New System.Windows.Forms.Label()
        Me.Production_id = New System.Windows.Forms.Label()
        Me.Trade_id = New System.Windows.Forms.Label()
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
        Me.dgv.Location = New System.Drawing.Point(6, 21)
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
        Me.dgv.Size = New System.Drawing.Size(905, 183)
        Me.dgv.TabIndex = 144
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Location = New System.Drawing.Point(31, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 10)
        Me.GroupBox1.TabIndex = 188
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ">>"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存记录ToolStripMenuItem, Me.批量导入ToolStripMenuItem, Me.退出界面ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 70)
        '
        '保存记录ToolStripMenuItem
        '
        Me.保存记录ToolStripMenuItem.Name = "保存记录ToolStripMenuItem"
        Me.保存记录ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.保存记录ToolStripMenuItem.Text = "保存记录"
        '
        '批量导入ToolStripMenuItem
        '
        Me.批量导入ToolStripMenuItem.Name = "批量导入ToolStripMenuItem"
        Me.批量导入ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.批量导入ToolStripMenuItem.Text = "批量导入"
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
        Me.Label4.Location = New System.Drawing.Point(548, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 41)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "贸易出库"
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
        Me.dgv2.Location = New System.Drawing.Point(6, 17)
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
        Me.dgv2.Size = New System.Drawing.Size(905, 225)
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
        Me.GroupBox3.Location = New System.Drawing.Point(334, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(918, 212)
        Me.GroupBox3.TabIndex = 186
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Production"
        '
        'GroupBox2
        '
        Me.GroupBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox2.Controls.Add(Me.dgv2)
        Me.GroupBox2.Location = New System.Drawing.Point(334, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(917, 252)
        Me.GroupBox2.TabIndex = 185
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trade"
        '
        'HTHT
        '
        Me.HTHT.AutoSize = True
        Me.HTHT.Location = New System.Drawing.Point(12, 2)
        Me.HTHT.Name = "HTHT"
        Me.HTHT.Size = New System.Drawing.Size(17, 12)
        Me.HTHT.TabIndex = 214
        Me.HTHT.Text = "id"
        Me.HTHT.Visible = False
        '
        'Receipt_id
        '
        Me.Receipt_id.AutoSize = True
        Me.Receipt_id.Location = New System.Drawing.Point(12, 16)
        Me.Receipt_id.Name = "Receipt_id"
        Me.Receipt_id.Size = New System.Drawing.Size(17, 12)
        Me.Receipt_id.TabIndex = 213
        Me.Receipt_id.Text = "id"
        '
        'FORSQL
        '
        Me.FORSQL.BackColor = System.Drawing.Color.Red
        Me.FORSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FORSQL.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FORSQL.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FORSQL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FORSQL.Location = New System.Drawing.Point(619, 59)
        Me.FORSQL.Name = "FORSQL"
        Me.FORSQL.Size = New System.Drawing.Size(239, 29)
        Me.FORSQL.TabIndex = 217
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(518, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 21)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "检索报关单号"
        '
        'bgbg
        '
        Me.bgbg.AutoSize = True
        Me.bgbg.Location = New System.Drawing.Point(12, 29)
        Me.bgbg.Name = "bgbg"
        Me.bgbg.Size = New System.Drawing.Size(17, 12)
        Me.bgbg.TabIndex = 218
        Me.bgbg.Text = "id"
        Me.bgbg.Visible = False
        '
        'jichuxinxi
        '
        Me.jichuxinxi.ContextMenuStrip = Me.ContextMenuStrip1
        Me.jichuxinxi.Controls.Add(Me.lingyongkuwei)
        Me.jichuxinxi.Controls.Add(Me.cunfangkuwei)
        Me.jichuxinxi.Controls.Add(Me.zhongliang)
        Me.jichuxinxi.Controls.Add(Me.zhonglianglabel)
        Me.jichuxinxi.Controls.Add(Me.chechuanhao)
        Me.jichuxinxi.Controls.Add(Me.hetonghao)
        Me.jichuxinxi.Controls.Add(Me.Label9)
        Me.jichuxinxi.Controls.Add(Me.pinming)
        Me.jichuxinxi.Controls.Add(Me.Label7)
        Me.jichuxinxi.Controls.Add(Me.kehumingcheng)
        Me.jichuxinxi.Controls.Add(Me.Label6)
        Me.jichuxinxi.Controls.Add(Me.xstdh)
        Me.jichuxinxi.Controls.Add(Me.Label5)
        Me.jichuxinxi.Controls.Add(Me.riqi)
        Me.jichuxinxi.Controls.Add(Me.Label8)
        Me.jichuxinxi.Controls.Add(Me.xshth)
        Me.jichuxinxi.Controls.Add(Me.Label2)
        Me.jichuxinxi.Controls.Add(Me.Label14)
        Me.jichuxinxi.Controls.Add(Me.jianshu)
        Me.jichuxinxi.Controls.Add(Me.baoguandanhao)
        Me.jichuxinxi.Controls.Add(Me.Label1)
        Me.jichuxinxi.Controls.Add(Me.Label17)
        Me.jichuxinxi.Controls.Add(Me.Label24)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(14, 73)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(301, 461)
        Me.jichuxinxi.TabIndex = 219
        Me.jichuxinxi.TabStop = False
        '
        'lingyongkuwei
        '
        Me.lingyongkuwei.BackColor = System.Drawing.SystemColors.Control
        Me.lingyongkuwei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lingyongkuwei.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lingyongkuwei.ForeColor = System.Drawing.Color.DarkRed
        Me.lingyongkuwei.Location = New System.Drawing.Point(116, 109)
        Me.lingyongkuwei.Name = "lingyongkuwei"
        Me.lingyongkuwei.ReadOnly = True
        Me.lingyongkuwei.Size = New System.Drawing.Size(175, 29)
        Me.lingyongkuwei.TabIndex = 231
        '
        'cunfangkuwei
        '
        Me.cunfangkuwei.BackColor = System.Drawing.SystemColors.Control
        Me.cunfangkuwei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cunfangkuwei.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cunfangkuwei.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cunfangkuwei.Location = New System.Drawing.Point(116, 151)
        Me.cunfangkuwei.Name = "cunfangkuwei"
        Me.cunfangkuwei.ReadOnly = True
        Me.cunfangkuwei.Size = New System.Drawing.Size(175, 29)
        Me.cunfangkuwei.TabIndex = 230
        '
        'zhongliang
        '
        Me.zhongliang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.zhongliang.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.zhongliang.ForeColor = System.Drawing.Color.Teal
        Me.zhongliang.Location = New System.Drawing.Point(230, 343)
        Me.zhongliang.Name = "zhongliang"
        Me.zhongliang.Size = New System.Drawing.Size(61, 29)
        Me.zhongliang.TabIndex = 228
        '
        'zhonglianglabel
        '
        Me.zhonglianglabel.AutoSize = True
        Me.zhonglianglabel.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.zhonglianglabel.ForeColor = System.Drawing.Color.Teal
        Me.zhonglianglabel.Location = New System.Drawing.Point(182, 345)
        Me.zhonglianglabel.Name = "zhonglianglabel"
        Me.zhonglianglabel.Size = New System.Drawing.Size(42, 21)
        Me.zhonglianglabel.TabIndex = 229
        Me.zhonglianglabel.Text = "重量"
        '
        'chechuanhao
        '
        Me.chechuanhao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chechuanhao.ForeColor = System.Drawing.Color.Teal
        Me.chechuanhao.FormattingEnabled = True
        Me.chechuanhao.Location = New System.Drawing.Point(116, 413)
        Me.chechuanhao.Name = "chechuanhao"
        Me.chechuanhao.Size = New System.Drawing.Size(175, 29)
        Me.chechuanhao.TabIndex = 227
        '
        'hetonghao
        '
        Me.hetonghao.BackColor = System.Drawing.SystemColors.Control
        Me.hetonghao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetonghao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetonghao.ForeColor = System.Drawing.Color.DarkRed
        Me.hetonghao.Location = New System.Drawing.Point(116, 28)
        Me.hetonghao.Name = "hetonghao"
        Me.hetonghao.ReadOnly = True
        Me.hetonghao.Size = New System.Drawing.Size(175, 29)
        Me.hetonghao.TabIndex = 226
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(51, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 21)
        Me.Label9.TabIndex = 225
        Me.Label9.Text = "车船号"
        '
        'pinming
        '
        Me.pinming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.pinming.Enabled = False
        Me.pinming.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pinming.ForeColor = System.Drawing.Color.Teal
        Me.pinming.FormattingEnabled = True
        Me.pinming.Location = New System.Drawing.Point(116, 378)
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(175, 29)
        Me.pinming.TabIndex = 222
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(68, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 21)
        Me.Label7.TabIndex = 223
        Me.Label7.Text = "品名"
        '
        'kehumingcheng
        '
        Me.kehumingcheng.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.kehumingcheng.ForeColor = System.Drawing.Color.Teal
        Me.kehumingcheng.FormattingEnabled = True
        Me.kehumingcheng.Location = New System.Drawing.Point(116, 305)
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(175, 29)
        Me.kehumingcheng.TabIndex = 220
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(36, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 21)
        Me.Label6.TabIndex = 221
        Me.Label6.Text = "客户名称"
        '
        'xstdh
        '
        Me.xstdh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xstdh.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.xstdh.ForeColor = System.Drawing.Color.Teal
        Me.xstdh.Location = New System.Drawing.Point(116, 270)
        Me.xstdh.Name = "xstdh"
        Me.xstdh.Size = New System.Drawing.Size(175, 29)
        Me.xstdh.TabIndex = 218
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(20, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 219
        Me.Label5.Text = "销售提单号"
        '
        'riqi
        '
        Me.riqi.Enabled = False
        Me.riqi.Location = New System.Drawing.Point(116, 235)
        Me.riqi.Name = "riqi"
        Me.riqi.Size = New System.Drawing.Size(175, 29)
        Me.riqi.TabIndex = 216
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(68, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 21)
        Me.Label8.TabIndex = 217
        Me.Label8.Text = "日期"
        '
        'xshth
        '
        Me.xshth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xshth.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.xshth.ForeColor = System.Drawing.Color.Teal
        Me.xshth.Location = New System.Drawing.Point(116, 200)
        Me.xshth.Name = "xshth"
        Me.xshth.Size = New System.Drawing.Size(175, 29)
        Me.xshth.TabIndex = 208
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(20, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "销售合同号"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(10, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 21)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "原料领用库位"
        '
        'jianshu
        '
        Me.jianshu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jianshu.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jianshu.ForeColor = System.Drawing.Color.Teal
        Me.jianshu.Location = New System.Drawing.Point(116, 343)
        Me.jianshu.Name = "jianshu"
        Me.jianshu.Size = New System.Drawing.Size(61, 29)
        Me.jianshu.TabIndex = 11
        '
        'baoguandanhao
        '
        Me.baoguandanhao.BackColor = System.Drawing.SystemColors.Control
        Me.baoguandanhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.baoguandanhao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.baoguandanhao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.baoguandanhao.Location = New System.Drawing.Point(116, 70)
        Me.baoguandanhao.Name = "baoguandanhao"
        Me.baoguandanhao.ReadOnly = True
        Me.baoguandanhao.Size = New System.Drawing.Size(175, 29)
        Me.baoguandanhao.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(68, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "件数"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(10, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 21)
        Me.Label17.TabIndex = 177
        Me.Label17.Text = "原料报关单号"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(26, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 21)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "原料合同号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "产品存放库位"
        '
        'Unload_id
        '
        Me.Unload_id.AutoSize = True
        Me.Unload_id.Location = New System.Drawing.Point(67, 16)
        Me.Unload_id.Name = "Unload_id"
        Me.Unload_id.Size = New System.Drawing.Size(17, 12)
        Me.Unload_id.TabIndex = 220
        Me.Unload_id.Text = "id"
        '
        'Production_id
        '
        Me.Production_id.AutoSize = True
        Me.Production_id.Location = New System.Drawing.Point(128, 16)
        Me.Production_id.Name = "Production_id"
        Me.Production_id.Size = New System.Drawing.Size(17, 12)
        Me.Production_id.TabIndex = 221
        Me.Production_id.Text = "id"
        '
        'Trade_id
        '
        Me.Trade_id.AutoSize = True
        Me.Trade_id.Location = New System.Drawing.Point(183, 16)
        Me.Trade_id.Name = "Trade_id"
        Me.Trade_id.Size = New System.Drawing.Size(17, 12)
        Me.Trade_id.TabIndex = 222
        Me.Trade_id.Text = "id"
        '
        'CIQ_Trade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Trade_id)
        Me.Controls.Add(Me.Production_id)
        Me.Controls.Add(Me.Unload_id)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bgbg)
        Me.Controls.Add(Me.FORSQL)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.HTHT)
        Me.Controls.Add(Me.Receipt_id)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CIQ_Trade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "5.出库"
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
    Friend WithEvents HTHT As System.Windows.Forms.Label
    Friend WithEvents Receipt_id As System.Windows.Forms.Label
    Friend WithEvents FORSQL As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bgbg As System.Windows.Forms.Label
    Friend WithEvents 批量导入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents lingyongkuwei As System.Windows.Forms.TextBox
    Friend WithEvents cunfangkuwei As System.Windows.Forms.TextBox
    Friend WithEvents zhongliang As System.Windows.Forms.TextBox
    Friend WithEvents zhonglianglabel As System.Windows.Forms.Label
    Friend WithEvents chechuanhao As System.Windows.Forms.ComboBox
    Friend WithEvents hetonghao As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pinming As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents kehumingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xstdh As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents riqi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents xshth As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents jianshu As System.Windows.Forms.TextBox
    Friend WithEvents baoguandanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Unload_id As System.Windows.Forms.Label
    Friend WithEvents Production_id As System.Windows.Forms.Label
    Friend WithEvents Trade_id As System.Windows.Forms.Label
End Class
