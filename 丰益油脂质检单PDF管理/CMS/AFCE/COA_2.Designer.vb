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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COA_2))
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LABEL_BILL = New System.Windows.Forms.ToolStripButton()
        Me.TXT_PATH = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripLabel()
        Me.filename = New System.Windows.Forms.ToolStripTextBox()
        Me.BUT_START = New System.Windows.Forms.ToolStripButton()
        Me.删除记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打印单笔记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.LABEL_BILL, Me.TXT_PATH, Me.ToolStripSeparator10, Me.filename, Me.BUT_START, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.ToolStrip1.TabIndex = 135
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LABEL_BILL
        '
        Me.LABEL_BILL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LABEL_BILL.Name = "LABEL_BILL"
        Me.LABEL_BILL.Size = New System.Drawing.Size(82, 22)
        Me.LABEL_BILL.Text = "选择PDF提单"
        '
        'TXT_PATH
        '
        Me.TXT_PATH.Name = "TXT_PATH"
        Me.TXT_PATH.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripSeparator10.Text = "文件名"
        '
        'filename
        '
        Me.filename.Name = "filename"
        Me.filename.Size = New System.Drawing.Size(166, 25)
        '
        'BUT_START
        '
        Me.BUT_START.BackColor = System.Drawing.Color.Yellow
        Me.BUT_START.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BUT_START.Name = "BUT_START"
        Me.BUT_START.Size = New System.Drawing.Size(44, 22)
        Me.BUT_START.Text = "PUSH"
        '
        '删除记录ToolStripMenuItem
        '
        Me.删除记录ToolStripMenuItem.Name = "删除记录ToolStripMenuItem"
        Me.删除记录ToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        '
        '修改记录ToolStripMenuItem
        '
        Me.修改记录ToolStripMenuItem.Name = "修改记录ToolStripMenuItem"
        Me.修改记录ToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        '
        '打印单笔记录ToolStripMenuItem
        '
        Me.打印单笔记录ToolStripMenuItem.Name = "打印单笔记录ToolStripMenuItem"
        Me.打印单笔记录ToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打印单笔记录ToolStripMenuItem, Me.修改记录ToolStripMenuItem, Me.删除记录ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(69, 70)
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(12, 44)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(1240, 455)
        Me.axHWPostil1.TabIndex = 136
        '
        'COA_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 511)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "COA_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文件签章推送"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents 删除记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打印单笔记录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LABEL_BILL As System.Windows.Forms.ToolStripButton
    Friend WithEvents TXT_PATH As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BUT_START As System.Windows.Forms.ToolStripButton
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents filename As System.Windows.Forms.ToolStripTextBox
End Class
