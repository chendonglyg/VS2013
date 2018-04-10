<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEMP5
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.opd = New System.Windows.Forms.OpenFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.luru = New System.Windows.Forms.GroupBox
        Me.fujianleixing = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.zichanyuanzhi = New System.Windows.Forms.TextBox
        Me.dt1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.shuliang = New System.Windows.Forms.TextBox
        Me.beizhu = New System.Windows.Forms.TextBox
        Me.shiyongbumen = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.zichanfenlei = New System.Windows.Forms.ComboBox
        Me.piaohaol = New System.Windows.Forms.Label
        Me.fapiaoshuliang = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.shiyongnianxian = New System.Windows.Forms.ComboBox
        Me.boweil = New System.Windows.Forms.Label
        Me.tidanhaol = New System.Windows.Forms.Label
        Me.zichanhao = New System.Windows.Forms.ComboBox
        Me.huowuliuxiangl = New System.Windows.Forms.Label
        Me.fujianshuliang = New System.Windows.Forms.ComboBox
        Me.chuanmingl = New System.Windows.Forms.Label
        Me.shiyongzhuangtai = New System.Windows.Forms.ComboBox
        Me.fahuodanweil = New System.Windows.Forms.Label
        Me.gongsimingcheng = New System.Windows.Forms.ComboBox
        Me.shenqingdanweil = New System.Windows.Forms.Label
        Me.guigexinghao = New System.Windows.Forms.ComboBox
        Me.guigel = New System.Windows.Forms.Label
        Me.zichanmingcheng = New System.Windows.Forms.ComboBox
        Me.huowumingl = New System.Windows.Forms.Label
        Me.baojianhaol = New System.Windows.Forms.Label
        Me.afcehao = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ID = New System.Windows.Forms.Label
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.资产调拨ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.资产报废ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.资产调拨纪录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.luru.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(500, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "资产调拨与报废"
        '
        'DGV
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Location = New System.Drawing.Point(30, 332)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Size = New System.Drawing.Size(1218, 320)
        Me.DGV.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.资产调拨ToolStripMenuItem, Me.资产报废ToolStripMenuItem, Me.资产调拨纪录ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 92)
        '
        'luru
        '
        Me.luru.Controls.Add(Me.fujianleixing)
        Me.luru.Controls.Add(Me.Label5)
        Me.luru.Controls.Add(Me.zichanyuanzhi)
        Me.luru.Controls.Add(Me.dt1)
        Me.luru.Controls.Add(Me.Label4)
        Me.luru.Controls.Add(Me.shuliang)
        Me.luru.Controls.Add(Me.beizhu)
        Me.luru.Controls.Add(Me.shiyongbumen)
        Me.luru.Controls.Add(Me.Label3)
        Me.luru.Controls.Add(Me.Label9)
        Me.luru.Controls.Add(Me.zichanfenlei)
        Me.luru.Controls.Add(Me.piaohaol)
        Me.luru.Controls.Add(Me.fapiaoshuliang)
        Me.luru.Controls.Add(Me.Label21)
        Me.luru.Controls.Add(Me.shiyongnianxian)
        Me.luru.Controls.Add(Me.boweil)
        Me.luru.Controls.Add(Me.tidanhaol)
        Me.luru.Controls.Add(Me.zichanhao)
        Me.luru.Controls.Add(Me.huowuliuxiangl)
        Me.luru.Controls.Add(Me.fujianshuliang)
        Me.luru.Controls.Add(Me.chuanmingl)
        Me.luru.Controls.Add(Me.shiyongzhuangtai)
        Me.luru.Controls.Add(Me.fahuodanweil)
        Me.luru.Controls.Add(Me.gongsimingcheng)
        Me.luru.Controls.Add(Me.shenqingdanweil)
        Me.luru.Controls.Add(Me.guigexinghao)
        Me.luru.Controls.Add(Me.guigel)
        Me.luru.Controls.Add(Me.zichanmingcheng)
        Me.luru.Controls.Add(Me.huowumingl)
        Me.luru.Controls.Add(Me.baojianhaol)
        Me.luru.Controls.Add(Me.afcehao)
        Me.luru.Controls.Add(Me.Label2)
        Me.luru.Enabled = False
        Me.luru.Location = New System.Drawing.Point(30, 135)
        Me.luru.Name = "luru"
        Me.luru.Size = New System.Drawing.Size(1218, 168)
        Me.luru.TabIndex = 154
        Me.luru.TabStop = False
        Me.luru.Text = "填写区"
        '
        'fujianleixing
        '
        Me.fujianleixing.FormattingEnabled = True
        Me.fujianleixing.Items.AddRange(New Object() {"AFCE申请", "合同", "发票", "PDF综合"})
        Me.fujianleixing.Location = New System.Drawing.Point(897, 70)
        Me.fujianleixing.Name = "fujianleixing"
        Me.fujianleixing.Size = New System.Drawing.Size(114, 21)
        Me.fujianleixing.TabIndex = 157
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(841, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "附件类型"
        '
        'zichanyuanzhi
        '
        Me.zichanyuanzhi.Location = New System.Drawing.Point(687, 104)
        Me.zichanyuanzhi.Name = "zichanyuanzhi"
        Me.zichanyuanzhi.Size = New System.Drawing.Size(114, 20)
        Me.zichanyuanzhi.TabIndex = 154
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(687, 35)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(114, 20)
        Me.dt1.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(841, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "公司名称"
        '
        'shuliang
        '
        Me.shuliang.Location = New System.Drawing.Point(477, 71)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(62, 20)
        Me.shuliang.TabIndex = 151
        '
        'beizhu
        '
        Me.beizhu.Location = New System.Drawing.Point(72, 137)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(519, 20)
        Me.beizhu.TabIndex = 150
        '
        'shiyongbumen
        '
        Me.shiyongbumen.FormattingEnabled = True
        Me.shiyongbumen.Location = New System.Drawing.Point(896, 36)
        Me.shiyongbumen.Name = "shiyongbumen"
        Me.shiyongbumen.Size = New System.Drawing.Size(114, 21)
        Me.shiyongbumen.TabIndex = 138
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(843, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "使用部门"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(443, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "数量"
        '
        'zichanfenlei
        '
        Me.zichanfenlei.FormattingEnabled = True
        Me.zichanfenlei.Location = New System.Drawing.Point(477, 34)
        Me.zichanfenlei.Name = "zichanfenlei"
        Me.zichanfenlei.Size = New System.Drawing.Size(114, 21)
        Me.zichanfenlei.TabIndex = 122
        '
        'piaohaol
        '
        Me.piaohaol.AutoSize = True
        Me.piaohaol.Location = New System.Drawing.Point(419, 40)
        Me.piaohaol.Name = "piaohaol"
        Me.piaohaol.Size = New System.Drawing.Size(55, 13)
        Me.piaohaol.TabIndex = 145
        Me.piaohaol.Text = "资产分类"
        '
        'fapiaoshuliang
        '
        Me.fapiaoshuliang.FormattingEnabled = True
        Me.fapiaoshuliang.Location = New System.Drawing.Point(279, 101)
        Me.fapiaoshuliang.Name = "fapiaoshuliang"
        Me.fapiaoshuliang.Size = New System.Drawing.Size(114, 21)
        Me.fapiaoshuliang.TabIndex = 140
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(224, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "发票数量"
        '
        'shiyongnianxian
        '
        Me.shiyongnianxian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.shiyongnianxian.FormattingEnabled = True
        Me.shiyongnianxian.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "25", "30", "35", "40", "50", "55", "60"})
        Me.shiyongnianxian.Location = New System.Drawing.Point(74, 66)
        Me.shiyongnianxian.Name = "shiyongnianxian"
        Me.shiyongnianxian.Size = New System.Drawing.Size(48, 21)
        Me.shiyongnianxian.TabIndex = 135
        '
        'boweil
        '
        Me.boweil.AutoSize = True
        Me.boweil.Location = New System.Drawing.Point(12, 69)
        Me.boweil.Name = "boweil"
        Me.boweil.Size = New System.Drawing.Size(55, 13)
        Me.boweil.TabIndex = 143
        Me.boweil.Text = "使用年限"
        '
        'tidanhaol
        '
        Me.tidanhaol.AutoSize = True
        Me.tidanhaol.Location = New System.Drawing.Point(620, 38)
        Me.tidanhaol.Name = "tidanhaol"
        Me.tidanhaol.Size = New System.Drawing.Size(67, 13)
        Me.tidanhaol.TabIndex = 142
        Me.tidanhaol.Text = "资本化日期"
        '
        'zichanhao
        '
        Me.zichanhao.FormattingEnabled = True
        Me.zichanhao.Items.AddRange(New Object() {"移库发货", "移库收货", "收货", "出货", "收货（测试)"})
        Me.zichanhao.Location = New System.Drawing.Point(279, 34)
        Me.zichanhao.Name = "zichanhao"
        Me.zichanhao.Size = New System.Drawing.Size(114, 21)
        Me.zichanhao.TabIndex = 132
        '
        'huowuliuxiangl
        '
        Me.huowuliuxiangl.AutoSize = True
        Me.huowuliuxiangl.Location = New System.Drawing.Point(233, 37)
        Me.huowuliuxiangl.Name = "huowuliuxiangl"
        Me.huowuliuxiangl.Size = New System.Drawing.Size(43, 13)
        Me.huowuliuxiangl.TabIndex = 141
        Me.huowuliuxiangl.Text = "资产号"
        '
        'fujianshuliang
        '
        Me.fujianshuliang.FormattingEnabled = True
        Me.fujianshuliang.Location = New System.Drawing.Point(477, 103)
        Me.fujianshuliang.Name = "fujianshuliang"
        Me.fujianshuliang.Size = New System.Drawing.Size(114, 21)
        Me.fujianshuliang.TabIndex = 130
        '
        'chuanmingl
        '
        Me.chuanmingl.AutoSize = True
        Me.chuanmingl.Location = New System.Drawing.Point(422, 106)
        Me.chuanmingl.Name = "chuanmingl"
        Me.chuanmingl.Size = New System.Drawing.Size(55, 13)
        Me.chuanmingl.TabIndex = 139
        Me.chuanmingl.Text = "附件数量"
        '
        'shiyongzhuangtai
        '
        Me.shiyongzhuangtai.FormattingEnabled = True
        Me.shiyongzhuangtai.Location = New System.Drawing.Point(74, 98)
        Me.shiyongzhuangtai.Name = "shiyongzhuangtai"
        Me.shiyongzhuangtai.Size = New System.Drawing.Size(114, 21)
        Me.shiyongzhuangtai.TabIndex = 129
        '
        'fahuodanweil
        '
        Me.fahuodanweil.AutoSize = True
        Me.fahuodanweil.Location = New System.Drawing.Point(12, 101)
        Me.fahuodanweil.Name = "fahuodanweil"
        Me.fahuodanweil.Size = New System.Drawing.Size(55, 13)
        Me.fahuodanweil.TabIndex = 136
        Me.fahuodanweil.Text = "使用状态"
        '
        'gongsimingcheng
        '
        Me.gongsimingcheng.FormattingEnabled = True
        Me.gongsimingcheng.Location = New System.Drawing.Point(896, 103)
        Me.gongsimingcheng.Name = "gongsimingcheng"
        Me.gongsimingcheng.Size = New System.Drawing.Size(195, 21)
        Me.gongsimingcheng.TabIndex = 127
        '
        'shenqingdanweil
        '
        Me.shenqingdanweil.AutoSize = True
        Me.shenqingdanweil.Location = New System.Drawing.Point(629, 108)
        Me.shenqingdanweil.Name = "shenqingdanweil"
        Me.shenqingdanweil.Size = New System.Drawing.Size(55, 13)
        Me.shenqingdanweil.TabIndex = 133
        Me.shenqingdanweil.Text = "资产原值"
        '
        'guigexinghao
        '
        Me.guigexinghao.FormattingEnabled = True
        Me.guigexinghao.Location = New System.Drawing.Point(279, 69)
        Me.guigexinghao.Name = "guigexinghao"
        Me.guigexinghao.Size = New System.Drawing.Size(114, 21)
        Me.guigexinghao.TabIndex = 126
        '
        'guigel
        '
        Me.guigel.AutoSize = True
        Me.guigel.Location = New System.Drawing.Point(224, 71)
        Me.guigel.Name = "guigel"
        Me.guigel.Size = New System.Drawing.Size(55, 13)
        Me.guigel.TabIndex = 131
        Me.guigel.Text = "规格型号"
        '
        'zichanmingcheng
        '
        Me.zichanmingcheng.FormattingEnabled = True
        Me.zichanmingcheng.Location = New System.Drawing.Point(687, 71)
        Me.zichanmingcheng.Name = "zichanmingcheng"
        Me.zichanmingcheng.Size = New System.Drawing.Size(114, 21)
        Me.zichanmingcheng.TabIndex = 124
        '
        'huowumingl
        '
        Me.huowumingl.AutoSize = True
        Me.huowumingl.Location = New System.Drawing.Point(628, 76)
        Me.huowumingl.Name = "huowumingl"
        Me.huowumingl.Size = New System.Drawing.Size(55, 13)
        Me.huowumingl.TabIndex = 128
        Me.huowumingl.Text = "资产名称"
        '
        'baojianhaol
        '
        Me.baojianhaol.AutoSize = True
        Me.baojianhaol.Location = New System.Drawing.Point(35, 139)
        Me.baojianhaol.Name = "baojianhaol"
        Me.baojianhaol.Size = New System.Drawing.Size(31, 13)
        Me.baojianhaol.TabIndex = 125
        Me.baojianhaol.Text = "备注"
        '
        'afcehao
        '
        Me.afcehao.FormattingEnabled = True
        Me.afcehao.Location = New System.Drawing.Point(74, 34)
        Me.afcehao.Name = "afcehao"
        Me.afcehao.Size = New System.Drawing.Size(114, 21)
        Me.afcehao.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "AFCE号"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripTextBox2, Me.ToolStripSeparator9, Me.ToolStripSeparator10, Me.ToolStripButton3, Me.ToolStripTextBox1, Me.ToolStripSeparator3, Me.ToolStripSeparator8, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1274, 25)
        Me.ToolStrip1.TabIndex = 155
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(27, 119)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 157
        Me.ID.Text = "ID"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = Global.AFCE.My.Resources.Resources.Hein12
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel1.Text = "输入AFCE号:"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.AFCE.My.Resources.Resources.find
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripButton3.Text = "输入资产号:"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.AFCE.My.Resources.Resources.Slayman3
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton4.Text = "退出"
        '
        '资产调拨ToolStripMenuItem
        '
        Me.资产调拨ToolStripMenuItem.Image = Global.AFCE.My.Resources.Resources.Hein17
        Me.资产调拨ToolStripMenuItem.Name = "资产调拨ToolStripMenuItem"
        Me.资产调拨ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.资产调拨ToolStripMenuItem.Text = "资产调拨"
        '
        '资产报废ToolStripMenuItem
        '
        Me.资产报废ToolStripMenuItem.Image = Global.AFCE.My.Resources.Resources.Kobra2
        Me.资产报废ToolStripMenuItem.Name = "资产报废ToolStripMenuItem"
        Me.资产报废ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.资产报废ToolStripMenuItem.Text = "资产报废"
        '
        '资产调拨纪录ToolStripMenuItem
        '
        Me.资产调拨纪录ToolStripMenuItem.Image = Global.AFCE.My.Resources.Resources.Hein16
        Me.资产调拨纪录ToolStripMenuItem.Name = "资产调拨纪录ToolStripMenuItem"
        Me.资产调拨纪录ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.资产调拨纪录ToolStripMenuItem.Text = "资产调拨纪录"
        '
        'RejectAsets
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1274, 682)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.luru)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RejectAsets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "部门调拨与报废"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.luru.ResumeLayout(False)
        Me.luru.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents luru As System.Windows.Forms.GroupBox
    Friend WithEvents fujianleixing As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents zichanyuanzhi As System.Windows.Forms.TextBox
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents shuliang As System.Windows.Forms.TextBox
    Friend WithEvents beizhu As System.Windows.Forms.TextBox
    Friend WithEvents shiyongbumen As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents zichanfenlei As System.Windows.Forms.ComboBox
    Friend WithEvents piaohaol As System.Windows.Forms.Label
    Friend WithEvents fapiaoshuliang As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents shiyongnianxian As System.Windows.Forms.ComboBox
    Friend WithEvents boweil As System.Windows.Forms.Label
    Friend WithEvents tidanhaol As System.Windows.Forms.Label
    Friend WithEvents zichanhao As System.Windows.Forms.ComboBox
    Friend WithEvents huowuliuxiangl As System.Windows.Forms.Label
    Friend WithEvents fujianshuliang As System.Windows.Forms.ComboBox
    Friend WithEvents chuanmingl As System.Windows.Forms.Label
    Friend WithEvents shiyongzhuangtai As System.Windows.Forms.ComboBox
    Friend WithEvents fahuodanweil As System.Windows.Forms.Label
    Friend WithEvents gongsimingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents shenqingdanweil As System.Windows.Forms.Label
    Friend WithEvents guigexinghao As System.Windows.Forms.ComboBox
    Friend WithEvents guigel As System.Windows.Forms.Label
    Friend WithEvents zichanmingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents huowumingl As System.Windows.Forms.Label
    Friend WithEvents baojianhaol As System.Windows.Forms.Label
    Friend WithEvents afcehao As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 资产调拨ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 资产报废ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents 资产调拨纪录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
