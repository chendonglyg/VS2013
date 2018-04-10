<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COA_4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COA_4))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripLabel()
        Me.YearSum = New System.Windows.Forms.ToolStripComboBox()
        Me.LABEL_BILL = New System.Windows.Forms.ToolStripButton()
        Me.FileName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDID = New System.Windows.Forms.Label()
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripSeparator10, Me.YearSum, Me.LABEL_BILL, Me.FileName, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 172
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
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Enabled = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripSeparator10.Text = "年度:"
        '
        'YearSum
        '
        Me.YearSum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearSum.Items.AddRange(New Object() {"2017", "2018", "2019", "2020"})
        Me.YearSum.Name = "YearSum"
        Me.YearSum.Size = New System.Drawing.Size(166, 25)
        '
        'LABEL_BILL
        '
        Me.LABEL_BILL.Enabled = False
        Me.LABEL_BILL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LABEL_BILL.Name = "LABEL_BILL"
        Me.LABEL_BILL.Size = New System.Drawing.Size(96, 22)
        Me.LABEL_BILL.Text = "文件名关键字："
        '
        'FileName
        '
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(200, 25)
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
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(363, 34)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(633, 521)
        Me.axHWPostil1.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(876, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Label1"
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(846, 11)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(24, 20)
        Me.IDID.TabIndex = 174
        Me.IDID.Text = "ID"
        '
        'yidengji
        '
        Me.yidengji.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yidengji.DefaultCellStyle = DataGridViewCellStyle3
        Me.yidengji.Location = New System.Drawing.Point(12, 34)
        Me.yidengji.Name = "yidengji"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.yidengji.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.yidengji.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.yidengji.Size = New System.Drawing.Size(345, 521)
        Me.yidengji.TabIndex = 173
        '
        'COA_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IDID)
        Me.Controls.Add(Me.yidengji)
        Me.Name = "COA_4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COA_4"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents YearSum As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LABEL_BILL As System.Windows.Forms.ToolStripButton
    Friend WithEvents FileName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
End Class
