<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toledo20110415
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.sh = New System.Windows.Forms.RadioButton()
        Me.fh = New System.Windows.Forms.RadioButton()
        Me.shsh = New System.Windows.Forms.ComboBox()
        Me.fhfh = New System.Windows.Forms.ComboBox()
        Me.ph = New System.Windows.Forms.RadioButton()
        Me.ch = New System.Windows.Forms.RadioButton()
        Me.piaohao = New System.Windows.Forms.ComboBox()
        Me.chehao = New System.Windows.Forms.ComboBox()
        Me.c1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt12 = New System.Windows.Forms.DateTimePicker()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.shuliang = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新宋体", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(569, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "过期数据查询"
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
        Me.dgv.Location = New System.Drawing.Point(22, 237)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.Size = New System.Drawing.Size(1238, 356)
        Me.dgv.TabIndex = 36
        '
        'gb
        '
        Me.gb.Controls.Add(Me.sh)
        Me.gb.Controls.Add(Me.fh)
        Me.gb.Controls.Add(Me.shsh)
        Me.gb.Controls.Add(Me.fhfh)
        Me.gb.Controls.Add(Me.ph)
        Me.gb.Controls.Add(Me.ch)
        Me.gb.Controls.Add(Me.piaohao)
        Me.gb.Controls.Add(Me.chehao)
        Me.gb.Location = New System.Drawing.Point(22, 126)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(461, 94)
        Me.gb.TabIndex = 38
        Me.gb.TabStop = False
        Me.gb.Text = "条件区域"
        '
        'sh
        '
        Me.sh.AutoSize = True
        Me.sh.Location = New System.Drawing.Point(236, 60)
        Me.sh.Name = "sh"
        Me.sh.Size = New System.Drawing.Size(73, 18)
        Me.sh.TabIndex = 103
        Me.sh.TabStop = True
        Me.sh.Text = "收货单位"
        Me.sh.UseVisualStyleBackColor = True
        '
        'fh
        '
        Me.fh.AutoSize = True
        Me.fh.Location = New System.Drawing.Point(236, 29)
        Me.fh.Name = "fh"
        Me.fh.Size = New System.Drawing.Size(73, 18)
        Me.fh.TabIndex = 104
        Me.fh.TabStop = True
        Me.fh.Text = "发货单位"
        Me.fh.UseVisualStyleBackColor = True
        '
        'shsh
        '
        Me.shsh.FormattingEnabled = True
        Me.shsh.Location = New System.Drawing.Point(312, 56)
        Me.shsh.Name = "shsh"
        Me.shsh.Size = New System.Drawing.Size(114, 21)
        Me.shsh.TabIndex = 102
        '
        'fhfh
        '
        Me.fhfh.FormattingEnabled = True
        Me.fhfh.Location = New System.Drawing.Point(312, 27)
        Me.fhfh.Name = "fhfh"
        Me.fhfh.Size = New System.Drawing.Size(114, 21)
        Me.fhfh.TabIndex = 101
        '
        'ph
        '
        Me.ph.AutoSize = True
        Me.ph.Location = New System.Drawing.Point(24, 60)
        Me.ph.Name = "ph"
        Me.ph.Size = New System.Drawing.Size(49, 18)
        Me.ph.TabIndex = 99
        Me.ph.TabStop = True
        Me.ph.Text = "票号"
        Me.ph.UseVisualStyleBackColor = True
        '
        'ch
        '
        Me.ch.AutoSize = True
        Me.ch.Location = New System.Drawing.Point(24, 29)
        Me.ch.Name = "ch"
        Me.ch.Size = New System.Drawing.Size(49, 18)
        Me.ch.TabIndex = 100
        Me.ch.TabStop = True
        Me.ch.Text = "车号"
        Me.ch.UseVisualStyleBackColor = True
        '
        'piaohao
        '
        Me.piaohao.FormattingEnabled = True
        Me.piaohao.Location = New System.Drawing.Point(76, 56)
        Me.piaohao.Name = "piaohao"
        Me.piaohao.Size = New System.Drawing.Size(114, 21)
        Me.piaohao.TabIndex = 98
        '
        'chehao
        '
        Me.chehao.FormattingEnabled = True
        Me.chehao.Location = New System.Drawing.Point(76, 27)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(114, 21)
        Me.chehao.TabIndex = 97
        '
        'c1
        '
        Me.c1.AutoSize = True
        Me.c1.Location = New System.Drawing.Point(495, 69)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(15, 14)
        Me.c1.TabIndex = 301
        Me.c1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(663, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 300
        Me.Label2.Text = "至"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt12
        '
        Me.dt12.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt12.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt12.Location = New System.Drawing.Point(695, 65)
        Me.dt12.Name = "dt12"
        Me.dt12.Size = New System.Drawing.Size(141, 21)
        Me.dt12.TabIndex = 299
        '
        'dt11
        '
        Me.dt11.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt11.Location = New System.Drawing.Point(516, 65)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(141, 21)
        Me.dt11.TabIndex = 298
        '
        'Button1
        '
        Me.Button1.Image = Global.Balance.My.Resources.Resources.Hein181
        Me.Button1.Location = New System.Drawing.Point(495, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 94)
        Me.Button1.TabIndex = 302
        Me.Button1.UseVisualStyleBackColor = True
        '
        'shuliang
        '
        Me.shuliang.AutoSize = True
        Me.shuliang.Location = New System.Drawing.Point(836, 598)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(0, 13)
        Me.shuliang.TabIndex = 303
        '
        'Toledo20110415
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 621)
        Me.Controls.Add(Me.shuliang)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dt12)
        Me.Controls.Add(Me.dt11)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Toledo20110415"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toledo20110415"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents sh As System.Windows.Forms.RadioButton
    Friend WithEvents fh As System.Windows.Forms.RadioButton
    Friend WithEvents shsh As System.Windows.Forms.ComboBox
    Friend WithEvents fhfh As System.Windows.Forms.ComboBox
    Friend WithEvents ph As System.Windows.Forms.RadioButton
    Friend WithEvents ch As System.Windows.Forms.RadioButton
    Friend WithEvents piaohao As System.Windows.Forms.ComboBox
    Friend WithEvents chehao As System.Windows.Forms.ComboBox
    Friend WithEvents c1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt12 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents shuliang As System.Windows.Forms.Label
End Class
