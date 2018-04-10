<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USERMANAGE
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.station = New System.Windows.Forms.ComboBox()
        Me.S = New System.Windows.Forms.Label()
        Me.TextBox113 = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.TextBox114 = New System.Windows.Forms.TextBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.TextBox115 = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.xitongmokuai = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.buda = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.zhubiaochaxun = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.huizongbaobiao = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.qitashezhi = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.yonghuguanli = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.yikuguanli = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.kuchangguanli = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.guobangjiemian = New System.Windows.Forms.CheckBox()
        Me.pizhongshanchu = New System.Windows.Forms.CheckBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox13.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(243, 133)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 30)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "删除用户"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(243, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 30)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "增加用户"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.station)
        Me.GroupBox13.Controls.Add(Me.S)
        Me.GroupBox13.Controls.Add(Me.TextBox113)
        Me.GroupBox13.Controls.Add(Me.Label114)
        Me.GroupBox13.Controls.Add(Me.TextBox114)
        Me.GroupBox13.Controls.Add(Me.Label115)
        Me.GroupBox13.Controls.Add(Me.TextBox115)
        Me.GroupBox13.Controls.Add(Me.Label116)
        Me.GroupBox13.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(225, 163)
        Me.GroupBox13.TabIndex = 38
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Information"
        '
        'station
        '
        Me.station.FormattingEnabled = True
        Me.station.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "筒仓", "粕库", "榨油厂", "精炼厂", "分提车间", "酸化油车间", "35T锅炉房", "75T锅炉房", "污水处理", "小包装罐区", "粮油罐区", "小包装成品库", "小包装辅料库", "IT", "财务", "管理"})
        Me.station.Location = New System.Drawing.Point(102, 128)
        Me.station.Name = "station"
        Me.station.Size = New System.Drawing.Size(110, 21)
        Me.station.TabIndex = 77
        '
        'S
        '
        Me.S.AutoSize = True
        Me.S.Location = New System.Drawing.Point(32, 132)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(49, 13)
        Me.S.TabIndex = 177
        Me.S.Text = "Station ?"
        '
        'TextBox113
        '
        Me.TextBox113.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox113.Location = New System.Drawing.Point(78, 93)
        Me.TextBox113.Name = "TextBox113"
        Me.TextBox113.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox113.Size = New System.Drawing.Size(134, 21)
        Me.TextBox113.TabIndex = 176
        Me.TextBox113.UseSystemPasswordChar = True
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(24, 96)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(53, 13)
        Me.Label114.TabIndex = 175
        Me.Label114.Text = "Password"
        '
        'TextBox114
        '
        Me.TextBox114.Enabled = False
        Me.TextBox114.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox114.Location = New System.Drawing.Point(78, 59)
        Me.TextBox114.Name = "TextBox114"
        Me.TextBox114.Size = New System.Drawing.Size(134, 21)
        Me.TextBox114.TabIndex = 174
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(12, 62)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(65, 13)
        Me.Label115.TabIndex = 173
        Me.Label115.Text = "Username"
        '
        'TextBox115
        '
        Me.TextBox115.Enabled = False
        Me.TextBox115.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox115.Location = New System.Drawing.Point(78, 25)
        Me.TextBox115.Name = "TextBox115"
        Me.TextBox115.Size = New System.Drawing.Size(94, 21)
        Me.TextBox115.TabIndex = 172
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(56, 28)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(21, 13)
        Me.Label116.TabIndex = 171
        Me.Label116.Text = "ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(243, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 30)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "设置权限"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 30)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 247)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(341, 514)
        Me.dgv.TabIndex = 35
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.PictureBox14)
        Me.GroupBox15.Enabled = False
        Me.GroupBox15.ForeColor = System.Drawing.Color.Red
        Me.GroupBox15.Location = New System.Drawing.Point(381, 451)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox15.TabIndex = 76
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "最高权限"
        '
        'PictureBox14
        '
        Me.PictureBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox14.Image = Global.Balance.My.Resources.Resources._01300000291092123635130775482
        Me.PictureBox14.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 0
        Me.PictureBox14.TabStop = False
        '
        'xitongmokuai
        '
        Me.xitongmokuai.AutoSize = True
        Me.xitongmokuai.Location = New System.Drawing.Point(384, 432)
        Me.xitongmokuai.Name = "xitongmokuai"
        Me.xitongmokuai.Size = New System.Drawing.Size(74, 17)
        Me.xitongmokuai.TabIndex = 71
        Me.xitongmokuai.Text = "系统模块"
        Me.xitongmokuai.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.PictureBox7)
        Me.GroupBox7.Enabled = False
        Me.GroupBox7.Location = New System.Drawing.Point(840, 282)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox7.TabIndex = 64
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "磅单补打"
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox7.Image = Global.Balance.My.Resources.Resources.补打榜单
        Me.PictureBox7.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'buda
        '
        Me.buda.AutoSize = True
        Me.buda.Location = New System.Drawing.Point(840, 263)
        Me.buda.Name = "buda"
        Me.buda.Size = New System.Drawing.Size(74, 17)
        Me.buda.TabIndex = 63
        Me.buda.Text = "磅单补打"
        Me.buda.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.PictureBox8)
        Me.GroupBox8.Enabled = False
        Me.GroupBox8.Location = New System.Drawing.Point(1065, 282)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox8.TabIndex = 62
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "主表数据查询"
        '
        'PictureBox8
        '
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox8.Image = Global.Balance.My.Resources.Resources.主表查询
        Me.PictureBox8.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'zhubiaochaxun
        '
        Me.zhubiaochaxun.AutoSize = True
        Me.zhubiaochaxun.Location = New System.Drawing.Point(1065, 263)
        Me.zhubiaochaxun.Name = "zhubiaochaxun"
        Me.zhubiaochaxun.Size = New System.Drawing.Size(74, 17)
        Me.zhubiaochaxun.TabIndex = 61
        Me.zhubiaochaxun.Text = "主表数据"
        Me.zhubiaochaxun.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(1065, 117)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox4.TabIndex = 58
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "04-汇总报表打印"
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.Balance.My.Resources.Resources.汇总报表
        Me.PictureBox4.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'huizongbaobiao
        '
        Me.huizongbaobiao.AutoSize = True
        Me.huizongbaobiao.Location = New System.Drawing.Point(1065, 98)
        Me.huizongbaobiao.Name = "huizongbaobiao"
        Me.huizongbaobiao.Size = New System.Drawing.Size(74, 17)
        Me.huizongbaobiao.TabIndex = 57
        Me.huizongbaobiao.Text = "汇总报表"
        Me.huizongbaobiao.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox5)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Location = New System.Drawing.Point(384, 282)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "05-其他参数设置"
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Image = Global.Balance.My.Resources.Resources.设置界面
        Me.PictureBox5.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'qitashezhi
        '
        Me.qitashezhi.AutoSize = True
        Me.qitashezhi.Location = New System.Drawing.Point(384, 263)
        Me.qitashezhi.Name = "qitashezhi"
        Me.qitashezhi.Size = New System.Drawing.Size(74, 17)
        Me.qitashezhi.TabIndex = 55
        Me.qitashezhi.Text = "其他设置"
        Me.qitashezhi.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PictureBox6)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Location = New System.Drawing.Point(612, 282)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox6.TabIndex = 54
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "06-用户管理"
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox6.Image = Global.Balance.My.Resources.Resources.用户设置
        Me.PictureBox6.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'yonghuguanli
        '
        Me.yonghuguanli.AutoSize = True
        Me.yonghuguanli.Location = New System.Drawing.Point(612, 263)
        Me.yonghuguanli.Name = "yonghuguanli"
        Me.yonghuguanli.Size = New System.Drawing.Size(74, 17)
        Me.yonghuguanli.TabIndex = 53
        Me.yonghuguanli.Text = "用户管理"
        Me.yonghuguanli.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(840, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "03-移库数据查询"
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.Balance.My.Resources.Resources.移库查询
        Me.PictureBox3.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'yikuguanli
        '
        Me.yikuguanli.AutoSize = True
        Me.yikuguanli.Location = New System.Drawing.Point(840, 98)
        Me.yikuguanli.Name = "yikuguanli"
        Me.yikuguanli.Size = New System.Drawing.Size(74, 17)
        Me.yikuguanli.TabIndex = 51
        Me.yikuguanli.Text = "移库管理"
        Me.yikuguanli.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(612, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "02-库场收货管理"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Balance.My.Resources.Resources.库场收货
        Me.PictureBox2.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'kuchangguanli
        '
        Me.kuchangguanli.AutoSize = True
        Me.kuchangguanli.Location = New System.Drawing.Point(612, 98)
        Me.kuchangguanli.Name = "kuchangguanli"
        Me.kuchangguanli.Size = New System.Drawing.Size(74, 17)
        Me.kuchangguanli.TabIndex = 49
        Me.kuchangguanli.Text = "库场管理"
        Me.kuchangguanli.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(384, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "01-过磅主界面"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Balance.My.Resources.Resources.主界面
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'guobangjiemian
        '
        Me.guobangjiemian.AutoSize = True
        Me.guobangjiemian.Location = New System.Drawing.Point(384, 98)
        Me.guobangjiemian.Name = "guobangjiemian"
        Me.guobangjiemian.Size = New System.Drawing.Size(74, 17)
        Me.guobangjiemian.TabIndex = 47
        Me.guobangjiemian.Text = "过磅界面"
        Me.guobangjiemian.UseVisualStyleBackColor = True
        '
        'pizhongshanchu
        '
        Me.pizhongshanchu.AutoSize = True
        Me.pizhongshanchu.Location = New System.Drawing.Point(612, 432)
        Me.pizhongshanchu.Name = "pizhongshanchu"
        Me.pizhongshanchu.Size = New System.Drawing.Size(74, 17)
        Me.pizhongshanchu.TabIndex = 77
        Me.pizhongshanchu.Text = "皮重删除"
        Me.pizhongshanchu.UseVisualStyleBackColor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Balance.My.Resources.Resources.Kobra
        Me.PictureBox9.Location = New System.Drawing.Point(69, 43)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox9.TabIndex = 79
        Me.PictureBox9.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.PictureBox9)
        Me.GroupBox9.Enabled = False
        Me.GroupBox9.ForeColor = System.Drawing.Color.Red
        Me.GroupBox9.Location = New System.Drawing.Point(612, 451)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox9.TabIndex = 80
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "皮重删除权限"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(-1, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(225, 30)
        Me.Button5.TabIndex = 81
        Me.Button5.Text = "更新至工业园用户列表"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'USERMANAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 808)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.pizhongshanchu)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.xitongmokuai)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.buda)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.zhubiaochaxun)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.huizongbaobiao)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.qitashezhi)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.yonghuguanli)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.yikuguanli)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.kuchangguanli)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.guobangjiemian)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "USERMANAGE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usersmanage"
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents S As System.Windows.Forms.Label
    Friend WithEvents TextBox113 As System.Windows.Forms.TextBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents TextBox114 As System.Windows.Forms.TextBox
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents TextBox115 As System.Windows.Forms.TextBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents xitongmokuai As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents buda As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents zhubiaochaxun As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents huizongbaobiao As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents qitashezhi As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents yonghuguanli As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents yikuguanli As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents kuchangguanli As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents guobangjiemian As System.Windows.Forms.CheckBox
    Friend WithEvents station As System.Windows.Forms.ComboBox
    Friend WithEvents pizhongshanchu As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
