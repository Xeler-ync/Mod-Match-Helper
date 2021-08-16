<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoEdit
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
        Me.ListBoxListMod = New System.Windows.Forms.ListBox()
        Me.TextBoxInfoInput = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelModInfo = New System.Windows.Forms.Label()
        Me.LabelRely = New System.Windows.Forms.Label()
        Me.ButtonReloadModList = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxListMod
        '
        Me.ListBoxListMod.FormattingEnabled = True
        Me.ListBoxListMod.ItemHeight = 12
        Me.ListBoxListMod.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxListMod.Name = "ListBoxListMod"
        Me.ListBoxListMod.Size = New System.Drawing.Size(349, 424)
        Me.ListBoxListMod.TabIndex = 0
        '
        'TextBoxInfoInput
        '
        Me.TextBoxInfoInput.Enabled = False
        Me.TextBoxInfoInput.Location = New System.Drawing.Point(444, 347)
        Me.TextBoxInfoInput.Multiline = True
        Me.TextBoxInfoInput.Name = "TextBoxInfoInput"
        Me.TextBoxInfoInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBoxInfoInput.Size = New System.Drawing.Size(228, 42)
        Me.TextBoxInfoInput.TabIndex = 1
        Me.TextBoxInfoInput.Text = "Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rely" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(367, 350)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(29, 12)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Name"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(367, 362)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(71, 12)
        Me.LabelDescription.TabIndex = 3
        Me.LabelDescription.Text = "Description"
        '
        'LabelModInfo
        '
        Me.LabelModInfo.Location = New System.Drawing.Point(367, 12)
        Me.LabelModInfo.Name = "LabelModInfo"
        Me.LabelModInfo.Size = New System.Drawing.Size(305, 322)
        Me.LabelModInfo.TabIndex = 4
        Me.LabelModInfo.Text = "Label1"
        '
        'LabelRely
        '
        Me.LabelRely.AutoSize = True
        Me.LabelRely.Location = New System.Drawing.Point(367, 374)
        Me.LabelRely.Name = "LabelRely"
        Me.LabelRely.Size = New System.Drawing.Size(29, 12)
        Me.LabelRely.TabIndex = 5
        Me.LabelRely.Text = "Rely"
        '
        'ButtonReloadModList
        '
        Me.ButtonReloadModList.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.ButtonReloadModList.Location = New System.Drawing.Point(367, 395)
        Me.ButtonReloadModList.Name = "ButtonReloadModList"
        Me.ButtonReloadModList.Size = New System.Drawing.Size(148, 43)
        Me.ButtonReloadModList.TabIndex = 6
        Me.ButtonReloadModList.Text = "ReloadModList"
        Me.ButtonReloadModList.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.ButtonReset.Location = New System.Drawing.Point(521, 395)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(151, 43)
        Me.ButtonReset.TabIndex = 7
        Me.ButtonReset.Text = "ResetAll"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'FormInfoEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonReloadModList)
        Me.Controls.Add(Me.LabelRely)
        Me.Controls.Add(Me.LabelModInfo)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TextBoxInfoInput)
        Me.Controls.Add(Me.ListBoxListMod)
        Me.Name = "FormInfoEdit"
        Me.Text = "FormInfoEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxListMod As ListBox
    Friend WithEvents TextBoxInfoInput As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelModInfo As Label
    Friend WithEvents LabelRely As Label
    Friend WithEvents ButtonReloadModList As Button
    Friend WithEvents ButtonReset As Button
End Class
