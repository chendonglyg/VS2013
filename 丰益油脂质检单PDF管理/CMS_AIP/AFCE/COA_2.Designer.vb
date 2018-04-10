<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COA_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COA_2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LABEL_BILL = New System.Windows.Forms.ToolStripButton()
        Me.PDF_PATH = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripLabel()
        Me.Filename = New System.Windows.Forms.ToolStripTextBox()
        Me.BUT_START = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.IDID = New System.Windows.Forms.Label()
        Me.ing = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.LABEL_BILL, Me.PDF_PATH, Me.ToolStripSeparator10, Me.Filename, Me.BUT_START, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator9, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1685, 25)
        Me.ToolStrip1.TabIndex = 135
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LABEL_BILL
        '
        Me.LABEL_BILL.Enabled = False
        Me.LABEL_BILL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LABEL_BILL.Name = "LABEL_BILL"
        Me.LABEL_BILL.Size = New System.Drawing.Size(72, 22)
        Me.LABEL_BILL.Text = "盖章后文件"
        '
        'PDF_PATH
        '
        Me.PDF_PATH.Enabled = False
        Me.PDF_PATH.Name = "PDF_PATH"
        Me.PDF_PATH.Size = New System.Drawing.Size(399, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Enabled = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripSeparator10.Text = "源文件名"
        '
        'Filename
        '
        Me.Filename.Enabled = False
        Me.Filename.Name = "Filename"
        Me.Filename.Size = New System.Drawing.Size(220, 25)
        '
        'BUT_START
        '
        Me.BUT_START.BackColor = System.Drawing.Color.Yellow
        Me.BUT_START.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BUT_START.Name = "BUT_START"
        Me.BUT_START.Size = New System.Drawing.Size(44, 22)
        Me.BUT_START.Text = "PUSH"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripButton1.Text = "TEST"
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(397, 44)
        Me.axHWPostil1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(855, 455)
        Me.axHWPostil1.TabIndex = 136
        '
        'yidengji
        '
        Me.yidengji.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yidengji.DefaultCellStyle = DataGridViewCellStyle2
        Me.yidengji.Location = New System.Drawing.Point(16, 55)
        Me.yidengji.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.yidengji.Name = "yidengji"
        Me.yidengji.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.yidengji.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.yidengji.Size = New System.Drawing.Size(505, 569)
        Me.yidengji.TabIndex = 140
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(1031, 0)
        Me.IDID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(24, 20)
        Me.IDID.TabIndex = 171
        Me.IDID.Text = "ID"
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ing.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ing.Location = New System.Drawing.Point(937, 358)
        Me.ing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ing.Name = "ing"
        Me.ing.Size = New System.Drawing.Size(234, 41)
        Me.ing.TabIndex = 172
        Me.ing.Text = "正在转换数据..."
        Me.ing.Visible = False
        '
        'COA_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 639)
        Me.Controls.Add(Me.ing)
        Me.Controls.Add(Me.IDID)
        Me.Controls.Add(Me.yidengji)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "COA_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文件签章推送"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents LABEL_BILL As System.Windows.Forms.ToolStripButton
    Friend WithEvents PDF_PATH As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BUT_START As System.Windows.Forms.ToolStripButton
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Filename As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents ing As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
