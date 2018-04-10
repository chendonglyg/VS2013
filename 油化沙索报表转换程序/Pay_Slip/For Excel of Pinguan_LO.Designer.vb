<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_Excel_of_Pinguan_LO
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
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fromno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.RadioButton21 = New System.Windows.Forms.RadioButton()
        Me.RadioButton22 = New System.Windows.Forms.RadioButton()
        Me.RadioButton23 = New System.Windows.Forms.RadioButton()
        Me.RadioButton24 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fromc6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.fromno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(996, 245)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Packing Line"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(215, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "我要填写第"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(324, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 15)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "行"
        '
        'fromno
        '
        Me.fromno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fromno.Location = New System.Drawing.Point(290, 162)
        Me.fromno.Name = "fromno"
        Me.fromno.Size = New System.Drawing.Size(33, 21)
        Me.fromno.TabIndex = 69
        Me.fromno.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(357, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 42)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Packing Line"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "FAC模板"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(35, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "T01数据源"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(39, 184)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(522, 21)
        Me.TextBox2.TabIndex = 61
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(38, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(522, 21)
        Me.TextBox1.TabIndex = 59
        '
        'pb
        '
        Me.pb.ForeColor = System.Drawing.Color.Red
        Me.pb.Location = New System.Drawing.Point(12, 564)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(996, 18)
        Me.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb.TabIndex = 67
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton13)
        Me.GroupBox2.Controls.Add(Me.RadioButton14)
        Me.GroupBox2.Controls.Add(Me.RadioButton15)
        Me.GroupBox2.Controls.Add(Me.RadioButton16)
        Me.GroupBox2.Controls.Add(Me.RadioButton17)
        Me.GroupBox2.Controls.Add(Me.RadioButton18)
        Me.GroupBox2.Controls.Add(Me.RadioButton19)
        Me.GroupBox2.Controls.Add(Me.RadioButton20)
        Me.GroupBox2.Controls.Add(Me.RadioButton21)
        Me.GroupBox2.Controls.Add(Me.RadioButton22)
        Me.GroupBox2.Controls.Add(Me.RadioButton23)
        Me.GroupBox2.Controls.Add(Me.RadioButton24)
        Me.GroupBox2.Controls.Add(Me.RadioButton12)
        Me.GroupBox2.Controls.Add(Me.RadioButton11)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.fromc6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(996, 288)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fatty Acid Plant"
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(787, 253)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton13.TabIndex = 95
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "23:00"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(719, 253)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton14.TabIndex = 94
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "22:00"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(651, 253)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton15.TabIndex = 93
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Text = "21:00"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(583, 253)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton16.TabIndex = 92
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "20:00"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(515, 253)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton17.TabIndex = 91
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.Text = "19:00"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(447, 253)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton18.TabIndex = 90
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.Text = "18:00"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.Location = New System.Drawing.Point(379, 253)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton19.TabIndex = 89
        Me.RadioButton19.TabStop = True
        Me.RadioButton19.Text = "17:00"
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton20
        '
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.Location = New System.Drawing.Point(311, 253)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton20.TabIndex = 88
        Me.RadioButton20.TabStop = True
        Me.RadioButton20.Text = "16:00"
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'RadioButton21
        '
        Me.RadioButton21.AutoSize = True
        Me.RadioButton21.Location = New System.Drawing.Point(243, 253)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton21.TabIndex = 87
        Me.RadioButton21.TabStop = True
        Me.RadioButton21.Text = "15:00"
        Me.RadioButton21.UseVisualStyleBackColor = True
        '
        'RadioButton22
        '
        Me.RadioButton22.AutoSize = True
        Me.RadioButton22.Location = New System.Drawing.Point(175, 253)
        Me.RadioButton22.Name = "RadioButton22"
        Me.RadioButton22.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton22.TabIndex = 86
        Me.RadioButton22.TabStop = True
        Me.RadioButton22.Text = "14:00"
        Me.RadioButton22.UseVisualStyleBackColor = True
        '
        'RadioButton23
        '
        Me.RadioButton23.AutoSize = True
        Me.RadioButton23.Location = New System.Drawing.Point(107, 253)
        Me.RadioButton23.Name = "RadioButton23"
        Me.RadioButton23.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton23.TabIndex = 85
        Me.RadioButton23.TabStop = True
        Me.RadioButton23.Text = "13:00"
        Me.RadioButton23.UseVisualStyleBackColor = True
        '
        'RadioButton24
        '
        Me.RadioButton24.AutoSize = True
        Me.RadioButton24.Location = New System.Drawing.Point(39, 253)
        Me.RadioButton24.Name = "RadioButton24"
        Me.RadioButton24.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton24.TabIndex = 84
        Me.RadioButton24.TabStop = True
        Me.RadioButton24.Text = "12:00"
        Me.RadioButton24.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(787, 232)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton12.TabIndex = 83
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "11:00"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(719, 232)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton11.TabIndex = 82
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "10:00"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(651, 232)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton10.TabIndex = 81
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "9:00"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(583, 232)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton9.TabIndex = 80
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "8:00"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(515, 232)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton8.TabIndex = 79
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "7:00"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(447, 232)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton7.TabIndex = 78
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "6:00"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(379, 232)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton6.TabIndex = 77
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "5:00"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(311, 232)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton5.TabIndex = 76
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "4:00"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(243, 232)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton4.TabIndex = 75
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "3:00"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(175, 232)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton3.TabIndex = 74
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "2:00"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(107, 232)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton2.TabIndex = 73
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "1:00"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(39, 232)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton1.TabIndex = 72
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "0:00"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(215, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "C6位置为第"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(324, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 15)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "行"
        '
        'fromc6
        '
        Me.fromc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fromc6.Location = New System.Drawing.Point(291, 162)
        Me.fromc6.Name = "fromc6"
        Me.fromc6.Size = New System.Drawing.Size(33, 21)
        Me.fromc6.TabIndex = 69
        Me.fromc6.Text = "8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(357, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 42)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Fatty Acid Plant"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(36, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 12)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "FAC模板"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(35, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 12)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "T01数据源"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(39, 184)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(522, 21)
        Me.TextBox4.TabIndex = 61
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(38, 110)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(522, 21)
        Me.TextBox5.TabIndex = 59
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(887, 6)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(121, 18)
        Me.Button9.TabIndex = 72
        Me.Button9.Text = "KILL ALL EXCEL"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.Pay_Slip.My.Resources.Resources.office图标下载2
        Me.Button6.Location = New System.Drawing.Point(768, 93)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(172, 53)
        Me.Button6.TabIndex = 63
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.Pay_Slip.My.Resources.Resources._6552
        Me.Button7.Location = New System.Drawing.Point(590, 174)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(172, 53)
        Me.Button7.TabIndex = 62
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.Pay_Slip.My.Resources.Resources._6552
        Me.Button8.Location = New System.Drawing.Point(590, 93)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(172, 53)
        Me.Button8.TabIndex = 60
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Pay_Slip.My.Resources.Resources.office图标下载2
        Me.Button3.Location = New System.Drawing.Point(768, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 53)
        Me.Button3.TabIndex = 63
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Pay_Slip.My.Resources.Resources._6552
        Me.Button2.Location = New System.Drawing.Point(590, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 53)
        Me.Button2.TabIndex = 62
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Pay_Slip.My.Resources.Resources._6552
        Me.Button1.Location = New System.Drawing.Point(590, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 53)
        Me.Button1.TabIndex = 60
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Pay_Slip.My.Resources.Resources._128_咖啡
        Me.Button5.Location = New System.Drawing.Point(768, 174)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(172, 53)
        Me.Button5.TabIndex = 64
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.Pay_Slip.My.Resources.Resources._128_咖啡
        Me.Button4.Location = New System.Drawing.Point(768, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 53)
        Me.Button4.TabIndex = 64
        Me.Button4.UseVisualStyleBackColor = True
        '
        'For_Excel_of_Pinguan_LO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 594)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pb)
        Me.Name = "For_Excel_of_Pinguan_LO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "油化品管报表自动填写系统"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fromno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fromc6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton14 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton15 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton17 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton18 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton19 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton20 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton21 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton22 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton23 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton24 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
