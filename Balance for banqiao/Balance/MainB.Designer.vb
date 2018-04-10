<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainB
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
        Me.siji = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.yunshudanwei = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbldata = New System.Windows.Forms.Label()
        Me.pizhong = New System.Windows.Forms.TextBox()
        Me.maozhongshijian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.print = New System.Windows.Forms.Button()
        Me.jingzhong = New System.Windows.Forms.TextBox()
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.maozhong = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pizhongshijian = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.piaohao = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.piguo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.g3 = New System.Windows.Forms.GroupBox()
        Me.xiangzhong = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.xiangshu = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.xianghao2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.beizhu = New System.Windows.Forms.RichTextBox()
        Me.ph = New System.Windows.Forms.RadioButton()
        Me.ch = New System.Windows.Forms.RadioButton()
        Me.bdh = New System.Windows.Forms.RadioButton()
        Me.maocao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.maoguo = New System.Windows.Forms.TextBox()
        Me.jianshu = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.bangdanhao = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.bowei = New System.Windows.Forms.ComboBox()
        Me.boweil = New System.Windows.Forms.Label()
        Me.tidanhao = New System.Windows.Forms.ComboBox()
        Me.tidanhaol = New System.Windows.Forms.Label()
        Me.huowuliuxiang = New System.Windows.Forms.ComboBox()
        Me.huowuliuxiangl = New System.Windows.Forms.Label()
        Me.chuanming = New System.Windows.Forms.ComboBox()
        Me.chuanmingl = New System.Windows.Forms.Label()
        Me.fahuodanwei = New System.Windows.Forms.ComboBox()
        Me.fahuodanweil = New System.Windows.Forms.Label()
        Me.shenqingdanwei = New System.Windows.Forms.ComboBox()
        Me.shenqingdanweil = New System.Windows.Forms.Label()
        Me.guige = New System.Windows.Forms.ComboBox()
        Me.guigel = New System.Windows.Forms.Label()
        Me.huowuming = New System.Windows.Forms.ComboBox()
        Me.huowumingl = New System.Windows.Forms.Label()
        Me.baojianhao = New System.Windows.Forms.ComboBox()
        Me.baojianhaol = New System.Windows.Forms.Label()
        Me.chehao = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt12 = New System.Windows.Forms.DateTimePicker()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.c1 = New System.Windows.Forms.CheckBox()
        Me.g3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'siji
        '
        Me.siji.Enabled = False
        Me.siji.FormattingEnabled = True
        Me.siji.Location = New System.Drawing.Point(453, 183)
        Me.siji.Name = "siji"
        Me.siji.Size = New System.Drawing.Size(114, 21)
        Me.siji.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "罐号:"
        '
        'yunshudanwei
        '
        Me.yunshudanwei.Enabled = False
        Me.yunshudanwei.FormattingEnabled = True
        Me.yunshudanwei.Location = New System.Drawing.Point(453, 89)
        Me.yunshudanwei.Name = "yunshudanwei"
        Me.yunshudanwei.Size = New System.Drawing.Size(114, 21)
        Me.yunshudanwei.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(386, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "集装箱号:"
        '
        'lbldata
        '
        Me.lbldata.AutoSize = True
        Me.lbldata.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldata.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbldata.Location = New System.Drawing.Point(443, 43)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(378, 31)
        Me.lbldata.TabIndex = 32
        Me.lbldata.Text = "益海（连云港）磅单补打界面"
        '
        'pizhong
        '
        Me.pizhong.ForeColor = System.Drawing.Color.Red
        Me.pizhong.Location = New System.Drawing.Point(757, 87)
        Me.pizhong.Name = "pizhong"
        Me.pizhong.ReadOnly = True
        Me.pizhong.Size = New System.Drawing.Size(72, 20)
        Me.pizhong.TabIndex = 82
        '
        'maozhongshijian
        '
        Me.maozhongshijian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.maozhongshijian.Location = New System.Drawing.Point(757, 63)
        Me.maozhongshijian.Name = "maozhongshijian"
        Me.maozhongshijian.ReadOnly = True
        Me.maozhongshijian.Size = New System.Drawing.Size(114, 20)
        Me.maozhongshijian.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(726, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "皮重:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(702, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "毛重时间:"
        '
        'print
        '
        Me.print.Image = Global.Balance.My.Resources.Resources.Hein28
        Me.print.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.print.Location = New System.Drawing.Point(1095, 298)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(151, 50)
        Me.print.TabIndex = 42
        Me.print.Text = "打印"
        Me.print.UseVisualStyleBackColor = True
        '
        'jingzhong
        '
        Me.jingzhong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.jingzhong.Location = New System.Drawing.Point(757, 135)
        Me.jingzhong.Name = "jingzhong"
        Me.jingzhong.ReadOnly = True
        Me.jingzhong.Size = New System.Drawing.Size(72, 20)
        Me.jingzhong.TabIndex = 78
        '
        'sp
        '
        Me.sp.DtrEnable = True
        Me.sp.PortName = "COM6"
        Me.sp.RtsEnable = True
        '
        'maozhong
        '
        Me.maozhong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.maozhong.Location = New System.Drawing.Point(757, 39)
        Me.maozhong.Name = "maozhong"
        Me.maozhong.ReadOnly = True
        Me.maozhong.Size = New System.Drawing.Size(72, 20)
        Me.maozhong.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(726, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "净重:"
        '
        'pizhongshijian
        '
        Me.pizhongshijian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pizhongshijian.Location = New System.Drawing.Point(757, 112)
        Me.pizhongshijian.Name = "pizhongshijian"
        Me.pizhongshijian.ReadOnly = True
        Me.pizhongshijian.Size = New System.Drawing.Size(114, 20)
        Me.pizhongshijian.TabIndex = 77
        '
        'Button1
        '
        Me.Button1.Image = Global.Balance.My.Resources.Resources.Woaf08
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button1.Location = New System.Drawing.Point(1095, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 50)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "查询"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'piaohao
        '
        Me.piaohao.Enabled = False
        Me.piaohao.FormattingEnabled = True
        Me.piaohao.Location = New System.Drawing.Point(119, 73)
        Me.piaohao.Name = "piaohao"
        Me.piaohao.Size = New System.Drawing.Size(114, 21)
        Me.piaohao.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(702, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "皮重时间:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(726, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "毛重:"
        '
        'piguo
        '
        Me.piguo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.piguo.Location = New System.Drawing.Point(757, 231)
        Me.piguo.Name = "piguo"
        Me.piguo.ReadOnly = True
        Me.piguo.Size = New System.Drawing.Size(72, 20)
        Me.piguo.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(690, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "皮重过磅点:"
        '
        'picao
        '
        Me.picao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picao.Location = New System.Drawing.Point(757, 183)
        Me.picao.Name = "picao"
        Me.picao.ReadOnly = True
        Me.picao.Size = New System.Drawing.Size(72, 20)
        Me.picao.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(690, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "皮重操作者:"
        '
        'g3
        '
        Me.g3.Controls.Add(Me.xiangzhong)
        Me.g3.Controls.Add(Me.Label23)
        Me.g3.Controls.Add(Me.xiangshu)
        Me.g3.Controls.Add(Me.Label19)
        Me.g3.Controls.Add(Me.xianghao2)
        Me.g3.Controls.Add(Me.Label2)
        Me.g3.Controls.Add(Me.RadioButton1)
        Me.g3.Controls.Add(Me.Label16)
        Me.g3.Controls.Add(Me.beizhu)
        Me.g3.Controls.Add(Me.ph)
        Me.g3.Controls.Add(Me.ch)
        Me.g3.Controls.Add(Me.bdh)
        Me.g3.Controls.Add(Me.siji)
        Me.g3.Controls.Add(Me.Label3)
        Me.g3.Controls.Add(Me.yunshudanwei)
        Me.g3.Controls.Add(Me.Label9)
        Me.g3.Controls.Add(Me.pizhong)
        Me.g3.Controls.Add(Me.maozhongshijian)
        Me.g3.Controls.Add(Me.Label4)
        Me.g3.Controls.Add(Me.Label5)
        Me.g3.Controls.Add(Me.jingzhong)
        Me.g3.Controls.Add(Me.pizhongshijian)
        Me.g3.Controls.Add(Me.maozhong)
        Me.g3.Controls.Add(Me.Label10)
        Me.g3.Controls.Add(Me.piaohao)
        Me.g3.Controls.Add(Me.Label11)
        Me.g3.Controls.Add(Me.Label12)
        Me.g3.Controls.Add(Me.piguo)
        Me.g3.Controls.Add(Me.Label8)
        Me.g3.Controls.Add(Me.picao)
        Me.g3.Controls.Add(Me.Label7)
        Me.g3.Controls.Add(Me.maocao)
        Me.g3.Controls.Add(Me.Label6)
        Me.g3.Controls.Add(Me.maoguo)
        Me.g3.Controls.Add(Me.jianshu)
        Me.g3.Controls.Add(Me.Label20)
        Me.g3.Controls.Add(Me.bangdanhao)
        Me.g3.Controls.Add(Me.Label22)
        Me.g3.Controls.Add(Me.bowei)
        Me.g3.Controls.Add(Me.boweil)
        Me.g3.Controls.Add(Me.tidanhao)
        Me.g3.Controls.Add(Me.tidanhaol)
        Me.g3.Controls.Add(Me.huowuliuxiang)
        Me.g3.Controls.Add(Me.huowuliuxiangl)
        Me.g3.Controls.Add(Me.chuanming)
        Me.g3.Controls.Add(Me.chuanmingl)
        Me.g3.Controls.Add(Me.fahuodanwei)
        Me.g3.Controls.Add(Me.fahuodanweil)
        Me.g3.Controls.Add(Me.shenqingdanwei)
        Me.g3.Controls.Add(Me.shenqingdanweil)
        Me.g3.Controls.Add(Me.guige)
        Me.g3.Controls.Add(Me.guigel)
        Me.g3.Controls.Add(Me.huowuming)
        Me.g3.Controls.Add(Me.huowumingl)
        Me.g3.Controls.Add(Me.baojianhao)
        Me.g3.Controls.Add(Me.baojianhaol)
        Me.g3.Controls.Add(Me.chehao)
        Me.g3.Location = New System.Drawing.Point(36, 140)
        Me.g3.Name = "g3"
        Me.g3.Size = New System.Drawing.Size(1053, 260)
        Me.g3.TabIndex = 38
        Me.g3.TabStop = False
        Me.g3.Text = "填写区"
        '
        'xiangzhong
        '
        Me.xiangzhong.Location = New System.Drawing.Point(453, 159)
        Me.xiangzhong.Name = "xiangzhong"
        Me.xiangzhong.Size = New System.Drawing.Size(114, 20)
        Me.xiangzhong.TabIndex = 104
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(410, 164)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "箱重:"
        '
        'xiangshu
        '
        Me.xiangshu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xiangshu.FormattingEnabled = True
        Me.xiangshu.Items.AddRange(New Object() {"0", "1", "2"})
        Me.xiangshu.Location = New System.Drawing.Point(453, 137)
        Me.xiangshu.Name = "xiangshu"
        Me.xiangshu.Size = New System.Drawing.Size(48, 21)
        Me.xiangshu.TabIndex = 101
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(410, 140)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "箱数:"
        '
        'xianghao2
        '
        Me.xianghao2.Enabled = False
        Me.xianghao2.FormattingEnabled = True
        Me.xianghao2.Location = New System.Drawing.Point(453, 114)
        Me.xianghao2.Name = "xianghao2"
        Me.xianghao2.Size = New System.Drawing.Size(114, 21)
        Me.xianghao2.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "集装箱号2:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 18)
        Me.RadioButton1.TabIndex = 95
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "不选"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(896, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "备注:"
        '
        'beizhu
        '
        Me.beizhu.Enabled = False
        Me.beizhu.Location = New System.Drawing.Point(899, 176)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(148, 73)
        Me.beizhu.TabIndex = 93
        Me.beizhu.Text = ""
        '
        'ph
        '
        Me.ph.AutoSize = True
        Me.ph.Location = New System.Drawing.Point(67, 76)
        Me.ph.Name = "ph"
        Me.ph.Size = New System.Drawing.Size(49, 18)
        Me.ph.TabIndex = 88
        Me.ph.TabStop = True
        Me.ph.Text = "票号"
        Me.ph.UseVisualStyleBackColor = True
        '
        'ch
        '
        Me.ch.AutoSize = True
        Me.ch.Location = New System.Drawing.Point(67, 46)
        Me.ch.Name = "ch"
        Me.ch.Size = New System.Drawing.Size(49, 18)
        Me.ch.TabIndex = 88
        Me.ch.TabStop = True
        Me.ch.Text = "车号"
        Me.ch.UseVisualStyleBackColor = True
        '
        'bdh
        '
        Me.bdh.AutoSize = True
        Me.bdh.Location = New System.Drawing.Point(383, 236)
        Me.bdh.Name = "bdh"
        Me.bdh.Size = New System.Drawing.Size(61, 18)
        Me.bdh.TabIndex = 87
        Me.bdh.TabStop = True
        Me.bdh.Text = "磅单号"
        Me.bdh.UseVisualStyleBackColor = True
        '
        'maocao
        '
        Me.maocao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.maocao.Location = New System.Drawing.Point(757, 159)
        Me.maocao.Name = "maocao"
        Me.maocao.ReadOnly = True
        Me.maocao.Size = New System.Drawing.Size(72, 20)
        Me.maocao.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(690, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "毛重操作者:"
        '
        'maoguo
        '
        Me.maoguo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.maoguo.Location = New System.Drawing.Point(757, 207)
        Me.maoguo.Name = "maoguo"
        Me.maoguo.ReadOnly = True
        Me.maoguo.Size = New System.Drawing.Size(72, 20)
        Me.maoguo.TabIndex = 66
        '
        'jianshu
        '
        Me.jianshu.Enabled = False
        Me.jianshu.Location = New System.Drawing.Point(453, 208)
        Me.jianshu.Name = "jianshu"
        Me.jianshu.Size = New System.Drawing.Size(72, 20)
        Me.jianshu.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(690, 210)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "毛重过磅点:"
        '
        'bangdanhao
        '
        Me.bangdanhao.Enabled = False
        Me.bangdanhao.FormattingEnabled = True
        Me.bangdanhao.Location = New System.Drawing.Point(453, 232)
        Me.bangdanhao.Name = "bangdanhao"
        Me.bangdanhao.Size = New System.Drawing.Size(126, 21)
        Me.bangdanhao.TabIndex = 29
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(410, 211)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 13)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "件数:"
        '
        'bowei
        '
        Me.bowei.Enabled = False
        Me.bowei.FormattingEnabled = True
        Me.bowei.Location = New System.Drawing.Point(453, 66)
        Me.bowei.Name = "bowei"
        Me.bowei.Size = New System.Drawing.Size(114, 21)
        Me.bowei.TabIndex = 25
        '
        'boweil
        '
        Me.boweil.AutoSize = True
        Me.boweil.Location = New System.Drawing.Point(410, 70)
        Me.boweil.Name = "boweil"
        Me.boweil.Size = New System.Drawing.Size(34, 13)
        Me.boweil.TabIndex = 34
        Me.boweil.Text = "泊位:"
        '
        'tidanhao
        '
        Me.tidanhao.Enabled = False
        Me.tidanhao.FormattingEnabled = True
        Me.tidanhao.Location = New System.Drawing.Point(453, 41)
        Me.tidanhao.Name = "tidanhao"
        Me.tidanhao.Size = New System.Drawing.Size(114, 21)
        Me.tidanhao.TabIndex = 24
        '
        'tidanhaol
        '
        Me.tidanhaol.AutoSize = True
        Me.tidanhaol.Location = New System.Drawing.Point(398, 46)
        Me.tidanhaol.Name = "tidanhaol"
        Me.tidanhaol.Size = New System.Drawing.Size(46, 13)
        Me.tidanhaol.TabIndex = 32
        Me.tidanhaol.Text = "提单号:"
        '
        'huowuliuxiang
        '
        Me.huowuliuxiang.Enabled = False
        Me.huowuliuxiang.FormattingEnabled = True
        Me.huowuliuxiang.Items.AddRange(New Object() {"移库发货", "移库收货", "收货", "出货"})
        Me.huowuliuxiang.Location = New System.Drawing.Point(453, 14)
        Me.huowuliuxiang.Name = "huowuliuxiang"
        Me.huowuliuxiang.Size = New System.Drawing.Size(114, 21)
        Me.huowuliuxiang.TabIndex = 23
        '
        'huowuliuxiangl
        '
        Me.huowuliuxiangl.AutoSize = True
        Me.huowuliuxiangl.Location = New System.Drawing.Point(386, 18)
        Me.huowuliuxiangl.Name = "huowuliuxiangl"
        Me.huowuliuxiangl.Size = New System.Drawing.Size(58, 13)
        Me.huowuliuxiangl.TabIndex = 30
        Me.huowuliuxiangl.Text = "货物流向:"
        '
        'chuanming
        '
        Me.chuanming.Enabled = False
        Me.chuanming.FormattingEnabled = True
        Me.chuanming.Location = New System.Drawing.Point(119, 223)
        Me.chuanming.Name = "chuanming"
        Me.chuanming.Size = New System.Drawing.Size(114, 21)
        Me.chuanming.TabIndex = 22
        '
        'chuanmingl
        '
        Me.chuanmingl.AutoSize = True
        Me.chuanmingl.Enabled = False
        Me.chuanmingl.Location = New System.Drawing.Point(85, 226)
        Me.chuanmingl.Name = "chuanmingl"
        Me.chuanmingl.Size = New System.Drawing.Size(34, 13)
        Me.chuanmingl.TabIndex = 28
        Me.chuanmingl.Text = "船名:"
        '
        'fahuodanwei
        '
        Me.fahuodanwei.Enabled = False
        Me.fahuodanwei.FormattingEnabled = True
        Me.fahuodanwei.Location = New System.Drawing.Point(119, 193)
        Me.fahuodanwei.Name = "fahuodanwei"
        Me.fahuodanwei.Size = New System.Drawing.Size(114, 21)
        Me.fahuodanwei.TabIndex = 21
        '
        'fahuodanweil
        '
        Me.fahuodanweil.AutoSize = True
        Me.fahuodanweil.Enabled = False
        Me.fahuodanweil.Location = New System.Drawing.Point(61, 196)
        Me.fahuodanweil.Name = "fahuodanweil"
        Me.fahuodanweil.Size = New System.Drawing.Size(58, 13)
        Me.fahuodanweil.TabIndex = 26
        Me.fahuodanweil.Text = "发货单位:"
        '
        'shenqingdanwei
        '
        Me.shenqingdanwei.Enabled = False
        Me.shenqingdanwei.FormattingEnabled = True
        Me.shenqingdanwei.Location = New System.Drawing.Point(119, 163)
        Me.shenqingdanwei.Name = "shenqingdanwei"
        Me.shenqingdanwei.Size = New System.Drawing.Size(114, 21)
        Me.shenqingdanwei.TabIndex = 20
        '
        'shenqingdanweil
        '
        Me.shenqingdanweil.AutoSize = True
        Me.shenqingdanweil.Enabled = False
        Me.shenqingdanweil.Location = New System.Drawing.Point(61, 166)
        Me.shenqingdanweil.Name = "shenqingdanweil"
        Me.shenqingdanweil.Size = New System.Drawing.Size(58, 13)
        Me.shenqingdanweil.TabIndex = 24
        Me.shenqingdanweil.Text = "申请单位:"
        '
        'guige
        '
        Me.guige.Enabled = False
        Me.guige.FormattingEnabled = True
        Me.guige.Location = New System.Drawing.Point(119, 133)
        Me.guige.Name = "guige"
        Me.guige.Size = New System.Drawing.Size(114, 21)
        Me.guige.TabIndex = 19
        '
        'guigel
        '
        Me.guigel.AutoSize = True
        Me.guigel.Enabled = False
        Me.guigel.Location = New System.Drawing.Point(85, 137)
        Me.guigel.Name = "guigel"
        Me.guigel.Size = New System.Drawing.Size(34, 13)
        Me.guigel.TabIndex = 22
        Me.guigel.Text = "规格:"
        '
        'huowuming
        '
        Me.huowuming.Enabled = False
        Me.huowuming.FormattingEnabled = True
        Me.huowuming.Location = New System.Drawing.Point(119, 103)
        Me.huowuming.Name = "huowuming"
        Me.huowuming.Size = New System.Drawing.Size(114, 21)
        Me.huowuming.TabIndex = 17
        '
        'huowumingl
        '
        Me.huowumingl.AutoSize = True
        Me.huowumingl.Enabled = False
        Me.huowumingl.Location = New System.Drawing.Point(73, 106)
        Me.huowumingl.Name = "huowumingl"
        Me.huowumingl.Size = New System.Drawing.Size(46, 13)
        Me.huowumingl.TabIndex = 20
        Me.huowumingl.Text = "货物名:"
        '
        'baojianhao
        '
        Me.baojianhao.Enabled = False
        Me.baojianhao.FormattingEnabled = True
        Me.baojianhao.Location = New System.Drawing.Point(757, 16)
        Me.baojianhao.Name = "baojianhao"
        Me.baojianhao.Size = New System.Drawing.Size(126, 21)
        Me.baojianhao.TabIndex = 30
        '
        'baojianhaol
        '
        Me.baojianhaol.AutoSize = True
        Me.baojianhaol.Location = New System.Drawing.Point(712, 20)
        Me.baojianhaol.Name = "baojianhaol"
        Me.baojianhaol.Size = New System.Drawing.Size(46, 13)
        Me.baojianhaol.TabIndex = 18
        Me.baojianhaol.Text = "报检号:"
        '
        'chehao
        '
        Me.chehao.Enabled = False
        Me.chehao.FormattingEnabled = True
        Me.chehao.Location = New System.Drawing.Point(119, 43)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(114, 21)
        Me.chehao.TabIndex = 15
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'dgv
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(36, 436)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Size = New System.Drawing.Size(1210, 299)
        Me.dgv.TabIndex = 35
        '
        'Button5
        '
        Me.Button5.Image = Global.Balance.My.Resources.Resources.Slayman3
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button5.Location = New System.Drawing.Point(1095, 350)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 50)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "退出"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(562, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 296
        Me.Label1.Text = "至"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt12
        '
        Me.dt12.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt12.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt12.Location = New System.Drawing.Point(594, 113)
        Me.dt12.Name = "dt12"
        Me.dt12.Size = New System.Drawing.Size(141, 21)
        Me.dt12.TabIndex = 295
        '
        'dt11
        '
        Me.dt11.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt11.Location = New System.Drawing.Point(415, 113)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(141, 21)
        Me.dt11.TabIndex = 294
        '
        'c1
        '
        Me.c1.AutoSize = True
        Me.c1.Location = New System.Drawing.Point(394, 118)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(15, 14)
        Me.c1.TabIndex = 297
        Me.c1.UseVisualStyleBackColor = True
        '
        'MainB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 774)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dt12)
        Me.Controls.Add(Me.dt11)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.g3)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Button5)
        Me.Name = "MainB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainB"
        Me.g3.ResumeLayout(False)
        Me.g3.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents siji As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents yunshudanwei As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents pizhong As System.Windows.Forms.TextBox
    Friend WithEvents maozhongshijian As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents jingzhong As System.Windows.Forms.TextBox
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents maozhong As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pizhongshijian As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents piaohao As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents piguo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents picao As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents g3 As System.Windows.Forms.GroupBox
    Friend WithEvents maocao As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents maoguo As System.Windows.Forms.TextBox
    Friend WithEvents jianshu As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents bangdanhao As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents bowei As System.Windows.Forms.ComboBox
    Friend WithEvents boweil As System.Windows.Forms.Label
    Friend WithEvents tidanhao As System.Windows.Forms.ComboBox
    Friend WithEvents tidanhaol As System.Windows.Forms.Label
    Friend WithEvents huowuliuxiang As System.Windows.Forms.ComboBox
    Friend WithEvents huowuliuxiangl As System.Windows.Forms.Label
    Friend WithEvents chuanming As System.Windows.Forms.ComboBox
    Friend WithEvents chuanmingl As System.Windows.Forms.Label
    Friend WithEvents fahuodanwei As System.Windows.Forms.ComboBox
    Friend WithEvents fahuodanweil As System.Windows.Forms.Label
    Friend WithEvents shenqingdanwei As System.Windows.Forms.ComboBox
    Friend WithEvents shenqingdanweil As System.Windows.Forms.Label
    Friend WithEvents guige As System.Windows.Forms.ComboBox
    Friend WithEvents guigel As System.Windows.Forms.Label
    Friend WithEvents huowuming As System.Windows.Forms.ComboBox
    Friend WithEvents huowumingl As System.Windows.Forms.Label
    Friend WithEvents baojianhao As System.Windows.Forms.ComboBox
    Friend WithEvents baojianhaol As System.Windows.Forms.Label
    Friend WithEvents chehao As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ph As System.Windows.Forms.RadioButton
    Friend WithEvents ch As System.Windows.Forms.RadioButton
    Friend WithEvents bdh As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents beizhu As System.Windows.Forms.RichTextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents c1 As System.Windows.Forms.CheckBox
    Friend WithEvents xianghao2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xiangzhong As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents xiangshu As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
