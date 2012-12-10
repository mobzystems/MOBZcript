<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOBZcript
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
    Dim Label1 As System.Windows.Forms.Label
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.argumentsTextBox = New System.Windows.Forms.TextBox()
    Me.echoCheckButton = New System.Windows.Forms.CheckBox()
    Me.scriptTextBox = New System.Windows.Forms.TextBox()
    Me.mainMenu = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.openItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.saveItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.saveAsItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.exitItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mainStatusStrip = New System.Windows.Forms.StatusStrip()
    Me.versionLabel = New System.Windows.Forms.ToolStripStatusLabel()
    Label1 = New System.Windows.Forms.Label()
    Me.Panel1.SuspendLayout()
    Me.mainMenu.SuspendLayout()
    Me.mainStatusStrip.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Label1.AutoSize = True
    Label1.Location = New System.Drawing.Point(69, 13)
    Label1.Name = "Label1"
    Label1.Size = New System.Drawing.Size(60, 13)
    Label1.TabIndex = 3
    Label1.Text = "&Arguments:"
    '
    'Panel1
    '
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel1.Controls.Add(Me.argumentsTextBox)
    Me.Panel1.Controls.Add(Label1)
    Me.Panel1.Controls.Add(Me.echoCheckButton)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 24)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(926, 41)
    Me.Panel1.TabIndex = 1
    '
    'argumentsTextBox
    '
    Me.argumentsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.argumentsTextBox.Location = New System.Drawing.Point(135, 10)
    Me.argumentsTextBox.Name = "argumentsTextBox"
    Me.argumentsTextBox.Size = New System.Drawing.Size(775, 20)
    Me.argumentsTextBox.TabIndex = 4
    Me.argumentsTextBox.Text = "one two three"
    '
    'echoCheckButton
    '
    Me.echoCheckButton.AutoSize = True
    Me.echoCheckButton.Location = New System.Drawing.Point(12, 12)
    Me.echoCheckButton.Name = "echoCheckButton"
    Me.echoCheckButton.Size = New System.Drawing.Size(51, 17)
    Me.echoCheckButton.TabIndex = 2
    Me.echoCheckButton.Text = "Echo"
    Me.echoCheckButton.UseVisualStyleBackColor = True
    '
    'scriptTextBox
    '
    Me.scriptTextBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.scriptTextBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.scriptTextBox.Location = New System.Drawing.Point(0, 65)
    Me.scriptTextBox.Multiline = True
    Me.scriptTextBox.Name = "scriptTextBox"
    Me.scriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.scriptTextBox.Size = New System.Drawing.Size(926, 389)
    Me.scriptTextBox.TabIndex = 0
    Me.scriptTextBox.Text = "setlocal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo First=%1 Second=%2 Third=%3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exit /B 12"
    '
    'mainMenu
    '
    Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ScriptToolStripMenuItem})
    Me.mainMenu.Location = New System.Drawing.Point(0, 0)
    Me.mainMenu.Name = "mainMenu"
    Me.mainMenu.Size = New System.Drawing.Size(926, 24)
    Me.mainMenu.TabIndex = 2
    Me.mainMenu.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openItem, Me.saveItem, Me.saveAsItem, Me.ToolStripMenuItem1, Me.exitItem})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
    Me.FileToolStripMenuItem.Text = "&File"
    '
    'openItem
    '
    Me.openItem.Name = "openItem"
    Me.openItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
    Me.openItem.Size = New System.Drawing.Size(155, 22)
    Me.openItem.Text = "&Open..."
    '
    'saveItem
    '
    Me.saveItem.Name = "saveItem"
    Me.saveItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.saveItem.Size = New System.Drawing.Size(155, 22)
    Me.saveItem.Text = "&Save"
    '
    'saveAsItem
    '
    Me.saveAsItem.Name = "saveAsItem"
    Me.saveAsItem.Size = New System.Drawing.Size(155, 22)
    Me.saveAsItem.Text = "Save &as..."
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
    '
    'exitItem
    '
    Me.exitItem.Name = "exitItem"
    Me.exitItem.ShortcutKeyDisplayString = "Alt+F4"
    Me.exitItem.Size = New System.Drawing.Size(155, 22)
    Me.exitItem.Text = "E&xit"
    '
    'ScriptToolStripMenuItem
    '
    Me.ScriptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunToolStripMenuItem})
    Me.ScriptToolStripMenuItem.Name = "ScriptToolStripMenuItem"
    Me.ScriptToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
    Me.ScriptToolStripMenuItem.Text = "&Script"
    '
    'RunToolStripMenuItem
    '
    Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
    Me.RunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
    Me.RunToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
    Me.RunToolStripMenuItem.Text = "&Run"
    '
    'mainStatusStrip
    '
    Me.mainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.versionLabel})
    Me.mainStatusStrip.Location = New System.Drawing.Point(0, 454)
    Me.mainStatusStrip.Name = "mainStatusStrip"
    Me.mainStatusStrip.Size = New System.Drawing.Size(926, 22)
    Me.mainStatusStrip.TabIndex = 3
    '
    'versionLabel
    '
    Me.versionLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.versionLabel.IsLink = True
    Me.versionLabel.Name = "versionLabel"
    Me.versionLabel.Size = New System.Drawing.Size(880, 17)
    Me.versionLabel.Spring = True
    Me.versionLabel.Text = "MOBZcript v# by MOBZystems"
    Me.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'MOBZcript
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(926, 476)
    Me.Controls.Add(Me.scriptTextBox)
    Me.Controls.Add(Me.mainStatusStrip)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.mainMenu)
    Me.MainMenuStrip = Me.mainMenu
    Me.Name = "MOBZcript"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
    Me.Text = "MOBZcript Cmd Script Editor"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.mainMenu.ResumeLayout(False)
    Me.mainMenu.PerformLayout()
    Me.mainStatusStrip.ResumeLayout(False)
    Me.mainStatusStrip.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents argumentsTextBox As System.Windows.Forms.TextBox
  Friend WithEvents echoCheckButton As System.Windows.Forms.CheckBox
  Friend WithEvents scriptTextBox As System.Windows.Forms.TextBox
  Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents openItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents saveItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents saveAsItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents exitItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mainStatusStrip As System.Windows.Forms.StatusStrip
  Friend WithEvents versionLabel As System.Windows.Forms.ToolStripStatusLabel

End Class
