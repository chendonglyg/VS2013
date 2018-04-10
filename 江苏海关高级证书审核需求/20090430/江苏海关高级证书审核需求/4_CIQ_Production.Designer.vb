<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIQ_Production
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
        Me.退出界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.HTHT = New System.Windows.Forms.Label()
        Me.Unload_id = New System.Windows.Forms.Label()
        Me.FORSQL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BGBG = New System.Windows.Forms.Label()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.riqi2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ccppm3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ccppm2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.hetonghao = New System.Windows.Forms.TextBox()
        Me.riqi = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chanchukuwei = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ccpsl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ccppm = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.caozuoren = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lingyongshuliang = New System.Windows.Forms.TextBox()
        Me.baoguandanhao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lingyongkuwei = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Receipt_id = New System.Windows.Forms.Label()
        Me.Production_id = New System.Windows.Forms.Label()
        Me.更新所选记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.dgv.Size = New System.Drawing.Size(910, 176)
        Me.dgv.TabIndex = 144
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Location = New System.Drawing.Point(31, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 10)
        Me.GroupBox1.TabIndex = 188
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
        Me.Label4.Location = New System.Drawing.Point(548, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 41)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "生产领用+产出"
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
        Me.dgv2.Location = New System.Drawing.Point(6, 21)
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
        Me.dgv2.Size = New System.Drawing.Size(910, 226)
        Me.dgv2.TabIndex = 144
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.更新所选记录ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(153, 70)
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
        Me.GroupBox3.Location = New System.Drawing.Point(329, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(922, 203)
        Me.GroupBox3.TabIndex = 186
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Unload"
        '
        'GroupBox2
        '
        Me.GroupBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox2.Controls.Add(Me.dgv2)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 253)
        Me.GroupBox2.TabIndex = 185
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Production"
        '
        'HTHT
        '
        Me.HTHT.AutoSize = True
        Me.HTHT.Location = New System.Drawing.Point(29, 9)
        Me.HTHT.Name = "HTHT"
        Me.HTHT.Size = New System.Drawing.Size(17, 12)
        Me.HTHT.TabIndex = 214
        Me.HTHT.Text = "id"
        Me.HTHT.Visible = False
        '
        'Unload_id
        '
        Me.Unload_id.AutoSize = True
        Me.Unload_id.Location = New System.Drawing.Point(83, 24)
        Me.Unload_id.Name = "Unload_id"
        Me.Unload_id.Size = New System.Drawing.Size(17, 12)
        Me.Unload_id.TabIndex = 213
        Me.Unload_id.Text = "id"
        '
        'FORSQL
        '
        Me.FORSQL.BackColor = System.Drawing.Color.Red
        Me.FORSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FORSQL.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FORSQL.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FORSQL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FORSQL.Location = New System.Drawing.Point(479, 64)
        Me.FORSQL.Name = "FORSQL"
        Me.FORSQL.Size = New System.Drawing.Size(157, 29)
        Me.FORSQL.TabIndex = 215
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(378, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 21)
        Me.Label7.TabIndex = 216
        Me.Label7.Text = "检索报关单号"
        '
        'BGBG
        '
        Me.BGBG.AutoSize = True
        Me.BGBG.Location = New System.Drawing.Point(29, 39)
        Me.BGBG.Name = "BGBG"
        Me.BGBG.Size = New System.Drawing.Size(17, 12)
        Me.BGBG.TabIndex = 217
        Me.BGBG.Text = "id"
        Me.BGBG.Visible = False
        '
        'jichuxinxi
        '
        Me.jichuxinxi.ContextMenuStrip = Me.ContextMenuStrip1
        Me.jichuxinxi.Controls.Add(Me.riqi2)
        Me.jichuxinxi.Controls.Add(Me.Label11)
        Me.jichuxinxi.Controls.Add(Me.ccppm3)
        Me.jichuxinxi.Controls.Add(Me.Label10)
        Me.jichuxinxi.Controls.Add(Me.ccppm2)
        Me.jichuxinxi.Controls.Add(Me.Label9)
        Me.jichuxinxi.Controls.Add(Me.hetonghao)
        Me.jichuxinxi.Controls.Add(Me.riqi)
        Me.jichuxinxi.Controls.Add(Me.Label8)
        Me.jichuxinxi.Controls.Add(Me.chanchukuwei)
        Me.jichuxinxi.Controls.Add(Me.Label6)
        Me.jichuxinxi.Controls.Add(Me.ccpsl)
        Me.jichuxinxi.Controls.Add(Me.Label2)
        Me.jichuxinxi.Controls.Add(Me.ccppm)
        Me.jichuxinxi.Controls.Add(Me.Label5)
        Me.jichuxinxi.Controls.Add(Me.caozuoren)
        Me.jichuxinxi.Controls.Add(Me.Label14)
        Me.jichuxinxi.Controls.Add(Me.lingyongshuliang)
        Me.jichuxinxi.Controls.Add(Me.baoguandanhao)
        Me.jichuxinxi.Controls.Add(Me.Label1)
        Me.jichuxinxi.Controls.Add(Me.Label17)
        Me.jichuxinxi.Controls.Add(Me.Label24)
        Me.jichuxinxi.Controls.Add(Me.lingyongkuwei)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(22, 87)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(301, 462)
        Me.jichuxinxi.TabIndex = 218
        Me.jichuxinxi.TabStop = False
        '
        'riqi2
        '
        Me.riqi2.Location = New System.Drawing.Point(108, 429)
        Me.riqi2.Name = "riqi2"
        Me.riqi2.Size = New System.Drawing.Size(175, 29)
        Me.riqi2.TabIndex = 221
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(174, 433)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 21)
        Me.Label11.TabIndex = 222
        Me.Label11.Text = "日期"
        '
        'ccppm3
        '
        Me.ccppm3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ccppm3.ForeColor = System.Drawing.Color.Red
        Me.ccppm3.FormattingEnabled = True
        Me.ccppm3.Items.AddRange(New Object() {"CPS", "色拉油", "豆粕"})
        Me.ccppm3.Location = New System.Drawing.Point(108, 281)
        Me.ccppm3.Name = "ccppm3"
        Me.ccppm3.Size = New System.Drawing.Size(175, 29)
        Me.ccppm3.TabIndex = 219
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(13, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 21)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "产成品品名3"
        '
        'ccppm2
        '
        Me.ccppm2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ccppm2.ForeColor = System.Drawing.Color.Red
        Me.ccppm2.FormattingEnabled = True
        Me.ccppm2.Items.AddRange(New Object() {"CPS", "色拉油", "豆粕"})
        Me.ccppm2.Location = New System.Drawing.Point(108, 249)
        Me.ccppm2.Name = "ccppm2"
        Me.ccppm2.Size = New System.Drawing.Size(175, 29)
        Me.ccppm2.TabIndex = 217
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(13, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 21)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "产成品品名2"
        '
        'hetonghao
        '
        Me.hetonghao.BackColor = System.Drawing.Color.White
        Me.hetonghao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hetonghao.Enabled = False
        Me.hetonghao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hetonghao.ForeColor = System.Drawing.Color.DarkRed
        Me.hetonghao.Location = New System.Drawing.Point(108, 30)
        Me.hetonghao.Name = "hetonghao"
        Me.hetonghao.Size = New System.Drawing.Size(175, 29)
        Me.hetonghao.TabIndex = 216
        '
        'riqi
        '
        Me.riqi.Location = New System.Drawing.Point(108, 394)
        Me.riqi.Name = "riqi"
        Me.riqi.Size = New System.Drawing.Size(175, 29)
        Me.riqi.TabIndex = 214
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(32, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 21)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "日期范围"
        '
        'chanchukuwei
        '
        Me.chanchukuwei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chanchukuwei.ForeColor = System.Drawing.Color.Red
        Me.chanchukuwei.FormattingEnabled = True
        Me.chanchukuwei.Items.AddRange(New Object() {"豆粕筒仓", "4号库", "罐区"})
        Me.chanchukuwei.Location = New System.Drawing.Point(108, 355)
        Me.chanchukuwei.Name = "chanchukuwei"
        Me.chanchukuwei.Size = New System.Drawing.Size(175, 29)
        Me.chanchukuwei.TabIndex = 212
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(32, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 21)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "产出库位"
        '
        'ccpsl
        '
        Me.ccpsl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ccpsl.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccpsl.ForeColor = System.Drawing.Color.Red
        Me.ccpsl.Location = New System.Drawing.Point(108, 320)
        Me.ccpsl.Name = "ccpsl"
        Me.ccpsl.Size = New System.Drawing.Size(78, 29)
        Me.ccpsl.TabIndex = 209
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(16, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "产成品数量"
        '
        'ccppm
        '
        Me.ccppm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ccppm.ForeColor = System.Drawing.Color.Red
        Me.ccppm.FormattingEnabled = True
        Me.ccppm.Items.AddRange(New Object() {"CPS", "色拉油", "豆粕"})
        Me.ccppm.Location = New System.Drawing.Point(108, 217)
        Me.ccppm.Name = "ccppm"
        Me.ccppm.Size = New System.Drawing.Size(175, 29)
        Me.ccppm.TabIndex = 208
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(13, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 21)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "产成品品名1"
        '
        'caozuoren
        '
        Me.caozuoren.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.caozuoren.ForeColor = System.Drawing.Color.Maroon
        Me.caozuoren.FormattingEnabled = True
        Me.caozuoren.Items.AddRange(New Object() {"顾红艳"})
        Me.caozuoren.Location = New System.Drawing.Point(108, 100)
        Me.caozuoren.Name = "caozuoren"
        Me.caozuoren.Size = New System.Drawing.Size(175, 29)
        Me.caozuoren.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(48, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 21)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "操作人"
        '
        'lingyongshuliang
        '
        Me.lingyongshuliang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lingyongshuliang.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lingyongshuliang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lingyongshuliang.Location = New System.Drawing.Point(108, 176)
        Me.lingyongshuliang.Name = "lingyongshuliang"
        Me.lingyongshuliang.Size = New System.Drawing.Size(78, 29)
        Me.lingyongshuliang.TabIndex = 11
        '
        'baoguandanhao
        '
        Me.baoguandanhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.baoguandanhao.Enabled = False
        Me.baoguandanhao.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.baoguandanhao.ForeColor = System.Drawing.Color.Maroon
        Me.baoguandanhao.Location = New System.Drawing.Point(108, 65)
        Me.baoguandanhao.Name = "baoguandanhao"
        Me.baoguandanhao.Size = New System.Drawing.Size(175, 29)
        Me.baoguandanhao.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "领用数量"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(32, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 21)
        Me.Label17.TabIndex = 177
        Me.Label17.Text = "报关单号"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Maroon
        Me.Label24.Location = New System.Drawing.Point(48, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 21)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "合同号"
        '
        'lingyongkuwei
        '
        Me.lingyongkuwei.Enabled = False
        Me.lingyongkuwei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lingyongkuwei.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lingyongkuwei.FormattingEnabled = True
        Me.lingyongkuwei.Location = New System.Drawing.Point(108, 141)
        Me.lingyongkuwei.Name = "lingyongkuwei"
        Me.lingyongkuwei.Size = New System.Drawing.Size(175, 29)
        Me.lingyongkuwei.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "领用库位"
        '
        'Receipt_id
        '
        Me.Receipt_id.AutoSize = True
        Me.Receipt_id.Location = New System.Drawing.Point(29, 24)
        Me.Receipt_id.Name = "Receipt_id"
        Me.Receipt_id.Size = New System.Drawing.Size(17, 12)
        Me.Receipt_id.TabIndex = 219
        Me.Receipt_id.Text = "id"
        '
        'Production_id
        '
        Me.Production_id.AutoSize = True
        Me.Production_id.Location = New System.Drawing.Point(141, 24)
        Me.Production_id.Name = "Production_id"
        Me.Production_id.Size = New System.Drawing.Size(17, 12)
        Me.Production_id.TabIndex = 222
        Me.Production_id.Text = "id"
        '
        '更新所选记录ToolStripMenuItem
        '
        Me.更新所选记录ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.更新所选记录ToolStripMenuItem.Name = "更新所选记录ToolStripMenuItem"
        Me.更新所选记录ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.更新所选记录ToolStripMenuItem.Text = "更新所选记录"
        '
        'CIQ_Production
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Production_id)
        Me.Controls.Add(Me.Receipt_id)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.FORSQL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BGBG)
        Me.Controls.Add(Me.HTHT)
        Me.Controls.Add(Me.Unload_id)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CIQ_Production"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "4.生产领用+产出"
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
    Friend WithEvents Unload_id As System.Windows.Forms.Label
    Friend WithEvents FORSQL As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BGBG As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents ccppm3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ccppm2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hetonghao As System.Windows.Forms.TextBox
    Friend WithEvents riqi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chanchukuwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ccpsl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ccppm As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents caozuoren As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lingyongshuliang As System.Windows.Forms.TextBox
    Friend WithEvents baoguandanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lingyongkuwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Receipt_id As System.Windows.Forms.Label
    Friend WithEvents Production_id As System.Windows.Forms.Label
    Friend WithEvents riqi2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents 更新所选记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
