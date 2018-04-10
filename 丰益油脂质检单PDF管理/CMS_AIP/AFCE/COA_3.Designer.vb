<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COA_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COA_3))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.MouseCall = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打印COAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除COAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDID = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Filename = New System.Windows.Forms.Label()
        Me.ing = New System.Windows.Forms.Label()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MouseCall.SuspendLayout()
        Me.SuspendLayout()
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(385, 10)
        Me.axHWPostil1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(867, 439)
        Me.axHWPostil1.TabIndex = 5
        '
        'yidengji
        '
        Me.yidengji.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.yidengji.ContextMenuStrip = Me.MouseCall
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yidengji.DefaultCellStyle = DataGridViewCellStyle3
        Me.yidengji.Location = New System.Drawing.Point(16, 12)
        Me.yidengji.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.yidengji.Name = "yidengji"
        Me.yidengji.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.yidengji.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.yidengji.Size = New System.Drawing.Size(489, 549)
        Me.yidengji.TabIndex = 137
        '
        'MouseCall
        '
        Me.MouseCall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打印COAToolStripMenuItem, Me.删除COAToolStripMenuItem, Me.退出ToolStripMenuItem, Me.另存为ToolStripMenuItem})
        Me.MouseCall.Name = "MouseCall"
        Me.MouseCall.Size = New System.Drawing.Size(127, 92)
        '
        '打印COAToolStripMenuItem
        '
        Me.打印COAToolStripMenuItem.Name = "打印COAToolStripMenuItem"
        Me.打印COAToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.打印COAToolStripMenuItem.Text = "打印COA"
        '
        '删除COAToolStripMenuItem
        '
        Me.删除COAToolStripMenuItem.Name = "删除COAToolStripMenuItem"
        Me.删除COAToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.删除COAToolStripMenuItem.Text = "删除COA"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.退出ToolStripMenuItem.Text = "刷新列表"
        '
        '另存为ToolStripMenuItem
        '
        Me.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem"
        Me.另存为ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.另存为ToolStripMenuItem.Text = "另存为"
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(-1, 548)
        Me.IDID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(24, 20)
        Me.IDID.TabIndex = 167
        Me.IDID.Text = "ID"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 100000
        '
        'Filename
        '
        Me.Filename.AutoSize = True
        Me.Filename.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Filename.Location = New System.Drawing.Point(39, 548)
        Me.Filename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Filename.Name = "Filename"
        Me.Filename.Size = New System.Drawing.Size(70, 20)
        Me.Filename.TabIndex = 168
        Me.Filename.Text = "Filename"
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ing.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ing.Location = New System.Drawing.Point(933, 258)
        Me.ing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ing.Name = "ing"
        Me.ing.Size = New System.Drawing.Size(234, 41)
        Me.ing.TabIndex = 173
        Me.ing.Text = "正在转换数据..."
        Me.ing.Visible = False
        '
        'COA_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 571)
        Me.Controls.Add(Me.ing)
        Me.Controls.Add(Me.Filename)
        Me.Controls.Add(Me.IDID)
        Me.Controls.Add(Me.yidengji)
        Me.Controls.Add(Me.axHWPostil1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "COA_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "库场单据打印"
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MouseCall.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Friend WithEvents MouseCall As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 删除COAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents 打印COAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Filename As System.Windows.Forms.Label
    Friend WithEvents ing As System.Windows.Forms.Label
    Friend WithEvents 另存为ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
