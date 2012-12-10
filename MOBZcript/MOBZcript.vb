Option Strict On
Option Explicit On

Imports System.IO

Public Class MOBZcript
  Const TEMPFILENAME As String = "_MOBZcript.cmd"
  Const TITLEFORMAT As String = "{0} - MOBZcript"
  Protected _filename As String
  Protected _workingDirectory As String
  Protected _scriptDirectory As String
  Protected _originalScript As String = Nothing

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    Me._workingDirectory = Path.GetTempPath()
    Me._scriptDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    Me._filename = Path.Combine(Path.GetTempPath(), "untitled-1.cmd")
    If File.Exists(Me._filename) Then
      LoadFile(Me._filename)
    End If
    SetTitle(Me._filename)

    Me.versionLabel.Text = Me.versionLabel.Text.Replace("#", My.Application.Info.Version.ToString(3) + " (" + CStr(IntPtr.Size * 8) + "-bit)")
  End Sub

  Protected Sub SetTitle(title As String)
    Me.Text = String.Format(TITLEFORMAT, title)
  End Sub

  Protected Sub LoadFile(filename As String)
    Me.scriptTextBox.Text = File.ReadAllText(filename)
    Me.scriptTextBox.Select(0, 0)
    SampleScript()
  End Sub

  Protected Sub SampleScript()
    Me._originalScript = "*" + Me.scriptTextBox.Text
  End Sub

  Protected Function ScriptHasChanged() As Boolean
    Return Me._originalScript.Substring(1) <> Me.scriptTextBox.Text
  End Function

  'Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
  '  If keyData = Keys.F5 Then
  '    Me.runButton.PerformClick()
  '    Return True
  '  End If
  '  Return MyBase.ProcessCmdKey(msg, keyData)
  'End Function

  Private Sub runButton_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
    ' Save the script
    File.WriteAllText(Me._filename, Me.scriptTextBox.Text)

    ' Create a temporary script to run the source script
    Dim tempPathName As String = Path.Combine(Me._workingDirectory, TEMPFILENAME)
    Dim driveName As String = Path.GetPathRoot(Me._filename)
    If driveName.StartsWith("\\") Then
      MessageBox.Show(
        "This script is located on a UNC path (" + driveName + "). It cant be run from there." + Environment.NewLine +
        Environment.NewLine +
        "Save it in another location and try again.",
        "Script cannot be run",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error
      )
      Return
    End If

    If driveName.EndsWith(Path.DirectorySeparatorChar) Then
      driveName = driveName.Substring(0, driveName.Length - 1)
    End If

    Dim tempScript As String = String.Format(
      "@echo --- Starting script..." + Environment.NewLine +
      "@echo {2}" + Environment.NewLine +
      "{4}" + Environment.NewLine +
      "@cd {3}" + Environment.NewLine +
      "@call ""{0}"" {1}" + Environment.NewLine +
      "@echo --- Script returned %ERRORLEVEL%" + Environment.NewLine,
      Me._filename,
      Me.argumentsTextBox.Text,
      If(Me.echoCheckButton.Checked, "on", "off"),
      Path.GetDirectoryName(Me._filename),
      driveName
    )
    File.WriteAllText(tempPathName, tempScript)
    Dim args As String = String.Format("/c (cmd /c ""{0}"")&pause", tempPathName)
    Dim p As Process = Process.Start("cmd.exe", args)
  End Sub

  Private Sub echoCheckButton_CheckedChanged(sender As Object, e As EventArgs) Handles echoCheckButton.Click
    Me.echoCheckButton.Text = "Echo " + If(Me.echoCheckButton.Checked, "ON", "OFF")
  End Sub

  Private Sub saveAsButton_Click(sender As Object, e As EventArgs) Handles saveAsItem.Click
    Using f As New SaveFileDialog
      f.AddExtension = True
      f.DefaultExt = ".cmd"
      f.OverwritePrompt = True
      f.InitialDirectory = Me._scriptDirectory
      If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        Try
          File.WriteAllText(f.FileName, Me.scriptTextBox.Text)
          Me._filename = f.FileName
          Me._scriptDirectory = Path.GetDirectoryName(f.FileName)
          SetTitle(Me._filename)
          SampleScript()
        Catch ex As Exception
          MessageBox.Show("The file could not be saved: " + ex.Message, "Error saving file")
        End Try
      End If
    End Using
  End Sub

  Private Sub openItem_Click(sender As Object, e As EventArgs) Handles openItem.Click
    Using F As New OpenFileDialog
      F.DefaultExt = ".cmd"
      F.Filter = "Command files (*.cmd, *.bat)|*.cmd;*.bat|All files|*.*"
      F.InitialDirectory = Me._scriptDirectory
      If F.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        If Me.ScriptHasChanged() Then
          If MessageBox.Show(
            "Current script has unsaved changes - discard?",
            "Unsaved changes",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2
          ) = Windows.Forms.DialogResult.Cancel Then
            Return
          End If
        End If
        Try
          LoadFile(F.FileName)
          Me._filename = F.FileName
          Me._scriptDirectory = Path.GetDirectoryName(F.FileName)
          SetTitle(Me._filename)
        Catch ex As Exception
          MessageBox.Show("The file could not be opened: " + ex.Message, "Error opening file")
        End Try
      End If
    End Using
  End Sub

  Private Sub saveItem_Click(sender As Object, e As EventArgs) Handles saveItem.Click
    Try
      File.WriteAllText(Me._filename, Me.scriptTextBox.Text)
      SampleScript()
    Catch ex As Exception
      MessageBox.Show("The file could not be saved: " + ex.Message, "Error saving file")
    End Try
  End Sub

  Private Sub exitItem_Click(sender As Object, e As EventArgs) Handles exitItem.Click
    If Me.ScriptHasChanged() Then
      If MessageBox.Show(
        "Current script has unsaved changes - exit anyway?",
        "Unsaved changes",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button2
      ) = Windows.Forms.DialogResult.Cancel Then
        Return
      End If
    End If
    Me.Close()
  End Sub

  Private Sub versionLabel_Click(sender As Object, e As EventArgs) Handles versionLabel.Click
    Process.Start("http://www.mobzystems.com/Tools/MOBZscript")
  End Sub
End Class
