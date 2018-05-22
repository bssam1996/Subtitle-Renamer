Imports System.IO
Public Class Main
    Dim vnumber As Integer = 0
    Dim subnumber As Integer = 0
    Dim bigger As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            adding(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
    Public Sub adding(path As String)
        Try
            ListView1.Items.Clear()
            subnumber = 0
            vnumber = 0
            Label1.Text = path
            If Label1.Text.Count = 3 Then
                Label1.Text = path
            Else
                Label1.Text = path + "\"
            End If
            Dim extensions As String = ""
            For Each checking As CheckBox In GroupBox1.Controls
                If checking.Checked = True Then
                    extensions = extensions + checking.Text + " "
                End If
            Next
            Dim di As New IO.DirectoryInfo(path)
            Dim diar As IO.FileInfo() = di.GetFiles("*.*") 'All files
            Dim dra As IO.FileInfo
            Dim q = 1 'for # row
            'Dim dotPosition As Integer
            For Each dra In diar
                If extensions.Contains(dra.Extension.ToUpper) Then
                    ListView1.Items.Add(q.ToString)
                    'dotPosition = dra.ToString.LastIndexOf(".")
                    'extOnly = dra.ToString.Substring(dotPosition + 1)
                    ListView1.Items(q - 1).SubItems.Add(IO.Path.GetFileNameWithoutExtension(path + "\" + dra.ToString))
                    ListView1.Items(q - 1).SubItems.Add(dra.Extension)
                    q += 1
                End If
            Next
            vnumber = ListView1.Items.Count
            extensions = ""
            For Each checking As CheckBox In GroupBox2.Controls
                If checking.Checked = True Then
                    extensions = extensions + checking.Text + " "
                End If
            Next
            diar = di.GetFiles("*.*") 'All files
            For Each dra In diar
                If extensions.Contains(dra.Extension.ToUpper) Then
                    subnumber += 1
                End If
            Next
            If subnumber > ListView1.Items.Count Then
                For k = 1 To diar.Count - ListView1.Items.Count
                    ListView1.Items.Add(q.ToString)
                    ListView1.Items(q - 1).SubItems.Add("")
                    ListView1.Items(q - 1).SubItems.Add("")
                    q += 1
                Next
            End If
            If vnumber > subnumber Then
                bigger = subnumber
            Else
                bigger = vnumber
            End If
            Dim i As Integer = 0
            For Each dra In diar
                If extensions.Contains(dra.Extension.ToUpper) Then
                    ListView1.Items(i).SubItems.Add(IO.Path.GetFileNameWithoutExtension(path + "\" + dra.ToString))
                    ListView1.Items(i).SubItems.Add(dra.Extension)
                    i += 1
                End If
            Next
            If automaticfillingcheckbox.Checked = True Then
                fillascending.Enabled = False
                ResetFillingToolStripMenuItem.Enabled = True
                plus.Enabled = True
                minus.Enabled = True
                apply.Enabled = True
                For k = 0 To subnumber - 1
                    If k > vnumber Then
                        ListView1.Items(k).SubItems.Add("0")
                    Else
                        ListView1.Items(k).SubItems.Add((k + 1).ToString)
                    End If
                Next
            Else
                apply.Enabled = False
                plus.Enabled = False
                minus.Enabled = False
                ResetFillingToolStripMenuItem.Enabled = False
                fillascending.Enabled = True
            End If
            Label2.Text = "Total Video Files : " & vnumber & vbNewLine & "Total Subtitle files : " & subnumber
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DeleteThisItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisItemToolStripMenuItem.Click
        Try
            For Each i As ListViewItem In ListView1.SelectedItems
                If ListView1.SelectedItems(0).Text <> "" Then
                    vnumber -= 1
                End If
                If ListView1.SelectedItems(0).SubItems(1).Text <> "" Then
                    subnumber -= 1
                End If
                ListView1.Items.Remove(i)
            Next
            Label2.Text = "Total Video Files : " & vnumber & vbNewLine & "Total Subtitle files : " & subnumber
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            ListView1.Items.Clear()
            Label2.Text = "Total Video Files : 0" & vbNewLine & "Total Subtitle files : 0"
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DetailsDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsDefaultToolStripMenuItem.Click
        ListView1.View = View.Details
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        ListView1.View = View.List
    End Sub

    Private Sub TilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesToolStripMenuItem.Click
        ListView1.View = View.Tile
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                If Directory.Exists(filePaths(0)) Then
                    adding(filePaths(0))
                End If
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If Directory.Exists(filePaths(0)) Then
                e.Effect = DragDropEffects.Copy
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ResetFillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetFillingToolStripMenuItem.Click
        Try
            fillascending.Enabled = False
            plus.Enabled = True
            minus.Enabled = True
            apply.Enabled = True

            For k = 0 To subnumber - 1
                If k > vnumber Then
                    ListView1.Items(k).SubItems(5).Text = "0"
                Else
                    ListView1.Items(k).SubItems(5).Text = k + 1
                End If
            Next
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub fillascending_Click(sender As Object, e As EventArgs) Handles fillascending.Click
        Try
            fillascending.Enabled = False
            ResetFillingToolStripMenuItem.Enabled = True
            plus.Enabled = True
            minus.Enabled = True
            apply.Enabled = True
            For k = 0 To subnumber - 1
                If k > vnumber Then
                    ListView1.Items(k).SubItems.Add("0")
                Else
                    ListView1.Items(k).SubItems.Add((k + 1).ToString)
                End If
            Next
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                If ListView1.SelectedItems(0).SubItems(5).Text < vnumber Then
                    ListView1.SelectedItems(0).SubItems(5).Text += 1
                End If
            End If
            ListView1.Focus()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                If ListView1.SelectedItems(0).SubItems(5).Text > 1 Then
                    ListView1.SelectedItems(0).SubItems(5).Text -= 1
                End If
            End If
            ListView1.Focus()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub apply_Click(sender As Object, e As EventArgs) Handles apply.Click
        Try
            For k = 0 To subnumber - 2
                For i = k + 1 To subnumber - 1
                    If ListView1.Items(k).SubItems(3).Text = ListView1.Items(i).SubItems(3).Text And ListView1.Items(k).SubItems(4).Text = ListView1.Items(i).SubItems(4).Text Then
                        MsgBox("There is a repeated subtitle name in row " + ListView1.Items(k).Text + " With row " + ListView1.Items(i).Text)
                        Exit Sub
                    End If
                Next
            Next
            For k = 0 To subnumber - 1
                Dim num As Integer = Val(ListView1.Items(k).SubItems(5).Text)
                Dim fullsub As String = ListView1.Items(k).SubItems(3).Text + ListView1.Items(k).SubItems(4).Text
                Dim movname As String = ListView1.Items(num - 1).SubItems(1).Text

                If My.Computer.FileSystem.FileExists(Label1.Text + movname + ListView1.Items(k).SubItems(4).Text) = False And ListView1.Items(k).SubItems(5).Text <> "0" Then
                    My.Computer.FileSystem.RenameFile(Label1.Text + fullsub, movname + ListView1.Items(k).SubItems(4).Text)
                End If
            Next
            MsgBox("Done!", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CheckUncheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckUncheckToolStripMenuItem.Click
        If FilterContextMenuStrip.SourceControl Is GroupBox1 Then
            Dim checkstateselection As Boolean = True 'select all
            For Each checking As CheckBox In GroupBox1.Controls
                If checking.Checked = True Then
                    checkstateselection = False
                End If
            Next
            If checkstateselection = True Then
                For Each checking As CheckBox In GroupBox1.Controls
                    checking.Checked = True
                Next
            Else
                For Each checking As CheckBox In GroupBox1.Controls
                    checking.Checked = False
                Next
            End If
        ElseIf FilterContextMenuStrip.SourceControl Is GroupBox2 Then
            Dim checkstateselection As Boolean = True 'select all
            For Each checking As CheckBox In GroupBox2.Controls
                If checking.Checked = True Then
                    checkstateselection = False
                End If
            Next
            If checkstateselection = True Then
                For Each checking As CheckBox In GroupBox2.Controls
                    checking.Checked = True
                Next
            Else
                For Each checking As CheckBox In GroupBox2.Controls
                    checking.Checked = False
                Next
            End If
        End If
    End Sub

    Private Sub ExcludeInChangingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcludeInChangingToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                For i = 0 To ListView1.SelectedItems.Count - 1
                    ListView1.SelectedItems(i).SubItems(5).Text = "0"
                Next
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        If AlwaysOnTopToolStripMenuItem.Checked = True Then
            AlwaysOnTopToolStripMenuItem.Checked = False
            Me.TopMost = False
        Else
            AlwaysOnTopToolStripMenuItem.Checked = True
            Me.TopMost = True
        End If
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Add Then
            If plus.Enabled = True Then
                Try
                    If ListView1.SelectedItems.Count > 0 Then
                        For i = 0 To ListView1.SelectedItems.Count - 1
                            If ListView1.SelectedItems(i).SubItems(5).Text < vnumber Then
                                ListView1.SelectedItems(i).SubItems(5).Text += 1
                            End If
                        Next
                    End If
                    '   ListView1.Focus()
                Catch ex As Exception
                    MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
        If e.KeyCode = Keys.Subtract Then
            Try
                If ListView1.SelectedItems.Count > 0 Then
                    For i = 0 To ListView1.SelectedItems.Count - 1
                        If ListView1.SelectedItems(i).SubItems(5).Text > 1 Then
                            ListView1.SelectedItems(i).SubItems(5).Text -= 1
                        End If
                    Next
                End If
                ' ListView1.Focus()
            Catch ex As Exception
                MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Try
            If My.Computer.Network.IsAvailable Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/bssam1996/Subtitle-Renamer/master/Version")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim modnewestversion As String = newestversion.Replace(".", "")
                Dim currentversion As String = Application.ProductVersion
                currentversion = currentversion.Replace(".", "")
                If Integer.Parse(modnewestversion) <= Integer.Parse(currentversion) Then
                    MsgBox("You are up to date!", MsgBoxStyle.Information, "Version is up to date")
                Else
                    If MsgBox("Update Found Version : " + newestversion + vbNewLine + "Would you like to update now?", vbInformation + vbYesNo) = MsgBoxResult.Yes Then
                        updateform.ShowDialog()
                    End If
                End If
            Else
                MsgBox("Please Check your network!", MsgBoxStyle.Critical, "Network Unavailable")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
            Me.Text = "Subtitle-Renamer V" + Application.ProductVersion
            If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Subtitle-Renamer") Is Nothing Then
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\", True).CreateSubKey("Subtitle-Renamer")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "", """" & Application.ExecutablePath & """")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "Path", """" & Application.StartupPath & """")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "ulevel", "3")
            Else
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "ulevel", "").ToString = "1" Then
                    System.Threading.Thread.Sleep(2000)
                    Dim location As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "", Nothing).ToString
                    location = location.Replace(Chr(34), "")
                    My.Computer.FileSystem.CopyFile(Application.ExecutablePath, location, True)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "ulevel", "2")
                    Process.Start(location)
                    End
                ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "ulevel", "").ToString = "2" Then
                    System.Threading.Thread.Sleep(2000)
                    System.IO.Directory.Delete(Application.StartupPath + "\update", True)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "ulevel", "3")
                Else
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "", """" & Application.ExecutablePath & """")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "Path", """" & Application.StartupPath & """")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Subtitle-Renamer", "ulevel", "3")
                End If
            End If
        Catch
        End Try

    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    System.Threading.Thread.Sleep(2000)
    '    MsgBox(System.Diagnostics.Process.GetCurrentProcess.MainWindowTitle)
    'End Sub
End Class
