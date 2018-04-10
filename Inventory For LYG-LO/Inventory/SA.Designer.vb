<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SA
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.sasa = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(28, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 26)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "确定(&O)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Location = New System.Drawing.Point(28, 76)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(144, 21)
        Me.PasswordTextBox.TabIndex = 59
        '
        'sasa
        '
        Me.sasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sasa.Location = New System.Drawing.Point(28, 39)
        Me.sasa.Name = "sasa"
        Me.sasa.Size = New System.Drawing.Size(144, 21)
        Me.sasa.TabIndex = 57
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(26, 57)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(146, 21)
        Me.PasswordLabel.TabIndex = 58
        Me.PasswordLabel.Text = "SQL连接密码"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(26, 20)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(146, 21)
        Me.UsernameLabel.TabIndex = 56
        Me.UsernameLabel.Text = "SQL连接账号:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 161)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.sasa)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "SA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL连接设置"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sasa As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
End Class
