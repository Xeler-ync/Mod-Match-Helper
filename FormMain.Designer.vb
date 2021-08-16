<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CheckedListBoxSelectMods = New System.Windows.Forms.CheckedListBox()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.LabelModInfo = New System.Windows.Forms.Label()
        Me.ButtonTest1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBoxSelectMods
        '
        Me.CheckedListBoxSelectMods.ColumnWidth = 2
        Me.CheckedListBoxSelectMods.FormattingEnabled = True
        Me.CheckedListBoxSelectMods.Location = New System.Drawing.Point(12, 12)
        Me.CheckedListBoxSelectMods.Name = "CheckedListBoxSelectMods"
        Me.CheckedListBoxSelectMods.Size = New System.Drawing.Size(497, 324)
        Me.CheckedListBoxSelectMods.TabIndex = 0
        '
        'ButtonTest
        '
        Me.ButtonTest.Location = New System.Drawing.Point(12, 342)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(85, 79)
        Me.ButtonTest.TabIndex = 1
        Me.ButtonTest.Text = "Button1"
        Me.ButtonTest.UseVisualStyleBackColor = True
        '
        'LabelModInfo
        '
        Me.LabelModInfo.Location = New System.Drawing.Point(542, 58)
        Me.LabelModInfo.Name = "LabelModInfo"
        Me.LabelModInfo.Size = New System.Drawing.Size(213, 164)
        Me.LabelModInfo.TabIndex = 2
        Me.LabelModInfo.Text = "Label1"
        '
        'ButtonTest1
        '
        Me.ButtonTest1.Location = New System.Drawing.Point(331, 368)
        Me.ButtonTest1.Name = "ButtonTest1"
        Me.ButtonTest1.Size = New System.Drawing.Size(120, 44)
        Me.ButtonTest1.TabIndex = 3
        Me.ButtonTest1.Text = "Button1"
        Me.ButtonTest1.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonTest1)
        Me.Controls.Add(Me.LabelModInfo)
        Me.Controls.Add(Me.ButtonTest)
        Me.Controls.Add(Me.CheckedListBoxSelectMods)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBoxSelectMods As CheckedListBox
    Friend WithEvents ButtonTest As Button
    Friend WithEvents LabelModInfo As Label
    Friend WithEvents ButtonTest1 As Button
End Class
