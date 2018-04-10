<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COA_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COA_1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打印单笔记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUT_START = New System.Windows.Forms.ToolStripButton()
        Me.filename = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripLabel()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.TXT_PATH = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.LABEL_BILL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDID = New System.Windows.Forms.Label()
        Me.ing = New System.Windows.Forms.Label()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(355, 28)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(641, 421)
        Me.axHWPostil1.TabIndex = 138
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打印单笔记录ToolStripMenuItem, Me.修改记录ToolStripMenuItem, Me.删除记录ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(69, 70)
        '
        '打印单笔记录ToolStripMenuItem
        '
        Me.打印单笔记录ToolStripMenuItem.Name = "打印单笔记录ToolStripMenuItem"
        Me.打印单笔记录ToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        '
        '修改记录ToolStripMenuItem
        '
        Me.修改记录ToolStripMenuItem.Name = "修改记录ToolStripMenuItem"
        Me.修改记录ToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        '
        '删除记录ToolStripMenuItem
        '
        Me.删除记录ToolStripMenuItem.Name = "删除记录ToolStripMenuItem"
        Me.删除记录ToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        '
        'BUT_START
        '
        Me.BUT_START.BackColor = System.Drawing.Color.Yellow
        Me.BUT_START.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BUT_START.Name = "BUT_START"
        Me.BUT_START.Size = New System.Drawing.Size(44, 22)
        Me.BUT_START.Text = "PUSH"
        '
        'filename
        '
        Me.filename.Name = "filename"
        Me.filename.Size = New System.Drawing.Size(166, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripSeparator10.Text = "文件名"
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'TXT_PATH
        '
        Me.TXT_PATH.Name = "TXT_PATH"
        Me.TXT_PATH.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.LABEL_BILL, Me.TXT_PATH, Me.ToolStripSeparator10, Me.filename, Me.BUT_START, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 137
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'LABEL_BILL
        '
        Me.LABEL_BILL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LABEL_BILL.Name = "LABEL_BILL"
        Me.LABEL_BILL.Size = New System.Drawing.Size(86, 22)
        Me.LABEL_BILL.Text = "选择COA表格"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
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
        Me.yidengji.Location = New System.Drawing.Point(0, 28)
        Me.yidengji.Name = "yidengji"
        Me.yidengji.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.yidengji.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.yidengji.Size = New System.Drawing.Size(349, 421)
        Me.yidengji.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(743, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Label1"
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(713, 5)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(24, 20)
        Me.IDID.TabIndex = 169
        Me.IDID.Text = "ID"
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ing.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ing.Location = New System.Drawing.Point(617, 249)
        Me.ing.Name = "ing"
        Me.ing.Size = New System.Drawing.Size(234, 41)
        Me.ing.TabIndex = 173
        Me.ing.Text = "正在转换数据..."
        Me.ing.Visible = False
        '
        'COA_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 461)
        Me.Controls.Add(Me.ing)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IDID)
        Me.Controls.Add(Me.yidengji)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "COA_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COA文件上传"
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 打印单笔记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BUT_START As System.Windows.Forms.ToolStripButton
    Friend WithEvents filename As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TXT_PATH As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LABEL_BILL As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents ing As System.Windows.Forms.Label
End Class
