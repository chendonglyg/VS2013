<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForPrintA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.Print1 = New System.Windows.Forms.Button()
        Me.rukudt2 = New System.Windows.Forms.DateTimePicker()
        Me.cplx1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rukugz = New System.Windows.Forms.Label()
        Me.rukudt1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chukudt11 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chukusc = New System.Windows.Forms.RadioButton()
        Me.chukugz = New System.Windows.Forms.RadioButton()
        Me.chukudt2 = New System.Windows.Forms.DateTimePicker()
        Me.cplx2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chukudt1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.diaobodt2 = New System.Windows.Forms.DateTimePicker()
        Me.cplx3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.diaobogz = New System.Windows.Forms.Label()
        Me.diaobodt1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ck = New System.Windows.Forms.CheckBox()
        Me.cangku = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.scxh = New System.Windows.Forms.CheckBox()
        Me.shengchanxianhao = New System.Windows.Forms.ComboBox()
        Me.hw = New System.Windows.Forms.CheckBox()
        Me.huowei = New System.Windows.Forms.ComboBox()
        Me.cq = New System.Windows.Forms.CheckBox()
        Me.cangqu = New System.Windows.Forms.ComboBox()
        Me.cpmc = New System.Windows.Forms.CheckBox()
        Me.chanpinmingcheng = New System.Windows.Forms.ComboBox()
        Me.pp = New System.Windows.Forms.CheckBox()
        Me.pinpai = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.jichuxinxi.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(577, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "报表打印汇总"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1238, 355)
        Me.GroupBox2.TabIndex = 169
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "数据浏览区"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(19, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(1193, 29)
        Me.Button4.TabIndex = 171
        Me.Button4.Text = "Print"
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.dgv.Location = New System.Drawing.Point(19, 51)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1193, 288)
        Me.dgv.TabIndex = 144
        '
        'jichuxinxi
        '
        Me.jichuxinxi.Controls.Add(Me.Print1)
        Me.jichuxinxi.Controls.Add(Me.rukudt2)
        Me.jichuxinxi.Controls.Add(Me.cplx1)
        Me.jichuxinxi.Controls.Add(Me.Label10)
        Me.jichuxinxi.Controls.Add(Me.rukugz)
        Me.jichuxinxi.Controls.Add(Me.rukudt1)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(22, 66)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(300, 194)
        Me.jichuxinxi.TabIndex = 170
        Me.jichuxinxi.TabStop = False
        Me.jichuxinxi.Text = "入库记录"
        '
        'Print1
        '
        Me.Print1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Print1.ForeColor = System.Drawing.Color.Red
        Me.Print1.Location = New System.Drawing.Point(87, 160)
        Me.Print1.Name = "Print1"
        Me.Print1.Size = New System.Drawing.Size(182, 28)
        Me.Print1.TabIndex = 164
        Me.Print1.Text = "Find"
        Me.Print1.UseVisualStyleBackColor = True
        '
        'rukudt2
        '
        Me.rukudt2.CalendarFont = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rukudt2.CustomFormat = "yyyy年MM月dd日 HH时mm分"
        Me.rukudt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rukudt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.rukudt2.Location = New System.Drawing.Point(87, 88)
        Me.rukudt2.Name = "rukudt2"
        Me.rukudt2.ShowUpDown = True
        Me.rukudt2.Size = New System.Drawing.Size(182, 21)
        Me.rukudt2.TabIndex = 160
        Me.rukudt2.Value = New Date(2012, 10, 31, 12, 11, 0, 0)
        '
        'cplx1
        '
        Me.cplx1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cplx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cplx1.FormattingEnabled = True
        Me.cplx1.Items.AddRange(New Object() {"生产进", "调拨回"})
        Me.cplx1.Location = New System.Drawing.Point(87, 32)
        Me.cplx1.Name = "cplx1"
        Me.cplx1.Size = New System.Drawing.Size(182, 23)
        Me.cplx1.TabIndex = 158
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "产品流向"
        '
        'rukugz
        '
        Me.rukugz.AutoSize = True
        Me.rukugz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rukugz.Location = New System.Drawing.Point(16, 75)
        Me.rukugz.Name = "rukugz"
        Me.rukugz.Size = New System.Drawing.Size(55, 15)
        Me.rukugz.TabIndex = 115
        Me.rukugz.Text = "入库时间"
        '
        'rukudt1
        '
        Me.rukudt1.CalendarFont = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rukudt1.CustomFormat = "yyyy年MM月dd日 HH时mm分"
        Me.rukudt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rukudt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.rukudt1.Location = New System.Drawing.Point(87, 61)
        Me.rukudt1.Name = "rukudt1"
        Me.rukudt1.ShowUpDown = True
        Me.rukudt1.Size = New System.Drawing.Size(182, 21)
        Me.rukudt1.TabIndex = 8
        Me.rukudt1.Value = New Date(2012, 10, 31, 12, 11, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chukudt11)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.chukusc)
        Me.GroupBox1.Controls.Add(Me.chukugz)
        Me.GroupBox1.Controls.Add(Me.chukudt2)
        Me.GroupBox1.Controls.Add(Me.cplx2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chukudt1)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(328, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 194)
        Me.GroupBox1.TabIndex = 171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "出库记录"
        '
        'chukudt11
        '
        Me.chukudt11.CalendarFont = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chukudt11.CustomFormat = "yyyy年MM月dd日 HH时mm分"
        Me.chukudt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chukudt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chukudt11.Location = New System.Drawing.Point(87, 88)
        Me.chukudt11.Name = "chukudt11"
        Me.chukudt11.ShowUpDown = True
        Me.chukudt11.Size = New System.Drawing.Size(182, 21)
        Me.chukudt11.TabIndex = 166
        Me.chukudt11.Value = New Date(2012, 10, 31, 12, 11, 0, 0)
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(87, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 28)
        Me.Button1.TabIndex = 165
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chukusc
        '
        Me.chukusc.AutoSize = True
        Me.chukusc.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chukusc.Location = New System.Drawing.Point(7, 123)
        Me.chukusc.Name = "chukusc"
        Me.chukusc.Size = New System.Drawing.Size(74, 21)
        Me.chukusc.TabIndex = 163
        Me.chukusc.TabStop = True
        Me.chukusc.Text = "生产时间"
        Me.chukusc.UseVisualStyleBackColor = True
        '
        'chukugz
        '
        Me.chukugz.AutoSize = True
        Me.chukugz.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chukugz.Location = New System.Drawing.Point(7, 75)
        Me.chukugz.Name = "chukugz"
        Me.chukugz.Size = New System.Drawing.Size(74, 21)
        Me.chukugz.TabIndex = 162
        Me.chukugz.TabStop = True
        Me.chukugz.Text = "出库时间"
        Me.chukugz.UseVisualStyleBackColor = True
        '
        'chukudt2
        '
        Me.chukudt2.CalendarFont = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chukudt2.CustomFormat = "yyyy年MM月dd日 HH时mm分"
        Me.chukudt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chukudt2.Location = New System.Drawing.Point(87, 120)
        Me.chukudt2.Name = "chukudt2"
        Me.chukudt2.Size = New System.Drawing.Size(182, 21)
        Me.chukudt2.TabIndex = 161
        Me.chukudt2.Value = New Date(2012, 10, 31, 12, 11, 0, 0)
        '
        'cplx2
        '
        Me.cplx2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cplx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cplx2.FormattingEnabled = True
        Me.cplx2.Items.AddRange(New Object() {"经销出", "赠品出", "食堂领用", "礼品领用", "品控抽检", "回填", "换货出"})
        Me.cplx2.Location = New System.Drawing.Point(87, 32)
        Me.cplx2.Name = "cplx2"
        Me.cplx2.Size = New System.Drawing.Size(182, 23)
        Me.cplx2.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "产品流向"
        '
        'chukudt1
        '
        Me.chukudt1.CalendarFont = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chukudt1.CustomFormat = "yyyy年MM月dd日 HH时mm分"
        Me.chukudt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chukudt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chukudt1.Location = New System.Drawing.Point(87, 61)
        Me.chukudt1.Name = "chukudt1"
        Me.chukudt1.ShowUpDown = True
        Me.chukudt1.Size = New System.Drawing.Size(182, 21)
        Me.chukudt1.TabIndex = 8
        Me.chukudt1.Value = New Date(2012, 10, 31, 12, 11, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.diaobodt2)
        Me.GroupBox3.Controls.Add(Me.cplx3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.diaobogz)
        Me.GroupBox3.Controls.Add(Me.diaobodt1)
        Me.GroupBox3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(624, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 194)
        Me.GroupBox3.TabIndex = 172
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "调拨记录"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(87, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 28)
        Me.Button2.TabIndex = 165
        Me.Button2.Text = "Find"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'diaobodt2
        '
        Me.diaobodt2.CalendarFont = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.diaobodt2.CustomFormat = "yyyy年MM月dd日 HH时mm分"
        Me.diaobodt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diaobodt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.diaobodt2.Location = New System.Drawing.Point(87, 88)
        Me.diaobodt2.Name = "diaobodt2"
        Me.diaobodt2.ShowUpDown = True
        Me.diaobodt2.Size = New System.Drawing.Size(182, 21)
        Me.diaobodt2.TabIndex = 161
        Me.diaobodt2.Value = New Date(2012, 10, 31, 12, 11, 0, 0)
        '
        'cplx3
        '
        Me.cplx3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cplx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cplx3.FormattingEnabled = True
        Me.cplx3.Items.AddRange(New Object() {"调拨出", "调拨进"})
        Me.cplx3.Location = New System.Drawing.Point(87, 32)
        Me.cplx3.Name = "cplx3"
        Me.cplx3.Size = New System.Drawing.Size(182, 23)
        Me.cplx3.TabIndex = 158
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "产品流向"
        '
        'diaobogz
        '
        Me.diaobogz.AutoSize = True
        Me.diaobogz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diaobogz.Location = New System.Drawing.Point(16, 75)
        Me.diaobogz.Name = "diaobogz"
        Me.diaobogz.Size = New System.Drawing.Size(55, 15)
        Me.diaobogz.TabIndex = 115
        Me.diaobogz.Text = "调拨时间"
        '
        'diaobodt1
        '
        Me.diaobodt1.CalendarFont = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.diaobodt1.CustomFormat = "yyyy年MM月dd日 HH时mm分"
        Me.diaobodt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diaobodt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.diaobodt1.Location = New System.Drawing.Point(87, 61)
        Me.diaobodt1.Name = "diaobodt1"
        Me.diaobodt1.ShowUpDown = True
        Me.diaobodt1.Size = New System.Drawing.Size(182, 21)
        Me.diaobodt1.TabIndex = 8
        Me.diaobodt1.Value = New Date(2012, 10, 31, 12, 11, 0, 0)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ck)
        Me.GroupBox4.Controls.Add(Me.cangku)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.scxh)
        Me.GroupBox4.Controls.Add(Me.shengchanxianhao)
        Me.GroupBox4.Controls.Add(Me.hw)
        Me.GroupBox4.Controls.Add(Me.huowei)
        Me.GroupBox4.Controls.Add(Me.cq)
        Me.GroupBox4.Controls.Add(Me.cangqu)
        Me.GroupBox4.Controls.Add(Me.cpmc)
        Me.GroupBox4.Controls.Add(Me.chanpinmingcheng)
        Me.GroupBox4.Controls.Add(Me.pp)
        Me.GroupBox4.Controls.Add(Me.pinpai)
        Me.GroupBox4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(918, 66)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 239)
        Me.GroupBox4.TabIndex = 173
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "库存信息"
        '
        'ck
        '
        Me.ck.AutoSize = True
        Me.ck.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ck.Location = New System.Drawing.Point(18, 77)
        Me.ck.Name = "ck"
        Me.ck.Size = New System.Drawing.Size(51, 21)
        Me.ck.TabIndex = 172
        Me.ck.Text = "仓库"
        Me.ck.UseVisualStyleBackColor = True
        '
        'cangku
        '
        Me.cangku.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cangku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cangku.FormattingEnabled = True
        Me.cangku.Items.AddRange(New Object() {"调拨出", "调拨进"})
        Me.cangku.Location = New System.Drawing.Point(97, 77)
        Me.cangku.Name = "cangku"
        Me.cangku.Size = New System.Drawing.Size(182, 23)
        Me.cangku.TabIndex = 171
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(6, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(330, 28)
        Me.Button3.TabIndex = 170
        Me.Button3.Text = "Find"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'scxh
        '
        Me.scxh.AutoSize = True
        Me.scxh.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.scxh.Location = New System.Drawing.Point(18, 162)
        Me.scxh.Name = "scxh"
        Me.scxh.Size = New System.Drawing.Size(75, 21)
        Me.scxh.TabIndex = 169
        Me.scxh.Text = "生产线号"
        Me.scxh.UseVisualStyleBackColor = True
        '
        'shengchanxianhao
        '
        Me.shengchanxianhao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.shengchanxianhao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shengchanxianhao.FormattingEnabled = True
        Me.shengchanxianhao.Items.AddRange(New Object() {"L01", "L02", "L03", "L04"})
        Me.shengchanxianhao.Location = New System.Drawing.Point(97, 160)
        Me.shengchanxianhao.Name = "shengchanxianhao"
        Me.shengchanxianhao.Size = New System.Drawing.Size(182, 23)
        Me.shengchanxianhao.TabIndex = 168
        '
        'hw
        '
        Me.hw.AutoSize = True
        Me.hw.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.hw.Location = New System.Drawing.Point(18, 133)
        Me.hw.Name = "hw"
        Me.hw.Size = New System.Drawing.Size(51, 21)
        Me.hw.TabIndex = 167
        Me.hw.Text = "货位"
        Me.hw.UseVisualStyleBackColor = True
        '
        'huowei
        '
        Me.huowei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.huowei.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.huowei.FormattingEnabled = True
        Me.huowei.Items.AddRange(New Object() {"调拨出", "调拨进"})
        Me.huowei.Location = New System.Drawing.Point(97, 131)
        Me.huowei.Name = "huowei"
        Me.huowei.Size = New System.Drawing.Size(182, 23)
        Me.huowei.TabIndex = 166
        '
        'cq
        '
        Me.cq.AutoSize = True
        Me.cq.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cq.Location = New System.Drawing.Point(18, 106)
        Me.cq.Name = "cq"
        Me.cq.Size = New System.Drawing.Size(51, 21)
        Me.cq.TabIndex = 165
        Me.cq.Text = "仓区"
        Me.cq.UseVisualStyleBackColor = True
        '
        'cangqu
        '
        Me.cangqu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cangqu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cangqu.FormattingEnabled = True
        Me.cangqu.Items.AddRange(New Object() {"调拨出", "调拨进"})
        Me.cangqu.Location = New System.Drawing.Point(97, 104)
        Me.cangqu.Name = "cangqu"
        Me.cangqu.Size = New System.Drawing.Size(182, 23)
        Me.cangqu.TabIndex = 164
        '
        'cpmc
        '
        Me.cpmc.AutoSize = True
        Me.cpmc.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cpmc.Location = New System.Drawing.Point(18, 48)
        Me.cpmc.Name = "cpmc"
        Me.cpmc.Size = New System.Drawing.Size(75, 21)
        Me.cpmc.TabIndex = 163
        Me.cpmc.Text = "产品名称"
        Me.cpmc.UseVisualStyleBackColor = True
        '
        'chanpinmingcheng
        '
        Me.chanpinmingcheng.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chanpinmingcheng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chanpinmingcheng.FormattingEnabled = True
        Me.chanpinmingcheng.Items.AddRange(New Object() {"调拨出", "调拨进"})
        Me.chanpinmingcheng.Location = New System.Drawing.Point(97, 46)
        Me.chanpinmingcheng.Name = "chanpinmingcheng"
        Me.chanpinmingcheng.Size = New System.Drawing.Size(182, 23)
        Me.chanpinmingcheng.TabIndex = 162
        '
        'pp
        '
        Me.pp.AutoSize = True
        Me.pp.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pp.Location = New System.Drawing.Point(18, 21)
        Me.pp.Name = "pp"
        Me.pp.Size = New System.Drawing.Size(51, 21)
        Me.pp.TabIndex = 161
        Me.pp.Text = "品牌"
        Me.pp.UseVisualStyleBackColor = True
        '
        'pinpai
        '
        Me.pinpai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pinpai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinpai.FormattingEnabled = True
        Me.pinpai.Location = New System.Drawing.Point(97, 19)
        Me.pinpai.Name = "pinpai"
        Me.pinpai.Size = New System.Drawing.Size(182, 23)
        Me.pinpai.TabIndex = 160
        '
        'ForPrintA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 670)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ForPrintA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "打印汇总界面"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents cplx1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rukugz As System.Windows.Forms.Label
    Friend WithEvents rukudt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rukudt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chukusc As System.Windows.Forms.RadioButton
    Friend WithEvents chukugz As System.Windows.Forms.RadioButton
    Friend WithEvents chukudt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cplx2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chukudt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents diaobodt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cplx3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents diaobogz As System.Windows.Forms.Label
    Friend WithEvents diaobodt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents scxh As System.Windows.Forms.CheckBox
    Friend WithEvents shengchanxianhao As System.Windows.Forms.ComboBox
    Friend WithEvents hw As System.Windows.Forms.CheckBox
    Friend WithEvents huowei As System.Windows.Forms.ComboBox
    Friend WithEvents cq As System.Windows.Forms.CheckBox
    Friend WithEvents cangqu As System.Windows.Forms.ComboBox
    Friend WithEvents cpmc As System.Windows.Forms.CheckBox
    Friend WithEvents chanpinmingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents pp As System.Windows.Forms.CheckBox
    Friend WithEvents pinpai As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Print1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ck As System.Windows.Forms.CheckBox
    Friend WithEvents cangku As System.Windows.Forms.ComboBox
    Friend WithEvents chukudt11 As System.Windows.Forms.DateTimePicker
End Class
